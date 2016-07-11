namespace System.Activities.DurableInstancing {
  public enum InstanceCompletionAction {
    DeleteAll = 1,
    DeleteNothing = 0,
  }
  public enum InstanceEncodingOption {
    GZip = 1,
    None = 0,
  }
  public enum InstanceLockedExceptionAction {
    AggressiveRetry = 2,
    BasicRetry = 1,
    NoRetry = 0,
  }
  public sealed partial class SqlWorkflowInstanceStore : System.Runtime.DurableInstancing.InstanceStore {
    public SqlWorkflowInstanceStore() { }
    public SqlWorkflowInstanceStore(string connectionString) { }
    public string ConnectionString { get { return default(string); } set { } }
    public bool EnqueueRunCommands { get { return default(bool); } set { } }
    public System.TimeSpan HostLockRenewalPeriod { get { return default(System.TimeSpan); } set { } }
    public System.Activities.DurableInstancing.InstanceCompletionAction InstanceCompletionAction { get { return default(System.Activities.DurableInstancing.InstanceCompletionAction); } set { } }
    public System.Activities.DurableInstancing.InstanceEncodingOption InstanceEncodingOption { get { return default(System.Activities.DurableInstancing.InstanceEncodingOption); } set { } }
    public System.Activities.DurableInstancing.InstanceLockedExceptionAction InstanceLockedExceptionAction { get { return default(System.Activities.DurableInstancing.InstanceLockedExceptionAction); } set { } }
    public int MaxConnectionRetries { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.TimeSpan RunnableInstancesDetectionPeriod { get { return default(System.TimeSpan); } set { } }
    protected internal override System.IAsyncResult BeginTryCommand(System.Runtime.DurableInstancing.InstancePersistenceContext context, System.Runtime.DurableInstancing.InstancePersistenceCommand command, System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected internal override bool EndTryCommand(System.IAsyncResult result) { return default(bool); }
    protected override void OnFreeInstanceHandle(System.Runtime.DurableInstancing.InstanceHandle instanceHandle, object userContext) { }
    protected override object OnNewInstanceHandle(System.Runtime.DurableInstancing.InstanceHandle instanceHandle) { return default(object); }
    public void Promote(string name, System.Collections.Generic.IEnumerable<System.Xml.Linq.XName> promoteAsVariant, System.Collections.Generic.IEnumerable<System.Xml.Linq.XName> promoteAsBinary) { }
  }
}
