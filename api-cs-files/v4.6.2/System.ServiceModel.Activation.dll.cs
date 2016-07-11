namespace System.ServiceModel {
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.ServiceModel, Version=3.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
  public static partial class ServiceHostingEnvironment {
    public static bool AspNetCompatibilityEnabled { get { return default(bool); } }
    public static bool MultipleSiteBindingsEnabled { get { return default(bool); } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public static void EnsureInitialized() { }
    public static void EnsureServiceAvailable(string virtualPath) { }
  }
}
namespace System.ServiceModel.Activation {
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.ServiceModel, Version=3.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
  public abstract partial class HostedTransportConfiguration {
    protected HostedTransportConfiguration() { }
    public abstract System.Uri[] GetBaseAddresses(string virtualPath);
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
  public sealed partial class ServiceActivationBuildProviderAttribute : System.Attribute {
    public ServiceActivationBuildProviderAttribute() { }
  }
  [System.Security.SecurityCriticalAttribute((System.Security.SecurityCriticalScope)(1))]
  [System.ServiceModel.Activation.ServiceActivationBuildProviderAttribute]
  [System.Web.Compilation.BuildProviderAppliesToAttribute((System.Web.Compilation.BuildProviderAppliesTo)(1))]
  public sealed partial class ServiceBuildProvider : System.Web.Compilation.BuildProvider {
    public ServiceBuildProvider() { }
    public override System.Web.Compilation.CompilerType CodeCompilerType { get { return default(System.Web.Compilation.CompilerType); } }
    public override System.Collections.ICollection VirtualPathDependencies { get { return default(System.Collections.ICollection); } }
    public override void GenerateCode(System.Web.Compilation.AssemblyBuilder assemblyBuilder) { }
    protected override System.CodeDom.CodeCompileUnit GetCodeCompileUnit(out System.Collections.IDictionary linePragmasTable) { linePragmasTable = default(System.Collections.IDictionary); return default(System.CodeDom.CodeCompileUnit); }
    public override string GetCustomString(System.CodeDom.Compiler.CompilerResults results) { return default(string); }
    public override System.Web.Compilation.BuildProviderResultFlags GetResultFlags(System.CodeDom.Compiler.CompilerResults results) { return default(System.Web.Compilation.BuildProviderResultFlags); }
  }
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.ServiceModel, Version=3.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
  public partial class ServiceHostFactory : System.ServiceModel.Activation.ServiceHostFactoryBase {
    public ServiceHostFactory() { }
    public override System.ServiceModel.ServiceHostBase CreateServiceHost(string constructorString, System.Uri[] baseAddresses) { return default(System.ServiceModel.ServiceHostBase); }
    protected virtual System.ServiceModel.ServiceHost CreateServiceHost(System.Type serviceType, System.Uri[] baseAddresses) { return default(System.ServiceModel.ServiceHost); }
  }
  public partial class ServiceRoute : System.Web.Routing.Route {
    public ServiceRoute(string routePrefix, System.ServiceModel.Activation.ServiceHostFactoryBase serviceHostFactory, System.Type serviceType) : base (default(string), default(System.Web.Routing.IRouteHandler)) { }
  }
}
namespace System.ServiceModel.Activities.Activation {
  public partial class WorkflowServiceHostFactory : System.ServiceModel.Activation.ServiceHostFactoryBase {
    public WorkflowServiceHostFactory() { }
    public override System.ServiceModel.ServiceHostBase CreateServiceHost(string constructorString, System.Uri[] baseAddresses) { return default(System.ServiceModel.ServiceHostBase); }
    protected virtual System.ServiceModel.Activities.WorkflowServiceHost CreateWorkflowServiceHost(System.Activities.Activity activity, System.Uri[] baseAddresses) { return default(System.ServiceModel.Activities.WorkflowServiceHost); }
    protected virtual System.ServiceModel.Activities.WorkflowServiceHost CreateWorkflowServiceHost(System.ServiceModel.Activities.WorkflowService service, System.Uri[] baseAddresses) { return default(System.ServiceModel.Activities.WorkflowServiceHost); }
  }
}
