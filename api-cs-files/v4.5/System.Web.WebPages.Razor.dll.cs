namespace System.Web.WebPages.Razor {
  public partial class CompilingPathEventArgs : System.EventArgs {
    public CompilingPathEventArgs(string virtualPath, System.Web.WebPages.Razor.WebPageRazorHost host) { }
    public System.Web.WebPages.Razor.WebPageRazorHost Host { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.WebPages.Razor.WebPageRazorHost); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string VirtualPath { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public static partial class PreApplicationStartCode {
    public static void Start() { }
  }
  [System.Web.Compilation.BuildProviderAppliesToAttribute((System.Web.Compilation.BuildProviderAppliesTo)(3))]
  public partial class RazorBuildProvider : System.Web.Compilation.BuildProvider {
    public RazorBuildProvider() { }
    public System.Web.Compilation.AssemblyBuilder AssemblyBuilder { get { return default(System.Web.Compilation.AssemblyBuilder); } }
    public override System.Web.Compilation.CompilerType CodeCompilerType { get { return default(System.Web.Compilation.CompilerType); } }
    public new string VirtualPath { get { return default(string); } }
    public override System.Collections.ICollection VirtualPathDependencies { get { return default(System.Collections.ICollection); } }
    public static event System.EventHandler<System.Web.Razor.Generator.CodeGenerationCompleteEventArgs> CodeGenerationCompleted { add { } remove { } }
    public static event System.EventHandler CodeGenerationStarted { add { } remove { } }
    public static event System.EventHandler<System.Web.WebPages.Razor.CompilingPathEventArgs> CompilingPath { add { } remove { } }
    public void AddVirtualPathDependency(string dependency) { }
    protected internal virtual System.Web.WebPages.Razor.WebPageRazorHost CreateHost() { return default(System.Web.WebPages.Razor.WebPageRazorHost); }
    public override void GenerateCode(System.Web.Compilation.AssemblyBuilder assemblyBuilder) { }
    public override System.Type GetGeneratedType(System.CodeDom.Compiler.CompilerResults results) { return default(System.Type); }
    protected internal virtual System.Web.WebPages.Razor.WebPageRazorHost GetHostFromConfig() { return default(System.Web.WebPages.Razor.WebPageRazorHost); }
    protected internal virtual System.IO.TextReader InternalOpenReader() { return default(System.IO.TextReader); }
    protected virtual void OnBeforeCompilePath(System.Web.WebPages.Razor.CompilingPathEventArgs args) { }
  }
  public partial class WebCodeRazorHost : System.Web.WebPages.Razor.WebPageRazorHost {
    public WebCodeRazorHost(string virtualPath) : base (default(string)) { }
    public WebCodeRazorHost(string virtualPath, string physicalPath) : base (default(string)) { }
    protected override string GetClassName(string virtualPath) { return default(string); }
    public override void PostProcessGeneratedCode(System.Web.Razor.Generator.CodeGeneratorContext context) { }
  }
  public partial class WebPageRazorHost : System.Web.Razor.RazorEngineHost {
    public WebPageRazorHost(string virtualPath) { }
    public WebPageRazorHost(string virtualPath, string physicalPath) { }
    public override System.Web.Razor.RazorCodeLanguage CodeLanguage { get { return default(System.Web.Razor.RazorCodeLanguage); } protected set { } }
    public override string DefaultBaseClass { get { return default(string); } set { } }
    public override string DefaultClassName { get { return default(string); } set { } }
    public bool DefaultDebugCompilation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string DefaultPageBaseClass { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override string InstrumentedSourceFilePath { get { return default(string); } set { } }
    public bool IsSpecialPage { get { return default(bool); } }
    public string PhysicalPath { get { return default(string); } set { } }
    public string VirtualPath { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public static void AddGlobalImport(string ns) { }
    public override System.Web.Razor.Parser.ParserBase CreateMarkupParser() { return default(System.Web.Razor.Parser.ParserBase); }
    protected virtual string GetClassName(string virtualPath) { return default(string); }
    protected virtual System.Web.Razor.RazorCodeLanguage GetCodeLanguage() { return default(System.Web.Razor.RazorCodeLanguage); }
    public static System.Collections.Generic.IEnumerable<System.String> GetGlobalImports() { return default(System.Collections.Generic.IEnumerable<System.String>); }
    public override void PostProcessGeneratedCode(System.Web.Razor.Generator.CodeGeneratorContext context) { }
    protected void RegisterSpecialFile(string fileName, string baseTypeName) { }
    protected void RegisterSpecialFile(string fileName, System.Type baseType) { }
  }
  public partial class WebRazorHostFactory {
    public WebRazorHostFactory() { }
    public static void ApplyConfigurationToHost(System.Web.WebPages.Razor.Configuration.RazorPagesSection config, System.Web.WebPages.Razor.WebPageRazorHost host) { }
    public static System.Web.WebPages.Razor.WebPageRazorHost CreateDefaultHost(string virtualPath) { return default(System.Web.WebPages.Razor.WebPageRazorHost); }
    public static System.Web.WebPages.Razor.WebPageRazorHost CreateDefaultHost(string virtualPath, string physicalPath) { return default(System.Web.WebPages.Razor.WebPageRazorHost); }
    public virtual System.Web.WebPages.Razor.WebPageRazorHost CreateHost(string virtualPath, string physicalPath) { return default(System.Web.WebPages.Razor.WebPageRazorHost); }
    public static System.Web.WebPages.Razor.WebPageRazorHost CreateHostFromConfig(string virtualPath) { return default(System.Web.WebPages.Razor.WebPageRazorHost); }
    public static System.Web.WebPages.Razor.WebPageRazorHost CreateHostFromConfig(string virtualPath, string physicalPath) { return default(System.Web.WebPages.Razor.WebPageRazorHost); }
    public static System.Web.WebPages.Razor.WebPageRazorHost CreateHostFromConfig(System.Web.WebPages.Razor.Configuration.RazorWebSectionGroup config, string virtualPath) { return default(System.Web.WebPages.Razor.WebPageRazorHost); }
    public static System.Web.WebPages.Razor.WebPageRazorHost CreateHostFromConfig(System.Web.WebPages.Razor.Configuration.RazorWebSectionGroup config, string virtualPath, string physicalPath) { return default(System.Web.WebPages.Razor.WebPageRazorHost); }
  }
}
namespace System.Web.WebPages.Razor.Configuration {
  public partial class HostSection : System.Configuration.ConfigurationSection {
    public static readonly string SectionName;
    public HostSection() { }
    [System.Configuration.ConfigurationPropertyAttribute("factoryType", IsRequired=true, DefaultValue=null)]
    public string FactoryType { get { return default(string); } set { } }
  }
  public partial class RazorPagesSection : System.Configuration.ConfigurationSection {
    public static readonly string SectionName;
    public RazorPagesSection() { }
    [System.Configuration.ConfigurationPropertyAttribute("namespaces", IsRequired=true)]
    public System.Web.Configuration.NamespaceCollection Namespaces { get { return default(System.Web.Configuration.NamespaceCollection); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("pageBaseType", IsRequired=true)]
    public string PageBaseType { get { return default(string); } set { } }
  }
  public partial class RazorWebSectionGroup : System.Configuration.ConfigurationSectionGroup {
    public static readonly string GroupName;
    public RazorWebSectionGroup() { }
    [System.Configuration.ConfigurationPropertyAttribute("host", IsRequired=false)]
    public System.Web.WebPages.Razor.Configuration.HostSection Host { get { return default(System.Web.WebPages.Razor.Configuration.HostSection); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("pages", IsRequired=false)]
    public System.Web.WebPages.Razor.Configuration.RazorPagesSection Pages { get { return default(System.Web.WebPages.Razor.Configuration.RazorPagesSection); } set { } }
  }
}
