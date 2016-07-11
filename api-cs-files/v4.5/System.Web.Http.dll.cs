namespace System.Net.Http {
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public static partial class HttpRequestMessageExtensions {
    public static System.Net.Http.HttpResponseMessage CreateResponse<T>(this System.Net.Http.HttpRequestMessage request, System.Net.HttpStatusCode statusCode, T value) { return default(System.Net.Http.HttpResponseMessage); }
    public static System.Net.Http.HttpResponseMessage CreateResponse<T>(this System.Net.Http.HttpRequestMessage request, System.Net.HttpStatusCode statusCode, T value, System.Net.Http.Formatting.MediaTypeFormatter formatter) { return default(System.Net.Http.HttpResponseMessage); }
    public static System.Net.Http.HttpResponseMessage CreateResponse<T>(this System.Net.Http.HttpRequestMessage request, System.Net.HttpStatusCode statusCode, T value, System.Net.Http.Formatting.MediaTypeFormatter formatter, System.Net.Http.Headers.MediaTypeHeaderValue mediaType) { return default(System.Net.Http.HttpResponseMessage); }
    public static System.Net.Http.HttpResponseMessage CreateResponse<T>(this System.Net.Http.HttpRequestMessage request, System.Net.HttpStatusCode statusCode, T value, System.Net.Http.Formatting.MediaTypeFormatter formatter, string mediaType) { return default(System.Net.Http.HttpResponseMessage); }
    public static System.Net.Http.HttpResponseMessage CreateResponse<T>(this System.Net.Http.HttpRequestMessage request, System.Net.HttpStatusCode statusCode, T value, System.Net.Http.Headers.MediaTypeHeaderValue mediaType) { return default(System.Net.Http.HttpResponseMessage); }
    public static System.Net.Http.HttpResponseMessage CreateResponse<T>(this System.Net.Http.HttpRequestMessage request, System.Net.HttpStatusCode statusCode, T value, string mediaType) { return default(System.Net.Http.HttpResponseMessage); }
    public static System.Net.Http.HttpResponseMessage CreateResponse<T>(this System.Net.Http.HttpRequestMessage request, System.Net.HttpStatusCode statusCode, T value, System.Web.Http.HttpConfiguration configuration) { return default(System.Net.Http.HttpResponseMessage); }
    public static void DisposeRequestResources(this System.Net.Http.HttpRequestMessage request) { }
    public static System.Web.Http.HttpConfiguration GetConfiguration(this System.Net.Http.HttpRequestMessage request) { return default(System.Web.Http.HttpConfiguration); }
    public static System.Guid GetCorrelationId(this System.Net.Http.HttpRequestMessage request) { return default(System.Guid); }
    public static System.Web.Http.Dependencies.IDependencyScope GetDependencyScope(this System.Net.Http.HttpRequestMessage request) { return default(System.Web.Http.Dependencies.IDependencyScope); }
    public static System.Web.Http.Routing.IHttpRouteData GetRouteData(this System.Net.Http.HttpRequestMessage request) { return default(System.Web.Http.Routing.IHttpRouteData); }
    public static System.Threading.SynchronizationContext GetSynchronizationContext(this System.Net.Http.HttpRequestMessage request) { return default(System.Threading.SynchronizationContext); }
    public static void RegisterForDispose(this System.Net.Http.HttpRequestMessage request, System.IDisposable resource) { }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public static partial class HttpResponseMessageExtensions {
    public static bool TryGetContentValue<T>(this System.Net.Http.HttpResponseMessage response, out T value) { value = default(T); return default(bool); }
  }
}
namespace System.Net.Http.Formatting {
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public static partial class MediaTypeFormatterExtensions {
    public static void AddUriPathExtensionMapping(this System.Net.Http.Formatting.MediaTypeFormatter formatter, string uriPathExtension, System.Net.Http.Headers.MediaTypeHeaderValue mediaType) { }
    public static void AddUriPathExtensionMapping(this System.Net.Http.Formatting.MediaTypeFormatter formatter, string uriPathExtension, string mediaType) { }
  }
  public partial class UriPathExtensionMapping : System.Net.Http.Formatting.MediaTypeMapping {
    public static readonly string UriPathExtensionKey;
    public UriPathExtensionMapping(string uriPathExtension, System.Net.Http.Headers.MediaTypeHeaderValue mediaType) : base (default(System.Net.Http.Headers.MediaTypeHeaderValue)) { }
    public UriPathExtensionMapping(string uriPathExtension, string mediaType) : base (default(System.Net.Http.Headers.MediaTypeHeaderValue)) { }
    public string UriPathExtension { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public override double TryMatchMediaType(System.Net.Http.HttpRequestMessage request) { return default(double); }
  }
}
namespace System.Web.Http {
  [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=false, Inherited=true)]
  [System.CLSCompliantAttribute(false)]
  public sealed partial class AcceptVerbsAttribute : System.Attribute {
    public AcceptVerbsAttribute(params System.String[] methods) { }
    public System.Collections.ObjectModel.Collection<System.Net.Http.HttpMethod> HttpMethods { get { return default(System.Collections.ObjectModel.Collection<System.Net.Http.HttpMethod>); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=false, Inherited=true)]
  public sealed partial class ActionNameAttribute : System.Attribute {
    public ActionNameAttribute(string name) { }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(68), Inherited=true, AllowMultiple=false)]
  public sealed partial class AllowAnonymousAttribute : System.Attribute {
    public AllowAnonymousAttribute() { }
  }
  public abstract partial class ApiController : System.IDisposable, System.Web.Http.Controllers.IHttpController {
    protected ApiController() { }
    public System.Web.Http.HttpConfiguration Configuration { get { return default(System.Web.Http.HttpConfiguration); } set { } }
    public System.Web.Http.Controllers.HttpControllerContext ControllerContext { get { return default(System.Web.Http.Controllers.HttpControllerContext); } set { } }
    public System.Web.Http.ModelBinding.ModelStateDictionary ModelState { get { return default(System.Web.Http.ModelBinding.ModelStateDictionary); } }
    public System.Net.Http.HttpRequestMessage Request { get { return default(System.Net.Http.HttpRequestMessage); } set { } }
    public System.Web.Http.Routing.UrlHelper Url { get { return default(System.Web.Http.Routing.UrlHelper); } }
    public System.Security.Principal.IPrincipal User { get { return default(System.Security.Principal.IPrincipal); } }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public virtual System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> ExecuteAsync(System.Web.Http.Controllers.HttpControllerContext controllerContext, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>); }
    protected virtual void Initialize(System.Web.Http.Controllers.HttpControllerContext controllerContext) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(68), Inherited=true, AllowMultiple=true)]
  public partial class AuthorizeAttribute : System.Web.Http.Filters.AuthorizationFilterAttribute {
    public AuthorizeAttribute() { }
    public string Roles { get { return default(string); } set { } }
    public override object TypeId { get { return default(object); } }
    public string Users { get { return default(string); } set { } }
    protected virtual void HandleUnauthorizedRequest(System.Web.Http.Controllers.HttpActionContext actionContext) { }
    public override void OnAuthorization(System.Web.Http.Controllers.HttpActionContext actionContext) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(2052), Inherited=true, AllowMultiple=false)]
  public sealed partial class FromBodyAttribute : System.Attribute {
    public FromBodyAttribute() { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(2052), Inherited=true, AllowMultiple=false)]
  public sealed partial class FromUriAttribute : System.Web.Http.ModelBinding.ModelBinderAttribute {
    public FromUriAttribute() { }
    public override System.Collections.Generic.IEnumerable<System.Web.Http.ValueProviders.ValueProviderFactory> GetValueProviderFactories(System.Web.Http.HttpConfiguration configuration) { return default(System.Collections.Generic.IEnumerable<System.Web.Http.ValueProviders.ValueProviderFactory>); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(132), AllowMultiple=false, Inherited=true)]
  public sealed partial class HttpBindNeverAttribute : System.Web.Http.ModelBinding.HttpBindingBehaviorAttribute {
    public HttpBindNeverAttribute() : base (default(System.Web.Http.ModelBinding.HttpBindingBehavior)) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(132), AllowMultiple=false, Inherited=true)]
  public sealed partial class HttpBindRequiredAttribute : System.Web.Http.ModelBinding.HttpBindingBehaviorAttribute {
    public HttpBindRequiredAttribute() : base (default(System.Web.Http.ModelBinding.HttpBindingBehavior)) { }
  }
  public partial class HttpConfiguration : System.IDisposable {
    public HttpConfiguration() { }
    public HttpConfiguration(System.Web.Http.HttpRouteCollection routes) { }
    public System.Web.Http.Dependencies.IDependencyResolver DependencyResolver { get { return default(System.Web.Http.Dependencies.IDependencyResolver); } set { } }
    public System.Web.Http.Filters.HttpFilterCollection Filters { get { return default(System.Web.Http.Filters.HttpFilterCollection); } }
    public System.Net.Http.Formatting.MediaTypeFormatterCollection Formatters { get { return default(System.Net.Http.Formatting.MediaTypeFormatterCollection); } }
    public System.Web.Http.IncludeErrorDetailPolicy IncludeErrorDetailPolicy { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Http.IncludeErrorDetailPolicy); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.ObjectModel.Collection<System.Net.Http.DelegatingHandler> MessageHandlers { get { return default(System.Collections.ObjectModel.Collection<System.Net.Http.DelegatingHandler>); } }
    public System.Collections.Concurrent.ConcurrentDictionary<System.Object, System.Object> Properties { get { return default(System.Collections.Concurrent.ConcurrentDictionary<System.Object, System.Object>); } }
    public System.Web.Http.HttpRouteCollection Routes { get { return default(System.Web.Http.HttpRouteCollection); } }
    public System.Web.Http.Services.DefaultServices Services { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Http.Services.DefaultServices); } }
    public string VirtualPathRoot { get { return default(string); } }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=false, Inherited=true)]
  public sealed partial class HttpDeleteAttribute : System.Attribute {
    public HttpDeleteAttribute() { }
    public System.Collections.ObjectModel.Collection<System.Net.Http.HttpMethod> HttpMethods { get { return default(System.Collections.ObjectModel.Collection<System.Net.Http.HttpMethod>); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=false, Inherited=true)]
  public sealed partial class HttpGetAttribute : System.Attribute {
    public HttpGetAttribute() { }
    public System.Collections.ObjectModel.Collection<System.Net.Http.HttpMethod> HttpMethods { get { return default(System.Collections.ObjectModel.Collection<System.Net.Http.HttpMethod>); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=false, Inherited=true)]
  public sealed partial class HttpHeadAttribute : System.Attribute {
    public HttpHeadAttribute() { }
    public System.Collections.ObjectModel.Collection<System.Net.Http.HttpMethod> HttpMethods { get { return default(System.Collections.ObjectModel.Collection<System.Net.Http.HttpMethod>); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=false, Inherited=true)]
  public sealed partial class HttpOptionsAttribute : System.Attribute {
    public HttpOptionsAttribute() { }
    public System.Collections.ObjectModel.Collection<System.Net.Http.HttpMethod> HttpMethods { get { return default(System.Collections.ObjectModel.Collection<System.Net.Http.HttpMethod>); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=false, Inherited=true)]
  public sealed partial class HttpPatchAttribute : System.Attribute {
    public HttpPatchAttribute() { }
    public System.Collections.ObjectModel.Collection<System.Net.Http.HttpMethod> HttpMethods { get { return default(System.Collections.ObjectModel.Collection<System.Net.Http.HttpMethod>); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=false, Inherited=true)]
  public sealed partial class HttpPostAttribute : System.Attribute {
    public HttpPostAttribute() { }
    public System.Collections.ObjectModel.Collection<System.Net.Http.HttpMethod> HttpMethods { get { return default(System.Collections.ObjectModel.Collection<System.Net.Http.HttpMethod>); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=false, Inherited=true)]
  public sealed partial class HttpPutAttribute : System.Attribute {
    public HttpPutAttribute() { }
    public System.Collections.ObjectModel.Collection<System.Net.Http.HttpMethod> HttpMethods { get { return default(System.Collections.ObjectModel.Collection<System.Net.Http.HttpMethod>); } }
  }
  public partial class HttpResponseException : System.Exception {
    public HttpResponseException(System.Net.Http.HttpResponseMessage response) { }
    public System.Net.Http.HttpResponseMessage Response { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Net.Http.HttpResponseMessage); } }
  }
  public partial class HttpRouteCollection : System.Collections.Generic.ICollection<System.Web.Http.Routing.IHttpRoute>, System.Collections.Generic.IEnumerable<System.Web.Http.Routing.IHttpRoute>, System.Collections.IEnumerable, System.IDisposable {
    public HttpRouteCollection() { }
    public HttpRouteCollection(string virtualPathRoot) { }
    public virtual int Count { get { return default(int); } }
    public virtual bool IsReadOnly { get { return default(bool); } }
    public virtual System.Web.Http.Routing.IHttpRoute this[int index] { get { return default(System.Web.Http.Routing.IHttpRoute); } }
    public virtual System.Web.Http.Routing.IHttpRoute this[string name] { get { return default(System.Web.Http.Routing.IHttpRoute); } }
    public virtual string VirtualPathRoot { get { return default(string); } }
    public virtual void Add(string name, System.Web.Http.Routing.IHttpRoute route) { }
    public virtual void Clear() { }
    public virtual bool Contains(System.Web.Http.Routing.IHttpRoute item) { return default(bool); }
    public virtual bool ContainsKey(string name) { return default(bool); }
    public virtual void CopyTo(System.Collections.Generic.KeyValuePair<System.String, System.Web.Http.Routing.IHttpRoute>[] array, int arrayIndex) { }
    public virtual void CopyTo(System.Web.Http.Routing.IHttpRoute[] array, int arrayIndex) { }
    public virtual System.Web.Http.Routing.IHttpRoute CreateRoute(string routeTemplate, System.Collections.Generic.IDictionary<System.String, System.Object> defaults, System.Collections.Generic.IDictionary<System.String, System.Object> constraints, System.Collections.Generic.IDictionary<System.String, System.Object> dataTokens, System.Collections.Generic.IDictionary<System.String, System.Object> parameters) { return default(System.Web.Http.Routing.IHttpRoute); }
    public System.Web.Http.Routing.IHttpRoute CreateRoute(string routeTemplate, object defaults, object constraints, System.Collections.Generic.IDictionary<System.String, System.Object> parameters) { return default(System.Web.Http.Routing.IHttpRoute); }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public virtual System.Collections.Generic.IEnumerator<System.Web.Http.Routing.IHttpRoute> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Web.Http.Routing.IHttpRoute>); }
    public virtual System.Web.Http.Routing.IHttpRouteData GetRouteData(System.Net.Http.HttpRequestMessage request) { return default(System.Web.Http.Routing.IHttpRouteData); }
    public virtual System.Web.Http.Routing.IHttpVirtualPathData GetVirtualPath(System.Web.Http.Controllers.HttpControllerContext controllerContext, string name, System.Collections.Generic.IDictionary<System.String, System.Object> values) { return default(System.Web.Http.Routing.IHttpVirtualPathData); }
    public virtual void Insert(int index, string name, System.Web.Http.Routing.IHttpRoute value) { }
    protected virtual System.Collections.IEnumerator OnGetEnumerator() { return default(System.Collections.IEnumerator); }
    public virtual bool Remove(string name) { return default(bool); }
    void System.Collections.Generic.ICollection<System.Web.Http.Routing.IHttpRoute>.Add(System.Web.Http.Routing.IHttpRoute route) { }
    bool System.Collections.Generic.ICollection<System.Web.Http.Routing.IHttpRoute>.Remove(System.Web.Http.Routing.IHttpRoute route) { return default(bool); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    public virtual bool TryGetValue(string name, out System.Web.Http.Routing.IHttpRoute route) { route = default(System.Web.Http.Routing.IHttpRoute); return default(bool); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public static partial class HttpRouteCollectionExtensions {
    public static System.Web.Http.Routing.IHttpRoute MapHttpRoute(this System.Web.Http.HttpRouteCollection routes, string name, string routeTemplate) { return default(System.Web.Http.Routing.IHttpRoute); }
    public static System.Web.Http.Routing.IHttpRoute MapHttpRoute(this System.Web.Http.HttpRouteCollection routes, string name, string routeTemplate, object defaults) { return default(System.Web.Http.Routing.IHttpRoute); }
    public static System.Web.Http.Routing.IHttpRoute MapHttpRoute(this System.Web.Http.HttpRouteCollection routes, string name, string routeTemplate, object defaults, object constraints) { return default(System.Web.Http.Routing.IHttpRoute); }
  }
  public partial class HttpServer : System.Net.Http.DelegatingHandler {
    public HttpServer() { }
    public HttpServer(System.Web.Http.Dispatcher.HttpControllerDispatcher dispatcher) { }
    public HttpServer(System.Web.Http.HttpConfiguration configuration) { }
    public HttpServer(System.Web.Http.HttpConfiguration configuration, System.Net.Http.HttpMessageHandler dispatcher) { }
    public System.Web.Http.HttpConfiguration Configuration { get { return default(System.Web.Http.HttpConfiguration); } }
    public System.Net.Http.HttpMessageHandler Dispatcher { get { return default(System.Net.Http.HttpMessageHandler); } }
    protected override void Dispose(bool disposing) { }
    protected virtual void Initialize() { }
    protected override System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>); }
  }
  public enum IncludeErrorDetailPolicy {
    Always = 1,
    LocalOnly = 0,
    Never = 2,
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=false, Inherited=true)]
  public sealed partial class NonActionAttribute : System.Attribute {
    public NonActionAttribute() { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(68), Inherited=true, AllowMultiple=false)]
  public partial class QueryableAttribute : System.Web.Http.Filters.ActionFilterAttribute {
    public QueryableAttribute() { }
    public int ResultLimit { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected virtual System.Linq.IQueryable ApplyResultLimit(System.Web.Http.Filters.HttpActionExecutedContext actionExecutedContext, System.Linq.IQueryable query) { return default(System.Linq.IQueryable); }
    public override void OnActionExecuted(System.Web.Http.Filters.HttpActionExecutedContext actionExecutedContext) { }
    public override void OnActionExecuting(System.Web.Http.Controllers.HttpActionContext actionContext) { }
  }
  public sealed partial class RouteParameter {
    internal RouteParameter() { }
    public static readonly System.Web.Http.RouteParameter Optional;
    public override string ToString() { return default(string); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public static partial class ServicesExtensions {
    public static System.Web.Http.Controllers.IHttpActionInvoker GetActionInvoker(this System.Web.Http.Services.DefaultServices services) { return default(System.Web.Http.Controllers.IHttpActionInvoker); }
    public static System.Web.Http.Controllers.IHttpActionSelector GetActionSelector(this System.Web.Http.Services.DefaultServices services) { return default(System.Web.Http.Controllers.IHttpActionSelector); }
    public static System.Web.Http.Controllers.IActionValueBinder GetActionValueBinder(this System.Web.Http.Services.DefaultServices services) { return default(System.Web.Http.Controllers.IActionValueBinder); }
    public static System.Web.Http.Description.IApiExplorer GetApiExplorer(this System.Web.Http.Services.DefaultServices services) { return default(System.Web.Http.Description.IApiExplorer); }
    public static System.Web.Http.Dispatcher.IAssembliesResolver GetAssembliesResolver(this System.Web.Http.Services.DefaultServices services) { return default(System.Web.Http.Dispatcher.IAssembliesResolver); }
    public static System.Web.Http.Validation.IBodyModelValidator GetBodyModelValidator(this System.Web.Http.Services.DefaultServices services) { return default(System.Web.Http.Validation.IBodyModelValidator); }
    public static System.Net.Http.Formatting.IContentNegotiator GetContentNegotiator(this System.Web.Http.Services.DefaultServices services) { return default(System.Net.Http.Formatting.IContentNegotiator); }
    public static System.Web.Http.Description.IDocumentationProvider GetDocumentationProvider(this System.Web.Http.Services.DefaultServices services) { return default(System.Web.Http.Description.IDocumentationProvider); }
    public static System.Collections.Generic.IEnumerable<System.Web.Http.Filters.IFilterProvider> GetFilterProviders(this System.Web.Http.Services.DefaultServices services) { return default(System.Collections.Generic.IEnumerable<System.Web.Http.Filters.IFilterProvider>); }
    public static System.Web.Http.Dispatcher.IHttpControllerActivator GetHttpControllerActivator(this System.Web.Http.Services.DefaultServices services) { return default(System.Web.Http.Dispatcher.IHttpControllerActivator); }
    public static System.Web.Http.Dispatcher.IHttpControllerSelector GetHttpControllerSelector(this System.Web.Http.Services.DefaultServices services) { return default(System.Web.Http.Dispatcher.IHttpControllerSelector); }
    public static System.Web.Http.Dispatcher.IHttpControllerTypeResolver GetHttpControllerTypeResolver(this System.Web.Http.Services.DefaultServices services) { return default(System.Web.Http.Dispatcher.IHttpControllerTypeResolver); }
    public static System.Collections.Generic.IEnumerable<System.Web.Http.ModelBinding.ModelBinderProvider> GetModelBinderProviders(this System.Web.Http.Services.DefaultServices services) { return default(System.Collections.Generic.IEnumerable<System.Web.Http.ModelBinding.ModelBinderProvider>); }
    public static System.Web.Http.Metadata.ModelMetadataProvider GetModelMetadataProvider(this System.Web.Http.Services.DefaultServices services) { return default(System.Web.Http.Metadata.ModelMetadataProvider); }
    public static System.Collections.Generic.IEnumerable<System.Web.Http.Validation.ModelValidatorProvider> GetModelValidatorProviders(this System.Web.Http.Services.DefaultServices services) { return default(System.Collections.Generic.IEnumerable<System.Web.Http.Validation.ModelValidatorProvider>); }
    public static System.Web.Http.Tracing.ITraceManager GetTraceManager(this System.Web.Http.Services.DefaultServices services) { return default(System.Web.Http.Tracing.ITraceManager); }
    public static System.Web.Http.Tracing.ITraceWriter GetTraceWriter(this System.Web.Http.Services.DefaultServices services) { return default(System.Web.Http.Tracing.ITraceWriter); }
    public static System.Collections.Generic.IEnumerable<System.Web.Http.ValueProviders.ValueProviderFactory> GetValueProviderFactories(this System.Web.Http.Services.DefaultServices services) { return default(System.Collections.Generic.IEnumerable<System.Web.Http.ValueProviders.ValueProviderFactory>); }
  }
}
namespace System.Web.Http.Controllers {
  public partial class ApiControllerActionInvoker : System.Web.Http.Controllers.IHttpActionInvoker {
    public ApiControllerActionInvoker() { }
    public virtual System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> InvokeActionAsync(System.Web.Http.Controllers.HttpActionContext actionContext, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>); }
  }
  public partial class ApiControllerActionSelector : System.Web.Http.Controllers.IHttpActionSelector {
    public ApiControllerActionSelector() { }
    public virtual System.Linq.ILookup<System.String, System.Web.Http.Controllers.HttpActionDescriptor> GetActionMapping(System.Web.Http.Controllers.HttpControllerDescriptor controllerDescriptor) { return default(System.Linq.ILookup<System.String, System.Web.Http.Controllers.HttpActionDescriptor>); }
    public virtual System.Web.Http.Controllers.HttpActionDescriptor SelectAction(System.Web.Http.Controllers.HttpControllerContext controllerContext) { return default(System.Web.Http.Controllers.HttpActionDescriptor); }
  }
  public partial class HttpActionBinding {
    public HttpActionBinding() { }
    public HttpActionBinding(System.Web.Http.Controllers.HttpActionDescriptor actionDescriptor, System.Web.Http.Controllers.HttpParameterBinding[] bindings) { }
    public System.Web.Http.Controllers.HttpActionDescriptor ActionDescriptor { get { return default(System.Web.Http.Controllers.HttpActionDescriptor); } set { } }
    public System.Web.Http.Controllers.HttpParameterBinding[] ParameterBindings { get { return default(System.Web.Http.Controllers.HttpParameterBinding[]); } set { } }
    public virtual System.Threading.Tasks.Task ExecuteBindingAsync(System.Web.Http.Controllers.HttpActionContext actionContext, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
  }
  public partial class HttpActionContext {
    public HttpActionContext() { }
    public HttpActionContext(System.Web.Http.Controllers.HttpControllerContext controllerContext, System.Web.Http.Controllers.HttpActionDescriptor actionDescriptor) { }
    public System.Collections.Generic.Dictionary<System.String, System.Object> ActionArguments { get { return default(System.Collections.Generic.Dictionary<System.String, System.Object>); } }
    public System.Web.Http.Controllers.HttpActionDescriptor ActionDescriptor { get { return default(System.Web.Http.Controllers.HttpActionDescriptor); } set { } }
    public System.Web.Http.Controllers.HttpControllerContext ControllerContext { get { return default(System.Web.Http.Controllers.HttpControllerContext); } set { } }
    public System.Web.Http.ModelBinding.ModelStateDictionary ModelState { get { return default(System.Web.Http.ModelBinding.ModelStateDictionary); } }
    public System.Net.Http.HttpRequestMessage Request { get { return default(System.Net.Http.HttpRequestMessage); } }
    public System.Net.Http.HttpResponseMessage Response { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Net.Http.HttpResponseMessage); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public static partial class HttpActionContextExtensions {
    public static System.Web.Http.ModelBinding.IModelBinder GetBinder(this System.Web.Http.Controllers.HttpActionContext actionContext, System.Web.Http.ModelBinding.ModelBindingContext bindingContext) { return default(System.Web.Http.ModelBinding.IModelBinder); }
    public static System.Web.Http.Metadata.ModelMetadataProvider GetMetadataProvider(this System.Web.Http.Controllers.HttpActionContext actionContext) { return default(System.Web.Http.Metadata.ModelMetadataProvider); }
    public static System.Collections.Generic.IEnumerable<System.Web.Http.Validation.ModelValidatorProvider> GetValidatorProviders(this System.Web.Http.Controllers.HttpActionContext actionContext) { return default(System.Collections.Generic.IEnumerable<System.Web.Http.Validation.ModelValidatorProvider>); }
    public static System.Collections.Generic.IEnumerable<System.Web.Http.Validation.ModelValidator> GetValidators(this System.Web.Http.Controllers.HttpActionContext actionContext, System.Web.Http.Metadata.ModelMetadata metadata) { return default(System.Collections.Generic.IEnumerable<System.Web.Http.Validation.ModelValidator>); }
    public static bool TryGetBinder(this System.Web.Http.Controllers.HttpActionContext actionContext, System.Web.Http.ModelBinding.ModelBindingContext bindingContext, out System.Web.Http.ModelBinding.IModelBinder binder) { binder = default(System.Web.Http.ModelBinding.IModelBinder); return default(bool); }
  }
  public abstract partial class HttpActionDescriptor {
    protected HttpActionDescriptor() { }
    protected HttpActionDescriptor(System.Web.Http.Controllers.HttpControllerDescriptor controllerDescriptor) { }
    public virtual System.Web.Http.Controllers.HttpActionBinding ActionBinding { get { return default(System.Web.Http.Controllers.HttpActionBinding); } set { } }
    public abstract string ActionName { get; }
    public System.Web.Http.HttpConfiguration Configuration { get { return default(System.Web.Http.HttpConfiguration); } set { } }
    public System.Web.Http.Controllers.HttpControllerDescriptor ControllerDescriptor { get { return default(System.Web.Http.Controllers.HttpControllerDescriptor); } set { } }
    public System.Collections.Concurrent.ConcurrentDictionary<System.Object, System.Object> Properties { get { return default(System.Collections.Concurrent.ConcurrentDictionary<System.Object, System.Object>); } }
    public virtual System.Web.Http.Controllers.IActionResultConverter ResultConverter { get { return default(System.Web.Http.Controllers.IActionResultConverter); } }
    public abstract System.Type ReturnType { get; }
    public virtual System.Collections.ObjectModel.Collection<System.Net.Http.HttpMethod> SupportedHttpMethods { get { return default(System.Collections.ObjectModel.Collection<System.Net.Http.HttpMethod>); } }
    public abstract System.Threading.Tasks.Task<System.Object> ExecuteAsync(System.Web.Http.Controllers.HttpControllerContext controllerContext, System.Collections.Generic.IDictionary<System.String, System.Object> arguments);
    public virtual System.Collections.ObjectModel.Collection<T> GetCustomAttributes<T>() where T : class { return default(System.Collections.ObjectModel.Collection<T>); }
    public virtual System.Collections.ObjectModel.Collection<System.Web.Http.Filters.FilterInfo> GetFilterPipeline() { return default(System.Collections.ObjectModel.Collection<System.Web.Http.Filters.FilterInfo>); }
    public virtual System.Collections.ObjectModel.Collection<System.Web.Http.Filters.IFilter> GetFilters() { return default(System.Collections.ObjectModel.Collection<System.Web.Http.Filters.IFilter>); }
    public abstract System.Collections.ObjectModel.Collection<System.Web.Http.Controllers.HttpParameterDescriptor> GetParameters();
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false, Inherited=true)]
  public sealed partial class HttpControllerConfigurationAttribute : System.Attribute {
    public HttpControllerConfigurationAttribute() { }
    public System.Type ActionValueBinder { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Type HttpActionInvoker { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Type HttpActionSelector { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Type HttpControllerActivator { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial class HttpControllerContext {
    public HttpControllerContext() { }
    public HttpControllerContext(System.Web.Http.HttpConfiguration configuration, System.Web.Http.Routing.IHttpRouteData routeData, System.Net.Http.HttpRequestMessage request) { }
    public System.Web.Http.HttpConfiguration Configuration { get { return default(System.Web.Http.HttpConfiguration); } set { } }
    public System.Web.Http.Controllers.IHttpController Controller { get { return default(System.Web.Http.Controllers.IHttpController); } set { } }
    public System.Web.Http.Controllers.HttpControllerDescriptor ControllerDescriptor { get { return default(System.Web.Http.Controllers.HttpControllerDescriptor); } set { } }
    public System.Net.Http.HttpRequestMessage Request { get { return default(System.Net.Http.HttpRequestMessage); } set { } }
    public System.Web.Http.Routing.IHttpRouteData RouteData { get { return default(System.Web.Http.Routing.IHttpRouteData); } set { } }
    public System.Web.Http.Routing.UrlHelper Url { get { return default(System.Web.Http.Routing.UrlHelper); } set { } }
  }
  public partial class HttpControllerDescriptor {
    public HttpControllerDescriptor() { }
    public HttpControllerDescriptor(System.Web.Http.HttpConfiguration configuration, string controllerName, System.Type controllerType) { }
    public System.Web.Http.Controllers.IActionValueBinder ActionValueBinder { get { return default(System.Web.Http.Controllers.IActionValueBinder); } set { } }
    public System.Web.Http.HttpConfiguration Configuration { get { return default(System.Web.Http.HttpConfiguration); } set { } }
    public string ControllerName { get { return default(string); } set { } }
    public System.Type ControllerType { get { return default(System.Type); } set { } }
    public System.Web.Http.Controllers.IHttpActionInvoker HttpActionInvoker { get { return default(System.Web.Http.Controllers.IHttpActionInvoker); } set { } }
    public System.Web.Http.Controllers.IHttpActionSelector HttpActionSelector { get { return default(System.Web.Http.Controllers.IHttpActionSelector); } set { } }
    public System.Web.Http.Dispatcher.IHttpControllerActivator HttpControllerActivator { get { return default(System.Web.Http.Dispatcher.IHttpControllerActivator); } set { } }
    public System.Collections.Concurrent.ConcurrentDictionary<System.Object, System.Object> Properties { get { return default(System.Collections.Concurrent.ConcurrentDictionary<System.Object, System.Object>); } }
    public virtual System.Web.Http.Controllers.IHttpController CreateController(System.Net.Http.HttpRequestMessage request) { return default(System.Web.Http.Controllers.IHttpController); }
    public virtual System.Collections.ObjectModel.Collection<T> GetCustomAttributes<T>() where T : class { return default(System.Collections.ObjectModel.Collection<T>); }
    public virtual System.Collections.ObjectModel.Collection<System.Web.Http.Filters.IFilter> GetFilters() { return default(System.Collections.ObjectModel.Collection<System.Web.Http.Filters.IFilter>); }
  }
  public abstract partial class HttpParameterBinding {
    protected HttpParameterBinding(System.Web.Http.Controllers.HttpParameterDescriptor descriptor) { }
    public System.Web.Http.Controllers.HttpParameterDescriptor Descriptor { get { return default(System.Web.Http.Controllers.HttpParameterDescriptor); } }
    public virtual string ErrorMessage { get { return default(string); } }
    public bool IsValid { get { return default(bool); } }
    public virtual bool WillReadBody { get { return default(bool); } }
    public abstract System.Threading.Tasks.Task ExecuteBindingAsync(System.Web.Http.Metadata.ModelMetadataProvider metadataProvider, System.Web.Http.Controllers.HttpActionContext actionContext, System.Threading.CancellationToken cancellationToken);
  }
  public abstract partial class HttpParameterDescriptor {
    protected HttpParameterDescriptor() { }
    protected HttpParameterDescriptor(System.Web.Http.Controllers.HttpActionDescriptor actionDescriptor) { }
    public System.Web.Http.Controllers.HttpActionDescriptor ActionDescriptor { get { return default(System.Web.Http.Controllers.HttpActionDescriptor); } set { } }
    public System.Web.Http.HttpConfiguration Configuration { get { return default(System.Web.Http.HttpConfiguration); } set { } }
    public virtual object DefaultValue { get { return default(object); } }
    public virtual System.Web.Http.ModelBinding.ModelBinderAttribute ModelBinderAttribute { get { return default(System.Web.Http.ModelBinding.ModelBinderAttribute); } set { } }
    public abstract string ParameterName { get; }
    public abstract System.Type ParameterType { get; }
    public virtual string Prefix { get { return default(string); } }
    public System.Collections.Concurrent.ConcurrentDictionary<System.Object, System.Object> Properties { get { return default(System.Collections.Concurrent.ConcurrentDictionary<System.Object, System.Object>); } }
    public virtual System.Collections.ObjectModel.Collection<T> GetCustomAttributes<T>() where T : class { return default(System.Collections.ObjectModel.Collection<T>); }
  }
  public partial interface IActionResultConverter {
    System.Net.Http.HttpResponseMessage Convert(System.Web.Http.Controllers.HttpControllerContext controllerContext, object actionResult);
  }
  public partial interface IActionValueBinder {
    System.Web.Http.Controllers.HttpActionBinding GetBinding(System.Web.Http.Controllers.HttpActionDescriptor actionDescriptor);
  }
  public partial interface IHttpActionInvoker {
    System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> InvokeActionAsync(System.Web.Http.Controllers.HttpActionContext actionContext, System.Threading.CancellationToken cancellationToken);
  }
  public partial interface IHttpActionSelector {
    System.Linq.ILookup<System.String, System.Web.Http.Controllers.HttpActionDescriptor> GetActionMapping(System.Web.Http.Controllers.HttpControllerDescriptor controllerDescriptor);
    System.Web.Http.Controllers.HttpActionDescriptor SelectAction(System.Web.Http.Controllers.HttpControllerContext controllerContext);
  }
  public partial interface IHttpController {
    System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> ExecuteAsync(System.Web.Http.Controllers.HttpControllerContext controllerContext, System.Threading.CancellationToken cancellationToken);
  }
  public partial class ReflectedHttpActionDescriptor : System.Web.Http.Controllers.HttpActionDescriptor {
    public ReflectedHttpActionDescriptor() { }
    public ReflectedHttpActionDescriptor(System.Web.Http.Controllers.HttpControllerDescriptor controllerDescriptor, System.Reflection.MethodInfo methodInfo) { }
    public override string ActionName { get { return default(string); } }
    public System.Reflection.MethodInfo MethodInfo { get { return default(System.Reflection.MethodInfo); } set { } }
    public override System.Type ReturnType { get { return default(System.Type); } }
    public override System.Collections.ObjectModel.Collection<System.Net.Http.HttpMethod> SupportedHttpMethods { get { return default(System.Collections.ObjectModel.Collection<System.Net.Http.HttpMethod>); } }
    public override System.Threading.Tasks.Task<System.Object> ExecuteAsync(System.Web.Http.Controllers.HttpControllerContext controllerContext, System.Collections.Generic.IDictionary<System.String, System.Object> arguments) { return default(System.Threading.Tasks.Task<System.Object>); }
    public override System.Collections.ObjectModel.Collection<T> GetCustomAttributes<T>() { return default(System.Collections.ObjectModel.Collection<T>); }
    public override System.Collections.ObjectModel.Collection<System.Web.Http.Filters.IFilter> GetFilters() { return default(System.Collections.ObjectModel.Collection<System.Web.Http.Filters.IFilter>); }
    public override System.Collections.ObjectModel.Collection<System.Web.Http.Controllers.HttpParameterDescriptor> GetParameters() { return default(System.Collections.ObjectModel.Collection<System.Web.Http.Controllers.HttpParameterDescriptor>); }
  }
  public partial class ReflectedHttpParameterDescriptor : System.Web.Http.Controllers.HttpParameterDescriptor {
    public ReflectedHttpParameterDescriptor() { }
    public ReflectedHttpParameterDescriptor(System.Web.Http.Controllers.HttpActionDescriptor actionDescriptor, System.Reflection.ParameterInfo parameterInfo) { }
    public override object DefaultValue { get { return default(object); } }
    public System.Reflection.ParameterInfo ParameterInfo { get { return default(System.Reflection.ParameterInfo); } set { } }
    public override string ParameterName { get { return default(string); } }
    public override System.Type ParameterType { get { return default(System.Type); } }
    public override System.Collections.ObjectModel.Collection<T> GetCustomAttributes<T>() { return default(System.Collections.ObjectModel.Collection<T>); }
  }
  public partial class ResponseMessageResultConverter : System.Web.Http.Controllers.IActionResultConverter {
    public ResponseMessageResultConverter() { }
    public System.Net.Http.HttpResponseMessage Convert(System.Web.Http.Controllers.HttpControllerContext controllerContext, object actionResult) { return default(System.Net.Http.HttpResponseMessage); }
  }
  public partial class ValueResultConverter<T> : System.Web.Http.Controllers.IActionResultConverter {
    public ValueResultConverter() { }
    public System.Net.Http.HttpResponseMessage Convert(System.Web.Http.Controllers.HttpControllerContext controllerContext, object actionResult) { return default(System.Net.Http.HttpResponseMessage); }
  }
  public partial class VoidResultConverter : System.Web.Http.Controllers.IActionResultConverter {
    public VoidResultConverter() { }
    public System.Net.Http.HttpResponseMessage Convert(System.Web.Http.Controllers.HttpControllerContext controllerContext, object actionResult) { return default(System.Net.Http.HttpResponseMessage); }
  }
}
namespace System.Web.Http.Dependencies {
  public partial interface IDependencyResolver : System.IDisposable, System.Web.Http.Dependencies.IDependencyScope {
    System.Web.Http.Dependencies.IDependencyScope BeginScope();
  }
  public partial interface IDependencyScope : System.IDisposable {
    object GetService(System.Type serviceType);
    System.Collections.Generic.IEnumerable<System.Object> GetServices(System.Type serviceType);
  }
}
namespace System.Web.Http.Description {
  public partial class ApiDescription {
    public ApiDescription() { }
    public System.Web.Http.Controllers.HttpActionDescriptor ActionDescriptor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Http.Controllers.HttpActionDescriptor); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Documentation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Net.Http.HttpMethod HttpMethod { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Net.Http.HttpMethod); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string ID { get { return default(string); } }
    public System.Collections.ObjectModel.Collection<System.Web.Http.Description.ApiParameterDescription> ParameterDescriptions { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.ObjectModel.Collection<System.Web.Http.Description.ApiParameterDescription>); } }
    public string RelativePath { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Web.Http.Routing.IHttpRoute Route { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Http.Routing.IHttpRoute); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.ObjectModel.Collection<System.Net.Http.Formatting.MediaTypeFormatter> SupportedRequestBodyFormatters { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.ObjectModel.Collection<System.Net.Http.Formatting.MediaTypeFormatter>); } }
    public System.Collections.ObjectModel.Collection<System.Net.Http.Formatting.MediaTypeFormatter> SupportedResponseFormatters { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.ObjectModel.Collection<System.Net.Http.Formatting.MediaTypeFormatter>); } }
  }
  public partial class ApiExplorer : System.Web.Http.Description.IApiExplorer {
    public ApiExplorer(System.Web.Http.HttpConfiguration configuration) { }
    public System.Collections.ObjectModel.Collection<System.Web.Http.Description.ApiDescription> ApiDescriptions { get { return default(System.Collections.ObjectModel.Collection<System.Web.Http.Description.ApiDescription>); } }
    public System.Web.Http.Description.IDocumentationProvider DocumentationProvider { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Http.Description.IDocumentationProvider); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public virtual System.Collections.ObjectModel.Collection<System.Net.Http.HttpMethod> GetHttpMethodsSupportedByAction(System.Web.Http.Routing.IHttpRoute route, System.Web.Http.Controllers.HttpActionDescriptor actionDescriptor) { return default(System.Collections.ObjectModel.Collection<System.Net.Http.HttpMethod>); }
    public virtual bool ShouldExploreAction(string actionVariableValue, System.Web.Http.Controllers.HttpActionDescriptor actionDescriptor, System.Web.Http.Routing.IHttpRoute route) { return default(bool); }
    public virtual bool ShouldExploreController(string controllerVariableValue, System.Web.Http.Controllers.HttpControllerDescriptor controllerDescriptor, System.Web.Http.Routing.IHttpRoute route) { return default(bool); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(68), AllowMultiple=false)]
  public sealed partial class ApiExplorerSettingsAttribute : System.Attribute {
    public ApiExplorerSettingsAttribute() { }
    public bool IgnoreApi { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial class ApiParameterDescription {
    public ApiParameterDescription() { }
    public string Documentation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Web.Http.Controllers.HttpParameterDescriptor ParameterDescriptor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Http.Controllers.HttpParameterDescriptor); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Web.Http.Description.ApiParameterSource Source { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Http.Description.ApiParameterSource); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public enum ApiParameterSource {
    FromBody = 1,
    FromUri = 0,
    Unknown = 2,
  }
  public partial interface IApiExplorer {
    System.Collections.ObjectModel.Collection<System.Web.Http.Description.ApiDescription> ApiDescriptions { get; }
  }
  public partial interface IDocumentationProvider {
    string GetDocumentation(System.Web.Http.Controllers.HttpActionDescriptor actionDescriptor);
    string GetDocumentation(System.Web.Http.Controllers.HttpParameterDescriptor parameterDescriptor);
  }
}
namespace System.Web.Http.Dispatcher {
  public partial class DefaultHttpControllerActivator : System.Web.Http.Dispatcher.IHttpControllerActivator {
    public DefaultHttpControllerActivator() { }
    public System.Web.Http.Controllers.IHttpController Create(System.Net.Http.HttpRequestMessage request, System.Web.Http.Controllers.HttpControllerDescriptor controllerDescriptor, System.Type controllerType) { return default(System.Web.Http.Controllers.IHttpController); }
  }
  public partial class DefaultHttpControllerSelector : System.Web.Http.Dispatcher.IHttpControllerSelector {
    public static readonly string ControllerSuffix;
    public DefaultHttpControllerSelector(System.Web.Http.HttpConfiguration configuration) { }
    public virtual System.Collections.Generic.IDictionary<System.String, System.Web.Http.Controllers.HttpControllerDescriptor> GetControllerMapping() { return default(System.Collections.Generic.IDictionary<System.String, System.Web.Http.Controllers.HttpControllerDescriptor>); }
    public virtual string GetControllerName(System.Net.Http.HttpRequestMessage request) { return default(string); }
    public virtual System.Web.Http.Controllers.HttpControllerDescriptor SelectController(System.Net.Http.HttpRequestMessage request) { return default(System.Web.Http.Controllers.HttpControllerDescriptor); }
  }
  public partial class DefaultHttpControllerTypeResolver : System.Web.Http.Dispatcher.IHttpControllerTypeResolver {
    public DefaultHttpControllerTypeResolver() { }
    public DefaultHttpControllerTypeResolver(System.Predicate<System.Type> predicate) { }
    protected System.Predicate<System.Type> IsControllerTypePredicate { get { return default(System.Predicate<System.Type>); } }
    public virtual System.Collections.Generic.ICollection<System.Type> GetControllerTypes(System.Web.Http.Dispatcher.IAssembliesResolver assembliesResolver) { return default(System.Collections.Generic.ICollection<System.Type>); }
  }
  [System.Runtime.Serialization.DataContractAttribute(Name="Exception")]
  [System.Xml.Serialization.XmlRootAttribute("Exception")]
  public partial class ExceptionSurrogate {
    internal ExceptionSurrogate() { }
    [System.Runtime.Serialization.DataMemberAttribute]
    public string ExceptionType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, IsRequired=false)]
    public System.Web.Http.Dispatcher.ExceptionSurrogate InnerException { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Http.Dispatcher.ExceptionSurrogate); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, IsRequired=false)]
    public string Message { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, IsRequired=false)]
    public string StackTrace { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial class HttpControllerDispatcher : System.Net.Http.HttpMessageHandler {
    public HttpControllerDispatcher() { }
    public HttpControllerDispatcher(System.Web.Http.HttpConfiguration configuration) { }
    public System.Web.Http.HttpConfiguration Configuration { get { return default(System.Web.Http.HttpConfiguration); } }
    protected override void Dispose(bool disposing) { }
    protected override System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>); }
  }
  public partial interface IAssembliesResolver {
    System.Collections.Generic.ICollection<System.Reflection.Assembly> GetAssemblies();
  }
  public partial interface IHttpControllerActivator {
    System.Web.Http.Controllers.IHttpController Create(System.Net.Http.HttpRequestMessage request, System.Web.Http.Controllers.HttpControllerDescriptor controllerDescriptor, System.Type controllerType);
  }
  public partial interface IHttpControllerSelector {
    System.Collections.Generic.IDictionary<System.String, System.Web.Http.Controllers.HttpControllerDescriptor> GetControllerMapping();
    System.Web.Http.Controllers.HttpControllerDescriptor SelectController(System.Net.Http.HttpRequestMessage request);
  }
  public partial interface IHttpControllerTypeResolver {
    System.Collections.Generic.ICollection<System.Type> GetControllerTypes(System.Web.Http.Dispatcher.IAssembliesResolver assembliesResolver);
  }
}
namespace System.Web.Http.Filters {
  public partial class ActionDescriptorFilterProvider : System.Web.Http.Filters.IFilterProvider {
    public ActionDescriptorFilterProvider() { }
    public System.Collections.Generic.IEnumerable<System.Web.Http.Filters.FilterInfo> GetFilters(System.Web.Http.HttpConfiguration configuration, System.Web.Http.Controllers.HttpActionDescriptor actionDescriptor) { return default(System.Collections.Generic.IEnumerable<System.Web.Http.Filters.FilterInfo>); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(68), Inherited=true, AllowMultiple=true)]
  public abstract partial class ActionFilterAttribute : System.Web.Http.Filters.FilterAttribute, System.Web.Http.Filters.IActionFilter, System.Web.Http.Filters.IFilter {
    protected ActionFilterAttribute() { }
    public virtual void OnActionExecuted(System.Web.Http.Filters.HttpActionExecutedContext actionExecutedContext) { }
    public virtual void OnActionExecuting(System.Web.Http.Controllers.HttpActionContext actionContext) { }
    System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> System.Web.Http.Filters.IActionFilter.ExecuteActionFilterAsync(System.Web.Http.Controllers.HttpActionContext actionContext, System.Threading.CancellationToken cancellationToken, System.Func<System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>> continuation) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(68), Inherited=true, AllowMultiple=true)]
  public abstract partial class AuthorizationFilterAttribute : System.Web.Http.Filters.FilterAttribute, System.Web.Http.Filters.IAuthorizationFilter, System.Web.Http.Filters.IFilter {
    protected AuthorizationFilterAttribute() { }
    public virtual void OnAuthorization(System.Web.Http.Controllers.HttpActionContext actionContext) { }
    System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> System.Web.Http.Filters.IAuthorizationFilter.ExecuteAuthorizationFilterAsync(System.Web.Http.Controllers.HttpActionContext actionContext, System.Threading.CancellationToken cancellationToken, System.Func<System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>> continuation) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>); }
  }
  public partial class ConfigurationFilterProvider : System.Web.Http.Filters.IFilterProvider {
    public ConfigurationFilterProvider() { }
    public System.Collections.Generic.IEnumerable<System.Web.Http.Filters.FilterInfo> GetFilters(System.Web.Http.HttpConfiguration configuration, System.Web.Http.Controllers.HttpActionDescriptor actionDescriptor) { return default(System.Collections.Generic.IEnumerable<System.Web.Http.Filters.FilterInfo>); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(68), Inherited=true, AllowMultiple=true)]
  public abstract partial class ExceptionFilterAttribute : System.Web.Http.Filters.FilterAttribute, System.Web.Http.Filters.IExceptionFilter, System.Web.Http.Filters.IFilter {
    protected ExceptionFilterAttribute() { }
    public virtual void OnException(System.Web.Http.Filters.HttpActionExecutedContext actionExecutedContext) { }
    System.Threading.Tasks.Task System.Web.Http.Filters.IExceptionFilter.ExecuteExceptionFilterAsync(System.Web.Http.Filters.HttpActionExecutedContext actionExecutedContext, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(68), Inherited=true, AllowMultiple=true)]
  public abstract partial class FilterAttribute : System.Attribute, System.Web.Http.Filters.IFilter {
    protected FilterAttribute() { }
    public bool AllowMultiple { get { return default(bool); } }
  }
  public sealed partial class FilterInfo {
    public FilterInfo(System.Web.Http.Filters.IFilter instance, System.Web.Http.Filters.FilterScope scope) { }
    public System.Web.Http.Filters.IFilter Instance { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Http.Filters.IFilter); } }
    public System.Web.Http.Filters.FilterScope Scope { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Http.Filters.FilterScope); } }
  }
  public enum FilterScope {
    Action = 20,
    Controller = 10,
    Global = 0,
  }
  public partial class HttpActionExecutedContext {
    public HttpActionExecutedContext() { }
    public HttpActionExecutedContext(System.Web.Http.Controllers.HttpActionContext actionContext, System.Exception exception) { }
    public System.Web.Http.Controllers.HttpActionContext ActionContext { get { return default(System.Web.Http.Controllers.HttpActionContext); } set { } }
    public System.Exception Exception { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Exception); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Net.Http.HttpRequestMessage Request { get { return default(System.Net.Http.HttpRequestMessage); } }
    public System.Net.Http.HttpResponseMessage Response { get { return default(System.Net.Http.HttpResponseMessage); } set { } }
  }
  public partial class HttpFilterCollection : System.Collections.Generic.IEnumerable<System.Web.Http.Filters.FilterInfo>, System.Collections.IEnumerable {
    public HttpFilterCollection() { }
    public int Count { get { return default(int); } }
    public void Add(System.Web.Http.Filters.IFilter filter) { }
    public void Clear() { }
    public bool Contains(System.Web.Http.Filters.IFilter filter) { return default(bool); }
    public System.Collections.Generic.IEnumerator<System.Web.Http.Filters.FilterInfo> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Web.Http.Filters.FilterInfo>); }
    public void Remove(System.Web.Http.Filters.IFilter filter) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public partial interface IActionFilter : System.Web.Http.Filters.IFilter {
    System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> ExecuteActionFilterAsync(System.Web.Http.Controllers.HttpActionContext actionContext, System.Threading.CancellationToken cancellationToken, System.Func<System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>> continuation);
  }
  public partial interface IAuthorizationFilter : System.Web.Http.Filters.IFilter {
    System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> ExecuteAuthorizationFilterAsync(System.Web.Http.Controllers.HttpActionContext actionContext, System.Threading.CancellationToken cancellationToken, System.Func<System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>> continuation);
  }
  public partial interface IExceptionFilter : System.Web.Http.Filters.IFilter {
    System.Threading.Tasks.Task ExecuteExceptionFilterAsync(System.Web.Http.Filters.HttpActionExecutedContext actionExecutedContext, System.Threading.CancellationToken cancellationToken);
  }
  public partial interface IFilter {
    bool AllowMultiple { get; }
  }
  public partial interface IFilterProvider {
    System.Collections.Generic.IEnumerable<System.Web.Http.Filters.FilterInfo> GetFilters(System.Web.Http.HttpConfiguration configuration, System.Web.Http.Controllers.HttpActionDescriptor actionDescriptor);
  }
}
namespace System.Web.Http.Hosting {
  public static partial class HttpPropertyKeys {
    public static readonly string DependencyScope;
    public static readonly string DisposableRequestResourcesKey;
    public static readonly string HttpConfigurationKey;
    public static readonly string HttpRouteDataKey;
    public static readonly string RequestCorrelationKey;
    public static readonly string SynchronizationContextKey;
  }
}
namespace System.Web.Http.Metadata {
  public partial class ModelMetadata {
    public ModelMetadata(System.Web.Http.Metadata.ModelMetadataProvider provider, System.Type containerType, System.Func<System.Object> modelAccessor, System.Type modelType, string propertyName) { }
    public virtual System.Collections.Generic.Dictionary<System.String, System.Object> AdditionalValues { get { return default(System.Collections.Generic.Dictionary<System.String, System.Object>); } }
    public System.Type ContainerType { get { return default(System.Type); } }
    public virtual bool ConvertEmptyStringToNull { get { return default(bool); } set { } }
    public virtual string Description { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public virtual bool IsComplexType { get { return default(bool); } }
    public bool IsNullableValueType { get { return default(bool); } }
    public virtual bool IsReadOnly { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public object Model { get { return default(object); } set { } }
    public System.Type ModelType { get { return default(System.Type); } }
    public virtual System.Collections.Generic.IEnumerable<System.Web.Http.Metadata.ModelMetadata> Properties { get { return default(System.Collections.Generic.IEnumerable<System.Web.Http.Metadata.ModelMetadata>); } }
    public string PropertyName { get { return default(string); } }
    protected System.Web.Http.Metadata.ModelMetadataProvider Provider { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Http.Metadata.ModelMetadataProvider); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string GetDisplayName() { return default(string); }
    public virtual System.Collections.Generic.IEnumerable<System.Web.Http.Validation.ModelValidator> GetValidators(System.Collections.Generic.IEnumerable<System.Web.Http.Validation.ModelValidatorProvider> validatorProviders) { return default(System.Collections.Generic.IEnumerable<System.Web.Http.Validation.ModelValidator>); }
  }
  public abstract partial class ModelMetadataProvider {
    protected ModelMetadataProvider() { }
    public abstract System.Collections.Generic.IEnumerable<System.Web.Http.Metadata.ModelMetadata> GetMetadataForProperties(object container, System.Type containerType);
    public abstract System.Web.Http.Metadata.ModelMetadata GetMetadataForProperty(System.Func<System.Object> modelAccessor, System.Type containerType, string propertyName);
    public abstract System.Web.Http.Metadata.ModelMetadata GetMetadataForType(System.Func<System.Object> modelAccessor, System.Type modelType);
  }
}
namespace System.Web.Http.Metadata.Providers {
  public abstract partial class AssociatedMetadataProvider<TModelMetadata> : System.Web.Http.Metadata.ModelMetadataProvider where TModelMetadata : System.Web.Http.Metadata.ModelMetadata {
    protected AssociatedMetadataProvider() { }
    protected abstract TModelMetadata CreateMetadataFromPrototype(TModelMetadata prototype, System.Func<System.Object> modelAccessor);
    protected abstract TModelMetadata CreateMetadataPrototype(System.Collections.Generic.IEnumerable<System.Attribute> attributes, System.Type containerType, System.Type modelType, string propertyName);
    public sealed override System.Collections.Generic.IEnumerable<System.Web.Http.Metadata.ModelMetadata> GetMetadataForProperties(object container, System.Type containerType) { return default(System.Collections.Generic.IEnumerable<System.Web.Http.Metadata.ModelMetadata>); }
    public sealed override System.Web.Http.Metadata.ModelMetadata GetMetadataForProperty(System.Func<System.Object> modelAccessor, System.Type containerType, string propertyName) { return default(System.Web.Http.Metadata.ModelMetadata); }
    public sealed override System.Web.Http.Metadata.ModelMetadata GetMetadataForType(System.Func<System.Object> modelAccessor, System.Type modelType) { return default(System.Web.Http.Metadata.ModelMetadata); }
  }
  public partial class CachedDataAnnotationsMetadataAttributes {
    public CachedDataAnnotationsMetadataAttributes(System.Collections.Generic.IEnumerable<System.Attribute> attributes) { }
    public System.ComponentModel.DataAnnotations.DisplayAttribute Display { [System.Runtime.CompilerServices.CompilerGeneratedAttribute, System.Security.SecuritySafeCriticalAttribute]get { return default(System.ComponentModel.DataAnnotations.DisplayAttribute); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute, System.Security.SecuritySafeCriticalAttribute]protected set { } }
    public System.ComponentModel.DataAnnotations.DisplayFormatAttribute DisplayFormat { [System.Runtime.CompilerServices.CompilerGeneratedAttribute, System.Security.SecuritySafeCriticalAttribute]get { return default(System.ComponentModel.DataAnnotations.DisplayFormatAttribute); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute, System.Security.SecuritySafeCriticalAttribute]protected set { } }
    public System.ComponentModel.DataAnnotations.EditableAttribute Editable { [System.Runtime.CompilerServices.CompilerGeneratedAttribute, System.Security.SecuritySafeCriticalAttribute]get { return default(System.ComponentModel.DataAnnotations.EditableAttribute); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute, System.Security.SecuritySafeCriticalAttribute]protected set { } }
    public System.ComponentModel.ReadOnlyAttribute ReadOnly { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ComponentModel.ReadOnlyAttribute); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
  }
  public partial class CachedDataAnnotationsModelMetadata : System.Web.Http.Metadata.Providers.CachedModelMetadata<System.Web.Http.Metadata.Providers.CachedDataAnnotationsMetadataAttributes> {
    public CachedDataAnnotationsModelMetadata(System.Web.Http.Metadata.Providers.CachedDataAnnotationsModelMetadata prototype, System.Func<System.Object> modelAccessor) : base (default(System.Web.Http.Metadata.Providers.CachedModelMetadata<System.Web.Http.Metadata.Providers.CachedDataAnnotationsMetadataAttributes>), default(System.Func<System.Object>)) { }
    public CachedDataAnnotationsModelMetadata(System.Web.Http.Metadata.Providers.DataAnnotationsModelMetadataProvider provider, System.Type containerType, System.Type modelType, string propertyName, System.Collections.Generic.IEnumerable<System.Attribute> attributes) : base (default(System.Web.Http.Metadata.Providers.CachedModelMetadata<System.Web.Http.Metadata.Providers.CachedDataAnnotationsMetadataAttributes>), default(System.Func<System.Object>)) { }
    [System.Security.SecuritySafeCriticalAttribute]
    protected override bool ComputeConvertEmptyStringToNull() { return default(bool); }
    [System.Security.SecuritySafeCriticalAttribute]
    protected override string ComputeDescription() { return default(string); }
    [System.Security.SecuritySafeCriticalAttribute]
    protected override bool ComputeIsReadOnly() { return default(bool); }
  }
  public abstract partial class CachedModelMetadata<TPrototypeCache> : System.Web.Http.Metadata.ModelMetadata {
    protected CachedModelMetadata(System.Web.Http.Metadata.Providers.CachedModelMetadata<TPrototypeCache> prototype, System.Func<System.Object> modelAccessor) : base (default(System.Web.Http.Metadata.ModelMetadataProvider), default(System.Type), default(System.Func<System.Object>), default(System.Type), default(string)) { }
    protected CachedModelMetadata(System.Web.Http.Metadata.Providers.DataAnnotationsModelMetadataProvider provider, System.Type containerType, System.Type modelType, string propertyName, TPrototypeCache prototypeCache) : base (default(System.Web.Http.Metadata.ModelMetadataProvider), default(System.Type), default(System.Func<System.Object>), default(System.Type), default(string)) { }
    public sealed override bool ConvertEmptyStringToNull { get { return default(bool); } set { } }
    public sealed override string Description { get { return default(string); } set { } }
    public sealed override bool IsReadOnly { get { return default(bool); } set { } }
    protected TPrototypeCache PrototypeCache { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TPrototypeCache); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected virtual bool ComputeConvertEmptyStringToNull() { return default(bool); }
    protected virtual string ComputeDescription() { return default(string); }
    protected virtual bool ComputeIsReadOnly() { return default(bool); }
  }
  public partial class DataAnnotationsModelMetadataProvider : System.Web.Http.Metadata.Providers.AssociatedMetadataProvider<System.Web.Http.Metadata.Providers.CachedDataAnnotationsModelMetadata> {
    public DataAnnotationsModelMetadataProvider() { }
    protected override System.Web.Http.Metadata.Providers.CachedDataAnnotationsModelMetadata CreateMetadataFromPrototype(System.Web.Http.Metadata.Providers.CachedDataAnnotationsModelMetadata prototype, System.Func<System.Object> modelAccessor) { return default(System.Web.Http.Metadata.Providers.CachedDataAnnotationsModelMetadata); }
    protected override System.Web.Http.Metadata.Providers.CachedDataAnnotationsModelMetadata CreateMetadataPrototype(System.Collections.Generic.IEnumerable<System.Attribute> attributes, System.Type containerType, System.Type modelType, string propertyName) { return default(System.Web.Http.Metadata.Providers.CachedDataAnnotationsModelMetadata); }
  }
  public partial class EmptyModelMetadataProvider : System.Web.Http.Metadata.Providers.AssociatedMetadataProvider<System.Web.Http.Metadata.ModelMetadata> {
    public EmptyModelMetadataProvider() { }
    protected override System.Web.Http.Metadata.ModelMetadata CreateMetadataFromPrototype(System.Web.Http.Metadata.ModelMetadata prototype, System.Func<System.Object> modelAccessor) { return default(System.Web.Http.Metadata.ModelMetadata); }
    protected override System.Web.Http.Metadata.ModelMetadata CreateMetadataPrototype(System.Collections.Generic.IEnumerable<System.Attribute> attributes, System.Type containerType, System.Type modelType, string propertyName) { return default(System.Web.Http.Metadata.ModelMetadata); }
  }
}
namespace System.Web.Http.ModelBinding {
  public partial class CancellationTokenParameterBinding : System.Web.Http.Controllers.HttpParameterBinding {
    public CancellationTokenParameterBinding(System.Web.Http.Controllers.HttpParameterDescriptor descriptor) : base (default(System.Web.Http.Controllers.HttpParameterDescriptor)) { }
    public override System.Threading.Tasks.Task ExecuteBindingAsync(System.Web.Http.Metadata.ModelMetadataProvider metadataProvider, System.Web.Http.Controllers.HttpActionContext actionContext, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(3100), AllowMultiple=false, Inherited=false)]
  public abstract partial class CustomModelBinderAttribute : System.Attribute {
    protected CustomModelBinderAttribute() { }
    public abstract System.Web.Http.ModelBinding.IModelBinder GetBinder();
  }
  public partial class DefaultActionValueBinder : System.Web.Http.Controllers.IActionValueBinder {
    public DefaultActionValueBinder() { }
    public virtual System.Web.Http.Controllers.HttpActionBinding GetBinding(System.Web.Http.Controllers.HttpActionDescriptor actionDescriptor) { return default(System.Web.Http.Controllers.HttpActionBinding); }
    protected virtual System.Web.Http.Validation.IBodyModelValidator GetBodyModelValidator(System.Web.Http.Controllers.HttpActionDescriptor actionDescriptor) { return default(System.Web.Http.Validation.IBodyModelValidator); }
    protected virtual System.Collections.Generic.IEnumerable<System.Net.Http.Formatting.MediaTypeFormatter> GetFormatters(System.Web.Http.Controllers.HttpActionDescriptor actionDescriptor) { return default(System.Collections.Generic.IEnumerable<System.Net.Http.Formatting.MediaTypeFormatter>); }
  }
  public partial class ErrorParameterBinding : System.Web.Http.Controllers.HttpParameterBinding {
    public ErrorParameterBinding(System.Web.Http.Controllers.HttpParameterDescriptor descriptor, string message) : base (default(System.Web.Http.Controllers.HttpParameterDescriptor)) { }
    public override string ErrorMessage { get { return default(string); } }
    public override System.Threading.Tasks.Task ExecuteBindingAsync(System.Web.Http.Metadata.ModelMetadataProvider metadataProvider, System.Web.Http.Controllers.HttpActionContext actionContext, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
  }
  public partial class FormatterParameterBinding : System.Web.Http.Controllers.HttpParameterBinding {
    public FormatterParameterBinding(System.Web.Http.Controllers.HttpParameterDescriptor descriptor, System.Collections.Generic.IEnumerable<System.Net.Http.Formatting.MediaTypeFormatter> formatters, System.Web.Http.Validation.IBodyModelValidator bodyModelValidator) : base (default(System.Web.Http.Controllers.HttpParameterDescriptor)) { }
    public System.Web.Http.Validation.IBodyModelValidator BodyModelValidator { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Http.Validation.IBodyModelValidator); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.Generic.IEnumerable<System.Net.Http.Formatting.MediaTypeFormatter> Formatters { get { return default(System.Collections.Generic.IEnumerable<System.Net.Http.Formatting.MediaTypeFormatter>); } set { } }
    public override bool WillReadBody { get { return default(bool); } }
    public override System.Threading.Tasks.Task ExecuteBindingAsync(System.Web.Http.Metadata.ModelMetadataProvider metadataProvider, System.Web.Http.Controllers.HttpActionContext actionContext, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
    protected virtual System.Threading.Tasks.Task<System.Object> ReadContentAsync(System.Net.Http.HttpRequestMessage request, System.Type type, System.Collections.Generic.IEnumerable<System.Net.Http.Formatting.MediaTypeFormatter> formatters, System.Net.Http.Formatting.IFormatterLogger formatterLogger) { return default(System.Threading.Tasks.Task<System.Object>); }
  }
  public static partial class FormDataCollectionExtensions {
    public static object ReadAs(this System.Net.Http.Formatting.FormDataCollection formData, System.Type type) { return default(object); }
    public static object ReadAs(this System.Net.Http.Formatting.FormDataCollection formData, System.Type type, string modelName, System.Net.Http.Formatting.IRequiredMemberSelector requiredMemberSelector, System.Net.Http.Formatting.IFormatterLogger formatterLogger) { return default(object); }
    public static T ReadAs<T>(this System.Net.Http.Formatting.FormDataCollection formData) { return default(T); }
    public static T ReadAs<T>(this System.Net.Http.Formatting.FormDataCollection formData, string modelName, System.Net.Http.Formatting.IRequiredMemberSelector requiredMemberSelector, System.Net.Http.Formatting.IFormatterLogger formatterLogger) { return default(T); }
  }
  public enum HttpBindingBehavior {
    Never = 1,
    Optional = 0,
    Required = 2,
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(132), AllowMultiple=false, Inherited=true)]
  public partial class HttpBindingBehaviorAttribute : System.Attribute {
    public HttpBindingBehaviorAttribute(System.Web.Http.ModelBinding.HttpBindingBehavior behavior) { }
    public System.Web.Http.ModelBinding.HttpBindingBehavior Behavior { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Http.ModelBinding.HttpBindingBehavior); } }
    public override object TypeId { get { return default(object); } }
  }
  public partial class HttpRequestParameterBinding : System.Web.Http.Controllers.HttpParameterBinding {
    public HttpRequestParameterBinding(System.Web.Http.Controllers.HttpParameterDescriptor descriptor) : base (default(System.Web.Http.Controllers.HttpParameterDescriptor)) { }
    public override System.Threading.Tasks.Task ExecuteBindingAsync(System.Web.Http.Metadata.ModelMetadataProvider metadataProvider, System.Web.Http.Controllers.HttpActionContext actionContext, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
  }
  public partial interface IModelBinder {
    bool BindModel(System.Web.Http.Controllers.HttpActionContext actionContext, System.Web.Http.ModelBinding.ModelBindingContext bindingContext);
  }
  public partial class JQueryMvcFormUrlEncodedFormatter : System.Net.Http.Formatting.FormUrlEncodedMediaTypeFormatter {
    public JQueryMvcFormUrlEncodedFormatter() { }
    public override bool CanReadType(System.Type type) { return default(bool); }
    public override System.Threading.Tasks.Task<System.Object> ReadFromStreamAsync(System.Type type, System.IO.Stream stream, System.Net.Http.Headers.HttpContentHeaders contentHeaders, System.Net.Http.Formatting.IFormatterLogger formatterLogger) { return default(System.Threading.Tasks.Task<System.Object>); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(2052), Inherited=true, AllowMultiple=false)]
  public partial class ModelBinderAttribute : System.Attribute {
    public ModelBinderAttribute() { }
    public ModelBinderAttribute(System.Type binderType) { }
    public System.Type BinderType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool SuppressPrefixCheck { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Web.Http.ModelBinding.ModelBinderProvider GetModelBinderProvider(System.Web.Http.HttpConfiguration configuration) { return default(System.Web.Http.ModelBinding.ModelBinderProvider); }
    public virtual System.Collections.Generic.IEnumerable<System.Web.Http.ValueProviders.ValueProviderFactory> GetValueProviderFactories(System.Web.Http.HttpConfiguration configuration) { return default(System.Collections.Generic.IEnumerable<System.Web.Http.ValueProviders.ValueProviderFactory>); }
  }
  public static partial class ModelBinderConfig {
    public static string ResourceClassKey { get { return default(string); } set { } }
    public static System.Web.Http.ModelBinding.ModelBinderErrorMessageProvider TypeConversionErrorMessageProvider { get { return default(System.Web.Http.ModelBinding.ModelBinderErrorMessageProvider); } set { } }
    public static System.Web.Http.ModelBinding.ModelBinderErrorMessageProvider ValueRequiredErrorMessageProvider { get { return default(System.Web.Http.ModelBinding.ModelBinderErrorMessageProvider); } set { } }
  }
  public delegate string ModelBinderErrorMessageProvider(System.Web.Http.Controllers.HttpActionContext actionContext, System.Web.Http.Metadata.ModelMetadata modelMetadata, object incomingValue);
  public partial class ModelBinderParameterBinding : System.Web.Http.Controllers.HttpParameterBinding {
    public ModelBinderParameterBinding(System.Web.Http.Controllers.HttpParameterDescriptor descriptor, System.Web.Http.ModelBinding.ModelBinderProvider modelBinderProvider, System.Collections.Generic.IEnumerable<System.Web.Http.ValueProviders.ValueProviderFactory> valueProviderFactories) : base (default(System.Web.Http.Controllers.HttpParameterDescriptor)) { }
    public System.Web.Http.ModelBinding.ModelBinderProvider ModelBinderProvider { get { return default(System.Web.Http.ModelBinding.ModelBinderProvider); } }
    public System.Collections.Generic.IEnumerable<System.Web.Http.ValueProviders.ValueProviderFactory> ValueProviderFactories { get { return default(System.Collections.Generic.IEnumerable<System.Web.Http.ValueProviders.ValueProviderFactory>); } }
    public override System.Threading.Tasks.Task ExecuteBindingAsync(System.Web.Http.Metadata.ModelMetadataProvider metadataProvider, System.Web.Http.Controllers.HttpActionContext actionContext, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
  }
  public abstract partial class ModelBinderProvider {
    protected ModelBinderProvider() { }
    public abstract System.Web.Http.ModelBinding.IModelBinder GetBinder(System.Web.Http.Controllers.HttpActionContext actionContext, System.Web.Http.ModelBinding.ModelBindingContext bindingContext);
  }
  public partial class ModelBindingContext {
    public ModelBindingContext() { }
    public ModelBindingContext(System.Web.Http.ModelBinding.ModelBindingContext bindingContext) { }
    public bool FallbackToEmptyPrefix { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public object Model { get { return default(object); } set { } }
    public System.Web.Http.Metadata.ModelMetadata ModelMetadata { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Http.Metadata.ModelMetadata); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string ModelName { get { return default(string); } set { } }
    public System.Web.Http.ModelBinding.ModelStateDictionary ModelState { get { return default(System.Web.Http.ModelBinding.ModelStateDictionary); } set { } }
    public System.Type ModelType { get { return default(System.Type); } }
    public System.Collections.Generic.IDictionary<System.String, System.Web.Http.Metadata.ModelMetadata> PropertyMetadata { get { return default(System.Collections.Generic.IDictionary<System.String, System.Web.Http.Metadata.ModelMetadata>); } }
    public System.Web.Http.Validation.ModelValidationNode ValidationNode { get { return default(System.Web.Http.Validation.ModelValidationNode); } set { } }
    public System.Web.Http.ValueProviders.IValueProvider ValueProvider { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Http.ValueProviders.IValueProvider); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial class ModelError {
    public ModelError(System.Exception exception) { }
    public ModelError(System.Exception exception, string errorMessage) { }
    public ModelError(string errorMessage) { }
    public string ErrorMessage { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public System.Exception Exception { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Exception); } }
  }
  public partial class ModelErrorCollection : System.Collections.ObjectModel.Collection<System.Web.Http.ModelBinding.ModelError> {
    public ModelErrorCollection() { }
    public void Add(System.Exception exception) { }
    public void Add(string errorMessage) { }
  }
  public partial class ModelState {
    public ModelState() { }
    public System.Web.Http.ModelBinding.ModelErrorCollection Errors { get { return default(System.Web.Http.ModelBinding.ModelErrorCollection); } }
    public System.Web.Http.ValueProviders.ValueProviderResult Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Http.ValueProviders.ValueProviderResult); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial class ModelStateDictionary : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String, System.Web.Http.ModelBinding.ModelState>>, System.Collections.Generic.IDictionary<System.String, System.Web.Http.ModelBinding.ModelState>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Web.Http.ModelBinding.ModelState>>, System.Collections.IEnumerable {
    public ModelStateDictionary() { }
    public ModelStateDictionary(System.Web.Http.ModelBinding.ModelStateDictionary dictionary) { }
    public int Count { get { return default(int); } }
    public bool IsReadOnly { get { return default(bool); } }
    public bool IsValid { get { return default(bool); } }
    public System.Web.Http.ModelBinding.ModelState this[string key] { get { return default(System.Web.Http.ModelBinding.ModelState); } set { } }
    public System.Collections.Generic.ICollection<System.String> Keys { get { return default(System.Collections.Generic.ICollection<System.String>); } }
    public System.Collections.Generic.ICollection<System.Web.Http.ModelBinding.ModelState> Values { get { return default(System.Collections.Generic.ICollection<System.Web.Http.ModelBinding.ModelState>); } }
    public void Add(System.Collections.Generic.KeyValuePair<System.String, System.Web.Http.ModelBinding.ModelState> item) { }
    public void Add(string key, System.Web.Http.ModelBinding.ModelState value) { }
    public void AddModelError(string key, System.Exception exception) { }
    public void AddModelError(string key, string errorMessage) { }
    public void Clear() { }
    public bool Contains(System.Collections.Generic.KeyValuePair<System.String, System.Web.Http.ModelBinding.ModelState> item) { return default(bool); }
    public bool ContainsKey(string key) { return default(bool); }
    public void CopyTo(System.Collections.Generic.KeyValuePair<System.String, System.Web.Http.ModelBinding.ModelState>[] array, int arrayIndex) { }
    public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String, System.Web.Http.ModelBinding.ModelState>> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String, System.Web.Http.ModelBinding.ModelState>>); }
    public bool IsValidField(string key) { return default(bool); }
    public void Merge(System.Web.Http.ModelBinding.ModelStateDictionary dictionary) { }
    public bool Remove(System.Collections.Generic.KeyValuePair<System.String, System.Web.Http.ModelBinding.ModelState> item) { return default(bool); }
    public bool Remove(string key) { return default(bool); }
    public void SetModelValue(string key, System.Web.Http.ValueProviders.ValueProviderResult value) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    public bool TryGetValue(string key, out System.Web.Http.ModelBinding.ModelState value) { value = default(System.Web.Http.ModelBinding.ModelState); return default(bool); }
  }
}
namespace System.Web.Http.ModelBinding.Binders {
  public partial class ArrayModelBinder<TElement> : System.Web.Http.ModelBinding.Binders.CollectionModelBinder<TElement> {
    public ArrayModelBinder() { }
    protected override bool CreateOrReplaceCollection(System.Web.Http.Controllers.HttpActionContext actionContext, System.Web.Http.ModelBinding.ModelBindingContext bindingContext, System.Collections.Generic.IList<TElement> newCollection) { return default(bool); }
  }
  public sealed partial class ArrayModelBinderProvider : System.Web.Http.ModelBinding.ModelBinderProvider {
    public ArrayModelBinderProvider() { }
    public override System.Web.Http.ModelBinding.IModelBinder GetBinder(System.Web.Http.Controllers.HttpActionContext actionContext, System.Web.Http.ModelBinding.ModelBindingContext bindingContext) { return default(System.Web.Http.ModelBinding.IModelBinder); }
  }
  public sealed partial class BinaryDataModelBinderProvider : System.Web.Http.ModelBinding.ModelBinderProvider {
    public BinaryDataModelBinderProvider() { }
    public override System.Web.Http.ModelBinding.IModelBinder GetBinder(System.Web.Http.Controllers.HttpActionContext actionContext, System.Web.Http.ModelBinding.ModelBindingContext bindingContext) { return default(System.Web.Http.ModelBinding.IModelBinder); }
  }
  public partial class CollectionModelBinder<TElement> : System.Web.Http.ModelBinding.IModelBinder {
    public CollectionModelBinder() { }
    public virtual bool BindModel(System.Web.Http.Controllers.HttpActionContext actionContext, System.Web.Http.ModelBinding.ModelBindingContext bindingContext) { return default(bool); }
    protected virtual bool CreateOrReplaceCollection(System.Web.Http.Controllers.HttpActionContext actionContext, System.Web.Http.ModelBinding.ModelBindingContext bindingContext, System.Collections.Generic.IList<TElement> newCollection) { return default(bool); }
  }
  public sealed partial class CollectionModelBinderProvider : System.Web.Http.ModelBinding.ModelBinderProvider {
    public CollectionModelBinderProvider() { }
    public override System.Web.Http.ModelBinding.IModelBinder GetBinder(System.Web.Http.Controllers.HttpActionContext actionContext, System.Web.Http.ModelBinding.ModelBindingContext bindingContext) { return default(System.Web.Http.ModelBinding.IModelBinder); }
  }
  public partial class ComplexModelDto {
    public ComplexModelDto(System.Web.Http.Metadata.ModelMetadata modelMetadata, System.Collections.Generic.IEnumerable<System.Web.Http.Metadata.ModelMetadata> propertyMetadata) { }
    public System.Web.Http.Metadata.ModelMetadata ModelMetadata { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Http.Metadata.ModelMetadata); } }
    public System.Collections.ObjectModel.Collection<System.Web.Http.Metadata.ModelMetadata> PropertyMetadata { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.ObjectModel.Collection<System.Web.Http.Metadata.ModelMetadata>); } }
    public System.Collections.Generic.IDictionary<System.Web.Http.Metadata.ModelMetadata, System.Web.Http.ModelBinding.Binders.ComplexModelDtoResult> Results { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IDictionary<System.Web.Http.Metadata.ModelMetadata, System.Web.Http.ModelBinding.Binders.ComplexModelDtoResult>); } }
  }
  public sealed partial class ComplexModelDtoModelBinder : System.Web.Http.ModelBinding.IModelBinder {
    public ComplexModelDtoModelBinder() { }
    public bool BindModel(System.Web.Http.Controllers.HttpActionContext actionContext, System.Web.Http.ModelBinding.ModelBindingContext bindingContext) { return default(bool); }
  }
  public sealed partial class ComplexModelDtoModelBinderProvider : System.Web.Http.ModelBinding.ModelBinderProvider {
    public ComplexModelDtoModelBinderProvider() { }
    public override System.Web.Http.ModelBinding.IModelBinder GetBinder(System.Web.Http.Controllers.HttpActionContext actionContext, System.Web.Http.ModelBinding.ModelBindingContext bindingContext) { return default(System.Web.Http.ModelBinding.IModelBinder); }
  }
  public sealed partial class ComplexModelDtoResult {
    public ComplexModelDtoResult(object model, System.Web.Http.Validation.ModelValidationNode validationNode) { }
    public object Model { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } }
    public System.Web.Http.Validation.ModelValidationNode ValidationNode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Http.Validation.ModelValidationNode); } }
  }
  public partial class CompositeModelBinder : System.Web.Http.ModelBinding.IModelBinder {
    public CompositeModelBinder(System.Collections.Generic.IEnumerable<System.Web.Http.ModelBinding.ModelBinderProvider> modelBinderProviders) { }
    public CompositeModelBinder(System.Web.Http.ModelBinding.ModelBinderProvider[] modelBinderProviders) { }
    public virtual bool BindModel(System.Web.Http.Controllers.HttpActionContext actionContext, System.Web.Http.ModelBinding.ModelBindingContext bindingContext) { return default(bool); }
  }
  public sealed partial class CompositeModelBinderProvider : System.Web.Http.ModelBinding.ModelBinderProvider {
    public CompositeModelBinderProvider() { }
    public CompositeModelBinderProvider(System.Collections.Generic.IEnumerable<System.Web.Http.ModelBinding.ModelBinderProvider> providers) { }
    public System.Collections.Generic.IEnumerable<System.Web.Http.ModelBinding.ModelBinderProvider> Providers { get { return default(System.Collections.Generic.IEnumerable<System.Web.Http.ModelBinding.ModelBinderProvider>); } }
    public override System.Web.Http.ModelBinding.IModelBinder GetBinder(System.Web.Http.Controllers.HttpActionContext actionContext, System.Web.Http.ModelBinding.ModelBindingContext bindingContext) { return default(System.Web.Http.ModelBinding.IModelBinder); }
  }
  public partial class DictionaryModelBinder<TKey, TValue> : System.Web.Http.ModelBinding.Binders.CollectionModelBinder<System.Collections.Generic.KeyValuePair<TKey, TValue>> {
    public DictionaryModelBinder() { }
    protected override bool CreateOrReplaceCollection(System.Web.Http.Controllers.HttpActionContext actionContext, System.Web.Http.ModelBinding.ModelBindingContext bindingContext, System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<TKey, TValue>> newCollection) { return default(bool); }
  }
  public sealed partial class DictionaryModelBinderProvider : System.Web.Http.ModelBinding.ModelBinderProvider {
    public DictionaryModelBinderProvider() { }
    public override System.Web.Http.ModelBinding.IModelBinder GetBinder(System.Web.Http.Controllers.HttpActionContext actionContext, System.Web.Http.ModelBinding.ModelBindingContext bindingContext) { return default(System.Web.Http.ModelBinding.IModelBinder); }
  }
  public sealed partial class GenericModelBinderProvider : System.Web.Http.ModelBinding.ModelBinderProvider {
    public GenericModelBinderProvider(System.Type modelType, System.Func<System.Type[], System.Web.Http.ModelBinding.IModelBinder> modelBinderFactory) { }
    public GenericModelBinderProvider(System.Type modelType, System.Type modelBinderType) { }
    public GenericModelBinderProvider(System.Type modelType, System.Web.Http.ModelBinding.IModelBinder modelBinder) { }
    public System.Type ModelType { get { return default(System.Type); } }
    public bool SuppressPrefixCheck { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override System.Web.Http.ModelBinding.IModelBinder GetBinder(System.Web.Http.Controllers.HttpActionContext actionContext, System.Web.Http.ModelBinding.ModelBindingContext bindingContext) { return default(System.Web.Http.ModelBinding.IModelBinder); }
  }
  public sealed partial class KeyValuePairModelBinder<TKey, TValue> : System.Web.Http.ModelBinding.IModelBinder {
    public KeyValuePairModelBinder() { }
    public bool BindModel(System.Web.Http.Controllers.HttpActionContext actionContext, System.Web.Http.ModelBinding.ModelBindingContext bindingContext) { return default(bool); }
  }
  public sealed partial class KeyValuePairModelBinderProvider : System.Web.Http.ModelBinding.ModelBinderProvider {
    public KeyValuePairModelBinderProvider() { }
    public override System.Web.Http.ModelBinding.IModelBinder GetBinder(System.Web.Http.Controllers.HttpActionContext actionContext, System.Web.Http.ModelBinding.ModelBindingContext bindingContext) { return default(System.Web.Http.ModelBinding.IModelBinder); }
  }
  public partial class MutableObjectModelBinder : System.Web.Http.ModelBinding.IModelBinder {
    public MutableObjectModelBinder() { }
    public virtual bool BindModel(System.Web.Http.Controllers.HttpActionContext actionContext, System.Web.Http.ModelBinding.ModelBindingContext bindingContext) { return default(bool); }
    protected virtual bool CanUpdateProperty(System.Web.Http.Metadata.ModelMetadata propertyMetadata) { return default(bool); }
    protected virtual object CreateModel(System.Web.Http.Controllers.HttpActionContext actionContext, System.Web.Http.ModelBinding.ModelBindingContext bindingContext) { return default(object); }
    protected virtual void EnsureModel(System.Web.Http.Controllers.HttpActionContext actionContext, System.Web.Http.ModelBinding.ModelBindingContext bindingContext) { }
    protected virtual System.Collections.Generic.IEnumerable<System.Web.Http.Metadata.ModelMetadata> GetMetadataForProperties(System.Web.Http.Controllers.HttpActionContext actionContext, System.Web.Http.ModelBinding.ModelBindingContext bindingContext) { return default(System.Collections.Generic.IEnumerable<System.Web.Http.Metadata.ModelMetadata>); }
    protected virtual void SetProperty(System.Web.Http.Controllers.HttpActionContext actionContext, System.Web.Http.ModelBinding.ModelBindingContext bindingContext, System.Web.Http.Metadata.ModelMetadata propertyMetadata, System.Web.Http.ModelBinding.Binders.ComplexModelDtoResult dtoResult, System.Web.Http.Validation.ModelValidator requiredValidator) { }
  }
  public sealed partial class MutableObjectModelBinderProvider : System.Web.Http.ModelBinding.ModelBinderProvider {
    public MutableObjectModelBinderProvider() { }
    public override System.Web.Http.ModelBinding.IModelBinder GetBinder(System.Web.Http.Controllers.HttpActionContext actionContext, System.Web.Http.ModelBinding.ModelBindingContext bindingContext) { return default(System.Web.Http.ModelBinding.IModelBinder); }
  }
  public sealed partial class SimpleModelBinderProvider : System.Web.Http.ModelBinding.ModelBinderProvider {
    public SimpleModelBinderProvider(System.Type modelType, System.Func<System.Web.Http.ModelBinding.IModelBinder> modelBinderFactory) { }
    public SimpleModelBinderProvider(System.Type modelType, System.Web.Http.ModelBinding.IModelBinder modelBinder) { }
    public System.Type ModelType { get { return default(System.Type); } }
    public bool SuppressPrefixCheck { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override System.Web.Http.ModelBinding.IModelBinder GetBinder(System.Web.Http.Controllers.HttpActionContext actionContext, System.Web.Http.ModelBinding.ModelBindingContext bindingContext) { return default(System.Web.Http.ModelBinding.IModelBinder); }
  }
  public sealed partial class TypeConverterModelBinder : System.Web.Http.ModelBinding.IModelBinder {
    public TypeConverterModelBinder() { }
    public bool BindModel(System.Web.Http.Controllers.HttpActionContext actionContext, System.Web.Http.ModelBinding.ModelBindingContext bindingContext) { return default(bool); }
  }
  public sealed partial class TypeConverterModelBinderProvider : System.Web.Http.ModelBinding.ModelBinderProvider {
    public TypeConverterModelBinderProvider() { }
    public override System.Web.Http.ModelBinding.IModelBinder GetBinder(System.Web.Http.Controllers.HttpActionContext actionContext, System.Web.Http.ModelBinding.ModelBindingContext bindingContext) { return default(System.Web.Http.ModelBinding.IModelBinder); }
  }
  public sealed partial class TypeMatchModelBinder : System.Web.Http.ModelBinding.IModelBinder {
    public TypeMatchModelBinder() { }
    public bool BindModel(System.Web.Http.Controllers.HttpActionContext actionContext, System.Web.Http.ModelBinding.ModelBindingContext bindingContext) { return default(bool); }
  }
  public sealed partial class TypeMatchModelBinderProvider : System.Web.Http.ModelBinding.ModelBinderProvider {
    public TypeMatchModelBinderProvider() { }
    public override System.Web.Http.ModelBinding.IModelBinder GetBinder(System.Web.Http.Controllers.HttpActionContext actionContext, System.Web.Http.ModelBinding.ModelBindingContext bindingContext) { return default(System.Web.Http.ModelBinding.IModelBinder); }
  }
}
namespace System.Web.Http.Routing {
  public partial class HttpMethodConstraint : System.Web.Http.Routing.IHttpRouteConstraint {
    public HttpMethodConstraint(params System.Net.Http.HttpMethod[] allowedMethods) { }
    public System.Collections.ObjectModel.Collection<System.Net.Http.HttpMethod> AllowedMethods { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.ObjectModel.Collection<System.Net.Http.HttpMethod>); } }
    protected virtual bool Match(System.Net.Http.HttpRequestMessage request, System.Web.Http.Routing.IHttpRoute route, string parameterName, System.Collections.Generic.IDictionary<System.String, System.Object> values, System.Web.Http.Routing.HttpRouteDirection routeDirection) { return default(bool); }
    bool System.Web.Http.Routing.IHttpRouteConstraint.Match(System.Net.Http.HttpRequestMessage request, System.Web.Http.Routing.IHttpRoute route, string parameterName, System.Collections.Generic.IDictionary<System.String, System.Object> values, System.Web.Http.Routing.HttpRouteDirection routeDirection) { return default(bool); }
  }
  public partial class HttpRoute : System.Web.Http.Routing.IHttpRoute {
    public HttpRoute() { }
    public HttpRoute(string routeTemplate) { }
    public HttpRoute(string routeTemplate, System.Web.Http.Routing.HttpRouteValueDictionary defaults) { }
    public HttpRoute(string routeTemplate, System.Web.Http.Routing.HttpRouteValueDictionary defaults, System.Web.Http.Routing.HttpRouteValueDictionary constraints) { }
    public HttpRoute(string routeTemplate, System.Web.Http.Routing.HttpRouteValueDictionary defaults, System.Web.Http.Routing.HttpRouteValueDictionary constraints, System.Web.Http.Routing.HttpRouteValueDictionary dataTokens) { }
    public System.Collections.Generic.IDictionary<System.String, System.Object> Constraints { get { return default(System.Collections.Generic.IDictionary<System.String, System.Object>); } }
    public System.Collections.Generic.IDictionary<System.String, System.Object> DataTokens { get { return default(System.Collections.Generic.IDictionary<System.String, System.Object>); } }
    public System.Collections.Generic.IDictionary<System.String, System.Object> Defaults { get { return default(System.Collections.Generic.IDictionary<System.String, System.Object>); } }
    public string RouteTemplate { get { return default(string); } }
    public virtual System.Web.Http.Routing.IHttpRouteData GetRouteData(string virtualPathRoot, System.Net.Http.HttpRequestMessage request) { return default(System.Web.Http.Routing.IHttpRouteData); }
    public virtual System.Web.Http.Routing.IHttpVirtualPathData GetVirtualPath(System.Web.Http.Controllers.HttpControllerContext controllerContext, System.Collections.Generic.IDictionary<System.String, System.Object> values) { return default(System.Web.Http.Routing.IHttpVirtualPathData); }
    protected virtual bool ProcessConstraint(System.Net.Http.HttpRequestMessage request, object constraint, string parameterName, System.Web.Http.Routing.HttpRouteValueDictionary values, System.Web.Http.Routing.HttpRouteDirection routeDirection) { return default(bool); }
  }
  public partial class HttpRouteData : System.Web.Http.Routing.IHttpRouteData {
    public HttpRouteData(System.Web.Http.Routing.IHttpRoute route) { }
    public HttpRouteData(System.Web.Http.Routing.IHttpRoute route, System.Web.Http.Routing.HttpRouteValueDictionary values) { }
    public System.Web.Http.Routing.IHttpRoute Route { get { return default(System.Web.Http.Routing.IHttpRoute); } }
    public System.Collections.Generic.IDictionary<System.String, System.Object> Values { get { return default(System.Collections.Generic.IDictionary<System.String, System.Object>); } }
  }
  public enum HttpRouteDirection {
    UriGeneration = 1,
    UriResolution = 0,
  }
  public partial class HttpRouteValueDictionary : System.Collections.Generic.Dictionary<System.String, System.Object> {
    public HttpRouteValueDictionary() { }
    public HttpRouteValueDictionary(System.Collections.Generic.IDictionary<System.String, System.Object> dictionary) { }
    public HttpRouteValueDictionary(object values) { }
  }
  public partial class HttpVirtualPathData : System.Web.Http.Routing.IHttpVirtualPathData {
    public HttpVirtualPathData(System.Web.Http.Routing.IHttpRoute route, string virtualPath) { }
    public System.Web.Http.Routing.IHttpRoute Route { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Http.Routing.IHttpRoute); } }
    public string VirtualPath { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
  }
  public partial interface IHttpRoute {
    System.Collections.Generic.IDictionary<System.String, System.Object> Constraints { get; }
    System.Collections.Generic.IDictionary<System.String, System.Object> DataTokens { get; }
    System.Collections.Generic.IDictionary<System.String, System.Object> Defaults { get; }
    string RouteTemplate { get; }
    System.Web.Http.Routing.IHttpRouteData GetRouteData(string virtualPathRoot, System.Net.Http.HttpRequestMessage request);
    System.Web.Http.Routing.IHttpVirtualPathData GetVirtualPath(System.Web.Http.Controllers.HttpControllerContext controllerContext, System.Collections.Generic.IDictionary<System.String, System.Object> values);
  }
  public partial interface IHttpRouteConstraint {
    bool Match(System.Net.Http.HttpRequestMessage request, System.Web.Http.Routing.IHttpRoute route, string parameterName, System.Collections.Generic.IDictionary<System.String, System.Object> values, System.Web.Http.Routing.HttpRouteDirection routeDirection);
  }
  public partial interface IHttpRouteData {
    System.Web.Http.Routing.IHttpRoute Route { get; }
    System.Collections.Generic.IDictionary<System.String, System.Object> Values { get; }
  }
  public partial interface IHttpVirtualPathData {
    System.Web.Http.Routing.IHttpRoute Route { get; }
    string VirtualPath { get; }
  }
  public partial class UrlHelper {
    public UrlHelper(System.Web.Http.Controllers.HttpControllerContext controllerContext) { }
    public System.Web.Http.Controllers.HttpControllerContext ControllerContext { get { return default(System.Web.Http.Controllers.HttpControllerContext); } set { } }
    public string Link(string routeName, System.Collections.Generic.IDictionary<System.String, System.Object> routeValues) { return default(string); }
    public string Link(string routeName, object routeValues) { return default(string); }
    public string Route(string routeName, System.Collections.Generic.IDictionary<System.String, System.Object> routeValues) { return default(string); }
    public string Route(string routeName, object routeValues) { return default(string); }
  }
}
namespace System.Web.Http.Services {
  public partial class DefaultServices : System.IDisposable {
    protected DefaultServices() { }
    public DefaultServices(System.Web.Http.HttpConfiguration configuration) { }
    public System.Collections.Generic.ICollection<System.Type> ServiceTypes { get { return default(System.Collections.Generic.ICollection<System.Type>); } }
    public void Add(System.Type serviceType, object service) { }
    public void AddRange(System.Type serviceType, System.Collections.Generic.IEnumerable<System.Object> services) { }
    public void Clear(System.Type serviceType) { }
    public virtual void Dispose() { }
    public int FindIndex(System.Type serviceType, System.Predicate<System.Object> match) { return default(int); }
    public virtual object GetService(System.Type serviceType) { return default(object); }
    public virtual System.Collections.Generic.IEnumerable<System.Object> GetServices(System.Type serviceType) { return default(System.Collections.Generic.IEnumerable<System.Object>); }
    public void Insert(System.Type serviceType, int index, object service) { }
    public void InsertRange(System.Type serviceType, int index, System.Collections.Generic.IEnumerable<System.Object> services) { }
    public bool Remove(System.Type serviceType, object service) { return default(bool); }
    public int RemoveAll(System.Type serviceType, System.Predicate<System.Object> match) { return default(int); }
    public void RemoveAt(System.Type serviceType, int index) { }
    public void Replace(System.Type serviceType, object service) { }
    public void ReplaceRange(System.Type serviceType, System.Collections.Generic.IEnumerable<System.Object> services) { }
  }
}
namespace System.Web.Http.Tracing {
  public partial interface ITraceManager {
    void Initialize(System.Web.Http.HttpConfiguration configuration);
  }
  public partial interface ITraceWriter {
    bool IsEnabled(string category, System.Web.Http.Tracing.TraceLevel level);
    void Trace(System.Net.Http.HttpRequestMessage request, string category, System.Web.Http.Tracing.TraceLevel level, System.Action<System.Web.Http.Tracing.TraceRecord> traceAction);
  }
  public static partial class ITraceWriterExtensions {
    public static void Debug(this System.Web.Http.Tracing.ITraceWriter traceWriter, System.Net.Http.HttpRequestMessage request, string category, System.Exception exception) { }
    public static void Debug(this System.Web.Http.Tracing.ITraceWriter traceWriter, System.Net.Http.HttpRequestMessage request, string category, System.Exception exception, string messageFormat, params System.Object[] messageArguments) { }
    public static void Debug(this System.Web.Http.Tracing.ITraceWriter traceWriter, System.Net.Http.HttpRequestMessage request, string category, string messageFormat, params System.Object[] messageArguments) { }
    public static void Error(this System.Web.Http.Tracing.ITraceWriter traceWriter, System.Net.Http.HttpRequestMessage request, string category, System.Exception exception) { }
    public static void Error(this System.Web.Http.Tracing.ITraceWriter traceWriter, System.Net.Http.HttpRequestMessage request, string category, System.Exception exception, string messageFormat, params System.Object[] messageArguments) { }
    public static void Error(this System.Web.Http.Tracing.ITraceWriter traceWriter, System.Net.Http.HttpRequestMessage request, string category, string messageFormat, params System.Object[] messageArguments) { }
    public static void Fatal(this System.Web.Http.Tracing.ITraceWriter traceWriter, System.Net.Http.HttpRequestMessage request, string category, System.Exception exception) { }
    public static void Fatal(this System.Web.Http.Tracing.ITraceWriter traceWriter, System.Net.Http.HttpRequestMessage request, string category, System.Exception exception, string messageFormat, params System.Object[] messageArguments) { }
    public static void Fatal(this System.Web.Http.Tracing.ITraceWriter traceWriter, System.Net.Http.HttpRequestMessage request, string category, string messageFormat, params System.Object[] messageArguments) { }
    public static void Info(this System.Web.Http.Tracing.ITraceWriter traceWriter, System.Net.Http.HttpRequestMessage request, string category, System.Exception exception) { }
    public static void Info(this System.Web.Http.Tracing.ITraceWriter traceWriter, System.Net.Http.HttpRequestMessage request, string category, System.Exception exception, string messageFormat, params System.Object[] messageArguments) { }
    public static void Info(this System.Web.Http.Tracing.ITraceWriter traceWriter, System.Net.Http.HttpRequestMessage request, string category, string messageFormat, params System.Object[] messageArguments) { }
    public static void Trace(this System.Web.Http.Tracing.ITraceWriter traceWriter, System.Net.Http.HttpRequestMessage request, string category, System.Web.Http.Tracing.TraceLevel level, System.Exception exception) { }
    public static void Trace(this System.Web.Http.Tracing.ITraceWriter traceWriter, System.Net.Http.HttpRequestMessage request, string category, System.Web.Http.Tracing.TraceLevel level, System.Exception exception, string messageFormat, params System.Object[] messageArguments) { }
    public static void Trace(this System.Web.Http.Tracing.ITraceWriter traceWriter, System.Net.Http.HttpRequestMessage request, string category, System.Web.Http.Tracing.TraceLevel level, string messageFormat, params System.Object[] messageArguments) { }
    public static void TraceBeginEnd(this System.Web.Http.Tracing.ITraceWriter traceWriter, System.Net.Http.HttpRequestMessage request, string category, System.Web.Http.Tracing.TraceLevel level, string operatorName, string operationName, System.Action<System.Web.Http.Tracing.TraceRecord> beginTrace, System.Action execute, System.Action<System.Web.Http.Tracing.TraceRecord> endTrace, System.Action<System.Web.Http.Tracing.TraceRecord> errorTrace) { }
    public static System.Threading.Tasks.Task TraceBeginEndAsync(this System.Web.Http.Tracing.ITraceWriter traceWriter, System.Net.Http.HttpRequestMessage request, string category, System.Web.Http.Tracing.TraceLevel level, string operatorName, string operationName, System.Action<System.Web.Http.Tracing.TraceRecord> beginTrace, System.Func<System.Threading.Tasks.Task> execute, System.Action<System.Web.Http.Tracing.TraceRecord> endTrace, System.Action<System.Web.Http.Tracing.TraceRecord> errorTrace) { return default(System.Threading.Tasks.Task); }
    public static System.Threading.Tasks.Task<TResult> TraceBeginEndAsync<TResult>(this System.Web.Http.Tracing.ITraceWriter traceWriter, System.Net.Http.HttpRequestMessage request, string category, System.Web.Http.Tracing.TraceLevel level, string operatorName, string operationName, System.Action<System.Web.Http.Tracing.TraceRecord> beginTrace, System.Func<System.Threading.Tasks.Task<TResult>> execute, System.Action<System.Web.Http.Tracing.TraceRecord, TResult> endTrace, System.Action<System.Web.Http.Tracing.TraceRecord> errorTrace) { return default(System.Threading.Tasks.Task<TResult>); }
    public static void Warn(this System.Web.Http.Tracing.ITraceWriter traceWriter, System.Net.Http.HttpRequestMessage request, string category, System.Exception exception) { }
    public static void Warn(this System.Web.Http.Tracing.ITraceWriter traceWriter, System.Net.Http.HttpRequestMessage request, string category, System.Exception exception, string messageFormat, params System.Object[] messageArguments) { }
    public static void Warn(this System.Web.Http.Tracing.ITraceWriter traceWriter, System.Net.Http.HttpRequestMessage request, string category, string messageFormat, params System.Object[] messageArguments) { }
  }
  public static partial class TraceCategories {
    public static readonly string ActionCategory;
    public static readonly string ControllersCategory;
    public static readonly string FiltersCategory;
    public static readonly string FormattingCategory;
    public static readonly string MessageHandlersCategory;
    public static readonly string ModelBindingCategory;
    public static readonly string RequestCategory;
    public static readonly string RoutingCategory;
  }
  public enum TraceKind {
    Begin = 1,
    End = 2,
    Trace = 0,
  }
  public enum TraceLevel {
    Debug = 1,
    Error = 4,
    Fatal = 5,
    Info = 2,
    Off = 0,
    Warn = 3,
  }
  public partial class TraceRecord {
    public TraceRecord(System.Net.Http.HttpRequestMessage request, string category, System.Web.Http.Tracing.TraceLevel level) { }
    public string Category { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Exception Exception { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Exception); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Web.Http.Tracing.TraceKind Kind { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Http.Tracing.TraceKind); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Web.Http.Tracing.TraceLevel Level { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Http.Tracing.TraceLevel); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Message { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Operation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Operator { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.Generic.Dictionary<System.Object, System.Object> Properties { get { return default(System.Collections.Generic.Dictionary<System.Object, System.Object>); } }
    public System.Net.Http.HttpRequestMessage Request { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Net.Http.HttpRequestMessage); } }
    public System.Guid RequestId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Guid); } }
    public System.Net.HttpStatusCode Status { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Net.HttpStatusCode); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.DateTime Timestamp { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.DateTime); } }
  }
}
namespace System.Web.Http.Validation {
  public partial class DefaultBodyModelValidator : System.Web.Http.Validation.IBodyModelValidator {
    public DefaultBodyModelValidator() { }
    public bool Validate(object model, System.Type type, System.Web.Http.Metadata.ModelMetadataProvider metadataProvider, System.Web.Http.Controllers.HttpActionContext actionContext, string keyPrefix) { return default(bool); }
  }
  public partial interface IBodyModelValidator {
    bool Validate(object model, System.Type type, System.Web.Http.Metadata.ModelMetadataProvider metadataProvider, System.Web.Http.Controllers.HttpActionContext actionContext, string keyPrefix);
  }
  public partial class ModelStateFormatterLogger : System.Net.Http.Formatting.IFormatterLogger {
    public ModelStateFormatterLogger(System.Web.Http.ModelBinding.ModelStateDictionary modelState, string prefix) { }
    public void LogError(string errorPath, string errorMessage) { }
  }
  public sealed partial class ModelValidatedEventArgs : System.EventArgs {
    public ModelValidatedEventArgs(System.Web.Http.Controllers.HttpActionContext actionContext, System.Web.Http.Validation.ModelValidationNode parentNode) { }
    public System.Web.Http.Controllers.HttpActionContext ActionContext { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Http.Controllers.HttpActionContext); } }
    public System.Web.Http.Validation.ModelValidationNode ParentNode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Http.Validation.ModelValidationNode); } }
  }
  public sealed partial class ModelValidatingEventArgs : System.ComponentModel.CancelEventArgs {
    public ModelValidatingEventArgs(System.Web.Http.Controllers.HttpActionContext actionContext, System.Web.Http.Validation.ModelValidationNode parentNode) { }
    public System.Web.Http.Controllers.HttpActionContext ActionContext { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Http.Controllers.HttpActionContext); } }
    public System.Web.Http.Validation.ModelValidationNode ParentNode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Http.Validation.ModelValidationNode); } }
  }
  public sealed partial class ModelValidationNode {
    public ModelValidationNode(System.Web.Http.Metadata.ModelMetadata modelMetadata, string modelStateKey) { }
    public ModelValidationNode(System.Web.Http.Metadata.ModelMetadata modelMetadata, string modelStateKey, System.Collections.Generic.IEnumerable<System.Web.Http.Validation.ModelValidationNode> childNodes) { }
    public System.Collections.Generic.ICollection<System.Web.Http.Validation.ModelValidationNode> ChildNodes { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.ICollection<System.Web.Http.Validation.ModelValidationNode>); } }
    public System.Web.Http.Metadata.ModelMetadata ModelMetadata { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Http.Metadata.ModelMetadata); } }
    public string ModelStateKey { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public bool SuppressValidation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool ValidateAllProperties { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public event System.EventHandler<System.Web.Http.Validation.ModelValidatedEventArgs> Validated { add { } remove { } }
    public event System.EventHandler<System.Web.Http.Validation.ModelValidatingEventArgs> Validating { add { } remove { } }
    public void CombineWith(System.Web.Http.Validation.ModelValidationNode otherNode) { }
    public void Validate(System.Web.Http.Controllers.HttpActionContext actionContext) { }
    public void Validate(System.Web.Http.Controllers.HttpActionContext actionContext, System.Web.Http.Validation.ModelValidationNode parentNode) { }
  }
  public sealed partial class ModelValidationRequiredMemberSelector : System.Net.Http.Formatting.IRequiredMemberSelector {
    public ModelValidationRequiredMemberSelector(System.Web.Http.Metadata.ModelMetadataProvider metadataProvider, System.Collections.Generic.IEnumerable<System.Web.Http.Validation.ModelValidatorProvider> validatorProviders) { }
    public bool IsRequiredMember(System.Reflection.MemberInfo member) { return default(bool); }
  }
  public partial class ModelValidationResult {
    public ModelValidationResult() { }
    public string MemberName { get { return default(string); } set { } }
    public string Message { get { return default(string); } set { } }
  }
  public abstract partial class ModelValidator {
    protected ModelValidator(System.Collections.Generic.IEnumerable<System.Web.Http.Validation.ModelValidatorProvider> validatorProviders) { }
    public virtual bool IsRequired { get { return default(bool); } }
    protected internal System.Collections.Generic.IEnumerable<System.Web.Http.Validation.ModelValidatorProvider> ValidatorProviders { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IEnumerable<System.Web.Http.Validation.ModelValidatorProvider>); } }
    public static System.Web.Http.Validation.ModelValidator GetModelValidator(System.Collections.Generic.IEnumerable<System.Web.Http.Validation.ModelValidatorProvider> validatorProviders) { return default(System.Web.Http.Validation.ModelValidator); }
    public abstract System.Collections.Generic.IEnumerable<System.Web.Http.Validation.ModelValidationResult> Validate(System.Web.Http.Metadata.ModelMetadata metadata, object container);
  }
  public abstract partial class ModelValidatorProvider {
    protected ModelValidatorProvider() { }
    public abstract System.Collections.Generic.IEnumerable<System.Web.Http.Validation.ModelValidator> GetValidators(System.Web.Http.Metadata.ModelMetadata metadata, System.Collections.Generic.IEnumerable<System.Web.Http.Validation.ModelValidatorProvider> validatorProviders);
  }
}
namespace System.Web.Http.Validation.Providers {
  public abstract partial class AssociatedValidatorProvider : System.Web.Http.Validation.ModelValidatorProvider {
    protected AssociatedValidatorProvider() { }
    protected virtual System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Type type) { return default(System.ComponentModel.ICustomTypeDescriptor); }
    public sealed override System.Collections.Generic.IEnumerable<System.Web.Http.Validation.ModelValidator> GetValidators(System.Web.Http.Metadata.ModelMetadata metadata, System.Collections.Generic.IEnumerable<System.Web.Http.Validation.ModelValidatorProvider> validatorProviders) { return default(System.Collections.Generic.IEnumerable<System.Web.Http.Validation.ModelValidator>); }
    protected abstract System.Collections.Generic.IEnumerable<System.Web.Http.Validation.ModelValidator> GetValidators(System.Web.Http.Metadata.ModelMetadata metadata, System.Collections.Generic.IEnumerable<System.Web.Http.Validation.ModelValidatorProvider> validatorProviders, System.Collections.Generic.IEnumerable<System.Attribute> attributes);
  }
  public delegate System.Web.Http.Validation.ModelValidator DataAnnotationsModelValidationFactory(System.Collections.Generic.IEnumerable<System.Web.Http.Validation.ModelValidatorProvider> validatorProviders, System.ComponentModel.DataAnnotations.ValidationAttribute attribute);
  [System.Security.SecuritySafeCriticalAttribute]
  public partial class DataAnnotationsModelValidatorProvider : System.Web.Http.Validation.Providers.AssociatedValidatorProvider {
    public DataAnnotationsModelValidatorProvider() { }
    [System.Security.SecuritySafeCriticalAttribute]
    protected override System.Collections.Generic.IEnumerable<System.Web.Http.Validation.ModelValidator> GetValidators(System.Web.Http.Metadata.ModelMetadata metadata, System.Collections.Generic.IEnumerable<System.Web.Http.Validation.ModelValidatorProvider> validatorProviders, System.Collections.Generic.IEnumerable<System.Attribute> attributes) { return default(System.Collections.Generic.IEnumerable<System.Web.Http.Validation.ModelValidator>); }
    public void RegisterAdapter(System.Type attributeType, System.Type adapterType) { }
    public void RegisterAdapterFactory(System.Type attributeType, System.Web.Http.Validation.Providers.DataAnnotationsModelValidationFactory factory) { }
    public void RegisterDefaultAdapter(System.Type adapterType) { }
    public void RegisterDefaultAdapterFactory(System.Web.Http.Validation.Providers.DataAnnotationsModelValidationFactory factory) { }
    public void RegisterDefaultValidatableObjectAdapter(System.Type adapterType) { }
    public void RegisterDefaultValidatableObjectAdapterFactory(System.Web.Http.Validation.Providers.DataAnnotationsValidatableObjectAdapterFactory factory) { }
    public void RegisterValidatableObjectAdapter(System.Type modelType, System.Type adapterType) { }
    public void RegisterValidatableObjectAdapterFactory(System.Type modelType, System.Web.Http.Validation.Providers.DataAnnotationsValidatableObjectAdapterFactory factory) { }
  }
  public delegate System.Web.Http.Validation.ModelValidator DataAnnotationsValidatableObjectAdapterFactory(System.Collections.Generic.IEnumerable<System.Web.Http.Validation.ModelValidatorProvider> validatorProviders);
  public partial class DataMemberModelValidatorProvider : System.Web.Http.Validation.Providers.AssociatedValidatorProvider {
    public DataMemberModelValidatorProvider() { }
    protected override System.Collections.Generic.IEnumerable<System.Web.Http.Validation.ModelValidator> GetValidators(System.Web.Http.Metadata.ModelMetadata metadata, System.Collections.Generic.IEnumerable<System.Web.Http.Validation.ModelValidatorProvider> validatorProviders, System.Collections.Generic.IEnumerable<System.Attribute> attributes) { return default(System.Collections.Generic.IEnumerable<System.Web.Http.Validation.ModelValidator>); }
  }
  public partial class RequiredMemberModelValidatorProvider : System.Web.Http.Validation.ModelValidatorProvider {
    public RequiredMemberModelValidatorProvider(System.Net.Http.Formatting.IRequiredMemberSelector requiredMemberSelector) { }
    public override System.Collections.Generic.IEnumerable<System.Web.Http.Validation.ModelValidator> GetValidators(System.Web.Http.Metadata.ModelMetadata metadata, System.Collections.Generic.IEnumerable<System.Web.Http.Validation.ModelValidatorProvider> validatorProviders) { return default(System.Collections.Generic.IEnumerable<System.Web.Http.Validation.ModelValidator>); }
  }
}
namespace System.Web.Http.Validation.Validators {
  [System.Security.SecuritySafeCriticalAttribute]
  public partial class DataAnnotationsModelValidator : System.Web.Http.Validation.ModelValidator {
    public DataAnnotationsModelValidator(System.Collections.Generic.IEnumerable<System.Web.Http.Validation.ModelValidatorProvider> validatorProviders, System.ComponentModel.DataAnnotations.ValidationAttribute attribute) : base (default(System.Collections.Generic.IEnumerable<System.Web.Http.Validation.ModelValidatorProvider>)) { }
    protected internal System.ComponentModel.DataAnnotations.ValidationAttribute Attribute { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ComponentModel.DataAnnotations.ValidationAttribute); } }
    public override bool IsRequired { [System.Security.SecuritySafeCriticalAttribute]get { return default(bool); } }
    [System.Security.SecuritySafeCriticalAttribute]
    public override System.Collections.Generic.IEnumerable<System.Web.Http.Validation.ModelValidationResult> Validate(System.Web.Http.Metadata.ModelMetadata metadata, object container) { return default(System.Collections.Generic.IEnumerable<System.Web.Http.Validation.ModelValidationResult>); }
  }
  public partial class RequiredMemberModelValidator : System.Web.Http.Validation.ModelValidator {
    public RequiredMemberModelValidator(System.Collections.Generic.IEnumerable<System.Web.Http.Validation.ModelValidatorProvider> validatorProviders) : base (default(System.Collections.Generic.IEnumerable<System.Web.Http.Validation.ModelValidatorProvider>)) { }
    public override bool IsRequired { get { return default(bool); } }
    public override System.Collections.Generic.IEnumerable<System.Web.Http.Validation.ModelValidationResult> Validate(System.Web.Http.Metadata.ModelMetadata metadata, object container) { return default(System.Collections.Generic.IEnumerable<System.Web.Http.Validation.ModelValidationResult>); }
  }
  public partial class ValidatableObjectAdapter : System.Web.Http.Validation.ModelValidator {
    public ValidatableObjectAdapter(System.Collections.Generic.IEnumerable<System.Web.Http.Validation.ModelValidatorProvider> validatorProviders) : base (default(System.Collections.Generic.IEnumerable<System.Web.Http.Validation.ModelValidatorProvider>)) { }
    public override System.Collections.Generic.IEnumerable<System.Web.Http.Validation.ModelValidationResult> Validate(System.Web.Http.Metadata.ModelMetadata metadata, object container) { return default(System.Collections.Generic.IEnumerable<System.Web.Http.Validation.ModelValidationResult>); }
  }
}
namespace System.Web.Http.ValueProviders {
  public partial interface IEnumerableValueProvider : System.Web.Http.ValueProviders.IValueProvider {
    System.Collections.Generic.IDictionary<System.String, System.String> GetKeysFromPrefix(string prefix);
  }
  public partial interface IUriValueProviderFactory {
  }
  public partial interface IValueProvider {
    bool ContainsPrefix(string prefix);
    System.Web.Http.ValueProviders.ValueProviderResult GetValue(string key);
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(2116), Inherited=true, AllowMultiple=false)]
  public sealed partial class ValueProviderAttribute : System.Web.Http.ModelBinding.ModelBinderAttribute {
    public ValueProviderAttribute(System.Type valueProviderFactory) { }
    public ValueProviderAttribute(params System.Type[] valueProviderFactories) { }
    public System.Collections.Generic.IEnumerable<System.Type> ValueProviderFactoryTypes { get { return default(System.Collections.Generic.IEnumerable<System.Type>); } }
    public override System.Collections.Generic.IEnumerable<System.Web.Http.ValueProviders.ValueProviderFactory> GetValueProviderFactories(System.Web.Http.HttpConfiguration configuration) { return default(System.Collections.Generic.IEnumerable<System.Web.Http.ValueProviders.ValueProviderFactory>); }
  }
  public abstract partial class ValueProviderFactory {
    protected ValueProviderFactory() { }
    public abstract System.Web.Http.ValueProviders.IValueProvider GetValueProvider(System.Web.Http.Controllers.HttpActionContext actionContext);
  }
  public partial class ValueProviderResult {
    protected ValueProviderResult() { }
    public ValueProviderResult(object rawValue, string attemptedValue, System.Globalization.CultureInfo culture) { }
    public string AttemptedValue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public System.Globalization.CultureInfo Culture { get { return default(System.Globalization.CultureInfo); } protected set { } }
    public object RawValue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public object ConvertTo(System.Type type) { return default(object); }
    public virtual object ConvertTo(System.Type type, System.Globalization.CultureInfo culture) { return default(object); }
  }
}
namespace System.Web.Http.ValueProviders.Providers {
  public partial class CompositeValueProvider : System.Collections.ObjectModel.Collection<System.Web.Http.ValueProviders.IValueProvider>, System.Web.Http.ValueProviders.IEnumerableValueProvider, System.Web.Http.ValueProviders.IValueProvider {
    public CompositeValueProvider() { }
    public CompositeValueProvider(System.Collections.Generic.IList<System.Web.Http.ValueProviders.IValueProvider> list) { }
    public virtual bool ContainsPrefix(string prefix) { return default(bool); }
    public virtual System.Collections.Generic.IDictionary<System.String, System.String> GetKeysFromPrefix(string prefix) { return default(System.Collections.Generic.IDictionary<System.String, System.String>); }
    public virtual System.Web.Http.ValueProviders.ValueProviderResult GetValue(string key) { return default(System.Web.Http.ValueProviders.ValueProviderResult); }
    protected override void InsertItem(int index, System.Web.Http.ValueProviders.IValueProvider item) { }
    protected override void SetItem(int index, System.Web.Http.ValueProviders.IValueProvider item) { }
  }
  public partial class CompositeValueProviderFactory : System.Web.Http.ValueProviders.ValueProviderFactory {
    public CompositeValueProviderFactory(System.Collections.Generic.IEnumerable<System.Web.Http.ValueProviders.ValueProviderFactory> factories) { }
    public override System.Web.Http.ValueProviders.IValueProvider GetValueProvider(System.Web.Http.Controllers.HttpActionContext actionContext) { return default(System.Web.Http.ValueProviders.IValueProvider); }
  }
  public partial class NameValueCollectionValueProvider : System.Web.Http.ValueProviders.IEnumerableValueProvider, System.Web.Http.ValueProviders.IValueProvider {
    public NameValueCollectionValueProvider(System.Collections.Specialized.NameValueCollection values, System.Globalization.CultureInfo culture) { }
    public NameValueCollectionValueProvider(System.Func<System.Collections.Specialized.NameValueCollection> valuesFactory, System.Globalization.CultureInfo culture) { }
    public virtual bool ContainsPrefix(string prefix) { return default(bool); }
    public virtual System.Collections.Generic.IDictionary<System.String, System.String> GetKeysFromPrefix(string prefix) { return default(System.Collections.Generic.IDictionary<System.String, System.String>); }
    public virtual System.Web.Http.ValueProviders.ValueProviderResult GetValue(string key) { return default(System.Web.Http.ValueProviders.ValueProviderResult); }
  }
  public partial class QueryStringValueProvider : System.Web.Http.ValueProviders.Providers.NameValueCollectionValueProvider {
    public QueryStringValueProvider(System.Web.Http.Controllers.HttpActionContext actionContext, System.Globalization.CultureInfo culture) : base (default(System.Collections.Specialized.NameValueCollection), default(System.Globalization.CultureInfo)) { }
  }
  public partial class QueryStringValueProviderFactory : System.Web.Http.ValueProviders.ValueProviderFactory, System.Web.Http.ValueProviders.IUriValueProviderFactory {
    public QueryStringValueProviderFactory() { }
    public override System.Web.Http.ValueProviders.IValueProvider GetValueProvider(System.Web.Http.Controllers.HttpActionContext actionContext) { return default(System.Web.Http.ValueProviders.IValueProvider); }
  }
  public partial class RouteDataValueProvider : System.Web.Http.ValueProviders.Providers.NameValueCollectionValueProvider {
    public RouteDataValueProvider(System.Web.Http.Controllers.HttpActionContext actionContext, System.Globalization.CultureInfo culture) : base (default(System.Collections.Specialized.NameValueCollection), default(System.Globalization.CultureInfo)) { }
  }
  public partial class RouteDataValueProviderFactory : System.Web.Http.ValueProviders.ValueProviderFactory, System.Web.Http.ValueProviders.IUriValueProviderFactory {
    public RouteDataValueProviderFactory() { }
    public override System.Web.Http.ValueProviders.IValueProvider GetValueProvider(System.Web.Http.Controllers.HttpActionContext actionContext) { return default(System.Web.Http.ValueProviders.IValueProvider); }
  }
}
