namespace System.Speech.AudioFormat {
  public enum AudioBitsPerSample {
    Eight = 8,
    Sixteen = 16,
  }
  public enum AudioChannel {
    Mono = 1,
    Stereo = 2,
  }
  public enum EncodingFormat {
    ALaw = 6,
    Pcm = 1,
    ULaw = 7,
  }
  public partial class SpeechAudioFormatInfo {
    public SpeechAudioFormatInfo(int samplesPerSecond, System.Speech.AudioFormat.AudioBitsPerSample bitsPerSample, System.Speech.AudioFormat.AudioChannel channel) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public SpeechAudioFormatInfo(System.Speech.AudioFormat.EncodingFormat encodingFormat, int samplesPerSecond, int bitsPerSample, int channelCount, int averageBytesPerSecond, int blockAlign, System.Byte[] formatSpecificData) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public int AverageBytesPerSecond { get { return default(int); } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public int BitsPerSample { get { return default(int); } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public int BlockAlign { get { return default(int); } }
    public int ChannelCount { get { return default(int); } }
    public System.Speech.AudioFormat.EncodingFormat EncodingFormat { get { return default(System.Speech.AudioFormat.EncodingFormat); } }
    public int SamplesPerSecond { get { return default(int); } }
    public override bool Equals(object obj) { return default(bool); }
    public System.Byte[] FormatSpecificData() { return default(System.Byte[]); }
    public override int GetHashCode() { return default(int); }
  }
}
namespace System.Speech.Recognition {
  public partial class AudioLevelUpdatedEventArgs : System.EventArgs {
    internal AudioLevelUpdatedEventArgs() { }
    public int AudioLevel { get { return default(int); } }
  }
  public enum AudioSignalProblem {
    None = 0,
    NoSignal = 2,
    TooFast = 5,
    TooLoud = 3,
    TooNoisy = 1,
    TooSlow = 6,
    TooSoft = 4,
  }
  public partial class AudioSignalProblemOccurredEventArgs : System.EventArgs {
    internal AudioSignalProblemOccurredEventArgs() { }
    public int AudioLevel { get { return default(int); } }
    public System.TimeSpan AudioPosition { get { return default(System.TimeSpan); } }
    public System.Speech.Recognition.AudioSignalProblem AudioSignalProblem { get { return default(System.Speech.Recognition.AudioSignalProblem); } }
    public System.TimeSpan RecognizerAudioPosition { get { return default(System.TimeSpan); } }
  }
  public enum AudioState {
    Silence = 1,
    Speech = 2,
    Stopped = 0,
  }
  public partial class AudioStateChangedEventArgs : System.EventArgs {
    internal AudioStateChangedEventArgs() { }
    public System.Speech.Recognition.AudioState AudioState { get { return default(System.Speech.Recognition.AudioState); } }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("{_oneOf.DebugSummary}")]
  public partial class Choices {
    public Choices() { }
    public Choices(params System.Speech.Recognition.GrammarBuilder[] alternateChoices) { }
    public Choices(params System.String[] phrases) { }
    public void Add(params System.Speech.Recognition.GrammarBuilder[] alternateChoices) { }
    public void Add(params System.String[] phrases) { }
    public System.Speech.Recognition.GrammarBuilder ToGrammarBuilder() { return default(System.Speech.Recognition.GrammarBuilder); }
  }
  public partial class DictationGrammar : System.Speech.Recognition.Grammar {
    public DictationGrammar() { }
    public DictationGrammar(string topic) { }
    public void SetDictationContext(string precedingText, string subsequentText) { }
  }
  [System.FlagsAttribute]
  public enum DisplayAttributes {
    ConsumeLeadingSpaces = 16,
    None = 0,
    OneTrailingSpace = 4,
    TwoTrailingSpaces = 8,
    ZeroTrailingSpaces = 2,
  }
  public partial class EmulateRecognizeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    internal EmulateRecognizeCompletedEventArgs() { }
    public System.Speech.Recognition.RecognitionResult Result { get { return default(System.Speech.Recognition.RecognitionResult); } }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("Grammar: {(_uri != null ? \"uri=\" + _uri.ToString () + \" \" : \"\") + \"rule=\" + _ruleName }")]
  public partial class Grammar {
    protected Grammar() { }
    public Grammar(System.IO.Stream stream) { }
    public Grammar(System.IO.Stream stream, string ruleName) { }
    public Grammar(System.IO.Stream stream, string ruleName, System.Object[] parameters) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public Grammar(System.IO.Stream stream, string ruleName, System.Uri baseUri) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public Grammar(System.IO.Stream stream, string ruleName, System.Uri baseUri, System.Object[] parameters) { }
    public Grammar(System.Speech.Recognition.GrammarBuilder builder) { }
    public Grammar(System.Speech.Recognition.SrgsGrammar.SrgsDocument srgsDocument) { }
    public Grammar(System.Speech.Recognition.SrgsGrammar.SrgsDocument srgsDocument, string ruleName) { }
    public Grammar(System.Speech.Recognition.SrgsGrammar.SrgsDocument srgsDocument, string ruleName, System.Object[] parameters) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public Grammar(System.Speech.Recognition.SrgsGrammar.SrgsDocument srgsDocument, string ruleName, System.Uri baseUri) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public Grammar(System.Speech.Recognition.SrgsGrammar.SrgsDocument srgsDocument, string ruleName, System.Uri baseUri, System.Object[] parameters) { }
    public Grammar(string path) { }
    public Grammar(string path, string ruleName) { }
    public Grammar(string path, string ruleName, System.Object[] parameters) { }
    public bool Enabled { get { return default(bool); } set { } }
    protected internal virtual bool IsStg { get { return default(bool); } }
    public bool Loaded { get { return default(bool); } }
    public string Name { get { return default(string); } set { } }
    public int Priority { get { return default(int); } set { } }
    protected string ResourceName { get { return default(string); } set { } }
    public string RuleName { get { return default(string); } }
    public float Weight { get { return default(float); } set { } }
    public event System.EventHandler<System.Speech.Recognition.SpeechRecognizedEventArgs> SpeechRecognized { add { } remove { } }
    public static System.Speech.Recognition.Grammar LoadLocalizedGrammarFromType(System.Type type, params System.Object[] onInitParameters) { return default(System.Speech.Recognition.Grammar); }
    protected void StgInit(System.Object[] parameters) { }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("{DebugSummary}")]
  public partial class GrammarBuilder {
    public GrammarBuilder() { }
    public GrammarBuilder(System.Speech.Recognition.Choices alternateChoices) { }
    public GrammarBuilder(System.Speech.Recognition.GrammarBuilder builder, int minRepeat, int maxRepeat) { }
    public GrammarBuilder(System.Speech.Recognition.SemanticResultKey key) { }
    public GrammarBuilder(System.Speech.Recognition.SemanticResultValue value) { }
    public GrammarBuilder(string phrase) { }
    public GrammarBuilder(string phrase, int minRepeat, int maxRepeat) { }
    public GrammarBuilder(string phrase, System.Speech.Recognition.SubsetMatchingMode subsetMatchingCriteria) { }
    public System.Globalization.CultureInfo Culture { get { return default(System.Globalization.CultureInfo); } set { } }
    public string DebugShowPhrases { get { return default(string); } }
    public static System.Speech.Recognition.GrammarBuilder Add(System.Speech.Recognition.Choices choices, System.Speech.Recognition.GrammarBuilder builder) { return default(System.Speech.Recognition.GrammarBuilder); }
    public static System.Speech.Recognition.GrammarBuilder Add(System.Speech.Recognition.GrammarBuilder builder, System.Speech.Recognition.Choices choices) { return default(System.Speech.Recognition.GrammarBuilder); }
    public static System.Speech.Recognition.GrammarBuilder Add(System.Speech.Recognition.GrammarBuilder builder1, System.Speech.Recognition.GrammarBuilder builder2) { return default(System.Speech.Recognition.GrammarBuilder); }
    public static System.Speech.Recognition.GrammarBuilder Add(System.Speech.Recognition.GrammarBuilder builder, string phrase) { return default(System.Speech.Recognition.GrammarBuilder); }
    public static System.Speech.Recognition.GrammarBuilder Add(string phrase, System.Speech.Recognition.GrammarBuilder builder) { return default(System.Speech.Recognition.GrammarBuilder); }
    public void Append(System.Speech.Recognition.Choices alternateChoices) { }
    public void Append(System.Speech.Recognition.GrammarBuilder builder) { }
    public void Append(System.Speech.Recognition.GrammarBuilder builder, int minRepeat, int maxRepeat) { }
    public void Append(System.Speech.Recognition.SemanticResultKey key) { }
    public void Append(System.Speech.Recognition.SemanticResultValue value) { }
    public void Append(string phrase) { }
    public void Append(string phrase, int minRepeat, int maxRepeat) { }
    public void Append(string phrase, System.Speech.Recognition.SubsetMatchingMode subsetMatchingCriteria) { }
    public void AppendDictation() { }
    public void AppendDictation(string category) { }
    public void AppendRuleReference(string path) { }
    public void AppendRuleReference(string path, string rule) { }
    public void AppendWildcard() { }
    public static System.Speech.Recognition.GrammarBuilder operator +(System.Speech.Recognition.Choices choices, System.Speech.Recognition.GrammarBuilder builder) { return default(System.Speech.Recognition.GrammarBuilder); }
    public static System.Speech.Recognition.GrammarBuilder operator +(System.Speech.Recognition.GrammarBuilder builder, System.Speech.Recognition.Choices choices) { return default(System.Speech.Recognition.GrammarBuilder); }
    public static System.Speech.Recognition.GrammarBuilder operator +(System.Speech.Recognition.GrammarBuilder builder1, System.Speech.Recognition.GrammarBuilder builder2) { return default(System.Speech.Recognition.GrammarBuilder); }
    public static System.Speech.Recognition.GrammarBuilder operator +(System.Speech.Recognition.GrammarBuilder builder, string phrase) { return default(System.Speech.Recognition.GrammarBuilder); }
    public static System.Speech.Recognition.GrammarBuilder operator +(string phrase, System.Speech.Recognition.GrammarBuilder builder) { return default(System.Speech.Recognition.GrammarBuilder); }
    public static implicit operator System.Speech.Recognition.GrammarBuilder (System.Speech.Recognition.Choices choices) { return default(System.Speech.Recognition.GrammarBuilder); }
    public static implicit operator System.Speech.Recognition.GrammarBuilder (System.Speech.Recognition.SemanticResultKey semanticKey) { return default(System.Speech.Recognition.GrammarBuilder); }
    public static implicit operator System.Speech.Recognition.GrammarBuilder (System.Speech.Recognition.SemanticResultValue semanticValue) { return default(System.Speech.Recognition.GrammarBuilder); }
    public static implicit operator System.Speech.Recognition.GrammarBuilder (string phrase) { return default(System.Speech.Recognition.GrammarBuilder); }
  }
  public partial class LoadGrammarCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    internal LoadGrammarCompletedEventArgs() { }
    public System.Speech.Recognition.Grammar Grammar { get { return default(System.Speech.Recognition.Grammar); } }
  }
  public abstract partial class RecognitionEventArgs : System.EventArgs {
    internal RecognitionEventArgs() { }
    public System.Speech.Recognition.RecognitionResult Result { get { return default(System.Speech.Recognition.RecognitionResult); } }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("{DebuggerDisplayString ()}")]
  public sealed partial class RecognitionResult : System.Speech.Recognition.RecognizedPhrase, System.Runtime.Serialization.ISerializable {
    internal RecognitionResult() { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Speech.Recognition.RecognizedPhrase> Alternates { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Speech.Recognition.RecognizedPhrase>); } }
    public System.Speech.Recognition.RecognizedAudio Audio { get { return default(System.Speech.Recognition.RecognizedAudio); } }
    public System.Speech.Recognition.RecognizedAudio GetAudioForWordRange(System.Speech.Recognition.RecognizedWordUnit firstWord, System.Speech.Recognition.RecognizedWordUnit lastWord) { return default(System.Speech.Recognition.RecognizedAudio); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, SerializationFormatter=true)]
    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial class RecognizeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    internal RecognizeCompletedEventArgs() { }
    public System.TimeSpan AudioPosition { get { return default(System.TimeSpan); } }
    public bool BabbleTimeout { get { return default(bool); } }
    public bool InitialSilenceTimeout { get { return default(bool); } }
    public bool InputStreamEnded { get { return default(bool); } }
    public System.Speech.Recognition.RecognitionResult Result { get { return default(System.Speech.Recognition.RecognitionResult); } }
  }
  public partial class RecognizedAudio {
    internal RecognizedAudio() { }
    public System.TimeSpan AudioPosition { get { return default(System.TimeSpan); } }
    public System.TimeSpan Duration { get { return default(System.TimeSpan); } }
    public System.Speech.AudioFormat.SpeechAudioFormatInfo Format { get { return default(System.Speech.AudioFormat.SpeechAudioFormatInfo); } }
    public System.DateTime StartTime { get { return default(System.DateTime); } }
    public System.Speech.Recognition.RecognizedAudio GetRange(System.TimeSpan audioPosition, System.TimeSpan duration) { return default(System.Speech.Recognition.RecognizedAudio); }
    public void WriteToAudioStream(System.IO.Stream outputStream) { }
    public void WriteToWaveStream(System.IO.Stream outputStream) { }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("{Text}")]
  public partial class RecognizedPhrase {
    internal RecognizedPhrase() { }
    public float Confidence { get { return default(float); } }
    public System.Speech.Recognition.Grammar Grammar { get { return default(System.Speech.Recognition.Grammar); } }
    public int HomophoneGroupId { get { return default(int); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Speech.Recognition.RecognizedPhrase> Homophones { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Speech.Recognition.RecognizedPhrase>); } }
    public System.Collections.ObjectModel.Collection<System.Speech.Recognition.ReplacementText> ReplacementWordUnits { get { return default(System.Collections.ObjectModel.Collection<System.Speech.Recognition.ReplacementText>); } }
    public System.Speech.Recognition.SemanticValue Semantics { get { return default(System.Speech.Recognition.SemanticValue); } }
    public string Text { get { return default(string); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Speech.Recognition.RecognizedWordUnit> Words { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Speech.Recognition.RecognizedWordUnit>); } }
    public System.Xml.XPath.IXPathNavigable ConstructSmlFromSemantics() { return default(System.Xml.XPath.IXPathNavigable); }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("Text: {Text}")]
  public partial class RecognizedWordUnit {
    public RecognizedWordUnit(string text, float confidence, string pronunciation, string lexicalForm, System.Speech.Recognition.DisplayAttributes displayAttributes, System.TimeSpan audioPosition, System.TimeSpan audioDuration) { }
    public float Confidence { get { return default(float); } }
    public System.Speech.Recognition.DisplayAttributes DisplayAttributes { get { return default(System.Speech.Recognition.DisplayAttributes); } }
    public string LexicalForm { get { return default(string); } }
    public string Pronunciation { get { return default(string); } }
    public string Text { get { return default(string); } }
  }
  public enum RecognizeMode {
    Multiple = 1,
    Single = 0,
  }
  public partial class RecognizerInfo : System.IDisposable {
    internal RecognizerInfo() { }
    public System.Collections.Generic.IDictionary<System.String, System.String> AdditionalInfo { get { return default(System.Collections.Generic.IDictionary<System.String, System.String>); } }
    public System.Globalization.CultureInfo Culture { get { return default(System.Globalization.CultureInfo); } }
    public string Description { get { return default(string); } }
    public string Id { get { return default(string); } }
    public string Name { get { return default(string); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Speech.AudioFormat.SpeechAudioFormatInfo> SupportedAudioFormats { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Speech.AudioFormat.SpeechAudioFormatInfo>); } }
    public void Dispose() { }
  }
  public enum RecognizerState {
    Listening = 1,
    Stopped = 0,
  }
  public partial class RecognizerUpdateReachedEventArgs : System.EventArgs {
    internal RecognizerUpdateReachedEventArgs() { }
    public System.TimeSpan AudioPosition { get { return default(System.TimeSpan); } }
    public object UserToken { get { return default(object); } }
  }
  public partial class ReplacementText {
    internal ReplacementText() { }
    public int CountOfWords { get { return default(int); } }
    public System.Speech.Recognition.DisplayAttributes DisplayAttributes { get { return default(System.Speech.Recognition.DisplayAttributes); } }
    public int FirstWordIndex { get { return default(int); } }
    public string Text { get { return default(string); } }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("{_semanticKey.DebugSummary}")]
  public partial class SemanticResultKey {
    public SemanticResultKey(string semanticResultKey, params System.Speech.Recognition.GrammarBuilder[] builders) { }
    public SemanticResultKey(string semanticResultKey, params System.String[] phrases) { }
    public System.Speech.Recognition.GrammarBuilder ToGrammarBuilder() { return default(System.Speech.Recognition.GrammarBuilder); }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("{_tag.DebugSummary}")]
  public partial class SemanticResultValue {
    public SemanticResultValue(object value) { }
    public SemanticResultValue(System.Speech.Recognition.GrammarBuilder builder, object value) { }
    public SemanticResultValue(string phrase, object value) { }
    public System.Speech.Recognition.GrammarBuilder ToGrammarBuilder() { return default(System.Speech.Recognition.GrammarBuilder); }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("'{_keyName}'= {Value}  -  Children = {_dictionary.Count}")]
  [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(System.Speech.Recognition.SemanticValue.SemanticValueDebugDisplay))]
  public sealed partial class SemanticValue : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String, System.Speech.Recognition.SemanticValue>>, System.Collections.Generic.IDictionary<System.String, System.Speech.Recognition.SemanticValue>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Speech.Recognition.SemanticValue>>, System.Collections.IEnumerable {
    public SemanticValue(object value) { }
    public SemanticValue(string keyName, object value, float confidence) { }
    public float Confidence { get { return default(float); } }
    public int Count { get { return default(int); } }
    public System.Speech.Recognition.SemanticValue this[string key] { get { return default(System.Speech.Recognition.SemanticValue); } set { } }
    bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Speech.Recognition.SemanticValue>>.IsReadOnly { get { return default(bool); } }
    System.Collections.Generic.ICollection<System.String> System.Collections.Generic.IDictionary<System.String,System.Speech.Recognition.SemanticValue>.Keys { get { return default(System.Collections.Generic.ICollection<System.String>); } }
    System.Collections.Generic.ICollection<System.Speech.Recognition.SemanticValue> System.Collections.Generic.IDictionary<System.String,System.Speech.Recognition.SemanticValue>.Values { get { return default(System.Collections.Generic.ICollection<System.Speech.Recognition.SemanticValue>); } }
    public object Value { get { return default(object); } }
    public bool Contains(System.Collections.Generic.KeyValuePair<System.String, System.Speech.Recognition.SemanticValue> item) { return default(bool); }
    public bool ContainsKey(string key) { return default(bool); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Speech.Recognition.SemanticValue>>.Add(System.Collections.Generic.KeyValuePair<System.String, System.Speech.Recognition.SemanticValue> key) { }
    void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Speech.Recognition.SemanticValue>>.Clear() { }
    void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Speech.Recognition.SemanticValue>>.CopyTo(System.Collections.Generic.KeyValuePair<System.String, System.Speech.Recognition.SemanticValue>[] array, int index) { }
    bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Speech.Recognition.SemanticValue>>.Remove(System.Collections.Generic.KeyValuePair<System.String, System.Speech.Recognition.SemanticValue> key) { return default(bool); }
    void System.Collections.Generic.IDictionary<System.String,System.Speech.Recognition.SemanticValue>.Add(string key, System.Speech.Recognition.SemanticValue value) { }
    bool System.Collections.Generic.IDictionary<System.String,System.Speech.Recognition.SemanticValue>.Remove(string key) { return default(bool); }
    bool System.Collections.Generic.IDictionary<System.String,System.Speech.Recognition.SemanticValue>.TryGetValue(string key, out System.Speech.Recognition.SemanticValue value) { value = default(System.Speech.Recognition.SemanticValue); return default(bool); }
    System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String, System.Speech.Recognition.SemanticValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Speech.Recognition.SemanticValue>>.GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String, System.Speech.Recognition.SemanticValue>>); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public partial class SpeechDetectedEventArgs : System.EventArgs {
    internal SpeechDetectedEventArgs() { }
    public System.TimeSpan AudioPosition { get { return default(System.TimeSpan); } }
  }
  public partial class SpeechHypothesizedEventArgs : System.Speech.Recognition.RecognitionEventArgs {
    internal SpeechHypothesizedEventArgs() { }
  }
  public partial class SpeechRecognitionEngine : System.IDisposable {
    public SpeechRecognitionEngine() { }
    public SpeechRecognitionEngine(System.Globalization.CultureInfo culture) { }
    public SpeechRecognitionEngine(System.Speech.Recognition.RecognizerInfo recognizerInfo) { }
    public SpeechRecognitionEngine(string recognizerId) { }
    public System.Speech.AudioFormat.SpeechAudioFormatInfo AudioFormat { get { return default(System.Speech.AudioFormat.SpeechAudioFormatInfo); } }
    public int AudioLevel { get { return default(int); } }
    public System.TimeSpan AudioPosition { get { return default(System.TimeSpan); } }
    public System.Speech.Recognition.AudioState AudioState { get { return default(System.Speech.Recognition.AudioState); } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public System.TimeSpan BabbleTimeout { get { return default(System.TimeSpan); } set { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public System.TimeSpan EndSilenceTimeout { get { return default(System.TimeSpan); } set { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public System.TimeSpan EndSilenceTimeoutAmbiguous { get { return default(System.TimeSpan); } set { } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Speech.Recognition.Grammar> Grammars { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Speech.Recognition.Grammar>); } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public System.TimeSpan InitialSilenceTimeout { get { return default(System.TimeSpan); } set { } }
    public int MaxAlternates { get { return default(int); } set { } }
    public System.TimeSpan RecognizerAudioPosition { get { return default(System.TimeSpan); } }
    public System.Speech.Recognition.RecognizerInfo RecognizerInfo { get { return default(System.Speech.Recognition.RecognizerInfo); } }
    public event System.EventHandler<System.Speech.Recognition.AudioLevelUpdatedEventArgs> AudioLevelUpdated { add { } remove { } }
    public event System.EventHandler<System.Speech.Recognition.AudioSignalProblemOccurredEventArgs> AudioSignalProblemOccurred { add { } remove { } }
    public event System.EventHandler<System.Speech.Recognition.AudioStateChangedEventArgs> AudioStateChanged { add { } remove { } }
    public event System.EventHandler<System.Speech.Recognition.EmulateRecognizeCompletedEventArgs> EmulateRecognizeCompleted { add { } remove { } }
    public event System.EventHandler<System.Speech.Recognition.LoadGrammarCompletedEventArgs> LoadGrammarCompleted { add { } remove { } }
    public event System.EventHandler<System.Speech.Recognition.RecognizeCompletedEventArgs> RecognizeCompleted { add { } remove { } }
    public event System.EventHandler<System.Speech.Recognition.RecognizerUpdateReachedEventArgs> RecognizerUpdateReached { add { } remove { } }
    public event System.EventHandler<System.Speech.Recognition.SpeechDetectedEventArgs> SpeechDetected { add { } remove { } }
    public event System.EventHandler<System.Speech.Recognition.SpeechHypothesizedEventArgs> SpeechHypothesized { add { } remove { } }
    public event System.EventHandler<System.Speech.Recognition.SpeechRecognitionRejectedEventArgs> SpeechRecognitionRejected { add { } remove { } }
    public event System.EventHandler<System.Speech.Recognition.SpeechRecognizedEventArgs> SpeechRecognized { add { } remove { } }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public System.Speech.Recognition.RecognitionResult EmulateRecognize(System.Speech.Recognition.RecognizedWordUnit[] wordUnits, System.Globalization.CompareOptions compareOptions) { return default(System.Speech.Recognition.RecognitionResult); }
    public System.Speech.Recognition.RecognitionResult EmulateRecognize(string inputText) { return default(System.Speech.Recognition.RecognitionResult); }
    public System.Speech.Recognition.RecognitionResult EmulateRecognize(string inputText, System.Globalization.CompareOptions compareOptions) { return default(System.Speech.Recognition.RecognitionResult); }
    public void EmulateRecognizeAsync(System.Speech.Recognition.RecognizedWordUnit[] wordUnits, System.Globalization.CompareOptions compareOptions) { }
    public void EmulateRecognizeAsync(string inputText) { }
    public void EmulateRecognizeAsync(string inputText, System.Globalization.CompareOptions compareOptions) { }
    public static System.Collections.ObjectModel.ReadOnlyCollection<System.Speech.Recognition.RecognizerInfo> InstalledRecognizers() { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Speech.Recognition.RecognizerInfo>); }
    public void LoadGrammar(System.Speech.Recognition.Grammar grammar) { }
    public void LoadGrammarAsync(System.Speech.Recognition.Grammar grammar) { }
    public object QueryRecognizerSetting(string settingName) { return default(object); }
    public System.Speech.Recognition.RecognitionResult Recognize() { return default(System.Speech.Recognition.RecognitionResult); }
    public System.Speech.Recognition.RecognitionResult Recognize(System.TimeSpan initialSilenceTimeout) { return default(System.Speech.Recognition.RecognitionResult); }
    public void RecognizeAsync() { }
    public void RecognizeAsync(System.Speech.Recognition.RecognizeMode mode) { }
    public void RecognizeAsyncCancel() { }
    public void RecognizeAsyncStop() { }
    public void RequestRecognizerUpdate() { }
    public void RequestRecognizerUpdate(object userToken) { }
    public void RequestRecognizerUpdate(object userToken, System.TimeSpan audioPositionAheadToRaiseUpdate) { }
    public void SetInputToAudioStream(System.IO.Stream audioSource, System.Speech.AudioFormat.SpeechAudioFormatInfo audioFormat) { }
    public void SetInputToDefaultAudioDevice() { }
    public void SetInputToNull() { }
    public void SetInputToWaveFile(string path) { }
    public void SetInputToWaveStream(System.IO.Stream audioSource) { }
    public void UnloadAllGrammars() { }
    public void UnloadGrammar(System.Speech.Recognition.Grammar grammar) { }
    public void UpdateRecognizerSetting(string settingName, int updatedValue) { }
    public void UpdateRecognizerSetting(string settingName, string updatedValue) { }
  }
  public partial class SpeechRecognitionRejectedEventArgs : System.Speech.Recognition.RecognitionEventArgs {
    internal SpeechRecognitionRejectedEventArgs() { }
  }
  public partial class SpeechRecognizedEventArgs : System.Speech.Recognition.RecognitionEventArgs {
    internal SpeechRecognizedEventArgs() { }
  }
  public partial class SpeechRecognizer : System.IDisposable {
    public SpeechRecognizer() { }
    public System.Speech.AudioFormat.SpeechAudioFormatInfo AudioFormat { get { return default(System.Speech.AudioFormat.SpeechAudioFormatInfo); } }
    public int AudioLevel { get { return default(int); } }
    public System.TimeSpan AudioPosition { get { return default(System.TimeSpan); } }
    public System.Speech.Recognition.AudioState AudioState { get { return default(System.Speech.Recognition.AudioState); } }
    public bool Enabled { get { return default(bool); } set { } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Speech.Recognition.Grammar> Grammars { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Speech.Recognition.Grammar>); } }
    public int MaxAlternates { get { return default(int); } set { } }
    public bool PauseRecognizerOnRecognition { get { return default(bool); } set { } }
    public System.TimeSpan RecognizerAudioPosition { get { return default(System.TimeSpan); } }
    public System.Speech.Recognition.RecognizerInfo RecognizerInfo { get { return default(System.Speech.Recognition.RecognizerInfo); } }
    public System.Speech.Recognition.RecognizerState State { get { return default(System.Speech.Recognition.RecognizerState); } }
    public event System.EventHandler<System.Speech.Recognition.AudioLevelUpdatedEventArgs> AudioLevelUpdated { add { } remove { } }
    public event System.EventHandler<System.Speech.Recognition.AudioSignalProblemOccurredEventArgs> AudioSignalProblemOccurred { add { } remove { } }
    public event System.EventHandler<System.Speech.Recognition.AudioStateChangedEventArgs> AudioStateChanged { add { } remove { } }
    public event System.EventHandler<System.Speech.Recognition.EmulateRecognizeCompletedEventArgs> EmulateRecognizeCompleted { add { } remove { } }
    public event System.EventHandler<System.Speech.Recognition.LoadGrammarCompletedEventArgs> LoadGrammarCompleted { add { } remove { } }
    public event System.EventHandler<System.Speech.Recognition.RecognizerUpdateReachedEventArgs> RecognizerUpdateReached { add { } remove { } }
    public event System.EventHandler<System.Speech.Recognition.SpeechDetectedEventArgs> SpeechDetected { add { } remove { } }
    public event System.EventHandler<System.Speech.Recognition.SpeechHypothesizedEventArgs> SpeechHypothesized { add { } remove { } }
    public event System.EventHandler<System.Speech.Recognition.SpeechRecognitionRejectedEventArgs> SpeechRecognitionRejected { add { } remove { } }
    public event System.EventHandler<System.Speech.Recognition.SpeechRecognizedEventArgs> SpeechRecognized { add { } remove { } }
    public event System.EventHandler<System.Speech.Recognition.StateChangedEventArgs> StateChanged { add { } remove { } }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public System.Speech.Recognition.RecognitionResult EmulateRecognize(System.Speech.Recognition.RecognizedWordUnit[] wordUnits, System.Globalization.CompareOptions compareOptions) { return default(System.Speech.Recognition.RecognitionResult); }
    public System.Speech.Recognition.RecognitionResult EmulateRecognize(string inputText) { return default(System.Speech.Recognition.RecognitionResult); }
    public System.Speech.Recognition.RecognitionResult EmulateRecognize(string inputText, System.Globalization.CompareOptions compareOptions) { return default(System.Speech.Recognition.RecognitionResult); }
    public void EmulateRecognizeAsync(System.Speech.Recognition.RecognizedWordUnit[] wordUnits, System.Globalization.CompareOptions compareOptions) { }
    public void EmulateRecognizeAsync(string inputText) { }
    public void EmulateRecognizeAsync(string inputText, System.Globalization.CompareOptions compareOptions) { }
    public void LoadGrammar(System.Speech.Recognition.Grammar grammar) { }
    public void LoadGrammarAsync(System.Speech.Recognition.Grammar grammar) { }
    public void RequestRecognizerUpdate() { }
    public void RequestRecognizerUpdate(object userToken) { }
    public void RequestRecognizerUpdate(object userToken, System.TimeSpan audioPositionAheadToRaiseUpdate) { }
    public void UnloadAllGrammars() { }
    public void UnloadGrammar(System.Speech.Recognition.Grammar grammar) { }
  }
  public partial class SpeechUI {
    internal SpeechUI() { }
    public static bool SendTextFeedback(System.Speech.Recognition.RecognitionResult result, string feedback, bool isSuccessfulAction) { return default(bool); }
  }
  public partial class StateChangedEventArgs : System.EventArgs {
    internal StateChangedEventArgs() { }
    public System.Speech.Recognition.RecognizerState RecognizerState { get { return default(System.Speech.Recognition.RecognizerState); } }
  }
  public enum SubsetMatchingMode {
    OrderedSubset = 1,
    OrderedSubsetContentRequired = 3,
    Subsequence = 0,
    SubsequenceContentRequired = 2,
  }
}
namespace System.Speech.Recognition.SrgsGrammar {
  public partial class SrgsDocument {
    public SrgsDocument() { }
    public SrgsDocument(System.Speech.Recognition.GrammarBuilder builder) { }
    public SrgsDocument(System.Speech.Recognition.SrgsGrammar.SrgsRule grammarRootRule) { }
    public SrgsDocument(string path) { }
    public SrgsDocument(System.Xml.XmlReader srgsGrammar) { }
    public System.Collections.ObjectModel.Collection<System.String> AssemblyReferences { get { return default(System.Collections.ObjectModel.Collection<System.String>); } }
    public System.Collections.ObjectModel.Collection<System.String> CodeBehind { get { return default(System.Collections.ObjectModel.Collection<System.String>); } }
    public System.Globalization.CultureInfo Culture { get { return default(System.Globalization.CultureInfo); } set { } }
    public bool Debug { get { return default(bool); } set { } }
    public System.Collections.ObjectModel.Collection<System.String> ImportNamespaces { get { return default(System.Collections.ObjectModel.Collection<System.String>); } }
    public string Language { get { return default(string); } set { } }
    public System.Speech.Recognition.SrgsGrammar.SrgsGrammarMode Mode { get { return default(System.Speech.Recognition.SrgsGrammar.SrgsGrammarMode); } set { } }
    public string Namespace { get { return default(string); } set { } }
    public System.Speech.Recognition.SrgsGrammar.SrgsPhoneticAlphabet PhoneticAlphabet { get { return default(System.Speech.Recognition.SrgsGrammar.SrgsPhoneticAlphabet); } set { } }
    public System.Speech.Recognition.SrgsGrammar.SrgsRule Root { get { return default(System.Speech.Recognition.SrgsGrammar.SrgsRule); } set { } }
    public System.Speech.Recognition.SrgsGrammar.SrgsRulesCollection Rules { get { return default(System.Speech.Recognition.SrgsGrammar.SrgsRulesCollection); } }
    public string Script { get { return default(string); } set { } }
    public System.Uri XmlBase { get { return default(System.Uri); } set { } }
    public void WriteSrgs(System.Xml.XmlWriter srgsGrammar) { }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("SrgsElement Children:[{_items.Count}]")]
  [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(System.Speech.Recognition.SrgsGrammar.SrgsElement.SrgsElementDebugDisplay))]
  public abstract partial class SrgsElement : System.MarshalByRefObject {
    protected SrgsElement() { }
  }
  public static partial class SrgsGrammarCompiler {
    public static void Compile(System.Speech.Recognition.SrgsGrammar.SrgsDocument srgsGrammar, System.IO.Stream outputStream) { }
    public static void Compile(string inputPath, System.IO.Stream outputStream) { }
    public static void Compile(System.Xml.XmlReader reader, System.IO.Stream outputStream) { }
    public static void CompileClassLibrary(System.Speech.Recognition.SrgsGrammar.SrgsDocument srgsGrammar, string outputPath, System.String[] referencedAssemblies, string keyFile) { }
    public static void CompileClassLibrary(System.String[] inputPaths, string outputPath, System.String[] referencedAssemblies, string keyFile) { }
    public static void CompileClassLibrary(System.Xml.XmlReader reader, string outputPath, System.String[] referencedAssemblies, string keyFile) { }
  }
  public enum SrgsGrammarMode {
    Dtmf = 1,
    Voice = 0,
  }
  [System.Diagnostics.DebuggerDisplayAttribute("{DebuggerDisplayString ()}")]
  [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(System.Speech.Recognition.SrgsGrammar.SrgsItem.SrgsItemDebugDisplay))]
  public partial class SrgsItem : System.Speech.Recognition.SrgsGrammar.SrgsElement {
    public SrgsItem() { }
    public SrgsItem(int repeatCount) { }
    public SrgsItem(int min, int max) { }
    public SrgsItem(int min, int max, params System.Speech.Recognition.SrgsGrammar.SrgsElement[] elements) { }
    public SrgsItem(int min, int max, string text) { }
    public SrgsItem(params System.Speech.Recognition.SrgsGrammar.SrgsElement[] elements) { }
    public SrgsItem(string text) { }
    public System.Collections.ObjectModel.Collection<System.Speech.Recognition.SrgsGrammar.SrgsElement> Elements { get { return default(System.Collections.ObjectModel.Collection<System.Speech.Recognition.SrgsGrammar.SrgsElement>); } }
    public int MaxRepeat { get { return default(int); } }
    public int MinRepeat { get { return default(int); } }
    public float RepeatProbability { get { return default(float); } set { } }
    public float Weight { get { return default(float); } set { } }
    public void Add(System.Speech.Recognition.SrgsGrammar.SrgsElement element) { }
    public void SetRepeat(int count) { }
    public void SetRepeat(int minRepeat, int maxRepeat) { }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("{DebuggerDisplayString ()}")]
  public partial class SrgsNameValueTag : System.Speech.Recognition.SrgsGrammar.SrgsElement {
    public SrgsNameValueTag() { }
    public SrgsNameValueTag(object value) { }
    public SrgsNameValueTag(string name, object value) { }
    public string Name { get { return default(string); } set { } }
    public object Value { get { return default(object); } set { } }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("{DebuggerDisplayString ()}")]
  [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(System.Speech.Recognition.SrgsGrammar.SrgsOneOf.OneOfDebugDisplay))]
  public partial class SrgsOneOf : System.Speech.Recognition.SrgsGrammar.SrgsElement {
    public SrgsOneOf() { }
    public SrgsOneOf(params System.Speech.Recognition.SrgsGrammar.SrgsItem[] items) { }
    public SrgsOneOf(params System.String[] items) { }
    public System.Collections.ObjectModel.Collection<System.Speech.Recognition.SrgsGrammar.SrgsItem> Items { get { return default(System.Collections.ObjectModel.Collection<System.Speech.Recognition.SrgsGrammar.SrgsItem>); } }
    public void Add(System.Speech.Recognition.SrgsGrammar.SrgsItem item) { }
  }
  public enum SrgsPhoneticAlphabet {
    Ipa = 1,
    Sapi = 0,
    Ups = 2,
  }
  [System.Diagnostics.DebuggerDisplayAttribute("Rule={_id.ToString()} Scope={_scope.ToString()}")]
  [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(System.Speech.Recognition.SrgsGrammar.SrgsRule.SrgsRuleDebugDisplay))]
  public partial class SrgsRule {
    public SrgsRule(string id) { }
    public SrgsRule(string id, params System.Speech.Recognition.SrgsGrammar.SrgsElement[] elements) { }
    public string BaseClass { get { return default(string); } set { } }
    public System.Collections.ObjectModel.Collection<System.Speech.Recognition.SrgsGrammar.SrgsElement> Elements { get { return default(System.Collections.ObjectModel.Collection<System.Speech.Recognition.SrgsGrammar.SrgsElement>); } }
    public string Id { get { return default(string); } set { } }
    public string OnError { get { return default(string); } set { } }
    public string OnInit { get { return default(string); } set { } }
    public string OnParse { get { return default(string); } set { } }
    public string OnRecognition { get { return default(string); } set { } }
    public System.Speech.Recognition.SrgsGrammar.SrgsRuleScope Scope { get { return default(System.Speech.Recognition.SrgsGrammar.SrgsRuleScope); } set { } }
    public string Script { get { return default(string); } set { } }
    public void Add(System.Speech.Recognition.SrgsGrammar.SrgsElement element) { }
  }
  [System.ComponentModel.ImmutableObjectAttribute(true)]
  [System.Diagnostics.DebuggerDisplayAttribute("{DebuggerDisplayString()}")]
  public partial class SrgsRuleRef : System.Speech.Recognition.SrgsGrammar.SrgsElement {
    public static readonly System.Speech.Recognition.SrgsGrammar.SrgsRuleRef Dictation;
    public static readonly System.Speech.Recognition.SrgsGrammar.SrgsRuleRef Garbage;
    public static readonly System.Speech.Recognition.SrgsGrammar.SrgsRuleRef MnemonicSpelling;
    public static readonly System.Speech.Recognition.SrgsGrammar.SrgsRuleRef Null;
    public static readonly System.Speech.Recognition.SrgsGrammar.SrgsRuleRef Void;
    public SrgsRuleRef(System.Speech.Recognition.SrgsGrammar.SrgsRule rule) { }
    public SrgsRuleRef(System.Speech.Recognition.SrgsGrammar.SrgsRule rule, string semanticKey) { }
    public SrgsRuleRef(System.Speech.Recognition.SrgsGrammar.SrgsRule rule, string semanticKey, string parameters) { }
    public SrgsRuleRef(System.Uri uri) { }
    public SrgsRuleRef(System.Uri uri, string rule) { }
    public SrgsRuleRef(System.Uri uri, string rule, string semanticKey) { }
    public SrgsRuleRef(System.Uri uri, string rule, string semanticKey, string parameters) { }
    public string Params { get { return default(string); } }
    public string SemanticKey { get { return default(string); } }
    public System.Uri Uri { get { return default(System.Uri); } }
  }
  public sealed partial class SrgsRulesCollection : System.Collections.ObjectModel.KeyedCollection<System.String, System.Speech.Recognition.SrgsGrammar.SrgsRule> {
    public SrgsRulesCollection() { }
    public void Add(params System.Speech.Recognition.SrgsGrammar.SrgsRule[] rules) { }
    protected override string GetKeyForItem(System.Speech.Recognition.SrgsGrammar.SrgsRule rule) { return default(string); }
  }
  public enum SrgsRuleScope {
    Private = 1,
    Public = 0,
  }
  [System.Diagnostics.DebuggerDisplayAttribute("{DebuggerDisplayString ()}")]
  public partial class SrgsSemanticInterpretationTag : System.Speech.Recognition.SrgsGrammar.SrgsElement {
    public SrgsSemanticInterpretationTag() { }
    public SrgsSemanticInterpretationTag(string script) { }
    public string Script { get { return default(string); } set { } }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("{DebuggerDisplayString ()}")]
  public partial class SrgsSubset : System.Speech.Recognition.SrgsGrammar.SrgsElement {
    public SrgsSubset(string text) { }
    public SrgsSubset(string text, System.Speech.Recognition.SubsetMatchingMode matchingMode) { }
    public System.Speech.Recognition.SubsetMatchingMode MatchingMode { get { return default(System.Speech.Recognition.SubsetMatchingMode); } set { } }
    public string Text { get { return default(string); } set { } }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("{DebuggerDisplayString ()}")]
  public partial class SrgsText : System.Speech.Recognition.SrgsGrammar.SrgsElement {
    public SrgsText() { }
    public SrgsText(string text) { }
    public string Text { get { return default(string); } set { } }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("{DebuggerDisplayString ()}")]
  public partial class SrgsToken : System.Speech.Recognition.SrgsGrammar.SrgsElement {
    public SrgsToken(string text) { }
    public string Display { get { return default(string); } set { } }
    public string Pronunciation { get { return default(string); } set { } }
    public string Text { get { return default(string); } set { } }
  }
}
namespace System.Speech.Synthesis {
  public partial class BookmarkReachedEventArgs : System.Speech.Synthesis.PromptEventArgs {
    internal BookmarkReachedEventArgs() { }
    public System.TimeSpan AudioPosition { get { return default(System.TimeSpan); } }
    public string Bookmark { get { return default(string); } }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("{_text}")]
  public partial class FilePrompt : System.Speech.Synthesis.Prompt {
    public FilePrompt(string path, System.Speech.Synthesis.SynthesisMediaType media) : base (default(string)) { }
    public FilePrompt(System.Uri promptFile, System.Speech.Synthesis.SynthesisMediaType media) : base (default(string)) { }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("{VoiceInfo.Name} [{Enabled ? \"Enabled\" : \"Disabled\"}]")]
  public partial class InstalledVoice {
    internal InstalledVoice() { }
    public bool Enabled { get { return default(bool); } set { } }
    public System.Speech.Synthesis.VoiceInfo VoiceInfo { get { return default(System.Speech.Synthesis.VoiceInfo); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }
  public partial class PhonemeReachedEventArgs : System.Speech.Synthesis.PromptEventArgs {
    internal PhonemeReachedEventArgs() { }
    public System.TimeSpan AudioPosition { get { return default(System.TimeSpan); } }
    public System.TimeSpan Duration { get { return default(System.TimeSpan); } }
    public System.Speech.Synthesis.SynthesizerEmphasis Emphasis { get { return default(System.Speech.Synthesis.SynthesizerEmphasis); } }
    public string NextPhoneme { get { return default(string); } }
    public string Phoneme { get { return default(string); } }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("{_text}")]
  public partial class Prompt {
    public Prompt(System.Speech.Synthesis.PromptBuilder promptBuilder) { }
    public Prompt(string textToSpeak) { }
    public Prompt(string textToSpeak, System.Speech.Synthesis.SynthesisTextFormat media) { }
    public bool IsCompleted { get { return default(bool); } }
  }
  public enum PromptBreak {
    ExtraLarge = 5,
    ExtraSmall = 1,
    Large = 4,
    Medium = 3,
    None = 0,
    Small = 2,
  }
  public partial class PromptBuilder {
    public PromptBuilder() { }
    public PromptBuilder(System.Globalization.CultureInfo culture) { }
    public System.Globalization.CultureInfo Culture { get { return default(System.Globalization.CultureInfo); } set { } }
    public bool IsEmpty { get { return default(bool); } }
    public void AppendAudio(string path) { }
    public void AppendAudio(System.Uri audioFile) { }
    public void AppendAudio(System.Uri audioFile, string alternateText) { }
    public void AppendBookmark(string bookmarkName) { }
    public void AppendBreak() { }
    public void AppendBreak(System.Speech.Synthesis.PromptBreak strength) { }
    public void AppendBreak(System.TimeSpan duration) { }
    public void AppendPromptBuilder(System.Speech.Synthesis.PromptBuilder promptBuilder) { }
    public void AppendSsml(string path) { }
    public void AppendSsml(System.Uri ssmlFile) { }
    public void AppendSsml(System.Xml.XmlReader ssmlFile) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public void AppendSsmlMarkup(string ssmlMarkup) { }
    public void AppendText(string textToSpeak) { }
    public void AppendText(string textToSpeak, System.Speech.Synthesis.PromptEmphasis emphasis) { }
    public void AppendText(string textToSpeak, System.Speech.Synthesis.PromptRate rate) { }
    public void AppendText(string textToSpeak, System.Speech.Synthesis.PromptVolume volume) { }
    public void AppendTextWithAlias(string textToSpeak, string substitute) { }
    public void AppendTextWithHint(string textToSpeak, System.Speech.Synthesis.SayAs sayAs) { }
    public void AppendTextWithHint(string textToSpeak, string sayAs) { }
    public void AppendTextWithPronunciation(string textToSpeak, string pronunciation) { }
    public void ClearContent() { }
    public void EndParagraph() { }
    public void EndSentence() { }
    public void EndStyle() { }
    public void EndVoice() { }
    public void StartParagraph() { }
    public void StartParagraph(System.Globalization.CultureInfo culture) { }
    public void StartSentence() { }
    public void StartSentence(System.Globalization.CultureInfo culture) { }
    public void StartStyle(System.Speech.Synthesis.PromptStyle style) { }
    public void StartVoice(System.Globalization.CultureInfo culture) { }
    public void StartVoice(System.Speech.Synthesis.VoiceGender gender) { }
    public void StartVoice(System.Speech.Synthesis.VoiceGender gender, System.Speech.Synthesis.VoiceAge age) { }
    public void StartVoice(System.Speech.Synthesis.VoiceGender gender, System.Speech.Synthesis.VoiceAge age, int voiceAlternate) { }
    public void StartVoice(System.Speech.Synthesis.VoiceInfo voice) { }
    public void StartVoice(string name) { }
    public string ToXml() { return default(string); }
  }
  public enum PromptEmphasis {
    Moderate = 2,
    None = 3,
    NotSet = 0,
    Reduced = 4,
    Strong = 1,
  }
  public abstract partial class PromptEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    internal PromptEventArgs() { }
    public System.Speech.Synthesis.Prompt Prompt { get { return default(System.Speech.Synthesis.Prompt); } }
  }
  public enum PromptRate {
    ExtraFast = 1,
    ExtraSlow = 5,
    Fast = 2,
    Medium = 3,
    NotSet = 0,
    Slow = 4,
  }
  public partial class PromptStyle {
    public PromptStyle() { }
    public PromptStyle(System.Speech.Synthesis.PromptEmphasis emphasis) { }
    public PromptStyle(System.Speech.Synthesis.PromptRate rate) { }
    public PromptStyle(System.Speech.Synthesis.PromptVolume volume) { }
    public System.Speech.Synthesis.PromptEmphasis Emphasis { get { return default(System.Speech.Synthesis.PromptEmphasis); } set { } }
    public System.Speech.Synthesis.PromptRate Rate { get { return default(System.Speech.Synthesis.PromptRate); } set { } }
    public System.Speech.Synthesis.PromptVolume Volume { get { return default(System.Speech.Synthesis.PromptVolume); } set { } }
  }
  public enum PromptVolume {
    Default = 7,
    ExtraLoud = 6,
    ExtraSoft = 2,
    Loud = 5,
    Medium = 4,
    NotSet = 0,
    Silent = 1,
    Soft = 3,
  }
  public enum SayAs {
    Date = 3,
    Day = 13,
    DayMonth = 10,
    DayMonthYear = 4,
    Month = 12,
    MonthDay = 9,
    MonthDayYear = 5,
    MonthYear = 8,
    NumberCardinal = 2,
    NumberOrdinal = 1,
    SpellOut = 0,
    Telephone = 17,
    Text = 18,
    Time = 14,
    Time12 = 16,
    Time24 = 15,
    Year = 11,
    YearMonth = 7,
    YearMonthDay = 6,
  }
  public partial class SpeakCompletedEventArgs : System.Speech.Synthesis.PromptEventArgs {
    internal SpeakCompletedEventArgs() { }
  }
  public partial class SpeakProgressEventArgs : System.Speech.Synthesis.PromptEventArgs {
    internal SpeakProgressEventArgs() { }
    public System.TimeSpan AudioPosition { get { return default(System.TimeSpan); } }
    public int CharacterCount { get { return default(int); } }
    public int CharacterPosition { get { return default(int); } }
    public string Text { get { return default(string); } }
  }
  public partial class SpeakStartedEventArgs : System.Speech.Synthesis.PromptEventArgs {
    internal SpeakStartedEventArgs() { }
  }
  public sealed partial class SpeechSynthesizer : System.IDisposable {
    public SpeechSynthesizer() { }
    public int Rate { get { return default(int); } set { } }
    public System.Speech.Synthesis.SynthesizerState State { get { return default(System.Speech.Synthesis.SynthesizerState); } }
    public System.Speech.Synthesis.VoiceInfo Voice { get { return default(System.Speech.Synthesis.VoiceInfo); } }
    public int Volume { get { return default(int); } set { } }
    public event System.EventHandler<System.Speech.Synthesis.BookmarkReachedEventArgs> BookmarkReached { add { } remove { } }
    public event System.EventHandler<System.Speech.Synthesis.PhonemeReachedEventArgs> PhonemeReached { add { } remove { } }
    public event System.EventHandler<System.Speech.Synthesis.SpeakCompletedEventArgs> SpeakCompleted { add { } remove { } }
    public event System.EventHandler<System.Speech.Synthesis.SpeakProgressEventArgs> SpeakProgress { add { } remove { } }
    public event System.EventHandler<System.Speech.Synthesis.SpeakStartedEventArgs> SpeakStarted { add { } remove { } }
    public event System.EventHandler<System.Speech.Synthesis.StateChangedEventArgs> StateChanged { add { } remove { } }
    public event System.EventHandler<System.Speech.Synthesis.VisemeReachedEventArgs> VisemeReached { add { } remove { } }
    public event System.EventHandler<System.Speech.Synthesis.VoiceChangeEventArgs> VoiceChange { add { } remove { } }
    public void AddLexicon(System.Uri uri, string mediaType) { }
    public void Dispose() { }
    ~SpeechSynthesizer() { }
    public System.Speech.Synthesis.Prompt GetCurrentlySpokenPrompt() { return default(System.Speech.Synthesis.Prompt); }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Speech.Synthesis.InstalledVoice> GetInstalledVoices() { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Speech.Synthesis.InstalledVoice>); }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Speech.Synthesis.InstalledVoice> GetInstalledVoices(System.Globalization.CultureInfo culture) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Speech.Synthesis.InstalledVoice>); }
    public void Pause() { }
    public void RemoveLexicon(System.Uri uri) { }
    public void Resume() { }
    public void SelectVoice(string name) { }
    public void SelectVoiceByHints(System.Speech.Synthesis.VoiceGender gender) { }
    public void SelectVoiceByHints(System.Speech.Synthesis.VoiceGender gender, System.Speech.Synthesis.VoiceAge age) { }
    public void SelectVoiceByHints(System.Speech.Synthesis.VoiceGender gender, System.Speech.Synthesis.VoiceAge age, int voiceAlternate) { }
    public void SelectVoiceByHints(System.Speech.Synthesis.VoiceGender gender, System.Speech.Synthesis.VoiceAge age, int voiceAlternate, System.Globalization.CultureInfo culture) { }
    public void SetOutputToAudioStream(System.IO.Stream audioDestination, System.Speech.AudioFormat.SpeechAudioFormatInfo formatInfo) { }
    public void SetOutputToDefaultAudioDevice() { }
    public void SetOutputToNull() { }
    public void SetOutputToWaveFile(string path) { }
    public void SetOutputToWaveFile(string path, System.Speech.AudioFormat.SpeechAudioFormatInfo formatInfo) { }
    public void SetOutputToWaveStream(System.IO.Stream audioDestination) { }
    public void Speak(System.Speech.Synthesis.Prompt prompt) { }
    public void Speak(System.Speech.Synthesis.PromptBuilder promptBuilder) { }
    public void Speak(string textToSpeak) { }
    public void SpeakAsync(System.Speech.Synthesis.Prompt prompt) { }
    public System.Speech.Synthesis.Prompt SpeakAsync(System.Speech.Synthesis.PromptBuilder promptBuilder) { return default(System.Speech.Synthesis.Prompt); }
    public System.Speech.Synthesis.Prompt SpeakAsync(string textToSpeak) { return default(System.Speech.Synthesis.Prompt); }
    public void SpeakAsyncCancel(System.Speech.Synthesis.Prompt prompt) { }
    public void SpeakAsyncCancelAll() { }
    public void SpeakSsml(string textToSpeak) { }
    public System.Speech.Synthesis.Prompt SpeakSsmlAsync(string textToSpeak) { return default(System.Speech.Synthesis.Prompt); }
  }
  public partial class StateChangedEventArgs : System.EventArgs {
    internal StateChangedEventArgs() { }
    public System.Speech.Synthesis.SynthesizerState PreviousState { get { return default(System.Speech.Synthesis.SynthesizerState); } }
    public System.Speech.Synthesis.SynthesizerState State { get { return default(System.Speech.Synthesis.SynthesizerState); } }
  }
  public enum SynthesisMediaType {
    Ssml = 1,
    Text = 0,
    WaveAudio = 2,
  }
  public enum SynthesisTextFormat {
    Ssml = 1,
    Text = 0,
  }
  [System.FlagsAttribute]
  public enum SynthesizerEmphasis {
    Emphasized = 2,
    Stressed = 1,
  }
  public enum SynthesizerState {
    Paused = 2,
    Ready = 0,
    Speaking = 1,
  }
  public partial class VisemeReachedEventArgs : System.Speech.Synthesis.PromptEventArgs {
    internal VisemeReachedEventArgs() { }
    public System.TimeSpan AudioPosition { get { return default(System.TimeSpan); } }
    public System.TimeSpan Duration { get { return default(System.TimeSpan); } }
    public System.Speech.Synthesis.SynthesizerEmphasis Emphasis { get { return default(System.Speech.Synthesis.SynthesizerEmphasis); } }
    public int NextViseme { get { return default(int); } }
    public int Viseme { get { return default(int); } }
  }
  public enum VoiceAge {
    Adult = 30,
    Child = 10,
    NotSet = 0,
    Senior = 65,
    Teen = 15,
  }
  public partial class VoiceChangeEventArgs : System.Speech.Synthesis.PromptEventArgs {
    internal VoiceChangeEventArgs() { }
    public System.Speech.Synthesis.VoiceInfo Voice { get { return default(System.Speech.Synthesis.VoiceInfo); } }
  }
  public enum VoiceGender {
    Female = 2,
    Male = 1,
    Neutral = 3,
    NotSet = 0,
  }
  [System.Diagnostics.DebuggerDisplayAttribute("{(_name != null ? \"'\" + _name + \"' \" : \"\") +  (_culture != null ? \" '\" + _culture.ToString () + \"' \" : \"\") + (_gender != VoiceGender.NotSet ? \" '\" + _gender.ToString () + \"' \" : \"\") + (_age != VoiceAge.NotSet ? \" '\" + _age.ToString () + \"' \" : \"\") + (_variant > 0 ? \" \" + _variant.ToString () : \"\")}")]
  public partial class VoiceInfo {
    internal VoiceInfo() { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public System.Collections.Generic.IDictionary<System.String, System.String> AdditionalInfo { get { return default(System.Collections.Generic.IDictionary<System.String, System.String>); } }
    public System.Speech.Synthesis.VoiceAge Age { get { return default(System.Speech.Synthesis.VoiceAge); } }
    public System.Globalization.CultureInfo Culture { get { return default(System.Globalization.CultureInfo); } }
    public string Description { get { return default(string); } }
    public System.Speech.Synthesis.VoiceGender Gender { get { return default(System.Speech.Synthesis.VoiceGender); } }
    public string Id { get { return default(string); } }
    public string Name { get { return default(string); } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Speech.AudioFormat.SpeechAudioFormatInfo> SupportedAudioFormats { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Speech.AudioFormat.SpeechAudioFormatInfo>); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }
}
namespace System.Speech.Synthesis.TtsEngine {
  [System.ComponentModel.ImmutableObjectAttribute(true)]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct ContourPoint : System.IEquatable<System.Speech.Synthesis.TtsEngine.ContourPoint> {
    public ContourPoint(float start, float change, System.Speech.Synthesis.TtsEngine.ContourPointChangeType changeType) { throw new System.NotImplementedException(); }
    public float Change { get { return default(float); } }
    public System.Speech.Synthesis.TtsEngine.ContourPointChangeType ChangeType { get { return default(System.Speech.Synthesis.TtsEngine.ContourPointChangeType); } }
    public float Start { get { return default(float); } }
    public override bool Equals(object obj) { return default(bool); }
    public bool Equals(System.Speech.Synthesis.TtsEngine.ContourPoint other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Speech.Synthesis.TtsEngine.ContourPoint point1, System.Speech.Synthesis.TtsEngine.ContourPoint point2) { return default(bool); }
    public static bool operator !=(System.Speech.Synthesis.TtsEngine.ContourPoint point1, System.Speech.Synthesis.TtsEngine.ContourPoint point2) { return default(bool); }
  }
  public enum ContourPointChangeType {
    Hz = 0,
    Percentage = 1,
  }
  public enum EmphasisBreak {
    Default = -7,
    ExtraStrong = -6,
    ExtraWeak = -2,
    Medium = -4,
    None = -1,
    Strong = -5,
    Weak = -3,
  }
  public enum EmphasisWord {
    Default = 0,
    Moderate = 2,
    None = 3,
    Reduced = 4,
    Strong = 1,
  }
  public enum EventParameterType {
    Object = 2,
    Pointer = 3,
    String = 4,
    Token = 1,
    Undefined = 0,
  }
  [System.ComponentModel.ImmutableObjectAttribute(true)]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct FragmentState : System.IEquatable<System.Speech.Synthesis.TtsEngine.FragmentState> {
    public FragmentState(System.Speech.Synthesis.TtsEngine.TtsEngineAction action, int langId, int emphasis, int duration, System.Speech.Synthesis.TtsEngine.SayAs sayAs, System.Speech.Synthesis.TtsEngine.Prosody prosody, System.Char[] phonemes) { throw new System.NotImplementedException(); }
    public System.Speech.Synthesis.TtsEngine.TtsEngineAction Action { get { return default(System.Speech.Synthesis.TtsEngine.TtsEngineAction); } }
    public int Duration { get { return default(int); } }
    public int Emphasis { get { return default(int); } }
    public int LangId { get { return default(int); } }
    public System.Char[] Phoneme { get { return default(System.Char[]); } }
    public System.Speech.Synthesis.TtsEngine.Prosody Prosody { get { return default(System.Speech.Synthesis.TtsEngine.Prosody); } }
    public System.Speech.Synthesis.TtsEngine.SayAs SayAs { get { return default(System.Speech.Synthesis.TtsEngine.SayAs); } }
    public override bool Equals(object obj) { return default(bool); }
    public bool Equals(System.Speech.Synthesis.TtsEngine.FragmentState other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Speech.Synthesis.TtsEngine.FragmentState state1, System.Speech.Synthesis.TtsEngine.FragmentState state2) { return default(bool); }
    public static bool operator !=(System.Speech.Synthesis.TtsEngine.FragmentState state1, System.Speech.Synthesis.TtsEngine.FragmentState state2) { return default(bool); }
  }
  public partial interface ITtsEngineSite {
    int Actions { get; }
    int EventInterest { get; }
    int Rate { get; }
    int Volume { get; }
    void AddEvents(System.Speech.Synthesis.TtsEngine.SpeechEventInfo[] events, int count);
    void CompleteSkip(int skipped);
    System.Speech.Synthesis.TtsEngine.SkipInfo GetSkipInfo();
    System.IO.Stream LoadResource(System.Uri uri, string mediaType);
    int Write(System.IntPtr data, int count);
  }
  public partial class Prosody {
    public Prosody() { }
    public int Duration { get { return default(int); } set { } }
    public System.Speech.Synthesis.TtsEngine.ProsodyNumber Pitch { get { return default(System.Speech.Synthesis.TtsEngine.ProsodyNumber); } set { } }
    public System.Speech.Synthesis.TtsEngine.ProsodyNumber Range { get { return default(System.Speech.Synthesis.TtsEngine.ProsodyNumber); } set { } }
    public System.Speech.Synthesis.TtsEngine.ProsodyNumber Rate { get { return default(System.Speech.Synthesis.TtsEngine.ProsodyNumber); } set { } }
    public System.Speech.Synthesis.TtsEngine.ProsodyNumber Volume { get { return default(System.Speech.Synthesis.TtsEngine.ProsodyNumber); } set { } }
    public System.Speech.Synthesis.TtsEngine.ContourPoint[] GetContourPoints() { return default(System.Speech.Synthesis.TtsEngine.ContourPoint[]); }
    public void SetContourPoints(System.Speech.Synthesis.TtsEngine.ContourPoint[] points) { }
  }
  [System.ComponentModel.ImmutableObjectAttribute(true)]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct ProsodyNumber : System.IEquatable<System.Speech.Synthesis.TtsEngine.ProsodyNumber> {
    public const int AbsoluteNumber = 2147483647;
    public ProsodyNumber(int ssmlAttributeId) { throw new System.NotImplementedException(); }
    public ProsodyNumber(float number) { throw new System.NotImplementedException(); }
    public bool IsNumberPercent { get { return default(bool); } }
    public float Number { get { return default(float); } }
    public int SsmlAttributeId { get { return default(int); } }
    public System.Speech.Synthesis.TtsEngine.ProsodyUnit Unit { get { return default(System.Speech.Synthesis.TtsEngine.ProsodyUnit); } }
    public override bool Equals(object obj) { return default(bool); }
    public bool Equals(System.Speech.Synthesis.TtsEngine.ProsodyNumber other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Speech.Synthesis.TtsEngine.ProsodyNumber prosodyNumber1, System.Speech.Synthesis.TtsEngine.ProsodyNumber prosodyNumber2) { return default(bool); }
    public static bool operator !=(System.Speech.Synthesis.TtsEngine.ProsodyNumber prosodyNumber1, System.Speech.Synthesis.TtsEngine.ProsodyNumber prosodyNumber2) { return default(bool); }
  }
  public enum ProsodyPitch {
    Default = 0,
    ExtraHigh = 5,
    ExtraLow = 1,
    High = 4,
    Low = 2,
    Medium = 3,
  }
  public enum ProsodyRange {
    Default = 0,
    ExtraHigh = 5,
    ExtraLow = 1,
    High = 4,
    Low = 2,
    Medium = 3,
  }
  public enum ProsodyRate {
    Default = 0,
    ExtraFast = 5,
    ExtraSlow = 1,
    Fast = 4,
    Medium = 3,
    Slow = 2,
  }
  public enum ProsodyUnit {
    Default = 0,
    Hz = 1,
    Semitone = 2,
  }
  public enum ProsodyVolume {
    Default = -1,
    ExtraLoud = -7,
    ExtraSoft = -3,
    Loud = -6,
    Medium = -5,
    Silent = -2,
    Soft = -4,
  }
  public partial class SayAs {
    public SayAs() { }
    public string Detail { get { return default(string); } set { } }
    public string Format { get { return default(string); } set { } }
    public string InterpretAs { get { return default(string); } set { } }
  }
  public partial class SkipInfo {
    public SkipInfo() { }
    public int Count { get { return default(int); } set { } }
    public int Type { get { return default(int); } set { } }
  }
  public enum SpeakOutputFormat {
    Text = 1,
    WaveFormat = 0,
  }
  [System.ComponentModel.ImmutableObjectAttribute(true)]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct SpeechEventInfo : System.IEquatable<System.Speech.Synthesis.TtsEngine.SpeechEventInfo> {
    public SpeechEventInfo(short eventId, short parameterType, int param1, System.IntPtr param2) { throw new System.NotImplementedException(); }
    public short EventId { get { return default(short); } }
    public int Param1 { get { return default(int); } }
    public System.IntPtr Param2 { get { return default(System.IntPtr); } }
    public short ParameterType { get { return default(short); } }
    public override bool Equals(object obj) { return default(bool); }
    public bool Equals(System.Speech.Synthesis.TtsEngine.SpeechEventInfo other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Speech.Synthesis.TtsEngine.SpeechEventInfo event1, System.Speech.Synthesis.TtsEngine.SpeechEventInfo event2) { return default(bool); }
    public static bool operator !=(System.Speech.Synthesis.TtsEngine.SpeechEventInfo event1, System.Speech.Synthesis.TtsEngine.SpeechEventInfo event2) { return default(bool); }
  }
  public partial class TextFragment {
    public TextFragment() { }
    public System.Speech.Synthesis.TtsEngine.FragmentState State { get { return default(System.Speech.Synthesis.TtsEngine.FragmentState); } set { } }
    public int TextLength { get { return default(int); } set { } }
    public int TextOffset { get { return default(int); } set { } }
    public string TextToSpeak { get { return default(string); } set { } }
  }
  public enum TtsEngineAction {
    Bookmark = 3,
    ParseUnknownTag = 7,
    Pronounce = 2,
    Silence = 1,
    Speak = 0,
    SpellOut = 4,
    StartParagraph = 6,
    StartSentence = 5,
  }
  public abstract partial class TtsEngineSsml {
    protected TtsEngineSsml(string registryKey) { }
    public abstract void AddLexicon(System.Uri uri, string mediaType, System.Speech.Synthesis.TtsEngine.ITtsEngineSite site);
    public abstract System.IntPtr GetOutputFormat(System.Speech.Synthesis.TtsEngine.SpeakOutputFormat speakOutputFormat, System.IntPtr targetWaveFormat);
    public abstract void RemoveLexicon(System.Uri uri, System.Speech.Synthesis.TtsEngine.ITtsEngineSite site);
    public abstract void Speak(System.Speech.Synthesis.TtsEngine.TextFragment[] fragment, System.IntPtr waveHeader, System.Speech.Synthesis.TtsEngine.ITtsEngineSite site);
  }
  public enum TtsEventId {
    AudioLevel = 9,
    Bookmark = 4,
    EndInputStream = 2,
    Phoneme = 6,
    SentenceBoundary = 7,
    StartInputStream = 1,
    Viseme = 8,
    VoiceChange = 3,
    WordBoundary = 5,
  }
}
