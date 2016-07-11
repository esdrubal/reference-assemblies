namespace System.Deployment.Application {
  public sealed partial class ApplicationDeployment {
    internal ApplicationDeployment() { }
    public System.Uri ActivationUri { get { return default(System.Uri); } }
    public static System.Deployment.Application.ApplicationDeployment CurrentDeployment { get { return default(System.Deployment.Application.ApplicationDeployment); } }
    public System.Version CurrentVersion { get { return default(System.Version); } }
    public string DataDirectory { get { return default(string); } }
    public bool IsFirstRun { get { return default(bool); } }
    public static bool IsNetworkDeployed { get { return default(bool); } }
    public System.DateTime TimeOfLastUpdateCheck { get { return default(System.DateTime); } }
    public string UpdatedApplicationFullName { get { return default(string); } }
    public System.Version UpdatedVersion { get { return default(System.Version); } }
    public System.Uri UpdateLocation { get { return default(System.Uri); } }
    public event System.Deployment.Application.CheckForUpdateCompletedEventHandler CheckForUpdateCompleted { add { } remove { } }
    public event System.Deployment.Application.DeploymentProgressChangedEventHandler CheckForUpdateProgressChanged { add { } remove { } }
    public event System.Deployment.Application.DownloadFileGroupCompletedEventHandler DownloadFileGroupCompleted { add { } remove { } }
    public event System.Deployment.Application.DeploymentProgressChangedEventHandler DownloadFileGroupProgressChanged { add { } remove { } }
    public event System.ComponentModel.AsyncCompletedEventHandler UpdateCompleted { add { } remove { } }
    public event System.Deployment.Application.DeploymentProgressChangedEventHandler UpdateProgressChanged { add { } remove { } }
    public System.Deployment.Application.UpdateCheckInfo CheckForDetailedUpdate() { return default(System.Deployment.Application.UpdateCheckInfo); }
    public System.Deployment.Application.UpdateCheckInfo CheckForDetailedUpdate(bool persistUpdateCheckResult) { return default(System.Deployment.Application.UpdateCheckInfo); }
    public bool CheckForUpdate() { return default(bool); }
    public bool CheckForUpdate(bool persistUpdateCheckResult) { return default(bool); }
    public void CheckForUpdateAsync() { }
    public void CheckForUpdateAsyncCancel() { }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.Assert, Name="FullTrust")]
    public void DownloadFileGroup(string groupName) { }
    public void DownloadFileGroupAsync(string groupName) { }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.Assert, Name="FullTrust")]
    public void DownloadFileGroupAsync(string groupName, object userState) { }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.Assert, Name="FullTrust")]
    public void DownloadFileGroupAsyncCancel(string groupName) { }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.Assert, Name="FullTrust")]
    public bool IsFileGroupDownloaded(string groupName) { return default(bool); }
    public bool Update() { return default(bool); }
    public void UpdateAsync() { }
    public void UpdateAsyncCancel() { }
  }
  public partial class CheckForUpdateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    internal CheckForUpdateCompletedEventArgs() { }
    public System.Version AvailableVersion { get { return default(System.Version); } }
    public bool IsUpdateRequired { get { return default(bool); } }
    public System.Version MinimumRequiredVersion { get { return default(System.Version); } }
    public bool UpdateAvailable { get { return default(bool); } }
    public long UpdateSizeBytes { get { return default(long); } }
  }
  public delegate void CheckForUpdateCompletedEventHandler(object sender, System.Deployment.Application.CheckForUpdateCompletedEventArgs e);
  public partial class CompatibleFramework {
    internal CompatibleFramework() { }
    public string Profile { get { return default(string); } }
    public string SupportedRuntime { get { return default(string); } }
    public string TargetVersion { get { return default(string); } }
  }
  public partial class CompatibleFrameworkMissingException : System.Deployment.Application.DependentPlatformMissingException {
    public CompatibleFrameworkMissingException() { }
    protected CompatibleFrameworkMissingException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    public CompatibleFrameworkMissingException(string message) { }
    public CompatibleFrameworkMissingException(string message, System.Exception innerException) { }
    public System.Deployment.Application.CompatibleFrameworks CompatibleFrameworks { get { return default(System.Deployment.Application.CompatibleFrameworks); } }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, SerializationFormatter=true)]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial class CompatibleFrameworks {
    internal CompatibleFrameworks() { }
    public System.Collections.Generic.IList<System.Deployment.Application.CompatibleFramework> Frameworks { get { return default(System.Collections.Generic.IList<System.Deployment.Application.CompatibleFramework>); } }
    public System.Uri SupportUrl { get { return default(System.Uri); } }
  }
  public partial class DependentPlatformMissingException : System.Deployment.Application.DeploymentException {
    public DependentPlatformMissingException() { }
    protected DependentPlatformMissingException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    public DependentPlatformMissingException(string message) { }
    public DependentPlatformMissingException(string message, System.Exception innerException) { }
    public DependentPlatformMissingException(string message, System.Uri supportUrl) { }
    public System.Uri SupportUrl { get { return default(System.Uri); } }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, SerializationFormatter=true)]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial class DeploymentDownloadException : System.Deployment.Application.DeploymentException {
    public DeploymentDownloadException() { }
    protected DeploymentDownloadException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    public DeploymentDownloadException(string message) { }
    public DeploymentDownloadException(string message, System.Exception innerException) { }
  }
  public partial class DeploymentException : System.SystemException {
    public DeploymentException() { }
    protected DeploymentException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    public DeploymentException(string message) { }
    public DeploymentException(string message, System.Exception innerException) { }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, SerializationFormatter=true)]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial class DeploymentProgressChangedEventArgs : System.ComponentModel.ProgressChangedEventArgs {
    internal DeploymentProgressChangedEventArgs() : base (default(int), default(object)) { }
    public long BytesCompleted { get { return default(long); } }
    public long BytesTotal { get { return default(long); } }
    public string Group { get { return default(string); } }
    public System.Deployment.Application.DeploymentProgressState State { get { return default(System.Deployment.Application.DeploymentProgressState); } }
  }
  public delegate void DeploymentProgressChangedEventHandler(object sender, System.Deployment.Application.DeploymentProgressChangedEventArgs e);
  public enum DeploymentProgressState {
    DownloadingApplicationFiles = 2,
    DownloadingApplicationInformation = 1,
    DownloadingDeploymentInformation = 0,
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("20FD4E26-8E0F-4F73-A0E0-F27B8C57BE6F")]
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.Demand, Name="FullTrust")]
  public partial class DeploymentServiceCom {
    public DeploymentServiceCom() { }
    public void ActivateApplicationExtension(string textualSubId, string deploymentProviderUrl, string targetAssociatedFile) { }
    public void ActivateDeployment(string deploymentLocation, bool isShortcut) { }
    public void ActivateDeploymentEx(string deploymentLocation, int unsignedPolicy, int signedPolicy) { }
    public void CheckForDeploymentUpdate(string textualSubId) { }
    public void CleanOnlineAppCache() { }
    public void EndServiceRightNow() { }
    public void MaintainSubscription(string textualSubId) { }
  }
  public partial class DownloadApplicationCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    internal DownloadApplicationCompletedEventArgs() { }
    public string LogFilePath { get { return default(string); } }
    public string ShortcutAppId { get { return default(string); } }
  }
  public partial class DownloadFileGroupCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    internal DownloadFileGroupCompletedEventArgs() { }
    public string Group { get { return default(string); } }
  }
  public delegate void DownloadFileGroupCompletedEventHandler(object sender, System.Deployment.Application.DownloadFileGroupCompletedEventArgs e);
  public partial class DownloadProgressChangedEventArgs : System.ComponentModel.ProgressChangedEventArgs {
    internal DownloadProgressChangedEventArgs() : base (default(int), default(object)) { }
    public long BytesDownloaded { get { return default(long); } }
    public System.Deployment.Application.DeploymentProgressState State { get { return default(System.Deployment.Application.DeploymentProgressState); } }
    public long TotalBytesToDownload { get { return default(long); } }
  }
  public partial class GetManifestCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    internal GetManifestCompletedEventArgs() { }
    public System.ActivationContext ActivationContext { get { return default(System.ActivationContext); } }
    public System.ApplicationIdentity ApplicationIdentity { get { return default(System.ApplicationIdentity); } }
    public System.Xml.XmlReader ApplicationManifest { get { return default(System.Xml.XmlReader); } }
    public System.Xml.XmlReader DeploymentManifest { get { return default(System.Xml.XmlReader); } }
    public bool IsCached { get { return default(bool); } }
    public string LogFilePath { get { return default(string); } }
    public string ProductName { get { return default(string); } }
    public string SubscriptionIdentity { get { return default(string); } }
    public System.Uri SupportUri { get { return default(System.Uri); } }
    public System.Version Version { get { return default(System.Version); } }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Unrestricted=true)]
  public partial class InPlaceHostingManager : System.IDisposable {
    public InPlaceHostingManager(System.Uri deploymentManifest) { }
    public InPlaceHostingManager(System.Uri deploymentManifest, bool launchInHostProcess) { }
    public event System.EventHandler<System.Deployment.Application.DownloadApplicationCompletedEventArgs> DownloadApplicationCompleted { add { } remove { } }
    public event System.EventHandler<System.Deployment.Application.DownloadProgressChangedEventArgs> DownloadProgressChanged { add { } remove { } }
    public event System.EventHandler<System.Deployment.Application.GetManifestCompletedEventArgs> GetManifestCompleted { add { } remove { } }
    public void AssertApplicationRequirements() { }
    public void AssertApplicationRequirements(bool grantApplicationTrust) { }
    public void CancelAsync() { }
    public void Dispose() { }
    public void DownloadApplicationAsync() { }
    public System.Runtime.Remoting.ObjectHandle Execute() { return default(System.Runtime.Remoting.ObjectHandle); }
    public void GetManifestAsync() { }
    public static void UninstallCustomAddIn(string subscriptionId) { }
    public static void UninstallCustomUXApplication(string subscriptionId) { }
  }
  public partial class InvalidDeploymentException : System.Deployment.Application.DeploymentException {
    public InvalidDeploymentException() { }
    protected InvalidDeploymentException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    public InvalidDeploymentException(string message) { }
    public InvalidDeploymentException(string message, System.Exception innerException) { }
  }
  public partial class SupportedRuntimeMissingException : System.Deployment.Application.DependentPlatformMissingException {
    public SupportedRuntimeMissingException() { }
    protected SupportedRuntimeMissingException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    public SupportedRuntimeMissingException(string message) { }
    public SupportedRuntimeMissingException(string message, System.Exception innerException) { }
    public string SupportedRuntimeVersion { get { return default(string); } }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, SerializationFormatter=true)]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial class TrustNotGrantedException : System.Deployment.Application.DeploymentException {
    public TrustNotGrantedException() { }
    protected TrustNotGrantedException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    public TrustNotGrantedException(string message) { }
    public TrustNotGrantedException(string message, System.Exception innerException) { }
  }
  public partial class UpdateCheckInfo {
    internal UpdateCheckInfo() { }
    public System.Version AvailableVersion { get { return default(System.Version); } }
    public bool IsUpdateRequired { get { return default(bool); } }
    public System.Version MinimumRequiredVersion { get { return default(System.Version); } }
    public bool UpdateAvailable { get { return default(bool); } }
    public long UpdateSizeBytes { get { return default(long); } }
  }
}
namespace System.Deployment.Internal.CodeSigning {
  public sealed partial class RSAPKCS1SHA256SignatureDescription : System.Security.Cryptography.SignatureDescription {
    public RSAPKCS1SHA256SignatureDescription() { }
    public override System.Security.Cryptography.AsymmetricSignatureDeformatter CreateDeformatter(System.Security.Cryptography.AsymmetricAlgorithm key) { return default(System.Security.Cryptography.AsymmetricSignatureDeformatter); }
    public override System.Security.Cryptography.AsymmetricSignatureFormatter CreateFormatter(System.Security.Cryptography.AsymmetricAlgorithm key) { return default(System.Security.Cryptography.AsymmetricSignatureFormatter); }
  }
}
