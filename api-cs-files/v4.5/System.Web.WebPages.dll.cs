namespace System.Web.Helpers {
  public static partial class AntiForgery {
    public static System.Web.HtmlString GetHtml() { return default(System.Web.HtmlString); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This method is deprecated. Use the GetHtml() method instead. To specify a custom domain for the generated cookie, use the <httpCookies> configuration element. To specify custom data to be embedded within the token, use the static AntiForgeryConfig.AdditionalDataProvider property.", true)]
    public static System.Web.HtmlString GetHtml(System.Web.HttpContextBase httpContext, string salt, string domain, string path) { return default(System.Web.HtmlString); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static void GetTokens(string oldCookieToken, out string newCookieToken, out string formToken) { newCookieToken = default(string); formToken = default(string); }
    public static void Validate() { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static void Validate(string cookieToken, string formToken) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This method is deprecated. Use the Validate() method instead.", true)]
    public static void Validate(System.Web.HttpContextBase httpContext, string salt) { }
  }
  public static partial class AntiForgeryConfig {
    public static System.Web.Helpers.IAntiForgeryAdditionalDataProvider AdditionalDataProvider { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Helpers.IAntiForgeryAdditionalDataProvider); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public static string CookieName { get { return default(string); } set { } }
    public static bool RequireSsl { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public static bool SuppressIdentityHeuristicChecks { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public static string UniqueClaimTypeIdentifier { get { return default(string); } set { } }
  }
  public partial interface IAntiForgeryAdditionalDataProvider {
    string GetAdditionalData(System.Web.HttpContextBase context);
    bool ValidateAdditionalData(System.Web.HttpContextBase context, string additionalData);
  }
  public sealed partial class UnvalidatedRequestValues {
    internal UnvalidatedRequestValues() { }
    public System.Collections.Specialized.NameValueCollection Form { get { return default(System.Collections.Specialized.NameValueCollection); } }
    public string this[string key] { get { return default(string); } }
    public System.Collections.Specialized.NameValueCollection QueryString { get { return default(System.Collections.Specialized.NameValueCollection); } }
  }
  public static partial class Validation {
    public static System.Web.Helpers.UnvalidatedRequestValues Unvalidated(this System.Web.HttpRequest request) { return default(System.Web.Helpers.UnvalidatedRequestValues); }
    public static string Unvalidated(this System.Web.HttpRequest request, string key) { return default(string); }
    public static System.Web.Helpers.UnvalidatedRequestValues Unvalidated(this System.Web.HttpRequestBase request) { return default(System.Web.Helpers.UnvalidatedRequestValues); }
    public static string Unvalidated(this System.Web.HttpRequestBase request, string key) { return default(string); }
  }
}
namespace System.Web.Mvc {
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Web.Mvc, Version=2.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  public sealed partial class HttpAntiForgeryException : System.Web.HttpException {
    public HttpAntiForgeryException() { }
    public HttpAntiForgeryException(string message) { }
    public HttpAntiForgeryException(string message, System.Exception innerException) { }
  }
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Web.Mvc, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  public partial class ModelClientValidationEqualToRule : System.Web.Mvc.ModelClientValidationRule {
    public ModelClientValidationEqualToRule(string errorMessage, object other) { }
  }
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Web.Mvc, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  public partial class ModelClientValidationRangeRule : System.Web.Mvc.ModelClientValidationRule {
    public ModelClientValidationRangeRule(string errorMessage, object minValue, object maxValue) { }
  }
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Web.Mvc, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  public partial class ModelClientValidationRegexRule : System.Web.Mvc.ModelClientValidationRule {
    public ModelClientValidationRegexRule(string errorMessage, string pattern) { }
  }
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Web.Mvc, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  public partial class ModelClientValidationRemoteRule : System.Web.Mvc.ModelClientValidationRule {
    public ModelClientValidationRemoteRule(string errorMessage, string url, string httpMethod, string additionalFields) { }
  }
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Web.Mvc, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  public partial class ModelClientValidationRequiredRule : System.Web.Mvc.ModelClientValidationRule {
    public ModelClientValidationRequiredRule(string errorMessage) { }
  }
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Web.Mvc, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  public partial class ModelClientValidationRule {
    public ModelClientValidationRule() { }
    public string ErrorMessage { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.Generic.IDictionary<System.String, System.Object> ValidationParameters { get { return default(System.Collections.Generic.IDictionary<System.String, System.Object>); } }
    public string ValidationType { get { return default(string); } set { } }
  }
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Web.Mvc, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  public partial class ModelClientValidationStringLengthRule : System.Web.Mvc.ModelClientValidationRule {
    public ModelClientValidationStringLengthRule(string errorMessage, int minimumLength, int maximumLength) { }
  }
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Web.Mvc, Version=2.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  public partial class TagBuilder {
    public TagBuilder(string tagName) { }
    public System.Collections.Generic.IDictionary<System.String, System.String> Attributes { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IDictionary<System.String, System.String>); } }
    public string IdAttributeDotReplacement { get { return default(string); } set { } }
    public string InnerHtml { get { return default(string); } set { } }
    public string TagName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public void AddCssClass(string value) { }
    public static string CreateSanitizedId(string originalId) { return default(string); }
    public static string CreateSanitizedId(string originalId, string invalidCharReplacement) { return default(string); }
    public void GenerateId(string name) { }
    public void MergeAttribute(string key, string value) { }
    public void MergeAttribute(string key, string value, bool replaceExisting) { }
    public void MergeAttributes<TKey, TValue>(System.Collections.Generic.IDictionary<TKey, TValue> attributes) { }
    public void MergeAttributes<TKey, TValue>(System.Collections.Generic.IDictionary<TKey, TValue> attributes, bool replaceExisting) { }
    public void SetInnerText(string innerText) { }
    public override string ToString() { return default(string); }
    public string ToString(System.Web.Mvc.TagRenderMode renderMode) { return default(string); }
  }
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Web.Mvc, Version=2.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  public enum TagRenderMode {
    EndTag = 2,
    Normal = 0,
    SelfClosing = 3,
    StartTag = 1,
  }
  public static partial class UnobtrusiveValidationAttributesGenerator {
    public static void GetValidationAttributes(System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelClientValidationRule> clientRules, System.Collections.Generic.IDictionary<System.String, System.Object> results) { }
  }
}
namespace System.Web.WebPages {
  public partial class ApplicationPart {
    public ApplicationPart(System.Reflection.Assembly assembly, string rootVirtualPath) { }
    public static string ProcessVirtualPath(System.Reflection.Assembly assembly, string baseVirtualPath, string virtualPath) { return default(string); }
    public static void Register(System.Web.WebPages.ApplicationPart applicationPart) { }
  }
  public abstract partial class ApplicationStartPage : System.Web.WebPages.WebPageExecutingBase {
    public static readonly string CacheKeyPrefix;
    public static readonly string StartPageVirtualPath;
    protected ApplicationStartPage() { }
    public System.Web.HttpApplication Application { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.HttpApplication); } }
    public override System.Web.HttpContextBase Context { get { return default(System.Web.HttpContextBase); } }
    public static System.Web.HtmlString Markup { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.HtmlString); } }
    public System.IO.TextWriter Output { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.IO.TextWriter); } }
    public override string VirtualPath { get { return default(string); } set { } }
    protected internal override System.IO.TextWriter GetOutputWriter() { return default(System.IO.TextWriter); }
    public override void Write(object value) { }
    public override void Write(System.Web.WebPages.HelperResult result) { }
    public override void WriteLiteral(object value) { }
  }
  public partial class AttributeValue {
    public AttributeValue(System.Web.WebPages.Instrumentation.PositionTagged<System.String> prefix, System.Web.WebPages.Instrumentation.PositionTagged<System.Object> value, bool literal) { }
    public bool Literal { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    public System.Web.WebPages.Instrumentation.PositionTagged<System.String> Prefix { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.WebPages.Instrumentation.PositionTagged<System.String>); } }
    public System.Web.WebPages.Instrumentation.PositionTagged<System.Object> Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.WebPages.Instrumentation.PositionTagged<System.Object>); } }
    public static System.Web.WebPages.AttributeValue FromTuple(System.Tuple<System.Tuple<System.String, System.Int32>, System.Tuple<System.Object, System.Int32>, System.Boolean> value) { return default(System.Web.WebPages.AttributeValue); }
    public static System.Web.WebPages.AttributeValue FromTuple(System.Tuple<System.Tuple<System.String, System.Int32>, System.Tuple<System.String, System.Int32>, System.Boolean> value) { return default(System.Web.WebPages.AttributeValue); }
    public static implicit operator System.Web.WebPages.AttributeValue (System.Tuple<System.Tuple<System.String, System.Int32>, System.Tuple<System.Object, System.Int32>, System.Boolean> value) { return default(System.Web.WebPages.AttributeValue); }
    public static implicit operator System.Web.WebPages.AttributeValue (System.Tuple<System.Tuple<System.String, System.Int32>, System.Tuple<System.String, System.Int32>, System.Boolean> value) { return default(System.Web.WebPages.AttributeValue); }
  }
  public static partial class BrowserHelpers {
    public static void ClearOverriddenBrowser(this System.Web.HttpContextBase httpContext) { }
    public static System.Web.HttpBrowserCapabilitiesBase GetOverriddenBrowser(this System.Web.HttpContextBase httpContext) { return default(System.Web.HttpBrowserCapabilitiesBase); }
    public static string GetOverriddenUserAgent(this System.Web.HttpContextBase httpContext) { return default(string); }
    public static string GetVaryByCustomStringForOverriddenBrowser(this System.Web.HttpContext httpContext) { return default(string); }
    public static string GetVaryByCustomStringForOverriddenBrowser(this System.Web.HttpContextBase httpContext) { return default(string); }
    public static void SetOverriddenBrowser(this System.Web.HttpContextBase httpContext, string userAgent) { }
    public static void SetOverriddenBrowser(this System.Web.HttpContextBase httpContext, System.Web.WebPages.BrowserOverride browserOverride) { }
  }
  public enum BrowserOverride {
    Desktop = 0,
    Mobile = 1,
  }
  public abstract partial class BrowserOverrideStore {
    protected BrowserOverrideStore() { }
    public abstract string GetOverriddenUserAgent(System.Web.HttpContextBase httpContext);
    public abstract void SetOverriddenUserAgent(System.Web.HttpContextBase httpContext, string userAgent);
  }
  public partial class BrowserOverrideStores {
    public BrowserOverrideStores() { }
    public static System.Web.WebPages.BrowserOverrideStore Current { get { return default(System.Web.WebPages.BrowserOverrideStore); } set { } }
  }
  public partial class CookieBrowserOverrideStore : System.Web.WebPages.BrowserOverrideStore {
    public CookieBrowserOverrideStore() { }
    public CookieBrowserOverrideStore(int daysToExpire) { }
    public override string GetOverriddenUserAgent(System.Web.HttpContextBase httpContext) { return default(string); }
    public override void SetOverriddenUserAgent(System.Web.HttpContextBase httpContext, string userAgent) { }
  }
  public partial class DefaultDisplayMode : System.Web.WebPages.IDisplayMode {
    public DefaultDisplayMode() { }
    public DefaultDisplayMode(string suffix) { }
    public System.Func<System.Web.HttpContextBase, System.Boolean> ContextCondition { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Func<System.Web.HttpContextBase, System.Boolean>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public virtual string DisplayModeId { get { return default(string); } }
    public bool CanHandleContext(System.Web.HttpContextBase httpContext) { return default(bool); }
    public virtual System.Web.WebPages.DisplayInfo GetDisplayInfo(System.Web.HttpContextBase httpContext, string virtualPath, System.Func<System.String, System.Boolean> virtualPathExists) { return default(System.Web.WebPages.DisplayInfo); }
    protected virtual string TransformPath(string virtualPath, string suffix) { return default(string); }
  }
  public partial class DisplayInfo {
    public DisplayInfo(string filePath, System.Web.WebPages.IDisplayMode displayMode) { }
    public System.Web.WebPages.IDisplayMode DisplayMode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.WebPages.IDisplayMode); } }
    public string FilePath { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
  }
  public sealed partial class DisplayModeProvider {
    internal DisplayModeProvider() { }
    public static readonly string DefaultDisplayModeId;
    public static readonly string MobileDisplayModeId;
    public static System.Web.WebPages.DisplayModeProvider Instance { get { return default(System.Web.WebPages.DisplayModeProvider); } }
    public System.Collections.Generic.IList<System.Web.WebPages.IDisplayMode> Modes { get { return default(System.Collections.Generic.IList<System.Web.WebPages.IDisplayMode>); } }
    public bool RequireConsistentDisplayMode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.Generic.IEnumerable<System.Web.WebPages.IDisplayMode> GetAvailableDisplayModesForContext(System.Web.HttpContextBase httpContext, System.Web.WebPages.IDisplayMode currentDisplayMode) { return default(System.Collections.Generic.IEnumerable<System.Web.WebPages.IDisplayMode>); }
    public System.Web.WebPages.DisplayInfo GetDisplayInfoForVirtualPath(string virtualPath, System.Web.HttpContextBase httpContext, System.Func<System.String, System.Boolean> virtualPathExists, System.Web.WebPages.IDisplayMode currentDisplayMode) { return default(System.Web.WebPages.DisplayInfo); }
  }
  public partial class HelperPage {
    public HelperPage() { }
    public static object App { get { return default(object); } }
    public static System.Web.HttpApplicationStateBase AppState { get { return default(System.Web.HttpApplicationStateBase); } }
    public static System.Web.Caching.Cache Cache { get { return default(System.Web.Caching.Cache); } }
    public static System.Web.HttpContextBase Context { get { return default(System.Web.HttpContextBase); } }
    public static System.Web.WebPages.WebPageRenderingBase CurrentPage { get { return default(System.Web.WebPages.WebPageRenderingBase); } }
    protected static string HelperVirtualPath { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public static System.Web.WebPages.Html.HtmlHelper Html { get { return default(System.Web.WebPages.Html.HtmlHelper); } }
    public static bool IsAjax { get { return default(bool); } }
    public static bool IsPost { get { return default(bool); } }
    public static object Model { get { return default(object); } }
    public static System.Web.WebPages.Html.ModelStateDictionary ModelState { get { return default(System.Web.WebPages.Html.ModelStateDictionary); } }
    public static object Page { get { return default(object); } }
    public static System.Web.WebPages.WebPageContext PageContext { get { return default(System.Web.WebPages.WebPageContext); } set { } }
    public static System.Collections.Generic.IDictionary<System.Object, System.Object> PageData { get { return default(System.Collections.Generic.IDictionary<System.Object, System.Object>); } }
    public static System.Web.HttpRequestBase Request { get { return default(System.Web.HttpRequestBase); } }
    public static System.Web.HttpResponseBase Response { get { return default(System.Web.HttpResponseBase); } }
    public static System.Web.HttpServerUtilityBase Server { get { return default(System.Web.HttpServerUtilityBase); } }
    public static System.Web.HttpSessionStateBase Session { get { return default(System.Web.HttpSessionStateBase); } }
    public static System.Collections.Generic.IList<System.String> UrlData { get { return default(System.Collections.Generic.IList<System.String>); } }
    public static System.Security.Principal.IPrincipal User { get { return default(System.Security.Principal.IPrincipal); } }
    public static string VirtualPath { get { return default(string); } }
    public static void BeginContext(System.IO.TextWriter writer, string virtualPath, int startPosition, int length, bool isLiteral) { }
    public static void BeginContext(string virtualPath, int startPosition, int length, bool isLiteral) { }
    public static void EndContext(System.IO.TextWriter writer, string virtualPath, int startPosition, int length, bool isLiteral) { }
    public static void EndContext(string virtualPath, int startPosition, int length, bool isLiteral) { }
    public static string Href(string path, params System.Object[] pathParts) { return default(string); }
    public static void WriteAttributeTo(System.IO.TextWriter writer, string name, System.Web.WebPages.Instrumentation.PositionTagged<System.String> prefix, System.Web.WebPages.Instrumentation.PositionTagged<System.String> suffix, params System.Web.WebPages.AttributeValue[] values) { }
    public static void WriteLiteralTo(System.IO.TextWriter writer, object value) { }
    public static void WriteLiteralTo(System.IO.TextWriter writer, System.Web.WebPages.HelperResult value) { }
    public static void WriteTo(System.IO.TextWriter writer, object value) { }
    public static void WriteTo(System.IO.TextWriter writer, System.Web.WebPages.HelperResult value) { }
  }
  public partial class HelperResult : System.Web.IHtmlString {
    public HelperResult(System.Action<System.IO.TextWriter> action) { }
    public string ToHtmlString() { return default(string); }
    public override string ToString() { return default(string); }
    public void WriteTo(System.IO.TextWriter writer) { }
  }
  public static partial class HttpContextExtensions {
    public static void RedirectLocal(this System.Web.HttpContextBase context, string url) { }
    public static void RegisterForDispose(this System.Web.HttpContextBase context, System.IDisposable resource) { }
  }
  public partial interface IDisplayMode {
    string DisplayModeId { get; }
    bool CanHandleContext(System.Web.HttpContextBase httpContext);
    System.Web.WebPages.DisplayInfo GetDisplayInfo(System.Web.HttpContextBase httpContext, string virtualPath, System.Func<System.String, System.Boolean> virtualPathExists);
  }
  public partial interface ITemplateFile {
    System.Web.WebPages.TemplateFileInfo TemplateInfo { get; }
  }
  public partial interface IValidator {
    System.Web.Mvc.ModelClientValidationRule ClientValidationRule { get; }
    System.ComponentModel.DataAnnotations.ValidationResult Validate(System.ComponentModel.DataAnnotations.ValidationContext validationContext);
  }
  public partial interface IVirtualPathFactory {
    object CreateInstance(string virtualPath);
    bool Exists(string virtualPath);
  }
  public partial interface IWebPageRequestExecutor {
    bool Execute(System.Web.WebPages.WebPage page);
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false, Inherited=true)]
  public sealed partial class PageVirtualPathAttribute : System.Attribute {
    public PageVirtualPathAttribute(string virtualPath) { }
    public string VirtualPath { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public static partial class PreApplicationStartCode {
    public static void Start() { }
  }
  public static partial class RequestExtensions {
    public static bool IsUrlLocalToHost(this System.Web.HttpRequestBase request, string url) { return default(bool); }
  }
  public abstract partial class RequestFieldValidatorBase : System.Web.WebPages.IValidator {
    protected RequestFieldValidatorBase(string errorMessage) { }
    protected RequestFieldValidatorBase(string errorMessage, bool useUnvalidatedValues) { }
    public virtual System.Web.Mvc.ModelClientValidationRule ClientValidationRule { get { return default(System.Web.Mvc.ModelClientValidationRule); } }
    protected static System.Web.HttpContextBase GetHttpContext(System.ComponentModel.DataAnnotations.ValidationContext validationContext) { return default(System.Web.HttpContextBase); }
    protected string GetRequestValue(System.Web.HttpRequestBase request, string field) { return default(string); }
    protected abstract bool IsValid(System.Web.HttpContextBase httpContext, string value);
    public virtual System.ComponentModel.DataAnnotations.ValidationResult Validate(System.ComponentModel.DataAnnotations.ValidationContext validationContext) { return default(System.ComponentModel.DataAnnotations.ValidationResult); }
  }
  public static partial class ResponseExtensions {
    public static void OutputCache(this System.Web.HttpResponseBase response, int numberOfSeconds, bool sliding=false, System.Collections.Generic.IEnumerable<System.String> varyByParams=null, System.Collections.Generic.IEnumerable<System.String> varyByHeaders=null, System.Collections.Generic.IEnumerable<System.String> varyByContentEncodings=null, System.Web.HttpCacheability cacheability=(System.Web.HttpCacheability)(4)) { }
    public static void SetStatus(this System.Web.HttpResponseBase response, int httpStatusCode) { }
    public static void SetStatus(this System.Web.HttpResponseBase response, System.Net.HttpStatusCode httpStatusCode) { }
    public static void WriteBinary(this System.Web.HttpResponseBase response, System.Byte[] data) { }
    public static void WriteBinary(this System.Web.HttpResponseBase response, System.Byte[] data, string mimeType) { }
  }
  public delegate void SectionWriter();
  public abstract partial class StartPage : System.Web.WebPages.WebPageRenderingBase {
    protected StartPage() { }
    public System.Web.WebPages.WebPageRenderingBase ChildPage { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.WebPages.WebPageRenderingBase); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override System.Web.HttpContextBase Context { get { return default(System.Web.HttpContextBase); } set { } }
    public override string Layout { get { return default(string); } set { } }
    public override object Page { get { return default(object); } }
    public override System.Collections.Generic.IDictionary<System.Object, System.Object> PageData { get { return default(System.Collections.Generic.IDictionary<System.Object, System.Object>); } }
    public override void ExecutePageHierarchy() { }
    protected internal override System.IO.TextWriter GetOutputWriter() { return default(System.IO.TextWriter); }
    public static System.Web.WebPages.WebPageRenderingBase GetStartPage(System.Web.WebPages.WebPageRenderingBase page, string fileName, System.Collections.Generic.IEnumerable<System.String> supportedExtensions) { return default(System.Web.WebPages.WebPageRenderingBase); }
    public override System.Web.WebPages.HelperResult RenderPage(string path, params System.Object[] data) { return default(System.Web.WebPages.HelperResult); }
    public void RunPage() { }
    public override void Write(object value) { }
    public override void Write(System.Web.WebPages.HelperResult result) { }
    public override void WriteLiteral(object value) { }
  }
  public static partial class StringExtensions {
    public static TValue As<TValue>(this string value) { return default(TValue); }
    public static TValue As<TValue>(this string value, TValue defaultValue) { return default(TValue); }
    public static bool AsBool(this string value) { return default(bool); }
    public static bool AsBool(this string value, bool defaultValue) { return default(bool); }
    public static System.DateTime AsDateTime(this string value) { return default(System.DateTime); }
    public static System.DateTime AsDateTime(this string value, System.DateTime defaultValue) { return default(System.DateTime); }
    public static decimal AsDecimal(this string value) { return default(decimal); }
    public static decimal AsDecimal(this string value, decimal defaultValue) { return default(decimal); }
    public static float AsFloat(this string value) { return default(float); }
    public static float AsFloat(this string value, float defaultValue) { return default(float); }
    public static int AsInt(this string value) { return default(int); }
    public static int AsInt(this string value, int defaultValue) { return default(int); }
    public static bool Is<TValue>(this string value) { return default(bool); }
    public static bool IsBool(this string value) { return default(bool); }
    public static bool IsDateTime(this string value) { return default(bool); }
    public static bool IsDecimal(this string value) { return default(bool); }
    public static bool IsEmpty(this string value) { return default(bool); }
    public static bool IsFloat(this string value) { return default(bool); }
    public static bool IsInt(this string value) { return default(bool); }
  }
  public partial class TemplateFileInfo {
    public TemplateFileInfo(string virtualPath) { }
    public string VirtualPath { get { return default(string); } }
  }
  public static partial class TemplateStack {
    public static System.Web.WebPages.ITemplateFile GetCurrentTemplate(System.Web.HttpContextBase httpContext) { return default(System.Web.WebPages.ITemplateFile); }
    public static System.Web.WebPages.ITemplateFile Pop(System.Web.HttpContextBase httpContext) { return default(System.Web.WebPages.ITemplateFile); }
    public static void Push(System.Web.HttpContextBase httpContext, System.Web.WebPages.ITemplateFile templateFile) { }
  }
  public sealed partial class ValidationHelper {
    internal ValidationHelper() { }
    public string FormField { get { return default(string); } }
    public static string InvalidCssClass { get { return default(string); } set { } }
    public static string ValidCssClass { get { return default(string); } set { } }
    public void Add(System.Collections.Generic.IEnumerable<System.String> fields, params System.Web.WebPages.IValidator[] validators) { }
    public void Add(string field, params System.Web.WebPages.IValidator[] validators) { }
    public void AddFormError(string errorMessage) { }
    public System.Web.HtmlString ClassFor(string field) { return default(System.Web.HtmlString); }
    public System.Web.HtmlString For(string field) { return default(System.Web.HtmlString); }
    public System.Collections.Generic.IEnumerable<System.String> GetErrors(params System.String[] fields) { return default(System.Collections.Generic.IEnumerable<System.String>); }
    public bool IsValid(params System.String[] fields) { return default(bool); }
    public void RequireField(string field) { }
    public void RequireField(string field, string errorMessage) { }
    public void RequireFields(params System.String[] fields) { }
    public System.Collections.Generic.IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(params System.String[] fields) { return default(System.Collections.Generic.IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult>); }
  }
  public abstract partial class Validator {
    protected Validator() { }
    public static System.Web.WebPages.IValidator DateTime(string errorMessage=null) { return default(System.Web.WebPages.IValidator); }
    public static System.Web.WebPages.IValidator Decimal(string errorMessage=null) { return default(System.Web.WebPages.IValidator); }
    public static System.Web.WebPages.IValidator EqualsTo(string otherFieldName, string errorMessage=null) { return default(System.Web.WebPages.IValidator); }
    public static System.Web.WebPages.IValidator Float(string errorMessage=null) { return default(System.Web.WebPages.IValidator); }
    public static System.Web.WebPages.IValidator Integer(string errorMessage=null) { return default(System.Web.WebPages.IValidator); }
    public static System.Web.WebPages.IValidator Range(double minValue, double maxValue, string errorMessage=null) { return default(System.Web.WebPages.IValidator); }
    public static System.Web.WebPages.IValidator Range(int minValue, int maxValue, string errorMessage=null) { return default(System.Web.WebPages.IValidator); }
    public static System.Web.WebPages.IValidator Regex(string pattern, string errorMessage=null) { return default(System.Web.WebPages.IValidator); }
    public static System.Web.WebPages.IValidator Required(string errorMessage=null) { return default(System.Web.WebPages.IValidator); }
    public static System.Web.WebPages.IValidator StringLength(int maxLength, int minLength=0, string errorMessage=null) { return default(System.Web.WebPages.IValidator); }
    public static System.Web.WebPages.IValidator Url(string errorMessage=null) { return default(System.Web.WebPages.IValidator); }
  }
  public partial class VirtualPathFactoryManager : System.Web.WebPages.IVirtualPathFactory {
    internal VirtualPathFactoryManager() { }
    public object CreateInstance(string virtualPath) { return default(object); }
    public bool Exists(string virtualPath) { return default(bool); }
    public static void RegisterVirtualPathFactory(System.Web.WebPages.IVirtualPathFactory virtualPathFactory) { }
  }
  public abstract partial class WebPage : System.Web.WebPages.WebPageBase {
    protected WebPage() { }
    public override System.Web.HttpContextBase Context { get { return default(System.Web.HttpContextBase); } set { } }
    public System.Web.WebPages.Html.HtmlHelper Html { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.WebPages.Html.HtmlHelper); } }
    public object Model { get { return default(object); } }
    public System.Web.WebPages.Html.ModelStateDictionary ModelState { get { return default(System.Web.WebPages.Html.ModelStateDictionary); } }
    public System.Web.WebPages.ValidationHelper Validation { get { return default(System.Web.WebPages.ValidationHelper); } }
    public override void ExecutePageHierarchy() { }
    protected override void InitializePage() { }
    public static void RegisterPageExecutor(System.Web.WebPages.IWebPageRequestExecutor executor) { }
    public override System.Web.WebPages.HelperResult RenderPage(string path, params System.Object[] data) { return default(System.Web.WebPages.HelperResult); }
  }
  public abstract partial class WebPageBase : System.Web.WebPages.WebPageRenderingBase {
    protected WebPageBase() { }
    public override string Layout { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.IO.TextWriter Output { get { return default(System.IO.TextWriter); } }
    public System.Collections.Generic.Stack<System.IO.TextWriter> OutputStack { get { return default(System.Collections.Generic.Stack<System.IO.TextWriter>); } }
    public override object Page { get { return default(object); } }
    public override System.Collections.Generic.IDictionary<System.Object, System.Object> PageData { get { return default(System.Collections.Generic.IDictionary<System.Object, System.Object>); } }
    protected virtual void ConfigurePage(System.Web.WebPages.WebPageBase parentPage) { }
    public static System.Web.WebPages.WebPageBase CreateInstanceFromVirtualPath(string virtualPath) { return default(System.Web.WebPages.WebPageBase); }
    public void DefineSection(string name, System.Web.WebPages.SectionWriter action) { }
    public override void ExecutePageHierarchy() { }
    public void ExecutePageHierarchy(System.Web.WebPages.WebPageContext pageContext, System.IO.TextWriter writer) { }
    public void ExecutePageHierarchy(System.Web.WebPages.WebPageContext pageContext, System.IO.TextWriter writer, System.Web.WebPages.WebPageRenderingBase startPage) { }
    protected internal override System.IO.TextWriter GetOutputWriter() { return default(System.IO.TextWriter); }
    protected virtual void InitializePage() { }
    public bool IsSectionDefined(string name) { return default(bool); }
    public void PopContext() { }
    public void PushContext(System.Web.WebPages.WebPageContext pageContext, System.IO.TextWriter writer) { }
    public System.Web.WebPages.HelperResult RenderBody() { return default(System.Web.WebPages.HelperResult); }
    public override System.Web.WebPages.HelperResult RenderPage(string path, params System.Object[] data) { return default(System.Web.WebPages.HelperResult); }
    public System.Web.WebPages.HelperResult RenderSection(string name) { return default(System.Web.WebPages.HelperResult); }
    public System.Web.WebPages.HelperResult RenderSection(string name, bool required) { return default(System.Web.WebPages.HelperResult); }
    public override void Write(object value) { }
    public override void Write(System.Web.WebPages.HelperResult result) { }
    public override void WriteLiteral(object value) { }
  }
  public partial class WebPageContext {
    public WebPageContext() { }
    public WebPageContext(System.Web.HttpContextBase context, System.Web.WebPages.WebPageRenderingBase page, object model) { }
    public static System.Web.WebPages.WebPageContext Current { get { return default(System.Web.WebPages.WebPageContext); } }
    public object Model { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } }
    public System.Web.WebPages.WebPageRenderingBase Page { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.WebPages.WebPageRenderingBase); } }
    public System.Collections.Generic.IDictionary<System.Object, System.Object> PageData { get { return default(System.Collections.Generic.IDictionary<System.Object, System.Object>); } }
  }
  public abstract partial class WebPageExecutingBase {
    protected WebPageExecutingBase() { }
    public virtual object App { get { return default(object); } }
    public virtual System.Web.HttpApplicationStateBase AppState { get { return default(System.Web.HttpApplicationStateBase); } }
    public virtual System.Web.HttpContextBase Context { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.HttpContextBase); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public virtual string VirtualPath { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public virtual System.Web.WebPages.IVirtualPathFactory VirtualPathFactory { get { return default(System.Web.WebPages.IVirtualPathFactory); } set { } }
    protected internal void BeginContext(int startPosition, int length, bool isLiteral) { }
    protected internal void BeginContext(System.IO.TextWriter writer, int startPosition, int length, bool isLiteral) { }
    protected internal void BeginContext(System.IO.TextWriter writer, string virtualPath, int startPosition, int length, bool isLiteral) { }
    protected internal void BeginContext(string virtualPath, int startPosition, int length, bool isLiteral) { }
    protected internal void EndContext(int startPosition, int length, bool isLiteral) { }
    protected internal void EndContext(System.IO.TextWriter writer, int startPosition, int length, bool isLiteral) { }
    protected internal void EndContext(System.IO.TextWriter writer, string virtualPath, int startPosition, int length, bool isLiteral) { }
    protected internal void EndContext(string virtualPath, int startPosition, int length, bool isLiteral) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public abstract void Execute();
    protected internal virtual System.IO.TextWriter GetOutputWriter() { return default(System.IO.TextWriter); }
    public virtual string Href(string path, params System.Object[] pathParts) { return default(string); }
    public virtual string NormalizePath(string path) { return default(string); }
    public abstract void Write(object value);
    public abstract void Write(System.Web.WebPages.HelperResult result);
    public virtual void WriteAttribute(string name, System.Web.WebPages.Instrumentation.PositionTagged<System.String> prefix, System.Web.WebPages.Instrumentation.PositionTagged<System.String> suffix, params System.Web.WebPages.AttributeValue[] values) { }
    public virtual void WriteAttributeTo(System.IO.TextWriter writer, string name, System.Web.WebPages.Instrumentation.PositionTagged<System.String> prefix, System.Web.WebPages.Instrumentation.PositionTagged<System.String> suffix, params System.Web.WebPages.AttributeValue[] values) { }
    protected internal virtual void WriteAttributeTo(string pageVirtualPath, System.IO.TextWriter writer, string name, System.Web.WebPages.Instrumentation.PositionTagged<System.String> prefix, System.Web.WebPages.Instrumentation.PositionTagged<System.String> suffix, params System.Web.WebPages.AttributeValue[] values) { }
    public abstract void WriteLiteral(object value);
    public static void WriteLiteralTo(System.IO.TextWriter writer, object content) { }
    public static void WriteTo(System.IO.TextWriter writer, object content) { }
    public static void WriteTo(System.IO.TextWriter writer, System.Web.WebPages.HelperResult content) { }
  }
  public partial class WebPageHttpHandler : System.Web.IHttpHandler, System.Web.SessionState.IRequiresSessionState {
    public static readonly string WebPagesVersionHeaderName;
    public WebPageHttpHandler(System.Web.WebPages.WebPage webPage) { }
    public static bool DisableWebPagesResponseHeader { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public virtual bool IsReusable { get { return default(bool); } }
    public static System.Web.IHttpHandler CreateFromVirtualPath(string virtualPath) { return default(System.Web.IHttpHandler); }
    public static System.Collections.ObjectModel.ReadOnlyCollection<System.String> GetRegisteredExtensions() { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.String>); }
    public virtual void ProcessRequest(System.Web.HttpContext context) { }
    public static void RegisterExtension(string extension) { }
  }
  public abstract partial class WebPageRenderingBase : System.Web.WebPages.WebPageExecutingBase, System.Web.WebPages.ITemplateFile {
    protected WebPageRenderingBase() { }
    public virtual System.Web.Caching.Cache Cache { get { return default(System.Web.Caching.Cache); } }
    public string Culture { get { return default(string); } set { } }
    protected internal System.Web.WebPages.IDisplayMode DisplayMode { get { return default(System.Web.WebPages.IDisplayMode); } }
    public virtual bool IsAjax { get { return default(bool); } }
    public virtual bool IsPost { get { return default(bool); } }
    public abstract string Layout { get; set; }
    public abstract object Page { get; }
    public System.Web.WebPages.WebPageContext PageContext { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.WebPages.WebPageContext); } }
    public abstract System.Collections.Generic.IDictionary<System.Object, System.Object> PageData { get; }
    public System.Web.Profile.ProfileBase Profile { get { return default(System.Web.Profile.ProfileBase); } }
    public virtual System.Web.HttpRequestBase Request { get { return default(System.Web.HttpRequestBase); } }
    public virtual System.Web.HttpResponseBase Response { get { return default(System.Web.HttpResponseBase); } }
    public virtual System.Web.HttpServerUtilityBase Server { get { return default(System.Web.HttpServerUtilityBase); } }
    public virtual System.Web.HttpSessionStateBase Session { get { return default(System.Web.HttpSessionStateBase); } }
    public virtual System.Web.WebPages.TemplateFileInfo TemplateInfo { get { return default(System.Web.WebPages.TemplateFileInfo); } }
    public string UICulture { get { return default(string); } set { } }
    public virtual System.Collections.Generic.IList<System.String> UrlData { get { return default(System.Collections.Generic.IList<System.String>); } }
    public virtual System.Security.Principal.IPrincipal User { get { return default(System.Security.Principal.IPrincipal); } }
    public abstract void ExecutePageHierarchy();
    public abstract System.Web.WebPages.HelperResult RenderPage(string path, params System.Object[] data);
  }
}
namespace System.Web.WebPages.Html {
  public partial class HtmlHelper {
    internal HtmlHelper() { }
    public static string IdAttributeDotReplacement { get { return default(string); } set { } }
    public static bool UnobtrusiveJavaScriptEnabled { get { return default(bool); } set { } }
    public static string ValidationInputCssClassName { get { return default(string); } set { } }
    public static string ValidationInputValidCssClassName { get { return default(string); } set { } }
    public static string ValidationMessageCssClassName { get { return default(string); } set { } }
    public static string ValidationMessageValidCssClassName { get { return default(string); } set { } }
    public static string ValidationSummaryClass { get { return default(string); } set { } }
    public static string ValidationSummaryValidClass { get { return default(string); } set { } }
    public string AttributeEncode(object value) { return default(string); }
    public string AttributeEncode(string value) { return default(string); }
    public System.Web.IHtmlString CheckBox(string name) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString CheckBox(string name, bool isChecked) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString CheckBox(string name, bool isChecked, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString CheckBox(string name, bool isChecked, object htmlAttributes) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString CheckBox(string name, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString CheckBox(string name, object htmlAttributes) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString DropDownList(string name, System.Collections.Generic.IEnumerable<System.Web.WebPages.Html.SelectListItem> selectList) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString DropDownList(string name, System.Collections.Generic.IEnumerable<System.Web.WebPages.Html.SelectListItem> selectList, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString DropDownList(string name, System.Collections.Generic.IEnumerable<System.Web.WebPages.Html.SelectListItem> selectList, object htmlAttributes) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString DropDownList(string name, string defaultOption, System.Collections.Generic.IEnumerable<System.Web.WebPages.Html.SelectListItem> selectList) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString DropDownList(string name, string defaultOption, System.Collections.Generic.IEnumerable<System.Web.WebPages.Html.SelectListItem> selectList, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString DropDownList(string name, string defaultOption, System.Collections.Generic.IEnumerable<System.Web.WebPages.Html.SelectListItem> selectList, object htmlAttributes) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString DropDownList(string name, string defaultOption, System.Collections.Generic.IEnumerable<System.Web.WebPages.Html.SelectListItem> selectList, object selectedValue, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString DropDownList(string name, string defaultOption, System.Collections.Generic.IEnumerable<System.Web.WebPages.Html.SelectListItem> selectList, object selectedValue, object htmlAttributes) { return default(System.Web.IHtmlString); }
    public string Encode(object value) { return default(string); }
    public string Encode(string value) { return default(string); }
    public System.Web.IHtmlString Hidden(string name) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString Hidden(string name, object value) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString Hidden(string name, object value, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString Hidden(string name, object value, object htmlAttributes) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString Label(string labelText) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString Label(string labelText, object attributes) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString Label(string labelText, string labelFor) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString Label(string labelText, string labelFor, System.Collections.Generic.IDictionary<System.String, System.Object> attributes) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString Label(string labelText, string labelFor, object attributes) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString ListBox(string name, System.Collections.Generic.IEnumerable<System.Web.WebPages.Html.SelectListItem> selectList) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString ListBox(string name, System.Collections.Generic.IEnumerable<System.Web.WebPages.Html.SelectListItem> selectList, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString ListBox(string name, System.Collections.Generic.IEnumerable<System.Web.WebPages.Html.SelectListItem> selectList, object htmlAttributes) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString ListBox(string name, System.Collections.Generic.IEnumerable<System.Web.WebPages.Html.SelectListItem> selectList, object selectedValues, int size, bool allowMultiple) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString ListBox(string name, string defaultOption, System.Collections.Generic.IEnumerable<System.Web.WebPages.Html.SelectListItem> selectList) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString ListBox(string name, string defaultOption, System.Collections.Generic.IEnumerable<System.Web.WebPages.Html.SelectListItem> selectList, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString ListBox(string name, string defaultOption, System.Collections.Generic.IEnumerable<System.Web.WebPages.Html.SelectListItem> selectList, object htmlAttributes) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString ListBox(string name, string defaultOption, System.Collections.Generic.IEnumerable<System.Web.WebPages.Html.SelectListItem> selectList, object selectedValues, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString ListBox(string name, string defaultOption, System.Collections.Generic.IEnumerable<System.Web.WebPages.Html.SelectListItem> selectList, object selectedValues, int size, bool allowMultiple) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString ListBox(string name, string defaultOption, System.Collections.Generic.IEnumerable<System.Web.WebPages.Html.SelectListItem> selectList, object selectedValues, int size, bool allowMultiple, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString ListBox(string name, string defaultOption, System.Collections.Generic.IEnumerable<System.Web.WebPages.Html.SelectListItem> selectList, object selectedValues, int size, bool allowMultiple, object htmlAttributes) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString ListBox(string name, string defaultOption, System.Collections.Generic.IEnumerable<System.Web.WebPages.Html.SelectListItem> selectList, object selectedValues, object htmlAttributes) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString Password(string name) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString Password(string name, object value) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString Password(string name, object value, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString Password(string name, object value, object htmlAttributes) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString RadioButton(string name, object value) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString RadioButton(string name, object value, bool isChecked) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString RadioButton(string name, object value, bool isChecked, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString RadioButton(string name, object value, bool isChecked, object htmlAttributes) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString RadioButton(string name, object value, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString RadioButton(string name, object value, object htmlAttributes) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString Raw(object value) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString Raw(string value) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString TextArea(string name) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString TextArea(string name, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString TextArea(string name, object htmlAttributes) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString TextArea(string name, string value) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString TextArea(string name, string value, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString TextArea(string name, string value, int rows, int columns, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString TextArea(string name, string value, int rows, int columns, object htmlAttributes) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString TextArea(string name, string value, object htmlAttributes) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString TextBox(string name) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString TextBox(string name, object value) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString TextBox(string name, object value, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString TextBox(string name, object value, object htmlAttributes) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString ValidationMessage(string name) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString ValidationMessage(string name, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString ValidationMessage(string name, object htmlAttributes) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString ValidationMessage(string name, string message) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString ValidationMessage(string name, string message, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString ValidationMessage(string name, string message, object htmlAttributes) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString ValidationSummary() { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString ValidationSummary(bool excludeFieldErrors) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString ValidationSummary(System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString ValidationSummary(object htmlAttributes) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString ValidationSummary(string message) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString ValidationSummary(string message, bool excludeFieldErrors, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString ValidationSummary(string message, bool excludeFieldErrors, object htmlAttributes) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString ValidationSummary(string message, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.IHtmlString); }
    public System.Web.IHtmlString ValidationSummary(string message, object htmlAttributes) { return default(System.Web.IHtmlString); }
  }
  public partial class ModelState {
    public ModelState() { }
    public System.Collections.Generic.IList<System.String> Errors { get { return default(System.Collections.Generic.IList<System.String>); } }
    public object Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial class ModelStateDictionary : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String, System.Web.WebPages.Html.ModelState>>, System.Collections.Generic.IDictionary<System.String, System.Web.WebPages.Html.ModelState>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Web.WebPages.Html.ModelState>>, System.Collections.IEnumerable {
    public ModelStateDictionary() { }
    public ModelStateDictionary(System.Web.WebPages.Html.ModelStateDictionary dictionary) { }
    public int Count { get { return default(int); } }
    public bool IsReadOnly { get { return default(bool); } }
    public bool IsValid { get { return default(bool); } }
    public System.Web.WebPages.Html.ModelState this[string key] { get { return default(System.Web.WebPages.Html.ModelState); } set { } }
    public System.Collections.Generic.ICollection<System.String> Keys { get { return default(System.Collections.Generic.ICollection<System.String>); } }
    public System.Collections.Generic.ICollection<System.Web.WebPages.Html.ModelState> Values { get { return default(System.Collections.Generic.ICollection<System.Web.WebPages.Html.ModelState>); } }
    public void Add(System.Collections.Generic.KeyValuePair<System.String, System.Web.WebPages.Html.ModelState> item) { }
    public void Add(string key, System.Web.WebPages.Html.ModelState value) { }
    public void AddError(string key, string errorMessage) { }
    public void AddFormError(string errorMessage) { }
    public void Clear() { }
    public bool Contains(System.Collections.Generic.KeyValuePair<System.String, System.Web.WebPages.Html.ModelState> item) { return default(bool); }
    public bool ContainsKey(string key) { return default(bool); }
    public void CopyTo(System.Collections.Generic.KeyValuePair<System.String, System.Web.WebPages.Html.ModelState>[] array, int arrayIndex) { }
    public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String, System.Web.WebPages.Html.ModelState>> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String, System.Web.WebPages.Html.ModelState>>); }
    public bool IsValidField(string key) { return default(bool); }
    public void Merge(System.Web.WebPages.Html.ModelStateDictionary dictionary) { }
    public bool Remove(System.Collections.Generic.KeyValuePair<System.String, System.Web.WebPages.Html.ModelState> item) { return default(bool); }
    public bool Remove(string key) { return default(bool); }
    public void SetModelValue(string key, object value) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    public bool TryGetValue(string key, out System.Web.WebPages.Html.ModelState value) { value = default(System.Web.WebPages.Html.ModelState); return default(bool); }
  }
  public partial class SelectListItem {
    public SelectListItem() { }
    public SelectListItem(System.Web.WebPages.Html.SelectListItem item) { }
    public bool Selected { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Text { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
}
namespace System.Web.WebPages.Instrumentation {
  public partial class InstrumentationService {
    public InstrumentationService() { }
    public bool IsAvailable { get { return default(bool); } }
    public void BeginContext(System.Web.HttpContextBase context, string virtualPath, System.IO.TextWriter writer, int startPosition, int length, bool isLiteral) { }
    public void EndContext(System.Web.HttpContextBase context, string virtualPath, System.IO.TextWriter writer, int startPosition, int length, bool isLiteral) { }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("({Position})\"{Value}\"")]
  public partial class PositionTagged<T> {
    public PositionTagged(T value, int offset) { }
    public int Position { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    public T Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(T); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Web.WebPages.Instrumentation.PositionTagged<T> left, System.Web.WebPages.Instrumentation.PositionTagged<T> right) { return default(bool); }
    public static implicit operator System.Web.WebPages.Instrumentation.PositionTagged<T> (System.Tuple<T, System.Int32> value) { return default(System.Web.WebPages.Instrumentation.PositionTagged<T>); }
    public static implicit operator T (System.Web.WebPages.Instrumentation.PositionTagged<T> value) { return default(T); }
    public static bool operator !=(System.Web.WebPages.Instrumentation.PositionTagged<T> left, System.Web.WebPages.Instrumentation.PositionTagged<T> right) { return default(bool); }
    public override string ToString() { return default(string); }
  }
}
namespace System.Web.WebPages.Scope {
  public partial class AspNetRequestScopeStorageProvider : System.Web.WebPages.Scope.IScopeStorageProvider {
    public AspNetRequestScopeStorageProvider() { }
    public System.Collections.Generic.IDictionary<System.Object, System.Object> ApplicationScope { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IDictionary<System.Object, System.Object>); } }
    public System.Collections.Generic.IDictionary<System.Object, System.Object> CurrentScope { get { return default(System.Collections.Generic.IDictionary<System.Object, System.Object>); } set { } }
    public System.Collections.Generic.IDictionary<System.Object, System.Object> GlobalScope { get { return default(System.Collections.Generic.IDictionary<System.Object, System.Object>); } }
    public System.Collections.Generic.IDictionary<System.Object, System.Object> RequestScope { get { return default(System.Collections.Generic.IDictionary<System.Object, System.Object>); } }
  }
  public partial interface IScopeStorageProvider {
    System.Collections.Generic.IDictionary<System.Object, System.Object> CurrentScope { get; set; }
    System.Collections.Generic.IDictionary<System.Object, System.Object> GlobalScope { get; }
  }
  public static partial class ScopeStorage {
    public static System.Web.WebPages.Scope.IScopeStorageProvider CurrentProvider { get { return default(System.Web.WebPages.Scope.IScopeStorageProvider); } set { } }
    public static System.Collections.Generic.IDictionary<System.Object, System.Object> CurrentScope { get { return default(System.Collections.Generic.IDictionary<System.Object, System.Object>); } }
    public static System.Collections.Generic.IDictionary<System.Object, System.Object> GlobalScope { get { return default(System.Collections.Generic.IDictionary<System.Object, System.Object>); } }
    public static System.IDisposable CreateTransientScope() { return default(System.IDisposable); }
    public static System.IDisposable CreateTransientScope(System.Collections.Generic.IDictionary<System.Object, System.Object> context) { return default(System.IDisposable); }
  }
  public partial class ScopeStorageDictionary : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.Object, System.Object>>, System.Collections.Generic.IDictionary<System.Object, System.Object>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Object, System.Object>>, System.Collections.IEnumerable {
    public ScopeStorageDictionary() { }
    public ScopeStorageDictionary(System.Collections.Generic.IDictionary<System.Object, System.Object> baseScope) { }
    protected System.Collections.Generic.IDictionary<System.Object, System.Object> BackingStore { get { return default(System.Collections.Generic.IDictionary<System.Object, System.Object>); } }
    protected System.Collections.Generic.IDictionary<System.Object, System.Object> BaseScope { get { return default(System.Collections.Generic.IDictionary<System.Object, System.Object>); } }
    public virtual int Count { get { return default(int); } }
    public virtual bool IsReadOnly { get { return default(bool); } }
    public object this[object key] { get { return default(object); } set { } }
    public virtual System.Collections.Generic.ICollection<System.Object> Keys { get { return default(System.Collections.Generic.ICollection<System.Object>); } }
    public virtual System.Collections.Generic.ICollection<System.Object> Values { get { return default(System.Collections.Generic.ICollection<System.Object>); } }
    public virtual void Add(System.Collections.Generic.KeyValuePair<System.Object, System.Object> item) { }
    public virtual void Add(object key, object value) { }
    public virtual void Clear() { }
    public virtual bool Contains(System.Collections.Generic.KeyValuePair<System.Object, System.Object> item) { return default(bool); }
    public virtual bool ContainsKey(object key) { return default(bool); }
    public virtual void CopyTo(System.Collections.Generic.KeyValuePair<System.Object, System.Object>[] array, int arrayIndex) { }
    public virtual System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Object, System.Object>> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Object, System.Object>>); }
    protected virtual System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Object, System.Object>> GetItems() { return default(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Object, System.Object>>); }
    public virtual bool Remove(System.Collections.Generic.KeyValuePair<System.Object, System.Object> item) { return default(bool); }
    public virtual bool Remove(object key) { return default(bool); }
    public virtual void SetValue(object key, object value) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    public virtual bool TryGetValue(object key, out object value) { value = default(object); return default(bool); }
  }
  public partial class StaticScopeStorageProvider : System.Web.WebPages.Scope.IScopeStorageProvider {
    public StaticScopeStorageProvider() { }
    public System.Collections.Generic.IDictionary<System.Object, System.Object> CurrentScope { get { return default(System.Collections.Generic.IDictionary<System.Object, System.Object>); } set { } }
    public System.Collections.Generic.IDictionary<System.Object, System.Object> GlobalScope { get { return default(System.Collections.Generic.IDictionary<System.Object, System.Object>); } }
  }
}
