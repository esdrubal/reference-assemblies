namespace System.ServiceModel {
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.ServiceModel, Version=3.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
  public static partial class ServiceHostingEnvironment {
    public static bool AspNetCompatibilityEnabled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    public static void EnsureServiceAvailable(string virtualPath) { }
  }
}
namespace System.ServiceModel.Activation {
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.ServiceModel, Version=3.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
  public partial class ServiceHostFactory : System.ServiceModel.Activation.ServiceHostFactoryBase {
    public ServiceHostFactory() { }
    [System.MonoTODOAttribute]
    public override System.ServiceModel.ServiceHostBase CreateServiceHost(string constructorString, System.Uri[] baseAddresses) { return default(System.ServiceModel.ServiceHostBase); }
    [System.MonoTODOAttribute("untested")]
    protected virtual System.ServiceModel.ServiceHost CreateServiceHost(System.Type serviceType, System.Uri[] baseAddresses) { return default(System.ServiceModel.ServiceHost); }
  }
}
