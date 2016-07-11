namespace System.Web.Routing {
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class HttpMethodConstraint : System.Web.Routing.IRouteConstraint {
    public HttpMethodConstraint(params System.String[] allowedMethods) { }
    public System.Collections.Generic.ICollection<System.String> AllowedMethods { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.ICollection<System.String>); } }
    protected virtual bool Match(System.Web.HttpContextBase httpContext, System.Web.Routing.Route route, string parameterName, System.Web.Routing.RouteValueDictionary values, System.Web.Routing.RouteDirection routeDirection) { return default(bool); }
    bool System.Web.Routing.IRouteConstraint.Match(System.Web.HttpContextBase httpContext, System.Web.Routing.Route route, string parameterName, System.Web.Routing.RouteValueDictionary values, System.Web.Routing.RouteDirection routeDirection) { return default(bool); }
  }
  [System.Web.AspNetHostingPermissionAttribute((System.Security.Permissions.SecurityAction)(6), Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute((System.Security.Permissions.SecurityAction)(7), Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial interface IRouteConstraint {
    bool Match(System.Web.HttpContextBase httpContext, System.Web.Routing.Route route, string parameterName, System.Web.Routing.RouteValueDictionary values, System.Web.Routing.RouteDirection routeDirection);
  }
  [System.Web.AspNetHostingPermissionAttribute((System.Security.Permissions.SecurityAction)(6), Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute((System.Security.Permissions.SecurityAction)(7), Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial interface IRouteHandler {
    System.Web.IHttpHandler GetHttpHandler(System.Web.Routing.RequestContext requestContext);
  }
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class RequestContext {
    public RequestContext(System.Web.HttpContextBase httpContext, System.Web.Routing.RouteData routeData) { }
    public System.Web.HttpContextBase HttpContext { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.HttpContextBase); } }
    public System.Web.Routing.RouteData RouteData { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Routing.RouteData); } }
  }
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class Route : System.Web.Routing.RouteBase {
    public Route(string url, System.Web.Routing.IRouteHandler routeHandler) { }
    public Route(string url, System.Web.Routing.RouteValueDictionary defaults, System.Web.Routing.IRouteHandler routeHandler) { }
    public Route(string url, System.Web.Routing.RouteValueDictionary defaults, System.Web.Routing.RouteValueDictionary constraints, System.Web.Routing.IRouteHandler routeHandler) { }
    public Route(string url, System.Web.Routing.RouteValueDictionary defaults, System.Web.Routing.RouteValueDictionary constraints, System.Web.Routing.RouteValueDictionary dataTokens, System.Web.Routing.IRouteHandler routeHandler) { }
    public System.Web.Routing.RouteValueDictionary Constraints { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Routing.RouteValueDictionary); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Web.Routing.RouteValueDictionary DataTokens { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Routing.RouteValueDictionary); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Web.Routing.RouteValueDictionary Defaults { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Routing.RouteValueDictionary); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Web.Routing.IRouteHandler RouteHandler { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Routing.IRouteHandler); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Url { get { return default(string); } set { } }
    public override System.Web.Routing.RouteData GetRouteData(System.Web.HttpContextBase httpContext) { return default(System.Web.Routing.RouteData); }
    public override System.Web.Routing.VirtualPathData GetVirtualPath(System.Web.Routing.RequestContext requestContext, System.Web.Routing.RouteValueDictionary values) { return default(System.Web.Routing.VirtualPathData); }
    protected virtual bool ProcessConstraint(System.Web.HttpContextBase httpContext, object constraint, string parameterName, System.Web.Routing.RouteValueDictionary values, System.Web.Routing.RouteDirection routeDirection) { return default(bool); }
  }
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public abstract partial class RouteBase {
    protected RouteBase() { }
    public abstract System.Web.Routing.RouteData GetRouteData(System.Web.HttpContextBase httpContext);
    public abstract System.Web.Routing.VirtualPathData GetVirtualPath(System.Web.Routing.RequestContext requestContext, System.Web.Routing.RouteValueDictionary values);
  }
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class RouteCollection : System.Collections.ObjectModel.Collection<System.Web.Routing.RouteBase> {
    public RouteCollection() { }
    public RouteCollection(System.Web.Hosting.VirtualPathProvider virtualPathProvider) { }
    public System.Web.Routing.RouteBase this[string name] { get { return default(System.Web.Routing.RouteBase); } }
    public bool RouteExistingFiles { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public void Add(string name, System.Web.Routing.RouteBase item) { }
    protected override void ClearItems() { }
    public System.IDisposable GetReadLock() { return default(System.IDisposable); }
    public System.Web.Routing.RouteData GetRouteData(System.Web.HttpContextBase httpContext) { return default(System.Web.Routing.RouteData); }
    public System.Web.Routing.VirtualPathData GetVirtualPath(System.Web.Routing.RequestContext requestContext, string name, System.Web.Routing.RouteValueDictionary values) { return default(System.Web.Routing.VirtualPathData); }
    public System.Web.Routing.VirtualPathData GetVirtualPath(System.Web.Routing.RequestContext requestContext, System.Web.Routing.RouteValueDictionary values) { return default(System.Web.Routing.VirtualPathData); }
    public System.IDisposable GetWriteLock() { return default(System.IDisposable); }
    protected override void InsertItem(int index, System.Web.Routing.RouteBase item) { }
    protected override void RemoveItem(int index) { }
    protected override void SetItem(int index, System.Web.Routing.RouteBase item) { }
  }
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class RouteData {
    public RouteData() { }
    public RouteData(System.Web.Routing.RouteBase route, System.Web.Routing.IRouteHandler routeHandler) { }
    public System.Web.Routing.RouteValueDictionary DataTokens { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Routing.RouteValueDictionary); } }
    public System.Web.Routing.RouteBase Route { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Routing.RouteBase); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Web.Routing.IRouteHandler RouteHandler { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Routing.IRouteHandler); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Web.Routing.RouteValueDictionary Values { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Routing.RouteValueDictionary); } }
    public string GetRequiredString(string valueName) { return default(string); }
  }
  public enum RouteDirection {
    IncomingRequest = 0,
    UrlGeneration = 1,
  }
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class RouteTable {
    public RouteTable() { }
    public static System.Web.Routing.RouteCollection Routes { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Routing.RouteCollection); } }
  }
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class RouteValueDictionary : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String, System.Object>>, System.Collections.Generic.IDictionary<System.String, System.Object>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>, System.Collections.IEnumerable {
    public RouteValueDictionary() { }
    public RouteValueDictionary(System.Collections.Generic.IDictionary<System.String, System.Object> dictionary) { }
    public RouteValueDictionary(object values) { }
    public int Count { get { return default(int); } }
    public object this[string key] { get { return default(object); } set { } }
    public System.Collections.Generic.Dictionary<System.String, System.Object>.KeyCollection Keys { get { return default(System.Collections.Generic.Dictionary<System.String, System.Object>.KeyCollection); } }
    bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string,object>>.IsReadOnly { get { return default(bool); } }
    System.Collections.Generic.ICollection<System.String> System.Collections.Generic.IDictionary<string,object>.Keys { get { return default(System.Collections.Generic.ICollection<System.String>); } }
    System.Collections.Generic.ICollection<System.Object> System.Collections.Generic.IDictionary<string,object>.Values { get { return default(System.Collections.Generic.ICollection<System.Object>); } }
    public System.Collections.Generic.Dictionary<System.String, System.Object>.ValueCollection Values { get { return default(System.Collections.Generic.Dictionary<System.String, System.Object>.ValueCollection); } }
    public void Add(string key, object value) { }
    public void Clear() { }
    public bool ContainsKey(string key) { return default(bool); }
    public bool ContainsValue(object value) { return default(bool); }
    public System.Collections.Generic.Dictionary<System.String, System.Object>.Enumerator GetEnumerator() { return default(System.Collections.Generic.Dictionary<System.String, System.Object>.Enumerator); }
    public bool Remove(string key) { return default(bool); }
    void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string,object>>.Add(System.Collections.Generic.KeyValuePair<System.String, System.Object> item) { }
    bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string,object>>.Contains(System.Collections.Generic.KeyValuePair<System.String, System.Object> item) { return default(bool); }
    void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string,object>>.CopyTo(System.Collections.Generic.KeyValuePair<System.String, System.Object>[] array, int arrayIndex) { }
    bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string,object>>.Remove(System.Collections.Generic.KeyValuePair<System.String, System.Object> item) { return default(bool); }
    System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String, System.Object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string,object>>.GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String, System.Object>>); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    public bool TryGetValue(string key, out object value) { value = default(object); return default(bool); }
  }
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class StopRoutingHandler : System.Web.Routing.IRouteHandler {
    public StopRoutingHandler() { }
    protected virtual System.Web.IHttpHandler GetHttpHandler(System.Web.Routing.RequestContext requestContext) { return default(System.Web.IHttpHandler); }
    System.Web.IHttpHandler System.Web.Routing.IRouteHandler.GetHttpHandler(System.Web.Routing.RequestContext requestContext) { return default(System.Web.IHttpHandler); }
  }
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public abstract partial class UrlRoutingHandler : System.Web.IHttpHandler {
    protected UrlRoutingHandler() { }
    protected virtual bool IsReusable { get { return default(bool); } }
    public System.Web.Routing.RouteCollection RouteCollection { get { return default(System.Web.Routing.RouteCollection); } set { } }
    bool System.Web.IHttpHandler.IsReusable { get { return default(bool); } }
    protected virtual void ProcessRequest(System.Web.HttpContext httpContext) { }
    protected virtual void ProcessRequest(System.Web.HttpContextBase httpContext) { }
    void System.Web.IHttpHandler.ProcessRequest(System.Web.HttpContext context) { }
    protected abstract void VerifyAndProcessRequest(System.Web.IHttpHandler httpHandler, System.Web.HttpContextBase httpContext);
  }
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class UrlRoutingModule : System.Web.IHttpModule {
    public UrlRoutingModule() { }
    public System.Web.Routing.RouteCollection RouteCollection { get { return default(System.Web.Routing.RouteCollection); } set { } }
    protected virtual void Dispose() { }
    protected virtual void Init(System.Web.HttpApplication application) { }
    public virtual void PostMapRequestHandler(System.Web.HttpContextBase context) { }
    [System.MonoTODOAttribute]
    public virtual void PostResolveRequestCache(System.Web.HttpContextBase context) { }
    void System.Web.IHttpModule.Dispose() { }
    void System.Web.IHttpModule.Init(System.Web.HttpApplication application) { }
  }
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class VirtualPathData {
    public VirtualPathData(System.Web.Routing.RouteBase route, string virtualPath) { }
    public System.Web.Routing.RouteValueDictionary DataTokens { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Routing.RouteValueDictionary); } }
    public System.Web.Routing.RouteBase Route { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Routing.RouteBase); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string VirtualPath { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
}
