namespace Microsoft.CSharp {
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Unrestricted=true)]
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
  public partial class CSharpCodeProvider : System.CodeDom.Compiler.CodeDomProvider {
    public CSharpCodeProvider() { }
    public CSharpCodeProvider(System.Collections.Generic.IDictionary<System.String, System.String> providerOptions) { }
    public override string FileExtension { get { return default(string); } }
    [System.ObsoleteAttribute("Use CodeDomProvider class")]
    public override System.CodeDom.Compiler.ICodeCompiler CreateCompiler() { return default(System.CodeDom.Compiler.ICodeCompiler); }
    [System.ObsoleteAttribute("Use CodeDomProvider class")]
    public override System.CodeDom.Compiler.ICodeGenerator CreateGenerator() { return default(System.CodeDom.Compiler.ICodeGenerator); }
    [System.MonoTODOAttribute]
    public override void GenerateCodeFromMember(System.CodeDom.CodeTypeMember member, System.IO.TextWriter writer, System.CodeDom.Compiler.CodeGeneratorOptions options) { }
    [System.MonoTODOAttribute]
    public override System.ComponentModel.TypeConverter GetConverter(System.Type type) { return default(System.ComponentModel.TypeConverter); }
  }
}
namespace Microsoft.VisualBasic {
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Unrestricted=true)]
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
  public partial class VBCodeProvider : System.CodeDom.Compiler.CodeDomProvider {
    public VBCodeProvider() { }
    public VBCodeProvider(System.Collections.Generic.IDictionary<System.String, System.String> providerOptions) { }
    public override string FileExtension { get { return default(string); } }
    public override System.CodeDom.Compiler.LanguageOptions LanguageOptions { get { return default(System.CodeDom.Compiler.LanguageOptions); } }
    [System.ObsoleteAttribute("Use CodeDomProvider class")]
    public override System.CodeDom.Compiler.ICodeCompiler CreateCompiler() { return default(System.CodeDom.Compiler.ICodeCompiler); }
    [System.ObsoleteAttribute("Use CodeDomProvider class")]
    public override System.CodeDom.Compiler.ICodeGenerator CreateGenerator() { return default(System.CodeDom.Compiler.ICodeGenerator); }
    [System.MonoTODOAttribute]
    public override void GenerateCodeFromMember(System.CodeDom.CodeTypeMember member, System.IO.TextWriter writer, System.CodeDom.Compiler.CodeGeneratorOptions options) { }
    public override System.ComponentModel.TypeConverter GetConverter(System.Type type) { return default(System.ComponentModel.TypeConverter); }
  }
}
namespace Microsoft.Win32 {
  public partial class IntranetZoneCredentialPolicy : System.Net.ICredentialPolicy {
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, ControlPolicy=true)]
    public IntranetZoneCredentialPolicy() { }
    public virtual bool ShouldSendCredential(System.Uri challengeUri, System.Net.WebRequest request, System.Net.NetworkCredential credential, System.Net.IAuthenticationModule authModule) { return default(bool); }
  }
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Unrestricted=true)]
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
  public partial class PowerModeChangedEventArgs : System.EventArgs {
    public PowerModeChangedEventArgs(Microsoft.Win32.PowerModes mode) { }
    public Microsoft.Win32.PowerModes Mode { get { return default(Microsoft.Win32.PowerModes); } }
  }
  public delegate void PowerModeChangedEventHandler(object sender, Microsoft.Win32.PowerModeChangedEventArgs e);
  public enum PowerModes {
    Resume = 1,
    StatusChange = 2,
    Suspend = 3,
  }
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Unrestricted=true)]
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
  public partial class SessionEndedEventArgs : System.EventArgs {
    public SessionEndedEventArgs(Microsoft.Win32.SessionEndReasons reason) { }
    public Microsoft.Win32.SessionEndReasons Reason { get { return default(Microsoft.Win32.SessionEndReasons); } }
  }
  public delegate void SessionEndedEventHandler(object sender, Microsoft.Win32.SessionEndedEventArgs e);
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Unrestricted=true)]
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
  public partial class SessionEndingEventArgs : System.EventArgs {
    public SessionEndingEventArgs(Microsoft.Win32.SessionEndReasons reason) { }
    public bool Cancel { get { return default(bool); } set { } }
    public Microsoft.Win32.SessionEndReasons Reason { get { return default(Microsoft.Win32.SessionEndReasons); } }
  }
  public delegate void SessionEndingEventHandler(object sender, Microsoft.Win32.SessionEndingEventArgs e);
  public enum SessionEndReasons {
    Logoff = 1,
    SystemShutdown = 2,
  }
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Unrestricted=true)]
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
  public partial class SessionSwitchEventArgs : System.EventArgs {
    public SessionSwitchEventArgs(Microsoft.Win32.SessionSwitchReason reason) { }
    public Microsoft.Win32.SessionSwitchReason Reason { get { return default(Microsoft.Win32.SessionSwitchReason); } }
  }
  public delegate void SessionSwitchEventHandler(object sender, Microsoft.Win32.SessionSwitchEventArgs e);
  public enum SessionSwitchReason {
    ConsoleConnect = 1,
    ConsoleDisconnect = 2,
    RemoteConnect = 3,
    RemoteDisconnect = 4,
    SessionLock = 7,
    SessionLogoff = 6,
    SessionLogon = 5,
    SessionRemoteControl = 9,
    SessionUnlock = 8,
  }
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
  public sealed partial class SystemEvents {
    internal SystemEvents() { }
    [System.MonoTODOAttribute]
    public static event System.EventHandler DisplaySettingsChanged { add { } remove { } }
    [System.MonoTODOAttribute("Currently does nothing on Mono")]
    public static event System.EventHandler DisplaySettingsChanging { add { } remove { } }
    [System.MonoTODOAttribute("Currently does nothing on Mono")]
    public static event System.EventHandler EventsThreadShutdown { add { } remove { } }
    [System.MonoTODOAttribute("Currently does nothing on Mono")]
    public static event System.EventHandler InstalledFontsChanged { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.MonoTODOAttribute("Currently does nothing on Mono")]
    [System.ObsoleteAttribute("")]
    public static event System.EventHandler LowMemory { add { } remove { } }
    [System.MonoTODOAttribute("Currently does nothing on Mono")]
    public static event System.EventHandler PaletteChanged { add { } remove { } }
    [System.MonoTODOAttribute("Currently does nothing on Mono")]
    public static event Microsoft.Win32.PowerModeChangedEventHandler PowerModeChanged { add { } remove { } }
    [System.MonoTODOAttribute("Currently does nothing on Mono")]
    public static event Microsoft.Win32.SessionEndedEventHandler SessionEnded { add { } remove { } }
    [System.MonoTODOAttribute("Currently does nothing on Mono")]
    public static event Microsoft.Win32.SessionEndingEventHandler SessionEnding { add { } remove { } }
    [System.MonoTODOAttribute("Currently does nothing on Mono")]
    public static event Microsoft.Win32.SessionSwitchEventHandler SessionSwitch { add { } remove { } }
    [System.MonoTODOAttribute("Currently does nothing on Mono")]
    public static event System.EventHandler TimeChanged { add { } remove { } }
    public static event Microsoft.Win32.TimerElapsedEventHandler TimerElapsed { add { } remove { } }
    [System.MonoTODOAttribute("Currently does nothing on Mono")]
    public static event Microsoft.Win32.UserPreferenceChangedEventHandler UserPreferenceChanged { add { } remove { } }
    [System.MonoTODOAttribute("Currently does nothing on Mono")]
    public static event Microsoft.Win32.UserPreferenceChangingEventHandler UserPreferenceChanging { add { } remove { } }
    public static System.IntPtr CreateTimer(int interval) { return default(System.IntPtr); }
    [System.MonoTODOAttribute]
    public static void InvokeOnEventsThread(System.Delegate method) { }
    public static void KillTimer(System.IntPtr timerId) { }
  }
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Unrestricted=true)]
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
  public partial class TimerElapsedEventArgs : System.EventArgs {
    public TimerElapsedEventArgs(System.IntPtr timerId) { }
    public System.IntPtr TimerId { get { return default(System.IntPtr); } }
  }
  public delegate void TimerElapsedEventHandler(object sender, Microsoft.Win32.TimerElapsedEventArgs e);
  public enum UserPreferenceCategory {
    Accessibility = 1,
    Color = 2,
    Desktop = 3,
    General = 4,
    Icon = 5,
    Keyboard = 6,
    Locale = 13,
    Menu = 7,
    Mouse = 8,
    Policy = 9,
    Power = 10,
    Screensaver = 11,
    VisualStyle = 14,
    Window = 12,
  }
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Unrestricted=true)]
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
  public partial class UserPreferenceChangedEventArgs : System.EventArgs {
    public UserPreferenceChangedEventArgs(Microsoft.Win32.UserPreferenceCategory category) { }
    public Microsoft.Win32.UserPreferenceCategory Category { get { return default(Microsoft.Win32.UserPreferenceCategory); } }
  }
  public delegate void UserPreferenceChangedEventHandler(object sender, Microsoft.Win32.UserPreferenceChangedEventArgs e);
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Unrestricted=true)]
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
  public partial class UserPreferenceChangingEventArgs : System.EventArgs {
    public UserPreferenceChangingEventArgs(Microsoft.Win32.UserPreferenceCategory category) { }
    public Microsoft.Win32.UserPreferenceCategory Category { get { return default(Microsoft.Win32.UserPreferenceCategory); } }
  }
  public delegate void UserPreferenceChangingEventHandler(object sender, Microsoft.Win32.UserPreferenceChangingEventArgs e);
}
namespace System {
  public partial class FileStyleUriParser : System.UriParser {
    public FileStyleUriParser() { }
  }
  public partial class FtpStyleUriParser : System.UriParser {
    public FtpStyleUriParser() { }
  }
  public partial class GenericUriParser : System.UriParser {
    public GenericUriParser(System.GenericUriParserOptions options) { }
  }
  [System.FlagsAttribute]
  public enum GenericUriParserOptions {
    AllowEmptyAuthority = 2,
    Default = 0,
    DontCompressPath = 128,
    DontConvertPathBackslashes = 64,
    DontUnescapePathDotsAndSlashes = 256,
    GenericAuthority = 1,
    Idn = 512,
    IriParsing = 1024,
    NoFragment = 32,
    NoPort = 8,
    NoQuery = 16,
    NoUserInfo = 4,
  }
  public partial class GopherStyleUriParser : System.UriParser {
    public GopherStyleUriParser() { }
  }
  public partial class HttpStyleUriParser : System.UriParser {
    public HttpStyleUriParser() { }
  }
  public partial class LdapStyleUriParser : System.UriParser {
    public LdapStyleUriParser() { }
  }
  [System.MonoTODOAttribute]
  public partial class NetPipeStyleUriParser : System.UriParser {
    public NetPipeStyleUriParser() { }
  }
  [System.MonoTODOAttribute]
  public partial class NetTcpStyleUriParser : System.UriParser {
    public NetTcpStyleUriParser() { }
  }
  [System.MonoTODOAttribute]
  public partial class NewsStyleUriParser : System.UriParser {
    public NewsStyleUriParser() { }
  }
  [System.ComponentModel.TypeConverterAttribute(typeof(System.UriTypeConverter))]
  public partial class Uri : System.Runtime.Serialization.ISerializable {
    public static readonly string SchemeDelimiter;
    public static readonly string UriSchemeFile;
    public static readonly string UriSchemeFtp;
    public static readonly string UriSchemeGopher;
    public static readonly string UriSchemeHttp;
    public static readonly string UriSchemeHttps;
    public static readonly string UriSchemeMailto;
    public static readonly string UriSchemeNetPipe;
    public static readonly string UriSchemeNetTcp;
    public static readonly string UriSchemeNews;
    public static readonly string UriSchemeNntp;
    protected Uri(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    public Uri(string uriString) { }
    [System.ObsoleteAttribute]
    public Uri(string uriString, bool dontEscape) { }
    public Uri(string uriString, System.UriKind uriKind) { }
    public Uri(System.Uri baseUri, string relativeUri) { }
    [System.ObsoleteAttribute("dontEscape is always false")]
    public Uri(System.Uri baseUri, string relativeUri, bool dontEscape) { }
    public Uri(System.Uri baseUri, System.Uri relativeUri) { }
    public string AbsolutePath { get { return default(string); } }
    public string AbsoluteUri { get { return default(string); } }
    public string Authority { get { return default(string); } }
    public string DnsSafeHost { get { return default(string); } }
    public string Fragment { get { return default(string); } }
    public string Host { get { return default(string); } }
    public System.UriHostNameType HostNameType { get { return default(System.UriHostNameType); } }
    public bool IsAbsoluteUri { get { return default(bool); } }
    public bool IsDefaultPort { get { return default(bool); } }
    public bool IsFile { get { return default(bool); } }
    public bool IsLoopback { get { return default(bool); } }
    public bool IsUnc { get { return default(bool); } }
    public string LocalPath { get { return default(string); } }
    public string OriginalString { get { return default(string); } }
    public string PathAndQuery { get { return default(string); } }
    public int Port { get { return default(int); } }
    public string Query { get { return default(string); } }
    public string Scheme { get { return default(string); } }
    public System.String[] Segments { get { return default(System.String[]); } }
    public bool UserEscaped { get { return default(bool); } }
    public string UserInfo { get { return default(string); } }
    [System.ObsoleteAttribute("This method does nothing, it has been obsoleted")]
    protected virtual void Canonicalize() { }
    public static System.UriHostNameType CheckHostName(string name) { return default(System.UriHostNameType); }
    public static bool CheckSchemeName(string schemeName) { return default(bool); }
    [System.MonoTODOAttribute("Find out what this should do")]
    [System.ObsoleteAttribute]
    protected virtual void CheckSecurity() { }
    public static int Compare(System.Uri uri1, System.Uri uri2, System.UriComponents partsToCompare, System.UriFormat compareFormat, System.StringComparison comparisonType) { return default(int); }
    public override bool Equals(object comparand) { return default(bool); }
    [System.ObsoleteAttribute]
    protected virtual void Escape() { }
    public static string EscapeDataString(string stringToEscape) { return default(string); }
    [System.ObsoleteAttribute]
    protected static string EscapeString(string str) { return default(string); }
    public static string EscapeUriString(string stringToEscape) { return default(string); }
    public static int FromHex(char digit) { return default(int); }
    public string GetComponents(System.UriComponents components, System.UriFormat format) { return default(string); }
    public override int GetHashCode() { return default(int); }
    public string GetLeftPart(System.UriPartial part) { return default(string); }
    protected void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    public static string HexEscape(char character) { return default(string); }
    public static char HexUnescape(string pattern, ref int index) { return default(char); }
    [System.ObsoleteAttribute]
    protected virtual bool IsBadFileSystemCharacter(char character) { return default(bool); }
    public bool IsBaseOf(System.Uri uri) { return default(bool); }
    [System.ObsoleteAttribute]
    protected static bool IsExcludedCharacter(char character) { return default(bool); }
    public static bool IsHexDigit(char character) { return default(bool); }
    public static bool IsHexEncoding(string pattern, int index) { return default(bool); }
    [System.ObsoleteAttribute]
    protected virtual bool IsReservedCharacter(char character) { return default(bool); }
    public bool IsWellFormedOriginalString() { return default(bool); }
    public static bool IsWellFormedUriString(string uriString, System.UriKind uriKind) { return default(bool); }
    [System.ObsoleteAttribute("Use MakeRelativeUri(Uri uri) instead.")]
    public string MakeRelative(System.Uri toUri) { return default(string); }
    public System.Uri MakeRelativeUri(System.Uri uri) { return default(System.Uri); }
    public static bool operator ==(System.Uri uri1, System.Uri uri2) { return default(bool); }
    public static bool operator !=(System.Uri uri1, System.Uri uri2) { return default(bool); }
    [System.ObsoleteAttribute("The method has been deprecated. It is not used by the system.")]
    protected virtual void Parse() { }
    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public override string ToString() { return default(string); }
    public static bool TryCreate(string uriString, System.UriKind uriKind, out System.Uri result) { result = default(System.Uri); return default(bool); }
    public static bool TryCreate(System.Uri baseUri, string relativeUri, out System.Uri result) { result = default(System.Uri); return default(bool); }
    public static bool TryCreate(System.Uri baseUri, System.Uri relativeUri, out System.Uri result) { result = default(System.Uri); return default(bool); }
    [System.ObsoleteAttribute]
    protected virtual string Unescape(string path) { return default(string); }
    public static string UnescapeDataString(string stringToUnescape) { return default(string); }
  }
  public partial class UriBuilder {
    public UriBuilder() { }
    public UriBuilder(string uri) { }
    public UriBuilder(string schemeName, string hostName) { }
    public UriBuilder(string scheme, string host, int portNumber) { }
    public UriBuilder(string scheme, string host, int port, string pathValue) { }
    public UriBuilder(string scheme, string host, int port, string path, string extraValue) { }
    public UriBuilder(System.Uri uri) { }
    public string Fragment { get { return default(string); } set { } }
    public string Host { get { return default(string); } set { } }
    public string Password { get { return default(string); } set { } }
    public string Path { get { return default(string); } set { } }
    public int Port { get { return default(int); } set { } }
    public string Query { get { return default(string); } set { } }
    public string Scheme { get { return default(string); } set { } }
    public System.Uri Uri { get { return default(System.Uri); } }
    public string UserName { get { return default(string); } set { } }
    public override bool Equals(object rparam) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
  }
  [System.FlagsAttribute]
  public enum UriComponents {
    AbsoluteUri = 127,
    Fragment = 64,
    Host = 4,
    HostAndPort = 132,
    HttpRequestUrl = 61,
    KeepDelimiter = 1073741824,
    Path = 16,
    PathAndQuery = 48,
    Port = 8,
    Query = 32,
    Scheme = 1,
    SchemeAndServer = 13,
    SerializationInfoString = -2147483648,
    StrongAuthority = 134,
    StrongPort = 128,
    UserInfo = 2,
  }
  public enum UriFormat {
    SafeUnescaped = 3,
    Unescaped = 2,
    UriEscaped = 1,
  }
  public partial class UriFormatException : System.FormatException, System.Runtime.Serialization.ISerializable {
    public UriFormatException() { }
    protected UriFormatException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    public UriFormatException(string textString) { }
    public UriFormatException(string textString, System.Exception e) { }
    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public enum UriHostNameType {
    Basic = 1,
    Dns = 2,
    IPv4 = 3,
    IPv6 = 4,
    Unknown = 0,
  }
  public enum UriIdnScope {
    All = 2,
    AllExceptIntranet = 1,
    None = 0,
  }
  public enum UriKind {
    Absolute = 1,
    Relative = 2,
    RelativeOrAbsolute = 0,
  }
  public abstract partial class UriParser {
    protected UriParser() { }
    protected internal virtual string GetComponents(System.Uri uri, System.UriComponents components, System.UriFormat format) { return default(string); }
    protected internal virtual void InitializeAndValidate(System.Uri uri, out System.UriFormatException parsingError) { parsingError = default(System.UriFormatException); }
    protected internal virtual bool IsBaseOf(System.Uri baseUri, System.Uri relativeUri) { return default(bool); }
    public static bool IsKnownScheme(string schemeName) { return default(bool); }
    protected internal virtual bool IsWellFormedOriginalString(System.Uri uri) { return default(bool); }
    protected internal virtual System.UriParser OnNewUri() { return default(System.UriParser); }
    [System.MonoTODOAttribute]
    protected virtual void OnRegister(string schemeName, int defaultPort) { }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Infrastructure=true)]
    public static void Register(System.UriParser uriParser, string schemeName, int defaultPort) { }
    [System.MonoTODOAttribute]
    protected internal virtual string Resolve(System.Uri baseUri, System.Uri relativeUri, out System.UriFormatException parsingError) { parsingError = default(System.UriFormatException); return default(string); }
  }
  public enum UriPartial {
    Authority = 1,
    Path = 2,
    Query = 3,
    Scheme = 0,
  }
  public partial class UriTypeConverter : System.ComponentModel.TypeConverter {
    public UriTypeConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
    public override bool IsValid(System.ComponentModel.ITypeDescriptorContext context, object value) { return default(bool); }
  }
}
namespace System.CodeDom {
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeArgumentReferenceExpression : System.CodeDom.CodeExpression {
    public CodeArgumentReferenceExpression() { }
    public CodeArgumentReferenceExpression(string name) { }
    public string ParameterName { get { return default(string); } set { } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeArrayCreateExpression : System.CodeDom.CodeExpression {
    public CodeArrayCreateExpression() { }
    public CodeArrayCreateExpression(System.CodeDom.CodeTypeReference createType, System.CodeDom.CodeExpression size) { }
    public CodeArrayCreateExpression(System.CodeDom.CodeTypeReference createType, params System.CodeDom.CodeExpression[] initializers) { }
    public CodeArrayCreateExpression(System.CodeDom.CodeTypeReference createType, int size) { }
    public CodeArrayCreateExpression(string createType, System.CodeDom.CodeExpression size) { }
    public CodeArrayCreateExpression(string createType, params System.CodeDom.CodeExpression[] initializers) { }
    public CodeArrayCreateExpression(string createType, int size) { }
    public CodeArrayCreateExpression(System.Type createType, System.CodeDom.CodeExpression size) { }
    public CodeArrayCreateExpression(System.Type createType, params System.CodeDom.CodeExpression[] initializers) { }
    public CodeArrayCreateExpression(System.Type createType, int size) { }
    public System.CodeDom.CodeTypeReference CreateType { get { return default(System.CodeDom.CodeTypeReference); } set { } }
    public System.CodeDom.CodeExpressionCollection Initializers { get { return default(System.CodeDom.CodeExpressionCollection); } }
    public int Size { get { return default(int); } set { } }
    public System.CodeDom.CodeExpression SizeExpression { get { return default(System.CodeDom.CodeExpression); } set { } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeArrayIndexerExpression : System.CodeDom.CodeExpression {
    public CodeArrayIndexerExpression() { }
    public CodeArrayIndexerExpression(System.CodeDom.CodeExpression targetObject, params System.CodeDom.CodeExpression[] indices) { }
    public System.CodeDom.CodeExpressionCollection Indices { get { return default(System.CodeDom.CodeExpressionCollection); } }
    public System.CodeDom.CodeExpression TargetObject { get { return default(System.CodeDom.CodeExpression); } set { } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeAssignStatement : System.CodeDom.CodeStatement {
    public CodeAssignStatement() { }
    public CodeAssignStatement(System.CodeDom.CodeExpression left, System.CodeDom.CodeExpression right) { }
    public System.CodeDom.CodeExpression Left { get { return default(System.CodeDom.CodeExpression); } set { } }
    public System.CodeDom.CodeExpression Right { get { return default(System.CodeDom.CodeExpression); } set { } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeAttachEventStatement : System.CodeDom.CodeStatement {
    public CodeAttachEventStatement() { }
    public CodeAttachEventStatement(System.CodeDom.CodeEventReferenceExpression eventRef, System.CodeDom.CodeExpression listener) { }
    public CodeAttachEventStatement(System.CodeDom.CodeExpression targetObject, string eventName, System.CodeDom.CodeExpression listener) { }
    public System.CodeDom.CodeEventReferenceExpression Event { get { return default(System.CodeDom.CodeEventReferenceExpression); } set { } }
    public System.CodeDom.CodeExpression Listener { get { return default(System.CodeDom.CodeExpression); } set { } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeAttributeArgument {
    public CodeAttributeArgument() { }
    public CodeAttributeArgument(System.CodeDom.CodeExpression value) { }
    public CodeAttributeArgument(string name, System.CodeDom.CodeExpression value) { }
    public string Name { get { return default(string); } set { } }
    public System.CodeDom.CodeExpression Value { get { return default(System.CodeDom.CodeExpression); } set { } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeAttributeArgumentCollection : System.Collections.CollectionBase {
    public CodeAttributeArgumentCollection() { }
    public CodeAttributeArgumentCollection(System.CodeDom.CodeAttributeArgument[] value) { }
    public CodeAttributeArgumentCollection(System.CodeDom.CodeAttributeArgumentCollection value) { }
    public System.CodeDom.CodeAttributeArgument this[int index] { get { return default(System.CodeDom.CodeAttributeArgument); } set { } }
    public int Add(System.CodeDom.CodeAttributeArgument value) { return default(int); }
    public void AddRange(System.CodeDom.CodeAttributeArgument[] value) { }
    public void AddRange(System.CodeDom.CodeAttributeArgumentCollection value) { }
    public bool Contains(System.CodeDom.CodeAttributeArgument value) { return default(bool); }
    public void CopyTo(System.CodeDom.CodeAttributeArgument[] array, int index) { }
    public int IndexOf(System.CodeDom.CodeAttributeArgument value) { return default(int); }
    public void Insert(int index, System.CodeDom.CodeAttributeArgument value) { }
    public void Remove(System.CodeDom.CodeAttributeArgument value) { }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeAttributeDeclaration {
    public CodeAttributeDeclaration() { }
    public CodeAttributeDeclaration(System.CodeDom.CodeTypeReference attributeType) { }
    public CodeAttributeDeclaration(System.CodeDom.CodeTypeReference attributeType, params System.CodeDom.CodeAttributeArgument[] arguments) { }
    public CodeAttributeDeclaration(string name) { }
    public CodeAttributeDeclaration(string name, params System.CodeDom.CodeAttributeArgument[] arguments) { }
    public System.CodeDom.CodeAttributeArgumentCollection Arguments { get { return default(System.CodeDom.CodeAttributeArgumentCollection); } }
    public System.CodeDom.CodeTypeReference AttributeType { get { return default(System.CodeDom.CodeTypeReference); } }
    public string Name { get { return default(string); } set { } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeAttributeDeclarationCollection : System.Collections.CollectionBase {
    public CodeAttributeDeclarationCollection() { }
    public CodeAttributeDeclarationCollection(System.CodeDom.CodeAttributeDeclaration[] value) { }
    public CodeAttributeDeclarationCollection(System.CodeDom.CodeAttributeDeclarationCollection value) { }
    public System.CodeDom.CodeAttributeDeclaration this[int index] { get { return default(System.CodeDom.CodeAttributeDeclaration); } set { } }
    public int Add(System.CodeDom.CodeAttributeDeclaration value) { return default(int); }
    public void AddRange(System.CodeDom.CodeAttributeDeclaration[] value) { }
    public void AddRange(System.CodeDom.CodeAttributeDeclarationCollection value) { }
    public bool Contains(System.CodeDom.CodeAttributeDeclaration value) { return default(bool); }
    public void CopyTo(System.CodeDom.CodeAttributeDeclaration[] array, int index) { }
    public int IndexOf(System.CodeDom.CodeAttributeDeclaration value) { return default(int); }
    public void Insert(int index, System.CodeDom.CodeAttributeDeclaration value) { }
    public void Remove(System.CodeDom.CodeAttributeDeclaration value) { }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeBaseReferenceExpression : System.CodeDom.CodeExpression {
    public CodeBaseReferenceExpression() { }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeBinaryOperatorExpression : System.CodeDom.CodeExpression {
    public CodeBinaryOperatorExpression() { }
    public CodeBinaryOperatorExpression(System.CodeDom.CodeExpression left, System.CodeDom.CodeBinaryOperatorType op, System.CodeDom.CodeExpression right) { }
    public System.CodeDom.CodeExpression Left { get { return default(System.CodeDom.CodeExpression); } set { } }
    public System.CodeDom.CodeBinaryOperatorType Operator { get { return default(System.CodeDom.CodeBinaryOperatorType); } set { } }
    public System.CodeDom.CodeExpression Right { get { return default(System.CodeDom.CodeExpression); } set { } }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public enum CodeBinaryOperatorType {
    Add = 0,
    Assign = 5,
    BitwiseAnd = 10,
    BitwiseOr = 9,
    BooleanAnd = 12,
    BooleanOr = 11,
    Divide = 3,
    GreaterThan = 15,
    GreaterThanOrEqual = 16,
    IdentityEquality = 7,
    IdentityInequality = 6,
    LessThan = 13,
    LessThanOrEqual = 14,
    Modulus = 4,
    Multiply = 2,
    Subtract = 1,
    ValueEquality = 8,
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeCastExpression : System.CodeDom.CodeExpression {
    public CodeCastExpression() { }
    public CodeCastExpression(System.CodeDom.CodeTypeReference targetType, System.CodeDom.CodeExpression expression) { }
    public CodeCastExpression(string targetType, System.CodeDom.CodeExpression expression) { }
    public CodeCastExpression(System.Type targetType, System.CodeDom.CodeExpression expression) { }
    public System.CodeDom.CodeExpression Expression { get { return default(System.CodeDom.CodeExpression); } set { } }
    public System.CodeDom.CodeTypeReference TargetType { get { return default(System.CodeDom.CodeTypeReference); } set { } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeCatchClause {
    public CodeCatchClause() { }
    public CodeCatchClause(string localName) { }
    public CodeCatchClause(string localName, System.CodeDom.CodeTypeReference catchExceptionType) { }
    public CodeCatchClause(string localName, System.CodeDom.CodeTypeReference catchExceptionType, params System.CodeDom.CodeStatement[] statements) { }
    public System.CodeDom.CodeTypeReference CatchExceptionType { get { return default(System.CodeDom.CodeTypeReference); } set { } }
    public string LocalName { get { return default(string); } set { } }
    public System.CodeDom.CodeStatementCollection Statements { get { return default(System.CodeDom.CodeStatementCollection); } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeCatchClauseCollection : System.Collections.CollectionBase {
    public CodeCatchClauseCollection() { }
    public CodeCatchClauseCollection(System.CodeDom.CodeCatchClause[] value) { }
    public CodeCatchClauseCollection(System.CodeDom.CodeCatchClauseCollection value) { }
    public System.CodeDom.CodeCatchClause this[int index] { get { return default(System.CodeDom.CodeCatchClause); } set { } }
    public int Add(System.CodeDom.CodeCatchClause value) { return default(int); }
    public void AddRange(System.CodeDom.CodeCatchClause[] value) { }
    public void AddRange(System.CodeDom.CodeCatchClauseCollection value) { }
    public bool Contains(System.CodeDom.CodeCatchClause value) { return default(bool); }
    public void CopyTo(System.CodeDom.CodeCatchClause[] array, int index) { }
    public int IndexOf(System.CodeDom.CodeCatchClause value) { return default(int); }
    public void Insert(int index, System.CodeDom.CodeCatchClause value) { }
    public void Remove(System.CodeDom.CodeCatchClause value) { }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeChecksumPragma : System.CodeDom.CodeDirective {
    public CodeChecksumPragma() { }
    public CodeChecksumPragma(string fileName, System.Guid checksumAlgorithmId, System.Byte[] checksumData) { }
    public System.Guid ChecksumAlgorithmId { get { return default(System.Guid); } set { } }
    public System.Byte[] ChecksumData { get { return default(System.Byte[]); } set { } }
    public string FileName { get { return default(string); } set { } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeComment : System.CodeDom.CodeObject {
    public CodeComment() { }
    public CodeComment(string text) { }
    public CodeComment(string text, bool docComment) { }
    public bool DocComment { get { return default(bool); } set { } }
    public string Text { get { return default(string); } set { } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeCommentStatement : System.CodeDom.CodeStatement {
    public CodeCommentStatement() { }
    public CodeCommentStatement(System.CodeDom.CodeComment comment) { }
    public CodeCommentStatement(string text) { }
    public CodeCommentStatement(string text, bool docComment) { }
    public System.CodeDom.CodeComment Comment { get { return default(System.CodeDom.CodeComment); } set { } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeCommentStatementCollection : System.Collections.CollectionBase {
    public CodeCommentStatementCollection() { }
    public CodeCommentStatementCollection(System.CodeDom.CodeCommentStatement[] value) { }
    public CodeCommentStatementCollection(System.CodeDom.CodeCommentStatementCollection value) { }
    public System.CodeDom.CodeCommentStatement this[int index] { get { return default(System.CodeDom.CodeCommentStatement); } set { } }
    public int Add(System.CodeDom.CodeCommentStatement value) { return default(int); }
    public void AddRange(System.CodeDom.CodeCommentStatement[] value) { }
    public void AddRange(System.CodeDom.CodeCommentStatementCollection value) { }
    public bool Contains(System.CodeDom.CodeCommentStatement value) { return default(bool); }
    public void CopyTo(System.CodeDom.CodeCommentStatement[] array, int index) { }
    public int IndexOf(System.CodeDom.CodeCommentStatement value) { return default(int); }
    public void Insert(int index, System.CodeDom.CodeCommentStatement value) { }
    public void Remove(System.CodeDom.CodeCommentStatement value) { }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeCompileUnit : System.CodeDom.CodeObject {
    public CodeCompileUnit() { }
    public System.CodeDom.CodeAttributeDeclarationCollection AssemblyCustomAttributes { get { return default(System.CodeDom.CodeAttributeDeclarationCollection); } }
    public System.CodeDom.CodeDirectiveCollection EndDirectives { get { return default(System.CodeDom.CodeDirectiveCollection); } }
    public System.CodeDom.CodeNamespaceCollection Namespaces { get { return default(System.CodeDom.CodeNamespaceCollection); } }
    public System.Collections.Specialized.StringCollection ReferencedAssemblies { get { return default(System.Collections.Specialized.StringCollection); } }
    public System.CodeDom.CodeDirectiveCollection StartDirectives { get { return default(System.CodeDom.CodeDirectiveCollection); } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeConditionStatement : System.CodeDom.CodeStatement {
    public CodeConditionStatement() { }
    public CodeConditionStatement(System.CodeDom.CodeExpression condition, params System.CodeDom.CodeStatement[] trueStatements) { }
    public CodeConditionStatement(System.CodeDom.CodeExpression condition, System.CodeDom.CodeStatement[] trueStatements, System.CodeDom.CodeStatement[] falseStatements) { }
    public System.CodeDom.CodeExpression Condition { get { return default(System.CodeDom.CodeExpression); } set { } }
    public System.CodeDom.CodeStatementCollection FalseStatements { get { return default(System.CodeDom.CodeStatementCollection); } }
    public System.CodeDom.CodeStatementCollection TrueStatements { get { return default(System.CodeDom.CodeStatementCollection); } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeConstructor : System.CodeDom.CodeMemberMethod {
    public CodeConstructor() { }
    public System.CodeDom.CodeExpressionCollection BaseConstructorArgs { get { return default(System.CodeDom.CodeExpressionCollection); } }
    public System.CodeDom.CodeExpressionCollection ChainedConstructorArgs { get { return default(System.CodeDom.CodeExpressionCollection); } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeDefaultValueExpression : System.CodeDom.CodeExpression {
    public CodeDefaultValueExpression() { }
    public CodeDefaultValueExpression(System.CodeDom.CodeTypeReference type) { }
    public System.CodeDom.CodeTypeReference Type { get { return default(System.CodeDom.CodeTypeReference); } set { } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeDelegateCreateExpression : System.CodeDom.CodeExpression {
    public CodeDelegateCreateExpression() { }
    public CodeDelegateCreateExpression(System.CodeDom.CodeTypeReference delegateType, System.CodeDom.CodeExpression targetObject, string methodName) { }
    public System.CodeDom.CodeTypeReference DelegateType { get { return default(System.CodeDom.CodeTypeReference); } set { } }
    public string MethodName { get { return default(string); } set { } }
    public System.CodeDom.CodeExpression TargetObject { get { return default(System.CodeDom.CodeExpression); } set { } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeDelegateInvokeExpression : System.CodeDom.CodeExpression {
    public CodeDelegateInvokeExpression() { }
    public CodeDelegateInvokeExpression(System.CodeDom.CodeExpression targetObject) { }
    public CodeDelegateInvokeExpression(System.CodeDom.CodeExpression targetObject, params System.CodeDom.CodeExpression[] parameters) { }
    public System.CodeDom.CodeExpressionCollection Parameters { get { return default(System.CodeDom.CodeExpressionCollection); } }
    public System.CodeDom.CodeExpression TargetObject { get { return default(System.CodeDom.CodeExpression); } set { } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeDirectionExpression : System.CodeDom.CodeExpression {
    public CodeDirectionExpression() { }
    public CodeDirectionExpression(System.CodeDom.FieldDirection direction, System.CodeDom.CodeExpression expression) { }
    public System.CodeDom.FieldDirection Direction { get { return default(System.CodeDom.FieldDirection); } set { } }
    public System.CodeDom.CodeExpression Expression { get { return default(System.CodeDom.CodeExpression); } set { } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeDirective : System.CodeDom.CodeObject {
    public CodeDirective() { }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeDirectiveCollection : System.Collections.CollectionBase {
    public CodeDirectiveCollection() { }
    public CodeDirectiveCollection(System.CodeDom.CodeDirective[] value) { }
    public CodeDirectiveCollection(System.CodeDom.CodeDirectiveCollection value) { }
    public System.CodeDom.CodeDirective this[int index] { get { return default(System.CodeDom.CodeDirective); } set { } }
    public int Add(System.CodeDom.CodeDirective value) { return default(int); }
    public void AddRange(System.CodeDom.CodeDirective[] value) { }
    public void AddRange(System.CodeDom.CodeDirectiveCollection value) { }
    public bool Contains(System.CodeDom.CodeDirective value) { return default(bool); }
    public void CopyTo(System.CodeDom.CodeDirective[] array, int index) { }
    public int IndexOf(System.CodeDom.CodeDirective value) { return default(int); }
    public void Insert(int index, System.CodeDom.CodeDirective value) { }
    public void Remove(System.CodeDom.CodeDirective value) { }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeEntryPointMethod : System.CodeDom.CodeMemberMethod {
    public CodeEntryPointMethod() { }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeEventReferenceExpression : System.CodeDom.CodeExpression {
    public CodeEventReferenceExpression() { }
    public CodeEventReferenceExpression(System.CodeDom.CodeExpression targetObject, string eventName) { }
    public string EventName { get { return default(string); } set { } }
    public System.CodeDom.CodeExpression TargetObject { get { return default(System.CodeDom.CodeExpression); } set { } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeExpression : System.CodeDom.CodeObject {
    public CodeExpression() { }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeExpressionCollection : System.Collections.CollectionBase {
    public CodeExpressionCollection() { }
    public CodeExpressionCollection(System.CodeDom.CodeExpression[] value) { }
    public CodeExpressionCollection(System.CodeDom.CodeExpressionCollection value) { }
    public System.CodeDom.CodeExpression this[int index] { get { return default(System.CodeDom.CodeExpression); } set { } }
    public int Add(System.CodeDom.CodeExpression value) { return default(int); }
    public void AddRange(System.CodeDom.CodeExpression[] value) { }
    public void AddRange(System.CodeDom.CodeExpressionCollection value) { }
    public bool Contains(System.CodeDom.CodeExpression value) { return default(bool); }
    public void CopyTo(System.CodeDom.CodeExpression[] array, int index) { }
    public int IndexOf(System.CodeDom.CodeExpression value) { return default(int); }
    public void Insert(int index, System.CodeDom.CodeExpression value) { }
    public void Remove(System.CodeDom.CodeExpression value) { }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeExpressionStatement : System.CodeDom.CodeStatement {
    public CodeExpressionStatement() { }
    public CodeExpressionStatement(System.CodeDom.CodeExpression expression) { }
    public System.CodeDom.CodeExpression Expression { get { return default(System.CodeDom.CodeExpression); } set { } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeFieldReferenceExpression : System.CodeDom.CodeExpression {
    public CodeFieldReferenceExpression() { }
    public CodeFieldReferenceExpression(System.CodeDom.CodeExpression targetObject, string fieldName) { }
    public string FieldName { get { return default(string); } set { } }
    public System.CodeDom.CodeExpression TargetObject { get { return default(System.CodeDom.CodeExpression); } set { } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeGotoStatement : System.CodeDom.CodeStatement {
    public CodeGotoStatement() { }
    public CodeGotoStatement(string label) { }
    public string Label { get { return default(string); } set { } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeIndexerExpression : System.CodeDom.CodeExpression {
    public CodeIndexerExpression() { }
    public CodeIndexerExpression(System.CodeDom.CodeExpression targetObject, params System.CodeDom.CodeExpression[] indices) { }
    public System.CodeDom.CodeExpressionCollection Indices { get { return default(System.CodeDom.CodeExpressionCollection); } }
    public System.CodeDom.CodeExpression TargetObject { get { return default(System.CodeDom.CodeExpression); } set { } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeIterationStatement : System.CodeDom.CodeStatement {
    public CodeIterationStatement() { }
    public CodeIterationStatement(System.CodeDom.CodeStatement initStatement, System.CodeDom.CodeExpression testExpression, System.CodeDom.CodeStatement incrementStatement, params System.CodeDom.CodeStatement[] statements) { }
    public System.CodeDom.CodeStatement IncrementStatement { get { return default(System.CodeDom.CodeStatement); } set { } }
    public System.CodeDom.CodeStatement InitStatement { get { return default(System.CodeDom.CodeStatement); } set { } }
    public System.CodeDom.CodeStatementCollection Statements { get { return default(System.CodeDom.CodeStatementCollection); } }
    public System.CodeDom.CodeExpression TestExpression { get { return default(System.CodeDom.CodeExpression); } set { } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeLabeledStatement : System.CodeDom.CodeStatement {
    public CodeLabeledStatement() { }
    public CodeLabeledStatement(string label) { }
    public CodeLabeledStatement(string label, System.CodeDom.CodeStatement statement) { }
    public string Label { get { return default(string); } set { } }
    public System.CodeDom.CodeStatement Statement { get { return default(System.CodeDom.CodeStatement); } set { } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeLinePragma {
    public CodeLinePragma() { }
    public CodeLinePragma(string fileName, int lineNumber) { }
    public string FileName { get { return default(string); } set { } }
    public int LineNumber { get { return default(int); } set { } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeMemberEvent : System.CodeDom.CodeTypeMember {
    public CodeMemberEvent() { }
    public System.CodeDom.CodeTypeReferenceCollection ImplementationTypes { get { return default(System.CodeDom.CodeTypeReferenceCollection); } }
    public System.CodeDom.CodeTypeReference PrivateImplementationType { get { return default(System.CodeDom.CodeTypeReference); } set { } }
    public System.CodeDom.CodeTypeReference Type { get { return default(System.CodeDom.CodeTypeReference); } set { } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeMemberField : System.CodeDom.CodeTypeMember {
    public CodeMemberField() { }
    public CodeMemberField(System.CodeDom.CodeTypeReference type, string name) { }
    public CodeMemberField(string type, string name) { }
    public CodeMemberField(System.Type type, string name) { }
    public System.CodeDom.CodeExpression InitExpression { get { return default(System.CodeDom.CodeExpression); } set { } }
    public System.CodeDom.CodeTypeReference Type { get { return default(System.CodeDom.CodeTypeReference); } set { } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeMemberMethod : System.CodeDom.CodeTypeMember {
    public CodeMemberMethod() { }
    public System.CodeDom.CodeTypeReferenceCollection ImplementationTypes { get { return default(System.CodeDom.CodeTypeReferenceCollection); } }
    public System.CodeDom.CodeParameterDeclarationExpressionCollection Parameters { get { return default(System.CodeDom.CodeParameterDeclarationExpressionCollection); } }
    public System.CodeDom.CodeTypeReference PrivateImplementationType { get { return default(System.CodeDom.CodeTypeReference); } set { } }
    public System.CodeDom.CodeTypeReference ReturnType { get { return default(System.CodeDom.CodeTypeReference); } set { } }
    public System.CodeDom.CodeAttributeDeclarationCollection ReturnTypeCustomAttributes { get { return default(System.CodeDom.CodeAttributeDeclarationCollection); } }
    public System.CodeDom.CodeStatementCollection Statements { get { return default(System.CodeDom.CodeStatementCollection); } }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public System.CodeDom.CodeTypeParameterCollection TypeParameters { get { return default(System.CodeDom.CodeTypeParameterCollection); } }
    public event System.EventHandler PopulateImplementationTypes { add { } remove { } }
    public event System.EventHandler PopulateParameters { add { } remove { } }
    public event System.EventHandler PopulateStatements { add { } remove { } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeMemberProperty : System.CodeDom.CodeTypeMember {
    public CodeMemberProperty() { }
    public System.CodeDom.CodeStatementCollection GetStatements { get { return default(System.CodeDom.CodeStatementCollection); } }
    public bool HasGet { get { return default(bool); } set { } }
    public bool HasSet { get { return default(bool); } set { } }
    public System.CodeDom.CodeTypeReferenceCollection ImplementationTypes { get { return default(System.CodeDom.CodeTypeReferenceCollection); } }
    public System.CodeDom.CodeParameterDeclarationExpressionCollection Parameters { get { return default(System.CodeDom.CodeParameterDeclarationExpressionCollection); } }
    public System.CodeDom.CodeTypeReference PrivateImplementationType { get { return default(System.CodeDom.CodeTypeReference); } set { } }
    public System.CodeDom.CodeStatementCollection SetStatements { get { return default(System.CodeDom.CodeStatementCollection); } }
    public System.CodeDom.CodeTypeReference Type { get { return default(System.CodeDom.CodeTypeReference); } set { } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeMethodInvokeExpression : System.CodeDom.CodeExpression {
    public CodeMethodInvokeExpression() { }
    public CodeMethodInvokeExpression(System.CodeDom.CodeExpression targetObject, string methodName, params System.CodeDom.CodeExpression[] parameters) { }
    public CodeMethodInvokeExpression(System.CodeDom.CodeMethodReferenceExpression method, params System.CodeDom.CodeExpression[] parameters) { }
    public System.CodeDom.CodeMethodReferenceExpression Method { get { return default(System.CodeDom.CodeMethodReferenceExpression); } set { } }
    public System.CodeDom.CodeExpressionCollection Parameters { get { return default(System.CodeDom.CodeExpressionCollection); } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeMethodReferenceExpression : System.CodeDom.CodeExpression {
    public CodeMethodReferenceExpression() { }
    public CodeMethodReferenceExpression(System.CodeDom.CodeExpression targetObject, string methodName) { }
    public CodeMethodReferenceExpression(System.CodeDom.CodeExpression targetObject, string methodName, params System.CodeDom.CodeTypeReference[] typeParameters) { }
    public string MethodName { get { return default(string); } set { } }
    public System.CodeDom.CodeExpression TargetObject { get { return default(System.CodeDom.CodeExpression); } set { } }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public System.CodeDom.CodeTypeReferenceCollection TypeArguments { get { return default(System.CodeDom.CodeTypeReferenceCollection); } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeMethodReturnStatement : System.CodeDom.CodeStatement {
    public CodeMethodReturnStatement() { }
    public CodeMethodReturnStatement(System.CodeDom.CodeExpression expression) { }
    public System.CodeDom.CodeExpression Expression { get { return default(System.CodeDom.CodeExpression); } set { } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeNamespace : System.CodeDom.CodeObject {
    public CodeNamespace() { }
    public CodeNamespace(string name) { }
    public System.CodeDom.CodeCommentStatementCollection Comments { get { return default(System.CodeDom.CodeCommentStatementCollection); } }
    public System.CodeDom.CodeNamespaceImportCollection Imports { get { return default(System.CodeDom.CodeNamespaceImportCollection); } }
    public string Name { get { return default(string); } set { } }
    public System.CodeDom.CodeTypeDeclarationCollection Types { get { return default(System.CodeDom.CodeTypeDeclarationCollection); } }
    public event System.EventHandler PopulateComments { add { } remove { } }
    public event System.EventHandler PopulateImports { add { } remove { } }
    public event System.EventHandler PopulateTypes { add { } remove { } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeNamespaceCollection : System.Collections.CollectionBase {
    public CodeNamespaceCollection() { }
    public CodeNamespaceCollection(System.CodeDom.CodeNamespace[] value) { }
    public CodeNamespaceCollection(System.CodeDom.CodeNamespaceCollection value) { }
    public System.CodeDom.CodeNamespace this[int index] { get { return default(System.CodeDom.CodeNamespace); } set { } }
    public int Add(System.CodeDom.CodeNamespace value) { return default(int); }
    public void AddRange(System.CodeDom.CodeNamespace[] value) { }
    public void AddRange(System.CodeDom.CodeNamespaceCollection value) { }
    public bool Contains(System.CodeDom.CodeNamespace value) { return default(bool); }
    public void CopyTo(System.CodeDom.CodeNamespace[] array, int index) { }
    public int IndexOf(System.CodeDom.CodeNamespace value) { return default(int); }
    public void Insert(int index, System.CodeDom.CodeNamespace value) { }
    public void Remove(System.CodeDom.CodeNamespace value) { }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeNamespaceImport : System.CodeDom.CodeObject {
    public CodeNamespaceImport() { }
    public CodeNamespaceImport(string nameSpace) { }
    public System.CodeDom.CodeLinePragma LinePragma { get { return default(System.CodeDom.CodeLinePragma); } set { } }
    public string Namespace { get { return default(string); } set { } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeNamespaceImportCollection : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList {
    public CodeNamespaceImportCollection() { }
    public int Count { get { return default(int); } }
    public System.CodeDom.CodeNamespaceImport this[int index] { get { return default(System.CodeDom.CodeNamespaceImport); } set { } }
    int System.Collections.ICollection.Count { get { return default(int); } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    bool System.Collections.IList.IsFixedSize { get { return default(bool); } }
    bool System.Collections.IList.IsReadOnly { get { return default(bool); } }
    object System.Collections.IList.this[int index] { get { return default(object); } set { } }
    public void Add(System.CodeDom.CodeNamespaceImport value) { }
    public void AddRange(System.CodeDom.CodeNamespaceImport[] value) { }
    public void Clear() { }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    int System.Collections.IList.Add(object value) { return default(int); }
    void System.Collections.IList.Clear() { }
    bool System.Collections.IList.Contains(object value) { return default(bool); }
    int System.Collections.IList.IndexOf(object value) { return default(int); }
    void System.Collections.IList.Insert(int index, object value) { }
    void System.Collections.IList.Remove(object value) { }
    void System.Collections.IList.RemoveAt(int index) { }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeObject {
    public CodeObject() { }
    public System.Collections.IDictionary UserData { get { return default(System.Collections.IDictionary); } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeObjectCreateExpression : System.CodeDom.CodeExpression {
    public CodeObjectCreateExpression() { }
    public CodeObjectCreateExpression(System.CodeDom.CodeTypeReference createType, params System.CodeDom.CodeExpression[] parameters) { }
    public CodeObjectCreateExpression(string createType, params System.CodeDom.CodeExpression[] parameters) { }
    public CodeObjectCreateExpression(System.Type createType, params System.CodeDom.CodeExpression[] parameters) { }
    public System.CodeDom.CodeTypeReference CreateType { get { return default(System.CodeDom.CodeTypeReference); } set { } }
    public System.CodeDom.CodeExpressionCollection Parameters { get { return default(System.CodeDom.CodeExpressionCollection); } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeParameterDeclarationExpression : System.CodeDom.CodeExpression {
    public CodeParameterDeclarationExpression() { }
    public CodeParameterDeclarationExpression(System.CodeDom.CodeTypeReference type, string name) { }
    public CodeParameterDeclarationExpression(string type, string name) { }
    public CodeParameterDeclarationExpression(System.Type type, string name) { }
    public System.CodeDom.CodeAttributeDeclarationCollection CustomAttributes { get { return default(System.CodeDom.CodeAttributeDeclarationCollection); } set { } }
    public System.CodeDom.FieldDirection Direction { get { return default(System.CodeDom.FieldDirection); } set { } }
    public string Name { get { return default(string); } set { } }
    public System.CodeDom.CodeTypeReference Type { get { return default(System.CodeDom.CodeTypeReference); } set { } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeParameterDeclarationExpressionCollection : System.Collections.CollectionBase {
    public CodeParameterDeclarationExpressionCollection() { }
    public CodeParameterDeclarationExpressionCollection(System.CodeDom.CodeParameterDeclarationExpression[] value) { }
    public CodeParameterDeclarationExpressionCollection(System.CodeDom.CodeParameterDeclarationExpressionCollection value) { }
    public System.CodeDom.CodeParameterDeclarationExpression this[int index] { get { return default(System.CodeDom.CodeParameterDeclarationExpression); } set { } }
    public int Add(System.CodeDom.CodeParameterDeclarationExpression value) { return default(int); }
    public void AddRange(System.CodeDom.CodeParameterDeclarationExpression[] value) { }
    public void AddRange(System.CodeDom.CodeParameterDeclarationExpressionCollection value) { }
    public bool Contains(System.CodeDom.CodeParameterDeclarationExpression value) { return default(bool); }
    public void CopyTo(System.CodeDom.CodeParameterDeclarationExpression[] array, int index) { }
    public int IndexOf(System.CodeDom.CodeParameterDeclarationExpression value) { return default(int); }
    public void Insert(int index, System.CodeDom.CodeParameterDeclarationExpression value) { }
    public void Remove(System.CodeDom.CodeParameterDeclarationExpression value) { }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodePrimitiveExpression : System.CodeDom.CodeExpression {
    public CodePrimitiveExpression() { }
    public CodePrimitiveExpression(object value) { }
    public object Value { get { return default(object); } set { } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodePropertyReferenceExpression : System.CodeDom.CodeExpression {
    public CodePropertyReferenceExpression() { }
    public CodePropertyReferenceExpression(System.CodeDom.CodeExpression targetObject, string propertyName) { }
    public string PropertyName { get { return default(string); } set { } }
    public System.CodeDom.CodeExpression TargetObject { get { return default(System.CodeDom.CodeExpression); } set { } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodePropertySetValueReferenceExpression : System.CodeDom.CodeExpression {
    public CodePropertySetValueReferenceExpression() { }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeRegionDirective : System.CodeDom.CodeDirective {
    public CodeRegionDirective() { }
    public CodeRegionDirective(System.CodeDom.CodeRegionMode regionMode, string regionText) { }
    public System.CodeDom.CodeRegionMode RegionMode { get { return default(System.CodeDom.CodeRegionMode); } set { } }
    public string RegionText { get { return default(string); } set { } }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public enum CodeRegionMode {
    End = 2,
    None = 0,
    Start = 1,
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeRemoveEventStatement : System.CodeDom.CodeStatement {
    public CodeRemoveEventStatement() { }
    public CodeRemoveEventStatement(System.CodeDom.CodeEventReferenceExpression eventRef, System.CodeDom.CodeExpression listener) { }
    public CodeRemoveEventStatement(System.CodeDom.CodeExpression targetObject, string eventName, System.CodeDom.CodeExpression listener) { }
    public System.CodeDom.CodeEventReferenceExpression Event { get { return default(System.CodeDom.CodeEventReferenceExpression); } set { } }
    public System.CodeDom.CodeExpression Listener { get { return default(System.CodeDom.CodeExpression); } set { } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeSnippetCompileUnit : System.CodeDom.CodeCompileUnit {
    public CodeSnippetCompileUnit() { }
    public CodeSnippetCompileUnit(string value) { }
    public System.CodeDom.CodeLinePragma LinePragma { get { return default(System.CodeDom.CodeLinePragma); } set { } }
    public string Value { get { return default(string); } set { } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeSnippetExpression : System.CodeDom.CodeExpression {
    public CodeSnippetExpression() { }
    public CodeSnippetExpression(string value) { }
    public string Value { get { return default(string); } set { } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeSnippetStatement : System.CodeDom.CodeStatement {
    public CodeSnippetStatement() { }
    public CodeSnippetStatement(string value) { }
    public string Value { get { return default(string); } set { } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeSnippetTypeMember : System.CodeDom.CodeTypeMember {
    public CodeSnippetTypeMember() { }
    public CodeSnippetTypeMember(string text) { }
    public string Text { get { return default(string); } set { } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeStatement : System.CodeDom.CodeObject {
    public CodeStatement() { }
    public System.CodeDom.CodeDirectiveCollection EndDirectives { get { return default(System.CodeDom.CodeDirectiveCollection); } }
    public System.CodeDom.CodeLinePragma LinePragma { get { return default(System.CodeDom.CodeLinePragma); } set { } }
    public System.CodeDom.CodeDirectiveCollection StartDirectives { get { return default(System.CodeDom.CodeDirectiveCollection); } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeStatementCollection : System.Collections.CollectionBase {
    public CodeStatementCollection() { }
    public CodeStatementCollection(System.CodeDom.CodeStatement[] value) { }
    public CodeStatementCollection(System.CodeDom.CodeStatementCollection value) { }
    public System.CodeDom.CodeStatement this[int index] { get { return default(System.CodeDom.CodeStatement); } set { } }
    public int Add(System.CodeDom.CodeExpression value) { return default(int); }
    public int Add(System.CodeDom.CodeStatement value) { return default(int); }
    public void AddRange(System.CodeDom.CodeStatement[] value) { }
    public void AddRange(System.CodeDom.CodeStatementCollection value) { }
    public bool Contains(System.CodeDom.CodeStatement value) { return default(bool); }
    public void CopyTo(System.CodeDom.CodeStatement[] array, int index) { }
    public int IndexOf(System.CodeDom.CodeStatement value) { return default(int); }
    public void Insert(int index, System.CodeDom.CodeStatement value) { }
    public void Remove(System.CodeDom.CodeStatement value) { }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeThisReferenceExpression : System.CodeDom.CodeExpression {
    public CodeThisReferenceExpression() { }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeThrowExceptionStatement : System.CodeDom.CodeStatement {
    public CodeThrowExceptionStatement() { }
    public CodeThrowExceptionStatement(System.CodeDom.CodeExpression toThrow) { }
    public System.CodeDom.CodeExpression ToThrow { get { return default(System.CodeDom.CodeExpression); } set { } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeTryCatchFinallyStatement : System.CodeDom.CodeStatement {
    public CodeTryCatchFinallyStatement() { }
    public CodeTryCatchFinallyStatement(System.CodeDom.CodeStatement[] tryStatements, System.CodeDom.CodeCatchClause[] catchClauses) { }
    public CodeTryCatchFinallyStatement(System.CodeDom.CodeStatement[] tryStatements, System.CodeDom.CodeCatchClause[] catchClauses, System.CodeDom.CodeStatement[] finallyStatements) { }
    public System.CodeDom.CodeCatchClauseCollection CatchClauses { get { return default(System.CodeDom.CodeCatchClauseCollection); } }
    public System.CodeDom.CodeStatementCollection FinallyStatements { get { return default(System.CodeDom.CodeStatementCollection); } }
    public System.CodeDom.CodeStatementCollection TryStatements { get { return default(System.CodeDom.CodeStatementCollection); } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeTypeConstructor : System.CodeDom.CodeMemberMethod {
    public CodeTypeConstructor() { }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeTypeDeclaration : System.CodeDom.CodeTypeMember {
    public CodeTypeDeclaration() { }
    public CodeTypeDeclaration(string name) { }
    public System.CodeDom.CodeTypeReferenceCollection BaseTypes { get { return default(System.CodeDom.CodeTypeReferenceCollection); } }
    public bool IsClass { get { return default(bool); } set { } }
    public bool IsEnum { get { return default(bool); } set { } }
    public bool IsInterface { get { return default(bool); } set { } }
    public bool IsPartial { get { return default(bool); } set { } }
    public bool IsStruct { get { return default(bool); } set { } }
    public System.CodeDom.CodeTypeMemberCollection Members { get { return default(System.CodeDom.CodeTypeMemberCollection); } }
    public System.Reflection.TypeAttributes TypeAttributes { get { return default(System.Reflection.TypeAttributes); } set { } }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public System.CodeDom.CodeTypeParameterCollection TypeParameters { get { return default(System.CodeDom.CodeTypeParameterCollection); } }
    public event System.EventHandler PopulateBaseTypes { add { } remove { } }
    public event System.EventHandler PopulateMembers { add { } remove { } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeTypeDeclarationCollection : System.Collections.CollectionBase {
    public CodeTypeDeclarationCollection() { }
    public CodeTypeDeclarationCollection(System.CodeDom.CodeTypeDeclaration[] value) { }
    public CodeTypeDeclarationCollection(System.CodeDom.CodeTypeDeclarationCollection value) { }
    public System.CodeDom.CodeTypeDeclaration this[int index] { get { return default(System.CodeDom.CodeTypeDeclaration); } set { } }
    public int Add(System.CodeDom.CodeTypeDeclaration value) { return default(int); }
    public void AddRange(System.CodeDom.CodeTypeDeclaration[] value) { }
    public void AddRange(System.CodeDom.CodeTypeDeclarationCollection value) { }
    public bool Contains(System.CodeDom.CodeTypeDeclaration value) { return default(bool); }
    public void CopyTo(System.CodeDom.CodeTypeDeclaration[] array, int index) { }
    public int IndexOf(System.CodeDom.CodeTypeDeclaration value) { return default(int); }
    public void Insert(int index, System.CodeDom.CodeTypeDeclaration value) { }
    public void Remove(System.CodeDom.CodeTypeDeclaration value) { }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeTypeDelegate : System.CodeDom.CodeTypeDeclaration {
    public CodeTypeDelegate() { }
    public CodeTypeDelegate(string name) { }
    public System.CodeDom.CodeParameterDeclarationExpressionCollection Parameters { get { return default(System.CodeDom.CodeParameterDeclarationExpressionCollection); } }
    public System.CodeDom.CodeTypeReference ReturnType { get { return default(System.CodeDom.CodeTypeReference); } set { } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeTypeMember : System.CodeDom.CodeObject {
    public CodeTypeMember() { }
    public System.CodeDom.MemberAttributes Attributes { get { return default(System.CodeDom.MemberAttributes); } set { } }
    public System.CodeDom.CodeCommentStatementCollection Comments { get { return default(System.CodeDom.CodeCommentStatementCollection); } }
    public System.CodeDom.CodeAttributeDeclarationCollection CustomAttributes { get { return default(System.CodeDom.CodeAttributeDeclarationCollection); } set { } }
    public System.CodeDom.CodeDirectiveCollection EndDirectives { get { return default(System.CodeDom.CodeDirectiveCollection); } }
    public System.CodeDom.CodeLinePragma LinePragma { get { return default(System.CodeDom.CodeLinePragma); } set { } }
    public string Name { get { return default(string); } set { } }
    public System.CodeDom.CodeDirectiveCollection StartDirectives { get { return default(System.CodeDom.CodeDirectiveCollection); } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeTypeMemberCollection : System.Collections.CollectionBase {
    public CodeTypeMemberCollection() { }
    public CodeTypeMemberCollection(System.CodeDom.CodeTypeMember[] value) { }
    public CodeTypeMemberCollection(System.CodeDom.CodeTypeMemberCollection value) { }
    public System.CodeDom.CodeTypeMember this[int index] { get { return default(System.CodeDom.CodeTypeMember); } set { } }
    public int Add(System.CodeDom.CodeTypeMember value) { return default(int); }
    public void AddRange(System.CodeDom.CodeTypeMember[] value) { }
    public void AddRange(System.CodeDom.CodeTypeMemberCollection value) { }
    public bool Contains(System.CodeDom.CodeTypeMember value) { return default(bool); }
    public void CopyTo(System.CodeDom.CodeTypeMember[] array, int index) { }
    public int IndexOf(System.CodeDom.CodeTypeMember value) { return default(int); }
    public void Insert(int index, System.CodeDom.CodeTypeMember value) { }
    public void Remove(System.CodeDom.CodeTypeMember value) { }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeTypeOfExpression : System.CodeDom.CodeExpression {
    public CodeTypeOfExpression() { }
    public CodeTypeOfExpression(System.CodeDom.CodeTypeReference type) { }
    public CodeTypeOfExpression(string type) { }
    public CodeTypeOfExpression(System.Type type) { }
    public System.CodeDom.CodeTypeReference Type { get { return default(System.CodeDom.CodeTypeReference); } set { } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeTypeParameter : System.CodeDom.CodeObject {
    public CodeTypeParameter() { }
    public CodeTypeParameter(string name) { }
    public System.CodeDom.CodeTypeReferenceCollection Constraints { get { return default(System.CodeDom.CodeTypeReferenceCollection); } }
    public System.CodeDom.CodeAttributeDeclarationCollection CustomAttributes { get { return default(System.CodeDom.CodeAttributeDeclarationCollection); } }
    public bool HasConstructorConstraint { get { return default(bool); } set { } }
    public string Name { get { return default(string); } set { } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeTypeParameterCollection : System.Collections.CollectionBase {
    public CodeTypeParameterCollection() { }
    public CodeTypeParameterCollection(System.CodeDom.CodeTypeParameter[] value) { }
    public CodeTypeParameterCollection(System.CodeDom.CodeTypeParameterCollection value) { }
    public System.CodeDom.CodeTypeParameter this[int index] { get { return default(System.CodeDom.CodeTypeParameter); } set { } }
    public int Add(System.CodeDom.CodeTypeParameter value) { return default(int); }
    public void Add(string value) { }
    public void AddRange(System.CodeDom.CodeTypeParameter[] value) { }
    public void AddRange(System.CodeDom.CodeTypeParameterCollection value) { }
    public bool Contains(System.CodeDom.CodeTypeParameter value) { return default(bool); }
    public void CopyTo(System.CodeDom.CodeTypeParameter[] array, int index) { }
    public int IndexOf(System.CodeDom.CodeTypeParameter value) { return default(int); }
    public void Insert(int index, System.CodeDom.CodeTypeParameter value) { }
    public void Remove(System.CodeDom.CodeTypeParameter value) { }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeTypeReference : System.CodeDom.CodeObject {
    public CodeTypeReference() { }
    public CodeTypeReference(System.CodeDom.CodeTypeParameter typeParameter) { }
    public CodeTypeReference(System.CodeDom.CodeTypeReference arrayElementType, int arrayRank) { }
    [System.MonoTODOAttribute("We should parse basetype from right to left in 2.0 profile.")]
    public CodeTypeReference(string baseType) { }
    public CodeTypeReference(string typeName, params System.CodeDom.CodeTypeReference[] typeArguments) { }
    public CodeTypeReference(string typeName, System.CodeDom.CodeTypeReferenceOptions referenceOptions) { }
    [System.MonoTODOAttribute("We should parse basetype from right to left in 2.0 profile.")]
    public CodeTypeReference(string baseType, int arrayRank) { }
    [System.MonoTODOAttribute("We should parse basetype from right to left in 2.0 profile.")]
    public CodeTypeReference(System.Type baseType) { }
    public CodeTypeReference(System.Type type, System.CodeDom.CodeTypeReferenceOptions referenceOptions) { }
    public System.CodeDom.CodeTypeReference ArrayElementType { get { return default(System.CodeDom.CodeTypeReference); } set { } }
    public int ArrayRank { get { return default(int); } set { } }
    public string BaseType { get { return default(string); } set { } }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public System.CodeDom.CodeTypeReferenceOptions Options { get { return default(System.CodeDom.CodeTypeReferenceOptions); } set { } }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public System.CodeDom.CodeTypeReferenceCollection TypeArguments { get { return default(System.CodeDom.CodeTypeReferenceCollection); } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeTypeReferenceCollection : System.Collections.CollectionBase {
    public CodeTypeReferenceCollection() { }
    public CodeTypeReferenceCollection(System.CodeDom.CodeTypeReference[] value) { }
    public CodeTypeReferenceCollection(System.CodeDom.CodeTypeReferenceCollection value) { }
    public System.CodeDom.CodeTypeReference this[int index] { get { return default(System.CodeDom.CodeTypeReference); } set { } }
    public int Add(System.CodeDom.CodeTypeReference value) { return default(int); }
    public void Add(string value) { }
    public void Add(System.Type value) { }
    public void AddRange(System.CodeDom.CodeTypeReference[] value) { }
    public void AddRange(System.CodeDom.CodeTypeReferenceCollection value) { }
    public bool Contains(System.CodeDom.CodeTypeReference value) { return default(bool); }
    public void CopyTo(System.CodeDom.CodeTypeReference[] array, int index) { }
    public int IndexOf(System.CodeDom.CodeTypeReference value) { return default(int); }
    public void Insert(int index, System.CodeDom.CodeTypeReference value) { }
    public void Remove(System.CodeDom.CodeTypeReference value) { }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeTypeReferenceExpression : System.CodeDom.CodeExpression {
    public CodeTypeReferenceExpression() { }
    public CodeTypeReferenceExpression(System.CodeDom.CodeTypeReference type) { }
    public CodeTypeReferenceExpression(string type) { }
    public CodeTypeReferenceExpression(System.Type type) { }
    public System.CodeDom.CodeTypeReference Type { get { return default(System.CodeDom.CodeTypeReference); } set { } }
  }
  [System.FlagsAttribute]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public enum CodeTypeReferenceOptions {
    GenericTypeParameter = 2,
    GlobalReference = 1,
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeVariableDeclarationStatement : System.CodeDom.CodeStatement {
    public CodeVariableDeclarationStatement() { }
    public CodeVariableDeclarationStatement(System.CodeDom.CodeTypeReference type, string name) { }
    public CodeVariableDeclarationStatement(System.CodeDom.CodeTypeReference type, string name, System.CodeDom.CodeExpression initExpression) { }
    public CodeVariableDeclarationStatement(string type, string name) { }
    public CodeVariableDeclarationStatement(string type, string name, System.CodeDom.CodeExpression initExpression) { }
    public CodeVariableDeclarationStatement(System.Type type, string name) { }
    public CodeVariableDeclarationStatement(System.Type type, string name, System.CodeDom.CodeExpression initExpression) { }
    public System.CodeDom.CodeExpression InitExpression { get { return default(System.CodeDom.CodeExpression); } set { } }
    public string Name { get { return default(string); } set { } }
    public System.CodeDom.CodeTypeReference Type { get { return default(System.CodeDom.CodeTypeReference); } set { } }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeVariableReferenceExpression : System.CodeDom.CodeExpression {
    public CodeVariableReferenceExpression() { }
    public CodeVariableReferenceExpression(string variableName) { }
    public string VariableName { get { return default(string); } set { } }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public enum FieldDirection {
    In = 0,
    Out = 1,
    Ref = 2,
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public enum MemberAttributes {
    Abstract = 1,
    AccessMask = 61440,
    Assembly = 4096,
    Const = 5,
    Family = 12288,
    FamilyAndAssembly = 8192,
    FamilyOrAssembly = 16384,
    Final = 2,
    New = 16,
    Overloaded = 256,
    Override = 4,
    Private = 20480,
    Public = 24576,
    ScopeMask = 15,
    Static = 3,
    VTableMask = 240,
  }
}
namespace System.CodeDom.Compiler {
  public abstract partial class CodeCompiler : System.CodeDom.Compiler.CodeGenerator, System.CodeDom.Compiler.ICodeCompiler {
    protected CodeCompiler() { }
    protected abstract string CompilerName { get; }
    protected abstract string FileExtension { get; }
    protected abstract string CmdArgsFromParameters(System.CodeDom.Compiler.CompilerParameters options);
    protected virtual System.CodeDom.Compiler.CompilerResults FromDom(System.CodeDom.Compiler.CompilerParameters options, System.CodeDom.CodeCompileUnit e) { return default(System.CodeDom.Compiler.CompilerResults); }
    protected virtual System.CodeDom.Compiler.CompilerResults FromDomBatch(System.CodeDom.Compiler.CompilerParameters options, System.CodeDom.CodeCompileUnit[] ea) { return default(System.CodeDom.Compiler.CompilerResults); }
    protected virtual System.CodeDom.Compiler.CompilerResults FromFile(System.CodeDom.Compiler.CompilerParameters options, string fileName) { return default(System.CodeDom.Compiler.CompilerResults); }
    protected virtual System.CodeDom.Compiler.CompilerResults FromFileBatch(System.CodeDom.Compiler.CompilerParameters options, System.String[] fileNames) { return default(System.CodeDom.Compiler.CompilerResults); }
    protected virtual System.CodeDom.Compiler.CompilerResults FromSource(System.CodeDom.Compiler.CompilerParameters options, string source) { return default(System.CodeDom.Compiler.CompilerResults); }
    protected virtual System.CodeDom.Compiler.CompilerResults FromSourceBatch(System.CodeDom.Compiler.CompilerParameters options, System.String[] sources) { return default(System.CodeDom.Compiler.CompilerResults); }
    [System.MonoTODOAttribute]
    protected virtual string GetResponseFileCmdArgs(System.CodeDom.Compiler.CompilerParameters options, string cmdArgs) { return default(string); }
    protected static string JoinStringArray(System.String[] sa, string separator) { return default(string); }
    protected abstract void ProcessCompilerOutputLine(System.CodeDom.Compiler.CompilerResults results, string line);
    System.CodeDom.Compiler.CompilerResults System.CodeDom.Compiler.ICodeCompiler.CompileAssemblyFromDom(System.CodeDom.Compiler.CompilerParameters options, System.CodeDom.CodeCompileUnit e) { return default(System.CodeDom.Compiler.CompilerResults); }
    System.CodeDom.Compiler.CompilerResults System.CodeDom.Compiler.ICodeCompiler.CompileAssemblyFromDomBatch(System.CodeDom.Compiler.CompilerParameters options, System.CodeDom.CodeCompileUnit[] ea) { return default(System.CodeDom.Compiler.CompilerResults); }
    System.CodeDom.Compiler.CompilerResults System.CodeDom.Compiler.ICodeCompiler.CompileAssemblyFromFile(System.CodeDom.Compiler.CompilerParameters options, string fileName) { return default(System.CodeDom.Compiler.CompilerResults); }
    System.CodeDom.Compiler.CompilerResults System.CodeDom.Compiler.ICodeCompiler.CompileAssemblyFromFileBatch(System.CodeDom.Compiler.CompilerParameters options, System.String[] fileNames) { return default(System.CodeDom.Compiler.CompilerResults); }
    System.CodeDom.Compiler.CompilerResults System.CodeDom.Compiler.ICodeCompiler.CompileAssemblyFromSource(System.CodeDom.Compiler.CompilerParameters options, string source) { return default(System.CodeDom.Compiler.CompilerResults); }
    System.CodeDom.Compiler.CompilerResults System.CodeDom.Compiler.ICodeCompiler.CompileAssemblyFromSourceBatch(System.CodeDom.Compiler.CompilerParameters options, System.String[] sources) { return default(System.CodeDom.Compiler.CompilerResults); }
  }
  [System.ComponentModel.ToolboxItemAttribute(false)]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public abstract partial class CodeDomProvider : System.ComponentModel.Component {
    protected CodeDomProvider() { }
    public virtual string FileExtension { get { return default(string); } }
    public virtual System.CodeDom.Compiler.LanguageOptions LanguageOptions { get { return default(System.CodeDom.Compiler.LanguageOptions); } }
    public virtual System.CodeDom.Compiler.CompilerResults CompileAssemblyFromDom(System.CodeDom.Compiler.CompilerParameters options, params System.CodeDom.CodeCompileUnit[] compilationUnits) { return default(System.CodeDom.Compiler.CompilerResults); }
    public virtual System.CodeDom.Compiler.CompilerResults CompileAssemblyFromFile(System.CodeDom.Compiler.CompilerParameters options, params System.String[] fileNames) { return default(System.CodeDom.Compiler.CompilerResults); }
    public virtual System.CodeDom.Compiler.CompilerResults CompileAssemblyFromSource(System.CodeDom.Compiler.CompilerParameters options, params System.String[] sources) { return default(System.CodeDom.Compiler.CompilerResults); }
    [System.ObsoleteAttribute("ICodeCompiler is obsolete")]
    public abstract System.CodeDom.Compiler.ICodeCompiler CreateCompiler();
    public virtual string CreateEscapedIdentifier(string value) { return default(string); }
    [System.ObsoleteAttribute("ICodeGenerator is obsolete")]
    public abstract System.CodeDom.Compiler.ICodeGenerator CreateGenerator();
    public virtual System.CodeDom.Compiler.ICodeGenerator CreateGenerator(System.IO.TextWriter output) { return default(System.CodeDom.Compiler.ICodeGenerator); }
    public virtual System.CodeDom.Compiler.ICodeGenerator CreateGenerator(string fileName) { return default(System.CodeDom.Compiler.ICodeGenerator); }
    [System.ObsoleteAttribute("ICodeParser is obsolete")]
    public virtual System.CodeDom.Compiler.ICodeParser CreateParser() { return default(System.CodeDom.Compiler.ICodeParser); }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
    public static System.CodeDom.Compiler.CodeDomProvider CreateProvider(string language) { return default(System.CodeDom.Compiler.CodeDomProvider); }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public static System.CodeDom.Compiler.CodeDomProvider CreateProvider(string language, System.Collections.Generic.IDictionary<System.String, System.String> providerOptions) { return default(System.CodeDom.Compiler.CodeDomProvider); }
    public virtual string CreateValidIdentifier(string value) { return default(string); }
    public virtual void GenerateCodeFromCompileUnit(System.CodeDom.CodeCompileUnit compileUnit, System.IO.TextWriter writer, System.CodeDom.Compiler.CodeGeneratorOptions options) { }
    public virtual void GenerateCodeFromExpression(System.CodeDom.CodeExpression expression, System.IO.TextWriter writer, System.CodeDom.Compiler.CodeGeneratorOptions options) { }
    public virtual void GenerateCodeFromMember(System.CodeDom.CodeTypeMember member, System.IO.TextWriter writer, System.CodeDom.Compiler.CodeGeneratorOptions options) { }
    public virtual void GenerateCodeFromNamespace(System.CodeDom.CodeNamespace codeNamespace, System.IO.TextWriter writer, System.CodeDom.Compiler.CodeGeneratorOptions options) { }
    public virtual void GenerateCodeFromStatement(System.CodeDom.CodeStatement statement, System.IO.TextWriter writer, System.CodeDom.Compiler.CodeGeneratorOptions options) { }
    public virtual void GenerateCodeFromType(System.CodeDom.CodeTypeDeclaration codeType, System.IO.TextWriter writer, System.CodeDom.Compiler.CodeGeneratorOptions options) { }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
    public static System.CodeDom.Compiler.CompilerInfo[] GetAllCompilerInfo() { return default(System.CodeDom.Compiler.CompilerInfo[]); }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
    public static System.CodeDom.Compiler.CompilerInfo GetCompilerInfo(string language) { return default(System.CodeDom.Compiler.CompilerInfo); }
    public virtual System.ComponentModel.TypeConverter GetConverter(System.Type type) { return default(System.ComponentModel.TypeConverter); }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
    public static string GetLanguageFromExtension(string extension) { return default(string); }
    public virtual string GetTypeOutput(System.CodeDom.CodeTypeReference type) { return default(string); }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
    public static bool IsDefinedExtension(string extension) { return default(bool); }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
    public static bool IsDefinedLanguage(string language) { return default(bool); }
    public virtual bool IsValidIdentifier(string value) { return default(bool); }
    public virtual System.CodeDom.CodeCompileUnit Parse(System.IO.TextReader codeStream) { return default(System.CodeDom.CodeCompileUnit); }
    public virtual bool Supports(System.CodeDom.Compiler.GeneratorSupport supports) { return default(bool); }
  }
  public abstract partial class CodeGenerator : System.CodeDom.Compiler.ICodeGenerator {
    protected CodeGenerator() { }
    protected System.CodeDom.CodeTypeDeclaration CurrentClass { get { return default(System.CodeDom.CodeTypeDeclaration); } }
    protected System.CodeDom.CodeTypeMember CurrentMember { get { return default(System.CodeDom.CodeTypeMember); } }
    protected string CurrentMemberName { get { return default(string); } }
    protected string CurrentTypeName { get { return default(string); } }
    protected int Indent { get { return default(int); } set { } }
    protected bool IsCurrentClass { get { return default(bool); } }
    protected bool IsCurrentDelegate { get { return default(bool); } }
    protected bool IsCurrentEnum { get { return default(bool); } }
    protected bool IsCurrentInterface { get { return default(bool); } }
    protected bool IsCurrentStruct { get { return default(bool); } }
    protected abstract string NullToken { get; }
    protected System.CodeDom.Compiler.CodeGeneratorOptions Options { get { return default(System.CodeDom.Compiler.CodeGeneratorOptions); } }
    protected System.IO.TextWriter Output { get { return default(System.IO.TextWriter); } }
    protected virtual void ContinueOnNewLine(string st) { }
    protected abstract string CreateEscapedIdentifier(string value);
    protected abstract string CreateValidIdentifier(string value);
    protected abstract void GenerateArgumentReferenceExpression(System.CodeDom.CodeArgumentReferenceExpression e);
    protected abstract void GenerateArrayCreateExpression(System.CodeDom.CodeArrayCreateExpression e);
    protected abstract void GenerateArrayIndexerExpression(System.CodeDom.CodeArrayIndexerExpression e);
    protected abstract void GenerateAssignStatement(System.CodeDom.CodeAssignStatement s);
    protected abstract void GenerateAttachEventStatement(System.CodeDom.CodeAttachEventStatement s);
    protected abstract void GenerateAttributeDeclarationsEnd(System.CodeDom.CodeAttributeDeclarationCollection attributes);
    protected abstract void GenerateAttributeDeclarationsStart(System.CodeDom.CodeAttributeDeclarationCollection attributes);
    protected abstract void GenerateBaseReferenceExpression(System.CodeDom.CodeBaseReferenceExpression e);
    protected virtual void GenerateBinaryOperatorExpression(System.CodeDom.CodeBinaryOperatorExpression e) { }
    protected abstract void GenerateCastExpression(System.CodeDom.CodeCastExpression e);
    [System.MonoTODOAttribute]
    public virtual void GenerateCodeFromMember(System.CodeDom.CodeTypeMember member, System.IO.TextWriter writer, System.CodeDom.Compiler.CodeGeneratorOptions options) { }
    protected abstract void GenerateComment(System.CodeDom.CodeComment comment);
    protected virtual void GenerateCommentStatement(System.CodeDom.CodeCommentStatement statement) { }
    protected virtual void GenerateCommentStatements(System.CodeDom.CodeCommentStatementCollection statements) { }
    protected virtual void GenerateCompileUnit(System.CodeDom.CodeCompileUnit compileUnit) { }
    protected virtual void GenerateCompileUnitEnd(System.CodeDom.CodeCompileUnit compileUnit) { }
    protected virtual void GenerateCompileUnitStart(System.CodeDom.CodeCompileUnit compileUnit) { }
    protected abstract void GenerateConditionStatement(System.CodeDom.CodeConditionStatement s);
    protected abstract void GenerateConstructor(System.CodeDom.CodeConstructor x, System.CodeDom.CodeTypeDeclaration d);
    protected virtual void GenerateDecimalValue(decimal d) { }
    [System.MonoTODOAttribute]
    protected virtual void GenerateDefaultValueExpression(System.CodeDom.CodeDefaultValueExpression e) { }
    protected abstract void GenerateDelegateCreateExpression(System.CodeDom.CodeDelegateCreateExpression e);
    protected abstract void GenerateDelegateInvokeExpression(System.CodeDom.CodeDelegateInvokeExpression e);
    protected virtual void GenerateDirectionExpression(System.CodeDom.CodeDirectionExpression e) { }
    protected virtual void GenerateDirectives(System.CodeDom.CodeDirectiveCollection directives) { }
    protected virtual void GenerateDoubleValue(double d) { }
    protected abstract void GenerateEntryPointMethod(System.CodeDom.CodeEntryPointMethod m, System.CodeDom.CodeTypeDeclaration d);
    protected abstract void GenerateEvent(System.CodeDom.CodeMemberEvent ev, System.CodeDom.CodeTypeDeclaration d);
    protected abstract void GenerateEventReferenceExpression(System.CodeDom.CodeEventReferenceExpression e);
    protected void GenerateExpression(System.CodeDom.CodeExpression e) { }
    protected abstract void GenerateExpressionStatement(System.CodeDom.CodeExpressionStatement statement);
    protected abstract void GenerateField(System.CodeDom.CodeMemberField f);
    protected abstract void GenerateFieldReferenceExpression(System.CodeDom.CodeFieldReferenceExpression e);
    protected abstract void GenerateGotoStatement(System.CodeDom.CodeGotoStatement statement);
    protected abstract void GenerateIndexerExpression(System.CodeDom.CodeIndexerExpression e);
    protected abstract void GenerateIterationStatement(System.CodeDom.CodeIterationStatement s);
    protected abstract void GenerateLabeledStatement(System.CodeDom.CodeLabeledStatement statement);
    protected abstract void GenerateLinePragmaEnd(System.CodeDom.CodeLinePragma p);
    protected abstract void GenerateLinePragmaStart(System.CodeDom.CodeLinePragma p);
    protected abstract void GenerateMethod(System.CodeDom.CodeMemberMethod m, System.CodeDom.CodeTypeDeclaration d);
    protected abstract void GenerateMethodInvokeExpression(System.CodeDom.CodeMethodInvokeExpression e);
    protected abstract void GenerateMethodReferenceExpression(System.CodeDom.CodeMethodReferenceExpression e);
    protected abstract void GenerateMethodReturnStatement(System.CodeDom.CodeMethodReturnStatement e);
    protected virtual void GenerateNamespace(System.CodeDom.CodeNamespace ns) { }
    protected abstract void GenerateNamespaceEnd(System.CodeDom.CodeNamespace ns);
    protected abstract void GenerateNamespaceImport(System.CodeDom.CodeNamespaceImport i);
    protected void GenerateNamespaceImports(System.CodeDom.CodeNamespace e) { }
    protected void GenerateNamespaces(System.CodeDom.CodeCompileUnit e) { }
    protected abstract void GenerateNamespaceStart(System.CodeDom.CodeNamespace ns);
    protected abstract void GenerateObjectCreateExpression(System.CodeDom.CodeObjectCreateExpression e);
    protected virtual void GenerateParameterDeclarationExpression(System.CodeDom.CodeParameterDeclarationExpression e) { }
    protected virtual void GeneratePrimitiveExpression(System.CodeDom.CodePrimitiveExpression e) { }
    protected abstract void GenerateProperty(System.CodeDom.CodeMemberProperty p, System.CodeDom.CodeTypeDeclaration d);
    protected abstract void GeneratePropertyReferenceExpression(System.CodeDom.CodePropertyReferenceExpression e);
    protected abstract void GeneratePropertySetValueReferenceExpression(System.CodeDom.CodePropertySetValueReferenceExpression e);
    protected abstract void GenerateRemoveEventStatement(System.CodeDom.CodeRemoveEventStatement statement);
    protected virtual void GenerateSingleFloatValue(float s) { }
    protected virtual void GenerateSnippetCompileUnit(System.CodeDom.CodeSnippetCompileUnit e) { }
    protected abstract void GenerateSnippetExpression(System.CodeDom.CodeSnippetExpression e);
    protected abstract void GenerateSnippetMember(System.CodeDom.CodeSnippetTypeMember m);
    protected virtual void GenerateSnippetStatement(System.CodeDom.CodeSnippetStatement s) { }
    protected void GenerateStatement(System.CodeDom.CodeStatement s) { }
    protected void GenerateStatements(System.CodeDom.CodeStatementCollection c) { }
    protected abstract void GenerateThisReferenceExpression(System.CodeDom.CodeThisReferenceExpression e);
    protected abstract void GenerateThrowExceptionStatement(System.CodeDom.CodeThrowExceptionStatement s);
    protected abstract void GenerateTryCatchFinallyStatement(System.CodeDom.CodeTryCatchFinallyStatement s);
    protected abstract void GenerateTypeConstructor(System.CodeDom.CodeTypeConstructor constructor);
    protected abstract void GenerateTypeEnd(System.CodeDom.CodeTypeDeclaration declaration);
    protected virtual void GenerateTypeOfExpression(System.CodeDom.CodeTypeOfExpression e) { }
    protected virtual void GenerateTypeReferenceExpression(System.CodeDom.CodeTypeReferenceExpression e) { }
    protected void GenerateTypes(System.CodeDom.CodeNamespace e) { }
    protected abstract void GenerateTypeStart(System.CodeDom.CodeTypeDeclaration declaration);
    protected abstract void GenerateVariableDeclarationStatement(System.CodeDom.CodeVariableDeclarationStatement e);
    protected abstract void GenerateVariableReferenceExpression(System.CodeDom.CodeVariableReferenceExpression e);
    protected abstract string GetTypeOutput(System.CodeDom.CodeTypeReference type);
    protected abstract bool IsValidIdentifier(string value);
    public static bool IsValidLanguageIndependentIdentifier(string value) { return default(bool); }
    protected virtual void OutputAttributeArgument(System.CodeDom.CodeAttributeArgument argument) { }
    protected virtual void OutputAttributeDeclarations(System.CodeDom.CodeAttributeDeclarationCollection attributes) { }
    protected virtual void OutputDirection(System.CodeDom.FieldDirection direction) { }
    protected virtual void OutputExpressionList(System.CodeDom.CodeExpressionCollection expressions) { }
    protected virtual void OutputExpressionList(System.CodeDom.CodeExpressionCollection expressions, bool newLineBetweenItems) { }
    protected virtual void OutputFieldScopeModifier(System.CodeDom.MemberAttributes attributes) { }
    protected virtual void OutputIdentifier(string ident) { }
    protected virtual void OutputMemberAccessModifier(System.CodeDom.MemberAttributes attributes) { }
    protected virtual void OutputMemberScopeModifier(System.CodeDom.MemberAttributes attributes) { }
    protected virtual void OutputOperator(System.CodeDom.CodeBinaryOperatorType op) { }
    protected virtual void OutputParameters(System.CodeDom.CodeParameterDeclarationExpressionCollection parameters) { }
    protected abstract void OutputType(System.CodeDom.CodeTypeReference t);
    protected virtual void OutputTypeAttributes(System.Reflection.TypeAttributes attributes, bool isStruct, bool isEnum) { }
    protected virtual void OutputTypeNamePair(System.CodeDom.CodeTypeReference type, string name) { }
    protected abstract string QuoteSnippetString(string value);
    protected abstract bool Supports(System.CodeDom.Compiler.GeneratorSupport supports);
    string System.CodeDom.Compiler.ICodeGenerator.CreateEscapedIdentifier(string value) { return default(string); }
    string System.CodeDom.Compiler.ICodeGenerator.CreateValidIdentifier(string value) { return default(string); }
    void System.CodeDom.Compiler.ICodeGenerator.GenerateCodeFromCompileUnit(System.CodeDom.CodeCompileUnit compileUnit, System.IO.TextWriter output, System.CodeDom.Compiler.CodeGeneratorOptions options) { }
    void System.CodeDom.Compiler.ICodeGenerator.GenerateCodeFromExpression(System.CodeDom.CodeExpression expression, System.IO.TextWriter output, System.CodeDom.Compiler.CodeGeneratorOptions options) { }
    void System.CodeDom.Compiler.ICodeGenerator.GenerateCodeFromNamespace(System.CodeDom.CodeNamespace ns, System.IO.TextWriter output, System.CodeDom.Compiler.CodeGeneratorOptions options) { }
    void System.CodeDom.Compiler.ICodeGenerator.GenerateCodeFromStatement(System.CodeDom.CodeStatement statement, System.IO.TextWriter output, System.CodeDom.Compiler.CodeGeneratorOptions options) { }
    void System.CodeDom.Compiler.ICodeGenerator.GenerateCodeFromType(System.CodeDom.CodeTypeDeclaration type, System.IO.TextWriter output, System.CodeDom.Compiler.CodeGeneratorOptions options) { }
    string System.CodeDom.Compiler.ICodeGenerator.GetTypeOutput(System.CodeDom.CodeTypeReference type) { return default(string); }
    bool System.CodeDom.Compiler.ICodeGenerator.IsValidIdentifier(string value) { return default(bool); }
    bool System.CodeDom.Compiler.ICodeGenerator.Supports(System.CodeDom.Compiler.GeneratorSupport value) { return default(bool); }
    void System.CodeDom.Compiler.ICodeGenerator.ValidateIdentifier(string value) { }
    protected virtual void ValidateIdentifier(string value) { }
    [System.MonoTODOAttribute]
    public static void ValidateIdentifiers(System.CodeDom.CodeObject e) { }
  }
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
  public partial class CodeGeneratorOptions {
    public CodeGeneratorOptions() { }
    public bool BlankLinesBetweenMembers { get { return default(bool); } set { } }
    public string BracingStyle { get { return default(string); } set { } }
    public bool ElseOnClosing { get { return default(bool); } set { } }
    public string IndentString { get { return default(string); } set { } }
    public object this[string index] { get { return default(object); } set { } }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public bool VerbatimOrder { get { return default(bool); } set { } }
  }
  public abstract partial class CodeParser : System.CodeDom.Compiler.ICodeParser {
    protected CodeParser() { }
    public abstract System.CodeDom.CodeCompileUnit Parse(System.IO.TextReader codeStream);
  }
  public partial class CompilerError {
    public CompilerError() { }
    public CompilerError(string fileName, int line, int column, string errorNumber, string errorText) { }
    public int Column { get { return default(int); } set { } }
    public string ErrorNumber { get { return default(string); } set { } }
    public string ErrorText { get { return default(string); } set { } }
    public string FileName { get { return default(string); } set { } }
    public bool IsWarning { get { return default(bool); } set { } }
    public int Line { get { return default(int); } set { } }
    public override string ToString() { return default(string); }
  }
  public partial class CompilerErrorCollection : System.Collections.CollectionBase {
    public CompilerErrorCollection() { }
    public CompilerErrorCollection(System.CodeDom.Compiler.CompilerError[] value) { }
    public CompilerErrorCollection(System.CodeDom.Compiler.CompilerErrorCollection value) { }
    public bool HasErrors { get { return default(bool); } }
    public bool HasWarnings { get { return default(bool); } }
    public System.CodeDom.Compiler.CompilerError this[int index] { get { return default(System.CodeDom.Compiler.CompilerError); } set { } }
    public int Add(System.CodeDom.Compiler.CompilerError value) { return default(int); }
    public void AddRange(System.CodeDom.Compiler.CompilerError[] value) { }
    public void AddRange(System.CodeDom.Compiler.CompilerErrorCollection value) { }
    public bool Contains(System.CodeDom.Compiler.CompilerError value) { return default(bool); }
    public void CopyTo(System.CodeDom.Compiler.CompilerError[] array, int index) { }
    public int IndexOf(System.CodeDom.Compiler.CompilerError value) { return default(int); }
    public void Insert(int index, System.CodeDom.Compiler.CompilerError value) { }
    public void Remove(System.CodeDom.Compiler.CompilerError value) { }
  }
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
  public sealed partial class CompilerInfo {
    internal CompilerInfo() { }
    public System.Type CodeDomProviderType { get { return default(System.Type); } }
    public bool IsCodeDomProviderTypeValid { get { return default(bool); } }
    public System.CodeDom.Compiler.CompilerParameters CreateDefaultCompilerParameters() { return default(System.CodeDom.Compiler.CompilerParameters); }
    public System.CodeDom.Compiler.CodeDomProvider CreateProvider() { return default(System.CodeDom.Compiler.CodeDomProvider); }
    public System.CodeDom.Compiler.CodeDomProvider CreateProvider(System.Collections.Generic.IDictionary<System.String, System.String> providerOptions) { return default(System.CodeDom.Compiler.CodeDomProvider); }
    public override bool Equals(object o) { return default(bool); }
    public System.String[] GetExtensions() { return default(System.String[]); }
    public override int GetHashCode() { return default(int); }
    public System.String[] GetLanguages() { return default(System.String[]); }
  }
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Unrestricted=true)]
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
  public partial class CompilerParameters {
    public CompilerParameters() { }
    public CompilerParameters(System.String[] assemblyNames) { }
    public CompilerParameters(System.String[] assemblyNames, string output) { }
    public CompilerParameters(System.String[] assemblyNames, string output, bool includeDebugInfo) { }
    public string CompilerOptions { get { return default(string); } set { } }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public System.Collections.Specialized.StringCollection EmbeddedResources { get { return default(System.Collections.Specialized.StringCollection); } }
    [System.ObsoleteAttribute]
    public System.Security.Policy.Evidence Evidence { get { return default(System.Security.Policy.Evidence); } set { } }
    public bool GenerateExecutable { get { return default(bool); } set { } }
    public bool GenerateInMemory { get { return default(bool); } set { } }
    public bool IncludeDebugInformation { get { return default(bool); } set { } }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public System.Collections.Specialized.StringCollection LinkedResources { get { return default(System.Collections.Specialized.StringCollection); } }
    public string MainClass { get { return default(string); } set { } }
    public string OutputAssembly { get { return default(string); } set { } }
    public System.Collections.Specialized.StringCollection ReferencedAssemblies { get { return default(System.Collections.Specialized.StringCollection); } }
    public System.CodeDom.Compiler.TempFileCollection TempFiles { get { return default(System.CodeDom.Compiler.TempFileCollection); } set { } }
    public bool TreatWarningsAsErrors { get { return default(bool); } set { } }
    public System.IntPtr UserToken { get { return default(System.IntPtr); } set { } }
    public int WarningLevel { get { return default(int); } set { } }
    public string Win32Resource { get { return default(string); } set { } }
  }
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Unrestricted=true)]
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
  public partial class CompilerResults {
    public CompilerResults(System.CodeDom.Compiler.TempFileCollection tempFiles) { }
    public System.Reflection.Assembly CompiledAssembly { get { return default(System.Reflection.Assembly); } set { } }
    public System.CodeDom.Compiler.CompilerErrorCollection Errors { get { return default(System.CodeDom.Compiler.CompilerErrorCollection); } }
    [System.ObsoleteAttribute]
    public System.Security.Policy.Evidence Evidence { get { return default(System.Security.Policy.Evidence); } set { } }
    public int NativeCompilerReturnValue { get { return default(int); } set { } }
    public System.Collections.Specialized.StringCollection Output { get { return default(System.Collections.Specialized.StringCollection); } }
    public string PathToAssembly { get { return default(string); } set { } }
    public System.CodeDom.Compiler.TempFileCollection TempFiles { get { return default(System.CodeDom.Compiler.TempFileCollection); } set { } }
  }
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
  public static partial class Executor {
    public static void ExecWait(string cmd, System.CodeDom.Compiler.TempFileCollection tempFiles) { }
    public static int ExecWaitWithCapture(System.IntPtr userToken, string cmd, System.CodeDom.Compiler.TempFileCollection tempFiles, ref string outputName, ref string errorName) { return default(int); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Assert, ControlPrincipal=true)]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, UnmanagedCode=true)]
    public static int ExecWaitWithCapture(System.IntPtr userToken, string cmd, string currentDir, System.CodeDom.Compiler.TempFileCollection tempFiles, ref string outputName, ref string errorName) { return default(int); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, UnmanagedCode=true)]
    public static int ExecWaitWithCapture(string cmd, System.CodeDom.Compiler.TempFileCollection tempFiles, ref string outputName, ref string errorName) { return default(int); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, UnmanagedCode=true)]
    public static int ExecWaitWithCapture(string cmd, string currentDir, System.CodeDom.Compiler.TempFileCollection tempFiles, ref string outputName, ref string errorName) { return default(int); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(32767), Inherited=false, AllowMultiple=false)]
  public sealed partial class GeneratedCodeAttribute : System.Attribute {
    public GeneratedCodeAttribute(string tool, string version) { }
    public string Tool { get { return default(string); } }
    public string Version { get { return default(string); } }
  }
  [System.FlagsAttribute]
  public enum GeneratorSupport {
    ArraysOfArrays = 1,
    AssemblyAttributes = 4096,
    ChainedConstructorArguments = 32768,
    ComplexExpressions = 524288,
    DeclareDelegates = 512,
    DeclareEnums = 256,
    DeclareEvents = 2048,
    DeclareIndexerProperties = 33554432,
    DeclareInterfaces = 1024,
    DeclareValueTypes = 128,
    EntryPointMethod = 2,
    GenericTypeDeclaration = 16777216,
    GenericTypeReference = 8388608,
    GotoStatements = 4,
    MultidimensionalArrays = 8,
    MultipleInterfaceMembers = 131072,
    NestedTypes = 65536,
    ParameterAttributes = 8192,
    PartialTypes = 4194304,
    PublicStaticMembers = 262144,
    ReferenceParameters = 16384,
    Resources = 2097152,
    ReturnTypeAttributes = 64,
    StaticConstructors = 16,
    TryCatchStatements = 32,
    Win32Resources = 1048576,
  }
  public partial interface ICodeCompiler {
    System.CodeDom.Compiler.CompilerResults CompileAssemblyFromDom(System.CodeDom.Compiler.CompilerParameters options, System.CodeDom.CodeCompileUnit compilationUnit);
    System.CodeDom.Compiler.CompilerResults CompileAssemblyFromDomBatch(System.CodeDom.Compiler.CompilerParameters options, System.CodeDom.CodeCompileUnit[] batch);
    System.CodeDom.Compiler.CompilerResults CompileAssemblyFromFile(System.CodeDom.Compiler.CompilerParameters options, string fileName);
    System.CodeDom.Compiler.CompilerResults CompileAssemblyFromFileBatch(System.CodeDom.Compiler.CompilerParameters options, System.String[] batch);
    System.CodeDom.Compiler.CompilerResults CompileAssemblyFromSource(System.CodeDom.Compiler.CompilerParameters options, string source);
    System.CodeDom.Compiler.CompilerResults CompileAssemblyFromSourceBatch(System.CodeDom.Compiler.CompilerParameters options, System.String[] batch);
  }
  public partial interface ICodeGenerator {
    string CreateEscapedIdentifier(string value);
    string CreateValidIdentifier(string value);
    void GenerateCodeFromCompileUnit(System.CodeDom.CodeCompileUnit compileUnit, System.IO.TextWriter output, System.CodeDom.Compiler.CodeGeneratorOptions options);
    void GenerateCodeFromExpression(System.CodeDom.CodeExpression expression, System.IO.TextWriter output, System.CodeDom.Compiler.CodeGeneratorOptions options);
    void GenerateCodeFromNamespace(System.CodeDom.CodeNamespace ns, System.IO.TextWriter output, System.CodeDom.Compiler.CodeGeneratorOptions options);
    void GenerateCodeFromStatement(System.CodeDom.CodeStatement statement, System.IO.TextWriter output, System.CodeDom.Compiler.CodeGeneratorOptions options);
    void GenerateCodeFromType(System.CodeDom.CodeTypeDeclaration typeDeclaration, System.IO.TextWriter output, System.CodeDom.Compiler.CodeGeneratorOptions options);
    string GetTypeOutput(System.CodeDom.CodeTypeReference type);
    bool IsValidIdentifier(string value);
    bool Supports(System.CodeDom.Compiler.GeneratorSupport supports);
    void ValidateIdentifier(string value);
  }
  public partial interface ICodeParser {
    System.CodeDom.CodeCompileUnit Parse(System.IO.TextReader codeStream);
  }
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Unrestricted=true)]
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
  public partial class IndentedTextWriter : System.IO.TextWriter {
    public const string DefaultTabString = "    ";
    public IndentedTextWriter(System.IO.TextWriter writer) { }
    public IndentedTextWriter(System.IO.TextWriter writer, string tabString) { }
    public override System.Text.Encoding Encoding { get { return default(System.Text.Encoding); } }
    public int Indent { get { return default(int); } set { } }
    public System.IO.TextWriter InnerWriter { get { return default(System.IO.TextWriter); } }
    public override string NewLine { get { return default(string); } set { } }
    public override void Close() { }
    public override void Flush() { }
    protected virtual void OutputTabs() { }
    public override void Write(bool value) { }
    public override void Write(char value) { }
    public override void Write(System.Char[] value) { }
    public override void Write(System.Char[] buffer, int index, int count) { }
    public override void Write(double value) { }
    public override void Write(int value) { }
    public override void Write(long value) { }
    public override void Write(object value) { }
    public override void Write(float value) { }
    public override void Write(string value) { }
    public override void Write(string format, object arg) { }
    public override void Write(string format, object arg0, object arg1) { }
    public override void Write(string format, params System.Object[] args) { }
    public override void WriteLine() { }
    public override void WriteLine(bool value) { }
    public override void WriteLine(char value) { }
    public override void WriteLine(System.Char[] value) { }
    public override void WriteLine(System.Char[] buffer, int index, int count) { }
    public override void WriteLine(double value) { }
    public override void WriteLine(int value) { }
    public override void WriteLine(long value) { }
    public override void WriteLine(object value) { }
    public override void WriteLine(float value) { }
    public override void WriteLine(string value) { }
    public override void WriteLine(string format, object arg) { }
    public override void WriteLine(string format, object arg0, object arg1) { }
    public override void WriteLine(string format, params System.Object[] args) { }
    [System.CLSCompliantAttribute(false)]
    public override void WriteLine(uint value) { }
    public void WriteLineNoTabs(string value) { }
  }
  [System.FlagsAttribute]
  public enum LanguageOptions {
    CaseInsensitive = 1,
    None = 0,
  }
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
  public partial class TempFileCollection : System.Collections.ICollection, System.Collections.IEnumerable, System.IDisposable {
    public TempFileCollection() { }
    public TempFileCollection(string tempDir) { }
    public TempFileCollection(string tempDir, bool keepFiles) { }
    public string BasePath { get { return default(string); } }
    public int Count { get { return default(int); } }
    public bool KeepFiles { get { return default(bool); } set { } }
    int System.Collections.ICollection.Count { get { return default(int); } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    public string TempDir { get { return default(string); } }
    public string AddExtension(string fileExtension) { return default(string); }
    public string AddExtension(string fileExtension, bool keepFile) { return default(string); }
    public void AddFile(string fileName, bool keepFile) { }
    public void CopyTo(System.String[] fileNames, int start) { }
    public void Delete() { }
    protected virtual void Dispose(bool disposing) { }
    ~TempFileCollection() { }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    void System.Collections.ICollection.CopyTo(System.Array array, int start) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    void System.IDisposable.Dispose() { }
  }
}
namespace System.Collections.Concurrent {
  [System.Diagnostics.DebuggerDisplayAttribute("Count={Count}")]
  [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(System.Collections.Generic.CollectionDebuggerView<T>))]
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public partial class BlockingCollection<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.ICollection, System.Collections.IEnumerable, System.IDisposable {
    public BlockingCollection() { }
    public BlockingCollection(System.Collections.Concurrent.IProducerConsumerCollection<T> collection) { }
    public BlockingCollection(System.Collections.Concurrent.IProducerConsumerCollection<T> collection, int boundedCapacity) { }
    public BlockingCollection(int boundedCapacity) { }
    public int BoundedCapacity { get { return default(int); } }
    public int Count { get { return default(int); } }
    public bool IsAddingCompleted { get { return default(bool); } }
    public bool IsCompleted { get { return default(bool); } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    public void Add(T item) { }
    public void Add(T item, System.Threading.CancellationToken cancellationToken) { }
    public static int AddToAny(System.Collections.Concurrent.BlockingCollection<T>[] collections, T item) { return default(int); }
    public static int AddToAny(System.Collections.Concurrent.BlockingCollection<T>[] collections, T item, System.Threading.CancellationToken cancellationToken) { return default(int); }
    public void CompleteAdding() { }
    public void CopyTo(T[] array, int index) { }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public System.Collections.Generic.IEnumerable<T> GetConsumingEnumerable() { return default(System.Collections.Generic.IEnumerable<T>); }
    [System.Diagnostics.DebuggerHiddenAttribute]
    public System.Collections.Generic.IEnumerable<T> GetConsumingEnumerable(System.Threading.CancellationToken cancellationToken) { return default(System.Collections.Generic.IEnumerable<T>); }
    System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { return default(System.Collections.Generic.IEnumerator<T>); }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    public T Take() { return default(T); }
    public T Take(System.Threading.CancellationToken cancellationToken) { return default(T); }
    public static int TakeFromAny(System.Collections.Concurrent.BlockingCollection<T>[] collections, out T item) { item = default(T); return default(int); }
    public static int TakeFromAny(System.Collections.Concurrent.BlockingCollection<T>[] collections, out T item, System.Threading.CancellationToken cancellationToken) { item = default(T); return default(int); }
    public T[] ToArray() { return default(T[]); }
    public bool TryAdd(T item) { return default(bool); }
    public bool TryAdd(T item, int millisecondsTimeout) { return default(bool); }
    public bool TryAdd(T item, int millisecondsTimeout, System.Threading.CancellationToken cancellationToken) { return default(bool); }
    public bool TryAdd(T item, System.TimeSpan timeout) { return default(bool); }
    public static int TryAddToAny(System.Collections.Concurrent.BlockingCollection<T>[] collections, T item) { return default(int); }
    public static int TryAddToAny(System.Collections.Concurrent.BlockingCollection<T>[] collections, T item, int millisecondsTimeout) { return default(int); }
    public static int TryAddToAny(System.Collections.Concurrent.BlockingCollection<T>[] collections, T item, int millisecondsTimeout, System.Threading.CancellationToken cancellationToken) { return default(int); }
    public static int TryAddToAny(System.Collections.Concurrent.BlockingCollection<T>[] collections, T item, System.TimeSpan timeout) { return default(int); }
    public bool TryTake(out T item) { item = default(T); return default(bool); }
    public bool TryTake(out T item, int millisecondsTimeout) { item = default(T); return default(bool); }
    public bool TryTake(out T item, int millisecondsTimeout, System.Threading.CancellationToken cancellationToken) { item = default(T); return default(bool); }
    public bool TryTake(out T item, System.TimeSpan timeout) { item = default(T); return default(bool); }
    public static int TryTakeFromAny(System.Collections.Concurrent.BlockingCollection<T>[] collections, out T item) { item = default(T); return default(int); }
    public static int TryTakeFromAny(System.Collections.Concurrent.BlockingCollection<T>[] collections, out T item, int millisecondsTimeout) { item = default(T); return default(int); }
    public static int TryTakeFromAny(System.Collections.Concurrent.BlockingCollection<T>[] collections, out T item, int millisecondsTimeout, System.Threading.CancellationToken cancellationToken) { item = default(T); return default(int); }
    public static int TryTakeFromAny(System.Collections.Concurrent.BlockingCollection<T>[] collections, out T item, System.TimeSpan timeout) { item = default(T); return default(int); }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("Count={Count}")]
  [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(System.Collections.Generic.CollectionDebuggerView<T>))]
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public partial class ConcurrentBag<T> : System.Collections.Concurrent.IProducerConsumerCollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.ICollection, System.Collections.IEnumerable {
    public ConcurrentBag() { }
    public ConcurrentBag(System.Collections.Generic.IEnumerable<T> collection) { }
    public int Count { get { return default(int); } }
    public bool IsEmpty { get { return default(bool); } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    public void Add(T item) { }
    public void CopyTo(T[] array, int index) { }
    public System.Collections.Generic.IEnumerator<T> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<T>); }
    bool System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(T element) { return default(bool); }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    public T[] ToArray() { return default(T[]); }
    public bool TryPeek(out T result) { result = default(T); return default(bool); }
    public bool TryTake(out T result) { result = default(T); return default(bool); }
  }
}
namespace System.Collections.Generic {
  public partial interface ISet<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable {
    new bool Add(T item);
    void ExceptWith(System.Collections.Generic.IEnumerable<T> other);
    void IntersectWith(System.Collections.Generic.IEnumerable<T> other);
    bool IsProperSubsetOf(System.Collections.Generic.IEnumerable<T> other);
    bool IsProperSupersetOf(System.Collections.Generic.IEnumerable<T> other);
    bool IsSubsetOf(System.Collections.Generic.IEnumerable<T> other);
    bool IsSupersetOf(System.Collections.Generic.IEnumerable<T> other);
    bool Overlaps(System.Collections.Generic.IEnumerable<T> other);
    bool SetEquals(System.Collections.Generic.IEnumerable<T> other);
    void SymmetricExceptWith(System.Collections.Generic.IEnumerable<T> other);
    void UnionWith(System.Collections.Generic.IEnumerable<T> other);
  }
  [System.Diagnostics.DebuggerDisplayAttribute("Count={Count}")]
  [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(System.Collections.Generic.CollectionDebuggerView<T>))]
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public partial class LinkedList<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.ICollection, System.Collections.IEnumerable, System.Runtime.Serialization.IDeserializationCallback, System.Runtime.Serialization.ISerializable {
    public LinkedList() { }
    public LinkedList(System.Collections.Generic.IEnumerable<T> collection) { }
    protected LinkedList(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public int Count { get { return default(int); } }
    public System.Collections.Generic.LinkedListNode<T> First { get { return default(System.Collections.Generic.LinkedListNode<T>); } }
    public System.Collections.Generic.LinkedListNode<T> Last { get { return default(System.Collections.Generic.LinkedListNode<T>); } }
    bool System.Collections.Generic.ICollection<T>.IsReadOnly { get { return default(bool); } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    public System.Collections.Generic.LinkedListNode<T> AddAfter(System.Collections.Generic.LinkedListNode<T> node, T value) { return default(System.Collections.Generic.LinkedListNode<T>); }
    public void AddAfter(System.Collections.Generic.LinkedListNode<T> node, System.Collections.Generic.LinkedListNode<T> newNode) { }
    public System.Collections.Generic.LinkedListNode<T> AddBefore(System.Collections.Generic.LinkedListNode<T> node, T value) { return default(System.Collections.Generic.LinkedListNode<T>); }
    public void AddBefore(System.Collections.Generic.LinkedListNode<T> node, System.Collections.Generic.LinkedListNode<T> newNode) { }
    public System.Collections.Generic.LinkedListNode<T> AddFirst(T value) { return default(System.Collections.Generic.LinkedListNode<T>); }
    public void AddFirst(System.Collections.Generic.LinkedListNode<T> node) { }
    public System.Collections.Generic.LinkedListNode<T> AddLast(T value) { return default(System.Collections.Generic.LinkedListNode<T>); }
    public void AddLast(System.Collections.Generic.LinkedListNode<T> node) { }
    public void Clear() { }
    public bool Contains(T value) { return default(bool); }
    public void CopyTo(T[] array, int index) { }
    public System.Collections.Generic.LinkedListNode<T> Find(T value) { return default(System.Collections.Generic.LinkedListNode<T>); }
    public System.Collections.Generic.LinkedListNode<T> FindLast(T value) { return default(System.Collections.Generic.LinkedListNode<T>); }
    public System.Collections.Generic.LinkedList<T>.Enumerator GetEnumerator() { return default(System.Collections.Generic.LinkedList<T>.Enumerator); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(128))]
    public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public virtual void OnDeserialization(object sender) { }
    public bool Remove(T value) { return default(bool); }
    public void Remove(System.Collections.Generic.LinkedListNode<T> node) { }
    public void RemoveFirst() { }
    public void RemoveLast() { }
    void System.Collections.Generic.ICollection<T>.Add(T value) { }
    System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { return default(System.Collections.Generic.IEnumerator<T>); }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Enumerator : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable, System.Runtime.Serialization.IDeserializationCallback, System.Runtime.Serialization.ISerializable {
      public T Current { get { return default(T); } }
      object System.Collections.IEnumerator.Current { get { return default(object); } }
      public void Dispose() { }
      public bool MoveNext() { return default(bool); }
      void System.Collections.IEnumerator.Reset() { }
      void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
      [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(128))]
      void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public sealed partial class LinkedListNode<T> {
    public LinkedListNode(T value) { }
    public System.Collections.Generic.LinkedList<T> List { get { return default(System.Collections.Generic.LinkedList<T>); } }
    public System.Collections.Generic.LinkedListNode<T> Next { get { return default(System.Collections.Generic.LinkedListNode<T>); } }
    public System.Collections.Generic.LinkedListNode<T> Previous { get { return default(System.Collections.Generic.LinkedListNode<T>); } }
    public T Value { get { return default(T); } set { } }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("Count={Count}")]
  [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(System.Collections.CollectionDebuggerView))]
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public partial class Queue<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.ICollection, System.Collections.IEnumerable {
    public Queue() { }
    public Queue(System.Collections.Generic.IEnumerable<T> collection) { }
    public Queue(int capacity) { }
    public int Count { get { return default(int); } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    public void Clear() { }
    public bool Contains(T item) { return default(bool); }
    public void CopyTo(T[] array, int arrayIndex) { }
    public T Dequeue() { return default(T); }
    public void Enqueue(T item) { }
    public System.Collections.Generic.Queue<T>.Enumerator GetEnumerator() { return default(System.Collections.Generic.Queue<T>.Enumerator); }
    public T Peek() { return default(T); }
    System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { return default(System.Collections.Generic.IEnumerator<T>); }
    void System.Collections.ICollection.CopyTo(System.Array array, int idx) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    public T[] ToArray() { return default(T[]); }
    public void TrimExcess() { }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Enumerator : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable {
      public T Current { get { return default(T); } }
      object System.Collections.IEnumerator.Current { get { return default(object); } }
      public void Dispose() { }
      public bool MoveNext() { return default(bool); }
      void System.Collections.IEnumerator.Reset() { }
    }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("Count={Count}")]
  [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(System.Collections.Generic.CollectionDebuggerView<T, U>))]
  public partial class SortedDictionary<TKey, TValue> : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.ICollection, System.Collections.IDictionary, System.Collections.IEnumerable, System.Runtime.Serialization.ISerializable {
    public SortedDictionary() { }
    public SortedDictionary(System.Collections.Generic.IComparer<TKey> comparer) { }
    public SortedDictionary(System.Collections.Generic.IDictionary<TKey, TValue> dictionary) { }
    public SortedDictionary(System.Collections.Generic.IDictionary<TKey, TValue> dictionary, System.Collections.Generic.IComparer<TKey> comparer) { }
    protected SortedDictionary(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public System.Collections.Generic.IComparer<TKey> Comparer { get { return default(System.Collections.Generic.IComparer<TKey>); } }
    public int Count { get { return default(int); } }
    public TValue this[TKey key] { get { return default(TValue); } set { } }
    public System.Collections.Generic.SortedDictionary<TKey, TValue>.KeyCollection Keys { get { return default(System.Collections.Generic.SortedDictionary<TKey, TValue>.KeyCollection); } }
    bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly { get { return default(bool); } }
    System.Collections.Generic.ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.Keys { get { return default(System.Collections.Generic.ICollection<TKey>); } }
    System.Collections.Generic.ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.Values { get { return default(System.Collections.Generic.ICollection<TValue>); } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    bool System.Collections.IDictionary.IsFixedSize { get { return default(bool); } }
    bool System.Collections.IDictionary.IsReadOnly { get { return default(bool); } }
    object System.Collections.IDictionary.this[object key] { get { return default(object); } set { } }
    System.Collections.ICollection System.Collections.IDictionary.Keys { get { return default(System.Collections.ICollection); } }
    System.Collections.ICollection System.Collections.IDictionary.Values { get { return default(System.Collections.ICollection); } }
    public System.Collections.Generic.SortedDictionary<TKey, TValue>.ValueCollection Values { get { return default(System.Collections.Generic.SortedDictionary<TKey, TValue>.ValueCollection); } }
    public void Add(TKey key, TValue value) { }
    public void Clear() { }
    public bool ContainsKey(TKey key) { return default(bool); }
    public bool ContainsValue(TValue value) { return default(bool); }
    public void CopyTo(System.Collections.Generic.KeyValuePair<TKey, TValue>[] array, int index) { }
    public System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator GetEnumerator() { return default(System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(128))]
    public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public bool Remove(TKey key) { return default(bool); }
    void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey, TValue> item) { }
    bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> item) { return default(bool); }
    bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> item) { return default(bool); }
    System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>>); }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    void System.Collections.IDictionary.Add(object key, object value) { }
    bool System.Collections.IDictionary.Contains(object key) { return default(bool); }
    System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { return default(System.Collections.IDictionaryEnumerator); }
    void System.Collections.IDictionary.Remove(object key) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    public bool TryGetValue(TKey key, out TValue value) { value = default(TValue); return default(bool); }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Enumerator : System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IDictionaryEnumerator, System.Collections.IEnumerator, System.IDisposable {
      public System.Collections.Generic.KeyValuePair<TKey, TValue> Current { get { return default(System.Collections.Generic.KeyValuePair<TKey, TValue>); } }
      System.Collections.DictionaryEntry System.Collections.IDictionaryEnumerator.Entry { get { return default(System.Collections.DictionaryEntry); } }
      object System.Collections.IDictionaryEnumerator.Key { get { return default(object); } }
      object System.Collections.IDictionaryEnumerator.Value { get { return default(object); } }
      object System.Collections.IEnumerator.Current { get { return default(object); } }
      public void Dispose() { }
      public bool MoveNext() { return default(bool); }
      void System.Collections.IEnumerator.Reset() { }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("Count={Count}")]
    [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(System.Collections.Generic.CollectionDebuggerView<T, U>))]
    public sealed partial class KeyCollection : System.Collections.Generic.ICollection<TKey>, System.Collections.Generic.IEnumerable<TKey>, System.Collections.ICollection, System.Collections.IEnumerable {
      public KeyCollection(System.Collections.Generic.SortedDictionary<TKey, TValue> dictionary) { }
      public int Count { get { return default(int); } }
      bool System.Collections.Generic.ICollection<TKey>.IsReadOnly { get { return default(bool); } }
      bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
      object System.Collections.ICollection.SyncRoot { get { return default(object); } }
      public void CopyTo(TKey[] array, int index) { }
      public System.Collections.Generic.SortedDictionary<TKey, TValue>.KeyCollection.Enumerator GetEnumerator() { return default(System.Collections.Generic.SortedDictionary<TKey, TValue>.KeyCollection.Enumerator); }
      void System.Collections.Generic.ICollection<TKey>.Add(TKey item) { }
      void System.Collections.Generic.ICollection<TKey>.Clear() { }
      bool System.Collections.Generic.ICollection<TKey>.Contains(TKey item) { return default(bool); }
      bool System.Collections.Generic.ICollection<TKey>.Remove(TKey item) { return default(bool); }
      System.Collections.Generic.IEnumerator<TKey> System.Collections.Generic.IEnumerable<TKey>.GetEnumerator() { return default(System.Collections.Generic.IEnumerator<TKey>); }
      void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
      System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
      [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
      public partial struct Enumerator : System.Collections.Generic.IEnumerator<TKey>, System.Collections.IEnumerator, System.IDisposable {
        public TKey Current { get { return default(TKey); } }
        object System.Collections.IEnumerator.Current { get { return default(object); } }
        public void Dispose() { }
        public bool MoveNext() { return default(bool); }
        void System.Collections.IEnumerator.Reset() { }
      }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("Count={Count}")]
    [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(System.Collections.Generic.CollectionDebuggerView<T, U>))]
    public sealed partial class ValueCollection : System.Collections.Generic.ICollection<TValue>, System.Collections.Generic.IEnumerable<TValue>, System.Collections.ICollection, System.Collections.IEnumerable {
      public ValueCollection(System.Collections.Generic.SortedDictionary<TKey, TValue> dictionary) { }
      public int Count { get { return default(int); } }
      bool System.Collections.Generic.ICollection<TValue>.IsReadOnly { get { return default(bool); } }
      bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
      object System.Collections.ICollection.SyncRoot { get { return default(object); } }
      public void CopyTo(TValue[] array, int index) { }
      public System.Collections.Generic.SortedDictionary<TKey, TValue>.ValueCollection.Enumerator GetEnumerator() { return default(System.Collections.Generic.SortedDictionary<TKey, TValue>.ValueCollection.Enumerator); }
      void System.Collections.Generic.ICollection<TValue>.Add(TValue item) { }
      void System.Collections.Generic.ICollection<TValue>.Clear() { }
      bool System.Collections.Generic.ICollection<TValue>.Contains(TValue item) { return default(bool); }
      bool System.Collections.Generic.ICollection<TValue>.Remove(TValue item) { return default(bool); }
      System.Collections.Generic.IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator() { return default(System.Collections.Generic.IEnumerator<TValue>); }
      void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
      System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
      [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
      public partial struct Enumerator : System.Collections.Generic.IEnumerator<TValue>, System.Collections.IEnumerator, System.IDisposable {
        public TValue Current { get { return default(TValue); } }
        object System.Collections.IEnumerator.Current { get { return default(object); } }
        public void Dispose() { }
        public bool MoveNext() { return default(bool); }
        void System.Collections.IEnumerator.Reset() { }
      }
    }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("Count={Count}")]
  [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(System.Collections.Generic.CollectionDebuggerView<T, U>))]
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public partial class SortedList<TKey, TValue> : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.ICollection, System.Collections.IDictionary, System.Collections.IEnumerable {
    public SortedList() { }
    public SortedList(System.Collections.Generic.IComparer<TKey> comparer) { }
    public SortedList(System.Collections.Generic.IDictionary<TKey, TValue> dictionary) { }
    public SortedList(System.Collections.Generic.IDictionary<TKey, TValue> dictionary, System.Collections.Generic.IComparer<TKey> comparer) { }
    public SortedList(int capacity) { }
    public SortedList(int capacity, System.Collections.Generic.IComparer<TKey> comparer) { }
    public int Capacity { get { return default(int); } set { } }
    public System.Collections.Generic.IComparer<TKey> Comparer { get { return default(System.Collections.Generic.IComparer<TKey>); } }
    public int Count { get { return default(int); } }
    public TValue this[TKey key] { get { return default(TValue); } set { } }
    public System.Collections.Generic.IList<TKey> Keys { get { return default(System.Collections.Generic.IList<TKey>); } }
    bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly { get { return default(bool); } }
    System.Collections.Generic.ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.Keys { get { return default(System.Collections.Generic.ICollection<TKey>); } }
    System.Collections.Generic.ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.Values { get { return default(System.Collections.Generic.ICollection<TValue>); } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    bool System.Collections.IDictionary.IsFixedSize { get { return default(bool); } }
    bool System.Collections.IDictionary.IsReadOnly { get { return default(bool); } }
    object System.Collections.IDictionary.this[object key] { get { return default(object); } set { } }
    System.Collections.ICollection System.Collections.IDictionary.Keys { get { return default(System.Collections.ICollection); } }
    System.Collections.ICollection System.Collections.IDictionary.Values { get { return default(System.Collections.ICollection); } }
    public System.Collections.Generic.IList<TValue> Values { get { return default(System.Collections.Generic.IList<TValue>); } }
    public void Add(TKey key, TValue value) { }
    public void Clear() { }
    public bool ContainsKey(TKey key) { return default(bool); }
    public bool ContainsValue(TValue value) { return default(bool); }
    [System.Diagnostics.DebuggerHiddenAttribute]
    public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>>); }
    public int IndexOfKey(TKey key) { return default(int); }
    public int IndexOfValue(TValue value) { return default(int); }
    public bool Remove(TKey key) { return default(bool); }
    public void RemoveAt(int index) { }
    void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair) { }
    void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Clear() { }
    bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair) { return default(bool); }
    void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(System.Collections.Generic.KeyValuePair<TKey, TValue>[] array, int arrayIndex) { }
    bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair) { return default(bool); }
    [System.Diagnostics.DebuggerHiddenAttribute]
    System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>>); }
    void System.Collections.ICollection.CopyTo(System.Array array, int arrayIndex) { }
    void System.Collections.IDictionary.Add(object key, object value) { }
    bool System.Collections.IDictionary.Contains(object key) { return default(bool); }
    System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { return default(System.Collections.IDictionaryEnumerator); }
    void System.Collections.IDictionary.Remove(object key) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    public void TrimExcess() { }
    public bool TryGetValue(TKey key, out TValue value) { value = default(TValue); return default(bool); }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("Count={Count}")]
  [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(System.Collections.CollectionDebuggerView))]
  public partial class SortedSet<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.ISet<T>, System.Collections.ICollection, System.Collections.IEnumerable, System.Runtime.Serialization.IDeserializationCallback, System.Runtime.Serialization.ISerializable {
    public SortedSet() { }
    public SortedSet(System.Collections.Generic.IComparer<T> comparer) { }
    public SortedSet(System.Collections.Generic.IEnumerable<T> collection) { }
    public SortedSet(System.Collections.Generic.IEnumerable<T> collection, System.Collections.Generic.IComparer<T> comparer) { }
    protected SortedSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public System.Collections.Generic.IComparer<T> Comparer { get { return default(System.Collections.Generic.IComparer<T>); } }
    public int Count { get { return default(int); } }
    public T Max { get { return default(T); } }
    public T Min { get { return default(T); } }
    bool System.Collections.Generic.ICollection<T>.IsReadOnly { get { return default(bool); } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    public bool Add(T item) { return default(bool); }
    public virtual void Clear() { }
    public virtual bool Contains(T item) { return default(bool); }
    public void CopyTo(T[] array) { }
    public void CopyTo(T[] array, int index) { }
    public void CopyTo(T[] array, int index, int count) { }
    public static System.Collections.Generic.IEqualityComparer<System.Collections.Generic.SortedSet<T>> CreateSetComparer() { return default(System.Collections.Generic.IEqualityComparer<System.Collections.Generic.SortedSet<T>>); }
    [System.MonoTODOAttribute]
    public static System.Collections.Generic.IEqualityComparer<System.Collections.Generic.SortedSet<T>> CreateSetComparer(System.Collections.Generic.IEqualityComparer<T> memberEqualityComparer) { return default(System.Collections.Generic.IEqualityComparer<System.Collections.Generic.SortedSet<T>>); }
    [System.MonoLimitationAttribute("Isn't O(n) when other is SortedSet<T>")]
    public void ExceptWith(System.Collections.Generic.IEnumerable<T> other) { }
    public System.Collections.Generic.SortedSet<T>.Enumerator GetEnumerator() { return default(System.Collections.Generic.SortedSet<T>.Enumerator); }
    [System.MonoTODOAttribute]
    protected virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public virtual System.Collections.Generic.SortedSet<T> GetViewBetween(T lowerValue, T upperValue) { return default(System.Collections.Generic.SortedSet<T>); }
    [System.MonoLimitationAttribute("Isn't O(n) when other is SortedSet<T>")]
    public virtual void IntersectWith(System.Collections.Generic.IEnumerable<T> other) { }
    public bool IsProperSubsetOf(System.Collections.Generic.IEnumerable<T> other) { return default(bool); }
    public bool IsProperSupersetOf(System.Collections.Generic.IEnumerable<T> other) { return default(bool); }
    public bool IsSubsetOf(System.Collections.Generic.IEnumerable<T> other) { return default(bool); }
    public bool IsSupersetOf(System.Collections.Generic.IEnumerable<T> other) { return default(bool); }
    [System.MonoTODOAttribute]
    protected virtual void OnDeserialization(object sender) { }
    public bool Overlaps(System.Collections.Generic.IEnumerable<T> other) { return default(bool); }
    public bool Remove(T item) { return default(bool); }
    public int RemoveWhere(System.Predicate<T> match) { return default(int); }
    [System.Diagnostics.DebuggerHiddenAttribute]
    public System.Collections.Generic.IEnumerable<T> Reverse() { return default(System.Collections.Generic.IEnumerable<T>); }
    public bool SetEquals(System.Collections.Generic.IEnumerable<T> other) { return default(bool); }
    [System.MonoLimitationAttribute("Isn't O(n) when other is SortedSet<T>")]
    public void SymmetricExceptWith(System.Collections.Generic.IEnumerable<T> other) { }
    void System.Collections.Generic.ICollection<T>.Add(T item) { }
    System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { return default(System.Collections.Generic.IEnumerator<T>); }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    [System.MonoLimitationAttribute("Isn't O(n) when other is SortedSet<T>")]
    public void UnionWith(System.Collections.Generic.IEnumerable<T> other) { }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Enumerator : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable {
      public T Current { get { return default(T); } }
      object System.Collections.IEnumerator.Current { get { return default(object); } }
      public void Dispose() { }
      public bool MoveNext() { return default(bool); }
      void System.Collections.IEnumerator.Reset() { }
    }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("Count={Count}")]
  [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(System.Collections.CollectionDebuggerView))]
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public partial class Stack<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.ICollection, System.Collections.IEnumerable {
    public Stack() { }
    public Stack(System.Collections.Generic.IEnumerable<T> collection) { }
    public Stack(int capacity) { }
    public int Count { get { return default(int); } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    public void Clear() { }
    public bool Contains(T item) { return default(bool); }
    public void CopyTo(T[] array, int arrayIndex) { }
    public System.Collections.Generic.Stack<T>.Enumerator GetEnumerator() { return default(System.Collections.Generic.Stack<T>.Enumerator); }
    public T Peek() { return default(T); }
    public T Pop() { return default(T); }
    public void Push(T item) { }
    System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { return default(System.Collections.Generic.IEnumerator<T>); }
    void System.Collections.ICollection.CopyTo(System.Array dest, int idx) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    public T[] ToArray() { return default(T[]); }
    public void TrimExcess() { }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Enumerator : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable {
      public T Current { get { return default(T); } }
      object System.Collections.IEnumerator.Current { get { return default(object); } }
      public void Dispose() { }
      public bool MoveNext() { return default(bool); }
      void System.Collections.IEnumerator.Reset() { }
    }
  }
}
namespace System.Collections.ObjectModel {
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("WindowsBase, Version=3.0.0.0, PublicKeyToken=31bf3856ad364e35")]
  public partial class ObservableCollection<T> : System.Collections.ObjectModel.Collection<T>, System.Collections.Specialized.INotifyCollectionChanged, System.ComponentModel.INotifyPropertyChanged {
    public ObservableCollection() { }
    public ObservableCollection(System.Collections.Generic.IEnumerable<T> collection) { }
    public ObservableCollection(System.Collections.Generic.List<T> list) { }
    public virtual event System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged { add { } remove { } }
    protected virtual event System.ComponentModel.PropertyChangedEventHandler PropertyChanged { add { } remove { } }
    event System.ComponentModel.PropertyChangedEventHandler System.ComponentModel.INotifyPropertyChanged.PropertyChanged { add { } remove { } }
    protected System.IDisposable BlockReentrancy() { return default(System.IDisposable); }
    protected void CheckReentrancy() { }
    protected override void ClearItems() { }
    protected override void InsertItem(int index, T item) { }
    public void Move(int oldIndex, int newIndex) { }
    protected virtual void MoveItem(int oldIndex, int newIndex) { }
    protected virtual void OnCollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventArgs e) { }
    protected virtual void OnPropertyChanged(System.ComponentModel.PropertyChangedEventArgs e) { }
    protected override void RemoveItem(int index) { }
    protected override void SetItem(int index, T item) { }
  }
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("WindowsBase, Version=3.0.0.0, PublicKeyToken=31bf3856ad364e35")]
  public partial class ReadOnlyObservableCollection<T> : System.Collections.ObjectModel.ReadOnlyCollection<T>, System.Collections.Specialized.INotifyCollectionChanged, System.ComponentModel.INotifyPropertyChanged {
    public ReadOnlyObservableCollection(System.Collections.ObjectModel.ObservableCollection<T> list) : base (default(System.Collections.Generic.IList<T>)) { }
    protected virtual event System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged { add { } remove { } }
    protected virtual event System.ComponentModel.PropertyChangedEventHandler PropertyChanged { add { } remove { } }
    event System.Collections.Specialized.NotifyCollectionChangedEventHandler System.Collections.Specialized.INotifyCollectionChanged.CollectionChanged { add { } remove { } }
    event System.ComponentModel.PropertyChangedEventHandler System.ComponentModel.INotifyPropertyChanged.PropertyChanged { add { } remove { } }
    protected virtual void OnCollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventArgs args) { }
    protected virtual void OnPropertyChanged(System.ComponentModel.PropertyChangedEventArgs args) { }
  }
}
namespace System.Collections.Specialized {
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct BitVector32 {
    public BitVector32(System.Collections.Specialized.BitVector32 value) { throw new System.NotImplementedException(); }
    public BitVector32(int data) { throw new System.NotImplementedException(); }
    public int Data { get { return default(int); } }
    public int this[System.Collections.Specialized.BitVector32.Section section] { get { return default(int); } set { } }
    public bool this[int bit] { get { return default(bool); } set { } }
    public static int CreateMask() { return default(int); }
    public static int CreateMask(int previous) { return default(int); }
    public static System.Collections.Specialized.BitVector32.Section CreateSection(short maxValue) { return default(System.Collections.Specialized.BitVector32.Section); }
    public static System.Collections.Specialized.BitVector32.Section CreateSection(short maxValue, System.Collections.Specialized.BitVector32.Section previous) { return default(System.Collections.Specialized.BitVector32.Section); }
    public override bool Equals(object o) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
    public static string ToString(System.Collections.Specialized.BitVector32 value) { return default(string); }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Section {
      public short Mask { get { return default(short); } }
      public short Offset { get { return default(short); } }
      public bool Equals(System.Collections.Specialized.BitVector32.Section obj) { return default(bool); }
      public override bool Equals(object o) { return default(bool); }
      public override int GetHashCode() { return default(int); }
      public static bool operator ==(System.Collections.Specialized.BitVector32.Section a, System.Collections.Specialized.BitVector32.Section b) { return default(bool); }
      public static bool operator !=(System.Collections.Specialized.BitVector32.Section a, System.Collections.Specialized.BitVector32.Section b) { return default(bool); }
      public override string ToString() { return default(string); }
      public static string ToString(System.Collections.Specialized.BitVector32.Section value) { return default(string); }
    }
  }
  public partial class CollectionsUtil {
    public CollectionsUtil() { }
    public static System.Collections.Hashtable CreateCaseInsensitiveHashtable() { return default(System.Collections.Hashtable); }
    public static System.Collections.Hashtable CreateCaseInsensitiveHashtable(System.Collections.IDictionary d) { return default(System.Collections.Hashtable); }
    public static System.Collections.Hashtable CreateCaseInsensitiveHashtable(int capacity) { return default(System.Collections.Hashtable); }
    public static System.Collections.SortedList CreateCaseInsensitiveSortedList() { return default(System.Collections.SortedList); }
  }
  public partial class HybridDictionary : System.Collections.ICollection, System.Collections.IDictionary, System.Collections.IEnumerable {
    public HybridDictionary() { }
    public HybridDictionary(bool caseInsensitive) { }
    public HybridDictionary(int initialSize) { }
    public HybridDictionary(int initialSize, bool caseInsensitive) { }
    public int Count { get { return default(int); } }
    public bool IsFixedSize { get { return default(bool); } }
    public bool IsReadOnly { get { return default(bool); } }
    public bool IsSynchronized { get { return default(bool); } }
    public object this[object key] { get { return default(object); } set { } }
    public System.Collections.ICollection Keys { get { return default(System.Collections.ICollection); } }
    public object SyncRoot { get { return default(object); } }
    public System.Collections.ICollection Values { get { return default(System.Collections.ICollection); } }
    public void Add(object key, object value) { }
    public void Clear() { }
    public bool Contains(object key) { return default(bool); }
    public void CopyTo(System.Array array, int index) { }
    public System.Collections.IDictionaryEnumerator GetEnumerator() { return default(System.Collections.IDictionaryEnumerator); }
    public void Remove(object key) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("WindowsBase, Version=3.0.0.0, PublicKeyToken=31bf3856ad364e35")]
  public partial interface INotifyCollectionChanged {
    event System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged;
  }
  public partial interface IOrderedDictionary : System.Collections.ICollection, System.Collections.IDictionary, System.Collections.IEnumerable {
    object this[int index] { get; set; }
    new System.Collections.IDictionaryEnumerator GetEnumerator();
    void Insert(int index, object key, object value);
    void RemoveAt(int index);
  }
  public partial class ListDictionary : System.Collections.ICollection, System.Collections.IDictionary, System.Collections.IEnumerable {
    public ListDictionary() { }
    public ListDictionary(System.Collections.IComparer comparer) { }
    public int Count { get { return default(int); } }
    public bool IsFixedSize { get { return default(bool); } }
    public bool IsReadOnly { get { return default(bool); } }
    public bool IsSynchronized { get { return default(bool); } }
    public object this[object key] { get { return default(object); } set { } }
    public System.Collections.ICollection Keys { get { return default(System.Collections.ICollection); } }
    public object SyncRoot { get { return default(object); } }
    public System.Collections.ICollection Values { get { return default(System.Collections.ICollection); } }
    public void Add(object key, object value) { }
    public void Clear() { }
    public bool Contains(object key) { return default(bool); }
    public void CopyTo(System.Array array, int index) { }
    public System.Collections.IDictionaryEnumerator GetEnumerator() { return default(System.Collections.IDictionaryEnumerator); }
    public void Remove(object key) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public abstract partial class NameObjectCollectionBase : System.Collections.ICollection, System.Collections.IEnumerable, System.Runtime.Serialization.IDeserializationCallback, System.Runtime.Serialization.ISerializable {
    protected NameObjectCollectionBase() { }
    protected NameObjectCollectionBase(System.Collections.IEqualityComparer equalityComparer) { }
    [System.ObsoleteAttribute("Use NameObjectCollectionBase(IEqualityComparer)")]
    protected NameObjectCollectionBase(System.Collections.IHashCodeProvider hashProvider, System.Collections.IComparer comparer) { }
    protected NameObjectCollectionBase(int capacity) { }
    protected NameObjectCollectionBase(int capacity, System.Collections.IEqualityComparer equalityComparer) { }
    [System.ObsoleteAttribute("Use NameObjectCollectionBase(int,IEqualityComparer)")]
    protected NameObjectCollectionBase(int capacity, System.Collections.IHashCodeProvider hashProvider, System.Collections.IComparer comparer) { }
    protected NameObjectCollectionBase(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public virtual int Count { get { return default(int); } }
    protected bool IsReadOnly { get { return default(bool); } set { } }
    public virtual System.Collections.Specialized.NameObjectCollectionBase.KeysCollection Keys { get { return default(System.Collections.Specialized.NameObjectCollectionBase.KeysCollection); } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    protected void BaseAdd(string name, object value) { }
    protected void BaseClear() { }
    protected object BaseGet(int index) { return default(object); }
    protected object BaseGet(string name) { return default(object); }
    protected System.String[] BaseGetAllKeys() { return default(System.String[]); }
    protected System.Object[] BaseGetAllValues() { return default(System.Object[]); }
    protected System.Object[] BaseGetAllValues(System.Type type) { return default(System.Object[]); }
    protected string BaseGetKey(int index) { return default(string); }
    protected bool BaseHasKeys() { return default(bool); }
    protected void BaseRemove(string name) { }
    protected void BaseRemoveAt(int index) { }
    protected void BaseSet(int index, object value) { }
    protected void BaseSet(string name, object value) { }
    public virtual System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public virtual void OnDeserialization(object sender) { }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    public partial class KeysCollection : System.Collections.ICollection, System.Collections.IEnumerable {
      internal KeysCollection() { }
      public int Count { get { return default(int); } }
      public string this[int index] { get { return default(string); } }
      bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
      object System.Collections.ICollection.SyncRoot { get { return default(object); } }
      public virtual string Get(int index) { return default(string); }
      public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
      void System.Collections.ICollection.CopyTo(System.Array array, int arrayIndex) { }
    }
  }
  public partial class NameValueCollection : System.Collections.Specialized.NameObjectCollectionBase {
    public NameValueCollection() { }
    public NameValueCollection(System.Collections.IEqualityComparer equalityComparer) { }
    [System.ObsoleteAttribute("Use NameValueCollection (IEqualityComparer)")]
    public NameValueCollection(System.Collections.IHashCodeProvider hashProvider, System.Collections.IComparer comparer) { }
    public NameValueCollection(System.Collections.Specialized.NameValueCollection col) { }
    public NameValueCollection(int capacity) { }
    public NameValueCollection(int capacity, System.Collections.IEqualityComparer equalityComparer) { }
    [System.ObsoleteAttribute("Use NameValueCollection (IEqualityComparer)")]
    public NameValueCollection(int capacity, System.Collections.IHashCodeProvider hashProvider, System.Collections.IComparer comparer) { }
    public NameValueCollection(int capacity, System.Collections.Specialized.NameValueCollection col) { }
    protected NameValueCollection(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public virtual System.String[] AllKeys { get { return default(System.String[]); } }
    public string this[int index] { get { return default(string); } }
    public string this[string name] { get { return default(string); } set { } }
    public void Add(System.Collections.Specialized.NameValueCollection c) { }
    public virtual void Add(string name, string value) { }
    public virtual void Clear() { }
    public void CopyTo(System.Array dest, int index) { }
    public virtual string Get(int index) { return default(string); }
    public virtual string Get(string name) { return default(string); }
    public virtual string GetKey(int index) { return default(string); }
    public virtual System.String[] GetValues(int index) { return default(System.String[]); }
    public virtual System.String[] GetValues(string name) { return default(System.String[]); }
    public bool HasKeys() { return default(bool); }
    protected void InvalidateCachedArrays() { }
    public virtual void Remove(string name) { }
    public virtual void Set(string name, string value) { }
  }
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("WindowsBase, Version=3.0.0.0, PublicKeyToken=31bf3856ad364e35")]
  public enum NotifyCollectionChangedAction {
    Add = 0,
    Move = 3,
    Remove = 1,
    Replace = 2,
    Reset = 4,
  }
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("WindowsBase, Version=3.0.0.0, PublicKeyToken=31bf3856ad364e35")]
  public partial class NotifyCollectionChangedEventArgs : System.EventArgs {
    public NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction action) { }
    public NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction action, System.Collections.IList changedItems) { }
    public NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction action, System.Collections.IList newItems, System.Collections.IList oldItems) { }
    public NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction action, System.Collections.IList newItems, System.Collections.IList oldItems, int startingIndex) { }
    public NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction action, System.Collections.IList changedItems, int startingIndex) { }
    public NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction action, System.Collections.IList changedItems, int index, int oldIndex) { }
    public NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction action, object changedItem) { }
    public NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction action, object changedItem, int index) { }
    public NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction action, object changedItem, int index, int oldIndex) { }
    public NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction action, object newItem, object oldItem) { }
    public NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction action, object newItem, object oldItem, int index) { }
    public System.Collections.Specialized.NotifyCollectionChangedAction Action { get { return default(System.Collections.Specialized.NotifyCollectionChangedAction); } }
    public System.Collections.IList NewItems { get { return default(System.Collections.IList); } }
    public int NewStartingIndex { get { return default(int); } }
    public System.Collections.IList OldItems { get { return default(System.Collections.IList); } }
    public int OldStartingIndex { get { return default(int); } }
  }
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("WindowsBase, Version=3.0.0.0, PublicKeyToken=31bf3856ad364e35")]
  public delegate void NotifyCollectionChangedEventHandler(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e);
  public partial class OrderedDictionary : System.Collections.ICollection, System.Collections.IDictionary, System.Collections.IEnumerable, System.Collections.Specialized.IOrderedDictionary, System.Runtime.Serialization.IDeserializationCallback, System.Runtime.Serialization.ISerializable {
    public OrderedDictionary() { }
    public OrderedDictionary(System.Collections.IEqualityComparer comparer) { }
    public OrderedDictionary(int capacity) { }
    public OrderedDictionary(int capacity, System.Collections.IEqualityComparer comparer) { }
    protected OrderedDictionary(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public int Count { get { return default(int); } }
    public bool IsReadOnly { get { return default(bool); } }
    public object this[int index] { get { return default(object); } set { } }
    public object this[object key] { get { return default(object); } set { } }
    public System.Collections.ICollection Keys { get { return default(System.Collections.ICollection); } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    bool System.Collections.IDictionary.IsFixedSize { get { return default(bool); } }
    public System.Collections.ICollection Values { get { return default(System.Collections.ICollection); } }
    public void Add(object key, object value) { }
    public System.Collections.Specialized.OrderedDictionary AsReadOnly() { return default(System.Collections.Specialized.OrderedDictionary); }
    public void Clear() { }
    public bool Contains(object key) { return default(bool); }
    public void CopyTo(System.Array array, int index) { }
    public virtual System.Collections.IDictionaryEnumerator GetEnumerator() { return default(System.Collections.IDictionaryEnumerator); }
    public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public void Insert(int index, object key, object value) { }
    protected virtual void OnDeserialization(object sender) { }
    public void Remove(object key) { }
    public void RemoveAt(int index) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
  }
  public partial class StringCollection : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList {
    public StringCollection() { }
    public int Count { get { return default(int); } }
    public bool IsReadOnly { get { return default(bool); } }
    public bool IsSynchronized { get { return default(bool); } }
    public string this[int index] { get { return default(string); } set { } }
    public object SyncRoot { get { return default(object); } }
    bool System.Collections.IList.IsFixedSize { get { return default(bool); } }
    bool System.Collections.IList.IsReadOnly { get { return default(bool); } }
    object System.Collections.IList.this[int index] { get { return default(object); } set { } }
    public int Add(string value) { return default(int); }
    public void AddRange(System.String[] value) { }
    public void Clear() { }
    public bool Contains(string value) { return default(bool); }
    public void CopyTo(System.String[] array, int index) { }
    public System.Collections.Specialized.StringEnumerator GetEnumerator() { return default(System.Collections.Specialized.StringEnumerator); }
    public int IndexOf(string value) { return default(int); }
    public void Insert(int index, string value) { }
    public void Remove(string value) { }
    public void RemoveAt(int index) { }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    int System.Collections.IList.Add(object value) { return default(int); }
    bool System.Collections.IList.Contains(object value) { return default(bool); }
    int System.Collections.IList.IndexOf(object value) { return default(int); }
    void System.Collections.IList.Insert(int index, object value) { }
    void System.Collections.IList.Remove(object value) { }
  }
  [System.ComponentModel.Design.Serialization.DesignerSerializerAttribute("System.Diagnostics.Design.StringDictionaryCodeDomSerializer, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.ComponentModel.Design.Serialization.CodeDomSerializer, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  public partial class StringDictionary : System.Collections.IEnumerable {
    public StringDictionary() { }
    public virtual int Count { get { return default(int); } }
    public virtual bool IsSynchronized { get { return default(bool); } }
    public virtual string this[string key] { get { return default(string); } set { } }
    public virtual System.Collections.ICollection Keys { get { return default(System.Collections.ICollection); } }
    public virtual object SyncRoot { get { return default(object); } }
    public virtual System.Collections.ICollection Values { get { return default(System.Collections.ICollection); } }
    public virtual void Add(string key, string value) { }
    public virtual void Clear() { }
    public virtual bool ContainsKey(string key) { return default(bool); }
    public virtual bool ContainsValue(string value) { return default(bool); }
    public virtual void CopyTo(System.Array array, int index) { }
    public virtual System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public virtual void Remove(string key) { }
  }
  public partial class StringEnumerator {
    internal StringEnumerator() { }
    public string Current { get { return default(string); } }
    public bool MoveNext() { return default(bool); }
    public void Reset() { }
  }
}
namespace System.ComponentModel {
  public partial class AddingNewEventArgs : System.EventArgs {
    public AddingNewEventArgs() { }
    public AddingNewEventArgs(object newObject) { }
    public object NewObject { get { return default(object); } set { } }
  }
  public delegate void AddingNewEventHandler(object sender, System.ComponentModel.AddingNewEventArgs e);
  [System.AttributeUsageAttribute((System.AttributeTargets)(32767))]
  public sealed partial class AmbientValueAttribute : System.Attribute {
    public AmbientValueAttribute(bool value) { }
    public AmbientValueAttribute(byte value) { }
    public AmbientValueAttribute(char value) { }
    public AmbientValueAttribute(double value) { }
    public AmbientValueAttribute(short value) { }
    public AmbientValueAttribute(int value) { }
    public AmbientValueAttribute(long value) { }
    public AmbientValueAttribute(object value) { }
    public AmbientValueAttribute(float value) { }
    public AmbientValueAttribute(string value) { }
    public AmbientValueAttribute(System.Type type, string value) { }
    public object Value { get { return default(object); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }
  public partial class ArrayConverter : System.ComponentModel.CollectionConverter {
    public ArrayConverter() { }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
    public override System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public override bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
  }
  public partial class AsyncCompletedEventArgs : System.EventArgs {
    public AsyncCompletedEventArgs(System.Exception error, bool cancelled, object userState) { }
    public bool Cancelled { get { return default(bool); } }
    public System.Exception Error { get { return default(System.Exception); } }
    public object UserState { get { return default(object); } }
    protected void RaiseExceptionIfNecessary() { }
  }
  public delegate void AsyncCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
  public sealed partial class AsyncOperation {
    internal AsyncOperation() { }
    public System.Threading.SynchronizationContext SynchronizationContext { get { return default(System.Threading.SynchronizationContext); } }
    public object UserSuppliedState { get { return default(object); } }
    ~AsyncOperation() { }
    public void OperationCompleted() { }
    public void Post(System.Threading.SendOrPostCallback d, object arg) { }
    public void PostOperationCompleted(System.Threading.SendOrPostCallback d, object arg) { }
  }
  public static partial class AsyncOperationManager {
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static System.Threading.SynchronizationContext SynchronizationContext { get { return default(System.Threading.SynchronizationContext); } set { } }
    public static System.ComponentModel.AsyncOperation CreateOperation(object userSuppliedState) { return default(System.ComponentModel.AsyncOperation); }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class AttributeCollection : System.Collections.ICollection, System.Collections.IEnumerable {
    public static readonly System.ComponentModel.AttributeCollection Empty;
    protected AttributeCollection() { }
    public AttributeCollection(params System.Attribute[] attributes) { }
    protected virtual System.Attribute[] Attributes { get { return default(System.Attribute[]); } }
    public int Count { get { return default(int); } }
    public virtual System.Attribute this[int index] { get { return default(System.Attribute); } }
    public virtual System.Attribute this[System.Type type] { get { return default(System.Attribute); } }
    int System.Collections.ICollection.Count { get { return default(int); } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    public bool Contains(System.Attribute attr) { return default(bool); }
    public bool Contains(System.Attribute[] attributes) { return default(bool); }
    public void CopyTo(System.Array array, int index) { }
    public static System.ComponentModel.AttributeCollection FromExisting(System.ComponentModel.AttributeCollection existing, params System.Attribute[] newAttributes) { return default(System.ComponentModel.AttributeCollection); }
    protected System.Attribute GetDefaultAttribute(System.Type attributeType) { return default(System.Attribute); }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public bool Matches(System.Attribute attr) { return default(bool); }
    public bool Matches(System.Attribute[] attributes) { return default(bool); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(128), AllowMultiple=false, Inherited=true)]
  public partial class AttributeProviderAttribute : System.Attribute {
    public AttributeProviderAttribute(string typeName) { }
    public AttributeProviderAttribute(string typeName, string propertyName) { }
    public AttributeProviderAttribute(System.Type type) { }
    public string PropertyName { get { return default(string); } }
    public string TypeName { get { return default(string); } }
  }
  [System.ComponentModel.DefaultEventAttribute("DoWork")]
  public partial class BackgroundWorker : System.ComponentModel.Component {
    public BackgroundWorker() { }
    [System.ComponentModel.BrowsableAttribute(false)]
    public bool CancellationPending { get { return default(bool); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public bool IsBusy { get { return default(bool); } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool WorkerReportsProgress { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool WorkerSupportsCancellation { get { return default(bool); } set { } }
    public event System.ComponentModel.DoWorkEventHandler DoWork { add { } remove { } }
    public event System.ComponentModel.ProgressChangedEventHandler ProgressChanged { add { } remove { } }
    public event System.ComponentModel.RunWorkerCompletedEventHandler RunWorkerCompleted { add { } remove { } }
    public void CancelAsync() { }
    protected virtual void OnDoWork(System.ComponentModel.DoWorkEventArgs e) { }
    protected virtual void OnProgressChanged(System.ComponentModel.ProgressChangedEventArgs e) { }
    protected virtual void OnRunWorkerCompleted(System.ComponentModel.RunWorkerCompletedEventArgs e) { }
    public void ReportProgress(int percentProgress) { }
    public void ReportProgress(int percentProgress, object userState) { }
    public void RunWorkerAsync() { }
    public void RunWorkerAsync(object argument) { }
  }
  public abstract partial class BaseNumberConverter : System.ComponentModel.TypeConverter {
    protected BaseNumberConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type t) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(32767))]
  public sealed partial class BindableAttribute : System.Attribute {
    public static readonly System.ComponentModel.BindableAttribute Default;
    public static readonly System.ComponentModel.BindableAttribute No;
    public static readonly System.ComponentModel.BindableAttribute Yes;
    public BindableAttribute(bool bindable) { }
    public BindableAttribute(bool bindable, System.ComponentModel.BindingDirection direction) { }
    public BindableAttribute(System.ComponentModel.BindableSupport flags) { }
    public BindableAttribute(System.ComponentModel.BindableSupport flags, System.ComponentModel.BindingDirection direction) { }
    public bool Bindable { get { return default(bool); } }
    public System.ComponentModel.BindingDirection Direction { get { return default(System.ComponentModel.BindingDirection); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool IsDefaultAttribute() { return default(bool); }
  }
  public enum BindableSupport {
    Default = 2,
    No = 0,
    Yes = 1,
  }
  public enum BindingDirection {
    OneWay = 0,
    TwoWay = 1,
  }
  public partial class BindingList<T> : System.Collections.ObjectModel.Collection<T>, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.ComponentModel.IBindingList, System.ComponentModel.ICancelAddNew, System.ComponentModel.IRaiseItemChangedEvents {
    public BindingList() { }
    public BindingList(System.Collections.Generic.IList<T> list) { }
    public bool AllowEdit { get { return default(bool); } set { } }
    public bool AllowNew { get { return default(bool); } set { } }
    public bool AllowRemove { get { return default(bool); } set { } }
    protected virtual bool IsSortedCore { get { return default(bool); } }
    public bool RaiseListChangedEvents { get { return default(bool); } set { } }
    protected virtual System.ComponentModel.ListSortDirection SortDirectionCore { get { return default(System.ComponentModel.ListSortDirection); } }
    protected virtual System.ComponentModel.PropertyDescriptor SortPropertyCore { get { return default(System.ComponentModel.PropertyDescriptor); } }
    protected virtual bool SupportsChangeNotificationCore { get { return default(bool); } }
    protected virtual bool SupportsSearchingCore { get { return default(bool); } }
    protected virtual bool SupportsSortingCore { get { return default(bool); } }
    bool System.ComponentModel.IBindingList.AllowEdit { get { return default(bool); } }
    bool System.ComponentModel.IBindingList.AllowNew { get { return default(bool); } }
    bool System.ComponentModel.IBindingList.AllowRemove { get { return default(bool); } }
    bool System.ComponentModel.IBindingList.IsSorted { get { return default(bool); } }
    System.ComponentModel.ListSortDirection System.ComponentModel.IBindingList.SortDirection { get { return default(System.ComponentModel.ListSortDirection); } }
    System.ComponentModel.PropertyDescriptor System.ComponentModel.IBindingList.SortProperty { get { return default(System.ComponentModel.PropertyDescriptor); } }
    bool System.ComponentModel.IBindingList.SupportsChangeNotification { get { return default(bool); } }
    bool System.ComponentModel.IBindingList.SupportsSearching { get { return default(bool); } }
    bool System.ComponentModel.IBindingList.SupportsSorting { get { return default(bool); } }
    bool System.ComponentModel.IRaiseItemChangedEvents.RaisesItemChangedEvents { get { return default(bool); } }
    public event System.ComponentModel.AddingNewEventHandler AddingNew { add { } remove { } }
    public event System.ComponentModel.ListChangedEventHandler ListChanged { add { } remove { } }
    public T AddNew() { return default(T); }
    protected virtual object AddNewCore() { return default(object); }
    protected virtual void ApplySortCore(System.ComponentModel.PropertyDescriptor prop, System.ComponentModel.ListSortDirection direction) { }
    public virtual void CancelNew(int itemIndex) { }
    protected override void ClearItems() { }
    public virtual void EndNew(int itemIndex) { }
    protected virtual int FindCore(System.ComponentModel.PropertyDescriptor prop, object key) { return default(int); }
    protected override void InsertItem(int index, T item) { }
    protected virtual void OnAddingNew(System.ComponentModel.AddingNewEventArgs e) { }
    protected virtual void OnListChanged(System.ComponentModel.ListChangedEventArgs e) { }
    protected override void RemoveItem(int index) { }
    protected virtual void RemoveSortCore() { }
    public void ResetBindings() { }
    public void ResetItem(int position) { }
    protected override void SetItem(int index, T item) { }
    void System.ComponentModel.IBindingList.AddIndex(System.ComponentModel.PropertyDescriptor index) { }
    object System.ComponentModel.IBindingList.AddNew() { return default(object); }
    void System.ComponentModel.IBindingList.ApplySort(System.ComponentModel.PropertyDescriptor property, System.ComponentModel.ListSortDirection direction) { }
    int System.ComponentModel.IBindingList.Find(System.ComponentModel.PropertyDescriptor property, object key) { return default(int); }
    void System.ComponentModel.IBindingList.RemoveIndex(System.ComponentModel.PropertyDescriptor property) { }
    void System.ComponentModel.IBindingList.RemoveSort() { }
  }
  public partial class BooleanConverter : System.ComponentModel.TypeConverter {
    public BooleanConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { return default(System.ComponentModel.TypeConverter.StandardValuesCollection); }
    public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(32767))]
  public sealed partial class BrowsableAttribute : System.Attribute {
    public static readonly System.ComponentModel.BrowsableAttribute Default;
    public static readonly System.ComponentModel.BrowsableAttribute No;
    public static readonly System.ComponentModel.BrowsableAttribute Yes;
    public BrowsableAttribute(bool browsable) { }
    public bool Browsable { get { return default(bool); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool IsDefaultAttribute() { return default(bool); }
  }
  public partial class ByteConverter : System.ComponentModel.BaseNumberConverter {
    public ByteConverter() { }
  }
  public partial class CancelEventArgs : System.EventArgs {
    public CancelEventArgs() { }
    public CancelEventArgs(bool cancel) { }
    public bool Cancel { get { return default(bool); } set { } }
  }
  public delegate void CancelEventHandler(object sender, System.ComponentModel.CancelEventArgs e);
  [System.AttributeUsageAttribute((System.AttributeTargets)(32767))]
  public partial class CategoryAttribute : System.Attribute {
    public CategoryAttribute() { }
    public CategoryAttribute(string category) { }
    public static System.ComponentModel.CategoryAttribute Action { get { return default(System.ComponentModel.CategoryAttribute); } }
    public static System.ComponentModel.CategoryAttribute Appearance { get { return default(System.ComponentModel.CategoryAttribute); } }
    public static System.ComponentModel.CategoryAttribute Asynchronous { get { return default(System.ComponentModel.CategoryAttribute); } }
    public static System.ComponentModel.CategoryAttribute Behavior { get { return default(System.ComponentModel.CategoryAttribute); } }
    public string Category { get { return default(string); } }
    public static System.ComponentModel.CategoryAttribute Data { get { return default(System.ComponentModel.CategoryAttribute); } }
    public static System.ComponentModel.CategoryAttribute Default { get { return default(System.ComponentModel.CategoryAttribute); } }
    public static System.ComponentModel.CategoryAttribute Design { get { return default(System.ComponentModel.CategoryAttribute); } }
    public static System.ComponentModel.CategoryAttribute DragDrop { get { return default(System.ComponentModel.CategoryAttribute); } }
    public static System.ComponentModel.CategoryAttribute Focus { get { return default(System.ComponentModel.CategoryAttribute); } }
    public static System.ComponentModel.CategoryAttribute Format { get { return default(System.ComponentModel.CategoryAttribute); } }
    public static System.ComponentModel.CategoryAttribute Key { get { return default(System.ComponentModel.CategoryAttribute); } }
    public static System.ComponentModel.CategoryAttribute Layout { get { return default(System.ComponentModel.CategoryAttribute); } }
    public static System.ComponentModel.CategoryAttribute Mouse { get { return default(System.ComponentModel.CategoryAttribute); } }
    public static System.ComponentModel.CategoryAttribute WindowStyle { get { return default(System.ComponentModel.CategoryAttribute); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    protected virtual string GetLocalizedString(string value) { return default(string); }
    public override bool IsDefaultAttribute() { return default(bool); }
  }
  public partial class CharConverter : System.ComponentModel.TypeConverter {
    public CharConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
  }
  public enum CollectionChangeAction {
    Add = 1,
    Refresh = 3,
    Remove = 2,
  }
  public partial class CollectionChangeEventArgs : System.EventArgs {
    public CollectionChangeEventArgs(System.ComponentModel.CollectionChangeAction action, object element) { }
    public virtual System.ComponentModel.CollectionChangeAction Action { get { return default(System.ComponentModel.CollectionChangeAction); } }
    public virtual object Element { get { return default(object); } }
  }
  public delegate void CollectionChangeEventHandler(object sender, System.ComponentModel.CollectionChangeEventArgs e);
  public partial class CollectionConverter : System.ComponentModel.TypeConverter {
    public CollectionConverter() { }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
    public override System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public override bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false, Inherited=true)]
  public sealed partial class ComplexBindingPropertiesAttribute : System.Attribute {
    public static readonly System.ComponentModel.ComplexBindingPropertiesAttribute Default;
    public ComplexBindingPropertiesAttribute() { }
    public ComplexBindingPropertiesAttribute(string dataSource) { }
    public ComplexBindingPropertiesAttribute(string dataSource, string dataMember) { }
    public string DataMember { get { return default(string); } }
    public string DataSource { get { return default(string); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }
  [System.ComponentModel.DesignerCategoryAttribute("Component")]
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class Component : System.MarshalByRefObject, System.ComponentModel.IComponent, System.IDisposable {
    public Component() { }
    protected virtual bool CanRaiseEvents { get { return default(bool); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.ComponentModel.IContainer Container { get { return default(System.ComponentModel.IContainer); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    protected bool DesignMode { get { return default(bool); } }
    protected System.ComponentModel.EventHandlerList Events { get { return default(System.ComponentModel.EventHandlerList); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public virtual System.ComponentModel.ISite Site { get { return default(System.ComponentModel.ISite); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public event System.EventHandler Disposed { add { } remove { } }
    public void Dispose() { }
    protected virtual void Dispose(bool release_all) { }
    ~Component() { }
    protected virtual object GetService(System.Type service) { return default(object); }
    public override string ToString() { return default(string); }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class ComponentCollection : System.Collections.ReadOnlyCollectionBase {
    public ComponentCollection(System.ComponentModel.IComponent[] components) { }
    public virtual System.ComponentModel.IComponent this[int index] { get { return default(System.ComponentModel.IComponent); } }
    public virtual System.ComponentModel.IComponent this[string name] { get { return default(System.ComponentModel.IComponent); } }
    public void CopyTo(System.ComponentModel.IComponent[] array, int index) { }
  }
  public partial class ComponentConverter : System.ComponentModel.ReferenceConverter {
    public ComponentConverter(System.Type type) : base (default(System.Type)) { }
    public override System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public override bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
  }
  public abstract partial class ComponentEditor {
    protected ComponentEditor() { }
    public abstract bool EditComponent(System.ComponentModel.ITypeDescriptorContext context, object component);
    public bool EditComponent(object component) { return default(bool); }
  }
  public partial class ComponentResourceManager : System.Resources.ResourceManager {
    public ComponentResourceManager() { }
    public ComponentResourceManager(System.Type t) { }
    public void ApplyResources(object value, string objectName) { }
    public virtual void ApplyResources(object value, string objectName, System.Globalization.CultureInfo culture) { }
  }
  public partial class Container : System.ComponentModel.IContainer, System.IDisposable {
    public Container() { }
    public virtual System.ComponentModel.ComponentCollection Components { get { return default(System.ComponentModel.ComponentCollection); } }
    public virtual void Add(System.ComponentModel.IComponent component) { }
    public virtual void Add(System.ComponentModel.IComponent component, string name) { }
    protected virtual System.ComponentModel.ISite CreateSite(System.ComponentModel.IComponent component, string name) { return default(System.ComponentModel.ISite); }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    ~Container() { }
    protected virtual object GetService(System.Type service) { return default(object); }
    public virtual void Remove(System.ComponentModel.IComponent component) { }
    protected void RemoveWithoutUnsiting(System.ComponentModel.IComponent component) { }
    protected virtual void ValidateName(System.ComponentModel.IComponent component, string name) { }
  }
  public abstract partial class ContainerFilterService {
    protected ContainerFilterService() { }
    public virtual System.ComponentModel.ComponentCollection FilterComponents(System.ComponentModel.ComponentCollection components) { return default(System.ComponentModel.ComponentCollection); }
  }
  public partial class CultureInfoConverter : System.ComponentModel.TypeConverter {
    public CultureInfoConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
    protected virtual string GetCultureName(System.Globalization.CultureInfo culture) { return default(string); }
    public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { return default(System.ComponentModel.TypeConverter.StandardValuesCollection); }
    public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
  }
  public abstract partial class CustomTypeDescriptor : System.ComponentModel.ICustomTypeDescriptor {
    protected CustomTypeDescriptor() { }
    protected CustomTypeDescriptor(System.ComponentModel.ICustomTypeDescriptor parent) { }
    public virtual System.ComponentModel.AttributeCollection GetAttributes() { return default(System.ComponentModel.AttributeCollection); }
    public virtual string GetClassName() { return default(string); }
    public virtual string GetComponentName() { return default(string); }
    public virtual System.ComponentModel.TypeConverter GetConverter() { return default(System.ComponentModel.TypeConverter); }
    public virtual System.ComponentModel.EventDescriptor GetDefaultEvent() { return default(System.ComponentModel.EventDescriptor); }
    public virtual System.ComponentModel.PropertyDescriptor GetDefaultProperty() { return default(System.ComponentModel.PropertyDescriptor); }
    public virtual object GetEditor(System.Type editorBaseType) { return default(object); }
    public virtual System.ComponentModel.EventDescriptorCollection GetEvents() { return default(System.ComponentModel.EventDescriptorCollection); }
    public virtual System.ComponentModel.EventDescriptorCollection GetEvents(System.Attribute[] attributes) { return default(System.ComponentModel.EventDescriptorCollection); }
    public virtual System.ComponentModel.PropertyDescriptorCollection GetProperties() { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public virtual System.ComponentModel.PropertyDescriptorCollection GetProperties(System.Attribute[] attributes) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public virtual object GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd) { return default(object); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
  public sealed partial class DataObjectAttribute : System.Attribute {
    public static readonly System.ComponentModel.DataObjectAttribute DataObject;
    public static readonly System.ComponentModel.DataObjectAttribute Default;
    public static readonly System.ComponentModel.DataObjectAttribute NonDataObject;
    public DataObjectAttribute() { }
    public DataObjectAttribute(bool isDataObject) { }
    public bool IsDataObject { get { return default(bool); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool IsDefaultAttribute() { return default(bool); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(128))]
  public sealed partial class DataObjectFieldAttribute : System.Attribute {
    public DataObjectFieldAttribute(bool primaryKey) { }
    public DataObjectFieldAttribute(bool primaryKey, bool isIdentity) { }
    public DataObjectFieldAttribute(bool primaryKey, bool isIdentity, bool isNullable) { }
    public DataObjectFieldAttribute(bool primaryKey, bool isIdentity, bool isNullable, int length) { }
    public bool IsIdentity { get { return default(bool); } }
    public bool IsNullable { get { return default(bool); } }
    public int Length { get { return default(int); } }
    public bool PrimaryKey { get { return default(bool); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(64))]
  public sealed partial class DataObjectMethodAttribute : System.Attribute {
    public DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType methodType) { }
    public DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType methodType, bool isDefault) { }
    public bool IsDefault { get { return default(bool); } }
    public System.ComponentModel.DataObjectMethodType MethodType { get { return default(System.ComponentModel.DataObjectMethodType); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool Match(object obj) { return default(bool); }
  }
  public enum DataObjectMethodType {
    Delete = 4,
    Fill = 0,
    Insert = 3,
    Select = 1,
    Update = 2,
  }
  public partial class DateTimeConverter : System.ComponentModel.TypeConverter {
    public DateTimeConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
  }
  public partial class DateTimeOffsetConverter : System.ComponentModel.TypeConverter {
    public DateTimeOffsetConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
  }
  public partial class DecimalConverter : System.ComponentModel.BaseNumberConverter {
    public DecimalConverter() { }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
  public sealed partial class DefaultBindingPropertyAttribute : System.Attribute {
    public static readonly System.ComponentModel.DefaultBindingPropertyAttribute Default;
    public DefaultBindingPropertyAttribute() { }
    public DefaultBindingPropertyAttribute(string name) { }
    public string Name { get { return default(string); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
  public sealed partial class DefaultEventAttribute : System.Attribute {
    public static readonly System.ComponentModel.DefaultEventAttribute Default;
    public DefaultEventAttribute(string name) { }
    public string Name { get { return default(string); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
  public sealed partial class DefaultPropertyAttribute : System.Attribute {
    public static readonly System.ComponentModel.DefaultPropertyAttribute Default;
    public DefaultPropertyAttribute(string name) { }
    public string Name { get { return default(string); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(32767))]
  public partial class DefaultValueAttribute : System.Attribute {
    public DefaultValueAttribute(bool value) { }
    public DefaultValueAttribute(byte value) { }
    public DefaultValueAttribute(char value) { }
    public DefaultValueAttribute(double value) { }
    public DefaultValueAttribute(short value) { }
    public DefaultValueAttribute(int value) { }
    public DefaultValueAttribute(long value) { }
    public DefaultValueAttribute(object value) { }
    public DefaultValueAttribute(float value) { }
    public DefaultValueAttribute(string value) { }
    public DefaultValueAttribute(System.Type type, string value) { }
    public virtual object Value { get { return default(object); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    protected void SetValue(object value) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(32767))]
  public partial class DescriptionAttribute : System.Attribute {
    public static readonly System.ComponentModel.DescriptionAttribute Default;
    public DescriptionAttribute() { }
    public DescriptionAttribute(string description) { }
    public virtual string Description { get { return default(string); } }
    protected string DescriptionValue { get { return default(string); } set { } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool IsDefaultAttribute() { return default(bool); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(1028), AllowMultiple=true, Inherited=true)]
  public sealed partial class DesignerAttribute : System.Attribute {
    public DesignerAttribute(string designerTypeName) { }
    public DesignerAttribute(string designerTypeName, string designerBaseTypeName) { }
    public DesignerAttribute(string designerTypeName, System.Type designerBaseType) { }
    public DesignerAttribute(System.Type designerType) { }
    public DesignerAttribute(System.Type designerType, System.Type designerBaseType) { }
    public string DesignerBaseTypeName { get { return default(string); } }
    public string DesignerTypeName { get { return default(string); } }
    public override object TypeId { get { return default(object); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
  public sealed partial class DesignerCategoryAttribute : System.Attribute {
    public static readonly System.ComponentModel.DesignerCategoryAttribute Component;
    public static readonly System.ComponentModel.DesignerCategoryAttribute Default;
    public static readonly System.ComponentModel.DesignerCategoryAttribute Form;
    public static readonly System.ComponentModel.DesignerCategoryAttribute Generic;
    public DesignerCategoryAttribute() { }
    public DesignerCategoryAttribute(string category) { }
    public string Category { get { return default(string); } }
    public override object TypeId { get { return default(object); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool IsDefaultAttribute() { return default(bool); }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public enum DesignerSerializationVisibility {
    Content = 2,
    Hidden = 0,
    Visible = 1,
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(960))]
  public sealed partial class DesignerSerializationVisibilityAttribute : System.Attribute {
    public static readonly System.ComponentModel.DesignerSerializationVisibilityAttribute Content;
    public static readonly System.ComponentModel.DesignerSerializationVisibilityAttribute Default;
    public static readonly System.ComponentModel.DesignerSerializationVisibilityAttribute Hidden;
    public static readonly System.ComponentModel.DesignerSerializationVisibilityAttribute Visible;
    public DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility vis) { }
    public System.ComponentModel.DesignerSerializationVisibility Visibility { get { return default(System.ComponentModel.DesignerSerializationVisibility); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool IsDefaultAttribute() { return default(bool); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(32767))]
  public sealed partial class DesignOnlyAttribute : System.Attribute {
    public static readonly System.ComponentModel.DesignOnlyAttribute Default;
    public static readonly System.ComponentModel.DesignOnlyAttribute No;
    public static readonly System.ComponentModel.DesignOnlyAttribute Yes;
    public DesignOnlyAttribute(bool design_only) { }
    public bool IsDesignOnly { get { return default(bool); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool IsDefaultAttribute() { return default(bool); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(1028))]
  public sealed partial class DesignTimeVisibleAttribute : System.Attribute {
    public static readonly System.ComponentModel.DesignTimeVisibleAttribute Default;
    public static readonly System.ComponentModel.DesignTimeVisibleAttribute No;
    public static readonly System.ComponentModel.DesignTimeVisibleAttribute Yes;
    public DesignTimeVisibleAttribute() { }
    public DesignTimeVisibleAttribute(bool visible) { }
    public bool Visible { get { return default(bool); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool IsDefaultAttribute() { return default(bool); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(708))]
  public partial class DisplayNameAttribute : System.Attribute {
    public static readonly System.ComponentModel.DisplayNameAttribute Default;
    public DisplayNameAttribute() { }
    public DisplayNameAttribute(string displayName) { }
    public virtual string DisplayName { get { return default(string); } }
    protected string DisplayNameValue { get { return default(string); } set { } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool IsDefaultAttribute() { return default(bool); }
  }
  public partial class DoubleConverter : System.ComponentModel.BaseNumberConverter {
    public DoubleConverter() { }
  }
  public partial class DoWorkEventArgs : System.ComponentModel.CancelEventArgs {
    public DoWorkEventArgs(object argument) { }
    public object Argument { get { return default(object); } }
    public object Result { get { return default(object); } set { } }
  }
  public delegate void DoWorkEventHandler(object sender, System.ComponentModel.DoWorkEventArgs e);
  [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true, Inherited=true)]
  public sealed partial class EditorAttribute : System.Attribute {
    public EditorAttribute() { }
    public EditorAttribute(string typeName, string baseTypeName) { }
    public EditorAttribute(string typeName, System.Type baseType) { }
    public EditorAttribute(System.Type type, System.Type baseType) { }
    public string EditorBaseTypeName { get { return default(string); } }
    public string EditorTypeName { get { return default(string); } }
    public override object TypeId { get { return default(object); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(6140))]
  public sealed partial class EditorBrowsableAttribute : System.Attribute {
    public EditorBrowsableAttribute() { }
    public EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState state) { }
    public System.ComponentModel.EditorBrowsableState State { get { return default(System.ComponentModel.EditorBrowsableState); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }
  public enum EditorBrowsableState {
    Advanced = 2,
    Always = 0,
    Never = 1,
  }
  public partial class EnumConverter : System.ComponentModel.TypeConverter {
    public EnumConverter(System.Type type) { }
    protected virtual System.Collections.IComparer Comparer { get { return default(System.Collections.IComparer); } }
    protected System.Type EnumType { get { return default(System.Type); } }
    protected System.ComponentModel.TypeConverter.StandardValuesCollection Values { get { return default(System.ComponentModel.TypeConverter.StandardValuesCollection); } set { } }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
    public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { return default(System.ComponentModel.TypeConverter.StandardValuesCollection); }
    public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public override bool IsValid(System.ComponentModel.ITypeDescriptorContext context, object value) { return default(bool); }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public abstract partial class EventDescriptor : System.ComponentModel.MemberDescriptor {
    protected EventDescriptor(System.ComponentModel.MemberDescriptor desc) : base (default(string), default(System.Attribute[])) { }
    protected EventDescriptor(System.ComponentModel.MemberDescriptor desc, System.Attribute[] attrs) : base (default(string), default(System.Attribute[])) { }
    protected EventDescriptor(string str, System.Attribute[] attrs) : base (default(string), default(System.Attribute[])) { }
    public abstract System.Type ComponentType { get; }
    public abstract System.Type EventType { get; }
    public abstract bool IsMulticast { get; }
    public abstract void AddEventHandler(object component, System.Delegate value);
    public abstract void RemoveEventHandler(object component, System.Delegate value);
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class EventDescriptorCollection : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList {
    public static readonly System.ComponentModel.EventDescriptorCollection Empty;
    public EventDescriptorCollection(System.ComponentModel.EventDescriptor[] events) { }
    public EventDescriptorCollection(System.ComponentModel.EventDescriptor[] events, bool readOnly) { }
    public int Count { get { return default(int); } }
    public virtual System.ComponentModel.EventDescriptor this[int index] { get { return default(System.ComponentModel.EventDescriptor); } }
    public virtual System.ComponentModel.EventDescriptor this[string name] { get { return default(System.ComponentModel.EventDescriptor); } }
    int System.Collections.ICollection.Count { get { return default(int); } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    bool System.Collections.IList.IsFixedSize { get { return default(bool); } }
    bool System.Collections.IList.IsReadOnly { get { return default(bool); } }
    object System.Collections.IList.this[int index] { get { return default(object); } set { } }
    public int Add(System.ComponentModel.EventDescriptor value) { return default(int); }
    public void Clear() { }
    public bool Contains(System.ComponentModel.EventDescriptor value) { return default(bool); }
    public virtual System.ComponentModel.EventDescriptor Find(string name, bool ignoreCase) { return default(System.ComponentModel.EventDescriptor); }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public int IndexOf(System.ComponentModel.EventDescriptor value) { return default(int); }
    public void Insert(int index, System.ComponentModel.EventDescriptor value) { }
    protected void InternalSort(System.Collections.IComparer comparer) { }
    protected void InternalSort(System.String[] order) { }
    public void Remove(System.ComponentModel.EventDescriptor value) { }
    public void RemoveAt(int index) { }
    public virtual System.ComponentModel.EventDescriptorCollection Sort() { return default(System.ComponentModel.EventDescriptorCollection); }
    public virtual System.ComponentModel.EventDescriptorCollection Sort(System.Collections.IComparer comparer) { return default(System.ComponentModel.EventDescriptorCollection); }
    public virtual System.ComponentModel.EventDescriptorCollection Sort(System.String[] order) { return default(System.ComponentModel.EventDescriptorCollection); }
    public virtual System.ComponentModel.EventDescriptorCollection Sort(System.String[] order, System.Collections.IComparer comparer) { return default(System.ComponentModel.EventDescriptorCollection); }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    int System.Collections.IList.Add(object value) { return default(int); }
    void System.Collections.IList.Clear() { }
    bool System.Collections.IList.Contains(object value) { return default(bool); }
    int System.Collections.IList.IndexOf(object value) { return default(int); }
    void System.Collections.IList.Insert(int index, object value) { }
    void System.Collections.IList.Remove(object value) { }
    void System.Collections.IList.RemoveAt(int index) { }
  }
  public sealed partial class EventHandlerList : System.IDisposable {
    public EventHandlerList() { }
    public System.Delegate this[object key] { get { return default(System.Delegate); } set { } }
    public void AddHandler(object key, System.Delegate value) { }
    public void AddHandlers(System.ComponentModel.EventHandlerList listToAddFrom) { }
    public void Dispose() { }
    public void RemoveHandler(object key, System.Delegate value) { }
  }
  public partial class ExpandableObjectConverter : System.ComponentModel.TypeConverter {
    public ExpandableObjectConverter() { }
    public override System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public override bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(32767))]
  public sealed partial class ExtenderProvidedPropertyAttribute : System.Attribute {
    public ExtenderProvidedPropertyAttribute() { }
    public System.ComponentModel.PropertyDescriptor ExtenderProperty { get { return default(System.ComponentModel.PropertyDescriptor); } }
    public System.ComponentModel.IExtenderProvider Provider { get { return default(System.ComponentModel.IExtenderProvider); } }
    public System.Type ReceiverType { get { return default(System.Type); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool IsDefaultAttribute() { return default(bool); }
  }
  public partial class GuidConverter : System.ComponentModel.TypeConverter {
    public GuidConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
  }
  public partial class HandledEventArgs : System.EventArgs {
    public HandledEventArgs() { }
    public HandledEventArgs(bool defaultHandledValue) { }
    public bool Handled { get { return default(bool); } set { } }
  }
  public delegate void HandledEventHandler(object sender, System.ComponentModel.HandledEventArgs e);
  public partial interface IBindingList : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList {
    bool AllowEdit { get; }
    bool AllowNew { get; }
    bool AllowRemove { get; }
    bool IsSorted { get; }
    System.ComponentModel.ListSortDirection SortDirection { get; }
    System.ComponentModel.PropertyDescriptor SortProperty { get; }
    bool SupportsChangeNotification { get; }
    bool SupportsSearching { get; }
    bool SupportsSorting { get; }
    event System.ComponentModel.ListChangedEventHandler ListChanged;
    void AddIndex(System.ComponentModel.PropertyDescriptor property);
    object AddNew();
    void ApplySort(System.ComponentModel.PropertyDescriptor property, System.ComponentModel.ListSortDirection direction);
    int Find(System.ComponentModel.PropertyDescriptor property, object key);
    void RemoveIndex(System.ComponentModel.PropertyDescriptor property);
    void RemoveSort();
  }
  public partial interface IBindingListView : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.ComponentModel.IBindingList {
    string Filter { get; set; }
    System.ComponentModel.ListSortDescriptionCollection SortDescriptions { get; }
    bool SupportsAdvancedSorting { get; }
    bool SupportsFiltering { get; }
    void ApplySort(System.ComponentModel.ListSortDescriptionCollection sorts);
    void RemoveFilter();
  }
  public partial interface ICancelAddNew {
    void CancelNew(int itemIndex);
    void EndNew(int itemIndex);
  }
  public partial interface IChangeTracking {
    bool IsChanged { get; }
    void AcceptChanges();
  }
  [System.ObsoleteAttribute("Use TypeDescriptionProvider and TypeDescriptor.ComObjectType instead")]
  public partial interface IComNativeDescriptorHandler {
    System.ComponentModel.AttributeCollection GetAttributes(object component);
    string GetClassName(object component);
    System.ComponentModel.TypeConverter GetConverter(object component);
    System.ComponentModel.EventDescriptor GetDefaultEvent(object component);
    System.ComponentModel.PropertyDescriptor GetDefaultProperty(object component);
    object GetEditor(object component, System.Type baseEditorType);
    System.ComponentModel.EventDescriptorCollection GetEvents(object component);
    System.ComponentModel.EventDescriptorCollection GetEvents(object component, System.Attribute[] attributes);
    string GetName(object component);
    System.ComponentModel.PropertyDescriptorCollection GetProperties(object component, System.Attribute[] attributes);
    object GetPropertyValue(object component, int dispid, ref bool success);
    object GetPropertyValue(object component, string propertyName, ref bool success);
  }
  [System.ComponentModel.Design.Serialization.RootDesignerSerializerAttribute("System.ComponentModel.Design.Serialization.RootCodeDomSerializer, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.ComponentModel.Design.Serialization.CodeDomSerializer, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", true)]
  [System.ComponentModel.DesignerAttribute("System.ComponentModel.Design.ComponentDesigner, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(System.ComponentModel.Design.IDesigner))]
  [System.ComponentModel.DesignerAttribute("System.Windows.Forms.Design.ComponentDocumentDesigner, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(System.ComponentModel.Design.IRootDesigner))]
  [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.ComponentConverter))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial interface IComponent : System.IDisposable {
    System.ComponentModel.ISite Site { get; set; }
    event System.EventHandler Disposed;
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial interface IContainer : System.IDisposable {
    System.ComponentModel.ComponentCollection Components { get; }
    void Add(System.ComponentModel.IComponent component);
    void Add(System.ComponentModel.IComponent component, string name);
    void Remove(System.ComponentModel.IComponent component);
  }
  public partial interface ICustomTypeDescriptor {
    System.ComponentModel.AttributeCollection GetAttributes();
    string GetClassName();
    string GetComponentName();
    System.ComponentModel.TypeConverter GetConverter();
    System.ComponentModel.EventDescriptor GetDefaultEvent();
    System.ComponentModel.PropertyDescriptor GetDefaultProperty();
    object GetEditor(System.Type editorBaseType);
    System.ComponentModel.EventDescriptorCollection GetEvents();
    System.ComponentModel.EventDescriptorCollection GetEvents(System.Attribute[] arr);
    System.ComponentModel.PropertyDescriptorCollection GetProperties();
    System.ComponentModel.PropertyDescriptorCollection GetProperties(System.Attribute[] arr);
    object GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd);
  }
  public partial interface IDataErrorInfo {
    string Error { get; }
    string this[string columnName] { get; }
  }
  public partial interface IEditableObject {
    void BeginEdit();
    void CancelEdit();
    void EndEdit();
  }
  public partial interface IExtenderProvider {
    bool CanExtend(object extendee);
  }
  public partial interface IIntellisenseBuilder {
    string Name { get; }
    bool Show(string language, string value, ref string newValue);
  }
  [System.ComponentModel.MergablePropertyAttribute(false)]
  [System.ComponentModel.TypeConverterAttribute("System.Windows.Forms.Design.DataSourceConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  public partial interface IListSource {
    bool ContainsListCollection { get; }
    System.Collections.IList GetList();
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(32767))]
  public sealed partial class ImmutableObjectAttribute : System.Attribute {
    public static readonly System.ComponentModel.ImmutableObjectAttribute Default;
    public static readonly System.ComponentModel.ImmutableObjectAttribute No;
    public static readonly System.ComponentModel.ImmutableObjectAttribute Yes;
    public ImmutableObjectAttribute(bool immutable) { }
    public bool Immutable { get { return default(bool); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool IsDefaultAttribute() { return default(bool); }
  }
  public partial interface INestedContainer : System.ComponentModel.IContainer, System.IDisposable {
    System.ComponentModel.IComponent Owner { get; }
  }
  public partial interface INestedSite : System.ComponentModel.ISite, System.IServiceProvider {
    string FullName { get; }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(896))]
  public sealed partial class InheritanceAttribute : System.Attribute {
    public static readonly System.ComponentModel.InheritanceAttribute Default;
    public static readonly System.ComponentModel.InheritanceAttribute Inherited;
    public static readonly System.ComponentModel.InheritanceAttribute InheritedReadOnly;
    public static readonly System.ComponentModel.InheritanceAttribute NotInherited;
    public InheritanceAttribute() { }
    public InheritanceAttribute(System.ComponentModel.InheritanceLevel inheritanceLevel) { }
    public System.ComponentModel.InheritanceLevel InheritanceLevel { get { return default(System.ComponentModel.InheritanceLevel); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool IsDefaultAttribute() { return default(bool); }
    public override string ToString() { return default(string); }
  }
  public enum InheritanceLevel {
    Inherited = 1,
    InheritedReadOnly = 2,
    NotInherited = 3,
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
  public sealed partial class InitializationEventAttribute : System.Attribute {
    public InitializationEventAttribute(string eventName) { }
    public string EventName { get { return default(string); } }
  }
  public partial interface INotifyPropertyChanged {
    event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
  }
  public partial interface INotifyPropertyChanging {
    event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
  public partial class InstallerTypeAttribute : System.Attribute {
    public InstallerTypeAttribute(string typeName) { }
    public InstallerTypeAttribute(System.Type installerType) { }
    public virtual System.Type InstallerType { get { return default(System.Type); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }
  public abstract partial class InstanceCreationEditor {
    protected InstanceCreationEditor() { }
    public virtual string Text { get { return default(string); } }
    public abstract object CreateInstance(System.ComponentModel.ITypeDescriptorContext context, System.Type type);
  }
  public partial class Int16Converter : System.ComponentModel.BaseNumberConverter {
    public Int16Converter() { }
  }
  public partial class Int32Converter : System.ComponentModel.BaseNumberConverter {
    public Int32Converter() { }
  }
  public partial class Int64Converter : System.ComponentModel.BaseNumberConverter {
    public Int64Converter() { }
  }
  public partial class InvalidAsynchronousStateException : System.ArgumentException {
    public InvalidAsynchronousStateException() { }
    protected InvalidAsynchronousStateException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public InvalidAsynchronousStateException(string message) { }
    public InvalidAsynchronousStateException(string message, System.Exception innerException) { }
  }
  public partial class InvalidEnumArgumentException : System.ArgumentException {
    public InvalidEnumArgumentException() { }
    protected InvalidEnumArgumentException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public InvalidEnumArgumentException(string message) { }
    public InvalidEnumArgumentException(string message, System.Exception innerException) { }
    public InvalidEnumArgumentException(string argumentName, int invalidValue, System.Type enumClass) { }
  }
  public partial interface IRaiseItemChangedEvents {
    bool RaisesItemChangedEvents { get; }
  }
  public partial interface IRevertibleChangeTracking : System.ComponentModel.IChangeTracking {
    void RejectChanges();
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial interface ISite : System.IServiceProvider {
    System.ComponentModel.IComponent Component { get; }
    System.ComponentModel.IContainer Container { get; }
    bool DesignMode { get; }
    string Name { get; set; }
  }
  public partial interface ISupportInitialize {
    void BeginInit();
    void EndInit();
  }
  public partial interface ISupportInitializeNotification : System.ComponentModel.ISupportInitialize {
    bool IsInitialized { get; }
    event System.EventHandler Initialized;
  }
  public partial interface ISynchronizeInvoke {
    bool InvokeRequired { get; }
    System.IAsyncResult BeginInvoke(System.Delegate method, System.Object[] args);
    object EndInvoke(System.IAsyncResult result);
    object Invoke(System.Delegate method, System.Object[] args);
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial interface ITypeDescriptorContext : System.IServiceProvider {
    System.ComponentModel.IContainer Container { get; }
    object Instance { get; }
    System.ComponentModel.PropertyDescriptor PropertyDescriptor { get; }
    void OnComponentChanged();
    bool OnComponentChanging();
  }
  public partial interface ITypedList {
    System.ComponentModel.PropertyDescriptorCollection GetItemProperties(System.ComponentModel.PropertyDescriptor[] listAccessors);
    string GetListName(System.ComponentModel.PropertyDescriptor[] listAccessors);
  }
  public abstract partial class License : System.IDisposable {
    protected License() { }
    public abstract string LicenseKey { get; }
    public abstract void Dispose();
  }
  public partial class LicenseContext : System.IServiceProvider {
    public LicenseContext() { }
    public virtual System.ComponentModel.LicenseUsageMode UsageMode { get { return default(System.ComponentModel.LicenseUsageMode); } }
    public virtual string GetSavedLicenseKey(System.Type type, System.Reflection.Assembly resourceAssembly) { return default(string); }
    public virtual object GetService(System.Type type) { return default(object); }
    public virtual void SetSavedLicenseKey(System.Type type, string key) { }
  }
  public partial class LicenseException : System.SystemException {
    protected LicenseException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public LicenseException(System.Type type) { }
    public LicenseException(System.Type type, object instance) { }
    public LicenseException(System.Type type, object instance, string message) { }
    public LicenseException(System.Type type, object instance, string message, System.Exception innerException) { }
    public System.Type LicensedType { get { return default(System.Type); } }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, SerializationFormatter=true)]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public sealed partial class LicenseManager {
    internal LicenseManager() { }
    public static System.ComponentModel.LicenseContext CurrentContext { get { return default(System.ComponentModel.LicenseContext); } set { } }
    public static System.ComponentModel.LicenseUsageMode UsageMode { get { return default(System.ComponentModel.LicenseUsageMode); } }
    public static object CreateWithContext(System.Type type, System.ComponentModel.LicenseContext creationContext) { return default(object); }
    public static object CreateWithContext(System.Type type, System.ComponentModel.LicenseContext creationContext, System.Object[] args) { return default(object); }
    public static bool IsLicensed(System.Type type) { return default(bool); }
    public static bool IsValid(System.Type type) { return default(bool); }
    public static bool IsValid(System.Type type, object instance, out System.ComponentModel.License license) { license = default(System.ComponentModel.License); return default(bool); }
    public static void LockContext(object contextUser) { }
    public static void UnlockContext(object contextUser) { }
    public static void Validate(System.Type type) { }
    public static System.ComponentModel.License Validate(System.Type type, object instance) { return default(System.ComponentModel.License); }
  }
  public abstract partial class LicenseProvider {
    protected LicenseProvider() { }
    public abstract System.ComponentModel.License GetLicense(System.ComponentModel.LicenseContext context, System.Type type, object instance, bool allowExceptions);
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false, Inherited=false)]
  public sealed partial class LicenseProviderAttribute : System.Attribute {
    public static readonly System.ComponentModel.LicenseProviderAttribute Default;
    public LicenseProviderAttribute() { }
    public LicenseProviderAttribute(string typeName) { }
    public LicenseProviderAttribute(System.Type type) { }
    public System.Type LicenseProvider { get { return default(System.Type); } }
    public override object TypeId { get { return default(object); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }
  public enum LicenseUsageMode {
    Designtime = 1,
    Runtime = 0,
  }
  public partial class LicFileLicenseProvider : System.ComponentModel.LicenseProvider {
    public LicFileLicenseProvider() { }
    protected virtual string GetKey(System.Type type) { return default(string); }
    public override System.ComponentModel.License GetLicense(System.ComponentModel.LicenseContext context, System.Type type, object instance, bool allowExceptions) { return default(System.ComponentModel.License); }
    protected virtual bool IsKeyValid(string key, System.Type type) { return default(bool); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=false, Inherited=true)]
  public sealed partial class ListBindableAttribute : System.Attribute {
    public static readonly System.ComponentModel.ListBindableAttribute Default;
    public static readonly System.ComponentModel.ListBindableAttribute No;
    public static readonly System.ComponentModel.ListBindableAttribute Yes;
    public ListBindableAttribute(bool listBindable) { }
    public ListBindableAttribute(System.ComponentModel.BindableSupport flags) { }
    public bool ListBindable { get { return default(bool); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool IsDefaultAttribute() { return default(bool); }
  }
  public partial class ListChangedEventArgs : System.EventArgs {
    public ListChangedEventArgs(System.ComponentModel.ListChangedType listChangedType, System.ComponentModel.PropertyDescriptor propDesc) { }
    public ListChangedEventArgs(System.ComponentModel.ListChangedType listChangedType, int newIndex) { }
    public ListChangedEventArgs(System.ComponentModel.ListChangedType listChangedType, int newIndex, System.ComponentModel.PropertyDescriptor propDesc) { }
    public ListChangedEventArgs(System.ComponentModel.ListChangedType listChangedType, int newIndex, int oldIndex) { }
    public System.ComponentModel.ListChangedType ListChangedType { get { return default(System.ComponentModel.ListChangedType); } }
    public int NewIndex { get { return default(int); } }
    public int OldIndex { get { return default(int); } }
    public System.ComponentModel.PropertyDescriptor PropertyDescriptor { get { return default(System.ComponentModel.PropertyDescriptor); } }
  }
  public delegate void ListChangedEventHandler(object sender, System.ComponentModel.ListChangedEventArgs e);
  public enum ListChangedType {
    ItemAdded = 1,
    ItemChanged = 4,
    ItemDeleted = 2,
    ItemMoved = 3,
    PropertyDescriptorAdded = 5,
    PropertyDescriptorChanged = 7,
    PropertyDescriptorDeleted = 6,
    Reset = 0,
  }
  public partial class ListSortDescription {
    public ListSortDescription(System.ComponentModel.PropertyDescriptor propertyDescriptor, System.ComponentModel.ListSortDirection sortDirection) { }
    public System.ComponentModel.PropertyDescriptor PropertyDescriptor { get { return default(System.ComponentModel.PropertyDescriptor); } set { } }
    public System.ComponentModel.ListSortDirection SortDirection { get { return default(System.ComponentModel.ListSortDirection); } set { } }
  }
  public partial class ListSortDescriptionCollection : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList {
    public ListSortDescriptionCollection() { }
    public ListSortDescriptionCollection(System.ComponentModel.ListSortDescription[] sorts) { }
    public int Count { get { return default(int); } }
    public System.ComponentModel.ListSortDescription this[int index] { get { return default(System.ComponentModel.ListSortDescription); } set { } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    bool System.Collections.IList.IsFixedSize { get { return default(bool); } }
    bool System.Collections.IList.IsReadOnly { get { return default(bool); } }
    object System.Collections.IList.this[int index] { get { return default(object); } set { } }
    public bool Contains(object value) { return default(bool); }
    public void CopyTo(System.Array array, int index) { }
    public int IndexOf(object value) { return default(int); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    int System.Collections.IList.Add(object value) { return default(int); }
    void System.Collections.IList.Clear() { }
    void System.Collections.IList.Insert(int index, object value) { }
    void System.Collections.IList.Remove(object value) { }
    void System.Collections.IList.RemoveAt(int index) { }
  }
  public enum ListSortDirection {
    Ascending = 0,
    Descending = 1,
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(32767))]
  public sealed partial class LocalizableAttribute : System.Attribute {
    public static readonly System.ComponentModel.LocalizableAttribute Default;
    public static readonly System.ComponentModel.LocalizableAttribute No;
    public static readonly System.ComponentModel.LocalizableAttribute Yes;
    public LocalizableAttribute(bool localizable) { }
    public bool IsLocalizable { get { return default(bool); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool IsDefaultAttribute() { return default(bool); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
  public sealed partial class LookupBindingPropertiesAttribute : System.Attribute {
    public static readonly System.ComponentModel.LookupBindingPropertiesAttribute Default;
    public LookupBindingPropertiesAttribute() { }
    public LookupBindingPropertiesAttribute(string dataSource, string displayMember, string valueMember, string lookupMember) { }
    public string DataSource { get { return default(string); } }
    public string DisplayMember { get { return default(string); } }
    public string LookupMember { get { return default(string); } }
    public string ValueMember { get { return default(string); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }
  [System.ComponentModel.DesignerAttribute("System.Windows.Forms.Design.ComponentDocumentDesigner, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(System.ComponentModel.Design.IRootDesigner))]
  [System.ComponentModel.DesignerCategoryAttribute("Component")]
  [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.ComponentConverter))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class MarshalByValueComponent : System.ComponentModel.IComponent, System.IDisposable, System.IServiceProvider {
    public MarshalByValueComponent() { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public virtual System.ComponentModel.IContainer Container { get { return default(System.ComponentModel.IContainer); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public virtual bool DesignMode { get { return default(bool); } }
    protected System.ComponentModel.EventHandlerList Events { get { return default(System.ComponentModel.EventHandlerList); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public virtual System.ComponentModel.ISite Site { get { return default(System.ComponentModel.ISite); } set { } }
    public event System.EventHandler Disposed { add { } remove { } }
    public void Dispose() { }
    [System.MonoTODOAttribute]
    protected virtual void Dispose(bool disposing) { }
    ~MarshalByValueComponent() { }
    public virtual object GetService(System.Type service) { return default(object); }
    public override string ToString() { return default(string); }
  }
  public partial class MaskedTextProvider : System.ICloneable {
    public MaskedTextProvider(string mask) { }
    public MaskedTextProvider(string mask, bool restrictToAscii) { }
    public MaskedTextProvider(string mask, char passwordChar, bool allowPromptAsInput) { }
    public MaskedTextProvider(string mask, System.Globalization.CultureInfo culture) { }
    public MaskedTextProvider(string mask, System.Globalization.CultureInfo culture, bool restrictToAscii) { }
    public MaskedTextProvider(string mask, System.Globalization.CultureInfo culture, bool allowPromptAsInput, char promptChar, char passwordChar, bool restrictToAscii) { }
    public MaskedTextProvider(string mask, System.Globalization.CultureInfo culture, char passwordChar, bool allowPromptAsInput) { }
    public bool AllowPromptAsInput { get { return default(bool); } }
    public bool AsciiOnly { get { return default(bool); } }
    public int AssignedEditPositionCount { get { return default(int); } }
    public int AvailableEditPositionCount { get { return default(int); } }
    public System.Globalization.CultureInfo Culture { get { return default(System.Globalization.CultureInfo); } }
    public static char DefaultPasswordChar { get { return default(char); } }
    public int EditPositionCount { get { return default(int); } }
    public System.Collections.IEnumerator EditPositions { get { return default(System.Collections.IEnumerator); } }
    public bool IncludeLiterals { get { return default(bool); } set { } }
    public bool IncludePrompt { get { return default(bool); } set { } }
    public static int InvalidIndex { get { return default(int); } }
    public bool IsPassword { get { return default(bool); } set { } }
    public char this[int index] { get { return default(char); } }
    public int LastAssignedPosition { get { return default(int); } }
    public int Length { get { return default(int); } }
    public string Mask { get { return default(string); } }
    public bool MaskCompleted { get { return default(bool); } }
    public bool MaskFull { get { return default(bool); } }
    public char PasswordChar { get { return default(char); } set { } }
    public char PromptChar { get { return default(char); } set { } }
    public bool ResetOnPrompt { get { return default(bool); } set { } }
    public bool ResetOnSpace { get { return default(bool); } set { } }
    public bool SkipLiterals { get { return default(bool); } set { } }
    public bool Add(char input) { return default(bool); }
    public bool Add(char input, out int testPosition, out System.ComponentModel.MaskedTextResultHint resultHint) { testPosition = default(int); resultHint = default(System.ComponentModel.MaskedTextResultHint); return default(bool); }
    public bool Add(string input) { return default(bool); }
    public bool Add(string input, out int testPosition, out System.ComponentModel.MaskedTextResultHint resultHint) { testPosition = default(int); resultHint = default(System.ComponentModel.MaskedTextResultHint); return default(bool); }
    public void Clear() { }
    public void Clear(out System.ComponentModel.MaskedTextResultHint resultHint) { resultHint = default(System.ComponentModel.MaskedTextResultHint); }
    public object Clone() { return default(object); }
    public int FindAssignedEditPositionFrom(int position, bool direction) { return default(int); }
    public int FindAssignedEditPositionInRange(int startPosition, int endPosition, bool direction) { return default(int); }
    public int FindEditPositionFrom(int position, bool direction) { return default(int); }
    public int FindEditPositionInRange(int startPosition, int endPosition, bool direction) { return default(int); }
    public int FindNonEditPositionFrom(int position, bool direction) { return default(int); }
    public int FindNonEditPositionInRange(int startPosition, int endPosition, bool direction) { return default(int); }
    public int FindUnassignedEditPositionFrom(int position, bool direction) { return default(int); }
    public int FindUnassignedEditPositionInRange(int startPosition, int endPosition, bool direction) { return default(int); }
    public static bool GetOperationResultFromHint(System.ComponentModel.MaskedTextResultHint hint) { return default(bool); }
    public bool InsertAt(char input, int position) { return default(bool); }
    public bool InsertAt(char input, int position, out int testPosition, out System.ComponentModel.MaskedTextResultHint resultHint) { testPosition = default(int); resultHint = default(System.ComponentModel.MaskedTextResultHint); return default(bool); }
    public bool InsertAt(string input, int position) { return default(bool); }
    public bool InsertAt(string input, int position, out int testPosition, out System.ComponentModel.MaskedTextResultHint resultHint) { testPosition = default(int); resultHint = default(System.ComponentModel.MaskedTextResultHint); return default(bool); }
    public bool IsAvailablePosition(int position) { return default(bool); }
    public bool IsEditPosition(int position) { return default(bool); }
    public static bool IsValidInputChar(char c) { return default(bool); }
    public static bool IsValidMaskChar(char c) { return default(bool); }
    public static bool IsValidPasswordChar(char c) { return default(bool); }
    public bool Remove() { return default(bool); }
    public bool Remove(out int testPosition, out System.ComponentModel.MaskedTextResultHint resultHint) { testPosition = default(int); resultHint = default(System.ComponentModel.MaskedTextResultHint); return default(bool); }
    public bool RemoveAt(int position) { return default(bool); }
    public bool RemoveAt(int startPosition, int endPosition) { return default(bool); }
    public bool RemoveAt(int startPosition, int endPosition, out int testPosition, out System.ComponentModel.MaskedTextResultHint resultHint) { testPosition = default(int); resultHint = default(System.ComponentModel.MaskedTextResultHint); return default(bool); }
    public bool Replace(char input, int position) { return default(bool); }
    public bool Replace(char input, int startPosition, int endPosition, out int testPosition, out System.ComponentModel.MaskedTextResultHint resultHint) { testPosition = default(int); resultHint = default(System.ComponentModel.MaskedTextResultHint); return default(bool); }
    public bool Replace(char input, int position, out int testPosition, out System.ComponentModel.MaskedTextResultHint resultHint) { testPosition = default(int); resultHint = default(System.ComponentModel.MaskedTextResultHint); return default(bool); }
    public bool Replace(string input, int position) { return default(bool); }
    public bool Replace(string input, int startPosition, int endPosition, out int testPosition, out System.ComponentModel.MaskedTextResultHint resultHint) { testPosition = default(int); resultHint = default(System.ComponentModel.MaskedTextResultHint); return default(bool); }
    public bool Replace(string input, int position, out int testPosition, out System.ComponentModel.MaskedTextResultHint resultHint) { testPosition = default(int); resultHint = default(System.ComponentModel.MaskedTextResultHint); return default(bool); }
    public bool Set(string input) { return default(bool); }
    public bool Set(string input, out int testPosition, out System.ComponentModel.MaskedTextResultHint resultHint) { testPosition = default(int); resultHint = default(System.ComponentModel.MaskedTextResultHint); return default(bool); }
    public string ToDisplayString() { return default(string); }
    public override string ToString() { return default(string); }
    public string ToString(bool ignorePasswordChar) { return default(string); }
    public string ToString(bool includePrompt, bool includeLiterals) { return default(string); }
    public string ToString(bool ignorePasswordChar, bool includePrompt, bool includeLiterals, int startPosition, int length) { return default(string); }
    public string ToString(bool includePrompt, bool includeLiterals, int startPosition, int length) { return default(string); }
    public string ToString(bool ignorePasswordChar, int startPosition, int length) { return default(string); }
    public string ToString(int startPosition, int length) { return default(string); }
    public bool VerifyChar(char input, int position, out System.ComponentModel.MaskedTextResultHint hint) { hint = default(System.ComponentModel.MaskedTextResultHint); return default(bool); }
    public bool VerifyEscapeChar(char input, int position) { return default(bool); }
    public bool VerifyString(string input) { return default(bool); }
    public bool VerifyString(string input, out int testPosition, out System.ComponentModel.MaskedTextResultHint resultHint) { testPosition = default(int); resultHint = default(System.ComponentModel.MaskedTextResultHint); return default(bool); }
  }
  public enum MaskedTextResultHint {
    AlphanumericCharacterExpected = -2,
    AsciiCharacterExpected = -1,
    CharacterEscaped = 1,
    DigitExpected = -3,
    InvalidInput = -51,
    LetterExpected = -4,
    NoEffect = 2,
    NonEditPosition = -54,
    PositionOutOfRange = -55,
    PromptCharNotAllowed = -52,
    SideEffect = 3,
    SignedDigitExpected = -5,
    Success = 4,
    UnavailableEditPosition = -53,
    Unknown = 0,
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public abstract partial class MemberDescriptor {
    protected MemberDescriptor(System.ComponentModel.MemberDescriptor reference) { }
    protected MemberDescriptor(System.ComponentModel.MemberDescriptor reference, System.Attribute[] attrs) { }
    protected MemberDescriptor(string name) { }
    protected MemberDescriptor(string name, System.Attribute[] attrs) { }
    protected virtual System.Attribute[] AttributeArray { get { return default(System.Attribute[]); } set { } }
    public virtual System.ComponentModel.AttributeCollection Attributes { get { return default(System.ComponentModel.AttributeCollection); } }
    public virtual string Category { get { return default(string); } }
    public virtual string Description { get { return default(string); } }
    public virtual bool DesignTimeOnly { get { return default(bool); } }
    public virtual string DisplayName { get { return default(string); } }
    public virtual bool IsBrowsable { get { return default(bool); } }
    public virtual string Name { get { return default(string); } }
    protected virtual int NameHashCode { get { return default(int); } }
    protected virtual System.ComponentModel.AttributeCollection CreateAttributeCollection() { return default(System.ComponentModel.AttributeCollection); }
    public override bool Equals(object obj) { return default(bool); }
    protected virtual void FillAttributes(System.Collections.IList attributeList) { }
    protected static System.Reflection.MethodInfo FindMethod(System.Type componentClass, string name, System.Type[] args, System.Type returnType) { return default(System.Reflection.MethodInfo); }
    protected static System.Reflection.MethodInfo FindMethod(System.Type componentClass, string name, System.Type[] args, System.Type returnType, bool publicOnly) { return default(System.Reflection.MethodInfo); }
    public override int GetHashCode() { return default(int); }
    protected virtual object GetInvocationTarget(System.Type type, object instance) { return default(object); }
    [System.ObsoleteAttribute("Use GetInvocationTarget")]
    protected static object GetInvokee(System.Type componentClass, object component) { return default(object); }
    protected static System.ComponentModel.ISite GetSite(object component) { return default(System.ComponentModel.ISite); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(32767))]
  public sealed partial class MergablePropertyAttribute : System.Attribute {
    public static readonly System.ComponentModel.MergablePropertyAttribute Default;
    public static readonly System.ComponentModel.MergablePropertyAttribute No;
    public static readonly System.ComponentModel.MergablePropertyAttribute Yes;
    public MergablePropertyAttribute(bool allowMerge) { }
    public bool AllowMerge { get { return default(bool); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool IsDefaultAttribute() { return default(bool); }
  }
  public partial class MultilineStringConverter : System.ComponentModel.TypeConverter {
    public MultilineStringConverter() { }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
    public override System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public override bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
  }
  public partial class NestedContainer : System.ComponentModel.Container, System.ComponentModel.IContainer, System.ComponentModel.INestedContainer, System.IDisposable {
    public NestedContainer(System.ComponentModel.IComponent owner) { }
    public System.ComponentModel.IComponent Owner { get { return default(System.ComponentModel.IComponent); } }
    protected virtual string OwnerName { get { return default(string); } }
    protected override System.ComponentModel.ISite CreateSite(System.ComponentModel.IComponent component, string name) { return default(System.ComponentModel.ISite); }
    protected override void Dispose(bool disposing) { }
    protected override object GetService(System.Type service) { return default(object); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(128))]
  public sealed partial class NotifyParentPropertyAttribute : System.Attribute {
    public static readonly System.ComponentModel.NotifyParentPropertyAttribute Default;
    public static readonly System.ComponentModel.NotifyParentPropertyAttribute No;
    public static readonly System.ComponentModel.NotifyParentPropertyAttribute Yes;
    public NotifyParentPropertyAttribute(bool notifyParent) { }
    public bool NotifyParent { get { return default(bool); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool IsDefaultAttribute() { return default(bool); }
  }
  public partial class NullableConverter : System.ComponentModel.TypeConverter {
    public NullableConverter(System.Type nullableType) { }
    public System.Type NullableType { get { return default(System.Type); } }
    public System.Type UnderlyingType { get { return default(System.Type); } }
    public System.ComponentModel.TypeConverter UnderlyingTypeConverter { get { return default(System.ComponentModel.TypeConverter); } }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
    public override object CreateInstance(System.ComponentModel.ITypeDescriptorContext context, System.Collections.IDictionary propertyValues) { return default(object); }
    public override bool GetCreateInstanceSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public override System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public override bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { return default(System.ComponentModel.TypeConverter.StandardValuesCollection); }
    public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public override bool IsValid(System.ComponentModel.ITypeDescriptorContext context, object value) { return default(bool); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(32767))]
  public sealed partial class ParenthesizePropertyNameAttribute : System.Attribute {
    public static readonly System.ComponentModel.ParenthesizePropertyNameAttribute Default;
    public ParenthesizePropertyNameAttribute() { }
    public ParenthesizePropertyNameAttribute(bool needParenthesis) { }
    public bool NeedParenthesis { get { return default(bool); } }
    public override bool Equals(object o) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool IsDefaultAttribute() { return default(bool); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(32767))]
  public sealed partial class PasswordPropertyTextAttribute : System.Attribute {
    public static readonly System.ComponentModel.PasswordPropertyTextAttribute Default;
    public static readonly System.ComponentModel.PasswordPropertyTextAttribute No;
    public static readonly System.ComponentModel.PasswordPropertyTextAttribute Yes;
    public PasswordPropertyTextAttribute() { }
    public PasswordPropertyTextAttribute(bool password) { }
    public bool Password { get { return default(bool); } }
    public override bool Equals(object o) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool IsDefaultAttribute() { return default(bool); }
  }
  public partial class ProgressChangedEventArgs : System.EventArgs {
    public ProgressChangedEventArgs(int progressPercentage, object userState) { }
    public int ProgressPercentage { get { return default(int); } }
    public object UserState { get { return default(object); } }
  }
  public delegate void ProgressChangedEventHandler(object sender, System.ComponentModel.ProgressChangedEventArgs e);
  public partial class PropertyChangedEventArgs : System.EventArgs {
    public PropertyChangedEventArgs(string propertyName) { }
    public virtual string PropertyName { get { return default(string); } }
  }
  public delegate void PropertyChangedEventHandler(object sender, System.ComponentModel.PropertyChangedEventArgs e);
  public partial class PropertyChangingEventArgs : System.EventArgs {
    public PropertyChangingEventArgs(string propertyName) { }
    public virtual string PropertyName { get { return default(string); } }
  }
  public delegate void PropertyChangingEventHandler(object sender, System.ComponentModel.PropertyChangingEventArgs e);
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public abstract partial class PropertyDescriptor : System.ComponentModel.MemberDescriptor {
    protected PropertyDescriptor(System.ComponentModel.MemberDescriptor reference) : base (default(string), default(System.Attribute[])) { }
    protected PropertyDescriptor(System.ComponentModel.MemberDescriptor reference, System.Attribute[] attrs) : base (default(string), default(System.Attribute[])) { }
    protected PropertyDescriptor(string name, System.Attribute[] attrs) : base (default(string), default(System.Attribute[])) { }
    public abstract System.Type ComponentType { get; }
    public virtual System.ComponentModel.TypeConverter Converter { get { return default(System.ComponentModel.TypeConverter); } }
    public virtual bool IsLocalizable { get { return default(bool); } }
    public abstract bool IsReadOnly { get; }
    public abstract System.Type PropertyType { get; }
    public System.ComponentModel.DesignerSerializationVisibility SerializationVisibility { get { return default(System.ComponentModel.DesignerSerializationVisibility); } }
    public virtual bool SupportsChangeEvents { get { return default(bool); } }
    public virtual void AddValueChanged(object component, System.EventHandler handler) { }
    public abstract bool CanResetValue(object component);
    protected object CreateInstance(System.Type type) { return default(object); }
    public override bool Equals(object obj) { return default(bool); }
    protected override void FillAttributes(System.Collections.IList attributeList) { }
    public System.ComponentModel.PropertyDescriptorCollection GetChildProperties() { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public System.ComponentModel.PropertyDescriptorCollection GetChildProperties(System.Attribute[] filter) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public System.ComponentModel.PropertyDescriptorCollection GetChildProperties(object instance) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public virtual System.ComponentModel.PropertyDescriptorCollection GetChildProperties(object instance, System.Attribute[] filter) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public virtual object GetEditor(System.Type editorBaseType) { return default(object); }
    public override int GetHashCode() { return default(int); }
    protected override object GetInvocationTarget(System.Type type, object instance) { return default(object); }
    protected System.Type GetTypeFromName(string typeName) { return default(System.Type); }
    public abstract object GetValue(object component);
    protected internal System.EventHandler GetValueChangedHandler(object component) { return default(System.EventHandler); }
    protected virtual void OnValueChanged(object component, System.EventArgs e) { }
    public virtual void RemoveValueChanged(object component, System.EventHandler handler) { }
    public abstract void ResetValue(object component);
    public abstract void SetValue(object component, object value);
    public abstract bool ShouldSerializeValue(object component);
  }
  public partial class PropertyDescriptorCollection : System.Collections.ICollection, System.Collections.IDictionary, System.Collections.IEnumerable, System.Collections.IList {
    public static readonly System.ComponentModel.PropertyDescriptorCollection Empty;
    public PropertyDescriptorCollection(System.ComponentModel.PropertyDescriptor[] properties) { }
    public PropertyDescriptorCollection(System.ComponentModel.PropertyDescriptor[] properties, bool readOnly) { }
    public int Count { get { return default(int); } }
    public virtual System.ComponentModel.PropertyDescriptor this[int index] { get { return default(System.ComponentModel.PropertyDescriptor); } }
    public virtual System.ComponentModel.PropertyDescriptor this[string s] { get { return default(System.ComponentModel.PropertyDescriptor); } }
    int System.Collections.ICollection.Count { get { return default(int); } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    bool System.Collections.IDictionary.IsFixedSize { get { return default(bool); } }
    bool System.Collections.IDictionary.IsReadOnly { get { return default(bool); } }
    object System.Collections.IDictionary.this[object key] { get { return default(object); } set { } }
    System.Collections.ICollection System.Collections.IDictionary.Keys { get { return default(System.Collections.ICollection); } }
    System.Collections.ICollection System.Collections.IDictionary.Values { get { return default(System.Collections.ICollection); } }
    bool System.Collections.IList.IsFixedSize { get { return default(bool); } }
    bool System.Collections.IList.IsReadOnly { get { return default(bool); } }
    object System.Collections.IList.this[int index] { get { return default(object); } set { } }
    public int Add(System.ComponentModel.PropertyDescriptor value) { return default(int); }
    public void Clear() { }
    public bool Contains(System.ComponentModel.PropertyDescriptor value) { return default(bool); }
    public void CopyTo(System.Array array, int index) { }
    public virtual System.ComponentModel.PropertyDescriptor Find(string name, bool ignoreCase) { return default(System.ComponentModel.PropertyDescriptor); }
    public virtual System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public int IndexOf(System.ComponentModel.PropertyDescriptor value) { return default(int); }
    public void Insert(int index, System.ComponentModel.PropertyDescriptor value) { }
    protected void InternalSort(System.Collections.IComparer ic) { }
    protected void InternalSort(System.String[] order) { }
    public void Remove(System.ComponentModel.PropertyDescriptor value) { }
    public void RemoveAt(int index) { }
    public virtual System.ComponentModel.PropertyDescriptorCollection Sort() { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public virtual System.ComponentModel.PropertyDescriptorCollection Sort(System.Collections.IComparer comparer) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public virtual System.ComponentModel.PropertyDescriptorCollection Sort(System.String[] order) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public virtual System.ComponentModel.PropertyDescriptorCollection Sort(System.String[] order, System.Collections.IComparer comparer) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    void System.Collections.IDictionary.Add(object key, object value) { }
    void System.Collections.IDictionary.Clear() { }
    bool System.Collections.IDictionary.Contains(object value) { return default(bool); }
    [System.MonoTODOAttribute]
    System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { return default(System.Collections.IDictionaryEnumerator); }
    void System.Collections.IDictionary.Remove(object value) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    int System.Collections.IList.Add(object value) { return default(int); }
    void System.Collections.IList.Clear() { }
    bool System.Collections.IList.Contains(object value) { return default(bool); }
    int System.Collections.IList.IndexOf(object value) { return default(int); }
    void System.Collections.IList.Insert(int index, object value) { }
    void System.Collections.IList.Remove(object value) { }
    void System.Collections.IList.RemoveAt(int index) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(32767))]
  public partial class PropertyTabAttribute : System.Attribute {
    public PropertyTabAttribute() { }
    public PropertyTabAttribute(string tabClassName) { }
    public PropertyTabAttribute(string tabClassName, System.ComponentModel.PropertyTabScope tabScope) { }
    public PropertyTabAttribute(System.Type tabClass) { }
    public PropertyTabAttribute(System.Type tabClass, System.ComponentModel.PropertyTabScope tabScope) { }
    public System.Type[] TabClasses { get { return default(System.Type[]); } }
    protected System.String[] TabClassNames { get { return default(System.String[]); } }
    public System.ComponentModel.PropertyTabScope[] TabScopes { get { return default(System.ComponentModel.PropertyTabScope[]); } }
    public bool Equals(System.ComponentModel.PropertyTabAttribute other) { return default(bool); }
    public override bool Equals(object other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    protected void InitializeArrays(System.String[] tabClassNames, System.ComponentModel.PropertyTabScope[] tabScopes) { }
    protected void InitializeArrays(System.Type[] tabClasses, System.ComponentModel.PropertyTabScope[] tabScopes) { }
  }
  public enum PropertyTabScope {
    Component = 3,
    Document = 2,
    Global = 1,
    Static = 0,
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=true, Inherited=true)]
  public sealed partial class ProvidePropertyAttribute : System.Attribute {
    public ProvidePropertyAttribute(string propertyName, string receiverTypeName) { }
    public ProvidePropertyAttribute(string propertyName, System.Type receiverType) { }
    public string PropertyName { get { return default(string); } }
    public string ReceiverTypeName { get { return default(string); } }
    public override object TypeId { get { return default(object); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(32767))]
  public sealed partial class ReadOnlyAttribute : System.Attribute {
    public static readonly System.ComponentModel.ReadOnlyAttribute Default;
    public static readonly System.ComponentModel.ReadOnlyAttribute No;
    public static readonly System.ComponentModel.ReadOnlyAttribute Yes;
    public ReadOnlyAttribute(bool isReadOnly) { }
    public bool IsReadOnly { get { return default(bool); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool IsDefaultAttribute() { return default(bool); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(128))]
  [System.ObsoleteAttribute("Use SettingsBindableAttribute instead of RecommendedAsConfigurableAttribute")]
  public partial class RecommendedAsConfigurableAttribute : System.Attribute {
    public static readonly System.ComponentModel.RecommendedAsConfigurableAttribute Default;
    public static readonly System.ComponentModel.RecommendedAsConfigurableAttribute No;
    public static readonly System.ComponentModel.RecommendedAsConfigurableAttribute Yes;
    public RecommendedAsConfigurableAttribute(bool recommendedAsConfigurable) { }
    public bool RecommendedAsConfigurable { get { return default(bool); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool IsDefaultAttribute() { return default(bool); }
  }
  public partial class ReferenceConverter : System.ComponentModel.TypeConverter {
    public ReferenceConverter(System.Type type) { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
    public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { return default(System.ComponentModel.TypeConverter.StandardValuesCollection); }
    public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    protected virtual bool IsValueAllowed(System.ComponentModel.ITypeDescriptorContext context, object value) { return default(bool); }
  }
  public partial class RefreshEventArgs : System.EventArgs {
    public RefreshEventArgs(object componentChanged) { }
    public RefreshEventArgs(System.Type typeChanged) { }
    public object ComponentChanged { get { return default(object); } }
    public System.Type TypeChanged { get { return default(System.Type); } }
  }
  public delegate void RefreshEventHandler(System.ComponentModel.RefreshEventArgs e);
  public enum RefreshProperties {
    All = 1,
    None = 0,
    Repaint = 2,
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(32767))]
  public sealed partial class RefreshPropertiesAttribute : System.Attribute {
    public static readonly System.ComponentModel.RefreshPropertiesAttribute All;
    public static readonly System.ComponentModel.RefreshPropertiesAttribute Default;
    public static readonly System.ComponentModel.RefreshPropertiesAttribute Repaint;
    public RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties refresh) { }
    public System.ComponentModel.RefreshProperties RefreshProperties { get { return default(System.ComponentModel.RefreshProperties); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool IsDefaultAttribute() { return default(bool); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
  public partial class RunInstallerAttribute : System.Attribute {
    public static readonly System.ComponentModel.RunInstallerAttribute Default;
    public static readonly System.ComponentModel.RunInstallerAttribute No;
    public static readonly System.ComponentModel.RunInstallerAttribute Yes;
    public RunInstallerAttribute(bool runInstaller) { }
    public bool RunInstaller { get { return default(bool); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool IsDefaultAttribute() { return default(bool); }
  }
  public partial class RunWorkerCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    public RunWorkerCompletedEventArgs(object result, System.Exception error, bool cancelled) : base (default(System.Exception), default(bool), default(object)) { }
    public object Result { get { return default(object); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new object UserState { get { return default(object); } }
  }
  public delegate void RunWorkerCompletedEventHandler(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e);
  public partial class SByteConverter : System.ComponentModel.BaseNumberConverter {
    public SByteConverter() { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(128), AllowMultiple=false, Inherited=true)]
  public sealed partial class SettingsBindableAttribute : System.Attribute {
    public static readonly System.ComponentModel.SettingsBindableAttribute No;
    public static readonly System.ComponentModel.SettingsBindableAttribute Yes;
    public SettingsBindableAttribute(bool bindable) { }
    public bool Bindable { get { return default(bool); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }
  public partial class SingleConverter : System.ComponentModel.BaseNumberConverter {
    public SingleConverter() { }
  }
  public partial class StringConverter : System.ComponentModel.TypeConverter {
    public StringConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
  }
  public static partial class SyntaxCheck {
    public static bool CheckMachineName(string value) { return default(bool); }
    public static bool CheckPath(string value) { return default(bool); }
    public static bool CheckRootedPath(string value) { return default(bool); }
  }
  public partial class TimeSpanConverter : System.ComponentModel.TypeConverter {
    public TimeSpanConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(32767))]
  public partial class ToolboxItemAttribute : System.Attribute {
    public static readonly System.ComponentModel.ToolboxItemAttribute Default;
    public static readonly System.ComponentModel.ToolboxItemAttribute None;
    public ToolboxItemAttribute(bool defaultType) { }
    public ToolboxItemAttribute(string toolboxItemName) { }
    public ToolboxItemAttribute(System.Type toolboxItemType) { }
    public System.Type ToolboxItemType { get { return default(System.Type); } }
    public string ToolboxItemTypeName { get { return default(string); } }
    public override bool Equals(object o) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool IsDefaultAttribute() { return default(bool); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=true, Inherited=true)]
  public sealed partial class ToolboxItemFilterAttribute : System.Attribute {
    public ToolboxItemFilterAttribute(string filterString) { }
    public ToolboxItemFilterAttribute(string filterString, System.ComponentModel.ToolboxItemFilterType filterType) { }
    public string FilterString { get { return default(string); } }
    public System.ComponentModel.ToolboxItemFilterType FilterType { get { return default(System.ComponentModel.ToolboxItemFilterType); } }
    public override object TypeId { get { return default(object); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool Match(object obj) { return default(bool); }
    public override string ToString() { return default(string); }
  }
  public enum ToolboxItemFilterType {
    Allow = 0,
    Custom = 1,
    Prevent = 2,
    Require = 3,
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class TypeConverter {
    public TypeConverter() { }
    public virtual bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public bool CanConvertFrom(System.Type sourceType) { return default(bool); }
    public virtual bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public bool CanConvertTo(System.Type destinationType) { return default(bool); }
    public virtual object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public object ConvertFrom(object o) { return default(object); }
    public object ConvertFromInvariantString(System.ComponentModel.ITypeDescriptorContext context, string text) { return default(object); }
    public object ConvertFromInvariantString(string text) { return default(object); }
    public object ConvertFromString(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, string text) { return default(object); }
    public object ConvertFromString(System.ComponentModel.ITypeDescriptorContext context, string text) { return default(object); }
    public object ConvertFromString(string text) { return default(object); }
    public virtual object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
    public object ConvertTo(object value, System.Type destinationType) { return default(object); }
    public string ConvertToInvariantString(System.ComponentModel.ITypeDescriptorContext context, object value) { return default(string); }
    public string ConvertToInvariantString(object value) { return default(string); }
    public string ConvertToString(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(string); }
    public string ConvertToString(System.ComponentModel.ITypeDescriptorContext context, object value) { return default(string); }
    public string ConvertToString(object value) { return default(string); }
    public object CreateInstance(System.Collections.IDictionary propertyValues) { return default(object); }
    public virtual object CreateInstance(System.ComponentModel.ITypeDescriptorContext context, System.Collections.IDictionary propertyValues) { return default(object); }
    protected System.Exception GetConvertFromException(object value) { return default(System.Exception); }
    protected System.Exception GetConvertToException(object value, System.Type destinationType) { return default(System.Exception); }
    public bool GetCreateInstanceSupported() { return default(bool); }
    public virtual bool GetCreateInstanceSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public virtual System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public System.ComponentModel.PropertyDescriptorCollection GetProperties(object value) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public bool GetPropertiesSupported() { return default(bool); }
    public virtual bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public System.Collections.ICollection GetStandardValues() { return default(System.Collections.ICollection); }
    public virtual System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { return default(System.ComponentModel.TypeConverter.StandardValuesCollection); }
    public bool GetStandardValuesExclusive() { return default(bool); }
    public virtual bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public bool GetStandardValuesSupported() { return default(bool); }
    public virtual bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public virtual bool IsValid(System.ComponentModel.ITypeDescriptorContext context, object value) { return default(bool); }
    public bool IsValid(object value) { return default(bool); }
    protected System.ComponentModel.PropertyDescriptorCollection SortProperties(System.ComponentModel.PropertyDescriptorCollection props, System.String[] names) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    protected abstract partial class SimplePropertyDescriptor : System.ComponentModel.PropertyDescriptor {
      protected SimplePropertyDescriptor(System.Type componentType, string name, System.Type propertyType) : base (default(System.ComponentModel.MemberDescriptor)) { }
      protected SimplePropertyDescriptor(System.Type componentType, string name, System.Type propertyType, System.Attribute[] attributes) : base (default(System.ComponentModel.MemberDescriptor)) { }
      public override System.Type ComponentType { get { return default(System.Type); } }
      public override bool IsReadOnly { get { return default(bool); } }
      public override System.Type PropertyType { get { return default(System.Type); } }
      public override bool CanResetValue(object component) { return default(bool); }
      public override void ResetValue(object component) { }
      public override bool ShouldSerializeValue(object component) { return default(bool); }
    }
    public partial class StandardValuesCollection : System.Collections.ICollection, System.Collections.IEnumerable {
      public StandardValuesCollection(System.Collections.ICollection values) { }
      public int Count { get { return default(int); } }
      public object this[int index] { get { return default(object); } }
      int System.Collections.ICollection.Count { get { return default(int); } }
      bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
      object System.Collections.ICollection.SyncRoot { get { return default(object); } }
      public void CopyTo(System.Array array, int index) { }
      public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
      void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
      System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(32767))]
  public sealed partial class TypeConverterAttribute : System.Attribute {
    public static readonly System.ComponentModel.TypeConverterAttribute Default;
    public TypeConverterAttribute() { }
    public TypeConverterAttribute(string typeName) { }
    public TypeConverterAttribute(System.Type type) { }
    public string ConverterTypeName { get { return default(string); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }
  public abstract partial class TypeDescriptionProvider {
    protected TypeDescriptionProvider() { }
    protected TypeDescriptionProvider(System.ComponentModel.TypeDescriptionProvider parent) { }
    public virtual object CreateInstance(System.IServiceProvider provider, System.Type objectType, System.Type[] argTypes, System.Object[] args) { return default(object); }
    public virtual System.Collections.IDictionary GetCache(object instance) { return default(System.Collections.IDictionary); }
    public virtual System.ComponentModel.ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { return default(System.ComponentModel.ICustomTypeDescriptor); }
    protected internal virtual System.ComponentModel.IExtenderProvider[] GetExtenderProviders(object instance) { return default(System.ComponentModel.IExtenderProvider[]); }
    public virtual string GetFullComponentName(object component) { return default(string); }
    public System.Type GetReflectionType(object instance) { return default(System.Type); }
    public System.Type GetReflectionType(System.Type objectType) { return default(System.Type); }
    public virtual System.Type GetReflectionType(System.Type objectType, object instance) { return default(System.Type); }
    public virtual System.Type GetRuntimeType(System.Type reflectionType) { return default(System.Type); }
    public System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(object instance) { return default(System.ComponentModel.ICustomTypeDescriptor); }
    public System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Type objectType) { return default(System.ComponentModel.ICustomTypeDescriptor); }
    public virtual System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Type objectType, object instance) { return default(System.ComponentModel.ICustomTypeDescriptor); }
    public virtual bool IsSupportedType(System.Type type) { return default(bool); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), Inherited=true)]
  public sealed partial class TypeDescriptionProviderAttribute : System.Attribute {
    public TypeDescriptionProviderAttribute(string typeName) { }
    public TypeDescriptionProviderAttribute(System.Type type) { }
    public string TypeName { get { return default(string); } }
  }
  public sealed partial class TypeDescriptor {
    internal TypeDescriptor() { }
    [System.ObsoleteAttribute("Use ComObjectType")]
    public static System.ComponentModel.IComNativeDescriptorHandler ComNativeDescriptorHandler { get { return default(System.ComponentModel.IComNativeDescriptorHandler); } set { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    [System.MonoNotSupportedAttribute("Mono does not support COM")]
    public static System.Type ComObjectType { get { return default(System.Type); } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static System.Type InterfaceType { get { return default(System.Type); } }
    public static event System.ComponentModel.RefreshEventHandler Refreshed { add { } remove { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static System.ComponentModel.TypeDescriptionProvider AddAttributes(object instance, params System.Attribute[] attributes) { return default(System.ComponentModel.TypeDescriptionProvider); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static System.ComponentModel.TypeDescriptionProvider AddAttributes(System.Type type, params System.Attribute[] attributes) { return default(System.ComponentModel.TypeDescriptionProvider); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static void AddEditorTable(System.Type editorBaseType, System.Collections.Hashtable table) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static void AddProvider(System.ComponentModel.TypeDescriptionProvider provider, object instance) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static void AddProvider(System.ComponentModel.TypeDescriptionProvider provider, System.Type type) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    [System.MonoLimitationAttribute("Security not applied.")]
    public static void AddProviderTransparent(System.ComponentModel.TypeDescriptionProvider provider, object instance) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    [System.MonoLimitationAttribute("Security not applied.")]
    public static void AddProviderTransparent(System.ComponentModel.TypeDescriptionProvider provider, System.Type type) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    [System.MonoNotSupportedAttribute("Associations not supported")]
    public static void CreateAssociation(object primary, object secondary) { }
    public static System.ComponentModel.Design.IDesigner CreateDesigner(System.ComponentModel.IComponent component, System.Type designerBaseType) { return default(System.ComponentModel.Design.IDesigner); }
    [System.Security.Permissions.ReflectionPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, TypeInformation=true, MemberAccess=true)]
    public static System.ComponentModel.EventDescriptor CreateEvent(System.Type componentType, System.ComponentModel.EventDescriptor oldEventDescriptor, params System.Attribute[] attributes) { return default(System.ComponentModel.EventDescriptor); }
    [System.Security.Permissions.ReflectionPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, TypeInformation=true, MemberAccess=true)]
    public static System.ComponentModel.EventDescriptor CreateEvent(System.Type componentType, string name, System.Type type, params System.Attribute[] attributes) { return default(System.ComponentModel.EventDescriptor); }
    [System.MonoTODOAttribute]
    public static object CreateInstance(System.IServiceProvider provider, System.Type objectType, System.Type[] argTypes, System.Object[] args) { return default(object); }
    [System.Security.Permissions.ReflectionPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, TypeInformation=true, MemberAccess=true)]
    public static System.ComponentModel.PropertyDescriptor CreateProperty(System.Type componentType, System.ComponentModel.PropertyDescriptor oldPropertyDescriptor, params System.Attribute[] attributes) { return default(System.ComponentModel.PropertyDescriptor); }
    [System.Security.Permissions.ReflectionPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, TypeInformation=true, MemberAccess=true)]
    public static System.ComponentModel.PropertyDescriptor CreateProperty(System.Type componentType, string name, System.Type type, params System.Attribute[] attributes) { return default(System.ComponentModel.PropertyDescriptor); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    [System.MonoNotSupportedAttribute("Associations not supported")]
    public static object GetAssociation(System.Type type, object primary) { return default(object); }
    public static System.ComponentModel.AttributeCollection GetAttributes(object component) { return default(System.ComponentModel.AttributeCollection); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static System.ComponentModel.AttributeCollection GetAttributes(object component, bool noCustomTypeDesc) { return default(System.ComponentModel.AttributeCollection); }
    public static System.ComponentModel.AttributeCollection GetAttributes(System.Type componentType) { return default(System.ComponentModel.AttributeCollection); }
    public static string GetClassName(object component) { return default(string); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static string GetClassName(object component, bool noCustomTypeDesc) { return default(string); }
    [System.MonoNotSupportedAttribute("")]
    public static string GetClassName(System.Type componentType) { return default(string); }
    public static string GetComponentName(object component) { return default(string); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static string GetComponentName(object component, bool noCustomTypeDesc) { return default(string); }
    public static System.ComponentModel.TypeConverter GetConverter(object component) { return default(System.ComponentModel.TypeConverter); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static System.ComponentModel.TypeConverter GetConverter(object component, bool noCustomTypeDesc) { return default(System.ComponentModel.TypeConverter); }
    public static System.ComponentModel.TypeConverter GetConverter(System.Type type) { return default(System.ComponentModel.TypeConverter); }
    public static System.ComponentModel.EventDescriptor GetDefaultEvent(object component) { return default(System.ComponentModel.EventDescriptor); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static System.ComponentModel.EventDescriptor GetDefaultEvent(object component, bool noCustomTypeDesc) { return default(System.ComponentModel.EventDescriptor); }
    public static System.ComponentModel.EventDescriptor GetDefaultEvent(System.Type componentType) { return default(System.ComponentModel.EventDescriptor); }
    public static System.ComponentModel.PropertyDescriptor GetDefaultProperty(object component) { return default(System.ComponentModel.PropertyDescriptor); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static System.ComponentModel.PropertyDescriptor GetDefaultProperty(object component, bool noCustomTypeDesc) { return default(System.ComponentModel.PropertyDescriptor); }
    public static System.ComponentModel.PropertyDescriptor GetDefaultProperty(System.Type componentType) { return default(System.ComponentModel.PropertyDescriptor); }
    public static object GetEditor(object component, System.Type editorBaseType) { return default(object); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static object GetEditor(object component, System.Type editorBaseType, bool noCustomTypeDesc) { return default(object); }
    public static object GetEditor(System.Type componentType, System.Type editorBaseType) { return default(object); }
    public static System.ComponentModel.EventDescriptorCollection GetEvents(object component) { return default(System.ComponentModel.EventDescriptorCollection); }
    public static System.ComponentModel.EventDescriptorCollection GetEvents(object component, System.Attribute[] attributes) { return default(System.ComponentModel.EventDescriptorCollection); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static System.ComponentModel.EventDescriptorCollection GetEvents(object component, System.Attribute[] attributes, bool noCustomTypeDesc) { return default(System.ComponentModel.EventDescriptorCollection); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static System.ComponentModel.EventDescriptorCollection GetEvents(object component, bool noCustomTypeDesc) { return default(System.ComponentModel.EventDescriptorCollection); }
    public static System.ComponentModel.EventDescriptorCollection GetEvents(System.Type componentType) { return default(System.ComponentModel.EventDescriptorCollection); }
    public static System.ComponentModel.EventDescriptorCollection GetEvents(System.Type componentType, System.Attribute[] attributes) { return default(System.ComponentModel.EventDescriptorCollection); }
    [System.MonoNotSupportedAttribute("")]
    public static string GetFullComponentName(object component) { return default(string); }
    public static System.ComponentModel.PropertyDescriptorCollection GetProperties(object component) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public static System.ComponentModel.PropertyDescriptorCollection GetProperties(object component, System.Attribute[] attributes) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public static System.ComponentModel.PropertyDescriptorCollection GetProperties(object component, System.Attribute[] attributes, bool noCustomTypeDesc) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static System.ComponentModel.PropertyDescriptorCollection GetProperties(object component, bool noCustomTypeDesc) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public static System.ComponentModel.PropertyDescriptorCollection GetProperties(System.Type componentType) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public static System.ComponentModel.PropertyDescriptorCollection GetProperties(System.Type componentType, System.Attribute[] attributes) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static System.ComponentModel.TypeDescriptionProvider GetProvider(object instance) { return default(System.ComponentModel.TypeDescriptionProvider); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static System.ComponentModel.TypeDescriptionProvider GetProvider(System.Type type) { return default(System.ComponentModel.TypeDescriptionProvider); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static System.Type GetReflectionType(object instance) { return default(System.Type); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static System.Type GetReflectionType(System.Type type) { return default(System.Type); }
    public static void Refresh(object component) { }
    public static void Refresh(System.Reflection.Assembly assembly) { }
    public static void Refresh(System.Reflection.Module module) { }
    public static void Refresh(System.Type type) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    [System.MonoNotSupportedAttribute("Associations not supported")]
    public static void RemoveAssociation(object primary, object secondary) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    [System.MonoNotSupportedAttribute("Associations not supported")]
    public static void RemoveAssociations(object primary) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static void RemoveProvider(System.ComponentModel.TypeDescriptionProvider provider, object instance) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static void RemoveProvider(System.ComponentModel.TypeDescriptionProvider provider, System.Type type) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    [System.MonoLimitationAttribute("Security not applied.")]
    public static void RemoveProviderTransparent(System.ComponentModel.TypeDescriptionProvider provider, object instance) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    [System.MonoLimitationAttribute("Security not applied.")]
    public static void RemoveProviderTransparent(System.ComponentModel.TypeDescriptionProvider provider, System.Type type) { }
    public static void SortDescriptorArray(System.Collections.IList infos) { }
  }
  public abstract partial class TypeListConverter : System.ComponentModel.TypeConverter {
    protected TypeListConverter(System.Type[] types) { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
    public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { return default(System.ComponentModel.TypeConverter.StandardValuesCollection); }
    public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
  }
  public partial class UInt16Converter : System.ComponentModel.BaseNumberConverter {
    public UInt16Converter() { }
  }
  public partial class UInt32Converter : System.ComponentModel.BaseNumberConverter {
    public UInt32Converter() { }
  }
  public partial class UInt64Converter : System.ComponentModel.BaseNumberConverter {
    public UInt64Converter() { }
  }
  public partial class WarningException : System.SystemException {
    public WarningException() { }
    protected WarningException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public WarningException(string message) { }
    public WarningException(string message, System.Exception innerException) { }
    public WarningException(string message, string helpUrl) { }
    public WarningException(string message, string helpUrl, string helpTopic) { }
    public string HelpTopic { get { return default(string); } }
    public string HelpUrl { get { return default(string); } }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, SerializationFormatter=true)]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  [System.Security.SuppressUnmanagedCodeSecurityAttribute]
  public partial class Win32Exception : System.Runtime.InteropServices.ExternalException {
    public Win32Exception() { }
    public Win32Exception(int error) { }
    public Win32Exception(int error, string message) { }
    protected Win32Exception(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, UnmanagedCode=true)]
    public Win32Exception(string message) { }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, UnmanagedCode=true)]
    public Win32Exception(string message, System.Exception innerException) { }
    public int NativeErrorCode { get { return default(int); } }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, SerializationFormatter=true)]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
}
namespace System.ComponentModel.Design {
  public partial class ActiveDesignerEventArgs : System.EventArgs {
    public ActiveDesignerEventArgs(System.ComponentModel.Design.IDesignerHost oldDesigner, System.ComponentModel.Design.IDesignerHost newDesigner) { }
    public System.ComponentModel.Design.IDesignerHost NewDesigner { get { return default(System.ComponentModel.Design.IDesignerHost); } }
    public System.ComponentModel.Design.IDesignerHost OldDesigner { get { return default(System.ComponentModel.Design.IDesignerHost); } }
  }
  public delegate void ActiveDesignerEventHandler(object sender, System.ComponentModel.Design.ActiveDesignerEventArgs e);
  public partial class CheckoutException : System.Runtime.InteropServices.ExternalException {
    public static readonly System.ComponentModel.Design.CheckoutException Canceled;
    public CheckoutException() { }
    protected CheckoutException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public CheckoutException(string message) { }
    public CheckoutException(string message, System.Exception innerException) { }
    public CheckoutException(string message, int errorCode) { }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CommandID {
    public CommandID(System.Guid menuGroup, int commandID) { }
    public virtual System.Guid Guid { get { return default(System.Guid); } }
    public virtual int ID { get { return default(int); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class ComponentChangedEventArgs : System.EventArgs {
    public ComponentChangedEventArgs(object component, System.ComponentModel.MemberDescriptor member, object oldValue, object newValue) { }
    public object Component { get { return default(object); } }
    public System.ComponentModel.MemberDescriptor Member { get { return default(System.ComponentModel.MemberDescriptor); } }
    public object NewValue { get { return default(object); } }
    public object OldValue { get { return default(object); } }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public delegate void ComponentChangedEventHandler(object sender, System.ComponentModel.Design.ComponentChangedEventArgs e);
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class ComponentChangingEventArgs : System.EventArgs {
    public ComponentChangingEventArgs(object component, System.ComponentModel.MemberDescriptor member) { }
    public object Component { get { return default(object); } }
    public System.ComponentModel.MemberDescriptor Member { get { return default(System.ComponentModel.MemberDescriptor); } }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public delegate void ComponentChangingEventHandler(object sender, System.ComponentModel.Design.ComponentChangingEventArgs e);
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class ComponentEventArgs : System.EventArgs {
    public ComponentEventArgs(System.ComponentModel.IComponent component) { }
    public virtual System.ComponentModel.IComponent Component { get { return default(System.ComponentModel.IComponent); } }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public delegate void ComponentEventHandler(object sender, System.ComponentModel.Design.ComponentEventArgs e);
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class ComponentRenameEventArgs : System.EventArgs {
    public ComponentRenameEventArgs(object component, string oldName, string newName) { }
    public object Component { get { return default(object); } }
    public virtual string NewName { get { return default(string); } }
    public virtual string OldName { get { return default(string); } }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public delegate void ComponentRenameEventHandler(object sender, System.ComponentModel.Design.ComponentRenameEventArgs e);
  public partial class DesignerCollection : System.Collections.ICollection, System.Collections.IEnumerable {
    public DesignerCollection(System.Collections.IList designers) { }
    public DesignerCollection(System.ComponentModel.Design.IDesignerHost[] designers) { }
    public int Count { get { return default(int); } }
    public virtual System.ComponentModel.Design.IDesignerHost this[int index] { get { return default(System.ComponentModel.Design.IDesignerHost); } }
    int System.Collections.ICollection.Count { get { return default(int); } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public partial class DesignerEventArgs : System.EventArgs {
    public DesignerEventArgs(System.ComponentModel.Design.IDesignerHost host) { }
    public System.ComponentModel.Design.IDesignerHost Designer { get { return default(System.ComponentModel.Design.IDesignerHost); } }
  }
  public delegate void DesignerEventHandler(object sender, System.ComponentModel.Design.DesignerEventArgs e);
  public abstract partial class DesignerOptionService : System.ComponentModel.Design.IDesignerOptionService {
    protected internal DesignerOptionService() { }
    public System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection Options { get { return default(System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection); } }
    protected System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection CreateOptionCollection(System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection parent, string name, object value) { return default(System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection); }
    protected virtual void PopulateOptionCollection(System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection options) { }
    protected virtual bool ShowDialog(System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection options, object optionObject) { return default(bool); }
    object System.ComponentModel.Design.IDesignerOptionService.GetOptionValue(string pageName, string valueName) { return default(object); }
    void System.ComponentModel.Design.IDesignerOptionService.SetOptionValue(string pageName, string valueName, object value) { }
    [System.ComponentModel.EditorAttribute("", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.TypeConverter))]
    [System.MonoTODOAttribute("implement own TypeConverter")]
    public sealed partial class DesignerOptionCollection : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList {
      internal DesignerOptionCollection() { }
      public int Count { get { return default(int); } }
      public System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection this[int index] { get { return default(System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection); } }
      public System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection this[string index] { get { return default(System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection); } }
      public string Name { get { return default(string); } }
      public System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection Parent { get { return default(System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection); } }
      public System.ComponentModel.PropertyDescriptorCollection Properties { get { return default(System.ComponentModel.PropertyDescriptorCollection); } }
      bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
      object System.Collections.ICollection.SyncRoot { get { return default(object); } }
      bool System.Collections.IList.IsFixedSize { get { return default(bool); } }
      bool System.Collections.IList.IsReadOnly { get { return default(bool); } }
      object System.Collections.IList.this[int index] { get { return default(object); } set { } }
      public void CopyTo(System.Array array, int index) { }
      public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
      public int IndexOf(System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection item) { return default(int); }
      public bool ShowDialog() { return default(bool); }
      int System.Collections.IList.Add(object item) { return default(int); }
      void System.Collections.IList.Clear() { }
      bool System.Collections.IList.Contains(object item) { return default(bool); }
      int System.Collections.IList.IndexOf(object item) { return default(int); }
      void System.Collections.IList.Insert(int index, object item) { }
      void System.Collections.IList.Remove(object item) { }
      void System.Collections.IList.RemoveAt(int index) { }
      public sealed partial class WrappedPropertyDescriptor : System.ComponentModel.PropertyDescriptor {
        public WrappedPropertyDescriptor(System.ComponentModel.PropertyDescriptor property, object component) : base (default(System.ComponentModel.MemberDescriptor)) { }
        public override System.ComponentModel.AttributeCollection Attributes { get { return default(System.ComponentModel.AttributeCollection); } }
        public override System.Type ComponentType { get { return default(System.Type); } }
        public override bool IsReadOnly { get { return default(bool); } }
        public override System.Type PropertyType { get { return default(System.Type); } }
        public override bool CanResetValue(object ignored) { return default(bool); }
        public override object GetValue(object ignored) { return default(object); }
        public override void ResetValue(object ignored) { }
        public override void SetValue(object ignored, object value) { }
        public override bool ShouldSerializeValue(object ignored) { return default(bool); }
      }
    }
  }
  public abstract partial class DesignerTransaction : System.IDisposable {
    protected DesignerTransaction() { }
    protected DesignerTransaction(string description) { }
    public bool Canceled { get { return default(bool); } }
    public bool Committed { get { return default(bool); } }
    public string Description { get { return default(string); } }
    public void Cancel() { }
    public void Commit() { }
    protected virtual void Dispose(bool disposing) { }
    ~DesignerTransaction() { }
    protected abstract void OnCancel();
    protected abstract void OnCommit();
    void System.IDisposable.Dispose() { }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class DesignerTransactionCloseEventArgs : System.EventArgs {
    [System.ObsoleteAttribute("Use another constructor that indicates lastTransaction")]
    public DesignerTransactionCloseEventArgs(bool commit) { }
    public DesignerTransactionCloseEventArgs(bool commit, bool lastTransaction) { }
    public bool LastTransaction { get { return default(bool); } }
    public bool TransactionCommitted { get { return default(bool); } }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public delegate void DesignerTransactionCloseEventHandler(object sender, System.ComponentModel.Design.DesignerTransactionCloseEventArgs e);
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class DesignerVerb : System.ComponentModel.Design.MenuCommand {
    public DesignerVerb(string text, System.EventHandler handler) : base (default(System.EventHandler), default(System.ComponentModel.Design.CommandID)) { }
    public DesignerVerb(string text, System.EventHandler handler, System.ComponentModel.Design.CommandID startCommandID) : base (default(System.EventHandler), default(System.ComponentModel.Design.CommandID)) { }
    public string Description { get { return default(string); } set { } }
    public string Text { get { return default(string); } }
    public override string ToString() { return default(string); }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class DesignerVerbCollection : System.Collections.CollectionBase {
    public DesignerVerbCollection() { }
    public DesignerVerbCollection(System.ComponentModel.Design.DesignerVerb[] value) { }
    public System.ComponentModel.Design.DesignerVerb this[int index] { get { return default(System.ComponentModel.Design.DesignerVerb); } set { } }
    public int Add(System.ComponentModel.Design.DesignerVerb value) { return default(int); }
    public void AddRange(System.ComponentModel.Design.DesignerVerb[] value) { }
    public void AddRange(System.ComponentModel.Design.DesignerVerbCollection value) { }
    public bool Contains(System.ComponentModel.Design.DesignerVerb value) { return default(bool); }
    public void CopyTo(System.ComponentModel.Design.DesignerVerb[] array, int index) { }
    public int IndexOf(System.ComponentModel.Design.DesignerVerb value) { return default(int); }
    public void Insert(int index, System.ComponentModel.Design.DesignerVerb value) { }
    protected override void OnClear() { }
    protected override void OnInsert(int index, object value) { }
    protected override void OnRemove(int index, object value) { }
    protected override void OnSet(int index, object oldValue, object newValue) { }
    protected override void OnValidate(object value) { }
    public void Remove(System.ComponentModel.Design.DesignerVerb value) { }
  }
  public partial class DesigntimeLicenseContext : System.ComponentModel.LicenseContext {
    public DesigntimeLicenseContext() { }
    public override System.ComponentModel.LicenseUsageMode UsageMode { get { return default(System.ComponentModel.LicenseUsageMode); } }
    public override string GetSavedLicenseKey(System.Type type, System.Reflection.Assembly resourceAssembly) { return default(string); }
    public override void SetSavedLicenseKey(System.Type type, string key) { }
  }
  public partial class DesigntimeLicenseContextSerializer {
    internal DesigntimeLicenseContextSerializer() { }
    public static void Serialize(System.IO.Stream o, string cryptoKey, System.ComponentModel.Design.DesigntimeLicenseContext context) { }
  }
  public enum HelpContextType {
    Ambient = 0,
    Selection = 2,
    ToolWindowSelection = 3,
    Window = 1,
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=false, Inherited=false)]
  public sealed partial class HelpKeywordAttribute : System.Attribute {
    public static readonly System.ComponentModel.Design.HelpKeywordAttribute Default;
    public HelpKeywordAttribute() { }
    public HelpKeywordAttribute(string keyword) { }
    public HelpKeywordAttribute(System.Type t) { }
    public string HelpKeyword { get { return default(string); } }
    public override bool Equals(object other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool IsDefaultAttribute() { return default(bool); }
  }
  public enum HelpKeywordType {
    F1Keyword = 0,
    FilterKeyword = 2,
    GeneralKeyword = 1,
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial interface IComponentChangeService {
    event System.ComponentModel.Design.ComponentEventHandler ComponentAdded;
    event System.ComponentModel.Design.ComponentEventHandler ComponentAdding;
    event System.ComponentModel.Design.ComponentChangedEventHandler ComponentChanged;
    event System.ComponentModel.Design.ComponentChangingEventHandler ComponentChanging;
    event System.ComponentModel.Design.ComponentEventHandler ComponentRemoved;
    event System.ComponentModel.Design.ComponentEventHandler ComponentRemoving;
    event System.ComponentModel.Design.ComponentRenameEventHandler ComponentRename;
    void OnComponentChanged(object component, System.ComponentModel.MemberDescriptor member, object oldValue, object newValue);
    void OnComponentChanging(object component, System.ComponentModel.MemberDescriptor member);
  }
  public partial interface IComponentDiscoveryService {
    System.Collections.ICollection GetComponentTypes(System.ComponentModel.Design.IDesignerHost designerHost, System.Type baseType);
  }
  public partial interface IComponentInitializer {
    void InitializeExistingComponent(System.Collections.IDictionary defaultValues);
    void InitializeNewComponent(System.Collections.IDictionary defaultValues);
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial interface IDesigner : System.IDisposable {
    System.ComponentModel.IComponent Component { get; }
    System.ComponentModel.Design.DesignerVerbCollection Verbs { get; }
    void DoDefaultAction();
    void Initialize(System.ComponentModel.IComponent component);
  }
  public partial interface IDesignerEventService {
    System.ComponentModel.Design.IDesignerHost ActiveDesigner { get; }
    System.ComponentModel.Design.DesignerCollection Designers { get; }
    event System.ComponentModel.Design.ActiveDesignerEventHandler ActiveDesignerChanged;
    event System.ComponentModel.Design.DesignerEventHandler DesignerCreated;
    event System.ComponentModel.Design.DesignerEventHandler DesignerDisposed;
    event System.EventHandler SelectionChanged;
  }
  public partial interface IDesignerFilter {
    void PostFilterAttributes(System.Collections.IDictionary attributes);
    void PostFilterEvents(System.Collections.IDictionary events);
    void PostFilterProperties(System.Collections.IDictionary properties);
    void PreFilterAttributes(System.Collections.IDictionary attributes);
    void PreFilterEvents(System.Collections.IDictionary events);
    void PreFilterProperties(System.Collections.IDictionary properties);
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial interface IDesignerHost : System.ComponentModel.Design.IServiceContainer, System.IServiceProvider {
    System.ComponentModel.IContainer Container { get; }
    bool InTransaction { get; }
    bool Loading { get; }
    System.ComponentModel.IComponent RootComponent { get; }
    string RootComponentClassName { get; }
    string TransactionDescription { get; }
    event System.EventHandler Activated;
    event System.EventHandler Deactivated;
    event System.EventHandler LoadComplete;
    event System.ComponentModel.Design.DesignerTransactionCloseEventHandler TransactionClosed;
    event System.ComponentModel.Design.DesignerTransactionCloseEventHandler TransactionClosing;
    event System.EventHandler TransactionOpened;
    event System.EventHandler TransactionOpening;
    void Activate();
    System.ComponentModel.IComponent CreateComponent(System.Type componentClass);
    System.ComponentModel.IComponent CreateComponent(System.Type componentClass, string name);
    System.ComponentModel.Design.DesignerTransaction CreateTransaction();
    System.ComponentModel.Design.DesignerTransaction CreateTransaction(string description);
    void DestroyComponent(System.ComponentModel.IComponent component);
    System.ComponentModel.Design.IDesigner GetDesigner(System.ComponentModel.IComponent component);
    System.Type GetType(string typeName);
  }
  public partial interface IDesignerHostTransactionState {
    bool IsClosingTransaction { get; }
  }
  public partial interface IDesignerOptionService {
    object GetOptionValue(string pageName, string valueName);
    void SetOptionValue(string pageName, string valueName, object value);
  }
  public partial interface IDictionaryService {
    object GetKey(object value);
    object GetValue(object key);
    void SetValue(object key, object value);
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial interface IEventBindingService {
    string CreateUniqueMethodName(System.ComponentModel.IComponent component, System.ComponentModel.EventDescriptor e);
    System.Collections.ICollection GetCompatibleMethods(System.ComponentModel.EventDescriptor e);
    System.ComponentModel.EventDescriptor GetEvent(System.ComponentModel.PropertyDescriptor property);
    System.ComponentModel.PropertyDescriptorCollection GetEventProperties(System.ComponentModel.EventDescriptorCollection events);
    System.ComponentModel.PropertyDescriptor GetEventProperty(System.ComponentModel.EventDescriptor e);
    bool ShowCode();
    bool ShowCode(System.ComponentModel.IComponent component, System.ComponentModel.EventDescriptor e);
    bool ShowCode(int lineNumber);
  }
  public partial interface IExtenderListService {
    System.ComponentModel.IExtenderProvider[] GetExtenderProviders();
  }
  public partial interface IExtenderProviderService {
    void AddExtenderProvider(System.ComponentModel.IExtenderProvider provider);
    void RemoveExtenderProvider(System.ComponentModel.IExtenderProvider provider);
  }
  public partial interface IHelpService {
    void AddContextAttribute(string name, string value, System.ComponentModel.Design.HelpKeywordType keywordType);
    void ClearContextAttributes();
    System.ComponentModel.Design.IHelpService CreateLocalContext(System.ComponentModel.Design.HelpContextType contextType);
    void RemoveContextAttribute(string name, string value);
    void RemoveLocalContext(System.ComponentModel.Design.IHelpService localContext);
    void ShowHelpFromKeyword(string helpKeyword);
    void ShowHelpFromUrl(string helpUrl);
  }
  public partial interface IInheritanceService {
    void AddInheritedComponents(System.ComponentModel.IComponent component, System.ComponentModel.IContainer container);
    System.ComponentModel.InheritanceAttribute GetInheritanceAttribute(System.ComponentModel.IComponent component);
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial interface IMenuCommandService {
    System.ComponentModel.Design.DesignerVerbCollection Verbs { get; }
    void AddCommand(System.ComponentModel.Design.MenuCommand command);
    void AddVerb(System.ComponentModel.Design.DesignerVerb verb);
    System.ComponentModel.Design.MenuCommand FindCommand(System.ComponentModel.Design.CommandID commandID);
    bool GlobalInvoke(System.ComponentModel.Design.CommandID commandID);
    void RemoveCommand(System.ComponentModel.Design.MenuCommand command);
    void RemoveVerb(System.ComponentModel.Design.DesignerVerb verb);
    void ShowContextMenu(System.ComponentModel.Design.CommandID menuID, int x, int y);
  }
  public partial interface IReferenceService {
    System.ComponentModel.IComponent GetComponent(object reference);
    string GetName(object reference);
    object GetReference(string name);
    System.Object[] GetReferences();
    System.Object[] GetReferences(System.Type baseType);
  }
  public partial interface IResourceService {
    System.Resources.IResourceReader GetResourceReader(System.Globalization.CultureInfo info);
    System.Resources.IResourceWriter GetResourceWriter(System.Globalization.CultureInfo info);
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial interface IRootDesigner : System.ComponentModel.Design.IDesigner, System.IDisposable {
    System.ComponentModel.Design.ViewTechnology[] SupportedTechnologies { get; }
    object GetView(System.ComponentModel.Design.ViewTechnology technology);
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial interface ISelectionService {
    object PrimarySelection { get; }
    int SelectionCount { get; }
    event System.EventHandler SelectionChanged;
    event System.EventHandler SelectionChanging;
    bool GetComponentSelected(object component);
    System.Collections.ICollection GetSelectedComponents();
    void SetSelectedComponents(System.Collections.ICollection components);
    void SetSelectedComponents(System.Collections.ICollection components, System.ComponentModel.Design.SelectionTypes selectionType);
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial interface IServiceContainer : System.IServiceProvider {
    void AddService(System.Type serviceType, System.ComponentModel.Design.ServiceCreatorCallback callback);
    void AddService(System.Type serviceType, System.ComponentModel.Design.ServiceCreatorCallback callback, bool promote);
    void AddService(System.Type serviceType, object serviceInstance);
    void AddService(System.Type serviceType, object serviceInstance, bool promote);
    void RemoveService(System.Type serviceType);
    void RemoveService(System.Type serviceType, bool promote);
  }
  public partial interface ITreeDesigner : System.ComponentModel.Design.IDesigner, System.IDisposable {
    System.Collections.ICollection Children { get; }
    System.ComponentModel.Design.IDesigner Parent { get; }
  }
  public partial interface ITypeDescriptorFilterService {
    bool FilterAttributes(System.ComponentModel.IComponent component, System.Collections.IDictionary attributes);
    bool FilterEvents(System.ComponentModel.IComponent component, System.Collections.IDictionary events);
    bool FilterProperties(System.ComponentModel.IComponent component, System.Collections.IDictionary properties);
  }
  public partial interface ITypeDiscoveryService {
    System.Collections.ICollection GetTypes(System.Type baseType, bool excludeGlobalTypes);
  }
  public partial interface ITypeResolutionService {
    System.Reflection.Assembly GetAssembly(System.Reflection.AssemblyName name);
    System.Reflection.Assembly GetAssembly(System.Reflection.AssemblyName name, bool throwOnError);
    string GetPathOfAssembly(System.Reflection.AssemblyName name);
    System.Type GetType(string name);
    System.Type GetType(string name, bool throwOnError);
    System.Type GetType(string name, bool throwOnError, bool ignoreCase);
    void ReferenceAssembly(System.Reflection.AssemblyName name);
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class MenuCommand {
    public MenuCommand(System.EventHandler handler, System.ComponentModel.Design.CommandID command) { }
    public virtual bool Checked { get { return default(bool); } set { } }
    public virtual System.ComponentModel.Design.CommandID CommandID { get { return default(System.ComponentModel.Design.CommandID); } }
    public virtual bool Enabled { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public virtual int OleStatus { get { return default(int); } }
    public virtual System.Collections.IDictionary Properties { get { return default(System.Collections.IDictionary); } }
    public virtual bool Supported { get { return default(bool); } set { } }
    public virtual bool Visible { get { return default(bool); } set { } }
    public event System.EventHandler CommandChanged { add { } remove { } }
    public virtual void Invoke() { }
    public virtual void Invoke(object arg) { }
    protected virtual void OnCommandChanged(System.EventArgs e) { }
    public override string ToString() { return default(string); }
  }
  [System.FlagsAttribute]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public enum SelectionTypes {
    Add = 64,
    Auto = 1,
    [System.ObsoleteAttribute("This value has been deprecated. Use SelectionTypes.Primary instead.")]
    Click = 16,
    [System.ObsoleteAttribute("This value has been deprecated. It is no longer supported.")]
    MouseDown = 4,
    [System.ObsoleteAttribute("This value has been deprecated. It is no longer supported.")]
    MouseUp = 8,
    [System.ObsoleteAttribute("This value has been deprecated. Use SelectionTypes.Auto instead.")]
    Normal = 1,
    Primary = 16,
    Remove = 128,
    Replace = 2,
    Toggle = 32,
    [System.ObsoleteAttribute("This value has been deprecated. It is no longer supported.")]
    Valid = 31,
  }
  public partial class ServiceContainer : System.ComponentModel.Design.IServiceContainer, System.IDisposable, System.IServiceProvider {
    public ServiceContainer() { }
    public ServiceContainer(System.IServiceProvider parentProvider) { }
    protected virtual System.Type[] DefaultServices { get { return default(System.Type[]); } }
    public void AddService(System.Type serviceType, System.ComponentModel.Design.ServiceCreatorCallback callback) { }
    public virtual void AddService(System.Type serviceType, System.ComponentModel.Design.ServiceCreatorCallback callback, bool promote) { }
    public void AddService(System.Type serviceType, object serviceInstance) { }
    public virtual void AddService(System.Type serviceType, object serviceInstance, bool promote) { }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public virtual object GetService(System.Type serviceType) { return default(object); }
    public void RemoveService(System.Type serviceType) { }
    public virtual void RemoveService(System.Type serviceType, bool promote) { }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public delegate object ServiceCreatorCallback(System.ComponentModel.Design.IServiceContainer container, System.Type serviceType);
  public partial class StandardCommands {
    public static readonly System.ComponentModel.Design.CommandID AlignBottom;
    public static readonly System.ComponentModel.Design.CommandID AlignHorizontalCenters;
    public static readonly System.ComponentModel.Design.CommandID AlignLeft;
    public static readonly System.ComponentModel.Design.CommandID AlignRight;
    public static readonly System.ComponentModel.Design.CommandID AlignToGrid;
    public static readonly System.ComponentModel.Design.CommandID AlignTop;
    public static readonly System.ComponentModel.Design.CommandID AlignVerticalCenters;
    public static readonly System.ComponentModel.Design.CommandID ArrangeBottom;
    public static readonly System.ComponentModel.Design.CommandID ArrangeIcons;
    public static readonly System.ComponentModel.Design.CommandID ArrangeRight;
    public static readonly System.ComponentModel.Design.CommandID BringForward;
    public static readonly System.ComponentModel.Design.CommandID BringToFront;
    public static readonly System.ComponentModel.Design.CommandID CenterHorizontally;
    public static readonly System.ComponentModel.Design.CommandID CenterVertically;
    public static readonly System.ComponentModel.Design.CommandID Copy;
    public static readonly System.ComponentModel.Design.CommandID Cut;
    public static readonly System.ComponentModel.Design.CommandID Delete;
    public static readonly System.ComponentModel.Design.CommandID DocumentOutline;
    public static readonly System.ComponentModel.Design.CommandID F1Help;
    public static readonly System.ComponentModel.Design.CommandID Group;
    public static readonly System.ComponentModel.Design.CommandID HorizSpaceConcatenate;
    public static readonly System.ComponentModel.Design.CommandID HorizSpaceDecrease;
    public static readonly System.ComponentModel.Design.CommandID HorizSpaceIncrease;
    public static readonly System.ComponentModel.Design.CommandID HorizSpaceMakeEqual;
    public static readonly System.ComponentModel.Design.CommandID LineupIcons;
    public static readonly System.ComponentModel.Design.CommandID LockControls;
    public static readonly System.ComponentModel.Design.CommandID MultiLevelRedo;
    public static readonly System.ComponentModel.Design.CommandID MultiLevelUndo;
    public static readonly System.ComponentModel.Design.CommandID Paste;
    public static readonly System.ComponentModel.Design.CommandID Properties;
    public static readonly System.ComponentModel.Design.CommandID PropertiesWindow;
    public static readonly System.ComponentModel.Design.CommandID Redo;
    public static readonly System.ComponentModel.Design.CommandID Replace;
    public static readonly System.ComponentModel.Design.CommandID SelectAll;
    public static readonly System.ComponentModel.Design.CommandID SendBackward;
    public static readonly System.ComponentModel.Design.CommandID SendToBack;
    public static readonly System.ComponentModel.Design.CommandID ShowGrid;
    public static readonly System.ComponentModel.Design.CommandID ShowLargeIcons;
    public static readonly System.ComponentModel.Design.CommandID SizeToControl;
    public static readonly System.ComponentModel.Design.CommandID SizeToControlHeight;
    public static readonly System.ComponentModel.Design.CommandID SizeToControlWidth;
    public static readonly System.ComponentModel.Design.CommandID SizeToFit;
    public static readonly System.ComponentModel.Design.CommandID SizeToGrid;
    public static readonly System.ComponentModel.Design.CommandID SnapToGrid;
    public static readonly System.ComponentModel.Design.CommandID TabOrder;
    public static readonly System.ComponentModel.Design.CommandID Undo;
    public static readonly System.ComponentModel.Design.CommandID Ungroup;
    public static readonly System.ComponentModel.Design.CommandID VerbFirst;
    public static readonly System.ComponentModel.Design.CommandID VerbLast;
    public static readonly System.ComponentModel.Design.CommandID VertSpaceConcatenate;
    public static readonly System.ComponentModel.Design.CommandID VertSpaceDecrease;
    public static readonly System.ComponentModel.Design.CommandID VertSpaceIncrease;
    public static readonly System.ComponentModel.Design.CommandID VertSpaceMakeEqual;
    public static readonly System.ComponentModel.Design.CommandID ViewCode;
    public static readonly System.ComponentModel.Design.CommandID ViewGrid;
    public StandardCommands() { }
  }
  public partial class StandardToolWindows {
    public static readonly System.Guid ObjectBrowser;
    public static readonly System.Guid OutputWindow;
    public static readonly System.Guid ProjectExplorer;
    public static readonly System.Guid PropertyBrowser;
    public static readonly System.Guid RelatedLinks;
    public static readonly System.Guid ServerExplorer;
    public static readonly System.Guid TaskList;
    public static readonly System.Guid Toolbox;
    public StandardToolWindows() { }
  }
  public abstract partial class TypeDescriptionProviderService {
    protected TypeDescriptionProviderService() { }
    public abstract System.ComponentModel.TypeDescriptionProvider GetProvider(object instance);
    public abstract System.ComponentModel.TypeDescriptionProvider GetProvider(System.Type type);
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public enum ViewTechnology {
    Default = 2,
    [System.ObsoleteAttribute("Use ViewTechnology.Default.")]
    Passthrough = 0,
    [System.ObsoleteAttribute("Use ViewTechnology.Default.")]
    WindowsForms = 1,
  }
}
namespace System.ComponentModel.Design.Serialization {
  public abstract partial class ComponentSerializationService {
    protected ComponentSerializationService() { }
    public abstract System.ComponentModel.Design.Serialization.SerializationStore CreateStore();
    public abstract System.Collections.ICollection Deserialize(System.ComponentModel.Design.Serialization.SerializationStore store);
    public abstract System.Collections.ICollection Deserialize(System.ComponentModel.Design.Serialization.SerializationStore store, System.ComponentModel.IContainer container);
    public void DeserializeTo(System.ComponentModel.Design.Serialization.SerializationStore store, System.ComponentModel.IContainer container) { }
    public void DeserializeTo(System.ComponentModel.Design.Serialization.SerializationStore store, System.ComponentModel.IContainer container, bool validateRecycledTypes) { }
    public abstract void DeserializeTo(System.ComponentModel.Design.Serialization.SerializationStore store, System.ComponentModel.IContainer container, bool validateRecycledTypes, bool applyDefaults);
    public abstract System.ComponentModel.Design.Serialization.SerializationStore LoadStore(System.IO.Stream stream);
    public abstract void Serialize(System.ComponentModel.Design.Serialization.SerializationStore store, object value);
    public abstract void SerializeAbsolute(System.ComponentModel.Design.Serialization.SerializationStore store, object value);
    public abstract void SerializeMember(System.ComponentModel.Design.Serialization.SerializationStore store, object owningObject, System.ComponentModel.MemberDescriptor member);
    public abstract void SerializeMemberAbsolute(System.ComponentModel.Design.Serialization.SerializationStore store, object owningObject, System.ComponentModel.MemberDescriptor member);
  }
  public sealed partial class ContextStack {
    public ContextStack() { }
    public object Current { get { return default(object); } }
    public object this[int level] { get { return default(object); } }
    public object this[System.Type type] { get { return default(object); } }
    public void Append(object context) { }
    public object Pop() { return default(object); }
    public void Push(object context) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), Inherited=false)]
  public sealed partial class DefaultSerializationProviderAttribute : System.Attribute {
    public DefaultSerializationProviderAttribute(string providerTypeName) { }
    public DefaultSerializationProviderAttribute(System.Type providerType) { }
    public string ProviderTypeName { get { return default(string); } }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public abstract partial class DesignerLoader {
    protected DesignerLoader() { }
    public virtual bool Loading { get { return default(bool); } }
    public abstract void BeginLoad(System.ComponentModel.Design.Serialization.IDesignerLoaderHost host);
    public abstract void Dispose();
    public virtual void Flush() { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(1028), AllowMultiple=true, Inherited=true)]
  public sealed partial class DesignerSerializerAttribute : System.Attribute {
    public DesignerSerializerAttribute(string serializerTypeName, string baseSerializerTypeName) { }
    public DesignerSerializerAttribute(string serializerTypeName, System.Type baseSerializerType) { }
    public DesignerSerializerAttribute(System.Type serializerType, System.Type baseSerializerType) { }
    public string SerializerBaseTypeName { get { return default(string); } }
    public string SerializerTypeName { get { return default(string); } }
    public override object TypeId { get { return default(object); } }
  }
  public partial interface IDesignerLoaderHost : System.ComponentModel.Design.IDesignerHost, System.ComponentModel.Design.IServiceContainer, System.IServiceProvider {
    void EndLoad(string baseClassName, bool successful, System.Collections.ICollection errorCollection);
    void Reload();
  }
  public partial interface IDesignerLoaderHost2 : System.ComponentModel.Design.IDesignerHost, System.ComponentModel.Design.IServiceContainer, System.ComponentModel.Design.Serialization.IDesignerLoaderHost, System.IServiceProvider {
    bool CanReloadWithErrors { get; set; }
    bool IgnoreErrorsDuringReload { get; set; }
  }
  public partial interface IDesignerLoaderService {
    void AddLoadDependency();
    void DependentLoadComplete(bool successful, System.Collections.ICollection errorCollection);
    bool Reload();
  }
  public partial interface IDesignerSerializationManager : System.IServiceProvider {
    System.ComponentModel.Design.Serialization.ContextStack Context { get; }
    System.ComponentModel.PropertyDescriptorCollection Properties { get; }
    event System.ComponentModel.Design.Serialization.ResolveNameEventHandler ResolveName;
    event System.EventHandler SerializationComplete;
    void AddSerializationProvider(System.ComponentModel.Design.Serialization.IDesignerSerializationProvider provider);
    object CreateInstance(System.Type type, System.Collections.ICollection arguments, string name, bool addToContainer);
    object GetInstance(string name);
    string GetName(object value);
    object GetSerializer(System.Type objectType, System.Type serializerType);
    System.Type GetType(string typeName);
    void RemoveSerializationProvider(System.ComponentModel.Design.Serialization.IDesignerSerializationProvider provider);
    void ReportError(object errorInformation);
    void SetName(object instance, string name);
  }
  public partial interface IDesignerSerializationProvider {
    object GetSerializer(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object currentSerializer, System.Type objectType, System.Type serializerType);
  }
  public partial interface IDesignerSerializationService {
    System.Collections.ICollection Deserialize(object serializationData);
    object Serialize(System.Collections.ICollection objects);
  }
  public partial interface INameCreationService {
    string CreateName(System.ComponentModel.IContainer container, System.Type dataType);
    bool IsValidName(string name);
    void ValidateName(string name);
  }
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
  public sealed partial class InstanceDescriptor {
    public InstanceDescriptor(System.Reflection.MemberInfo member, System.Collections.ICollection arguments) { }
    public InstanceDescriptor(System.Reflection.MemberInfo member, System.Collections.ICollection arguments, bool isComplete) { }
    public System.Collections.ICollection Arguments { get { return default(System.Collections.ICollection); } }
    public bool IsComplete { get { return default(bool); } }
    public System.Reflection.MemberInfo MemberInfo { get { return default(System.Reflection.MemberInfo); } }
    public object Invoke() { return default(object); }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct MemberRelationship {
    public static readonly System.ComponentModel.Design.Serialization.MemberRelationship Empty;
    public MemberRelationship(object owner, System.ComponentModel.MemberDescriptor member) { throw new System.NotImplementedException(); }
    public bool IsEmpty { get { return default(bool); } }
    public System.ComponentModel.MemberDescriptor Member { get { return default(System.ComponentModel.MemberDescriptor); } }
    public object Owner { get { return default(object); } }
    public override bool Equals(object o) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.ComponentModel.Design.Serialization.MemberRelationship left, System.ComponentModel.Design.Serialization.MemberRelationship right) { return default(bool); }
    public static bool operator !=(System.ComponentModel.Design.Serialization.MemberRelationship left, System.ComponentModel.Design.Serialization.MemberRelationship right) { return default(bool); }
  }
  public abstract partial class MemberRelationshipService {
    protected MemberRelationshipService() { }
    public System.ComponentModel.Design.Serialization.MemberRelationship this[System.ComponentModel.Design.Serialization.MemberRelationship source] { get { return default(System.ComponentModel.Design.Serialization.MemberRelationship); } set { } }
    public System.ComponentModel.Design.Serialization.MemberRelationship this[object owner, System.ComponentModel.MemberDescriptor member] { get { return default(System.ComponentModel.Design.Serialization.MemberRelationship); } set { } }
    protected virtual System.ComponentModel.Design.Serialization.MemberRelationship GetRelationship(System.ComponentModel.Design.Serialization.MemberRelationship source) { return default(System.ComponentModel.Design.Serialization.MemberRelationship); }
    protected virtual void SetRelationship(System.ComponentModel.Design.Serialization.MemberRelationship source, System.ComponentModel.Design.Serialization.MemberRelationship relationship) { }
    public abstract bool SupportsRelationship(System.ComponentModel.Design.Serialization.MemberRelationship source, System.ComponentModel.Design.Serialization.MemberRelationship relationship);
  }
  public partial class ResolveNameEventArgs : System.EventArgs {
    public ResolveNameEventArgs(string name) { }
    public string Name { get { return default(string); } }
    public object Value { get { return default(object); } set { } }
  }
  public delegate void ResolveNameEventHandler(object sender, System.ComponentModel.Design.Serialization.ResolveNameEventArgs e);
  [System.AttributeUsageAttribute((System.AttributeTargets)(1028), AllowMultiple=true, Inherited=true)]
  [System.ObsoleteAttribute("Use DesignerSerializerAttribute instead")]
  public sealed partial class RootDesignerSerializerAttribute : System.Attribute {
    public RootDesignerSerializerAttribute(string serializerTypeName, string baseSerializerTypeName, bool reloadable) { }
    public RootDesignerSerializerAttribute(string serializerTypeName, System.Type baseSerializerType, bool reloadable) { }
    public RootDesignerSerializerAttribute(System.Type serializerType, System.Type baseSerializerType, bool reloadable) { }
    public bool Reloadable { get { return default(bool); } }
    public string SerializerBaseTypeName { get { return default(string); } }
    public string SerializerTypeName { get { return default(string); } }
    public override object TypeId { get { return default(object); } }
  }
  public abstract partial class SerializationStore : System.IDisposable {
    protected SerializationStore() { }
    public abstract System.Collections.ICollection Errors { get; }
    public abstract void Close();
    protected virtual void Dispose(bool disposing) { }
    public abstract void Save(System.IO.Stream stream);
    void System.IDisposable.Dispose() { }
  }
}
namespace System.Configuration {
  [System.AttributeUsageAttribute((System.AttributeTargets)(128))]
  public sealed partial class ApplicationScopedSettingAttribute : System.Configuration.SettingAttribute {
    public ApplicationScopedSettingAttribute() { }
  }
  public abstract partial class ApplicationSettingsBase : System.Configuration.SettingsBase, System.ComponentModel.INotifyPropertyChanged {
    protected ApplicationSettingsBase() { }
    protected ApplicationSettingsBase(System.ComponentModel.IComponent owner) { }
    protected ApplicationSettingsBase(System.ComponentModel.IComponent owner, string settingsKey) { }
    protected ApplicationSettingsBase(string settingsKey) { }
    [System.ComponentModel.BrowsableAttribute(false)]
    public override System.Configuration.SettingsContext Context { get { return default(System.Configuration.SettingsContext); } }
    [System.MonoTODOAttribute]
    public override object this[string propertyName] { get { return default(object); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public override System.Configuration.SettingsPropertyCollection Properties { get { return default(System.Configuration.SettingsPropertyCollection); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public override System.Configuration.SettingsPropertyValueCollection PropertyValues { get { return default(System.Configuration.SettingsPropertyValueCollection); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public override System.Configuration.SettingsProviderCollection Providers { get { return default(System.Configuration.SettingsProviderCollection); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public string SettingsKey { get { return default(string); } set { } }
    public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged { add { } remove { } }
    public event System.Configuration.SettingChangingEventHandler SettingChanging { add { } remove { } }
    public event System.Configuration.SettingsLoadedEventHandler SettingsLoaded { add { } remove { } }
    public event System.Configuration.SettingsSavingEventHandler SettingsSaving { add { } remove { } }
    public object GetPreviousVersion(string propertyName) { return default(object); }
    protected virtual void OnPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e) { }
    protected virtual void OnSettingChanging(object sender, System.Configuration.SettingChangingEventArgs e) { }
    protected virtual void OnSettingsLoaded(object sender, System.Configuration.SettingsLoadedEventArgs e) { }
    protected virtual void OnSettingsSaving(object sender, System.ComponentModel.CancelEventArgs e) { }
    public void Reload() { }
    public void Reset() { }
    public override void Save() { }
    public virtual void Upgrade() { }
  }
  public sealed partial class ApplicationSettingsGroup : System.Configuration.ConfigurationSectionGroup {
    public ApplicationSettingsGroup() { }
  }
  public partial class AppSettingsReader {
    public AppSettingsReader() { }
    public object GetValue(string key, System.Type type) { return default(object); }
  }
  public sealed partial class ClientSettingsSection : System.Configuration.ConfigurationSection {
    public ClientSettingsSection() { }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("", Options=(System.Configuration.ConfigurationPropertyOptions)(1))]
    public System.Configuration.SettingElementCollection Settings { get { return default(System.Configuration.SettingElementCollection); } }
  }
  public partial class ConfigurationException : System.SystemException {
    [System.ObsoleteAttribute("This class is obsolete.  Use System.Configuration.ConfigurationErrorsException")]
    public ConfigurationException() { }
    protected ConfigurationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    [System.ObsoleteAttribute("This class is obsolete.  Use System.Configuration.ConfigurationErrorsException")]
    public ConfigurationException(string message) { }
    [System.ObsoleteAttribute("This class is obsolete.  Use System.Configuration.ConfigurationErrorsException")]
    public ConfigurationException(string message, System.Exception inner) { }
    [System.ObsoleteAttribute("This class is obsolete.  Use System.Configuration.ConfigurationErrorsException")]
    public ConfigurationException(string message, System.Exception inner, string filename, int line) { }
    [System.ObsoleteAttribute("This class is obsolete.  Use System.Configuration.ConfigurationErrorsException")]
    public ConfigurationException(string message, System.Exception inner, System.Xml.XmlNode node) { }
    [System.ObsoleteAttribute("This class is obsolete.  Use System.Configuration.ConfigurationErrorsException")]
    public ConfigurationException(string message, string filename, int line) { }
    [System.ObsoleteAttribute("This class is obsolete.  Use System.Configuration.ConfigurationErrorsException")]
    public ConfigurationException(string message, System.Xml.XmlNode node) { }
    public virtual string BareMessage { get { return default(string); } }
    public virtual string Filename { get { return default(string); } }
    public virtual int Line { get { return default(int); } }
    public override string Message { get { return default(string); } }
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    [System.ObsoleteAttribute("This class is obsolete.  Use System.Configuration.ConfigurationErrorsException")]
    public static string GetXmlNodeFilename(System.Xml.XmlNode node) { return default(string); }
    [System.ObsoleteAttribute("This class is obsolete.  Use System.Configuration.ConfigurationErrorsException")]
    public static int GetXmlNodeLineNumber(System.Xml.XmlNode node) { return default(int); }
  }
  public sealed partial class ConfigurationSettings {
    internal ConfigurationSettings() { }
    [System.ObsoleteAttribute("This property is obsolete.  Please use System.Configuration.ConfigurationManager.AppSettings")]
    public static System.Collections.Specialized.NameValueCollection AppSettings { get { return default(System.Collections.Specialized.NameValueCollection); } }
    [System.ObsoleteAttribute("This method is obsolete, it has been replaced by System.Configuration!System.Configuration.ConfigurationManager.GetSection")]
    public static object GetConfig(string sectionName) { return default(object); }
  }
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
  public sealed partial class ConfigXmlDocument : System.Xml.XmlDocument, System.Configuration.Internal.IConfigErrorInfo {
    public ConfigXmlDocument() { }
    public string Filename { get { return default(string); } }
    public int LineNumber { get { return default(int); } }
    string System.Configuration.Internal.IConfigErrorInfo.Filename { get { return default(string); } }
    int System.Configuration.Internal.IConfigErrorInfo.LineNumber { get { return default(int); } }
    public override System.Xml.XmlAttribute CreateAttribute(string prefix, string localName, string namespaceUri) { return default(System.Xml.XmlAttribute); }
    public override System.Xml.XmlCDataSection CreateCDataSection(string data) { return default(System.Xml.XmlCDataSection); }
    public override System.Xml.XmlComment CreateComment(string comment) { return default(System.Xml.XmlComment); }
    public override System.Xml.XmlElement CreateElement(string prefix, string localName, string namespaceUri) { return default(System.Xml.XmlElement); }
    public override System.Xml.XmlSignificantWhitespace CreateSignificantWhitespace(string data) { return default(System.Xml.XmlSignificantWhitespace); }
    public override System.Xml.XmlText CreateTextNode(string text) { return default(System.Xml.XmlText); }
    public override System.Xml.XmlWhitespace CreateWhitespace(string data) { return default(System.Xml.XmlWhitespace); }
    public override void Load(string filename) { }
    public void LoadSingleElement(string filename, System.Xml.XmlTextReader sourceReader) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(128))]
  public sealed partial class DefaultSettingValueAttribute : System.Attribute {
    public DefaultSettingValueAttribute(string value) { }
    public string Value { get { return default(string); } }
  }
  public partial class DictionarySectionHandler : System.Configuration.IConfigurationSectionHandler {
    public DictionarySectionHandler() { }
    protected virtual string KeyAttributeName { get { return default(string); } }
    protected virtual string ValueAttributeName { get { return default(string); } }
    public virtual object Create(object parent, object context, System.Xml.XmlNode section) { return default(object); }
  }
  public partial interface IApplicationSettingsProvider {
    System.Configuration.SettingsPropertyValue GetPreviousVersion(System.Configuration.SettingsContext context, System.Configuration.SettingsProperty property);
    void Reset(System.Configuration.SettingsContext context);
    void Upgrade(System.Configuration.SettingsContext context, System.Configuration.SettingsPropertyCollection properties);
  }
  public partial interface IConfigurationSectionHandler {
    object Create(object parent, object configContext, System.Xml.XmlNode section);
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public partial interface IConfigurationSystem {
    object GetConfig(string configKey);
    void Init();
  }
  public sealed partial class IdnElement : System.Configuration.ConfigurationElement {
    public IdnElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("enabled", DefaultValue=(System.UriIdnScope)(0), Options=(System.Configuration.ConfigurationPropertyOptions)(6))]
    public System.UriIdnScope Enabled { get { return default(System.UriIdnScope); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    public override bool Equals(object o) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }
  public partial class IgnoreSectionHandler : System.Configuration.IConfigurationSectionHandler {
    public IgnoreSectionHandler() { }
    public virtual object Create(object parent, object configContext, System.Xml.XmlNode section) { return default(object); }
  }
  public partial interface IPersistComponentSettings {
    bool SaveSettings { get; set; }
    string SettingsKey { get; set; }
    void LoadComponentSettings();
    void ResetComponentSettings();
    void SaveComponentSettings();
  }
  public sealed partial class IriParsingElement : System.Configuration.ConfigurationElement {
    public IriParsingElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("enabled", DefaultValue=false, Options=(System.Configuration.ConfigurationPropertyOptions)(6))]
    public bool Enabled { get { return default(bool); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    public override bool Equals(object o) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }
  public partial interface ISettingsProviderService {
    System.Configuration.SettingsProvider GetSettingsProvider(System.Configuration.SettingsProperty property);
  }
  public partial class LocalFileSettingsProvider : System.Configuration.SettingsProvider, System.Configuration.IApplicationSettingsProvider {
    public LocalFileSettingsProvider() { }
    public override string ApplicationName { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public System.Configuration.SettingsPropertyValue GetPreviousVersion(System.Configuration.SettingsContext context, System.Configuration.SettingsProperty property) { return default(System.Configuration.SettingsPropertyValue); }
    [System.MonoTODOAttribute]
    public override System.Configuration.SettingsPropertyValueCollection GetPropertyValues(System.Configuration.SettingsContext context, System.Configuration.SettingsPropertyCollection properties) { return default(System.Configuration.SettingsPropertyValueCollection); }
    public override void Initialize(string name, System.Collections.Specialized.NameValueCollection values) { }
    [System.MonoTODOAttribute]
    public void Reset(System.Configuration.SettingsContext context) { }
    [System.MonoTODOAttribute]
    public override void SetPropertyValues(System.Configuration.SettingsContext context, System.Configuration.SettingsPropertyValueCollection values) { }
    [System.MonoTODOAttribute]
    public void Upgrade(System.Configuration.SettingsContext context, System.Configuration.SettingsPropertyCollection properties) { }
  }
  public partial class NameValueFileSectionHandler : System.Configuration.IConfigurationSectionHandler {
    public NameValueFileSectionHandler() { }
    public object Create(object parent, object configContext, System.Xml.XmlNode section) { return default(object); }
  }
  public partial class NameValueSectionHandler : System.Configuration.IConfigurationSectionHandler {
    public NameValueSectionHandler() { }
    protected virtual string KeyAttributeName { get { return default(string); } }
    protected virtual string ValueAttributeName { get { return default(string); } }
    public object Create(object parent, object context, System.Xml.XmlNode section) { return default(object); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(128))]
  public sealed partial class NoSettingsVersionUpgradeAttribute : System.Attribute {
    public NoSettingsVersionUpgradeAttribute() { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(128))]
  public partial class SettingAttribute : System.Attribute {
    public SettingAttribute() { }
  }
  public partial class SettingChangingEventArgs : System.ComponentModel.CancelEventArgs {
    public SettingChangingEventArgs(string settingName, string settingClass, string settingKey, object newValue, bool cancel) { }
    public object NewValue { get { return default(object); } }
    public string SettingClass { get { return default(string); } }
    public string SettingKey { get { return default(string); } }
    public string SettingName { get { return default(string); } }
  }
  public delegate void SettingChangingEventHandler(object sender, System.Configuration.SettingChangingEventArgs e);
  public sealed partial class SettingElement : System.Configuration.ConfigurationElement {
    public SettingElement() { }
    public SettingElement(string name, System.Configuration.SettingsSerializeAs serializeAs) { }
    [System.Configuration.ConfigurationPropertyAttribute("name", DefaultValue="", Options=(System.Configuration.ConfigurationPropertyOptions)(6))]
    public string Name { get { return default(string); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("serializeAs", DefaultValue=(System.Configuration.SettingsSerializeAs)(0), Options=(System.Configuration.ConfigurationPropertyOptions)(2))]
    public System.Configuration.SettingsSerializeAs SerializeAs { get { return default(System.Configuration.SettingsSerializeAs); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("value", DefaultValue=null, Options=(System.Configuration.ConfigurationPropertyOptions)(2))]
    public System.Configuration.SettingValueElement Value { get { return default(System.Configuration.SettingValueElement); } set { } }
    public override bool Equals(object o) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }
  public sealed partial class SettingElementCollection : System.Configuration.ConfigurationElementCollection {
    public SettingElementCollection() { }
    public override System.Configuration.ConfigurationElementCollectionType CollectionType { get { return default(System.Configuration.ConfigurationElementCollectionType); } }
    protected override string ElementName { get { return default(string); } }
    public void Add(System.Configuration.SettingElement element) { }
    public void Clear() { }
    protected override System.Configuration.ConfigurationElement CreateNewElement() { return default(System.Configuration.ConfigurationElement); }
    public System.Configuration.SettingElement Get(string elementKey) { return default(System.Configuration.SettingElement); }
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
    public void Remove(System.Configuration.SettingElement element) { }
  }
  public partial class SettingsAttributeDictionary : System.Collections.Hashtable {
    public SettingsAttributeDictionary() { }
    public SettingsAttributeDictionary(System.Configuration.SettingsAttributeDictionary attributes) { }
  }
  public abstract partial class SettingsBase {
    protected SettingsBase() { }
    public virtual System.Configuration.SettingsContext Context { get { return default(System.Configuration.SettingsContext); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public bool IsSynchronized { get { return default(bool); } }
    public virtual object this[string propertyName] { get { return default(object); } set { } }
    public virtual System.Configuration.SettingsPropertyCollection Properties { get { return default(System.Configuration.SettingsPropertyCollection); } }
    public virtual System.Configuration.SettingsPropertyValueCollection PropertyValues { get { return default(System.Configuration.SettingsPropertyValueCollection); } }
    public virtual System.Configuration.SettingsProviderCollection Providers { get { return default(System.Configuration.SettingsProviderCollection); } }
    public void Initialize(System.Configuration.SettingsContext context, System.Configuration.SettingsPropertyCollection properties, System.Configuration.SettingsProviderCollection providers) { }
    public virtual void Save() { }
    public static System.Configuration.SettingsBase Synchronized(System.Configuration.SettingsBase settingsBase) { return default(System.Configuration.SettingsBase); }
  }
  public partial class SettingsContext : System.Collections.Hashtable {
    public SettingsContext() { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(128))]
  public sealed partial class SettingsDescriptionAttribute : System.Attribute {
    public SettingsDescriptionAttribute(string description) { }
    public string Description { get { return default(string); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
  public sealed partial class SettingsGroupDescriptionAttribute : System.Attribute {
    public SettingsGroupDescriptionAttribute(string description) { }
    public string Description { get { return default(string); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
  public sealed partial class SettingsGroupNameAttribute : System.Attribute {
    public SettingsGroupNameAttribute(string groupName) { }
    public string GroupName { get { return default(string); } }
  }
  public partial class SettingsLoadedEventArgs : System.EventArgs {
    public SettingsLoadedEventArgs(System.Configuration.SettingsProvider provider) { }
    public System.Configuration.SettingsProvider Provider { get { return default(System.Configuration.SettingsProvider); } }
  }
  public delegate void SettingsLoadedEventHandler(object sender, System.Configuration.SettingsLoadedEventArgs e);
  public enum SettingsManageability {
    Roaming = 0,
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(132))]
  public sealed partial class SettingsManageabilityAttribute : System.Attribute {
    public SettingsManageabilityAttribute(System.Configuration.SettingsManageability manageability) { }
    public System.Configuration.SettingsManageability Manageability { get { return default(System.Configuration.SettingsManageability); } }
  }
  public partial class SettingsProperty {
    public SettingsProperty(System.Configuration.SettingsProperty propertyToCopy) { }
    public SettingsProperty(string name) { }
    public SettingsProperty(string name, System.Type propertyType, System.Configuration.SettingsProvider provider, bool isReadOnly, object defaultValue, System.Configuration.SettingsSerializeAs serializeAs, System.Configuration.SettingsAttributeDictionary attributes, bool throwOnErrorDeserializing, bool throwOnErrorSerializing) { }
    public virtual System.Configuration.SettingsAttributeDictionary Attributes { get { return default(System.Configuration.SettingsAttributeDictionary); } }
    public virtual object DefaultValue { get { return default(object); } set { } }
    public virtual bool IsReadOnly { get { return default(bool); } set { } }
    public virtual string Name { get { return default(string); } set { } }
    public virtual System.Type PropertyType { get { return default(System.Type); } set { } }
    public virtual System.Configuration.SettingsProvider Provider { get { return default(System.Configuration.SettingsProvider); } set { } }
    public virtual System.Configuration.SettingsSerializeAs SerializeAs { get { return default(System.Configuration.SettingsSerializeAs); } set { } }
    public bool ThrowOnErrorDeserializing { get { return default(bool); } set { } }
    public bool ThrowOnErrorSerializing { get { return default(bool); } set { } }
  }
  public partial class SettingsPropertyCollection : System.Collections.ICollection, System.Collections.IEnumerable, System.ICloneable {
    public SettingsPropertyCollection() { }
    public int Count { get { return default(int); } }
    public bool IsSynchronized { get { return default(bool); } }
    public System.Configuration.SettingsProperty this[string name] { get { return default(System.Configuration.SettingsProperty); } }
    public object SyncRoot { get { return default(object); } }
    public void Add(System.Configuration.SettingsProperty property) { }
    public void Clear() { }
    public object Clone() { return default(object); }
    public void CopyTo(System.Array array, int index) { }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    protected virtual void OnAdd(System.Configuration.SettingsProperty property) { }
    protected virtual void OnAddComplete(System.Configuration.SettingsProperty property) { }
    protected virtual void OnClear() { }
    protected virtual void OnClearComplete() { }
    protected virtual void OnRemove(System.Configuration.SettingsProperty property) { }
    protected virtual void OnRemoveComplete(System.Configuration.SettingsProperty property) { }
    public void Remove(string name) { }
    public void SetReadOnly() { }
  }
  public partial class SettingsPropertyIsReadOnlyException : System.Exception {
    public SettingsPropertyIsReadOnlyException() { }
    protected SettingsPropertyIsReadOnlyException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public SettingsPropertyIsReadOnlyException(string message) { }
    public SettingsPropertyIsReadOnlyException(string message, System.Exception innerException) { }
  }
  public partial class SettingsPropertyNotFoundException : System.Exception {
    public SettingsPropertyNotFoundException() { }
    protected SettingsPropertyNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public SettingsPropertyNotFoundException(string message) { }
    public SettingsPropertyNotFoundException(string message, System.Exception innerException) { }
  }
  public partial class SettingsPropertyValue {
    public SettingsPropertyValue(System.Configuration.SettingsProperty property) { }
    public bool Deserialized { get { return default(bool); } set { } }
    public bool IsDirty { get { return default(bool); } set { } }
    public string Name { get { return default(string); } }
    public System.Configuration.SettingsProperty Property { get { return default(System.Configuration.SettingsProperty); } }
    public object PropertyValue { get { return default(object); } set { } }
    public object SerializedValue { get { return default(object); } set { } }
    public bool UsingDefaultValue { get { return default(bool); } }
  }
  public partial class SettingsPropertyValueCollection : System.Collections.ICollection, System.Collections.IEnumerable, System.ICloneable {
    public SettingsPropertyValueCollection() { }
    public int Count { get { return default(int); } }
    public bool IsSynchronized { get { return default(bool); } }
    public System.Configuration.SettingsPropertyValue this[string name] { get { return default(System.Configuration.SettingsPropertyValue); } }
    public object SyncRoot { get { return default(object); } }
    public void Add(System.Configuration.SettingsPropertyValue property) { }
    public void Clear() { }
    public object Clone() { return default(object); }
    public void CopyTo(System.Array array, int index) { }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public void Remove(string name) { }
    public void SetReadOnly() { }
  }
  public partial class SettingsPropertyWrongTypeException : System.Exception {
    public SettingsPropertyWrongTypeException() { }
    protected SettingsPropertyWrongTypeException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public SettingsPropertyWrongTypeException(string message) { }
    public SettingsPropertyWrongTypeException(string message, System.Exception innerException) { }
  }
  public abstract partial class SettingsProvider : System.Configuration.Provider.ProviderBase {
    protected SettingsProvider() { }
    public abstract string ApplicationName { get; set; }
    public abstract System.Configuration.SettingsPropertyValueCollection GetPropertyValues(System.Configuration.SettingsContext context, System.Configuration.SettingsPropertyCollection collection);
    public abstract void SetPropertyValues(System.Configuration.SettingsContext context, System.Configuration.SettingsPropertyValueCollection collection);
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(132))]
  public sealed partial class SettingsProviderAttribute : System.Attribute {
    public SettingsProviderAttribute(string providerTypeName) { }
    public SettingsProviderAttribute(System.Type providerType) { }
    public string ProviderTypeName { get { return default(string); } }
  }
  public partial class SettingsProviderCollection : System.Configuration.Provider.ProviderCollection {
    public SettingsProviderCollection() { }
    public new System.Configuration.SettingsProvider this[string name] { get { return default(System.Configuration.SettingsProvider); } }
    public override void Add(System.Configuration.Provider.ProviderBase provider) { }
  }
  public delegate void SettingsSavingEventHandler(object sender, System.ComponentModel.CancelEventArgs e);
  public enum SettingsSerializeAs {
    Binary = 2,
    ProviderSpecific = 3,
    String = 0,
    Xml = 1,
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(132))]
  public sealed partial class SettingsSerializeAsAttribute : System.Attribute {
    public SettingsSerializeAsAttribute(System.Configuration.SettingsSerializeAs serializeAs) { }
    public System.Configuration.SettingsSerializeAs SerializeAs { get { return default(System.Configuration.SettingsSerializeAs); } }
  }
  public sealed partial class SettingValueElement : System.Configuration.ConfigurationElement {
    [System.MonoTODOAttribute]
    public SettingValueElement() { }
    [System.MonoTODOAttribute]
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    public System.Xml.XmlNode ValueXml { get { return default(System.Xml.XmlNode); } set { } }
    [System.MonoTODOAttribute]
    protected override void DeserializeElement(System.Xml.XmlReader reader, bool serializeCollectionKey) { }
    public override bool Equals(object settingValue) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    protected override bool IsModified() { return default(bool); }
    protected override void Reset(System.Configuration.ConfigurationElement parentElement) { }
    protected override void ResetModified() { }
    protected override bool SerializeToXmlElement(System.Xml.XmlWriter writer, string elementName) { return default(bool); }
    protected override void Unmerge(System.Configuration.ConfigurationElement sourceElement, System.Configuration.ConfigurationElement parentElement, System.Configuration.ConfigurationSaveMode saveMode) { }
  }
  public partial class SingleTagSectionHandler : System.Configuration.IConfigurationSectionHandler {
    public SingleTagSectionHandler() { }
    public virtual object Create(object parent, object context, System.Xml.XmlNode section) { return default(object); }
  }
  public enum SpecialSetting {
    ConnectionString = 0,
    WebServiceUrl = 1,
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(132))]
  public sealed partial class SpecialSettingAttribute : System.Attribute {
    public SpecialSettingAttribute(System.Configuration.SpecialSetting setting) { }
    public System.Configuration.SpecialSetting SpecialSetting { get { return default(System.Configuration.SpecialSetting); } }
  }
  public sealed partial class UriSection : System.Configuration.ConfigurationSection {
    public UriSection() { }
    [System.Configuration.ConfigurationPropertyAttribute("idn")]
    public System.Configuration.IdnElement Idn { get { return default(System.Configuration.IdnElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("iriParsing")]
    public System.Configuration.IriParsingElement IriParsing { get { return default(System.Configuration.IriParsingElement); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(128))]
  public sealed partial class UserScopedSettingAttribute : System.Configuration.SettingAttribute {
    public UserScopedSettingAttribute() { }
  }
  public sealed partial class UserSettingsGroup : System.Configuration.ConfigurationSectionGroup {
    public UserSettingsGroup() { }
  }
}
namespace System.Diagnostics {
  [System.Diagnostics.SwitchLevelAttribute(typeof(bool))]
  public partial class BooleanSwitch : System.Diagnostics.Switch {
    public BooleanSwitch(string displayName, string description) : base (default(string), default(string)) { }
    public BooleanSwitch(string displayName, string description, string defaultSwitchValue) : base (default(string), default(string)) { }
    public bool Enabled { get { return default(bool); } set { } }
    protected override void OnValueChanged() { }
  }
  public partial class ConsoleTraceListener : System.Diagnostics.TextWriterTraceListener {
    public ConsoleTraceListener() { }
    public ConsoleTraceListener(bool useErrorStream) { }
  }
  public partial class CorrelationManager {
    internal CorrelationManager() { }
    public System.Guid ActivityId { get { return default(System.Guid); } set { } }
    public System.Collections.Stack LogicalOperationStack { get { return default(System.Collections.Stack); } }
    public void StartLogicalOperation() { }
    public void StartLogicalOperation(object operationId) { }
    public void StopLogicalOperation() { }
  }
  [System.ComponentModel.TypeConverterAttribute("System.Diagnostics.Design.CounterCreationDataConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  public partial class CounterCreationData {
    public CounterCreationData() { }
    public CounterCreationData(string counterName, string counterHelp, System.Diagnostics.PerformanceCounterType counterType) { }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Diagnostics.MonitoringDescriptionAttribute("Description of this counter.")]
    public string CounterHelp { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.TypeConverterAttribute("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Diagnostics.MonitoringDescriptionAttribute("Name of this counter.")]
    public string CounterName { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Diagnostics.PerformanceCounterType), "NumberOfItems32")]
    [System.Diagnostics.MonitoringDescriptionAttribute("Type of this counter.")]
    public System.Diagnostics.PerformanceCounterType CounterType { get { return default(System.Diagnostics.PerformanceCounterType); } set { } }
  }
  public partial class CounterCreationDataCollection : System.Collections.CollectionBase {
    public CounterCreationDataCollection() { }
    public CounterCreationDataCollection(System.Diagnostics.CounterCreationData[] value) { }
    public CounterCreationDataCollection(System.Diagnostics.CounterCreationDataCollection value) { }
    public System.Diagnostics.CounterCreationData this[int index] { get { return default(System.Diagnostics.CounterCreationData); } set { } }
    public int Add(System.Diagnostics.CounterCreationData value) { return default(int); }
    public void AddRange(System.Diagnostics.CounterCreationData[] value) { }
    public void AddRange(System.Diagnostics.CounterCreationDataCollection value) { }
    public bool Contains(System.Diagnostics.CounterCreationData value) { return default(bool); }
    public void CopyTo(System.Diagnostics.CounterCreationData[] array, int index) { }
    public int IndexOf(System.Diagnostics.CounterCreationData value) { return default(int); }
    public void Insert(int index, System.Diagnostics.CounterCreationData value) { }
    protected override void OnValidate(object value) { }
    public virtual void Remove(System.Diagnostics.CounterCreationData value) { }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct CounterSample {
    public static System.Diagnostics.CounterSample Empty;
    public CounterSample(long rawValue, long baseValue, long counterFrequency, long systemFrequency, long timeStamp, long timeStamp100nSec, System.Diagnostics.PerformanceCounterType counterType) { throw new System.NotImplementedException(); }
    public CounterSample(long rawValue, long baseValue, long counterFrequency, long systemFrequency, long timeStamp, long timeStamp100nSec, System.Diagnostics.PerformanceCounterType counterType, long counterTimeStamp) { throw new System.NotImplementedException(); }
    public long BaseValue { get { return default(long); } }
    public long CounterFrequency { get { return default(long); } }
    public long CounterTimeStamp { get { return default(long); } }
    public System.Diagnostics.PerformanceCounterType CounterType { get { return default(System.Diagnostics.PerformanceCounterType); } }
    public long RawValue { get { return default(long); } }
    public long SystemFrequency { get { return default(long); } }
    public long TimeStamp { get { return default(long); } }
    public long TimeStamp100nSec { get { return default(long); } }
    public static float Calculate(System.Diagnostics.CounterSample counterSample) { return default(float); }
    public static float Calculate(System.Diagnostics.CounterSample counterSample, System.Diagnostics.CounterSample nextCounterSample) { return default(float); }
    public bool Equals(System.Diagnostics.CounterSample other) { return default(bool); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Diagnostics.CounterSample obj1, System.Diagnostics.CounterSample obj2) { return default(bool); }
    public static bool operator !=(System.Diagnostics.CounterSample obj1, System.Diagnostics.CounterSample obj2) { return default(bool); }
  }
  public static partial class CounterSampleCalculator {
    public static float ComputeCounterValue(System.Diagnostics.CounterSample newSample) { return default(float); }
    [System.MonoTODOAttribute("What's the algorithm?")]
    public static float ComputeCounterValue(System.Diagnostics.CounterSample oldSample, System.Diagnostics.CounterSample newSample) { return default(float); }
  }
  public partial class DataReceivedEventArgs : System.EventArgs {
    internal DataReceivedEventArgs() { }
    public string Data { get { return default(string); } }
  }
  public delegate void DataReceivedEventHandler(object sender, System.Diagnostics.DataReceivedEventArgs e);
  public static partial class Debug {
    public static bool AutoFlush { get { return default(bool); } set { } }
    public static int IndentLevel { get { return default(int); } set { } }
    public static int IndentSize { get { return default(int); } set { } }
    public static System.Diagnostics.TraceListenerCollection Listeners { get { return default(System.Diagnostics.TraceListenerCollection); } }
    [System.Diagnostics.ConditionalAttribute("DEBUG")]
    public static void Assert(bool condition) { }
    [System.Diagnostics.ConditionalAttribute("DEBUG")]
    public static void Assert(bool condition, string message) { }
    [System.Diagnostics.ConditionalAttribute("DEBUG")]
    public static void Assert(bool condition, string message, string detailMessage) { }
    [System.Diagnostics.ConditionalAttribute("DEBUG")]
    public static void Assert(bool condition, string message, string detailMessageFormat, params System.Object[] args) { }
    [System.Diagnostics.ConditionalAttribute("DEBUG")]
    public static void Close() { }
    [System.Diagnostics.ConditionalAttribute("DEBUG")]
    public static void Fail(string message) { }
    [System.Diagnostics.ConditionalAttribute("DEBUG")]
    public static void Fail(string message, string detailMessage) { }
    [System.Diagnostics.ConditionalAttribute("DEBUG")]
    public static void Flush() { }
    [System.Diagnostics.ConditionalAttribute("DEBUG")]
    public static void Indent() { }
    [System.Diagnostics.ConditionalAttribute("DEBUG")]
    public static void Print(string message) { }
    [System.Diagnostics.ConditionalAttribute("DEBUG")]
    public static void Print(string format, params System.Object[] args) { }
    [System.Diagnostics.ConditionalAttribute("DEBUG")]
    public static void Unindent() { }
    [System.Diagnostics.ConditionalAttribute("DEBUG")]
    public static void Write(object value) { }
    [System.Diagnostics.ConditionalAttribute("DEBUG")]
    public static void Write(object value, string category) { }
    [System.Diagnostics.ConditionalAttribute("DEBUG")]
    public static void Write(string message) { }
    [System.Diagnostics.ConditionalAttribute("DEBUG")]
    public static void Write(string message, string category) { }
    [System.Diagnostics.ConditionalAttribute("DEBUG")]
    public static void WriteIf(bool condition, object value) { }
    [System.Diagnostics.ConditionalAttribute("DEBUG")]
    public static void WriteIf(bool condition, object value, string category) { }
    [System.Diagnostics.ConditionalAttribute("DEBUG")]
    public static void WriteIf(bool condition, string message) { }
    [System.Diagnostics.ConditionalAttribute("DEBUG")]
    public static void WriteIf(bool condition, string message, string category) { }
    [System.Diagnostics.ConditionalAttribute("DEBUG")]
    public static void WriteLine(object value) { }
    [System.Diagnostics.ConditionalAttribute("DEBUG")]
    public static void WriteLine(object value, string category) { }
    [System.Diagnostics.ConditionalAttribute("DEBUG")]
    public static void WriteLine(string message) { }
    [System.Diagnostics.ConditionalAttribute("DEBUG")]
    public static void WriteLine(string format, params System.Object[] args) { }
    [System.Diagnostics.ConditionalAttribute("DEBUG")]
    public static void WriteLine(string message, string category) { }
    [System.Diagnostics.ConditionalAttribute("DEBUG")]
    public static void WriteLineIf(bool condition, object value) { }
    [System.Diagnostics.ConditionalAttribute("DEBUG")]
    public static void WriteLineIf(bool condition, object value, string category) { }
    [System.Diagnostics.ConditionalAttribute("DEBUG")]
    public static void WriteLineIf(bool condition, string message) { }
    [System.Diagnostics.ConditionalAttribute("DEBUG")]
    public static void WriteLineIf(bool condition, string message, string category) { }
  }
  public partial class DefaultTraceListener : System.Diagnostics.TraceListener {
    public DefaultTraceListener() { }
    [System.MonoTODOAttribute("AssertUiEnabled defaults to False; should follow Environment.UserInteractive.")]
    public bool AssertUiEnabled { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public string LogFileName { get { return default(string); } set { } }
    public override void Fail(string message) { }
    public override void Fail(string message, string detailMessage) { }
    public override void Write(string message) { }
    public override void WriteLine(string message) { }
  }
  public partial class DelimitedListTraceListener : System.Diagnostics.TextWriterTraceListener {
    public DelimitedListTraceListener(System.IO.Stream stream) { }
    public DelimitedListTraceListener(System.IO.Stream stream, string name) { }
    public DelimitedListTraceListener(System.IO.TextWriter writer) { }
    public DelimitedListTraceListener(System.IO.TextWriter writer, string name) { }
    public DelimitedListTraceListener(string fileName) { }
    public DelimitedListTraceListener(string fileName, string name) { }
    public string Delimiter { get { return default(string); } set { } }
    protected internal override System.String[] GetSupportedAttributes() { return default(System.String[]); }
    public override void TraceData(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, object data) { }
    public override void TraceData(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, params System.Object[] data) { }
    public override void TraceEvent(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, string message) { }
    public override void TraceEvent(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, string format, params System.Object[] args) { }
  }
  [System.ObsoleteAttribute("This class is obsoleted")]
  public partial class DiagnosticsConfigurationHandler : System.Configuration.IConfigurationSectionHandler {
    public DiagnosticsConfigurationHandler() { }
    public virtual object Create(object parent, object configContext, System.Xml.XmlNode section) { return default(object); }
  }
  public partial class EntryWrittenEventArgs : System.EventArgs {
    public EntryWrittenEventArgs() { }
    public EntryWrittenEventArgs(System.Diagnostics.EventLogEntry entry) { }
    public System.Diagnostics.EventLogEntry Entry { get { return default(System.Diagnostics.EventLogEntry); } }
  }
  public delegate void EntryWrittenEventHandler(object sender, System.Diagnostics.EntryWrittenEventArgs e);
  public partial class EventInstance {
    public EventInstance(long instanceId, int categoryId) { }
    public EventInstance(long instanceId, int categoryId, System.Diagnostics.EventLogEntryType entryType) { }
    public int CategoryId { get { return default(int); } set { } }
    public System.Diagnostics.EventLogEntryType EntryType { get { return default(System.Diagnostics.EventLogEntryType); } set { } }
    public long InstanceId { get { return default(long); } set { } }
  }
  [System.ComponentModel.DefaultEventAttribute("EntryWritten")]
  [System.ComponentModel.InstallerTypeAttribute(typeof(System.Diagnostics.EventLogInstaller))]
  [System.Diagnostics.MonitoringDescriptionAttribute("Represents an event log")]
  public partial class EventLog : System.ComponentModel.Component, System.ComponentModel.ISupportInitialize {
    public EventLog() { }
    public EventLog(string logName) { }
    public EventLog(string logName, string machineName) { }
    public EventLog(string logName, string machineName, string source) { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Diagnostics.MonitoringDescriptionAttribute("If enabled raises event when a log is written.")]
    public bool EnableRaisingEvents { get { return default(bool); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Diagnostics.MonitoringDescriptionAttribute("The entries in the log.")]
    public System.Diagnostics.EventLogEntryCollection Entries { get { return default(System.Diagnostics.EventLogEntryCollection); } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.ReadOnlyAttribute(true)]
    [System.ComponentModel.RecommendedAsConfigurableAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute("System.Diagnostics.Design.LogConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Diagnostics.MonitoringDescriptionAttribute("Name of the log that is read and written.")]
    public string Log { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public string LogDisplayName { get { return default(string); } }
    [System.ComponentModel.DefaultValueAttribute(".")]
    [System.ComponentModel.ReadOnlyAttribute(true)]
    [System.ComponentModel.RecommendedAsConfigurableAttribute(true)]
    [System.Diagnostics.MonitoringDescriptionAttribute("Name of the machine that this log get written to.")]
    public string MachineName { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.MonoTODOAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public long MaximumKilobytes { get { return default(long); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.MonoTODOAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public int MinimumRetentionDays { get { return default(int); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.MonoTODOAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public System.Diagnostics.OverflowAction OverflowAction { get { return default(System.Diagnostics.OverflowAction); } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.ReadOnlyAttribute(true)]
    [System.ComponentModel.RecommendedAsConfigurableAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Diagnostics.MonitoringDescriptionAttribute("The application name that writes the log.")]
    public string Source { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Diagnostics.MonitoringDescriptionAttribute("An object that synchronizes event handler calls.")]
    public System.ComponentModel.ISynchronizeInvoke SynchronizingObject { get { return default(System.ComponentModel.ISynchronizeInvoke); } set { } }
    [System.Diagnostics.MonitoringDescriptionAttribute("Raised for each EventLog entry written.")]
    public event System.Diagnostics.EntryWrittenEventHandler EntryWritten { add { } remove { } }
    public void BeginInit() { }
    public void Clear() { }
    public void Close() { }
    [System.MonoNotSupportedAttribute("remote machine is not supported")]
    public static void CreateEventSource(System.Diagnostics.EventSourceCreationData sourceData) { }
    public static void CreateEventSource(string source, string logName) { }
    [System.ObsoleteAttribute("use CreateEventSource(EventSourceCreationData) instead")]
    public static void CreateEventSource(string source, string logName, string machineName) { }
    public static void Delete(string logName) { }
    [System.MonoNotSupportedAttribute("remote machine is not supported")]
    public static void Delete(string logName, string machineName) { }
    public static void DeleteEventSource(string source) { }
    [System.MonoNotSupportedAttribute("remote machine is not supported")]
    public static void DeleteEventSource(string source, string machineName) { }
    protected override void Dispose(bool disposing) { }
    public void EndInit() { }
    public static bool Exists(string logName) { return default(bool); }
    [System.MonoNotSupportedAttribute("remote machine is not supported")]
    public static bool Exists(string logName, string machineName) { return default(bool); }
    public static System.Diagnostics.EventLog[] GetEventLogs() { return default(System.Diagnostics.EventLog[]); }
    [System.MonoNotSupportedAttribute("remote machine is not supported")]
    public static System.Diagnostics.EventLog[] GetEventLogs(string machineName) { return default(System.Diagnostics.EventLog[]); }
    [System.MonoNotSupportedAttribute("remote machine is not supported")]
    public static string LogNameFromSourceName(string source, string machineName) { return default(string); }
    [System.MonoTODOAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public void ModifyOverflowPolicy(System.Diagnostics.OverflowAction action, int retentionDays) { }
    [System.MonoTODOAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public void RegisterDisplayName(string resourceFile, long resourceId) { }
    public static bool SourceExists(string source) { return default(bool); }
    [System.MonoNotSupportedAttribute("remote machine is not supported")]
    public static bool SourceExists(string source, string machineName) { return default(bool); }
    public void WriteEntry(string message) { }
    public void WriteEntry(string message, System.Diagnostics.EventLogEntryType type) { }
    public void WriteEntry(string message, System.Diagnostics.EventLogEntryType type, int eventID) { }
    public void WriteEntry(string message, System.Diagnostics.EventLogEntryType type, int eventID, short category) { }
    public void WriteEntry(string message, System.Diagnostics.EventLogEntryType type, int eventID, short category, System.Byte[] rawData) { }
    public static void WriteEntry(string source, string message) { }
    public static void WriteEntry(string source, string message, System.Diagnostics.EventLogEntryType type) { }
    public static void WriteEntry(string source, string message, System.Diagnostics.EventLogEntryType type, int eventID) { }
    public static void WriteEntry(string source, string message, System.Diagnostics.EventLogEntryType type, int eventID, short category) { }
    public static void WriteEntry(string source, string message, System.Diagnostics.EventLogEntryType type, int eventID, short category, System.Byte[] rawData) { }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public void WriteEvent(System.Diagnostics.EventInstance instance, System.Byte[] data, params System.Object[] values) { }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public void WriteEvent(System.Diagnostics.EventInstance instance, params System.Object[] values) { }
    public static void WriteEvent(string source, System.Diagnostics.EventInstance instance, System.Byte[] data, params System.Object[] values) { }
    public static void WriteEvent(string source, System.Diagnostics.EventInstance instance, params System.Object[] values) { }
  }
  [System.ComponentModel.DesignTimeVisibleAttribute(false)]
  [System.ComponentModel.ToolboxItemAttribute(false)]
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
  public sealed partial class EventLogEntry : System.ComponentModel.Component, System.Runtime.Serialization.ISerializable {
    internal EventLogEntry() { }
    [System.Diagnostics.MonitoringDescriptionAttribute("The category of this event entry.")]
    public string Category { get { return default(string); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("An ID for the category of this event entry.")]
    public short CategoryNumber { get { return default(short); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("Binary data associated with this event entry.")]
    public System.Byte[] Data { get { return default(System.Byte[]); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The type of this event entry.")]
    public System.Diagnostics.EventLogEntryType EntryType { get { return default(System.Diagnostics.EventLogEntryType); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("An ID number for this event entry.")]
    [System.ObsoleteAttribute("Use InstanceId")]
    public int EventID { get { return default(int); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("Sequence numer of this event entry.")]
    public int Index { get { return default(int); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The instance ID for this event entry.")]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public long InstanceId { get { return default(long); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The Computer on which this event entry occured.")]
    public string MachineName { get { return default(string); } }
    [System.ComponentModel.EditorAttribute("System.ComponentModel.Design.BinaryEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Diagnostics.MonitoringDescriptionAttribute("The message of this event entry.")]
    public string Message { get { return default(string); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("Application strings for this event entry.")]
    public System.String[] ReplacementStrings { get { return default(System.String[]); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The source application of this event entry.")]
    public string Source { get { return default(string); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("Generation time of this event entry.")]
    public System.DateTime TimeGenerated { get { return default(System.DateTime); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The time at which this event entry was written to the logfile.")]
    public System.DateTime TimeWritten { get { return default(System.DateTime); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The name of a user associated with this event entry.")]
    public string UserName { get { return default(string); } }
    public bool Equals(System.Diagnostics.EventLogEntry otherEntry) { return default(bool); }
    [System.MonoTODOAttribute("Needs serialization support")]
    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial class EventLogEntryCollection : System.Collections.ICollection, System.Collections.IEnumerable {
    internal EventLogEntryCollection() { }
    public int Count { get { return default(int); } }
    public virtual System.Diagnostics.EventLogEntry this[int index] { get { return default(System.Diagnostics.EventLogEntry); } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    public void CopyTo(System.Diagnostics.EventLogEntry[] eventLogEntries, int index) { }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
  }
  public enum EventLogEntryType {
    Error = 1,
    FailureAudit = 16,
    Information = 4,
    SuccessAudit = 8,
    Warning = 2,
  }
  public sealed partial class EventLogPermission : System.Security.Permissions.ResourcePermissionBase {
    public EventLogPermission() { }
    public EventLogPermission(System.Diagnostics.EventLogPermissionAccess permissionAccess, string machineName) { }
    public EventLogPermission(System.Diagnostics.EventLogPermissionEntry[] permissionAccessEntries) { }
    public EventLogPermission(System.Security.Permissions.PermissionState state) { }
    public System.Diagnostics.EventLogPermissionEntryCollection PermissionEntries { get { return default(System.Diagnostics.EventLogPermissionEntryCollection); } }
  }
  [System.FlagsAttribute]
  public enum EventLogPermissionAccess {
    Administer = 48,
    [System.ObsoleteAttribute]
    Audit = 10,
    [System.ObsoleteAttribute]
    Browse = 2,
    [System.ObsoleteAttribute]
    Instrument = 6,
    None = 0,
    Write = 16,
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(621), AllowMultiple=true, Inherited=false)]
  public partial class EventLogPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute {
    public EventLogPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
    public string MachineName { get { return default(string); } set { } }
    public System.Diagnostics.EventLogPermissionAccess PermissionAccess { get { return default(System.Diagnostics.EventLogPermissionAccess); } set { } }
    public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
  }
  public partial class EventLogPermissionEntry {
    public EventLogPermissionEntry(System.Diagnostics.EventLogPermissionAccess permissionAccess, string machineName) { }
    public string MachineName { get { return default(string); } }
    public System.Diagnostics.EventLogPermissionAccess PermissionAccess { get { return default(System.Diagnostics.EventLogPermissionAccess); } }
  }
  public partial class EventLogPermissionEntryCollection : System.Collections.CollectionBase {
    internal EventLogPermissionEntryCollection() { }
    public System.Diagnostics.EventLogPermissionEntry this[int index] { get { return default(System.Diagnostics.EventLogPermissionEntry); } set { } }
    public int Add(System.Diagnostics.EventLogPermissionEntry value) { return default(int); }
    public void AddRange(System.Diagnostics.EventLogPermissionEntry[] value) { }
    public void AddRange(System.Diagnostics.EventLogPermissionEntryCollection value) { }
    public bool Contains(System.Diagnostics.EventLogPermissionEntry value) { return default(bool); }
    public void CopyTo(System.Diagnostics.EventLogPermissionEntry[] array, int index) { }
    public int IndexOf(System.Diagnostics.EventLogPermissionEntry value) { return default(int); }
    public void Insert(int index, System.Diagnostics.EventLogPermissionEntry value) { }
    protected override void OnClear() { }
    protected override void OnInsert(int index, object value) { }
    protected override void OnRemove(int index, object value) { }
    protected override void OnSet(int index, object oldValue, object newValue) { }
    public void Remove(System.Diagnostics.EventLogPermissionEntry value) { }
  }
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
  public sealed partial class EventLogTraceListener : System.Diagnostics.TraceListener {
    public EventLogTraceListener() { }
    public EventLogTraceListener(System.Diagnostics.EventLog eventLog) { }
    public EventLogTraceListener(string source) { }
    public System.Diagnostics.EventLog EventLog { get { return default(System.Diagnostics.EventLog); } set { } }
    public override string Name { get { return default(string); } set { } }
    public override void Close() { }
    protected override void Dispose(bool disposing) { }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public override void TraceData(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, object data) { }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public override void TraceData(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, params System.Object[] data) { }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public override void TraceEvent(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, string message) { }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public override void TraceEvent(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, string format, params System.Object[] args) { }
    public override void Write(string message) { }
    public override void WriteLine(string message) { }
  }
  public partial class EventSourceCreationData {
    public EventSourceCreationData(string source, string logName) { }
    public int CategoryCount { get { return default(int); } set { } }
    public string CategoryResourceFile { get { return default(string); } set { } }
    public string LogName { get { return default(string); } set { } }
    public string MachineName { get { return default(string); } set { } }
    public string MessageResourceFile { get { return default(string); } set { } }
    public string ParameterResourceFile { get { return default(string); } set { } }
    public string Source { get { return default(string); } set { } }
  }
  public partial class EventTypeFilter : System.Diagnostics.TraceFilter {
    public EventTypeFilter(System.Diagnostics.SourceLevels eventType) { }
    public System.Diagnostics.SourceLevels EventType { get { return default(System.Diagnostics.SourceLevels); } set { } }
    public override bool ShouldTrace(System.Diagnostics.TraceEventCache cache, string source, System.Diagnostics.TraceEventType eventType, int id, string formatOrMessage, System.Object[] args, object data1, System.Object[] data) { return default(bool); }
  }
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
  public sealed partial class FileVersionInfo {
    internal FileVersionInfo() { }
    public string Comments { get { return default(string); } }
    public string CompanyName { get { return default(string); } }
    public int FileBuildPart { get { return default(int); } }
    public string FileDescription { get { return default(string); } }
    public int FileMajorPart { get { return default(int); } }
    public int FileMinorPart { get { return default(int); } }
    public string FileName { get { return default(string); } }
    public int FilePrivatePart { get { return default(int); } }
    public string FileVersion { get { return default(string); } }
    public string InternalName { get { return default(string); } }
    public bool IsDebug { get { return default(bool); } }
    public bool IsPatched { get { return default(bool); } }
    public bool IsPreRelease { get { return default(bool); } }
    public bool IsPrivateBuild { get { return default(bool); } }
    public bool IsSpecialBuild { get { return default(bool); } }
    public string Language { get { return default(string); } }
    public string LegalCopyright { get { return default(string); } }
    public string LegalTrademarks { get { return default(string); } }
    public string OriginalFilename { get { return default(string); } }
    public string PrivateBuild { get { return default(string); } }
    public int ProductBuildPart { get { return default(int); } }
    public int ProductMajorPart { get { return default(int); } }
    public int ProductMinorPart { get { return default(int); } }
    public string ProductName { get { return default(string); } }
    public int ProductPrivatePart { get { return default(int); } }
    public string ProductVersion { get { return default(string); } }
    public string SpecialBuild { get { return default(string); } }
    public static System.Diagnostics.FileVersionInfo GetVersionInfo(string fileName) { return default(System.Diagnostics.FileVersionInfo); }
    public override string ToString() { return default(string); }
  }
  [System.Runtime.InteropServices.GuidAttribute("73386977-D6FD-11D2-BED5-00C04F79E3AE")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
  public partial interface ICollectData {
    void CloseData();
    void CollectData(int id, System.IntPtr valueName, System.IntPtr data, int totalBytes, out System.IntPtr res);
  }
  public partial class InstanceData {
    public InstanceData(string instanceName, System.Diagnostics.CounterSample sample) { }
    public string InstanceName { get { return default(string); } }
    public long RawValue { get { return default(long); } }
    public System.Diagnostics.CounterSample Sample { get { return default(System.Diagnostics.CounterSample); } }
  }
  public partial class InstanceDataCollection : System.Collections.DictionaryBase {
    [System.ObsoleteAttribute("Use InstanceDataCollectionCollection indexer instead.")]
    public InstanceDataCollection(string counterName) { }
    public string CounterName { get { return default(string); } }
    public System.Diagnostics.InstanceData this[string instanceName] { get { return default(System.Diagnostics.InstanceData); } }
    public System.Collections.ICollection Keys { get { return default(System.Collections.ICollection); } }
    public System.Collections.ICollection Values { get { return default(System.Collections.ICollection); } }
    public bool Contains(string instanceName) { return default(bool); }
    public void CopyTo(System.Diagnostics.InstanceData[] instances, int index) { }
  }
  public partial class InstanceDataCollectionCollection : System.Collections.DictionaryBase {
    [System.ObsoleteAttribute("Use PerformanceCounterCategory.ReadCategory()")]
    public InstanceDataCollectionCollection() { }
    public System.Diagnostics.InstanceDataCollection this[string counterName] { get { return default(System.Diagnostics.InstanceDataCollection); } }
    public System.Collections.ICollection Keys { get { return default(System.Collections.ICollection); } }
    public System.Collections.ICollection Values { get { return default(System.Collections.ICollection); } }
    public bool Contains(string counterName) { return default(bool); }
    public void CopyTo(System.Diagnostics.InstanceDataCollection[] counters, int index) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(32767))]
  public partial class MonitoringDescriptionAttribute : System.ComponentModel.DescriptionAttribute {
    public MonitoringDescriptionAttribute(string description) { }
    public override string Description { get { return default(string); } }
  }
  public enum OverflowAction {
    DoNotOverwrite = -1,
    OverwriteAsNeeded = 0,
    OverwriteOlder = 1,
  }
  [System.ComponentModel.InstallerTypeAttribute(typeof(System.Diagnostics.PerformanceCounterInstaller))]
  public sealed partial class PerformanceCounter : System.ComponentModel.Component, System.ComponentModel.ISupportInitialize {
    [System.ObsoleteAttribute]
    public static int DefaultFileMappingSize;
    public PerformanceCounter() { }
    public PerformanceCounter(string categoryName, string counterName) { }
    public PerformanceCounter(string categoryName, string counterName, bool readOnly) { }
    public PerformanceCounter(string categoryName, string counterName, string instanceName) { }
    public PerformanceCounter(string categoryName, string counterName, string instanceName, bool readOnly) { }
    public PerformanceCounter(string categoryName, string counterName, string instanceName, string machineName) { }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.ReadOnlyAttribute(true)]
    [System.ComponentModel.RecommendedAsConfigurableAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute("System.Diagnostics.Design.CategoryValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.SRDescriptionAttribute("The category name for this performance counter.")]
    public string CategoryName { get { return default(string); } set { } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.ReadOnlyAttribute(true)]
    [System.Diagnostics.MonitoringDescriptionAttribute("A description describing the counter.")]
    [System.MonoTODOAttribute]
    public string CounterHelp { get { return default(string); } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.ReadOnlyAttribute(true)]
    [System.ComponentModel.RecommendedAsConfigurableAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute("System.Diagnostics.Design.CounterNameConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.SRDescriptionAttribute("The name of this performance counter.")]
    public string CounterName { get { return default(string); } set { } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Diagnostics.MonitoringDescriptionAttribute("The type of the counter.")]
    public System.Diagnostics.PerformanceCounterType CounterType { get { return default(System.Diagnostics.PerformanceCounterType); } }
    [System.ComponentModel.DefaultValueAttribute((System.Diagnostics.PerformanceCounterInstanceLifetime)(0))]
    [System.MonoTODOAttribute]
    public System.Diagnostics.PerformanceCounterInstanceLifetime InstanceLifetime { get { return default(System.Diagnostics.PerformanceCounterInstanceLifetime); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.ReadOnlyAttribute(true)]
    [System.ComponentModel.RecommendedAsConfigurableAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute("System.Diagnostics.Design.InstanceNameConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.SRDescriptionAttribute("The instance name for this performance counter.")]
    public string InstanceName { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(".")]
    [System.ComponentModel.RecommendedAsConfigurableAttribute(true)]
    [System.MonoTODOAttribute("What's the machine name format?")]
    [System.SRDescriptionAttribute("The machine where this performance counter resides.")]
    public string MachineName { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Diagnostics.MonitoringDescriptionAttribute("The raw value of the counter.")]
    public long RawValue { get { return default(long); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Diagnostics.MonitoringDescriptionAttribute("The accessability level of the counter.")]
    public bool ReadOnly { get { return default(bool); } set { } }
    public void BeginInit() { }
    public void Close() { }
    public static void CloseSharedResources() { }
    public long Decrement() { return default(long); }
    protected override void Dispose(bool disposing) { }
    public void EndInit() { }
    public long Increment() { return default(long); }
    [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(1))]
    public long IncrementBy(long value) { return default(long); }
    public System.Diagnostics.CounterSample NextSample() { return default(System.Diagnostics.CounterSample); }
    public float NextValue() { return default(float); }
    [System.MonoTODOAttribute]
    [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(1))]
    public void RemoveInstance() { }
  }
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
  public sealed partial class PerformanceCounterCategory {
    public PerformanceCounterCategory() { }
    public PerformanceCounterCategory(string categoryName) { }
    public PerformanceCounterCategory(string categoryName, string machineName) { }
    public string CategoryHelp { get { return default(string); } }
    public string CategoryName { get { return default(string); } set { } }
    public System.Diagnostics.PerformanceCounterCategoryType CategoryType { get { return default(System.Diagnostics.PerformanceCounterCategoryType); } }
    public string MachineName { get { return default(string); } set { } }
    public bool CounterExists(string counterName) { return default(bool); }
    public static bool CounterExists(string counterName, string categoryName) { return default(bool); }
    public static bool CounterExists(string counterName, string categoryName, string machineName) { return default(bool); }
    [System.ObsoleteAttribute("Use another overload that uses PerformanceCounterCategoryType instead")]
    public static System.Diagnostics.PerformanceCounterCategory Create(string categoryName, string categoryHelp, System.Diagnostics.CounterCreationDataCollection counterData) { return default(System.Diagnostics.PerformanceCounterCategory); }
    public static System.Diagnostics.PerformanceCounterCategory Create(string categoryName, string categoryHelp, System.Diagnostics.PerformanceCounterCategoryType categoryType, System.Diagnostics.CounterCreationDataCollection counterData) { return default(System.Diagnostics.PerformanceCounterCategory); }
    public static System.Diagnostics.PerformanceCounterCategory Create(string categoryName, string categoryHelp, System.Diagnostics.PerformanceCounterCategoryType categoryType, string counterName, string counterHelp) { return default(System.Diagnostics.PerformanceCounterCategory); }
    [System.ObsoleteAttribute("Use another overload that uses PerformanceCounterCategoryType instead")]
    public static System.Diagnostics.PerformanceCounterCategory Create(string categoryName, string categoryHelp, string counterName, string counterHelp) { return default(System.Diagnostics.PerformanceCounterCategory); }
    public static void Delete(string categoryName) { }
    public static bool Exists(string categoryName) { return default(bool); }
    public static bool Exists(string categoryName, string machineName) { return default(bool); }
    public static System.Diagnostics.PerformanceCounterCategory[] GetCategories() { return default(System.Diagnostics.PerformanceCounterCategory[]); }
    public static System.Diagnostics.PerformanceCounterCategory[] GetCategories(string machineName) { return default(System.Diagnostics.PerformanceCounterCategory[]); }
    public System.Diagnostics.PerformanceCounter[] GetCounters() { return default(System.Diagnostics.PerformanceCounter[]); }
    public System.Diagnostics.PerformanceCounter[] GetCounters(string instanceName) { return default(System.Diagnostics.PerformanceCounter[]); }
    public System.String[] GetInstanceNames() { return default(System.String[]); }
    public bool InstanceExists(string instanceName) { return default(bool); }
    public static bool InstanceExists(string instanceName, string categoryName) { return default(bool); }
    public static bool InstanceExists(string instanceName, string categoryName, string machineName) { return default(bool); }
    [System.MonoTODOAttribute]
    public System.Diagnostics.InstanceDataCollectionCollection ReadCategory() { return default(System.Diagnostics.InstanceDataCollectionCollection); }
  }
  public enum PerformanceCounterCategoryType {
    MultiInstance = 1,
    SingleInstance = 0,
    Unknown = -1,
  }
  public enum PerformanceCounterInstanceLifetime {
    Global = 0,
    Process = 1,
  }
  [System.MonoTODOAttribute("not implemented")]
  [System.ObsoleteAttribute("use PerformanceCounter")]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("82840be1-d273-11d2-b94a-00600893b17a")]
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
  public sealed partial class PerformanceCounterManager : System.Diagnostics.ICollectData {
    [System.ObsoleteAttribute("use PerformanceCounter")]
    public PerformanceCounterManager() { }
    void System.Diagnostics.ICollectData.CloseData() { }
    void System.Diagnostics.ICollectData.CollectData(int callIdx, System.IntPtr valueNamePtr, System.IntPtr dataPtr, int totalBytes, out System.IntPtr res) { res = default(System.IntPtr); }
  }
  public sealed partial class PerformanceCounterPermission : System.Security.Permissions.ResourcePermissionBase {
    public PerformanceCounterPermission() { }
    public PerformanceCounterPermission(System.Diagnostics.PerformanceCounterPermissionAccess permissionAccess, string machineName, string categoryName) { }
    public PerformanceCounterPermission(System.Diagnostics.PerformanceCounterPermissionEntry[] permissionAccessEntries) { }
    public PerformanceCounterPermission(System.Security.Permissions.PermissionState state) { }
    public System.Diagnostics.PerformanceCounterPermissionEntryCollection PermissionEntries { get { return default(System.Diagnostics.PerformanceCounterPermissionEntryCollection); } }
  }
  [System.FlagsAttribute]
  public enum PerformanceCounterPermissionAccess {
    Administer = 7,
    [System.ObsoleteAttribute]
    Browse = 1,
    [System.ObsoleteAttribute]
    Instrument = 3,
    None = 0,
    Read = 1,
    Write = 2,
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(621), AllowMultiple=true, Inherited=false)]
  public partial class PerformanceCounterPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute {
    public PerformanceCounterPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
    public string CategoryName { get { return default(string); } set { } }
    public string MachineName { get { return default(string); } set { } }
    public System.Diagnostics.PerformanceCounterPermissionAccess PermissionAccess { get { return default(System.Diagnostics.PerformanceCounterPermissionAccess); } set { } }
    public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
  }
  public partial class PerformanceCounterPermissionEntry {
    public PerformanceCounterPermissionEntry(System.Diagnostics.PerformanceCounterPermissionAccess permissionAccess, string machineName, string categoryName) { }
    public string CategoryName { get { return default(string); } }
    public string MachineName { get { return default(string); } }
    public System.Diagnostics.PerformanceCounterPermissionAccess PermissionAccess { get { return default(System.Diagnostics.PerformanceCounterPermissionAccess); } }
  }
  public partial class PerformanceCounterPermissionEntryCollection : System.Collections.CollectionBase {
    internal PerformanceCounterPermissionEntryCollection() { }
    public System.Diagnostics.PerformanceCounterPermissionEntry this[int index] { get { return default(System.Diagnostics.PerformanceCounterPermissionEntry); } set { } }
    public int Add(System.Diagnostics.PerformanceCounterPermissionEntry value) { return default(int); }
    public void AddRange(System.Diagnostics.PerformanceCounterPermissionEntry[] value) { }
    public void AddRange(System.Diagnostics.PerformanceCounterPermissionEntryCollection value) { }
    public bool Contains(System.Diagnostics.PerformanceCounterPermissionEntry value) { return default(bool); }
    public void CopyTo(System.Diagnostics.PerformanceCounterPermissionEntry[] array, int index) { }
    public int IndexOf(System.Diagnostics.PerformanceCounterPermissionEntry value) { return default(int); }
    public void Insert(int index, System.Diagnostics.PerformanceCounterPermissionEntry value) { }
    protected override void OnClear() { }
    protected override void OnInsert(int index, object value) { }
    protected override void OnRemove(int index, object value) { }
    protected override void OnSet(int index, object oldValue, object newValue) { }
    public void Remove(System.Diagnostics.PerformanceCounterPermissionEntry value) { }
  }
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Diagnostics.AlphabeticalEnumConverter))]
  public enum PerformanceCounterType {
    AverageBase = 1073939458,
    AverageCount64 = 1073874176,
    AverageTimer32 = 805438464,
    CounterDelta32 = 4195328,
    CounterDelta64 = 4195584,
    CounterMultiBase = 1107494144,
    CounterMultiTimer = 574686464,
    CounterMultiTimer100Ns = 575735040,
    CounterMultiTimer100NsInverse = 592512256,
    CounterMultiTimerInverse = 591463680,
    CounterTimer = 541132032,
    CounterTimerInverse = 557909248,
    CountPerTimeInterval32 = 4523008,
    CountPerTimeInterval64 = 4523264,
    ElapsedTime = 807666944,
    NumberOfItems32 = 65536,
    NumberOfItems64 = 65792,
    NumberOfItemsHEX32 = 0,
    NumberOfItemsHEX64 = 256,
    RateOfCountsPerSecond32 = 272696320,
    RateOfCountsPerSecond64 = 272696576,
    RawBase = 1073939459,
    RawFraction = 537003008,
    SampleBase = 1073939457,
    SampleCounter = 4260864,
    SampleFraction = 549585920,
    Timer100Ns = 542180608,
    Timer100NsInverse = 558957824,
  }
  [System.ComponentModel.DefaultEventAttribute("Exited")]
  [System.ComponentModel.DefaultPropertyAttribute("StartInfo")]
  [System.ComponentModel.DesignerAttribute("System.Diagnostics.Design.ProcessDesigner, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [System.Diagnostics.MonitoringDescriptionAttribute("Represents a system process")]
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Unrestricted=true)]
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
  public partial class Process : System.ComponentModel.Component {
    public Process() { }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Diagnostics.MonitoringDescriptionAttribute("Base process priority.")]
    [System.MonoTODOAttribute]
    public int BasePriority { get { return default(int); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Diagnostics.MonitoringDescriptionAttribute("Check for exiting of the process to raise the apropriate event.")]
    public bool EnableRaisingEvents { get { return default(bool); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Diagnostics.MonitoringDescriptionAttribute("The exit code of the process.")]
    public int ExitCode { get { return default(int); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Diagnostics.MonitoringDescriptionAttribute("The exit time of the process.")]
    public System.DateTime ExitTime { get { return default(System.DateTime); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Diagnostics.MonitoringDescriptionAttribute("Handle for this process.")]
    public System.IntPtr Handle { get { return default(System.IntPtr); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Diagnostics.MonitoringDescriptionAttribute("Handles for this process.")]
    [System.MonoTODOAttribute]
    public int HandleCount { get { return default(int); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Diagnostics.MonitoringDescriptionAttribute("Determines if the process is still running.")]
    public bool HasExited { get { return default(bool); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Diagnostics.MonitoringDescriptionAttribute("Process identifier.")]
    public int Id { get { return default(int); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Diagnostics.MonitoringDescriptionAttribute("The name of the computer running the process.")]
    [System.MonoTODOAttribute]
    public string MachineName { get { return default(string); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Diagnostics.MonitoringDescriptionAttribute("The main module of the process.")]
    public System.Diagnostics.ProcessModule MainModule { get { return default(System.Diagnostics.ProcessModule); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Diagnostics.MonitoringDescriptionAttribute("The handle of the main window of the process.")]
    [System.MonoTODOAttribute]
    public System.IntPtr MainWindowHandle { get { return default(System.IntPtr); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Diagnostics.MonitoringDescriptionAttribute("The title of the main window of the process.")]
    [System.MonoTODOAttribute]
    public string MainWindowTitle { get { return default(string); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Diagnostics.MonitoringDescriptionAttribute("The maximum working set for this process.")]
    public System.IntPtr MaxWorkingSet { get { return default(System.IntPtr); } set { } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Diagnostics.MonitoringDescriptionAttribute("The minimum working set for this process.")]
    public System.IntPtr MinWorkingSet { get { return default(System.IntPtr); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Diagnostics.MonitoringDescriptionAttribute("The modules that are loaded as part of this process.")]
    public System.Diagnostics.ProcessModuleCollection Modules { get { return default(System.Diagnostics.ProcessModuleCollection); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Diagnostics.MonitoringDescriptionAttribute("The number of bytes that are not pageable.")]
    [System.MonoTODOAttribute]
    [System.ObsoleteAttribute("Use NonpagedSystemMemorySize64")]
    public int NonpagedSystemMemorySize { get { return default(int); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Diagnostics.MonitoringDescriptionAttribute("The number of bytes that are not pageable.")]
    [System.MonoTODOAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public long NonpagedSystemMemorySize64 { get { return default(long); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Diagnostics.MonitoringDescriptionAttribute("The number of bytes that are paged.")]
    [System.MonoTODOAttribute]
    [System.ObsoleteAttribute("Use PagedMemorySize64")]
    public int PagedMemorySize { get { return default(int); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Diagnostics.MonitoringDescriptionAttribute("The number of bytes that are paged.")]
    [System.MonoTODOAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public long PagedMemorySize64 { get { return default(long); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Diagnostics.MonitoringDescriptionAttribute("The amount of paged system memory in bytes.")]
    [System.MonoTODOAttribute]
    [System.ObsoleteAttribute("Use PagedSystemMemorySize64")]
    public int PagedSystemMemorySize { get { return default(int); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Diagnostics.MonitoringDescriptionAttribute("The amount of paged system memory in bytes.")]
    [System.MonoTODOAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public long PagedSystemMemorySize64 { get { return default(long); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Diagnostics.MonitoringDescriptionAttribute("The maximum amount of paged memory used by this process.")]
    [System.MonoTODOAttribute]
    [System.ObsoleteAttribute("Use PeakPagedMemorySize64")]
    public int PeakPagedMemorySize { get { return default(int); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Diagnostics.MonitoringDescriptionAttribute("The maximum amount of paged memory used by this process.")]
    [System.MonoTODOAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public long PeakPagedMemorySize64 { get { return default(long); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Diagnostics.MonitoringDescriptionAttribute("The maximum amount of virtual memory used by this process.")]
    [System.ObsoleteAttribute("Use PeakVirtualMemorySize64")]
    public int PeakVirtualMemorySize { get { return default(int); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Diagnostics.MonitoringDescriptionAttribute("The maximum amount of virtual memory used by this process.")]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public long PeakVirtualMemorySize64 { get { return default(long); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Diagnostics.MonitoringDescriptionAttribute("The maximum amount of system memory used by this process.")]
    [System.ObsoleteAttribute("Use PeakWorkingSet64")]
    public int PeakWorkingSet { get { return default(int); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Diagnostics.MonitoringDescriptionAttribute("The maximum amount of system memory used by this process.")]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public long PeakWorkingSet64 { get { return default(long); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Diagnostics.MonitoringDescriptionAttribute("Process will be of higher priority while it is actively used.")]
    [System.MonoTODOAttribute]
    public bool PriorityBoostEnabled { get { return default(bool); } set { } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Diagnostics.MonitoringDescriptionAttribute("The relative process priority.")]
    [System.MonoLimitationAttribute("Under Unix, only root is allowed to raise the priority.")]
    public System.Diagnostics.ProcessPriorityClass PriorityClass { get { return default(System.Diagnostics.ProcessPriorityClass); } set { } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Diagnostics.MonitoringDescriptionAttribute("The amount of memory exclusively used by this process.")]
    [System.ObsoleteAttribute("Use PrivateMemorySize64")]
    public int PrivateMemorySize { get { return default(int); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Diagnostics.MonitoringDescriptionAttribute("The amount of memory exclusively used by this process.")]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public long PrivateMemorySize64 { get { return default(long); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Diagnostics.MonitoringDescriptionAttribute("The amount of processing time spent in the OS core for this process.")]
    public System.TimeSpan PrivilegedProcessorTime { get { return default(System.TimeSpan); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Diagnostics.MonitoringDescriptionAttribute("The name of this process.")]
    public string ProcessName { get { return default(string); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Diagnostics.MonitoringDescriptionAttribute("Allowed processor that can be used by this process.")]
    [System.MonoTODOAttribute]
    public System.IntPtr ProcessorAffinity { get { return default(System.IntPtr); } set { } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Diagnostics.MonitoringDescriptionAttribute("Is this process responsive.")]
    [System.MonoTODOAttribute]
    public bool Responding { get { return default(bool); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Diagnostics.MonitoringDescriptionAttribute("The session ID for this process.")]
    [System.MonoNotSupportedAttribute("")]
    public int SessionId { get { return default(int); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Diagnostics.MonitoringDescriptionAttribute("The standard error stream of this process.")]
    public System.IO.StreamReader StandardError { get { return default(System.IO.StreamReader); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Diagnostics.MonitoringDescriptionAttribute("The standard input stream of this process.")]
    public System.IO.StreamWriter StandardInput { get { return default(System.IO.StreamWriter); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Diagnostics.MonitoringDescriptionAttribute("The standard output stream of this process.")]
    public System.IO.StreamReader StandardOutput { get { return default(System.IO.StreamReader); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.Diagnostics.MonitoringDescriptionAttribute("Information for the start of this process.")]
    public System.Diagnostics.ProcessStartInfo StartInfo { get { return default(System.Diagnostics.ProcessStartInfo); } set { } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Diagnostics.MonitoringDescriptionAttribute("The time this process started.")]
    public System.DateTime StartTime { get { return default(System.DateTime); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Diagnostics.MonitoringDescriptionAttribute("The object that is used to synchronize event handler calls for this process.")]
    public System.ComponentModel.ISynchronizeInvoke SynchronizingObject { get { return default(System.ComponentModel.ISynchronizeInvoke); } set { } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Diagnostics.MonitoringDescriptionAttribute("The number of threads of this process.")]
    [System.MonoTODOAttribute]
    public System.Diagnostics.ProcessThreadCollection Threads { get { return default(System.Diagnostics.ProcessThreadCollection); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Diagnostics.MonitoringDescriptionAttribute("The total CPU time spent for this process.")]
    public System.TimeSpan TotalProcessorTime { get { return default(System.TimeSpan); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Diagnostics.MonitoringDescriptionAttribute("The CPU time spent for this process in user mode.")]
    public System.TimeSpan UserProcessorTime { get { return default(System.TimeSpan); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Diagnostics.MonitoringDescriptionAttribute("The amount of virtual memory currently used for this process.")]
    [System.ObsoleteAttribute("Use VirtualMemorySize64")]
    public int VirtualMemorySize { get { return default(int); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Diagnostics.MonitoringDescriptionAttribute("The amount of virtual memory currently used for this process.")]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public long VirtualMemorySize64 { get { return default(long); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Diagnostics.MonitoringDescriptionAttribute("The amount of physical memory currently used for this process.")]
    [System.ObsoleteAttribute("Use WorkingSet64")]
    public int WorkingSet { get { return default(int); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Diagnostics.MonitoringDescriptionAttribute("The amount of physical memory currently used for this process.")]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public long WorkingSet64 { get { return default(long); } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.Diagnostics.MonitoringDescriptionAttribute("Raised when it receives error data")]
    public event System.Diagnostics.DataReceivedEventHandler ErrorDataReceived { add { } remove { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.Diagnostics.MonitoringDescriptionAttribute("Raised when this process exits.")]
    public event System.EventHandler Exited { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.Diagnostics.MonitoringDescriptionAttribute("Raised when it receives output data")]
    public event System.Diagnostics.DataReceivedEventHandler OutputDataReceived { add { } remove { } }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public void BeginErrorReadLine() { }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public void BeginOutputReadLine() { }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public void CancelErrorRead() { }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public void CancelOutputRead() { }
    public void Close() { }
    public bool CloseMainWindow() { return default(bool); }
    protected override void Dispose(bool disposing) { }
    [System.MonoTODOAttribute]
    public static void EnterDebugMode() { }
    ~Process() { }
    public static System.Diagnostics.Process GetCurrentProcess() { return default(System.Diagnostics.Process); }
    public static System.Diagnostics.Process GetProcessById(int processId) { return default(System.Diagnostics.Process); }
    [System.MonoTODOAttribute("There is no support for retrieving process information from a remote machine")]
    public static System.Diagnostics.Process GetProcessById(int processId, string machineName) { return default(System.Diagnostics.Process); }
    public static System.Diagnostics.Process[] GetProcesses() { return default(System.Diagnostics.Process[]); }
    [System.MonoTODOAttribute("There is no support for retrieving process information from a remote machine")]
    public static System.Diagnostics.Process[] GetProcesses(string machineName) { return default(System.Diagnostics.Process[]); }
    public static System.Diagnostics.Process[] GetProcessesByName(string processName) { return default(System.Diagnostics.Process[]); }
    [System.MonoTODOAttribute]
    public static System.Diagnostics.Process[] GetProcessesByName(string processName, string machineName) { return default(System.Diagnostics.Process[]); }
    public void Kill() { }
    [System.MonoTODOAttribute]
    public static void LeaveDebugMode() { }
    protected void OnExited() { }
    public void Refresh() { }
    public bool Start() { return default(bool); }
    public static System.Diagnostics.Process Start(System.Diagnostics.ProcessStartInfo startInfo) { return default(System.Diagnostics.Process); }
    public static System.Diagnostics.Process Start(string fileName) { return default(System.Diagnostics.Process); }
    public static System.Diagnostics.Process Start(string fileName, string arguments) { return default(System.Diagnostics.Process); }
    public static System.Diagnostics.Process Start(string fileName, string username, System.Security.SecureString password, string domain) { return default(System.Diagnostics.Process); }
    public static System.Diagnostics.Process Start(string fileName, string arguments, string username, System.Security.SecureString password, string domain) { return default(System.Diagnostics.Process); }
    public override string ToString() { return default(string); }
    public void WaitForExit() { }
    public bool WaitForExit(int milliseconds) { return default(bool); }
    [System.MonoTODOAttribute]
    public bool WaitForInputIdle() { return default(bool); }
    [System.MonoTODOAttribute]
    public bool WaitForInputIdle(int milliseconds) { return default(bool); }
  }
  [System.ComponentModel.DesignerAttribute("System.Diagnostics.Design.ProcessModuleDesigner, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  public partial class ProcessModule : System.ComponentModel.Component {
    internal ProcessModule() { }
    [System.Diagnostics.MonitoringDescriptionAttribute("The base memory address of this module")]
    public System.IntPtr BaseAddress { get { return default(System.IntPtr); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The base memory address of the entry point of this module")]
    public System.IntPtr EntryPointAddress { get { return default(System.IntPtr); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The file name of this module")]
    public string FileName { get { return default(string); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public System.Diagnostics.FileVersionInfo FileVersionInfo { get { return default(System.Diagnostics.FileVersionInfo); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The memory needed by this module")]
    public int ModuleMemorySize { get { return default(int); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The name of this module")]
    public string ModuleName { get { return default(string); } }
    public override string ToString() { return default(string); }
  }
  public partial class ProcessModuleCollection : System.Collections.ReadOnlyCollectionBase {
    protected ProcessModuleCollection() { }
    public ProcessModuleCollection(System.Diagnostics.ProcessModule[] processModules) { }
    public System.Diagnostics.ProcessModule this[int index] { get { return default(System.Diagnostics.ProcessModule); } }
    public bool Contains(System.Diagnostics.ProcessModule module) { return default(bool); }
    public void CopyTo(System.Diagnostics.ProcessModule[] array, int index) { }
    public int IndexOf(System.Diagnostics.ProcessModule module) { return default(int); }
  }
  public enum ProcessPriorityClass {
    AboveNormal = 32768,
    BelowNormal = 16384,
    High = 128,
    Idle = 64,
    Normal = 32,
    RealTime = 256,
  }
  [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.ExpandableObjectConverter))]
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
  public sealed partial class ProcessStartInfo {
    public ProcessStartInfo() { }
    public ProcessStartInfo(string filename) { }
    public ProcessStartInfo(string filename, string arguments) { }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.RecommendedAsConfigurableAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Diagnostics.MonitoringDescriptionAttribute("Command line agruments for this process.")]
    public string Arguments { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Diagnostics.MonitoringDescriptionAttribute("Start this process with a new window.")]
    public bool CreateNoWindow { get { return default(bool); } set { } }
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    public string Domain { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.EditorAttribute("System.Diagnostics.Design.StringDictionaryEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Diagnostics.MonitoringDescriptionAttribute("Environment variables used for this process.")]
    public System.Collections.Specialized.StringDictionary EnvironmentVariables { get { return default(System.Collections.Specialized.StringDictionary); } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Diagnostics.MonitoringDescriptionAttribute("Thread shows dialogboxes for errors.")]
    public bool ErrorDialog { get { return default(bool); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.IntPtr ErrorDialogParentHandle { get { return default(System.IntPtr); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Diagnostics.Design.StartFileNameEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.RecommendedAsConfigurableAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Diagnostics.MonitoringDescriptionAttribute("The name of the resource to start this process.")]
    public string FileName { get { return default(string); } set { } }
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    public bool LoadUserProfile { get { return default(bool); } set { } }
    public System.Security.SecureString Password { get { return default(System.Security.SecureString); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Diagnostics.MonitoringDescriptionAttribute("Errors of this process are redirected.")]
    public bool RedirectStandardError { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Diagnostics.MonitoringDescriptionAttribute("Standard input of this process is redirected.")]
    public bool RedirectStandardInput { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Diagnostics.MonitoringDescriptionAttribute("Standart output of this process is redirected.")]
    public bool RedirectStandardOutput { get { return default(bool); } set { } }
    public System.Text.Encoding StandardErrorEncoding { get { return default(System.Text.Encoding); } set { } }
    public System.Text.Encoding StandardOutputEncoding { get { return default(System.Text.Encoding); } set { } }
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    public string UserName { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Diagnostics.MonitoringDescriptionAttribute("Use the shell to start this process.")]
    public bool UseShellExecute { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute("System.Diagnostics.Design.VerbConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Diagnostics.MonitoringDescriptionAttribute("The verb to apply to a used document.")]
    public string Verb { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.String[] Verbs { get { return default(System.String[]); } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Diagnostics.ProcessWindowStyle), "Normal")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Diagnostics.MonitoringDescriptionAttribute("The window style used to start this process.")]
    public System.Diagnostics.ProcessWindowStyle WindowStyle { get { return default(System.Diagnostics.ProcessWindowStyle); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Diagnostics.Design.WorkingDirectoryEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.RecommendedAsConfigurableAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Diagnostics.MonitoringDescriptionAttribute("The initial directory for this process.")]
    public string WorkingDirectory { get { return default(string); } set { } }
  }
  [System.ComponentModel.DesignerAttribute("System.Diagnostics.Design.ProcessThreadDesigner, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  public partial class ProcessThread : System.ComponentModel.Component {
    internal ProcessThread() { }
    [System.Diagnostics.MonitoringDescriptionAttribute("The base priority of this thread.")]
    [System.MonoTODOAttribute]
    public int BasePriority { get { return default(int); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The current priority of this thread.")]
    [System.MonoTODOAttribute]
    public int CurrentPriority { get { return default(int); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The ID of this thread.")]
    [System.MonoTODOAttribute]
    public int Id { get { return default(int); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.MonoTODOAttribute]
    public int IdealProcessor { set { } }
    [System.Diagnostics.MonitoringDescriptionAttribute("Thread gets a priority boot when interactively used by a user.")]
    [System.MonoTODOAttribute]
    public bool PriorityBoostEnabled { get { return default(bool); } set { } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The priority level of this thread.")]
    [System.MonoTODOAttribute]
    public System.Diagnostics.ThreadPriorityLevel PriorityLevel { get { return default(System.Diagnostics.ThreadPriorityLevel); } set { } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The amount of CPU time used in privileged mode.")]
    [System.MonoTODOAttribute]
    public System.TimeSpan PrivilegedProcessorTime { get { return default(System.TimeSpan); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.MonoTODOAttribute]
    public System.IntPtr ProcessorAffinity { set { } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The start address in memory of this thread.")]
    [System.MonoTODOAttribute]
    public System.IntPtr StartAddress { get { return default(System.IntPtr); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The time this thread was started.")]
    [System.MonoTODOAttribute]
    public System.DateTime StartTime { get { return default(System.DateTime); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The current state of this thread.")]
    [System.MonoTODOAttribute]
    public System.Diagnostics.ThreadState ThreadState { get { return default(System.Diagnostics.ThreadState); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The total amount of CPU time used.")]
    [System.MonoTODOAttribute]
    public System.TimeSpan TotalProcessorTime { get { return default(System.TimeSpan); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The amount of CPU time used in user mode.")]
    [System.MonoTODOAttribute]
    public System.TimeSpan UserProcessorTime { get { return default(System.TimeSpan); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The reason why this thread is waiting.")]
    [System.MonoTODOAttribute]
    public System.Diagnostics.ThreadWaitReason WaitReason { get { return default(System.Diagnostics.ThreadWaitReason); } }
    [System.MonoTODOAttribute]
    public void ResetIdealProcessor() { }
  }
  public partial class ProcessThreadCollection : System.Collections.ReadOnlyCollectionBase {
    protected ProcessThreadCollection() { }
    public ProcessThreadCollection(System.Diagnostics.ProcessThread[] processThreads) { }
    public System.Diagnostics.ProcessThread this[int index] { get { return default(System.Diagnostics.ProcessThread); } }
    public int Add(System.Diagnostics.ProcessThread thread) { return default(int); }
    public bool Contains(System.Diagnostics.ProcessThread thread) { return default(bool); }
    public void CopyTo(System.Diagnostics.ProcessThread[] array, int index) { }
    public int IndexOf(System.Diagnostics.ProcessThread thread) { return default(int); }
    public void Insert(int index, System.Diagnostics.ProcessThread thread) { }
    public void Remove(System.Diagnostics.ProcessThread thread) { }
  }
  public enum ProcessWindowStyle {
    Hidden = 1,
    Maximized = 3,
    Minimized = 2,
    Normal = 0,
  }
  public partial class SourceFilter : System.Diagnostics.TraceFilter {
    public SourceFilter(string source) { }
    public string Source { get { return default(string); } set { } }
    public override bool ShouldTrace(System.Diagnostics.TraceEventCache cache, string source, System.Diagnostics.TraceEventType eventType, int id, string formatOrMessage, System.Object[] args, object data1, System.Object[] data) { return default(bool); }
  }
  [System.FlagsAttribute]
  public enum SourceLevels {
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    ActivityTracing = 65280,
    All = -1,
    Critical = 1,
    Error = 3,
    Information = 15,
    Off = 0,
    Verbose = 31,
    Warning = 7,
  }
  public partial class SourceSwitch : System.Diagnostics.Switch {
    public SourceSwitch(string displayName) : base (default(string), default(string)) { }
    public SourceSwitch(string displayName, string defaultSwitchValue) : base (default(string), default(string)) { }
    public System.Diagnostics.SourceLevels Level { get { return default(System.Diagnostics.SourceLevels); } set { } }
    protected override void OnValueChanged() { }
    public bool ShouldTrace(System.Diagnostics.TraceEventType eventType) { return default(bool); }
  }
  public partial class Stopwatch {
    public static readonly long Frequency;
    public static readonly bool IsHighResolution;
    public Stopwatch() { }
    public System.TimeSpan Elapsed { get { return default(System.TimeSpan); } }
    public long ElapsedMilliseconds { get { return default(long); } }
    public long ElapsedTicks { get { return default(long); } }
    public bool IsRunning { get { return default(bool); } }
    public static long GetTimestamp() { return default(long); }
    public void Reset() { }
    public void Restart() { }
    public void Start() { }
    public static System.Diagnostics.Stopwatch StartNew() { return default(System.Diagnostics.Stopwatch); }
    public void Stop() { }
  }
  public abstract partial class Switch {
    protected Switch(string displayName, string description) { }
    protected Switch(string displayName, string description, string defaultSwitchValue) { }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Specialized.StringDictionary Attributes { get { return default(System.Collections.Specialized.StringDictionary); } }
    public string Description { get { return default(string); } }
    public string DisplayName { get { return default(string); } }
    protected int SwitchSetting { get { return default(int); } set { } }
    protected string Value { get { return default(string); } set { } }
    protected internal virtual System.String[] GetSupportedAttributes() { return default(System.String[]); }
    protected virtual void OnSwitchSettingChanged() { }
    protected virtual void OnValueChanged() { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(741))]
  [System.MonoLimitationAttribute("This attribute is not considered in trace support.")]
  public sealed partial class SwitchAttribute : System.Attribute {
    public SwitchAttribute(string switchName, System.Type switchType) { }
    public string SwitchDescription { get { return default(string); } set { } }
    public string SwitchName { get { return default(string); } set { } }
    public System.Type SwitchType { get { return default(System.Type); } set { } }
    public static System.Diagnostics.SwitchAttribute[] GetAll(System.Reflection.Assembly assembly) { return default(System.Diagnostics.SwitchAttribute[]); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
  [System.MonoLimitationAttribute("This attribute is not considered in trace support.")]
  public sealed partial class SwitchLevelAttribute : System.Attribute {
    public SwitchLevelAttribute(System.Type switchLevelType) { }
    public System.Type SwitchLevelType { get { return default(System.Type); } set { } }
  }
  public partial class TextWriterTraceListener : System.Diagnostics.TraceListener {
    public TextWriterTraceListener() { }
    public TextWriterTraceListener(System.IO.Stream stream) { }
    public TextWriterTraceListener(System.IO.Stream stream, string name) { }
    public TextWriterTraceListener(System.IO.TextWriter writer) { }
    public TextWriterTraceListener(System.IO.TextWriter writer, string name) { }
    public TextWriterTraceListener(string fileName) { }
    public TextWriterTraceListener(string fileName, string name) { }
    public System.IO.TextWriter Writer { get { return default(System.IO.TextWriter); } set { } }
    public override void Close() { }
    protected override void Dispose(bool disposing) { }
    public override void Flush() { }
    public override void Write(string message) { }
    public override void WriteLine(string message) { }
  }
  public enum ThreadPriorityLevel {
    AboveNormal = 1,
    BelowNormal = -1,
    Highest = 2,
    Idle = -15,
    Lowest = -2,
    Normal = 0,
    TimeCritical = 15,
  }
  public enum ThreadState {
    Initialized = 0,
    Ready = 1,
    Running = 2,
    Standby = 3,
    Terminated = 4,
    Transition = 6,
    Unknown = 7,
    Wait = 5,
  }
  public enum ThreadWaitReason {
    EventPairHigh = 7,
    EventPairLow = 8,
    ExecutionDelay = 4,
    Executive = 0,
    FreePage = 1,
    LpcReceive = 9,
    LpcReply = 10,
    PageIn = 2,
    PageOut = 12,
    Suspended = 5,
    SystemAllocation = 3,
    Unknown = 13,
    UserRequest = 6,
    VirtualMemory = 11,
  }
  public sealed partial class Trace {
    internal Trace() { }
    public static bool AutoFlush { get { return default(bool); } set { } }
    public static System.Diagnostics.CorrelationManager CorrelationManager { get { return default(System.Diagnostics.CorrelationManager); } }
    public static int IndentLevel { get { return default(int); } set { } }
    public static int IndentSize { get { return default(int); } set { } }
    public static System.Diagnostics.TraceListenerCollection Listeners { get { return default(System.Diagnostics.TraceListenerCollection); } }
    public static bool UseGlobalLock { get { return default(bool); } set { } }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void Assert(bool condition) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void Assert(bool condition, string message) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void Assert(bool condition, string message, string detailMessage) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void Close() { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void Fail(string message) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void Fail(string message, string detailMessage) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void Flush() { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void Indent() { }
    [System.MonoNotSupportedAttribute("")]
    public static void Refresh() { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void TraceError(string message) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void TraceError(string message, params System.Object[] args) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void TraceInformation(string message) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void TraceInformation(string message, params System.Object[] args) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void TraceWarning(string message) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void TraceWarning(string message, params System.Object[] args) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void Unindent() { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void Write(object value) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void Write(object value, string category) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void Write(string message) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void Write(string message, string category) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void WriteIf(bool condition, object value) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void WriteIf(bool condition, object value, string category) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void WriteIf(bool condition, string message) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void WriteIf(bool condition, string message, string category) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void WriteLine(object value) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void WriteLine(object value, string category) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void WriteLine(string message) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void WriteLine(string message, string category) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void WriteLineIf(bool condition, object value) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void WriteLineIf(bool condition, object value, string category) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void WriteLineIf(bool condition, string message) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void WriteLineIf(bool condition, string message, string category) { }
  }
  public partial class TraceEventCache {
    public TraceEventCache() { }
    public string Callstack { get { return default(string); } }
    public System.DateTime DateTime { get { return default(System.DateTime); } }
    public System.Collections.Stack LogicalOperationStack { get { return default(System.Collections.Stack); } }
    public int ProcessId { get { return default(int); } }
    public string ThreadId { get { return default(string); } }
    public long Timestamp { get { return default(long); } }
  }
  public enum TraceEventType {
    Critical = 1,
    Error = 2,
    Information = 8,
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    Resume = 2048,
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    Start = 256,
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    Stop = 512,
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    Suspend = 1024,
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    Transfer = 4096,
    Verbose = 16,
    Warning = 4,
  }
  public abstract partial class TraceFilter {
    protected TraceFilter() { }
    public abstract bool ShouldTrace(System.Diagnostics.TraceEventCache cache, string source, System.Diagnostics.TraceEventType eventType, int id, string formatOrMessage, System.Object[] args, object data1, System.Object[] data);
  }
  public enum TraceLevel {
    Error = 1,
    Info = 3,
    Off = 0,
    Verbose = 4,
    Warning = 2,
  }
  public abstract partial class TraceListener : System.MarshalByRefObject, System.IDisposable {
    protected TraceListener() { }
    protected TraceListener(string name) { }
    public System.Collections.Specialized.StringDictionary Attributes { get { return default(System.Collections.Specialized.StringDictionary); } }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public System.Diagnostics.TraceFilter Filter { get { return default(System.Diagnostics.TraceFilter); } set { } }
    public int IndentLevel { get { return default(int); } set { } }
    public int IndentSize { get { return default(int); } set { } }
    [System.MonoLimitationAttribute("This property exists but is never considered.")]
    public virtual bool IsThreadSafe { get { return default(bool); } }
    public virtual string Name { get { return default(string); } set { } }
    protected bool NeedIndent { get { return default(bool); } set { } }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public System.Diagnostics.TraceOptions TraceOutputOptions { get { return default(System.Diagnostics.TraceOptions); } set { } }
    public virtual void Close() { }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public virtual void Fail(string message) { }
    public virtual void Fail(string message, string detailMessage) { }
    public virtual void Flush() { }
    protected internal virtual System.String[] GetSupportedAttributes() { return default(System.String[]); }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public virtual void TraceData(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, object data) { }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public virtual void TraceData(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, params System.Object[] data) { }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public virtual void TraceEvent(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id) { }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public virtual void TraceEvent(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, string message) { }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public virtual void TraceEvent(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, string format, params System.Object[] args) { }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public virtual void TraceTransfer(System.Diagnostics.TraceEventCache eventCache, string source, int id, string message, System.Guid relatedActivityId) { }
    public virtual void Write(object o) { }
    public virtual void Write(object o, string category) { }
    public abstract void Write(string message);
    public virtual void Write(string message, string category) { }
    protected virtual void WriteIndent() { }
    public virtual void WriteLine(object o) { }
    public virtual void WriteLine(object o, string category) { }
    public abstract void WriteLine(string message);
    public virtual void WriteLine(string message, string category) { }
  }
  public partial class TraceListenerCollection : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList {
    internal TraceListenerCollection() { }
    public int Count { get { return default(int); } }
    public System.Diagnostics.TraceListener this[int index] { get { return default(System.Diagnostics.TraceListener); } set { } }
    public System.Diagnostics.TraceListener this[string name] { get { return default(System.Diagnostics.TraceListener); } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    bool System.Collections.IList.IsFixedSize { get { return default(bool); } }
    bool System.Collections.IList.IsReadOnly { get { return default(bool); } }
    object System.Collections.IList.this[int index] { get { return default(object); } set { } }
    public int Add(System.Diagnostics.TraceListener listener) { return default(int); }
    public void AddRange(System.Diagnostics.TraceListener[] value) { }
    public void AddRange(System.Diagnostics.TraceListenerCollection value) { }
    public void Clear() { }
    public bool Contains(System.Diagnostics.TraceListener listener) { return default(bool); }
    public void CopyTo(System.Diagnostics.TraceListener[] listeners, int index) { }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public int IndexOf(System.Diagnostics.TraceListener listener) { return default(int); }
    public void Insert(int index, System.Diagnostics.TraceListener listener) { }
    public void Remove(System.Diagnostics.TraceListener listener) { }
    public void Remove(string name) { }
    public void RemoveAt(int index) { }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    int System.Collections.IList.Add(object value) { return default(int); }
    bool System.Collections.IList.Contains(object value) { return default(bool); }
    int System.Collections.IList.IndexOf(object value) { return default(int); }
    void System.Collections.IList.Insert(int index, object value) { }
    void System.Collections.IList.Remove(object value) { }
  }
  [System.FlagsAttribute]
  public enum TraceOptions {
    Callstack = 32,
    DateTime = 2,
    LogicalOperationStack = 1,
    None = 0,
    ProcessId = 8,
    ThreadId = 16,
    Timestamp = 4,
  }
  public partial class TraceSource {
    public TraceSource(string name) { }
    public TraceSource(string name, System.Diagnostics.SourceLevels defaultLevel) { }
    public System.Collections.Specialized.StringDictionary Attributes { get { return default(System.Collections.Specialized.StringDictionary); } }
    public System.Diagnostics.TraceListenerCollection Listeners { get { return default(System.Diagnostics.TraceListenerCollection); } }
    public string Name { get { return default(string); } }
    public System.Diagnostics.SourceSwitch Switch { get { return default(System.Diagnostics.SourceSwitch); } set { } }
    public void Close() { }
    public void Flush() { }
    protected virtual System.String[] GetSupportedAttributes() { return default(System.String[]); }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public void TraceData(System.Diagnostics.TraceEventType eventType, int id, object data) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public void TraceData(System.Diagnostics.TraceEventType eventType, int id, params System.Object[] data) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public void TraceEvent(System.Diagnostics.TraceEventType eventType, int id) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public void TraceEvent(System.Diagnostics.TraceEventType eventType, int id, string message) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public void TraceEvent(System.Diagnostics.TraceEventType eventType, int id, string format, params System.Object[] args) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public void TraceInformation(string format) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public void TraceInformation(string format, params System.Object[] args) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public void TraceTransfer(int id, string message, System.Guid relatedActivityId) { }
  }
  [System.Diagnostics.SwitchLevelAttribute(typeof(System.Diagnostics.TraceLevel))]
  public partial class TraceSwitch : System.Diagnostics.Switch {
    public TraceSwitch(string displayName, string description) : base (default(string), default(string)) { }
    public TraceSwitch(string displayName, string description, string defaultSwitchValue) : base (default(string), default(string)) { }
    public System.Diagnostics.TraceLevel Level { get { return default(System.Diagnostics.TraceLevel); } set { } }
    public bool TraceError { get { return default(bool); } }
    public bool TraceInfo { get { return default(bool); } }
    public bool TraceVerbose { get { return default(bool); } }
    public bool TraceWarning { get { return default(bool); } }
    protected override void OnSwitchSettingChanged() { }
    protected override void OnValueChanged() { }
  }
  public partial class XmlWriterTraceListener : System.Diagnostics.TextWriterTraceListener {
    public XmlWriterTraceListener(System.IO.Stream stream) { }
    public XmlWriterTraceListener(System.IO.Stream writer, string name) { }
    public XmlWriterTraceListener(System.IO.TextWriter writer) { }
    public XmlWriterTraceListener(System.IO.TextWriter writer, string name) { }
    public XmlWriterTraceListener(string filename) { }
    public XmlWriterTraceListener(string filename, string name) { }
    public override void Close() { }
    public override void Fail(string message, string detailMessage) { }
    public override void TraceData(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, object data) { }
    [System.MonoLimitationAttribute("level is not always correct")]
    public override void TraceData(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, params System.Object[] data) { }
    [System.MonoLimitationAttribute("level is not always correct")]
    public override void TraceEvent(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, string message) { }
    [System.MonoLimitationAttribute("level is not always correct")]
    public override void TraceEvent(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, string format, params System.Object[] args) { }
    public override void TraceTransfer(System.Diagnostics.TraceEventCache eventCache, string source, int id, string message, System.Guid relatedActivityId) { }
    public override void Write(string message) { }
    [System.MonoLimitationAttribute("level is not always correct")]
    public override void WriteLine(string message) { }
  }
}
namespace System.Diagnostics.CodeAnalysis {
  [System.AttributeUsageAttribute((System.AttributeTargets)(748), AllowMultiple=false, Inherited=false)]
  public sealed partial class ExcludeFromCodeCoverageAttribute : System.Attribute {
    public ExcludeFromCodeCoverageAttribute() { }
  }
}
namespace System.IO {
  public partial class ErrorEventArgs : System.EventArgs {
    public ErrorEventArgs(System.Exception exception) { }
    public virtual System.Exception GetException() { return default(System.Exception); }
  }
  public delegate void ErrorEventHandler(object sender, System.IO.ErrorEventArgs e);
  public partial class FileSystemEventArgs : System.EventArgs {
    public FileSystemEventArgs(System.IO.WatcherChangeTypes changeType, string directory, string name) { }
    public System.IO.WatcherChangeTypes ChangeType { get { return default(System.IO.WatcherChangeTypes); } }
    public string FullPath { get { return default(string); } }
    public string Name { get { return default(string); } }
  }
  public delegate void FileSystemEventHandler(object sender, System.IO.FileSystemEventArgs e);
  [System.ComponentModel.DefaultEventAttribute("Changed")]
  [System.IO.IODescriptionAttribute("")]
  public partial class FileSystemWatcher : System.ComponentModel.Component, System.ComponentModel.ISupportInitialize {
    public FileSystemWatcher() { }
    public FileSystemWatcher(string path) { }
    public FileSystemWatcher(string path, string filter) { }
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.IO.IODescriptionAttribute("Flag to indicate if this instance is active")]
    public bool EnableRaisingEvents { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute("*.*")]
    [System.ComponentModel.RecommendedAsConfigurableAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.IO.IODescriptionAttribute("File name filter pattern")]
    public string Filter { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.IO.IODescriptionAttribute("Flag to indicate we want to watch subdirectories")]
    public bool IncludeSubdirectories { get { return default(bool); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(8192)]
    public int InternalBufferSize { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.IO.NotifyFilters)(19))]
    [System.IO.IODescriptionAttribute("Flag to indicate which change event we want to monitor")]
    public System.IO.NotifyFilters NotifyFilter { get { return default(System.IO.NotifyFilters); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Diagnostics.Design.FSWPathEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.RecommendedAsConfigurableAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.IO.IODescriptionAttribute("The directory to monitor")]
    public string Path { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public override System.ComponentModel.ISite Site { get { return default(System.ComponentModel.ISite); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.IO.IODescriptionAttribute("The object used to marshal the event handler calls resulting from a directory change")]
    public System.ComponentModel.ISynchronizeInvoke SynchronizingObject { get { return default(System.ComponentModel.ISynchronizeInvoke); } set { } }
    [System.IO.IODescriptionAttribute("Occurs when a file/directory change matches the filter")]
    public event System.IO.FileSystemEventHandler Changed { add { } remove { } }
    [System.IO.IODescriptionAttribute("Occurs when a file/directory creation matches the filter")]
    public event System.IO.FileSystemEventHandler Created { add { } remove { } }
    [System.IO.IODescriptionAttribute("Occurs when a file/directory deletion matches the filter")]
    public event System.IO.FileSystemEventHandler Deleted { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public event System.IO.ErrorEventHandler Error { add { } remove { } }
    [System.IO.IODescriptionAttribute("Occurs when a file/directory rename matches the filter")]
    public event System.IO.RenamedEventHandler Renamed { add { } remove { } }
    public void BeginInit() { }
    protected override void Dispose(bool disposing) { }
    public void EndInit() { }
    ~FileSystemWatcher() { }
    protected void OnChanged(System.IO.FileSystemEventArgs e) { }
    protected void OnCreated(System.IO.FileSystemEventArgs e) { }
    protected void OnDeleted(System.IO.FileSystemEventArgs e) { }
    protected void OnError(System.IO.ErrorEventArgs e) { }
    protected void OnRenamed(System.IO.RenamedEventArgs e) { }
    public System.IO.WaitForChangedResult WaitForChanged(System.IO.WatcherChangeTypes changeType) { return default(System.IO.WaitForChangedResult); }
    public System.IO.WaitForChangedResult WaitForChanged(System.IO.WatcherChangeTypes changeType, int timeout) { return default(System.IO.WaitForChangedResult); }
  }
  public partial class InternalBufferOverflowException : System.SystemException {
    public InternalBufferOverflowException() { }
    protected InternalBufferOverflowException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public InternalBufferOverflowException(string message) { }
    public InternalBufferOverflowException(string message, System.Exception inner) { }
  }
  public sealed partial class InvalidDataException : System.SystemException {
    public InvalidDataException() { }
    public InvalidDataException(string message) { }
    public InvalidDataException(string message, System.Exception innerException) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(32767))]
  public partial class IODescriptionAttribute : System.ComponentModel.DescriptionAttribute {
    public IODescriptionAttribute(string description) { }
    public override string Description { get { return default(string); } }
  }
  [System.FlagsAttribute]
  public enum NotifyFilters {
    Attributes = 4,
    CreationTime = 64,
    DirectoryName = 2,
    FileName = 1,
    LastAccess = 32,
    LastWrite = 16,
    Security = 256,
    Size = 8,
  }
  public partial class RenamedEventArgs : System.IO.FileSystemEventArgs {
    public RenamedEventArgs(System.IO.WatcherChangeTypes changeType, string directory, string name, string oldName) : base (default(System.IO.WatcherChangeTypes), default(string), default(string)) { }
    public string OldFullPath { get { return default(string); } }
    public string OldName { get { return default(string); } }
  }
  public delegate void RenamedEventHandler(object sender, System.IO.RenamedEventArgs e);
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct WaitForChangedResult {
    public System.IO.WatcherChangeTypes ChangeType { get { return default(System.IO.WatcherChangeTypes); } set { } }
    public string Name { get { return default(string); } set { } }
    public string OldName { get { return default(string); } set { } }
    public bool TimedOut { get { return default(bool); } set { } }
  }
  [System.FlagsAttribute]
  public enum WatcherChangeTypes {
    All = 15,
    Changed = 4,
    Created = 1,
    Deleted = 2,
    Renamed = 8,
  }
}
namespace System.IO.Compression {
  public enum CompressionMode {
    Compress = 1,
    Decompress = 0,
  }
  public partial class DeflateStream : System.IO.Stream {
    public DeflateStream(System.IO.Stream compressedStream, System.IO.Compression.CompressionMode mode) { }
    public DeflateStream(System.IO.Stream compressedStream, System.IO.Compression.CompressionMode mode, bool leaveOpen) { }
    public System.IO.Stream BaseStream { get { return default(System.IO.Stream); } }
    public override bool CanRead { get { return default(bool); } }
    public override bool CanSeek { get { return default(bool); } }
    public override bool CanWrite { get { return default(bool); } }
    public override long Length { get { return default(long); } }
    public override long Position { get { return default(long); } set { } }
    public override System.IAsyncResult BeginRead(System.Byte[] buffer, int offset, int count, System.AsyncCallback cback, object state) { return default(System.IAsyncResult); }
    public override System.IAsyncResult BeginWrite(System.Byte[] buffer, int offset, int count, System.AsyncCallback cback, object state) { return default(System.IAsyncResult); }
    protected override void Dispose(bool disposing) { }
    public override int EndRead(System.IAsyncResult async_result) { return default(int); }
    public override void EndWrite(System.IAsyncResult async_result) { }
    public override void Flush() { }
    public override int Read(System.Byte[] dest, int dest_offset, int count) { return default(int); }
    public override long Seek(long offset, System.IO.SeekOrigin origin) { return default(long); }
    public override void SetLength(long value) { }
    public override void Write(System.Byte[] src, int src_offset, int count) { }
  }
  public partial class GZipStream : System.IO.Stream {
    public GZipStream(System.IO.Stream compressedStream, System.IO.Compression.CompressionMode mode) { }
    public GZipStream(System.IO.Stream compressedStream, System.IO.Compression.CompressionMode mode, bool leaveOpen) { }
    public System.IO.Stream BaseStream { get { return default(System.IO.Stream); } }
    public override bool CanRead { get { return default(bool); } }
    public override bool CanSeek { get { return default(bool); } }
    public override bool CanWrite { get { return default(bool); } }
    public override long Length { get { return default(long); } }
    public override long Position { get { return default(long); } set { } }
    public override System.IAsyncResult BeginRead(System.Byte[] buffer, int offset, int count, System.AsyncCallback cback, object state) { return default(System.IAsyncResult); }
    public override System.IAsyncResult BeginWrite(System.Byte[] buffer, int offset, int count, System.AsyncCallback cback, object state) { return default(System.IAsyncResult); }
    protected override void Dispose(bool disposing) { }
    public override int EndRead(System.IAsyncResult async_result) { return default(int); }
    public override void EndWrite(System.IAsyncResult async_result) { }
    public override void Flush() { }
    public override int Read(System.Byte[] dest, int dest_offset, int count) { return default(int); }
    public override long Seek(long offset, System.IO.SeekOrigin origin) { return default(long); }
    public override void SetLength(long value) { }
    public override void Write(System.Byte[] src, int src_offset, int count) { }
  }
}
namespace System.IO.Ports {
  public enum Handshake {
    None = 0,
    RequestToSend = 2,
    RequestToSendXOnXOff = 3,
    XOnXOff = 1,
  }
  public enum Parity {
    Even = 2,
    Mark = 3,
    None = 0,
    Odd = 1,
    Space = 4,
  }
  public enum SerialData {
    Chars = 1,
    Eof = 2,
  }
  public partial class SerialDataReceivedEventArgs : System.EventArgs {
    internal SerialDataReceivedEventArgs() { }
    public System.IO.Ports.SerialData EventType { get { return default(System.IO.Ports.SerialData); } }
  }
  public delegate void SerialDataReceivedEventHandler(object sender, System.IO.Ports.SerialDataReceivedEventArgs e);
  public enum SerialError {
    Frame = 8,
    Overrun = 2,
    RXOver = 1,
    RXParity = 4,
    TXFull = 256,
  }
  public partial class SerialErrorReceivedEventArgs : System.EventArgs {
    internal SerialErrorReceivedEventArgs() { }
    public System.IO.Ports.SerialError EventType { get { return default(System.IO.Ports.SerialError); } }
  }
  public delegate void SerialErrorReceivedEventHandler(object sender, System.IO.Ports.SerialErrorReceivedEventArgs e);
  public enum SerialPinChange {
    Break = 64,
    CDChanged = 32,
    CtsChanged = 8,
    DsrChanged = 16,
    Ring = 256,
  }
  public partial class SerialPinChangedEventArgs : System.EventArgs {
    internal SerialPinChangedEventArgs() { }
    public System.IO.Ports.SerialPinChange EventType { get { return default(System.IO.Ports.SerialPinChange); } }
  }
  public delegate void SerialPinChangedEventHandler(object sender, System.IO.Ports.SerialPinChangedEventArgs e);
  [System.Diagnostics.MonitoringDescriptionAttribute("")]
  public partial class SerialPort : System.ComponentModel.Component {
    public const int InfiniteTimeout = -1;
    public SerialPort() { }
    public SerialPort(System.ComponentModel.IContainer container) { }
    public SerialPort(string portName) { }
    public SerialPort(string portName, int baudRate) { }
    public SerialPort(string portName, int baudRate, System.IO.Ports.Parity parity) { }
    public SerialPort(string portName, int baudRate, System.IO.Ports.Parity parity, int dataBits) { }
    public SerialPort(string portName, int baudRate, System.IO.Ports.Parity parity, int dataBits, System.IO.Ports.StopBits stopBits) { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.IO.Stream BaseStream { get { return default(System.IO.Stream); } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(9600)]
    [System.Diagnostics.MonitoringDescriptionAttribute("")]
    public int BaudRate { get { return default(int); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public bool BreakState { get { return default(bool); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public int BytesToRead { get { return default(int); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public int BytesToWrite { get { return default(int); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public bool CDHolding { get { return default(bool); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public bool CtsHolding { get { return default(bool); } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(8)]
    [System.Diagnostics.MonitoringDescriptionAttribute("")]
    public int DataBits { get { return default(int); } set { } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Diagnostics.MonitoringDescriptionAttribute("")]
    [System.MonoTODOAttribute("Not implemented")]
    public bool DiscardNull { get { return default(bool); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public bool DsrHolding { get { return default(bool); } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Diagnostics.MonitoringDescriptionAttribute("")]
    public bool DtrEnable { get { return default(bool); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Diagnostics.MonitoringDescriptionAttribute("")]
    public System.Text.Encoding Encoding { get { return default(System.Text.Encoding); } set { } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.IO.Ports.Handshake)(0))]
    [System.Diagnostics.MonitoringDescriptionAttribute("")]
    public System.IO.Ports.Handshake Handshake { get { return default(System.IO.Ports.Handshake); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public bool IsOpen { get { return default(bool); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute("\n")]
    [System.Diagnostics.MonitoringDescriptionAttribute("")]
    public string NewLine { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.IO.Ports.Parity)(0))]
    [System.Diagnostics.MonitoringDescriptionAttribute("")]
    public System.IO.Ports.Parity Parity { get { return default(System.IO.Ports.Parity); } set { } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(63)]
    [System.Diagnostics.MonitoringDescriptionAttribute("")]
    [System.MonoTODOAttribute("Not implemented")]
    public byte ParityReplace { get { return default(byte); } set { } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("COM1")]
    [System.Diagnostics.MonitoringDescriptionAttribute("")]
    public string PortName { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(4096)]
    [System.Diagnostics.MonitoringDescriptionAttribute("")]
    public int ReadBufferSize { get { return default(int); } set { } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(-1)]
    [System.Diagnostics.MonitoringDescriptionAttribute("")]
    public int ReadTimeout { get { return default(int); } set { } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(1)]
    [System.Diagnostics.MonitoringDescriptionAttribute("")]
    [System.MonoTODOAttribute("Not implemented")]
    public int ReceivedBytesThreshold { get { return default(int); } set { } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Diagnostics.MonitoringDescriptionAttribute("")]
    public bool RtsEnable { get { return default(bool); } set { } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.IO.Ports.StopBits)(1))]
    [System.Diagnostics.MonitoringDescriptionAttribute("")]
    public System.IO.Ports.StopBits StopBits { get { return default(System.IO.Ports.StopBits); } set { } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(2048)]
    [System.Diagnostics.MonitoringDescriptionAttribute("")]
    public int WriteBufferSize { get { return default(int); } set { } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(-1)]
    [System.Diagnostics.MonitoringDescriptionAttribute("")]
    public int WriteTimeout { get { return default(int); } set { } }
    [System.Diagnostics.MonitoringDescriptionAttribute("")]
    public event System.IO.Ports.SerialDataReceivedEventHandler DataReceived { add { } remove { } }
    [System.Diagnostics.MonitoringDescriptionAttribute("")]
    public event System.IO.Ports.SerialErrorReceivedEventHandler ErrorReceived { add { } remove { } }
    [System.Diagnostics.MonitoringDescriptionAttribute("")]
    public event System.IO.Ports.SerialPinChangedEventHandler PinChanged { add { } remove { } }
    public void Close() { }
    public void DiscardInBuffer() { }
    public void DiscardOutBuffer() { }
    protected override void Dispose(bool disposing) { }
    public static System.String[] GetPortNames() { return default(System.String[]); }
    public void Open() { }
    public int Read(System.Byte[] buffer, int offset, int count) { return default(int); }
    public int Read(System.Char[] buffer, int offset, int count) { return default(int); }
    public int ReadByte() { return default(int); }
    public int ReadChar() { return default(int); }
    public string ReadExisting() { return default(string); }
    public string ReadLine() { return default(string); }
    public string ReadTo(string value) { return default(string); }
    public void Write(System.Byte[] buffer, int offset, int count) { }
    public void Write(System.Char[] buffer, int offset, int count) { }
    public void Write(string str) { }
    public void WriteLine(string str) { }
  }
  public enum StopBits {
    None = 0,
    One = 1,
    OnePointFive = 3,
    Two = 2,
  }
}
namespace System.Media {
  [System.ComponentModel.ToolboxItemAttribute(false)]
  public partial class SoundPlayer : System.ComponentModel.Component, System.Runtime.Serialization.ISerializable {
    public SoundPlayer() { }
    public SoundPlayer(System.IO.Stream stream) { }
    protected SoundPlayer(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext context) { }
    public SoundPlayer(string soundLocation) { }
    public bool IsLoadCompleted { get { return default(bool); } }
    public int LoadTimeout { get { return default(int); } set { } }
    public string SoundLocation { get { return default(string); } set { } }
    public System.IO.Stream Stream { get { return default(System.IO.Stream); } set { } }
    public object Tag { get { return default(object); } set { } }
    public event System.ComponentModel.AsyncCompletedEventHandler LoadCompleted { add { } remove { } }
    public event System.EventHandler SoundLocationChanged { add { } remove { } }
    public event System.EventHandler StreamChanged { add { } remove { } }
    public void Load() { }
    public void LoadAsync() { }
    protected virtual void OnLoadCompleted(System.ComponentModel.AsyncCompletedEventArgs e) { }
    protected virtual void OnSoundLocationChanged(System.EventArgs e) { }
    protected virtual void OnStreamChanged(System.EventArgs e) { }
    public void Play() { }
    public void PlayLooping() { }
    public void PlaySync() { }
    public void Stop() { }
    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial class SystemSound {
    internal SystemSound() { }
    public void Play() { }
  }
  public sealed partial class SystemSounds {
    internal SystemSounds() { }
    public static System.Media.SystemSound Asterisk { get { return default(System.Media.SystemSound); } }
    public static System.Media.SystemSound Beep { get { return default(System.Media.SystemSound); } }
    public static System.Media.SystemSound Exclamation { get { return default(System.Media.SystemSound); } }
    public static System.Media.SystemSound Hand { get { return default(System.Media.SystemSound); } }
    public static System.Media.SystemSound Question { get { return default(System.Media.SystemSound); } }
  }
}
namespace System.Net {
  public partial class AuthenticationManager {
    internal AuthenticationManager() { }
    public static System.Net.ICredentialPolicy CredentialPolicy { get { return default(System.Net.ICredentialPolicy); } set { } }
    [System.MonoTODOAttribute]
    public static System.Collections.Specialized.StringDictionary CustomTargetNameDictionary { get { return default(System.Collections.Specialized.StringDictionary); } }
    public static System.Collections.IEnumerator RegisteredModules { get { return default(System.Collections.IEnumerator); } }
    public static System.Net.Authorization Authenticate(string challenge, System.Net.WebRequest request, System.Net.ICredentials credentials) { return default(System.Net.Authorization); }
    public static System.Net.Authorization PreAuthenticate(System.Net.WebRequest request, System.Net.ICredentials credentials) { return default(System.Net.Authorization); }
    public static void Register(System.Net.IAuthenticationModule authenticationModule) { }
    public static void Unregister(System.Net.IAuthenticationModule authenticationModule) { }
    public static void Unregister(string authenticationScheme) { }
  }
  [System.FlagsAttribute]
  public enum AuthenticationSchemes {
    Anonymous = 32768,
    Basic = 8,
    Digest = 1,
    IntegratedWindowsAuthentication = 6,
    Negotiate = 2,
    None = 0,
    Ntlm = 4,
  }
  public delegate System.Net.AuthenticationSchemes AuthenticationSchemeSelector(System.Net.HttpListenerRequest httpRequest);
  public partial class Authorization {
    public Authorization(string token) { }
    public Authorization(string token, bool finished) { }
    public Authorization(string token, bool finished, string connectionGroupId) { }
    public bool Complete { get { return default(bool); } }
    public string ConnectionGroupId { get { return default(string); } }
    public string Message { get { return default(string); } }
    [System.MonoTODOAttribute]
    public bool MutuallyAuthenticated { get { return default(bool); } set { } }
    public System.String[] ProtectionRealm { get { return default(System.String[]); } set { } }
  }
  public delegate System.Net.IPEndPoint BindIPEndPoint(System.Net.ServicePoint servicePoint, System.Net.IPEndPoint remoteEndPoint, int retryCount);
  public delegate System.Collections.Generic.IEnumerable<System.String> CipherSuitesCallback(System.Net.SecurityProtocolType protocol, System.Collections.Generic.IEnumerable<System.String> allCiphers);
  public sealed partial class Cookie {
    public Cookie() { }
    public Cookie(string name, string value) { }
    public Cookie(string name, string value, string path) { }
    public Cookie(string name, string value, string path, string domain) { }
    public string Comment { get { return default(string); } set { } }
    public System.Uri CommentUri { get { return default(System.Uri); } set { } }
    public bool Discard { get { return default(bool); } set { } }
    public string Domain { get { return default(string); } set { } }
    public bool Expired { get { return default(bool); } set { } }
    public System.DateTime Expires { get { return default(System.DateTime); } set { } }
    public bool HttpOnly { get { return default(bool); } set { } }
    public string Name { get { return default(string); } set { } }
    public string Path { get { return default(string); } set { } }
    public string Port { get { return default(string); } set { } }
    public bool Secure { get { return default(bool); } set { } }
    public System.DateTime TimeStamp { get { return default(System.DateTime); } }
    public string Value { get { return default(string); } set { } }
    public int Version { get { return default(int); } set { } }
    public override bool Equals(object comparand) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
  }
  public partial class CookieCollection : System.Collections.ICollection, System.Collections.IEnumerable {
    public CookieCollection() { }
    public int Count { get { return default(int); } }
    public bool IsReadOnly { get { return default(bool); } }
    public bool IsSynchronized { get { return default(bool); } }
    public System.Net.Cookie this[int index] { get { return default(System.Net.Cookie); } }
    public System.Net.Cookie this[string name] { get { return default(System.Net.Cookie); } }
    public object SyncRoot { get { return default(object); } }
    public void Add(System.Net.Cookie cookie) { }
    public void Add(System.Net.CookieCollection cookies) { }
    public void CopyTo(System.Array array, int index) { }
    public void CopyTo(System.Net.Cookie[] array, int index) { }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public partial class CookieContainer {
    public const int DefaultCookieLengthLimit = 4096;
    public const int DefaultCookieLimit = 300;
    public const int DefaultPerDomainCookieLimit = 20;
    public CookieContainer() { }
    public CookieContainer(int capacity) { }
    public CookieContainer(int capacity, int perDomainCapacity, int maxCookieSize) { }
    public int Capacity { get { return default(int); } set { } }
    public int Count { get { return default(int); } }
    public int MaxCookieSize { get { return default(int); } set { } }
    public int PerDomainCapacity { get { return default(int); } set { } }
    public void Add(System.Net.Cookie cookie) { }
    public void Add(System.Net.CookieCollection cookies) { }
    public void Add(System.Uri uri, System.Net.Cookie cookie) { }
    public void Add(System.Uri uri, System.Net.CookieCollection cookies) { }
    public string GetCookieHeader(System.Uri uri) { return default(string); }
    public System.Net.CookieCollection GetCookies(System.Uri uri) { return default(System.Net.CookieCollection); }
    public void SetCookies(System.Uri uri, string cookieHeader) { }
  }
  public partial class CookieException : System.FormatException, System.Runtime.Serialization.ISerializable {
    public CookieException() { }
    protected CookieException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial class CredentialCache : System.Collections.IEnumerable, System.Net.ICredentials, System.Net.ICredentialsByHost {
    public CredentialCache() { }
    [System.MonoTODOAttribute("Need EnvironmentPermission implementation first")]
    public static System.Net.ICredentials DefaultCredentials { get { return default(System.Net.ICredentials); } }
    public static System.Net.NetworkCredential DefaultNetworkCredentials { get { return default(System.Net.NetworkCredential); } }
    public void Add(string host, int port, string authenticationType, System.Net.NetworkCredential credential) { }
    public void Add(System.Uri uriPrefix, string authType, System.Net.NetworkCredential cred) { }
    public System.Net.NetworkCredential GetCredential(string host, int port, string authenticationType) { return default(System.Net.NetworkCredential); }
    public System.Net.NetworkCredential GetCredential(System.Uri uriPrefix, string authType) { return default(System.Net.NetworkCredential); }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public void Remove(string host, int port, string authenticationType) { }
    public void Remove(System.Uri uriPrefix, string authType) { }
  }
  [System.FlagsAttribute]
  public enum DecompressionMethods {
    Deflate = 2,
    GZip = 1,
    None = 0,
  }
  public static partial class Dns {
    public static System.IAsyncResult BeginGetHostAddresses(string hostNameOrAddress, System.AsyncCallback requestCallback, object state) { return default(System.IAsyncResult); }
    [System.ObsoleteAttribute("Use BeginGetHostEntry instead")]
    public static System.IAsyncResult BeginGetHostByName(string hostName, System.AsyncCallback requestCallback, object stateObject) { return default(System.IAsyncResult); }
    public static System.IAsyncResult BeginGetHostEntry(System.Net.IPAddress address, System.AsyncCallback requestCallback, object stateObject) { return default(System.IAsyncResult); }
    public static System.IAsyncResult BeginGetHostEntry(string hostNameOrAddress, System.AsyncCallback requestCallback, object stateObject) { return default(System.IAsyncResult); }
    [System.ObsoleteAttribute("Use BeginGetHostEntry instead")]
    public static System.IAsyncResult BeginResolve(string hostName, System.AsyncCallback requestCallback, object stateObject) { return default(System.IAsyncResult); }
    public static System.Net.IPAddress[] EndGetHostAddresses(System.IAsyncResult asyncResult) { return default(System.Net.IPAddress[]); }
    [System.ObsoleteAttribute("Use EndGetHostEntry instead")]
    public static System.Net.IPHostEntry EndGetHostByName(System.IAsyncResult asyncResult) { return default(System.Net.IPHostEntry); }
    public static System.Net.IPHostEntry EndGetHostEntry(System.IAsyncResult asyncResult) { return default(System.Net.IPHostEntry); }
    [System.ObsoleteAttribute("Use EndGetHostEntry instead")]
    public static System.Net.IPHostEntry EndResolve(System.IAsyncResult asyncResult) { return default(System.Net.IPHostEntry); }
    public static System.Net.IPAddress[] GetHostAddresses(string hostNameOrAddress) { return default(System.Net.IPAddress[]); }
    [System.ObsoleteAttribute("Use GetHostEntry instead")]
    public static System.Net.IPHostEntry GetHostByAddress(System.Net.IPAddress address) { return default(System.Net.IPHostEntry); }
    [System.ObsoleteAttribute("Use GetHostEntry instead")]
    public static System.Net.IPHostEntry GetHostByAddress(string address) { return default(System.Net.IPHostEntry); }
    [System.ObsoleteAttribute("Use GetHostEntry instead")]
    public static System.Net.IPHostEntry GetHostByName(string hostName) { return default(System.Net.IPHostEntry); }
    public static System.Net.IPHostEntry GetHostEntry(System.Net.IPAddress address) { return default(System.Net.IPHostEntry); }
    public static System.Net.IPHostEntry GetHostEntry(string hostNameOrAddress) { return default(System.Net.IPHostEntry); }
    public static string GetHostName() { return default(string); }
    [System.ObsoleteAttribute("Use GetHostEntry instead")]
    public static System.Net.IPHostEntry Resolve(string hostName) { return default(System.Net.IPHostEntry); }
  }
  public partial class DnsEndPoint : System.Net.EndPoint {
    public DnsEndPoint(string host, int port) { }
    public DnsEndPoint(string host, int port, System.Net.Sockets.AddressFamily addressFamily) { }
    public override System.Net.Sockets.AddressFamily AddressFamily { get { return default(System.Net.Sockets.AddressFamily); } }
    public string Host { get { return default(string); } }
    public int Port { get { return default(int); } }
    public override bool Equals(object comparand) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
  }
  public sealed partial class DnsPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission {
    public DnsPermission(System.Security.Permissions.PermissionState state) { }
    public override System.Security.IPermission Copy() { return default(System.Security.IPermission); }
    public override void FromXml(System.Security.SecurityElement securityElement) { }
    public override System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
    public override bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
    public bool IsUnrestricted() { return default(bool); }
    public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
    public override System.Security.IPermission Union(System.Security.IPermission target) { return default(System.Security.IPermission); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
  public sealed partial class DnsPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute {
    public DnsPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
    public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
  }
  public partial class DownloadDataCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    internal DownloadDataCompletedEventArgs() : base (default(System.Exception), default(bool), default(object)) { }
    public System.Byte[] Result { get { return default(System.Byte[]); } }
  }
  public delegate void DownloadDataCompletedEventHandler(object sender, System.Net.DownloadDataCompletedEventArgs e);
  public partial class DownloadProgressChangedEventArgs : System.ComponentModel.ProgressChangedEventArgs {
    internal DownloadProgressChangedEventArgs() : base (default(int), default(object)) { }
    public long BytesReceived { get { return default(long); } }
    public long TotalBytesToReceive { get { return default(long); } }
  }
  public delegate void DownloadProgressChangedEventHandler(object sender, System.Net.DownloadProgressChangedEventArgs e);
  public partial class DownloadStringCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    internal DownloadStringCompletedEventArgs() : base (default(System.Exception), default(bool), default(object)) { }
    public string Result { get { return default(string); } }
  }
  public delegate void DownloadStringCompletedEventHandler(object sender, System.Net.DownloadStringCompletedEventArgs e);
  public abstract partial class EndPoint {
    protected EndPoint() { }
    public virtual System.Net.Sockets.AddressFamily AddressFamily { get { return default(System.Net.Sockets.AddressFamily); } }
    public virtual System.Net.EndPoint Create(System.Net.SocketAddress socketAddress) { return default(System.Net.EndPoint); }
    public virtual System.Net.SocketAddress Serialize() { return default(System.Net.SocketAddress); }
  }
  public partial class EndpointPermission {
    internal EndpointPermission() { }
    public string Hostname { get { return default(string); } }
    public int Port { get { return default(int); } }
    public System.Net.TransportType Transport { get { return default(System.Net.TransportType); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
  }
  public partial class FileWebRequest : System.Net.WebRequest, System.Runtime.Serialization.ISerializable {
    [System.ObsoleteAttribute("Serialization is obsoleted for this type", false)]
    protected FileWebRequest(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    public override string ConnectionGroupName { get { return default(string); } set { } }
    public override long ContentLength { get { return default(long); } set { } }
    public override string ContentType { get { return default(string); } set { } }
    public override System.Net.ICredentials Credentials { get { return default(System.Net.ICredentials); } set { } }
    public override System.Net.WebHeaderCollection Headers { get { return default(System.Net.WebHeaderCollection); } }
    public override string Method { get { return default(string); } set { } }
    public override bool PreAuthenticate { get { return default(bool); } set { } }
    public override System.Net.IWebProxy Proxy { get { return default(System.Net.IWebProxy); } set { } }
    public override System.Uri RequestUri { get { return default(System.Uri); } }
    public override int Timeout { get { return default(int); } set { } }
    public override bool UseDefaultCredentials { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public override void Abort() { }
    public override System.IAsyncResult BeginGetRequestStream(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public override System.IAsyncResult BeginGetResponse(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public override System.IO.Stream EndGetRequestStream(System.IAsyncResult asyncResult) { return default(System.IO.Stream); }
    public override System.Net.WebResponse EndGetResponse(System.IAsyncResult asyncResult) { return default(System.Net.WebResponse); }
    protected override void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    public override System.IO.Stream GetRequestStream() { return default(System.IO.Stream); }
    public override System.Net.WebResponse GetResponse() { return default(System.Net.WebResponse); }
    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
  }
  public partial class FileWebResponse : System.Net.WebResponse, System.IDisposable, System.Runtime.Serialization.ISerializable {
    [System.ObsoleteAttribute("Serialization is obsoleted for this type", false)]
    protected FileWebResponse(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    public override long ContentLength { get { return default(long); } }
    public override string ContentType { get { return default(string); } }
    public override System.Net.WebHeaderCollection Headers { get { return default(System.Net.WebHeaderCollection); } }
    public override System.Uri ResponseUri { get { return default(System.Uri); } }
    public override void Close() { }
    protected override void Dispose(bool disposing) { }
    ~FileWebResponse() { }
    protected override void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    public override System.IO.Stream GetResponseStream() { return default(System.IO.Stream); }
    void System.IDisposable.Dispose() { }
    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
  }
  public enum FtpStatusCode {
    AccountNeeded = 532,
    ActionAbortedLocalProcessingError = 451,
    ActionAbortedUnknownPageType = 551,
    ActionNotTakenFilenameNotAllowed = 553,
    ActionNotTakenFileUnavailable = 550,
    ActionNotTakenFileUnavailableOrBusy = 450,
    ActionNotTakenInsufficientSpace = 452,
    ArgumentSyntaxError = 501,
    BadCommandSequence = 503,
    CantOpenData = 425,
    ClosingControl = 221,
    ClosingData = 226,
    CommandExtraneous = 202,
    CommandNotImplemented = 502,
    CommandOK = 200,
    CommandSyntaxError = 500,
    ConnectionClosed = 426,
    DataAlreadyOpen = 125,
    DirectoryStatus = 212,
    EnteringPassive = 227,
    FileActionAborted = 552,
    FileActionOK = 250,
    FileCommandPending = 350,
    FileStatus = 213,
    LoggedInProceed = 230,
    NeedLoginAccount = 332,
    NotLoggedIn = 530,
    OpeningData = 150,
    PathnameCreated = 257,
    RestartMarker = 110,
    SendPasswordCommand = 331,
    SendUserCommand = 220,
    ServerWantsSecureSession = 234,
    ServiceNotAvailable = 421,
    ServiceTemporarilyNotAvailable = 120,
    SystemType = 215,
    Undefined = 0,
  }
  public sealed partial class FtpWebRequest : System.Net.WebRequest {
    internal FtpWebRequest() { }
    [System.MonoTODOAttribute]
    public System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates { get { return default(System.Security.Cryptography.X509Certificates.X509CertificateCollection); } set { } }
    [System.MonoTODOAttribute]
    public override string ConnectionGroupName { get { return default(string); } set { } }
    public override long ContentLength { get { return default(long); } set { } }
    public long ContentOffset { get { return default(long); } set { } }
    public override string ContentType { get { return default(string); } set { } }
    public override System.Net.ICredentials Credentials { get { return default(System.Net.ICredentials); } set { } }
    [System.MonoTODOAttribute]
    public static new System.Net.Cache.RequestCachePolicy DefaultCachePolicy { get { return default(System.Net.Cache.RequestCachePolicy); } set { } }
    public bool EnableSsl { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public override System.Net.WebHeaderCollection Headers { get { return default(System.Net.WebHeaderCollection); } set { } }
    [System.MonoTODOAttribute("We don't support KeepAlive = true")]
    public bool KeepAlive { get { return default(bool); } set { } }
    public override string Method { get { return default(string); } set { } }
    public override bool PreAuthenticate { get { return default(bool); } set { } }
    public override System.Net.IWebProxy Proxy { get { return default(System.Net.IWebProxy); } set { } }
    public int ReadWriteTimeout { get { return default(int); } set { } }
    public string RenameTo { get { return default(string); } set { } }
    public override System.Uri RequestUri { get { return default(System.Uri); } }
    public System.Net.ServicePoint ServicePoint { get { return default(System.Net.ServicePoint); } }
    public override int Timeout { get { return default(int); } set { } }
    public bool UseBinary { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public override bool UseDefaultCredentials { get { return default(bool); } set { } }
    public bool UsePassive { get { return default(bool); } set { } }
    public override void Abort() { }
    public override System.IAsyncResult BeginGetRequestStream(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public override System.IAsyncResult BeginGetResponse(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public override System.IO.Stream EndGetRequestStream(System.IAsyncResult asyncResult) { return default(System.IO.Stream); }
    public override System.Net.WebResponse EndGetResponse(System.IAsyncResult asyncResult) { return default(System.Net.WebResponse); }
    public override System.IO.Stream GetRequestStream() { return default(System.IO.Stream); }
    public override System.Net.WebResponse GetResponse() { return default(System.Net.WebResponse); }
  }
  public partial class FtpWebResponse : System.Net.WebResponse {
    internal FtpWebResponse() { }
    public string BannerMessage { get { return default(string); } }
    public override long ContentLength { get { return default(long); } }
    public string ExitMessage { get { return default(string); } }
    public override System.Net.WebHeaderCollection Headers { get { return default(System.Net.WebHeaderCollection); } }
    public System.DateTime LastModified { get { return default(System.DateTime); } }
    public override System.Uri ResponseUri { get { return default(System.Uri); } }
    public System.Net.FtpStatusCode StatusCode { get { return default(System.Net.FtpStatusCode); } }
    public string StatusDescription { get { return default(string); } }
    public string WelcomeMessage { get { return default(string); } }
    public override void Close() { }
    public override System.IO.Stream GetResponseStream() { return default(System.IO.Stream); }
  }
  [System.ObsoleteAttribute("Use WebRequest.DefaultProxy instead")]
  public partial class GlobalProxySelection {
    public GlobalProxySelection() { }
    public static System.Net.IWebProxy Select { get { return default(System.Net.IWebProxy); } set { } }
    public static System.Net.IWebProxy GetEmptyWebProxy() { return default(System.Net.IWebProxy); }
  }
  public delegate void HttpContinueDelegate(int StatusCode, System.Net.WebHeaderCollection httpHeaders);
  public sealed partial class HttpListener : System.IDisposable {
    public HttpListener() { }
    public System.Net.AuthenticationSchemes AuthenticationSchemes { get { return default(System.Net.AuthenticationSchemes); } set { } }
    public System.Net.AuthenticationSchemeSelector AuthenticationSchemeSelectorDelegate { get { return default(System.Net.AuthenticationSchemeSelector); } set { } }
    public bool IgnoreWriteExceptions { get { return default(bool); } set { } }
    public bool IsListening { get { return default(bool); } }
    public static bool IsSupported { get { return default(bool); } }
    public System.Net.HttpListenerPrefixCollection Prefixes { get { return default(System.Net.HttpListenerPrefixCollection); } }
    public string Realm { get { return default(string); } set { } }
    [System.MonoTODOAttribute("Support for NTLM needs some loving.")]
    public bool UnsafeConnectionNtlmAuthentication { get { return default(bool); } set { } }
    public void Abort() { }
    public System.IAsyncResult BeginGetContext(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public void Close() { }
    public System.Net.HttpListenerContext EndGetContext(System.IAsyncResult asyncResult) { return default(System.Net.HttpListenerContext); }
    public System.Net.HttpListenerContext GetContext() { return default(System.Net.HttpListenerContext); }
    public void Start() { }
    public void Stop() { }
    void System.IDisposable.Dispose() { }
  }
  public partial class HttpListenerBasicIdentity : System.Security.Principal.GenericIdentity {
    public HttpListenerBasicIdentity(string username, string password) : base (default(string), default(string)) { }
    public virtual string Password { get { return default(string); } }
  }
  public sealed partial class HttpListenerContext {
    internal HttpListenerContext() { }
    public System.Net.HttpListenerRequest Request { get { return default(System.Net.HttpListenerRequest); } }
    public System.Net.HttpListenerResponse Response { get { return default(System.Net.HttpListenerResponse); } }
    public System.Security.Principal.IPrincipal User { get { return default(System.Security.Principal.IPrincipal); } }
  }
  public partial class HttpListenerException : System.ComponentModel.Win32Exception {
    public HttpListenerException() { }
    public HttpListenerException(int errorCode) { }
    public HttpListenerException(int errorCode, string message) { }
    protected HttpListenerException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    public override int ErrorCode { get { return default(int); } }
  }
  public partial class HttpListenerPrefixCollection : System.Collections.Generic.ICollection<System.String>, System.Collections.Generic.IEnumerable<System.String>, System.Collections.IEnumerable {
    internal HttpListenerPrefixCollection() { }
    public int Count { get { return default(int); } }
    public bool IsReadOnly { get { return default(bool); } }
    public bool IsSynchronized { get { return default(bool); } }
    public void Add(string uriPrefix) { }
    public void Clear() { }
    public bool Contains(string uriPrefix) { return default(bool); }
    public void CopyTo(System.Array array, int offset) { }
    public void CopyTo(System.String[] array, int offset) { }
    public System.Collections.Generic.IEnumerator<System.String> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.String>); }
    public bool Remove(string uriPrefix) { return default(bool); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public sealed partial class HttpListenerRequest {
    internal HttpListenerRequest() { }
    public System.String[] AcceptTypes { get { return default(System.String[]); } }
    public int ClientCertificateError { get { return default(int); } }
    public System.Text.Encoding ContentEncoding { get { return default(System.Text.Encoding); } }
    public long ContentLength64 { get { return default(long); } }
    public string ContentType { get { return default(string); } }
    public System.Net.CookieCollection Cookies { get { return default(System.Net.CookieCollection); } }
    public bool HasEntityBody { get { return default(bool); } }
    public System.Collections.Specialized.NameValueCollection Headers { get { return default(System.Collections.Specialized.NameValueCollection); } }
    public string HttpMethod { get { return default(string); } }
    public System.IO.Stream InputStream { get { return default(System.IO.Stream); } }
    [System.MonoTODOAttribute("Always returns false")]
    public bool IsAuthenticated { get { return default(bool); } }
    public bool IsLocal { get { return default(bool); } }
    public bool IsSecureConnection { get { return default(bool); } }
    public bool KeepAlive { get { return default(bool); } }
    public System.Net.IPEndPoint LocalEndPoint { get { return default(System.Net.IPEndPoint); } }
    public System.Version ProtocolVersion { get { return default(System.Version); } }
    public System.Collections.Specialized.NameValueCollection QueryString { get { return default(System.Collections.Specialized.NameValueCollection); } }
    public string RawUrl { get { return default(string); } }
    public System.Net.IPEndPoint RemoteEndPoint { get { return default(System.Net.IPEndPoint); } }
    [System.MonoTODOAttribute("Always returns Guid.Empty")]
    public System.Guid RequestTraceIdentifier { get { return default(System.Guid); } }
    [System.MonoTODOAttribute]
    public string ServiceName { get { return default(string); } }
    public System.Net.TransportContext TransportContext { get { return default(System.Net.TransportContext); } }
    public System.Uri Url { get { return default(System.Uri); } }
    public System.Uri UrlReferrer { get { return default(System.Uri); } }
    public string UserAgent { get { return default(string); } }
    public string UserHostAddress { get { return default(string); } }
    public string UserHostName { get { return default(string); } }
    public System.String[] UserLanguages { get { return default(System.String[]); } }
    public System.IAsyncResult BeginGetClientCertificate(System.AsyncCallback requestCallback, object state) { return default(System.IAsyncResult); }
    public System.Security.Cryptography.X509Certificates.X509Certificate2 EndGetClientCertificate(System.IAsyncResult asyncResult) { return default(System.Security.Cryptography.X509Certificates.X509Certificate2); }
    public System.Security.Cryptography.X509Certificates.X509Certificate2 GetClientCertificate() { return default(System.Security.Cryptography.X509Certificates.X509Certificate2); }
  }
  public sealed partial class HttpListenerResponse : System.IDisposable {
    internal HttpListenerResponse() { }
    public System.Text.Encoding ContentEncoding { get { return default(System.Text.Encoding); } set { } }
    public long ContentLength64 { get { return default(long); } set { } }
    public string ContentType { get { return default(string); } set { } }
    public System.Net.CookieCollection Cookies { get { return default(System.Net.CookieCollection); } set { } }
    public System.Net.WebHeaderCollection Headers { get { return default(System.Net.WebHeaderCollection); } set { } }
    public bool KeepAlive { get { return default(bool); } set { } }
    public System.IO.Stream OutputStream { get { return default(System.IO.Stream); } }
    public System.Version ProtocolVersion { get { return default(System.Version); } set { } }
    public string RedirectLocation { get { return default(string); } set { } }
    public bool SendChunked { get { return default(bool); } set { } }
    public int StatusCode { get { return default(int); } set { } }
    public string StatusDescription { get { return default(string); } set { } }
    public void Abort() { }
    public void AddHeader(string name, string value) { }
    public void AppendCookie(System.Net.Cookie cookie) { }
    public void AppendHeader(string name, string value) { }
    public void Close() { }
    public void Close(System.Byte[] responseEntity, bool willBlock) { }
    public void CopyFrom(System.Net.HttpListenerResponse templateResponse) { }
    public void Redirect(string url) { }
    public void SetCookie(System.Net.Cookie cookie) { }
    void System.IDisposable.Dispose() { }
  }
  public enum HttpRequestHeader {
    Accept = 20,
    AcceptCharset = 21,
    AcceptEncoding = 22,
    AcceptLanguage = 23,
    Allow = 10,
    Authorization = 24,
    CacheControl = 0,
    Connection = 1,
    ContentEncoding = 13,
    ContentLanguage = 14,
    ContentLength = 11,
    ContentLocation = 15,
    ContentMd5 = 16,
    ContentRange = 17,
    ContentType = 12,
    Cookie = 25,
    Date = 2,
    Expect = 26,
    Expires = 18,
    From = 27,
    Host = 28,
    IfMatch = 29,
    IfModifiedSince = 30,
    IfNoneMatch = 31,
    IfRange = 32,
    IfUnmodifiedSince = 33,
    KeepAlive = 3,
    LastModified = 19,
    MaxForwards = 34,
    Pragma = 4,
    ProxyAuthorization = 35,
    Range = 37,
    Referer = 36,
    Te = 38,
    Trailer = 5,
    TransferEncoding = 6,
    Translate = 39,
    Upgrade = 7,
    UserAgent = 40,
    Via = 8,
    Warning = 9,
  }
  public enum HttpResponseHeader {
    AcceptRanges = 20,
    Age = 21,
    Allow = 10,
    CacheControl = 0,
    Connection = 1,
    ContentEncoding = 13,
    ContentLanguage = 14,
    ContentLength = 11,
    ContentLocation = 15,
    ContentMd5 = 16,
    ContentRange = 17,
    ContentType = 12,
    Date = 2,
    ETag = 22,
    Expires = 18,
    KeepAlive = 3,
    LastModified = 19,
    Location = 23,
    Pragma = 4,
    ProxyAuthenticate = 24,
    RetryAfter = 25,
    Server = 26,
    SetCookie = 27,
    Trailer = 5,
    TransferEncoding = 6,
    Upgrade = 7,
    Vary = 28,
    Via = 8,
    Warning = 9,
    WwwAuthenticate = 29,
  }
  public enum HttpStatusCode {
    Accepted = 202,
    Ambiguous = 300,
    BadGateway = 502,
    BadRequest = 400,
    Conflict = 409,
    Continue = 100,
    Created = 201,
    ExpectationFailed = 417,
    Forbidden = 403,
    Found = 302,
    GatewayTimeout = 504,
    Gone = 410,
    HttpVersionNotSupported = 505,
    InternalServerError = 500,
    LengthRequired = 411,
    MethodNotAllowed = 405,
    Moved = 301,
    MovedPermanently = 301,
    MultipleChoices = 300,
    NoContent = 204,
    NonAuthoritativeInformation = 203,
    NotAcceptable = 406,
    NotFound = 404,
    NotImplemented = 501,
    NotModified = 304,
    OK = 200,
    PartialContent = 206,
    PaymentRequired = 402,
    PreconditionFailed = 412,
    ProxyAuthenticationRequired = 407,
    Redirect = 302,
    RedirectKeepVerb = 307,
    RedirectMethod = 303,
    RequestedRangeNotSatisfiable = 416,
    RequestEntityTooLarge = 413,
    RequestTimeout = 408,
    RequestUriTooLong = 414,
    ResetContent = 205,
    SeeOther = 303,
    ServiceUnavailable = 503,
    SwitchingProtocols = 101,
    TemporaryRedirect = 307,
    Unauthorized = 401,
    UnsupportedMediaType = 415,
    Unused = 306,
    UseProxy = 305,
  }
  public partial class HttpVersion {
    public static readonly System.Version Version10;
    public static readonly System.Version Version11;
    public HttpVersion() { }
  }
  public partial class HttpWebRequest : System.Net.WebRequest, System.Runtime.Serialization.ISerializable {
    [System.ObsoleteAttribute("Serialization is obsoleted for this type", false)]
    protected HttpWebRequest(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    public string Accept { get { return default(string); } set { } }
    public System.Uri Address { get { return default(System.Uri); } }
    public bool AllowAutoRedirect { get { return default(bool); } set { } }
    public bool AllowWriteStreamBuffering { get { return default(bool); } set { } }
    public System.Net.DecompressionMethods AutomaticDecompression { get { return default(System.Net.DecompressionMethods); } set { } }
    public System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates { get { return default(System.Security.Cryptography.X509Certificates.X509CertificateCollection); } [System.MonoTODOAttribute]set { } }
    public string Connection { get { return default(string); } set { } }
    public override string ConnectionGroupName { get { return default(string); } set { } }
    public override long ContentLength { get { return default(long); } set { } }
    public override string ContentType { get { return default(string); } set { } }
    public System.Net.HttpContinueDelegate ContinueDelegate { get { return default(System.Net.HttpContinueDelegate); } set { } }
    public System.Net.CookieContainer CookieContainer { get { return default(System.Net.CookieContainer); } set { } }
    public override System.Net.ICredentials Credentials { get { return default(System.Net.ICredentials); } set { } }
    public System.DateTime Date { get { return default(System.DateTime); } set { } }
    [System.MonoTODOAttribute]
    public static new System.Net.Cache.RequestCachePolicy DefaultCachePolicy { get { return default(System.Net.Cache.RequestCachePolicy); } set { } }
    [System.MonoTODOAttribute]
    public static int DefaultMaximumErrorResponseLength { get { return default(int); } set { } }
    [System.MonoTODOAttribute("Use this")]
    public static int DefaultMaximumResponseHeadersLength { get { return default(int); } set { } }
    public string Expect { get { return default(string); } set { } }
    public bool HaveResponse { get { return default(bool); } }
    public override System.Net.WebHeaderCollection Headers { get { return default(System.Net.WebHeaderCollection); } set { } }
    public string Host { get { return default(string); } set { } }
    public System.DateTime IfModifiedSince { get { return default(System.DateTime); } set { } }
    public bool KeepAlive { get { return default(bool); } set { } }
    public int MaximumAutomaticRedirections { get { return default(int); } set { } }
    [System.MonoTODOAttribute("Use this")]
    public int MaximumResponseHeadersLength { get { return default(int); } set { } }
    public string MediaType { get { return default(string); } set { } }
    public override string Method { get { return default(string); } set { } }
    public bool Pipelined { get { return default(bool); } set { } }
    public override bool PreAuthenticate { get { return default(bool); } set { } }
    public System.Version ProtocolVersion { get { return default(System.Version); } set { } }
    public override System.Net.IWebProxy Proxy { get { return default(System.Net.IWebProxy); } set { } }
    public int ReadWriteTimeout { get { return default(int); } set { } }
    public string Referer { get { return default(string); } set { } }
    public override System.Uri RequestUri { get { return default(System.Uri); } }
    public bool SendChunked { get { return default(bool); } set { } }
    public System.Net.ServicePoint ServicePoint { get { return default(System.Net.ServicePoint); } }
    public virtual bool SupportsCookieContainer { get { return default(bool); } }
    public override int Timeout { get { return default(int); } set { } }
    public string TransferEncoding { get { return default(string); } set { } }
    public bool UnsafeAuthenticatedConnectionSharing { get { return default(bool); } set { } }
    public override bool UseDefaultCredentials { get { return default(bool); } set { } }
    public string UserAgent { get { return default(string); } set { } }
    public override void Abort() { }
    public void AddRange(int range) { }
    public void AddRange(int from, int to) { }
    public void AddRange(long range) { }
    public void AddRange(long from, long to) { }
    public void AddRange(string rangeSpecifier, int range) { }
    public void AddRange(string rangeSpecifier, int from, int to) { }
    public void AddRange(string rangeSpecifier, long range) { }
    public void AddRange(string rangeSpecifier, long from, long to) { }
    public override System.IAsyncResult BeginGetRequestStream(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public override System.IAsyncResult BeginGetResponse(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public override System.IO.Stream EndGetRequestStream(System.IAsyncResult asyncResult) { return default(System.IO.Stream); }
    public System.IO.Stream EndGetRequestStream(System.IAsyncResult asyncResult, out System.Net.TransportContext transportContext) { transportContext = default(System.Net.TransportContext); return default(System.IO.Stream); }
    public override System.Net.WebResponse EndGetResponse(System.IAsyncResult asyncResult) { return default(System.Net.WebResponse); }
    protected override void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    public override System.IO.Stream GetRequestStream() { return default(System.IO.Stream); }
    public override System.Net.WebResponse GetResponse() { return default(System.Net.WebResponse); }
    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
  }
  public partial class HttpWebResponse : System.Net.WebResponse, System.IDisposable, System.Runtime.Serialization.ISerializable {
    [System.ObsoleteAttribute("Serialization is obsoleted for this type", false)]
    protected HttpWebResponse(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    public string CharacterSet { get { return default(string); } }
    public string ContentEncoding { get { return default(string); } }
    public override long ContentLength { get { return default(long); } }
    public override string ContentType { get { return default(string); } }
    public System.Net.CookieCollection Cookies { get { return default(System.Net.CookieCollection); } set { } }
    public override System.Net.WebHeaderCollection Headers { get { return default(System.Net.WebHeaderCollection); } }
    [System.MonoTODOAttribute]
    public override bool IsMutuallyAuthenticated { get { return default(bool); } }
    public System.DateTime LastModified { get { return default(System.DateTime); } }
    public string Method { get { return default(string); } }
    public System.Version ProtocolVersion { get { return default(System.Version); } }
    public override System.Uri ResponseUri { get { return default(System.Uri); } }
    public string Server { get { return default(string); } }
    public System.Net.HttpStatusCode StatusCode { get { return default(System.Net.HttpStatusCode); } }
    public string StatusDescription { get { return default(string); } }
    public override void Close() { }
    protected override void Dispose(bool disposing) { }
    protected override void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    public string GetResponseHeader(string headerName) { return default(string); }
    public override System.IO.Stream GetResponseStream() { return default(System.IO.Stream); }
    void System.IDisposable.Dispose() { }
    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
  }
  public partial interface IAuthenticationModule {
    string AuthenticationType { get; }
    bool CanPreAuthenticate { get; }
    System.Net.Authorization Authenticate(string challenge, System.Net.WebRequest request, System.Net.ICredentials credentials);
    System.Net.Authorization PreAuthenticate(System.Net.WebRequest request, System.Net.ICredentials credentials);
  }
  public partial interface ICertificatePolicy {
    bool CheckValidationResult(System.Net.ServicePoint srvPoint, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Net.WebRequest request, int certificateProblem);
  }
  public partial interface ICredentialPolicy {
    bool ShouldSendCredential(System.Uri challengeUri, System.Net.WebRequest request, System.Net.NetworkCredential credential, System.Net.IAuthenticationModule authenticationModule);
  }
  public partial interface ICredentials {
    System.Net.NetworkCredential GetCredential(System.Uri uri, string authType);
  }
  public partial interface ICredentialsByHost {
    System.Net.NetworkCredential GetCredential(string host, int port, string authenticationType);
  }
  public partial class IPAddress {
    public static readonly System.Net.IPAddress Any;
    public static readonly System.Net.IPAddress Broadcast;
    public static readonly System.Net.IPAddress IPv6Any;
    public static readonly System.Net.IPAddress IPv6Loopback;
    public static readonly System.Net.IPAddress IPv6None;
    public static readonly System.Net.IPAddress Loopback;
    public static readonly System.Net.IPAddress None;
    public IPAddress(System.Byte[] address) { }
    public IPAddress(System.Byte[] address, long scopeid) { }
    public IPAddress(long newAddress) { }
    [System.ObsoleteAttribute("This property is obsolete. Use GetAddressBytes.")]
    public long Address { get { return default(long); } set { } }
    public System.Net.Sockets.AddressFamily AddressFamily { get { return default(System.Net.Sockets.AddressFamily); } }
    public bool IsIPv6LinkLocal { get { return default(bool); } }
    public bool IsIPv6Multicast { get { return default(bool); } }
    public bool IsIPv6SiteLocal { get { return default(bool); } }
    public bool IsIPv6Teredo { get { return default(bool); } }
    public long ScopeId { get { return default(long); } set { } }
    public override bool Equals(object comparand) { return default(bool); }
    public System.Byte[] GetAddressBytes() { return default(System.Byte[]); }
    public override int GetHashCode() { return default(int); }
    public static short HostToNetworkOrder(short host) { return default(short); }
    public static int HostToNetworkOrder(int host) { return default(int); }
    public static long HostToNetworkOrder(long host) { return default(long); }
    public static bool IsLoopback(System.Net.IPAddress address) { return default(bool); }
    public static short NetworkToHostOrder(short network) { return default(short); }
    public static int NetworkToHostOrder(int network) { return default(int); }
    public static long NetworkToHostOrder(long network) { return default(long); }
    public static System.Net.IPAddress Parse(string ipString) { return default(System.Net.IPAddress); }
    public override string ToString() { return default(string); }
    public static bool TryParse(string ipString, out System.Net.IPAddress address) { address = default(System.Net.IPAddress); return default(bool); }
  }
  public partial class IPEndPoint : System.Net.EndPoint {
    public const int MaxPort = 65535;
    public const int MinPort = 0;
    public IPEndPoint(long address, int port) { }
    public IPEndPoint(System.Net.IPAddress address, int port) { }
    public System.Net.IPAddress Address { get { return default(System.Net.IPAddress); } set { } }
    public override System.Net.Sockets.AddressFamily AddressFamily { get { return default(System.Net.Sockets.AddressFamily); } }
    public int Port { get { return default(int); } set { } }
    public override System.Net.EndPoint Create(System.Net.SocketAddress socketAddress) { return default(System.Net.EndPoint); }
    public override bool Equals(object comparand) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override System.Net.SocketAddress Serialize() { return default(System.Net.SocketAddress); }
    public override string ToString() { return default(string); }
  }
  public partial class IPHostEntry {
    public IPHostEntry() { }
    public System.Net.IPAddress[] AddressList { get { return default(System.Net.IPAddress[]); } set { } }
    public System.String[] Aliases { get { return default(System.String[]); } set { } }
    public string HostName { get { return default(string); } set { } }
  }
  public partial interface IWebProxy {
    System.Net.ICredentials Credentials { get; set; }
    System.Uri GetProxy(System.Uri destination);
    bool IsBypassed(System.Uri host);
  }
  public partial interface IWebProxyScript {
    void Close();
    bool Load(System.Uri scriptLocation, string script, System.Type helperType);
    string Run(string url, string host);
  }
  public partial interface IWebRequestCreate {
    System.Net.WebRequest Create(System.Uri uri);
  }
  [System.FlagsAttribute]
  public enum NetworkAccess {
    Accept = 128,
    Connect = 64,
  }
  public partial class NetworkCredential : System.Net.ICredentials, System.Net.ICredentialsByHost {
    public NetworkCredential() { }
    public NetworkCredential(string userName, System.Security.SecureString password) { }
    public NetworkCredential(string userName, System.Security.SecureString password, string domain) { }
    public NetworkCredential(string userName, string password) { }
    public NetworkCredential(string userName, string password, string domain) { }
    public string Domain { get { return default(string); } set { } }
    public string Password { get { return default(string); } set { } }
    public System.Security.SecureString SecurePassword { get { return default(System.Security.SecureString); } set { } }
    public string UserName { get { return default(string); } set { } }
    public System.Net.NetworkCredential GetCredential(string host, int port, string authenticationType) { return default(System.Net.NetworkCredential); }
    public System.Net.NetworkCredential GetCredential(System.Uri uri, string authType) { return default(System.Net.NetworkCredential); }
  }
  public partial class OpenReadCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    internal OpenReadCompletedEventArgs() : base (default(System.Exception), default(bool), default(object)) { }
    public System.IO.Stream Result { get { return default(System.IO.Stream); } }
  }
  public delegate void OpenReadCompletedEventHandler(object sender, System.Net.OpenReadCompletedEventArgs e);
  public partial class OpenWriteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    internal OpenWriteCompletedEventArgs() : base (default(System.Exception), default(bool), default(object)) { }
    public System.IO.Stream Result { get { return default(System.IO.Stream); } }
  }
  public delegate void OpenWriteCompletedEventHandler(object sender, System.Net.OpenWriteCompletedEventArgs e);
  public partial class ProtocolViolationException : System.InvalidOperationException, System.Runtime.Serialization.ISerializable {
    public ProtocolViolationException() { }
    protected ProtocolViolationException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    public ProtocolViolationException(string message) { }
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  [System.FlagsAttribute]
  public enum SecurityProtocolType {
    Ssl3 = 48,
    Tls = 192,
  }
  public partial class ServicePoint {
    internal ServicePoint() { }
    public System.Uri Address { get { return default(System.Uri); } }
    public System.Net.BindIPEndPoint BindIPEndPointDelegate { get { return default(System.Net.BindIPEndPoint); } set { } }
    public System.Security.Cryptography.X509Certificates.X509Certificate Certificate { get { return default(System.Security.Cryptography.X509Certificates.X509Certificate); } }
    public System.Security.Cryptography.X509Certificates.X509Certificate ClientCertificate { get { return default(System.Security.Cryptography.X509Certificates.X509Certificate); } }
    [System.MonoTODOAttribute]
    public int ConnectionLeaseTimeout { get { return default(int); } set { } }
    public int ConnectionLimit { get { return default(int); } set { } }
    public string ConnectionName { get { return default(string); } }
    public int CurrentConnections { get { return default(int); } }
    public bool Expect100Continue { get { return default(bool); } set { } }
    public System.DateTime IdleSince { get { return default(System.DateTime); } }
    public int MaxIdleTime { get { return default(int); } set { } }
    public virtual System.Version ProtocolVersion { get { return default(System.Version); } }
    [System.MonoTODOAttribute]
    public int ReceiveBufferSize { get { return default(int); } set { } }
    public bool SupportsPipelining { get { return default(bool); } }
    public bool UseNagleAlgorithm { get { return default(bool); } set { } }
    public bool CloseConnectionGroup(string connectionGroupName) { return default(bool); }
    public void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval) { }
  }
  public partial class ServicePointManager {
    internal ServicePointManager() { }
    public const int DefaultNonPersistentConnectionLimit = 4;
    public const int DefaultPersistentConnectionLimit = 2;
    [System.ObsoleteAttribute("Use ServerCertificateValidationCallback instead", false)]
    public static System.Net.ICertificatePolicy CertificatePolicy { get { return default(System.Net.ICertificatePolicy); } set { } }
    [System.MonoTODOAttribute("CRL checks not implemented")]
    public static bool CheckCertificateRevocationList { get { return default(bool); } set { } }
    public static System.Net.CipherSuitesCallback ClientCipherSuitesCallback { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Net.CipherSuitesCallback); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public static int DefaultConnectionLimit { get { return default(int); } set { } }
    [System.MonoTODOAttribute]
    public static int DnsRefreshTimeout { get { return default(int); } set { } }
    [System.MonoTODOAttribute]
    public static bool EnableDnsRoundRobin { get { return default(bool); } set { } }
    public static bool Expect100Continue { get { return default(bool); } set { } }
    public static int MaxServicePointIdleTime { get { return default(int); } set { } }
    public static int MaxServicePoints { get { return default(int); } set { } }
    public static System.Net.SecurityProtocolType SecurityProtocol { get { return default(System.Net.SecurityProtocolType); } set { } }
    public static System.Net.Security.RemoteCertificateValidationCallback ServerCertificateValidationCallback { get { return default(System.Net.Security.RemoteCertificateValidationCallback); } set { } }
    public static System.Net.CipherSuitesCallback ServerCipherSuitesCallback { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Net.CipherSuitesCallback); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public static bool UseNagleAlgorithm { get { return default(bool); } set { } }
    public static System.Net.ServicePoint FindServicePoint(string uriString, System.Net.IWebProxy proxy) { return default(System.Net.ServicePoint); }
    public static System.Net.ServicePoint FindServicePoint(System.Uri address) { return default(System.Net.ServicePoint); }
    public static System.Net.ServicePoint FindServicePoint(System.Uri address, System.Net.IWebProxy proxy) { return default(System.Net.ServicePoint); }
    public static void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval) { }
  }
  public partial class SocketAddress {
    public SocketAddress(System.Net.Sockets.AddressFamily family) { }
    public SocketAddress(System.Net.Sockets.AddressFamily family, int size) { }
    public System.Net.Sockets.AddressFamily Family { get { return default(System.Net.Sockets.AddressFamily); } }
    public byte this[int offset] { get { return default(byte); } set { } }
    public int Size { get { return default(int); } }
    public override bool Equals(object comparand) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
  }
  public sealed partial class SocketPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission {
    public const int AllPorts = -1;
    public SocketPermission(System.Net.NetworkAccess access, System.Net.TransportType transport, string hostName, int portNumber) { }
    public SocketPermission(System.Security.Permissions.PermissionState state) { }
    public System.Collections.IEnumerator AcceptList { get { return default(System.Collections.IEnumerator); } }
    public System.Collections.IEnumerator ConnectList { get { return default(System.Collections.IEnumerator); } }
    public void AddPermission(System.Net.NetworkAccess access, System.Net.TransportType transport, string hostName, int portNumber) { }
    public override System.Security.IPermission Copy() { return default(System.Security.IPermission); }
    public override void FromXml(System.Security.SecurityElement securityElement) { }
    public override System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
    public override bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
    public bool IsUnrestricted() { return default(bool); }
    public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
    public override System.Security.IPermission Union(System.Security.IPermission target) { return default(System.Security.IPermission); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
  public sealed partial class SocketPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute {
    public SocketPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
    public string Access { get { return default(string); } set { } }
    public string Host { get { return default(string); } set { } }
    public string Port { get { return default(string); } set { } }
    public string Transport { get { return default(string); } set { } }
    public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
  }
  public abstract partial class TransportContext {
    protected TransportContext() { }
    public abstract System.Security.Authentication.ExtendedProtection.ChannelBinding GetChannelBinding(System.Security.Authentication.ExtendedProtection.ChannelBindingKind kind);
  }
  public enum TransportType {
    All = 3,
    Connectionless = 1,
    ConnectionOriented = 2,
    Tcp = 2,
    Udp = 1,
  }
  public partial class UploadDataCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    internal UploadDataCompletedEventArgs() : base (default(System.Exception), default(bool), default(object)) { }
    public System.Byte[] Result { get { return default(System.Byte[]); } }
  }
  public delegate void UploadDataCompletedEventHandler(object sender, System.Net.UploadDataCompletedEventArgs e);
  public partial class UploadFileCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    internal UploadFileCompletedEventArgs() : base (default(System.Exception), default(bool), default(object)) { }
    public System.Byte[] Result { get { return default(System.Byte[]); } }
  }
  public delegate void UploadFileCompletedEventHandler(object sender, System.Net.UploadFileCompletedEventArgs e);
  public partial class UploadProgressChangedEventArgs : System.ComponentModel.ProgressChangedEventArgs {
    internal UploadProgressChangedEventArgs() : base (default(int), default(object)) { }
    public long BytesReceived { get { return default(long); } }
    public long BytesSent { get { return default(long); } }
    public long TotalBytesToReceive { get { return default(long); } }
    public long TotalBytesToSend { get { return default(long); } }
  }
  public delegate void UploadProgressChangedEventHandler(object sender, System.Net.UploadProgressChangedEventArgs e);
  public partial class UploadStringCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    internal UploadStringCompletedEventArgs() : base (default(System.Exception), default(bool), default(object)) { }
    public string Result { get { return default(string); } }
  }
  public delegate void UploadStringCompletedEventHandler(object sender, System.Net.UploadStringCompletedEventArgs e);
  public partial class UploadValuesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    internal UploadValuesCompletedEventArgs() : base (default(System.Exception), default(bool), default(object)) { }
    public System.Byte[] Result { get { return default(System.Byte[]); } }
  }
  public delegate void UploadValuesCompletedEventHandler(object sender, System.Net.UploadValuesCompletedEventArgs e);
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class WebClient : System.ComponentModel.Component {
    public WebClient() { }
    public string BaseAddress { get { return default(string); } set { } }
    [System.MonoTODOAttribute("Value can be set but is currently ignored")]
    public System.Net.Cache.RequestCachePolicy CachePolicy { get { return default(System.Net.Cache.RequestCachePolicy); } set { } }
    public System.Net.ICredentials Credentials { get { return default(System.Net.ICredentials); } set { } }
    public System.Text.Encoding Encoding { get { return default(System.Text.Encoding); } set { } }
    public System.Net.WebHeaderCollection Headers { get { return default(System.Net.WebHeaderCollection); } set { } }
    public bool IsBusy { get { return default(bool); } }
    public System.Net.IWebProxy Proxy { get { return default(System.Net.IWebProxy); } set { } }
    public System.Collections.Specialized.NameValueCollection QueryString { get { return default(System.Collections.Specialized.NameValueCollection); } set { } }
    public System.Net.WebHeaderCollection ResponseHeaders { get { return default(System.Net.WebHeaderCollection); } }
    [System.MonoTODOAttribute("Value can be set but is ignored")]
    public bool UseDefaultCredentials { get { return default(bool); } set { } }
    public event System.Net.DownloadDataCompletedEventHandler DownloadDataCompleted { add { } remove { } }
    public event System.ComponentModel.AsyncCompletedEventHandler DownloadFileCompleted { add { } remove { } }
    public event System.Net.DownloadProgressChangedEventHandler DownloadProgressChanged { add { } remove { } }
    public event System.Net.DownloadStringCompletedEventHandler DownloadStringCompleted { add { } remove { } }
    public event System.Net.OpenReadCompletedEventHandler OpenReadCompleted { add { } remove { } }
    public event System.Net.OpenWriteCompletedEventHandler OpenWriteCompleted { add { } remove { } }
    public event System.Net.UploadDataCompletedEventHandler UploadDataCompleted { add { } remove { } }
    public event System.Net.UploadFileCompletedEventHandler UploadFileCompleted { add { } remove { } }
    public event System.Net.UploadProgressChangedEventHandler UploadProgressChanged { add { } remove { } }
    public event System.Net.UploadStringCompletedEventHandler UploadStringCompleted { add { } remove { } }
    public event System.Net.UploadValuesCompletedEventHandler UploadValuesCompleted { add { } remove { } }
    public void CancelAsync() { }
    public System.Byte[] DownloadData(string address) { return default(System.Byte[]); }
    public System.Byte[] DownloadData(System.Uri address) { return default(System.Byte[]); }
    public void DownloadDataAsync(System.Uri address) { }
    public void DownloadDataAsync(System.Uri address, object userToken) { }
    public void DownloadFile(string address, string fileName) { }
    public void DownloadFile(System.Uri address, string fileName) { }
    public void DownloadFileAsync(System.Uri address, string fileName) { }
    public void DownloadFileAsync(System.Uri address, string fileName, object userToken) { }
    public string DownloadString(string address) { return default(string); }
    public string DownloadString(System.Uri address) { return default(string); }
    public void DownloadStringAsync(System.Uri address) { }
    public void DownloadStringAsync(System.Uri address, object userToken) { }
    protected virtual System.Net.WebRequest GetWebRequest(System.Uri address) { return default(System.Net.WebRequest); }
    protected virtual System.Net.WebResponse GetWebResponse(System.Net.WebRequest request) { return default(System.Net.WebResponse); }
    protected virtual System.Net.WebResponse GetWebResponse(System.Net.WebRequest request, System.IAsyncResult result) { return default(System.Net.WebResponse); }
    protected virtual void OnDownloadDataCompleted(System.Net.DownloadDataCompletedEventArgs e) { }
    protected virtual void OnDownloadFileCompleted(System.ComponentModel.AsyncCompletedEventArgs e) { }
    protected virtual void OnDownloadProgressChanged(System.Net.DownloadProgressChangedEventArgs e) { }
    protected virtual void OnDownloadStringCompleted(System.Net.DownloadStringCompletedEventArgs e) { }
    protected virtual void OnOpenReadCompleted(System.Net.OpenReadCompletedEventArgs e) { }
    protected virtual void OnOpenWriteCompleted(System.Net.OpenWriteCompletedEventArgs e) { }
    protected virtual void OnUploadDataCompleted(System.Net.UploadDataCompletedEventArgs e) { }
    protected virtual void OnUploadFileCompleted(System.Net.UploadFileCompletedEventArgs e) { }
    protected virtual void OnUploadProgressChanged(System.Net.UploadProgressChangedEventArgs e) { }
    protected virtual void OnUploadStringCompleted(System.Net.UploadStringCompletedEventArgs e) { }
    protected virtual void OnUploadValuesCompleted(System.Net.UploadValuesCompletedEventArgs e) { }
    public System.IO.Stream OpenRead(string address) { return default(System.IO.Stream); }
    public System.IO.Stream OpenRead(System.Uri address) { return default(System.IO.Stream); }
    public void OpenReadAsync(System.Uri address) { }
    public void OpenReadAsync(System.Uri address, object userToken) { }
    public System.IO.Stream OpenWrite(string address) { return default(System.IO.Stream); }
    public System.IO.Stream OpenWrite(string address, string method) { return default(System.IO.Stream); }
    public System.IO.Stream OpenWrite(System.Uri address) { return default(System.IO.Stream); }
    public System.IO.Stream OpenWrite(System.Uri address, string method) { return default(System.IO.Stream); }
    public void OpenWriteAsync(System.Uri address) { }
    public void OpenWriteAsync(System.Uri address, string method) { }
    public void OpenWriteAsync(System.Uri address, string method, object userToken) { }
    public System.Byte[] UploadData(string address, System.Byte[] data) { return default(System.Byte[]); }
    public System.Byte[] UploadData(string address, string method, System.Byte[] data) { return default(System.Byte[]); }
    public System.Byte[] UploadData(System.Uri address, System.Byte[] data) { return default(System.Byte[]); }
    public System.Byte[] UploadData(System.Uri address, string method, System.Byte[] data) { return default(System.Byte[]); }
    public void UploadDataAsync(System.Uri address, System.Byte[] data) { }
    public void UploadDataAsync(System.Uri address, string method, System.Byte[] data) { }
    public void UploadDataAsync(System.Uri address, string method, System.Byte[] data, object userToken) { }
    public System.Byte[] UploadFile(string address, string fileName) { return default(System.Byte[]); }
    public System.Byte[] UploadFile(string address, string method, string fileName) { return default(System.Byte[]); }
    public System.Byte[] UploadFile(System.Uri address, string fileName) { return default(System.Byte[]); }
    public System.Byte[] UploadFile(System.Uri address, string method, string fileName) { return default(System.Byte[]); }
    public void UploadFileAsync(System.Uri address, string fileName) { }
    public void UploadFileAsync(System.Uri address, string method, string fileName) { }
    public void UploadFileAsync(System.Uri address, string method, string fileName, object userToken) { }
    public string UploadString(string address, string data) { return default(string); }
    public string UploadString(string address, string method, string data) { return default(string); }
    public string UploadString(System.Uri address, string data) { return default(string); }
    public string UploadString(System.Uri address, string method, string data) { return default(string); }
    public void UploadStringAsync(System.Uri address, string data) { }
    public void UploadStringAsync(System.Uri address, string method, string data) { }
    public void UploadStringAsync(System.Uri address, string method, string data, object userToken) { }
    public System.Byte[] UploadValues(string address, System.Collections.Specialized.NameValueCollection data) { return default(System.Byte[]); }
    public System.Byte[] UploadValues(string address, string method, System.Collections.Specialized.NameValueCollection data) { return default(System.Byte[]); }
    public System.Byte[] UploadValues(System.Uri address, System.Collections.Specialized.NameValueCollection data) { return default(System.Byte[]); }
    public System.Byte[] UploadValues(System.Uri address, string method, System.Collections.Specialized.NameValueCollection data) { return default(System.Byte[]); }
    public void UploadValuesAsync(System.Uri address, System.Collections.Specialized.NameValueCollection data) { }
    public void UploadValuesAsync(System.Uri address, string method, System.Collections.Specialized.NameValueCollection data) { }
    public void UploadValuesAsync(System.Uri address, string method, System.Collections.Specialized.NameValueCollection data, object userToken) { }
  }
  public partial class WebException : System.InvalidOperationException, System.Runtime.Serialization.ISerializable {
    public WebException() { }
    protected WebException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    public WebException(string message) { }
    public WebException(string message, System.Exception innerException) { }
    public WebException(string message, System.Exception innerException, System.Net.WebExceptionStatus status, System.Net.WebResponse response) { }
    public WebException(string message, System.Net.WebExceptionStatus status) { }
    public System.Net.WebResponse Response { get { return default(System.Net.WebResponse); } }
    public System.Net.WebExceptionStatus Status { get { return default(System.Net.WebExceptionStatus); } }
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public enum WebExceptionStatus {
    CacheEntryNotFound = 18,
    ConnectFailure = 2,
    ConnectionClosed = 8,
    KeepAliveFailure = 12,
    MessageLengthLimitExceeded = 17,
    NameResolutionFailure = 1,
    Pending = 13,
    PipelineFailure = 5,
    ProtocolError = 7,
    ProxyNameResolutionFailure = 15,
    ReceiveFailure = 3,
    RequestCanceled = 6,
    RequestProhibitedByCachePolicy = 19,
    RequestProhibitedByProxy = 20,
    SecureChannelFailure = 10,
    SendFailure = 4,
    ServerProtocolViolation = 11,
    Success = 0,
    Timeout = 14,
    TrustFailure = 9,
    UnknownError = 16,
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class WebHeaderCollection : System.Collections.Specialized.NameValueCollection, System.Runtime.Serialization.ISerializable {
    public WebHeaderCollection() { }
    protected WebHeaderCollection(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    public override System.String[] AllKeys { get { return default(System.String[]); } }
    public override int Count { get { return default(int); } }
    public string this[System.Net.HttpRequestHeader header] { get { return default(string); } set { } }
    public string this[System.Net.HttpResponseHeader header] { get { return default(string); } set { } }
    public override System.Collections.Specialized.NameObjectCollectionBase.KeysCollection Keys { get { return default(System.Collections.Specialized.NameObjectCollectionBase.KeysCollection); } }
    public void Add(System.Net.HttpRequestHeader header, string value) { }
    public void Add(System.Net.HttpResponseHeader header, string value) { }
    public void Add(string header) { }
    public override void Add(string name, string value) { }
    protected void AddWithoutValidate(string headerName, string headerValue) { }
    public override void Clear() { }
    public override string Get(int index) { return default(string); }
    public override string Get(string name) { return default(string); }
    public override System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public override string GetKey(int index) { return default(string); }
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    public override System.String[] GetValues(int index) { return default(System.String[]); }
    public override System.String[] GetValues(string header) { return default(System.String[]); }
    public static bool IsRestricted(string headerName) { return default(bool); }
    public static bool IsRestricted(string headerName, bool response) { return default(bool); }
    public override void OnDeserialization(object sender) { }
    public void Remove(System.Net.HttpRequestHeader header) { }
    public void Remove(System.Net.HttpResponseHeader header) { }
    public override void Remove(string name) { }
    public void Set(System.Net.HttpRequestHeader header, string value) { }
    public void Set(System.Net.HttpResponseHeader header, string value) { }
    public override void Set(string name, string value) { }
    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    public System.Byte[] ToByteArray() { return default(System.Byte[]); }
    public override string ToString() { return default(string); }
  }
  [System.MonoTODOAttribute("Most private members that include functionallity are not implemented!")]
  public sealed partial class WebPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission {
    public WebPermission() { }
    public WebPermission(System.Net.NetworkAccess access, string uriString) { }
    public WebPermission(System.Net.NetworkAccess access, System.Text.RegularExpressions.Regex uriRegex) { }
    public WebPermission(System.Security.Permissions.PermissionState state) { }
    public System.Collections.IEnumerator AcceptList { get { return default(System.Collections.IEnumerator); } }
    public System.Collections.IEnumerator ConnectList { get { return default(System.Collections.IEnumerator); } }
    public void AddPermission(System.Net.NetworkAccess access, string uriString) { }
    public void AddPermission(System.Net.NetworkAccess access, System.Text.RegularExpressions.Regex uriRegex) { }
    public override System.Security.IPermission Copy() { return default(System.Security.IPermission); }
    public override void FromXml(System.Security.SecurityElement securityElement) { }
    public override System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
    public override bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
    public bool IsUnrestricted() { return default(bool); }
    public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
    public override System.Security.IPermission Union(System.Security.IPermission target) { return default(System.Security.IPermission); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
  public sealed partial class WebPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute {
    public WebPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
    public string Accept { get { return default(string); } set { } }
    public string AcceptPattern { get { return default(string); } set { } }
    public string Connect { get { return default(string); } set { } }
    public string ConnectPattern { get { return default(string); } set { } }
    public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
  }
  public partial class WebProxy : System.Net.IWebProxy, System.Runtime.Serialization.ISerializable {
    public WebProxy() { }
    protected WebProxy(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    public WebProxy(string address) { }
    public WebProxy(string address, bool bypassOnLocal) { }
    public WebProxy(string address, bool bypassOnLocal, System.String[] bypassList) { }
    public WebProxy(string address, bool bypassOnLocal, System.String[] bypassList, System.Net.ICredentials credentials) { }
    public WebProxy(string host, int port) { }
    public WebProxy(System.Uri address) { }
    public WebProxy(System.Uri address, bool bypassOnLocal) { }
    public WebProxy(System.Uri address, bool bypassOnLocal, System.String[] bypassList) { }
    public WebProxy(System.Uri address, bool bypassOnLocal, System.String[] bypassList, System.Net.ICredentials credentials) { }
    public System.Uri Address { get { return default(System.Uri); } set { } }
    public System.Collections.ArrayList BypassArrayList { get { return default(System.Collections.ArrayList); } }
    public System.String[] BypassList { get { return default(System.String[]); } set { } }
    public bool BypassProxyOnLocal { get { return default(bool); } set { } }
    public System.Net.ICredentials Credentials { get { return default(System.Net.ICredentials); } set { } }
    [System.MonoTODOAttribute("Does not affect Credentials, since CredentialCache.DefaultCredentials is not implemented.")]
    public bool UseDefaultCredentials { get { return default(bool); } set { } }
    [System.MonoTODOAttribute("Can we get this info under windows from the system?")]
    [System.ObsoleteAttribute("This method has been deprecated", false)]
    public static System.Net.WebProxy GetDefaultProxy() { return default(System.Net.WebProxy); }
    protected virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    public System.Uri GetProxy(System.Uri destination) { return default(System.Uri); }
    public bool IsBypassed(System.Uri host) { return default(bool); }
    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
  }
  public abstract partial class WebRequest : System.MarshalByRefObject, System.Runtime.Serialization.ISerializable {
    protected WebRequest() { }
    protected WebRequest(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    public System.Net.Security.AuthenticationLevel AuthenticationLevel { get { return default(System.Net.Security.AuthenticationLevel); } set { } }
    [System.MonoTODOAttribute("Implement the caching system. Currently always returns a policy with the NoCacheNoStore level")]
    public virtual System.Net.Cache.RequestCachePolicy CachePolicy { get { return default(System.Net.Cache.RequestCachePolicy); } set { } }
    public virtual string ConnectionGroupName { get { return default(string); } set { } }
    public virtual long ContentLength { get { return default(long); } set { } }
    public virtual string ContentType { get { return default(string); } set { } }
    public virtual System.Net.ICredentials Credentials { get { return default(System.Net.ICredentials); } set { } }
    public static System.Net.Cache.RequestCachePolicy DefaultCachePolicy { get { return default(System.Net.Cache.RequestCachePolicy); } set { } }
    public static System.Net.IWebProxy DefaultWebProxy { get { return default(System.Net.IWebProxy); } set { } }
    public virtual System.Net.WebHeaderCollection Headers { get { return default(System.Net.WebHeaderCollection); } set { } }
    public System.Security.Principal.TokenImpersonationLevel ImpersonationLevel { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Security.Principal.TokenImpersonationLevel); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public virtual string Method { get { return default(string); } set { } }
    public virtual bool PreAuthenticate { get { return default(bool); } set { } }
    public virtual System.Net.IWebProxy Proxy { get { return default(System.Net.IWebProxy); } set { } }
    public virtual System.Uri RequestUri { get { return default(System.Uri); } }
    public virtual int Timeout { get { return default(int); } set { } }
    public virtual bool UseDefaultCredentials { get { return default(bool); } set { } }
    public virtual void Abort() { }
    public virtual System.IAsyncResult BeginGetRequestStream(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public virtual System.IAsyncResult BeginGetResponse(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public static System.Net.WebRequest Create(string requestUriString) { return default(System.Net.WebRequest); }
    public static System.Net.WebRequest Create(System.Uri requestUri) { return default(System.Net.WebRequest); }
    public static System.Net.WebRequest CreateDefault(System.Uri requestUri) { return default(System.Net.WebRequest); }
    public static System.Net.HttpWebRequest CreateHttp(string requestUriString) { return default(System.Net.HttpWebRequest); }
    public static System.Net.HttpWebRequest CreateHttp(System.Uri requestUri) { return default(System.Net.HttpWebRequest); }
    public virtual System.IO.Stream EndGetRequestStream(System.IAsyncResult asyncResult) { return default(System.IO.Stream); }
    public virtual System.Net.WebResponse EndGetResponse(System.IAsyncResult asyncResult) { return default(System.Net.WebResponse); }
    protected virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    public virtual System.IO.Stream GetRequestStream() { return default(System.IO.Stream); }
    public virtual System.Net.WebResponse GetResponse() { return default(System.Net.WebResponse); }
    [System.MonoTODOAttribute("Look in other places for proxy config info")]
    public static System.Net.IWebProxy GetSystemWebProxy() { return default(System.Net.IWebProxy); }
    public static bool RegisterPrefix(string prefix, System.Net.IWebRequestCreate creator) { return default(bool); }
    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
  }
  public static partial class WebRequestMethods {
    public static partial class File {
      public const string DownloadFile = "GET";
      public const string UploadFile = "PUT";
    }
    public static partial class Ftp {
      public const string AppendFile = "APPE";
      public const string DeleteFile = "DELE";
      public const string DownloadFile = "RETR";
      public const string GetDateTimestamp = "MDTM";
      public const string GetFileSize = "SIZE";
      public const string ListDirectory = "NLST";
      public const string ListDirectoryDetails = "LIST";
      public const string MakeDirectory = "MKD";
      public const string PrintWorkingDirectory = "PWD";
      public const string RemoveDirectory = "RMD";
      public const string Rename = "RENAME";
      public const string UploadFile = "STOR";
      public const string UploadFileWithUniqueName = "STOU";
    }
    public static partial class Http {
      public const string Connect = "CONNECT";
      public const string Get = "GET";
      public const string Head = "HEAD";
      public const string MkCol = "MKCOL";
      public const string Post = "POST";
      public const string Put = "PUT";
    }
  }
  public abstract partial class WebResponse : System.MarshalByRefObject, System.IDisposable, System.Runtime.Serialization.ISerializable {
    protected WebResponse() { }
    protected WebResponse(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    public virtual long ContentLength { get { return default(long); } set { } }
    public virtual string ContentType { get { return default(string); } set { } }
    public virtual System.Net.WebHeaderCollection Headers { get { return default(System.Net.WebHeaderCollection); } }
    [System.MonoTODOAttribute]
    public virtual bool IsFromCache { get { return default(bool); } }
    [System.MonoTODOAttribute]
    public virtual bool IsMutuallyAuthenticated { get { return default(bool); } }
    public virtual System.Uri ResponseUri { get { return default(System.Uri); } }
    public virtual bool SupportsHeaders { get { return default(bool); } }
    public virtual void Close() { }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    [System.MonoTODOAttribute]
    protected virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    public virtual System.IO.Stream GetResponseStream() { return default(System.IO.Stream); }
    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
  }
  public static partial class WebUtility {
    public static string HtmlDecode(string value) { return default(string); }
    public static void HtmlDecode(string value, System.IO.TextWriter output) { }
    public static string HtmlEncode(string value) { return default(string); }
    public static void HtmlEncode(string value, System.IO.TextWriter output) { }
    public static string UrlDecode(string encodedValue) { return default(string); }
    public static System.Byte[] UrlDecodeToBytes(System.Byte[] encodedValue, int offset, int count) { return default(System.Byte[]); }
    public static string UrlEncode(string value) { return default(string); }
    public static System.Byte[] UrlEncodeToBytes(System.Byte[] value, int offset, int count) { return default(System.Byte[]); }
  }
}
namespace System.Net.Cache {
  public enum HttpCacheAgeControl {
    MaxAge = 2,
    MaxAgeAndMaxStale = 6,
    MaxAgeAndMinFresh = 3,
    MaxStale = 4,
    MinFresh = 1,
    None = 0,
  }
  public enum HttpRequestCacheLevel {
    BypassCache = 1,
    CacheIfAvailable = 3,
    CacheOnly = 2,
    CacheOrNextCacheOnly = 7,
    Default = 0,
    NoCacheNoStore = 6,
    Refresh = 8,
    Reload = 5,
    Revalidate = 4,
  }
  public partial class HttpRequestCachePolicy : System.Net.Cache.RequestCachePolicy {
    public HttpRequestCachePolicy() { }
    public HttpRequestCachePolicy(System.DateTime cacheSyncDate) { }
    public HttpRequestCachePolicy(System.Net.Cache.HttpCacheAgeControl cacheAgeControl, System.TimeSpan ageOrFreshOrStale) { }
    public HttpRequestCachePolicy(System.Net.Cache.HttpCacheAgeControl cacheAgeControl, System.TimeSpan maxAge, System.TimeSpan freshOrStale) { }
    public HttpRequestCachePolicy(System.Net.Cache.HttpCacheAgeControl cacheAgeControl, System.TimeSpan maxAge, System.TimeSpan freshOrStale, System.DateTime cacheSyncDate) { }
    public HttpRequestCachePolicy(System.Net.Cache.HttpRequestCacheLevel level) { }
    public System.DateTime CacheSyncDate { get { return default(System.DateTime); } }
    public new System.Net.Cache.HttpRequestCacheLevel Level { get { return default(System.Net.Cache.HttpRequestCacheLevel); } }
    public System.TimeSpan MaxAge { get { return default(System.TimeSpan); } }
    public System.TimeSpan MaxStale { get { return default(System.TimeSpan); } }
    public System.TimeSpan MinFresh { get { return default(System.TimeSpan); } }
    [System.MonoTODOAttribute]
    public override string ToString() { return default(string); }
  }
  public enum RequestCacheLevel {
    BypassCache = 1,
    CacheIfAvailable = 3,
    CacheOnly = 2,
    Default = 0,
    NoCacheNoStore = 6,
    Reload = 5,
    Revalidate = 4,
  }
  public partial class RequestCachePolicy {
    public RequestCachePolicy() { }
    public RequestCachePolicy(System.Net.Cache.RequestCacheLevel level) { }
    public System.Net.Cache.RequestCacheLevel Level { get { return default(System.Net.Cache.RequestCacheLevel); } }
    [System.MonoTODOAttribute]
    public override string ToString() { return default(string); }
  }
}
namespace System.Net.Configuration {
  public sealed partial class AuthenticationModuleElement : System.Configuration.ConfigurationElement {
    public AuthenticationModuleElement() { }
    public AuthenticationModuleElement(string typeName) { }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("type", Options=(System.Configuration.ConfigurationPropertyOptions)(6))]
    public string Type { get { return default(string); } set { } }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.Net.Configuration.AuthenticationModuleElement), CollectionType=(System.Configuration.ConfigurationElementCollectionType)(1))]
  public sealed partial class AuthenticationModuleElementCollection : System.Configuration.ConfigurationElementCollection {
    [System.MonoTODOAttribute]
    public AuthenticationModuleElementCollection() { }
    [System.MonoTODOAttribute]
    public System.Net.Configuration.AuthenticationModuleElement this[int index] { get { return default(System.Net.Configuration.AuthenticationModuleElement); } set { } }
    [System.MonoTODOAttribute]
    public new System.Net.Configuration.AuthenticationModuleElement this[string name] { get { return default(System.Net.Configuration.AuthenticationModuleElement); } set { } }
    public void Add(System.Net.Configuration.AuthenticationModuleElement element) { }
    public void Clear() { }
    protected override System.Configuration.ConfigurationElement CreateNewElement() { return default(System.Configuration.ConfigurationElement); }
    [System.MonoTODOAttribute("argument exception?")]
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
    public int IndexOf(System.Net.Configuration.AuthenticationModuleElement element) { return default(int); }
    public void Remove(System.Net.Configuration.AuthenticationModuleElement element) { }
    public void Remove(string name) { }
    public void RemoveAt(int index) { }
  }
  public sealed partial class AuthenticationModulesSection : System.Configuration.ConfigurationSection {
    public AuthenticationModulesSection() { }
    [System.Configuration.ConfigurationPropertyAttribute("", Options=(System.Configuration.ConfigurationPropertyOptions)(1))]
    public System.Net.Configuration.AuthenticationModuleElementCollection AuthenticationModules { get { return default(System.Net.Configuration.AuthenticationModuleElementCollection); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.MonoTODOAttribute]
    protected override void InitializeDefault() { }
    [System.MonoTODOAttribute]
    protected override void PostDeserialize() { }
  }
  public sealed partial class BypassElement : System.Configuration.ConfigurationElement {
    public BypassElement() { }
    public BypassElement(string address) { }
    [System.Configuration.ConfigurationPropertyAttribute("address", Options=(System.Configuration.ConfigurationPropertyOptions)(6))]
    public string Address { get { return default(string); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.Net.Configuration.BypassElement), CollectionType=(System.Configuration.ConfigurationElementCollectionType)(1))]
  public sealed partial class BypassElementCollection : System.Configuration.ConfigurationElementCollection {
    public BypassElementCollection() { }
    [System.MonoTODOAttribute]
    public System.Net.Configuration.BypassElement this[int index] { get { return default(System.Net.Configuration.BypassElement); } set { } }
    public new System.Net.Configuration.BypassElement this[string name] { get { return default(System.Net.Configuration.BypassElement); } set { } }
    protected override bool ThrowOnDuplicate { get { return default(bool); } }
    public void Add(System.Net.Configuration.BypassElement element) { }
    public void Clear() { }
    protected override System.Configuration.ConfigurationElement CreateNewElement() { return default(System.Configuration.ConfigurationElement); }
    [System.MonoTODOAttribute("argument exception?")]
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
    public int IndexOf(System.Net.Configuration.BypassElement element) { return default(int); }
    public void Remove(System.Net.Configuration.BypassElement element) { }
    public void Remove(string name) { }
    public void RemoveAt(int index) { }
  }
  public sealed partial class ConnectionManagementElement : System.Configuration.ConfigurationElement {
    public ConnectionManagementElement() { }
    public ConnectionManagementElement(string address, int maxConnection) { }
    [System.Configuration.ConfigurationPropertyAttribute("address", Options=(System.Configuration.ConfigurationPropertyOptions)(6))]
    public string Address { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxconnection", DefaultValue="6", Options=(System.Configuration.ConfigurationPropertyOptions)(2))]
    public int MaxConnection { get { return default(int); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.Net.Configuration.ConnectionManagementElement), CollectionType=(System.Configuration.ConfigurationElementCollectionType)(1))]
  public sealed partial class ConnectionManagementElementCollection : System.Configuration.ConfigurationElementCollection {
    public ConnectionManagementElementCollection() { }
    [System.MonoTODOAttribute]
    public System.Net.Configuration.ConnectionManagementElement this[int index] { get { return default(System.Net.Configuration.ConnectionManagementElement); } set { } }
    public new System.Net.Configuration.ConnectionManagementElement this[string name] { get { return default(System.Net.Configuration.ConnectionManagementElement); } set { } }
    public void Add(System.Net.Configuration.ConnectionManagementElement element) { }
    public void Clear() { }
    protected override System.Configuration.ConfigurationElement CreateNewElement() { return default(System.Configuration.ConfigurationElement); }
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
    public int IndexOf(System.Net.Configuration.ConnectionManagementElement element) { return default(int); }
    public void Remove(System.Net.Configuration.ConnectionManagementElement element) { }
    public void Remove(string name) { }
    public void RemoveAt(int index) { }
  }
  public sealed partial class ConnectionManagementSection : System.Configuration.ConfigurationSection {
    public ConnectionManagementSection() { }
    [System.Configuration.ConfigurationPropertyAttribute("", Options=(System.Configuration.ConfigurationPropertyOptions)(1))]
    public System.Net.Configuration.ConnectionManagementElementCollection ConnectionManagement { get { return default(System.Net.Configuration.ConnectionManagementElementCollection); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  public sealed partial class DefaultProxySection : System.Configuration.ConfigurationSection {
    public DefaultProxySection() { }
    [System.Configuration.ConfigurationPropertyAttribute("bypasslist")]
    public System.Net.Configuration.BypassElementCollection BypassList { get { return default(System.Net.Configuration.BypassElementCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("enabled", DefaultValue="True")]
    public bool Enabled { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("module")]
    public System.Net.Configuration.ModuleElement Module { get { return default(System.Net.Configuration.ModuleElement); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("proxy")]
    public System.Net.Configuration.ProxyElement Proxy { get { return default(System.Net.Configuration.ProxyElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("useDefaultCredentials", DefaultValue="False")]
    public bool UseDefaultCredentials { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    protected override void PostDeserialize() { }
    [System.MonoTODOAttribute]
    protected override void Reset(System.Configuration.ConfigurationElement parentElement) { }
  }
  public sealed partial class FtpCachePolicyElement : System.Configuration.ConfigurationElement {
    public FtpCachePolicyElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("policyLevel", DefaultValue="Default")]
    public System.Net.Cache.RequestCacheLevel PolicyLevel { get { return default(System.Net.Cache.RequestCacheLevel); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.MonoTODOAttribute]
    protected override void DeserializeElement(System.Xml.XmlReader reader, bool serializeCollectionKey) { }
    [System.MonoTODOAttribute]
    protected override void Reset(System.Configuration.ConfigurationElement parentElement) { }
  }
  public sealed partial class HttpCachePolicyElement : System.Configuration.ConfigurationElement {
    public HttpCachePolicyElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("maximumAge", DefaultValue="10675199.02:48:05.4775807")]
    public System.TimeSpan MaximumAge { get { return default(System.TimeSpan); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maximumStale", DefaultValue="-10675199.02:48:05.4775808")]
    public System.TimeSpan MaximumStale { get { return default(System.TimeSpan); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("minimumFresh", DefaultValue="-10675199.02:48:05.4775808")]
    public System.TimeSpan MinimumFresh { get { return default(System.TimeSpan); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("policyLevel", DefaultValue="Default", Options=(System.Configuration.ConfigurationPropertyOptions)(2))]
    public System.Net.Cache.HttpRequestCacheLevel PolicyLevel { get { return default(System.Net.Cache.HttpRequestCacheLevel); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.MonoTODOAttribute]
    protected override void DeserializeElement(System.Xml.XmlReader reader, bool serializeCollectionKey) { }
    [System.MonoTODOAttribute]
    protected override void Reset(System.Configuration.ConfigurationElement parentElement) { }
  }
  public sealed partial class HttpWebRequestElement : System.Configuration.ConfigurationElement {
    public HttpWebRequestElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("maximumErrorResponseLength", DefaultValue="64")]
    public int MaximumErrorResponseLength { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maximumResponseHeadersLength", DefaultValue="64")]
    public int MaximumResponseHeadersLength { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maximumUnauthorizedUploadLength", DefaultValue="-1")]
    public int MaximumUnauthorizedUploadLength { get { return default(int); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("useUnsafeHeaderParsing", DefaultValue="False")]
    public bool UseUnsafeHeaderParsing { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    protected override void PostDeserialize() { }
  }
  public sealed partial class Ipv6Element : System.Configuration.ConfigurationElement {
    public Ipv6Element() { }
    [System.Configuration.ConfigurationPropertyAttribute("enabled", DefaultValue="False")]
    public bool Enabled { get { return default(bool); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  public sealed partial class MailSettingsSectionGroup : System.Configuration.ConfigurationSectionGroup {
    public MailSettingsSectionGroup() { }
    public System.Net.Configuration.SmtpSection Smtp { get { return default(System.Net.Configuration.SmtpSection); } }
  }
  public sealed partial class ModuleElement : System.Configuration.ConfigurationElement {
    public ModuleElement() { }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("type")]
    public string Type { get { return default(string); } set { } }
  }
  public sealed partial class NetSectionGroup : System.Configuration.ConfigurationSectionGroup {
    [System.MonoTODOAttribute]
    public NetSectionGroup() { }
    [System.Configuration.ConfigurationPropertyAttribute("authenticationModules")]
    public System.Net.Configuration.AuthenticationModulesSection AuthenticationModules { get { return default(System.Net.Configuration.AuthenticationModulesSection); } }
    [System.Configuration.ConfigurationPropertyAttribute("connectionManagement")]
    public System.Net.Configuration.ConnectionManagementSection ConnectionManagement { get { return default(System.Net.Configuration.ConnectionManagementSection); } }
    [System.Configuration.ConfigurationPropertyAttribute("defaultProxy")]
    public System.Net.Configuration.DefaultProxySection DefaultProxy { get { return default(System.Net.Configuration.DefaultProxySection); } }
    public System.Net.Configuration.MailSettingsSectionGroup MailSettings { get { return default(System.Net.Configuration.MailSettingsSectionGroup); } }
    [System.Configuration.ConfigurationPropertyAttribute("requestCaching")]
    public System.Net.Configuration.RequestCachingSection RequestCaching { get { return default(System.Net.Configuration.RequestCachingSection); } }
    [System.Configuration.ConfigurationPropertyAttribute("settings")]
    public System.Net.Configuration.SettingsSection Settings { get { return default(System.Net.Configuration.SettingsSection); } }
    [System.Configuration.ConfigurationPropertyAttribute("webRequestModules")]
    public System.Net.Configuration.WebRequestModulesSection WebRequestModules { get { return default(System.Net.Configuration.WebRequestModulesSection); } }
    [System.MonoTODOAttribute]
    public static System.Net.Configuration.NetSectionGroup GetSectionGroup(System.Configuration.Configuration config) { return default(System.Net.Configuration.NetSectionGroup); }
  }
  public sealed partial class PerformanceCountersElement : System.Configuration.ConfigurationElement {
    public PerformanceCountersElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("enabled", DefaultValue="False")]
    public bool Enabled { get { return default(bool); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  public sealed partial class ProxyElement : System.Configuration.ConfigurationElement {
    public ProxyElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("autoDetect", DefaultValue="Unspecified")]
    public System.Net.Configuration.ProxyElement.AutoDetectValues AutoDetect { get { return default(System.Net.Configuration.ProxyElement.AutoDetectValues); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("bypassonlocal", DefaultValue="Unspecified")]
    public System.Net.Configuration.ProxyElement.BypassOnLocalValues BypassOnLocal { get { return default(System.Net.Configuration.ProxyElement.BypassOnLocalValues); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("proxyaddress")]
    public System.Uri ProxyAddress { get { return default(System.Uri); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("scriptLocation")]
    public System.Uri ScriptLocation { get { return default(System.Uri); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("usesystemdefault", DefaultValue="Unspecified")]
    public System.Net.Configuration.ProxyElement.UseSystemDefaultValues UseSystemDefault { get { return default(System.Net.Configuration.ProxyElement.UseSystemDefaultValues); } set { } }
    public enum AutoDetectValues {
      False = 0,
      True = 1,
      Unspecified = -1,
    }
    public enum BypassOnLocalValues {
      False = 0,
      True = 1,
      Unspecified = -1,
    }
    public enum UseSystemDefaultValues {
      False = 0,
      True = 1,
      Unspecified = -1,
    }
  }
  public sealed partial class RequestCachingSection : System.Configuration.ConfigurationSection {
    public RequestCachingSection() { }
    [System.Configuration.ConfigurationPropertyAttribute("defaultFtpCachePolicy")]
    public System.Net.Configuration.FtpCachePolicyElement DefaultFtpCachePolicy { get { return default(System.Net.Configuration.FtpCachePolicyElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("defaultHttpCachePolicy")]
    public System.Net.Configuration.HttpCachePolicyElement DefaultHttpCachePolicy { get { return default(System.Net.Configuration.HttpCachePolicyElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("defaultPolicyLevel", DefaultValue="BypassCache")]
    public System.Net.Cache.RequestCacheLevel DefaultPolicyLevel { get { return default(System.Net.Cache.RequestCacheLevel); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("disableAllCaching", DefaultValue="False")]
    public bool DisableAllCaching { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("isPrivateCache", DefaultValue="True")]
    public bool IsPrivateCache { get { return default(bool); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("unspecifiedMaximumAge", DefaultValue="1.00:00:00")]
    public System.TimeSpan UnspecifiedMaximumAge { get { return default(System.TimeSpan); } set { } }
    [System.MonoTODOAttribute]
    protected override void DeserializeElement(System.Xml.XmlReader reader, bool serializeCollectionKey) { }
    [System.MonoTODOAttribute]
    protected override void PostDeserialize() { }
  }
  public sealed partial class ServicePointManagerElement : System.Configuration.ConfigurationElement {
    public ServicePointManagerElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("checkCertificateName", DefaultValue="True")]
    public bool CheckCertificateName { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("checkCertificateRevocationList", DefaultValue="False")]
    public bool CheckCertificateRevocationList { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("dnsRefreshTimeout", DefaultValue="120000")]
    public int DnsRefreshTimeout { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("enableDnsRoundRobin", DefaultValue="False")]
    public bool EnableDnsRoundRobin { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("expect100Continue", DefaultValue="True")]
    public bool Expect100Continue { get { return default(bool); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("useNagleAlgorithm", DefaultValue="True")]
    public bool UseNagleAlgorithm { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    protected override void PostDeserialize() { }
  }
  public sealed partial class SettingsSection : System.Configuration.ConfigurationSection {
    public SettingsSection() { }
    [System.Configuration.ConfigurationPropertyAttribute("httpWebRequest")]
    public System.Net.Configuration.HttpWebRequestElement HttpWebRequest { get { return default(System.Net.Configuration.HttpWebRequestElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("ipv6")]
    public System.Net.Configuration.Ipv6Element Ipv6 { get { return default(System.Net.Configuration.Ipv6Element); } }
    [System.Configuration.ConfigurationPropertyAttribute("performanceCounters")]
    public System.Net.Configuration.PerformanceCountersElement PerformanceCounters { get { return default(System.Net.Configuration.PerformanceCountersElement); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("servicePointManager")]
    public System.Net.Configuration.ServicePointManagerElement ServicePointManager { get { return default(System.Net.Configuration.ServicePointManagerElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("socket")]
    public System.Net.Configuration.SocketElement Socket { get { return default(System.Net.Configuration.SocketElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("webProxyScript")]
    public System.Net.Configuration.WebProxyScriptElement WebProxyScript { get { return default(System.Net.Configuration.WebProxyScriptElement); } }
  }
  public sealed partial class SmtpNetworkElement : System.Configuration.ConfigurationElement {
    public SmtpNetworkElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("defaultCredentials", DefaultValue="False")]
    public bool DefaultCredentials { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("enableSsl", DefaultValue=false)]
    public bool EnableSsl { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("host")]
    public string Host { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("password")]
    public string Password { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("port", DefaultValue="25")]
    public int Port { get { return default(int); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("targetName", DefaultValue=null)]
    public string TargetName { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("userName", DefaultValue=null)]
    public string UserName { get { return default(string); } set { } }
    protected override void PostDeserialize() { }
  }
  public sealed partial class SmtpSection : System.Configuration.ConfigurationSection {
    public SmtpSection() { }
    [System.Configuration.ConfigurationPropertyAttribute("deliveryMethod", DefaultValue="Network")]
    public System.Net.Mail.SmtpDeliveryMethod DeliveryMethod { get { return default(System.Net.Mail.SmtpDeliveryMethod); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("from")]
    public string From { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("network")]
    public System.Net.Configuration.SmtpNetworkElement Network { get { return default(System.Net.Configuration.SmtpNetworkElement); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("specifiedPickupDirectory")]
    public System.Net.Configuration.SmtpSpecifiedPickupDirectoryElement SpecifiedPickupDirectory { get { return default(System.Net.Configuration.SmtpSpecifiedPickupDirectoryElement); } }
  }
  public sealed partial class SmtpSpecifiedPickupDirectoryElement : System.Configuration.ConfigurationElement {
    public SmtpSpecifiedPickupDirectoryElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("pickupDirectoryLocation")]
    public string PickupDirectoryLocation { get { return default(string); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  public sealed partial class SocketElement : System.Configuration.ConfigurationElement {
    public SocketElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("alwaysUseCompletionPortsForAccept", DefaultValue="False")]
    public bool AlwaysUseCompletionPortsForAccept { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("alwaysUseCompletionPortsForConnect", DefaultValue="False")]
    public bool AlwaysUseCompletionPortsForConnect { get { return default(bool); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.MonoTODOAttribute]
    protected override void PostDeserialize() { }
  }
  public sealed partial class WebProxyScriptElement : System.Configuration.ConfigurationElement {
    public WebProxyScriptElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("downloadTimeout", DefaultValue="00:02:00")]
    public System.TimeSpan DownloadTimeout { get { return default(System.TimeSpan); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    protected override void PostDeserialize() { }
  }
  public sealed partial class WebRequestModuleElement : System.Configuration.ConfigurationElement {
    public WebRequestModuleElement() { }
    public WebRequestModuleElement(string prefix, string type) { }
    public WebRequestModuleElement(string prefix, System.Type type) { }
    [System.Configuration.ConfigurationPropertyAttribute("prefix", Options=(System.Configuration.ConfigurationPropertyOptions)(6))]
    public string Prefix { get { return default(string); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.TypeConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("type")]
    public System.Type Type { get { return default(System.Type); } set { } }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.Net.Configuration.WebRequestModuleElement), CollectionType=(System.Configuration.ConfigurationElementCollectionType)(1))]
  public sealed partial class WebRequestModuleElementCollection : System.Configuration.ConfigurationElementCollection {
    public WebRequestModuleElementCollection() { }
    [System.MonoTODOAttribute]
    public System.Net.Configuration.WebRequestModuleElement this[int index] { get { return default(System.Net.Configuration.WebRequestModuleElement); } set { } }
    [System.MonoTODOAttribute]
    public new System.Net.Configuration.WebRequestModuleElement this[string name] { get { return default(System.Net.Configuration.WebRequestModuleElement); } set { } }
    public void Add(System.Net.Configuration.WebRequestModuleElement element) { }
    public void Clear() { }
    protected override System.Configuration.ConfigurationElement CreateNewElement() { return default(System.Configuration.ConfigurationElement); }
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
    public int IndexOf(System.Net.Configuration.WebRequestModuleElement element) { return default(int); }
    public void Remove(System.Net.Configuration.WebRequestModuleElement element) { }
    public void Remove(string name) { }
    public void RemoveAt(int index) { }
  }
  public sealed partial class WebRequestModulesSection : System.Configuration.ConfigurationSection {
    public WebRequestModulesSection() { }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("", Options=(System.Configuration.ConfigurationPropertyOptions)(1))]
    public System.Net.Configuration.WebRequestModuleElementCollection WebRequestModules { get { return default(System.Net.Configuration.WebRequestModuleElementCollection); } }
    [System.MonoTODOAttribute]
    protected override void InitializeDefault() { }
    [System.MonoTODOAttribute]
    protected override void PostDeserialize() { }
  }
}
namespace System.Net.Mail {
  public partial class AlternateView : System.Net.Mail.AttachmentBase {
    public AlternateView(System.IO.Stream contentStream) : base (default(System.IO.Stream)) { }
    public AlternateView(System.IO.Stream contentStream, System.Net.Mime.ContentType contentType) : base (default(System.IO.Stream)) { }
    public AlternateView(System.IO.Stream contentStream, string mediaType) : base (default(System.IO.Stream)) { }
    public AlternateView(string fileName) : base (default(System.IO.Stream)) { }
    public AlternateView(string fileName, System.Net.Mime.ContentType contentType) : base (default(System.IO.Stream)) { }
    public AlternateView(string fileName, string mediaType) : base (default(System.IO.Stream)) { }
    public System.Uri BaseUri { get { return default(System.Uri); } set { } }
    public System.Net.Mail.LinkedResourceCollection LinkedResources { get { return default(System.Net.Mail.LinkedResourceCollection); } }
    public static System.Net.Mail.AlternateView CreateAlternateViewFromString(string content) { return default(System.Net.Mail.AlternateView); }
    public static System.Net.Mail.AlternateView CreateAlternateViewFromString(string content, System.Net.Mime.ContentType contentType) { return default(System.Net.Mail.AlternateView); }
    public static System.Net.Mail.AlternateView CreateAlternateViewFromString(string content, System.Text.Encoding encoding, string mediaType) { return default(System.Net.Mail.AlternateView); }
    protected override void Dispose(bool disposing) { }
  }
  public sealed partial class AlternateViewCollection : System.Collections.ObjectModel.Collection<System.Net.Mail.AlternateView>, System.IDisposable {
    internal AlternateViewCollection() { }
    protected override void ClearItems() { }
    public void Dispose() { }
    protected override void InsertItem(int index, System.Net.Mail.AlternateView item) { }
    protected override void RemoveItem(int index) { }
    protected override void SetItem(int index, System.Net.Mail.AlternateView item) { }
  }
  public partial class Attachment : System.Net.Mail.AttachmentBase {
    public Attachment(System.IO.Stream contentStream, System.Net.Mime.ContentType contentType) : base (default(System.IO.Stream)) { }
    public Attachment(System.IO.Stream contentStream, string name) : base (default(System.IO.Stream)) { }
    public Attachment(System.IO.Stream contentStream, string name, string mediaType) : base (default(System.IO.Stream)) { }
    public Attachment(string fileName) : base (default(System.IO.Stream)) { }
    public Attachment(string fileName, System.Net.Mime.ContentType contentType) : base (default(System.IO.Stream)) { }
    public Attachment(string fileName, string mediaType) : base (default(System.IO.Stream)) { }
    public System.Net.Mime.ContentDisposition ContentDisposition { get { return default(System.Net.Mime.ContentDisposition); } }
    public string Name { get { return default(string); } set { } }
    public System.Text.Encoding NameEncoding { get { return default(System.Text.Encoding); } set { } }
    public static System.Net.Mail.Attachment CreateAttachmentFromString(string content, System.Net.Mime.ContentType contentType) { return default(System.Net.Mail.Attachment); }
    public static System.Net.Mail.Attachment CreateAttachmentFromString(string content, string name) { return default(System.Net.Mail.Attachment); }
    public static System.Net.Mail.Attachment CreateAttachmentFromString(string content, string name, System.Text.Encoding contentEncoding, string mediaType) { return default(System.Net.Mail.Attachment); }
  }
  public abstract partial class AttachmentBase : System.IDisposable {
    protected AttachmentBase(System.IO.Stream contentStream) { }
    protected AttachmentBase(System.IO.Stream contentStream, System.Net.Mime.ContentType contentType) { }
    protected AttachmentBase(System.IO.Stream contentStream, string mediaType) { }
    protected AttachmentBase(string fileName) { }
    protected AttachmentBase(string fileName, System.Net.Mime.ContentType contentType) { }
    protected AttachmentBase(string fileName, string mediaType) { }
    public string ContentId { get { return default(string); } set { } }
    public System.IO.Stream ContentStream { get { return default(System.IO.Stream); } }
    public System.Net.Mime.ContentType ContentType { get { return default(System.Net.Mime.ContentType); } set { } }
    public System.Net.Mime.TransferEncoding TransferEncoding { get { return default(System.Net.Mime.TransferEncoding); } set { } }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
  }
  public sealed partial class AttachmentCollection : System.Collections.ObjectModel.Collection<System.Net.Mail.Attachment>, System.IDisposable {
    internal AttachmentCollection() { }
    protected override void ClearItems() { }
    public void Dispose() { }
    protected override void InsertItem(int index, System.Net.Mail.Attachment item) { }
    protected override void RemoveItem(int index) { }
    protected override void SetItem(int index, System.Net.Mail.Attachment item) { }
  }
  [System.FlagsAttribute]
  public enum DeliveryNotificationOptions {
    Delay = 4,
    Never = 134217728,
    None = 0,
    OnFailure = 2,
    OnSuccess = 1,
  }
  public partial class LinkedResource : System.Net.Mail.AttachmentBase {
    public LinkedResource(System.IO.Stream contentStream) : base (default(System.IO.Stream)) { }
    public LinkedResource(System.IO.Stream contentStream, System.Net.Mime.ContentType contentType) : base (default(System.IO.Stream)) { }
    public LinkedResource(System.IO.Stream contentStream, string mediaType) : base (default(System.IO.Stream)) { }
    public LinkedResource(string fileName) : base (default(System.IO.Stream)) { }
    public LinkedResource(string fileName, System.Net.Mime.ContentType contentType) : base (default(System.IO.Stream)) { }
    public LinkedResource(string fileName, string mediaType) : base (default(System.IO.Stream)) { }
    public System.Uri ContentLink { get { return default(System.Uri); } set { } }
    public static System.Net.Mail.LinkedResource CreateLinkedResourceFromString(string content) { return default(System.Net.Mail.LinkedResource); }
    public static System.Net.Mail.LinkedResource CreateLinkedResourceFromString(string content, System.Net.Mime.ContentType contentType) { return default(System.Net.Mail.LinkedResource); }
    public static System.Net.Mail.LinkedResource CreateLinkedResourceFromString(string content, System.Text.Encoding contentEncoding, string mediaType) { return default(System.Net.Mail.LinkedResource); }
  }
  public sealed partial class LinkedResourceCollection : System.Collections.ObjectModel.Collection<System.Net.Mail.LinkedResource>, System.IDisposable {
    internal LinkedResourceCollection() { }
    protected override void ClearItems() { }
    public void Dispose() { }
    protected override void InsertItem(int index, System.Net.Mail.LinkedResource item) { }
    protected override void RemoveItem(int index) { }
    protected override void SetItem(int index, System.Net.Mail.LinkedResource item) { }
  }
  public partial class MailAddress {
    public MailAddress(string address) { }
    public MailAddress(string address, string displayName) { }
    [System.MonoTODOAttribute("We don't do anything with displayNameEncoding")]
    public MailAddress(string address, string displayName, System.Text.Encoding displayNameEncoding) { }
    public string Address { get { return default(string); } }
    public string DisplayName { get { return default(string); } }
    public string Host { get { return default(string); } }
    public string User { get { return default(string); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
  }
  public partial class MailAddressCollection : System.Collections.ObjectModel.Collection<System.Net.Mail.MailAddress> {
    public MailAddressCollection() { }
    public void Add(string addresses) { }
    protected override void InsertItem(int index, System.Net.Mail.MailAddress item) { }
    protected override void SetItem(int index, System.Net.Mail.MailAddress item) { }
    public override string ToString() { return default(string); }
  }
  public partial class MailMessage : System.IDisposable {
    public MailMessage() { }
    public MailMessage(System.Net.Mail.MailAddress from, System.Net.Mail.MailAddress to) { }
    public MailMessage(string from, string to) { }
    public MailMessage(string from, string to, string subject, string body) { }
    public System.Net.Mail.AlternateViewCollection AlternateViews { get { return default(System.Net.Mail.AlternateViewCollection); } }
    public System.Net.Mail.AttachmentCollection Attachments { get { return default(System.Net.Mail.AttachmentCollection); } }
    public System.Net.Mail.MailAddressCollection Bcc { get { return default(System.Net.Mail.MailAddressCollection); } }
    public string Body { get { return default(string); } set { } }
    public System.Text.Encoding BodyEncoding { get { return default(System.Text.Encoding); } set { } }
    public System.Net.Mail.MailAddressCollection CC { get { return default(System.Net.Mail.MailAddressCollection); } }
    public System.Net.Mail.DeliveryNotificationOptions DeliveryNotificationOptions { get { return default(System.Net.Mail.DeliveryNotificationOptions); } set { } }
    public System.Net.Mail.MailAddress From { get { return default(System.Net.Mail.MailAddress); } set { } }
    public System.Collections.Specialized.NameValueCollection Headers { get { return default(System.Collections.Specialized.NameValueCollection); } }
    public System.Text.Encoding HeadersEncoding { get { return default(System.Text.Encoding); } set { } }
    public bool IsBodyHtml { get { return default(bool); } set { } }
    public System.Net.Mail.MailPriority Priority { get { return default(System.Net.Mail.MailPriority); } set { } }
    [System.ObsoleteAttribute("Use ReplyToList instead")]
    public System.Net.Mail.MailAddress ReplyTo { get { return default(System.Net.Mail.MailAddress); } set { } }
    public System.Net.Mail.MailAddressCollection ReplyToList { get { return default(System.Net.Mail.MailAddressCollection); } }
    public System.Net.Mail.MailAddress Sender { get { return default(System.Net.Mail.MailAddress); } set { } }
    public string Subject { get { return default(string); } set { } }
    public System.Text.Encoding SubjectEncoding { get { return default(System.Text.Encoding); } set { } }
    public System.Net.Mail.MailAddressCollection To { get { return default(System.Net.Mail.MailAddressCollection); } }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
  }
  public enum MailPriority {
    High = 2,
    Low = 1,
    Normal = 0,
  }
  public delegate void SendCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
  public enum SmtpAccess {
    Connect = 1,
    ConnectToUnrestrictedPort = 2,
    None = 0,
  }
  public partial class SmtpClient : System.IDisposable {
    public SmtpClient() { }
    public SmtpClient(string host) { }
    public SmtpClient(string host, int port) { }
    [System.MonoTODOAttribute("Client certificates not used")]
    public System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates { get { return default(System.Security.Cryptography.X509Certificates.X509CertificateCollection); } }
    public System.Net.ICredentialsByHost Credentials { get { return default(System.Net.ICredentialsByHost); } set { } }
    public System.Net.Mail.SmtpDeliveryMethod DeliveryMethod { get { return default(System.Net.Mail.SmtpDeliveryMethod); } set { } }
    public bool EnableSsl { get { return default(bool); } set { } }
    public string Host { get { return default(string); } set { } }
    public string PickupDirectoryLocation { get { return default(string); } set { } }
    public int Port { get { return default(int); } set { } }
    [System.MonoTODOAttribute]
    public System.Net.ServicePoint ServicePoint { get { return default(System.Net.ServicePoint); } }
    public string TargetName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public int Timeout { get { return default(int); } set { } }
    public bool UseDefaultCredentials { get { return default(bool); } [System.MonoNotSupportedAttribute("no DefaultCredential support in Mono")]set { } }
    public event System.Net.Mail.SendCompletedEventHandler SendCompleted { add { } remove { } }
    public void Dispose() { }
    [System.MonoTODOAttribute("Does nothing at the moment.")]
    protected virtual void Dispose(bool disposing) { }
    protected void OnSendCompleted(System.ComponentModel.AsyncCompletedEventArgs e) { }
    public void Send(System.Net.Mail.MailMessage message) { }
    public void Send(string from, string to, string subject, string body) { }
    public void SendAsync(System.Net.Mail.MailMessage message, object userToken) { }
    public void SendAsync(string from, string to, string subject, string body, object userToken) { }
    public void SendAsyncCancel() { }
  }
  public enum SmtpDeliveryMethod {
    Network = 0,
    PickupDirectoryFromIis = 2,
    SpecifiedPickupDirectory = 1,
  }
  public partial class SmtpException : System.Exception, System.Runtime.Serialization.ISerializable {
    public SmtpException() { }
    public SmtpException(System.Net.Mail.SmtpStatusCode statusCode) { }
    public SmtpException(System.Net.Mail.SmtpStatusCode statusCode, string message) { }
    protected SmtpException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public SmtpException(string message) { }
    public SmtpException(string message, System.Exception innerException) { }
    public System.Net.Mail.SmtpStatusCode StatusCode { get { return default(System.Net.Mail.SmtpStatusCode); } set { } }
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial class SmtpFailedRecipientException : System.Net.Mail.SmtpException, System.Runtime.Serialization.ISerializable {
    public SmtpFailedRecipientException() { }
    public SmtpFailedRecipientException(System.Net.Mail.SmtpStatusCode statusCode, string failedRecipient) { }
    public SmtpFailedRecipientException(System.Net.Mail.SmtpStatusCode statusCode, string failedRecipient, string serverResponse) { }
    protected SmtpFailedRecipientException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    public SmtpFailedRecipientException(string message) { }
    public SmtpFailedRecipientException(string message, System.Exception innerException) { }
    public SmtpFailedRecipientException(string message, string failedRecipient, System.Exception innerException) { }
    public string FailedRecipient { get { return default(string); } }
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
  }
  public partial class SmtpFailedRecipientsException : System.Net.Mail.SmtpFailedRecipientException, System.Runtime.Serialization.ISerializable {
    public SmtpFailedRecipientsException() { }
    protected SmtpFailedRecipientsException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public SmtpFailedRecipientsException(string message) { }
    public SmtpFailedRecipientsException(string message, System.Exception innerException) { }
    public SmtpFailedRecipientsException(string message, System.Net.Mail.SmtpFailedRecipientException[] innerExceptions) { }
    public System.Net.Mail.SmtpFailedRecipientException[] InnerExceptions { get { return default(System.Net.Mail.SmtpFailedRecipientException[]); } }
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public sealed partial class SmtpPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission {
    public SmtpPermission(bool unrestricted) { }
    public SmtpPermission(System.Net.Mail.SmtpAccess access) { }
    public SmtpPermission(System.Security.Permissions.PermissionState state) { }
    public System.Net.Mail.SmtpAccess Access { get { return default(System.Net.Mail.SmtpAccess); } }
    public void AddPermission(System.Net.Mail.SmtpAccess access) { }
    public override System.Security.IPermission Copy() { return default(System.Security.IPermission); }
    public override void FromXml(System.Security.SecurityElement securityElement) { }
    public override System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
    public override bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
    public bool IsUnrestricted() { return default(bool); }
    public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
    public override System.Security.IPermission Union(System.Security.IPermission target) { return default(System.Security.IPermission); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
  public sealed partial class SmtpPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute {
    public SmtpPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
    public string Access { get { return default(string); } set { } }
    public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
  }
  public enum SmtpStatusCode {
    BadCommandSequence = 503,
    CannotVerifyUserWillAttemptDelivery = 252,
    ClientNotPermitted = 454,
    CommandNotImplemented = 502,
    CommandParameterNotImplemented = 504,
    CommandUnrecognized = 500,
    ExceededStorageAllocation = 552,
    GeneralFailure = -1,
    HelpMessage = 214,
    InsufficientStorage = 452,
    LocalErrorInProcessing = 451,
    MailboxBusy = 450,
    MailboxNameNotAllowed = 553,
    MailboxUnavailable = 550,
    MustIssueStartTlsFirst = 530,
    Ok = 250,
    ServiceClosingTransmissionChannel = 221,
    ServiceNotAvailable = 421,
    ServiceReady = 220,
    StartMailInput = 354,
    SyntaxError = 501,
    SystemStatus = 211,
    TransactionFailed = 554,
    UserNotLocalTryAlternatePath = 551,
    UserNotLocalWillForward = 251,
  }
}
namespace System.Net.Mime {
  public partial class ContentDisposition {
    public ContentDisposition() { }
    public ContentDisposition(string disposition) { }
    public System.DateTime CreationDate { get { return default(System.DateTime); } set { } }
    public string DispositionType { get { return default(string); } set { } }
    public string FileName { get { return default(string); } set { } }
    public bool Inline { get { return default(bool); } set { } }
    public System.DateTime ModificationDate { get { return default(System.DateTime); } set { } }
    public System.Collections.Specialized.StringDictionary Parameters { get { return default(System.Collections.Specialized.StringDictionary); } }
    public System.DateTime ReadDate { get { return default(System.DateTime); } set { } }
    public long Size { get { return default(long); } set { } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
  }
  public partial class ContentType {
    public ContentType() { }
    public ContentType(string contentType) { }
    public string Boundary { get { return default(string); } set { } }
    public string CharSet { get { return default(string); } set { } }
    public string MediaType { get { return default(string); } set { } }
    public string Name { get { return default(string); } set { } }
    public System.Collections.Specialized.StringDictionary Parameters { get { return default(System.Collections.Specialized.StringDictionary); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
  }
  public static partial class DispositionTypeNames {
    public const string Attachment = "attachment";
    public const string Inline = "inline";
  }
  public static partial class MediaTypeNames {
    public static partial class Application {
      public const string Octet = "application/octet-stream";
      public const string Pdf = "application/pdf";
      public const string Rtf = "application/rtf";
      public const string Soap = "application/soap+xml";
      public const string Zip = "application/zip";
    }
    public static partial class Image {
      public const string Gif = "image/gif";
      public const string Jpeg = "image/jpeg";
      public const string Tiff = "image/tiff";
    }
    public static partial class Text {
      public const string Html = "text/html";
      public const string Plain = "text/plain";
      public const string RichText = "text/richtext";
      public const string Xml = "text/xml";
    }
  }
  public enum TransferEncoding {
    Base64 = 1,
    QuotedPrintable = 0,
    SevenBit = 2,
    Unknown = -1,
  }
}
namespace System.Net.NetworkInformation {
  public enum DuplicateAddressDetectionState {
    Deprecated = 3,
    Duplicate = 2,
    Invalid = 0,
    Preferred = 4,
    Tentative = 1,
  }
  public abstract partial class GatewayIPAddressInformation {
    protected GatewayIPAddressInformation() { }
    public abstract System.Net.IPAddress Address { get; }
  }
  public partial class GatewayIPAddressInformationCollection : System.Collections.Generic.ICollection<System.Net.NetworkInformation.GatewayIPAddressInformation>, System.Collections.Generic.IEnumerable<System.Net.NetworkInformation.GatewayIPAddressInformation>, System.Collections.IEnumerable {
    protected GatewayIPAddressInformationCollection() { }
    public virtual int Count { get { return default(int); } }
    public virtual bool IsReadOnly { get { return default(bool); } }
    public virtual System.Net.NetworkInformation.GatewayIPAddressInformation this[int index] { get { return default(System.Net.NetworkInformation.GatewayIPAddressInformation); } }
    public virtual void Add(System.Net.NetworkInformation.GatewayIPAddressInformation address) { }
    public virtual void Clear() { }
    public virtual bool Contains(System.Net.NetworkInformation.GatewayIPAddressInformation address) { return default(bool); }
    public virtual void CopyTo(System.Net.NetworkInformation.GatewayIPAddressInformation[] array, int offset) { }
    public virtual System.Collections.Generic.IEnumerator<System.Net.NetworkInformation.GatewayIPAddressInformation> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Net.NetworkInformation.GatewayIPAddressInformation>); }
    public virtual bool Remove(System.Net.NetworkInformation.GatewayIPAddressInformation address) { return default(bool); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public abstract partial class IcmpV4Statistics {
    protected IcmpV4Statistics() { }
    public abstract long AddressMaskRepliesReceived { get; }
    public abstract long AddressMaskRepliesSent { get; }
    public abstract long AddressMaskRequestsReceived { get; }
    public abstract long AddressMaskRequestsSent { get; }
    public abstract long DestinationUnreachableMessagesReceived { get; }
    public abstract long DestinationUnreachableMessagesSent { get; }
    public abstract long EchoRepliesReceived { get; }
    public abstract long EchoRepliesSent { get; }
    public abstract long EchoRequestsReceived { get; }
    public abstract long EchoRequestsSent { get; }
    public abstract long ErrorsReceived { get; }
    public abstract long ErrorsSent { get; }
    public abstract long MessagesReceived { get; }
    public abstract long MessagesSent { get; }
    public abstract long ParameterProblemsReceived { get; }
    public abstract long ParameterProblemsSent { get; }
    public abstract long RedirectsReceived { get; }
    public abstract long RedirectsSent { get; }
    public abstract long SourceQuenchesReceived { get; }
    public abstract long SourceQuenchesSent { get; }
    public abstract long TimeExceededMessagesReceived { get; }
    public abstract long TimeExceededMessagesSent { get; }
    public abstract long TimestampRepliesReceived { get; }
    public abstract long TimestampRepliesSent { get; }
    public abstract long TimestampRequestsReceived { get; }
    public abstract long TimestampRequestsSent { get; }
  }
  public abstract partial class IcmpV6Statistics {
    protected IcmpV6Statistics() { }
    public abstract long DestinationUnreachableMessagesReceived { get; }
    public abstract long DestinationUnreachableMessagesSent { get; }
    public abstract long EchoRepliesReceived { get; }
    public abstract long EchoRepliesSent { get; }
    public abstract long EchoRequestsReceived { get; }
    public abstract long EchoRequestsSent { get; }
    public abstract long ErrorsReceived { get; }
    public abstract long ErrorsSent { get; }
    public abstract long MembershipQueriesReceived { get; }
    public abstract long MembershipQueriesSent { get; }
    public abstract long MembershipReductionsReceived { get; }
    public abstract long MembershipReductionsSent { get; }
    public abstract long MembershipReportsReceived { get; }
    public abstract long MembershipReportsSent { get; }
    public abstract long MessagesReceived { get; }
    public abstract long MessagesSent { get; }
    public abstract long NeighborAdvertisementsReceived { get; }
    public abstract long NeighborAdvertisementsSent { get; }
    public abstract long NeighborSolicitsReceived { get; }
    public abstract long NeighborSolicitsSent { get; }
    public abstract long PacketTooBigMessagesReceived { get; }
    public abstract long PacketTooBigMessagesSent { get; }
    public abstract long ParameterProblemsReceived { get; }
    public abstract long ParameterProblemsSent { get; }
    public abstract long RedirectsReceived { get; }
    public abstract long RedirectsSent { get; }
    public abstract long RouterAdvertisementsReceived { get; }
    public abstract long RouterAdvertisementsSent { get; }
    public abstract long RouterSolicitsReceived { get; }
    public abstract long RouterSolicitsSent { get; }
    public abstract long TimeExceededMessagesReceived { get; }
    public abstract long TimeExceededMessagesSent { get; }
  }
  public partial class IPAddressCollection : System.Collections.Generic.ICollection<System.Net.IPAddress>, System.Collections.Generic.IEnumerable<System.Net.IPAddress>, System.Collections.IEnumerable {
    protected internal IPAddressCollection() { }
    public virtual int Count { get { return default(int); } }
    public virtual bool IsReadOnly { get { return default(bool); } }
    public virtual System.Net.IPAddress this[int index] { get { return default(System.Net.IPAddress); } }
    public virtual void Add(System.Net.IPAddress address) { }
    public virtual void Clear() { }
    public virtual bool Contains(System.Net.IPAddress address) { return default(bool); }
    public virtual void CopyTo(System.Net.IPAddress[] array, int offset) { }
    public virtual System.Collections.Generic.IEnumerator<System.Net.IPAddress> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Net.IPAddress>); }
    public virtual bool Remove(System.Net.IPAddress address) { return default(bool); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public abstract partial class IPAddressInformation {
    protected IPAddressInformation() { }
    public abstract System.Net.IPAddress Address { get; }
    public abstract bool IsDnsEligible { get; }
    public abstract bool IsTransient { get; }
  }
  public partial class IPAddressInformationCollection : System.Collections.Generic.ICollection<System.Net.NetworkInformation.IPAddressInformation>, System.Collections.Generic.IEnumerable<System.Net.NetworkInformation.IPAddressInformation>, System.Collections.IEnumerable {
    internal IPAddressInformationCollection() { }
    public virtual int Count { get { return default(int); } }
    public virtual bool IsReadOnly { get { return default(bool); } }
    public virtual System.Net.NetworkInformation.IPAddressInformation this[int index] { get { return default(System.Net.NetworkInformation.IPAddressInformation); } }
    public virtual void Add(System.Net.NetworkInformation.IPAddressInformation address) { }
    public virtual void Clear() { }
    public virtual bool Contains(System.Net.NetworkInformation.IPAddressInformation address) { return default(bool); }
    public virtual void CopyTo(System.Net.NetworkInformation.IPAddressInformation[] array, int offset) { }
    public virtual System.Collections.Generic.IEnumerator<System.Net.NetworkInformation.IPAddressInformation> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Net.NetworkInformation.IPAddressInformation>); }
    public virtual bool Remove(System.Net.NetworkInformation.IPAddressInformation address) { return default(bool); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public abstract partial class IPGlobalProperties {
    protected IPGlobalProperties() { }
    public abstract string DhcpScopeName { get; }
    public abstract string DomainName { get; }
    public abstract string HostName { get; }
    public abstract bool IsWinsProxy { get; }
    public abstract System.Net.NetworkInformation.NetBiosNodeType NodeType { get; }
    public abstract System.Net.NetworkInformation.TcpConnectionInformation[] GetActiveTcpConnections();
    public abstract System.Net.IPEndPoint[] GetActiveTcpListeners();
    public abstract System.Net.IPEndPoint[] GetActiveUdpListeners();
    public abstract System.Net.NetworkInformation.IcmpV4Statistics GetIcmpV4Statistics();
    public abstract System.Net.NetworkInformation.IcmpV6Statistics GetIcmpV6Statistics();
    public static System.Net.NetworkInformation.IPGlobalProperties GetIPGlobalProperties() { return default(System.Net.NetworkInformation.IPGlobalProperties); }
    public abstract System.Net.NetworkInformation.IPGlobalStatistics GetIPv4GlobalStatistics();
    public abstract System.Net.NetworkInformation.IPGlobalStatistics GetIPv6GlobalStatistics();
    public abstract System.Net.NetworkInformation.TcpStatistics GetTcpIPv4Statistics();
    public abstract System.Net.NetworkInformation.TcpStatistics GetTcpIPv6Statistics();
    public abstract System.Net.NetworkInformation.UdpStatistics GetUdpIPv4Statistics();
    public abstract System.Net.NetworkInformation.UdpStatistics GetUdpIPv6Statistics();
  }
  public abstract partial class IPGlobalStatistics {
    protected IPGlobalStatistics() { }
    public abstract int DefaultTtl { get; }
    public abstract bool ForwardingEnabled { get; }
    public abstract int NumberOfInterfaces { get; }
    public abstract int NumberOfIPAddresses { get; }
    public abstract int NumberOfRoutes { get; }
    public abstract long OutputPacketRequests { get; }
    public abstract long OutputPacketRoutingDiscards { get; }
    public abstract long OutputPacketsDiscarded { get; }
    public abstract long OutputPacketsWithNoRoute { get; }
    public abstract long PacketFragmentFailures { get; }
    public abstract long PacketReassembliesRequired { get; }
    public abstract long PacketReassemblyFailures { get; }
    public abstract long PacketReassemblyTimeout { get; }
    public abstract long PacketsFragmented { get; }
    public abstract long PacketsReassembled { get; }
    public abstract long ReceivedPackets { get; }
    public abstract long ReceivedPacketsDelivered { get; }
    public abstract long ReceivedPacketsDiscarded { get; }
    public abstract long ReceivedPacketsForwarded { get; }
    public abstract long ReceivedPacketsWithAddressErrors { get; }
    public abstract long ReceivedPacketsWithHeadersErrors { get; }
    public abstract long ReceivedPacketsWithUnknownProtocol { get; }
  }
  public abstract partial class IPInterfaceProperties {
    protected IPInterfaceProperties() { }
    public abstract System.Net.NetworkInformation.IPAddressInformationCollection AnycastAddresses { get; }
    public abstract System.Net.NetworkInformation.IPAddressCollection DhcpServerAddresses { get; }
    public abstract System.Net.NetworkInformation.IPAddressCollection DnsAddresses { get; }
    public abstract string DnsSuffix { get; }
    public abstract System.Net.NetworkInformation.GatewayIPAddressInformationCollection GatewayAddresses { get; }
    public abstract bool IsDnsEnabled { get; }
    public abstract bool IsDynamicDnsEnabled { get; }
    public abstract System.Net.NetworkInformation.MulticastIPAddressInformationCollection MulticastAddresses { get; }
    public abstract System.Net.NetworkInformation.UnicastIPAddressInformationCollection UnicastAddresses { get; }
    public abstract System.Net.NetworkInformation.IPAddressCollection WinsServersAddresses { get; }
    public abstract System.Net.NetworkInformation.IPv4InterfaceProperties GetIPv4Properties();
    public abstract System.Net.NetworkInformation.IPv6InterfaceProperties GetIPv6Properties();
  }
  public enum IPStatus {
    BadDestination = 11018,
    BadHeader = 11042,
    BadOption = 11007,
    BadRoute = 11012,
    DestinationHostUnreachable = 11003,
    DestinationNetworkUnreachable = 11002,
    DestinationPortUnreachable = 11005,
    DestinationProhibited = 11004,
    DestinationProtocolUnreachable = 11004,
    DestinationScopeMismatch = 11045,
    DestinationUnreachable = 11040,
    HardwareError = 11008,
    IcmpError = 11044,
    NoResources = 11006,
    PacketTooBig = 11009,
    ParameterProblem = 11015,
    SourceQuench = 11016,
    Success = 0,
    TimedOut = 11010,
    TimeExceeded = 11041,
    TtlExpired = 11013,
    TtlReassemblyTimeExceeded = 11014,
    Unknown = -1,
    UnrecognizedNextHeader = 11043,
  }
  public abstract partial class IPv4InterfaceProperties {
    protected IPv4InterfaceProperties() { }
    public abstract int Index { get; }
    public abstract bool IsAutomaticPrivateAddressingActive { get; }
    public abstract bool IsAutomaticPrivateAddressingEnabled { get; }
    public abstract bool IsDhcpEnabled { get; }
    public abstract bool IsForwardingEnabled { get; }
    public abstract int Mtu { get; }
    public abstract bool UsesWins { get; }
  }
  public abstract partial class IPv4InterfaceStatistics {
    protected IPv4InterfaceStatistics() { }
    public abstract long BytesReceived { get; }
    public abstract long BytesSent { get; }
    public abstract long IncomingPacketsDiscarded { get; }
    public abstract long IncomingPacketsWithErrors { get; }
    public abstract long IncomingUnknownProtocolPackets { get; }
    public abstract long NonUnicastPacketsReceived { get; }
    public abstract long NonUnicastPacketsSent { get; }
    public abstract long OutgoingPacketsDiscarded { get; }
    public abstract long OutgoingPacketsWithErrors { get; }
    [System.MonoTODOAttribute("Not implemented for Linux")]
    public abstract long OutputQueueLength { get; }
    public abstract long UnicastPacketsReceived { get; }
    public abstract long UnicastPacketsSent { get; }
  }
  public abstract partial class IPv6InterfaceProperties {
    protected IPv6InterfaceProperties() { }
    public abstract int Index { get; }
    public abstract int Mtu { get; }
  }
  public abstract partial class MulticastIPAddressInformation : System.Net.NetworkInformation.IPAddressInformation {
    protected MulticastIPAddressInformation() { }
    public abstract long AddressPreferredLifetime { get; }
    public abstract long AddressValidLifetime { get; }
    public abstract long DhcpLeaseLifetime { get; }
    public abstract System.Net.NetworkInformation.DuplicateAddressDetectionState DuplicateAddressDetectionState { get; }
    public abstract System.Net.NetworkInformation.PrefixOrigin PrefixOrigin { get; }
    public abstract System.Net.NetworkInformation.SuffixOrigin SuffixOrigin { get; }
  }
  public partial class MulticastIPAddressInformationCollection : System.Collections.Generic.ICollection<System.Net.NetworkInformation.MulticastIPAddressInformation>, System.Collections.Generic.IEnumerable<System.Net.NetworkInformation.MulticastIPAddressInformation>, System.Collections.IEnumerable {
    protected internal MulticastIPAddressInformationCollection() { }
    public virtual int Count { get { return default(int); } }
    public virtual bool IsReadOnly { get { return default(bool); } }
    public virtual System.Net.NetworkInformation.MulticastIPAddressInformation this[int index] { get { return default(System.Net.NetworkInformation.MulticastIPAddressInformation); } }
    public virtual void Add(System.Net.NetworkInformation.MulticastIPAddressInformation address) { }
    public virtual void Clear() { }
    public virtual bool Contains(System.Net.NetworkInformation.MulticastIPAddressInformation address) { return default(bool); }
    public virtual void CopyTo(System.Net.NetworkInformation.MulticastIPAddressInformation[] array, int offset) { }
    public virtual System.Collections.Generic.IEnumerator<System.Net.NetworkInformation.MulticastIPAddressInformation> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Net.NetworkInformation.MulticastIPAddressInformation>); }
    public virtual bool Remove(System.Net.NetworkInformation.MulticastIPAddressInformation address) { return default(bool); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public enum NetBiosNodeType {
    Broadcast = 1,
    Hybrid = 8,
    Mixed = 4,
    Peer2Peer = 2,
    Unknown = 0,
  }
  public delegate void NetworkAddressChangedEventHandler(object sender, System.EventArgs e);
  public delegate void NetworkAvailabilityChangedEventHandler(object sender, System.Net.NetworkInformation.NetworkAvailabilityEventArgs e);
  public partial class NetworkAvailabilityEventArgs : System.EventArgs {
    internal NetworkAvailabilityEventArgs() { }
    public bool IsAvailable { get { return default(bool); } }
  }
  public sealed partial class NetworkChange {
    public NetworkChange() { }
    public static event System.Net.NetworkInformation.NetworkAddressChangedEventHandler NetworkAddressChanged { add { } remove { } }
    public static event System.Net.NetworkInformation.NetworkAvailabilityChangedEventHandler NetworkAvailabilityChanged { add { } remove { } }
  }
  [System.FlagsAttribute]
  public enum NetworkInformationAccess {
    None = 0,
    Ping = 4,
    Read = 1,
  }
  public partial class NetworkInformationException : System.ComponentModel.Win32Exception {
    public NetworkInformationException() { }
    public NetworkInformationException(int errorCode) { }
    protected NetworkInformationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public override int ErrorCode { get { return default(int); } }
  }
  public sealed partial class NetworkInformationPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission {
    [System.MonoTODOAttribute]
    public NetworkInformationPermission(System.Net.NetworkInformation.NetworkInformationAccess access) { }
    [System.MonoTODOAttribute]
    public NetworkInformationPermission(System.Security.Permissions.PermissionState state) { }
    [System.MonoTODOAttribute]
    public System.Net.NetworkInformation.NetworkInformationAccess Access { get { return default(System.Net.NetworkInformation.NetworkInformationAccess); } }
    [System.MonoTODOAttribute]
    public void AddPermission(System.Net.NetworkInformation.NetworkInformationAccess access) { }
    [System.MonoTODOAttribute]
    public override System.Security.IPermission Copy() { return default(System.Security.IPermission); }
    [System.MonoTODOAttribute]
    public override void FromXml(System.Security.SecurityElement securityElement) { }
    [System.MonoTODOAttribute]
    public override System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
    [System.MonoTODOAttribute]
    public override bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
    [System.MonoTODOAttribute]
    public bool IsUnrestricted() { return default(bool); }
    [System.MonoTODOAttribute]
    public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
    [System.MonoTODOAttribute]
    public override System.Security.IPermission Union(System.Security.IPermission target) { return default(System.Security.IPermission); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
  public sealed partial class NetworkInformationPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute {
    public NetworkInformationPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
    public string Access { get { return default(string); } set { } }
    [System.MonoTODOAttribute("verify implementation")]
    public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
  }
  public abstract partial class NetworkInterface {
    protected NetworkInterface() { }
    public abstract string Description { get; }
    public abstract string Id { get; }
    public abstract bool IsReceiveOnly { get; }
    [System.MonoTODOAttribute("Only works on Linux. Returns 0 on other systems.")]
    public static int LoopbackInterfaceIndex { get { return default(int); } }
    public abstract string Name { get; }
    public abstract System.Net.NetworkInformation.NetworkInterfaceType NetworkInterfaceType { get; }
    public abstract System.Net.NetworkInformation.OperationalStatus OperationalStatus { get; }
    public abstract long Speed { get; }
    public abstract bool SupportsMulticast { get; }
    public static System.Net.NetworkInformation.NetworkInterface[] GetAllNetworkInterfaces() { return default(System.Net.NetworkInformation.NetworkInterface[]); }
    public abstract System.Net.NetworkInformation.IPInterfaceProperties GetIPProperties();
    public abstract System.Net.NetworkInformation.IPv4InterfaceStatistics GetIPv4Statistics();
    [System.MonoTODOAttribute("Always returns true")]
    public static bool GetIsNetworkAvailable() { return default(bool); }
    public abstract System.Net.NetworkInformation.PhysicalAddress GetPhysicalAddress();
    public abstract bool Supports(System.Net.NetworkInformation.NetworkInterfaceComponent networkInterfaceComponent);
  }
  public enum NetworkInterfaceComponent {
    IPv4 = 0,
    IPv6 = 1,
  }
  public enum NetworkInterfaceType {
    AsymmetricDsl = 94,
    Atm = 37,
    BasicIsdn = 20,
    Ethernet = 6,
    Ethernet3Megabit = 26,
    FastEthernetFx = 69,
    FastEthernetT = 62,
    Fddi = 15,
    GenericModem = 48,
    GigabitEthernet = 117,
    HighPerformanceSerialBus = 144,
    IPOverAtm = 114,
    Isdn = 63,
    Loopback = 24,
    MultiRateSymmetricDsl = 143,
    Ppp = 23,
    PrimaryIsdn = 21,
    RateAdaptDsl = 95,
    Slip = 28,
    SymmetricDsl = 96,
    TokenRing = 9,
    Tunnel = 131,
    Unknown = 1,
    VeryHighSpeedDsl = 97,
    Wireless80211 = 71,
  }
  public enum OperationalStatus {
    Dormant = 5,
    Down = 2,
    LowerLayerDown = 7,
    NotPresent = 6,
    Testing = 3,
    Unknown = 4,
    Up = 1,
  }
  public partial class PhysicalAddress {
    public static readonly System.Net.NetworkInformation.PhysicalAddress None;
    public PhysicalAddress(System.Byte[] address) { }
    public override bool Equals(object comparand) { return default(bool); }
    public System.Byte[] GetAddressBytes() { return default(System.Byte[]); }
    public override int GetHashCode() { return default(int); }
    public static System.Net.NetworkInformation.PhysicalAddress Parse(string address) { return default(System.Net.NetworkInformation.PhysicalAddress); }
    public override string ToString() { return default(string); }
  }
  [System.MonoTODOAttribute("IPv6 support is missing")]
  public partial class Ping : System.ComponentModel.Component, System.IDisposable {
    public Ping() { }
    public event System.Net.NetworkInformation.PingCompletedEventHandler PingCompleted { add { } remove { } }
    protected void OnPingCompleted(System.Net.NetworkInformation.PingCompletedEventArgs e) { }
    public System.Net.NetworkInformation.PingReply Send(System.Net.IPAddress address) { return default(System.Net.NetworkInformation.PingReply); }
    public System.Net.NetworkInformation.PingReply Send(System.Net.IPAddress address, int timeout) { return default(System.Net.NetworkInformation.PingReply); }
    public System.Net.NetworkInformation.PingReply Send(System.Net.IPAddress address, int timeout, System.Byte[] buffer) { return default(System.Net.NetworkInformation.PingReply); }
    public System.Net.NetworkInformation.PingReply Send(System.Net.IPAddress address, int timeout, System.Byte[] buffer, System.Net.NetworkInformation.PingOptions options) { return default(System.Net.NetworkInformation.PingReply); }
    public System.Net.NetworkInformation.PingReply Send(string hostNameOrAddress) { return default(System.Net.NetworkInformation.PingReply); }
    public System.Net.NetworkInformation.PingReply Send(string hostNameOrAddress, int timeout) { return default(System.Net.NetworkInformation.PingReply); }
    public System.Net.NetworkInformation.PingReply Send(string hostNameOrAddress, int timeout, System.Byte[] buffer) { return default(System.Net.NetworkInformation.PingReply); }
    public System.Net.NetworkInformation.PingReply Send(string hostNameOrAddress, int timeout, System.Byte[] buffer, System.Net.NetworkInformation.PingOptions options) { return default(System.Net.NetworkInformation.PingReply); }
    public void SendAsync(System.Net.IPAddress address, int timeout, System.Byte[] buffer, System.Net.NetworkInformation.PingOptions options, object userToken) { }
    public void SendAsync(System.Net.IPAddress address, int timeout, System.Byte[] buffer, object userToken) { }
    public void SendAsync(System.Net.IPAddress address, int timeout, object userToken) { }
    public void SendAsync(System.Net.IPAddress address, object userToken) { }
    public void SendAsync(string hostNameOrAddress, int timeout, System.Byte[] buffer, System.Net.NetworkInformation.PingOptions options, object userToken) { }
    public void SendAsync(string hostNameOrAddress, int timeout, System.Byte[] buffer, object userToken) { }
    public void SendAsync(string hostNameOrAddress, int timeout, object userToken) { }
    public void SendAsync(string hostNameOrAddress, object userToken) { }
    public void SendAsyncCancel() { }
    void System.IDisposable.Dispose() { }
  }
  public partial class PingCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    internal PingCompletedEventArgs() : base (default(System.Exception), default(bool), default(object)) { }
    public System.Net.NetworkInformation.PingReply Reply { get { return default(System.Net.NetworkInformation.PingReply); } }
  }
  public delegate void PingCompletedEventHandler(object sender, System.Net.NetworkInformation.PingCompletedEventArgs e);
  public partial class PingException : System.InvalidOperationException {
    protected PingException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    public PingException(string message) { }
    public PingException(string message, System.Exception innerException) { }
  }
  public partial class PingOptions {
    public PingOptions() { }
    public PingOptions(int ttl, bool dontFragment) { }
    public bool DontFragment { get { return default(bool); } set { } }
    public int Ttl { get { return default(int); } set { } }
  }
  public partial class PingReply {
    internal PingReply() { }
    public System.Net.IPAddress Address { get { return default(System.Net.IPAddress); } }
    public System.Byte[] Buffer { get { return default(System.Byte[]); } }
    public System.Net.NetworkInformation.PingOptions Options { get { return default(System.Net.NetworkInformation.PingOptions); } }
    public long RoundtripTime { get { return default(long); } }
    public System.Net.NetworkInformation.IPStatus Status { get { return default(System.Net.NetworkInformation.IPStatus); } }
  }
  public enum PrefixOrigin {
    Dhcp = 3,
    Manual = 1,
    Other = 0,
    RouterAdvertisement = 4,
    WellKnown = 2,
  }
  public enum SuffixOrigin {
    LinkLayerAddress = 4,
    Manual = 1,
    OriginDhcp = 3,
    Other = 0,
    Random = 5,
    WellKnown = 2,
  }
  public abstract partial class TcpConnectionInformation {
    protected TcpConnectionInformation() { }
    public abstract System.Net.IPEndPoint LocalEndPoint { get; }
    public abstract System.Net.IPEndPoint RemoteEndPoint { get; }
    public abstract System.Net.NetworkInformation.TcpState State { get; }
  }
  public enum TcpState {
    Closed = 1,
    CloseWait = 8,
    Closing = 9,
    DeleteTcb = 12,
    Established = 5,
    FinWait1 = 6,
    FinWait2 = 7,
    LastAck = 10,
    Listen = 2,
    SynReceived = 4,
    SynSent = 3,
    TimeWait = 11,
    Unknown = 0,
  }
  public abstract partial class TcpStatistics {
    protected TcpStatistics() { }
    public abstract long ConnectionsAccepted { get; }
    public abstract long ConnectionsInitiated { get; }
    public abstract long CumulativeConnections { get; }
    public abstract long CurrentConnections { get; }
    public abstract long ErrorsReceived { get; }
    public abstract long FailedConnectionAttempts { get; }
    public abstract long MaximumConnections { get; }
    public abstract long MaximumTransmissionTimeout { get; }
    public abstract long MinimumTransmissionTimeout { get; }
    public abstract long ResetConnections { get; }
    public abstract long ResetsSent { get; }
    public abstract long SegmentsReceived { get; }
    public abstract long SegmentsResent { get; }
    public abstract long SegmentsSent { get; }
  }
  public abstract partial class UdpStatistics {
    protected UdpStatistics() { }
    public abstract long DatagramsReceived { get; }
    public abstract long DatagramsSent { get; }
    public abstract long IncomingDatagramsDiscarded { get; }
    public abstract long IncomingDatagramsWithErrors { get; }
    public abstract int UdpListeners { get; }
  }
  public abstract partial class UnicastIPAddressInformation : System.Net.NetworkInformation.IPAddressInformation {
    protected UnicastIPAddressInformation() { }
    public abstract long AddressPreferredLifetime { get; }
    public abstract long AddressValidLifetime { get; }
    public abstract long DhcpLeaseLifetime { get; }
    public abstract System.Net.NetworkInformation.DuplicateAddressDetectionState DuplicateAddressDetectionState { get; }
    public abstract System.Net.IPAddress IPv4Mask { get; }
    public abstract System.Net.NetworkInformation.PrefixOrigin PrefixOrigin { get; }
    public abstract System.Net.NetworkInformation.SuffixOrigin SuffixOrigin { get; }
  }
  public partial class UnicastIPAddressInformationCollection : System.Collections.Generic.ICollection<System.Net.NetworkInformation.UnicastIPAddressInformation>, System.Collections.Generic.IEnumerable<System.Net.NetworkInformation.UnicastIPAddressInformation>, System.Collections.IEnumerable {
    protected internal UnicastIPAddressInformationCollection() { }
    public virtual int Count { get { return default(int); } }
    public virtual bool IsReadOnly { get { return default(bool); } }
    public virtual System.Net.NetworkInformation.UnicastIPAddressInformation this[int index] { get { return default(System.Net.NetworkInformation.UnicastIPAddressInformation); } }
    public virtual void Add(System.Net.NetworkInformation.UnicastIPAddressInformation address) { }
    public virtual void Clear() { }
    public virtual bool Contains(System.Net.NetworkInformation.UnicastIPAddressInformation address) { return default(bool); }
    public virtual void CopyTo(System.Net.NetworkInformation.UnicastIPAddressInformation[] array, int offset) { }
    public virtual System.Collections.Generic.IEnumerator<System.Net.NetworkInformation.UnicastIPAddressInformation> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Net.NetworkInformation.UnicastIPAddressInformation>); }
    public virtual bool Remove(System.Net.NetworkInformation.UnicastIPAddressInformation address) { return default(bool); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
}
namespace System.Net.Security {
  public abstract partial class AuthenticatedStream : System.IO.Stream {
    protected AuthenticatedStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen) { }
    protected System.IO.Stream InnerStream { get { return default(System.IO.Stream); } }
    public abstract bool IsAuthenticated { get; }
    public abstract bool IsEncrypted { get; }
    public abstract bool IsMutuallyAuthenticated { get; }
    public abstract bool IsServer { get; }
    public abstract bool IsSigned { get; }
    public bool LeaveInnerStreamOpen { get { return default(bool); } }
    protected override void Dispose(bool disposing) { }
  }
  public enum AuthenticationLevel {
    MutualAuthRequested = 1,
    MutualAuthRequired = 2,
    None = 0,
  }
  public delegate System.Security.Cryptography.X509Certificates.X509Certificate LocalCertificateSelectionCallback(object sender, string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, System.String[] acceptableIssuers);
  public partial class NegotiateStream : System.Net.Security.AuthenticatedStream {
    [System.MonoTODOAttribute]
    public NegotiateStream(System.IO.Stream innerStream) : base (default(System.IO.Stream), default(bool)) { }
    [System.MonoTODOAttribute]
    public NegotiateStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen) : base (default(System.IO.Stream), default(bool)) { }
    public override bool CanRead { get { return default(bool); } }
    public override bool CanSeek { get { return default(bool); } }
    [System.MonoTODOAttribute]
    public override bool CanTimeout { get { return default(bool); } }
    public override bool CanWrite { get { return default(bool); } }
    [System.MonoTODOAttribute]
    public virtual System.Security.Principal.TokenImpersonationLevel ImpersonationLevel { get { return default(System.Security.Principal.TokenImpersonationLevel); } }
    [System.MonoTODOAttribute]
    public override bool IsAuthenticated { get { return default(bool); } }
    [System.MonoTODOAttribute]
    public override bool IsEncrypted { get { return default(bool); } }
    [System.MonoTODOAttribute]
    public override bool IsMutuallyAuthenticated { get { return default(bool); } }
    [System.MonoTODOAttribute]
    public override bool IsServer { get { return default(bool); } }
    [System.MonoTODOAttribute]
    public override bool IsSigned { get { return default(bool); } }
    public override long Length { get { return default(long); } }
    public override long Position { get { return default(long); } set { } }
    public override int ReadTimeout { get { return default(int); } set { } }
    [System.MonoTODOAttribute]
    public virtual System.Security.Principal.IIdentity RemoteIdentity { get { return default(System.Security.Principal.IIdentity); } }
    public override int WriteTimeout { get { return default(int); } set { } }
    [System.MonoTODOAttribute]
    public virtual void AuthenticateAsClient() { }
    [System.MonoTODOAttribute]
    public virtual void AuthenticateAsClient(System.Net.NetworkCredential credential, string targetName) { }
    [System.MonoTODOAttribute]
    public virtual void AuthenticateAsClient(System.Net.NetworkCredential credential, string targetName, System.Net.Security.ProtectionLevel requiredProtectionLevel, System.Security.Principal.TokenImpersonationLevel allowedImpersonationLevel) { }
    [System.MonoTODOAttribute]
    public virtual void AuthenticateAsServer() { }
    [System.MonoTODOAttribute]
    public virtual void AuthenticateAsServer(System.Net.NetworkCredential credential, System.Net.Security.ProtectionLevel requiredProtectionLevel, System.Security.Principal.TokenImpersonationLevel requiredImpersonationLevel) { }
    [System.MonoTODOAttribute]
    public virtual System.IAsyncResult BeginAuthenticateAsClient(System.AsyncCallback asyncCallback, object asyncState) { return default(System.IAsyncResult); }
    [System.MonoTODOAttribute]
    public virtual System.IAsyncResult BeginAuthenticateAsClient(System.Net.NetworkCredential credential, string targetName, System.AsyncCallback asyncCallback, object asyncState) { return default(System.IAsyncResult); }
    [System.MonoTODOAttribute]
    public virtual System.IAsyncResult BeginAuthenticateAsClient(System.Net.NetworkCredential credential, string targetName, System.Net.Security.ProtectionLevel requiredProtectionLevel, System.Security.Principal.TokenImpersonationLevel allowedImpersonationLevel, System.AsyncCallback asyncCallback, object asyncState) { return default(System.IAsyncResult); }
    [System.MonoTODOAttribute]
    public virtual System.IAsyncResult BeginAuthenticateAsServer(System.AsyncCallback asyncCallback, object asyncState) { return default(System.IAsyncResult); }
    [System.MonoTODOAttribute]
    public virtual System.IAsyncResult BeginAuthenticateAsServer(System.Net.NetworkCredential credential, System.Net.Security.ProtectionLevel requiredProtectionLevel, System.Security.Principal.TokenImpersonationLevel requiredImpersonationLevel, System.AsyncCallback asyncCallback, object asyncState) { return default(System.IAsyncResult); }
    [System.MonoTODOAttribute]
    public override System.IAsyncResult BeginRead(System.Byte[] buffer, int offset, int count, System.AsyncCallback asyncCallback, object asyncState) { return default(System.IAsyncResult); }
    [System.MonoTODOAttribute]
    public override System.IAsyncResult BeginWrite(System.Byte[] buffer, int offset, int count, System.AsyncCallback asyncCallback, object asyncState) { return default(System.IAsyncResult); }
    [System.MonoTODOAttribute]
    protected override void Dispose(bool disposing) { }
    [System.MonoTODOAttribute]
    public virtual void EndAuthenticateAsClient(System.IAsyncResult asyncResult) { }
    [System.MonoTODOAttribute]
    public virtual void EndAuthenticateAsServer(System.IAsyncResult asyncResult) { }
    [System.MonoTODOAttribute]
    public override int EndRead(System.IAsyncResult asyncResult) { return default(int); }
    [System.MonoTODOAttribute]
    public override void EndWrite(System.IAsyncResult asyncResult) { }
    [System.MonoTODOAttribute]
    public override void Flush() { }
    [System.MonoTODOAttribute]
    public override int Read(System.Byte[] buffer, int offset, int count) { return default(int); }
    [System.MonoTODOAttribute]
    public override long Seek(long offset, System.IO.SeekOrigin origin) { return default(long); }
    [System.MonoTODOAttribute]
    public override void SetLength(long value) { }
    [System.MonoTODOAttribute]
    public override void Write(System.Byte[] buffer, int offset, int count) { }
  }
  public enum ProtectionLevel {
    EncryptAndSign = 2,
    None = 0,
    Sign = 1,
  }
  public delegate bool RemoteCertificateValidationCallback(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors);
  [System.FlagsAttribute]
  public enum SslPolicyErrors {
    None = 0,
    RemoteCertificateChainErrors = 4,
    RemoteCertificateNameMismatch = 2,
    RemoteCertificateNotAvailable = 1,
  }
  [System.MonoTODOAttribute("Non-X509Certificate2 certificate is not supported")]
  public partial class SslStream : System.Net.Security.AuthenticatedStream {
    public SslStream(System.IO.Stream innerStream) : base (default(System.IO.Stream), default(bool)) { }
    public SslStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen) : base (default(System.IO.Stream), default(bool)) { }
    [System.MonoTODOAttribute("userCertificateValidationCallback is not passed X509Chain and SslPolicyErrors correctly")]
    public SslStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen, System.Net.Security.RemoteCertificateValidationCallback userCertificateValidationCallback) : base (default(System.IO.Stream), default(bool)) { }
    [System.MonoTODOAttribute("userCertificateValidationCallback is not passed X509Chain and SslPolicyErrors correctly")]
    public SslStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen, System.Net.Security.RemoteCertificateValidationCallback userCertificateValidationCallback, System.Net.Security.LocalCertificateSelectionCallback userCertificateSelectionCallback) : base (default(System.IO.Stream), default(bool)) { }
    public override bool CanRead { get { return default(bool); } }
    public override bool CanSeek { get { return default(bool); } }
    public override bool CanTimeout { get { return default(bool); } }
    public override bool CanWrite { get { return default(bool); } }
    public virtual bool CheckCertRevocationStatus { get { return default(bool); } }
    public virtual System.Security.Authentication.CipherAlgorithmType CipherAlgorithm { get { return default(System.Security.Authentication.CipherAlgorithmType); } }
    public virtual int CipherStrength { get { return default(int); } }
    public virtual System.Security.Authentication.HashAlgorithmType HashAlgorithm { get { return default(System.Security.Authentication.HashAlgorithmType); } }
    public virtual int HashStrength { get { return default(int); } }
    public override bool IsAuthenticated { get { return default(bool); } }
    public override bool IsEncrypted { get { return default(bool); } }
    public override bool IsMutuallyAuthenticated { get { return default(bool); } }
    public override bool IsServer { get { return default(bool); } }
    public override bool IsSigned { get { return default(bool); } }
    public virtual System.Security.Authentication.ExchangeAlgorithmType KeyExchangeAlgorithm { get { return default(System.Security.Authentication.ExchangeAlgorithmType); } }
    public virtual int KeyExchangeStrength { get { return default(int); } }
    public override long Length { get { return default(long); } }
    public virtual System.Security.Cryptography.X509Certificates.X509Certificate LocalCertificate { get { return default(System.Security.Cryptography.X509Certificates.X509Certificate); } }
    public override long Position { get { return default(long); } set { } }
    public override int ReadTimeout { get { return default(int); } set { } }
    public virtual System.Security.Cryptography.X509Certificates.X509Certificate RemoteCertificate { get { return default(System.Security.Cryptography.X509Certificates.X509Certificate); } }
    public virtual System.Security.Authentication.SslProtocols SslProtocol { get { return default(System.Security.Authentication.SslProtocols); } }
    public override int WriteTimeout { get { return default(int); } set { } }
    public virtual void AuthenticateAsClient(string targetHost) { }
    public virtual void AuthenticateAsClient(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }
    public virtual void AuthenticateAsServer(System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate) { }
    public virtual void AuthenticateAsServer(System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, bool clientCertificateRequired, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }
    public virtual System.IAsyncResult BeginAuthenticateAsClient(string targetHost, System.AsyncCallback asyncCallback, object asyncState) { return default(System.IAsyncResult); }
    public virtual System.IAsyncResult BeginAuthenticateAsClient(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation, System.AsyncCallback asyncCallback, object asyncState) { return default(System.IAsyncResult); }
    public virtual System.IAsyncResult BeginAuthenticateAsServer(System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, System.AsyncCallback asyncCallback, object asyncState) { return default(System.IAsyncResult); }
    public virtual System.IAsyncResult BeginAuthenticateAsServer(System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, bool clientCertificateRequired, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation, System.AsyncCallback asyncCallback, object asyncState) { return default(System.IAsyncResult); }
    public override System.IAsyncResult BeginRead(System.Byte[] buffer, int offset, int count, System.AsyncCallback asyncCallback, object asyncState) { return default(System.IAsyncResult); }
    public override System.IAsyncResult BeginWrite(System.Byte[] buffer, int offset, int count, System.AsyncCallback asyncCallback, object asyncState) { return default(System.IAsyncResult); }
    protected override void Dispose(bool disposing) { }
    public virtual void EndAuthenticateAsClient(System.IAsyncResult asyncResult) { }
    public virtual void EndAuthenticateAsServer(System.IAsyncResult asyncResult) { }
    public override int EndRead(System.IAsyncResult asyncResult) { return default(int); }
    public override void EndWrite(System.IAsyncResult asyncResult) { }
    public override void Flush() { }
    public override int Read(System.Byte[] buffer, int offset, int count) { return default(int); }
    public override long Seek(long offset, System.IO.SeekOrigin origin) { return default(long); }
    public override void SetLength(long value) { }
    public void Write(System.Byte[] buffer) { }
    public override void Write(System.Byte[] buffer, int offset, int count) { }
  }
}
namespace System.Net.Sockets {
  public enum AddressFamily {
    AppleTalk = 16,
    Atm = 22,
    Banyan = 21,
    Ccitt = 10,
    Chaos = 5,
    Cluster = 24,
    DataKit = 9,
    DataLink = 13,
    DecNet = 12,
    Ecma = 8,
    FireFox = 19,
    HyperChannel = 15,
    Ieee12844 = 25,
    ImpLink = 3,
    InterNetwork = 2,
    InterNetworkV6 = 23,
    Ipx = 6,
    Irda = 26,
    Iso = 7,
    Lat = 14,
    Max = 29,
    NetBios = 17,
    NetworkDesigners = 28,
    NS = 6,
    Osi = 7,
    Pup = 4,
    Sna = 11,
    Unix = 1,
    Unknown = -1,
    Unspecified = 0,
    VoiceView = 18,
  }
  public enum IOControlCode : long {
    AbsorbRouterAlert = (long)2550136837,
    AddMulticastGroupOnInterface = (long)2550136842,
    AddressListChange = (long)671088663,
    AddressListQuery = (long)1207959574,
    AddressListSort = (long)3355443225,
    AssociateHandle = (long)2281701377,
    AsyncIO = (long)2147772029,
    BindToInterface = (long)2550136840,
    DataToRead = (long)1074030207,
    DeleteMulticastGroupFromInterface = (long)2550136843,
    EnableCircularQueuing = (long)671088642,
    Flush = (long)671088644,
    GetBroadcastAddress = (long)1207959557,
    GetExtensionFunctionPointer = (long)3355443206,
    GetGroupQos = (long)3355443208,
    GetQos = (long)3355443207,
    KeepAliveValues = (long)2550136836,
    LimitBroadcasts = (long)2550136839,
    MulticastInterface = (long)2550136841,
    MulticastScope = (long)2281701386,
    MultipointLoopback = (long)2281701385,
    NamespaceChange = (long)2281701401,
    NonBlockingIO = (long)2147772030,
    OobDataRead = (long)1074033415,
    QueryTargetPnpHandle = (long)1207959576,
    ReceiveAll = (long)2550136833,
    ReceiveAllIgmpMulticast = (long)2550136835,
    ReceiveAllMulticast = (long)2550136834,
    RoutingInterfaceChange = (long)2281701397,
    RoutingInterfaceQuery = (long)3355443220,
    SetGroupQos = (long)2281701388,
    SetQos = (long)2281701387,
    TranslateHandle = (long)3355443213,
    UnicastInterface = (long)2550136838,
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct IPPacketInformation {
    public System.Net.IPAddress Address { get { return default(System.Net.IPAddress); } }
    public int Interface { get { return default(int); } }
    public override bool Equals(object comparand) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Net.Sockets.IPPacketInformation p1, System.Net.Sockets.IPPacketInformation p2) { return default(bool); }
    public static bool operator !=(System.Net.Sockets.IPPacketInformation p1, System.Net.Sockets.IPPacketInformation p2) { return default(bool); }
  }
  public partial class IPv6MulticastOption {
    public IPv6MulticastOption(System.Net.IPAddress group) { }
    public IPv6MulticastOption(System.Net.IPAddress group, long ifindex) { }
    public System.Net.IPAddress Group { get { return default(System.Net.IPAddress); } set { } }
    public long InterfaceIndex { get { return default(long); } set { } }
  }
  public partial class LingerOption {
    public LingerOption(bool enable, int seconds) { }
    public bool Enabled { get { return default(bool); } set { } }
    public int LingerTime { get { return default(int); } set { } }
  }
  public partial class MulticastOption {
    public MulticastOption(System.Net.IPAddress group) { }
    public MulticastOption(System.Net.IPAddress group, int interfaceIndex) { }
    public MulticastOption(System.Net.IPAddress group, System.Net.IPAddress mcint) { }
    public System.Net.IPAddress Group { get { return default(System.Net.IPAddress); } set { } }
    public int InterfaceIndex { get { return default(int); } set { } }
    public System.Net.IPAddress LocalAddress { get { return default(System.Net.IPAddress); } set { } }
  }
  public partial class NetworkStream : System.IO.Stream, System.IDisposable {
    public NetworkStream(System.Net.Sockets.Socket socket) { }
    public NetworkStream(System.Net.Sockets.Socket socket, bool ownsSocket) { }
    public NetworkStream(System.Net.Sockets.Socket socket, System.IO.FileAccess access) { }
    public NetworkStream(System.Net.Sockets.Socket socket, System.IO.FileAccess access, bool ownsSocket) { }
    public override bool CanRead { get { return default(bool); } }
    public override bool CanSeek { get { return default(bool); } }
    public override bool CanTimeout { get { return default(bool); } }
    public override bool CanWrite { get { return default(bool); } }
    public virtual bool DataAvailable { get { return default(bool); } }
    public override long Length { get { return default(long); } }
    public override long Position { get { return default(long); } set { } }
    protected bool Readable { get { return default(bool); } set { } }
    public override int ReadTimeout { get { return default(int); } set { } }
    protected System.Net.Sockets.Socket Socket { get { return default(System.Net.Sockets.Socket); } }
    protected bool Writeable { get { return default(bool); } set { } }
    public override int WriteTimeout { get { return default(int); } set { } }
    public override System.IAsyncResult BeginRead(System.Byte[] buffer, int offset, int size, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public override System.IAsyncResult BeginWrite(System.Byte[] buffer, int offset, int size, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public void Close(int timeout) { }
    protected override void Dispose(bool disposing) { }
    public override int EndRead(System.IAsyncResult ar) { return default(int); }
    public override void EndWrite(System.IAsyncResult ar) { }
    ~NetworkStream() { }
    public override void Flush() { }
    public override int Read(System.Byte[] buffer, int offset, int size) { buffer = default(System.Byte[]); return default(int); }
    public override long Seek(long offset, System.IO.SeekOrigin origin) { return default(long); }
    public override void SetLength(long value) { }
    public override void Write(System.Byte[] buffer, int offset, int size) { }
  }
  public enum ProtocolFamily {
    AppleTalk = 16,
    Atm = 22,
    Banyan = 21,
    Ccitt = 10,
    Chaos = 5,
    Cluster = 24,
    DataKit = 9,
    DataLink = 13,
    DecNet = 12,
    Ecma = 8,
    FireFox = 19,
    HyperChannel = 15,
    Ieee12844 = 25,
    ImpLink = 3,
    InterNetwork = 2,
    InterNetworkV6 = 23,
    Ipx = 6,
    Irda = 26,
    Iso = 7,
    Lat = 14,
    Max = 29,
    NetBios = 17,
    NetworkDesigners = 28,
    NS = 6,
    Osi = 7,
    Pup = 4,
    Sna = 11,
    Unix = 1,
    Unknown = -1,
    Unspecified = 0,
    VoiceView = 18,
  }
  public enum ProtocolType {
    Ggp = 3,
    Icmp = 1,
    IcmpV6 = 58,
    Idp = 22,
    Igmp = 2,
    IP = 0,
    IPSecAuthenticationHeader = 51,
    IPSecEncapsulatingSecurityPayload = 50,
    IPv4 = 4,
    IPv6 = 41,
    IPv6DestinationOptions = 60,
    IPv6FragmentHeader = 44,
    IPv6HopByHopOptions = 0,
    IPv6NoNextHeader = 59,
    IPv6RoutingHeader = 43,
    Ipx = 1000,
    ND = 77,
    Pup = 12,
    Raw = 255,
    Spx = 1256,
    SpxII = 1257,
    Tcp = 6,
    Udp = 17,
    Unknown = -1,
    Unspecified = 0,
  }
  public enum SelectMode {
    SelectError = 2,
    SelectRead = 0,
    SelectWrite = 1,
  }
  public partial class SendPacketsElement {
    public SendPacketsElement(System.Byte[] buffer) { }
    public SendPacketsElement(System.Byte[] buffer, int offset, int count) { }
    public SendPacketsElement(System.Byte[] buffer, int offset, int count, bool endOfPacket) { }
    public SendPacketsElement(string filepath) { }
    public SendPacketsElement(string filepath, int offset, int count) { }
    public SendPacketsElement(string filepath, int offset, int count, bool endOfPacket) { }
    public System.Byte[] Buffer { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Byte[]); } }
    public int Count { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    public bool EndOfPacket { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    public string FilePath { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public int Offset { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
  }
  public partial class Socket : System.IDisposable {
    public Socket(System.Net.Sockets.AddressFamily addressFamily, System.Net.Sockets.SocketType socketType, System.Net.Sockets.ProtocolType protocolType) { }
    public Socket(System.Net.Sockets.SocketInformation socketInformation) { }
    public System.Net.Sockets.AddressFamily AddressFamily { get { return default(System.Net.Sockets.AddressFamily); } }
    public int Available { get { return default(int); } }
    public bool Blocking { get { return default(bool); } set { } }
    public bool Connected { get { return default(bool); } }
    public bool DontFragment { get { return default(bool); } set { } }
    public bool EnableBroadcast { get { return default(bool); } set { } }
    public bool ExclusiveAddressUse { get { return default(bool); } set { } }
    public System.IntPtr Handle { get { return default(System.IntPtr); } }
    public bool IsBound { get { return default(bool); } }
    public System.Net.Sockets.LingerOption LingerState { get { return default(System.Net.Sockets.LingerOption); } set { } }
    public System.Net.EndPoint LocalEndPoint { get { return default(System.Net.EndPoint); } }
    public bool MulticastLoopback { get { return default(bool); } set { } }
    public bool NoDelay { get { return default(bool); } set { } }
    public static bool OSSupportsIPv6 { get { return default(bool); } }
    public System.Net.Sockets.ProtocolType ProtocolType { get { return default(System.Net.Sockets.ProtocolType); } }
    public int ReceiveBufferSize { get { return default(int); } set { } }
    public int ReceiveTimeout { get { return default(int); } set { } }
    public System.Net.EndPoint RemoteEndPoint { get { return default(System.Net.EndPoint); } }
    public int SendBufferSize { get { return default(int); } set { } }
    public int SendTimeout { get { return default(int); } set { } }
    public System.Net.Sockets.SocketType SocketType { get { return default(System.Net.Sockets.SocketType); } }
    public static bool SupportsIPv4 { get { return default(bool); } }
    [System.ObsoleteAttribute("Use OSSupportsIPv6 instead")]
    public static bool SupportsIPv6 { get { return default(bool); } }
    public short Ttl { get { return default(short); } set { } }
    [System.MonoTODOAttribute("This doesn't do anything on Mono yet")]
    public bool UseOnlyOverlappedIO { get { return default(bool); } set { } }
    public System.Net.Sockets.Socket Accept() { return default(System.Net.Sockets.Socket); }
    public bool AcceptAsync(System.Net.Sockets.SocketAsyncEventArgs e) { return default(bool); }
    public System.IAsyncResult BeginAccept(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginAccept(int receiveSize, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginAccept(System.Net.Sockets.Socket acceptSocket, int receiveSize, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginConnect(System.Net.EndPoint end_point, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginConnect(System.Net.IPAddress address, int port, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginConnect(System.Net.IPAddress[] addresses, int port, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginConnect(string host, int port, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginDisconnect(bool reuseSocket, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginReceive(System.Byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socket_flags, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginReceive(System.Byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags flags, out System.Net.Sockets.SocketError error, System.AsyncCallback callback, object state) { error = default(System.Net.Sockets.SocketError); return default(System.IAsyncResult); }
    [System.CLSCompliantAttribute(false)]
    public System.IAsyncResult BeginReceive(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> buffers, System.Net.Sockets.SocketFlags socketFlags, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    [System.CLSCompliantAttribute(false)]
    public System.IAsyncResult BeginReceive(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> buffers, System.Net.Sockets.SocketFlags socketFlags, out System.Net.Sockets.SocketError errorCode, System.AsyncCallback callback, object state) { errorCode = default(System.Net.Sockets.SocketError); return default(System.IAsyncResult); }
    public System.IAsyncResult BeginReceiveFrom(System.Byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socket_flags, ref System.Net.EndPoint remote_end, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    [System.MonoTODOAttribute]
    public System.IAsyncResult BeginReceiveMessageFrom(System.Byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.EndPoint remoteEP, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginSend(System.Byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socket_flags, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginSend(System.Byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, out System.Net.Sockets.SocketError errorCode, System.AsyncCallback callback, object state) { errorCode = default(System.Net.Sockets.SocketError); return default(System.IAsyncResult); }
    public System.IAsyncResult BeginSend(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> buffers, System.Net.Sockets.SocketFlags socketFlags, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    [System.CLSCompliantAttribute(false)]
    public System.IAsyncResult BeginSend(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> buffers, System.Net.Sockets.SocketFlags socketFlags, out System.Net.Sockets.SocketError errorCode, System.AsyncCallback callback, object state) { errorCode = default(System.Net.Sockets.SocketError); return default(System.IAsyncResult); }
    public System.IAsyncResult BeginSendFile(string fileName, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginSendFile(string fileName, System.Byte[] preBuffer, System.Byte[] postBuffer, System.Net.Sockets.TransmitFileOptions flags, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginSendTo(System.Byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socket_flags, System.Net.EndPoint remote_end, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public void Bind(System.Net.EndPoint local_end) { }
    public void Close() { }
    public void Close(int timeout) { }
    public void Connect(System.Net.EndPoint remoteEP) { }
    public void Connect(System.Net.IPAddress address, int port) { }
    public void Connect(System.Net.IPAddress[] addresses, int port) { }
    public void Connect(string host, int port) { }
    public bool ConnectAsync(System.Net.Sockets.SocketAsyncEventArgs e) { return default(bool); }
    public void Disconnect(bool reuseSocket) { }
    public bool DisconnectAsync(System.Net.Sockets.SocketAsyncEventArgs e) { return default(bool); }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    [System.MonoLimitationAttribute("We do not support passing sockets across processes, we merely allow this API to pass the socket across AppDomains")]
    public System.Net.Sockets.SocketInformation DuplicateAndClose(int targetProcessId) { return default(System.Net.Sockets.SocketInformation); }
    public System.Net.Sockets.Socket EndAccept(out System.Byte[] buffer, System.IAsyncResult asyncResult) { buffer = default(System.Byte[]); return default(System.Net.Sockets.Socket); }
    public System.Net.Sockets.Socket EndAccept(out System.Byte[] buffer, out int bytesTransferred, System.IAsyncResult asyncResult) { buffer = default(System.Byte[]); bytesTransferred = default(int); return default(System.Net.Sockets.Socket); }
    public System.Net.Sockets.Socket EndAccept(System.IAsyncResult result) { return default(System.Net.Sockets.Socket); }
    public void EndConnect(System.IAsyncResult result) { }
    public void EndDisconnect(System.IAsyncResult asyncResult) { }
    public int EndReceive(System.IAsyncResult result) { return default(int); }
    public int EndReceive(System.IAsyncResult asyncResult, out System.Net.Sockets.SocketError errorCode) { errorCode = default(System.Net.Sockets.SocketError); return default(int); }
    public int EndReceiveFrom(System.IAsyncResult result, ref System.Net.EndPoint end_point) { return default(int); }
    [System.MonoTODOAttribute]
    public int EndReceiveMessageFrom(System.IAsyncResult asyncResult, ref System.Net.Sockets.SocketFlags socketFlags, ref System.Net.EndPoint endPoint, out System.Net.Sockets.IPPacketInformation ipPacketInformation) { ipPacketInformation = default(System.Net.Sockets.IPPacketInformation); return default(int); }
    public int EndSend(System.IAsyncResult result) { return default(int); }
    public int EndSend(System.IAsyncResult asyncResult, out System.Net.Sockets.SocketError errorCode) { errorCode = default(System.Net.Sockets.SocketError); return default(int); }
    public void EndSendFile(System.IAsyncResult asyncResult) { }
    public int EndSendTo(System.IAsyncResult result) { return default(int); }
    ~Socket() { }
    public object GetSocketOption(System.Net.Sockets.SocketOptionLevel optionLevel, System.Net.Sockets.SocketOptionName optionName) { return default(object); }
    public void GetSocketOption(System.Net.Sockets.SocketOptionLevel optionLevel, System.Net.Sockets.SocketOptionName optionName, System.Byte[] optionValue) { }
    public System.Byte[] GetSocketOption(System.Net.Sockets.SocketOptionLevel optionLevel, System.Net.Sockets.SocketOptionName optionName, int length) { return default(System.Byte[]); }
    public int IOControl(int ioctl_code, System.Byte[] in_value, System.Byte[] out_value) { return default(int); }
    public int IOControl(System.Net.Sockets.IOControlCode ioControlCode, System.Byte[] optionInValue, System.Byte[] optionOutValue) { return default(int); }
    public void Listen(int backlog) { }
    public bool Poll(int time_us, System.Net.Sockets.SelectMode mode) { return default(bool); }
    public int Receive(System.Byte[] buffer) { return default(int); }
    public int Receive(System.Byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags flags) { return default(int); }
    public int Receive(System.Byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags flags, out System.Net.Sockets.SocketError error) { error = default(System.Net.Sockets.SocketError); return default(int); }
    public int Receive(System.Byte[] buffer, int size, System.Net.Sockets.SocketFlags flags) { return default(int); }
    public int Receive(System.Byte[] buffer, System.Net.Sockets.SocketFlags flags) { return default(int); }
    public int Receive(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> buffers) { return default(int); }
    [System.CLSCompliantAttribute(false)]
    public int Receive(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> buffers, System.Net.Sockets.SocketFlags socketFlags) { return default(int); }
    [System.CLSCompliantAttribute(false)]
    public int Receive(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> buffers, System.Net.Sockets.SocketFlags socketFlags, out System.Net.Sockets.SocketError errorCode) { errorCode = default(System.Net.Sockets.SocketError); return default(int); }
    public bool ReceiveAsync(System.Net.Sockets.SocketAsyncEventArgs e) { return default(bool); }
    public int ReceiveFrom(System.Byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags flags, ref System.Net.EndPoint remoteEP) { return default(int); }
    public int ReceiveFrom(System.Byte[] buffer, int size, System.Net.Sockets.SocketFlags flags, ref System.Net.EndPoint remoteEP) { return default(int); }
    public int ReceiveFrom(System.Byte[] buffer, ref System.Net.EndPoint remoteEP) { return default(int); }
    public int ReceiveFrom(System.Byte[] buffer, System.Net.Sockets.SocketFlags flags, ref System.Net.EndPoint remoteEP) { return default(int); }
    public bool ReceiveFromAsync(System.Net.Sockets.SocketAsyncEventArgs e) { return default(bool); }
    [System.MonoTODOAttribute("Not implemented")]
    public int ReceiveMessageFrom(System.Byte[] buffer, int offset, int size, ref System.Net.Sockets.SocketFlags socketFlags, ref System.Net.EndPoint remoteEP, out System.Net.Sockets.IPPacketInformation ipPacketInformation) { ipPacketInformation = default(System.Net.Sockets.IPPacketInformation); return default(int); }
    [System.MonoTODOAttribute("Not implemented")]
    public bool ReceiveMessageFromAsync(System.Net.Sockets.SocketAsyncEventArgs e) { return default(bool); }
    public static void Select(System.Collections.IList checkRead, System.Collections.IList checkWrite, System.Collections.IList checkError, int microSeconds) { }
    public int Send(System.Byte[] buf) { return default(int); }
    public int Send(System.Byte[] buf, int offset, int size, System.Net.Sockets.SocketFlags flags) { return default(int); }
    public int Send(System.Byte[] buf, int offset, int size, System.Net.Sockets.SocketFlags flags, out System.Net.Sockets.SocketError error) { error = default(System.Net.Sockets.SocketError); return default(int); }
    public int Send(System.Byte[] buf, int size, System.Net.Sockets.SocketFlags flags) { return default(int); }
    public int Send(System.Byte[] buf, System.Net.Sockets.SocketFlags flags) { return default(int); }
    public int Send(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> buffers) { return default(int); }
    public int Send(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> buffers, System.Net.Sockets.SocketFlags socketFlags) { return default(int); }
    [System.CLSCompliantAttribute(false)]
    public int Send(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> buffers, System.Net.Sockets.SocketFlags socketFlags, out System.Net.Sockets.SocketError errorCode) { errorCode = default(System.Net.Sockets.SocketError); return default(int); }
    public bool SendAsync(System.Net.Sockets.SocketAsyncEventArgs e) { return default(bool); }
    public void SendFile(string fileName) { }
    public void SendFile(string fileName, System.Byte[] preBuffer, System.Byte[] postBuffer, System.Net.Sockets.TransmitFileOptions flags) { }
    [System.MonoTODOAttribute("Not implemented")]
    public bool SendPacketsAsync(System.Net.Sockets.SocketAsyncEventArgs e) { return default(bool); }
    public int SendTo(System.Byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags flags, System.Net.EndPoint remote_end) { return default(int); }
    public int SendTo(System.Byte[] buffer, int size, System.Net.Sockets.SocketFlags flags, System.Net.EndPoint remote_end) { return default(int); }
    public int SendTo(System.Byte[] buffer, System.Net.EndPoint remote_end) { return default(int); }
    public int SendTo(System.Byte[] buffer, System.Net.Sockets.SocketFlags flags, System.Net.EndPoint remote_end) { return default(int); }
    public bool SendToAsync(System.Net.Sockets.SocketAsyncEventArgs e) { return default(bool); }
    public void SetSocketOption(System.Net.Sockets.SocketOptionLevel optionLevel, System.Net.Sockets.SocketOptionName optionName, bool optionValue) { }
    public void SetSocketOption(System.Net.Sockets.SocketOptionLevel optionLevel, System.Net.Sockets.SocketOptionName optionName, System.Byte[] optionValue) { }
    public void SetSocketOption(System.Net.Sockets.SocketOptionLevel optionLevel, System.Net.Sockets.SocketOptionName optionName, int optionValue) { }
    public void SetSocketOption(System.Net.Sockets.SocketOptionLevel optionLevel, System.Net.Sockets.SocketOptionName optionName, object optionValue) { }
    public void Shutdown(System.Net.Sockets.SocketShutdown how) { }
  }
  public partial class SocketAsyncEventArgs : System.EventArgs, System.IDisposable {
    public SocketAsyncEventArgs() { }
    public System.Net.Sockets.Socket AcceptSocket { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Net.Sockets.Socket); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Byte[] Buffer { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Byte[]); } }
    public System.Collections.Generic.IList<System.ArraySegment<System.Byte>> BufferList { get { return default(System.Collections.Generic.IList<System.ArraySegment<System.Byte>>); } set { } }
    public int BytesTransferred { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    public System.Exception ConnectByNameError { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Exception); } }
    public System.Net.Sockets.Socket ConnectSocket { get { return default(System.Net.Sockets.Socket); } }
    public int Count { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    public bool DisconnectReuseSocket { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Net.Sockets.SocketAsyncOperation LastOperation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Net.Sockets.SocketAsyncOperation); } }
    public int Offset { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    public System.Net.Sockets.IPPacketInformation ReceiveMessageFromPacketInfo { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Net.Sockets.IPPacketInformation); } }
    public System.Net.EndPoint RemoteEndPoint { get { return default(System.Net.EndPoint); } set { } }
    public System.Net.Sockets.SendPacketsElement[] SendPacketsElements { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Net.Sockets.SendPacketsElement[]); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Net.Sockets.TransmitFileOptions SendPacketsFlags { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Net.Sockets.TransmitFileOptions); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute("unused property")]
    public int SendPacketsSendSize { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Net.Sockets.SocketError SocketError { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Net.Sockets.SocketError); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Net.Sockets.SocketFlags SocketFlags { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Net.Sockets.SocketFlags); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public object UserToken { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public event System.EventHandler<System.Net.Sockets.SocketAsyncEventArgs> Completed { add { } remove { } }
    public void Dispose() { }
    ~SocketAsyncEventArgs() { }
    protected virtual void OnCompleted(System.Net.Sockets.SocketAsyncEventArgs e) { }
    public void SetBuffer(System.Byte[] buffer, int offset, int count) { }
    public void SetBuffer(int offset, int count) { }
  }
  public enum SocketAsyncOperation {
    Accept = 1,
    Connect = 2,
    Disconnect = 3,
    None = 0,
    Receive = 4,
    ReceiveFrom = 5,
    ReceiveMessageFrom = 6,
    Send = 7,
    SendPackets = 8,
    SendTo = 9,
  }
  public enum SocketError {
    AccessDenied = 10013,
    AddressAlreadyInUse = 10048,
    AddressFamilyNotSupported = 10047,
    AddressNotAvailable = 10049,
    AlreadyInProgress = 10037,
    ConnectionAborted = 10053,
    ConnectionRefused = 10061,
    ConnectionReset = 10054,
    DestinationAddressRequired = 10039,
    Disconnecting = 10101,
    Fault = 10014,
    HostDown = 10064,
    HostNotFound = 11001,
    HostUnreachable = 10065,
    InProgress = 10036,
    Interrupted = 10004,
    InvalidArgument = 10022,
    IOPending = 997,
    IsConnected = 10056,
    MessageSize = 10040,
    NetworkDown = 10050,
    NetworkReset = 10052,
    NetworkUnreachable = 10051,
    NoBufferSpaceAvailable = 10055,
    NoData = 11004,
    NoRecovery = 11003,
    NotConnected = 10057,
    NotInitialized = 10093,
    NotSocket = 10038,
    OperationAborted = 995,
    OperationNotSupported = 10045,
    ProcessLimit = 10067,
    ProtocolFamilyNotSupported = 10046,
    ProtocolNotSupported = 10043,
    ProtocolOption = 10042,
    ProtocolType = 10041,
    Shutdown = 10058,
    SocketError = -1,
    SocketNotSupported = 10044,
    Success = 0,
    SystemNotReady = 10091,
    TimedOut = 10060,
    TooManyOpenSockets = 10024,
    TryAgain = 11002,
    TypeNotFound = 10109,
    VersionNotSupported = 10092,
    WouldBlock = 10035,
  }
  public partial class SocketException : System.ComponentModel.Win32Exception {
    public SocketException() { }
    public SocketException(int error) { }
    protected SocketException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public override int ErrorCode { get { return default(int); } }
    public override string Message { get { return default(string); } }
    public System.Net.Sockets.SocketError SocketErrorCode { get { return default(System.Net.Sockets.SocketError); } }
  }
  [System.FlagsAttribute]
  public enum SocketFlags {
    Broadcast = 1024,
    ControlDataTruncated = 512,
    DontRoute = 4,
    MaxIOVectorLength = 16,
    Multicast = 2048,
    None = 0,
    OutOfBand = 1,
    Partial = 32768,
    Peek = 2,
    Truncated = 256,
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct SocketInformation {
    public System.Net.Sockets.SocketInformationOptions Options { get { return default(System.Net.Sockets.SocketInformationOptions); } set { } }
    public System.Byte[] ProtocolInformation { get { return default(System.Byte[]); } set { } }
  }
  [System.FlagsAttribute]
  public enum SocketInformationOptions {
    Connected = 2,
    Listening = 4,
    NonBlocking = 1,
    UseOnlyOverlappedIO = 8,
  }
  public enum SocketOptionLevel {
    IP = 0,
    IPv6 = 41,
    Socket = 65535,
    Tcp = 6,
    Udp = 17,
  }
  public enum SocketOptionName {
    AcceptConnection = 2,
    AddMembership = 12,
    AddSourceMembership = 15,
    BlockSource = 17,
    Broadcast = 32,
    BsdUrgent = 2,
    ChecksumCoverage = 20,
    Debug = 1,
    DontFragment = 14,
    DontLinger = -129,
    DontRoute = 16,
    DropMembership = 13,
    DropSourceMembership = 16,
    Error = 4103,
    ExclusiveAddressUse = -5,
    Expedited = 2,
    HeaderIncluded = 2,
    HopLimit = 21,
    IPOptions = 1,
    IpTimeToLive = 4,
    KeepAlive = 8,
    Linger = 128,
    MaxConnections = 2147483647,
    MulticastInterface = 9,
    MulticastLoopback = 11,
    MulticastTimeToLive = 10,
    NoChecksum = 1,
    NoDelay = 1,
    OutOfBandInline = 256,
    PacketInformation = 19,
    ReceiveBuffer = 4098,
    ReceiveLowWater = 4100,
    ReceiveTimeout = 4102,
    ReuseAddress = 4,
    SendBuffer = 4097,
    SendLowWater = 4099,
    SendTimeout = 4101,
    Type = 4104,
    TypeOfService = 3,
    UnblockSource = 18,
    UpdateAcceptContext = 28683,
    UpdateConnectContext = 28688,
    UseLoopback = 64,
  }
  public enum SocketShutdown {
    Both = 2,
    Receive = 0,
    Send = 1,
  }
  public enum SocketType {
    Dgram = 2,
    Raw = 3,
    Rdm = 4,
    Seqpacket = 5,
    Stream = 1,
    Unknown = -1,
  }
  public partial class TcpClient : System.IDisposable {
    public TcpClient() { }
    public TcpClient(System.Net.IPEndPoint localEP) { }
    public TcpClient(System.Net.Sockets.AddressFamily family) { }
    public TcpClient(string hostname, int port) { }
    protected bool Active { get { return default(bool); } set { } }
    public int Available { get { return default(int); } }
    public System.Net.Sockets.Socket Client { get { return default(System.Net.Sockets.Socket); } set { } }
    public bool Connected { get { return default(bool); } }
    public bool ExclusiveAddressUse { get { return default(bool); } set { } }
    public System.Net.Sockets.LingerOption LingerState { get { return default(System.Net.Sockets.LingerOption); } set { } }
    public bool NoDelay { get { return default(bool); } set { } }
    public int ReceiveBufferSize { get { return default(int); } set { } }
    public int ReceiveTimeout { get { return default(int); } set { } }
    public int SendBufferSize { get { return default(int); } set { } }
    public int SendTimeout { get { return default(int); } set { } }
    public System.IAsyncResult BeginConnect(System.Net.IPAddress address, int port, System.AsyncCallback requestCallback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginConnect(System.Net.IPAddress[] addresses, int port, System.AsyncCallback requestCallback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginConnect(string host, int port, System.AsyncCallback requestCallback, object state) { return default(System.IAsyncResult); }
    public void Close() { }
    public void Connect(System.Net.IPAddress address, int port) { }
    public void Connect(System.Net.IPAddress[] ipAddresses, int port) { }
    public void Connect(System.Net.IPEndPoint remoteEP) { }
    public void Connect(string hostname, int port) { }
    protected virtual void Dispose(bool disposing) { }
    public void EndConnect(System.IAsyncResult asyncResult) { }
    ~TcpClient() { }
    public System.Net.Sockets.NetworkStream GetStream() { return default(System.Net.Sockets.NetworkStream); }
    void System.IDisposable.Dispose() { }
  }
  public partial class TcpListener {
    [System.ObsoleteAttribute("Use TcpListener (IPAddress address, int port) instead")]
    public TcpListener(int port) { }
    public TcpListener(System.Net.IPAddress localaddr, int port) { }
    public TcpListener(System.Net.IPEndPoint localEP) { }
    protected bool Active { get { return default(bool); } }
    public bool ExclusiveAddressUse { get { return default(bool); } set { } }
    public System.Net.EndPoint LocalEndpoint { get { return default(System.Net.EndPoint); } }
    public System.Net.Sockets.Socket Server { get { return default(System.Net.Sockets.Socket); } }
    public System.Net.Sockets.Socket AcceptSocket() { return default(System.Net.Sockets.Socket); }
    public System.Net.Sockets.TcpClient AcceptTcpClient() { return default(System.Net.Sockets.TcpClient); }
    public System.IAsyncResult BeginAcceptSocket(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginAcceptTcpClient(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.Net.Sockets.Socket EndAcceptSocket(System.IAsyncResult asyncResult) { return default(System.Net.Sockets.Socket); }
    public System.Net.Sockets.TcpClient EndAcceptTcpClient(System.IAsyncResult asyncResult) { return default(System.Net.Sockets.TcpClient); }
    ~TcpListener() { }
    public bool Pending() { return default(bool); }
    public void Start() { }
    public void Start(int backlog) { }
    public void Stop() { }
  }
  [System.FlagsAttribute]
  public enum TransmitFileOptions {
    Disconnect = 1,
    ReuseSocket = 2,
    UseDefaultWorkerThread = 0,
    UseKernelApc = 32,
    UseSystemThread = 16,
    WriteBehind = 4,
  }
  public partial class UdpClient : System.IDisposable {
    public UdpClient() { }
    public UdpClient(int port) { }
    public UdpClient(int port, System.Net.Sockets.AddressFamily family) { }
    public UdpClient(System.Net.IPEndPoint localEP) { }
    public UdpClient(System.Net.Sockets.AddressFamily family) { }
    public UdpClient(string hostname, int port) { }
    protected bool Active { get { return default(bool); } set { } }
    public int Available { get { return default(int); } }
    public System.Net.Sockets.Socket Client { get { return default(System.Net.Sockets.Socket); } set { } }
    public bool DontFragment { get { return default(bool); } set { } }
    public bool EnableBroadcast { get { return default(bool); } set { } }
    public bool ExclusiveAddressUse { get { return default(bool); } set { } }
    public bool MulticastLoopback { get { return default(bool); } set { } }
    public short Ttl { get { return default(short); } set { } }
    public System.IAsyncResult BeginReceive(System.AsyncCallback requestCallback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginSend(System.Byte[] datagram, int bytes, System.AsyncCallback requestCallback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginSend(System.Byte[] datagram, int bytes, System.Net.IPEndPoint endPoint, System.AsyncCallback requestCallback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginSend(System.Byte[] datagram, int bytes, string hostname, int port, System.AsyncCallback requestCallback, object state) { return default(System.IAsyncResult); }
    public void Close() { }
    public void Connect(System.Net.IPAddress addr, int port) { }
    public void Connect(System.Net.IPEndPoint endPoint) { }
    public void Connect(string hostname, int port) { }
    protected virtual void Dispose(bool disposing) { }
    public void DropMulticastGroup(System.Net.IPAddress multicastAddr) { }
    public void DropMulticastGroup(System.Net.IPAddress multicastAddr, int ifindex) { }
    public System.Byte[] EndReceive(System.IAsyncResult asyncResult, ref System.Net.IPEndPoint remoteEP) { return default(System.Byte[]); }
    public int EndSend(System.IAsyncResult asyncResult) { return default(int); }
    ~UdpClient() { }
    public void JoinMulticastGroup(int ifindex, System.Net.IPAddress multicastAddr) { }
    public void JoinMulticastGroup(System.Net.IPAddress multicastAddr) { }
    public void JoinMulticastGroup(System.Net.IPAddress multicastAddr, int timeToLive) { }
    public void JoinMulticastGroup(System.Net.IPAddress multicastAddr, System.Net.IPAddress localAddress) { }
    public System.Byte[] Receive(ref System.Net.IPEndPoint remoteEP) { return default(System.Byte[]); }
    public int Send(System.Byte[] dgram, int bytes) { return default(int); }
    public int Send(System.Byte[] dgram, int bytes, System.Net.IPEndPoint endPoint) { return default(int); }
    public int Send(System.Byte[] dgram, int bytes, string hostname, int port) { return default(int); }
    void System.IDisposable.Dispose() { }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Size=1)]
  public partial struct UdpReceiveResult : System.IEquatable<System.Net.Sockets.UdpReceiveResult> {
    public UdpReceiveResult(System.Byte[] buffer, System.Net.IPEndPoint remoteEndPoint) { throw new System.NotImplementedException(); }
    public System.Byte[] Buffer { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Byte[]); } }
    public System.Net.IPEndPoint RemoteEndPoint { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Net.IPEndPoint); } }
    public bool Equals(System.Net.Sockets.UdpReceiveResult other) { return default(bool); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Net.Sockets.UdpReceiveResult left, System.Net.Sockets.UdpReceiveResult right) { return default(bool); }
    public static bool operator !=(System.Net.Sockets.UdpReceiveResult left, System.Net.Sockets.UdpReceiveResult right) { return default(bool); }
  }
}
namespace System.Runtime.InteropServices {
  [System.AttributeUsageAttribute((System.AttributeTargets)(2048))]
  public sealed partial class DefaultParameterValueAttribute : System.Attribute {
    public DefaultParameterValueAttribute(object value) { }
    public object Value { get { return default(object); } }
  }
  public sealed partial class HandleCollector {
    public HandleCollector(string name, int initialThreshold) { }
    public HandleCollector(string name, int initialThreshold, int maximumThreshold) { }
    public int Count { get { return default(int); } }
    public int InitialThreshold { get { return default(int); } }
    public int MaximumThreshold { get { return default(int); } }
    public string Name { get { return default(string); } }
    public void Add() { }
    public void Remove() { }
  }
  [System.MonoLimitationAttribute("The runtime does nothing special apart from what it already does with marshal-by-ref objects")]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class StandardOleMarshalObject : System.MarshalByRefObject {
    protected StandardOleMarshalObject() { }
  }
}
namespace System.Runtime.InteropServices.ComTypes {
  [System.FlagsAttribute]
  public enum ADVF {
    ADVF_DATAONSTOP = 64,
    ADVF_NODATA = 1,
    ADVF_ONLYONCE = 4,
    ADVF_PRIMEFIRST = 2,
    ADVFCACHE_FORCEBUILTIN = 16,
    ADVFCACHE_NOHANDLER = 8,
    ADVFCACHE_ONSAVE = 32,
  }
  public enum DATADIR {
    DATADIR_GET = 1,
    DATADIR_SET = 2,
  }
  [System.FlagsAttribute]
  public enum DVASPECT {
    DVASPECT_CONTENT = 1,
    DVASPECT_DOCPRINT = 8,
    DVASPECT_ICON = 4,
    DVASPECT_THUMBNAIL = 2,
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct FORMATETC {
    public short cfFormat;
    public System.Runtime.InteropServices.ComTypes.DVASPECT dwAspect;
    public int lindex;
    public System.IntPtr ptd;
    public System.Runtime.InteropServices.ComTypes.TYMED tymed;
  }
  [System.Runtime.InteropServices.GuidAttribute("0000010F-0000-0000-C000-000000000046")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
  public partial interface IAdviseSink {
    void OnClose();
    void OnDataChange(ref System.Runtime.InteropServices.ComTypes.FORMATETC format, ref System.Runtime.InteropServices.ComTypes.STGMEDIUM stgmedium);
    void OnRename(System.Runtime.InteropServices.ComTypes.IMoniker moniker);
    void OnSave();
    void OnViewChange(int aspect, int index);
  }
  [System.Runtime.InteropServices.GuidAttribute("0000010e-0000-0000-C000-000000000046")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
  public partial interface IDataObject {
    int DAdvise(ref System.Runtime.InteropServices.ComTypes.FORMATETC pFormatetc, System.Runtime.InteropServices.ComTypes.ADVF advf, System.Runtime.InteropServices.ComTypes.IAdviseSink adviseSink, out int connection);
    void DUnadvise(int connection);
    int EnumDAdvise(out System.Runtime.InteropServices.ComTypes.IEnumSTATDATA enumAdvise);
    System.Runtime.InteropServices.ComTypes.IEnumFORMATETC EnumFormatEtc(System.Runtime.InteropServices.ComTypes.DATADIR direction);
    int GetCanonicalFormatEtc(ref System.Runtime.InteropServices.ComTypes.FORMATETC formatIn, out System.Runtime.InteropServices.ComTypes.FORMATETC formatOut);
    void GetData(ref System.Runtime.InteropServices.ComTypes.FORMATETC format, out System.Runtime.InteropServices.ComTypes.STGMEDIUM medium);
    void GetDataHere(ref System.Runtime.InteropServices.ComTypes.FORMATETC format, ref System.Runtime.InteropServices.ComTypes.STGMEDIUM medium);
    int QueryGetData(ref System.Runtime.InteropServices.ComTypes.FORMATETC format);
    void SetData(ref System.Runtime.InteropServices.ComTypes.FORMATETC formatIn, ref System.Runtime.InteropServices.ComTypes.STGMEDIUM medium, bool release);
  }
  [System.Runtime.InteropServices.GuidAttribute("00000103-0000-0000-C000-000000000046")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
  public partial interface IEnumFORMATETC {
    void Clone(out System.Runtime.InteropServices.ComTypes.IEnumFORMATETC newEnum);
    int Next(int celt, System.Runtime.InteropServices.ComTypes.FORMATETC[] rgelt, System.Int32[] pceltFetched);
    int Reset();
    int Skip(int celt);
  }
  [System.Runtime.InteropServices.GuidAttribute("00000103-0000-0000-C000-000000000046")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
  public partial interface IEnumSTATDATA {
    void Clone(out System.Runtime.InteropServices.ComTypes.IEnumSTATDATA newEnum);
    int Next(int celt, System.Runtime.InteropServices.ComTypes.STATDATA[] rgelt, System.Int32[] pceltFetched);
    int Reset();
    int Skip(int celt);
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct STATDATA {
    public System.Runtime.InteropServices.ComTypes.ADVF advf;
    public System.Runtime.InteropServices.ComTypes.IAdviseSink advSink;
    public int connection;
    public System.Runtime.InteropServices.ComTypes.FORMATETC formatetc;
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct STGMEDIUM {
    public object pUnkForRelease;
    public System.Runtime.InteropServices.ComTypes.TYMED tymed;
    public System.IntPtr unionmember;
  }
  [System.FlagsAttribute]
  public enum TYMED {
    TYMED_ENHMF = 64,
    TYMED_FILE = 2,
    TYMED_GDI = 16,
    TYMED_HGLOBAL = 1,
    TYMED_ISTORAGE = 8,
    TYMED_ISTREAM = 4,
    TYMED_MFPICT = 32,
    TYMED_NULL = 0,
  }
}
namespace System.Runtime.Versioning {
  public sealed partial class FrameworkName : System.IEquatable<System.Runtime.Versioning.FrameworkName> {
    public FrameworkName(string frameworkName) { }
    public FrameworkName(string identifier, System.Version version) { }
    public FrameworkName(string identifier, System.Version version, string profile) { }
    public string FullName { get { return default(string); } }
    public string Identifier { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string Profile { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public System.Version Version { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Version); } }
    public override bool Equals(object obj) { return default(bool); }
    public bool Equals(System.Runtime.Versioning.FrameworkName other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Runtime.Versioning.FrameworkName left, System.Runtime.Versioning.FrameworkName right) { return default(bool); }
    public static bool operator !=(System.Runtime.Versioning.FrameworkName left, System.Runtime.Versioning.FrameworkName right) { return default(bool); }
    public override string ToString() { return default(string); }
  }
}
namespace System.Security.AccessControl {
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public sealed partial class SemaphoreAccessRule : System.Security.AccessControl.AccessRule {
    public SemaphoreAccessRule(System.Security.Principal.IdentityReference identity, System.Security.AccessControl.SemaphoreRights semaphoreRights, System.Security.AccessControl.AccessControlType type) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AccessControlType)) { }
    public SemaphoreAccessRule(string identity, System.Security.AccessControl.SemaphoreRights semaphoreRights, System.Security.AccessControl.AccessControlType type) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AccessControlType)) { }
    public System.Security.AccessControl.SemaphoreRights SemaphoreRights { get { return default(System.Security.AccessControl.SemaphoreRights); } }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public sealed partial class SemaphoreAuditRule : System.Security.AccessControl.AuditRule {
    public SemaphoreAuditRule(System.Security.Principal.IdentityReference identity, System.Security.AccessControl.SemaphoreRights semaphoreRights, System.Security.AccessControl.AuditFlags flags) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AuditFlags)) { }
    public System.Security.AccessControl.SemaphoreRights SemaphoreRights { get { return default(System.Security.AccessControl.SemaphoreRights); } }
  }
  [System.FlagsAttribute]
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public enum SemaphoreRights {
    ChangePermissions = 262144,
    Delete = 65536,
    FullControl = 2031619,
    Modify = 2,
    ReadPermissions = 131072,
    Synchronize = 1048576,
    TakeOwnership = 524288,
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public sealed partial class SemaphoreSecurity : System.Security.AccessControl.NativeObjectSecurity {
    public SemaphoreSecurity() : base (default(bool), default(System.Security.AccessControl.ResourceType)) { }
    public SemaphoreSecurity(string name, System.Security.AccessControl.AccessControlSections includeSections) : base (default(bool), default(System.Security.AccessControl.ResourceType)) { }
    public override System.Type AccessRightType { get { return default(System.Type); } }
    public override System.Type AccessRuleType { get { return default(System.Type); } }
    public override System.Type AuditRuleType { get { return default(System.Type); } }
    public override System.Security.AccessControl.AccessRule AccessRuleFactory(System.Security.Principal.IdentityReference identityReference, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AccessControlType type) { return default(System.Security.AccessControl.AccessRule); }
    public void AddAccessRule(System.Security.AccessControl.SemaphoreAccessRule rule) { }
    public void AddAuditRule(System.Security.AccessControl.SemaphoreAuditRule rule) { }
    public override System.Security.AccessControl.AuditRule AuditRuleFactory(System.Security.Principal.IdentityReference identityReference, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AuditFlags flags) { return default(System.Security.AccessControl.AuditRule); }
    public bool RemoveAccessRule(System.Security.AccessControl.SemaphoreAccessRule rule) { return default(bool); }
    public void RemoveAccessRuleAll(System.Security.AccessControl.SemaphoreAccessRule rule) { }
    public void RemoveAccessRuleSpecific(System.Security.AccessControl.SemaphoreAccessRule rule) { }
    public bool RemoveAuditRule(System.Security.AccessControl.SemaphoreAuditRule rule) { return default(bool); }
    public void RemoveAuditRuleAll(System.Security.AccessControl.SemaphoreAuditRule rule) { }
    public void RemoveAuditRuleSpecific(System.Security.AccessControl.SemaphoreAuditRule rule) { }
    public void ResetAccessRule(System.Security.AccessControl.SemaphoreAccessRule rule) { }
    public void SetAccessRule(System.Security.AccessControl.SemaphoreAccessRule rule) { }
    public void SetAuditRule(System.Security.AccessControl.SemaphoreAuditRule rule) { }
  }
}
namespace System.Security.Authentication {
  public partial class AuthenticationException : System.SystemException {
    public AuthenticationException() { }
    protected AuthenticationException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    public AuthenticationException(string message) { }
    public AuthenticationException(string message, System.Exception innerException) { }
  }
  public enum CipherAlgorithmType {
    Aes = 26129,
    Aes128 = 26126,
    Aes192 = 26127,
    Aes256 = 26128,
    Des = 26113,
    None = 0,
    Null = 24576,
    Rc2 = 26114,
    Rc4 = 26625,
    TripleDes = 26115,
  }
  public enum ExchangeAlgorithmType {
    DiffieHellman = 43522,
    None = 0,
    RsaKeyX = 41984,
    RsaSign = 9216,
  }
  public enum HashAlgorithmType {
    Md5 = 32771,
    None = 0,
    Sha1 = 32772,
  }
  public partial class InvalidCredentialException : System.Security.Authentication.AuthenticationException {
    public InvalidCredentialException() { }
    protected InvalidCredentialException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    public InvalidCredentialException(string message) { }
    public InvalidCredentialException(string message, System.Exception innerException) { }
  }
  [System.FlagsAttribute]
  public enum SslProtocols {
    Default = 240,
    None = 0,
    Ssl2 = 12,
    Ssl3 = 48,
    Tls = 192,
  }
}
namespace System.Security.Authentication.ExtendedProtection {
  public abstract partial class ChannelBinding : Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid {
    protected ChannelBinding() : base (default(bool)) { }
    protected ChannelBinding(bool ownsHandle) : base (default(bool)) { }
    public abstract int Size { get; }
  }
  public enum ChannelBindingKind {
    Endpoint = 2,
    Unique = 1,
    Unknown = 0,
  }
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicyTypeConverter))]
  [System.MonoTODOAttribute]
  public partial class ExtendedProtectionPolicy : System.Runtime.Serialization.ISerializable {
    protected ExtendedProtectionPolicy(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    [System.MonoTODOAttribute("Not implemented.")]
    public ExtendedProtectionPolicy(System.Security.Authentication.ExtendedProtection.PolicyEnforcement policyEnforcement) { }
    public ExtendedProtectionPolicy(System.Security.Authentication.ExtendedProtection.PolicyEnforcement policyEnforcement, System.Security.Authentication.ExtendedProtection.ChannelBinding customChannelBinding) { }
    public ExtendedProtectionPolicy(System.Security.Authentication.ExtendedProtection.PolicyEnforcement policyEnforcement, System.Security.Authentication.ExtendedProtection.ProtectionScenario protectionScenario, System.Collections.ICollection customServiceNames) { }
    public ExtendedProtectionPolicy(System.Security.Authentication.ExtendedProtection.PolicyEnforcement policyEnforcement, System.Security.Authentication.ExtendedProtection.ProtectionScenario protectionScenario, System.Security.Authentication.ExtendedProtection.ServiceNameCollection customServiceNames) { }
    public System.Security.Authentication.ExtendedProtection.ChannelBinding CustomChannelBinding { get { return default(System.Security.Authentication.ExtendedProtection.ChannelBinding); } }
    public System.Security.Authentication.ExtendedProtection.ServiceNameCollection CustomServiceNames { get { return default(System.Security.Authentication.ExtendedProtection.ServiceNameCollection); } }
    public static bool OSSupportsExtendedProtection { get { return default(bool); } }
    public System.Security.Authentication.ExtendedProtection.PolicyEnforcement PolicyEnforcement { get { return default(System.Security.Authentication.ExtendedProtection.PolicyEnforcement); } }
    public System.Security.Authentication.ExtendedProtection.ProtectionScenario ProtectionScenario { get { return default(System.Security.Authentication.ExtendedProtection.ProtectionScenario); } }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, SerializationFormatter=true)]
    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    [System.MonoTODOAttribute]
    public override string ToString() { return default(string); }
  }
  [System.MonoTODOAttribute]
  public partial class ExtendedProtectionPolicyTypeConverter : System.ComponentModel.TypeConverter {
    public ExtendedProtectionPolicyTypeConverter() { }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
  }
  public enum PolicyEnforcement {
    Always = 2,
    Never = 0,
    WhenSupported = 1,
  }
  public enum ProtectionScenario {
    TransportSelected = 0,
    TrustedProxy = 1,
  }
  [System.MonoTODOAttribute]
  public partial class ServiceNameCollection : System.Collections.ReadOnlyCollectionBase {
    public ServiceNameCollection(System.Collections.ICollection items) { }
    public System.Security.Authentication.ExtendedProtection.ServiceNameCollection Merge(System.Collections.IEnumerable serviceNames) { return default(System.Security.Authentication.ExtendedProtection.ServiceNameCollection); }
    public System.Security.Authentication.ExtendedProtection.ServiceNameCollection Merge(string serviceName) { return default(System.Security.Authentication.ExtendedProtection.ServiceNameCollection); }
  }
}
namespace System.Security.Authentication.ExtendedProtection.Configuration {
  [System.MonoTODOAttribute]
  public sealed partial class ExtendedProtectionPolicyElement : System.Configuration.ConfigurationElement {
    public ExtendedProtectionPolicyElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("customServiceNames")]
    public System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElementCollection CustomServiceNames { get { return default(System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElementCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("policyEnforcement")]
    public System.Security.Authentication.ExtendedProtection.PolicyEnforcement PolicyEnforcement { get { return default(System.Security.Authentication.ExtendedProtection.PolicyEnforcement); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("protectionScenario", DefaultValue=(System.Security.Authentication.ExtendedProtection.ProtectionScenario)(0))]
    public System.Security.Authentication.ExtendedProtection.ProtectionScenario ProtectionScenario { get { return default(System.Security.Authentication.ExtendedProtection.ProtectionScenario); } set { } }
    public System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy BuildPolicy() { return default(System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy); }
  }
  public sealed partial class ServiceNameElement : System.Configuration.ConfigurationElement {
    public ServiceNameElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("name")]
    public string Name { get { return default(string); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElement))]
  public sealed partial class ServiceNameElementCollection : System.Configuration.ConfigurationElementCollection {
    public ServiceNameElementCollection() { }
    public System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElement this[int index] { get { return default(System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElement); } }
    public new System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElement this[string name] { get { return default(System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElement); } }
    public void Add(System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElement element) { }
    public void Clear() { }
    protected override System.Configuration.ConfigurationElement CreateNewElement() { return default(System.Configuration.ConfigurationElement); }
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
    public int IndexOf(System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElement element) { return default(int); }
    public void Remove(System.Security.Authentication.ExtendedProtection.Configuration.ServiceNameElement element) { }
    public void Remove(string name) { }
    public void RemoveAt(int index) { }
  }
}
namespace System.Security.Cryptography {
  public partial class AsnEncodedData {
    protected AsnEncodedData() { }
    public AsnEncodedData(System.Byte[] rawData) { }
    public AsnEncodedData(System.Security.Cryptography.AsnEncodedData asnEncodedData) { }
    public AsnEncodedData(System.Security.Cryptography.Oid oid, System.Byte[] rawData) { }
    public AsnEncodedData(string oid, System.Byte[] rawData) { }
    public System.Security.Cryptography.Oid Oid { get { return default(System.Security.Cryptography.Oid); } set { } }
    public System.Byte[] RawData { get { return default(System.Byte[]); } set { } }
    public virtual void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData) { }
    public virtual string Format(bool multiLine) { return default(string); }
  }
  public sealed partial class AsnEncodedDataCollection : System.Collections.ICollection, System.Collections.IEnumerable {
    public AsnEncodedDataCollection() { }
    public AsnEncodedDataCollection(System.Security.Cryptography.AsnEncodedData asnEncodedData) { }
    public int Count { get { return default(int); } }
    public bool IsSynchronized { get { return default(bool); } }
    public System.Security.Cryptography.AsnEncodedData this[int index] { get { return default(System.Security.Cryptography.AsnEncodedData); } }
    public object SyncRoot { get { return default(object); } }
    public int Add(System.Security.Cryptography.AsnEncodedData asnEncodedData) { return default(int); }
    public void CopyTo(System.Security.Cryptography.AsnEncodedData[] array, int index) { }
    public System.Security.Cryptography.AsnEncodedDataEnumerator GetEnumerator() { return default(System.Security.Cryptography.AsnEncodedDataEnumerator); }
    public void Remove(System.Security.Cryptography.AsnEncodedData asnEncodedData) { }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public sealed partial class AsnEncodedDataEnumerator : System.Collections.IEnumerator {
    internal AsnEncodedDataEnumerator() { }
    public System.Security.Cryptography.AsnEncodedData Current { get { return default(System.Security.Cryptography.AsnEncodedData); } }
    object System.Collections.IEnumerator.Current { get { return default(object); } }
    public bool MoveNext() { return default(bool); }
    public void Reset() { }
  }
  public sealed partial class Oid {
    public Oid() { }
    public Oid(System.Security.Cryptography.Oid oid) { }
    public Oid(string oid) { }
    public Oid(string value, string friendlyName) { }
    public string FriendlyName { get { return default(string); } set { } }
    public string Value { get { return default(string); } set { } }
  }
  public sealed partial class OidCollection : System.Collections.ICollection, System.Collections.IEnumerable {
    public OidCollection() { }
    public int Count { get { return default(int); } }
    public bool IsSynchronized { get { return default(bool); } }
    public System.Security.Cryptography.Oid this[int index] { get { return default(System.Security.Cryptography.Oid); } }
    public System.Security.Cryptography.Oid this[string oid] { get { return default(System.Security.Cryptography.Oid); } }
    public object SyncRoot { get { return default(object); } }
    public int Add(System.Security.Cryptography.Oid oid) { return default(int); }
    public void CopyTo(System.Security.Cryptography.Oid[] array, int index) { }
    public System.Security.Cryptography.OidEnumerator GetEnumerator() { return default(System.Security.Cryptography.OidEnumerator); }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public sealed partial class OidEnumerator : System.Collections.IEnumerator {
    internal OidEnumerator() { }
    public System.Security.Cryptography.Oid Current { get { return default(System.Security.Cryptography.Oid); } }
    object System.Collections.IEnumerator.Current { get { return default(object); } }
    public bool MoveNext() { return default(bool); }
    public void Reset() { }
  }
}
namespace System.Security.Cryptography.X509Certificates {
  [System.FlagsAttribute]
  public enum OpenFlags {
    IncludeArchived = 8,
    MaxAllowed = 2,
    OpenExistingOnly = 4,
    ReadOnly = 0,
    ReadWrite = 1,
  }
  public sealed partial class PublicKey {
    public PublicKey(System.Security.Cryptography.Oid oid, System.Security.Cryptography.AsnEncodedData parameters, System.Security.Cryptography.AsnEncodedData keyValue) { }
    public System.Security.Cryptography.AsnEncodedData EncodedKeyValue { get { return default(System.Security.Cryptography.AsnEncodedData); } }
    public System.Security.Cryptography.AsnEncodedData EncodedParameters { get { return default(System.Security.Cryptography.AsnEncodedData); } }
    public System.Security.Cryptography.AsymmetricAlgorithm Key { get { return default(System.Security.Cryptography.AsymmetricAlgorithm); } }
    public System.Security.Cryptography.Oid Oid { get { return default(System.Security.Cryptography.Oid); } }
  }
  public enum StoreLocation {
    CurrentUser = 1,
    LocalMachine = 2,
  }
  public enum StoreName {
    AddressBook = 1,
    AuthRoot = 2,
    CertificateAuthority = 3,
    Disallowed = 4,
    My = 5,
    Root = 6,
    TrustedPeople = 7,
    TrustedPublisher = 8,
  }
  [System.MonoTODOAttribute("Some X500DistinguishedNameFlags options aren't supported, like DoNotUsePlusSign, DoNotUseQuotes and ForceUTF8Encoding")]
  public sealed partial class X500DistinguishedName : System.Security.Cryptography.AsnEncodedData {
    public X500DistinguishedName(System.Byte[] encodedDistinguishedName) { }
    public X500DistinguishedName(System.Security.Cryptography.AsnEncodedData encodedDistinguishedName) { }
    public X500DistinguishedName(System.Security.Cryptography.X509Certificates.X500DistinguishedName distinguishedName) { }
    public X500DistinguishedName(string distinguishedName) { }
    public X500DistinguishedName(string distinguishedName, System.Security.Cryptography.X509Certificates.X500DistinguishedNameFlags flag) { }
    public string Name { get { return default(string); } }
    public string Decode(System.Security.Cryptography.X509Certificates.X500DistinguishedNameFlags flag) { return default(string); }
    public override string Format(bool multiLine) { return default(string); }
  }
  [System.FlagsAttribute]
  public enum X500DistinguishedNameFlags {
    DoNotUsePlusSign = 32,
    DoNotUseQuotes = 64,
    ForceUTF8Encoding = 16384,
    None = 0,
    Reversed = 1,
    UseCommas = 128,
    UseNewLines = 256,
    UseSemicolons = 16,
    UseT61Encoding = 8192,
    UseUTF8Encoding = 4096,
  }
  public sealed partial class X509BasicConstraintsExtension : System.Security.Cryptography.X509Certificates.X509Extension {
    public X509BasicConstraintsExtension() { }
    public X509BasicConstraintsExtension(bool certificateAuthority, bool hasPathLengthConstraint, int pathLengthConstraint, bool critical) { }
    public X509BasicConstraintsExtension(System.Security.Cryptography.AsnEncodedData encodedBasicConstraints, bool critical) { }
    public bool CertificateAuthority { get { return default(bool); } }
    public bool HasPathLengthConstraint { get { return default(bool); } }
    public int PathLengthConstraint { get { return default(int); } }
    public override void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData) { }
  }
  public partial class X509Certificate2 : System.Security.Cryptography.X509Certificates.X509Certificate {
    public X509Certificate2() { }
    public X509Certificate2(System.Byte[] rawData) { }
    public X509Certificate2(System.Byte[] rawData, System.Security.SecureString password) { }
    public X509Certificate2(System.Byte[] rawData, System.Security.SecureString password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags) { }
    public X509Certificate2(System.Byte[] rawData, string password) { }
    public X509Certificate2(System.Byte[] rawData, string password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags) { }
    public X509Certificate2(System.IntPtr handle) { }
    public X509Certificate2(System.Security.Cryptography.X509Certificates.X509Certificate certificate) { }
    public X509Certificate2(string fileName) { }
    public X509Certificate2(string fileName, System.Security.SecureString password) { }
    public X509Certificate2(string fileName, System.Security.SecureString password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags) { }
    public X509Certificate2(string fileName, string password) { }
    public X509Certificate2(string fileName, string password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags) { }
    public bool Archived { get { return default(bool); } set { } }
    public System.Security.Cryptography.X509Certificates.X509ExtensionCollection Extensions { get { return default(System.Security.Cryptography.X509Certificates.X509ExtensionCollection); } }
    public string FriendlyName { get { return default(string); } set { } }
    public bool HasPrivateKey { get { return default(bool); } }
    public System.Security.Cryptography.X509Certificates.X500DistinguishedName IssuerName { get { return default(System.Security.Cryptography.X509Certificates.X500DistinguishedName); } }
    public System.DateTime NotAfter { get { return default(System.DateTime); } }
    public System.DateTime NotBefore { get { return default(System.DateTime); } }
    public System.Security.Cryptography.AsymmetricAlgorithm PrivateKey { get { return default(System.Security.Cryptography.AsymmetricAlgorithm); } set { } }
    public System.Security.Cryptography.X509Certificates.PublicKey PublicKey { get { return default(System.Security.Cryptography.X509Certificates.PublicKey); } }
    public System.Byte[] RawData { get { return default(System.Byte[]); } }
    public string SerialNumber { get { return default(string); } }
    public System.Security.Cryptography.Oid SignatureAlgorithm { get { return default(System.Security.Cryptography.Oid); } }
    public System.Security.Cryptography.X509Certificates.X500DistinguishedName SubjectName { get { return default(System.Security.Cryptography.X509Certificates.X500DistinguishedName); } }
    public string Thumbprint { get { return default(string); } }
    public int Version { get { return default(int); } }
    [System.MonoTODOAttribute("Detection limited to Cert, Pfx, Pkcs12, Pkcs7 and Unknown")]
    public static System.Security.Cryptography.X509Certificates.X509ContentType GetCertContentType(System.Byte[] rawData) { return default(System.Security.Cryptography.X509Certificates.X509ContentType); }
    [System.MonoTODOAttribute("Detection limited to Cert, Pfx, Pkcs12 and Unknown")]
    public static System.Security.Cryptography.X509Certificates.X509ContentType GetCertContentType(string fileName) { return default(System.Security.Cryptography.X509Certificates.X509ContentType); }
    [System.MonoTODOAttribute("always return String.Empty for UpnName, DnsFromAlternativeName and UrlName")]
    public string GetNameInfo(System.Security.Cryptography.X509Certificates.X509NameType nameType, bool forIssuer) { return default(string); }
    public override void Import(System.Byte[] rawData) { }
    [System.MonoTODOAttribute("SecureString is incomplete")]
    public override void Import(System.Byte[] rawData, System.Security.SecureString password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags) { }
    [System.MonoTODOAttribute("missing KeyStorageFlags support")]
    public override void Import(System.Byte[] rawData, string password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags) { }
    public override void Import(string fileName) { }
    [System.MonoTODOAttribute("SecureString is incomplete")]
    public override void Import(string fileName, System.Security.SecureString password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags) { }
    [System.MonoTODOAttribute("missing KeyStorageFlags support")]
    public override void Import(string fileName, string password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags) { }
    public override void Reset() { }
    public override string ToString() { return default(string); }
    public override string ToString(bool verbose) { return default(string); }
    [System.MonoTODOAttribute("by default this depends on the incomplete X509Chain")]
    public bool Verify() { return default(bool); }
  }
  public partial class X509Certificate2Collection : System.Security.Cryptography.X509Certificates.X509CertificateCollection {
    public X509Certificate2Collection() { }
    public X509Certificate2Collection(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
    public X509Certificate2Collection(System.Security.Cryptography.X509Certificates.X509Certificate2[] certificates) { }
    public X509Certificate2Collection(System.Security.Cryptography.X509Certificates.X509Certificate2Collection certificates) { }
    public new System.Security.Cryptography.X509Certificates.X509Certificate2 this[int index] { get { return default(System.Security.Cryptography.X509Certificates.X509Certificate2); } set { } }
    public int Add(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { return default(int); }
    [System.MonoTODOAttribute("Method isn't transactional (like documented)")]
    public void AddRange(System.Security.Cryptography.X509Certificates.X509Certificate2[] certificates) { }
    [System.MonoTODOAttribute("Method isn't transactional (like documented)")]
    public void AddRange(System.Security.Cryptography.X509Certificates.X509Certificate2Collection certificates) { }
    public bool Contains(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { return default(bool); }
    [System.MonoTODOAttribute("only support X509ContentType.Cert")]
    public System.Byte[] Export(System.Security.Cryptography.X509Certificates.X509ContentType contentType) { return default(System.Byte[]); }
    [System.MonoTODOAttribute("only support X509ContentType.Cert")]
    public System.Byte[] Export(System.Security.Cryptography.X509Certificates.X509ContentType contentType, string password) { return default(System.Byte[]); }
    [System.MonoTODOAttribute("Does not support X509FindType.FindByTemplateName, FindByApplicationPolicy and FindByCertificatePolicy")]
    public System.Security.Cryptography.X509Certificates.X509Certificate2Collection Find(System.Security.Cryptography.X509Certificates.X509FindType findType, object findValue, bool validOnly) { return default(System.Security.Cryptography.X509Certificates.X509Certificate2Collection); }
    public new System.Security.Cryptography.X509Certificates.X509Certificate2Enumerator GetEnumerator() { return default(System.Security.Cryptography.X509Certificates.X509Certificate2Enumerator); }
    [System.MonoTODOAttribute("same limitations as X509Certificate2.Import")]
    public void Import(System.Byte[] rawData) { }
    [System.MonoTODOAttribute("same limitations as X509Certificate2.Import")]
    public void Import(System.Byte[] rawData, string password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags) { }
    [System.MonoTODOAttribute("same limitations as X509Certificate2.Import")]
    public void Import(string fileName) { }
    [System.MonoTODOAttribute("same limitations as X509Certificate2.Import")]
    public void Import(string fileName, string password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags) { }
    public void Insert(int index, System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
    public void Remove(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
    [System.MonoTODOAttribute("Method isn't transactional (like documented)")]
    public void RemoveRange(System.Security.Cryptography.X509Certificates.X509Certificate2[] certificates) { }
    [System.MonoTODOAttribute("Method isn't transactional (like documented)")]
    public void RemoveRange(System.Security.Cryptography.X509Certificates.X509Certificate2Collection certificates) { }
  }
  public sealed partial class X509Certificate2Enumerator : System.Collections.IEnumerator {
    internal X509Certificate2Enumerator() { }
    public System.Security.Cryptography.X509Certificates.X509Certificate2 Current { get { return default(System.Security.Cryptography.X509Certificates.X509Certificate2); } }
    object System.Collections.IEnumerator.Current { get { return default(object); } }
    public bool MoveNext() { return default(bool); }
    public void Reset() { }
    bool System.Collections.IEnumerator.MoveNext() { return default(bool); }
    void System.Collections.IEnumerator.Reset() { }
  }
  public partial class X509CertificateCollection : System.Collections.CollectionBase {
    public X509CertificateCollection() { }
    public X509CertificateCollection(System.Security.Cryptography.X509Certificates.X509Certificate[] value) { }
    public X509CertificateCollection(System.Security.Cryptography.X509Certificates.X509CertificateCollection value) { }
    public System.Security.Cryptography.X509Certificates.X509Certificate this[int index] { get { return default(System.Security.Cryptography.X509Certificates.X509Certificate); } set { } }
    public int Add(System.Security.Cryptography.X509Certificates.X509Certificate value) { return default(int); }
    public void AddRange(System.Security.Cryptography.X509Certificates.X509Certificate[] value) { }
    public void AddRange(System.Security.Cryptography.X509Certificates.X509CertificateCollection value) { }
    public bool Contains(System.Security.Cryptography.X509Certificates.X509Certificate value) { return default(bool); }
    public void CopyTo(System.Security.Cryptography.X509Certificates.X509Certificate[] array, int index) { }
    public new System.Security.Cryptography.X509Certificates.X509CertificateCollection.X509CertificateEnumerator GetEnumerator() { return default(System.Security.Cryptography.X509Certificates.X509CertificateCollection.X509CertificateEnumerator); }
    public override int GetHashCode() { return default(int); }
    public int IndexOf(System.Security.Cryptography.X509Certificates.X509Certificate value) { return default(int); }
    public void Insert(int index, System.Security.Cryptography.X509Certificates.X509Certificate value) { }
    public void Remove(System.Security.Cryptography.X509Certificates.X509Certificate value) { }
    public partial class X509CertificateEnumerator : System.Collections.IEnumerator {
      public X509CertificateEnumerator(System.Security.Cryptography.X509Certificates.X509CertificateCollection mappings) { }
      public System.Security.Cryptography.X509Certificates.X509Certificate Current { get { return default(System.Security.Cryptography.X509Certificates.X509Certificate); } }
      object System.Collections.IEnumerator.Current { get { return default(object); } }
      public bool MoveNext() { return default(bool); }
      public void Reset() { }
      bool System.Collections.IEnumerator.MoveNext() { return default(bool); }
      void System.Collections.IEnumerator.Reset() { }
    }
  }
  public partial class X509Chain {
    public X509Chain() { }
    public X509Chain(bool useMachineContext) { }
    [System.MonoTODOAttribute("Mono's X509Chain is fully managed. All handles are invalid.")]
    public X509Chain(System.IntPtr chainContext) { }
    [System.MonoTODOAttribute("Mono's X509Chain is fully managed. Always returns IntPtr.Zero.")]
    public System.IntPtr ChainContext { get { return default(System.IntPtr); } }
    public System.Security.Cryptography.X509Certificates.X509ChainElementCollection ChainElements { get { return default(System.Security.Cryptography.X509Certificates.X509ChainElementCollection); } }
    public System.Security.Cryptography.X509Certificates.X509ChainPolicy ChainPolicy { get { return default(System.Security.Cryptography.X509Certificates.X509ChainPolicy); } set { } }
    public System.Security.Cryptography.X509Certificates.X509ChainStatus[] ChainStatus { get { return default(System.Security.Cryptography.X509Certificates.X509ChainStatus[]); } }
    [System.MonoTODOAttribute("Not totally RFC3280 compliant, but neither is MS implementation...")]
    public bool Build(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { return default(bool); }
    public static System.Security.Cryptography.X509Certificates.X509Chain Create() { return default(System.Security.Cryptography.X509Certificates.X509Chain); }
    public void Reset() { }
  }
  public partial class X509ChainElement {
    internal X509ChainElement() { }
    public System.Security.Cryptography.X509Certificates.X509Certificate2 Certificate { get { return default(System.Security.Cryptography.X509Certificates.X509Certificate2); } }
    public System.Security.Cryptography.X509Certificates.X509ChainStatus[] ChainElementStatus { get { return default(System.Security.Cryptography.X509Certificates.X509ChainStatus[]); } }
    public string Information { get { return default(string); } }
  }
  public sealed partial class X509ChainElementCollection : System.Collections.ICollection, System.Collections.IEnumerable {
    internal X509ChainElementCollection() { }
    public int Count { get { return default(int); } }
    public bool IsSynchronized { get { return default(bool); } }
    public System.Security.Cryptography.X509Certificates.X509ChainElement this[int index] { get { return default(System.Security.Cryptography.X509Certificates.X509ChainElement); } }
    public object SyncRoot { get { return default(object); } }
    public void CopyTo(System.Security.Cryptography.X509Certificates.X509ChainElement[] array, int index) { }
    public System.Security.Cryptography.X509Certificates.X509ChainElementEnumerator GetEnumerator() { return default(System.Security.Cryptography.X509Certificates.X509ChainElementEnumerator); }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public sealed partial class X509ChainElementEnumerator : System.Collections.IEnumerator {
    internal X509ChainElementEnumerator() { }
    public System.Security.Cryptography.X509Certificates.X509ChainElement Current { get { return default(System.Security.Cryptography.X509Certificates.X509ChainElement); } }
    object System.Collections.IEnumerator.Current { get { return default(object); } }
    public bool MoveNext() { return default(bool); }
    public void Reset() { }
  }
  public sealed partial class X509ChainPolicy {
    public X509ChainPolicy() { }
    public System.Security.Cryptography.OidCollection ApplicationPolicy { get { return default(System.Security.Cryptography.OidCollection); } }
    public System.Security.Cryptography.OidCollection CertificatePolicy { get { return default(System.Security.Cryptography.OidCollection); } }
    public System.Security.Cryptography.X509Certificates.X509Certificate2Collection ExtraStore { get { return default(System.Security.Cryptography.X509Certificates.X509Certificate2Collection); } }
    public System.Security.Cryptography.X509Certificates.X509RevocationFlag RevocationFlag { get { return default(System.Security.Cryptography.X509Certificates.X509RevocationFlag); } set { } }
    public System.Security.Cryptography.X509Certificates.X509RevocationMode RevocationMode { get { return default(System.Security.Cryptography.X509Certificates.X509RevocationMode); } set { } }
    public System.TimeSpan UrlRetrievalTimeout { get { return default(System.TimeSpan); } set { } }
    public System.Security.Cryptography.X509Certificates.X509VerificationFlags VerificationFlags { get { return default(System.Security.Cryptography.X509Certificates.X509VerificationFlags); } set { } }
    public System.DateTime VerificationTime { get { return default(System.DateTime); } set { } }
    public void Reset() { }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct X509ChainStatus {
    public System.Security.Cryptography.X509Certificates.X509ChainStatusFlags Status { get { return default(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags); } set { } }
    public string StatusInformation { get { return default(string); } set { } }
  }
  [System.FlagsAttribute]
  public enum X509ChainStatusFlags {
    CtlNotSignatureValid = 262144,
    CtlNotTimeValid = 131072,
    CtlNotValidForUsage = 524288,
    Cyclic = 128,
    HasExcludedNameConstraint = 32768,
    HasNotDefinedNameConstraint = 8192,
    HasNotPermittedNameConstraint = 16384,
    HasNotSupportedNameConstraint = 4096,
    InvalidBasicConstraints = 1024,
    InvalidExtension = 256,
    InvalidNameConstraints = 2048,
    InvalidPolicyConstraints = 512,
    NoError = 0,
    NoIssuanceChainPolicy = 33554432,
    NotSignatureValid = 8,
    NotTimeNested = 2,
    NotTimeValid = 1,
    NotValidForUsage = 16,
    OfflineRevocation = 16777216,
    PartialChain = 65536,
    RevocationStatusUnknown = 64,
    Revoked = 4,
    UntrustedRoot = 32,
  }
  public sealed partial class X509EnhancedKeyUsageExtension : System.Security.Cryptography.X509Certificates.X509Extension {
    public X509EnhancedKeyUsageExtension() { }
    public X509EnhancedKeyUsageExtension(System.Security.Cryptography.AsnEncodedData encodedEnhancedKeyUsages, bool critical) { }
    public X509EnhancedKeyUsageExtension(System.Security.Cryptography.OidCollection enhancedKeyUsages, bool critical) { }
    public System.Security.Cryptography.OidCollection EnhancedKeyUsages { get { return default(System.Security.Cryptography.OidCollection); } }
    public override void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData) { }
  }
  public partial class X509Extension : System.Security.Cryptography.AsnEncodedData {
    protected X509Extension() { }
    public X509Extension(System.Security.Cryptography.AsnEncodedData encodedExtension, bool critical) { }
    public X509Extension(System.Security.Cryptography.Oid oid, System.Byte[] rawData, bool critical) { }
    public X509Extension(string oid, System.Byte[] rawData, bool critical) { }
    public bool Critical { get { return default(bool); } set { } }
    public override void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData) { }
  }
  public sealed partial class X509ExtensionCollection : System.Collections.ICollection, System.Collections.IEnumerable {
    public X509ExtensionCollection() { }
    public int Count { get { return default(int); } }
    public bool IsSynchronized { get { return default(bool); } }
    public System.Security.Cryptography.X509Certificates.X509Extension this[int index] { get { return default(System.Security.Cryptography.X509Certificates.X509Extension); } }
    public System.Security.Cryptography.X509Certificates.X509Extension this[string oid] { get { return default(System.Security.Cryptography.X509Certificates.X509Extension); } }
    public object SyncRoot { get { return default(object); } }
    public int Add(System.Security.Cryptography.X509Certificates.X509Extension extension) { return default(int); }
    public void CopyTo(System.Security.Cryptography.X509Certificates.X509Extension[] array, int index) { }
    public System.Security.Cryptography.X509Certificates.X509ExtensionEnumerator GetEnumerator() { return default(System.Security.Cryptography.X509Certificates.X509ExtensionEnumerator); }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public sealed partial class X509ExtensionEnumerator : System.Collections.IEnumerator {
    internal X509ExtensionEnumerator() { }
    public System.Security.Cryptography.X509Certificates.X509Extension Current { get { return default(System.Security.Cryptography.X509Certificates.X509Extension); } }
    object System.Collections.IEnumerator.Current { get { return default(object); } }
    public bool MoveNext() { return default(bool); }
    public void Reset() { }
  }
  public enum X509FindType {
    FindByApplicationPolicy = 10,
    FindByCertificatePolicy = 11,
    FindByExtension = 12,
    FindByIssuerDistinguishedName = 4,
    FindByIssuerName = 3,
    FindByKeyUsage = 13,
    FindBySerialNumber = 5,
    FindBySubjectDistinguishedName = 2,
    FindBySubjectKeyIdentifier = 14,
    FindBySubjectName = 1,
    FindByTemplateName = 9,
    FindByThumbprint = 0,
    FindByTimeExpired = 8,
    FindByTimeNotYetValid = 7,
    FindByTimeValid = 6,
  }
  public enum X509IncludeOption {
    EndCertOnly = 2,
    ExcludeRoot = 1,
    None = 0,
    WholeChain = 3,
  }
  public sealed partial class X509KeyUsageExtension : System.Security.Cryptography.X509Certificates.X509Extension {
    public X509KeyUsageExtension() { }
    public X509KeyUsageExtension(System.Security.Cryptography.AsnEncodedData encodedKeyUsage, bool critical) { }
    public X509KeyUsageExtension(System.Security.Cryptography.X509Certificates.X509KeyUsageFlags keyUsages, bool critical) { }
    public System.Security.Cryptography.X509Certificates.X509KeyUsageFlags KeyUsages { get { return default(System.Security.Cryptography.X509Certificates.X509KeyUsageFlags); } }
    public override void CopyFrom(System.Security.Cryptography.AsnEncodedData encodedData) { }
  }
  [System.FlagsAttribute]
  public enum X509KeyUsageFlags {
    CrlSign = 2,
    DataEncipherment = 16,
    DecipherOnly = 32768,
    DigitalSignature = 128,
    EncipherOnly = 1,
    KeyAgreement = 8,
    KeyCertSign = 4,
    KeyEncipherment = 32,
    None = 0,
    NonRepudiation = 64,
  }
  public enum X509NameType {
    DnsFromAlternativeName = 4,
    DnsName = 3,
    EmailName = 1,
    SimpleName = 0,
    UpnName = 2,
    UrlName = 5,
  }
  public enum X509RevocationFlag {
    EndCertificateOnly = 0,
    EntireChain = 1,
    ExcludeRoot = 2,
  }
  public enum X509RevocationMode {
    NoCheck = 0,
    Offline = 2,
    Online = 1,
  }
  public sealed partial class X509Store {
    public X509Store() { }
    [System.MonoTODOAttribute("Mono's stores are fully managed. All handles are invalid.")]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, UnmanagedCode=true)]
    public X509Store(System.IntPtr storeHandle) { }
    public X509Store(System.Security.Cryptography.X509Certificates.StoreLocation storeLocation) { }
    public X509Store(System.Security.Cryptography.X509Certificates.StoreName storeName) { }
    public X509Store(System.Security.Cryptography.X509Certificates.StoreName storeName, System.Security.Cryptography.X509Certificates.StoreLocation storeLocation) { }
    public X509Store(string storeName) { }
    public X509Store(string storeName, System.Security.Cryptography.X509Certificates.StoreLocation storeLocation) { }
    public System.Security.Cryptography.X509Certificates.X509Certificate2Collection Certificates { get { return default(System.Security.Cryptography.X509Certificates.X509Certificate2Collection); } }
    public System.Security.Cryptography.X509Certificates.StoreLocation Location { get { return default(System.Security.Cryptography.X509Certificates.StoreLocation); } }
    public string Name { get { return default(string); } }
    [System.MonoTODOAttribute("Mono's stores are fully managed. Always returns IntPtr.Zero.")]
    public System.IntPtr StoreHandle { get { return default(System.IntPtr); } }
    public void Add(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
    [System.MonoTODOAttribute("Method isn't transactional (like documented)")]
    public void AddRange(System.Security.Cryptography.X509Certificates.X509Certificate2Collection certificates) { }
    public void Close() { }
    public void Open(System.Security.Cryptography.X509Certificates.OpenFlags flags) { }
    public void Remove(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
    [System.MonoTODOAttribute("Method isn't transactional (like documented)")]
    public void RemoveRange(System.Security.Cryptography.X509Certificates.X509Certificate2Collection certificates) { }
  }
  public sealed partial class X509SubjectKeyIdentifierExtension : System.Security.Cryptography.X509Certificates.X509Extension {
    public X509SubjectKeyIdentifierExtension() { }
    public X509SubjectKeyIdentifierExtension(System.Byte[] subjectKeyIdentifier, bool critical) { }
    public X509SubjectKeyIdentifierExtension(System.Security.Cryptography.AsnEncodedData encodedSubjectKeyIdentifier, bool critical) { }
    public X509SubjectKeyIdentifierExtension(System.Security.Cryptography.X509Certificates.PublicKey key, bool critical) { }
    public X509SubjectKeyIdentifierExtension(System.Security.Cryptography.X509Certificates.PublicKey key, System.Security.Cryptography.X509Certificates.X509SubjectKeyIdentifierHashAlgorithm algorithm, bool critical) { }
    public X509SubjectKeyIdentifierExtension(string subjectKeyIdentifier, bool critical) { }
    public string SubjectKeyIdentifier { get { return default(string); } }
    public override void CopyFrom(System.Security.Cryptography.AsnEncodedData encodedData) { }
  }
  public enum X509SubjectKeyIdentifierHashAlgorithm {
    CapiSha1 = 2,
    Sha1 = 0,
    ShortSha1 = 1,
  }
  [System.FlagsAttribute]
  public enum X509VerificationFlags {
    AllFlags = 4095,
    AllowUnknownCertificateAuthority = 16,
    IgnoreCertificateAuthorityRevocationUnknown = 1024,
    IgnoreCtlNotTimeValid = 2,
    IgnoreCtlSignerRevocationUnknown = 512,
    IgnoreEndRevocationUnknown = 256,
    IgnoreInvalidBasicConstraints = 8,
    IgnoreInvalidName = 64,
    IgnoreInvalidPolicy = 128,
    IgnoreNotTimeNested = 4,
    IgnoreNotTimeValid = 1,
    IgnoreRootRevocationUnknown = 2048,
    IgnoreWrongUsage = 32,
    NoFlag = 0,
  }
}
namespace System.Security.Permissions {
  public abstract partial class ResourcePermissionBase : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission {
    public const string Any = "*";
    public const string Local = ".";
    protected ResourcePermissionBase() { }
    protected ResourcePermissionBase(System.Security.Permissions.PermissionState state) { }
    protected System.Type PermissionAccessType { get { return default(System.Type); } set { } }
    protected System.String[] TagNames { get { return default(System.String[]); } set { } }
    protected void AddPermissionAccess(System.Security.Permissions.ResourcePermissionBaseEntry entry) { }
    protected void Clear() { }
    public override System.Security.IPermission Copy() { return default(System.Security.IPermission); }
    [System.MonoTODOAttribute("incomplete - need more test")]
    public override void FromXml(System.Security.SecurityElement securityElement) { }
    protected System.Security.Permissions.ResourcePermissionBaseEntry[] GetPermissionEntries() { return default(System.Security.Permissions.ResourcePermissionBaseEntry[]); }
    public override System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
    public override bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
    public bool IsUnrestricted() { return default(bool); }
    protected void RemovePermissionAccess(System.Security.Permissions.ResourcePermissionBaseEntry entry) { }
    public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
    public override System.Security.IPermission Union(System.Security.IPermission target) { return default(System.Security.IPermission); }
  }
  public partial class ResourcePermissionBaseEntry {
    public ResourcePermissionBaseEntry() { }
    public ResourcePermissionBaseEntry(int permissionAccess, System.String[] permissionAccessPath) { }
    public int PermissionAccess { get { return default(int); } }
    public System.String[] PermissionAccessPath { get { return default(System.String[]); } }
  }
  public sealed partial class StorePermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission {
    public StorePermission(System.Security.Permissions.PermissionState state) { }
    public StorePermission(System.Security.Permissions.StorePermissionFlags flags) { }
    public System.Security.Permissions.StorePermissionFlags Flags { get { return default(System.Security.Permissions.StorePermissionFlags); } set { } }
    public override System.Security.IPermission Copy() { return default(System.Security.IPermission); }
    public override void FromXml(System.Security.SecurityElement e) { }
    public override System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
    public override bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
    public bool IsUnrestricted() { return default(bool); }
    public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
    public override System.Security.IPermission Union(System.Security.IPermission target) { return default(System.Security.IPermission); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
  public sealed partial class StorePermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute {
    public StorePermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
    public bool AddToStore { get { return default(bool); } set { } }
    public bool CreateStore { get { return default(bool); } set { } }
    public bool DeleteStore { get { return default(bool); } set { } }
    public bool EnumerateCertificates { get { return default(bool); } set { } }
    public bool EnumerateStores { get { return default(bool); } set { } }
    public System.Security.Permissions.StorePermissionFlags Flags { get { return default(System.Security.Permissions.StorePermissionFlags); } set { } }
    public bool OpenStore { get { return default(bool); } set { } }
    public bool RemoveFromStore { get { return default(bool); } set { } }
    public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
  }
  [System.FlagsAttribute]
  public enum StorePermissionFlags {
    AddToStore = 32,
    AllFlags = 247,
    CreateStore = 1,
    DeleteStore = 2,
    EnumerateCertificates = 128,
    EnumerateStores = 4,
    NoFlags = 0,
    OpenStore = 16,
    RemoveFromStore = 64,
  }
}
namespace System.Text.RegularExpressions {
  public partial class Capture {
    internal Capture() { }
    public int Index { get { return default(int); } }
    public int Length { get { return default(int); } }
    public string Value { get { return default(string); } }
    public override string ToString() { return default(string); }
  }
  public partial class CaptureCollection : System.Collections.ICollection, System.Collections.IEnumerable {
    internal CaptureCollection() { }
    public int Count { get { return default(int); } }
    public bool IsReadOnly { get { return default(bool); } }
    public bool IsSynchronized { get { return default(bool); } }
    public System.Text.RegularExpressions.Capture this[int i] { get { return default(System.Text.RegularExpressions.Capture); } }
    public object SyncRoot { get { return default(object); } }
    public void CopyTo(System.Array array, int arrayIndex) { }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public partial class Group : System.Text.RegularExpressions.Capture {
    internal Group() { }
    public System.Text.RegularExpressions.CaptureCollection Captures { get { return default(System.Text.RegularExpressions.CaptureCollection); } }
    public bool Success { get { return default(bool); } }
    [System.MonoTODOAttribute("not thread-safe")]
    public static System.Text.RegularExpressions.Group Synchronized(System.Text.RegularExpressions.Group inner) { return default(System.Text.RegularExpressions.Group); }
  }
  public partial class GroupCollection : System.Collections.ICollection, System.Collections.IEnumerable {
    internal GroupCollection() { }
    public int Count { get { return default(int); } }
    public bool IsReadOnly { get { return default(bool); } }
    public bool IsSynchronized { get { return default(bool); } }
    public System.Text.RegularExpressions.Group this[int groupnum] { get { return default(System.Text.RegularExpressions.Group); } }
    public System.Text.RegularExpressions.Group this[string groupName] { get { return default(System.Text.RegularExpressions.Group); } }
    public object SyncRoot { get { return default(object); } }
    public void CopyTo(System.Array array, int arrayIndex) { }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public partial class Match : System.Text.RegularExpressions.Group {
    internal Match() { }
    public static System.Text.RegularExpressions.Match Empty { get { return default(System.Text.RegularExpressions.Match); } }
    public virtual System.Text.RegularExpressions.GroupCollection Groups { get { return default(System.Text.RegularExpressions.GroupCollection); } }
    public System.Text.RegularExpressions.Match NextMatch() { return default(System.Text.RegularExpressions.Match); }
    public virtual string Result(string replacement) { return default(string); }
    [System.MonoTODOAttribute("not thread-safe")]
    public static System.Text.RegularExpressions.Match Synchronized(System.Text.RegularExpressions.Match inner) { return default(System.Text.RegularExpressions.Match); }
  }
  public partial class MatchCollection : System.Collections.ICollection, System.Collections.IEnumerable {
    internal MatchCollection() { }
    public int Count { get { return default(int); } }
    public bool IsReadOnly { get { return default(bool); } }
    public bool IsSynchronized { get { return default(bool); } }
    public virtual System.Text.RegularExpressions.Match this[int i] { get { return default(System.Text.RegularExpressions.Match); } }
    public object SyncRoot { get { return default(object); } }
    public void CopyTo(System.Array array, int arrayIndex) { }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public delegate string MatchEvaluator(System.Text.RegularExpressions.Match match);
  public partial class Regex : System.Runtime.Serialization.ISerializable {
    [System.MonoTODOAttribute]
    protected internal System.Collections.Hashtable capnames;
    [System.MonoTODOAttribute]
    protected internal System.Collections.Hashtable caps;
    [System.MonoTODOAttribute]
    protected internal int capsize;
    [System.MonoTODOAttribute]
    protected internal System.String[] capslist;
    [System.MonoTODOAttribute]
    protected internal System.Text.RegularExpressions.RegexRunnerFactory factory;
    protected internal string pattern;
    protected internal System.Text.RegularExpressions.RegexOptions roptions;
    protected Regex() { }
    protected Regex(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public Regex(string pattern) { }
    public Regex(string pattern, System.Text.RegularExpressions.RegexOptions options) { }
    public static int CacheSize { get { return default(int); } set { } }
    public System.Text.RegularExpressions.RegexOptions Options { get { return default(System.Text.RegularExpressions.RegexOptions); } }
    public bool RightToLeft { get { return default(bool); } }
    [System.MonoTODOAttribute]
    public static void CompileToAssembly(System.Text.RegularExpressions.RegexCompilationInfo[] regexes, System.Reflection.AssemblyName aname) { }
    [System.MonoTODOAttribute]
    public static void CompileToAssembly(System.Text.RegularExpressions.RegexCompilationInfo[] regexes, System.Reflection.AssemblyName aname, System.Reflection.Emit.CustomAttributeBuilder[] attribs) { }
    [System.MonoTODOAttribute]
    public static void CompileToAssembly(System.Text.RegularExpressions.RegexCompilationInfo[] regexes, System.Reflection.AssemblyName aname, System.Reflection.Emit.CustomAttributeBuilder[] attribs, string resourceFile) { }
    public static string Escape(string str) { return default(string); }
    public System.String[] GetGroupNames() { return default(System.String[]); }
    public System.Int32[] GetGroupNumbers() { return default(System.Int32[]); }
    public string GroupNameFromNumber(int i) { return default(string); }
    public int GroupNumberFromName(string name) { return default(int); }
    protected void InitializeReferences() { }
    public bool IsMatch(string input) { return default(bool); }
    public bool IsMatch(string input, int startat) { return default(bool); }
    public static bool IsMatch(string input, string pattern) { return default(bool); }
    public static bool IsMatch(string input, string pattern, System.Text.RegularExpressions.RegexOptions options) { return default(bool); }
    public System.Text.RegularExpressions.Match Match(string input) { return default(System.Text.RegularExpressions.Match); }
    public System.Text.RegularExpressions.Match Match(string input, int startat) { return default(System.Text.RegularExpressions.Match); }
    public System.Text.RegularExpressions.Match Match(string input, int beginning, int length) { return default(System.Text.RegularExpressions.Match); }
    public static System.Text.RegularExpressions.Match Match(string input, string pattern) { return default(System.Text.RegularExpressions.Match); }
    public static System.Text.RegularExpressions.Match Match(string input, string pattern, System.Text.RegularExpressions.RegexOptions options) { return default(System.Text.RegularExpressions.Match); }
    public System.Text.RegularExpressions.MatchCollection Matches(string input) { return default(System.Text.RegularExpressions.MatchCollection); }
    public System.Text.RegularExpressions.MatchCollection Matches(string input, int startat) { return default(System.Text.RegularExpressions.MatchCollection); }
    public static System.Text.RegularExpressions.MatchCollection Matches(string input, string pattern) { return default(System.Text.RegularExpressions.MatchCollection); }
    public static System.Text.RegularExpressions.MatchCollection Matches(string input, string pattern, System.Text.RegularExpressions.RegexOptions options) { return default(System.Text.RegularExpressions.MatchCollection); }
    public string Replace(string input, string replacement) { return default(string); }
    public string Replace(string input, string replacement, int count) { return default(string); }
    public string Replace(string input, string replacement, int count, int startat) { return default(string); }
    public static string Replace(string input, string pattern, string replacement) { return default(string); }
    public static string Replace(string input, string pattern, string replacement, System.Text.RegularExpressions.RegexOptions options) { return default(string); }
    public static string Replace(string input, string pattern, System.Text.RegularExpressions.MatchEvaluator evaluator) { return default(string); }
    public static string Replace(string input, string pattern, System.Text.RegularExpressions.MatchEvaluator evaluator, System.Text.RegularExpressions.RegexOptions options) { return default(string); }
    public string Replace(string input, System.Text.RegularExpressions.MatchEvaluator evaluator) { return default(string); }
    public string Replace(string input, System.Text.RegularExpressions.MatchEvaluator evaluator, int count) { return default(string); }
    public string Replace(string input, System.Text.RegularExpressions.MatchEvaluator evaluator, int count, int startat) { return default(string); }
    public System.String[] Split(string input) { return default(System.String[]); }
    public System.String[] Split(string input, int count) { return default(System.String[]); }
    public System.String[] Split(string input, int count, int startat) { return default(System.String[]); }
    public static System.String[] Split(string input, string pattern) { return default(System.String[]); }
    public static System.String[] Split(string input, string pattern, System.Text.RegularExpressions.RegexOptions options) { return default(System.String[]); }
    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public override string ToString() { return default(string); }
    public static string Unescape(string str) { return default(string); }
    protected bool UseOptionC() { return default(bool); }
    protected bool UseOptionR() { return default(bool); }
  }
  public partial class RegexCompilationInfo {
    public RegexCompilationInfo(string pattern, System.Text.RegularExpressions.RegexOptions options, string name, string fullnamespace, bool ispublic) { }
    public bool IsPublic { get { return default(bool); } set { } }
    public string Name { get { return default(string); } set { } }
    public string Namespace { get { return default(string); } set { } }
    public System.Text.RegularExpressions.RegexOptions Options { get { return default(System.Text.RegularExpressions.RegexOptions); } set { } }
    public string Pattern { get { return default(string); } set { } }
  }
  [System.FlagsAttribute]
  public enum RegexOptions {
    Compiled = 8,
    CultureInvariant = 512,
    ECMAScript = 256,
    ExplicitCapture = 4,
    IgnoreCase = 1,
    IgnorePatternWhitespace = 32,
    Multiline = 2,
    None = 0,
    RightToLeft = 64,
    Singleline = 16,
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.MonoTODOAttribute("RegexRunner is not supported by Mono.")]
  public abstract partial class RegexRunner {
    [System.MonoTODOAttribute]
    protected internal System.Int32[] runcrawl;
    [System.MonoTODOAttribute]
    protected internal int runcrawlpos;
    [System.MonoTODOAttribute]
    protected internal System.Text.RegularExpressions.Match runmatch;
    [System.MonoTODOAttribute]
    protected internal System.Text.RegularExpressions.Regex runregex;
    [System.MonoTODOAttribute]
    protected internal System.Int32[] runstack;
    [System.MonoTODOAttribute]
    protected internal int runstackpos;
    [System.MonoTODOAttribute]
    protected internal string runtext;
    [System.MonoTODOAttribute]
    protected internal int runtextbeg;
    [System.MonoTODOAttribute]
    protected internal int runtextend;
    [System.MonoTODOAttribute]
    protected internal int runtextpos;
    [System.MonoTODOAttribute]
    protected internal int runtextstart;
    [System.MonoTODOAttribute]
    protected internal System.Int32[] runtrack;
    [System.MonoTODOAttribute]
    protected internal int runtrackcount;
    [System.MonoTODOAttribute]
    protected internal int runtrackpos;
    [System.MonoTODOAttribute]
    protected internal RegexRunner() { }
    [System.MonoTODOAttribute]
    protected void Capture(int capnum, int start, int end) { }
    [System.MonoTODOAttribute]
    protected static bool CharInClass(char ch, string charClass) { return default(bool); }
    [System.MonoTODOAttribute]
    protected static bool CharInSet(char ch, string @set, string category) { return default(bool); }
    [System.MonoTODOAttribute]
    protected void Crawl(int i) { }
    [System.MonoTODOAttribute]
    protected int Crawlpos() { return default(int); }
    [System.MonoTODOAttribute]
    protected void DoubleCrawl() { }
    [System.MonoTODOAttribute]
    protected void DoubleStack() { }
    [System.MonoTODOAttribute]
    protected void DoubleTrack() { }
    [System.MonoTODOAttribute]
    protected void EnsureStorage() { }
    protected abstract bool FindFirstChar();
    protected abstract void Go();
    protected abstract void InitTrackCount();
    [System.MonoTODOAttribute]
    protected bool IsBoundary(int index, int startpos, int endpos) { return default(bool); }
    [System.MonoTODOAttribute]
    protected bool IsECMABoundary(int index, int startpos, int endpos) { return default(bool); }
    [System.MonoTODOAttribute]
    protected bool IsMatched(int cap) { return default(bool); }
    [System.MonoTODOAttribute]
    protected int MatchIndex(int cap) { return default(int); }
    [System.MonoTODOAttribute]
    protected int MatchLength(int cap) { return default(int); }
    [System.MonoTODOAttribute]
    protected int Popcrawl() { return default(int); }
    protected internal System.Text.RegularExpressions.Match Scan(System.Text.RegularExpressions.Regex regex, string text, int textbeg, int textend, int textstart, int prevlen, bool quick) { return default(System.Text.RegularExpressions.Match); }
    [System.MonoTODOAttribute]
    protected void TransferCapture(int capnum, int uncapnum, int start, int end) { }
    [System.MonoTODOAttribute]
    protected void Uncapture() { }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public abstract partial class RegexRunnerFactory {
    protected RegexRunnerFactory() { }
    protected internal abstract System.Text.RegularExpressions.RegexRunner CreateInstance();
  }
}
namespace System.Threading {
  [System.Diagnostics.DebuggerDisplayAttribute("Participant Count={ParticipantCount},Participants Remaining={ParticipantsRemaining}")]
  public partial class Barrier : System.IDisposable {
    public Barrier(int participantCount) { }
    public Barrier(int participantCount, System.Action<System.Threading.Barrier> postPhaseAction) { }
    public long CurrentPhaseNumber { get { return default(long); } }
    public int ParticipantCount { get { return default(int); } }
    [System.MonoTODOAttribute]
    public int ParticipantsRemaining { get { return default(int); } }
    public long AddParticipant() { return default(long); }
    public long AddParticipants(int participantCount) { return default(long); }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public void RemoveParticipant() { }
    public void RemoveParticipants(int participantCount) { }
    public void SignalAndWait() { }
    public bool SignalAndWait(int millisecondsTimeout) { return default(bool); }
    public bool SignalAndWait(int millisecondsTimeout, System.Threading.CancellationToken cancellationToken) { return default(bool); }
    public void SignalAndWait(System.Threading.CancellationToken cancellationToken) { }
    public bool SignalAndWait(System.TimeSpan timeout) { return default(bool); }
    public bool SignalAndWait(System.TimeSpan timeout, System.Threading.CancellationToken cancellationToken) { return default(bool); }
  }
  public partial class BarrierPostPhaseException : System.Exception {
    public BarrierPostPhaseException() { }
    public BarrierPostPhaseException(System.Exception innerException) { }
    protected BarrierPostPhaseException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public BarrierPostPhaseException(string message) { }
    public BarrierPostPhaseException(string message, System.Exception innerException) { }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public sealed partial class Semaphore : System.Threading.WaitHandle {
    public Semaphore(int initialCount, int maximumCount) { }
    public Semaphore(int initialCount, int maximumCount, string name) { }
    public Semaphore(int initialCount, int maximumCount, string name, out bool createdNew) { createdNew = default(bool); }
    [System.MonoTODOAttribute("CreateSemaphore_internal does not support access control, semaphoreSecurity is ignored")]
    public Semaphore(int initialCount, int maximumCount, string name, out bool createdNew, System.Security.AccessControl.SemaphoreSecurity semaphoreSecurity) { createdNew = default(bool); }
    public System.Security.AccessControl.SemaphoreSecurity GetAccessControl() { return default(System.Security.AccessControl.SemaphoreSecurity); }
    public static System.Threading.Semaphore OpenExisting(string name) { return default(System.Threading.Semaphore); }
    public static System.Threading.Semaphore OpenExisting(string name, System.Security.AccessControl.SemaphoreRights rights) { return default(System.Threading.Semaphore); }
    [System.Runtime.ConstrainedExecution.PrePrepareMethodAttribute]
    [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(2))]
    public int Release() { return default(int); }
    [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(2))]
    public int Release(int releaseCount) { return default(int); }
    public void SetAccessControl(System.Security.AccessControl.SemaphoreSecurity semaphoreSecurity) { }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
    public static bool TryOpenExisting(string name, System.Security.AccessControl.SemaphoreRights rights, out System.Threading.Semaphore result) { result = default(System.Threading.Semaphore); return default(bool); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
    public static bool TryOpenExisting(string name, out System.Threading.Semaphore result) { result = default(System.Threading.Semaphore); return default(bool); }
  }
  public partial class ThreadExceptionEventArgs : System.EventArgs {
    public ThreadExceptionEventArgs(System.Exception t) { }
    public System.Exception Exception { get { return default(System.Exception); } }
  }
  public delegate void ThreadExceptionEventHandler(object sender, System.Threading.ThreadExceptionEventArgs e);
}
namespace System.Timers {
  public partial class ElapsedEventArgs : System.EventArgs {
    internal ElapsedEventArgs() { }
    public System.DateTime SignalTime { get { return default(System.DateTime); } }
  }
  public delegate void ElapsedEventHandler(object sender, System.Timers.ElapsedEventArgs e);
  [System.ComponentModel.DefaultEventAttribute("Elapsed")]
  [System.ComponentModel.DefaultPropertyAttribute("Interval")]
  public partial class Timer : System.ComponentModel.Component, System.ComponentModel.ISupportInitialize {
    public Timer() { }
    public Timer(double interval) { }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Timers.TimersDescriptionAttribute("Indicates whether the timer will be restarted when it is enabled.")]
    public bool AutoReset { get { return default(bool); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Timers.TimersDescriptionAttribute("Indicates whether the timer is enabled to fire events at a defined interval.")]
    public bool Enabled { get { return default(bool); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(100)]
    [System.ComponentModel.RecommendedAsConfigurableAttribute(true)]
    [System.Timers.TimersDescriptionAttribute("The number of milliseconds between timer events.")]
    public double Interval { get { return default(double); } set { } }
    public override System.ComponentModel.ISite Site { get { return default(System.ComponentModel.ISite); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Timers.TimersDescriptionAttribute("The object used to marshal the event handler calls issued when an interval has elapsed.")]
    public System.ComponentModel.ISynchronizeInvoke SynchronizingObject { get { return default(System.ComponentModel.ISynchronizeInvoke); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.Timers.TimersDescriptionAttribute("Occurs when the Interval has elapsed.")]
    public event System.Timers.ElapsedEventHandler Elapsed { add { } remove { } }
    public void BeginInit() { }
    public void Close() { }
    protected override void Dispose(bool disposing) { }
    public void EndInit() { }
    public void Start() { }
    public void Stop() { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(32767))]
  public partial class TimersDescriptionAttribute : System.ComponentModel.DescriptionAttribute {
    public TimersDescriptionAttribute(string description) { }
    public override string Description { get { return default(string); } }
  }
}
namespace System.Web {
  public sealed partial class AspNetHostingPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission {
    public AspNetHostingPermission(System.Security.Permissions.PermissionState state) { }
    public AspNetHostingPermission(System.Web.AspNetHostingPermissionLevel level) { }
    public System.Web.AspNetHostingPermissionLevel Level { get { return default(System.Web.AspNetHostingPermissionLevel); } set { } }
    public override System.Security.IPermission Copy() { return default(System.Security.IPermission); }
    public override void FromXml(System.Security.SecurityElement securityElement) { }
    public override System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
    public override bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
    public bool IsUnrestricted() { return default(bool); }
    public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
    public override System.Security.IPermission Union(System.Security.IPermission target) { return default(System.Security.IPermission); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true, Inherited=false)]
  public sealed partial class AspNetHostingPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute {
    public AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
    public System.Web.AspNetHostingPermissionLevel Level { get { return default(System.Web.AspNetHostingPermissionLevel); } set { } }
    public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
  }
  public enum AspNetHostingPermissionLevel {
    High = 500,
    Low = 300,
    Medium = 400,
    Minimal = 200,
    None = 100,
    Unrestricted = 600,
  }
}
