namespace System.Security.Cryptography {
  public sealed partial class CryptographicAttributeObject {
    public CryptographicAttributeObject(System.Security.Cryptography.Oid oid) { }
    public CryptographicAttributeObject(System.Security.Cryptography.Oid oid, System.Security.Cryptography.AsnEncodedDataCollection values) { }
    public System.Security.Cryptography.Oid Oid { get { return default(System.Security.Cryptography.Oid); } }
    public System.Security.Cryptography.AsnEncodedDataCollection Values { get { return default(System.Security.Cryptography.AsnEncodedDataCollection); } }
  }
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
  public enum MemoryProtectionScope {
    CrossProcess = 1,
    SameLogon = 2,
    SameProcess = 0,
  }
  public sealed partial class ProtectedData {
    internal ProtectedData() { }
    public static System.Byte[] Protect(System.Byte[] userData, System.Byte[] optionalEntropy, System.Security.Cryptography.DataProtectionScope scope) { return default(System.Byte[]); }
    public static System.Byte[] Unprotect(System.Byte[] encryptedData, System.Byte[] optionalEntropy, System.Security.Cryptography.DataProtectionScope scope) { return default(System.Byte[]); }
  }
  public sealed partial class ProtectedMemory {
    internal ProtectedMemory() { }
    [System.MonoTODOAttribute("only supported on Windows 2000 SP3 and later")]
    public static void Protect(System.Byte[] userData, System.Security.Cryptography.MemoryProtectionScope scope) { }
    [System.MonoTODOAttribute("only supported on Windows 2000 SP3 and later")]
    public static void Unprotect(System.Byte[] encryptedData, System.Security.Cryptography.MemoryProtectionScope scope) { }
  }
}
namespace System.Security.Cryptography.Pkcs {
  public sealed partial class AlgorithmIdentifier {
    public AlgorithmIdentifier() { }
    public AlgorithmIdentifier(System.Security.Cryptography.Oid algorithm) { }
    public AlgorithmIdentifier(System.Security.Cryptography.Oid algorithm, int keyLength) { }
    public int KeyLength { get { return default(int); } set { } }
    public System.Security.Cryptography.Oid Oid { get { return default(System.Security.Cryptography.Oid); } set { } }
    public System.Byte[] Parameters { get { return default(System.Byte[]); } set { } }
  }
  public sealed partial class CmsRecipient {
    public CmsRecipient(System.Security.Cryptography.Pkcs.SubjectIdentifierType recipientIdentifierType, System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
    public CmsRecipient(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
    public System.Security.Cryptography.X509Certificates.X509Certificate2 Certificate { get { return default(System.Security.Cryptography.X509Certificates.X509Certificate2); } }
    public System.Security.Cryptography.Pkcs.SubjectIdentifierType RecipientIdentifierType { get { return default(System.Security.Cryptography.Pkcs.SubjectIdentifierType); } }
  }
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
  public sealed partial class CmsRecipientEnumerator : System.Collections.IEnumerator {
    internal CmsRecipientEnumerator() { }
    public System.Security.Cryptography.Pkcs.CmsRecipient Current { get { return default(System.Security.Cryptography.Pkcs.CmsRecipient); } }
    object System.Collections.IEnumerator.Current { get { return default(object); } }
    public bool MoveNext() { return default(bool); }
    public void Reset() { }
  }
  public sealed partial class CmsSigner {
    public CmsSigner() { }
    [System.MonoTODOAttribute]
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
  public sealed partial class ContentInfo {
    public ContentInfo(System.Byte[] content) { }
    public ContentInfo(System.Security.Cryptography.Oid oid, System.Byte[] content) { }
    public System.Byte[] Content { get { return default(System.Byte[]); } }
    public System.Security.Cryptography.Oid ContentType { get { return default(System.Security.Cryptography.Oid); } }
    ~ContentInfo() { }
    [System.MonoTODOAttribute("MS is stricter than us about the content structure")]
    public static System.Security.Cryptography.Oid GetContentType(System.Byte[] encodedMessage) { return default(System.Security.Cryptography.Oid); }
  }
  public sealed partial class EnvelopedCms {
    public EnvelopedCms() { }
    public EnvelopedCms(System.Security.Cryptography.Pkcs.ContentInfo content) { }
    public EnvelopedCms(System.Security.Cryptography.Pkcs.ContentInfo contentInfo, System.Security.Cryptography.Pkcs.AlgorithmIdentifier encryptionAlgorithm) { }
    public EnvelopedCms(System.Security.Cryptography.Pkcs.SubjectIdentifierType recipientIdentifierType, System.Security.Cryptography.Pkcs.ContentInfo contentInfo) { }
    public EnvelopedCms(System.Security.Cryptography.Pkcs.SubjectIdentifierType recipientIdentifierType, System.Security.Cryptography.Pkcs.ContentInfo contentInfo, System.Security.Cryptography.Pkcs.AlgorithmIdentifier encryptionAlgorithm) { }
    public System.Security.Cryptography.X509Certificates.X509Certificate2Collection Certificates { get { return default(System.Security.Cryptography.X509Certificates.X509Certificate2Collection); } }
    public System.Security.Cryptography.Pkcs.AlgorithmIdentifier ContentEncryptionAlgorithm { get { return default(System.Security.Cryptography.Pkcs.AlgorithmIdentifier); } }
    public System.Security.Cryptography.Pkcs.ContentInfo ContentInfo { get { return default(System.Security.Cryptography.Pkcs.ContentInfo); } }
    public System.Security.Cryptography.Pkcs.RecipientInfoCollection RecipientInfos { get { return default(System.Security.Cryptography.Pkcs.RecipientInfoCollection); } }
    public System.Security.Cryptography.CryptographicAttributeObjectCollection UnprotectedAttributes { get { return default(System.Security.Cryptography.CryptographicAttributeObjectCollection); } }
    public int Version { get { return default(int); } }
    [System.MonoTODOAttribute]
    public void Decode(System.Byte[] encodedMessage) { }
    [System.MonoTODOAttribute]
    public void Decrypt() { }
    [System.MonoTODOAttribute]
    public void Decrypt(System.Security.Cryptography.Pkcs.RecipientInfo recipientInfo) { }
    [System.MonoTODOAttribute]
    public void Decrypt(System.Security.Cryptography.Pkcs.RecipientInfo recipientInfo, System.Security.Cryptography.X509Certificates.X509Certificate2Collection extraStore) { }
    [System.MonoTODOAttribute]
    public void Decrypt(System.Security.Cryptography.X509Certificates.X509Certificate2Collection extraStore) { }
    [System.MonoTODOAttribute]
    public System.Byte[] Encode() { return default(System.Byte[]); }
    [System.MonoTODOAttribute]
    public void Encrypt() { }
    [System.MonoTODOAttribute]
    public void Encrypt(System.Security.Cryptography.Pkcs.CmsRecipient recipient) { }
    [System.MonoTODOAttribute]
    public void Encrypt(System.Security.Cryptography.Pkcs.CmsRecipientCollection recipients) { }
  }
  public enum KeyAgreeKeyChoice {
    EphemeralKey = 1,
    StaticKey = 2,
    Unknown = 0,
  }
  [System.MonoTODOAttribute]
  public sealed partial class KeyAgreeRecipientInfo : System.Security.Cryptography.Pkcs.RecipientInfo {
    internal KeyAgreeRecipientInfo() { }
    public System.DateTime Date { get { return default(System.DateTime); } }
    public override System.Byte[] EncryptedKey { get { return default(System.Byte[]); } }
    public override System.Security.Cryptography.Pkcs.AlgorithmIdentifier KeyEncryptionAlgorithm { get { return default(System.Security.Cryptography.Pkcs.AlgorithmIdentifier); } }
    public System.Security.Cryptography.Pkcs.SubjectIdentifierOrKey OriginatorIdentifierOrKey { get { return default(System.Security.Cryptography.Pkcs.SubjectIdentifierOrKey); } }
    public System.Security.Cryptography.CryptographicAttributeObject OtherKeyAttribute { get { return default(System.Security.Cryptography.CryptographicAttributeObject); } }
    public override System.Security.Cryptography.Pkcs.SubjectIdentifier RecipientIdentifier { get { return default(System.Security.Cryptography.Pkcs.SubjectIdentifier); } }
    public override int Version { get { return default(int); } }
  }
  public sealed partial class KeyTransRecipientInfo : System.Security.Cryptography.Pkcs.RecipientInfo {
    internal KeyTransRecipientInfo() { }
    public override System.Byte[] EncryptedKey { get { return default(System.Byte[]); } }
    public override System.Security.Cryptography.Pkcs.AlgorithmIdentifier KeyEncryptionAlgorithm { get { return default(System.Security.Cryptography.Pkcs.AlgorithmIdentifier); } }
    public override System.Security.Cryptography.Pkcs.SubjectIdentifier RecipientIdentifier { get { return default(System.Security.Cryptography.Pkcs.SubjectIdentifier); } }
    public override int Version { get { return default(int); } }
  }
  public partial class Pkcs9AttributeObject : System.Security.Cryptography.AsnEncodedData {
    public Pkcs9AttributeObject() { }
    public Pkcs9AttributeObject(System.Security.Cryptography.AsnEncodedData asnEncodedData) { }
    public Pkcs9AttributeObject(System.Security.Cryptography.Oid oid, System.Byte[] encodedData) { }
    public Pkcs9AttributeObject(string oid, System.Byte[] encodedData) { }
    public new System.Security.Cryptography.Oid Oid { get { return default(System.Security.Cryptography.Oid); } }
    public override void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData) { }
  }
  public sealed partial class Pkcs9ContentType : System.Security.Cryptography.Pkcs.Pkcs9AttributeObject {
    public Pkcs9ContentType() { }
    public System.Security.Cryptography.Oid ContentType { get { return default(System.Security.Cryptography.Oid); } }
    public override void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData) { }
  }
  public sealed partial class Pkcs9DocumentDescription : System.Security.Cryptography.Pkcs.Pkcs9AttributeObject {
    public Pkcs9DocumentDescription() { }
    public Pkcs9DocumentDescription(System.Byte[] encodedDocumentDescription) { }
    public Pkcs9DocumentDescription(string documentDescription) { }
    public string DocumentDescription { get { return default(string); } }
    public override void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData) { }
  }
  public sealed partial class Pkcs9DocumentName : System.Security.Cryptography.Pkcs.Pkcs9AttributeObject {
    public Pkcs9DocumentName() { }
    public Pkcs9DocumentName(System.Byte[] encodedDocumentName) { }
    public Pkcs9DocumentName(string documentName) { }
    public string DocumentName { get { return default(string); } }
    public override void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData) { }
  }
  public sealed partial class Pkcs9MessageDigest : System.Security.Cryptography.Pkcs.Pkcs9AttributeObject {
    public Pkcs9MessageDigest() { }
    public System.Byte[] MessageDigest { get { return default(System.Byte[]); } }
    public override void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData) { }
  }
  public sealed partial class Pkcs9SigningTime : System.Security.Cryptography.Pkcs.Pkcs9AttributeObject {
    public Pkcs9SigningTime() { }
    public Pkcs9SigningTime(System.Byte[] encodedSigningTime) { }
    public Pkcs9SigningTime(System.DateTime signingTime) { }
    public System.DateTime SigningTime { get { return default(System.DateTime); } }
    public override void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData) { }
  }
  public sealed partial class PublicKeyInfo {
    internal PublicKeyInfo() { }
    public System.Security.Cryptography.Pkcs.AlgorithmIdentifier Algorithm { get { return default(System.Security.Cryptography.Pkcs.AlgorithmIdentifier); } }
    public System.Byte[] KeyValue { get { return default(System.Byte[]); } }
  }
  public abstract partial class RecipientInfo {
    internal RecipientInfo() { }
    public abstract System.Byte[] EncryptedKey { get; }
    public abstract System.Security.Cryptography.Pkcs.AlgorithmIdentifier KeyEncryptionAlgorithm { get; }
    public abstract System.Security.Cryptography.Pkcs.SubjectIdentifier RecipientIdentifier { get; }
    public System.Security.Cryptography.Pkcs.RecipientInfoType Type { get { return default(System.Security.Cryptography.Pkcs.RecipientInfoType); } }
    public abstract int Version { get; }
  }
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
  public sealed partial class SignedCms {
    public SignedCms() { }
    public SignedCms(System.Security.Cryptography.Pkcs.ContentInfo content) { }
    public SignedCms(System.Security.Cryptography.Pkcs.ContentInfo content, bool detached) { }
    public SignedCms(System.Security.Cryptography.Pkcs.SubjectIdentifierType signerIdentifierType) { }
    public SignedCms(System.Security.Cryptography.Pkcs.SubjectIdentifierType signerIdentifierType, System.Security.Cryptography.Pkcs.ContentInfo content) { }
    public SignedCms(System.Security.Cryptography.Pkcs.SubjectIdentifierType signerIdentifierType, System.Security.Cryptography.Pkcs.ContentInfo content, bool detached) { }
    public System.Security.Cryptography.X509Certificates.X509Certificate2Collection Certificates { get { return default(System.Security.Cryptography.X509Certificates.X509Certificate2Collection); } }
    public System.Security.Cryptography.Pkcs.ContentInfo ContentInfo { get { return default(System.Security.Cryptography.Pkcs.ContentInfo); } }
    public bool Detached { get { return default(bool); } }
    public System.Security.Cryptography.Pkcs.SignerInfoCollection SignerInfos { get { return default(System.Security.Cryptography.Pkcs.SignerInfoCollection); } }
    public int Version { get { return default(int); } }
    [System.MonoTODOAttribute]
    public void CheckHash() { }
    [System.MonoTODOAttribute]
    public void CheckSignature(bool verifySignatureOnly) { }
    [System.MonoTODOAttribute]
    public void CheckSignature(System.Security.Cryptography.X509Certificates.X509Certificate2Collection extraStore, bool verifySignatureOnly) { }
    [System.MonoTODOAttribute]
    public void ComputeSignature() { }
    [System.MonoTODOAttribute]
    public void ComputeSignature(System.Security.Cryptography.Pkcs.CmsSigner signer) { }
    [System.MonoTODOAttribute]
    public void ComputeSignature(System.Security.Cryptography.Pkcs.CmsSigner signer, bool silent) { }
    [System.MonoTODOAttribute("incomplete - missing attributes")]
    public void Decode(System.Byte[] encodedMessage) { }
    [System.MonoTODOAttribute]
    public System.Byte[] Encode() { return default(System.Byte[]); }
    [System.MonoTODOAttribute]
    public void RemoveSignature(int index) { }
    [System.MonoTODOAttribute]
    public void RemoveSignature(System.Security.Cryptography.Pkcs.SignerInfo signerInfo) { }
  }
  public sealed partial class SignerInfo {
    internal SignerInfo() { }
    public System.Security.Cryptography.X509Certificates.X509Certificate2 Certificate { get { return default(System.Security.Cryptography.X509Certificates.X509Certificate2); } }
    public System.Security.Cryptography.Pkcs.SignerInfoCollection CounterSignerInfos { get { return default(System.Security.Cryptography.Pkcs.SignerInfoCollection); } }
    public System.Security.Cryptography.Oid DigestAlgorithm { get { return default(System.Security.Cryptography.Oid); } }
    public System.Security.Cryptography.CryptographicAttributeObjectCollection SignedAttributes { get { return default(System.Security.Cryptography.CryptographicAttributeObjectCollection); } }
    public System.Security.Cryptography.Pkcs.SubjectIdentifier SignerIdentifier { get { return default(System.Security.Cryptography.Pkcs.SubjectIdentifier); } }
    public System.Security.Cryptography.CryptographicAttributeObjectCollection UnsignedAttributes { get { return default(System.Security.Cryptography.CryptographicAttributeObjectCollection); } }
    public int Version { get { return default(int); } }
    [System.MonoTODOAttribute]
    public void CheckHash() { }
    [System.MonoTODOAttribute]
    public void CheckSignature(bool verifySignatureOnly) { }
    [System.MonoTODOAttribute]
    public void CheckSignature(System.Security.Cryptography.X509Certificates.X509Certificate2Collection extraStore, bool verifySignatureOnly) { }
    [System.MonoTODOAttribute]
    public void ComputeCounterSignature() { }
    [System.MonoTODOAttribute]
    public void ComputeCounterSignature(System.Security.Cryptography.Pkcs.CmsSigner signer) { }
    [System.MonoTODOAttribute]
    public void RemoveCounterSignature(int index) { }
    [System.MonoTODOAttribute]
    public void RemoveCounterSignature(System.Security.Cryptography.Pkcs.SignerInfo counterSignerInfo) { }
  }
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
  public sealed partial class SignerInfoEnumerator : System.Collections.IEnumerator {
    internal SignerInfoEnumerator() { }
    public System.Security.Cryptography.Pkcs.SignerInfo Current { get { return default(System.Security.Cryptography.Pkcs.SignerInfo); } }
    object System.Collections.IEnumerator.Current { get { return default(object); } }
    public bool MoveNext() { return default(bool); }
    public void Reset() { }
  }
  public sealed partial class SubjectIdentifier {
    internal SubjectIdentifier() { }
    public System.Security.Cryptography.Pkcs.SubjectIdentifierType Type { get { return default(System.Security.Cryptography.Pkcs.SubjectIdentifierType); } }
    public object Value { get { return default(object); } }
  }
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
  public static partial class X509Certificate2UI {
    [System.MonoTODOAttribute]
    public static void DisplayCertificate(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
    [System.MonoTODOAttribute]
    [System.Security.Permissions.UIPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Window=(System.Security.Permissions.UIPermissionWindow)(2))]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, UnmanagedCode=true)]
    public static void DisplayCertificate(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, System.IntPtr hwndParent) { }
    [System.MonoTODOAttribute]
    public static System.Security.Cryptography.X509Certificates.X509Certificate2Collection SelectFromCollection(System.Security.Cryptography.X509Certificates.X509Certificate2Collection certificates, string title, string message, System.Security.Cryptography.X509Certificates.X509SelectionFlag selectionFlag) { return default(System.Security.Cryptography.X509Certificates.X509Certificate2Collection); }
    [System.MonoTODOAttribute]
    [System.Security.Permissions.UIPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Window=(System.Security.Permissions.UIPermissionWindow)(2))]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, UnmanagedCode=true)]
    public static System.Security.Cryptography.X509Certificates.X509Certificate2Collection SelectFromCollection(System.Security.Cryptography.X509Certificates.X509Certificate2Collection certificates, string title, string message, System.Security.Cryptography.X509Certificates.X509SelectionFlag selectionFlag, System.IntPtr hwndParent) { return default(System.Security.Cryptography.X509Certificates.X509Certificate2Collection); }
  }
  public enum X509SelectionFlag {
    MultiSelection = 1,
    SingleSelection = 0,
  }
}
namespace System.Security.Cryptography.Xml {
  public sealed partial class CipherData {
    public CipherData() { }
    public CipherData(System.Byte[] cipherValue) { }
    public CipherData(System.Security.Cryptography.Xml.CipherReference cipherReference) { }
    public System.Security.Cryptography.Xml.CipherReference CipherReference { get { return default(System.Security.Cryptography.Xml.CipherReference); } set { } }
    public System.Byte[] CipherValue { get { return default(System.Byte[]); } set { } }
    public System.Xml.XmlElement GetXml() { return default(System.Xml.XmlElement); }
    public void LoadXml(System.Xml.XmlElement value) { }
  }
  public sealed partial class CipherReference : System.Security.Cryptography.Xml.EncryptedReference {
    public CipherReference() { }
    public CipherReference(string uri) { }
    public CipherReference(string uri, System.Security.Cryptography.Xml.TransformChain tc) { }
    public override System.Xml.XmlElement GetXml() { return default(System.Xml.XmlElement); }
    public override void LoadXml(System.Xml.XmlElement value) { }
  }
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
  public sealed partial class DataReference : System.Security.Cryptography.Xml.EncryptedReference {
    public DataReference() { }
    public DataReference(string uri) { }
    public DataReference(string uri, System.Security.Cryptography.Xml.TransformChain tc) { }
  }
  public partial class DSAKeyValue : System.Security.Cryptography.Xml.KeyInfoClause {
    public DSAKeyValue() { }
    public DSAKeyValue(System.Security.Cryptography.DSA key) { }
    public System.Security.Cryptography.DSA Key { get { return default(System.Security.Cryptography.DSA); } set { } }
    public override System.Xml.XmlElement GetXml() { return default(System.Xml.XmlElement); }
    public override void LoadXml(System.Xml.XmlElement value) { }
  }
  public sealed partial class EncryptedData : System.Security.Cryptography.Xml.EncryptedType {
    public EncryptedData() { }
    public override System.Xml.XmlElement GetXml() { return default(System.Xml.XmlElement); }
    public override void LoadXml(System.Xml.XmlElement value) { }
  }
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
  public abstract partial class EncryptedReference {
    protected EncryptedReference() { }
    protected EncryptedReference(string uri) { }
    protected EncryptedReference(string uri, System.Security.Cryptography.Xml.TransformChain tc) { }
    [System.MonoTODOAttribute("Always returns false")]
    protected internal bool CacheValid { get { return default(bool); } }
    protected string ReferenceType { get { return default(string); } set { } }
    public System.Security.Cryptography.Xml.TransformChain TransformChain { get { return default(System.Security.Cryptography.Xml.TransformChain); } set { } }
    public string Uri { get { return default(string); } set { } }
    public void AddTransform(System.Security.Cryptography.Xml.Transform transform) { }
    public virtual System.Xml.XmlElement GetXml() { return default(System.Xml.XmlElement); }
    [System.MonoTODOAttribute("Make compliant.")]
    public virtual void LoadXml(System.Xml.XmlElement value) { }
  }
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
    [System.MonoTODOAttribute]
    public EncryptedXml() { }
    [System.MonoTODOAttribute]
    public EncryptedXml(System.Xml.XmlDocument document) { }
    [System.MonoTODOAttribute]
    public EncryptedXml(System.Xml.XmlDocument document, System.Security.Policy.Evidence evidence) { }
    public System.Security.Policy.Evidence DocumentEvidence { get { return default(System.Security.Policy.Evidence); } set { } }
    public System.Text.Encoding Encoding { get { return default(System.Text.Encoding); } set { } }
    public System.Security.Cryptography.CipherMode Mode { get { return default(System.Security.Cryptography.CipherMode); } set { } }
    public System.Security.Cryptography.PaddingMode Padding { get { return default(System.Security.Cryptography.PaddingMode); } set { } }
    public string Recipient { get { return default(string); } set { } }
    public System.Xml.XmlResolver Resolver { get { return default(System.Xml.XmlResolver); } set { } }
    public void AddKeyNameMapping(string keyName, object keyObject) { }
    public void ClearKeyNameMappings() { }
    public System.Byte[] DecryptData(System.Security.Cryptography.Xml.EncryptedData encryptedData, System.Security.Cryptography.SymmetricAlgorithm symAlg) { return default(System.Byte[]); }
    public void DecryptDocument() { }
    public virtual System.Byte[] DecryptEncryptedKey(System.Security.Cryptography.Xml.EncryptedKey encryptedKey) { return default(System.Byte[]); }
    [System.MonoTODOAttribute("Test this.")]
    public static System.Byte[] DecryptKey(System.Byte[] keyData, System.Security.Cryptography.RSA rsa, bool fOAEP) { return default(System.Byte[]); }
    public static System.Byte[] DecryptKey(System.Byte[] keyData, System.Security.Cryptography.SymmetricAlgorithm symAlg) { return default(System.Byte[]); }
    [System.MonoTODOAttribute]
    public System.Security.Cryptography.Xml.EncryptedData Encrypt(System.Xml.XmlElement inputElement, System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { return default(System.Security.Cryptography.Xml.EncryptedData); }
    public System.Security.Cryptography.Xml.EncryptedData Encrypt(System.Xml.XmlElement inputElement, string keyName) { return default(System.Security.Cryptography.Xml.EncryptedData); }
    public System.Byte[] EncryptData(System.Byte[] plainText, System.Security.Cryptography.SymmetricAlgorithm symAlg) { return default(System.Byte[]); }
    public System.Byte[] EncryptData(System.Xml.XmlElement inputElement, System.Security.Cryptography.SymmetricAlgorithm symAlg, bool content) { return default(System.Byte[]); }
    [System.MonoTODOAttribute("Test this.")]
    public static System.Byte[] EncryptKey(System.Byte[] keyData, System.Security.Cryptography.RSA rsa, bool fOAEP) { return default(System.Byte[]); }
    public static System.Byte[] EncryptKey(System.Byte[] keyData, System.Security.Cryptography.SymmetricAlgorithm symAlg) { return default(System.Byte[]); }
    public virtual System.Byte[] GetDecryptionIV(System.Security.Cryptography.Xml.EncryptedData encryptedData, string symAlgUri) { return default(System.Byte[]); }
    public virtual System.Security.Cryptography.SymmetricAlgorithm GetDecryptionKey(System.Security.Cryptography.Xml.EncryptedData encryptedData, string symAlgUri) { return default(System.Security.Cryptography.SymmetricAlgorithm); }
    public virtual System.Xml.XmlElement GetIdElement(System.Xml.XmlDocument document, string idValue) { return default(System.Xml.XmlElement); }
    public void ReplaceData(System.Xml.XmlElement inputElement, System.Byte[] decryptedData) { }
    public static void ReplaceElement(System.Xml.XmlElement inputElement, System.Security.Cryptography.Xml.EncryptedData encryptedData, bool content) { }
  }
  public partial class EncryptionMethod {
    public EncryptionMethod() { }
    public EncryptionMethod(string strAlgorithm) { }
    public string KeyAlgorithm { get { return default(string); } set { } }
    public int KeySize { get { return default(int); } set { } }
    public System.Xml.XmlElement GetXml() { return default(System.Xml.XmlElement); }
    public void LoadXml(System.Xml.XmlElement value) { }
  }
  public sealed partial class EncryptionProperty {
    public EncryptionProperty() { }
    public EncryptionProperty(System.Xml.XmlElement elemProp) { }
    public string Id { get { return default(string); } }
    [System.MonoTODOAttribute("Always returns null")]
    public System.Xml.XmlElement PropertyElement { get { return default(System.Xml.XmlElement); } set { } }
    public string Target { get { return default(string); } }
    public System.Xml.XmlElement GetXml() { return default(System.Xml.XmlElement); }
    public void LoadXml(System.Xml.XmlElement value) { }
  }
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
  public abstract partial class KeyInfoClause {
    protected KeyInfoClause() { }
    public abstract System.Xml.XmlElement GetXml();
    public abstract void LoadXml(System.Xml.XmlElement element);
  }
  public partial class KeyInfoEncryptedKey : System.Security.Cryptography.Xml.KeyInfoClause {
    public KeyInfoEncryptedKey() { }
    public KeyInfoEncryptedKey(System.Security.Cryptography.Xml.EncryptedKey ek) { }
    public System.Security.Cryptography.Xml.EncryptedKey EncryptedKey { get { return default(System.Security.Cryptography.Xml.EncryptedKey); } set { } }
    public override System.Xml.XmlElement GetXml() { return default(System.Xml.XmlElement); }
    public override void LoadXml(System.Xml.XmlElement value) { }
  }
  public partial class KeyInfoName : System.Security.Cryptography.Xml.KeyInfoClause {
    public KeyInfoName() { }
    public KeyInfoName(string keyName) { }
    public string Value { get { return default(string); } set { } }
    public override System.Xml.XmlElement GetXml() { return default(System.Xml.XmlElement); }
    public override void LoadXml(System.Xml.XmlElement value) { }
  }
  public partial class KeyInfoNode : System.Security.Cryptography.Xml.KeyInfoClause {
    public KeyInfoNode() { }
    public KeyInfoNode(System.Xml.XmlElement node) { }
    public System.Xml.XmlElement Value { get { return default(System.Xml.XmlElement); } set { } }
    public override System.Xml.XmlElement GetXml() { return default(System.Xml.XmlElement); }
    public override void LoadXml(System.Xml.XmlElement value) { }
  }
  public partial class KeyInfoRetrievalMethod : System.Security.Cryptography.Xml.KeyInfoClause {
    public KeyInfoRetrievalMethod() { }
    public KeyInfoRetrievalMethod(string strUri) { }
    public KeyInfoRetrievalMethod(string strUri, string strType) { }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public string Type { get { return default(string); } set { } }
    public string Uri { get { return default(string); } set { } }
    public override System.Xml.XmlElement GetXml() { return default(System.Xml.XmlElement); }
    public override void LoadXml(System.Xml.XmlElement value) { }
  }
  public partial class KeyInfoX509Data : System.Security.Cryptography.Xml.KeyInfoClause {
    public KeyInfoX509Data() { }
    public KeyInfoX509Data(System.Byte[] rgbCert) { }
    public KeyInfoX509Data(System.Security.Cryptography.X509Certificates.X509Certificate cert) { }
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
  public sealed partial class KeyReference : System.Security.Cryptography.Xml.EncryptedReference {
    public KeyReference() { }
    public KeyReference(string uri) { }
    public KeyReference(string uri, System.Security.Cryptography.Xml.TransformChain tc) { }
  }
  public partial class Reference {
    public Reference() { }
    [System.MonoTODOAttribute("There is no description about how it is used.")]
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
  public partial class RSAKeyValue : System.Security.Cryptography.Xml.KeyInfoClause {
    public RSAKeyValue() { }
    public RSAKeyValue(System.Security.Cryptography.RSA key) { }
    public System.Security.Cryptography.RSA Key { get { return default(System.Security.Cryptography.RSA); } set { } }
    public override System.Xml.XmlElement GetXml() { return default(System.Xml.XmlElement); }
    public override void LoadXml(System.Xml.XmlElement value) { }
  }
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
  public partial class SignedInfo : System.Collections.ICollection, System.Collections.IEnumerable {
    public SignedInfo() { }
    public string CanonicalizationMethod { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
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
    public const string XmlDsigSHA1Url = "http://www.w3.org/2000/09/xmldsig#sha1";
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
    public System.Security.Cryptography.Xml.Signature Signature { get { return default(System.Security.Cryptography.Xml.Signature); } }
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
    [System.MonoTODOAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public bool CheckSignature(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, bool verifySignatureOnly) { return default(bool); }
    public bool CheckSignatureReturningKey(out System.Security.Cryptography.AsymmetricAlgorithm signingKey) { signingKey = default(System.Security.Cryptography.AsymmetricAlgorithm); return default(bool); }
    public void ComputeSignature() { }
    public void ComputeSignature(System.Security.Cryptography.KeyedHashAlgorithm macAlg) { }
    public virtual System.Xml.XmlElement GetIdElement(System.Xml.XmlDocument document, string idValue) { return default(System.Xml.XmlElement); }
    protected virtual System.Security.Cryptography.AsymmetricAlgorithm GetPublicKey() { return default(System.Security.Cryptography.AsymmetricAlgorithm); }
    public System.Xml.XmlElement GetXml() { return default(System.Xml.XmlElement); }
    public void LoadXml(System.Xml.XmlElement value) { }
  }
  public abstract partial class Transform {
    protected Transform() { }
    public string Algorithm { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
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
  public partial class TransformChain {
    public TransformChain() { }
    public int Count { get { return default(int); } }
    public System.Security.Cryptography.Xml.Transform this[int index] { get { return default(System.Security.Cryptography.Xml.Transform); } }
    public void Add(System.Security.Cryptography.Xml.Transform transform) { }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct X509IssuerSerial {
    public string IssuerName { get { return default(string); } set { } }
    public string SerialNumber { get { return default(string); } set { } }
  }
  public partial class XmlDecryptionTransform : System.Security.Cryptography.Xml.Transform {
    public XmlDecryptionTransform() { }
    public System.Security.Cryptography.Xml.EncryptedXml EncryptedXml { get { return default(System.Security.Cryptography.Xml.EncryptedXml); } set { } }
    public override System.Type[] InputTypes { get { return default(System.Type[]); } }
    public override System.Type[] OutputTypes { get { return default(System.Type[]); } }
    public void AddExceptUri(string uri) { }
    [System.MonoTODOAttribute("Verify")]
    protected override System.Xml.XmlNodeList GetInnerXml() { return default(System.Xml.XmlNodeList); }
    [System.MonoTODOAttribute("Verify processing of ExceptURIs")]
    public override object GetOutput() { return default(object); }
    public override object GetOutput(System.Type type) { return default(object); }
    [System.MonoTODOAttribute("verify")]
    protected virtual bool IsTargetElement(System.Xml.XmlElement inputElement, string idValue) { return default(bool); }
    [System.MonoTODOAttribute("This doesn't seem to work in .NET")]
    public override void LoadInnerXml(System.Xml.XmlNodeList nodeList) { }
    public override void LoadInput(object obj) { }
  }
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
  public partial class XmlDsigC14NWithCommentsTransform : System.Security.Cryptography.Xml.XmlDsigC14NTransform {
    public XmlDsigC14NWithCommentsTransform() { }
  }
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
  public partial class XmlDsigExcC14NWithCommentsTransform : System.Security.Cryptography.Xml.XmlDsigExcC14NTransform {
    public XmlDsigExcC14NWithCommentsTransform() { }
    public XmlDsigExcC14NWithCommentsTransform(string inclusiveNamespacesPrefixList) { }
  }
  public partial class XmlDsigXPathTransform : System.Security.Cryptography.Xml.Transform {
    public XmlDsigXPathTransform() { }
    public override System.Type[] InputTypes { get { return default(System.Type[]); } }
    public override System.Type[] OutputTypes { get { return default(System.Type[]); } }
    protected override System.Xml.XmlNodeList GetInnerXml() { return default(System.Xml.XmlNodeList); }
    [System.MonoTODOAttribute("Evaluation of extension function here() results in different from MS.NET (is MS.NET really correct??).")]
    public override object GetOutput() { return default(object); }
    public override object GetOutput(System.Type type) { return default(object); }
    public override void LoadInnerXml(System.Xml.XmlNodeList nodeList) { }
    public override void LoadInput(object obj) { }
  }
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
  public partial class XmlLicenseTransform : System.Security.Cryptography.Xml.Transform {
    public XmlLicenseTransform() { }
    public System.Security.Cryptography.Xml.IRelDecryptor Decryptor { get { return default(System.Security.Cryptography.Xml.IRelDecryptor); } set { } }
    public override System.Type[] InputTypes { get { return default(System.Type[]); } }
    public override System.Type[] OutputTypes { get { return default(System.Type[]); } }
    [System.MonoTODOAttribute]
    protected override System.Xml.XmlNodeList GetInnerXml() { return default(System.Xml.XmlNodeList); }
    [System.MonoTODOAttribute]
    public override object GetOutput() { return default(object); }
    public override object GetOutput(System.Type type) { return default(object); }
    public override void LoadInnerXml(System.Xml.XmlNodeList nodeList) { }
    [System.MonoTODOAttribute]
    public override void LoadInput(object obj) { }
  }
}
namespace System.Security.Permissions {
  public sealed partial class DataProtectionPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission {
    public DataProtectionPermission(System.Security.Permissions.DataProtectionPermissionFlags flags) { }
    public DataProtectionPermission(System.Security.Permissions.PermissionState state) { }
    public System.Security.Permissions.DataProtectionPermissionFlags Flags { get { return default(System.Security.Permissions.DataProtectionPermissionFlags); } set { } }
    public override System.Security.IPermission Copy() { return default(System.Security.IPermission); }
    public override void FromXml(System.Security.SecurityElement e) { }
    public override System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
    public override bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
    public bool IsUnrestricted() { return default(bool); }
    public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
    public override System.Security.IPermission Union(System.Security.IPermission target) { return default(System.Security.IPermission); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
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
