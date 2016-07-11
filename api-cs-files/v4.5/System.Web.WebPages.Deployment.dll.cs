namespace System.Web.WebPages.Deployment {
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public static partial class PreApplicationStartCode {
    public static void Start() { }
  }
  public static partial class WebPagesDeployment {
    public static string GetAssemblyPath(System.Version version) { return default(string); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public static System.Collections.Generic.IDictionary<System.String, System.Version> GetIncompatibleDependencies(string appPath) { return default(System.Collections.Generic.IDictionary<System.String, System.Version>); }
    public static System.Version GetMaxVersion() { return default(System.Version); }
    [System.ObsoleteAttribute("This method is obsolete and is meant for legacy code. Use GetVersionWithoutEnabled instead.")]
    public static System.Version GetVersion(string path) { return default(System.Version); }
    public static System.Version GetVersionWithoutEnabledCheck(string path) { return default(System.Version); }
    public static System.Collections.Generic.IEnumerable<System.Reflection.AssemblyName> GetWebPagesAssemblies() { return default(System.Collections.Generic.IEnumerable<System.Reflection.AssemblyName>); }
    public static bool IsEnabled(string path) { return default(bool); }
    public static bool IsExplicitlyDisabled(string path) { return default(bool); }
  }
}
