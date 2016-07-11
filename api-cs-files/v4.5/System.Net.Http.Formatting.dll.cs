namespace Newtonsoft.Json {
  public enum ConstructorHandling {
    AllowNonPublicDefaultConstructor = 1,
    Default = 0,
  }
  public enum DateFormatHandling {
    IsoDateFormat = 0,
    MicrosoftDateFormat = 1,
  }
  public enum DateTimeZoneHandling {
    Local = 0,
    RoundtripKind = 3,
    Unspecified = 2,
    Utc = 1,
  }
  [System.FlagsAttribute]
  public enum DefaultValueHandling {
    Ignore = 1,
    IgnoreAndPopulate = 3,
    Include = 0,
    Populate = 2,
  }
  public enum Formatting {
    Indented = 1,
    None = 0,
  }
  public partial interface IJsonLineInfo {
    int LineNumber { get; }
    int LinePosition { get; }
    bool HasLineInfo();
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(1028), AllowMultiple=false)]
  public sealed partial class JsonArrayAttribute : Newtonsoft.Json.JsonContainerAttribute {
    public JsonArrayAttribute() { }
    public JsonArrayAttribute(bool allowNullItems) { }
    public JsonArrayAttribute(string id) { }
    public bool AllowNullItems { get { return default(bool); } set { } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(32), AllowMultiple=false)]
  public sealed partial class JsonConstructorAttribute : System.Attribute {
    public JsonConstructorAttribute() { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(1028), AllowMultiple=false)]
  public abstract partial class JsonContainerAttribute : System.Attribute {
    protected JsonContainerAttribute() { }
    protected JsonContainerAttribute(string id) { }
    public string Description { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Id { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool IsReference { get { return default(bool); } set { } }
    public string Title { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public static partial class JsonConvert {
    public static readonly string False;
    public static readonly string NaN;
    public static readonly string NegativeInfinity;
    public static readonly string Null;
    public static readonly string PositiveInfinity;
    public static readonly string True;
    public static readonly string Undefined;
    public static T DeserializeAnonymousType<T>(string value, T anonymousTypeObject) { return default(T); }
    public static object DeserializeObject(string value) { return default(object); }
    public static object DeserializeObject(string value, Newtonsoft.Json.JsonSerializerSettings settings) { return default(object); }
    public static object DeserializeObject(string value, System.Type type) { return default(object); }
    public static object DeserializeObject(string value, System.Type type, params Newtonsoft.Json.JsonConverter[] converters) { return default(object); }
    public static object DeserializeObject(string value, System.Type type, Newtonsoft.Json.JsonSerializerSettings settings) { return default(object); }
    public static T DeserializeObject<T>(string value) { return default(T); }
    public static T DeserializeObject<T>(string value, params Newtonsoft.Json.JsonConverter[] converters) { return default(T); }
    public static T DeserializeObject<T>(string value, Newtonsoft.Json.JsonSerializerSettings settings) { return default(T); }
    public static System.Threading.Tasks.Task<System.Object> DeserializeObjectAsync(string value) { return default(System.Threading.Tasks.Task<System.Object>); }
    public static System.Threading.Tasks.Task<System.Object> DeserializeObjectAsync(string value, System.Type type, Newtonsoft.Json.JsonSerializerSettings settings) { return default(System.Threading.Tasks.Task<System.Object>); }
    public static System.Threading.Tasks.Task<T> DeserializeObjectAsync<T>(string value) { return default(System.Threading.Tasks.Task<T>); }
    public static System.Threading.Tasks.Task<T> DeserializeObjectAsync<T>(string value, Newtonsoft.Json.JsonSerializerSettings settings) { return default(System.Threading.Tasks.Task<T>); }
    public static System.Xml.XmlDocument DeserializeXmlNode(string value) { return default(System.Xml.XmlDocument); }
    public static System.Xml.XmlDocument DeserializeXmlNode(string value, string deserializeRootElementName) { return default(System.Xml.XmlDocument); }
    public static System.Xml.XmlDocument DeserializeXmlNode(string value, string deserializeRootElementName, bool writeArrayAttribute) { return default(System.Xml.XmlDocument); }
    public static System.Xml.Linq.XDocument DeserializeXNode(string value) { return default(System.Xml.Linq.XDocument); }
    public static System.Xml.Linq.XDocument DeserializeXNode(string value, string deserializeRootElementName) { return default(System.Xml.Linq.XDocument); }
    public static System.Xml.Linq.XDocument DeserializeXNode(string value, string deserializeRootElementName, bool writeArrayAttribute) { return default(System.Xml.Linq.XDocument); }
    public static void PopulateObject(string value, object target) { }
    public static void PopulateObject(string value, object target, Newtonsoft.Json.JsonSerializerSettings settings) { }
    public static System.Threading.Tasks.Task PopulateObjectAsync(string value, object target, Newtonsoft.Json.JsonSerializerSettings settings) { return default(System.Threading.Tasks.Task); }
    public static string SerializeObject(object value) { return default(string); }
    public static string SerializeObject(object value, Newtonsoft.Json.Formatting formatting) { return default(string); }
    public static string SerializeObject(object value, Newtonsoft.Json.Formatting formatting, params Newtonsoft.Json.JsonConverter[] converters) { return default(string); }
    public static string SerializeObject(object value, Newtonsoft.Json.Formatting formatting, Newtonsoft.Json.JsonSerializerSettings settings) { return default(string); }
    public static string SerializeObject(object value, params Newtonsoft.Json.JsonConverter[] converters) { return default(string); }
    public static string SerializeObject(object value, Newtonsoft.Json.JsonSerializerSettings settings) { return default(string); }
    public static System.Threading.Tasks.Task<System.String> SerializeObjectAsync(object value) { return default(System.Threading.Tasks.Task<System.String>); }
    public static System.Threading.Tasks.Task<System.String> SerializeObjectAsync(object value, Newtonsoft.Json.Formatting formatting) { return default(System.Threading.Tasks.Task<System.String>); }
    public static System.Threading.Tasks.Task<System.String> SerializeObjectAsync(object value, Newtonsoft.Json.Formatting formatting, Newtonsoft.Json.JsonSerializerSettings settings) { return default(System.Threading.Tasks.Task<System.String>); }
    public static string SerializeXmlNode(System.Xml.XmlNode node) { return default(string); }
    public static string SerializeXmlNode(System.Xml.XmlNode node, Newtonsoft.Json.Formatting formatting) { return default(string); }
    public static string SerializeXmlNode(System.Xml.XmlNode node, Newtonsoft.Json.Formatting formatting, bool omitRootObject) { return default(string); }
    public static string SerializeXNode(System.Xml.Linq.XObject node) { return default(string); }
    public static string SerializeXNode(System.Xml.Linq.XObject node, Newtonsoft.Json.Formatting formatting) { return default(string); }
    public static string SerializeXNode(System.Xml.Linq.XObject node, Newtonsoft.Json.Formatting formatting, bool omitRootObject) { return default(string); }
    public static string ToString(bool value) { return default(string); }
    public static string ToString(byte value) { return default(string); }
    public static string ToString(char value) { return default(string); }
    public static string ToString(System.DateTime value) { return default(string); }
    public static string ToString(System.DateTime value, Newtonsoft.Json.DateFormatHandling format, Newtonsoft.Json.DateTimeZoneHandling timeZoneHandling) { return default(string); }
    public static string ToString(System.DateTimeOffset value) { return default(string); }
    public static string ToString(System.DateTimeOffset value, Newtonsoft.Json.DateFormatHandling format) { return default(string); }
    public static string ToString(decimal value) { return default(string); }
    public static string ToString(double value) { return default(string); }
    public static string ToString(System.Enum value) { return default(string); }
    public static string ToString(System.Guid value) { return default(string); }
    public static string ToString(short value) { return default(string); }
    public static string ToString(int value) { return default(string); }
    public static string ToString(long value) { return default(string); }
    public static string ToString(object value) { return default(string); }
    [System.CLSCompliantAttribute(false)]
    public static string ToString(sbyte value) { return default(string); }
    public static string ToString(float value) { return default(string); }
    public static string ToString(string value) { return default(string); }
    public static string ToString(string value, char delimter) { return default(string); }
    public static string ToString(System.TimeSpan value) { return default(string); }
    [System.CLSCompliantAttribute(false)]
    public static string ToString(ushort value) { return default(string); }
    [System.CLSCompliantAttribute(false)]
    public static string ToString(uint value) { return default(string); }
    [System.CLSCompliantAttribute(false)]
    public static string ToString(ulong value) { return default(string); }
    public static string ToString(System.Uri value) { return default(string); }
  }
  public abstract partial class JsonConverter {
    protected JsonConverter() { }
    public virtual bool CanRead { get { return default(bool); } }
    public virtual bool CanWrite { get { return default(bool); } }
    public abstract bool CanConvert(System.Type objectType);
    public virtual Newtonsoft.Json.Schema.JsonSchema GetSchema() { return default(Newtonsoft.Json.Schema.JsonSchema); }
    public abstract object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
    public abstract void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(3484), AllowMultiple=false)]
  public sealed partial class JsonConverterAttribute : System.Attribute {
    public JsonConverterAttribute(System.Type converterType) { }
    public System.Type ConverterType { get { return default(System.Type); } }
  }
  public partial class JsonConverterCollection : System.Collections.ObjectModel.Collection<Newtonsoft.Json.JsonConverter> {
    public JsonConverterCollection() { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=false)]
  public sealed partial class JsonIgnoreAttribute : System.Attribute {
    public JsonIgnoreAttribute() { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(1036), AllowMultiple=false)]
  public sealed partial class JsonObjectAttribute : Newtonsoft.Json.JsonContainerAttribute {
    public JsonObjectAttribute() { }
    public JsonObjectAttribute(Newtonsoft.Json.MemberSerialization memberSerialization) { }
    public JsonObjectAttribute(string id) { }
    public Newtonsoft.Json.MemberSerialization MemberSerialization { get { return default(Newtonsoft.Json.MemberSerialization); } set { } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(2432), AllowMultiple=false)]
  public sealed partial class JsonPropertyAttribute : System.Attribute {
    public JsonPropertyAttribute() { }
    public JsonPropertyAttribute(string propertyName) { }
    public Newtonsoft.Json.DefaultValueHandling DefaultValueHandling { get { return default(Newtonsoft.Json.DefaultValueHandling); } set { } }
    public bool IsReference { get { return default(bool); } set { } }
    public Newtonsoft.Json.NullValueHandling NullValueHandling { get { return default(Newtonsoft.Json.NullValueHandling); } set { } }
    public Newtonsoft.Json.ObjectCreationHandling ObjectCreationHandling { get { return default(Newtonsoft.Json.ObjectCreationHandling); } set { } }
    public int Order { get { return default(int); } set { } }
    public string PropertyName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Newtonsoft.Json.ReferenceLoopHandling ReferenceLoopHandling { get { return default(Newtonsoft.Json.ReferenceLoopHandling); } set { } }
    public Newtonsoft.Json.Required Required { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Newtonsoft.Json.Required); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Newtonsoft.Json.TypeNameHandling TypeNameHandling { get { return default(Newtonsoft.Json.TypeNameHandling); } set { } }
  }
  public abstract partial class JsonReader : System.IDisposable {
    protected JsonReader() { }
    public bool CloseInput { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Globalization.CultureInfo Culture { get { return default(System.Globalization.CultureInfo); } set { } }
    protected Newtonsoft.Json.JsonReader.State CurrentState { get { return default(Newtonsoft.Json.JsonReader.State); } }
    public Newtonsoft.Json.DateTimeZoneHandling DateTimeZoneHandling { get { return default(Newtonsoft.Json.DateTimeZoneHandling); } set { } }
    public virtual int Depth { get { return default(int); } }
    public virtual string Path { get { return default(string); } }
    public virtual char QuoteChar { get { return default(char); } protected internal set { } }
    public virtual Newtonsoft.Json.JsonToken TokenType { get { return default(Newtonsoft.Json.JsonToken); } }
    public virtual object Value { get { return default(object); } }
    public virtual System.Type ValueType { get { return default(System.Type); } }
    public virtual void Close() { }
    protected virtual void Dispose(bool disposing) { }
    public abstract bool Read();
    public abstract System.Byte[] ReadAsBytes();
    public abstract System.Nullable<System.DateTime> ReadAsDateTime();
    public abstract System.Nullable<System.DateTimeOffset> ReadAsDateTimeOffset();
    public abstract System.Nullable<System.Decimal> ReadAsDecimal();
    public abstract System.Nullable<System.Int32> ReadAsInt32();
    public abstract string ReadAsString();
    protected void SetStateBasedOnCurrent() { }
    protected void SetToken(Newtonsoft.Json.JsonToken newToken) { }
    protected void SetToken(Newtonsoft.Json.JsonToken newToken, object value) { }
    public void Skip() { }
    void System.IDisposable.Dispose() { }
    protected internal enum State {
      Array = 6,
      ArrayStart = 5,
      Closed = 7,
      Complete = 1,
      Constructor = 10,
      ConstructorStart = 9,
      Error = 11,
      Finished = 12,
      Object = 4,
      ObjectStart = 3,
      PostValue = 8,
      Property = 2,
      Start = 0,
    }
  }
  public partial class JsonReaderException : System.Exception {
    public JsonReaderException() { }
    public JsonReaderException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public JsonReaderException(string message) { }
    public JsonReaderException(string message, System.Exception innerException) { }
    public int LineNumber { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    public int LinePosition { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    public string Path { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
  }
  public partial class JsonSerializationException : System.Exception {
    public JsonSerializationException() { }
    public JsonSerializationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public JsonSerializationException(string message) { }
    public JsonSerializationException(string message, System.Exception innerException) { }
  }
  public partial class JsonSerializer {
    public JsonSerializer() { }
    public virtual System.Runtime.Serialization.SerializationBinder Binder { get { return default(System.Runtime.Serialization.SerializationBinder); } set { } }
    public virtual Newtonsoft.Json.ConstructorHandling ConstructorHandling { get { return default(Newtonsoft.Json.ConstructorHandling); } set { } }
    public virtual System.Runtime.Serialization.StreamingContext Context { get { return default(System.Runtime.Serialization.StreamingContext); } set { } }
    public virtual Newtonsoft.Json.Serialization.IContractResolver ContractResolver { get { return default(Newtonsoft.Json.Serialization.IContractResolver); } set { } }
    public virtual Newtonsoft.Json.JsonConverterCollection Converters { get { return default(Newtonsoft.Json.JsonConverterCollection); } }
    public virtual System.Globalization.CultureInfo Culture { get { return default(System.Globalization.CultureInfo); } set { } }
    public virtual Newtonsoft.Json.DateFormatHandling DateFormatHandling { get { return default(Newtonsoft.Json.DateFormatHandling); } set { } }
    public virtual Newtonsoft.Json.DateTimeZoneHandling DateTimeZoneHandling { get { return default(Newtonsoft.Json.DateTimeZoneHandling); } set { } }
    public virtual Newtonsoft.Json.DefaultValueHandling DefaultValueHandling { get { return default(Newtonsoft.Json.DefaultValueHandling); } set { } }
    public virtual Newtonsoft.Json.Formatting Formatting { get { return default(Newtonsoft.Json.Formatting); } set { } }
    public virtual Newtonsoft.Json.MissingMemberHandling MissingMemberHandling { get { return default(Newtonsoft.Json.MissingMemberHandling); } set { } }
    public virtual Newtonsoft.Json.NullValueHandling NullValueHandling { get { return default(Newtonsoft.Json.NullValueHandling); } set { } }
    public virtual Newtonsoft.Json.ObjectCreationHandling ObjectCreationHandling { get { return default(Newtonsoft.Json.ObjectCreationHandling); } set { } }
    public virtual Newtonsoft.Json.PreserveReferencesHandling PreserveReferencesHandling { get { return default(Newtonsoft.Json.PreserveReferencesHandling); } set { } }
    public virtual Newtonsoft.Json.ReferenceLoopHandling ReferenceLoopHandling { get { return default(Newtonsoft.Json.ReferenceLoopHandling); } set { } }
    public virtual Newtonsoft.Json.Serialization.IReferenceResolver ReferenceResolver { get { return default(Newtonsoft.Json.Serialization.IReferenceResolver); } set { } }
    public virtual System.Runtime.Serialization.Formatters.FormatterAssemblyStyle TypeNameAssemblyFormat { get { return default(System.Runtime.Serialization.Formatters.FormatterAssemblyStyle); } set { } }
    public virtual Newtonsoft.Json.TypeNameHandling TypeNameHandling { get { return default(Newtonsoft.Json.TypeNameHandling); } set { } }
    public virtual event System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> Error { add { } remove { } }
    public static Newtonsoft.Json.JsonSerializer Create(Newtonsoft.Json.JsonSerializerSettings settings) { return default(Newtonsoft.Json.JsonSerializer); }
    public object Deserialize(Newtonsoft.Json.JsonReader reader) { return default(object); }
    public object Deserialize(Newtonsoft.Json.JsonReader reader, System.Type objectType) { return default(object); }
    public object Deserialize(System.IO.TextReader reader, System.Type objectType) { return default(object); }
    public T Deserialize<T>(Newtonsoft.Json.JsonReader reader) { return default(T); }
    public void Populate(Newtonsoft.Json.JsonReader reader, object target) { }
    public void Populate(System.IO.TextReader reader, object target) { }
    public void Serialize(Newtonsoft.Json.JsonWriter jsonWriter, object value) { }
    public void Serialize(System.IO.TextWriter textWriter, object value) { }
  }
  public partial class JsonSerializerSettings {
    public JsonSerializerSettings() { }
    public System.Runtime.Serialization.SerializationBinder Binder { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Runtime.Serialization.SerializationBinder); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Newtonsoft.Json.ConstructorHandling ConstructorHandling { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Newtonsoft.Json.ConstructorHandling); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Runtime.Serialization.StreamingContext Context { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Runtime.Serialization.StreamingContext); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Newtonsoft.Json.Serialization.IContractResolver ContractResolver { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Newtonsoft.Json.Serialization.IContractResolver); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.Generic.IList<Newtonsoft.Json.JsonConverter> Converters { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IList<Newtonsoft.Json.JsonConverter>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Globalization.CultureInfo Culture { get { return default(System.Globalization.CultureInfo); } set { } }
    public Newtonsoft.Json.DateFormatHandling DateFormatHandling { get { return default(Newtonsoft.Json.DateFormatHandling); } set { } }
    public Newtonsoft.Json.DateTimeZoneHandling DateTimeZoneHandling { get { return default(Newtonsoft.Json.DateTimeZoneHandling); } set { } }
    public Newtonsoft.Json.DefaultValueHandling DefaultValueHandling { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Newtonsoft.Json.DefaultValueHandling); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> Error { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Newtonsoft.Json.Formatting Formatting { get { return default(Newtonsoft.Json.Formatting); } set { } }
    public Newtonsoft.Json.MissingMemberHandling MissingMemberHandling { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Newtonsoft.Json.MissingMemberHandling); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Newtonsoft.Json.NullValueHandling NullValueHandling { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Newtonsoft.Json.NullValueHandling); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Newtonsoft.Json.ObjectCreationHandling ObjectCreationHandling { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Newtonsoft.Json.ObjectCreationHandling); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Newtonsoft.Json.PreserveReferencesHandling PreserveReferencesHandling { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Newtonsoft.Json.PreserveReferencesHandling); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Newtonsoft.Json.ReferenceLoopHandling ReferenceLoopHandling { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Newtonsoft.Json.ReferenceLoopHandling); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Newtonsoft.Json.Serialization.IReferenceResolver ReferenceResolver { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Newtonsoft.Json.Serialization.IReferenceResolver); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Runtime.Serialization.Formatters.FormatterAssemblyStyle TypeNameAssemblyFormat { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Runtime.Serialization.Formatters.FormatterAssemblyStyle); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Newtonsoft.Json.TypeNameHandling TypeNameHandling { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Newtonsoft.Json.TypeNameHandling); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial class JsonTextReader : Newtonsoft.Json.JsonReader, Newtonsoft.Json.IJsonLineInfo {
    public JsonTextReader(System.IO.TextReader reader) { }
    public int LineNumber { get { return default(int); } }
    public int LinePosition { get { return default(int); } }
    public override void Close() { }
    public bool HasLineInfo() { return default(bool); }
    [System.Diagnostics.DebuggerStepThroughAttribute]
    public override bool Read() { return default(bool); }
    public override System.Byte[] ReadAsBytes() { return default(System.Byte[]); }
    public override System.Nullable<System.DateTime> ReadAsDateTime() { return default(System.Nullable<System.DateTime>); }
    public override System.Nullable<System.DateTimeOffset> ReadAsDateTimeOffset() { return default(System.Nullable<System.DateTimeOffset>); }
    public override System.Nullable<System.Decimal> ReadAsDecimal() { return default(System.Nullable<System.Decimal>); }
    public override System.Nullable<System.Int32> ReadAsInt32() { return default(System.Nullable<System.Int32>); }
    public override string ReadAsString() { return default(string); }
  }
  public partial class JsonTextWriter : Newtonsoft.Json.JsonWriter {
    public JsonTextWriter(System.IO.TextWriter textWriter) { }
    public int Indentation { get { return default(int); } set { } }
    public char IndentChar { get { return default(char); } set { } }
    public char QuoteChar { get { return default(char); } set { } }
    public bool QuoteName { get { return default(bool); } set { } }
    public override void Close() { }
    public override void Flush() { }
    public override void WriteComment(string text) { }
    protected override void WriteEnd(Newtonsoft.Json.JsonToken token) { }
    protected override void WriteIndent() { }
    protected override void WriteIndentSpace() { }
    public override void WriteNull() { }
    public override void WritePropertyName(string name) { }
    public override void WriteRaw(string json) { }
    public override void WriteStartArray() { }
    public override void WriteStartConstructor(string name) { }
    public override void WriteStartObject() { }
    public override void WriteUndefined() { }
    public override void WriteValue(bool value) { }
    public override void WriteValue(byte value) { }
    public override void WriteValue(System.Byte[] value) { }
    public override void WriteValue(char value) { }
    public override void WriteValue(System.DateTime value) { }
    public override void WriteValue(System.DateTimeOffset value) { }
    public override void WriteValue(decimal value) { }
    public override void WriteValue(double value) { }
    public override void WriteValue(System.Guid value) { }
    public override void WriteValue(short value) { }
    public override void WriteValue(int value) { }
    public override void WriteValue(long value) { }
    [System.CLSCompliantAttribute(false)]
    public override void WriteValue(sbyte value) { }
    public override void WriteValue(float value) { }
    public override void WriteValue(string value) { }
    public override void WriteValue(System.TimeSpan value) { }
    [System.CLSCompliantAttribute(false)]
    public override void WriteValue(ushort value) { }
    [System.CLSCompliantAttribute(false)]
    public override void WriteValue(uint value) { }
    [System.CLSCompliantAttribute(false)]
    public override void WriteValue(ulong value) { }
    public override void WriteValue(System.Uri value) { }
    protected override void WriteValueDelimiter() { }
    public override void WriteWhitespace(string ws) { }
  }
  public enum JsonToken {
    Boolean = 10,
    Bytes = 17,
    Comment = 5,
    Date = 16,
    EndArray = 14,
    EndConstructor = 15,
    EndObject = 13,
    Float = 8,
    Integer = 7,
    None = 0,
    Null = 11,
    PropertyName = 4,
    Raw = 6,
    StartArray = 2,
    StartConstructor = 3,
    StartObject = 1,
    String = 9,
    Undefined = 12,
  }
  public partial class JsonValidatingReader : Newtonsoft.Json.JsonReader, Newtonsoft.Json.IJsonLineInfo {
    public JsonValidatingReader(Newtonsoft.Json.JsonReader reader) { }
    public override int Depth { get { return default(int); } }
    int Newtonsoft.Json.IJsonLineInfo.LineNumber { get { return default(int); } }
    int Newtonsoft.Json.IJsonLineInfo.LinePosition { get { return default(int); } }
    public override string Path { get { return default(string); } }
    public override char QuoteChar { get { return default(char); } protected internal set { } }
    public Newtonsoft.Json.JsonReader Reader { get { return default(Newtonsoft.Json.JsonReader); } }
    public Newtonsoft.Json.Schema.JsonSchema Schema { get { return default(Newtonsoft.Json.Schema.JsonSchema); } set { } }
    public override Newtonsoft.Json.JsonToken TokenType { get { return default(Newtonsoft.Json.JsonToken); } }
    public override object Value { get { return default(object); } }
    public override System.Type ValueType { get { return default(System.Type); } }
    public event Newtonsoft.Json.Schema.ValidationEventHandler ValidationEventHandler { add { } remove { } }
    bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { return default(bool); }
    public override bool Read() { return default(bool); }
    public override System.Byte[] ReadAsBytes() { return default(System.Byte[]); }
    public override System.Nullable<System.DateTime> ReadAsDateTime() { return default(System.Nullable<System.DateTime>); }
    public override System.Nullable<System.DateTimeOffset> ReadAsDateTimeOffset() { return default(System.Nullable<System.DateTimeOffset>); }
    public override System.Nullable<System.Decimal> ReadAsDecimal() { return default(System.Nullable<System.Decimal>); }
    public override System.Nullable<System.Int32> ReadAsInt32() { return default(System.Nullable<System.Int32>); }
    public override string ReadAsString() { return default(string); }
  }
  public abstract partial class JsonWriter : System.IDisposable {
    protected JsonWriter() { }
    public bool CloseOutput { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Newtonsoft.Json.DateFormatHandling DateFormatHandling { get { return default(Newtonsoft.Json.DateFormatHandling); } set { } }
    public Newtonsoft.Json.DateTimeZoneHandling DateTimeZoneHandling { get { return default(Newtonsoft.Json.DateTimeZoneHandling); } set { } }
    public Newtonsoft.Json.Formatting Formatting { get { return default(Newtonsoft.Json.Formatting); } set { } }
    public string Path { get { return default(string); } }
    protected internal int Top { get { return default(int); } }
    public Newtonsoft.Json.WriteState WriteState { get { return default(Newtonsoft.Json.WriteState); } }
    public virtual void Close() { }
    public abstract void Flush();
    void System.IDisposable.Dispose() { }
    public virtual void WriteComment(string text) { }
    public virtual void WriteEnd() { }
    protected virtual void WriteEnd(Newtonsoft.Json.JsonToken token) { }
    public virtual void WriteEndArray() { }
    public virtual void WriteEndConstructor() { }
    public virtual void WriteEndObject() { }
    protected virtual void WriteIndent() { }
    protected virtual void WriteIndentSpace() { }
    public virtual void WriteNull() { }
    public virtual void WritePropertyName(string name) { }
    public virtual void WriteRaw(string json) { }
    public virtual void WriteRawValue(string json) { }
    public virtual void WriteStartArray() { }
    public virtual void WriteStartConstructor(string name) { }
    public virtual void WriteStartObject() { }
    public void WriteToken(Newtonsoft.Json.JsonReader reader) { }
    public virtual void WriteUndefined() { }
    public virtual void WriteValue(bool value) { }
    public virtual void WriteValue(byte value) { }
    public virtual void WriteValue(System.Byte[] value) { }
    public virtual void WriteValue(char value) { }
    public virtual void WriteValue(System.DateTime value) { }
    public virtual void WriteValue(System.DateTimeOffset value) { }
    public virtual void WriteValue(decimal value) { }
    public virtual void WriteValue(double value) { }
    public virtual void WriteValue(System.Guid value) { }
    public virtual void WriteValue(short value) { }
    public virtual void WriteValue(int value) { }
    public virtual void WriteValue(long value) { }
    public virtual void WriteValue(System.Nullable<System.Boolean> value) { }
    public virtual void WriteValue(System.Nullable<System.Byte> value) { }
    public virtual void WriteValue(System.Nullable<System.Char> value) { }
    public virtual void WriteValue(System.Nullable<System.DateTime> value) { }
    public virtual void WriteValue(System.Nullable<System.DateTimeOffset> value) { }
    public virtual void WriteValue(System.Nullable<System.Decimal> value) { }
    public virtual void WriteValue(System.Nullable<System.Double> value) { }
    public virtual void WriteValue(System.Nullable<System.Guid> value) { }
    public virtual void WriteValue(System.Nullable<System.Int16> value) { }
    public virtual void WriteValue(System.Nullable<System.Int32> value) { }
    public virtual void WriteValue(System.Nullable<System.Int64> value) { }
    [System.CLSCompliantAttribute(false)]
    public virtual void WriteValue(System.Nullable<System.SByte> value) { }
    public virtual void WriteValue(System.Nullable<System.Single> value) { }
    public virtual void WriteValue(System.Nullable<System.TimeSpan> value) { }
    [System.CLSCompliantAttribute(false)]
    public virtual void WriteValue(System.Nullable<System.UInt16> value) { }
    [System.CLSCompliantAttribute(false)]
    public virtual void WriteValue(System.Nullable<System.UInt32> value) { }
    [System.CLSCompliantAttribute(false)]
    public virtual void WriteValue(System.Nullable<System.UInt64> value) { }
    public virtual void WriteValue(object value) { }
    [System.CLSCompliantAttribute(false)]
    public virtual void WriteValue(sbyte value) { }
    public virtual void WriteValue(float value) { }
    public virtual void WriteValue(string value) { }
    public virtual void WriteValue(System.TimeSpan value) { }
    [System.CLSCompliantAttribute(false)]
    public virtual void WriteValue(ushort value) { }
    [System.CLSCompliantAttribute(false)]
    public virtual void WriteValue(uint value) { }
    [System.CLSCompliantAttribute(false)]
    public virtual void WriteValue(ulong value) { }
    public virtual void WriteValue(System.Uri value) { }
    protected virtual void WriteValueDelimiter() { }
    public virtual void WriteWhitespace(string ws) { }
  }
  public partial class JsonWriterException : System.Exception {
    public JsonWriterException() { }
    public JsonWriterException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public JsonWriterException(string message) { }
    public JsonWriterException(string message, System.Exception innerException) { }
  }
  public enum MemberSerialization {
    OptIn = 1,
    OptOut = 0,
  }
  public enum MissingMemberHandling {
    Error = 1,
    Ignore = 0,
  }
  public enum NullValueHandling {
    Ignore = 1,
    Include = 0,
  }
  public enum ObjectCreationHandling {
    Auto = 0,
    Replace = 2,
    Reuse = 1,
  }
  [System.FlagsAttribute]
  public enum PreserveReferencesHandling {
    All = 3,
    Arrays = 2,
    None = 0,
    Objects = 1,
  }
  public enum ReferenceLoopHandling {
    Error = 0,
    Ignore = 1,
    Serialize = 2,
  }
  public enum Required {
    AllowNull = 1,
    Always = 2,
    Default = 0,
  }
  [System.FlagsAttribute]
  public enum TypeNameHandling {
    All = 3,
    Arrays = 2,
    Auto = 4,
    None = 0,
    Objects = 1,
  }
  public enum WriteState {
    Array = 3,
    Closed = 1,
    Constructor = 4,
    Error = 0,
    Object = 2,
    Property = 5,
    Start = 6,
  }
}
namespace Newtonsoft.Json.Bson {
  public partial class BsonObjectId {
    public BsonObjectId(System.Byte[] value) { }
    public System.Byte[] Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Byte[]); } }
  }
  public partial class BsonReader : Newtonsoft.Json.JsonReader {
    public BsonReader(System.IO.BinaryReader reader) { }
    public BsonReader(System.IO.BinaryReader reader, bool readRootValueAsArray, System.DateTimeKind dateTimeKindHandling) { }
    public BsonReader(System.IO.Stream stream) { }
    public BsonReader(System.IO.Stream stream, bool readRootValueAsArray, System.DateTimeKind dateTimeKindHandling) { }
    public System.DateTimeKind DateTimeKindHandling { get { return default(System.DateTimeKind); } set { } }
    public bool JsonNet35BinaryCompatibility { get { return default(bool); } set { } }
    public bool ReadRootValueAsArray { get { return default(bool); } set { } }
    public override void Close() { }
    public override bool Read() { return default(bool); }
    public override System.Byte[] ReadAsBytes() { return default(System.Byte[]); }
    public override System.Nullable<System.DateTime> ReadAsDateTime() { return default(System.Nullable<System.DateTime>); }
    public override System.Nullable<System.DateTimeOffset> ReadAsDateTimeOffset() { return default(System.Nullable<System.DateTimeOffset>); }
    public override System.Nullable<System.Decimal> ReadAsDecimal() { return default(System.Nullable<System.Decimal>); }
    public override System.Nullable<System.Int32> ReadAsInt32() { return default(System.Nullable<System.Int32>); }
    public override string ReadAsString() { return default(string); }
  }
  public partial class BsonWriter : Newtonsoft.Json.JsonWriter {
    public BsonWriter(System.IO.BinaryWriter writer) { }
    public BsonWriter(System.IO.Stream stream) { }
    public System.DateTimeKind DateTimeKindHandling { get { return default(System.DateTimeKind); } set { } }
    public override void Close() { }
    public override void Flush() { }
    public override void WriteComment(string text) { }
    protected override void WriteEnd(Newtonsoft.Json.JsonToken token) { }
    public override void WriteNull() { }
    public void WriteObjectId(System.Byte[] value) { }
    public override void WritePropertyName(string name) { }
    public override void WriteRaw(string json) { }
    public override void WriteRawValue(string json) { }
    public void WriteRegex(string pattern, string options) { }
    public override void WriteStartArray() { }
    public override void WriteStartConstructor(string name) { }
    public override void WriteStartObject() { }
    public override void WriteUndefined() { }
    public override void WriteValue(bool value) { }
    public override void WriteValue(byte value) { }
    public override void WriteValue(System.Byte[] value) { }
    public override void WriteValue(char value) { }
    public override void WriteValue(System.DateTime value) { }
    public override void WriteValue(System.DateTimeOffset value) { }
    public override void WriteValue(decimal value) { }
    public override void WriteValue(double value) { }
    public override void WriteValue(System.Guid value) { }
    public override void WriteValue(short value) { }
    public override void WriteValue(int value) { }
    public override void WriteValue(long value) { }
    [System.CLSCompliantAttribute(false)]
    public override void WriteValue(sbyte value) { }
    public override void WriteValue(float value) { }
    public override void WriteValue(string value) { }
    public override void WriteValue(System.TimeSpan value) { }
    [System.CLSCompliantAttribute(false)]
    public override void WriteValue(ushort value) { }
    [System.CLSCompliantAttribute(false)]
    public override void WriteValue(uint value) { }
    [System.CLSCompliantAttribute(false)]
    public override void WriteValue(ulong value) { }
    public override void WriteValue(System.Uri value) { }
  }
}
namespace Newtonsoft.Json.Converters {
  public partial class BinaryConverter : Newtonsoft.Json.JsonConverter {
    public BinaryConverter() { }
    public override bool CanConvert(System.Type objectType) { return default(bool); }
    public override object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer) { return default(object); }
    public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer) { }
  }
  public partial class BsonObjectIdConverter : Newtonsoft.Json.JsonConverter {
    public BsonObjectIdConverter() { }
    public override bool CanConvert(System.Type objectType) { return default(bool); }
    public override object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer) { return default(object); }
    public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer) { }
  }
  public abstract partial class CustomCreationConverter<T> : Newtonsoft.Json.JsonConverter {
    protected CustomCreationConverter() { }
    public override bool CanWrite { get { return default(bool); } }
    public override bool CanConvert(System.Type objectType) { return default(bool); }
    public abstract T Create(System.Type objectType);
    public override object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer) { return default(object); }
    public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer) { }
  }
  public partial class DataSetConverter : Newtonsoft.Json.JsonConverter {
    public DataSetConverter() { }
    public override bool CanConvert(System.Type valueType) { return default(bool); }
    public override object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer) { return default(object); }
    public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer) { }
  }
  public partial class DataTableConverter : Newtonsoft.Json.JsonConverter {
    public DataTableConverter() { }
    public override bool CanConvert(System.Type valueType) { return default(bool); }
    public override object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer) { return default(object); }
    public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer) { }
  }
  public abstract partial class DateTimeConverterBase : Newtonsoft.Json.JsonConverter {
    protected DateTimeConverterBase() { }
    public override bool CanConvert(System.Type objectType) { return default(bool); }
  }
  public partial class EntityKeyMemberConverter : Newtonsoft.Json.JsonConverter {
    public EntityKeyMemberConverter() { }
    public override bool CanConvert(System.Type objectType) { return default(bool); }
    public override object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer) { return default(object); }
    public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer) { }
  }
  public partial class ExpandoObjectConverter : Newtonsoft.Json.JsonConverter {
    public ExpandoObjectConverter() { }
    public override bool CanWrite { get { return default(bool); } }
    public override bool CanConvert(System.Type objectType) { return default(bool); }
    public override object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer) { return default(object); }
    public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer) { }
  }
  public partial class IsoDateTimeConverter : Newtonsoft.Json.Converters.DateTimeConverterBase {
    public IsoDateTimeConverter() { }
    public System.Globalization.CultureInfo Culture { get { return default(System.Globalization.CultureInfo); } set { } }
    public string DateTimeFormat { get { return default(string); } set { } }
    public System.Globalization.DateTimeStyles DateTimeStyles { get { return default(System.Globalization.DateTimeStyles); } set { } }
    public override object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer) { return default(object); }
    public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer) { }
  }
  public partial class JavaScriptDateTimeConverter : Newtonsoft.Json.Converters.DateTimeConverterBase {
    public JavaScriptDateTimeConverter() { }
    public override object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer) { return default(object); }
    public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer) { }
  }
  public partial class KeyValuePairConverter : Newtonsoft.Json.JsonConverter {
    public KeyValuePairConverter() { }
    public override bool CanConvert(System.Type objectType) { return default(bool); }
    public override object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer) { return default(object); }
    public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer) { }
  }
  public partial class RegexConverter : Newtonsoft.Json.JsonConverter {
    public RegexConverter() { }
    public override bool CanConvert(System.Type objectType) { return default(bool); }
    public override object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer) { return default(object); }
    public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer) { }
  }
  public partial class StringEnumConverter : Newtonsoft.Json.JsonConverter {
    public StringEnumConverter() { }
    public bool CamelCaseText { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override bool CanConvert(System.Type objectType) { return default(bool); }
    public override object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer) { return default(object); }
    public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer) { }
  }
  public partial class VersionConverter : Newtonsoft.Json.JsonConverter {
    public VersionConverter() { }
    public override bool CanConvert(System.Type objectType) { return default(bool); }
    public override object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer) { return default(object); }
    public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer) { }
  }
  public partial class XmlNodeConverter : Newtonsoft.Json.JsonConverter {
    public XmlNodeConverter() { }
    public string DeserializeRootElementName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool OmitRootObject { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool WriteArrayAttribute { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override bool CanConvert(System.Type valueType) { return default(bool); }
    public override object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer) { return default(object); }
    public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer) { }
  }
}
namespace Newtonsoft.Json.Linq {
  public static partial class Extensions {
    public static Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken> Ancestors<T>(this System.Collections.Generic.IEnumerable<T> source) where T : Newtonsoft.Json.Linq.JToken { return default(Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken>); }
    public static Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken> AsJEnumerable(this System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> source) { return default(Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken>); }
    public static Newtonsoft.Json.Linq.IJEnumerable<T> AsJEnumerable<T>(this System.Collections.Generic.IEnumerable<T> source) where T : Newtonsoft.Json.Linq.JToken { return default(Newtonsoft.Json.Linq.IJEnumerable<T>); }
    public static Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken> Children<T>(this System.Collections.Generic.IEnumerable<T> source) where T : Newtonsoft.Json.Linq.JToken { return default(Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken>); }
    public static System.Collections.Generic.IEnumerable<U> Children<T, U>(this System.Collections.Generic.IEnumerable<T> source) where T : Newtonsoft.Json.Linq.JToken { return default(System.Collections.Generic.IEnumerable<U>); }
    public static Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken> Descendants<T>(this System.Collections.Generic.IEnumerable<T> source) where T : Newtonsoft.Json.Linq.JContainer { return default(Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken>); }
    public static Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JProperty> Properties(this System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JObject> source) { return default(Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JProperty>); }
    public static U Value<U>(this System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> value) { return default(U); }
    public static U Value<T, U>(this System.Collections.Generic.IEnumerable<T> value) where T : Newtonsoft.Json.Linq.JToken { return default(U); }
    public static Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken> Values(this System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> source) { return default(Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken>); }
    public static Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken> Values(this System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> source, object key) { return default(Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken>); }
    public static System.Collections.Generic.IEnumerable<U> Values<U>(this System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> source) { return default(System.Collections.Generic.IEnumerable<U>); }
    public static System.Collections.Generic.IEnumerable<U> Values<U>(this System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> source, object key) { return default(System.Collections.Generic.IEnumerable<U>); }
  }
  public partial interface IJEnumerable<out T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable where T : Newtonsoft.Json.Linq.JToken {
    Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken> this[object key] { get; }
  }
  public partial class JArray : Newtonsoft.Json.Linq.JContainer, System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>, System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>, System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>, System.Collections.IEnumerable {
    public JArray() { }
    public JArray(Newtonsoft.Json.Linq.JArray other) { }
    public JArray(object content) { }
    public JArray(params System.Object[] content) { }
    protected override System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> ChildrenTokens { get { return default(System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>); } }
    public Newtonsoft.Json.Linq.JToken this[int index] { get { return default(Newtonsoft.Json.Linq.JToken); } set { } }
    public override Newtonsoft.Json.Linq.JToken this[object key] { get { return default(Newtonsoft.Json.Linq.JToken); } set { } }
    bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.IsReadOnly { get { return default(bool); } }
    public override Newtonsoft.Json.Linq.JTokenType Type { get { return default(Newtonsoft.Json.Linq.JTokenType); } }
    public void Add(Newtonsoft.Json.Linq.JToken item) { }
    public void Clear() { }
    public bool Contains(Newtonsoft.Json.Linq.JToken item) { return default(bool); }
    public static new Newtonsoft.Json.Linq.JArray FromObject(object o) { return default(Newtonsoft.Json.Linq.JArray); }
    public static new Newtonsoft.Json.Linq.JArray FromObject(object o, Newtonsoft.Json.JsonSerializer jsonSerializer) { return default(Newtonsoft.Json.Linq.JArray); }
    public int IndexOf(Newtonsoft.Json.Linq.JToken item) { return default(int); }
    public void Insert(int index, Newtonsoft.Json.Linq.JToken item) { }
    public static new Newtonsoft.Json.Linq.JArray Load(Newtonsoft.Json.JsonReader reader) { return default(Newtonsoft.Json.Linq.JArray); }
    public static new Newtonsoft.Json.Linq.JArray Parse(string json) { return default(Newtonsoft.Json.Linq.JArray); }
    public bool Remove(Newtonsoft.Json.Linq.JToken item) { return default(bool); }
    public void RemoveAt(int index) { }
    void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.CopyTo(Newtonsoft.Json.Linq.JToken[] array, int arrayIndex) { }
    public override void WriteTo(Newtonsoft.Json.JsonWriter writer, params Newtonsoft.Json.JsonConverter[] converters) { }
  }
  public partial class JConstructor : Newtonsoft.Json.Linq.JContainer {
    public JConstructor() { }
    public JConstructor(Newtonsoft.Json.Linq.JConstructor other) { }
    public JConstructor(string name) { }
    public JConstructor(string name, object content) { }
    public JConstructor(string name, params System.Object[] content) { }
    protected override System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> ChildrenTokens { get { return default(System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>); } }
    public override Newtonsoft.Json.Linq.JToken this[object key] { get { return default(Newtonsoft.Json.Linq.JToken); } set { } }
    public string Name { get { return default(string); } set { } }
    public override Newtonsoft.Json.Linq.JTokenType Type { get { return default(Newtonsoft.Json.Linq.JTokenType); } }
    public static new Newtonsoft.Json.Linq.JConstructor Load(Newtonsoft.Json.JsonReader reader) { return default(Newtonsoft.Json.Linq.JConstructor); }
    public override void WriteTo(Newtonsoft.Json.JsonWriter writer, params Newtonsoft.Json.JsonConverter[] converters) { }
  }
  public abstract partial class JContainer : Newtonsoft.Json.Linq.JToken, System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>, System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>, System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.Collections.Specialized.INotifyCollectionChanged, System.ComponentModel.IBindingList, System.ComponentModel.ITypedList {
    internal JContainer() { }
    protected abstract System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> ChildrenTokens { get; }
    public int Count { get { return default(int); } }
    public override Newtonsoft.Json.Linq.JToken First { get { return default(Newtonsoft.Json.Linq.JToken); } }
    public override bool HasValues { get { return default(bool); } }
    public override Newtonsoft.Json.Linq.JToken Last { get { return default(Newtonsoft.Json.Linq.JToken); } }
    bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.IsReadOnly { get { return default(bool); } }
    Newtonsoft.Json.Linq.JToken System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.this[int index] { get { return default(Newtonsoft.Json.Linq.JToken); } set { } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    bool System.Collections.IList.IsFixedSize { get { return default(bool); } }
    bool System.Collections.IList.IsReadOnly { get { return default(bool); } }
    object System.Collections.IList.this[int index] { get { return default(object); } set { } }
    bool System.ComponentModel.IBindingList.AllowEdit { get { return default(bool); } }
    bool System.ComponentModel.IBindingList.AllowNew { get { return default(bool); } }
    bool System.ComponentModel.IBindingList.AllowRemove { get { return default(bool); } }
    bool System.ComponentModel.IBindingList.IsSorted { get { return default(bool); } }
    System.ComponentModel.ListSortDirection System.ComponentModel.IBindingList.SortDirection { get { return default(System.ComponentModel.ListSortDirection); } }
    System.ComponentModel.PropertyDescriptor System.ComponentModel.IBindingList.SortProperty { get { return default(System.ComponentModel.PropertyDescriptor); } }
    bool System.ComponentModel.IBindingList.SupportsChangeNotification { get { return default(bool); } }
    bool System.ComponentModel.IBindingList.SupportsSearching { get { return default(bool); } }
    bool System.ComponentModel.IBindingList.SupportsSorting { get { return default(bool); } }
    public event System.ComponentModel.AddingNewEventHandler AddingNew { add { } remove { } }
    public event System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged { add { } remove { } }
    public event System.ComponentModel.ListChangedEventHandler ListChanged { add { } remove { } }
    public virtual void Add(object content) { }
    public void AddFirst(object content) { }
    public override Newtonsoft.Json.Linq.JEnumerable<Newtonsoft.Json.Linq.JToken> Children() { return default(Newtonsoft.Json.Linq.JEnumerable<Newtonsoft.Json.Linq.JToken>); }
    public Newtonsoft.Json.JsonWriter CreateWriter() { return default(Newtonsoft.Json.JsonWriter); }
    [System.Diagnostics.DebuggerHiddenAttribute]
    public System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> Descendants() { return default(System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>); }
    protected virtual void OnAddingNew(System.ComponentModel.AddingNewEventArgs e) { }
    protected virtual void OnCollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventArgs e) { }
    protected virtual void OnListChanged(System.ComponentModel.ListChangedEventArgs e) { }
    public void RemoveAll() { }
    public void ReplaceAll(object content) { }
    void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Add(Newtonsoft.Json.Linq.JToken item) { }
    void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Clear() { }
    bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Contains(Newtonsoft.Json.Linq.JToken item) { return default(bool); }
    void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.CopyTo(Newtonsoft.Json.Linq.JToken[] array, int arrayIndex) { }
    bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Remove(Newtonsoft.Json.Linq.JToken item) { return default(bool); }
    int System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.IndexOf(Newtonsoft.Json.Linq.JToken item) { return default(int); }
    void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Insert(int index, Newtonsoft.Json.Linq.JToken item) { }
    void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.RemoveAt(int index) { }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    int System.Collections.IList.Add(object value) { return default(int); }
    void System.Collections.IList.Clear() { }
    bool System.Collections.IList.Contains(object value) { return default(bool); }
    int System.Collections.IList.IndexOf(object value) { return default(int); }
    void System.Collections.IList.Insert(int index, object value) { }
    void System.Collections.IList.Remove(object value) { }
    void System.Collections.IList.RemoveAt(int index) { }
    void System.ComponentModel.IBindingList.AddIndex(System.ComponentModel.PropertyDescriptor property) { }
    object System.ComponentModel.IBindingList.AddNew() { return default(object); }
    void System.ComponentModel.IBindingList.ApplySort(System.ComponentModel.PropertyDescriptor property, System.ComponentModel.ListSortDirection direction) { }
    int System.ComponentModel.IBindingList.Find(System.ComponentModel.PropertyDescriptor property, object key) { return default(int); }
    void System.ComponentModel.IBindingList.RemoveIndex(System.ComponentModel.PropertyDescriptor property) { }
    void System.ComponentModel.IBindingList.RemoveSort() { }
    System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ITypedList.GetItemProperties(System.ComponentModel.PropertyDescriptor[] listAccessors) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    string System.ComponentModel.ITypedList.GetListName(System.ComponentModel.PropertyDescriptor[] listAccessors) { return default(string); }
    public override System.Collections.Generic.IEnumerable<T> Values<T>() { return default(System.Collections.Generic.IEnumerable<T>); }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct JEnumerable<T> : Newtonsoft.Json.Linq.IJEnumerable<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable where T : Newtonsoft.Json.Linq.JToken {
    public static readonly Newtonsoft.Json.Linq.JEnumerable<T> Empty;
    public JEnumerable(System.Collections.Generic.IEnumerable<T> enumerable) { throw new System.NotImplementedException(); }
    public Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken> this[object key] { get { return default(Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken>); } }
    public override bool Equals(object obj) { return default(bool); }
    public System.Collections.Generic.IEnumerator<T> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<T>); }
    public override int GetHashCode() { return default(int); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public partial class JObject : Newtonsoft.Json.Linq.JContainer, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String, Newtonsoft.Json.Linq.JToken>>, System.Collections.Generic.IDictionary<System.String, Newtonsoft.Json.Linq.JToken>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, Newtonsoft.Json.Linq.JToken>>, System.Collections.IEnumerable, System.ComponentModel.ICustomTypeDescriptor, System.ComponentModel.INotifyPropertyChanged, System.ComponentModel.INotifyPropertyChanging {
    public JObject() { }
    public JObject(Newtonsoft.Json.Linq.JObject other) { }
    public JObject(object content) { }
    public JObject(params System.Object[] content) { }
    protected override System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> ChildrenTokens { get { return default(System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>); } }
    public override Newtonsoft.Json.Linq.JToken this[object key] { get { return default(Newtonsoft.Json.Linq.JToken); } set { } }
    public Newtonsoft.Json.Linq.JToken this[string propertyName] { get { return default(Newtonsoft.Json.Linq.JToken); } set { } }
    bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string,Newtonsoft.Json.Linq.JToken>>.IsReadOnly { get { return default(bool); } }
    System.Collections.Generic.ICollection<System.String> System.Collections.Generic.IDictionary<string,Newtonsoft.Json.Linq.JToken>.Keys { get { return default(System.Collections.Generic.ICollection<System.String>); } }
    System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IDictionary<string,Newtonsoft.Json.Linq.JToken>.Values { get { return default(System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>); } }
    public override Newtonsoft.Json.Linq.JTokenType Type { get { return default(Newtonsoft.Json.Linq.JTokenType); } }
    public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged { add { } remove { } }
    public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging { add { } remove { } }
    public void Add(string propertyName, Newtonsoft.Json.Linq.JToken value) { }
    public static new Newtonsoft.Json.Linq.JObject FromObject(object o) { return default(Newtonsoft.Json.Linq.JObject); }
    public static new Newtonsoft.Json.Linq.JObject FromObject(object o, Newtonsoft.Json.JsonSerializer jsonSerializer) { return default(Newtonsoft.Json.Linq.JObject); }
    [System.Diagnostics.DebuggerHiddenAttribute]
    public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String, Newtonsoft.Json.Linq.JToken>> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String, Newtonsoft.Json.Linq.JToken>>); }
    protected override System.Dynamic.DynamicMetaObject GetMetaObject(System.Linq.Expressions.Expression parameter) { return default(System.Dynamic.DynamicMetaObject); }
    public static new Newtonsoft.Json.Linq.JObject Load(Newtonsoft.Json.JsonReader reader) { return default(Newtonsoft.Json.Linq.JObject); }
    protected virtual void OnPropertyChanged(string propertyName) { }
    protected virtual void OnPropertyChanging(string propertyName) { }
    public static new Newtonsoft.Json.Linq.JObject Parse(string json) { return default(Newtonsoft.Json.Linq.JObject); }
    public System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JProperty> Properties() { return default(System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JProperty>); }
    public Newtonsoft.Json.Linq.JProperty Property(string name) { return default(Newtonsoft.Json.Linq.JProperty); }
    public Newtonsoft.Json.Linq.JEnumerable<Newtonsoft.Json.Linq.JToken> PropertyValues() { return default(Newtonsoft.Json.Linq.JEnumerable<Newtonsoft.Json.Linq.JToken>); }
    public bool Remove(string propertyName) { return default(bool); }
    void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string,Newtonsoft.Json.Linq.JToken>>.Add(System.Collections.Generic.KeyValuePair<System.String, Newtonsoft.Json.Linq.JToken> item) { }
    void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string,Newtonsoft.Json.Linq.JToken>>.Clear() { }
    bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string,Newtonsoft.Json.Linq.JToken>>.Contains(System.Collections.Generic.KeyValuePair<System.String, Newtonsoft.Json.Linq.JToken> item) { return default(bool); }
    void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string,Newtonsoft.Json.Linq.JToken>>.CopyTo(System.Collections.Generic.KeyValuePair<System.String, Newtonsoft.Json.Linq.JToken>[] array, int arrayIndex) { }
    bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string,Newtonsoft.Json.Linq.JToken>>.Remove(System.Collections.Generic.KeyValuePair<System.String, Newtonsoft.Json.Linq.JToken> item) { return default(bool); }
    bool System.Collections.Generic.IDictionary<string,Newtonsoft.Json.Linq.JToken>.ContainsKey(string key) { return default(bool); }
    System.ComponentModel.AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { return default(System.ComponentModel.AttributeCollection); }
    string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { return default(string); }
    string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { return default(string); }
    System.ComponentModel.TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { return default(System.ComponentModel.TypeConverter); }
    System.ComponentModel.EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { return default(System.ComponentModel.EventDescriptor); }
    System.ComponentModel.PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { return default(System.ComponentModel.PropertyDescriptor); }
    object System.ComponentModel.ICustomTypeDescriptor.GetEditor(System.Type editorBaseType) { return default(object); }
    System.ComponentModel.EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { return default(System.ComponentModel.EventDescriptorCollection); }
    System.ComponentModel.EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(System.Attribute[] attributes) { return default(System.ComponentModel.EventDescriptorCollection); }
    System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { return default(System.ComponentModel.PropertyDescriptorCollection); }
    System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(System.Attribute[] attributes) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd) { return default(object); }
    public bool TryGetValue(string propertyName, out Newtonsoft.Json.Linq.JToken value) { value = default(Newtonsoft.Json.Linq.JToken); return default(bool); }
    public override void WriteTo(Newtonsoft.Json.JsonWriter writer, params Newtonsoft.Json.JsonConverter[] converters) { }
  }
  public partial class JProperty : Newtonsoft.Json.Linq.JContainer {
    public JProperty(Newtonsoft.Json.Linq.JProperty other) { }
    public JProperty(string name, object content) { }
    public JProperty(string name, params System.Object[] content) { }
    protected override System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> ChildrenTokens { get { return default(System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>); } }
    public string Name { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(string); } }
    public override Newtonsoft.Json.Linq.JTokenType Type { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(Newtonsoft.Json.Linq.JTokenType); } }
    public Newtonsoft.Json.Linq.JToken Value { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(Newtonsoft.Json.Linq.JToken); } set { } }
    public static new Newtonsoft.Json.Linq.JProperty Load(Newtonsoft.Json.JsonReader reader) { return default(Newtonsoft.Json.Linq.JProperty); }
    public override void WriteTo(Newtonsoft.Json.JsonWriter writer, params Newtonsoft.Json.JsonConverter[] converters) { }
  }
  public partial class JPropertyDescriptor : System.ComponentModel.PropertyDescriptor {
    public JPropertyDescriptor(string name, System.Type propertyType) : base (default(string), default(System.Attribute[])) { }
    public override System.Type ComponentType { get { return default(System.Type); } }
    public override bool IsReadOnly { get { return default(bool); } }
    protected override int NameHashCode { get { return default(int); } }
    public override System.Type PropertyType { get { return default(System.Type); } }
    public override bool CanResetValue(object component) { return default(bool); }
    public override object GetValue(object component) { return default(object); }
    public override void ResetValue(object component) { }
    public override void SetValue(object component, object value) { }
    public override bool ShouldSerializeValue(object component) { return default(bool); }
  }
  public partial class JRaw : Newtonsoft.Json.Linq.JValue {
    public JRaw(Newtonsoft.Json.Linq.JRaw other) : base (default(Newtonsoft.Json.Linq.JValue)) { }
    public JRaw(object rawJson) : base (default(Newtonsoft.Json.Linq.JValue)) { }
    public static Newtonsoft.Json.Linq.JRaw Create(Newtonsoft.Json.JsonReader reader) { return default(Newtonsoft.Json.Linq.JRaw); }
  }
  public abstract partial class JToken : Newtonsoft.Json.IJsonLineInfo, Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken>, System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>, System.Collections.IEnumerable, System.Dynamic.IDynamicMetaObjectProvider, System.ICloneable {
    internal JToken() { }
    public static Newtonsoft.Json.Linq.JTokenEqualityComparer EqualityComparer { get { return default(Newtonsoft.Json.Linq.JTokenEqualityComparer); } }
    public virtual Newtonsoft.Json.Linq.JToken First { get { return default(Newtonsoft.Json.Linq.JToken); } }
    public abstract bool HasValues { get; }
    public virtual Newtonsoft.Json.Linq.JToken this[object key] { get { return default(Newtonsoft.Json.Linq.JToken); } set { } }
    public virtual Newtonsoft.Json.Linq.JToken Last { get { return default(Newtonsoft.Json.Linq.JToken); } }
    int Newtonsoft.Json.IJsonLineInfo.LineNumber { get { return default(int); } }
    int Newtonsoft.Json.IJsonLineInfo.LinePosition { get { return default(int); } }
    Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken> Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken>.this[object key] { get { return default(Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken>); } }
    public Newtonsoft.Json.Linq.JToken Next { get { return default(Newtonsoft.Json.Linq.JToken); } }
    public Newtonsoft.Json.Linq.JContainer Parent { [System.Diagnostics.DebuggerStepThroughAttribute]get { return default(Newtonsoft.Json.Linq.JContainer); } }
    public Newtonsoft.Json.Linq.JToken Previous { get { return default(Newtonsoft.Json.Linq.JToken); } }
    public Newtonsoft.Json.Linq.JToken Root { get { return default(Newtonsoft.Json.Linq.JToken); } }
    public abstract Newtonsoft.Json.Linq.JTokenType Type { get; }
    public void AddAfterSelf(object content) { }
    public void AddBeforeSelf(object content) { }
    [System.Diagnostics.DebuggerHiddenAttribute]
    public System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> AfterSelf() { return default(System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>); }
    [System.Diagnostics.DebuggerHiddenAttribute]
    public System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> Ancestors() { return default(System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>); }
    [System.Diagnostics.DebuggerHiddenAttribute]
    public System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> BeforeSelf() { return default(System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>); }
    public virtual Newtonsoft.Json.Linq.JEnumerable<Newtonsoft.Json.Linq.JToken> Children() { return default(Newtonsoft.Json.Linq.JEnumerable<Newtonsoft.Json.Linq.JToken>); }
    public Newtonsoft.Json.Linq.JEnumerable<T> Children<T>() where T : Newtonsoft.Json.Linq.JToken { return default(Newtonsoft.Json.Linq.JEnumerable<T>); }
    public Newtonsoft.Json.JsonReader CreateReader() { return default(Newtonsoft.Json.JsonReader); }
    public Newtonsoft.Json.Linq.JToken DeepClone() { return default(Newtonsoft.Json.Linq.JToken); }
    public static bool DeepEquals(Newtonsoft.Json.Linq.JToken t1, Newtonsoft.Json.Linq.JToken t2) { return default(bool); }
    public static Newtonsoft.Json.Linq.JToken FromObject(object o) { return default(Newtonsoft.Json.Linq.JToken); }
    public static Newtonsoft.Json.Linq.JToken FromObject(object o, Newtonsoft.Json.JsonSerializer jsonSerializer) { return default(Newtonsoft.Json.Linq.JToken); }
    protected virtual System.Dynamic.DynamicMetaObject GetMetaObject(System.Linq.Expressions.Expression parameter) { return default(System.Dynamic.DynamicMetaObject); }
    public static Newtonsoft.Json.Linq.JToken Load(Newtonsoft.Json.JsonReader reader) { return default(Newtonsoft.Json.Linq.JToken); }
    bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { return default(bool); }
    public static explicit operator bool (Newtonsoft.Json.Linq.JToken value) { return default(bool); }
    public static explicit operator System.Byte[] (Newtonsoft.Json.Linq.JToken value) { return default(System.Byte[]); }
    public static explicit operator System.DateTime (Newtonsoft.Json.Linq.JToken value) { return default(System.DateTime); }
    public static explicit operator System.DateTimeOffset (Newtonsoft.Json.Linq.JToken value) { return default(System.DateTimeOffset); }
    public static explicit operator decimal (Newtonsoft.Json.Linq.JToken value) { return default(decimal); }
    public static explicit operator double (Newtonsoft.Json.Linq.JToken value) { return default(double); }
    public static explicit operator short (Newtonsoft.Json.Linq.JToken value) { return default(short); }
    public static explicit operator int (Newtonsoft.Json.Linq.JToken value) { return default(int); }
    public static explicit operator long (Newtonsoft.Json.Linq.JToken value) { return default(long); }
    public static explicit operator System.Nullable<System.Boolean> (Newtonsoft.Json.Linq.JToken value) { return default(System.Nullable<System.Boolean>); }
    public static explicit operator System.Nullable<System.DateTime> (Newtonsoft.Json.Linq.JToken value) { return default(System.Nullable<System.DateTime>); }
    public static explicit operator System.Nullable<System.DateTimeOffset> (Newtonsoft.Json.Linq.JToken value) { return default(System.Nullable<System.DateTimeOffset>); }
    public static explicit operator System.Nullable<System.Decimal> (Newtonsoft.Json.Linq.JToken value) { return default(System.Nullable<System.Decimal>); }
    public static explicit operator System.Nullable<System.Double> (Newtonsoft.Json.Linq.JToken value) { return default(System.Nullable<System.Double>); }
    public static explicit operator System.Nullable<System.Int16> (Newtonsoft.Json.Linq.JToken value) { return default(System.Nullable<System.Int16>); }
    public static explicit operator System.Nullable<System.Int32> (Newtonsoft.Json.Linq.JToken value) { return default(System.Nullable<System.Int32>); }
    public static explicit operator System.Nullable<System.Int64> (Newtonsoft.Json.Linq.JToken value) { return default(System.Nullable<System.Int64>); }
    public static explicit operator System.Nullable<System.Single> (Newtonsoft.Json.Linq.JToken value) { return default(System.Nullable<System.Single>); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator System.Nullable<System.UInt16> (Newtonsoft.Json.Linq.JToken value) { return default(System.Nullable<System.UInt16>); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator System.Nullable<System.UInt32> (Newtonsoft.Json.Linq.JToken value) { return default(System.Nullable<System.UInt32>); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator System.Nullable<System.UInt64> (Newtonsoft.Json.Linq.JToken value) { return default(System.Nullable<System.UInt64>); }
    public static explicit operator float (Newtonsoft.Json.Linq.JToken value) { return default(float); }
    public static explicit operator string (Newtonsoft.Json.Linq.JToken value) { return default(string); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator ushort (Newtonsoft.Json.Linq.JToken value) { return default(ushort); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator uint (Newtonsoft.Json.Linq.JToken value) { return default(uint); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator ulong (Newtonsoft.Json.Linq.JToken value) { return default(ulong); }
    public static implicit operator Newtonsoft.Json.Linq.JToken (bool value) { return default(Newtonsoft.Json.Linq.JToken); }
    public static implicit operator Newtonsoft.Json.Linq.JToken (System.Byte[] value) { return default(Newtonsoft.Json.Linq.JToken); }
    public static implicit operator Newtonsoft.Json.Linq.JToken (System.DateTime value) { return default(Newtonsoft.Json.Linq.JToken); }
    public static implicit operator Newtonsoft.Json.Linq.JToken (System.DateTimeOffset value) { return default(Newtonsoft.Json.Linq.JToken); }
    public static implicit operator Newtonsoft.Json.Linq.JToken (decimal value) { return default(Newtonsoft.Json.Linq.JToken); }
    public static implicit operator Newtonsoft.Json.Linq.JToken (double value) { return default(Newtonsoft.Json.Linq.JToken); }
    [System.CLSCompliantAttribute(false)]
    public static implicit operator Newtonsoft.Json.Linq.JToken (short value) { return default(Newtonsoft.Json.Linq.JToken); }
    public static implicit operator Newtonsoft.Json.Linq.JToken (int value) { return default(Newtonsoft.Json.Linq.JToken); }
    public static implicit operator Newtonsoft.Json.Linq.JToken (long value) { return default(Newtonsoft.Json.Linq.JToken); }
    public static implicit operator Newtonsoft.Json.Linq.JToken (System.Nullable<System.Boolean> value) { return default(Newtonsoft.Json.Linq.JToken); }
    public static implicit operator Newtonsoft.Json.Linq.JToken (System.Nullable<System.DateTime> value) { return default(Newtonsoft.Json.Linq.JToken); }
    public static implicit operator Newtonsoft.Json.Linq.JToken (System.Nullable<System.DateTimeOffset> value) { return default(Newtonsoft.Json.Linq.JToken); }
    public static implicit operator Newtonsoft.Json.Linq.JToken (System.Nullable<System.Decimal> value) { return default(Newtonsoft.Json.Linq.JToken); }
    public static implicit operator Newtonsoft.Json.Linq.JToken (System.Nullable<System.Double> value) { return default(Newtonsoft.Json.Linq.JToken); }
    [System.CLSCompliantAttribute(false)]
    public static implicit operator Newtonsoft.Json.Linq.JToken (System.Nullable<System.Int16> value) { return default(Newtonsoft.Json.Linq.JToken); }
    public static implicit operator Newtonsoft.Json.Linq.JToken (System.Nullable<System.Int32> value) { return default(Newtonsoft.Json.Linq.JToken); }
    public static implicit operator Newtonsoft.Json.Linq.JToken (System.Nullable<System.Int64> value) { return default(Newtonsoft.Json.Linq.JToken); }
    public static implicit operator Newtonsoft.Json.Linq.JToken (System.Nullable<System.Single> value) { return default(Newtonsoft.Json.Linq.JToken); }
    [System.CLSCompliantAttribute(false)]
    public static implicit operator Newtonsoft.Json.Linq.JToken (System.Nullable<System.UInt16> value) { return default(Newtonsoft.Json.Linq.JToken); }
    [System.CLSCompliantAttribute(false)]
    public static implicit operator Newtonsoft.Json.Linq.JToken (System.Nullable<System.UInt32> value) { return default(Newtonsoft.Json.Linq.JToken); }
    [System.CLSCompliantAttribute(false)]
    public static implicit operator Newtonsoft.Json.Linq.JToken (System.Nullable<System.UInt64> value) { return default(Newtonsoft.Json.Linq.JToken); }
    public static implicit operator Newtonsoft.Json.Linq.JToken (float value) { return default(Newtonsoft.Json.Linq.JToken); }
    public static implicit operator Newtonsoft.Json.Linq.JToken (string value) { return default(Newtonsoft.Json.Linq.JToken); }
    [System.CLSCompliantAttribute(false)]
    public static implicit operator Newtonsoft.Json.Linq.JToken (ushort value) { return default(Newtonsoft.Json.Linq.JToken); }
    [System.CLSCompliantAttribute(false)]
    public static implicit operator Newtonsoft.Json.Linq.JToken (uint value) { return default(Newtonsoft.Json.Linq.JToken); }
    [System.CLSCompliantAttribute(false)]
    public static implicit operator Newtonsoft.Json.Linq.JToken (ulong value) { return default(Newtonsoft.Json.Linq.JToken); }
    public static Newtonsoft.Json.Linq.JToken Parse(string json) { return default(Newtonsoft.Json.Linq.JToken); }
    public static Newtonsoft.Json.Linq.JToken ReadFrom(Newtonsoft.Json.JsonReader reader) { return default(Newtonsoft.Json.Linq.JToken); }
    public void Remove() { }
    public void Replace(Newtonsoft.Json.Linq.JToken value) { }
    public Newtonsoft.Json.Linq.JToken SelectToken(string path) { return default(Newtonsoft.Json.Linq.JToken); }
    public Newtonsoft.Json.Linq.JToken SelectToken(string path, bool errorWhenNoMatch) { return default(Newtonsoft.Json.Linq.JToken); }
    System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator() { return default(System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    System.Dynamic.DynamicMetaObject System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(System.Linq.Expressions.Expression parameter) { return default(System.Dynamic.DynamicMetaObject); }
    object System.ICloneable.Clone() { return default(object); }
    public T ToObject<T>() { return default(T); }
    public T ToObject<T>(Newtonsoft.Json.JsonSerializer jsonSerializer) { return default(T); }
    public override string ToString() { return default(string); }
    public string ToString(Newtonsoft.Json.Formatting formatting, params Newtonsoft.Json.JsonConverter[] converters) { return default(string); }
    public virtual T Value<T>(object key) { return default(T); }
    public virtual System.Collections.Generic.IEnumerable<T> Values<T>() { return default(System.Collections.Generic.IEnumerable<T>); }
    public abstract void WriteTo(Newtonsoft.Json.JsonWriter writer, params Newtonsoft.Json.JsonConverter[] converters);
  }
  public partial class JTokenEqualityComparer : System.Collections.Generic.IEqualityComparer<Newtonsoft.Json.Linq.JToken> {
    public JTokenEqualityComparer() { }
    public bool Equals(Newtonsoft.Json.Linq.JToken x, Newtonsoft.Json.Linq.JToken y) { return default(bool); }
    public int GetHashCode(Newtonsoft.Json.Linq.JToken obj) { return default(int); }
  }
  public partial class JTokenReader : Newtonsoft.Json.JsonReader, Newtonsoft.Json.IJsonLineInfo {
    public JTokenReader(Newtonsoft.Json.Linq.JToken token) { }
    int Newtonsoft.Json.IJsonLineInfo.LineNumber { get { return default(int); } }
    int Newtonsoft.Json.IJsonLineInfo.LinePosition { get { return default(int); } }
    bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { return default(bool); }
    public override bool Read() { return default(bool); }
    public override System.Byte[] ReadAsBytes() { return default(System.Byte[]); }
    public override System.Nullable<System.DateTime> ReadAsDateTime() { return default(System.Nullable<System.DateTime>); }
    public override System.Nullable<System.DateTimeOffset> ReadAsDateTimeOffset() { return default(System.Nullable<System.DateTimeOffset>); }
    public override System.Nullable<System.Decimal> ReadAsDecimal() { return default(System.Nullable<System.Decimal>); }
    public override System.Nullable<System.Int32> ReadAsInt32() { return default(System.Nullable<System.Int32>); }
    public override string ReadAsString() { return default(string); }
  }
  public enum JTokenType {
    Array = 2,
    Boolean = 9,
    Bytes = 14,
    Comment = 5,
    Constructor = 3,
    Date = 12,
    Float = 7,
    Guid = 15,
    Integer = 6,
    None = 0,
    Null = 10,
    Object = 1,
    Property = 4,
    Raw = 13,
    String = 8,
    TimeSpan = 17,
    Undefined = 11,
    Uri = 16,
  }
  public partial class JTokenWriter : Newtonsoft.Json.JsonWriter {
    public JTokenWriter() { }
    public JTokenWriter(Newtonsoft.Json.Linq.JContainer container) { }
    public Newtonsoft.Json.Linq.JToken Token { get { return default(Newtonsoft.Json.Linq.JToken); } }
    public override void Close() { }
    public override void Flush() { }
    public override void WriteComment(string text) { }
    protected override void WriteEnd(Newtonsoft.Json.JsonToken token) { }
    public override void WriteNull() { }
    public override void WritePropertyName(string name) { }
    public override void WriteRaw(string json) { }
    public override void WriteStartArray() { }
    public override void WriteStartConstructor(string name) { }
    public override void WriteStartObject() { }
    public override void WriteUndefined() { }
    public override void WriteValue(bool value) { }
    public override void WriteValue(byte value) { }
    public override void WriteValue(System.Byte[] value) { }
    public override void WriteValue(char value) { }
    public override void WriteValue(System.DateTime value) { }
    public override void WriteValue(System.DateTimeOffset value) { }
    public override void WriteValue(decimal value) { }
    public override void WriteValue(double value) { }
    public override void WriteValue(System.Guid value) { }
    public override void WriteValue(short value) { }
    public override void WriteValue(int value) { }
    public override void WriteValue(long value) { }
    [System.CLSCompliantAttribute(false)]
    public override void WriteValue(sbyte value) { }
    public override void WriteValue(float value) { }
    public override void WriteValue(string value) { }
    public override void WriteValue(System.TimeSpan value) { }
    [System.CLSCompliantAttribute(false)]
    public override void WriteValue(ushort value) { }
    [System.CLSCompliantAttribute(false)]
    public override void WriteValue(uint value) { }
    [System.CLSCompliantAttribute(false)]
    public override void WriteValue(ulong value) { }
    public override void WriteValue(System.Uri value) { }
  }
  public partial class JValue : Newtonsoft.Json.Linq.JToken, System.IComparable, System.IComparable<Newtonsoft.Json.Linq.JValue>, System.IEquatable<Newtonsoft.Json.Linq.JValue>, System.IFormattable {
    public JValue(Newtonsoft.Json.Linq.JValue other) { }
    public JValue(bool value) { }
    public JValue(System.DateTime value) { }
    public JValue(double value) { }
    public JValue(System.Guid value) { }
    public JValue(long value) { }
    public JValue(object value) { }
    public JValue(string value) { }
    public JValue(System.TimeSpan value) { }
    [System.CLSCompliantAttribute(false)]
    public JValue(ulong value) { }
    public JValue(System.Uri value) { }
    public override bool HasValues { get { return default(bool); } }
    public override Newtonsoft.Json.Linq.JTokenType Type { get { return default(Newtonsoft.Json.Linq.JTokenType); } }
    public object Value { get { return default(object); } set { } }
    public int CompareTo(Newtonsoft.Json.Linq.JValue obj) { return default(int); }
    public static Newtonsoft.Json.Linq.JValue CreateComment(string value) { return default(Newtonsoft.Json.Linq.JValue); }
    public static Newtonsoft.Json.Linq.JValue CreateString(string value) { return default(Newtonsoft.Json.Linq.JValue); }
    public bool Equals(Newtonsoft.Json.Linq.JValue other) { return default(bool); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    protected override System.Dynamic.DynamicMetaObject GetMetaObject(System.Linq.Expressions.Expression parameter) { return default(System.Dynamic.DynamicMetaObject); }
    int System.IComparable.CompareTo(object obj) { return default(int); }
    public override string ToString() { return default(string); }
    public string ToString(System.IFormatProvider formatProvider) { return default(string); }
    public string ToString(string format) { return default(string); }
    public string ToString(string format, System.IFormatProvider formatProvider) { return default(string); }
    public override void WriteTo(Newtonsoft.Json.JsonWriter writer, params Newtonsoft.Json.JsonConverter[] converters) { }
  }
}
namespace Newtonsoft.Json.Schema {
  public static partial class Extensions {
    public static bool IsValid(this Newtonsoft.Json.Linq.JToken source, Newtonsoft.Json.Schema.JsonSchema schema) { return default(bool); }
    public static bool IsValid(this Newtonsoft.Json.Linq.JToken source, Newtonsoft.Json.Schema.JsonSchema schema, out System.Collections.Generic.IList<System.String> errorMessages) { errorMessages = default(System.Collections.Generic.IList<System.String>); return default(bool); }
    public static void Validate(this Newtonsoft.Json.Linq.JToken source, Newtonsoft.Json.Schema.JsonSchema schema) { }
    public static void Validate(this Newtonsoft.Json.Linq.JToken source, Newtonsoft.Json.Schema.JsonSchema schema, Newtonsoft.Json.Schema.ValidationEventHandler validationEventHandler) { }
  }
  public partial class JsonSchema {
    public JsonSchema() { }
    public Newtonsoft.Json.Schema.JsonSchema AdditionalProperties { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Newtonsoft.Json.Schema.JsonSchema); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool AllowAdditionalProperties { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Newtonsoft.Json.Linq.JToken Default { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Newtonsoft.Json.Linq.JToken); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Description { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Nullable<Newtonsoft.Json.Schema.JsonSchemaType> Disallow { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<Newtonsoft.Json.Schema.JsonSchemaType>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Nullable<System.Double> DivisibleBy { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.Double>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> Enum { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Nullable<System.Boolean> ExclusiveMaximum { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.Boolean>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Nullable<System.Boolean> ExclusiveMinimum { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.Boolean>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Newtonsoft.Json.Schema.JsonSchema Extends { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Newtonsoft.Json.Schema.JsonSchema); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Format { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Nullable<System.Boolean> Hidden { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.Boolean>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Id { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.Generic.IList<System.String> Identity { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IList<System.String>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.Generic.IList<Newtonsoft.Json.Schema.JsonSchema> Items { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IList<Newtonsoft.Json.Schema.JsonSchema>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Nullable<System.Double> Maximum { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.Double>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Nullable<System.Int32> MaximumItems { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.Int32>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Nullable<System.Int32> MaximumLength { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.Int32>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Nullable<System.Double> Minimum { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.Double>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Nullable<System.Int32> MinimumItems { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.Int32>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Nullable<System.Int32> MinimumLength { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.Int32>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.Generic.IDictionary<Newtonsoft.Json.Linq.JToken, System.String> Options { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IDictionary<Newtonsoft.Json.Linq.JToken, System.String>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Pattern { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.Generic.IDictionary<System.String, Newtonsoft.Json.Schema.JsonSchema> PatternProperties { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IDictionary<System.String, Newtonsoft.Json.Schema.JsonSchema>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.Generic.IDictionary<System.String, Newtonsoft.Json.Schema.JsonSchema> Properties { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IDictionary<System.String, Newtonsoft.Json.Schema.JsonSchema>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Nullable<System.Boolean> ReadOnly { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.Boolean>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Nullable<System.Boolean> Required { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.Boolean>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Requires { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Title { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Nullable<System.Boolean> Transient { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.Boolean>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Nullable<Newtonsoft.Json.Schema.JsonSchemaType> Type { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<Newtonsoft.Json.Schema.JsonSchemaType>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public static Newtonsoft.Json.Schema.JsonSchema Parse(string json) { return default(Newtonsoft.Json.Schema.JsonSchema); }
    public static Newtonsoft.Json.Schema.JsonSchema Parse(string json, Newtonsoft.Json.Schema.JsonSchemaResolver resolver) { return default(Newtonsoft.Json.Schema.JsonSchema); }
    public static Newtonsoft.Json.Schema.JsonSchema Read(Newtonsoft.Json.JsonReader reader) { return default(Newtonsoft.Json.Schema.JsonSchema); }
    public static Newtonsoft.Json.Schema.JsonSchema Read(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Schema.JsonSchemaResolver resolver) { return default(Newtonsoft.Json.Schema.JsonSchema); }
    public override string ToString() { return default(string); }
    public void WriteTo(Newtonsoft.Json.JsonWriter writer) { }
    public void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Schema.JsonSchemaResolver resolver) { }
  }
  public partial class JsonSchemaException : System.Exception {
    public JsonSchemaException() { }
    public JsonSchemaException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public JsonSchemaException(string message) { }
    public JsonSchemaException(string message, System.Exception innerException) { }
    public int LineNumber { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    public int LinePosition { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    public string Path { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
  }
  public partial class JsonSchemaGenerator {
    public JsonSchemaGenerator() { }
    public Newtonsoft.Json.Serialization.IContractResolver ContractResolver { get { return default(Newtonsoft.Json.Serialization.IContractResolver); } set { } }
    public Newtonsoft.Json.Schema.UndefinedSchemaIdHandling UndefinedSchemaIdHandling { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Newtonsoft.Json.Schema.UndefinedSchemaIdHandling); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Newtonsoft.Json.Schema.JsonSchema Generate(System.Type type) { return default(Newtonsoft.Json.Schema.JsonSchema); }
    public Newtonsoft.Json.Schema.JsonSchema Generate(System.Type type, Newtonsoft.Json.Schema.JsonSchemaResolver resolver) { return default(Newtonsoft.Json.Schema.JsonSchema); }
    public Newtonsoft.Json.Schema.JsonSchema Generate(System.Type type, Newtonsoft.Json.Schema.JsonSchemaResolver resolver, bool rootSchemaNullable) { return default(Newtonsoft.Json.Schema.JsonSchema); }
    public Newtonsoft.Json.Schema.JsonSchema Generate(System.Type type, bool rootSchemaNullable) { return default(Newtonsoft.Json.Schema.JsonSchema); }
  }
  public partial class JsonSchemaResolver {
    public JsonSchemaResolver() { }
    public System.Collections.Generic.IList<Newtonsoft.Json.Schema.JsonSchema> LoadedSchemas { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IList<Newtonsoft.Json.Schema.JsonSchema>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public virtual Newtonsoft.Json.Schema.JsonSchema GetSchema(string id) { return default(Newtonsoft.Json.Schema.JsonSchema); }
  }
  [System.FlagsAttribute]
  public enum JsonSchemaType {
    Any = 127,
    Array = 32,
    Boolean = 8,
    Float = 2,
    Integer = 4,
    None = 0,
    Null = 64,
    Object = 16,
    String = 1,
  }
  public enum UndefinedSchemaIdHandling {
    None = 0,
    UseAssemblyQualifiedName = 2,
    UseTypeName = 1,
  }
  public partial class ValidationEventArgs : System.EventArgs {
    internal ValidationEventArgs() { }
    public Newtonsoft.Json.Schema.JsonSchemaException Exception { get { return default(Newtonsoft.Json.Schema.JsonSchemaException); } }
    public string Message { get { return default(string); } }
    public string Path { get { return default(string); } }
  }
  public delegate void ValidationEventHandler(object sender, Newtonsoft.Json.Schema.ValidationEventArgs e);
}
namespace Newtonsoft.Json.Serialization {
  public partial class CamelCasePropertyNamesContractResolver : Newtonsoft.Json.Serialization.DefaultContractResolver {
    public CamelCasePropertyNamesContractResolver() { }
    protected internal override string ResolvePropertyName(string propertyName) { return default(string); }
  }
  public partial class DefaultContractResolver : Newtonsoft.Json.Serialization.IContractResolver {
    public DefaultContractResolver() { }
    public DefaultContractResolver(bool shareCache) { }
    public System.Reflection.BindingFlags DefaultMembersSearchFlags { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Reflection.BindingFlags); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool DynamicCodeGeneration { get { return default(bool); } }
    public bool IgnoreSerializableInterface { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool SerializeCompilerGeneratedMembers { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected virtual Newtonsoft.Json.Serialization.JsonArrayContract CreateArrayContract(System.Type objectType) { return default(Newtonsoft.Json.Serialization.JsonArrayContract); }
    protected virtual System.Collections.Generic.IList<Newtonsoft.Json.Serialization.JsonProperty> CreateConstructorParameters(System.Reflection.ConstructorInfo constructor, Newtonsoft.Json.Serialization.JsonPropertyCollection memberProperties) { return default(System.Collections.Generic.IList<Newtonsoft.Json.Serialization.JsonProperty>); }
    protected virtual Newtonsoft.Json.Serialization.JsonContract CreateContract(System.Type objectType) { return default(Newtonsoft.Json.Serialization.JsonContract); }
    protected virtual Newtonsoft.Json.Serialization.JsonDictionaryContract CreateDictionaryContract(System.Type objectType) { return default(Newtonsoft.Json.Serialization.JsonDictionaryContract); }
    protected virtual Newtonsoft.Json.Serialization.JsonDynamicContract CreateDynamicContract(System.Type objectType) { return default(Newtonsoft.Json.Serialization.JsonDynamicContract); }
    protected virtual Newtonsoft.Json.Serialization.JsonISerializableContract CreateISerializableContract(System.Type objectType) { return default(Newtonsoft.Json.Serialization.JsonISerializableContract); }
    protected virtual Newtonsoft.Json.Serialization.JsonLinqContract CreateLinqContract(System.Type objectType) { return default(Newtonsoft.Json.Serialization.JsonLinqContract); }
    protected virtual Newtonsoft.Json.Serialization.IValueProvider CreateMemberValueProvider(System.Reflection.MemberInfo member) { return default(Newtonsoft.Json.Serialization.IValueProvider); }
    protected virtual Newtonsoft.Json.Serialization.JsonObjectContract CreateObjectContract(System.Type objectType) { return default(Newtonsoft.Json.Serialization.JsonObjectContract); }
    protected virtual Newtonsoft.Json.Serialization.JsonPrimitiveContract CreatePrimitiveContract(System.Type objectType) { return default(Newtonsoft.Json.Serialization.JsonPrimitiveContract); }
    protected virtual System.Collections.Generic.IList<Newtonsoft.Json.Serialization.JsonProperty> CreateProperties(System.Type type, Newtonsoft.Json.MemberSerialization memberSerialization) { return default(System.Collections.Generic.IList<Newtonsoft.Json.Serialization.JsonProperty>); }
    protected virtual Newtonsoft.Json.Serialization.JsonProperty CreateProperty(System.Reflection.MemberInfo member, Newtonsoft.Json.MemberSerialization memberSerialization) { return default(Newtonsoft.Json.Serialization.JsonProperty); }
    protected virtual Newtonsoft.Json.Serialization.JsonProperty CreatePropertyFromConstructorParameter(Newtonsoft.Json.Serialization.JsonProperty matchingMemberProperty, System.Reflection.ParameterInfo parameterInfo) { return default(Newtonsoft.Json.Serialization.JsonProperty); }
    protected virtual Newtonsoft.Json.Serialization.JsonStringContract CreateStringContract(System.Type objectType) { return default(Newtonsoft.Json.Serialization.JsonStringContract); }
    protected virtual System.Collections.Generic.List<System.Reflection.MemberInfo> GetSerializableMembers(System.Type objectType) { return default(System.Collections.Generic.List<System.Reflection.MemberInfo>); }
    public virtual Newtonsoft.Json.Serialization.JsonContract ResolveContract(System.Type type) { return default(Newtonsoft.Json.Serialization.JsonContract); }
    protected virtual Newtonsoft.Json.JsonConverter ResolveContractConverter(System.Type objectType) { return default(Newtonsoft.Json.JsonConverter); }
    protected internal virtual string ResolvePropertyName(string propertyName) { return default(string); }
  }
  public partial class DefaultSerializationBinder : System.Runtime.Serialization.SerializationBinder {
    public DefaultSerializationBinder() { }
    public override void BindToName(System.Type serializedType, out string assemblyName, out string typeName) { assemblyName = default(string); typeName = default(string); }
    public override System.Type BindToType(string assemblyName, string typeName) { return default(System.Type); }
  }
  public partial class DynamicValueProvider : Newtonsoft.Json.Serialization.IValueProvider {
    public DynamicValueProvider(System.Reflection.MemberInfo memberInfo) { }
    public object GetValue(object target) { return default(object); }
    public void SetValue(object target, object value) { }
  }
  public partial class ErrorContext {
    internal ErrorContext() { }
    public System.Exception Error { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Exception); } }
    public bool Handled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public object Member { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } }
    public object OriginalObject { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } }
    public string Path { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
  }
  public partial class ErrorEventArgs : System.EventArgs {
    public ErrorEventArgs(object currentObject, Newtonsoft.Json.Serialization.ErrorContext errorContext) { }
    public object CurrentObject { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } }
    public Newtonsoft.Json.Serialization.ErrorContext ErrorContext { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Newtonsoft.Json.Serialization.ErrorContext); } }
  }
  public partial interface IContractResolver {
    Newtonsoft.Json.Serialization.JsonContract ResolveContract(System.Type type);
  }
  public partial interface IReferenceResolver {
    void AddReference(object context, string reference, object value);
    string GetReference(object context, object value);
    bool IsReferenced(object context, object value);
    object ResolveReference(object context, string reference);
  }
  public partial interface IValueProvider {
    object GetValue(object target);
    void SetValue(object target, object value);
  }
  public partial class JsonArrayContract : Newtonsoft.Json.Serialization.JsonContract {
    public JsonArrayContract(System.Type underlyingType) { }
    public System.Type CollectionItemType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } }
  }
  public abstract partial class JsonContract {
    internal JsonContract() { }
    public Newtonsoft.Json.JsonConverter Converter { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Newtonsoft.Json.JsonConverter); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Type CreatedType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Func<System.Object> DefaultCreator { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Func<System.Object>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool DefaultCreatorNonPublic { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Nullable<System.Boolean> IsReference { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.Boolean>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Reflection.MethodInfo OnDeserialized { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Reflection.MethodInfo); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Reflection.MethodInfo OnDeserializing { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Reflection.MethodInfo); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Reflection.MethodInfo OnError { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Reflection.MethodInfo); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Reflection.MethodInfo OnSerialized { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Reflection.MethodInfo); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Reflection.MethodInfo OnSerializing { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Reflection.MethodInfo); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Type UnderlyingType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } }
  }
  public partial class JsonDictionaryContract : Newtonsoft.Json.Serialization.JsonContract {
    public JsonDictionaryContract(System.Type underlyingType) { }
    public System.Type DictionaryKeyType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } }
    public System.Type DictionaryValueType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } }
    public System.Func<System.String, System.String> PropertyNameResolver { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Func<System.String, System.String>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial class JsonDynamicContract : Newtonsoft.Json.Serialization.JsonContract {
    public JsonDynamicContract(System.Type underlyingType) { }
    public Newtonsoft.Json.Serialization.JsonPropertyCollection Properties { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Newtonsoft.Json.Serialization.JsonPropertyCollection); } }
    public System.Func<System.String, System.String> PropertyNameResolver { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Func<System.String, System.String>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial class JsonISerializableContract : Newtonsoft.Json.Serialization.JsonContract {
    public JsonISerializableContract(System.Type underlyingType) { }
    public Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> ISerializableCreator { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Newtonsoft.Json.Serialization.ObjectConstructor<System.Object>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial class JsonLinqContract : Newtonsoft.Json.Serialization.JsonContract {
    public JsonLinqContract(System.Type underlyingType) { }
  }
  public partial class JsonObjectContract : Newtonsoft.Json.Serialization.JsonContract {
    public JsonObjectContract(System.Type underlyingType) { }
    public Newtonsoft.Json.Serialization.JsonPropertyCollection ConstructorParameters { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Newtonsoft.Json.Serialization.JsonPropertyCollection); } }
    public Newtonsoft.Json.MemberSerialization MemberSerialization { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Newtonsoft.Json.MemberSerialization); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Reflection.ConstructorInfo OverrideConstructor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Reflection.ConstructorInfo); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Reflection.ConstructorInfo ParametrizedConstructor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Reflection.ConstructorInfo); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Newtonsoft.Json.Serialization.JsonPropertyCollection Properties { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Newtonsoft.Json.Serialization.JsonPropertyCollection); } }
  }
  public partial class JsonPrimitiveContract : Newtonsoft.Json.Serialization.JsonContract {
    public JsonPrimitiveContract(System.Type underlyingType) { }
  }
  public partial class JsonProperty {
    public JsonProperty() { }
    public Newtonsoft.Json.JsonConverter Converter { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Newtonsoft.Json.JsonConverter); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Type DeclaringType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public object DefaultValue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Nullable<Newtonsoft.Json.DefaultValueHandling> DefaultValueHandling { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<Newtonsoft.Json.DefaultValueHandling>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Predicate<System.Object> GetIsSpecified { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Predicate<System.Object>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool Ignored { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Nullable<System.Boolean> IsReference { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.Boolean>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Newtonsoft.Json.JsonConverter MemberConverter { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Newtonsoft.Json.JsonConverter); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Nullable<Newtonsoft.Json.NullValueHandling> NullValueHandling { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<Newtonsoft.Json.NullValueHandling>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Nullable<Newtonsoft.Json.ObjectCreationHandling> ObjectCreationHandling { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<Newtonsoft.Json.ObjectCreationHandling>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Nullable<System.Int32> Order { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.Int32>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string PropertyName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Type PropertyType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool Readable { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> ReferenceLoopHandling { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<Newtonsoft.Json.ReferenceLoopHandling>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Newtonsoft.Json.Required Required { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Newtonsoft.Json.Required); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Action<System.Object, System.Object> SetIsSpecified { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Action<System.Object, System.Object>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Predicate<System.Object> ShouldSerialize { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Predicate<System.Object>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Nullable<Newtonsoft.Json.TypeNameHandling> TypeNameHandling { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<Newtonsoft.Json.TypeNameHandling>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string UnderlyingName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Newtonsoft.Json.Serialization.IValueProvider ValueProvider { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Newtonsoft.Json.Serialization.IValueProvider); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool Writable { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override string ToString() { return default(string); }
  }
  public partial class JsonPropertyCollection : System.Collections.ObjectModel.KeyedCollection<System.String, Newtonsoft.Json.Serialization.JsonProperty> {
    public JsonPropertyCollection(System.Type type) { }
    public void AddProperty(Newtonsoft.Json.Serialization.JsonProperty property) { }
    public Newtonsoft.Json.Serialization.JsonProperty GetClosestMatchProperty(string propertyName) { return default(Newtonsoft.Json.Serialization.JsonProperty); }
    protected override string GetKeyForItem(Newtonsoft.Json.Serialization.JsonProperty item) { return default(string); }
    public Newtonsoft.Json.Serialization.JsonProperty GetProperty(string propertyName, System.StringComparison comparisonType) { return default(Newtonsoft.Json.Serialization.JsonProperty); }
  }
  public partial class JsonStringContract : Newtonsoft.Json.Serialization.JsonPrimitiveContract {
    public JsonStringContract(System.Type underlyingType) : base (default(System.Type)) { }
  }
  public delegate object ObjectConstructor<T>(params System.Object[] args);
  [System.AttributeUsageAttribute((System.AttributeTargets)(64), Inherited=false)]
  public sealed partial class OnErrorAttribute : System.Attribute {
    public OnErrorAttribute() { }
  }
  public partial class ReflectionValueProvider : Newtonsoft.Json.Serialization.IValueProvider {
    public ReflectionValueProvider(System.Reflection.MemberInfo memberInfo) { }
    public object GetValue(object target) { return default(object); }
    public void SetValue(object target, object value) { }
  }
}
namespace System.Net.Http {
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public static partial class HttpClientExtensions {
    public static System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PostAsJsonAsync<T>(this System.Net.Http.HttpClient client, string requestUri, T value) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>); }
    public static System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PostAsJsonAsync<T>(this System.Net.Http.HttpClient client, string requestUri, T value, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>); }
    public static System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PostAsXmlAsync<T>(this System.Net.Http.HttpClient client, string requestUri, T value) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>); }
    public static System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PostAsXmlAsync<T>(this System.Net.Http.HttpClient client, string requestUri, T value, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>); }
    public static System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PostAsync<T>(this System.Net.Http.HttpClient client, string requestUri, T value, System.Net.Http.Formatting.MediaTypeFormatter formatter) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>); }
    public static System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PostAsync<T>(this System.Net.Http.HttpClient client, string requestUri, T value, System.Net.Http.Formatting.MediaTypeFormatter formatter, string mediaType) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>); }
    public static System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PostAsync<T>(this System.Net.Http.HttpClient client, string requestUri, T value, System.Net.Http.Formatting.MediaTypeFormatter formatter, string mediaType, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>); }
    public static System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PostAsync<T>(this System.Net.Http.HttpClient client, string requestUri, T value, System.Net.Http.Formatting.MediaTypeFormatter formatter, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>); }
    public static System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PutAsJsonAsync<T>(this System.Net.Http.HttpClient client, string requestUri, T value) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>); }
    public static System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PutAsJsonAsync<T>(this System.Net.Http.HttpClient client, string requestUri, T value, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>); }
    public static System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PutAsXmlAsync<T>(this System.Net.Http.HttpClient client, string requestUri, T value) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>); }
    public static System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PutAsXmlAsync<T>(this System.Net.Http.HttpClient client, string requestUri, T value, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>); }
    public static System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PutAsync<T>(this System.Net.Http.HttpClient client, string requestUri, T value, System.Net.Http.Formatting.MediaTypeFormatter formatter) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>); }
    public static System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PutAsync<T>(this System.Net.Http.HttpClient client, string requestUri, T value, System.Net.Http.Formatting.MediaTypeFormatter formatter, string mediaType) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>); }
    public static System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PutAsync<T>(this System.Net.Http.HttpClient client, string requestUri, T value, System.Net.Http.Formatting.MediaTypeFormatter formatter, string mediaType, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>); }
    public static System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PutAsync<T>(this System.Net.Http.HttpClient client, string requestUri, T value, System.Net.Http.Formatting.MediaTypeFormatter formatter, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public static partial class HttpContentCollectionExtensions {
    public static System.Collections.Generic.IEnumerable<System.Net.Http.HttpContent> FindAllContentType(this System.Collections.Generic.IEnumerable<System.Net.Http.HttpContent> contents, System.Net.Http.Headers.MediaTypeHeaderValue contentType) { return default(System.Collections.Generic.IEnumerable<System.Net.Http.HttpContent>); }
    public static System.Collections.Generic.IEnumerable<System.Net.Http.HttpContent> FindAllContentType(this System.Collections.Generic.IEnumerable<System.Net.Http.HttpContent> contents, string contentType) { return default(System.Collections.Generic.IEnumerable<System.Net.Http.HttpContent>); }
    public static System.Net.Http.HttpContent FirstDispositionName(this System.Collections.Generic.IEnumerable<System.Net.Http.HttpContent> contents, string dispositionName) { return default(System.Net.Http.HttpContent); }
    public static System.Net.Http.HttpContent FirstDispositionNameOrDefault(this System.Collections.Generic.IEnumerable<System.Net.Http.HttpContent> contents, string dispositionName) { return default(System.Net.Http.HttpContent); }
    public static System.Net.Http.HttpContent FirstDispositionType(this System.Collections.Generic.IEnumerable<System.Net.Http.HttpContent> contents, string dispositionType) { return default(System.Net.Http.HttpContent); }
    public static System.Net.Http.HttpContent FirstDispositionTypeOrDefault(this System.Collections.Generic.IEnumerable<System.Net.Http.HttpContent> contents, string dispositionType) { return default(System.Net.Http.HttpContent); }
    public static System.Net.Http.HttpContent FirstStart(this System.Collections.Generic.IEnumerable<System.Net.Http.HttpContent> contents, string start) { return default(System.Net.Http.HttpContent); }
    public static System.Net.Http.HttpContent FirstStartOrDefault(this System.Collections.Generic.IEnumerable<System.Net.Http.HttpContent> contents, string start) { return default(System.Net.Http.HttpContent); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public static partial class HttpContentExtensions {
    public static System.Threading.Tasks.Task<System.Object> ReadAsAsync(this System.Net.Http.HttpContent content, System.Type type) { return default(System.Threading.Tasks.Task<System.Object>); }
    public static System.Threading.Tasks.Task<System.Object> ReadAsAsync(this System.Net.Http.HttpContent content, System.Type type, System.Collections.Generic.IEnumerable<System.Net.Http.Formatting.MediaTypeFormatter> formatters) { return default(System.Threading.Tasks.Task<System.Object>); }
    public static System.Threading.Tasks.Task<System.Object> ReadAsAsync(this System.Net.Http.HttpContent content, System.Type type, System.Collections.Generic.IEnumerable<System.Net.Http.Formatting.MediaTypeFormatter> formatters, System.Net.Http.Formatting.IFormatterLogger formatterLogger) { return default(System.Threading.Tasks.Task<System.Object>); }
    public static System.Threading.Tasks.Task<T> ReadAsAsync<T>(this System.Net.Http.HttpContent content) { return default(System.Threading.Tasks.Task<T>); }
    public static System.Threading.Tasks.Task<T> ReadAsAsync<T>(this System.Net.Http.HttpContent content, System.Collections.Generic.IEnumerable<System.Net.Http.Formatting.MediaTypeFormatter> formatters) { return default(System.Threading.Tasks.Task<T>); }
    public static System.Threading.Tasks.Task<T> ReadAsAsync<T>(this System.Net.Http.HttpContent content, System.Collections.Generic.IEnumerable<System.Net.Http.Formatting.MediaTypeFormatter> formatters, System.Net.Http.Formatting.IFormatterLogger formatterLogger) { return default(System.Threading.Tasks.Task<T>); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public static partial class HttpContentMessageExtensions {
    public static bool IsHttpRequestMessageContent(this System.Net.Http.HttpContent content) { return default(bool); }
    public static bool IsHttpResponseMessageContent(this System.Net.Http.HttpContent content) { return default(bool); }
    public static System.Threading.Tasks.Task<System.Net.Http.HttpRequestMessage> ReadAsHttpRequestMessageAsync(this System.Net.Http.HttpContent content) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpRequestMessage>); }
    public static System.Threading.Tasks.Task<System.Net.Http.HttpRequestMessage> ReadAsHttpRequestMessageAsync(this System.Net.Http.HttpContent content, string uriScheme) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpRequestMessage>); }
    public static System.Threading.Tasks.Task<System.Net.Http.HttpRequestMessage> ReadAsHttpRequestMessageAsync(this System.Net.Http.HttpContent content, string uriScheme, int bufferSize) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpRequestMessage>); }
    public static System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> ReadAsHttpResponseMessageAsync(this System.Net.Http.HttpContent content) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>); }
    public static System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> ReadAsHttpResponseMessageAsync(this System.Net.Http.HttpContent content, int bufferSize) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public static partial class HttpContentMultipartExtensions {
    public static bool IsMimeMultipartContent(this System.Net.Http.HttpContent content) { return default(bool); }
    public static bool IsMimeMultipartContent(this System.Net.Http.HttpContent content, string subtype) { return default(bool); }
    public static System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<System.Net.Http.HttpContent>> ReadAsMultipartAsync(this System.Net.Http.HttpContent content) { return default(System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<System.Net.Http.HttpContent>>); }
    public static System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<System.Net.Http.HttpContent>> ReadAsMultipartAsync(this System.Net.Http.HttpContent content, System.Net.Http.IMultipartStreamProvider streamProvider) { return default(System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<System.Net.Http.HttpContent>>); }
    public static System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<System.Net.Http.HttpContent>> ReadAsMultipartAsync(this System.Net.Http.HttpContent content, System.Net.Http.IMultipartStreamProvider streamProvider, int bufferSize) { return default(System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<System.Net.Http.HttpContent>>); }
  }
  public partial class HttpMessageContent : System.Net.Http.HttpContent {
    public HttpMessageContent(System.Net.Http.HttpRequestMessage httpRequest) { }
    public HttpMessageContent(System.Net.Http.HttpResponseMessage httpResponse) { }
    public System.Net.Http.HttpRequestMessage HttpRequestMessage { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Net.Http.HttpRequestMessage); } }
    public System.Net.Http.HttpResponseMessage HttpResponseMessage { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Net.Http.HttpResponseMessage); } }
    protected override void Dispose(bool disposing) { }
    protected override System.Threading.Tasks.Task SerializeToStreamAsync(System.IO.Stream stream, System.Net.TransportContext context) { return default(System.Threading.Tasks.Task); }
    protected override bool TryComputeLength(out long length) { length = default(long); return default(bool); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public static partial class HttpRequestHeadersExtensions {
    public static System.Collections.ObjectModel.Collection<System.Net.Http.Headers.CookieHeaderValue> GetCookies(this System.Net.Http.Headers.HttpRequestHeaders headers) { return default(System.Collections.ObjectModel.Collection<System.Net.Http.Headers.CookieHeaderValue>); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public static partial class HttpRequestMessageExtensions {
    public static System.Net.Http.HttpResponseMessage CreateResponse(this System.Net.Http.HttpRequestMessage request) { return default(System.Net.Http.HttpResponseMessage); }
    public static System.Net.Http.HttpResponseMessage CreateResponse(this System.Net.Http.HttpRequestMessage request, System.Net.HttpStatusCode statusCode) { return default(System.Net.Http.HttpResponseMessage); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public static partial class HttpResponseHeadersExtensions {
    public static void AddCookies(this System.Net.Http.Headers.HttpResponseHeaders headers, System.Collections.Generic.IEnumerable<System.Net.Http.Headers.CookieHeaderValue> cookies) { }
  }
  public partial interface IMultipartStreamProvider {
    System.IO.Stream GetStream(System.Net.Http.Headers.HttpContentHeaders headers);
  }
  public partial class MultipartFileStreamProvider : System.Net.Http.IMultipartStreamProvider {
    public MultipartFileStreamProvider(string rootPath) { }
    public MultipartFileStreamProvider(string rootPath, int bufferSize) { }
    public System.Collections.ObjectModel.Collection<System.String> BodyPartFileNames { get { return default(System.Collections.ObjectModel.Collection<System.String>); } }
    public virtual string GetLocalFileName(System.Net.Http.Headers.HttpContentHeaders headers) { return default(string); }
    public virtual System.IO.Stream GetStream(System.Net.Http.Headers.HttpContentHeaders headers) { return default(System.IO.Stream); }
  }
  public partial class MultipartFormDataStreamProvider : System.Net.Http.IMultipartStreamProvider {
    public MultipartFormDataStreamProvider(string rootPath) { }
    public MultipartFormDataStreamProvider(string rootPath, int bufferSize) { }
    public System.Collections.Generic.IDictionary<System.String, System.String> BodyPartFileNames { get { return default(System.Collections.Generic.IDictionary<System.String, System.String>); } }
    public virtual string GetLocalFileName(System.Net.Http.Headers.HttpContentHeaders headers) { return default(string); }
    public virtual System.IO.Stream GetStream(System.Net.Http.Headers.HttpContentHeaders headers) { return default(System.IO.Stream); }
  }
  public partial class ObjectContent : System.Net.Http.HttpContent {
    public ObjectContent(System.Type type, object value, System.Net.Http.Formatting.MediaTypeFormatter formatter) { }
    public ObjectContent(System.Type type, object value, System.Net.Http.Formatting.MediaTypeFormatter formatter, string mediaType) { }
    public System.Net.Http.Formatting.MediaTypeFormatter Formatter { get { return default(System.Net.Http.Formatting.MediaTypeFormatter); } }
    public System.Type ObjectType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } }
    public object Value { get { return default(object); } set { } }
    protected override System.Threading.Tasks.Task SerializeToStreamAsync(System.IO.Stream stream, System.Net.TransportContext context) { return default(System.Threading.Tasks.Task); }
    protected override bool TryComputeLength(out long length) { length = default(long); return default(bool); }
  }
  public partial class ObjectContent<T> : System.Net.Http.ObjectContent {
    public ObjectContent(T value, System.Net.Http.Formatting.MediaTypeFormatter formatter) : base (default(System.Type), default(object), default(System.Net.Http.Formatting.MediaTypeFormatter)) { }
    public ObjectContent(T value, System.Net.Http.Formatting.MediaTypeFormatter formatter, string mediaType) : base (default(System.Type), default(object), default(System.Net.Http.Formatting.MediaTypeFormatter)) { }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public static partial class UriExtensions {
    public static System.Collections.Specialized.NameValueCollection ParseQueryString(this System.Uri address) { return default(System.Collections.Specialized.NameValueCollection); }
    public static bool TryReadQueryAs(this System.Uri address, System.Type type, out object value) { value = default(object); return default(bool); }
    public static bool TryReadQueryAs<T>(this System.Uri address, out T value) { value = default(T); return default(bool); }
    public static bool TryReadQueryAsJson(this System.Uri address, out Newtonsoft.Json.Linq.JObject value) { value = default(Newtonsoft.Json.Linq.JObject); return default(bool); }
  }
}
namespace System.Net.Http.Formatting {
  public abstract partial class BufferedMediaTypeFormatter : System.Net.Http.Formatting.MediaTypeFormatter {
    protected BufferedMediaTypeFormatter() { }
    public int BufferSize { get { return default(int); } set { } }
    public virtual object ReadFromStream(System.Type type, System.IO.Stream stream, System.Net.Http.Headers.HttpContentHeaders contentHeaders, System.Net.Http.Formatting.IFormatterLogger formatterLogger) { return default(object); }
    public sealed override System.Threading.Tasks.Task<System.Object> ReadFromStreamAsync(System.Type type, System.IO.Stream stream, System.Net.Http.Headers.HttpContentHeaders contentHeaders, System.Net.Http.Formatting.IFormatterLogger formatterLogger) { return default(System.Threading.Tasks.Task<System.Object>); }
    public virtual void WriteToStream(System.Type type, object value, System.IO.Stream stream, System.Net.Http.Headers.HttpContentHeaders contentHeaders) { }
    public sealed override System.Threading.Tasks.Task WriteToStreamAsync(System.Type type, object value, System.IO.Stream stream, System.Net.Http.Headers.HttpContentHeaders contentHeaders, System.Net.TransportContext transportContext) { return default(System.Threading.Tasks.Task); }
  }
  public partial class ContentNegotiationResult {
    public ContentNegotiationResult(System.Net.Http.Formatting.MediaTypeFormatter formatter, System.Net.Http.Headers.MediaTypeHeaderValue mediaType) { }
    public System.Net.Http.Formatting.MediaTypeFormatter Formatter { get { return default(System.Net.Http.Formatting.MediaTypeFormatter); } set { } }
    public System.Net.Http.Headers.MediaTypeHeaderValue MediaType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Net.Http.Headers.MediaTypeHeaderValue); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial class DefaultContentNegotiator : System.Net.Http.Formatting.IContentNegotiator {
    public DefaultContentNegotiator() { }
    public virtual System.Net.Http.Formatting.ContentNegotiationResult Negotiate(System.Type type, System.Net.Http.HttpRequestMessage request, System.Collections.Generic.IEnumerable<System.Net.Http.Formatting.MediaTypeFormatter> formatters) { return default(System.Net.Http.Formatting.ContentNegotiationResult); }
  }
  public sealed partial class DelegatingEnumerable<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable {
    public DelegatingEnumerable() { }
    public DelegatingEnumerable(System.Collections.Generic.IEnumerable<T> source) { }
    public void Add(object item) { }
    public System.Collections.Generic.IEnumerator<T> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<T>); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public partial class FormDataCollection : System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.String>>, System.Collections.IEnumerable {
    public FormDataCollection(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.String>> pairs) { }
    public FormDataCollection(string query) { }
    public FormDataCollection(System.Uri uri) { }
    public string Get(string key) { return default(string); }
    public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String, System.String>> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String, System.String>>); }
    public System.String[] GetValues(string key) { return default(System.String[]); }
    public System.Collections.Specialized.NameValueCollection ReadAsNameValueCollection() { return default(System.Collections.Specialized.NameValueCollection); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public partial class FormUrlEncodedMediaTypeFormatter : System.Net.Http.Formatting.MediaTypeFormatter {
    public FormUrlEncodedMediaTypeFormatter() { }
    public static System.Net.Http.Headers.MediaTypeHeaderValue DefaultMediaType { get { return default(System.Net.Http.Headers.MediaTypeHeaderValue); } }
    public int MaxDepth { get { return default(int); } set { } }
    public int ReadBufferSize { get { return default(int); } set { } }
    public override bool CanReadType(System.Type type) { return default(bool); }
    public override bool CanWriteType(System.Type type) { return default(bool); }
    public override System.Threading.Tasks.Task<System.Object> ReadFromStreamAsync(System.Type type, System.IO.Stream stream, System.Net.Http.Headers.HttpContentHeaders contentHeaders, System.Net.Http.Formatting.IFormatterLogger formatterLogger) { return default(System.Threading.Tasks.Task<System.Object>); }
  }
  public partial interface IContentNegotiator {
    System.Net.Http.Formatting.ContentNegotiationResult Negotiate(System.Type type, System.Net.Http.HttpRequestMessage request, System.Collections.Generic.IEnumerable<System.Net.Http.Formatting.MediaTypeFormatter> formatters);
  }
  public partial interface IFormatterLogger {
    void LogError(string errorPath, string errorMessage);
  }
  public partial interface IRequiredMemberSelector {
    bool IsRequiredMember(System.Reflection.MemberInfo member);
  }
  public partial class JsonMediaTypeFormatter : System.Net.Http.Formatting.MediaTypeFormatter {
    public JsonMediaTypeFormatter() { }
    public static System.Net.Http.Headers.MediaTypeHeaderValue DefaultMediaType { get { return default(System.Net.Http.Headers.MediaTypeHeaderValue); } }
    public bool Indent { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public int MaxDepth { get { return default(int); } set { } }
    public Newtonsoft.Json.JsonSerializerSettings SerializerSettings { get { return default(Newtonsoft.Json.JsonSerializerSettings); } set { } }
    public bool UseDataContractJsonSerializer { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override bool CanReadType(System.Type type) { return default(bool); }
    public override bool CanWriteType(System.Type type) { return default(bool); }
    public Newtonsoft.Json.JsonSerializerSettings CreateDefaultSerializerSettings() { return default(Newtonsoft.Json.JsonSerializerSettings); }
    public override System.Threading.Tasks.Task<System.Object> ReadFromStreamAsync(System.Type type, System.IO.Stream stream, System.Net.Http.Headers.HttpContentHeaders contentHeaders, System.Net.Http.Formatting.IFormatterLogger formatterLogger) { return default(System.Threading.Tasks.Task<System.Object>); }
    public override System.Threading.Tasks.Task WriteToStreamAsync(System.Type type, object value, System.IO.Stream stream, System.Net.Http.Headers.HttpContentHeaders contentHeaders, System.Net.TransportContext transportContext) { return default(System.Threading.Tasks.Task); }
  }
  public partial class MediaRangeMapping : System.Net.Http.Formatting.MediaTypeMapping {
    public MediaRangeMapping(System.Net.Http.Headers.MediaTypeHeaderValue mediaRange, System.Net.Http.Headers.MediaTypeHeaderValue mediaType) : base (default(System.Net.Http.Headers.MediaTypeHeaderValue)) { }
    public MediaRangeMapping(string mediaRange, string mediaType) : base (default(System.Net.Http.Headers.MediaTypeHeaderValue)) { }
    public System.Net.Http.Headers.MediaTypeHeaderValue MediaRange { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Net.Http.Headers.MediaTypeHeaderValue); } }
    public override double TryMatchMediaType(System.Net.Http.HttpRequestMessage request) { return default(double); }
  }
  public abstract partial class MediaTypeFormatter {
    protected MediaTypeFormatter() { }
    public static int MaxHttpCollectionKeys { get { return default(int); } set { } }
    public System.Collections.ObjectModel.Collection<System.Net.Http.Formatting.MediaTypeMapping> MediaTypeMappings { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.ObjectModel.Collection<System.Net.Http.Formatting.MediaTypeMapping>); } }
    public System.Net.Http.Formatting.IRequiredMemberSelector RequiredMemberSelector { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Net.Http.Formatting.IRequiredMemberSelector); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.ObjectModel.Collection<System.Text.Encoding> SupportedEncodings { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.ObjectModel.Collection<System.Text.Encoding>); } }
    public System.Collections.ObjectModel.Collection<System.Net.Http.Headers.MediaTypeHeaderValue> SupportedMediaTypes { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.ObjectModel.Collection<System.Net.Http.Headers.MediaTypeHeaderValue>); } }
    public abstract bool CanReadType(System.Type type);
    public abstract bool CanWriteType(System.Type type);
    protected internal static object GetDefaultValueForType(System.Type type) { return default(object); }
    public virtual System.Net.Http.Formatting.MediaTypeFormatter GetPerRequestFormatterInstance(System.Type type, System.Net.Http.HttpRequestMessage request, System.Net.Http.Headers.MediaTypeHeaderValue mediaType) { return default(System.Net.Http.Formatting.MediaTypeFormatter); }
    public virtual System.Threading.Tasks.Task<System.Object> ReadFromStreamAsync(System.Type type, System.IO.Stream stream, System.Net.Http.Headers.HttpContentHeaders contentHeaders, System.Net.Http.Formatting.IFormatterLogger formatterLogger) { return default(System.Threading.Tasks.Task<System.Object>); }
    protected System.Text.Encoding SelectCharacterEncoding(System.Net.Http.Headers.HttpContentHeaders contentHeaders) { return default(System.Text.Encoding); }
    public virtual void SetDefaultContentHeaders(System.Type type, System.Net.Http.Headers.HttpContentHeaders headers, string mediaType) { }
    public virtual System.Threading.Tasks.Task WriteToStreamAsync(System.Type type, object value, System.IO.Stream stream, System.Net.Http.Headers.HttpContentHeaders contentHeaders, System.Net.TransportContext transportContext) { return default(System.Threading.Tasks.Task); }
  }
  public partial class MediaTypeFormatterCollection : System.Collections.ObjectModel.Collection<System.Net.Http.Formatting.MediaTypeFormatter> {
    public MediaTypeFormatterCollection() { }
    public MediaTypeFormatterCollection(System.Collections.Generic.IEnumerable<System.Net.Http.Formatting.MediaTypeFormatter> formatters) { }
    public System.Net.Http.Formatting.FormUrlEncodedMediaTypeFormatter FormUrlEncodedFormatter { get { return default(System.Net.Http.Formatting.FormUrlEncodedMediaTypeFormatter); } }
    public System.Net.Http.Formatting.JsonMediaTypeFormatter JsonFormatter { get { return default(System.Net.Http.Formatting.JsonMediaTypeFormatter); } }
    public System.Net.Http.Formatting.XmlMediaTypeFormatter XmlFormatter { get { return default(System.Net.Http.Formatting.XmlMediaTypeFormatter); } }
    public System.Net.Http.Formatting.MediaTypeFormatter FindReader(System.Type type, System.Net.Http.Headers.MediaTypeHeaderValue mediaType) { return default(System.Net.Http.Formatting.MediaTypeFormatter); }
    public System.Net.Http.Formatting.MediaTypeFormatter FindWriter(System.Type type, System.Net.Http.Headers.MediaTypeHeaderValue mediaType) { return default(System.Net.Http.Formatting.MediaTypeFormatter); }
    public static bool IsTypeExcludedFromValidation(System.Type type) { return default(bool); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public static partial class MediaTypeFormatterExtensions {
    public static void AddMediaRangeMapping(this System.Net.Http.Formatting.MediaTypeFormatter formatter, System.Net.Http.Headers.MediaTypeHeaderValue mediaRange, System.Net.Http.Headers.MediaTypeHeaderValue mediaType) { }
    public static void AddMediaRangeMapping(this System.Net.Http.Formatting.MediaTypeFormatter formatter, string mediaRange, string mediaType) { }
    public static void AddQueryStringMapping(this System.Net.Http.Formatting.MediaTypeFormatter formatter, string queryStringParameterName, string queryStringParameterValue, System.Net.Http.Headers.MediaTypeHeaderValue mediaType) { }
    public static void AddQueryStringMapping(this System.Net.Http.Formatting.MediaTypeFormatter formatter, string queryStringParameterName, string queryStringParameterValue, string mediaType) { }
    public static void AddRequestHeaderMapping(this System.Net.Http.Formatting.MediaTypeFormatter formatter, string headerName, string headerValue, System.StringComparison valueComparison, bool isValueSubstring, System.Net.Http.Headers.MediaTypeHeaderValue mediaType) { }
    public static void AddRequestHeaderMapping(this System.Net.Http.Formatting.MediaTypeFormatter formatter, string headerName, string headerValue, System.StringComparison valueComparison, bool isValueSubstring, string mediaType) { }
  }
  public abstract partial class MediaTypeMapping {
    protected MediaTypeMapping(System.Net.Http.Headers.MediaTypeHeaderValue mediaType) { }
    protected MediaTypeMapping(string mediaType) { }
    public System.Net.Http.Headers.MediaTypeHeaderValue MediaType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Net.Http.Headers.MediaTypeHeaderValue); } }
    public abstract double TryMatchMediaType(System.Net.Http.HttpRequestMessage request);
  }
  public partial class QueryStringMapping : System.Net.Http.Formatting.MediaTypeMapping {
    public QueryStringMapping(string queryStringParameterName, string queryStringParameterValue, System.Net.Http.Headers.MediaTypeHeaderValue mediaType) : base (default(System.Net.Http.Headers.MediaTypeHeaderValue)) { }
    public QueryStringMapping(string queryStringParameterName, string queryStringParameterValue, string mediaType) : base (default(System.Net.Http.Headers.MediaTypeHeaderValue)) { }
    public string QueryStringParameterName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string QueryStringParameterValue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public override double TryMatchMediaType(System.Net.Http.HttpRequestMessage request) { return default(double); }
  }
  public partial class RequestHeaderMapping : System.Net.Http.Formatting.MediaTypeMapping {
    public RequestHeaderMapping(string headerName, string headerValue, System.StringComparison valueComparison, bool isValueSubstring, System.Net.Http.Headers.MediaTypeHeaderValue mediaType) : base (default(System.Net.Http.Headers.MediaTypeHeaderValue)) { }
    public RequestHeaderMapping(string headerName, string headerValue, System.StringComparison valueComparison, bool isValueSubstring, string mediaType) : base (default(System.Net.Http.Headers.MediaTypeHeaderValue)) { }
    public string HeaderName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string HeaderValue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public System.StringComparison HeaderValueComparison { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.StringComparison); } }
    public bool IsValueSubstring { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    public override double TryMatchMediaType(System.Net.Http.HttpRequestMessage request) { return default(double); }
  }
  public partial class XmlMediaTypeFormatter : System.Net.Http.Formatting.MediaTypeFormatter {
    public XmlMediaTypeFormatter() { }
    public static System.Net.Http.Headers.MediaTypeHeaderValue DefaultMediaType { get { return default(System.Net.Http.Headers.MediaTypeHeaderValue); } }
    public bool Indent { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public int MaxDepth { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool UseXmlSerializer { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override bool CanReadType(System.Type type) { return default(bool); }
    public override bool CanWriteType(System.Type type) { return default(bool); }
    public override System.Threading.Tasks.Task<System.Object> ReadFromStreamAsync(System.Type type, System.IO.Stream stream, System.Net.Http.Headers.HttpContentHeaders contentHeaders, System.Net.Http.Formatting.IFormatterLogger formatterLogger) { return default(System.Threading.Tasks.Task<System.Object>); }
    public bool RemoveSerializer(System.Type type) { return default(bool); }
    public void SetSerializer(System.Type type, System.Runtime.Serialization.XmlObjectSerializer serializer) { }
    public void SetSerializer(System.Type type, System.Xml.Serialization.XmlSerializer serializer) { }
    public void SetSerializer<T>(System.Runtime.Serialization.XmlObjectSerializer serializer) { }
    public void SetSerializer<T>(System.Xml.Serialization.XmlSerializer serializer) { }
    public override System.Threading.Tasks.Task WriteToStreamAsync(System.Type type, object value, System.IO.Stream stream, System.Net.Http.Headers.HttpContentHeaders contentHeaders, System.Net.TransportContext transportContext) { return default(System.Threading.Tasks.Task); }
  }
}
namespace System.Net.Http.Headers {
  public partial class CookieHeaderValue : System.ICloneable {
    protected CookieHeaderValue() { }
    public CookieHeaderValue(string name, System.Collections.Specialized.NameValueCollection values) { }
    public CookieHeaderValue(string name, string value) { }
    public System.Collections.ObjectModel.Collection<System.Net.Http.Headers.CookieState> Cookies { get { return default(System.Collections.ObjectModel.Collection<System.Net.Http.Headers.CookieState>); } }
    public string Domain { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Nullable<System.DateTimeOffset> Expires { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.DateTimeOffset>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool HttpOnly { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Net.Http.Headers.CookieState this[string name] { get { return default(System.Net.Http.Headers.CookieState); } }
    public System.Nullable<System.TimeSpan> MaxAge { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.TimeSpan>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Path { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool Secure { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public object Clone() { return default(object); }
    public override string ToString() { return default(string); }
    public static bool TryParse(string input, out System.Net.Http.Headers.CookieHeaderValue parsedValue) { parsedValue = default(System.Net.Http.Headers.CookieHeaderValue); return default(bool); }
  }
  public partial class CookieState : System.ICloneable {
    public CookieState(string name) { }
    public CookieState(string name, System.Collections.Specialized.NameValueCollection values) { }
    public CookieState(string name, string value) { }
    public string this[string name] { get { return default(string); } set { } }
    public string Name { get { return default(string); } set { } }
    public string Value { get { return default(string); } set { } }
    public System.Collections.Specialized.NameValueCollection Values { get { return default(System.Collections.Specialized.NameValueCollection); } }
    public object Clone() { return default(object); }
    public override string ToString() { return default(string); }
  }
}
