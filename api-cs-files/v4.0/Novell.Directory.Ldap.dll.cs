namespace  {
  public partial class Integer32 {
    public Integer32(int ival) { }
    public int intValue { get { return default(int); } set { } }
  }
  public partial interface IThreadRunnable {
    void Run();
  }
  public partial class SupportClass {
    public SupportClass() { }
    public static object CreateNewInstance(System.Type classType) { return default(object); }
    public static bool EqualsSupport(System.Collections.ICollection source, System.Collections.ICollection target) { return default(bool); }
    public static bool EqualsSupport(System.Collections.ICollection source, object target) { return default(bool); }
    public static bool EqualsSupport(System.Collections.IDictionaryEnumerator source, System.Collections.IDictionaryEnumerator target) { return default(bool); }
    public static bool EqualsSupport(System.Collections.IDictionaryEnumerator source, object target) { return default(bool); }
    public static string FormatDateTime(System.Globalization.DateTimeFormatInfo format, System.DateTime date) { return default(string); }
    public static void GetCharsFromString(string sourceString, int sourceStart, int sourceEnd, ref System.Char[] destinationArray, int destinationStart) { }
    public static System.IO.FileStream GetFileStream(string FileName, bool Append) { return default(System.IO.FileStream); }
    public static object HashtableRemove(System.Collections.Hashtable hashtable, object key) { return default(object); }
    public static double Identity(double literal) { return default(double); }
    public static long Identity(long literal) { return default(long); }
    public static float Identity(float literal) { return default(float); }
    [System.CLSCompliantAttribute(false)]
    public static ulong Identity(ulong literal) { return default(ulong); }
    public static object PutElement(System.Collections.IDictionary collection, object key, object newValue) { return default(object); }
    [System.CLSCompliantAttribute(false)]
    public static int ReadInput(System.IO.Stream sourceStream, ref System.SByte[] target, int start, int count) { return default(int); }
    [System.CLSCompliantAttribute(false)]
    public static int ReadInput(System.IO.TextReader sourceTextReader, ref System.SByte[] target, int start, int count) { return default(int); }
    public static System.Collections.IEnumerator ReverseStack(System.Collections.ICollection collection) { return default(System.Collections.IEnumerator); }
    public static void SetSize(System.Collections.ArrayList arrayList, int newSize) { }
    public static object StackPush(System.Collections.Stack stack, object element) { return default(object); }
    public static System.Byte[] ToByteArray(System.Object[] tempObjectArray) { return default(System.Byte[]); }
    [System.CLSCompliantAttribute(false)]
    public static System.Byte[] ToByteArray(System.SByte[] sbyteArray) { return default(System.Byte[]); }
    public static System.Byte[] ToByteArray(string sourceString) { return default(System.Byte[]); }
    public static System.Char[] ToCharArray(System.Byte[] byteArray) { return default(System.Char[]); }
    [System.CLSCompliantAttribute(false)]
    public static System.Char[] ToCharArray(System.SByte[] sByteArray) { return default(System.Char[]); }
    [System.CLSCompliantAttribute(false)]
    public static System.SByte[] ToSByteArray(System.Byte[] byteArray) { return default(System.SByte[]); }
    public static bool VectorRemoveElement(System.Collections.IList arrayList, object element) { return default(bool); }
    public static void WriteStackTrace(System.Exception throwable, System.IO.TextWriter stream) { }
    public partial class AbstractSetSupport : SupportClass.SetSupport {
      public AbstractSetSupport() { }
    }
    public partial class ArrayListSupport {
      public ArrayListSupport() { }
      public static System.Object[] ToArray(System.Collections.ArrayList collection, System.Object[] objects) { return default(System.Object[]); }
    }
    public partial class ArraysSupport {
      public ArraysSupport() { }
      public static void FillArray(System.Array array, int fromindex, int toindex, object val) { }
      public static void FillArray(System.Array array, object val) { }
      public static bool IsArrayEqual(System.Array array1, System.Array array2) { return default(bool); }
    }
    public partial class CollectionSupport : System.Collections.CollectionBase {
      public CollectionSupport() { }
      public virtual bool Add(object element) { return default(bool); }
      public virtual bool AddAll(SupportClass.CollectionSupport collection) { return default(bool); }
      public virtual bool AddAll(System.Collections.ICollection collection) { return default(bool); }
      public virtual bool Contains(object element) { return default(bool); }
      public virtual bool ContainsAll(SupportClass.CollectionSupport collection) { return default(bool); }
      public virtual bool ContainsAll(System.Collections.ICollection collection) { return default(bool); }
      public virtual bool IsEmpty() { return default(bool); }
      public virtual bool Remove(object element) { return default(bool); }
      public virtual bool RemoveAll(SupportClass.CollectionSupport collection) { return default(bool); }
      public virtual bool RemoveAll(System.Collections.ICollection collection) { return default(bool); }
      public virtual bool RetainAll(SupportClass.CollectionSupport collection) { return default(bool); }
      public virtual bool RetainAll(System.Collections.ICollection collection) { return default(bool); }
      public virtual System.Object[] ToArray() { return default(System.Object[]); }
      public virtual System.Object[] ToArray(System.Object[] objects) { return default(System.Object[]); }
      public static SupportClass.CollectionSupport ToCollectionSupport(System.Object[] array) { return default(SupportClass.CollectionSupport); }
    }
    public partial class DateTimeFormatManager {
      public static SupportClass.DateTimeFormatManager.DateTimeFormatHashTable manager;
      public DateTimeFormatManager() { }
      public partial class DateTimeFormatHashTable : System.Collections.Hashtable {
        public DateTimeFormatHashTable() { }
        public string GetDateFormatPattern(System.Globalization.DateTimeFormatInfo format) { return default(string); }
        public string GetTimeFormatPattern(System.Globalization.DateTimeFormatInfo format) { return default(string); }
        public void SetDateFormatPattern(System.Globalization.DateTimeFormatInfo format, string newPattern) { }
        public void SetTimeFormatPattern(System.Globalization.DateTimeFormatInfo format, string newPattern) { }
      }
    }
    public partial class ListCollectionSupport : System.Collections.ArrayList {
      public ListCollectionSupport() { }
      public ListCollectionSupport(System.Collections.ICollection collection) { }
      public ListCollectionSupport(int capacity) { }
      public virtual new bool Add(object valueToInsert) { return default(bool); }
      public virtual bool AddAll(SupportClass.CollectionSupport collection) { return default(bool); }
      public virtual bool AddAll(System.Collections.IList collection) { return default(bool); }
      public virtual bool AddAll(int index, SupportClass.CollectionSupport collection) { return default(bool); }
      public virtual bool AddAll(int index, System.Collections.IList list) { return default(bool); }
      public virtual bool ContainsAll(SupportClass.CollectionSupport collection) { return default(bool); }
      public virtual bool ContainsAll(System.Collections.ICollection collection) { return default(bool); }
      public virtual object Get(int index) { return default(object); }
      public virtual object GetLast() { return default(object); }
      public virtual bool IsEmpty() { return default(bool); }
      public virtual object ListCollectionClone() { return default(object); }
      public virtual System.Collections.IEnumerator ListIterator() { return default(System.Collections.IEnumerator); }
      public virtual System.Collections.IEnumerator ListIterator(int index) { return default(System.Collections.IEnumerator); }
      public virtual bool RemoveAll(SupportClass.CollectionSupport collection) { return default(bool); }
      public virtual bool RemoveAll(System.Collections.ICollection collection) { return default(bool); }
      public virtual object RemoveElement(int index) { return default(object); }
      public virtual bool RemoveElement(object element) { return default(bool); }
      public virtual object RemoveFirst() { return default(object); }
      public virtual object RemoveLast() { return default(object); }
      public virtual bool RetainAll(SupportClass.CollectionSupport collection) { return default(bool); }
      public virtual bool RetainAll(System.Collections.ICollection collection) { return default(bool); }
      public virtual object Set(int index, object element) { return default(object); }
      public virtual SupportClass.ListCollectionSupport SubList(int startIndex, int endIndex) { return default(SupportClass.ListCollectionSupport); }
      public virtual System.Object[] ToArray(System.Object[] objects) { return default(System.Object[]); }
    }
    public partial class MessageDigestSupport {
      public MessageDigestSupport(string algorithm) { }
      public System.Security.Cryptography.HashAlgorithm Algorithm { get { return default(System.Security.Cryptography.HashAlgorithm); } set { } }
      public string AlgorithmName { get { return default(string); } }
      public System.Byte[] Data { get { return default(System.Byte[]); } set { } }
      [System.CLSCompliantAttribute(false)]
      public System.SByte[] DigestData() { return default(System.SByte[]); }
      [System.CLSCompliantAttribute(false)]
      public System.SByte[] DigestData(System.Byte[] newData) { return default(System.SByte[]); }
      [System.CLSCompliantAttribute(false)]
      public static bool EquivalentDigest(System.SByte[] firstDigest, System.SByte[] secondDigest) { return default(bool); }
      public static SupportClass.MessageDigestSupport GetInstance(string algorithm) { return default(SupportClass.MessageDigestSupport); }
      public void Reset() { }
      public override string ToString() { return default(string); }
      public void Update(byte newData) { }
      public void Update(System.Byte[] newData) { }
      public void Update(System.Byte[] newData, int offset, int count) { }
    }
    public partial class SecureRandomSupport {
      public SecureRandomSupport() { }
      public SecureRandomSupport(System.Byte[] seed) { }
      public static System.Byte[] GetSeed(int numberOfBytes) { return default(System.Byte[]); }
      [System.CLSCompliantAttribute(false)]
      public System.SByte[] NextBytes(System.Byte[] randomnumbersarray) { return default(System.SByte[]); }
      public void SetSeed(System.Byte[] newSeed) { }
      public void SetSeed(long newSeed) { }
    }
    public partial class SetSupport : System.Collections.ArrayList {
      public SetSupport() { }
      public SetSupport(System.Collections.ICollection collection) { }
      public SetSupport(int capacity) { }
      public virtual new bool Add(object objectToAdd) { return default(bool); }
      public virtual bool AddAll(SupportClass.CollectionSupport collection) { return default(bool); }
      public virtual bool AddAll(System.Collections.ICollection collection) { return default(bool); }
      public virtual bool ContainsAll(SupportClass.CollectionSupport collection) { return default(bool); }
      public virtual bool ContainsAll(System.Collections.ICollection collection) { return default(bool); }
      public virtual bool IsEmpty() { return default(bool); }
      public virtual new bool Remove(object elementToRemove) { return default(bool); }
      public virtual bool RemoveAll(SupportClass.CollectionSupport collection) { return default(bool); }
      public virtual bool RemoveAll(System.Collections.ICollection collection) { return default(bool); }
      public virtual bool RetainAll(SupportClass.CollectionSupport collection) { return default(bool); }
      public virtual bool RetainAll(System.Collections.ICollection collection) { return default(bool); }
      public virtual new System.Object[] ToArray() { return default(System.Object[]); }
      public virtual System.Object[] ToArray(System.Object[] objects) { return default(System.Object[]); }
    }
    public partial interface SingleThreadModel {
    }
    public partial class ThreadClass : IThreadRunnable {
      public ThreadClass() { }
      public ThreadClass(string Name) { }
      public ThreadClass(System.Threading.ThreadStart Start) { }
      public ThreadClass(System.Threading.ThreadStart Start, string Name) { }
      public System.Threading.Thread Instance { get { return default(System.Threading.Thread); } set { } }
      public bool IsAlive { get { return default(bool); } }
      public bool IsBackground { get { return default(bool); } set { } }
      public string Name { get { return default(string); } set { } }
      public System.Threading.ThreadPriority Priority { get { return default(System.Threading.ThreadPriority); } set { } }
      public void Abort() { }
      public void Abort(object stateInfo) { }
      public static SupportClass.ThreadClass Current() { return default(SupportClass.ThreadClass); }
      public virtual void Interrupt() { }
      public void Join() { }
      public void Join(long MiliSeconds) { }
      public void Join(long MiliSeconds, int NanoSeconds) { }
      public void Resume() { }
      public virtual void Run() { }
      public virtual void Start() { }
      public void Suspend() { }
      public override string ToString() { return default(string); }
    }
    public partial class Tokenizer {
      public Tokenizer(string source) { }
      public Tokenizer(string source, string delimiters) { }
      public Tokenizer(string source, string delimiters, bool retDel) { }
      public int Count { get { return default(int); } }
      public bool HasMoreTokens() { return default(bool); }
      public string NextToken() { return default(string); }
      public string NextToken(string delimiters) { return default(string); }
    }
  }
}
namespace Novell.Directory.Ldap {
  public enum AuthenticationTypes {
    Anonymous = 16,
    Delegation = 256,
    Encryption = 2,
    FastBind = 32,
    None = 0,
    ReadonlyServer = 4,
    Sealing = 128,
    Secure = 1,
    SecureSocketsLayer = 2,
    ServerBind = 512,
    Signing = 64,
  }
  public delegate bool CertificateValidationCallback(System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Int32[] certificateErrors);
  public partial class InterThreadException : Novell.Directory.Ldap.LdapException {
    internal InterThreadException() { }
  }
  public partial class LdapAbandonRequest : Novell.Directory.Ldap.LdapMessage {
    public LdapAbandonRequest(int id, Novell.Directory.Ldap.LdapControl[] cont) : base (default(Novell.Directory.Ldap.Rfc2251.RfcLdapMessage)) { }
  }
  public partial class LdapAddRequest : Novell.Directory.Ldap.LdapMessage {
    public LdapAddRequest(Novell.Directory.Ldap.LdapEntry entry, Novell.Directory.Ldap.LdapControl[] cont) : base (default(Novell.Directory.Ldap.Rfc2251.RfcLdapMessage)) { }
    public virtual Novell.Directory.Ldap.LdapEntry Entry { get { return default(Novell.Directory.Ldap.LdapEntry); } }
    public override string ToString() { return default(string); }
  }
  public partial class LdapAttribute : System.ICloneable, System.IComparable {
    public LdapAttribute(Novell.Directory.Ldap.LdapAttribute attr) { }
    public LdapAttribute(string attrName) { }
    [System.CLSCompliantAttribute(false)]
    public LdapAttribute(string attrName, System.SByte[] attrBytes) { }
    public LdapAttribute(string attrName, string attrString) { }
    public LdapAttribute(string attrName, System.String[] attrStrings) { }
    [System.CLSCompliantAttribute(false)]
    public virtual System.SByte[] ByteValue { get { return default(System.SByte[]); } }
    [System.CLSCompliantAttribute(false)]
    public virtual System.SByte[][] ByteValueArray { get { return default(System.SByte[][]); } }
    public virtual System.Collections.IEnumerator ByteValues { get { return default(System.Collections.IEnumerator); } }
    public virtual string LangSubtype { get { return default(string); } }
    public virtual string Name { get { return default(string); } }
    public virtual string StringValue { get { return default(string); } }
    public virtual System.String[] StringValueArray { get { return default(System.String[]); } }
    public virtual System.Collections.IEnumerator StringValues { get { return default(System.Collections.IEnumerator); } }
    protected internal virtual string Value { set { } }
    public virtual void addBase64Value(System.Char[] attrChars) { }
    public virtual void addBase64Value(string attrString) { }
    public virtual void addBase64Value(System.Text.StringBuilder attrString, int start, int end) { }
    public virtual void addURLValue(string url) { }
    public virtual void addURLValue(System.Uri url) { }
    [System.CLSCompliantAttribute(false)]
    public virtual void addValue(System.SByte[] attrBytes) { }
    public virtual void addValue(string attrString) { }
    public object Clone() { return default(object); }
    public virtual int CompareTo(object attribute) { return default(int); }
    public virtual string getBaseName() { return default(string); }
    public static string getBaseName(string attrName) { return default(string); }
    public virtual System.String[] getSubtypes() { return default(System.String[]); }
    public static System.String[] getSubtypes(string attrName) { return default(System.String[]); }
    public virtual bool hasSubtype(string subtype) { return default(bool); }
    public virtual bool hasSubtypes(System.String[] subtypes) { return default(bool); }
    [System.CLSCompliantAttribute(false)]
    public virtual void removeValue(System.SByte[] attrBytes) { }
    public virtual void removeValue(string attrString) { }
    public virtual int size() { return default(int); }
    public override string ToString() { return default(string); }
  }
  public partial class LdapAttributeSchema : Novell.Directory.Ldap.LdapSchemaElement {
    public const int DIRECTORY_OPERATION = 1;
    public const int DISTRIBUTED_OPERATION = 2;
    public const int DSA_OPERATION = 3;
    public const int USER_APPLICATIONS = 0;
    public LdapAttributeSchema(string raw) : base (default(string)) { }
    public LdapAttributeSchema(System.String[] names, string oid, string description, string syntaxString, bool single, string superior, bool obsolete, string equality, string ordering, string substring, bool collective, bool isUserModifiable, int usage) : base (default(string)) { }
    public virtual bool Collective { get { return default(bool); } }
    public virtual string EqualityMatchingRule { get { return default(string); } }
    public virtual string OrderingMatchingRule { get { return default(string); } }
    public virtual bool SingleValued { get { return default(bool); } }
    public virtual string SubstringMatchingRule { get { return default(string); } }
    public virtual string Superior { get { return default(string); } }
    public virtual string SyntaxString { get { return default(string); } }
    public virtual int Usage { get { return default(int); } }
    public virtual bool UserModifiable { get { return default(bool); } }
    protected internal override string formatString() { return default(string); }
  }
  public partial class LdapAttributeSet : SupportClass.AbstractSetSupport, System.ICloneable {
    public LdapAttributeSet() { }
    public override int Count { get { return default(int); } }
    public override bool Add(object attr) { return default(bool); }
    public override bool AddAll(System.Collections.ICollection c) { return default(bool); }
    public override void Clear() { }
    public override object Clone() { return default(object); }
    public override bool Contains(object attr) { return default(bool); }
    public virtual Novell.Directory.Ldap.LdapAttribute getAttribute(string attrName) { return default(Novell.Directory.Ldap.LdapAttribute); }
    public virtual Novell.Directory.Ldap.LdapAttribute getAttribute(string attrName, string lang) { return default(Novell.Directory.Ldap.LdapAttribute); }
    public override System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public virtual Novell.Directory.Ldap.LdapAttributeSet getSubset(string subtype) { return default(Novell.Directory.Ldap.LdapAttributeSet); }
    public override bool IsEmpty() { return default(bool); }
    public override bool Remove(object object_Renamed) { return default(bool); }
    public override string ToString() { return default(string); }
  }
  public partial interface LdapAuthHandler : Novell.Directory.Ldap.LdapReferralHandler {
    Novell.Directory.Ldap.LdapAuthProvider getAuthProvider(string host, int port);
  }
  public partial class LdapAuthProvider {
    [System.CLSCompliantAttribute(false)]
    public LdapAuthProvider(string dn, System.SByte[] password) { }
    public virtual string DN { get { return default(string); } }
    [System.CLSCompliantAttribute(false)]
    public virtual System.SByte[] Password { get { return default(System.SByte[]); } }
  }
  public partial interface LdapBindHandler : Novell.Directory.Ldap.LdapReferralHandler {
    Novell.Directory.Ldap.LdapConnection Bind(System.String[] ldapurl, Novell.Directory.Ldap.LdapConnection conn);
  }
  public partial class LdapBindRequest : Novell.Directory.Ldap.LdapMessage {
    [System.CLSCompliantAttribute(false)]
    public LdapBindRequest(int version, string dn, System.SByte[] passwd, Novell.Directory.Ldap.LdapControl[] cont) : base (default(Novell.Directory.Ldap.Rfc2251.RfcLdapMessage)) { }
    [System.CLSCompliantAttribute(false)]
    public LdapBindRequest(int version, string dn, string mechanism, System.SByte[] credentials, Novell.Directory.Ldap.LdapControl[] cont) : base (default(Novell.Directory.Ldap.Rfc2251.RfcLdapMessage)) { }
    public virtual string AuthenticationDN { get { return default(string); } }
    public override string ToString() { return default(string); }
  }
  public partial class LdapCompareAttrNames : System.Collections.IComparer {
    public LdapCompareAttrNames(string attrName) { }
    public LdapCompareAttrNames(string attrName, bool ascendingFlag) { }
    public LdapCompareAttrNames(System.String[] attrNames) { }
    public LdapCompareAttrNames(System.String[] attrNames, System.Boolean[] ascendingFlags) { }
    public virtual System.Globalization.CultureInfo Locale { get { return default(System.Globalization.CultureInfo); } set { } }
    public virtual int Compare(object object1, object object2) { return default(int); }
    public override bool Equals(object comparator) { return default(bool); }
  }
  public partial class LdapCompareRequest : Novell.Directory.Ldap.LdapMessage {
    [System.CLSCompliantAttribute(false)]
    public LdapCompareRequest(string dn, string name, System.SByte[] value_Renamed, Novell.Directory.Ldap.LdapControl[] cont) : base (default(Novell.Directory.Ldap.Rfc2251.RfcLdapMessage)) { }
    [System.CLSCompliantAttribute(false)]
    public virtual System.SByte[] AssertionValue { get { return default(System.SByte[]); } }
    public virtual string AttributeDescription { get { return default(string); } }
    public virtual string DN { get { return default(string); } }
  }
  public partial class LdapConnection : System.ICloneable {
    public const string ALL_USER_ATTRS = "*";
    public const int DEFAULT_PORT = 389;
    public const int DEFAULT_SSL_PORT = 636;
    public const string Ldap_PROPERTY_PROTOCOL = "version.protocol";
    public const string Ldap_PROPERTY_SDK = "version.sdk";
    public const string Ldap_PROPERTY_SECURITY = "version.security";
    public const int Ldap_V3 = 3;
    public const string NO_ATTRS = "1.1";
    public const int SCOPE_BASE = 0;
    public const int SCOPE_ONE = 1;
    public const int SCOPE_SUB = 2;
    public const string SERVER_SHUTDOWN_OID = "1.3.6.1.4.1.1466.20036";
    public LdapConnection() { }
    public virtual string AuthenticationDN { get { return default(string); } }
    public virtual string AuthenticationMethod { get { return default(string); } }
    public virtual bool Bound { get { return default(bool); } }
    public virtual bool Connected { get { return default(bool); } }
    public virtual Novell.Directory.Ldap.LdapConstraints Constraints { get { return default(Novell.Directory.Ldap.LdapConstraints); } set { } }
    public virtual string Host { get { return default(string); } }
    public virtual int Port { get { return default(int); } }
    public virtual int ProtocolVersion { get { return default(int); } }
    public virtual Novell.Directory.Ldap.LdapControl[] ResponseControls { get { return default(Novell.Directory.Ldap.LdapControl[]); } }
    public virtual object SaslBindCallbackHandler { get { return default(object); } }
    public virtual System.Collections.IDictionary SaslBindProperties { get { return default(System.Collections.IDictionary); } }
    public virtual Novell.Directory.Ldap.LdapSearchConstraints SearchConstraints { get { return default(Novell.Directory.Ldap.LdapSearchConstraints); } }
    public bool SecureSocketLayer { get { return default(bool); } set { } }
    public virtual bool TLS { get { return default(bool); } }
    public event Novell.Directory.Ldap.CertificateValidationCallback UserDefinedServerCertValidationDelegate { add { } remove { } }
    public virtual void Abandon(Novell.Directory.Ldap.LdapMessageQueue queue) { }
    public virtual void Abandon(Novell.Directory.Ldap.LdapMessageQueue queue, Novell.Directory.Ldap.LdapConstraints cons) { }
    public virtual void Abandon(Novell.Directory.Ldap.LdapSearchResults results) { }
    public virtual void Abandon(Novell.Directory.Ldap.LdapSearchResults results, Novell.Directory.Ldap.LdapConstraints cons) { }
    public virtual void Abandon(int id) { }
    public virtual void Abandon(int id, Novell.Directory.Ldap.LdapConstraints cons) { }
    public virtual void Add(Novell.Directory.Ldap.LdapEntry entry) { }
    public virtual void Add(Novell.Directory.Ldap.LdapEntry entry, Novell.Directory.Ldap.LdapConstraints cons) { }
    public virtual Novell.Directory.Ldap.LdapResponseQueue Add(Novell.Directory.Ldap.LdapEntry entry, Novell.Directory.Ldap.LdapResponseQueue queue) { return default(Novell.Directory.Ldap.LdapResponseQueue); }
    public virtual Novell.Directory.Ldap.LdapResponseQueue Add(Novell.Directory.Ldap.LdapEntry entry, Novell.Directory.Ldap.LdapResponseQueue queue, Novell.Directory.Ldap.LdapConstraints cons) { return default(Novell.Directory.Ldap.LdapResponseQueue); }
    public virtual void AddUnsolicitedNotificationListener(Novell.Directory.Ldap.LdapUnsolicitedNotificationListener listener) { }
    [System.CLSCompliantAttribute(false)]
    public virtual void Bind(int version, string dn, System.SByte[] passwd) { }
    [System.CLSCompliantAttribute(false)]
    public virtual void Bind(int version, string dn, System.SByte[] passwd, Novell.Directory.Ldap.LdapConstraints cons) { }
    [System.CLSCompliantAttribute(false)]
    public virtual Novell.Directory.Ldap.LdapResponseQueue Bind(int version, string dn, System.SByte[] passwd, Novell.Directory.Ldap.LdapResponseQueue queue) { return default(Novell.Directory.Ldap.LdapResponseQueue); }
    [System.CLSCompliantAttribute(false)]
    public virtual Novell.Directory.Ldap.LdapResponseQueue Bind(int version, string dn, System.SByte[] passwd, Novell.Directory.Ldap.LdapResponseQueue queue, Novell.Directory.Ldap.LdapConstraints cons, string mech) { return default(Novell.Directory.Ldap.LdapResponseQueue); }
    public virtual void Bind(int version, string dn, string passwd) { }
    public virtual void Bind(int version, string dn, string passwd, Novell.Directory.Ldap.LdapConstraints cons) { }
    public virtual void Bind(string dn, string passwd) { }
    public virtual void Bind(string dn, string passwd, Novell.Directory.Ldap.AuthenticationTypes authenticationTypes) { }
    public virtual void Bind(string dn, string passwd, Novell.Directory.Ldap.LdapConstraints cons) { }
    public object Clone() { return default(object); }
    public virtual bool Compare(string dn, Novell.Directory.Ldap.LdapAttribute attr) { return default(bool); }
    public virtual bool Compare(string dn, Novell.Directory.Ldap.LdapAttribute attr, Novell.Directory.Ldap.LdapConstraints cons) { return default(bool); }
    public virtual Novell.Directory.Ldap.LdapResponseQueue Compare(string dn, Novell.Directory.Ldap.LdapAttribute attr, Novell.Directory.Ldap.LdapResponseQueue queue) { return default(Novell.Directory.Ldap.LdapResponseQueue); }
    public virtual Novell.Directory.Ldap.LdapResponseQueue Compare(string dn, Novell.Directory.Ldap.LdapAttribute attr, Novell.Directory.Ldap.LdapResponseQueue queue, Novell.Directory.Ldap.LdapConstraints cons) { return default(Novell.Directory.Ldap.LdapResponseQueue); }
    public virtual void Connect(string host, int port) { }
    public virtual void Delete(string dn) { }
    public virtual void Delete(string dn, Novell.Directory.Ldap.LdapConstraints cons) { }
    public virtual Novell.Directory.Ldap.LdapResponseQueue Delete(string dn, Novell.Directory.Ldap.LdapResponseQueue queue) { return default(Novell.Directory.Ldap.LdapResponseQueue); }
    public virtual Novell.Directory.Ldap.LdapResponseQueue Delete(string dn, Novell.Directory.Ldap.LdapResponseQueue queue, Novell.Directory.Ldap.LdapConstraints cons) { return default(Novell.Directory.Ldap.LdapResponseQueue); }
    public virtual void Disconnect() { }
    public virtual void Disconnect(Novell.Directory.Ldap.LdapConstraints cons) { }
    public virtual Novell.Directory.Ldap.LdapExtendedResponse ExtendedOperation(Novell.Directory.Ldap.LdapExtendedOperation op) { return default(Novell.Directory.Ldap.LdapExtendedResponse); }
    public virtual Novell.Directory.Ldap.LdapExtendedResponse ExtendedOperation(Novell.Directory.Ldap.LdapExtendedOperation op, Novell.Directory.Ldap.LdapConstraints cons) { return default(Novell.Directory.Ldap.LdapExtendedResponse); }
    public virtual Novell.Directory.Ldap.LdapResponseQueue ExtendedOperation(Novell.Directory.Ldap.LdapExtendedOperation op, Novell.Directory.Ldap.LdapConstraints cons, Novell.Directory.Ldap.LdapResponseQueue queue) { return default(Novell.Directory.Ldap.LdapResponseQueue); }
    public virtual Novell.Directory.Ldap.LdapResponseQueue ExtendedOperation(Novell.Directory.Ldap.LdapExtendedOperation op, Novell.Directory.Ldap.LdapResponseQueue queue) { return default(Novell.Directory.Ldap.LdapResponseQueue); }
    public virtual Novell.Directory.Ldap.LdapSchema FetchSchema(string schemaDN) { return default(Novell.Directory.Ldap.LdapSchema); }
    ~LdapConnection() { }
    public virtual object getProperty(string name) { return default(object); }
    public virtual string GetSchemaDN() { return default(string); }
    public virtual string GetSchemaDN(string dn) { return default(string); }
    protected internal virtual Novell.Directory.Ldap.LdapMessage MakeExtendedOperation(Novell.Directory.Ldap.LdapExtendedOperation op, Novell.Directory.Ldap.LdapConstraints cons) { return default(Novell.Directory.Ldap.LdapMessage); }
    public virtual void Modify(string dn, Novell.Directory.Ldap.LdapModification mod) { }
    public virtual void Modify(string dn, Novell.Directory.Ldap.LdapModification mod, Novell.Directory.Ldap.LdapConstraints cons) { }
    public virtual Novell.Directory.Ldap.LdapResponseQueue Modify(string dn, Novell.Directory.Ldap.LdapModification mod, Novell.Directory.Ldap.LdapResponseQueue queue) { return default(Novell.Directory.Ldap.LdapResponseQueue); }
    public virtual Novell.Directory.Ldap.LdapResponseQueue Modify(string dn, Novell.Directory.Ldap.LdapModification mod, Novell.Directory.Ldap.LdapResponseQueue queue, Novell.Directory.Ldap.LdapConstraints cons) { return default(Novell.Directory.Ldap.LdapResponseQueue); }
    public virtual void Modify(string dn, Novell.Directory.Ldap.LdapModification[] mods) { }
    public virtual void Modify(string dn, Novell.Directory.Ldap.LdapModification[] mods, Novell.Directory.Ldap.LdapConstraints cons) { }
    public virtual Novell.Directory.Ldap.LdapResponseQueue Modify(string dn, Novell.Directory.Ldap.LdapModification[] mods, Novell.Directory.Ldap.LdapResponseQueue queue) { return default(Novell.Directory.Ldap.LdapResponseQueue); }
    public virtual Novell.Directory.Ldap.LdapResponseQueue Modify(string dn, Novell.Directory.Ldap.LdapModification[] mods, Novell.Directory.Ldap.LdapResponseQueue queue, Novell.Directory.Ldap.LdapConstraints cons) { return default(Novell.Directory.Ldap.LdapResponseQueue); }
    public static Novell.Directory.Ldap.LdapEntry Read(Novell.Directory.Ldap.LdapUrl toGet) { return default(Novell.Directory.Ldap.LdapEntry); }
    public static Novell.Directory.Ldap.LdapEntry Read(Novell.Directory.Ldap.LdapUrl toGet, Novell.Directory.Ldap.LdapSearchConstraints cons) { return default(Novell.Directory.Ldap.LdapEntry); }
    public virtual Novell.Directory.Ldap.LdapEntry Read(string dn) { return default(Novell.Directory.Ldap.LdapEntry); }
    public virtual Novell.Directory.Ldap.LdapEntry Read(string dn, Novell.Directory.Ldap.LdapSearchConstraints cons) { return default(Novell.Directory.Ldap.LdapEntry); }
    public virtual Novell.Directory.Ldap.LdapEntry Read(string dn, System.String[] attrs) { return default(Novell.Directory.Ldap.LdapEntry); }
    public virtual Novell.Directory.Ldap.LdapEntry Read(string dn, System.String[] attrs, Novell.Directory.Ldap.LdapSearchConstraints cons) { return default(Novell.Directory.Ldap.LdapEntry); }
    public virtual void RemoveUnsolicitedNotificationListener(Novell.Directory.Ldap.LdapUnsolicitedNotificationListener listener) { }
    public virtual void Rename(string dn, string newRdn, bool deleteOldRdn) { }
    public virtual void Rename(string dn, string newRdn, bool deleteOldRdn, Novell.Directory.Ldap.LdapConstraints cons) { }
    public virtual Novell.Directory.Ldap.LdapResponseQueue Rename(string dn, string newRdn, bool deleteOldRdn, Novell.Directory.Ldap.LdapResponseQueue queue) { return default(Novell.Directory.Ldap.LdapResponseQueue); }
    public virtual Novell.Directory.Ldap.LdapResponseQueue Rename(string dn, string newRdn, bool deleteOldRdn, Novell.Directory.Ldap.LdapResponseQueue queue, Novell.Directory.Ldap.LdapConstraints cons) { return default(Novell.Directory.Ldap.LdapResponseQueue); }
    public virtual void Rename(string dn, string newRdn, string newParentdn, bool deleteOldRdn) { }
    public virtual void Rename(string dn, string newRdn, string newParentdn, bool deleteOldRdn, Novell.Directory.Ldap.LdapConstraints cons) { }
    public virtual Novell.Directory.Ldap.LdapResponseQueue Rename(string dn, string newRdn, string newParentdn, bool deleteOldRdn, Novell.Directory.Ldap.LdapResponseQueue queue) { return default(Novell.Directory.Ldap.LdapResponseQueue); }
    public virtual Novell.Directory.Ldap.LdapResponseQueue Rename(string dn, string newRdn, string newParentdn, bool deleteOldRdn, Novell.Directory.Ldap.LdapResponseQueue queue, Novell.Directory.Ldap.LdapConstraints cons) { return default(Novell.Directory.Ldap.LdapResponseQueue); }
    public static Novell.Directory.Ldap.LdapSearchResults Search(Novell.Directory.Ldap.LdapUrl toGet) { return default(Novell.Directory.Ldap.LdapSearchResults); }
    public static Novell.Directory.Ldap.LdapSearchResults Search(Novell.Directory.Ldap.LdapUrl toGet, Novell.Directory.Ldap.LdapSearchConstraints cons) { return default(Novell.Directory.Ldap.LdapSearchResults); }
    public virtual Novell.Directory.Ldap.LdapSearchResults Search(string base_Renamed, int scope, string filter, System.String[] attrs, bool typesOnly) { return default(Novell.Directory.Ldap.LdapSearchResults); }
    public virtual Novell.Directory.Ldap.LdapSearchResults Search(string base_Renamed, int scope, string filter, System.String[] attrs, bool typesOnly, Novell.Directory.Ldap.LdapSearchConstraints cons) { return default(Novell.Directory.Ldap.LdapSearchResults); }
    public virtual Novell.Directory.Ldap.LdapSearchQueue Search(string base_Renamed, int scope, string filter, System.String[] attrs, bool typesOnly, Novell.Directory.Ldap.LdapSearchQueue queue) { return default(Novell.Directory.Ldap.LdapSearchQueue); }
    public virtual Novell.Directory.Ldap.LdapSearchQueue Search(string base_Renamed, int scope, string filter, System.String[] attrs, bool typesOnly, Novell.Directory.Ldap.LdapSearchQueue queue, Novell.Directory.Ldap.LdapSearchConstraints cons) { return default(Novell.Directory.Ldap.LdapSearchQueue); }
    public virtual Novell.Directory.Ldap.LdapMessageQueue SendRequest(Novell.Directory.Ldap.LdapMessage request, Novell.Directory.Ldap.LdapMessageQueue queue) { return default(Novell.Directory.Ldap.LdapMessageQueue); }
    public virtual Novell.Directory.Ldap.LdapMessageQueue SendRequest(Novell.Directory.Ldap.LdapMessage request, Novell.Directory.Ldap.LdapMessageQueue queue, Novell.Directory.Ldap.LdapConstraints cons) { return default(Novell.Directory.Ldap.LdapMessageQueue); }
    public virtual void startTLS() { }
    public virtual void stopTLS() { }
  }
  public partial class LdapConstraints : System.ICloneable {
    public LdapConstraints() { }
    public LdapConstraints(int msLimit, bool doReferrals, Novell.Directory.Ldap.LdapReferralHandler handler, int hop_limit) { }
    public virtual int HopLimit { get { return default(int); } set { } }
    public virtual bool ReferralFollowing { get { return default(bool); } set { } }
    public virtual int TimeLimit { get { return default(int); } set { } }
    public object Clone() { return default(object); }
    public virtual Novell.Directory.Ldap.LdapControl[] getControls() { return default(Novell.Directory.Ldap.LdapControl[]); }
    public virtual object getProperty(string name) { return default(object); }
    public virtual void setControls(Novell.Directory.Ldap.LdapControl control) { }
    public virtual void setControls(Novell.Directory.Ldap.LdapControl[] controls) { }
    public virtual void setProperty(string name, object value_Renamed) { }
    public virtual void setReferralHandler(Novell.Directory.Ldap.LdapReferralHandler handler) { }
  }
  public partial class LdapControl : System.ICloneable {
    protected internal LdapControl(Novell.Directory.Ldap.Rfc2251.RfcControl control) { }
    [System.CLSCompliantAttribute(false)]
    public LdapControl(string oid, bool critical, System.SByte[] values) { }
    public virtual bool Critical { get { return default(bool); } }
    public virtual string ID { get { return default(string); } }
    public object Clone() { return default(object); }
    [System.CLSCompliantAttribute(false)]
    public virtual System.SByte[] getValue() { return default(System.SByte[]); }
    public static void register(string oid, System.Type controlClass) { }
    [System.CLSCompliantAttribute(false)]
    protected internal virtual void setValue(System.SByte[] controlValue) { }
  }
  public partial class LdapDeleteRequest : Novell.Directory.Ldap.LdapMessage {
    public LdapDeleteRequest(string dn, Novell.Directory.Ldap.LdapControl[] cont) : base (default(Novell.Directory.Ldap.Rfc2251.RfcLdapMessage)) { }
    public virtual string DN { get { return default(string); } }
    public override string ToString() { return default(string); }
  }
  public partial class LdapDITContentRuleSchema : Novell.Directory.Ldap.LdapSchemaElement {
    public LdapDITContentRuleSchema(string raw) : base (default(string)) { }
    public LdapDITContentRuleSchema(System.String[] names, string oid, string description, bool obsolete, System.String[] auxiliary, System.String[] required, System.String[] optional, System.String[] precluded) : base (default(string)) { }
    public virtual System.String[] AuxiliaryClasses { get { return default(System.String[]); } }
    public virtual System.String[] OptionalAttributes { get { return default(System.String[]); } }
    public virtual System.String[] PrecludedAttributes { get { return default(System.String[]); } }
    public virtual System.String[] RequiredAttributes { get { return default(System.String[]); } }
    protected internal override string formatString() { return default(string); }
  }
  public partial class LdapDITStructureRuleSchema : Novell.Directory.Ldap.LdapSchemaElement {
    public LdapDITStructureRuleSchema(string raw) : base (default(string)) { }
    public LdapDITStructureRuleSchema(System.String[] names, int ruleID, string description, bool obsolete, string nameForm, System.String[] superiorIDs) : base (default(string)) { }
    public virtual string NameForm { get { return default(string); } }
    public virtual int RuleID { get { return default(int); } }
    public virtual System.String[] Superiors { get { return default(System.String[]); } }
    protected internal override string formatString() { return default(string); }
  }
  public partial class LdapDN {
    public LdapDN() { }
    [System.CLSCompliantAttribute(false)]
    public static bool equals(string dn1, string dn2) { return default(bool); }
    public static string escapeRDN(string rdn) { return default(string); }
    public static System.String[] explodeDN(string dn, bool noTypes) { return default(System.String[]); }
    public static System.String[] explodeRDN(string rdn, bool noTypes) { return default(System.String[]); }
    public static bool isValid(string dn) { return default(bool); }
    public static string normalize(string dn) { return default(string); }
    public static string unescapeRDN(string rdn) { return default(string); }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Size=1)]
  public partial struct LdapDSConstants {
    public static readonly int LDAP_DS_40X_REFERENCE_ENTRY;
    public static readonly int LDAP_DS_ALIAS_ENTRY;
    public static readonly long LDAP_DS_ATTR_COMPARE;
    public static readonly long LDAP_DS_ATTR_INHERIT_CTL;
    public static readonly long LDAP_DS_ATTR_READ;
    public static readonly long LDAP_DS_ATTR_SELF;
    public static readonly long LDAP_DS_ATTR_SUPERVISOR;
    public static readonly long LDAP_DS_ATTR_WRITE;
    public static readonly int LDAP_DS_AUDITED;
    public static readonly int LDAP_DS_BACKLINKED;
    public static readonly int LDAP_DS_CONTAINER_ALIAS;
    public static readonly int LDAP_DS_CONTAINER_ENTRY;
    public static readonly long LDAP_DS_DYNAMIC_ACL;
    public static readonly long LDAP_DS_ENTRY_ADD;
    public static readonly long LDAP_DS_ENTRY_BROWSE;
    public static readonly int LDAP_DS_ENTRY_DAMAGED;
    public static readonly long LDAP_DS_ENTRY_DELETE;
    public static readonly long LDAP_DS_ENTRY_INHERIT_CTL;
    public static readonly int LDAP_DS_ENTRY_NOT_PRESENT;
    public static readonly long LDAP_DS_ENTRY_RENAME;
    public static readonly long LDAP_DS_ENTRY_SUPERVISOR;
    public static readonly int LDAP_DS_ENTRY_VERIFY_CTS;
    public static readonly int LDAP_DS_MATCHES_LIST_FILTER;
    public static readonly int LDAP_DS_NEW_ENTRY;
    public static readonly int LDAP_DS_PARTITION_ROOT;
    public static readonly int LDAP_DS_REFERENCE_ENTRY;
    public static readonly int LDAP_DS_TEMPORARY_REFERENCE;
  }
  public partial class LdapEntry : System.IComparable {
    protected internal Novell.Directory.Ldap.LdapAttributeSet attrs;
    protected internal string dn;
    public LdapEntry() { }
    public LdapEntry(string dn) { }
    public LdapEntry(string dn, Novell.Directory.Ldap.LdapAttributeSet attrs) { }
    [System.CLSCompliantAttribute(false)]
    public virtual string DN { get { return default(string); } }
    public virtual int CompareTo(object entry) { return default(int); }
    public virtual Novell.Directory.Ldap.LdapAttribute getAttribute(string attrName) { return default(Novell.Directory.Ldap.LdapAttribute); }
    public virtual Novell.Directory.Ldap.LdapAttributeSet getAttributeSet() { return default(Novell.Directory.Ldap.LdapAttributeSet); }
    public virtual Novell.Directory.Ldap.LdapAttributeSet getAttributeSet(string subtype) { return default(Novell.Directory.Ldap.LdapAttributeSet); }
    public override string ToString() { return default(string); }
  }
  public partial class LdapException : System.Exception {
    public const int ADMIN_LIMIT_EXCEEDED = 11;
    public const int AFFECTS_MULTIPLE_DSAS = 71;
    public const int ALIAS_DEREFERENCING_PROBLEM = 36;
    public const int ALIAS_PROBLEM = 33;
    public const int AMBIGUOUS_RESPONSE = 101;
    public const int ATTRIBUTE_OR_VALUE_EXISTS = 20;
    public const int AUTH_METHOD_NOT_SUPPORTED = 7;
    public const int AUTH_UNKNOWN = 86;
    public const int BUSY = 51;
    public const int CLIENT_LOOP = 96;
    public const int COMPARE_FALSE = 5;
    public const int COMPARE_TRUE = 6;
    public const int CONFIDENTIALITY_REQUIRED = 13;
    public const int CONNECT_ERROR = 91;
    public const int CONSTRAINT_VIOLATION = 19;
    public const int CONTROL_NOT_FOUND = 93;
    public const int DECODING_ERROR = 84;
    public const int ENCODING_ERROR = 83;
    public const int ENTRY_ALREADY_EXISTS = 68;
    public const int FILTER_ERROR = 87;
    public const int INAPPROPRIATE_AUTHENTICATION = 48;
    public const int INAPPROPRIATE_MATCHING = 18;
    public const int INSUFFICIENT_ACCESS_RIGHTS = 50;
    public const int INVALID_ATTRIBUTE_SYNTAX = 21;
    public const int INVALID_CREDENTIALS = 49;
    public const int INVALID_DN_SYNTAX = 34;
    public const int INVALID_RESPONSE = 100;
    public const int IS_LEAF = 35;
    public const int Ldap_NOT_SUPPORTED = 92;
    public const int Ldap_PARTIAL_RESULTS = 9;
    public const int Ldap_TIMEOUT = 85;
    public const int LOCAL_ERROR = 82;
    public const int LOOP_DETECT = 54;
    public const int MORE_RESULTS_TO_RETURN = 95;
    public const int NAMING_VIOLATION = 64;
    public const int NO_MEMORY = 90;
    public const int NO_RESULTS_RETURNED = 94;
    public const int NO_SUCH_ATTRIBUTE = 16;
    public const int NO_SUCH_OBJECT = 32;
    public const int NOT_ALLOWED_ON_NONLEAF = 66;
    public const int NOT_ALLOWED_ON_RDN = 67;
    public const int OBJECT_CLASS_MODS_PROHIBITED = 69;
    public const int OBJECT_CLASS_VIOLATION = 65;
    public const int OPERATIONS_ERROR = 1;
    public const int OTHER = 80;
    public const int PROTOCOL_ERROR = 2;
    public const int REFERRAL = 10;
    public const int REFERRAL_LIMIT_EXCEEDED = 97;
    public const int SASL_BIND_IN_PROGRESS = 14;
    public const int SERVER_DOWN = 81;
    public const int SIZE_LIMIT_EXCEEDED = 4;
    public const int SSL_HANDSHAKE_FAILED = 113;
    public const int SSL_PROVIDER_NOT_FOUND = 114;
    public const int STRONG_AUTH_REQUIRED = 8;
    public const int SUCCESS = 0;
    public const int TIME_LIMIT_EXCEEDED = 3;
    public const int TLS_NOT_SUPPORTED = 112;
    public const int UNAVAILABLE = 52;
    public const int UNAVAILABLE_CRITICAL_EXTENSION = 12;
    public const int UNDEFINED_ATTRIBUTE_TYPE = 17;
    public const int UNWILLING_TO_PERFORM = 53;
    public const int USER_CANCELLED = 88;
    public LdapException() { }
    public LdapException(string messageOrKey, int resultCode, string serverMsg) { }
    public LdapException(string messageOrKey, int resultCode, string serverMsg, System.Exception rootException) { }
    public LdapException(string messageOrKey, int resultCode, string serverMsg, string matchedDN) { }
    public LdapException(string messageOrKey, System.Object[] arguments, int resultCode, string serverMsg) { }
    public LdapException(string messageOrKey, System.Object[] arguments, int resultCode, string serverMsg, System.Exception rootException) { }
    public LdapException(string messageOrKey, System.Object[] arguments, int resultCode, string serverMsg, string matchedDN) { }
    public virtual System.Exception Cause { get { return default(System.Exception); } }
    public virtual string LdapErrorMessage { get { return default(string); } }
    public virtual string MatchedDN { get { return default(string); } }
    public override string Message { get { return default(string); } }
    public virtual int ResultCode { get { return default(int); } }
    public virtual string resultCodeToString() { return default(string); }
    public virtual string resultCodeToString(System.Globalization.CultureInfo locale) { return default(string); }
    public static string resultCodeToString(int code) { return default(string); }
    public static string resultCodeToString(int code, System.Globalization.CultureInfo locale) { return default(string); }
    public override string ToString() { return default(string); }
  }
  public partial class LdapExtendedOperation : System.ICloneable {
    [System.CLSCompliantAttribute(false)]
    public LdapExtendedOperation(string oid, System.SByte[] vals) { }
    public object Clone() { return default(object); }
    public virtual string getID() { return default(string); }
    [System.CLSCompliantAttribute(false)]
    public virtual System.SByte[] getValue() { return default(System.SByte[]); }
    protected internal virtual void setID(string newoid) { }
    [System.CLSCompliantAttribute(false)]
    protected internal virtual void setValue(System.SByte[] newVals) { }
  }
  public partial class LdapExtendedRequest : Novell.Directory.Ldap.LdapMessage {
    public LdapExtendedRequest(Novell.Directory.Ldap.LdapExtendedOperation op, Novell.Directory.Ldap.LdapControl[] cont) : base (default(Novell.Directory.Ldap.Rfc2251.RfcLdapMessage)) { }
    public virtual Novell.Directory.Ldap.LdapExtendedOperation ExtendedOperation { get { return default(Novell.Directory.Ldap.LdapExtendedOperation); } }
  }
  public partial class LdapExtendedResponse : Novell.Directory.Ldap.LdapResponse {
    public LdapExtendedResponse(Novell.Directory.Ldap.Rfc2251.RfcLdapMessage message) : base (default(Novell.Directory.Ldap.InterThreadException), default(Novell.Directory.Ldap.Utilclass.ReferralInfo)) { }
    public virtual string ID { get { return default(string); } }
    public static Novell.Directory.Ldap.Utilclass.RespExtensionSet RegisteredResponses { get { return default(Novell.Directory.Ldap.Utilclass.RespExtensionSet); } }
    [System.CLSCompliantAttribute(false)]
    public virtual System.SByte[] Value { get { return default(System.SByte[]); } }
    public static void register(string oid, System.Type extendedResponseClass) { }
  }
  public partial class LdapIntermediateResponse : Novell.Directory.Ldap.LdapResponse {
    public LdapIntermediateResponse(Novell.Directory.Ldap.Rfc2251.RfcLdapMessage message) : base (default(Novell.Directory.Ldap.InterThreadException), default(Novell.Directory.Ldap.Utilclass.ReferralInfo)) { }
    public string getID() { return default(string); }
    public static Novell.Directory.Ldap.Utilclass.RespExtensionSet getRegisteredResponses() { return default(Novell.Directory.Ldap.Utilclass.RespExtensionSet); }
    [System.CLSCompliantAttribute(false)]
    public System.SByte[] getValue() { return default(System.SByte[]); }
    public static void register(string oid, System.Type extendedResponseClass) { }
  }
  public partial class LdapLocalException : Novell.Directory.Ldap.LdapException {
    public LdapLocalException() { }
    public LdapLocalException(string messageOrKey, int resultCode) { }
    public LdapLocalException(string messageOrKey, int resultCode, System.Exception rootException) { }
    public LdapLocalException(string messageOrKey, System.Object[] arguments, int resultCode) { }
    public LdapLocalException(string messageOrKey, System.Object[] arguments, int resultCode, System.Exception rootException) { }
    public override string ToString() { return default(string); }
  }
  public partial class LdapMatchingRuleSchema : Novell.Directory.Ldap.LdapSchemaElement {
    public LdapMatchingRuleSchema(string rawMatchingRule, string rawMatchingRuleUse) : base (default(string)) { }
    public LdapMatchingRuleSchema(System.String[] names, string oid, string description, System.String[] attributes, bool obsolete, string syntaxString) : base (default(string)) { }
    public virtual System.String[] Attributes { get { return default(System.String[]); } }
    public virtual string SyntaxString { get { return default(string); } }
    protected internal override string formatString() { return default(string); }
  }
  public partial class LdapMatchingRuleUseSchema : Novell.Directory.Ldap.LdapSchemaElement {
    public LdapMatchingRuleUseSchema(string raw) : base (default(string)) { }
    public LdapMatchingRuleUseSchema(System.String[] names, string oid, string description, bool obsolete, System.String[] attributes) : base (default(string)) { }
    public virtual System.String[] Attributes { get { return default(System.String[]); } }
    protected internal override string formatString() { return default(string); }
  }
  public partial class LdapMessage {
    public const int ABANDON_REQUEST = 16;
    public const int ADD_REQUEST = 8;
    public const int ADD_RESPONSE = 9;
    public const int BIND_REQUEST = 0;
    public const int BIND_RESPONSE = 1;
    public const int COMPARE_REQUEST = 14;
    public const int COMPARE_RESPONSE = 15;
    public const int DEL_REQUEST = 10;
    public const int DEL_RESPONSE = 11;
    public const int EXTENDED_REQUEST = 23;
    public const int EXTENDED_RESPONSE = 24;
    public const int INTERMEDIATE_RESPONSE = 25;
    protected internal Novell.Directory.Ldap.Rfc2251.RfcLdapMessage message;
    public const int MODIFY_RDN_REQUEST = 12;
    public const int MODIFY_RDN_RESPONSE = 13;
    public const int MODIFY_REQUEST = 6;
    public const int MODIFY_RESPONSE = 7;
    public const int SEARCH_REQUEST = 3;
    public const int SEARCH_RESPONSE = 4;
    public const int SEARCH_RESULT = 5;
    public const int SEARCH_RESULT_REFERENCE = 19;
    public const int UNBIND_REQUEST = 2;
    protected internal LdapMessage(Novell.Directory.Ldap.Rfc2251.RfcLdapMessage message) { }
    public virtual Novell.Directory.Ldap.LdapControl[] Controls { get { return default(Novell.Directory.Ldap.LdapControl[]); } }
    public virtual int MessageID { get { return default(int); } }
    public virtual bool Request { get { return default(bool); } }
    public virtual string Tag { get { return default(string); } set { } }
    public virtual int Type { get { return default(int); } }
    public override string ToString() { return default(string); }
  }
  public abstract partial class LdapMessageQueue {
    internal LdapMessageQueue() { }
    public virtual System.Int32[] MessageIDs { get { return default(System.Int32[]); } }
    public virtual Novell.Directory.Ldap.LdapMessage getResponse() { return default(Novell.Directory.Ldap.LdapMessage); }
    public virtual Novell.Directory.Ldap.LdapMessage getResponse(int msgid) { return default(Novell.Directory.Ldap.LdapMessage); }
    public virtual bool isComplete(int msgid) { return default(bool); }
    public virtual bool isResponseReceived() { return default(bool); }
    public virtual bool isResponseReceived(int msgid) { return default(bool); }
  }
  public partial class LdapModification {
    public const int ADD = 0;
    public const int DELETE = 1;
    public const int REPLACE = 2;
    public LdapModification(int op, Novell.Directory.Ldap.LdapAttribute attr) { }
    public virtual Novell.Directory.Ldap.LdapAttribute Attribute { get { return default(Novell.Directory.Ldap.LdapAttribute); } }
    public virtual int Op { get { return default(int); } }
  }
  public partial class LdapModifyDNRequest : Novell.Directory.Ldap.LdapMessage {
    public LdapModifyDNRequest(string dn, string newRdn, string newParentdn, bool deleteOldRdn, Novell.Directory.Ldap.LdapControl[] cont) : base (default(Novell.Directory.Ldap.Rfc2251.RfcLdapMessage)) { }
    public virtual bool DeleteOldRDN { get { return default(bool); } }
    public virtual string DN { get { return default(string); } }
    public virtual string NewRDN { get { return default(string); } }
    public virtual string ParentDN { get { return default(string); } }
    public override string ToString() { return default(string); }
  }
  public partial class LdapModifyRequest : Novell.Directory.Ldap.LdapMessage {
    public LdapModifyRequest(string dn, Novell.Directory.Ldap.LdapModification[] mods, Novell.Directory.Ldap.LdapControl[] cont) : base (default(Novell.Directory.Ldap.Rfc2251.RfcLdapMessage)) { }
    public virtual string DN { get { return default(string); } }
    public virtual Novell.Directory.Ldap.LdapModification[] Modifications { get { return default(Novell.Directory.Ldap.LdapModification[]); } }
    public override string ToString() { return default(string); }
  }
  public partial class LdapNameFormSchema : Novell.Directory.Ldap.LdapSchemaElement {
    public LdapNameFormSchema(string raw) : base (default(string)) { }
    public LdapNameFormSchema(System.String[] names, string oid, string description, bool obsolete, string objectClass, System.String[] required, System.String[] optional) : base (default(string)) { }
    public virtual string ObjectClass { get { return default(string); } }
    public virtual System.String[] OptionalNamingAttributes { get { return default(System.String[]); } }
    public virtual System.String[] RequiredNamingAttributes { get { return default(System.String[]); } }
    protected internal override string formatString() { return default(string); }
  }
  public partial class LdapObjectClassSchema : Novell.Directory.Ldap.LdapSchemaElement {
    public const int ABSTRACT = 0;
    public const int AUXILIARY = 2;
    public const int STRUCTURAL = 1;
    public LdapObjectClassSchema(string raw) : base (default(string)) { }
    public LdapObjectClassSchema(System.String[] names, string oid, System.String[] superiors, string description, System.String[] required, System.String[] optional, int type, bool obsolete) : base (default(string)) { }
    public virtual System.String[] OptionalAttributes { get { return default(System.String[]); } }
    public virtual System.String[] RequiredAttributes { get { return default(System.String[]); } }
    public virtual System.String[] Superiors { get { return default(System.String[]); } }
    public virtual int Type { get { return default(int); } }
    protected internal override string formatString() { return default(string); }
  }
  public partial class LdapReferralException : Novell.Directory.Ldap.LdapException {
    public LdapReferralException() { }
    public LdapReferralException(string message) { }
    public LdapReferralException(string message, System.Exception rootException) { }
    public LdapReferralException(string message, int resultCode, string serverMessage) { }
    public LdapReferralException(string message, int resultCode, string serverMessage, System.Exception rootException) { }
    public LdapReferralException(string message, System.Object[] arguments) { }
    public LdapReferralException(string message, System.Object[] arguments, System.Exception rootException) { }
    public LdapReferralException(string message, System.Object[] arguments, int resultCode, string serverMessage) { }
    public LdapReferralException(string message, System.Object[] arguments, int resultCode, string serverMessage, System.Exception rootException) { }
    public virtual string FailedReferral { get { return default(string); } set { } }
    public virtual System.String[] getReferrals() { return default(System.String[]); }
    public override string ToString() { return default(string); }
  }
  public partial interface LdapReferralHandler {
  }
  public partial class LdapResponse : Novell.Directory.Ldap.LdapMessage {
    public LdapResponse(Novell.Directory.Ldap.InterThreadException ex, Novell.Directory.Ldap.Utilclass.ReferralInfo activeReferral) : base (default(Novell.Directory.Ldap.Rfc2251.RfcLdapMessage)) { }
    public LdapResponse(int type) : base (default(Novell.Directory.Ldap.Rfc2251.RfcLdapMessage)) { }
    public LdapResponse(int type, int resultCode, string matchedDN, string serverMessage, System.String[] referrals, Novell.Directory.Ldap.LdapControl[] controls) : base (default(Novell.Directory.Ldap.Rfc2251.RfcLdapMessage)) { }
    public override Novell.Directory.Ldap.LdapControl[] Controls { get { return default(Novell.Directory.Ldap.LdapControl[]); } }
    public virtual string ErrorMessage { get { return default(string); } }
    public virtual string MatchedDN { get { return default(string); } }
    public override int MessageID { get { return default(int); } }
    public virtual System.String[] Referrals { get { return default(System.String[]); } }
    public virtual int ResultCode { get { return default(int); } }
    public override int Type { get { return default(int); } }
  }
  public partial class LdapResponseQueue : Novell.Directory.Ldap.LdapMessageQueue {
    internal LdapResponseQueue() { }
    public virtual void merge(Novell.Directory.Ldap.LdapMessageQueue queue2) { }
  }
  public partial class LdapSchema : Novell.Directory.Ldap.LdapEntry {
    public LdapSchema(Novell.Directory.Ldap.LdapEntry ent) { }
    public virtual System.Collections.IEnumerator AttributeNames { get { return default(System.Collections.IEnumerator); } }
    public virtual System.Collections.IEnumerator AttributeSchemas { get { return default(System.Collections.IEnumerator); } }
    public virtual System.Collections.IEnumerator DITContentRuleNames { get { return default(System.Collections.IEnumerator); } }
    public virtual System.Collections.IEnumerator DITContentRuleSchemas { get { return default(System.Collections.IEnumerator); } }
    public virtual System.Collections.IEnumerator DITStructureRuleNames { get { return default(System.Collections.IEnumerator); } }
    public virtual System.Collections.IEnumerator DITStructureRuleSchemas { get { return default(System.Collections.IEnumerator); } }
    public virtual System.Collections.IEnumerator MatchingRuleNames { get { return default(System.Collections.IEnumerator); } }
    public virtual System.Collections.IEnumerator MatchingRuleSchemas { get { return default(System.Collections.IEnumerator); } }
    public virtual System.Collections.IEnumerator MatchingRuleUseNames { get { return default(System.Collections.IEnumerator); } }
    public virtual System.Collections.IEnumerator MatchingRuleUseSchemas { get { return default(System.Collections.IEnumerator); } }
    public virtual System.Collections.IEnumerator NameFormNames { get { return default(System.Collections.IEnumerator); } }
    public virtual System.Collections.IEnumerator NameFormSchemas { get { return default(System.Collections.IEnumerator); } }
    public virtual System.Collections.IEnumerator ObjectClassNames { get { return default(System.Collections.IEnumerator); } }
    public virtual System.Collections.IEnumerator ObjectClassSchemas { get { return default(System.Collections.IEnumerator); } }
    public virtual System.Collections.IEnumerator SyntaxSchemas { get { return default(System.Collections.IEnumerator); } }
    public virtual Novell.Directory.Ldap.LdapAttributeSchema getAttributeSchema(string name) { return default(Novell.Directory.Ldap.LdapAttributeSchema); }
    public virtual Novell.Directory.Ldap.LdapDITContentRuleSchema getDITContentRuleSchema(string name) { return default(Novell.Directory.Ldap.LdapDITContentRuleSchema); }
    public virtual Novell.Directory.Ldap.LdapDITStructureRuleSchema getDITStructureRuleSchema(int ID) { return default(Novell.Directory.Ldap.LdapDITStructureRuleSchema); }
    public virtual Novell.Directory.Ldap.LdapDITStructureRuleSchema getDITStructureRuleSchema(string name) { return default(Novell.Directory.Ldap.LdapDITStructureRuleSchema); }
    public virtual Novell.Directory.Ldap.LdapMatchingRuleSchema getMatchingRuleSchema(string name) { return default(Novell.Directory.Ldap.LdapMatchingRuleSchema); }
    public virtual Novell.Directory.Ldap.LdapMatchingRuleUseSchema getMatchingRuleUseSchema(string name) { return default(Novell.Directory.Ldap.LdapMatchingRuleUseSchema); }
    public virtual Novell.Directory.Ldap.LdapNameFormSchema getNameFormSchema(string name) { return default(Novell.Directory.Ldap.LdapNameFormSchema); }
    public virtual Novell.Directory.Ldap.LdapObjectClassSchema getObjectClassSchema(string name) { return default(Novell.Directory.Ldap.LdapObjectClassSchema); }
    public virtual Novell.Directory.Ldap.LdapSyntaxSchema getSyntaxSchema(string oid) { return default(Novell.Directory.Ldap.LdapSyntaxSchema); }
  }
  public abstract partial class LdapSchemaElement : Novell.Directory.Ldap.LdapAttribute {
    [System.CLSCompliantAttribute(false)]
    protected internal string description;
    protected internal System.Collections.Hashtable hashQualifier;
    [System.CLSCompliantAttribute(false)]
    protected internal System.String[] names;
    [System.CLSCompliantAttribute(false)]
    protected internal bool obsolete;
    protected internal string oid;
    protected internal System.String[] qualifier;
    protected internal LdapSchemaElement(string attrName) : base (default(Novell.Directory.Ldap.LdapAttribute)) { }
    public virtual string Description { get { return default(string); } }
    public virtual string ID { get { return default(string); } }
    public virtual System.String[] Names { get { return default(System.String[]); } }
    public virtual bool Obsolete { get { return default(bool); } }
    public virtual System.Collections.IEnumerator QualifierNames { get { return default(System.Collections.IEnumerator); } }
    public virtual void addValue(System.Byte[] value_Renamed) { }
    public override void addValue(string value_Renamed) { }
    protected internal abstract string formatString();
    public virtual System.String[] getQualifier(string name) { return default(System.String[]); }
    public virtual void removeValue(System.Byte[] value_Renamed) { }
    public override void removeValue(string value_Renamed) { }
    public virtual void setQualifier(string name, System.String[] values) { }
    public override string ToString() { return default(string); }
  }
  public partial class LdapSearchConstraints : Novell.Directory.Ldap.LdapConstraints {
    public const int DEREF_ALWAYS = 3;
    public const int DEREF_FINDING = 2;
    public const int DEREF_NEVER = 0;
    public const int DEREF_SEARCHING = 1;
    public LdapSearchConstraints() { }
    public LdapSearchConstraints(Novell.Directory.Ldap.LdapConstraints cons) { }
    public LdapSearchConstraints(int msLimit, int serverTimeLimit, int dereference, int maxResults, bool doReferrals, int batchSize, Novell.Directory.Ldap.LdapReferralHandler handler, int hop_limit) { }
    public virtual int BatchSize { get { return default(int); } set { } }
    public virtual int Dereference { get { return default(int); } set { } }
    public virtual int MaxResults { get { return default(int); } set { } }
    public virtual int ServerTimeLimit { get { return default(int); } set { } }
  }
  public partial class LdapSearchQueue : Novell.Directory.Ldap.LdapMessageQueue {
    internal LdapSearchQueue() { }
    public virtual void merge(Novell.Directory.Ldap.LdapMessageQueue queue2) { }
  }
  public partial class LdapSearchRequest : Novell.Directory.Ldap.LdapMessage {
    public const int AND = 0;
    public const int ANY = 1;
    public const int APPROX_MATCH = 8;
    public const int EQUALITY_MATCH = 3;
    public const int EXTENSIBLE_MATCH = 9;
    public const int FINAL = 2;
    public const int GREATER_OR_EQUAL = 5;
    public const int INITIAL = 0;
    public const int LESS_OR_EQUAL = 6;
    public const int NOT = 2;
    public const int OR = 1;
    public const int PRESENT = 7;
    public const int SUBSTRINGS = 4;
    public LdapSearchRequest(string base_Renamed, int scope, Novell.Directory.Ldap.Rfc2251.RfcFilter filter, System.String[] attrs, int dereference, int maxResults, int serverTimeLimit, bool typesOnly, Novell.Directory.Ldap.LdapControl[] cont) : base (default(Novell.Directory.Ldap.Rfc2251.RfcLdapMessage)) { }
    public LdapSearchRequest(string base_Renamed, int scope, string filter, System.String[] attrs, int dereference, int maxResults, int serverTimeLimit, bool typesOnly, Novell.Directory.Ldap.LdapControl[] cont) : base (default(Novell.Directory.Ldap.Rfc2251.RfcLdapMessage)) { }
    public virtual System.String[] Attributes { get { return default(System.String[]); } }
    public virtual int Dereference { get { return default(int); } }
    public virtual string DN { get { return default(string); } }
    public virtual int MaxResults { get { return default(int); } }
    public virtual int Scope { get { return default(int); } }
    public virtual System.Collections.IEnumerator SearchFilter { get { return default(System.Collections.IEnumerator); } }
    public virtual int ServerTimeLimit { get { return default(int); } }
    public virtual string StringFilter { get { return default(string); } }
    public virtual bool TypesOnly { get { return default(bool); } }
  }
  public partial class LdapSearchResult : Novell.Directory.Ldap.LdapMessage {
    public LdapSearchResult(Novell.Directory.Ldap.LdapEntry entry, Novell.Directory.Ldap.LdapControl[] cont) : base (default(Novell.Directory.Ldap.Rfc2251.RfcLdapMessage)) { }
    public virtual Novell.Directory.Ldap.LdapEntry Entry { get { return default(Novell.Directory.Ldap.LdapEntry); } }
    public override string ToString() { return default(string); }
  }
  public partial class LdapSearchResultReference : Novell.Directory.Ldap.LdapMessage {
    internal LdapSearchResultReference() : base (default(Novell.Directory.Ldap.Rfc2251.RfcLdapMessage)) { }
    public virtual System.String[] Referrals { get { return default(System.String[]); } }
  }
  public partial class LdapSearchResults {
    internal LdapSearchResults() { }
    public virtual int Count { get { return default(int); } }
    public virtual Novell.Directory.Ldap.LdapControl[] ResponseControls { get { return default(Novell.Directory.Ldap.LdapControl[]); } }
    public virtual bool hasMore() { return default(bool); }
    public virtual Novell.Directory.Ldap.LdapEntry next() { return default(Novell.Directory.Ldap.LdapEntry); }
  }
  public partial class LdapSyntaxSchema : Novell.Directory.Ldap.LdapSchemaElement {
    public LdapSyntaxSchema(string raw) : base (default(string)) { }
    public LdapSyntaxSchema(string oid, string description) : base (default(string)) { }
    protected internal override string formatString() { return default(string); }
  }
  public partial class LdapUnbindRequest : Novell.Directory.Ldap.LdapMessage {
    public LdapUnbindRequest(Novell.Directory.Ldap.LdapControl[] cont) : base (default(Novell.Directory.Ldap.Rfc2251.RfcLdapMessage)) { }
  }
  public partial interface LdapUnsolicitedNotificationListener {
    void messageReceived(Novell.Directory.Ldap.LdapExtendedResponse msg);
  }
  public partial class LdapUrl : System.ICloneable {
    public LdapUrl(string url) { }
    public LdapUrl(string host, int port, string dn) { }
    public LdapUrl(string host, int port, string dn, System.String[] attrNames, int scope, string filter, System.String[] extensions) { }
    public LdapUrl(string host, int port, string dn, System.String[] attrNames, int scope, string filter, System.String[] extensions, bool secure) { }
    public virtual System.String[] AttributeArray { get { return default(System.String[]); } }
    public virtual System.Collections.IEnumerator Attributes { get { return default(System.Collections.IEnumerator); } }
    public virtual System.String[] Extensions { get { return default(System.String[]); } }
    public virtual string Filter { get { return default(string); } }
    public virtual string Host { get { return default(string); } }
    public virtual int Port { get { return default(int); } }
    public virtual int Scope { get { return default(int); } }
    public virtual bool Secure { get { return default(bool); } }
    public object Clone() { return default(object); }
    public static string decode(string URLEncoded) { return default(string); }
    public static string encode(string toEncode) { return default(string); }
    public virtual string getDN() { return default(string); }
    public override string ToString() { return default(string); }
  }
}
namespace Novell.Directory.Ldap.Asn1 {
  public partial class Asn1Boolean : Novell.Directory.Ldap.Asn1.Asn1Object {
    public static readonly Novell.Directory.Ldap.Asn1.Asn1Identifier ID;
    public const int TAG = 1;
    [System.CLSCompliantAttribute(false)]
    public Asn1Boolean(Novell.Directory.Ldap.Asn1.Asn1Decoder dec, System.IO.Stream in_Renamed, int len) : base (default(Novell.Directory.Ldap.Asn1.Asn1Identifier)) { }
    public Asn1Boolean(bool content) : base (default(Novell.Directory.Ldap.Asn1.Asn1Identifier)) { }
    public bool booleanValue() { return default(bool); }
    public override void encode(Novell.Directory.Ldap.Asn1.Asn1Encoder enc, System.IO.Stream out_Renamed) { }
    public override string ToString() { return default(string); }
  }
  public partial class Asn1Choice : Novell.Directory.Ldap.Asn1.Asn1Object {
    protected internal Asn1Choice() : base (default(Novell.Directory.Ldap.Asn1.Asn1Identifier)) { }
    public Asn1Choice(Novell.Directory.Ldap.Asn1.Asn1Object content) : base (default(Novell.Directory.Ldap.Asn1.Asn1Identifier)) { }
    [System.CLSCompliantAttribute(false)]
    protected internal virtual Novell.Directory.Ldap.Asn1.Asn1Object ChoiceValue { set { } }
    public Novell.Directory.Ldap.Asn1.Asn1Object choiceValue() { return default(Novell.Directory.Ldap.Asn1.Asn1Object); }
    public override void encode(Novell.Directory.Ldap.Asn1.Asn1Encoder enc, System.IO.Stream out_Renamed) { }
    public override Novell.Directory.Ldap.Asn1.Asn1Identifier getIdentifier() { return default(Novell.Directory.Ldap.Asn1.Asn1Identifier); }
    public override void setIdentifier(Novell.Directory.Ldap.Asn1.Asn1Identifier id) { }
    public override string ToString() { return default(string); }
  }
  [System.CLSCompliantAttribute(false)]
  public partial interface Asn1Decoder : System.Runtime.Serialization.ISerializable {
    Novell.Directory.Ldap.Asn1.Asn1Object decode(System.IO.Stream in_Renamed);
    Novell.Directory.Ldap.Asn1.Asn1Object decode(System.IO.Stream in_Renamed, System.Int32[] length);
    Novell.Directory.Ldap.Asn1.Asn1Object decode(System.SByte[] value_Renamed);
    object decodeBoolean(System.IO.Stream in_Renamed, int len);
    object decodeCharacterString(System.IO.Stream in_Renamed, int len);
    object decodeNumeric(System.IO.Stream in_Renamed, int len);
    object decodeOctetString(System.IO.Stream in_Renamed, int len);
  }
  public partial interface Asn1Encoder : System.Runtime.Serialization.ISerializable {
    void encode(Novell.Directory.Ldap.Asn1.Asn1Boolean b, System.IO.Stream out_Renamed);
    void encode(Novell.Directory.Ldap.Asn1.Asn1Identifier id, System.IO.Stream out_Renamed);
    void encode(Novell.Directory.Ldap.Asn1.Asn1Null n, System.IO.Stream out_Renamed);
    void encode(Novell.Directory.Ldap.Asn1.Asn1Numeric n, System.IO.Stream out_Renamed);
    void encode(Novell.Directory.Ldap.Asn1.Asn1OctetString os, System.IO.Stream out_Renamed);
    void encode(Novell.Directory.Ldap.Asn1.Asn1Structured c, System.IO.Stream out_Renamed);
    void encode(Novell.Directory.Ldap.Asn1.Asn1Tagged t, System.IO.Stream out_Renamed);
  }
  public partial class Asn1Enumerated : Novell.Directory.Ldap.Asn1.Asn1Numeric {
    public static readonly Novell.Directory.Ldap.Asn1.Asn1Identifier ID;
    public const int TAG = 10;
    [System.CLSCompliantAttribute(false)]
    public Asn1Enumerated(Novell.Directory.Ldap.Asn1.Asn1Decoder dec, System.IO.Stream in_Renamed, int len) { }
    public Asn1Enumerated(int content) { }
    public Asn1Enumerated(long content) { }
    public override void encode(Novell.Directory.Ldap.Asn1.Asn1Encoder enc, System.IO.Stream out_Renamed) { }
    public override string ToString() { return default(string); }
  }
  public partial class Asn1Identifier : System.ICloneable {
    public const int APPLICATION = 1;
    public const int CONTEXT = 2;
    public const int PRIVATE = 3;
    public const int UNIVERSAL = 0;
    public Asn1Identifier() { }
    public Asn1Identifier(int tagClass, bool constructed, int tag) { }
    public Asn1Identifier(System.IO.Stream in_Renamed) { }
    [System.CLSCompliantAttribute(false)]
    public virtual bool Application { get { return default(bool); } }
    public virtual int Asn1Class { get { return default(int); } }
    public virtual bool Constructed { get { return default(bool); } }
    [System.CLSCompliantAttribute(false)]
    public virtual bool Context { get { return default(bool); } }
    public virtual int EncodedLength { get { return default(int); } }
    [System.CLSCompliantAttribute(false)]
    public virtual bool Private { get { return default(bool); } }
    public virtual int Tag { get { return default(int); } }
    [System.CLSCompliantAttribute(false)]
    public virtual bool Universal { get { return default(bool); } }
    public object Clone() { return default(object); }
    public void reset(System.IO.Stream in_Renamed) { }
  }
  public partial class Asn1Integer : Novell.Directory.Ldap.Asn1.Asn1Numeric {
    public static readonly Novell.Directory.Ldap.Asn1.Asn1Identifier ID;
    public const int TAG = 2;
    [System.CLSCompliantAttribute(false)]
    public Asn1Integer(Novell.Directory.Ldap.Asn1.Asn1Decoder dec, System.IO.Stream in_Renamed, int len) { }
    public Asn1Integer(int content) { }
    public Asn1Integer(long content) { }
    public override void encode(Novell.Directory.Ldap.Asn1.Asn1Encoder enc, System.IO.Stream out_Renamed) { }
    public override string ToString() { return default(string); }
  }
  public partial class Asn1Length {
    public Asn1Length() { }
    public Asn1Length(int length) { }
    public Asn1Length(System.IO.Stream in_Renamed) { }
    public virtual int EncodedLength { get { return default(int); } }
    public virtual int Length { get { return default(int); } }
    public void reset(System.IO.Stream in_Renamed) { }
  }
  public partial class Asn1Null : Novell.Directory.Ldap.Asn1.Asn1Object {
    public static readonly Novell.Directory.Ldap.Asn1.Asn1Identifier ID;
    public const int TAG = 5;
    public Asn1Null() : base (default(Novell.Directory.Ldap.Asn1.Asn1Identifier)) { }
    public override void encode(Novell.Directory.Ldap.Asn1.Asn1Encoder enc, System.IO.Stream out_Renamed) { }
    public override string ToString() { return default(string); }
  }
  public abstract partial class Asn1Numeric : Novell.Directory.Ldap.Asn1.Asn1Object {
    internal Asn1Numeric() : base (default(Novell.Directory.Ldap.Asn1.Asn1Identifier)) { }
    public int intValue() { return default(int); }
    public long longValue() { return default(long); }
  }
  public abstract partial class Asn1Object : System.Runtime.Serialization.ISerializable {
    public Asn1Object(Novell.Directory.Ldap.Asn1.Asn1Identifier id) { }
    public abstract void encode(Novell.Directory.Ldap.Asn1.Asn1Encoder enc, System.IO.Stream out_Renamed);
    [System.CLSCompliantAttribute(false)]
    public System.SByte[] getEncoding(Novell.Directory.Ldap.Asn1.Asn1Encoder enc) { return default(System.SByte[]); }
    public virtual Novell.Directory.Ldap.Asn1.Asn1Identifier getIdentifier() { return default(Novell.Directory.Ldap.Asn1.Asn1Identifier); }
    public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public virtual void setIdentifier(Novell.Directory.Ldap.Asn1.Asn1Identifier id) { }
    [System.CLSCompliantAttribute(false)]
    public override string ToString() { return default(string); }
  }
  public partial class Asn1OctetString : Novell.Directory.Ldap.Asn1.Asn1Object {
    protected internal static readonly Novell.Directory.Ldap.Asn1.Asn1Identifier ID;
    public const int TAG = 4;
    [System.CLSCompliantAttribute(false)]
    public Asn1OctetString(Novell.Directory.Ldap.Asn1.Asn1Decoder dec, System.IO.Stream in_Renamed, int len) : base (default(Novell.Directory.Ldap.Asn1.Asn1Identifier)) { }
    [System.CLSCompliantAttribute(false)]
    public Asn1OctetString(System.SByte[] content) : base (default(Novell.Directory.Ldap.Asn1.Asn1Identifier)) { }
    public Asn1OctetString(string content) : base (default(Novell.Directory.Ldap.Asn1.Asn1Identifier)) { }
    [System.CLSCompliantAttribute(false)]
    public System.SByte[] byteValue() { return default(System.SByte[]); }
    public override void encode(Novell.Directory.Ldap.Asn1.Asn1Encoder enc, System.IO.Stream out_Renamed) { }
    public string stringValue() { return default(string); }
    public override string ToString() { return default(string); }
  }
  public partial class Asn1Sequence : Novell.Directory.Ldap.Asn1.Asn1Structured {
    public const int TAG = 16;
    public Asn1Sequence() : base (default(Novell.Directory.Ldap.Asn1.Asn1Identifier)) { }
    [System.CLSCompliantAttribute(false)]
    public Asn1Sequence(Novell.Directory.Ldap.Asn1.Asn1Decoder dec, System.IO.Stream in_Renamed, int len) : base (default(Novell.Directory.Ldap.Asn1.Asn1Identifier)) { }
    public Asn1Sequence(Novell.Directory.Ldap.Asn1.Asn1Object[] newContent, int size) : base (default(Novell.Directory.Ldap.Asn1.Asn1Identifier)) { }
    public Asn1Sequence(int size) : base (default(Novell.Directory.Ldap.Asn1.Asn1Identifier)) { }
    [System.CLSCompliantAttribute(false)]
    public override string ToString() { return default(string); }
  }
  public partial class Asn1SequenceOf : Novell.Directory.Ldap.Asn1.Asn1Structured {
    public static readonly Novell.Directory.Ldap.Asn1.Asn1Identifier ID;
    public const int TAG = 16;
    public Asn1SequenceOf() : base (default(Novell.Directory.Ldap.Asn1.Asn1Identifier)) { }
    [System.CLSCompliantAttribute(false)]
    public Asn1SequenceOf(Novell.Directory.Ldap.Asn1.Asn1Decoder dec, System.IO.Stream in_Renamed, int len) : base (default(Novell.Directory.Ldap.Asn1.Asn1Identifier)) { }
    public Asn1SequenceOf(Novell.Directory.Ldap.Asn1.Asn1Sequence sequence) : base (default(Novell.Directory.Ldap.Asn1.Asn1Identifier)) { }
    public Asn1SequenceOf(int size) : base (default(Novell.Directory.Ldap.Asn1.Asn1Identifier)) { }
    [System.CLSCompliantAttribute(false)]
    public override string ToString() { return default(string); }
  }
  public partial class Asn1Set : Novell.Directory.Ldap.Asn1.Asn1Structured {
    public static readonly Novell.Directory.Ldap.Asn1.Asn1Identifier ID;
    public const int TAG = 17;
    public Asn1Set() : base (default(Novell.Directory.Ldap.Asn1.Asn1Identifier)) { }
    [System.CLSCompliantAttribute(false)]
    public Asn1Set(Novell.Directory.Ldap.Asn1.Asn1Decoder dec, System.IO.Stream in_Renamed, int len) : base (default(Novell.Directory.Ldap.Asn1.Asn1Identifier)) { }
    public Asn1Set(int size) : base (default(Novell.Directory.Ldap.Asn1.Asn1Identifier)) { }
    [System.CLSCompliantAttribute(false)]
    public override string ToString() { return default(string); }
  }
  public partial class Asn1SetOf : Novell.Directory.Ldap.Asn1.Asn1Structured {
    public static readonly Novell.Directory.Ldap.Asn1.Asn1Identifier ID;
    public const int TAG = 17;
    public Asn1SetOf() : base (default(Novell.Directory.Ldap.Asn1.Asn1Identifier)) { }
    public Asn1SetOf(Novell.Directory.Ldap.Asn1.Asn1Set set_Renamed) : base (default(Novell.Directory.Ldap.Asn1.Asn1Identifier)) { }
    public Asn1SetOf(int size) : base (default(Novell.Directory.Ldap.Asn1.Asn1Identifier)) { }
    [System.CLSCompliantAttribute(false)]
    public override string ToString() { return default(string); }
  }
  public abstract partial class Asn1Structured : Novell.Directory.Ldap.Asn1.Asn1Object {
    protected internal Asn1Structured(Novell.Directory.Ldap.Asn1.Asn1Identifier id) : base (default(Novell.Directory.Ldap.Asn1.Asn1Identifier)) { }
    protected internal Asn1Structured(Novell.Directory.Ldap.Asn1.Asn1Identifier id, Novell.Directory.Ldap.Asn1.Asn1Object[] newContent, int size) : base (default(Novell.Directory.Ldap.Asn1.Asn1Identifier)) { }
    protected internal Asn1Structured(Novell.Directory.Ldap.Asn1.Asn1Identifier id, int size) : base (default(Novell.Directory.Ldap.Asn1.Asn1Identifier)) { }
    public void add(Novell.Directory.Ldap.Asn1.Asn1Object value_Renamed) { }
    [System.CLSCompliantAttribute(false)]
    protected internal void decodeStructured(Novell.Directory.Ldap.Asn1.Asn1Decoder dec, System.IO.Stream in_Renamed, int len) { }
    public override void encode(Novell.Directory.Ldap.Asn1.Asn1Encoder enc, System.IO.Stream out_Renamed) { }
    public Novell.Directory.Ldap.Asn1.Asn1Object get_Renamed(int index) { return default(Novell.Directory.Ldap.Asn1.Asn1Object); }
    public void set_Renamed(int index, Novell.Directory.Ldap.Asn1.Asn1Object value_Renamed) { }
    public int size() { return default(int); }
    public Novell.Directory.Ldap.Asn1.Asn1Object[] toArray() { return default(Novell.Directory.Ldap.Asn1.Asn1Object[]); }
    [System.CLSCompliantAttribute(false)]
    public virtual string toString(string type) { return default(string); }
  }
  public partial class Asn1Tagged : Novell.Directory.Ldap.Asn1.Asn1Object {
    [System.CLSCompliantAttribute(false)]
    public Asn1Tagged(Novell.Directory.Ldap.Asn1.Asn1Decoder dec, System.IO.Stream in_Renamed, int len, Novell.Directory.Ldap.Asn1.Asn1Identifier identifier) : base (default(Novell.Directory.Ldap.Asn1.Asn1Identifier)) { }
    public Asn1Tagged(Novell.Directory.Ldap.Asn1.Asn1Identifier identifier, Novell.Directory.Ldap.Asn1.Asn1Object object_Renamed) : base (default(Novell.Directory.Ldap.Asn1.Asn1Identifier)) { }
    public Asn1Tagged(Novell.Directory.Ldap.Asn1.Asn1Identifier identifier, Novell.Directory.Ldap.Asn1.Asn1Object object_Renamed, bool explicit_Renamed) : base (default(Novell.Directory.Ldap.Asn1.Asn1Identifier)) { }
    public virtual bool Explicit { get { return default(bool); } }
    [System.CLSCompliantAttribute(false)]
    public virtual Novell.Directory.Ldap.Asn1.Asn1Object TaggedValue { set { } }
    public override void encode(Novell.Directory.Ldap.Asn1.Asn1Encoder enc, System.IO.Stream out_Renamed) { }
    public Novell.Directory.Ldap.Asn1.Asn1Object taggedValue() { return default(Novell.Directory.Ldap.Asn1.Asn1Object); }
    public override string ToString() { return default(string); }
  }
  public partial class LBERDecoder : Novell.Directory.Ldap.Asn1.Asn1Decoder, System.Runtime.Serialization.ISerializable {
    public LBERDecoder() { }
    public virtual Novell.Directory.Ldap.Asn1.Asn1Object decode(System.IO.Stream in_Renamed) { return default(Novell.Directory.Ldap.Asn1.Asn1Object); }
    public virtual Novell.Directory.Ldap.Asn1.Asn1Object decode(System.IO.Stream in_Renamed, System.Int32[] len) { return default(Novell.Directory.Ldap.Asn1.Asn1Object); }
    [System.CLSCompliantAttribute(false)]
    public virtual Novell.Directory.Ldap.Asn1.Asn1Object decode(System.SByte[] value_Renamed) { return default(Novell.Directory.Ldap.Asn1.Asn1Object); }
    public object decodeBoolean(System.IO.Stream in_Renamed, int len) { return default(object); }
    public object decodeCharacterString(System.IO.Stream in_Renamed, int len) { return default(object); }
    public object decodeNumeric(System.IO.Stream in_Renamed, int len) { return default(object); }
    public object decodeOctetString(System.IO.Stream in_Renamed, int len) { return default(object); }
    public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial class LBEREncoder : Novell.Directory.Ldap.Asn1.Asn1Encoder, System.Runtime.Serialization.ISerializable {
    public LBEREncoder() { }
    public virtual void encode(Novell.Directory.Ldap.Asn1.Asn1Boolean b, System.IO.Stream out_Renamed) { }
    public void encode(Novell.Directory.Ldap.Asn1.Asn1Identifier id, System.IO.Stream out_Renamed) { }
    public void encode(Novell.Directory.Ldap.Asn1.Asn1Null n, System.IO.Stream out_Renamed) { }
    public void encode(Novell.Directory.Ldap.Asn1.Asn1Numeric n, System.IO.Stream out_Renamed) { }
    public void encode(Novell.Directory.Ldap.Asn1.Asn1OctetString os, System.IO.Stream out_Renamed) { }
    public void encode(Novell.Directory.Ldap.Asn1.Asn1Structured c, System.IO.Stream out_Renamed) { }
    public void encode(Novell.Directory.Ldap.Asn1.Asn1Tagged t, System.IO.Stream out_Renamed) { }
    public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
}
namespace Novell.Directory.Ldap.Controls {
  public partial class LdapEntryChangeControl : Novell.Directory.Ldap.LdapControl {
    [System.CLSCompliantAttribute(false)]
    public LdapEntryChangeControl(string oid, bool critical, System.SByte[] value_Renamed) : base (default(string), default(bool), default(System.SByte[])) { }
    public virtual int ChangeNumber { get { return default(int); } }
    public virtual int ChangeType { get { return default(int); } }
    public virtual bool HasChangeNumber { get { return default(bool); } }
    public virtual string PreviousDN { get { return default(string); } }
    public override string ToString() { return default(string); }
  }
  public partial class LdapPersistSearchControl : Novell.Directory.Ldap.LdapControl {
    public const int ADD = 1;
    public static readonly int ANY;
    public const int DELETE = 2;
    public const int MODDN = 8;
    public const int MODIFY = 4;
    public LdapPersistSearchControl() : base (default(string), default(bool), default(System.SByte[])) { }
    public LdapPersistSearchControl(int changeTypes, bool changesOnly, bool returnControls, bool isCritical) : base (default(string), default(bool), default(System.SByte[])) { }
    public virtual bool ChangesOnly { get { return default(bool); } set { } }
    public virtual int ChangeTypes { get { return default(int); } set { } }
    public virtual bool ReturnControls { get { return default(bool); } set { } }
    public override string ToString() { return default(string); }
  }
  public partial class LdapSortControl : Novell.Directory.Ldap.LdapControl {
    public LdapSortControl(Novell.Directory.Ldap.Controls.LdapSortKey key, bool critical) : base (default(string), default(bool), default(System.SByte[])) { }
    public LdapSortControl(Novell.Directory.Ldap.Controls.LdapSortKey[] keys, bool critical) : base (default(string), default(bool), default(System.SByte[])) { }
  }
  public partial class LdapSortKey {
    public LdapSortKey(string keyDescription) { }
    public LdapSortKey(string key, bool reverse) { }
    public LdapSortKey(string key, bool reverse, string matchRule) { }
    public virtual string Key { get { return default(string); } }
    public virtual string MatchRule { get { return default(string); } }
    public virtual bool Reverse { get { return default(bool); } }
  }
  public partial class LdapSortResponse : Novell.Directory.Ldap.LdapControl {
    [System.CLSCompliantAttribute(false)]
    public LdapSortResponse(string oid, bool critical, System.SByte[] values) : base (default(string), default(bool), default(System.SByte[])) { }
    public virtual string FailedAttribute { get { return default(string); } }
    public virtual int ResultCode { get { return default(int); } }
  }
  public partial class LdapVirtualListControl : Novell.Directory.Ldap.LdapControl {
    public LdapVirtualListControl(int startIndex, int beforeCount, int afterCount, int contentCount) : base (default(string), default(bool), default(System.SByte[])) { }
    public LdapVirtualListControl(int startIndex, int beforeCount, int afterCount, int contentCount, string context) : base (default(string), default(bool), default(System.SByte[])) { }
    public LdapVirtualListControl(string jumpTo, int beforeCount, int afterCount) : base (default(string), default(bool), default(System.SByte[])) { }
    public LdapVirtualListControl(string jumpTo, int beforeCount, int afterCount, string context) : base (default(string), default(bool), default(System.SByte[])) { }
    public virtual int AfterCount { get { return default(int); } }
    public virtual int BeforeCount { get { return default(int); } }
    public virtual string Context { get { return default(string); } set { } }
    public virtual int ListSize { get { return default(int); } set { } }
    public virtual void setRange(int listIndex, int beforeCount, int afterCount) { }
    public virtual void setRange(string jumpTo, int beforeCount, int afterCount) { }
  }
  public partial class LdapVirtualListResponse : Novell.Directory.Ldap.LdapControl {
    [System.CLSCompliantAttribute(false)]
    public LdapVirtualListResponse(string oid, bool critical, System.SByte[] values) : base (default(string), default(bool), default(System.SByte[])) { }
    public virtual int ContentCount { get { return default(int); } }
    public virtual string Context { get { return default(string); } }
    public virtual int FirstPosition { get { return default(int); } }
    public virtual int ResultCode { get { return default(int); } }
  }
}
namespace Novell.Directory.Ldap.Events {
  public partial class BaseEventArgs : System.EventArgs {
    protected Novell.Directory.Ldap.LdapMessage ldap_message;
    public BaseEventArgs(Novell.Directory.Ldap.LdapMessage message) { }
    public Novell.Directory.Ldap.LdapMessage ContianedEventInformation { get { return default(Novell.Directory.Ldap.LdapMessage); } }
  }
  public partial class DirectoryEventArgs : Novell.Directory.Ldap.Events.BaseEventArgs {
    protected Novell.Directory.Ldap.Events.EventClassifiers eClassification;
    public DirectoryEventArgs(Novell.Directory.Ldap.LdapMessage sourceMessage, Novell.Directory.Ldap.Events.EventClassifiers aClassification) : base (default(Novell.Directory.Ldap.LdapMessage)) { }
    public Novell.Directory.Ldap.Events.EventClassifiers EventClassification { get { return default(Novell.Directory.Ldap.Events.EventClassifiers); } set { } }
  }
  public partial class DirectoryExceptionEventArgs : Novell.Directory.Ldap.Events.BaseEventArgs {
    protected Novell.Directory.Ldap.LdapException ldap_exception_object;
    public DirectoryExceptionEventArgs(Novell.Directory.Ldap.LdapMessage message, Novell.Directory.Ldap.LdapException ldapException) : base (default(Novell.Directory.Ldap.LdapMessage)) { }
    public Novell.Directory.Ldap.LdapException LdapExceptionObject { get { return default(Novell.Directory.Ldap.LdapException); } }
  }
  public enum EventClassifiers {
    CLASSIFICATION_EDIR_EVENT = 1,
    CLASSIFICATION_LDAP_PSEARCH = 0,
    CLASSIFICATION_UNKNOWN = -1,
  }
  public partial class LdapEventArgs : Novell.Directory.Ldap.Events.DirectoryEventArgs {
    protected Novell.Directory.Ldap.Events.LdapEventType eType;
    public LdapEventArgs(Novell.Directory.Ldap.LdapMessage sourceMessage, Novell.Directory.Ldap.Events.EventClassifiers aClassification, Novell.Directory.Ldap.Events.LdapEventType aType) : base (default(Novell.Directory.Ldap.LdapMessage), default(Novell.Directory.Ldap.Events.EventClassifiers)) { }
    public Novell.Directory.Ldap.Events.LdapEventType EventType { get { return default(Novell.Directory.Ldap.Events.LdapEventType); } set { } }
    public override string ToString() { return default(string); }
  }
  public abstract partial class LdapEventSource {
    protected const int DEFAULT_SLEEP_TIME = 1000;
    protected Novell.Directory.Ldap.Events.LdapEventSource.DirectoryEventHandler directory_event;
    protected Novell.Directory.Ldap.Events.LdapEventSource.DirectoryExceptionEventHandler directory_exception_event;
    protected internal const int EVENT_TYPE_UNKNOWN = -1;
    protected Novell.Directory.Ldap.Events.LdapEventSource.EventsGenerator m_objEventsGenerator;
    protected int sleep_interval;
    protected LdapEventSource() { }
    public int SleepInterval { get { return default(int); } set { } }
    public event Novell.Directory.Ldap.Events.LdapEventSource.DirectoryEventHandler DirectoryEvent { add { } remove { } }
    public event Novell.Directory.Ldap.Events.LdapEventSource.DirectoryExceptionEventHandler DirectoryExceptionEvent { add { } remove { } }
    protected Novell.Directory.Ldap.Events.LdapEventSource.LISTENERS_COUNT GetCurrentListenersState() { return default(Novell.Directory.Ldap.Events.LdapEventSource.LISTENERS_COUNT); }
    protected abstract int GetListeners();
    protected void ListenerAdded() { }
    protected void ListenerRemoved() { }
    protected void NotifyDirectoryListeners(Novell.Directory.Ldap.Events.DirectoryEventArgs objDirectoryEventArgs) { }
    protected void NotifyDirectoryListeners(Novell.Directory.Ldap.LdapMessage sourceMessage, Novell.Directory.Ldap.Events.EventClassifiers aClassification) { }
    protected abstract bool NotifyEventListeners(Novell.Directory.Ldap.LdapMessage sourceMessage, Novell.Directory.Ldap.Events.EventClassifiers aClassification, int nType);
    protected void NotifyExceptionListeners(Novell.Directory.Ldap.LdapMessage sourceMessage, Novell.Directory.Ldap.LdapException ldapException) { }
    protected void NotifyListeners(Novell.Directory.Ldap.LdapMessage sourceMessage, Novell.Directory.Ldap.Events.EventClassifiers aClassification, int nType) { }
    protected void StartEventPolling(Novell.Directory.Ldap.LdapMessageQueue queue, Novell.Directory.Ldap.LdapConnection conn, int msgid) { }
    protected abstract void StartSearchAndPolling();
    protected void StopEventPolling() { }
    protected abstract void StopSearchAndPolling();
    public delegate void DirectoryEventHandler(object source, Novell.Directory.Ldap.Events.DirectoryEventArgs objDirectoryEventArgs);
    public delegate void DirectoryExceptionEventHandler(object source, Novell.Directory.Ldap.Events.DirectoryExceptionEventArgs objDirectoryExceptionEventArgs);
    protected partial class EventsGenerator {
      public EventsGenerator(Novell.Directory.Ldap.Events.LdapEventSource objEventSource, Novell.Directory.Ldap.LdapMessageQueue queue, Novell.Directory.Ldap.LdapConnection conn, int msgid) { }
      public int SleepTime { get { return default(int); } set { } }
      protected void processmessage(Novell.Directory.Ldap.LdapMessage response) { }
      protected void Run() { }
      public void StartEventPolling() { }
      public void StopEventPolling() { }
    }
    protected enum LISTENERS_COUNT {
      MORE_THAN_ONE = 2,
      ONE = 1,
      ZERO = 0,
    }
  }
  public enum LdapEventType {
    LDAP_PSEARCH_ADD = 1,
    LDAP_PSEARCH_ANY = 15,
    LDAP_PSEARCH_DELETE = 2,
    LDAP_PSEARCH_MODDN = 8,
    LDAP_PSEARCH_MODIFY = 4,
    TYPE_UNKNOWN = -1,
  }
  public partial class PSearchEventSource : Novell.Directory.Ldap.Events.LdapEventSource {
    protected System.String[] mAttrs;
    protected Novell.Directory.Ldap.LdapConnection mConnection;
    protected Novell.Directory.Ldap.Events.LdapEventType mEventChangeType;
    protected string mFilter;
    protected Novell.Directory.Ldap.LdapSearchQueue mQueue;
    protected int mScope;
    protected string mSearchBase;
    protected Novell.Directory.Ldap.LdapSearchConstraints mSearchConstraints;
    protected bool mTypesOnly;
    protected Novell.Directory.Ldap.Events.PSearchEventSource.SearchReferralEventHandler search_referral_event;
    protected Novell.Directory.Ldap.Events.PSearchEventSource.SearchResultEventHandler search_result_event;
    public PSearchEventSource(Novell.Directory.Ldap.LdapConnection conn, string searchBase, int scope, string filter, System.String[] attrs, bool typesOnly, Novell.Directory.Ldap.LdapSearchConstraints constraints, Novell.Directory.Ldap.Events.LdapEventType eventchangetype, bool changeonly) { }
    public event Novell.Directory.Ldap.Events.PSearchEventSource.SearchReferralEventHandler SearchReferralEvent { add { } remove { } }
    public event Novell.Directory.Ldap.Events.PSearchEventSource.SearchResultEventHandler SearchResultEvent { add { } remove { } }
    protected override int GetListeners() { return default(int); }
    protected override bool NotifyEventListeners(Novell.Directory.Ldap.LdapMessage sourceMessage, Novell.Directory.Ldap.Events.EventClassifiers aClassification, int nType) { return default(bool); }
    protected override void StartSearchAndPolling() { }
    protected override void StopSearchAndPolling() { }
    public delegate void SearchReferralEventHandler(object source, Novell.Directory.Ldap.Events.SearchReferralEventArgs objArgs);
    public delegate void SearchResultEventHandler(object source, Novell.Directory.Ldap.Events.SearchResultEventArgs objArgs);
  }
  public partial class SearchReferralEventArgs : Novell.Directory.Ldap.Events.LdapEventArgs {
    public SearchReferralEventArgs(Novell.Directory.Ldap.LdapMessage sourceMessage, Novell.Directory.Ldap.Events.EventClassifiers aClassification, Novell.Directory.Ldap.Events.LdapEventType aType) : base (default(Novell.Directory.Ldap.LdapMessage), default(Novell.Directory.Ldap.Events.EventClassifiers), default(Novell.Directory.Ldap.Events.LdapEventType)) { }
    public System.String[] getUrls() { return default(System.String[]); }
  }
  public partial class SearchResultEventArgs : Novell.Directory.Ldap.Events.LdapEventArgs {
    public SearchResultEventArgs(Novell.Directory.Ldap.LdapMessage sourceMessage, Novell.Directory.Ldap.Events.EventClassifiers aClassification, Novell.Directory.Ldap.Events.LdapEventType aType) : base (default(Novell.Directory.Ldap.LdapMessage), default(Novell.Directory.Ldap.Events.EventClassifiers), default(Novell.Directory.Ldap.Events.LdapEventType)) { }
    public Novell.Directory.Ldap.LdapEntry Entry { get { return default(Novell.Directory.Ldap.LdapEntry); } }
    public override string ToString() { return default(string); }
  }
}
namespace Novell.Directory.Ldap.Events.Edir {
  public enum DebugParameterType {
    ADDRESS = 5,
    BINARY = 3,
    ENTRYID = 1,
    INTEGER = 4,
    STRING = 2,
    TIMESTAMP = 6,
    TIMEVECTOR = 7,
  }
  public partial class DSETimeStamp {
    protected int nEvent;
    protected int nSeconds;
    protected int replica_number;
    public DSETimeStamp(Novell.Directory.Ldap.Asn1.Asn1Sequence dseObject) { }
    public int Event { get { return default(int); } }
    public int ReplicaNumber { get { return default(int); } }
    public int Seconds { get { return default(int); } }
    public override string ToString() { return default(string); }
  }
  public partial class EdirEventArgs : Novell.Directory.Ldap.Events.DirectoryEventArgs {
    public EdirEventArgs(Novell.Directory.Ldap.LdapMessage sourceMessage, Novell.Directory.Ldap.Events.EventClassifiers aClassification) : base (default(Novell.Directory.Ldap.LdapMessage), default(Novell.Directory.Ldap.Events.EventClassifiers)) { }
    public Novell.Directory.Ldap.Events.Edir.EdirEventIntermediateResponse IntermediateResponse { get { return default(Novell.Directory.Ldap.Events.Edir.EdirEventIntermediateResponse); } }
  }
  public enum EdirEventDataType {
    EDIR_TAG_BINDERY_EVENT_DATA = 5,
    EDIR_TAG_CHANGE_CONFIG_PARAM = 11,
    EDIR_TAG_CHANGE_SERVER_ADDRESS = 10,
    EDIR_TAG_CONNECTION_STATE = 9,
    EDIR_TAG_DEBUG_EVENT_DATA = 14,
    EDIR_TAG_DSESEV_INFO = 6,
    EDIR_TAG_ENTRY_EVENT_DATA = 1,
    EDIR_TAG_GENERAL_EVENT_DATA = 3,
    EDIR_TAG_MODULE_STATE_DATA = 7,
    EDIR_TAG_NETWORK_ADDRESS = 8,
    EDIR_TAG_NO_DATA = 12,
    EDIR_TAG_SKULK_DATA = 4,
    EDIR_TAG_STATUS_LOG = 13,
    EDIR_TAG_VALUE_EVENT_DATA = 2,
  }
  public partial class EdirEventIntermediateResponse : Novell.Directory.Ldap.LdapIntermediateResponse {
    protected Novell.Directory.Ldap.Events.Edir.EventData.BaseEdirEventData event_response_data;
    protected Novell.Directory.Ldap.Events.Edir.EdirEventResultType event_result_type;
    protected Novell.Directory.Ldap.Events.Edir.EdirEventType event_type;
    public EdirEventIntermediateResponse(Novell.Directory.Ldap.Rfc2251.RfcLdapMessage message) : base (default(Novell.Directory.Ldap.Rfc2251.RfcLdapMessage)) { }
    public EdirEventIntermediateResponse(System.Byte[] message) : base (default(Novell.Directory.Ldap.Rfc2251.RfcLdapMessage)) { }
    public Novell.Directory.Ldap.Events.Edir.EventData.BaseEdirEventData EventResponseDataObject { get { return default(Novell.Directory.Ldap.Events.Edir.EventData.BaseEdirEventData); } }
    public Novell.Directory.Ldap.Events.Edir.EdirEventResultType EventResultType { get { return default(Novell.Directory.Ldap.Events.Edir.EdirEventResultType); } }
    public Novell.Directory.Ldap.Events.Edir.EdirEventType EventType { get { return default(Novell.Directory.Ldap.Events.Edir.EdirEventType); } }
    [System.CLSCompliantAttribute(false)]
    protected void ProcessMessage(System.SByte[] returnedValue) { }
  }
  public enum EdirEventResultType {
    EVT_STATUS_ALL = 0,
    EVT_STATUS_FAILURE = 2,
    EVT_STATUS_SUCCESS = 1,
  }
  public partial class EdirEventSource : Novell.Directory.Ldap.Events.LdapEventSource {
    protected Novell.Directory.Ldap.Events.Edir.EdirEventSource.EdirEventHandler edir_event;
    protected Novell.Directory.Ldap.LdapConnection mConnection;
    protected Novell.Directory.Ldap.LdapResponseQueue mQueue;
    protected Novell.Directory.Ldap.Events.Edir.MonitorEventRequest mRequestOperation;
    public EdirEventSource(Novell.Directory.Ldap.Events.Edir.EdirEventSpecifier[] specifier, Novell.Directory.Ldap.LdapConnection conn) { }
    public event Novell.Directory.Ldap.Events.Edir.EdirEventSource.EdirEventHandler EdirEvent { add { } remove { } }
    protected override int GetListeners() { return default(int); }
    protected override bool NotifyEventListeners(Novell.Directory.Ldap.LdapMessage sourceMessage, Novell.Directory.Ldap.Events.EventClassifiers aClassification, int nType) { return default(bool); }
    protected override void StartSearchAndPolling() { }
    protected override void StopSearchAndPolling() { }
    public delegate void EdirEventHandler(object source, Novell.Directory.Ldap.Events.Edir.EdirEventArgs objEdirEventArgs);
  }
  public partial class EdirEventSpecifier {
    public EdirEventSpecifier(Novell.Directory.Ldap.Events.Edir.EdirEventType eventType, Novell.Directory.Ldap.Events.Edir.EdirEventResultType eventResultType) { }
    public EdirEventSpecifier(Novell.Directory.Ldap.Events.Edir.EdirEventType eventType, Novell.Directory.Ldap.Events.Edir.EdirEventResultType eventResultType, string filter) { }
    public string EventFilter { get { return default(string); } }
    public Novell.Directory.Ldap.Events.Edir.EdirEventResultType EventResultType { get { return default(Novell.Directory.Ldap.Events.Edir.EdirEventResultType); } }
    public Novell.Directory.Ldap.Events.Edir.EdirEventType EventType { get { return default(Novell.Directory.Ldap.Events.Edir.EdirEventType); } }
  }
  public enum EdirEventType {
    EVT_ABORT_JOIN = 145,
    EVT_ABORT_PARTITION_OP = 109,
    EVT_ADD_ENTRY = 168,
    EVT_ADD_MEMBER = 153,
    EVT_ADD_PROPERTY = 151,
    EVT_ADD_REPLICA = 103,
    EVT_ADD_VALUE = 5,
    EVT_AGENT_CLOSE_LOCAL = 54,
    EVT_AGENT_OPEN_LOCAL = 53,
    EVT_ALLOW_LOGIN = 188,
    EVT_BACKLINK_PROC_DONE = 95,
    EVT_BACKUP_ENTRY = 114,
    EVT_BEGIN_NAMEBASE_TRANSACTION = 213,
    EVT_BKLINK_OPERATOR = 63,
    EVT_BKLINK_SEV = 62,
    EVT_CHANGE_CONN_STATE = 173,
    EVT_CHANGE_MODULE_STATE = 21,
    EVT_CHANGE_OBJ_SECURITY = 156,
    EVT_CHANGE_PROP_SECURITY = 155,
    EVT_CHANGE_REPLICA_TYPE = 107,
    EVT_CHANGE_SECURITY_EQUALS = 164,
    EVT_CHANGE_SERVER_ADDRS = 219,
    EVT_CHANGE_TREE_NAME = 143,
    EVT_CHECK_CONSOLE_OPERATOR = 142,
    EVT_CHECK_SEV = 12,
    EVT_CHGPASS = 101,
    EVT_CLOSE_BINDERY = 172,
    EVT_CLOSE_STREAM = 7,
    EVT_COMPARE_ATTR_VALUE = 123,
    EVT_CONNECT_TO_ADDRESS = 158,
    EVT_CONSOLE_OPERATION = 203,
    EVT_CRC_FAILURE = 167,
    EVT_CREATE_BACKLINK = 141,
    EVT_CREATE_BINDERY_OBJECT = 10,
    EVT_CREATE_ENTRY = 1,
    EVT_CREATE_NAMEBASE = 163,
    EVT_CREATE_SUBREF = 132,
    EVT_DB_ALLOC = 202,
    EVT_DB_AUDIT = 175,
    EVT_DB_AUDIT_NCP = 176,
    EVT_DB_AUDIT_SKULK = 177,
    EVT_DB_AUTHEN = 26,
    EVT_DB_BACKLINK = 27,
    EVT_DB_BACKLINK_DETAIL = 236,
    EVT_DB_BUFFERS = 28,
    EVT_DB_CHANGE_CACHE = 184,
    EVT_DB_CLIENT_BUFFERS = 189,
    EVT_DB_COLL = 29,
    EVT_DB_CONN_TRACE = 210,
    EVT_DB_DIRXML = 214,
    EVT_DB_DIRXML_DRIVERS = 217,
    EVT_DB_DNS = 220,
    EVT_DB_DRL = 198,
    EVT_DB_DRL_DETAIL = 237,
    EVT_DB_DSAGENT = 30,
    EVT_DB_EMU = 31,
    EVT_DB_FRAGGER = 32,
    EVT_DB_HTTPSTK = 231,
    EVT_DB_IN_SYNC_DETAIL = 227,
    EVT_DB_INIT = 33,
    EVT_DB_INSPECTOR = 34,
    EVT_DB_JANITOR = 35,
    EVT_DB_LDAPSTK = 232,
    EVT_DB_LIMBER = 36,
    EVT_DB_LOCKING = 37,
    EVT_DB_LOST_ENTRY = 183,
    EVT_DB_MIN = 39,
    EVT_DB_MISC = 40,
    EVT_DB_MOVE = 38,
    EVT_DB_NCPENG = 166,
    EVT_DB_NDSMON = 218,
    EVT_DB_NICIEXT = 233,
    EVT_DB_NMAS = 235,
    EVT_DB_NPKI_API = 242,
    EVT_DB_OBIT = 207,
    EVT_DB_OBJECT_PRODUCER = 238,
    EVT_DB_PART = 41,
    EVT_DB_PKI = 230,
    EVT_DB_PURGE = 186,
    EVT_DB_RECMAN = 42,
    EVT_DB_REPAIR = 221,
    EVT_DB_REPAIR_DEBUG = 222,
    EVT_DB_RESNAME = 44,
    EVT_DB_SAP = 45,
    EVT_DB_SCHEMA = 46,
    EVT_DB_SCHEMA_DETAIL = 225,
    EVT_DB_SEARCH = 239,
    EVT_DB_SEARCH_DETAIL = 240,
    EVT_DB_SECRET_STORE = 234,
    EVT_DB_SERVER_PACKET = 204,
    EVT_DB_SKULKER = 47,
    EVT_DB_SSL = 229,
    EVT_DB_STREAMS = 48,
    EVT_DB_SYNC_DETAIL = 209,
    EVT_DB_SYNC_IN = 49,
    EVT_DB_THREADS = 50,
    EVT_DB_TIMEVECTOR = 51,
    EVT_DB_VCLIENT = 52,
    EVT_DB_WANMAN = 190,
    EVT_DEFINE_ATTR_DEF = 116,
    EVT_DEFINE_CLASS_DEF = 119,
    EVT_DELETE_ATTRIBUTE = 8,
    EVT_DELETE_BINDERY_OBJECT = 11,
    EVT_DELETE_ENTRY = 2,
    EVT_DELETE_MEMBER = 154,
    EVT_DELETE_PROPERTY = 152,
    EVT_DELETE_SUBTREE = 64,
    EVT_DELETE_UNUSED_EXTREF = 15,
    EVT_DELETE_VALUE = 6,
    EVT_DS_ERR_VIA_BINDERY = 55,
    EVT_DSA_BAD_VERB = 56,
    EVT_DSA_READ = 99,
    EVT_DSA_REQUEST_END = 58,
    EVT_DSA_REQUEST_START = 57,
    EVT_END_NAMEBASE_TRANSACTION = 187,
    EVT_END_UPDATE_REPLICA = 138,
    EVT_END_UPDATE_SCHEMA = 148,
    EVT_ENTRYID_SWAP = 181,
    EVT_INSIDE_NCP_REQUEST = 182,
    EVT_INSPECT_ENTRY = 127,
    EVT_INVALID = 0,
    EVT_ITERATOR = 224,
    EVT_JOIN_DONE = 86,
    EVT_JOIN_PARTITIONS = 106,
    EVT_LIMBER_DONE = 76,
    EVT_LIST_CONT_CLASSES = 126,
    EVT_LIST_PARTITIONS = 133,
    EVT_LIST_SUBORDINATES = 125,
    EVT_LOCAL_REPLICA_CHANGE = 197,
    EVT_LOGIN = 100,
    EVT_LOGOUT = 102,
    EVT_LOST_ENTRY = 70,
    EVT_LOW_LEVEL_JOIN = 162,
    EVT_LOW_LEVEL_JOIN_BEGIN = 226,
    EVT_LOW_LEVEL_SPLIT = 185,
    EVT_LUMBER_DONE = 94,
    EVT_MAX_EVENTS = 243,
    EVT_MERGE_ENTRIES = 130,
    EVT_MERGE_TREE = 131,
    EVT_MODIFY_CLASS_DEF = 120,
    EVT_MODIFY_ENTRY = 169,
    EVT_MODIFY_RDN = 178,
    EVT_MOVE_DEST_ENTRY = 14,
    EVT_MOVE_ENTRY_DEST = 200,
    EVT_MOVE_ENTRY_SOURCE = 199,
    EVT_MOVE_SOURCE_ENTRY = 4,
    EVT_MOVE_SUBTREE = 59,
    EVT_MOVE_TREE = 149,
    EVT_MOVE_TREE_END = 83,
    EVT_MOVE_TREE_START = 82,
    EVT_MUTATE_ENTRY = 129,
    EVT_NAME_COLLISION = 90,
    EVT_NCP_RETRY_EXPENDED = 18,
    EVT_NEW_SCHEMA_EPOCH = 174,
    EVT_NLM_LOADED = 91,
    EVT_NO_REPLICA_PTR = 60,
    EVT_NOTIFY_REF_CHANGE = 201,
    EVT_OPEN_BINDERY = 171,
    EVT_PARTITION_LOCKED = 87,
    EVT_PARTITION_OPERATION_EVENT = 20,
    EVT_PARTITION_STATE_CHG = 160,
    EVT_PARTITION_UNLOCKED = 88,
    EVT_PRE_DELETE_ENTRY = 228,
    EVT_PURGE_END = 73,
    EVT_PURGE_ENTRY_FAIL = 71,
    EVT_PURGE_START = 72,
    EVT_READ_ATTR = 134,
    EVT_READ_REFERENCES = 135,
    EVT_RECV_REPLICA_UPDATES = 110,
    EVT_REFERRAL = 67,
    EVT_RELOAD_DS = 150,
    EVT_REMOTE_SERVER_DOWN = 17,
    EVT_REMOVE_ATTR_DEF = 117,
    EVT_REMOVE_BACKLINK = 161,
    EVT_REMOVE_CLASS_DEF = 118,
    EVT_REMOVE_ENTRY = 108,
    EVT_REMOVE_ENTRY_DIR = 122,
    EVT_REMOVE_REPLICA = 104,
    EVT_RENAME_ENTRY = 3,
    EVT_REPAIR_TIME_STAMPS = 111,
    EVT_REPLICA_IN_TRANSITION = 208,
    EVT_REQ_UPDATE_SERVER_STATUS = 216,
    EVT_RESEND_ENTRY = 128,
    EVT_RESET_DS_COUNTERS = 121,
    EVT_RESTORE_ENTRY = 115,
    EVT_SCHEMA_SYNC = 89,
    EVT_SEARCH = 159,
    EVT_SEND_REPLICA_UPDATES = 112,
    EVT_SERVER_ADDRESS_CHANGE = 98,
    EVT_SERVER_RENAME = 96,
    EVT_SET_BINDERY_CONTEXT = 9,
    EVT_SPLIT_DONE = 77,
    EVT_SPLIT_PARTITION = 105,
    EVT_START_JOIN = 144,
    EVT_START_UPDATE_REPLICA = 137,
    EVT_START_UPDATE_SCHEMA = 147,
    EVT_STATUS_LOG = 241,
    EVT_STREAM = 124,
    EVT_SYNC_IN_END = 61,
    EVT_SYNC_PART_END = 81,
    EVT_SYNC_PART_START = 80,
    EVT_SYNC_PARTITION = 139,
    EVT_SYNC_SCHEMA = 140,
    EVT_SYNC_SVR_OUT_END = 79,
    EVT_SYNC_SVR_OUT_START = 78,
    EVT_SYNTHETIC_TIME = 97,
    EVT_UPDATE_ATTR_DEF = 69,
    EVT_UPDATE_CLASS_DEF = 68,
    EVT_UPDATE_REPLICA = 136,
    EVT_UPDATE_SCHEMA = 146,
    EVT_UPDATE_SEV = 13,
    EVT_VERIFY_PASS = 113,
    EVT_VR_DRIVER_STATE_CHANGE = 215,
  }
  public partial class EventOids {
    public const string NLDAP_EVENT_NOTIFICATION = "2.16.840.1.113719.1.27.100.81";
    public const string NLDAP_FILTERED_MONITOR_EVENTS_REQUEST = "2.16.840.1.113719.1.27.100.84";
    public const string NLDAP_MONITOR_EVENTS_REQUEST = "2.16.840.1.113719.1.27.100.79";
    public const string NLDAP_MONITOR_EVENTS_RESPONSE = "2.16.840.1.113719.1.27.100.80";
    public EventOids() { }
  }
  public enum GeneralEventField {
    EVT_TAG_GEN_CURRPROC = 4,
    EVT_TAG_GEN_DSTIME = 1,
    EVT_TAG_GEN_INTEGERS = 6,
    EVT_TAG_GEN_MILLISEC = 2,
    EVT_TAG_GEN_PERP = 5,
    EVT_TAG_GEN_STRINGS = 7,
    EVT_TAG_GEN_VERB = 3,
  }
  public partial class MonitorEventRequest : Novell.Directory.Ldap.LdapExtendedOperation {
    public MonitorEventRequest(Novell.Directory.Ldap.Events.Edir.EdirEventSpecifier[] specifiers) : base (default(string), default(System.SByte[])) { }
  }
  public partial class MonitorEventResponse : Novell.Directory.Ldap.LdapExtendedResponse {
    protected Novell.Directory.Ldap.Events.Edir.EdirEventSpecifier[] specifier_list;
    public MonitorEventResponse(Novell.Directory.Ldap.Rfc2251.RfcLdapMessage message) : base (default(Novell.Directory.Ldap.Rfc2251.RfcLdapMessage)) { }
    public Novell.Directory.Ldap.Events.Edir.EdirEventSpecifier[] SpecifierList { get { return default(Novell.Directory.Ldap.Events.Edir.EdirEventSpecifier[]); } }
  }
}
namespace Novell.Directory.Ldap.Events.Edir.EventData {
  public partial class BaseEdirEventData {
    protected System.IO.MemoryStream decodedData;
    protected Novell.Directory.Ldap.Asn1.LBERDecoder decoder;
    protected Novell.Directory.Ldap.Events.Edir.EdirEventDataType event_data_type;
    public BaseEdirEventData(Novell.Directory.Ldap.Events.Edir.EdirEventDataType eventDataType, Novell.Directory.Ldap.Asn1.Asn1Object message) { }
    public Novell.Directory.Ldap.Events.Edir.EdirEventDataType EventDataType { get { return default(Novell.Directory.Ldap.Events.Edir.EdirEventDataType); } }
    protected void DataInitDone() { }
  }
  public partial class BinderyObjectEventData : Novell.Directory.Ldap.Events.Edir.EventData.BaseEdirEventData {
    protected int nEmuObjFlags;
    protected int nSecurity;
    protected int nType;
    protected string strEntryDN;
    protected string strName;
    public BinderyObjectEventData(Novell.Directory.Ldap.Events.Edir.EdirEventDataType eventDataType, Novell.Directory.Ldap.Asn1.Asn1Object message) : base (default(Novell.Directory.Ldap.Events.Edir.EdirEventDataType), default(Novell.Directory.Ldap.Asn1.Asn1Object)) { }
    public int EmuObjFlags { get { return default(int); } }
    public string EntryDN { get { return default(string); } }
    public string Name { get { return default(string); } }
    public int Security { get { return default(int); } }
    public int ValueType { get { return default(int); } }
    public override string ToString() { return default(string); }
  }
  public partial class ChangeAddressEventData : Novell.Directory.Ldap.Events.Edir.EventData.BaseEdirEventData {
    protected int address_family;
    protected int nFlags;
    protected int nProto;
    protected string pstk_name;
    protected string source_module;
    protected string strAddress;
    public ChangeAddressEventData(Novell.Directory.Ldap.Events.Edir.EdirEventDataType eventDataType, Novell.Directory.Ldap.Asn1.Asn1Object message) : base (default(Novell.Directory.Ldap.Events.Edir.EdirEventDataType), default(Novell.Directory.Ldap.Asn1.Asn1Object)) { }
    public string Address { get { return default(string); } }
    public int AddressFamily { get { return default(int); } }
    public int Flags { get { return default(int); } }
    public int Proto { get { return default(int); } }
    public string PstkName { get { return default(string); } }
    public string SourceModule { get { return default(string); } }
    public override string ToString() { return default(string); }
  }
  public partial class ConnectionStateEventData : Novell.Directory.Ldap.Events.Edir.EventData.BaseEdirEventData {
    protected int new_flags;
    protected int old_flags;
    protected string source_module;
    protected string strConnectionDN;
    public ConnectionStateEventData(Novell.Directory.Ldap.Events.Edir.EdirEventDataType eventDataType, Novell.Directory.Ldap.Asn1.Asn1Object message) : base (default(Novell.Directory.Ldap.Events.Edir.EdirEventDataType), default(Novell.Directory.Ldap.Asn1.Asn1Object)) { }
    public string ConnectionDN { get { return default(string); } }
    public int NewFlags { get { return default(int); } }
    public int OldFlags { get { return default(int); } }
    public string SourceModule { get { return default(string); } }
    public override string ToString() { return default(string); }
  }
  public partial class DebugEventData : Novell.Directory.Ldap.Events.Edir.EventData.BaseEdirEventData {
    protected int ds_time;
    protected int milli_seconds;
    protected int nVerb;
    protected System.Collections.ArrayList parameter_collection;
    protected int parameter_count;
    protected string strFormatString;
    protected string strPerpetratorDN;
    public DebugEventData(Novell.Directory.Ldap.Events.Edir.EdirEventDataType eventDataType, Novell.Directory.Ldap.Asn1.Asn1Object message) : base (default(Novell.Directory.Ldap.Events.Edir.EdirEventDataType), default(Novell.Directory.Ldap.Asn1.Asn1Object)) { }
    public int DSTime { get { return default(int); } }
    public string FormatString { get { return default(string); } }
    public int MilliSeconds { get { return default(int); } }
    public int ParameterCount { get { return default(int); } }
    public System.Collections.ArrayList Parameters { get { return default(System.Collections.ArrayList); } }
    public string PerpetratorDN { get { return default(string); } }
    public int Verb { get { return default(int); } }
    public override string ToString() { return default(string); }
  }
  public partial class DebugParameter {
    protected Novell.Directory.Ldap.Events.Edir.DebugParameterType debug_type;
    protected object objData;
    public DebugParameter(Novell.Directory.Ldap.Asn1.Asn1Tagged dseObject) { }
    public object Data { get { return default(object); } }
    public Novell.Directory.Ldap.Events.Edir.DebugParameterType DebugType { get { return default(Novell.Directory.Ldap.Events.Edir.DebugParameterType); } }
    protected int getTaggedIntValue(Novell.Directory.Ldap.Asn1.Asn1Tagged tagVal) { return default(int); }
    protected Novell.Directory.Ldap.Asn1.Asn1Sequence getTaggedSequence(Novell.Directory.Ldap.Asn1.Asn1Tagged tagVal) { return default(Novell.Directory.Ldap.Asn1.Asn1Sequence); }
    public override string ToString() { return default(string); }
  }
  public partial class EntryEventData : Novell.Directory.Ldap.Events.Edir.EventData.BaseEdirEventData {
    protected int nFlags;
    protected int nVerb;
    protected string strClassId;
    protected string strEntry;
    protected string strNewDN;
    protected string strPerpetratorDN;
    protected Novell.Directory.Ldap.Events.Edir.DSETimeStamp timeStampObj;
    public EntryEventData(Novell.Directory.Ldap.Events.Edir.EdirEventDataType eventDataType, Novell.Directory.Ldap.Asn1.Asn1Object message) : base (default(Novell.Directory.Ldap.Events.Edir.EdirEventDataType), default(Novell.Directory.Ldap.Asn1.Asn1Object)) { }
    public string ClassId { get { return default(string); } }
    public string Entry { get { return default(string); } }
    public int Flags { get { return default(int); } }
    public string NewDN { get { return default(string); } }
    public string PerpetratorDN { get { return default(string); } }
    public Novell.Directory.Ldap.Events.Edir.DSETimeStamp TimeStamp { get { return default(Novell.Directory.Ldap.Events.Edir.DSETimeStamp); } }
    public int Verb { get { return default(int); } }
    public override string ToString() { return default(string); }
  }
  public partial class GeneralDSEventData : Novell.Directory.Ldap.Events.Edir.EventData.BaseEdirEventData {
    protected int current_process;
    protected int ds_time;
    protected System.Int32[] integer_values;
    protected int milli_seconds;
    protected int nVerb;
    protected System.String[] string_values;
    protected string strPerpetratorDN;
    public GeneralDSEventData(Novell.Directory.Ldap.Events.Edir.EdirEventDataType eventDataType, Novell.Directory.Ldap.Asn1.Asn1Object message) : base (default(Novell.Directory.Ldap.Events.Edir.EdirEventDataType), default(Novell.Directory.Ldap.Asn1.Asn1Object)) { }
    public int CurrentProcess { get { return default(int); } }
    public int DSTime { get { return default(int); } }
    public System.Int32[] IntegerValues { get { return default(System.Int32[]); } }
    public int MilliSeconds { get { return default(int); } }
    public string PerpetratorDN { get { return default(string); } }
    public System.String[] StringValues { get { return default(System.String[]); } }
    public int Verb { get { return default(int); } }
    protected int getTaggedIntValue(Novell.Directory.Ldap.Asn1.Asn1Tagged tagvalue, Novell.Directory.Ldap.Events.Edir.GeneralEventField tagid) { return default(int); }
    protected Novell.Directory.Ldap.Asn1.Asn1Sequence getTaggedSequence(Novell.Directory.Ldap.Asn1.Asn1Tagged tagvalue, Novell.Directory.Ldap.Events.Edir.GeneralEventField tagid) { return default(Novell.Directory.Ldap.Asn1.Asn1Sequence); }
    protected string getTaggedStringValue(Novell.Directory.Ldap.Asn1.Asn1Tagged tagvalue, Novell.Directory.Ldap.Events.Edir.GeneralEventField tagid) { return default(string); }
    public override string ToString() { return default(string); }
  }
  public partial class ModuleStateEventData : Novell.Directory.Ldap.Events.Edir.EventData.BaseEdirEventData {
    protected int nFlags;
    protected string strConnectionDN;
    protected string strDescription;
    protected string strName;
    protected string strSource;
    public ModuleStateEventData(Novell.Directory.Ldap.Events.Edir.EdirEventDataType eventDataType, Novell.Directory.Ldap.Asn1.Asn1Object message) : base (default(Novell.Directory.Ldap.Events.Edir.EdirEventDataType), default(Novell.Directory.Ldap.Asn1.Asn1Object)) { }
    public string ConnectionDN { get { return default(string); } }
    public string Description { get { return default(string); } }
    public int Flags { get { return default(int); } }
    public string Name { get { return default(string); } }
    public string Source { get { return default(string); } }
    public override string ToString() { return default(string); }
  }
  public partial class NetworkAddressEventData : Novell.Directory.Ldap.Events.Edir.EventData.BaseEdirEventData {
    protected int nType;
    protected string strData;
    public NetworkAddressEventData(Novell.Directory.Ldap.Events.Edir.EdirEventDataType eventDataType, Novell.Directory.Ldap.Asn1.Asn1Object message) : base (default(Novell.Directory.Ldap.Events.Edir.EdirEventDataType), default(Novell.Directory.Ldap.Asn1.Asn1Object)) { }
    public string Data { get { return default(string); } }
    public int ValueType { get { return default(int); } }
    public override string ToString() { return default(string); }
  }
  public partial class ReferralAddress {
    protected int address_type;
    protected string strAddress;
    public ReferralAddress(Novell.Directory.Ldap.Asn1.Asn1Sequence dseObject) { }
    public string Address { get { return default(string); } }
    public int AddressType { get { return default(int); } }
  }
  public partial class SecurityEquivalenceEventData : Novell.Directory.Ldap.Events.Edir.EventData.BaseEdirEventData {
    protected int referral_count;
    protected System.Collections.ArrayList referral_list;
    protected int retry_count;
    protected string strEntryDN;
    protected string strValueDN;
    public SecurityEquivalenceEventData(Novell.Directory.Ldap.Events.Edir.EdirEventDataType eventDataType, Novell.Directory.Ldap.Asn1.Asn1Object message) : base (default(Novell.Directory.Ldap.Events.Edir.EdirEventDataType), default(Novell.Directory.Ldap.Asn1.Asn1Object)) { }
    public string EntryDN { get { return default(string); } }
    public int ReferralCount { get { return default(int); } }
    public System.Collections.ArrayList ReferralList { get { return default(System.Collections.ArrayList); } }
    public int RetryCount { get { return default(int); } }
    public string ValueDN { get { return default(string); } }
    public override string ToString() { return default(string); }
  }
  public partial class ValueEventData : Novell.Directory.Ldap.Events.Edir.EventData.BaseEdirEventData {
    protected System.Byte[] binData;
    protected int nVerb;
    protected string strAttribute;
    protected string strClassId;
    protected string strData;
    protected string strEntry;
    protected string strPerpetratorDN;
    protected string strSyntax;
    protected Novell.Directory.Ldap.Events.Edir.DSETimeStamp timeStampObj;
    public ValueEventData(Novell.Directory.Ldap.Events.Edir.EdirEventDataType eventDataType, Novell.Directory.Ldap.Asn1.Asn1Object message) : base (default(Novell.Directory.Ldap.Events.Edir.EdirEventDataType), default(Novell.Directory.Ldap.Asn1.Asn1Object)) { }
    public string Attribute { get { return default(string); } }
    public System.Byte[] BinaryData { get { return default(System.Byte[]); } }
    public string ClassId { get { return default(string); } }
    public string Data { get { return default(string); } }
    public string Entry { get { return default(string); } }
    public string PerpetratorDN { get { return default(string); } }
    public string Syntax { get { return default(string); } }
    public Novell.Directory.Ldap.Events.Edir.DSETimeStamp TimeStamp { get { return default(Novell.Directory.Ldap.Events.Edir.DSETimeStamp); } }
    public int Verb { get { return default(int); } }
    public override string ToString() { return default(string); }
  }
}
namespace Novell.Directory.Ldap.Extensions {
  public partial class AbortPartitionOperationRequest : Novell.Directory.Ldap.LdapExtendedOperation {
    public AbortPartitionOperationRequest(string partitionDN, int flags) : base (default(string), default(System.SByte[])) { }
  }
  public partial class AddReplicaRequest : Novell.Directory.Ldap.LdapExtendedOperation {
    public AddReplicaRequest(string dn, string serverDN, int replicaType, int flags) : base (default(string), default(System.SByte[])) { }
  }
  public partial class BackupRestoreConstants {
    public const string NLDAP_LDAP_BACKUP_REQUEST = "2.16.840.1.113719.1.27.100.96";
    public const string NLDAP_LDAP_BACKUP_RESPONSE = "2.16.840.1.113719.1.27.100.97";
    public const string NLDAP_LDAP_RESTORE_REQUEST = "2.16.840.1.113719.1.27.100.98";
    public const string NLDAP_LDAP_RESTORE_RESPONSE = "2.16.840.1.113719.1.27.100.99";
    public BackupRestoreConstants() { }
  }
  public partial class ChangeReplicaTypeRequest : Novell.Directory.Ldap.LdapExtendedOperation {
    public ChangeReplicaTypeRequest(string dn, string serverDN, int replicaType, int flags) : base (default(string), default(System.SByte[])) { }
  }
  public partial class GetBindDNRequest : Novell.Directory.Ldap.LdapExtendedOperation {
    public GetBindDNRequest() : base (default(string), default(System.SByte[])) { }
  }
  public partial class GetBindDNResponse : Novell.Directory.Ldap.LdapExtendedResponse {
    public GetBindDNResponse(Novell.Directory.Ldap.Rfc2251.RfcLdapMessage rfcMessage) : base (default(Novell.Directory.Ldap.Rfc2251.RfcLdapMessage)) { }
    public virtual string Identity { get { return default(string); } }
  }
  public partial class GetEffectivePrivilegesRequest : Novell.Directory.Ldap.LdapExtendedOperation {
    public GetEffectivePrivilegesRequest(string dn, string trusteeDN, string attrName) : base (default(string), default(System.SByte[])) { }
  }
  public partial class GetEffectivePrivilegesResponse : Novell.Directory.Ldap.LdapExtendedResponse {
    public GetEffectivePrivilegesResponse(Novell.Directory.Ldap.Rfc2251.RfcLdapMessage rfcMessage) : base (default(Novell.Directory.Ldap.Rfc2251.RfcLdapMessage)) { }
    public virtual int Privileges { get { return default(int); } }
  }
  public partial class GetReplicaInfoRequest : Novell.Directory.Ldap.LdapExtendedOperation {
    public GetReplicaInfoRequest(string serverDN, string partitionDN) : base (default(string), default(System.SByte[])) { }
  }
  public partial class GetReplicaInfoResponse : Novell.Directory.Ldap.LdapExtendedResponse {
    public GetReplicaInfoResponse(Novell.Directory.Ldap.Rfc2251.RfcLdapMessage rfcMessage) : base (default(Novell.Directory.Ldap.Rfc2251.RfcLdapMessage)) { }
    public virtual int getflags() { return default(int); }
    public virtual int getlocalPartitionID() { return default(int); }
    public virtual int getmodificationTime() { return default(int); }
    public virtual string getpartitionDN() { return default(string); }
    public virtual int getpartitionID() { return default(int); }
    public virtual int getpurgeTime() { return default(int); }
    public virtual int getreplicaState() { return default(int); }
    public virtual int getreplicaType() { return default(int); }
  }
  public partial class GetReplicationFilterRequest : Novell.Directory.Ldap.LdapExtendedOperation {
    public GetReplicationFilterRequest(string serverDN) : base (default(string), default(System.SByte[])) { }
  }
  public partial class GetReplicationFilterResponse : Novell.Directory.Ldap.LdapExtendedResponse {
    public GetReplicationFilterResponse(Novell.Directory.Ldap.Rfc2251.RfcLdapMessage rfcMessage) : base (default(Novell.Directory.Ldap.Rfc2251.RfcLdapMessage)) { }
    public virtual System.String[][] ReplicationFilter { get { return default(System.String[][]); } }
  }
  public partial class LdapBackupRequest : Novell.Directory.Ldap.LdapExtendedOperation {
    public LdapBackupRequest(string objectDN, System.Byte[] passwd, string stateInfo) : base (default(string), default(System.SByte[])) { }
  }
  public partial class LdapBackupResponse : Novell.Directory.Ldap.LdapExtendedResponse {
    public LdapBackupResponse(Novell.Directory.Ldap.Rfc2251.RfcLdapMessage rfcMessage) : base (default(Novell.Directory.Ldap.Rfc2251.RfcLdapMessage)) { }
    public int getBufferLength() { return default(int); }
    public string getChunkSizesString() { return default(string); }
    public System.Byte[] getReturnedBuffer() { return default(System.Byte[]); }
    public string getStatusInfo() { return default(string); }
  }
  public partial class LdapRestoreRequest : Novell.Directory.Ldap.LdapExtendedOperation {
    public LdapRestoreRequest(string objectDN, System.Byte[] passwd, int bufferLength, string chunkSizesString, System.Byte[] returnedBuffer) : base (default(string), default(System.SByte[])) { }
  }
  public partial class ListReplicasRequest : Novell.Directory.Ldap.LdapExtendedOperation {
    public ListReplicasRequest(string serverName) : base (default(string), default(System.SByte[])) { }
  }
  public partial class ListReplicasResponse : Novell.Directory.Ldap.LdapExtendedResponse {
    public ListReplicasResponse(Novell.Directory.Ldap.Rfc2251.RfcLdapMessage rfcMessage) : base (default(Novell.Directory.Ldap.Rfc2251.RfcLdapMessage)) { }
    public virtual System.String[] ReplicaList { get { return default(System.String[]); } }
  }
  public partial class MergePartitionsRequest : Novell.Directory.Ldap.LdapExtendedOperation {
    public MergePartitionsRequest(string dn, int flags) : base (default(string), default(System.SByte[])) { }
  }
  public partial class NamingContextConstants {
    public const string ABORT_NAMING_CONTEXT_OP_REQ = "2.16.840.1.113719.1.27.100.29";
    public const string ABORT_NAMING_CONTEXT_OP_RES = "2.16.840.1.113719.1.27.100.30";
    public const string ADD_REPLICA_REQ = "2.16.840.1.113719.1.27.100.7";
    public const string ADD_REPLICA_RES = "2.16.840.1.113719.1.27.100.8";
    public const string CHANGE_REPLICA_TYPE_REQ = "2.16.840.1.113719.1.27.100.15";
    public const string CHANGE_REPLICA_TYPE_RES = "2.16.840.1.113719.1.27.100.16";
    public const string CREATE_NAMING_CONTEXT_REQ = "2.16.840.1.113719.1.27.100.3";
    public const string CREATE_NAMING_CONTEXT_RES = "2.16.840.1.113719.1.27.100.4";
    public const string CREATE_ORPHAN_NAMING_CONTEXT_REQ = "2.16.840.1.113719.1.27.100.39";
    public const string CREATE_ORPHAN_NAMING_CONTEXT_RES = "2.16.840.1.113719.1.27.100.40";
    public const string DELETE_REPLICA_REQ = "2.16.840.1.113719.1.27.100.11";
    public const string DELETE_REPLICA_RES = "2.16.840.1.113719.1.27.100.12";
    public const string GET_EFFECTIVE_PRIVILEGES_REQ = "2.16.840.1.113719.1.27.100.33";
    public const string GET_EFFECTIVE_PRIVILEGES_RES = "2.16.840.1.113719.1.27.100.34";
    public const string GET_IDENTITY_NAME_REQ = "2.16.840.1.113719.1.27.100.31";
    public const string GET_IDENTITY_NAME_RES = "2.16.840.1.113719.1.27.100.32";
    public const string GET_REPLICA_INFO_REQ = "2.16.840.1.113719.1.27.100.17";
    public const string GET_REPLICA_INFO_RES = "2.16.840.1.113719.1.27.100.18";
    public const string GET_REPLICATION_FILTER_REQ = "2.16.840.1.113719.1.27.100.37";
    public const string GET_REPLICATION_FILTER_RES = "2.16.840.1.113719.1.27.100.38";
    public const int Ldap_DS_FLAG_BOUNDARY = 2;
    public const int Ldap_DS_FLAG_BUSY = 1;
    public const int Ldap_ENSURE_SERVERS_UP = 1;
    public const int Ldap_RS_BEGIN_ADD = 8;
    public const int Ldap_RS_DEAD_REPLICA = 7;
    public const int Ldap_RS_DYING_REPLICA = 2;
    public const int Ldap_RS_JS_0 = 64;
    public const int Ldap_RS_JS_1 = 65;
    public const int Ldap_RS_JS_2 = 66;
    public const int Ldap_RS_LOCKED = 3;
    public const int Ldap_RS_MASTER_DONE = 12;
    public const int Ldap_RS_MASTER_START = 11;
    public const int Ldap_RS_NEW_REPLICA = 1;
    public const int Ldap_RS_ON = 0;
    public const int Ldap_RS_SS_0 = 48;
    public const int Ldap_RS_SS_1 = 49;
    public const int Ldap_RS_TRANSITION_ON = 6;
    public const int Ldap_RT_MASTER = 0;
    public const int Ldap_RT_READONLY = 2;
    public const int Ldap_RT_SECONDARY = 1;
    public const int Ldap_RT_SPARSE_READ = 5;
    public const int Ldap_RT_SPARSE_WRITE = 4;
    public const int Ldap_RT_SUBREF = 3;
    public const string LIST_REPLICAS_REQ = "2.16.840.1.113719.1.27.100.19";
    public const string LIST_REPLICAS_RES = "2.16.840.1.113719.1.27.100.20";
    public const string MERGE_NAMING_CONTEXT_REQ = "2.16.840.1.113719.1.27.100.5";
    public const string MERGE_NAMING_CONTEXT_RES = "2.16.840.1.113719.1.27.100.6";
    public const string NAMING_CONTEXT_COUNT_REQ = "2.16.840.1.113719.1.27.100.13";
    public const string NAMING_CONTEXT_COUNT_RES = "2.16.840.1.113719.1.27.100.14";
    public const string NAMING_CONTEXT_SYNC_REQ = "2.16.840.1.113719.1.27.100.25";
    public const string NAMING_CONTEXT_SYNC_RES = "2.16.840.1.113719.1.27.100.26";
    public const string RECEIVE_ALL_UPDATES_REQ = "2.16.840.1.113719.1.27.100.21";
    public const string RECEIVE_ALL_UPDATES_RES = "2.16.840.1.113719.1.27.100.22";
    public const string REFRESH_SERVER_REQ = "2.16.840.1.113719.1.27.100.9";
    public const string REFRESH_SERVER_RES = "2.16.840.1.113719.1.27.100.10";
    public const string REMOVE_ORPHAN_NAMING_CONTEXT_REQ = "2.16.840.1.113719.1.27.100.41";
    public const string REMOVE_ORPHAN_NAMING_CONTEXT_RES = "2.16.840.1.113719.1.27.100.42";
    public const string SCHEMA_SYNC_REQ = "2.16.840.1.113719.1.27.100.27";
    public const string SCHEMA_SYNC_RES = "2.16.840.1.113719.1.27.100.28";
    public const string SEND_ALL_UPDATES_REQ = "2.16.840.1.113719.1.27.100.23";
    public const string SEND_ALL_UPDATES_RES = "2.16.840.1.113719.1.27.100.24";
    public const string SET_REPLICATION_FILTER_REQ = "2.16.840.1.113719.1.27.100.35";
    public const string SET_REPLICATION_FILTER_RES = "2.16.840.1.113719.1.27.100.36";
    public const string TRIGGER_BKLINKER_REQ = "2.16.840.1.113719.1.27.100.43";
    public const string TRIGGER_BKLINKER_RES = "2.16.840.1.113719.1.27.100.44";
    public const string TRIGGER_JANITOR_REQ = "2.16.840.1.113719.1.27.100.47";
    public const string TRIGGER_JANITOR_RES = "2.16.840.1.113719.1.27.100.48";
    public const string TRIGGER_LIMBER_REQ = "2.16.840.1.113719.1.27.100.49";
    public const string TRIGGER_LIMBER_RES = "2.16.840.1.113719.1.27.100.50";
    public const string TRIGGER_PART_PURGE_REQ = "2.16.840.1.113719.1.27.100.55";
    public const string TRIGGER_PART_PURGE_RES = "2.16.840.1.113719.1.27.100.56";
    public const string TRIGGER_SCHEMA_SYNC_REQ = "2.16.840.1.113719.1.27.100.53";
    public const string TRIGGER_SCHEMA_SYNC_RES = "2.16.840.1.113719.1.27.100.54";
    public const string TRIGGER_SKULKER_REQ = "2.16.840.1.113719.1.27.100.51";
    public const string TRIGGER_SKULKER_RES = "2.16.840.1.113719.1.27.100.52";
    public NamingContextConstants() { }
  }
  public partial class PartitionEntryCountRequest : Novell.Directory.Ldap.LdapExtendedOperation {
    public PartitionEntryCountRequest(string dn) : base (default(string), default(System.SByte[])) { }
  }
  public partial class PartitionEntryCountResponse : Novell.Directory.Ldap.LdapExtendedResponse {
    public PartitionEntryCountResponse(Novell.Directory.Ldap.Rfc2251.RfcLdapMessage rfcMessage) : base (default(Novell.Directory.Ldap.Rfc2251.RfcLdapMessage)) { }
    public virtual int Count { get { return default(int); } }
  }
  public partial class PartitionSyncRequest : Novell.Directory.Ldap.LdapExtendedOperation {
    public PartitionSyncRequest(string serverName, string partitionRoot, int delay) : base (default(string), default(System.SByte[])) { }
  }
  public partial class ReceiveAllUpdatesRequest : Novell.Directory.Ldap.LdapExtendedOperation {
    public ReceiveAllUpdatesRequest(string partitionRoot, string toServerDN, string fromServerDN) : base (default(string), default(System.SByte[])) { }
  }
  public partial class RefreshLdapServerRequest : Novell.Directory.Ldap.LdapExtendedOperation {
    public RefreshLdapServerRequest() : base (default(string), default(System.SByte[])) { }
  }
  public partial class RemoveOrphanPartitionRequest : Novell.Directory.Ldap.LdapExtendedOperation {
    public RemoveOrphanPartitionRequest(string serverDN, string contextName) : base (default(string), default(System.SByte[])) { }
  }
  public partial class RemoveReplicaRequest : Novell.Directory.Ldap.LdapExtendedOperation {
    public RemoveReplicaRequest(string dn, string serverDN, int flags) : base (default(string), default(System.SByte[])) { }
  }
  public partial class ReplicationConstants {
    public const string ABORT_NAMING_CONTEXT_OP_REQ = "2.16.840.1.113719.1.27.100.29";
    public const string ABORT_NAMING_CONTEXT_OP_RES = "2.16.840.1.113719.1.27.100.30";
    public const string ADD_REPLICA_REQ = "2.16.840.1.113719.1.27.100.7";
    public const string ADD_REPLICA_RES = "2.16.840.1.113719.1.27.100.8";
    public const string CHANGE_REPLICA_TYPE_REQ = "2.16.840.1.113719.1.27.100.15";
    public const string CHANGE_REPLICA_TYPE_RES = "2.16.840.1.113719.1.27.100.16";
    public const string CREATE_NAMING_CONTEXT_REQ = "2.16.840.1.113719.1.27.100.3";
    public const string CREATE_NAMING_CONTEXT_RES = "2.16.840.1.113719.1.27.100.4";
    public const string CREATE_ORPHAN_NAMING_CONTEXT_REQ = "2.16.840.1.113719.1.27.100.39";
    public const string CREATE_ORPHAN_NAMING_CONTEXT_RES = "2.16.840.1.113719.1.27.100.40";
    public const string DELETE_REPLICA_REQ = "2.16.840.1.113719.1.27.100.11";
    public const string DELETE_REPLICA_RES = "2.16.840.1.113719.1.27.100.12";
    public const string GET_EFFECTIVE_PRIVILEGES_REQ = "2.16.840.1.113719.1.27.100.33";
    public const string GET_EFFECTIVE_PRIVILEGES_RES = "2.16.840.1.113719.1.27.100.34";
    public const string GET_IDENTITY_NAME_REQ = "2.16.840.1.113719.1.27.100.31";
    public const string GET_IDENTITY_NAME_RES = "2.16.840.1.113719.1.27.100.32";
    public const string GET_REPLICA_INFO_REQ = "2.16.840.1.113719.1.27.100.17";
    public const string GET_REPLICA_INFO_RES = "2.16.840.1.113719.1.27.100.18";
    public const string GET_REPLICATION_FILTER_REQ = "2.16.840.1.113719.1.27.100.37";
    public const string GET_REPLICATION_FILTER_RES = "2.16.840.1.113719.1.27.100.38";
    public const int Ldap_DS_FLAG_BOUNDARY = 2;
    public const int Ldap_DS_FLAG_BUSY = 1;
    public const int Ldap_ENSURE_SERVERS_UP = 1;
    public const int Ldap_RS_BEGIN_ADD = 8;
    public const int Ldap_RS_DEAD_REPLICA = 7;
    public const int Ldap_RS_DYING_REPLICA = 2;
    public const int Ldap_RS_JS_0 = 64;
    public const int Ldap_RS_JS_1 = 65;
    public const int Ldap_RS_JS_2 = 66;
    public const int Ldap_RS_LOCKED = 3;
    public const int Ldap_RS_MASTER_DONE = 12;
    public const int Ldap_RS_MASTER_START = 11;
    public const int Ldap_RS_NEW_REPLICA = 1;
    public const int Ldap_RS_ON = 0;
    public const int Ldap_RS_SS_0 = 48;
    public const int Ldap_RS_SS_1 = 49;
    public const int Ldap_RS_TRANSITION_ON = 6;
    public const int Ldap_RT_MASTER = 0;
    public const int Ldap_RT_READONLY = 2;
    public const int Ldap_RT_SECONDARY = 1;
    public const int Ldap_RT_SPARSE_READ = 5;
    public const int Ldap_RT_SPARSE_WRITE = 4;
    public const int Ldap_RT_SUBREF = 3;
    public const string LIST_REPLICAS_REQ = "2.16.840.1.113719.1.27.100.19";
    public const string LIST_REPLICAS_RES = "2.16.840.1.113719.1.27.100.20";
    public const string MERGE_NAMING_CONTEXT_REQ = "2.16.840.1.113719.1.27.100.5";
    public const string MERGE_NAMING_CONTEXT_RES = "2.16.840.1.113719.1.27.100.6";
    public const string NAMING_CONTEXT_COUNT_REQ = "2.16.840.1.113719.1.27.100.13";
    public const string NAMING_CONTEXT_COUNT_RES = "2.16.840.1.113719.1.27.100.14";
    public const string NAMING_CONTEXT_SYNC_REQ = "2.16.840.1.113719.1.27.100.25";
    public const string NAMING_CONTEXT_SYNC_RES = "2.16.840.1.113719.1.27.100.26";
    public const string RECEIVE_ALL_UPDATES_REQ = "2.16.840.1.113719.1.27.100.21";
    public const string RECEIVE_ALL_UPDATES_RES = "2.16.840.1.113719.1.27.100.22";
    public const string REFRESH_SERVER_REQ = "2.16.840.1.113719.1.27.100.9";
    public const string REFRESH_SERVER_RES = "2.16.840.1.113719.1.27.100.10";
    public const string REMOVE_ORPHAN_NAMING_CONTEXT_REQ = "2.16.840.1.113719.1.27.100.41";
    public const string REMOVE_ORPHAN_NAMING_CONTEXT_RES = "2.16.840.1.113719.1.27.100.42";
    public const string SCHEMA_SYNC_REQ = "2.16.840.1.113719.1.27.100.27";
    public const string SCHEMA_SYNC_RES = "2.16.840.1.113719.1.27.100.28";
    public const string SEND_ALL_UPDATES_REQ = "2.16.840.1.113719.1.27.100.23";
    public const string SEND_ALL_UPDATES_RES = "2.16.840.1.113719.1.27.100.24";
    public const string SET_REPLICATION_FILTER_REQ = "2.16.840.1.113719.1.27.100.35";
    public const string SET_REPLICATION_FILTER_RES = "2.16.840.1.113719.1.27.100.36";
    public const string TRIGGER_BKLINKER_REQ = "2.16.840.1.113719.1.27.100.43";
    public const string TRIGGER_BKLINKER_RES = "2.16.840.1.113719.1.27.100.44";
    public const string TRIGGER_JANITOR_REQ = "2.16.840.1.113719.1.27.100.47";
    public const string TRIGGER_JANITOR_RES = "2.16.840.1.113719.1.27.100.48";
    public const string TRIGGER_LIMBER_REQ = "2.16.840.1.113719.1.27.100.49";
    public const string TRIGGER_LIMBER_RES = "2.16.840.1.113719.1.27.100.50";
    public const string TRIGGER_PART_PURGE_REQ = "2.16.840.1.113719.1.27.100.55";
    public const string TRIGGER_PART_PURGE_RES = "2.16.840.1.113719.1.27.100.56";
    public const string TRIGGER_SCHEMA_SYNC_REQ = "2.16.840.1.113719.1.27.100.53";
    public const string TRIGGER_SCHEMA_SYNC_RES = "2.16.840.1.113719.1.27.100.54";
    public const string TRIGGER_SKULKER_REQ = "2.16.840.1.113719.1.27.100.51";
    public const string TRIGGER_SKULKER_RES = "2.16.840.1.113719.1.27.100.52";
    public ReplicationConstants() { }
  }
  public partial class SchemaSyncRequest : Novell.Directory.Ldap.LdapExtendedOperation {
    public SchemaSyncRequest(string serverName, int delay) : base (default(string), default(System.SByte[])) { }
  }
  public partial class SendAllUpdatesRequest : Novell.Directory.Ldap.LdapExtendedOperation {
    public SendAllUpdatesRequest(string partitionRoot, string origServerDN) : base (default(string), default(System.SByte[])) { }
  }
  public partial class SetReplicationFilterRequest : Novell.Directory.Ldap.LdapExtendedOperation {
    public SetReplicationFilterRequest(string serverDN, System.String[][] replicationFilter) : base (default(string), default(System.SByte[])) { }
  }
  public partial class SplitOrphanPartitionRequest : Novell.Directory.Ldap.LdapExtendedOperation {
    public SplitOrphanPartitionRequest(string serverDN, string contextName) : base (default(string), default(System.SByte[])) { }
  }
  public partial class SplitPartitionRequest : Novell.Directory.Ldap.LdapExtendedOperation {
    public SplitPartitionRequest(string dn, int flags) : base (default(string), default(System.SByte[])) { }
  }
  public partial class TriggerBackgroundProcessRequest : Novell.Directory.Ldap.LdapExtendedOperation {
    public const int Ldap_BK_PROCESS_BKLINKER = 1;
    public const int Ldap_BK_PROCESS_JANITOR = 2;
    public const int Ldap_BK_PROCESS_LIMBER = 3;
    public const int Ldap_BK_PROCESS_PART_PURGE = 6;
    public const int Ldap_BK_PROCESS_SCHEMA_SYNC = 5;
    public const int Ldap_BK_PROCESS_SKULKER = 4;
    public TriggerBackgroundProcessRequest(int processID) : base (default(string), default(System.SByte[])) { }
  }
}
namespace Novell.Directory.Ldap.Rfc2251 {
  public partial class RfcAddRequest : Novell.Directory.Ldap.Asn1.Asn1Sequence, Novell.Directory.Ldap.Rfc2251.RfcRequest {
    public RfcAddRequest(Novell.Directory.Ldap.Rfc2251.RfcLdapDN entry, Novell.Directory.Ldap.Rfc2251.RfcAttributeList attributes) { }
    public virtual Novell.Directory.Ldap.Rfc2251.RfcAttributeList Attributes { get { return default(Novell.Directory.Ldap.Rfc2251.RfcAttributeList); } }
    public Novell.Directory.Ldap.Rfc2251.RfcRequest dupRequest(string base_Renamed, string filter, bool request) { return default(Novell.Directory.Ldap.Rfc2251.RfcRequest); }
    public override Novell.Directory.Ldap.Asn1.Asn1Identifier getIdentifier() { return default(Novell.Directory.Ldap.Asn1.Asn1Identifier); }
    public string getRequestDN() { return default(string); }
  }
  public partial class RfcAddResponse : Novell.Directory.Ldap.Rfc2251.RfcLdapResult {
    [System.CLSCompliantAttribute(false)]
    public RfcAddResponse(Novell.Directory.Ldap.Asn1.Asn1Decoder dec, System.IO.Stream in_Renamed, int len) : base (default(Novell.Directory.Ldap.Asn1.Asn1Enumerated), default(Novell.Directory.Ldap.Rfc2251.RfcLdapDN), default(Novell.Directory.Ldap.Rfc2251.RfcLdapString)) { }
    public RfcAddResponse(Novell.Directory.Ldap.Asn1.Asn1Enumerated resultCode, Novell.Directory.Ldap.Rfc2251.RfcLdapDN matchedDN, Novell.Directory.Ldap.Rfc2251.RfcLdapString errorMessage, Novell.Directory.Ldap.Rfc2251.RfcReferral referral) : base (default(Novell.Directory.Ldap.Asn1.Asn1Enumerated), default(Novell.Directory.Ldap.Rfc2251.RfcLdapDN), default(Novell.Directory.Ldap.Rfc2251.RfcLdapString)) { }
    public override Novell.Directory.Ldap.Asn1.Asn1Identifier getIdentifier() { return default(Novell.Directory.Ldap.Asn1.Asn1Identifier); }
  }
  public partial class RfcAssertionValue : Novell.Directory.Ldap.Asn1.Asn1OctetString {
    [System.CLSCompliantAttribute(false)]
    public RfcAssertionValue(System.SByte[] value_Renamed) : base (default(System.SByte[])) { }
  }
  public partial class RfcAttributeDescription : Novell.Directory.Ldap.Rfc2251.RfcLdapString {
    [System.CLSCompliantAttribute(false)]
    public RfcAttributeDescription(Novell.Directory.Ldap.Asn1.Asn1Decoder dec, System.IO.Stream in_Renamed, int len) : base (default(string)) { }
    public RfcAttributeDescription(string s) : base (default(string)) { }
  }
  public partial class RfcAttributeDescriptionList : Novell.Directory.Ldap.Asn1.Asn1SequenceOf {
    public RfcAttributeDescriptionList(int size) { }
    public RfcAttributeDescriptionList(System.String[] attrs) { }
  }
  public partial class RfcAttributeList : Novell.Directory.Ldap.Asn1.Asn1SequenceOf {
    public RfcAttributeList(int size) { }
  }
  public partial class RfcAttributeTypeAndValues : Novell.Directory.Ldap.Asn1.Asn1Sequence {
    public RfcAttributeTypeAndValues(Novell.Directory.Ldap.Rfc2251.RfcAttributeDescription type, Novell.Directory.Ldap.Asn1.Asn1SetOf vals) { }
  }
  public partial class RfcAttributeValue : Novell.Directory.Ldap.Asn1.Asn1OctetString {
    [System.CLSCompliantAttribute(false)]
    public RfcAttributeValue(System.SByte[] value_Renamed) : base (default(System.SByte[])) { }
    public RfcAttributeValue(string value_Renamed) : base (default(System.SByte[])) { }
  }
  public partial class RfcAttributeValueAssertion : Novell.Directory.Ldap.Asn1.Asn1Sequence {
    public RfcAttributeValueAssertion(Novell.Directory.Ldap.Rfc2251.RfcAttributeDescription ad, Novell.Directory.Ldap.Rfc2251.RfcAssertionValue av) { }
    [System.CLSCompliantAttribute(false)]
    public virtual System.SByte[] AssertionValue { get { return default(System.SByte[]); } }
    public virtual string AttributeDescription { get { return default(string); } }
  }
  public partial class RfcAuthenticationChoice : Novell.Directory.Ldap.Asn1.Asn1Choice {
    public RfcAuthenticationChoice(Novell.Directory.Ldap.Asn1.Asn1Tagged choice) { }
    [System.CLSCompliantAttribute(false)]
    public RfcAuthenticationChoice(string mechanism, System.SByte[] credentials) { }
  }
  public partial class RfcBindRequest : Novell.Directory.Ldap.Asn1.Asn1Sequence, Novell.Directory.Ldap.Rfc2251.RfcRequest {
    public RfcBindRequest(Novell.Directory.Ldap.Asn1.Asn1Integer version, Novell.Directory.Ldap.Rfc2251.RfcLdapDN name, Novell.Directory.Ldap.Rfc2251.RfcAuthenticationChoice auth) { }
    [System.CLSCompliantAttribute(false)]
    public RfcBindRequest(int version, string dn, string mechanism, System.SByte[] credentials) { }
    public virtual Novell.Directory.Ldap.Rfc2251.RfcAuthenticationChoice AuthenticationChoice { get { return default(Novell.Directory.Ldap.Rfc2251.RfcAuthenticationChoice); } set { } }
    public virtual Novell.Directory.Ldap.Rfc2251.RfcLdapDN Name { get { return default(Novell.Directory.Ldap.Rfc2251.RfcLdapDN); } set { } }
    public virtual Novell.Directory.Ldap.Asn1.Asn1Integer Version { get { return default(Novell.Directory.Ldap.Asn1.Asn1Integer); } set { } }
    public Novell.Directory.Ldap.Rfc2251.RfcRequest dupRequest(string base_Renamed, string filter, bool request) { return default(Novell.Directory.Ldap.Rfc2251.RfcRequest); }
    public override Novell.Directory.Ldap.Asn1.Asn1Identifier getIdentifier() { return default(Novell.Directory.Ldap.Asn1.Asn1Identifier); }
    public string getRequestDN() { return default(string); }
  }
  public partial class RfcBindResponse : Novell.Directory.Ldap.Asn1.Asn1Sequence, Novell.Directory.Ldap.Rfc2251.RfcResponse {
    [System.CLSCompliantAttribute(false)]
    public RfcBindResponse(Novell.Directory.Ldap.Asn1.Asn1Decoder dec, System.IO.Stream in_Renamed, int len) { }
    public virtual Novell.Directory.Ldap.Asn1.Asn1OctetString ServerSaslCreds { get { return default(Novell.Directory.Ldap.Asn1.Asn1OctetString); } }
    public Novell.Directory.Ldap.Rfc2251.RfcLdapString getErrorMessage() { return default(Novell.Directory.Ldap.Rfc2251.RfcLdapString); }
    public override Novell.Directory.Ldap.Asn1.Asn1Identifier getIdentifier() { return default(Novell.Directory.Ldap.Asn1.Asn1Identifier); }
    public Novell.Directory.Ldap.Rfc2251.RfcLdapDN getMatchedDN() { return default(Novell.Directory.Ldap.Rfc2251.RfcLdapDN); }
    public Novell.Directory.Ldap.Rfc2251.RfcReferral getReferral() { return default(Novell.Directory.Ldap.Rfc2251.RfcReferral); }
    public Novell.Directory.Ldap.Asn1.Asn1Enumerated getResultCode() { return default(Novell.Directory.Ldap.Asn1.Asn1Enumerated); }
  }
  public partial class RfcCompareRequest : Novell.Directory.Ldap.Asn1.Asn1Sequence, Novell.Directory.Ldap.Rfc2251.RfcRequest {
    public RfcCompareRequest(Novell.Directory.Ldap.Rfc2251.RfcLdapDN entry, Novell.Directory.Ldap.Rfc2251.RfcAttributeValueAssertion ava) { }
    public virtual Novell.Directory.Ldap.Rfc2251.RfcAttributeValueAssertion AttributeValueAssertion { get { return default(Novell.Directory.Ldap.Rfc2251.RfcAttributeValueAssertion); } }
    public Novell.Directory.Ldap.Rfc2251.RfcRequest dupRequest(string base_Renamed, string filter, bool request) { return default(Novell.Directory.Ldap.Rfc2251.RfcRequest); }
    public override Novell.Directory.Ldap.Asn1.Asn1Identifier getIdentifier() { return default(Novell.Directory.Ldap.Asn1.Asn1Identifier); }
    public string getRequestDN() { return default(string); }
  }
  public partial class RfcCompareResponse : Novell.Directory.Ldap.Rfc2251.RfcLdapResult {
    [System.CLSCompliantAttribute(false)]
    public RfcCompareResponse(Novell.Directory.Ldap.Asn1.Asn1Decoder dec, System.IO.Stream in_Renamed, int len) : base (default(Novell.Directory.Ldap.Asn1.Asn1Enumerated), default(Novell.Directory.Ldap.Rfc2251.RfcLdapDN), default(Novell.Directory.Ldap.Rfc2251.RfcLdapString)) { }
    public RfcCompareResponse(Novell.Directory.Ldap.Asn1.Asn1Enumerated resultCode, Novell.Directory.Ldap.Rfc2251.RfcLdapDN matchedDN, Novell.Directory.Ldap.Rfc2251.RfcLdapString errorMessage, Novell.Directory.Ldap.Rfc2251.RfcReferral referral) : base (default(Novell.Directory.Ldap.Asn1.Asn1Enumerated), default(Novell.Directory.Ldap.Rfc2251.RfcLdapDN), default(Novell.Directory.Ldap.Rfc2251.RfcLdapString)) { }
    public override Novell.Directory.Ldap.Asn1.Asn1Identifier getIdentifier() { return default(Novell.Directory.Ldap.Asn1.Asn1Identifier); }
  }
  public partial class RfcControl : Novell.Directory.Ldap.Asn1.Asn1Sequence {
    [System.CLSCompliantAttribute(false)]
    public RfcControl(Novell.Directory.Ldap.Asn1.Asn1Decoder dec, System.IO.Stream in_Renamed, int len) { }
    public RfcControl(Novell.Directory.Ldap.Asn1.Asn1Sequence seqObj) { }
    public RfcControl(Novell.Directory.Ldap.Rfc2251.RfcLdapOID controlType) { }
    public RfcControl(Novell.Directory.Ldap.Rfc2251.RfcLdapOID controlType, Novell.Directory.Ldap.Asn1.Asn1Boolean criticality) { }
    public RfcControl(Novell.Directory.Ldap.Rfc2251.RfcLdapOID controlType, Novell.Directory.Ldap.Asn1.Asn1Boolean criticality, Novell.Directory.Ldap.Asn1.Asn1OctetString controlValue) { }
    public virtual Novell.Directory.Ldap.Asn1.Asn1OctetString ControlType { get { return default(Novell.Directory.Ldap.Asn1.Asn1OctetString); } }
    public virtual Novell.Directory.Ldap.Asn1.Asn1OctetString ControlValue { get { return default(Novell.Directory.Ldap.Asn1.Asn1OctetString); } set { } }
    public virtual Novell.Directory.Ldap.Asn1.Asn1Boolean Criticality { get { return default(Novell.Directory.Ldap.Asn1.Asn1Boolean); } }
  }
  public partial class RfcControls : Novell.Directory.Ldap.Asn1.Asn1SequenceOf {
    public const int CONTROLS = 0;
    public RfcControls() { }
    [System.CLSCompliantAttribute(false)]
    public RfcControls(Novell.Directory.Ldap.Asn1.Asn1Decoder dec, System.IO.Stream in_Renamed, int len) { }
    public void add(Novell.Directory.Ldap.Rfc2251.RfcControl control) { }
    public override Novell.Directory.Ldap.Asn1.Asn1Identifier getIdentifier() { return default(Novell.Directory.Ldap.Asn1.Asn1Identifier); }
    public void set_Renamed(int index, Novell.Directory.Ldap.Rfc2251.RfcControl control) { }
  }
  public partial class RfcDelRequest : Novell.Directory.Ldap.Rfc2251.RfcLdapDN, Novell.Directory.Ldap.Rfc2251.RfcRequest {
    [System.CLSCompliantAttribute(false)]
    public RfcDelRequest(System.SByte[] dn) : base (default(string)) { }
    public RfcDelRequest(string dn) : base (default(string)) { }
    public Novell.Directory.Ldap.Rfc2251.RfcRequest dupRequest(string base_Renamed, string filter, bool request) { return default(Novell.Directory.Ldap.Rfc2251.RfcRequest); }
    public override Novell.Directory.Ldap.Asn1.Asn1Identifier getIdentifier() { return default(Novell.Directory.Ldap.Asn1.Asn1Identifier); }
    public string getRequestDN() { return default(string); }
  }
  public partial class RfcDelResponse : Novell.Directory.Ldap.Rfc2251.RfcLdapResult {
    [System.CLSCompliantAttribute(false)]
    public RfcDelResponse(Novell.Directory.Ldap.Asn1.Asn1Decoder dec, System.IO.Stream in_Renamed, int len) : base (default(Novell.Directory.Ldap.Asn1.Asn1Enumerated), default(Novell.Directory.Ldap.Rfc2251.RfcLdapDN), default(Novell.Directory.Ldap.Rfc2251.RfcLdapString)) { }
    public RfcDelResponse(Novell.Directory.Ldap.Asn1.Asn1Enumerated resultCode, Novell.Directory.Ldap.Rfc2251.RfcLdapDN matchedDN, Novell.Directory.Ldap.Rfc2251.RfcLdapString errorMessage, Novell.Directory.Ldap.Rfc2251.RfcReferral referral) : base (default(Novell.Directory.Ldap.Asn1.Asn1Enumerated), default(Novell.Directory.Ldap.Rfc2251.RfcLdapDN), default(Novell.Directory.Ldap.Rfc2251.RfcLdapString)) { }
    public override Novell.Directory.Ldap.Asn1.Asn1Identifier getIdentifier() { return default(Novell.Directory.Ldap.Asn1.Asn1Identifier); }
  }
  public partial class RfcExtendedRequest : Novell.Directory.Ldap.Asn1.Asn1Sequence, Novell.Directory.Ldap.Rfc2251.RfcRequest {
    public const int REQUEST_NAME = 0;
    public const int REQUEST_VALUE = 1;
    public RfcExtendedRequest(Novell.Directory.Ldap.Asn1.Asn1Object[] origRequest) { }
    public RfcExtendedRequest(Novell.Directory.Ldap.Rfc2251.RfcLdapOID requestName) { }
    public RfcExtendedRequest(Novell.Directory.Ldap.Rfc2251.RfcLdapOID requestName, Novell.Directory.Ldap.Asn1.Asn1OctetString requestValue) { }
    public Novell.Directory.Ldap.Rfc2251.RfcRequest dupRequest(string base_Renamed, string filter, bool request) { return default(Novell.Directory.Ldap.Rfc2251.RfcRequest); }
    public override Novell.Directory.Ldap.Asn1.Asn1Identifier getIdentifier() { return default(Novell.Directory.Ldap.Asn1.Asn1Identifier); }
    public string getRequestDN() { return default(string); }
  }
  public partial class RfcExtendedResponse : Novell.Directory.Ldap.Asn1.Asn1Sequence, Novell.Directory.Ldap.Rfc2251.RfcResponse {
    public const int RESPONSE = 11;
    public const int RESPONSE_NAME = 10;
    [System.CLSCompliantAttribute(false)]
    public RfcExtendedResponse(Novell.Directory.Ldap.Asn1.Asn1Decoder dec, System.IO.Stream in_Renamed, int len) { }
    [System.CLSCompliantAttribute(false)]
    public virtual Novell.Directory.Ldap.Asn1.Asn1OctetString Response { get { return default(Novell.Directory.Ldap.Asn1.Asn1OctetString); } }
    public virtual Novell.Directory.Ldap.Rfc2251.RfcLdapOID ResponseName { get { return default(Novell.Directory.Ldap.Rfc2251.RfcLdapOID); } }
    public Novell.Directory.Ldap.Rfc2251.RfcLdapString getErrorMessage() { return default(Novell.Directory.Ldap.Rfc2251.RfcLdapString); }
    public override Novell.Directory.Ldap.Asn1.Asn1Identifier getIdentifier() { return default(Novell.Directory.Ldap.Asn1.Asn1Identifier); }
    public Novell.Directory.Ldap.Rfc2251.RfcLdapDN getMatchedDN() { return default(Novell.Directory.Ldap.Rfc2251.RfcLdapDN); }
    public Novell.Directory.Ldap.Rfc2251.RfcReferral getReferral() { return default(Novell.Directory.Ldap.Rfc2251.RfcReferral); }
    public Novell.Directory.Ldap.Asn1.Asn1Enumerated getResultCode() { return default(Novell.Directory.Ldap.Asn1.Asn1Enumerated); }
  }
  public partial class RfcFilter : Novell.Directory.Ldap.Asn1.Asn1Choice {
    public const int AND = 0;
    public const int ANY = 1;
    public const int APPROX_MATCH = 8;
    public const int EQUALITY_MATCH = 3;
    public const int EXTENSIBLE_MATCH = 9;
    public const int FINAL = 2;
    public const int GREATER_OR_EQUAL = 5;
    public const int INITIAL = 0;
    public const int LESS_OR_EQUAL = 6;
    public const int NOT = 2;
    public const int OR = 1;
    public const int PRESENT = 7;
    public const int SUBSTRINGS = 4;
    public RfcFilter() { }
    public RfcFilter(string filter) { }
    [System.CLSCompliantAttribute(false)]
    public virtual void addAttributeValueAssertion(int rfcType, string attrName, System.SByte[] value_Renamed) { }
    [System.CLSCompliantAttribute(false)]
    public virtual void addExtensibleMatch(string matchingRule, string attrName, System.SByte[] value_Renamed, bool useDNMatching) { }
    public virtual void addPresent(string attrName) { }
    [System.CLSCompliantAttribute(false)]
    public virtual void addSubstring(int type, System.SByte[] value_Renamed) { }
    public virtual void endNestedFilter(int rfcType) { }
    public virtual void endSubstrings() { }
    public virtual string filterToString() { return default(string); }
    public virtual System.Collections.IEnumerator getFilterIterator() { return default(System.Collections.IEnumerator); }
    public virtual void startNestedFilter(int rfcType) { }
    public virtual void startSubstrings(string attrName) { }
  }
  public partial class RfcIntermediateResponse : Novell.Directory.Ldap.Asn1.Asn1Sequence, Novell.Directory.Ldap.Rfc2251.RfcResponse {
    public const int TAG_RESPONSE = 1;
    public const int TAG_RESPONSE_NAME = 0;
    [System.CLSCompliantAttribute(false)]
    public RfcIntermediateResponse(Novell.Directory.Ldap.Asn1.Asn1Decoder dec, System.IO.Stream in_Renamed, int len) { }
    public Novell.Directory.Ldap.Rfc2251.RfcLdapString getErrorMessage() { return default(Novell.Directory.Ldap.Rfc2251.RfcLdapString); }
    public override Novell.Directory.Ldap.Asn1.Asn1Identifier getIdentifier() { return default(Novell.Directory.Ldap.Asn1.Asn1Identifier); }
    public Novell.Directory.Ldap.Rfc2251.RfcLdapDN getMatchedDN() { return default(Novell.Directory.Ldap.Rfc2251.RfcLdapDN); }
    public Novell.Directory.Ldap.Rfc2251.RfcReferral getReferral() { return default(Novell.Directory.Ldap.Rfc2251.RfcReferral); }
    public Novell.Directory.Ldap.Asn1.Asn1OctetString getResponse() { return default(Novell.Directory.Ldap.Asn1.Asn1OctetString); }
    public Novell.Directory.Ldap.Rfc2251.RfcLdapOID getResponseName() { return default(Novell.Directory.Ldap.Rfc2251.RfcLdapOID); }
    public Novell.Directory.Ldap.Asn1.Asn1Enumerated getResultCode() { return default(Novell.Directory.Ldap.Asn1.Asn1Enumerated); }
  }
  public partial class RfcLdapDN : Novell.Directory.Ldap.Rfc2251.RfcLdapString {
    [System.CLSCompliantAttribute(false)]
    public RfcLdapDN(System.SByte[] s) : base (default(string)) { }
    public RfcLdapDN(string s) : base (default(string)) { }
  }
  public partial class RfcLdapMessage : Novell.Directory.Ldap.Asn1.Asn1Sequence {
    [System.CLSCompliantAttribute(false)]
    public RfcLdapMessage(Novell.Directory.Ldap.Asn1.Asn1Decoder dec, System.IO.Stream in_Renamed, int len) { }
    public RfcLdapMessage(Novell.Directory.Ldap.Asn1.Asn1Sequence op) { }
    public RfcLdapMessage(Novell.Directory.Ldap.Asn1.Asn1Sequence op, Novell.Directory.Ldap.Rfc2251.RfcControls controls) { }
    public RfcLdapMessage(Novell.Directory.Ldap.Rfc2251.RfcRequest op) { }
    public RfcLdapMessage(Novell.Directory.Ldap.Rfc2251.RfcRequest op, Novell.Directory.Ldap.Rfc2251.RfcControls controls) { }
    public virtual Novell.Directory.Ldap.Rfc2251.RfcControls Controls { get { return default(Novell.Directory.Ldap.Rfc2251.RfcControls); } }
    public virtual int MessageID { get { return default(int); } }
    public virtual string RequestDN { get { return default(string); } }
    public virtual Novell.Directory.Ldap.LdapMessage RequestingMessage { get { return default(Novell.Directory.Ldap.LdapMessage); } set { } }
    public virtual Novell.Directory.Ldap.Asn1.Asn1Object Response { get { return default(Novell.Directory.Ldap.Asn1.Asn1Object); } }
    public virtual int Type { get { return default(int); } }
    public object dupMessage(string dn, string filter, bool reference) { return default(object); }
    public Novell.Directory.Ldap.Rfc2251.RfcRequest getRequest() { return default(Novell.Directory.Ldap.Rfc2251.RfcRequest); }
    public virtual bool isRequest() { return default(bool); }
  }
  public partial class RfcLdapOID : Novell.Directory.Ldap.Asn1.Asn1OctetString {
    [System.CLSCompliantAttribute(false)]
    public RfcLdapOID(System.SByte[] s) : base (default(System.SByte[])) { }
    public RfcLdapOID(string s) : base (default(System.SByte[])) { }
  }
  public partial class RfcLdapResult : Novell.Directory.Ldap.Asn1.Asn1Sequence, Novell.Directory.Ldap.Rfc2251.RfcResponse {
    public const int REFERRAL = 3;
    [System.CLSCompliantAttribute(false)]
    public RfcLdapResult(Novell.Directory.Ldap.Asn1.Asn1Decoder dec, System.IO.Stream in_Renamed, int len) { }
    public RfcLdapResult(Novell.Directory.Ldap.Asn1.Asn1Enumerated resultCode, Novell.Directory.Ldap.Rfc2251.RfcLdapDN matchedDN, Novell.Directory.Ldap.Rfc2251.RfcLdapString errorMessage) { }
    public RfcLdapResult(Novell.Directory.Ldap.Asn1.Asn1Enumerated resultCode, Novell.Directory.Ldap.Rfc2251.RfcLdapDN matchedDN, Novell.Directory.Ldap.Rfc2251.RfcLdapString errorMessage, Novell.Directory.Ldap.Rfc2251.RfcReferral referral) { }
    public Novell.Directory.Ldap.Rfc2251.RfcLdapString getErrorMessage() { return default(Novell.Directory.Ldap.Rfc2251.RfcLdapString); }
    public Novell.Directory.Ldap.Rfc2251.RfcLdapDN getMatchedDN() { return default(Novell.Directory.Ldap.Rfc2251.RfcLdapDN); }
    public Novell.Directory.Ldap.Rfc2251.RfcReferral getReferral() { return default(Novell.Directory.Ldap.Rfc2251.RfcReferral); }
    public Novell.Directory.Ldap.Asn1.Asn1Enumerated getResultCode() { return default(Novell.Directory.Ldap.Asn1.Asn1Enumerated); }
  }
  public partial class RfcLdapString : Novell.Directory.Ldap.Asn1.Asn1OctetString {
    [System.CLSCompliantAttribute(false)]
    public RfcLdapString(Novell.Directory.Ldap.Asn1.Asn1Decoder dec, System.IO.Stream in_Renamed, int len) : base (default(System.SByte[])) { }
    [System.CLSCompliantAttribute(false)]
    public RfcLdapString(System.SByte[] ba) : base (default(System.SByte[])) { }
    public RfcLdapString(string s) : base (default(System.SByte[])) { }
  }
  public partial class RfcLdapSuperDN : Novell.Directory.Ldap.Asn1.Asn1Tagged {
    protected static readonly Novell.Directory.Ldap.Asn1.Asn1Identifier ID;
    public static readonly int TAG;
    [System.CLSCompliantAttribute(false)]
    public RfcLdapSuperDN(System.SByte[] ba) : base (default(Novell.Directory.Ldap.Asn1.Asn1Identifier), default(Novell.Directory.Ldap.Asn1.Asn1Object)) { }
    public RfcLdapSuperDN(string s) : base (default(Novell.Directory.Ldap.Asn1.Asn1Identifier), default(Novell.Directory.Ldap.Asn1.Asn1Object)) { }
    [System.CLSCompliantAttribute(false)]
    public System.SByte[] byteValue() { return default(System.SByte[]); }
    public override void encode(Novell.Directory.Ldap.Asn1.Asn1Encoder enc, System.IO.Stream out_Renamed) { }
    public string stringValue() { return default(string); }
    public override string ToString() { return default(string); }
  }
  public partial class RfcMatchingRuleAssertion : Novell.Directory.Ldap.Asn1.Asn1Sequence {
    public RfcMatchingRuleAssertion(Novell.Directory.Ldap.Rfc2251.RfcAssertionValue matchValue) { }
    public RfcMatchingRuleAssertion(Novell.Directory.Ldap.Rfc2251.RfcMatchingRuleId matchingRule, Novell.Directory.Ldap.Rfc2251.RfcAttributeDescription type, Novell.Directory.Ldap.Rfc2251.RfcAssertionValue matchValue, Novell.Directory.Ldap.Asn1.Asn1Boolean dnAttributes) { }
  }
  public partial class RfcMatchingRuleId : Novell.Directory.Ldap.Rfc2251.RfcLdapString {
    public RfcMatchingRuleId(string s) : base (default(string)) { }
  }
  public partial class RfcModifyDNRequest : Novell.Directory.Ldap.Asn1.Asn1Sequence, Novell.Directory.Ldap.Rfc2251.RfcRequest {
    public RfcModifyDNRequest(Novell.Directory.Ldap.Rfc2251.RfcLdapDN entry, Novell.Directory.Ldap.Rfc2251.RfcRelativeLdapDN newrdn, Novell.Directory.Ldap.Asn1.Asn1Boolean deleteoldrdn) { }
    public RfcModifyDNRequest(Novell.Directory.Ldap.Rfc2251.RfcLdapDN entry, Novell.Directory.Ldap.Rfc2251.RfcRelativeLdapDN newrdn, Novell.Directory.Ldap.Asn1.Asn1Boolean deleteoldrdn, Novell.Directory.Ldap.Rfc2251.RfcLdapSuperDN newSuperior) { }
    public Novell.Directory.Ldap.Rfc2251.RfcRequest dupRequest(string base_Renamed, string filter, bool request) { return default(Novell.Directory.Ldap.Rfc2251.RfcRequest); }
    public override Novell.Directory.Ldap.Asn1.Asn1Identifier getIdentifier() { return default(Novell.Directory.Ldap.Asn1.Asn1Identifier); }
    public string getRequestDN() { return default(string); }
  }
  public partial class RfcModifyDNResponse : Novell.Directory.Ldap.Rfc2251.RfcLdapResult {
    [System.CLSCompliantAttribute(false)]
    public RfcModifyDNResponse(Novell.Directory.Ldap.Asn1.Asn1Decoder dec, System.IO.Stream in_Renamed, int len) : base (default(Novell.Directory.Ldap.Asn1.Asn1Enumerated), default(Novell.Directory.Ldap.Rfc2251.RfcLdapDN), default(Novell.Directory.Ldap.Rfc2251.RfcLdapString)) { }
    public RfcModifyDNResponse(Novell.Directory.Ldap.Asn1.Asn1Enumerated resultCode, Novell.Directory.Ldap.Rfc2251.RfcLdapDN matchedDN, Novell.Directory.Ldap.Rfc2251.RfcLdapString errorMessage, Novell.Directory.Ldap.Rfc2251.RfcReferral referral) : base (default(Novell.Directory.Ldap.Asn1.Asn1Enumerated), default(Novell.Directory.Ldap.Rfc2251.RfcLdapDN), default(Novell.Directory.Ldap.Rfc2251.RfcLdapString)) { }
    public override Novell.Directory.Ldap.Asn1.Asn1Identifier getIdentifier() { return default(Novell.Directory.Ldap.Asn1.Asn1Identifier); }
  }
  public partial class RfcModifyRequest : Novell.Directory.Ldap.Asn1.Asn1Sequence, Novell.Directory.Ldap.Rfc2251.RfcRequest {
    public RfcModifyRequest(Novell.Directory.Ldap.Rfc2251.RfcLdapDN object_Renamed, Novell.Directory.Ldap.Asn1.Asn1SequenceOf modification) { }
    public virtual Novell.Directory.Ldap.Asn1.Asn1SequenceOf Modifications { get { return default(Novell.Directory.Ldap.Asn1.Asn1SequenceOf); } }
    public Novell.Directory.Ldap.Rfc2251.RfcRequest dupRequest(string base_Renamed, string filter, bool request) { return default(Novell.Directory.Ldap.Rfc2251.RfcRequest); }
    public override Novell.Directory.Ldap.Asn1.Asn1Identifier getIdentifier() { return default(Novell.Directory.Ldap.Asn1.Asn1Identifier); }
    public string getRequestDN() { return default(string); }
  }
  public partial class RfcModifyResponse : Novell.Directory.Ldap.Rfc2251.RfcLdapResult {
    [System.CLSCompliantAttribute(false)]
    public RfcModifyResponse(Novell.Directory.Ldap.Asn1.Asn1Decoder dec, System.IO.Stream in_Renamed, int len) : base (default(Novell.Directory.Ldap.Asn1.Asn1Enumerated), default(Novell.Directory.Ldap.Rfc2251.RfcLdapDN), default(Novell.Directory.Ldap.Rfc2251.RfcLdapString)) { }
    public RfcModifyResponse(Novell.Directory.Ldap.Asn1.Asn1Enumerated resultCode, Novell.Directory.Ldap.Rfc2251.RfcLdapDN matchedDN, Novell.Directory.Ldap.Rfc2251.RfcLdapString errorMessage, Novell.Directory.Ldap.Rfc2251.RfcReferral referral) : base (default(Novell.Directory.Ldap.Asn1.Asn1Enumerated), default(Novell.Directory.Ldap.Rfc2251.RfcLdapDN), default(Novell.Directory.Ldap.Rfc2251.RfcLdapString)) { }
    public override Novell.Directory.Ldap.Asn1.Asn1Identifier getIdentifier() { return default(Novell.Directory.Ldap.Asn1.Asn1Identifier); }
  }
  public partial class RfcReferral : Novell.Directory.Ldap.Asn1.Asn1SequenceOf {
    [System.CLSCompliantAttribute(false)]
    public RfcReferral(Novell.Directory.Ldap.Asn1.Asn1Decoder dec, System.IO.Stream in_Renamed, int len) { }
  }
  public partial class RfcRelativeLdapDN : Novell.Directory.Ldap.Rfc2251.RfcLdapString {
    public RfcRelativeLdapDN(string s) : base (default(string)) { }
  }
  public partial interface RfcRequest {
    Novell.Directory.Ldap.Rfc2251.RfcRequest dupRequest(string base_Renamed, string filter, bool reference);
    string getRequestDN();
  }
  public partial interface RfcResponse {
    Novell.Directory.Ldap.Rfc2251.RfcLdapString getErrorMessage();
    Novell.Directory.Ldap.Rfc2251.RfcLdapDN getMatchedDN();
    Novell.Directory.Ldap.Rfc2251.RfcReferral getReferral();
    Novell.Directory.Ldap.Asn1.Asn1Enumerated getResultCode();
  }
  public partial class RfcSaslCredentials : Novell.Directory.Ldap.Asn1.Asn1Sequence {
    public RfcSaslCredentials(Novell.Directory.Ldap.Rfc2251.RfcLdapString mechanism) { }
    public RfcSaslCredentials(Novell.Directory.Ldap.Rfc2251.RfcLdapString mechanism, Novell.Directory.Ldap.Asn1.Asn1OctetString credentials) { }
  }
  public partial class RfcSearchRequest : Novell.Directory.Ldap.Asn1.Asn1Sequence, Novell.Directory.Ldap.Rfc2251.RfcRequest {
    public RfcSearchRequest(Novell.Directory.Ldap.Rfc2251.RfcLdapDN baseObject, Novell.Directory.Ldap.Asn1.Asn1Enumerated scope, Novell.Directory.Ldap.Asn1.Asn1Enumerated derefAliases, Novell.Directory.Ldap.Asn1.Asn1Integer sizeLimit, Novell.Directory.Ldap.Asn1.Asn1Integer timeLimit, Novell.Directory.Ldap.Asn1.Asn1Boolean typesOnly, Novell.Directory.Ldap.Rfc2251.RfcFilter filter, Novell.Directory.Ldap.Rfc2251.RfcAttributeDescriptionList attributes) { }
    public Novell.Directory.Ldap.Rfc2251.RfcRequest dupRequest(string base_Renamed, string filter, bool request) { return default(Novell.Directory.Ldap.Rfc2251.RfcRequest); }
    public override Novell.Directory.Ldap.Asn1.Asn1Identifier getIdentifier() { return default(Novell.Directory.Ldap.Asn1.Asn1Identifier); }
    public string getRequestDN() { return default(string); }
  }
  public partial class RfcSearchResultDone : Novell.Directory.Ldap.Rfc2251.RfcLdapResult {
    [System.CLSCompliantAttribute(false)]
    public RfcSearchResultDone(Novell.Directory.Ldap.Asn1.Asn1Decoder dec, System.IO.Stream in_Renamed, int len) : base (default(Novell.Directory.Ldap.Asn1.Asn1Enumerated), default(Novell.Directory.Ldap.Rfc2251.RfcLdapDN), default(Novell.Directory.Ldap.Rfc2251.RfcLdapString)) { }
    public RfcSearchResultDone(Novell.Directory.Ldap.Asn1.Asn1Enumerated resultCode, Novell.Directory.Ldap.Rfc2251.RfcLdapDN matchedDN, Novell.Directory.Ldap.Rfc2251.RfcLdapString errorMessage, Novell.Directory.Ldap.Rfc2251.RfcReferral referral) : base (default(Novell.Directory.Ldap.Asn1.Asn1Enumerated), default(Novell.Directory.Ldap.Rfc2251.RfcLdapDN), default(Novell.Directory.Ldap.Rfc2251.RfcLdapString)) { }
    public override Novell.Directory.Ldap.Asn1.Asn1Identifier getIdentifier() { return default(Novell.Directory.Ldap.Asn1.Asn1Identifier); }
  }
  public partial class RfcSearchResultEntry : Novell.Directory.Ldap.Asn1.Asn1Sequence {
    [System.CLSCompliantAttribute(false)]
    public RfcSearchResultEntry(Novell.Directory.Ldap.Asn1.Asn1Decoder dec, System.IO.Stream in_Renamed, int len) { }
    public virtual Novell.Directory.Ldap.Asn1.Asn1Sequence Attributes { get { return default(Novell.Directory.Ldap.Asn1.Asn1Sequence); } }
    public virtual Novell.Directory.Ldap.Asn1.Asn1OctetString ObjectName { get { return default(Novell.Directory.Ldap.Asn1.Asn1OctetString); } }
    public override Novell.Directory.Ldap.Asn1.Asn1Identifier getIdentifier() { return default(Novell.Directory.Ldap.Asn1.Asn1Identifier); }
  }
  public partial class RfcSearchResultReference : Novell.Directory.Ldap.Asn1.Asn1SequenceOf {
    [System.CLSCompliantAttribute(false)]
    public RfcSearchResultReference(Novell.Directory.Ldap.Asn1.Asn1Decoder dec, System.IO.Stream in_Renamed, int len) { }
    public override Novell.Directory.Ldap.Asn1.Asn1Identifier getIdentifier() { return default(Novell.Directory.Ldap.Asn1.Asn1Identifier); }
  }
  public partial class RfcSubstringFilter : Novell.Directory.Ldap.Asn1.Asn1Sequence {
    public RfcSubstringFilter(Novell.Directory.Ldap.Rfc2251.RfcAttributeDescription type, Novell.Directory.Ldap.Asn1.Asn1SequenceOf substrings) { }
  }
  public partial class RfcUnbindRequest : Novell.Directory.Ldap.Asn1.Asn1Null, Novell.Directory.Ldap.Rfc2251.RfcRequest {
    public RfcUnbindRequest() { }
    public Novell.Directory.Ldap.Rfc2251.RfcRequest dupRequest(string base_Renamed, string filter, bool request) { return default(Novell.Directory.Ldap.Rfc2251.RfcRequest); }
    public override Novell.Directory.Ldap.Asn1.Asn1Identifier getIdentifier() { return default(Novell.Directory.Ldap.Asn1.Asn1Identifier); }
    public string getRequestDN() { return default(string); }
  }
}
namespace Novell.Directory.Ldap.Utilclass {
  public partial class ArrayEnumeration : System.Collections.IEnumerator {
    public ArrayEnumeration(System.Object[] eArray) { }
    public virtual object Current { get { return default(object); } }
    public bool hasMoreElements() { return default(bool); }
    public virtual bool MoveNext() { return default(bool); }
    public object nextElement() { return default(object); }
    public virtual void Reset() { }
  }
  public partial class AttributeQualifier {
    public AttributeQualifier(string name, System.String[] value_Renamed) { }
    public virtual string Name { get { return default(string); } }
    public virtual System.String[] Values { get { return default(System.String[]); } }
  }
  public partial class Base64 {
    internal Base64() { }
    [System.CLSCompliantAttribute(false)]
    public static System.SByte[] decode(System.Char[] encodedChars) { return default(System.SByte[]); }
    [System.CLSCompliantAttribute(false)]
    public static System.SByte[] decode(string encodedString) { return default(System.SByte[]); }
    [System.CLSCompliantAttribute(false)]
    public static System.SByte[] decode(System.Text.StringBuilder encodedSBuf, int start, int end) { return default(System.SByte[]); }
    [System.CLSCompliantAttribute(false)]
    public static string encode(System.SByte[] inputBytes) { return default(string); }
    public static string encode(string inputString) { return default(string); }
    [System.CLSCompliantAttribute(false)]
    public static bool isLDIFSafe(System.SByte[] bytes) { return default(bool); }
    public static bool isLDIFSafe(string str) { return default(bool); }
    [System.CLSCompliantAttribute(false)]
    public static bool isValidUTF8(System.SByte[] array, bool isUCS2Only) { return default(bool); }
  }
  public partial class BindProperties {
    public BindProperties(int version, string dn, string method, bool anonymous, System.Collections.Hashtable bindProperties, object bindCallbackHandler) { }
    public virtual bool Anonymous { get { return default(bool); } }
    public virtual string AuthenticationDN { get { return default(string); } }
    public virtual string AuthenticationMethod { get { return default(string); } }
    public virtual int ProtocolVersion { get { return default(int); } }
    public virtual System.Collections.Hashtable SaslBindProperties { get { return default(System.Collections.Hashtable); } }
    public virtual object SaslCallbackHandler { get { return default(object); } }
  }
  [System.CLSCompliantAttribute(false)]
  public enum CharacterTypes : sbyte {
    ALPHABETIC = (sbyte)4,
    COMMENTCHAR = (sbyte)16,
    NUMERIC = (sbyte)2,
    STRINGQUOTE = (sbyte)8,
    WHITESPACE = (sbyte)1,
  }
  public partial class DN {
    public DN() { }
    public DN(string dnString) { }
    public virtual Novell.Directory.Ldap.Utilclass.DN Parent { get { return default(Novell.Directory.Ldap.Utilclass.DN); } }
    public virtual System.Collections.ArrayList RDNs { get { return default(System.Collections.ArrayList); } }
    public virtual void addRDN(Novell.Directory.Ldap.Utilclass.RDN rdn) { }
    public virtual void addRDNToBack(Novell.Directory.Ldap.Utilclass.RDN rdn) { }
    public virtual void addRDNToFront(Novell.Directory.Ldap.Utilclass.RDN rdn) { }
    public virtual int countRDNs() { return default(int); }
    public bool Equals(Novell.Directory.Ldap.Utilclass.DN toDN) { return default(bool); }
    public override bool Equals(object toDN) { return default(bool); }
    public virtual System.String[] explodeDN(bool noTypes) { return default(System.String[]); }
    public System.Collections.ArrayList getrdnList() { return default(System.Collections.ArrayList); }
    public virtual bool isDescendantOf(Novell.Directory.Ldap.Utilclass.DN containerDN) { return default(bool); }
    public override string ToString() { return default(string); }
  }
  public partial class EnumeratedIterator : System.Collections.IEnumerator {
    public EnumeratedIterator(System.Collections.IEnumerator iterator) { }
    public virtual object Current { get { return default(object); } }
    public bool hasMoreElements() { return default(bool); }
    public virtual bool MoveNext() { return default(bool); }
    public object nextElement() { return default(object); }
    public virtual void Reset() { }
  }
  public partial class ExceptionMessages : System.Resources.ResourceManager {
    public const string CANNOT_BIND = "CANNOT_BIND";
    public const string CONNECTION_CLOSED = "CONNECTION_CLOSED";
    public const string CONNECTION_ERROR = "CONNECTION_ERROR";
    public const string CONNECTION_FINALIZED = "CONNECTION_FINALIZED";
    public const string CONNECTION_IMPOSSIBLE = "CONNECTION_IMPOSSIBLE";
    public const string CONNECTION_READER = "CONNECTION_READER";
    public const string CONNECTION_WAIT = "CONNECTION_WAIT";
    public const string DECODING_ERROR = "DECODING_ERROR";
    public const string DN_PARAM_ERROR = "DN_PARAM_ERROR";
    public const string DUP_ERROR = "DUP_ERROR";
    public const string ENCODING_ERROR = "ENCODING_ERROR";
    public const string ENTRY_PARAM_ERROR = "ENTRY_PARAM_ERROR";
    public const string EXPECTING_LEFT_PAREN = "EXPECTING_LEFT_PAREN";
    public const string EXPECTING_RIGHT_PAREN = "EXPECTING_RIGHT_PAREN";
    public const string FAILED_REFERRAL = "FAILED_REFERRAL";
    public const string IMPROPER_REFERRAL = "IMPROPER_REFERRAL";
    public const string INVALID_ADDRESS = "INVALID_ADDRESS";
    public const string INVALID_CHAR_IN_DESCR = "INVALID_CHAR_IN_DESCR";
    public const string INVALID_CHAR_IN_FILTER = "INVALID_CHAR_IN_FILTER";
    public const string INVALID_ESC_IN_DESCR = "INVALID_ESC_IN_DESCR";
    public const string INVALID_ESCAPE = "INVALID_ESCAPE";
    public const string INVALID_FILTER_COMPARISON = "INVALID_FILTER_COMPARISON";
    public const string IO_EXCEPTION = "IO_EXCEPTION";
    public const string MATCHED_DN = "MATCHED_DN";
    public const string MISSING_LEFT_PAREN = "MISSING_LEFT_PAREN";
    public const string MISSING_RIGHT_PAREN = "MISSING_RIGHT_PAREN";
    public const string MULTIPLE_SCHEMA = "MULTIPLE_SCHEMA";
    public const string NO_ATTRIBUTE_NAME = "NO_ATTRIBUTE_NAME";
    public const string NO_DN_NOR_MATCHING_RULE = "NO_DN_NOR_MATCHING_RULE";
    public const string NO_DUP_REQUEST = "NO_DUP_REQUEST";
    public const string NO_MATCHING_RULE = "NO_MATCHING_RULE";
    public const string NO_MEMORY = "NO_MEMORY";
    public const string NO_OPTION = "NO_OPTION";
    public const string NO_SCHEMA = "NO_SCHEMA";
    public const string NO_STARTTLS = "NO_STARTTLS";
    public const string NO_SUP_PROPERTY = "NO_SUP_PROPERTY";
    public const string NO_TLS_FACTORY = "NO_TLS_FACTORY";
    public const string NOT_AN_ATTRIBUTE = "NOT_AN_ATTRIBUTE";
    public const string NOT_IMPLEMENTED = "NOT_IMPLEMENTED";
    public const string OP_PARAM_ERROR = "OP_PARAM_ERROR";
    public const string OUTSTANDING_OPERATIONS = "OUTSTANDING_OPERATIONS";
    public const string PARAM_ERROR = "PARAM_ERROR";
    public const string RDN_PARAM_ERROR = "RDN_PARAM_ERROR";
    public const string READ_MULTIPLE = "READ_MULTIPLE";
    public const string REFERENCE_ERROR = "REFERENCE_ERROR";
    public const string REFERENCE_NOFOLLOW = "REFERENCE_NOFOLLOW";
    public const string REFERRAL_BIND = "REFERRAL_BIND";
    public const string REFERRAL_BIND_MATCH = "REFERRAL_BIND_MATCH";
    public const string REFERRAL_ERROR = "REFERRAL_ERROR";
    public const string REFERRAL_ITEM = "REFERRAL_ITEM";
    public const string REFERRAL_LOCAL = "REFERRAL_LOCAL";
    public const string REFERRAL_SEND = "REFERRAL_SEND";
    public const string SERVER_CONNECT_ERROR = "SERVER_CONNECT_ERROR";
    public const string SERVER_MSG = "SERVER_MSG";
    public const string SERVER_SHUTDOWN_REQ = "SERVER_SHUTDOWN_REQ";
    public const string SHORT_ESCAPE = "SHORT_ESCAPE";
    public const string SSL_PROVIDER_MISSING = "SSL_PROVIDER_MISSING";
    public const string STOPTLS_ERROR = "STOPTLS_ERROR";
    [System.CLSCompliantAttribute(false)]
    public const string TOSTRING = "TOSTRING";
    public const string UNEQUAL_LENGTHS = "UNEQUAL_LENGTHS";
    public const string UNEXPECTED_END = "UNEXPECTED_END";
    public const string UNKNOWN_RESULT = "UNKNOWN_RESULT";
    public const string WRONG_FACTORY = "WRONG_FACTORY";
    public ExceptionMessages() { }
    public System.Object[][] getContents() { return default(System.Object[][]); }
  }
  public partial class ExtResponseFactory {
    public ExtResponseFactory() { }
    public static Novell.Directory.Ldap.LdapExtendedResponse convertToExtendedResponse(Novell.Directory.Ldap.Rfc2251.RfcLdapMessage inResponse) { return default(Novell.Directory.Ldap.LdapExtendedResponse); }
  }
  public partial class IntermediateResponseFactory {
    public IntermediateResponseFactory() { }
    public static Novell.Directory.Ldap.LdapIntermediateResponse convertToIntermediateResponse(Novell.Directory.Ldap.Rfc2251.RfcLdapMessage inResponse) { return default(Novell.Directory.Ldap.LdapIntermediateResponse); }
  }
  public partial class RDN {
    public RDN() { }
    public RDN(string rdn) { }
    public virtual bool Multivalued { get { return default(bool); } }
    protected internal virtual string RawValue { get { return default(string); } }
    public virtual string Type { get { return default(string); } }
    public virtual System.String[] Types { get { return default(System.String[]); } }
    public virtual string Value { get { return default(string); } }
    public virtual System.String[] Values { get { return default(System.String[]); } }
    public virtual void add(string attrType, string attrValue, string rawValue) { }
    [System.CLSCompliantAttribute(false)]
    public virtual bool equals(Novell.Directory.Ldap.Utilclass.RDN rdn) { return default(bool); }
    public virtual System.String[] explodeRDN(bool noTypes) { return default(System.String[]); }
    public override string ToString() { return default(string); }
    [System.CLSCompliantAttribute(false)]
    public virtual string toString(bool noTypes) { return default(string); }
  }
  public partial class ReferralInfo {
    public ReferralInfo(Novell.Directory.Ldap.LdapConnection lc, System.String[] refList, Novell.Directory.Ldap.LdapUrl refUrl) { }
    public virtual Novell.Directory.Ldap.LdapConnection ReferralConnection { get { return default(Novell.Directory.Ldap.LdapConnection); } }
    public virtual System.String[] ReferralList { get { return default(System.String[]); } }
    public virtual Novell.Directory.Ldap.LdapUrl ReferralUrl { get { return default(Novell.Directory.Ldap.LdapUrl); } }
  }
  public partial class ResourcesHandler {
    internal ResourcesHandler() { }
    public static string getMessage(string messageOrKey, System.Object[] arguments) { return default(string); }
    public static string getMessage(string messageOrKey, System.Object[] arguments, System.Globalization.CultureInfo locale) { return default(string); }
    public static string getResultString(int code) { return default(string); }
    public static string getResultString(int code, System.Globalization.CultureInfo locale) { return default(string); }
  }
  public partial class RespControlVector : System.Collections.ArrayList {
    public RespControlVector(int cap, int incr) { }
    public System.Type findResponseControl(string searchOID) { return default(System.Type); }
    public void registerResponseControl(string oid, System.Type controlClass) { }
  }
  public partial class RespExtensionSet : SupportClass.AbstractSetSupport {
    public RespExtensionSet() { }
    public override int Count { get { return default(int); } }
    public System.Type findResponseExtension(string searchOID) { return default(System.Type); }
    public override System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public void registerResponseExtension(string oid, System.Type extClass) { }
  }
  public partial class ResultCodeMessages : System.Resources.ResourceManager {
    public ResultCodeMessages() { }
    public System.Object[][] getContents() { return default(System.Object[][]); }
  }
  public partial class SchemaParser {
    public SchemaParser(string aString) { }
    public virtual System.String[] Applies { get { return default(System.String[]); } }
    public virtual System.String[] Auxiliary { get { return default(System.String[]); } }
    public virtual bool Collective { get { return default(bool); } }
    public virtual string Description { get { return default(string); } }
    public virtual string Equality { get { return default(string); } }
    public virtual string ID { get { return default(string); } }
    public virtual string NameForm { get { return default(string); } }
    public virtual System.String[] Names { get { return default(System.String[]); } }
    public virtual string ObjectClass { get { return default(string); } }
    public virtual bool Obsolete { get { return default(bool); } }
    public virtual System.String[] Optional { get { return default(System.String[]); } }
    public virtual string Ordering { get { return default(string); } }
    public virtual System.String[] Precluded { get { return default(System.String[]); } }
    public virtual System.Collections.IEnumerator Qualifiers { get { return default(System.Collections.IEnumerator); } }
    public virtual string RawString { get { return default(string); } set { } }
    public virtual System.String[] Required { get { return default(System.String[]); } }
    public virtual bool Single { get { return default(bool); } }
    public virtual string Substring { get { return default(string); } }
    public virtual string Superior { get { return default(string); } }
    public virtual System.String[] Superiors { get { return default(System.String[]); } }
    public virtual string Syntax { get { return default(string); } }
    public virtual int Type { get { return default(int); } }
    public virtual int Usage { get { return default(int); } }
    public virtual bool UserMod { get { return default(bool); } }
  }
  public partial class SchemaTokenCreator {
    public int lastttype;
    public double NumberValue;
    public string StringValue;
    public SchemaTokenCreator(System.IO.Stream instream) { }
    public SchemaTokenCreator(System.IO.StreamReader r) { }
    public SchemaTokenCreator(System.IO.StringReader r) { }
    public int CurrentLine { get { return default(int); } }
    public void CommentCharacter(int ch) { }
    public void InitTable() { }
    public int nextToken() { return default(int); }
    public void OrdinaryCharacter(int ch) { }
    public void OrdinaryCharacters(int min, int max) { }
    public void parseNumbers() { }
    public void pushBack() { }
    public void QuoteCharacter(int ch) { }
    public string ToStringValue() { return default(string); }
    public void WhitespaceCharacters(int min, int max) { }
    public void WordCharacters(int min, int max) { }
  }
  public enum TokenTypes {
    EOF = -1,
    EOL = 10,
    NUMBER = -2,
    REAL = -4,
    STRING = -5,
    WORD = -3,
  }
}
