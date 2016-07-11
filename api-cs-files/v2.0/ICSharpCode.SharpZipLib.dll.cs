namespace ICSharpCode.SharpZipLib {
  public partial class SharpZipBaseException : System.ApplicationException {
    public SharpZipBaseException() { }
    public SharpZipBaseException(string msg) { }
    public SharpZipBaseException(string message, System.Exception innerException) { }
  }
}
namespace ICSharpCode.SharpZipLib.BZip2 {
  public sealed partial class BZip2 {
    public BZip2() { }
    public static void Compress(System.IO.Stream instream, System.IO.Stream outstream, int blockSize) { }
    public static void Decompress(System.IO.Stream instream, System.IO.Stream outstream) { }
  }
  public sealed partial class BZip2Constants {
    internal BZip2Constants() { }
    public static readonly int baseBlockSize;
    public static readonly int G_SIZE;
    public static readonly int MAX_ALPHA_SIZE;
    public static readonly int MAX_CODE_LEN;
    public static readonly int MAX_SELECTORS;
    public static readonly int N_GROUPS;
    public static readonly int N_ITERS;
    public static readonly int NUM_OVERSHOOT_BYTES;
    public static readonly System.Int32[] rNums;
    public static readonly int RUNA;
    public static readonly int RUNB;
  }
  public partial class BZip2Exception : ICSharpCode.SharpZipLib.SharpZipBaseException {
    public BZip2Exception() { }
    public BZip2Exception(string message) { }
  }
  public partial class BZip2InputStream : System.IO.Stream {
    public BZip2InputStream(System.IO.Stream stream) { }
    public override bool CanRead { get { return default(bool); } }
    public override bool CanSeek { get { return default(bool); } }
    public override bool CanWrite { get { return default(bool); } }
    public override long Length { get { return default(long); } }
    public override long Position { get { return default(long); } set { } }
    public override void Close() { }
    public override void Flush() { }
    public override int Read(System.Byte[] b, int offset, int count) { return default(int); }
    public override int ReadByte() { return default(int); }
    public override long Seek(long offset, System.IO.SeekOrigin origin) { return default(long); }
    public override void SetLength(long val) { }
    public override void Write(System.Byte[] array, int offset, int count) { }
    public override void WriteByte(byte val) { }
  }
  public partial class BZip2OutputStream : System.IO.Stream {
    public BZip2OutputStream(System.IO.Stream stream) { }
    public BZip2OutputStream(System.IO.Stream stream, int blockSize) { }
    public override bool CanRead { get { return default(bool); } }
    public override bool CanSeek { get { return default(bool); } }
    public override bool CanWrite { get { return default(bool); } }
    public override long Length { get { return default(long); } }
    public override long Position { get { return default(long); } set { } }
    public override void Close() { }
    ~BZip2OutputStream() { }
    public override void Flush() { }
    public override int Read(System.Byte[] b, int off, int len) { return default(int); }
    public override int ReadByte() { return default(int); }
    public override long Seek(long offset, System.IO.SeekOrigin origin) { return default(long); }
    public override void SetLength(long val) { }
    public override void Write(System.Byte[] buf, int off, int len) { }
    public override void WriteByte(byte bv) { }
  }
}
namespace ICSharpCode.SharpZipLib.Checksums {
  public sealed partial class Adler32 : ICSharpCode.SharpZipLib.Checksums.IChecksum {
    public Adler32() { }
    public long Value { get { return default(long); } }
    public void Reset() { }
    public void Update(System.Byte[] buffer) { }
    public void Update(System.Byte[] buf, int off, int len) { }
    public void Update(int bval) { }
  }
  public sealed partial class Crc32 : ICSharpCode.SharpZipLib.Checksums.IChecksum {
    public Crc32() { }
    public long Value { get { return default(long); } set { } }
    public void Reset() { }
    public void Update(System.Byte[] buffer) { }
    public void Update(System.Byte[] buf, int off, int len) { }
    public void Update(int bval) { }
  }
  public partial interface IChecksum {
    long Value { get; }
    void Reset();
    void Update(System.Byte[] buffer);
    void Update(System.Byte[] buf, int off, int len);
    void Update(int bval);
  }
  public partial class StrangeCRC : ICSharpCode.SharpZipLib.Checksums.IChecksum {
    public StrangeCRC() { }
    public long Value { get { return default(long); } }
    public void Reset() { }
    public void Update(System.Byte[] buf) { }
    public void Update(System.Byte[] buf, int off, int len) { }
    public void Update(int inCh) { }
  }
}
namespace ICSharpCode.SharpZipLib.Core {
  public partial class DirectoryEventArgs : ICSharpCode.SharpZipLib.Core.ScanEventArgs {
    public DirectoryEventArgs(string name, bool hasMatchingFiles) : base (default(string)) { }
    public bool HasMatchingFiles { get { return default(bool); } }
  }
  public delegate void DirectoryFailureDelegate(object sender, ICSharpCode.SharpZipLib.Core.ScanFailureEventArgs e);
  public delegate void FileFailureDelegate(object sender, ICSharpCode.SharpZipLib.Core.ScanFailureEventArgs e);
  public partial class FileSystemScanner {
    public ICSharpCode.SharpZipLib.Core.DirectoryFailureDelegate DirectoryFailure;
    public ICSharpCode.SharpZipLib.Core.FileFailureDelegate FileFailure;
    public ICSharpCode.SharpZipLib.Core.ProcessDirectoryDelegate ProcessDirectory;
    public ICSharpCode.SharpZipLib.Core.ProcessFileDelegate ProcessFile;
    public FileSystemScanner(ICSharpCode.SharpZipLib.Core.IScanFilter fileFilter) { }
    public FileSystemScanner(ICSharpCode.SharpZipLib.Core.IScanFilter fileFilter, ICSharpCode.SharpZipLib.Core.IScanFilter directoryFilter) { }
    public FileSystemScanner(string filter) { }
    public FileSystemScanner(string fileFilter, string directoryFilter) { }
    public void OnDirectoryFailure(string directory, System.Exception e) { }
    public void OnFileFailure(string file, System.Exception e) { }
    public void OnProcessDirectory(string directory, bool hasMatchingFiles) { }
    public void OnProcessFile(string file) { }
    public void Scan(string directory, bool recurse) { }
  }
  public partial interface INameTransform {
    string TransformDirectory(string name);
    string TransformFile(string name);
  }
  public partial interface IScanFilter {
    bool IsMatch(string name);
  }
  public partial class NameAndSizeFilter : ICSharpCode.SharpZipLib.Core.PathFilter {
    public NameAndSizeFilter(string filter, long minSize, long maxSize) : base (default(string)) { }
    public long MaxSize { get { return default(long); } set { } }
    public long MinSize { get { return default(long); } set { } }
    public override bool IsMatch(string fileName) { return default(bool); }
  }
  public partial class NameFilter {
    public NameFilter(string filter) { }
    public bool IsExcluded(string testValue) { return default(bool); }
    public bool IsIncluded(string testValue) { return default(bool); }
    public bool IsMatch(string testValue) { return default(bool); }
    public static bool IsValidExpression(string e) { return default(bool); }
    public static bool IsValidFilterExpression(string toTest) { return default(bool); }
    public override string ToString() { return default(string); }
  }
  public partial class PathFilter : ICSharpCode.SharpZipLib.Core.IScanFilter {
    public PathFilter(string filter) { }
    public virtual bool IsMatch(string name) { return default(bool); }
  }
  public delegate void ProcessDirectoryDelegate(object Sender, ICSharpCode.SharpZipLib.Core.DirectoryEventArgs e);
  public delegate void ProcessFileDelegate(object sender, ICSharpCode.SharpZipLib.Core.ScanEventArgs e);
  public partial class ScanEventArgs : System.EventArgs {
    public ScanEventArgs(string name) { }
    public bool ContinueRunning { get { return default(bool); } set { } }
    public string Name { get { return default(string); } }
  }
  public partial class ScanFailureEventArgs {
    public ScanFailureEventArgs(string name, System.Exception e) { }
    public bool ContinueRunning { get { return default(bool); } set { } }
    public System.Exception Exception { get { return default(System.Exception); } }
    public string Name { get { return default(string); } }
  }
}
namespace ICSharpCode.SharpZipLib.Encryption {
  public abstract partial class PkzipClassic : System.Security.Cryptography.SymmetricAlgorithm {
    protected PkzipClassic() { }
    public static System.Byte[] GenerateKeys(System.Byte[] seed) { return default(System.Byte[]); }
  }
  public sealed partial class PkzipClassicManaged : ICSharpCode.SharpZipLib.Encryption.PkzipClassic {
    public PkzipClassicManaged() { }
    public override int BlockSize { get { return default(int); } set { } }
    public override System.Byte[] Key { get { return default(System.Byte[]); } set { } }
    public override System.Security.Cryptography.KeySizes[] LegalBlockSizes { get { return default(System.Security.Cryptography.KeySizes[]); } }
    public override System.Security.Cryptography.KeySizes[] LegalKeySizes { get { return default(System.Security.Cryptography.KeySizes[]); } }
    public override System.Security.Cryptography.ICryptoTransform CreateDecryptor(System.Byte[] rgbKey, System.Byte[] rgbIV) { return default(System.Security.Cryptography.ICryptoTransform); }
    public override System.Security.Cryptography.ICryptoTransform CreateEncryptor(System.Byte[] rgbKey, System.Byte[] rgbIV) { return default(System.Security.Cryptography.ICryptoTransform); }
    public override void GenerateIV() { }
    public override void GenerateKey() { }
  }
}
namespace ICSharpCode.SharpZipLib.GZip {
  public partial class GZipConstants {
    internal GZipConstants() { }
    public const int FCOMMENT = 16;
    public const int FEXTRA = 4;
    public const int FHCRC = 2;
    public const int FNAME = 8;
    public const int FTEXT = 1;
    public static readonly int GZIP_MAGIC;
  }
  public partial class GZipException : ICSharpCode.SharpZipLib.SharpZipBaseException {
    public GZipException() { }
    public GZipException(string message) { }
  }
  public partial class GZipInputStream : ICSharpCode.SharpZipLib.Zip.Compression.Streams.InflaterInputStream {
    protected ICSharpCode.SharpZipLib.Checksums.Crc32 crc;
    protected bool eos;
    public GZipInputStream(System.IO.Stream baseInputStream) : base (default(System.IO.Stream)) { }
    public GZipInputStream(System.IO.Stream baseInputStream, int size) : base (default(System.IO.Stream)) { }
    public override int Read(System.Byte[] buf, int offset, int len) { return default(int); }
  }
  public partial class GZipOutputStream : ICSharpCode.SharpZipLib.Zip.Compression.Streams.DeflaterOutputStream {
    protected ICSharpCode.SharpZipLib.Checksums.Crc32 crc;
    public GZipOutputStream(System.IO.Stream baseOutputStream) : base (default(System.IO.Stream)) { }
    public GZipOutputStream(System.IO.Stream baseOutputStream, int size) : base (default(System.IO.Stream)) { }
    public override void Close() { }
    public override void Finish() { }
    public int GetLevel() { return default(int); }
    public void SetLevel(int level) { }
    public override void Write(System.Byte[] buf, int off, int len) { }
  }
}
namespace ICSharpCode.SharpZipLib.Tar {
  public partial class InvalidHeaderException : ICSharpCode.SharpZipLib.Tar.TarException {
    public InvalidHeaderException() { }
    public InvalidHeaderException(string msg) { }
  }
  public delegate void ProgressMessageHandler(ICSharpCode.SharpZipLib.Tar.TarArchive archive, ICSharpCode.SharpZipLib.Tar.TarEntry entry, string message);
  public partial class TarArchive {
    protected TarArchive() { }
    public bool ApplyUserInfoOverrides { get { return default(bool); } set { } }
    public int GroupId { get { return default(int); } }
    public string GroupName { get { return default(string); } }
    public string PathPrefix { get { return default(string); } set { } }
    public int RecordSize { get { return default(int); } }
    public string RootPath { get { return default(string); } set { } }
    public int UserId { get { return default(int); } }
    public string UserName { get { return default(string); } }
    public event ICSharpCode.SharpZipLib.Tar.ProgressMessageHandler ProgressMessageEvent { add { } remove { } }
    public void CloseArchive() { }
    public static ICSharpCode.SharpZipLib.Tar.TarArchive CreateInputTarArchive(System.IO.Stream inputStream) { return default(ICSharpCode.SharpZipLib.Tar.TarArchive); }
    public static ICSharpCode.SharpZipLib.Tar.TarArchive CreateInputTarArchive(System.IO.Stream inputStream, int blockFactor) { return default(ICSharpCode.SharpZipLib.Tar.TarArchive); }
    public static ICSharpCode.SharpZipLib.Tar.TarArchive CreateOutputTarArchive(System.IO.Stream outputStream) { return default(ICSharpCode.SharpZipLib.Tar.TarArchive); }
    public static ICSharpCode.SharpZipLib.Tar.TarArchive CreateOutputTarArchive(System.IO.Stream outputStream, int blockFactor) { return default(ICSharpCode.SharpZipLib.Tar.TarArchive); }
    public void ExtractContents(string destDir) { }
    public void ListContents() { }
    protected virtual void OnProgressMessageEvent(ICSharpCode.SharpZipLib.Tar.TarEntry entry, string message) { }
    public void SetAsciiTranslation(bool asciiTranslate) { }
    public void SetKeepOldFiles(bool keepOldFiles) { }
    public void SetUserInfo(int userId, string userName, int groupId, string groupName) { }
    public void WriteEntry(ICSharpCode.SharpZipLib.Tar.TarEntry sourceEntry, bool recurse) { }
  }
  public partial class TarBuffer {
    public const int BlockSize = 512;
    public const int DefaultBlockFactor = 20;
    public const int DefaultRecordSize = 10240;
    protected TarBuffer() { }
    public int BlockFactor { get { return default(int); } }
    public int RecordSize { get { return default(int); } }
    public void Close() { }
    public static ICSharpCode.SharpZipLib.Tar.TarBuffer CreateInputTarBuffer(System.IO.Stream inputStream) { return default(ICSharpCode.SharpZipLib.Tar.TarBuffer); }
    public static ICSharpCode.SharpZipLib.Tar.TarBuffer CreateInputTarBuffer(System.IO.Stream inputStream, int blockFactor) { return default(ICSharpCode.SharpZipLib.Tar.TarBuffer); }
    public static ICSharpCode.SharpZipLib.Tar.TarBuffer CreateOutputTarBuffer(System.IO.Stream outputStream) { return default(ICSharpCode.SharpZipLib.Tar.TarBuffer); }
    public static ICSharpCode.SharpZipLib.Tar.TarBuffer CreateOutputTarBuffer(System.IO.Stream outputStream, int blockFactor) { return default(ICSharpCode.SharpZipLib.Tar.TarBuffer); }
    public int GetBlockFactor() { return default(int); }
    public int GetCurrentBlockNum() { return default(int); }
    public int GetCurrentRecordNum() { return default(int); }
    public int GetRecordSize() { return default(int); }
    public bool IsEOFBlock(System.Byte[] block) { return default(bool); }
    public System.Byte[] ReadBlock() { return default(System.Byte[]); }
    public void SkipBlock() { }
    public void WriteBlock(System.Byte[] block) { }
    public void WriteBlock(System.Byte[] buf, int offset) { }
  }
  public partial class TarEntry : System.ICloneable {
    public TarEntry(ICSharpCode.SharpZipLib.Tar.TarHeader header) { }
    public TarEntry(System.Byte[] headerBuf) { }
    public string File { get { return default(string); } }
    public int GroupId { get { return default(int); } set { } }
    public string GroupName { get { return default(string); } set { } }
    public bool IsDirectory { get { return default(bool); } }
    public System.DateTime ModTime { get { return default(System.DateTime); } set { } }
    public string Name { get { return default(string); } set { } }
    public long Size { get { return default(long); } set { } }
    public ICSharpCode.SharpZipLib.Tar.TarHeader TarHeader { get { return default(ICSharpCode.SharpZipLib.Tar.TarHeader); } }
    public int UserId { get { return default(int); } set { } }
    public string UserName { get { return default(string); } set { } }
    public void AdjustEntryName(System.Byte[] outbuf, string newName) { }
    public object Clone() { return default(object); }
    public static ICSharpCode.SharpZipLib.Tar.TarEntry CreateEntryFromFile(string fileName) { return default(ICSharpCode.SharpZipLib.Tar.TarEntry); }
    public static ICSharpCode.SharpZipLib.Tar.TarEntry CreateTarEntry(string name) { return default(ICSharpCode.SharpZipLib.Tar.TarEntry); }
    public override bool Equals(object it) { return default(bool); }
    public ICSharpCode.SharpZipLib.Tar.TarEntry[] GetDirectoryEntries() { return default(ICSharpCode.SharpZipLib.Tar.TarEntry[]); }
    public void GetFileTarHeader(ICSharpCode.SharpZipLib.Tar.TarHeader hdr, string file) { }
    public override int GetHashCode() { return default(int); }
    public bool IsDescendent(ICSharpCode.SharpZipLib.Tar.TarEntry desc) { return default(bool); }
    public void NameTarHeader(ICSharpCode.SharpZipLib.Tar.TarHeader hdr, string name) { }
    public void SetIds(int userId, int groupId) { }
    public void SetNames(string userName, string groupName) { }
    public void WriteEntryHeader(System.Byte[] outbuf) { }
  }
  public partial class TarException : ICSharpCode.SharpZipLib.SharpZipBaseException {
    public TarException() { }
    public TarException(string message) { }
  }
  public partial class TarHeader : System.ICloneable {
    public static readonly int CHKSUMLEN;
    public const int CHKSUMOFS = 148;
    public static readonly int DEVLEN;
    public static readonly int GIDLEN;
    public static readonly int GNAMELEN;
    public static readonly string GNU_TMAGIC;
    public const byte LF_ACL = (byte)65;
    public const byte LF_BLK = (byte)52;
    public const byte LF_CHR = (byte)51;
    public const byte LF_CONTIG = (byte)55;
    public const byte LF_DIR = (byte)53;
    public const byte LF_EXTATTR = (byte)69;
    public const byte LF_FIFO = (byte)54;
    public const byte LF_GHDR = (byte)103;
    public const byte LF_GNU_DUMPDIR = (byte)68;
    public const byte LF_GNU_LONGLINK = (byte)75;
    public const byte LF_GNU_LONGNAME = (byte)76;
    public const byte LF_GNU_MULTIVOL = (byte)77;
    public const byte LF_GNU_NAMES = (byte)78;
    public const byte LF_GNU_SPARSE = (byte)83;
    public const byte LF_GNU_VOLHDR = (byte)86;
    public const byte LF_LINK = (byte)49;
    public const byte LF_META = (byte)73;
    public const byte LF_NORMAL = (byte)48;
    public const byte LF_OLDNORM = (byte)0;
    public const byte LF_SYMLINK = (byte)50;
    public static readonly byte LF_XHDR;
    public static readonly int MAGICLEN;
    public static readonly int MODELEN;
    public static readonly int MODTIMELEN;
    public static readonly int NAMELEN;
    public static readonly int SIZELEN;
    public static readonly string TMAGIC;
    public static readonly int UIDLEN;
    public static readonly int UNAMELEN;
    public static readonly int VERSIONLEN;
    public TarHeader() { }
    public int Checksum { get { return default(int); } }
    public int DevMajor { get { return default(int); } set { } }
    public int DevMinor { get { return default(int); } set { } }
    public int GroupId { get { return default(int); } set { } }
    public string GroupName { get { return default(string); } set { } }
    public bool IsChecksumValid { get { return default(bool); } }
    public string LinkName { get { return default(string); } set { } }
    public string Magic { get { return default(string); } set { } }
    public int Mode { get { return default(int); } set { } }
    public System.DateTime ModTime { get { return default(System.DateTime); } set { } }
    public string Name { get { return default(string); } set { } }
    public long Size { get { return default(long); } set { } }
    public byte TypeFlag { get { return default(byte); } set { } }
    public int UserId { get { return default(int); } set { } }
    public string UserName { get { return default(string); } set { } }
    public string Version { get { return default(string); } set { } }
    public object Clone() { return default(object); }
    public override bool Equals(object obj) { return default(bool); }
    public static int GetAsciiBytes(string toAdd, int nameOffset, System.Byte[] buffer, int bufferOffset, int length) { return default(int); }
    public override int GetHashCode() { return default(int); }
    public static int GetLongOctalBytes(long val, System.Byte[] buf, int offset, int length) { return default(int); }
    [System.ObsoleteAttribute]
    public string GetName() { return default(string); }
    public static int GetNameBytes(string name, System.Byte[] buf, int offset, int length) { return default(int); }
    public static int GetNameBytes(string name, int nameOffset, System.Byte[] buf, int bufferOffset, int length) { return default(int); }
    public static int GetNameBytes(System.Text.StringBuilder name, System.Byte[] buf, int offset, int length) { return default(int); }
    public static int GetNameBytes(System.Text.StringBuilder name, int nameOffset, System.Byte[] buf, int bufferOffset, int length) { return default(int); }
    public static int GetOctalBytes(long val, System.Byte[] buf, int offset, int length) { return default(int); }
    public void ParseBuffer(System.Byte[] header) { }
    public static System.Text.StringBuilder ParseName(System.Byte[] header, int offset, int length) { return default(System.Text.StringBuilder); }
    public static long ParseOctal(System.Byte[] header, int offset, int length) { return default(long); }
    public static void ResetValueDefaults() { }
    public static void SetValueDefaults(int userId, string userName, int groupId, string groupName) { }
    public void WriteHeader(System.Byte[] outbuf) { }
  }
  public partial class TarInputStream : System.IO.Stream {
    protected ICSharpCode.SharpZipLib.Tar.TarBuffer buffer;
    protected ICSharpCode.SharpZipLib.Tar.TarEntry currEntry;
    protected ICSharpCode.SharpZipLib.Tar.TarInputStream.IEntryFactory eFactory;
    protected long entryOffset;
    protected long entrySize;
    protected bool hasHitEOF;
    protected System.Byte[] readBuf;
    public TarInputStream(System.IO.Stream inputStream) { }
    public TarInputStream(System.IO.Stream inputStream, int blockFactor) { }
    public long Available { get { return default(long); } }
    public override bool CanRead { get { return default(bool); } }
    public override bool CanSeek { get { return default(bool); } }
    public override bool CanWrite { get { return default(bool); } }
    public bool IsMarkSupported { get { return default(bool); } }
    public override long Length { get { return default(long); } }
    public override long Position { get { return default(long); } set { } }
    public override void Close() { }
    public void CopyEntryContents(System.IO.Stream outputStream) { }
    public override void Flush() { }
    public ICSharpCode.SharpZipLib.Tar.TarEntry GetNextEntry() { return default(ICSharpCode.SharpZipLib.Tar.TarEntry); }
    public int GetRecordSize() { return default(int); }
    public void Mark(int markLimit) { }
    public override int Read(System.Byte[] outputBuffer, int offset, int count) { return default(int); }
    public override int ReadByte() { return default(int); }
    public void Reset() { }
    public override long Seek(long offset, System.IO.SeekOrigin origin) { return default(long); }
    public void SetEntryFactory(ICSharpCode.SharpZipLib.Tar.TarInputStream.IEntryFactory factory) { }
    public override void SetLength(long val) { }
    public void Skip(long numToSkip) { }
    public override void Write(System.Byte[] array, int offset, int count) { }
    public override void WriteByte(byte val) { }
    public partial class EntryFactoryAdapter : ICSharpCode.SharpZipLib.Tar.TarInputStream.IEntryFactory {
      public EntryFactoryAdapter() { }
      public ICSharpCode.SharpZipLib.Tar.TarEntry CreateEntry(System.Byte[] headerBuf) { return default(ICSharpCode.SharpZipLib.Tar.TarEntry); }
      public ICSharpCode.SharpZipLib.Tar.TarEntry CreateEntry(string name) { return default(ICSharpCode.SharpZipLib.Tar.TarEntry); }
      public ICSharpCode.SharpZipLib.Tar.TarEntry CreateEntryFromFile(string fileName) { return default(ICSharpCode.SharpZipLib.Tar.TarEntry); }
    }
    public partial interface IEntryFactory {
      ICSharpCode.SharpZipLib.Tar.TarEntry CreateEntry(System.Byte[] headerBuf);
      ICSharpCode.SharpZipLib.Tar.TarEntry CreateEntry(string name);
      ICSharpCode.SharpZipLib.Tar.TarEntry CreateEntryFromFile(string fileName);
    }
  }
  public partial class TarOutputStream : System.IO.Stream {
    protected System.Byte[] assemBuf;
    protected int assemLen;
    protected System.Byte[] blockBuf;
    protected ICSharpCode.SharpZipLib.Tar.TarBuffer buffer;
    protected long currBytes;
    protected long currSize;
    protected bool debug;
    protected System.IO.Stream outputStream;
    public TarOutputStream(System.IO.Stream outputStream) { }
    public TarOutputStream(System.IO.Stream outputStream, int blockFactor) { }
    public override bool CanRead { get { return default(bool); } }
    public override bool CanSeek { get { return default(bool); } }
    public override bool CanWrite { get { return default(bool); } }
    public override long Length { get { return default(long); } }
    public override long Position { get { return default(long); } set { } }
    public override void Close() { }
    public void CloseEntry() { }
    public void Finish() { }
    public override void Flush() { }
    public int GetRecordSize() { return default(int); }
    public void PutNextEntry(ICSharpCode.SharpZipLib.Tar.TarEntry entry) { }
    public override int Read(System.Byte[] b, int off, int len) { return default(int); }
    public override int ReadByte() { return default(int); }
    public override long Seek(long offset, System.IO.SeekOrigin origin) { return default(long); }
    public override void SetLength(long val) { }
    public override void Write(System.Byte[] wBuf, int wOffset, int numToWrite) { }
    public override void WriteByte(byte b) { }
  }
}
namespace ICSharpCode.SharpZipLib.Zip {
  public enum CompressionMethod {
    BZip2 = 11,
    Deflate64 = 9,
    Deflated = 8,
    Stored = 0,
    WinZipAES = 99,
  }
  public partial class FastZip {
    public FastZip() { }
    public FastZip(ICSharpCode.SharpZipLib.Zip.FastZipEvents events) { }
    public bool CreateEmptyDirectories { get { return default(bool); } set { } }
    public ICSharpCode.SharpZipLib.Zip.ZipNameTransform NameTransform { get { return default(ICSharpCode.SharpZipLib.Zip.ZipNameTransform); } set { } }
    public void CreateZip(string zipFileName, string sourceDirectory, bool recurse, string fileFilter) { }
    public void CreateZip(string zipFileName, string sourceDirectory, bool recurse, string fileFilter, string directoryFilter) { }
    public void ExtractZip(string zipFileName, string targetDirectory, ICSharpCode.SharpZipLib.Zip.FastZip.Overwrite overwrite, ICSharpCode.SharpZipLib.Zip.FastZip.ConfirmOverwriteDelegate confirmDelegate, string fileFilter, string directoryFilter) { }
    public void ExtractZip(string zipFileName, string targetDirectory, string fileFilter) { }
    public delegate bool ConfirmOverwriteDelegate(string fileName);
    public enum Overwrite {
      Always = 2,
      Never = 1,
      Prompt = 0,
    }
  }
  public partial class FastZipEvents {
    public ICSharpCode.SharpZipLib.Core.DirectoryFailureDelegate DirectoryFailure;
    public ICSharpCode.SharpZipLib.Core.FileFailureDelegate FileFailure;
    public ICSharpCode.SharpZipLib.Core.ProcessDirectoryDelegate ProcessDirectory;
    public ICSharpCode.SharpZipLib.Core.ProcessFileDelegate ProcessFile;
    public FastZipEvents() { }
    public void OnDirectoryFailure(string directory, System.Exception e) { }
    public void OnFileFailure(string file, System.Exception e) { }
    public void OnProcessDirectory(string directory, bool hasMatchingFiles) { }
    public void OnProcessFile(string file) { }
  }
  public partial class KeysRequiredEventArgs : System.EventArgs {
    public KeysRequiredEventArgs(string name) { }
    public KeysRequiredEventArgs(string name, System.Byte[] keyValue) { }
    public string FileName { get { return default(string); } }
    public System.Byte[] Key { get { return default(System.Byte[]); } set { } }
  }
  public sealed partial class ZipConstants {
    public const int CENATT = 36;
    public const int CENATX = 38;
    public const int CENCOM = 32;
    public const int CENCRC = 16;
    public const int CENDIGITALSIG = 84233040;
    public const int CENDSK = 34;
    public const int CENEXT = 30;
    public const int CENFLG = 8;
    public const int CENHDR = 46;
    public const int CENHOW = 10;
    public const int CENLEN = 24;
    public const int CENNAM = 28;
    public const int CENOFF = 42;
    public const int CENSIG = 33639248;
    public const int CENSIG64 = 101075792;
    public const int CENSIZ = 20;
    public const int CENTIM = 12;
    public const int CENVEM = 4;
    public const int CENVER = 6;
    public const int CRYPTO_HEADER_SIZE = 12;
    public const int ENDCOM = 20;
    public const int ENDDCD = 6;
    public const int ENDHDR = 22;
    public const int ENDNRD = 4;
    public const int ENDOFF = 16;
    public const int ENDSIG = 101010256;
    public const int ENDSIZ = 12;
    public const int ENDSUB = 8;
    public const int ENDTOT = 10;
    public const int EXTCRC = 4;
    public const int EXTHDR = 16;
    public const int EXTLEN = 12;
    public const int EXTSIG = 134695760;
    public const int EXTSIZ = 8;
    public const int LOCCRC = 14;
    public const int LOCEXT = 28;
    public const int LOCFLG = 6;
    public const int LOCHDR = 30;
    public const int LOCHOW = 8;
    public const int LOCLEN = 22;
    public const int LOCNAM = 26;
    public const int LOCSIG = 67324752;
    public const int LOCSIZ = 18;
    public const int LOCTIM = 10;
    public const int LOCVER = 4;
    public const int SPANNINGSIG = 134695760;
    public const int SPANTEMPSIG = 808471376;
    public const int VERSION_MADE_BY = 20;
    public const int VERSION_STRONG_ENCRYPTION = 50;
    public ZipConstants() { }
    public static int DefaultCodePage { get { return default(int); } set { } }
    public static System.Byte[] ConvertToArray(string str) { return default(System.Byte[]); }
    public static string ConvertToString(System.Byte[] data) { return default(string); }
    public static string ConvertToString(System.Byte[] data, int length) { return default(string); }
  }
  public partial class ZipEntry : System.ICloneable {
    public ZipEntry(ICSharpCode.SharpZipLib.Zip.ZipEntry e) { }
    public ZipEntry(string name) { }
    public string Comment { get { return default(string); } set { } }
    public long CompressedSize { get { return default(long); } set { } }
    public ICSharpCode.SharpZipLib.Zip.CompressionMethod CompressionMethod { get { return default(ICSharpCode.SharpZipLib.Zip.CompressionMethod); } set { } }
    public long Crc { get { return default(long); } set { } }
    public System.DateTime DateTime { get { return default(System.DateTime); } set { } }
    public long DosTime { get { return default(long); } set { } }
    public int ExternalFileAttributes { get { return default(int); } set { } }
    public System.Byte[] ExtraData { get { return default(System.Byte[]); } set { } }
    public int Flags { get { return default(int); } set { } }
    public int HostSystem { get { return default(int); } }
    public bool IsCrypted { get { return default(bool); } set { } }
    public bool IsDirectory { get { return default(bool); } }
    public bool IsFile { get { return default(bool); } }
    public string Name { get { return default(string); } }
    public int Offset { get { return default(int); } set { } }
    public bool RequiresZip64 { get { return default(bool); } }
    public long Size { get { return default(long); } set { } }
    public int Version { get { return default(int); } }
    public int VersionMadeBy { get { return default(int); } }
    public int ZipFileIndex { get { return default(int); } set { } }
    public static string CleanName(string name) { return default(string); }
    public static string CleanName(string name, bool relativePath) { return default(string); }
    public object Clone() { return default(object); }
    public override string ToString() { return default(string); }
  }
  public partial class ZipException : ICSharpCode.SharpZipLib.SharpZipBaseException {
    public ZipException() { }
    public ZipException(string msg) { }
  }
  public partial class ZipFile : System.Collections.IEnumerable {
    public ICSharpCode.SharpZipLib.Zip.ZipFile.KeysRequiredEventHandler KeysRequired;
    public ZipFile(System.IO.FileStream file) { }
    public ZipFile(System.IO.Stream baseStream) { }
    public ZipFile(string name) { }
    [System.Runtime.CompilerServices.IndexerName("EntryByIndex")]
    public ICSharpCode.SharpZipLib.Zip.ZipEntry this[int index] { get { return default(ICSharpCode.SharpZipLib.Zip.ZipEntry); } }
    public string Name { get { return default(string); } }
    public string Password { set { } }
    public int Size { get { return default(int); } }
    public string ZipFileComment { get { return default(string); } }
    public void Close() { }
    public int FindEntry(string name, bool ignoreCase) { return default(int); }
    public ICSharpCode.SharpZipLib.Zip.ZipEntry GetEntry(string name) { return default(ICSharpCode.SharpZipLib.Zip.ZipEntry); }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public System.IO.Stream GetInputStream(ICSharpCode.SharpZipLib.Zip.ZipEntry entry) { return default(System.IO.Stream); }
    public System.IO.Stream GetInputStream(int entryIndex) { return default(System.IO.Stream); }
    public bool TestArchive(bool testData) { return default(bool); }
    public delegate void KeysRequiredEventHandler(object sender, ICSharpCode.SharpZipLib.Zip.KeysRequiredEventArgs e);
  }
  public partial class ZipInputStream : ICSharpCode.SharpZipLib.Zip.Compression.Streams.InflaterInputStream {
    public ZipInputStream(System.IO.Stream baseInputStream) : base (default(System.IO.Stream)) { }
    public override int Available { get { return default(int); } }
    public bool CanDecompressEntry { get { return default(bool); } }
    public string Password { get { return default(string); } set { } }
    public int BodyRead(System.Byte[] b, int off, int len) { return default(int); }
    public override void Close() { }
    public void CloseEntry() { }
    public ICSharpCode.SharpZipLib.Zip.ZipEntry GetNextEntry() { return default(ICSharpCode.SharpZipLib.Zip.ZipEntry); }
    public override int Read(System.Byte[] destination, int index, int count) { return default(int); }
    public override int ReadByte() { return default(int); }
  }
  public partial class ZipNameTransform : ICSharpCode.SharpZipLib.Core.INameTransform {
    public ZipNameTransform() { }
    public ZipNameTransform(bool useRelativePaths) { }
    public ZipNameTransform(bool useRelativePaths, string trimPrefix) { }
    public string TrimPrefix { get { return default(string); } set { } }
    public string TransformDirectory(string name) { return default(string); }
    public string TransformFile(string name) { return default(string); }
  }
  public partial class ZipOutputStream : ICSharpCode.SharpZipLib.Zip.Compression.Streams.DeflaterOutputStream {
    public ZipOutputStream(System.IO.Stream baseOutputStream) : base (default(System.IO.Stream)) { }
    public bool IsFinished { get { return default(bool); } }
    public void CloseEntry() { }
    public override void Finish() { }
    public int GetLevel() { return default(int); }
    public void PutNextEntry(ICSharpCode.SharpZipLib.Zip.ZipEntry entry) { }
    public void SetComment(string comment) { }
    public void SetLevel(int level) { }
    public override void Write(System.Byte[] b, int off, int len) { }
  }
}
namespace ICSharpCode.SharpZipLib.Zip.Compression {
  public partial class Deflater {
    public static int BEST_COMPRESSION;
    public static int BEST_SPEED;
    public static int DEFAULT_COMPRESSION;
    public static int DEFLATED;
    public static int NO_COMPRESSION;
    public Deflater() { }
    public Deflater(int lvl) { }
    public Deflater(int level, bool noZlibHeaderOrFooter) { }
    public int Adler { get { return default(int); } }
    public bool IsFinished { get { return default(bool); } }
    public bool IsNeedingInput { get { return default(bool); } }
    public int TotalIn { get { return default(int); } }
    public long TotalOut { get { return default(long); } }
    public int Deflate(System.Byte[] output) { return default(int); }
    public int Deflate(System.Byte[] output, int offset, int length) { return default(int); }
    public void Finish() { }
    public void Flush() { }
    public int GetLevel() { return default(int); }
    public void Reset() { }
    public void SetDictionary(System.Byte[] dict) { }
    public void SetDictionary(System.Byte[] dict, int offset, int length) { }
    public void SetInput(System.Byte[] input) { }
    public void SetInput(System.Byte[] input, int off, int len) { }
    public void SetLevel(int lvl) { }
    public void SetStrategy(ICSharpCode.SharpZipLib.Zip.Compression.DeflateStrategy strategy) { }
  }
  public partial class DeflaterConstants {
    public static System.Int32[] COMPR_FUNC;
    public const bool DEBUGGING = false;
    public const int DEFAULT_MEM_LEVEL = 8;
    public const int DEFLATE_FAST = 1;
    public const int DEFLATE_SLOW = 2;
    public const int DEFLATE_STORED = 0;
    public const int DYN_TREES = 2;
    public static System.Int32[] GOOD_LENGTH;
    public const int HASH_BITS = 15;
    public const int HASH_MASK = 32767;
    public const int HASH_SHIFT = 5;
    public const int HASH_SIZE = 32768;
    public static int MAX_BLOCK_SIZE;
    public static System.Int32[] MAX_CHAIN;
    public const int MAX_DIST = 32506;
    public static System.Int32[] MAX_LAZY;
    public const int MAX_MATCH = 258;
    public const int MAX_WBITS = 15;
    public const int MIN_LOOKAHEAD = 262;
    public const int MIN_MATCH = 3;
    public static System.Int32[] NICE_LENGTH;
    public const int PENDING_BUF_SIZE = 65536;
    public const int PRESET_DICT = 32;
    public const int STATIC_TREES = 1;
    public const int STORED_BLOCK = 0;
    public const int WMASK = 32767;
    public const int WSIZE = 32768;
    public DeflaterConstants() { }
  }
  public partial class DeflaterEngine : ICSharpCode.SharpZipLib.Zip.Compression.DeflaterConstants {
    public DeflaterEngine(ICSharpCode.SharpZipLib.Zip.Compression.DeflaterPending pending) { }
    public int Adler { get { return default(int); } }
    public ICSharpCode.SharpZipLib.Zip.Compression.DeflateStrategy Strategy { get { return default(ICSharpCode.SharpZipLib.Zip.Compression.DeflateStrategy); } set { } }
    public int TotalIn { get { return default(int); } }
    public bool Deflate(bool flush, bool finish) { return default(bool); }
    public void FillWindow() { }
    public bool NeedsInput() { return default(bool); }
    public void Reset() { }
    public void ResetAdler() { }
    public void SetDictionary(System.Byte[] buffer, int offset, int length) { }
    public void SetInput(System.Byte[] buf, int off, int len) { }
    public void SetLevel(int lvl) { }
  }
  public partial class DeflaterHuffman {
    public ICSharpCode.SharpZipLib.Zip.Compression.DeflaterPending pending;
    public DeflaterHuffman(ICSharpCode.SharpZipLib.Zip.Compression.DeflaterPending pending) { }
    public static short BitReverse(int toReverse) { return default(short); }
    public void CompressBlock() { }
    public void FlushBlock(System.Byte[] stored, int storedOffset, int storedLength, bool lastBlock) { }
    public void FlushStoredBlock(System.Byte[] stored, int storedOffset, int storedLength, bool lastBlock) { }
    public bool IsFull() { return default(bool); }
    public void Reset() { }
    public void SendAllTrees(int blTreeCodes) { }
    public bool TallyDist(int dist, int len) { return default(bool); }
    public bool TallyLit(int lit) { return default(bool); }
    public partial class Tree {
      public System.Int16[] freqs;
      public System.Byte[] length;
      public int minNumCodes;
      public int numCodes;
      public Tree(ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman dh, int elems, int minCodes, int maxLength) { }
      public void BuildCodes() { }
      public void BuildTree() { }
      public void CalcBLFreq(ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.Tree blTree) { }
      public void CheckEmpty() { }
      public int GetEncodedLength() { return default(int); }
      public void Reset() { }
      public void SetStaticCodes(System.Int16[] stCodes, System.Byte[] stLength) { }
      public void WriteSymbol(int code) { }
      public void WriteTree(ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.Tree blTree) { }
    }
  }
  public partial class DeflaterPending : ICSharpCode.SharpZipLib.Zip.Compression.PendingBuffer {
    public DeflaterPending() { }
  }
  public enum DeflateStrategy {
    Default = 0,
    Filtered = 1,
    HuffmanOnly = 2,
  }
  public partial class Inflater {
    public Inflater() { }
    public Inflater(bool noHeader) { }
    public int Adler { get { return default(int); } }
    public bool IsFinished { get { return default(bool); } }
    public bool IsNeedingDictionary { get { return default(bool); } }
    public bool IsNeedingInput { get { return default(bool); } }
    public int RemainingInput { get { return default(int); } }
    public int TotalIn { get { return default(int); } }
    public int TotalOut { get { return default(int); } }
    public int Inflate(System.Byte[] buf) { return default(int); }
    public int Inflate(System.Byte[] buf, int offset, int len) { return default(int); }
    public void Reset() { }
    public void SetDictionary(System.Byte[] buffer) { }
    public void SetDictionary(System.Byte[] buffer, int offset, int len) { }
    public void SetInput(System.Byte[] buf) { }
    public void SetInput(System.Byte[] buffer, int offset, int length) { }
  }
  public partial class InflaterHuffmanTree {
    public static ICSharpCode.SharpZipLib.Zip.Compression.InflaterHuffmanTree defDistTree;
    public static ICSharpCode.SharpZipLib.Zip.Compression.InflaterHuffmanTree defLitLenTree;
    public InflaterHuffmanTree(System.Byte[] codeLengths) { }
    public int GetSymbol(ICSharpCode.SharpZipLib.Zip.Compression.Streams.StreamManipulator input) { return default(int); }
  }
  public partial class PendingBuffer {
    protected System.Byte[] buf;
    public PendingBuffer() { }
    public PendingBuffer(int bufsize) { }
    public int BitCount { get { return default(int); } }
    public bool IsFlushed { get { return default(bool); } }
    public void AlignToByte() { }
    public int Flush(System.Byte[] output, int offset, int length) { return default(int); }
    public void Reset() { }
    public System.Byte[] ToByteArray() { return default(System.Byte[]); }
    public void WriteBits(int b, int count) { }
    public void WriteBlock(System.Byte[] block, int offset, int len) { }
    public void WriteByte(int b) { }
    public void WriteInt(int s) { }
    public void WriteShort(int s) { }
    public void WriteShortMSB(int s) { }
  }
}
namespace ICSharpCode.SharpZipLib.Zip.Compression.Streams {
  public partial class DeflaterOutputStream : System.IO.Stream {
    protected System.IO.Stream baseOutputStream;
    protected System.Byte[] buf;
    protected ICSharpCode.SharpZipLib.Zip.Compression.Deflater def;
    public DeflaterOutputStream(System.IO.Stream baseOutputStream) { }
    public DeflaterOutputStream(System.IO.Stream baseOutputStream, ICSharpCode.SharpZipLib.Zip.Compression.Deflater defl) { }
    public DeflaterOutputStream(System.IO.Stream baseOutputStream, ICSharpCode.SharpZipLib.Zip.Compression.Deflater deflater, int bufsize) { }
    public bool CanPatchEntries { get { return default(bool); } }
    public override bool CanRead { get { return default(bool); } }
    public override bool CanSeek { get { return default(bool); } }
    public override bool CanWrite { get { return default(bool); } }
    public bool IsStreamOwner { get { return default(bool); } set { } }
    public override long Length { get { return default(long); } }
    public string Password { get { return default(string); } set { } }
    public override long Position { get { return default(long); } set { } }
    public override System.IAsyncResult BeginRead(System.Byte[] buffer, int offset, int count, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public override System.IAsyncResult BeginWrite(System.Byte[] buffer, int offset, int count, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public override void Close() { }
    protected void Deflate() { }
    protected void EncryptBlock(System.Byte[] buffer, int offset, int length) { }
    protected byte EncryptByte() { return default(byte); }
    public virtual void Finish() { }
    public override void Flush() { }
    protected void InitializePassword(string password) { }
    public override int Read(System.Byte[] b, int off, int len) { return default(int); }
    public override int ReadByte() { return default(int); }
    public override long Seek(long offset, System.IO.SeekOrigin origin) { return default(long); }
    public override void SetLength(long val) { }
    protected void UpdateKeys(byte ch) { }
    public override void Write(System.Byte[] buf, int off, int len) { }
    public override void WriteByte(byte bval) { }
  }
  public partial class InflaterInputBuffer {
    public InflaterInputBuffer(System.IO.Stream stream) { }
    public int Available { get { return default(int); } set { } }
    public System.Byte[] ClearText { get { return default(System.Byte[]); } }
    public int ClearTextLength { get { return default(int); } }
    public System.Security.Cryptography.ICryptoTransform CryptoTransform { set { } }
    public System.Byte[] RawData { get { return default(System.Byte[]); } }
    public int RawLength { get { return default(int); } }
    public void Fill() { }
    public int ReadClearTextBuffer(System.Byte[] outBuffer, int offset, int length) { return default(int); }
    public int ReadLeByte() { return default(int); }
    public int ReadLeInt() { return default(int); }
    public long ReadLeLong() { return default(long); }
    public int ReadLeShort() { return default(int); }
    public int ReadRawBuffer(System.Byte[] buffer) { return default(int); }
    public int ReadRawBuffer(System.Byte[] outBuffer, int offset, int length) { return default(int); }
    public void SetInflaterInput(ICSharpCode.SharpZipLib.Zip.Compression.Inflater inflater) { }
  }
  public partial class InflaterInputStream : System.IO.Stream {
    protected System.IO.Stream baseInputStream;
    protected long csize;
    protected ICSharpCode.SharpZipLib.Zip.Compression.Inflater inf;
    protected ICSharpCode.SharpZipLib.Zip.Compression.Streams.InflaterInputBuffer inputBuffer;
    public InflaterInputStream(System.IO.Stream baseInputStream) { }
    public InflaterInputStream(System.IO.Stream baseInputStream, ICSharpCode.SharpZipLib.Zip.Compression.Inflater inf) { }
    public InflaterInputStream(System.IO.Stream baseInputStream, ICSharpCode.SharpZipLib.Zip.Compression.Inflater inflater, int bufferSize) { }
    public virtual int Available { get { return default(int); } }
    public override bool CanRead { get { return default(bool); } }
    public override bool CanSeek { get { return default(bool); } }
    public override bool CanWrite { get { return default(bool); } }
    public bool IsStreamOwner { get { return default(bool); } set { } }
    public override long Length { get { return default(long); } }
    public override long Position { get { return default(long); } set { } }
    public override System.IAsyncResult BeginWrite(System.Byte[] buffer, int offset, int count, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public override void Close() { }
    protected void Fill() { }
    public override void Flush() { }
    public override int Read(System.Byte[] b, int off, int len) { return default(int); }
    public override long Seek(long offset, System.IO.SeekOrigin origin) { return default(long); }
    public override void SetLength(long val) { }
    public long Skip(long n) { return default(long); }
    protected void StopDecrypting() { }
    public override void Write(System.Byte[] array, int offset, int count) { }
    public override void WriteByte(byte val) { }
  }
  public partial class OutputWindow {
    public OutputWindow() { }
    public void CopyDict(System.Byte[] dict, int offset, int len) { }
    public int CopyOutput(System.Byte[] output, int offset, int len) { return default(int); }
    public int CopyStored(ICSharpCode.SharpZipLib.Zip.Compression.Streams.StreamManipulator input, int len) { return default(int); }
    public int GetAvailable() { return default(int); }
    public int GetFreeSpace() { return default(int); }
    public void Repeat(int len, int dist) { }
    public void Reset() { }
    public void Write(int abyte) { }
  }
  public partial class StreamManipulator {
    public StreamManipulator() { }
    public int AvailableBits { get { return default(int); } }
    public int AvailableBytes { get { return default(int); } }
    public bool IsNeedingInput { get { return default(bool); } }
    public int CopyBytes(System.Byte[] output, int offset, int length) { return default(int); }
    public void DropBits(int n) { }
    public int GetBits(int n) { return default(int); }
    public int PeekBits(int n) { return default(int); }
    public void Reset() { }
    public void SetInput(System.Byte[] buf, int off, int len) { }
    public void SkipToByteBoundary() { }
  }
}
