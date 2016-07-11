namespace System.Web {
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public abstract partial class HttpApplicationStateBase : System.Collections.Specialized.NameObjectCollectionBase, System.Collections.ICollection, System.Collections.IEnumerable {
    protected HttpApplicationStateBase() { }
    public virtual System.String[] AllKeys { get { return default(System.String[]); } }
    public virtual System.Web.HttpApplicationStateBase Contents { get { return default(System.Web.HttpApplicationStateBase); } }
    public override int Count { get { return default(int); } }
    public virtual bool IsSynchronized { get { return default(bool); } }
    public virtual object this[int index] { get { return default(object); } }
    public virtual object this[string name] { get { return default(object); } set { } }
    public virtual System.Web.HttpStaticObjectsCollectionBase StaticObjects { get { return default(System.Web.HttpStaticObjectsCollectionBase); } }
    public virtual object SyncRoot { get { return default(object); } }
    public virtual void Add(string name, object value) { }
    public virtual void Clear() { }
    public virtual void CopyTo(System.Array array, int index) { }
    public virtual object Get(int index) { return default(object); }
    public virtual object Get(string name) { return default(object); }
    public override System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public virtual string GetKey(int index) { return default(string); }
    public virtual void Lock() { }
    public virtual void Remove(string name) { }
    public virtual void RemoveAll() { }
    public virtual void RemoveAt(int index) { }
    public virtual void Set(string name, object value) { }
    public virtual void UnLock() { }
  }
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class HttpApplicationStateWrapper : System.Web.HttpApplicationStateBase {
    public HttpApplicationStateWrapper(System.Web.HttpApplicationState httpApplicationState) { }
    public override System.String[] AllKeys { get { return default(System.String[]); } }
    public override System.Web.HttpApplicationStateBase Contents { get { return default(System.Web.HttpApplicationStateBase); } }
    public override int Count { get { return default(int); } }
    public override bool IsSynchronized { get { return default(bool); } }
    public override object this[int index] { get { return default(object); } }
    public override object this[string name] { get { return default(object); } set { } }
    public override System.Collections.Specialized.NameObjectCollectionBase.KeysCollection Keys { get { return default(System.Collections.Specialized.NameObjectCollectionBase.KeysCollection); } }
    public override System.Web.HttpStaticObjectsCollectionBase StaticObjects { get { return default(System.Web.HttpStaticObjectsCollectionBase); } }
    public override object SyncRoot { get { return default(object); } }
    public override void Add(string name, object value) { }
    public override void Clear() { }
    public override void CopyTo(System.Array array, int index) { }
    public override object Get(int index) { return default(object); }
    public override object Get(string name) { return default(object); }
    public override System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public override string GetKey(int index) { return default(string); }
    [System.MonoTODOAttribute]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public override void Lock() { }
    public override void OnDeserialization(object sender) { }
    public override void Remove(string name) { }
    public override void RemoveAll() { }
    public override void RemoveAt(int index) { }
    public override void Set(string name, object value) { }
    public override void UnLock() { }
  }
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public abstract partial class HttpBrowserCapabilitiesBase : System.Web.UI.IFilterResolutionService {
    protected HttpBrowserCapabilitiesBase() { }
    public virtual bool ActiveXControls { get { return default(bool); } }
    public virtual System.Collections.IDictionary Adapters { get { return default(System.Collections.IDictionary); } }
    public virtual bool AOL { get { return default(bool); } }
    public virtual bool BackgroundSounds { get { return default(bool); } }
    public virtual bool Beta { get { return default(bool); } }
    public virtual string Browser { get { return default(string); } }
    public virtual System.Collections.ArrayList Browsers { get { return default(System.Collections.ArrayList); } }
    public virtual bool CanCombineFormsInDeck { get { return default(bool); } }
    public virtual bool CanInitiateVoiceCall { get { return default(bool); } }
    public virtual bool CanRenderAfterInputOrSelectElement { get { return default(bool); } }
    public virtual bool CanRenderEmptySelects { get { return default(bool); } }
    public virtual bool CanRenderInputAndSelectElementsTogether { get { return default(bool); } }
    public virtual bool CanRenderMixedSelects { get { return default(bool); } }
    public virtual bool CanRenderOneventAndPrevElementsTogether { get { return default(bool); } }
    public virtual bool CanRenderPostBackCards { get { return default(bool); } }
    public virtual bool CanRenderSetvarZeroWithMultiSelectionList { get { return default(bool); } }
    public virtual bool CanSendMail { get { return default(bool); } }
    public virtual System.Collections.IDictionary Capabilities { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.IDictionary); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public virtual bool CDF { get { return default(bool); } }
    public virtual System.Version ClrVersion { get { return default(System.Version); } }
    public virtual bool Cookies { get { return default(bool); } }
    public virtual bool Crawler { get { return default(bool); } }
    public virtual int DefaultSubmitButtonLimit { get { return default(int); } }
    public virtual System.Version EcmaScriptVersion { get { return default(System.Version); } }
    public virtual bool Frames { get { return default(bool); } }
    public virtual int GatewayMajorVersion { get { return default(int); } }
    public virtual double GatewayMinorVersion { get { return default(double); } }
    public virtual string GatewayVersion { get { return default(string); } }
    public virtual bool HasBackButton { get { return default(bool); } }
    public virtual bool HidesRightAlignedMultiselectScrollbars { get { return default(bool); } }
    public virtual string HtmlTextWriter { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public virtual string Id { get { return default(string); } }
    public virtual string InputType { get { return default(string); } }
    public virtual bool IsColor { get { return default(bool); } }
    public virtual bool IsMobileDevice { get { return default(bool); } }
    public virtual string this[string key] { get { return default(string); } }
    public virtual bool JavaApplets { get { return default(bool); } }
    public virtual System.Version JScriptVersion { get { return default(System.Version); } }
    public virtual int MajorVersion { get { return default(int); } }
    public virtual int MaximumHrefLength { get { return default(int); } }
    public virtual int MaximumRenderedPageSize { get { return default(int); } }
    public virtual int MaximumSoftkeyLabelLength { get { return default(int); } }
    public virtual double MinorVersion { get { return default(double); } }
    public virtual string MinorVersionString { get { return default(string); } }
    public virtual string MobileDeviceManufacturer { get { return default(string); } }
    public virtual string MobileDeviceModel { get { return default(string); } }
    public virtual System.Version MSDomVersion { get { return default(System.Version); } }
    public virtual int NumberOfSoftkeys { get { return default(int); } }
    public virtual string Platform { get { return default(string); } }
    public virtual string PreferredImageMime { get { return default(string); } }
    public virtual string PreferredRenderingMime { get { return default(string); } }
    public virtual string PreferredRenderingType { get { return default(string); } }
    public virtual string PreferredRequestEncoding { get { return default(string); } }
    public virtual string PreferredResponseEncoding { get { return default(string); } }
    public virtual bool RendersBreakBeforeWmlSelectAndInput { get { return default(bool); } }
    public virtual bool RendersBreaksAfterHtmlLists { get { return default(bool); } }
    public virtual bool RendersBreaksAfterWmlAnchor { get { return default(bool); } }
    public virtual bool RendersBreaksAfterWmlInput { get { return default(bool); } }
    public virtual bool RendersWmlDoAcceptsInline { get { return default(bool); } }
    public virtual bool RendersWmlSelectsAsMenuCards { get { return default(bool); } }
    public virtual string RequiredMetaTagNameValue { get { return default(string); } }
    public virtual bool RequiresAttributeColonSubstitution { get { return default(bool); } }
    public virtual bool RequiresContentTypeMetaTag { get { return default(bool); } }
    public virtual bool RequiresControlStateInSession { get { return default(bool); } }
    public virtual bool RequiresDBCSCharacter { get { return default(bool); } }
    public virtual bool RequiresHtmlAdaptiveErrorReporting { get { return default(bool); } }
    public virtual bool RequiresLeadingPageBreak { get { return default(bool); } }
    public virtual bool RequiresNoBreakInFormatting { get { return default(bool); } }
    public virtual bool RequiresOutputOptimization { get { return default(bool); } }
    public virtual bool RequiresPhoneNumbersAsPlainText { get { return default(bool); } }
    public virtual bool RequiresSpecialViewStateEncoding { get { return default(bool); } }
    public virtual bool RequiresUniqueFilePathSuffix { get { return default(bool); } }
    public virtual bool RequiresUniqueHtmlCheckboxNames { get { return default(bool); } }
    public virtual bool RequiresUniqueHtmlInputNames { get { return default(bool); } }
    public virtual bool RequiresUrlEncodedPostfieldValues { get { return default(bool); } }
    public virtual int ScreenBitDepth { get { return default(int); } }
    public virtual int ScreenCharactersHeight { get { return default(int); } }
    public virtual int ScreenCharactersWidth { get { return default(int); } }
    public virtual int ScreenPixelsHeight { get { return default(int); } }
    public virtual int ScreenPixelsWidth { get { return default(int); } }
    public virtual bool SupportsAccesskeyAttribute { get { return default(bool); } }
    public virtual bool SupportsBodyColor { get { return default(bool); } }
    public virtual bool SupportsBold { get { return default(bool); } }
    public virtual bool SupportsCacheControlMetaTag { get { return default(bool); } }
    public virtual bool SupportsCallback { get { return default(bool); } }
    public virtual bool SupportsCss { get { return default(bool); } }
    public virtual bool SupportsDivAlign { get { return default(bool); } }
    public virtual bool SupportsDivNoWrap { get { return default(bool); } }
    public virtual bool SupportsEmptyStringInCookieValue { get { return default(bool); } }
    public virtual bool SupportsFontColor { get { return default(bool); } }
    public virtual bool SupportsFontName { get { return default(bool); } }
    public virtual bool SupportsFontSize { get { return default(bool); } }
    public virtual bool SupportsImageSubmit { get { return default(bool); } }
    public virtual bool SupportsIModeSymbols { get { return default(bool); } }
    public virtual bool SupportsInputIStyle { get { return default(bool); } }
    public virtual bool SupportsInputMode { get { return default(bool); } }
    public virtual bool SupportsItalic { get { return default(bool); } }
    public virtual bool SupportsJPhoneMultiMediaAttributes { get { return default(bool); } }
    public virtual bool SupportsJPhoneSymbols { get { return default(bool); } }
    public virtual bool SupportsQueryStringInFormAction { get { return default(bool); } }
    public virtual bool SupportsRedirectWithCookie { get { return default(bool); } }
    public virtual bool SupportsSelectMultiple { get { return default(bool); } }
    public virtual bool SupportsUncheck { get { return default(bool); } }
    public virtual bool SupportsXmlHttp { get { return default(bool); } }
    public virtual bool Tables { get { return default(bool); } }
    public virtual System.Type TagWriter { get { return default(System.Type); } }
    public virtual string Type { get { return default(string); } }
    public virtual bool UseOptimizedCacheKey { get { return default(bool); } }
    public virtual bool VBScript { get { return default(bool); } }
    public virtual string Version { get { return default(string); } }
    public virtual System.Version W3CDomVersion { get { return default(System.Version); } }
    public virtual bool Win16 { get { return default(bool); } }
    public virtual bool Win32 { get { return default(bool); } }
    public virtual void AddBrowser(string browserName) { }
    public virtual int CompareFilters(string filter1, string filter2) { return default(int); }
    public virtual System.Web.UI.HtmlTextWriter CreateHtmlTextWriter(System.IO.TextWriter w) { return default(System.Web.UI.HtmlTextWriter); }
    public virtual void DisableOptimizedCacheKey() { }
    public virtual bool EvaluateFilter(string filterName) { return default(bool); }
    public virtual System.Version[] GetClrVersions() { return default(System.Version[]); }
    public virtual bool IsBrowser(string browserName) { return default(bool); }
  }
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class HttpBrowserCapabilitiesWrapper : System.Web.HttpBrowserCapabilitiesBase {
    public HttpBrowserCapabilitiesWrapper(System.Web.HttpBrowserCapabilities httpBrowserCapabilities) { }
    public override bool ActiveXControls { get { return default(bool); } }
    public override System.Collections.IDictionary Adapters { get { return default(System.Collections.IDictionary); } }
    public override bool AOL { get { return default(bool); } }
    public override bool BackgroundSounds { get { return default(bool); } }
    public override bool Beta { get { return default(bool); } }
    public override string Browser { get { return default(string); } }
    public override System.Collections.ArrayList Browsers { get { return default(System.Collections.ArrayList); } }
    public override bool CanCombineFormsInDeck { get { return default(bool); } }
    public override bool CanInitiateVoiceCall { get { return default(bool); } }
    public override bool CanRenderAfterInputOrSelectElement { get { return default(bool); } }
    public override bool CanRenderEmptySelects { get { return default(bool); } }
    public override bool CanRenderInputAndSelectElementsTogether { get { return default(bool); } }
    public override bool CanRenderMixedSelects { get { return default(bool); } }
    public override bool CanRenderOneventAndPrevElementsTogether { get { return default(bool); } }
    public override bool CanRenderPostBackCards { get { return default(bool); } }
    public override bool CanRenderSetvarZeroWithMultiSelectionList { get { return default(bool); } }
    public override bool CanSendMail { get { return default(bool); } }
    public override System.Collections.IDictionary Capabilities { get { return default(System.Collections.IDictionary); } set { } }
    public override bool CDF { get { return default(bool); } }
    public override System.Version ClrVersion { get { return default(System.Version); } }
    public override bool Cookies { get { return default(bool); } }
    public override bool Crawler { get { return default(bool); } }
    public override int DefaultSubmitButtonLimit { get { return default(int); } }
    public override System.Version EcmaScriptVersion { get { return default(System.Version); } }
    public override bool Frames { get { return default(bool); } }
    public override int GatewayMajorVersion { get { return default(int); } }
    public override double GatewayMinorVersion { get { return default(double); } }
    public override string GatewayVersion { get { return default(string); } }
    public override bool HasBackButton { get { return default(bool); } }
    public override bool HidesRightAlignedMultiselectScrollbars { get { return default(bool); } }
    public override string HtmlTextWriter { get { return default(string); } set { } }
    public override string Id { get { return default(string); } }
    public override string InputType { get { return default(string); } }
    public override bool IsColor { get { return default(bool); } }
    public override bool IsMobileDevice { get { return default(bool); } }
    public override string this[string key] { get { return default(string); } }
    public override bool JavaApplets { get { return default(bool); } }
    public override System.Version JScriptVersion { get { return default(System.Version); } }
    public override int MajorVersion { get { return default(int); } }
    public override int MaximumHrefLength { get { return default(int); } }
    public override int MaximumRenderedPageSize { get { return default(int); } }
    public override int MaximumSoftkeyLabelLength { get { return default(int); } }
    public override double MinorVersion { get { return default(double); } }
    public override string MinorVersionString { get { return default(string); } }
    public override string MobileDeviceManufacturer { get { return default(string); } }
    public override string MobileDeviceModel { get { return default(string); } }
    public override System.Version MSDomVersion { get { return default(System.Version); } }
    public override int NumberOfSoftkeys { get { return default(int); } }
    public override string Platform { get { return default(string); } }
    public override string PreferredImageMime { get { return default(string); } }
    public override string PreferredRenderingMime { get { return default(string); } }
    public override string PreferredRenderingType { get { return default(string); } }
    public override string PreferredRequestEncoding { get { return default(string); } }
    public override string PreferredResponseEncoding { get { return default(string); } }
    public override bool RendersBreakBeforeWmlSelectAndInput { get { return default(bool); } }
    public override bool RendersBreaksAfterHtmlLists { get { return default(bool); } }
    public override bool RendersBreaksAfterWmlAnchor { get { return default(bool); } }
    public override bool RendersBreaksAfterWmlInput { get { return default(bool); } }
    public override bool RendersWmlDoAcceptsInline { get { return default(bool); } }
    public override bool RendersWmlSelectsAsMenuCards { get { return default(bool); } }
    public override string RequiredMetaTagNameValue { get { return default(string); } }
    public override bool RequiresAttributeColonSubstitution { get { return default(bool); } }
    public override bool RequiresContentTypeMetaTag { get { return default(bool); } }
    public override bool RequiresControlStateInSession { get { return default(bool); } }
    public override bool RequiresDBCSCharacter { get { return default(bool); } }
    public override bool RequiresHtmlAdaptiveErrorReporting { get { return default(bool); } }
    public override bool RequiresLeadingPageBreak { get { return default(bool); } }
    public override bool RequiresNoBreakInFormatting { get { return default(bool); } }
    public override bool RequiresOutputOptimization { get { return default(bool); } }
    public override bool RequiresPhoneNumbersAsPlainText { get { return default(bool); } }
    public override bool RequiresSpecialViewStateEncoding { get { return default(bool); } }
    public override bool RequiresUniqueFilePathSuffix { get { return default(bool); } }
    public override bool RequiresUniqueHtmlCheckboxNames { get { return default(bool); } }
    public override bool RequiresUniqueHtmlInputNames { get { return default(bool); } }
    public override bool RequiresUrlEncodedPostfieldValues { get { return default(bool); } }
    public override int ScreenBitDepth { get { return default(int); } }
    public override int ScreenCharactersHeight { get { return default(int); } }
    public override int ScreenCharactersWidth { get { return default(int); } }
    public override int ScreenPixelsHeight { get { return default(int); } }
    public override int ScreenPixelsWidth { get { return default(int); } }
    public override bool SupportsAccesskeyAttribute { get { return default(bool); } }
    public override bool SupportsBodyColor { get { return default(bool); } }
    public override bool SupportsBold { get { return default(bool); } }
    public override bool SupportsCacheControlMetaTag { get { return default(bool); } }
    public override bool SupportsCallback { get { return default(bool); } }
    public override bool SupportsCss { get { return default(bool); } }
    public override bool SupportsDivAlign { get { return default(bool); } }
    public override bool SupportsDivNoWrap { get { return default(bool); } }
    public override bool SupportsEmptyStringInCookieValue { get { return default(bool); } }
    public override bool SupportsFontColor { get { return default(bool); } }
    public override bool SupportsFontName { get { return default(bool); } }
    public override bool SupportsFontSize { get { return default(bool); } }
    public override bool SupportsImageSubmit { get { return default(bool); } }
    public override bool SupportsIModeSymbols { get { return default(bool); } }
    public override bool SupportsInputIStyle { get { return default(bool); } }
    public override bool SupportsInputMode { get { return default(bool); } }
    public override bool SupportsItalic { get { return default(bool); } }
    public override bool SupportsJPhoneMultiMediaAttributes { get { return default(bool); } }
    public override bool SupportsJPhoneSymbols { get { return default(bool); } }
    public override bool SupportsQueryStringInFormAction { get { return default(bool); } }
    public override bool SupportsRedirectWithCookie { get { return default(bool); } }
    public override bool SupportsSelectMultiple { get { return default(bool); } }
    public override bool SupportsUncheck { get { return default(bool); } }
    public override bool SupportsXmlHttp { get { return default(bool); } }
    public override bool Tables { get { return default(bool); } }
    public override System.Type TagWriter { get { return default(System.Type); } }
    public override string Type { get { return default(string); } }
    public override bool UseOptimizedCacheKey { get { return default(bool); } }
    public override bool VBScript { get { return default(bool); } }
    public override string Version { get { return default(string); } }
    public override System.Version W3CDomVersion { get { return default(System.Version); } }
    public override bool Win16 { get { return default(bool); } }
    public override bool Win32 { get { return default(bool); } }
    public override void AddBrowser(string browserName) { }
    [System.MonoTODOAttribute]
    public override int CompareFilters(string filter1, string filter2) { return default(int); }
    [System.MonoTODOAttribute]
    public override System.Web.UI.HtmlTextWriter CreateHtmlTextWriter(System.IO.TextWriter w) { return default(System.Web.UI.HtmlTextWriter); }
    public override void DisableOptimizedCacheKey() { }
    [System.MonoTODOAttribute]
    public override bool EvaluateFilter(string filterName) { return default(bool); }
    public override System.Version[] GetClrVersions() { return default(System.Version[]); }
    public override bool IsBrowser(string browserName) { return default(bool); }
  }
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public abstract partial class HttpCachePolicyBase {
    protected HttpCachePolicyBase() { }
    public virtual System.Web.HttpCacheVaryByContentEncodings VaryByContentEncodings { get { return default(System.Web.HttpCacheVaryByContentEncodings); } }
    public virtual System.Web.HttpCacheVaryByHeaders VaryByHeaders { get { return default(System.Web.HttpCacheVaryByHeaders); } }
    public virtual System.Web.HttpCacheVaryByParams VaryByParams { get { return default(System.Web.HttpCacheVaryByParams); } }
    public virtual void AddValidationCallback(System.Web.HttpCacheValidateHandler handler, object data) { }
    public virtual void AppendCacheExtension(string extension) { }
    public virtual void SetAllowResponseInBrowserHistory(bool allow) { }
    public virtual void SetCacheability(System.Web.HttpCacheability cacheability) { }
    public virtual void SetCacheability(System.Web.HttpCacheability cacheability, string field) { }
    public virtual void SetETag(string etag) { }
    public virtual void SetETagFromFileDependencies() { }
    public virtual void SetExpires(System.DateTime date) { }
    public virtual void SetLastModified(System.DateTime date) { }
    public virtual void SetLastModifiedFromFileDependencies() { }
    public virtual void SetMaxAge(System.TimeSpan delta) { }
    public virtual void SetNoServerCaching() { }
    public virtual void SetNoStore() { }
    public virtual void SetNoTransforms() { }
    public virtual void SetOmitVaryStar(bool omit) { }
    public virtual void SetProxyMaxAge(System.TimeSpan delta) { }
    public virtual void SetRevalidation(System.Web.HttpCacheRevalidation revalidation) { }
    public virtual void SetSlidingExpiration(bool slide) { }
    public virtual void SetValidUntilExpires(bool validUntilExpires) { }
    public virtual void SetVaryByCustom(string custom) { }
  }
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class HttpCachePolicyWrapper : System.Web.HttpCachePolicyBase {
    public HttpCachePolicyWrapper(System.Web.HttpCachePolicy httpCachePolicy) { }
    public override System.Web.HttpCacheVaryByContentEncodings VaryByContentEncodings { get { return default(System.Web.HttpCacheVaryByContentEncodings); } }
    public override System.Web.HttpCacheVaryByHeaders VaryByHeaders { get { return default(System.Web.HttpCacheVaryByHeaders); } }
    public override System.Web.HttpCacheVaryByParams VaryByParams { get { return default(System.Web.HttpCacheVaryByParams); } }
    public override void AddValidationCallback(System.Web.HttpCacheValidateHandler handler, object data) { }
    public override void AppendCacheExtension(string extension) { }
    public override void SetAllowResponseInBrowserHistory(bool allow) { }
    public override void SetCacheability(System.Web.HttpCacheability cacheability) { }
    public override void SetCacheability(System.Web.HttpCacheability cacheability, string field) { }
    public override void SetETag(string etag) { }
    public override void SetETagFromFileDependencies() { }
    public override void SetExpires(System.DateTime date) { }
    public override void SetLastModified(System.DateTime date) { }
    public override void SetLastModifiedFromFileDependencies() { }
    public override void SetMaxAge(System.TimeSpan delta) { }
    public override void SetNoServerCaching() { }
    public override void SetNoStore() { }
    public override void SetNoTransforms() { }
    public override void SetOmitVaryStar(bool omit) { }
    public override void SetProxyMaxAge(System.TimeSpan delta) { }
    public override void SetRevalidation(System.Web.HttpCacheRevalidation revalidation) { }
    public override void SetSlidingExpiration(bool slide) { }
    public override void SetValidUntilExpires(bool validUntilExpires) { }
    public override void SetVaryByCustom(string custom) { }
  }
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public abstract partial class HttpContextBase : System.IServiceProvider {
    protected HttpContextBase() { }
    public virtual System.Exception[] AllErrors { get { return default(System.Exception[]); } }
    public virtual System.Web.HttpApplicationStateBase Application { get { return default(System.Web.HttpApplicationStateBase); } }
    public virtual System.Web.HttpApplication ApplicationInstance { get { return default(System.Web.HttpApplication); } set { } }
    public virtual System.Web.Caching.Cache Cache { get { return default(System.Web.Caching.Cache); } }
    public virtual System.Web.IHttpHandler CurrentHandler { get { return default(System.Web.IHttpHandler); } }
    public virtual System.Web.RequestNotification CurrentNotification { get { return default(System.Web.RequestNotification); } }
    public virtual System.Exception Error { get { return default(System.Exception); } }
    public virtual System.Web.IHttpHandler Handler { get { return default(System.Web.IHttpHandler); } set { } }
    public virtual bool IsCustomErrorEnabled { get { return default(bool); } }
    public virtual bool IsDebuggingEnabled { get { return default(bool); } }
    public virtual bool IsPostNotification { get { return default(bool); } }
    public virtual System.Collections.IDictionary Items { get { return default(System.Collections.IDictionary); } }
    public virtual System.Web.IHttpHandler PreviousHandler { get { return default(System.Web.IHttpHandler); } }
    public virtual System.Web.Profile.ProfileBase Profile { get { return default(System.Web.Profile.ProfileBase); } }
    public virtual System.Web.HttpRequestBase Request { get { return default(System.Web.HttpRequestBase); } }
    public virtual System.Web.HttpResponseBase Response { get { return default(System.Web.HttpResponseBase); } }
    public virtual System.Web.HttpServerUtilityBase Server { get { return default(System.Web.HttpServerUtilityBase); } }
    public virtual System.Web.HttpSessionStateBase Session { get { return default(System.Web.HttpSessionStateBase); } }
    public virtual bool SkipAuthorization { get { return default(bool); } set { } }
    public virtual System.DateTime Timestamp { get { return default(System.DateTime); } }
    public virtual System.Web.TraceContext Trace { get { return default(System.Web.TraceContext); } }
    public virtual System.Security.Principal.IPrincipal User { get { return default(System.Security.Principal.IPrincipal); } set { } }
    public virtual void AddError(System.Exception errorInfo) { }
    public virtual void ClearError() { }
    public virtual object GetGlobalResourceObject(string classKey, string resourceKey) { return default(object); }
    public virtual object GetGlobalResourceObject(string classKey, string resourceKey, System.Globalization.CultureInfo culture) { return default(object); }
    public virtual object GetLocalResourceObject(string virtualPath, string resourceKey) { return default(object); }
    public virtual object GetLocalResourceObject(string virtualPath, string resourceKey, System.Globalization.CultureInfo culture) { return default(object); }
    public virtual object GetSection(string sectionName) { return default(object); }
    public virtual object GetService(System.Type serviceType) { return default(object); }
    public virtual void RewritePath(string path) { }
    public virtual void RewritePath(string path, bool rebaseClientPath) { }
    public virtual void RewritePath(string filePath, string pathInfo, string queryString) { }
    public virtual void RewritePath(string filePath, string pathInfo, string queryString, bool setClientFilePath) { }
  }
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class HttpContextWrapper : System.Web.HttpContextBase {
    public HttpContextWrapper(System.Web.HttpContext httpContext) { }
    public override System.Exception[] AllErrors { get { return default(System.Exception[]); } }
    public override System.Web.HttpApplicationStateBase Application { get { return default(System.Web.HttpApplicationStateBase); } }
    public override System.Web.HttpApplication ApplicationInstance { get { return default(System.Web.HttpApplication); } set { } }
    public override System.Web.Caching.Cache Cache { get { return default(System.Web.Caching.Cache); } }
    public override System.Web.IHttpHandler CurrentHandler { get { return default(System.Web.IHttpHandler); } }
    public override System.Web.RequestNotification CurrentNotification { get { return default(System.Web.RequestNotification); } }
    public override System.Exception Error { get { return default(System.Exception); } }
    public override System.Web.IHttpHandler Handler { get { return default(System.Web.IHttpHandler); } set { } }
    public override bool IsCustomErrorEnabled { get { return default(bool); } }
    public override bool IsDebuggingEnabled { get { return default(bool); } }
    public override bool IsPostNotification { get { return default(bool); } }
    public override System.Collections.IDictionary Items { get { return default(System.Collections.IDictionary); } }
    public override System.Web.IHttpHandler PreviousHandler { get { return default(System.Web.IHttpHandler); } }
    public override System.Web.Profile.ProfileBase Profile { get { return default(System.Web.Profile.ProfileBase); } }
    public override System.Web.HttpRequestBase Request { get { return default(System.Web.HttpRequestBase); } }
    public override System.Web.HttpResponseBase Response { get { return default(System.Web.HttpResponseBase); } }
    public override System.Web.HttpServerUtilityBase Server { get { return default(System.Web.HttpServerUtilityBase); } }
    public override System.Web.HttpSessionStateBase Session { get { return default(System.Web.HttpSessionStateBase); } }
    public override bool SkipAuthorization { get { return default(bool); } set { } }
    public override System.DateTime Timestamp { get { return default(System.DateTime); } }
    public override System.Web.TraceContext Trace { get { return default(System.Web.TraceContext); } }
    public override System.Security.Principal.IPrincipal User { get { return default(System.Security.Principal.IPrincipal); } set { } }
    public override void AddError(System.Exception errorInfo) { }
    public override void ClearError() { }
    public override object GetGlobalResourceObject(string classKey, string resourceKey) { return default(object); }
    public override object GetGlobalResourceObject(string classKey, string resourceKey, System.Globalization.CultureInfo culture) { return default(object); }
    public override object GetLocalResourceObject(string overridePath, string resourceKey) { return default(object); }
    public override object GetLocalResourceObject(string overridePath, string resourceKey, System.Globalization.CultureInfo culture) { return default(object); }
    public override object GetSection(string sectionName) { return default(object); }
    [System.MonoTODOAttribute]
    public override object GetService(System.Type serviceType) { return default(object); }
    public override void RewritePath(string path) { }
    public override void RewritePath(string path, bool rebaseClientPath) { }
    public override void RewritePath(string filePath, string pathInfo, string queryString) { }
    public override void RewritePath(string filePath, string pathInfo, string queryString, bool setClientFilePath) { }
  }
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public abstract partial class HttpFileCollectionBase : System.Collections.Specialized.NameObjectCollectionBase, System.Collections.ICollection, System.Collections.IEnumerable {
    protected HttpFileCollectionBase() { }
    public virtual System.String[] AllKeys { get { return default(System.String[]); } }
    public override int Count { get { return default(int); } }
    public virtual bool IsSynchronized { get { return default(bool); } }
    public virtual System.Web.HttpPostedFileBase this[int index] { get { return default(System.Web.HttpPostedFileBase); } }
    public virtual System.Web.HttpPostedFileBase this[string name] { get { return default(System.Web.HttpPostedFileBase); } }
    public virtual object SyncRoot { get { return default(object); } }
    public virtual void CopyTo(System.Array dest, int index) { }
    public virtual System.Web.HttpPostedFileBase Get(int index) { return default(System.Web.HttpPostedFileBase); }
    public virtual System.Web.HttpPostedFileBase Get(string name) { return default(System.Web.HttpPostedFileBase); }
    public override System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public virtual string GetKey(int index) { return default(string); }
  }
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class HttpFileCollectionWrapper : System.Web.HttpFileCollectionBase {
    public HttpFileCollectionWrapper(System.Web.HttpFileCollection httpFileCollection) { }
    public override System.String[] AllKeys { get { return default(System.String[]); } }
    public override int Count { get { return default(int); } }
    public override bool IsSynchronized { get { return default(bool); } }
    public override System.Web.HttpPostedFileBase this[int index] { get { return default(System.Web.HttpPostedFileBase); } }
    public override System.Web.HttpPostedFileBase this[string name] { get { return default(System.Web.HttpPostedFileBase); } }
    public override System.Collections.Specialized.NameObjectCollectionBase.KeysCollection Keys { get { return default(System.Collections.Specialized.NameObjectCollectionBase.KeysCollection); } }
    public override object SyncRoot { get { return default(object); } }
    public override void CopyTo(System.Array dest, int index) { }
    public override System.Web.HttpPostedFileBase Get(int index) { return default(System.Web.HttpPostedFileBase); }
    public override System.Web.HttpPostedFileBase Get(string name) { return default(System.Web.HttpPostedFileBase); }
    public override System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public override string GetKey(int index) { return default(string); }
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public override void OnDeserialization(object sender) { }
  }
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public abstract partial class HttpPostedFileBase {
    protected HttpPostedFileBase() { }
    public virtual int ContentLength { get { return default(int); } }
    public virtual string ContentType { get { return default(string); } }
    public virtual string FileName { get { return default(string); } }
    public virtual System.IO.Stream InputStream { get { return default(System.IO.Stream); } }
    public virtual void SaveAs(string filename) { }
  }
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class HttpPostedFileWrapper : System.Web.HttpPostedFileBase {
    public HttpPostedFileWrapper(System.Web.HttpPostedFile httpPostedFile) { }
    public override int ContentLength { get { return default(int); } }
    public override string ContentType { get { return default(string); } }
    public override string FileName { get { return default(string); } }
    public override System.IO.Stream InputStream { get { return default(System.IO.Stream); } }
    public override void SaveAs(string filename) { }
  }
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public abstract partial class HttpRequestBase {
    protected HttpRequestBase() { }
    public virtual System.String[] AcceptTypes { get { return default(System.String[]); } }
    public virtual string AnonymousID { get { return default(string); } }
    public virtual string ApplicationPath { get { return default(string); } }
    public virtual string AppRelativeCurrentExecutionFilePath { get { return default(string); } }
    public virtual System.Web.HttpBrowserCapabilitiesBase Browser { get { return default(System.Web.HttpBrowserCapabilitiesBase); } }
    public virtual System.Web.HttpClientCertificate ClientCertificate { get { return default(System.Web.HttpClientCertificate); } }
    public virtual System.Text.Encoding ContentEncoding { get { return default(System.Text.Encoding); } set { } }
    public virtual int ContentLength { get { return default(int); } }
    public virtual string ContentType { get { return default(string); } set { } }
    public virtual System.Web.HttpCookieCollection Cookies { get { return default(System.Web.HttpCookieCollection); } }
    public virtual string CurrentExecutionFilePath { get { return default(string); } }
    public virtual string FilePath { get { return default(string); } }
    public virtual System.Web.HttpFileCollectionBase Files { get { return default(System.Web.HttpFileCollectionBase); } }
    public virtual System.IO.Stream Filter { get { return default(System.IO.Stream); } set { } }
    public virtual System.Collections.Specialized.NameValueCollection Form { get { return default(System.Collections.Specialized.NameValueCollection); } }
    public virtual System.Collections.Specialized.NameValueCollection Headers { get { return default(System.Collections.Specialized.NameValueCollection); } }
    public virtual string HttpMethod { get { return default(string); } }
    public virtual System.IO.Stream InputStream { get { return default(System.IO.Stream); } }
    public virtual bool IsAuthenticated { get { return default(bool); } }
    public virtual bool IsLocal { get { return default(bool); } }
    public virtual bool IsSecureConnection { get { return default(bool); } }
    public virtual string this[string key] { get { return default(string); } }
    public virtual System.Security.Principal.WindowsIdentity LogonUserIdentity { get { return default(System.Security.Principal.WindowsIdentity); } }
    public virtual System.Collections.Specialized.NameValueCollection Params { get { return default(System.Collections.Specialized.NameValueCollection); } }
    public virtual string Path { get { return default(string); } }
    public virtual string PathInfo { get { return default(string); } }
    public virtual string PhysicalApplicationPath { get { return default(string); } }
    public virtual string PhysicalPath { get { return default(string); } }
    public virtual System.Collections.Specialized.NameValueCollection QueryString { get { return default(System.Collections.Specialized.NameValueCollection); } }
    public virtual string RawUrl { get { return default(string); } }
    public virtual string RequestType { get { return default(string); } set { } }
    public virtual System.Collections.Specialized.NameValueCollection ServerVariables { get { return default(System.Collections.Specialized.NameValueCollection); } }
    public virtual int TotalBytes { get { return default(int); } }
    public virtual System.Uri Url { get { return default(System.Uri); } }
    public virtual System.Uri UrlReferrer { get { return default(System.Uri); } }
    public virtual string UserAgent { get { return default(string); } }
    public virtual string UserHostAddress { get { return default(string); } }
    public virtual string UserHostName { get { return default(string); } }
    public virtual System.String[] UserLanguages { get { return default(System.String[]); } }
    public virtual System.Byte[] BinaryRead(int count) { return default(System.Byte[]); }
    public virtual System.Int32[] MapImageCoordinates(string imageFieldName) { return default(System.Int32[]); }
    public virtual string MapPath(string virtualPath) { return default(string); }
    public virtual string MapPath(string virtualPath, string baseVirtualDir, bool allowCrossAppMapping) { return default(string); }
    public virtual void SaveAs(string filename, bool includeHeaders) { }
    public virtual void ValidateInput() { }
  }
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class HttpRequestWrapper : System.Web.HttpRequestBase {
    public HttpRequestWrapper(System.Web.HttpRequest httpRequest) { }
    public override System.String[] AcceptTypes { get { return default(System.String[]); } }
    public override string AnonymousID { get { return default(string); } }
    public override string ApplicationPath { get { return default(string); } }
    public override string AppRelativeCurrentExecutionFilePath { get { return default(string); } }
    public override System.Web.HttpBrowserCapabilitiesBase Browser { get { return default(System.Web.HttpBrowserCapabilitiesBase); } }
    public override System.Web.HttpClientCertificate ClientCertificate { get { return default(System.Web.HttpClientCertificate); } }
    public override System.Text.Encoding ContentEncoding { get { return default(System.Text.Encoding); } set { } }
    public override int ContentLength { get { return default(int); } }
    public override string ContentType { get { return default(string); } set { } }
    public override System.Web.HttpCookieCollection Cookies { get { return default(System.Web.HttpCookieCollection); } }
    public override string CurrentExecutionFilePath { get { return default(string); } }
    public override string FilePath { get { return default(string); } }
    public override System.Web.HttpFileCollectionBase Files { get { return default(System.Web.HttpFileCollectionBase); } }
    public override System.IO.Stream Filter { get { return default(System.IO.Stream); } set { } }
    public override System.Collections.Specialized.NameValueCollection Form { get { return default(System.Collections.Specialized.NameValueCollection); } }
    public override System.Collections.Specialized.NameValueCollection Headers { get { return default(System.Collections.Specialized.NameValueCollection); } }
    public override string HttpMethod { get { return default(string); } }
    public override System.IO.Stream InputStream { get { return default(System.IO.Stream); } }
    public override bool IsAuthenticated { get { return default(bool); } }
    public override bool IsLocal { get { return default(bool); } }
    public override bool IsSecureConnection { get { return default(bool); } }
    public override string this[string key] { get { return default(string); } }
    public override System.Security.Principal.WindowsIdentity LogonUserIdentity { get { return default(System.Security.Principal.WindowsIdentity); } }
    public override System.Collections.Specialized.NameValueCollection Params { get { return default(System.Collections.Specialized.NameValueCollection); } }
    public override string Path { get { return default(string); } }
    public override string PathInfo { get { return default(string); } }
    public override string PhysicalApplicationPath { get { return default(string); } }
    public override string PhysicalPath { get { return default(string); } }
    public override System.Collections.Specialized.NameValueCollection QueryString { get { return default(System.Collections.Specialized.NameValueCollection); } }
    public override string RawUrl { get { return default(string); } }
    public override string RequestType { get { return default(string); } set { } }
    public override System.Collections.Specialized.NameValueCollection ServerVariables { get { return default(System.Collections.Specialized.NameValueCollection); } }
    public override int TotalBytes { get { return default(int); } }
    public override System.Uri Url { get { return default(System.Uri); } }
    public override System.Uri UrlReferrer { get { return default(System.Uri); } }
    public override string UserAgent { get { return default(string); } }
    public override string UserHostAddress { get { return default(string); } }
    public override string UserHostName { get { return default(string); } }
    public override System.String[] UserLanguages { get { return default(System.String[]); } }
    public override System.Byte[] BinaryRead(int count) { return default(System.Byte[]); }
    public override System.Int32[] MapImageCoordinates(string imageFieldName) { return default(System.Int32[]); }
    public override string MapPath(string overridePath) { return default(string); }
    public override string MapPath(string overridePath, string baseVirtualDir, bool allowCrossAppMapping) { return default(string); }
    public override void SaveAs(string filename, bool includeHeaders) { }
    public override void ValidateInput() { }
  }
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public abstract partial class HttpResponseBase {
    protected HttpResponseBase() { }
    public virtual bool Buffer { get { return default(bool); } set { } }
    public virtual bool BufferOutput { get { return default(bool); } set { } }
    public virtual System.Web.HttpCachePolicyBase Cache { get { return default(System.Web.HttpCachePolicyBase); } }
    public virtual string CacheControl { get { return default(string); } set { } }
    public virtual string Charset { get { return default(string); } set { } }
    public virtual System.Text.Encoding ContentEncoding { get { return default(System.Text.Encoding); } set { } }
    public virtual string ContentType { get { return default(string); } set { } }
    public virtual System.Web.HttpCookieCollection Cookies { get { return default(System.Web.HttpCookieCollection); } }
    public virtual int Expires { get { return default(int); } set { } }
    public virtual System.DateTime ExpiresAbsolute { get { return default(System.DateTime); } set { } }
    public virtual System.IO.Stream Filter { get { return default(System.IO.Stream); } set { } }
    public virtual System.Text.Encoding HeaderEncoding { get { return default(System.Text.Encoding); } set { } }
    public virtual System.Collections.Specialized.NameValueCollection Headers { get { return default(System.Collections.Specialized.NameValueCollection); } }
    public virtual bool IsClientConnected { get { return default(bool); } }
    public virtual bool IsRequestBeingRedirected { get { return default(bool); } }
    public virtual System.IO.TextWriter Output { get { return default(System.IO.TextWriter); } set { } }
    public virtual System.IO.Stream OutputStream { get { return default(System.IO.Stream); } }
    public virtual string RedirectLocation { get { return default(string); } set { } }
    public virtual string Status { get { return default(string); } set { } }
    public virtual int StatusCode { get { return default(int); } set { } }
    public virtual string StatusDescription { get { return default(string); } set { } }
    public virtual int SubStatusCode { get { return default(int); } set { } }
    public virtual bool SuppressContent { get { return default(bool); } set { } }
    public virtual bool TrySkipIisCustomErrors { get { return default(bool); } set { } }
    public virtual void AddCacheDependency(params System.Web.Caching.CacheDependency[] dependencies) { }
    public virtual void AddCacheItemDependencies(System.Collections.ArrayList cacheKeys) { }
    public virtual void AddCacheItemDependencies(System.String[] cacheKeys) { }
    public virtual void AddCacheItemDependency(string cacheKey) { }
    public virtual void AddFileDependencies(System.Collections.ArrayList filenames) { }
    public virtual void AddFileDependencies(System.String[] filenames) { }
    public virtual void AddFileDependency(string filename) { }
    public virtual void AddHeader(string name, string value) { }
    public virtual void AppendCookie(System.Web.HttpCookie cookie) { }
    public virtual void AppendHeader(string name, string value) { }
    public virtual void AppendToLog(string param) { }
    public virtual string ApplyAppPathModifier(string virtualPath) { return default(string); }
    public virtual void BinaryWrite(System.Byte[] buffer) { }
    public virtual void Clear() { }
    public virtual void ClearContent() { }
    public virtual void ClearHeaders() { }
    public virtual void Close() { }
    public virtual void DisableKernelCache() { }
    public virtual void End() { }
    public virtual void Flush() { }
    public virtual void Pics(string value) { }
    public virtual void Redirect(string url) { }
    public virtual void Redirect(string url, bool endResponse) { }
    public virtual void RemoveOutputCacheItem(string path) { }
    public virtual void SetCookie(System.Web.HttpCookie cookie) { }
    public virtual void TransmitFile(string filename) { }
    public virtual void TransmitFile(string filename, long offset, long length) { }
    public virtual void Write(char ch) { }
    public virtual void Write(System.Char[] buffer, int index, int count) { }
    public virtual void Write(object obj) { }
    public virtual void Write(string s) { }
    public virtual void WriteFile(System.IntPtr fileHandle, long offset, long size) { }
    public virtual void WriteFile(string filename) { }
    public virtual void WriteFile(string filename, bool readIntoMemory) { }
    public virtual void WriteFile(string filename, long offset, long size) { }
    public virtual void WriteSubstitution(System.Web.HttpResponseSubstitutionCallback callback) { }
  }
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class HttpResponseWrapper : System.Web.HttpResponseBase {
    public HttpResponseWrapper(System.Web.HttpResponse httpResponse) { }
    public override bool Buffer { get { return default(bool); } set { } }
    public override bool BufferOutput { get { return default(bool); } set { } }
    public override System.Web.HttpCachePolicyBase Cache { get { return default(System.Web.HttpCachePolicyBase); } }
    public override string CacheControl { get { return default(string); } set { } }
    public override string Charset { get { return default(string); } set { } }
    public override System.Text.Encoding ContentEncoding { get { return default(System.Text.Encoding); } set { } }
    public override string ContentType { get { return default(string); } set { } }
    public override System.Web.HttpCookieCollection Cookies { get { return default(System.Web.HttpCookieCollection); } }
    public override int Expires { get { return default(int); } set { } }
    public override System.DateTime ExpiresAbsolute { get { return default(System.DateTime); } set { } }
    public override System.IO.Stream Filter { get { return default(System.IO.Stream); } set { } }
    public override System.Text.Encoding HeaderEncoding { get { return default(System.Text.Encoding); } set { } }
    public override System.Collections.Specialized.NameValueCollection Headers { get { return default(System.Collections.Specialized.NameValueCollection); } }
    public override bool IsClientConnected { get { return default(bool); } }
    public override bool IsRequestBeingRedirected { get { return default(bool); } }
    public override System.IO.TextWriter Output { get { return default(System.IO.TextWriter); } }
    public override System.IO.Stream OutputStream { get { return default(System.IO.Stream); } }
    public override string RedirectLocation { get { return default(string); } set { } }
    public override string Status { get { return default(string); } set { } }
    public override int StatusCode { get { return default(int); } set { } }
    public override string StatusDescription { get { return default(string); } set { } }
    public override int SubStatusCode { get { return default(int); } set { } }
    public override bool SuppressContent { get { return default(bool); } set { } }
    public override bool TrySkipIisCustomErrors { get { return default(bool); } set { } }
    public override void AddCacheDependency(params System.Web.Caching.CacheDependency[] dependencies) { }
    public override void AddCacheItemDependencies(System.Collections.ArrayList cacheKeys) { }
    public override void AddCacheItemDependencies(System.String[] cacheKeys) { }
    public override void AddCacheItemDependency(string cacheKey) { }
    public override void AddFileDependencies(System.Collections.ArrayList filenames) { }
    public override void AddFileDependencies(System.String[] filenames) { }
    public override void AddFileDependency(string filename) { }
    public override void AddHeader(string name, string value) { }
    public override void AppendCookie(System.Web.HttpCookie cookie) { }
    public override void AppendHeader(string name, string value) { }
    public override void AppendToLog(string param) { }
    public override string ApplyAppPathModifier(string overridePath) { return default(string); }
    public override void BinaryWrite(System.Byte[] buffer) { }
    public override void Clear() { }
    public override void ClearContent() { }
    public override void ClearHeaders() { }
    public override void Close() { }
    public override void DisableKernelCache() { }
    public override void End() { }
    public override void Flush() { }
    public override void Pics(string value) { }
    public override void Redirect(string url) { }
    public override void Redirect(string url, bool endResponse) { }
    public override void RemoveOutputCacheItem(string path) { }
    public override void SetCookie(System.Web.HttpCookie cookie) { }
    public override void TransmitFile(string filename) { }
    public override void TransmitFile(string filename, long offset, long length) { }
    public override void Write(char ch) { }
    public override void Write(System.Char[] buffer, int index, int count) { }
    public override void Write(object obj) { }
    public override void Write(string s) { }
    public override void WriteFile(System.IntPtr fileHandle, long offset, long size) { }
    public override void WriteFile(string filename) { }
    public override void WriteFile(string filename, bool readIntoMemory) { }
    public override void WriteFile(string filename, long offset, long size) { }
    public override void WriteSubstitution(System.Web.HttpResponseSubstitutionCallback callback) { }
  }
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public abstract partial class HttpServerUtilityBase {
    protected HttpServerUtilityBase() { }
    public virtual string MachineName { get { return default(string); } }
    public virtual int ScriptTimeout { get { return default(int); } set { } }
    public virtual void ClearError() { }
    public virtual object CreateObject(string progID) { return default(object); }
    public virtual object CreateObject(System.Type type) { return default(object); }
    public virtual object CreateObjectFromClsid(string clsid) { return default(object); }
    public virtual void Execute(string path) { }
    public virtual void Execute(string path, bool preserveForm) { }
    public virtual void Execute(string path, System.IO.TextWriter writer) { }
    public virtual void Execute(string path, System.IO.TextWriter writer, bool preserveForm) { }
    public virtual void Execute(System.Web.IHttpHandler handler, System.IO.TextWriter writer, bool preserveForm) { }
    public virtual System.Exception GetLastError() { return default(System.Exception); }
    public virtual string HtmlDecode(string s) { return default(string); }
    public virtual void HtmlDecode(string s, System.IO.TextWriter output) { }
    public virtual string HtmlEncode(string s) { return default(string); }
    public virtual void HtmlEncode(string s, System.IO.TextWriter output) { }
    public virtual string MapPath(string path) { return default(string); }
    public virtual void Transfer(string path) { }
    public virtual void Transfer(string path, bool preserveForm) { }
    public virtual void Transfer(System.Web.IHttpHandler handler, bool preserveForm) { }
    public virtual void TransferRequest(string path) { }
    public virtual void TransferRequest(string path, bool preserveForm) { }
    public virtual void TransferRequest(string path, bool preserveForm, string method, System.Collections.Specialized.NameValueCollection headers) { }
    public virtual string UrlDecode(string s) { return default(string); }
    public virtual void UrlDecode(string s, System.IO.TextWriter output) { }
    public virtual string UrlEncode(string s) { return default(string); }
    public virtual void UrlEncode(string s, System.IO.TextWriter output) { }
    public virtual string UrlPathEncode(string s) { return default(string); }
    public virtual System.Byte[] UrlTokenDecode(string input) { return default(System.Byte[]); }
    public virtual string UrlTokenEncode(System.Byte[] input) { return default(string); }
  }
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class HttpServerUtilityWrapper : System.Web.HttpServerUtilityBase {
    public HttpServerUtilityWrapper(System.Web.HttpServerUtility httpServerUtility) { }
    public override string MachineName { get { return default(string); } }
    public override int ScriptTimeout { get { return default(int); } set { } }
    public override void ClearError() { }
    public override object CreateObject(string progID) { return default(object); }
    public override object CreateObject(System.Type type) { return default(object); }
    public override object CreateObjectFromClsid(string clsid) { return default(object); }
    public override void Execute(string path) { }
    public override void Execute(string path, bool preserveForm) { }
    public override void Execute(string path, System.IO.TextWriter writer) { }
    public override void Execute(string path, System.IO.TextWriter writer, bool preserveForm) { }
    public override void Execute(System.Web.IHttpHandler handler, System.IO.TextWriter writer, bool preserveForm) { }
    public override System.Exception GetLastError() { return default(System.Exception); }
    public override string HtmlDecode(string s) { return default(string); }
    public override void HtmlDecode(string s, System.IO.TextWriter output) { }
    public override string HtmlEncode(string s) { return default(string); }
    public override void HtmlEncode(string s, System.IO.TextWriter output) { }
    public override string MapPath(string path) { return default(string); }
    public override void Transfer(string path) { }
    public override void Transfer(string path, bool preserveForm) { }
    public override void Transfer(System.Web.IHttpHandler handler, bool preserveForm) { }
    [System.MonoTODOAttribute]
    public override void TransferRequest(string path) { }
    [System.MonoTODOAttribute]
    public override void TransferRequest(string path, bool preserveForm) { }
    [System.MonoTODOAttribute]
    public override void TransferRequest(string path, bool preserveForm, string method, System.Collections.Specialized.NameValueCollection headers) { }
    public override string UrlDecode(string s) { return default(string); }
    public override void UrlDecode(string s, System.IO.TextWriter output) { }
    public override string UrlEncode(string s) { return default(string); }
    public override void UrlEncode(string s, System.IO.TextWriter output) { }
    public override string UrlPathEncode(string s) { return default(string); }
    [System.MonoTODOAttribute]
    public override System.Byte[] UrlTokenDecode(string input) { return default(System.Byte[]); }
    [System.MonoTODOAttribute]
    public override string UrlTokenEncode(System.Byte[] input) { return default(string); }
  }
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public abstract partial class HttpSessionStateBase : System.Collections.ICollection, System.Collections.IEnumerable {
    protected HttpSessionStateBase() { }
    public virtual int CodePage { get { return default(int); } set { } }
    public virtual System.Web.HttpSessionStateBase Contents { get { return default(System.Web.HttpSessionStateBase); } }
    public virtual System.Web.HttpCookieMode CookieMode { get { return default(System.Web.HttpCookieMode); } }
    public virtual int Count { get { return default(int); } }
    public virtual bool IsCookieless { get { return default(bool); } }
    public virtual bool IsNewSession { get { return default(bool); } }
    public virtual bool IsReadOnly { get { return default(bool); } }
    public virtual bool IsSynchronized { get { return default(bool); } }
    public virtual object this[int index] { get { return default(object); } set { } }
    public virtual object this[string name] { get { return default(object); } set { } }
    public virtual System.Collections.Specialized.NameObjectCollectionBase.KeysCollection Keys { get { return default(System.Collections.Specialized.NameObjectCollectionBase.KeysCollection); } }
    public virtual int LCID { get { return default(int); } set { } }
    public virtual System.Web.SessionState.SessionStateMode Mode { get { return default(System.Web.SessionState.SessionStateMode); } }
    public virtual string SessionID { get { return default(string); } }
    public virtual System.Web.HttpStaticObjectsCollectionBase StaticObjects { get { return default(System.Web.HttpStaticObjectsCollectionBase); } }
    public virtual object SyncRoot { get { return default(object); } }
    public virtual int Timeout { get { return default(int); } set { } }
    public virtual void Abandon() { }
    public virtual void Add(string name, object value) { }
    public virtual void Clear() { }
    public virtual void CopyTo(System.Array array, int index) { }
    public virtual System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public virtual void Remove(string name) { }
    public virtual void RemoveAll() { }
    public virtual void RemoveAt(int index) { }
  }
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class HttpSessionStateWrapper : System.Web.HttpSessionStateBase {
    public HttpSessionStateWrapper(System.Web.SessionState.HttpSessionState httpSessionState) { }
    public override int CodePage { get { return default(int); } set { } }
    public override System.Web.HttpSessionStateBase Contents { get { return default(System.Web.HttpSessionStateBase); } }
    [System.MonoTODOAttribute]
    public override System.Web.HttpCookieMode CookieMode { get { return default(System.Web.HttpCookieMode); } }
    public override int Count { get { return default(int); } }
    public override bool IsCookieless { get { return default(bool); } }
    public override bool IsNewSession { get { return default(bool); } }
    public override bool IsReadOnly { get { return default(bool); } }
    public override bool IsSynchronized { get { return default(bool); } }
    public override object this[int index] { get { return default(object); } set { } }
    public override object this[string name] { get { return default(object); } set { } }
    public override System.Collections.Specialized.NameObjectCollectionBase.KeysCollection Keys { get { return default(System.Collections.Specialized.NameObjectCollectionBase.KeysCollection); } }
    public override int LCID { get { return default(int); } set { } }
    public override System.Web.SessionState.SessionStateMode Mode { get { return default(System.Web.SessionState.SessionStateMode); } }
    public override string SessionID { get { return default(string); } }
    public override System.Web.HttpStaticObjectsCollectionBase StaticObjects { get { return default(System.Web.HttpStaticObjectsCollectionBase); } }
    public override object SyncRoot { get { return default(object); } }
    public override int Timeout { get { return default(int); } set { } }
    public override void Abandon() { }
    public override void Add(string name, object value) { }
    public override void Clear() { }
    public override void CopyTo(System.Array array, int index) { }
    public override System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public override void Remove(string name) { }
    public override void RemoveAll() { }
    public override void RemoveAt(int index) { }
  }
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public abstract partial class HttpStaticObjectsCollectionBase : System.Collections.ICollection, System.Collections.IEnumerable {
    protected HttpStaticObjectsCollectionBase() { }
    public virtual int Count { get { return default(int); } }
    public virtual bool IsReadOnly { get { return default(bool); } }
    public virtual bool IsSynchronized { get { return default(bool); } }
    public virtual object this[string name] { get { return default(object); } }
    public virtual bool NeverAccessed { get { return default(bool); } }
    public virtual object SyncRoot { get { return default(object); } }
    public virtual void CopyTo(System.Array array, int index) { }
    public virtual System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public virtual object GetObject(string name) { return default(object); }
    public virtual void Serialize(System.IO.BinaryWriter writer) { }
  }
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class HttpStaticObjectsCollectionWrapper : System.Web.HttpStaticObjectsCollectionBase {
    public HttpStaticObjectsCollectionWrapper(System.Web.HttpStaticObjectsCollection httpStaticObjectsCollection) { }
    public override int Count { get { return default(int); } }
    public override bool IsReadOnly { get { return default(bool); } }
    public override bool IsSynchronized { get { return default(bool); } }
    public override object this[string name] { get { return default(object); } }
    public override bool NeverAccessed { get { return default(bool); } }
    public override object SyncRoot { get { return default(object); } }
    public override void CopyTo(System.Array array, int index) { }
    public override System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public override object GetObject(string name) { return default(object); }
    public override void Serialize(System.IO.BinaryWriter writer) { }
  }
}
