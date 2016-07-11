namespace System.Management.Instrumentation {
  public partial class DefaultManagementInstaller : System.Configuration.Install.Installer {
    public DefaultManagementInstaller() { }
  }
  public static partial class InstrumentationManager {
    public static void Publish(object value) { }
    public static void RegisterAssembly(System.Reflection.Assembly managementAssembly) { }
    public static void RegisterType(System.Type managementType) { }
    public static void Revoke(object value) { }
    public static void UnregisterAssembly(System.Reflection.Assembly managementAssembly) { }
    public static void UnregisterType(System.Type managementType) { }
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(0))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("2A7B042D-578A-4366-9A3D-154C0498458E")]
  [System.Runtime.InteropServices.ProgIdAttribute("")]
  public partial class ManagedCommonProvider {
    public ManagedCommonProvider() { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
  public sealed partial class ManagementQualifierAttribute : System.Attribute {
    public ManagementQualifierAttribute(string name) { }
    public System.Management.Instrumentation.ManagementQualifierFlavors Flavor { get { return default(System.Management.Instrumentation.ManagementQualifierFlavors); } set { } }
    public string Name { get { return default(string); } }
    public object Value { get { return default(object); } set { } }
  }
  [System.FlagsAttribute]
  public enum ManagementQualifierFlavors {
    Amended = 1,
    ClassOnly = 4,
    DisableOverride = 2,
    ThisClassOnly = 8,
  }
  public partial class WmiProviderInstallationException : System.Exception {
    public WmiProviderInstallationException() { }
    protected WmiProviderInstallationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public WmiProviderInstallationException(string message) { }
    public WmiProviderInstallationException(string message, System.Exception innerException) { }
  }
}
