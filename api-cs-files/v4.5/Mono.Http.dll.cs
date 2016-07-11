namespace Mono.Http {
  public partial class GZipWebRequest : System.Net.WebRequest, System.Runtime.Serialization.ISerializable {
    public GZipWebRequest(System.Net.WebRequest request) { }
    protected GZipWebRequest(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    public override string ConnectionGroupName { get { return default(string); } set { } }
    public override long ContentLength { get { return default(long); } set { } }
    public override string ContentType { get { return default(string); } set { } }
    public override System.Net.ICredentials Credentials { get { return default(System.Net.ICredentials); } set { } }
    public bool EnableCompression { get { return default(bool); } set { } }
    public override System.Net.WebHeaderCollection Headers { get { return default(System.Net.WebHeaderCollection); } set { } }
    public override string Method { get { return default(string); } set { } }
    public override bool PreAuthenticate { get { return default(bool); } set { } }
    public override System.Net.IWebProxy Proxy { get { return default(System.Net.IWebProxy); } set { } }
    public System.Net.WebRequest RealRequest { get { return default(System.Net.WebRequest); } }
    public override System.Uri RequestUri { get { return default(System.Uri); } }
    public override int Timeout { get { return default(int); } set { } }
    public override void Abort() { }
    public override System.IAsyncResult BeginGetRequestStream(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public override System.IAsyncResult BeginGetResponse(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public override System.IO.Stream EndGetRequestStream(System.IAsyncResult asyncResult) { return default(System.IO.Stream); }
    public override System.Net.WebResponse EndGetResponse(System.IAsyncResult asyncResult) { return default(System.Net.WebResponse); }
    public override System.IO.Stream GetRequestStream() { return default(System.IO.Stream); }
    public override System.Net.WebResponse GetResponse() { return default(System.Net.WebResponse); }
    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial class GZipWebRequestCreator : System.Net.IWebRequestCreate {
    public GZipWebRequestCreator() { }
    public System.Net.WebRequest Create(System.Uri uri) { return default(System.Net.WebRequest); }
  }
  public partial class GZipWriteFilter : System.IO.Stream {
    public GZipWriteFilter(System.IO.Stream baseStream) { }
    public override bool CanRead { get { return default(bool); } }
    public override bool CanSeek { get { return default(bool); } }
    public override bool CanWrite { get { return default(bool); } }
    public override long Length { get { return default(long); } }
    public override long Position { get { return default(long); } set { } }
    public override void Close() { }
    public override void Flush() { }
    public override int Read(System.Byte[] buffer, int offset, int count) { return default(int); }
    public override long Seek(long offset, System.IO.SeekOrigin origin) { return default(long); }
    public override void SetLength(long value) { }
    public override void Write(System.Byte[] buffer, int offset, int count) { }
  }
  public partial class NtlmClient : System.Net.IAuthenticationModule {
    public NtlmClient() { }
    public string AuthenticationType { get { return default(string); } }
    public bool CanPreAuthenticate { get { return default(bool); } }
    public System.Net.Authorization Authenticate(string challenge, System.Net.WebRequest webRequest, System.Net.ICredentials credentials) { return default(System.Net.Authorization); }
    public System.Net.Authorization PreAuthenticate(System.Net.WebRequest webRequest, System.Net.ICredentials credentials) { return default(System.Net.Authorization); }
  }
}
namespace Mono.Http.Configuration {
  public partial class AcceptEncodingConfig {
    public AcceptEncodingConfig() { }
    public AcceptEncodingConfig(Mono.Http.Configuration.AcceptEncodingConfig parent) { }
    public void Add(string encoding, string type) { }
    public void Clear() { }
    public bool SetFilter(System.Web.HttpResponse response, string acceptEncoding) { return default(bool); }
  }
  public partial class AcceptEncodingSectionHandler : System.Configuration.IConfigurationSectionHandler {
    public AcceptEncodingSectionHandler() { }
    public object Create(object parent, object configContext, System.Xml.XmlNode section) { return default(object); }
  }
}
namespace Mono.Http.Modules {
  public partial class AcceptEncodingModule : System.Web.IHttpModule {
    public AcceptEncodingModule() { }
    public void Dispose() { }
    public void Init(System.Web.HttpApplication app) { }
  }
  public abstract partial class AuthenticationModule : System.Web.IHttpModule {
    public AuthenticationModule(string authenticationMethod) { }
    public string AuthenticationMethod { get { return default(string); } }
    protected bool AuthenticationRequired { get { return default(bool); } }
    protected abstract bool AcceptCredentials(System.Web.HttpApplication app, string authentication);
    protected string Authorization(System.Web.HttpApplication app, string authenticationMethod) { return default(string); }
    protected void DenyAccess(System.Web.HttpApplication app) { }
    public virtual void Dispose() { }
    public virtual void Init(System.Web.HttpApplication context) { }
    public virtual void OnAuthenticateRequest(object source, System.EventArgs eventArgs) { }
    public abstract void OnEndRequest(object source, System.EventArgs eventArgs);
  }
  public partial class BasicAuthenticationModule : Mono.Http.Modules.AuthenticationModule {
    public BasicAuthenticationModule() : base (default(string)) { }
    protected override bool AcceptCredentials(System.Web.HttpApplication app, string authentication) { return default(bool); }
    public override void OnEndRequest(object source, System.EventArgs eventArgs) { }
  }
  public partial class DigestAuthenticationModule : Mono.Http.Modules.AuthenticationModule {
    public DigestAuthenticationModule() : base (default(string)) { }
    protected override bool AcceptCredentials(System.Web.HttpApplication app, string authentication) { return default(bool); }
    protected virtual string GetCurrentNonce() { return default(string); }
    protected virtual bool GetUserByName(System.Web.HttpApplication app, string username, out string password, out System.String[] roles) { password = default(string); roles = default(System.String[]); return default(bool); }
    protected virtual bool IsValidNonce(string nonce) { return default(bool); }
    public override void OnEndRequest(object source, System.EventArgs eventArgs) { }
  }
}
namespace System.Net {
  public partial class GZipWebResponse : System.Net.WebResponse, System.IDisposable, System.Runtime.Serialization.ISerializable {
    protected GZipWebResponse(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public override long ContentLength { get { return default(long); } }
    public override string ContentType { get { return default(string); } }
    public override System.Net.WebHeaderCollection Headers { get { return default(System.Net.WebHeaderCollection); } }
    public bool IsCompressed { get { return default(bool); } }
    public System.Net.WebResponse RealResponse { get { return default(System.Net.WebResponse); } }
    public override System.Uri ResponseUri { get { return default(System.Uri); } }
    public override void Close() { }
    public override System.IO.Stream GetResponseStream() { return default(System.IO.Stream); }
    void System.IDisposable.Dispose() { }
    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
}
