namespace I18N.Common {
  public abstract partial class ByteEncoding : I18N.Common.MonoEncoding {
    protected string bodyName;
    protected string encodingName;
    protected string headerName;
    protected bool isBrowserDisplay;
    protected bool isBrowserSave;
    protected bool isMailNewsDisplay;
    protected bool isMailNewsSave;
    protected System.Char[] toChars;
    protected string webName;
    protected int windowsCodePage;
    protected ByteEncoding(int codePage, System.Char[] toChars, string encodingName, string bodyName, string headerName, string webName, bool isBrowserDisplay, bool isBrowserSave, bool isMailNewsDisplay, bool isMailNewsSave, int windowsCodePage) : base (default(int)) { }
    public override string BodyName { get { return default(string); } }
    public override string EncodingName { get { return default(string); } }
    public override string HeaderName { get { return default(string); } }
    public override bool IsBrowserDisplay { get { return default(bool); } }
    public override bool IsBrowserSave { get { return default(bool); } }
    public override bool IsMailNewsDisplay { get { return default(bool); } }
    public override bool IsMailNewsSave { get { return default(bool); } }
    public override bool IsSingleByte { get { return default(bool); } }
    public override string WebName { get { return default(string); } }
    public override int WindowsCodePage { get { return default(int); } }
    public override int GetByteCount(string s) { return default(int); }
    public unsafe override int GetByteCountImpl(char* chars, int count) { return default(int); }
    public unsafe override int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount) { return default(int); }
    public override int GetCharCount(System.Byte[] bytes, int index, int count) { return default(int); }
    public override int GetChars(System.Byte[] bytes, int byteIndex, int byteCount, System.Char[] chars, int charIndex) { return default(int); }
    public override int GetMaxByteCount(int charCount) { return default(int); }
    public override int GetMaxCharCount(int byteCount) { return default(int); }
    public override string GetString(System.Byte[] bytes) { return default(string); }
    public override string GetString(System.Byte[] bytes, int index, int count) { return default(string); }
    public override bool IsAlwaysNormalized(System.Text.NormalizationForm form) { return default(bool); }
    protected unsafe abstract void ToBytes(char* chars, int charCount, byte* bytes, int byteCount);
    protected virtual void ToBytes(System.Char[] chars, int charIndex, int charCount, System.Byte[] bytes, int byteIndex) { }
  }
  public abstract partial class ByteSafeEncoding : I18N.Common.MonoSafeEncoding {
    protected string bodyName;
    protected string encodingName;
    protected string headerName;
    protected bool isBrowserDisplay;
    protected bool isBrowserSave;
    protected bool isMailNewsDisplay;
    protected bool isMailNewsSave;
    protected System.Char[] toChars;
    protected string webName;
    protected int windowsCodePage;
    protected ByteSafeEncoding(int codePage, System.Char[] toChars, string encodingName, string bodyName, string headerName, string webName, bool isBrowserDisplay, bool isBrowserSave, bool isMailNewsDisplay, bool isMailNewsSave, int windowsCodePage) : base (default(int)) { }
    public override string BodyName { get { return default(string); } }
    public override string EncodingName { get { return default(string); } }
    public override string HeaderName { get { return default(string); } }
    public override bool IsBrowserDisplay { get { return default(bool); } }
    public override bool IsBrowserSave { get { return default(bool); } }
    public override bool IsMailNewsDisplay { get { return default(bool); } }
    public override bool IsMailNewsSave { get { return default(bool); } }
    public override bool IsSingleByte { get { return default(bool); } }
    public override string WebName { get { return default(string); } }
    public override int WindowsCodePage { get { return default(int); } }
    public unsafe override int GetByteCount(char* chars, int count) { return default(int); }
    public override int GetByteCount(System.Char[] chars, int index, int count) { return default(int); }
    public override int GetByteCount(string s) { return default(int); }
    public override int GetBytes(System.Char[] chars, int charIndex, int charCount, System.Byte[] bytes, int byteIndex) { return default(int); }
    public override System.Byte[] GetBytes(string s) { return default(System.Byte[]); }
    public override int GetBytes(string s, int charIndex, int charCount, System.Byte[] bytes, int byteIndex) { return default(int); }
    public override int GetCharCount(System.Byte[] bytes, int index, int count) { return default(int); }
    public override int GetChars(System.Byte[] bytes, int byteIndex, int byteCount, System.Char[] chars, int charIndex) { return default(int); }
    public override int GetMaxByteCount(int charCount) { return default(int); }
    public override int GetMaxCharCount(int byteCount) { return default(int); }
    public override string GetString(System.Byte[] bytes) { return default(string); }
    public override string GetString(System.Byte[] bytes, int index, int count) { return default(string); }
    public override bool IsAlwaysNormalized(System.Text.NormalizationForm form) { return default(bool); }
    protected abstract void ToBytes(System.Char[] chars, int charIndex, int charCount, System.Byte[] bytes, int byteIndex);
    protected virtual void ToBytes(string s, int charIndex, int charCount, System.Byte[] bytes, int byteIndex) { }
  }
  public sealed partial class Handlers {
    public static readonly System.String[] List;
    public Handlers() { }
    public static string GetAlias(string name) { return default(string); }
  }
  public partial class Manager {
    internal Manager() { }
    public static I18N.Common.Manager PrimaryManager { get { return default(I18N.Common.Manager); } }
    public System.Globalization.CultureInfo GetCulture(int culture, bool useUserOverride) { return default(System.Globalization.CultureInfo); }
    public System.Globalization.CultureInfo GetCulture(string name, bool useUserOverride) { return default(System.Globalization.CultureInfo); }
    public System.Text.Encoding GetEncoding(int codePage) { return default(System.Text.Encoding); }
    public System.Text.Encoding GetEncoding(string name) { return default(System.Text.Encoding); }
  }
  public abstract partial class MonoEncoder : System.Text.Encoder {
    public MonoEncoder(I18N.Common.MonoEncoding encoding) { }
    public override int GetByteCount(System.Char[] chars, int index, int count, bool refresh) { return default(int); }
    public unsafe abstract int GetByteCountImpl(char* chars, int charCount, bool refresh);
    public unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { return default(int); }
    public override int GetBytes(System.Char[] chars, int charIndex, int charCount, System.Byte[] bytes, int byteIndex, bool flush) { return default(int); }
    public unsafe abstract int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount, bool refresh);
    public unsafe void HandleFallback(char* chars, ref int charIndex, ref int charCount, byte* bytes, ref int byteIndex, ref int byteCount, object state) { }
  }
  public abstract partial class MonoEncoding : System.Text.Encoding {
    public MonoEncoding(int codePage) { }
    public MonoEncoding(int codePage, int windowsCodePage) { }
    public override int WindowsCodePage { get { return default(int); } }
    public unsafe override int GetByteCount(char* chars, int count) { return default(int); }
    public override int GetByteCount(System.Char[] chars, int index, int count) { return default(int); }
    public unsafe abstract int GetByteCountImpl(char* chars, int charCount);
    public unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { return default(int); }
    public override int GetBytes(System.Char[] chars, int charIndex, int charCount, System.Byte[] bytes, int byteIndex) { return default(int); }
    public override int GetBytes(string s, int charIndex, int charCount, System.Byte[] bytes, int byteIndex) { return default(int); }
    public unsafe abstract int GetBytesImpl(char* chars, int charCount, byte* bytes, int byteCount);
    protected unsafe virtual int GetBytesInternal(char* chars, int charCount, byte* bytes, int byteCount, bool flush, object state) { return default(int); }
    public unsafe void HandleFallback(ref System.Text.EncoderFallbackBuffer buffer, char* chars, ref int charIndex, ref int charCount, byte* bytes, ref int byteIndex, ref int byteCount) { }
    public unsafe void HandleFallback(ref System.Text.EncoderFallbackBuffer buffer, char* chars, ref int charIndex, ref int charCount, byte* bytes, ref int byteIndex, ref int byteCount, object state) { }
  }
  public abstract partial class MonoSafeEncoder : System.Text.Encoder {
    public MonoSafeEncoder(I18N.Common.MonoSafeEncoding encoding) { }
    public void HandleFallback(System.Char[] chars, ref int charIndex, ref int charCount, System.Byte[] bytes, ref int byteIndex, ref int byteCount, object state) { }
  }
  public abstract partial class MonoSafeEncoding : System.Text.Encoding {
    public MonoSafeEncoding(int codePage) { }
    public MonoSafeEncoding(int codePage, int windowsCodePage) { }
    public override int WindowsCodePage { get { return default(int); } }
    protected virtual int GetBytesInternal(System.Char[] chars, int charIndex, int charCount, System.Byte[] bytes, int byteIndex, bool flush, object state) { return default(int); }
    public void HandleFallback(ref System.Text.EncoderFallbackBuffer buffer, System.Char[] chars, ref int charIndex, ref int charCount, System.Byte[] bytes, ref int byteIndex, ref int byteCount, object state) { }
  }
  public sealed partial class Strings {
    public Strings() { }
    public static string GetString(string tag) { return default(string); }
  }
}
