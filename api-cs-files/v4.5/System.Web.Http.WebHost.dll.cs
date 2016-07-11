namespace System.Web.Http {
  public static partial class GlobalConfiguration {
    public static System.Web.Http.HttpConfiguration Configuration { get { return default(System.Web.Http.HttpConfiguration); } }
    public static System.Web.Http.Dispatcher.HttpControllerDispatcher Dispatcher { get { return default(System.Web.Http.Dispatcher.HttpControllerDispatcher); } }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public static partial class RouteCollectionExtensions {
    public static System.Web.Routing.Route MapHttpRoute(this System.Web.Routing.RouteCollection routes, string name, string routeTemplate) { return default(System.Web.Routing.Route); }
    public static System.Web.Routing.Route MapHttpRoute(this System.Web.Routing.RouteCollection routes, string name, string routeTemplate, object defaults) { return default(System.Web.Routing.Route); }
    public static System.Web.Routing.Route MapHttpRoute(this System.Web.Routing.RouteCollection routes, string name, string routeTemplate, object defaults, object constraints) { return default(System.Web.Routing.Route); }
  }
}
namespace System.Web.Http.WebHost {
  public partial class HttpControllerHandler : System.Web.IHttpAsyncHandler, System.Web.IHttpHandler {
    public HttpControllerHandler(System.Web.Routing.RouteData routeData) { }
    protected virtual bool IsReusable { get { return default(bool); } }
    bool System.Web.IHttpHandler.IsReusable { get { return default(bool); } }
    protected virtual System.IAsyncResult BeginProcessRequest(System.Web.HttpContextBase httpContextBase, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected virtual void EndProcessRequest(System.IAsyncResult result) { }
    protected virtual void ProcessRequest(System.Web.HttpContextBase httpContextBase) { }
    System.IAsyncResult System.Web.IHttpAsyncHandler.BeginProcessRequest(System.Web.HttpContext httpContext, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    void System.Web.IHttpAsyncHandler.EndProcessRequest(System.IAsyncResult result) { }
    void System.Web.IHttpHandler.ProcessRequest(System.Web.HttpContext httpContext) { }
  }
  public partial class HttpControllerRouteHandler : System.Web.Routing.IRouteHandler {
    protected HttpControllerRouteHandler() { }
    public static System.Web.Http.WebHost.HttpControllerRouteHandler Instance { get { return default(System.Web.Http.WebHost.HttpControllerRouteHandler); } }
    protected virtual System.Web.IHttpHandler GetHttpHandler(System.Web.Routing.RequestContext requestContext) { return default(System.Web.IHttpHandler); }
    System.Web.IHttpHandler System.Web.Routing.IRouteHandler.GetHttpHandler(System.Web.Routing.RequestContext requestContext) { return default(System.Web.IHttpHandler); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public static partial class PreApplicationStartCode {
    public static void Start() { }
  }
}
namespace System.Web.Http.WebHost.Routing {
  public partial class HttpWebRoute : System.Web.Routing.Route {
    public HttpWebRoute(string url, System.Web.Routing.IRouteHandler routeHandler) : base (default(string), default(System.Web.Routing.IRouteHandler)) { }
    public HttpWebRoute(string url, System.Web.Routing.RouteValueDictionary defaults, System.Web.Routing.IRouteHandler routeHandler) : base (default(string), default(System.Web.Routing.IRouteHandler)) { }
    public HttpWebRoute(string url, System.Web.Routing.RouteValueDictionary defaults, System.Web.Routing.RouteValueDictionary constraints, System.Web.Routing.IRouteHandler routeHandler) : base (default(string), default(System.Web.Routing.IRouteHandler)) { }
    public HttpWebRoute(string url, System.Web.Routing.RouteValueDictionary defaults, System.Web.Routing.RouteValueDictionary constraints, System.Web.Routing.RouteValueDictionary dataTokens, System.Web.Routing.IRouteHandler routeHandler) : base (default(string), default(System.Web.Routing.IRouteHandler)) { }
    public override System.Web.Routing.VirtualPathData GetVirtualPath(System.Web.Routing.RequestContext requestContext, System.Web.Routing.RouteValueDictionary values) { return default(System.Web.Routing.VirtualPathData); }
    protected override bool ProcessConstraint(System.Web.HttpContextBase httpContext, object constraint, string parameterName, System.Web.Routing.RouteValueDictionary values, System.Web.Routing.RouteDirection routeDirection) { return default(bool); }
  }
}
