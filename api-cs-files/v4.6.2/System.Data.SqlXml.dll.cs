namespace System.Xml.Xsl.Runtime {
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct AncestorDocOrderIterator {
    public System.Xml.XPath.XPathNavigator Current { get { return default(System.Xml.XPath.XPathNavigator); } }
    public void Create(System.Xml.XPath.XPathNavigator context, System.Xml.Xsl.Runtime.XmlNavigatorFilter filter, bool orSelf) { }
    public bool MoveNext() { return default(bool); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct AncestorIterator {
    public System.Xml.XPath.XPathNavigator Current { get { return default(System.Xml.XPath.XPathNavigator); } }
    public void Create(System.Xml.XPath.XPathNavigator context, System.Xml.Xsl.Runtime.XmlNavigatorFilter filter, bool orSelf) { }
    public bool MoveNext() { return default(bool); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct AttributeContentIterator {
    public System.Xml.XPath.XPathNavigator Current { get { return default(System.Xml.XPath.XPathNavigator); } }
    public void Create(System.Xml.XPath.XPathNavigator context) { }
    public bool MoveNext() { return default(bool); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct AttributeIterator {
    public System.Xml.XPath.XPathNavigator Current { get { return default(System.Xml.XPath.XPathNavigator); } }
    public void Create(System.Xml.XPath.XPathNavigator context) { }
    public bool MoveNext() { return default(bool); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct ContentIterator {
    public System.Xml.XPath.XPathNavigator Current { get { return default(System.Xml.XPath.XPathNavigator); } }
    public void Create(System.Xml.XPath.XPathNavigator context) { }
    public bool MoveNext() { return default(bool); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct ContentMergeIterator {
    public System.Xml.XPath.XPathNavigator Current { get { return default(System.Xml.XPath.XPathNavigator); } }
    public void Create(System.Xml.Xsl.Runtime.XmlNavigatorFilter filter) { }
    public System.Xml.Xsl.Runtime.IteratorResult MoveNext(System.Xml.XPath.XPathNavigator input) { return default(System.Xml.Xsl.Runtime.IteratorResult); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct DecimalAggregator {
    public decimal AverageResult { get { return default(decimal); } }
    public bool IsEmpty { get { return default(bool); } }
    public decimal MaximumResult { get { return default(decimal); } }
    public decimal MinimumResult { get { return default(decimal); } }
    public decimal SumResult { get { return default(decimal); } }
    public void Average(decimal value) { }
    public void Create() { }
    public void Maximum(decimal value) { }
    public void Minimum(decimal value) { }
    public void Sum(decimal value) { }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct DescendantIterator {
    public System.Xml.XPath.XPathNavigator Current { get { return default(System.Xml.XPath.XPathNavigator); } }
    public void Create(System.Xml.XPath.XPathNavigator input, System.Xml.Xsl.Runtime.XmlNavigatorFilter filter, bool orSelf) { }
    public bool MoveNext() { return default(bool); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct DescendantMergeIterator {
    public System.Xml.XPath.XPathNavigator Current { get { return default(System.Xml.XPath.XPathNavigator); } }
    public void Create(System.Xml.Xsl.Runtime.XmlNavigatorFilter filter, bool orSelf) { }
    public System.Xml.Xsl.Runtime.IteratorResult MoveNext(System.Xml.XPath.XPathNavigator input) { return default(System.Xml.Xsl.Runtime.IteratorResult); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct DifferenceIterator {
    public System.Xml.XPath.XPathNavigator Current { get { return default(System.Xml.XPath.XPathNavigator); } }
    public void Create(System.Xml.Xsl.Runtime.XmlQueryRuntime runtime) { }
    public System.Xml.Xsl.Runtime.SetIteratorResult MoveNext(System.Xml.XPath.XPathNavigator nestedNavigator) { return default(System.Xml.Xsl.Runtime.SetIteratorResult); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct DodSequenceMerge {
    public void AddSequence(System.Collections.Generic.IList<System.Xml.XPath.XPathNavigator> sequence) { }
    public void Create(System.Xml.Xsl.Runtime.XmlQueryRuntime runtime) { }
    public System.Collections.Generic.IList<System.Xml.XPath.XPathNavigator> MergeSequences() { return default(System.Collections.Generic.IList<System.Xml.XPath.XPathNavigator>); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct DoubleAggregator {
    public double AverageResult { get { return default(double); } }
    public bool IsEmpty { get { return default(bool); } }
    public double MaximumResult { get { return default(double); } }
    public double MinimumResult { get { return default(double); } }
    public double SumResult { get { return default(double); } }
    public void Average(double value) { }
    public void Create() { }
    public void Maximum(double value) { }
    public void Minimum(double value) { }
    public void Sum(double value) { }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct ElementContentIterator {
    public System.Xml.XPath.XPathNavigator Current { get { return default(System.Xml.XPath.XPathNavigator); } }
    public void Create(System.Xml.XPath.XPathNavigator context, string localName, string ns) { }
    public bool MoveNext() { return default(bool); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct FollowingSiblingIterator {
    public System.Xml.XPath.XPathNavigator Current { get { return default(System.Xml.XPath.XPathNavigator); } }
    public void Create(System.Xml.XPath.XPathNavigator context, System.Xml.Xsl.Runtime.XmlNavigatorFilter filter) { }
    public bool MoveNext() { return default(bool); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct FollowingSiblingMergeIterator {
    public System.Xml.XPath.XPathNavigator Current { get { return default(System.Xml.XPath.XPathNavigator); } }
    public void Create(System.Xml.Xsl.Runtime.XmlNavigatorFilter filter) { }
    public System.Xml.Xsl.Runtime.IteratorResult MoveNext(System.Xml.XPath.XPathNavigator navigator) { return default(System.Xml.Xsl.Runtime.IteratorResult); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct IdIterator {
    public System.Xml.XPath.XPathNavigator Current { get { return default(System.Xml.XPath.XPathNavigator); } }
    public void Create(System.Xml.XPath.XPathNavigator context, string value) { }
    public bool MoveNext() { return default(bool); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Int32Aggregator {
    public int AverageResult { get { return default(int); } }
    public bool IsEmpty { get { return default(bool); } }
    public int MaximumResult { get { return default(int); } }
    public int MinimumResult { get { return default(int); } }
    public int SumResult { get { return default(int); } }
    public void Average(int value) { }
    public void Create() { }
    public void Maximum(int value) { }
    public void Minimum(int value) { }
    public void Sum(int value) { }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Int64Aggregator {
    public long AverageResult { get { return default(long); } }
    public bool IsEmpty { get { return default(bool); } }
    public long MaximumResult { get { return default(long); } }
    public long MinimumResult { get { return default(long); } }
    public long SumResult { get { return default(long); } }
    public void Average(long value) { }
    public void Create() { }
    public void Maximum(long value) { }
    public void Minimum(long value) { }
    public void Sum(long value) { }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct IntersectIterator {
    public System.Xml.XPath.XPathNavigator Current { get { return default(System.Xml.XPath.XPathNavigator); } }
    public void Create(System.Xml.Xsl.Runtime.XmlQueryRuntime runtime) { }
    public System.Xml.Xsl.Runtime.SetIteratorResult MoveNext(System.Xml.XPath.XPathNavigator nestedNavigator) { return default(System.Xml.Xsl.Runtime.SetIteratorResult); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public enum IteratorResult {
    HaveCurrentNode = 2,
    NeedInputNode = 1,
    NoMoreNodes = 0,
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct NamespaceIterator {
    public System.Xml.XPath.XPathNavigator Current { get { return default(System.Xml.XPath.XPathNavigator); } }
    public void Create(System.Xml.XPath.XPathNavigator context) { }
    public bool MoveNext() { return default(bool); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct NodeKindContentIterator {
    public System.Xml.XPath.XPathNavigator Current { get { return default(System.Xml.XPath.XPathNavigator); } }
    public void Create(System.Xml.XPath.XPathNavigator context, System.Xml.XPath.XPathNodeType nodeType) { }
    public bool MoveNext() { return default(bool); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct NodeRangeIterator {
    public System.Xml.XPath.XPathNavigator Current { get { return default(System.Xml.XPath.XPathNavigator); } }
    public void Create(System.Xml.XPath.XPathNavigator start, System.Xml.Xsl.Runtime.XmlNavigatorFilter filter, System.Xml.XPath.XPathNavigator end) { }
    public bool MoveNext() { return default(bool); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct ParentIterator {
    public System.Xml.XPath.XPathNavigator Current { get { return default(System.Xml.XPath.XPathNavigator); } }
    public void Create(System.Xml.XPath.XPathNavigator context, System.Xml.Xsl.Runtime.XmlNavigatorFilter filter) { }
    public bool MoveNext() { return default(bool); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct PrecedingIterator {
    public System.Xml.XPath.XPathNavigator Current { get { return default(System.Xml.XPath.XPathNavigator); } }
    public void Create(System.Xml.XPath.XPathNavigator context, System.Xml.Xsl.Runtime.XmlNavigatorFilter filter) { }
    public bool MoveNext() { return default(bool); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct PrecedingSiblingDocOrderIterator {
    public System.Xml.XPath.XPathNavigator Current { get { return default(System.Xml.XPath.XPathNavigator); } }
    public void Create(System.Xml.XPath.XPathNavigator context, System.Xml.Xsl.Runtime.XmlNavigatorFilter filter) { }
    public bool MoveNext() { return default(bool); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct PrecedingSiblingIterator {
    public System.Xml.XPath.XPathNavigator Current { get { return default(System.Xml.XPath.XPathNavigator); } }
    public void Create(System.Xml.XPath.XPathNavigator context, System.Xml.Xsl.Runtime.XmlNavigatorFilter filter) { }
    public bool MoveNext() { return default(bool); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public enum SetIteratorResult {
    HaveCurrentNode = 4,
    InitRightIterator = 1,
    NeedLeftNode = 2,
    NeedRightNode = 3,
    NoMoreNodes = 0,
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct StringConcat {
    public string Delimiter { get { return default(string); } set { } }
    public void Clear() { }
    public void Concat(string value) { }
    public string GetResult() { return default(string); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct UnionIterator {
    public System.Xml.XPath.XPathNavigator Current { get { return default(System.Xml.XPath.XPathNavigator); } }
    public void Create(System.Xml.Xsl.Runtime.XmlQueryRuntime runtime) { }
    public System.Xml.Xsl.Runtime.SetIteratorResult MoveNext(System.Xml.XPath.XPathNavigator nestedNavigator) { return default(System.Xml.Xsl.Runtime.SetIteratorResult); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class XmlCollation {
    internal XmlCollation() { }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class XmlILIndex {
    internal XmlILIndex() { }
    public void Add(string key, System.Xml.XPath.XPathNavigator navigator) { }
    public System.Xml.Xsl.Runtime.XmlQueryNodeSequence Lookup(string key) { return default(System.Xml.Xsl.Runtime.XmlQueryNodeSequence); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public static partial class XmlILStorageConverter {
    public static System.Xml.Schema.XmlAtomicValue BooleanToAtomicValue(bool value, int index, System.Xml.Xsl.Runtime.XmlQueryRuntime runtime) { return default(System.Xml.Schema.XmlAtomicValue); }
    public static System.Xml.Schema.XmlAtomicValue BytesToAtomicValue(System.Byte[] value, int index, System.Xml.Xsl.Runtime.XmlQueryRuntime runtime) { return default(System.Xml.Schema.XmlAtomicValue); }
    public static System.Xml.Schema.XmlAtomicValue DateTimeToAtomicValue(System.DateTime value, int index, System.Xml.Xsl.Runtime.XmlQueryRuntime runtime) { return default(System.Xml.Schema.XmlAtomicValue); }
    public static System.Xml.Schema.XmlAtomicValue DecimalToAtomicValue(decimal value, int index, System.Xml.Xsl.Runtime.XmlQueryRuntime runtime) { return default(System.Xml.Schema.XmlAtomicValue); }
    public static System.Xml.Schema.XmlAtomicValue DoubleToAtomicValue(double value, int index, System.Xml.Xsl.Runtime.XmlQueryRuntime runtime) { return default(System.Xml.Schema.XmlAtomicValue); }
    public static System.Xml.Schema.XmlAtomicValue Int32ToAtomicValue(int value, int index, System.Xml.Xsl.Runtime.XmlQueryRuntime runtime) { return default(System.Xml.Schema.XmlAtomicValue); }
    public static System.Xml.Schema.XmlAtomicValue Int64ToAtomicValue(long value, int index, System.Xml.Xsl.Runtime.XmlQueryRuntime runtime) { return default(System.Xml.Schema.XmlAtomicValue); }
    public static System.Collections.Generic.IList<System.Xml.XPath.XPathNavigator> ItemsToNavigators(System.Collections.Generic.IList<System.Xml.XPath.XPathItem> listItems) { return default(System.Collections.Generic.IList<System.Xml.XPath.XPathNavigator>); }
    public static System.Collections.Generic.IList<System.Xml.XPath.XPathItem> NavigatorsToItems(System.Collections.Generic.IList<System.Xml.XPath.XPathNavigator> listNavigators) { return default(System.Collections.Generic.IList<System.Xml.XPath.XPathItem>); }
    public static System.Xml.Schema.XmlAtomicValue SingleToAtomicValue(float value, int index, System.Xml.Xsl.Runtime.XmlQueryRuntime runtime) { return default(System.Xml.Schema.XmlAtomicValue); }
    public static System.Xml.Schema.XmlAtomicValue StringToAtomicValue(string value, int index, System.Xml.Xsl.Runtime.XmlQueryRuntime runtime) { return default(System.Xml.Schema.XmlAtomicValue); }
    public static System.Xml.Schema.XmlAtomicValue TimeSpanToAtomicValue(System.TimeSpan value, int index, System.Xml.Xsl.Runtime.XmlQueryRuntime runtime) { return default(System.Xml.Schema.XmlAtomicValue); }
    public static System.Xml.Schema.XmlAtomicValue XmlQualifiedNameToAtomicValue(System.Xml.XmlQualifiedName value, int index, System.Xml.Xsl.Runtime.XmlQueryRuntime runtime) { return default(System.Xml.Schema.XmlAtomicValue); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public abstract partial class XmlNavigatorFilter {
    protected XmlNavigatorFilter() { }
    public abstract bool IsFiltered(System.Xml.XPath.XPathNavigator navigator);
    public abstract bool MoveToContent(System.Xml.XPath.XPathNavigator navigator);
    public abstract bool MoveToFollowing(System.Xml.XPath.XPathNavigator navigator, System.Xml.XPath.XPathNavigator navigatorEnd);
    public abstract bool MoveToFollowingSibling(System.Xml.XPath.XPathNavigator navigator);
    public abstract bool MoveToNextContent(System.Xml.XPath.XPathNavigator navigator);
    public abstract bool MoveToPreviousSibling(System.Xml.XPath.XPathNavigator navigator);
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class XmlQueryContext {
    internal XmlQueryContext() { }
    public System.Xml.XPath.XPathNavigator DefaultDataSource { get { return default(System.Xml.XPath.XPathNavigator); } }
    public System.Xml.XmlNameTable DefaultNameTable { get { return default(System.Xml.XmlNameTable); } }
    public System.Xml.XmlNameTable QueryNameTable { get { return default(System.Xml.XmlNameTable); } }
    public System.Xml.XPath.XPathNavigator GetDataSource(string uriRelative, string uriBase) { return default(System.Xml.XPath.XPathNavigator); }
    public object GetLateBoundObject(string namespaceUri) { return default(object); }
    public object GetParameter(string localName, string namespaceUri) { return default(object); }
    public System.Collections.Generic.IList<System.Xml.XPath.XPathItem> InvokeXsltLateBoundFunction(string name, string namespaceUri, System.Collections.Generic.IList<System.Xml.XPath.XPathItem>[] args) { return default(System.Collections.Generic.IList<System.Xml.XPath.XPathItem>); }
    public bool LateBoundFunctionExists(string name, string namespaceUri) { return default(bool); }
    public void OnXsltMessageEncountered(string message) { }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class XmlQueryItemSequence : System.Xml.Xsl.Runtime.XmlQuerySequence<System.Xml.XPath.XPathItem> {
    public static readonly new System.Xml.Xsl.Runtime.XmlQueryItemSequence Empty;
    public XmlQueryItemSequence() { }
    public XmlQueryItemSequence(int capacity) { }
    public XmlQueryItemSequence(System.Xml.XPath.XPathItem item) { }
    public void AddClone(System.Xml.XPath.XPathItem item) { }
    public static System.Xml.Xsl.Runtime.XmlQueryItemSequence CreateOrReuse(System.Xml.Xsl.Runtime.XmlQueryItemSequence seq) { return default(System.Xml.Xsl.Runtime.XmlQueryItemSequence); }
    public static System.Xml.Xsl.Runtime.XmlQueryItemSequence CreateOrReuse(System.Xml.Xsl.Runtime.XmlQueryItemSequence seq, System.Xml.XPath.XPathItem item) { return default(System.Xml.Xsl.Runtime.XmlQueryItemSequence); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class XmlQueryNodeSequence : System.Xml.Xsl.Runtime.XmlQuerySequence<System.Xml.XPath.XPathNavigator>, System.Collections.Generic.ICollection<System.Xml.XPath.XPathItem>, System.Collections.Generic.IEnumerable<System.Xml.XPath.XPathItem>, System.Collections.Generic.IList<System.Xml.XPath.XPathItem>, System.Collections.IEnumerable {
    public static readonly new System.Xml.Xsl.Runtime.XmlQueryNodeSequence Empty;
    public XmlQueryNodeSequence() { }
    public XmlQueryNodeSequence(System.Collections.Generic.IList<System.Xml.XPath.XPathNavigator> list) { }
    public XmlQueryNodeSequence(int capacity) { }
    public XmlQueryNodeSequence(System.Xml.XPath.XPathNavigator navigator) { }
    public XmlQueryNodeSequence(System.Xml.XPath.XPathNavigator[] array, int size) { }
    public bool IsDocOrderDistinct { get { return default(bool); } set { } }
    bool System.Collections.Generic.ICollection<System.Xml.XPath.XPathItem>.IsReadOnly { get { return default(bool); } }
    System.Xml.XPath.XPathItem System.Collections.Generic.IList<System.Xml.XPath.XPathItem>.this[int index] { get { return default(System.Xml.XPath.XPathItem); } set { } }
    public void AddClone(System.Xml.XPath.XPathNavigator navigator) { }
    public static System.Xml.Xsl.Runtime.XmlQueryNodeSequence CreateOrReuse(System.Xml.Xsl.Runtime.XmlQueryNodeSequence seq) { return default(System.Xml.Xsl.Runtime.XmlQueryNodeSequence); }
    public static System.Xml.Xsl.Runtime.XmlQueryNodeSequence CreateOrReuse(System.Xml.Xsl.Runtime.XmlQueryNodeSequence seq, System.Xml.XPath.XPathNavigator navigator) { return default(System.Xml.Xsl.Runtime.XmlQueryNodeSequence); }
    public System.Xml.Xsl.Runtime.XmlQueryNodeSequence DocOrderDistinct(System.Collections.Generic.IComparer<System.Xml.XPath.XPathNavigator> comparer) { return default(System.Xml.Xsl.Runtime.XmlQueryNodeSequence); }
    protected override void OnItemsChanged() { }
    void System.Collections.Generic.ICollection<System.Xml.XPath.XPathItem>.Add(System.Xml.XPath.XPathItem value) { }
    void System.Collections.Generic.ICollection<System.Xml.XPath.XPathItem>.Clear() { }
    bool System.Collections.Generic.ICollection<System.Xml.XPath.XPathItem>.Contains(System.Xml.XPath.XPathItem value) { return default(bool); }
    void System.Collections.Generic.ICollection<System.Xml.XPath.XPathItem>.CopyTo(System.Xml.XPath.XPathItem[] array, int index) { }
    bool System.Collections.Generic.ICollection<System.Xml.XPath.XPathItem>.Remove(System.Xml.XPath.XPathItem value) { return default(bool); }
    System.Collections.Generic.IEnumerator<System.Xml.XPath.XPathItem> System.Collections.Generic.IEnumerable<System.Xml.XPath.XPathItem>.GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Xml.XPath.XPathItem>); }
    int System.Collections.Generic.IList<System.Xml.XPath.XPathItem>.IndexOf(System.Xml.XPath.XPathItem value) { return default(int); }
    void System.Collections.Generic.IList<System.Xml.XPath.XPathItem>.Insert(int index, System.Xml.XPath.XPathItem value) { }
    void System.Collections.Generic.IList<System.Xml.XPath.XPathItem>.RemoveAt(int index) { }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class XmlQueryOutput : System.Xml.XmlWriter {
    internal XmlQueryOutput() { }
    public override System.Xml.WriteState WriteState { get { return default(System.Xml.WriteState); } }
    public override string XmlLang { get { return default(string); } }
    public override System.Xml.XmlSpace XmlSpace { get { return default(System.Xml.XmlSpace); } }
    public override void Close() { }
    public void EndCopy(System.Xml.XPath.XPathNavigator navigator) { }
    public void EndTree() { }
    public override void Flush() { }
    public override string LookupPrefix(string ns) { return default(string); }
    public bool StartCopy(System.Xml.XPath.XPathNavigator navigator) { return default(bool); }
    public void StartElementContentUnchecked() { }
    public void StartTree(System.Xml.XPath.XPathNodeType rootType) { }
    public override void WriteBase64(System.Byte[] buffer, int index, int count) { }
    public override void WriteCData(string text) { }
    public override void WriteCharEntity(char ch) { }
    public override void WriteChars(System.Char[] buffer, int index, int count) { }
    public override void WriteComment(string text) { }
    public void WriteCommentString(string text) { }
    public override void WriteDocType(string name, string pubid, string sysid, string subset) { }
    public override void WriteEndAttribute() { }
    public void WriteEndAttributeUnchecked() { }
    public void WriteEndComment() { }
    public override void WriteEndDocument() { }
    public override void WriteEndElement() { }
    public void WriteEndElementUnchecked(string localName) { }
    public void WriteEndElementUnchecked(string prefix, string localName, string ns) { }
    public void WriteEndNamespace() { }
    public void WriteEndProcessingInstruction() { }
    public void WriteEndRoot() { }
    public override void WriteEntityRef(string name) { }
    public override void WriteFullEndElement() { }
    public void WriteItem(System.Xml.XPath.XPathItem item) { }
    public void WriteNamespaceDeclaration(string prefix, string ns) { }
    public void WriteNamespaceDeclarationUnchecked(string prefix, string ns) { }
    public void WriteNamespaceString(string text) { }
    public override void WriteProcessingInstruction(string target, string text) { }
    public void WriteProcessingInstructionString(string text) { }
    public override void WriteRaw(System.Char[] buffer, int index, int count) { }
    public override void WriteRaw(string data) { }
    public void WriteRawUnchecked(string text) { }
    public override void WriteStartAttribute(string prefix, string localName, string ns) { }
    public void WriteStartAttributeComputed(string tagName, int prefixMappingsIndex) { }
    public void WriteStartAttributeComputed(string tagName, string ns) { }
    public void WriteStartAttributeComputed(System.Xml.XmlQualifiedName name) { }
    public void WriteStartAttributeComputed(System.Xml.XPath.XPathNavigator navigator) { }
    public void WriteStartAttributeLocalName(string localName) { }
    public void WriteStartAttributeUnchecked(string localName) { }
    public void WriteStartAttributeUnchecked(string prefix, string localName, string ns) { }
    public void WriteStartComment() { }
    public override void WriteStartDocument() { }
    public override void WriteStartDocument(bool standalone) { }
    public override void WriteStartElement(string prefix, string localName, string ns) { }
    public void WriteStartElementComputed(string tagName, int prefixMappingsIndex) { }
    public void WriteStartElementComputed(string tagName, string ns) { }
    public void WriteStartElementComputed(System.Xml.XmlQualifiedName name) { }
    public void WriteStartElementComputed(System.Xml.XPath.XPathNavigator navigator) { }
    public void WriteStartElementLocalName(string localName) { }
    public void WriteStartElementUnchecked(string localName) { }
    public void WriteStartElementUnchecked(string prefix, string localName, string ns) { }
    public void WriteStartNamespace(string prefix) { }
    public void WriteStartProcessingInstruction(string target) { }
    public void WriteStartRoot() { }
    public override void WriteString(string text) { }
    public void WriteStringUnchecked(string text) { }
    public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }
    public override void WriteWhitespace(string ws) { }
    public void XsltCopyOf(System.Xml.XPath.XPathNavigator navigator) { }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class XmlQueryRuntime {
    internal XmlQueryRuntime() { }
    public System.Xml.Xsl.Runtime.XmlQueryContext ExternalContext { get { return default(System.Xml.Xsl.Runtime.XmlQueryContext); } }
    public System.Xml.XmlNameTable NameTable { get { return default(System.Xml.XmlNameTable); } }
    public System.Xml.Xsl.Runtime.XmlQueryOutput Output { get { return default(System.Xml.Xsl.Runtime.XmlQueryOutput); } }
    public System.Xml.Xsl.Runtime.XsltLibrary XsltFunctions { get { return default(System.Xml.Xsl.Runtime.XsltLibrary); } }
    public void AddNewIndex(System.Xml.XPath.XPathNavigator context, int indexId, System.Xml.Xsl.Runtime.XmlILIndex index) { }
    public object ChangeTypeXsltArgument(int indexType, object value, System.Type destinationType) { return default(object); }
    public object ChangeTypeXsltResult(int indexType, object value) { return default(object); }
    public int ComparePosition(System.Xml.XPath.XPathNavigator navigatorThis, System.Xml.XPath.XPathNavigator navigatorThat) { return default(int); }
    public System.Xml.Xsl.Runtime.XmlCollation CreateCollation(string collation) { return default(System.Xml.Xsl.Runtime.XmlCollation); }
    public System.String[] DebugGetGlobalNames() { return default(System.String[]); }
    public System.Collections.IList DebugGetGlobalValue(string name) { return default(System.Collections.IList); }
    public object DebugGetXsltValue(System.Collections.IList seq) { return default(object); }
    public void DebugSetGlobalValue(string name, object value) { }
    public System.Collections.Generic.IList<System.Xml.XPath.XPathNavigator> DocOrderDistinct(System.Collections.Generic.IList<System.Xml.XPath.XPathNavigator> seq) { return default(System.Collections.Generic.IList<System.Xml.XPath.XPathNavigator>); }
    public bool EarlyBoundFunctionExists(string name, string namespaceUri) { return default(bool); }
    public System.Xml.XPath.XPathNavigator EndRtfConstruction(out System.Xml.Xsl.Runtime.XmlQueryOutput output) { output = default(System.Xml.Xsl.Runtime.XmlQueryOutput); return default(System.Xml.XPath.XPathNavigator); }
    public System.Collections.Generic.IList<System.Xml.XPath.XPathItem> EndSequenceConstruction(out System.Xml.Xsl.Runtime.XmlQueryOutput output) { output = default(System.Xml.Xsl.Runtime.XmlQueryOutput); return default(System.Collections.Generic.IList<System.Xml.XPath.XPathItem>); }
    public bool FindIndex(System.Xml.XPath.XPathNavigator context, int indexId, out System.Xml.Xsl.Runtime.XmlILIndex index) { index = default(System.Xml.Xsl.Runtime.XmlILIndex); return default(bool); }
    public string GenerateId(System.Xml.XPath.XPathNavigator navigator) { return default(string); }
    public string GetAtomizedName(int index) { return default(string); }
    public System.Xml.Xsl.Runtime.XmlCollation GetCollation(int index) { return default(System.Xml.Xsl.Runtime.XmlCollation); }
    public object GetEarlyBoundObject(int index) { return default(object); }
    public object GetGlobalValue(int index) { return default(object); }
    public System.Xml.Xsl.Runtime.XmlNavigatorFilter GetNameFilter(int index) { return default(System.Xml.Xsl.Runtime.XmlNavigatorFilter); }
    public System.Xml.Xsl.Runtime.XmlNavigatorFilter GetTypeFilter(System.Xml.XPath.XPathNodeType nodeType) { return default(System.Xml.Xsl.Runtime.XmlNavigatorFilter); }
    public bool IsGlobalComputed(int index) { return default(bool); }
    public bool IsQNameEqual(System.Xml.XPath.XPathNavigator navigator, int indexLocalName, int indexNamespaceUri) { return default(bool); }
    public bool IsQNameEqual(System.Xml.XPath.XPathNavigator n1, System.Xml.XPath.XPathNavigator n2) { return default(bool); }
    public bool MatchesXmlType(System.Collections.Generic.IList<System.Xml.XPath.XPathItem> seq, int indexType) { return default(bool); }
    public bool MatchesXmlType(System.Collections.Generic.IList<System.Xml.XPath.XPathItem> seq, System.Xml.Schema.XmlTypeCode code) { return default(bool); }
    public bool MatchesXmlType(System.Xml.XPath.XPathItem item, int indexType) { return default(bool); }
    public bool MatchesXmlType(System.Xml.XPath.XPathItem item, System.Xml.Schema.XmlTypeCode code) { return default(bool); }
    public static int OnCurrentNodeChanged(System.Xml.XPath.XPathNavigator currentNode) { return default(int); }
    public System.Xml.XmlQualifiedName ParseTagName(string tagName, int indexPrefixMappings) { return default(System.Xml.XmlQualifiedName); }
    public System.Xml.XmlQualifiedName ParseTagName(string tagName, string ns) { return default(System.Xml.XmlQualifiedName); }
    public void SendMessage(string message) { }
    public void SetGlobalValue(int index, object value) { }
    public void StartRtfConstruction(string baseUri, out System.Xml.Xsl.Runtime.XmlQueryOutput output) { output = default(System.Xml.Xsl.Runtime.XmlQueryOutput); }
    public void StartSequenceConstruction(out System.Xml.Xsl.Runtime.XmlQueryOutput output) { output = default(System.Xml.Xsl.Runtime.XmlQueryOutput); }
    public System.Xml.XPath.XPathNavigator TextRtfConstruction(string text, string baseUri) { return default(System.Xml.XPath.XPathNavigator); }
    public void ThrowException(string text) { }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public partial class XmlQuerySequence<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IList<T>, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList {
    public static readonly System.Xml.Xsl.Runtime.XmlQuerySequence<T> Empty;
    public XmlQuerySequence() { }
    public XmlQuerySequence(T value) { }
    public XmlQuerySequence(T[] array, int size) { }
    public XmlQuerySequence(int capacity) { }
    public int Count { get { return default(int); } }
    public T this[int index] { get { return default(T); } set { } }
    bool System.Collections.Generic.ICollection<T>.IsReadOnly { get { return default(bool); } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    bool System.Collections.IList.IsFixedSize { get { return default(bool); } }
    bool System.Collections.IList.IsReadOnly { get { return default(bool); } }
    object System.Collections.IList.this[int index] { get { return default(object); } set { } }
    public void Add(T value) { }
    public void Clear() { }
    public bool Contains(T value) { return default(bool); }
    public void CopyTo(T[] array, int index) { }
    public static System.Xml.Xsl.Runtime.XmlQuerySequence<T> CreateOrReuse(System.Xml.Xsl.Runtime.XmlQuerySequence<T> seq) { return default(System.Xml.Xsl.Runtime.XmlQuerySequence<T>); }
    public static System.Xml.Xsl.Runtime.XmlQuerySequence<T> CreateOrReuse(System.Xml.Xsl.Runtime.XmlQuerySequence<T> seq, T item) { return default(System.Xml.Xsl.Runtime.XmlQuerySequence<T>); }
    public System.Collections.Generic.IEnumerator<T> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<T>); }
    public int IndexOf(T value) { return default(int); }
    protected virtual void OnItemsChanged() { }
    public void SortByKeys(System.Array keys) { }
    void System.Collections.Generic.ICollection<T>.Add(T value) { }
    void System.Collections.Generic.ICollection<T>.Clear() { }
    bool System.Collections.Generic.ICollection<T>.Remove(T value) { return default(bool); }
    void System.Collections.Generic.IList<T>.Insert(int index, T value) { }
    void System.Collections.Generic.IList<T>.RemoveAt(int index) { }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    int System.Collections.IList.Add(object value) { return default(int); }
    void System.Collections.IList.Clear() { }
    bool System.Collections.IList.Contains(object value) { return default(bool); }
    int System.Collections.IList.IndexOf(object value) { return default(int); }
    void System.Collections.IList.Insert(int index, object value) { }
    void System.Collections.IList.Remove(object value) { }
    void System.Collections.IList.RemoveAt(int index) { }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct XmlSortKeyAccumulator {
    public System.Array Keys { get { return default(System.Array); } }
    public void AddDateTimeSortKey(System.Xml.Xsl.Runtime.XmlCollation collation, System.DateTime value) { }
    public void AddDecimalSortKey(System.Xml.Xsl.Runtime.XmlCollation collation, decimal value) { }
    public void AddDoubleSortKey(System.Xml.Xsl.Runtime.XmlCollation collation, double value) { }
    public void AddEmptySortKey(System.Xml.Xsl.Runtime.XmlCollation collation) { }
    public void AddIntegerSortKey(System.Xml.Xsl.Runtime.XmlCollation collation, long value) { }
    public void AddIntSortKey(System.Xml.Xsl.Runtime.XmlCollation collation, int value) { }
    public void AddStringSortKey(System.Xml.Xsl.Runtime.XmlCollation collation, string value) { }
    public void Create() { }
    public void FinishSortKeys() { }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct XPathFollowingIterator {
    public System.Xml.XPath.XPathNavigator Current { get { return default(System.Xml.XPath.XPathNavigator); } }
    public void Create(System.Xml.XPath.XPathNavigator input, System.Xml.Xsl.Runtime.XmlNavigatorFilter filter) { }
    public bool MoveNext() { return default(bool); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct XPathFollowingMergeIterator {
    public System.Xml.XPath.XPathNavigator Current { get { return default(System.Xml.XPath.XPathNavigator); } }
    public void Create(System.Xml.Xsl.Runtime.XmlNavigatorFilter filter) { }
    public System.Xml.Xsl.Runtime.IteratorResult MoveNext(System.Xml.XPath.XPathNavigator input) { return default(System.Xml.Xsl.Runtime.IteratorResult); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct XPathPrecedingDocOrderIterator {
    public System.Xml.XPath.XPathNavigator Current { get { return default(System.Xml.XPath.XPathNavigator); } }
    public void Create(System.Xml.XPath.XPathNavigator input, System.Xml.Xsl.Runtime.XmlNavigatorFilter filter) { }
    public bool MoveNext() { return default(bool); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct XPathPrecedingIterator {
    public System.Xml.XPath.XPathNavigator Current { get { return default(System.Xml.XPath.XPathNavigator); } }
    public void Create(System.Xml.XPath.XPathNavigator context, System.Xml.Xsl.Runtime.XmlNavigatorFilter filter) { }
    public bool MoveNext() { return default(bool); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct XPathPrecedingMergeIterator {
    public System.Xml.XPath.XPathNavigator Current { get { return default(System.Xml.XPath.XPathNavigator); } }
    public void Create(System.Xml.Xsl.Runtime.XmlNavigatorFilter filter) { }
    public System.Xml.Xsl.Runtime.IteratorResult MoveNext(System.Xml.XPath.XPathNavigator input) { return default(System.Xml.Xsl.Runtime.IteratorResult); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public static partial class XsltConvert {
    public static System.Collections.Generic.IList<System.Xml.XPath.XPathNavigator> EnsureNodeSet(System.Collections.Generic.IList<System.Xml.XPath.XPathItem> listItems) { return default(System.Collections.Generic.IList<System.Xml.XPath.XPathNavigator>); }
    public static bool ToBoolean(System.Collections.Generic.IList<System.Xml.XPath.XPathItem> listItems) { return default(bool); }
    public static bool ToBoolean(System.Xml.XPath.XPathItem item) { return default(bool); }
    public static System.DateTime ToDateTime(string value) { return default(System.DateTime); }
    public static decimal ToDecimal(double value) { return default(decimal); }
    public static double ToDouble(System.Collections.Generic.IList<System.Xml.XPath.XPathItem> listItems) { return default(double); }
    public static double ToDouble(decimal value) { return default(double); }
    public static double ToDouble(int value) { return default(double); }
    public static double ToDouble(long value) { return default(double); }
    public static double ToDouble(string value) { return default(double); }
    public static double ToDouble(System.Xml.XPath.XPathItem item) { return default(double); }
    public static int ToInt(double value) { return default(int); }
    public static long ToLong(double value) { return default(long); }
    public static System.Xml.XPath.XPathNavigator ToNode(System.Collections.Generic.IList<System.Xml.XPath.XPathItem> listItems) { return default(System.Xml.XPath.XPathNavigator); }
    public static System.Xml.XPath.XPathNavigator ToNode(System.Xml.XPath.XPathItem item) { return default(System.Xml.XPath.XPathNavigator); }
    public static System.Collections.Generic.IList<System.Xml.XPath.XPathNavigator> ToNodeSet(System.Collections.Generic.IList<System.Xml.XPath.XPathItem> listItems) { return default(System.Collections.Generic.IList<System.Xml.XPath.XPathNavigator>); }
    public static System.Collections.Generic.IList<System.Xml.XPath.XPathNavigator> ToNodeSet(System.Xml.XPath.XPathItem item) { return default(System.Collections.Generic.IList<System.Xml.XPath.XPathNavigator>); }
    public static string ToString(System.Collections.Generic.IList<System.Xml.XPath.XPathItem> listItems) { return default(string); }
    public static string ToString(System.DateTime value) { return default(string); }
    public static string ToString(double value) { return default(string); }
    public static string ToString(System.Xml.XPath.XPathItem item) { return default(string); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public static partial class XsltFunctions {
    public static string BaseUri(System.Xml.XPath.XPathNavigator navigator) { return default(string); }
    public static bool Contains(string s1, string s2) { return default(bool); }
    public static string EXslObjectType(System.Collections.Generic.IList<System.Xml.XPath.XPathItem> value) { return default(string); }
    public static bool Lang(string value, System.Xml.XPath.XPathNavigator context) { return default(bool); }
    public static string MSFormatDateTime(string dateTime, string format, string lang, bool isDate) { return default(string); }
    public static string MSLocalName(string name) { return default(string); }
    public static string MSNamespaceUri(string name, System.Xml.XPath.XPathNavigator currentNode) { return default(string); }
    public static double MSNumber(System.Collections.Generic.IList<System.Xml.XPath.XPathItem> value) { return default(double); }
    public static double MSStringCompare(string s1, string s2, string lang, string options) { return default(double); }
    public static string MSUtc(string dateTime) { return default(string); }
    public static string NormalizeSpace(string value) { return default(string); }
    public static string OuterXml(System.Xml.XPath.XPathNavigator navigator) { return default(string); }
    public static double Round(double value) { return default(double); }
    public static bool StartsWith(string s1, string s2) { return default(bool); }
    public static string Substring(string value, double startIndex) { return default(string); }
    public static string Substring(string value, double startIndex, double length) { return default(string); }
    public static string SubstringAfter(string s1, string s2) { return default(string); }
    public static string SubstringBefore(string s1, string s2) { return default(string); }
    public static System.Xml.XPath.XPathItem SystemProperty(System.Xml.XmlQualifiedName name) { return default(System.Xml.XPath.XPathItem); }
    public static string Translate(string arg, string mapString, string transString) { return default(string); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class XsltLibrary {
    internal XsltLibrary() { }
    public int CheckScriptNamespace(string nsUri) { return default(int); }
    public bool ElementAvailable(System.Xml.XmlQualifiedName name) { return default(bool); }
    public bool EqualityOperator(double opCode, System.Collections.Generic.IList<System.Xml.XPath.XPathItem> left, System.Collections.Generic.IList<System.Xml.XPath.XPathItem> right) { return default(bool); }
    public string FormatMessage(string res, System.Collections.Generic.IList<System.String> args) { return default(string); }
    public string FormatNumberDynamic(double value, string formatPicture, System.Xml.XmlQualifiedName decimalFormatName, string errorMessageName) { return default(string); }
    public string FormatNumberStatic(double value, double decimalFormatterIndex) { return default(string); }
    public bool FunctionAvailable(System.Xml.XmlQualifiedName name) { return default(bool); }
    public bool IsSameNodeSort(System.Xml.XPath.XPathNavigator nav1, System.Xml.XPath.XPathNavigator nav2) { return default(bool); }
    public int LangToLcid(string lang, bool forwardCompatibility) { return default(int); }
    public string NumberFormat(System.Collections.Generic.IList<System.Xml.XPath.XPathItem> value, string formatString, double lang, string letterValue, string groupingSeparator, double groupingSize) { return default(string); }
    public int RegisterDecimalFormat(System.Xml.XmlQualifiedName name, string infinitySymbol, string nanSymbol, string characters) { return default(int); }
    public double RegisterDecimalFormatter(string formatPicture, string infinitySymbol, string nanSymbol, string characters) { return default(double); }
    public bool RelationalOperator(double opCode, System.Collections.Generic.IList<System.Xml.XPath.XPathItem> left, System.Collections.Generic.IList<System.Xml.XPath.XPathItem> right) { return default(bool); }
  }
}
