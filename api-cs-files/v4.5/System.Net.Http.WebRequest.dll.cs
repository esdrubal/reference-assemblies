namespace System.Net.Http {
  public partial class WebRequestHandler : System.Net.Http.HttpClientHandler {
    public WebRequestHandler() { }
    public bool AllowPipelining { get { return default(bool); } set { } }
    public System.Net.Security.AuthenticationLevel AuthenticationLevel { get { return default(System.Net.Security.AuthenticationLevel); } set { } }
    public System.Net.Cache.RequestCachePolicy CachePolicy { get { return default(System.Net.Cache.RequestCachePolicy); } set { } }
    [System.MonoTODOAttribute]
    public System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates { get { return default(System.Security.Cryptography.X509Certificates.X509CertificateCollection); } }
    [System.MonoTODOAttribute]
    public System.TimeSpan ContinueTimeout { get { return default(System.TimeSpan); } set { } }
    public System.Security.Principal.TokenImpersonationLevel ImpersonationLevel { get { return default(System.Security.Principal.TokenImpersonationLevel); } set { } }
    public int MaxResponseHeadersLength { get { return default(int); } set { } }
    public int ReadWriteTimeout { get { return default(int); } set { } }
    [System.MonoTODOAttribute]
    public System.Net.Security.RemoteCertificateValidationCallback ServerCertificateValidationCallback { get { return default(System.Net.Security.RemoteCertificateValidationCallback); } set { } }
    public bool UnsafeAuthenticatedConnectionSharing { get { return default(bool); } set { } }
  }
}
