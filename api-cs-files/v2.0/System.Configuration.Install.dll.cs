namespace System.Configuration.Install {
  public partial class AssemblyInstaller : System.Configuration.Install.Installer {
    public AssemblyInstaller() { }
    public AssemblyInstaller(System.Reflection.Assembly assembly, System.String[] commandLine) { }
    public AssemblyInstaller(string fileName, System.String[] commandLine) { }
    public System.Reflection.Assembly Assembly { get { return default(System.Reflection.Assembly); } set { } }
    public System.String[] CommandLine { get { return default(System.String[]); } set { } }
    public override string HelpText { get { return default(string); } }
    public string Path { get { return default(string); } set { } }
    public bool UseNewContext { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public static void CheckIfInstallable(string assemblyName) { }
    public override void Commit(System.Collections.IDictionary savedState) { }
    public override void Install(System.Collections.IDictionary savedState) { }
    public override void Rollback(System.Collections.IDictionary savedState) { }
    public override void Uninstall(System.Collections.IDictionary savedState) { }
  }
  public abstract partial class ComponentInstaller : System.Configuration.Install.Installer {
    protected ComponentInstaller() { }
    public abstract void CopyFromComponent(System.ComponentModel.IComponent component);
    [System.MonoTODOAttribute("Mono always returns false")]
    public virtual bool IsEquivalentInstaller(System.Configuration.Install.ComponentInstaller otherInstaller) { return default(bool); }
  }
  [System.Runtime.InteropServices.GuidAttribute("1E233FE7-C16D-4512-8C3B-2E9988F08D38")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
  public partial interface IManagedInstaller {
    int ManagedInstall(string commandLine, int hInstall);
  }
  public partial class InstallContext {
    public InstallContext() { }
    public InstallContext(string logFilePath, System.String[] commandLine) { }
    public System.Collections.Specialized.StringDictionary Parameters { get { return default(System.Collections.Specialized.StringDictionary); } }
    public bool IsParameterTrue(string paramName) { return default(bool); }
    public void LogMessage(string message) { }
    protected static System.Collections.Specialized.StringDictionary ParseCommandLine(System.String[] args) { return default(System.Collections.Specialized.StringDictionary); }
  }
  [System.ComponentModel.DefaultEventAttribute("AfterInstall")]
  public partial class Installer : System.ComponentModel.Component {
    public Installer() { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Configuration.Install.InstallContext Context { get { return default(System.Configuration.Install.InstallContext); } set { } }
    public virtual string HelpText { get { return default(string); } }
    public System.Configuration.Install.InstallerCollection Installers { get { return default(System.Configuration.Install.InstallerCollection); } }
    public System.Configuration.Install.Installer Parent { get { return default(System.Configuration.Install.Installer); } set { } }
    public event System.Configuration.Install.InstallEventHandler AfterInstall { add { } remove { } }
    public event System.Configuration.Install.InstallEventHandler AfterRollback { add { } remove { } }
    public event System.Configuration.Install.InstallEventHandler AfterUninstall { add { } remove { } }
    public event System.Configuration.Install.InstallEventHandler BeforeInstall { add { } remove { } }
    public event System.Configuration.Install.InstallEventHandler BeforeRollback { add { } remove { } }
    public event System.Configuration.Install.InstallEventHandler BeforeUninstall { add { } remove { } }
    public event System.Configuration.Install.InstallEventHandler Committed { add { } remove { } }
    public event System.Configuration.Install.InstallEventHandler Committing { add { } remove { } }
    public virtual void Commit(System.Collections.IDictionary savedState) { }
    public virtual void Install(System.Collections.IDictionary stateSaver) { }
    protected virtual void OnAfterInstall(System.Collections.IDictionary savedState) { }
    protected virtual void OnAfterRollback(System.Collections.IDictionary savedState) { }
    protected virtual void OnAfterUninstall(System.Collections.IDictionary savedState) { }
    protected virtual void OnBeforeInstall(System.Collections.IDictionary savedState) { }
    protected virtual void OnBeforeRollback(System.Collections.IDictionary savedState) { }
    protected virtual void OnBeforeUninstall(System.Collections.IDictionary savedState) { }
    protected virtual void OnCommitted(System.Collections.IDictionary savedState) { }
    protected virtual void OnCommitting(System.Collections.IDictionary savedState) { }
    public virtual void Rollback(System.Collections.IDictionary savedState) { }
    public virtual void Uninstall(System.Collections.IDictionary savedState) { }
  }
  public partial class InstallerCollection : System.Collections.CollectionBase {
    internal InstallerCollection() { }
    public System.Configuration.Install.Installer this[int index] { get { return default(System.Configuration.Install.Installer); } set { } }
    public int Add(System.Configuration.Install.Installer value) { return default(int); }
    public void AddRange(System.Configuration.Install.Installer[] value) { }
    public void AddRange(System.Configuration.Install.InstallerCollection value) { }
    public bool Contains(System.Configuration.Install.Installer value) { return default(bool); }
    public void CopyTo(System.Configuration.Install.Installer[] array, int index) { }
    public int IndexOf(System.Configuration.Install.Installer value) { return default(int); }
    public void Insert(int index, System.Configuration.Install.Installer value) { }
    protected override void OnInsert(int index, object value) { }
    protected override void OnRemove(int index, object value) { }
    protected override void OnSet(int index, object oldValue, object newValue) { }
    public void Remove(System.Configuration.Install.Installer value) { }
  }
  public partial class InstallEventArgs : System.EventArgs {
    public InstallEventArgs() { }
    public InstallEventArgs(System.Collections.IDictionary savedState) { }
    public System.Collections.IDictionary SavedState { get { return default(System.Collections.IDictionary); } }
  }
  public delegate void InstallEventHandler(object sender, System.Configuration.Install.InstallEventArgs e);
  public partial class InstallException : System.SystemException {
    public InstallException() { }
    protected InstallException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public InstallException(string message) { }
    public InstallException(string message, System.Exception innerException) { }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("42EB0342-0393-448f-84AA-D4BEB0283595")]
  public partial class ManagedInstallerClass : System.Configuration.Install.IManagedInstaller {
    public ManagedInstallerClass() { }
    [System.MonoTODOAttribute]
    public static void InstallHelper(System.String[] args) { }
    [System.MonoTODOAttribute]
    int System.Configuration.Install.IManagedInstaller.ManagedInstall(string argString, int hInstall) { return default(int); }
  }
  public partial class TransactedInstaller : System.Configuration.Install.Installer {
    public TransactedInstaller() { }
    public override void Install(System.Collections.IDictionary savedState) { }
    public override void Uninstall(System.Collections.IDictionary savedState) { }
  }
  public enum UninstallAction {
    NoAction = 1,
    Remove = 0,
  }
}
namespace System.Diagnostics {
  public partial class EventLogInstaller : System.Configuration.Install.ComponentInstaller {
    public EventLogInstaller() { }
    [System.MonoTODOAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public int CategoryCount { get { return default(int); } set { } }
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.FileNameEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute("System.Diagnostics.Design.StringValueConverter, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.MonoTODOAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public string CategoryResourceFile { get { return default(string); } set { } }
    [System.ComponentModel.TypeConverterAttribute("System.Diagnostics.Design.StringValueConverter, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    public string Log { get { return default(string); } set { } }
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.FileNameEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute("System.Diagnostics.Design.StringValueConverter, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.MonoTODOAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public string MessageResourceFile { get { return default(string); } set { } }
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.FileNameEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute("System.Diagnostics.Design.StringValueConverter, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.MonoTODOAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public string ParameterResourceFile { get { return default(string); } set { } }
    [System.ComponentModel.TypeConverterAttribute("System.Diagnostics.Design.StringValueConverter, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    public string Source { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Configuration.Install.UninstallAction)(0))]
    public System.Configuration.Install.UninstallAction UninstallAction { get { return default(System.Configuration.Install.UninstallAction); } set { } }
    [System.MonoTODOAttribute]
    public override void CopyFromComponent(System.ComponentModel.IComponent component) { }
    [System.MonoTODOAttribute]
    public override void Install(System.Collections.IDictionary stateSaver) { }
    [System.MonoTODOAttribute]
    public override bool IsEquivalentInstaller(System.Configuration.Install.ComponentInstaller otherInstaller) { return default(bool); }
    [System.MonoTODOAttribute]
    public override void Rollback(System.Collections.IDictionary savedState) { }
    [System.MonoTODOAttribute]
    public override void Uninstall(System.Collections.IDictionary savedState) { }
  }
  public partial class PerformanceCounterInstaller : System.Configuration.Install.ComponentInstaller {
    public PerformanceCounterInstaller() { }
    [System.ComponentModel.DefaultValueAttribute("")]
    public string CategoryHelp { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.TypeConverterAttribute("System.Diagnostics.Design.StringValueConverter, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    public string CategoryName { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Diagnostics.PerformanceCounterCategoryType)(-1))]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public System.Diagnostics.PerformanceCounterCategoryType CategoryType { get { return default(System.Diagnostics.PerformanceCounterCategoryType); } set { } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    public System.Diagnostics.CounterCreationDataCollection Counters { get { return default(System.Diagnostics.CounterCreationDataCollection); } }
    [System.ComponentModel.DefaultValueAttribute((System.Configuration.Install.UninstallAction)(0))]
    public System.Configuration.Install.UninstallAction UninstallAction { get { return default(System.Configuration.Install.UninstallAction); } set { } }
    [System.MonoTODOAttribute]
    public override void CopyFromComponent(System.ComponentModel.IComponent component) { }
    [System.MonoTODOAttribute]
    public override void Install(System.Collections.IDictionary stateSaver) { }
    [System.MonoTODOAttribute]
    public override void Rollback(System.Collections.IDictionary savedState) { }
    [System.MonoTODOAttribute]
    public override void Uninstall(System.Collections.IDictionary savedState) { }
  }
}
