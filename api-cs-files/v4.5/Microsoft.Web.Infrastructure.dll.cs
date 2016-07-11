namespace Microsoft.Web.Infrastructure {
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public static partial class HttpContextHelper {
    [System.Security.SecuritySafeCriticalAttribute]
    public static void ExecuteInNullContext(System.Action action) { }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public static partial class InfrastructureHelper {
    [System.Security.SecuritySafeCriticalAttribute]
    public static bool IsCodeDomDefinedExtension(string extension) { return default(bool); }
    [System.Security.SecuritySafeCriticalAttribute]
    public static void UnloadAppDomain() { }
  }
}
namespace Microsoft.Web.Infrastructure.DynamicModuleHelper {
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public static partial class DynamicModuleUtility {
    [System.Security.SecuritySafeCriticalAttribute]
    public static void RegisterModule(System.Type moduleType) { }
  }
}
namespace Microsoft.Web.Infrastructure.DynamicValidationHelper {
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public static partial class ValidationUtility {
    [System.Security.SecuritySafeCriticalAttribute]
    public static void EnableDynamicValidation(System.Web.HttpContext context) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public static void GetUnvalidatedCollections(System.Web.HttpContext context, out System.Func<System.Collections.Specialized.NameValueCollection> formGetter, out System.Func<System.Collections.Specialized.NameValueCollection> queryStringGetter) { formGetter = default(System.Func<System.Collections.Specialized.NameValueCollection>); queryStringGetter = default(System.Func<System.Collections.Specialized.NameValueCollection>); }
    [System.Security.SecuritySafeCriticalAttribute]
    public static System.Nullable<System.Boolean> IsValidationEnabled(System.Web.HttpContext context) { return default(System.Nullable<System.Boolean>); }
  }
}
