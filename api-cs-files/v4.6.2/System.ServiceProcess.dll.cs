namespace System.ServiceProcess {
  public enum PowerBroadcastStatus {
    BatteryLow = 9,
    OemEvent = 11,
    PowerStatusChange = 10,
    QuerySuspend = 0,
    QuerySuspendFailed = 2,
    ResumeAutomatic = 18,
    ResumeCritical = 6,
    ResumeSuspend = 7,
    Suspend = 4,
  }
  public enum ServiceAccount {
    LocalService = 0,
    LocalSystem = 2,
    NetworkService = 1,
    User = 3,
  }
  [System.ComponentModel.InstallerTypeAttribute(typeof(System.ServiceProcess.ServiceProcessInstaller))]
  public partial class ServiceBase : System.ComponentModel.Component {
    public const int MaxNameLength = 80;
    public ServiceBase() { }
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.ServiceProcess.ServiceProcessDescriptionAttribute("SBAutoLog")]
    public bool AutoLog { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool CanHandlePowerEvent { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public bool CanHandleSessionChangeEvent { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool CanPauseAndContinue { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool CanShutdown { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool CanStop { get { return default(bool); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public virtual System.Diagnostics.EventLog EventLog { get { return default(System.Diagnostics.EventLog); } }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public int ExitCode { get { return default(int); } set { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    protected System.IntPtr ServiceHandle { get { return default(System.IntPtr); } }
    [System.ComponentModel.TypeConverterAttribute("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ServiceProcess.ServiceProcessDescriptionAttribute("SBServiceName")]
    public string ServiceName { get { return default(string); } set { } }
    protected override void Dispose(bool disposing) { }
    protected virtual void OnContinue() { }
    protected virtual void OnCustomCommand(int command) { }
    protected virtual void OnPause() { }
    protected virtual bool OnPowerEvent(System.ServiceProcess.PowerBroadcastStatus powerStatus) { return default(bool); }
    protected virtual void OnSessionChange(System.ServiceProcess.SessionChangeDescription changeDescription) { }
    protected virtual void OnShutdown() { }
    protected virtual void OnStart(System.String[] args) { }
    protected virtual void OnStop() { }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public void RequestAdditionalTime(int milliseconds) { }
    public static void Run(System.ServiceProcess.ServiceBase service) { }
    public static void Run(System.ServiceProcess.ServiceBase[] services) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public void ServiceMainCallback(int argCount, System.IntPtr argPointer) { }
    public void Stop() { }
  }
  [System.ComponentModel.DesignerAttribute("System.ServiceProcess.Design.ServiceControllerDesigner, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [System.ServiceProcess.ServiceProcessDescriptionAttribute("ServiceControllerDesc")]
  public partial class ServiceController : System.ComponentModel.Component {
    public ServiceController() { }
    public ServiceController(string name) { }
    public ServiceController(string name, string machineName) { }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ServiceProcess.ServiceProcessDescriptionAttribute("SPCanPauseAndContinue")]
    public bool CanPauseAndContinue { get { return default(bool); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ServiceProcess.ServiceProcessDescriptionAttribute("SPCanShutdown")]
    public bool CanShutdown { get { return default(bool); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ServiceProcess.ServiceProcessDescriptionAttribute("SPCanStop")]
    public bool CanStop { get { return default(bool); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ServiceProcess.ServiceProcessDescriptionAttribute("SPDependentServices")]
    public System.ServiceProcess.ServiceController[] DependentServices { get { return default(System.ServiceProcess.ServiceController[]); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.ReadOnlyAttribute(true)]
    [System.ServiceProcess.ServiceProcessDescriptionAttribute("SPDisplayName")]
    public string DisplayName { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(".")]
    [System.ComponentModel.SettingsBindableAttribute(true)]
    [System.ServiceProcess.ServiceProcessDescriptionAttribute("SPMachineName")]
    public string MachineName { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Runtime.InteropServices.SafeHandle ServiceHandle { get { return default(System.Runtime.InteropServices.SafeHandle); } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.ReadOnlyAttribute(true)]
    [System.ComponentModel.SettingsBindableAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceProcess.Design.ServiceNameConverter))]
    [System.ServiceProcess.ServiceProcessDescriptionAttribute("SPServiceName")]
    public string ServiceName { get { return default(string); } set { } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ServiceProcess.ServiceProcessDescriptionAttribute("SPServicesDependedOn")]
    public System.ServiceProcess.ServiceController[] ServicesDependedOn { get { return default(System.ServiceProcess.ServiceController[]); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ServiceProcess.ServiceProcessDescriptionAttribute("SPServiceType")]
    public System.ServiceProcess.ServiceType ServiceType { get { return default(System.ServiceProcess.ServiceType); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ServiceProcess.ServiceProcessDescriptionAttribute("SPStartType")]
    public System.ServiceProcess.ServiceStartMode StartType { get { return default(System.ServiceProcess.ServiceStartMode); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ServiceProcess.ServiceProcessDescriptionAttribute("SPStatus")]
    public System.ServiceProcess.ServiceControllerStatus Status { get { return default(System.ServiceProcess.ServiceControllerStatus); } }
    public void Close() { }
    public void Continue() { }
    protected override void Dispose(bool disposing) { }
    public void ExecuteCommand(int command) { }
    public static System.ServiceProcess.ServiceController[] GetDevices() { return default(System.ServiceProcess.ServiceController[]); }
    public static System.ServiceProcess.ServiceController[] GetDevices(string machineName) { return default(System.ServiceProcess.ServiceController[]); }
    public static System.ServiceProcess.ServiceController[] GetServices() { return default(System.ServiceProcess.ServiceController[]); }
    public static System.ServiceProcess.ServiceController[] GetServices(string machineName) { return default(System.ServiceProcess.ServiceController[]); }
    public void Pause() { }
    public void Refresh() { }
    public void Start() { }
    public void Start(System.String[] args) { }
    public void Stop() { }
    public void WaitForStatus(System.ServiceProcess.ServiceControllerStatus desiredStatus) { }
    public void WaitForStatus(System.ServiceProcess.ServiceControllerStatus desiredStatus, System.TimeSpan timeout) { }
  }
  public sealed partial class ServiceControllerPermission : System.Security.Permissions.ResourcePermissionBase {
    public ServiceControllerPermission() { }
    public ServiceControllerPermission(System.Security.Permissions.PermissionState state) { }
    public ServiceControllerPermission(System.ServiceProcess.ServiceControllerPermissionAccess permissionAccess, string machineName, string serviceName) { }
    public ServiceControllerPermission(System.ServiceProcess.ServiceControllerPermissionEntry[] permissionAccessEntries) { }
    public System.ServiceProcess.ServiceControllerPermissionEntryCollection PermissionEntries { get { return default(System.ServiceProcess.ServiceControllerPermissionEntryCollection); } }
  }
  [System.FlagsAttribute]
  public enum ServiceControllerPermissionAccess {
    Browse = 2,
    Control = 6,
    None = 0,
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(621), AllowMultiple=true, Inherited=false)]
  public partial class ServiceControllerPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute {
    public ServiceControllerPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
    public string MachineName { get { return default(string); } set { } }
    public System.ServiceProcess.ServiceControllerPermissionAccess PermissionAccess { get { return default(System.ServiceProcess.ServiceControllerPermissionAccess); } set { } }
    public string ServiceName { get { return default(string); } set { } }
    public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
  }
  public partial class ServiceControllerPermissionEntry {
    public ServiceControllerPermissionEntry() { }
    public ServiceControllerPermissionEntry(System.ServiceProcess.ServiceControllerPermissionAccess permissionAccess, string machineName, string serviceName) { }
    public string MachineName { get { return default(string); } }
    public System.ServiceProcess.ServiceControllerPermissionAccess PermissionAccess { get { return default(System.ServiceProcess.ServiceControllerPermissionAccess); } }
    public string ServiceName { get { return default(string); } }
  }
  public partial class ServiceControllerPermissionEntryCollection : System.Collections.CollectionBase {
    internal ServiceControllerPermissionEntryCollection() { }
    public System.ServiceProcess.ServiceControllerPermissionEntry this[int index] { get { return default(System.ServiceProcess.ServiceControllerPermissionEntry); } set { } }
    public int Add(System.ServiceProcess.ServiceControllerPermissionEntry value) { return default(int); }
    public void AddRange(System.ServiceProcess.ServiceControllerPermissionEntry[] value) { }
    public void AddRange(System.ServiceProcess.ServiceControllerPermissionEntryCollection value) { }
    public bool Contains(System.ServiceProcess.ServiceControllerPermissionEntry value) { return default(bool); }
    public void CopyTo(System.ServiceProcess.ServiceControllerPermissionEntry[] array, int index) { }
    public int IndexOf(System.ServiceProcess.ServiceControllerPermissionEntry value) { return default(int); }
    public void Insert(int index, System.ServiceProcess.ServiceControllerPermissionEntry value) { }
    protected override void OnClear() { }
    protected override void OnInsert(int index, object value) { }
    protected override void OnRemove(int index, object value) { }
    protected override void OnSet(int index, object oldValue, object newValue) { }
    public void Remove(System.ServiceProcess.ServiceControllerPermissionEntry value) { }
  }
  public enum ServiceControllerStatus {
    ContinuePending = 5,
    Paused = 7,
    PausePending = 6,
    Running = 4,
    StartPending = 2,
    Stopped = 1,
    StopPending = 3,
  }
  public partial class ServiceInstaller : System.Configuration.Install.ComponentInstaller {
    public ServiceInstaller() { }
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.ServiceProcess.ServiceProcessDescriptionAttribute("ServiceInstallerDelayedAutoStart")]
    public bool DelayedAutoStart { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    [System.ServiceProcess.ServiceProcessDescriptionAttribute("ServiceInstallerDescription")]
    public string Description { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ServiceProcess.ServiceProcessDescriptionAttribute("ServiceInstallerDisplayName")]
    public string DisplayName { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.TypeConverterAttribute("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ServiceProcess.ServiceProcessDescriptionAttribute("ServiceInstallerServiceName")]
    public string ServiceName { get { return default(string); } set { } }
    [System.ServiceProcess.ServiceProcessDescriptionAttribute("ServiceInstallerServicesDependedOn")]
    public System.String[] ServicesDependedOn { get { return default(System.String[]); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceProcess.ServiceStartMode)(3))]
    [System.ServiceProcess.ServiceProcessDescriptionAttribute("ServiceInstallerStartType")]
    public System.ServiceProcess.ServiceStartMode StartType { get { return default(System.ServiceProcess.ServiceStartMode); } set { } }
    public override void CopyFromComponent(System.ComponentModel.IComponent component) { }
    public override void Install(System.Collections.IDictionary stateSaver) { }
    public override bool IsEquivalentInstaller(System.Configuration.Install.ComponentInstaller otherInstaller) { return default(bool); }
    public override void Rollback(System.Collections.IDictionary savedState) { }
    public override void Uninstall(System.Collections.IDictionary savedState) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(32767))]
  public partial class ServiceProcessDescriptionAttribute : System.ComponentModel.DescriptionAttribute {
    public ServiceProcessDescriptionAttribute(string description) { }
    public override string Description { get { return default(string); } }
  }
  public partial class ServiceProcessInstaller : System.Configuration.Install.ComponentInstaller {
    public ServiceProcessInstaller() { }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceProcess.ServiceAccount)(3))]
    [System.ServiceProcess.ServiceProcessDescriptionAttribute("ServiceProcessInstallerAccount")]
    public System.ServiceProcess.ServiceAccount Account { get { return default(System.ServiceProcess.ServiceAccount); } set { } }
    public override string HelpText { get { return default(string); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public string Password { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.TypeConverterAttribute("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    public string Username { get { return default(string); } set { } }
    public override void CopyFromComponent(System.ComponentModel.IComponent comp) { }
    public override void Install(System.Collections.IDictionary stateSaver) { }
    public override void Rollback(System.Collections.IDictionary savedState) { }
  }
  public enum ServiceStartMode {
    Automatic = 2,
    Boot = 0,
    Disabled = 4,
    Manual = 3,
    System = 1,
  }
  [System.FlagsAttribute]
  public enum ServiceType {
    Adapter = 4,
    FileSystemDriver = 2,
    InteractiveProcess = 256,
    KernelDriver = 1,
    RecognizerDriver = 8,
    Win32OwnProcess = 16,
    Win32ShareProcess = 32,
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct SessionChangeDescription {
    public System.ServiceProcess.SessionChangeReason Reason { get { return default(System.ServiceProcess.SessionChangeReason); } }
    public int SessionId { get { return default(int); } }
    public override bool Equals(object obj) { return default(bool); }
    public bool Equals(System.ServiceProcess.SessionChangeDescription changeDescription) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.ServiceProcess.SessionChangeDescription a, System.ServiceProcess.SessionChangeDescription b) { return default(bool); }
    public static bool operator !=(System.ServiceProcess.SessionChangeDescription a, System.ServiceProcess.SessionChangeDescription b) { return default(bool); }
  }
  public enum SessionChangeReason {
    ConsoleConnect = 1,
    ConsoleDisconnect = 2,
    RemoteConnect = 3,
    RemoteDisconnect = 4,
    SessionLock = 7,
    SessionLogoff = 6,
    SessionLogon = 5,
    SessionRemoteControl = 9,
    SessionUnlock = 8,
  }
  public partial class TimeoutException : System.SystemException {
    public TimeoutException() { }
    protected TimeoutException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public TimeoutException(string message) { }
    public TimeoutException(string message, System.Exception innerException) { }
  }
}
namespace System.ServiceProcess.Design {
  public partial class ServiceInstallerDialog : System.Windows.Forms.Form {
    public ServiceInstallerDialog() { }
    public string Password { get { return default(string); } set { } }
    public System.ServiceProcess.Design.ServiceInstallerDialogResult Result { get { return default(System.ServiceProcess.Design.ServiceInstallerDialogResult); } }
    public string Username { get { return default(string); } set { } }
    [System.STAThreadAttribute]
    public static void Main() { }
  }
  public enum ServiceInstallerDialogResult {
    Canceled = 2,
    OK = 0,
    UseSystem = 1,
  }
}
