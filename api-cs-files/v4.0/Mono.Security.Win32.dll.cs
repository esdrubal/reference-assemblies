namespace Mono.Security.Cryptography {
  public partial class CapiContext : System.IDisposable {
    public CapiContext() { }
    public CapiContext(System.Security.Cryptography.CspParameters csp) { }
    public int Error { get { return default(int); } }
    public System.IntPtr Handle { get { return default(System.IntPtr); } }
    public bool Result { get { return default(bool); } }
    public void Dispose() { }
    ~CapiContext() { }
  }
  public partial class CapiHash : System.IDisposable {
    public CapiHash(Mono.Security.Cryptography.CapiContext ctx, int hashAlgorithm) { }
    public CapiHash(int hashAlgorithm) { }
    public CapiHash(System.Security.Cryptography.CspParameters cspParams, int hashAlgorithm) { }
    public System.IntPtr Handle { get { return default(System.IntPtr); } }
    public int HashSize { get { return default(int); } }
    public void Dispose() { }
    ~CapiHash() { }
    public void HashCore(System.Byte[] data, int start, int length) { }
    public System.Byte[] HashFinal() { return default(System.Byte[]); }
    public void Initialize(int algo) { }
  }
  public abstract partial class MD2 : System.Security.Cryptography.HashAlgorithm {
    protected MD2() { }
    public static new Mono.Security.Cryptography.MD2 Create() { return default(Mono.Security.Cryptography.MD2); }
    public static new Mono.Security.Cryptography.MD2 Create(string hashName) { return default(Mono.Security.Cryptography.MD2); }
  }
  public partial class MD2CryptoServiceProvider : Mono.Security.Cryptography.MD2 {
    public MD2CryptoServiceProvider() { }
    protected override void Dispose(bool disposing) { }
    ~MD2CryptoServiceProvider() { }
    protected override void HashCore(System.Byte[] rgb, int ibStart, int cbSize) { }
    protected override System.Byte[] HashFinal() { return default(System.Byte[]); }
    public override void Initialize() { }
  }
  public abstract partial class MD4 : System.Security.Cryptography.HashAlgorithm {
    protected MD4() { }
    public static new Mono.Security.Cryptography.MD4 Create() { return default(Mono.Security.Cryptography.MD4); }
    public static new Mono.Security.Cryptography.MD4 Create(string hashName) { return default(Mono.Security.Cryptography.MD4); }
  }
  public partial class MD4CryptoServiceProvider : Mono.Security.Cryptography.MD4 {
    public MD4CryptoServiceProvider() { }
    protected override void Dispose(bool disposing) { }
    ~MD4CryptoServiceProvider() { }
    protected override void HashCore(System.Byte[] rgb, int ibStart, int cbSize) { }
    protected override System.Byte[] HashFinal() { return default(System.Byte[]); }
    public override void Initialize() { }
  }
  public partial class MD5CryptoServiceProvider : System.Security.Cryptography.MD5 {
    public MD5CryptoServiceProvider() { }
    protected override void Dispose(bool disposing) { }
    ~MD5CryptoServiceProvider() { }
    protected override void HashCore(System.Byte[] rgb, int ibStart, int cbSize) { }
    protected override System.Byte[] HashFinal() { return default(System.Byte[]); }
    public override void Initialize() { }
  }
  public partial class RNGCryptoServiceProvider : System.Security.Cryptography.RandomNumberGenerator {
    public RNGCryptoServiceProvider() { }
    public RNGCryptoServiceProvider(System.Byte[] rgb) { }
    public RNGCryptoServiceProvider(System.Security.Cryptography.CspParameters cspParams) { }
    public RNGCryptoServiceProvider(string str) { }
    ~RNGCryptoServiceProvider() { }
    public override void GetBytes(System.Byte[] data) { }
    public override void GetNonZeroBytes(System.Byte[] data) { }
  }
  public partial class SHA1CryptoServiceProvider : System.Security.Cryptography.SHA1 {
    public SHA1CryptoServiceProvider() { }
    protected override void Dispose(bool disposing) { }
    ~SHA1CryptoServiceProvider() { }
    protected override void HashCore(System.Byte[] rgb, int ibStart, int cbSize) { }
    protected override System.Byte[] HashFinal() { return default(System.Byte[]); }
    public override void Initialize() { }
  }
}
