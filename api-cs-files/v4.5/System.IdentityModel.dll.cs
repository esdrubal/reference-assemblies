namespace System.IdentityModel {
  public abstract partial class CookieTransform {
    protected CookieTransform() { }
    public abstract System.Byte[] Encode(System.Byte[] value);
  }
  public abstract partial class OpenObject {
    protected OpenObject() { }
    public System.Collections.Generic.Dictionary<System.String, System.Object> Properties { get { return default(System.Collections.Generic.Dictionary<System.String, System.Object>); } }
  }
  public partial class SignatureVerificationFailedException : System.Exception {
    public SignatureVerificationFailedException() { }
    public SignatureVerificationFailedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public SignatureVerificationFailedException(string message) { }
    public SignatureVerificationFailedException(string message, System.Exception innerException) { }
  }
}
namespace System.IdentityModel.Claims {
  [System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.xmlsoap.org/ws/2005/05/identity")]
  public partial class Claim {
    public Claim(string claimType, object resource, string right) { }
    public string ClaimType { get { return default(string); } }
    public static System.Collections.Generic.IEqualityComparer<System.IdentityModel.Claims.Claim> DefaultComparer { get { return default(System.Collections.Generic.IEqualityComparer<System.IdentityModel.Claims.Claim>); } }
    public object Resource { get { return default(object); } }
    public string Right { get { return default(string); } }
    public static System.IdentityModel.Claims.Claim System { get { return default(System.IdentityModel.Claims.Claim); } }
    [System.MonoTODOAttribute]
    public static System.IdentityModel.Claims.Claim CreateDenyOnlyWindowsSidClaim(System.Security.Principal.SecurityIdentifier identifier) { return default(System.IdentityModel.Claims.Claim); }
    public static System.IdentityModel.Claims.Claim CreateDnsClaim(string dns) { return default(System.IdentityModel.Claims.Claim); }
    public static System.IdentityModel.Claims.Claim CreateHashClaim(System.Byte[] hash) { return default(System.IdentityModel.Claims.Claim); }
    public static System.IdentityModel.Claims.Claim CreateMailAddressClaim(System.Net.Mail.MailAddress mailAddress) { return default(System.IdentityModel.Claims.Claim); }
    public static System.IdentityModel.Claims.Claim CreateNameClaim(string name) { return default(System.IdentityModel.Claims.Claim); }
    public static System.IdentityModel.Claims.Claim CreateRsaClaim(System.Security.Cryptography.RSA rsa) { return default(System.IdentityModel.Claims.Claim); }
    public static System.IdentityModel.Claims.Claim CreateSpnClaim(string spn) { return default(System.IdentityModel.Claims.Claim); }
    public static System.IdentityModel.Claims.Claim CreateThumbprintClaim(System.Byte[] thumbprint) { return default(System.IdentityModel.Claims.Claim); }
    public static System.IdentityModel.Claims.Claim CreateUpnClaim(string upn) { return default(System.IdentityModel.Claims.Claim); }
    public static System.IdentityModel.Claims.Claim CreateUriClaim(System.Uri uri) { return default(System.IdentityModel.Claims.Claim); }
    public static System.IdentityModel.Claims.Claim CreateWindowsSidClaim(System.Security.Principal.SecurityIdentifier sid) { return default(System.IdentityModel.Claims.Claim); }
    public static System.IdentityModel.Claims.Claim CreateX500DistinguishedNameClaim(System.Security.Cryptography.X509Certificates.X500DistinguishedName x500DistinguishedName) { return default(System.IdentityModel.Claims.Claim); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
  }
  [System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.xmlsoap.org/ws/2005/05/identity")]
  public abstract partial class ClaimSet : System.Collections.Generic.IEnumerable<System.IdentityModel.Claims.Claim>, System.Collections.IEnumerable {
    protected ClaimSet() { }
    public abstract int Count { get; }
    public abstract System.IdentityModel.Claims.ClaimSet Issuer { get; }
    public abstract System.IdentityModel.Claims.Claim this[int index] { get; }
    public static System.IdentityModel.Claims.ClaimSet System { get { return default(System.IdentityModel.Claims.ClaimSet); } }
    [System.MonoTODOAttribute]
    public static System.IdentityModel.Claims.ClaimSet Windows { get { return default(System.IdentityModel.Claims.ClaimSet); } }
    public virtual bool ContainsClaim(System.IdentityModel.Claims.Claim claim) { return default(bool); }
    public virtual bool ContainsClaim(System.IdentityModel.Claims.Claim claim, System.Collections.Generic.IEqualityComparer<System.IdentityModel.Claims.Claim> comparer) { return default(bool); }
    public abstract System.Collections.Generic.IEnumerable<System.IdentityModel.Claims.Claim> FindClaims(string resourceType, string right);
    public abstract System.Collections.Generic.IEnumerator<System.IdentityModel.Claims.Claim> GetEnumerator();
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public static partial class ClaimTypes {
    public static string Anonymous { get { return default(string); } }
    public static string Authentication { get { return default(string); } }
    public static string AuthorizationDecision { get { return default(string); } }
    public static string Country { get { return default(string); } }
    public static string DateOfBirth { get { return default(string); } }
    public static string DenyOnlySid { get { return default(string); } }
    public static string Dns { get { return default(string); } }
    public static string Email { get { return default(string); } }
    public static string Gender { get { return default(string); } }
    public static string GivenName { get { return default(string); } }
    public static string Hash { get { return default(string); } }
    public static string HomePhone { get { return default(string); } }
    public static string Locality { get { return default(string); } }
    public static string MobilePhone { get { return default(string); } }
    public static string Name { get { return default(string); } }
    public static string NameIdentifier { get { return default(string); } }
    public static string OtherPhone { get { return default(string); } }
    public static string PostalCode { get { return default(string); } }
    public static string PPID { get { return default(string); } }
    public static string Rsa { get { return default(string); } }
    public static string Sid { get { return default(string); } }
    public static string Spn { get { return default(string); } }
    public static string StateOrProvince { get { return default(string); } }
    public static string StreetAddress { get { return default(string); } }
    public static string Surname { get { return default(string); } }
    public static string System { get { return default(string); } }
    public static string Thumbprint { get { return default(string); } }
    public static string Upn { get { return default(string); } }
    public static string Uri { get { return default(string); } }
    public static string Webpage { get { return default(string); } }
    public static string X500DistinguishedName { get { return default(string); } }
  }
  [System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.xmlsoap.org/ws/2005/05/identity")]
  public partial class DefaultClaimSet : System.IdentityModel.Claims.ClaimSet {
    public DefaultClaimSet(System.Collections.Generic.IList<System.IdentityModel.Claims.Claim> claims) { }
    public DefaultClaimSet(params System.IdentityModel.Claims.Claim[] claims) { }
    public DefaultClaimSet(System.IdentityModel.Claims.ClaimSet issuer, System.Collections.Generic.IList<System.IdentityModel.Claims.Claim> claims) { }
    public DefaultClaimSet(System.IdentityModel.Claims.ClaimSet issuer, params System.IdentityModel.Claims.Claim[] claims) { }
    public override int Count { get { return default(int); } }
    public override System.IdentityModel.Claims.ClaimSet Issuer { get { return default(System.IdentityModel.Claims.ClaimSet); } }
    public override System.IdentityModel.Claims.Claim this[int index] { get { return default(System.IdentityModel.Claims.Claim); } }
    public override bool ContainsClaim(System.IdentityModel.Claims.Claim claim) { return default(bool); }
    public override System.Collections.Generic.IEnumerable<System.IdentityModel.Claims.Claim> FindClaims(string claimType, string right) { return default(System.Collections.Generic.IEnumerable<System.IdentityModel.Claims.Claim>); }
    public override System.Collections.Generic.IEnumerator<System.IdentityModel.Claims.Claim> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.IdentityModel.Claims.Claim>); }
    protected void Initialize(System.IdentityModel.Claims.ClaimSet issuer, System.Collections.Generic.IList<System.IdentityModel.Claims.Claim> claims) { }
    [System.MonoTODOAttribute]
    public override string ToString() { return default(string); }
  }
  public static partial class Rights {
    public static string Identity { get { return default(string); } }
    public static string PossessProperty { get { return default(string); } }
  }
  public partial class WindowsClaimSet : System.IdentityModel.Claims.ClaimSet, System.IDisposable {
    [System.MonoTODOAttribute]
    public WindowsClaimSet(System.Security.Principal.WindowsIdentity identity) { }
    [System.MonoTODOAttribute]
    public WindowsClaimSet(System.Security.Principal.WindowsIdentity identity, bool includeWindowsGroups) { }
    [System.MonoTODOAttribute]
    public WindowsClaimSet(System.Security.Principal.WindowsIdentity identity, bool includeWindowsGroups, System.DateTime expirationTime) { }
    [System.MonoTODOAttribute]
    public WindowsClaimSet(System.Security.Principal.WindowsIdentity identity, System.DateTime expirationTime) { }
    public override int Count { get { return default(int); } }
    public System.DateTime ExpirationTime { get { return default(System.DateTime); } }
    public override System.IdentityModel.Claims.ClaimSet Issuer { get { return default(System.IdentityModel.Claims.ClaimSet); } }
    public override System.IdentityModel.Claims.Claim this[int index] { get { return default(System.IdentityModel.Claims.Claim); } }
    public System.Security.Principal.WindowsIdentity WindowsIdentity { get { return default(System.Security.Principal.WindowsIdentity); } }
    [System.MonoTODOAttribute]
    public void Dispose() { }
    [System.MonoTODOAttribute]
    public override System.Collections.Generic.IEnumerable<System.IdentityModel.Claims.Claim> FindClaims(string claimType, string right) { return default(System.Collections.Generic.IEnumerable<System.IdentityModel.Claims.Claim>); }
    [System.MonoTODOAttribute]
    public override System.Collections.Generic.IEnumerator<System.IdentityModel.Claims.Claim> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.IdentityModel.Claims.Claim>); }
    public override string ToString() { return default(string); }
  }
  public partial class X509CertificateClaimSet : System.IdentityModel.Claims.ClaimSet, System.IDisposable {
    public X509CertificateClaimSet(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
    public override int Count { get { return default(int); } }
    [System.MonoTODOAttribute("use ParseExact")]
    public System.DateTime ExpirationTime { get { return default(System.DateTime); } }
    public override System.IdentityModel.Claims.ClaimSet Issuer { get { return default(System.IdentityModel.Claims.ClaimSet); } }
    public override System.IdentityModel.Claims.Claim this[int index] { get { return default(System.IdentityModel.Claims.Claim); } }
    public System.Security.Cryptography.X509Certificates.X509Certificate2 X509Certificate { get { return default(System.Security.Cryptography.X509Certificates.X509Certificate2); } }
    [System.MonoTODOAttribute]
    public void Dispose() { }
    [System.MonoTODOAttribute]
    public override System.Collections.Generic.IEnumerable<System.IdentityModel.Claims.Claim> FindClaims(string claimType, string right) { return default(System.Collections.Generic.IEnumerable<System.IdentityModel.Claims.Claim>); }
    public override System.Collections.Generic.IEnumerator<System.IdentityModel.Claims.Claim> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.IdentityModel.Claims.Claim>); }
    [System.MonoTODOAttribute]
    public override string ToString() { return default(string); }
  }
}
namespace System.IdentityModel.Configuration {
  public partial interface ICustomIdentityConfiguration {
    void LoadCustomConfiguration(System.Xml.XmlNodeList nodeList);
  }
  public sealed partial class IdentityModelCaches {
    public IdentityModelCaches() { }
    public System.IdentityModel.Tokens.SessionSecurityTokenCache SessionSecurityTokenCache { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.IdentityModel.Tokens.SessionSecurityTokenCache); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.IdentityModel.Tokens.TokenReplayCache TokenReplayCache { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.IdentityModel.Tokens.TokenReplayCache); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
}
namespace System.IdentityModel.Policy {
  public abstract partial class AuthorizationContext : System.IdentityModel.Policy.IAuthorizationComponent {
    protected AuthorizationContext() { }
    public abstract System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Claims.ClaimSet> ClaimSets { get; }
    public abstract System.DateTime ExpirationTime { get; }
    public abstract string Id { get; }
    public abstract System.Collections.Generic.IDictionary<System.String, System.Object> Properties { get; }
    [System.MonoTODOAttribute]
    public static System.IdentityModel.Policy.AuthorizationContext CreateDefaultAuthorizationContext(System.Collections.Generic.IList<System.IdentityModel.Policy.IAuthorizationPolicy> policies) { return default(System.IdentityModel.Policy.AuthorizationContext); }
  }
  public abstract partial class EvaluationContext {
    protected EvaluationContext() { }
    public abstract System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Claims.ClaimSet> ClaimSets { get; }
    public abstract int Generation { get; }
    public abstract System.Collections.Generic.IDictionary<System.String, System.Object> Properties { get; }
    public abstract void AddClaimSet(System.IdentityModel.Policy.IAuthorizationPolicy authorizationPolicy, System.IdentityModel.Claims.ClaimSet claimSet);
    public abstract void RecordExpirationTime(System.DateTime time);
  }
  public partial interface IAuthorizationComponent {
    string Id { get; }
  }
  public partial interface IAuthorizationPolicy : System.IdentityModel.Policy.IAuthorizationComponent {
    System.IdentityModel.Claims.ClaimSet Issuer { get; }
    bool Evaluate(System.IdentityModel.Policy.EvaluationContext evaluationContext, ref object state);
  }
}
namespace System.IdentityModel.Protocols.WSTrust {
  public partial class BinaryExchange {
    public BinaryExchange(System.Byte[] binaryData, System.Uri valueType) { }
    public BinaryExchange(System.Byte[] binaryData, System.Uri valueType, System.Uri encodingType) { }
    public System.Byte[] BinaryData { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Byte[]); } }
    public System.Uri EncodingType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Uri); } }
    public System.Uri ValueType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Uri); } }
  }
  public partial class EndpointReference {
    public EndpointReference(string uri) { }
    public System.Collections.ObjectModel.Collection<System.Xml.XmlElement> Details { get { return default(System.Collections.ObjectModel.Collection<System.Xml.XmlElement>); } }
    public System.Uri Uri { get { return default(System.Uri); } }
    [System.MonoTODOAttribute]
    public static System.IdentityModel.Protocols.WSTrust.EndpointReference ReadFrom(System.Xml.XmlDictionaryReader reader) { return default(System.IdentityModel.Protocols.WSTrust.EndpointReference); }
    [System.MonoTODOAttribute]
    public static System.IdentityModel.Protocols.WSTrust.EndpointReference ReadFrom(System.Xml.XmlReader reader) { return default(System.IdentityModel.Protocols.WSTrust.EndpointReference); }
    [System.MonoTODOAttribute]
    public void WriteTo(System.Xml.XmlWriter writer) { }
  }
  public partial class Entropy : System.IdentityModel.Protocols.WSTrust.ProtectedKey {
    public Entropy(System.Byte[] secret) : base (default(System.Byte[])) { }
    public Entropy(System.Byte[] secret, System.IdentityModel.Tokens.EncryptingCredentials wrappingCredentials) : base (default(System.Byte[])) { }
    public Entropy(System.IdentityModel.Protocols.WSTrust.ProtectedKey protectedKey) : base (default(System.Byte[])) { }
    public Entropy(int entropySizeInBits) : base (default(System.Byte[])) { }
  }
  public partial class Lifetime {
    public Lifetime(System.DateTime created, System.DateTime expires) { }
    public Lifetime(System.Nullable<System.DateTime> created, System.Nullable<System.DateTime> expires) { }
    public System.Nullable<System.DateTime> Created { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.DateTime>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Nullable<System.DateTime> Expires { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.DateTime>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial class ProtectedKey {
    public ProtectedKey(System.Byte[] secret) { }
    public ProtectedKey(System.Byte[] secret, System.IdentityModel.Tokens.EncryptingCredentials wrappingCredentials) { }
    public System.IdentityModel.Tokens.EncryptingCredentials WrappingCredentials { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.IdentityModel.Tokens.EncryptingCredentials); } }
    public System.Byte[] GetKeyBytes() { return default(System.Byte[]); }
  }
  public partial class RequestedProofToken {
    public RequestedProofToken(System.Byte[] secret) { }
    public RequestedProofToken(System.Byte[] secret, System.IdentityModel.Tokens.EncryptingCredentials wrappingCredentials) { }
    public RequestedProofToken(System.IdentityModel.Protocols.WSTrust.ProtectedKey protectedKey) { }
    public RequestedProofToken(string computedKeyAlgorithm) { }
    public string ComputedKeyAlgorithm { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public System.IdentityModel.Protocols.WSTrust.ProtectedKey ProtectedKey { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.IdentityModel.Protocols.WSTrust.ProtectedKey); } }
  }
  public partial class RequestedSecurityToken {
    public RequestedSecurityToken(System.IdentityModel.Tokens.SecurityToken token) { }
    public RequestedSecurityToken(System.Xml.XmlElement tokenAsXml) { }
    public System.IdentityModel.Tokens.SecurityToken SecurityToken { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.IdentityModel.Tokens.SecurityToken); } }
    public virtual System.Xml.XmlElement SecurityTokenXml { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xml.XmlElement); } }
  }
  public partial class RequestSecurityTokenResponse : System.IdentityModel.Protocols.WSTrust.WSTrustMessage {
    public RequestSecurityTokenResponse() { }
    public RequestSecurityTokenResponse(System.IdentityModel.Protocols.WSTrust.WSTrustMessage message) { }
    public bool IsFinal { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.IdentityModel.Tokens.SecurityKeyIdentifierClause RequestedAttachedReference { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.IdentityModel.Tokens.SecurityKeyIdentifierClause); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.IdentityModel.Protocols.WSTrust.RequestedProofToken RequestedProofToken { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.IdentityModel.Protocols.WSTrust.RequestedProofToken); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.IdentityModel.Protocols.WSTrust.RequestedSecurityToken RequestedSecurityToken { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.IdentityModel.Protocols.WSTrust.RequestedSecurityToken); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool RequestedTokenCancelled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.IdentityModel.Tokens.SecurityKeyIdentifierClause RequestedUnattachedReference { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.IdentityModel.Tokens.SecurityKeyIdentifierClause); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.IdentityModel.Protocols.WSTrust.Status Status { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.IdentityModel.Protocols.WSTrust.Status); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial class Status {
    public Status(string code, string reason) { }
    public string Code { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Reason { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial class UseKey {
    public UseKey() { }
    public UseKey(System.IdentityModel.Tokens.SecurityKeyIdentifier ski) { }
    public UseKey(System.IdentityModel.Tokens.SecurityKeyIdentifier ski, System.IdentityModel.Tokens.SecurityToken token) { }
    public UseKey(System.IdentityModel.Tokens.SecurityToken token) { }
    public System.IdentityModel.Tokens.SecurityKeyIdentifier SecurityKeyIdentifier { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.IdentityModel.Tokens.SecurityKeyIdentifier); } }
    public System.IdentityModel.Tokens.SecurityToken Token { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.IdentityModel.Tokens.SecurityToken); } }
  }
  public abstract partial class WSTrustMessage : System.IdentityModel.OpenObject {
    protected WSTrustMessage() { }
    public bool AllowPostdating { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.IdentityModel.Protocols.WSTrust.EndpointReference AppliesTo { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.IdentityModel.Protocols.WSTrust.EndpointReference); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string AuthenticationType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.IdentityModel.Protocols.WSTrust.BinaryExchange BinaryExchange { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.IdentityModel.Protocols.WSTrust.BinaryExchange); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string CanonicalizationAlgorithm { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Context { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string EncryptionAlgorithm { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string EncryptWith { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.IdentityModel.Protocols.WSTrust.Entropy Entropy { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.IdentityModel.Protocols.WSTrust.Entropy); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Nullable<System.Int32> KeySizeInBits { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.Int32>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string KeyType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string KeyWrapAlgorithm { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.IdentityModel.Protocols.WSTrust.Lifetime Lifetime { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.IdentityModel.Protocols.WSTrust.Lifetime); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string ReplyTo { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string RequestType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string SignatureAlgorithm { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string SignWith { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string TokenType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.IdentityModel.Protocols.WSTrust.UseKey UseKey { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.IdentityModel.Protocols.WSTrust.UseKey); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
}
namespace System.IdentityModel.Selectors {
  public enum AudienceUriMode {
    Always = 1,
    BearerKeyOnly = 2,
    Never = 0,
  }
  public partial class CustomUserNameSecurityTokenAuthenticator : System.IdentityModel.Selectors.UserNameSecurityTokenAuthenticator {
    public CustomUserNameSecurityTokenAuthenticator(System.IdentityModel.Selectors.UserNamePasswordValidator validator) { }
    protected override System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy> ValidateUserNamePasswordCore(string userName, string password) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy>); }
  }
  public partial class KerberosSecurityTokenAuthenticator : System.IdentityModel.Selectors.WindowsSecurityTokenAuthenticator {
    [System.MonoTODOAttribute]
    public KerberosSecurityTokenAuthenticator() { }
    [System.MonoTODOAttribute]
    public KerberosSecurityTokenAuthenticator(bool includeWindowsGroups) { }
    [System.MonoTODOAttribute]
    protected override bool CanValidateTokenCore(System.IdentityModel.Tokens.SecurityToken token) { return default(bool); }
  }
  public partial class KerberosSecurityTokenProvider : System.IdentityModel.Selectors.SecurityTokenProvider {
    public KerberosSecurityTokenProvider(string servicePrincipalName) { }
    [System.MonoTODOAttribute]
    public KerberosSecurityTokenProvider(string servicePrincipalName, System.Security.Principal.TokenImpersonationLevel tokenImpersonationLevel) { }
    [System.MonoTODOAttribute]
    public KerberosSecurityTokenProvider(string servicePrincipalName, System.Security.Principal.TokenImpersonationLevel tokenImpersonationLevel, System.Net.NetworkCredential credential) { }
    public System.Net.NetworkCredential NetworkCredential { get { return default(System.Net.NetworkCredential); } }
    public string ServicePrincipalName { get { return default(string); } }
    public System.Security.Principal.TokenImpersonationLevel TokenImpersonationLevel { get { return default(System.Security.Principal.TokenImpersonationLevel); } }
    [System.MonoTODOAttribute]
    protected override System.IdentityModel.Tokens.SecurityToken GetTokenCore(System.TimeSpan timeout) { return default(System.IdentityModel.Tokens.SecurityToken); }
  }
  public partial class RsaSecurityTokenAuthenticator : System.IdentityModel.Selectors.SecurityTokenAuthenticator {
    public RsaSecurityTokenAuthenticator() { }
    protected override bool CanValidateTokenCore(System.IdentityModel.Tokens.SecurityToken token) { return default(bool); }
    [System.MonoTODOAttribute("hmm, what to validate?")]
    protected override System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy> ValidateTokenCore(System.IdentityModel.Tokens.SecurityToken token) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy>); }
  }
  public partial class SamlSecurityTokenAuthenticator : System.IdentityModel.Selectors.SecurityTokenAuthenticator {
    public SamlSecurityTokenAuthenticator(System.Collections.Generic.IList<System.IdentityModel.Selectors.SecurityTokenAuthenticator> supportingAuthenticators) { }
    public SamlSecurityTokenAuthenticator(System.Collections.Generic.IList<System.IdentityModel.Selectors.SecurityTokenAuthenticator> supportingAuthenticators, System.TimeSpan maxClockSkew) { }
    protected override bool CanValidateTokenCore(System.IdentityModel.Tokens.SecurityToken token) { return default(bool); }
    [System.MonoTODOAttribute]
    public virtual System.IdentityModel.Claims.ClaimSet ResolveClaimSet(System.IdentityModel.Tokens.SecurityKeyIdentifier keyIdentifier) { return default(System.IdentityModel.Claims.ClaimSet); }
    public virtual System.IdentityModel.Claims.ClaimSet ResolveClaimSet(System.IdentityModel.Tokens.SecurityToken token) { return default(System.IdentityModel.Claims.ClaimSet); }
    [System.MonoTODOAttribute]
    public virtual System.Security.Principal.IIdentity ResolveIdentity(System.IdentityModel.Tokens.SecurityKeyIdentifier keyIdentifier) { return default(System.Security.Principal.IIdentity); }
    public virtual System.Security.Principal.IIdentity ResolveIdentity(System.IdentityModel.Tokens.SecurityToken token) { return default(System.Security.Principal.IIdentity); }
    [System.MonoTODOAttribute]
    protected override System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy> ValidateTokenCore(System.IdentityModel.Tokens.SecurityToken token) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy>); }
  }
  public abstract partial class SecurityTokenAuthenticator {
    protected SecurityTokenAuthenticator() { }
    public bool CanValidateToken(System.IdentityModel.Tokens.SecurityToken token) { return default(bool); }
    protected abstract bool CanValidateTokenCore(System.IdentityModel.Tokens.SecurityToken token);
    public System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy> ValidateToken(System.IdentityModel.Tokens.SecurityToken token) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy>); }
    protected abstract System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy> ValidateTokenCore(System.IdentityModel.Tokens.SecurityToken token);
  }
  public abstract partial class SecurityTokenManager {
    protected SecurityTokenManager() { }
    public abstract System.IdentityModel.Selectors.SecurityTokenAuthenticator CreateSecurityTokenAuthenticator(System.IdentityModel.Selectors.SecurityTokenRequirement requirement, out System.IdentityModel.Selectors.SecurityTokenResolver resolver);
    public abstract System.IdentityModel.Selectors.SecurityTokenProvider CreateSecurityTokenProvider(System.IdentityModel.Selectors.SecurityTokenRequirement requirement);
    public abstract System.IdentityModel.Selectors.SecurityTokenSerializer CreateSecurityTokenSerializer(System.IdentityModel.Selectors.SecurityTokenVersion version);
  }
  public abstract partial class SecurityTokenProvider {
    protected SecurityTokenProvider() { }
    public virtual bool SupportsTokenCancellation { get { return default(bool); } }
    public virtual bool SupportsTokenRenewal { get { return default(bool); } }
    public System.IAsyncResult BeginCancelToken(System.TimeSpan timeout, System.IdentityModel.Tokens.SecurityToken token, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected virtual System.IAsyncResult BeginCancelTokenCore(System.TimeSpan timeout, System.IdentityModel.Tokens.SecurityToken token, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginGetToken(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    [System.MonoTODOAttribute]
    protected virtual System.IAsyncResult BeginGetTokenCore(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginRenewToken(System.TimeSpan timeout, System.IdentityModel.Tokens.SecurityToken token, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected virtual System.IAsyncResult BeginRenewTokenCore(System.TimeSpan timeout, System.IdentityModel.Tokens.SecurityToken token, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public void CancelToken(System.TimeSpan timeout, System.IdentityModel.Tokens.SecurityToken token) { }
    protected virtual void CancelTokenCore(System.TimeSpan timeout, System.IdentityModel.Tokens.SecurityToken token) { }
    public void EndCancelToken(System.IAsyncResult result) { }
    protected virtual void EndCancelTokenCore(System.IAsyncResult result) { }
    public System.IdentityModel.Tokens.SecurityToken EndGetToken(System.IAsyncResult result) { return default(System.IdentityModel.Tokens.SecurityToken); }
    [System.MonoTODOAttribute]
    protected virtual System.IdentityModel.Tokens.SecurityToken EndGetTokenCore(System.IAsyncResult result) { return default(System.IdentityModel.Tokens.SecurityToken); }
    public System.IdentityModel.Tokens.SecurityToken EndRenewToken(System.IAsyncResult result) { return default(System.IdentityModel.Tokens.SecurityToken); }
    protected virtual System.IdentityModel.Tokens.SecurityToken EndRenewTokenCore(System.IAsyncResult result) { return default(System.IdentityModel.Tokens.SecurityToken); }
    public System.IdentityModel.Tokens.SecurityToken GetToken(System.TimeSpan timeout) { return default(System.IdentityModel.Tokens.SecurityToken); }
    protected abstract System.IdentityModel.Tokens.SecurityToken GetTokenCore(System.TimeSpan timeout);
    public System.IdentityModel.Tokens.SecurityToken RenewToken(System.TimeSpan timeout, System.IdentityModel.Tokens.SecurityToken token) { return default(System.IdentityModel.Tokens.SecurityToken); }
    protected virtual System.IdentityModel.Tokens.SecurityToken RenewTokenCore(System.TimeSpan timeout, System.IdentityModel.Tokens.SecurityToken token) { return default(System.IdentityModel.Tokens.SecurityToken); }
  }
  public partial class SecurityTokenRequirement {
    public SecurityTokenRequirement() { }
    public int KeySize { get { return default(int); } set { } }
    public static string KeySizeProperty { get { return default(string); } }
    public System.IdentityModel.Tokens.SecurityKeyType KeyType { get { return default(System.IdentityModel.Tokens.SecurityKeyType); } set { } }
    public static string KeyTypeProperty { get { return default(string); } }
    public System.IdentityModel.Tokens.SecurityKeyUsage KeyUsage { get { return default(System.IdentityModel.Tokens.SecurityKeyUsage); } set { } }
    public static string KeyUsageProperty { get { return default(string); } }
    public System.Collections.Generic.IDictionary<System.String, System.Object> Properties { get { return default(System.Collections.Generic.IDictionary<System.String, System.Object>); } }
    public bool RequireCryptographicToken { get { return default(bool); } set { } }
    public static string RequireCryptographicTokenProperty { get { return default(string); } }
    public string TokenType { get { return default(string); } set { } }
    public static string TokenTypeProperty { get { return default(string); } }
    public TValue GetProperty<TValue>(string property) { return default(TValue); }
    public bool TryGetProperty<TValue>(string property, out TValue value) { value = default(TValue); return default(bool); }
  }
  public abstract partial class SecurityTokenResolver {
    protected SecurityTokenResolver() { }
    public static System.IdentityModel.Selectors.SecurityTokenResolver CreateDefaultSecurityTokenResolver(System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SecurityToken> tokens, bool canMatchLocalId) { return default(System.IdentityModel.Selectors.SecurityTokenResolver); }
    public System.IdentityModel.Tokens.SecurityKey ResolveSecurityKey(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause) { return default(System.IdentityModel.Tokens.SecurityKey); }
    public System.IdentityModel.Tokens.SecurityToken ResolveToken(System.IdentityModel.Tokens.SecurityKeyIdentifier keyIdentifier) { return default(System.IdentityModel.Tokens.SecurityToken); }
    public System.IdentityModel.Tokens.SecurityToken ResolveToken(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause) { return default(System.IdentityModel.Tokens.SecurityToken); }
    public bool TryResolveSecurityKey(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause, out System.IdentityModel.Tokens.SecurityKey key) { key = default(System.IdentityModel.Tokens.SecurityKey); return default(bool); }
    protected abstract bool TryResolveSecurityKeyCore(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause, out System.IdentityModel.Tokens.SecurityKey key);
    public bool TryResolveToken(System.IdentityModel.Tokens.SecurityKeyIdentifier keyIdentifier, out System.IdentityModel.Tokens.SecurityToken token) { token = default(System.IdentityModel.Tokens.SecurityToken); return default(bool); }
    public bool TryResolveToken(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause, out System.IdentityModel.Tokens.SecurityToken token) { token = default(System.IdentityModel.Tokens.SecurityToken); return default(bool); }
    protected abstract bool TryResolveTokenCore(System.IdentityModel.Tokens.SecurityKeyIdentifier keyIdentifier, out System.IdentityModel.Tokens.SecurityToken token);
    protected abstract bool TryResolveTokenCore(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause, out System.IdentityModel.Tokens.SecurityToken token);
  }
  public abstract partial class SecurityTokenSerializer {
    protected SecurityTokenSerializer() { }
    [System.MonoTODOAttribute]
    public bool CanReadKeyIdentifier(System.Xml.XmlReader reader) { return default(bool); }
    [System.MonoTODOAttribute]
    public bool CanReadKeyIdentifierClause(System.Xml.XmlReader reader) { return default(bool); }
    protected abstract bool CanReadKeyIdentifierClauseCore(System.Xml.XmlReader reader);
    protected abstract bool CanReadKeyIdentifierCore(System.Xml.XmlReader reader);
    [System.MonoTODOAttribute]
    public bool CanReadToken(System.Xml.XmlReader reader) { return default(bool); }
    protected abstract bool CanReadTokenCore(System.Xml.XmlReader reader);
    [System.MonoTODOAttribute]
    public bool CanWriteKeyIdentifier(System.IdentityModel.Tokens.SecurityKeyIdentifier keyIdentifier) { return default(bool); }
    [System.MonoTODOAttribute]
    public bool CanWriteKeyIdentifierClause(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause) { return default(bool); }
    protected abstract bool CanWriteKeyIdentifierClauseCore(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause);
    protected abstract bool CanWriteKeyIdentifierCore(System.IdentityModel.Tokens.SecurityKeyIdentifier keyIdentifier);
    [System.MonoTODOAttribute]
    public bool CanWriteToken(System.IdentityModel.Tokens.SecurityToken token) { return default(bool); }
    protected abstract bool CanWriteTokenCore(System.IdentityModel.Tokens.SecurityToken token);
    [System.MonoTODOAttribute]
    public System.IdentityModel.Tokens.SecurityKeyIdentifier ReadKeyIdentifier(System.Xml.XmlReader reader) { return default(System.IdentityModel.Tokens.SecurityKeyIdentifier); }
    [System.MonoTODOAttribute]
    public System.IdentityModel.Tokens.SecurityKeyIdentifierClause ReadKeyIdentifierClause(System.Xml.XmlReader reader) { return default(System.IdentityModel.Tokens.SecurityKeyIdentifierClause); }
    protected abstract System.IdentityModel.Tokens.SecurityKeyIdentifierClause ReadKeyIdentifierClauseCore(System.Xml.XmlReader reader);
    protected abstract System.IdentityModel.Tokens.SecurityKeyIdentifier ReadKeyIdentifierCore(System.Xml.XmlReader reader);
    [System.MonoTODOAttribute]
    public System.IdentityModel.Tokens.SecurityToken ReadToken(System.Xml.XmlReader reader, System.IdentityModel.Selectors.SecurityTokenResolver tokenResolver) { return default(System.IdentityModel.Tokens.SecurityToken); }
    protected abstract System.IdentityModel.Tokens.SecurityToken ReadTokenCore(System.Xml.XmlReader reader, System.IdentityModel.Selectors.SecurityTokenResolver tokenResolver);
    [System.MonoTODOAttribute]
    public void WriteKeyIdentifier(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SecurityKeyIdentifier keyIdentifier) { }
    [System.MonoTODOAttribute]
    public void WriteKeyIdentifierClause(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause) { }
    protected abstract void WriteKeyIdentifierClauseCore(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause);
    protected abstract void WriteKeyIdentifierCore(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SecurityKeyIdentifier keyIdentifier);
    [System.MonoTODOAttribute]
    public void WriteToken(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SecurityToken token) { }
    protected abstract void WriteTokenCore(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SecurityToken token);
  }
  public abstract partial class SecurityTokenVersion {
    protected SecurityTokenVersion() { }
    public abstract System.Collections.ObjectModel.ReadOnlyCollection<System.String> GetSecuritySpecifications();
  }
  public abstract partial class UserNamePasswordValidator {
    protected UserNamePasswordValidator() { }
    public static System.IdentityModel.Selectors.UserNamePasswordValidator None { get { return default(System.IdentityModel.Selectors.UserNamePasswordValidator); } }
    public static System.IdentityModel.Selectors.UserNamePasswordValidator CreateMembershipProviderValidator(System.Web.Security.MembershipProvider provider) { return default(System.IdentityModel.Selectors.UserNamePasswordValidator); }
    public abstract void Validate(string userName, string password);
  }
  public abstract partial class UserNameSecurityTokenAuthenticator : System.IdentityModel.Selectors.SecurityTokenAuthenticator {
    protected UserNameSecurityTokenAuthenticator() { }
    protected override bool CanValidateTokenCore(System.IdentityModel.Tokens.SecurityToken token) { return default(bool); }
    protected override System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy> ValidateTokenCore(System.IdentityModel.Tokens.SecurityToken token) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy>); }
    protected abstract System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy> ValidateUserNamePasswordCore(string userName, string password);
  }
  public partial class UserNameSecurityTokenProvider : System.IdentityModel.Selectors.SecurityTokenProvider {
    public UserNameSecurityTokenProvider(string userName, string password) { }
    protected override System.IdentityModel.Tokens.SecurityToken GetTokenCore(System.TimeSpan timeout) { return default(System.IdentityModel.Tokens.SecurityToken); }
  }
  public partial class WindowsSecurityTokenAuthenticator : System.IdentityModel.Selectors.SecurityTokenAuthenticator {
    [System.MonoTODOAttribute]
    public WindowsSecurityTokenAuthenticator() { }
    [System.MonoTODOAttribute]
    public WindowsSecurityTokenAuthenticator(bool includeWindowsGroups) { }
    [System.MonoTODOAttribute]
    protected override bool CanValidateTokenCore(System.IdentityModel.Tokens.SecurityToken token) { return default(bool); }
    [System.MonoTODOAttribute]
    protected override System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy> ValidateTokenCore(System.IdentityModel.Tokens.SecurityToken token) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy>); }
  }
  public partial class WindowsUserNameSecurityTokenAuthenticator : System.IdentityModel.Selectors.UserNameSecurityTokenAuthenticator {
    public WindowsUserNameSecurityTokenAuthenticator() { }
    public WindowsUserNameSecurityTokenAuthenticator(bool includeWindowsGroups) { }
    [System.MonoTODOAttribute]
    protected override System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy> ValidateUserNamePasswordCore(string userName, string password) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy>); }
  }
  public abstract partial class X509CertificateValidator {
    protected X509CertificateValidator() { }
    public static System.IdentityModel.Selectors.X509CertificateValidator ChainTrust { get { return default(System.IdentityModel.Selectors.X509CertificateValidator); } }
    public static System.IdentityModel.Selectors.X509CertificateValidator None { get { return default(System.IdentityModel.Selectors.X509CertificateValidator); } }
    public static System.IdentityModel.Selectors.X509CertificateValidator PeerOrChainTrust { get { return default(System.IdentityModel.Selectors.X509CertificateValidator); } }
    public static System.IdentityModel.Selectors.X509CertificateValidator PeerTrust { get { return default(System.IdentityModel.Selectors.X509CertificateValidator); } }
    public static System.IdentityModel.Selectors.X509CertificateValidator CreateChainTrustValidator(bool useMachineContext, System.Security.Cryptography.X509Certificates.X509ChainPolicy chainPolicy) { return default(System.IdentityModel.Selectors.X509CertificateValidator); }
    public static System.IdentityModel.Selectors.X509CertificateValidator CreatePeerOrChainTrustValidator(bool useMachineContext, System.Security.Cryptography.X509Certificates.X509ChainPolicy chainPolicy) { return default(System.IdentityModel.Selectors.X509CertificateValidator); }
    public abstract void Validate(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
  }
  public partial class X509SecurityTokenAuthenticator : System.IdentityModel.Selectors.SecurityTokenAuthenticator {
    public X509SecurityTokenAuthenticator() { }
    public X509SecurityTokenAuthenticator(System.IdentityModel.Selectors.X509CertificateValidator validator) { }
    public X509SecurityTokenAuthenticator(System.IdentityModel.Selectors.X509CertificateValidator validator, bool mapToWindows) { }
    public X509SecurityTokenAuthenticator(System.IdentityModel.Selectors.X509CertificateValidator validator, bool mapToWindows, bool includeWindowsGroups) { }
    protected override bool CanValidateTokenCore(System.IdentityModel.Tokens.SecurityToken token) { return default(bool); }
    protected override System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy> ValidateTokenCore(System.IdentityModel.Tokens.SecurityToken token) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy>); }
  }
  public partial class X509SecurityTokenProvider : System.IdentityModel.Selectors.SecurityTokenProvider, System.IDisposable {
    public X509SecurityTokenProvider(System.Security.Cryptography.X509Certificates.StoreLocation storeLocation, System.Security.Cryptography.X509Certificates.StoreName storeName, System.Security.Cryptography.X509Certificates.X509FindType findType, object findValue) { }
    public X509SecurityTokenProvider(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
    public System.Security.Cryptography.X509Certificates.X509Certificate2 Certificate { get { return default(System.Security.Cryptography.X509Certificates.X509Certificate2); } }
    public void Dispose() { }
    protected override System.IdentityModel.Tokens.SecurityToken GetTokenCore(System.TimeSpan timeout) { return default(System.IdentityModel.Tokens.SecurityToken); }
  }
}
namespace System.IdentityModel.Tokens {
  public abstract partial class AsymmetricSecurityKey : System.IdentityModel.Tokens.SecurityKey {
    protected AsymmetricSecurityKey() { }
    public abstract System.Security.Cryptography.AsymmetricAlgorithm GetAsymmetricAlgorithm(string algorithm, bool privateKey);
    public abstract System.Security.Cryptography.HashAlgorithm GetHashAlgorithmForSignature(string algorithm);
    public abstract System.Security.Cryptography.AsymmetricSignatureDeformatter GetSignatureDeformatter(string algorithm);
    public abstract System.Security.Cryptography.AsymmetricSignatureFormatter GetSignatureFormatter(string algorithm);
    public abstract bool HasPrivateKey();
  }
  public partial class AudienceRestriction {
    public AudienceRestriction() { }
    public AudienceRestriction(System.IdentityModel.Selectors.AudienceUriMode audienceMode) { }
    public System.Collections.ObjectModel.Collection<System.Uri> AllowedAudienceUris { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.ObjectModel.Collection<System.Uri>); } }
    public System.IdentityModel.Selectors.AudienceUriMode AudienceMode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.IdentityModel.Selectors.AudienceUriMode); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial class AuthenticationContext {
    public AuthenticationContext() { }
    public System.Collections.ObjectModel.Collection<System.String> Authorities { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.ObjectModel.Collection<System.String>); } }
    public string ContextClass { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string ContextDeclaration { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public abstract partial class BinaryKeyIdentifierClause : System.IdentityModel.Tokens.SecurityKeyIdentifierClause {
    protected BinaryKeyIdentifierClause(string clauseType, System.Byte[] identificationData, bool cloneBuffer) : base (default(string)) { }
    protected BinaryKeyIdentifierClause(string clauseType, System.Byte[] identificationData, bool cloneBuffer, System.Byte[] derivationNonce, int derivationLength) : base (default(string)) { }
    public System.Byte[] GetBuffer() { return default(System.Byte[]); }
    protected System.Byte[] GetRawBuffer() { return default(System.Byte[]); }
    public bool Matches(System.Byte[] data) { return default(bool); }
    public bool Matches(System.Byte[] data, int offset) { return default(bool); }
    public override bool Matches(System.IdentityModel.Tokens.SecurityKeyIdentifierClause clause) { return default(bool); }
  }
  public partial class BootstrapContext : System.Runtime.Serialization.ISerializable {
    public BootstrapContext(System.Byte[] token) { }
    public BootstrapContext(System.IdentityModel.Tokens.SecurityToken token, System.IdentityModel.Tokens.SecurityTokenHandler handler) { }
    protected BootstrapContext(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public BootstrapContext(string token) { }
    public System.IdentityModel.Tokens.SecurityToken SecurityToken { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.IdentityModel.Tokens.SecurityToken); } }
    public System.IdentityModel.Tokens.SecurityTokenHandler SecurityTokenHandler { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.IdentityModel.Tokens.SecurityTokenHandler); } }
    public string Token { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public System.Byte[] TokenBytes { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Byte[]); } }
    public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public sealed partial class EncryptedKeyIdentifierClause : System.IdentityModel.Tokens.BinaryKeyIdentifierClause {
    public EncryptedKeyIdentifierClause(System.Byte[] encryptedKey, string encryptionMethod) : base (default(string), default(System.Byte[]), default(bool)) { }
    public EncryptedKeyIdentifierClause(System.Byte[] encryptedKey, string encryptionMethod, System.IdentityModel.Tokens.SecurityKeyIdentifier identifier) : base (default(string), default(System.Byte[]), default(bool)) { }
    public EncryptedKeyIdentifierClause(System.Byte[] encryptedKey, string encryptionMethod, System.IdentityModel.Tokens.SecurityKeyIdentifier identifier, string carriedKeyName) : base (default(string), default(System.Byte[]), default(bool)) { }
    public EncryptedKeyIdentifierClause(System.Byte[] encryptedKey, string encryptionMethod, System.IdentityModel.Tokens.SecurityKeyIdentifier identifier, string carriedKeyName, System.Byte[] derivationNonce, int derivationLength) : base (default(string), default(System.Byte[]), default(bool)) { }
    public string CarriedKeyName { get { return default(string); } }
    public System.IdentityModel.Tokens.SecurityKeyIdentifier EncryptingKeyIdentifier { get { return default(System.IdentityModel.Tokens.SecurityKeyIdentifier); } }
    public string EncryptionMethod { get { return default(string); } }
    public System.Byte[] GetEncryptedKey() { return default(System.Byte[]); }
    public bool Matches(System.Byte[] encryptedKey, string encryptionMethod, string carriedKeyName) { return default(bool); }
    public override bool Matches(System.IdentityModel.Tokens.SecurityKeyIdentifierClause clause) { return default(bool); }
    [System.MonoTODOAttribute]
    public override string ToString() { return default(string); }
  }
  public partial class EncryptingCredentials {
    public EncryptingCredentials() { }
    public EncryptingCredentials(System.IdentityModel.Tokens.SecurityKey key, System.IdentityModel.Tokens.SecurityKeyIdentifier keyIdentifier, string algorithm) { }
    public string Algorithm { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.IdentityModel.Tokens.SecurityKey SecurityKey { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.IdentityModel.Tokens.SecurityKey); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.IdentityModel.Tokens.SecurityKeyIdentifier SecurityKeyIdentifier { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.IdentityModel.Tokens.SecurityKeyIdentifier); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial class GenericXmlSecurityToken : System.IdentityModel.Tokens.SecurityToken {
    public GenericXmlSecurityToken(System.Xml.XmlElement tokenXml, System.IdentityModel.Tokens.SecurityToken proofToken, System.DateTime effectiveTime, System.DateTime expirationTime, System.IdentityModel.Tokens.SecurityKeyIdentifierClause internalTokenReference, System.IdentityModel.Tokens.SecurityKeyIdentifierClause externalTokenReference, System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy> authorizationPolicies) { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy> AuthorizationPolicies { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy>); } }
    public System.IdentityModel.Tokens.SecurityKeyIdentifierClause ExternalTokenReference { get { return default(System.IdentityModel.Tokens.SecurityKeyIdentifierClause); } }
    [System.MonoTODOAttribute]
    public override string Id { get { return default(string); } }
    public System.IdentityModel.Tokens.SecurityKeyIdentifierClause InternalTokenReference { get { return default(System.IdentityModel.Tokens.SecurityKeyIdentifierClause); } }
    public System.IdentityModel.Tokens.SecurityToken ProofToken { get { return default(System.IdentityModel.Tokens.SecurityToken); } }
    [System.MonoTODOAttribute]
    public override System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SecurityKey> SecurityKeys { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SecurityKey>); } }
    public System.Xml.XmlElement TokenXml { get { return default(System.Xml.XmlElement); } }
    public override System.DateTime ValidFrom { get { return default(System.DateTime); } }
    public override System.DateTime ValidTo { get { return default(System.DateTime); } }
    [System.MonoTODOAttribute]
    public override bool CanCreateKeyIdentifierClause<T>() { return default(bool); }
    [System.MonoTODOAttribute]
    public override T CreateKeyIdentifierClause<T>() { return default(T); }
    [System.MonoTODOAttribute]
    public override bool MatchesKeyIdentifierClause(System.IdentityModel.Tokens.SecurityKeyIdentifierClause skiClause) { return default(bool); }
  }
  public partial class InMemorySymmetricSecurityKey : System.IdentityModel.Tokens.SymmetricSecurityKey {
    public InMemorySymmetricSecurityKey(System.Byte[] key) { }
    public InMemorySymmetricSecurityKey(System.Byte[] key, bool clone) { }
    public override int KeySize { get { return default(int); } }
    public override System.Byte[] DecryptKey(string algorithm, System.Byte[] keyData) { return default(System.Byte[]); }
    public override System.Byte[] EncryptKey(string algorithm, System.Byte[] keyData) { return default(System.Byte[]); }
    public override System.Byte[] GenerateDerivedKey(string algorithm, System.Byte[] label, System.Byte[] nonce, int derivedKeyLength, int offset) { return default(System.Byte[]); }
    public override System.Security.Cryptography.ICryptoTransform GetDecryptionTransform(string algorithm, System.Byte[] iv) { return default(System.Security.Cryptography.ICryptoTransform); }
    public override System.Security.Cryptography.ICryptoTransform GetEncryptionTransform(string algorithm, System.Byte[] iv) { return default(System.Security.Cryptography.ICryptoTransform); }
    [System.MonoTODOAttribute]
    public override int GetIVSize(string algorithm) { return default(int); }
    public override System.Security.Cryptography.KeyedHashAlgorithm GetKeyedHashAlgorithm(string algorithm) { return default(System.Security.Cryptography.KeyedHashAlgorithm); }
    public override System.Security.Cryptography.SymmetricAlgorithm GetSymmetricAlgorithm(string algorithm) { return default(System.Security.Cryptography.SymmetricAlgorithm); }
    public override System.Byte[] GetSymmetricKey() { return default(System.Byte[]); }
    public override bool IsAsymmetricAlgorithm(string algorithm) { return default(bool); }
    public override bool IsSupportedAlgorithm(string algorithm) { return default(bool); }
    public override bool IsSymmetricAlgorithm(string algorithm) { return default(bool); }
  }
  public abstract partial class IssuerNameRegistry : System.IdentityModel.Configuration.ICustomIdentityConfiguration {
    protected IssuerNameRegistry() { }
    public abstract string GetIssuerName(System.IdentityModel.Tokens.SecurityToken securityToken);
    [System.MonoTODOAttribute]
    public virtual string GetIssuerName(System.IdentityModel.Tokens.SecurityToken securityToken, string requestedIssuerName) { return default(string); }
    [System.MonoTODOAttribute]
    public virtual string GetWindowsIssuerName() { return default(string); }
    [System.MonoTODOAttribute]
    public virtual void LoadCustomConfiguration(System.Xml.XmlNodeList nodelist) { }
  }
  public partial class KerberosReceiverSecurityToken : System.IdentityModel.Tokens.WindowsSecurityToken {
    [System.MonoTODOAttribute]
    public KerberosReceiverSecurityToken(System.Byte[] request) { }
    [System.MonoTODOAttribute]
    public KerberosReceiverSecurityToken(System.Byte[] request, string id) { }
    [System.MonoTODOAttribute]
    public System.IdentityModel.Tokens.SymmetricSecurityKey SecurityKey { get { return default(System.IdentityModel.Tokens.SymmetricSecurityKey); } }
    [System.MonoTODOAttribute]
    public override System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SecurityKey> SecurityKeys { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SecurityKey>); } }
    [System.MonoTODOAttribute]
    public override bool CanCreateKeyIdentifierClause<T>() { return default(bool); }
    [System.MonoTODOAttribute]
    public override T CreateKeyIdentifierClause<T>() { return default(T); }
    [System.MonoTODOAttribute]
    public System.Byte[] GetRequest() { return default(System.Byte[]); }
    [System.MonoTODOAttribute]
    public override bool MatchesKeyIdentifierClause(System.IdentityModel.Tokens.SecurityKeyIdentifierClause skiClause) { return default(bool); }
  }
  public partial class KerberosRequestorSecurityToken : System.IdentityModel.Tokens.SecurityToken {
    [System.MonoTODOAttribute]
    public KerberosRequestorSecurityToken(string servicePrincipalName) { }
    [System.MonoTODOAttribute]
    public KerberosRequestorSecurityToken(string servicePrincipalName, System.Security.Principal.TokenImpersonationLevel tokenImpersonationLevel, System.Net.NetworkCredential networkCredential, string id) { }
    public override string Id { get { return default(string); } }
    [System.MonoTODOAttribute]
    public System.IdentityModel.Tokens.SymmetricSecurityKey SecurityKey { get { return default(System.IdentityModel.Tokens.SymmetricSecurityKey); } }
    [System.MonoTODOAttribute]
    public override System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SecurityKey> SecurityKeys { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SecurityKey>); } }
    public string ServicePrincipalName { get { return default(string); } }
    [System.MonoTODOAttribute]
    public override System.DateTime ValidFrom { get { return default(System.DateTime); } }
    [System.MonoTODOAttribute]
    public override System.DateTime ValidTo { get { return default(System.DateTime); } }
    [System.MonoTODOAttribute]
    public override bool CanCreateKeyIdentifierClause<T>() { return default(bool); }
    [System.MonoTODOAttribute]
    public override T CreateKeyIdentifierClause<T>() { return default(T); }
    [System.MonoTODOAttribute]
    public System.Byte[] GetRequest() { return default(System.Byte[]); }
    [System.MonoTODOAttribute]
    public override bool MatchesKeyIdentifierClause(System.IdentityModel.Tokens.SecurityKeyIdentifierClause skiClause) { return default(bool); }
  }
  public partial class LocalIdKeyIdentifierClause : System.IdentityModel.Tokens.SecurityKeyIdentifierClause {
    public LocalIdKeyIdentifierClause(string localId) : base (default(string)) { }
    public LocalIdKeyIdentifierClause(string localId, System.Byte[] derivationNonce, int derivationLength, System.Type ownerType) : base (default(string)) { }
    public LocalIdKeyIdentifierClause(string localId, System.Type ownerType) : base (default(string)) { }
    public string LocalId { get { return default(string); } }
    public System.Type OwnerType { get { return default(System.Type); } }
    public override bool Matches(System.IdentityModel.Tokens.SecurityKeyIdentifierClause clause) { return default(bool); }
    public bool Matches(string localId, System.Type ownerType) { return default(bool); }
    [System.MonoTODOAttribute]
    public override string ToString() { return default(string); }
  }
  public abstract partial class ProofDescriptor {
    protected ProofDescriptor() { }
    public abstract System.IdentityModel.Tokens.SecurityKeyIdentifier KeyIdentifier { get; }
    public abstract void ApplyTo(System.IdentityModel.Protocols.WSTrust.RequestSecurityTokenResponse response);
  }
  public partial class RsaKeyIdentifierClause : System.IdentityModel.Tokens.SecurityKeyIdentifierClause {
    public RsaKeyIdentifierClause(System.Security.Cryptography.RSA rsa) : base (default(string)) { }
    public override bool CanCreateKey { get { return default(bool); } }
    public System.Security.Cryptography.RSA Rsa { get { return default(System.Security.Cryptography.RSA); } }
    public override System.IdentityModel.Tokens.SecurityKey CreateKey() { return default(System.IdentityModel.Tokens.SecurityKey); }
    public System.Byte[] GetExponent() { return default(System.Byte[]); }
    public System.Byte[] GetModulus() { return default(System.Byte[]); }
    public override bool Matches(System.IdentityModel.Tokens.SecurityKeyIdentifierClause clause) { return default(bool); }
    public bool Matches(System.Security.Cryptography.RSA rsa) { return default(bool); }
    [System.MonoTODOAttribute]
    public override string ToString() { return default(string); }
    [System.MonoTODOAttribute]
    public void WriteExponentAsBase64(System.Xml.XmlWriter writer) { }
    [System.MonoTODOAttribute]
    public void WriteModulusAsBase64(System.Xml.XmlWriter writer) { }
  }
  public sealed partial class RsaSecurityKey : System.IdentityModel.Tokens.AsymmetricSecurityKey {
    public RsaSecurityKey(System.Security.Cryptography.RSA rsa) { }
    public override int KeySize { get { return default(int); } }
    [System.MonoTODOAttribute]
    public override System.Byte[] DecryptKey(string algorithm, System.Byte[] keyData) { return default(System.Byte[]); }
    [System.MonoTODOAttribute]
    public override System.Byte[] EncryptKey(string algorithm, System.Byte[] keyData) { return default(System.Byte[]); }
    [System.MonoTODOAttribute]
    public override System.Security.Cryptography.AsymmetricAlgorithm GetAsymmetricAlgorithm(string algorithm, bool privateKey) { return default(System.Security.Cryptography.AsymmetricAlgorithm); }
    [System.MonoTODOAttribute]
    public override System.Security.Cryptography.HashAlgorithm GetHashAlgorithmForSignature(string algorithm) { return default(System.Security.Cryptography.HashAlgorithm); }
    [System.MonoTODOAttribute]
    public override System.Security.Cryptography.AsymmetricSignatureDeformatter GetSignatureDeformatter(string algorithm) { return default(System.Security.Cryptography.AsymmetricSignatureDeformatter); }
    [System.MonoTODOAttribute]
    public override System.Security.Cryptography.AsymmetricSignatureFormatter GetSignatureFormatter(string algorithm) { return default(System.Security.Cryptography.AsymmetricSignatureFormatter); }
    public override bool HasPrivateKey() { return default(bool); }
    [System.MonoTODOAttribute]
    public override bool IsAsymmetricAlgorithm(string algorithm) { return default(bool); }
    [System.MonoTODOAttribute]
    public override bool IsSupportedAlgorithm(string algorithm) { return default(bool); }
    [System.MonoTODOAttribute]
    public override bool IsSymmetricAlgorithm(string algorithm) { return default(bool); }
  }
  public partial class RsaSecurityToken : System.IdentityModel.Tokens.SecurityToken {
    public RsaSecurityToken(System.Security.Cryptography.RSA rsa) { }
    public RsaSecurityToken(System.Security.Cryptography.RSA rsa, string id) { }
    public override string Id { get { return default(string); } }
    public System.Security.Cryptography.RSA Rsa { get { return default(System.Security.Cryptography.RSA); } }
    [System.MonoTODOAttribute]
    public override System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SecurityKey> SecurityKeys { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SecurityKey>); } }
    public override System.DateTime ValidFrom { get { return default(System.DateTime); } }
    public override System.DateTime ValidTo { get { return default(System.DateTime); } }
    [System.MonoTODOAttribute]
    public override bool CanCreateKeyIdentifierClause<T>() { return default(bool); }
    [System.MonoTODOAttribute]
    public override T CreateKeyIdentifierClause<T>() { return default(T); }
    [System.MonoTODOAttribute]
    public override bool MatchesKeyIdentifierClause(System.IdentityModel.Tokens.SecurityKeyIdentifierClause skiClause) { return default(bool); }
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public enum SamlAccessDecision {
    [System.Runtime.Serialization.EnumMemberAttribute]
    Deny = 1,
    [System.Runtime.Serialization.EnumMemberAttribute]
    Indeterminate = 2,
    [System.Runtime.Serialization.EnumMemberAttribute]
    Permit = 0,
  }
  public partial class SamlAction {
    public SamlAction() { }
    public SamlAction(string action) { }
    public SamlAction(string action, string ns) { }
    public string Action { get { return default(string); } set { } }
    public bool IsReadOnly { get { return default(bool); } }
    public string Namespace { get { return default(string); } set { } }
    public void MakeReadOnly() { }
    public virtual void ReadXml(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoTokenSerializer, System.IdentityModel.Selectors.SecurityTokenResolver outOfBandTokenResolver) { }
    public virtual void WriteXml(System.Xml.XmlDictionaryWriter writer, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoTokenSerializer) { }
  }
  public partial class SamlAdvice {
    public SamlAdvice() { }
    public SamlAdvice(System.Collections.Generic.IEnumerable<System.IdentityModel.Tokens.SamlAssertion> assertions) { }
    public SamlAdvice(System.Collections.Generic.IEnumerable<System.String> references) { }
    public SamlAdvice(System.Collections.Generic.IEnumerable<System.String> references, System.Collections.Generic.IEnumerable<System.IdentityModel.Tokens.SamlAssertion> assertions) { }
    public System.Collections.Generic.IList<System.String> AssertionIdReferences { get { return default(System.Collections.Generic.IList<System.String>); } }
    public System.Collections.Generic.IList<System.IdentityModel.Tokens.SamlAssertion> Assertions { get { return default(System.Collections.Generic.IList<System.IdentityModel.Tokens.SamlAssertion>); } }
    public bool IsReadOnly { get { return default(bool); } }
    public void MakeReadOnly() { }
    public virtual void ReadXml(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoTokenSerializer, System.IdentityModel.Selectors.SecurityTokenResolver outOfBandTokenResolver) { }
    public virtual void WriteXml(System.Xml.XmlDictionaryWriter writer, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoTokenSerializer) { }
  }
  public partial class SamlAssertion {
    public SamlAssertion() { }
    public SamlAssertion(string assertionId, string issuer, System.DateTime issueInstant, System.IdentityModel.Tokens.SamlConditions conditions, System.IdentityModel.Tokens.SamlAdvice advice, System.Collections.Generic.IEnumerable<System.IdentityModel.Tokens.SamlStatement> statements) { }
    public System.IdentityModel.Tokens.SamlAdvice Advice { get { return default(System.IdentityModel.Tokens.SamlAdvice); } set { } }
    public string AssertionId { get { return default(string); } set { } }
    public System.IdentityModel.Tokens.SamlConditions Conditions { get { return default(System.IdentityModel.Tokens.SamlConditions); } set { } }
    public bool IsReadOnly { get { return default(bool); } }
    public System.DateTime IssueInstant { get { return default(System.DateTime); } set { } }
    public string Issuer { get { return default(string); } set { } }
    public int MajorVersion { get { return default(int); } }
    public int MinorVersion { get { return default(int); } }
    public System.IdentityModel.Tokens.SigningCredentials SigningCredentials { get { return default(System.IdentityModel.Tokens.SigningCredentials); } set { } }
    [System.MonoTODOAttribute]
    public System.IdentityModel.Tokens.SecurityToken SigningToken { get { return default(System.IdentityModel.Tokens.SecurityToken); } }
    public System.Collections.Generic.IList<System.IdentityModel.Tokens.SamlStatement> Statements { get { return default(System.Collections.Generic.IList<System.IdentityModel.Tokens.SamlStatement>); } }
    public void MakeReadOnly() { }
    [System.MonoTODOAttribute]
    protected void ReadSignature(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoTokenSerializer, System.IdentityModel.Selectors.SecurityTokenResolver outOfBandTokenResolver, System.IdentityModel.Tokens.SamlSerializer samlSerializer) { }
    [System.MonoTODOAttribute]
    public virtual void ReadXml(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoTokenSerializer, System.IdentityModel.Selectors.SecurityTokenResolver outOfBandTokenResolver) { }
    public virtual void WriteXml(System.Xml.XmlDictionaryWriter writer, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoTokenSerializer) { }
  }
  public partial class SamlAssertionKeyIdentifierClause : System.IdentityModel.Tokens.SecurityKeyIdentifierClause {
    [System.MonoTODOAttribute]
    public SamlAssertionKeyIdentifierClause(string assertionId) : base (default(string)) { }
    public string AssertionId { get { return default(string); } }
    [System.MonoTODOAttribute]
    public override bool Matches(System.IdentityModel.Tokens.SecurityKeyIdentifierClause clause) { return default(bool); }
    public bool Matches(string assertionId) { return default(bool); }
    [System.MonoTODOAttribute]
    public override string ToString() { return default(string); }
  }
  public partial class SamlAttribute {
    public SamlAttribute() { }
    public SamlAttribute(System.IdentityModel.Claims.Claim claim) { }
    public SamlAttribute(string attributeNamespace, string attributeName, System.Collections.Generic.IEnumerable<System.String> attributeValues) { }
    public System.Collections.Generic.IList<System.String> AttributeValues { get { return default(System.Collections.Generic.IList<System.String>); } }
    public bool IsReadOnly { get { return default(bool); } }
    public string Name { get { return default(string); } set { } }
    public string Namespace { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public virtual System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Claims.Claim> ExtractClaims() { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Claims.Claim>); }
    public void MakeReadOnly() { }
    [System.MonoTODOAttribute]
    public virtual void ReadXml(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoTokenSerializer, System.IdentityModel.Selectors.SecurityTokenResolver outOfBandTokenResolver) { }
    public virtual void WriteXml(System.Xml.XmlDictionaryWriter writer, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoTokenSerializer) { }
  }
  public partial class SamlAttributeStatement : System.IdentityModel.Tokens.SamlSubjectStatement {
    public SamlAttributeStatement() { }
    public SamlAttributeStatement(System.IdentityModel.Tokens.SamlSubject samlSubject, System.Collections.Generic.IEnumerable<System.IdentityModel.Tokens.SamlAttribute> attributes) { }
    public System.Collections.Generic.IList<System.IdentityModel.Tokens.SamlAttribute> Attributes { get { return default(System.Collections.Generic.IList<System.IdentityModel.Tokens.SamlAttribute>); } }
    public override bool IsReadOnly { get { return default(bool); } }
    [System.MonoTODOAttribute]
    protected override void AddClaimsToList(System.Collections.Generic.IList<System.IdentityModel.Claims.Claim> claims) { }
    public override void MakeReadOnly() { }
    [System.MonoTODOAttribute]
    public override void ReadXml(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoTokenSerializer, System.IdentityModel.Selectors.SecurityTokenResolver outOfBandTokenResolver) { }
    public override void WriteXml(System.Xml.XmlDictionaryWriter writer, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoTokenSerializer) { }
  }
  public partial class SamlAudienceRestrictionCondition : System.IdentityModel.Tokens.SamlCondition {
    public SamlAudienceRestrictionCondition() { }
    public SamlAudienceRestrictionCondition(System.Collections.Generic.IEnumerable<System.Uri> audiences) { }
    public System.Collections.Generic.IList<System.Uri> Audiences { get { return default(System.Collections.Generic.IList<System.Uri>); } }
    public override bool IsReadOnly { get { return default(bool); } }
    public override void MakeReadOnly() { }
    [System.MonoTODOAttribute]
    public override void ReadXml(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer, System.IdentityModel.Selectors.SecurityTokenResolver outOfBandTokenResolver) { }
    public override void WriteXml(System.Xml.XmlDictionaryWriter writer, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer) { }
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public partial class SamlAuthenticationClaimResource {
    public SamlAuthenticationClaimResource(System.DateTime authenticationInstant, string authenticationMethod, string dnsAddress, string ipAddress) { }
    public SamlAuthenticationClaimResource(System.DateTime authenticationInstant, string authenticationMethod, string dnsAddress, string ipAddress, System.Collections.Generic.IEnumerable<System.IdentityModel.Tokens.SamlAuthorityBinding> authorityBindings) { }
    public SamlAuthenticationClaimResource(System.DateTime authenticationInstant, string authenticationMethod, string dnsAddress, string ipAddress, System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SamlAuthorityBinding> authorityBindings) { }
    public System.DateTime AuthenticationInstant { get { return default(System.DateTime); } }
    public string AuthenticationMethod { get { return default(string); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SamlAuthorityBinding> AuthorityBindings { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SamlAuthorityBinding>); } }
    public string DnsAddress { get { return default(string); } }
    public string IPAddress { get { return default(string); } }
  }
  public partial class SamlAuthenticationStatement : System.IdentityModel.Tokens.SamlSubjectStatement {
    public SamlAuthenticationStatement() { }
    public SamlAuthenticationStatement(System.IdentityModel.Tokens.SamlSubject samlSubject, string authenticationMethod, System.DateTime authenticationInstant, string dnsAddress, string ipAddress, System.Collections.Generic.IEnumerable<System.IdentityModel.Tokens.SamlAuthorityBinding> authorityBindings) { }
    public System.DateTime AuthenticationInstant { get { return default(System.DateTime); } set { } }
    public string AuthenticationMethod { get { return default(string); } set { } }
    public System.Collections.Generic.IList<System.IdentityModel.Tokens.SamlAuthorityBinding> AuthorityBindings { get { return default(System.Collections.Generic.IList<System.IdentityModel.Tokens.SamlAuthorityBinding>); } }
    public static string ClaimType { get { return default(string); } }
    public string DnsAddress { get { return default(string); } set { } }
    public string IPAddress { get { return default(string); } set { } }
    public override bool IsReadOnly { get { return default(bool); } }
    [System.MonoTODOAttribute]
    protected override void AddClaimsToList(System.Collections.Generic.IList<System.IdentityModel.Claims.Claim> claims) { }
    public override void MakeReadOnly() { }
    [System.MonoTODOAttribute]
    public override void ReadXml(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoTokenSerializer, System.IdentityModel.Selectors.SecurityTokenResolver outOfBandTokenResolver) { }
    public override void WriteXml(System.Xml.XmlDictionaryWriter writer, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoTokenSerializer) { }
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public partial class SamlAuthorityBinding {
    public SamlAuthorityBinding() { }
    public SamlAuthorityBinding(System.Xml.XmlQualifiedName kind, string binding, string location) { }
    [System.Runtime.Serialization.DataMemberAttribute]
    public System.Xml.XmlQualifiedName AuthorityKind { get { return default(System.Xml.XmlQualifiedName); } set { } }
    [System.Runtime.Serialization.DataMemberAttribute]
    public string Binding { get { return default(string); } set { } }
    public bool IsReadOnly { get { return default(bool); } }
    [System.Runtime.Serialization.DataMemberAttribute]
    public string Location { get { return default(string); } set { } }
    public void MakeReadOnly() { }
    [System.MonoTODOAttribute]
    public virtual void ReadXml(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer, System.IdentityModel.Selectors.SecurityTokenResolver outOfBandTokenResolver) { }
    public virtual void WriteXml(System.Xml.XmlDictionaryWriter writer, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer) { }
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public partial class SamlAuthorizationDecisionClaimResource {
    public SamlAuthorizationDecisionClaimResource(string resource, System.IdentityModel.Tokens.SamlAccessDecision decision, string actionName, string actionNamespace) { }
    public System.IdentityModel.Tokens.SamlAccessDecision AccessDecision { get { return default(System.IdentityModel.Tokens.SamlAccessDecision); } }
    public string ActionName { get { return default(string); } }
    public string ActionNamespace { get { return default(string); } }
    public string Resource { get { return default(string); } }
  }
  public partial class SamlAuthorizationDecisionStatement : System.IdentityModel.Tokens.SamlSubjectStatement {
    public SamlAuthorizationDecisionStatement() { }
    public SamlAuthorizationDecisionStatement(System.IdentityModel.Tokens.SamlSubject samlSubject, string resource, System.IdentityModel.Tokens.SamlAccessDecision accessDecision, System.Collections.Generic.IEnumerable<System.IdentityModel.Tokens.SamlAction> samlActions) { }
    public SamlAuthorizationDecisionStatement(System.IdentityModel.Tokens.SamlSubject samlSubject, string resource, System.IdentityModel.Tokens.SamlAccessDecision accessDecision, System.Collections.Generic.IEnumerable<System.IdentityModel.Tokens.SamlAction> samlActions, System.IdentityModel.Tokens.SamlEvidence samlEvidence) { }
    public System.IdentityModel.Tokens.SamlAccessDecision AccessDecision { get { return default(System.IdentityModel.Tokens.SamlAccessDecision); } set { } }
    public static string ClaimType { get { return default(string); } }
    public System.IdentityModel.Tokens.SamlEvidence Evidence { get { return default(System.IdentityModel.Tokens.SamlEvidence); } set { } }
    public override bool IsReadOnly { get { return default(bool); } }
    public string Resource { get { return default(string); } set { } }
    public System.Collections.Generic.IList<System.IdentityModel.Tokens.SamlAction> SamlActions { get { return default(System.Collections.Generic.IList<System.IdentityModel.Tokens.SamlAction>); } }
    [System.MonoTODOAttribute]
    protected override void AddClaimsToList(System.Collections.Generic.IList<System.IdentityModel.Claims.Claim> claims) { }
    public override void MakeReadOnly() { }
    public override void ReadXml(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer, System.IdentityModel.Selectors.SecurityTokenResolver resolver) { }
    public override void WriteXml(System.Xml.XmlDictionaryWriter writer, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer) { }
  }
  public abstract partial class SamlCondition {
    protected SamlCondition() { }
    public abstract bool IsReadOnly { get; }
    public abstract void MakeReadOnly();
    public abstract void ReadXml(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer, System.IdentityModel.Selectors.SecurityTokenResolver outOfBandTokenResolver);
    public abstract void WriteXml(System.Xml.XmlDictionaryWriter writer, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer);
  }
  public partial class SamlConditions {
    public SamlConditions() { }
    public SamlConditions(System.DateTime notBefore, System.DateTime notOnOrAfter) { }
    public SamlConditions(System.DateTime notBefore, System.DateTime notOnOrAfter, System.Collections.Generic.IEnumerable<System.IdentityModel.Tokens.SamlCondition> conditions) { }
    public System.Collections.Generic.IList<System.IdentityModel.Tokens.SamlCondition> Conditions { get { return default(System.Collections.Generic.IList<System.IdentityModel.Tokens.SamlCondition>); } }
    public bool IsReadOnly { get { return default(bool); } }
    public System.DateTime NotBefore { get { return default(System.DateTime); } set { } }
    public System.DateTime NotOnOrAfter { get { return default(System.DateTime); } set { } }
    public void MakeReadOnly() { }
    [System.MonoTODOAttribute]
    public virtual void ReadXml(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoTokenSerializer, System.IdentityModel.Selectors.SecurityTokenResolver outOfBandTokenResolver) { }
    public virtual void WriteXml(System.Xml.XmlDictionaryWriter writer, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoTokenSerializer) { }
  }
  public static partial class SamlConstants {
    public static string EmailName { get { return default(string); } }
    public static string EmailNamespace { get { return default(string); } }
    public static string HolderOfKey { get { return default(string); } }
    public static int MajorVersionValue { get { return default(int); } }
    public static int MinorVersionValue { get { return default(int); } }
    public static string Namespace { get { return default(string); } }
    public static string SenderVouches { get { return default(string); } }
    public static string UserName { get { return default(string); } }
    public static string UserNameNamespace { get { return default(string); } }
  }
  public partial class SamlDoNotCacheCondition : System.IdentityModel.Tokens.SamlCondition {
    public SamlDoNotCacheCondition() { }
    public override bool IsReadOnly { get { return default(bool); } }
    public override void MakeReadOnly() { }
    [System.MonoTODOAttribute]
    public override void ReadXml(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer, System.IdentityModel.Selectors.SecurityTokenResolver outOfBandTokenResolver) { }
    public override void WriteXml(System.Xml.XmlDictionaryWriter writer, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer) { }
  }
  public partial class SamlEvidence {
    public SamlEvidence() { }
    public SamlEvidence(System.Collections.Generic.IEnumerable<System.IdentityModel.Tokens.SamlAssertion> assertions) { }
    public SamlEvidence(System.Collections.Generic.IEnumerable<System.String> assertionIdReferences) { }
    public SamlEvidence(System.Collections.Generic.IEnumerable<System.String> assertionIdReferences, System.Collections.Generic.IEnumerable<System.IdentityModel.Tokens.SamlAssertion> assertions) { }
    public System.Collections.Generic.IList<System.String> AssertionIdReferences { get { return default(System.Collections.Generic.IList<System.String>); } }
    public System.Collections.Generic.IList<System.IdentityModel.Tokens.SamlAssertion> Assertions { get { return default(System.Collections.Generic.IList<System.IdentityModel.Tokens.SamlAssertion>); } }
    public bool IsReadOnly { get { return default(bool); } }
    public void MakeReadOnly() { }
    public virtual void ReadXml(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer, System.IdentityModel.Selectors.SecurityTokenResolver resolver) { }
    public virtual void WriteXml(System.Xml.XmlDictionaryWriter writer, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer) { }
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public partial class SamlNameIdentifierClaimResource {
    public SamlNameIdentifierClaimResource(string name, string nameQualifier, string format) { }
    public string Format { get { return default(string); } }
    public string Name { get { return default(string); } }
    public string NameQualifier { get { return default(string); } }
  }
  public partial class SamlSecurityToken : System.IdentityModel.Tokens.SecurityToken {
    [System.MonoTODOAttribute]
    protected SamlSecurityToken() { }
    public SamlSecurityToken(System.IdentityModel.Tokens.SamlAssertion assertion) { }
    public System.IdentityModel.Tokens.SamlAssertion Assertion { get { return default(System.IdentityModel.Tokens.SamlAssertion); } }
    [System.MonoTODOAttribute]
    public override string Id { get { return default(string); } }
    [System.MonoTODOAttribute]
    public override System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SecurityKey> SecurityKeys { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SecurityKey>); } }
    [System.MonoTODOAttribute]
    public override System.DateTime ValidFrom { get { return default(System.DateTime); } }
    [System.MonoTODOAttribute]
    public override System.DateTime ValidTo { get { return default(System.DateTime); } }
    [System.MonoTODOAttribute]
    public override bool CanCreateKeyIdentifierClause<T>() { return default(bool); }
    [System.MonoTODOAttribute]
    public override T CreateKeyIdentifierClause<T>() { return default(T); }
    [System.MonoTODOAttribute]
    protected void Initialize(System.IdentityModel.Tokens.SamlAssertion assertion) { }
    [System.MonoTODOAttribute]
    public override bool MatchesKeyIdentifierClause(System.IdentityModel.Tokens.SecurityKeyIdentifierClause skiClause) { return default(bool); }
  }
  public partial class SamlSerializer {
    [System.MonoTODOAttribute]
    public SamlSerializer() { }
    [System.MonoTODOAttribute]
    public virtual System.IdentityModel.Tokens.SamlAdvice LoadAdvice(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Selectors.SecurityTokenSerializer tokenSerializer, System.IdentityModel.Selectors.SecurityTokenResolver tokenResolver) { return default(System.IdentityModel.Tokens.SamlAdvice); }
    [System.MonoTODOAttribute]
    public virtual System.IdentityModel.Tokens.SamlAssertion LoadAssertion(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Selectors.SecurityTokenSerializer tokenSerializer, System.IdentityModel.Selectors.SecurityTokenResolver tokenResolver) { return default(System.IdentityModel.Tokens.SamlAssertion); }
    [System.MonoTODOAttribute]
    public virtual System.IdentityModel.Tokens.SamlAttribute LoadAttribute(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Selectors.SecurityTokenSerializer tokenSerializer, System.IdentityModel.Selectors.SecurityTokenResolver tokenResolver) { return default(System.IdentityModel.Tokens.SamlAttribute); }
    [System.MonoTODOAttribute]
    public virtual System.IdentityModel.Tokens.SamlCondition LoadCondition(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Selectors.SecurityTokenSerializer tokenSerializer, System.IdentityModel.Selectors.SecurityTokenResolver tokenResolver) { return default(System.IdentityModel.Tokens.SamlCondition); }
    [System.MonoTODOAttribute]
    public virtual System.IdentityModel.Tokens.SamlConditions LoadConditions(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Selectors.SecurityTokenSerializer tokenSerializer, System.IdentityModel.Selectors.SecurityTokenResolver tokenResolver) { return default(System.IdentityModel.Tokens.SamlConditions); }
    [System.MonoTODOAttribute]
    public virtual System.IdentityModel.Tokens.SamlStatement LoadStatement(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Selectors.SecurityTokenSerializer tokenSerializer, System.IdentityModel.Selectors.SecurityTokenResolver tokenResolver) { return default(System.IdentityModel.Tokens.SamlStatement); }
    [System.MonoTODOAttribute]
    public void PopulateDictionary(System.Xml.IXmlDictionary dictionary) { }
    [System.MonoTODOAttribute]
    public virtual System.IdentityModel.Tokens.SamlSecurityToken ReadToken(System.Xml.XmlReader reader, System.IdentityModel.Selectors.SecurityTokenSerializer tokenSerializer, System.IdentityModel.Selectors.SecurityTokenResolver tokenResolver) { return default(System.IdentityModel.Tokens.SamlSecurityToken); }
    [System.MonoTODOAttribute]
    public virtual void WriteToken(System.IdentityModel.Tokens.SamlSecurityToken token, System.Xml.XmlWriter writer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer) { }
  }
  public abstract partial class SamlStatement {
    protected SamlStatement() { }
    public abstract bool IsReadOnly { get; }
    public abstract System.IdentityModel.Policy.IAuthorizationPolicy CreatePolicy(System.IdentityModel.Claims.ClaimSet issuer, System.IdentityModel.Selectors.SamlSecurityTokenAuthenticator samlAuthenticator);
    public abstract void MakeReadOnly();
    public abstract void ReadXml(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoTokenSerializer, System.IdentityModel.Selectors.SecurityTokenResolver outOfBandTokenResolver);
    public abstract void WriteXml(System.Xml.XmlDictionaryWriter writer, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoTokenSerializer);
  }
  public partial class SamlSubject {
    public SamlSubject() { }
    public SamlSubject(string nameFormat, string nameQualifier, string name) { }
    public SamlSubject(string nameFormat, string nameQualifier, string name, System.Collections.Generic.IEnumerable<System.String> confirmations, string confirmationData, System.IdentityModel.Tokens.SecurityKeyIdentifier securityKeyIdentifier) { }
    public System.Collections.Generic.IList<System.String> ConfirmationMethods { get { return default(System.Collections.Generic.IList<System.String>); } }
    public System.IdentityModel.Tokens.SecurityKey Crypto { get { return default(System.IdentityModel.Tokens.SecurityKey); } set { } }
    public bool IsReadOnly { get { return default(bool); } }
    public System.IdentityModel.Tokens.SecurityKeyIdentifier KeyIdentifier { get { return default(System.IdentityModel.Tokens.SecurityKeyIdentifier); } set { } }
    public string Name { get { return default(string); } set { } }
    public static string NameClaimType { get { return default(string); } }
    public string NameFormat { get { return default(string); } set { } }
    public string NameQualifier { get { return default(string); } set { } }
    public string SubjectConfirmationData { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public virtual System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Claims.Claim> ExtractClaims() { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Claims.Claim>); }
    [System.MonoTODOAttribute]
    public virtual System.IdentityModel.Claims.ClaimSet ExtractSubjectKeyClaimSet(System.IdentityModel.Selectors.SamlSecurityTokenAuthenticator samlAuthenticator) { return default(System.IdentityModel.Claims.ClaimSet); }
    public void MakeReadOnly() { }
    public virtual void ReadXml(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoTokenSerializer, System.IdentityModel.Selectors.SecurityTokenResolver outOfBandTokenResolver) { }
    public virtual void WriteXml(System.Xml.XmlDictionaryWriter writer, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoTokenSerializer) { }
  }
  public abstract partial class SamlSubjectStatement : System.IdentityModel.Tokens.SamlStatement {
    protected SamlSubjectStatement() { }
    protected SamlSubjectStatement(System.IdentityModel.Tokens.SamlSubject samlSubject) { }
    public override bool IsReadOnly { get { return default(bool); } }
    public System.IdentityModel.Tokens.SamlSubject SamlSubject { get { return default(System.IdentityModel.Tokens.SamlSubject); } set { } }
    protected abstract void AddClaimsToList(System.Collections.Generic.IList<System.IdentityModel.Claims.Claim> claims);
    [System.MonoTODOAttribute]
    public override System.IdentityModel.Policy.IAuthorizationPolicy CreatePolicy(System.IdentityModel.Claims.ClaimSet issuer, System.IdentityModel.Selectors.SamlSecurityTokenAuthenticator samlAuthenticator) { return default(System.IdentityModel.Policy.IAuthorizationPolicy); }
    public override void MakeReadOnly() { }
    protected void SetSubject(System.IdentityModel.Tokens.SamlSubject samlSubject) { }
  }
  public static partial class SecurityAlgorithms {
    public const string Aes128Encryption = "http://www.w3.org/2001/04/xmlenc#aes128-cbc";
    public const string Aes128KeyWrap = "http://www.w3.org/2001/04/xmlenc#kw-aes128";
    public const string Aes192Encryption = "http://www.w3.org/2001/04/xmlenc#aes192-cbc";
    public const string Aes192KeyWrap = "http://www.w3.org/2001/04/xmlenc#kw-aes192";
    public const string Aes256Encryption = "http://www.w3.org/2001/04/xmlenc#aes256-cbc";
    public const string Aes256KeyWrap = "http://www.w3.org/2001/04/xmlenc#kw-aes256";
    public const string DesEncryption = "http://www.w3.org/2001/04/xmlenc#des-cbc";
    public const string DsaSha1Signature = "http://www.w3.org/2000/09/xmldsig#dsa-sha1";
    public const string ExclusiveC14n = "http://www.w3.org/2001/10/xml-exc-c14n#";
    public const string ExclusiveC14nWithComments = "http://www.w3.org/2001/10/xml-exc-c14n#WithComments";
    public const string HmacSha1Signature = "http://www.w3.org/2000/09/xmldsig#hmac-sha1";
    public const string HmacSha256Signature = "http://www.w3.org/2001/04/xmldsig-more#hmac-sha256";
    public const string Psha1KeyDerivation = "http://schemas.xmlsoap.org/ws/2005/02/sc/dk/p_sha1";
    public const string Ripemd160Digest = "http://www.w3.org/2001/04/xmlenc#ripemd160";
    public const string RsaOaepKeyWrap = "http://www.w3.org/2001/04/xmlenc#rsa-oaep-mgf1p";
    public const string RsaSha1Signature = "http://www.w3.org/2000/09/xmldsig#rsa-sha1";
    public const string RsaSha256Signature = "http://www.w3.org/2001/04/xmldsig-more#rsa-sha256";
    public const string RsaV15KeyWrap = "http://www.w3.org/2001/04/xmlenc#rsa-1_5";
    public const string Sha1Digest = "http://www.w3.org/2000/09/xmldsig#sha1";
    public const string Sha256Digest = "http://www.w3.org/2001/04/xmlenc#sha256";
    public const string Sha512Digest = "http://www.w3.org/2001/04/xmlenc#sha512";
    public const string TlsSspiKeyWrap = "http://schemas.xmlsoap.org/2005/02/trust/tlsnego#TLS_Wrap";
    public const string TripleDesEncryption = "http://www.w3.org/2001/04/xmlenc#tripledes-cbc";
    public const string TripleDesKeyWrap = "http://www.w3.org/2001/04/xmlenc#kw-tripledes";
    public const string WindowsSspiKeyWrap = "http://schemas.xmlsoap.org/2005/02/trust/spnego#GSS_Wrap";
  }
  public abstract partial class SecurityKey {
    [System.MonoTODOAttribute]
    protected SecurityKey() { }
    public abstract int KeySize { get; }
    public abstract System.Byte[] DecryptKey(string algorithm, System.Byte[] keyData);
    public abstract System.Byte[] EncryptKey(string algorithm, System.Byte[] keyData);
    public abstract bool IsAsymmetricAlgorithm(string algorithm);
    public abstract bool IsSupportedAlgorithm(string algorithm);
    public abstract bool IsSymmetricAlgorithm(string algorithm);
  }
  public partial class SecurityKeyIdentifier : System.Collections.Generic.IEnumerable<System.IdentityModel.Tokens.SecurityKeyIdentifierClause>, System.Collections.IEnumerable {
    public SecurityKeyIdentifier() { }
    public SecurityKeyIdentifier(params System.IdentityModel.Tokens.SecurityKeyIdentifierClause[] identifiers) { }
    public bool CanCreateKey { get { return default(bool); } }
    public int Count { get { return default(int); } }
    public bool IsReadOnly { get { return default(bool); } }
    public System.IdentityModel.Tokens.SecurityKeyIdentifierClause this[int i] { get { return default(System.IdentityModel.Tokens.SecurityKeyIdentifierClause); } }
    public void Add(System.IdentityModel.Tokens.SecurityKeyIdentifierClause item) { }
    public System.IdentityModel.Tokens.SecurityKey CreateKey() { return default(System.IdentityModel.Tokens.SecurityKey); }
    public TClause Find<TClause>() where TClause : System.IdentityModel.Tokens.SecurityKeyIdentifierClause { return default(TClause); }
    public System.Collections.Generic.IEnumerator<System.IdentityModel.Tokens.SecurityKeyIdentifierClause> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.IdentityModel.Tokens.SecurityKeyIdentifierClause>); }
    public void MakeReadOnly() { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    public override string ToString() { return default(string); }
    public bool TryFind<TClause>(out TClause result) where TClause : System.IdentityModel.Tokens.SecurityKeyIdentifierClause { result = default(TClause); return default(bool); }
  }
  public abstract partial class SecurityKeyIdentifierClause {
    protected SecurityKeyIdentifierClause(string clauseType) { }
    protected SecurityKeyIdentifierClause(string clauseType, System.Byte[] derivationNonce, int derivationLength) { }
    public virtual bool CanCreateKey { get { return default(bool); } }
    public string ClauseType { get { return default(string); } }
    public int DerivationLength { get { return default(int); } }
    public string Id { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public virtual System.IdentityModel.Tokens.SecurityKey CreateKey() { return default(System.IdentityModel.Tokens.SecurityKey); }
    public System.Byte[] GetDerivationNonce() { return default(System.Byte[]); }
    [System.MonoTODOAttribute]
    public virtual bool Matches(System.IdentityModel.Tokens.SecurityKeyIdentifierClause clause) { return default(bool); }
  }
  public enum SecurityKeyType {
    AsymmetricKey = 1,
    SymmetricKey = 0,
  }
  public enum SecurityKeyUsage {
    Exchange = 0,
    Signature = 1,
  }
  public abstract partial class SecurityToken {
    protected SecurityToken() { }
    public abstract string Id { get; }
    public abstract System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SecurityKey> SecurityKeys { get; }
    [System.MonoTODOAttribute]
    public abstract System.DateTime ValidFrom { get; }
    [System.MonoTODOAttribute]
    public abstract System.DateTime ValidTo { get; }
    [System.MonoTODOAttribute]
    public virtual bool CanCreateKeyIdentifierClause<T>() where T : System.IdentityModel.Tokens.SecurityKeyIdentifierClause { return default(bool); }
    [System.MonoTODOAttribute]
    public virtual T CreateKeyIdentifierClause<T>() where T : System.IdentityModel.Tokens.SecurityKeyIdentifierClause { return default(T); }
    public virtual bool MatchesKeyIdentifierClause(System.IdentityModel.Tokens.SecurityKeyIdentifierClause skiClause) { return default(bool); }
    [System.MonoTODOAttribute]
    public virtual System.IdentityModel.Tokens.SecurityKey ResolveKeyIdentifierClause(System.IdentityModel.Tokens.SecurityKeyIdentifierClause skiClause) { return default(System.IdentityModel.Tokens.SecurityKey); }
  }
  public partial class SecurityTokenDescriptor {
    public SecurityTokenDescriptor() { }
    public string AppliesToAddress { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.IdentityModel.Tokens.SecurityKeyIdentifierClause AttachedReference { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.IdentityModel.Tokens.SecurityKeyIdentifierClause); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Security.Claims.AuthenticationInformation AuthenticationInfo { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Security.Claims.AuthenticationInformation); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.IdentityModel.Tokens.EncryptingCredentials EncryptingCredentials { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.IdentityModel.Tokens.EncryptingCredentials); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.IdentityModel.Protocols.WSTrust.Lifetime Lifetime { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.IdentityModel.Protocols.WSTrust.Lifetime); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.IdentityModel.Tokens.ProofDescriptor Proof { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.IdentityModel.Tokens.ProofDescriptor); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.Generic.Dictionary<System.String, System.Object> Properties { get { return default(System.Collections.Generic.Dictionary<System.String, System.Object>); } }
    public string ReplyToAddress { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.IdentityModel.Tokens.SigningCredentials SigningCredentials { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.IdentityModel.Tokens.SigningCredentials); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Security.Claims.ClaimsIdentity Subject { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Security.Claims.ClaimsIdentity); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.IdentityModel.Tokens.SecurityToken Token { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.IdentityModel.Tokens.SecurityToken); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string TokenIssuerName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string TokenType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.IdentityModel.Tokens.SecurityKeyIdentifierClause UnattachedReference { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.IdentityModel.Tokens.SecurityKeyIdentifierClause); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public void AddAuthenticationClaims(string authType) { }
    [System.MonoTODOAttribute]
    public void AddAuthenticationClaims(string authType, System.DateTime time) { }
    [System.MonoTODOAttribute]
    public virtual void ApplyTo(System.IdentityModel.Protocols.WSTrust.RequestSecurityTokenResponse response) { }
  }
  public partial class SecurityTokenException : System.SystemException {
    public SecurityTokenException() { }
    protected SecurityTokenException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public SecurityTokenException(string msg) { }
    public SecurityTokenException(string msg, System.Exception inner) { }
  }
  public partial class SecurityTokenExpiredException : System.IdentityModel.Tokens.SecurityTokenValidationException {
    public SecurityTokenExpiredException() { }
    public SecurityTokenExpiredException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public SecurityTokenExpiredException(string message) { }
    public SecurityTokenExpiredException(string message, System.Exception innerException) { }
  }
  public abstract partial class SecurityTokenHandler : System.IdentityModel.Configuration.ICustomIdentityConfiguration {
    protected SecurityTokenHandler() { }
    public virtual bool CanValidateToken { get { return default(bool); } }
    public virtual bool CanWriteToken { get { return default(bool); } }
    public System.IdentityModel.Tokens.SecurityTokenHandlerConfiguration Configuration { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.IdentityModel.Tokens.SecurityTokenHandlerConfiguration); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.IdentityModel.Tokens.SecurityTokenHandlerCollection ContainingCollection { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.IdentityModel.Tokens.SecurityTokenHandlerCollection); } }
    public abstract System.Type TokenType { get; }
    public virtual bool CanReadKeyIdentifierClause(System.Xml.XmlReader reader) { return default(bool); }
    public virtual bool CanReadToken(string tokenString) { return default(bool); }
    public virtual bool CanReadToken(System.Xml.XmlReader reader) { return default(bool); }
    public virtual bool CanWriteKeyIdentifierClause(System.IdentityModel.Tokens.SecurityKeyIdentifierClause securityKeyIdentifierClause) { return default(bool); }
    public virtual System.IdentityModel.Tokens.SecurityKeyIdentifierClause CreateSecurityTokenReference(System.IdentityModel.Tokens.SecurityToken token, bool attached) { return default(System.IdentityModel.Tokens.SecurityKeyIdentifierClause); }
    public virtual System.IdentityModel.Tokens.SecurityToken CreateToken(System.IdentityModel.Tokens.SecurityTokenDescriptor tokenDescriptor) { return default(System.IdentityModel.Tokens.SecurityToken); }
    protected virtual void DetectReplayedToken(System.IdentityModel.Tokens.SecurityToken token) { }
    public abstract System.String[] GetTokenTypeIdentifiers();
    public virtual void LoadCustomConfiguration(System.Xml.XmlNodeList nodelist) { }
    public virtual System.IdentityModel.Tokens.SecurityKeyIdentifierClause ReadKeyIdentifierClause(System.Xml.XmlReader reader) { return default(System.IdentityModel.Tokens.SecurityKeyIdentifierClause); }
    public virtual System.IdentityModel.Tokens.SecurityToken ReadToken(string tokenString) { return default(System.IdentityModel.Tokens.SecurityToken); }
    public virtual System.IdentityModel.Tokens.SecurityToken ReadToken(System.Xml.XmlReader reader) { return default(System.IdentityModel.Tokens.SecurityToken); }
    public virtual System.IdentityModel.Tokens.SecurityToken ReadToken(System.Xml.XmlReader reader, System.IdentityModel.Selectors.SecurityTokenResolver tokenResolver) { return default(System.IdentityModel.Tokens.SecurityToken); }
    protected void TraceTokenValidationFailure(System.IdentityModel.Tokens.SecurityToken token, string errorMessage) { }
    protected void TraceTokenValidationSuccess(System.IdentityModel.Tokens.SecurityToken token) { }
    public virtual System.Collections.ObjectModel.ReadOnlyCollection<System.Security.Claims.ClaimsIdentity> ValidateToken(System.IdentityModel.Tokens.SecurityToken token) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Security.Claims.ClaimsIdentity>); }
    public virtual void WriteKeyIdentifierClause(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SecurityKeyIdentifierClause securityKeyIdentifierClause) { }
    public virtual string WriteToken(System.IdentityModel.Tokens.SecurityToken token) { return default(string); }
    public virtual void WriteToken(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SecurityToken token) { }
  }
  public partial class SecurityTokenHandlerCollection : System.Collections.ObjectModel.Collection<System.IdentityModel.Tokens.SecurityTokenHandler> {
    public SecurityTokenHandlerCollection() { }
    public SecurityTokenHandlerCollection(System.Collections.Generic.IEnumerable<System.IdentityModel.Tokens.SecurityTokenHandler> handlers) { }
    public SecurityTokenHandlerCollection(System.Collections.Generic.IEnumerable<System.IdentityModel.Tokens.SecurityTokenHandler> handlers, System.IdentityModel.Tokens.SecurityTokenHandlerConfiguration configuration) { }
    public SecurityTokenHandlerCollection(System.IdentityModel.Tokens.SecurityTokenHandlerConfiguration configuration) { }
    public System.IdentityModel.Tokens.SecurityTokenHandlerConfiguration Configuration { get { return default(System.IdentityModel.Tokens.SecurityTokenHandlerConfiguration); } }
    public System.IdentityModel.Tokens.SecurityTokenHandler this[System.IdentityModel.Tokens.SecurityToken token] { get { return default(System.IdentityModel.Tokens.SecurityTokenHandler); } }
    [System.MonoTODOAttribute]
    public System.IdentityModel.Tokens.SecurityTokenHandler this[string tokenTypeIdentifier] { get { return default(System.IdentityModel.Tokens.SecurityTokenHandler); } }
    [System.MonoTODOAttribute]
    public System.IdentityModel.Tokens.SecurityTokenHandler this[System.Type tokenType] { get { return default(System.IdentityModel.Tokens.SecurityTokenHandler); } }
    public System.Collections.Generic.IEnumerable<System.String> TokenTypeIdentifiers { get { return default(System.Collections.Generic.IEnumerable<System.String>); } }
    public System.Collections.Generic.IEnumerable<System.Type> TokenTypes { get { return default(System.Collections.Generic.IEnumerable<System.Type>); } }
    [System.MonoTODOAttribute]
    public void AddOrReplace(System.IdentityModel.Tokens.SecurityTokenHandler handler) { }
    [System.MonoTODOAttribute]
    public bool CanReadKeyIdentifierClause(System.Xml.XmlReader reader) { return default(bool); }
    [System.MonoTODOAttribute]
    protected virtual bool CanReadKeyIdentifierClauseCore(System.Xml.XmlReader reader) { return default(bool); }
    [System.MonoTODOAttribute]
    public bool CanReadToken(string tokenString) { return default(bool); }
    [System.MonoTODOAttribute]
    public bool CanReadToken(System.Xml.XmlReader reader) { return default(bool); }
    [System.MonoTODOAttribute]
    public bool CanWriteToken(System.IdentityModel.Tokens.SecurityToken token) { return default(bool); }
    [System.MonoTODOAttribute]
    protected override void ClearItems() { }
    [System.MonoTODOAttribute]
    public static System.IdentityModel.Tokens.SecurityTokenHandlerCollection CreateDefaultSecurityTokenHandlerCollection() { return default(System.IdentityModel.Tokens.SecurityTokenHandlerCollection); }
    [System.MonoTODOAttribute]
    public static System.IdentityModel.Tokens.SecurityTokenHandlerCollection CreateDefaultSecurityTokenHandlerCollection(System.IdentityModel.Tokens.SecurityTokenHandlerConfiguration configuration) { return default(System.IdentityModel.Tokens.SecurityTokenHandlerCollection); }
    [System.MonoTODOAttribute]
    public System.IdentityModel.Tokens.SecurityToken CreateToken(System.IdentityModel.Tokens.SecurityTokenDescriptor tokenDescriptor) { return default(System.IdentityModel.Tokens.SecurityToken); }
    [System.MonoTODOAttribute]
    protected override void InsertItem(int index, System.IdentityModel.Tokens.SecurityTokenHandler item) { }
    [System.MonoTODOAttribute]
    public System.IdentityModel.Tokens.SecurityKeyIdentifierClause ReadKeyIdentifierClause(System.Xml.XmlReader reader) { return default(System.IdentityModel.Tokens.SecurityKeyIdentifierClause); }
    [System.MonoTODOAttribute]
    protected virtual System.IdentityModel.Tokens.SecurityKeyIdentifierClause ReadKeyIdentifierClauseCore(System.Xml.XmlReader reader) { return default(System.IdentityModel.Tokens.SecurityKeyIdentifierClause); }
    [System.MonoTODOAttribute]
    public System.IdentityModel.Tokens.SecurityToken ReadToken(string tokenString) { return default(System.IdentityModel.Tokens.SecurityToken); }
    [System.MonoTODOAttribute]
    public System.IdentityModel.Tokens.SecurityToken ReadToken(System.Xml.XmlReader reader) { return default(System.IdentityModel.Tokens.SecurityToken); }
    [System.MonoTODOAttribute]
    protected override void RemoveItem(int index) { }
    [System.MonoTODOAttribute]
    protected override void SetItem(int index, System.IdentityModel.Tokens.SecurityTokenHandler item) { }
    [System.MonoTODOAttribute]
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Security.Claims.ClaimsIdentity> ValidateToken(System.IdentityModel.Tokens.SecurityToken token) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Security.Claims.ClaimsIdentity>); }
    [System.MonoTODOAttribute]
    public void WriteKeyIdentifierClause(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause) { }
    [System.MonoTODOAttribute]
    protected virtual void WriteKeyIdentifierClauseCore(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause) { }
    [System.MonoTODOAttribute]
    public string WriteToken(System.IdentityModel.Tokens.SecurityToken token) { return default(string); }
    [System.MonoTODOAttribute]
    public void WriteToken(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SecurityToken token) { }
  }
  public partial class SecurityTokenHandlerConfiguration {
    public static readonly System.ServiceModel.Security.X509CertificateValidationMode DefaultCertificateValidationMode;
    public static readonly System.IdentityModel.Selectors.X509CertificateValidator DefaultCertificateValidator;
    public static readonly bool DefaultDetectReplayedTokens;
    public static readonly System.IdentityModel.Tokens.IssuerNameRegistry DefaultIssuerNameRegistry;
    public static readonly System.IdentityModel.Selectors.SecurityTokenResolver DefaultIssuerTokenResolver;
    public static readonly System.TimeSpan DefaultMaxClockSkew;
    public static readonly System.Security.Cryptography.X509Certificates.X509RevocationMode DefaultRevocationMode;
    public static readonly bool DefaultSaveBootstrapContext;
    public static readonly System.TimeSpan DefaultTokenReplayCacheExpirationPeriod;
    public static readonly System.Security.Cryptography.X509Certificates.StoreLocation DefaultTrustedStoreLocation;
    public SecurityTokenHandlerConfiguration() { }
    public System.IdentityModel.Tokens.AudienceRestriction AudienceRestriction { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.IdentityModel.Tokens.AudienceRestriction); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.IdentityModel.Configuration.IdentityModelCaches Caches { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.IdentityModel.Configuration.IdentityModelCaches); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.ServiceModel.Security.X509CertificateValidationMode CertificateValidationMode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Security.X509CertificateValidationMode); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.IdentityModel.Selectors.X509CertificateValidator CertificateValidator { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.IdentityModel.Selectors.X509CertificateValidator); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool DetectReplayedTokens { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.IdentityModel.Tokens.IssuerNameRegistry IssuerNameRegistry { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.IdentityModel.Tokens.IssuerNameRegistry); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.IdentityModel.Selectors.SecurityTokenResolver IssuerTokenResolver { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.IdentityModel.Selectors.SecurityTokenResolver); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.TimeSpan MaxClockSkew { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.TimeSpan); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Security.Cryptography.X509Certificates.X509RevocationMode RevocationMode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Security.Cryptography.X509Certificates.X509RevocationMode); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool SaveBootstrapContext { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.IdentityModel.Selectors.SecurityTokenResolver ServiceTokenResolver { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.IdentityModel.Selectors.SecurityTokenResolver); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.TimeSpan TokenReplayCacheExpirationPeriod { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.TimeSpan); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Security.Cryptography.X509Certificates.StoreLocation TrustedStoreLocation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Security.Cryptography.X509Certificates.StoreLocation); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial class SecurityTokenNotYetValidException : System.IdentityModel.Tokens.SecurityTokenValidationException {
    public SecurityTokenNotYetValidException() { }
    public SecurityTokenNotYetValidException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public SecurityTokenNotYetValidException(string message) { }
    public SecurityTokenNotYetValidException(string message, System.Exception innerException) { }
  }
  public partial class SecurityTokenReplayDetectedException : System.IdentityModel.Tokens.SecurityTokenValidationException {
    public SecurityTokenReplayDetectedException() { }
    public SecurityTokenReplayDetectedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public SecurityTokenReplayDetectedException(string message) { }
    public SecurityTokenReplayDetectedException(string message, System.Exception innerException) { }
  }
  public static partial class SecurityTokenTypes {
    public static string Kerberos { get { return default(string); } }
    public static string Rsa { get { return default(string); } }
    public static string Saml { get { return default(string); } }
    public static string UserName { get { return default(string); } }
    public static string X509Certificate { get { return default(string); } }
  }
  public partial class SecurityTokenValidationException : System.IdentityModel.Tokens.SecurityTokenException {
    public SecurityTokenValidationException() { }
    protected SecurityTokenValidationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public SecurityTokenValidationException(string msg) { }
    public SecurityTokenValidationException(string msg, System.Exception inner) { }
  }
  public partial class SessionSecurityToken : System.IdentityModel.Tokens.SecurityToken {
    protected SessionSecurityToken(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public SessionSecurityToken(System.Security.Claims.ClaimsPrincipal claimsPrincipal) { }
    public SessionSecurityToken(System.Security.Claims.ClaimsPrincipal claimsPrincipal, string context) { }
    public SessionSecurityToken(System.Security.Claims.ClaimsPrincipal claimsPrincipal, string context, System.Nullable<System.DateTime> validFrom, System.Nullable<System.DateTime> validTo) { }
    public SessionSecurityToken(System.Security.Claims.ClaimsPrincipal claimsPrincipal, string context, string endpointId, System.Nullable<System.DateTime> validFrom, System.Nullable<System.DateTime> validTo) { }
    public SessionSecurityToken(System.Security.Claims.ClaimsPrincipal claimsPrincipal, System.TimeSpan lifetime) { }
    public SessionSecurityToken(System.Security.Claims.ClaimsPrincipal claimsPrincipal, System.Xml.UniqueId contextId, string context, string endpointId, System.DateTime validFrom, System.TimeSpan lifetime, System.IdentityModel.Tokens.SymmetricSecurityKey key) { }
    public SessionSecurityToken(System.Security.Claims.ClaimsPrincipal claimsPrincipal, System.Xml.UniqueId contextId, string context, string endpointId, System.Nullable<System.DateTime> validFrom, System.Nullable<System.DateTime> validTo, System.IdentityModel.Tokens.SymmetricSecurityKey key) { }
    public SessionSecurityToken(System.Security.Claims.ClaimsPrincipal claimsPrincipal, System.Xml.UniqueId contextId, string context, string endpointId, System.TimeSpan lifetime, System.IdentityModel.Tokens.SymmetricSecurityKey key) { }
    public System.Security.Claims.ClaimsPrincipal ClaimsPrincipal { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Security.Claims.ClaimsPrincipal); } }
    public string Context { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public System.Xml.UniqueId ContextId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xml.UniqueId); } }
    public string EndpointId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    [System.MonoTODOAttribute]
    public override string Id { get { return default(string); } }
    public bool IsPersistent { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool IsReferenceMode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.DateTime KeyEffectiveTime { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.DateTime); } }
    public System.DateTime KeyExpirationTime { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.DateTime); } }
    public System.Xml.UniqueId KeyGeneration { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xml.UniqueId); } }
    public System.Uri SecureConversationVersion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Uri); } }
    public override System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SecurityKey> SecurityKeys { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SecurityKey>); } }
    public override System.DateTime ValidFrom { get { return default(System.DateTime); } }
    public override System.DateTime ValidTo { get { return default(System.DateTime); } }
    [System.MonoTODOAttribute]
    public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public abstract partial class SessionSecurityTokenCache : System.IdentityModel.Configuration.ICustomIdentityConfiguration {
    protected SessionSecurityTokenCache() { }
    public abstract void AddOrUpdate(System.IdentityModel.Tokens.SessionSecurityTokenCacheKey key, System.IdentityModel.Tokens.SessionSecurityToken value, System.DateTime expiryTime);
    public abstract System.IdentityModel.Tokens.SessionSecurityToken Get(System.IdentityModel.Tokens.SessionSecurityTokenCacheKey key);
    public abstract System.Collections.Generic.IEnumerable<System.IdentityModel.Tokens.SessionSecurityToken> GetAll(string endpointId, System.Xml.UniqueId contextId);
    [System.MonoTODOAttribute]
    public virtual void LoadCustomConfiguration(System.Xml.XmlNodeList nodelist) { }
    public abstract void Remove(System.IdentityModel.Tokens.SessionSecurityTokenCacheKey key);
    public abstract void RemoveAll(string endpointId);
    public abstract void RemoveAll(string endpointId, System.Xml.UniqueId contextId);
  }
  public partial class SessionSecurityTokenCacheKey {
    public SessionSecurityTokenCacheKey(string endpointId, System.Xml.UniqueId contextId, System.Xml.UniqueId keyGeneration) { }
    public System.Xml.UniqueId ContextId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xml.UniqueId); } }
    public string EndpointId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public bool IgnoreKeyGeneration { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Xml.UniqueId KeyGeneration { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xml.UniqueId); } }
    [System.MonoTODOAttribute]
    public override bool Equals(object obj) { return default(bool); }
    [System.MonoTODOAttribute]
    public override int GetHashCode() { return default(int); }
    [System.MonoTODOAttribute]
    public static bool operator ==(System.IdentityModel.Tokens.SessionSecurityTokenCacheKey first, System.IdentityModel.Tokens.SessionSecurityTokenCacheKey second) { return default(bool); }
    [System.MonoTODOAttribute]
    public static bool operator !=(System.IdentityModel.Tokens.SessionSecurityTokenCacheKey first, System.IdentityModel.Tokens.SessionSecurityTokenCacheKey second) { return default(bool); }
    [System.MonoTODOAttribute]
    public override string ToString() { return default(string); }
  }
  public partial class SessionSecurityTokenHandler : System.IdentityModel.Tokens.SecurityTokenHandler {
    public static readonly System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.CookieTransform> DefaultCookieTransforms;
    public static readonly System.TimeSpan DefaultLifetime;
    public SessionSecurityTokenHandler() { }
    public SessionSecurityTokenHandler(System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.CookieTransform> transforms) { }
    public SessionSecurityTokenHandler(System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.CookieTransform> transforms, System.TimeSpan tokenLifetime) { }
    public override bool CanValidateToken { get { return default(bool); } }
    public override bool CanWriteToken { get { return default(bool); } }
    public virtual string CookieElementName { get { return default(string); } }
    public virtual string CookieNamespace { get { return default(string); } }
    public static System.TimeSpan DefaultTokenLifetime { get { return default(System.TimeSpan); } }
    public virtual System.TimeSpan TokenLifetime { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.TimeSpan); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override System.Type TokenType { get { return default(System.Type); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.CookieTransform> Transforms { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.CookieTransform>); } }
    [System.MonoTODOAttribute]
    protected virtual System.Byte[] ApplyTransforms(System.Byte[] cookie, bool outbound) { return default(System.Byte[]); }
    [System.MonoTODOAttribute]
    public override bool CanReadToken(System.Xml.XmlReader reader) { return default(bool); }
    [System.MonoTODOAttribute]
    public virtual System.IdentityModel.Tokens.SessionSecurityToken CreateSessionSecurityToken(System.Security.Claims.ClaimsPrincipal principal, string context, string endpointId, System.DateTime validFrom, System.DateTime validTo) { return default(System.IdentityModel.Tokens.SessionSecurityToken); }
    [System.MonoTODOAttribute]
    public override System.IdentityModel.Tokens.SecurityToken CreateToken(System.IdentityModel.Tokens.SecurityTokenDescriptor tokenDescriptor) { return default(System.IdentityModel.Tokens.SecurityToken); }
    [System.MonoTODOAttribute]
    public override System.String[] GetTokenTypeIdentifiers() { return default(System.String[]); }
    [System.MonoTODOAttribute]
    public override void LoadCustomConfiguration(System.Xml.XmlNodeList customConfigElements) { }
    [System.MonoTODOAttribute]
    public virtual System.IdentityModel.Tokens.SecurityToken ReadToken(System.Byte[] token, System.IdentityModel.Selectors.SecurityTokenResolver tokenResolver) { return default(System.IdentityModel.Tokens.SecurityToken); }
    [System.MonoTODOAttribute]
    public override System.IdentityModel.Tokens.SecurityToken ReadToken(System.Xml.XmlReader reader) { return default(System.IdentityModel.Tokens.SecurityToken); }
    [System.MonoTODOAttribute]
    public override System.IdentityModel.Tokens.SecurityToken ReadToken(System.Xml.XmlReader reader, System.IdentityModel.Selectors.SecurityTokenResolver tokenResolver) { return default(System.IdentityModel.Tokens.SecurityToken); }
    [System.MonoTODOAttribute]
    protected void SetTransforms(System.Collections.Generic.IEnumerable<System.IdentityModel.CookieTransform> transforms) { }
    [System.MonoTODOAttribute]
    protected virtual void ValidateSession(System.IdentityModel.Tokens.SessionSecurityToken securityToken) { }
    [System.MonoTODOAttribute]
    public override System.Collections.ObjectModel.ReadOnlyCollection<System.Security.Claims.ClaimsIdentity> ValidateToken(System.IdentityModel.Tokens.SecurityToken token) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Security.Claims.ClaimsIdentity>); }
    [System.MonoTODOAttribute]
    public virtual System.Collections.ObjectModel.ReadOnlyCollection<System.Security.Claims.ClaimsIdentity> ValidateToken(System.IdentityModel.Tokens.SessionSecurityToken token, string endpointId) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Security.Claims.ClaimsIdentity>); }
    [System.MonoTODOAttribute]
    public virtual System.Byte[] WriteToken(System.IdentityModel.Tokens.SessionSecurityToken sessionToken) { return default(System.Byte[]); }
    [System.MonoTODOAttribute]
    public override void WriteToken(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SecurityToken token) { }
  }
  public partial class SigningCredentials {
    public SigningCredentials(System.IdentityModel.Tokens.SecurityKey signingKey, string signatureAlgorithm, string digestAlgorithm) { }
    public SigningCredentials(System.IdentityModel.Tokens.SecurityKey signingKey, string signatureAlgorithm, string digestAlgorithm, System.IdentityModel.Tokens.SecurityKeyIdentifier signingKeyIdentifier) { }
    public string DigestAlgorithm { get { return default(string); } }
    public string SignatureAlgorithm { get { return default(string); } }
    public System.IdentityModel.Tokens.SecurityKey SigningKey { get { return default(System.IdentityModel.Tokens.SecurityKey); } }
    public System.IdentityModel.Tokens.SecurityKeyIdentifier SigningKeyIdentifier { get { return default(System.IdentityModel.Tokens.SecurityKeyIdentifier); } }
  }
  public abstract partial class SymmetricSecurityKey : System.IdentityModel.Tokens.SecurityKey {
    [System.MonoTODOAttribute]
    protected SymmetricSecurityKey() { }
    public abstract System.Byte[] GenerateDerivedKey(string algorithm, System.Byte[] label, System.Byte[] nonce, int derivedKeyLength, int offset);
    public abstract System.Security.Cryptography.ICryptoTransform GetDecryptionTransform(string algorithm, System.Byte[] iv);
    public abstract System.Security.Cryptography.ICryptoTransform GetEncryptionTransform(string algorithm, System.Byte[] iv);
    public abstract int GetIVSize(string algorithm);
    public abstract System.Security.Cryptography.KeyedHashAlgorithm GetKeyedHashAlgorithm(string algorithm);
    public abstract System.Security.Cryptography.SymmetricAlgorithm GetSymmetricAlgorithm(string algorithm);
    public abstract System.Byte[] GetSymmetricKey();
  }
  public abstract partial class TokenReplayCache : System.IdentityModel.Configuration.ICustomIdentityConfiguration {
    protected TokenReplayCache() { }
    public abstract void AddOrUpdate(string key, System.IdentityModel.Tokens.SecurityToken securityToken, System.DateTime expirationTime);
    public abstract bool Contains(string key);
    public abstract System.IdentityModel.Tokens.SecurityToken Get(string key);
    [System.MonoTODOAttribute]
    public virtual void LoadCustomConfiguration(System.Xml.XmlNodeList nodelist) { }
    public abstract void Remove(string key);
  }
  public partial class UserNameSecurityToken : System.IdentityModel.Tokens.SecurityToken {
    public UserNameSecurityToken(string userName, string password) { }
    public UserNameSecurityToken(string userName, string password, string id) { }
    public override string Id { get { return default(string); } }
    public string Password { get { return default(string); } }
    public override System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SecurityKey> SecurityKeys { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SecurityKey>); } }
    public string UserName { get { return default(string); } }
    public override System.DateTime ValidFrom { get { return default(System.DateTime); } }
    public override System.DateTime ValidTo { get { return default(System.DateTime); } }
  }
  public partial class WindowsSecurityToken : System.IdentityModel.Tokens.SecurityToken {
    [System.MonoTODOAttribute]
    public WindowsSecurityToken() { }
    [System.MonoTODOAttribute]
    public WindowsSecurityToken(System.Security.Principal.WindowsIdentity identity) { }
    public WindowsSecurityToken(System.Security.Principal.WindowsIdentity identity, string id) { }
    public override string Id { get { return default(string); } }
    [System.MonoTODOAttribute]
    public override System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SecurityKey> SecurityKeys { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SecurityKey>); } }
    [System.MonoTODOAttribute]
    public override System.DateTime ValidFrom { get { return default(System.DateTime); } }
    [System.MonoTODOAttribute]
    public override System.DateTime ValidTo { get { return default(System.DateTime); } }
    public System.Security.Principal.WindowsIdentity WindowsIdentity { get { return default(System.Security.Principal.WindowsIdentity); } }
  }
  public partial class X509AsymmetricSecurityKey : System.IdentityModel.Tokens.AsymmetricSecurityKey {
    public X509AsymmetricSecurityKey(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
    public override int KeySize { get { return default(int); } }
    public override System.Byte[] DecryptKey(string algorithm, System.Byte[] keyData) { return default(System.Byte[]); }
    public override System.Byte[] EncryptKey(string algorithm, System.Byte[] keyData) { return default(System.Byte[]); }
    public override System.Security.Cryptography.AsymmetricAlgorithm GetAsymmetricAlgorithm(string algorithm, bool privateKey) { return default(System.Security.Cryptography.AsymmetricAlgorithm); }
    public override System.Security.Cryptography.HashAlgorithm GetHashAlgorithmForSignature(string algorithm) { return default(System.Security.Cryptography.HashAlgorithm); }
    public override System.Security.Cryptography.AsymmetricSignatureDeformatter GetSignatureDeformatter(string algorithm) { return default(System.Security.Cryptography.AsymmetricSignatureDeformatter); }
    public override System.Security.Cryptography.AsymmetricSignatureFormatter GetSignatureFormatter(string algorithm) { return default(System.Security.Cryptography.AsymmetricSignatureFormatter); }
    public override bool HasPrivateKey() { return default(bool); }
    public override bool IsAsymmetricAlgorithm(string algorithm) { return default(bool); }
    public override bool IsSupportedAlgorithm(string algorithm) { return default(bool); }
    public override bool IsSymmetricAlgorithm(string algorithm) { return default(bool); }
  }
  public partial class X509IssuerSerialKeyIdentifierClause : System.IdentityModel.Tokens.SecurityKeyIdentifierClause {
    public X509IssuerSerialKeyIdentifierClause(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) : base (default(string)) { }
    public X509IssuerSerialKeyIdentifierClause(string issuerName, string issuerSerialNumber) : base (default(string)) { }
    public string IssuerName { get { return default(string); } }
    public string IssuerSerialNumber { get { return default(string); } }
    public override bool Matches(System.IdentityModel.Tokens.SecurityKeyIdentifierClause clause) { return default(bool); }
    public bool Matches(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { return default(bool); }
    public bool Matches(string issuerName, string issuerSerialNumber) { return default(bool); }
    [System.MonoTODOAttribute]
    public override string ToString() { return default(string); }
  }
  public partial class X509RawDataKeyIdentifierClause : System.IdentityModel.Tokens.BinaryKeyIdentifierClause {
    public X509RawDataKeyIdentifierClause(System.Byte[] certificateRawData) : base (default(string), default(System.Byte[]), default(bool)) { }
    public X509RawDataKeyIdentifierClause(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) : base (default(string), default(System.Byte[]), default(bool)) { }
    public override bool CanCreateKey { get { return default(bool); } }
    public override System.IdentityModel.Tokens.SecurityKey CreateKey() { return default(System.IdentityModel.Tokens.SecurityKey); }
    [System.MonoTODOAttribute("Not sure what should be returned when there are public/private pair key and public-only key")]
    public System.Byte[] GetX509RawData() { return default(System.Byte[]); }
    [System.MonoTODOAttribute("Not sure what should be returned when there are public/private pair key and public-only key")]
    public bool Matches(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { return default(bool); }
    [System.MonoTODOAttribute]
    public override string ToString() { return default(string); }
  }
  public partial class X509SecurityToken : System.IdentityModel.Tokens.SecurityToken, System.IDisposable {
    public X509SecurityToken(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
    public X509SecurityToken(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, string id) { }
    public System.Security.Cryptography.X509Certificates.X509Certificate2 Certificate { get { return default(System.Security.Cryptography.X509Certificates.X509Certificate2); } }
    public override string Id { get { return default(string); } }
    public override System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SecurityKey> SecurityKeys { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SecurityKey>); } }
    public override System.DateTime ValidFrom { get { return default(System.DateTime); } }
    public override System.DateTime ValidTo { get { return default(System.DateTime); } }
    public override bool CanCreateKeyIdentifierClause<T>() { return default(bool); }
    public override T CreateKeyIdentifierClause<T>() { return default(T); }
    public virtual void Dispose() { }
    [System.MonoTODOAttribute]
    public override bool MatchesKeyIdentifierClause(System.IdentityModel.Tokens.SecurityKeyIdentifierClause skiClause) { return default(bool); }
    protected void ThrowIfDisposed() { }
  }
  public partial class X509SigningCredentials : System.IdentityModel.Tokens.SigningCredentials {
    public X509SigningCredentials(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) : base (default(System.IdentityModel.Tokens.SecurityKey), default(string), default(string)) { }
    public X509SigningCredentials(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, System.IdentityModel.Tokens.SecurityKeyIdentifier ski) : base (default(System.IdentityModel.Tokens.SecurityKey), default(string), default(string)) { }
    public X509SigningCredentials(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, System.IdentityModel.Tokens.SecurityKeyIdentifier ski, string signatureAlgorithm, string digestAlgorithm) : base (default(System.IdentityModel.Tokens.SecurityKey), default(string), default(string)) { }
    public X509SigningCredentials(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, string signatureAlgorithm, string digestAlgorithm) : base (default(System.IdentityModel.Tokens.SecurityKey), default(string), default(string)) { }
    public System.Security.Cryptography.X509Certificates.X509Certificate2 Certificate { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Security.Cryptography.X509Certificates.X509Certificate2); } }
  }
  public partial class X509SubjectKeyIdentifierClause : System.IdentityModel.Tokens.BinaryKeyIdentifierClause {
    [System.MonoTODOAttribute]
    public X509SubjectKeyIdentifierClause(System.Byte[] certificateSubject) : base (default(string), default(System.Byte[]), default(bool)) { }
    [System.MonoTODOAttribute]
    public static bool CanCreateFrom(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { return default(bool); }
    [System.MonoTODOAttribute]
    public System.Byte[] GetX509SubjectKeyIdentifier() { return default(System.Byte[]); }
    [System.MonoTODOAttribute]
    public bool Matches(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { return default(bool); }
    [System.MonoTODOAttribute]
    public override string ToString() { return default(string); }
    [System.MonoTODOAttribute]
    public static bool TryCreateFrom(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, out System.IdentityModel.Tokens.X509SubjectKeyIdentifierClause clause) { clause = default(System.IdentityModel.Tokens.X509SubjectKeyIdentifierClause); return default(bool); }
  }
  public partial class X509ThumbprintKeyIdentifierClause : System.IdentityModel.Tokens.BinaryKeyIdentifierClause {
    public X509ThumbprintKeyIdentifierClause(System.Byte[] certificateThumbprint) : base (default(string), default(System.Byte[]), default(bool)) { }
    public X509ThumbprintKeyIdentifierClause(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) : base (default(string), default(System.Byte[]), default(bool)) { }
    public System.Byte[] GetX509Thumbprint() { return default(System.Byte[]); }
    public bool Matches(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { return default(bool); }
    [System.MonoTODOAttribute]
    public override string ToString() { return default(string); }
  }
  public partial class X509WindowsSecurityToken : System.IdentityModel.Tokens.X509SecurityToken {
    [System.MonoTODOAttribute]
    public X509WindowsSecurityToken(System.Security.Cryptography.X509Certificates.X509Certificate2 cert, System.Security.Principal.WindowsIdentity identity) : base (default(System.Security.Cryptography.X509Certificates.X509Certificate2)) { }
    public X509WindowsSecurityToken(System.Security.Cryptography.X509Certificates.X509Certificate2 cert, System.Security.Principal.WindowsIdentity identity, string id) : base (default(System.Security.Cryptography.X509Certificates.X509Certificate2)) { }
    public System.Security.Principal.WindowsIdentity WindowsIdentity { get { return default(System.Security.Principal.WindowsIdentity); } }
  }
}
namespace System.Security.Claims {
  public partial class AuthenticationInformation {
    public AuthenticationInformation() { }
    public string Address { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.ObjectModel.Collection<System.IdentityModel.Tokens.AuthenticationContext> AuthorizationContexts { get { return default(System.Collections.ObjectModel.Collection<System.IdentityModel.Tokens.AuthenticationContext>); } }
    public string DnsName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Nullable<System.DateTime> NotOnOrAfter { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.DateTime>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Session { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public static partial class AuthenticationTypes {
    public const string Basic = "Basic";
    public const string Federation = "Federation";
    public const string Kerberos = "Kerberos";
    public const string Negotiate = "Negotiate";
    public const string Password = "Password";
    public const string Signature = "Signature";
    public const string Windows = "Windows";
    public const string X509 = "X509";
  }
}
namespace System.ServiceModel.Security {
  public enum X509CertificateValidationMode {
    ChainTrust = 2,
    Custom = 4,
    None = 0,
    PeerOrChainTrust = 3,
    PeerTrust = 1,
  }
}
