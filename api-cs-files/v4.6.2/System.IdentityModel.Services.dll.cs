namespace System.IdentityModel.Services {
  public enum ApplicationType {
    AspNetWebApplication = 0,
    WcfServiceApplication = 1,
  }
  public partial class AsynchronousOperationException : System.Exception {
    public AsynchronousOperationException() { }
    public AsynchronousOperationException(System.Exception innerException) { }
    protected AsynchronousOperationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public AsynchronousOperationException(string message) { }
    public AsynchronousOperationException(string message, System.Exception innerException) { }
  }
  public partial class AttributeRequestMessage : System.IdentityModel.Services.WSFederationMessage {
    public AttributeRequestMessage(System.Uri baseUrl) : base (default(System.Uri), default(string)) { }
    public string Attribute { get { return default(string); } set { } }
    public string AttributePtr { get { return default(string); } set { } }
    public string Reply { get { return default(string); } set { } }
    public string Result { get { return default(string); } set { } }
    public string ResultPtr { get { return default(string); } set { } }
    protected override void Validate() { }
    public override void Write(System.IO.TextWriter writer) { }
  }
  public partial class AuthorizationFailedEventArgs : System.EventArgs {
    public AuthorizationFailedEventArgs() { }
    public bool RedirectToIdentityProvider { get { return default(bool); } set { } }
  }
  public sealed partial class ChunkedCookieHandler : System.IdentityModel.Services.CookieHandler {
    public const int DefaultChunkSize = 2000;
    public const int MinimumChunkSize = 1000;
    public ChunkedCookieHandler() { }
    public ChunkedCookieHandler(int chunkSize) { }
    public int ChunkSize { get { return default(int); } }
    protected override void DeleteCore(string name, string path, string domain, System.Web.HttpContext context) { }
    protected override System.Byte[] ReadCore(string name, System.Web.HttpContext context) { return default(System.Byte[]); }
    protected override void WriteCore(System.Byte[] value, string name, string path, string domain, System.DateTime expirationTime, bool secure, bool httpOnly, System.Web.HttpContext context) { }
  }
  public partial class ChunkedCookieHandlerElement : System.Configuration.ConfigurationElement {
    public ChunkedCookieHandlerElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("chunkSize", IsRequired=false, DefaultValue=2000)]
    [System.Configuration.IntegerValidatorAttribute(MinValue=1000)]
    public int ChunkSize { get { return default(int); } set { } }
  }
  public partial class ClaimsAuthorizationModule : System.IdentityModel.Services.HttpModuleBase {
    public ClaimsAuthorizationModule() { }
    public System.Security.Claims.ClaimsAuthorizationManager ClaimsAuthorizationManager { get { return default(System.Security.Claims.ClaimsAuthorizationManager); } set { } }
    protected virtual bool Authorize() { return default(bool); }
    public override void Dispose() { }
    protected override void InitializeModule(System.Web.HttpApplication context) { }
    protected override void InitializePropertiesFromConfiguration() { }
    protected virtual void OnAuthorizeRequest(object sender, System.EventArgs args) { }
  }
  public sealed partial class ClaimsPrincipalPermission : System.Security.IPermission, System.Security.ISecurityEncodable, System.Security.Permissions.IUnrestrictedPermission {
    public ClaimsPrincipalPermission(string resource, string action) { }
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Security", "CA2103:ReviewImperativeSecurity", Justification="It is expected that the runtime’s behavior would rely on changing data")]
    public static void CheckAccess(string resource, string action) { }
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Security", "CA2103:ReviewImperativeSecurity", Justification="It is expected that the runtime’s behavior would rely on changing data")]
    public System.Security.IPermission Copy() { return default(System.Security.IPermission); }
    public void Demand() { }
    public void FromXml(System.Security.SecurityElement element) { }
    public System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
    public bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
    public bool IsUnrestricted() { return default(bool); }
    public System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
    public System.Security.IPermission Union(System.Security.IPermission target) { return default(System.Security.IPermission); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(196), AllowMultiple=true)]
  public sealed partial class ClaimsPrincipalPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute {
    public ClaimsPrincipalPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
    public string Operation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Resource { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Security", "CA2103:ReviewImperativeSecurity", Justification="It is expected that the runtime’s behavior would rely on changing data")]
    public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
  }
  public abstract partial class CookieHandler {
    protected CookieHandler() { }
    public virtual string Domain { get { return default(string); } set { } }
    public virtual bool HideFromClientScript { get { return default(bool); } set { } }
    public virtual string Name { get { return default(string); } set { } }
    public virtual string Path { get { return default(string); } set { } }
    public virtual System.Nullable<System.TimeSpan> PersistentSessionLifetime { get { return default(System.Nullable<System.TimeSpan>); } set { } }
    public virtual bool RequireSsl { get { return default(bool); } set { } }
    public void Delete() { }
    public void Delete(string name) { }
    public void Delete(string name, string path, string domain, System.Web.HttpContext context) { }
    public void Delete(string name, System.Web.HttpContext context) { }
    public void Delete(System.Web.HttpContext context) { }
    protected abstract void DeleteCore(string name, string path, string domain, System.Web.HttpContext context);
    public virtual string MatchCookiePath(System.Uri baseUri, System.Uri targetUri) { return default(string); }
    public System.Byte[] Read() { return default(System.Byte[]); }
    public System.Byte[] Read(string name) { return default(System.Byte[]); }
    public System.Byte[] Read(string name, System.Web.HttpContext context) { return default(System.Byte[]); }
    public System.Byte[] Read(System.Web.HttpContext context) { return default(System.Byte[]); }
    protected abstract System.Byte[] ReadCore(string name, System.Web.HttpContext context);
    public void Write(System.Byte[] value, bool isPersistent, System.DateTime tokenExpirationTime) { }
    public void Write(System.Byte[] value, string name, System.DateTime expirationTime) { }
    public void Write(System.Byte[] value, string name, System.DateTime expirationTime, System.Web.HttpContext context) { }
    public void Write(System.Byte[] value, string name, string path, string domain, System.DateTime expirationTime, bool requiresSsl, bool hideFromClientScript, System.Web.HttpContext context) { }
    protected abstract void WriteCore(System.Byte[] value, string name, string path, string domain, System.DateTime expirationTime, bool secure, bool httpOnly, System.Web.HttpContext context);
  }
  public partial class CookieHandlerElement : System.Configuration.ConfigurationElement {
    public CookieHandlerElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("chunkedCookieHandler", IsRequired=false)]
    public System.IdentityModel.Services.ChunkedCookieHandlerElement ChunkedCookieHandler { get { return default(System.IdentityModel.Services.ChunkedCookieHandlerElement); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("customCookieHandler", IsRequired=false)]
    public System.IdentityModel.Configuration.CustomTypeElement CustomCookieHandler { get { return default(System.IdentityModel.Configuration.CustomTypeElement); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("domain", IsRequired=false)]
    public string Domain { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("hideFromScript", IsRequired=false, DefaultValue=true)]
    public bool HideFromScript { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("mode", IsRequired=false, DefaultValue=(System.IdentityModel.Services.CookieHandlerMode)(0))]
    public System.IdentityModel.Services.CookieHandlerMode Mode { get { return default(System.IdentityModel.Services.CookieHandlerMode); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("name", IsRequired=false)]
    public string Name { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("path", IsRequired=false)]
    public string Path { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("persistentSessionLifetime", DefaultValue="0:0:0", IsRequired=false)]
    [System.Configuration.TimeSpanValidatorAttribute(MinValueString="0:0:0", MaxValueString="365.0:0:0")]
    public System.TimeSpan PersistentSessionLifetime { get { return default(System.TimeSpan); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("requireSsl", IsRequired=false, DefaultValue=true)]
    public bool RequireSsl { get { return default(bool); } set { } }
    public System.IdentityModel.Services.CookieHandler GetConfiguredCookieHandler() { return default(System.IdentityModel.Services.CookieHandler); }
  }
  public enum CookieHandlerMode {
    Chunked = 1,
    Custom = 2,
    Default = 0,
  }
  public partial class ErrorEventArgs : System.ComponentModel.CancelEventArgs {
    public ErrorEventArgs(bool cancel, System.Exception exception) { }
    public ErrorEventArgs(System.Exception exception) { }
    public System.Exception Exception { get { return default(System.Exception); } }
  }
  public static partial class FederatedAuthentication {
    public static System.IdentityModel.Services.ClaimsAuthorizationModule ClaimsAuthorizationModule { get { return default(System.IdentityModel.Services.ClaimsAuthorizationModule); } }
    public static System.IdentityModel.Services.Configuration.FederationConfiguration FederationConfiguration { get { return default(System.IdentityModel.Services.Configuration.FederationConfiguration); } }
    public static System.IdentityModel.Services.SessionAuthenticationModule SessionAuthenticationModule { get { return default(System.IdentityModel.Services.SessionAuthenticationModule); } }
    public static System.IdentityModel.Services.WSFederationAuthenticationModule WSFederationAuthenticationModule { get { return default(System.IdentityModel.Services.WSFederationAuthenticationModule); } }
    public static event System.EventHandler<System.IdentityModel.Services.Configuration.FederationConfigurationCreatedEventArgs> FederationConfigurationCreated { add { } remove { } }
    public static T GetHttpModule<T>() where T : class, System.Web.IHttpModule { return default(T); }
  }
  public partial class FederatedAuthenticationSessionEndingException : System.Exception, System.Runtime.Serialization.ISerializable {
    public FederatedAuthenticationSessionEndingException() { }
    protected FederatedAuthenticationSessionEndingException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public FederatedAuthenticationSessionEndingException(string message) { }
    public FederatedAuthenticationSessionEndingException(string message, System.Exception inner) { }
  }
  public static partial class FederatedPassiveSecurityTokenServiceOperations {
    public static void ProcessRequest(System.Web.HttpRequest request, System.Security.Claims.ClaimsPrincipal principal, System.IdentityModel.SecurityTokenService sts, System.Web.HttpResponse response) { }
    public static void ProcessRequest(System.Web.HttpRequest request, System.Security.Claims.ClaimsPrincipal principal, System.IdentityModel.SecurityTokenService sts, System.Web.HttpResponse response, System.IdentityModel.Services.WSFederationSerializer federationSerializer) { }
    public static System.IdentityModel.Services.SignInResponseMessage ProcessSignInRequest(System.IdentityModel.Services.SignInRequestMessage requestMessage, System.Security.Claims.ClaimsPrincipal principal, System.IdentityModel.SecurityTokenService sts) { return default(System.IdentityModel.Services.SignInResponseMessage); }
    public static System.IdentityModel.Services.SignInResponseMessage ProcessSignInRequest(System.IdentityModel.Services.SignInRequestMessage requestMessage, System.Security.Claims.ClaimsPrincipal principal, System.IdentityModel.SecurityTokenService sts, System.IdentityModel.Services.WSFederationSerializer federationSerializer) { return default(System.IdentityModel.Services.SignInResponseMessage); }
    public static void ProcessSignInResponse(System.IdentityModel.Services.SignInResponseMessage signInResponseMessage, System.Web.HttpResponse httpResponse) { }
    public static void ProcessSignOutRequest(System.IdentityModel.Services.FederationMessage requestMessage, System.Security.Claims.ClaimsPrincipal principal, string reply, System.Web.HttpResponse httpResponse) { }
  }
  public partial class FederatedSessionExpiredException : System.IdentityModel.Services.FederatedAuthenticationSessionEndingException {
    public FederatedSessionExpiredException() { }
    public FederatedSessionExpiredException(System.DateTime tested, System.DateTime expired) { }
    public FederatedSessionExpiredException(System.DateTime tested, System.DateTime expired, System.Exception inner) { }
    protected FederatedSessionExpiredException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public FederatedSessionExpiredException(string message) { }
    public FederatedSessionExpiredException(string message, System.Exception inner) { }
    public System.DateTime Expired { get { return default(System.DateTime); } }
    public System.DateTime Tested { get { return default(System.DateTime); } }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, SerializationFormatter=true)]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial class FederationException : System.Exception {
    public FederationException() { }
    protected FederationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public FederationException(string message) { }
    public FederationException(string message, System.Exception inner) { }
  }
  public static partial class FederationManagement {
    public static System.Xml.XmlReader CreateApplicationFederationMetadata(System.Uri applicationUri, System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, System.Collections.ObjectModel.Collection<System.IdentityModel.Metadata.DisplayClaim> claimsRequired, System.IdentityModel.Services.ApplicationType applicationType, System.Collections.ObjectModel.Collection<System.Uri> audienceUris) { return default(System.Xml.XmlReader); }
    public static System.Xml.XmlReader UpdateIdentityProviderTrustInfo(System.Xml.XmlReader metadataReader, System.Xml.XmlReader inputConfiguration, bool claimsOfferedUpdate) { return default(System.Xml.XmlReader); }
    public static System.Xml.XmlReader UpdateIdentityProviderTrustInfo(System.Xml.XmlReader metadataReader, System.Xml.XmlReader inputConfiguration, bool claimsOfferedUpdate, System.IdentityModel.Metadata.MetadataSerializer metadataSerializer) { return default(System.Xml.XmlReader); }
    public static void UpdateIdentityProviderTrustInfo(System.Xml.XmlReader metadataReader, System.Xml.XmlReader inputConfiguration, out System.Xml.XmlNodeReader newIssuerNameRegistry, out System.Xml.XmlNodeReader claimTypesOffered) { newIssuerNameRegistry = default(System.Xml.XmlNodeReader); claimTypesOffered = default(System.Xml.XmlNodeReader); }
    public static void UpdateIdentityProviderTrustInfo(System.Xml.XmlReader metadataReader, System.Xml.XmlReader inputConfiguration, out System.Xml.XmlNodeReader newIssuerNameRegistry, out System.Xml.XmlNodeReader claimTypesOffered, System.IdentityModel.Metadata.MetadataSerializer metadataSerializer) { newIssuerNameRegistry = default(System.Xml.XmlNodeReader); claimTypesOffered = default(System.Xml.XmlNodeReader); }
  }
  public abstract partial class FederationMessage {
    protected FederationMessage(System.Uri baseUrl) { }
    public System.Uri BaseUri { get { return default(System.Uri); } set { } }
    public System.Collections.Generic.IDictionary<System.String, System.String> Parameters { get { return default(System.Collections.Generic.IDictionary<System.String, System.String>); } }
    public static System.Uri GetBaseUrl(System.Uri uri) { return default(System.Uri); }
    public string GetParameter(string parameter) { return default(string); }
    public static System.Collections.Specialized.NameValueCollection ParseQueryString(System.Uri data) { return default(System.Collections.Specialized.NameValueCollection); }
    public void RemoveParameter(string parameter) { }
    public void SetParameter(string parameter, string value) { }
    public void SetUriParameter(string parameter, string value) { }
    protected virtual void Validate() { }
    public abstract void Write(System.IO.TextWriter writer);
    public virtual string WriteFormPost() { return default(string); }
    public virtual string WriteQueryString() { return default(string); }
  }
  public abstract partial class HttpModuleBase : System.Web.IHttpModule {
    protected HttpModuleBase() { }
    public System.IdentityModel.Services.Configuration.FederationConfiguration FederationConfiguration { get { return default(System.IdentityModel.Services.Configuration.FederationConfiguration); } set { } }
    public virtual void Dispose() { }
    public void Init(System.Web.HttpApplication context) { }
    protected abstract void InitializeModule(System.Web.HttpApplication context);
    protected abstract void InitializePropertiesFromConfiguration();
  }
  public partial class MachineKeyTransform : System.IdentityModel.CookieTransform {
    public MachineKeyTransform() { }
    public override System.Byte[] Decode(System.Byte[] encoded) { return default(System.Byte[]); }
    public override System.Byte[] Encode(System.Byte[] value) { return default(System.Byte[]); }
  }
  public partial class PseudonymRequestMessage : System.IdentityModel.Services.WSFederationMessage {
    public PseudonymRequestMessage(System.Uri baseUrl) : base (default(System.Uri), default(string)) { }
    public string Pseudonym { get { return default(string); } set { } }
    public string PseudonymPtr { get { return default(string); } set { } }
    public string Reply { get { return default(string); } set { } }
    public string Result { get { return default(string); } set { } }
    public string ResultPtr { get { return default(string); } set { } }
    protected override void Validate() { }
    public override void Write(System.IO.TextWriter writer) { }
  }
  public partial class RedirectingToIdentityProviderEventArgs : System.ComponentModel.CancelEventArgs {
    public RedirectingToIdentityProviderEventArgs(System.IdentityModel.Services.SignInRequestMessage signInRequestMessage) { }
    public System.IdentityModel.Services.SignInRequestMessage SignInRequestMessage { get { return default(System.IdentityModel.Services.SignInRequestMessage); } set { } }
  }
  public partial class SecurityTokenReceivedEventArgs : System.ComponentModel.CancelEventArgs {
    public SecurityTokenReceivedEventArgs(System.IdentityModel.Tokens.SecurityToken securityToken) { }
    public SecurityTokenReceivedEventArgs(System.IdentityModel.Tokens.SecurityToken securityToken, string signInContext) { }
    public System.IdentityModel.Tokens.SecurityToken SecurityToken { get { return default(System.IdentityModel.Tokens.SecurityToken); } set { } }
    public string SignInContext { get { return default(string); } }
  }
  public partial class SecurityTokenValidatedEventArgs : System.ComponentModel.CancelEventArgs {
    public SecurityTokenValidatedEventArgs(System.Security.Claims.ClaimsPrincipal claimsPrincipal) { }
    public System.Security.Claims.ClaimsPrincipal ClaimsPrincipal { get { return default(System.Security.Claims.ClaimsPrincipal); } set { } }
  }
  public partial class ServiceCertificateElement : System.Configuration.ConfigurationElement {
    public ServiceCertificateElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("certificateReference", IsRequired=false)]
    public System.ServiceModel.Configuration.CertificateReferenceElement CertificateReference { get { return default(System.ServiceModel.Configuration.CertificateReferenceElement); } set { } }
  }
  public partial class SessionAuthenticationModule : System.IdentityModel.Services.HttpModuleBase {
    public SessionAuthenticationModule() { }
    public virtual System.IdentityModel.Tokens.SessionSecurityToken ContextSessionSecurityToken { get { return default(System.IdentityModel.Tokens.SessionSecurityToken); } }
    public System.IdentityModel.Services.CookieHandler CookieHandler { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.IdentityModel.Services.CookieHandler); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool IsReferenceMode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public event System.EventHandler<System.IdentityModel.Services.SessionSecurityTokenCreatedEventArgs> SessionSecurityTokenCreated { add { } remove { } }
    public event System.EventHandler<System.IdentityModel.Services.SessionSecurityTokenReceivedEventArgs> SessionSecurityTokenReceived { add { } remove { } }
    public event System.EventHandler SignedOut { add { } remove { } }
    public event System.EventHandler<System.IdentityModel.Services.SigningOutEventArgs> SigningOut { add { } remove { } }
    public event System.EventHandler<System.IdentityModel.Services.ErrorEventArgs> SignOutError { add { } remove { } }
    public virtual void AuthenticateSessionSecurityToken(System.IdentityModel.Tokens.SessionSecurityToken sessionToken, bool writeCookie) { }
    public bool ContainsSessionTokenCookie(System.Web.HttpCookieCollection httpCookieCollection) { return default(bool); }
    public System.IdentityModel.Tokens.SessionSecurityToken CreateSessionSecurityToken(System.Security.Claims.ClaimsPrincipal principal, string context, System.DateTime validFrom, System.DateTime validTo, bool isPersistent) { return default(System.IdentityModel.Tokens.SessionSecurityToken); }
    public void DeleteSessionTokenCookie() { }
    protected override void InitializeModule(System.Web.HttpApplication context) { }
    protected override void InitializePropertiesFromConfiguration() { }
    protected virtual void OnAuthenticateRequest(object sender, System.EventArgs eventArgs) { }
    protected virtual void OnPostAuthenticateRequest(object sender, System.EventArgs e) { }
    protected virtual void OnSessionSecurityTokenCreated(System.IdentityModel.Services.SessionSecurityTokenCreatedEventArgs args) { }
    protected virtual void OnSessionSecurityTokenReceived(System.IdentityModel.Services.SessionSecurityTokenReceivedEventArgs args) { }
    protected virtual void OnSignedOut(System.EventArgs e) { }
    protected virtual void OnSigningOut(System.IdentityModel.Services.SigningOutEventArgs e) { }
    protected virtual void OnSignOutError(System.IdentityModel.Services.ErrorEventArgs e) { }
    public System.IdentityModel.Tokens.SessionSecurityToken ReadSessionTokenFromCookie(System.Byte[] sessionCookie) { return default(System.IdentityModel.Tokens.SessionSecurityToken); }
    protected virtual void SetPrincipalFromSessionToken(System.IdentityModel.Tokens.SessionSecurityToken sessionSecurityToken) { }
    public virtual void SignOut() { }
    public bool TryReadSessionTokenFromCookie(out System.IdentityModel.Tokens.SessionSecurityToken sessionToken) { sessionToken = default(System.IdentityModel.Tokens.SessionSecurityToken); return default(bool); }
    protected System.Collections.ObjectModel.ReadOnlyCollection<System.Security.Claims.ClaimsIdentity> ValidateSessionToken(System.IdentityModel.Tokens.SessionSecurityToken sessionSecurityToken) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Security.Claims.ClaimsIdentity>); }
    public void WriteSessionTokenToCookie(System.IdentityModel.Tokens.SessionSecurityToken sessionToken) { }
  }
  public partial class SessionSecurityTokenCreatedEventArgs : System.EventArgs {
    public SessionSecurityTokenCreatedEventArgs(System.IdentityModel.Tokens.SessionSecurityToken sessionToken) { }
    public System.IdentityModel.Tokens.SessionSecurityToken SessionToken { get { return default(System.IdentityModel.Tokens.SessionSecurityToken); } set { } }
    public bool WriteSessionCookie { get { return default(bool); } set { } }
  }
  public partial class SessionSecurityTokenReceivedEventArgs : System.ComponentModel.CancelEventArgs {
    public SessionSecurityTokenReceivedEventArgs(System.IdentityModel.Tokens.SessionSecurityToken sessionToken) { }
    public bool ReissueCookie { get { return default(bool); } set { } }
    public System.IdentityModel.Tokens.SessionSecurityToken SessionToken { get { return default(System.IdentityModel.Tokens.SessionSecurityToken); } set { } }
  }
  public partial class SessionSecurityTokenResolver : System.IdentityModel.Selectors.SecurityTokenResolver {
    public SessionSecurityTokenResolver(System.IdentityModel.Tokens.SessionSecurityTokenCache tokenCache, string endpointId) { }
    protected override bool TryResolveSecurityKeyCore(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause, out System.IdentityModel.Tokens.SecurityKey key) { key = default(System.IdentityModel.Tokens.SecurityKey); return default(bool); }
    protected override bool TryResolveTokenCore(System.IdentityModel.Tokens.SecurityKeyIdentifier keyIdentifier, out System.IdentityModel.Tokens.SecurityToken token) { token = default(System.IdentityModel.Tokens.SecurityToken); return default(bool); }
    protected override bool TryResolveTokenCore(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause, out System.IdentityModel.Tokens.SecurityToken token) { token = default(System.IdentityModel.Tokens.SecurityToken); return default(bool); }
  }
  public partial class SigningOutEventArgs : System.EventArgs {
    public SigningOutEventArgs(bool isIPInitiated) { }
    public static System.IdentityModel.Services.SigningOutEventArgs IPInitiated { get { return default(System.IdentityModel.Services.SigningOutEventArgs); } }
    public bool IsIPInitiated { get { return default(bool); } }
    public static System.IdentityModel.Services.SigningOutEventArgs RPInitiated { get { return default(System.IdentityModel.Services.SigningOutEventArgs); } }
  }
  public partial class SignInRequestMessage : System.IdentityModel.Services.WSFederationMessage {
    public SignInRequestMessage(System.Uri baseUrl, string realm) : base (default(System.Uri), default(string)) { }
    public SignInRequestMessage(System.Uri baseUrl, string realm, string reply) : base (default(System.Uri), default(string)) { }
    public string AuthenticationType { get { return default(string); } set { } }
    public string CurrentTime { get { return default(string); } set { } }
    public string Federation { get { return default(string); } set { } }
    public string Freshness { get { return default(string); } set { } }
    public string HomeRealm { get { return default(string); } set { } }
    public string Policy { get { return default(string); } set { } }
    public string Realm { get { return default(string); } set { } }
    public string Reply { get { return default(string); } set { } }
    public string Request { get { return default(string); } set { } }
    public string RequestPtr { get { return default(string); } set { } }
    public string RequestUrl { get { return default(string); } }
    public string Resource { get { return default(string); } set { } }
    protected override void Validate() { }
    public override void Write(System.IO.TextWriter writer) { }
  }
  public partial class SignInResponseMessage : System.IdentityModel.Services.WSFederationMessage {
    public SignInResponseMessage(System.Uri baseUrl, System.IdentityModel.Protocols.WSTrust.RequestSecurityTokenResponse response, System.IdentityModel.Services.WSFederationSerializer federationSerializer, System.IdentityModel.Protocols.WSTrust.WSTrustSerializationContext context) : base (default(System.Uri), default(string)) { }
    public SignInResponseMessage(System.Uri baseUrl, string result) : base (default(System.Uri), default(string)) { }
    public SignInResponseMessage(System.Uri baseUrl, System.Uri resultPtr) : base (default(System.Uri), default(string)) { }
    public string Result { get { return default(string); } set { } }
    public string ResultPtr { get { return default(string); } set { } }
    protected override void Validate() { }
    public override void Write(System.IO.TextWriter writer) { }
  }
  public partial class SignOutCleanupRequestMessage : System.IdentityModel.Services.WSFederationMessage {
    public SignOutCleanupRequestMessage(System.Uri baseUrl) : base (default(System.Uri), default(string)) { }
    public SignOutCleanupRequestMessage(System.Uri baseUrl, string reply) : base (default(System.Uri), default(string)) { }
    public string Reply { get { return default(string); } set { } }
    protected override void Validate() { }
    public override void Write(System.IO.TextWriter writer) { }
  }
  public partial class SignOutRequestMessage : System.IdentityModel.Services.WSFederationMessage {
    public SignOutRequestMessage(System.Uri baseUrl) : base (default(System.Uri), default(string)) { }
    public SignOutRequestMessage(System.Uri baseUrl, string reply) : base (default(System.Uri), default(string)) { }
    public string Reply { get { return default(string); } set { } }
    protected override void Validate() { }
    public override void Write(System.IO.TextWriter writer) { }
  }
  public partial class WSFederationAuthenticationModule : System.IdentityModel.Services.HttpModuleBase {
    public WSFederationAuthenticationModule() { }
    public string AuthenticationType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Freshness { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string HomeRealm { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Issuer { get { return default(string); } set { } }
    public bool PassiveRedirectEnabled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool PersistentCookiesOnPassiveRedirects { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Policy { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Realm { get { return default(string); } set { } }
    public string Reply { get { return default(string); } set { } }
    public string Request { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string RequestPtr { get { return default(string); } set { } }
    public bool RequireHttps { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Resource { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string SignInContext { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string SignInQueryString { get { return default(string); } set { } }
    public string SignOutQueryString { get { return default(string); } set { } }
    public string SignOutReply { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Xml.XmlDictionaryReaderQuotas XmlDictionaryReaderQuotas { get { return default(System.Xml.XmlDictionaryReaderQuotas); } set { } }
    public event System.EventHandler<System.IdentityModel.Services.AuthorizationFailedEventArgs> AuthorizationFailed { add { } remove { } }
    public event System.EventHandler<System.IdentityModel.Services.RedirectingToIdentityProviderEventArgs> RedirectingToIdentityProvider { add { } remove { } }
    public event System.EventHandler<System.IdentityModel.Services.SecurityTokenReceivedEventArgs> SecurityTokenReceived { add { } remove { } }
    public event System.EventHandler<System.IdentityModel.Services.SecurityTokenValidatedEventArgs> SecurityTokenValidated { add { } remove { } }
    public event System.EventHandler<System.IdentityModel.Services.SessionSecurityTokenCreatedEventArgs> SessionSecurityTokenCreated { add { } remove { } }
    public event System.EventHandler SignedIn { add { } remove { } }
    public event System.EventHandler SignedOut { add { } remove { } }
    public event System.EventHandler<System.IdentityModel.Services.ErrorEventArgs> SignInError { add { } remove { } }
    public event System.EventHandler<System.IdentityModel.Services.SigningOutEventArgs> SigningOut { add { } remove { } }
    public event System.EventHandler<System.IdentityModel.Services.ErrorEventArgs> SignOutError { add { } remove { } }
    public bool CanReadSignInResponse(System.Web.HttpRequestBase request) { return default(bool); }
    public virtual bool CanReadSignInResponse(System.Web.HttpRequestBase request, bool onPage) { return default(bool); }
    public System.IdentityModel.Services.SignInRequestMessage CreateSignInRequest(string uniqueId, string returnUrl, bool rememberMeSet) { return default(System.IdentityModel.Services.SignInRequestMessage); }
    public static void FederatedSignOut(System.Uri signOutUrl, System.Uri replyUrl) { }
    public static string GetFederationPassiveSignOutUrl(string issuer, string signOutReply, string signOutQueryString) { return default(string); }
    protected virtual string GetReferencedResult(string resultPtr) { return default(string); }
    protected virtual string GetReturnUrlFromResponse(System.Web.HttpRequestBase request) { return default(string); }
    public virtual System.IdentityModel.Tokens.SecurityToken GetSecurityToken(System.IdentityModel.Services.SignInResponseMessage message) { return default(System.IdentityModel.Tokens.SecurityToken); }
    public virtual System.IdentityModel.Tokens.SecurityToken GetSecurityToken(System.Web.HttpRequestBase request) { return default(System.IdentityModel.Tokens.SecurityToken); }
    protected virtual string GetSessionTokenContext() { return default(string); }
    public virtual System.IdentityModel.Services.SignInResponseMessage GetSignInResponseMessage(System.Web.HttpRequestBase request) { return default(System.IdentityModel.Services.SignInResponseMessage); }
    protected virtual string GetSignOutRedirectUrl(System.IdentityModel.Services.SignOutCleanupRequestMessage signOutMessage) { return default(string); }
    public virtual string GetXmlTokenFromMessage(System.IdentityModel.Services.SignInResponseMessage message) { return default(string); }
    public virtual string GetXmlTokenFromMessage(System.IdentityModel.Services.SignInResponseMessage message, System.IdentityModel.Services.WSFederationSerializer federationSerializer) { return default(string); }
    protected override void InitializeModule(System.Web.HttpApplication context) { }
    protected override void InitializePropertiesFromConfiguration() { }
    public virtual bool IsSignInResponse(System.Web.HttpRequestBase request) { return default(bool); }
    protected virtual void OnAuthenticateRequest(object sender, System.EventArgs args) { }
    protected virtual void OnAuthorizationFailed(System.IdentityModel.Services.AuthorizationFailedEventArgs e) { }
    protected virtual void OnEndRequest(object sender, System.EventArgs args) { }
    protected virtual void OnPostAuthenticateRequest(object sender, System.EventArgs e) { }
    protected virtual void OnRedirectingToIdentityProvider(System.IdentityModel.Services.RedirectingToIdentityProviderEventArgs e) { }
    protected virtual void OnSessionSecurityTokenCreated(System.IdentityModel.Services.SessionSecurityTokenCreatedEventArgs args) { }
    protected virtual void OnSignedIn(System.EventArgs args) { }
    protected virtual void OnSignedOut(System.EventArgs args) { }
    protected virtual void OnSignInError(System.IdentityModel.Services.ErrorEventArgs args) { }
    protected virtual void OnSigningOut(System.IdentityModel.Services.SigningOutEventArgs args) { }
    protected virtual void OnSignOutError(System.IdentityModel.Services.ErrorEventArgs args) { }
    public virtual void RedirectToIdentityProvider(string uniqueId, string returnUrl, bool persist) { }
    public void SetPrincipalAndWriteSessionToken(System.IdentityModel.Tokens.SessionSecurityToken sessionToken, bool isSession) { }
    public virtual void SignIn(string ControlId) { }
    public virtual void SignOut() { }
    public virtual void SignOut(bool isIPRequest) { }
    public virtual void SignOut(string redirectUrl) { }
    public virtual void SignOut(string redirectUrl, bool initiateSignoutCleanup) { }
    public void VerifyProperties() { }
  }
  public abstract partial class WSFederationMessage : System.IdentityModel.Services.FederationMessage {
    public WSFederationMessage(System.Uri baseUrl, string action) : base (default(System.Uri)) { }
    public string Action { get { return default(string); } set { } }
    public string Context { get { return default(string); } set { } }
    public string Encoding { get { return default(string); } set { } }
    public static System.IdentityModel.Services.WSFederationMessage CreateFromFormPost(System.Web.HttpRequestBase request) { return default(System.IdentityModel.Services.WSFederationMessage); }
    public static System.IdentityModel.Services.WSFederationMessage CreateFromNameValueCollection(System.Uri baseUrl, System.Collections.Specialized.NameValueCollection collection) { return default(System.IdentityModel.Services.WSFederationMessage); }
    public static System.IdentityModel.Services.WSFederationMessage CreateFromUri(System.Uri requestUri) { return default(System.IdentityModel.Services.WSFederationMessage); }
    public static bool TryCreateFromUri(System.Uri requestUri, out System.IdentityModel.Services.WSFederationMessage fedMsg) { fedMsg = default(System.IdentityModel.Services.WSFederationMessage); return default(bool); }
  }
  public partial class WSFederationMessageException : System.Exception {
    public WSFederationMessageException() { }
    protected WSFederationMessageException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public WSFederationMessageException(string message) { }
    public WSFederationMessageException(string message, System.Exception inner) { }
  }
  public partial class WSFederationSerializer {
    public WSFederationSerializer() { }
    public WSFederationSerializer(System.IdentityModel.Protocols.WSTrust.WSTrustRequestSerializer requestSerializer, System.IdentityModel.Protocols.WSTrust.WSTrustResponseSerializer responseSerializer) { }
    public WSFederationSerializer(System.Xml.XmlDictionaryReader reader) { }
    public virtual bool CanReadRequest(string trustMessage) { return default(bool); }
    public virtual bool CanReadResponse(string trustMessage) { return default(bool); }
    public virtual System.IdentityModel.Protocols.WSTrust.RequestSecurityToken CreateRequest(System.IdentityModel.Services.FederationMessage message, System.IdentityModel.Protocols.WSTrust.WSTrustSerializationContext context) { return default(System.IdentityModel.Protocols.WSTrust.RequestSecurityToken); }
    public virtual System.IdentityModel.Protocols.WSTrust.RequestSecurityTokenResponse CreateResponse(System.IdentityModel.Services.FederationMessage message, System.IdentityModel.Protocols.WSTrust.WSTrustSerializationContext context) { return default(System.IdentityModel.Protocols.WSTrust.RequestSecurityTokenResponse); }
    public virtual string GetReferencedRequest(string wreqptr) { return default(string); }
    public virtual string GetReferencedResult(string wresultptr) { return default(string); }
    public virtual string GetRequestAsString(System.IdentityModel.Protocols.WSTrust.RequestSecurityToken request, System.IdentityModel.Protocols.WSTrust.WSTrustSerializationContext context) { return default(string); }
    public virtual string GetResponseAsString(System.IdentityModel.Protocols.WSTrust.RequestSecurityTokenResponse response, System.IdentityModel.Protocols.WSTrust.WSTrustSerializationContext context) { return default(string); }
  }
}
namespace System.IdentityModel.Services.Configuration {
  public partial class FederationConfiguration {
    public static readonly string DefaultFederationConfigurationName;
    public FederationConfiguration() { }
    public FederationConfiguration(bool loadConfig) { }
    public FederationConfiguration(string federationConfigurationName) { }
    public System.IdentityModel.Services.CookieHandler CookieHandler { get { return default(System.IdentityModel.Services.CookieHandler); } set { } }
    public System.Xml.XmlElement CustomElement { get { return default(System.Xml.XmlElement); } set { } }
    public System.IdentityModel.Configuration.IdentityConfiguration IdentityConfiguration { get { return default(System.IdentityModel.Configuration.IdentityConfiguration); } set { } }
    public virtual bool IsInitialized { get { return default(bool); } protected set { } }
    public string Name { get { return default(string); } }
    public System.Security.Cryptography.X509Certificates.X509Certificate2 ServiceCertificate { get { return default(System.Security.Cryptography.X509Certificates.X509Certificate2); } set { } }
    public System.IdentityModel.Services.Configuration.WsFederationConfiguration WsFederationConfiguration { get { return default(System.IdentityModel.Services.Configuration.WsFederationConfiguration); } set { } }
    public virtual void Initialize() { }
    protected void LoadConfiguration(System.IdentityModel.Services.Configuration.FederationConfigurationElement element) { }
  }
  public partial class FederationConfigurationCreatedEventArgs : System.EventArgs {
    public FederationConfigurationCreatedEventArgs(System.IdentityModel.Services.Configuration.FederationConfiguration config) { }
    public System.IdentityModel.Services.Configuration.FederationConfiguration FederationConfiguration { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.IdentityModel.Services.Configuration.FederationConfiguration); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public sealed partial class FederationConfigurationElement : System.Configuration.ConfigurationElement {
    public FederationConfigurationElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("cookieHandler", IsRequired=false)]
    public System.IdentityModel.Services.CookieHandlerElement CookieHandler { get { return default(System.IdentityModel.Services.CookieHandlerElement); } set { } }
    public System.Xml.XmlElement CustomElement { get { return default(System.Xml.XmlElement); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("identityConfigurationName", DefaultValue="", IsRequired=false)]
    public string IdentityConfigurationName { get { return default(string); } set { } }
    public bool IsConfigured { get { return default(bool); } }
    [System.Configuration.ConfigurationPropertyAttribute("name", Options=(System.Configuration.ConfigurationPropertyOptions)(4))]
    public string Name { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("serviceCertificate", IsRequired=false)]
    public System.IdentityModel.Services.ServiceCertificateElement ServiceCertificate { get { return default(System.IdentityModel.Services.ServiceCertificateElement); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("wsFederation", IsRequired=false)]
    public System.IdentityModel.Services.Configuration.WSFederationElement WsFederation { get { return default(System.IdentityModel.Services.Configuration.WSFederationElement); } set { } }
    protected override bool OnDeserializeUnrecognizedElement(string elementName, System.Xml.XmlReader reader) { return default(bool); }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.IdentityModel.Services.Configuration.FederationConfigurationElement), AddItemName="federationConfiguration", CollectionType=(System.Configuration.ConfigurationElementCollectionType)(0))]
  public sealed partial class FederationConfigurationElementCollection : System.Configuration.ConfigurationElementCollection {
    public FederationConfigurationElementCollection() { }
    protected override bool ThrowOnDuplicate { get { return default(bool); } }
    protected override void BaseAdd(System.Configuration.ConfigurationElement element) { }
    protected override System.Configuration.ConfigurationElement CreateNewElement() { return default(System.Configuration.ConfigurationElement); }
    public System.IdentityModel.Services.Configuration.FederationConfigurationElement GetElement(string name) { return default(System.IdentityModel.Services.Configuration.FederationConfigurationElement); }
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
  }
  public sealed partial class SystemIdentityModelServicesSection : System.Configuration.ConfigurationSection {
    public const string SectionName = "system.identityModel.services";
    public SystemIdentityModelServicesSection() { }
    public static System.IdentityModel.Services.Configuration.SystemIdentityModelServicesSection Current { get { return default(System.IdentityModel.Services.Configuration.SystemIdentityModelServicesSection); } }
    public static System.IdentityModel.Services.Configuration.FederationConfigurationElement DefaultFederationConfigurationElement { get { return default(System.IdentityModel.Services.Configuration.FederationConfigurationElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("", Options=(System.Configuration.ConfigurationPropertyOptions)(1))]
    public System.IdentityModel.Services.Configuration.FederationConfigurationElementCollection FederationConfigurationElements { get { return default(System.IdentityModel.Services.Configuration.FederationConfigurationElementCollection); } }
  }
  public partial class WsFederationConfiguration {
    public const string DefaultFreshness = null;
    public const int DefaultMaxArrayLength = 2097152;
    public const int DefaultMaxStringContentLength = 2097152;
    public const bool DefaultPassiveRedirectEnabled = true;
    public const bool DefaultPersistentCookiesOnPassiveRedirects = false;
    public const bool DefaultRequireHttps = true;
    public WsFederationConfiguration(System.IdentityModel.Services.Configuration.WSFederationElement federationElement) { }
    public WsFederationConfiguration(string issuer, string realm) { }
    public string AuthenticationType { get { return default(string); } set { } }
    public System.Collections.Generic.Dictionary<System.String, System.String> CustomAttributes { get { return default(System.Collections.Generic.Dictionary<System.String, System.String>); } }
    public string Freshness { get { return default(string); } set { } }
    public string HomeRealm { get { return default(string); } set { } }
    public string Issuer { get { return default(string); } set { } }
    public bool PassiveRedirectEnabled { get { return default(bool); } set { } }
    public bool PersistentCookiesOnPassiveRedirects { get { return default(bool); } set { } }
    public string Policy { get { return default(string); } set { } }
    public string Realm { get { return default(string); } set { } }
    public string Reply { get { return default(string); } set { } }
    public string Request { get { return default(string); } set { } }
    public string RequestPtr { get { return default(string); } set { } }
    public bool RequireHttps { get { return default(bool); } set { } }
    public string Resource { get { return default(string); } set { } }
    public string SignInQueryString { get { return default(string); } set { } }
    public string SignOutQueryString { get { return default(string); } set { } }
    public string SignOutReply { get { return default(string); } set { } }
    public System.Xml.XmlDictionaryReaderQuotas XmlDictionaryReaderQuotas { get { return default(System.Xml.XmlDictionaryReaderQuotas); } set { } }
  }
  public sealed partial class WSFederationElement : System.Configuration.ConfigurationElement {
    public WSFederationElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("authenticationType", IsRequired=false)]
    public string AuthenticationType { get { return default(string); } set { } }
    public System.Collections.Generic.Dictionary<System.String, System.String> CustomAttributes { get { return default(System.Collections.Generic.Dictionary<System.String, System.String>); } }
    [System.Configuration.ConfigurationPropertyAttribute("freshness", DefaultValue=null, IsRequired=false)]
    public string Freshness { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("homeRealm", IsRequired=false)]
    public string HomeRealm { get { return default(string); } set { } }
    public bool IsConfigured { get { return default(bool); } }
    [System.Configuration.ConfigurationPropertyAttribute("issuer", IsRequired=true)]
    public string Issuer { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("passiveRedirectEnabled", DefaultValue=true, IsRequired=false)]
    public bool PassiveRedirectEnabled { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("persistentCookiesOnPassiveRedirects", DefaultValue=false, IsRequired=false)]
    public bool PersistentCookiesOnPassiveRedirects { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("policy", IsRequired=false)]
    public string Policy { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("realm", IsRequired=true)]
    public string Realm { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("reply", IsRequired=false)]
    public string Reply { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("request", IsRequired=false)]
    public string Request { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("requestPtr", IsRequired=false)]
    public string RequestPtr { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("requireHttps", DefaultValue=true, IsRequired=false)]
    public bool RequireHttps { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("resource", IsRequired=false)]
    public string Resource { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("signInQueryString", IsRequired=false)]
    public string SignInQueryString { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("signOutQueryString", IsRequired=false)]
    public string SignOutQueryString { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("signOutReply", IsRequired=false)]
    public string SignOutReply { get { return default(string); } set { } }
    protected override bool OnDeserializeUnrecognizedAttribute(string name, string value) { return default(bool); }
  }
}
namespace System.IdentityModel.Services.Tokens {
  public partial class MachineKeySessionSecurityTokenHandler : System.IdentityModel.Tokens.SessionSecurityTokenHandler {
    public MachineKeySessionSecurityTokenHandler() { }
    public MachineKeySessionSecurityTokenHandler(System.TimeSpan tokenLifetime) { }
  }
  public partial class MembershipUserNameSecurityTokenHandler : System.IdentityModel.Tokens.UserNameSecurityTokenHandler {
    public MembershipUserNameSecurityTokenHandler() { }
    public MembershipUserNameSecurityTokenHandler(System.Web.Security.MembershipProvider provider) { }
    public override bool CanValidateToken { get { return default(bool); } }
    public System.Web.Security.MembershipProvider MembershipProvider { get { return default(System.Web.Security.MembershipProvider); } set { } }
    public override void LoadCustomConfiguration(System.Xml.XmlNodeList customConfigElements) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public override System.Collections.ObjectModel.ReadOnlyCollection<System.Security.Claims.ClaimsIdentity> ValidateToken(System.IdentityModel.Tokens.SecurityToken token) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Security.Claims.ClaimsIdentity>); }
  }
}
