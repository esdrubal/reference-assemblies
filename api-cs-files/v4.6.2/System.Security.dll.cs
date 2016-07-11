namespace System.Security.Cryptography {
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public sealed partial class CryptographicAttributeObject {
    public CryptographicAttributeObject(System.Security.Cryptography.Oid oid) { }
    public CryptographicAttributeObject(System.Security.Cryptography.Oid oid, System.Security.Cryptography.AsnEncodedDataCollection values) { }
    public System.Security.Cryptography.Oid Oid { get { return default(System.Security.Cryptography.Oid); } }
    public System.Security.Cryptography.AsnEncodedDataCollection Values { get { return default(System.Security.Cryptography.AsnEncodedDataCollection); } }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public sealed partial class CryptographicAttributeObjectCollection : System.Collections.ICollection, System.Collections.IEnumerable {
    public CryptographicAttributeObjectCollection() { }
    public CryptographicAttributeObjectCollection(System.Security.Cryptography.CryptographicAttributeObject attribute) { }
    public int Count { get { return default(int); } }
    public bool IsSynchronized { get { return default(bool); } }
    public System.Security.Cryptography.CryptographicAttributeObject this[int index] { get { return default(System.Security.Cryptography.CryptographicAttributeObject); } }
    public object SyncRoot { get { return default(object); } }
    public int Add(System.Security.Cryptography.AsnEncodedData asnEncodedData) { return default(int); }
    public int Add(System.Security.Cryptography.CryptographicAttributeObject attribute) { return default(int); }
    public void CopyTo(System.Security.Cryptography.CryptographicAttributeObject[] array, int index) { }
    public System.Security.Cryptography.CryptographicAttributeObjectEnumerator GetEnumerator() { return default(System.Security.Cryptography.CryptographicAttributeObjectEnumerator); }
    public void Remove(System.Security.Cryptography.CryptographicAttributeObject attribute) { }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public sealed partial class CryptographicAttributeObjectEnumerator : System.Collections.IEnumerator {
    internal CryptographicAttributeObjectEnumerator() { }
    public System.Security.Cryptography.CryptographicAttributeObject Current { get { return default(System.Security.Cryptography.CryptographicAttributeObject); } }
    object System.Collections.IEnumerator.Current { get { return default(object); } }
    public bool MoveNext() { return default(bool); }
    public void Reset() { }
  }
  public enum DataProtectionScope {
    CurrentUser = 0,
    LocalMachine = 1,
  }
  public abstract partial class DataProtector {
    protected DataProtector(string applicationName, string primaryPurpose, System.String[] specificPurposes) { }
    protected string ApplicationName { get { return default(string); } }
    protected virtual bool PrependHashedPurposeToPlaintext { get { return default(bool); } }
    protected string PrimaryPurpose { get { return default(string); } }
    protected System.Collections.Generic.IEnumerable<System.String> SpecificPurposes { get { return default(System.Collections.Generic.IEnumerable<System.String>); } }
    public static System.Security.Cryptography.DataProtector Create(string providerClass, string applicationName, string primaryPurpose, params System.String[] specificPurposes) { return default(System.Security.Cryptography.DataProtector); }
    protected virtual System.Byte[] GetHashedPurpose() { return default(System.Byte[]); }
    public abstract bool IsReprotectRequired(System.Byte[] encryptedData);
    public System.Byte[] Protect(System.Byte[] userData) { return default(System.Byte[]); }
    protected abstract System.Byte[] ProviderProtect(System.Byte[] userData);
    protected abstract System.Byte[] ProviderUnprotect(System.Byte[] encryptedData);
    public System.Byte[] Unprotect(System.Byte[] encryptedData) { return default(System.Byte[]); }
  }
  public sealed partial class DpapiDataProtector : System.Security.Cryptography.DataProtector {
    [System.Security.SecuritySafeCriticalAttribute]
    [System.Security.Permissions.DataProtectionPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Unrestricted=true)]
    public DpapiDataProtector(string appName, string primaryPurpose, params System.String[] specificPurpose) : base (default(string), default(string), default(System.String[])) { }
    protected override bool PrependHashedPurposeToPlaintext { get { return default(bool); } }
    public System.Security.Cryptography.DataProtectionScope Scope { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Security.Cryptography.DataProtectionScope); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override bool IsReprotectRequired(System.Byte[] encryptedData) { return default(bool); }
    [System.Security.SecuritySafeCriticalAttribute]
    [System.Security.Permissions.DataProtectionPermissionAttribute(System.Security.Permissions.SecurityAction.Assert, ProtectData=true)]
    protected override System.Byte[] ProviderProtect(System.Byte[] userData) { return default(System.Byte[]); }
    [System.Security.SecuritySafeCriticalAttribute]
    [System.Security.Permissions.DataProtectionPermissionAttribute(System.Security.Permissions.SecurityAction.Assert, UnprotectData=true)]
    protected override System.Byte[] ProviderUnprotect(System.Byte[] encryptedData) { return default(System.Byte[]); }
  }
  public enum MemoryProtectionScope {
    CrossProcess = 1,
    SameLogon = 2,
    SameProcess = 0,
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public static partial class ProtectedData {
    [System.Security.SecuritySafeCriticalAttribute]
    public static System.Byte[] Protect(System.Byte[] userData, System.Byte[] optionalEntropy, System.Security.Cryptography.DataProtectionScope scope) { return default(System.Byte[]); }
    [System.Security.SecuritySafeCriticalAttribute]
    public static System.Byte[] Unprotect(System.Byte[] encryptedData, System.Byte[] optionalEntropy, System.Security.Cryptography.DataProtectionScope scope) { return default(System.Byte[]); }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public static partial class ProtectedMemory {
    [System.Security.SecuritySafeCriticalAttribute]
    public static void Protect(System.Byte[] userData, System.Security.Cryptography.MemoryProtectionScope scope) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public static void Unprotect(System.Byte[] encryptedData, System.Security.Cryptography.MemoryProtectionScope scope) { }
  }
}
namespace System.Security.Cryptography.Pkcs {
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public sealed partial class AlgorithmIdentifier {
    public AlgorithmIdentifier() { }
    public AlgorithmIdentifier(System.Security.Cryptography.Oid oid) { }
    public AlgorithmIdentifier(System.Security.Cryptography.Oid oid, int keyLength) { }
    public int KeyLength { get { return default(int); } set { } }
    public System.Security.Cryptography.Oid Oid { get { return default(System.Security.Cryptography.Oid); } set { } }
    public System.Byte[] Parameters { get { return default(System.Byte[]); } set { } }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public sealed partial class CmsRecipient {
    public CmsRecipient(System.Security.Cryptography.Pkcs.SubjectIdentifierType recipientIdentifierType, System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
    public CmsRecipient(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
    public System.Security.Cryptography.X509Certificates.X509Certificate2 Certificate { get { return default(System.Security.Cryptography.X509Certificates.X509Certificate2); } }
    public System.Security.Cryptography.Pkcs.SubjectIdentifierType RecipientIdentifierType { get { return default(System.Security.Cryptography.Pkcs.SubjectIdentifierType); } }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public sealed partial class CmsRecipientCollection : System.Collections.ICollection, System.Collections.IEnumerable {
    public CmsRecipientCollection() { }
    public CmsRecipientCollection(System.Security.Cryptography.Pkcs.CmsRecipient recipient) { }
    public CmsRecipientCollection(System.Security.Cryptography.Pkcs.SubjectIdentifierType recipientIdentifierType, System.Security.Cryptography.X509Certificates.X509Certificate2Collection certificates) { }
    public int Count { get { return default(int); } }
    public bool IsSynchronized { get { return default(bool); } }
    public System.Security.Cryptography.Pkcs.CmsRecipient this[int index] { get { return default(System.Security.Cryptography.Pkcs.CmsRecipient); } }
    public object SyncRoot { get { return default(object); } }
    public int Add(System.Security.Cryptography.Pkcs.CmsRecipient recipient) { return default(int); }
    public void CopyTo(System.Array array, int index) { }
    public void CopyTo(System.Security.Cryptography.Pkcs.CmsRecipient[] array, int index) { }
    public System.Security.Cryptography.Pkcs.CmsRecipientEnumerator GetEnumerator() { return default(System.Security.Cryptography.Pkcs.CmsRecipientEnumerator); }
    public void Remove(System.Security.Cryptography.Pkcs.CmsRecipient recipient) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public sealed partial class CmsRecipientEnumerator : System.Collections.IEnumerator {
    internal CmsRecipientEnumerator() { }
    public System.Security.Cryptography.Pkcs.CmsRecipient Current { get { return default(System.Security.Cryptography.Pkcs.CmsRecipient); } }
    object System.Collections.IEnumerator.Current { get { return default(object); } }
    public bool MoveNext() { return default(bool); }
    public void Reset() { }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public sealed partial class CmsSigner {
    public CmsSigner() { }
    [System.Security.SecuritySafeCriticalAttribute]
    public CmsSigner(System.Security.Cryptography.CspParameters parameters) { }
    public CmsSigner(System.Security.Cryptography.Pkcs.SubjectIdentifierType signerIdentifierType) { }
    public CmsSigner(System.Security.Cryptography.Pkcs.SubjectIdentifierType signerIdentifierType, System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
    public CmsSigner(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
    public System.Security.Cryptography.X509Certificates.X509Certificate2 Certificate { get { return default(System.Security.Cryptography.X509Certificates.X509Certificate2); } set { } }
    public System.Security.Cryptography.X509Certificates.X509Certificate2Collection Certificates { get { return default(System.Security.Cryptography.X509Certificates.X509Certificate2Collection); } }
    public System.Security.Cryptography.Oid DigestAlgorithm { get { return default(System.Security.Cryptography.Oid); } set { } }
    public System.Security.Cryptography.X509Certificates.X509IncludeOption IncludeOption { get { return default(System.Security.Cryptography.X509Certificates.X509IncludeOption); } set { } }
    public System.Security.Cryptography.CryptographicAttributeObjectCollection SignedAttributes { get { return default(System.Security.Cryptography.CryptographicAttributeObjectCollection); } }
    public System.Security.Cryptography.Pkcs.SubjectIdentifierType SignerIdentifierType { get { return default(System.Security.Cryptography.Pkcs.SubjectIdentifierType); } set { } }
    public System.Security.Cryptography.CryptographicAttributeObjectCollection UnsignedAttributes { get { return default(System.Security.Cryptography.CryptographicAttributeObjectCollection); } }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public sealed partial class ContentInfo {
    public ContentInfo(System.Byte[] content) { }
    public ContentInfo(System.Security.Cryptography.Oid contentType, System.Byte[] content) { }
    public System.Byte[] Content { get { return default(System.Byte[]); } }
    public System.Security.Cryptography.Oid ContentType { get { return default(System.Security.Cryptography.Oid); } }
    ~ContentInfo() { }
    [System.Security.SecuritySafeCriticalAttribute]
    public static System.Security.Cryptography.Oid GetContentType(System.Byte[] encodedMessage) { return default(System.Security.Cryptography.Oid); }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public sealed partial class EnvelopedCms {
    public EnvelopedCms() { }
    public EnvelopedCms(System.Security.Cryptography.Pkcs.ContentInfo contentInfo) { }
    public EnvelopedCms(System.Security.Cryptography.Pkcs.ContentInfo contentInfo, System.Security.Cryptography.Pkcs.AlgorithmIdentifier encryptionAlgorithm) { }
    public EnvelopedCms(System.Security.Cryptography.Pkcs.SubjectIdentifierType recipientIdentifierType, System.Security.Cryptography.Pkcs.ContentInfo contentInfo) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public EnvelopedCms(System.Security.Cryptography.Pkcs.SubjectIdentifierType recipientIdentifierType, System.Security.Cryptography.Pkcs.ContentInfo contentInfo, System.Security.Cryptography.Pkcs.AlgorithmIdentifier encryptionAlgorithm) { }
    public System.Security.Cryptography.X509Certificates.X509Certificate2Collection Certificates { get { return default(System.Security.Cryptography.X509Certificates.X509Certificate2Collection); } }
    public System.Security.Cryptography.Pkcs.AlgorithmIdentifier ContentEncryptionAlgorithm { get { return default(System.Security.Cryptography.Pkcs.AlgorithmIdentifier); } }
    public System.Security.Cryptography.Pkcs.ContentInfo ContentInfo { get { return default(System.Security.Cryptography.Pkcs.ContentInfo); } }
    public System.Security.Cryptography.Pkcs.RecipientInfoCollection RecipientInfos { [System.Security.SecuritySafeCriticalAttribute]get { return default(System.Security.Cryptography.Pkcs.RecipientInfoCollection); } }
    public System.Security.Cryptography.CryptographicAttributeObjectCollection UnprotectedAttributes { get { return default(System.Security.Cryptography.CryptographicAttributeObjectCollection); } }
    public int Version { get { return default(int); } }
    [System.Security.SecuritySafeCriticalAttribute]
    public void Decode(System.Byte[] encodedMessage) { }
    public void Decrypt() { }
    public void Decrypt(System.Security.Cryptography.Pkcs.RecipientInfo recipientInfo) { }
    public void Decrypt(System.Security.Cryptography.Pkcs.RecipientInfo recipientInfo, System.Security.Cryptography.X509Certificates.X509Certificate2Collection extraStore) { }
    public void Decrypt(System.Security.Cryptography.X509Certificates.X509Certificate2Collection extraStore) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public System.Byte[] Encode() { return default(System.Byte[]); }
    public void Encrypt() { }
    public void Encrypt(System.Security.Cryptography.Pkcs.CmsRecipient recipient) { }
    public void Encrypt(System.Security.Cryptography.Pkcs.CmsRecipientCollection recipients) { }
  }
  public enum KeyAgreeKeyChoice {
    EphemeralKey = 1,
    StaticKey = 2,
    Unknown = 0,
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public sealed partial class KeyAgreeRecipientInfo : System.Security.Cryptography.Pkcs.RecipientInfo {
    internal KeyAgreeRecipientInfo() { }
    public System.DateTime Date { get { return default(System.DateTime); } }
    public override System.Byte[] EncryptedKey { [System.Security.SecuritySafeCriticalAttribute]get { return default(System.Byte[]); } }
    public override System.Security.Cryptography.Pkcs.AlgorithmIdentifier KeyEncryptionAlgorithm { [System.Security.SecuritySafeCriticalAttribute]get { return default(System.Security.Cryptography.Pkcs.AlgorithmIdentifier); } }
    public System.Security.Cryptography.Pkcs.SubjectIdentifierOrKey OriginatorIdentifierOrKey { [System.Security.SecuritySafeCriticalAttribute]get { return default(System.Security.Cryptography.Pkcs.SubjectIdentifierOrKey); } }
    public System.Security.Cryptography.CryptographicAttributeObject OtherKeyAttribute { [System.Security.SecuritySafeCriticalAttribute]get { return default(System.Security.Cryptography.CryptographicAttributeObject); } }
    public override System.Security.Cryptography.Pkcs.SubjectIdentifier RecipientIdentifier { [System.Security.SecuritySafeCriticalAttribute]get { return default(System.Security.Cryptography.Pkcs.SubjectIdentifier); } }
    public override int Version { get { return default(int); } }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public sealed partial class KeyTransRecipientInfo : System.Security.Cryptography.Pkcs.RecipientInfo {
    internal KeyTransRecipientInfo() { }
    public override System.Byte[] EncryptedKey { [System.Security.SecuritySafeCriticalAttribute]get { return default(System.Byte[]); } }
    public override System.Security.Cryptography.Pkcs.AlgorithmIdentifier KeyEncryptionAlgorithm { [System.Security.SecuritySafeCriticalAttribute]get { return default(System.Security.Cryptography.Pkcs.AlgorithmIdentifier); } }
    public override System.Security.Cryptography.Pkcs.SubjectIdentifier RecipientIdentifier { [System.Security.SecuritySafeCriticalAttribute]get { return default(System.Security.Cryptography.Pkcs.SubjectIdentifier); } }
    public override int Version { get { return default(int); } }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public partial class Pkcs9AttributeObject : System.Security.Cryptography.AsnEncodedData {
    public Pkcs9AttributeObject() { }
    public Pkcs9AttributeObject(System.Security.Cryptography.AsnEncodedData asnEncodedData) { }
    public Pkcs9AttributeObject(System.Security.Cryptography.Oid oid, System.Byte[] encodedData) { }
    public Pkcs9AttributeObject(string oid, System.Byte[] encodedData) { }
    public new System.Security.Cryptography.Oid Oid { get { return default(System.Security.Cryptography.Oid); } }
    public override void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData) { }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public sealed partial class Pkcs9ContentType : System.Security.Cryptography.Pkcs.Pkcs9AttributeObject {
    public Pkcs9ContentType() { }
    public System.Security.Cryptography.Oid ContentType { get { return default(System.Security.Cryptography.Oid); } }
    public override void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData) { }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public sealed partial class Pkcs9DocumentDescription : System.Security.Cryptography.Pkcs.Pkcs9AttributeObject {
    public Pkcs9DocumentDescription() { }
    public Pkcs9DocumentDescription(System.Byte[] encodedDocumentDescription) { }
    public Pkcs9DocumentDescription(string documentDescription) { }
    public string DocumentDescription { get { return default(string); } }
    public override void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData) { }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public sealed partial class Pkcs9DocumentName : System.Security.Cryptography.Pkcs.Pkcs9AttributeObject {
    public Pkcs9DocumentName() { }
    public Pkcs9DocumentName(System.Byte[] encodedDocumentName) { }
    public Pkcs9DocumentName(string documentName) { }
    public string DocumentName { get { return default(string); } }
    public override void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData) { }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public sealed partial class Pkcs9MessageDigest : System.Security.Cryptography.Pkcs.Pkcs9AttributeObject {
    public Pkcs9MessageDigest() { }
    public System.Byte[] MessageDigest { get { return default(System.Byte[]); } }
    public override void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData) { }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public sealed partial class Pkcs9SigningTime : System.Security.Cryptography.Pkcs.Pkcs9AttributeObject {
    public Pkcs9SigningTime() { }
    public Pkcs9SigningTime(System.Byte[] encodedSigningTime) { }
    public Pkcs9SigningTime(System.DateTime signingTime) { }
    public System.DateTime SigningTime { get { return default(System.DateTime); } }
    public override void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData) { }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public sealed partial class PublicKeyInfo {
    internal PublicKeyInfo() { }
    public System.Security.Cryptography.Pkcs.AlgorithmIdentifier Algorithm { get { return default(System.Security.Cryptography.Pkcs.AlgorithmIdentifier); } }
    public System.Byte[] KeyValue { get { return default(System.Byte[]); } }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public abstract partial class RecipientInfo {
    internal RecipientInfo() { }
    public abstract System.Byte[] EncryptedKey { get; }
    public abstract System.Security.Cryptography.Pkcs.AlgorithmIdentifier KeyEncryptionAlgorithm { get; }
    public abstract System.Security.Cryptography.Pkcs.SubjectIdentifier RecipientIdentifier { get; }
    public System.Security.Cryptography.Pkcs.RecipientInfoType Type { get { return default(System.Security.Cryptography.Pkcs.RecipientInfoType); } }
    public abstract int Version { get; }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public sealed partial class RecipientInfoCollection : System.Collections.ICollection, System.Collections.IEnumerable {
    internal RecipientInfoCollection() { }
    public int Count { get { return default(int); } }
    public bool IsSynchronized { get { return default(bool); } }
    public System.Security.Cryptography.Pkcs.RecipientInfo this[int index] { get { return default(System.Security.Cryptography.Pkcs.RecipientInfo); } }
    public object SyncRoot { get { return default(object); } }
    public void CopyTo(System.Array array, int index) { }
    public void CopyTo(System.Security.Cryptography.Pkcs.RecipientInfo[] array, int index) { }
    public System.Security.Cryptography.Pkcs.RecipientInfoEnumerator GetEnumerator() { return default(System.Security.Cryptography.Pkcs.RecipientInfoEnumerator); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public sealed partial class RecipientInfoEnumerator : System.Collections.IEnumerator {
    internal RecipientInfoEnumerator() { }
    public System.Security.Cryptography.Pkcs.RecipientInfo Current { get { return default(System.Security.Cryptography.Pkcs.RecipientInfo); } }
    object System.Collections.IEnumerator.Current { get { return default(object); } }
    public bool MoveNext() { return default(bool); }
    public void Reset() { }
  }
  public enum RecipientInfoType {
    KeyAgreement = 2,
    KeyTransport = 1,
    Unknown = 0,
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public sealed partial class SignedCms {
    public SignedCms() { }
    public SignedCms(System.Security.Cryptography.Pkcs.ContentInfo contentInfo) { }
    public SignedCms(System.Security.Cryptography.Pkcs.ContentInfo contentInfo, bool detached) { }
    public SignedCms(System.Security.Cryptography.Pkcs.SubjectIdentifierType signerIdentifierType) { }
    public SignedCms(System.Security.Cryptography.Pkcs.SubjectIdentifierType signerIdentifierType, System.Security.Cryptography.Pkcs.ContentInfo contentInfo) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public SignedCms(System.Security.Cryptography.Pkcs.SubjectIdentifierType signerIdentifierType, System.Security.Cryptography.Pkcs.ContentInfo contentInfo, bool detached) { }
    public System.Security.Cryptography.X509Certificates.X509Certificate2Collection Certificates { [System.Security.SecuritySafeCriticalAttribute]get { return default(System.Security.Cryptography.X509Certificates.X509Certificate2Collection); } }
    public System.Security.Cryptography.Pkcs.ContentInfo ContentInfo { get { return default(System.Security.Cryptography.Pkcs.ContentInfo); } }
    public bool Detached { get { return default(bool); } }
    public System.Security.Cryptography.Pkcs.SignerInfoCollection SignerInfos { [System.Security.SecuritySafeCriticalAttribute]get { return default(System.Security.Cryptography.Pkcs.SignerInfoCollection); } }
    public int Version { [System.Security.SecuritySafeCriticalAttribute]get { return default(int); } }
    [System.Security.SecuritySafeCriticalAttribute]
    public void CheckHash() { }
    public void CheckSignature(bool verifySignatureOnly) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public void CheckSignature(System.Security.Cryptography.X509Certificates.X509Certificate2Collection extraStore, bool verifySignatureOnly) { }
    public void ComputeSignature() { }
    public void ComputeSignature(System.Security.Cryptography.Pkcs.CmsSigner signer) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public void ComputeSignature(System.Security.Cryptography.Pkcs.CmsSigner signer, bool silent) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public void Decode(System.Byte[] encodedMessage) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public System.Byte[] Encode() { return default(System.Byte[]); }
    [System.Security.SecuritySafeCriticalAttribute]
    public void RemoveSignature(int index) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public void RemoveSignature(System.Security.Cryptography.Pkcs.SignerInfo signerInfo) { }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public sealed partial class SignerInfo {
    internal SignerInfo() { }
    public System.Security.Cryptography.X509Certificates.X509Certificate2 Certificate { get { return default(System.Security.Cryptography.X509Certificates.X509Certificate2); } }
    public System.Security.Cryptography.Pkcs.SignerInfoCollection CounterSignerInfos { get { return default(System.Security.Cryptography.Pkcs.SignerInfoCollection); } }
    public System.Security.Cryptography.Oid DigestAlgorithm { get { return default(System.Security.Cryptography.Oid); } }
    public System.Security.Cryptography.CryptographicAttributeObjectCollection SignedAttributes { [System.Security.SecuritySafeCriticalAttribute]get { return default(System.Security.Cryptography.CryptographicAttributeObjectCollection); } }
    public System.Security.Cryptography.Pkcs.SubjectIdentifier SignerIdentifier { [System.Security.SecuritySafeCriticalAttribute]get { return default(System.Security.Cryptography.Pkcs.SubjectIdentifier); } }
    public System.Security.Cryptography.CryptographicAttributeObjectCollection UnsignedAttributes { [System.Security.SecuritySafeCriticalAttribute]get { return default(System.Security.Cryptography.CryptographicAttributeObjectCollection); } }
    public int Version { get { return default(int); } }
    [System.Security.SecuritySafeCriticalAttribute]
    public void CheckHash() { }
    public void CheckSignature(bool verifySignatureOnly) { }
    public void CheckSignature(System.Security.Cryptography.X509Certificates.X509Certificate2Collection extraStore, bool verifySignatureOnly) { }
    public void ComputeCounterSignature() { }
    public void ComputeCounterSignature(System.Security.Cryptography.Pkcs.CmsSigner signer) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public void RemoveCounterSignature(int index) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public void RemoveCounterSignature(System.Security.Cryptography.Pkcs.SignerInfo counterSignerInfo) { }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public sealed partial class SignerInfoCollection : System.Collections.ICollection, System.Collections.IEnumerable {
    internal SignerInfoCollection() { }
    public int Count { get { return default(int); } }
    public bool IsSynchronized { get { return default(bool); } }
    public System.Security.Cryptography.Pkcs.SignerInfo this[int index] { get { return default(System.Security.Cryptography.Pkcs.SignerInfo); } }
    public object SyncRoot { get { return default(object); } }
    public void CopyTo(System.Array array, int index) { }
    public void CopyTo(System.Security.Cryptography.Pkcs.SignerInfo[] array, int index) { }
    public System.Security.Cryptography.Pkcs.SignerInfoEnumerator GetEnumerator() { return default(System.Security.Cryptography.Pkcs.SignerInfoEnumerator); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public sealed partial class SignerInfoEnumerator : System.Collections.IEnumerator {
    internal SignerInfoEnumerator() { }
    public System.Security.Cryptography.Pkcs.SignerInfo Current { get { return default(System.Security.Cryptography.Pkcs.SignerInfo); } }
    object System.Collections.IEnumerator.Current { get { return default(object); } }
    public bool MoveNext() { return default(bool); }
    public void Reset() { }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public sealed partial class SubjectIdentifier {
    internal SubjectIdentifier() { }
    public System.Security.Cryptography.Pkcs.SubjectIdentifierType Type { get { return default(System.Security.Cryptography.Pkcs.SubjectIdentifierType); } }
    public object Value { get { return default(object); } }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public sealed partial class SubjectIdentifierOrKey {
    internal SubjectIdentifierOrKey() { }
    public System.Security.Cryptography.Pkcs.SubjectIdentifierOrKeyType Type { get { return default(System.Security.Cryptography.Pkcs.SubjectIdentifierOrKeyType); } }
    public object Value { get { return default(object); } }
  }
  public enum SubjectIdentifierOrKeyType {
    IssuerAndSerialNumber = 1,
    PublicKeyInfo = 3,
    SubjectKeyIdentifier = 2,
    Unknown = 0,
  }
  public enum SubjectIdentifierType {
    IssuerAndSerialNumber = 1,
    NoSignature = 3,
    SubjectKeyIdentifier = 2,
    Unknown = 0,
  }
}
namespace System.Security.Cryptography.X509Certificates {
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public static partial class X509Certificate2UI {
    [System.Security.SecuritySafeCriticalAttribute]
    public static void DisplayCertificate(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
    [System.Security.SecurityCriticalAttribute]
    public static void DisplayCertificate(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, System.IntPtr hwndParent) { }
    public static System.Security.Cryptography.X509Certificates.X509Certificate2Collection SelectFromCollection(System.Security.Cryptography.X509Certificates.X509Certificate2Collection certificates, string title, string message, System.Security.Cryptography.X509Certificates.X509SelectionFlag selectionFlag) { return default(System.Security.Cryptography.X509Certificates.X509Certificate2Collection); }
    [System.Security.SecurityCriticalAttribute]
    public static System.Security.Cryptography.X509Certificates.X509Certificate2Collection SelectFromCollection(System.Security.Cryptography.X509Certificates.X509Certificate2Collection certificates, string title, string message, System.Security.Cryptography.X509Certificates.X509SelectionFlag selectionFlag, System.IntPtr hwndParent) { return default(System.Security.Cryptography.X509Certificates.X509Certificate2Collection); }
  }
  public enum X509SelectionFlag {
    MultiSelection = 1,
    SingleSelection = 0,
  }
}
namespace System.Security.Cryptography.Xml {
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public sealed partial class CipherData {
    public CipherData() { }
    public CipherData(System.Byte[] cipherValue) { }
    public CipherData(System.Security.Cryptography.Xml.CipherReference cipherReference) { }
    public System.Security.Cryptography.Xml.CipherReference CipherReference { get { return default(System.Security.Cryptography.Xml.CipherReference); } set { } }
    public System.Byte[] CipherValue { get { return default(System.Byte[]); } set { } }
    public System.Xml.XmlElement GetXml() { return default(System.Xml.XmlElement); }
    public void LoadXml(System.Xml.XmlElement value) { }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public sealed partial class CipherReference : System.Security.Cryptography.Xml.EncryptedReference {
    public CipherReference() { }
    public CipherReference(string uri) { }
    public CipherReference(string uri, System.Security.Cryptography.Xml.TransformChain transformChain) { }
    public override System.Xml.XmlElement GetXml() { return default(System.Xml.XmlElement); }
    public override void LoadXml(System.Xml.XmlElement value) { }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public partial class DataObject {
    public DataObject() { }
    public DataObject(string id, string mimeType, string encoding, System.Xml.XmlElement data) { }
    public System.Xml.XmlNodeList Data { get { return default(System.Xml.XmlNodeList); } set { } }
    public string Encoding { get { return default(string); } set { } }
    public string Id { get { return default(string); } set { } }
    public string MimeType { get { return default(string); } set { } }
    public System.Xml.XmlElement GetXml() { return default(System.Xml.XmlElement); }
    public void LoadXml(System.Xml.XmlElement value) { }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public sealed partial class DataReference : System.Security.Cryptography.Xml.EncryptedReference {
    public DataReference() { }
    public DataReference(string uri) { }
    public DataReference(string uri, System.Security.Cryptography.Xml.TransformChain transformChain) { }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public partial class DSAKeyValue : System.Security.Cryptography.Xml.KeyInfoClause {
    public DSAKeyValue() { }
    public DSAKeyValue(System.Security.Cryptography.DSA key) { }
    public System.Security.Cryptography.DSA Key { get { return default(System.Security.Cryptography.DSA); } set { } }
    public override System.Xml.XmlElement GetXml() { return default(System.Xml.XmlElement); }
    public override void LoadXml(System.Xml.XmlElement value) { }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public sealed partial class EncryptedData : System.Security.Cryptography.Xml.EncryptedType {
    public EncryptedData() { }
    public override System.Xml.XmlElement GetXml() { return default(System.Xml.XmlElement); }
    public override void LoadXml(System.Xml.XmlElement value) { }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public sealed partial class EncryptedKey : System.Security.Cryptography.Xml.EncryptedType {
    public EncryptedKey() { }
    public string CarriedKeyName { get { return default(string); } set { } }
    public string Recipient { get { return default(string); } set { } }
    public System.Security.Cryptography.Xml.ReferenceList ReferenceList { get { return default(System.Security.Cryptography.Xml.ReferenceList); } }
    public void AddReference(System.Security.Cryptography.Xml.DataReference dataReference) { }
    public void AddReference(System.Security.Cryptography.Xml.KeyReference keyReference) { }
    public override System.Xml.XmlElement GetXml() { return default(System.Xml.XmlElement); }
    public override void LoadXml(System.Xml.XmlElement value) { }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public abstract partial class EncryptedReference {
    protected EncryptedReference() { }
    protected EncryptedReference(string uri) { }
    protected EncryptedReference(string uri, System.Security.Cryptography.Xml.TransformChain transformChain) { }
    protected internal bool CacheValid { get { return default(bool); } }
    protected string ReferenceType { get { return default(string); } set { } }
    public System.Security.Cryptography.Xml.TransformChain TransformChain { get { return default(System.Security.Cryptography.Xml.TransformChain); } set { } }
    public string Uri { get { return default(string); } set { } }
    public void AddTransform(System.Security.Cryptography.Xml.Transform transform) { }
    public virtual System.Xml.XmlElement GetXml() { return default(System.Xml.XmlElement); }
    public virtual void LoadXml(System.Xml.XmlElement value) { }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public abstract partial class EncryptedType {
    protected EncryptedType() { }
    public virtual System.Security.Cryptography.Xml.CipherData CipherData { get { return default(System.Security.Cryptography.Xml.CipherData); } set { } }
    public virtual string Encoding { get { return default(string); } set { } }
    public virtual System.Security.Cryptography.Xml.EncryptionMethod EncryptionMethod { get { return default(System.Security.Cryptography.Xml.EncryptionMethod); } set { } }
    public virtual System.Security.Cryptography.Xml.EncryptionPropertyCollection EncryptionProperties { get { return default(System.Security.Cryptography.Xml.EncryptionPropertyCollection); } }
    public virtual string Id { get { return default(string); } set { } }
    public System.Security.Cryptography.Xml.KeyInfo KeyInfo { get { return default(System.Security.Cryptography.Xml.KeyInfo); } set { } }
    public virtual string MimeType { get { return default(string); } set { } }
    public virtual string Type { get { return default(string); } set { } }
    public void AddProperty(System.Security.Cryptography.Xml.EncryptionProperty ep) { }
    public abstract System.Xml.XmlElement GetXml();
    public abstract void LoadXml(System.Xml.XmlElement value);
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public partial class EncryptedXml {
    public const string XmlEncAES128KeyWrapUrl = "http://www.w3.org/2001/04/xmlenc#kw-aes128";
    public const string XmlEncAES128Url = "http://www.w3.org/2001/04/xmlenc#aes128-cbc";
    public const string XmlEncAES192KeyWrapUrl = "http://www.w3.org/2001/04/xmlenc#kw-aes192";
    public const string XmlEncAES192Url = "http://www.w3.org/2001/04/xmlenc#aes192-cbc";
    public const string XmlEncAES256KeyWrapUrl = "http://www.w3.org/2001/04/xmlenc#kw-aes256";
    public const string XmlEncAES256Url = "http://www.w3.org/2001/04/xmlenc#aes256-cbc";
    public const string XmlEncDESUrl = "http://www.w3.org/2001/04/xmlenc#des-cbc";
    public const string XmlEncElementContentUrl = "http://www.w3.org/2001/04/xmlenc#Content";
    public const string XmlEncElementUrl = "http://www.w3.org/2001/04/xmlenc#Element";
    public const string XmlEncEncryptedKeyUrl = "http://www.w3.org/2001/04/xmlenc#EncryptedKey";
    public const string XmlEncNamespaceUrl = "http://www.w3.org/2001/04/xmlenc#";
    public const string XmlEncRSA15Url = "http://www.w3.org/2001/04/xmlenc#rsa-1_5";
    public const string XmlEncRSAOAEPUrl = "http://www.w3.org/2001/04/xmlenc#rsa-oaep-mgf1p";
    public const string XmlEncSHA256Url = "http://www.w3.org/2001/04/xmlenc#sha256";
    public const string XmlEncSHA512Url = "http://www.w3.org/2001/04/xmlenc#sha512";
    public const string XmlEncTripleDESKeyWrapUrl = "http://www.w3.org/2001/04/xmlenc#kw-tripledes";
    public const string XmlEncTripleDESUrl = "http://www.w3.org/2001/04/xmlenc#tripledes-cbc";
    public EncryptedXml() { }
    public EncryptedXml(System.Xml.XmlDocument document) { }
    public EncryptedXml(System.Xml.XmlDocument document, System.Security.Policy.Evidence evidence) { }
    public System.Security.Policy.Evidence DocumentEvidence { get { return default(System.Security.Policy.Evidence); } set { } }
    public System.Text.Encoding Encoding { get { return default(System.Text.Encoding); } set { } }
    public System.Security.Cryptography.CipherMode Mode { get { return default(System.Security.Cryptography.CipherMode); } set { } }
    public System.Security.Cryptography.PaddingMode Padding { get { return default(System.Security.Cryptography.PaddingMode); } set { } }
    public string Recipient { get { return default(string); } set { } }
    public System.Xml.XmlResolver Resolver { get { return default(System.Xml.XmlResolver); } set { } }
    public int XmlDSigSearchDepth { get { return default(int); } set { } }
    public void AddKeyNameMapping(string keyName, object keyObject) { }
    public void ClearKeyNameMappings() { }
    public System.Byte[] DecryptData(System.Security.Cryptography.Xml.EncryptedData encryptedData, System.Security.Cryptography.SymmetricAlgorithm symmetricAlgorithm) { return default(System.Byte[]); }
    public void DecryptDocument() { }
    public virtual System.Byte[] DecryptEncryptedKey(System.Security.Cryptography.Xml.EncryptedKey encryptedKey) { return default(System.Byte[]); }
    public static System.Byte[] DecryptKey(System.Byte[] keyData, System.Security.Cryptography.RSA rsa, bool useOAEP) { return default(System.Byte[]); }
    public static System.Byte[] DecryptKey(System.Byte[] keyData, System.Security.Cryptography.SymmetricAlgorithm symmetricAlgorithm) { return default(System.Byte[]); }
    public System.Security.Cryptography.Xml.EncryptedData Encrypt(System.Xml.XmlElement inputElement, System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { return default(System.Security.Cryptography.Xml.EncryptedData); }
    public System.Security.Cryptography.Xml.EncryptedData Encrypt(System.Xml.XmlElement inputElement, string keyName) { return default(System.Security.Cryptography.Xml.EncryptedData); }
    public System.Byte[] EncryptData(System.Byte[] plaintext, System.Security.Cryptography.SymmetricAlgorithm symmetricAlgorithm) { return default(System.Byte[]); }
    public System.Byte[] EncryptData(System.Xml.XmlElement inputElement, System.Security.Cryptography.SymmetricAlgorithm symmetricAlgorithm, bool content) { return default(System.Byte[]); }
    public static System.Byte[] EncryptKey(System.Byte[] keyData, System.Security.Cryptography.RSA rsa, bool useOAEP) { return default(System.Byte[]); }
    public static System.Byte[] EncryptKey(System.Byte[] keyData, System.Security.Cryptography.SymmetricAlgorithm symmetricAlgorithm) { return default(System.Byte[]); }
    public virtual System.Byte[] GetDecryptionIV(System.Security.Cryptography.Xml.EncryptedData encryptedData, string symmetricAlgorithmUri) { return default(System.Byte[]); }
    public virtual System.Security.Cryptography.SymmetricAlgorithm GetDecryptionKey(System.Security.Cryptography.Xml.EncryptedData encryptedData, string symmetricAlgorithmUri) { return default(System.Security.Cryptography.SymmetricAlgorithm); }
    public virtual System.Xml.XmlElement GetIdElement(System.Xml.XmlDocument document, string idValue) { return default(System.Xml.XmlElement); }
    public void ReplaceData(System.Xml.XmlElement inputElement, System.Byte[] decryptedData) { }
    public static void ReplaceElement(System.Xml.XmlElement inputElement, System.Security.Cryptography.Xml.EncryptedData encryptedData, bool content) { }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public partial class EncryptionMethod {
    public EncryptionMethod() { }
    public EncryptionMethod(string algorithm) { }
    public string KeyAlgorithm { get { return default(string); } set { } }
    public int KeySize { get { return default(int); } set { } }
    public System.Xml.XmlElement GetXml() { return default(System.Xml.XmlElement); }
    public void LoadXml(System.Xml.XmlElement value) { }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public sealed partial class EncryptionProperty {
    public EncryptionProperty() { }
    public EncryptionProperty(System.Xml.XmlElement elementProperty) { }
    public string Id { get { return default(string); } }
    public System.Xml.XmlElement PropertyElement { get { return default(System.Xml.XmlElement); } set { } }
    public string Target { get { return default(string); } }
    public System.Xml.XmlElement GetXml() { return default(System.Xml.XmlElement); }
    public void LoadXml(System.Xml.XmlElement value) { }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public sealed partial class EncryptionPropertyCollection : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList {
    public EncryptionPropertyCollection() { }
    public int Count { get { return default(int); } }
    public bool IsFixedSize { get { return default(bool); } }
    public bool IsReadOnly { get { return default(bool); } }
    public bool IsSynchronized { get { return default(bool); } }
    [System.Runtime.CompilerServices.IndexerName("ItemOf")]
    public System.Security.Cryptography.Xml.EncryptionProperty this[int index] { get { return default(System.Security.Cryptography.Xml.EncryptionProperty); } set { } }
    public object SyncRoot { get { return default(object); } }
    object System.Collections.IList.this[int index] { get { return default(object); } set { } }
    public int Add(System.Security.Cryptography.Xml.EncryptionProperty value) { return default(int); }
    public void Clear() { }
    public bool Contains(System.Security.Cryptography.Xml.EncryptionProperty value) { return default(bool); }
    public void CopyTo(System.Array array, int index) { }
    public void CopyTo(System.Security.Cryptography.Xml.EncryptionProperty[] array, int index) { }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public int IndexOf(System.Security.Cryptography.Xml.EncryptionProperty value) { return default(int); }
    public void Insert(int index, System.Security.Cryptography.Xml.EncryptionProperty value) { }
    public System.Security.Cryptography.Xml.EncryptionProperty Item(int index) { return default(System.Security.Cryptography.Xml.EncryptionProperty); }
    public void Remove(System.Security.Cryptography.Xml.EncryptionProperty value) { }
    public void RemoveAt(int index) { }
    int System.Collections.IList.Add(object value) { return default(int); }
    bool System.Collections.IList.Contains(object value) { return default(bool); }
    int System.Collections.IList.IndexOf(object value) { return default(int); }
    void System.Collections.IList.Insert(int index, object value) { }
    void System.Collections.IList.Remove(object value) { }
  }
  public partial interface IRelDecryptor {
    System.IO.Stream Decrypt(System.Security.Cryptography.Xml.EncryptionMethod encryptionMethod, System.Security.Cryptography.Xml.KeyInfo keyInfo, System.IO.Stream toDecrypt);
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public partial class KeyInfo : System.Collections.IEnumerable {
    public KeyInfo() { }
    public int Count { get { return default(int); } }
    public string Id { get { return default(string); } set { } }
    public void AddClause(System.Security.Cryptography.Xml.KeyInfoClause clause) { }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public System.Collections.IEnumerator GetEnumerator(System.Type requestedObjectType) { return default(System.Collections.IEnumerator); }
    public System.Xml.XmlElement GetXml() { return default(System.Xml.XmlElement); }
    public void LoadXml(System.Xml.XmlElement value) { }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public abstract partial class KeyInfoClause {
    protected KeyInfoClause() { }
    public abstract System.Xml.XmlElement GetXml();
    public abstract void LoadXml(System.Xml.XmlElement element);
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public partial class KeyInfoEncryptedKey : System.Security.Cryptography.Xml.KeyInfoClause {
    public KeyInfoEncryptedKey() { }
    public KeyInfoEncryptedKey(System.Security.Cryptography.Xml.EncryptedKey encryptedKey) { }
    public System.Security.Cryptography.Xml.EncryptedKey EncryptedKey { get { return default(System.Security.Cryptography.Xml.EncryptedKey); } set { } }
    public override System.Xml.XmlElement GetXml() { return default(System.Xml.XmlElement); }
    public override void LoadXml(System.Xml.XmlElement value) { }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public partial class KeyInfoName : System.Security.Cryptography.Xml.KeyInfoClause {
    public KeyInfoName() { }
    public KeyInfoName(string keyName) { }
    public string Value { get { return default(string); } set { } }
    public override System.Xml.XmlElement GetXml() { return default(System.Xml.XmlElement); }
    public override void LoadXml(System.Xml.XmlElement value) { }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public partial class KeyInfoNode : System.Security.Cryptography.Xml.KeyInfoClause {
    public KeyInfoNode() { }
    public KeyInfoNode(System.Xml.XmlElement node) { }
    public System.Xml.XmlElement Value { get { return default(System.Xml.XmlElement); } set { } }
    public override System.Xml.XmlElement GetXml() { return default(System.Xml.XmlElement); }
    public override void LoadXml(System.Xml.XmlElement value) { }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public partial class KeyInfoRetrievalMethod : System.Security.Cryptography.Xml.KeyInfoClause {
    public KeyInfoRetrievalMethod() { }
    public KeyInfoRetrievalMethod(string strUri) { }
    public KeyInfoRetrievalMethod(string strUri, string typeName) { }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public string Type { get { return default(string); } set { } }
    public string Uri { get { return default(string); } set { } }
    public override System.Xml.XmlElement GetXml() { return default(System.Xml.XmlElement); }
    public override void LoadXml(System.Xml.XmlElement value) { }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public partial class KeyInfoX509Data : System.Security.Cryptography.Xml.KeyInfoClause {
    public KeyInfoX509Data() { }
    public KeyInfoX509Data(System.Byte[] rgbCert) { }
    public KeyInfoX509Data(System.Security.Cryptography.X509Certificates.X509Certificate cert) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public KeyInfoX509Data(System.Security.Cryptography.X509Certificates.X509Certificate cert, System.Security.Cryptography.X509Certificates.X509IncludeOption includeOption) { }
    public System.Collections.ArrayList Certificates { get { return default(System.Collections.ArrayList); } }
    public System.Byte[] CRL { get { return default(System.Byte[]); } set { } }
    public System.Collections.ArrayList IssuerSerials { get { return default(System.Collections.ArrayList); } }
    public System.Collections.ArrayList SubjectKeyIds { get { return default(System.Collections.ArrayList); } }
    public System.Collections.ArrayList SubjectNames { get { return default(System.Collections.ArrayList); } }
    public void AddCertificate(System.Security.Cryptography.X509Certificates.X509Certificate certificate) { }
    public void AddIssuerSerial(string issuerName, string serialNumber) { }
    public void AddSubjectKeyId(System.Byte[] subjectKeyId) { }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public void AddSubjectKeyId(string subjectKeyId) { }
    public void AddSubjectName(string subjectName) { }
    public override System.Xml.XmlElement GetXml() { return default(System.Xml.XmlElement); }
    public override void LoadXml(System.Xml.XmlElement element) { }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public sealed partial class KeyReference : System.Security.Cryptography.Xml.EncryptedReference {
    public KeyReference() { }
    public KeyReference(string uri) { }
    public KeyReference(string uri, System.Security.Cryptography.Xml.TransformChain transformChain) { }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public partial class Reference {
    public Reference() { }
    public Reference(System.IO.Stream stream) { }
    public Reference(string uri) { }
    public string DigestMethod { get { return default(string); } set { } }
    public System.Byte[] DigestValue { get { return default(System.Byte[]); } set { } }
    public string Id { get { return default(string); } set { } }
    public System.Security.Cryptography.Xml.TransformChain TransformChain { get { return default(System.Security.Cryptography.Xml.TransformChain); } [System.Runtime.InteropServices.ComVisibleAttribute(false)]set { } }
    public string Type { get { return default(string); } set { } }
    public string Uri { get { return default(string); } set { } }
    public void AddTransform(System.Security.Cryptography.Xml.Transform transform) { }
    public System.Xml.XmlElement GetXml() { return default(System.Xml.XmlElement); }
    public void LoadXml(System.Xml.XmlElement value) { }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public sealed partial class ReferenceList : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList {
    public ReferenceList() { }
    public int Count { get { return default(int); } }
    public bool IsSynchronized { get { return default(bool); } }
    [System.Runtime.CompilerServices.IndexerName("ItemOf")]
    public System.Security.Cryptography.Xml.EncryptedReference this[int index] { get { return default(System.Security.Cryptography.Xml.EncryptedReference); } set { } }
    public object SyncRoot { get { return default(object); } }
    bool System.Collections.IList.IsFixedSize { get { return default(bool); } }
    bool System.Collections.IList.IsReadOnly { get { return default(bool); } }
    object System.Collections.IList.this[int index] { get { return default(object); } set { } }
    public int Add(object value) { return default(int); }
    public void Clear() { }
    public bool Contains(object value) { return default(bool); }
    public void CopyTo(System.Array array, int index) { }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public int IndexOf(object value) { return default(int); }
    public void Insert(int index, object value) { }
    public System.Security.Cryptography.Xml.EncryptedReference Item(int index) { return default(System.Security.Cryptography.Xml.EncryptedReference); }
    public void Remove(object value) { }
    public void RemoveAt(int index) { }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public partial class RSAKeyValue : System.Security.Cryptography.Xml.KeyInfoClause {
    public RSAKeyValue() { }
    public RSAKeyValue(System.Security.Cryptography.RSA key) { }
    public System.Security.Cryptography.RSA Key { get { return default(System.Security.Cryptography.RSA); } set { } }
    public override System.Xml.XmlElement GetXml() { return default(System.Xml.XmlElement); }
    public override void LoadXml(System.Xml.XmlElement value) { }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public partial class Signature {
    public Signature() { }
    public string Id { get { return default(string); } set { } }
    public System.Security.Cryptography.Xml.KeyInfo KeyInfo { get { return default(System.Security.Cryptography.Xml.KeyInfo); } set { } }
    public System.Collections.IList ObjectList { get { return default(System.Collections.IList); } set { } }
    public System.Byte[] SignatureValue { get { return default(System.Byte[]); } set { } }
    public System.Security.Cryptography.Xml.SignedInfo SignedInfo { get { return default(System.Security.Cryptography.Xml.SignedInfo); } set { } }
    public void AddObject(System.Security.Cryptography.Xml.DataObject dataObject) { }
    public System.Xml.XmlElement GetXml() { return default(System.Xml.XmlElement); }
    public void LoadXml(System.Xml.XmlElement value) { }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public partial class SignedInfo : System.Collections.ICollection, System.Collections.IEnumerable {
    public SignedInfo() { }
    public string CanonicalizationMethod { get { return default(string); } set { } }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public System.Security.Cryptography.Xml.Transform CanonicalizationMethodObject { get { return default(System.Security.Cryptography.Xml.Transform); } }
    public int Count { get { return default(int); } }
    public string Id { get { return default(string); } set { } }
    public bool IsReadOnly { get { return default(bool); } }
    public bool IsSynchronized { get { return default(bool); } }
    public System.Collections.ArrayList References { get { return default(System.Collections.ArrayList); } }
    public string SignatureLength { get { return default(string); } set { } }
    public string SignatureMethod { get { return default(string); } set { } }
    public object SyncRoot { get { return default(object); } }
    public void AddReference(System.Security.Cryptography.Xml.Reference reference) { }
    public void CopyTo(System.Array array, int index) { }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public System.Xml.XmlElement GetXml() { return default(System.Xml.XmlElement); }
    public void LoadXml(System.Xml.XmlElement value) { }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public partial class SignedXml {
    protected System.Security.Cryptography.Xml.Signature m_signature;
    protected string m_strSigningKeyName;
    public const string XmlDecryptionTransformUrl = "http://www.w3.org/2002/07/decrypt#XML";
    public const string XmlDsigBase64TransformUrl = "http://www.w3.org/2000/09/xmldsig#base64";
    public const string XmlDsigC14NTransformUrl = "http://www.w3.org/TR/2001/REC-xml-c14n-20010315";
    public const string XmlDsigC14NWithCommentsTransformUrl = "http://www.w3.org/TR/2001/REC-xml-c14n-20010315#WithComments";
    public const string XmlDsigCanonicalizationUrl = "http://www.w3.org/TR/2001/REC-xml-c14n-20010315";
    public const string XmlDsigCanonicalizationWithCommentsUrl = "http://www.w3.org/TR/2001/REC-xml-c14n-20010315#WithComments";
    public const string XmlDsigDSAUrl = "http://www.w3.org/2000/09/xmldsig#dsa-sha1";
    public const string XmlDsigEnvelopedSignatureTransformUrl = "http://www.w3.org/2000/09/xmldsig#enveloped-signature";
    public const string XmlDsigExcC14NTransformUrl = "http://www.w3.org/2001/10/xml-exc-c14n#";
    public const string XmlDsigExcC14NWithCommentsTransformUrl = "http://www.w3.org/2001/10/xml-exc-c14n#WithComments";
    public const string XmlDsigHMACSHA1Url = "http://www.w3.org/2000/09/xmldsig#hmac-sha1";
    public const string XmlDsigMinimalCanonicalizationUrl = "http://www.w3.org/2000/09/xmldsig#minimal";
    public const string XmlDsigNamespaceUrl = "http://www.w3.org/2000/09/xmldsig#";
    public const string XmlDsigRSASHA1Url = "http://www.w3.org/2000/09/xmldsig#rsa-sha1";
    public const string XmlDsigRSASHA256Url = "http://www.w3.org/2001/04/xmldsig-more#rsa-sha256";
    public const string XmlDsigRSASHA384Url = "http://www.w3.org/2001/04/xmldsig-more#rsa-sha384";
    public const string XmlDsigRSASHA512Url = "http://www.w3.org/2001/04/xmldsig-more#rsa-sha512";
    public const string XmlDsigSHA1Url = "http://www.w3.org/2000/09/xmldsig#sha1";
    public const string XmlDsigSHA256Url = "http://www.w3.org/2001/04/xmlenc#sha256";
    public const string XmlDsigSHA384Url = "http://www.w3.org/2001/04/xmldsig-more#sha384";
    public const string XmlDsigSHA512Url = "http://www.w3.org/2001/04/xmlenc#sha512";
    public const string XmlDsigXPathTransformUrl = "http://www.w3.org/TR/1999/REC-xpath-19991116";
    public const string XmlDsigXsltTransformUrl = "http://www.w3.org/TR/1999/REC-xslt-19991116";
    public const string XmlLicenseTransformUrl = "urn:mpeg:mpeg21:2003:01-REL-R-NS:licenseTransform";
    public SignedXml() { }
    public SignedXml(System.Xml.XmlDocument document) { }
    public SignedXml(System.Xml.XmlElement elem) { }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public System.Security.Cryptography.Xml.EncryptedXml EncryptedXml { get { return default(System.Security.Cryptography.Xml.EncryptedXml); } set { } }
    public System.Security.Cryptography.Xml.KeyInfo KeyInfo { get { return default(System.Security.Cryptography.Xml.KeyInfo); } set { } }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public System.Xml.XmlResolver Resolver { set { } }
    public System.Collections.ObjectModel.Collection<System.String> SafeCanonicalizationMethods { get { return default(System.Collections.ObjectModel.Collection<System.String>); } }
    public System.Security.Cryptography.Xml.Signature Signature { get { return default(System.Security.Cryptography.Xml.Signature); } }
    public System.Func<System.Security.Cryptography.Xml.SignedXml, System.Boolean> SignatureFormatValidator { get { return default(System.Func<System.Security.Cryptography.Xml.SignedXml, System.Boolean>); } set { } }
    public string SignatureLength { get { return default(string); } }
    public string SignatureMethod { get { return default(string); } }
    public System.Byte[] SignatureValue { get { return default(System.Byte[]); } }
    public System.Security.Cryptography.Xml.SignedInfo SignedInfo { get { return default(System.Security.Cryptography.Xml.SignedInfo); } }
    public System.Security.Cryptography.AsymmetricAlgorithm SigningKey { get { return default(System.Security.Cryptography.AsymmetricAlgorithm); } set { } }
    public string SigningKeyName { get { return default(string); } set { } }
    public void AddObject(System.Security.Cryptography.Xml.DataObject dataObject) { }
    public void AddReference(System.Security.Cryptography.Xml.Reference reference) { }
    public bool CheckSignature() { return default(bool); }
    public bool CheckSignature(System.Security.Cryptography.AsymmetricAlgorithm key) { return default(bool); }
    public bool CheckSignature(System.Security.Cryptography.KeyedHashAlgorithm macAlg) { return default(bool); }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    [System.Security.SecuritySafeCriticalAttribute]
    public bool CheckSignature(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, bool verifySignatureOnly) { return default(bool); }
    public bool CheckSignatureReturningKey(out System.Security.Cryptography.AsymmetricAlgorithm signingKey) { signingKey = default(System.Security.Cryptography.AsymmetricAlgorithm); return default(bool); }
    public void ComputeSignature() { }
    public void ComputeSignature(System.Security.Cryptography.KeyedHashAlgorithm macAlg) { }
    public virtual System.Xml.XmlElement GetIdElement(System.Xml.XmlDocument document, string idValue) { return default(System.Xml.XmlElement); }
    protected virtual System.Security.Cryptography.AsymmetricAlgorithm GetPublicKey() { return default(System.Security.Cryptography.AsymmetricAlgorithm); }
    public System.Xml.XmlElement GetXml() { return default(System.Xml.XmlElement); }
    public void LoadXml(System.Xml.XmlElement value) { }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public abstract partial class Transform {
    protected Transform() { }
    public string Algorithm { get { return default(string); } set { } }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public System.Xml.XmlElement Context { get { return default(System.Xml.XmlElement); } set { } }
    public abstract System.Type[] InputTypes { get; }
    public abstract System.Type[] OutputTypes { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public System.Collections.Hashtable PropagatedNamespaces { get { return default(System.Collections.Hashtable); } }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public System.Xml.XmlResolver Resolver { set { } }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public virtual System.Byte[] GetDigestedOutput(System.Security.Cryptography.HashAlgorithm hash) { return default(System.Byte[]); }
    protected abstract System.Xml.XmlNodeList GetInnerXml();
    public abstract object GetOutput();
    public abstract object GetOutput(System.Type type);
    public System.Xml.XmlElement GetXml() { return default(System.Xml.XmlElement); }
    public abstract void LoadInnerXml(System.Xml.XmlNodeList nodeList);
    public abstract void LoadInput(object obj);
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public partial class TransformChain {
    public TransformChain() { }
    public int Count { get { return default(int); } }
    public System.Security.Cryptography.Xml.Transform this[int index] { get { return default(System.Security.Cryptography.Xml.Transform); } }
    public void Add(System.Security.Cryptography.Xml.Transform transform) { }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct X509IssuerSerial {
    public string IssuerName { get { return default(string); } set { } }
    public string SerialNumber { get { return default(string); } set { } }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public partial class XmlDecryptionTransform : System.Security.Cryptography.Xml.Transform {
    public XmlDecryptionTransform() { }
    public System.Security.Cryptography.Xml.EncryptedXml EncryptedXml { get { return default(System.Security.Cryptography.Xml.EncryptedXml); } set { } }
    public override System.Type[] InputTypes { get { return default(System.Type[]); } }
    public override System.Type[] OutputTypes { get { return default(System.Type[]); } }
    public void AddExceptUri(string uri) { }
    protected override System.Xml.XmlNodeList GetInnerXml() { return default(System.Xml.XmlNodeList); }
    public override object GetOutput() { return default(object); }
    public override object GetOutput(System.Type type) { return default(object); }
    protected virtual bool IsTargetElement(System.Xml.XmlElement inputElement, string idValue) { return default(bool); }
    public override void LoadInnerXml(System.Xml.XmlNodeList nodeList) { }
    public override void LoadInput(object obj) { }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public partial class XmlDsigBase64Transform : System.Security.Cryptography.Xml.Transform {
    public XmlDsigBase64Transform() { }
    public override System.Type[] InputTypes { get { return default(System.Type[]); } }
    public override System.Type[] OutputTypes { get { return default(System.Type[]); } }
    protected override System.Xml.XmlNodeList GetInnerXml() { return default(System.Xml.XmlNodeList); }
    public override object GetOutput() { return default(object); }
    public override object GetOutput(System.Type type) { return default(object); }
    public override void LoadInnerXml(System.Xml.XmlNodeList nodeList) { }
    public override void LoadInput(object obj) { }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public partial class XmlDsigC14NTransform : System.Security.Cryptography.Xml.Transform {
    public XmlDsigC14NTransform() { }
    public XmlDsigC14NTransform(bool includeComments) { }
    public override System.Type[] InputTypes { get { return default(System.Type[]); } }
    public override System.Type[] OutputTypes { get { return default(System.Type[]); } }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public override System.Byte[] GetDigestedOutput(System.Security.Cryptography.HashAlgorithm hash) { return default(System.Byte[]); }
    protected override System.Xml.XmlNodeList GetInnerXml() { return default(System.Xml.XmlNodeList); }
    public override object GetOutput() { return default(object); }
    public override object GetOutput(System.Type type) { return default(object); }
    public override void LoadInnerXml(System.Xml.XmlNodeList nodeList) { }
    public override void LoadInput(object obj) { }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public partial class XmlDsigC14NWithCommentsTransform : System.Security.Cryptography.Xml.XmlDsigC14NTransform {
    public XmlDsigC14NWithCommentsTransform() { }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public partial class XmlDsigEnvelopedSignatureTransform : System.Security.Cryptography.Xml.Transform {
    public XmlDsigEnvelopedSignatureTransform() { }
    public XmlDsigEnvelopedSignatureTransform(bool includeComments) { }
    public override System.Type[] InputTypes { get { return default(System.Type[]); } }
    public override System.Type[] OutputTypes { get { return default(System.Type[]); } }
    protected override System.Xml.XmlNodeList GetInnerXml() { return default(System.Xml.XmlNodeList); }
    public override object GetOutput() { return default(object); }
    public override object GetOutput(System.Type type) { return default(object); }
    public override void LoadInnerXml(System.Xml.XmlNodeList nodeList) { }
    public override void LoadInput(object obj) { }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public partial class XmlDsigExcC14NTransform : System.Security.Cryptography.Xml.Transform {
    public XmlDsigExcC14NTransform() { }
    public XmlDsigExcC14NTransform(bool includeComments) { }
    public XmlDsigExcC14NTransform(bool includeComments, string inclusiveNamespacesPrefixList) { }
    public XmlDsigExcC14NTransform(string inclusiveNamespacesPrefixList) { }
    public string InclusiveNamespacesPrefixList { get { return default(string); } set { } }
    public override System.Type[] InputTypes { get { return default(System.Type[]); } }
    public override System.Type[] OutputTypes { get { return default(System.Type[]); } }
    public override System.Byte[] GetDigestedOutput(System.Security.Cryptography.HashAlgorithm hash) { return default(System.Byte[]); }
    protected override System.Xml.XmlNodeList GetInnerXml() { return default(System.Xml.XmlNodeList); }
    public override object GetOutput() { return default(object); }
    public override object GetOutput(System.Type type) { return default(object); }
    public override void LoadInnerXml(System.Xml.XmlNodeList nodeList) { }
    public override void LoadInput(object obj) { }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public partial class XmlDsigExcC14NWithCommentsTransform : System.Security.Cryptography.Xml.XmlDsigExcC14NTransform {
    public XmlDsigExcC14NWithCommentsTransform() { }
    public XmlDsigExcC14NWithCommentsTransform(string inclusiveNamespacesPrefixList) { }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public partial class XmlDsigXPathTransform : System.Security.Cryptography.Xml.Transform {
    public XmlDsigXPathTransform() { }
    public override System.Type[] InputTypes { get { return default(System.Type[]); } }
    public override System.Type[] OutputTypes { get { return default(System.Type[]); } }
    protected override System.Xml.XmlNodeList GetInnerXml() { return default(System.Xml.XmlNodeList); }
    public override object GetOutput() { return default(object); }
    public override object GetOutput(System.Type type) { return default(object); }
    public override void LoadInnerXml(System.Xml.XmlNodeList nodeList) { }
    public override void LoadInput(object obj) { }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public partial class XmlDsigXsltTransform : System.Security.Cryptography.Xml.Transform {
    public XmlDsigXsltTransform() { }
    public XmlDsigXsltTransform(bool includeComments) { }
    public override System.Type[] InputTypes { get { return default(System.Type[]); } }
    public override System.Type[] OutputTypes { get { return default(System.Type[]); } }
    protected override System.Xml.XmlNodeList GetInnerXml() { return default(System.Xml.XmlNodeList); }
    public override object GetOutput() { return default(object); }
    public override object GetOutput(System.Type type) { return default(object); }
    public override void LoadInnerXml(System.Xml.XmlNodeList nodeList) { }
    public override void LoadInput(object obj) { }
  }
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public partial class XmlLicenseTransform : System.Security.Cryptography.Xml.Transform {
    public XmlLicenseTransform() { }
    public System.Security.Cryptography.Xml.IRelDecryptor Decryptor { get { return default(System.Security.Cryptography.Xml.IRelDecryptor); } set { } }
    public override System.Type[] InputTypes { get { return default(System.Type[]); } }
    public override System.Type[] OutputTypes { get { return default(System.Type[]); } }
    protected override System.Xml.XmlNodeList GetInnerXml() { return default(System.Xml.XmlNodeList); }
    public override object GetOutput() { return default(object); }
    public override object GetOutput(System.Type type) { return default(object); }
    public override void LoadInnerXml(System.Xml.XmlNodeList nodeList) { }
    public override void LoadInput(object obj) { }
  }
}
namespace System.Security.Permissions {
  public sealed partial class DataProtectionPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission {
    public DataProtectionPermission(System.Security.Permissions.DataProtectionPermissionFlags flag) { }
    public DataProtectionPermission(System.Security.Permissions.PermissionState state) { }
    public System.Security.Permissions.DataProtectionPermissionFlags Flags { get { return default(System.Security.Permissions.DataProtectionPermissionFlags); } set { } }
    public override System.Security.IPermission Copy() { return default(System.Security.IPermission); }
    public override void FromXml(System.Security.SecurityElement securityElement) { }
    public override System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
    public override bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
    public bool IsUnrestricted() { return default(bool); }
    public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
    public override System.Security.IPermission Union(System.Security.IPermission target) { return default(System.Security.IPermission); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
  [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
  public sealed partial class DataProtectionPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute {
    public DataProtectionPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
    public System.Security.Permissions.DataProtectionPermissionFlags Flags { get { return default(System.Security.Permissions.DataProtectionPermissionFlags); } set { } }
    public bool ProtectData { get { return default(bool); } set { } }
    public bool ProtectMemory { get { return default(bool); } set { } }
    public bool UnprotectData { get { return default(bool); } set { } }
    public bool UnprotectMemory { get { return default(bool); } set { } }
    public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
  }
  [System.FlagsAttribute]
  public enum DataProtectionPermissionFlags {
    AllFlags = 15,
    NoFlags = 0,
    ProtectData = 1,
    ProtectMemory = 4,
    UnprotectData = 2,
    UnprotectMemory = 8,
  }
}
