namespace System.IdentityModel.Selectors {
  public partial class CardSpaceException : System.Exception {
    public CardSpaceException() { }
    protected CardSpaceException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public CardSpaceException(string message) { }
    public CardSpaceException(string message, System.Exception innerException) { }
  }
  public partial class CardSpacePolicyElement {
    public CardSpacePolicyElement(System.Xml.XmlElement target, System.Xml.XmlElement issuer, System.Collections.ObjectModel.Collection<System.Xml.XmlElement> parameters, System.Uri policyNoticeLink, int policyNoticeVersion, bool isManagedIssuer) { }
    public bool IsManagedIssuer { get { return default(bool); } set { } }
    public System.Xml.XmlElement Issuer { get { return default(System.Xml.XmlElement); } set { } }
    public System.Collections.ObjectModel.Collection<System.Xml.XmlElement> Parameters { get { return default(System.Collections.ObjectModel.Collection<System.Xml.XmlElement>); } }
    public System.Uri PolicyNoticeLink { get { return default(System.Uri); } set { } }
    public int PolicyNoticeVersion { get { return default(int); } set { } }
    public System.Xml.XmlElement Target { get { return default(System.Xml.XmlElement); } set { } }
  }
  public static partial class CardSpaceSelector {
    [System.MonoTODOAttribute]
    public static System.IdentityModel.Tokens.GenericXmlSecurityToken GetToken(System.IdentityModel.Selectors.CardSpacePolicyElement[] policyChain, System.IdentityModel.Selectors.SecurityTokenSerializer serializer) { return default(System.IdentityModel.Tokens.GenericXmlSecurityToken); }
    public static System.IdentityModel.Tokens.GenericXmlSecurityToken GetToken(System.Xml.XmlElement endpoint, System.Collections.Generic.IEnumerable<System.Xml.XmlElement> policy, System.Xml.XmlElement requiredRemoteTokenIssuer, System.IdentityModel.Selectors.SecurityTokenSerializer serializer) { return default(System.IdentityModel.Tokens.GenericXmlSecurityToken); }
    [System.MonoTODOAttribute]
    public static void Import(string fileName) { }
    [System.MonoTODOAttribute]
    public static void Manage() { }
  }
  public partial class IdentityValidationException : System.Exception {
    public IdentityValidationException() { }
    protected IdentityValidationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public IdentityValidationException(string message) { }
    public IdentityValidationException(string message, System.Exception innerException) { }
  }
  public partial class PolicyValidationException : System.Exception {
    public PolicyValidationException() { }
    protected PolicyValidationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public PolicyValidationException(string message) { }
    public PolicyValidationException(string message, System.Exception innerException) { }
  }
  public partial class ServiceBusyException : System.Exception {
    public ServiceBusyException() { }
    protected ServiceBusyException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public ServiceBusyException(string message) { }
    public ServiceBusyException(string message, System.Exception innerException) { }
  }
  public partial class ServiceNotStartedException : System.Exception {
    public ServiceNotStartedException() { }
    protected ServiceNotStartedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public ServiceNotStartedException(string message) { }
    public ServiceNotStartedException(string message, System.Exception innerException) { }
  }
  public partial class StsCommunicationException : System.Exception {
    public StsCommunicationException() { }
    protected StsCommunicationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public StsCommunicationException(string message) { }
    public StsCommunicationException(string message, System.Exception innerException) { }
  }
  public partial class UnsupportedPolicyOptionsException : System.Exception {
    public UnsupportedPolicyOptionsException() { }
    protected UnsupportedPolicyOptionsException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public UnsupportedPolicyOptionsException(string message) { }
    public UnsupportedPolicyOptionsException(string message, System.Exception innerException) { }
  }
  public partial class UntrustedRecipientException : System.Exception {
    public UntrustedRecipientException() { }
    protected UntrustedRecipientException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public UntrustedRecipientException(string message) { }
    public UntrustedRecipientException(string message, System.Exception innerException) { }
  }
  public partial class UserCancellationException : System.Exception {
    public UserCancellationException() { }
    protected UserCancellationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public UserCancellationException(string message) { }
    public UserCancellationException(string message, System.Exception innerException) { }
  }
}
