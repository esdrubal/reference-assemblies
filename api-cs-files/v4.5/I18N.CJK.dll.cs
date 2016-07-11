namespace I18N.CJK {
  public partial class CP50220 : I18N.CJK.ISO2022JPEncoding {
    public CP50220() : base (default(int), default(bool), default(bool)) { }
    public override string EncodingName { get { return default(string); } }
  }
  public partial class CP50221 : I18N.CJK.ISO2022JPEncoding {
    public CP50221() : base (default(int), default(bool), default(bool)) { }
    public override string EncodingName { get { return default(string); } }
  }
  public partial class CP50222 : I18N.CJK.ISO2022JPEncoding {
    public CP50222() : base (default(int), default(bool), default(bool)) { }
    public override string EncodingName { get { return default(string); } }
  }
  public partial class CP51932 : I18N.Common.MonoSafeEncoding {
    public CP51932() : base (default(int)) { }
    public override string BodyName { get { return default(string); } }
    public override string EncodingName { get { return default(string); } }
    public override string HeaderName { get { return default(string); } }
    public override bool IsBrowserDisplay { get { return default(bool); } }
    public override bool IsBrowserSave { get { return default(bool); } }
    public override bool IsMailNewsDisplay { get { return default(bool); } }
    public override bool IsMailNewsSave { get { return default(bool); } }
    public override string WebName { get { return default(string); } }
    public override int GetByteCount(System.Char[] chars, int index, int length) { return default(int); }
    public override int GetBytes(System.Char[] chars, int charIndex, int charCount, System.Byte[] bytes, int byteIndex) { return default(int); }
    public override int GetCharCount(System.Byte[] bytes, int index, int count) { return default(int); }
    public override int GetChars(System.Byte[] bytes, int byteIndex, int byteCount, System.Char[] chars, int charIndex) { return default(int); }
    public override System.Text.Decoder GetDecoder() { return default(System.Text.Decoder); }
    public override System.Text.Encoder GetEncoder() { return default(System.Text.Encoder); }
    public override int GetMaxByteCount(int charCount) { return default(int); }
    public override int GetMaxCharCount(int byteCount) { return default(int); }
  }
  public partial class CP51932Encoder : I18N.Common.MonoSafeEncoder {
    public CP51932Encoder(I18N.Common.MonoSafeEncoding encoding) : base (default(I18N.Common.MonoSafeEncoding)) { }
    public override int GetByteCount(System.Char[] chars, int index, int count, bool flush) { return default(int); }
    public override int GetBytes(System.Char[] chars, int charIndex, int charCount, System.Byte[] bytes, int byteIndex, bool flush) { return default(int); }
  }
  public partial class CP54936 : I18N.CJK.GB18030Encoding {
    public CP54936() { }
  }
  public partial class CP932 : I18N.Common.MonoSafeEncoding {
    public CP932() : base (default(int)) { }
    public override string BodyName { get { return default(string); } }
    public override string EncodingName { get { return default(string); } }
    public override string HeaderName { get { return default(string); } }
    public override bool IsBrowserDisplay { get { return default(bool); } }
    public override bool IsBrowserSave { get { return default(bool); } }
    public override bool IsMailNewsDisplay { get { return default(bool); } }
    public override bool IsMailNewsSave { get { return default(bool); } }
    public override string WebName { get { return default(string); } }
    public override int WindowsCodePage { get { return default(int); } }
    public override int GetByteCount(System.Char[] chars, int index, int count) { return default(int); }
    public override int GetBytes(System.Char[] chars, int charIndex, int charCount, System.Byte[] bytes, int byteIndex) { return default(int); }
    public override int GetCharCount(System.Byte[] bytes, int index, int count) { return default(int); }
    public override int GetChars(System.Byte[] bytes, int byteIndex, int byteCount, System.Char[] chars, int charIndex) { return default(int); }
    public override System.Text.Decoder GetDecoder() { return default(System.Text.Decoder); }
    public override System.Text.Encoder GetEncoder() { return default(System.Text.Encoder); }
    public override int GetMaxByteCount(int charCount) { return default(int); }
    public override int GetMaxCharCount(int byteCount) { return default(int); }
  }
  public partial class ENCeuc_jp : I18N.CJK.CP51932 {
    public ENCeuc_jp() { }
  }
  public partial class ENCiso_2022_jp : I18N.CJK.CP50220 {
    public ENCiso_2022_jp() { }
  }
  public partial class ENCshift_jis : I18N.CJK.CP932 {
    public ENCshift_jis() { }
  }
  public partial class GB18030Encoding : I18N.Common.MonoSafeEncoding {
    public GB18030Encoding() : base (default(int)) { }
    public override string BodyName { get { return default(string); } }
    public override string EncodingName { get { return default(string); } }
    public override string HeaderName { get { return default(string); } }
    public override bool IsBrowserDisplay { get { return default(bool); } }
    public override bool IsBrowserSave { get { return default(bool); } }
    public override bool IsMailNewsDisplay { get { return default(bool); } }
    public override bool IsMailNewsSave { get { return default(bool); } }
    public override string WebName { get { return default(string); } }
    public override int GetByteCount(System.Char[] chars, int index, int length) { return default(int); }
    public override int GetBytes(System.Char[] chars, int charIndex, int charCount, System.Byte[] bytes, int byteIndex) { return default(int); }
    public override int GetCharCount(System.Byte[] bytes, int start, int len) { return default(int); }
    public override int GetChars(System.Byte[] bytes, int byteIdx, int srclen, System.Char[] chars, int charIdx) { return default(int); }
    public override System.Text.Decoder GetDecoder() { return default(System.Text.Decoder); }
    public override System.Text.Encoder GetEncoder() { return default(System.Text.Encoder); }
    public override int GetMaxByteCount(int len) { return default(int); }
    public override int GetMaxCharCount(int len) { return default(int); }
  }
  public partial class ISO2022JPEncoding : I18N.Common.MonoSafeEncoding {
    public ISO2022JPEncoding(int codePage, bool allow1ByteKana, bool allowShiftIO) : base (default(int)) { }
    public override string BodyName { get { return default(string); } }
    public override string HeaderName { get { return default(string); } }
    public override string WebName { get { return default(string); } }
    public override int GetByteCount(System.Char[] chars, int charIndex, int charCount) { return default(int); }
    public override int GetBytes(System.Char[] chars, int charIndex, int charCount, System.Byte[] bytes, int byteIndex) { return default(int); }
    protected override int GetBytesInternal(System.Char[] chars, int charIndex, int charCount, System.Byte[] bytes, int byteIndex, bool flush, object state) { return default(int); }
    public override int GetCharCount(System.Byte[] bytes, int index, int count) { return default(int); }
    public override int GetChars(System.Byte[] bytes, int byteIndex, int byteCount, System.Char[] chars, int charIndex) { return default(int); }
    public override int GetMaxByteCount(int charCount) { return default(int); }
    public override int GetMaxCharCount(int byteCount) { return default(int); }
  }
}
