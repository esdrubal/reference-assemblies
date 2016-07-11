namespace Mono.Posix {
  [System.CLSCompliantAttribute(false)]
  [System.FlagsAttribute]
  [System.ObsoleteAttribute("Use Mono.Unix.Native.AccessModes")]
  public enum AccessMode {
    F_OK = 8,
    R_OK = 1,
    W_OK = 2,
    X_OK = 4,
  }
  [System.ObsoleteAttribute("Use Mono.Unix.Catalog")]
  public partial class Catalog {
    public Catalog() { }
    public static string GetPluralString(string s, string p, int n) { return default(string); }
    public static string GetString(string s) { return default(string); }
    public static void Init(string package, string localedir) { }
  }
  [System.CLSCompliantAttribute(false)]
  [System.FlagsAttribute]
  [System.ObsoleteAttribute("Use Mono.Unix.Native.FilePermissions")]
  public enum FileMode {
    S_IRGRP = 32,
    S_IROTH = 4,
    S_IRUSR = 256,
    S_ISGID = 1024,
    S_ISUID = 2048,
    S_ISVTX = 512,
    S_IWGRP = 16,
    S_IWOTH = 2,
    S_IWUSR = 128,
    S_IXGRP = 8,
    S_IXOTH = 1,
    S_IXUSR = 64,
  }
  [System.CLSCompliantAttribute(false)]
  [System.FlagsAttribute]
  [System.ObsoleteAttribute("Use Mono.Unix.Native.OpenFlags")]
  public enum OpenFlags {
    O_APPEND = 64,
    O_CREAT = 4,
    O_EXCL = 8,
    O_NOCTTY = 16,
    O_NONBLOCK = 128,
    O_RDONLY = 0,
    O_RDWR = 2,
    O_SYNC = 256,
    O_TRUNC = 32,
    O_WRONLY = 1,
  }
  [System.ObsoleteAttribute("Use Mono.Unix.PeerCred")]
  public partial class PeerCred {
    public PeerCred(System.Net.Sockets.Socket sock) { }
    public int GroupID { get { return default(int); } }
    public int ProcessID { get { return default(int); } }
    public int UserID { get { return default(int); } }
  }
  [System.CLSCompliantAttribute(false)]
  [System.ObsoleteAttribute("Use Mono.Unix.Native.Signum")]
  public enum Signals {
    SIGABRT = 5,
    SIGALRM = 13,
    SIGBUS = 6,
    SIGCHLD = 15,
    SIGCONT = 16,
    SIGFPE = 7,
    SIGHUP = 0,
    SIGILL = 3,
    SIGINT = 1,
    SIGIO = 27,
    SIGKILL = 8,
    SIGPIPE = 12,
    SIGPROF = 25,
    SIGQUIT = 2,
    SIGSEGV = 10,
    SIGSTOP = 17,
    SIGSYS = 28,
    SIGTERM = 14,
    SIGTRAP = 4,
    SIGTSTP = 18,
    SIGTTIN = 19,
    SIGTTOU = 20,
    SIGURG = 21,
    SIGUSR1 = 9,
    SIGUSR2 = 11,
    SIGVTALRM = 24,
    SIGWINCH = 26,
    SIGXCPU = 22,
    SIGXFSZ = 23,
  }
  [System.ObsoleteAttribute("Use Mono.Unix.Native.Stat")]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Stat {
    [System.ObsoleteAttribute("Use Mono.Unix.Native.Stat.st_atime")]
    public readonly System.DateTime ATime;
    [System.ObsoleteAttribute("Use Mono.Unix.Native.Stat.st_blocks")]
    public readonly long Blocks;
    [System.ObsoleteAttribute("Use Mono.Unix.Native.Stat.st_blksize")]
    public readonly long BlockSize;
    [System.ObsoleteAttribute("Use Mono.Unix.Native.Stat.st_ctime")]
    public readonly System.DateTime CTime;
    [System.ObsoleteAttribute("Use Mono.Unix.Native.Stat.st_dev")]
    public readonly int Device;
    [System.ObsoleteAttribute("Use Mono.Unix.Native.Stat.st_rdev")]
    public readonly long DeviceType;
    [System.ObsoleteAttribute("Use Mono.Unix.Native.Stat.st_gid")]
    public readonly int Gid;
    [System.ObsoleteAttribute("Use Mono.Unix.Native.Stat.st_ino")]
    public readonly int INode;
    [System.ObsoleteAttribute("Use Mono.Unix.Native.Stat.st_mode")]
    public readonly Mono.Posix.StatMode Mode;
    [System.ObsoleteAttribute("Use Mono.Unix.Native.Stat.st_mtime")]
    public readonly System.DateTime MTime;
    [System.ObsoleteAttribute("Use Mono.Unix.Native.Stat.st_nlink")]
    public readonly int NLinks;
    [System.ObsoleteAttribute("Use Mono.Unix.Native.Stat.st_size")]
    public readonly long Size;
    [System.ObsoleteAttribute("Use Mono.Unix.Native.Stat.st_uid")]
    public readonly int Uid;
    [System.ObsoleteAttribute("Use Mono.Unix.Native.NativeConvert.LocalUnixEpoch")]
    public static readonly System.DateTime UnixEpoch;
    [System.ObsoleteAttribute("Use Mono.Unix.Native.NativeConvert.ToDateTime")]
    public static System.DateTime UnixToDateTime(long unix) { return default(System.DateTime); }
  }
  [System.FlagsAttribute]
  [System.ObsoleteAttribute("Use Mono.Unix.Native.FilePermissions")]
  public enum StatMode {
    [System.ObsoleteAttribute("Use Mono.Unix.Native.FilePermissions.S_IFBLK")]
    BlockDevice = 24576,
    [System.ObsoleteAttribute("Use Mono.Unix.Native.FilePermissions.S_IFCHR")]
    CharDevice = 8192,
    [System.ObsoleteAttribute("Use Mono.Unix.Native.FilePermissions.S_IFDIR")]
    Directory = 16384,
    [System.ObsoleteAttribute("Use Mono.Unix.Native.FilePermissions.S_IFIFO")]
    FIFO = 4096,
    [System.ObsoleteAttribute("Use Mono.Unix.Native.FilePermissions.S_IXGRP")]
    GroupExecute = 8,
    [System.ObsoleteAttribute("Use Mono.Unix.Native.FilePermissions.S_IRGRP")]
    GroupRead = 32,
    [System.ObsoleteAttribute("Use Mono.Unix.Native.FilePermissions.S_IWGRP")]
    GroupWrite = 16,
    [System.ObsoleteAttribute("Use Mono.Unix.Native.FilePermissions.S_IXOTH")]
    OthersExecute = 1,
    [System.ObsoleteAttribute("Use Mono.Unix.Native.FilePermissions.S_IROTH")]
    OthersRead = 4,
    [System.ObsoleteAttribute("Use Mono.Unix.Native.FilePermissions.S_IWOTH")]
    OthersWrite = 2,
    [System.ObsoleteAttribute("Use Mono.Unix.Native.FilePermissions.S_IXUSR")]
    OwnerExecute = 64,
    [System.ObsoleteAttribute("Use Mono.Unix.Native.FilePermissions.S_IRUSR")]
    OwnerRead = 256,
    [System.ObsoleteAttribute("Use Mono.Unix.Native.FilePermissions.S_IWUSR")]
    OwnerWrite = 128,
    [System.ObsoleteAttribute("Use Mono.Unix.Native.FilePermissions.S_IFREG")]
    Regular = 32768,
    [System.ObsoleteAttribute("Use Mono.Unix.Native.FilePermissions.S_ISGID")]
    SGid = 1024,
    [System.ObsoleteAttribute("Use Mono.Unix.Native.FilePermissions.S_IFSOCK")]
    Socket = 49152,
    [System.ObsoleteAttribute("Use Mono.Unix.Native.FilePermissions.S_ISVTX")]
    Sticky = 512,
    [System.ObsoleteAttribute("Use Mono.Unix.Native.FilePermissions.S_ISUID")]
    SUid = 2048,
    [System.ObsoleteAttribute("Use Mono.Unix.Native.FilePermissions.S_IFLNK")]
    SymLink = 40960,
  }
  [System.ObsoleteAttribute("Use Mono.Unix.Native.FilePermissions")]
  public enum StatModeMasks {
    [System.ObsoleteAttribute("Use Mono.Unix.Native.FilePermissions.S_RWXG")]
    GroupMask = 56,
    [System.ObsoleteAttribute("Use Mono.Unix.Native.FilePermissions.S_RWXO")]
    OthersMask = 7,
    [System.ObsoleteAttribute("Use Mono.Unix.Native.FilePermissions.S_RWXU")]
    OwnerMask = 448,
    [System.ObsoleteAttribute("Use Mono.Unix.Native.FilePermissions.S_IFMT")]
    TypeMask = 61440,
  }
  [System.CLSCompliantAttribute(false)]
  [System.ObsoleteAttribute("Use Mono.Unix.Native.Syscall.")]
  public partial class Syscall {
    public Syscall() { }
    public static int access(string pathname, Mono.Posix.AccessMode mode) { return default(int); }
    public static uint alarm(uint seconds) { return default(uint); }
    public static int chdir(string path) { return default(int); }
    public static int chmod(string path, Mono.Posix.FileMode mode) { return default(int); }
    public static int chown(string path, int owner, int group) { return default(int); }
    public static int chroot(string path) { return default(int); }
    public static int close(int fileDescriptor) { return default(int); }
    public static int closedir(System.IntPtr dir) { return default(int); }
    public static int creat(string pathname, Mono.Posix.FileMode flags) { return default(int); }
    public static int dup(int fileDescriptor) { return default(int); }
    public static int dup2(int oldFileDescriptor, int newFileDescriptor) { return default(int); }
    public static int exit(int status) { return default(int); }
    public static int fork() { return default(int); }
    public static int getegid() { return default(int); }
    public static int geteuid() { return default(int); }
    public static int getgid() { return default(int); }
    public static string getgroupname(int gid) { return default(string); }
    [System.CLSCompliantAttribute(false)]
    public static string gethostname() { return default(string); }
    public static string GetHostName() { return default(string); }
    public static int getpgrp() { return default(int); }
    public static int getpid() { return default(int); }
    public static int getppid() { return default(int); }
    public static int getuid() { return default(int); }
    public static string getusername(int uid) { return default(string); }
    public static bool isatty(int desc) { return default(bool); }
    public static void kill(int pid, int sig) { }
    public static int lchown(string path, int owner, int group) { return default(int); }
    public static int link(string oldPath, string newPath) { return default(int); }
    public static int lseek(int fileDescriptor, int offset, int whence) { return default(int); }
    public static int lstat(string filename, out Mono.Posix.Stat stat) { stat = default(Mono.Posix.Stat); return default(int); }
    public static int mkdir(string pathname, Mono.Posix.FileMode mode) { return default(int); }
    public static int nice(int increment) { return default(int); }
    public static int open(string pathname, Mono.Posix.OpenFlags flags) { return default(int); }
    public static int open(string pathname, Mono.Posix.OpenFlags flags, Mono.Posix.FileMode mode) { return default(int); }
    public static System.IntPtr opendir(string path) { return default(System.IntPtr); }
    public static int pause() { return default(int); }
    public unsafe static System.IntPtr read(int fileDescriptor, void* buf, System.IntPtr count) { return default(System.IntPtr); }
    public static string readdir(System.IntPtr dir) { return default(string); }
    public static string readlink(string path) { return default(string); }
    public static int rename(string oldPath, string newPath) { return default(int); }
    public static int rmdir(string path) { return default(int); }
    public static int setgid(int gid) { return default(int); }
    public static int setpgid(int pid, int pgid) { return default(int); }
    public static int setregid(int rgid, int egid) { return default(int); }
    public static int setreuid(int ruid, int euid) { return default(int); }
    public static int setsid() { return default(int); }
    public static int setuid(int uid) { return default(int); }
    public static int signal(int signum, Mono.Posix.Syscall.sighandler_t handler) { return default(int); }
    public static int stat(string filename, out Mono.Posix.Stat stat) { stat = default(Mono.Posix.Stat); return default(int); }
    public static string strerror(int errnum) { return default(string); }
    public static int symlink(string oldpath, string newpath) { return default(int); }
    public static void sync() { }
    public static int umask(int umask) { return default(int); }
    public static int unlink(string path) { return default(int); }
    public static int waitpid(int pid, Mono.Posix.WaitOptions options) { return default(int); }
    public static int waitpid(int pid, out int status, Mono.Posix.WaitOptions options) { status = default(int); return default(int); }
    public static int WEXITSTATUS(int status) { return default(int); }
    public static int WIFEXITED(int status) { return default(int); }
    public static int WIFSIGNALED(int status) { return default(int); }
    public static int WIFSTOPPED(int status) { return default(int); }
    public unsafe static System.IntPtr write(int fileDescriptor, void* buf, System.IntPtr count) { return default(System.IntPtr); }
    public static int WSTOPSIG(int status) { return default(int); }
    public static int WTERMSIG(int status) { return default(int); }
    public delegate void sighandler_t(int v);
  }
  [System.ObsoleteAttribute("Use Mono.Unix.UnixEndPoint")]
  public partial class UnixEndPoint : System.Net.EndPoint {
    public UnixEndPoint(string filename) { }
    public override System.Net.Sockets.AddressFamily AddressFamily { get { return default(System.Net.Sockets.AddressFamily); } }
    public string Filename { get { return default(string); } set { } }
    public override System.Net.EndPoint Create(System.Net.SocketAddress socketAddress) { return default(System.Net.EndPoint); }
    public override bool Equals(object o) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override System.Net.SocketAddress Serialize() { return default(System.Net.SocketAddress); }
    public override string ToString() { return default(string); }
  }
  [System.CLSCompliantAttribute(false)]
  [System.FlagsAttribute]
  [System.ObsoleteAttribute("Use Mono.Unix.Native.WaitOptions")]
  public enum WaitOptions {
    WNOHANG = 0,
    WUNTRACED = 1,
  }
}
namespace Mono.Remoting.Channels.Unix {
  public partial class UnixChannel : System.Runtime.Remoting.Channels.IChannel, System.Runtime.Remoting.Channels.IChannelReceiver, System.Runtime.Remoting.Channels.IChannelSender {
    public UnixChannel() { }
    public UnixChannel(System.Collections.IDictionary properties, System.Runtime.Remoting.Channels.IClientChannelSinkProvider clientSinkProvider, System.Runtime.Remoting.Channels.IServerChannelSinkProvider serverSinkProvider) { }
    public UnixChannel(string path) { }
    public object ChannelData { get { return default(object); } }
    public string ChannelName { get { return default(string); } }
    public int ChannelPriority { get { return default(int); } }
    public System.Runtime.Remoting.Messaging.IMessageSink CreateMessageSink(string url, object remoteChannelData, out string objectURI) { objectURI = default(string); return default(System.Runtime.Remoting.Messaging.IMessageSink); }
    public System.String[] GetUrlsForUri(string uri) { return default(System.String[]); }
    public string Parse(string url, out string objectURI) { objectURI = default(string); return default(string); }
    public void StartListening(object data) { }
    public void StopListening(object data) { }
  }
  public partial class UnixClientChannel : System.Runtime.Remoting.Channels.IChannel, System.Runtime.Remoting.Channels.IChannelSender {
    public UnixClientChannel() { }
    public UnixClientChannel(System.Collections.IDictionary properties, System.Runtime.Remoting.Channels.IClientChannelSinkProvider sinkProvider) { }
    public UnixClientChannel(string name, System.Runtime.Remoting.Channels.IClientChannelSinkProvider sinkProvider) { }
    public string ChannelName { get { return default(string); } }
    public int ChannelPriority { get { return default(int); } }
    public System.Runtime.Remoting.Messaging.IMessageSink CreateMessageSink(string url, object remoteChannelData, out string objectURI) { objectURI = default(string); return default(System.Runtime.Remoting.Messaging.IMessageSink); }
    public string Parse(string url, out string objectURI) { objectURI = default(string); return default(string); }
  }
  public partial class UnixServerChannel : System.Runtime.Remoting.Channels.IChannel, System.Runtime.Remoting.Channels.IChannelReceiver {
    public UnixServerChannel(System.Collections.IDictionary properties, System.Runtime.Remoting.Channels.IServerChannelSinkProvider serverSinkProvider) { }
    public UnixServerChannel(string path) { }
    public UnixServerChannel(string name, string path) { }
    public UnixServerChannel(string name, string path, System.Runtime.Remoting.Channels.IServerChannelSinkProvider serverSinkProvider) { }
    public object ChannelData { get { return default(object); } }
    public string ChannelName { get { return default(string); } }
    public int ChannelPriority { get { return default(int); } }
    public string GetChannelUri() { return default(string); }
    public System.String[] GetUrlsForUri(string uri) { return default(System.String[]); }
    public string Parse(string url, out string objectURI) { objectURI = default(string); return default(string); }
    public void StartListening(object data) { }
    public void StopListening(object data) { }
  }
}
namespace Mono.Unix {
  public partial class AbstractUnixEndPoint : System.Net.EndPoint {
    public AbstractUnixEndPoint(string path) { }
    public override System.Net.Sockets.AddressFamily AddressFamily { get { return default(System.Net.Sockets.AddressFamily); } }
    public string Path { get { return default(string); } set { } }
    public override System.Net.EndPoint Create(System.Net.SocketAddress socketAddress) { return default(System.Net.EndPoint); }
    public override bool Equals(object o) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override System.Net.SocketAddress Serialize() { return default(System.Net.SocketAddress); }
    public override string ToString() { return default(string); }
  }
  public partial class Catalog {
    internal Catalog() { }
    public static string GetPluralString(string s, string p, int n) { return default(string); }
    public static string GetString(string s) { return default(string); }
    public static void Init(string package, string localedir) { }
  }
  public enum FileAccessPattern {
    FlushCache = 4,
    NoReuse = 5,
    Normal = 0,
    PreLoad = 3,
    Random = 1,
    Sequential = 2,
  }
  [System.FlagsAttribute]
  public enum FileAccessPermissions {
    AllPermissions = 511,
    DefaultPermissions = 438,
    GroupExecute = 8,
    GroupRead = 32,
    GroupReadWriteExecute = 56,
    GroupWrite = 16,
    OtherExecute = 1,
    OtherRead = 4,
    OtherReadWriteExecute = 7,
    OtherWrite = 2,
    UserExecute = 64,
    UserRead = 256,
    UserReadWriteExecute = 448,
    UserWrite = 128,
  }
  public sealed partial class FileHandleOperations {
    internal FileHandleOperations() { }
    public static void AdviseFileAccessPattern(Mono.Unix.UnixStream stream, Mono.Unix.FileAccessPattern pattern) { }
    public static void AdviseFileAccessPattern(Mono.Unix.UnixStream stream, Mono.Unix.FileAccessPattern pattern, long offset, long len) { }
    public static void AdviseFileAccessPattern(int fd, Mono.Unix.FileAccessPattern pattern) { }
    public static void AdviseFileAccessPattern(int fd, Mono.Unix.FileAccessPattern pattern, long offset, long len) { }
    public static void AdviseFileAccessPattern(System.IO.FileStream file, Mono.Unix.FileAccessPattern pattern) { }
    public static void AdviseFileAccessPattern(System.IO.FileStream file, Mono.Unix.FileAccessPattern pattern, long offset, long len) { }
  }
  [System.FlagsAttribute]
  public enum FileSpecialAttributes {
    SetGroupId = 1024,
    SetUserId = 2048,
    Sticky = 512,
  }
  public enum FileTypes {
    BlockDevice = 24576,
    CharacterDevice = 8192,
    Directory = 16384,
    Fifo = 4096,
    RegularFile = 32768,
    Socket = 49152,
    SymbolicLink = 40960,
  }
  public partial class PeerCred {
    public PeerCred(System.Net.Sockets.Socket sock) { }
    public int GroupID { get { return default(int); } }
    public int ProcessID { get { return default(int); } }
    public int UserID { get { return default(int); } }
  }
  public partial class StdioFileStream : System.IO.Stream {
    public static readonly System.IntPtr InvalidFileStream;
    public static readonly System.IntPtr StandardError;
    public static readonly System.IntPtr StandardInput;
    public static readonly System.IntPtr StandardOutput;
    public StdioFileStream(System.IntPtr fileStream) { }
    public StdioFileStream(System.IntPtr fileStream, bool ownsHandle) { }
    public StdioFileStream(System.IntPtr fileStream, System.IO.FileAccess access) { }
    public StdioFileStream(System.IntPtr fileStream, System.IO.FileAccess access, bool ownsHandle) { }
    public StdioFileStream(string path) { }
    public StdioFileStream(string path, System.IO.FileAccess access) { }
    public StdioFileStream(string path, System.IO.FileMode mode) { }
    public StdioFileStream(string path, System.IO.FileMode mode, System.IO.FileAccess access) { }
    public StdioFileStream(string path, string mode) { }
    public override bool CanRead { get { return default(bool); } }
    public override bool CanSeek { get { return default(bool); } }
    public override bool CanWrite { get { return default(bool); } }
    public System.IntPtr Handle { get { return default(System.IntPtr); } }
    public override long Length { get { return default(long); } }
    public override long Position { get { return default(long); } set { } }
    public override void Close() { }
    ~StdioFileStream() { }
    public override void Flush() { }
    public override int Read(System.Byte[] buffer, int offset, int count) { buffer = default(System.Byte[]); return default(int); }
    public void RestoreFilePosition(Mono.Unix.Native.FilePosition pos) { }
    public void Rewind() { }
    public void SaveFilePosition(Mono.Unix.Native.FilePosition pos) { }
    public override long Seek(long offset, System.IO.SeekOrigin origin) { return default(long); }
    public override void SetLength(long value) { }
    public override void Write(System.Byte[] buffer, int offset, int count) { }
  }
  public partial class UnixClient : System.MarshalByRefObject, System.IDisposable {
    public UnixClient() { }
    public UnixClient(Mono.Unix.UnixEndPoint ep) { }
    public UnixClient(string path) { }
    public System.Net.Sockets.Socket Client { get { return default(System.Net.Sockets.Socket); } set { } }
    public System.Net.Sockets.LingerOption LingerState { get { return default(System.Net.Sockets.LingerOption); } set { } }
    public Mono.Unix.PeerCred PeerCredential { get { return default(Mono.Unix.PeerCred); } }
    public int ReceiveBufferSize { get { return default(int); } set { } }
    public int ReceiveTimeout { get { return default(int); } set { } }
    public int SendBufferSize { get { return default(int); } set { } }
    public int SendTimeout { get { return default(int); } set { } }
    public void Close() { }
    public void Connect(Mono.Unix.UnixEndPoint remoteEndPoint) { }
    public void Connect(string path) { }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    ~UnixClient() { }
    public System.Net.Sockets.NetworkStream GetStream() { return default(System.Net.Sockets.NetworkStream); }
  }
  public sealed partial class UnixDirectoryInfo : Mono.Unix.UnixFileSystemInfo {
    public UnixDirectoryInfo(string path) : base (default(string)) { }
    public override string Name { get { return default(string); } }
    public Mono.Unix.UnixDirectoryInfo Parent { get { return default(Mono.Unix.UnixDirectoryInfo); } }
    public Mono.Unix.UnixDirectoryInfo Root { get { return default(Mono.Unix.UnixDirectoryInfo); } }
    public void Create() { }
    public void Create(Mono.Unix.FileAccessPermissions mode) { }
    [System.CLSCompliantAttribute(false)]
    public void Create(Mono.Unix.Native.FilePermissions mode) { }
    public override void Delete() { }
    public void Delete(bool recursive) { }
    public static string GetCurrentDirectory() { return default(string); }
    public Mono.Unix.Native.Dirent[] GetEntries() { return default(Mono.Unix.Native.Dirent[]); }
    public Mono.Unix.Native.Dirent[] GetEntries(string regex) { return default(Mono.Unix.Native.Dirent[]); }
    public Mono.Unix.Native.Dirent[] GetEntries(System.Text.RegularExpressions.Regex regex) { return default(Mono.Unix.Native.Dirent[]); }
    public Mono.Unix.UnixFileSystemInfo[] GetFileSystemEntries() { return default(Mono.Unix.UnixFileSystemInfo[]); }
    public Mono.Unix.UnixFileSystemInfo[] GetFileSystemEntries(string regex) { return default(Mono.Unix.UnixFileSystemInfo[]); }
    public Mono.Unix.UnixFileSystemInfo[] GetFileSystemEntries(System.Text.RegularExpressions.Regex regex) { return default(Mono.Unix.UnixFileSystemInfo[]); }
    public static void SetCurrentDirectory(string path) { }
  }
  public sealed partial class UnixDriveInfo {
    public UnixDriveInfo(string mountPoint) { }
    public long AvailableFreeSpace { get { return default(long); } }
    public string DriveFormat { get { return default(string); } }
    public Mono.Unix.UnixDriveType DriveType { get { return default(Mono.Unix.UnixDriveType); } }
    public bool IsReady { get { return default(bool); } }
    public long MaximumFilenameLength { get { return default(long); } }
    public string Name { get { return default(string); } }
    public Mono.Unix.UnixDirectoryInfo RootDirectory { get { return default(Mono.Unix.UnixDirectoryInfo); } }
    public long TotalFreeSpace { get { return default(long); } }
    public long TotalSize { get { return default(long); } }
    public string VolumeLabel { get { return default(string); } }
    public static Mono.Unix.UnixDriveInfo[] GetDrives() { return default(Mono.Unix.UnixDriveInfo[]); }
    public static Mono.Unix.UnixDriveInfo GetForSpecialFile(string specialFile) { return default(Mono.Unix.UnixDriveInfo); }
    public override string ToString() { return default(string); }
  }
  public enum UnixDriveType {
    CDRom = 5,
    Fixed = 3,
    Network = 4,
    NoRootDirectory = 1,
    Ram = 6,
    Removable = 2,
    Unknown = 0,
  }
  public partial class UnixEncoding : System.Text.Encoding {
    public static readonly char EscapeByte;
    public static readonly System.Text.Encoding Instance;
    public UnixEncoding() { }
    public override bool Equals(object value) { return default(bool); }
    public override int GetByteCount(System.Char[] chars, int index, int count) { return default(int); }
    public override int GetByteCount(string s) { return default(int); }
    public override int GetBytes(System.Char[] chars, int charIndex, int charCount, System.Byte[] bytes, int byteIndex) { return default(int); }
    public override System.Byte[] GetBytes(string s) { return default(System.Byte[]); }
    public override int GetBytes(string s, int charIndex, int charCount, System.Byte[] bytes, int byteIndex) { return default(int); }
    public override int GetCharCount(System.Byte[] bytes, int index, int count) { return default(int); }
    public override int GetChars(System.Byte[] bytes, int byteIndex, int byteCount, System.Char[] chars, int charIndex) { return default(int); }
    public override System.Text.Decoder GetDecoder() { return default(System.Text.Decoder); }
    public override System.Text.Encoder GetEncoder() { return default(System.Text.Encoder); }
    public override int GetHashCode() { return default(int); }
    public override int GetMaxByteCount(int charCount) { return default(int); }
    public override int GetMaxCharCount(int byteCount) { return default(int); }
    public override System.Byte[] GetPreamble() { return default(System.Byte[]); }
  }
  public partial class UnixEndPoint : System.Net.EndPoint {
    public UnixEndPoint(string filename) { }
    public override System.Net.Sockets.AddressFamily AddressFamily { get { return default(System.Net.Sockets.AddressFamily); } }
    public string Filename { get { return default(string); } set { } }
    public override System.Net.EndPoint Create(System.Net.SocketAddress socketAddress) { return default(System.Net.EndPoint); }
    public override bool Equals(object o) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override System.Net.SocketAddress Serialize() { return default(System.Net.SocketAddress); }
    public override string ToString() { return default(string); }
  }
  public sealed partial class UnixEnvironment {
    internal UnixEnvironment() { }
    public static string CurrentDirectory { get { return default(string); } set { } }
    public static Mono.Unix.UnixGroupInfo EffectiveGroup { get { return default(Mono.Unix.UnixGroupInfo); } set { } }
    public static long EffectiveGroupId { get { return default(long); } set { } }
    public static Mono.Unix.UnixUserInfo EffectiveUser { get { return default(Mono.Unix.UnixUserInfo); } set { } }
    public static long EffectiveUserId { get { return default(long); } set { } }
    public static string Login { get { return default(string); } }
    public static string MachineName { get { return default(string); } set { } }
    public static Mono.Unix.UnixGroupInfo RealGroup { get { return default(Mono.Unix.UnixGroupInfo); } }
    public static long RealGroupId { get { return default(long); } }
    public static Mono.Unix.UnixUserInfo RealUser { get { return default(Mono.Unix.UnixUserInfo); } }
    public static long RealUserId { get { return default(long); } }
    public static string UserName { get { return default(string); } }
    public static int CreateSession() { return default(int); }
    [System.CLSCompliantAttribute(false)]
    public static string GetConfigurationString(Mono.Unix.Native.ConfstrName name) { return default(string); }
    [System.CLSCompliantAttribute(false)]
    public static long GetConfigurationValue(Mono.Unix.Native.SysconfName name) { return default(long); }
    public static Mono.Unix.UnixProcess GetParentProcess() { return default(Mono.Unix.UnixProcess); }
    public static int GetParentProcessId() { return default(int); }
    public static int GetProcessGroup() { return default(int); }
    public static System.Int64[] GetSupplementaryGroupIds() { return default(System.Int64[]); }
    public static Mono.Unix.UnixGroupInfo[] GetSupplementaryGroups() { return default(Mono.Unix.UnixGroupInfo[]); }
    public static System.String[] GetUserShells() { return default(System.String[]); }
    public static void SetNiceValue(int inc) { }
    public static void SetProcessGroup() { }
    public static void SetSupplementaryGroupIds(System.Int64[] list) { }
    public static void SetSupplementaryGroups(Mono.Unix.UnixGroupInfo[] groups) { }
  }
  public sealed partial class UnixFileInfo : Mono.Unix.UnixFileSystemInfo {
    public UnixFileInfo(string path) : base (default(string)) { }
    public Mono.Unix.UnixDirectoryInfo Directory { get { return default(Mono.Unix.UnixDirectoryInfo); } }
    public string DirectoryName { get { return default(string); } }
    public override string Name { get { return default(string); } }
    public Mono.Unix.UnixStream Create() { return default(Mono.Unix.UnixStream); }
    public Mono.Unix.UnixStream Create(Mono.Unix.FileAccessPermissions mode) { return default(Mono.Unix.UnixStream); }
    [System.CLSCompliantAttribute(false)]
    public Mono.Unix.UnixStream Create(Mono.Unix.Native.FilePermissions mode) { return default(Mono.Unix.UnixStream); }
    public override void Delete() { }
    [System.CLSCompliantAttribute(false)]
    public Mono.Unix.UnixStream Open(Mono.Unix.Native.OpenFlags flags) { return default(Mono.Unix.UnixStream); }
    [System.CLSCompliantAttribute(false)]
    public Mono.Unix.UnixStream Open(Mono.Unix.Native.OpenFlags flags, Mono.Unix.Native.FilePermissions mode) { return default(Mono.Unix.UnixStream); }
    public Mono.Unix.UnixStream Open(System.IO.FileMode mode) { return default(Mono.Unix.UnixStream); }
    public Mono.Unix.UnixStream Open(System.IO.FileMode mode, System.IO.FileAccess access) { return default(Mono.Unix.UnixStream); }
    [System.CLSCompliantAttribute(false)]
    public Mono.Unix.UnixStream Open(System.IO.FileMode mode, System.IO.FileAccess access, Mono.Unix.Native.FilePermissions perms) { return default(Mono.Unix.UnixStream); }
    public Mono.Unix.UnixStream OpenRead() { return default(Mono.Unix.UnixStream); }
    public Mono.Unix.UnixStream OpenWrite() { return default(Mono.Unix.UnixStream); }
  }
  public abstract partial class UnixFileSystemInfo {
    protected UnixFileSystemInfo(string path) { }
    public long BlocksAllocated { get { return default(long); } }
    public long BlockSize { get { return default(long); } }
    public long Device { get { return default(long); } }
    public long DeviceType { get { return default(long); } }
    public bool Exists { get { return default(bool); } }
    public Mono.Unix.FileAccessPermissions FileAccessPermissions { get { return default(Mono.Unix.FileAccessPermissions); } set { } }
    public Mono.Unix.FileSpecialAttributes FileSpecialAttributes { get { return default(Mono.Unix.FileSpecialAttributes); } set { } }
    public Mono.Unix.FileTypes FileType { get { return default(Mono.Unix.FileTypes); } }
    public virtual string FullName { get { return default(string); } }
    protected string FullPath { get { return default(string); } set { } }
    public long Inode { get { return default(long); } }
    public bool IsBlockDevice { get { return default(bool); } }
    public bool IsCharacterDevice { get { return default(bool); } }
    public bool IsDirectory { get { return default(bool); } }
    public bool IsFifo { get { return default(bool); } }
    public bool IsRegularFile { get { return default(bool); } }
    public bool IsSetGroup { get { return default(bool); } }
    public bool IsSetUser { get { return default(bool); } }
    public bool IsSocket { get { return default(bool); } }
    public bool IsSticky { get { return default(bool); } }
    public bool IsSymbolicLink { get { return default(bool); } }
    public System.DateTime LastAccessTime { get { return default(System.DateTime); } }
    public System.DateTime LastAccessTimeUtc { get { return default(System.DateTime); } }
    public System.DateTime LastStatusChangeTime { get { return default(System.DateTime); } }
    public System.DateTime LastStatusChangeTimeUtc { get { return default(System.DateTime); } }
    public System.DateTime LastWriteTime { get { return default(System.DateTime); } }
    public System.DateTime LastWriteTimeUtc { get { return default(System.DateTime); } }
    public long Length { get { return default(long); } }
    public long LinkCount { get { return default(long); } }
    public abstract string Name { get; }
    protected string OriginalPath { get { return default(string); } set { } }
    public Mono.Unix.UnixGroupInfo OwnerGroup { get { return default(Mono.Unix.UnixGroupInfo); } }
    public long OwnerGroupId { get { return default(long); } }
    public Mono.Unix.UnixUserInfo OwnerUser { get { return default(Mono.Unix.UnixUserInfo); } }
    public long OwnerUserId { get { return default(long); } }
    [System.CLSCompliantAttribute(false)]
    public Mono.Unix.Native.FilePermissions Protection { get { return default(Mono.Unix.Native.FilePermissions); } set { } }
    [System.CLSCompliantAttribute(false)]
    public bool CanAccess(Mono.Unix.Native.AccessModes mode) { return default(bool); }
    public Mono.Unix.UnixFileSystemInfo CreateLink(string path) { return default(Mono.Unix.UnixFileSystemInfo); }
    public Mono.Unix.UnixSymbolicLinkInfo CreateSymbolicLink(string path) { return default(Mono.Unix.UnixSymbolicLinkInfo); }
    public abstract void Delete();
    [System.CLSCompliantAttribute(false)]
    public long GetConfigurationValue(Mono.Unix.Native.PathconfName name) { return default(long); }
    protected virtual bool GetFileStatus(string path, out Mono.Unix.Native.Stat stat) { stat = default(Mono.Unix.Native.Stat); return default(bool); }
    public static Mono.Unix.UnixFileSystemInfo GetFileSystemEntry(string path) { return default(Mono.Unix.UnixFileSystemInfo); }
    public void Refresh() { }
    public void SetLength(long length) { }
    public void SetOwner(Mono.Unix.UnixUserInfo owner) { }
    public void SetOwner(Mono.Unix.UnixUserInfo owner, Mono.Unix.UnixGroupInfo group) { }
    public virtual void SetOwner(long owner, long group) { }
    public void SetOwner(string owner) { }
    public void SetOwner(string owner, string group) { }
    public Mono.Unix.Native.Stat ToStat() { return default(Mono.Unix.Native.Stat); }
    public override string ToString() { return default(string); }
    public static bool TryGetFileSystemEntry(string path, out Mono.Unix.UnixFileSystemInfo entry) { entry = default(Mono.Unix.UnixFileSystemInfo); return default(bool); }
  }
  public sealed partial class UnixGroupInfo {
    public UnixGroupInfo(Mono.Unix.Native.Group group) { }
    public UnixGroupInfo(long group) { }
    public UnixGroupInfo(string group) { }
    public long GroupId { get { return default(long); } }
    public string GroupName { get { return default(string); } }
    public string Password { get { return default(string); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static Mono.Unix.UnixGroupInfo[] GetLocalGroups() { return default(Mono.Unix.UnixGroupInfo[]); }
    public System.String[] GetMemberNames() { return default(System.String[]); }
    public Mono.Unix.UnixUserInfo[] GetMembers() { return default(Mono.Unix.UnixUserInfo[]); }
    public Mono.Unix.Native.Group ToGroup() { return default(Mono.Unix.Native.Group); }
    public override string ToString() { return default(string); }
  }
  public partial class UnixIOException : System.IO.IOException {
    public UnixIOException() { }
    public UnixIOException(Mono.Unix.Native.Errno errno) { }
    public UnixIOException(Mono.Unix.Native.Errno errno, System.Exception inner) { }
    public UnixIOException(int errno) { }
    public UnixIOException(int errno, System.Exception inner) { }
    protected UnixIOException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public UnixIOException(string message) { }
    public UnixIOException(string message, System.Exception inner) { }
    public Mono.Unix.Native.Errno ErrorCode { get { return default(Mono.Unix.Native.Errno); } }
    public int NativeErrorCode { get { return default(int); } }
  }
  public partial class UnixListener : System.MarshalByRefObject, System.IDisposable {
    public UnixListener(Mono.Unix.UnixEndPoint localEndPoint) { }
    public UnixListener(string path) { }
    public System.Net.EndPoint LocalEndpoint { get { return default(System.Net.EndPoint); } }
    protected System.Net.Sockets.Socket Server { get { return default(System.Net.Sockets.Socket); } }
    public System.Net.Sockets.Socket AcceptSocket() { return default(System.Net.Sockets.Socket); }
    public Mono.Unix.UnixClient AcceptUnixClient() { return default(Mono.Unix.UnixClient); }
    public void Dispose() { }
    protected void Dispose(bool disposing) { }
    ~UnixListener() { }
    public bool Pending() { return default(bool); }
    public void Start() { }
    public void Start(int backlog) { }
    public void Stop() { }
  }
  public sealed partial class UnixMarshal {
    internal UnixMarshal() { }
    public static System.IntPtr AllocHeap(long size) { return default(System.IntPtr); }
    public static void FreeHeap(System.IntPtr ptr) { }
    [System.CLSCompliantAttribute(false)]
    public static string GetErrorDescription(Mono.Unix.Native.Errno errno) { return default(string); }
    public static string PtrToString(System.IntPtr p) { return default(string); }
    public static string PtrToString(System.IntPtr p, System.Text.Encoding encoding) { return default(string); }
    public static System.String[] PtrToStringArray(int count, System.IntPtr stringArray) { return default(System.String[]); }
    public static System.String[] PtrToStringArray(int count, System.IntPtr stringArray, System.Text.Encoding encoding) { return default(System.String[]); }
    public static System.String[] PtrToStringArray(System.IntPtr stringArray) { return default(System.String[]); }
    public static System.String[] PtrToStringArray(System.IntPtr stringArray, System.Text.Encoding encoding) { return default(System.String[]); }
    public static string PtrToStringUnix(System.IntPtr p) { return default(string); }
    public static System.IntPtr ReAllocHeap(System.IntPtr ptr, long size) { return default(System.IntPtr); }
    public static bool ShouldRetrySyscall(int r) { return default(bool); }
    [System.CLSCompliantAttribute(false)]
    public static bool ShouldRetrySyscall(int r, out Mono.Unix.Native.Errno errno) { errno = default(Mono.Unix.Native.Errno); return default(bool); }
    public static System.IntPtr StringToHeap(string s) { return default(System.IntPtr); }
    public static System.IntPtr StringToHeap(string s, int index, int count) { return default(System.IntPtr); }
    public static System.IntPtr StringToHeap(string s, int index, int count, System.Text.Encoding encoding) { return default(System.IntPtr); }
    public static System.IntPtr StringToHeap(string s, System.Text.Encoding encoding) { return default(System.IntPtr); }
    [System.CLSCompliantAttribute(false)]
    public static void ThrowExceptionForError(Mono.Unix.Native.Errno errno) { }
    [System.CLSCompliantAttribute(false)]
    public static void ThrowExceptionForErrorIf(int retval, Mono.Unix.Native.Errno errno) { }
    public static void ThrowExceptionForLastError() { }
    public static void ThrowExceptionForLastErrorIf(int retval) { }
  }
  public sealed partial class UnixPath {
    internal UnixPath() { }
    public static readonly char AltDirectorySeparatorChar;
    public static readonly char DirectorySeparatorChar;
    public static readonly char PathSeparator;
    public static readonly char VolumeSeparatorChar;
    public static string Combine(string path1, params System.String[] paths) { return default(string); }
    public static string GetCanonicalPath(string path) { return default(string); }
    public static string GetCompleteRealPath(string path) { return default(string); }
    public static string GetDirectoryName(string path) { return default(string); }
    public static string GetFileName(string path) { return default(string); }
    public static string GetFullPath(string path) { return default(string); }
    public static System.Char[] GetInvalidPathChars() { return default(System.Char[]); }
    public static string GetPathRoot(string path) { return default(string); }
    public static string GetRealPath(string path) { return default(string); }
    public static bool IsPathRooted(string path) { return default(bool); }
    public static string ReadLink(string path) { return default(string); }
    public static string ReadLinkAt(int dirfd, string path) { return default(string); }
    public static string TryReadLink(string path) { return default(string); }
    public static string TryReadLinkAt(int dirfd, string path) { return default(string); }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct UnixPipes : System.IEquatable<Mono.Unix.UnixPipes> {
    public Mono.Unix.UnixStream Reading;
    public Mono.Unix.UnixStream Writing;
    public UnixPipes(Mono.Unix.UnixStream reading, Mono.Unix.UnixStream writing) { throw new System.NotImplementedException(); }
    public static Mono.Unix.UnixPipes CreatePipes() { return default(Mono.Unix.UnixPipes); }
    public bool Equals(Mono.Unix.UnixPipes value) { return default(bool); }
    public override bool Equals(object value) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(Mono.Unix.UnixPipes lhs, Mono.Unix.UnixPipes rhs) { return default(bool); }
    public static bool operator !=(Mono.Unix.UnixPipes lhs, Mono.Unix.UnixPipes rhs) { return default(bool); }
  }
  public sealed partial class UnixProcess {
    internal UnixProcess() { }
    public int ExitCode { get { return default(int); } }
    public bool HasExited { get { return default(bool); } }
    public bool HasSignaled { get { return default(bool); } }
    public bool HasStopped { get { return default(bool); } }
    public int Id { get { return default(int); } }
    public int ProcessGroupId { get { return default(int); } set { } }
    public int SessionId { get { return default(int); } }
    public Mono.Unix.Native.Signum StopSignal { get { return default(Mono.Unix.Native.Signum); } }
    public Mono.Unix.Native.Signum TerminationSignal { get { return default(Mono.Unix.Native.Signum); } }
    public static Mono.Unix.UnixProcess GetCurrentProcess() { return default(Mono.Unix.UnixProcess); }
    public static int GetCurrentProcessId() { return default(int); }
    public void Kill() { }
    [System.CLSCompliantAttribute(false)]
    public void Signal(Mono.Unix.Native.Signum signal) { }
    public void WaitForExit() { }
  }
  public partial class UnixSignal : System.Threading.WaitHandle {
    public UnixSignal(Mono.Unix.Native.RealTimeSignum rtsig) { }
    public UnixSignal(Mono.Unix.Native.Signum signum) { }
    public int Count { get { return default(int); } set { } }
    public bool IsRealTimeSignal { get { return default(bool); } }
    public bool IsSet { get { return default(bool); } }
    public Mono.Unix.Native.RealTimeSignum RealTimeSignum { get { return default(Mono.Unix.Native.RealTimeSignum); } }
    public Mono.Unix.Native.Signum Signum { get { return default(Mono.Unix.Native.Signum); } }
    protected override void Dispose(bool disposing) { }
    public bool Reset() { return default(bool); }
    public static int WaitAny(Mono.Unix.UnixSignal[] signals) { return default(int); }
    public static int WaitAny(Mono.Unix.UnixSignal[] signals, int millisecondsTimeout) { return default(int); }
    public static int WaitAny(Mono.Unix.UnixSignal[] signals, System.TimeSpan timeout) { return default(int); }
    public override bool WaitOne() { return default(bool); }
    public override bool WaitOne(int millisecondsTimeout, bool exitContext) { return default(bool); }
    public override bool WaitOne(System.TimeSpan timeout, bool exitContext) { return default(bool); }
  }
  public sealed partial class UnixStream : System.IO.Stream, System.IDisposable {
    public const int InvalidFileDescriptor = -1;
    public const int StandardErrorFileDescriptor = 2;
    public const int StandardInputFileDescriptor = 0;
    public const int StandardOutputFileDescriptor = 1;
    public UnixStream(int fileDescriptor) { }
    public UnixStream(int fileDescriptor, bool ownsHandle) { }
    public override bool CanRead { get { return default(bool); } }
    public override bool CanSeek { get { return default(bool); } }
    public override bool CanWrite { get { return default(bool); } }
    public Mono.Unix.FileAccessPermissions FileAccessPermissions { get { return default(Mono.Unix.FileAccessPermissions); } set { } }
    public Mono.Unix.FileSpecialAttributes FileSpecialAttributes { get { return default(Mono.Unix.FileSpecialAttributes); } set { } }
    public Mono.Unix.FileTypes FileType { get { return default(Mono.Unix.FileTypes); } }
    public int Handle { get { return default(int); } }
    public override long Length { get { return default(long); } }
    public Mono.Unix.UnixGroupInfo OwnerGroup { get { return default(Mono.Unix.UnixGroupInfo); } }
    public long OwnerGroupId { get { return default(long); } }
    public Mono.Unix.UnixUserInfo OwnerUser { get { return default(Mono.Unix.UnixUserInfo); } }
    public long OwnerUserId { get { return default(long); } }
    public override long Position { get { return default(long); } set { } }
    [System.CLSCompliantAttribute(false)]
    public Mono.Unix.Native.FilePermissions Protection { get { return default(Mono.Unix.Native.FilePermissions); } set { } }
    public void AdviseFileAccessPattern(Mono.Unix.FileAccessPattern pattern) { }
    public void AdviseFileAccessPattern(Mono.Unix.FileAccessPattern pattern, long offset, long len) { }
    public override void Close() { }
    ~UnixStream() { }
    public override void Flush() { }
    [System.CLSCompliantAttribute(false)]
    public long GetConfigurationValue(Mono.Unix.Native.PathconfName name) { return default(long); }
    public override int Read(System.Byte[] buffer, int offset, int count) { buffer = default(System.Byte[]); return default(int); }
    public int ReadAtOffset(System.Byte[] buffer, int offset, int count, long fileOffset) { buffer = default(System.Byte[]); return default(int); }
    public override long Seek(long offset, System.IO.SeekOrigin origin) { return default(long); }
    public void SendTo(Mono.Unix.UnixStream output) { }
    [System.CLSCompliantAttribute(false)]
    public void SendTo(Mono.Unix.UnixStream output, ulong count) { }
    [System.CLSCompliantAttribute(false)]
    public void SendTo(int out_fd, ulong count) { }
    public override void SetLength(long value) { }
    public void SetOwner(long user, long group) { }
    public void SetOwner(string user) { }
    public void SetOwner(string user, string group) { }
    void System.IDisposable.Dispose() { }
    public override void Write(System.Byte[] buffer, int offset, int count) { }
    public void WriteAtOffset(System.Byte[] buffer, int offset, int count, long fileOffset) { }
  }
  public sealed partial class UnixSymbolicLinkInfo : Mono.Unix.UnixFileSystemInfo {
    public UnixSymbolicLinkInfo(string path) : base (default(string)) { }
    [System.ObsoleteAttribute("Use GetContents()")]
    public Mono.Unix.UnixFileSystemInfo Contents { get { return default(Mono.Unix.UnixFileSystemInfo); } }
    public string ContentsPath { get { return default(string); } }
    public bool HasContents { get { return default(bool); } }
    public override string Name { get { return default(string); } }
    public void CreateSymbolicLinkTo(Mono.Unix.UnixFileSystemInfo path) { }
    public void CreateSymbolicLinkTo(string path) { }
    public override void Delete() { }
    public Mono.Unix.UnixFileSystemInfo GetContents() { return default(Mono.Unix.UnixFileSystemInfo); }
    protected override bool GetFileStatus(string path, out Mono.Unix.Native.Stat stat) { stat = default(Mono.Unix.Native.Stat); return default(bool); }
    public override void SetOwner(long owner, long group) { }
  }
  public sealed partial class UnixUserInfo {
    public UnixUserInfo(Mono.Unix.Native.Passwd passwd) { }
    public UnixUserInfo(long user) { }
    public UnixUserInfo(string user) { }
    [System.CLSCompliantAttribute(false)]
    public UnixUserInfo(uint user) { }
    public Mono.Unix.UnixGroupInfo Group { get { return default(Mono.Unix.UnixGroupInfo); } }
    public long GroupId { get { return default(long); } }
    public string GroupName { get { return default(string); } }
    public string HomeDirectory { get { return default(string); } }
    public string Password { get { return default(string); } }
    public string RealName { get { return default(string); } }
    public string ShellProgram { get { return default(string); } }
    public long UserId { get { return default(long); } }
    public string UserName { get { return default(string); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static Mono.Unix.UnixUserInfo[] GetLocalUsers() { return default(Mono.Unix.UnixUserInfo[]); }
    public static string GetLoginName() { return default(string); }
    public static Mono.Unix.UnixUserInfo GetRealUser() { return default(Mono.Unix.UnixUserInfo); }
    public static long GetRealUserId() { return default(long); }
    public Mono.Unix.Native.Passwd ToPasswd() { return default(Mono.Unix.Native.Passwd); }
    public override string ToString() { return default(string); }
  }
}
namespace Mono.Unix.Native {
  [MapAttribute]
  [System.CLSCompliantAttribute(false)]
  [System.FlagsAttribute]
  public enum AccessModes {
    F_OK = 8,
    R_OK = 1,
    W_OK = 2,
    X_OK = 4,
  }
  [MapAttribute]
  [System.CLSCompliantAttribute(false)]
  [System.FlagsAttribute]
  public enum AtFlags {
    AT_EMPTY_PATH = 4096,
    AT_NO_AUTOMOUNT = 2048,
    AT_REMOVEDIR = 512,
    AT_SYMLINK_FOLLOW = 1024,
    AT_SYMLINK_NOFOLLOW = 256,
  }
  public sealed partial class CdeclFunction {
    public CdeclFunction(string library, string method) { }
    public CdeclFunction(string library, string method, System.Type returnType) { }
    public object Invoke(System.Object[] parameters) { return default(object); }
  }
  [MapAttribute]
  [System.CLSCompliantAttribute(false)]
  public enum ConfstrName {
    _CS_GNU_LIBC_VERSION = 2,
    _CS_GNU_LIBPTHREAD_VERSION = 3,
    _CS_LFS_CFLAGS = 1000,
    _CS_LFS_LDFLAGS = 1001,
    _CS_LFS_LIBS = 1002,
    _CS_LFS_LINTFLAGS = 1003,
    _CS_LFS64_CFLAGS = 1004,
    _CS_LFS64_LDFLAGS = 1005,
    _CS_LFS64_LIBS = 1006,
    _CS_LFS64_LINTFLAGS = 1007,
    _CS_PATH = 0,
    _CS_POSIX_V6_ILP32_OFF32_CFLAGS = 1116,
    _CS_POSIX_V6_ILP32_OFF32_LDFLAGS = 1117,
    _CS_POSIX_V6_ILP32_OFF32_LIBS = 1118,
    _CS_POSIX_V6_ILP32_OFF32_LINTFLAGS = 1119,
    _CS_POSIX_V6_ILP32_OFFBIG_CFLAGS = 1120,
    _CS_POSIX_V6_ILP32_OFFBIG_LDFLAGS = 1121,
    _CS_POSIX_V6_ILP32_OFFBIG_LIBS = 1122,
    _CS_POSIX_V6_ILP32_OFFBIG_LINTFLAGS = 1123,
    _CS_POSIX_V6_LP64_OFF64_CFLAGS = 1124,
    _CS_POSIX_V6_LP64_OFF64_LDFLAGS = 1125,
    _CS_POSIX_V6_LP64_OFF64_LIBS = 1126,
    _CS_POSIX_V6_LP64_OFF64_LINTFLAGS = 1127,
    _CS_POSIX_V6_LPBIG_OFFBIG_CFLAGS = 1128,
    _CS_POSIX_V6_LPBIG_OFFBIG_LDFLAGS = 1129,
    _CS_POSIX_V6_LPBIG_OFFBIG_LIBS = 1130,
    _CS_POSIX_V6_LPBIG_OFFBIG_LINTFLAGS = 1131,
    _CS_V6_WIDTH_RESTRICTED_ENVS = 1,
    _CS_XBS5_ILP32_OFF32_CFLAGS = 1100,
    _CS_XBS5_ILP32_OFF32_LDFLAGS = 1101,
    _CS_XBS5_ILP32_OFF32_LIBS = 1102,
    _CS_XBS5_ILP32_OFF32_LINTFLAGS = 1103,
    _CS_XBS5_ILP32_OFFBIG_CFLAGS = 1104,
    _CS_XBS5_ILP32_OFFBIG_LDFLAGS = 1105,
    _CS_XBS5_ILP32_OFFBIG_LIBS = 1106,
    _CS_XBS5_ILP32_OFFBIG_LINTFLAGS = 1107,
    _CS_XBS5_LP64_OFF64_CFLAGS = 1108,
    _CS_XBS5_LP64_OFF64_LDFLAGS = 1109,
    _CS_XBS5_LP64_OFF64_LIBS = 1110,
    _CS_XBS5_LP64_OFF64_LINTFLAGS = 1111,
    _CS_XBS5_LPBIG_OFFBIG_CFLAGS = 1112,
    _CS_XBS5_LPBIG_OFFBIG_LDFLAGS = 1113,
    _CS_XBS5_LPBIG_OFFBIG_LIBS = 1114,
    _CS_XBS5_LPBIG_OFFBIG_LINTFLAGS = 1115,
  }
  [MapAttribute]
  [System.CLSCompliantAttribute(false)]
  [System.FlagsAttribute]
  public enum DirectoryNotifyFlags {
    DN_ACCESS = 1,
    DN_ATTRIB = 32,
    DN_CREATE = 4,
    DN_DELETE = 8,
    DN_MODIFY = 2,
    DN_MULTISHOT = -2147483648,
    DN_RENAME = 16,
  }
  public sealed partial class Dirent : System.IEquatable<Mono.Unix.Native.Dirent> {
    [System.CLSCompliantAttribute(false)]
    public ulong d_ino;
    public string d_name;
    public long d_off;
    [System.CLSCompliantAttribute(false)]
    public ushort d_reclen;
    public byte d_type;
    public Dirent() { }
    public bool Equals(Mono.Unix.Native.Dirent value) { return default(bool); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(Mono.Unix.Native.Dirent lhs, Mono.Unix.Native.Dirent rhs) { return default(bool); }
    public static bool operator !=(Mono.Unix.Native.Dirent lhs, Mono.Unix.Native.Dirent rhs) { return default(bool); }
    public override string ToString() { return default(string); }
  }
  [System.CLSCompliantAttribute(false)]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit, Size=12)]
  public partial struct EpollEvent {
    [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
    public Mono.Unix.Native.EpollEvents events;
    [System.Runtime.InteropServices.FieldOffsetAttribute(4)]
    public int fd;
    [System.Runtime.InteropServices.FieldOffsetAttribute(4)]
    public System.IntPtr ptr;
    [System.Runtime.InteropServices.FieldOffsetAttribute(4)]
    public uint u32;
    [System.Runtime.InteropServices.FieldOffsetAttribute(4)]
    public ulong u64;
  }
  [MapAttribute]
  [System.CLSCompliantAttribute(false)]
  [System.FlagsAttribute]
  public enum EpollEvents : uint {
    EPOLLERR = (uint)8,
    EPOLLET = (uint)2147483648,
    EPOLLHUP = (uint)16,
    EPOLLIN = (uint)1,
    EPOLLMSG = (uint)1024,
    EPOLLONESHOT = (uint)1073741824,
    EPOLLOUT = (uint)4,
    EPOLLPRI = (uint)2,
    EPOLLRDBAND = (uint)128,
    EPOLLRDHUP = (uint)8192,
    EPOLLRDNORM = (uint)64,
    EPOLLWRBAND = (uint)512,
    EPOLLWRNORM = (uint)256,
  }
  [MapAttribute]
  [System.FlagsAttribute]
  public enum EpollFlags {
    EPOLL_CLOEXEC = 2000000,
    EPOLL_NONBLOCK = 4000,
  }
  public enum EpollOp {
    EPOLL_CTL_ADD = 1,
    EPOLL_CTL_DEL = 2,
    EPOLL_CTL_MOD = 3,
  }
  [MapAttribute]
  public enum Errno {
    E2BIG = 7,
    EACCES = 13,
    EADDRINUSE = 98,
    EADDRNOTAVAIL = 99,
    EADV = 68,
    EAFNOSUPPORT = 97,
    EAGAIN = 11,
    EALREADY = 114,
    EAUTH = 1080,
    EBADARCH = 1086,
    EBADE = 52,
    EBADEXEC = 1085,
    EBADF = 9,
    EBADFD = 77,
    EBADMACHO = 1088,
    EBADMSG = 74,
    EBADR = 53,
    EBADRPC = 1072,
    EBADRQC = 56,
    EBADSLT = 57,
    EBFONT = 59,
    EBUSY = 16,
    ECANCELED = 125,
    ECHILD = 10,
    ECHRNG = 44,
    ECOMM = 70,
    ECONNABORTED = 103,
    ECONNREFUSED = 111,
    ECONNRESET = 104,
    EDEADLK = 35,
    EDEADLOCK = 35,
    EDESTADDRREQ = 89,
    EDEVERR = 1083,
    EDOM = 33,
    EDOTDOT = 73,
    EDQUOT = 122,
    EEXIST = 17,
    EFAULT = 14,
    EFBIG = 27,
    EFTYPE = 1079,
    EHOSTDOWN = 112,
    EHOSTUNREACH = 113,
    EIDRM = 43,
    EILSEQ = 84,
    EINPROGRESS = 115,
    EINTR = 4,
    EINVAL = 22,
    EIO = 5,
    EISCONN = 106,
    EISDIR = 21,
    EISNAM = 120,
    EKEYEXPIRED = 127,
    EKEYREJECTED = 129,
    EKEYREVOKED = 128,
    EL2HLT = 51,
    EL2NSYNC = 45,
    EL3HLT = 46,
    EL3RST = 47,
    ELIBACC = 79,
    ELIBBAD = 80,
    ELIBEXEC = 83,
    ELIBMAX = 82,
    ELIBSCN = 81,
    ELNRNG = 48,
    ELOOP = 40,
    EMEDIUMTYPE = 124,
    EMFILE = 24,
    EMLINK = 31,
    EMSGSIZE = 90,
    EMULTIHOP = 72,
    ENAMETOOLONG = 36,
    ENAVAIL = 119,
    ENEEDAUTH = 1081,
    ENETDOWN = 100,
    ENETRESET = 102,
    ENETUNREACH = 101,
    ENFILE = 23,
    ENOANO = 55,
    ENOATTR = 1093,
    ENOBUFS = 105,
    ENOCSI = 50,
    ENODATA = 61,
    ENODEV = 19,
    ENOENT = 2,
    ENOEXEC = 8,
    ENOKEY = 126,
    ENOLCK = 37,
    ENOLINK = 67,
    ENOMEDIUM = 123,
    ENOMEM = 12,
    ENOMSG = 42,
    ENONET = 64,
    ENOPKG = 65,
    ENOPOLICY = 1103,
    ENOPROTOOPT = 92,
    ENOSPC = 28,
    ENOSR = 63,
    ENOSTR = 60,
    ENOSYS = 38,
    ENOTBLK = 15,
    ENOTCONN = 107,
    ENOTDIR = 20,
    ENOTEMPTY = 39,
    ENOTNAM = 118,
    ENOTRECOVERABLE = 131,
    ENOTSOCK = 88,
    ENOTTY = 25,
    ENOTUNIQ = 76,
    ENXIO = 6,
    EOPNOTSUPP = 95,
    EOVERFLOW = 75,
    EOWNERDEAD = 130,
    EPERM = 1,
    EPFNOSUPPORT = 96,
    EPIPE = 32,
    EPROCLIM = 1067,
    EPROCUNAVAIL = 1076,
    EPROGMISMATCH = 1075,
    EPROGUNAVAIL = 1074,
    EPROTO = 71,
    EPROTONOSUPPORT = 93,
    EPROTOTYPE = 91,
    EPWROFF = 1082,
    ERANGE = 34,
    EREMCHG = 78,
    EREMOTE = 66,
    EREMOTEIO = 121,
    ERESTART = 85,
    EROFS = 30,
    ERPCMISMATCH = 1073,
    ESHLIBVERS = 1087,
    ESHUTDOWN = 108,
    ESOCKTNOSUPPORT = 94,
    ESPIPE = 29,
    ESRCH = 3,
    ESRMNT = 69,
    ESTALE = 116,
    ESTRPIPE = 86,
    ETIME = 62,
    ETIMEDOUT = 110,
    ETOOMANYREFS = 109,
    ETXTBSY = 26,
    EUCLEAN = 117,
    EUNATCH = 49,
    EUSERS = 87,
    EWOULDBLOCK = 11,
    EXDEV = 18,
    EXFULL = 54,
  }
  [MapAttribute]
  [System.CLSCompliantAttribute(false)]
  public enum FcntlCommand {
    F_DUPFD = 0,
    F_GETFD = 1,
    F_GETFL = 3,
    F_GETLEASE = 1025,
    F_GETLK = 12,
    F_GETOWN = 9,
    F_GETSIG = 11,
    F_NOTIFY = 1026,
    F_SETFD = 2,
    F_SETFL = 4,
    F_SETLEASE = 1024,
    F_SETLK = 13,
    F_SETLKW = 14,
    F_SETOWN = 8,
    F_SETSIG = 10,
  }
  [MapAttribute]
  [System.CLSCompliantAttribute(false)]
  [System.FlagsAttribute]
  public enum FilePermissions : uint {
    ACCESSPERMS = (uint)511,
    ALLPERMS = (uint)4095,
    DEFFILEMODE = (uint)438,
    [MapAttribute(SuppressFlags="S_IFMT")]
    S_IFBLK = (uint)24576,
    [MapAttribute(SuppressFlags="S_IFMT")]
    S_IFCHR = (uint)8192,
    [MapAttribute(SuppressFlags="S_IFMT")]
    S_IFDIR = (uint)16384,
    [MapAttribute(SuppressFlags="S_IFMT")]
    S_IFIFO = (uint)4096,
    [MapAttribute(SuppressFlags="S_IFMT")]
    S_IFLNK = (uint)40960,
    S_IFMT = (uint)61440,
    [MapAttribute(SuppressFlags="S_IFMT")]
    S_IFREG = (uint)32768,
    [MapAttribute(SuppressFlags="S_IFMT")]
    S_IFSOCK = (uint)49152,
    S_IRGRP = (uint)32,
    S_IROTH = (uint)4,
    S_IRUSR = (uint)256,
    S_IRWXG = (uint)56,
    S_IRWXO = (uint)7,
    S_IRWXU = (uint)448,
    S_ISGID = (uint)1024,
    S_ISUID = (uint)2048,
    S_ISVTX = (uint)512,
    S_IWGRP = (uint)16,
    S_IWOTH = (uint)2,
    S_IWUSR = (uint)128,
    S_IXGRP = (uint)8,
    S_IXOTH = (uint)1,
    S_IXUSR = (uint)64,
  }
  public sealed partial class FilePosition : System.MarshalByRefObject, System.IDisposable, System.IEquatable<Mono.Unix.Native.FilePosition> {
    public FilePosition() { }
    public void Dispose() { }
    public bool Equals(Mono.Unix.Native.FilePosition value) { return default(bool); }
    public override bool Equals(object obj) { return default(bool); }
    ~FilePosition() { }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(Mono.Unix.Native.FilePosition lhs, Mono.Unix.Native.FilePosition rhs) { return default(bool); }
    public static bool operator !=(Mono.Unix.Native.FilePosition lhs, Mono.Unix.Native.FilePosition rhs) { return default(bool); }
    public override string ToString() { return default(string); }
  }
  [MapAttribute("struct flock")]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Flock : System.IEquatable<Mono.Unix.Native.Flock> {
    [Mono.Unix.Native.off_tAttribute]
    public long l_len;
    [Mono.Unix.Native.pid_tAttribute]
    public int l_pid;
    [Mono.Unix.Native.off_tAttribute]
    public long l_start;
    [System.CLSCompliantAttribute(false)]
    public Mono.Unix.Native.LockType l_type;
    [System.CLSCompliantAttribute(false)]
    public Mono.Unix.Native.SeekFlags l_whence;
    public bool Equals(Mono.Unix.Native.Flock value) { return default(bool); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(Mono.Unix.Native.Flock lhs, Mono.Unix.Native.Flock rhs) { return default(bool); }
    public static bool operator !=(Mono.Unix.Native.Flock lhs, Mono.Unix.Native.Flock rhs) { return default(bool); }
  }
  public sealed partial class Fstab : System.IEquatable<Mono.Unix.Native.Fstab> {
    public string fs_file;
    public int fs_freq;
    public string fs_mntops;
    public int fs_passno;
    public string fs_spec;
    public string fs_type;
    public string fs_vfstype;
    public Fstab() { }
    public bool Equals(Mono.Unix.Native.Fstab value) { return default(bool); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(Mono.Unix.Native.Fstab lhs, Mono.Unix.Native.Fstab rhs) { return default(bool); }
    public static bool operator !=(Mono.Unix.Native.Fstab lhs, Mono.Unix.Native.Fstab rhs) { return default(bool); }
    public override string ToString() { return default(string); }
  }
  public sealed partial class Group : System.IEquatable<Mono.Unix.Native.Group> {
    [System.CLSCompliantAttribute(false)]
    public uint gr_gid;
    public System.String[] gr_mem;
    public string gr_name;
    public string gr_passwd;
    public Group() { }
    public bool Equals(Mono.Unix.Native.Group value) { return default(bool); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(Mono.Unix.Native.Group lhs, Mono.Unix.Native.Group rhs) { return default(bool); }
    public static bool operator !=(Mono.Unix.Native.Group lhs, Mono.Unix.Native.Group rhs) { return default(bool); }
    public override string ToString() { return default(string); }
  }
  [MapAttribute("struct iovec")]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Iovec {
    public System.IntPtr iov_base;
    [System.CLSCompliantAttribute(false)]
    public ulong iov_len;
  }
  [MapAttribute]
  [System.CLSCompliantAttribute(false)]
  public enum LockfCommand {
    F_LOCK = 1,
    F_TEST = 3,
    F_TLOCK = 2,
    F_ULOCK = 0,
  }
  [MapAttribute]
  [System.CLSCompliantAttribute(false)]
  public enum LockType : short {
    F_RDLCK = (short)0,
    F_UNLCK = (short)2,
    F_WRLCK = (short)1,
  }
  [MapAttribute]
  [System.CLSCompliantAttribute(false)]
  [System.FlagsAttribute]
  public enum MlockallFlags {
    MCL_CURRENT = 1,
    MCL_FUTURE = 2,
  }
  [MapAttribute]
  [System.CLSCompliantAttribute(false)]
  [System.FlagsAttribute]
  public enum MmapFlags {
    MAP_ANON = 32,
    MAP_ANONYMOUS = 32,
    MAP_DENYWRITE = 2048,
    MAP_EXECUTABLE = 4096,
    MAP_FILE = 0,
    MAP_FIXED = 16,
    MAP_GROWSDOWN = 256,
    MAP_LOCKED = 8192,
    MAP_NONBLOCK = 65536,
    MAP_NORESERVE = 16384,
    MAP_POPULATE = 32768,
    MAP_PRIVATE = 2,
    MAP_SHARED = 1,
    MAP_TYPE = 15,
  }
  [MapAttribute]
  [System.CLSCompliantAttribute(false)]
  [System.FlagsAttribute]
  public enum MmapProts {
    PROT_EXEC = 4,
    PROT_GROWSDOWN = 16777216,
    PROT_GROWSUP = 33554432,
    PROT_NONE = 0,
    PROT_READ = 1,
    PROT_WRITE = 2,
  }
  [MapAttribute]
  [System.CLSCompliantAttribute(false)]
  [System.FlagsAttribute]
  public enum MountFlags : ulong {
    ST_APPEND = (ulong)256,
    ST_BIND = (ulong)4096,
    ST_IMMUTABLE = (ulong)512,
    ST_MANDLOCK = (ulong)64,
    ST_NOATIME = (ulong)1024,
    ST_NODEV = (ulong)4,
    ST_NODIRATIME = (ulong)2048,
    ST_NOEXEC = (ulong)8,
    ST_NOSUID = (ulong)2,
    ST_RDONLY = (ulong)1,
    ST_REMOUNT = (ulong)32,
    ST_SYNCHRONOUS = (ulong)16,
    ST_WRITE = (ulong)128,
  }
  [MapAttribute]
  [System.CLSCompliantAttribute(false)]
  [System.FlagsAttribute]
  public enum MremapFlags : ulong {
    MREMAP_MAYMOVE = (ulong)1,
  }
  [MapAttribute]
  [System.CLSCompliantAttribute(false)]
  [System.FlagsAttribute]
  public enum MsyncFlags {
    MS_ASYNC = 1,
    MS_INVALIDATE = 2,
    MS_SYNC = 4,
  }
  [System.CLSCompliantAttribute(false)]
  public sealed partial class NativeConvert {
    internal NativeConvert() { }
    public static readonly System.DateTime LocalUnixEpoch;
    public static readonly System.TimeSpan LocalUtcOffset;
    public static readonly System.DateTime UnixEpoch;
    public static int FromAccessModes(Mono.Unix.Native.AccessModes value) { return default(int); }
    public static int FromAtFlags(Mono.Unix.Native.AtFlags value) { return default(int); }
    public static int FromConfstrName(Mono.Unix.Native.ConfstrName value) { return default(int); }
    public static long FromDateTime(System.DateTime time) { return default(long); }
    public static int FromDirectoryNotifyFlags(Mono.Unix.Native.DirectoryNotifyFlags value) { return default(int); }
    public static uint FromEpollEvents(Mono.Unix.Native.EpollEvents value) { return default(uint); }
    public static int FromEpollFlags(Mono.Unix.Native.EpollFlags value) { return default(int); }
    public static int FromErrno(Mono.Unix.Native.Errno value) { return default(int); }
    public static int FromFcntlCommand(Mono.Unix.Native.FcntlCommand value) { return default(int); }
    public static uint FromFilePermissions(Mono.Unix.Native.FilePermissions value) { return default(uint); }
    public static int FromLockfCommand(Mono.Unix.Native.LockfCommand value) { return default(int); }
    public static short FromLockType(Mono.Unix.Native.LockType value) { return default(short); }
    public static int FromMlockallFlags(Mono.Unix.Native.MlockallFlags value) { return default(int); }
    public static int FromMmapFlags(Mono.Unix.Native.MmapFlags value) { return default(int); }
    public static int FromMmapProts(Mono.Unix.Native.MmapProts value) { return default(int); }
    public static ulong FromMountFlags(Mono.Unix.Native.MountFlags value) { return default(ulong); }
    public static ulong FromMremapFlags(Mono.Unix.Native.MremapFlags value) { return default(ulong); }
    public static int FromMsyncFlags(Mono.Unix.Native.MsyncFlags value) { return default(int); }
    public static Mono.Unix.Native.FilePermissions FromOctalPermissionString(string value) { return default(Mono.Unix.Native.FilePermissions); }
    public static int FromOpenFlags(Mono.Unix.Native.OpenFlags value) { return default(int); }
    public static int FromPathconfName(Mono.Unix.Native.PathconfName value) { return default(int); }
    public static short FromPollEvents(Mono.Unix.Native.PollEvents value) { return default(short); }
    public static int FromPosixFadviseAdvice(Mono.Unix.Native.PosixFadviseAdvice value) { return default(int); }
    public static int FromPosixMadviseAdvice(Mono.Unix.Native.PosixMadviseAdvice value) { return default(int); }
    public static int FromRealTimeSignum(Mono.Unix.Native.RealTimeSignum sig) { return default(int); }
    public static short FromSeekFlags(Mono.Unix.Native.SeekFlags value) { return default(short); }
    public static int FromSignum(Mono.Unix.Native.Signum value) { return default(int); }
    public static int FromSysconfName(Mono.Unix.Native.SysconfName value) { return default(int); }
    public static int FromSyslogFacility(Mono.Unix.Native.SyslogFacility value) { return default(int); }
    public static int FromSyslogLevel(Mono.Unix.Native.SyslogLevel value) { return default(int); }
    public static int FromSyslogOptions(Mono.Unix.Native.SyslogOptions value) { return default(int); }
    public static System.DateTime FromTimeT(long time) { return default(System.DateTime); }
    public static Mono.Unix.Native.FilePermissions FromUnixPermissionString(string value) { return default(Mono.Unix.Native.FilePermissions); }
    public static int FromWaitOptions(Mono.Unix.Native.WaitOptions value) { return default(int); }
    public static int FromXattrFlags(Mono.Unix.Native.XattrFlags value) { return default(int); }
    public static Mono.Unix.Native.AccessModes ToAccessModes(int value) { return default(Mono.Unix.Native.AccessModes); }
    public static Mono.Unix.Native.AtFlags ToAtFlags(int value) { return default(Mono.Unix.Native.AtFlags); }
    public static Mono.Unix.Native.ConfstrName ToConfstrName(int value) { return default(Mono.Unix.Native.ConfstrName); }
    public static System.DateTime ToDateTime(long time) { return default(System.DateTime); }
    public static Mono.Unix.Native.DirectoryNotifyFlags ToDirectoryNotifyFlags(int value) { return default(Mono.Unix.Native.DirectoryNotifyFlags); }
    public static Mono.Unix.Native.EpollEvents ToEpollEvents(uint value) { return default(Mono.Unix.Native.EpollEvents); }
    public static Mono.Unix.Native.EpollFlags ToEpollFlags(int value) { return default(Mono.Unix.Native.EpollFlags); }
    public static Mono.Unix.Native.Errno ToErrno(int value) { return default(Mono.Unix.Native.Errno); }
    public static Mono.Unix.Native.FcntlCommand ToFcntlCommand(int value) { return default(Mono.Unix.Native.FcntlCommand); }
    public static Mono.Unix.Native.FilePermissions ToFilePermissions(uint value) { return default(Mono.Unix.Native.FilePermissions); }
    public static string ToFopenMode(System.IO.FileAccess access) { return default(string); }
    public static string ToFopenMode(System.IO.FileMode mode) { return default(string); }
    public static string ToFopenMode(System.IO.FileMode mode, System.IO.FileAccess access) { return default(string); }
    public static Mono.Unix.Native.LockfCommand ToLockfCommand(int value) { return default(Mono.Unix.Native.LockfCommand); }
    public static Mono.Unix.Native.LockType ToLockType(short value) { return default(Mono.Unix.Native.LockType); }
    public static Mono.Unix.Native.MlockallFlags ToMlockallFlags(int value) { return default(Mono.Unix.Native.MlockallFlags); }
    public static Mono.Unix.Native.MmapFlags ToMmapFlags(int value) { return default(Mono.Unix.Native.MmapFlags); }
    public static Mono.Unix.Native.MmapProts ToMmapProts(int value) { return default(Mono.Unix.Native.MmapProts); }
    public static Mono.Unix.Native.MountFlags ToMountFlags(ulong value) { return default(Mono.Unix.Native.MountFlags); }
    public static Mono.Unix.Native.MremapFlags ToMremapFlags(ulong value) { return default(Mono.Unix.Native.MremapFlags); }
    public static Mono.Unix.Native.MsyncFlags ToMsyncFlags(int value) { return default(Mono.Unix.Native.MsyncFlags); }
    public static string ToOctalPermissionString(Mono.Unix.Native.FilePermissions value) { return default(string); }
    public static Mono.Unix.Native.OpenFlags ToOpenFlags(int value) { return default(Mono.Unix.Native.OpenFlags); }
    public static Mono.Unix.Native.OpenFlags ToOpenFlags(System.IO.FileMode mode, System.IO.FileAccess access) { return default(Mono.Unix.Native.OpenFlags); }
    public static Mono.Unix.Native.PathconfName ToPathconfName(int value) { return default(Mono.Unix.Native.PathconfName); }
    public static Mono.Unix.Native.PollEvents ToPollEvents(short value) { return default(Mono.Unix.Native.PollEvents); }
    public static Mono.Unix.Native.PosixFadviseAdvice ToPosixFadviseAdvice(int value) { return default(Mono.Unix.Native.PosixFadviseAdvice); }
    public static Mono.Unix.Native.PosixMadviseAdvice ToPosixMadviseAdvice(int value) { return default(Mono.Unix.Native.PosixMadviseAdvice); }
    public static Mono.Unix.Native.RealTimeSignum ToRealTimeSignum(int offset) { return default(Mono.Unix.Native.RealTimeSignum); }
    public static Mono.Unix.Native.SeekFlags ToSeekFlags(short value) { return default(Mono.Unix.Native.SeekFlags); }
    public static Mono.Unix.Native.Signum ToSignum(int value) { return default(Mono.Unix.Native.Signum); }
    public static Mono.Unix.Native.SysconfName ToSysconfName(int value) { return default(Mono.Unix.Native.SysconfName); }
    public static Mono.Unix.Native.SyslogFacility ToSyslogFacility(int value) { return default(Mono.Unix.Native.SyslogFacility); }
    public static Mono.Unix.Native.SyslogLevel ToSyslogLevel(int value) { return default(Mono.Unix.Native.SyslogLevel); }
    public static Mono.Unix.Native.SyslogOptions ToSyslogOptions(int value) { return default(Mono.Unix.Native.SyslogOptions); }
    public static long ToTimeT(System.DateTime time) { return default(long); }
    public static string ToUnixPermissionString(Mono.Unix.Native.FilePermissions value) { return default(string); }
    public static Mono.Unix.Native.WaitOptions ToWaitOptions(int value) { return default(Mono.Unix.Native.WaitOptions); }
    public static Mono.Unix.Native.XattrFlags ToXattrFlags(int value) { return default(Mono.Unix.Native.XattrFlags); }
    public static bool TryCopy(ref Mono.Unix.Native.Flock source, System.IntPtr destination) { return default(bool); }
    public static bool TryCopy(ref Mono.Unix.Native.Iovec source, System.IntPtr destination) { return default(bool); }
    public static bool TryCopy(ref Mono.Unix.Native.Pollfd source, System.IntPtr destination) { return default(bool); }
    public static bool TryCopy(ref Mono.Unix.Native.Stat source, System.IntPtr destination) { return default(bool); }
    public static bool TryCopy(ref Mono.Unix.Native.Statvfs source, System.IntPtr destination) { return default(bool); }
    public static bool TryCopy(ref Mono.Unix.Native.Timespec source, System.IntPtr destination) { return default(bool); }
    public static bool TryCopy(ref Mono.Unix.Native.Timeval source, System.IntPtr destination) { return default(bool); }
    public static bool TryCopy(ref Mono.Unix.Native.Timezone source, System.IntPtr destination) { return default(bool); }
    public static bool TryCopy(ref Mono.Unix.Native.Utimbuf source, System.IntPtr destination) { return default(bool); }
    public static bool TryCopy(System.IntPtr source, out Mono.Unix.Native.Flock destination) { destination = default(Mono.Unix.Native.Flock); return default(bool); }
    public static bool TryCopy(System.IntPtr source, out Mono.Unix.Native.Iovec destination) { destination = default(Mono.Unix.Native.Iovec); return default(bool); }
    public static bool TryCopy(System.IntPtr source, out Mono.Unix.Native.Pollfd destination) { destination = default(Mono.Unix.Native.Pollfd); return default(bool); }
    public static bool TryCopy(System.IntPtr source, out Mono.Unix.Native.Stat destination) { destination = default(Mono.Unix.Native.Stat); return default(bool); }
    public static bool TryCopy(System.IntPtr source, out Mono.Unix.Native.Statvfs destination) { destination = default(Mono.Unix.Native.Statvfs); return default(bool); }
    public static bool TryCopy(System.IntPtr source, out Mono.Unix.Native.Timespec destination) { destination = default(Mono.Unix.Native.Timespec); return default(bool); }
    public static bool TryCopy(System.IntPtr source, out Mono.Unix.Native.Timeval destination) { destination = default(Mono.Unix.Native.Timeval); return default(bool); }
    public static bool TryCopy(System.IntPtr source, out Mono.Unix.Native.Timezone destination) { destination = default(Mono.Unix.Native.Timezone); return default(bool); }
    public static bool TryCopy(System.IntPtr source, out Mono.Unix.Native.Utimbuf destination) { destination = default(Mono.Unix.Native.Utimbuf); return default(bool); }
    public static bool TryFromAccessModes(Mono.Unix.Native.AccessModes value, out int rval) { rval = default(int); return default(bool); }
    public static bool TryFromAtFlags(Mono.Unix.Native.AtFlags value, out int rval) { rval = default(int); return default(bool); }
    public static bool TryFromConfstrName(Mono.Unix.Native.ConfstrName value, out int rval) { rval = default(int); return default(bool); }
    public static bool TryFromDirectoryNotifyFlags(Mono.Unix.Native.DirectoryNotifyFlags value, out int rval) { rval = default(int); return default(bool); }
    public static bool TryFromEpollEvents(Mono.Unix.Native.EpollEvents value, out uint rval) { rval = default(uint); return default(bool); }
    public static bool TryFromEpollFlags(Mono.Unix.Native.EpollFlags value, out int rval) { rval = default(int); return default(bool); }
    public static bool TryFromErrno(Mono.Unix.Native.Errno value, out int rval) { rval = default(int); return default(bool); }
    public static bool TryFromFcntlCommand(Mono.Unix.Native.FcntlCommand value, out int rval) { rval = default(int); return default(bool); }
    public static bool TryFromFilePermissions(Mono.Unix.Native.FilePermissions value, out uint rval) { rval = default(uint); return default(bool); }
    public static bool TryFromLockfCommand(Mono.Unix.Native.LockfCommand value, out int rval) { rval = default(int); return default(bool); }
    public static bool TryFromLockType(Mono.Unix.Native.LockType value, out short rval) { rval = default(short); return default(bool); }
    public static bool TryFromMlockallFlags(Mono.Unix.Native.MlockallFlags value, out int rval) { rval = default(int); return default(bool); }
    public static bool TryFromMmapFlags(Mono.Unix.Native.MmapFlags value, out int rval) { rval = default(int); return default(bool); }
    public static bool TryFromMmapProts(Mono.Unix.Native.MmapProts value, out int rval) { rval = default(int); return default(bool); }
    public static bool TryFromMountFlags(Mono.Unix.Native.MountFlags value, out ulong rval) { rval = default(ulong); return default(bool); }
    public static bool TryFromMremapFlags(Mono.Unix.Native.MremapFlags value, out ulong rval) { rval = default(ulong); return default(bool); }
    public static bool TryFromMsyncFlags(Mono.Unix.Native.MsyncFlags value, out int rval) { rval = default(int); return default(bool); }
    public static bool TryFromOpenFlags(Mono.Unix.Native.OpenFlags value, out int rval) { rval = default(int); return default(bool); }
    public static bool TryFromPathconfName(Mono.Unix.Native.PathconfName value, out int rval) { rval = default(int); return default(bool); }
    public static bool TryFromPollEvents(Mono.Unix.Native.PollEvents value, out short rval) { rval = default(short); return default(bool); }
    public static bool TryFromPosixFadviseAdvice(Mono.Unix.Native.PosixFadviseAdvice value, out int rval) { rval = default(int); return default(bool); }
    public static bool TryFromPosixMadviseAdvice(Mono.Unix.Native.PosixMadviseAdvice value, out int rval) { rval = default(int); return default(bool); }
    public static bool TryFromSeekFlags(Mono.Unix.Native.SeekFlags value, out short rval) { rval = default(short); return default(bool); }
    public static bool TryFromSignum(Mono.Unix.Native.Signum value, out int rval) { rval = default(int); return default(bool); }
    public static bool TryFromSysconfName(Mono.Unix.Native.SysconfName value, out int rval) { rval = default(int); return default(bool); }
    public static bool TryFromSyslogFacility(Mono.Unix.Native.SyslogFacility value, out int rval) { rval = default(int); return default(bool); }
    public static bool TryFromSyslogLevel(Mono.Unix.Native.SyslogLevel value, out int rval) { rval = default(int); return default(bool); }
    public static bool TryFromSyslogOptions(Mono.Unix.Native.SyslogOptions value, out int rval) { rval = default(int); return default(bool); }
    public static bool TryFromWaitOptions(Mono.Unix.Native.WaitOptions value, out int rval) { rval = default(int); return default(bool); }
    public static bool TryFromXattrFlags(Mono.Unix.Native.XattrFlags value, out int rval) { rval = default(int); return default(bool); }
    public static bool TryToAccessModes(int value, out Mono.Unix.Native.AccessModes rval) { rval = default(Mono.Unix.Native.AccessModes); return default(bool); }
    public static bool TryToAtFlags(int value, out Mono.Unix.Native.AtFlags rval) { rval = default(Mono.Unix.Native.AtFlags); return default(bool); }
    public static bool TryToConfstrName(int value, out Mono.Unix.Native.ConfstrName rval) { rval = default(Mono.Unix.Native.ConfstrName); return default(bool); }
    public static bool TryToDirectoryNotifyFlags(int value, out Mono.Unix.Native.DirectoryNotifyFlags rval) { rval = default(Mono.Unix.Native.DirectoryNotifyFlags); return default(bool); }
    public static bool TryToEpollEvents(uint value, out Mono.Unix.Native.EpollEvents rval) { rval = default(Mono.Unix.Native.EpollEvents); return default(bool); }
    public static bool TryToEpollFlags(int value, out Mono.Unix.Native.EpollFlags rval) { rval = default(Mono.Unix.Native.EpollFlags); return default(bool); }
    public static bool TryToErrno(int value, out Mono.Unix.Native.Errno rval) { rval = default(Mono.Unix.Native.Errno); return default(bool); }
    public static bool TryToFcntlCommand(int value, out Mono.Unix.Native.FcntlCommand rval) { rval = default(Mono.Unix.Native.FcntlCommand); return default(bool); }
    public static bool TryToFilePermissions(uint value, out Mono.Unix.Native.FilePermissions rval) { rval = default(Mono.Unix.Native.FilePermissions); return default(bool); }
    public static bool TryToLockfCommand(int value, out Mono.Unix.Native.LockfCommand rval) { rval = default(Mono.Unix.Native.LockfCommand); return default(bool); }
    public static bool TryToLockType(short value, out Mono.Unix.Native.LockType rval) { rval = default(Mono.Unix.Native.LockType); return default(bool); }
    public static bool TryToMlockallFlags(int value, out Mono.Unix.Native.MlockallFlags rval) { rval = default(Mono.Unix.Native.MlockallFlags); return default(bool); }
    public static bool TryToMmapFlags(int value, out Mono.Unix.Native.MmapFlags rval) { rval = default(Mono.Unix.Native.MmapFlags); return default(bool); }
    public static bool TryToMmapProts(int value, out Mono.Unix.Native.MmapProts rval) { rval = default(Mono.Unix.Native.MmapProts); return default(bool); }
    public static bool TryToMountFlags(ulong value, out Mono.Unix.Native.MountFlags rval) { rval = default(Mono.Unix.Native.MountFlags); return default(bool); }
    public static bool TryToMremapFlags(ulong value, out Mono.Unix.Native.MremapFlags rval) { rval = default(Mono.Unix.Native.MremapFlags); return default(bool); }
    public static bool TryToMsyncFlags(int value, out Mono.Unix.Native.MsyncFlags rval) { rval = default(Mono.Unix.Native.MsyncFlags); return default(bool); }
    public static bool TryToOpenFlags(int value, out Mono.Unix.Native.OpenFlags rval) { rval = default(Mono.Unix.Native.OpenFlags); return default(bool); }
    public static bool TryToPathconfName(int value, out Mono.Unix.Native.PathconfName rval) { rval = default(Mono.Unix.Native.PathconfName); return default(bool); }
    public static bool TryToPollEvents(short value, out Mono.Unix.Native.PollEvents rval) { rval = default(Mono.Unix.Native.PollEvents); return default(bool); }
    public static bool TryToPosixFadviseAdvice(int value, out Mono.Unix.Native.PosixFadviseAdvice rval) { rval = default(Mono.Unix.Native.PosixFadviseAdvice); return default(bool); }
    public static bool TryToPosixMadviseAdvice(int value, out Mono.Unix.Native.PosixMadviseAdvice rval) { rval = default(Mono.Unix.Native.PosixMadviseAdvice); return default(bool); }
    public static bool TryToSeekFlags(short value, out Mono.Unix.Native.SeekFlags rval) { rval = default(Mono.Unix.Native.SeekFlags); return default(bool); }
    public static bool TryToSignum(int value, out Mono.Unix.Native.Signum rval) { rval = default(Mono.Unix.Native.Signum); return default(bool); }
    public static bool TryToSysconfName(int value, out Mono.Unix.Native.SysconfName rval) { rval = default(Mono.Unix.Native.SysconfName); return default(bool); }
    public static bool TryToSyslogFacility(int value, out Mono.Unix.Native.SyslogFacility rval) { rval = default(Mono.Unix.Native.SyslogFacility); return default(bool); }
    public static bool TryToSyslogLevel(int value, out Mono.Unix.Native.SyslogLevel rval) { rval = default(Mono.Unix.Native.SyslogLevel); return default(bool); }
    public static bool TryToSyslogOptions(int value, out Mono.Unix.Native.SyslogOptions rval) { rval = default(Mono.Unix.Native.SyslogOptions); return default(bool); }
    public static bool TryToWaitOptions(int value, out Mono.Unix.Native.WaitOptions rval) { rval = default(Mono.Unix.Native.WaitOptions); return default(bool); }
    public static bool TryToXattrFlags(int value, out Mono.Unix.Native.XattrFlags rval) { rval = default(Mono.Unix.Native.XattrFlags); return default(bool); }
  }
  [MapAttribute]
  [System.CLSCompliantAttribute(false)]
  [System.FlagsAttribute]
  public enum OpenFlags {
    O_APPEND = 1024,
    O_ASYNC = 8192,
    O_CLOEXEC = 524288,
    O_CREAT = 64,
    O_DIRECT = 16384,
    O_DIRECTORY = 65536,
    O_EXCL = 128,
    O_LARGEFILE = 32768,
    O_NOCTTY = 256,
    O_NOFOLLOW = 131072,
    O_NONBLOCK = 2048,
    O_PATH = 2097152,
    O_RDONLY = 0,
    O_RDWR = 2,
    O_SYNC = 4096,
    O_TRUNC = 512,
    O_WRONLY = 1,
  }
  public sealed partial class Passwd : System.IEquatable<Mono.Unix.Native.Passwd> {
    public string pw_dir;
    public string pw_gecos;
    [System.CLSCompliantAttribute(false)]
    public uint pw_gid;
    public string pw_name;
    public string pw_passwd;
    public string pw_shell;
    [System.CLSCompliantAttribute(false)]
    public uint pw_uid;
    public Passwd() { }
    public bool Equals(Mono.Unix.Native.Passwd value) { return default(bool); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(Mono.Unix.Native.Passwd lhs, Mono.Unix.Native.Passwd rhs) { return default(bool); }
    public static bool operator !=(Mono.Unix.Native.Passwd lhs, Mono.Unix.Native.Passwd rhs) { return default(bool); }
    public override string ToString() { return default(string); }
  }
  [MapAttribute]
  [System.CLSCompliantAttribute(false)]
  public enum PathconfName {
    _PC_2_SYMLINKS = 20,
    _PC_ALLOC_SIZE_MIN = 18,
    _PC_ASYNC_IO = 10,
    _PC_CHOWN_RESTRICTED = 6,
    _PC_FILESIZEBITS = 13,
    _PC_LINK_MAX = 0,
    _PC_MAX_CANON = 1,
    _PC_MAX_INPUT = 2,
    _PC_NAME_MAX = 3,
    _PC_NO_TRUNC = 7,
    _PC_PATH_MAX = 4,
    _PC_PIPE_BUF = 5,
    _PC_PRIO_IO = 11,
    _PC_REC_INCR_XFER_SIZE = 14,
    _PC_REC_MAX_XFER_SIZE = 15,
    _PC_REC_MIN_XFER_SIZE = 16,
    _PC_REC_XFER_ALIGN = 17,
    _PC_SOCK_MAXBUF = 12,
    _PC_SYMLINK_MAX = 19,
    _PC_SYNC_IO = 9,
    _PC_VDISABLE = 8,
  }
  [MapAttribute]
  [System.FlagsAttribute]
  public enum PollEvents : short {
    POLLERR = (short)8,
    POLLHUP = (short)16,
    POLLIN = (short)1,
    POLLNVAL = (short)32,
    POLLOUT = (short)4,
    POLLPRI = (short)2,
    POLLRDBAND = (short)128,
    POLLRDNORM = (short)64,
    POLLWRBAND = (short)512,
    POLLWRNORM = (short)256,
  }
  [MapAttribute("struct pollfd")]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Pollfd : System.IEquatable<Mono.Unix.Native.Pollfd> {
    [System.CLSCompliantAttribute(false)]
    public Mono.Unix.Native.PollEvents events;
    public int fd;
    [System.CLSCompliantAttribute(false)]
    public Mono.Unix.Native.PollEvents revents;
    public bool Equals(Mono.Unix.Native.Pollfd value) { return default(bool); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(Mono.Unix.Native.Pollfd lhs, Mono.Unix.Native.Pollfd rhs) { return default(bool); }
    public static bool operator !=(Mono.Unix.Native.Pollfd lhs, Mono.Unix.Native.Pollfd rhs) { return default(bool); }
  }
  [MapAttribute]
  [System.CLSCompliantAttribute(false)]
  public enum PosixFadviseAdvice {
    POSIX_FADV_DONTNEED = 4,
    POSIX_FADV_NOREUSE = 5,
    POSIX_FADV_NORMAL = 0,
    POSIX_FADV_RANDOM = 1,
    POSIX_FADV_SEQUENTIAL = 2,
    POSIX_FADV_WILLNEED = 3,
  }
  [MapAttribute]
  [System.CLSCompliantAttribute(false)]
  public enum PosixMadviseAdvice {
    POSIX_MADV_DONTNEED = 4,
    POSIX_MADV_NORMAL = 0,
    POSIX_MADV_RANDOM = 1,
    POSIX_MADV_SEQUENTIAL = 2,
    POSIX_MADV_WILLNEED = 3,
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct RealTimeSignum : System.IEquatable<Mono.Unix.Native.RealTimeSignum> {
    public static readonly Mono.Unix.Native.RealTimeSignum MaxValue;
    public static readonly Mono.Unix.Native.RealTimeSignum MinValue;
    public RealTimeSignum(int offset) { throw new System.NotImplementedException(); }
    public int Offset { get { return default(int); } }
    public bool Equals(Mono.Unix.Native.RealTimeSignum value) { return default(bool); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(Mono.Unix.Native.RealTimeSignum lhs, Mono.Unix.Native.RealTimeSignum rhs) { return default(bool); }
    public static bool operator !=(Mono.Unix.Native.RealTimeSignum lhs, Mono.Unix.Native.RealTimeSignum rhs) { return default(bool); }
  }
  [MapAttribute]
  [System.CLSCompliantAttribute(false)]
  public enum SeekFlags : short {
    L_INCR = (short)1,
    L_SET = (short)0,
    L_XTND = (short)2,
    SEEK_CUR = (short)1,
    SEEK_END = (short)2,
    SEEK_SET = (short)0,
  }
  public enum SignalAction {
    Default = 0,
    Error = 2,
    Ignore = 1,
  }
  public delegate void SignalHandler(int signal);
  [MapAttribute]
  public enum Signum {
    SIGABRT = 6,
    SIGALRM = 14,
    SIGBUS = 7,
    SIGCHLD = 17,
    SIGCLD = 17,
    SIGCONT = 18,
    SIGFPE = 8,
    SIGHUP = 1,
    SIGILL = 4,
    SIGINT = 2,
    SIGIO = 29,
    SIGIOT = 6,
    SIGKILL = 9,
    SIGPIPE = 13,
    SIGPOLL = 29,
    SIGPROF = 27,
    SIGPWR = 30,
    SIGQUIT = 3,
    SIGSEGV = 11,
    SIGSTKFLT = 16,
    SIGSTOP = 19,
    SIGSYS = 31,
    SIGTERM = 15,
    SIGTRAP = 5,
    SIGTSTP = 20,
    SIGTTIN = 21,
    SIGTTOU = 22,
    SIGUNUSED = 31,
    SIGURG = 23,
    SIGUSR1 = 10,
    SIGUSR2 = 12,
    SIGVTALRM = 26,
    SIGWINCH = 28,
    SIGXCPU = 24,
    SIGXFSZ = 25,
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Stat : System.IEquatable<Mono.Unix.Native.Stat> {
    [Mono.Unix.Native.time_tAttribute]
    public long st_atime;
    public long st_atime_nsec;
    [Mono.Unix.Native.blksize_tAttribute]
    public long st_blksize;
    [Mono.Unix.Native.blkcnt_tAttribute]
    public long st_blocks;
    [Mono.Unix.Native.time_tAttribute]
    public long st_ctime;
    public long st_ctime_nsec;
    [Mono.Unix.Native.dev_tAttribute]
    [System.CLSCompliantAttribute(false)]
    public ulong st_dev;
    [Mono.Unix.Native.gid_tAttribute]
    [System.CLSCompliantAttribute(false)]
    public uint st_gid;
    [Mono.Unix.Native.ino_tAttribute]
    [System.CLSCompliantAttribute(false)]
    public ulong st_ino;
    [System.CLSCompliantAttribute(false)]
    public Mono.Unix.Native.FilePermissions st_mode;
    [Mono.Unix.Native.time_tAttribute]
    public long st_mtime;
    public long st_mtime_nsec;
    [Mono.Unix.Native.nlink_tAttribute]
    [System.CLSCompliantAttribute(false)]
    public ulong st_nlink;
    [Mono.Unix.Native.dev_tAttribute]
    [System.CLSCompliantAttribute(false)]
    public ulong st_rdev;
    [Mono.Unix.Native.off_tAttribute]
    public long st_size;
    [Mono.Unix.Native.uid_tAttribute]
    [System.CLSCompliantAttribute(false)]
    public uint st_uid;
    public Mono.Unix.Native.Timespec st_atim { get { return default(Mono.Unix.Native.Timespec); } set { } }
    public Mono.Unix.Native.Timespec st_ctim { get { return default(Mono.Unix.Native.Timespec); } set { } }
    public Mono.Unix.Native.Timespec st_mtim { get { return default(Mono.Unix.Native.Timespec); } set { } }
    public bool Equals(Mono.Unix.Native.Stat value) { return default(bool); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(Mono.Unix.Native.Stat lhs, Mono.Unix.Native.Stat rhs) { return default(bool); }
    public static bool operator !=(Mono.Unix.Native.Stat lhs, Mono.Unix.Native.Stat rhs) { return default(bool); }
  }
  [MapAttribute]
  [System.CLSCompliantAttribute(false)]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Statvfs : System.IEquatable<Mono.Unix.Native.Statvfs> {
    [Mono.Unix.Native.fsblkcnt_tAttribute]
    public ulong f_bavail;
    [Mono.Unix.Native.fsblkcnt_tAttribute]
    public ulong f_bfree;
    [Mono.Unix.Native.fsblkcnt_tAttribute]
    public ulong f_blocks;
    public ulong f_bsize;
    [Mono.Unix.Native.fsfilcnt_tAttribute]
    public ulong f_favail;
    [Mono.Unix.Native.fsfilcnt_tAttribute]
    public ulong f_ffree;
    [Mono.Unix.Native.fsfilcnt_tAttribute]
    public ulong f_files;
    public Mono.Unix.Native.MountFlags f_flag;
    public ulong f_frsize;
    public ulong f_fsid;
    public ulong f_namemax;
    public bool Equals(Mono.Unix.Native.Statvfs value) { return default(bool); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(Mono.Unix.Native.Statvfs lhs, Mono.Unix.Native.Statvfs rhs) { return default(bool); }
    public static bool operator !=(Mono.Unix.Native.Statvfs lhs, Mono.Unix.Native.Statvfs rhs) { return default(bool); }
  }
  public partial class Stdlib {
    internal Stdlib() { }
    [System.CLSCompliantAttribute(false)]
    public static readonly int _IOFBF;
    [System.CLSCompliantAttribute(false)]
    public static readonly int _IOLBF;
    [System.CLSCompliantAttribute(false)]
    public static readonly int _IONBF;
    [System.CLSCompliantAttribute(false)]
    public static readonly int BUFSIZ;
    [System.CLSCompliantAttribute(false)]
    public static readonly int EOF;
    [System.CLSCompliantAttribute(false)]
    public static readonly int EXIT_FAILURE;
    [System.CLSCompliantAttribute(false)]
    public static readonly int EXIT_SUCCESS;
    [System.CLSCompliantAttribute(false)]
    public static readonly int FILENAME_MAX;
    [System.CLSCompliantAttribute(false)]
    public static readonly int FOPEN_MAX;
    [System.CLSCompliantAttribute(false)]
    public static readonly int L_tmpnam;
    [System.CLSCompliantAttribute(false)]
    public static readonly int MB_CUR_MAX;
    [System.CLSCompliantAttribute(false)]
    public static readonly int RAND_MAX;
    [System.CLSCompliantAttribute(false)]
    public static readonly Mono.Unix.Native.SignalHandler SIG_DFL;
    [System.CLSCompliantAttribute(false)]
    public static readonly Mono.Unix.Native.SignalHandler SIG_ERR;
    [System.CLSCompliantAttribute(false)]
    public static readonly Mono.Unix.Native.SignalHandler SIG_IGN;
    public static readonly System.IntPtr stderr;
    public static readonly System.IntPtr stdin;
    public static readonly System.IntPtr stdout;
    [System.CLSCompliantAttribute(false)]
    public static readonly int TMP_MAX;
    [System.CLSCompliantAttribute(false)]
    public static void _Exit(int status) { }
    public static void abort() { }
    [System.CLSCompliantAttribute(false)]
    public static System.IntPtr calloc(ulong nmemb, ulong size) { return default(System.IntPtr); }
    public static int clearerr(System.IntPtr stream) { return default(int); }
    public static void exit(int status) { }
    public static int fclose(System.IntPtr stream) { return default(int); }
    public static int feof(System.IntPtr stream) { return default(int); }
    public static int ferror(System.IntPtr stream) { return default(int); }
    public static int fflush(System.IntPtr stream) { return default(int); }
    public static int fgetc(System.IntPtr stream) { return default(int); }
    public static int fgetpos(System.IntPtr stream, Mono.Unix.Native.FilePosition pos) { return default(int); }
    public static System.Text.StringBuilder fgets(System.Text.StringBuilder sb, int size, System.IntPtr stream) { return default(System.Text.StringBuilder); }
    public static System.Text.StringBuilder fgets(System.Text.StringBuilder sb, System.IntPtr stream) { return default(System.Text.StringBuilder); }
    public static System.IntPtr fopen(string path, string mode) { return default(System.IntPtr); }
    public static int fprintf(System.IntPtr stream, string message) { return default(int); }
    [System.ObsoleteAttribute("Not necessarily portable due to cdecl restrictions.\nUse fprintf (IntPtr, string) instead.")]
    public static int fprintf(System.IntPtr stream, string format, params System.Object[] parameters) { return default(int); }
    public static int fputc(int c, System.IntPtr stream) { return default(int); }
    public static int fputs(string s, System.IntPtr stream) { return default(int); }
    [System.CLSCompliantAttribute(false)]
    public static ulong fread(System.Byte[] ptr, System.IntPtr stream) { return default(ulong); }
    [System.CLSCompliantAttribute(false)]
    public static ulong fread(System.Byte[] ptr, ulong size, ulong nmemb, System.IntPtr stream) { return default(ulong); }
    [System.CLSCompliantAttribute(false)]
    public static ulong fread(System.IntPtr ptr, ulong size, ulong nmemb, System.IntPtr stream) { return default(ulong); }
    [System.CLSCompliantAttribute(false)]
    public unsafe static ulong fread(void* ptr, ulong size, ulong nmemb, System.IntPtr stream) { return default(ulong); }
    public static void free(System.IntPtr ptr) { }
    public static System.IntPtr freopen(string path, string mode, System.IntPtr stream) { return default(System.IntPtr); }
    [System.CLSCompliantAttribute(false)]
    public static int fseek(System.IntPtr stream, long offset, Mono.Unix.Native.SeekFlags origin) { return default(int); }
    public static int fsetpos(System.IntPtr stream, Mono.Unix.Native.FilePosition pos) { return default(int); }
    public static long ftell(System.IntPtr stream) { return default(long); }
    [System.CLSCompliantAttribute(false)]
    public static ulong fwrite(System.Byte[] ptr, System.IntPtr stream) { return default(ulong); }
    [System.CLSCompliantAttribute(false)]
    public static ulong fwrite(System.Byte[] ptr, ulong size, ulong nmemb, System.IntPtr stream) { return default(ulong); }
    [System.CLSCompliantAttribute(false)]
    public static ulong fwrite(System.IntPtr ptr, ulong size, ulong nmemb, System.IntPtr stream) { return default(ulong); }
    [System.CLSCompliantAttribute(false)]
    public unsafe static ulong fwrite(void* ptr, ulong size, ulong nmemb, System.IntPtr stream) { return default(ulong); }
    public static int getc(System.IntPtr stream) { return default(int); }
    public static int getchar() { return default(int); }
    public static string getenv(string name) { return default(string); }
    public static Mono.Unix.Native.Errno GetLastError() { return default(Mono.Unix.Native.Errno); }
    [System.CLSCompliantAttribute(false)]
    public static System.IntPtr malloc(ulong size) { return default(System.IntPtr); }
    public static int perror(string s) { return default(int); }
    public static int printf(string message) { return default(int); }
    [System.ObsoleteAttribute("Not necessarily portable due to cdecl restrictions.\nUse printf (string) instead.")]
    public static int printf(string format, params System.Object[] parameters) { return default(int); }
    public static int putc(int c, System.IntPtr stream) { return default(int); }
    public static int putchar(int c) { return default(int); }
    public static int puts(string s) { return default(int); }
    public static int raise(Mono.Unix.Native.RealTimeSignum rts) { return default(int); }
    [System.CLSCompliantAttribute(false)]
    public static int raise(Mono.Unix.Native.Signum sig) { return default(int); }
    public static int rand() { return default(int); }
    [System.CLSCompliantAttribute(false)]
    public static System.IntPtr realloc(System.IntPtr ptr, ulong size) { return default(System.IntPtr); }
    public static int remove(string filename) { return default(int); }
    public static int rename(string oldpath, string newpath) { return default(int); }
    public static int rewind(System.IntPtr stream) { return default(int); }
    [System.CLSCompliantAttribute(false)]
    public unsafe static int setbuf(System.IntPtr stream, byte* buf) { return default(int); }
    public static int setbuf(System.IntPtr stream, System.IntPtr buf) { return default(int); }
    protected static void SetLastError(Mono.Unix.Native.Errno error) { }
    public static int SetSignalAction(Mono.Unix.Native.RealTimeSignum rts, Mono.Unix.Native.SignalAction action) { return default(int); }
    public static int SetSignalAction(Mono.Unix.Native.Signum signal, Mono.Unix.Native.SignalAction action) { return default(int); }
    [System.CLSCompliantAttribute(false)]
    public unsafe static int setvbuf(System.IntPtr stream, byte* buf, int mode, ulong size) { return default(int); }
    [System.CLSCompliantAttribute(false)]
    public static int setvbuf(System.IntPtr stream, System.IntPtr buf, int mode, ulong size) { return default(int); }
    [System.CLSCompliantAttribute(false)]
    [System.ObsoleteAttribute("This is not safe; use Mono.Unix.UnixSignal for signal delivery or SetSignalAction()")]
    public static Mono.Unix.Native.SignalHandler signal(Mono.Unix.Native.Signum signum, Mono.Unix.Native.SignalHandler handler) { return default(Mono.Unix.Native.SignalHandler); }
    public static int snprintf(System.Text.StringBuilder s, string message) { return default(int); }
    [System.CLSCompliantAttribute(false)]
    [System.ObsoleteAttribute("Not necessarily portable due to cdecl restrictions.\nUse snprintf (StringBuilder, string) instead.")]
    public static int snprintf(System.Text.StringBuilder s, string format, params System.Object[] parameters) { return default(int); }
    [System.CLSCompliantAttribute(false)]
    public static int snprintf(System.Text.StringBuilder s, ulong n, string message) { return default(int); }
    [System.CLSCompliantAttribute(false)]
    [System.ObsoleteAttribute("Not necessarily portable due to cdecl restrictions.\nUse snprintf (StringBuilder, string) instead.")]
    public static int snprintf(System.Text.StringBuilder s, ulong n, string format, params System.Object[] parameters) { return default(int); }
    [System.CLSCompliantAttribute(false)]
    public static void srand(uint seed) { }
    [System.CLSCompliantAttribute(false)]
    public static string strerror(Mono.Unix.Native.Errno errnum) { return default(string); }
    [System.CLSCompliantAttribute(false)]
    public static ulong strlen(System.IntPtr s) { return default(ulong); }
    [System.CLSCompliantAttribute(false)]
    public static int system(string @string) { return default(int); }
    public static System.IntPtr tmpfile() { return default(System.IntPtr); }
    [System.ObsoleteAttribute("Syscall.mkstemp() should be preferred.")]
    public static string tmpnam() { return default(string); }
    [System.ObsoleteAttribute("Syscall.mkstemp() should be preferred.")]
    public static string tmpnam(System.Text.StringBuilder s) { return default(string); }
    public static int ungetc(int c, System.IntPtr stream) { return default(int); }
  }
  [System.CLSCompliantAttribute(false)]
  public sealed partial class Syscall : Mono.Unix.Native.Stdlib {
    internal Syscall() { }
    public static readonly int AT_FDCWD;
    public static readonly int L_ctermid;
    public static readonly int L_cuserid;
    public static readonly System.IntPtr MAP_FAILED;
    public static readonly long UTIME_NOW;
    public static readonly long UTIME_OMIT;
    [System.CLSCompliantAttribute(false)]
    public static int _exit(int status) { return default(int); }
    public static int access(string pathname, Mono.Unix.Native.AccessModes mode) { return default(int); }
    public static int acct(string filename) { return default(int); }
    public static uint alarm(uint seconds) { return default(uint); }
    public static int brk(System.IntPtr end_data_segment) { return default(int); }
    public static int chdir(string path) { return default(int); }
    public static int chmod(string path, Mono.Unix.Native.FilePermissions mode) { return default(int); }
    public static int chown(string path, uint owner, uint group) { return default(int); }
    public static int chroot(string path) { return default(int); }
    public static int close(int fd) { return default(int); }
    public static int closedir(System.IntPtr dir) { return default(int); }
    public static int closelog() { return default(int); }
    public static ulong confstr(Mono.Unix.Native.ConfstrName name, System.Text.StringBuilder buf, ulong len) { buf = default(System.Text.StringBuilder); return default(ulong); }
    public static int creat(string pathname, Mono.Unix.Native.FilePermissions mode) { return default(int); }
    [System.ObsoleteAttribute("This is insecure and should not be used", true)]
    public static string crypt(string key, string salt) { return default(string); }
    [System.ObsoleteAttribute("\"Nobody knows precisely what cuserid() does... DO NOT USE cuserid().\n`string' must hold L_cuserid characters.  Use getlogin_r instead.")]
    public static string cuserid(System.Text.StringBuilder @string) { return default(string); }
    public static int dirfd(System.IntPtr dir) { return default(int); }
    public static int dup(int fd) { return default(int); }
    public static int dup2(int fd, int fd2) { return default(int); }
    [System.ObsoleteAttribute("This is insecure and should not be used", true)]
    public static int encrypt(System.Byte[] block, bool decode) { return default(int); }
    public static int endfsent() { return default(int); }
    public static int endgrent() { return default(int); }
    public static int endpwent() { return default(int); }
    public static int endusershell() { return default(int); }
    public static int epoll_create(Mono.Unix.Native.EpollFlags flags) { return default(int); }
    public static int epoll_create(int size) { return default(int); }
    public static int epoll_ctl(int epfd, Mono.Unix.Native.EpollOp op, int fd, ref Mono.Unix.Native.EpollEvent ee) { return default(int); }
    public static int epoll_ctl(int epfd, Mono.Unix.Native.EpollOp op, int fd, Mono.Unix.Native.EpollEvents events) { return default(int); }
    public static int epoll_wait(int epfd, Mono.Unix.Native.EpollEvent[] events, int max_events, int timeout) { return default(int); }
    public static int execv(string path, System.String[] argv) { return default(int); }
    public static int execve(string path, System.String[] argv, System.String[] envp) { return default(int); }
    public static int execvp(string path, System.String[] argv) { return default(int); }
    public static int faccessat(int dirfd, string pathname, Mono.Unix.Native.AccessModes mode, Mono.Unix.Native.AtFlags flags) { return default(int); }
    public static int fchdir(int fd) { return default(int); }
    public static int fchmod(int filedes, Mono.Unix.Native.FilePermissions mode) { return default(int); }
    public static int fchmodat(int dirfd, string pathname, Mono.Unix.Native.FilePermissions mode, Mono.Unix.Native.AtFlags flags) { return default(int); }
    public static int fchown(int fd, uint owner, uint group) { return default(int); }
    public static int fchownat(int dirfd, string pathname, uint owner, uint group, Mono.Unix.Native.AtFlags flags) { return default(int); }
    public static int fcntl(int fd, Mono.Unix.Native.FcntlCommand cmd) { return default(int); }
    public static int fcntl(int fd, Mono.Unix.Native.FcntlCommand cmd, Mono.Unix.Native.DirectoryNotifyFlags arg) { return default(int); }
    public static int fcntl(int fd, Mono.Unix.Native.FcntlCommand cmd, ref Mono.Unix.Native.Flock @lock) { return default(int); }
    public static int fcntl(int fd, Mono.Unix.Native.FcntlCommand cmd, long arg) { return default(int); }
    public static int fdatasync(int fd) { return default(int); }
    public static System.IntPtr fdopendir(int fd) { return default(System.IntPtr); }
    public static int fexecve(int fd, System.String[] argv, System.String[] envp) { return default(int); }
    public static Mono.Unix.Native.Group fgetgrent(System.IntPtr stream) { return default(Mono.Unix.Native.Group); }
    public static Mono.Unix.Native.Passwd fgetpwent(System.IntPtr stream) { return default(Mono.Unix.Native.Passwd); }
    public static long fgetxattr(int fd, string name, System.Byte[] value) { return default(long); }
    public static long fgetxattr(int fd, string name, System.Byte[] value, ulong size) { return default(long); }
    public static long fgetxattr(int fd, string name, out System.Byte[] value) { value = default(System.Byte[]); return default(long); }
    public static long flistxattr(int fd, System.Byte[] list, ulong size) { return default(long); }
    public static long flistxattr(int fd, out System.String[] values) { values = default(System.String[]); return default(long); }
    public static long flistxattr(int fd, System.Text.Encoding encoding, out System.String[] values) { values = default(System.String[]); return default(long); }
    public static long fpathconf(int filedes, Mono.Unix.Native.PathconfName name) { return default(long); }
    public static long fpathconf(int filedes, Mono.Unix.Native.PathconfName name, Mono.Unix.Native.Errno defaultError) { return default(long); }
    public static int fremovexattr(int fd, string name) { return default(int); }
    public static int fsetxattr(int fd, string name, System.Byte[] value) { return default(int); }
    public static int fsetxattr(int fd, string name, System.Byte[] value, Mono.Unix.Native.XattrFlags flags) { return default(int); }
    public static int fsetxattr(int fd, string name, System.Byte[] value, ulong size) { return default(int); }
    public static int fsetxattr(int fd, string name, System.Byte[] value, ulong size, Mono.Unix.Native.XattrFlags flags) { return default(int); }
    public static int fstat(int filedes, out Mono.Unix.Native.Stat buf) { buf = default(Mono.Unix.Native.Stat); return default(int); }
    public static int fstatat(int dirfd, string file_name, out Mono.Unix.Native.Stat buf, Mono.Unix.Native.AtFlags flags) { buf = default(Mono.Unix.Native.Stat); return default(int); }
    public static int fstatvfs(int fd, out Mono.Unix.Native.Statvfs buf) { buf = default(Mono.Unix.Native.Statvfs); return default(int); }
    public static int fsync(int fd) { return default(int); }
    public static int ftruncate(int fd, long length) { return default(int); }
    public static int futimens(int fd, Mono.Unix.Native.Timespec[] times) { return default(int); }
    public static int futimes(int fd, Mono.Unix.Native.Timeval[] tvp) { return default(int); }
    public static System.Text.StringBuilder getcwd(System.Text.StringBuilder buf) { return default(System.Text.StringBuilder); }
    public static System.IntPtr getcwd(System.Text.StringBuilder buf, ulong size) { buf = default(System.Text.StringBuilder); return default(System.IntPtr); }
    public static int getdomainname(System.Text.StringBuilder name) { return default(int); }
    public static int getdomainname(System.Text.StringBuilder name, ulong len) { name = default(System.Text.StringBuilder); return default(int); }
    public static int getdtablesize() { return default(int); }
    public static uint getegid() { return default(uint); }
    public static uint geteuid() { return default(uint); }
    public static Mono.Unix.Native.Fstab getfsent() { return default(Mono.Unix.Native.Fstab); }
    public static Mono.Unix.Native.Fstab getfsfile(string mount_point) { return default(Mono.Unix.Native.Fstab); }
    public static Mono.Unix.Native.Fstab getfsspec(string special_file) { return default(Mono.Unix.Native.Fstab); }
    public static uint getgid() { return default(uint); }
    public static Mono.Unix.Native.Group getgrent() { return default(Mono.Unix.Native.Group); }
    public static Mono.Unix.Native.Group getgrgid(uint uid) { return default(Mono.Unix.Native.Group); }
    public static int getgrgid_r(uint uid, Mono.Unix.Native.Group grbuf, out Mono.Unix.Native.Group grbufp) { grbufp = default(Mono.Unix.Native.Group); return default(int); }
    public static Mono.Unix.Native.Group getgrnam(string name) { return default(Mono.Unix.Native.Group); }
    public static int getgrnam_r(string name, Mono.Unix.Native.Group grbuf, out Mono.Unix.Native.Group grbufp) { grbufp = default(Mono.Unix.Native.Group); return default(int); }
    public static Mono.Unix.Native.Group[] getgrouplist(Mono.Unix.Native.Passwd user) { return default(Mono.Unix.Native.Group[]); }
    public static Mono.Unix.Native.Group[] getgrouplist(string username) { return default(Mono.Unix.Native.Group[]); }
    public static int getgroups(int size, System.UInt32[] list) { return default(int); }
    public static int getgroups(System.UInt32[] list) { return default(int); }
    public static long gethostid() { return default(long); }
    public static int gethostname(System.Text.StringBuilder name) { return default(int); }
    public static int gethostname(System.Text.StringBuilder name, ulong len) { name = default(System.Text.StringBuilder); return default(int); }
    public static string getlogin() { return default(string); }
    public static int getlogin_r(System.Text.StringBuilder name) { return default(int); }
    public static int getlogin_r(System.Text.StringBuilder name, ulong bufsize) { name = default(System.Text.StringBuilder); return default(int); }
    [System.ObsoleteAttribute("Dropped in POSIX 1003.1-2001.  Use Syscall.sysconf (SysconfName._SC_PAGESIZE).")]
    public static int getpagesize() { return default(int); }
    public static int getpgid(int pid) { return default(int); }
    public static int getpgrp() { return default(int); }
    public static int getpid() { return default(int); }
    public static int getppid() { return default(int); }
    public static Mono.Unix.Native.Passwd getpwent() { return default(Mono.Unix.Native.Passwd); }
    public static Mono.Unix.Native.Passwd getpwnam(string name) { return default(Mono.Unix.Native.Passwd); }
    public static int getpwnam_r(string name, Mono.Unix.Native.Passwd pwbuf, out Mono.Unix.Native.Passwd pwbufp) { pwbufp = default(Mono.Unix.Native.Passwd); return default(int); }
    public static Mono.Unix.Native.Passwd getpwuid(uint uid) { return default(Mono.Unix.Native.Passwd); }
    public static int getpwuid_r(uint uid, Mono.Unix.Native.Passwd pwbuf, out Mono.Unix.Native.Passwd pwbufp) { pwbufp = default(Mono.Unix.Native.Passwd); return default(int); }
    public static int getresgid(out uint rgid, out uint egid, out uint sgid) { rgid = default(uint); egid = default(uint); sgid = default(uint); return default(int); }
    public static int getresuid(out uint ruid, out uint euid, out uint suid) { ruid = default(uint); euid = default(uint); suid = default(uint); return default(int); }
    public static int getsid(int pid) { return default(int); }
    public static int gettimeofday(out Mono.Unix.Native.Timeval tv) { tv = default(Mono.Unix.Native.Timeval); return default(int); }
    public static int gettimeofday(out Mono.Unix.Native.Timeval tv, out Mono.Unix.Native.Timezone tz) { tv = default(Mono.Unix.Native.Timeval); tz = default(Mono.Unix.Native.Timezone); return default(int); }
    public static int gettimeofday(out Mono.Unix.Native.Timezone tz) { tz = default(Mono.Unix.Native.Timezone); return default(int); }
    public static uint getuid() { return default(uint); }
    public static string getusershell() { return default(string); }
    public static long getxattr(string path, string name, System.Byte[] value) { return default(long); }
    public static long getxattr(string path, string name, System.Byte[] value, ulong size) { return default(long); }
    public static long getxattr(string path, string name, out System.Byte[] value) { value = default(System.Byte[]); return default(long); }
    public static bool isatty(int fd) { return default(bool); }
    public static int kill(int pid, Mono.Unix.Native.Signum sig) { return default(int); }
    public static int lchown(string path, uint owner, uint group) { return default(int); }
    public static long lgetxattr(string path, string name, System.Byte[] value) { return default(long); }
    public static long lgetxattr(string path, string name, System.Byte[] value, ulong size) { return default(long); }
    public static long lgetxattr(string path, string name, out System.Byte[] value) { value = default(System.Byte[]); return default(long); }
    public static int link(string oldpath, string newpath) { return default(int); }
    public static int linkat(int olddirfd, string oldpath, int newdirfd, string newpath, Mono.Unix.Native.AtFlags flags) { return default(int); }
    public static long listxattr(string path, System.Byte[] list, ulong size) { return default(long); }
    public static long listxattr(string path, out System.String[] values) { values = default(System.String[]); return default(long); }
    public static long listxattr(string path, System.Text.Encoding encoding, out System.String[] values) { values = default(System.String[]); return default(long); }
    public static long llistxattr(string path, System.Byte[] list, ulong size) { return default(long); }
    public static long llistxattr(string path, out System.String[] values) { values = default(System.String[]); return default(long); }
    public static long llistxattr(string path, System.Text.Encoding encoding, out System.String[] values) { values = default(System.String[]); return default(long); }
    public static int lockf(int fd, Mono.Unix.Native.LockfCommand cmd, long len) { return default(int); }
    public static int lremovexattr(string path, string name) { return default(int); }
    public static long lseek(int fd, long offset, Mono.Unix.Native.SeekFlags whence) { return default(long); }
    public static int lsetxattr(string path, string name, System.Byte[] value) { return default(int); }
    public static int lsetxattr(string path, string name, System.Byte[] value, Mono.Unix.Native.XattrFlags flags) { return default(int); }
    public static int lsetxattr(string path, string name, System.Byte[] value, ulong size) { return default(int); }
    public static int lsetxattr(string path, string name, System.Byte[] value, ulong size, Mono.Unix.Native.XattrFlags flags) { return default(int); }
    public static int lstat(string file_name, out Mono.Unix.Native.Stat buf) { buf = default(Mono.Unix.Native.Stat); return default(int); }
    public static int lutimes(string filename, Mono.Unix.Native.Timeval[] tvp) { return default(int); }
    public static int mincore(System.IntPtr start, ulong length, System.Byte[] vec) { return default(int); }
    public static int mkdir(string oldpath, Mono.Unix.Native.FilePermissions mode) { return default(int); }
    public static int mkdirat(int dirfd, string oldpath, Mono.Unix.Native.FilePermissions mode) { return default(int); }
    public static System.Text.StringBuilder mkdtemp(System.Text.StringBuilder template) { return default(System.Text.StringBuilder); }
    public static int mkfifo(string pathname, Mono.Unix.Native.FilePermissions mode) { return default(int); }
    public static int mkfifoat(int dirfd, string pathname, Mono.Unix.Native.FilePermissions mode) { return default(int); }
    public static int mknod(string pathname, Mono.Unix.Native.FilePermissions mode, ulong dev) { return default(int); }
    public static int mknodat(int dirfd, string pathname, Mono.Unix.Native.FilePermissions mode, ulong dev) { return default(int); }
    public static int mkstemp(System.Text.StringBuilder template) { return default(int); }
    public static int mlock(System.IntPtr start, ulong len) { return default(int); }
    public static int mlockall(Mono.Unix.Native.MlockallFlags flags) { return default(int); }
    public static System.IntPtr mmap(System.IntPtr start, ulong length, Mono.Unix.Native.MmapProts prot, Mono.Unix.Native.MmapFlags flags, int fd, long offset) { return default(System.IntPtr); }
    public static int mprotect(System.IntPtr start, ulong len, Mono.Unix.Native.MmapProts prot) { return default(int); }
    public static System.IntPtr mremap(System.IntPtr old_address, ulong old_size, ulong new_size, Mono.Unix.Native.MremapFlags flags) { return default(System.IntPtr); }
    public static int msync(System.IntPtr start, ulong len, Mono.Unix.Native.MsyncFlags flags) { return default(int); }
    public static int munlock(System.IntPtr start, ulong len) { return default(int); }
    public static int munlockall() { return default(int); }
    public static int munmap(System.IntPtr start, ulong length) { return default(int); }
    public static int nanosleep(ref Mono.Unix.Native.Timespec req, ref Mono.Unix.Native.Timespec rem) { return default(int); }
    public static int nice(int inc) { return default(int); }
    public static int open(string pathname, Mono.Unix.Native.OpenFlags flags) { return default(int); }
    public static int open(string pathname, Mono.Unix.Native.OpenFlags flags, Mono.Unix.Native.FilePermissions mode) { return default(int); }
    public static int openat(int dirfd, string pathname, Mono.Unix.Native.OpenFlags flags) { return default(int); }
    public static int openat(int dirfd, string pathname, Mono.Unix.Native.OpenFlags flags, Mono.Unix.Native.FilePermissions mode) { return default(int); }
    public static System.IntPtr opendir(string name) { return default(System.IntPtr); }
    public static int openlog(System.IntPtr ident, Mono.Unix.Native.SyslogOptions option, Mono.Unix.Native.SyslogFacility defaultFacility) { return default(int); }
    public static long pathconf(string path, Mono.Unix.Native.PathconfName name) { return default(long); }
    public static long pathconf(string path, Mono.Unix.Native.PathconfName name, Mono.Unix.Native.Errno defaultError) { return default(long); }
    public static int pause() { return default(int); }
    public static int pipe(out int reading, out int writing) { reading = default(int); writing = default(int); return default(int); }
    public static int pipe(System.Int32[] filedes) { return default(int); }
    public static int poll(Mono.Unix.Native.Pollfd[] fds, int timeout) { return default(int); }
    public static int poll(Mono.Unix.Native.Pollfd[] fds, uint nfds, int timeout) { return default(int); }
    public static int posix_fadvise(int fd, long offset, long len, Mono.Unix.Native.PosixFadviseAdvice advice) { return default(int); }
    public static int posix_fallocate(int fd, long offset, ulong len) { return default(int); }
    public static int posix_madvise(System.IntPtr addr, ulong len, Mono.Unix.Native.PosixMadviseAdvice advice) { return default(int); }
    public static long pread(int fd, System.IntPtr buf, ulong count, long offset) { return default(long); }
    public unsafe static long pread(int fd, void* buf, ulong count, long offset) { return default(long); }
    public static long preadv(int fd, Mono.Unix.Native.Iovec[] iov, long offset) { return default(long); }
    public static int psignal(Mono.Unix.Native.Signum sig, string s) { return default(int); }
    public static long pwrite(int fd, System.IntPtr buf, ulong count, long offset) { return default(long); }
    public unsafe static long pwrite(int fd, void* buf, ulong count, long offset) { return default(long); }
    public static long pwritev(int fd, Mono.Unix.Native.Iovec[] iov, long offset) { return default(long); }
    public static long read(int fd, System.IntPtr buf, ulong count) { return default(long); }
    public unsafe static long read(int fd, void* buf, ulong count) { return default(long); }
    public static Mono.Unix.Native.Dirent readdir(System.IntPtr dir) { return default(Mono.Unix.Native.Dirent); }
    public static int readdir_r(System.IntPtr dirp, Mono.Unix.Native.Dirent entry, out System.IntPtr result) { result = default(System.IntPtr); return default(int); }
    public static long readlink(string path, System.Byte[] buf) { return default(long); }
    public static int readlink(string path, System.Text.StringBuilder buf) { buf = default(System.Text.StringBuilder); return default(int); }
    public static int readlink(string path, System.Text.StringBuilder buf, ulong bufsiz) { buf = default(System.Text.StringBuilder); return default(int); }
    public static long readlinkat(int dirfd, string pathname, System.Byte[] buf) { return default(long); }
    public static int readlinkat(int dirfd, string pathname, System.Text.StringBuilder buf) { buf = default(System.Text.StringBuilder); return default(int); }
    public static int readlinkat(int dirfd, string pathname, System.Text.StringBuilder buf, ulong bufsiz) { buf = default(System.Text.StringBuilder); return default(int); }
    public static long readv(int fd, Mono.Unix.Native.Iovec[] iov) { return default(long); }
    public static int remap_file_pages(System.IntPtr start, ulong size, Mono.Unix.Native.MmapProts prot, long pgoff, Mono.Unix.Native.MmapFlags flags) { return default(int); }
    public static int removexattr(string path, string name) { return default(int); }
    public static int renameat(int olddirfd, string oldpath, int newdirfd, string newpath) { return default(int); }
    public static int revoke(string file) { return default(int); }
    public static int rewinddir(System.IntPtr dir) { return default(int); }
    public static int rmdir(string pathname) { return default(int); }
    public static System.IntPtr sbrk(System.IntPtr increment) { return default(System.IntPtr); }
    public static int seekdir(System.IntPtr dir, long offset) { return default(int); }
    public static long sendfile(int out_fd, int in_fd, ref long offset, ulong count) { return default(long); }
    public static int setdomainname(string name) { return default(int); }
    public static int setdomainname(string name, ulong len) { return default(int); }
    public static int setegid(uint uid) { return default(int); }
    public static int seteuid(uint euid) { return default(int); }
    public static int setfsent() { return default(int); }
    public static int setgid(uint gid) { return default(int); }
    public static int setgrent() { return default(int); }
    public static int setgroups(System.UInt32[] list) { return default(int); }
    public static int setgroups(ulong size, System.UInt32[] list) { return default(int); }
    public static int sethostid(long hostid) { return default(int); }
    public static int sethostname(string name) { return default(int); }
    public static int sethostname(string name, ulong len) { return default(int); }
    [System.ObsoleteAttribute("This is insecure and should not be used", true)]
    public static int setkey(string key) { return default(int); }
    public static int setlogin(string name) { return default(int); }
    public static int setlogmask(Mono.Unix.Native.SyslogLevel mask) { return default(int); }
    public static int setpgid(int pid, int pgid) { return default(int); }
    public static int setpgrp() { return default(int); }
    public static int setpwent() { return default(int); }
    public static int setregid(uint rgid, uint egid) { return default(int); }
    public static int setresgid(uint rgid, uint egid, uint sgid) { return default(int); }
    public static int setresuid(uint ruid, uint euid, uint suid) { return default(int); }
    public static int setreuid(uint ruid, uint euid) { return default(int); }
    public static int setsid() { return default(int); }
    public static int settimeofday(ref Mono.Unix.Native.Timeval tv) { return default(int); }
    public static int settimeofday(ref Mono.Unix.Native.Timeval tv, ref Mono.Unix.Native.Timezone tz) { return default(int); }
    public static int setuid(uint uid) { return default(int); }
    public static int setusershell() { return default(int); }
    public static int setxattr(string path, string name, System.Byte[] value) { return default(int); }
    public static int setxattr(string path, string name, System.Byte[] value, Mono.Unix.Native.XattrFlags flags) { return default(int); }
    public static int setxattr(string path, string name, System.Byte[] value, ulong size) { return default(int); }
    public static int setxattr(string path, string name, System.Byte[] value, ulong size, Mono.Unix.Native.XattrFlags flags) { return default(int); }
    public static uint sleep(uint seconds) { return default(uint); }
    public static int stat(string file_name, out Mono.Unix.Native.Stat buf) { buf = default(Mono.Unix.Native.Stat); return default(int); }
    public static int statvfs(string path, out Mono.Unix.Native.Statvfs buf) { buf = default(Mono.Unix.Native.Statvfs); return default(int); }
    public static int stime(ref long t) { return default(int); }
    public static int strerror_r(Mono.Unix.Native.Errno errnum, System.Text.StringBuilder buf) { return default(int); }
    public static int strerror_r(Mono.Unix.Native.Errno errnum, System.Text.StringBuilder buf, ulong n) { return default(int); }
    public static string strsignal(Mono.Unix.Native.Signum sig) { return default(string); }
    public static int swab(System.IntPtr from, System.IntPtr to, long n) { return default(int); }
    public unsafe static void swab(void* from, void* to, long n) { }
    public static int symlink(string oldpath, string newpath) { return default(int); }
    public static int symlinkat(string oldpath, int dirfd, string newpath) { return default(int); }
    public static int sync() { return default(int); }
    public static long sysconf(Mono.Unix.Native.SysconfName name) { return default(long); }
    public static long sysconf(Mono.Unix.Native.SysconfName name, Mono.Unix.Native.Errno defaultError) { return default(long); }
    public static int syslog(Mono.Unix.Native.SyslogFacility facility, Mono.Unix.Native.SyslogLevel level, string message) { return default(int); }
    [System.ObsoleteAttribute("Not necessarily portable due to cdecl restrictions.\nUse syslog(SyslogFacility, SyslogLevel, string) instead.")]
    public static int syslog(Mono.Unix.Native.SyslogFacility facility, Mono.Unix.Native.SyslogLevel level, string format, params System.Object[] parameters) { return default(int); }
    public static int syslog(Mono.Unix.Native.SyslogLevel level, string message) { return default(int); }
    [System.ObsoleteAttribute("Not necessarily portable due to cdecl restrictions.\nUse syslog(SyslogLevel, string) instead.")]
    public static int syslog(Mono.Unix.Native.SyslogLevel level, string format, params System.Object[] parameters) { return default(int); }
    public static int tcgetpgrp(int fd) { return default(int); }
    public static int tcsetpgrp(int fd, int pgrp) { return default(int); }
    public static long telldir(System.IntPtr dir) { return default(long); }
    public static long time(out long t) { t = default(long); return default(long); }
    public static int truncate(string path, long length) { return default(int); }
    public static string ttyname(int fd) { return default(string); }
    public static int ttyname_r(int fd, System.Text.StringBuilder buf) { return default(int); }
    public static int ttyname_r(int fd, System.Text.StringBuilder buf, ulong buflen) { buf = default(System.Text.StringBuilder); return default(int); }
    public static int ttyslot() { return default(int); }
    public static uint ualarm(uint usecs, uint interval) { return default(uint); }
    public static Mono.Unix.Native.FilePermissions umask(Mono.Unix.Native.FilePermissions mask) { return default(Mono.Unix.Native.FilePermissions); }
    public static int uname(out Mono.Unix.Native.Utsname buf) { buf = default(Mono.Unix.Native.Utsname); return default(int); }
    public static int unlink(string pathname) { return default(int); }
    public static int unlinkat(int dirfd, string pathname, Mono.Unix.Native.AtFlags flags) { return default(int); }
    public static int utime(string filename) { return default(int); }
    public static int utime(string filename, ref Mono.Unix.Native.Utimbuf buf) { return default(int); }
    public static int utimensat(int dirfd, string pathname, Mono.Unix.Native.Timespec[] times, Mono.Unix.Native.AtFlags flags) { return default(int); }
    public static int utimes(string filename, Mono.Unix.Native.Timeval[] tvp) { return default(int); }
    public static int vhangup() { return default(int); }
    public static int wait(out int status) { status = default(int); return default(int); }
    public static int waitpid(int pid, out int status, Mono.Unix.Native.WaitOptions options) { status = default(int); return default(int); }
    public static int WEXITSTATUS(int status) { return default(int); }
    public static bool WIFEXITED(int status) { return default(bool); }
    public static bool WIFSIGNALED(int status) { return default(bool); }
    public static bool WIFSTOPPED(int status) { return default(bool); }
    public static long write(int fd, System.IntPtr buf, ulong count) { return default(long); }
    public unsafe static long write(int fd, void* buf, ulong count) { return default(long); }
    public static long writev(int fd, Mono.Unix.Native.Iovec[] iov) { return default(long); }
    public static Mono.Unix.Native.Signum WSTOPSIG(int status) { return default(Mono.Unix.Native.Signum); }
    public static Mono.Unix.Native.Signum WTERMSIG(int status) { return default(Mono.Unix.Native.Signum); }
  }
  [MapAttribute]
  [System.CLSCompliantAttribute(false)]
  public enum SysconfName {
    _SC_2_C_BIND = 47,
    _SC_2_C_DEV = 48,
    _SC_2_C_VERSION = 96,
    _SC_2_CHAR_TERM = 95,
    _SC_2_FORT_DEV = 49,
    _SC_2_FORT_RUN = 50,
    _SC_2_LOCALEDEF = 52,
    _SC_2_PBS = 168,
    _SC_2_PBS_ACCOUNTING = 169,
    _SC_2_PBS_CHECKPOINT = 175,
    _SC_2_PBS_LOCATE = 170,
    _SC_2_PBS_MESSAGE = 171,
    _SC_2_PBS_TRACK = 172,
    _SC_2_SW_DEV = 51,
    _SC_2_UPE = 97,
    _SC_2_VERSION = 46,
    _SC_ADVISORY_INFO = 132,
    _SC_AIO_LISTIO_MAX = 23,
    _SC_AIO_MAX = 24,
    _SC_AIO_PRIO_DELTA_MAX = 25,
    _SC_ARG_MAX = 0,
    _SC_ASYNCHRONOUS_IO = 12,
    _SC_ATEXIT_MAX = 87,
    _SC_AVPHYS_PAGES = 86,
    _SC_BARRIERS = 133,
    _SC_BASE = 134,
    _SC_BC_BASE_MAX = 36,
    _SC_BC_DIM_MAX = 37,
    _SC_BC_SCALE_MAX = 38,
    _SC_BC_STRING_MAX = 39,
    _SC_C_LANG_SUPPORT = 135,
    _SC_C_LANG_SUPPORT_R = 136,
    _SC_CHAR_BIT = 101,
    _SC_CHAR_MAX = 102,
    _SC_CHAR_MIN = 103,
    _SC_CHARCLASS_NAME_MAX = 45,
    _SC_CHILD_MAX = 1,
    _SC_CLK_TCK = 2,
    _SC_CLOCK_SELECTION = 137,
    _SC_COLL_WEIGHTS_MAX = 40,
    _SC_CPUTIME = 138,
    _SC_DELAYTIMER_MAX = 26,
    _SC_DEVICE_IO = 140,
    _SC_DEVICE_SPECIFIC = 141,
    _SC_DEVICE_SPECIFIC_R = 142,
    _SC_EQUIV_CLASS_MAX = 41,
    _SC_EXPR_NEST_MAX = 42,
    _SC_FD_MGMT = 143,
    _SC_FIFO = 144,
    _SC_FILE_ATTRIBUTES = 146,
    _SC_FILE_LOCKING = 147,
    _SC_FILE_SYSTEM = 148,
    _SC_FSYNC = 15,
    _SC_GETGR_R_SIZE_MAX = 69,
    _SC_GETPW_R_SIZE_MAX = 70,
    _SC_HOST_NAME_MAX = 180,
    _SC_INT_MAX = 104,
    _SC_INT_MIN = 105,
    _SC_IOV_MAX = 60,
    _SC_JOB_CONTROL = 7,
    _SC_LEVEL1_DCACHE_ASSOC = 189,
    _SC_LEVEL1_DCACHE_LINESIZE = 190,
    _SC_LEVEL1_DCACHE_SIZE = 188,
    _SC_LEVEL1_ICACHE_ASSOC = 186,
    _SC_LEVEL1_ICACHE_LINESIZE = 187,
    _SC_LEVEL1_ICACHE_SIZE = 185,
    _SC_LEVEL2_CACHE_ASSOC = 192,
    _SC_LEVEL2_CACHE_LINESIZE = 193,
    _SC_LEVEL2_CACHE_SIZE = 191,
    _SC_LEVEL3_CACHE_ASSOC = 195,
    _SC_LEVEL3_CACHE_LINESIZE = 196,
    _SC_LEVEL3_CACHE_SIZE = 194,
    _SC_LEVEL4_CACHE_ASSOC = 198,
    _SC_LEVEL4_CACHE_LINESIZE = 199,
    _SC_LEVEL4_CACHE_SIZE = 197,
    _SC_LINE_MAX = 43,
    _SC_LOGIN_NAME_MAX = 71,
    _SC_LONG_BIT = 106,
    _SC_MAPPED_FILES = 16,
    _SC_MB_LEN_MAX = 108,
    _SC_MEMLOCK = 17,
    _SC_MEMLOCK_RANGE = 18,
    _SC_MEMORY_PROTECTION = 19,
    _SC_MESSAGE_PASSING = 20,
    _SC_MONOTONIC_CLOCK = 149,
    _SC_MQ_OPEN_MAX = 27,
    _SC_MQ_PRIO_MAX = 28,
    _SC_MULTI_PROCESS = 150,
    _SC_NETWORKING = 152,
    _SC_NGROUPS_MAX = 3,
    _SC_NL_ARGMAX = 119,
    _SC_NL_LANGMAX = 120,
    _SC_NL_MSGMAX = 121,
    _SC_NL_NMAX = 122,
    _SC_NL_SETMAX = 123,
    _SC_NL_TEXTMAX = 124,
    _SC_NPROCESSORS_CONF = 83,
    _SC_NPROCESSORS_ONLN = 84,
    _SC_NZERO = 109,
    _SC_OPEN_MAX = 4,
    _SC_PAGESIZE = 30,
    _SC_PASS_MAX = 88,
    _SC_PHYS_PAGES = 85,
    _SC_PII = 53,
    _SC_PII_INTERNET = 56,
    _SC_PII_INTERNET_DGRAM = 62,
    _SC_PII_INTERNET_STREAM = 61,
    _SC_PII_OSI = 57,
    _SC_PII_OSI_CLTS = 64,
    _SC_PII_OSI_COTS = 63,
    _SC_PII_OSI_M = 65,
    _SC_PII_SOCKET = 55,
    _SC_PII_XTI = 54,
    _SC_PIPE = 145,
    _SC_POLL = 58,
    _SC_PRIORITIZED_IO = 13,
    _SC_PRIORITY_SCHEDULING = 10,
    _SC_RE_DUP_MAX = 44,
    _SC_READER_WRITER_LOCKS = 153,
    _SC_REALTIME_SIGNALS = 9,
    _SC_REGEX_VERSION = 156,
    _SC_REGEXP = 155,
    _SC_RTSIG_MAX = 31,
    _SC_SAVED_IDS = 8,
    _SC_SCHAR_MAX = 111,
    _SC_SCHAR_MIN = 112,
    _SC_SELECT = 59,
    _SC_SEM_NSEMS_MAX = 32,
    _SC_SEM_VALUE_MAX = 33,
    _SC_SEMAPHORES = 21,
    _SC_SHARED_MEMORY_OBJECTS = 22,
    _SC_SHELL = 157,
    _SC_SHRT_MAX = 113,
    _SC_SHRT_MIN = 114,
    _SC_SIGNALS = 158,
    _SC_SIGQUEUE_MAX = 34,
    _SC_SINGLE_PROCESS = 151,
    _SC_SPAWN = 159,
    _SC_SPIN_LOCKS = 154,
    _SC_SPORADIC_SERVER = 160,
    _SC_SSIZE_MAX = 110,
    _SC_STREAM_MAX = 5,
    _SC_STREAMS = 174,
    _SC_SYMLOOP_MAX = 173,
    _SC_SYNCHRONIZED_IO = 14,
    _SC_SYSTEM_DATABASE = 162,
    _SC_SYSTEM_DATABASE_R = 163,
    _SC_T_IOV_MAX = 66,
    _SC_THREAD_ATTR_STACKADDR = 77,
    _SC_THREAD_ATTR_STACKSIZE = 78,
    _SC_THREAD_CPUTIME = 139,
    _SC_THREAD_DESTRUCTOR_ITERATIONS = 73,
    _SC_THREAD_KEYS_MAX = 74,
    _SC_THREAD_PRIO_INHERIT = 80,
    _SC_THREAD_PRIO_PROTECT = 81,
    _SC_THREAD_PRIORITY_SCHEDULING = 79,
    _SC_THREAD_PROCESS_SHARED = 82,
    _SC_THREAD_SAFE_FUNCTIONS = 68,
    _SC_THREAD_SPORADIC_SERVER = 161,
    _SC_THREAD_STACK_MIN = 75,
    _SC_THREAD_THREADS_MAX = 76,
    _SC_THREADS = 67,
    _SC_TIMEOUTS = 164,
    _SC_TIMER_MAX = 35,
    _SC_TIMERS = 11,
    _SC_TRACE = 181,
    _SC_TRACE_EVENT_FILTER = 182,
    _SC_TRACE_INHERIT = 183,
    _SC_TRACE_LOG = 184,
    _SC_TTY_NAME_MAX = 72,
    _SC_TYPED_MEMORY_OBJECTS = 165,
    _SC_TZNAME_MAX = 6,
    _SC_UCHAR_MAX = 115,
    _SC_UINT_MAX = 116,
    _SC_UIO_MAXIOV = 60,
    _SC_ULONG_MAX = 117,
    _SC_USER_GROUPS = 166,
    _SC_USER_GROUPS_R = 167,
    _SC_USHRT_MAX = 118,
    _SC_V6_ILP32_OFF32 = 176,
    _SC_V6_ILP32_OFFBIG = 177,
    _SC_V6_LP64_OFF64 = 178,
    _SC_V6_LPBIG_OFFBIG = 179,
    _SC_VERSION = 29,
    _SC_WORD_BIT = 107,
    _SC_XBS5_ILP32_OFF32 = 125,
    _SC_XBS5_ILP32_OFFBIG = 126,
    _SC_XBS5_LP64_OFF64 = 127,
    _SC_XBS5_LPBIG_OFFBIG = 128,
    _SC_XOPEN_CRYPT = 92,
    _SC_XOPEN_ENH_I18N = 93,
    _SC_XOPEN_LEGACY = 129,
    _SC_XOPEN_REALTIME = 130,
    _SC_XOPEN_REALTIME_THREADS = 131,
    _SC_XOPEN_SHM = 94,
    _SC_XOPEN_UNIX = 91,
    _SC_XOPEN_VERSION = 89,
    _SC_XOPEN_XCU_VERSION = 90,
    _SC_XOPEN_XPG2 = 98,
    _SC_XOPEN_XPG3 = 99,
    _SC_XOPEN_XPG4 = 100,
  }
  [MapAttribute]
  [System.CLSCompliantAttribute(false)]
  public enum SyslogFacility {
    LOG_AUTH = 32,
    LOG_AUTHPRIV = 80,
    LOG_CRON = 72,
    LOG_DAEMON = 24,
    LOG_FTP = 88,
    LOG_KERN = 0,
    LOG_LOCAL0 = 128,
    LOG_LOCAL1 = 136,
    LOG_LOCAL2 = 144,
    LOG_LOCAL3 = 152,
    LOG_LOCAL4 = 160,
    LOG_LOCAL5 = 168,
    LOG_LOCAL6 = 176,
    LOG_LOCAL7 = 184,
    LOG_LPR = 48,
    LOG_MAIL = 16,
    LOG_NEWS = 56,
    LOG_SYSLOG = 40,
    LOG_USER = 8,
    LOG_UUCP = 64,
  }
  [MapAttribute]
  [System.CLSCompliantAttribute(false)]
  public enum SyslogLevel {
    LOG_ALERT = 1,
    LOG_CRIT = 2,
    LOG_DEBUG = 7,
    LOG_EMERG = 0,
    LOG_ERR = 3,
    LOG_INFO = 6,
    LOG_NOTICE = 5,
    LOG_WARNING = 4,
  }
  [MapAttribute]
  [System.CLSCompliantAttribute(false)]
  [System.FlagsAttribute]
  public enum SyslogOptions {
    LOG_CONS = 2,
    LOG_NDELAY = 8,
    LOG_NOWAIT = 16,
    LOG_ODELAY = 4,
    LOG_PERROR = 32,
    LOG_PID = 1,
  }
  [MapAttribute("struct timespec")]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Timespec : System.IEquatable<Mono.Unix.Native.Timespec> {
    public long tv_nsec;
    [Mono.Unix.Native.time_tAttribute]
    public long tv_sec;
    public bool Equals(Mono.Unix.Native.Timespec value) { return default(bool); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(Mono.Unix.Native.Timespec lhs, Mono.Unix.Native.Timespec rhs) { return default(bool); }
    public static bool operator !=(Mono.Unix.Native.Timespec lhs, Mono.Unix.Native.Timespec rhs) { return default(bool); }
  }
  [MapAttribute("struct timeval")]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Timeval : System.IEquatable<Mono.Unix.Native.Timeval> {
    [Mono.Unix.Native.time_tAttribute]
    public long tv_sec;
    [Mono.Unix.Native.suseconds_tAttribute]
    public long tv_usec;
    public bool Equals(Mono.Unix.Native.Timeval value) { return default(bool); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(Mono.Unix.Native.Timeval lhs, Mono.Unix.Native.Timeval rhs) { return default(bool); }
    public static bool operator !=(Mono.Unix.Native.Timeval lhs, Mono.Unix.Native.Timeval rhs) { return default(bool); }
  }
  [MapAttribute("struct timezone")]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Timezone : System.IEquatable<Mono.Unix.Native.Timezone> {
    public int tz_minuteswest;
    public bool Equals(Mono.Unix.Native.Timezone value) { return default(bool); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(Mono.Unix.Native.Timezone lhs, Mono.Unix.Native.Timezone rhs) { return default(bool); }
    public static bool operator !=(Mono.Unix.Native.Timezone lhs, Mono.Unix.Native.Timezone rhs) { return default(bool); }
  }
  [MapAttribute("struct utimbuf")]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Utimbuf : System.IEquatable<Mono.Unix.Native.Utimbuf> {
    [Mono.Unix.Native.time_tAttribute]
    public long actime;
    [Mono.Unix.Native.time_tAttribute]
    public long modtime;
    public bool Equals(Mono.Unix.Native.Utimbuf value) { return default(bool); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(Mono.Unix.Native.Utimbuf lhs, Mono.Unix.Native.Utimbuf rhs) { return default(bool); }
    public static bool operator !=(Mono.Unix.Native.Utimbuf lhs, Mono.Unix.Native.Utimbuf rhs) { return default(bool); }
  }
  public sealed partial class Utsname : System.IEquatable<Mono.Unix.Native.Utsname> {
    public string domainname;
    public string machine;
    public string nodename;
    public string release;
    public string sysname;
    public string version;
    public Utsname() { }
    public bool Equals(Mono.Unix.Native.Utsname value) { return default(bool); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(Mono.Unix.Native.Utsname lhs, Mono.Unix.Native.Utsname rhs) { return default(bool); }
    public static bool operator !=(Mono.Unix.Native.Utsname lhs, Mono.Unix.Native.Utsname rhs) { return default(bool); }
    public override string ToString() { return default(string); }
  }
  [MapAttribute]
  [System.FlagsAttribute]
  public enum WaitOptions {
    WNOHANG = 1,
    WUNTRACED = 2,
  }
  [MapAttribute]
  [System.CLSCompliantAttribute(false)]
  [System.FlagsAttribute]
  public enum XattrFlags {
    XATTR_AUTO = 0,
    XATTR_CREATE = 1,
    XATTR_REPLACE = 2,
  }
}
