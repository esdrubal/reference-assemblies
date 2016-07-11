Unable to resolve assembly 'Assembly(Name=mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089)' referenced by 'Assembly(Name=Mono.XBuild.Tasks, Version=3.5.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756)'.
namespace Mono.PkgConfig {
  public partial interface IPcFileCacheContext : Mono.PkgConfig.IPcFileCacheContext<Mono.PkgConfig.PackageInfo> {
  }
  public partial interface IPcFileCacheContext<TP> where TP : Mono.PkgConfig.PackageInfo, new() {
    bool IsCustomDataComplete(string pcfile, TP pkg);
    void ReportError(string message, System.Exception ex);
    void StoreCustomData(Mono.PkgConfig.PcFile pcfile, TP pkg);
  }
  public partial class LibraryPackageInfo : Mono.PkgConfig.PackageInfo {
    public LibraryPackageInfo() { }
    public bool IsGacPackage { get { return default(bool); } set { } }
    protected internal override bool IsValidPackage { get { return default(bool); } }
  }
  public partial class LibraryPcFileCache : Mono.PkgConfig.PcFileCache<Mono.PkgConfig.LibraryPackageInfo> {
    public LibraryPcFileCache(Mono.PkgConfig.IPcFileCacheContext<Mono.PkgConfig.LibraryPackageInfo> ctx) : base (default(Mono.PkgConfig.IPcFileCacheContext<Mono.PkgConfig.LibraryPackageInfo>)) { }
    protected override string CacheDirectory { get { return default(string); } }
    public Mono.PkgConfig.PackageAssemblyInfo GetAssemblyLocation(string fullName) { return default(Mono.PkgConfig.PackageAssemblyInfo); }
    public Mono.PkgConfig.PackageAssemblyInfo GetAssemblyLocation(string fullName, System.Collections.Generic.IEnumerable<System.String> searchPaths) { return default(Mono.PkgConfig.PackageAssemblyInfo); }
    public static string NormalizeAsmName(string name) { return default(string); }
    protected override void ParsePackageInfo(Mono.PkgConfig.PcFile file, Mono.PkgConfig.LibraryPackageInfo pinfo) { }
    protected override void ReadPackageContent(System.Xml.XmlReader tr, Mono.PkgConfig.LibraryPackageInfo pinfo) { }
    public System.Collections.Generic.IEnumerable<Mono.PkgConfig.PackageAssemblyInfo> ResolveAssemblyName(string name) { return default(System.Collections.Generic.IEnumerable<Mono.PkgConfig.PackageAssemblyInfo>); }
    [System.Diagnostics.DebuggerHiddenAttribute]
    public System.Collections.Generic.IEnumerable<Mono.PkgConfig.PackageAssemblyInfo> ResolveAssemblyName(string name, System.Collections.Generic.IEnumerable<System.String> searchPaths) { return default(System.Collections.Generic.IEnumerable<Mono.PkgConfig.PackageAssemblyInfo>); }
    protected override void WritePackageContent(System.Xml.XmlTextWriter tw, string file, Mono.PkgConfig.LibraryPackageInfo pinfo) { }
  }
  public partial class PackageAssemblyInfo {
    public string Culture;
    public string Name;
    public string PublicKeyToken;
    public string Version;
    public PackageAssemblyInfo() { }
    public string File { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string FullName { get { return default(string); } }
    public Mono.PkgConfig.LibraryPackageInfo ParentPackage { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.PkgConfig.LibraryPackageInfo); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public void Update(System.Reflection.AssemblyName aname) { }
    public void UpdateFromFile(string file) { }
  }
  public partial class PackageInfo {
    public PackageInfo() { }
    public string Description { get { return default(string); } set { } }
    protected internal virtual bool IsValidPackage { get { return default(bool); } }
    public string Name { get { return default(string); } set { } }
    public string Requires { get { return default(string); } set { } }
    public string Version { get { return default(string); } set { } }
    public string GetData(string name) { return default(string); }
    public void RemoveData(string name) { }
    public void SetData(string name, string value) { }
  }
  public partial class PcFile {
    public PcFile() { }
    public string Description { get { return default(string); } set { } }
    public string FilePath { get { return default(string); } set { } }
    public bool HasErrors { get { return default(bool); } set { } }
    public string Libs { get { return default(string); } set { } }
    public string Name { get { return default(string); } set { } }
    public string Requires { get { return default(string); } set { } }
    public string Version { get { return default(string); } set { } }
    public string GetVariable(string varName) { return default(string); }
    public void Load(string pcfile) { }
  }
  public abstract partial class PcFileCache : Mono.PkgConfig.PcFileCache<Mono.PkgConfig.PackageInfo> {
    public PcFileCache(Mono.PkgConfig.IPcFileCacheContext ctx) : base (default(Mono.PkgConfig.IPcFileCacheContext<Mono.PkgConfig.PackageInfo>)) { }
  }
  public abstract partial class PcFileCache<TP> where TP : Mono.PkgConfig.PackageInfo, new() {
    public PcFileCache(Mono.PkgConfig.IPcFileCacheContext<TP> ctx) { }
    protected abstract string CacheDirectory { get; }
    public object SyncRoot { get { return default(object); } }
    public TP GetPackageInfo(string file) { return default(TP); }
    public TP GetPackageInfoByName(string name) { return default(TP); }
    public TP GetPackageInfoByName(string name, System.Collections.Generic.IEnumerable<System.String> pkgConfigDirs) { return default(TP); }
    public System.Collections.Generic.IEnumerable<TP> GetPackages() { return default(System.Collections.Generic.IEnumerable<TP>); }
    [System.Diagnostics.DebuggerHiddenAttribute]
    public System.Collections.Generic.IEnumerable<TP> GetPackages(System.Collections.Generic.IEnumerable<System.String> pkgConfigDirs) { return default(System.Collections.Generic.IEnumerable<TP>); }
    public System.Collections.Generic.IEnumerable<System.String> GetPkgconfigPaths(string prefix, string pkgConfigPath, string pkgConfigLibdir) { return default(System.Collections.Generic.IEnumerable<System.String>); }
    protected virtual void ParsePackageInfo(Mono.PkgConfig.PcFile file, TP pinfo) { }
    protected virtual void ReadPackageContent(System.Xml.XmlReader tr, TP pinfo) { }
    public void Save() { }
    public void Update() { }
    public void Update(System.Collections.Generic.IEnumerable<System.String> pkgConfigDirs) { }
    protected virtual void WritePackageContent(System.Xml.XmlTextWriter tw, string file, TP pinfo) { }
  }
}
