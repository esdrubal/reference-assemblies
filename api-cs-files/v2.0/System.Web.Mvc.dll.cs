namespace System.Web.Mvc {
  [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=false, Inherited=true)]
  public sealed partial class AcceptVerbsAttribute : System.Web.Mvc.ActionMethodSelectorAttribute {
    public AcceptVerbsAttribute(params System.String[] verbs) { }
    public AcceptVerbsAttribute(System.Web.Mvc.HttpVerbs verbs) { }
    public System.Collections.Generic.ICollection<System.String> Verbs { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.ICollection<System.String>); } }
    public override bool IsValidForRequest(System.Web.Mvc.ControllerContext controllerContext, System.Reflection.MethodInfo methodInfo) { return default(bool); }
  }
  public abstract partial class ActionDescriptor : System.Reflection.ICustomAttributeProvider {
    protected ActionDescriptor() { }
    public abstract string ActionName { get; }
    public abstract System.Web.Mvc.ControllerDescriptor ControllerDescriptor { get; }
    public abstract object Execute(System.Web.Mvc.ControllerContext controllerContext, System.Collections.Generic.IDictionary<System.String, System.Object> parameters);
    public virtual System.Object[] GetCustomAttributes(bool inherit) { return default(System.Object[]); }
    public virtual System.Object[] GetCustomAttributes(System.Type attributeType, bool inherit) { return default(System.Object[]); }
    public virtual System.Web.Mvc.FilterInfo GetFilters() { return default(System.Web.Mvc.FilterInfo); }
    public abstract System.Web.Mvc.ParameterDescriptor[] GetParameters();
    public virtual System.Collections.Generic.ICollection<System.Web.Mvc.ActionSelector> GetSelectors() { return default(System.Collections.Generic.ICollection<System.Web.Mvc.ActionSelector>); }
    public virtual bool IsDefined(System.Type attributeType, bool inherit) { return default(bool); }
  }
  public partial class ActionExecutedContext : System.Web.Mvc.ControllerContext {
    public ActionExecutedContext() { }
    public ActionExecutedContext(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ActionDescriptor actionDescriptor, bool canceled, System.Exception exception) { }
    public virtual System.Web.Mvc.ActionDescriptor ActionDescriptor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Mvc.ActionDescriptor); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public virtual bool Canceled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public virtual System.Exception Exception { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Exception); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool ExceptionHandled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Web.Mvc.ActionResult Result { get { return default(System.Web.Mvc.ActionResult); } set { } }
  }
  public partial class ActionExecutingContext : System.Web.Mvc.ControllerContext {
    public ActionExecutingContext() { }
    public ActionExecutingContext(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ActionDescriptor actionDescriptor, System.Collections.Generic.IDictionary<System.String, System.Object> actionParameters) { }
    public virtual System.Web.Mvc.ActionDescriptor ActionDescriptor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Mvc.ActionDescriptor); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public virtual System.Collections.Generic.IDictionary<System.String, System.Object> ActionParameters { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IDictionary<System.String, System.Object>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Web.Mvc.ActionResult Result { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Mvc.ActionResult); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(68), Inherited=true, AllowMultiple=false)]
  public abstract partial class ActionFilterAttribute : System.Web.Mvc.FilterAttribute, System.Web.Mvc.IActionFilter, System.Web.Mvc.IResultFilter {
    protected ActionFilterAttribute() { }
    public virtual void OnActionExecuted(System.Web.Mvc.ActionExecutedContext filterContext) { }
    public virtual void OnActionExecuting(System.Web.Mvc.ActionExecutingContext filterContext) { }
    public virtual void OnResultExecuted(System.Web.Mvc.ResultExecutedContext filterContext) { }
    public virtual void OnResultExecuting(System.Web.Mvc.ResultExecutingContext filterContext) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=false, Inherited=true)]
  public abstract partial class ActionMethodSelectorAttribute : System.Attribute {
    protected ActionMethodSelectorAttribute() { }
    public abstract bool IsValidForRequest(System.Web.Mvc.ControllerContext controllerContext, System.Reflection.MethodInfo methodInfo);
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=false, Inherited=true)]
  public sealed partial class ActionNameAttribute : System.Web.Mvc.ActionNameSelectorAttribute {
    public ActionNameAttribute(string name) { }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public override bool IsValidName(System.Web.Mvc.ControllerContext controllerContext, string actionName, System.Reflection.MethodInfo methodInfo) { return default(bool); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=false, Inherited=true)]
  public abstract partial class ActionNameSelectorAttribute : System.Attribute {
    protected ActionNameSelectorAttribute() { }
    public abstract bool IsValidName(System.Web.Mvc.ControllerContext controllerContext, string actionName, System.Reflection.MethodInfo methodInfo);
  }
  public abstract partial class ActionResult {
    protected ActionResult() { }
    public abstract void ExecuteResult(System.Web.Mvc.ControllerContext context);
  }
  public delegate bool ActionSelector(System.Web.Mvc.ControllerContext controllerContext);
  public partial class AjaxHelper {
    public AjaxHelper(System.Web.Mvc.ViewContext viewContext, System.Web.Mvc.IViewDataContainer viewDataContainer) { }
    public AjaxHelper(System.Web.Mvc.ViewContext viewContext, System.Web.Mvc.IViewDataContainer viewDataContainer, System.Web.Routing.RouteCollection routeCollection) { }
    public static string GlobalizationScriptPath { get { return default(string); } set { } }
    public System.Web.Routing.RouteCollection RouteCollection { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Routing.RouteCollection); } }
    public System.Web.Mvc.ViewContext ViewContext { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Mvc.ViewContext); } }
    public System.Web.Mvc.ViewDataDictionary ViewData { get { return default(System.Web.Mvc.ViewDataDictionary); } }
    public System.Web.Mvc.IViewDataContainer ViewDataContainer { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Mvc.IViewDataContainer); } }
    public string JavaScriptStringEncode(string message) { return default(string); }
  }
  public partial class AjaxHelper<TModel> : System.Web.Mvc.AjaxHelper {
    public AjaxHelper(System.Web.Mvc.ViewContext viewContext, System.Web.Mvc.IViewDataContainer viewDataContainer) : base (default(System.Web.Mvc.ViewContext), default(System.Web.Mvc.IViewDataContainer)) { }
    public AjaxHelper(System.Web.Mvc.ViewContext viewContext, System.Web.Mvc.IViewDataContainer viewDataContainer, System.Web.Routing.RouteCollection routeCollection) : base (default(System.Web.Mvc.ViewContext), default(System.Web.Mvc.IViewDataContainer)) { }
    public new System.Web.Mvc.ViewDataDictionary<TModel> ViewData { get { return default(System.Web.Mvc.ViewDataDictionary<TModel>); } }
  }
  public static partial class AjaxRequestExtensions {
    public static bool IsAjaxRequest(this System.Web.HttpRequestBase request) { return default(bool); }
  }
  public abstract partial class AreaRegistration {
    protected AreaRegistration() { }
    public abstract string AreaName { get; }
    public static void RegisterAllAreas() { }
    public static void RegisterAllAreas(object state) { }
    public abstract void RegisterArea(System.Web.Mvc.AreaRegistrationContext context);
  }
  public partial class AreaRegistrationContext {
    public AreaRegistrationContext(string areaName, System.Web.Routing.RouteCollection routes) { }
    public AreaRegistrationContext(string areaName, System.Web.Routing.RouteCollection routes, object state) { }
    public string AreaName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public System.Collections.Generic.ICollection<System.String> Namespaces { get { return default(System.Collections.Generic.ICollection<System.String>); } }
    public System.Web.Routing.RouteCollection Routes { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Routing.RouteCollection); } }
    public object State { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } }
    public System.Web.Routing.Route MapRoute(string name, string url) { return default(System.Web.Routing.Route); }
    public System.Web.Routing.Route MapRoute(string name, string url, object defaults) { return default(System.Web.Routing.Route); }
    public System.Web.Routing.Route MapRoute(string name, string url, object defaults, object constraints) { return default(System.Web.Routing.Route); }
    public System.Web.Routing.Route MapRoute(string name, string url, object defaults, object constraints, System.String[] namespaces) { return default(System.Web.Routing.Route); }
    public System.Web.Routing.Route MapRoute(string name, string url, object defaults, System.String[] namespaces) { return default(System.Web.Routing.Route); }
    public System.Web.Routing.Route MapRoute(string name, string url, System.String[] namespaces) { return default(System.Web.Routing.Route); }
  }
  public abstract partial class AssociatedMetadataProvider : System.Web.Mvc.ModelMetadataProvider {
    protected AssociatedMetadataProvider() { }
    protected abstract System.Web.Mvc.ModelMetadata CreateMetadata(System.Collections.Generic.IEnumerable<System.Attribute> attributes, System.Type containerType, System.Func<System.Object> modelAccessor, System.Type modelType, string propertyName);
    protected virtual System.Collections.Generic.IEnumerable<System.Attribute> FilterAttributes(System.Type containerType, System.ComponentModel.PropertyDescriptor propertyDescriptor, System.Collections.Generic.IEnumerable<System.Attribute> attributes) { return default(System.Collections.Generic.IEnumerable<System.Attribute>); }
    public override System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelMetadata> GetMetadataForProperties(object container, System.Type containerType) { return default(System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelMetadata>); }
    protected virtual System.Web.Mvc.ModelMetadata GetMetadataForProperty(System.Func<System.Object> modelAccessor, System.Type containerType, System.ComponentModel.PropertyDescriptor propertyDescriptor) { return default(System.Web.Mvc.ModelMetadata); }
    public override System.Web.Mvc.ModelMetadata GetMetadataForProperty(System.Func<System.Object> modelAccessor, System.Type containerType, string propertyName) { return default(System.Web.Mvc.ModelMetadata); }
    public override System.Web.Mvc.ModelMetadata GetMetadataForType(System.Func<System.Object> modelAccessor, System.Type modelType) { return default(System.Web.Mvc.ModelMetadata); }
    protected virtual System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Type type) { return default(System.ComponentModel.ICustomTypeDescriptor); }
  }
  public abstract partial class AssociatedValidatorProvider : System.Web.Mvc.ModelValidatorProvider {
    protected AssociatedValidatorProvider() { }
    protected virtual System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Type type) { return default(System.ComponentModel.ICustomTypeDescriptor); }
    public sealed override System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelValidator> GetValidators(System.Web.Mvc.ModelMetadata metadata, System.Web.Mvc.ControllerContext context) { return default(System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelValidator>); }
    protected abstract System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelValidator> GetValidators(System.Web.Mvc.ModelMetadata metadata, System.Web.Mvc.ControllerContext context, System.Collections.Generic.IEnumerable<System.Attribute> attributes);
  }
  public abstract partial class AsyncController : System.Web.Mvc.Controller, System.Web.Mvc.Async.IAsyncController, System.Web.Mvc.Async.IAsyncManagerContainer, System.Web.Mvc.IController {
    protected AsyncController() { }
    public System.Web.Mvc.Async.AsyncManager AsyncManager { get { return default(System.Web.Mvc.Async.AsyncManager); } }
    protected virtual System.IAsyncResult BeginExecute(System.Web.Routing.RequestContext requestContext, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected virtual System.IAsyncResult BeginExecuteCore(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected override System.Web.Mvc.IActionInvoker CreateActionInvoker() { return default(System.Web.Mvc.IActionInvoker); }
    protected virtual void EndExecute(System.IAsyncResult asyncResult) { }
    protected virtual void EndExecuteCore(System.IAsyncResult asyncResult) { }
    System.IAsyncResult System.Web.Mvc.Async.IAsyncController.BeginExecute(System.Web.Routing.RequestContext requestContext, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    void System.Web.Mvc.Async.IAsyncController.EndExecute(System.IAsyncResult asyncResult) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(68), Inherited=true, AllowMultiple=false)]
  public partial class AsyncTimeoutAttribute : System.Web.Mvc.ActionFilterAttribute {
    public AsyncTimeoutAttribute(int duration) { }
    public int Duration { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    public override void OnActionExecuting(System.Web.Mvc.ActionExecutingContext filterContext) { }
  }
  public partial class AuthorizationContext : System.Web.Mvc.ControllerContext {
    public AuthorizationContext() { }
    [System.ObsoleteAttribute("The recommended alternative is the constructor AuthorizationContext(ControllerContext controllerContext, ActionDescriptor actionDescriptor).")]
    public AuthorizationContext(System.Web.Mvc.ControllerContext controllerContext) { }
    public AuthorizationContext(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ActionDescriptor actionDescriptor) { }
    public virtual System.Web.Mvc.ActionDescriptor ActionDescriptor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Mvc.ActionDescriptor); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Web.Mvc.ActionResult Result { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Mvc.ActionResult); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(68), Inherited=true, AllowMultiple=true)]
  public partial class AuthorizeAttribute : System.Web.Mvc.FilterAttribute, System.Web.Mvc.IAuthorizationFilter {
    public AuthorizeAttribute() { }
    public string Roles { get { return default(string); } set { } }
    public override object TypeId { get { return default(object); } }
    public string Users { get { return default(string); } set { } }
    protected virtual bool AuthorizeCore(System.Web.HttpContextBase httpContext) { return default(bool); }
    protected virtual void HandleUnauthorizedRequest(System.Web.Mvc.AuthorizationContext filterContext) { }
    public virtual void OnAuthorization(System.Web.Mvc.AuthorizationContext filterContext) { }
    protected virtual System.Web.HttpValidationStatus OnCacheAuthorization(System.Web.HttpContextBase httpContext) { return default(System.Web.HttpValidationStatus); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(2052), AllowMultiple=false, Inherited=true)]
  public sealed partial class BindAttribute : System.Attribute {
    public BindAttribute() { }
    public string Exclude { get { return default(string); } set { } }
    public string Include { get { return default(string); } set { } }
    public string Prefix { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool IsPropertyAllowed(string propertyName) { return default(bool); }
  }
  public partial class ByteArrayModelBinder : System.Web.Mvc.IModelBinder {
    public ByteArrayModelBinder() { }
    public virtual object BindModel(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ModelBindingContext bindingContext) { return default(object); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(68), AllowMultiple=false, Inherited=true)]
  public sealed partial class ChildActionOnlyAttribute : System.Web.Mvc.FilterAttribute, System.Web.Mvc.IAuthorizationFilter {
    public ChildActionOnlyAttribute() { }
    public void OnAuthorization(System.Web.Mvc.AuthorizationContext filterContext) { }
  }
  public partial class ClientDataTypeModelValidatorProvider : System.Web.Mvc.ModelValidatorProvider {
    public ClientDataTypeModelValidatorProvider() { }
    public override System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelValidator> GetValidators(System.Web.Mvc.ModelMetadata metadata, System.Web.Mvc.ControllerContext context) { return default(System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelValidator>); }
  }
  public partial class ContentResult : System.Web.Mvc.ActionResult {
    public ContentResult() { }
    public string Content { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Text.Encoding ContentEncoding { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Text.Encoding); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string ContentType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override void ExecuteResult(System.Web.Mvc.ControllerContext context) { }
  }
  public abstract partial class Controller : System.Web.Mvc.ControllerBase, System.IDisposable, System.Web.Mvc.IActionFilter, System.Web.Mvc.IAuthorizationFilter, System.Web.Mvc.IExceptionFilter, System.Web.Mvc.IResultFilter {
    protected Controller() { }
    public System.Web.Mvc.IActionInvoker ActionInvoker { get { return default(System.Web.Mvc.IActionInvoker); } set { } }
    protected internal System.Web.Mvc.ModelBinderDictionary Binders { get { return default(System.Web.Mvc.ModelBinderDictionary); } set { } }
    public System.Web.HttpContextBase HttpContext { get { return default(System.Web.HttpContextBase); } }
    public System.Web.Mvc.ModelStateDictionary ModelState { get { return default(System.Web.Mvc.ModelStateDictionary); } }
    public System.Web.HttpRequestBase Request { get { return default(System.Web.HttpRequestBase); } }
    public System.Web.HttpResponseBase Response { get { return default(System.Web.HttpResponseBase); } }
    public System.Web.Routing.RouteData RouteData { get { return default(System.Web.Routing.RouteData); } }
    public System.Web.HttpServerUtilityBase Server { get { return default(System.Web.HttpServerUtilityBase); } }
    public System.Web.HttpSessionStateBase Session { get { return default(System.Web.HttpSessionStateBase); } }
    public System.Web.Mvc.ITempDataProvider TempDataProvider { get { return default(System.Web.Mvc.ITempDataProvider); } set { } }
    public System.Web.Mvc.UrlHelper Url { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Mvc.UrlHelper); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Security.Principal.IPrincipal User { get { return default(System.Security.Principal.IPrincipal); } }
    protected internal System.Web.Mvc.ContentResult Content(string content) { return default(System.Web.Mvc.ContentResult); }
    protected internal System.Web.Mvc.ContentResult Content(string content, string contentType) { return default(System.Web.Mvc.ContentResult); }
    protected internal virtual System.Web.Mvc.ContentResult Content(string content, string contentType, System.Text.Encoding contentEncoding) { return default(System.Web.Mvc.ContentResult); }
    protected virtual System.Web.Mvc.IActionInvoker CreateActionInvoker() { return default(System.Web.Mvc.IActionInvoker); }
    protected virtual System.Web.Mvc.ITempDataProvider CreateTempDataProvider() { return default(System.Web.Mvc.ITempDataProvider); }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    protected override void ExecuteCore() { }
    protected internal System.Web.Mvc.FileContentResult File(System.Byte[] fileContents, string contentType) { return default(System.Web.Mvc.FileContentResult); }
    protected internal virtual System.Web.Mvc.FileContentResult File(System.Byte[] fileContents, string contentType, string fileDownloadName) { return default(System.Web.Mvc.FileContentResult); }
    protected internal System.Web.Mvc.FileStreamResult File(System.IO.Stream fileStream, string contentType) { return default(System.Web.Mvc.FileStreamResult); }
    protected internal virtual System.Web.Mvc.FileStreamResult File(System.IO.Stream fileStream, string contentType, string fileDownloadName) { return default(System.Web.Mvc.FileStreamResult); }
    protected internal System.Web.Mvc.FilePathResult File(string fileName, string contentType) { return default(System.Web.Mvc.FilePathResult); }
    protected internal virtual System.Web.Mvc.FilePathResult File(string fileName, string contentType, string fileDownloadName) { return default(System.Web.Mvc.FilePathResult); }
    protected virtual void HandleUnknownAction(string actionName) { }
    protected override void Initialize(System.Web.Routing.RequestContext requestContext) { }
    protected internal virtual System.Web.Mvc.JavaScriptResult JavaScript(string script) { return default(System.Web.Mvc.JavaScriptResult); }
    protected internal System.Web.Mvc.JsonResult Json(object data) { return default(System.Web.Mvc.JsonResult); }
    protected internal System.Web.Mvc.JsonResult Json(object data, string contentType) { return default(System.Web.Mvc.JsonResult); }
    protected internal virtual System.Web.Mvc.JsonResult Json(object data, string contentType, System.Text.Encoding contentEncoding) { return default(System.Web.Mvc.JsonResult); }
    protected internal virtual System.Web.Mvc.JsonResult Json(object data, string contentType, System.Text.Encoding contentEncoding, System.Web.Mvc.JsonRequestBehavior behavior) { return default(System.Web.Mvc.JsonResult); }
    protected internal System.Web.Mvc.JsonResult Json(object data, string contentType, System.Web.Mvc.JsonRequestBehavior behavior) { return default(System.Web.Mvc.JsonResult); }
    protected internal System.Web.Mvc.JsonResult Json(object data, System.Web.Mvc.JsonRequestBehavior behavior) { return default(System.Web.Mvc.JsonResult); }
    protected virtual void OnActionExecuted(System.Web.Mvc.ActionExecutedContext filterContext) { }
    protected virtual void OnActionExecuting(System.Web.Mvc.ActionExecutingContext filterContext) { }
    protected virtual void OnAuthorization(System.Web.Mvc.AuthorizationContext filterContext) { }
    protected virtual void OnException(System.Web.Mvc.ExceptionContext filterContext) { }
    protected virtual void OnResultExecuted(System.Web.Mvc.ResultExecutedContext filterContext) { }
    protected virtual void OnResultExecuting(System.Web.Mvc.ResultExecutingContext filterContext) { }
    protected internal System.Web.Mvc.PartialViewResult PartialView() { return default(System.Web.Mvc.PartialViewResult); }
    protected internal System.Web.Mvc.PartialViewResult PartialView(object model) { return default(System.Web.Mvc.PartialViewResult); }
    protected internal System.Web.Mvc.PartialViewResult PartialView(string viewName) { return default(System.Web.Mvc.PartialViewResult); }
    protected internal virtual System.Web.Mvc.PartialViewResult PartialView(string viewName, object model) { return default(System.Web.Mvc.PartialViewResult); }
    protected internal virtual System.Web.Mvc.RedirectResult Redirect(string url) { return default(System.Web.Mvc.RedirectResult); }
    protected internal System.Web.Mvc.RedirectToRouteResult RedirectToAction(string actionName) { return default(System.Web.Mvc.RedirectToRouteResult); }
    protected internal System.Web.Mvc.RedirectToRouteResult RedirectToAction(string actionName, object routeValues) { return default(System.Web.Mvc.RedirectToRouteResult); }
    protected internal System.Web.Mvc.RedirectToRouteResult RedirectToAction(string actionName, string controllerName) { return default(System.Web.Mvc.RedirectToRouteResult); }
    protected internal System.Web.Mvc.RedirectToRouteResult RedirectToAction(string actionName, string controllerName, object routeValues) { return default(System.Web.Mvc.RedirectToRouteResult); }
    protected internal virtual System.Web.Mvc.RedirectToRouteResult RedirectToAction(string actionName, string controllerName, System.Web.Routing.RouteValueDictionary routeValues) { return default(System.Web.Mvc.RedirectToRouteResult); }
    protected internal System.Web.Mvc.RedirectToRouteResult RedirectToAction(string actionName, System.Web.Routing.RouteValueDictionary routeValues) { return default(System.Web.Mvc.RedirectToRouteResult); }
    protected internal System.Web.Mvc.RedirectToRouteResult RedirectToRoute(object routeValues) { return default(System.Web.Mvc.RedirectToRouteResult); }
    protected internal System.Web.Mvc.RedirectToRouteResult RedirectToRoute(string routeName) { return default(System.Web.Mvc.RedirectToRouteResult); }
    protected internal System.Web.Mvc.RedirectToRouteResult RedirectToRoute(string routeName, object routeValues) { return default(System.Web.Mvc.RedirectToRouteResult); }
    protected internal virtual System.Web.Mvc.RedirectToRouteResult RedirectToRoute(string routeName, System.Web.Routing.RouteValueDictionary routeValues) { return default(System.Web.Mvc.RedirectToRouteResult); }
    protected internal System.Web.Mvc.RedirectToRouteResult RedirectToRoute(System.Web.Routing.RouteValueDictionary routeValues) { return default(System.Web.Mvc.RedirectToRouteResult); }
    void System.Web.Mvc.IActionFilter.OnActionExecuted(System.Web.Mvc.ActionExecutedContext filterContext) { }
    void System.Web.Mvc.IActionFilter.OnActionExecuting(System.Web.Mvc.ActionExecutingContext filterContext) { }
    void System.Web.Mvc.IAuthorizationFilter.OnAuthorization(System.Web.Mvc.AuthorizationContext filterContext) { }
    void System.Web.Mvc.IExceptionFilter.OnException(System.Web.Mvc.ExceptionContext filterContext) { }
    void System.Web.Mvc.IResultFilter.OnResultExecuted(System.Web.Mvc.ResultExecutedContext filterContext) { }
    void System.Web.Mvc.IResultFilter.OnResultExecuting(System.Web.Mvc.ResultExecutingContext filterContext) { }
    protected internal bool TryUpdateModel<TModel>(TModel model) where TModel : class { return default(bool); }
    protected internal bool TryUpdateModel<TModel>(TModel model, string prefix) where TModel : class { return default(bool); }
    protected internal bool TryUpdateModel<TModel>(TModel model, string prefix, System.String[] includeProperties) where TModel : class { return default(bool); }
    protected internal bool TryUpdateModel<TModel>(TModel model, string prefix, System.String[] includeProperties, System.String[] excludeProperties) where TModel : class { return default(bool); }
    protected internal bool TryUpdateModel<TModel>(TModel model, string prefix, System.String[] includeProperties, System.String[] excludeProperties, System.Web.Mvc.IValueProvider valueProvider) where TModel : class { return default(bool); }
    protected internal bool TryUpdateModel<TModel>(TModel model, string prefix, System.String[] includeProperties, System.Web.Mvc.IValueProvider valueProvider) where TModel : class { return default(bool); }
    protected internal bool TryUpdateModel<TModel>(TModel model, string prefix, System.Web.Mvc.IValueProvider valueProvider) where TModel : class { return default(bool); }
    protected internal bool TryUpdateModel<TModel>(TModel model, System.String[] includeProperties) where TModel : class { return default(bool); }
    protected internal bool TryUpdateModel<TModel>(TModel model, System.String[] includeProperties, System.Web.Mvc.IValueProvider valueProvider) where TModel : class { return default(bool); }
    protected internal bool TryUpdateModel<TModel>(TModel model, System.Web.Mvc.IValueProvider valueProvider) where TModel : class { return default(bool); }
    protected internal bool TryValidateModel(object model) { return default(bool); }
    protected internal bool TryValidateModel(object model, string prefix) { return default(bool); }
    protected internal void UpdateModel<TModel>(TModel model) where TModel : class { }
    protected internal void UpdateModel<TModel>(TModel model, string prefix) where TModel : class { }
    protected internal void UpdateModel<TModel>(TModel model, string prefix, System.String[] includeProperties) where TModel : class { }
    protected internal void UpdateModel<TModel>(TModel model, string prefix, System.String[] includeProperties, System.String[] excludeProperties) where TModel : class { }
    protected internal void UpdateModel<TModel>(TModel model, string prefix, System.String[] includeProperties, System.String[] excludeProperties, System.Web.Mvc.IValueProvider valueProvider) where TModel : class { }
    protected internal void UpdateModel<TModel>(TModel model, string prefix, System.String[] includeProperties, System.Web.Mvc.IValueProvider valueProvider) where TModel : class { }
    protected internal void UpdateModel<TModel>(TModel model, string prefix, System.Web.Mvc.IValueProvider valueProvider) where TModel : class { }
    protected internal void UpdateModel<TModel>(TModel model, System.String[] includeProperties) where TModel : class { }
    protected internal void UpdateModel<TModel>(TModel model, System.String[] includeProperties, System.Web.Mvc.IValueProvider valueProvider) where TModel : class { }
    protected internal void UpdateModel<TModel>(TModel model, System.Web.Mvc.IValueProvider valueProvider) where TModel : class { }
    protected internal void ValidateModel(object model) { }
    protected internal void ValidateModel(object model, string prefix) { }
    protected internal System.Web.Mvc.ViewResult View() { return default(System.Web.Mvc.ViewResult); }
    protected internal System.Web.Mvc.ViewResult View(object model) { return default(System.Web.Mvc.ViewResult); }
    protected internal System.Web.Mvc.ViewResult View(string viewName) { return default(System.Web.Mvc.ViewResult); }
    protected internal System.Web.Mvc.ViewResult View(string viewName, object model) { return default(System.Web.Mvc.ViewResult); }
    protected internal System.Web.Mvc.ViewResult View(string viewName, string masterName) { return default(System.Web.Mvc.ViewResult); }
    protected internal virtual System.Web.Mvc.ViewResult View(string viewName, string masterName, object model) { return default(System.Web.Mvc.ViewResult); }
    protected internal System.Web.Mvc.ViewResult View(System.Web.Mvc.IView view) { return default(System.Web.Mvc.ViewResult); }
    protected internal virtual System.Web.Mvc.ViewResult View(System.Web.Mvc.IView view, object model) { return default(System.Web.Mvc.ViewResult); }
  }
  public partial class ControllerActionInvoker : System.Web.Mvc.IActionInvoker {
    public ControllerActionInvoker() { }
    protected internal System.Web.Mvc.ModelBinderDictionary Binders { get { return default(System.Web.Mvc.ModelBinderDictionary); } set { } }
    protected virtual System.Web.Mvc.ActionResult CreateActionResult(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ActionDescriptor actionDescriptor, object actionReturnValue) { return default(System.Web.Mvc.ActionResult); }
    protected virtual System.Web.Mvc.ActionDescriptor FindAction(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ControllerDescriptor controllerDescriptor, string actionName) { return default(System.Web.Mvc.ActionDescriptor); }
    protected virtual System.Web.Mvc.ControllerDescriptor GetControllerDescriptor(System.Web.Mvc.ControllerContext controllerContext) { return default(System.Web.Mvc.ControllerDescriptor); }
    protected virtual System.Web.Mvc.FilterInfo GetFilters(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ActionDescriptor actionDescriptor) { return default(System.Web.Mvc.FilterInfo); }
    protected virtual object GetParameterValue(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ParameterDescriptor parameterDescriptor) { return default(object); }
    protected virtual System.Collections.Generic.IDictionary<System.String, System.Object> GetParameterValues(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ActionDescriptor actionDescriptor) { return default(System.Collections.Generic.IDictionary<System.String, System.Object>); }
    public virtual bool InvokeAction(System.Web.Mvc.ControllerContext controllerContext, string actionName) { return default(bool); }
    protected virtual System.Web.Mvc.ActionResult InvokeActionMethod(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ActionDescriptor actionDescriptor, System.Collections.Generic.IDictionary<System.String, System.Object> parameters) { return default(System.Web.Mvc.ActionResult); }
    protected virtual System.Web.Mvc.ActionExecutedContext InvokeActionMethodWithFilters(System.Web.Mvc.ControllerContext controllerContext, System.Collections.Generic.IList<System.Web.Mvc.IActionFilter> filters, System.Web.Mvc.ActionDescriptor actionDescriptor, System.Collections.Generic.IDictionary<System.String, System.Object> parameters) { return default(System.Web.Mvc.ActionExecutedContext); }
    protected virtual void InvokeActionResult(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ActionResult actionResult) { }
    protected virtual System.Web.Mvc.ResultExecutedContext InvokeActionResultWithFilters(System.Web.Mvc.ControllerContext controllerContext, System.Collections.Generic.IList<System.Web.Mvc.IResultFilter> filters, System.Web.Mvc.ActionResult actionResult) { return default(System.Web.Mvc.ResultExecutedContext); }
    protected virtual System.Web.Mvc.AuthorizationContext InvokeAuthorizationFilters(System.Web.Mvc.ControllerContext controllerContext, System.Collections.Generic.IList<System.Web.Mvc.IAuthorizationFilter> filters, System.Web.Mvc.ActionDescriptor actionDescriptor) { return default(System.Web.Mvc.AuthorizationContext); }
    protected virtual System.Web.Mvc.ExceptionContext InvokeExceptionFilters(System.Web.Mvc.ControllerContext controllerContext, System.Collections.Generic.IList<System.Web.Mvc.IExceptionFilter> filters, System.Exception exception) { return default(System.Web.Mvc.ExceptionContext); }
  }
  public abstract partial class ControllerBase : System.Web.Mvc.IController {
    protected ControllerBase() { }
    public System.Web.Mvc.ControllerContext ControllerContext { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Mvc.ControllerContext); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Web.Mvc.TempDataDictionary TempData { get { return default(System.Web.Mvc.TempDataDictionary); } set { } }
    public bool ValidateRequest { get { return default(bool); } set { } }
    public System.Web.Mvc.IValueProvider ValueProvider { get { return default(System.Web.Mvc.IValueProvider); } set { } }
    public System.Web.Mvc.ViewDataDictionary ViewData { get { return default(System.Web.Mvc.ViewDataDictionary); } set { } }
    protected virtual void Execute(System.Web.Routing.RequestContext requestContext) { }
    protected abstract void ExecuteCore();
    protected virtual void Initialize(System.Web.Routing.RequestContext requestContext) { }
    void System.Web.Mvc.IController.Execute(System.Web.Routing.RequestContext requestContext) { }
  }
  public partial class ControllerBuilder {
    public ControllerBuilder() { }
    public static System.Web.Mvc.ControllerBuilder Current { get { return default(System.Web.Mvc.ControllerBuilder); } }
    public System.Collections.Generic.HashSet<System.String> DefaultNamespaces { get { return default(System.Collections.Generic.HashSet<System.String>); } }
    public System.Web.Mvc.IControllerFactory GetControllerFactory() { return default(System.Web.Mvc.IControllerFactory); }
    public void SetControllerFactory(System.Type controllerFactoryType) { }
    public void SetControllerFactory(System.Web.Mvc.IControllerFactory controllerFactory) { }
  }
  public partial class ControllerContext {
    public ControllerContext() { }
    public ControllerContext(System.Web.HttpContextBase httpContext, System.Web.Routing.RouteData routeData, System.Web.Mvc.ControllerBase controller) { }
    protected ControllerContext(System.Web.Mvc.ControllerContext controllerContext) { }
    public ControllerContext(System.Web.Routing.RequestContext requestContext, System.Web.Mvc.ControllerBase controller) { }
    public virtual System.Web.Mvc.ControllerBase Controller { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Mvc.ControllerBase); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public virtual System.Web.HttpContextBase HttpContext { get { return default(System.Web.HttpContextBase); } set { } }
    public virtual bool IsChildAction { get { return default(bool); } }
    public System.Web.Mvc.ViewContext ParentActionViewContext { get { return default(System.Web.Mvc.ViewContext); } }
    public System.Web.Routing.RequestContext RequestContext { get { return default(System.Web.Routing.RequestContext); } set { } }
    public virtual System.Web.Routing.RouteData RouteData { get { return default(System.Web.Routing.RouteData); } set { } }
  }
  public abstract partial class ControllerDescriptor : System.Reflection.ICustomAttributeProvider {
    protected ControllerDescriptor() { }
    public virtual string ControllerName { get { return default(string); } }
    public abstract System.Type ControllerType { get; }
    public abstract System.Web.Mvc.ActionDescriptor FindAction(System.Web.Mvc.ControllerContext controllerContext, string actionName);
    public abstract System.Web.Mvc.ActionDescriptor[] GetCanonicalActions();
    public virtual System.Object[] GetCustomAttributes(bool inherit) { return default(System.Object[]); }
    public virtual System.Object[] GetCustomAttributes(System.Type attributeType, bool inherit) { return default(System.Object[]); }
    public virtual bool IsDefined(System.Type attributeType, bool inherit) { return default(bool); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(3100), AllowMultiple=false, Inherited=false)]
  public abstract partial class CustomModelBinderAttribute : System.Attribute {
    protected CustomModelBinderAttribute() { }
    public abstract System.Web.Mvc.IModelBinder GetBinder();
  }
  public partial class DataAnnotationsModelMetadata : System.Web.Mvc.ModelMetadata {
    public DataAnnotationsModelMetadata(System.Web.Mvc.DataAnnotationsModelMetadataProvider provider, System.Type containerType, System.Func<System.Object> modelAccessor, System.Type modelType, string propertyName, System.ComponentModel.DataAnnotations.DisplayColumnAttribute displayColumnAttribute) : base (default(System.Web.Mvc.ModelMetadataProvider), default(System.Type), default(System.Func<System.Object>), default(System.Type), default(string)) { }
    protected override string GetSimpleDisplayText() { return default(string); }
  }
  public partial class DataAnnotationsModelMetadataProvider : System.Web.Mvc.AssociatedMetadataProvider {
    public DataAnnotationsModelMetadataProvider() { }
    protected override System.Web.Mvc.ModelMetadata CreateMetadata(System.Collections.Generic.IEnumerable<System.Attribute> attributes, System.Type containerType, System.Func<System.Object> modelAccessor, System.Type modelType, string propertyName) { return default(System.Web.Mvc.ModelMetadata); }
  }
  public delegate System.Web.Mvc.ModelValidator DataAnnotationsModelValidationFactory(System.Web.Mvc.ModelMetadata metadata, System.Web.Mvc.ControllerContext context, System.ComponentModel.DataAnnotations.ValidationAttribute attribute);
  public partial class DataAnnotationsModelValidator : System.Web.Mvc.ModelValidator {
    public DataAnnotationsModelValidator(System.Web.Mvc.ModelMetadata metadata, System.Web.Mvc.ControllerContext context, System.ComponentModel.DataAnnotations.ValidationAttribute attribute) : base (default(System.Web.Mvc.ModelMetadata), default(System.Web.Mvc.ControllerContext)) { }
    protected internal System.ComponentModel.DataAnnotations.ValidationAttribute Attribute { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ComponentModel.DataAnnotations.ValidationAttribute); } }
    protected internal string ErrorMessage { get { return default(string); } }
    public override bool IsRequired { get { return default(bool); } }
    [System.Diagnostics.DebuggerHiddenAttribute]
    public override System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelValidationResult> Validate(object container) { return default(System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelValidationResult>); }
  }
  public partial class DataAnnotationsModelValidator<TAttribute> : System.Web.Mvc.DataAnnotationsModelValidator where TAttribute : System.ComponentModel.DataAnnotations.ValidationAttribute {
    public DataAnnotationsModelValidator(System.Web.Mvc.ModelMetadata metadata, System.Web.Mvc.ControllerContext context, TAttribute attribute) : base (default(System.Web.Mvc.ModelMetadata), default(System.Web.Mvc.ControllerContext), default(System.ComponentModel.DataAnnotations.ValidationAttribute)) { }
    protected new TAttribute Attribute { get { return default(TAttribute); } }
  }
  public partial class DataAnnotationsModelValidatorProvider : System.Web.Mvc.AssociatedValidatorProvider {
    public DataAnnotationsModelValidatorProvider() { }
    public static bool AddImplicitRequiredAttributeForValueTypes { get { return default(bool); } set { } }
    protected override System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelValidator> GetValidators(System.Web.Mvc.ModelMetadata metadata, System.Web.Mvc.ControllerContext context, System.Collections.Generic.IEnumerable<System.Attribute> attributes) { return default(System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelValidator>); }
    public static void RegisterAdapter(System.Type attributeType, System.Type adapterType) { }
    public static void RegisterAdapterFactory(System.Type attributeType, System.Web.Mvc.DataAnnotationsModelValidationFactory factory) { }
    public static void RegisterDefaultAdapter(System.Type adapterType) { }
    public static void RegisterDefaultAdapterFactory(System.Web.Mvc.DataAnnotationsModelValidationFactory factory) { }
  }
  public partial class DataErrorInfoModelValidatorProvider : System.Web.Mvc.ModelValidatorProvider {
    public DataErrorInfoModelValidatorProvider() { }
    public override System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelValidator> GetValidators(System.Web.Mvc.ModelMetadata metadata, System.Web.Mvc.ControllerContext context) { return default(System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelValidator>); }
  }
  public partial class DefaultControllerFactory : System.Web.Mvc.IControllerFactory {
    public DefaultControllerFactory() { }
    public virtual System.Web.Mvc.IController CreateController(System.Web.Routing.RequestContext requestContext, string controllerName) { return default(System.Web.Mvc.IController); }
    protected internal virtual System.Web.Mvc.IController GetControllerInstance(System.Web.Routing.RequestContext requestContext, System.Type controllerType) { return default(System.Web.Mvc.IController); }
    protected internal virtual System.Type GetControllerType(System.Web.Routing.RequestContext requestContext, string controllerName) { return default(System.Type); }
    public virtual void ReleaseController(System.Web.Mvc.IController controller) { }
  }
  public partial class DefaultModelBinder : System.Web.Mvc.IModelBinder {
    public DefaultModelBinder() { }
    protected internal System.Web.Mvc.ModelBinderDictionary Binders { get { return default(System.Web.Mvc.ModelBinderDictionary); } set { } }
    public static string ResourceClassKey { get { return default(string); } set { } }
    public virtual object BindModel(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ModelBindingContext bindingContext) { return default(object); }
    protected virtual void BindProperty(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ModelBindingContext bindingContext, System.ComponentModel.PropertyDescriptor propertyDescriptor) { }
    protected virtual object CreateModel(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ModelBindingContext bindingContext, System.Type modelType) { return default(object); }
    protected static string CreateSubIndexName(string prefix, int index) { return default(string); }
    protected static string CreateSubIndexName(string prefix, string index) { return default(string); }
    protected internal static string CreateSubPropertyName(string prefix, string propertyName) { return default(string); }
    protected System.Collections.Generic.IEnumerable<System.ComponentModel.PropertyDescriptor> GetFilteredModelProperties(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ModelBindingContext bindingContext) { return default(System.Collections.Generic.IEnumerable<System.ComponentModel.PropertyDescriptor>); }
    protected virtual System.ComponentModel.PropertyDescriptorCollection GetModelProperties(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ModelBindingContext bindingContext) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    protected virtual object GetPropertyValue(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ModelBindingContext bindingContext, System.ComponentModel.PropertyDescriptor propertyDescriptor, System.Web.Mvc.IModelBinder propertyBinder) { return default(object); }
    protected virtual System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ModelBindingContext bindingContext) { return default(System.ComponentModel.ICustomTypeDescriptor); }
    protected static bool IsModelValid(System.Web.Mvc.ModelBindingContext bindingContext) { return default(bool); }
    protected virtual void OnModelUpdated(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ModelBindingContext bindingContext) { }
    protected virtual bool OnModelUpdating(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ModelBindingContext bindingContext) { return default(bool); }
    protected virtual void OnPropertyValidated(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ModelBindingContext bindingContext, System.ComponentModel.PropertyDescriptor propertyDescriptor, object value) { }
    protected virtual bool OnPropertyValidating(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ModelBindingContext bindingContext, System.ComponentModel.PropertyDescriptor propertyDescriptor, object value) { return default(bool); }
    protected virtual void SetProperty(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ModelBindingContext bindingContext, System.ComponentModel.PropertyDescriptor propertyDescriptor, object value) { }
  }
  public partial class DefaultViewLocationCache : System.Web.Mvc.IViewLocationCache {
    public static readonly System.Web.Mvc.IViewLocationCache Null;
    public DefaultViewLocationCache() { }
    public DefaultViewLocationCache(System.TimeSpan timeSpan) { }
    public System.TimeSpan TimeSpan { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.TimeSpan); } }
    public string GetViewLocation(System.Web.HttpContextBase httpContext, string key) { return default(string); }
    public void InsertViewLocation(System.Web.HttpContextBase httpContext, string key, string virtualPath) { }
  }
  public partial class DictionaryValueProvider<TValue> : System.Web.Mvc.IValueProvider {
    public DictionaryValueProvider(System.Collections.Generic.IDictionary<System.String, TValue> dictionary, System.Globalization.CultureInfo culture) { }
    public virtual bool ContainsPrefix(string prefix) { return default(bool); }
    public virtual System.Web.Mvc.ValueProviderResult GetValue(string key) { return default(System.Web.Mvc.ValueProviderResult); }
  }
  public partial class EmptyModelMetadataProvider : System.Web.Mvc.AssociatedMetadataProvider {
    public EmptyModelMetadataProvider() { }
    protected override System.Web.Mvc.ModelMetadata CreateMetadata(System.Collections.Generic.IEnumerable<System.Attribute> attributes, System.Type containerType, System.Func<System.Object> modelAccessor, System.Type modelType, string propertyName) { return default(System.Web.Mvc.ModelMetadata); }
  }
  public partial class EmptyModelValidatorProvider : System.Web.Mvc.ModelValidatorProvider {
    public EmptyModelValidatorProvider() { }
    public override System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelValidator> GetValidators(System.Web.Mvc.ModelMetadata metadata, System.Web.Mvc.ControllerContext context) { return default(System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelValidator>); }
  }
  public partial class EmptyResult : System.Web.Mvc.ActionResult {
    public EmptyResult() { }
    public override void ExecuteResult(System.Web.Mvc.ControllerContext context) { }
  }
  public partial class ExceptionContext : System.Web.Mvc.ControllerContext {
    public ExceptionContext() { }
    public ExceptionContext(System.Web.Mvc.ControllerContext controllerContext, System.Exception exception) { }
    public virtual System.Exception Exception { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Exception); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool ExceptionHandled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Web.Mvc.ActionResult Result { get { return default(System.Web.Mvc.ActionResult); } set { } }
  }
  public static partial class ExpressionHelper {
    public static string GetExpressionText(System.Linq.Expressions.LambdaExpression expression) { return default(string); }
    public static string GetExpressionText(string expression) { return default(string); }
  }
  public partial class FieldValidationMetadata {
    public FieldValidationMetadata() { }
    public string FieldName { get { return default(string); } set { } }
    public bool ReplaceValidationMessageContents { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string ValidationMessageId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.Generic.ICollection<System.Web.Mvc.ModelClientValidationRule> ValidationRules { get { return default(System.Collections.Generic.ICollection<System.Web.Mvc.ModelClientValidationRule>); } }
  }
  public partial class FileContentResult : System.Web.Mvc.FileResult {
    public FileContentResult(System.Byte[] fileContents, string contentType) : base (default(string)) { }
    public System.Byte[] FileContents { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Byte[]); } }
    protected override void WriteFile(System.Web.HttpResponseBase response) { }
  }
  public partial class FilePathResult : System.Web.Mvc.FileResult {
    public FilePathResult(string fileName, string contentType) : base (default(string)) { }
    public string FileName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    protected override void WriteFile(System.Web.HttpResponseBase response) { }
  }
  public abstract partial class FileResult : System.Web.Mvc.ActionResult {
    protected FileResult(string contentType) { }
    public string ContentType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string FileDownloadName { get { return default(string); } set { } }
    public override void ExecuteResult(System.Web.Mvc.ControllerContext context) { }
    protected abstract void WriteFile(System.Web.HttpResponseBase response);
  }
  public partial class FileStreamResult : System.Web.Mvc.FileResult {
    public FileStreamResult(System.IO.Stream fileStream, string contentType) : base (default(string)) { }
    public System.IO.Stream FileStream { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.IO.Stream); } }
    protected override void WriteFile(System.Web.HttpResponseBase response) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(68), Inherited=true, AllowMultiple=false)]
  public abstract partial class FilterAttribute : System.Attribute {
    protected FilterAttribute() { }
    public int Order { get { return default(int); } set { } }
  }
  public partial class FilterInfo {
    public FilterInfo() { }
    public System.Collections.Generic.IList<System.Web.Mvc.IActionFilter> ActionFilters { get { return default(System.Collections.Generic.IList<System.Web.Mvc.IActionFilter>); } }
    public System.Collections.Generic.IList<System.Web.Mvc.IAuthorizationFilter> AuthorizationFilters { get { return default(System.Collections.Generic.IList<System.Web.Mvc.IAuthorizationFilter>); } }
    public System.Collections.Generic.IList<System.Web.Mvc.IExceptionFilter> ExceptionFilters { get { return default(System.Collections.Generic.IList<System.Web.Mvc.IExceptionFilter>); } }
    public System.Collections.Generic.IList<System.Web.Mvc.IResultFilter> ResultFilters { get { return default(System.Collections.Generic.IList<System.Web.Mvc.IResultFilter>); } }
  }
  [System.Web.Mvc.FormCollection.FormCollectionBinderAttribute]
  public sealed partial class FormCollection : System.Collections.Specialized.NameValueCollection, System.Web.Mvc.IValueProvider {
    public FormCollection() { }
    public FormCollection(System.Collections.Specialized.NameValueCollection collection) { }
    public System.Web.Mvc.ValueProviderResult GetValue(string name) { return default(System.Web.Mvc.ValueProviderResult); }
    bool System.Web.Mvc.IValueProvider.ContainsPrefix(string prefix) { return default(bool); }
    System.Web.Mvc.ValueProviderResult System.Web.Mvc.IValueProvider.GetValue(string key) { return default(System.Web.Mvc.ValueProviderResult); }
    public System.Web.Mvc.IValueProvider ToValueProvider() { return default(System.Web.Mvc.IValueProvider); }
  }
  public partial class FormContext {
    public FormContext() { }
    public System.Collections.Generic.IDictionary<System.String, System.Web.Mvc.FieldValidationMetadata> FieldValidators { get { return default(System.Collections.Generic.IDictionary<System.String, System.Web.Mvc.FieldValidationMetadata>); } }
    public string FormId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool ReplaceValidationSummary { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string ValidationSummaryId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string GetJsonValidationMetadata() { return default(string); }
    public System.Web.Mvc.FieldValidationMetadata GetValidationMetadataForField(string fieldName) { return default(System.Web.Mvc.FieldValidationMetadata); }
    public System.Web.Mvc.FieldValidationMetadata GetValidationMetadataForField(string fieldName, bool createIfNotFound) { return default(System.Web.Mvc.FieldValidationMetadata); }
  }
  public enum FormMethod {
    Get = 0,
    Post = 1,
  }
  public sealed partial class FormValueProvider : System.Web.Mvc.NameValueCollectionValueProvider {
    public FormValueProvider(System.Web.Mvc.ControllerContext controllerContext) : base (default(System.Collections.Specialized.NameValueCollection), default(System.Globalization.CultureInfo)) { }
  }
  public sealed partial class FormValueProviderFactory : System.Web.Mvc.ValueProviderFactory {
    public FormValueProviderFactory() { }
    public override System.Web.Mvc.IValueProvider GetValueProvider(System.Web.Mvc.ControllerContext controllerContext) { return default(System.Web.Mvc.IValueProvider); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(68), Inherited=true, AllowMultiple=true)]
  public partial class HandleErrorAttribute : System.Web.Mvc.FilterAttribute, System.Web.Mvc.IExceptionFilter {
    public HandleErrorAttribute() { }
    public System.Type ExceptionType { get { return default(System.Type); } set { } }
    public string Master { get { return default(string); } set { } }
    public override object TypeId { get { return default(object); } }
    public string View { get { return default(string); } set { } }
    public virtual void OnException(System.Web.Mvc.ExceptionContext filterContext) { }
  }
  public partial class HandleErrorInfo {
    public HandleErrorInfo(System.Exception exception, string controllerName, string actionName) { }
    public string ActionName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string ControllerName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public System.Exception Exception { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Exception); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(132), AllowMultiple=false, Inherited=true)]
  public sealed partial class HiddenInputAttribute : System.Attribute {
    public HiddenInputAttribute() { }
    public bool DisplayValue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial class HtmlHelper {
    public static readonly string ValidationInputCssClassName;
    public static readonly string ValidationInputValidCssClassName;
    public static readonly string ValidationMessageCssClassName;
    public static readonly string ValidationMessageValidCssClassName;
    public static readonly string ValidationSummaryCssClassName;
    public static readonly string ValidationSummaryValidCssClassName;
    public HtmlHelper(System.Web.Mvc.ViewContext viewContext, System.Web.Mvc.IViewDataContainer viewDataContainer) { }
    public HtmlHelper(System.Web.Mvc.ViewContext viewContext, System.Web.Mvc.IViewDataContainer viewDataContainer, System.Web.Routing.RouteCollection routeCollection) { }
    public static string IdAttributeDotReplacement { get { return default(string); } set { } }
    public System.Web.Routing.RouteCollection RouteCollection { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Routing.RouteCollection); } }
    public System.Web.Mvc.ViewContext ViewContext { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Mvc.ViewContext); } }
    public System.Web.Mvc.ViewDataDictionary ViewData { get { return default(System.Web.Mvc.ViewDataDictionary); } }
    public System.Web.Mvc.IViewDataContainer ViewDataContainer { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Mvc.IViewDataContainer); } }
    public System.Web.Mvc.MvcHtmlString AntiForgeryToken() { return default(System.Web.Mvc.MvcHtmlString); }
    public System.Web.Mvc.MvcHtmlString AntiForgeryToken(string salt) { return default(System.Web.Mvc.MvcHtmlString); }
    public System.Web.Mvc.MvcHtmlString AntiForgeryToken(string salt, string domain, string path) { return default(System.Web.Mvc.MvcHtmlString); }
    public string AttributeEncode(object value) { return default(string); }
    public string AttributeEncode(string value) { return default(string); }
    public void EnableClientValidation() { }
    public string Encode(object value) { return default(string); }
    public string Encode(string value) { return default(string); }
    public static string GenerateIdFromName(string name) { return default(string); }
    public static string GenerateIdFromName(string name, string idAttributeDotReplacement) { return default(string); }
    public static string GenerateLink(System.Web.Routing.RequestContext requestContext, System.Web.Routing.RouteCollection routeCollection, string linkText, string routeName, string actionName, string controllerName, string protocol, string hostName, string fragment, System.Web.Routing.RouteValueDictionary routeValues, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(string); }
    public static string GenerateLink(System.Web.Routing.RequestContext requestContext, System.Web.Routing.RouteCollection routeCollection, string linkText, string routeName, string actionName, string controllerName, System.Web.Routing.RouteValueDictionary routeValues, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(string); }
    public static string GenerateRouteLink(System.Web.Routing.RequestContext requestContext, System.Web.Routing.RouteCollection routeCollection, string linkText, string routeName, string protocol, string hostName, string fragment, System.Web.Routing.RouteValueDictionary routeValues, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(string); }
    public static string GenerateRouteLink(System.Web.Routing.RequestContext requestContext, System.Web.Routing.RouteCollection routeCollection, string linkText, string routeName, System.Web.Routing.RouteValueDictionary routeValues, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(string); }
    public static string GetFormMethodString(System.Web.Mvc.FormMethod method) { return default(string); }
    public static string GetInputTypeString(System.Web.Mvc.InputType inputType) { return default(string); }
    public System.Web.Mvc.MvcHtmlString HttpMethodOverride(string httpMethod) { return default(System.Web.Mvc.MvcHtmlString); }
    public System.Web.Mvc.MvcHtmlString HttpMethodOverride(System.Web.Mvc.HttpVerbs httpVerb) { return default(System.Web.Mvc.MvcHtmlString); }
  }
  public partial class HtmlHelper<TModel> : System.Web.Mvc.HtmlHelper {
    public HtmlHelper(System.Web.Mvc.ViewContext viewContext, System.Web.Mvc.IViewDataContainer viewDataContainer) : base (default(System.Web.Mvc.ViewContext), default(System.Web.Mvc.IViewDataContainer)) { }
    public HtmlHelper(System.Web.Mvc.ViewContext viewContext, System.Web.Mvc.IViewDataContainer viewDataContainer, System.Web.Routing.RouteCollection routeCollection) : base (default(System.Web.Mvc.ViewContext), default(System.Web.Mvc.IViewDataContainer)) { }
    public new System.Web.Mvc.ViewDataDictionary<TModel> ViewData { get { return default(System.Web.Mvc.ViewDataDictionary<TModel>); } }
  }
  public sealed partial class HttpAntiForgeryException : System.Web.HttpException {
    public HttpAntiForgeryException() { }
    public HttpAntiForgeryException(string message) { }
    public HttpAntiForgeryException(string message, System.Exception innerException) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=false, Inherited=true)]
  public sealed partial class HttpDeleteAttribute : System.Web.Mvc.ActionMethodSelectorAttribute {
    public HttpDeleteAttribute() { }
    public override bool IsValidForRequest(System.Web.Mvc.ControllerContext controllerContext, System.Reflection.MethodInfo methodInfo) { return default(bool); }
  }
  public sealed partial class HttpFileCollectionValueProvider : System.Web.Mvc.DictionaryValueProvider<System.Web.HttpPostedFileBase[]> {
    public HttpFileCollectionValueProvider(System.Web.Mvc.ControllerContext controllerContext) : base (default(System.Collections.Generic.IDictionary<System.String, System.Web.HttpPostedFileBase[]>), default(System.Globalization.CultureInfo)) { }
  }
  public sealed partial class HttpFileCollectionValueProviderFactory : System.Web.Mvc.ValueProviderFactory {
    public HttpFileCollectionValueProviderFactory() { }
    public override System.Web.Mvc.IValueProvider GetValueProvider(System.Web.Mvc.ControllerContext controllerContext) { return default(System.Web.Mvc.IValueProvider); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=false, Inherited=true)]
  public sealed partial class HttpGetAttribute : System.Web.Mvc.ActionMethodSelectorAttribute {
    public HttpGetAttribute() { }
    public override bool IsValidForRequest(System.Web.Mvc.ControllerContext controllerContext, System.Reflection.MethodInfo methodInfo) { return default(bool); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=false, Inherited=true)]
  public sealed partial class HttpPostAttribute : System.Web.Mvc.ActionMethodSelectorAttribute {
    public HttpPostAttribute() { }
    public override bool IsValidForRequest(System.Web.Mvc.ControllerContext controllerContext, System.Reflection.MethodInfo methodInfo) { return default(bool); }
  }
  public partial class HttpPostedFileBaseModelBinder : System.Web.Mvc.IModelBinder {
    public HttpPostedFileBaseModelBinder() { }
    public object BindModel(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ModelBindingContext bindingContext) { return default(object); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=false, Inherited=true)]
  public sealed partial class HttpPutAttribute : System.Web.Mvc.ActionMethodSelectorAttribute {
    public HttpPutAttribute() { }
    public override bool IsValidForRequest(System.Web.Mvc.ControllerContext controllerContext, System.Reflection.MethodInfo methodInfo) { return default(bool); }
  }
  public static partial class HttpRequestExtensions {
    public static string GetHttpMethodOverride(this System.Web.HttpRequestBase request) { return default(string); }
  }
  public partial class HttpUnauthorizedResult : System.Web.Mvc.ActionResult {
    public HttpUnauthorizedResult() { }
    public override void ExecuteResult(System.Web.Mvc.ControllerContext context) { }
  }
  [System.FlagsAttribute]
  public enum HttpVerbs {
    Delete = 8,
    Get = 1,
    Head = 16,
    Post = 2,
    Put = 4,
  }
  public partial interface IActionFilter {
    void OnActionExecuted(System.Web.Mvc.ActionExecutedContext filterContext);
    void OnActionExecuting(System.Web.Mvc.ActionExecutingContext filterContext);
  }
  public partial interface IActionInvoker {
    bool InvokeAction(System.Web.Mvc.ControllerContext controllerContext, string actionName);
  }
  public partial interface IAuthorizationFilter {
    void OnAuthorization(System.Web.Mvc.AuthorizationContext filterContext);
  }
  public partial interface IController {
    void Execute(System.Web.Routing.RequestContext requestContext);
  }
  public partial interface IControllerFactory {
    System.Web.Mvc.IController CreateController(System.Web.Routing.RequestContext requestContext, string controllerName);
    void ReleaseController(System.Web.Mvc.IController controller);
  }
  public partial interface IExceptionFilter {
    void OnException(System.Web.Mvc.ExceptionContext filterContext);
  }
  public partial interface IModelBinder {
    object BindModel(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ModelBindingContext bindingContext);
  }
  public enum InputType {
    CheckBox = 0,
    Hidden = 1,
    Password = 2,
    Radio = 3,
    Text = 4,
  }
  public partial interface IResultFilter {
    void OnResultExecuted(System.Web.Mvc.ResultExecutedContext filterContext);
    void OnResultExecuting(System.Web.Mvc.ResultExecutingContext filterContext);
  }
  public partial interface IRouteWithArea {
    string Area { get; }
  }
  public partial interface ITempDataProvider {
    System.Collections.Generic.IDictionary<System.String, System.Object> LoadTempData(System.Web.Mvc.ControllerContext controllerContext);
    void SaveTempData(System.Web.Mvc.ControllerContext controllerContext, System.Collections.Generic.IDictionary<System.String, System.Object> values);
  }
  public partial interface IValueProvider {
    bool ContainsPrefix(string prefix);
    System.Web.Mvc.ValueProviderResult GetValue(string key);
  }
  public partial interface IView {
    void Render(System.Web.Mvc.ViewContext viewContext, System.IO.TextWriter writer);
  }
  public partial interface IViewDataContainer {
    System.Web.Mvc.ViewDataDictionary ViewData { get; set; }
  }
  public partial interface IViewEngine {
    System.Web.Mvc.ViewEngineResult FindPartialView(System.Web.Mvc.ControllerContext controllerContext, string partialViewName, bool useCache);
    System.Web.Mvc.ViewEngineResult FindView(System.Web.Mvc.ControllerContext controllerContext, string viewName, string masterName, bool useCache);
    void ReleaseView(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.IView view);
  }
  public partial interface IViewLocationCache {
    string GetViewLocation(System.Web.HttpContextBase httpContext, string key);
    void InsertViewLocation(System.Web.HttpContextBase httpContext, string key, string virtualPath);
  }
  public partial class JavaScriptResult : System.Web.Mvc.ActionResult {
    public JavaScriptResult() { }
    public string Script { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override void ExecuteResult(System.Web.Mvc.ControllerContext context) { }
  }
  public enum JsonRequestBehavior {
    AllowGet = 0,
    DenyGet = 1,
  }
  public partial class JsonResult : System.Web.Mvc.ActionResult {
    public JsonResult() { }
    public System.Text.Encoding ContentEncoding { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Text.Encoding); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string ContentType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public object Data { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Web.Mvc.JsonRequestBehavior JsonRequestBehavior { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Mvc.JsonRequestBehavior); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override void ExecuteResult(System.Web.Mvc.ControllerContext context) { }
  }
  public partial class LinqBinaryModelBinder : System.Web.Mvc.ByteArrayModelBinder {
    public LinqBinaryModelBinder() { }
    public override object BindModel(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ModelBindingContext bindingContext) { return default(object); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(3100), AllowMultiple=false, Inherited=false)]
  public sealed partial class ModelBinderAttribute : System.Web.Mvc.CustomModelBinderAttribute {
    public ModelBinderAttribute(System.Type binderType) { }
    public System.Type BinderType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } }
    public override System.Web.Mvc.IModelBinder GetBinder() { return default(System.Web.Mvc.IModelBinder); }
  }
  public partial class ModelBinderDictionary : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.Type, System.Web.Mvc.IModelBinder>>, System.Collections.Generic.IDictionary<System.Type, System.Web.Mvc.IModelBinder>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Type, System.Web.Mvc.IModelBinder>>, System.Collections.IEnumerable {
    public ModelBinderDictionary() { }
    public int Count { get { return default(int); } }
    public System.Web.Mvc.IModelBinder DefaultBinder { get { return default(System.Web.Mvc.IModelBinder); } set { } }
    public bool IsReadOnly { get { return default(bool); } }
    public System.Web.Mvc.IModelBinder this[System.Type key] { get { return default(System.Web.Mvc.IModelBinder); } set { } }
    public System.Collections.Generic.ICollection<System.Type> Keys { get { return default(System.Collections.Generic.ICollection<System.Type>); } }
    public System.Collections.Generic.ICollection<System.Web.Mvc.IModelBinder> Values { get { return default(System.Collections.Generic.ICollection<System.Web.Mvc.IModelBinder>); } }
    public void Add(System.Collections.Generic.KeyValuePair<System.Type, System.Web.Mvc.IModelBinder> item) { }
    public void Add(System.Type key, System.Web.Mvc.IModelBinder value) { }
    public void Clear() { }
    public bool Contains(System.Collections.Generic.KeyValuePair<System.Type, System.Web.Mvc.IModelBinder> item) { return default(bool); }
    public bool ContainsKey(System.Type key) { return default(bool); }
    public void CopyTo(System.Collections.Generic.KeyValuePair<System.Type, System.Web.Mvc.IModelBinder>[] array, int arrayIndex) { }
    public System.Web.Mvc.IModelBinder GetBinder(System.Type modelType) { return default(System.Web.Mvc.IModelBinder); }
    public virtual System.Web.Mvc.IModelBinder GetBinder(System.Type modelType, bool fallbackToDefault) { return default(System.Web.Mvc.IModelBinder); }
    public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Type, System.Web.Mvc.IModelBinder>> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Type, System.Web.Mvc.IModelBinder>>); }
    public bool Remove(System.Collections.Generic.KeyValuePair<System.Type, System.Web.Mvc.IModelBinder> item) { return default(bool); }
    public bool Remove(System.Type key) { return default(bool); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    public bool TryGetValue(System.Type key, out System.Web.Mvc.IModelBinder value) { value = default(System.Web.Mvc.IModelBinder); return default(bool); }
  }
  public static partial class ModelBinders {
    public static System.Web.Mvc.ModelBinderDictionary Binders { get { return default(System.Web.Mvc.ModelBinderDictionary); } }
  }
  public partial class ModelBindingContext {
    public ModelBindingContext() { }
    public ModelBindingContext(System.Web.Mvc.ModelBindingContext bindingContext) { }
    public bool FallbackToEmptyPrefix { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public object Model { get { return default(object); } set { } }
    public System.Web.Mvc.ModelMetadata ModelMetadata { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Mvc.ModelMetadata); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string ModelName { get { return default(string); } set { } }
    public System.Web.Mvc.ModelStateDictionary ModelState { get { return default(System.Web.Mvc.ModelStateDictionary); } set { } }
    public System.Type ModelType { get { return default(System.Type); } set { } }
    public System.Predicate<System.String> PropertyFilter { get { return default(System.Predicate<System.String>); } set { } }
    public System.Collections.Generic.IDictionary<System.String, System.Web.Mvc.ModelMetadata> PropertyMetadata { get { return default(System.Collections.Generic.IDictionary<System.String, System.Web.Mvc.ModelMetadata>); } }
    public System.Web.Mvc.IValueProvider ValueProvider { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Mvc.IValueProvider); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial class ModelClientValidationRangeRule : System.Web.Mvc.ModelClientValidationRule {
    public ModelClientValidationRangeRule(string errorMessage, object minValue, object maxValue) { }
  }
  public partial class ModelClientValidationRegexRule : System.Web.Mvc.ModelClientValidationRule {
    public ModelClientValidationRegexRule(string errorMessage, string pattern) { }
  }
  public partial class ModelClientValidationRequiredRule : System.Web.Mvc.ModelClientValidationRule {
    public ModelClientValidationRequiredRule(string errorMessage) { }
  }
  public partial class ModelClientValidationRule {
    public ModelClientValidationRule() { }
    public string ErrorMessage { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.Generic.IDictionary<System.String, System.Object> ValidationParameters { get { return default(System.Collections.Generic.IDictionary<System.String, System.Object>); } }
    public string ValidationType { get { return default(string); } set { } }
  }
  public partial class ModelClientValidationStringLengthRule : System.Web.Mvc.ModelClientValidationRule {
    public ModelClientValidationStringLengthRule(string errorMessage, int minimumLength, int maximumLength) { }
  }
  public partial class ModelError {
    public ModelError(System.Exception exception) { }
    public ModelError(System.Exception exception, string errorMessage) { }
    public ModelError(string errorMessage) { }
    public string ErrorMessage { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public System.Exception Exception { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Exception); } }
  }
  public partial class ModelErrorCollection : System.Collections.ObjectModel.Collection<System.Web.Mvc.ModelError> {
    public ModelErrorCollection() { }
    public void Add(System.Exception exception) { }
    public void Add(string errorMessage) { }
  }
  public partial class ModelMetadata {
    public ModelMetadata(System.Web.Mvc.ModelMetadataProvider provider, System.Type containerType, System.Func<System.Object> modelAccessor, System.Type modelType, string propertyName) { }
    public virtual System.Collections.Generic.Dictionary<System.String, System.Object> AdditionalValues { get { return default(System.Collections.Generic.Dictionary<System.String, System.Object>); } }
    public System.Type ContainerType { get { return default(System.Type); } }
    public virtual bool ConvertEmptyStringToNull { get { return default(bool); } set { } }
    public virtual string DataTypeName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public virtual string Description { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public virtual string DisplayFormatString { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public virtual string DisplayName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public virtual string EditFormatString { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public virtual bool HideSurroundingHtml { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public virtual bool IsComplexType { get { return default(bool); } }
    public bool IsNullableValueType { get { return default(bool); } }
    public virtual bool IsReadOnly { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public virtual bool IsRequired { get { return default(bool); } set { } }
    public object Model { get { return default(object); } set { } }
    public System.Type ModelType { get { return default(System.Type); } }
    public virtual string NullDisplayText { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public virtual System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelMetadata> Properties { get { return default(System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelMetadata>); } }
    public string PropertyName { get { return default(string); } }
    protected System.Web.Mvc.ModelMetadataProvider Provider { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Mvc.ModelMetadataProvider); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public virtual string ShortDisplayName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public virtual bool ShowForDisplay { get { return default(bool); } set { } }
    public virtual bool ShowForEdit { get { return default(bool); } set { } }
    public virtual string SimpleDisplayText { get { return default(string); } set { } }
    public virtual string TemplateHint { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public virtual string Watermark { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public static System.Web.Mvc.ModelMetadata FromLambdaExpression<TParameter, TValue>(System.Linq.Expressions.Expression<System.Func<TParameter, TValue>> expression, System.Web.Mvc.ViewDataDictionary<TParameter> viewData) { return default(System.Web.Mvc.ModelMetadata); }
    public static System.Web.Mvc.ModelMetadata FromStringExpression(string expression, System.Web.Mvc.ViewDataDictionary viewData) { return default(System.Web.Mvc.ModelMetadata); }
    public string GetDisplayName() { return default(string); }
    protected virtual string GetSimpleDisplayText() { return default(string); }
    public virtual System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelValidator> GetValidators(System.Web.Mvc.ControllerContext context) { return default(System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelValidator>); }
  }
  public abstract partial class ModelMetadataProvider {
    protected ModelMetadataProvider() { }
    public abstract System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelMetadata> GetMetadataForProperties(object container, System.Type containerType);
    public abstract System.Web.Mvc.ModelMetadata GetMetadataForProperty(System.Func<System.Object> modelAccessor, System.Type containerType, string propertyName);
    public abstract System.Web.Mvc.ModelMetadata GetMetadataForType(System.Func<System.Object> modelAccessor, System.Type modelType);
  }
  public static partial class ModelMetadataProviders {
    public static System.Web.Mvc.ModelMetadataProvider Current { get { return default(System.Web.Mvc.ModelMetadataProvider); } set { } }
  }
  public partial class ModelState {
    public ModelState() { }
    public System.Web.Mvc.ModelErrorCollection Errors { get { return default(System.Web.Mvc.ModelErrorCollection); } }
    public System.Web.Mvc.ValueProviderResult Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Mvc.ValueProviderResult); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial class ModelStateDictionary : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String, System.Web.Mvc.ModelState>>, System.Collections.Generic.IDictionary<System.String, System.Web.Mvc.ModelState>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Web.Mvc.ModelState>>, System.Collections.IEnumerable {
    public ModelStateDictionary() { }
    public ModelStateDictionary(System.Web.Mvc.ModelStateDictionary dictionary) { }
    public int Count { get { return default(int); } }
    public bool IsReadOnly { get { return default(bool); } }
    public bool IsValid { get { return default(bool); } }
    public System.Web.Mvc.ModelState this[string key] { get { return default(System.Web.Mvc.ModelState); } set { } }
    public System.Collections.Generic.ICollection<System.String> Keys { get { return default(System.Collections.Generic.ICollection<System.String>); } }
    public System.Collections.Generic.ICollection<System.Web.Mvc.ModelState> Values { get { return default(System.Collections.Generic.ICollection<System.Web.Mvc.ModelState>); } }
    public void Add(System.Collections.Generic.KeyValuePair<System.String, System.Web.Mvc.ModelState> item) { }
    public void Add(string key, System.Web.Mvc.ModelState value) { }
    public void AddModelError(string key, System.Exception exception) { }
    public void AddModelError(string key, string errorMessage) { }
    public void Clear() { }
    public bool Contains(System.Collections.Generic.KeyValuePair<System.String, System.Web.Mvc.ModelState> item) { return default(bool); }
    public bool ContainsKey(string key) { return default(bool); }
    public void CopyTo(System.Collections.Generic.KeyValuePair<System.String, System.Web.Mvc.ModelState>[] array, int arrayIndex) { }
    public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String, System.Web.Mvc.ModelState>> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String, System.Web.Mvc.ModelState>>); }
    public bool IsValidField(string key) { return default(bool); }
    public void Merge(System.Web.Mvc.ModelStateDictionary dictionary) { }
    public bool Remove(System.Collections.Generic.KeyValuePair<System.String, System.Web.Mvc.ModelState> item) { return default(bool); }
    public bool Remove(string key) { return default(bool); }
    public void SetModelValue(string key, System.Web.Mvc.ValueProviderResult value) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    public bool TryGetValue(string key, out System.Web.Mvc.ModelState value) { value = default(System.Web.Mvc.ModelState); return default(bool); }
  }
  public partial class ModelValidationResult {
    public ModelValidationResult() { }
    public string MemberName { get { return default(string); } set { } }
    public string Message { get { return default(string); } set { } }
  }
  public abstract partial class ModelValidator {
    protected ModelValidator(System.Web.Mvc.ModelMetadata metadata, System.Web.Mvc.ControllerContext controllerContext) { }
    protected internal System.Web.Mvc.ControllerContext ControllerContext { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Mvc.ControllerContext); } }
    public virtual bool IsRequired { get { return default(bool); } }
    protected internal System.Web.Mvc.ModelMetadata Metadata { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Mvc.ModelMetadata); } }
    public virtual System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelClientValidationRule> GetClientValidationRules() { return default(System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelClientValidationRule>); }
    public static System.Web.Mvc.ModelValidator GetModelValidator(System.Web.Mvc.ModelMetadata metadata, System.Web.Mvc.ControllerContext context) { return default(System.Web.Mvc.ModelValidator); }
    public abstract System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelValidationResult> Validate(object container);
  }
  public abstract partial class ModelValidatorProvider {
    protected ModelValidatorProvider() { }
    public abstract System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelValidator> GetValidators(System.Web.Mvc.ModelMetadata metadata, System.Web.Mvc.ControllerContext context);
  }
  public partial class ModelValidatorProviderCollection : System.Collections.ObjectModel.Collection<System.Web.Mvc.ModelValidatorProvider> {
    public ModelValidatorProviderCollection() { }
    public ModelValidatorProviderCollection(System.Collections.Generic.IList<System.Web.Mvc.ModelValidatorProvider> list) { }
    public System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelValidator> GetValidators(System.Web.Mvc.ModelMetadata metadata, System.Web.Mvc.ControllerContext context) { return default(System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelValidator>); }
    protected override void InsertItem(int index, System.Web.Mvc.ModelValidatorProvider item) { }
    protected override void SetItem(int index, System.Web.Mvc.ModelValidatorProvider item) { }
  }
  public static partial class ModelValidatorProviders {
    public static System.Web.Mvc.ModelValidatorProviderCollection Providers { get { return default(System.Web.Mvc.ModelValidatorProviderCollection); } }
  }
  public partial class MultiSelectList : System.Collections.Generic.IEnumerable<System.Web.Mvc.SelectListItem>, System.Collections.IEnumerable {
    public MultiSelectList(System.Collections.IEnumerable items) { }
    public MultiSelectList(System.Collections.IEnumerable items, System.Collections.IEnumerable selectedValues) { }
    public MultiSelectList(System.Collections.IEnumerable items, string dataValueField, string dataTextField) { }
    public MultiSelectList(System.Collections.IEnumerable items, string dataValueField, string dataTextField, System.Collections.IEnumerable selectedValues) { }
    public string DataTextField { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string DataValueField { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public System.Collections.IEnumerable Items { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.IEnumerable); } }
    public System.Collections.IEnumerable SelectedValues { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.IEnumerable); } }
    public virtual System.Collections.Generic.IEnumerator<System.Web.Mvc.SelectListItem> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Web.Mvc.SelectListItem>); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public partial class MvcHandler : System.Web.IHttpAsyncHandler, System.Web.IHttpHandler, System.Web.SessionState.IRequiresSessionState {
    public static readonly string MvcVersionHeaderName;
    public MvcHandler(System.Web.Routing.RequestContext requestContext) { }
    public static bool DisableMvcResponseHeader { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected virtual bool IsReusable { get { return default(bool); } }
    public System.Web.Routing.RequestContext RequestContext { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Routing.RequestContext); } }
    bool System.Web.IHttpHandler.IsReusable { get { return default(bool); } }
    protected internal virtual void AddVersionHeader(System.Web.HttpContextBase httpContext) { }
    protected virtual System.IAsyncResult BeginProcessRequest(System.Web.HttpContext httpContext, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected internal virtual System.IAsyncResult BeginProcessRequest(System.Web.HttpContextBase httpContext, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected internal virtual void EndProcessRequest(System.IAsyncResult asyncResult) { }
    protected virtual void ProcessRequest(System.Web.HttpContext httpContext) { }
    protected internal virtual void ProcessRequest(System.Web.HttpContextBase httpContext) { }
    System.IAsyncResult System.Web.IHttpAsyncHandler.BeginProcessRequest(System.Web.HttpContext context, System.AsyncCallback cb, object extraData) { return default(System.IAsyncResult); }
    void System.Web.IHttpAsyncHandler.EndProcessRequest(System.IAsyncResult result) { }
    void System.Web.IHttpHandler.ProcessRequest(System.Web.HttpContext httpContext) { }
  }
  public partial class MvcHtmlString {
    public static readonly System.Web.Mvc.MvcHtmlString Empty;
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("The recommended alternative is the static MvcHtmlString.Create(String value) method.")]
    protected MvcHtmlString(string value) { }
    public static System.Web.Mvc.MvcHtmlString Create(string value) { return default(System.Web.Mvc.MvcHtmlString); }
    public static bool IsNullOrEmpty(System.Web.Mvc.MvcHtmlString value) { return default(bool); }
    public string ToHtmlString() { return default(string); }
    public override string ToString() { return default(string); }
  }
  public partial class MvcHttpHandler : System.Web.Routing.UrlRoutingHandler, System.Web.IHttpAsyncHandler, System.Web.IHttpHandler, System.Web.SessionState.IRequiresSessionState {
    public MvcHttpHandler() { }
    protected virtual System.IAsyncResult BeginProcessRequest(System.Web.HttpContext httpContext, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected internal virtual System.IAsyncResult BeginProcessRequest(System.Web.HttpContextBase httpContext, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected internal virtual void EndProcessRequest(System.IAsyncResult asyncResult) { }
    System.IAsyncResult System.Web.IHttpAsyncHandler.BeginProcessRequest(System.Web.HttpContext context, System.AsyncCallback cb, object extraData) { return default(System.IAsyncResult); }
    void System.Web.IHttpAsyncHandler.EndProcessRequest(System.IAsyncResult result) { }
    protected override void VerifyAndProcessRequest(System.Web.IHttpHandler httpHandler, System.Web.HttpContextBase httpContext) { }
  }
  public partial class MvcRouteHandler : System.Web.Routing.IRouteHandler {
    public MvcRouteHandler() { }
    protected virtual System.Web.IHttpHandler GetHttpHandler(System.Web.Routing.RequestContext requestContext) { return default(System.Web.IHttpHandler); }
    System.Web.IHttpHandler System.Web.Routing.IRouteHandler.GetHttpHandler(System.Web.Routing.RequestContext requestContext) { return default(System.Web.IHttpHandler); }
  }
  public static partial class NameValueCollectionExtensions {
    public static void CopyTo(this System.Collections.Specialized.NameValueCollection collection, System.Collections.Generic.IDictionary<System.String, System.Object> destination) { }
    public static void CopyTo(this System.Collections.Specialized.NameValueCollection collection, System.Collections.Generic.IDictionary<System.String, System.Object> destination, bool replaceEntries) { }
  }
  public partial class NameValueCollectionValueProvider : System.Web.Mvc.IValueProvider {
    public NameValueCollectionValueProvider(System.Collections.Specialized.NameValueCollection collection, System.Globalization.CultureInfo culture) { }
    public virtual bool ContainsPrefix(string prefix) { return default(bool); }
    public virtual System.Web.Mvc.ValueProviderResult GetValue(string key) { return default(System.Web.Mvc.ValueProviderResult); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(68), Inherited=true, AllowMultiple=false)]
  public sealed partial class NoAsyncTimeoutAttribute : System.Web.Mvc.AsyncTimeoutAttribute {
    public NoAsyncTimeoutAttribute() : base (default(int)) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=false, Inherited=true)]
  public sealed partial class NonActionAttribute : System.Web.Mvc.ActionMethodSelectorAttribute {
    public NonActionAttribute() { }
    public override bool IsValidForRequest(System.Web.Mvc.ControllerContext controllerContext, System.Reflection.MethodInfo methodInfo) { return default(bool); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(68), Inherited=true, AllowMultiple=false)]
  public partial class OutputCacheAttribute : System.Web.Mvc.ActionFilterAttribute {
    public OutputCacheAttribute() { }
    public string CacheProfile { get { return default(string); } set { } }
    public int Duration { get { return default(int); } set { } }
    public System.Web.UI.OutputCacheLocation Location { get { return default(System.Web.UI.OutputCacheLocation); } set { } }
    public bool NoStore { get { return default(bool); } set { } }
    public string SqlDependency { get { return default(string); } set { } }
    public string VaryByContentEncoding { get { return default(string); } set { } }
    public string VaryByCustom { get { return default(string); } set { } }
    public string VaryByHeader { get { return default(string); } set { } }
    public string VaryByParam { get { return default(string); } set { } }
    public override void OnResultExecuting(System.Web.Mvc.ResultExecutingContext filterContext) { }
  }
  public abstract partial class ParameterBindingInfo {
    protected ParameterBindingInfo() { }
    public virtual System.Web.Mvc.IModelBinder Binder { get { return default(System.Web.Mvc.IModelBinder); } }
    public virtual System.Collections.Generic.ICollection<System.String> Exclude { get { return default(System.Collections.Generic.ICollection<System.String>); } }
    public virtual System.Collections.Generic.ICollection<System.String> Include { get { return default(System.Collections.Generic.ICollection<System.String>); } }
    public virtual string Prefix { get { return default(string); } }
  }
  public abstract partial class ParameterDescriptor : System.Reflection.ICustomAttributeProvider {
    protected ParameterDescriptor() { }
    public abstract System.Web.Mvc.ActionDescriptor ActionDescriptor { get; }
    public virtual System.Web.Mvc.ParameterBindingInfo BindingInfo { get { return default(System.Web.Mvc.ParameterBindingInfo); } }
    public virtual object DefaultValue { get { return default(object); } }
    public abstract string ParameterName { get; }
    public abstract System.Type ParameterType { get; }
    public virtual System.Object[] GetCustomAttributes(bool inherit) { return default(System.Object[]); }
    public virtual System.Object[] GetCustomAttributes(System.Type attributeType, bool inherit) { return default(System.Object[]); }
    public virtual bool IsDefined(System.Type attributeType, bool inherit) { return default(bool); }
  }
  public partial class PartialViewResult : System.Web.Mvc.ViewResultBase {
    public PartialViewResult() { }
    protected override System.Web.Mvc.ViewEngineResult FindView(System.Web.Mvc.ControllerContext context) { return default(System.Web.Mvc.ViewEngineResult); }
  }
  public sealed partial class QueryStringValueProvider : System.Web.Mvc.NameValueCollectionValueProvider {
    public QueryStringValueProvider(System.Web.Mvc.ControllerContext controllerContext) : base (default(System.Collections.Specialized.NameValueCollection), default(System.Globalization.CultureInfo)) { }
  }
  public sealed partial class QueryStringValueProviderFactory : System.Web.Mvc.ValueProviderFactory {
    public QueryStringValueProviderFactory() { }
    public override System.Web.Mvc.IValueProvider GetValueProvider(System.Web.Mvc.ControllerContext controllerContext) { return default(System.Web.Mvc.IValueProvider); }
  }
  public partial class RangeAttributeAdapter : System.Web.Mvc.DataAnnotationsModelValidator<System.ComponentModel.DataAnnotations.RangeAttribute> {
    public RangeAttributeAdapter(System.Web.Mvc.ModelMetadata metadata, System.Web.Mvc.ControllerContext context, System.ComponentModel.DataAnnotations.RangeAttribute attribute) : base (default(System.Web.Mvc.ModelMetadata), default(System.Web.Mvc.ControllerContext), default(System.ComponentModel.DataAnnotations.RangeAttribute)) { }
    public override System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelClientValidationRule> GetClientValidationRules() { return default(System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelClientValidationRule>); }
  }
  public partial class RedirectResult : System.Web.Mvc.ActionResult {
    public RedirectResult(string url) { }
    public string Url { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public override void ExecuteResult(System.Web.Mvc.ControllerContext context) { }
  }
  public partial class RedirectToRouteResult : System.Web.Mvc.ActionResult {
    public RedirectToRouteResult(string routeName, System.Web.Routing.RouteValueDictionary routeValues) { }
    public RedirectToRouteResult(System.Web.Routing.RouteValueDictionary routeValues) { }
    public string RouteName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public System.Web.Routing.RouteValueDictionary RouteValues { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Routing.RouteValueDictionary); } }
    public override void ExecuteResult(System.Web.Mvc.ControllerContext context) { }
  }
  public partial class ReflectedActionDescriptor : System.Web.Mvc.ActionDescriptor {
    public ReflectedActionDescriptor(System.Reflection.MethodInfo methodInfo, string actionName, System.Web.Mvc.ControllerDescriptor controllerDescriptor) { }
    public override string ActionName { get { return default(string); } }
    public override System.Web.Mvc.ControllerDescriptor ControllerDescriptor { get { return default(System.Web.Mvc.ControllerDescriptor); } }
    public System.Reflection.MethodInfo MethodInfo { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Reflection.MethodInfo); } }
    public override object Execute(System.Web.Mvc.ControllerContext controllerContext, System.Collections.Generic.IDictionary<System.String, System.Object> parameters) { return default(object); }
    public override System.Object[] GetCustomAttributes(bool inherit) { return default(System.Object[]); }
    public override System.Object[] GetCustomAttributes(System.Type attributeType, bool inherit) { return default(System.Object[]); }
    public override System.Web.Mvc.FilterInfo GetFilters() { return default(System.Web.Mvc.FilterInfo); }
    public override System.Web.Mvc.ParameterDescriptor[] GetParameters() { return default(System.Web.Mvc.ParameterDescriptor[]); }
    public override System.Collections.Generic.ICollection<System.Web.Mvc.ActionSelector> GetSelectors() { return default(System.Collections.Generic.ICollection<System.Web.Mvc.ActionSelector>); }
    public override bool IsDefined(System.Type attributeType, bool inherit) { return default(bool); }
  }
  public partial class ReflectedControllerDescriptor : System.Web.Mvc.ControllerDescriptor {
    public ReflectedControllerDescriptor(System.Type controllerType) { }
    public sealed override System.Type ControllerType { get { return default(System.Type); } }
    public override System.Web.Mvc.ActionDescriptor FindAction(System.Web.Mvc.ControllerContext controllerContext, string actionName) { return default(System.Web.Mvc.ActionDescriptor); }
    public override System.Web.Mvc.ActionDescriptor[] GetCanonicalActions() { return default(System.Web.Mvc.ActionDescriptor[]); }
    public override System.Object[] GetCustomAttributes(bool inherit) { return default(System.Object[]); }
    public override System.Object[] GetCustomAttributes(System.Type attributeType, bool inherit) { return default(System.Object[]); }
    public override bool IsDefined(System.Type attributeType, bool inherit) { return default(bool); }
  }
  public partial class ReflectedParameterDescriptor : System.Web.Mvc.ParameterDescriptor {
    public ReflectedParameterDescriptor(System.Reflection.ParameterInfo parameterInfo, System.Web.Mvc.ActionDescriptor actionDescriptor) { }
    public override System.Web.Mvc.ActionDescriptor ActionDescriptor { get { return default(System.Web.Mvc.ActionDescriptor); } }
    public override System.Web.Mvc.ParameterBindingInfo BindingInfo { get { return default(System.Web.Mvc.ParameterBindingInfo); } }
    public override object DefaultValue { get { return default(object); } }
    public System.Reflection.ParameterInfo ParameterInfo { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Reflection.ParameterInfo); } }
    public override string ParameterName { get { return default(string); } }
    public override System.Type ParameterType { get { return default(System.Type); } }
    public override System.Object[] GetCustomAttributes(bool inherit) { return default(System.Object[]); }
    public override System.Object[] GetCustomAttributes(System.Type attributeType, bool inherit) { return default(System.Object[]); }
    public override bool IsDefined(System.Type attributeType, bool inherit) { return default(bool); }
  }
  public partial class RegularExpressionAttributeAdapter : System.Web.Mvc.DataAnnotationsModelValidator<System.ComponentModel.DataAnnotations.RegularExpressionAttribute> {
    public RegularExpressionAttributeAdapter(System.Web.Mvc.ModelMetadata metadata, System.Web.Mvc.ControllerContext context, System.ComponentModel.DataAnnotations.RegularExpressionAttribute attribute) : base (default(System.Web.Mvc.ModelMetadata), default(System.Web.Mvc.ControllerContext), default(System.ComponentModel.DataAnnotations.RegularExpressionAttribute)) { }
    public override System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelClientValidationRule> GetClientValidationRules() { return default(System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelClientValidationRule>); }
  }
  public partial class RequiredAttributeAdapter : System.Web.Mvc.DataAnnotationsModelValidator<System.ComponentModel.DataAnnotations.RequiredAttribute> {
    public RequiredAttributeAdapter(System.Web.Mvc.ModelMetadata metadata, System.Web.Mvc.ControllerContext context, System.ComponentModel.DataAnnotations.RequiredAttribute attribute) : base (default(System.Web.Mvc.ModelMetadata), default(System.Web.Mvc.ControllerContext), default(System.ComponentModel.DataAnnotations.RequiredAttribute)) { }
    public override System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelClientValidationRule> GetClientValidationRules() { return default(System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelClientValidationRule>); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(68), Inherited=true, AllowMultiple=false)]
  public partial class RequireHttpsAttribute : System.Web.Mvc.FilterAttribute, System.Web.Mvc.IAuthorizationFilter {
    public RequireHttpsAttribute() { }
    protected virtual void HandleNonHttpsRequest(System.Web.Mvc.AuthorizationContext filterContext) { }
    public virtual void OnAuthorization(System.Web.Mvc.AuthorizationContext filterContext) { }
  }
  public partial class ResultExecutedContext : System.Web.Mvc.ControllerContext {
    public ResultExecutedContext() { }
    public ResultExecutedContext(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ActionResult result, bool canceled, System.Exception exception) { }
    public virtual bool Canceled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public virtual System.Exception Exception { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Exception); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool ExceptionHandled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public virtual System.Web.Mvc.ActionResult Result { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Mvc.ActionResult); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial class ResultExecutingContext : System.Web.Mvc.ControllerContext {
    public ResultExecutingContext() { }
    public ResultExecutingContext(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ActionResult result) { }
    public bool Cancel { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public virtual System.Web.Mvc.ActionResult Result { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Mvc.ActionResult); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public static partial class RouteCollectionExtensions {
    public static System.Web.Routing.VirtualPathData GetVirtualPathForArea(this System.Web.Routing.RouteCollection routes, System.Web.Routing.RequestContext requestContext, string name, System.Web.Routing.RouteValueDictionary values) { return default(System.Web.Routing.VirtualPathData); }
    public static System.Web.Routing.VirtualPathData GetVirtualPathForArea(this System.Web.Routing.RouteCollection routes, System.Web.Routing.RequestContext requestContext, System.Web.Routing.RouteValueDictionary values) { return default(System.Web.Routing.VirtualPathData); }
    public static void IgnoreRoute(this System.Web.Routing.RouteCollection routes, string url) { }
    public static void IgnoreRoute(this System.Web.Routing.RouteCollection routes, string url, object constraints) { }
    public static System.Web.Routing.Route MapRoute(this System.Web.Routing.RouteCollection routes, string name, string url) { return default(System.Web.Routing.Route); }
    public static System.Web.Routing.Route MapRoute(this System.Web.Routing.RouteCollection routes, string name, string url, object defaults) { return default(System.Web.Routing.Route); }
    public static System.Web.Routing.Route MapRoute(this System.Web.Routing.RouteCollection routes, string name, string url, object defaults, object constraints) { return default(System.Web.Routing.Route); }
    public static System.Web.Routing.Route MapRoute(this System.Web.Routing.RouteCollection routes, string name, string url, object defaults, object constraints, System.String[] namespaces) { return default(System.Web.Routing.Route); }
    public static System.Web.Routing.Route MapRoute(this System.Web.Routing.RouteCollection routes, string name, string url, object defaults, System.String[] namespaces) { return default(System.Web.Routing.Route); }
    public static System.Web.Routing.Route MapRoute(this System.Web.Routing.RouteCollection routes, string name, string url, System.String[] namespaces) { return default(System.Web.Routing.Route); }
  }
  public sealed partial class RouteDataValueProvider : System.Web.Mvc.DictionaryValueProvider<System.Object> {
    public RouteDataValueProvider(System.Web.Mvc.ControllerContext controllerContext) : base (default(System.Collections.Generic.IDictionary<System.String, System.Object>), default(System.Globalization.CultureInfo)) { }
  }
  public sealed partial class RouteDataValueProviderFactory : System.Web.Mvc.ValueProviderFactory {
    public RouteDataValueProviderFactory() { }
    public override System.Web.Mvc.IValueProvider GetValueProvider(System.Web.Mvc.ControllerContext controllerContext) { return default(System.Web.Mvc.IValueProvider); }
  }
  public partial class SelectList : System.Web.Mvc.MultiSelectList {
    public SelectList(System.Collections.IEnumerable items) : base (default(System.Collections.IEnumerable)) { }
    public SelectList(System.Collections.IEnumerable items, object selectedValue) : base (default(System.Collections.IEnumerable)) { }
    public SelectList(System.Collections.IEnumerable items, string dataValueField, string dataTextField) : base (default(System.Collections.IEnumerable)) { }
    public SelectList(System.Collections.IEnumerable items, string dataValueField, string dataTextField, object selectedValue) : base (default(System.Collections.IEnumerable)) { }
    public object SelectedValue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } }
  }
  public partial class SelectListItem {
    public SelectListItem() { }
    public bool Selected { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Text { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial class SessionStateTempDataProvider : System.Web.Mvc.ITempDataProvider {
    public SessionStateTempDataProvider() { }
    public virtual System.Collections.Generic.IDictionary<System.String, System.Object> LoadTempData(System.Web.Mvc.ControllerContext controllerContext) { return default(System.Collections.Generic.IDictionary<System.String, System.Object>); }
    public virtual void SaveTempData(System.Web.Mvc.ControllerContext controllerContext, System.Collections.Generic.IDictionary<System.String, System.Object> values) { }
  }
  public partial class StringLengthAttributeAdapter : System.Web.Mvc.DataAnnotationsModelValidator<System.ComponentModel.DataAnnotations.StringLengthAttribute> {
    public StringLengthAttributeAdapter(System.Web.Mvc.ModelMetadata metadata, System.Web.Mvc.ControllerContext context, System.ComponentModel.DataAnnotations.StringLengthAttribute attribute) : base (default(System.Web.Mvc.ModelMetadata), default(System.Web.Mvc.ControllerContext), default(System.ComponentModel.DataAnnotations.StringLengthAttribute)) { }
    public override System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelClientValidationRule> GetClientValidationRules() { return default(System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelClientValidationRule>); }
  }
  public partial class TagBuilder {
    public TagBuilder(string tagName) { }
    public System.Collections.Generic.IDictionary<System.String, System.String> Attributes { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IDictionary<System.String, System.String>); } }
    public string IdAttributeDotReplacement { get { return default(string); } set { } }
    public string InnerHtml { get { return default(string); } set { } }
    public string TagName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public void AddCssClass(string value) { }
    public void GenerateId(string name) { }
    public void MergeAttribute(string key, string value) { }
    public void MergeAttribute(string key, string value, bool replaceExisting) { }
    public void MergeAttributes<TKey, TValue>(System.Collections.Generic.IDictionary<TKey, TValue> attributes) { }
    public void MergeAttributes<TKey, TValue>(System.Collections.Generic.IDictionary<TKey, TValue> attributes, bool replaceExisting) { }
    public void SetInnerText(string innerText) { }
    public override string ToString() { return default(string); }
    public string ToString(System.Web.Mvc.TagRenderMode renderMode) { return default(string); }
  }
  public enum TagRenderMode {
    EndTag = 2,
    Normal = 0,
    SelfClosing = 3,
    StartTag = 1,
  }
  public partial class TempDataDictionary : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String, System.Object>>, System.Collections.Generic.IDictionary<System.String, System.Object>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>, System.Collections.IEnumerable, System.Runtime.Serialization.ISerializable {
    public TempDataDictionary() { }
    protected TempDataDictionary(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public int Count { get { return default(int); } }
    public object this[string key] { get { return default(object); } set { } }
    public System.Collections.Generic.ICollection<System.String> Keys { get { return default(System.Collections.Generic.ICollection<System.String>); } }
    bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string,object>>.IsReadOnly { get { return default(bool); } }
    public System.Collections.Generic.ICollection<System.Object> Values { get { return default(System.Collections.Generic.ICollection<System.Object>); } }
    public void Add(string key, object value) { }
    public void Clear() { }
    public bool ContainsKey(string key) { return default(bool); }
    public bool ContainsValue(object value) { return default(bool); }
    public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String, System.Object>> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String, System.Object>>); }
    protected virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public void Keep() { }
    public void Keep(string key) { }
    public void Load(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ITempDataProvider tempDataProvider) { }
    public object Peek(string key) { return default(object); }
    public bool Remove(string key) { return default(bool); }
    public void Save(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ITempDataProvider tempDataProvider) { }
    void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string,object>>.Add(System.Collections.Generic.KeyValuePair<System.String, System.Object> keyValuePair) { }
    bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string,object>>.Contains(System.Collections.Generic.KeyValuePair<System.String, System.Object> keyValuePair) { return default(bool); }
    void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string,object>>.CopyTo(System.Collections.Generic.KeyValuePair<System.String, System.Object>[] array, int index) { }
    bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string,object>>.Remove(System.Collections.Generic.KeyValuePair<System.String, System.Object> keyValuePair) { return default(bool); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public bool TryGetValue(string key, out object value) { value = default(object); return default(bool); }
  }
  public partial class TemplateInfo {
    public TemplateInfo() { }
    public object FormattedModelValue { get { return default(object); } set { } }
    public string HtmlFieldPrefix { get { return default(string); } set { } }
    public int TemplateDepth { get { return default(int); } }
    public string GetFullHtmlFieldId(string partialFieldName) { return default(string); }
    public string GetFullHtmlFieldName(string partialFieldName) { return default(string); }
    public bool Visited(System.Web.Mvc.ModelMetadata metadata) { return default(bool); }
  }
  public partial class UrlHelper {
    public UrlHelper(System.Web.Routing.RequestContext requestContext) { }
    public UrlHelper(System.Web.Routing.RequestContext requestContext, System.Web.Routing.RouteCollection routeCollection) { }
    public System.Web.Routing.RequestContext RequestContext { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Routing.RequestContext); } }
    public System.Web.Routing.RouteCollection RouteCollection { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Routing.RouteCollection); } }
    public string Action(string actionName) { return default(string); }
    public string Action(string actionName, object routeValues) { return default(string); }
    public string Action(string actionName, string controllerName) { return default(string); }
    public string Action(string actionName, string controllerName, object routeValues) { return default(string); }
    public string Action(string actionName, string controllerName, object routeValues, string protocol) { return default(string); }
    public string Action(string actionName, string controllerName, System.Web.Routing.RouteValueDictionary routeValues) { return default(string); }
    public string Action(string actionName, string controllerName, System.Web.Routing.RouteValueDictionary routeValues, string protocol, string hostName) { return default(string); }
    public string Action(string actionName, System.Web.Routing.RouteValueDictionary routeValues) { return default(string); }
    public string Content(string contentPath) { return default(string); }
    public string Encode(string url) { return default(string); }
    public static string GenerateContentUrl(string contentPath, System.Web.HttpContextBase httpContext) { return default(string); }
    public static string GenerateUrl(string routeName, string actionName, string controllerName, string protocol, string hostName, string fragment, System.Web.Routing.RouteValueDictionary routeValues, System.Web.Routing.RouteCollection routeCollection, System.Web.Routing.RequestContext requestContext, bool includeImplicitMvcValues) { return default(string); }
    public static string GenerateUrl(string routeName, string actionName, string controllerName, System.Web.Routing.RouteValueDictionary routeValues, System.Web.Routing.RouteCollection routeCollection, System.Web.Routing.RequestContext requestContext, bool includeImplicitMvcValues) { return default(string); }
    public string RouteUrl(object routeValues) { return default(string); }
    public string RouteUrl(string routeName) { return default(string); }
    public string RouteUrl(string routeName, object routeValues) { return default(string); }
    public string RouteUrl(string routeName, object routeValues, string protocol) { return default(string); }
    public string RouteUrl(string routeName, System.Web.Routing.RouteValueDictionary routeValues) { return default(string); }
    public string RouteUrl(string routeName, System.Web.Routing.RouteValueDictionary routeValues, string protocol, string hostName) { return default(string); }
    public string RouteUrl(System.Web.Routing.RouteValueDictionary routeValues) { return default(string); }
  }
  public sealed partial class UrlParameter {
    internal UrlParameter() { }
    public static readonly System.Web.Mvc.UrlParameter Optional;
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(68), AllowMultiple=false, Inherited=true)]
  public sealed partial class ValidateAntiForgeryTokenAttribute : System.Web.Mvc.FilterAttribute, System.Web.Mvc.IAuthorizationFilter {
    public ValidateAntiForgeryTokenAttribute() { }
    public string Salt { get { return default(string); } set { } }
    public void OnAuthorization(System.Web.Mvc.AuthorizationContext filterContext) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(68), Inherited=true, AllowMultiple=false)]
  public partial class ValidateInputAttribute : System.Web.Mvc.FilterAttribute, System.Web.Mvc.IAuthorizationFilter {
    public ValidateInputAttribute(bool enableValidation) { }
    public bool EnableValidation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    public virtual void OnAuthorization(System.Web.Mvc.AuthorizationContext filterContext) { }
  }
  public partial class ValueProviderCollection : System.Collections.ObjectModel.Collection<System.Web.Mvc.IValueProvider>, System.Web.Mvc.IValueProvider {
    public ValueProviderCollection() { }
    public ValueProviderCollection(System.Collections.Generic.IList<System.Web.Mvc.IValueProvider> list) { }
    public virtual bool ContainsPrefix(string prefix) { return default(bool); }
    public virtual System.Web.Mvc.ValueProviderResult GetValue(string key) { return default(System.Web.Mvc.ValueProviderResult); }
    protected override void InsertItem(int index, System.Web.Mvc.IValueProvider item) { }
    protected override void SetItem(int index, System.Web.Mvc.IValueProvider item) { }
  }
  [System.ObsoleteAttribute("The recommended alternative is to use one of the specific ValueProvider types, such as FormValueProvider.")]
  public partial class ValueProviderDictionary : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String, System.Web.Mvc.ValueProviderResult>>, System.Collections.Generic.IDictionary<System.String, System.Web.Mvc.ValueProviderResult>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Web.Mvc.ValueProviderResult>>, System.Collections.IEnumerable, System.Web.Mvc.IValueProvider {
    public ValueProviderDictionary(System.Web.Mvc.ControllerContext controllerContext) { }
    public System.Web.Mvc.ControllerContext ControllerContext { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Mvc.ControllerContext); } }
    public int Count { get { return default(int); } }
    public bool IsReadOnly { get { return default(bool); } }
    public System.Web.Mvc.ValueProviderResult this[string key] { get { return default(System.Web.Mvc.ValueProviderResult); } set { } }
    public System.Collections.Generic.ICollection<System.String> Keys { get { return default(System.Collections.Generic.ICollection<System.String>); } }
    public System.Collections.Generic.ICollection<System.Web.Mvc.ValueProviderResult> Values { get { return default(System.Collections.Generic.ICollection<System.Web.Mvc.ValueProviderResult>); } }
    public void Add(System.Collections.Generic.KeyValuePair<System.String, System.Web.Mvc.ValueProviderResult> item) { }
    public void Add(string key, object value) { }
    public void Add(string key, System.Web.Mvc.ValueProviderResult value) { }
    public void Clear() { }
    public bool Contains(System.Collections.Generic.KeyValuePair<System.String, System.Web.Mvc.ValueProviderResult> item) { return default(bool); }
    public bool ContainsKey(string key) { return default(bool); }
    public void CopyTo(System.Collections.Generic.KeyValuePair<System.String, System.Web.Mvc.ValueProviderResult>[] array, int arrayIndex) { }
    public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String, System.Web.Mvc.ValueProviderResult>> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String, System.Web.Mvc.ValueProviderResult>>); }
    public bool Remove(System.Collections.Generic.KeyValuePair<System.String, System.Web.Mvc.ValueProviderResult> item) { return default(bool); }
    public bool Remove(string key) { return default(bool); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    bool System.Web.Mvc.IValueProvider.ContainsPrefix(string prefix) { return default(bool); }
    System.Web.Mvc.ValueProviderResult System.Web.Mvc.IValueProvider.GetValue(string key) { return default(System.Web.Mvc.ValueProviderResult); }
    public bool TryGetValue(string key, out System.Web.Mvc.ValueProviderResult value) { value = default(System.Web.Mvc.ValueProviderResult); return default(bool); }
  }
  public static partial class ValueProviderFactories {
    public static System.Web.Mvc.ValueProviderFactoryCollection Factories { get { return default(System.Web.Mvc.ValueProviderFactoryCollection); } }
  }
  public abstract partial class ValueProviderFactory {
    protected ValueProviderFactory() { }
    public abstract System.Web.Mvc.IValueProvider GetValueProvider(System.Web.Mvc.ControllerContext controllerContext);
  }
  public partial class ValueProviderFactoryCollection : System.Collections.ObjectModel.Collection<System.Web.Mvc.ValueProviderFactory> {
    public ValueProviderFactoryCollection() { }
    public ValueProviderFactoryCollection(System.Collections.Generic.IList<System.Web.Mvc.ValueProviderFactory> list) { }
    public System.Web.Mvc.IValueProvider GetValueProvider(System.Web.Mvc.ControllerContext controllerContext) { return default(System.Web.Mvc.IValueProvider); }
    protected override void InsertItem(int index, System.Web.Mvc.ValueProviderFactory item) { }
    protected override void SetItem(int index, System.Web.Mvc.ValueProviderFactory item) { }
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
  public partial class ViewContext : System.Web.Mvc.ControllerContext {
    public ViewContext() { }
    public ViewContext(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.IView view, System.Web.Mvc.ViewDataDictionary viewData, System.Web.Mvc.TempDataDictionary tempData, System.IO.TextWriter writer) { }
    public virtual bool ClientValidationEnabled { get { return default(bool); } set { } }
    public virtual System.Web.Mvc.FormContext FormContext { get { return default(System.Web.Mvc.FormContext); } set { } }
    public virtual System.Web.Mvc.TempDataDictionary TempData { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Mvc.TempDataDictionary); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public virtual System.Web.Mvc.IView View { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Mvc.IView); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public virtual System.Web.Mvc.ViewDataDictionary ViewData { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Mvc.ViewDataDictionary); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public virtual System.IO.TextWriter Writer { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.IO.TextWriter); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public void OutputClientValidation() { }
  }
  public partial class ViewDataDictionary : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String, System.Object>>, System.Collections.Generic.IDictionary<System.String, System.Object>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>, System.Collections.IEnumerable {
    public ViewDataDictionary() { }
    public ViewDataDictionary(object model) { }
    public ViewDataDictionary(System.Web.Mvc.ViewDataDictionary dictionary) { }
    public int Count { get { return default(int); } }
    public bool IsReadOnly { get { return default(bool); } }
    public object this[string key] { get { return default(object); } set { } }
    public System.Collections.Generic.ICollection<System.String> Keys { get { return default(System.Collections.Generic.ICollection<System.String>); } }
    public object Model { get { return default(object); } set { } }
    public virtual System.Web.Mvc.ModelMetadata ModelMetadata { get { return default(System.Web.Mvc.ModelMetadata); } set { } }
    public System.Web.Mvc.ModelStateDictionary ModelState { get { return default(System.Web.Mvc.ModelStateDictionary); } }
    public System.Web.Mvc.TemplateInfo TemplateInfo { get { return default(System.Web.Mvc.TemplateInfo); } set { } }
    public System.Collections.Generic.ICollection<System.Object> Values { get { return default(System.Collections.Generic.ICollection<System.Object>); } }
    public void Add(System.Collections.Generic.KeyValuePair<System.String, System.Object> item) { }
    public void Add(string key, object value) { }
    public void Clear() { }
    public bool Contains(System.Collections.Generic.KeyValuePair<System.String, System.Object> item) { return default(bool); }
    public bool ContainsKey(string key) { return default(bool); }
    public void CopyTo(System.Collections.Generic.KeyValuePair<System.String, System.Object>[] array, int arrayIndex) { }
    public object Eval(string expression) { return default(object); }
    public string Eval(string expression, string format) { return default(string); }
    public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String, System.Object>> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String, System.Object>>); }
    public System.Web.Mvc.ViewDataInfo GetViewDataInfo(string expression) { return default(System.Web.Mvc.ViewDataInfo); }
    public bool Remove(System.Collections.Generic.KeyValuePair<System.String, System.Object> item) { return default(bool); }
    public bool Remove(string key) { return default(bool); }
    protected virtual void SetModel(object value) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    public bool TryGetValue(string key, out object value) { value = default(object); return default(bool); }
  }
  public partial class ViewDataDictionary<TModel> : System.Web.Mvc.ViewDataDictionary {
    public ViewDataDictionary() { }
    public ViewDataDictionary(TModel model) { }
    public ViewDataDictionary(System.Web.Mvc.ViewDataDictionary viewDataDictionary) { }
    public new TModel Model { get { return default(TModel); } set { } }
    public override System.Web.Mvc.ModelMetadata ModelMetadata { get { return default(System.Web.Mvc.ModelMetadata); } set { } }
    protected override void SetModel(object value) { }
  }
  public partial class ViewDataInfo {
    public ViewDataInfo() { }
    public ViewDataInfo(System.Func<System.Object> valueAccessor) { }
    public object Container { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.ComponentModel.PropertyDescriptor PropertyDescriptor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ComponentModel.PropertyDescriptor); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public object Value { get { return default(object); } set { } }
  }
  public partial class ViewEngineCollection : System.Collections.ObjectModel.Collection<System.Web.Mvc.IViewEngine> {
    public ViewEngineCollection() { }
    public ViewEngineCollection(System.Collections.Generic.IList<System.Web.Mvc.IViewEngine> list) { }
    public virtual System.Web.Mvc.ViewEngineResult FindPartialView(System.Web.Mvc.ControllerContext controllerContext, string partialViewName) { return default(System.Web.Mvc.ViewEngineResult); }
    public virtual System.Web.Mvc.ViewEngineResult FindView(System.Web.Mvc.ControllerContext controllerContext, string viewName, string masterName) { return default(System.Web.Mvc.ViewEngineResult); }
    protected override void InsertItem(int index, System.Web.Mvc.IViewEngine item) { }
    protected override void SetItem(int index, System.Web.Mvc.IViewEngine item) { }
  }
  public partial class ViewEngineResult {
    public ViewEngineResult(System.Collections.Generic.IEnumerable<System.String> searchedLocations) { }
    public ViewEngineResult(System.Web.Mvc.IView view, System.Web.Mvc.IViewEngine viewEngine) { }
    public System.Collections.Generic.IEnumerable<System.String> SearchedLocations { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IEnumerable<System.String>); } }
    public System.Web.Mvc.IView View { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Mvc.IView); } }
    public System.Web.Mvc.IViewEngine ViewEngine { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Mvc.IViewEngine); } }
  }
  public static partial class ViewEngines {
    public static System.Web.Mvc.ViewEngineCollection Engines { get { return default(System.Web.Mvc.ViewEngineCollection); } }
  }
  public partial class ViewMasterPage : System.Web.UI.MasterPage {
    public ViewMasterPage() { }
    public System.Web.Mvc.AjaxHelper<System.Object> Ajax { get { return default(System.Web.Mvc.AjaxHelper<System.Object>); } }
    public System.Web.Mvc.HtmlHelper<System.Object> Html { get { return default(System.Web.Mvc.HtmlHelper<System.Object>); } }
    public object Model { get { return default(object); } }
    public System.Web.Mvc.TempDataDictionary TempData { get { return default(System.Web.Mvc.TempDataDictionary); } }
    public System.Web.Mvc.UrlHelper Url { get { return default(System.Web.Mvc.UrlHelper); } }
    public System.Web.Mvc.ViewContext ViewContext { get { return default(System.Web.Mvc.ViewContext); } }
    public System.Web.Mvc.ViewDataDictionary ViewData { get { return default(System.Web.Mvc.ViewDataDictionary); } }
    public System.Web.UI.HtmlTextWriter Writer { get { return default(System.Web.UI.HtmlTextWriter); } }
  }
  public partial class ViewMasterPage<TModel> : System.Web.Mvc.ViewMasterPage {
    public ViewMasterPage() { }
    public new System.Web.Mvc.AjaxHelper<TModel> Ajax { get { return default(System.Web.Mvc.AjaxHelper<TModel>); } }
    public new System.Web.Mvc.HtmlHelper<TModel> Html { get { return default(System.Web.Mvc.HtmlHelper<TModel>); } }
    public new TModel Model { get { return default(TModel); } }
    public new System.Web.Mvc.ViewDataDictionary<TModel> ViewData { get { return default(System.Web.Mvc.ViewDataDictionary<TModel>); } }
  }
  [System.Web.UI.FileLevelControlBuilderAttribute(typeof(System.Web.Mvc.ViewPageControlBuilder))]
  public partial class ViewPage : System.Web.UI.Page, System.Web.Mvc.IViewDataContainer {
    public ViewPage() { }
    public System.Web.Mvc.AjaxHelper<System.Object> Ajax { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Mvc.AjaxHelper<System.Object>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Web.Mvc.HtmlHelper<System.Object> Html { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Mvc.HtmlHelper<System.Object>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string MasterLocation { get { return default(string); } set { } }
    public object Model { get { return default(object); } }
    public System.Web.Mvc.TempDataDictionary TempData { get { return default(System.Web.Mvc.TempDataDictionary); } }
    public System.Web.Mvc.UrlHelper Url { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Mvc.UrlHelper); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Web.Mvc.ViewContext ViewContext { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Mvc.ViewContext); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Web.Mvc.ViewDataDictionary ViewData { get { return default(System.Web.Mvc.ViewDataDictionary); } set { } }
    public System.Web.UI.HtmlTextWriter Writer { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.UI.HtmlTextWriter); } }
    public virtual void InitHelpers() { }
    protected override void OnPreInit(System.EventArgs e) { }
    public override void ProcessRequest(System.Web.HttpContext context) { }
    protected override void Render(System.Web.UI.HtmlTextWriter writer) { }
    public virtual void RenderView(System.Web.Mvc.ViewContext viewContext) { }
    [System.ObsoleteAttribute("The TextWriter is now provided by the ViewContext object passed to the RenderView method.", true)]
    public void SetTextWriter(System.IO.TextWriter textWriter) { }
    protected virtual void SetViewData(System.Web.Mvc.ViewDataDictionary viewData) { }
  }
  public partial class ViewPage<TModel> : System.Web.Mvc.ViewPage {
    public ViewPage() { }
    public new System.Web.Mvc.AjaxHelper<TModel> Ajax { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Mvc.AjaxHelper<TModel>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public new System.Web.Mvc.HtmlHelper<TModel> Html { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Mvc.HtmlHelper<TModel>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public new TModel Model { get { return default(TModel); } }
    public new System.Web.Mvc.ViewDataDictionary<TModel> ViewData { get { return default(System.Web.Mvc.ViewDataDictionary<TModel>); } set { } }
    public override void InitHelpers() { }
    protected override void SetViewData(System.Web.Mvc.ViewDataDictionary viewData) { }
  }
  public partial class ViewResult : System.Web.Mvc.ViewResultBase {
    public ViewResult() { }
    public string MasterName { get { return default(string); } set { } }
    protected override System.Web.Mvc.ViewEngineResult FindView(System.Web.Mvc.ControllerContext context) { return default(System.Web.Mvc.ViewEngineResult); }
  }
  public abstract partial class ViewResultBase : System.Web.Mvc.ActionResult {
    protected ViewResultBase() { }
    public System.Web.Mvc.TempDataDictionary TempData { get { return default(System.Web.Mvc.TempDataDictionary); } set { } }
    public System.Web.Mvc.IView View { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Mvc.IView); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Web.Mvc.ViewDataDictionary ViewData { get { return default(System.Web.Mvc.ViewDataDictionary); } set { } }
    public System.Web.Mvc.ViewEngineCollection ViewEngineCollection { get { return default(System.Web.Mvc.ViewEngineCollection); } set { } }
    public string ViewName { get { return default(string); } set { } }
    public override void ExecuteResult(System.Web.Mvc.ControllerContext context) { }
    protected abstract System.Web.Mvc.ViewEngineResult FindView(System.Web.Mvc.ControllerContext context);
  }
  public partial class ViewTemplateUserControl : System.Web.Mvc.ViewTemplateUserControl<System.Object> {
    public ViewTemplateUserControl() { }
  }
  public partial class ViewTemplateUserControl<TModel> : System.Web.Mvc.ViewUserControl<TModel> {
    public ViewTemplateUserControl() { }
    protected string FormattedModelValue { get { return default(string); } }
  }
  [System.Web.UI.ControlBuilderAttribute(typeof(System.Web.Mvc.ViewTypeControlBuilder))]
  [System.Web.UI.NonVisualControlAttribute]
  public partial class ViewType : System.Web.UI.Control {
    public ViewType() { }
    [System.ComponentModel.DefaultValueAttribute("")]
    public string TypeName { get { return default(string); } set { } }
  }
  [System.Web.UI.FileLevelControlBuilderAttribute(typeof(System.Web.Mvc.ViewUserControlControlBuilder))]
  public partial class ViewUserControl : System.Web.UI.UserControl, System.Web.Mvc.IViewDataContainer {
    public ViewUserControl() { }
    public System.Web.Mvc.AjaxHelper<System.Object> Ajax { get { return default(System.Web.Mvc.AjaxHelper<System.Object>); } }
    public System.Web.Mvc.HtmlHelper<System.Object> Html { get { return default(System.Web.Mvc.HtmlHelper<System.Object>); } }
    public object Model { get { return default(object); } }
    public System.Web.Mvc.TempDataDictionary TempData { get { return default(System.Web.Mvc.TempDataDictionary); } }
    public System.Web.Mvc.UrlHelper Url { get { return default(System.Web.Mvc.UrlHelper); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Web.Mvc.ViewContext ViewContext { get { return default(System.Web.Mvc.ViewContext); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Web.Mvc.ViewDataDictionary ViewData { get { return default(System.Web.Mvc.ViewDataDictionary); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    public string ViewDataKey { get { return default(string); } set { } }
    public System.Web.UI.HtmlTextWriter Writer { get { return default(System.Web.UI.HtmlTextWriter); } }
    protected void EnsureViewData() { }
    public virtual void RenderView(System.Web.Mvc.ViewContext viewContext) { }
    [System.ObsoleteAttribute("The TextWriter is now provided by the ViewContext object passed to the RenderView method.", true)]
    public void SetTextWriter(System.IO.TextWriter textWriter) { }
    protected virtual void SetViewData(System.Web.Mvc.ViewDataDictionary viewData) { }
  }
  public partial class ViewUserControl<TModel> : System.Web.Mvc.ViewUserControl {
    public ViewUserControl() { }
    public new System.Web.Mvc.AjaxHelper<TModel> Ajax { get { return default(System.Web.Mvc.AjaxHelper<TModel>); } }
    public new System.Web.Mvc.HtmlHelper<TModel> Html { get { return default(System.Web.Mvc.HtmlHelper<TModel>); } }
    public new TModel Model { get { return default(TModel); } }
    public new System.Web.Mvc.ViewDataDictionary<TModel> ViewData { get { return default(System.Web.Mvc.ViewDataDictionary<TModel>); } set { } }
    protected override void SetViewData(System.Web.Mvc.ViewDataDictionary viewData) { }
  }
  public abstract partial class VirtualPathProviderViewEngine : System.Web.Mvc.IViewEngine {
    protected VirtualPathProviderViewEngine() { }
    public System.String[] AreaMasterLocationFormats { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.String[]); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.String[] AreaPartialViewLocationFormats { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.String[]); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.String[] AreaViewLocationFormats { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.String[]); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.String[] MasterLocationFormats { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.String[]); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.String[] PartialViewLocationFormats { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.String[]); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Web.Mvc.IViewLocationCache ViewLocationCache { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Mvc.IViewLocationCache); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.String[] ViewLocationFormats { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.String[]); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected System.Web.Hosting.VirtualPathProvider VirtualPathProvider { get { return default(System.Web.Hosting.VirtualPathProvider); } set { } }
    protected abstract System.Web.Mvc.IView CreatePartialView(System.Web.Mvc.ControllerContext controllerContext, string partialPath);
    protected abstract System.Web.Mvc.IView CreateView(System.Web.Mvc.ControllerContext controllerContext, string viewPath, string masterPath);
    protected virtual bool FileExists(System.Web.Mvc.ControllerContext controllerContext, string virtualPath) { return default(bool); }
    public virtual System.Web.Mvc.ViewEngineResult FindPartialView(System.Web.Mvc.ControllerContext controllerContext, string partialViewName, bool useCache) { return default(System.Web.Mvc.ViewEngineResult); }
    public virtual System.Web.Mvc.ViewEngineResult FindView(System.Web.Mvc.ControllerContext controllerContext, string viewName, string masterName, bool useCache) { return default(System.Web.Mvc.ViewEngineResult); }
    public virtual void ReleaseView(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.IView view) { }
  }
  public partial class WebFormView : System.Web.Mvc.IView {
    public WebFormView(string viewPath) { }
    public WebFormView(string viewPath, string masterPath) { }
    public string MasterPath { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string ViewPath { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public virtual void Render(System.Web.Mvc.ViewContext viewContext, System.IO.TextWriter writer) { }
  }
  public partial class WebFormViewEngine : System.Web.Mvc.VirtualPathProviderViewEngine {
    public WebFormViewEngine() { }
    protected override System.Web.Mvc.IView CreatePartialView(System.Web.Mvc.ControllerContext controllerContext, string partialPath) { return default(System.Web.Mvc.IView); }
    protected override System.Web.Mvc.IView CreateView(System.Web.Mvc.ControllerContext controllerContext, string viewPath, string masterPath) { return default(System.Web.Mvc.IView); }
    protected override bool FileExists(System.Web.Mvc.ControllerContext controllerContext, string virtualPath) { return default(bool); }
  }
}
namespace System.Web.Mvc.Ajax {
  public static partial class AjaxExtensions {
    public static System.Web.Mvc.MvcHtmlString ActionLink(this System.Web.Mvc.AjaxHelper ajaxHelper, string linkText, string actionName, object routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString ActionLink(this System.Web.Mvc.AjaxHelper ajaxHelper, string linkText, string actionName, object routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions, object htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString ActionLink(this System.Web.Mvc.AjaxHelper ajaxHelper, string linkText, string actionName, string controllerName, object routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString ActionLink(this System.Web.Mvc.AjaxHelper ajaxHelper, string linkText, string actionName, string controllerName, object routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions, object htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString ActionLink(this System.Web.Mvc.AjaxHelper ajaxHelper, string linkText, string actionName, string controllerName, string protocol, string hostName, string fragment, object routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions, object htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString ActionLink(this System.Web.Mvc.AjaxHelper ajaxHelper, string linkText, string actionName, string controllerName, string protocol, string hostName, string fragment, System.Web.Routing.RouteValueDictionary routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString ActionLink(this System.Web.Mvc.AjaxHelper ajaxHelper, string linkText, string actionName, string controllerName, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString ActionLink(this System.Web.Mvc.AjaxHelper ajaxHelper, string linkText, string actionName, string controllerName, System.Web.Routing.RouteValueDictionary routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString ActionLink(this System.Web.Mvc.AjaxHelper ajaxHelper, string linkText, string actionName, string controllerName, System.Web.Routing.RouteValueDictionary routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString ActionLink(this System.Web.Mvc.AjaxHelper ajaxHelper, string linkText, string actionName, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString ActionLink(this System.Web.Mvc.AjaxHelper ajaxHelper, string linkText, string actionName, System.Web.Routing.RouteValueDictionary routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString ActionLink(this System.Web.Mvc.AjaxHelper ajaxHelper, string linkText, string actionName, System.Web.Routing.RouteValueDictionary routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.Html.MvcForm BeginForm(this System.Web.Mvc.AjaxHelper ajaxHelper, string actionName, object routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions) { return default(System.Web.Mvc.Html.MvcForm); }
    public static System.Web.Mvc.Html.MvcForm BeginForm(this System.Web.Mvc.AjaxHelper ajaxHelper, string actionName, object routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions, object htmlAttributes) { return default(System.Web.Mvc.Html.MvcForm); }
    public static System.Web.Mvc.Html.MvcForm BeginForm(this System.Web.Mvc.AjaxHelper ajaxHelper, string actionName, string controllerName, object routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions) { return default(System.Web.Mvc.Html.MvcForm); }
    public static System.Web.Mvc.Html.MvcForm BeginForm(this System.Web.Mvc.AjaxHelper ajaxHelper, string actionName, string controllerName, object routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions, object htmlAttributes) { return default(System.Web.Mvc.Html.MvcForm); }
    public static System.Web.Mvc.Html.MvcForm BeginForm(this System.Web.Mvc.AjaxHelper ajaxHelper, string actionName, string controllerName, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions) { return default(System.Web.Mvc.Html.MvcForm); }
    public static System.Web.Mvc.Html.MvcForm BeginForm(this System.Web.Mvc.AjaxHelper ajaxHelper, string actionName, string controllerName, System.Web.Routing.RouteValueDictionary routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions) { return default(System.Web.Mvc.Html.MvcForm); }
    public static System.Web.Mvc.Html.MvcForm BeginForm(this System.Web.Mvc.AjaxHelper ajaxHelper, string actionName, string controllerName, System.Web.Routing.RouteValueDictionary routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.Mvc.Html.MvcForm); }
    public static System.Web.Mvc.Html.MvcForm BeginForm(this System.Web.Mvc.AjaxHelper ajaxHelper, string actionName, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions) { return default(System.Web.Mvc.Html.MvcForm); }
    public static System.Web.Mvc.Html.MvcForm BeginForm(this System.Web.Mvc.AjaxHelper ajaxHelper, string actionName, System.Web.Routing.RouteValueDictionary routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions) { return default(System.Web.Mvc.Html.MvcForm); }
    public static System.Web.Mvc.Html.MvcForm BeginForm(this System.Web.Mvc.AjaxHelper ajaxHelper, string actionName, System.Web.Routing.RouteValueDictionary routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.Mvc.Html.MvcForm); }
    public static System.Web.Mvc.Html.MvcForm BeginForm(this System.Web.Mvc.AjaxHelper ajaxHelper, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions) { return default(System.Web.Mvc.Html.MvcForm); }
    public static System.Web.Mvc.Html.MvcForm BeginRouteForm(this System.Web.Mvc.AjaxHelper ajaxHelper, string routeName, object routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions) { return default(System.Web.Mvc.Html.MvcForm); }
    public static System.Web.Mvc.Html.MvcForm BeginRouteForm(this System.Web.Mvc.AjaxHelper ajaxHelper, string routeName, object routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions, object htmlAttributes) { return default(System.Web.Mvc.Html.MvcForm); }
    public static System.Web.Mvc.Html.MvcForm BeginRouteForm(this System.Web.Mvc.AjaxHelper ajaxHelper, string routeName, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions) { return default(System.Web.Mvc.Html.MvcForm); }
    public static System.Web.Mvc.Html.MvcForm BeginRouteForm(this System.Web.Mvc.AjaxHelper ajaxHelper, string routeName, System.Web.Routing.RouteValueDictionary routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions) { return default(System.Web.Mvc.Html.MvcForm); }
    public static System.Web.Mvc.Html.MvcForm BeginRouteForm(this System.Web.Mvc.AjaxHelper ajaxHelper, string routeName, System.Web.Routing.RouteValueDictionary routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.Mvc.Html.MvcForm); }
    public static System.Web.Mvc.MvcHtmlString GlobalizationScript(this System.Web.Mvc.AjaxHelper ajaxHelper) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString GlobalizationScript(this System.Web.Mvc.AjaxHelper ajaxHelper, System.Globalization.CultureInfo cultureInfo) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString RouteLink(this System.Web.Mvc.AjaxHelper ajaxHelper, string linkText, object routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString RouteLink(this System.Web.Mvc.AjaxHelper ajaxHelper, string linkText, object routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions, object htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString RouteLink(this System.Web.Mvc.AjaxHelper ajaxHelper, string linkText, string routeName, object routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString RouteLink(this System.Web.Mvc.AjaxHelper ajaxHelper, string linkText, string routeName, object routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions, object htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString RouteLink(this System.Web.Mvc.AjaxHelper ajaxHelper, string linkText, string routeName, string protocol, string hostName, string fragment, System.Web.Routing.RouteValueDictionary routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString RouteLink(this System.Web.Mvc.AjaxHelper ajaxHelper, string linkText, string routeName, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString RouteLink(this System.Web.Mvc.AjaxHelper ajaxHelper, string linkText, string routeName, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString RouteLink(this System.Web.Mvc.AjaxHelper ajaxHelper, string linkText, string routeName, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions, object htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString RouteLink(this System.Web.Mvc.AjaxHelper ajaxHelper, string linkText, string routeName, System.Web.Routing.RouteValueDictionary routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString RouteLink(this System.Web.Mvc.AjaxHelper ajaxHelper, string linkText, string routeName, System.Web.Routing.RouteValueDictionary routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString RouteLink(this System.Web.Mvc.AjaxHelper ajaxHelper, string linkText, System.Web.Routing.RouteValueDictionary routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString RouteLink(this System.Web.Mvc.AjaxHelper ajaxHelper, string linkText, System.Web.Routing.RouteValueDictionary routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
  }
  public partial class AjaxOptions {
    public AjaxOptions() { }
    public string Confirm { get { return default(string); } set { } }
    public string HttpMethod { get { return default(string); } set { } }
    public System.Web.Mvc.Ajax.InsertionMode InsertionMode { get { return default(System.Web.Mvc.Ajax.InsertionMode); } set { } }
    public string LoadingElementId { get { return default(string); } set { } }
    public string OnBegin { get { return default(string); } set { } }
    public string OnComplete { get { return default(string); } set { } }
    public string OnFailure { get { return default(string); } set { } }
    public string OnSuccess { get { return default(string); } set { } }
    public string UpdateTargetId { get { return default(string); } set { } }
    public string Url { get { return default(string); } set { } }
  }
  public enum InsertionMode {
    InsertAfter = 2,
    InsertBefore = 1,
    Replace = 0,
  }
}
namespace System.Web.Mvc.Async {
  public abstract partial class AsyncActionDescriptor : System.Web.Mvc.ActionDescriptor {
    protected AsyncActionDescriptor() { }
    public abstract System.IAsyncResult BeginExecute(System.Web.Mvc.ControllerContext controllerContext, System.Collections.Generic.IDictionary<System.String, System.Object> parameters, System.AsyncCallback callback, object state);
    public abstract object EndExecute(System.IAsyncResult asyncResult);
    public override object Execute(System.Web.Mvc.ControllerContext controllerContext, System.Collections.Generic.IDictionary<System.String, System.Object> parameters) { return default(object); }
  }
  public partial class AsyncControllerActionInvoker : System.Web.Mvc.ControllerActionInvoker, System.Web.Mvc.Async.IAsyncActionInvoker, System.Web.Mvc.IActionInvoker {
    public AsyncControllerActionInvoker() { }
    public virtual System.IAsyncResult BeginInvokeAction(System.Web.Mvc.ControllerContext controllerContext, string actionName, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected internal virtual System.IAsyncResult BeginInvokeActionMethod(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ActionDescriptor actionDescriptor, System.Collections.Generic.IDictionary<System.String, System.Object> parameters, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected internal virtual System.IAsyncResult BeginInvokeActionMethodWithFilters(System.Web.Mvc.ControllerContext controllerContext, System.Collections.Generic.IList<System.Web.Mvc.IActionFilter> filters, System.Web.Mvc.ActionDescriptor actionDescriptor, System.Collections.Generic.IDictionary<System.String, System.Object> parameters, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public virtual bool EndInvokeAction(System.IAsyncResult asyncResult) { return default(bool); }
    protected internal virtual System.Web.Mvc.ActionResult EndInvokeActionMethod(System.IAsyncResult asyncResult) { return default(System.Web.Mvc.ActionResult); }
    protected internal virtual System.Web.Mvc.ActionExecutedContext EndInvokeActionMethodWithFilters(System.IAsyncResult asyncResult) { return default(System.Web.Mvc.ActionExecutedContext); }
    protected override System.Web.Mvc.ControllerDescriptor GetControllerDescriptor(System.Web.Mvc.ControllerContext controllerContext) { return default(System.Web.Mvc.ControllerDescriptor); }
  }
  public partial class AsyncManager {
    public AsyncManager() { }
    public AsyncManager(System.Threading.SynchronizationContext syncContext) { }
    public System.Web.Mvc.Async.OperationCounter OutstandingOperations { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Mvc.Async.OperationCounter); } }
    public System.Collections.Generic.IDictionary<System.String, System.Object> Parameters { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IDictionary<System.String, System.Object>); } }
    public int Timeout { get { return default(int); } set { } }
    public event System.EventHandler Finished { add { } remove { } }
    public virtual void Finish() { }
    public virtual void Sync(System.Action action) { }
  }
  public partial interface IAsyncActionInvoker : System.Web.Mvc.IActionInvoker {
    System.IAsyncResult BeginInvokeAction(System.Web.Mvc.ControllerContext controllerContext, string actionName, System.AsyncCallback callback, object state);
    bool EndInvokeAction(System.IAsyncResult asyncResult);
  }
  public partial interface IAsyncController : System.Web.Mvc.IController {
    System.IAsyncResult BeginExecute(System.Web.Routing.RequestContext requestContext, System.AsyncCallback callback, object state);
    void EndExecute(System.IAsyncResult asyncResult);
  }
  public partial interface IAsyncManagerContainer {
    System.Web.Mvc.Async.AsyncManager AsyncManager { get; }
  }
  public sealed partial class OperationCounter {
    public OperationCounter() { }
    public int Count { get { return default(int); } }
    public event System.EventHandler Completed { add { } remove { } }
    public int Decrement() { return default(int); }
    public int Decrement(int value) { return default(int); }
    public int Increment() { return default(int); }
    public int Increment(int value) { return default(int); }
  }
  public partial class ReflectedAsyncActionDescriptor : System.Web.Mvc.Async.AsyncActionDescriptor {
    public ReflectedAsyncActionDescriptor(System.Reflection.MethodInfo asyncMethodInfo, System.Reflection.MethodInfo completedMethodInfo, string actionName, System.Web.Mvc.ControllerDescriptor controllerDescriptor) { }
    public override string ActionName { get { return default(string); } }
    public System.Reflection.MethodInfo AsyncMethodInfo { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Reflection.MethodInfo); } }
    public System.Reflection.MethodInfo CompletedMethodInfo { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Reflection.MethodInfo); } }
    public override System.Web.Mvc.ControllerDescriptor ControllerDescriptor { get { return default(System.Web.Mvc.ControllerDescriptor); } }
    public override System.IAsyncResult BeginExecute(System.Web.Mvc.ControllerContext controllerContext, System.Collections.Generic.IDictionary<System.String, System.Object> parameters, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public override object EndExecute(System.IAsyncResult asyncResult) { return default(object); }
    public override System.Object[] GetCustomAttributes(bool inherit) { return default(System.Object[]); }
    public override System.Object[] GetCustomAttributes(System.Type attributeType, bool inherit) { return default(System.Object[]); }
    public override System.Web.Mvc.FilterInfo GetFilters() { return default(System.Web.Mvc.FilterInfo); }
    public override System.Web.Mvc.ParameterDescriptor[] GetParameters() { return default(System.Web.Mvc.ParameterDescriptor[]); }
    public override System.Collections.Generic.ICollection<System.Web.Mvc.ActionSelector> GetSelectors() { return default(System.Collections.Generic.ICollection<System.Web.Mvc.ActionSelector>); }
    public override bool IsDefined(System.Type attributeType, bool inherit) { return default(bool); }
  }
  public partial class ReflectedAsyncControllerDescriptor : System.Web.Mvc.ControllerDescriptor {
    public ReflectedAsyncControllerDescriptor(System.Type controllerType) { }
    public sealed override System.Type ControllerType { get { return default(System.Type); } }
    public override System.Web.Mvc.ActionDescriptor FindAction(System.Web.Mvc.ControllerContext controllerContext, string actionName) { return default(System.Web.Mvc.ActionDescriptor); }
    public override System.Web.Mvc.ActionDescriptor[] GetCanonicalActions() { return default(System.Web.Mvc.ActionDescriptor[]); }
    public override System.Object[] GetCustomAttributes(bool inherit) { return default(System.Object[]); }
    public override System.Object[] GetCustomAttributes(System.Type attributeType, bool inherit) { return default(System.Object[]); }
    public override bool IsDefined(System.Type attributeType, bool inherit) { return default(bool); }
  }
  public sealed partial class SynchronousOperationException : System.Web.HttpException {
    public SynchronousOperationException() { }
    public SynchronousOperationException(string message) { }
    public SynchronousOperationException(string message, System.Exception innerException) { }
  }
}
namespace System.Web.Mvc.Html {
  public static partial class ChildActionExtensions {
    public static System.Web.Mvc.MvcHtmlString Action(this System.Web.Mvc.HtmlHelper htmlHelper, string actionName) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString Action(this System.Web.Mvc.HtmlHelper htmlHelper, string actionName, object routeValues) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString Action(this System.Web.Mvc.HtmlHelper htmlHelper, string actionName, string controllerName) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString Action(this System.Web.Mvc.HtmlHelper htmlHelper, string actionName, string controllerName, object routeValues) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString Action(this System.Web.Mvc.HtmlHelper htmlHelper, string actionName, string controllerName, System.Web.Routing.RouteValueDictionary routeValues) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString Action(this System.Web.Mvc.HtmlHelper htmlHelper, string actionName, System.Web.Routing.RouteValueDictionary routeValues) { return default(System.Web.Mvc.MvcHtmlString); }
    public static void RenderAction(this System.Web.Mvc.HtmlHelper htmlHelper, string actionName) { }
    public static void RenderAction(this System.Web.Mvc.HtmlHelper htmlHelper, string actionName, object routeValues) { }
    public static void RenderAction(this System.Web.Mvc.HtmlHelper htmlHelper, string actionName, string controllerName) { }
    public static void RenderAction(this System.Web.Mvc.HtmlHelper htmlHelper, string actionName, string controllerName, object routeValues) { }
    public static void RenderAction(this System.Web.Mvc.HtmlHelper htmlHelper, string actionName, string controllerName, System.Web.Routing.RouteValueDictionary routeValues) { }
    public static void RenderAction(this System.Web.Mvc.HtmlHelper htmlHelper, string actionName, System.Web.Routing.RouteValueDictionary routeValues) { }
  }
  public static partial class DisplayExtensions {
    public static System.Web.Mvc.MvcHtmlString Display(this System.Web.Mvc.HtmlHelper html, string expression) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString Display(this System.Web.Mvc.HtmlHelper html, string expression, object additionalViewData) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString Display(this System.Web.Mvc.HtmlHelper html, string expression, string templateName) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString Display(this System.Web.Mvc.HtmlHelper html, string expression, string templateName, object additionalViewData) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString Display(this System.Web.Mvc.HtmlHelper html, string expression, string templateName, string htmlFieldName) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString Display(this System.Web.Mvc.HtmlHelper html, string expression, string templateName, string htmlFieldName, object additionalViewData) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString DisplayFor<TModel, TValue>(this System.Web.Mvc.HtmlHelper<TModel> html, System.Linq.Expressions.Expression<System.Func<TModel, TValue>> expression) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString DisplayFor<TModel, TValue>(this System.Web.Mvc.HtmlHelper<TModel> html, System.Linq.Expressions.Expression<System.Func<TModel, TValue>> expression, object additionalViewData) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString DisplayFor<TModel, TValue>(this System.Web.Mvc.HtmlHelper<TModel> html, System.Linq.Expressions.Expression<System.Func<TModel, TValue>> expression, string templateName) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString DisplayFor<TModel, TValue>(this System.Web.Mvc.HtmlHelper<TModel> html, System.Linq.Expressions.Expression<System.Func<TModel, TValue>> expression, string templateName, object additionalViewData) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString DisplayFor<TModel, TValue>(this System.Web.Mvc.HtmlHelper<TModel> html, System.Linq.Expressions.Expression<System.Func<TModel, TValue>> expression, string templateName, string htmlFieldName) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString DisplayFor<TModel, TValue>(this System.Web.Mvc.HtmlHelper<TModel> html, System.Linq.Expressions.Expression<System.Func<TModel, TValue>> expression, string templateName, string htmlFieldName, object additionalViewData) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString DisplayForModel(this System.Web.Mvc.HtmlHelper html) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString DisplayForModel(this System.Web.Mvc.HtmlHelper html, object additionalViewData) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString DisplayForModel(this System.Web.Mvc.HtmlHelper html, string templateName) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString DisplayForModel(this System.Web.Mvc.HtmlHelper html, string templateName, object additionalViewData) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString DisplayForModel(this System.Web.Mvc.HtmlHelper html, string templateName, string htmlFieldName) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString DisplayForModel(this System.Web.Mvc.HtmlHelper html, string templateName, string htmlFieldName, object additionalViewData) { return default(System.Web.Mvc.MvcHtmlString); }
  }
  public static partial class DisplayTextExtensions {
    public static System.Web.Mvc.MvcHtmlString DisplayText(this System.Web.Mvc.HtmlHelper html, string name) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString DisplayTextFor<TModel, TResult>(this System.Web.Mvc.HtmlHelper<TModel> html, System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression) { return default(System.Web.Mvc.MvcHtmlString); }
  }
  public static partial class EditorExtensions {
    public static System.Web.Mvc.MvcHtmlString Editor(this System.Web.Mvc.HtmlHelper html, string expression) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString Editor(this System.Web.Mvc.HtmlHelper html, string expression, object additionalViewData) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString Editor(this System.Web.Mvc.HtmlHelper html, string expression, string templateName) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString Editor(this System.Web.Mvc.HtmlHelper html, string expression, string templateName, object additionalViewData) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString Editor(this System.Web.Mvc.HtmlHelper html, string expression, string templateName, string htmlFieldName) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString Editor(this System.Web.Mvc.HtmlHelper html, string expression, string templateName, string htmlFieldName, object additionalViewData) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString EditorFor<TModel, TValue>(this System.Web.Mvc.HtmlHelper<TModel> html, System.Linq.Expressions.Expression<System.Func<TModel, TValue>> expression) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString EditorFor<TModel, TValue>(this System.Web.Mvc.HtmlHelper<TModel> html, System.Linq.Expressions.Expression<System.Func<TModel, TValue>> expression, object additionalViewData) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString EditorFor<TModel, TValue>(this System.Web.Mvc.HtmlHelper<TModel> html, System.Linq.Expressions.Expression<System.Func<TModel, TValue>> expression, string templateName) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString EditorFor<TModel, TValue>(this System.Web.Mvc.HtmlHelper<TModel> html, System.Linq.Expressions.Expression<System.Func<TModel, TValue>> expression, string templateName, object additionalViewData) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString EditorFor<TModel, TValue>(this System.Web.Mvc.HtmlHelper<TModel> html, System.Linq.Expressions.Expression<System.Func<TModel, TValue>> expression, string templateName, string htmlFieldName) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString EditorFor<TModel, TValue>(this System.Web.Mvc.HtmlHelper<TModel> html, System.Linq.Expressions.Expression<System.Func<TModel, TValue>> expression, string templateName, string htmlFieldName, object additionalViewData) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString EditorForModel(this System.Web.Mvc.HtmlHelper html) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString EditorForModel(this System.Web.Mvc.HtmlHelper html, object additionalViewData) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString EditorForModel(this System.Web.Mvc.HtmlHelper html, string templateName) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString EditorForModel(this System.Web.Mvc.HtmlHelper html, string templateName, object additionalViewData) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString EditorForModel(this System.Web.Mvc.HtmlHelper html, string templateName, string htmlFieldName) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString EditorForModel(this System.Web.Mvc.HtmlHelper html, string templateName, string htmlFieldName, object additionalViewData) { return default(System.Web.Mvc.MvcHtmlString); }
  }
  public static partial class FormExtensions {
    public static System.Web.Mvc.Html.MvcForm BeginForm(this System.Web.Mvc.HtmlHelper htmlHelper) { return default(System.Web.Mvc.Html.MvcForm); }
    public static System.Web.Mvc.Html.MvcForm BeginForm(this System.Web.Mvc.HtmlHelper htmlHelper, object routeValues) { return default(System.Web.Mvc.Html.MvcForm); }
    public static System.Web.Mvc.Html.MvcForm BeginForm(this System.Web.Mvc.HtmlHelper htmlHelper, string actionName, string controllerName) { return default(System.Web.Mvc.Html.MvcForm); }
    public static System.Web.Mvc.Html.MvcForm BeginForm(this System.Web.Mvc.HtmlHelper htmlHelper, string actionName, string controllerName, object routeValues) { return default(System.Web.Mvc.Html.MvcForm); }
    public static System.Web.Mvc.Html.MvcForm BeginForm(this System.Web.Mvc.HtmlHelper htmlHelper, string actionName, string controllerName, object routeValues, System.Web.Mvc.FormMethod method) { return default(System.Web.Mvc.Html.MvcForm); }
    public static System.Web.Mvc.Html.MvcForm BeginForm(this System.Web.Mvc.HtmlHelper htmlHelper, string actionName, string controllerName, object routeValues, System.Web.Mvc.FormMethod method, object htmlAttributes) { return default(System.Web.Mvc.Html.MvcForm); }
    public static System.Web.Mvc.Html.MvcForm BeginForm(this System.Web.Mvc.HtmlHelper htmlHelper, string actionName, string controllerName, System.Web.Mvc.FormMethod method) { return default(System.Web.Mvc.Html.MvcForm); }
    public static System.Web.Mvc.Html.MvcForm BeginForm(this System.Web.Mvc.HtmlHelper htmlHelper, string actionName, string controllerName, System.Web.Mvc.FormMethod method, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.Mvc.Html.MvcForm); }
    public static System.Web.Mvc.Html.MvcForm BeginForm(this System.Web.Mvc.HtmlHelper htmlHelper, string actionName, string controllerName, System.Web.Mvc.FormMethod method, object htmlAttributes) { return default(System.Web.Mvc.Html.MvcForm); }
    public static System.Web.Mvc.Html.MvcForm BeginForm(this System.Web.Mvc.HtmlHelper htmlHelper, string actionName, string controllerName, System.Web.Routing.RouteValueDictionary routeValues) { return default(System.Web.Mvc.Html.MvcForm); }
    public static System.Web.Mvc.Html.MvcForm BeginForm(this System.Web.Mvc.HtmlHelper htmlHelper, string actionName, string controllerName, System.Web.Routing.RouteValueDictionary routeValues, System.Web.Mvc.FormMethod method) { return default(System.Web.Mvc.Html.MvcForm); }
    public static System.Web.Mvc.Html.MvcForm BeginForm(this System.Web.Mvc.HtmlHelper htmlHelper, string actionName, string controllerName, System.Web.Routing.RouteValueDictionary routeValues, System.Web.Mvc.FormMethod method, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.Mvc.Html.MvcForm); }
    public static System.Web.Mvc.Html.MvcForm BeginForm(this System.Web.Mvc.HtmlHelper htmlHelper, System.Web.Routing.RouteValueDictionary routeValues) { return default(System.Web.Mvc.Html.MvcForm); }
    public static System.Web.Mvc.Html.MvcForm BeginRouteForm(this System.Web.Mvc.HtmlHelper htmlHelper, object routeValues) { return default(System.Web.Mvc.Html.MvcForm); }
    public static System.Web.Mvc.Html.MvcForm BeginRouteForm(this System.Web.Mvc.HtmlHelper htmlHelper, string routeName) { return default(System.Web.Mvc.Html.MvcForm); }
    public static System.Web.Mvc.Html.MvcForm BeginRouteForm(this System.Web.Mvc.HtmlHelper htmlHelper, string routeName, object routeValues) { return default(System.Web.Mvc.Html.MvcForm); }
    public static System.Web.Mvc.Html.MvcForm BeginRouteForm(this System.Web.Mvc.HtmlHelper htmlHelper, string routeName, object routeValues, System.Web.Mvc.FormMethod method) { return default(System.Web.Mvc.Html.MvcForm); }
    public static System.Web.Mvc.Html.MvcForm BeginRouteForm(this System.Web.Mvc.HtmlHelper htmlHelper, string routeName, object routeValues, System.Web.Mvc.FormMethod method, object htmlAttributes) { return default(System.Web.Mvc.Html.MvcForm); }
    public static System.Web.Mvc.Html.MvcForm BeginRouteForm(this System.Web.Mvc.HtmlHelper htmlHelper, string routeName, System.Web.Mvc.FormMethod method) { return default(System.Web.Mvc.Html.MvcForm); }
    public static System.Web.Mvc.Html.MvcForm BeginRouteForm(this System.Web.Mvc.HtmlHelper htmlHelper, string routeName, System.Web.Mvc.FormMethod method, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.Mvc.Html.MvcForm); }
    public static System.Web.Mvc.Html.MvcForm BeginRouteForm(this System.Web.Mvc.HtmlHelper htmlHelper, string routeName, System.Web.Mvc.FormMethod method, object htmlAttributes) { return default(System.Web.Mvc.Html.MvcForm); }
    public static System.Web.Mvc.Html.MvcForm BeginRouteForm(this System.Web.Mvc.HtmlHelper htmlHelper, string routeName, System.Web.Routing.RouteValueDictionary routeValues) { return default(System.Web.Mvc.Html.MvcForm); }
    public static System.Web.Mvc.Html.MvcForm BeginRouteForm(this System.Web.Mvc.HtmlHelper htmlHelper, string routeName, System.Web.Routing.RouteValueDictionary routeValues, System.Web.Mvc.FormMethod method) { return default(System.Web.Mvc.Html.MvcForm); }
    public static System.Web.Mvc.Html.MvcForm BeginRouteForm(this System.Web.Mvc.HtmlHelper htmlHelper, string routeName, System.Web.Routing.RouteValueDictionary routeValues, System.Web.Mvc.FormMethod method, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.Mvc.Html.MvcForm); }
    public static System.Web.Mvc.Html.MvcForm BeginRouteForm(this System.Web.Mvc.HtmlHelper htmlHelper, System.Web.Routing.RouteValueDictionary routeValues) { return default(System.Web.Mvc.Html.MvcForm); }
    public static void EndForm(this System.Web.Mvc.HtmlHelper htmlHelper) { }
  }
  public static partial class InputExtensions {
    public static System.Web.Mvc.MvcHtmlString CheckBox(this System.Web.Mvc.HtmlHelper htmlHelper, string name) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString CheckBox(this System.Web.Mvc.HtmlHelper htmlHelper, string name, bool isChecked) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString CheckBox(this System.Web.Mvc.HtmlHelper htmlHelper, string name, bool isChecked, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString CheckBox(this System.Web.Mvc.HtmlHelper htmlHelper, string name, bool isChecked, object htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString CheckBox(this System.Web.Mvc.HtmlHelper htmlHelper, string name, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString CheckBox(this System.Web.Mvc.HtmlHelper htmlHelper, string name, object htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString CheckBoxFor<TModel>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, System.Boolean>> expression) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString CheckBoxFor<TModel>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, System.Boolean>> expression, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString CheckBoxFor<TModel>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, System.Boolean>> expression, object htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString Hidden(this System.Web.Mvc.HtmlHelper htmlHelper, string name) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString Hidden(this System.Web.Mvc.HtmlHelper htmlHelper, string name, object value) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString Hidden(this System.Web.Mvc.HtmlHelper htmlHelper, string name, object value, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString Hidden(this System.Web.Mvc.HtmlHelper htmlHelper, string name, object value, object htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString HiddenFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString HiddenFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString HiddenFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression, object htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString Password(this System.Web.Mvc.HtmlHelper htmlHelper, string name) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString Password(this System.Web.Mvc.HtmlHelper htmlHelper, string name, object value) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString Password(this System.Web.Mvc.HtmlHelper htmlHelper, string name, object value, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString Password(this System.Web.Mvc.HtmlHelper htmlHelper, string name, object value, object htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString PasswordFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString PasswordFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString PasswordFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression, object htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString RadioButton(this System.Web.Mvc.HtmlHelper htmlHelper, string name, object value) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString RadioButton(this System.Web.Mvc.HtmlHelper htmlHelper, string name, object value, bool isChecked) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString RadioButton(this System.Web.Mvc.HtmlHelper htmlHelper, string name, object value, bool isChecked, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString RadioButton(this System.Web.Mvc.HtmlHelper htmlHelper, string name, object value, bool isChecked, object htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString RadioButton(this System.Web.Mvc.HtmlHelper htmlHelper, string name, object value, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString RadioButton(this System.Web.Mvc.HtmlHelper htmlHelper, string name, object value, object htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString RadioButtonFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression, object value) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString RadioButtonFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression, object value, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString RadioButtonFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression, object value, object htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString TextBox(this System.Web.Mvc.HtmlHelper htmlHelper, string name) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString TextBox(this System.Web.Mvc.HtmlHelper htmlHelper, string name, object value) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString TextBox(this System.Web.Mvc.HtmlHelper htmlHelper, string name, object value, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString TextBox(this System.Web.Mvc.HtmlHelper htmlHelper, string name, object value, object htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString TextBoxFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString TextBoxFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString TextBoxFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression, object htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
  }
  public static partial class LabelExtensions {
    public static System.Web.Mvc.MvcHtmlString Label(this System.Web.Mvc.HtmlHelper html, string expression) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString LabelFor<TModel, TValue>(this System.Web.Mvc.HtmlHelper<TModel> html, System.Linq.Expressions.Expression<System.Func<TModel, TValue>> expression) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString LabelForModel(this System.Web.Mvc.HtmlHelper html) { return default(System.Web.Mvc.MvcHtmlString); }
  }
  public static partial class LinkExtensions {
    public static System.Web.Mvc.MvcHtmlString ActionLink(this System.Web.Mvc.HtmlHelper htmlHelper, string linkText, string actionName) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString ActionLink(this System.Web.Mvc.HtmlHelper htmlHelper, string linkText, string actionName, object routeValues) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString ActionLink(this System.Web.Mvc.HtmlHelper htmlHelper, string linkText, string actionName, object routeValues, object htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString ActionLink(this System.Web.Mvc.HtmlHelper htmlHelper, string linkText, string actionName, string controllerName) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString ActionLink(this System.Web.Mvc.HtmlHelper htmlHelper, string linkText, string actionName, string controllerName, object routeValues, object htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString ActionLink(this System.Web.Mvc.HtmlHelper htmlHelper, string linkText, string actionName, string controllerName, string protocol, string hostName, string fragment, object routeValues, object htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString ActionLink(this System.Web.Mvc.HtmlHelper htmlHelper, string linkText, string actionName, string controllerName, string protocol, string hostName, string fragment, System.Web.Routing.RouteValueDictionary routeValues, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString ActionLink(this System.Web.Mvc.HtmlHelper htmlHelper, string linkText, string actionName, string controllerName, System.Web.Routing.RouteValueDictionary routeValues, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString ActionLink(this System.Web.Mvc.HtmlHelper htmlHelper, string linkText, string actionName, System.Web.Routing.RouteValueDictionary routeValues) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString ActionLink(this System.Web.Mvc.HtmlHelper htmlHelper, string linkText, string actionName, System.Web.Routing.RouteValueDictionary routeValues, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString RouteLink(this System.Web.Mvc.HtmlHelper htmlHelper, string linkText, object routeValues) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString RouteLink(this System.Web.Mvc.HtmlHelper htmlHelper, string linkText, object routeValues, object htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString RouteLink(this System.Web.Mvc.HtmlHelper htmlHelper, string linkText, string routeName) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString RouteLink(this System.Web.Mvc.HtmlHelper htmlHelper, string linkText, string routeName, object routeValues) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString RouteLink(this System.Web.Mvc.HtmlHelper htmlHelper, string linkText, string routeName, object routeValues, object htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString RouteLink(this System.Web.Mvc.HtmlHelper htmlHelper, string linkText, string routeName, string protocol, string hostName, string fragment, object routeValues, object htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString RouteLink(this System.Web.Mvc.HtmlHelper htmlHelper, string linkText, string routeName, string protocol, string hostName, string fragment, System.Web.Routing.RouteValueDictionary routeValues, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString RouteLink(this System.Web.Mvc.HtmlHelper htmlHelper, string linkText, string routeName, System.Web.Routing.RouteValueDictionary routeValues) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString RouteLink(this System.Web.Mvc.HtmlHelper htmlHelper, string linkText, string routeName, System.Web.Routing.RouteValueDictionary routeValues, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString RouteLink(this System.Web.Mvc.HtmlHelper htmlHelper, string linkText, System.Web.Routing.RouteValueDictionary routeValues) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString RouteLink(this System.Web.Mvc.HtmlHelper htmlHelper, string linkText, System.Web.Routing.RouteValueDictionary routeValues, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
  }
  public partial class MvcForm : System.IDisposable {
    [System.ObsoleteAttribute("The recommended alternative is the constructor MvcForm(ViewContext viewContext).", true)]
    public MvcForm(System.Web.HttpResponseBase httpResponse) { }
    public MvcForm(System.Web.Mvc.ViewContext viewContext) { }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public void EndForm() { }
  }
  public static partial class PartialExtensions {
    public static System.Web.Mvc.MvcHtmlString Partial(this System.Web.Mvc.HtmlHelper htmlHelper, string partialViewName) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString Partial(this System.Web.Mvc.HtmlHelper htmlHelper, string partialViewName, object model) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString Partial(this System.Web.Mvc.HtmlHelper htmlHelper, string partialViewName, object model, System.Web.Mvc.ViewDataDictionary viewData) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString Partial(this System.Web.Mvc.HtmlHelper htmlHelper, string partialViewName, System.Web.Mvc.ViewDataDictionary viewData) { return default(System.Web.Mvc.MvcHtmlString); }
  }
  public static partial class RenderPartialExtensions {
    public static void RenderPartial(this System.Web.Mvc.HtmlHelper htmlHelper, string partialViewName) { }
    public static void RenderPartial(this System.Web.Mvc.HtmlHelper htmlHelper, string partialViewName, object model) { }
    public static void RenderPartial(this System.Web.Mvc.HtmlHelper htmlHelper, string partialViewName, object model, System.Web.Mvc.ViewDataDictionary viewData) { }
    public static void RenderPartial(this System.Web.Mvc.HtmlHelper htmlHelper, string partialViewName, System.Web.Mvc.ViewDataDictionary viewData) { }
  }
  public static partial class SelectExtensions {
    public static System.Web.Mvc.MvcHtmlString DropDownList(this System.Web.Mvc.HtmlHelper htmlHelper, string name) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString DropDownList(this System.Web.Mvc.HtmlHelper htmlHelper, string name, System.Collections.Generic.IEnumerable<System.Web.Mvc.SelectListItem> selectList) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString DropDownList(this System.Web.Mvc.HtmlHelper htmlHelper, string name, System.Collections.Generic.IEnumerable<System.Web.Mvc.SelectListItem> selectList, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString DropDownList(this System.Web.Mvc.HtmlHelper htmlHelper, string name, System.Collections.Generic.IEnumerable<System.Web.Mvc.SelectListItem> selectList, object htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString DropDownList(this System.Web.Mvc.HtmlHelper htmlHelper, string name, System.Collections.Generic.IEnumerable<System.Web.Mvc.SelectListItem> selectList, string optionLabel) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString DropDownList(this System.Web.Mvc.HtmlHelper htmlHelper, string name, System.Collections.Generic.IEnumerable<System.Web.Mvc.SelectListItem> selectList, string optionLabel, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString DropDownList(this System.Web.Mvc.HtmlHelper htmlHelper, string name, System.Collections.Generic.IEnumerable<System.Web.Mvc.SelectListItem> selectList, string optionLabel, object htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString DropDownList(this System.Web.Mvc.HtmlHelper htmlHelper, string name, string optionLabel) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString DropDownListFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression, System.Collections.Generic.IEnumerable<System.Web.Mvc.SelectListItem> selectList) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString DropDownListFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression, System.Collections.Generic.IEnumerable<System.Web.Mvc.SelectListItem> selectList, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString DropDownListFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression, System.Collections.Generic.IEnumerable<System.Web.Mvc.SelectListItem> selectList, object htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString DropDownListFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression, System.Collections.Generic.IEnumerable<System.Web.Mvc.SelectListItem> selectList, string optionLabel) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString DropDownListFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression, System.Collections.Generic.IEnumerable<System.Web.Mvc.SelectListItem> selectList, string optionLabel, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString DropDownListFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression, System.Collections.Generic.IEnumerable<System.Web.Mvc.SelectListItem> selectList, string optionLabel, object htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString ListBox(this System.Web.Mvc.HtmlHelper htmlHelper, string name) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString ListBox(this System.Web.Mvc.HtmlHelper htmlHelper, string name, System.Collections.Generic.IEnumerable<System.Web.Mvc.SelectListItem> selectList) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString ListBox(this System.Web.Mvc.HtmlHelper htmlHelper, string name, System.Collections.Generic.IEnumerable<System.Web.Mvc.SelectListItem> selectList, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString ListBox(this System.Web.Mvc.HtmlHelper htmlHelper, string name, System.Collections.Generic.IEnumerable<System.Web.Mvc.SelectListItem> selectList, object htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString ListBoxFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression, System.Collections.Generic.IEnumerable<System.Web.Mvc.SelectListItem> selectList) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString ListBoxFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression, System.Collections.Generic.IEnumerable<System.Web.Mvc.SelectListItem> selectList, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString ListBoxFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression, System.Collections.Generic.IEnumerable<System.Web.Mvc.SelectListItem> selectList, object htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
  }
  public static partial class TextAreaExtensions {
    public static System.Web.Mvc.MvcHtmlString TextArea(this System.Web.Mvc.HtmlHelper htmlHelper, string name) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString TextArea(this System.Web.Mvc.HtmlHelper htmlHelper, string name, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString TextArea(this System.Web.Mvc.HtmlHelper htmlHelper, string name, object htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString TextArea(this System.Web.Mvc.HtmlHelper htmlHelper, string name, string value) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString TextArea(this System.Web.Mvc.HtmlHelper htmlHelper, string name, string value, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString TextArea(this System.Web.Mvc.HtmlHelper htmlHelper, string name, string value, int rows, int columns, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString TextArea(this System.Web.Mvc.HtmlHelper htmlHelper, string name, string value, int rows, int columns, object htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString TextArea(this System.Web.Mvc.HtmlHelper htmlHelper, string name, string value, object htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString TextAreaFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString TextAreaFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString TextAreaFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression, int rows, int columns, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString TextAreaFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression, int rows, int columns, object htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString TextAreaFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression, object htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
  }
  public static partial class ValidationExtensions {
    public static string ResourceClassKey { get { return default(string); } set { } }
    public static void Validate(this System.Web.Mvc.HtmlHelper htmlHelper, string modelName) { }
    public static void ValidateFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression) { }
    public static System.Web.Mvc.MvcHtmlString ValidationMessage(this System.Web.Mvc.HtmlHelper htmlHelper, string modelName) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString ValidationMessage(this System.Web.Mvc.HtmlHelper htmlHelper, string modelName, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString ValidationMessage(this System.Web.Mvc.HtmlHelper htmlHelper, string modelName, object htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString ValidationMessage(this System.Web.Mvc.HtmlHelper htmlHelper, string modelName, string validationMessage) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString ValidationMessage(this System.Web.Mvc.HtmlHelper htmlHelper, string modelName, string validationMessage, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString ValidationMessage(this System.Web.Mvc.HtmlHelper htmlHelper, string modelName, string validationMessage, object htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString ValidationMessageFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString ValidationMessageFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression, string validationMessage) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString ValidationMessageFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression, string validationMessage, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString ValidationMessageFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression, string validationMessage, object htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString ValidationSummary(this System.Web.Mvc.HtmlHelper htmlHelper) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString ValidationSummary(this System.Web.Mvc.HtmlHelper htmlHelper, bool excludePropertyErrors) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString ValidationSummary(this System.Web.Mvc.HtmlHelper htmlHelper, bool excludePropertyErrors, string message) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString ValidationSummary(this System.Web.Mvc.HtmlHelper htmlHelper, bool excludePropertyErrors, string message, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString ValidationSummary(this System.Web.Mvc.HtmlHelper htmlHelper, bool excludePropertyErrors, string message, object htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString ValidationSummary(this System.Web.Mvc.HtmlHelper htmlHelper, string message) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString ValidationSummary(this System.Web.Mvc.HtmlHelper htmlHelper, string message, System.Collections.Generic.IDictionary<System.String, System.Object> htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
    public static System.Web.Mvc.MvcHtmlString ValidationSummary(this System.Web.Mvc.HtmlHelper htmlHelper, string message, object htmlAttributes) { return default(System.Web.Mvc.MvcHtmlString); }
  }
}
