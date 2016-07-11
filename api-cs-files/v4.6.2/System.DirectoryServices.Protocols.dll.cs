namespace System.DirectoryServices.Protocols {
  public partial class AddRequest : System.DirectoryServices.Protocols.DirectoryRequest {
    public AddRequest() { }
    public AddRequest(string distinguishedName, params System.DirectoryServices.Protocols.DirectoryAttribute[] attributes) { }
    public AddRequest(string distinguishedName, string objectClass) { }
    public System.DirectoryServices.Protocols.DirectoryAttributeCollection Attributes { get { return default(System.DirectoryServices.Protocols.DirectoryAttributeCollection); } }
    public string DistinguishedName { get { return default(string); } set { } }
    protected override System.Xml.XmlElement ToXmlNode(System.Xml.XmlDocument doc) { return default(System.Xml.XmlElement); }
  }
  public partial class AddResponse : System.DirectoryServices.Protocols.DirectoryResponse {
    internal AddResponse() { }
  }
  public partial class AsqRequestControl : System.DirectoryServices.Protocols.DirectoryControl {
    public AsqRequestControl() : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public AsqRequestControl(string attributeName) : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public string AttributeName { get { return default(string); } set { } }
    public override System.Byte[] GetValue() { return default(System.Byte[]); }
  }
  public partial class AsqResponseControl : System.DirectoryServices.Protocols.DirectoryControl {
    internal AsqResponseControl() : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public System.DirectoryServices.Protocols.ResultCode Result { get { return default(System.DirectoryServices.Protocols.ResultCode); } }
  }
  public enum AuthType {
    Anonymous = 0,
    Basic = 1,
    Digest = 4,
    Dpa = 6,
    External = 8,
    Kerberos = 9,
    Msn = 7,
    Negotiate = 2,
    Ntlm = 3,
    Sicily = 5,
  }
  public partial class BerConversionException : System.DirectoryServices.Protocols.DirectoryException {
    public BerConversionException() { }
    protected BerConversionException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public BerConversionException(string message) { }
    public BerConversionException(string message, System.Exception inner) { }
  }
  public sealed partial class BerConverter {
    internal BerConverter() { }
    public static System.Object[] Decode(string format, System.Byte[] value) { return default(System.Object[]); }
    public static System.Byte[] Encode(string format, params System.Object[] value) { return default(System.Byte[]); }
  }
  public partial class CompareRequest : System.DirectoryServices.Protocols.DirectoryRequest {
    public CompareRequest() { }
    public CompareRequest(string distinguishedName, System.DirectoryServices.Protocols.DirectoryAttribute assertion) { }
    public CompareRequest(string distinguishedName, string attributeName, System.Byte[] value) { }
    public CompareRequest(string distinguishedName, string attributeName, string value) { }
    public CompareRequest(string distinguishedName, string attributeName, System.Uri value) { }
    public System.DirectoryServices.Protocols.DirectoryAttribute Assertion { get { return default(System.DirectoryServices.Protocols.DirectoryAttribute); } }
    public string DistinguishedName { get { return default(string); } set { } }
    protected override System.Xml.XmlElement ToXmlNode(System.Xml.XmlDocument doc) { return default(System.Xml.XmlElement); }
  }
  public partial class CompareResponse : System.DirectoryServices.Protocols.DirectoryResponse {
    internal CompareResponse() { }
  }
  public partial class CrossDomainMoveControl : System.DirectoryServices.Protocols.DirectoryControl {
    public CrossDomainMoveControl() : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public CrossDomainMoveControl(string targetDomainController) : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public string TargetDomainController { get { return default(string); } set { } }
    public override System.Byte[] GetValue() { return default(System.Byte[]); }
  }
  public partial class DeleteRequest : System.DirectoryServices.Protocols.DirectoryRequest {
    public DeleteRequest() { }
    public DeleteRequest(string distinguishedName) { }
    public string DistinguishedName { get { return default(string); } set { } }
    protected override System.Xml.XmlElement ToXmlNode(System.Xml.XmlDocument doc) { return default(System.Xml.XmlElement); }
  }
  public partial class DeleteResponse : System.DirectoryServices.Protocols.DirectoryResponse {
    internal DeleteResponse() { }
  }
  public enum DereferenceAlias {
    Always = 3,
    FindingBaseObject = 2,
    InSearching = 1,
    Never = 0,
  }
  public delegate void DereferenceConnectionCallback(System.DirectoryServices.Protocols.LdapConnection primaryConnection, System.DirectoryServices.Protocols.LdapConnection connectionToDereference);
  public partial class DirectoryAttribute : System.Collections.CollectionBase {
    public DirectoryAttribute() { }
    public DirectoryAttribute(string name, System.Byte[] value) { }
    public DirectoryAttribute(string name, params System.Object[] values) { }
    public DirectoryAttribute(string name, string value) { }
    public DirectoryAttribute(string name, System.Uri value) { }
    public object this[int index] { get { return default(object); } set { } }
    public string Name { get { return default(string); } set { } }
    public int Add(System.Byte[] value) { return default(int); }
    public int Add(string value) { return default(int); }
    public int Add(System.Uri value) { return default(int); }
    public void AddRange(System.Object[] values) { }
    public bool Contains(object value) { return default(bool); }
    public void CopyTo(System.Object[] array, int index) { }
    public System.Object[] GetValues(System.Type valuesType) { return default(System.Object[]); }
    public int IndexOf(object value) { return default(int); }
    public void Insert(int index, System.Byte[] value) { }
    public void Insert(int index, string value) { }
    public void Insert(int index, System.Uri value) { }
    protected override void OnValidate(object value) { }
    public void Remove(object value) { }
  }
  public partial class DirectoryAttributeCollection : System.Collections.CollectionBase {
    public DirectoryAttributeCollection() { }
    public System.DirectoryServices.Protocols.DirectoryAttribute this[int index] { get { return default(System.DirectoryServices.Protocols.DirectoryAttribute); } set { } }
    public int Add(System.DirectoryServices.Protocols.DirectoryAttribute attribute) { return default(int); }
    public void AddRange(System.DirectoryServices.Protocols.DirectoryAttribute[] attributes) { }
    public void AddRange(System.DirectoryServices.Protocols.DirectoryAttributeCollection attributeCollection) { }
    public bool Contains(System.DirectoryServices.Protocols.DirectoryAttribute value) { return default(bool); }
    public void CopyTo(System.DirectoryServices.Protocols.DirectoryAttribute[] array, int index) { }
    public int IndexOf(System.DirectoryServices.Protocols.DirectoryAttribute value) { return default(int); }
    public void Insert(int index, System.DirectoryServices.Protocols.DirectoryAttribute value) { }
    protected override void OnValidate(object value) { }
    public void Remove(System.DirectoryServices.Protocols.DirectoryAttribute value) { }
  }
  public partial class DirectoryAttributeModification : System.DirectoryServices.Protocols.DirectoryAttribute {
    public DirectoryAttributeModification() { }
    public System.DirectoryServices.Protocols.DirectoryAttributeOperation Operation { get { return default(System.DirectoryServices.Protocols.DirectoryAttributeOperation); } set { } }
  }
  public partial class DirectoryAttributeModificationCollection : System.Collections.CollectionBase {
    public DirectoryAttributeModificationCollection() { }
    public System.DirectoryServices.Protocols.DirectoryAttributeModification this[int index] { get { return default(System.DirectoryServices.Protocols.DirectoryAttributeModification); } set { } }
    public int Add(System.DirectoryServices.Protocols.DirectoryAttributeModification attribute) { return default(int); }
    public void AddRange(System.DirectoryServices.Protocols.DirectoryAttributeModification[] attributes) { }
    public void AddRange(System.DirectoryServices.Protocols.DirectoryAttributeModificationCollection attributeCollection) { }
    public bool Contains(System.DirectoryServices.Protocols.DirectoryAttributeModification value) { return default(bool); }
    public void CopyTo(System.DirectoryServices.Protocols.DirectoryAttributeModification[] array, int index) { }
    public int IndexOf(System.DirectoryServices.Protocols.DirectoryAttributeModification value) { return default(int); }
    public void Insert(int index, System.DirectoryServices.Protocols.DirectoryAttributeModification value) { }
    protected override void OnValidate(object value) { }
    public void Remove(System.DirectoryServices.Protocols.DirectoryAttributeModification value) { }
  }
  public enum DirectoryAttributeOperation {
    Add = 0,
    Delete = 1,
    Replace = 2,
  }
  public abstract partial class DirectoryConnection {
    protected DirectoryConnection() { }
    public System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates { get { return default(System.Security.Cryptography.X509Certificates.X509CertificateCollection); } }
    public virtual System.Net.NetworkCredential Credential { set { } }
    public virtual System.DirectoryServices.Protocols.DirectoryIdentifier Directory { get { return default(System.DirectoryServices.Protocols.DirectoryIdentifier); } }
    public virtual System.TimeSpan Timeout { get { return default(System.TimeSpan); } set { } }
    [System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
    public abstract System.DirectoryServices.Protocols.DirectoryResponse SendRequest(System.DirectoryServices.Protocols.DirectoryRequest request);
  }
  public partial class DirectoryControl {
    public DirectoryControl(string type, System.Byte[] value, bool isCritical, bool serverSide) { }
    public bool IsCritical { get { return default(bool); } set { } }
    public bool ServerSide { get { return default(bool); } set { } }
    public string Type { get { return default(string); } }
    public virtual System.Byte[] GetValue() { return default(System.Byte[]); }
  }
  public partial class DirectoryControlCollection : System.Collections.CollectionBase {
    public DirectoryControlCollection() { }
    public System.DirectoryServices.Protocols.DirectoryControl this[int index] { get { return default(System.DirectoryServices.Protocols.DirectoryControl); } set { } }
    public int Add(System.DirectoryServices.Protocols.DirectoryControl control) { return default(int); }
    public void AddRange(System.DirectoryServices.Protocols.DirectoryControl[] controls) { }
    public void AddRange(System.DirectoryServices.Protocols.DirectoryControlCollection controlCollection) { }
    public bool Contains(System.DirectoryServices.Protocols.DirectoryControl value) { return default(bool); }
    public void CopyTo(System.DirectoryServices.Protocols.DirectoryControl[] array, int index) { }
    public int IndexOf(System.DirectoryServices.Protocols.DirectoryControl value) { return default(int); }
    public void Insert(int index, System.DirectoryServices.Protocols.DirectoryControl value) { }
    protected override void OnValidate(object value) { }
    public void Remove(System.DirectoryServices.Protocols.DirectoryControl value) { }
  }
  public partial class DirectoryException : System.Exception {
    public DirectoryException() { }
    protected DirectoryException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public DirectoryException(string message) { }
    public DirectoryException(string message, System.Exception inner) { }
  }
  public abstract partial class DirectoryIdentifier {
    protected DirectoryIdentifier() { }
  }
  public partial class DirectoryNotificationControl : System.DirectoryServices.Protocols.DirectoryControl {
    public DirectoryNotificationControl() : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
  }
  public abstract partial class DirectoryOperation {
    protected DirectoryOperation() { }
  }
  public partial class DirectoryOperationException : System.DirectoryServices.Protocols.DirectoryException, System.Runtime.Serialization.ISerializable {
    public DirectoryOperationException() { }
    public DirectoryOperationException(System.DirectoryServices.Protocols.DirectoryResponse response) { }
    public DirectoryOperationException(System.DirectoryServices.Protocols.DirectoryResponse response, string message) { }
    public DirectoryOperationException(System.DirectoryServices.Protocols.DirectoryResponse response, string message, System.Exception inner) { }
    protected DirectoryOperationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public DirectoryOperationException(string message) { }
    public DirectoryOperationException(string message, System.Exception inner) { }
    public System.DirectoryServices.Protocols.DirectoryResponse Response { get { return default(System.DirectoryServices.Protocols.DirectoryResponse); } }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, SerializationFormatter=true)]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
  }
  public abstract partial class DirectoryRequest : System.DirectoryServices.Protocols.DirectoryOperation {
    internal DirectoryRequest() { }
    public System.DirectoryServices.Protocols.DirectoryControlCollection Controls { get { return default(System.DirectoryServices.Protocols.DirectoryControlCollection); } }
    public string RequestId { get { return default(string); } set { } }
    protected abstract System.Xml.XmlElement ToXmlNode(System.Xml.XmlDocument doc);
  }
  public abstract partial class DirectoryResponse : System.DirectoryServices.Protocols.DirectoryOperation {
    internal DirectoryResponse() { }
    public virtual System.DirectoryServices.Protocols.DirectoryControl[] Controls { get { return default(System.DirectoryServices.Protocols.DirectoryControl[]); } }
    public virtual string ErrorMessage { get { return default(string); } }
    public virtual string MatchedDN { get { return default(string); } }
    public virtual System.Uri[] Referral { get { return default(System.Uri[]); } }
    public string RequestId { get { return default(string); } }
    public virtual System.DirectoryServices.Protocols.ResultCode ResultCode { get { return default(System.DirectoryServices.Protocols.ResultCode); } }
  }
  [System.FlagsAttribute]
  public enum DirectorySynchronizationOptions : long {
    IncrementalValues = (long)2147483648,
    None = (long)0,
    ObjectSecurity = (long)1,
    ParentsFirst = (long)2048,
    PublicDataOnly = (long)8192,
  }
  public partial class DirSyncRequestControl : System.DirectoryServices.Protocols.DirectoryControl {
    public DirSyncRequestControl() : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public DirSyncRequestControl(System.Byte[] cookie) : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public DirSyncRequestControl(System.Byte[] cookie, System.DirectoryServices.Protocols.DirectorySynchronizationOptions option) : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public DirSyncRequestControl(System.Byte[] cookie, System.DirectoryServices.Protocols.DirectorySynchronizationOptions option, int attributeCount) : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public int AttributeCount { get { return default(int); } set { } }
    public System.Byte[] Cookie { get { return default(System.Byte[]); } set { } }
    public System.DirectoryServices.Protocols.DirectorySynchronizationOptions Option { get { return default(System.DirectoryServices.Protocols.DirectorySynchronizationOptions); } set { } }
    public override System.Byte[] GetValue() { return default(System.Byte[]); }
  }
  public partial class DirSyncResponseControl : System.DirectoryServices.Protocols.DirectoryControl {
    internal DirSyncResponseControl() : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public System.Byte[] Cookie { get { return default(System.Byte[]); } }
    public bool MoreData { get { return default(bool); } }
    public int ResultSize { get { return default(int); } }
  }
  public partial class DomainScopeControl : System.DirectoryServices.Protocols.DirectoryControl {
    public DomainScopeControl() : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
  }
  public partial class DsmlAuthRequest : System.DirectoryServices.Protocols.DirectoryRequest {
    public DsmlAuthRequest() { }
    public DsmlAuthRequest(string principal) { }
    public string Principal { get { return default(string); } set { } }
    protected override System.Xml.XmlElement ToXmlNode(System.Xml.XmlDocument doc) { return default(System.Xml.XmlElement); }
  }
  public partial class DsmlAuthResponse : System.DirectoryServices.Protocols.DirectoryResponse {
    internal DsmlAuthResponse() { }
  }
  public partial class DsmlDirectoryIdentifier : System.DirectoryServices.Protocols.DirectoryIdentifier {
    public DsmlDirectoryIdentifier(System.Uri serverUri) { }
    public System.Uri ServerUri { get { return default(System.Uri); } }
  }
  public abstract partial class DsmlDocument {
    protected DsmlDocument() { }
    public abstract System.Xml.XmlDocument ToXml();
  }
  public enum DsmlDocumentProcessing {
    Parallel = 1,
    Sequential = 0,
  }
  public enum DsmlErrorProcessing {
    Exit = 1,
    Resume = 0,
  }
  public partial class DsmlErrorResponse : System.DirectoryServices.Protocols.DirectoryResponse {
    internal DsmlErrorResponse() { }
    public override System.DirectoryServices.Protocols.DirectoryControl[] Controls { get { return default(System.DirectoryServices.Protocols.DirectoryControl[]); } }
    public string Detail { get { return default(string); } }
    public override string ErrorMessage { get { return default(string); } }
    public override string MatchedDN { get { return default(string); } }
    public string Message { get { return default(string); } }
    public override System.Uri[] Referral { get { return default(System.Uri[]); } }
    public override System.DirectoryServices.Protocols.ResultCode ResultCode { get { return default(System.DirectoryServices.Protocols.ResultCode); } }
    public System.DirectoryServices.Protocols.ErrorResponseCategory Type { get { return default(System.DirectoryServices.Protocols.ErrorResponseCategory); } }
  }
  public partial class DsmlInvalidDocumentException : System.DirectoryServices.Protocols.DirectoryException {
    public DsmlInvalidDocumentException() { }
    protected DsmlInvalidDocumentException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public DsmlInvalidDocumentException(string message) { }
    public DsmlInvalidDocumentException(string message, System.Exception inner) { }
  }
  public partial class DsmlRequestDocument : System.DirectoryServices.Protocols.DsmlDocument, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList {
    public DsmlRequestDocument() { }
    public int Count { get { return default(int); } }
    public System.DirectoryServices.Protocols.DsmlDocumentProcessing DocumentProcessing { get { return default(System.DirectoryServices.Protocols.DsmlDocumentProcessing); } set { } }
    public System.DirectoryServices.Protocols.DsmlErrorProcessing ErrorProcessing { get { return default(System.DirectoryServices.Protocols.DsmlErrorProcessing); } set { } }
    protected bool IsFixedSize { get { return default(bool); } }
    protected bool IsReadOnly { get { return default(bool); } }
    protected bool IsSynchronized { get { return default(bool); } }
    public System.DirectoryServices.Protocols.DirectoryRequest this[int index] { get { return default(System.DirectoryServices.Protocols.DirectoryRequest); } set { } }
    public string RequestId { get { return default(string); } set { } }
    public System.DirectoryServices.Protocols.DsmlResponseOrder ResponseOrder { get { return default(System.DirectoryServices.Protocols.DsmlResponseOrder); } set { } }
    protected object SyncRoot { get { return default(object); } }
    int System.Collections.ICollection.Count { get { return default(int); } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    bool System.Collections.IList.IsFixedSize { get { return default(bool); } }
    bool System.Collections.IList.IsReadOnly { get { return default(bool); } }
    object System.Collections.IList.this[int index] { get { return default(object); } set { } }
    public int Add(System.DirectoryServices.Protocols.DirectoryRequest request) { return default(int); }
    public void Clear() { }
    public bool Contains(System.DirectoryServices.Protocols.DirectoryRequest value) { return default(bool); }
    public void CopyTo(System.DirectoryServices.Protocols.DirectoryRequest[] value, int i) { }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public int IndexOf(System.DirectoryServices.Protocols.DirectoryRequest value) { return default(int); }
    public void Insert(int index, System.DirectoryServices.Protocols.DirectoryRequest value) { }
    public void Remove(System.DirectoryServices.Protocols.DirectoryRequest value) { }
    public void RemoveAt(int index) { }
    void System.Collections.ICollection.CopyTo(System.Array value, int i) { }
    int System.Collections.IList.Add(object request) { return default(int); }
    void System.Collections.IList.Clear() { }
    bool System.Collections.IList.Contains(object value) { return default(bool); }
    int System.Collections.IList.IndexOf(object value) { return default(int); }
    void System.Collections.IList.Insert(int index, object value) { }
    void System.Collections.IList.Remove(object value) { }
    void System.Collections.IList.RemoveAt(int index) { }
    public override System.Xml.XmlDocument ToXml() { return default(System.Xml.XmlDocument); }
  }
  public partial class DsmlResponseDocument : System.DirectoryServices.Protocols.DsmlDocument, System.Collections.ICollection, System.Collections.IEnumerable {
    internal DsmlResponseDocument() { }
    public int Count { get { return default(int); } }
    public bool IsErrorResponse { get { return default(bool); } }
    public bool IsOperationError { get { return default(bool); } }
    protected bool IsSynchronized { get { return default(bool); } }
    public System.DirectoryServices.Protocols.DirectoryResponse this[int index] { get { return default(System.DirectoryServices.Protocols.DirectoryResponse); } }
    public string RequestId { get { return default(string); } }
    protected object SyncRoot { get { return default(object); } }
    int System.Collections.ICollection.Count { get { return default(int); } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    public void CopyTo(System.DirectoryServices.Protocols.DirectoryResponse[] value, int i) { }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    void System.Collections.ICollection.CopyTo(System.Array value, int i) { }
    public override System.Xml.XmlDocument ToXml() { return default(System.Xml.XmlDocument); }
  }
  public enum DsmlResponseOrder {
    Sequential = 0,
    Unordered = 1,
  }
  public abstract partial class DsmlSoapConnection : System.DirectoryServices.Protocols.DirectoryConnection {
    protected DsmlSoapConnection() { }
    public abstract string SessionId { get; }
    public System.Xml.XmlNode SoapRequestHeader { get { return default(System.Xml.XmlNode); } set { } }
    [System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
    public abstract void BeginSession();
    [System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
    public abstract void EndSession();
  }
  public partial class DsmlSoapHttpConnection : System.DirectoryServices.Protocols.DsmlSoapConnection {
    [System.Net.WebPermissionAttribute(System.Security.Permissions.SecurityAction.Assert, Unrestricted=true)]
    [System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Unrestricted=true)]
    public DsmlSoapHttpConnection(System.DirectoryServices.Protocols.DsmlDirectoryIdentifier identifier) { }
    [System.Security.Permissions.EnvironmentPermissionAttribute(System.Security.Permissions.SecurityAction.Assert, Unrestricted=true)]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Assert, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
    [System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Unrestricted=true)]
    public DsmlSoapHttpConnection(System.DirectoryServices.Protocols.DsmlDirectoryIdentifier identifier, System.Net.NetworkCredential credential) { }
    [System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Unrestricted=true)]
    public DsmlSoapHttpConnection(System.DirectoryServices.Protocols.DsmlDirectoryIdentifier identifier, System.Net.NetworkCredential credential, System.DirectoryServices.Protocols.AuthType authType) { }
    [System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Unrestricted=true)]
    public DsmlSoapHttpConnection(System.Uri uri) { }
    public System.DirectoryServices.Protocols.AuthType AuthType { get { return default(System.DirectoryServices.Protocols.AuthType); } set { } }
    public override string SessionId { get { return default(string); } }
    public string SoapActionHeader { get { return default(string); } set { } }
    public override System.TimeSpan Timeout { get { return default(System.TimeSpan); } set { } }
    [System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
    public void Abort(System.IAsyncResult asyncResult) { }
    [System.Net.WebPermissionAttribute(System.Security.Permissions.SecurityAction.Assert, Unrestricted=true)]
    [System.Net.NetworkInformation.NetworkInformationPermissionAttribute(System.Security.Permissions.SecurityAction.Assert, Unrestricted=true)]
    [System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
    public System.IAsyncResult BeginSendRequest(System.DirectoryServices.Protocols.DsmlRequestDocument request, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    [System.Net.WebPermissionAttribute(System.Security.Permissions.SecurityAction.Assert, Unrestricted=true)]
    [System.Net.NetworkInformation.NetworkInformationPermissionAttribute(System.Security.Permissions.SecurityAction.Assert, Unrestricted=true)]
    [System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
    public override void BeginSession() { }
    public System.DirectoryServices.Protocols.DsmlResponseDocument EndSendRequest(System.IAsyncResult asyncResult) { return default(System.DirectoryServices.Protocols.DsmlResponseDocument); }
    [System.Net.WebPermissionAttribute(System.Security.Permissions.SecurityAction.Assert, Unrestricted=true)]
    [System.Net.NetworkInformation.NetworkInformationPermissionAttribute(System.Security.Permissions.SecurityAction.Assert, Unrestricted=true)]
    [System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
    public override void EndSession() { }
    [System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
    public override System.DirectoryServices.Protocols.DirectoryResponse SendRequest(System.DirectoryServices.Protocols.DirectoryRequest request) { return default(System.DirectoryServices.Protocols.DirectoryResponse); }
    [System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
    public System.DirectoryServices.Protocols.DsmlResponseDocument SendRequest(System.DirectoryServices.Protocols.DsmlRequestDocument request) { return default(System.DirectoryServices.Protocols.DsmlResponseDocument); }
  }
  public enum ErrorResponseCategory {
    AuthenticationFailed = 5,
    ConnectionClosed = 2,
    CouldNotConnect = 1,
    GatewayInternalError = 4,
    MalformedRequest = 3,
    NotAttempted = 0,
    Other = 7,
    UnresolvableUri = 6,
  }
  public partial class ErrorResponseException : System.DirectoryServices.Protocols.DirectoryException, System.Runtime.Serialization.ISerializable {
    public ErrorResponseException() { }
    public ErrorResponseException(System.DirectoryServices.Protocols.DsmlErrorResponse response) { }
    public ErrorResponseException(System.DirectoryServices.Protocols.DsmlErrorResponse response, string message) { }
    public ErrorResponseException(System.DirectoryServices.Protocols.DsmlErrorResponse response, string message, System.Exception inner) { }
    protected ErrorResponseException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public ErrorResponseException(string message) { }
    public ErrorResponseException(string message, System.Exception inner) { }
    public System.DirectoryServices.Protocols.DsmlErrorResponse Response { get { return default(System.DirectoryServices.Protocols.DsmlErrorResponse); } }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, SerializationFormatter=true)]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
  }
  public partial class ExtendedDNControl : System.DirectoryServices.Protocols.DirectoryControl {
    public ExtendedDNControl() : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public ExtendedDNControl(System.DirectoryServices.Protocols.ExtendedDNFlag flag) : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public System.DirectoryServices.Protocols.ExtendedDNFlag Flag { get { return default(System.DirectoryServices.Protocols.ExtendedDNFlag); } set { } }
    public override System.Byte[] GetValue() { return default(System.Byte[]); }
  }
  public enum ExtendedDNFlag {
    HexString = 0,
    StandardString = 1,
  }
  public partial class ExtendedRequest : System.DirectoryServices.Protocols.DirectoryRequest {
    public ExtendedRequest() { }
    public ExtendedRequest(string requestName) { }
    public ExtendedRequest(string requestName, System.Byte[] requestValue) { }
    public string RequestName { get { return default(string); } set { } }
    public System.Byte[] RequestValue { get { return default(System.Byte[]); } set { } }
    protected override System.Xml.XmlElement ToXmlNode(System.Xml.XmlDocument doc) { return default(System.Xml.XmlElement); }
  }
  public partial class ExtendedResponse : System.DirectoryServices.Protocols.DirectoryResponse {
    internal ExtendedResponse() { }
    public string ResponseName { get { return default(string); } }
    public System.Byte[] ResponseValue { get { return default(System.Byte[]); } }
  }
  public partial class LazyCommitControl : System.DirectoryServices.Protocols.DirectoryControl {
    public LazyCommitControl() : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
  }
  public partial class LdapConnection : System.DirectoryServices.Protocols.DirectoryConnection, System.IDisposable {
    [System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Unrestricted=true)]
    public LdapConnection(System.DirectoryServices.Protocols.LdapDirectoryIdentifier identifier) { }
    [System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Unrestricted=true)]
    public LdapConnection(System.DirectoryServices.Protocols.LdapDirectoryIdentifier identifier, System.Net.NetworkCredential credential) { }
    [System.Security.Permissions.EnvironmentPermissionAttribute(System.Security.Permissions.SecurityAction.Assert, Unrestricted=true)]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Assert, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
    [System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Unrestricted=true)]
    public LdapConnection(System.DirectoryServices.Protocols.LdapDirectoryIdentifier identifier, System.Net.NetworkCredential credential, System.DirectoryServices.Protocols.AuthType authType) { }
    [System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Unrestricted=true)]
    public LdapConnection(string server) { }
    public System.DirectoryServices.Protocols.AuthType AuthType { get { return default(System.DirectoryServices.Protocols.AuthType); } set { } }
    public bool AutoBind { get { return default(bool); } set { } }
    public override System.Net.NetworkCredential Credential { set { } }
    public System.DirectoryServices.Protocols.LdapSessionOptions SessionOptions { get { return default(System.DirectoryServices.Protocols.LdapSessionOptions); } }
    public override System.TimeSpan Timeout { get { return default(System.TimeSpan); } set { } }
    [System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
    public void Abort(System.IAsyncResult asyncResult) { }
    [System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
    public System.IAsyncResult BeginSendRequest(System.DirectoryServices.Protocols.DirectoryRequest request, System.DirectoryServices.Protocols.PartialResultProcessing partialMode, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    [System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
    public System.IAsyncResult BeginSendRequest(System.DirectoryServices.Protocols.DirectoryRequest request, System.TimeSpan requestTimeout, System.DirectoryServices.Protocols.PartialResultProcessing partialMode, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    [System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
    public void Bind() { }
    [System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
    public void Bind(System.Net.NetworkCredential newCredential) { }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public System.DirectoryServices.Protocols.DirectoryResponse EndSendRequest(System.IAsyncResult asyncResult) { return default(System.DirectoryServices.Protocols.DirectoryResponse); }
    ~LdapConnection() { }
    public System.DirectoryServices.Protocols.PartialResultsCollection GetPartialResults(System.IAsyncResult asyncResult) { return default(System.DirectoryServices.Protocols.PartialResultsCollection); }
    [System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
    public override System.DirectoryServices.Protocols.DirectoryResponse SendRequest(System.DirectoryServices.Protocols.DirectoryRequest request) { return default(System.DirectoryServices.Protocols.DirectoryResponse); }
    [System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
    public System.DirectoryServices.Protocols.DirectoryResponse SendRequest(System.DirectoryServices.Protocols.DirectoryRequest request, System.TimeSpan requestTimeout) { return default(System.DirectoryServices.Protocols.DirectoryResponse); }
  }
  public partial class LdapDirectoryIdentifier : System.DirectoryServices.Protocols.DirectoryIdentifier {
    public LdapDirectoryIdentifier(string server) { }
    public LdapDirectoryIdentifier(string server, bool fullyQualifiedDnsHostName, bool connectionless) { }
    public LdapDirectoryIdentifier(string server, int portNumber) { }
    public LdapDirectoryIdentifier(string server, int portNumber, bool fullyQualifiedDnsHostName, bool connectionless) { }
    public LdapDirectoryIdentifier(System.String[] servers, bool fullyQualifiedDnsHostName, bool connectionless) { }
    public LdapDirectoryIdentifier(System.String[] servers, int portNumber, bool fullyQualifiedDnsHostName, bool connectionless) { }
    public bool Connectionless { get { return default(bool); } }
    public bool FullyQualifiedDnsHostName { get { return default(bool); } }
    public int PortNumber { get { return default(int); } }
    public System.String[] Servers { get { return default(System.String[]); } }
  }
  public partial class LdapException : System.DirectoryServices.Protocols.DirectoryException, System.Runtime.Serialization.ISerializable {
    public LdapException() { }
    public LdapException(int errorCode) { }
    public LdapException(int errorCode, string message) { }
    public LdapException(int errorCode, string message, System.Exception inner) { }
    public LdapException(int errorCode, string message, string serverErrorMessage) { }
    protected LdapException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public LdapException(string message) { }
    public LdapException(string message, System.Exception inner) { }
    public int ErrorCode { get { return default(int); } }
    public System.DirectoryServices.Protocols.PartialResultsCollection PartialResults { get { return default(System.DirectoryServices.Protocols.PartialResultsCollection); } }
    public string ServerErrorMessage { get { return default(string); } }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, SerializationFormatter=true)]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
  }
  public partial class LdapSessionOptions {
    internal LdapSessionOptions() { }
    public bool AutoReconnect { get { return default(bool); } set { } }
    public string DomainName { get { return default(string); } set { } }
    public string HostName { get { return default(string); } set { } }
    public bool HostReachable { get { return default(bool); } }
    public System.DirectoryServices.Protocols.LocatorFlags LocatorFlag { get { return default(System.DirectoryServices.Protocols.LocatorFlags); } set { } }
    public System.TimeSpan PingKeepAliveTimeout { get { return default(System.TimeSpan); } set { } }
    public int PingLimit { get { return default(int); } set { } }
    public System.TimeSpan PingWaitTimeout { get { return default(System.TimeSpan); } set { } }
    public int ProtocolVersion { get { return default(int); } set { } }
    public System.DirectoryServices.Protocols.QueryClientCertificateCallback QueryClientCertificate { get { return default(System.DirectoryServices.Protocols.QueryClientCertificateCallback); } set { } }
    public System.DirectoryServices.Protocols.ReferralCallback ReferralCallback { get { return default(System.DirectoryServices.Protocols.ReferralCallback); } set { } }
    public System.DirectoryServices.Protocols.ReferralChasingOptions ReferralChasing { get { return default(System.DirectoryServices.Protocols.ReferralChasingOptions); } set { } }
    public int ReferralHopLimit { get { return default(int); } set { } }
    public bool RootDseCache { get { return default(bool); } set { } }
    public string SaslMethod { get { return default(string); } set { } }
    public bool Sealing { get { return default(bool); } set { } }
    public bool SecureSocketLayer { get { return default(bool); } set { } }
    public object SecurityContext { get { return default(object); } }
    public System.TimeSpan SendTimeout { get { return default(System.TimeSpan); } set { } }
    public bool Signing { get { return default(bool); } set { } }
    public System.DirectoryServices.Protocols.SecurityPackageContextConnectionInformation SslInformation { get { return default(System.DirectoryServices.Protocols.SecurityPackageContextConnectionInformation); } }
    public int SspiFlag { get { return default(int); } set { } }
    public bool TcpKeepAlive { get { return default(bool); } set { } }
    public System.DirectoryServices.Protocols.VerifyServerCertificateCallback VerifyServerCertificate { get { return default(System.DirectoryServices.Protocols.VerifyServerCertificateCallback); } set { } }
    public void FastConcurrentBind() { }
    public void StartTransportLayerSecurity(System.DirectoryServices.Protocols.DirectoryControlCollection controls) { }
    public void StopTransportLayerSecurity() { }
  }
  [System.FlagsAttribute]
  public enum LocatorFlags : long {
    AvoidSelf = (long)16384,
    DirectoryServicesPreferred = (long)32,
    DirectoryServicesRequired = (long)16,
    ForceRediscovery = (long)1,
    GCRequired = (long)64,
    GoodTimeServerPreferred = (long)8192,
    IPRequired = (long)512,
    IsDnsName = (long)131072,
    IsFlatName = (long)65536,
    KdcRequired = (long)1024,
    None = (long)0,
    OnlyLdapNeeded = (long)32768,
    PdcRequired = (long)128,
    ReturnDnsName = (long)1073741824,
    ReturnFlatName = (long)2147483648,
    TimeServerRequired = (long)2048,
    WriteableRequired = (long)4096,
  }
  public partial class ModifyDNRequest : System.DirectoryServices.Protocols.DirectoryRequest {
    public ModifyDNRequest() { }
    public ModifyDNRequest(string distinguishedName, string newParentDistinguishedName, string newName) { }
    public bool DeleteOldRdn { get { return default(bool); } set { } }
    public string DistinguishedName { get { return default(string); } set { } }
    public string NewName { get { return default(string); } set { } }
    public string NewParentDistinguishedName { get { return default(string); } set { } }
    protected override System.Xml.XmlElement ToXmlNode(System.Xml.XmlDocument doc) { return default(System.Xml.XmlElement); }
  }
  public partial class ModifyDNResponse : System.DirectoryServices.Protocols.DirectoryResponse {
    internal ModifyDNResponse() { }
  }
  public partial class ModifyRequest : System.DirectoryServices.Protocols.DirectoryRequest {
    public ModifyRequest() { }
    public ModifyRequest(string distinguishedName, params System.DirectoryServices.Protocols.DirectoryAttributeModification[] modifications) { }
    public ModifyRequest(string distinguishedName, System.DirectoryServices.Protocols.DirectoryAttributeOperation operation, string attributeName, params System.Object[] values) { }
    public string DistinguishedName { get { return default(string); } set { } }
    public System.DirectoryServices.Protocols.DirectoryAttributeModificationCollection Modifications { get { return default(System.DirectoryServices.Protocols.DirectoryAttributeModificationCollection); } }
    protected override System.Xml.XmlElement ToXmlNode(System.Xml.XmlDocument doc) { return default(System.Xml.XmlElement); }
  }
  public partial class ModifyResponse : System.DirectoryServices.Protocols.DirectoryResponse {
    internal ModifyResponse() { }
  }
  public delegate bool NotifyOfNewConnectionCallback(System.DirectoryServices.Protocols.LdapConnection primaryConnection, System.DirectoryServices.Protocols.LdapConnection referralFromConnection, string newDistinguishedName, System.DirectoryServices.Protocols.LdapDirectoryIdentifier identifier, System.DirectoryServices.Protocols.LdapConnection newConnection, System.Net.NetworkCredential credential, long currentUserToken, int errorCodeFromBind);
  public partial class PageResultRequestControl : System.DirectoryServices.Protocols.DirectoryControl {
    public PageResultRequestControl() : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public PageResultRequestControl(System.Byte[] cookie) : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public PageResultRequestControl(int pageSize) : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public System.Byte[] Cookie { get { return default(System.Byte[]); } set { } }
    public int PageSize { get { return default(int); } set { } }
    public override System.Byte[] GetValue() { return default(System.Byte[]); }
  }
  public partial class PageResultResponseControl : System.DirectoryServices.Protocols.DirectoryControl {
    internal PageResultResponseControl() : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public System.Byte[] Cookie { get { return default(System.Byte[]); } }
    public int TotalCount { get { return default(int); } }
  }
  public enum PartialResultProcessing {
    NoPartialResultSupport = 0,
    ReturnPartialResults = 1,
    ReturnPartialResultsAndNotifyCallback = 2,
  }
  public partial class PartialResultsCollection : System.Collections.ReadOnlyCollectionBase {
    internal PartialResultsCollection() { }
    public object this[int index] { get { return default(object); } }
    public bool Contains(object value) { return default(bool); }
    public void CopyTo(System.Object[] values, int index) { }
    public int IndexOf(object value) { return default(int); }
  }
  public partial class PermissiveModifyControl : System.DirectoryServices.Protocols.DirectoryControl {
    public PermissiveModifyControl() : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
  }
  public delegate System.Security.Cryptography.X509Certificates.X509Certificate QueryClientCertificateCallback(System.DirectoryServices.Protocols.LdapConnection connection, System.Byte[][] trustedCAs);
  public delegate System.DirectoryServices.Protocols.LdapConnection QueryForConnectionCallback(System.DirectoryServices.Protocols.LdapConnection primaryConnection, System.DirectoryServices.Protocols.LdapConnection referralFromConnection, string newDistinguishedName, System.DirectoryServices.Protocols.LdapDirectoryIdentifier identifier, System.Net.NetworkCredential credential, long currentUserToken);
  public partial class QuotaControl : System.DirectoryServices.Protocols.DirectoryControl {
    public QuotaControl() : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public QuotaControl(System.Security.Principal.SecurityIdentifier querySid) : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public System.Security.Principal.SecurityIdentifier QuerySid { get { return default(System.Security.Principal.SecurityIdentifier); } set { } }
    public override System.Byte[] GetValue() { return default(System.Byte[]); }
  }
  public sealed partial class ReferralCallback {
    public ReferralCallback() { }
    public System.DirectoryServices.Protocols.DereferenceConnectionCallback DereferenceConnection { get { return default(System.DirectoryServices.Protocols.DereferenceConnectionCallback); } set { } }
    public System.DirectoryServices.Protocols.NotifyOfNewConnectionCallback NotifyNewConnection { get { return default(System.DirectoryServices.Protocols.NotifyOfNewConnectionCallback); } set { } }
    public System.DirectoryServices.Protocols.QueryForConnectionCallback QueryForConnection { get { return default(System.DirectoryServices.Protocols.QueryForConnectionCallback); } set { } }
  }
  [System.FlagsAttribute]
  public enum ReferralChasingOptions {
    All = 96,
    External = 64,
    None = 0,
    Subordinate = 32,
  }
  public enum ResultCode {
    AdminLimitExceeded = 11,
    AffectsMultipleDsas = 71,
    AliasDereferencingProblem = 36,
    AliasProblem = 33,
    AttributeOrValueExists = 20,
    AuthMethodNotSupported = 7,
    Busy = 51,
    CompareFalse = 5,
    CompareTrue = 6,
    ConfidentialityRequired = 13,
    ConstraintViolation = 19,
    EntryAlreadyExists = 68,
    InappropriateAuthentication = 48,
    InappropriateMatching = 18,
    InsufficientAccessRights = 50,
    InvalidAttributeSyntax = 21,
    InvalidDNSyntax = 34,
    LoopDetect = 54,
    NamingViolation = 64,
    NoSuchAttribute = 16,
    NoSuchObject = 32,
    NotAllowedOnNonLeaf = 66,
    NotAllowedOnRdn = 67,
    ObjectClassModificationsProhibited = 69,
    ObjectClassViolation = 65,
    OffsetRangeError = 61,
    OperationsError = 1,
    Other = 80,
    ProtocolError = 2,
    Referral = 10,
    ReferralV2 = 9,
    ResultsTooLarge = 70,
    SaslBindInProgress = 14,
    SizeLimitExceeded = 4,
    SortControlMissing = 60,
    StrongAuthRequired = 8,
    Success = 0,
    TimeLimitExceeded = 3,
    Unavailable = 52,
    UnavailableCriticalExtension = 12,
    UndefinedAttributeType = 17,
    UnwillingToPerform = 53,
    VirtualListViewError = 76,
  }
  public enum SearchOption {
    DomainScope = 1,
    PhantomRoot = 2,
  }
  public partial class SearchOptionsControl : System.DirectoryServices.Protocols.DirectoryControl {
    public SearchOptionsControl() : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public SearchOptionsControl(System.DirectoryServices.Protocols.SearchOption flags) : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public System.DirectoryServices.Protocols.SearchOption SearchOption { get { return default(System.DirectoryServices.Protocols.SearchOption); } set { } }
    public override System.Byte[] GetValue() { return default(System.Byte[]); }
  }
  public partial class SearchRequest : System.DirectoryServices.Protocols.DirectoryRequest {
    public SearchRequest() { }
    public SearchRequest(string distinguishedName, string ldapFilter, System.DirectoryServices.Protocols.SearchScope searchScope, params System.String[] attributeList) { }
    public SearchRequest(string distinguishedName, System.Xml.XmlDocument filter, System.DirectoryServices.Protocols.SearchScope searchScope, params System.String[] attributeList) { }
    public System.DirectoryServices.Protocols.DereferenceAlias Aliases { get { return default(System.DirectoryServices.Protocols.DereferenceAlias); } set { } }
    public System.Collections.Specialized.StringCollection Attributes { get { return default(System.Collections.Specialized.StringCollection); } }
    public string DistinguishedName { get { return default(string); } set { } }
    public object Filter { get { return default(object); } set { } }
    public System.DirectoryServices.Protocols.SearchScope Scope { get { return default(System.DirectoryServices.Protocols.SearchScope); } set { } }
    public int SizeLimit { get { return default(int); } set { } }
    public System.TimeSpan TimeLimit { get { return default(System.TimeSpan); } set { } }
    public bool TypesOnly { get { return default(bool); } set { } }
    protected override System.Xml.XmlElement ToXmlNode(System.Xml.XmlDocument doc) { return default(System.Xml.XmlElement); }
  }
  public partial class SearchResponse : System.DirectoryServices.Protocols.DirectoryResponse {
    internal SearchResponse() { }
    public override System.DirectoryServices.Protocols.DirectoryControl[] Controls { get { return default(System.DirectoryServices.Protocols.DirectoryControl[]); } }
    public System.DirectoryServices.Protocols.SearchResultEntryCollection Entries { get { return default(System.DirectoryServices.Protocols.SearchResultEntryCollection); } }
    public override string ErrorMessage { get { return default(string); } }
    public override string MatchedDN { get { return default(string); } }
    public System.DirectoryServices.Protocols.SearchResultReferenceCollection References { get { return default(System.DirectoryServices.Protocols.SearchResultReferenceCollection); } }
    public override System.Uri[] Referral { get { return default(System.Uri[]); } }
    public override System.DirectoryServices.Protocols.ResultCode ResultCode { get { return default(System.DirectoryServices.Protocols.ResultCode); } }
  }
  public partial class SearchResultAttributeCollection : System.Collections.DictionaryBase {
    internal SearchResultAttributeCollection() { }
    public System.Collections.ICollection AttributeNames { get { return default(System.Collections.ICollection); } }
    public System.DirectoryServices.Protocols.DirectoryAttribute this[string attributeName] { get { return default(System.DirectoryServices.Protocols.DirectoryAttribute); } }
    public System.Collections.ICollection Values { get { return default(System.Collections.ICollection); } }
    public bool Contains(string attributeName) { return default(bool); }
    public void CopyTo(System.DirectoryServices.Protocols.DirectoryAttribute[] array, int index) { }
  }
  public partial class SearchResultEntry {
    internal SearchResultEntry() { }
    public System.DirectoryServices.Protocols.SearchResultAttributeCollection Attributes { get { return default(System.DirectoryServices.Protocols.SearchResultAttributeCollection); } }
    public System.DirectoryServices.Protocols.DirectoryControl[] Controls { get { return default(System.DirectoryServices.Protocols.DirectoryControl[]); } }
    public string DistinguishedName { get { return default(string); } }
  }
  public partial class SearchResultEntryCollection : System.Collections.ReadOnlyCollectionBase {
    internal SearchResultEntryCollection() { }
    public System.DirectoryServices.Protocols.SearchResultEntry this[int index] { get { return default(System.DirectoryServices.Protocols.SearchResultEntry); } }
    public bool Contains(System.DirectoryServices.Protocols.SearchResultEntry value) { return default(bool); }
    public void CopyTo(System.DirectoryServices.Protocols.SearchResultEntry[] values, int index) { }
    public int IndexOf(System.DirectoryServices.Protocols.SearchResultEntry value) { return default(int); }
  }
  public partial class SearchResultReference {
    internal SearchResultReference() { }
    public System.DirectoryServices.Protocols.DirectoryControl[] Controls { get { return default(System.DirectoryServices.Protocols.DirectoryControl[]); } }
    public System.Uri[] Reference { get { return default(System.Uri[]); } }
  }
  public partial class SearchResultReferenceCollection : System.Collections.ReadOnlyCollectionBase {
    internal SearchResultReferenceCollection() { }
    public System.DirectoryServices.Protocols.SearchResultReference this[int index] { get { return default(System.DirectoryServices.Protocols.SearchResultReference); } }
    public bool Contains(System.DirectoryServices.Protocols.SearchResultReference value) { return default(bool); }
    public void CopyTo(System.DirectoryServices.Protocols.SearchResultReference[] values, int index) { }
    public int IndexOf(System.DirectoryServices.Protocols.SearchResultReference value) { return default(int); }
  }
  public enum SearchScope {
    Base = 0,
    OneLevel = 1,
    Subtree = 2,
  }
  public partial class SecurityDescriptorFlagControl : System.DirectoryServices.Protocols.DirectoryControl {
    public SecurityDescriptorFlagControl() : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public SecurityDescriptorFlagControl(System.DirectoryServices.Protocols.SecurityMasks masks) : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public System.DirectoryServices.Protocols.SecurityMasks SecurityMasks { get { return default(System.DirectoryServices.Protocols.SecurityMasks); } set { } }
    public override System.Byte[] GetValue() { return default(System.Byte[]); }
  }
  [System.FlagsAttribute]
  public enum SecurityMasks {
    Dacl = 4,
    Group = 2,
    None = 0,
    Owner = 1,
    Sacl = 8,
  }
  public partial class SecurityPackageContextConnectionInformation {
    internal SecurityPackageContextConnectionInformation() { }
    public System.Security.Authentication.CipherAlgorithmType AlgorithmIdentifier { get { return default(System.Security.Authentication.CipherAlgorithmType); } }
    public int CipherStrength { get { return default(int); } }
    public int ExchangeStrength { get { return default(int); } }
    public System.Security.Authentication.HashAlgorithmType Hash { get { return default(System.Security.Authentication.HashAlgorithmType); } }
    public int HashStrength { get { return default(int); } }
    public int KeyExchangeAlgorithm { get { return default(int); } }
    public System.DirectoryServices.Protocols.SecurityProtocol Protocol { get { return default(System.DirectoryServices.Protocols.SecurityProtocol); } }
  }
  public enum SecurityProtocol {
    Pct1Client = 2,
    Pct1Server = 1,
    Ssl2Client = 8,
    Ssl2Server = 4,
    Ssl3Client = 32,
    Ssl3Server = 16,
    Tls1Client = 128,
    Tls1Server = 64,
  }
  public partial class ShowDeletedControl : System.DirectoryServices.Protocols.DirectoryControl {
    public ShowDeletedControl() : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
  }
  public partial class SortKey {
    public SortKey() { }
    public SortKey(string attributeName, string matchingRule, bool reverseOrder) { }
    public string AttributeName { get { return default(string); } set { } }
    public string MatchingRule { get { return default(string); } set { } }
    public bool ReverseOrder { get { return default(bool); } set { } }
  }
  public partial class SortRequestControl : System.DirectoryServices.Protocols.DirectoryControl {
    public SortRequestControl(params System.DirectoryServices.Protocols.SortKey[] sortKeys) : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public SortRequestControl(string attributeName, bool reverseOrder) : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public SortRequestControl(string attributeName, string matchingRule, bool reverseOrder) : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public System.DirectoryServices.Protocols.SortKey[] SortKeys { get { return default(System.DirectoryServices.Protocols.SortKey[]); } set { } }
    public override System.Byte[] GetValue() { return default(System.Byte[]); }
  }
  public partial class SortResponseControl : System.DirectoryServices.Protocols.DirectoryControl {
    internal SortResponseControl() : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public string AttributeName { get { return default(string); } }
    public System.DirectoryServices.Protocols.ResultCode Result { get { return default(System.DirectoryServices.Protocols.ResultCode); } }
  }
  public partial class TlsOperationException : System.DirectoryServices.Protocols.DirectoryOperationException {
    public TlsOperationException() { }
    public TlsOperationException(System.DirectoryServices.Protocols.DirectoryResponse response) { }
    public TlsOperationException(System.DirectoryServices.Protocols.DirectoryResponse response, string message) { }
    public TlsOperationException(System.DirectoryServices.Protocols.DirectoryResponse response, string message, System.Exception inner) { }
    protected TlsOperationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public TlsOperationException(string message) { }
    public TlsOperationException(string message, System.Exception inner) { }
  }
  public partial class TreeDeleteControl : System.DirectoryServices.Protocols.DirectoryControl {
    public TreeDeleteControl() : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
  }
  public partial class VerifyNameControl : System.DirectoryServices.Protocols.DirectoryControl {
    public VerifyNameControl() : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public VerifyNameControl(string serverName) : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public VerifyNameControl(string serverName, int flag) : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public int Flag { get { return default(int); } set { } }
    public string ServerName { get { return default(string); } set { } }
    public override System.Byte[] GetValue() { return default(System.Byte[]); }
  }
  public delegate bool VerifyServerCertificateCallback(System.DirectoryServices.Protocols.LdapConnection connection, System.Security.Cryptography.X509Certificates.X509Certificate certificate);
  public partial class VlvRequestControl : System.DirectoryServices.Protocols.DirectoryControl {
    public VlvRequestControl() : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public VlvRequestControl(int beforeCount, int afterCount, System.Byte[] target) : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public VlvRequestControl(int beforeCount, int afterCount, int offset) : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public VlvRequestControl(int beforeCount, int afterCount, string target) : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public int AfterCount { get { return default(int); } set { } }
    public int BeforeCount { get { return default(int); } set { } }
    public System.Byte[] ContextId { get { return default(System.Byte[]); } set { } }
    public int EstimateCount { get { return default(int); } set { } }
    public int Offset { get { return default(int); } set { } }
    public System.Byte[] Target { get { return default(System.Byte[]); } set { } }
    public override System.Byte[] GetValue() { return default(System.Byte[]); }
  }
  public partial class VlvResponseControl : System.DirectoryServices.Protocols.DirectoryControl {
    internal VlvResponseControl() : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public int ContentCount { get { return default(int); } }
    public System.Byte[] ContextId { get { return default(System.Byte[]); } }
    public System.DirectoryServices.Protocols.ResultCode Result { get { return default(System.DirectoryServices.Protocols.ResultCode); } }
    public int TargetPosition { get { return default(int); } }
  }
}
