namespace System.DirectoryServices.Protocols {
  [System.MonoTODOAttribute]
  public partial class AddRequest : System.DirectoryServices.Protocols.DirectoryRequest {
    public AddRequest() { }
    public AddRequest(string distinguishedName, params System.DirectoryServices.Protocols.DirectoryAttribute[] attributes) { }
    public AddRequest(string distinguishedName, string objectClass) { }
    public System.DirectoryServices.Protocols.DirectoryAttributeCollection Attributes { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.DirectoryServices.Protocols.DirectoryAttributeCollection); } }
    public string DistinguishedName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override System.Xml.XmlElement ToXmlNode(System.Xml.XmlDocument doc) { return default(System.Xml.XmlElement); }
  }
  public partial class AddResponse : System.DirectoryServices.Protocols.DirectoryResponse {
    public AddResponse() { }
  }
  public partial class AsqRequestControl : System.DirectoryServices.Protocols.DirectoryControl {
    public AsqRequestControl() : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public AsqRequestControl(string attributeName) : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public string AttributeName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public override System.Byte[] GetValue() { return default(System.Byte[]); }
  }
  [System.MonoTODOAttribute]
  public partial class AsqResponseControl : System.DirectoryServices.Protocols.DirectoryControl {
    internal AsqResponseControl() : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public System.DirectoryServices.Protocols.ResultCode Result { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.DirectoryServices.Protocols.ResultCode); } }
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
  [System.MonoTODOAttribute]
  public sealed partial class BerConverter {
    public BerConverter() { }
    [System.MonoTODOAttribute]
    public static System.Object[] Decode(string format, System.Byte[] value) { return default(System.Object[]); }
    [System.MonoTODOAttribute]
    public static System.Byte[] Encode(string format, params System.Object[] value) { return default(System.Byte[]); }
  }
  public partial class CompareRequest : System.DirectoryServices.Protocols.DirectoryRequest {
    public CompareRequest() { }
    public CompareRequest(string distinguishedName, System.DirectoryServices.Protocols.DirectoryAttribute assertion) { }
    public CompareRequest(string distinguishedName, string attributeName, System.Byte[] value) { }
    public CompareRequest(string distinguishedName, string attributeName, string value) { }
    public CompareRequest(string distinguishedName, string attributeName, System.Uri value) { }
    public System.DirectoryServices.Protocols.DirectoryAttribute Assertion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.DirectoryServices.Protocols.DirectoryAttribute); } }
    public string DistinguishedName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    protected override System.Xml.XmlElement ToXmlNode(System.Xml.XmlDocument doc) { return default(System.Xml.XmlElement); }
  }
  public partial class CompareResponse : System.DirectoryServices.Protocols.DirectoryResponse {
    internal CompareResponse() { }
  }
  public partial class CrossDomainMoveControl : System.DirectoryServices.Protocols.DirectoryControl {
    public CrossDomainMoveControl() : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public CrossDomainMoveControl(string targetDomainController) : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public string TargetDomainController { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public override System.Byte[] GetValue() { return default(System.Byte[]); }
  }
  public partial class DeleteRequest : System.DirectoryServices.Protocols.DirectoryRequest {
    public DeleteRequest() { }
    public DeleteRequest(string distinguishedName) { }
    public string DistinguishedName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
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
  [System.MonoTODOAttribute]
  public partial class DirectoryAttribute : System.Collections.CollectionBase {
    public DirectoryAttribute() { }
    public DirectoryAttribute(string name, System.Byte[] value) { }
    public DirectoryAttribute(string name, params System.Object[] values) { }
    public DirectoryAttribute(string name, string value) { }
    public DirectoryAttribute(string name, System.Uri value) { }
    public object this[int index] { get { return default(object); } set { } }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public int Add(System.Byte[] value) { return default(int); }
    [System.MonoTODOAttribute]
    public int Add(string value) { return default(int); }
    [System.MonoTODOAttribute]
    public int Add(System.Uri value) { return default(int); }
    [System.MonoTODOAttribute]
    public void AddRange(System.Object[] values) { }
    [System.MonoTODOAttribute]
    public bool Contains(object value) { return default(bool); }
    [System.MonoTODOAttribute]
    public void CopyTo(System.Object[] array, int index) { }
    [System.MonoTODOAttribute]
    public System.Object[] GetValues(System.Type valuesType) { return default(System.Object[]); }
    [System.MonoTODOAttribute]
    public int IndexOf(object value) { return default(int); }
    [System.MonoTODOAttribute]
    public void Insert(int index, System.Byte[] value) { }
    [System.MonoTODOAttribute]
    public void Insert(int index, string value) { }
    [System.MonoTODOAttribute]
    public void Insert(int index, System.Uri value) { }
    [System.MonoTODOAttribute]
    protected override void OnValidate(object value) { }
    [System.MonoTODOAttribute]
    public void Remove(object value) { }
  }
  [System.MonoTODOAttribute]
  public partial class DirectoryAttributeCollection : System.Collections.CollectionBase {
    internal DirectoryAttributeCollection() { }
    public System.DirectoryServices.Protocols.DirectoryAttribute this[int index] { get { return default(System.DirectoryServices.Protocols.DirectoryAttribute); } set { } }
    public int Add(System.DirectoryServices.Protocols.DirectoryAttribute attribute) { return default(int); }
    public void AddRange(System.DirectoryServices.Protocols.DirectoryAttribute[] attributes) { }
    public void AddRange(System.DirectoryServices.Protocols.DirectoryAttributeCollection attributeCollection) { }
    public bool Contains(System.DirectoryServices.Protocols.DirectoryAttribute value) { return default(bool); }
    public void CopyTo(System.DirectoryServices.Protocols.DirectoryAttribute[] array, int index) { }
    public int IndexOf(System.DirectoryServices.Protocols.DirectoryAttribute value) { return default(int); }
    public void Insert(int index, System.DirectoryServices.Protocols.DirectoryAttribute value) { }
    [System.MonoTODOAttribute("verify")]
    protected override void OnValidate(object value) { }
    public void Remove(System.DirectoryServices.Protocols.DirectoryAttribute value) { }
  }
  public partial class DirectoryAttributeModification : System.DirectoryServices.Protocols.DirectoryAttribute {
    public DirectoryAttributeModification() { }
    public System.DirectoryServices.Protocols.DirectoryAttributeOperation Operation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.DirectoryServices.Protocols.DirectoryAttributeOperation); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
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
    [System.MonoTODOAttribute("verify")]
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
    [System.MonoTODOAttribute]
    public System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates { get { return default(System.Security.Cryptography.X509Certificates.X509CertificateCollection); } }
    [System.MonoTODOAttribute]
    public virtual System.Net.NetworkCredential Credential { set { } }
    [System.MonoTODOAttribute]
    public virtual System.DirectoryServices.Protocols.DirectoryIdentifier Directory { get { return default(System.DirectoryServices.Protocols.DirectoryIdentifier); } }
    [System.MonoTODOAttribute]
    public virtual System.TimeSpan Timeout { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.TimeSpan); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
    public abstract System.DirectoryServices.Protocols.DirectoryResponse SendRequest(System.DirectoryServices.Protocols.DirectoryRequest request);
  }
  public partial class DirectoryControl {
    public DirectoryControl(string type, System.Byte[] value, bool isCritical, bool serverSide) { }
    public bool IsCritical { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool ServerSide { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Type { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    [System.MonoTODOAttribute]
    public virtual System.Byte[] GetValue() { return default(System.Byte[]); }
  }
  [System.MonoTODOAttribute]
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
    [System.MonoTODOAttribute("verify")]
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
    internal DirectoryNotificationControl() : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
  }
  public abstract partial class DirectoryOperation {
    protected DirectoryOperation() { }
  }
  [System.MonoTODOAttribute]
  public partial class DirectoryOperationException : System.DirectoryServices.Protocols.DirectoryException, System.Runtime.Serialization.ISerializable {
    public DirectoryOperationException() { }
    public DirectoryOperationException(System.DirectoryServices.Protocols.DirectoryResponse response) { }
    public DirectoryOperationException(System.DirectoryServices.Protocols.DirectoryResponse response, string message) { }
    public DirectoryOperationException(System.DirectoryServices.Protocols.DirectoryResponse response, string message, System.Exception inner) { }
    protected DirectoryOperationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public DirectoryOperationException(string message) { }
    public DirectoryOperationException(string message, System.Exception inner) { }
    public System.DirectoryServices.Protocols.DirectoryResponse Response { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.DirectoryServices.Protocols.DirectoryResponse); } }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, SerializationFormatter=true)]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
  }
  [System.MonoTODOAttribute]
  public abstract partial class DirectoryRequest : System.DirectoryServices.Protocols.DirectoryOperation {
    internal DirectoryRequest() { }
    public System.DirectoryServices.Protocols.DirectoryControlCollection Controls { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.DirectoryServices.Protocols.DirectoryControlCollection); } }
    public string RequestId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected abstract System.Xml.XmlElement ToXmlNode(System.Xml.XmlDocument doc);
  }
  [System.MonoTODOAttribute]
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
  public enum DirectorySynchronizationOptions {
    IncrementalValues = 8,
    None = 0,
    ObjectSecurity = 1,
    ParentsFirst = 2,
    PublicDataOnly = 4,
  }
  public partial class DirSyncRequestControl : System.DirectoryServices.Protocols.DirectoryControl {
    public DirSyncRequestControl() : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public DirSyncRequestControl(System.Byte[] cookie) : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public DirSyncRequestControl(System.Byte[] cookie, System.DirectoryServices.Protocols.DirectorySynchronizationOptions option) : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public DirSyncRequestControl(System.Byte[] cookie, System.DirectoryServices.Protocols.DirectorySynchronizationOptions option, int attributeCount) : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public int AttributeCount { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Byte[] Cookie { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Byte[]); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.DirectoryServices.Protocols.DirectorySynchronizationOptions Option { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.DirectoryServices.Protocols.DirectorySynchronizationOptions); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override System.Byte[] GetValue() { return default(System.Byte[]); }
  }
  [System.MonoTODOAttribute]
  public partial class DirSyncResponseControl : System.DirectoryServices.Protocols.DirectoryControl {
    internal DirSyncResponseControl() : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public System.Byte[] Cookie { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Byte[]); } }
    public bool MoreData { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    public int ResultSize { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
  }
  public partial class DomainScopeControl : System.DirectoryServices.Protocols.DirectoryControl {
    public DomainScopeControl() : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
  }
  public partial class DsmlAuthRequest : System.DirectoryServices.Protocols.DirectoryRequest {
    public DsmlAuthRequest() { }
    public DsmlAuthRequest(string principal) { }
    public string Principal { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    protected override System.Xml.XmlElement ToXmlNode(System.Xml.XmlDocument doc) { return default(System.Xml.XmlElement); }
  }
  public partial class DsmlAuthResponse : System.DirectoryServices.Protocols.DirectoryResponse {
    internal DsmlAuthResponse() { }
  }
  public partial class DsmlDirectoryIdentifier : System.DirectoryServices.Protocols.DirectoryIdentifier {
    public DsmlDirectoryIdentifier(System.Uri serverUri) { }
    public System.Uri ServerUri { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Uri); } }
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
  [System.MonoTODOAttribute]
  public partial class DsmlErrorResponse : System.DirectoryServices.Protocols.DirectoryResponse {
    public DsmlErrorResponse() { }
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
  [System.MonoTODOAttribute]
  public partial class DsmlRequestDocument : System.DirectoryServices.Protocols.DsmlDocument, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList {
    internal DsmlRequestDocument() { }
    public int Count { get { return default(int); } }
    public System.DirectoryServices.Protocols.DsmlDocumentProcessing DocumentProcessing { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.DirectoryServices.Protocols.DsmlDocumentProcessing); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.DirectoryServices.Protocols.DsmlErrorProcessing ErrorProcessing { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.DirectoryServices.Protocols.DsmlErrorProcessing); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected bool IsFixedSize { get { return default(bool); } }
    protected bool IsReadOnly { get { return default(bool); } }
    protected bool IsSynchronized { get { return default(bool); } }
    public System.DirectoryServices.Protocols.DirectoryRequest this[int index] { get { return default(System.DirectoryServices.Protocols.DirectoryRequest); } set { } }
    public string RequestId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.DirectoryServices.Protocols.DsmlResponseOrder ResponseOrder { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.DirectoryServices.Protocols.DsmlResponseOrder); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
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
  [System.MonoTODOAttribute]
  public partial class DsmlResponseDocument : System.DirectoryServices.Protocols.DsmlDocument, System.Collections.ICollection, System.Collections.IEnumerable {
    public DsmlResponseDocument() { }
    public int Count { get { return default(int); } }
    public System.DirectoryServices.Protocols.DsmlDocumentProcessing DocumentProcessing { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.DirectoryServices.Protocols.DsmlDocumentProcessing); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.DirectoryServices.Protocols.DsmlErrorProcessing ErrorProcessing { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.DirectoryServices.Protocols.DsmlErrorProcessing); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public bool IsErrorResponse { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    protected bool IsFixedSize { get { return default(bool); } }
    [System.MonoTODOAttribute]
    public bool IsOperationError { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    protected bool IsReadOnly { get { return default(bool); } }
    protected bool IsSynchronized { get { return default(bool); } }
    public System.DirectoryServices.Protocols.DirectoryResponse this[int index] { get { return default(System.DirectoryServices.Protocols.DirectoryResponse); } set { } }
    [System.MonoTODOAttribute]
    public string RequestId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string ResponseId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.DirectoryServices.Protocols.DsmlResponseOrder ResponseOrder { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.DirectoryServices.Protocols.DsmlResponseOrder); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected object SyncRoot { get { return default(object); } }
    int System.Collections.ICollection.Count { get { return default(int); } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    public int Add(System.DirectoryServices.Protocols.DirectoryResponse request) { return default(int); }
    public void Clear() { }
    public bool Contains(System.DirectoryServices.Protocols.DirectoryResponse value) { return default(bool); }
    public void CopyTo(System.DirectoryServices.Protocols.DirectoryResponse[] value, int i) { }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public int IndexOf(System.DirectoryServices.Protocols.DirectoryResponse value) { return default(int); }
    public void Insert(int index, System.DirectoryServices.Protocols.DirectoryResponse value) { }
    public void Remove(System.DirectoryServices.Protocols.DirectoryResponse value) { }
    public void RemoveAt(int index) { }
    void System.Collections.ICollection.CopyTo(System.Array value, int i) { }
    [System.MonoTODOAttribute]
    public override System.Xml.XmlDocument ToXml() { return default(System.Xml.XmlDocument); }
  }
  public enum DsmlResponseOrder {
    Sequential = 0,
    Unordered = 1,
  }
  public abstract partial class DsmlSoapConnection : System.DirectoryServices.Protocols.DirectoryConnection {
    protected DsmlSoapConnection() { }
    public abstract string SessionId { get; }
    public System.Xml.XmlNode SoapRequestHeader { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xml.XmlNode); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
    public abstract void BeginSession();
    [System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
    public abstract void EndSession();
  }
  public partial class DsmlSoapHttpConnection : System.DirectoryServices.Protocols.DsmlSoapConnection {
    public DsmlSoapHttpConnection(System.DirectoryServices.Protocols.DsmlDirectoryIdentifier identifier) { }
    public DsmlSoapHttpConnection(System.DirectoryServices.Protocols.DsmlDirectoryIdentifier identifier, System.Net.NetworkCredential credential) { }
    public DsmlSoapHttpConnection(System.DirectoryServices.Protocols.DsmlDirectoryIdentifier identifier, System.Net.NetworkCredential credential, System.DirectoryServices.Protocols.AuthType authType) { }
    public DsmlSoapHttpConnection(System.Uri uri) { }
    public System.DirectoryServices.Protocols.AuthType AuthType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.DirectoryServices.Protocols.AuthType); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public override string SessionId { get { return default(string); } }
    public string SoapActionHeader { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override System.TimeSpan Timeout { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.TimeSpan); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
    public void Abort(System.IAsyncResult asyncResult) { }
    [System.Net.NetworkInformation.NetworkInformationPermissionAttribute(System.Security.Permissions.SecurityAction.Assert, Unrestricted=true)]
    [System.Net.WebPermissionAttribute(System.Security.Permissions.SecurityAction.Assert, Unrestricted=true)]
    [System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
    public System.IAsyncResult BeginSendRequest(System.DirectoryServices.Protocols.DsmlRequestDocument request, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    [System.Net.NetworkInformation.NetworkInformationPermissionAttribute(System.Security.Permissions.SecurityAction.Assert, Unrestricted=true)]
    [System.Net.WebPermissionAttribute(System.Security.Permissions.SecurityAction.Assert, Unrestricted=true)]
    [System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
    public override void BeginSession() { }
    public System.DirectoryServices.Protocols.DsmlResponseDocument EndSendRequest(System.IAsyncResult asyncResult) { return default(System.DirectoryServices.Protocols.DsmlResponseDocument); }
    [System.Net.NetworkInformation.NetworkInformationPermissionAttribute(System.Security.Permissions.SecurityAction.Assert, Unrestricted=true)]
    [System.Net.WebPermissionAttribute(System.Security.Permissions.SecurityAction.Assert, Unrestricted=true)]
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
    public System.DirectoryServices.Protocols.DsmlErrorResponse Response { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.DirectoryServices.Protocols.DsmlErrorResponse); } }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, SerializationFormatter=true)]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
  }
  public partial class ExtendedDNControl : System.DirectoryServices.Protocols.DirectoryControl {
    public ExtendedDNControl() : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public ExtendedDNControl(System.DirectoryServices.Protocols.ExtendedDNFlag flag) : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public System.DirectoryServices.Protocols.ExtendedDNFlag Flag { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.DirectoryServices.Protocols.ExtendedDNFlag); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
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
    public string RequestName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Byte[] RequestValue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Byte[]); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    protected override System.Xml.XmlElement ToXmlNode(System.Xml.XmlDocument doc) { return default(System.Xml.XmlElement); }
  }
  public partial class ExtendedResponse : System.DirectoryServices.Protocols.DirectoryResponse {
    internal ExtendedResponse() { }
    [System.MonoTODOAttribute]
    public string ResponseName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    [System.MonoTODOAttribute]
    public System.Byte[] ResponseValue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Byte[]); } }
  }
  public partial class LazyCommitControl : System.DirectoryServices.Protocols.DirectoryControl {
    internal LazyCommitControl() : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
  }
  [System.MonoTODOAttribute]
  public partial class LdapConnection : System.DirectoryServices.Protocols.DirectoryConnection, System.IDisposable {
    public LdapConnection(System.DirectoryServices.Protocols.LdapDirectoryIdentifier identifier) { }
    public LdapConnection(System.DirectoryServices.Protocols.LdapDirectoryIdentifier identifier, System.Net.NetworkCredential credential) { }
    public LdapConnection(System.DirectoryServices.Protocols.LdapDirectoryIdentifier identifier, System.Net.NetworkCredential credential, System.DirectoryServices.Protocols.AuthType authType) { }
    public LdapConnection(string server) { }
    public System.DirectoryServices.Protocols.AuthType AuthType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.DirectoryServices.Protocols.AuthType); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool AutoBind { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public override System.Net.NetworkCredential Credential { set { } }
    [System.MonoTODOAttribute]
    public System.DirectoryServices.Protocols.LdapSessionOptions SessionOptions { get { return default(System.DirectoryServices.Protocols.LdapSessionOptions); } }
    public override System.TimeSpan Timeout { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.TimeSpan); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
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
    public bool Connectionless { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    public bool FullyQualifiedDnsHostName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    public int PortNumber { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    public System.String[] Servers { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.String[]); } }
  }
  public partial class LdapException : System.DirectoryServices.Protocols.DirectoryException, System.Runtime.Serialization.ISerializable {
    public LdapException() { }
    public LdapException(int errorCode) { }
    public LdapException(int errorCode, string message) { }
    public LdapException(int errorCode, string message, System.Exception inner) { }
    public LdapException(int errorCode, string message, string serverErrorMessage) { }
    [System.MonoTODOAttribute]
    protected LdapException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public LdapException(string message) { }
    public LdapException(string message, System.Exception inner) { }
    public int ErrorCode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    public System.DirectoryServices.Protocols.PartialResultsCollection PartialResults { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.DirectoryServices.Protocols.PartialResultsCollection); } }
    public string ServerErrorMessage { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    [System.MonoTODOAttribute]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, SerializationFormatter=true)]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
  }
  public partial class LdapSessionOptions {
    internal LdapSessionOptions() { }
    public bool AutoReconnect { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string DomainName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string HostName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public bool HostReachable { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    public System.DirectoryServices.Protocols.LocatorFlags LocatorFlag { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.DirectoryServices.Protocols.LocatorFlags); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.TimeSpan PingKeepAliveTimeout { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.TimeSpan); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public int PingLimit { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.TimeSpan PingWaitTimeout { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.TimeSpan); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public int ProtocolVersion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.DirectoryServices.Protocols.QueryClientCertificateCallback QueryClientCertificate { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.DirectoryServices.Protocols.QueryClientCertificateCallback); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.DirectoryServices.Protocols.ReferralCallback ReferralCallback { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.DirectoryServices.Protocols.ReferralCallback); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.DirectoryServices.Protocols.ReferralChasingOptions ReferralChasing { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.DirectoryServices.Protocols.ReferralChasingOptions); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public int ReferralHopLimit { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool RootDseCache { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string SaslMethod { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool Sealing { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool SecureSocketLayer { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public object SecurityContext { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } }
    public System.TimeSpan SendTimeout { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.TimeSpan); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool Signing { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public System.DirectoryServices.Protocols.SecurityPackageContextConnectionInformation SslInformation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.DirectoryServices.Protocols.SecurityPackageContextConnectionInformation); } }
    public int SspiFlag { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool TcpKeepAlive { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.DirectoryServices.Protocols.VerifyServerCertificateCallback VerifyServerCertificate { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.DirectoryServices.Protocols.VerifyServerCertificateCallback); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public void FastConcurrentBind() { }
    [System.MonoTODOAttribute]
    public void StartTransportLayerSecurity(System.DirectoryServices.Protocols.DirectoryControlCollection controls) { }
    [System.MonoTODOAttribute]
    public void StopTransportLayerSecurity() { }
  }
  [System.FlagsAttribute]
  public enum LocatorFlags {
    AvoidSelf = 16384,
    DirectoryServicesPreferred = 32,
    DirectoryServicesRequired = 16,
    ForceRediscovery = 1,
    GCRequired = 64,
    GoodTimeServerPreferred = 8192,
    IPRequired = 512,
    IsDnsName = 131072,
    IsFlatName = 65536,
    KdcRequired = 1024,
    None = 0,
    OnlyLdapNeeded = 32768,
    PdcRequired = 128,
    ReturnDnsName = 1073741824,
    ReturnFlatName = -2147483647,
    TimeServerRequired = 2048,
    WriteableRequired = 4096,
  }
  public partial class ModifyDNRequest : System.DirectoryServices.Protocols.DirectoryRequest {
    public ModifyDNRequest() { }
    public ModifyDNRequest(string distinguishedName, string newParentDistinguishedName, string newName) { }
    public bool DeleteOldRdn { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string DistinguishedName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string NewName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string NewParentDistinguishedName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    protected override System.Xml.XmlElement ToXmlNode(System.Xml.XmlDocument doc) { return default(System.Xml.XmlElement); }
  }
  public partial class ModifyDNResponse : System.DirectoryServices.Protocols.DirectoryResponse {
    internal ModifyDNResponse() { }
  }
  [System.MonoTODOAttribute]
  public partial class ModifyRequest : System.DirectoryServices.Protocols.DirectoryRequest {
    public ModifyRequest() { }
    public ModifyRequest(string distinguishedName, params System.DirectoryServices.Protocols.DirectoryAttributeModification[] modifications) { }
    public ModifyRequest(string distinguishedName, System.DirectoryServices.Protocols.DirectoryAttributeOperation operation, string attributeName, params System.Object[] values) { }
    public string DistinguishedName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.DirectoryServices.Protocols.DirectoryAttributeModificationCollection Modifications { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.DirectoryServices.Protocols.DirectoryAttributeModificationCollection); } }
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
    public System.Byte[] Cookie { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Byte[]); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public int PageSize { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public override System.Byte[] GetValue() { return default(System.Byte[]); }
  }
  public partial class PageResultResponseControl : System.DirectoryServices.Protocols.DirectoryControl {
    internal PageResultResponseControl() : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public System.Byte[] Cookie { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Byte[]); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public int TotalCount { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
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
    public System.Security.Principal.SecurityIdentifier QuerySid { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Security.Principal.SecurityIdentifier); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public override System.Byte[] GetValue() { return default(System.Byte[]); }
  }
  public sealed partial class ReferralCallback {
    public ReferralCallback() { }
    public System.DirectoryServices.Protocols.DereferenceConnectionCallback DereferenceConnection { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.DirectoryServices.Protocols.DereferenceConnectionCallback); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.DirectoryServices.Protocols.NotifyOfNewConnectionCallback NotifyNewConnection { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.DirectoryServices.Protocols.NotifyOfNewConnectionCallback); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.DirectoryServices.Protocols.QueryForConnectionCallback QueryForConnection { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.DirectoryServices.Protocols.QueryForConnectionCallback); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
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
    DomainScope = 0,
    PhantomRoot = 1,
  }
  public partial class SearchOptionsControl : System.DirectoryServices.Protocols.DirectoryControl {
    public SearchOptionsControl() : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public SearchOptionsControl(System.DirectoryServices.Protocols.SearchOption flags) : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public System.DirectoryServices.Protocols.SearchOption SearchOption { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.DirectoryServices.Protocols.SearchOption); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public override System.Byte[] GetValue() { return default(System.Byte[]); }
  }
  [System.MonoTODOAttribute]
  public partial class SearchRequest : System.DirectoryServices.Protocols.DirectoryRequest {
    public SearchRequest() { }
    [System.MonoTODOAttribute]
    public SearchRequest(string distinguishedName, string ldapFilter, System.DirectoryServices.Protocols.SearchScope searchScope, params System.String[] attributeList) { }
    [System.MonoTODOAttribute]
    public SearchRequest(string distinguishedName, System.Xml.XmlDocument filter, System.DirectoryServices.Protocols.SearchScope searchScope, params System.String[] attributeList) { }
    public System.DirectoryServices.Protocols.DereferenceAlias Aliases { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.DirectoryServices.Protocols.DereferenceAlias); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.Specialized.StringCollection Attributes { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Specialized.StringCollection); } }
    public string DistinguishedName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public object Filter { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.DirectoryServices.Protocols.SearchScope Scope { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.DirectoryServices.Protocols.SearchScope); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public int SizeLimit { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.TimeSpan TimeLimit { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.TimeSpan); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool TypesOnly { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    protected override System.Xml.XmlElement ToXmlNode(System.Xml.XmlDocument doc) { return default(System.Xml.XmlElement); }
  }
  [System.MonoTODOAttribute]
  public partial class SearchResponse : System.DirectoryServices.Protocols.DirectoryResponse {
    internal SearchResponse() { }
    [System.MonoTODOAttribute]
    public override System.DirectoryServices.Protocols.DirectoryControl[] Controls { get { return default(System.DirectoryServices.Protocols.DirectoryControl[]); } }
    [System.MonoTODOAttribute]
    public System.DirectoryServices.Protocols.SearchResultEntryCollection Entries { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.DirectoryServices.Protocols.SearchResultEntryCollection); } }
    [System.MonoTODOAttribute]
    public override string ErrorMessage { get { return default(string); } }
    [System.MonoTODOAttribute]
    public override string MatchedDN { get { return default(string); } }
    [System.MonoTODOAttribute]
    public System.DirectoryServices.Protocols.SearchResultReferenceCollection References { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.DirectoryServices.Protocols.SearchResultReferenceCollection); } }
    [System.MonoTODOAttribute]
    public override System.Uri[] Referral { get { return default(System.Uri[]); } }
    [System.MonoTODOAttribute]
    public override System.DirectoryServices.Protocols.ResultCode ResultCode { get { return default(System.DirectoryServices.Protocols.ResultCode); } }
  }
  [System.MonoTODOAttribute]
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
    [System.MonoTODOAttribute]
    public System.DirectoryServices.Protocols.SearchResultAttributeCollection Attributes { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.DirectoryServices.Protocols.SearchResultAttributeCollection); } }
    [System.MonoTODOAttribute]
    public System.DirectoryServices.Protocols.DirectoryControl[] Controls { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.DirectoryServices.Protocols.DirectoryControl[]); } }
    [System.MonoTODOAttribute]
    public string DistinguishedName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
  }
  [System.MonoTODOAttribute]
  public partial class SearchResultEntryCollection : System.Collections.ReadOnlyCollectionBase {
    internal SearchResultEntryCollection() { }
    public System.DirectoryServices.Protocols.SearchResultEntry this[int index] { get { return default(System.DirectoryServices.Protocols.SearchResultEntry); } }
    public bool Contains(System.DirectoryServices.Protocols.SearchResultEntry value) { return default(bool); }
    public void CopyTo(System.DirectoryServices.Protocols.SearchResultEntry[] values, int index) { }
    public int IndexOf(System.DirectoryServices.Protocols.SearchResultEntry value) { return default(int); }
  }
  [System.MonoTODOAttribute]
  public partial class SearchResultReference {
    internal SearchResultReference() { }
    public System.DirectoryServices.Protocols.DirectoryControl[] Controls { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.DirectoryServices.Protocols.DirectoryControl[]); } }
    public System.Uri[] Reference { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Uri[]); } }
  }
  [System.MonoTODOAttribute]
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
    [System.MonoTODOAttribute]
    public SecurityDescriptorFlagControl() : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    [System.MonoTODOAttribute]
    public SecurityDescriptorFlagControl(System.DirectoryServices.Protocols.SecurityMasks masks) : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public System.DirectoryServices.Protocols.SecurityMasks SecurityMasks { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.DirectoryServices.Protocols.SecurityMasks); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
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
  [System.MonoTODOAttribute]
  public partial class SecurityPackageContextConnectionInformation {
    internal SecurityPackageContextConnectionInformation() { }
    public System.Security.Authentication.CipherAlgorithmType AlgorithmIdentifier { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Security.Authentication.CipherAlgorithmType); } }
    public int CipherStrength { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    public int ExchangeStrength { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    public System.Security.Authentication.HashAlgorithmType Hash { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Security.Authentication.HashAlgorithmType); } }
    public int HashStrength { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    public int KeyExchangeAlgorithm { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    public System.DirectoryServices.Protocols.SecurityProtocol Protocol { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.DirectoryServices.Protocols.SecurityProtocol); } }
  }
  public enum SecurityProtocol {
    Pct1Client = 1,
    Pct1Server = 0,
    Ssl2Client = 3,
    Ssl2Server = 2,
    Ssl3Client = 5,
    Ssl3Server = 4,
    Tls1Client = 7,
    Tls1Server = 6,
  }
  public partial class ShowDeletedControl : System.DirectoryServices.Protocols.DirectoryControl {
    [System.MonoTODOAttribute]
    public ShowDeletedControl() : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
  }
  public partial class SortKey {
    public SortKey() { }
    public SortKey(string attributeName, string matchingRule, bool reverseOrder) { }
    public string AttributeName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string MatchingRule { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool ReverseOrder { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial class SortRequestControl : System.DirectoryServices.Protocols.DirectoryControl {
    [System.MonoTODOAttribute]
    public SortRequestControl(params System.DirectoryServices.Protocols.SortKey[] sortKeys) : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    [System.MonoTODOAttribute]
    public SortRequestControl(string attributeName, bool reverseOrder) : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    [System.MonoTODOAttribute]
    public SortRequestControl(string attributeName, string matchingRule, bool reverseOrder) : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public System.DirectoryServices.Protocols.SortKey[] SortKeys { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.DirectoryServices.Protocols.SortKey[]); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public override System.Byte[] GetValue() { return default(System.Byte[]); }
  }
  public partial class SortResponseControl : System.DirectoryServices.Protocols.DirectoryControl {
    internal SortResponseControl() : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    [System.MonoTODOAttribute]
    public string AttributeName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    [System.MonoTODOAttribute]
    public System.DirectoryServices.Protocols.ResultCode Result { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.DirectoryServices.Protocols.ResultCode); } }
  }
  public partial class TlsOperationException : System.DirectoryServices.Protocols.DirectoryOperationException {
    public TlsOperationException() { }
    public TlsOperationException(System.DirectoryServices.Protocols.DirectoryResponse response) { }
    public TlsOperationException(System.DirectoryServices.Protocols.DirectoryResponse response, string message) { }
    public TlsOperationException(System.DirectoryServices.Protocols.DirectoryResponse response, string message, System.Exception inner) { }
    protected TlsOperationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public TlsOperationException(string message) { }
    public TlsOperationException(string message, System.Exception inner) { }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, SerializationFormatter=true)]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
  }
  public partial class TreeDeleteControl : System.DirectoryServices.Protocols.DirectoryControl {
    [System.MonoTODOAttribute]
    public TreeDeleteControl() : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
  }
  public partial class VerifyNameControl : System.DirectoryServices.Protocols.DirectoryControl {
    public VerifyNameControl() : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public VerifyNameControl(string serverName) : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public VerifyNameControl(string serverName, int flag) : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public int Flag { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string ServerName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public override System.Byte[] GetValue() { return default(System.Byte[]); }
  }
  public delegate bool VerifyServerCertificateCallback(System.DirectoryServices.Protocols.LdapConnection connection, System.Security.Cryptography.X509Certificates.X509Certificate certificate);
  public partial class VlvRequestControl : System.DirectoryServices.Protocols.DirectoryControl {
    [System.MonoTODOAttribute]
    public VlvRequestControl() : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    [System.MonoTODOAttribute]
    public VlvRequestControl(int beforeCount, int afterCount, System.Byte[] target) : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public VlvRequestControl(int beforeCount, int afterCount, int offset) : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public VlvRequestControl(int beforeCount, int afterCount, string target) : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    public int AfterCount { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public int BeforeCount { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Byte[] ContextId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Byte[]); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public int EstimateCount { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public int Offset { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Byte[] Target { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Byte[]); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public override System.Byte[] GetValue() { return default(System.Byte[]); }
  }
  public partial class VlvResponseControl : System.DirectoryServices.Protocols.DirectoryControl {
    internal VlvResponseControl() : base (default(string), default(System.Byte[]), default(bool), default(bool)) { }
    [System.MonoTODOAttribute]
    public int ContentCount { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    [System.MonoTODOAttribute]
    public System.Byte[] ContextId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Byte[]); } }
    [System.MonoTODOAttribute]
    public System.DirectoryServices.Protocols.ResultCode Result { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.DirectoryServices.Protocols.ResultCode); } }
    [System.MonoTODOAttribute]
    public int TargetPosition { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
  }
}
