namespace System.Transactions {
  public sealed partial class CommittableTransaction : System.Transactions.Transaction, System.IAsyncResult {
    public CommittableTransaction() { }
    public CommittableTransaction(System.TimeSpan timeout) { }
    public CommittableTransaction(System.Transactions.TransactionOptions options) { }
    object System.IAsyncResult.AsyncState { get { return default(object); } }
    System.Threading.WaitHandle System.IAsyncResult.AsyncWaitHandle { get { return default(System.Threading.WaitHandle); } }
    bool System.IAsyncResult.CompletedSynchronously { get { return default(bool); } }
    bool System.IAsyncResult.IsCompleted { get { return default(bool); } }
    public System.IAsyncResult BeginCommit(System.AsyncCallback asyncCallback, object asyncState) { return default(System.IAsyncResult); }
    public void Commit() { }
    public void EndCommit(System.IAsyncResult asyncResult) { }
  }
  public enum DependentCloneOption {
    BlockCommitUntilComplete = 0,
    RollbackIfNotComplete = 1,
  }
  public sealed partial class DependentTransaction : System.Transactions.Transaction {
    internal DependentTransaction() { }
    public void Complete() { }
  }
  public sealed partial class DistributedTransactionPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission {
    public DistributedTransactionPermission(System.Security.Permissions.PermissionState state) { }
    public override System.Security.IPermission Copy() { return default(System.Security.IPermission); }
    public override void FromXml(System.Security.SecurityElement securityElement) { }
    public override System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
    public override bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
    public bool IsUnrestricted() { return default(bool); }
    public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
    public override System.Security.IPermission Union(System.Security.IPermission target) { return default(System.Security.IPermission); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
  public sealed partial class DistributedTransactionPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute {
    public DistributedTransactionPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
    public new bool Unrestricted { get { return default(bool); } set { } }
    public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
  }
  public partial class Enlistment {
    internal Enlistment() { }
    public void Done() { }
  }
  [System.FlagsAttribute]
  public enum EnlistmentOptions {
    EnlistDuringPrepareRequired = 1,
    None = 0,
  }
  public enum EnterpriseServicesInteropOption {
    Automatic = 1,
    Full = 2,
    None = 0,
  }
  public delegate System.Transactions.Transaction HostCurrentTransactionCallback();
  [System.Runtime.InteropServices.GuidAttribute("0fb15084-af41-11ce-bd2b-204c4f4f5020")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
  public partial interface IDtcTransaction {
    void Abort(System.IntPtr reason, int retaining, int async);
    void Commit(int retaining, int commitType, int reserved);
    void GetTransactionInfo(System.IntPtr transactionInformation);
  }
  public partial interface IEnlistmentNotification {
    void Commit(System.Transactions.Enlistment enlistment);
    void InDoubt(System.Transactions.Enlistment enlistment);
    void Prepare(System.Transactions.PreparingEnlistment preparingEnlistment);
    void Rollback(System.Transactions.Enlistment enlistment);
  }
  public partial interface IPromotableSinglePhaseNotification : System.Transactions.ITransactionPromoter {
    void Initialize();
    void Rollback(System.Transactions.SinglePhaseEnlistment singlePhaseEnlistment);
    void SinglePhaseCommit(System.Transactions.SinglePhaseEnlistment singlePhaseEnlistment);
  }
  public partial interface ISimpleTransactionSuperior : System.Transactions.ITransactionPromoter {
    void Rollback();
  }
  public partial interface ISinglePhaseNotification : System.Transactions.IEnlistmentNotification {
    void SinglePhaseCommit(System.Transactions.SinglePhaseEnlistment singlePhaseEnlistment);
  }
  public enum IsolationLevel {
    Chaos = 5,
    ReadCommitted = 2,
    ReadUncommitted = 3,
    RepeatableRead = 1,
    Serializable = 0,
    Snapshot = 4,
    Unspecified = 6,
  }
  public partial interface ITransactionPromoter {
    System.Byte[] Promote();
  }
  public partial class PreparingEnlistment : System.Transactions.Enlistment {
    internal PreparingEnlistment() { }
    public void ForceRollback() { }
    public void ForceRollback(System.Exception e) { }
    public void Prepared() { }
    public System.Byte[] RecoveryInformation() { return default(System.Byte[]); }
  }
  public partial class SinglePhaseEnlistment : System.Transactions.Enlistment {
    internal SinglePhaseEnlistment() { }
    public void Aborted() { }
    public void Aborted(System.Exception e) { }
    public void Committed() { }
    public void InDoubt() { }
    public void InDoubt(System.Exception e) { }
  }
  public sealed partial class SubordinateTransaction : System.Transactions.Transaction {
    public SubordinateTransaction(System.Transactions.IsolationLevel isoLevel, System.Transactions.ISimpleTransactionSuperior superior) { }
  }
  public partial class Transaction : System.IDisposable, System.Runtime.Serialization.ISerializable {
    internal Transaction() { }
    public static System.Transactions.Transaction Current { get { return default(System.Transactions.Transaction); } set { } }
    public System.Transactions.IsolationLevel IsolationLevel { get { return default(System.Transactions.IsolationLevel); } }
    public System.Guid PromoterType { get { return default(System.Guid); } }
    public System.Transactions.TransactionInformation TransactionInformation { get { return default(System.Transactions.TransactionInformation); } }
    public event System.Transactions.TransactionCompletedEventHandler TransactionCompleted { add { } remove { } }
    public System.Transactions.Transaction Clone() { return default(System.Transactions.Transaction); }
    public System.Transactions.DependentTransaction DependentClone(System.Transactions.DependentCloneOption cloneOption) { return default(System.Transactions.DependentTransaction); }
    public void Dispose() { }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public System.Transactions.Enlistment EnlistDurable(System.Guid resourceManagerIdentifier, System.Transactions.IEnlistmentNotification enlistmentNotification, System.Transactions.EnlistmentOptions enlistmentOptions) { return default(System.Transactions.Enlistment); }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public System.Transactions.Enlistment EnlistDurable(System.Guid resourceManagerIdentifier, System.Transactions.ISinglePhaseNotification singlePhaseNotification, System.Transactions.EnlistmentOptions enlistmentOptions) { return default(System.Transactions.Enlistment); }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public bool EnlistPromotableSinglePhase(System.Transactions.IPromotableSinglePhaseNotification promotableSinglePhaseNotification) { return default(bool); }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public bool EnlistPromotableSinglePhase(System.Transactions.IPromotableSinglePhaseNotification promotableSinglePhaseNotification, System.Guid promoterType) { return default(bool); }
    public System.Transactions.Enlistment EnlistVolatile(System.Transactions.IEnlistmentNotification enlistmentNotification, System.Transactions.EnlistmentOptions enlistmentOptions) { return default(System.Transactions.Enlistment); }
    public System.Transactions.Enlistment EnlistVolatile(System.Transactions.ISinglePhaseNotification singlePhaseNotification, System.Transactions.EnlistmentOptions enlistmentOptions) { return default(System.Transactions.Enlistment); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public System.Byte[] GetPromotedToken() { return default(System.Byte[]); }
    public static bool operator ==(System.Transactions.Transaction x, System.Transactions.Transaction y) { return default(bool); }
    public static bool operator !=(System.Transactions.Transaction x, System.Transactions.Transaction y) { return default(bool); }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public System.Transactions.Enlistment PromoteAndEnlistDurable(System.Guid resourceManagerIdentifier, System.Transactions.IPromotableSinglePhaseNotification promotableNotification, System.Transactions.ISinglePhaseNotification enlistmentNotification, System.Transactions.EnlistmentOptions enlistmentOptions) { return default(System.Transactions.Enlistment); }
    public void Rollback() { }
    public void Rollback(System.Exception e) { }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public void SetDistributedTransactionIdentifier(System.Transactions.IPromotableSinglePhaseNotification promotableNotification, System.Guid distributedTransactionIdentifier) { }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, SerializationFormatter=true)]
    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial class TransactionAbortedException : System.Transactions.TransactionException {
    public TransactionAbortedException() { }
    protected TransactionAbortedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public TransactionAbortedException(string message) { }
    public TransactionAbortedException(string message, System.Exception innerException) { }
  }
  public delegate void TransactionCompletedEventHandler(object sender, System.Transactions.TransactionEventArgs e);
  public partial class TransactionEventArgs : System.EventArgs {
    public TransactionEventArgs() { }
    public System.Transactions.Transaction Transaction { get { return default(System.Transactions.Transaction); } }
  }
  public partial class TransactionException : System.SystemException {
    public TransactionException() { }
    protected TransactionException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public TransactionException(string message) { }
    public TransactionException(string message, System.Exception innerException) { }
  }
  public partial class TransactionInDoubtException : System.Transactions.TransactionException {
    public TransactionInDoubtException() { }
    protected TransactionInDoubtException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public TransactionInDoubtException(string message) { }
    public TransactionInDoubtException(string message, System.Exception innerException) { }
  }
  public partial class TransactionInformation {
    internal TransactionInformation() { }
    public System.DateTime CreationTime { get { return default(System.DateTime); } }
    public System.Guid DistributedIdentifier { get { return default(System.Guid); } }
    public string LocalIdentifier { get { return default(string); } }
    public System.Transactions.TransactionStatus Status { get { return default(System.Transactions.TransactionStatus); } }
  }
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
  public static partial class TransactionInterop {
    public static readonly System.Guid PromoterTypeDtc;
    public static System.Transactions.IDtcTransaction GetDtcTransaction(System.Transactions.Transaction transaction) { return default(System.Transactions.IDtcTransaction); }
    public static System.Byte[] GetExportCookie(System.Transactions.Transaction transaction, System.Byte[] whereabouts) { return default(System.Byte[]); }
    public static System.Transactions.Transaction GetTransactionFromDtcTransaction(System.Transactions.IDtcTransaction transactionNative) { return default(System.Transactions.Transaction); }
    public static System.Transactions.Transaction GetTransactionFromExportCookie(System.Byte[] cookie) { return default(System.Transactions.Transaction); }
    public static System.Transactions.Transaction GetTransactionFromTransmitterPropagationToken(System.Byte[] propagationToken) { return default(System.Transactions.Transaction); }
    public static System.Byte[] GetTransmitterPropagationToken(System.Transactions.Transaction transaction) { return default(System.Byte[]); }
    public static System.Byte[] GetWhereabouts() { return default(System.Byte[]); }
  }
  public static partial class TransactionManager {
    public static System.TimeSpan DefaultTimeout { get { return default(System.TimeSpan); } }
    public static System.Transactions.HostCurrentTransactionCallback HostCurrentCallback { get { return default(System.Transactions.HostCurrentTransactionCallback); } set { } }
    public static System.TimeSpan MaximumTimeout { get { return default(System.TimeSpan); } }
    public static event System.Transactions.TransactionStartedEventHandler DistributedTransactionStarted { add { } remove { } }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public static void RecoveryComplete(System.Guid resourceManagerIdentifier) { }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public static System.Transactions.Enlistment Reenlist(System.Guid resourceManagerIdentifier, System.Byte[] recoveryInformation, System.Transactions.IEnlistmentNotification enlistmentNotification) { return default(System.Transactions.Enlistment); }
  }
  public partial class TransactionManagerCommunicationException : System.Transactions.TransactionException {
    public TransactionManagerCommunicationException() { }
    protected TransactionManagerCommunicationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public TransactionManagerCommunicationException(string message) { }
    public TransactionManagerCommunicationException(string message, System.Exception innerException) { }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct TransactionOptions {
    public System.Transactions.IsolationLevel IsolationLevel { get { return default(System.Transactions.IsolationLevel); } set { } }
    public System.TimeSpan Timeout { get { return default(System.TimeSpan); } set { } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Transactions.TransactionOptions x, System.Transactions.TransactionOptions y) { return default(bool); }
    public static bool operator !=(System.Transactions.TransactionOptions x, System.Transactions.TransactionOptions y) { return default(bool); }
  }
  public partial class TransactionPromotionException : System.Transactions.TransactionException {
    public TransactionPromotionException() { }
    protected TransactionPromotionException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public TransactionPromotionException(string message) { }
    public TransactionPromotionException(string message, System.Exception innerException) { }
  }
  public sealed partial class TransactionScope : System.IDisposable {
    public TransactionScope() { }
    public TransactionScope(System.Transactions.Transaction transactionToUse) { }
    public TransactionScope(System.Transactions.Transaction transactionToUse, System.TimeSpan scopeTimeout) { }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public TransactionScope(System.Transactions.Transaction transactionToUse, System.TimeSpan scopeTimeout, System.Transactions.EnterpriseServicesInteropOption interopOption) { }
    public TransactionScope(System.Transactions.Transaction transactionToUse, System.TimeSpan scopeTimeout, System.Transactions.TransactionScopeAsyncFlowOption asyncFlowOption) { }
    public TransactionScope(System.Transactions.Transaction transactionToUse, System.Transactions.TransactionScopeAsyncFlowOption asyncFlowOption) { }
    public TransactionScope(System.Transactions.TransactionScopeAsyncFlowOption asyncFlowOption) { }
    public TransactionScope(System.Transactions.TransactionScopeOption scopeOption) { }
    public TransactionScope(System.Transactions.TransactionScopeOption scopeOption, System.TimeSpan scopeTimeout) { }
    public TransactionScope(System.Transactions.TransactionScopeOption scopeOption, System.TimeSpan scopeTimeout, System.Transactions.TransactionScopeAsyncFlowOption asyncFlowOption) { }
    public TransactionScope(System.Transactions.TransactionScopeOption scopeOption, System.Transactions.TransactionOptions transactionOptions) { }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public TransactionScope(System.Transactions.TransactionScopeOption scopeOption, System.Transactions.TransactionOptions transactionOptions, System.Transactions.EnterpriseServicesInteropOption interopOption) { }
    public TransactionScope(System.Transactions.TransactionScopeOption scopeOption, System.Transactions.TransactionOptions transactionOptions, System.Transactions.TransactionScopeAsyncFlowOption asyncFlowOption) { }
    public TransactionScope(System.Transactions.TransactionScopeOption scopeOption, System.Transactions.TransactionScopeAsyncFlowOption asyncFlowOption) { }
    public void Complete() { }
    public void Dispose() { }
  }
  public enum TransactionScopeAsyncFlowOption {
    Enabled = 1,
    Suppress = 0,
  }
  public enum TransactionScopeOption {
    Required = 0,
    RequiresNew = 1,
    Suppress = 2,
  }
  public delegate void TransactionStartedEventHandler(object sender, System.Transactions.TransactionEventArgs e);
  public enum TransactionStatus {
    Aborted = 2,
    Active = 0,
    Committed = 1,
    InDoubt = 3,
  }
}
namespace System.Transactions.Configuration {
  public sealed partial class DefaultSettingsSection : System.Configuration.ConfigurationSection {
    public DefaultSettingsSection() { }
    [System.Configuration.ConfigurationPropertyAttribute("distributedTransactionManagerName", DefaultValue="")]
    public string DistributedTransactionManagerName { get { return default(string); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("timeout", DefaultValue="00:01:00")]
    [System.Configuration.TimeSpanValidatorAttribute(MinValueString="00:00:00", MaxValueString="10675199.02:48:05.4775807")]
    public System.TimeSpan Timeout { get { return default(System.TimeSpan); } set { } }
  }
  public sealed partial class MachineSettingsSection : System.Configuration.ConfigurationSection {
    public MachineSettingsSection() { }
    [System.Configuration.ConfigurationPropertyAttribute("maxTimeout", DefaultValue="00:10:00")]
    [System.Configuration.TimeSpanValidatorAttribute(MinValueString="00:00:00", MaxValueString="10675199.02:48:05.4775807")]
    public System.TimeSpan MaxTimeout { get { return default(System.TimeSpan); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  public sealed partial class TransactionsSectionGroup : System.Configuration.ConfigurationSectionGroup {
    public TransactionsSectionGroup() { }
    [System.Configuration.ConfigurationPropertyAttribute("defaultSettings")]
    public System.Transactions.Configuration.DefaultSettingsSection DefaultSettings { get { return default(System.Transactions.Configuration.DefaultSettingsSection); } }
    [System.Configuration.ConfigurationPropertyAttribute("machineSettings")]
    public System.Transactions.Configuration.MachineSettingsSection MachineSettings { get { return default(System.Transactions.Configuration.MachineSettingsSection); } }
    public static System.Transactions.Configuration.TransactionsSectionGroup GetSectionGroup(System.Configuration.Configuration config) { return default(System.Transactions.Configuration.TransactionsSectionGroup); }
  }
}
