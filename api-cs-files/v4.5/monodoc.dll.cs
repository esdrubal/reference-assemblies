namespace Lucene.Net {
  public sealed partial class LucenePackage {
    internal LucenePackage() { }
  }
}
namespace Lucene.Net.Analysis {
  public abstract partial class Analyzer : System.IDisposable {
    [System.ObsoleteAttribute]
    protected internal bool overridesTokenStreamMethod;
    protected Analyzer() { }
    protected internal virtual object PreviousTokenStream { get { return default(object); } set { } }
    public void Close() { }
    public virtual void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public virtual int GetOffsetGap(Lucene.Net.Documents.IFieldable field) { return default(int); }
    public virtual int GetPositionIncrementGap(string fieldName) { return default(int); }
    public virtual Lucene.Net.Analysis.TokenStream ReusableTokenStream(string fieldName, System.IO.TextReader reader) { return default(Lucene.Net.Analysis.TokenStream); }
    [System.ObsoleteAttribute("This is only present to preserve back-compat of classes that subclass a core analyzer and override tokenStream but not reusableTokenStream ")]
    protected internal virtual void SetOverridesTokenStreamMethod<TClass>() where TClass : Lucene.Net.Analysis.Analyzer { }
    public abstract Lucene.Net.Analysis.TokenStream TokenStream(string fieldName, System.IO.TextReader reader);
  }
  public sealed partial class ASCIIFoldingFilter : Lucene.Net.Analysis.TokenFilter {
    public ASCIIFoldingFilter(Lucene.Net.Analysis.TokenStream input) : base (default(Lucene.Net.Analysis.TokenStream)) { }
    public void FoldToASCII(System.Char[] input, int length) { }
    public override bool IncrementToken() { return default(bool); }
  }
  public abstract partial class BaseCharFilter : Lucene.Net.Analysis.CharFilter {
    protected BaseCharFilter(Lucene.Net.Analysis.CharStream @in) : base (default(Lucene.Net.Analysis.CharStream)) { }
    protected int LastCumulativeDiff { get { return default(int); } }
    protected void AddOffCorrectMap(int off, int cumulativeDiff) { }
    protected internal override int Correct(int currentOff) { return default(int); }
    [System.ObsoleteAttribute("Use LastCumulativeDiff property instead")]
    protected int GetLastCumulativeDiff() { return default(int); }
  }
  public sealed partial class CachingTokenFilter : Lucene.Net.Analysis.TokenFilter {
    public CachingTokenFilter(Lucene.Net.Analysis.TokenStream input) : base (default(Lucene.Net.Analysis.TokenStream)) { }
    public override void End() { }
    public override bool IncrementToken() { return default(bool); }
    public override void Reset() { }
  }
  public partial class CharArraySet : System.Collections.Generic.ICollection<System.String>, System.Collections.Generic.IEnumerable<System.String>, System.Collections.Generic.ISet<System.String>, System.Collections.IEnumerable {
    public static Lucene.Net.Analysis.CharArraySet EMPTY_SET;
    public CharArraySet(System.Collections.Generic.IEnumerable<System.Object> c, bool ignoreCase) { }
    public CharArraySet(System.Collections.Generic.IEnumerable<System.String> c, bool ignoreCase) { }
    public CharArraySet(int startSize, bool ignoreCase) { }
    public int Count { get { return default(int); } }
    public bool IsEmpty { get { return default(bool); } }
    public bool IsReadOnly { get { return default(bool); } }
    public bool Add(System.Char[] text) { return default(bool); }
    public bool Add(object item) { return default(bool); }
    public bool Add(string text) { return default(bool); }
    public void AddAll(System.Collections.Generic.IEnumerable<System.String> coll) { }
    public void Clear() { }
    public virtual bool Contains(System.Char[] text, int off, int len) { return default(bool); }
    public bool Contains(object item) { return default(bool); }
    public virtual bool Contains(string text) { return default(bool); }
    public static Lucene.Net.Analysis.CharArraySet Copy<T>(System.Collections.Generic.ISet<T> @set) { return default(Lucene.Net.Analysis.CharArraySet); }
    public System.Collections.Generic.IEnumerator<System.String> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.String>); }
    public void RemoveAll(System.Collections.Generic.ICollection<System.String> c) { }
    public void RetainAll(System.Collections.Generic.ICollection<System.String> c) { }
    public System.Collections.Generic.IEnumerator<System.String> StringEnumerator() { return default(System.Collections.Generic.IEnumerator<System.String>); }
    void System.Collections.Generic.ICollection<string>.Add(string item) { }
    void System.Collections.Generic.ICollection<string>.CopyTo(System.String[] array, int arrayIndex) { }
    bool System.Collections.Generic.ICollection<string>.Remove(string item) { return default(bool); }
    void System.Collections.Generic.ISet<string>.ExceptWith(System.Collections.Generic.IEnumerable<System.String> other) { }
    void System.Collections.Generic.ISet<string>.IntersectWith(System.Collections.Generic.IEnumerable<System.String> other) { }
    bool System.Collections.Generic.ISet<string>.IsProperSubsetOf(System.Collections.Generic.IEnumerable<System.String> other) { return default(bool); }
    bool System.Collections.Generic.ISet<string>.IsProperSupersetOf(System.Collections.Generic.IEnumerable<System.String> other) { return default(bool); }
    bool System.Collections.Generic.ISet<string>.IsSubsetOf(System.Collections.Generic.IEnumerable<System.String> other) { return default(bool); }
    bool System.Collections.Generic.ISet<string>.IsSupersetOf(System.Collections.Generic.IEnumerable<System.String> other) { return default(bool); }
    bool System.Collections.Generic.ISet<string>.Overlaps(System.Collections.Generic.IEnumerable<System.String> other) { return default(bool); }
    bool System.Collections.Generic.ISet<string>.SetEquals(System.Collections.Generic.IEnumerable<System.String> other) { return default(bool); }
    void System.Collections.Generic.ISet<string>.SymmetricExceptWith(System.Collections.Generic.IEnumerable<System.String> other) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    public void UnionWith(System.Collections.Generic.IEnumerable<System.String> other) { }
    public static Lucene.Net.Analysis.CharArraySet UnmodifiableSet(Lucene.Net.Analysis.CharArraySet @set) { return default(Lucene.Net.Analysis.CharArraySet); }
    public partial class CharArraySetEnumerator : System.Collections.Generic.IEnumerator<System.String>, System.Collections.IEnumerator, System.IDisposable {
      protected internal CharArraySetEnumerator(Lucene.Net.Analysis.CharArraySet creator) { }
      public string Current { get { return default(string); } }
      object System.Collections.IEnumerator.Current { get { return default(object); } }
      public void Dispose() { }
      public bool MoveNext() { return default(bool); }
      public System.Char[] NextCharArray() { return default(System.Char[]); }
      public void Reset() { }
    }
  }
  public abstract partial class CharFilter : Lucene.Net.Analysis.CharStream {
    protected internal Lucene.Net.Analysis.CharStream input;
    protected internal CharFilter(Lucene.Net.Analysis.CharStream in_Renamed) : base (default(System.IO.StreamReader)) { }
    protected internal virtual int Correct(int currentOff) { return default(int); }
    public override int CorrectOffset(int currentOff) { return default(int); }
    protected override void Dispose(bool disposing) { }
    public void Mark(int readAheadLimit) { }
    public bool MarkSupported() { return default(bool); }
    public override int Read(System.Char[] cbuf, int off, int len) { return default(int); }
    public void Reset() { }
  }
  public sealed partial class CharReader : Lucene.Net.Analysis.CharStream {
    internal CharReader() : base (default(System.IO.StreamReader)) { }
    public override int CorrectOffset(int currentOff) { return default(int); }
    protected override void Dispose(bool disposing) { }
    public static Lucene.Net.Analysis.CharStream Get(System.IO.TextReader input) { return default(Lucene.Net.Analysis.CharStream); }
    public void Mark(int readAheadLimit) { }
    public bool MarkSupported() { return default(bool); }
    public override int Read(System.Char[] cbuf, int off, int len) { return default(int); }
    public void Reset() { }
  }
  public abstract partial class CharStream : System.IO.StreamReader {
    protected CharStream(System.IO.StreamReader reader) : base (default(System.IO.Stream)) { }
    public abstract int CorrectOffset(int currentOff);
  }
  public abstract partial class CharTokenizer : Lucene.Net.Analysis.Tokenizer {
    protected CharTokenizer(Lucene.Net.Util.AttributeSource source, System.IO.TextReader input) { }
    protected CharTokenizer(Lucene.Net.Util.AttributeSource.AttributeFactory factory, System.IO.TextReader input) { }
    protected CharTokenizer(System.IO.TextReader input) { }
    public override void End() { }
    public override bool IncrementToken() { return default(bool); }
    protected internal abstract bool IsTokenChar(char c);
    protected internal virtual char Normalize(char c) { return default(char); }
    public override void Reset(System.IO.TextReader input) { }
  }
  [System.ObsoleteAttribute("If you build a new index, use ASCIIFoldingFilter which covers a superset of Latin 1.  This class is included for use with existing indexes and will be removed in a future release (possible Lucene 4.0).")]
  public partial class ISOLatin1AccentFilter : Lucene.Net.Analysis.TokenFilter {
    public ISOLatin1AccentFilter(Lucene.Net.Analysis.TokenStream input) : base (default(Lucene.Net.Analysis.TokenStream)) { }
    public override bool IncrementToken() { return default(bool); }
    public void RemoveAccents(System.Char[] input, int length) { }
  }
  public partial class KeywordAnalyzer : Lucene.Net.Analysis.Analyzer {
    public KeywordAnalyzer() { }
    public override Lucene.Net.Analysis.TokenStream ReusableTokenStream(string fieldName, System.IO.TextReader reader) { return default(Lucene.Net.Analysis.TokenStream); }
    public override Lucene.Net.Analysis.TokenStream TokenStream(string fieldName, System.IO.TextReader reader) { return default(Lucene.Net.Analysis.TokenStream); }
  }
  public sealed partial class KeywordTokenizer : Lucene.Net.Analysis.Tokenizer {
    public KeywordTokenizer(Lucene.Net.Util.AttributeSource source, System.IO.TextReader input, int bufferSize) { }
    public KeywordTokenizer(Lucene.Net.Util.AttributeSource.AttributeFactory factory, System.IO.TextReader input, int bufferSize) { }
    public KeywordTokenizer(System.IO.TextReader input) { }
    public KeywordTokenizer(System.IO.TextReader input, int bufferSize) { }
    public override void End() { }
    public override bool IncrementToken() { return default(bool); }
    public override void Reset(System.IO.TextReader input) { }
  }
  public sealed partial class LengthFilter : Lucene.Net.Analysis.TokenFilter {
    public LengthFilter(Lucene.Net.Analysis.TokenStream in_Renamed, int min, int max) : base (default(Lucene.Net.Analysis.TokenStream)) { }
    public override bool IncrementToken() { return default(bool); }
  }
  public partial class LetterTokenizer : Lucene.Net.Analysis.CharTokenizer {
    public LetterTokenizer(Lucene.Net.Util.AttributeSource source, System.IO.TextReader @in) : base (default(System.IO.TextReader)) { }
    public LetterTokenizer(Lucene.Net.Util.AttributeSource.AttributeFactory factory, System.IO.TextReader @in) : base (default(System.IO.TextReader)) { }
    public LetterTokenizer(System.IO.TextReader @in) : base (default(System.IO.TextReader)) { }
    protected internal override bool IsTokenChar(char c) { return default(bool); }
  }
  public sealed partial class LowerCaseFilter : Lucene.Net.Analysis.TokenFilter {
    public LowerCaseFilter(Lucene.Net.Analysis.TokenStream @in) : base (default(Lucene.Net.Analysis.TokenStream)) { }
    public override bool IncrementToken() { return default(bool); }
  }
  public sealed partial class LowerCaseTokenizer : Lucene.Net.Analysis.LetterTokenizer {
    public LowerCaseTokenizer(Lucene.Net.Util.AttributeSource source, System.IO.TextReader @in) : base (default(System.IO.TextReader)) { }
    public LowerCaseTokenizer(Lucene.Net.Util.AttributeSource.AttributeFactory factory, System.IO.TextReader @in) : base (default(System.IO.TextReader)) { }
    public LowerCaseTokenizer(System.IO.TextReader @in) : base (default(System.IO.TextReader)) { }
    protected internal override char Normalize(char c) { return default(char); }
  }
  public partial class MappingCharFilter : Lucene.Net.Analysis.BaseCharFilter {
    public MappingCharFilter(Lucene.Net.Analysis.NormalizeCharMap normMap, Lucene.Net.Analysis.CharStream @in) : base (default(Lucene.Net.Analysis.CharStream)) { }
    public MappingCharFilter(Lucene.Net.Analysis.NormalizeCharMap normMap, System.IO.TextReader @in) : base (default(Lucene.Net.Analysis.CharStream)) { }
    public override int Read() { return default(int); }
    public override int Read(System.Char[] cbuf, int off, int len) { return default(int); }
  }
  public partial class NormalizeCharMap {
    public NormalizeCharMap() { }
    public virtual void Add(string singleMatch, string replacement) { }
  }
  public sealed partial class NumericTokenStream : Lucene.Net.Analysis.TokenStream {
    public const string TOKEN_TYPE_FULL_PREC = "fullPrecNumeric";
    public const string TOKEN_TYPE_LOWER_PREC = "lowerPrecNumeric";
    public NumericTokenStream() { }
    public NumericTokenStream(Lucene.Net.Util.AttributeSource source, int precisionStep) { }
    public NumericTokenStream(Lucene.Net.Util.AttributeSource.AttributeFactory factory, int precisionStep) { }
    public NumericTokenStream(int precisionStep) { }
    protected override void Dispose(bool disposing) { }
    public override bool IncrementToken() { return default(bool); }
    public override void Reset() { }
    public Lucene.Net.Analysis.NumericTokenStream SetDoubleValue(double value_Renamed) { return default(Lucene.Net.Analysis.NumericTokenStream); }
    public Lucene.Net.Analysis.NumericTokenStream SetFloatValue(float value_Renamed) { return default(Lucene.Net.Analysis.NumericTokenStream); }
    public Lucene.Net.Analysis.NumericTokenStream SetIntValue(int value_Renamed) { return default(Lucene.Net.Analysis.NumericTokenStream); }
    public Lucene.Net.Analysis.NumericTokenStream SetLongValue(long value_Renamed) { return default(Lucene.Net.Analysis.NumericTokenStream); }
    public override string ToString() { return default(string); }
  }
  public partial class PerFieldAnalyzerWrapper : Lucene.Net.Analysis.Analyzer {
    public PerFieldAnalyzerWrapper(Lucene.Net.Analysis.Analyzer defaultAnalyzer) { }
    public PerFieldAnalyzerWrapper(Lucene.Net.Analysis.Analyzer defaultAnalyzer, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, Lucene.Net.Analysis.Analyzer>> fieldAnalyzers) { }
    public virtual void AddAnalyzer(string fieldName, Lucene.Net.Analysis.Analyzer analyzer) { }
    public override int GetOffsetGap(Lucene.Net.Documents.IFieldable field) { return default(int); }
    public override int GetPositionIncrementGap(string fieldName) { return default(int); }
    public override Lucene.Net.Analysis.TokenStream ReusableTokenStream(string fieldName, System.IO.TextReader reader) { return default(Lucene.Net.Analysis.TokenStream); }
    public override Lucene.Net.Analysis.TokenStream TokenStream(string fieldName, System.IO.TextReader reader) { return default(Lucene.Net.Analysis.TokenStream); }
    public override string ToString() { return default(string); }
  }
  public sealed partial class PorterStemFilter : Lucene.Net.Analysis.TokenFilter {
    public PorterStemFilter(Lucene.Net.Analysis.TokenStream in_Renamed) : base (default(Lucene.Net.Analysis.TokenStream)) { }
    public override bool IncrementToken() { return default(bool); }
  }
  public sealed partial class SimpleAnalyzer : Lucene.Net.Analysis.Analyzer {
    public SimpleAnalyzer() { }
    public override Lucene.Net.Analysis.TokenStream ReusableTokenStream(string fieldName, System.IO.TextReader reader) { return default(Lucene.Net.Analysis.TokenStream); }
    public override Lucene.Net.Analysis.TokenStream TokenStream(string fieldName, System.IO.TextReader reader) { return default(Lucene.Net.Analysis.TokenStream); }
  }
  public sealed partial class StopAnalyzer : Lucene.Net.Analysis.Analyzer {
    public static System.Collections.Generic.ISet<System.String> ENGLISH_STOP_WORDS_SET;
    public StopAnalyzer(Lucene.Net.Util.Version matchVersion) { }
    public StopAnalyzer(Lucene.Net.Util.Version matchVersion, System.Collections.Generic.ISet<System.String> stopWords) { }
    public StopAnalyzer(Lucene.Net.Util.Version matchVersion, System.IO.FileInfo stopwordsFile) { }
    public StopAnalyzer(Lucene.Net.Util.Version matchVersion, System.IO.TextReader stopwords) { }
    public override Lucene.Net.Analysis.TokenStream ReusableTokenStream(string fieldName, System.IO.TextReader reader) { return default(Lucene.Net.Analysis.TokenStream); }
    public override Lucene.Net.Analysis.TokenStream TokenStream(string fieldName, System.IO.TextReader reader) { return default(Lucene.Net.Analysis.TokenStream); }
  }
  public sealed partial class StopFilter : Lucene.Net.Analysis.TokenFilter {
    public StopFilter(bool enablePositionIncrements, Lucene.Net.Analysis.TokenStream @in, System.Collections.Generic.ISet<System.String> stopWords) : base (default(Lucene.Net.Analysis.TokenStream)) { }
    public StopFilter(bool enablePositionIncrements, Lucene.Net.Analysis.TokenStream input, System.Collections.Generic.ISet<System.String> stopWords, bool ignoreCase) : base (default(Lucene.Net.Analysis.TokenStream)) { }
    public bool EnablePositionIncrements { get { return default(bool); } set { } }
    public static bool GetEnablePositionIncrementsVersionDefault(Lucene.Net.Util.Version matchVersion) { return default(bool); }
    public override bool IncrementToken() { return default(bool); }
    public static System.Collections.Generic.ISet<System.String> MakeStopSet(System.Collections.Generic.IList<System.Object> stopWords) { return default(System.Collections.Generic.ISet<System.String>); }
    public static System.Collections.Generic.ISet<System.String> MakeStopSet(System.Collections.Generic.IList<System.Object> stopWords, bool ignoreCase) { return default(System.Collections.Generic.ISet<System.String>); }
    public static System.Collections.Generic.ISet<System.String> MakeStopSet(params System.String[] stopWords) { return default(System.Collections.Generic.ISet<System.String>); }
    public static System.Collections.Generic.ISet<System.String> MakeStopSet(System.String[] stopWords, bool ignoreCase) { return default(System.Collections.Generic.ISet<System.String>); }
  }
  public sealed partial class TeeSinkTokenFilter : Lucene.Net.Analysis.TokenFilter {
    public TeeSinkTokenFilter(Lucene.Net.Analysis.TokenStream input) : base (default(Lucene.Net.Analysis.TokenStream)) { }
    public void AddSinkTokenStream(Lucene.Net.Analysis.TeeSinkTokenFilter.SinkTokenStream sink) { }
    public void ConsumeAllTokens() { }
    public override void End() { }
    public override bool IncrementToken() { return default(bool); }
    public Lucene.Net.Analysis.TeeSinkTokenFilter.SinkTokenStream NewSinkTokenStream() { return default(Lucene.Net.Analysis.TeeSinkTokenFilter.SinkTokenStream); }
    public Lucene.Net.Analysis.TeeSinkTokenFilter.SinkTokenStream NewSinkTokenStream(Lucene.Net.Analysis.TeeSinkTokenFilter.SinkFilter filter) { return default(Lucene.Net.Analysis.TeeSinkTokenFilter.SinkTokenStream); }
    public partial class AnonymousClassSinkFilter : Lucene.Net.Analysis.TeeSinkTokenFilter.SinkFilter {
      public AnonymousClassSinkFilter() { }
      public override bool Accept(Lucene.Net.Util.AttributeSource source) { return default(bool); }
    }
    public abstract partial class SinkFilter {
      protected SinkFilter() { }
      public abstract bool Accept(Lucene.Net.Util.AttributeSource source);
      public virtual void Reset() { }
    }
    public sealed partial class SinkTokenStream : Lucene.Net.Analysis.TokenStream {
      internal SinkTokenStream() { }
      protected override void Dispose(bool disposing) { }
      public override void End() { }
      public override bool IncrementToken() { return default(bool); }
      public override void Reset() { }
    }
  }
  public partial class Token : Lucene.Net.Util.Attribute, Lucene.Net.Analysis.Tokenattributes.IFlagsAttribute, Lucene.Net.Analysis.Tokenattributes.IOffsetAttribute, Lucene.Net.Analysis.Tokenattributes.IPayloadAttribute, Lucene.Net.Analysis.Tokenattributes.IPositionIncrementAttribute, Lucene.Net.Analysis.Tokenattributes.ITermAttribute, Lucene.Net.Analysis.Tokenattributes.ITypeAttribute, Lucene.Net.Util.IAttribute {
    public const string DEFAULT_TYPE = "word";
    public static Lucene.Net.Util.AttributeSource.AttributeFactory TOKEN_ATTRIBUTE_FACTORY;
    public Token() { }
    public Token(System.Char[] startTermBuffer, int termBufferOffset, int termBufferLength, int start, int end) { }
    public Token(int start, int end) { }
    public Token(int start, int end, int flags) { }
    public Token(int start, int end, string typ) { }
    public Token(string text, int start, int end) { }
    public Token(string text, int start, int end, int flags) { }
    public Token(string text, int start, int end, string typ) { }
    public virtual int EndOffset { get { return default(int); } set { } }
    public virtual int Flags { get { return default(int); } set { } }
    public virtual Lucene.Net.Index.Payload Payload { get { return default(Lucene.Net.Index.Payload); } set { } }
    public virtual int PositionIncrement { get { return default(int); } set { } }
    public virtual int StartOffset { get { return default(int); } set { } }
    public string Term { get { return default(string); } }
    public string Type { get { return default(string); } set { } }
    public override void Clear() { }
    public override object Clone() { return default(object); }
    public virtual Lucene.Net.Analysis.Token Clone(System.Char[] newTermBuffer, int newTermOffset, int newTermLength, int newStartOffset, int newEndOffset) { return default(Lucene.Net.Analysis.Token); }
    public override void CopyTo(Lucene.Net.Util.Attribute target) { }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public virtual void Reinit(Lucene.Net.Analysis.Token prototype) { }
    public virtual void Reinit(Lucene.Net.Analysis.Token prototype, System.Char[] newTermBuffer, int offset, int length) { }
    public virtual void Reinit(Lucene.Net.Analysis.Token prototype, string newTerm) { }
    public virtual Lucene.Net.Analysis.Token Reinit(System.Char[] newTermBuffer, int newTermOffset, int newTermLength, int newStartOffset, int newEndOffset) { return default(Lucene.Net.Analysis.Token); }
    public virtual Lucene.Net.Analysis.Token Reinit(System.Char[] newTermBuffer, int newTermOffset, int newTermLength, int newStartOffset, int newEndOffset, string newType) { return default(Lucene.Net.Analysis.Token); }
    public virtual Lucene.Net.Analysis.Token Reinit(string newTerm, int newStartOffset, int newEndOffset) { return default(Lucene.Net.Analysis.Token); }
    public virtual Lucene.Net.Analysis.Token Reinit(string newTerm, int newTermOffset, int newTermLength, int newStartOffset, int newEndOffset) { return default(Lucene.Net.Analysis.Token); }
    public virtual Lucene.Net.Analysis.Token Reinit(string newTerm, int newTermOffset, int newTermLength, int newStartOffset, int newEndOffset, string newType) { return default(Lucene.Net.Analysis.Token); }
    public virtual Lucene.Net.Analysis.Token Reinit(string newTerm, int newStartOffset, int newEndOffset, string newType) { return default(Lucene.Net.Analysis.Token); }
    public virtual System.Char[] ResizeTermBuffer(int newSize) { return default(System.Char[]); }
    public virtual void SetOffset(int startOffset, int endOffset) { }
    public void SetTermBuffer(System.Char[] buffer, int offset, int length) { }
    public void SetTermBuffer(string buffer) { }
    public void SetTermBuffer(string buffer, int offset, int length) { }
    public void SetTermLength(int length) { }
    public System.Char[] TermBuffer() { return default(System.Char[]); }
    public int TermLength() { return default(int); }
    public override string ToString() { return default(string); }
    public partial class TokenAttributeFactory : Lucene.Net.Util.AttributeSource.AttributeFactory {
      public TokenAttributeFactory(Lucene.Net.Util.AttributeSource.AttributeFactory delegateFactory) { }
      public override Lucene.Net.Util.Attribute CreateAttributeInstance<T>() { return default(Lucene.Net.Util.Attribute); }
      public override bool Equals(object other) { return default(bool); }
      public override int GetHashCode() { return default(int); }
    }
  }
  public abstract partial class TokenFilter : Lucene.Net.Analysis.TokenStream {
    protected internal Lucene.Net.Analysis.TokenStream input;
    protected internal TokenFilter(Lucene.Net.Analysis.TokenStream input) { }
    protected override void Dispose(bool disposing) { }
    public override void End() { }
    public override void Reset() { }
  }
  public abstract partial class Tokenizer : Lucene.Net.Analysis.TokenStream {
    protected internal System.IO.TextReader input;
    protected internal Tokenizer() { }
    protected internal Tokenizer(Lucene.Net.Util.AttributeSource source) { }
    protected internal Tokenizer(Lucene.Net.Util.AttributeSource source, System.IO.TextReader input) { }
    protected internal Tokenizer(Lucene.Net.Util.AttributeSource.AttributeFactory factory) { }
    protected internal Tokenizer(Lucene.Net.Util.AttributeSource.AttributeFactory factory, System.IO.TextReader input) { }
    protected internal Tokenizer(System.IO.TextReader input) { }
    protected internal int CorrectOffset(int currentOff) { return default(int); }
    protected override void Dispose(bool disposing) { }
    public virtual void Reset(System.IO.TextReader input) { }
  }
  public abstract partial class TokenStream : Lucene.Net.Util.AttributeSource, System.IDisposable {
    protected internal TokenStream() { }
    protected internal TokenStream(Lucene.Net.Util.AttributeSource input) { }
    protected internal TokenStream(Lucene.Net.Util.AttributeSource.AttributeFactory factory) { }
    [System.ObsoleteAttribute("Use Dispose() instead")]
    public void Close() { }
    public void Dispose() { }
    protected abstract void Dispose(bool disposing);
    public virtual void End() { }
    public abstract bool IncrementToken();
    public virtual void Reset() { }
  }
  public sealed partial class WhitespaceAnalyzer : Lucene.Net.Analysis.Analyzer {
    public WhitespaceAnalyzer() { }
    public override Lucene.Net.Analysis.TokenStream ReusableTokenStream(string fieldName, System.IO.TextReader reader) { return default(Lucene.Net.Analysis.TokenStream); }
    public override Lucene.Net.Analysis.TokenStream TokenStream(string fieldName, System.IO.TextReader reader) { return default(Lucene.Net.Analysis.TokenStream); }
  }
  public partial class WhitespaceTokenizer : Lucene.Net.Analysis.CharTokenizer {
    public WhitespaceTokenizer(Lucene.Net.Util.AttributeSource source, System.IO.TextReader @in) : base (default(System.IO.TextReader)) { }
    public WhitespaceTokenizer(Lucene.Net.Util.AttributeSource.AttributeFactory factory, System.IO.TextReader @in) : base (default(System.IO.TextReader)) { }
    public WhitespaceTokenizer(System.IO.TextReader @in) : base (default(System.IO.TextReader)) { }
    protected internal override bool IsTokenChar(char c) { return default(bool); }
  }
  public partial class WordlistLoader {
    public WordlistLoader() { }
    public static System.Collections.Generic.Dictionary<System.String, System.String> GetStemDict(System.IO.FileInfo wordstemfile) { return default(System.Collections.Generic.Dictionary<System.String, System.String>); }
    public static System.Collections.Generic.ISet<System.String> GetWordSet(System.IO.FileInfo wordfile) { return default(System.Collections.Generic.ISet<System.String>); }
    public static System.Collections.Generic.ISet<System.String> GetWordSet(System.IO.FileInfo wordfile, string comment) { return default(System.Collections.Generic.ISet<System.String>); }
    public static System.Collections.Generic.ISet<System.String> GetWordSet(System.IO.TextReader reader) { return default(System.Collections.Generic.ISet<System.String>); }
    public static System.Collections.Generic.ISet<System.String> GetWordSet(System.IO.TextReader reader, string comment) { return default(System.Collections.Generic.ISet<System.String>); }
  }
}
namespace Lucene.Net.Analysis.Standard {
  public partial class StandardAnalyzer : Lucene.Net.Analysis.Analyzer {
    public const int DEFAULT_MAX_TOKEN_LENGTH = 255;
    public static readonly System.Collections.Generic.ISet<System.String> STOP_WORDS_SET;
    public StandardAnalyzer(Lucene.Net.Util.Version matchVersion) { }
    public StandardAnalyzer(Lucene.Net.Util.Version matchVersion, System.Collections.Generic.ISet<System.String> stopWords) { }
    public StandardAnalyzer(Lucene.Net.Util.Version matchVersion, System.IO.FileInfo stopwords) { }
    public StandardAnalyzer(Lucene.Net.Util.Version matchVersion, System.IO.TextReader stopwords) { }
    public virtual int MaxTokenLength { get { return default(int); } set { } }
    public override Lucene.Net.Analysis.TokenStream ReusableTokenStream(string fieldName, System.IO.TextReader reader) { return default(Lucene.Net.Analysis.TokenStream); }
    public override Lucene.Net.Analysis.TokenStream TokenStream(string fieldName, System.IO.TextReader reader) { return default(Lucene.Net.Analysis.TokenStream); }
  }
  public sealed partial class StandardFilter : Lucene.Net.Analysis.TokenFilter {
    public StandardFilter(Lucene.Net.Analysis.TokenStream in_Renamed) : base (default(Lucene.Net.Analysis.TokenStream)) { }
    public override bool IncrementToken() { return default(bool); }
  }
  public sealed partial class StandardTokenizer : Lucene.Net.Analysis.Tokenizer {
    public const int ACRONYM = 2;
    [System.ObsoleteAttribute("this solves a bug where HOSTs that end with '.' are identified as ACRONYMs.")]
    public const int ACRONYM_DEP = 8;
    public const int ALPHANUM = 0;
    public const int APOSTROPHE = 1;
    public const int CJ = 7;
    public const int COMPANY = 3;
    public const int EMAIL = 4;
    public const int HOST = 5;
    public const int NUM = 6;
    public static readonly System.String[] TOKEN_TYPES;
    public StandardTokenizer(Lucene.Net.Util.Version matchVersion, Lucene.Net.Util.AttributeSource source, System.IO.TextReader input) { }
    public StandardTokenizer(Lucene.Net.Util.Version matchVersion, Lucene.Net.Util.AttributeSource.AttributeFactory factory, System.IO.TextReader input) { }
    public StandardTokenizer(Lucene.Net.Util.Version matchVersion, System.IO.TextReader input) { }
    public int MaxTokenLength { get { return default(int); } set { } }
    public override void End() { }
    public override bool IncrementToken() { return default(bool); }
    public override void Reset(System.IO.TextReader reader) { }
    [System.ObsoleteAttribute("Remove in 3.X and make true the only valid value. See https://issues.apache.org/jira/browse/LUCENE-1068")]
    public void SetReplaceInvalidAcronym(bool replaceInvalidAcronym) { }
  }
}
namespace Lucene.Net.Analysis.Tokenattributes {
  public partial class FlagsAttribute : Lucene.Net.Util.Attribute, Lucene.Net.Analysis.Tokenattributes.IFlagsAttribute, Lucene.Net.Util.IAttribute, System.ICloneable {
    public FlagsAttribute() { }
    public virtual int Flags { get { return default(int); } set { } }
    public override void Clear() { }
    public override object Clone() { return default(object); }
    public override void CopyTo(Lucene.Net.Util.Attribute target) { }
    public override bool Equals(object other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }
  public partial interface IFlagsAttribute : Lucene.Net.Util.IAttribute {
    int Flags { get; set; }
  }
  public partial interface IOffsetAttribute : Lucene.Net.Util.IAttribute {
    int EndOffset { get; }
    int StartOffset { get; }
    void SetOffset(int startOffset, int endOffset);
  }
  public partial interface IPayloadAttribute : Lucene.Net.Util.IAttribute {
    Lucene.Net.Index.Payload Payload { get; set; }
  }
  public partial interface IPositionIncrementAttribute : Lucene.Net.Util.IAttribute {
    int PositionIncrement { get; set; }
  }
  public partial interface ITermAttribute : Lucene.Net.Util.IAttribute {
    string Term { get; }
    System.Char[] ResizeTermBuffer(int newSize);
    void SetTermBuffer(System.Char[] buffer, int offset, int length);
    void SetTermBuffer(string buffer);
    void SetTermBuffer(string buffer, int offset, int length);
    void SetTermLength(int length);
    System.Char[] TermBuffer();
    int TermLength();
  }
  public partial interface ITypeAttribute : Lucene.Net.Util.IAttribute {
    string Type { get; set; }
  }
  public partial class OffsetAttribute : Lucene.Net.Util.Attribute, Lucene.Net.Analysis.Tokenattributes.IOffsetAttribute, Lucene.Net.Util.IAttribute, System.ICloneable {
    public OffsetAttribute() { }
    public virtual int EndOffset { get { return default(int); } }
    public virtual int StartOffset { get { return default(int); } }
    public override void Clear() { }
    public override object Clone() { return default(object); }
    public override void CopyTo(Lucene.Net.Util.Attribute target) { }
    public override bool Equals(object other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public virtual void SetOffset(int startOffset, int endOffset) { }
  }
  public partial class PayloadAttribute : Lucene.Net.Util.Attribute, Lucene.Net.Analysis.Tokenattributes.IPayloadAttribute, Lucene.Net.Util.IAttribute, System.ICloneable {
    public PayloadAttribute() { }
    public PayloadAttribute(Lucene.Net.Index.Payload payload) { }
    public virtual Lucene.Net.Index.Payload Payload { get { return default(Lucene.Net.Index.Payload); } set { } }
    public override void Clear() { }
    public override object Clone() { return default(object); }
    public override void CopyTo(Lucene.Net.Util.Attribute target) { }
    public override bool Equals(object other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }
  public partial class PositionIncrementAttribute : Lucene.Net.Util.Attribute, Lucene.Net.Analysis.Tokenattributes.IPositionIncrementAttribute, Lucene.Net.Util.IAttribute, System.ICloneable {
    public PositionIncrementAttribute() { }
    public virtual int PositionIncrement { get { return default(int); } set { } }
    public override void Clear() { }
    public override object Clone() { return default(object); }
    public override void CopyTo(Lucene.Net.Util.Attribute target) { }
    public override bool Equals(object other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }
  public partial class TermAttribute : Lucene.Net.Util.Attribute, Lucene.Net.Analysis.Tokenattributes.ITermAttribute, Lucene.Net.Util.IAttribute, System.ICloneable {
    public TermAttribute() { }
    public virtual string Term { get { return default(string); } }
    public override void Clear() { }
    public override object Clone() { return default(object); }
    public override void CopyTo(Lucene.Net.Util.Attribute target) { }
    public override bool Equals(object other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public virtual System.Char[] ResizeTermBuffer(int newSize) { return default(System.Char[]); }
    public virtual void SetTermBuffer(System.Char[] buffer, int offset, int length) { }
    public virtual void SetTermBuffer(string buffer) { }
    public virtual void SetTermBuffer(string buffer, int offset, int length) { }
    public virtual void SetTermLength(int length) { }
    public virtual System.Char[] TermBuffer() { return default(System.Char[]); }
    public virtual int TermLength() { return default(int); }
    public override string ToString() { return default(string); }
  }
  public partial class TypeAttribute : Lucene.Net.Util.Attribute, Lucene.Net.Analysis.Tokenattributes.ITypeAttribute, Lucene.Net.Util.IAttribute, System.ICloneable {
    public const string DEFAULT_TYPE = "word";
    public TypeAttribute() { }
    public TypeAttribute(string type) { }
    public virtual string Type { get { return default(string); } set { } }
    public override void Clear() { }
    public override object Clone() { return default(object); }
    public override void CopyTo(Lucene.Net.Util.Attribute target) { }
    public override bool Equals(object other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }
}
namespace Lucene.Net.Documents {
  public abstract partial class AbstractField : Lucene.Net.Documents.IFieldable {
    protected internal object fieldsData;
    protected internal int internalBinaryLength;
    protected internal int internalbinaryOffset;
    protected internal float internalBoost;
    protected internal bool internalIsBinary;
    protected internal bool internalIsIndexed;
    protected internal bool internalIsStored;
    protected internal bool internalIsTokenized;
    protected internal string internalName;
    protected internal bool internalOmitNorms;
    protected internal bool internalOmitTermFreqAndPositions;
    protected internal bool lazy;
    protected internal bool storeOffsetWithTermVector;
    protected internal bool storePositionWithTermVector;
    protected internal bool storeTermVector;
    protected internal Lucene.Net.Analysis.TokenStream tokenStream;
    protected internal AbstractField() { }
    protected internal AbstractField(string name, Lucene.Net.Documents.Field.Store store, Lucene.Net.Documents.Field.Index index, Lucene.Net.Documents.Field.TermVector termVector) { }
    public virtual int BinaryLength { get { return default(int); } }
    public virtual int BinaryOffset { get { return default(int); } }
    public virtual float Boost { get { return default(float); } set { } }
    public bool IsBinary { get { return default(bool); } }
    public bool IsIndexed { get { return default(bool); } }
    public virtual bool IsLazy { get { return default(bool); } }
    public bool IsStored { get { return default(bool); } }
    public virtual bool IsStoreOffsetWithTermVector { get { return default(bool); } }
    public virtual bool IsStorePositionWithTermVector { get { return default(bool); } }
    public bool IsTermVectorStored { get { return default(bool); } }
    public bool IsTokenized { get { return default(bool); } }
    public virtual string Name { get { return default(string); } }
    public virtual bool OmitNorms { get { return default(bool); } set { } }
    public virtual bool OmitTermFreqAndPositions { get { return default(bool); } set { } }
    public abstract System.IO.TextReader ReaderValue { get; }
    public abstract string StringValue { get; }
    public abstract Lucene.Net.Analysis.TokenStream TokenStreamValue { get; }
    public virtual System.Byte[] GetBinaryValue() { return default(System.Byte[]); }
    public virtual System.Byte[] GetBinaryValue(System.Byte[] result) { return default(System.Byte[]); }
    protected internal virtual void SetStoreTermVector(Lucene.Net.Documents.Field.TermVector termVector) { }
    public override string ToString() { return default(string); }
  }
  public partial class CompressionTools {
    internal CompressionTools() { }
    public static System.Byte[] Compress(System.Byte[] value_Renamed) { return default(System.Byte[]); }
    public static System.Byte[] Compress(System.Byte[] value_Renamed, int offset, int length) { return default(System.Byte[]); }
    public static System.Byte[] Compress(System.Byte[] value_Renamed, int offset, int length, int compressionLevel) { return default(System.Byte[]); }
    public static System.Byte[] CompressString(string value_Renamed) { return default(System.Byte[]); }
    public static System.Byte[] CompressString(string value_Renamed, int compressionLevel) { return default(System.Byte[]); }
    public static System.Byte[] Decompress(System.Byte[] value_Renamed) { return default(System.Byte[]); }
    public static string DecompressString(System.Byte[] value_Renamed) { return default(string); }
  }
  [System.ObsoleteAttribute("If you build a new index, use DateTools or NumericField instead.This class is included for use with existing indices and will be removed in a future release (possibly Lucene 4.0).")]
  public partial class DateField {
    internal DateField() { }
    public static string DateToString(System.DateTime date) { return default(string); }
    public static string MAX_DATE_STRING() { return default(string); }
    public static string MIN_DATE_STRING() { return default(string); }
    public static System.DateTime StringToDate(string s) { return default(System.DateTime); }
    public static long StringToTime(string s) { return default(long); }
    public static string TimeToString(long time) { return default(string); }
  }
  public partial class DateTools {
    internal DateTools() { }
    public static string DateToString(System.DateTime date, Lucene.Net.Documents.DateTools.Resolution resolution) { return default(string); }
    public static System.DateTime Round(System.DateTime date, Lucene.Net.Documents.DateTools.Resolution resolution) { return default(System.DateTime); }
    public static long Round(long time, Lucene.Net.Documents.DateTools.Resolution resolution) { return default(long); }
    public static System.DateTime StringToDate(string dateString) { return default(System.DateTime); }
    public static long StringToTime(string dateString) { return default(long); }
    public static string TimeToString(long time, Lucene.Net.Documents.DateTools.Resolution resolution) { return default(string); }
    public partial class Resolution {
      internal Resolution() { }
      public static readonly Lucene.Net.Documents.DateTools.Resolution DAY;
      public static readonly Lucene.Net.Documents.DateTools.Resolution HOUR;
      public static readonly Lucene.Net.Documents.DateTools.Resolution MILLISECOND;
      public static readonly Lucene.Net.Documents.DateTools.Resolution MINUTE;
      public static readonly Lucene.Net.Documents.DateTools.Resolution MONTH;
      public static readonly Lucene.Net.Documents.DateTools.Resolution SECOND;
      public static readonly Lucene.Net.Documents.DateTools.Resolution YEAR;
      public override string ToString() { return default(string); }
    }
  }
  public sealed partial class Document {
    public Document() { }
    public float Boost { get { return default(float); } set { } }
    public System.Collections.Generic.IList<Lucene.Net.Documents.IFieldable> fields_ForNUnit { get { return default(System.Collections.Generic.IList<Lucene.Net.Documents.IFieldable>); } }
    public void Add(Lucene.Net.Documents.IFieldable field) { }
    public string Get(string name) { return default(string); }
    public System.Byte[] GetBinaryValue(string name) { return default(System.Byte[]); }
    public System.Byte[][] GetBinaryValues(string name) { return default(System.Byte[][]); }
    public Lucene.Net.Documents.Field GetField(string name) { return default(Lucene.Net.Documents.Field); }
    public Lucene.Net.Documents.IFieldable GetFieldable(string name) { return default(Lucene.Net.Documents.IFieldable); }
    public Lucene.Net.Documents.IFieldable[] GetFieldables(string name) { return default(Lucene.Net.Documents.IFieldable[]); }
    public System.Collections.Generic.IList<Lucene.Net.Documents.IFieldable> GetFields() { return default(System.Collections.Generic.IList<Lucene.Net.Documents.IFieldable>); }
    public Lucene.Net.Documents.Field[] GetFields(string name) { return default(Lucene.Net.Documents.Field[]); }
    public System.String[] GetValues(string name) { return default(System.String[]); }
    public void RemoveField(string name) { }
    public void RemoveFields(string name) { }
    public override string ToString() { return default(string); }
  }
  public sealed partial class Field : Lucene.Net.Documents.AbstractField, Lucene.Net.Documents.IFieldable {
    public Field(string name, Lucene.Net.Analysis.TokenStream tokenStream) { }
    public Field(string name, Lucene.Net.Analysis.TokenStream tokenStream, Lucene.Net.Documents.Field.TermVector termVector) { }
    public Field(string name, bool internName, string value, Lucene.Net.Documents.Field.Store store, Lucene.Net.Documents.Field.Index index, Lucene.Net.Documents.Field.TermVector termVector) { }
    public Field(string name, System.Byte[] value_Renamed, Lucene.Net.Documents.Field.Store store) { }
    public Field(string name, System.Byte[] value_Renamed, int offset, int length, Lucene.Net.Documents.Field.Store store) { }
    public Field(string name, System.IO.TextReader reader) { }
    public Field(string name, System.IO.TextReader reader, Lucene.Net.Documents.Field.TermVector termVector) { }
    public Field(string name, string value, Lucene.Net.Documents.Field.Store store, Lucene.Net.Documents.Field.Index index) { }
    public Field(string name, string value, Lucene.Net.Documents.Field.Store store, Lucene.Net.Documents.Field.Index index, Lucene.Net.Documents.Field.TermVector termVector) { }
    public override System.IO.TextReader ReaderValue { get { return default(System.IO.TextReader); } }
    public override string StringValue { get { return default(string); } }
    public override Lucene.Net.Analysis.TokenStream TokenStreamValue { get { return default(Lucene.Net.Analysis.TokenStream); } }
    public void SetTokenStream(Lucene.Net.Analysis.TokenStream tokenStream) { }
    public void SetValue(System.Byte[] value) { }
    public void SetValue(System.Byte[] value, int offset, int length) { }
    public void SetValue(System.IO.TextReader value) { }
    public void SetValue(string value) { }
    public enum Index {
      ANALYZED = 1,
      ANALYZED_NO_NORMS = 4,
      NO = 0,
      NOT_ANALYZED = 2,
      NOT_ANALYZED_NO_NORMS = 3,
    }
    public enum Store {
      NO = 1,
      YES = 0,
    }
    public enum TermVector {
      NO = 0,
      WITH_OFFSETS = 3,
      WITH_POSITIONS = 2,
      WITH_POSITIONS_OFFSETS = 4,
      YES = 1,
    }
  }
  public static partial class FieldExtensions {
    public static bool IsAnalyzed(this Lucene.Net.Documents.Field.Index index) { return default(bool); }
    public static bool IsIndexed(this Lucene.Net.Documents.Field.Index index) { return default(bool); }
    public static bool IsStored(this Lucene.Net.Documents.Field.Store store) { return default(bool); }
    public static bool IsStored(this Lucene.Net.Documents.Field.TermVector tv) { return default(bool); }
    public static bool OmitNorms(this Lucene.Net.Documents.Field.Index index) { return default(bool); }
    public static Lucene.Net.Documents.Field.Index ToIndex(bool indexed, bool analyed) { return default(Lucene.Net.Documents.Field.Index); }
    public static Lucene.Net.Documents.Field.Index ToIndex(bool indexed, bool analyzed, bool omitNorms) { return default(Lucene.Net.Documents.Field.Index); }
    public static Lucene.Net.Documents.Field.TermVector ToTermVector(bool stored, bool withOffsets, bool withPositions) { return default(Lucene.Net.Documents.Field.TermVector); }
    public static bool WithOffsets(this Lucene.Net.Documents.Field.TermVector tv) { return default(bool); }
    public static bool WithPositions(this Lucene.Net.Documents.Field.TermVector tv) { return default(bool); }
  }
  public partial interface FieldSelector {
    Lucene.Net.Documents.FieldSelectorResult Accept(string fieldName);
  }
  public enum FieldSelectorResult {
    INVALID = 0,
    LAZY_LOAD = 2,
    LOAD = 1,
    LOAD_AND_BREAK = 4,
    NO_LOAD = 3,
    SIZE = 5,
    SIZE_AND_BREAK = 6,
  }
  public partial interface IFieldable {
    int BinaryLength { get; }
    int BinaryOffset { get; }
    float Boost { get; set; }
    bool IsBinary { get; }
    bool IsIndexed { get; }
    bool IsLazy { get; }
    bool IsStored { get; }
    bool IsStoreOffsetWithTermVector { get; }
    bool IsStorePositionWithTermVector { get; }
    bool IsTermVectorStored { get; }
    bool IsTokenized { get; }
    string Name { get; }
    bool OmitNorms { get; set; }
    bool OmitTermFreqAndPositions { get; set; }
    System.IO.TextReader ReaderValue { get; }
    string StringValue { get; }
    Lucene.Net.Analysis.TokenStream TokenStreamValue { get; }
    System.Byte[] GetBinaryValue();
    System.Byte[] GetBinaryValue(System.Byte[] result);
  }
  public partial class LoadFirstFieldSelector : Lucene.Net.Documents.FieldSelector {
    public LoadFirstFieldSelector() { }
    public virtual Lucene.Net.Documents.FieldSelectorResult Accept(string fieldName) { return default(Lucene.Net.Documents.FieldSelectorResult); }
  }
  public partial class MapFieldSelector : Lucene.Net.Documents.FieldSelector {
    public MapFieldSelector(System.Collections.Generic.IDictionary<System.String, Lucene.Net.Documents.FieldSelectorResult> fieldSelections) { }
    public MapFieldSelector(System.Collections.Generic.IList<System.String> fields) { }
    public MapFieldSelector(params System.String[] fields) { }
    public virtual Lucene.Net.Documents.FieldSelectorResult Accept(string field) { return default(Lucene.Net.Documents.FieldSelectorResult); }
  }
  [System.ObsoleteAttribute("For new indexes use NumericUtils instead, which provides a sortable binary representation (prefix encoded) of numeric values. To index and efficiently query numeric values use NumericField and NumericRangeQuery. This class is included for use with existing indices and will be removed in a future release (possibly Lucene 4.0).")]
  public partial class NumberTools {
    public static readonly string MAX_STRING_VALUE;
    public static readonly string MIN_STRING_VALUE;
    public static readonly int STR_SIZE;
    public NumberTools() { }
    public static string LongToString(long l) { return default(string); }
    public static long StringToLong(string str) { return default(long); }
    public static long ToLong(string t) { return default(long); }
    public static string ToString(long lval) { return default(string); }
  }
  public sealed partial class NumericField : Lucene.Net.Documents.AbstractField {
    public NumericField(string name) { }
    public NumericField(string name, Lucene.Net.Documents.Field.Store store, bool index) { }
    public NumericField(string name, int precisionStep) { }
    public NumericField(string name, int precisionStep, Lucene.Net.Documents.Field.Store store, bool index) { }
    public System.ValueType NumericValue { get { return default(System.ValueType); } }
    public override System.IO.TextReader ReaderValue { get { return default(System.IO.TextReader); } }
    public override string StringValue { get { return default(string); } }
    public override Lucene.Net.Analysis.TokenStream TokenStreamValue { get { return default(Lucene.Net.Analysis.TokenStream); } }
    public override System.Byte[] GetBinaryValue(System.Byte[] result) { return default(System.Byte[]); }
    public Lucene.Net.Documents.NumericField SetDoubleValue(double value_Renamed) { return default(Lucene.Net.Documents.NumericField); }
    public Lucene.Net.Documents.NumericField SetFloatValue(float value_Renamed) { return default(Lucene.Net.Documents.NumericField); }
    public Lucene.Net.Documents.NumericField SetIntValue(int value_Renamed) { return default(Lucene.Net.Documents.NumericField); }
    public Lucene.Net.Documents.NumericField SetLongValue(long value_Renamed) { return default(Lucene.Net.Documents.NumericField); }
  }
  public partial class SetBasedFieldSelector : Lucene.Net.Documents.FieldSelector {
    public SetBasedFieldSelector(System.Collections.Generic.ISet<System.String> fieldsToLoad, System.Collections.Generic.ISet<System.String> lazyFieldsToLoad) { }
    public virtual Lucene.Net.Documents.FieldSelectorResult Accept(string fieldName) { return default(Lucene.Net.Documents.FieldSelectorResult); }
  }
}
namespace Lucene.Net.Index {
  public abstract partial class AbstractAllTermDocs : Lucene.Net.Index.TermDocs, System.IDisposable {
    protected int internalDoc;
    protected int maxDoc;
    protected AbstractAllTermDocs(int maxDoc) { }
    public int Doc { get { return default(int); } }
    public int Freq { get { return default(int); } }
    public void Close() { }
    public void Dispose() { }
    protected abstract void Dispose(bool disposing);
    public abstract bool IsDeleted(int doc);
    public bool Next() { return default(bool); }
    public int Read(System.Int32[] docs, System.Int32[] freqs) { return default(int); }
    public void Seek(Lucene.Net.Index.Term term) { }
    public void Seek(Lucene.Net.Index.TermEnum termEnum) { }
    public bool SkipTo(int target) { return default(bool); }
  }
  public sealed partial class ByteBlockPool {
    public System.Byte[] buffer;
    public System.Byte[][] buffers;
    public int byteOffset;
    public int byteUpto;
    public static readonly int FIRST_LEVEL_SIZE_For_NUnit_Test;
    public ByteBlockPool(Lucene.Net.Index.ByteBlockPool.Allocator allocator, bool trackAllocations) { }
    public static int FIRST_LEVEL_SIZE_ForNUnit { get { return default(int); } }
    public int AllocSlice(System.Byte[] slice, int upto) { return default(int); }
    public int NewSlice(int size) { return default(int); }
    public void NextBuffer() { }
    public void Reset() { }
    public abstract partial class Allocator {
      protected Allocator() { }
      public abstract System.Byte[] GetByteBlock(bool trackAllocations);
      public abstract void RecycleByteBlocks(System.Byte[][] blocks, int start, int end);
      public abstract void RecycleByteBlocks(System.Collections.Generic.IList<System.Byte[]> blocks);
    }
  }
  public sealed partial class ByteSliceReader : Lucene.Net.Store.IndexInput {
    public int bufferOffset;
    public int endIndex;
    public int upto;
    public ByteSliceReader() { }
    public override long FilePointer { get { return default(long); } }
    public override object Clone() { return default(object); }
    protected override void Dispose(bool disposing) { }
    public bool Eof() { return default(bool); }
    public void Init(Lucene.Net.Index.ByteBlockPool pool, int startIndex, int endIndex) { }
    public override long Length() { return default(long); }
    public void NextSlice() { }
    public override byte ReadByte() { return default(byte); }
    public override void ReadBytes(System.Byte[] b, int offset, int len) { }
    public override void Seek(long pos) { }
    public long WriteTo(Lucene.Net.Store.IndexOutput @out) { return default(long); }
  }
  public sealed partial class ByteSliceWriter {
    public ByteSliceWriter(Lucene.Net.Index.ByteBlockPool pool) { }
    public int Address { get { return default(int); } }
    public void Init(int address) { }
    public void WriteByte(byte b) { }
    public void WriteBytes(System.Byte[] b, int offset, int len) { }
    public void WriteVInt(int i) { }
  }
  public partial class CheckIndex {
    public CheckIndex(Lucene.Net.Store.Directory dir) { }
    public virtual Lucene.Net.Index.CheckIndex.Status CheckIndex_Renamed_Method() { return default(Lucene.Net.Index.CheckIndex.Status); }
    public virtual Lucene.Net.Index.CheckIndex.Status CheckIndex_Renamed_Method(System.Collections.Generic.List<System.String> onlySegments) { return default(Lucene.Net.Index.CheckIndex.Status); }
    public virtual void FixIndex(Lucene.Net.Index.CheckIndex.Status result) { }
    [System.STAThreadAttribute]
    public static void Main(System.String[] args) { }
    public virtual void SetInfoStream(System.IO.StreamWriter @out) { }
    public partial class Status {
      public bool cantOpenSegments;
      public bool clean;
      public Lucene.Net.Store.Directory dir;
      public bool missingSegments;
      public bool missingSegmentVersion;
      public int numBadSegments;
      public int numSegments;
      public bool @partial;
      public string segmentFormat;
      public System.Collections.Generic.IList<Lucene.Net.Index.CheckIndex.Status.SegmentInfoStatus> segmentInfos;
      public System.Collections.Generic.List<System.String> segmentsChecked;
      public string segmentsFileName;
      public bool toolOutOfDate;
      public int totLoseDocCount;
      public System.Collections.Generic.IDictionary<System.String, System.String> userData;
      public Status() { }
      public sealed partial class FieldNormStatus {
        public System.Exception error;
        public long totFields;
        public FieldNormStatus() { }
      }
      public partial class SegmentInfoStatus {
        public bool compound;
        public string deletionsFileName;
        public System.Collections.Generic.IDictionary<System.String, System.String> diagnostics;
        public int docCount;
        public bool docStoreCompoundFile;
        public int docStoreOffset;
        public string docStoreSegment;
        public Lucene.Net.Index.CheckIndex.Status.FieldNormStatus fieldNormStatus;
        public bool hasDeletions;
        public bool hasProx;
        public string name;
        public int numDeleted;
        public int numFiles;
        public bool openReaderPassed;
        public double sizeMB;
        public Lucene.Net.Index.CheckIndex.Status.StoredFieldStatus storedFieldStatus;
        public Lucene.Net.Index.CheckIndex.Status.TermIndexStatus termIndexStatus;
        public Lucene.Net.Index.CheckIndex.Status.TermVectorStatus termVectorStatus;
        public SegmentInfoStatus() { }
      }
      public sealed partial class StoredFieldStatus {
        public int docCount;
        public System.Exception error;
        public long totFields;
        public StoredFieldStatus() { }
      }
      public sealed partial class TermIndexStatus {
        public System.Exception error;
        public long termCount;
        public long totFreq;
        public long totPos;
        public TermIndexStatus() { }
      }
      public sealed partial class TermVectorStatus {
        public int docCount;
        public System.Exception error;
        public long totVectors;
        public TermVectorStatus() { }
      }
    }
  }
  public partial class CompoundFileReader : Lucene.Net.Store.Directory {
    public CompoundFileReader(Lucene.Net.Store.Directory dir, string name) { }
    public CompoundFileReader(Lucene.Net.Store.Directory dir, string name, int readBufferSize) { }
    public virtual Lucene.Net.Store.Directory Directory { get { return default(Lucene.Net.Store.Directory); } }
    public virtual string Name { get { return default(string); } }
    public override Lucene.Net.Store.IndexOutput CreateOutput(string name) { return default(Lucene.Net.Store.IndexOutput); }
    public override void DeleteFile(string name) { }
    protected override void Dispose(bool disposing) { }
    public override bool FileExists(string name) { return default(bool); }
    public override long FileLength(string name) { return default(long); }
    public override long FileModified(string name) { return default(long); }
    public override System.String[] ListAll() { return default(System.String[]); }
    public override Lucene.Net.Store.Lock MakeLock(string name) { return default(Lucene.Net.Store.Lock); }
    public override Lucene.Net.Store.IndexInput OpenInput(string id) { return default(Lucene.Net.Store.IndexInput); }
    public override Lucene.Net.Store.IndexInput OpenInput(string id, int readBufferSize) { return default(Lucene.Net.Store.IndexInput); }
    public void RenameFile(string from, string to) { }
    public override void TouchFile(string name) { }
    public sealed partial class CSIndexInput : Lucene.Net.Store.BufferedIndexInput {
      internal CSIndexInput() { }
      public Lucene.Net.Store.IndexInput base_Renamed_ForNUnit { get { return default(Lucene.Net.Store.IndexInput); } }
      public override object Clone() { return default(object); }
      protected override void Dispose(bool disposing) { }
      public override long Length() { return default(long); }
      public override void ReadInternal(System.Byte[] b, int offset, int len) { }
      public override void SeekInternal(long pos) { }
    }
  }
  public sealed partial class CompoundFileWriter : System.IDisposable {
    public CompoundFileWriter(Lucene.Net.Store.Directory dir, string name) { }
    public Lucene.Net.Store.Directory Directory { get { return default(Lucene.Net.Store.Directory); } }
    public string Name { get { return default(string); } }
    public void AddFile(string file) { }
    [System.ObsoleteAttribute("Use Dispose() instead")]
    public void Close() { }
    public void Dispose() { }
  }
  public partial class ConcurrentMergeScheduler : Lucene.Net.Index.MergeScheduler {
    protected internal Lucene.Net.Store.Directory dir;
    protected internal int mergeThreadCount;
    protected internal System.Collections.Generic.IList<Lucene.Net.Index.ConcurrentMergeScheduler.MergeThread> mergeThreads;
    protected internal Lucene.Net.Index.IndexWriter writer;
    public ConcurrentMergeScheduler() { }
    public virtual int MaxThreadCount { get { return default(int); } set { } }
    public static bool AnyUnhandledExceptions() { return default(bool); }
    public virtual void ClearSuppressExceptions() { }
    public static void ClearUnhandledExceptions() { }
    protected override void Dispose(bool disposing) { }
    protected internal virtual void DoMerge(Lucene.Net.Index.MergePolicy.OneMerge merge) { }
    protected internal virtual Lucene.Net.Index.ConcurrentMergeScheduler.MergeThread GetMergeThread(Lucene.Net.Index.IndexWriter writer, Lucene.Net.Index.MergePolicy.OneMerge merge) { return default(Lucene.Net.Index.ConcurrentMergeScheduler.MergeThread); }
    public virtual int GetMergeThreadPriority() { return default(int); }
    protected internal virtual void HandleMergeException(System.Exception exc) { }
    public override void Merge(Lucene.Net.Index.IndexWriter writer) { }
    public virtual void SetMergeThreadPriority(int pri) { }
    public virtual void SetSuppressExceptions() { }
    public static void SetTestMode() { }
    public virtual void Sync() { }
    public partial class MergeThread : Lucene.Net.Support.ThreadClass {
      public MergeThread(Lucene.Net.Index.ConcurrentMergeScheduler enclosingInstance, Lucene.Net.Index.IndexWriter writer, Lucene.Net.Index.MergePolicy.OneMerge startMerge) { }
      public Lucene.Net.Index.ConcurrentMergeScheduler Enclosing_Instance { get { return default(Lucene.Net.Index.ConcurrentMergeScheduler); } }
      public virtual Lucene.Net.Index.MergePolicy.OneMerge RunningMerge { get { return default(Lucene.Net.Index.MergePolicy.OneMerge); } }
      public override void Run() { }
      public virtual void SetRunningMerge(Lucene.Net.Index.MergePolicy.OneMerge merge) { }
      public virtual void SetThreadPriority(int pri) { }
      public override string ToString() { return default(string); }
    }
  }
  public partial class CorruptIndexException : System.IO.IOException {
    public CorruptIndexException(string message) { }
    public CorruptIndexException(string message, System.Exception exp) { }
  }
  public partial class DirectoryReader : Lucene.Net.Index.IndexReader {
    internal DirectoryReader() { }
    protected internal Lucene.Net.Store.Directory internalDirectory;
    protected internal bool readOnly;
    public override System.Collections.Generic.IDictionary<System.String, System.String> CommitUserData { get { return default(System.Collections.Generic.IDictionary<System.String, System.String>); } }
    public override bool HasDeletions { get { return default(bool); } }
    public override Lucene.Net.Index.IndexCommit IndexCommit { get { return default(Lucene.Net.Index.IndexCommit); } }
    public override int MaxDoc { get { return default(int); } }
    public override int TermInfosIndexDivisor { get { return default(int); } }
    public override long Version { get { return default(long); } }
    protected internal override void AcquireWriteLock() { }
    public override object Clone() { return default(object); }
    public override Lucene.Net.Index.IndexReader Clone(bool openReadOnly) { return default(Lucene.Net.Index.IndexReader); }
    public override Lucene.Net.Store.Directory Directory() { return default(Lucene.Net.Store.Directory); }
    public override int DocFreq(Lucene.Net.Index.Term t) { return default(int); }
    protected internal override void DoClose() { }
    protected internal override void DoCommit(System.Collections.Generic.IDictionary<System.String, System.String> commitUserData) { }
    public override Lucene.Net.Documents.Document Document(int n, Lucene.Net.Documents.FieldSelector fieldSelector) { return default(Lucene.Net.Documents.Document); }
    protected internal override void DoDelete(int n) { }
    protected internal override void DoSetNorm(int n, string field, byte value_Renamed) { }
    protected internal override void DoUndeleteAll() { }
    public override System.Collections.Generic.ICollection<System.String> GetFieldNames(Lucene.Net.Index.IndexReader.FieldOption fieldNames) { return default(System.Collections.Generic.ICollection<System.String>); }
    public override Lucene.Net.Index.IndexReader[] GetSequentialSubReaders() { return default(Lucene.Net.Index.IndexReader[]); }
    public override void GetTermFreqVector(int docNumber, Lucene.Net.Index.TermVectorMapper mapper) { }
    public override Lucene.Net.Index.ITermFreqVector GetTermFreqVector(int n, string field) { return default(Lucene.Net.Index.ITermFreqVector); }
    public override void GetTermFreqVector(int docNumber, string field, Lucene.Net.Index.TermVectorMapper mapper) { }
    public override Lucene.Net.Index.ITermFreqVector[] GetTermFreqVectors(int n) { return default(Lucene.Net.Index.ITermFreqVector[]); }
    public override bool HasNorms(string field) { return default(bool); }
    public override bool IsCurrent() { return default(bool); }
    public override bool IsDeleted(int n) { return default(bool); }
    public override bool IsOptimized() { return default(bool); }
    public static new System.Collections.Generic.ICollection<Lucene.Net.Index.IndexCommit> ListCommits(Lucene.Net.Store.Directory dir) { return default(System.Collections.Generic.ICollection<Lucene.Net.Index.IndexCommit>); }
    public override System.Byte[] Norms(string field) { return default(System.Byte[]); }
    public override void Norms(string field, System.Byte[] result, int offset) { }
    public override int NumDocs() { return default(int); }
    public override Lucene.Net.Index.IndexReader Reopen() { return default(Lucene.Net.Index.IndexReader); }
    public override Lucene.Net.Index.IndexReader Reopen(Lucene.Net.Index.IndexCommit commit) { return default(Lucene.Net.Index.IndexReader); }
    public override Lucene.Net.Index.IndexReader Reopen(bool openReadOnly) { return default(Lucene.Net.Index.IndexReader); }
    public override Lucene.Net.Index.TermDocs TermDocs() { return default(Lucene.Net.Index.TermDocs); }
    public override Lucene.Net.Index.TermPositions TermPositions() { return default(Lucene.Net.Index.TermPositions); }
    public override Lucene.Net.Index.TermEnum Terms() { return default(Lucene.Net.Index.TermEnum); }
    public override Lucene.Net.Index.TermEnum Terms(Lucene.Net.Index.Term term) { return default(Lucene.Net.Index.TermEnum); }
  }
  public sealed partial class DocumentsWriter : System.IDisposable {
    internal DocumentsWriter() { }
    public static int BYTE_BLOCK_SIZE_ForNUnit { get { return default(int); } }
    public static int CHAR_BLOCK_SIZE_ForNUnit { get { return default(int); } }
    public void Dispose() { }
  }
  public sealed partial class FieldInfo : System.ICloneable {
    internal FieldInfo() { }
    public bool isIndexed_ForNUnit { get { return default(bool); } }
    public string name_ForNUnit { get { return default(string); } }
    public bool omitNorms_ForNUnit { get { return default(bool); } }
    public bool omitTermFreqAndPositions_ForNUnit { get { return default(bool); } }
    public bool storePayloads_ForNUnit { get { return default(bool); } }
    public bool storeTermVector_ForNUnit { get { return default(bool); } }
    public object Clone() { return default(object); }
  }
  public sealed partial class FieldInfos : System.ICloneable {
    public const int FORMAT_PRE = -1;
    public const int FORMAT_START = -2;
    public FieldInfos() { }
    public FieldInfos(Lucene.Net.Store.Directory d, string name) { }
    public void Add(Lucene.Net.Documents.Document doc) { }
    public void Add(System.Collections.Generic.ICollection<System.String> names, bool isIndexed) { }
    public void Add(string name, bool isIndexed) { }
    public void Add(string name, bool isIndexed, bool storeTermVector) { }
    public void Add(string name, bool isIndexed, bool storeTermVector, bool storePositionWithTermVector, bool storeOffsetWithTermVector) { }
    public void Add(string name, bool isIndexed, bool storeTermVector, bool storePositionWithTermVector, bool storeOffsetWithTermVector, bool omitNorms) { }
    public Lucene.Net.Index.FieldInfo Add(string name, bool isIndexed, bool storeTermVector, bool storePositionWithTermVector, bool storeOffsetWithTermVector, bool omitNorms, bool storePayloads, bool omitTermFreqAndPositions) { return default(Lucene.Net.Index.FieldInfo); }
    public void AddIndexed(System.Collections.Generic.ICollection<System.String> names, bool storeTermVectors, bool storePositionWithTermVector, bool storeOffsetWithTermVector) { }
    public object Clone() { return default(object); }
    public Lucene.Net.Index.FieldInfo FieldInfo(int fieldNumber) { return default(Lucene.Net.Index.FieldInfo); }
    public Lucene.Net.Index.FieldInfo FieldInfo(string fieldName) { return default(Lucene.Net.Index.FieldInfo); }
    public string FieldName(int fieldNumber) { return default(string); }
    public int FieldNumber(string fieldName) { return default(int); }
    public bool HasVectors() { return default(bool); }
    public int Size() { return default(int); }
    public void Write(Lucene.Net.Store.Directory d, string name) { }
    public void Write(Lucene.Net.Store.IndexOutput output) { }
  }
  public sealed partial class FieldInvertState {
    public FieldInvertState() { }
    public FieldInvertState(int position, int length, int numOverlap, int offset, float boost) { }
    public Lucene.Net.Util.AttributeSource AttributeSource { get { return default(Lucene.Net.Util.AttributeSource); } }
    public float Boost { get { return default(float); } }
    public int Length { get { return default(int); } }
    public int NumOverlap { get { return default(int); } }
    public int Offset { get { return default(int); } }
    public int Position { get { return default(int); } }
  }
  public partial class FieldReaderException : System.SystemException {
    public FieldReaderException() { }
    public FieldReaderException(System.Exception cause) { }
    public FieldReaderException(string message) { }
    public FieldReaderException(string message, System.Exception cause) { }
  }
  public partial class FieldSortedTermVectorMapper : Lucene.Net.Index.TermVectorMapper {
    public FieldSortedTermVectorMapper(bool ignoringPositions, bool ignoringOffsets, System.Collections.Generic.IComparer<Lucene.Net.Index.TermVectorEntry> comparator) { }
    public FieldSortedTermVectorMapper(System.Collections.Generic.IComparer<Lucene.Net.Index.TermVectorEntry> comparator) { }
    public virtual System.Collections.Generic.IComparer<Lucene.Net.Index.TermVectorEntry> Comparator { get { return default(System.Collections.Generic.IComparer<Lucene.Net.Index.TermVectorEntry>); } }
    public virtual System.Collections.Generic.IDictionary<System.String, System.Collections.Generic.SortedSet<Lucene.Net.Index.TermVectorEntry>> FieldToTerms { get { return default(System.Collections.Generic.IDictionary<System.String, System.Collections.Generic.SortedSet<Lucene.Net.Index.TermVectorEntry>>); } }
    public override void Map(string term, int frequency, Lucene.Net.Index.TermVectorOffsetInfo[] offsets, System.Int32[] positions) { }
    public override void SetExpectations(string field, int numTerms, bool storeOffsets, bool storePositions) { }
  }
  public sealed partial class FieldsReader : System.ICloneable, System.IDisposable {
    public FieldsReader(Lucene.Net.Store.Directory d, string segment, Lucene.Net.Index.FieldInfos fn) { }
    public object Clone() { return default(object); }
    public void Dispose() { }
    public Lucene.Net.Documents.Document Doc(int n, Lucene.Net.Documents.FieldSelector fieldSelector) { return default(Lucene.Net.Documents.Document); }
    public int Size() { return default(int); }
  }
  public partial class FilterIndexReader : Lucene.Net.Index.IndexReader {
    protected internal Lucene.Net.Index.IndexReader in_Renamed;
    public FilterIndexReader(Lucene.Net.Index.IndexReader in_Renamed) { }
    public override object DeletesCacheKey { get { return default(object); } }
    public override object FieldCacheKey { get { return default(object); } }
    public override bool HasDeletions { get { return default(bool); } }
    public override int MaxDoc { get { return default(int); } }
    public override long Version { get { return default(long); } }
    public override object Clone() { return default(object); }
    public override Lucene.Net.Store.Directory Directory() { return default(Lucene.Net.Store.Directory); }
    public override int DocFreq(Lucene.Net.Index.Term t) { return default(int); }
    protected internal override void DoClose() { }
    protected internal override void DoCommit(System.Collections.Generic.IDictionary<System.String, System.String> commitUserData) { }
    public override Lucene.Net.Documents.Document Document(int n, Lucene.Net.Documents.FieldSelector fieldSelector) { return default(Lucene.Net.Documents.Document); }
    protected internal override void DoDelete(int n) { }
    protected internal override void DoSetNorm(int d, string f, byte b) { }
    protected internal override void DoUndeleteAll() { }
    public override System.Collections.Generic.ICollection<System.String> GetFieldNames(Lucene.Net.Index.IndexReader.FieldOption fieldNames) { return default(System.Collections.Generic.ICollection<System.String>); }
    public override Lucene.Net.Index.IndexReader[] GetSequentialSubReaders() { return default(Lucene.Net.Index.IndexReader[]); }
    public override void GetTermFreqVector(int docNumber, Lucene.Net.Index.TermVectorMapper mapper) { }
    public override Lucene.Net.Index.ITermFreqVector GetTermFreqVector(int docNumber, string field) { return default(Lucene.Net.Index.ITermFreqVector); }
    public override void GetTermFreqVector(int docNumber, string field, Lucene.Net.Index.TermVectorMapper mapper) { }
    public override Lucene.Net.Index.ITermFreqVector[] GetTermFreqVectors(int docNumber) { return default(Lucene.Net.Index.ITermFreqVector[]); }
    public override bool HasNorms(string field) { return default(bool); }
    public override bool IsCurrent() { return default(bool); }
    public override bool IsDeleted(int n) { return default(bool); }
    public override bool IsOptimized() { return default(bool); }
    public override System.Byte[] Norms(string f) { return default(System.Byte[]); }
    public override void Norms(string f, System.Byte[] bytes, int offset) { }
    public override int NumDocs() { return default(int); }
    public override Lucene.Net.Index.TermDocs TermDocs() { return default(Lucene.Net.Index.TermDocs); }
    public override Lucene.Net.Index.TermDocs TermDocs(Lucene.Net.Index.Term term) { return default(Lucene.Net.Index.TermDocs); }
    public override Lucene.Net.Index.TermPositions TermPositions() { return default(Lucene.Net.Index.TermPositions); }
    public override Lucene.Net.Index.TermEnum Terms() { return default(Lucene.Net.Index.TermEnum); }
    public override Lucene.Net.Index.TermEnum Terms(Lucene.Net.Index.Term t) { return default(Lucene.Net.Index.TermEnum); }
    public partial class FilterTermDocs : Lucene.Net.Index.TermDocs, System.IDisposable {
      protected internal Lucene.Net.Index.TermDocs in_Renamed;
      public FilterTermDocs(Lucene.Net.Index.TermDocs in_Renamed) { }
      public virtual int Doc { get { return default(int); } }
      public virtual int Freq { get { return default(int); } }
      public void Close() { }
      public void Dispose() { }
      protected virtual void Dispose(bool disposing) { }
      public virtual bool Next() { return default(bool); }
      public virtual int Read(System.Int32[] docs, System.Int32[] freqs) { return default(int); }
      public virtual void Seek(Lucene.Net.Index.Term term) { }
      public virtual void Seek(Lucene.Net.Index.TermEnum termEnum) { }
      public virtual bool SkipTo(int i) { return default(bool); }
    }
    public partial class FilterTermEnum : Lucene.Net.Index.TermEnum {
      protected internal Lucene.Net.Index.TermEnum in_Renamed;
      public FilterTermEnum(Lucene.Net.Index.TermEnum in_Renamed) { }
      public override Lucene.Net.Index.Term Term { get { return default(Lucene.Net.Index.Term); } }
      protected override void Dispose(bool disposing) { }
      public override int DocFreq() { return default(int); }
      public override bool Next() { return default(bool); }
    }
    public partial class FilterTermPositions : Lucene.Net.Index.FilterIndexReader.FilterTermDocs, Lucene.Net.Index.TermDocs, Lucene.Net.Index.TermPositions, System.IDisposable {
      public FilterTermPositions(Lucene.Net.Index.TermPositions in_Renamed) : base (default(Lucene.Net.Index.TermDocs)) { }
      public virtual bool IsPayloadAvailable { get { return default(bool); } }
      public virtual int PayloadLength { get { return default(int); } }
      public virtual System.Byte[] GetPayload(System.Byte[] data, int offset) { return default(System.Byte[]); }
      public virtual int NextPosition() { return default(int); }
    }
  }
  public abstract partial class IndexCommit {
    protected IndexCommit() { }
    public abstract Lucene.Net.Store.Directory Directory { get; }
    public abstract System.Collections.Generic.ICollection<System.String> FileNames { get; }
    public abstract long Generation { get; }
    public abstract bool IsDeleted { get; }
    public abstract bool IsOptimized { get; }
    public abstract string SegmentsFileName { get; }
    public virtual long Timestamp { get { return default(long); } }
    public abstract System.Collections.Generic.IDictionary<System.String, System.String> UserData { get; }
    public abstract long Version { get; }
    public abstract void Delete();
    public override bool Equals(object other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }
  public partial interface IndexDeletionPolicy {
    void OnCommit<T>(System.Collections.Generic.IList<T> commits) where T : Lucene.Net.Index.IndexCommit;
    void OnInit<T>(System.Collections.Generic.IList<T> commits) where T : Lucene.Net.Index.IndexCommit;
  }
  public sealed partial class IndexFileDeleter : System.IDisposable {
    public static bool VERBOSE_REF_COUNTS;
    public IndexFileDeleter(Lucene.Net.Store.Directory directory, Lucene.Net.Index.IndexDeletionPolicy policy, Lucene.Net.Index.SegmentInfos segmentInfos, System.IO.StreamWriter infoStream, Lucene.Net.Index.DocumentsWriter docWriter, System.Collections.Generic.HashSet<System.String> synced) { }
    public Lucene.Net.Index.SegmentInfos LastSegmentInfos { get { return default(Lucene.Net.Index.SegmentInfos); } }
    public void Checkpoint(Lucene.Net.Index.SegmentInfos segmentInfos, bool isCommit) { }
    public void Dispose() { }
    public bool Exists(string fileName) { return default(bool); }
    public void Refresh() { }
    public void Refresh(string segmentName) { }
  }
  public partial class IndexFileNameFilter {
    internal IndexFileNameFilter() { }
    public static Lucene.Net.Index.IndexFileNameFilter Filter { get { return default(Lucene.Net.Index.IndexFileNameFilter); } }
    public virtual bool Accept(System.IO.FileInfo dir, string name) { return default(bool); }
    public virtual bool IsCFSFile(string name) { return default(bool); }
  }
  public sealed partial class IndexFileNames {
    public static readonly System.String[] COMPOUND_EXTENSIONS;
    public const string COMPOUND_FILE_EXTENSION = "cfs";
    public const string COMPOUND_FILE_STORE_EXTENSION = "cfx";
    public const string DELETABLE = "deletable";
    public const string FIELD_INFOS_EXTENSION = "fnm";
    public const string FIELDS_EXTENSION = "fdt";
    public const string FIELDS_INDEX_EXTENSION = "fdx";
    public const string FREQ_EXTENSION = "frq";
    public const string GEN_EXTENSION = "gen";
    public static readonly System.String[] INDEX_EXTENSIONS;
    public static readonly System.String[] INDEX_EXTENSIONS_IN_COMPOUND_FILE;
    public static readonly System.String[] NON_STORE_INDEX_EXTENSIONS;
    public const string NORMS_EXTENSION = "nrm";
    public const string PLAIN_NORMS_EXTENSION = "f";
    public const string PROX_EXTENSION = "prx";
    public const string SEGMENTS = "segments";
    public const string SEGMENTS_GEN = "segments.gen";
    public const string SEPARATE_NORMS_EXTENSION = "s";
    public static readonly System.String[] STORE_INDEX_EXTENSIONS;
    public const string TERMS_EXTENSION = "tis";
    public const string TERMS_INDEX_EXTENSION = "tii";
    public static readonly System.String[] VECTOR_EXTENSIONS;
    public const string VECTORS_DOCUMENTS_EXTENSION = "tvd";
    public const string VECTORS_FIELDS_EXTENSION = "tvf";
    public const string VECTORS_INDEX_EXTENSION = "tvx";
    public IndexFileNames() { }
    public static string FileNameFromGeneration(string base_Renamed, string extension, long gen) { return default(string); }
  }
  public abstract partial class IndexReader : System.ICloneable, System.IDisposable {
    protected internal static int DEFAULT_TERMS_INDEX_DIVISOR;
    protected internal bool hasChanges;
    protected internal IndexReader() { }
    public virtual System.Collections.Generic.IDictionary<System.String, System.String> CommitUserData { get { return default(System.Collections.Generic.IDictionary<System.String, System.String>); } }
    public virtual object DeletesCacheKey { get { return default(object); } }
    public virtual object FieldCacheKey { get { return default(object); } }
    public abstract bool HasDeletions { get; }
    public virtual Lucene.Net.Index.IndexCommit IndexCommit { get { return default(Lucene.Net.Index.IndexCommit); } }
    public Lucene.Net.Documents.Document this[int doc] { get { return default(Lucene.Net.Documents.Document); } }
    public abstract int MaxDoc { get; }
    public virtual int NumDeletedDocs { get { return default(int); } }
    public virtual int RefCount { get { return default(int); } }
    public virtual int TermInfosIndexDivisor { get { return default(int); } }
    public virtual long UniqueTermCount { get { return default(long); } }
    public virtual long Version { get { return default(long); } }
    protected internal virtual void AcquireWriteLock() { }
    public virtual object Clone() { return default(object); }
    public virtual Lucene.Net.Index.IndexReader Clone(bool openReadOnly) { return default(Lucene.Net.Index.IndexReader); }
    [System.ObsoleteAttribute("Use Dispose() instead")]
    public void Close() { }
    public void Commit() { }
    public void Commit(System.Collections.Generic.IDictionary<System.String, System.String> commitUserData) { }
    public virtual void DecRef() { }
    public virtual void DeleteDocument(int docNum) { }
    public virtual int DeleteDocuments(Lucene.Net.Index.Term term) { return default(int); }
    public virtual Lucene.Net.Store.Directory Directory() { return default(Lucene.Net.Store.Directory); }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public abstract int DocFreq(Lucene.Net.Index.Term t);
    protected internal abstract void DoClose();
    protected internal abstract void DoCommit(System.Collections.Generic.IDictionary<System.String, System.String> commitUserData);
    public virtual Lucene.Net.Documents.Document Document(int n) { return default(Lucene.Net.Documents.Document); }
    public abstract Lucene.Net.Documents.Document Document(int n, Lucene.Net.Documents.FieldSelector fieldSelector);
    protected internal abstract void DoDelete(int docNum);
    protected internal abstract void DoSetNorm(int doc, string field, byte value_Renamed);
    protected internal abstract void DoUndeleteAll();
    protected internal void EnsureOpen() { }
    public void Flush() { }
    public void Flush(System.Collections.Generic.IDictionary<System.String, System.String> commitUserData) { }
    public static System.Collections.Generic.IDictionary<System.String, System.String> GetCommitUserData(Lucene.Net.Store.Directory directory) { return default(System.Collections.Generic.IDictionary<System.String, System.String>); }
    public static long GetCurrentVersion(Lucene.Net.Store.Directory directory) { return default(long); }
    public abstract System.Collections.Generic.ICollection<System.String> GetFieldNames(Lucene.Net.Index.IndexReader.FieldOption fldOption);
    public virtual Lucene.Net.Index.IndexReader[] GetSequentialSubReaders() { return default(Lucene.Net.Index.IndexReader[]); }
    public abstract void GetTermFreqVector(int docNumber, Lucene.Net.Index.TermVectorMapper mapper);
    public abstract Lucene.Net.Index.ITermFreqVector GetTermFreqVector(int docNumber, string field);
    public abstract void GetTermFreqVector(int docNumber, string field, Lucene.Net.Index.TermVectorMapper mapper);
    public abstract Lucene.Net.Index.ITermFreqVector[] GetTermFreqVectors(int docNumber);
    public virtual bool HasNorms(string field) { return default(bool); }
    public virtual void IncRef() { }
    public static bool IndexExists(Lucene.Net.Store.Directory directory) { return default(bool); }
    public virtual bool IsCurrent() { return default(bool); }
    public abstract bool IsDeleted(int n);
    public virtual bool IsOptimized() { return default(bool); }
    public static long LastModified(Lucene.Net.Store.Directory directory2) { return default(long); }
    public static System.Collections.Generic.ICollection<Lucene.Net.Index.IndexCommit> ListCommits(Lucene.Net.Store.Directory dir) { return default(System.Collections.Generic.ICollection<Lucene.Net.Index.IndexCommit>); }
    [System.STAThreadAttribute]
    public static void Main(System.String[] args) { }
    public abstract System.Byte[] Norms(string field);
    public abstract void Norms(string field, System.Byte[] bytes, int offset);
    public abstract int NumDocs();
    public static Lucene.Net.Index.IndexReader Open(Lucene.Net.Index.IndexCommit commit, Lucene.Net.Index.IndexDeletionPolicy deletionPolicy, bool readOnly) { return default(Lucene.Net.Index.IndexReader); }
    public static Lucene.Net.Index.IndexReader Open(Lucene.Net.Index.IndexCommit commit, Lucene.Net.Index.IndexDeletionPolicy deletionPolicy, bool readOnly, int termInfosIndexDivisor) { return default(Lucene.Net.Index.IndexReader); }
    public static Lucene.Net.Index.IndexReader Open(Lucene.Net.Index.IndexCommit commit, bool readOnly) { return default(Lucene.Net.Index.IndexReader); }
    public static Lucene.Net.Index.IndexReader Open(Lucene.Net.Store.Directory directory, Lucene.Net.Index.IndexDeletionPolicy deletionPolicy, bool readOnly) { return default(Lucene.Net.Index.IndexReader); }
    public static Lucene.Net.Index.IndexReader Open(Lucene.Net.Store.Directory directory, Lucene.Net.Index.IndexDeletionPolicy deletionPolicy, bool readOnly, int termInfosIndexDivisor) { return default(Lucene.Net.Index.IndexReader); }
    public static Lucene.Net.Index.IndexReader Open(Lucene.Net.Store.Directory directory, bool readOnly) { return default(Lucene.Net.Index.IndexReader); }
    public virtual Lucene.Net.Index.IndexReader Reopen() { return default(Lucene.Net.Index.IndexReader); }
    public virtual Lucene.Net.Index.IndexReader Reopen(Lucene.Net.Index.IndexCommit commit) { return default(Lucene.Net.Index.IndexReader); }
    public virtual Lucene.Net.Index.IndexReader Reopen(bool openReadOnly) { return default(Lucene.Net.Index.IndexReader); }
    public virtual void SetNorm(int doc, string field, byte value) { }
    public virtual void SetNorm(int doc, string field, float value) { }
    public abstract Lucene.Net.Index.TermDocs TermDocs();
    public virtual Lucene.Net.Index.TermDocs TermDocs(Lucene.Net.Index.Term term) { return default(Lucene.Net.Index.TermDocs); }
    public abstract Lucene.Net.Index.TermPositions TermPositions();
    public virtual Lucene.Net.Index.TermPositions TermPositions(Lucene.Net.Index.Term term) { return default(Lucene.Net.Index.TermPositions); }
    public abstract Lucene.Net.Index.TermEnum Terms();
    public abstract Lucene.Net.Index.TermEnum Terms(Lucene.Net.Index.Term t);
    public virtual void UndeleteAll() { }
    public sealed partial class FieldOption {
      internal FieldOption() { }
      public static readonly Lucene.Net.Index.IndexReader.FieldOption ALL;
      public static readonly Lucene.Net.Index.IndexReader.FieldOption INDEXED;
      public static readonly Lucene.Net.Index.IndexReader.FieldOption INDEXED_NO_TERMVECTOR;
      public static readonly Lucene.Net.Index.IndexReader.FieldOption INDEXED_WITH_TERMVECTOR;
      public static readonly Lucene.Net.Index.IndexReader.FieldOption OMIT_TERM_FREQ_AND_POSITIONS;
      public static readonly Lucene.Net.Index.IndexReader.FieldOption STORES_PAYLOADS;
      public static readonly Lucene.Net.Index.IndexReader.FieldOption TERMVECTOR;
      public static readonly Lucene.Net.Index.IndexReader.FieldOption TERMVECTOR_WITH_OFFSET;
      public static readonly Lucene.Net.Index.IndexReader.FieldOption TERMVECTOR_WITH_POSITION;
      public static readonly Lucene.Net.Index.IndexReader.FieldOption TERMVECTOR_WITH_POSITION_OFFSET;
      public static readonly Lucene.Net.Index.IndexReader.FieldOption UNINDEXED;
      public override string ToString() { return default(string); }
    }
  }
  public partial class IndexWriter : System.IDisposable {
    public static readonly int DEFAULT_MAX_BUFFERED_DELETE_TERMS;
    public static readonly int DEFAULT_MAX_BUFFERED_DOCS;
    public const int DEFAULT_MAX_FIELD_LENGTH = 10000;
    public const double DEFAULT_RAM_BUFFER_SIZE_MB = 16;
    public const int DEFAULT_TERM_INDEX_INTERVAL = 128;
    public const int DISABLE_AUTO_FLUSH = -1;
    public static readonly int MAX_TERM_LENGTH;
    public const string WRITE_LOCK_NAME = "write.lock";
    public static long WRITE_LOCK_TIMEOUT;
    public IndexWriter(Lucene.Net.Store.Directory d, Lucene.Net.Analysis.Analyzer a, Lucene.Net.Index.IndexDeletionPolicy deletionPolicy, Lucene.Net.Index.IndexWriter.MaxFieldLength mfl) { }
    public IndexWriter(Lucene.Net.Store.Directory d, Lucene.Net.Analysis.Analyzer a, Lucene.Net.Index.IndexDeletionPolicy deletionPolicy, Lucene.Net.Index.IndexWriter.MaxFieldLength mfl, Lucene.Net.Index.IndexCommit commit) { }
    public IndexWriter(Lucene.Net.Store.Directory d, Lucene.Net.Analysis.Analyzer a, Lucene.Net.Index.IndexWriter.MaxFieldLength mfl) { }
    public IndexWriter(Lucene.Net.Store.Directory d, Lucene.Net.Analysis.Analyzer a, bool create, Lucene.Net.Index.IndexDeletionPolicy deletionPolicy, Lucene.Net.Index.IndexWriter.MaxFieldLength mfl) { }
    public IndexWriter(Lucene.Net.Store.Directory d, Lucene.Net.Analysis.Analyzer a, bool create, Lucene.Net.Index.IndexWriter.MaxFieldLength mfl) { }
    public virtual Lucene.Net.Analysis.Analyzer Analyzer { get { return default(Lucene.Net.Analysis.Analyzer); } }
    public static System.IO.StreamWriter DefaultInfoStream { get { return default(System.IO.StreamWriter); } set { } }
    public static long DefaultWriteLockTimeout { get { return default(long); } set { } }
    public virtual Lucene.Net.Store.Directory Directory { get { return default(Lucene.Net.Store.Directory); } }
    public virtual System.IO.StreamWriter InfoStream { get { return default(System.IO.StreamWriter); } }
    public virtual int MaxMergeDocs { get { return default(int); } set { } }
    public virtual Lucene.Net.Index.IndexWriter.IndexReaderWarmer MergedSegmentWarmer { get { return default(Lucene.Net.Index.IndexWriter.IndexReaderWarmer); } set { } }
    public virtual int MergeFactor { get { return default(int); } set { } }
    public virtual Lucene.Net.Index.MergePolicy MergePolicy { get { return default(Lucene.Net.Index.MergePolicy); } }
    public virtual Lucene.Net.Index.MergeScheduler MergeScheduler { get { return default(Lucene.Net.Index.MergeScheduler); } }
    public int ReaderTermsIndexDivisor { get { return default(int); } set { } }
    public virtual Lucene.Net.Search.Similarity Similarity { get { return default(Lucene.Net.Search.Similarity); } }
    public virtual int TermIndexInterval { get { return default(int); } set { } }
    public virtual bool UseCompoundFile { get { return default(bool); } set { } }
    public virtual bool Verbose { get { return default(bool); } }
    public virtual long WriteLockTimeout { get { return default(long); } set { } }
    public virtual void AddDocument(Lucene.Net.Documents.Document doc) { }
    public virtual void AddDocument(Lucene.Net.Documents.Document doc, Lucene.Net.Analysis.Analyzer analyzer) { }
    public virtual void AddIndexes(params Lucene.Net.Index.IndexReader[] readers) { }
    public virtual void AddIndexesNoOptimize(params Lucene.Net.Store.Directory[] dirs) { }
    [System.ObsoleteAttribute("Use Dispose() instead")]
    public void Close() { }
    [System.ObsoleteAttribute("Use Dispose(bool) instead")]
    public virtual void Close(bool waitForMerges) { }
    public void Commit() { }
    public void Commit(System.Collections.Generic.IDictionary<System.String, System.String> commitUserData) { }
    public virtual void DeleteAll() { }
    public virtual void DeleteDocuments(Lucene.Net.Index.Term term) { }
    public virtual void DeleteDocuments(params Lucene.Net.Index.Term[] terms) { }
    public virtual void DeleteDocuments(Lucene.Net.Search.Query query) { }
    public virtual void DeleteDocuments(params Lucene.Net.Search.Query[] queries) { }
    public virtual void Dispose() { }
    public virtual void Dispose(bool waitForMerges) { }
    protected virtual void Dispose(bool disposing, bool waitForMerges) { }
    protected virtual void DoAfterFlush() { }
    protected virtual void DoBeforeFlush() { }
    protected internal void EnsureOpen() { }
    protected internal void EnsureOpen(bool includePendingClose) { }
    public virtual void ExpungeDeletes() { }
    public virtual void ExpungeDeletes(bool doWait) { }
    public void Flush(bool triggerMerge, bool flushDocStores, bool flushDeletes) { }
    public int GetDocCount(int i) { return default(int); }
    public virtual int GetMaxBufferedDeleteTerms() { return default(int); }
    public virtual int GetMaxBufferedDocs() { return default(int); }
    public virtual int GetMaxFieldLength() { return default(int); }
    public virtual double GetRAMBufferSizeMB() { return default(double); }
    public virtual Lucene.Net.Index.IndexReader GetReader() { return default(Lucene.Net.Index.IndexReader); }
    public virtual Lucene.Net.Index.IndexReader GetReader(int termInfosIndexDivisor) { return default(Lucene.Net.Index.IndexReader); }
    public virtual bool HasDeletions() { return default(bool); }
    public static bool IsLocked(Lucene.Net.Store.Directory directory) { return default(bool); }
    public virtual int MaxDoc() { return default(int); }
    public void MaybeMerge() { }
    public void Merge_ForNUnit(Lucene.Net.Index.MergePolicy.OneMerge merge) { }
    public virtual void Message(string message) { }
    public virtual Lucene.Net.Index.SegmentInfo NewestSegment() { return default(Lucene.Net.Index.SegmentInfo); }
    public virtual int NumDeletedDocs(Lucene.Net.Index.SegmentInfo info) { return default(int); }
    public virtual int NumDocs() { return default(int); }
    public int NumRamDocs() { return default(int); }
    public virtual void Optimize() { }
    public virtual void Optimize(bool doWait) { }
    public virtual void Optimize(int maxNumSegments) { }
    public virtual void Optimize(int maxNumSegments, bool doWait) { }
    public void PrepareCommit() { }
    public long RamSizeInBytes() { return default(long); }
    public virtual void Rollback() { }
    public virtual string SegString() { return default(string); }
    public virtual void SetInfoStream(System.IO.StreamWriter infoStream) { }
    public virtual void SetMaxBufferedDeleteTerms(int maxBufferedDeleteTerms) { }
    public virtual void SetMaxBufferedDocs(int maxBufferedDocs) { }
    public virtual void SetMaxFieldLength(int maxFieldLength) { }
    public virtual void SetMergePolicy(Lucene.Net.Index.MergePolicy mp) { }
    public virtual void SetMergeScheduler(Lucene.Net.Index.MergeScheduler mergeScheduler) { }
    public virtual void SetRAMBufferSizeMB(double mb) { }
    public virtual void SetSimilarity(Lucene.Net.Search.Similarity similarity) { }
    public virtual bool TestPoint(string name) { return default(bool); }
    public static void Unlock(Lucene.Net.Store.Directory directory) { }
    public virtual void UpdateDocument(Lucene.Net.Index.Term term, Lucene.Net.Documents.Document doc) { }
    public virtual void UpdateDocument(Lucene.Net.Index.Term term, Lucene.Net.Documents.Document doc, Lucene.Net.Analysis.Analyzer analyzer) { }
    public virtual void WaitForMerges() { }
    public abstract partial class IndexReaderWarmer {
      protected IndexReaderWarmer() { }
      public abstract void Warm(Lucene.Net.Index.IndexReader reader);
    }
    public sealed partial class MaxFieldLength {
      public static readonly Lucene.Net.Index.IndexWriter.MaxFieldLength LIMITED;
      public static readonly Lucene.Net.Index.IndexWriter.MaxFieldLength UNLIMITED;
      public MaxFieldLength(int limit) { }
      public int Limit { get { return default(int); } }
      public override string ToString() { return default(string); }
    }
  }
  public partial interface ITermFreqVector {
    string Field { get; }
    int Size { get; }
    System.Int32[] GetTermFrequencies();
    System.String[] GetTerms();
    System.Int32[] IndexesOf(System.String[] terms, int start, int len);
    int IndexOf(string term);
  }
  public sealed partial class KeepOnlyLastCommitDeletionPolicy : Lucene.Net.Index.IndexDeletionPolicy {
    public KeepOnlyLastCommitDeletionPolicy() { }
    public void OnCommit<T>(System.Collections.Generic.IList<T> commits) where T : Lucene.Net.Index.IndexCommit { }
    public void OnInit<T>(System.Collections.Generic.IList<T> commits) where T : Lucene.Net.Index.IndexCommit { }
  }
  public partial class LogByteSizeMergePolicy : Lucene.Net.Index.LogMergePolicy {
    public static readonly long DEFAULT_MAX_MERGE_MB;
    public const double DEFAULT_MIN_MERGE_MB = 1.6;
    public LogByteSizeMergePolicy(Lucene.Net.Index.IndexWriter writer) : base (default(Lucene.Net.Index.IndexWriter)) { }
    public virtual double MaxMergeMB { get { return default(double); } set { } }
    public virtual double MinMergeMB { get { return default(double); } set { } }
    protected override void Dispose(bool disposing) { }
    protected internal override long Size(Lucene.Net.Index.SegmentInfo info) { return default(long); }
  }
  public partial class LogDocMergePolicy : Lucene.Net.Index.LogMergePolicy {
    public const int DEFAULT_MIN_MERGE_DOCS = 1000;
    public LogDocMergePolicy(Lucene.Net.Index.IndexWriter writer) : base (default(Lucene.Net.Index.IndexWriter)) { }
    public virtual int MinMergeDocs { get { return default(int); } set { } }
    protected override void Dispose(bool disposing) { }
    protected internal override long Size(Lucene.Net.Index.SegmentInfo info) { return default(long); }
  }
  public abstract partial class LogMergePolicy : Lucene.Net.Index.MergePolicy {
    public static readonly int DEFAULT_MAX_MERGE_DOCS;
    public const int DEFAULT_MERGE_FACTOR = 10;
    public static double DEFAULT_NO_CFS_RATIO;
    protected internal bool internalCalibrateSizeByDeletes;
    protected double internalNoCFSRatio;
    public const double LEVEL_LOG_SPAN = 0.75;
    protected LogMergePolicy(Lucene.Net.Index.IndexWriter writer) : base (default(Lucene.Net.Index.IndexWriter)) { }
    public virtual bool CalibrateSizeByDeletes { get { return default(bool); } set { } }
    public virtual int MaxMergeDocs { get { return default(int); } set { } }
    public virtual int MergeFactor { get { return default(int); } set { } }
    public double NoCFSRatio { get { return default(double); } set { } }
    public override Lucene.Net.Index.MergePolicy.MergeSpecification FindMerges(Lucene.Net.Index.SegmentInfos infos) { return default(Lucene.Net.Index.MergePolicy.MergeSpecification); }
    public override Lucene.Net.Index.MergePolicy.MergeSpecification FindMergesForOptimize(Lucene.Net.Index.SegmentInfos infos, int maxNumSegments, System.Collections.Generic.ISet<Lucene.Net.Index.SegmentInfo> segmentsToOptimize) { return default(Lucene.Net.Index.MergePolicy.MergeSpecification); }
    public override Lucene.Net.Index.MergePolicy.MergeSpecification FindMergesToExpungeDeletes(Lucene.Net.Index.SegmentInfos segmentInfos) { return default(Lucene.Net.Index.MergePolicy.MergeSpecification); }
    public virtual bool GetUseCompoundDocStore() { return default(bool); }
    public virtual bool GetUseCompoundFile() { return default(bool); }
    protected Lucene.Net.Index.MergePolicy.OneMerge MakeOneMerge(Lucene.Net.Index.SegmentInfos infos, Lucene.Net.Index.SegmentInfos infosToMerge) { return default(Lucene.Net.Index.MergePolicy.OneMerge); }
    public virtual void SetUseCompoundDocStore(bool useCompoundDocStore) { }
    public virtual void SetUseCompoundFile(bool useCompoundFile) { }
    protected internal abstract long Size(Lucene.Net.Index.SegmentInfo info);
    protected internal virtual long SizeBytes(Lucene.Net.Index.SegmentInfo info) { return default(long); }
    protected internal virtual long SizeDocs(Lucene.Net.Index.SegmentInfo info) { return default(long); }
    public override bool UseCompoundDocStore(Lucene.Net.Index.SegmentInfos infos) { return default(bool); }
    public override bool UseCompoundFile(Lucene.Net.Index.SegmentInfos infos, Lucene.Net.Index.SegmentInfo info) { return default(bool); }
    protected internal virtual bool Verbose() { return default(bool); }
  }
  public abstract partial class MergePolicy : System.IDisposable {
    protected internal Lucene.Net.Index.IndexWriter writer;
    protected MergePolicy(Lucene.Net.Index.IndexWriter writer) { }
    [System.ObsoleteAttribute("Use Dispose() instead")]
    public void Close() { }
    public void Dispose() { }
    protected abstract void Dispose(bool disposing);
    public abstract Lucene.Net.Index.MergePolicy.MergeSpecification FindMerges(Lucene.Net.Index.SegmentInfos segmentInfos);
    public abstract Lucene.Net.Index.MergePolicy.MergeSpecification FindMergesForOptimize(Lucene.Net.Index.SegmentInfos segmentInfos, int maxSegmentCount, System.Collections.Generic.ISet<Lucene.Net.Index.SegmentInfo> segmentsToOptimize);
    public abstract Lucene.Net.Index.MergePolicy.MergeSpecification FindMergesToExpungeDeletes(Lucene.Net.Index.SegmentInfos segmentInfos);
    public abstract bool UseCompoundDocStore(Lucene.Net.Index.SegmentInfos segments);
    public abstract bool UseCompoundFile(Lucene.Net.Index.SegmentInfos segments, Lucene.Net.Index.SegmentInfo newSegment);
    public partial class MergeAbortedException : System.IO.IOException {
      public MergeAbortedException() { }
      public MergeAbortedException(string message) { }
    }
    public partial class MergeException : System.SystemException {
      public MergeException(System.Exception exc, Lucene.Net.Store.Directory dir) { }
      public MergeException(string message, Lucene.Net.Store.Directory dir) { }
      public virtual Lucene.Net.Store.Directory Directory { get { return default(Lucene.Net.Store.Directory); } }
    }
    public partial class MergeSpecification {
      public System.Collections.Generic.IList<Lucene.Net.Index.MergePolicy.OneMerge> merges;
      public MergeSpecification() { }
      public virtual void Add(Lucene.Net.Index.MergePolicy.OneMerge merge) { }
      public virtual string SegString(Lucene.Net.Store.Directory dir) { return default(string); }
    }
    public partial class OneMerge {
      public OneMerge(Lucene.Net.Index.SegmentInfos segments, bool useCompoundFile) { }
      public Lucene.Net.Index.SegmentInfos segments_ForNUnit { get { return default(Lucene.Net.Index.SegmentInfos); } }
    }
  }
  public abstract partial class MergeScheduler : System.IDisposable {
    protected MergeScheduler() { }
    [System.ObsoleteAttribute("Use Dispose() instead")]
    public void Close() { }
    public void Dispose() { }
    protected abstract void Dispose(bool disposing);
    public abstract void Merge(Lucene.Net.Index.IndexWriter writer);
  }
  public partial class MultipleTermPositions : Lucene.Net.Index.TermDocs, Lucene.Net.Index.TermPositions, System.IDisposable {
    public MultipleTermPositions(Lucene.Net.Index.IndexReader indexReader, Lucene.Net.Index.Term[] terms) { }
    public int Doc { get { return default(int); } }
    public int Freq { get { return default(int); } }
    public virtual bool IsPayloadAvailable { get { return default(bool); } }
    public virtual int PayloadLength { get { return default(int); } }
    [System.ObsoleteAttribute("Use Dispose() instead")]
    public void Close() { }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public virtual System.Byte[] GetPayload(System.Byte[] data, int offset) { return default(System.Byte[]); }
    public bool Next() { return default(bool); }
    public int NextPosition() { return default(int); }
    public virtual int Read(System.Int32[] arg0, System.Int32[] arg1) { return default(int); }
    public virtual void Seek(Lucene.Net.Index.Term arg0) { }
    public virtual void Seek(Lucene.Net.Index.TermEnum termEnum) { }
    public bool SkipTo(int target) { return default(bool); }
  }
  public partial class MultiReader : Lucene.Net.Index.IndexReader, System.ICloneable {
    protected internal Lucene.Net.Index.IndexReader[] subReaders;
    public MultiReader(params Lucene.Net.Index.IndexReader[] subReaders) { }
    public MultiReader(Lucene.Net.Index.IndexReader[] subReaders, bool closeSubReaders) { }
    public override bool HasDeletions { get { return default(bool); } }
    public override int MaxDoc { get { return default(int); } }
    public override long Version { get { return default(long); } }
    public override object Clone() { return default(object); }
    public override int DocFreq(Lucene.Net.Index.Term t) { return default(int); }
    protected internal override void DoClose() { }
    protected internal override void DoCommit(System.Collections.Generic.IDictionary<System.String, System.String> commitUserData) { }
    public override Lucene.Net.Documents.Document Document(int n, Lucene.Net.Documents.FieldSelector fieldSelector) { return default(Lucene.Net.Documents.Document); }
    protected internal override void DoDelete(int n) { }
    protected internal virtual Lucene.Net.Index.IndexReader DoReopen(bool doClone) { return default(Lucene.Net.Index.IndexReader); }
    protected internal override void DoSetNorm(int n, string field, byte value_Renamed) { }
    protected internal override void DoUndeleteAll() { }
    public override System.Collections.Generic.ICollection<System.String> GetFieldNames(Lucene.Net.Index.IndexReader.FieldOption fieldNames) { return default(System.Collections.Generic.ICollection<System.String>); }
    public override Lucene.Net.Index.IndexReader[] GetSequentialSubReaders() { return default(Lucene.Net.Index.IndexReader[]); }
    public override void GetTermFreqVector(int docNumber, Lucene.Net.Index.TermVectorMapper mapper) { }
    public override Lucene.Net.Index.ITermFreqVector GetTermFreqVector(int n, string field) { return default(Lucene.Net.Index.ITermFreqVector); }
    public override void GetTermFreqVector(int docNumber, string field, Lucene.Net.Index.TermVectorMapper mapper) { }
    public override Lucene.Net.Index.ITermFreqVector[] GetTermFreqVectors(int n) { return default(Lucene.Net.Index.ITermFreqVector[]); }
    public override bool HasNorms(string field) { return default(bool); }
    public override bool IsCurrent() { return default(bool); }
    public override bool IsDeleted(int n) { return default(bool); }
    public override bool IsOptimized() { return default(bool); }
    public override System.Byte[] Norms(string field) { return default(System.Byte[]); }
    public override void Norms(string field, System.Byte[] result, int offset) { }
    public override int NumDocs() { return default(int); }
    public override Lucene.Net.Index.IndexReader Reopen() { return default(Lucene.Net.Index.IndexReader); }
    public override Lucene.Net.Index.TermDocs TermDocs() { return default(Lucene.Net.Index.TermDocs); }
    public override Lucene.Net.Index.TermPositions TermPositions() { return default(Lucene.Net.Index.TermPositions); }
    public override Lucene.Net.Index.TermEnum Terms() { return default(Lucene.Net.Index.TermEnum); }
    public override Lucene.Net.Index.TermEnum Terms(Lucene.Net.Index.Term term) { return default(Lucene.Net.Index.TermEnum); }
  }
  public partial class ParallelReader : Lucene.Net.Index.IndexReader, System.ICloneable {
    public ParallelReader() { }
    public ParallelReader(bool closeSubReaders) { }
    public override bool HasDeletions { get { return default(bool); } }
    public override int MaxDoc { get { return default(int); } }
    public override long Version { get { return default(long); } }
    public virtual void Add(Lucene.Net.Index.IndexReader reader) { }
    public virtual void Add(Lucene.Net.Index.IndexReader reader, bool ignoreStoredFields) { }
    public override object Clone() { return default(object); }
    public override int DocFreq(Lucene.Net.Index.Term term) { return default(int); }
    protected internal override void DoClose() { }
    protected internal override void DoCommit(System.Collections.Generic.IDictionary<System.String, System.String> commitUserData) { }
    public override Lucene.Net.Documents.Document Document(int n, Lucene.Net.Documents.FieldSelector fieldSelector) { return default(Lucene.Net.Documents.Document); }
    protected internal override void DoDelete(int n) { }
    protected internal virtual Lucene.Net.Index.IndexReader DoReopen(bool doClone) { return default(Lucene.Net.Index.IndexReader); }
    protected internal override void DoSetNorm(int n, string field, byte value_Renamed) { }
    protected internal override void DoUndeleteAll() { }
    public override System.Collections.Generic.ICollection<System.String> GetFieldNames(Lucene.Net.Index.IndexReader.FieldOption fieldNames) { return default(System.Collections.Generic.ICollection<System.String>); }
    public virtual Lucene.Net.Index.IndexReader[] GetSubReaders() { return default(Lucene.Net.Index.IndexReader[]); }
    public override void GetTermFreqVector(int docNumber, Lucene.Net.Index.TermVectorMapper mapper) { }
    public override Lucene.Net.Index.ITermFreqVector GetTermFreqVector(int n, string field) { return default(Lucene.Net.Index.ITermFreqVector); }
    public override void GetTermFreqVector(int docNumber, string field, Lucene.Net.Index.TermVectorMapper mapper) { }
    public override Lucene.Net.Index.ITermFreqVector[] GetTermFreqVectors(int n) { return default(Lucene.Net.Index.ITermFreqVector[]); }
    public override bool HasNorms(string field) { return default(bool); }
    public override bool IsCurrent() { return default(bool); }
    public override bool IsDeleted(int n) { return default(bool); }
    public override bool IsOptimized() { return default(bool); }
    public override System.Byte[] Norms(string field) { return default(System.Byte[]); }
    public override void Norms(string field, System.Byte[] result, int offset) { }
    public override int NumDocs() { return default(int); }
    public override Lucene.Net.Index.IndexReader Reopen() { return default(Lucene.Net.Index.IndexReader); }
    public override Lucene.Net.Index.TermDocs TermDocs() { return default(Lucene.Net.Index.TermDocs); }
    public override Lucene.Net.Index.TermDocs TermDocs(Lucene.Net.Index.Term term) { return default(Lucene.Net.Index.TermDocs); }
    public override Lucene.Net.Index.TermPositions TermPositions() { return default(Lucene.Net.Index.TermPositions); }
    public override Lucene.Net.Index.TermPositions TermPositions(Lucene.Net.Index.Term term) { return default(Lucene.Net.Index.TermPositions); }
    public override Lucene.Net.Index.TermEnum Terms() { return default(Lucene.Net.Index.TermEnum); }
    public override Lucene.Net.Index.TermEnum Terms(Lucene.Net.Index.Term term) { return default(Lucene.Net.Index.TermEnum); }
  }
  public partial class Payload : System.ICloneable {
    protected internal System.Byte[] data;
    protected internal int internalLength;
    protected internal int internalOffset;
    public Payload() { }
    public Payload(System.Byte[] data) { }
    public Payload(System.Byte[] data, int offset, int length) { }
    public virtual int Length { get { return default(int); } }
    public virtual int Offset { get { return default(int); } }
    public virtual byte ByteAt(int index) { return default(byte); }
    public virtual object Clone() { return default(object); }
    public virtual void CopyTo(System.Byte[] target, int targetOffset) { }
    public override bool Equals(object obj) { return default(bool); }
    public virtual System.Byte[] GetData() { return default(System.Byte[]); }
    public override int GetHashCode() { return default(int); }
    public virtual void SetData(System.Byte[] value) { }
    public virtual void SetData(System.Byte[] value, int offset, int length) { }
    public virtual System.Byte[] ToByteArray() { return default(System.Byte[]); }
  }
  public partial class PositionBasedTermVectorMapper : Lucene.Net.Index.TermVectorMapper {
    public PositionBasedTermVectorMapper() { }
    public PositionBasedTermVectorMapper(bool ignoringOffsets) { }
    public virtual System.Collections.Generic.IDictionary<System.String, System.Collections.Generic.IDictionary<System.Int32, Lucene.Net.Index.PositionBasedTermVectorMapper.TVPositionInfo>> FieldToTerms { get { return default(System.Collections.Generic.IDictionary<System.String, System.Collections.Generic.IDictionary<System.Int32, Lucene.Net.Index.PositionBasedTermVectorMapper.TVPositionInfo>>); } }
    public override bool IsIgnoringPositions { get { return default(bool); } }
    public override void Map(string term, int frequency, Lucene.Net.Index.TermVectorOffsetInfo[] offsets, System.Int32[] positions) { }
    public override void SetExpectations(string field, int numTerms, bool storeOffsets, bool storePositions) { }
    public partial class TVPositionInfo {
      public TVPositionInfo(int position, bool storeOffsets) { }
      public virtual System.Collections.Generic.IList<Lucene.Net.Index.TermVectorOffsetInfo> Offsets { get { return default(System.Collections.Generic.IList<Lucene.Net.Index.TermVectorOffsetInfo>); } }
      public virtual int Position { get { return default(int); } }
      public virtual System.Collections.Generic.IList<System.String> Terms { get { return default(System.Collections.Generic.IList<System.String>); } }
    }
  }
  public partial class ReadOnlyDirectoryReader : Lucene.Net.Index.DirectoryReader {
    internal ReadOnlyDirectoryReader() { }
    protected internal override void AcquireWriteLock() { }
  }
  public partial class ReadOnlySegmentReader : Lucene.Net.Index.SegmentReader {
    public ReadOnlySegmentReader() { }
    protected internal override void AcquireWriteLock() { }
    public override bool IsDeleted(int n) { return default(bool); }
  }
  public sealed partial class SegmentInfo : System.ICloneable {
    public Lucene.Net.Store.Directory dir;
    public int docCount;
    public string name;
    public SegmentInfo(string name, int docCount, Lucene.Net.Store.Directory dir) { }
    public SegmentInfo(string name, int docCount, Lucene.Net.Store.Directory dir, bool isCompoundFile, bool hasSingleNormFile) { }
    public SegmentInfo(string name, int docCount, Lucene.Net.Store.Directory dir, bool isCompoundFile, bool hasSingleNormFile, int docStoreOffset, string docStoreSegment, bool docStoreIsCompoundFile, bool hasProx) { }
    public System.Collections.Generic.IDictionary<System.String, System.String> Diagnostics { get { return default(System.Collections.Generic.IDictionary<System.String, System.String>); } }
    public bool DocStoreIsCompoundFile { get { return default(bool); } }
    public int DocStoreOffset { get { return default(int); } }
    public string DocStoreSegment { get { return default(string); } }
    public bool HasProx { get { return default(bool); } }
    public object Clone() { return default(object); }
    public override bool Equals(object obj) { return default(bool); }
    public System.Collections.Generic.IList<System.String> Files() { return default(System.Collections.Generic.IList<System.String>); }
    public int GetDelCount() { return default(int); }
    public string GetDelFileName() { return default(string); }
    public override int GetHashCode() { return default(int); }
    public string GetNormFileName(int number) { return default(string); }
    public bool GetUseCompoundFile() { return default(bool); }
    public bool HasDeletions() { return default(bool); }
    public bool HasSeparateNorms() { return default(bool); }
    public bool HasSeparateNorms(int fieldNumber) { return default(bool); }
    public string SegString(Lucene.Net.Store.Directory dir) { return default(string); }
    public long SizeInBytes() { return default(long); }
    public override string ToString() { return default(string); }
  }
  public sealed partial class SegmentInfos : System.Collections.Generic.List<Lucene.Net.Index.SegmentInfo>, System.ICloneable {
    public int counter;
    public const int FORMAT = -1;
    public const int FORMAT_CHECKSUM = -5;
    public const int FORMAT_DEL_COUNT = -6;
    public const int FORMAT_DIAGNOSTICS = -9;
    public const int FORMAT_HAS_PROX = -7;
    public const int FORMAT_LOCKLESS = -2;
    public const int FORMAT_SHARED_DOC_STORE = -4;
    public const int FORMAT_SINGLE_NORM_FILE = -3;
    public const int FORMAT_USER_DATA = -8;
    public SegmentInfos() { }
    public static int DefaultGenFileRetryCount { get { return default(int); } set { } }
    public static int DefaultGenFileRetryPauseMsec { get { return default(int); } set { } }
    public static int DefaultGenLookaheadCount { get { return default(int); } set { } }
    public long Generation { get { return default(long); } }
    public static System.IO.StreamWriter InfoStream { get { return default(System.IO.StreamWriter); } }
    public long LastGeneration { get { return default(long); } }
    public System.Collections.Generic.IDictionary<System.String, System.String> UserData { get { return default(System.Collections.Generic.IDictionary<System.String, System.String>); } }
    public long Version { get { return default(long); } }
    public object Clone() { return default(object); }
    public void Commit(Lucene.Net.Store.Directory dir) { }
    public override bool Equals(object obj) { return default(bool); }
    public System.Collections.Generic.ICollection<System.String> Files(Lucene.Net.Store.Directory dir, bool includeSegmentsFile) { return default(System.Collections.Generic.ICollection<System.String>); }
    public static long GenerationFromSegmentsFileName(string fileName) { return default(long); }
    public string GetCurrentSegmentFileName() { return default(string); }
    public static string GetCurrentSegmentFileName(Lucene.Net.Store.Directory directory) { return default(string); }
    public static string GetCurrentSegmentFileName(System.String[] files) { return default(string); }
    public static long GetCurrentSegmentGeneration(Lucene.Net.Store.Directory directory) { return default(long); }
    public static long GetCurrentSegmentGeneration(System.String[] files) { return default(long); }
    public override int GetHashCode() { return default(int); }
    public string GetNextSegmentFileName() { return default(string); }
    public bool HasExternalSegments(Lucene.Net.Store.Directory dir) { return default(bool); }
    public Lucene.Net.Index.SegmentInfo Info(int i) { return default(Lucene.Net.Index.SegmentInfo); }
    public Lucene.Net.Index.SegmentInfos Range(int first, int last) { return default(Lucene.Net.Index.SegmentInfos); }
    public void Read(Lucene.Net.Store.Directory directory) { }
    public void Read(Lucene.Net.Store.Directory directory, string segmentFileName) { }
    public static System.Collections.Generic.IDictionary<System.String, System.String> ReadCurrentUserData(Lucene.Net.Store.Directory directory) { return default(System.Collections.Generic.IDictionary<System.String, System.String>); }
    public static long ReadCurrentVersion(Lucene.Net.Store.Directory directory) { return default(long); }
    public string SegString(Lucene.Net.Store.Directory directory) { return default(string); }
    public static void SetInfoStream(System.IO.StreamWriter infoStream) { }
    public abstract partial class FindSegmentsFile {
      protected FindSegmentsFile(Lucene.Net.Store.Directory directory) { }
      public abstract object DoBody(string segmentFileName);
      public object Run() { return default(object); }
      public object Run(Lucene.Net.Index.IndexCommit commit) { return default(object); }
    }
  }
  public sealed partial class SegmentMerger {
    public SegmentMerger(Lucene.Net.Store.Directory dir, string name) { }
    public void Add(Lucene.Net.Index.IndexReader reader) { }
    public System.Collections.Generic.ICollection<System.String> CreateCompoundFile(string fileName) { return default(System.Collections.Generic.ICollection<System.String>); }
    public int Merge() { return default(int); }
  }
  public partial class SegmentReader : Lucene.Net.Index.IndexReader {
    protected internal bool readOnly;
    public SegmentReader() { }
    public Lucene.Net.Index.SegmentReader.CoreReaders core_ForNUnit { get { return default(Lucene.Net.Index.SegmentReader.CoreReaders); } }
    public Lucene.Net.Util.BitVector deletedDocs_ForNUnit { get { return default(Lucene.Net.Util.BitVector); } }
    public Lucene.Net.Index.SegmentReader.Ref deletedDocsRef_ForNUnit { get { return default(Lucene.Net.Index.SegmentReader.Ref); } }
    public override object DeletesCacheKey { get { return default(object); } }
    public override object FieldCacheKey { get { return default(object); } }
    public override bool HasDeletions { get { return default(bool); } }
    public override int MaxDoc { get { return default(int); } }
    public System.Collections.Generic.IDictionary<System.String, Lucene.Net.Index.SegmentReader.Norm> norms_ForNUnit { get { return default(System.Collections.Generic.IDictionary<System.String, Lucene.Net.Index.SegmentReader.Norm>); } }
    public virtual string SegmentName { get { return default(string); } }
    public override int TermInfosIndexDivisor { get { return default(int); } }
    public override long UniqueTermCount { get { return default(long); } }
    public override object Clone() { return default(object); }
    public override Lucene.Net.Index.IndexReader Clone(bool openReadOnly) { return default(Lucene.Net.Index.IndexReader); }
    protected internal virtual Lucene.Net.Util.BitVector CloneDeletedDocs(Lucene.Net.Util.BitVector bv) { return default(Lucene.Net.Util.BitVector); }
    protected internal virtual System.Byte[] CloneNormBytes(System.Byte[] bytes) { return default(System.Byte[]); }
    public override Lucene.Net.Store.Directory Directory() { return default(Lucene.Net.Store.Directory); }
    public override int DocFreq(Lucene.Net.Index.Term t) { return default(int); }
    protected internal override void DoClose() { }
    protected internal override void DoCommit(System.Collections.Generic.IDictionary<System.String, System.String> commitUserData) { }
    public override Lucene.Net.Documents.Document Document(int n, Lucene.Net.Documents.FieldSelector fieldSelector) { return default(Lucene.Net.Documents.Document); }
    protected internal override void DoDelete(int docNum) { }
    protected internal override void DoSetNorm(int doc, string field, byte value_Renamed) { }
    protected internal override void DoUndeleteAll() { }
    public virtual Lucene.Net.Index.FieldInfos FieldInfos() { return default(Lucene.Net.Index.FieldInfos); }
    public static Lucene.Net.Index.SegmentReader Get(bool readOnly, Lucene.Net.Index.SegmentInfo si, int termInfosIndexDivisor) { return default(Lucene.Net.Index.SegmentReader); }
    public static Lucene.Net.Index.SegmentReader Get(bool readOnly, Lucene.Net.Store.Directory dir, Lucene.Net.Index.SegmentInfo si, int readBufferSize, bool doOpenStores, int termInfosIndexDivisor) { return default(Lucene.Net.Index.SegmentReader); }
    public override System.Collections.Generic.ICollection<System.String> GetFieldNames(Lucene.Net.Index.IndexReader.FieldOption fieldOption) { return default(System.Collections.Generic.ICollection<System.String>); }
    protected internal virtual System.Byte[] GetNorms(string field) { return default(System.Byte[]); }
    public static Lucene.Net.Index.SegmentReader GetOnlySegmentReader(Lucene.Net.Index.IndexReader reader) { return default(Lucene.Net.Index.SegmentReader); }
    [System.ObsoleteAttribute("Remove this when tests are fixed!")]
    public static Lucene.Net.Index.SegmentReader GetOnlySegmentReader(Lucene.Net.Store.Directory dir) { return default(Lucene.Net.Index.SegmentReader); }
    public override void GetTermFreqVector(int docNumber, Lucene.Net.Index.TermVectorMapper mapper) { }
    public override Lucene.Net.Index.ITermFreqVector GetTermFreqVector(int docNumber, string field) { return default(Lucene.Net.Index.ITermFreqVector); }
    public override void GetTermFreqVector(int docNumber, string field, Lucene.Net.Index.TermVectorMapper mapper) { }
    public override Lucene.Net.Index.ITermFreqVector[] GetTermFreqVectors(int docNumber) { return default(Lucene.Net.Index.ITermFreqVector[]); }
    public override bool HasNorms(string field) { return default(bool); }
    public override bool IsDeleted(int n) { return default(bool); }
    public override System.Byte[] Norms(string field) { return default(System.Byte[]); }
    public override void Norms(string field, System.Byte[] bytes, int offset) { }
    public virtual bool NormsClosed() { return default(bool); }
    public virtual bool NormsClosed(string field) { return default(bool); }
    public override int NumDocs() { return default(int); }
    public override Lucene.Net.Index.TermDocs TermDocs() { return default(Lucene.Net.Index.TermDocs); }
    public override Lucene.Net.Index.TermDocs TermDocs(Lucene.Net.Index.Term term) { return default(Lucene.Net.Index.TermDocs); }
    public override Lucene.Net.Index.TermPositions TermPositions() { return default(Lucene.Net.Index.TermPositions); }
    public override Lucene.Net.Index.TermEnum Terms() { return default(Lucene.Net.Index.TermEnum); }
    public override Lucene.Net.Index.TermEnum Terms(Lucene.Net.Index.Term t) { return default(Lucene.Net.Index.TermEnum); }
    public virtual bool TermsIndexLoaded() { return default(bool); }
    public sealed partial class CoreReaders {
      internal CoreReaders() { }
      public Lucene.Net.Index.FieldInfos fieldInfos_ForNUnit { get { return default(Lucene.Net.Index.FieldInfos); } }
    }
    public sealed partial class Norm : System.ICloneable {
      public Norm(Lucene.Net.Index.SegmentReader enclosingInstance, Lucene.Net.Store.IndexInput in_Renamed, int number, long normSeek) { }
      public Lucene.Net.Index.SegmentReader Enclosing_Instance { get { return default(Lucene.Net.Index.SegmentReader); } }
      public System.Byte[] Bytes() { return default(System.Byte[]); }
      public void Bytes(System.Byte[] bytesOut, int offset, int len) { }
      public Lucene.Net.Index.SegmentReader.Ref BytesRef() { return default(Lucene.Net.Index.SegmentReader.Ref); }
      public object Clone() { return default(object); }
      public System.Byte[] CopyOnWrite() { return default(System.Byte[]); }
      public void DecRef() { }
      public void IncRef() { }
      public void ReWrite(Lucene.Net.Index.SegmentInfo si) { }
    }
    public partial class Ref {
      public Ref() { }
      public virtual int DecRef() { return default(int); }
      public virtual int IncRef() { return default(int); }
      public virtual int RefCount() { return default(int); }
      public override string ToString() { return default(string); }
    }
  }
  public partial class SerialMergeScheduler : Lucene.Net.Index.MergeScheduler {
    public SerialMergeScheduler() { }
    protected override void Dispose(bool disposing) { }
    public override void Merge(Lucene.Net.Index.IndexWriter writer) { }
  }
  public partial class SnapshotDeletionPolicy : Lucene.Net.Index.IndexDeletionPolicy {
    public SnapshotDeletionPolicy(Lucene.Net.Index.IndexDeletionPolicy primary) { }
    public virtual void OnCommit<T>(System.Collections.Generic.IList<T> commits) where T : Lucene.Net.Index.IndexCommit { }
    public virtual void OnInit<T>(System.Collections.Generic.IList<T> commits) where T : Lucene.Net.Index.IndexCommit { }
    public virtual void Release() { }
    public virtual Lucene.Net.Index.IndexCommit Snapshot() { return default(Lucene.Net.Index.IndexCommit); }
  }
  public partial class SortedTermVectorMapper : Lucene.Net.Index.TermVectorMapper {
    public const string ALL = "_ALL_";
    public SortedTermVectorMapper(bool ignoringPositions, bool ignoringOffsets, System.Collections.Generic.IComparer<Lucene.Net.Index.TermVectorEntry> comparator) { }
    public SortedTermVectorMapper(System.Collections.Generic.IComparer<Lucene.Net.Index.TermVectorEntry> comparator) { }
    public virtual System.Collections.Generic.SortedSet<Lucene.Net.Index.TermVectorEntry> TermVectorEntrySet { get { return default(System.Collections.Generic.SortedSet<Lucene.Net.Index.TermVectorEntry>); } }
    public override void Map(string term, int frequency, Lucene.Net.Index.TermVectorOffsetInfo[] offsets, System.Int32[] positions) { }
    public override void SetExpectations(string field, int numTerms, bool storeOffsets, bool storePositions) { }
  }
  public partial class StaleReaderException : System.IO.IOException {
    public StaleReaderException(string message) { }
  }
  public sealed partial class Term : System.IComparable<Lucene.Net.Index.Term> {
    public Term(string fld) { }
    public Term(string fld, string txt) { }
    public string Field { get { return default(string); } }
    public string Text { get { return default(string); } }
    public int CompareTo(Lucene.Net.Index.Term other) { return default(int); }
    public Lucene.Net.Index.Term CreateTerm(string text) { return default(Lucene.Net.Index.Term); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
  }
  public partial interface TermDocs : System.IDisposable {
    int Doc { get; }
    int Freq { get; }
    [System.ObsoleteAttribute("Use Dispose() instead")]
    void Close();
    bool Next();
    int Read(System.Int32[] docs, System.Int32[] freqs);
    void Seek(Lucene.Net.Index.Term term);
    void Seek(Lucene.Net.Index.TermEnum termEnum);
    bool SkipTo(int target);
  }
  public abstract partial class TermEnum : System.IDisposable {
    protected TermEnum() { }
    public abstract Lucene.Net.Index.Term Term { get; }
    [System.ObsoleteAttribute("Use Dispose() instead")]
    public void Close() { }
    public void Dispose() { }
    protected abstract void Dispose(bool disposing);
    public abstract int DocFreq();
    public abstract bool Next();
  }
  public partial interface TermPositions : Lucene.Net.Index.TermDocs, System.IDisposable {
    bool IsPayloadAvailable { get; }
    int PayloadLength { get; }
    System.Byte[] GetPayload(System.Byte[] data, int offset);
    int NextPosition();
  }
  public partial interface TermPositionVector : Lucene.Net.Index.ITermFreqVector {
    Lucene.Net.Index.TermVectorOffsetInfo[] GetOffsets(int index);
    System.Int32[] GetTermPositions(int index);
  }
  public partial class TermVectorEntry {
    public TermVectorEntry() { }
    public TermVectorEntry(string field, string term, int frequency, Lucene.Net.Index.TermVectorOffsetInfo[] offsets, System.Int32[] positions) { }
    public virtual string Field { get { return default(string); } }
    public virtual int Frequency { get { return default(int); } }
    public virtual string Term { get { return default(string); } }
    public override bool Equals(object o) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public virtual Lucene.Net.Index.TermVectorOffsetInfo[] GetOffsets() { return default(Lucene.Net.Index.TermVectorOffsetInfo[]); }
    public virtual System.Int32[] GetPositions() { return default(System.Int32[]); }
    public override string ToString() { return default(string); }
  }
  public partial class TermVectorEntryFreqSortedComparator : System.Collections.Generic.IComparer<Lucene.Net.Index.TermVectorEntry> {
    public TermVectorEntryFreqSortedComparator() { }
    public virtual int Compare(Lucene.Net.Index.TermVectorEntry entry, Lucene.Net.Index.TermVectorEntry entry1) { return default(int); }
  }
  public abstract partial class TermVectorMapper {
    protected internal TermVectorMapper() { }
    protected internal TermVectorMapper(bool ignoringPositions, bool ignoringOffsets) { }
    public virtual bool IsIgnoringOffsets { get { return default(bool); } }
    public virtual bool IsIgnoringPositions { get { return default(bool); } }
    public abstract void Map(string term, int frequency, Lucene.Net.Index.TermVectorOffsetInfo[] offsets, System.Int32[] positions);
    public virtual void SetDocumentNumber(int documentNumber) { }
    public abstract void SetExpectations(string field, int numTerms, bool storeOffsets, bool storePositions);
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct TermVectorOffsetInfo : System.IEquatable<Lucene.Net.Index.TermVectorOffsetInfo> {
    public static readonly Lucene.Net.Index.TermVectorOffsetInfo[] EMPTY_OFFSET_INFO;
    public static readonly Lucene.Net.Index.TermVectorOffsetInfo Null;
    public TermVectorOffsetInfo(int startOffset, int endOffset) { throw new System.NotImplementedException(); }
    public int EndOffset { get { return default(int); } set { } }
    public int StartOffset { get { return default(int); } set { } }
    public bool Equals(Lucene.Net.Index.TermVectorOffsetInfo other) { return default(bool); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(Lucene.Net.Index.TermVectorOffsetInfo left, object right) { return default(bool); }
    public static bool operator !=(Lucene.Net.Index.TermVectorOffsetInfo left, object right) { return default(bool); }
  }
}
namespace Lucene.Net.Messages {
  public partial interface INLSException {
    Lucene.Net.Messages.Message MessageObject { get; }
  }
  public partial interface Message {
    string Key { get; }
    System.Object[] GetArguments();
    string GetLocalizedMessage();
    string GetLocalizedMessage(System.Globalization.CultureInfo locale);
  }
  public partial class MessageImpl : Lucene.Net.Messages.Message {
    public MessageImpl(string key) { }
    public MessageImpl(string key, params System.Object[] args) { }
    public virtual string Key { get { return default(string); } }
    public virtual System.Object[] GetArguments() { return default(System.Object[]); }
    public virtual string GetLocalizedMessage() { return default(string); }
    public virtual string GetLocalizedMessage(System.Globalization.CultureInfo locale) { return default(string); }
    public override string ToString() { return default(string); }
  }
  public partial class NLS {
    protected internal NLS() { }
    public static string GetLocalizedMessage(string key) { return default(string); }
    public static string GetLocalizedMessage(string key, System.Globalization.CultureInfo locale) { return default(string); }
    public static string GetLocalizedMessage(string key, System.Globalization.CultureInfo locale, params System.Object[] args) { return default(string); }
    public static string GetLocalizedMessage(string key, params System.Object[] args) { return default(string); }
    protected internal static void InitializeMessages<T>(string bundleName) { }
    public partial interface IPriviligedAction {
      object Run();
    }
  }
}
namespace Lucene.Net.QueryParsers {
  public sealed partial class FastCharStream : Lucene.Net.QueryParsers.ICharStream {
    public FastCharStream(System.IO.TextReader r) { }
    public int BeginColumn { get { return default(int); } }
    public int BeginLine { get { return default(int); } }
    public int Column { get { return default(int); } }
    public int EndColumn { get { return default(int); } }
    public int EndLine { get { return default(int); } }
    public string Image { get { return default(string); } }
    public int Line { get { return default(int); } }
    public void Backup(int amount) { }
    public char BeginToken() { return default(char); }
    public void Done() { }
    public System.Char[] GetSuffix(int len) { return default(System.Char[]); }
    public char ReadChar() { return default(char); }
  }
  public partial interface ICharStream {
    int BeginColumn { get; }
    int BeginLine { get; }
    [System.ObsoleteAttribute]
    int Column { get; }
    int EndColumn { get; }
    int EndLine { get; }
    string Image { get; }
    [System.ObsoleteAttribute]
    int Line { get; }
    void Backup(int amount);
    char BeginToken();
    void Done();
    System.Char[] GetSuffix(int len);
    char ReadChar();
  }
  public partial class MultiFieldQueryParser : Lucene.Net.QueryParsers.QueryParser {
    protected internal System.Collections.Generic.IDictionary<System.String, System.Single> boosts;
    protected internal System.String[] fields;
    public MultiFieldQueryParser(Lucene.Net.Util.Version matchVersion, System.String[] fields, Lucene.Net.Analysis.Analyzer analyzer) : base (default(Lucene.Net.Util.Version), default(string), default(Lucene.Net.Analysis.Analyzer)) { }
    public MultiFieldQueryParser(Lucene.Net.Util.Version matchVersion, System.String[] fields, Lucene.Net.Analysis.Analyzer analyzer, System.Collections.Generic.IDictionary<System.String, System.Single> boosts) : base (default(Lucene.Net.Util.Version), default(string), default(Lucene.Net.Analysis.Analyzer)) { }
    protected internal override Lucene.Net.Search.Query GetFieldQuery(string field, string queryText) { return default(Lucene.Net.Search.Query); }
    protected internal override Lucene.Net.Search.Query GetFieldQuery(string field, string queryText, int slop) { return default(Lucene.Net.Search.Query); }
    protected internal override Lucene.Net.Search.Query GetFuzzyQuery(string field, string termStr, float minSimilarity) { return default(Lucene.Net.Search.Query); }
    protected internal override Lucene.Net.Search.Query GetPrefixQuery(string field, string termStr) { return default(Lucene.Net.Search.Query); }
    protected internal override Lucene.Net.Search.Query GetRangeQuery(string field, string part1, string part2, bool inclusive) { return default(Lucene.Net.Search.Query); }
    protected internal override Lucene.Net.Search.Query GetWildcardQuery(string field, string termStr) { return default(Lucene.Net.Search.Query); }
    public static Lucene.Net.Search.Query Parse(Lucene.Net.Util.Version matchVersion, string query, System.String[] fields, Lucene.Net.Search.Occur[] flags, Lucene.Net.Analysis.Analyzer analyzer) { return default(Lucene.Net.Search.Query); }
    public static Lucene.Net.Search.Query Parse(Lucene.Net.Util.Version matchVersion, System.String[] queries, System.String[] fields, Lucene.Net.Analysis.Analyzer analyzer) { return default(Lucene.Net.Search.Query); }
    public static Lucene.Net.Search.Query Parse(Lucene.Net.Util.Version matchVersion, System.String[] queries, System.String[] fields, Lucene.Net.Search.Occur[] flags, Lucene.Net.Analysis.Analyzer analyzer) { return default(Lucene.Net.Search.Query); }
  }
  public partial class ParseException : System.Exception {
    public Lucene.Net.QueryParsers.Token currentToken;
    protected internal string eol;
    public System.Int32[][] expectedTokenSequences;
    protected internal bool specialConstructor;
    public System.String[] tokenImage;
    public ParseException() { }
    public ParseException(Lucene.Net.QueryParsers.Token currentTokenVal, System.Int32[][] expectedTokenSequencesVal, System.String[] tokenImageVal) { }
    public ParseException(string message) { }
    public ParseException(string message, System.Exception ex) { }
    public override string Message { get { return default(string); } }
    protected internal virtual string Add_escapes(string str) { return default(string); }
  }
  public partial class QueryParser : Lucene.Net.QueryParsers.QueryParserConstants {
    public static Lucene.Net.QueryParsers.QueryParser.Operator AND_OPERATOR;
    public Lucene.Net.QueryParsers.Token jj_nt;
    public static Lucene.Net.QueryParsers.QueryParser.Operator OR_OPERATOR;
    public Lucene.Net.QueryParsers.Token token;
    public Lucene.Net.QueryParsers.QueryParserTokenManager token_source;
    protected internal QueryParser(Lucene.Net.QueryParsers.ICharStream stream) { }
    protected QueryParser(Lucene.Net.QueryParsers.QueryParserTokenManager tm) { }
    public QueryParser(Lucene.Net.Util.Version matchVersion, string f, Lucene.Net.Analysis.Analyzer a) { }
    public virtual bool AllowLeadingWildcard { get { return default(bool); } set { } }
    public virtual Lucene.Net.Analysis.Analyzer Analyzer { get { return default(Lucene.Net.Analysis.Analyzer); } }
    public virtual Lucene.Net.QueryParsers.QueryParser.Operator DefaultOperator { get { return default(Lucene.Net.QueryParsers.QueryParser.Operator); } set { } }
    public virtual bool EnablePositionIncrements { get { return default(bool); } set { } }
    public virtual string Field { get { return default(string); } }
    public virtual float FuzzyMinSim { get { return default(float); } set { } }
    public virtual int FuzzyPrefixLength { get { return default(int); } set { } }
    public virtual System.Globalization.CultureInfo Locale { get { return default(System.Globalization.CultureInfo); } set { } }
    public virtual bool LowercaseExpandedTerms { get { return default(bool); } set { } }
    public virtual Lucene.Net.Search.RewriteMethod MultiTermRewriteMethod { get { return default(Lucene.Net.Search.RewriteMethod); } set { } }
    public virtual int PhraseSlop { get { return default(int); } set { } }
    public virtual System.Globalization.CompareInfo RangeCollator { get { return default(System.Globalization.CompareInfo); } set { } }
    protected internal virtual void AddClause(System.Collections.Generic.List<Lucene.Net.Search.BooleanClause> clauses, int conj, int mods, Lucene.Net.Search.Query q) { }
    public Lucene.Net.Search.Query Clause(string field) { return default(Lucene.Net.Search.Query); }
    public int Conjunction() { return default(int); }
    public void Disable_tracing() { }
    public void Enable_tracing() { }
    public static string Escape(string s) { return default(string); }
    public virtual Lucene.Net.QueryParsers.ParseException GenerateParseException() { return default(Lucene.Net.QueryParsers.ParseException); }
    protected internal virtual Lucene.Net.Search.Query GetBooleanQuery(System.Collections.Generic.IList<Lucene.Net.Search.BooleanClause> clauses) { return default(Lucene.Net.Search.Query); }
    protected internal virtual Lucene.Net.Search.Query GetBooleanQuery(System.Collections.Generic.IList<Lucene.Net.Search.BooleanClause> clauses, bool disableCoord) { return default(Lucene.Net.Search.Query); }
    public virtual Lucene.Net.Documents.DateTools.Resolution getDateResolution(string fieldName) { return default(Lucene.Net.Documents.DateTools.Resolution); }
    protected internal virtual Lucene.Net.Search.Query GetFieldQuery(string field, string queryText) { return default(Lucene.Net.Search.Query); }
    protected internal virtual Lucene.Net.Search.Query GetFieldQuery(string field, string queryText, int slop) { return default(Lucene.Net.Search.Query); }
    protected internal virtual Lucene.Net.Search.Query GetFuzzyQuery(string field, string termStr, float minSimilarity) { return default(Lucene.Net.Search.Query); }
    public Lucene.Net.QueryParsers.Token GetNextToken() { return default(Lucene.Net.QueryParsers.Token); }
    protected internal virtual Lucene.Net.Search.Query GetPrefixQuery(string field, string termStr) { return default(Lucene.Net.Search.Query); }
    protected internal virtual Lucene.Net.Search.Query GetRangeQuery(string field, string part1, string part2, bool inclusive) { return default(Lucene.Net.Search.Query); }
    public Lucene.Net.QueryParsers.Token getToken(int index) { return default(Lucene.Net.QueryParsers.Token); }
    protected internal virtual Lucene.Net.Search.Query GetWildcardQuery(string field, string termStr) { return default(Lucene.Net.Search.Query); }
    [System.STAThreadAttribute]
    public static void Main(System.String[] args) { }
    public int Modifiers() { return default(int); }
    protected internal virtual Lucene.Net.Search.BooleanClause NewBooleanClause(Lucene.Net.Search.Query q, Lucene.Net.Search.Occur occur) { return default(Lucene.Net.Search.BooleanClause); }
    protected internal virtual Lucene.Net.Search.BooleanQuery NewBooleanQuery(bool disableCoord) { return default(Lucene.Net.Search.BooleanQuery); }
    protected internal virtual Lucene.Net.Search.Query NewFuzzyQuery(Lucene.Net.Index.Term term, float minimumSimilarity, int prefixLength) { return default(Lucene.Net.Search.Query); }
    protected internal virtual Lucene.Net.Search.Query NewMatchAllDocsQuery() { return default(Lucene.Net.Search.Query); }
    protected internal virtual Lucene.Net.Search.MultiPhraseQuery NewMultiPhraseQuery() { return default(Lucene.Net.Search.MultiPhraseQuery); }
    protected internal virtual Lucene.Net.Search.PhraseQuery NewPhraseQuery() { return default(Lucene.Net.Search.PhraseQuery); }
    protected internal virtual Lucene.Net.Search.Query NewPrefixQuery(Lucene.Net.Index.Term prefix) { return default(Lucene.Net.Search.Query); }
    protected internal virtual Lucene.Net.Search.Query NewRangeQuery(string field, string part1, string part2, bool inclusive) { return default(Lucene.Net.Search.Query); }
    protected internal virtual Lucene.Net.Search.Query NewTermQuery(Lucene.Net.Index.Term term) { return default(Lucene.Net.Search.Query); }
    protected internal virtual Lucene.Net.Search.Query NewWildcardQuery(Lucene.Net.Index.Term t) { return default(Lucene.Net.Search.Query); }
    public virtual Lucene.Net.Search.Query Parse(string query) { return default(Lucene.Net.Search.Query); }
    public Lucene.Net.Search.Query Query(string field) { return default(Lucene.Net.Search.Query); }
    public void ReInit(Lucene.Net.QueryParsers.ICharStream stream) { }
    public void ReInit(Lucene.Net.QueryParsers.QueryParserTokenManager tm) { }
    public virtual void SetDateResolution(Lucene.Net.Documents.DateTools.Resolution dateResolution) { }
    public virtual void SetDateResolution(string fieldName, Lucene.Net.Documents.DateTools.Resolution dateResolution) { }
    public Lucene.Net.Search.Query Term(string field) { return default(Lucene.Net.Search.Query); }
    public Lucene.Net.Search.Query TopLevelQuery(string field) { return default(Lucene.Net.Search.Query); }
    public enum Operator {
      AND = 1,
      OR = 0,
    }
  }
  public partial class QueryParserConstants {
    protected internal const int AndToken = 8;
    protected internal const int BoostToken = 0;
    protected internal const int CaratToken = 17;
    protected internal const int ColonToken = 15;
    protected internal const int DefaultToken = 3;
    protected internal const int EndOfFileToken = 0;
    protected internal const int EscapedCharToken = 2;
    protected internal const int FuzzySlopToken = 20;
    protected internal const int LParanToken = 13;
    protected internal const int MinusToken = 12;
    protected internal const int NotToken = 10;
    protected internal const int NumberToken = 25;
    protected internal const int NumCharToken = 1;
    protected internal const int OrToken = 9;
    protected internal const int PlusToken = 11;
    protected internal const int PrefixTermToken = 21;
    protected internal const int QuotedCharToken = 6;
    protected internal const int QuotedToken = 18;
    protected internal const int RangeExEndToken = 31;
    protected internal const int RangeExGoopToken = 33;
    protected internal const int RangeExQuotedToken = 32;
    protected internal const int RangeExStartToken = 24;
    protected const int RangeExToken = 1;
    protected internal const int RangeExToToken = 30;
    protected internal const int RangeInEndToken = 27;
    protected internal const int RangeInGoopToken = 29;
    protected internal const int RangeInQuotedToken = 28;
    protected internal const int RangeInStartToken = 23;
    protected internal const int RangeInToken = 2;
    protected internal const int RangeInToToken = 26;
    protected internal const int RParenToken = 14;
    protected internal const int StarToken = 16;
    protected internal const int TermCharToken = 4;
    protected internal const int TermStartCharToken = 3;
    protected internal const int TermToken = 19;
    protected internal static System.String[] tokenImage;
    protected internal const int WhitespaceToken = 5;
    protected internal const int WildTermToken = 22;
    public QueryParserConstants() { }
  }
  public partial class QueryParserTokenManager : Lucene.Net.QueryParsers.QueryParserConstants {
    protected internal char curChar;
    public System.IO.StreamWriter debugStream;
    protected internal Lucene.Net.QueryParsers.ICharStream input_stream;
    public static readonly System.Int32[] jjnewLexState;
    public static readonly System.String[] jjstrLiteralImages;
    public static readonly System.String[] lexStateNames;
    public QueryParserTokenManager(Lucene.Net.QueryParsers.ICharStream stream) { }
    public QueryParserTokenManager(Lucene.Net.QueryParsers.ICharStream stream, int lexState) { }
    public virtual Lucene.Net.QueryParsers.Token GetNextToken() { return default(Lucene.Net.QueryParsers.Token); }
    protected internal virtual Lucene.Net.QueryParsers.Token JjFillToken() { return default(Lucene.Net.QueryParsers.Token); }
    public virtual void ReInit(Lucene.Net.QueryParsers.ICharStream stream) { }
    public virtual void ReInit(Lucene.Net.QueryParsers.ICharStream stream, int lexState) { }
    public virtual void SetDebugStream(System.IO.StreamWriter ds) { }
    public virtual void SwitchTo(int lexState) { }
  }
  public partial class Token {
    public int beginColumn;
    public int beginLine;
    public int endColumn;
    public int endLine;
    public string image;
    public int kind;
    public Lucene.Net.QueryParsers.Token next;
    public Lucene.Net.QueryParsers.Token specialToken;
    public Token() { }
    public Token(int kind) { }
    public Token(int kind, string image) { }
    public virtual object Value { get { return default(object); } }
    public static Lucene.Net.QueryParsers.Token NewToken(int ofKind) { return default(Lucene.Net.QueryParsers.Token); }
    public static Lucene.Net.QueryParsers.Token NewToken(int ofKind, string image) { return default(Lucene.Net.QueryParsers.Token); }
    public override string ToString() { return default(string); }
  }
  public partial class TokenMgrError : System.ApplicationException {
    public TokenMgrError() { }
    public TokenMgrError(bool EOFSeen, int lexState, int errorLine, int errorColumn, string errorAfter, char curChar, int reason) { }
    public TokenMgrError(string message, int reason) { }
    public override string Message { get { return default(string); } }
    protected internal static string addEscapes(string str) { return default(string); }
    protected internal static string LexicalError(bool EOFSeen, int lexState, int errorLine, int errorColumn, string errorAfter, char curChar) { return default(string); }
  }
}
namespace Lucene.Net.Search {
  public partial class BooleanClause {
    public BooleanClause(Lucene.Net.Search.Query query, Lucene.Net.Search.Occur occur) { }
    public virtual bool IsProhibited { get { return default(bool); } }
    public virtual bool IsRequired { get { return default(bool); } }
    public virtual Lucene.Net.Search.Occur Occur { get { return default(Lucene.Net.Search.Occur); } set { } }
    public virtual Lucene.Net.Search.Query Query { get { return default(Lucene.Net.Search.Query); } set { } }
    public override bool Equals(object o) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
  }
  public partial class BooleanQuery : Lucene.Net.Search.Query, System.Collections.Generic.IEnumerable<Lucene.Net.Search.BooleanClause>, System.Collections.IEnumerable, System.ICloneable {
    protected internal int minNrShouldMatch;
    public BooleanQuery() { }
    public BooleanQuery(bool disableCoord) { }
    public virtual System.Collections.Generic.List<Lucene.Net.Search.BooleanClause> Clauses { get { return default(System.Collections.Generic.List<Lucene.Net.Search.BooleanClause>); } }
    public static int MaxClauseCount { get { return default(int); } set { } }
    public virtual int MinimumNumberShouldMatch { get { return default(int); } set { } }
    public virtual void Add(Lucene.Net.Search.BooleanClause clause) { }
    public virtual void Add(Lucene.Net.Search.Query query, Lucene.Net.Search.Occur occur) { }
    public override object Clone() { return default(object); }
    public override Lucene.Net.Search.Weight CreateWeight(Lucene.Net.Search.Searcher searcher) { return default(Lucene.Net.Search.Weight); }
    public override bool Equals(object o) { return default(bool); }
    public override void ExtractTerms(System.Collections.Generic.ISet<Lucene.Net.Index.Term> terms) { }
    public virtual Lucene.Net.Search.BooleanClause[] GetClauses() { return default(Lucene.Net.Search.BooleanClause[]); }
    public System.Collections.Generic.IEnumerator<Lucene.Net.Search.BooleanClause> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<Lucene.Net.Search.BooleanClause>); }
    public override int GetHashCode() { return default(int); }
    public override Lucene.Net.Search.Similarity GetSimilarity(Lucene.Net.Search.Searcher searcher) { return default(Lucene.Net.Search.Similarity); }
    public virtual bool IsCoordDisabled() { return default(bool); }
    public override Lucene.Net.Search.Query Rewrite(Lucene.Net.Index.IndexReader reader) { return default(Lucene.Net.Search.Query); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    public override string ToString(string field) { return default(string); }
    protected internal partial class BooleanWeight : Lucene.Net.Search.Weight {
      protected internal Lucene.Net.Search.Similarity similarity;
      protected internal System.Collections.Generic.List<Lucene.Net.Search.Weight> weights;
      public BooleanWeight(Lucene.Net.Search.BooleanQuery enclosingInstance, Lucene.Net.Search.Searcher searcher) { }
      public Lucene.Net.Search.BooleanQuery Enclosing_Instance { get { return default(Lucene.Net.Search.BooleanQuery); } }
      public override Lucene.Net.Search.Query Query { get { return default(Lucene.Net.Search.Query); } }
      public override float Value { get { return default(float); } }
      public override Lucene.Net.Search.Explanation Explain(Lucene.Net.Index.IndexReader reader, int doc) { return default(Lucene.Net.Search.Explanation); }
      public override bool GetScoresDocsOutOfOrder() { return default(bool); }
      public override float GetSumOfSquaredWeights() { return default(float); }
      public override void Normalize(float norm) { }
      public override Lucene.Net.Search.Scorer Scorer(Lucene.Net.Index.IndexReader reader, bool scoreDocsInOrder, bool topScorer) { return default(Lucene.Net.Search.Scorer); }
    }
    public partial class TooManyClauses : System.SystemException {
      public TooManyClauses() { }
      public override string Message { get { return default(string); } }
    }
  }
  public sealed partial class BooleanScorer : Lucene.Net.Search.Scorer {
    public BooleanScorer(Lucene.Net.Search.Similarity similarity, int minNrShouldMatch, System.Collections.Generic.List<Lucene.Net.Search.Scorer> optionalScorers, System.Collections.Generic.List<Lucene.Net.Search.Scorer> prohibitedScorers) : base (default(Lucene.Net.Search.Similarity)) { }
    public override int Advance(int target) { return default(int); }
    public override int DocID() { return default(int); }
    public override int NextDoc() { return default(int); }
    public override float Score() { return default(float); }
    public override void Score(Lucene.Net.Search.Collector collector) { }
    public override bool Score(Lucene.Net.Search.Collector collector, int max, int firstDocID) { return default(bool); }
    public override string ToString() { return default(string); }
  }
  public partial interface ByteParser : Lucene.Net.Search.Parser {
    sbyte ParseByte(string string_Renamed);
  }
  public abstract partial class CacheEntry {
    protected CacheEntry() { }
    public abstract System.Type CacheType { get; }
    public abstract object Custom { get; }
    public string EstimatedSize { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected internal set { } }
    public abstract string FieldName { get; }
    public abstract object ReaderKey { get; }
    public abstract object Value { get; }
    public virtual void EstimateSize() { }
    public virtual void EstimateSize(Lucene.Net.Util.RamUsageEstimator ramCalc) { }
    public override string ToString() { return default(string); }
  }
  public partial class CachingSpanFilter : Lucene.Net.Search.SpanFilter {
    public int hitCount;
    public int missCount;
    public CachingSpanFilter(Lucene.Net.Search.SpanFilter filter) { }
    public CachingSpanFilter(Lucene.Net.Search.SpanFilter filter, Lucene.Net.Search.CachingWrapperFilter.DeletesMode deletesMode) { }
    public override Lucene.Net.Search.SpanFilterResult BitSpans(Lucene.Net.Index.IndexReader reader) { return default(Lucene.Net.Search.SpanFilterResult); }
    public override bool Equals(object o) { return default(bool); }
    public override Lucene.Net.Search.DocIdSet GetDocIdSet(Lucene.Net.Index.IndexReader reader) { return default(Lucene.Net.Search.DocIdSet); }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
  }
  public partial class CachingWrapperFilter : Lucene.Net.Search.Filter {
    protected internal Lucene.Net.Search.Filter filter;
    public int hitCount;
    public int missCount;
    public CachingWrapperFilter(Lucene.Net.Search.Filter filter) { }
    public CachingWrapperFilter(Lucene.Net.Search.Filter filter, Lucene.Net.Search.CachingWrapperFilter.DeletesMode deletesMode) { }
    protected internal virtual Lucene.Net.Search.DocIdSet DocIdSetToCache(Lucene.Net.Search.DocIdSet docIdSet, Lucene.Net.Index.IndexReader reader) { return default(Lucene.Net.Search.DocIdSet); }
    public override bool Equals(object o) { return default(bool); }
    public override Lucene.Net.Search.DocIdSet GetDocIdSet(Lucene.Net.Index.IndexReader reader) { return default(Lucene.Net.Search.DocIdSet); }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
    public enum DeletesMode {
      DYNAMIC = 2,
      IGNORE = 0,
      RECACHE = 1,
    }
  }
  public abstract partial class Collector {
    protected Collector() { }
    public abstract bool AcceptsDocsOutOfOrder { get; }
    public abstract void Collect(int doc);
    public abstract void SetNextReader(Lucene.Net.Index.IndexReader reader, int docBase);
    public abstract void SetScorer(Lucene.Net.Search.Scorer scorer);
  }
  public partial class ComplexExplanation : Lucene.Net.Search.Explanation {
    public ComplexExplanation() { }
    public ComplexExplanation(bool match, float value_Renamed, string description) { }
    public override bool IsMatch { get { return default(bool); } }
    public virtual System.Nullable<System.Boolean> Match { get { return default(System.Nullable<System.Boolean>); } set { } }
    protected internal override string Summary { get { return default(string); } }
  }
  public partial class ConstantScoreQuery : Lucene.Net.Search.Query {
    protected internal Lucene.Net.Search.Filter internalFilter;
    public ConstantScoreQuery(Lucene.Net.Search.Filter filter) { }
    public virtual Lucene.Net.Search.Filter Filter { get { return default(Lucene.Net.Search.Filter); } }
    public override object Clone() { return default(object); }
    public override Lucene.Net.Search.Weight CreateWeight(Lucene.Net.Search.Searcher searcher) { return default(Lucene.Net.Search.Weight); }
    public override bool Equals(object o) { return default(bool); }
    public override void ExtractTerms(System.Collections.Generic.ISet<Lucene.Net.Index.Term> terms) { }
    public override int GetHashCode() { return default(int); }
    public override Lucene.Net.Search.Query Rewrite(Lucene.Net.Index.IndexReader reader) { return default(Lucene.Net.Search.Query); }
    public override string ToString(string field) { return default(string); }
    protected internal partial class ConstantScorer : Lucene.Net.Search.Scorer {
      public ConstantScorer(Lucene.Net.Search.ConstantScoreQuery enclosingInstance, Lucene.Net.Search.Similarity similarity, Lucene.Net.Index.IndexReader reader, Lucene.Net.Search.Weight w) : base (default(Lucene.Net.Search.Similarity)) { }
      public Lucene.Net.Search.ConstantScoreQuery Enclosing_Instance { get { return default(Lucene.Net.Search.ConstantScoreQuery); } }
      public override int Advance(int target) { return default(int); }
      public override int DocID() { return default(int); }
      public override int NextDoc() { return default(int); }
      public override float Score() { return default(float); }
    }
    protected internal partial class ConstantWeight : Lucene.Net.Search.Weight {
      public ConstantWeight(Lucene.Net.Search.ConstantScoreQuery enclosingInstance, Lucene.Net.Search.Searcher searcher) { }
      public Lucene.Net.Search.ConstantScoreQuery Enclosing_Instance { get { return default(Lucene.Net.Search.ConstantScoreQuery); } }
      public override Lucene.Net.Search.Query Query { get { return default(Lucene.Net.Search.Query); } }
      public override float Value { get { return default(float); } }
      public override Lucene.Net.Search.Explanation Explain(Lucene.Net.Index.IndexReader reader, int doc) { return default(Lucene.Net.Search.Explanation); }
      public override float GetSumOfSquaredWeights() { return default(float); }
      public override void Normalize(float norm) { }
      public override Lucene.Net.Search.Scorer Scorer(Lucene.Net.Index.IndexReader reader, bool scoreDocsInOrder, bool topScorer) { return default(Lucene.Net.Search.Scorer); }
    }
  }
  public sealed partial class CreationPlaceholder {
    public CreationPlaceholder() { }
  }
  public partial class DefaultSimilarity : Lucene.Net.Search.Similarity {
    protected internal bool internalDiscountOverlaps;
    public DefaultSimilarity() { }
    public virtual bool DiscountOverlaps { get { return default(bool); } set { } }
    public override float ComputeNorm(string field, Lucene.Net.Index.FieldInvertState state) { return default(float); }
    public override float Coord(int overlap, int maxOverlap) { return default(float); }
    public override float Idf(int docFreq, int numDocs) { return default(float); }
    public override float LengthNorm(string fieldName, int numTerms) { return default(float); }
    public override float QueryNorm(float sumOfSquaredWeights) { return default(float); }
    public override float SloppyFreq(int distance) { return default(float); }
    public override float Tf(float freq) { return default(float); }
  }
  public partial class DisjunctionMaxQuery : Lucene.Net.Search.Query, System.Collections.Generic.IEnumerable<Lucene.Net.Search.Query>, System.Collections.IEnumerable, System.ICloneable {
    public DisjunctionMaxQuery(System.Collections.Generic.ICollection<Lucene.Net.Search.Query> disjuncts, float tieBreakerMultiplier) { }
    public DisjunctionMaxQuery(float tieBreakerMultiplier) { }
    public virtual void Add(Lucene.Net.Search.Query query) { }
    public virtual void Add(System.Collections.Generic.ICollection<Lucene.Net.Search.Query> disjuncts) { }
    public override object Clone() { return default(object); }
    public override Lucene.Net.Search.Weight CreateWeight(Lucene.Net.Search.Searcher searcher) { return default(Lucene.Net.Search.Weight); }
    public override bool Equals(object o) { return default(bool); }
    public override void ExtractTerms(System.Collections.Generic.ISet<Lucene.Net.Index.Term> terms) { }
    public virtual System.Collections.Generic.IEnumerator<Lucene.Net.Search.Query> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<Lucene.Net.Search.Query>); }
    public override int GetHashCode() { return default(int); }
    public override Lucene.Net.Search.Query Rewrite(Lucene.Net.Index.IndexReader reader) { return default(Lucene.Net.Search.Query); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    public override string ToString(string field) { return default(string); }
    protected internal partial class DisjunctionMaxWeight : Lucene.Net.Search.Weight {
      protected internal Lucene.Net.Search.Similarity similarity;
      protected internal System.Collections.Generic.List<Lucene.Net.Search.Weight> weights;
      public DisjunctionMaxWeight(Lucene.Net.Search.DisjunctionMaxQuery enclosingInstance, Lucene.Net.Search.Searcher searcher) { }
      public Lucene.Net.Search.DisjunctionMaxQuery Enclosing_Instance { get { return default(Lucene.Net.Search.DisjunctionMaxQuery); } }
      public override Lucene.Net.Search.Query Query { get { return default(Lucene.Net.Search.Query); } }
      public override float Value { get { return default(float); } }
      public override Lucene.Net.Search.Explanation Explain(Lucene.Net.Index.IndexReader reader, int doc) { return default(Lucene.Net.Search.Explanation); }
      public override float GetSumOfSquaredWeights() { return default(float); }
      public override void Normalize(float norm) { }
      public override Lucene.Net.Search.Scorer Scorer(Lucene.Net.Index.IndexReader reader, bool scoreDocsInOrder, bool topScorer) { return default(Lucene.Net.Search.Scorer); }
    }
  }
  public abstract partial class DocIdSet {
    public static readonly Lucene.Net.Search.DocIdSet EMPTY_DOCIDSET;
    protected DocIdSet() { }
    public virtual bool IsCacheable { get { return default(bool); } }
    public abstract Lucene.Net.Search.DocIdSetIterator Iterator();
    public partial class AnonymousClassDocIdSet : Lucene.Net.Search.DocIdSet {
      public AnonymousClassDocIdSet() { }
      public override bool IsCacheable { get { return default(bool); } }
      public override Lucene.Net.Search.DocIdSetIterator Iterator() { return default(Lucene.Net.Search.DocIdSetIterator); }
      public partial class AnonymousClassDocIdSetIterator : Lucene.Net.Search.DocIdSetIterator {
        public AnonymousClassDocIdSetIterator(Lucene.Net.Search.DocIdSet.AnonymousClassDocIdSet enclosingInstance) { }
        public Lucene.Net.Search.DocIdSet.AnonymousClassDocIdSet Enclosing_Instance { get { return default(Lucene.Net.Search.DocIdSet.AnonymousClassDocIdSet); } }
        public override int Advance(int target) { return default(int); }
        public override int DocID() { return default(int); }
        public override int NextDoc() { return default(int); }
      }
    }
  }
  public abstract partial class DocIdSetIterator {
    public static readonly int NO_MORE_DOCS;
    protected DocIdSetIterator() { }
    public abstract int Advance(int target);
    public abstract int DocID();
    public abstract int NextDoc();
  }
  public partial interface DoubleParser : Lucene.Net.Search.Parser {
    double ParseDouble(string string_Renamed);
  }
  public partial class Explanation {
    public Explanation() { }
    public Explanation(float value, string description) { }
    public virtual string Description { get { return default(string); } set { } }
    public virtual bool IsMatch { get { return default(bool); } }
    protected internal virtual string Summary { get { return default(string); } }
    public virtual float Value { get { return default(float); } set { } }
    public virtual void AddDetail(Lucene.Net.Search.Explanation detail) { }
    public virtual Lucene.Net.Search.Explanation[] GetDetails() { return default(Lucene.Net.Search.Explanation[]); }
    public virtual string ToHtml() { return default(string); }
    public override string ToString() { return default(string); }
    protected internal virtual string ToString(int depth) { return default(string); }
    public abstract partial class IDFExplanation {
      protected IDFExplanation() { }
      public abstract float Idf { get; }
      public abstract string Explain();
    }
  }
  public partial interface FieldCache {
    System.IO.StreamWriter InfoStream { get; set; }
    System.SByte[] GetBytes(Lucene.Net.Index.IndexReader reader, string field);
    System.SByte[] GetBytes(Lucene.Net.Index.IndexReader reader, string field, Lucene.Net.Search.ByteParser parser);
    Lucene.Net.Search.CacheEntry[] GetCacheEntries();
    System.Double[] GetDoubles(Lucene.Net.Index.IndexReader reader, string field);
    System.Double[] GetDoubles(Lucene.Net.Index.IndexReader reader, string field, Lucene.Net.Search.DoubleParser parser);
    System.Single[] GetFloats(Lucene.Net.Index.IndexReader reader, string field);
    System.Single[] GetFloats(Lucene.Net.Index.IndexReader reader, string field, Lucene.Net.Search.FloatParser parser);
    System.Int32[] GetInts(Lucene.Net.Index.IndexReader reader, string field);
    System.Int32[] GetInts(Lucene.Net.Index.IndexReader reader, string field, Lucene.Net.Search.IntParser parser);
    System.Int64[] GetLongs(Lucene.Net.Index.IndexReader reader, string field);
    System.Int64[] GetLongs(Lucene.Net.Index.IndexReader reader, string field, Lucene.Net.Search.LongParser parser);
    System.Int16[] GetShorts(Lucene.Net.Index.IndexReader reader, string field);
    System.Int16[] GetShorts(Lucene.Net.Index.IndexReader reader, string field, Lucene.Net.Search.ShortParser parser);
    Lucene.Net.Search.StringIndex GetStringIndex(Lucene.Net.Index.IndexReader reader, string field);
    System.String[] GetStrings(Lucene.Net.Index.IndexReader reader, string field);
    void Purge(Lucene.Net.Index.IndexReader r);
    void PurgeAllCaches();
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Size=1)]
  public partial struct FieldCache_Fields {
    public static readonly Lucene.Net.Search.FieldCache DEFAULT;
    public static readonly Lucene.Net.Search.ByteParser DEFAULT_BYTE_PARSER;
    public static readonly Lucene.Net.Search.DoubleParser DEFAULT_DOUBLE_PARSER;
    public static readonly Lucene.Net.Search.FloatParser DEFAULT_FLOAT_PARSER;
    public static readonly Lucene.Net.Search.IntParser DEFAULT_INT_PARSER;
    public static readonly Lucene.Net.Search.LongParser DEFAULT_LONG_PARSER;
    public static readonly Lucene.Net.Search.ShortParser DEFAULT_SHORT_PARSER;
    public static readonly Lucene.Net.Search.DoubleParser NUMERIC_UTILS_DOUBLE_PARSER;
    public static readonly Lucene.Net.Search.FloatParser NUMERIC_UTILS_FLOAT_PARSER;
    public static readonly Lucene.Net.Search.IntParser NUMERIC_UTILS_INT_PARSER;
    public static readonly Lucene.Net.Search.LongParser NUMERIC_UTILS_LONG_PARSER;
    public static readonly int STRING_INDEX;
  }
  public static partial class FieldCacheRangeFilter {
    public static Lucene.Net.Search.FieldCacheRangeFilter<System.Nullable<System.SByte>> NewByteRange(string field, Lucene.Net.Search.ByteParser parser, System.Nullable<System.SByte> lowerVal, System.Nullable<System.SByte> upperVal, bool includeLower, bool includeUpper) { return default(Lucene.Net.Search.FieldCacheRangeFilter<System.Nullable<System.SByte>>); }
    public static Lucene.Net.Search.FieldCacheRangeFilter<System.Nullable<System.SByte>> NewByteRange(string field, System.Nullable<System.SByte> lowerVal, System.Nullable<System.SByte> upperVal, bool includeLower, bool includeUpper) { return default(Lucene.Net.Search.FieldCacheRangeFilter<System.Nullable<System.SByte>>); }
    public static Lucene.Net.Search.FieldCacheRangeFilter<System.Nullable<System.Double>> NewDoubleRange(string field, Lucene.Net.Search.DoubleParser parser, System.Nullable<System.Double> lowerVal, System.Nullable<System.Double> upperVal, bool includeLower, bool includeUpper) { return default(Lucene.Net.Search.FieldCacheRangeFilter<System.Nullable<System.Double>>); }
    public static Lucene.Net.Search.FieldCacheRangeFilter<System.Nullable<System.Double>> NewDoubleRange(string field, System.Nullable<System.Double> lowerVal, System.Nullable<System.Double> upperVal, bool includeLower, bool includeUpper) { return default(Lucene.Net.Search.FieldCacheRangeFilter<System.Nullable<System.Double>>); }
    public static Lucene.Net.Search.FieldCacheRangeFilter<System.Nullable<System.Single>> NewFloatRange(string field, Lucene.Net.Search.FloatParser parser, System.Nullable<System.Single> lowerVal, System.Nullable<System.Single> upperVal, bool includeLower, bool includeUpper) { return default(Lucene.Net.Search.FieldCacheRangeFilter<System.Nullable<System.Single>>); }
    public static Lucene.Net.Search.FieldCacheRangeFilter<System.Nullable<System.Single>> NewFloatRange(string field, System.Nullable<System.Single> lowerVal, System.Nullable<System.Single> upperVal, bool includeLower, bool includeUpper) { return default(Lucene.Net.Search.FieldCacheRangeFilter<System.Nullable<System.Single>>); }
    public static Lucene.Net.Search.FieldCacheRangeFilter<System.Nullable<System.Int32>> NewIntRange(string field, Lucene.Net.Search.IntParser parser, System.Nullable<System.Int32> lowerVal, System.Nullable<System.Int32> upperVal, bool includeLower, bool includeUpper) { return default(Lucene.Net.Search.FieldCacheRangeFilter<System.Nullable<System.Int32>>); }
    public static Lucene.Net.Search.FieldCacheRangeFilter<System.Nullable<System.Int32>> NewIntRange(string field, System.Nullable<System.Int32> lowerVal, System.Nullable<System.Int32> upperVal, bool includeLower, bool includeUpper) { return default(Lucene.Net.Search.FieldCacheRangeFilter<System.Nullable<System.Int32>>); }
    public static Lucene.Net.Search.FieldCacheRangeFilter<System.Nullable<System.Int64>> NewLongRange(string field, Lucene.Net.Search.LongParser parser, System.Nullable<System.Int64> lowerVal, System.Nullable<System.Int64> upperVal, bool includeLower, bool includeUpper) { return default(Lucene.Net.Search.FieldCacheRangeFilter<System.Nullable<System.Int64>>); }
    public static Lucene.Net.Search.FieldCacheRangeFilter<System.Nullable<System.Int64>> NewLongRange(string field, System.Nullable<System.Int64> lowerVal, System.Nullable<System.Int64> upperVal, bool includeLower, bool includeUpper) { return default(Lucene.Net.Search.FieldCacheRangeFilter<System.Nullable<System.Int64>>); }
    public static Lucene.Net.Search.FieldCacheRangeFilter<System.Nullable<System.Int16>> NewShortRange(string field, Lucene.Net.Search.ShortParser parser, System.Nullable<System.Int16> lowerVal, System.Nullable<System.Int16> upperVal, bool includeLower, bool includeUpper) { return default(Lucene.Net.Search.FieldCacheRangeFilter<System.Nullable<System.Int16>>); }
    public static Lucene.Net.Search.FieldCacheRangeFilter<System.Nullable<System.Int16>> NewShortRange(string field, System.Nullable<System.Int16> lowerVal, System.Nullable<System.Int16> upperVal, bool includeLower, bool includeUpper) { return default(Lucene.Net.Search.FieldCacheRangeFilter<System.Nullable<System.Int16>>); }
    public static Lucene.Net.Search.FieldCacheRangeFilter<System.String> NewStringRange(string field, string lowerVal, string upperVal, bool includeLower, bool includeUpper) { return default(Lucene.Net.Search.FieldCacheRangeFilter<System.String>); }
  }
  public abstract partial class FieldCacheRangeFilter<T> : Lucene.Net.Search.Filter {
    protected internal FieldCacheRangeFilter(string field, Lucene.Net.Search.Parser parser, T lowerVal, T upperVal, bool includeLower, bool includeUpper) { }
    public string GetField { get { return default(string); } }
    public bool IncludesLower { get { return default(bool); } }
    public bool IncludesUpper { get { return default(bool); } }
    public T LowerValue { get { return default(T); } }
    public Lucene.Net.Search.Parser Parser { get { return default(Lucene.Net.Search.Parser); } }
    public T UpperValue { get { return default(T); } }
    public override bool Equals(object o) { return default(bool); }
    public abstract override Lucene.Net.Search.DocIdSet GetDocIdSet(Lucene.Net.Index.IndexReader reader);
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
  }
  public partial class FieldCacheTermsFilter : Lucene.Net.Search.Filter {
    public FieldCacheTermsFilter(string field, params System.String[] terms) { }
    public virtual Lucene.Net.Search.FieldCache FieldCache { get { return default(Lucene.Net.Search.FieldCache); } }
    public override Lucene.Net.Search.DocIdSet GetDocIdSet(Lucene.Net.Index.IndexReader reader) { return default(Lucene.Net.Search.DocIdSet); }
    protected internal partial class FieldCacheTermsFilterDocIdSet : Lucene.Net.Search.DocIdSet {
      public FieldCacheTermsFilterDocIdSet(Lucene.Net.Search.FieldCacheTermsFilter enclosingInstance, Lucene.Net.Search.StringIndex fcsi) { }
      public Lucene.Net.Search.FieldCacheTermsFilter Enclosing_Instance { get { return default(Lucene.Net.Search.FieldCacheTermsFilter); } }
      public override bool IsCacheable { get { return default(bool); } }
      public override Lucene.Net.Search.DocIdSetIterator Iterator() { return default(Lucene.Net.Search.DocIdSetIterator); }
      protected internal partial class FieldCacheTermsFilterDocIdSetIterator : Lucene.Net.Search.DocIdSetIterator {
        public FieldCacheTermsFilterDocIdSetIterator(Lucene.Net.Search.FieldCacheTermsFilter.FieldCacheTermsFilterDocIdSet enclosingInstance) { }
        public Lucene.Net.Search.FieldCacheTermsFilter.FieldCacheTermsFilterDocIdSet Enclosing_Instance { get { return default(Lucene.Net.Search.FieldCacheTermsFilter.FieldCacheTermsFilterDocIdSet); } }
        public override int Advance(int target) { return default(int); }
        public override int DocID() { return default(int); }
        public override int NextDoc() { return default(int); }
      }
    }
  }
  public abstract partial class FieldComparator {
    protected FieldComparator() { }
    public abstract System.IComparable this[int slot] { get; }
    protected internal static int BinarySearch(System.String[] a, string key) { return default(int); }
    protected internal static int BinarySearch(System.String[] a, string key, int low, int high) { return default(int); }
    public abstract int Compare(int slot1, int slot2);
    public abstract int CompareBottom(int doc);
    public abstract void Copy(int slot, int doc);
    public abstract void SetBottom(int slot);
    public abstract void SetNextReader(Lucene.Net.Index.IndexReader reader, int docBase);
    public virtual void SetScorer(Lucene.Net.Search.Scorer scorer) { }
    public sealed partial class ByteComparator : Lucene.Net.Search.FieldComparator {
      internal ByteComparator() { }
      public override System.IComparable this[int slot] { get { return default(System.IComparable); } }
      public override int Compare(int slot1, int slot2) { return default(int); }
      public override int CompareBottom(int doc) { return default(int); }
      public override void Copy(int slot, int doc) { }
      public override void SetBottom(int bottom) { }
      public override void SetNextReader(Lucene.Net.Index.IndexReader reader, int docBase) { }
    }
    public sealed partial class DocComparator : Lucene.Net.Search.FieldComparator {
      internal DocComparator() { }
      public override System.IComparable this[int slot] { get { return default(System.IComparable); } }
      public override int Compare(int slot1, int slot2) { return default(int); }
      public override int CompareBottom(int doc) { return default(int); }
      public override void Copy(int slot, int doc) { }
      public override void SetBottom(int bottom) { }
      public override void SetNextReader(Lucene.Net.Index.IndexReader reader, int docBase) { }
    }
    public sealed partial class DoubleComparator : Lucene.Net.Search.FieldComparator {
      internal DoubleComparator() { }
      public override System.IComparable this[int slot] { get { return default(System.IComparable); } }
      public override int Compare(int slot1, int slot2) { return default(int); }
      public override int CompareBottom(int doc) { return default(int); }
      public override void Copy(int slot, int doc) { }
      public override void SetBottom(int bottom) { }
      public override void SetNextReader(Lucene.Net.Index.IndexReader reader, int docBase) { }
    }
    public sealed partial class FloatComparator : Lucene.Net.Search.FieldComparator {
      internal FloatComparator() { }
      public override System.IComparable this[int slot] { get { return default(System.IComparable); } }
      public override int Compare(int slot1, int slot2) { return default(int); }
      public override int CompareBottom(int doc) { return default(int); }
      public override void Copy(int slot, int doc) { }
      public override void SetBottom(int bottom) { }
      public override void SetNextReader(Lucene.Net.Index.IndexReader reader, int docBase) { }
    }
    public sealed partial class IntComparator : Lucene.Net.Search.FieldComparator {
      internal IntComparator() { }
      public override System.IComparable this[int slot] { get { return default(System.IComparable); } }
      public override int Compare(int slot1, int slot2) { return default(int); }
      public override int CompareBottom(int doc) { return default(int); }
      public override void Copy(int slot, int doc) { }
      public override void SetBottom(int bottom) { }
      public override void SetNextReader(Lucene.Net.Index.IndexReader reader, int docBase) { }
    }
    public sealed partial class LongComparator : Lucene.Net.Search.FieldComparator {
      internal LongComparator() { }
      public override System.IComparable this[int slot] { get { return default(System.IComparable); } }
      public override int Compare(int slot1, int slot2) { return default(int); }
      public override int CompareBottom(int doc) { return default(int); }
      public override void Copy(int slot, int doc) { }
      public override void SetBottom(int bottom) { }
      public override void SetNextReader(Lucene.Net.Index.IndexReader reader, int docBase) { }
    }
    public sealed partial class RelevanceComparator : Lucene.Net.Search.FieldComparator {
      internal RelevanceComparator() { }
      public override System.IComparable this[int slot] { get { return default(System.IComparable); } }
      public override int Compare(int slot1, int slot2) { return default(int); }
      public override int CompareBottom(int doc) { return default(int); }
      public override void Copy(int slot, int doc) { }
      public override void SetBottom(int bottom) { }
      public override void SetNextReader(Lucene.Net.Index.IndexReader reader, int docBase) { }
      public override void SetScorer(Lucene.Net.Search.Scorer scorer) { }
    }
    public sealed partial class ShortComparator : Lucene.Net.Search.FieldComparator {
      internal ShortComparator() { }
      public override System.IComparable this[int slot] { get { return default(System.IComparable); } }
      public override int Compare(int slot1, int slot2) { return default(int); }
      public override int CompareBottom(int doc) { return default(int); }
      public override void Copy(int slot, int doc) { }
      public override void SetBottom(int bottom) { }
      public override void SetNextReader(Lucene.Net.Index.IndexReader reader, int docBase) { }
    }
    public sealed partial class StringComparatorLocale : Lucene.Net.Search.FieldComparator {
      internal StringComparatorLocale() { }
      public override System.IComparable this[int slot] { get { return default(System.IComparable); } }
      public override int Compare(int slot1, int slot2) { return default(int); }
      public override int CompareBottom(int doc) { return default(int); }
      public override void Copy(int slot, int doc) { }
      public override void SetBottom(int bottom) { }
      public override void SetNextReader(Lucene.Net.Index.IndexReader reader, int docBase) { }
    }
    public sealed partial class StringOrdValComparator : Lucene.Net.Search.FieldComparator {
      public StringOrdValComparator(int numHits, string field, int sortPos, bool reversed) { }
      public int BottomSlot { get { return default(int); } }
      public string Field { get { return default(string); } }
      public override System.IComparable this[int slot] { get { return default(System.IComparable); } }
      public override int Compare(int slot1, int slot2) { return default(int); }
      public override int CompareBottom(int doc) { return default(int); }
      public override void Copy(int slot, int doc) { }
      public System.String[] GetValues() { return default(System.String[]); }
      public override void SetBottom(int bottom) { }
      public override void SetNextReader(Lucene.Net.Index.IndexReader reader, int docBase) { }
    }
    public sealed partial class StringValComparator : Lucene.Net.Search.FieldComparator {
      internal StringValComparator() { }
      public override System.IComparable this[int slot] { get { return default(System.IComparable); } }
      public override int Compare(int slot1, int slot2) { return default(int); }
      public override int CompareBottom(int doc) { return default(int); }
      public override void Copy(int slot, int doc) { }
      public override void SetBottom(int bottom) { }
      public override void SetNextReader(Lucene.Net.Index.IndexReader reader, int docBase) { }
    }
  }
  public abstract partial class FieldComparatorSource {
    protected FieldComparatorSource() { }
    public abstract Lucene.Net.Search.FieldComparator NewComparator(string fieldname, int numHits, int sortPos, bool reversed);
  }
  public partial class FieldDoc : Lucene.Net.Search.ScoreDoc {
    public System.IComparable[] fields;
    public FieldDoc(int doc, float score) : base (default(int), default(float)) { }
    public FieldDoc(int doc, float score, System.IComparable[] fields) : base (default(int), default(float)) { }
    public override string ToString() { return default(string); }
  }
  public abstract partial class FieldValueHitQueue : Lucene.Net.Util.PriorityQueue<Lucene.Net.Search.FieldValueHitQueue.Entry> {
    internal FieldValueHitQueue() { }
    protected internal Lucene.Net.Search.FieldComparator[] comparators;
    protected internal Lucene.Net.Search.SortField[] fields;
    protected internal System.Int32[] reverseMul;
    public static Lucene.Net.Search.FieldValueHitQueue Create(Lucene.Net.Search.SortField[] fields, int size) { return default(Lucene.Net.Search.FieldValueHitQueue); }
    public abstract override bool LessThan(Lucene.Net.Search.FieldValueHitQueue.Entry a, Lucene.Net.Search.FieldValueHitQueue.Entry b);
    public sealed partial class Entry : Lucene.Net.Search.ScoreDoc {
      internal Entry() : base (default(int), default(float)) { }
      public override string ToString() { return default(string); }
    }
  }
  public abstract partial class Filter {
    protected Filter() { }
    public abstract Lucene.Net.Search.DocIdSet GetDocIdSet(Lucene.Net.Index.IndexReader reader);
  }
  public abstract partial class FilteredDocIdSet : Lucene.Net.Search.DocIdSet {
    protected FilteredDocIdSet(Lucene.Net.Search.DocIdSet innerSet) { }
    public override bool IsCacheable { get { return default(bool); } }
    public override Lucene.Net.Search.DocIdSetIterator Iterator() { return default(Lucene.Net.Search.DocIdSetIterator); }
    public abstract bool Match(int docid);
  }
  public abstract partial class FilteredDocIdSetIterator : Lucene.Net.Search.DocIdSetIterator {
    protected internal Lucene.Net.Search.DocIdSetIterator internalInnerIter;
    protected FilteredDocIdSetIterator(Lucene.Net.Search.DocIdSetIterator innerIter) { }
    public override int Advance(int target) { return default(int); }
    public override int DocID() { return default(int); }
    public abstract bool Match(int doc);
    public override int NextDoc() { return default(int); }
  }
  public partial class FilteredQuery : Lucene.Net.Search.Query {
    public FilteredQuery(Lucene.Net.Search.Query query, Lucene.Net.Search.Filter filter) { }
    public virtual Lucene.Net.Search.Filter Filter { get { return default(Lucene.Net.Search.Filter); } }
    public virtual Lucene.Net.Search.Query Query { get { return default(Lucene.Net.Search.Query); } }
    public override Lucene.Net.Search.Weight CreateWeight(Lucene.Net.Search.Searcher searcher) { return default(Lucene.Net.Search.Weight); }
    public override bool Equals(object o) { return default(bool); }
    public override void ExtractTerms(System.Collections.Generic.ISet<Lucene.Net.Index.Term> terms) { }
    public override int GetHashCode() { return default(int); }
    public override Lucene.Net.Search.Query Rewrite(Lucene.Net.Index.IndexReader reader) { return default(Lucene.Net.Search.Query); }
    public override string ToString(string s) { return default(string); }
  }
  public abstract partial class FilteredTermEnum : Lucene.Net.Index.TermEnum {
    protected internal Lucene.Net.Index.TermEnum actualEnum;
    protected internal Lucene.Net.Index.Term currentTerm;
    protected FilteredTermEnum() { }
    public override Lucene.Net.Index.Term Term { get { return default(Lucene.Net.Index.Term); } }
    public abstract float Difference();
    protected override void Dispose(bool disposing) { }
    public override int DocFreq() { return default(int); }
    public abstract bool EndEnum();
    public override bool Next() { return default(bool); }
    protected internal virtual void SetEnum(Lucene.Net.Index.TermEnum actualEnum) { }
    protected internal abstract bool TermCompare(Lucene.Net.Index.Term term);
  }
  public partial class FilterManager {
    protected internal System.Collections.Generic.IDictionary<System.Int32, Lucene.Net.Search.FilterManager.FilterItem> cache;
    protected internal int cacheCleanSize;
    protected internal long cleanSleepTime;
    protected internal const int DEFAULT_CACHE_CLEAN_SIZE = 100;
    protected internal const long DEFAULT_CACHE_SLEEP_TIME = (long)600000;
    protected internal Lucene.Net.Search.FilterManager.FilterCleaner internalFilterCleaner;
    protected internal static Lucene.Net.Search.FilterManager manager;
    protected internal FilterManager() { }
    public static Lucene.Net.Search.FilterManager Instance { get { return default(Lucene.Net.Search.FilterManager); } }
    public virtual Lucene.Net.Search.Filter GetFilter(Lucene.Net.Search.Filter filter) { return default(Lucene.Net.Search.Filter); }
    public virtual void SetCacheSize(int value) { }
    public virtual void SetCleanThreadSleepTime(long value) { }
    protected internal partial class FilterCleaner : Lucene.Net.Support.IThreadRunnable {
      public FilterCleaner(Lucene.Net.Search.FilterManager enclosingInstance) { }
      public virtual void Run() { }
    }
    protected internal partial class FilterItem {
      public Lucene.Net.Search.Filter filter;
      public long timestamp;
      public FilterItem(Lucene.Net.Search.Filter filter) { }
    }
  }
  public partial interface FloatParser : Lucene.Net.Search.Parser {
    float ParseFloat(string string_Renamed);
  }
  public partial class FuzzyQuery : Lucene.Net.Search.MultiTermQuery {
    public const float defaultMinSimilarity = 0.5f;
    public const int defaultPrefixLength = 0;
    public FuzzyQuery(Lucene.Net.Index.Term term) { }
    public FuzzyQuery(Lucene.Net.Index.Term term, float minimumSimilarity) { }
    public FuzzyQuery(Lucene.Net.Index.Term term, float minimumSimilarity, int prefixLength) { }
    public virtual float MinSimilarity { get { return default(float); } }
    public virtual int PrefixLength { get { return default(int); } }
    public override Lucene.Net.Search.RewriteMethod RewriteMethod { set { } }
    public Lucene.Net.Index.Term Term { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Lucene.Net.Index.Term); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected internal set { } }
    public override bool Equals(object obj) { return default(bool); }
    protected internal override Lucene.Net.Search.FilteredTermEnum GetEnum(Lucene.Net.Index.IndexReader reader) { return default(Lucene.Net.Search.FilteredTermEnum); }
    public override int GetHashCode() { return default(int); }
    public override Lucene.Net.Search.Query Rewrite(Lucene.Net.Index.IndexReader reader) { return default(Lucene.Net.Search.Query); }
    public override string ToString(string field) { return default(string); }
    protected internal partial class ScoreTerm : System.IComparable<Lucene.Net.Search.FuzzyQuery.ScoreTerm> {
      public float score;
      public Lucene.Net.Index.Term term;
      public ScoreTerm() { }
      public int CompareTo(Lucene.Net.Search.FuzzyQuery.ScoreTerm other) { return default(int); }
    }
  }
  public sealed partial class FuzzyTermEnum : Lucene.Net.Search.FilteredTermEnum {
    public FuzzyTermEnum(Lucene.Net.Index.IndexReader reader, Lucene.Net.Index.Term term) { }
    public FuzzyTermEnum(Lucene.Net.Index.IndexReader reader, Lucene.Net.Index.Term term, float minSimilarity) { }
    public FuzzyTermEnum(Lucene.Net.Index.IndexReader reader, Lucene.Net.Index.Term term, float minSimilarity, int prefixLength) { }
    public override float Difference() { return default(float); }
    protected override void Dispose(bool disposing) { }
    public override bool EndEnum() { return default(bool); }
    protected internal override bool TermCompare(Lucene.Net.Index.Term term) { return default(bool); }
  }
  public sealed partial class HitQueue : Lucene.Net.Util.PriorityQueue<Lucene.Net.Search.ScoreDoc> {
    public HitQueue(int size, bool prePopulate) { }
    protected internal override Lucene.Net.Search.ScoreDoc SentinelObject { get { return default(Lucene.Net.Search.ScoreDoc); } }
    public override bool LessThan(Lucene.Net.Search.ScoreDoc hitA, Lucene.Net.Search.ScoreDoc hitB) { return default(bool); }
  }
  public partial class IndexSearcher : Lucene.Net.Search.Searcher {
    public IndexSearcher(Lucene.Net.Index.IndexReader r) { }
    public IndexSearcher(Lucene.Net.Index.IndexReader reader, Lucene.Net.Index.IndexReader[] subReaders, System.Int32[] docStarts) { }
    public IndexSearcher(Lucene.Net.Store.Directory path) { }
    public IndexSearcher(Lucene.Net.Store.Directory path, bool readOnly) { }
    public virtual Lucene.Net.Index.IndexReader IndexReader { get { return default(Lucene.Net.Index.IndexReader); } }
    public override int MaxDoc { get { return default(int); } }
    public Lucene.Net.Index.IndexReader reader_ForNUnit { get { return default(Lucene.Net.Index.IndexReader); } }
    protected override void Dispose(bool disposing) { }
    public override Lucene.Net.Documents.Document Doc(int i) { return default(Lucene.Net.Documents.Document); }
    public override Lucene.Net.Documents.Document Doc(int i, Lucene.Net.Documents.FieldSelector fieldSelector) { return default(Lucene.Net.Documents.Document); }
    public override int DocFreq(Lucene.Net.Index.Term term) { return default(int); }
    public override Lucene.Net.Search.Explanation Explain(Lucene.Net.Search.Weight weight, int doc) { return default(Lucene.Net.Search.Explanation); }
    protected internal virtual void GatherSubReaders(System.Collections.Generic.IList<Lucene.Net.Index.IndexReader> allSubReaders, Lucene.Net.Index.IndexReader r) { }
    public override Lucene.Net.Search.Query Rewrite(Lucene.Net.Search.Query original) { return default(Lucene.Net.Search.Query); }
    public override void Search(Lucene.Net.Search.Weight weight, Lucene.Net.Search.Filter filter, Lucene.Net.Search.Collector collector) { }
    public override Lucene.Net.Search.TopDocs Search(Lucene.Net.Search.Weight weight, Lucene.Net.Search.Filter filter, int nDocs) { return default(Lucene.Net.Search.TopDocs); }
    public override Lucene.Net.Search.TopFieldDocs Search(Lucene.Net.Search.Weight weight, Lucene.Net.Search.Filter filter, int nDocs, Lucene.Net.Search.Sort sort) { return default(Lucene.Net.Search.TopFieldDocs); }
    public virtual Lucene.Net.Search.TopFieldDocs Search(Lucene.Net.Search.Weight weight, Lucene.Net.Search.Filter filter, int nDocs, Lucene.Net.Search.Sort sort, bool fillFields) { return default(Lucene.Net.Search.TopFieldDocs); }
    public virtual void SetDefaultFieldSortScoring(bool doTrackScores, bool doMaxScore) { }
  }
  public partial interface IntParser : Lucene.Net.Search.Parser {
    int ParseInt(string string_Renamed);
  }
  public partial interface LongParser : Lucene.Net.Search.Parser {
    long ParseLong(string string_Renamed);
  }
  public partial class MatchAllDocsQuery : Lucene.Net.Search.Query {
    public MatchAllDocsQuery() { }
    public MatchAllDocsQuery(string normsField) { }
    public override Lucene.Net.Search.Weight CreateWeight(Lucene.Net.Search.Searcher searcher) { return default(Lucene.Net.Search.Weight); }
    public override bool Equals(object o) { return default(bool); }
    public override void ExtractTerms(System.Collections.Generic.ISet<Lucene.Net.Index.Term> terms) { }
    public override int GetHashCode() { return default(int); }
    public override string ToString(string field) { return default(string); }
  }
  public partial class MultiPhraseQuery : Lucene.Net.Search.Query {
    public MultiPhraseQuery() { }
    public virtual int Slop { get { return default(int); } set { } }
    public virtual void Add(Lucene.Net.Index.Term term) { }
    public virtual void Add(Lucene.Net.Index.Term[] terms) { }
    public virtual void Add(Lucene.Net.Index.Term[] terms, int position) { }
    public override Lucene.Net.Search.Weight CreateWeight(Lucene.Net.Search.Searcher searcher) { return default(Lucene.Net.Search.Weight); }
    public override bool Equals(object o) { return default(bool); }
    public override void ExtractTerms(System.Collections.Generic.ISet<Lucene.Net.Index.Term> terms) { }
    public override int GetHashCode() { return default(int); }
    public virtual System.Int32[] GetPositions() { return default(System.Int32[]); }
    public virtual System.Collections.Generic.IList<Lucene.Net.Index.Term[]> GetTermArrays() { return default(System.Collections.Generic.IList<Lucene.Net.Index.Term[]>); }
    public override Lucene.Net.Search.Query Rewrite(Lucene.Net.Index.IndexReader reader) { return default(Lucene.Net.Search.Query); }
    public static bool TermEquals(System.Array array1, System.Array array2) { return default(bool); }
    public override string ToString(string f) { return default(string); }
  }
  public partial class MultiSearcher : Lucene.Net.Search.Searcher {
    public MultiSearcher(params Lucene.Net.Search.Searchable[] searchables) { }
    public override int MaxDoc { get { return default(int); } }
    public override Lucene.Net.Search.Weight CreateWeight(Lucene.Net.Search.Query original) { return default(Lucene.Net.Search.Weight); }
    protected override void Dispose(bool disposing) { }
    public override Lucene.Net.Documents.Document Doc(int n) { return default(Lucene.Net.Documents.Document); }
    public override Lucene.Net.Documents.Document Doc(int n, Lucene.Net.Documents.FieldSelector fieldSelector) { return default(Lucene.Net.Documents.Document); }
    public override int DocFreq(Lucene.Net.Index.Term term) { return default(int); }
    public override Lucene.Net.Search.Explanation Explain(Lucene.Net.Search.Weight weight, int doc) { return default(Lucene.Net.Search.Explanation); }
    public virtual Lucene.Net.Search.Searchable[] GetSearchables() { return default(Lucene.Net.Search.Searchable[]); }
    protected internal virtual System.Int32[] GetStarts() { return default(System.Int32[]); }
    public override Lucene.Net.Search.Query Rewrite(Lucene.Net.Search.Query original) { return default(Lucene.Net.Search.Query); }
    public override void Search(Lucene.Net.Search.Weight weight, Lucene.Net.Search.Filter filter, Lucene.Net.Search.Collector collector) { }
    public override Lucene.Net.Search.TopDocs Search(Lucene.Net.Search.Weight weight, Lucene.Net.Search.Filter filter, int nDocs) { return default(Lucene.Net.Search.TopDocs); }
    public override Lucene.Net.Search.TopFieldDocs Search(Lucene.Net.Search.Weight weight, Lucene.Net.Search.Filter filter, int n, Lucene.Net.Search.Sort sort) { return default(Lucene.Net.Search.TopFieldDocs); }
    public virtual int SubDoc(int n) { return default(int); }
    public virtual int SubSearcher(int n) { return default(int); }
  }
  public abstract partial class MultiTermQuery : Lucene.Net.Search.Query {
    public static readonly Lucene.Net.Search.RewriteMethod CONSTANT_SCORE_AUTO_REWRITE_DEFAULT;
    public static readonly Lucene.Net.Search.RewriteMethod CONSTANT_SCORE_BOOLEAN_QUERY_REWRITE;
    public static readonly Lucene.Net.Search.RewriteMethod CONSTANT_SCORE_FILTER_REWRITE;
    protected internal Lucene.Net.Search.RewriteMethod internalRewriteMethod;
    public static readonly Lucene.Net.Search.RewriteMethod SCORING_BOOLEAN_QUERY_REWRITE;
    protected MultiTermQuery() { }
    public virtual Lucene.Net.Search.RewriteMethod RewriteMethod { get { return default(Lucene.Net.Search.RewriteMethod); } set { } }
    public virtual int TotalNumberOfTerms { get { return default(int); } }
    public virtual void ClearTotalNumberOfTerms() { }
    public override bool Equals(object obj) { return default(bool); }
    protected internal abstract Lucene.Net.Search.FilteredTermEnum GetEnum(Lucene.Net.Index.IndexReader reader);
    public override int GetHashCode() { return default(int); }
    protected internal virtual void IncTotalNumberOfTerms(int inc) { }
    public override Lucene.Net.Search.Query Rewrite(Lucene.Net.Index.IndexReader reader) { return default(Lucene.Net.Search.Query); }
    public partial class AnonymousClassConstantScoreAutoRewrite : Lucene.Net.Search.MultiTermQuery.ConstantScoreAutoRewrite {
      public AnonymousClassConstantScoreAutoRewrite() { }
      public override double DocCountPercent { set { } }
      public override int TermCountCutoff { set { } }
      protected internal virtual object ReadResolve() { return default(object); }
    }
    public partial class ConstantScoreAutoRewrite : Lucene.Net.Search.RewriteMethod {
      public static double DEFAULT_DOC_COUNT_PERCENT;
      public static int DEFAULT_TERM_COUNT_CUTOFF;
      public ConstantScoreAutoRewrite() { }
      public virtual double DocCountPercent { get { return default(double); } set { } }
      public virtual int TermCountCutoff { get { return default(int); } set { } }
      public override bool Equals(object obj) { return default(bool); }
      public override int GetHashCode() { return default(int); }
      public override Lucene.Net.Search.Query Rewrite(Lucene.Net.Index.IndexReader reader, Lucene.Net.Search.MultiTermQuery query) { return default(Lucene.Net.Search.Query); }
    }
  }
  public partial class MultiTermQueryWrapperFilter<T> : Lucene.Net.Search.Filter where T : Lucene.Net.Search.MultiTermQuery {
    protected internal T query;
    protected internal MultiTermQueryWrapperFilter(T query) { }
    public virtual int TotalNumberOfTerms { get { return default(int); } }
    public virtual void ClearTotalNumberOfTerms() { }
    public override bool Equals(object o) { return default(bool); }
    public override Lucene.Net.Search.DocIdSet GetDocIdSet(Lucene.Net.Index.IndexReader reader) { return default(Lucene.Net.Search.DocIdSet); }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
  }
  public static partial class NumericRangeFilter {
    public static Lucene.Net.Search.NumericRangeFilter<System.Double> NewDoubleRange(string field, int precisionStep, System.Nullable<System.Double> min, System.Nullable<System.Double> max, bool minInclusive, bool maxInclusive) { return default(Lucene.Net.Search.NumericRangeFilter<System.Double>); }
    public static Lucene.Net.Search.NumericRangeFilter<System.Double> NewDoubleRange(string field, System.Nullable<System.Double> min, System.Nullable<System.Double> max, bool minInclusive, bool maxInclusive) { return default(Lucene.Net.Search.NumericRangeFilter<System.Double>); }
    public static Lucene.Net.Search.NumericRangeFilter<System.Single> NewFloatRange(string field, int precisionStep, System.Nullable<System.Single> min, System.Nullable<System.Single> max, bool minInclusive, bool maxInclusive) { return default(Lucene.Net.Search.NumericRangeFilter<System.Single>); }
    public static Lucene.Net.Search.NumericRangeFilter<System.Single> NewFloatRange(string field, System.Nullable<System.Single> min, System.Nullable<System.Single> max, bool minInclusive, bool maxInclusive) { return default(Lucene.Net.Search.NumericRangeFilter<System.Single>); }
    public static Lucene.Net.Search.NumericRangeFilter<System.Int32> NewIntRange(string field, int precisionStep, System.Nullable<System.Int32> min, System.Nullable<System.Int32> max, bool minInclusive, bool maxInclusive) { return default(Lucene.Net.Search.NumericRangeFilter<System.Int32>); }
    public static Lucene.Net.Search.NumericRangeFilter<System.Int32> NewIntRange(string field, System.Nullable<System.Int32> min, System.Nullable<System.Int32> max, bool minInclusive, bool maxInclusive) { return default(Lucene.Net.Search.NumericRangeFilter<System.Int32>); }
    public static Lucene.Net.Search.NumericRangeFilter<System.Int64> NewLongRange(string field, int precisionStep, System.Nullable<System.Int64> min, System.Nullable<System.Int64> max, bool minInclusive, bool maxInclusive) { return default(Lucene.Net.Search.NumericRangeFilter<System.Int64>); }
    public static Lucene.Net.Search.NumericRangeFilter<System.Int64> NewLongRange(string field, System.Nullable<System.Int64> min, System.Nullable<System.Int64> max, bool minInclusive, bool maxInclusive) { return default(Lucene.Net.Search.NumericRangeFilter<System.Int64>); }
  }
  public sealed partial class NumericRangeFilter<T> : Lucene.Net.Search.MultiTermQueryWrapperFilter<Lucene.Net.Search.NumericRangeQuery<T>> where T : struct, System.IComparable<T> {
    internal NumericRangeFilter() : base (default(Lucene.Net.Search.NumericRangeQuery<T>)) { }
    public string Field { get { return default(string); } }
    public bool IncludesMax { get { return default(bool); } }
    public bool IncludesMin { get { return default(bool); } }
    public System.Nullable<T> Max { get { return default(System.Nullable<T>); } }
    public System.Nullable<T> Min { get { return default(System.Nullable<T>); } }
  }
  public static partial class NumericRangeQuery {
    public static Lucene.Net.Search.NumericRangeQuery<System.Double> NewDoubleRange(string field, int precisionStep, System.Nullable<System.Double> min, System.Nullable<System.Double> max, bool minInclusive, bool maxInclusive) { return default(Lucene.Net.Search.NumericRangeQuery<System.Double>); }
    public static Lucene.Net.Search.NumericRangeQuery<System.Double> NewDoubleRange(string field, System.Nullable<System.Double> min, System.Nullable<System.Double> max, bool minInclusive, bool maxInclusive) { return default(Lucene.Net.Search.NumericRangeQuery<System.Double>); }
    public static Lucene.Net.Search.NumericRangeQuery<System.Single> NewFloatRange(string field, int precisionStep, System.Nullable<System.Single> min, System.Nullable<System.Single> max, bool minInclusive, bool maxInclusive) { return default(Lucene.Net.Search.NumericRangeQuery<System.Single>); }
    public static Lucene.Net.Search.NumericRangeQuery<System.Single> NewFloatRange(string field, System.Nullable<System.Single> min, System.Nullable<System.Single> max, bool minInclusive, bool maxInclusive) { return default(Lucene.Net.Search.NumericRangeQuery<System.Single>); }
    public static Lucene.Net.Search.NumericRangeQuery<System.Int32> NewIntRange(string field, int precisionStep, System.Nullable<System.Int32> min, System.Nullable<System.Int32> max, bool minInclusive, bool maxInclusive) { return default(Lucene.Net.Search.NumericRangeQuery<System.Int32>); }
    public static Lucene.Net.Search.NumericRangeQuery<System.Int32> NewIntRange(string field, System.Nullable<System.Int32> min, System.Nullable<System.Int32> max, bool minInclusive, bool maxInclusive) { return default(Lucene.Net.Search.NumericRangeQuery<System.Int32>); }
    public static Lucene.Net.Search.NumericRangeQuery<System.Int64> NewLongRange(string field, int precisionStep, System.Nullable<System.Int64> min, System.Nullable<System.Int64> max, bool minInclusive, bool maxInclusive) { return default(Lucene.Net.Search.NumericRangeQuery<System.Int64>); }
    public static Lucene.Net.Search.NumericRangeQuery<System.Int64> NewLongRange(string field, System.Nullable<System.Int64> min, System.Nullable<System.Int64> max, bool minInclusive, bool maxInclusive) { return default(Lucene.Net.Search.NumericRangeQuery<System.Int64>); }
  }
  public sealed partial class NumericRangeQuery<T> : Lucene.Net.Search.MultiTermQuery where T : struct, System.IComparable<T> {
    internal NumericRangeQuery() { }
    public string Field { get { return default(string); } }
    public bool IncludesMax { get { return default(bool); } }
    public bool IncludesMin { get { return default(bool); } }
    public System.Nullable<T> Max { get { return default(System.Nullable<T>); } }
    public System.Nullable<T> Min { get { return default(System.Nullable<T>); } }
    public override bool Equals(object o) { return default(bool); }
    protected internal override Lucene.Net.Search.FilteredTermEnum GetEnum(Lucene.Net.Index.IndexReader reader) { return default(Lucene.Net.Search.FilteredTermEnum); }
    public override int GetHashCode() { return default(int); }
    public override string ToString(string field) { return default(string); }
  }
  public enum Occur {
    MUST = 0,
    MUST_NOT = 2,
    SHOULD = 1,
  }
  public static partial class OccurExtensions {
    public static string ToString(this Lucene.Net.Search.Occur occur) { return default(string); }
  }
  public partial class ParallelMultiSearcher : Lucene.Net.Search.MultiSearcher {
    public ParallelMultiSearcher(params Lucene.Net.Search.Searchable[] searchables) : base (default(Lucene.Net.Search.Searchable[])) { }
    public override int DocFreq(Lucene.Net.Index.Term term) { return default(int); }
    public override void Search(Lucene.Net.Search.Weight weight, Lucene.Net.Search.Filter filter, Lucene.Net.Search.Collector collector) { }
    public override Lucene.Net.Search.TopDocs Search(Lucene.Net.Search.Weight weight, Lucene.Net.Search.Filter filter, int nDocs) { return default(Lucene.Net.Search.TopDocs); }
    public override Lucene.Net.Search.TopFieldDocs Search(Lucene.Net.Search.Weight weight, Lucene.Net.Search.Filter filter, int nDocs, Lucene.Net.Search.Sort sort) { return default(Lucene.Net.Search.TopFieldDocs); }
  }
  public partial interface Parser {
  }
  public partial class PhraseQuery : Lucene.Net.Search.Query {
    public PhraseQuery() { }
    public virtual int Slop { get { return default(int); } set { } }
    public virtual void Add(Lucene.Net.Index.Term term) { }
    public virtual void Add(Lucene.Net.Index.Term term, int position) { }
    public override Lucene.Net.Search.Weight CreateWeight(Lucene.Net.Search.Searcher searcher) { return default(Lucene.Net.Search.Weight); }
    public override bool Equals(object o) { return default(bool); }
    public override void ExtractTerms(System.Collections.Generic.ISet<Lucene.Net.Index.Term> queryTerms) { }
    public override int GetHashCode() { return default(int); }
    public virtual System.Int32[] GetPositions() { return default(System.Int32[]); }
    public virtual Lucene.Net.Index.Term[] GetTerms() { return default(Lucene.Net.Index.Term[]); }
    public override string ToString(string f) { return default(string); }
  }
  public partial class PositiveScoresOnlyCollector : Lucene.Net.Search.Collector {
    public PositiveScoresOnlyCollector(Lucene.Net.Search.Collector c) { }
    public override bool AcceptsDocsOutOfOrder { get { return default(bool); } }
    public override void Collect(int doc) { }
    public override void SetNextReader(Lucene.Net.Index.IndexReader reader, int docBase) { }
    public override void SetScorer(Lucene.Net.Search.Scorer scorer) { }
  }
  public partial class PrefixFilter : Lucene.Net.Search.MultiTermQueryWrapperFilter<Lucene.Net.Search.PrefixQuery> {
    public PrefixFilter(Lucene.Net.Index.Term prefix) : base (default(Lucene.Net.Search.PrefixQuery)) { }
    public virtual Lucene.Net.Index.Term Prefix { get { return default(Lucene.Net.Index.Term); } }
    public override string ToString() { return default(string); }
  }
  public partial class PrefixQuery : Lucene.Net.Search.MultiTermQuery {
    public PrefixQuery(Lucene.Net.Index.Term prefix) { }
    public virtual Lucene.Net.Index.Term Prefix { get { return default(Lucene.Net.Index.Term); } }
    public override bool Equals(object obj) { return default(bool); }
    protected internal override Lucene.Net.Search.FilteredTermEnum GetEnum(Lucene.Net.Index.IndexReader reader) { return default(Lucene.Net.Search.FilteredTermEnum); }
    public override int GetHashCode() { return default(int); }
    public override string ToString(string field) { return default(string); }
  }
  public partial class PrefixTermEnum : Lucene.Net.Search.FilteredTermEnum {
    public PrefixTermEnum(Lucene.Net.Index.IndexReader reader, Lucene.Net.Index.Term prefix) { }
    protected internal virtual Lucene.Net.Index.Term PrefixTerm { get { return default(Lucene.Net.Index.Term); } }
    public override float Difference() { return default(float); }
    public override bool EndEnum() { return default(bool); }
    protected internal override bool TermCompare(Lucene.Net.Index.Term term) { return default(bool); }
  }
  public abstract partial class Query : System.ICloneable {
    protected Query() { }
    public virtual float Boost { get { return default(float); } set { } }
    public virtual object Clone() { return default(object); }
    public virtual Lucene.Net.Search.Query Combine(Lucene.Net.Search.Query[] queries) { return default(Lucene.Net.Search.Query); }
    public virtual Lucene.Net.Search.Weight CreateWeight(Lucene.Net.Search.Searcher searcher) { return default(Lucene.Net.Search.Weight); }
    public override bool Equals(object obj) { return default(bool); }
    public virtual void ExtractTerms(System.Collections.Generic.ISet<Lucene.Net.Index.Term> terms) { }
    public override int GetHashCode() { return default(int); }
    public virtual Lucene.Net.Search.Similarity GetSimilarity(Lucene.Net.Search.Searcher searcher) { return default(Lucene.Net.Search.Similarity); }
    public static Lucene.Net.Search.Query MergeBooleanQueries(params Lucene.Net.Search.BooleanQuery[] queries) { return default(Lucene.Net.Search.Query); }
    public virtual Lucene.Net.Search.Query Rewrite(Lucene.Net.Index.IndexReader reader) { return default(Lucene.Net.Search.Query); }
    public override string ToString() { return default(string); }
    public abstract string ToString(string field);
    public virtual Lucene.Net.Search.Weight Weight(Lucene.Net.Search.Searcher searcher) { return default(Lucene.Net.Search.Weight); }
  }
  public partial class QueryTermVector : Lucene.Net.Index.ITermFreqVector {
    public QueryTermVector(string queryString, Lucene.Net.Analysis.Analyzer analyzer) { }
    public QueryTermVector(System.String[] queryTerms) { }
    public virtual string Field { get { return default(string); } }
    public virtual int Size { get { return default(int); } }
    public virtual System.Int32[] GetTermFrequencies() { return default(System.Int32[]); }
    public virtual System.String[] GetTerms() { return default(System.String[]); }
    public virtual System.Int32[] IndexesOf(System.String[] terms, int start, int len) { return default(System.Int32[]); }
    public virtual int IndexOf(string term) { return default(int); }
    public override string ToString() { return default(string); }
  }
  public partial class QueryWrapperFilter : Lucene.Net.Search.Filter {
    public QueryWrapperFilter(Lucene.Net.Search.Query query) { }
    public override bool Equals(object o) { return default(bool); }
    public override Lucene.Net.Search.DocIdSet GetDocIdSet(Lucene.Net.Index.IndexReader reader) { return default(Lucene.Net.Search.DocIdSet); }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
  }
  public abstract partial class RewriteMethod {
    protected RewriteMethod() { }
    public abstract Lucene.Net.Search.Query Rewrite(Lucene.Net.Index.IndexReader reader, Lucene.Net.Search.MultiTermQuery query);
  }
  public partial class ScoreCachingWrappingScorer : Lucene.Net.Search.Scorer {
    public ScoreCachingWrappingScorer(Lucene.Net.Search.Scorer scorer) : base (default(Lucene.Net.Search.Similarity)) { }
    public override Lucene.Net.Search.Similarity Similarity { get { return default(Lucene.Net.Search.Similarity); } }
    public override int Advance(int target) { return default(int); }
    public override int DocID() { return default(int); }
    public override int NextDoc() { return default(int); }
    public override float Score() { return default(float); }
    public override void Score(Lucene.Net.Search.Collector collector) { }
    public override bool Score(Lucene.Net.Search.Collector collector, int max, int firstDocID) { return default(bool); }
  }
  public partial class ScoreDoc {
    public ScoreDoc(int doc, float score) { }
    public int Doc { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public float Score { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(float); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override string ToString() { return default(string); }
  }
  public abstract partial class Scorer : Lucene.Net.Search.DocIdSetIterator {
    protected internal Scorer(Lucene.Net.Search.Similarity similarity) { }
    public virtual Lucene.Net.Search.Similarity Similarity { get { return default(Lucene.Net.Search.Similarity); } }
    public abstract float Score();
    public virtual void Score(Lucene.Net.Search.Collector collector) { }
    public virtual bool Score(Lucene.Net.Search.Collector collector, int max, int firstDocID) { return default(bool); }
  }
  public partial interface Searchable : System.IDisposable {
    int MaxDoc { get; }
    void Close();
    Lucene.Net.Documents.Document Doc(int i);
    Lucene.Net.Documents.Document Doc(int n, Lucene.Net.Documents.FieldSelector fieldSelector);
    int DocFreq(Lucene.Net.Index.Term term);
    System.Int32[] DocFreqs(Lucene.Net.Index.Term[] terms);
    Lucene.Net.Search.Explanation Explain(Lucene.Net.Search.Weight weight, int doc);
    Lucene.Net.Search.Query Rewrite(Lucene.Net.Search.Query query);
    void Search(Lucene.Net.Search.Weight weight, Lucene.Net.Search.Filter filter, Lucene.Net.Search.Collector collector);
    Lucene.Net.Search.TopDocs Search(Lucene.Net.Search.Weight weight, Lucene.Net.Search.Filter filter, int n);
    Lucene.Net.Search.TopFieldDocs Search(Lucene.Net.Search.Weight weight, Lucene.Net.Search.Filter filter, int n, Lucene.Net.Search.Sort sort);
  }
  public abstract partial class Searcher : System.MarshalByRefObject, Lucene.Net.Search.Searchable, System.IDisposable {
    protected Searcher() { }
    public abstract int MaxDoc { get; }
    public virtual Lucene.Net.Search.Similarity Similarity { get { return default(Lucene.Net.Search.Similarity); } set { } }
    [System.ObsoleteAttribute("Use Dispose() instead")]
    public void Close() { }
    public virtual Lucene.Net.Search.Weight CreateWeight(Lucene.Net.Search.Query query) { return default(Lucene.Net.Search.Weight); }
    public void Dispose() { }
    protected abstract void Dispose(bool disposing);
    public abstract Lucene.Net.Documents.Document Doc(int i);
    public abstract Lucene.Net.Documents.Document Doc(int docid, Lucene.Net.Documents.FieldSelector fieldSelector);
    public abstract int DocFreq(Lucene.Net.Index.Term term);
    public virtual System.Int32[] DocFreqs(Lucene.Net.Index.Term[] terms) { return default(System.Int32[]); }
    public virtual Lucene.Net.Search.Explanation Explain(Lucene.Net.Search.Query query, int doc) { return default(Lucene.Net.Search.Explanation); }
    public abstract Lucene.Net.Search.Explanation Explain(Lucene.Net.Search.Weight weight, int doc);
    public abstract Lucene.Net.Search.Query Rewrite(Lucene.Net.Search.Query query);
    public virtual void Search(Lucene.Net.Search.Query query, Lucene.Net.Search.Collector results) { }
    public virtual void Search(Lucene.Net.Search.Query query, Lucene.Net.Search.Filter filter, Lucene.Net.Search.Collector results) { }
    public virtual Lucene.Net.Search.TopDocs Search(Lucene.Net.Search.Query query, Lucene.Net.Search.Filter filter, int n) { return default(Lucene.Net.Search.TopDocs); }
    public virtual Lucene.Net.Search.TopFieldDocs Search(Lucene.Net.Search.Query query, Lucene.Net.Search.Filter filter, int n, Lucene.Net.Search.Sort sort) { return default(Lucene.Net.Search.TopFieldDocs); }
    public virtual Lucene.Net.Search.TopDocs Search(Lucene.Net.Search.Query query, int n) { return default(Lucene.Net.Search.TopDocs); }
    public abstract void Search(Lucene.Net.Search.Weight weight, Lucene.Net.Search.Filter filter, Lucene.Net.Search.Collector results);
    public abstract Lucene.Net.Search.TopDocs Search(Lucene.Net.Search.Weight weight, Lucene.Net.Search.Filter filter, int n);
    public abstract Lucene.Net.Search.TopFieldDocs Search(Lucene.Net.Search.Weight weight, Lucene.Net.Search.Filter filter, int n, Lucene.Net.Search.Sort sort);
  }
  public partial interface ShortParser : Lucene.Net.Search.Parser {
    short ParseShort(string string_Renamed);
  }
  public abstract partial class Similarity {
    public const int NO_DOC_ID_PROVIDED = -1;
    protected Similarity() { }
    public static Lucene.Net.Search.Similarity Default { get { return default(Lucene.Net.Search.Similarity); } set { } }
    public virtual float ComputeNorm(string field, Lucene.Net.Index.FieldInvertState state) { return default(float); }
    public abstract float Coord(int overlap, int maxOverlap);
    public static float DecodeNorm(byte b) { return default(float); }
    public static byte EncodeNorm(float f) { return default(byte); }
    public static System.Single[] GetNormDecoder() { return default(System.Single[]); }
    public abstract float Idf(int docFreq, int numDocs);
    public virtual Lucene.Net.Search.Explanation.IDFExplanation IdfExplain(Lucene.Net.Index.Term term, Lucene.Net.Search.Searcher searcher) { return default(Lucene.Net.Search.Explanation.IDFExplanation); }
    public virtual Lucene.Net.Search.Explanation.IDFExplanation IdfExplain(System.Collections.Generic.ICollection<Lucene.Net.Index.Term> terms, Lucene.Net.Search.Searcher searcher) { return default(Lucene.Net.Search.Explanation.IDFExplanation); }
    public abstract float LengthNorm(string fieldName, int numTokens);
    public abstract float QueryNorm(float sumOfSquaredWeights);
    public virtual float ScorePayload(int docId, string fieldName, int start, int end, System.Byte[] payload, int offset, int length) { return default(float); }
    public abstract float SloppyFreq(int distance);
    public virtual float Tf(int freq) { return default(float); }
    public abstract float Tf(float freq);
  }
  public partial class SimilarityDelegator : Lucene.Net.Search.Similarity {
    public SimilarityDelegator(Lucene.Net.Search.Similarity delegee) { }
    public override float ComputeNorm(string fieldName, Lucene.Net.Index.FieldInvertState state) { return default(float); }
    public override float Coord(int overlap, int maxOverlap) { return default(float); }
    public override float Idf(int docFreq, int numDocs) { return default(float); }
    public override float LengthNorm(string fieldName, int numTerms) { return default(float); }
    public override float QueryNorm(float sumOfSquaredWeights) { return default(float); }
    public override float ScorePayload(int docId, string fieldName, int start, int end, System.Byte[] payload, int offset, int length) { return default(float); }
    public override float SloppyFreq(int distance) { return default(float); }
    public override float Tf(float freq) { return default(float); }
  }
  public partial class SingleTermEnum : Lucene.Net.Search.FilteredTermEnum {
    public SingleTermEnum(Lucene.Net.Index.IndexReader reader, Lucene.Net.Index.Term singleTerm) { }
    public override float Difference() { return default(float); }
    public override bool EndEnum() { return default(bool); }
    protected internal override bool TermCompare(Lucene.Net.Index.Term term) { return default(bool); }
  }
  public partial class Sort {
    public static readonly Lucene.Net.Search.Sort INDEXORDER;
    public static readonly Lucene.Net.Search.Sort RELEVANCE;
    public Sort() { }
    public Sort(Lucene.Net.Search.SortField field) { }
    public Sort(params Lucene.Net.Search.SortField[] fields) { }
    public override bool Equals(object o) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public virtual Lucene.Net.Search.SortField[] GetSort() { return default(Lucene.Net.Search.SortField[]); }
    public virtual void SetSort(Lucene.Net.Search.SortField field) { }
    public virtual void SetSort(params Lucene.Net.Search.SortField[] fields) { }
    public override string ToString() { return default(string); }
  }
  public partial class SortField {
    public const int BYTE = 10;
    public const int CUSTOM = 9;
    public const int DOC = 1;
    public const int DOUBLE = 7;
    public static readonly Lucene.Net.Search.SortField FIELD_DOC;
    public static readonly Lucene.Net.Search.SortField FIELD_SCORE;
    public const int FLOAT = 5;
    public const int INT = 4;
    public const int LONG = 6;
    public const int SCORE = 0;
    public const int SHORT = 8;
    public const int STRING = 3;
    public const int STRING_VAL = 11;
    public SortField(string field, Lucene.Net.Search.FieldComparatorSource comparator) { }
    public SortField(string field, Lucene.Net.Search.FieldComparatorSource comparator, bool reverse) { }
    public SortField(string field, Lucene.Net.Search.Parser parser) { }
    public SortField(string field, Lucene.Net.Search.Parser parser, bool reverse) { }
    public SortField(string field, System.Globalization.CultureInfo locale) { }
    public SortField(string field, System.Globalization.CultureInfo locale, bool reverse) { }
    public SortField(string field, int type) { }
    public SortField(string field, int type, bool reverse) { }
    public virtual Lucene.Net.Search.FieldComparatorSource ComparatorSource { get { return default(Lucene.Net.Search.FieldComparatorSource); } }
    public virtual string Field { get { return default(string); } }
    public virtual System.Globalization.CultureInfo Locale { get { return default(System.Globalization.CultureInfo); } }
    public virtual Lucene.Net.Search.Parser Parser { get { return default(Lucene.Net.Search.Parser); } }
    public virtual bool Reverse { get { return default(bool); } }
    public virtual int Type { get { return default(int); } }
    public override bool Equals(object o) { return default(bool); }
    public virtual Lucene.Net.Search.FieldComparator GetComparator(int numHits, int sortPos) { return default(Lucene.Net.Search.FieldComparator); }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
  }
  public abstract partial class SpanFilter : Lucene.Net.Search.Filter {
    protected SpanFilter() { }
    public abstract Lucene.Net.Search.SpanFilterResult BitSpans(Lucene.Net.Index.IndexReader reader);
  }
  public partial class SpanFilterResult {
    public SpanFilterResult(Lucene.Net.Search.DocIdSet docIdSet, System.Collections.Generic.IList<Lucene.Net.Search.SpanFilterResult.PositionInfo> positions) { }
    public virtual Lucene.Net.Search.DocIdSet DocIdSet { get { return default(Lucene.Net.Search.DocIdSet); } }
    public virtual System.Collections.Generic.IList<Lucene.Net.Search.SpanFilterResult.PositionInfo> Positions { get { return default(System.Collections.Generic.IList<Lucene.Net.Search.SpanFilterResult.PositionInfo>); } }
    public partial class PositionInfo {
      public PositionInfo(int doc) { }
      public virtual int Doc { get { return default(int); } }
      public virtual System.Collections.Generic.IList<Lucene.Net.Search.SpanFilterResult.StartEnd> Positions { get { return default(System.Collections.Generic.IList<Lucene.Net.Search.SpanFilterResult.StartEnd>); } }
      public virtual void AddPosition(int start, int end) { }
    }
    public partial class StartEnd {
      public StartEnd(int start, int end) { }
      public virtual int End { get { return default(int); } }
      public virtual int Start { get { return default(int); } }
    }
  }
  public partial class SpanQueryFilter : Lucene.Net.Search.SpanFilter {
    protected internal Lucene.Net.Search.Spans.SpanQuery internalQuery;
    protected internal SpanQueryFilter() { }
    public SpanQueryFilter(Lucene.Net.Search.Spans.SpanQuery query) { }
    public virtual Lucene.Net.Search.Spans.SpanQuery Query { get { return default(Lucene.Net.Search.Spans.SpanQuery); } }
    public override Lucene.Net.Search.SpanFilterResult BitSpans(Lucene.Net.Index.IndexReader reader) { return default(Lucene.Net.Search.SpanFilterResult); }
    public override bool Equals(object o) { return default(bool); }
    public override Lucene.Net.Search.DocIdSet GetDocIdSet(Lucene.Net.Index.IndexReader reader) { return default(Lucene.Net.Search.DocIdSet); }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
  }
  public partial class StringIndex {
    public System.String[] lookup;
    public System.Int32[] order;
    public StringIndex(System.Int32[] values, System.String[] lookup) { }
    public virtual int BinarySearchLookup(string key) { return default(int); }
  }
  public partial class TermQuery : Lucene.Net.Search.Query {
    public TermQuery(Lucene.Net.Index.Term t) { }
    public virtual Lucene.Net.Index.Term Term { get { return default(Lucene.Net.Index.Term); } }
    public override Lucene.Net.Search.Weight CreateWeight(Lucene.Net.Search.Searcher searcher) { return default(Lucene.Net.Search.Weight); }
    public override bool Equals(object o) { return default(bool); }
    public override void ExtractTerms(System.Collections.Generic.ISet<Lucene.Net.Index.Term> terms) { }
    public override int GetHashCode() { return default(int); }
    public override string ToString(string field) { return default(string); }
  }
  public partial class TermRangeFilter : Lucene.Net.Search.MultiTermQueryWrapperFilter<Lucene.Net.Search.TermRangeQuery> {
    public TermRangeFilter(string fieldName, string lowerTerm, string upperTerm, bool includeLower, bool includeUpper) : base (default(Lucene.Net.Search.TermRangeQuery)) { }
    public TermRangeFilter(string fieldName, string lowerTerm, string upperTerm, bool includeLower, bool includeUpper, System.Globalization.CompareInfo collator) : base (default(Lucene.Net.Search.TermRangeQuery)) { }
    public virtual System.Globalization.CompareInfo Collator { get { return default(System.Globalization.CompareInfo); } }
    public virtual string Field { get { return default(string); } }
    public virtual bool IncludesLower { get { return default(bool); } }
    public virtual bool IncludesUpper { get { return default(bool); } }
    public virtual string LowerTerm { get { return default(string); } }
    public virtual string UpperTerm { get { return default(string); } }
    public static Lucene.Net.Search.TermRangeFilter Less(string fieldName, string upperTerm) { return default(Lucene.Net.Search.TermRangeFilter); }
    public static Lucene.Net.Search.TermRangeFilter More(string fieldName, string lowerTerm) { return default(Lucene.Net.Search.TermRangeFilter); }
  }
  public partial class TermRangeQuery : Lucene.Net.Search.MultiTermQuery {
    public TermRangeQuery(string field, string lowerTerm, string upperTerm, bool includeLower, bool includeUpper) { }
    public TermRangeQuery(string field, string lowerTerm, string upperTerm, bool includeLower, bool includeUpper, System.Globalization.CompareInfo collator) { }
    public virtual System.Globalization.CompareInfo Collator { get { return default(System.Globalization.CompareInfo); } }
    public virtual string Field { get { return default(string); } }
    public virtual bool IncludesLower { get { return default(bool); } }
    public virtual bool IncludesUpper { get { return default(bool); } }
    public virtual string LowerTerm { get { return default(string); } }
    public virtual string UpperTerm { get { return default(string); } }
    public override bool Equals(object obj) { return default(bool); }
    protected internal override Lucene.Net.Search.FilteredTermEnum GetEnum(Lucene.Net.Index.IndexReader reader) { return default(Lucene.Net.Search.FilteredTermEnum); }
    public override int GetHashCode() { return default(int); }
    public override string ToString(string field) { return default(string); }
  }
  public partial class TermRangeTermEnum : Lucene.Net.Search.FilteredTermEnum {
    public TermRangeTermEnum(Lucene.Net.Index.IndexReader reader, string field, string lowerTermText, string upperTermText, bool includeLower, bool includeUpper, System.Globalization.CompareInfo collator) { }
    public override float Difference() { return default(float); }
    public override bool EndEnum() { return default(bool); }
    protected internal override bool TermCompare(Lucene.Net.Index.Term term) { return default(bool); }
  }
  public sealed partial class TermScorer : Lucene.Net.Search.Scorer {
    public TermScorer(Lucene.Net.Search.Weight weight, Lucene.Net.Index.TermDocs td, Lucene.Net.Search.Similarity similarity, System.Byte[] norms) : base (default(Lucene.Net.Search.Similarity)) { }
    public override int Advance(int target) { return default(int); }
    public override int DocID() { return default(int); }
    public override int NextDoc() { return default(int); }
    public override float Score() { return default(float); }
    public override void Score(Lucene.Net.Search.Collector c) { }
    public override bool Score(Lucene.Net.Search.Collector c, int end, int firstDocID) { return default(bool); }
    public override string ToString() { return default(string); }
  }
  public partial class TimeLimitingCollector : Lucene.Net.Search.Collector {
    public bool DEFAULT_GREEDY;
    public const int DEFAULT_RESOLUTION = 20;
    public TimeLimitingCollector(Lucene.Net.Search.Collector collector, long timeAllowed) { }
    public override bool AcceptsDocsOutOfOrder { get { return default(bool); } }
    public virtual bool IsGreedy { get { return default(bool); } set { } }
    public static long Resolution { get { return default(long); } set { } }
    public override void Collect(int doc) { }
    public override void SetNextReader(Lucene.Net.Index.IndexReader reader, int base_Renamed) { }
    public override void SetScorer(Lucene.Net.Search.Scorer scorer) { }
    public partial class TimeExceededException : System.SystemException {
      internal TimeExceededException() { }
      public virtual int LastDocCollected { get { return default(int); } }
      public virtual long TimeAllowed { get { return default(long); } }
      public virtual long TimeElapsed { get { return default(long); } }
    }
  }
  public partial class TopDocs {
    public TopDocs(int totalHits, Lucene.Net.Search.ScoreDoc[] scoreDocs, float maxScore) { }
    public float MaxScore { get { return default(float); } set { } }
    public Lucene.Net.Search.ScoreDoc[] ScoreDocs { get { return default(Lucene.Net.Search.ScoreDoc[]); } set { } }
    public int TotalHits { get { return default(int); } set { } }
  }
  public abstract partial class TopDocsCollector<T> : Lucene.Net.Search.Collector where T : Lucene.Net.Search.ScoreDoc {
    protected internal static readonly Lucene.Net.Search.TopDocs EMPTY_TOPDOCS;
    protected internal int internalTotalHits;
    protected internal Lucene.Net.Util.PriorityQueue<T> pq;
    protected internal TopDocsCollector(Lucene.Net.Util.PriorityQueue<T> pq) { }
    public virtual int TotalHits { get { return default(int); } }
    public virtual Lucene.Net.Search.TopDocs NewTopDocs(Lucene.Net.Search.ScoreDoc[] results, int start) { return default(Lucene.Net.Search.TopDocs); }
    protected internal virtual void PopulateResults(Lucene.Net.Search.ScoreDoc[] results, int howMany) { }
    public Lucene.Net.Search.TopDocs TopDocs() { return default(Lucene.Net.Search.TopDocs); }
    public Lucene.Net.Search.TopDocs TopDocs(int start) { return default(Lucene.Net.Search.TopDocs); }
    public Lucene.Net.Search.TopDocs TopDocs(int start, int howMany) { return default(Lucene.Net.Search.TopDocs); }
  }
  public abstract partial class TopFieldCollector : Lucene.Net.Search.TopDocsCollector<Lucene.Net.Search.FieldValueHitQueue.Entry> {
    internal TopFieldCollector() : base (default(Lucene.Net.Util.PriorityQueue<Lucene.Net.Search.FieldValueHitQueue.Entry>)) { }
    public override bool AcceptsDocsOutOfOrder { get { return default(bool); } }
    public static Lucene.Net.Search.TopFieldCollector Create(Lucene.Net.Search.Sort sort, int numHits, bool fillFields, bool trackDocScores, bool trackMaxScore, bool docsScoredInOrder) { return default(Lucene.Net.Search.TopFieldCollector); }
    public override Lucene.Net.Search.TopDocs NewTopDocs(Lucene.Net.Search.ScoreDoc[] results, int start) { return default(Lucene.Net.Search.TopDocs); }
    protected internal override void PopulateResults(Lucene.Net.Search.ScoreDoc[] results, int howMany) { }
  }
  public partial class TopFieldDocs : Lucene.Net.Search.TopDocs {
    public Lucene.Net.Search.SortField[] fields;
    public TopFieldDocs(int totalHits, Lucene.Net.Search.ScoreDoc[] scoreDocs, Lucene.Net.Search.SortField[] fields, float maxScore) : base (default(int), default(Lucene.Net.Search.ScoreDoc[]), default(float)) { }
  }
  public abstract partial class TopScoreDocCollector : Lucene.Net.Search.TopDocsCollector<Lucene.Net.Search.ScoreDoc> {
    internal TopScoreDocCollector() : base (default(Lucene.Net.Util.PriorityQueue<Lucene.Net.Search.ScoreDoc>)) { }
    public static Lucene.Net.Search.TopScoreDocCollector Create(int numHits, bool docsScoredInOrder) { return default(Lucene.Net.Search.TopScoreDocCollector); }
    public override Lucene.Net.Search.TopDocs NewTopDocs(Lucene.Net.Search.ScoreDoc[] results, int start) { return default(Lucene.Net.Search.TopDocs); }
    public override void SetNextReader(Lucene.Net.Index.IndexReader reader, int base_Renamed) { }
    public override void SetScorer(Lucene.Net.Search.Scorer scorer) { }
  }
  public abstract partial class Weight {
    protected Weight() { }
    public abstract Lucene.Net.Search.Query Query { get; }
    public abstract float Value { get; }
    public abstract Lucene.Net.Search.Explanation Explain(Lucene.Net.Index.IndexReader reader, int doc);
    public virtual bool GetScoresDocsOutOfOrder() { return default(bool); }
    public abstract float GetSumOfSquaredWeights();
    public abstract void Normalize(float norm);
    public abstract Lucene.Net.Search.Scorer Scorer(Lucene.Net.Index.IndexReader reader, bool scoreDocsInOrder, bool topScorer);
  }
  public partial class WildcardQuery : Lucene.Net.Search.MultiTermQuery {
    protected internal Lucene.Net.Index.Term internalTerm;
    public WildcardQuery(Lucene.Net.Index.Term term) { }
    public Lucene.Net.Index.Term Term { get { return default(Lucene.Net.Index.Term); } }
    public override bool Equals(object obj) { return default(bool); }
    protected internal override Lucene.Net.Search.FilteredTermEnum GetEnum(Lucene.Net.Index.IndexReader reader) { return default(Lucene.Net.Search.FilteredTermEnum); }
    public override int GetHashCode() { return default(int); }
    public override Lucene.Net.Search.Query Rewrite(Lucene.Net.Index.IndexReader reader) { return default(Lucene.Net.Search.Query); }
    public override string ToString(string field) { return default(string); }
  }
  public partial class WildcardTermEnum : Lucene.Net.Search.FilteredTermEnum {
    public const char WILDCARD_CHAR = '?';
    public const char WILDCARD_STRING = '*';
    public WildcardTermEnum(Lucene.Net.Index.IndexReader reader, Lucene.Net.Index.Term term) { }
    public override float Difference() { return default(float); }
    public override bool EndEnum() { return default(bool); }
    protected internal override bool TermCompare(Lucene.Net.Index.Term term) { return default(bool); }
    public static bool WildcardEquals(string pattern, int patternIdx, string string_Renamed, int stringIdx) { return default(bool); }
  }
}
namespace Lucene.Net.Search.Function {
  public partial class ByteFieldSource : Lucene.Net.Search.Function.FieldCacheSource {
    public ByteFieldSource(string field) : base (default(string)) { }
    public ByteFieldSource(string field, Lucene.Net.Search.ByteParser parser) : base (default(string)) { }
    public override bool CachedFieldSourceEquals(Lucene.Net.Search.Function.FieldCacheSource o) { return default(bool); }
    public override int CachedFieldSourceHashCode() { return default(int); }
    public override string Description() { return default(string); }
    public override Lucene.Net.Search.Function.DocValues GetCachedFieldValues(Lucene.Net.Search.FieldCache cache, string field, Lucene.Net.Index.IndexReader reader) { return default(Lucene.Net.Search.Function.DocValues); }
  }
  public partial class CustomScoreProvider {
    protected Lucene.Net.Index.IndexReader reader;
    public CustomScoreProvider(Lucene.Net.Index.IndexReader reader) { }
    public virtual Lucene.Net.Search.Explanation CustomExplain(int doc, Lucene.Net.Search.Explanation subQueryExpl, Lucene.Net.Search.Explanation valSrcExpl) { return default(Lucene.Net.Search.Explanation); }
    public virtual Lucene.Net.Search.Explanation CustomExplain(int doc, Lucene.Net.Search.Explanation subQueryExpl, Lucene.Net.Search.Explanation[] valSrcExpls) { return default(Lucene.Net.Search.Explanation); }
    public virtual float CustomScore(int doc, float subQueryScore, float valSrcScore) { return default(float); }
    public virtual float CustomScore(int doc, float subQueryScore, System.Single[] valSrcScores) { return default(float); }
  }
  public partial class CustomScoreQuery : Lucene.Net.Search.Query, System.ICloneable {
    public CustomScoreQuery(Lucene.Net.Search.Query subQuery) { }
    public CustomScoreQuery(Lucene.Net.Search.Query subQuery, Lucene.Net.Search.Function.ValueSourceQuery valSrcQuery) { }
    public CustomScoreQuery(Lucene.Net.Search.Query subQuery, params Lucene.Net.Search.Function.ValueSourceQuery[] valSrcQueries) { }
    public override object Clone() { return default(object); }
    public override Lucene.Net.Search.Weight CreateWeight(Lucene.Net.Search.Searcher searcher) { return default(Lucene.Net.Search.Weight); }
    [System.ObsoleteAttribute("Will be removed in Lucene 3.1")]
    public virtual Lucene.Net.Search.Explanation CustomExplain(int doc, Lucene.Net.Search.Explanation subQueryExpl, Lucene.Net.Search.Explanation valSrcExpl) { return default(Lucene.Net.Search.Explanation); }
    [System.ObsoleteAttribute("Will be removed in Lucene 3.1")]
    public virtual Lucene.Net.Search.Explanation CustomExplain(int doc, Lucene.Net.Search.Explanation subQueryExpl, Lucene.Net.Search.Explanation[] valSrcExpls) { return default(Lucene.Net.Search.Explanation); }
    [System.ObsoleteAttribute("Will be removed in Lucene 3.1")]
    public virtual float CustomScore(int doc, float subQueryScore, float valSrcScore) { return default(float); }
    [System.ObsoleteAttribute("Will be removed in Lucene 3.1")]
    public virtual float CustomScore(int doc, float subQueryScore, System.Single[] valSrcScores) { return default(float); }
    public override bool Equals(object o) { return default(bool); }
    public override void ExtractTerms(System.Collections.Generic.ISet<Lucene.Net.Index.Term> terms) { }
    protected virtual Lucene.Net.Search.Function.CustomScoreProvider GetCustomScoreProvider(Lucene.Net.Index.IndexReader reader) { return default(Lucene.Net.Search.Function.CustomScoreProvider); }
    public override int GetHashCode() { return default(int); }
    public virtual bool IsStrict() { return default(bool); }
    public virtual string Name() { return default(string); }
    public override Lucene.Net.Search.Query Rewrite(Lucene.Net.Index.IndexReader reader) { return default(Lucene.Net.Search.Query); }
    public virtual void SetStrict(bool strict) { }
    public override string ToString(string field) { return default(string); }
  }
  public abstract partial class DocValues {
    protected DocValues() { }
    protected internal virtual object InnerArray { get { return default(object); } }
    public virtual double DoubleVal(int doc) { return default(double); }
    public virtual Lucene.Net.Search.Explanation Explain(int doc) { return default(Lucene.Net.Search.Explanation); }
    public abstract float FloatVal(int doc);
    public virtual float GetAverageValue() { return default(float); }
    public virtual float GetMaxValue() { return default(float); }
    public virtual float GetMinValue() { return default(float); }
    public virtual int IntVal(int doc) { return default(int); }
    public virtual long LongVal(int doc) { return default(long); }
    public virtual string StrVal(int doc) { return default(string); }
    public abstract string ToString(int doc);
  }
  public abstract partial class FieldCacheSource : Lucene.Net.Search.Function.ValueSource {
    protected FieldCacheSource(string field) { }
    public abstract bool CachedFieldSourceEquals(Lucene.Net.Search.Function.FieldCacheSource other);
    public abstract int CachedFieldSourceHashCode();
    public override string Description() { return default(string); }
    public override bool Equals(object o) { return default(bool); }
    public abstract Lucene.Net.Search.Function.DocValues GetCachedFieldValues(Lucene.Net.Search.FieldCache cache, string field, Lucene.Net.Index.IndexReader reader);
    public override int GetHashCode() { return default(int); }
    public override Lucene.Net.Search.Function.DocValues GetValues(Lucene.Net.Index.IndexReader reader) { return default(Lucene.Net.Search.Function.DocValues); }
  }
  public partial class FieldScoreQuery : Lucene.Net.Search.Function.ValueSourceQuery {
    public FieldScoreQuery(string field, Lucene.Net.Search.Function.FieldScoreQuery.Type type) : base (default(Lucene.Net.Search.Function.ValueSource)) { }
    public partial class Type {
      internal Type() { }
      public static readonly Lucene.Net.Search.Function.FieldScoreQuery.Type BYTE;
      public static readonly Lucene.Net.Search.Function.FieldScoreQuery.Type FLOAT;
      public static readonly Lucene.Net.Search.Function.FieldScoreQuery.Type INT;
      public static readonly Lucene.Net.Search.Function.FieldScoreQuery.Type SHORT;
      public override string ToString() { return default(string); }
    }
  }
  public partial class FloatFieldSource : Lucene.Net.Search.Function.FieldCacheSource {
    public FloatFieldSource(string field) : base (default(string)) { }
    public FloatFieldSource(string field, Lucene.Net.Search.FloatParser parser) : base (default(string)) { }
    public override bool CachedFieldSourceEquals(Lucene.Net.Search.Function.FieldCacheSource o) { return default(bool); }
    public override int CachedFieldSourceHashCode() { return default(int); }
    public override string Description() { return default(string); }
    public override Lucene.Net.Search.Function.DocValues GetCachedFieldValues(Lucene.Net.Search.FieldCache cache, string field, Lucene.Net.Index.IndexReader reader) { return default(Lucene.Net.Search.Function.DocValues); }
  }
  public partial class IntFieldSource : Lucene.Net.Search.Function.FieldCacheSource {
    public IntFieldSource(string field) : base (default(string)) { }
    public IntFieldSource(string field, Lucene.Net.Search.IntParser parser) : base (default(string)) { }
    public override bool CachedFieldSourceEquals(Lucene.Net.Search.Function.FieldCacheSource o) { return default(bool); }
    public override int CachedFieldSourceHashCode() { return default(int); }
    public override string Description() { return default(string); }
    public override Lucene.Net.Search.Function.DocValues GetCachedFieldValues(Lucene.Net.Search.FieldCache cache, string field, Lucene.Net.Index.IndexReader reader) { return default(Lucene.Net.Search.Function.DocValues); }
  }
  public partial class OrdFieldSource : Lucene.Net.Search.Function.ValueSource {
    protected internal string field;
    public OrdFieldSource(string field) { }
    public override string Description() { return default(string); }
    public override bool Equals(object o) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override Lucene.Net.Search.Function.DocValues GetValues(Lucene.Net.Index.IndexReader reader) { return default(Lucene.Net.Search.Function.DocValues); }
  }
  public partial class ReverseOrdFieldSource : Lucene.Net.Search.Function.ValueSource {
    public string field;
    public ReverseOrdFieldSource(string field) { }
    public override string Description() { return default(string); }
    public override bool Equals(object o) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override Lucene.Net.Search.Function.DocValues GetValues(Lucene.Net.Index.IndexReader reader) { return default(Lucene.Net.Search.Function.DocValues); }
  }
  public partial class ShortFieldSource : Lucene.Net.Search.Function.FieldCacheSource {
    public ShortFieldSource(string field) : base (default(string)) { }
    public ShortFieldSource(string field, Lucene.Net.Search.ShortParser parser) : base (default(string)) { }
    public override bool CachedFieldSourceEquals(Lucene.Net.Search.Function.FieldCacheSource o) { return default(bool); }
    public override int CachedFieldSourceHashCode() { return default(int); }
    public override string Description() { return default(string); }
    public override Lucene.Net.Search.Function.DocValues GetCachedFieldValues(Lucene.Net.Search.FieldCache cache, string field, Lucene.Net.Index.IndexReader reader) { return default(Lucene.Net.Search.Function.DocValues); }
  }
  public abstract partial class ValueSource {
    protected ValueSource() { }
    public abstract string Description();
    public abstract override bool Equals(object o);
    public abstract override int GetHashCode();
    public abstract Lucene.Net.Search.Function.DocValues GetValues(Lucene.Net.Index.IndexReader reader);
    public override string ToString() { return default(string); }
  }
  public partial class ValueSourceQuery : Lucene.Net.Search.Query {
    public ValueSourceQuery(Lucene.Net.Search.Function.ValueSource valSrc) { }
    public override object Clone() { return default(object); }
    public override Lucene.Net.Search.Weight CreateWeight(Lucene.Net.Search.Searcher searcher) { return default(Lucene.Net.Search.Weight); }
    public override bool Equals(object o) { return default(bool); }
    public override void ExtractTerms(System.Collections.Generic.ISet<Lucene.Net.Index.Term> terms) { }
    public override int GetHashCode() { return default(int); }
    public override Lucene.Net.Search.Query Rewrite(Lucene.Net.Index.IndexReader reader) { return default(Lucene.Net.Search.Query); }
    public override string ToString(string field) { return default(string); }
  }
}
namespace Lucene.Net.Search.Payloads {
  public partial class AveragePayloadFunction : Lucene.Net.Search.Payloads.PayloadFunction {
    public AveragePayloadFunction() { }
    public override float CurrentScore(int docId, string field, int start, int end, int numPayloadsSeen, float currentScore, float currentPayloadScore) { return default(float); }
    public override float DocScore(int docId, string field, int numPayloadsSeen, float payloadScore) { return default(float); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }
  public partial class MaxPayloadFunction : Lucene.Net.Search.Payloads.PayloadFunction {
    public MaxPayloadFunction() { }
    public override float CurrentScore(int docId, string field, int start, int end, int numPayloadsSeen, float currentScore, float currentPayloadScore) { return default(float); }
    public override float DocScore(int docId, string field, int numPayloadsSeen, float payloadScore) { return default(float); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }
  public partial class MinPayloadFunction : Lucene.Net.Search.Payloads.PayloadFunction {
    public MinPayloadFunction() { }
    public override float CurrentScore(int docId, string field, int start, int end, int numPayloadsSeen, float currentScore, float currentPayloadScore) { return default(float); }
    public override float DocScore(int docId, string field, int numPayloadsSeen, float payloadScore) { return default(float); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }
  public abstract partial class PayloadFunction {
    protected PayloadFunction() { }
    public abstract float CurrentScore(int docId, string field, int start, int end, int numPayloadsSeen, float currentScore, float currentPayloadScore);
    public abstract float DocScore(int docId, string field, int numPayloadsSeen, float payloadScore);
    public abstract override bool Equals(object o);
    public abstract override int GetHashCode();
  }
  public partial class PayloadNearQuery : Lucene.Net.Search.Spans.SpanNearQuery, System.ICloneable {
    protected internal string fieldName;
    protected internal Lucene.Net.Search.Payloads.PayloadFunction function;
    public PayloadNearQuery(Lucene.Net.Search.Spans.SpanQuery[] clauses, int slop, bool inOrder) : base (default(Lucene.Net.Search.Spans.SpanQuery[]), default(int), default(bool)) { }
    public PayloadNearQuery(Lucene.Net.Search.Spans.SpanQuery[] clauses, int slop, bool inOrder, Lucene.Net.Search.Payloads.PayloadFunction function) : base (default(Lucene.Net.Search.Spans.SpanQuery[]), default(int), default(bool)) { }
    public override object Clone() { return default(object); }
    public override Lucene.Net.Search.Weight CreateWeight(Lucene.Net.Search.Searcher searcher) { return default(Lucene.Net.Search.Weight); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override string ToString(string field) { return default(string); }
    public partial class PayloadNearSpanScorer : Lucene.Net.Search.Spans.SpanScorer {
      protected internal float payloadScore;
      protected internal PayloadNearSpanScorer(Lucene.Net.Search.Payloads.PayloadNearQuery enclosingInstance, Lucene.Net.Search.Spans.Spans spans, Lucene.Net.Search.Weight weight, Lucene.Net.Search.Similarity similarity, System.Byte[] norms) : base (default(Lucene.Net.Search.Spans.Spans), default(Lucene.Net.Search.Weight), default(Lucene.Net.Search.Similarity), default(System.Byte[])) { }
      public Lucene.Net.Search.Payloads.PayloadNearQuery Enclosing_Instance { get { return default(Lucene.Net.Search.Payloads.PayloadNearQuery); } }
      protected internal override Lucene.Net.Search.Explanation Explain(int doc) { return default(Lucene.Net.Search.Explanation); }
      public virtual void GetPayloads(Lucene.Net.Search.Spans.Spans[] subSpans) { }
      protected internal virtual void ProcessPayloads(System.Collections.Generic.ICollection<System.Byte[]> payLoads, int start, int end) { }
      public override float Score() { return default(float); }
      public override bool SetFreqCurrentDoc() { return default(bool); }
    }
    public partial class PayloadNearSpanWeight : Lucene.Net.Search.Spans.SpanWeight {
      public PayloadNearSpanWeight(Lucene.Net.Search.Payloads.PayloadNearQuery enclosingInstance, Lucene.Net.Search.Spans.SpanQuery query, Lucene.Net.Search.Searcher searcher) : base (default(Lucene.Net.Search.Spans.SpanQuery), default(Lucene.Net.Search.Searcher)) { }
      public Lucene.Net.Search.Payloads.PayloadNearQuery Enclosing_Instance { get { return default(Lucene.Net.Search.Payloads.PayloadNearQuery); } }
      public override Lucene.Net.Search.Scorer Scorer(Lucene.Net.Index.IndexReader reader, bool scoreDocsInOrder, bool topScorer) { return default(Lucene.Net.Search.Scorer); }
    }
  }
  public partial class PayloadSpanUtil {
    public PayloadSpanUtil(Lucene.Net.Index.IndexReader reader) { }
    public virtual System.Collections.Generic.ICollection<System.Byte[]> GetPayloadsForQuery(Lucene.Net.Search.Query query) { return default(System.Collections.Generic.ICollection<System.Byte[]>); }
  }
  public partial class PayloadTermQuery : Lucene.Net.Search.Spans.SpanTermQuery {
    protected internal Lucene.Net.Search.Payloads.PayloadFunction function;
    public PayloadTermQuery(Lucene.Net.Index.Term term, Lucene.Net.Search.Payloads.PayloadFunction function) : base (default(Lucene.Net.Index.Term)) { }
    public PayloadTermQuery(Lucene.Net.Index.Term term, Lucene.Net.Search.Payloads.PayloadFunction function, bool includeSpanScore) : base (default(Lucene.Net.Index.Term)) { }
    public override Lucene.Net.Search.Weight CreateWeight(Lucene.Net.Search.Searcher searcher) { return default(Lucene.Net.Search.Weight); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    protected internal partial class PayloadTermWeight : Lucene.Net.Search.Spans.SpanWeight {
      public PayloadTermWeight(Lucene.Net.Search.Payloads.PayloadTermQuery enclosingInstance, Lucene.Net.Search.Payloads.PayloadTermQuery query, Lucene.Net.Search.Searcher searcher) : base (default(Lucene.Net.Search.Spans.SpanQuery), default(Lucene.Net.Search.Searcher)) { }
      public Lucene.Net.Search.Payloads.PayloadTermQuery Enclosing_Instance { get { return default(Lucene.Net.Search.Payloads.PayloadTermQuery); } }
      public override Lucene.Net.Search.Scorer Scorer(Lucene.Net.Index.IndexReader reader, bool scoreDocsInOrder, bool topScorer) { return default(Lucene.Net.Search.Scorer); }
      protected internal partial class PayloadTermSpanScorer : Lucene.Net.Search.Spans.SpanScorer {
        protected internal System.Byte[] payload;
        protected internal float payloadScore;
        protected internal int payloadsSeen;
        protected internal Lucene.Net.Index.TermPositions positions;
        public PayloadTermSpanScorer(Lucene.Net.Search.Payloads.PayloadTermQuery.PayloadTermWeight enclosingInstance, Lucene.Net.Search.Spans.TermSpans spans, Lucene.Net.Search.Weight weight, Lucene.Net.Search.Similarity similarity, System.Byte[] norms) : base (default(Lucene.Net.Search.Spans.Spans), default(Lucene.Net.Search.Weight), default(Lucene.Net.Search.Similarity), default(System.Byte[])) { }
        public Lucene.Net.Search.Payloads.PayloadTermQuery.PayloadTermWeight Enclosing_Instance { get { return default(Lucene.Net.Search.Payloads.PayloadTermQuery.PayloadTermWeight); } }
        protected internal override Lucene.Net.Search.Explanation Explain(int doc) { return default(Lucene.Net.Search.Explanation); }
        protected internal virtual float GetPayloadScore() { return default(float); }
        protected internal virtual float GetSpanScore() { return default(float); }
        protected internal virtual void ProcessPayload(Lucene.Net.Search.Similarity similarity) { }
        public override float Score() { return default(float); }
        public override bool SetFreqCurrentDoc() { return default(bool); }
      }
    }
  }
}
namespace Lucene.Net.Search.Spans {
  public partial class FieldMaskingSpanQuery : Lucene.Net.Search.Spans.SpanQuery {
    public FieldMaskingSpanQuery(Lucene.Net.Search.Spans.SpanQuery maskedQuery, string maskedField) { }
    public override string Field { get { return default(string); } }
    public virtual Lucene.Net.Search.Spans.SpanQuery MaskedQuery { get { return default(Lucene.Net.Search.Spans.SpanQuery); } }
    public override Lucene.Net.Search.Weight CreateWeight(Lucene.Net.Search.Searcher searcher) { return default(Lucene.Net.Search.Weight); }
    public override bool Equals(object o) { return default(bool); }
    public override void ExtractTerms(System.Collections.Generic.ISet<Lucene.Net.Index.Term> terms) { }
    public override int GetHashCode() { return default(int); }
    public override Lucene.Net.Search.Similarity GetSimilarity(Lucene.Net.Search.Searcher searcher) { return default(Lucene.Net.Search.Similarity); }
    public override Lucene.Net.Search.Spans.Spans GetSpans(Lucene.Net.Index.IndexReader reader) { return default(Lucene.Net.Search.Spans.Spans); }
    public override Lucene.Net.Search.Query Rewrite(Lucene.Net.Index.IndexReader reader) { return default(Lucene.Net.Search.Query); }
    public override string ToString(string field) { return default(string); }
  }
  public partial class NearSpansOrdered : Lucene.Net.Search.Spans.Spans {
    public NearSpansOrdered(Lucene.Net.Search.Spans.SpanNearQuery spanNearQuery, Lucene.Net.Index.IndexReader reader) { }
    public NearSpansOrdered(Lucene.Net.Search.Spans.SpanNearQuery spanNearQuery, Lucene.Net.Index.IndexReader reader, bool collectPayloads) { }
    public override int Doc() { return default(int); }
    public override int End() { return default(int); }
    public override System.Collections.Generic.ICollection<System.Byte[]> GetPayload() { return default(System.Collections.Generic.ICollection<System.Byte[]>); }
    public virtual Lucene.Net.Search.Spans.Spans[] GetSubSpans() { return default(Lucene.Net.Search.Spans.Spans[]); }
    public override bool IsPayloadAvailable() { return default(bool); }
    public override bool Next() { return default(bool); }
    public override bool SkipTo(int target) { return default(bool); }
    public override int Start() { return default(int); }
    public override string ToString() { return default(string); }
  }
  public partial class NearSpansUnordered : Lucene.Net.Search.Spans.Spans {
    public NearSpansUnordered(Lucene.Net.Search.Spans.SpanNearQuery query, Lucene.Net.Index.IndexReader reader) { }
    public override int Doc() { return default(int); }
    public override int End() { return default(int); }
    public override System.Collections.Generic.ICollection<System.Byte[]> GetPayload() { return default(System.Collections.Generic.ICollection<System.Byte[]>); }
    public virtual Lucene.Net.Search.Spans.Spans[] GetSubSpans() { return default(Lucene.Net.Search.Spans.Spans[]); }
    public override bool IsPayloadAvailable() { return default(bool); }
    public override bool Next() { return default(bool); }
    public override bool SkipTo(int target) { return default(bool); }
    public override int Start() { return default(int); }
    public override string ToString() { return default(string); }
  }
  public partial class SpanFirstQuery : Lucene.Net.Search.Spans.SpanQuery, System.ICloneable {
    public SpanFirstQuery(Lucene.Net.Search.Spans.SpanQuery match, int end) { }
    public virtual int End { get { return default(int); } }
    public override string Field { get { return default(string); } }
    public virtual Lucene.Net.Search.Spans.SpanQuery Match { get { return default(Lucene.Net.Search.Spans.SpanQuery); } }
    public override object Clone() { return default(object); }
    public override bool Equals(object o) { return default(bool); }
    public override void ExtractTerms(System.Collections.Generic.ISet<Lucene.Net.Index.Term> terms) { }
    public override int GetHashCode() { return default(int); }
    public override Lucene.Net.Search.Spans.Spans GetSpans(Lucene.Net.Index.IndexReader reader) { return default(Lucene.Net.Search.Spans.Spans); }
    public override Lucene.Net.Search.Query Rewrite(Lucene.Net.Index.IndexReader reader) { return default(Lucene.Net.Search.Query); }
    public override string ToString(string field) { return default(string); }
  }
  public partial class SpanNearQuery : Lucene.Net.Search.Spans.SpanQuery, System.ICloneable {
    protected internal System.Collections.Generic.IList<Lucene.Net.Search.Spans.SpanQuery> clauses;
    protected internal bool inOrder;
    protected internal string internalField;
    protected internal int internalSlop;
    public SpanNearQuery(Lucene.Net.Search.Spans.SpanQuery[] clauses, int slop, bool inOrder) { }
    public SpanNearQuery(Lucene.Net.Search.Spans.SpanQuery[] clauses, int slop, bool inOrder, bool collectPayloads) { }
    public override string Field { get { return default(string); } }
    public virtual bool IsInOrder { get { return default(bool); } }
    public virtual int Slop { get { return default(int); } }
    public override object Clone() { return default(object); }
    public override bool Equals(object o) { return default(bool); }
    public override void ExtractTerms(System.Collections.Generic.ISet<Lucene.Net.Index.Term> terms) { }
    public virtual Lucene.Net.Search.Spans.SpanQuery[] GetClauses() { return default(Lucene.Net.Search.Spans.SpanQuery[]); }
    public override int GetHashCode() { return default(int); }
    public override Lucene.Net.Search.Spans.Spans GetSpans(Lucene.Net.Index.IndexReader reader) { return default(Lucene.Net.Search.Spans.Spans); }
    public override Lucene.Net.Search.Query Rewrite(Lucene.Net.Index.IndexReader reader) { return default(Lucene.Net.Search.Query); }
    public override string ToString(string field) { return default(string); }
  }
  public partial class SpanNotQuery : Lucene.Net.Search.Spans.SpanQuery, System.ICloneable {
    public SpanNotQuery(Lucene.Net.Search.Spans.SpanQuery include, Lucene.Net.Search.Spans.SpanQuery exclude) { }
    public virtual Lucene.Net.Search.Spans.SpanQuery Exclude { get { return default(Lucene.Net.Search.Spans.SpanQuery); } }
    public override string Field { get { return default(string); } }
    public virtual Lucene.Net.Search.Spans.SpanQuery Include { get { return default(Lucene.Net.Search.Spans.SpanQuery); } }
    public override object Clone() { return default(object); }
    public override bool Equals(object o) { return default(bool); }
    public override void ExtractTerms(System.Collections.Generic.ISet<Lucene.Net.Index.Term> terms) { }
    public override int GetHashCode() { return default(int); }
    public override Lucene.Net.Search.Spans.Spans GetSpans(Lucene.Net.Index.IndexReader reader) { return default(Lucene.Net.Search.Spans.Spans); }
    public override Lucene.Net.Search.Query Rewrite(Lucene.Net.Index.IndexReader reader) { return default(Lucene.Net.Search.Query); }
    public override string ToString(string field) { return default(string); }
  }
  public partial class SpanOrQuery : Lucene.Net.Search.Spans.SpanQuery, System.ICloneable {
    public SpanOrQuery(params Lucene.Net.Search.Spans.SpanQuery[] clauses) { }
    public override string Field { get { return default(string); } }
    public override object Clone() { return default(object); }
    public override bool Equals(object o) { return default(bool); }
    public override void ExtractTerms(System.Collections.Generic.ISet<Lucene.Net.Index.Term> terms) { }
    public virtual Lucene.Net.Search.Spans.SpanQuery[] GetClauses() { return default(Lucene.Net.Search.Spans.SpanQuery[]); }
    public override int GetHashCode() { return default(int); }
    public override Lucene.Net.Search.Spans.Spans GetSpans(Lucene.Net.Index.IndexReader reader) { return default(Lucene.Net.Search.Spans.Spans); }
    public override Lucene.Net.Search.Query Rewrite(Lucene.Net.Index.IndexReader reader) { return default(Lucene.Net.Search.Query); }
    public override string ToString(string field) { return default(string); }
  }
  public abstract partial class SpanQuery : Lucene.Net.Search.Query {
    protected SpanQuery() { }
    public abstract string Field { get; }
    public override Lucene.Net.Search.Weight CreateWeight(Lucene.Net.Search.Searcher searcher) { return default(Lucene.Net.Search.Weight); }
    public abstract Lucene.Net.Search.Spans.Spans GetSpans(Lucene.Net.Index.IndexReader reader);
  }
  public abstract partial class Spans {
    protected Spans() { }
    public abstract int Doc();
    public abstract int End();
    public abstract System.Collections.Generic.ICollection<System.Byte[]> GetPayload();
    public abstract bool IsPayloadAvailable();
    public abstract bool Next();
    public abstract bool SkipTo(int target);
    public abstract int Start();
  }
  public partial class SpanScorer : Lucene.Net.Search.Scorer {
    protected internal int doc;
    protected internal float freq;
    protected internal bool more;
    protected internal System.Byte[] norms;
    protected internal Lucene.Net.Search.Spans.Spans spans;
    protected internal float value_Renamed;
    protected internal Lucene.Net.Search.Weight weight;
    protected internal SpanScorer(Lucene.Net.Search.Spans.Spans spans, Lucene.Net.Search.Weight weight, Lucene.Net.Search.Similarity similarity, System.Byte[] norms) : base (default(Lucene.Net.Search.Similarity)) { }
    public override int Advance(int target) { return default(int); }
    public override int DocID() { return default(int); }
    protected internal virtual Lucene.Net.Search.Explanation Explain(int doc) { return default(Lucene.Net.Search.Explanation); }
    public override int NextDoc() { return default(int); }
    public override float Score() { return default(float); }
    public virtual bool SetFreqCurrentDoc() { return default(bool); }
  }
  public partial class SpanTermQuery : Lucene.Net.Search.Spans.SpanQuery {
    protected internal Lucene.Net.Index.Term internalTerm;
    public SpanTermQuery(Lucene.Net.Index.Term term) { }
    public override string Field { get { return default(string); } }
    public virtual Lucene.Net.Index.Term Term { get { return default(Lucene.Net.Index.Term); } }
    public override bool Equals(object obj) { return default(bool); }
    public override void ExtractTerms(System.Collections.Generic.ISet<Lucene.Net.Index.Term> terms) { }
    public override int GetHashCode() { return default(int); }
    public override Lucene.Net.Search.Spans.Spans GetSpans(Lucene.Net.Index.IndexReader reader) { return default(Lucene.Net.Search.Spans.Spans); }
    public override string ToString(string field) { return default(string); }
  }
  public partial class SpanWeight : Lucene.Net.Search.Weight {
    protected internal float idf;
    protected internal Lucene.Net.Search.Spans.SpanQuery internalQuery;
    protected internal float queryNorm;
    protected internal float queryWeight;
    protected internal Lucene.Net.Search.Similarity similarity;
    protected internal System.Collections.Generic.ISet<Lucene.Net.Index.Term> terms;
    protected internal float value_Renamed;
    public SpanWeight(Lucene.Net.Search.Spans.SpanQuery query, Lucene.Net.Search.Searcher searcher) { }
    public override Lucene.Net.Search.Query Query { get { return default(Lucene.Net.Search.Query); } }
    public override float Value { get { return default(float); } }
    public override Lucene.Net.Search.Explanation Explain(Lucene.Net.Index.IndexReader reader, int doc) { return default(Lucene.Net.Search.Explanation); }
    public override float GetSumOfSquaredWeights() { return default(float); }
    public override void Normalize(float queryNorm) { }
    public override Lucene.Net.Search.Scorer Scorer(Lucene.Net.Index.IndexReader reader, bool scoreDocsInOrder, bool topScorer) { return default(Lucene.Net.Search.Scorer); }
  }
  public partial class TermSpans : Lucene.Net.Search.Spans.Spans {
    protected internal int count;
    protected internal int freq;
    protected internal int internalDoc;
    protected internal Lucene.Net.Index.TermPositions internalPositions;
    protected internal int position;
    protected internal Lucene.Net.Index.Term term;
    public TermSpans(Lucene.Net.Index.TermPositions positions, Lucene.Net.Index.Term term) { }
    public virtual Lucene.Net.Index.TermPositions Positions { get { return default(Lucene.Net.Index.TermPositions); } }
    public override int Doc() { return default(int); }
    public override int End() { return default(int); }
    public override System.Collections.Generic.ICollection<System.Byte[]> GetPayload() { return default(System.Collections.Generic.ICollection<System.Byte[]>); }
    public override bool IsPayloadAvailable() { return default(bool); }
    public override bool Next() { return default(bool); }
    public override bool SkipTo(int target) { return default(bool); }
    public override int Start() { return default(int); }
    public override string ToString() { return default(string); }
  }
}
namespace Lucene.Net.Store {
  public partial class AlreadyClosedException : System.SystemException {
    public AlreadyClosedException() { }
    protected AlreadyClosedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public AlreadyClosedException(string message) { }
    public AlreadyClosedException(string message, System.Exception inner) { }
  }
  public abstract partial class BufferedIndexInput : Lucene.Net.Store.IndexInput, System.ICloneable {
    protected internal System.Byte[] buffer;
    public const int BUFFER_SIZE = 1024;
    protected BufferedIndexInput() { }
    protected BufferedIndexInput(int bufferSize) { }
    public virtual int BufferSize { get { return default(int); } }
    public override long FilePointer { get { return default(long); } }
    public override object Clone() { return default(object); }
    protected internal virtual void NewBuffer(System.Byte[] newBuffer) { }
    public override byte ReadByte() { return default(byte); }
    public override void ReadBytes(System.Byte[] b, int offset, int len) { }
    public override void ReadBytes(System.Byte[] b, int offset, int len, bool useBuffer) { }
    public abstract void ReadInternal(System.Byte[] b, int offset, int length);
    public override void Seek(long pos) { }
    public abstract void SeekInternal(long pos);
    public virtual void SetBufferSize(int newSize) { }
  }
  public abstract partial class BufferedIndexOutput : Lucene.Net.Store.IndexOutput {
    protected BufferedIndexOutput() { }
    public override long FilePointer { get { return default(long); } }
    public abstract override long Length { get; }
    protected override void Dispose(bool disposing) { }
    public override void Flush() { }
    public abstract void FlushBuffer(System.Byte[] b, int offset, int len);
    public override void Seek(long pos) { }
    public override void WriteByte(byte b) { }
    public override void WriteBytes(System.Byte[] b, int offset, int length) { }
  }
  public partial class ChecksumIndexInput : Lucene.Net.Store.IndexInput {
    public ChecksumIndexInput(Lucene.Net.Store.IndexInput main) { }
    public virtual long Checksum { get { return default(long); } }
    public override long FilePointer { get { return default(long); } }
    protected override void Dispose(bool disposing) { }
    public override long Length() { return default(long); }
    public override byte ReadByte() { return default(byte); }
    public override void ReadBytes(System.Byte[] b, int offset, int len) { }
    public override void Seek(long pos) { }
  }
  public partial class ChecksumIndexOutput : Lucene.Net.Store.IndexOutput {
    public ChecksumIndexOutput(Lucene.Net.Store.IndexOutput main) { }
    public virtual long Checksum { get { return default(long); } }
    public override long FilePointer { get { return default(long); } }
    public override long Length { get { return default(long); } }
    protected override void Dispose(bool disposing) { }
    public virtual void FinishCommit() { }
    public override void Flush() { }
    public virtual void PrepareCommit() { }
    public override void Seek(long pos) { }
    public override void WriteByte(byte b) { }
    public override void WriteBytes(System.Byte[] b, int offset, int length) { }
  }
  public abstract partial class Directory : System.IDisposable {
    protected internal Lucene.Net.Store.LockFactory interalLockFactory;
    protected internal bool isOpen;
    protected Directory() { }
    public bool isOpen_ForNUnit { get { return default(bool); } }
    public virtual Lucene.Net.Store.LockFactory LockFactory { get { return default(Lucene.Net.Store.LockFactory); } }
    public virtual void ClearLock(string name) { }
    [System.ObsoleteAttribute("Use Dispose() instead")]
    public void Close() { }
    public static void Copy(Lucene.Net.Store.Directory src, Lucene.Net.Store.Directory dest, bool closeDirSrc) { }
    public abstract Lucene.Net.Store.IndexOutput CreateOutput(string name);
    public abstract void DeleteFile(string name);
    public void Dispose() { }
    protected abstract void Dispose(bool disposing);
    public void EnsureOpen() { }
    public abstract bool FileExists(string name);
    public abstract long FileLength(string name);
    public abstract long FileModified(string name);
    public virtual string GetLockId() { return default(string); }
    public abstract System.String[] ListAll();
    public virtual Lucene.Net.Store.Lock MakeLock(string name) { return default(Lucene.Net.Store.Lock); }
    public abstract Lucene.Net.Store.IndexInput OpenInput(string name);
    public virtual Lucene.Net.Store.IndexInput OpenInput(string name, int bufferSize) { return default(Lucene.Net.Store.IndexInput); }
    public virtual void SetLockFactory(Lucene.Net.Store.LockFactory lockFactory) { }
    public virtual void Sync(string name) { }
    public override string ToString() { return default(string); }
    public abstract void TouchFile(string name);
  }
  public partial class FileSwitchDirectory : Lucene.Net.Store.Directory {
    public FileSwitchDirectory(System.Collections.Generic.HashSet<System.String> primaryExtensions, Lucene.Net.Store.Directory primaryDir, Lucene.Net.Store.Directory secondaryDir, bool doClose) { }
    public virtual Lucene.Net.Store.Directory PrimaryDir { get { return default(Lucene.Net.Store.Directory); } }
    public virtual Lucene.Net.Store.Directory SecondaryDir { get { return default(Lucene.Net.Store.Directory); } }
    public override Lucene.Net.Store.IndexOutput CreateOutput(string name) { return default(Lucene.Net.Store.IndexOutput); }
    public override void DeleteFile(string name) { }
    protected override void Dispose(bool disposing) { }
    public override bool FileExists(string name) { return default(bool); }
    public override long FileLength(string name) { return default(long); }
    public override long FileModified(string name) { return default(long); }
    public static string GetExtension(string name) { return default(string); }
    public override System.String[] ListAll() { return default(System.String[]); }
    public override Lucene.Net.Store.IndexInput OpenInput(string name) { return default(Lucene.Net.Store.IndexInput); }
    public override void Sync(string name) { }
    public override void TouchFile(string name) { }
  }
  public abstract partial class FSDirectory : Lucene.Net.Store.Directory {
    public static readonly int DEFAULT_READ_CHUNK_SIZE;
    protected internal System.IO.DirectoryInfo internalDirectory;
    protected internal FSDirectory(System.IO.DirectoryInfo path, Lucene.Net.Store.LockFactory lockFactory) { }
    public virtual System.IO.DirectoryInfo Directory { get { return default(System.IO.DirectoryInfo); } }
    public int ReadChunkSize { get { return default(int); } set { } }
    public override void DeleteFile(string name) { }
    protected override void Dispose(bool disposing) { }
    public override bool FileExists(string name) { return default(bool); }
    public override long FileLength(string name) { return default(long); }
    public static long FileModified(System.IO.FileInfo directory, string name) { return default(long); }
    public override long FileModified(string name) { return default(long); }
    public override string GetLockId() { return default(string); }
    protected internal void InitOutput(string name) { }
    public override System.String[] ListAll() { return default(System.String[]); }
    public static System.String[] ListAll(System.IO.DirectoryInfo dir) { return default(System.String[]); }
    public static Lucene.Net.Store.FSDirectory Open(System.IO.DirectoryInfo path) { return default(Lucene.Net.Store.FSDirectory); }
    public static Lucene.Net.Store.FSDirectory Open(System.IO.DirectoryInfo path, Lucene.Net.Store.LockFactory lockFactory) { return default(Lucene.Net.Store.FSDirectory); }
    public static Lucene.Net.Store.FSDirectory Open(string path) { return default(Lucene.Net.Store.FSDirectory); }
    public override Lucene.Net.Store.IndexInput OpenInput(string name) { return default(Lucene.Net.Store.IndexInput); }
    public override void Sync(string name) { }
    public override string ToString() { return default(string); }
    public override void TouchFile(string name) { }
  }
  public abstract partial class FSLockFactory : Lucene.Net.Store.LockFactory {
    protected internal System.IO.DirectoryInfo internalLockDir;
    protected FSLockFactory() { }
    public virtual System.IO.DirectoryInfo LockDir { get { return default(System.IO.DirectoryInfo); } protected internal set { } }
  }
  public abstract partial class IndexInput : System.ICloneable, System.IDisposable {
    protected IndexInput() { }
    public abstract long FilePointer { get; }
    public virtual object Clone() { return default(object); }
    [System.ObsoleteAttribute("Use Dispose() instead.")]
    public void Close() { }
    public void Dispose() { }
    protected abstract void Dispose(bool disposing);
    public abstract long Length();
    public abstract byte ReadByte();
    public abstract void ReadBytes(System.Byte[] b, int offset, int len);
    public virtual void ReadBytes(System.Byte[] b, int offset, int len, bool useBuffer) { }
    [System.ObsoleteAttribute("-- please use ReadString or ReadBytes instead, and construct the string from those utf8 bytes")]
    public virtual void ReadChars(System.Char[] buffer, int start, int length) { }
    public virtual int ReadInt() { return default(int); }
    public virtual long ReadLong() { return default(long); }
    public virtual string ReadString() { return default(string); }
    public virtual System.Collections.Generic.IDictionary<System.String, System.String> ReadStringStringMap() { return default(System.Collections.Generic.IDictionary<System.String, System.String>); }
    public virtual int ReadVInt() { return default(int); }
    public virtual long ReadVLong() { return default(long); }
    public abstract void Seek(long pos);
    public virtual void SetModifiedUTF8StringsMode() { }
    [System.ObsoleteAttribute("this method operates on old \"modified utf8\" encoded strings")]
    public virtual void SkipChars(int length) { }
  }
  public abstract partial class IndexOutput : System.IDisposable {
    protected IndexOutput() { }
    public abstract long FilePointer { get; }
    public abstract long Length { get; }
    [System.ObsoleteAttribute("Use Dispose() instead.")]
    public void Close() { }
    public virtual void CopyBytes(Lucene.Net.Store.IndexInput input, long numBytes) { }
    public void Dispose() { }
    protected abstract void Dispose(bool disposing);
    public abstract void Flush();
    public abstract void Seek(long pos);
    public virtual void SetLength(long length) { }
    public abstract void WriteByte(byte b);
    public virtual void WriteBytes(System.Byte[] b, int length) { }
    public abstract void WriteBytes(System.Byte[] b, int offset, int length);
    [System.ObsoleteAttribute("-- please pre-convert to utf8 bytes instead or use WriteString")]
    public virtual void WriteChars(System.Char[] s, int start, int length) { }
    [System.ObsoleteAttribute("-- please pre-convert to utf8 bytes instead or use WriteString")]
    public virtual void WriteChars(string s, int start, int length) { }
    public virtual void WriteInt(int i) { }
    public virtual void WriteLong(long i) { }
    public virtual void WriteString(string s) { }
    public virtual void WriteStringStringMap(System.Collections.Generic.IDictionary<System.String, System.String> map) { }
    public virtual void WriteVInt(int i) { }
    public virtual void WriteVLong(long i) { }
  }
  public abstract partial class Lock {
    protected internal System.Exception failureReason;
    public const long LOCK_OBTAIN_WAIT_FOREVER = (long)-1;
    public static long LOCK_POLL_INTERVAL;
    protected Lock() { }
    public abstract bool IsLocked();
    public abstract bool Obtain();
    public virtual bool Obtain(long lockWaitTimeout) { return default(bool); }
    public abstract void Release();
    public abstract partial class With {
      protected With(Lucene.Net.Store.Lock lock_Renamed, long lockWaitTimeout) { }
      protected internal abstract object DoBody();
      public virtual object run() { return default(object); }
    }
  }
  public abstract partial class LockFactory {
    protected internal string internalLockPrefix;
    protected LockFactory() { }
    public virtual string LockPrefix { get { return default(string); } set { } }
    public abstract void ClearLock(string lockName);
    public abstract Lucene.Net.Store.Lock MakeLock(string lockName);
  }
  public partial class LockObtainFailedException : System.IO.IOException {
    public LockObtainFailedException(string message) { }
    public LockObtainFailedException(string message, System.Exception ex) { }
  }
  public partial class LockReleaseFailedException : System.IO.IOException {
    public LockReleaseFailedException(string message) { }
  }
  public partial class LockStressTest {
    public LockStressTest() { }
    [System.STAThreadAttribute]
    public static void Main(System.String[] args) { }
  }
  public partial class LockVerifyServer {
    public LockVerifyServer() { }
    [System.STAThreadAttribute]
    public static void Main(System.String[] args) { }
  }
  public partial class MMapDirectory : Lucene.Net.Store.FSDirectory {
    public static bool UNMAP_SUPPORTED;
    public MMapDirectory(System.IO.DirectoryInfo path) : base (default(System.IO.DirectoryInfo), default(Lucene.Net.Store.LockFactory)) { }
    public MMapDirectory(System.IO.DirectoryInfo path, Lucene.Net.Store.LockFactory lockFactory) : base (default(System.IO.DirectoryInfo), default(Lucene.Net.Store.LockFactory)) { }
    public virtual int MaxChunkSize { get { return default(int); } set { } }
    public virtual bool UseUnmap { get { return default(bool); } set { } }
    public override Lucene.Net.Store.IndexOutput CreateOutput(string name) { return default(Lucene.Net.Store.IndexOutput); }
    public override Lucene.Net.Store.IndexInput OpenInput(string name, int bufferSize) { return default(Lucene.Net.Store.IndexInput); }
    protected internal partial class MultiMMapIndexInput : Lucene.Net.Store.IndexInput, System.ICloneable {
      public MultiMMapIndexInput(Lucene.Net.Store.MMapDirectory enclosingInstance, System.IO.FileStream raf, int maxBufSize) { }
      public Lucene.Net.Store.MMapDirectory Enclosing_Instance { get { return default(Lucene.Net.Store.MMapDirectory); } }
      public override long FilePointer { get { return default(long); } }
      public override object Clone() { return default(object); }
      protected override void Dispose(bool disposing) { }
      public override long Length() { return default(long); }
      public override byte ReadByte() { return default(byte); }
      public override void ReadBytes(System.Byte[] b, int offset, int len) { }
      public override void Seek(long pos) { }
    }
  }
  public partial class NativeFSLockFactory : Lucene.Net.Store.FSLockFactory {
    public NativeFSLockFactory() { }
    public NativeFSLockFactory(System.IO.DirectoryInfo lockDir) { }
    public NativeFSLockFactory(string lockDirName) { }
    public override void ClearLock(string lockName) { }
    public override Lucene.Net.Store.Lock MakeLock(string lockName) { return default(Lucene.Net.Store.Lock); }
  }
  public partial class NIOFSDirectory : Lucene.Net.Store.FSDirectory {
    public NIOFSDirectory(System.IO.DirectoryInfo dir, Lucene.Net.Store.LockFactory lockFactory) : base (default(System.IO.DirectoryInfo), default(Lucene.Net.Store.LockFactory)) { }
    public override Lucene.Net.Store.IndexOutput CreateOutput(string name) { return default(Lucene.Net.Store.IndexOutput); }
    public partial class NIOFSIndexInput {
      public NIOFSIndexInput() { }
    }
  }
  public partial class NoLockFactory : Lucene.Net.Store.LockFactory {
    public NoLockFactory() { }
    public static Lucene.Net.Store.NoLockFactory Instance { get { return default(Lucene.Net.Store.NoLockFactory); } }
    public override void ClearLock(string lockName) { }
    public override Lucene.Net.Store.Lock MakeLock(string lockName) { return default(Lucene.Net.Store.Lock); }
  }
  public partial class NoSuchDirectoryException : System.IO.FileNotFoundException {
    public NoSuchDirectoryException(string message) { }
  }
  public partial class RAMDirectory : Lucene.Net.Store.Directory {
    protected internal Lucene.Net.Support.HashMap<System.String, Lucene.Net.Store.RAMFile> fileMap;
    protected internal long internalSizeInBytes;
    public RAMDirectory() { }
    public RAMDirectory(Lucene.Net.Store.Directory dir) { }
    public override Lucene.Net.Store.IndexOutput CreateOutput(string name) { return default(Lucene.Net.Store.IndexOutput); }
    public override void DeleteFile(string name) { }
    protected override void Dispose(bool disposing) { }
    public override bool FileExists(string name) { return default(bool); }
    public override long FileLength(string name) { return default(long); }
    public override long FileModified(string name) { return default(long); }
    public override System.String[] ListAll() { return default(System.String[]); }
    public override Lucene.Net.Store.IndexInput OpenInput(string name) { return default(Lucene.Net.Store.IndexInput); }
    public long SizeInBytes() { return default(long); }
    public override void TouchFile(string name) { }
  }
  public partial class RAMFile {
    protected System.Collections.Generic.List<System.Byte[]> buffers;
    public RAMFile() { }
    public RAMFile(Lucene.Net.Store.RAMDirectory directory) { }
    public virtual long SizeInBytes { get { return default(long); } }
    public System.Byte[] GetBuffer(int index) { return default(System.Byte[]); }
    public virtual System.Byte[] NewBuffer(int size) { return default(System.Byte[]); }
    public int NumBuffers() { return default(int); }
  }
  public partial class RAMInputStream : Lucene.Net.Store.IndexInput {
    public RAMInputStream(Lucene.Net.Store.RAMFile f) { }
    public override long FilePointer { get { return default(long); } }
    protected override void Dispose(bool disposing) { }
    public override long Length() { return default(long); }
    public override byte ReadByte() { return default(byte); }
    public override void ReadBytes(System.Byte[] b, int offset, int len) { }
    public override void Seek(long pos) { }
  }
  public partial class RAMOutputStream : Lucene.Net.Store.IndexOutput {
    public RAMOutputStream() { }
    public override long FilePointer { get { return default(long); } }
    public override long Length { get { return default(long); } }
    protected override void Dispose(bool disposing) { }
    public override void Flush() { }
    public virtual void Reset() { }
    public override void Seek(long pos) { }
    public virtual long SizeInBytes() { return default(long); }
    public override void WriteByte(byte b) { }
    public override void WriteBytes(System.Byte[] b, int offset, int len) { }
    public virtual void WriteTo(Lucene.Net.Store.IndexOutput out_Renamed) { }
  }
  public partial class SimpleFSDirectory : Lucene.Net.Store.FSDirectory {
    public SimpleFSDirectory(System.IO.DirectoryInfo path) : base (default(System.IO.DirectoryInfo), default(Lucene.Net.Store.LockFactory)) { }
    public SimpleFSDirectory(System.IO.DirectoryInfo path, Lucene.Net.Store.LockFactory lockFactory) : base (default(System.IO.DirectoryInfo), default(Lucene.Net.Store.LockFactory)) { }
    public override Lucene.Net.Store.IndexOutput CreateOutput(string name) { return default(Lucene.Net.Store.IndexOutput); }
    public override Lucene.Net.Store.IndexInput OpenInput(string name, int bufferSize) { return default(Lucene.Net.Store.IndexInput); }
    protected internal partial class SimpleFSIndexInput : Lucene.Net.Store.BufferedIndexInput {
      protected internal int chunkSize;
      protected internal Lucene.Net.Store.SimpleFSDirectory.SimpleFSIndexInput.Descriptor file;
      public SimpleFSIndexInput(System.IO.FileInfo path, int bufferSize, int chunkSize) { }
      public bool isClone_ForNUnit { get { return default(bool); } }
      public override object Clone() { return default(object); }
      protected override void Dispose(bool disposing) { }
      public virtual bool IsFDValid() { return default(bool); }
      public override long Length() { return default(long); }
      public override void ReadInternal(System.Byte[] b, int offset, int len) { }
      public override void SeekInternal(long position) { }
      protected internal partial class Descriptor : System.IO.BinaryReader {
        protected internal bool isOpen;
        public Descriptor(System.IO.FileInfo file, System.IO.FileAccess mode) : base (default(System.IO.Stream)) { }
        protected override void Dispose(bool disposing) { }
        ~Descriptor() { }
      }
    }
    public partial class SimpleFSIndexOutput : Lucene.Net.Store.BufferedIndexOutput {
      public SimpleFSIndexOutput(System.IO.FileInfo path) { }
      public override long Length { get { return default(long); } }
      protected override void Dispose(bool disposing) { }
      public override void FlushBuffer(System.Byte[] b, int offset, int size) { }
      public override void Seek(long pos) { }
      public override void SetLength(long length) { }
    }
  }
  public partial class SimpleFSLockFactory : Lucene.Net.Store.FSLockFactory {
    public SimpleFSLockFactory() { }
    public SimpleFSLockFactory(System.IO.DirectoryInfo lockDir) { }
    public SimpleFSLockFactory(string lockDirName) { }
    public override void ClearLock(string lockName) { }
    public override Lucene.Net.Store.Lock MakeLock(string lockName) { return default(Lucene.Net.Store.Lock); }
  }
  public partial class SingleInstanceLockFactory : Lucene.Net.Store.LockFactory {
    public SingleInstanceLockFactory() { }
    public override void ClearLock(string lockName) { }
    public override Lucene.Net.Store.Lock MakeLock(string lockName) { return default(Lucene.Net.Store.Lock); }
  }
  public partial class VerifyingLockFactory : Lucene.Net.Store.LockFactory {
    public VerifyingLockFactory(sbyte id, Lucene.Net.Store.LockFactory lf, string host, int port) { }
    public override void ClearLock(string lockName) { }
    public override Lucene.Net.Store.Lock MakeLock(string lockName) { return default(Lucene.Net.Store.Lock); }
  }
}
namespace Lucene.Net.Support {
  public partial class AppSettings {
    public AppSettings() { }
    public static bool Get(string key, bool defValue) { return default(bool); }
    public static int Get(string key, int defValue) { return default(int); }
    public static long Get(string key, long defValue) { return default(long); }
    public static string Get(string key, string defValue) { return default(string); }
    public static void Set(string key, bool defValue) { }
    public static void Set(string key, int defValue) { }
    public static void Set(string key, long defValue) { }
    public static void Set(string key, string defValue) { }
  }
  public partial class BitSetSupport {
    public BitSetSupport() { }
    public static int Cardinality(System.Collections.BitArray bits) { return default(int); }
    public static int NextClearBit(System.Collections.BitArray bitArray, int index) { return default(int); }
    public static int NextSetBit(System.Collections.BitArray bitArray, int index) { return default(int); }
  }
  public partial class BuildType {
    public static bool Debug;
    public BuildType() { }
  }
  public partial class Character {
    public Character() { }
    public static int MAX_RADIX { get { return default(int); } }
    public static int MIN_RADIX { get { return default(int); } }
    public static char ForDigit(int digit, int radix) { return default(char); }
  }
  public partial class CloseableThreadLocalProfiler {
    public static System.Collections.Generic.List<System.WeakReference> Instances;
    public CloseableThreadLocalProfiler() { }
    public static bool EnableCloseableThreadLocalProfiler { get { return default(bool); } set { } }
  }
  public partial class CollectionsHelper {
    public CollectionsHelper() { }
    public static void Add(System.Collections.Hashtable hashtable, object item) { }
    public static void AddAll(System.Collections.Generic.IDictionary<System.String, System.String> hashtable, System.Collections.Generic.ICollection<System.String> items) { }
    public static void AddAll(System.Collections.Hashtable hashtable, System.Collections.ICollection items) { }
    public static void AddAllIfNotContains(System.Collections.Generic.IDictionary<System.String, System.String> hashtable, System.Collections.Generic.ICollection<System.String> items) { }
    public static void AddAllIfNotContains(System.Collections.Hashtable hashtable, System.Collections.ICollection items) { }
    public static void AddAllIfNotContains(System.Collections.Hashtable hashtable, System.Collections.IList items) { }
    public static void AddIfNotContains(System.Collections.ArrayList hashtable, object item) { }
    public static void AddIfNotContains(System.Collections.Hashtable hashtable, object item) { }
    public static string CollectionToString(System.Collections.Generic.IDictionary<System.String, System.String> c) { return default(string); }
    public static string CollectionToString(System.Collections.ICollection c) { return default(string); }
    public static bool CompareStringArrays(System.String[] l1, System.String[] l2) { return default(bool); }
    public static bool Contains(System.Collections.Generic.ICollection<System.String> col, string item) { return default(bool); }
    public static bool Contains(System.Collections.ICollection col, object item) { return default(bool); }
    public static bool Equals(System.Array array1, System.Array array2) { return default(bool); }
    public static void Fill(System.Array array, int fromindex, int toindex, object val) { }
    public static void Fill(System.Array array, object val) { }
    public static void Sort(System.Collections.IList list, System.Collections.IComparer Comparator) { }
  }
  public partial class Compare {
    public Compare() { }
    public static bool CompareTermArrays(Lucene.Net.Index.Term[] t1, Lucene.Net.Index.Term[] t2) { return default(bool); }
  }
  public partial class CRC32 : Lucene.Net.Support.IChecksum {
    public CRC32() { }
    public long Value { get { return default(long); } }
    public void Reset() { }
    public void Update(System.Byte[] buf) { }
    public void Update(System.Byte[] buf, int off, int len) { }
    public void Update(int bval) { }
  }
  public static partial class Cryptography {
    public static bool FIPSCompliant;
    public static System.Security.Cryptography.HashAlgorithm HashAlgorithm { get { return default(System.Security.Cryptography.HashAlgorithm); } }
  }
  public partial class Deflater {
    internal Deflater() { }
    public const int BEST_COMPRESSION = 9;
    public bool IsFinished { get { return default(bool); } }
    public int Deflate(System.Byte[] output) { return default(int); }
    public void Finish() { }
    public void SetInput(System.Byte[] input, int offset, int count) { }
    public void SetLevel(int level) { }
  }
  public partial class Double {
    public Double() { }
    public static double Parse(string s) { return default(double); }
  }
  public partial class EquatableList<T> : System.Collections.Generic.List<T>, System.ICloneable, System.IEquatable<System.Collections.Generic.IEnumerable<T>> {
    public EquatableList() { }
    public EquatableList(System.Collections.Generic.IEnumerable<T> collection) { }
    public EquatableList(int capacity) { }
    public void AddRange(System.Collections.ICollection c) { }
    public object Clone() { return default(object); }
    public bool Equals(System.Collections.Generic.IEnumerable<T> other) { return default(bool); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static int GetHashCode<T>(System.Collections.Generic.IEnumerable<T> source) { return default(int); }
  }
  public partial class FileSupport {
    public FileSupport() { }
    public static System.IO.FileInfo[] GetFiles(System.IO.DirectoryInfo path) { return default(System.IO.FileInfo[]); }
    public static System.IO.FileInfo[] GetFiles(System.IO.FileInfo path) { return default(System.IO.FileInfo[]); }
    public static System.String[] GetLuceneIndexFiles(string fullName, Lucene.Net.Index.IndexFileNameFilter indexFileNameFilter) { return default(System.String[]); }
    public static void Sync(System.IO.FileStream fileStream) { }
  }
  public partial class HashMap<TKey, TValue> : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable {
    public HashMap() { }
    public HashMap(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>> other) { }
    public HashMap(System.Collections.Generic.IEqualityComparer<TKey> comparer) { }
    public HashMap(int initialCapacity) { }
    public HashMap(int initialCapacity, System.Collections.Generic.IEqualityComparer<TKey> comparer) { }
    public int Count { get { return default(int); } }
    public bool IsReadOnly { get { return default(bool); } }
    public TValue this[TKey key] { get { return default(TValue); } set { } }
    public System.Collections.Generic.ICollection<TKey> Keys { get { return default(System.Collections.Generic.ICollection<TKey>); } }
    public System.Collections.Generic.ICollection<TValue> Values { get { return default(System.Collections.Generic.ICollection<TValue>); } }
    public virtual void Add(TKey key, TValue value) { }
    public void Clear() { }
    public bool ContainsKey(TKey key) { return default(bool); }
    public bool ContainsValue(TValue value) { return default(bool); }
    [System.Diagnostics.DebuggerHiddenAttribute]
    public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>>); }
    public bool Remove(TKey key) { return default(bool); }
    public bool Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> item) { return default(bool); }
    void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey, TValue> item) { }
    bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> item) { return default(bool); }
    void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(System.Collections.Generic.KeyValuePair<TKey, TValue>[] array, int arrayIndex) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    public bool TryGetValue(TKey key, out TValue value) { value = default(TValue); return default(bool); }
  }
  public partial interface IChecksum {
    long Value { get; }
    void Reset();
    void Update(System.Byte[] b);
    void Update(System.Byte[] b, int offset, int length);
    void Update(int b);
  }
  public partial class Inflater {
    internal Inflater() { }
    public bool IsFinished { get { return default(bool); } }
    public int Inflate(System.Byte[] buffer) { return default(int); }
    public void SetInput(System.Byte[] buffer) { }
  }
  public partial interface IThreadRunnable {
    void Run();
  }
  public partial class Number {
    public const int MAX_RADIX = 36;
    public const int MIN_RADIX = 2;
    public Number() { }
    public static int NextSetBit(System.Collections.BitArray bits, int fromIndex) { return default(int); }
    public static long Parse(string s, int radix) { return default(long); }
    public static long ToInt64(string s) { return default(long); }
    public static string ToString(long number) { return default(string); }
    public static string ToString(long i, int radix) { return default(string); }
    public static string ToString(float f) { return default(string); }
    public static int URShift(int number, int bits) { return default(int); }
    public static long URShift(long number, int bits) { return default(long); }
  }
  public partial class OS {
    public OS() { }
    public static bool IsUnix { get { return default(bool); } }
    public static bool IsWindows { get { return default(bool); } }
  }
  public partial class SharpZipLib {
    public SharpZipLib() { }
    public static Lucene.Net.Support.Deflater CreateDeflater() { return default(Lucene.Net.Support.Deflater); }
    public static Lucene.Net.Support.Inflater CreateInflater() { return default(Lucene.Net.Support.Inflater); }
  }
  public partial class Single {
    public Single() { }
    public static int FloatToIntBits(float value) { return default(int); }
    public static float IntBitsToFloat(int value) { return default(float); }
    public static float Parse(string s) { return default(float); }
    public static float Parse(string s, System.Globalization.NumberStyles style) { return default(float); }
    public static float Parse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider) { return default(float); }
    public static float Parse(string s, System.IFormatProvider provider) { return default(float); }
    public static string ToString(float f) { return default(string); }
    public static string ToString(float f, string format) { return default(string); }
    public static bool TryParse(string s, out float f) { f = default(float); return default(bool); }
  }
  public partial class TextSupport {
    public TextSupport() { }
    public static void GetCharsFromString(string sourceString, int sourceStart, int sourceEnd, System.Char[] destinationArray, int destinationStart) { }
  }
  public partial class ThreadClass : Lucene.Net.Support.IThreadRunnable {
    public ThreadClass() { }
    public ThreadClass(string Name) { }
    public ThreadClass(System.Threading.ThreadStart Start) { }
    public ThreadClass(System.Threading.ThreadStart Start, string Name) { }
    public System.Threading.Thread Instance { get { return default(System.Threading.Thread); } set { } }
    public bool IsAlive { get { return default(bool); } }
    public bool IsBackground { get { return default(bool); } set { } }
    public string Name { get { return default(string); } set { } }
    public System.Threading.ThreadPriority Priority { get { return default(System.Threading.ThreadPriority); } set { } }
    public void Abort() { }
    public void Abort(object stateInfo) { }
    public static Lucene.Net.Support.ThreadClass Current() { return default(Lucene.Net.Support.ThreadClass); }
    public static Lucene.Net.Support.ThreadClass CurrentThread() { return default(Lucene.Net.Support.ThreadClass); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public virtual void Interrupt() { }
    public void Join() { }
    public void Join(long MiliSeconds) { }
    public void Join(long MiliSeconds, int NanoSeconds) { }
    public static bool operator ==(Lucene.Net.Support.ThreadClass t1, object t2) { return default(bool); }
    public static bool operator !=(Lucene.Net.Support.ThreadClass t1, object t2) { return default(bool); }
    public void Resume() { }
    public virtual void Run() { }
    public void SetDaemon(bool isDaemon) { }
    public static void Sleep(long ms) { }
    public virtual void Start() { }
    public void Suspend() { }
    public override string ToString() { return default(string); }
  }
  public abstract partial class ThreadLock {
    protected ThreadLock() { }
    public static Lucene.Net.Support.ThreadLock MonitorLock { get { return default(Lucene.Net.Support.ThreadLock); } }
    public static Lucene.Net.Support.ThreadLock NullLock { get { return default(Lucene.Net.Support.ThreadLock); } }
    public abstract void Enter(object obj);
    public abstract void Exit(object obj);
  }
  public sealed partial class WeakDictionary<TKey, TValue> : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable {
    public WeakDictionary() { }
    public WeakDictionary(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>> otherDictionary) { }
    public WeakDictionary(int initialCapacity) { }
    public int Count { get { return default(int); } }
    public bool IsReadOnly { get { return default(bool); } }
    public TValue this[TKey key] { get { return default(TValue); } set { } }
    public System.Collections.Generic.ICollection<TKey> Keys { get { return default(System.Collections.Generic.ICollection<TKey>); } }
    public System.Collections.Generic.ICollection<TValue> Values { get { return default(System.Collections.Generic.ICollection<TValue>); } }
    public void Add(TKey key, TValue value) { }
    public void Clear() { }
    public bool ContainsKey(TKey key) { return default(bool); }
    [System.Diagnostics.DebuggerHiddenAttribute]
    public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>>); }
    public bool Remove(TKey key) { return default(bool); }
    void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey, TValue> item) { }
    bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> item) { return default(bool); }
    void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(System.Collections.Generic.KeyValuePair<TKey, TValue>[] array, int arrayIndex) { }
    bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> item) { return default(bool); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    public bool TryGetValue(TKey key, out TValue value) { value = default(TValue); return default(bool); }
  }
}
namespace Lucene.Net.Support.Compatibility {
  public static partial class SetFactory {
    public static System.Collections.Generic.ISet<T> CreateHashSet<T>() { return default(System.Collections.Generic.ISet<T>); }
    public static System.Collections.Generic.ISet<T> CreateHashSet<T>(System.Collections.Generic.IEnumerable<T> other) { return default(System.Collections.Generic.ISet<T>); }
  }
}
namespace Lucene.Net.Util {
  public sealed partial class ArrayUtil {
    public ArrayUtil() { }
    public static int GetNextSize(int targetSize) { return default(int); }
    public static int GetShrinkSize(int currentSize, int targetSize) { return default(int); }
    public static System.Byte[] Grow(System.Byte[] array) { return default(System.Byte[]); }
    public static System.Byte[] Grow(System.Byte[] array, int minSize) { return default(System.Byte[]); }
    public static System.Int32[] Grow(System.Int32[] array) { return default(System.Int32[]); }
    public static System.Int32[] Grow(System.Int32[] array, int minSize) { return default(System.Int32[]); }
    public static System.Int64[] Grow(System.Int64[] array) { return default(System.Int64[]); }
    public static System.Int64[] Grow(System.Int64[] array, int minSize) { return default(System.Int64[]); }
    public static int HashCode(System.Byte[] array, int start, int end) { return default(int); }
    public static int HashCode(System.Char[] array, int start, int end) { return default(int); }
    public static int ParseInt(System.Char[] chars) { return default(int); }
    public static int ParseInt(System.Char[] chars, int offset, int len) { return default(int); }
    public static int ParseInt(System.Char[] chars, int offset, int len, int radix) { return default(int); }
    public static System.Byte[] Shrink(System.Byte[] array, int targetSize) { return default(System.Byte[]); }
    public static System.Int32[] Shrink(System.Int32[] array, int targetSize) { return default(System.Int32[]); }
    public static System.Int64[] Shrink(System.Int64[] array, int targetSize) { return default(System.Int64[]); }
  }
  public abstract partial class Attribute : Lucene.Net.Util.IAttribute, System.ICloneable {
    protected Attribute() { }
    public abstract void Clear();
    public virtual object Clone() { return default(object); }
    public abstract void CopyTo(Lucene.Net.Util.Attribute target);
    public abstract override bool Equals(object other);
    public abstract override int GetHashCode();
    public override string ToString() { return default(string); }
  }
  public partial class AttributeSource {
    public AttributeSource() { }
    public AttributeSource(Lucene.Net.Util.AttributeSource input) { }
    public AttributeSource(Lucene.Net.Util.AttributeSource.AttributeFactory factory) { }
    public virtual Lucene.Net.Util.AttributeSource.AttributeFactory Factory { get { return default(Lucene.Net.Util.AttributeSource.AttributeFactory); } }
    public virtual bool HasAttributes { get { return default(bool); } }
    public virtual T AddAttribute<T>() where T : Lucene.Net.Util.IAttribute { return default(T); }
    public virtual void AddAttributeImpl(Lucene.Net.Util.Attribute att) { }
    public virtual Lucene.Net.Util.AttributeSource.State CaptureState() { return default(Lucene.Net.Util.AttributeSource.State); }
    public virtual void ClearAttributes() { }
    public virtual Lucene.Net.Util.AttributeSource CloneAttributes() { return default(Lucene.Net.Util.AttributeSource); }
    public override bool Equals(object obj) { return default(bool); }
    public virtual T GetAttribute<T>() where T : Lucene.Net.Util.IAttribute { return default(T); }
    [System.Diagnostics.DebuggerHiddenAttribute]
    public virtual System.Collections.Generic.IEnumerable<Lucene.Net.Util.Attribute> GetAttributeImplsIterator() { return default(System.Collections.Generic.IEnumerable<Lucene.Net.Util.Attribute>); }
    public virtual System.Collections.Generic.IEnumerable<System.Type> GetAttributeTypesIterator() { return default(System.Collections.Generic.IEnumerable<System.Type>); }
    public override int GetHashCode() { return default(int); }
    public virtual bool HasAttribute<T>() where T : Lucene.Net.Util.IAttribute { return default(bool); }
    public virtual void RestoreState(Lucene.Net.Util.AttributeSource.State state) { }
    public override string ToString() { return default(string); }
    public abstract partial class AttributeFactory {
      public static readonly Lucene.Net.Util.AttributeSource.AttributeFactory DEFAULT_ATTRIBUTE_FACTORY;
      protected AttributeFactory() { }
      public abstract Lucene.Net.Util.Attribute CreateAttributeInstance<T>() where T : Lucene.Net.Util.IAttribute;
    }
    public sealed partial class State : System.ICloneable {
      public State() { }
      public object Clone() { return default(object); }
    }
  }
  public partial class AverageGuessMemoryModel : Lucene.Net.Util.MemoryModel {
    public AverageGuessMemoryModel() { }
    public override int ArraySize { get { return default(int); } }
    public override int ClassSize { get { return default(int); } }
    public override int ReferenceSize { get { return default(int); } }
    public override int GetPrimitiveSize(System.Type clazz) { return default(int); }
  }
  public partial class BitUtil {
    public static readonly System.Byte[] ntzTable;
    public BitUtil() { }
    public static bool IsPowerOfTwo(int v) { return default(bool); }
    public static bool IsPowerOfTwo(long v) { return default(bool); }
    public static int NextHighestPowerOfTwo(int v) { return default(int); }
    public static long NextHighestPowerOfTwo(long v) { return default(long); }
    public static int Ntz(int val) { return default(int); }
    public static int Ntz(long val) { return default(int); }
    public static int Ntz2(long x) { return default(int); }
    public static int Ntz3(long x) { return default(int); }
    public static int Pop(long x) { return default(int); }
    public static long Pop_andnot(System.Int64[] A, System.Int64[] B, int wordOffset, int numWords) { return default(long); }
    public static long Pop_array(System.Int64[] A, int wordOffset, int numWords) { return default(long); }
    public static long Pop_intersect(System.Int64[] A, System.Int64[] B, int wordOffset, int numWords) { return default(long); }
    public static long Pop_union(System.Int64[] A, System.Int64[] B, int wordOffset, int numWords) { return default(long); }
    public static long Pop_xor(System.Int64[] A, System.Int64[] B, int wordOffset, int numWords) { return default(long); }
  }
  public sealed partial class BitVector : System.ICloneable {
    public BitVector(Lucene.Net.Store.Directory d, string name) { }
    public BitVector(int n) { }
    public void Clear(int bit) { }
    public object Clone() { return default(object); }
    public int Count() { return default(int); }
    public bool Get(int bit) { return default(bool); }
    public bool GetAndSet(int bit) { return default(bool); }
    public int GetRecomputedCount() { return default(int); }
    public void Set(int bit) { }
    public int Size() { return default(int); }
    public Lucene.Net.Util.BitVector Subset(int start, int end) { return default(Lucene.Net.Util.BitVector); }
    public void Write(Lucene.Net.Store.Directory d, string name) { }
  }
  public partial class CloseableThreadLocal<T> : System.IDisposable where T : class {
    public CloseableThreadLocal() { }
    [System.ObsoleteAttribute("Use Dispose() instead")]
    public virtual void Close() { }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public virtual T Get() { return default(T); }
    public virtual T InitialValue() { return default(T); }
    public virtual void Set(T @object) { }
  }
  public sealed partial class Constants {
    internal Constants() { }
    public static readonly bool JAVA_1_1;
    public static readonly bool JAVA_1_2;
    public static readonly bool JAVA_1_3;
    public static readonly string JAVA_VENDOR;
    public static readonly string JAVA_VERSION;
    public static bool JRE_IS_64BIT;
    public static readonly bool LINUX;
    public static readonly string LUCENE_MAIN_VERSION;
    public static string LUCENE_VERSION;
    public static readonly string OS_ARCH;
    public static readonly string OS_NAME;
    public static readonly string OS_VERSION;
    public static readonly bool SUN_OS;
    public static readonly bool WINDOWS;
  }
  public partial class DocIdBitSet : Lucene.Net.Search.DocIdSet {
    public DocIdBitSet(System.Collections.BitArray bitSet) { }
    public virtual System.Collections.BitArray BitSet { get { return default(System.Collections.BitArray); } }
    public override bool IsCacheable { get { return default(bool); } }
    public override Lucene.Net.Search.DocIdSetIterator Iterator() { return default(Lucene.Net.Search.DocIdSetIterator); }
  }
  public sealed partial class FieldCacheSanityChecker {
    public FieldCacheSanityChecker() { }
    public Lucene.Net.Util.FieldCacheSanityChecker.Insanity[] Check(params Lucene.Net.Search.CacheEntry[] cacheEntries) { return default(Lucene.Net.Util.FieldCacheSanityChecker.Insanity[]); }
    public static Lucene.Net.Util.FieldCacheSanityChecker.Insanity[] CheckSanity(params Lucene.Net.Search.CacheEntry[] cacheEntries) { return default(Lucene.Net.Util.FieldCacheSanityChecker.Insanity[]); }
    public static Lucene.Net.Util.FieldCacheSanityChecker.Insanity[] CheckSanity(Lucene.Net.Search.FieldCache cache) { return default(Lucene.Net.Util.FieldCacheSanityChecker.Insanity[]); }
    public void SetRamUsageEstimator(Lucene.Net.Util.RamUsageEstimator r) { }
    public sealed partial class Insanity {
      public Insanity(Lucene.Net.Util.FieldCacheSanityChecker.InsanityType type, string msg, params Lucene.Net.Search.CacheEntry[] entries) { }
      public string Msg { get { return default(string); } }
      public Lucene.Net.Util.FieldCacheSanityChecker.InsanityType Type { get { return default(Lucene.Net.Util.FieldCacheSanityChecker.InsanityType); } }
      public Lucene.Net.Search.CacheEntry[] GetCacheEntries() { return default(Lucene.Net.Search.CacheEntry[]); }
      public override string ToString() { return default(string); }
    }
    public sealed partial class InsanityType {
      internal InsanityType() { }
      public static readonly Lucene.Net.Util.FieldCacheSanityChecker.InsanityType EXPECTED;
      public static readonly Lucene.Net.Util.FieldCacheSanityChecker.InsanityType SUBREADER;
      public static readonly Lucene.Net.Util.FieldCacheSanityChecker.InsanityType VALUEMISMATCH;
      public override string ToString() { return default(string); }
    }
  }
  public partial interface IAttribute {
  }
  public partial class IdentityDictionary<TKey, TValue> : System.Collections.Generic.Dictionary<TKey, TValue> {
    public IdentityDictionary() { }
    public IdentityDictionary(System.Collections.Generic.IDictionary<TKey, TValue> other) { }
    public IdentityDictionary(int capacity) { }
  }
  public partial class IndexableBinaryStringTools {
    internal IndexableBinaryStringTools() { }
    public static System.Collections.Generic.List<System.Byte> Decode(System.Collections.Generic.List<System.Char> input) { return default(System.Collections.Generic.List<System.Byte>); }
    public static void Decode(System.Collections.Generic.List<System.Char> input, System.Collections.Generic.List<System.Byte> output) { }
    public static System.Collections.Generic.List<System.Char> Encode(System.Collections.Generic.List<System.Byte> input) { return default(System.Collections.Generic.List<System.Char>); }
    public static void Encode(System.Collections.Generic.List<System.Byte> input, System.Collections.Generic.List<System.Char> output) { }
    public static int GetDecodedLength(System.Collections.Generic.List<System.Char> encoded) { return default(int); }
    public static int GetEncodedLength(System.Collections.Generic.List<System.Byte> original) { return default(int); }
  }
  public partial class MapOfSets<TKey, TValue> {
    public MapOfSets(System.Collections.Generic.IDictionary<TKey, System.Collections.Generic.HashSet<TValue>> m) { }
    public virtual System.Collections.Generic.IDictionary<TKey, System.Collections.Generic.HashSet<TValue>> Map { get { return default(System.Collections.Generic.IDictionary<TKey, System.Collections.Generic.HashSet<TValue>>); } }
    public virtual int Put(TKey key, TValue val) { return default(int); }
    public virtual int PutAll(TKey key, System.Collections.Generic.IEnumerable<TValue> vals) { return default(int); }
  }
  public abstract partial class MemoryModel {
    protected MemoryModel() { }
    public abstract int ArraySize { get; }
    public abstract int ClassSize { get; }
    public abstract int ReferenceSize { get; }
    public abstract int GetPrimitiveSize(System.Type clazz);
  }
  public sealed partial class NumericUtils {
    internal NumericUtils() { }
    public const int BUF_SIZE_INT = 6;
    public const int BUF_SIZE_LONG = 11;
    public const int PRECISION_STEP_DEFAULT = 4;
    public static char SHIFT_START_INT;
    public static char SHIFT_START_LONG;
    public static string DoubleToPrefixCoded(double val) { return default(string); }
    public static long DoubleToSortableLong(double val) { return default(long); }
    public static string FloatToPrefixCoded(float val) { return default(string); }
    public static int FloatToSortableInt(float val) { return default(int); }
    public static string IntToPrefixCoded(int val) { return default(string); }
    public static string IntToPrefixCoded(int val, int shift) { return default(string); }
    public static int IntToPrefixCoded(int val, int shift, System.Char[] buffer) { return default(int); }
    public static string LongToPrefixCoded(long val) { return default(string); }
    public static string LongToPrefixCoded(long val, int shift) { return default(string); }
    public static int LongToPrefixCoded(long val, int shift, System.Char[] buffer) { return default(int); }
    public static double PrefixCodedToDouble(string val) { return default(double); }
    public static float PrefixCodedToFloat(string val) { return default(float); }
    public static int PrefixCodedToInt(string prefixCoded) { return default(int); }
    public static long PrefixCodedToLong(string prefixCoded) { return default(long); }
    public static float SortableIntToFloat(int val) { return default(float); }
    public static double SortableLongToDouble(long val) { return default(double); }
    public static void SplitIntRange(Lucene.Net.Util.NumericUtils.IntRangeBuilder builder, int precisionStep, int minBound, int maxBound) { }
    public static void SplitLongRange(Lucene.Net.Util.NumericUtils.LongRangeBuilder builder, int precisionStep, long minBound, long maxBound) { }
    public abstract partial class IntRangeBuilder {
      protected IntRangeBuilder() { }
      public virtual void AddRange(int min, int max, int shift) { }
      public virtual void AddRange(string minPrefixCoded, string maxPrefixCoded) { }
    }
    public abstract partial class LongRangeBuilder {
      protected LongRangeBuilder() { }
      public virtual void AddRange(long min, long max, int shift) { }
      public virtual void AddRange(string minPrefixCoded, string maxPrefixCoded) { }
    }
  }
  public partial class OpenBitSet : Lucene.Net.Search.DocIdSet, System.ICloneable {
    protected internal System.Int64[] internalbits;
    protected internal int wlen;
    public OpenBitSet() { }
    public OpenBitSet(long numBits) { }
    public OpenBitSet(System.Int64[] bits, int numWords) { }
    public virtual System.Int64[] Bits { get { return default(System.Int64[]); } set { } }
    public override bool IsCacheable { get { return default(bool); } }
    public virtual int NumWords { get { return default(int); } set { } }
    public virtual void And(Lucene.Net.Util.OpenBitSet other) { }
    public virtual void AndNot(Lucene.Net.Util.OpenBitSet other) { }
    public static long AndNotCount(Lucene.Net.Util.OpenBitSet a, Lucene.Net.Util.OpenBitSet b) { return default(long); }
    public static int Bits2words(long numBits) { return default(int); }
    public virtual long Capacity() { return default(long); }
    public virtual long Cardinality() { return default(long); }
    public virtual void Clear(int startIndex, int endIndex) { }
    public virtual void Clear(long index) { }
    public virtual void Clear(long startIndex, long endIndex) { }
    public virtual object Clone() { return default(object); }
    public virtual void EnsureCapacity(long numBits) { }
    public virtual void EnsureCapacityWords(int numWords) { }
    public override bool Equals(object o) { return default(bool); }
    protected internal virtual int ExpandingWordNum(long index) { return default(int); }
    public virtual void FastClear(int index) { }
    public virtual void FastClear(long index) { }
    public virtual void FastFlip(int index) { }
    public virtual void FastFlip(long index) { }
    public virtual bool FastGet(int index) { return default(bool); }
    public virtual bool FastGet(long index) { return default(bool); }
    public virtual void FastSet(int index) { }
    public virtual void FastSet(long index) { }
    public virtual void Flip(long index) { }
    public virtual void Flip(long startIndex, long endIndex) { }
    public virtual bool FlipAndGet(int index) { return default(bool); }
    public virtual bool FlipAndGet(long index) { return default(bool); }
    public virtual bool Get(int index) { return default(bool); }
    public virtual bool Get(long index) { return default(bool); }
    public virtual bool GetAndSet(int index) { return default(bool); }
    public virtual bool GetAndSet(long index) { return default(bool); }
    public virtual int GetBit(int index) { return default(int); }
    public override int GetHashCode() { return default(int); }
    public virtual void Intersect(Lucene.Net.Util.OpenBitSet other) { }
    public static long IntersectionCount(Lucene.Net.Util.OpenBitSet a, Lucene.Net.Util.OpenBitSet b) { return default(long); }
    public virtual bool Intersects(Lucene.Net.Util.OpenBitSet other) { return default(bool); }
    public virtual bool IsEmpty() { return default(bool); }
    public override Lucene.Net.Search.DocIdSetIterator Iterator() { return default(Lucene.Net.Search.DocIdSetIterator); }
    public virtual int NextSetBit(int index) { return default(int); }
    public virtual long NextSetBit(long index) { return default(long); }
    public virtual void Or(Lucene.Net.Util.OpenBitSet other) { }
    public virtual void Remove(Lucene.Net.Util.OpenBitSet other) { }
    public virtual void Set(long index) { }
    public virtual void Set(long startIndex, long endIndex) { }
    public virtual long Size() { return default(long); }
    public virtual void TrimTrailingZeros() { }
    public virtual void Union(Lucene.Net.Util.OpenBitSet other) { }
    public static long UnionCount(Lucene.Net.Util.OpenBitSet a, Lucene.Net.Util.OpenBitSet b) { return default(long); }
    public virtual void Xor(Lucene.Net.Util.OpenBitSet other) { }
    public static long XorCount(Lucene.Net.Util.OpenBitSet a, Lucene.Net.Util.OpenBitSet b) { return default(long); }
  }
  public partial class OpenBitSetDISI : Lucene.Net.Util.OpenBitSet {
    public OpenBitSetDISI(Lucene.Net.Search.DocIdSetIterator disi, int maxSize) { }
    public OpenBitSetDISI(int maxSize) { }
    public virtual void InPlaceAnd(Lucene.Net.Search.DocIdSetIterator disi) { }
    public virtual void InPlaceNot(Lucene.Net.Search.DocIdSetIterator disi) { }
    public virtual void InPlaceOr(Lucene.Net.Search.DocIdSetIterator disi) { }
    public virtual void InPlaceXor(Lucene.Net.Search.DocIdSetIterator disi) { }
  }
  public partial class OpenBitSetIterator : Lucene.Net.Search.DocIdSetIterator {
    public OpenBitSetIterator(Lucene.Net.Util.OpenBitSet obs) { }
    public OpenBitSetIterator(System.Int64[] bits, int numWords) { }
    public override int Advance(int target) { return default(int); }
    public override int DocID() { return default(int); }
    public override int NextDoc() { return default(int); }
  }
  public abstract partial class PriorityQueue<T> {
    protected internal T[] heap;
    protected PriorityQueue() { }
    protected internal virtual T SentinelObject { get { return default(T); } }
    public T Add(T element) { return default(T); }
    public void Clear() { }
    protected internal void Initialize(int maxSize) { }
    public virtual T InsertWithOverflow(T element) { return default(T); }
    public abstract bool LessThan(T a, T b);
    public T Pop() { return default(T); }
    public int Size() { return default(int); }
    public T Top() { return default(T); }
    public T UpdateTop() { return default(T); }
  }
  public sealed partial class RamUsageEstimator {
    public RamUsageEstimator() { }
    public RamUsageEstimator(Lucene.Net.Util.MemoryModel memoryModel) { }
    public RamUsageEstimator(Lucene.Net.Util.MemoryModel memoryModel, bool checkInterned) { }
    public RamUsageEstimator(bool checkInterned) { }
    public long EstimateRamUsage(object obj) { return default(long); }
    public static string HumanReadableUnits(long bytes, System.IFormatProvider df) { return default(string); }
  }
  public partial class ReaderUtil {
    public ReaderUtil() { }
    public static void GatherSubReaders(System.Collections.Generic.IList<Lucene.Net.Index.IndexReader> allSubReaders, Lucene.Net.Index.IndexReader reader) { }
    public static int SubIndex(int n, System.Int32[] docStarts) { return default(int); }
    public static Lucene.Net.Index.IndexReader SubReader(Lucene.Net.Index.IndexReader reader, int subIndex) { return default(Lucene.Net.Index.IndexReader); }
    public static Lucene.Net.Index.IndexReader SubReader(int doc, Lucene.Net.Index.IndexReader reader) { return default(Lucene.Net.Index.IndexReader); }
  }
  public partial class ScorerDocQueue {
    public ScorerDocQueue(int maxSize) { }
    public void AdjustTop() { }
    public void Clear() { }
    public virtual bool Insert(Lucene.Net.Search.Scorer scorer) { return default(bool); }
    public Lucene.Net.Search.Scorer Pop() { return default(Lucene.Net.Search.Scorer); }
    public void Put(Lucene.Net.Search.Scorer scorer) { }
    public int Size() { return default(int); }
    public Lucene.Net.Search.Scorer Top() { return default(Lucene.Net.Search.Scorer); }
    public int TopDoc() { return default(int); }
    public bool TopNextAndAdjustElsePop() { return default(bool); }
    public float TopScore() { return default(float); }
    public bool TopSkipToAndAdjustElsePop(int target) { return default(bool); }
  }
  public partial class SimpleStringInterner : Lucene.Net.Util.StringInterner {
    public SimpleStringInterner(int tableSize, int maxChainLength) { }
    public override string Intern(string s) { return default(string); }
  }
  public partial class SmallFloat {
    public SmallFloat() { }
    public static float Byte315ToFloat(byte b) { return default(float); }
    public static float Byte52ToFloat(byte b) { return default(float); }
    public static float ByteToFloat(byte b, int numMantissaBits, int zeroExp) { return default(float); }
    public static sbyte FloatToByte(float f, int numMantissaBits, int zeroExp) { return default(sbyte); }
    public static sbyte FloatToByte315(float f) { return default(sbyte); }
    public static sbyte FloatToByte52(float f) { return default(sbyte); }
  }
  public partial class SortedVIntList : Lucene.Net.Search.DocIdSet {
    public SortedVIntList(Lucene.Net.Search.DocIdSetIterator docIdSetIterator) { }
    public SortedVIntList(Lucene.Net.Util.OpenBitSet bits) { }
    public SortedVIntList(System.Collections.BitArray bits) { }
    public SortedVIntList(params System.Int32[] sortedInts) { }
    public SortedVIntList(System.Int32[] sortedInts, int inputSize) { }
    public virtual int ByteSize { get { return default(int); } }
    public override bool IsCacheable { get { return default(bool); } }
    public virtual int Size { get { return default(int); } }
    public override Lucene.Net.Search.DocIdSetIterator Iterator() { return default(Lucene.Net.Search.DocIdSetIterator); }
  }
  public abstract partial class SorterTemplate {
    protected SorterTemplate() { }
    protected internal abstract int Compare(int i, int j);
    protected internal virtual void MergeSort(int lo, int hi) { }
    public virtual void QuickSort(int lo, int hi) { }
    protected internal abstract void Swap(int i, int j);
  }
  public abstract partial class StringHelper {
    internal StringHelper() { }
    public static Lucene.Net.Util.StringInterner interner;
    public static int BytesDifference(System.Byte[] bytes1, int len1, System.Byte[] bytes2, int len2) { return default(int); }
    public static string Intern(string s) { return default(string); }
    public static int StringDifference(string s1, string s2) { return default(int); }
  }
  public partial class StringInterner {
    public StringInterner() { }
    public virtual string Intern(System.Char[] arr, int offset, int len) { return default(string); }
    public virtual string Intern(string s) { return default(string); }
  }
  public partial class ToStringUtils {
    public ToStringUtils() { }
    public static string Boost(float boost) { return default(string); }
  }
  public static partial class UnicodeUtil {
    public const int UNI_REPLACEMENT_CHAR = 65533;
    public const int UNI_SUR_HIGH_END = 56319;
    public const int UNI_SUR_HIGH_START = 55296;
    public const int UNI_SUR_LOW_END = 57343;
    public const int UNI_SUR_LOW_START = 56320;
    public static void UTF16toUTF8(System.Char[] source, int offset, Lucene.Net.Util.UnicodeUtil.UTF8Result result) { }
    public static void UTF16toUTF8(System.Char[] source, int offset, int length, Lucene.Net.Util.UnicodeUtil.UTF8Result result) { }
    public static void UTF16toUTF8(string s, int offset, int length, Lucene.Net.Util.UnicodeUtil.UTF8Result result) { }
    public static void UTF8toUTF16(System.Byte[] utf8, int offset, int length, Lucene.Net.Util.UnicodeUtil.UTF16Result result) { }
    public sealed partial class UTF16Result {
      public int length;
      public System.Int32[] offsets;
      public System.Char[] result;
      public UTF16Result() { }
      public void CopyText(Lucene.Net.Util.UnicodeUtil.UTF16Result other) { }
      public void SetLength(int newLength) { }
    }
    public sealed partial class UTF8Result {
      public int length;
      public System.Byte[] result;
      public UTF8Result() { }
      public void SetLength(int newLength) { }
    }
  }
  public enum Version {
    LUCENE_20 = 0,
    LUCENE_21 = 1,
    LUCENE_22 = 2,
    LUCENE_23 = 3,
    LUCENE_24 = 4,
    LUCENE_29 = 5,
    LUCENE_30 = 6,
    [System.ObsoleteAttribute("Use an actual version instead.")]
    LUCENE_CURRENT = 7,
  }
  public static partial class VersionEnumExtensions {
    public static bool OnOrAfter(this Lucene.Net.Util.Version first, Lucene.Net.Util.Version other) { return default(bool); }
  }
}
namespace Lucene.Net.Util.Cache {
  public abstract partial class Cache<TKey, TValue> : System.IDisposable {
    protected Cache() { }
    [System.ObsoleteAttribute("Use Dispose() instead")]
    public void Close() { }
    public abstract bool ContainsKey(object key);
    public void Dispose() { }
    protected abstract void Dispose(bool disposing);
    public abstract TValue Get(object key);
    public abstract void Put(TKey key, TValue value_Renamed);
    public static Lucene.Net.Util.Cache.Cache<TKey, TValue> SynchronizedCache(Lucene.Net.Util.Cache.Cache<TKey, TValue> cache) { return default(Lucene.Net.Util.Cache.Cache<TKey, TValue>); }
  }
  public partial class SimpleLRUCache<TKey, TValue> : Lucene.Net.Util.Cache.SimpleMapCache<TKey, TValue> {
    public SimpleLRUCache(int Capacity) { }
    public override TValue Get(object Key) { return default(TValue); }
    public override void Put(TKey Key, TValue Value) { }
  }
  public partial class SimpleMapCache<TKey, TValue> : Lucene.Net.Util.Cache.Cache<TKey, TValue> {
    public SimpleMapCache() { }
    public SimpleMapCache(System.Collections.Generic.Dictionary<TKey, TValue> map) { }
    public override bool ContainsKey(object key) { return default(bool); }
    protected override void Dispose(bool disposing) { }
    public override TValue Get(object key) { return default(TValue); }
    public virtual System.Collections.Generic.HashSet<TKey> KeySet() { return default(System.Collections.Generic.HashSet<TKey>); }
    public override void Put(TKey key, TValue value_Renamed) { }
  }
}
namespace Mono.Documentation {
  public delegate System.Xml.XmlDocument DocLoader(string escapedTypeName);
  public partial class ManifestResourceResolver : System.Xml.XmlUrlResolver {
    public ManifestResourceResolver(params System.String[] dirs) { }
    public override object GetEntity(System.Uri absoluteUri, string role, System.Type ofObjectToReturn) { return default(object); }
    public override System.Uri ResolveUri(System.Uri baseUri, string relativeUri) { return default(System.Uri); }
  }
  public static partial class XmlDocUtils {
    public static void AddExtensionMethods(System.Xml.XmlDocument typexml, System.Collections.ArrayList extensions, Mono.Documentation.DocLoader loader) { }
    public static string GetCachedFileName(string cacheDir, string url) { return default(string); }
    public static string GetCacheDirectory(string assembledBase) { return default(string); }
    public static System.Xml.XmlNodeList GetMemberGenericParameters(System.Xml.XmlNode member) { return default(System.Xml.XmlNodeList); }
    public static System.Xml.XmlNodeList GetTypeGenericParameters(System.Xml.XmlNode member) { return default(System.Xml.XmlNodeList); }
    public static string ToEscapedMemberName(string member) { return default(string); }
    public static string ToEscapedTypeName(string name) { return default(string); }
    public static string ToTypeName(string type, System.Xml.XmlNode member) { return default(string); }
    public static string ToTypeName(string type, System.Xml.XmlNodeList typeGenParams, System.Xml.XmlNodeList memberGenParams) { return default(string); }
  }
}
namespace Mono.Utilities {
  public partial class Colorizer {
    public Colorizer() { }
    public static string Colorize(string text, string lang) { return default(string); }
  }
  public partial class LRUCache<TKey, TValue> {
    public LRUCache(int capacity) { }
    public static Mono.Utilities.LRUCache<TKey, TValue> Default { get { return default(Mono.Utilities.LRUCache<TKey, TValue>); } }
    public TValue Get(TKey key) { return default(TValue); }
    public void Put(TKey key, TValue value) { }
  }
}
namespace Monodoc {
  public static partial class Config {
    public static System.Configuration.KeyValueConfigurationCollection AppSettings { get { return default(System.Configuration.KeyValueConfigurationCollection); } }
    public static System.Configuration.KeyValueConfigurationCollection LibSettings { get { return default(System.Configuration.KeyValueConfigurationCollection); } }
    public static string Get(string key) { return default(string); }
  }
  public static partial class DocCacheHelper {
    public static Monodoc.IDocCache GetDefaultCache(string name) { return default(Monodoc.IDocCache); }
  }
  public enum DocEntity {
    Blob = 1,
    Text = 0,
  }
  public static partial class DocRevisionManagerExtensions {
    public static System.IO.Stream RetrieveLatestRevision(this Monodoc.IDocRevisionManager revManager, string id) { return default(System.IO.Stream); }
  }
  public static partial class DocStorageExtensions {
    public static bool TryRetrieve(this Monodoc.IDocStorage storage, string id, out System.IO.Stream stream) { stream = default(System.IO.Stream); return default(bool); }
  }
  public enum DocumentType {
    AddinXml = 3,
    EcmaSpecXml = 1,
    EcmaXml = 0,
    ErrorXml = 8,
    Html = 5,
    Man = 2,
    MonoBook = 4,
    PlainText = 7,
    TocXml = 6,
  }
  public partial class HelpSource {
    [System.ObsoleteAttribute]
    public static bool FullHtml;
    [System.ObsoleteAttribute]
    public static bool use_css;
    [System.ObsoleteAttribute]
    public static bool UseWebdocCache;
    public HelpSource() { }
    public HelpSource(string base_filename, bool create) { }
    public string BaseDir { get { return default(string); } }
    public string BaseFilePath { get { return default(string); } }
    public Monodoc.IDocCache Cache { get { return default(Monodoc.IDocCache); } }
    [System.ObsoleteAttribute("Use Monodoc.Providers.HtmlGenerator.InlineCss")]
    public string InlineCss { get { return default(string); } }
    [System.ObsoleteAttribute]
    public string InlineJavaScript { get { return default(string); } }
    public string Name { get { return default(string); } }
    public Monodoc.RootTree RootTree { get { return default(Monodoc.RootTree); } set { } }
    public virtual Monodoc.SortType SortType { get { return default(Monodoc.SortType); } }
    public int SourceID { get { return default(int); } }
    public Monodoc.IDocStorage Storage { get { return default(Monodoc.IDocStorage); } protected set { } }
    public System.Diagnostics.TraceLevel TraceLevel { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Diagnostics.TraceLevel); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Monodoc.Tree Tree { get { return default(Monodoc.Tree); } }
    protected virtual string UriPrefix { get { return default(string); } }
    public virtual bool CanHandleUrl(string url) { return default(bool); }
    public virtual System.IO.Stream GetCachedHelpStream(string id) { return default(System.IO.Stream); }
    public virtual string GetCachedText(string id) { return default(string); }
    public virtual Monodoc.DocumentType GetDocumentTypeForId(string id) { return default(Monodoc.DocumentType); }
    public virtual System.IO.Stream GetHelpStream(string id) { return default(System.IO.Stream); }
    public System.Xml.XmlReader GetHelpXml(string id) { return default(System.Xml.XmlReader); }
    public virtual System.Xml.XmlDocument GetHelpXmlWithChanges(string id) { return default(System.Xml.XmlDocument); }
    public virtual System.IO.Stream GetImage(string url) { return default(System.IO.Stream); }
    public virtual string GetInternalIdForUrl(string url, out Monodoc.Node node, out System.Collections.Generic.Dictionary<System.String, System.String> context) { node = default(Monodoc.Node); context = default(System.Collections.Generic.Dictionary<System.String, System.String>); return default(string); }
    public virtual string GetPublicUrl(Monodoc.Node node) { return default(string); }
    public virtual string GetText(string id) { return default(string); }
    [System.ObsoleteAttribute("Use RenderUrl")]
    public string GetText(string url, out Monodoc.Node node) { node = default(Monodoc.Node); return default(string); }
    public virtual bool IsGeneratedContent(string id) { return default(bool); }
    public virtual bool IsMultiPart(string id, out System.Collections.Generic.IEnumerable<System.String> parts) { parts = default(System.Collections.Generic.IEnumerable<System.String>); return default(bool); }
    public virtual bool IsRawContent(string id) { return default(bool); }
    public virtual Monodoc.Node MatchNode(string url) { return default(Monodoc.Node); }
    public virtual void PopulateIndex(Monodoc.IndexMaker index_maker) { }
    public virtual void PopulateSearchableIndex(Lucene.Net.Index.IndexWriter writer) { }
    [System.ObsoleteAttribute("Use RenderUrl")]
    public string RenderNamespaceLookup(string url, out Monodoc.Node node) { node = default(Monodoc.Node); return default(string); }
    public virtual void RenderPreviewDocs(System.Xml.XmlNode newNode, System.Xml.XmlWriter writer) { }
    public void Save() { }
  }
  public partial interface IDocCache : System.IDisposable {
    void CacheBlob(string id, System.Byte[] data);
    void CacheBlob(string id, System.IO.Stream stream);
    void CacheText(string id, System.IO.Stream stream);
    void CacheText(string id, string content);
    bool CanCache(Monodoc.DocEntity entity);
    System.IO.Stream GetCachedStream(string id);
    string GetCachedString(string id);
    bool IsCached(string id);
  }
  public partial interface IDocGenerator<TOutput> {
    TOutput Generate(Monodoc.HelpSource hs, string internalId, System.Collections.Generic.Dictionary<System.String, System.String> context);
  }
  public partial interface IDocRevisionManager {
    System.Collections.Generic.IEnumerable<System.String> AvailableRevisionsForId(string id);
    string GetRevisionDescription(string revision);
    string LatestRevisionForId(string id);
    System.IO.Stream RetrieveWithRevision(string id, string revision);
  }
  public partial interface IDocStorage : System.IDisposable {
    Monodoc.IDocRevisionManager RevisionManager { get; }
    bool SupportChange { get; }
    bool SupportRevision { get; }
    System.Collections.Generic.IEnumerable<System.String> GetAvailableIds();
    System.IO.Stream Retrieve(string id);
    string Store(string id, System.Byte[] data);
    string Store(string id, System.IO.Stream stream);
    string Store(string id, string text);
  }
  public partial interface IListModel {
    int Rows { get; }
    string GetDescription(int row);
    string GetValue(int row);
  }
  public partial class IndexEntry {
    public IndexEntry() { }
    public IndexEntry(System.IO.FileStream fs, System.IO.BinaryReader reader, int position) { }
    public int Count { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    public Monodoc.Topic this[int idx] { get { return default(Monodoc.Topic); } }
    public int Position { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    public System.Collections.Generic.IList<Monodoc.Topic> Topics { get { return default(System.Collections.Generic.IList<Monodoc.Topic>); } }
    public void Add(Monodoc.Topic t) { }
    public void WriteTopics(Monodoc.IndexMaker maker, System.IO.Stream stream, System.IO.BinaryWriter writer) { }
  }
  public partial class IndexMaker {
    public IndexMaker() { }
    public void Add(string caption, string sort_key, string url) { }
    public void AddTopic(Monodoc.Topic topic) { }
    public int GetCode(string s) { return default(int); }
    public void Save(string filename) { }
  }
  public partial class IndexReader : Monodoc.IListModel {
    internal IndexReader() { }
    public int Rows { get { return default(int); } }
    public string GetDescription(int row) { return default(string); }
    public Monodoc.IndexEntry GetIndexEntry(int row) { return default(Monodoc.IndexEntry); }
    public string GetValue(int row) { return default(string); }
    public static Monodoc.IndexReader Load(string filename) { return default(Monodoc.IndexReader); }
  }
  public partial class Node : System.IComparable, System.IComparable<Monodoc.Node> {
    public bool Documented;
    public Node(Monodoc.Node parent, string caption, string element) { }
    [System.ObsoleteAttribute("Tree inheriting Node is being phased out. Use the `Tree.RootNode' property instead")]
    public Node(string caption, string element) { }
    public string Caption { get { return default(string); } }
    public System.Collections.Generic.IList<Monodoc.Node> ChildNodes { get { return default(System.Collections.Generic.IList<Monodoc.Node>); } }
    public string Element { get { return default(string); } set { } }
    public bool IsLeaf { get { return default(bool); } }
    [System.ObsoleteAttribute("Use ChildNodes")]
    public System.Collections.ArrayList Nodes { get { return default(System.Collections.ArrayList); } }
    public Monodoc.Node Parent { get { return default(Monodoc.Node); } }
    public string PublicUrl { get { return default(string); } }
    [System.ObsoleteAttribute("Use `Tree' instead of 'tree'")]
    public Monodoc.Tree tree { get { return default(Monodoc.Tree); } }
    public Monodoc.Tree Tree { get { return default(Monodoc.Tree); } }
    public void AddNode(Monodoc.Node n) { }
    public Monodoc.Node CreateNode(string c_caption, string c_element) { return default(Monodoc.Node); }
    public void DeleteNode(Monodoc.Node n) { }
    public void EnsureLoaded() { }
    public void EnsureNodes() { }
    public Monodoc.Node GetOrCreateNode(string c_caption, string c_element) { return default(Monodoc.Node); }
    [System.ObsoleteAttribute("Use TreeDumper")]
    public static void PrintTree(Monodoc.Tree t) { }
    public void Sort() { }
    int System.IComparable.CompareTo(object obj) { return default(int); }
    int System.IComparable<Monodoc.Node>.CompareTo(Monodoc.Node obj) { return default(int); }
  }
  public abstract partial class Provider {
    public Provider() { }
    public int Code { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public abstract void CloseTree(Monodoc.HelpSource hs, Monodoc.Tree tree);
    public abstract void PopulateTree(Monodoc.Tree tree);
  }
  public partial class Result {
    public Result(string Term, Lucene.Net.Search.Searcher searcher, Lucene.Net.Search.ScoreDoc[] docs) { }
    public int Count { get { return default(int); } }
    public Lucene.Net.Documents.Document this[int i] { get { return default(Lucene.Net.Documents.Document); } }
    public string Term { get { return default(string); } }
    public string GetFullTitle(int i) { return default(string); }
    public string GetTitle(int i) { return default(string); }
    public string GetUrl(int i) { return default(string); }
    public float Score(int i) { return default(float); }
  }
  public partial class RootTree : Monodoc.Tree {
    internal RootTree() : base (default(Monodoc.HelpSource), default(string)) { }
    public const int MonodocVersion = 2;
    public System.Collections.Generic.IList<Monodoc.HelpSource> HelpSources { get { return default(System.Collections.Generic.IList<Monodoc.HelpSource>); } }
    public System.DateTime LastHelpSourceTime { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.DateTime); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public void AddSource(string sourcesDir) { }
    public bool AddSourceFile(string sourceFile) { return default(bool); }
    public static void AddUncompiledSource(string path) { }
    public bool GenerateIndex() { return default(bool); }
    public bool GenerateSearchIndex() { return default(bool); }
    public static Monodoc.HelpSource GetHelpSource(string provider, string basefilepath) { return default(Monodoc.HelpSource); }
    public Monodoc.HelpSource GetHelpSourceAndIdForUrl(string url, Monodoc.HelpSource hintSource, out string internalId, out System.Collections.Generic.Dictionary<System.String, System.String> context, out Monodoc.Node node) { internalId = default(string); context = default(System.Collections.Generic.Dictionary<System.String, System.String>); node = default(Monodoc.Node); return default(Monodoc.HelpSource); }
    public Monodoc.HelpSource GetHelpSourceAndIdForUrl(string url, out string internalId, out System.Collections.Generic.Dictionary<System.String, System.String> context) { internalId = default(string); context = default(System.Collections.Generic.Dictionary<System.String, System.String>); return default(Monodoc.HelpSource); }
    public Monodoc.HelpSource GetHelpSourceAndIdForUrl(string url, out string internalId, out System.Collections.Generic.Dictionary<System.String, System.String> context, out Monodoc.Node node) { internalId = default(string); context = default(System.Collections.Generic.Dictionary<System.String, System.String>); node = default(Monodoc.Node); return default(Monodoc.HelpSource); }
    public Monodoc.HelpSource GetHelpSourceAndIdFromName(string name, out string internalId, out Monodoc.Node node) { internalId = default(string); node = default(Monodoc.Node); return default(Monodoc.HelpSource); }
    public Monodoc.HelpSource GetHelpSourceFromId(int id) { return default(Monodoc.HelpSource); }
    [System.ObsoleteAttribute("Use RawGenerator directly")]
    public System.Xml.XmlDocument GetHelpXml(string id) { return default(System.Xml.XmlDocument); }
    public System.IO.Stream GetImage(string url) { return default(System.IO.Stream); }
    public Monodoc.IndexReader GetIndex() { return default(Monodoc.IndexReader); }
    public static Monodoc.Provider GetProvider(string provider, params System.String[] basefilepaths) { return default(Monodoc.Provider); }
    public Monodoc.SearchableIndex GetSearchIndex() { return default(Monodoc.SearchableIndex); }
    public static System.String[] GetSupportedFormats() { return default(System.String[]); }
    [System.ObsoleteAttribute]
    public string GetTitle(string url) { return default(string); }
    public static Monodoc.RootTree LoadTree() { return default(Monodoc.RootTree); }
    public static Monodoc.RootTree LoadTree(string basedir, bool includeExternal=true) { return default(Monodoc.RootTree); }
    public static Monodoc.RootTree LoadTree(string indexDir, System.Xml.XmlDocument docTree, System.Collections.Generic.IEnumerable<System.String> sourceFiles) { return default(Monodoc.RootTree); }
    public Monodoc.Node LookupEntryPoint(string name) { return default(Monodoc.Node); }
    public static void MakeIndex() { }
    [System.ObsoleteAttribute("Use GenerateIndex")]
    public static void MakeIndex(Monodoc.RootTree root) { }
    public static void MakeSearchIndex() { }
    [System.ObsoleteAttribute("Use GenerateSearchIndex")]
    public static void MakeSearchIndex(Monodoc.RootTree root) { }
    [System.ObsoleteAttribute("Use the RenderUrl variant accepting a generator")]
    public string RenderUrl(string url, out Monodoc.Node n) { n = default(Monodoc.Node); return default(string); }
    public TOutput RenderUrl<TOutput>(string url, Monodoc.IDocGenerator<TOutput> generator, Monodoc.HelpSource hintSource=null) { return default(TOutput); }
    public TOutput RenderUrl<TOutput>(string url, Monodoc.IDocGenerator<TOutput> generator, out Monodoc.Node node, Monodoc.HelpSource hintSource=null) { node = default(Monodoc.Node); return default(TOutput); }
  }
  public partial class SearchableIndex {
    public SearchableIndex() { }
    public string Dir { get { return default(string); } set { } }
    public Monodoc.Result FastSearch(string term, int number) { return default(Monodoc.Result); }
    public static Monodoc.SearchableIndex Load(string dir) { return default(Monodoc.SearchableIndex); }
    public Monodoc.Result Search(string term) { return default(Monodoc.Result); }
    public Monodoc.Result Search(string term, int count) { return default(Monodoc.Result); }
    public Monodoc.Result Search(string term, int count, int start) { return default(Monodoc.Result); }
  }
  [System.ObsoleteAttribute]
  public partial class Settings {
    [System.ObsoleteAttribute]
    public string Email;
    [System.ObsoleteAttribute]
    public bool EnableEditing;
    [System.ObsoleteAttribute]
    public string Key;
    [System.ObsoleteAttribute]
    public int LastSeenVersion;
    [System.ObsoleteAttribute]
    public string preferred_font_family;
    [System.ObsoleteAttribute]
    public double preferred_font_size;
    [System.ObsoleteAttribute]
    public static bool RunningGUI;
    [System.ObsoleteAttribute]
    public int SerialNumber;
    [System.ObsoleteAttribute]
    public bool ShowComments;
    [System.ObsoleteAttribute]
    public bool ShowInheritedMembers;
    public Settings() { }
  }
  [System.ObsoleteAttribute]
  public partial class SettingsHandler {
    [System.ObsoleteAttribute]
    public static string Path;
    [System.ObsoleteAttribute]
    public static Monodoc.Settings Settings;
    public SettingsHandler() { }
    [System.ObsoleteAttribute]
    public static void CheckUpgrade() { }
    [System.ObsoleteAttribute]
    public static void EnsureSettingsDirectory() { }
    [System.ObsoleteAttribute]
    public static void Save() { }
  }
  public enum SortType {
    Caption = 0,
    Element = 1,
  }
  public partial class Topic {
    public readonly string Caption;
    public readonly string SortKey;
    public readonly string Url;
    public Topic(string caption, string sort_key, string url) { }
  }
  public partial class Tree : Monodoc.Node {
    public const long CurrentVersionNumber = (long)1;
    public readonly Monodoc.HelpSource HelpSource;
    public Tree(Monodoc.HelpSource hs, Monodoc.Node parent, string caption, string element) : base (default(string), default(string)) { }
    public Tree(Monodoc.HelpSource hs, string filename) : base (default(string), default(string)) { }
    public Tree(Monodoc.HelpSource hs, string caption, string url) : base (default(string), default(string)) { }
    public Monodoc.Node RootNode { get { return default(Monodoc.Node); } }
    public long VersionNumber { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(long); } }
    public void InflateNode(Monodoc.Node baseNode) { }
    public void Save(string file) { }
  }
  public static partial class TreeDumper {
    public static string ExportToTocXml(Monodoc.Node root, string title, string desc) { return default(string); }
    public static void PrintTree(Monodoc.Node node) { }
  }
  public static partial class TypeUtils {
    public static bool GetNamespaceAndType(string url, out string ns, out string type) { ns = default(string); type = default(string); return default(bool); }
  }
}
namespace Monodoc.Caches {
  public partial class FileCache : Monodoc.IDocCache, System.IDisposable {
    public FileCache(string baseCacheDir) { }
    public void CacheBlob(string id, System.Byte[] data) { }
    public void CacheBlob(string id, System.IO.Stream stream) { }
    public void CacheText(string id, System.IO.Stream stream) { }
    public void CacheText(string id, string content) { }
    public bool CanCache(Monodoc.DocEntity entity) { return default(bool); }
    public void Dispose() { }
    public System.IO.Stream GetCachedStream(string id) { return default(System.IO.Stream); }
    public string GetCachedString(string id) { return default(string); }
    public bool IsCached(string id) { return default(bool); }
  }
  public partial class NullCache : Monodoc.IDocCache, System.IDisposable {
    public NullCache() { }
    public void CacheBlob(string id, System.Byte[] data) { }
    public void CacheBlob(string id, System.IO.Stream stream) { }
    public void CacheText(string id, System.IO.Stream stream) { }
    public void CacheText(string id, string content) { }
    public bool CanCache(Monodoc.DocEntity entity) { return default(bool); }
    public void Dispose() { }
    public System.IO.Stream GetCachedStream(string id) { return default(System.IO.Stream); }
    public string GetCachedString(string id) { return default(string); }
    public bool IsCached(string id) { return default(bool); }
  }
}
namespace Monodoc.Ecma {
  public partial class EcmaDesc : System.IEquatable<Monodoc.Ecma.EcmaDesc> {
    public EcmaDesc() { }
    public System.Collections.Generic.IList<System.Int32> ArrayDimensions { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IList<System.Int32>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Monodoc.Ecma.EcmaDesc.Kind DescKind { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Monodoc.Ecma.EcmaDesc.Kind); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Monodoc.Ecma.EcmaDesc.Mod DescModifier { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Monodoc.Ecma.EcmaDesc.Mod); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public char Etc { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(char); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string EtcFilter { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Monodoc.Ecma.EcmaDesc ExplicitImplMember { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Monodoc.Ecma.EcmaDesc); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.Generic.IList<Monodoc.Ecma.EcmaDesc> GenericMemberArguments { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IList<Monodoc.Ecma.EcmaDesc>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public int GenericMemberArgumentsCount { get { return default(int); } }
    public bool GenericMemberArgumentsIsNumeric { get { return default(bool); } }
    public System.Collections.Generic.IList<Monodoc.Ecma.EcmaDesc> GenericTypeArguments { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IList<Monodoc.Ecma.EcmaDesc>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public int GenericTypeArgumentsCount { get { return default(int); } }
    public bool GenericTypeArgumentsIsNumeric { get { return default(bool); } }
    public bool IsEtc { get { return default(bool); } }
    public System.Collections.Generic.IList<Monodoc.Ecma.EcmaDesc> MemberArguments { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IList<Monodoc.Ecma.EcmaDesc>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public int MemberArgumentsCount { get { return default(int); } }
    public string MemberName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Namespace { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Monodoc.Ecma.EcmaDesc NestedType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Monodoc.Ecma.EcmaDesc); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string TypeName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool Equals(Monodoc.Ecma.EcmaDesc other) { return default(bool); }
    public override bool Equals(object other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public string ToCompleteMemberName(Monodoc.Ecma.EcmaDesc.Format format) { return default(string); }
    public string ToCompleteTypeName(char innerTypeSeparator='.') { return default(string); }
    public string ToEcmaCref() { return default(string); }
    public override string ToString() { return default(string); }
    public enum Format {
      WithArgs = 0,
      WithoutArgs = 1,
    }
    public enum Kind {
      Constructor = 1,
      Event = 6,
      Field = 4,
      Method = 2,
      Namespace = 3,
      Operator = 7,
      Property = 5,
      Type = 0,
    }
    public enum Mod {
      Normal = 0,
      Out = 3,
      Pointer = 1,
      Ref = 2,
    }
  }
  public partial class EcmaUrlParser {
    public int eof_token;
    public System.IO.TextWriter ErrorOutput;
    protected bool use_global_stacks;
    protected static readonly System.Int16[] yyCheck;
    protected static readonly System.Int16[] yyDgoto;
    protected const int yyFinal = 9;
    protected static readonly System.Int16[] yyGindex;
    protected int yyMax;
    protected static readonly System.String[] yyNames;
    protected static readonly System.Int16[] yyRindex;
    protected static readonly System.Int16[] yySindex;
    protected static readonly System.Int16[] yyTable;
    public EcmaUrlParser() { }
    public void IsValid(string input) { }
    public Monodoc.Ecma.EcmaDesc Parse(string input) { return default(Monodoc.Ecma.EcmaDesc); }
    public bool TryParse(string input, out Monodoc.Ecma.EcmaDesc desc) { desc = default(Monodoc.Ecma.EcmaDesc); return default(bool); }
    protected object yyDefault(object first) { return default(object); }
    public void yyerror(string message) { }
    public void yyerror(string message, System.String[] expected) { }
    protected System.String[] yyExpecting(int state) { return default(System.String[]); }
    protected System.Int32[] yyExpectingTokens(int state) { return default(System.Int32[]); }
    public static string yyname(int token) { return default(string); }
  }
  public partial class EcmaUrlTokenizer {
    public EcmaUrlTokenizer(string input) { }
    public object Value { get { return default(object); } }
    public bool advance() { return default(bool); }
    public int token() { return default(int); }
    public object value() { return default(object); }
  }
}
namespace Monodoc.Generators {
  public partial class HtmlGenerator : Monodoc.IDocGenerator<System.String> {
    public HtmlGenerator(Monodoc.IDocCache defaultCache) { }
    public static string InlineCss { get { return default(string); } set { } }
    public string Generate(Monodoc.HelpSource hs, string id, System.Collections.Generic.Dictionary<System.String, System.String> context) { return default(string); }
  }
  public partial class RawGenerator : Monodoc.IDocGenerator<System.String> {
    public RawGenerator() { }
    public string Generate(Monodoc.HelpSource hs, string id, System.Collections.Generic.Dictionary<System.String, System.String> context) { return default(string); }
  }
}
namespace Monodoc.Generators.Html {
  public partial class Addin2Html {
    public Addin2Html() { }
    public string CssCode { get { return default(string); } }
    public string Export(System.IO.Stream stream, System.Collections.Generic.Dictionary<System.String, System.String> extraArgs) { return default(string); }
    public string Export(string input, System.Collections.Generic.Dictionary<System.String, System.String> extraArgs) { return default(string); }
    protected string GetAddinTextFromUrl(System.Xml.XmlElement addin, string addinId, string fileId) { return default(string); }
    protected string GetExtensionNodeTextFromUrl(System.Xml.XmlElement addin, string addinId, string fileId, string nodeId) { return default(string); }
    protected string GetExtensionTextFromUrl(System.Xml.XmlElement addin, string addinId, string fileId, string path) { return default(string); }
    public string Htmlize(System.Xml.XmlElement addin, string urlType, string addinId, string fileId, string path) { return default(string); }
  }
  public partial class Ecma2Html {
    public Ecma2Html() { }
    public string CssCode { get { return default(string); } }
    public string JsCode { get { return default(string); } }
    protected virtual System.Xml.XmlResolver CreateDocumentResolver() { return default(System.Xml.XmlResolver); }
    public string Export(System.IO.Stream stream, System.Collections.Generic.Dictionary<System.String, System.String> extraArgs) { return default(string); }
    public string Export(string input, System.Collections.Generic.Dictionary<System.String, System.String> extraArgs) { return default(string); }
    public string Htmlize(System.Xml.XmlReader ecma_xml, System.Collections.Generic.Dictionary<System.String, System.String> extraArgs) { return default(string); }
    public string Htmlize(System.Xml.XmlReader ecma_xml, System.Xml.Xsl.XsltArgumentList args) { return default(string); }
    public partial class ExtensionObject {
      public ExtensionObject() { }
      public string Colorize(string code, string lang) { return default(string); }
      public bool IsToBeAdded(string text) { return default(bool); }
      public string MakeNiceSignature(string sig, string contexttype) { return default(string); }
      public bool MonoEditing() { return default(bool); }
      public string MonoImpInfo(string assemblyname, string typename, bool strlong) { return default(string); }
    }
  }
  public partial class Ecmaspec2Html {
    public Ecmaspec2Html() { }
    public string CssCode { get { return default(string); } }
    public string Export(System.IO.Stream stream, System.Collections.Generic.Dictionary<System.String, System.String> extraArgs) { return default(string); }
    public string Export(string input, System.Collections.Generic.Dictionary<System.String, System.String> extraArgs) { return default(string); }
  }
  public partial class Error2Html {
    public Error2Html() { }
    public string CssCode { get { return default(string); } }
    public string Export(System.IO.Stream input, System.Collections.Generic.Dictionary<System.String, System.String> extraArgs) { return default(string); }
    public string Export(string input, System.Collections.Generic.Dictionary<System.String, System.String> extraArgs) { return default(string); }
    public string Htmlize(System.Xml.XPath.IXPathNavigable doc) { return default(string); }
  }
  public partial class Idem {
    public Idem() { }
    public string CssCode { get { return default(string); } }
    public string Export(System.IO.Stream input, System.Collections.Generic.Dictionary<System.String, System.String> extraArgs) { return default(string); }
    public string Export(string input, System.Collections.Generic.Dictionary<System.String, System.String> extraArgs) { return default(string); }
  }
  public partial class Man2Html {
    public Man2Html() { }
    public string CssCode { get { return default(string); } }
    public string Export(System.IO.Stream input, System.Collections.Generic.Dictionary<System.String, System.String> extraArgs) { return default(string); }
    public string Export(string input, System.Collections.Generic.Dictionary<System.String, System.String> extraArgs) { return default(string); }
    public static string GetTextFromReader(System.IO.TextReader file) { return default(string); }
  }
  public partial class MonoBook2Html {
    public MonoBook2Html() { }
    public string CssCode { get { return default(string); } }
    public string Export(System.IO.Stream input, System.Collections.Generic.Dictionary<System.String, System.String> extraArgs) { return default(string); }
    public string Export(string input, System.Collections.Generic.Dictionary<System.String, System.String> extraArgs) { return default(string); }
    public string FromXmlReader(System.Xml.XmlReader reader) { return default(string); }
  }
  public partial class Toc2Html {
    public Toc2Html() { }
    public string CssCode { get { return default(string); } }
    public string Export(System.IO.Stream input, System.Collections.Generic.Dictionary<System.String, System.String> extraArgs) { return default(string); }
    public string Export(string input, System.Collections.Generic.Dictionary<System.String, System.String> extraArgs) { return default(string); }
  }
}
namespace Monodoc.Providers {
  public partial class AddinsHelpSource : Monodoc.HelpSource {
    protected internal const string AddinPrefix = "addin:";
    protected internal const string ExtensionNodePrefix = "extension-node:";
    protected internal const string ExtensionPrefix = "extension-point:";
    public AddinsHelpSource(string base_file, bool create) { }
    protected override string UriPrefix { get { return default(string); } }
    public override bool CanHandleUrl(string url) { return default(bool); }
    public override Monodoc.DocumentType GetDocumentTypeForId(string id) { return default(Monodoc.DocumentType); }
    public override string GetInternalIdForUrl(string url, out Monodoc.Node node, out System.Collections.Generic.Dictionary<System.String, System.String> context) { node = default(Monodoc.Node); context = default(System.Collections.Generic.Dictionary<System.String, System.String>); return default(string); }
    public override Monodoc.Node MatchNode(string url) { return default(Monodoc.Node); }
  }
  public partial class AddinsProvider : Monodoc.Provider {
    public AddinsProvider(string xmlModelFile) { }
    public override void CloseTree(Monodoc.HelpSource hs, Monodoc.Tree tree) { }
    public override void PopulateTree(Monodoc.Tree tree) { }
  }
  public partial class EcmaHelpSource : Monodoc.HelpSource {
    protected EcmaHelpSource() { }
    public EcmaHelpSource(string base_file, bool create) { }
    protected override string UriPrefix { get { return default(string); } }
    public override bool CanHandleUrl(string url) { return default(bool); }
    public override System.IO.Stream GetCachedHelpStream(string id) { return default(System.IO.Stream); }
    public override Monodoc.DocumentType GetDocumentTypeForId(string id) { return default(Monodoc.DocumentType); }
    public override System.IO.Stream GetHelpStream(string id) { return default(System.IO.Stream); }
    public string GetInternalIdForInternalUrl(string internalUrl, out string hash) { hash = default(string); return default(string); }
    public override string GetInternalIdForUrl(string url, out Monodoc.Node node, out System.Collections.Generic.Dictionary<System.String, System.String> context) { node = default(Monodoc.Node); context = default(System.Collections.Generic.Dictionary<System.String, System.String>); return default(string); }
    public override string GetPublicUrl(Monodoc.Node node) { return default(string); }
    public override Monodoc.Node MatchNode(string url) { return default(Monodoc.Node); }
    public override void PopulateIndex(Monodoc.IndexMaker index_maker) { }
    public override void PopulateSearchableIndex(Lucene.Net.Index.IndexWriter writer) { }
  }
  public enum EcmaNodeType {
    Invalid = 0,
    Member = 3,
    Meta = 4,
    Namespace = 1,
    Type = 2,
  }
  public partial class EcmaProvider : Monodoc.Provider {
    public EcmaProvider() { }
    public EcmaProvider(string baseDir) { }
    public Monodoc.Providers.IEcmaProviderFileSource FileSource { get { return default(Monodoc.Providers.IEcmaProviderFileSource); } set { } }
    public void AddDirectory(string directory) { }
    public override void CloseTree(Monodoc.HelpSource hs, Monodoc.Tree tree) { }
    public override void PopulateTree(Monodoc.Tree tree) { }
  }
  public partial class EcmaSpecHelpSource : Monodoc.HelpSource {
    public EcmaSpecHelpSource(string base_file, bool create) { }
    protected override string UriPrefix { get { return default(string); } }
    public override Monodoc.DocumentType GetDocumentTypeForId(string id) { return default(Monodoc.DocumentType); }
    public override System.IO.Stream GetHelpStream(string id) { return default(System.IO.Stream); }
    public override string GetText(string id) { return default(string); }
    public override bool IsGeneratedContent(string id) { return default(bool); }
    public override bool IsMultiPart(string id, out System.Collections.Generic.IEnumerable<System.String> parts) { parts = default(System.Collections.Generic.IEnumerable<System.String>); return default(bool); }
    public override void PopulateSearchableIndex(Lucene.Net.Index.IndexWriter writer) { }
  }
  public partial class EcmaSpecProvider : Monodoc.Provider {
    public EcmaSpecProvider(string base_directory) { }
    public override void CloseTree(Monodoc.HelpSource hs, Monodoc.Tree tree) { }
    public override void PopulateTree(Monodoc.Tree tree) { }
  }
  public partial class EcmaUncompiledHelpSource : Monodoc.Providers.EcmaHelpSource {
    public readonly string BasePath;
    public EcmaUncompiledHelpSource(string base_file, bool markName=true) { }
    public new string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    protected override string UriPrefix { get { return default(string); } }
    public override System.IO.Stream GetImage(string url) { return default(System.IO.Stream); }
  }
  public partial class ErrorDetails {
    public System.Xml.XmlNode Details;
    public System.Xml.XmlNode Summary;
    public ErrorDetails() { }
  }
  public partial class ErrorDocumentation {
    public Monodoc.Providers.ErrorDetails Details;
    public string ErrorName;
    public System.Collections.Generic.List<System.String> Examples;
    public ErrorDocumentation() { }
    public ErrorDocumentation(string ErrorName) { }
  }
  public partial class ErrorHelpSource : Monodoc.HelpSource {
    public ErrorHelpSource(string base_file, bool create) { }
    protected override string UriPrefix { get { return default(string); } }
    public override Monodoc.DocumentType GetDocumentTypeForId(string id) { return default(Monodoc.DocumentType); }
    public override string GetInternalIdForUrl(string url, out Monodoc.Node node, out System.Collections.Generic.Dictionary<System.String, System.String> context) { node = default(Monodoc.Node); context = default(System.Collections.Generic.Dictionary<System.String, System.String>); return default(string); }
    public override string GetText(string id) { return default(string); }
    public override bool IsGeneratedContent(string id) { return default(bool); }
    public override void PopulateIndex(Monodoc.IndexMaker index_maker) { }
    public override void PopulateSearchableIndex(Lucene.Net.Index.IndexWriter writer) { }
  }
  public partial class ErrorProvider : Monodoc.Provider {
    public ErrorProvider(string configFile) { }
    public override void CloseTree(Monodoc.HelpSource hs, Monodoc.Tree tree) { }
    public override void PopulateTree(Monodoc.Tree tree) { }
    public static Monodoc.Providers.ErrorProviderConfig ReadConfig(string file) { return default(Monodoc.Providers.ErrorProviderConfig); }
  }
  public partial class ErrorProviderConfig {
    public int ErrorNumSubstringLength;
    public int ErrorNumSubstringStart;
    public string FilesPath;
    public string FriendlyFormatString;
    public string Match;
    public ErrorProviderConfig() { }
    public System.Collections.Generic.Dictionary<System.String, Monodoc.Providers.ErrorDocumentation> Compile(Monodoc.HelpSource hs) { return default(System.Collections.Generic.Dictionary<System.String, Monodoc.Providers.ErrorDocumentation>); }
    public override string ToString() { return default(string); }
  }
  public partial interface IEcmaProviderFileSource {
    System.Xml.Linq.XElement ExtractNamespaceSummary(string path);
    System.Xml.XmlReader GetIndexReader(string path);
    System.Xml.Linq.XElement GetNamespaceElement(string path);
    string GetNamespaceXmlPath(string basePath, string ns);
    System.Xml.Linq.XDocument GetTypeDocument(string path);
    string GetTypeXmlPath(string basePath, string nsName, string typeName);
  }
  public partial class ManHelpSource : Monodoc.HelpSource {
    public ManHelpSource(string base_file, bool create) { }
    protected override string UriPrefix { get { return default(string); } }
    public override Monodoc.DocumentType GetDocumentTypeForId(string id) { return default(Monodoc.DocumentType); }
    public override string GetText(string url) { return default(string); }
    public override bool IsGeneratedContent(string id) { return default(bool); }
    public override Monodoc.Node MatchNode(string url) { return default(Monodoc.Node); }
  }
  public partial class ManProvider : Monodoc.Provider {
    public ManProvider(System.String[] handbookTocFiles) { }
    public override void CloseTree(Monodoc.HelpSource hs, Monodoc.Tree tree) { }
    public override void PopulateTree(Monodoc.Tree tree) { }
  }
  public partial class XhtmlHelpSource : Monodoc.HelpSource {
    public XhtmlHelpSource(string base_file, bool create) { }
    public override Monodoc.SortType SortType { get { return default(Monodoc.SortType); } }
    protected override string UriPrefix { get { return default(string); } }
    public static string GetAbsoluteLink(string target, string url) { return default(string); }
    public override Monodoc.DocumentType GetDocumentTypeForId(string id) { return default(Monodoc.DocumentType); }
    public override string GetText(string url) { return default(string); }
    public override bool IsGeneratedContent(string id) { return default(bool); }
    public override void PopulateIndex(Monodoc.IndexMaker index_maker) { }
  }
  public partial class XhtmlProvider : Monodoc.Provider {
    public XhtmlProvider(string handbookTocFile) { }
    public override void CloseTree(Monodoc.HelpSource hs, Monodoc.Tree tree) { }
    public override void PopulateTree(Monodoc.Tree tree) { }
  }
}
namespace Monodoc.Storage {
  public partial class NullStorage : Monodoc.IDocStorage, System.IDisposable {
    public NullStorage() { }
    public Monodoc.IDocRevisionManager RevisionManager { get { return default(Monodoc.IDocRevisionManager); } }
    public bool SupportChange { get { return default(bool); } }
    public bool SupportRevision { get { return default(bool); } }
    public void Dispose() { }
    public System.Collections.Generic.IEnumerable<System.String> GetAvailableIds() { return default(System.Collections.Generic.IEnumerable<System.String>); }
    public System.IO.Stream Retrieve(string id) { return default(System.IO.Stream); }
    public string Store(string id, System.Byte[] data) { return default(string); }
    public string Store(string id, System.IO.Stream stream) { return default(string); }
    public string Store(string id, string text) { return default(string); }
  }
  public partial class UncompiledDocStorage : Monodoc.IDocStorage, System.IDisposable {
    public UncompiledDocStorage(string basePath) { }
    public Monodoc.IDocRevisionManager RevisionManager { get { return default(Monodoc.IDocRevisionManager); } }
    public bool SupportChange { get { return default(bool); } }
    public bool SupportRevision { get { return default(bool); } }
    public void Dispose() { }
    public System.Collections.Generic.IEnumerable<System.String> GetAvailableIds() { return default(System.Collections.Generic.IEnumerable<System.String>); }
    public System.IO.Stream Retrieve(string id) { return default(System.IO.Stream); }
    public string Store(string id, System.Byte[] data) { return default(string); }
    public string Store(string id, System.IO.Stream stream) { return default(string); }
    public string Store(string id, string text) { return default(string); }
  }
  public partial class ZipStorage : Monodoc.IDocStorage, System.IDisposable {
    public ZipStorage(string zipFileName) { }
    public Monodoc.IDocRevisionManager RevisionManager { get { return default(Monodoc.IDocRevisionManager); } }
    public bool SupportChange { get { return default(bool); } }
    public bool SupportRevision { get { return default(bool); } }
    public void Dispose() { }
    public System.Collections.Generic.IEnumerable<System.String> GetAvailableIds() { return default(System.Collections.Generic.IEnumerable<System.String>); }
    public System.IO.Stream Retrieve(string id) { return default(System.IO.Stream); }
    public string Store(string id, System.Byte[] data) { return default(string); }
    public string Store(string id, System.IO.Stream stream) { return default(string); }
    public string Store(string id, string text) { return default(string); }
  }
}
namespace Simplicit.Net.Lzo {
  public partial class LZOCompressor {
    public LZOCompressor() { }
    public string Version { get { return default(string); } }
    public string VersionDate { get { return default(string); } }
    public System.Byte[] Compress(System.Byte[] src) { return default(System.Byte[]); }
    public System.Byte[] Decompress(System.Byte[] src) { return default(System.Byte[]); }
  }
}
