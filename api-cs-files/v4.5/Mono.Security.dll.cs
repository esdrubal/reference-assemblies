namespace Mono.Math {
  public partial class BigInteger {
    public BigInteger() { }
    public BigInteger(Mono.Math.BigInteger bi) { }
    [System.CLSCompliantAttribute(false)]
    public BigInteger(Mono.Math.BigInteger bi, uint len) { }
    [System.CLSCompliantAttribute(false)]
    public BigInteger(Mono.Math.BigInteger.Sign sign, uint len) { }
    public BigInteger(System.Byte[] inData) { }
    [System.CLSCompliantAttribute(false)]
    public BigInteger(uint ui) { }
    [System.CLSCompliantAttribute(false)]
    public BigInteger(System.UInt32[] inData) { }
    [System.CLSCompliantAttribute(false)]
    public BigInteger(ulong ul) { }
    public static Mono.Math.BigInteger Add(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2) { return default(Mono.Math.BigInteger); }
    public int BitCount() { return default(int); }
    public void Clear() { }
    [System.CLSCompliantAttribute(false)]
    public void ClearBit(uint bitNum) { }
    public Mono.Math.BigInteger.Sign Compare(Mono.Math.BigInteger bi) { return default(Mono.Math.BigInteger.Sign); }
    public static Mono.Math.BigInteger Divid(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2) { return default(Mono.Math.BigInteger); }
    public static Mono.Math.BigInteger Divid(Mono.Math.BigInteger bi, int i) { return default(Mono.Math.BigInteger); }
    public override bool Equals(object o) { return default(bool); }
    public Mono.Math.BigInteger GCD(Mono.Math.BigInteger bi) { return default(Mono.Math.BigInteger); }
    public static Mono.Math.BigInteger GeneratePseudoPrime(int bits) { return default(Mono.Math.BigInteger); }
    public static Mono.Math.BigInteger GenerateRandom(int bits) { return default(Mono.Math.BigInteger); }
    public static Mono.Math.BigInteger GenerateRandom(int bits, System.Security.Cryptography.RandomNumberGenerator rng) { return default(Mono.Math.BigInteger); }
    public System.Byte[] GetBytes() { return default(System.Byte[]); }
    public override int GetHashCode() { return default(int); }
    public void Incr2() { }
    public bool IsProbablePrime() { return default(bool); }
    public int LowestSetBit() { return default(int); }
    public Mono.Math.BigInteger ModInverse(Mono.Math.BigInteger modulus) { return default(Mono.Math.BigInteger); }
    public Mono.Math.BigInteger ModPow(Mono.Math.BigInteger exp, Mono.Math.BigInteger n) { return default(Mono.Math.BigInteger); }
    public static Mono.Math.BigInteger Modulus(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2) { return default(Mono.Math.BigInteger); }
    public static int Modulus(Mono.Math.BigInteger bi, int i) { return default(int); }
    [System.CLSCompliantAttribute(false)]
    public static uint Modulus(Mono.Math.BigInteger bi, uint ui) { return default(uint); }
    public static Mono.Math.BigInteger Multiply(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2) { return default(Mono.Math.BigInteger); }
    public static Mono.Math.BigInteger Multiply(Mono.Math.BigInteger bi, int i) { return default(Mono.Math.BigInteger); }
    public static Mono.Math.BigInteger NextHighestPrime(Mono.Math.BigInteger bi) { return default(Mono.Math.BigInteger); }
    public static Mono.Math.BigInteger operator +(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2) { return default(Mono.Math.BigInteger); }
    public static Mono.Math.BigInteger operator /(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2) { return default(Mono.Math.BigInteger); }
    public static Mono.Math.BigInteger operator /(Mono.Math.BigInteger bi, int i) { return default(Mono.Math.BigInteger); }
    public static bool operator ==(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2) { return default(bool); }
    [System.CLSCompliantAttribute(false)]
    public static bool operator ==(Mono.Math.BigInteger bi1, uint ui) { return default(bool); }
    public static bool operator >(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2) { return default(bool); }
    public static bool operator >=(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2) { return default(bool); }
    public static implicit operator Mono.Math.BigInteger (int value) { return default(Mono.Math.BigInteger); }
    [System.CLSCompliantAttribute(false)]
    public static implicit operator Mono.Math.BigInteger (uint value) { return default(Mono.Math.BigInteger); }
    [System.CLSCompliantAttribute(false)]
    public static implicit operator Mono.Math.BigInteger (ulong value) { return default(Mono.Math.BigInteger); }
    public static bool operator !=(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2) { return default(bool); }
    [System.CLSCompliantAttribute(false)]
    public static bool operator !=(Mono.Math.BigInteger bi1, uint ui) { return default(bool); }
    public static Mono.Math.BigInteger operator <<(Mono.Math.BigInteger bi1, int shiftVal) { return default(Mono.Math.BigInteger); }
    public static bool operator <(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2) { return default(bool); }
    public static bool operator <=(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2) { return default(bool); }
    public static Mono.Math.BigInteger operator %(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2) { return default(Mono.Math.BigInteger); }
    public static int operator %(Mono.Math.BigInteger bi, int i) { return default(int); }
    [System.CLSCompliantAttribute(false)]
    public static uint operator %(Mono.Math.BigInteger bi, uint ui) { return default(uint); }
    public static Mono.Math.BigInteger operator *(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2) { return default(Mono.Math.BigInteger); }
    public static Mono.Math.BigInteger operator *(Mono.Math.BigInteger bi, int i) { return default(Mono.Math.BigInteger); }
    public static Mono.Math.BigInteger operator >>(Mono.Math.BigInteger bi1, int shiftVal) { return default(Mono.Math.BigInteger); }
    public static Mono.Math.BigInteger operator -(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2) { return default(Mono.Math.BigInteger); }
    public static Mono.Math.BigInteger Parse(string number) { return default(Mono.Math.BigInteger); }
    public void Randomize() { }
    public void Randomize(System.Security.Cryptography.RandomNumberGenerator rng) { }
    [System.CLSCompliantAttribute(false)]
    public void SetBit(uint bitNum) { }
    [System.CLSCompliantAttribute(false)]
    public void SetBit(uint bitNum, bool value) { }
    public static Mono.Math.BigInteger Subtract(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2) { return default(Mono.Math.BigInteger); }
    public bool TestBit(int bitNum) { return default(bool); }
    [System.CLSCompliantAttribute(false)]
    public bool TestBit(uint bitNum) { return default(bool); }
    public override string ToString() { return default(string); }
    [System.CLSCompliantAttribute(false)]
    public string ToString(uint radix) { return default(string); }
    [System.CLSCompliantAttribute(false)]
    public string ToString(uint radix, string characterSet) { return default(string); }
    public sealed partial class ModulusRing {
      public ModulusRing(Mono.Math.BigInteger modulus) { }
      public void BarrettReduction(Mono.Math.BigInteger x) { }
      public Mono.Math.BigInteger Difference(Mono.Math.BigInteger a, Mono.Math.BigInteger b) { return default(Mono.Math.BigInteger); }
      public Mono.Math.BigInteger Multiply(Mono.Math.BigInteger a, Mono.Math.BigInteger b) { return default(Mono.Math.BigInteger); }
      public Mono.Math.BigInteger Pow(Mono.Math.BigInteger a, Mono.Math.BigInteger k) { return default(Mono.Math.BigInteger); }
      [System.CLSCompliantAttribute(false)]
      public Mono.Math.BigInteger Pow(uint b, Mono.Math.BigInteger exp) { return default(Mono.Math.BigInteger); }
    }
    public enum Sign {
      Negative = -1,
      Positive = 1,
      Zero = 0,
    }
  }
}
namespace Mono.Math.Prime {
  public enum ConfidenceFactor {
    ExtraHigh = 4,
    ExtraLow = 0,
    High = 3,
    Low = 1,
    Medium = 2,
    Provable = 5,
  }
  public delegate bool PrimalityTest(Mono.Math.BigInteger bi, Mono.Math.Prime.ConfidenceFactor confidence);
  public sealed partial class PrimalityTests {
    internal PrimalityTests() { }
    public static bool RabinMillerTest(Mono.Math.BigInteger n, Mono.Math.Prime.ConfidenceFactor confidence) { return default(bool); }
    public static bool SmallPrimeSppTest(Mono.Math.BigInteger bi, Mono.Math.Prime.ConfidenceFactor confidence) { return default(bool); }
    public static bool Test(Mono.Math.BigInteger n, Mono.Math.Prime.ConfidenceFactor confidence) { return default(bool); }
  }
}
namespace Mono.Math.Prime.Generator {
  public partial class NextPrimeFinder : Mono.Math.Prime.Generator.SequentialSearchPrimeGeneratorBase {
    public NextPrimeFinder() { }
    protected override Mono.Math.BigInteger GenerateSearchBase(int bits, object Context) { return default(Mono.Math.BigInteger); }
  }
  public abstract partial class PrimeGeneratorBase {
    protected PrimeGeneratorBase() { }
    public virtual Mono.Math.Prime.ConfidenceFactor Confidence { get { return default(Mono.Math.Prime.ConfidenceFactor); } }
    public virtual Mono.Math.Prime.PrimalityTest PrimalityTest { get { return default(Mono.Math.Prime.PrimalityTest); } }
    public virtual int TrialDivisionBounds { get { return default(int); } }
    public abstract Mono.Math.BigInteger GenerateNewPrime(int bits);
    protected bool PostTrialDivisionTests(Mono.Math.BigInteger bi) { return default(bool); }
  }
  public partial class SequentialSearchPrimeGeneratorBase : Mono.Math.Prime.Generator.PrimeGeneratorBase {
    public SequentialSearchPrimeGeneratorBase() { }
    public override Mono.Math.BigInteger GenerateNewPrime(int bits) { return default(Mono.Math.BigInteger); }
    public virtual Mono.Math.BigInteger GenerateNewPrime(int bits, object context) { return default(Mono.Math.BigInteger); }
    protected virtual Mono.Math.BigInteger GenerateSearchBase(int bits, object context) { return default(Mono.Math.BigInteger); }
    protected virtual bool IsPrimeAcceptable(Mono.Math.BigInteger bi, object context) { return default(bool); }
  }
}
namespace Mono.Security {
  public partial class ASN1 {
    public ASN1() { }
    public ASN1(byte tag) { }
    public ASN1(byte tag, System.Byte[] data) { }
    public ASN1(System.Byte[] data) { }
    public int Count { get { return default(int); } }
    public Mono.Security.ASN1 this[int index] { get { return default(Mono.Security.ASN1); } }
    public int Length { get { return default(int); } }
    public byte Tag { get { return default(byte); } }
    public System.Byte[] Value { get { return default(System.Byte[]); } set { } }
    public Mono.Security.ASN1 Add(Mono.Security.ASN1 asn1) { return default(Mono.Security.ASN1); }
    public bool CompareValue(System.Byte[] value) { return default(bool); }
    protected void Decode(System.Byte[] asn1, ref int anPos, int anLength) { }
    protected void DecodeTLV(System.Byte[] asn1, ref int pos, out byte tag, out int length, out System.Byte[] content) { tag = default(byte); length = default(int); content = default(System.Byte[]); }
    public Mono.Security.ASN1 Element(int index, byte anTag) { return default(Mono.Security.ASN1); }
    public bool Equals(System.Byte[] asn1) { return default(bool); }
    public virtual System.Byte[] GetBytes() { return default(System.Byte[]); }
    public void SaveToFile(string filename) { }
    public override string ToString() { return default(string); }
  }
  public static partial class ASN1Convert {
    public static Mono.Security.ASN1 FromDateTime(System.DateTime dt) { return default(Mono.Security.ASN1); }
    public static Mono.Security.ASN1 FromInt32(int value) { return default(Mono.Security.ASN1); }
    public static Mono.Security.ASN1 FromOid(string oid) { return default(Mono.Security.ASN1); }
    public static Mono.Security.ASN1 FromUnsignedBigInteger(System.Byte[] big) { return default(Mono.Security.ASN1); }
    public static System.DateTime ToDateTime(Mono.Security.ASN1 time) { return default(System.DateTime); }
    public static int ToInt32(Mono.Security.ASN1 asn1) { return default(int); }
    public static string ToOid(Mono.Security.ASN1 asn1) { return default(string); }
  }
  public sealed partial class PKCS7 {
    internal PKCS7() { }
    public static Mono.Security.ASN1 AlgorithmIdentifier(string oid) { return default(Mono.Security.ASN1); }
    public static Mono.Security.ASN1 AlgorithmIdentifier(string oid, Mono.Security.ASN1 parameters) { return default(Mono.Security.ASN1); }
    public static Mono.Security.ASN1 Attribute(string oid, Mono.Security.ASN1 value) { return default(Mono.Security.ASN1); }
    public static Mono.Security.ASN1 IssuerAndSerialNumber(Mono.Security.X509.X509Certificate x509) { return default(Mono.Security.ASN1); }
    public partial class ContentInfo {
      public ContentInfo() { }
      public ContentInfo(Mono.Security.ASN1 asn1) { }
      public ContentInfo(System.Byte[] data) { }
      public ContentInfo(string oid) { }
      public Mono.Security.ASN1 ASN1 { get { return default(Mono.Security.ASN1); } }
      public Mono.Security.ASN1 Content { get { return default(Mono.Security.ASN1); } set { } }
      public string ContentType { get { return default(string); } set { } }
      public System.Byte[] GetBytes() { return default(System.Byte[]); }
    }
    public partial class EncryptedData {
      public EncryptedData() { }
      public EncryptedData(Mono.Security.ASN1 asn1) { }
      public EncryptedData(System.Byte[] data) { }
      public Mono.Security.ASN1 ASN1 { get { return default(Mono.Security.ASN1); } }
      public Mono.Security.PKCS7.ContentInfo ContentInfo { get { return default(Mono.Security.PKCS7.ContentInfo); } }
      public System.Byte[] EncryptedContent { get { return default(System.Byte[]); } }
      public Mono.Security.PKCS7.ContentInfo EncryptionAlgorithm { get { return default(Mono.Security.PKCS7.ContentInfo); } }
      public byte Version { get { return default(byte); } set { } }
      public System.Byte[] GetBytes() { return default(System.Byte[]); }
    }
    public partial class EnvelopedData {
      public EnvelopedData() { }
      public EnvelopedData(Mono.Security.ASN1 asn1) { }
      public EnvelopedData(System.Byte[] data) { }
      public Mono.Security.ASN1 ASN1 { get { return default(Mono.Security.ASN1); } }
      public Mono.Security.PKCS7.ContentInfo ContentInfo { get { return default(Mono.Security.PKCS7.ContentInfo); } }
      public System.Byte[] EncryptedContent { get { return default(System.Byte[]); } }
      public Mono.Security.PKCS7.ContentInfo EncryptionAlgorithm { get { return default(Mono.Security.PKCS7.ContentInfo); } }
      public System.Collections.ArrayList RecipientInfos { get { return default(System.Collections.ArrayList); } }
      public byte Version { get { return default(byte); } set { } }
      public System.Byte[] GetBytes() { return default(System.Byte[]); }
    }
    public partial class Oid {
      public const string contentType = "1.2.840.113549.1.9.3";
      public const string countersignature = "1.2.840.113549.1.9.6";
      public const string data = "1.2.840.113549.1.7.1";
      public const string digestedData = "1.2.840.113549.1.7.5";
      public const string encryptedData = "1.2.840.113549.1.7.6";
      public const string envelopedData = "1.2.840.113549.1.7.3";
      public const string messageDigest = "1.2.840.113549.1.9.4";
      public const string rsaEncryption = "1.2.840.113549.1.1.1";
      public const string signedAndEnvelopedData = "1.2.840.113549.1.7.4";
      public const string signedData = "1.2.840.113549.1.7.2";
      public const string signingTime = "1.2.840.113549.1.9.5";
      public Oid() { }
    }
    public partial class RecipientInfo {
      public RecipientInfo() { }
      public RecipientInfo(Mono.Security.ASN1 data) { }
      public string Issuer { get { return default(string); } }
      public System.Byte[] Key { get { return default(System.Byte[]); } }
      public string Oid { get { return default(string); } }
      public System.Byte[] Serial { get { return default(System.Byte[]); } }
      public System.Byte[] SubjectKeyIdentifier { get { return default(System.Byte[]); } }
      public int Version { get { return default(int); } }
    }
    public partial class SignedData {
      public SignedData() { }
      public SignedData(Mono.Security.ASN1 asn1) { }
      public SignedData(System.Byte[] data) { }
      public Mono.Security.ASN1 ASN1 { get { return default(Mono.Security.ASN1); } }
      public Mono.Security.X509.X509CertificateCollection Certificates { get { return default(Mono.Security.X509.X509CertificateCollection); } }
      public Mono.Security.PKCS7.ContentInfo ContentInfo { get { return default(Mono.Security.PKCS7.ContentInfo); } }
      public System.Collections.ArrayList Crls { get { return default(System.Collections.ArrayList); } }
      public string HashName { get { return default(string); } set { } }
      public Mono.Security.PKCS7.SignerInfo SignerInfo { get { return default(Mono.Security.PKCS7.SignerInfo); } }
      public bool UseAuthenticatedAttributes { get { return default(bool); } set { } }
      public byte Version { get { return default(byte); } set { } }
      public System.Byte[] GetBytes() { return default(System.Byte[]); }
      public bool VerifySignature(System.Security.Cryptography.AsymmetricAlgorithm aa) { return default(bool); }
    }
    public partial class SignerInfo {
      public SignerInfo() { }
      public SignerInfo(Mono.Security.ASN1 asn1) { }
      public SignerInfo(System.Byte[] data) { }
      public Mono.Security.ASN1 ASN1 { get { return default(Mono.Security.ASN1); } }
      public System.Collections.ArrayList AuthenticatedAttributes { get { return default(System.Collections.ArrayList); } }
      public Mono.Security.X509.X509Certificate Certificate { get { return default(Mono.Security.X509.X509Certificate); } set { } }
      public string HashName { get { return default(string); } set { } }
      public string IssuerName { get { return default(string); } }
      public System.Security.Cryptography.AsymmetricAlgorithm Key { get { return default(System.Security.Cryptography.AsymmetricAlgorithm); } set { } }
      public System.Byte[] SerialNumber { get { return default(System.Byte[]); } }
      public System.Byte[] Signature { get { return default(System.Byte[]); } set { } }
      public System.Byte[] SubjectKeyIdentifier { get { return default(System.Byte[]); } }
      public System.Collections.ArrayList UnauthenticatedAttributes { get { return default(System.Collections.ArrayList); } }
      public byte Version { get { return default(byte); } set { } }
      public System.Byte[] GetBytes() { return default(System.Byte[]); }
    }
  }
  public sealed partial class StrongName {
    public StrongName() { }
    public StrongName(System.Byte[] data) { }
    public StrongName(int keySize) { }
    public StrongName(System.Security.Cryptography.RSA rsa) { }
    public bool CanSign { get { return default(bool); } }
    public System.Byte[] PublicKey { get { return default(System.Byte[]); } }
    public System.Byte[] PublicKeyToken { get { return default(System.Byte[]); } }
    public System.Security.Cryptography.RSA RSA { get { return default(System.Security.Cryptography.RSA); } set { } }
    public string TokenAlgorithm { get { return default(string); } set { } }
    public System.Byte[] GetBytes() { return default(System.Byte[]); }
    public System.Byte[] Hash(string fileName) { return default(System.Byte[]); }
    public bool Sign(string fileName) { return default(bool); }
    public bool Verify(System.IO.Stream stream) { return default(bool); }
    public bool Verify(string fileName) { return default(bool); }
  }
}
namespace Mono.Security.Authenticode {
  public partial class AuthenticodeBase {
    public const string spcIndirectDataContext = "1.3.6.1.4.1.311.2.1.4";
    public AuthenticodeBase() { }
    protected System.Byte[] HashFile(string fileName, string hashName) { return default(System.Byte[]); }
  }
  public partial class AuthenticodeDeformatter : Mono.Security.Authenticode.AuthenticodeBase {
    public AuthenticodeDeformatter() { }
    public AuthenticodeDeformatter(string fileName) { }
    public Mono.Security.X509.X509CertificateCollection Certificates { get { return default(Mono.Security.X509.X509CertificateCollection); } }
    public string FileName { get { return default(string); } set { } }
    public System.Byte[] Hash { get { return default(System.Byte[]); } }
    public int Reason { get { return default(int); } }
    public System.Byte[] Signature { get { return default(System.Byte[]); } }
    public Mono.Security.X509.X509Certificate SigningCertificate { get { return default(Mono.Security.X509.X509Certificate); } }
    public System.DateTime Timestamp { get { return default(System.DateTime); } }
    public bool IsTrusted() { return default(bool); }
  }
  public partial class AuthenticodeFormatter : Mono.Security.Authenticode.AuthenticodeBase {
    public AuthenticodeFormatter() { }
    public Mono.Security.Authenticode.Authority Authority { get { return default(Mono.Security.Authenticode.Authority); } set { } }
    public Mono.Security.X509.X509CertificateCollection Certificates { get { return default(Mono.Security.X509.X509CertificateCollection); } }
    public System.Collections.ArrayList Crl { get { return default(System.Collections.ArrayList); } }
    public string Description { get { return default(string); } set { } }
    public string Hash { get { return default(string); } set { } }
    public System.Security.Cryptography.RSA RSA { get { return default(System.Security.Cryptography.RSA); } set { } }
    public System.Uri TimestampUrl { get { return default(System.Uri); } set { } }
    public System.Uri Url { get { return default(System.Uri); } set { } }
    public void ProcessTimestamp(System.Byte[] response) { }
    public bool Sign(string fileName) { return default(bool); }
    public bool Timestamp(string fileName) { return default(bool); }
    public Mono.Security.ASN1 TimestampRequest(System.Byte[] signature) { return default(Mono.Security.ASN1); }
  }
  public enum Authority {
    Commercial = 1,
    Individual = 0,
    Maximum = 2,
  }
  public partial class PrivateKey {
    public PrivateKey() { }
    public PrivateKey(System.Byte[] data, string password) { }
    public bool Encrypted { get { return default(bool); } }
    public int KeyType { get { return default(int); } set { } }
    public System.Security.Cryptography.RSA RSA { get { return default(System.Security.Cryptography.RSA); } set { } }
    public bool Weak { get { return default(bool); } set { } }
    public static Mono.Security.Authenticode.PrivateKey CreateFromFile(string filename) { return default(Mono.Security.Authenticode.PrivateKey); }
    public static Mono.Security.Authenticode.PrivateKey CreateFromFile(string filename, string password) { return default(Mono.Security.Authenticode.PrivateKey); }
    public void Save(string filename) { }
    public void Save(string filename, string password) { }
  }
  public partial class SoftwarePublisherCertificate {
    public SoftwarePublisherCertificate() { }
    public SoftwarePublisherCertificate(System.Byte[] data) { }
    public Mono.Security.X509.X509CertificateCollection Certificates { get { return default(Mono.Security.X509.X509CertificateCollection); } }
    public System.Collections.ArrayList Crls { get { return default(System.Collections.ArrayList); } }
    public static Mono.Security.Authenticode.SoftwarePublisherCertificate CreateFromFile(string filename) { return default(Mono.Security.Authenticode.SoftwarePublisherCertificate); }
    public System.Byte[] GetBytes() { return default(System.Byte[]); }
  }
}
namespace Mono.Security.Cryptography {
  public partial class ARC4Managed : Mono.Security.Cryptography.RC4, System.IDisposable, System.Security.Cryptography.ICryptoTransform {
    public ARC4Managed() { }
    public bool CanReuseTransform { get { return default(bool); } }
    public bool CanTransformMultipleBlocks { get { return default(bool); } }
    public int InputBlockSize { get { return default(int); } }
    public override System.Byte[] Key { get { return default(System.Byte[]); } set { } }
    public int OutputBlockSize { get { return default(int); } }
    public override System.Security.Cryptography.ICryptoTransform CreateDecryptor(System.Byte[] rgbKey, System.Byte[] rgvIV) { return default(System.Security.Cryptography.ICryptoTransform); }
    public override System.Security.Cryptography.ICryptoTransform CreateEncryptor(System.Byte[] rgbKey, System.Byte[] rgvIV) { return default(System.Security.Cryptography.ICryptoTransform); }
    protected override void Dispose(bool disposing) { }
    ~ARC4Managed() { }
    public override void GenerateIV() { }
    public override void GenerateKey() { }
    public int TransformBlock(System.Byte[] inputBuffer, int inputOffset, int inputCount, System.Byte[] outputBuffer, int outputOffset) { return default(int); }
    public System.Byte[] TransformFinalBlock(System.Byte[] inputBuffer, int inputOffset, int inputCount) { return default(System.Byte[]); }
  }
  public partial class BlockProcessor {
    public BlockProcessor(System.Security.Cryptography.ICryptoTransform transform) { }
    public BlockProcessor(System.Security.Cryptography.ICryptoTransform transform, int blockSize) { }
    public void Core(System.Byte[] rgb) { }
    public void Core(System.Byte[] rgb, int ib, int cb) { }
    public System.Byte[] Final() { return default(System.Byte[]); }
    ~BlockProcessor() { }
    public void Initialize() { }
  }
  public sealed partial class CryptoConvert {
    internal CryptoConvert() { }
    public static System.Security.Cryptography.RSA FromCapiKeyBlob(System.Byte[] blob) { return default(System.Security.Cryptography.RSA); }
    public static System.Security.Cryptography.RSA FromCapiKeyBlob(System.Byte[] blob, int offset) { return default(System.Security.Cryptography.RSA); }
    public static System.Security.Cryptography.DSA FromCapiKeyBlobDSA(System.Byte[] blob) { return default(System.Security.Cryptography.DSA); }
    public static System.Security.Cryptography.DSA FromCapiKeyBlobDSA(System.Byte[] blob, int offset) { return default(System.Security.Cryptography.DSA); }
    public static System.Security.Cryptography.RSA FromCapiPrivateKeyBlob(System.Byte[] blob) { return default(System.Security.Cryptography.RSA); }
    public static System.Security.Cryptography.RSA FromCapiPrivateKeyBlob(System.Byte[] blob, int offset) { return default(System.Security.Cryptography.RSA); }
    public static System.Security.Cryptography.DSA FromCapiPrivateKeyBlobDSA(System.Byte[] blob) { return default(System.Security.Cryptography.DSA); }
    public static System.Security.Cryptography.DSA FromCapiPrivateKeyBlobDSA(System.Byte[] blob, int offset) { return default(System.Security.Cryptography.DSA); }
    public static System.Security.Cryptography.RSA FromCapiPublicKeyBlob(System.Byte[] blob) { return default(System.Security.Cryptography.RSA); }
    public static System.Security.Cryptography.RSA FromCapiPublicKeyBlob(System.Byte[] blob, int offset) { return default(System.Security.Cryptography.RSA); }
    public static System.Security.Cryptography.DSA FromCapiPublicKeyBlobDSA(System.Byte[] blob) { return default(System.Security.Cryptography.DSA); }
    public static System.Security.Cryptography.DSA FromCapiPublicKeyBlobDSA(System.Byte[] blob, int offset) { return default(System.Security.Cryptography.DSA); }
    public static System.Byte[] FromHex(string hex) { return default(System.Byte[]); }
    public static System.Byte[] ToCapiKeyBlob(System.Security.Cryptography.AsymmetricAlgorithm keypair, bool includePrivateKey) { return default(System.Byte[]); }
    public static System.Byte[] ToCapiKeyBlob(System.Security.Cryptography.DSA dsa, bool includePrivateKey) { return default(System.Byte[]); }
    public static System.Byte[] ToCapiKeyBlob(System.Security.Cryptography.RSA rsa, bool includePrivateKey) { return default(System.Byte[]); }
    public static System.Byte[] ToCapiPrivateKeyBlob(System.Security.Cryptography.DSA dsa) { return default(System.Byte[]); }
    public static System.Byte[] ToCapiPrivateKeyBlob(System.Security.Cryptography.RSA rsa) { return default(System.Byte[]); }
    public static System.Byte[] ToCapiPublicKeyBlob(System.Security.Cryptography.DSA dsa) { return default(System.Byte[]); }
    public static System.Byte[] ToCapiPublicKeyBlob(System.Security.Cryptography.RSA rsa) { return default(System.Byte[]); }
    public static string ToHex(System.Byte[] input) { return default(string); }
  }
  public enum DHKeyGeneration {
    Random = 0,
    Static = 1,
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct DHParameters {
    public System.Byte[] G;
    public System.Byte[] P;
    public System.Byte[] X;
  }
  public abstract partial class DiffieHellman : System.Security.Cryptography.AsymmetricAlgorithm {
    protected DiffieHellman() { }
    public static new Mono.Security.Cryptography.DiffieHellman Create() { return default(Mono.Security.Cryptography.DiffieHellman); }
    public static new Mono.Security.Cryptography.DiffieHellman Create(string algName) { return default(Mono.Security.Cryptography.DiffieHellman); }
    public abstract System.Byte[] CreateKeyExchange();
    public abstract System.Byte[] DecryptKeyExchange(System.Byte[] keyex);
    public abstract Mono.Security.Cryptography.DHParameters ExportParameters(bool includePrivate);
    public override void FromXmlString(string xmlString) { }
    public abstract void ImportParameters(Mono.Security.Cryptography.DHParameters parameters);
    public override string ToXmlString(bool includePrivateParameters) { return default(string); }
  }
  public sealed partial class DiffieHellmanManaged : Mono.Security.Cryptography.DiffieHellman {
    public DiffieHellmanManaged() { }
    public DiffieHellmanManaged(System.Byte[] p, System.Byte[] g, System.Byte[] x) { }
    public DiffieHellmanManaged(System.Byte[] p, System.Byte[] g, int l) { }
    public DiffieHellmanManaged(int bitLength, int l, Mono.Security.Cryptography.DHKeyGeneration method) { }
    public override string KeyExchangeAlgorithm { get { return default(string); } }
    public override string SignatureAlgorithm { get { return default(string); } }
    public override System.Byte[] CreateKeyExchange() { return default(System.Byte[]); }
    public override System.Byte[] DecryptKeyExchange(System.Byte[] keyEx) { return default(System.Byte[]); }
    protected override void Dispose(bool disposing) { }
    public override Mono.Security.Cryptography.DHParameters ExportParameters(bool includePrivateParameters) { return default(Mono.Security.Cryptography.DHParameters); }
    ~DiffieHellmanManaged() { }
    public override void ImportParameters(Mono.Security.Cryptography.DHParameters parameters) { }
  }
  public sealed partial class KeyBuilder {
    internal KeyBuilder() { }
    public static System.Byte[] IV(int size) { return default(System.Byte[]); }
    public static System.Byte[] Key(int size) { return default(System.Byte[]); }
  }
  public partial class KeyPairPersistence {
    public KeyPairPersistence(System.Security.Cryptography.CspParameters parameters) { }
    public KeyPairPersistence(System.Security.Cryptography.CspParameters parameters, string keyPair) { }
    public string Filename { get { return default(string); } }
    public string KeyValue { get { return default(string); } set { } }
    public System.Security.Cryptography.CspParameters Parameters { get { return default(System.Security.Cryptography.CspParameters); } }
    public bool Load() { return default(bool); }
    public void Remove() { }
    public void Save() { }
  }
  public abstract partial class MD2 : System.Security.Cryptography.HashAlgorithm {
    protected MD2() { }
    public static new Mono.Security.Cryptography.MD2 Create() { return default(Mono.Security.Cryptography.MD2); }
    public static new Mono.Security.Cryptography.MD2 Create(string hashName) { return default(Mono.Security.Cryptography.MD2); }
  }
  public partial class MD2Managed : Mono.Security.Cryptography.MD2 {
    public MD2Managed() { }
    protected override void HashCore(System.Byte[] array, int ibStart, int cbSize) { }
    protected override System.Byte[] HashFinal() { return default(System.Byte[]); }
    public override void Initialize() { }
  }
  public abstract partial class MD4 : System.Security.Cryptography.HashAlgorithm {
    protected MD4() { }
    public static new Mono.Security.Cryptography.MD4 Create() { return default(Mono.Security.Cryptography.MD4); }
    public static new Mono.Security.Cryptography.MD4 Create(string hashName) { return default(Mono.Security.Cryptography.MD4); }
  }
  public partial class MD4Managed : Mono.Security.Cryptography.MD4 {
    public MD4Managed() { }
    protected override void HashCore(System.Byte[] array, int ibStart, int cbSize) { }
    protected override System.Byte[] HashFinal() { return default(System.Byte[]); }
    public override void Initialize() { }
  }
  public sealed partial class PKCS1 {
    internal PKCS1() { }
    public static System.Byte[] Decrypt_OAEP(System.Security.Cryptography.RSA rsa, System.Security.Cryptography.HashAlgorithm hash, System.Byte[] C) { return default(System.Byte[]); }
    public static System.Byte[] Decrypt_v15(System.Security.Cryptography.RSA rsa, System.Byte[] C) { return default(System.Byte[]); }
    public static System.Byte[] Encode_v15(System.Security.Cryptography.HashAlgorithm hash, System.Byte[] hashValue, int emLength) { return default(System.Byte[]); }
    public static System.Byte[] Encrypt_OAEP(System.Security.Cryptography.RSA rsa, System.Security.Cryptography.HashAlgorithm hash, System.Security.Cryptography.RandomNumberGenerator rng, System.Byte[] M) { return default(System.Byte[]); }
    public static System.Byte[] Encrypt_v15(System.Security.Cryptography.RSA rsa, System.Security.Cryptography.RandomNumberGenerator rng, System.Byte[] M) { return default(System.Byte[]); }
    public static System.Byte[] I2OSP(System.Byte[] x, int size) { return default(System.Byte[]); }
    public static System.Byte[] I2OSP(int x, int size) { return default(System.Byte[]); }
    public static System.Byte[] MGF1(System.Security.Cryptography.HashAlgorithm hash, System.Byte[] mgfSeed, int maskLen) { return default(System.Byte[]); }
    public static System.Byte[] OS2IP(System.Byte[] x) { return default(System.Byte[]); }
    public static System.Byte[] RSADP(System.Security.Cryptography.RSA rsa, System.Byte[] c) { return default(System.Byte[]); }
    public static System.Byte[] RSAEP(System.Security.Cryptography.RSA rsa, System.Byte[] m) { return default(System.Byte[]); }
    public static System.Byte[] RSASP1(System.Security.Cryptography.RSA rsa, System.Byte[] m) { return default(System.Byte[]); }
    public static System.Byte[] RSAVP1(System.Security.Cryptography.RSA rsa, System.Byte[] s) { return default(System.Byte[]); }
    public static System.Byte[] Sign_v15(System.Security.Cryptography.RSA rsa, System.Security.Cryptography.HashAlgorithm hash, System.Byte[] hashValue) { return default(System.Byte[]); }
    public static bool Verify_v15(System.Security.Cryptography.RSA rsa, System.Security.Cryptography.HashAlgorithm hash, System.Byte[] hashValue, System.Byte[] signature) { return default(bool); }
    public static bool Verify_v15(System.Security.Cryptography.RSA rsa, System.Security.Cryptography.HashAlgorithm hash, System.Byte[] hashValue, System.Byte[] signature, bool tryNonStandardEncoding) { return default(bool); }
  }
  public sealed partial class PKCS8 {
    internal PKCS8() { }
    public static Mono.Security.Cryptography.PKCS8.KeyInfo GetType(System.Byte[] data) { return default(Mono.Security.Cryptography.PKCS8.KeyInfo); }
    public partial class EncryptedPrivateKeyInfo {
      public EncryptedPrivateKeyInfo() { }
      public EncryptedPrivateKeyInfo(System.Byte[] data) { }
      public string Algorithm { get { return default(string); } set { } }
      public System.Byte[] EncryptedData { get { return default(System.Byte[]); } set { } }
      public int IterationCount { get { return default(int); } set { } }
      public System.Byte[] Salt { get { return default(System.Byte[]); } set { } }
      public System.Byte[] GetBytes() { return default(System.Byte[]); }
    }
    public enum KeyInfo {
      EncryptedPrivateKey = 1,
      PrivateKey = 0,
      Unknown = 2,
    }
    public partial class PrivateKeyInfo {
      public PrivateKeyInfo() { }
      public PrivateKeyInfo(System.Byte[] data) { }
      public string Algorithm { get { return default(string); } set { } }
      public System.Collections.ArrayList Attributes { get { return default(System.Collections.ArrayList); } }
      public System.Byte[] PrivateKey { get { return default(System.Byte[]); } set { } }
      public int Version { get { return default(int); } set { } }
      public static System.Security.Cryptography.DSA DecodeDSA(System.Byte[] privateKey, System.Security.Cryptography.DSAParameters dsaParameters) { return default(System.Security.Cryptography.DSA); }
      public static System.Security.Cryptography.RSA DecodeRSA(System.Byte[] keypair) { return default(System.Security.Cryptography.RSA); }
      public static System.Byte[] Encode(System.Security.Cryptography.AsymmetricAlgorithm aa) { return default(System.Byte[]); }
      public static System.Byte[] Encode(System.Security.Cryptography.DSA dsa) { return default(System.Byte[]); }
      public static System.Byte[] Encode(System.Security.Cryptography.RSA rsa) { return default(System.Byte[]); }
      public System.Byte[] GetBytes() { return default(System.Byte[]); }
    }
  }
  public abstract partial class RC4 : System.Security.Cryptography.SymmetricAlgorithm {
    public RC4() { }
    public override System.Byte[] IV { get { return default(System.Byte[]); } set { } }
    public static new Mono.Security.Cryptography.RC4 Create() { return default(Mono.Security.Cryptography.RC4); }
    public static new Mono.Security.Cryptography.RC4 Create(string algName) { return default(Mono.Security.Cryptography.RC4); }
  }
  public partial class RSAManaged : System.Security.Cryptography.RSA {
    public RSAManaged() { }
    public RSAManaged(int keySize) { }
    public bool IsCrtPossible { get { return default(bool); } }
    public override string KeyExchangeAlgorithm { get { return default(string); } }
    public override int KeySize { get { return default(int); } }
    public bool PublicOnly { get { return default(bool); } }
    public override string SignatureAlgorithm { get { return default(string); } }
    public bool UseKeyBlinding { get { return default(bool); } set { } }
    public event Mono.Security.Cryptography.RSAManaged.KeyGeneratedEventHandler KeyGenerated { add { } remove { } }
    public override System.Byte[] DecryptValue(System.Byte[] rgb) { return default(System.Byte[]); }
    protected override void Dispose(bool disposing) { }
    public override System.Byte[] EncryptValue(System.Byte[] rgb) { return default(System.Byte[]); }
    public override System.Security.Cryptography.RSAParameters ExportParameters(bool includePrivateParameters) { return default(System.Security.Cryptography.RSAParameters); }
    ~RSAManaged() { }
    public override void ImportParameters(System.Security.Cryptography.RSAParameters parameters) { }
    public override string ToXmlString(bool includePrivateParameters) { return default(string); }
    public delegate void KeyGeneratedEventHandler(object sender, System.EventArgs e);
  }
  public abstract partial class SHA224 : System.Security.Cryptography.HashAlgorithm {
    public SHA224() { }
    public static new Mono.Security.Cryptography.SHA224 Create() { return default(Mono.Security.Cryptography.SHA224); }
    public static new Mono.Security.Cryptography.SHA224 Create(string hashName) { return default(Mono.Security.Cryptography.SHA224); }
  }
  public partial class SHA224Managed : Mono.Security.Cryptography.SHA224 {
    public SHA224Managed() { }
    protected override void HashCore(System.Byte[] rgb, int start, int size) { }
    protected override System.Byte[] HashFinal() { return default(System.Byte[]); }
    public override void Initialize() { }
  }
}
namespace Mono.Security.Protocol.Ntlm {
  [System.ObsoleteAttribute("Use of this API is highly discouraged, it selects legacy-mode LM/NTLM authentication, which sends your password in very weak encryption over the wire even if the server supports the more secure NTLMv2 / NTLMv2 Session. You need to use the new `Type3Message (Type2Message)' constructor to use the more secure NTLMv2 / NTLMv2 Session authentication modes. These require the Type 2 message from the server to compute the response.")]
  public partial class ChallengeResponse : System.IDisposable {
    public ChallengeResponse() { }
    public ChallengeResponse(string password, System.Byte[] challenge) { }
    public System.Byte[] Challenge { get { return default(System.Byte[]); } set { } }
    public System.Byte[] LM { get { return default(System.Byte[]); } }
    public System.Byte[] NT { get { return default(System.Byte[]); } }
    public string Password { get { return default(string); } set { } }
    public void Dispose() { }
    ~ChallengeResponse() { }
  }
  public static partial class ChallengeResponse2 {
    public static void Compute(Mono.Security.Protocol.Ntlm.Type2Message type2, Mono.Security.Protocol.Ntlm.NtlmAuthLevel level, string username, string password, string domain, out System.Byte[] lm, out System.Byte[] ntlm) { lm = default(System.Byte[]); ntlm = default(System.Byte[]); }
  }
  public abstract partial class MessageBase {
    protected MessageBase(int messageType) { }
    public Mono.Security.Protocol.Ntlm.NtlmFlags Flags { get { return default(Mono.Security.Protocol.Ntlm.NtlmFlags); } set { } }
    public int Type { get { return default(int); } }
    protected bool CheckHeader(System.Byte[] message) { return default(bool); }
    protected virtual void Decode(System.Byte[] message) { }
    public abstract System.Byte[] GetBytes();
    protected System.Byte[] PrepareMessage(int messageSize) { return default(System.Byte[]); }
  }
  public enum NtlmAuthLevel {
    LM_and_NTLM = 0,
    LM_and_NTLM_and_try_NTLMv2_Session = 1,
    NTLM_only = 2,
    NTLMv2_only = 3,
  }
  [System.FlagsAttribute]
  public enum NtlmFlags {
    Negotiate128 = 536870912,
    Negotiate56 = -2147483648,
    NegotiateAlwaysSign = 32768,
    NegotiateDomainSupplied = 4096,
    NegotiateNtlm = 512,
    NegotiateNtlm2Key = 524288,
    NegotiateOem = 2,
    NegotiateUnicode = 1,
    NegotiateWorkstationSupplied = 8192,
    RequestTarget = 4,
  }
  public static partial class NtlmSettings {
    public static Mono.Security.Protocol.Ntlm.NtlmAuthLevel DefaultAuthLevel { get { return default(Mono.Security.Protocol.Ntlm.NtlmAuthLevel); } set { } }
  }
  public partial class Type1Message : Mono.Security.Protocol.Ntlm.MessageBase {
    public Type1Message() : base (default(int)) { }
    public Type1Message(System.Byte[] message) : base (default(int)) { }
    public string Domain { get { return default(string); } set { } }
    public string Host { get { return default(string); } set { } }
    protected override void Decode(System.Byte[] message) { }
    public override System.Byte[] GetBytes() { return default(System.Byte[]); }
  }
  public partial class Type2Message : Mono.Security.Protocol.Ntlm.MessageBase {
    public Type2Message() : base (default(int)) { }
    public Type2Message(System.Byte[] message) : base (default(int)) { }
    public System.Byte[] Nonce { get { return default(System.Byte[]); } set { } }
    public System.Byte[] TargetInfo { get { return default(System.Byte[]); } }
    public string TargetName { get { return default(string); } }
    protected override void Decode(System.Byte[] message) { }
    ~Type2Message() { }
    public override System.Byte[] GetBytes() { return default(System.Byte[]); }
  }
  public partial class Type3Message : Mono.Security.Protocol.Ntlm.MessageBase {
    [System.ObsoleteAttribute("Use of this API is highly discouraged, it selects legacy-mode LM/NTLM authentication, which sends your password in very weak encryption over the wire even if the server supports the more secure NTLMv2 / NTLMv2 Session. You need to use the new `Type3Message (Type2Message)' constructor to use the more secure NTLMv2 / NTLMv2 Session authentication modes. These require the Type 2 message from the server to compute the response.")]
    public Type3Message() : base (default(int)) { }
    public Type3Message(Mono.Security.Protocol.Ntlm.Type2Message type2) : base (default(int)) { }
    public Type3Message(System.Byte[] message) : base (default(int)) { }
    [System.ObsoleteAttribute("Use of this API is highly discouraged, it selects legacy-mode LM/NTLM authentication, which sends your password in very weak encryption over the wire even if the server supports the more secure NTLMv2 / NTLMv2 Session. You need to use the new `Type3Message (Type2Message)' constructor to use the more secure NTLMv2 / NTLMv2 Session authentication modes. These require the Type 2 message from the server to compute the response.")]
    public System.Byte[] Challenge { get { return default(System.Byte[]); } set { } }
    [System.ObsoleteAttribute("Use NtlmSettings.DefaultAuthLevel")]
    public static Mono.Security.Protocol.Ntlm.NtlmAuthLevel DefaultAuthLevel { get { return default(Mono.Security.Protocol.Ntlm.NtlmAuthLevel); } set { } }
    public string Domain { get { return default(string); } set { } }
    public string Host { get { return default(string); } set { } }
    public Mono.Security.Protocol.Ntlm.NtlmAuthLevel Level { get { return default(Mono.Security.Protocol.Ntlm.NtlmAuthLevel); } set { } }
    public System.Byte[] LM { get { return default(System.Byte[]); } }
    public System.Byte[] NT { get { return default(System.Byte[]); } set { } }
    public string Password { get { return default(string); } set { } }
    public string Username { get { return default(string); } set { } }
    protected override void Decode(System.Byte[] message) { }
    ~Type3Message() { }
    public override System.Byte[] GetBytes() { return default(System.Byte[]); }
  }
}
namespace Mono.Security.Protocol.Tls {
  public delegate System.Security.Cryptography.X509Certificates.X509Certificate CertificateSelectionCallback(System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection serverRequestedCertificates);
  public delegate bool CertificateValidationCallback(System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Int32[] certificateErrors);
  public delegate Mono.Security.Protocol.Tls.ValidationResult CertificateValidationCallback2(Mono.Security.X509.X509CertificateCollection collection);
  public enum CipherAlgorithmType {
    Des = 0,
    None = 1,
    Rc2 = 2,
    Rc4 = 3,
    Rijndael = 4,
    SkipJack = 5,
    TripleDes = 6,
  }
  public enum ExchangeAlgorithmType {
    DiffieHellman = 0,
    Fortezza = 1,
    None = 2,
    RsaKeyX = 3,
    RsaSign = 4,
  }
  public enum HashAlgorithmType {
    Md5 = 0,
    None = 1,
    Sha1 = 2,
  }
  public delegate System.Security.Cryptography.AsymmetricAlgorithm PrivateKeySelectionCallback(System.Security.Cryptography.X509Certificates.X509Certificate certificate, string targetHost);
  public enum SecurityCompressionType {
    None = 0,
    Zlib = 1,
  }
  [System.FlagsAttribute]
  public enum SecurityProtocolType {
    Default = -1073741824,
    Ssl2 = 12,
    Ssl3 = 48,
    Tls = 192,
    Tls11 = 768,
    Tls12 = 3072,
  }
  public partial class SslClientStream : Mono.Security.Protocol.Tls.SslStreamBase {
    public SslClientStream(System.IO.Stream stream, string targetHost, bool ownsStream) : base (default(System.IO.Stream), default(bool)) { }
    public SslClientStream(System.IO.Stream stream, string targetHost, bool ownsStream, Mono.Security.Protocol.Tls.SecurityProtocolType securityProtocolType) : base (default(System.IO.Stream), default(bool)) { }
    public SslClientStream(System.IO.Stream stream, string targetHost, bool ownsStream, Mono.Security.Protocol.Tls.SecurityProtocolType securityProtocolType, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates) : base (default(System.IO.Stream), default(bool)) { }
    public SslClientStream(System.IO.Stream stream, string targetHost, System.Security.Cryptography.X509Certificates.X509Certificate clientCertificate) : base (default(System.IO.Stream), default(bool)) { }
    public SslClientStream(System.IO.Stream stream, string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates) : base (default(System.IO.Stream), default(bool)) { }
    public System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates { get { return default(System.Security.Cryptography.X509Certificates.X509CertificateCollection); } }
    public Mono.Security.Protocol.Tls.CertificateSelectionCallback ClientCertSelectionDelegate { get { return default(Mono.Security.Protocol.Tls.CertificateSelectionCallback); } set { } }
    public Mono.Security.Protocol.Tls.PrivateKeySelectionCallback PrivateKeyCertSelectionDelegate { get { return default(Mono.Security.Protocol.Tls.PrivateKeySelectionCallback); } set { } }
    public System.Security.Cryptography.X509Certificates.X509Certificate SelectedClientCertificate { get { return default(System.Security.Cryptography.X509Certificates.X509Certificate); } }
    public Mono.Security.Protocol.Tls.CertificateValidationCallback ServerCertValidationDelegate { get { return default(Mono.Security.Protocol.Tls.CertificateValidationCallback); } set { } }
    public event Mono.Security.Protocol.Tls.CertificateValidationCallback2 ServerCertValidation2 { add { } remove { } }
    protected override void Dispose(bool disposing) { }
    ~SslClientStream() { }
  }
  public partial class SslServerStream : Mono.Security.Protocol.Tls.SslStreamBase {
    public SslServerStream(System.IO.Stream stream, System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate) : base (default(System.IO.Stream), default(bool)) { }
    public SslServerStream(System.IO.Stream stream, System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, bool clientCertificateRequired, bool ownsStream) : base (default(System.IO.Stream), default(bool)) { }
    public SslServerStream(System.IO.Stream stream, System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, bool clientCertificateRequired, bool ownsStream, Mono.Security.Protocol.Tls.SecurityProtocolType securityProtocolType) : base (default(System.IO.Stream), default(bool)) { }
    public SslServerStream(System.IO.Stream stream, System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, bool clientCertificateRequired, bool requestClientCertificate, bool ownsStream) : base (default(System.IO.Stream), default(bool)) { }
    public SslServerStream(System.IO.Stream stream, System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, bool clientCertificateRequired, bool requestClientCertificate, bool ownsStream, Mono.Security.Protocol.Tls.SecurityProtocolType securityProtocolType) : base (default(System.IO.Stream), default(bool)) { }
    public System.Security.Cryptography.X509Certificates.X509Certificate ClientCertificate { get { return default(System.Security.Cryptography.X509Certificates.X509Certificate); } }
    public Mono.Security.Protocol.Tls.CertificateValidationCallback ClientCertValidationDelegate { get { return default(Mono.Security.Protocol.Tls.CertificateValidationCallback); } set { } }
    public Mono.Security.Protocol.Tls.PrivateKeySelectionCallback PrivateKeyCertSelectionDelegate { get { return default(Mono.Security.Protocol.Tls.PrivateKeySelectionCallback); } set { } }
    public event Mono.Security.Protocol.Tls.CertificateValidationCallback2 ClientCertValidation2 { add { } remove { } }
    protected override void Dispose(bool disposing) { }
    ~SslServerStream() { }
  }
  public abstract partial class SslStreamBase : System.IO.Stream, System.IDisposable {
    protected SslStreamBase(System.IO.Stream stream, bool ownsStream) { }
    public override bool CanRead { get { return default(bool); } }
    public override bool CanSeek { get { return default(bool); } }
    public override bool CanWrite { get { return default(bool); } }
    public bool CheckCertRevocationStatus { get { return default(bool); } set { } }
    public Mono.Security.Protocol.Tls.CipherAlgorithmType CipherAlgorithm { get { return default(Mono.Security.Protocol.Tls.CipherAlgorithmType); } }
    public int CipherStrength { get { return default(int); } }
    public Mono.Security.Protocol.Tls.HashAlgorithmType HashAlgorithm { get { return default(Mono.Security.Protocol.Tls.HashAlgorithmType); } }
    public int HashStrength { get { return default(int); } }
    public Mono.Security.Protocol.Tls.ExchangeAlgorithmType KeyExchangeAlgorithm { get { return default(Mono.Security.Protocol.Tls.ExchangeAlgorithmType); } }
    public int KeyExchangeStrength { get { return default(int); } }
    public override long Length { get { return default(long); } }
    public override long Position { get { return default(long); } set { } }
    public Mono.Security.Protocol.Tls.SecurityProtocolType SecurityProtocol { get { return default(Mono.Security.Protocol.Tls.SecurityProtocolType); } }
    public System.Security.Cryptography.X509Certificates.X509Certificate ServerCertificate { get { return default(System.Security.Cryptography.X509Certificates.X509Certificate); } }
    public override System.IAsyncResult BeginRead(System.Byte[] buffer, int offset, int count, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public override System.IAsyncResult BeginWrite(System.Byte[] buffer, int offset, int count, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public override void Close() { }
    protected override void Dispose(bool disposing) { }
    public override int EndRead(System.IAsyncResult asyncResult) { return default(int); }
    public override void EndWrite(System.IAsyncResult asyncResult) { }
    ~SslStreamBase() { }
    public override void Flush() { }
    public int Read(System.Byte[] buffer) { return default(int); }
    public override int Read(System.Byte[] buffer, int offset, int count) { return default(int); }
    public override long Seek(long offset, System.IO.SeekOrigin origin) { return default(long); }
    public override void SetLength(long value) { }
    public void Write(System.Byte[] buffer) { }
    public override void Write(System.Byte[] buffer, int offset, int count) { }
  }
  public partial class ValidationResult {
    public ValidationResult(bool trusted, bool user_denied, int error_code) { }
    public int ErrorCode { get { return default(int); } }
    public bool Trusted { get { return default(bool); } }
    public bool UserDenied { get { return default(bool); } }
  }
}
namespace Mono.Security.X509 {
  public partial class PKCS12 : System.ICloneable {
    public const string certBag = "1.2.840.113549.1.12.10.1.3";
    public const string crlBag = "1.2.840.113549.1.12.10.1.4";
    public const int CryptoApiPasswordLimit = 32;
    public const string keyBag = "1.2.840.113549.1.12.10.1.1";
    public const string pbeWithSHAAnd128BitRC2CBC = "1.2.840.113549.1.12.1.5";
    public const string pbeWithSHAAnd128BitRC4 = "1.2.840.113549.1.12.1.1";
    public const string pbeWithSHAAnd2KeyTripleDESCBC = "1.2.840.113549.1.12.1.4";
    public const string pbeWithSHAAnd3KeyTripleDESCBC = "1.2.840.113549.1.12.1.3";
    public const string pbeWithSHAAnd40BitRC2CBC = "1.2.840.113549.1.12.1.6";
    public const string pbeWithSHAAnd40BitRC4 = "1.2.840.113549.1.12.1.2";
    public const string pkcs8ShroudedKeyBag = "1.2.840.113549.1.12.10.1.2";
    public const string safeContentsBag = "1.2.840.113549.1.12.10.1.6";
    public const string sdsiCertificate = "1.2.840.113549.1.9.22.2";
    public const string secretBag = "1.2.840.113549.1.12.10.1.5";
    public const string x509Certificate = "1.2.840.113549.1.9.22.1";
    public const string x509Crl = "1.2.840.113549.1.9.23.1";
    public PKCS12() { }
    public PKCS12(System.Byte[] data) { }
    public PKCS12(System.Byte[] data, System.Byte[] password) { }
    public PKCS12(System.Byte[] data, string password) { }
    public Mono.Security.X509.X509CertificateCollection Certificates { get { return default(Mono.Security.X509.X509CertificateCollection); } }
    public int IterationCount { get { return default(int); } set { } }
    public System.Collections.ArrayList Keys { get { return default(System.Collections.ArrayList); } }
    public static int MaximumPasswordLength { get { return default(int); } set { } }
    public string Password { set { } }
    public System.Collections.ArrayList Secrets { get { return default(System.Collections.ArrayList); } }
    public void AddCertificate(Mono.Security.X509.X509Certificate cert) { }
    public void AddCertificate(Mono.Security.X509.X509Certificate cert, System.Collections.IDictionary attributes) { }
    public void AddKeyBag(System.Security.Cryptography.AsymmetricAlgorithm aa) { }
    public void AddKeyBag(System.Security.Cryptography.AsymmetricAlgorithm aa, System.Collections.IDictionary attributes) { }
    public void AddPkcs8ShroudedKeyBag(System.Security.Cryptography.AsymmetricAlgorithm aa) { }
    public void AddPkcs8ShroudedKeyBag(System.Security.Cryptography.AsymmetricAlgorithm aa, System.Collections.IDictionary attributes) { }
    public void AddSecretBag(System.Byte[] secret) { }
    public void AddSecretBag(System.Byte[] secret, System.Collections.IDictionary attributes) { }
    public object Clone() { return default(object); }
    public System.Byte[] Decrypt(Mono.Security.PKCS7.EncryptedData ed) { return default(System.Byte[]); }
    public System.Byte[] Decrypt(string algorithmOid, System.Byte[] salt, int iterationCount, System.Byte[] encryptedData) { return default(System.Byte[]); }
    public System.Byte[] Encrypt(string algorithmOid, System.Byte[] salt, int iterationCount, System.Byte[] data) { return default(System.Byte[]); }
    ~PKCS12() { }
    public System.Security.Cryptography.AsymmetricAlgorithm GetAsymmetricAlgorithm(System.Collections.IDictionary attrs) { return default(System.Security.Cryptography.AsymmetricAlgorithm); }
    public System.Collections.IDictionary GetAttributes(Mono.Security.X509.X509Certificate cert) { return default(System.Collections.IDictionary); }
    public System.Collections.IDictionary GetAttributes(System.Security.Cryptography.AsymmetricAlgorithm aa) { return default(System.Collections.IDictionary); }
    public System.Byte[] GetBytes() { return default(System.Byte[]); }
    public Mono.Security.X509.X509Certificate GetCertificate(System.Collections.IDictionary attrs) { return default(Mono.Security.X509.X509Certificate); }
    public System.Byte[] GetSecret(System.Collections.IDictionary attrs) { return default(System.Byte[]); }
    public static Mono.Security.X509.PKCS12 LoadFromFile(string filename) { return default(Mono.Security.X509.PKCS12); }
    public static Mono.Security.X509.PKCS12 LoadFromFile(string filename, string password) { return default(Mono.Security.X509.PKCS12); }
    public void RemoveCertificate(Mono.Security.X509.X509Certificate cert) { }
    public void RemoveCertificate(Mono.Security.X509.X509Certificate cert, System.Collections.IDictionary attrs) { }
    public void RemoveKeyBag(System.Security.Cryptography.AsymmetricAlgorithm aa) { }
    public void RemovePkcs8ShroudedKeyBag(System.Security.Cryptography.AsymmetricAlgorithm aa) { }
    public void RemoveSecretBag(System.Byte[] secret) { }
    public void SaveToFile(string filename) { }
    public partial class DeriveBytes {
      public DeriveBytes() { }
      public string HashName { get { return default(string); } set { } }
      public int IterationCount { get { return default(int); } set { } }
      public System.Byte[] Password { get { return default(System.Byte[]); } set { } }
      public System.Byte[] Salt { get { return default(System.Byte[]); } set { } }
      public System.Byte[] DeriveIV(int size) { return default(System.Byte[]); }
      public System.Byte[] DeriveKey(int size) { return default(System.Byte[]); }
      public System.Byte[] DeriveMAC(int size) { return default(System.Byte[]); }
      public enum Purpose {
        IV = 1,
        Key = 0,
        MAC = 2,
      }
    }
  }
  public partial class PKCS5 {
    public const string pbeWithMD2AndDESCBC = "1.2.840.113549.1.5.1";
    public const string pbeWithMD2AndRC2CBC = "1.2.840.113549.1.5.4";
    public const string pbeWithMD5AndDESCBC = "1.2.840.113549.1.5.3";
    public const string pbeWithMD5AndRC2CBC = "1.2.840.113549.1.5.6";
    public const string pbeWithSHA1AndDESCBC = "1.2.840.113549.1.5.10";
    public const string pbeWithSHA1AndRC2CBC = "1.2.840.113549.1.5.11";
    public PKCS5() { }
  }
  public partial class PKCS9 {
    public const string friendlyName = "1.2.840.113549.1.9.20";
    public const string localKeyId = "1.2.840.113549.1.9.21";
    public PKCS9() { }
  }
  public sealed partial class X501 {
    internal X501() { }
    public static Mono.Security.ASN1 FromString(string rdn) { return default(Mono.Security.ASN1); }
    public static string ToString(Mono.Security.ASN1 seq) { return default(string); }
    public static string ToString(Mono.Security.ASN1 seq, bool reversed, string separator, bool quotes) { return default(string); }
  }
  public abstract partial class X509Builder {
    protected X509Builder() { }
    public string Hash { get { return default(string); } set { } }
    protected string GetOid(string hashName) { return default(string); }
    public virtual System.Byte[] Sign(System.Security.Cryptography.AsymmetricAlgorithm aa) { return default(System.Byte[]); }
    public virtual System.Byte[] Sign(System.Security.Cryptography.DSA key) { return default(System.Byte[]); }
    public virtual System.Byte[] Sign(System.Security.Cryptography.RSA key) { return default(System.Byte[]); }
    protected abstract Mono.Security.ASN1 ToBeSigned(string hashName);
  }
  public partial class X509Certificate : System.Runtime.Serialization.ISerializable {
    public X509Certificate(System.Byte[] data) { }
    protected X509Certificate(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public System.Security.Cryptography.DSA DSA { get { return default(System.Security.Cryptography.DSA); } set { } }
    public Mono.Security.X509.X509ExtensionCollection Extensions { get { return default(Mono.Security.X509.X509ExtensionCollection); } }
    public System.Byte[] Hash { get { return default(System.Byte[]); } }
    public bool IsCurrent { get { return default(bool); } }
    public bool IsSelfSigned { get { return default(bool); } }
    public virtual string IssuerName { get { return default(string); } }
    public System.Byte[] IssuerUniqueIdentifier { get { return default(System.Byte[]); } }
    public virtual string KeyAlgorithm { get { return default(string); } }
    public virtual System.Byte[] KeyAlgorithmParameters { get { return default(System.Byte[]); } set { } }
    public virtual System.Byte[] PublicKey { get { return default(System.Byte[]); } }
    public virtual System.Byte[] RawData { get { return default(System.Byte[]); } }
    public virtual System.Security.Cryptography.RSA RSA { get { return default(System.Security.Cryptography.RSA); } set { } }
    public virtual System.Byte[] SerialNumber { get { return default(System.Byte[]); } }
    public virtual System.Byte[] Signature { get { return default(System.Byte[]); } }
    public virtual string SignatureAlgorithm { get { return default(string); } }
    public virtual System.Byte[] SignatureAlgorithmParameters { get { return default(System.Byte[]); } }
    public virtual string SubjectName { get { return default(string); } }
    public System.Byte[] SubjectUniqueIdentifier { get { return default(System.Byte[]); } }
    public virtual System.DateTime ValidFrom { get { return default(System.DateTime); } }
    public virtual System.DateTime ValidUntil { get { return default(System.DateTime); } }
    public int Version { get { return default(int); } }
    public bool CheckSignature(System.Byte[] hash, string hashAlgorithm, System.Byte[] signature) { return default(bool); }
    public Mono.Security.ASN1 GetIssuerName() { return default(Mono.Security.ASN1); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, SerializationFormatter=true)]
    public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public Mono.Security.ASN1 GetSubjectName() { return default(Mono.Security.ASN1); }
    public bool VerifySignature(System.Security.Cryptography.AsymmetricAlgorithm aa) { return default(bool); }
    public bool WasCurrent(System.DateTime instant) { return default(bool); }
  }
  public partial class X509CertificateBuilder : Mono.Security.X509.X509Builder {
    public X509CertificateBuilder() { }
    public X509CertificateBuilder(byte version) { }
    public Mono.Security.X509.X509ExtensionCollection Extensions { get { return default(Mono.Security.X509.X509ExtensionCollection); } }
    public string IssuerName { get { return default(string); } set { } }
    public System.Byte[] IssuerUniqueId { get { return default(System.Byte[]); } set { } }
    public System.DateTime NotAfter { get { return default(System.DateTime); } set { } }
    public System.DateTime NotBefore { get { return default(System.DateTime); } set { } }
    public System.Byte[] SerialNumber { get { return default(System.Byte[]); } set { } }
    public string SubjectName { get { return default(string); } set { } }
    public System.Security.Cryptography.AsymmetricAlgorithm SubjectPublicKey { get { return default(System.Security.Cryptography.AsymmetricAlgorithm); } set { } }
    public System.Byte[] SubjectUniqueId { get { return default(System.Byte[]); } set { } }
    public byte Version { get { return default(byte); } set { } }
    protected override Mono.Security.ASN1 ToBeSigned(string oid) { return default(Mono.Security.ASN1); }
  }
  public partial class X509CertificateCollection : System.Collections.CollectionBase, System.Collections.IEnumerable {
    public X509CertificateCollection() { }
    public X509CertificateCollection(Mono.Security.X509.X509Certificate[] value) { }
    public X509CertificateCollection(Mono.Security.X509.X509CertificateCollection value) { }
    public Mono.Security.X509.X509Certificate this[int index] { get { return default(Mono.Security.X509.X509Certificate); } set { } }
    public int Add(Mono.Security.X509.X509Certificate value) { return default(int); }
    public void AddRange(Mono.Security.X509.X509Certificate[] value) { }
    public void AddRange(Mono.Security.X509.X509CertificateCollection value) { }
    public bool Contains(Mono.Security.X509.X509Certificate value) { return default(bool); }
    public void CopyTo(Mono.Security.X509.X509Certificate[] array, int index) { }
    public new Mono.Security.X509.X509CertificateCollection.X509CertificateEnumerator GetEnumerator() { return default(Mono.Security.X509.X509CertificateCollection.X509CertificateEnumerator); }
    public override int GetHashCode() { return default(int); }
    public int IndexOf(Mono.Security.X509.X509Certificate value) { return default(int); }
    public void Insert(int index, Mono.Security.X509.X509Certificate value) { }
    public void Remove(Mono.Security.X509.X509Certificate value) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    public partial class X509CertificateEnumerator : System.Collections.IEnumerator {
      public X509CertificateEnumerator(Mono.Security.X509.X509CertificateCollection mappings) { }
      public Mono.Security.X509.X509Certificate Current { get { return default(Mono.Security.X509.X509Certificate); } }
      object System.Collections.IEnumerator.Current { get { return default(object); } }
      public bool MoveNext() { return default(bool); }
      public void Reset() { }
      bool System.Collections.IEnumerator.MoveNext() { return default(bool); }
      void System.Collections.IEnumerator.Reset() { }
    }
  }
  public partial class X509Chain {
    public X509Chain() { }
    public X509Chain(Mono.Security.X509.X509CertificateCollection chain) { }
    public Mono.Security.X509.X509CertificateCollection Chain { get { return default(Mono.Security.X509.X509CertificateCollection); } }
    public Mono.Security.X509.X509Certificate Root { get { return default(Mono.Security.X509.X509Certificate); } }
    public Mono.Security.X509.X509ChainStatusFlags Status { get { return default(Mono.Security.X509.X509ChainStatusFlags); } }
    public Mono.Security.X509.X509CertificateCollection TrustAnchors { get { return default(Mono.Security.X509.X509CertificateCollection); } set { } }
    public bool Build(Mono.Security.X509.X509Certificate leaf) { return default(bool); }
    public Mono.Security.X509.X509Certificate FindByIssuerName(string issuerName) { return default(Mono.Security.X509.X509Certificate); }
    public void LoadCertificate(Mono.Security.X509.X509Certificate x509) { }
    public void LoadCertificates(Mono.Security.X509.X509CertificateCollection collection) { }
    public void Reset() { }
  }
  [System.FlagsAttribute]
  public enum X509ChainStatusFlags {
    InvalidBasicConstraints = 1024,
    NoError = 0,
    NotSignatureValid = 8,
    NotTimeNested = 2,
    NotTimeValid = 1,
    PartialChain = 65536,
    UntrustedRoot = 32,
  }
  public partial class X509Crl {
    public X509Crl(System.Byte[] crl) { }
    public System.Collections.ArrayList Entries { get { return default(System.Collections.ArrayList); } }
    public Mono.Security.X509.X509ExtensionCollection Extensions { get { return default(Mono.Security.X509.X509ExtensionCollection); } }
    public System.Byte[] Hash { get { return default(System.Byte[]); } }
    public bool IsCurrent { get { return default(bool); } }
    public string IssuerName { get { return default(string); } }
    public Mono.Security.X509.X509Crl.X509CrlEntry this[System.Byte[] serialNumber] { get { return default(Mono.Security.X509.X509Crl.X509CrlEntry); } }
    public Mono.Security.X509.X509Crl.X509CrlEntry this[int index] { get { return default(Mono.Security.X509.X509Crl.X509CrlEntry); } }
    public System.DateTime NextUpdate { get { return default(System.DateTime); } }
    public System.Byte[] RawData { get { return default(System.Byte[]); } }
    public System.Byte[] Signature { get { return default(System.Byte[]); } }
    public string SignatureAlgorithm { get { return default(string); } }
    public System.DateTime ThisUpdate { get { return default(System.DateTime); } }
    public byte Version { get { return default(byte); } }
    public static Mono.Security.X509.X509Crl CreateFromFile(string filename) { return default(Mono.Security.X509.X509Crl); }
    public System.Byte[] GetBytes() { return default(System.Byte[]); }
    public Mono.Security.X509.X509Crl.X509CrlEntry GetCrlEntry(Mono.Security.X509.X509Certificate x509) { return default(Mono.Security.X509.X509Crl.X509CrlEntry); }
    public Mono.Security.X509.X509Crl.X509CrlEntry GetCrlEntry(System.Byte[] serialNumber) { return default(Mono.Security.X509.X509Crl.X509CrlEntry); }
    public bool VerifySignature(Mono.Security.X509.X509Certificate x509) { return default(bool); }
    public bool VerifySignature(System.Security.Cryptography.AsymmetricAlgorithm aa) { return default(bool); }
    public bool WasCurrent(System.DateTime instant) { return default(bool); }
    public partial class X509CrlEntry {
      internal X509CrlEntry() { }
      public Mono.Security.X509.X509ExtensionCollection Extensions { get { return default(Mono.Security.X509.X509ExtensionCollection); } }
      public System.DateTime RevocationDate { get { return default(System.DateTime); } }
      public System.Byte[] SerialNumber { get { return default(System.Byte[]); } }
      public System.Byte[] GetBytes() { return default(System.Byte[]); }
    }
  }
  public partial class X509Extension {
    protected bool extnCritical;
    protected string extnOid;
    protected Mono.Security.ASN1 extnValue;
    protected X509Extension() { }
    public X509Extension(Mono.Security.ASN1 asn1) { }
    public X509Extension(Mono.Security.X509.X509Extension extension) { }
    public Mono.Security.ASN1 ASN1 { get { return default(Mono.Security.ASN1); } }
    public bool Critical { get { return default(bool); } set { } }
    public virtual string Name { get { return default(string); } }
    public string Oid { get { return default(string); } }
    public Mono.Security.ASN1 Value { get { return default(Mono.Security.ASN1); } }
    protected virtual void Decode() { }
    protected virtual void Encode() { }
    public override bool Equals(object obj) { return default(bool); }
    public System.Byte[] GetBytes() { return default(System.Byte[]); }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
  }
  public sealed partial class X509ExtensionCollection : System.Collections.CollectionBase, System.Collections.IEnumerable {
    public X509ExtensionCollection() { }
    public X509ExtensionCollection(Mono.Security.ASN1 asn1) { }
    public Mono.Security.X509.X509Extension this[int index] { get { return default(Mono.Security.X509.X509Extension); } }
    public Mono.Security.X509.X509Extension this[string oid] { get { return default(Mono.Security.X509.X509Extension); } }
    public int Add(Mono.Security.X509.X509Extension extension) { return default(int); }
    public void AddRange(Mono.Security.X509.X509Extension[] extension) { }
    public void AddRange(Mono.Security.X509.X509ExtensionCollection collection) { }
    public bool Contains(Mono.Security.X509.X509Extension extension) { return default(bool); }
    public bool Contains(string oid) { return default(bool); }
    public void CopyTo(Mono.Security.X509.X509Extension[] extensions, int index) { }
    public System.Byte[] GetBytes() { return default(System.Byte[]); }
    public int IndexOf(Mono.Security.X509.X509Extension extension) { return default(int); }
    public int IndexOf(string oid) { return default(int); }
    public void Insert(int index, Mono.Security.X509.X509Extension extension) { }
    public void Remove(Mono.Security.X509.X509Extension extension) { }
    public void Remove(string oid) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public partial class X509Store {
    internal X509Store() { }
    public Mono.Security.X509.X509CertificateCollection Certificates { get { return default(Mono.Security.X509.X509CertificateCollection); } }
    public System.Collections.ArrayList Crls { get { return default(System.Collections.ArrayList); } }
    public string Name { get { return default(string); } }
    public void Clear() { }
    public void Import(Mono.Security.X509.X509Certificate certificate) { }
    public void Import(Mono.Security.X509.X509Crl crl) { }
    public void Remove(Mono.Security.X509.X509Certificate certificate) { }
    public void Remove(Mono.Security.X509.X509Crl crl) { }
  }
  public sealed partial class X509StoreManager {
    internal X509StoreManager() { }
    public static Mono.Security.X509.X509Stores CurrentUser { get { return default(Mono.Security.X509.X509Stores); } }
    public static Mono.Security.X509.X509CertificateCollection IntermediateCACertificates { get { return default(Mono.Security.X509.X509CertificateCollection); } }
    public static System.Collections.ArrayList IntermediateCACrls { get { return default(System.Collections.ArrayList); } }
    public static Mono.Security.X509.X509Stores LocalMachine { get { return default(Mono.Security.X509.X509Stores); } }
    public static System.Collections.ArrayList TrustedRootCACrls { get { return default(System.Collections.ArrayList); } }
    public static Mono.Security.X509.X509CertificateCollection TrustedRootCertificates { get { return default(Mono.Security.X509.X509CertificateCollection); } }
    public static Mono.Security.X509.X509CertificateCollection UntrustedCertificates { get { return default(Mono.Security.X509.X509CertificateCollection); } }
  }
  public partial class X509Stores {
    internal X509Stores() { }
    public Mono.Security.X509.X509Store IntermediateCA { get { return default(Mono.Security.X509.X509Store); } }
    public Mono.Security.X509.X509Store OtherPeople { get { return default(Mono.Security.X509.X509Store); } }
    public Mono.Security.X509.X509Store Personal { get { return default(Mono.Security.X509.X509Store); } }
    public Mono.Security.X509.X509Store TrustedRoot { get { return default(Mono.Security.X509.X509Store); } }
    public Mono.Security.X509.X509Store Untrusted { get { return default(Mono.Security.X509.X509Store); } }
    public void Clear() { }
    public Mono.Security.X509.X509Store Open(string storeName, bool create) { return default(Mono.Security.X509.X509Store); }
    public partial class Names {
      public const string IntermediateCA = "CA";
      public const string OtherPeople = "AddressBook";
      public const string Personal = "My";
      public const string TrustedRoot = "Trust";
      public const string Untrusted = "Disallowed";
      public Names() { }
    }
  }
  public partial class X520 {
    public X520() { }
    public abstract partial class AttributeTypeAndValue {
      protected AttributeTypeAndValue(string oid, int upperBound) { }
      protected AttributeTypeAndValue(string oid, int upperBound, byte encoding) { }
      public Mono.Security.ASN1 ASN1 { get { return default(Mono.Security.ASN1); } }
      public string Value { get { return default(string); } set { } }
      public System.Byte[] GetBytes() { return default(System.Byte[]); }
      public System.Byte[] GetBytes(byte encoding) { return default(System.Byte[]); }
    }
    public partial class CommonName : Mono.Security.X509.X520.AttributeTypeAndValue {
      public CommonName() : base (default(string), default(int)) { }
    }
    public partial class CountryName : Mono.Security.X509.X520.AttributeTypeAndValue {
      public CountryName() : base (default(string), default(int)) { }
    }
    public partial class DnQualifier : Mono.Security.X509.X520.AttributeTypeAndValue {
      public DnQualifier() : base (default(string), default(int)) { }
    }
    public partial class DomainComponent : Mono.Security.X509.X520.AttributeTypeAndValue {
      public DomainComponent() : base (default(string), default(int)) { }
    }
    public partial class EmailAddress : Mono.Security.X509.X520.AttributeTypeAndValue {
      public EmailAddress() : base (default(string), default(int)) { }
    }
    public partial class GivenName : Mono.Security.X509.X520.AttributeTypeAndValue {
      public GivenName() : base (default(string), default(int)) { }
    }
    public partial class Initial : Mono.Security.X509.X520.AttributeTypeAndValue {
      public Initial() : base (default(string), default(int)) { }
    }
    public partial class LocalityName : Mono.Security.X509.X520.AttributeTypeAndValue {
      public LocalityName() : base (default(string), default(int)) { }
    }
    public partial class Name : Mono.Security.X509.X520.AttributeTypeAndValue {
      public Name() : base (default(string), default(int)) { }
    }
    public partial class Oid : Mono.Security.X509.X520.AttributeTypeAndValue {
      public Oid(string oid) : base (default(string), default(int)) { }
    }
    public partial class OrganizationalUnitName : Mono.Security.X509.X520.AttributeTypeAndValue {
      public OrganizationalUnitName() : base (default(string), default(int)) { }
    }
    public partial class OrganizationName : Mono.Security.X509.X520.AttributeTypeAndValue {
      public OrganizationName() : base (default(string), default(int)) { }
    }
    public partial class SerialNumber : Mono.Security.X509.X520.AttributeTypeAndValue {
      public SerialNumber() : base (default(string), default(int)) { }
    }
    public partial class StateOrProvinceName : Mono.Security.X509.X520.AttributeTypeAndValue {
      public StateOrProvinceName() : base (default(string), default(int)) { }
    }
    public partial class Surname : Mono.Security.X509.X520.AttributeTypeAndValue {
      public Surname() : base (default(string), default(int)) { }
    }
    public partial class Title : Mono.Security.X509.X520.AttributeTypeAndValue {
      public Title() : base (default(string), default(int)) { }
    }
    public partial class UserId : Mono.Security.X509.X520.AttributeTypeAndValue {
      public UserId() : base (default(string), default(int)) { }
    }
  }
}
namespace Mono.Security.X509.Extensions {
  public partial class AuthorityKeyIdentifierExtension : Mono.Security.X509.X509Extension {
    public AuthorityKeyIdentifierExtension() { }
    public AuthorityKeyIdentifierExtension(Mono.Security.ASN1 asn1) { }
    public AuthorityKeyIdentifierExtension(Mono.Security.X509.X509Extension extension) { }
    public System.Byte[] Identifier { get { return default(System.Byte[]); } set { } }
    public override string Name { get { return default(string); } }
    protected override void Decode() { }
    protected override void Encode() { }
    public override string ToString() { return default(string); }
  }
  public partial class BasicConstraintsExtension : Mono.Security.X509.X509Extension {
    public const int NoPathLengthConstraint = -1;
    public BasicConstraintsExtension() { }
    public BasicConstraintsExtension(Mono.Security.ASN1 asn1) { }
    public BasicConstraintsExtension(Mono.Security.X509.X509Extension extension) { }
    public bool CertificateAuthority { get { return default(bool); } set { } }
    public override string Name { get { return default(string); } }
    public int PathLenConstraint { get { return default(int); } set { } }
    protected override void Decode() { }
    protected override void Encode() { }
    public override string ToString() { return default(string); }
  }
  public partial class CertificatePoliciesExtension : Mono.Security.X509.X509Extension {
    public CertificatePoliciesExtension() { }
    public CertificatePoliciesExtension(Mono.Security.ASN1 asn1) { }
    public CertificatePoliciesExtension(Mono.Security.X509.X509Extension extension) { }
    public override string Name { get { return default(string); } }
    protected override void Decode() { }
    public override string ToString() { return default(string); }
  }
  public partial class CRLDistributionPointsExtension : Mono.Security.X509.X509Extension {
    public CRLDistributionPointsExtension() { }
    public CRLDistributionPointsExtension(Mono.Security.ASN1 asn1) { }
    public CRLDistributionPointsExtension(Mono.Security.X509.X509Extension extension) { }
    public System.Collections.Generic.IEnumerable<Mono.Security.X509.Extensions.CRLDistributionPointsExtension.DistributionPoint> DistributionPoints { get { return default(System.Collections.Generic.IEnumerable<Mono.Security.X509.Extensions.CRLDistributionPointsExtension.DistributionPoint>); } }
    public override string Name { get { return default(string); } }
    protected override void Decode() { }
    public override string ToString() { return default(string); }
    public partial class DistributionPoint {
      public DistributionPoint(Mono.Security.ASN1 dp) { }
      public DistributionPoint(string dp, Mono.Security.X509.Extensions.CRLDistributionPointsExtension.ReasonFlags reasons, string issuer) { }
      public string CRLIssuer { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
      public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
      public Mono.Security.X509.Extensions.CRLDistributionPointsExtension.ReasonFlags Reasons { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.Security.X509.Extensions.CRLDistributionPointsExtension.ReasonFlags); } }
    }
    [System.FlagsAttribute]
    public enum ReasonFlags {
      AACompromise = 8,
      AffiliationChanged = 3,
      CACompromise = 2,
      CertificateHold = 6,
      CessationOfOperation = 5,
      KeyCompromise = 1,
      PrivilegeWithdrawn = 7,
      Superseded = 4,
      Unused = 0,
    }
  }
  public partial class ExtendedKeyUsageExtension : Mono.Security.X509.X509Extension {
    public ExtendedKeyUsageExtension() { }
    public ExtendedKeyUsageExtension(Mono.Security.ASN1 asn1) { }
    public ExtendedKeyUsageExtension(Mono.Security.X509.X509Extension extension) { }
    public System.Collections.ArrayList KeyPurpose { get { return default(System.Collections.ArrayList); } }
    public override string Name { get { return default(string); } }
    protected override void Decode() { }
    protected override void Encode() { }
    public override string ToString() { return default(string); }
  }
  public partial class KeyAttributesExtension : Mono.Security.X509.X509Extension {
    public KeyAttributesExtension() { }
    public KeyAttributesExtension(Mono.Security.ASN1 asn1) { }
    public KeyAttributesExtension(Mono.Security.X509.X509Extension extension) { }
    public System.Byte[] KeyIdentifier { get { return default(System.Byte[]); } }
    public override string Name { get { return default(string); } }
    public System.DateTime NotAfter { get { return default(System.DateTime); } }
    public System.DateTime NotBefore { get { return default(System.DateTime); } }
    protected override void Decode() { }
    public bool Support(Mono.Security.X509.Extensions.KeyUsages usage) { return default(bool); }
    public override string ToString() { return default(string); }
  }
  public partial class KeyUsageExtension : Mono.Security.X509.X509Extension {
    public KeyUsageExtension() { }
    public KeyUsageExtension(Mono.Security.ASN1 asn1) { }
    public KeyUsageExtension(Mono.Security.X509.X509Extension extension) { }
    public Mono.Security.X509.Extensions.KeyUsages KeyUsage { get { return default(Mono.Security.X509.Extensions.KeyUsages); } set { } }
    public override string Name { get { return default(string); } }
    protected override void Decode() { }
    protected override void Encode() { }
    public bool Support(Mono.Security.X509.Extensions.KeyUsages usage) { return default(bool); }
    public override string ToString() { return default(string); }
  }
  [System.FlagsAttribute]
  public enum KeyUsages {
    cRLSign = 2,
    dataEncipherment = 16,
    decipherOnly = 2048,
    digitalSignature = 128,
    encipherOnly = 1,
    keyAgreement = 8,
    keyCertSign = 4,
    keyEncipherment = 32,
    none = 0,
    nonRepudiation = 64,
  }
  public partial class NetscapeCertTypeExtension : Mono.Security.X509.X509Extension {
    public NetscapeCertTypeExtension() { }
    public NetscapeCertTypeExtension(Mono.Security.ASN1 asn1) { }
    public NetscapeCertTypeExtension(Mono.Security.X509.X509Extension extension) { }
    public override string Name { get { return default(string); } }
    protected override void Decode() { }
    public bool Support(Mono.Security.X509.Extensions.NetscapeCertTypeExtension.CertTypes usage) { return default(bool); }
    public override string ToString() { return default(string); }
    [System.FlagsAttribute]
    public enum CertTypes {
      ObjectSigning = 16,
      ObjectSigningCA = 1,
      Smime = 32,
      SmimeCA = 2,
      SslCA = 4,
      SslClient = 128,
      SslServer = 64,
    }
  }
  public partial class PrivateKeyUsagePeriodExtension : Mono.Security.X509.X509Extension {
    public PrivateKeyUsagePeriodExtension() { }
    public PrivateKeyUsagePeriodExtension(Mono.Security.ASN1 asn1) { }
    public PrivateKeyUsagePeriodExtension(Mono.Security.X509.X509Extension extension) { }
    public override string Name { get { return default(string); } }
    protected override void Decode() { }
    public override string ToString() { return default(string); }
  }
  public partial class SubjectAltNameExtension : Mono.Security.X509.X509Extension {
    public SubjectAltNameExtension() { }
    public SubjectAltNameExtension(Mono.Security.ASN1 asn1) { }
    public SubjectAltNameExtension(Mono.Security.X509.X509Extension extension) { }
    public SubjectAltNameExtension(System.String[] rfc822, System.String[] dnsNames, System.String[] ipAddresses, System.String[] uris) { }
    public System.String[] DNSNames { get { return default(System.String[]); } }
    public System.String[] IPAddresses { get { return default(System.String[]); } }
    public override string Name { get { return default(string); } }
    public System.String[] RFC822 { get { return default(System.String[]); } }
    public System.String[] UniformResourceIdentifiers { get { return default(System.String[]); } }
    protected override void Decode() { }
    public override string ToString() { return default(string); }
  }
  public partial class SubjectKeyIdentifierExtension : Mono.Security.X509.X509Extension {
    public SubjectKeyIdentifierExtension() { }
    public SubjectKeyIdentifierExtension(Mono.Security.ASN1 asn1) { }
    public SubjectKeyIdentifierExtension(Mono.Security.X509.X509Extension extension) { }
    public System.Byte[] Identifier { get { return default(System.Byte[]); } set { } }
    public override string Name { get { return default(string); } }
    protected override void Decode() { }
    protected override void Encode() { }
    public override string ToString() { return default(string); }
  }
}
namespace Mono.Xml {
  [System.CLSCompliantAttribute(false)]
  public partial class MiniParser {
    protected int col;
    protected static System.String[] errors;
    protected int line;
    protected bool splitCData;
    protected System.Int32[] twoCharBuff;
    public MiniParser() { }
    protected void FatalErr(string descr) { }
    public void Parse(Mono.Xml.MiniParser.IReader reader, Mono.Xml.MiniParser.IHandler handler) { }
    public void Reset() { }
    protected static bool StrEquals(string str, System.Text.StringBuilder sb, int sbStart, int len) { return default(bool); }
    protected static int Xlat(int charCode, int state) { return default(int); }
    public partial class AttrListImpl : Mono.Xml.MiniParser.IAttrList, Mono.Xml.MiniParser.IMutableAttrList {
      protected System.Collections.ArrayList names;
      protected System.Collections.ArrayList values;
      public AttrListImpl() { }
      public AttrListImpl(Mono.Xml.MiniParser.IAttrList attrs) { }
      public AttrListImpl(int initialCapacity) { }
      public bool IsEmpty { get { return default(bool); } }
      public int Length { get { return default(int); } }
      public System.String[] Names { get { return default(System.String[]); } }
      public System.String[] Values { get { return default(System.String[]); } }
      public void Add(string name, string value) { }
      public void ChangeValue(string name, string newValue) { }
      public void Clear() { }
      public void CopyFrom(Mono.Xml.MiniParser.IAttrList attrs) { }
      public string GetName(int i) { return default(string); }
      public string GetValue(int i) { return default(string); }
      public string GetValue(string name) { return default(string); }
      public void Remove(int i) { }
      public void Remove(string name) { }
    }
    public partial class HandlerAdapter : Mono.Xml.MiniParser.IHandler {
      public HandlerAdapter() { }
      public void OnChars(string ch) { }
      public void OnEndElement(string name) { }
      public void OnEndParsing(Mono.Xml.MiniParser parser) { }
      public void OnStartElement(string name, Mono.Xml.MiniParser.IAttrList attrs) { }
      public void OnStartParsing(Mono.Xml.MiniParser parser) { }
    }
    public partial interface IAttrList {
      bool IsEmpty { get; }
      int Length { get; }
      System.String[] Names { get; }
      System.String[] Values { get; }
      void ChangeValue(string name, string newValue);
      string GetName(int i);
      string GetValue(int i);
      string GetValue(string name);
    }
    public partial interface IHandler {
      void OnChars(string ch);
      void OnEndElement(string name);
      void OnEndParsing(Mono.Xml.MiniParser parser);
      void OnStartElement(string name, Mono.Xml.MiniParser.IAttrList attrs);
      void OnStartParsing(Mono.Xml.MiniParser parser);
    }
    public partial interface IMutableAttrList : Mono.Xml.MiniParser.IAttrList {
      void Add(string name, string value);
      void Clear();
      void CopyFrom(Mono.Xml.MiniParser.IAttrList attrs);
      void Remove(int i);
      void Remove(string name);
    }
    public partial interface IReader {
      int Read();
    }
    public partial class XMLError : System.Exception {
      protected int column;
      protected string descr;
      protected int line;
      public XMLError() { }
      public XMLError(string descr) { }
      public XMLError(string descr, int line, int column) { }
      public int Column { get { return default(int); } }
      public int Line { get { return default(int); } }
      public override string ToString() { return default(string); }
    }
  }
  [System.CLSCompliantAttribute(false)]
  public partial class SecurityParser : Mono.Xml.MiniParser, Mono.Xml.MiniParser.IHandler, Mono.Xml.MiniParser.IReader {
    public SecurityParser() { }
    public void LoadXml(string xml) { }
    public void OnChars(string ch) { }
    public void OnEndElement(string name) { }
    public void OnEndParsing(Mono.Xml.MiniParser parser) { }
    public void OnStartElement(string name, Mono.Xml.MiniParser.IAttrList attrs) { }
    public void OnStartParsing(Mono.Xml.MiniParser parser) { }
    public int Read() { return default(int); }
    public System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
  }
}
