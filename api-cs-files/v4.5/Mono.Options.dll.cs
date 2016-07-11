namespace Mono.Options {
  public abstract partial class ArgumentSource {
    protected ArgumentSource() { }
    public abstract string Description { get; }
    public static System.Collections.Generic.IEnumerable<System.String> GetArguments(System.IO.TextReader reader) { return default(System.Collections.Generic.IEnumerable<System.String>); }
    public abstract bool GetArguments(string value, out System.Collections.Generic.IEnumerable<System.String> replacement);
    public static System.Collections.Generic.IEnumerable<System.String> GetArgumentsFromFile(string file) { return default(System.Collections.Generic.IEnumerable<System.String>); }
    public abstract System.String[] GetNames();
  }
  public abstract partial class Option {
    protected Option(string prototype, string description) { }
    protected Option(string prototype, string description, int maxValueCount) { }
    protected Option(string prototype, string description, int maxValueCount, bool hidden) { }
    public string Description { get { return default(string); } }
    public bool Hidden { get { return default(bool); } }
    public int MaxValueCount { get { return default(int); } }
    public Mono.Options.OptionValueType OptionValueType { get { return default(Mono.Options.OptionValueType); } }
    public string Prototype { get { return default(string); } }
    public System.String[] GetNames() { return default(System.String[]); }
    public System.String[] GetValueSeparators() { return default(System.String[]); }
    public void Invoke(Mono.Options.OptionContext c) { }
    protected abstract void OnParseComplete(Mono.Options.OptionContext c);
    protected static T Parse<T>(string value, Mono.Options.OptionContext c) { return default(T); }
    public override string ToString() { return default(string); }
  }
  public delegate void OptionAction<TKey, TValue>(TKey key, TValue value);
  public partial class OptionContext {
    public OptionContext(Mono.Options.OptionSet @set) { }
    public Mono.Options.Option Option { get { return default(Mono.Options.Option); } set { } }
    public int OptionIndex { get { return default(int); } set { } }
    public string OptionName { get { return default(string); } set { } }
    public Mono.Options.OptionSet OptionSet { get { return default(Mono.Options.OptionSet); } }
    public Mono.Options.OptionValueCollection OptionValues { get { return default(Mono.Options.OptionValueCollection); } }
  }
  public partial class OptionException : System.Exception {
    public OptionException() { }
    protected OptionException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public OptionException(string message, string optionName) { }
    public OptionException(string message, string optionName, System.Exception innerException) { }
    public string OptionName { get { return default(string); } }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, SerializationFormatter=true)]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial class OptionSet : System.Collections.ObjectModel.KeyedCollection<System.String, Mono.Options.Option> {
    public OptionSet() { }
    public OptionSet(System.Converter<System.String, System.String> localizer) { }
    public System.Collections.ObjectModel.ReadOnlyCollection<Mono.Options.ArgumentSource> ArgumentSources { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<Mono.Options.ArgumentSource>); } }
    public System.Converter<System.String, System.String> MessageLocalizer { get { return default(System.Converter<System.String, System.String>); } }
    public Mono.Options.OptionSet Add(Mono.Options.ArgumentSource source) { return default(Mono.Options.OptionSet); }
    public new Mono.Options.OptionSet Add(Mono.Options.Option option) { return default(Mono.Options.OptionSet); }
    public Mono.Options.OptionSet Add(string header) { return default(Mono.Options.OptionSet); }
    public Mono.Options.OptionSet Add(string prototype, Mono.Options.OptionAction<System.String, System.String> action) { return default(Mono.Options.OptionSet); }
    public Mono.Options.OptionSet Add(string prototype, System.Action<System.String> action) { return default(Mono.Options.OptionSet); }
    public Mono.Options.OptionSet Add(string prototype, string description, Mono.Options.OptionAction<System.String, System.String> action) { return default(Mono.Options.OptionSet); }
    public Mono.Options.OptionSet Add(string prototype, string description, Mono.Options.OptionAction<System.String, System.String> action, bool hidden) { return default(Mono.Options.OptionSet); }
    public Mono.Options.OptionSet Add(string prototype, string description, System.Action<System.String> action) { return default(Mono.Options.OptionSet); }
    public Mono.Options.OptionSet Add(string prototype, string description, System.Action<System.String> action, bool hidden) { return default(Mono.Options.OptionSet); }
    public Mono.Options.OptionSet Add<T>(string prototype, System.Action<T> action) { return default(Mono.Options.OptionSet); }
    public Mono.Options.OptionSet Add<T>(string prototype, string description, System.Action<T> action) { return default(Mono.Options.OptionSet); }
    public Mono.Options.OptionSet Add<TKey, TValue>(string prototype, Mono.Options.OptionAction<TKey, TValue> action) { return default(Mono.Options.OptionSet); }
    public Mono.Options.OptionSet Add<TKey, TValue>(string prototype, string description, Mono.Options.OptionAction<TKey, TValue> action) { return default(Mono.Options.OptionSet); }
    protected virtual Mono.Options.OptionContext CreateOptionContext() { return default(Mono.Options.OptionContext); }
    protected override string GetKeyForItem(Mono.Options.Option item) { return default(string); }
    [System.ObsoleteAttribute("Use KeyedCollection.this[string]")]
    protected Mono.Options.Option GetOptionForName(string option) { return default(Mono.Options.Option); }
    protected bool GetOptionParts(string argument, out string flag, out string name, out string sep, out string value) { flag = default(string); name = default(string); sep = default(string); value = default(string); return default(bool); }
    protected override void InsertItem(int index, Mono.Options.Option item) { }
    public System.Collections.Generic.List<System.String> Parse(System.Collections.Generic.IEnumerable<System.String> arguments) { return default(System.Collections.Generic.List<System.String>); }
    protected virtual bool Parse(string argument, Mono.Options.OptionContext c) { return default(bool); }
    protected override void RemoveItem(int index) { }
    protected override void SetItem(int index, Mono.Options.Option item) { }
    public void WriteOptionDescriptions(System.IO.TextWriter o) { }
  }
  public partial class OptionValueCollection : System.Collections.Generic.ICollection<System.String>, System.Collections.Generic.IEnumerable<System.String>, System.Collections.Generic.IList<System.String>, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList {
    internal OptionValueCollection() { }
    public int Count { get { return default(int); } }
    public bool IsReadOnly { get { return default(bool); } }
    public string this[int index] { get { return default(string); } set { } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    bool System.Collections.IList.IsFixedSize { get { return default(bool); } }
    object System.Collections.IList.this[int index] { get { return default(object); } set { } }
    public void Add(string item) { }
    public void Clear() { }
    public bool Contains(string item) { return default(bool); }
    public void CopyTo(System.String[] array, int arrayIndex) { }
    public System.Collections.Generic.IEnumerator<System.String> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.String>); }
    public int IndexOf(string item) { return default(int); }
    public void Insert(int index, string item) { }
    public bool Remove(string item) { return default(bool); }
    public void RemoveAt(int index) { }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    int System.Collections.IList.Add(object value) { return default(int); }
    bool System.Collections.IList.Contains(object value) { return default(bool); }
    int System.Collections.IList.IndexOf(object value) { return default(int); }
    void System.Collections.IList.Insert(int index, object value) { }
    void System.Collections.IList.Remove(object value) { }
    void System.Collections.IList.RemoveAt(int index) { }
    public System.String[] ToArray() { return default(System.String[]); }
    public System.Collections.Generic.List<System.String> ToList() { return default(System.Collections.Generic.List<System.String>); }
    public override string ToString() { return default(string); }
  }
  public enum OptionValueType {
    None = 0,
    Optional = 1,
    Required = 2,
  }
  public partial class ResponseFileSource : Mono.Options.ArgumentSource {
    public ResponseFileSource() { }
    public override string Description { get { return default(string); } }
    public override bool GetArguments(string value, out System.Collections.Generic.IEnumerable<System.String> replacement) { replacement = default(System.Collections.Generic.IEnumerable<System.String>); return default(bool); }
    public override System.String[] GetNames() { return default(System.String[]); }
  }
}
