namespace System.ServiceModel {
  public partial class CorrelationActionMessageFilter : System.ServiceModel.Dispatcher.MessageFilter {
    public CorrelationActionMessageFilter() { }
    public string Action { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override bool Equals(object other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool Match(System.ServiceModel.Channels.Message message) { return default(bool); }
    public override bool Match(System.ServiceModel.Channels.MessageBuffer messageBuffer) { return default(bool); }
    public override string ToString() { return default(string); }
  }
  public partial class CorrelationQuery {
    public CorrelationQuery() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.ServiceModel.MessageQuerySet Select { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.MessageQuerySet); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.MessageQuerySet> SelectAdditional { get { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.MessageQuerySet>); } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.ServiceModel.Dispatcher.MessageFilter Where { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Dispatcher.MessageFilter); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override bool Equals(object other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }
  public partial class Endpoint {
    public Endpoint() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Uri AddressUri { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Uri); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public string BehaviorConfigurationName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.ServiceModel.Channels.Binding Binding { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Channels.Binding); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Channels.AddressHeader> Headers { get { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Channels.AddressHeader>); } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.XamlIntegration.EndpointIdentityConverter))]
    public System.ServiceModel.EndpointIdentity Identity { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.EndpointIdentity); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Uri ListenUri { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Uri); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.XamlIntegration.ServiceXNameTypeConverter))]
    public System.Xml.Linq.XName ServiceContractName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xml.Linq.XName); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.ServiceModel.EndpointAddress GetAddress() { return default(System.ServiceModel.EndpointAddress); }
    public System.ServiceModel.EndpointAddress GetAddress(System.ServiceModel.ServiceHostBase host) { return default(System.ServiceModel.EndpointAddress); }
  }
  [System.Windows.Markup.MarkupExtensionReturnTypeAttribute(typeof(System.ServiceModel.EndpointIdentity))]
  public partial class EndpointIdentityExtension : System.Windows.Markup.MarkupExtension {
    public EndpointIdentityExtension() { }
    public EndpointIdentityExtension(System.ServiceModel.EndpointIdentity identity) { }
    public object ClaimResource { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string ClaimRight { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string ClaimType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override object ProvideValue(System.IServiceProvider serviceProvider) { return default(object); }
  }
  public partial class MessageQuerySet : System.Collections.Generic.Dictionary<System.String, System.ServiceModel.Dispatcher.MessageQuery> {
    public MessageQuerySet() { }
    public MessageQuerySet(System.ServiceModel.Dispatcher.MessageQueryTable<System.String> queryTable) { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.ServiceModel.Dispatcher.MessageQueryTable<System.String> GetMessageQueryTable() { return default(System.ServiceModel.Dispatcher.MessageQueryTable<System.String>); }
  }
}
namespace System.ServiceModel.Activities {
  public sealed partial class CallbackCorrelationInitializer : System.ServiceModel.Activities.CorrelationInitializer {
    public CallbackCorrelationInitializer() { }
  }
  public partial class ChannelCacheSettings {
    public ChannelCacheSettings() { }
    public System.TimeSpan IdleTimeout { get { return default(System.TimeSpan); } set { } }
    public System.TimeSpan LeaseTimeout { get { return default(System.TimeSpan); } set { } }
    public int MaxItemsInCache { get { return default(int); } set { } }
  }
  public sealed partial class ContextCorrelationInitializer : System.ServiceModel.Activities.CorrelationInitializer {
    public ContextCorrelationInitializer() { }
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public partial class CorrelationHandle : System.Activities.Handle {
    public CorrelationHandle() { }
    protected override void OnInitialize(System.Activities.HandleInitializationContext context) { }
    protected override void OnUninitialize(System.Activities.HandleInitializationContext context) { }
  }
  public abstract partial class CorrelationInitializer {
    internal CorrelationInitializer() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<System.ServiceModel.Activities.CorrelationHandle> CorrelationHandle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<System.ServiceModel.Activities.CorrelationHandle>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial class CorrelationScope : System.Activities.NativeActivity {
    public CorrelationScope() { }
    public System.Activities.Activity Body { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Activity); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Activities.InArgument<System.ServiceModel.Activities.CorrelationHandle> CorrelatesWith { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<System.ServiceModel.Activities.CorrelationHandle>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.NativeActivityMetadata metadata) { }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeCorrelatesWith() { return default(bool); }
  }
  public sealed partial class DurableInstancingOptions {
    internal DurableInstancingOptions() { }
    public System.Runtime.DurableInstancing.InstanceStore InstanceStore { get { return default(System.Runtime.DurableInstancing.InstanceStore); } set { } }
    public void AddInitialInstanceValues(System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Object> writeOnlyValues) { }
    public void AddInstanceOwnerValues(System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Object> readWriteValues, System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Object> writeOnlyValues) { }
  }
  public sealed partial class HostSettings {
    public HostSettings() { }
    public bool IncludeExceptionDetailInFaults { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Xml.Linq.XName ScopeName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xml.Linq.XName); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool UseNoPersistHandle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  [System.Windows.Markup.ContentPropertyAttribute("CorrelationData")]
  public sealed partial class InitializeCorrelation : System.Activities.NativeActivity {
    public InitializeCorrelation() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<System.ServiceModel.Activities.CorrelationHandle> Correlation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<System.ServiceModel.Activities.CorrelationHandle>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.Generic.IDictionary<System.String, System.Activities.InArgument<System.String>> CorrelationData { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IDictionary<System.String, System.Activities.InArgument<System.String>>); } }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
  }
  public partial interface IReceiveMessageCallback {
    void OnReceiveMessage(System.ServiceModel.OperationContext operationContext, System.Activities.ExecutionProperties activityExecutionProperties);
  }
  public partial interface ISendMessageCallback {
    void OnSendMessage(System.ServiceModel.OperationContext operationContext);
  }
  [System.ServiceModel.Activities.Description.WorkflowContractBehaviorAttribute]
  [System.ServiceModel.ServiceContractAttribute(Name="IWorkflowInstanceManagement", Namespace="http://schemas.datacontract.org/2008/10/WorkflowServices")]
  public partial interface IWorkflowInstanceManagement {
    [System.ServiceModel.OperationContractAttribute(Name="Abandon")]
    void Abandon(System.Guid instanceId, string reason);
    [System.ServiceModel.OperationContractAttribute(Name="Abandon", AsyncPattern=true)]
    System.IAsyncResult BeginAbandon(System.Guid instanceId, string reason, System.AsyncCallback callback, object state);
    [System.ServiceModel.OperationContractAttribute(Name="Cancel", AsyncPattern=true)]
    System.IAsyncResult BeginCancel(System.Guid instanceId, System.AsyncCallback callback, object state);
    [System.ServiceModel.OperationContractAttribute(Name="Run", AsyncPattern=true)]
    System.IAsyncResult BeginRun(System.Guid instanceId, System.AsyncCallback callback, object state);
    [System.ServiceModel.OperationContractAttribute(Name="Suspend", AsyncPattern=true)]
    System.IAsyncResult BeginSuspend(System.Guid instanceId, string reason, System.AsyncCallback callback, object state);
    [System.ServiceModel.OperationContractAttribute(Name="Terminate", AsyncPattern=true)]
    System.IAsyncResult BeginTerminate(System.Guid instanceId, string reason, System.AsyncCallback callback, object state);
    [System.ServiceModel.OperationContractAttribute(Name="TransactedCancel", AsyncPattern=true)]
    System.IAsyncResult BeginTransactedCancel(System.Guid instanceId, System.AsyncCallback callback, object state);
    [System.ServiceModel.OperationContractAttribute(Name="TransactedRun", AsyncPattern=true)]
    System.IAsyncResult BeginTransactedRun(System.Guid instanceId, System.AsyncCallback callback, object state);
    [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Name="TransactedSuspend")]
    System.IAsyncResult BeginTransactedSuspend(System.Guid instanceId, string reason, System.AsyncCallback callback, object state);
    [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Name="TransactedTerminate")]
    System.IAsyncResult BeginTransactedTerminate(System.Guid instanceId, string reason, System.AsyncCallback callback, object state);
    [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Name="TransactedUnsuspend")]
    System.IAsyncResult BeginTransactedUnsuspend(System.Guid instanceId, System.AsyncCallback callback, object state);
    [System.ServiceModel.OperationContractAttribute(Name="Unsuspend", AsyncPattern=true)]
    System.IAsyncResult BeginUnsuspend(System.Guid instanceId, System.AsyncCallback callback, object state);
    [System.ServiceModel.OperationContractAttribute(Name="Cancel")]
    void Cancel(System.Guid instanceId);
    void EndAbandon(System.IAsyncResult result);
    void EndCancel(System.IAsyncResult result);
    void EndRun(System.IAsyncResult result);
    void EndSuspend(System.IAsyncResult result);
    void EndTerminate(System.IAsyncResult result);
    void EndTransactedCancel(System.IAsyncResult result);
    void EndTransactedRun(System.IAsyncResult result);
    void EndTransactedSuspend(System.IAsyncResult result);
    void EndTransactedTerminate(System.IAsyncResult result);
    void EndTransactedUnsuspend(System.IAsyncResult result);
    void EndUnsuspend(System.IAsyncResult result);
    [System.ServiceModel.OperationContractAttribute(Name="Run")]
    void Run(System.Guid instanceId);
    [System.ServiceModel.OperationContractAttribute(Name="Suspend")]
    void Suspend(System.Guid instanceId, string reason);
    [System.ServiceModel.OperationContractAttribute(Name="Terminate")]
    void Terminate(System.Guid instanceId, string reason);
    [System.ServiceModel.OperationContractAttribute(Name="TransactedCancel")]
    [System.ServiceModel.TransactionFlowAttribute((System.ServiceModel.TransactionFlowOption)(1))]
    void TransactedCancel(System.Guid instanceId);
    [System.ServiceModel.OperationContractAttribute(Name="TransactedRun")]
    [System.ServiceModel.TransactionFlowAttribute((System.ServiceModel.TransactionFlowOption)(1))]
    void TransactedRun(System.Guid instanceId);
    [System.ServiceModel.OperationContractAttribute(Name="TransactedSuspend")]
    [System.ServiceModel.TransactionFlowAttribute((System.ServiceModel.TransactionFlowOption)(1))]
    void TransactedSuspend(System.Guid instanceId, string reason);
    [System.ServiceModel.OperationContractAttribute(Name="TransactedTerminate")]
    [System.ServiceModel.TransactionFlowAttribute((System.ServiceModel.TransactionFlowOption)(1))]
    void TransactedTerminate(System.Guid instanceId, string reason);
    [System.ServiceModel.OperationContractAttribute(Name="TransactedUnsuspend")]
    [System.ServiceModel.TransactionFlowAttribute((System.ServiceModel.TransactionFlowOption)(1))]
    void TransactedUnsuspend(System.Guid instanceId);
    [System.ServiceModel.OperationContractAttribute(Name="Unsuspend")]
    void Unsuspend(System.Guid instanceId);
  }
  [System.ServiceModel.Activities.Description.WorkflowContractBehaviorAttribute]
  [System.ServiceModel.ServiceContractAttribute(Name="IWorkflowInstanceManagement", Namespace="http://schemas.datacontract.org/2008/10/WorkflowServices", ConfigurationName="System.ServiceModel.Activities.IWorkflowInstanceManagement")]
  public partial interface IWorkflowUpdateableInstanceManagement : System.ServiceModel.Activities.IWorkflowInstanceManagement {
    [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Name="TransactedUpdate")]
    System.IAsyncResult BeginTransactedUpdate(System.Guid instanceId, System.Activities.WorkflowIdentity updatedDefinitionIdentity, System.AsyncCallback callback, object state);
    [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Name="Update")]
    System.IAsyncResult BeginUpdate(System.Guid instanceId, System.Activities.WorkflowIdentity updatedDefinitionIdentity, System.AsyncCallback callback, object state);
    void EndTransactedUpdate(System.IAsyncResult result);
    void EndUpdate(System.IAsyncResult result);
    [System.ServiceModel.OperationContractAttribute(Name="TransactedUpdate")]
    [System.ServiceModel.TransactionFlowAttribute((System.ServiceModel.TransactionFlowOption)(1))]
    void TransactedUpdate(System.Guid instanceId, System.Activities.WorkflowIdentity updatedDefinitionIdentity);
    [System.ServiceModel.OperationContractAttribute(Name="Update")]
    void Update(System.Guid instanceId, System.Activities.WorkflowIdentity updatedDefinitionIdentity);
  }
  public partial class MessageContext {
    public MessageContext() { }
    public virtual System.Guid EndToEndTracingId { get { return default(System.Guid); } set { } }
    public virtual System.ServiceModel.Channels.Message Message { get { return default(System.ServiceModel.Channels.Message); } set { } }
  }
  [System.Windows.Markup.ContentPropertyAttribute("MessageQuerySet")]
  public sealed partial class QueryCorrelationInitializer : System.ServiceModel.Activities.CorrelationInitializer {
    public QueryCorrelationInitializer() { }
    public System.ServiceModel.MessageQuerySet MessageQuerySet { get { return default(System.ServiceModel.MessageQuerySet); } set { } }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Content")]
  public sealed partial class Receive : System.Activities.Activity {
    public Receive() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public string Action { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool CanCreateInstance { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.ServiceModel.Activities.ReceiveContent Content { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Activities.ReceiveContent); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.ServiceModel.MessageQuerySet CorrelatesOn { get { return default(System.ServiceModel.MessageQuerySet); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<System.ServiceModel.Activities.CorrelationHandle> CorrelatesWith { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<System.ServiceModel.Activities.CorrelationHandle>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Activities.CorrelationInitializer> CorrelationInitializers { get { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Activities.CorrelationInitializer>); } }
    public System.Collections.ObjectModel.Collection<System.Type> KnownTypes { get { return default(System.Collections.ObjectModel.Collection<System.Type>); } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public string OperationName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Nullable<System.Net.Security.ProtectionLevel> ProtectionLevel { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.Net.Security.ProtectionLevel>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.Activities.SerializerOption)(0))]
    public System.ServiceModel.Activities.SerializerOption SerializerOption { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Activities.SerializerOption); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.XamlIntegration.ServiceXNameTypeConverter))]
    public System.Xml.Linq.XName ServiceContractName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xml.Linq.XName); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.ActivityMetadata metadata) { }
    public static System.ServiceModel.Activities.Receive FromOperationDescription(System.ServiceModel.Description.OperationDescription operation) { return default(System.ServiceModel.Activities.Receive); }
    protected override void OnCreateDynamicUpdateMap(System.Activities.DynamicUpdate.UpdateMapMetadata metadata, System.Activities.Activity originalActivity) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeCorrelatesOn() { return default(bool); }
  }
  public abstract partial class ReceiveContent {
    internal ReceiveContent() { }
    public static System.ServiceModel.Activities.ReceiveMessageContent Create(System.Activities.OutArgument message) { return default(System.ServiceModel.Activities.ReceiveMessageContent); }
    public static System.ServiceModel.Activities.ReceiveMessageContent Create(System.Activities.OutArgument message, System.Type declaredMessageType) { return default(System.ServiceModel.Activities.ReceiveMessageContent); }
    public static System.ServiceModel.Activities.ReceiveParametersContent Create(System.Collections.Generic.IDictionary<System.String, System.Activities.OutArgument> parameters) { return default(System.ServiceModel.Activities.ReceiveParametersContent); }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Message")]
  public sealed partial class ReceiveMessageContent : System.ServiceModel.Activities.ReceiveContent {
    public ReceiveMessageContent() { }
    public ReceiveMessageContent(System.Activities.OutArgument message) { }
    public ReceiveMessageContent(System.Activities.OutArgument message, System.Type declaredMessageType) { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Type DeclaredMessageType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.OutArgument Message { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.OutArgument); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeDeclaredMessageType() { return default(bool); }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Parameters")]
  public sealed partial class ReceiveParametersContent : System.ServiceModel.Activities.ReceiveContent {
    public ReceiveParametersContent() { }
    public ReceiveParametersContent(System.Collections.Generic.IDictionary<System.String, System.Activities.OutArgument> parameters) { }
    public System.Collections.Generic.IDictionary<System.String, System.Activities.OutArgument> Parameters { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IDictionary<System.String, System.Activities.OutArgument>); } }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Content")]
  public sealed partial class ReceiveReply : System.Activities.Activity {
    public ReceiveReply() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public string Action { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.ServiceModel.Activities.ReceiveContent Content { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Activities.ReceiveContent); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Activities.CorrelationInitializer> CorrelationInitializers { get { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Activities.CorrelationInitializer>); } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.ServiceModel.Activities.Send Request { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Activities.Send); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.ActivityMetadata metadata) { }
  }
  public sealed partial class ReceiveSettings {
    public ReceiveSettings() { }
    public string Action { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool CanCreateInstance { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string OwnerDisplayName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public sealed partial class RequestReplyCorrelationInitializer : System.ServiceModel.Activities.CorrelationInitializer {
    public RequestReplyCorrelationInitializer() { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Content")]
  public sealed partial class Send : System.Activities.Activity {
    public Send() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public string Action { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.ServiceModel.Activities.SendContent Content { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Activities.SendContent); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<System.ServiceModel.Activities.CorrelationHandle> CorrelatesWith { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<System.ServiceModel.Activities.CorrelationHandle>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Activities.CorrelationInitializer> CorrelationInitializers { get { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Activities.CorrelationInitializer>); } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.ServiceModel.Endpoint Endpoint { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Endpoint); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument<System.Uri> EndpointAddress { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument<System.Uri>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public string EndpointConfigurationName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.ObjectModel.Collection<System.Type> KnownTypes { get { return default(System.Collections.ObjectModel.Collection<System.Type>); } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public string OperationName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Nullable<System.Net.Security.ProtectionLevel> ProtectionLevel { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.Net.Security.ProtectionLevel>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.Activities.SerializerOption)(0))]
    public System.ServiceModel.Activities.SerializerOption SerializerOption { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Activities.SerializerOption); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.XamlIntegration.ServiceXNameTypeConverter))]
    public System.Xml.Linq.XName ServiceContractName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xml.Linq.XName); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Security.Principal.TokenImpersonationLevel)(2))]
    public System.Security.Principal.TokenImpersonationLevel TokenImpersonationLevel { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Security.Principal.TokenImpersonationLevel); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.ActivityMetadata metadata) { }
  }
  public abstract partial class SendContent {
    internal SendContent() { }
    public static System.ServiceModel.Activities.SendMessageContent Create(System.Activities.InArgument message) { return default(System.ServiceModel.Activities.SendMessageContent); }
    public static System.ServiceModel.Activities.SendMessageContent Create(System.Activities.InArgument message, System.Type declaredMessageType) { return default(System.ServiceModel.Activities.SendMessageContent); }
    public static System.ServiceModel.Activities.SendParametersContent Create(System.Collections.Generic.IDictionary<System.String, System.Activities.InArgument> parameters) { return default(System.ServiceModel.Activities.SendParametersContent); }
  }
  public sealed partial class SendMessageChannelCache : System.IDisposable {
    public SendMessageChannelCache() { }
    public SendMessageChannelCache(System.ServiceModel.Activities.ChannelCacheSettings factorySettings, System.ServiceModel.Activities.ChannelCacheSettings channelSettings) { }
    public SendMessageChannelCache(System.ServiceModel.Activities.ChannelCacheSettings factorySettings, System.ServiceModel.Activities.ChannelCacheSettings channelSettings, bool allowUnsafeCaching) { }
    public bool AllowUnsafeCaching { get { return default(bool); } set { } }
    public System.ServiceModel.Activities.ChannelCacheSettings ChannelSettings { get { return default(System.ServiceModel.Activities.ChannelCacheSettings); } set { } }
    public System.ServiceModel.Activities.ChannelCacheSettings FactorySettings { get { return default(System.ServiceModel.Activities.ChannelCacheSettings); } set { } }
    public void Dispose() { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Message")]
  public sealed partial class SendMessageContent : System.ServiceModel.Activities.SendContent {
    public SendMessageContent() { }
    public SendMessageContent(System.Activities.InArgument message) { }
    public SendMessageContent(System.Activities.InArgument message, System.Type declaredMessageType) { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Type DeclaredMessageType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.InArgument Message { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.InArgument); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeDeclaredMessageType() { return default(bool); }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Parameters")]
  public sealed partial class SendParametersContent : System.ServiceModel.Activities.SendContent {
    public SendParametersContent() { }
    public SendParametersContent(System.Collections.Generic.IDictionary<System.String, System.Activities.InArgument> parameters) { }
    public System.Collections.Generic.IDictionary<System.String, System.Activities.InArgument> Parameters { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IDictionary<System.String, System.Activities.InArgument>); } }
  }
  public abstract partial class SendReceiveExtension {
    protected SendReceiveExtension() { }
    public abstract System.ServiceModel.Activities.HostSettings HostSettings { get; }
    public abstract void Cancel(System.Activities.Bookmark bookmark);
    protected abstract void OnRegisterReceive(System.ServiceModel.Activities.ReceiveSettings settings, System.Runtime.DurableInstancing.InstanceKey correlatesWith, System.Activities.Bookmark receiveBookmark);
    public abstract void OnUninitializeCorrelation(System.Runtime.DurableInstancing.InstanceKey correlationKey);
    public void RegisterReceive(System.ServiceModel.Activities.ReceiveSettings settings, System.Runtime.DurableInstancing.InstanceKey correlatesWith, System.Activities.Bookmark receiveBookmark) { }
    public abstract void Send(System.ServiceModel.Activities.MessageContext message, System.ServiceModel.Activities.SendSettings settings, System.Runtime.DurableInstancing.InstanceKey correlatesWith, System.Activities.Bookmark sendCompleteBookmark);
  }
  [System.Windows.Markup.ContentPropertyAttribute("Content")]
  public sealed partial class SendReply : System.Activities.Activity {
    public SendReply() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public string Action { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.ServiceModel.Activities.SendContent Content { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Activities.SendContent); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Activities.CorrelationInitializer> CorrelationInitializers { get { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Activities.CorrelationInitializer>); } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool PersistBeforeSend { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.ServiceModel.Activities.Receive Request { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Activities.Receive); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void CacheMetadata(System.Activities.ActivityMetadata metadata) { }
    public static System.ServiceModel.Activities.SendReply FromOperationDescription(System.ServiceModel.Description.OperationDescription operation, out System.Collections.Generic.IEnumerable<System.ServiceModel.Activities.SendReply> faultReplies) { faultReplies = default(System.Collections.Generic.IEnumerable<System.ServiceModel.Activities.SendReply>); return default(System.ServiceModel.Activities.SendReply); }
  }
  public sealed partial class SendSettings {
    public SendSettings() { }
    public System.ServiceModel.Endpoint Endpoint { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Endpoint); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Uri EndpointAddress { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Uri); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string EndpointConfigurationName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool IsOneWay { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string OwnerDisplayName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Nullable<System.Net.Security.ProtectionLevel> ProtectionLevel { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.Net.Security.ProtectionLevel>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool RequirePersistBeforeSend { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Security.Principal.TokenImpersonationLevel TokenImpersonationLevel { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Security.Principal.TokenImpersonationLevel); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public enum SerializerOption {
    DataContractSerializer = 0,
    XmlSerializer = 1,
  }
  [System.Windows.Markup.ContentPropertyAttribute("Body")]
  public sealed partial class TransactedReceiveScope : System.Activities.NativeActivity {
    public TransactedReceiveScope() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.Activity Body { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Activity); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.ServiceModel.Activities.Receive Request { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Activities.Receive); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.ObjectModel.Collection<System.Activities.Variable> Variables { get { return default(System.Collections.ObjectModel.Collection<System.Activities.Variable>); } }
    protected override void CacheMetadata(System.Activities.NativeActivityMetadata metadata) { }
    protected override void Execute(System.Activities.NativeActivityContext context) { }
  }
  public partial class WorkflowControlClient : System.ServiceModel.ClientBase<System.ServiceModel.Activities.IWorkflowInstanceManagement> {
    public WorkflowControlClient() { }
    public WorkflowControlClient(System.ServiceModel.Activities.WorkflowControlEndpoint workflowEndpoint) { }
    public WorkflowControlClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) { }
    public WorkflowControlClient(string endpointConfigurationName) { }
    public WorkflowControlClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) { }
    public WorkflowControlClient(string endpointConfigurationName, string remoteAddress) { }
    public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> AbandonCompleted { add { } remove { } }
    public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CancelCompleted { add { } remove { } }
    public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> RunCompleted { add { } remove { } }
    public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> SuspendCompleted { add { } remove { } }
    public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> TerminateCompleted { add { } remove { } }
    public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> UnsuspendCompleted { add { } remove { } }
    public void Abandon(System.Guid instanceId) { }
    public void Abandon(System.Guid instanceId, string reason) { }
    public void AbandonAsync(System.Guid instanceId) { }
    public void AbandonAsync(System.Guid instanceId, object userState) { }
    public void AbandonAsync(System.Guid instanceId, string reason) { }
    public void AbandonAsync(System.Guid instanceId, string reason, object userState) { }
    public System.IAsyncResult BeginAbandon(System.Guid instanceId, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginAbandon(System.Guid instanceId, string reason, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginCancel(System.Guid instanceId, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginRun(System.Guid instanceId, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginSuspend(System.Guid instanceId, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginSuspend(System.Guid instanceId, string reason, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginTerminate(System.Guid instanceId, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginTerminate(System.Guid instanceId, string reason, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginUnsuspend(System.Guid instanceId, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public void Cancel(System.Guid instanceId) { }
    public void CancelAsync(System.Guid instanceId) { }
    public void CancelAsync(System.Guid instanceId, object userState) { }
    public void EndAbandon(System.IAsyncResult result) { }
    public void EndCancel(System.IAsyncResult result) { }
    public void EndRun(System.IAsyncResult result) { }
    public void EndSuspend(System.IAsyncResult result) { }
    public void EndTerminate(System.IAsyncResult result) { }
    public void EndUnsuspend(System.IAsyncResult result) { }
    public void Run(System.Guid instanceId) { }
    public void RunAsync(System.Guid instanceId) { }
    public void RunAsync(System.Guid instanceId, object userState) { }
    public void Suspend(System.Guid instanceId) { }
    public void Suspend(System.Guid instanceId, string reason) { }
    public void SuspendAsync(System.Guid instanceId) { }
    public void SuspendAsync(System.Guid instanceId, object userState) { }
    public void SuspendAsync(System.Guid instanceId, string reason) { }
    public void SuspendAsync(System.Guid instanceId, string reason, object userState) { }
    public void Terminate(System.Guid instanceId) { }
    public void Terminate(System.Guid instanceId, string reason) { }
    public void TerminateAsync(System.Guid instanceId) { }
    public void TerminateAsync(System.Guid instanceId, object userState) { }
    public void TerminateAsync(System.Guid instanceId, string reason) { }
    public void TerminateAsync(System.Guid instanceId, string reason, object userState) { }
    public void Unsuspend(System.Guid instanceId) { }
    public void UnsuspendAsync(System.Guid instanceId) { }
    public void UnsuspendAsync(System.Guid instanceId, object userState) { }
  }
  public partial class WorkflowControlEndpoint : System.ServiceModel.Description.ServiceEndpoint {
    public WorkflowControlEndpoint() : base (default(System.ServiceModel.Description.ContractDescription)) { }
    public WorkflowControlEndpoint(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress address) : base (default(System.ServiceModel.Description.ContractDescription)) { }
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public partial class WorkflowCreationContext {
    public WorkflowCreationContext() { }
    [System.Runtime.Serialization.DataMemberAttribute]
    public bool CreateOnly { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.Runtime.Serialization.DataMemberAttribute]
    public bool IsCompletionTransactionRequired { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.Generic.IDictionary<System.String, System.Object> WorkflowArguments { get { return default(System.Collections.Generic.IDictionary<System.String, System.Object>); } }
    protected internal virtual void OnAbort() { }
    protected internal virtual System.IAsyncResult OnBeginWorkflowCompleted(System.Activities.ActivityInstanceState completionState, System.Collections.Generic.IDictionary<System.String, System.Object> workflowOutputs, System.Exception terminationException, System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected internal virtual void OnEndWorkflowCompleted(System.IAsyncResult result) { }
  }
  public abstract partial class WorkflowHostingEndpoint : System.ServiceModel.Description.ServiceEndpoint {
    protected WorkflowHostingEndpoint(System.Type contractType) : base (default(System.ServiceModel.Description.ContractDescription)) { }
    protected WorkflowHostingEndpoint(System.Type contractType, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress address) : base (default(System.ServiceModel.Description.ContractDescription)) { }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.CorrelationQuery> CorrelationQueries { get { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.CorrelationQuery>); } }
    protected internal virtual System.ServiceModel.Activities.WorkflowCreationContext OnGetCreationContext(System.Object[] inputs, System.ServiceModel.OperationContext operationContext, System.Guid instanceId, System.ServiceModel.Activities.WorkflowHostingResponseContext responseContext) { return default(System.ServiceModel.Activities.WorkflowCreationContext); }
    protected internal virtual System.Guid OnGetInstanceId(System.Object[] inputs, System.ServiceModel.OperationContext operationContext) { return default(System.Guid); }
    protected internal virtual System.Activities.Bookmark OnResolveBookmark(System.Object[] inputs, System.ServiceModel.OperationContext operationContext, System.ServiceModel.Activities.WorkflowHostingResponseContext responseContext, out object value) { value = default(object); return default(System.Activities.Bookmark); }
  }
  public sealed partial class WorkflowHostingResponseContext {
    internal WorkflowHostingResponseContext() { }
    public void SendResponse(object returnValue, System.Object[] outputs) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Body")]
  public partial class WorkflowService : System.Activities.Debugger.IDebuggableWorkflowTree {
    public WorkflowService() { }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool AllowBufferedReceive { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.Activity Body { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Activity); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public string ConfigurationName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Activities.WorkflowIdentity DefinitionIdentity { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.WorkflowIdentity); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Endpoint> Endpoints { get { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Endpoint>); } }
    public System.Collections.ObjectModel.Collection<System.Type> ImplementedContracts { get { return default(System.Collections.ObjectModel.Collection<System.Type>); } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.XamlIntegration.ServiceXNameTypeConverter))]
    public System.Xml.Linq.XName Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xml.Linq.XName); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.Generic.IDictionary<System.Activities.WorkflowIdentity, System.Activities.DynamicUpdate.DynamicUpdateMap> UpdateMaps { get { return default(System.Collections.Generic.IDictionary<System.Activities.WorkflowIdentity, System.Activities.DynamicUpdate.DynamicUpdateMap>); } }
    public virtual System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.ServiceModel.Description.ContractDescription> GetContractDescriptions() { return default(System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.ServiceModel.Description.ContractDescription>); }
    public System.Activities.Activity GetWorkflowRoot() { return default(System.Activities.Activity); }
    public System.Activities.Validation.ValidationResults Validate(System.Activities.Validation.ValidationSettings settings) { return default(System.Activities.Validation.ValidationResults); }
  }
  public partial class WorkflowServiceHost : System.ServiceModel.ServiceHostBase {
    protected WorkflowServiceHost() { }
    public WorkflowServiceHost(System.Activities.Activity activity, params System.Uri[] baseAddresses) { }
    public WorkflowServiceHost(object serviceImplementation, params System.Uri[] baseAddresses) { }
    public WorkflowServiceHost(System.ServiceModel.Activities.WorkflowService serviceDefinition, params System.Uri[] baseAddresses) { }
    public System.Activities.Activity Activity { get { return default(System.Activities.Activity); } }
    public System.ServiceModel.Activities.DurableInstancingOptions DurableInstancingOptions { get { return default(System.ServiceModel.Activities.DurableInstancingOptions); } }
    public System.Collections.Generic.ICollection<System.ServiceModel.Activities.WorkflowService> SupportedVersions { get { return default(System.Collections.Generic.ICollection<System.ServiceModel.Activities.WorkflowService>); } }
    public System.Activities.Hosting.WorkflowInstanceExtensionManager WorkflowExtensions { get { return default(System.Activities.Hosting.WorkflowInstanceExtensionManager); } }
    public override void AddServiceEndpoint(System.ServiceModel.Description.ServiceEndpoint endpoint) { }
    public new System.ServiceModel.Description.ServiceEndpoint AddServiceEndpoint(string implementedContract, System.ServiceModel.Channels.Binding binding, string address) { return default(System.ServiceModel.Description.ServiceEndpoint); }
    public new System.ServiceModel.Description.ServiceEndpoint AddServiceEndpoint(string implementedContract, System.ServiceModel.Channels.Binding binding, string address, System.Uri listenUri) { return default(System.ServiceModel.Description.ServiceEndpoint); }
    public new System.ServiceModel.Description.ServiceEndpoint AddServiceEndpoint(string implementedContract, System.ServiceModel.Channels.Binding binding, System.Uri address) { return default(System.ServiceModel.Description.ServiceEndpoint); }
    public new System.ServiceModel.Description.ServiceEndpoint AddServiceEndpoint(string implementedContract, System.ServiceModel.Channels.Binding binding, System.Uri address, System.Uri listenUri) { return default(System.ServiceModel.Description.ServiceEndpoint); }
    public System.ServiceModel.Description.ServiceEndpoint AddServiceEndpoint(System.Xml.Linq.XName serviceContractName, System.ServiceModel.Channels.Binding binding, string address, System.Uri listenUri=null, string behaviorConfigurationName=null) { return default(System.ServiceModel.Description.ServiceEndpoint); }
    public System.ServiceModel.Description.ServiceEndpoint AddServiceEndpoint(System.Xml.Linq.XName serviceContractName, System.ServiceModel.Channels.Binding binding, System.Uri address, System.Uri listenUri=null, string behaviorConfigurationName=null) { return default(System.ServiceModel.Description.ServiceEndpoint); }
    protected override System.ServiceModel.Description.ServiceDescription CreateDescription(out System.Collections.Generic.IDictionary<System.String, System.ServiceModel.Description.ContractDescription> implementedContracts) { implementedContracts = default(System.Collections.Generic.IDictionary<System.String, System.ServiceModel.Description.ContractDescription>); return default(System.ServiceModel.Description.ServiceDescription); }
    protected override void InitializeRuntime() { }
    protected override void OnAbort() { }
    protected override System.IAsyncResult OnBeginClose(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected override void OnClose(System.TimeSpan timeout) { }
    protected override void OnEndClose(System.IAsyncResult result) { }
  }
  public partial class WorkflowUpdateableControlClient : System.ServiceModel.ClientBase<System.ServiceModel.Activities.IWorkflowUpdateableInstanceManagement> {
    public WorkflowUpdateableControlClient() { }
    public WorkflowUpdateableControlClient(System.ServiceModel.Activities.WorkflowControlEndpoint workflowEndpoint) { }
    public WorkflowUpdateableControlClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) { }
    public WorkflowUpdateableControlClient(string endpointConfigurationName) { }
    public WorkflowUpdateableControlClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) { }
    public WorkflowUpdateableControlClient(string endpointConfigurationName, string remoteAddress) { }
    public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> AbandonCompleted { add { } remove { } }
    public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CancelCompleted { add { } remove { } }
    public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> RunCompleted { add { } remove { } }
    public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> SuspendCompleted { add { } remove { } }
    public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> TerminateCompleted { add { } remove { } }
    public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> UnsuspendCompleted { add { } remove { } }
    public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> UpdateCompleted { add { } remove { } }
    public void Abandon(System.Guid instanceId) { }
    public void Abandon(System.Guid instanceId, string reason) { }
    public void AbandonAsync(System.Guid instanceId) { }
    public void AbandonAsync(System.Guid instanceId, object userState) { }
    public void AbandonAsync(System.Guid instanceId, string reason) { }
    public void AbandonAsync(System.Guid instanceId, string reason, object userState) { }
    public System.IAsyncResult BeginAbandon(System.Guid instanceId, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginAbandon(System.Guid instanceId, string reason, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginCancel(System.Guid instanceId, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginRun(System.Guid instanceId, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginSuspend(System.Guid instanceId, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginSuspend(System.Guid instanceId, string reason, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginTerminate(System.Guid instanceId, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginTerminate(System.Guid instanceId, string reason, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginUnsuspend(System.Guid instanceId, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginUpdate(System.Guid instanceId, System.Activities.WorkflowIdentity updatedDefinitionIdentity, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public void Cancel(System.Guid instanceId) { }
    public void CancelAsync(System.Guid instanceId) { }
    public void CancelAsync(System.Guid instanceId, object userState) { }
    public void EndAbandon(System.IAsyncResult result) { }
    public void EndCancel(System.IAsyncResult result) { }
    public void EndRun(System.IAsyncResult result) { }
    public void EndSuspend(System.IAsyncResult result) { }
    public void EndTerminate(System.IAsyncResult result) { }
    public void EndUnsuspend(System.IAsyncResult result) { }
    public void EndUpdate(System.IAsyncResult result) { }
    public void Run(System.Guid instanceId) { }
    public void RunAsync(System.Guid instanceId) { }
    public void RunAsync(System.Guid instanceId, object userState) { }
    public void Suspend(System.Guid instanceId) { }
    public void Suspend(System.Guid instanceId, string reason) { }
    public void SuspendAsync(System.Guid instanceId) { }
    public void SuspendAsync(System.Guid instanceId, object userState) { }
    public void SuspendAsync(System.Guid instanceId, string reason) { }
    public void SuspendAsync(System.Guid instanceId, string reason, object userState) { }
    public void Terminate(System.Guid instanceId) { }
    public void Terminate(System.Guid instanceId, string reason) { }
    public void TerminateAsync(System.Guid instanceId) { }
    public void TerminateAsync(System.Guid instanceId, object userState) { }
    public void TerminateAsync(System.Guid instanceId, string reason) { }
    public void TerminateAsync(System.Guid instanceId, string reason, object userState) { }
    public void Unsuspend(System.Guid instanceId) { }
    public void UnsuspendAsync(System.Guid instanceId) { }
    public void UnsuspendAsync(System.Guid instanceId, object userState) { }
    public void Update(System.Guid instanceId, System.Activities.WorkflowIdentity updatedDefinitionIdentity) { }
    public void UpdateAsync(System.Guid instanceId, System.Activities.WorkflowIdentity updatedDefinitionIdentity) { }
    public void UpdateAsync(System.Guid instanceId, System.Activities.WorkflowIdentity updatedDefinitionIdentity, object userState) { }
  }
}
namespace System.ServiceModel.Activities.Configuration {
  public sealed partial class BufferedReceiveElement : System.ServiceModel.Configuration.BehaviorExtensionElement {
    public BufferedReceiveElement() { }
    public override System.Type BehaviorType { get { return default(System.Type); } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.Int32Converter))]
    [System.Configuration.ConfigurationPropertyAttribute("maxPendingMessagesPerChannel", DefaultValue=512)]
    [System.Configuration.IntegerValidatorAttribute(MinValue=1, MaxValue=2147483647)]
    public int MaxPendingMessagesPerChannel { get { return default(int); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    protected internal override object CreateBehavior() { return default(object); }
  }
  public sealed partial class ChannelSettingsElement : System.Configuration.ConfigurationElement {
    public ChannelSettingsElement() { }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Configuration.TimeSpanOrInfiniteConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("idleTimeout", DefaultValue="00:02:00")]
    [System.ServiceModel.Configuration.ServiceModelTimeSpanValidatorAttribute(MinValueString="00:00:00")]
    public System.TimeSpan IdleTimeout { get { return default(System.TimeSpan); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Configuration.TimeSpanOrInfiniteConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("leaseTimeout", DefaultValue="00:05:00")]
    [System.ServiceModel.Configuration.ServiceModelTimeSpanValidatorAttribute(MinValueString="00:00:00")]
    public System.TimeSpan LeaseTimeout { get { return default(System.TimeSpan); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxItemsInCache", DefaultValue="16")]
    [System.Configuration.IntegerValidatorAttribute(MinValue=0)]
    public int MaxItemsInCache { get { return default(int); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  public partial class EtwTrackingBehaviorElement : System.ServiceModel.Configuration.BehaviorExtensionElement {
    public EtwTrackingBehaviorElement() { }
    public override System.Type BehaviorType { get { return default(System.Type); } }
    [System.Configuration.ConfigurationPropertyAttribute("profileName", DefaultValue="", Options=(System.Configuration.ConfigurationPropertyOptions)(4))]
    [System.Configuration.StringValidatorAttribute(MinLength=0)]
    public string ProfileName { get { return default(string); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    protected internal override object CreateBehavior() { return default(object); }
  }
  public sealed partial class FactorySettingsElement : System.Configuration.ConfigurationElement {
    public FactorySettingsElement() { }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Configuration.TimeSpanOrInfiniteConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("idleTimeout", DefaultValue="00:02:00")]
    [System.ServiceModel.Configuration.ServiceModelTimeSpanValidatorAttribute(MinValueString="00:00:00")]
    public System.TimeSpan IdleTimeout { get { return default(System.TimeSpan); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Configuration.TimeSpanOrInfiniteConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("leaseTimeout", DefaultValue="Infinite")]
    [System.ServiceModel.Configuration.ServiceModelTimeSpanValidatorAttribute(MinValueString="00:00:00")]
    public System.TimeSpan LeaseTimeout { get { return default(System.TimeSpan); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxItemsInCache", DefaultValue="16")]
    [System.Configuration.IntegerValidatorAttribute(MinValue=0)]
    public int MaxItemsInCache { get { return default(int); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  public sealed partial class SendMessageChannelCacheElement : System.ServiceModel.Configuration.BehaviorExtensionElement {
    public SendMessageChannelCacheElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("allowUnsafeCaching", DefaultValue=false)]
    public bool AllowUnsafeCaching { get { return default(bool); } set { } }
    public override System.Type BehaviorType { get { return default(System.Type); } }
    [System.Configuration.ConfigurationPropertyAttribute("channelSettings")]
    public System.ServiceModel.Activities.Configuration.ChannelSettingsElement ChannelSettings { get { return default(System.ServiceModel.Activities.Configuration.ChannelSettingsElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("factorySettings")]
    public System.ServiceModel.Activities.Configuration.FactorySettingsElement FactorySettings { get { return default(System.ServiceModel.Activities.Configuration.FactorySettingsElement); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    protected internal override object CreateBehavior() { return default(object); }
  }
  public sealed partial class ServiceModelActivitiesSectionGroup : System.Configuration.ConfigurationSectionGroup {
    public ServiceModelActivitiesSectionGroup() { }
    public System.ServiceModel.Activities.Configuration.WorkflowHostingOptionsSection WorkflowHostingOptionsSection { get { return default(System.ServiceModel.Activities.Configuration.WorkflowHostingOptionsSection); } }
    public static System.ServiceModel.Activities.Configuration.ServiceModelActivitiesSectionGroup GetSectionGroup(System.Configuration.Configuration config) { return default(System.ServiceModel.Activities.Configuration.ServiceModelActivitiesSectionGroup); }
  }
  public partial class SqlWorkflowInstanceStoreElement : System.ServiceModel.Configuration.BehaviorExtensionElement {
    public SqlWorkflowInstanceStoreElement() { }
    public override System.Type BehaviorType { get { return default(System.Type); } }
    [System.Configuration.ConfigurationPropertyAttribute("connectionString", IsRequired=false)]
    [System.Configuration.StringValidatorAttribute(MinLength=0)]
    public string ConnectionString { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("connectionStringName", IsRequired=false)]
    [System.Configuration.StringValidatorAttribute(MinLength=0)]
    public string ConnectionStringName { get { return default(string); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Configuration.TimeSpanOrInfiniteConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("hostLockRenewalPeriod", IsRequired=false, DefaultValue="00:00:30.0")]
    [System.Configuration.PositiveTimeSpanValidatorAttribute]
    public System.TimeSpan HostLockRenewalPeriod { get { return default(System.TimeSpan); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("instanceCompletionAction", IsRequired=false, DefaultValue=(System.Activities.DurableInstancing.InstanceCompletionAction)(1))]
    public System.Activities.DurableInstancing.InstanceCompletionAction InstanceCompletionAction { get { return default(System.Activities.DurableInstancing.InstanceCompletionAction); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("instanceEncodingOption", IsRequired=false, DefaultValue=(System.Activities.DurableInstancing.InstanceEncodingOption)(1))]
    public System.Activities.DurableInstancing.InstanceEncodingOption InstanceEncodingOption { get { return default(System.Activities.DurableInstancing.InstanceEncodingOption); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("instanceLockedExceptionAction", IsRequired=false, DefaultValue=(System.Activities.DurableInstancing.InstanceLockedExceptionAction)(0))]
    public System.Activities.DurableInstancing.InstanceLockedExceptionAction InstanceLockedExceptionAction { get { return default(System.Activities.DurableInstancing.InstanceLockedExceptionAction); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxConnectionRetries", IsRequired=false, DefaultValue=4)]
    [System.Configuration.IntegerValidatorAttribute(MinValue=0)]
    public int MaxConnectionRetries { get { return default(int); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Configuration.TimeSpanOrInfiniteConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("runnableInstancesDetectionPeriod", IsRequired=false, DefaultValue="00:00:05.0")]
    [System.Configuration.PositiveTimeSpanValidatorAttribute]
    public System.TimeSpan RunnableInstancesDetectionPeriod { get { return default(System.TimeSpan); } set { } }
    protected internal override object CreateBehavior() { return default(object); }
  }
  public partial class WorkflowControlEndpointCollectionElement : System.ServiceModel.Configuration.StandardEndpointCollectionElement<System.ServiceModel.Activities.WorkflowControlEndpoint, System.ServiceModel.Activities.Configuration.WorkflowControlEndpointElement> {
    public WorkflowControlEndpointCollectionElement() { }
  }
  public partial class WorkflowControlEndpointElement : System.ServiceModel.Configuration.StandardEndpointElement {
    public WorkflowControlEndpointElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("address", DefaultValue="")]
    public System.Uri Address { get { return default(System.Uri); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("binding", DefaultValue="")]
    [System.Configuration.StringValidatorAttribute(MinLength=0)]
    public string Binding { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("bindingConfiguration", DefaultValue="")]
    [System.Configuration.StringValidatorAttribute(MinLength=0)]
    public string BindingConfiguration { get { return default(string); } set { } }
    protected internal override System.Type EndpointType { get { return default(System.Type); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    protected internal override System.ServiceModel.Description.ServiceEndpoint CreateServiceEndpoint(System.ServiceModel.Description.ContractDescription contractDescription) { return default(System.ServiceModel.Description.ServiceEndpoint); }
    protected override void OnApplyConfiguration(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Configuration.ChannelEndpointElement channelEndpointElement) { }
    protected override void OnApplyConfiguration(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Configuration.ServiceEndpointElement serviceEndpointElement) { }
    protected override void OnInitializeAndValidate(System.ServiceModel.Configuration.ChannelEndpointElement channelEndpointElement) { }
    protected override void OnInitializeAndValidate(System.ServiceModel.Configuration.ServiceEndpointElement serviceEndpointElement) { }
  }
  public sealed partial class WorkflowHostingOptionsSection : System.Configuration.ConfigurationSection {
    public WorkflowHostingOptionsSection() { }
    [System.Configuration.ConfigurationPropertyAttribute("overrideSiteName", DefaultValue="false")]
    public bool OverrideSiteName { get { return default(bool); } set { } }
  }
  public sealed partial class WorkflowIdleElement : System.ServiceModel.Configuration.BehaviorExtensionElement {
    public WorkflowIdleElement() { }
    public override System.Type BehaviorType { get { return default(System.Type); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Configuration.TimeSpanOrInfiniteConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("timeToPersist", DefaultValue="Infinite")]
    [System.ServiceModel.Configuration.ServiceModelTimeSpanValidatorAttribute(MinValueString="00:00:00")]
    public System.TimeSpan TimeToPersist { get { return default(System.TimeSpan); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Configuration.TimeSpanOrInfiniteConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("timeToUnload", DefaultValue="00:01:00")]
    [System.ServiceModel.Configuration.ServiceModelTimeSpanValidatorAttribute(MinValueString="00:00:00")]
    public System.TimeSpan TimeToUnload { get { return default(System.TimeSpan); } set { } }
    protected internal override object CreateBehavior() { return default(object); }
  }
  public partial class WorkflowInstanceManagementElement : System.ServiceModel.Configuration.BehaviorExtensionElement {
    public WorkflowInstanceManagementElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("authorizedWindowsGroup", IsRequired=false)]
    [System.Configuration.StringValidatorAttribute(MinLength=0)]
    public string AuthorizedWindowsGroup { get { return default(string); } set { } }
    public override System.Type BehaviorType { get { return default(System.Type); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    protected internal override object CreateBehavior() { return default(object); }
  }
  public sealed partial class WorkflowUnhandledExceptionElement : System.ServiceModel.Configuration.BehaviorExtensionElement {
    public WorkflowUnhandledExceptionElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("action", DefaultValue=(System.ServiceModel.Activities.Description.WorkflowUnhandledExceptionAction)(3))]
    [System.ServiceModel.Activities.Configuration.ServiceModelActivitiesEnumValidatorAttribute(typeof(System.ServiceModel.Activities.Description.WorkflowUnhandledExceptionActionHelper))]
    public System.ServiceModel.Activities.Description.WorkflowUnhandledExceptionAction Action { get { return default(System.ServiceModel.Activities.Description.WorkflowUnhandledExceptionAction); } set { } }
    public override System.Type BehaviorType { get { return default(System.Type); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    protected internal override object CreateBehavior() { return default(object); }
  }
}
namespace System.ServiceModel.Activities.Description {
  public sealed partial class BufferedReceiveServiceBehavior : System.ServiceModel.Description.IServiceBehavior {
    public BufferedReceiveServiceBehavior() { }
    public int MaxPendingMessagesPerChannel { get { return default(int); } set { } }
    public void AddBindingParameters(System.ServiceModel.Description.ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase, System.Collections.ObjectModel.Collection<System.ServiceModel.Description.ServiceEndpoint> endpoints, System.ServiceModel.Channels.BindingParameterCollection bindingParameters) { }
    public void ApplyDispatchBehavior(System.ServiceModel.Description.ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase) { }
    public void Validate(System.ServiceModel.Description.ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase) { }
  }
  public partial class EtwTrackingBehavior : System.ServiceModel.Description.IServiceBehavior {
    public EtwTrackingBehavior() { }
    public string ProfileName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public virtual void AddBindingParameters(System.ServiceModel.Description.ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase, System.Collections.ObjectModel.Collection<System.ServiceModel.Description.ServiceEndpoint> endpoints, System.ServiceModel.Channels.BindingParameterCollection bindingParameters) { }
    public virtual void ApplyDispatchBehavior(System.ServiceModel.Description.ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase) { }
    public virtual void Validate(System.ServiceModel.Description.ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase) { }
  }
  public partial class SqlWorkflowInstanceStoreBehavior : System.ServiceModel.Description.IServiceBehavior {
    public SqlWorkflowInstanceStoreBehavior() { }
    public SqlWorkflowInstanceStoreBehavior(string connectionString) { }
    public string ConnectionString { get { return default(string); } set { } }
    public System.TimeSpan HostLockRenewalPeriod { get { return default(System.TimeSpan); } set { } }
    public System.Activities.DurableInstancing.InstanceCompletionAction InstanceCompletionAction { get { return default(System.Activities.DurableInstancing.InstanceCompletionAction); } set { } }
    public System.Activities.DurableInstancing.InstanceEncodingOption InstanceEncodingOption { get { return default(System.Activities.DurableInstancing.InstanceEncodingOption); } set { } }
    public System.Activities.DurableInstancing.InstanceLockedExceptionAction InstanceLockedExceptionAction { get { return default(System.Activities.DurableInstancing.InstanceLockedExceptionAction); } set { } }
    public int MaxConnectionRetries { get { return default(int); } set { } }
    public System.TimeSpan RunnableInstancesDetectionPeriod { get { return default(System.TimeSpan); } set { } }
    public void AddBindingParameters(System.ServiceModel.Description.ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase, System.Collections.ObjectModel.Collection<System.ServiceModel.Description.ServiceEndpoint> endpoints, System.ServiceModel.Channels.BindingParameterCollection bindingParameters) { }
    public void ApplyDispatchBehavior(System.ServiceModel.Description.ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase) { }
    public void Promote(string name, System.Collections.Generic.IEnumerable<System.Xml.Linq.XName> promoteAsSqlVariant, System.Collections.Generic.IEnumerable<System.Xml.Linq.XName> promoteAsBinary) { }
    public void Validate(System.ServiceModel.Description.ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(1024), AllowMultiple=false)]
  public sealed partial class WorkflowContractBehaviorAttribute : System.Attribute, System.ServiceModel.Description.IContractBehavior {
    public WorkflowContractBehaviorAttribute() { }
    public void AddBindingParameters(System.ServiceModel.Description.ContractDescription contractDescription, System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Channels.BindingParameterCollection bindingParameters) { }
    public void ApplyClientBehavior(System.ServiceModel.Description.ContractDescription contractDescription, System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.ClientRuntime clientRuntime) { }
    public void ApplyDispatchBehavior(System.ServiceModel.Description.ContractDescription contractDescription, System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.DispatchRuntime dispatchRuntime) { }
    public void Validate(System.ServiceModel.Description.ContractDescription contractDescription, System.ServiceModel.Description.ServiceEndpoint endpoint) { }
  }
  public partial class WorkflowIdleBehavior : System.ServiceModel.Description.IServiceBehavior {
    public WorkflowIdleBehavior() { }
    public System.TimeSpan TimeToPersist { get { return default(System.TimeSpan); } set { } }
    public System.TimeSpan TimeToUnload { get { return default(System.TimeSpan); } set { } }
    public void AddBindingParameters(System.ServiceModel.Description.ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase, System.Collections.ObjectModel.Collection<System.ServiceModel.Description.ServiceEndpoint> endpoints, System.ServiceModel.Channels.BindingParameterCollection bindingParameters) { }
    public void ApplyDispatchBehavior(System.ServiceModel.Description.ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase) { }
    public void Validate(System.ServiceModel.Description.ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase) { }
  }
  public sealed partial class WorkflowInstanceManagementBehavior : System.ServiceModel.Description.IServiceBehavior {
    public const string ControlEndpointAddress = "System.ServiceModel.Activities_IWorkflowInstanceManagement";
    public WorkflowInstanceManagementBehavior() { }
    public static System.ServiceModel.Channels.Binding HttpControlEndpointBinding { get { return default(System.ServiceModel.Channels.Binding); } }
    public static System.ServiceModel.Channels.Binding NamedPipeControlEndpointBinding { get { return default(System.ServiceModel.Channels.Binding); } }
    public string WindowsGroup { get { return default(string); } set { } }
    public void AddBindingParameters(System.ServiceModel.Description.ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase, System.Collections.ObjectModel.Collection<System.ServiceModel.Description.ServiceEndpoint> endpoints, System.ServiceModel.Channels.BindingParameterCollection bindingParameters) { }
    public void ApplyDispatchBehavior(System.ServiceModel.Description.ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase) { }
    public void Validate(System.ServiceModel.Description.ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase) { }
  }
  public enum WorkflowUnhandledExceptionAction {
    Abandon = 0,
    AbandonAndSuspend = 3,
    Cancel = 1,
    Terminate = 2,
  }
  public partial class WorkflowUnhandledExceptionBehavior : System.ServiceModel.Description.IServiceBehavior {
    public WorkflowUnhandledExceptionBehavior() { }
    public System.ServiceModel.Activities.Description.WorkflowUnhandledExceptionAction Action { get { return default(System.ServiceModel.Activities.Description.WorkflowUnhandledExceptionAction); } set { } }
    public void AddBindingParameters(System.ServiceModel.Description.ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase, System.Collections.ObjectModel.Collection<System.ServiceModel.Description.ServiceEndpoint> endpoints, System.ServiceModel.Channels.BindingParameterCollection bindingParameters) { }
    public void ApplyDispatchBehavior(System.ServiceModel.Description.ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase) { }
    public void Validate(System.ServiceModel.Description.ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase) { }
  }
}
namespace System.ServiceModel.Activities.Tracking {
  public partial class ReceiveMessageRecord : System.Activities.Tracking.CustomTrackingRecord {
    protected ReceiveMessageRecord(System.ServiceModel.Activities.Tracking.ReceiveMessageRecord record) : base (default(string)) { }
    public ReceiveMessageRecord(string name) : base (default(string)) { }
    public System.Guid E2EActivityId { get { return default(System.Guid); } }
    public System.Guid MessageId { get { return default(System.Guid); } }
    protected override System.Activities.Tracking.TrackingRecord Clone() { return default(System.Activities.Tracking.TrackingRecord); }
  }
  public partial class SendMessageRecord : System.Activities.Tracking.CustomTrackingRecord {
    protected SendMessageRecord(System.ServiceModel.Activities.Tracking.SendMessageRecord record) : base (default(string)) { }
    public SendMessageRecord(string name) : base (default(string)) { }
    public System.Guid E2EActivityId { get { return default(System.Guid); } set { } }
    protected override System.Activities.Tracking.TrackingRecord Clone() { return default(System.Activities.Tracking.TrackingRecord); }
  }
}
namespace System.ServiceModel.Activities.Tracking.Configuration {
  public partial class ActivityScheduledQueryElement : System.ServiceModel.Activities.Tracking.Configuration.TrackingQueryElement {
    public ActivityScheduledQueryElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("activityName", IsKey=true, DefaultValue="*")]
    [System.Configuration.StringValidatorAttribute(MinLength=1)]
    public string ActivityName { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("childActivityName", IsKey=true, DefaultValue="*")]
    [System.Configuration.StringValidatorAttribute(MinLength=1)]
    public string ChildActivityName { get { return default(string); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    protected override System.Activities.Tracking.TrackingQuery NewTrackingQuery() { return default(System.Activities.Tracking.TrackingQuery); }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.ServiceModel.Activities.Tracking.Configuration.ActivityScheduledQueryElement), CollectionType=(System.Configuration.ConfigurationElementCollectionType)(0), AddItemName="activityScheduledQuery")]
  public partial class ActivityScheduledQueryElementCollection : System.ServiceModel.Activities.Tracking.Configuration.TrackingConfigurationCollection<System.ServiceModel.Activities.Tracking.Configuration.ActivityScheduledQueryElement> {
    public ActivityScheduledQueryElementCollection() { }
    protected override string ElementName { get { return default(string); } }
  }
  public partial class ActivityStateQueryElement : System.ServiceModel.Activities.Tracking.Configuration.TrackingQueryElement {
    public ActivityStateQueryElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("activityName", IsKey=true, DefaultValue="*")]
    [System.Configuration.StringValidatorAttribute(MinLength=1)]
    public string ActivityName { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("arguments")]
    public System.ServiceModel.Activities.Tracking.Configuration.ArgumentElementCollection Arguments { get { return default(System.ServiceModel.Activities.Tracking.Configuration.ArgumentElementCollection); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("states")]
    public System.ServiceModel.Activities.Tracking.Configuration.StateElementCollection States { get { return default(System.ServiceModel.Activities.Tracking.Configuration.StateElementCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("variables")]
    public System.ServiceModel.Activities.Tracking.Configuration.VariableElementCollection Variables { get { return default(System.ServiceModel.Activities.Tracking.Configuration.VariableElementCollection); } }
    protected override System.Activities.Tracking.TrackingQuery NewTrackingQuery() { return default(System.Activities.Tracking.TrackingQuery); }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.ServiceModel.Activities.Tracking.Configuration.ActivityStateQueryElement), CollectionType=(System.Configuration.ConfigurationElementCollectionType)(0), AddItemName="activityStateQuery")]
  public partial class ActivityStateQueryElementCollection : System.ServiceModel.Activities.Tracking.Configuration.TrackingConfigurationCollection<System.ServiceModel.Activities.Tracking.Configuration.ActivityStateQueryElement> {
    public ActivityStateQueryElementCollection() { }
    protected override string ElementName { get { return default(string); } }
  }
  public partial class AnnotationElement : System.ServiceModel.Activities.Tracking.Configuration.TrackingConfigurationElement {
    public AnnotationElement() { }
    public override object ElementKey { get { return default(object); } }
    [System.Configuration.ConfigurationPropertyAttribute("name", IsKey=true, IsRequired=true)]
    [System.Configuration.StringValidatorAttribute(MinLength=0)]
    public string Name { get { return default(string); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("value", IsRequired=true)]
    [System.Configuration.StringValidatorAttribute(MinLength=0)]
    public string Value { get { return default(string); } set { } }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.ServiceModel.Activities.Tracking.Configuration.AnnotationElement), CollectionType=(System.Configuration.ConfigurationElementCollectionType)(0), AddItemName="annotation")]
  public partial class AnnotationElementCollection : System.ServiceModel.Activities.Tracking.Configuration.TrackingConfigurationCollection<System.ServiceModel.Activities.Tracking.Configuration.AnnotationElement> {
    public AnnotationElementCollection() { }
    protected override string ElementName { get { return default(string); } }
  }
  public partial class ArgumentElement : System.ServiceModel.Activities.Tracking.Configuration.TrackingConfigurationElement {
    public ArgumentElement() { }
    public override object ElementKey { get { return default(object); } }
    [System.Configuration.ConfigurationPropertyAttribute("name", IsKey=true, IsRequired=true)]
    [System.Configuration.StringValidatorAttribute(MinLength=0)]
    public string Name { get { return default(string); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.ServiceModel.Activities.Tracking.Configuration.ArgumentElement), CollectionType=(System.Configuration.ConfigurationElementCollectionType)(0), AddItemName="argument")]
  public partial class ArgumentElementCollection : System.ServiceModel.Activities.Tracking.Configuration.TrackingConfigurationCollection<System.ServiceModel.Activities.Tracking.Configuration.ArgumentElement> {
    public ArgumentElementCollection() { }
    protected override string ElementName { get { return default(string); } }
  }
  public partial class BookmarkResumptionQueryElement : System.ServiceModel.Activities.Tracking.Configuration.TrackingQueryElement {
    public BookmarkResumptionQueryElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("name", IsKey=true, DefaultValue="*")]
    [System.Configuration.StringValidatorAttribute(MinLength=0)]
    public string Name { get { return default(string); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    protected override System.Activities.Tracking.TrackingQuery NewTrackingQuery() { return default(System.Activities.Tracking.TrackingQuery); }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.ServiceModel.Activities.Tracking.Configuration.BookmarkResumptionQueryElement), CollectionType=(System.Configuration.ConfigurationElementCollectionType)(0), AddItemName="bookmarkResumptionQuery")]
  public partial class BookmarkResumptionQueryElementCollection : System.ServiceModel.Activities.Tracking.Configuration.TrackingConfigurationCollection<System.ServiceModel.Activities.Tracking.Configuration.BookmarkResumptionQueryElement> {
    public BookmarkResumptionQueryElementCollection() { }
    protected override string ElementName { get { return default(string); } }
  }
  public partial class CancelRequestedQueryElement : System.ServiceModel.Activities.Tracking.Configuration.TrackingQueryElement {
    public CancelRequestedQueryElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("activityName", IsKey=true, DefaultValue="*")]
    [System.Configuration.StringValidatorAttribute(MinLength=1)]
    public string ActivityName { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("childActivityName", DefaultValue="*")]
    [System.Configuration.StringValidatorAttribute(MinLength=1)]
    public string ChildActivityName { get { return default(string); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    protected override System.Activities.Tracking.TrackingQuery NewTrackingQuery() { return default(System.Activities.Tracking.TrackingQuery); }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.ServiceModel.Activities.Tracking.Configuration.CancelRequestedQueryElement), CollectionType=(System.Configuration.ConfigurationElementCollectionType)(0), AddItemName="cancelRequestedQuery")]
  public partial class CancelRequestedQueryElementCollection : System.ServiceModel.Activities.Tracking.Configuration.TrackingConfigurationCollection<System.ServiceModel.Activities.Tracking.Configuration.CancelRequestedQueryElement> {
    public CancelRequestedQueryElementCollection() { }
    protected override string ElementName { get { return default(string); } }
  }
  public partial class CustomTrackingQueryElement : System.ServiceModel.Activities.Tracking.Configuration.TrackingQueryElement {
    public CustomTrackingQueryElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("activityName", IsKey=true, DefaultValue="*")]
    [System.Configuration.StringValidatorAttribute(MinLength=1)]
    public string ActivityName { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("name", IsKey=true, DefaultValue="*")]
    [System.Configuration.StringValidatorAttribute(MinLength=0)]
    public string Name { get { return default(string); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    protected override System.Activities.Tracking.TrackingQuery NewTrackingQuery() { return default(System.Activities.Tracking.TrackingQuery); }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.ServiceModel.Activities.Tracking.Configuration.CustomTrackingQueryElement), CollectionType=(System.Configuration.ConfigurationElementCollectionType)(0), AddItemName="customTrackingQuery")]
  public partial class CustomTrackingQueryElementCollection : System.ServiceModel.Activities.Tracking.Configuration.TrackingConfigurationCollection<System.ServiceModel.Activities.Tracking.Configuration.CustomTrackingQueryElement> {
    public CustomTrackingQueryElementCollection() { }
    protected override string ElementName { get { return default(string); } }
  }
  public partial class FaultPropagationQueryElement : System.ServiceModel.Activities.Tracking.Configuration.TrackingQueryElement {
    public FaultPropagationQueryElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("faultHandlerActivityName", IsKey=true, DefaultValue="*")]
    [System.Configuration.StringValidatorAttribute(MinLength=1)]
    public string FaultHandlerActivityName { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("faultSourceActivityName", IsKey=true, DefaultValue="*")]
    [System.Configuration.StringValidatorAttribute(MinLength=1)]
    public string FaultSourceActivityName { get { return default(string); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    protected override System.Activities.Tracking.TrackingQuery NewTrackingQuery() { return default(System.Activities.Tracking.TrackingQuery); }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.ServiceModel.Activities.Tracking.Configuration.FaultPropagationQueryElement), CollectionType=(System.Configuration.ConfigurationElementCollectionType)(0), AddItemName="faultPropagationQuery")]
  public partial class FaultPropagationQueryElementCollection : System.ServiceModel.Activities.Tracking.Configuration.TrackingConfigurationCollection<System.ServiceModel.Activities.Tracking.Configuration.FaultPropagationQueryElement> {
    public FaultPropagationQueryElementCollection() { }
    protected override string ElementName { get { return default(string); } }
  }
  public partial class ProfileElement : System.ServiceModel.Activities.Tracking.Configuration.TrackingConfigurationElement {
    public ProfileElement() { }
    public override object ElementKey { get { return default(object); } }
    [System.Configuration.ConfigurationPropertyAttribute("implementationVisibility", DefaultValue=(System.Activities.Tracking.ImplementationVisibility)(0))]
    [System.ServiceModel.Activities.Configuration.ServiceModelActivitiesEnumValidatorAttribute(typeof(System.ServiceModel.Activities.Tracking.Configuration.ImplementationVisibilityHelper))]
    public System.Activities.Tracking.ImplementationVisibility ImplementationVisibility { get { return default(System.Activities.Tracking.ImplementationVisibility); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("name", IsKey=true, IsRequired=true)]
    [System.Configuration.StringValidatorAttribute(MinLength=0)]
    public string Name { get { return default(string); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("", IsDefaultCollection=true)]
    public System.ServiceModel.Activities.Tracking.Configuration.ProfileWorkflowElementCollection Workflows { get { return default(System.ServiceModel.Activities.Tracking.Configuration.ProfileWorkflowElementCollection); } }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.ServiceModel.Activities.Tracking.Configuration.ProfileElement), AddItemName="trackingProfile", RemoveItemName="remove", ClearItemsName="clear")]
  public sealed partial class ProfileElementCollection : System.ServiceModel.Activities.Tracking.Configuration.TrackingConfigurationCollection<System.ServiceModel.Activities.Tracking.Configuration.ProfileElement> {
    internal ProfileElementCollection() { }
    public override System.Configuration.ConfigurationElementCollectionType CollectionType { get { return default(System.Configuration.ConfigurationElementCollectionType); } }
  }
  public partial class ProfileWorkflowElement : System.ServiceModel.Activities.Tracking.Configuration.TrackingConfigurationElement {
    public ProfileWorkflowElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("activityDefinitionId", IsKey=true, DefaultValue="*")]
    [System.Configuration.StringValidatorAttribute(MinLength=1)]
    public string ActivityDefinitionId { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("activityScheduledQueries")]
    public System.ServiceModel.Activities.Tracking.Configuration.ActivityScheduledQueryElementCollection ActivityScheduledQueries { get { return default(System.ServiceModel.Activities.Tracking.Configuration.ActivityScheduledQueryElementCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("activityStateQueries")]
    public System.ServiceModel.Activities.Tracking.Configuration.ActivityStateQueryElementCollection ActivityStateQueries { get { return default(System.ServiceModel.Activities.Tracking.Configuration.ActivityStateQueryElementCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("bookmarkResumptionQueries")]
    public System.ServiceModel.Activities.Tracking.Configuration.BookmarkResumptionQueryElementCollection BookmarkResumptionQueries { get { return default(System.ServiceModel.Activities.Tracking.Configuration.BookmarkResumptionQueryElementCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("cancelRequestedQueries")]
    public System.ServiceModel.Activities.Tracking.Configuration.CancelRequestedQueryElementCollection CancelRequestedQueries { get { return default(System.ServiceModel.Activities.Tracking.Configuration.CancelRequestedQueryElementCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("customTrackingQueries")]
    public System.ServiceModel.Activities.Tracking.Configuration.CustomTrackingQueryElementCollection CustomTrackingQueries { get { return default(System.ServiceModel.Activities.Tracking.Configuration.CustomTrackingQueryElementCollection); } }
    public override object ElementKey { get { return default(object); } }
    [System.Configuration.ConfigurationPropertyAttribute("faultPropagationQueries")]
    public System.ServiceModel.Activities.Tracking.Configuration.FaultPropagationQueryElementCollection FaultPropagationQueries { get { return default(System.ServiceModel.Activities.Tracking.Configuration.FaultPropagationQueryElementCollection); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("stateMachineStateQueries")]
    public System.ServiceModel.Activities.Tracking.Configuration.StateMachineStateQueryElementCollection StateMachineStateQueries { get { return default(System.ServiceModel.Activities.Tracking.Configuration.StateMachineStateQueryElementCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("workflowInstanceQueries")]
    public System.ServiceModel.Activities.Tracking.Configuration.WorkflowInstanceQueryElementCollection WorkflowInstanceQueries { get { return default(System.ServiceModel.Activities.Tracking.Configuration.WorkflowInstanceQueryElementCollection); } }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.ServiceModel.Activities.Tracking.Configuration.ProfileWorkflowElement), CollectionType=(System.Configuration.ConfigurationElementCollectionType)(0), AddItemName="workflow")]
  public partial class ProfileWorkflowElementCollection : System.ServiceModel.Activities.Tracking.Configuration.TrackingConfigurationCollection<System.ServiceModel.Activities.Tracking.Configuration.ProfileWorkflowElement> {
    public ProfileWorkflowElementCollection() { }
    protected override string ElementName { get { return default(string); } }
  }
  public partial class StateElement : System.ServiceModel.Activities.Tracking.Configuration.TrackingConfigurationElement {
    public StateElement() { }
    public override object ElementKey { get { return default(object); } }
    [System.Configuration.ConfigurationPropertyAttribute("name", IsKey=true, DefaultValue="*")]
    [System.Configuration.StringValidatorAttribute(MinLength=0)]
    public string Name { get { return default(string); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.ServiceModel.Activities.Tracking.Configuration.StateElement), CollectionType=(System.Configuration.ConfigurationElementCollectionType)(0), AddItemName="state")]
  public sealed partial class StateElementCollection : System.ServiceModel.Activities.Tracking.Configuration.TrackingConfigurationCollection<System.ServiceModel.Activities.Tracking.Configuration.StateElement> {
    public StateElementCollection() { }
    protected override string ElementName { get { return default(string); } }
  }
  public partial class StateMachineStateQueryElement : System.ServiceModel.Activities.Tracking.Configuration.TrackingQueryElement {
    public StateMachineStateQueryElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("activityName", IsKey=true, DefaultValue="*")]
    [System.Configuration.StringValidatorAttribute(MinLength=1)]
    public string ActivityName { get { return default(string); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    protected override System.Activities.Tracking.TrackingQuery NewTrackingQuery() { return default(System.Activities.Tracking.TrackingQuery); }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.ServiceModel.Activities.Tracking.Configuration.StateMachineStateQueryElement), CollectionType=(System.Configuration.ConfigurationElementCollectionType)(0), AddItemName="stateMachineStateQuery")]
  public partial class StateMachineStateQueryElementCollection : System.ServiceModel.Activities.Tracking.Configuration.TrackingConfigurationCollection<System.ServiceModel.Activities.Tracking.Configuration.StateMachineStateQueryElement> {
    public StateMachineStateQueryElementCollection() { }
    protected override string ElementName { get { return default(string); } }
  }
  public partial class TrackingConfigurationCollection<TConfigurationElement> : System.Configuration.ConfigurationElementCollection where TConfigurationElement : System.ServiceModel.Activities.Tracking.Configuration.TrackingConfigurationElement, new() {
    public TrackingConfigurationCollection() { }
    public override System.Configuration.ConfigurationElementCollectionType CollectionType { get { return default(System.Configuration.ConfigurationElementCollectionType); } }
    public TConfigurationElement this[int index] { get { return default(TConfigurationElement); } set { } }
    public void Add(TConfigurationElement element) { }
    public void Clear() { }
    protected override System.Configuration.ConfigurationElement CreateNewElement() { return default(System.Configuration.ConfigurationElement); }
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
    public int IndexOf(TConfigurationElement element) { return default(int); }
    public void Remove(TConfigurationElement element) { }
    public void RemoveAt(int index) { }
  }
  public abstract partial class TrackingConfigurationElement : System.Configuration.ConfigurationElement {
    protected TrackingConfigurationElement() { }
    public abstract object ElementKey { get; }
    protected static string GetStringPairKey(string value1, string value2) { return default(string); }
  }
  public abstract partial class TrackingQueryElement : System.ServiceModel.Activities.Tracking.Configuration.TrackingConfigurationElement {
    protected TrackingQueryElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("annotations")]
    public System.ServiceModel.Activities.Tracking.Configuration.AnnotationElementCollection Annotations { get { return default(System.ServiceModel.Activities.Tracking.Configuration.AnnotationElementCollection); } }
    public override object ElementKey { get { return default(object); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    protected abstract System.Activities.Tracking.TrackingQuery NewTrackingQuery();
    protected virtual void UpdateTrackingQuery(System.Activities.Tracking.TrackingQuery trackingQuery) { }
  }
  public partial class TrackingSection : System.Configuration.ConfigurationSection {
    public TrackingSection() { }
    [System.Configuration.ConfigurationPropertyAttribute("profiles")]
    public System.ServiceModel.Activities.Tracking.Configuration.ProfileElementCollection Profiles { get { return default(System.ServiceModel.Activities.Tracking.Configuration.ProfileElementCollection); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    public System.Collections.ObjectModel.Collection<System.Activities.Tracking.TrackingProfile> TrackingProfiles { get { return default(System.Collections.ObjectModel.Collection<System.Activities.Tracking.TrackingProfile>); } }
  }
  public partial class VariableElement : System.ServiceModel.Activities.Tracking.Configuration.TrackingConfigurationElement {
    public VariableElement() { }
    public override object ElementKey { get { return default(object); } }
    [System.Configuration.ConfigurationPropertyAttribute("name", IsKey=true, IsRequired=true)]
    [System.Configuration.StringValidatorAttribute(MinLength=0)]
    public string Name { get { return default(string); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.ServiceModel.Activities.Tracking.Configuration.VariableElement), CollectionType=(System.Configuration.ConfigurationElementCollectionType)(0), AddItemName="variable")]
  public partial class VariableElementCollection : System.ServiceModel.Activities.Tracking.Configuration.TrackingConfigurationCollection<System.ServiceModel.Activities.Tracking.Configuration.VariableElement> {
    public VariableElementCollection() { }
    protected override string ElementName { get { return default(string); } }
  }
  public partial class WorkflowInstanceQueryElement : System.ServiceModel.Activities.Tracking.Configuration.TrackingQueryElement {
    public WorkflowInstanceQueryElement() { }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("states")]
    public System.ServiceModel.Activities.Tracking.Configuration.StateElementCollection States { get { return default(System.ServiceModel.Activities.Tracking.Configuration.StateElementCollection); } }
    protected override System.Activities.Tracking.TrackingQuery NewTrackingQuery() { return default(System.Activities.Tracking.TrackingQuery); }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.ServiceModel.Activities.Tracking.Configuration.WorkflowInstanceQueryElement), CollectionType=(System.Configuration.ConfigurationElementCollectionType)(0), AddItemName="workflowInstanceQuery")]
  public sealed partial class WorkflowInstanceQueryElementCollection : System.ServiceModel.Activities.Tracking.Configuration.TrackingConfigurationCollection<System.ServiceModel.Activities.Tracking.Configuration.WorkflowInstanceQueryElement> {
    public WorkflowInstanceQueryElementCollection() { }
    protected override string ElementName { get { return default(string); } }
  }
}
namespace System.ServiceModel.XamlIntegration {
  public partial class EndpointIdentityConverter : System.ComponentModel.TypeConverter {
    public EndpointIdentityConverter() { }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
  }
  public partial class ServiceXNameTypeConverter : System.ComponentModel.TypeConverter {
    public ServiceXNameTypeConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
  }
  [System.Windows.Markup.MarkupExtensionReturnTypeAttribute(typeof(System.ServiceModel.SpnEndpointIdentity))]
  public partial class SpnEndpointIdentityExtension : System.Windows.Markup.MarkupExtension {
    public SpnEndpointIdentityExtension() { }
    public SpnEndpointIdentityExtension(System.ServiceModel.SpnEndpointIdentity identity) { }
    public string SpnName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override object ProvideValue(System.IServiceProvider serviceProvider) { return default(object); }
  }
  [System.Windows.Markup.MarkupExtensionReturnTypeAttribute(typeof(System.ServiceModel.UpnEndpointIdentity))]
  public partial class UpnEndpointIdentityExtension : System.Windows.Markup.MarkupExtension {
    public UpnEndpointIdentityExtension() { }
    public UpnEndpointIdentityExtension(System.ServiceModel.UpnEndpointIdentity identity) { }
    public string UpnName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override object ProvideValue(System.IServiceProvider serviceProvider) { return default(object); }
  }
}
