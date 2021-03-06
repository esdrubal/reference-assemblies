namespace System.IO.Compression {
  public partial class ZipArchive : System.IDisposable {
    public ZipArchive(System.IO.Stream stream) { }
    public ZipArchive(System.IO.Stream stream, System.IO.Compression.ZipArchiveMode mode) { }
    public ZipArchive(System.IO.Stream stream, System.IO.Compression.ZipArchiveMode mode, bool leaveOpen) { }
    public ZipArchive(System.IO.Stream stream, System.IO.Compression.ZipArchiveMode mode, bool leaveOpen, System.Text.Encoding entryNameEncoding) { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.IO.Compression.ZipArchiveEntry> Entries { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.IO.Compression.ZipArchiveEntry>); } }
    public System.IO.Compression.ZipArchiveMode Mode { get { return default(System.IO.Compression.ZipArchiveMode); } }
    public System.IO.Compression.ZipArchiveEntry CreateEntry(string entryName) { return default(System.IO.Compression.ZipArchiveEntry); }
    public System.IO.Compression.ZipArchiveEntry CreateEntry(string entryName, System.IO.Compression.CompressionLevel compressionLevel) { return default(System.IO.Compression.ZipArchiveEntry); }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public System.IO.Compression.ZipArchiveEntry GetEntry(string entryName) { return default(System.IO.Compression.ZipArchiveEntry); }
  }
  public partial class ZipArchiveEntry {
    internal ZipArchiveEntry() { }
    public System.IO.Compression.ZipArchive Archive { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.IO.Compression.ZipArchive); } }
    public long CompressedLength { get { return default(long); } }
    public string FullName { get { return default(string); } }
    public System.DateTimeOffset LastWriteTime { get { return default(System.DateTimeOffset); } set { } }
    public long Length { get { return default(long); } }
    public string Name { get { return default(string); } }
    public void Delete() { }
    public System.IO.Stream Open() { return default(System.IO.Stream); }
  }
  public enum ZipArchiveMode {
    Create = 1,
    Read = 0,
    Update = 2,
  }
}
