namespace System.ServiceModel {
  [System.ObsoleteAttribute("The WF3 types are deprecated.  Instead, please use the new WF4 types from System.Activities.*")]
  public partial class WorkflowServiceHost : System.ServiceModel.ServiceHostBase {
    protected WorkflowServiceHost() { }
    public WorkflowServiceHost(System.IO.Stream workflowDefinition, System.IO.Stream ruleDefinition, params System.Uri[] baseAddress) { }
    public WorkflowServiceHost(System.IO.Stream workflowDefinition, System.IO.Stream ruleDefinition, System.Workflow.ComponentModel.Compiler.ITypeProvider typeProvider, params System.Uri[] baseAddress) { }
    public WorkflowServiceHost(System.IO.Stream workflowDefinition, params System.Uri[] baseAddress) { }
    public WorkflowServiceHost(string workflowDefinitionPath, string ruleDefinitionPath, params System.Uri[] baseAddress) { }
    public WorkflowServiceHost(string workflowDefinitionPath, string ruleDefinitionPath, System.Workflow.ComponentModel.Compiler.ITypeProvider typeProvider, params System.Uri[] baseAddress) { }
    public WorkflowServiceHost(string workflowDefinitionPath, params System.Uri[] baseAddress) { }
    public WorkflowServiceHost(System.Type workflowType, params System.Uri[] baseAddress) { }
    public System.ServiceModel.Description.ServiceEndpoint AddServiceEndpoint(System.Type implementedContract, System.ServiceModel.Channels.Binding binding, string address) { return default(System.ServiceModel.Description.ServiceEndpoint); }
    public System.ServiceModel.Description.ServiceEndpoint AddServiceEndpoint(System.Type implementedContract, System.ServiceModel.Channels.Binding binding, string address, System.Uri listenUri) { return default(System.ServiceModel.Description.ServiceEndpoint); }
    public System.ServiceModel.Description.ServiceEndpoint AddServiceEndpoint(System.Type implementedContract, System.ServiceModel.Channels.Binding binding, System.Uri address) { return default(System.ServiceModel.Description.ServiceEndpoint); }
    public System.ServiceModel.Description.ServiceEndpoint AddServiceEndpoint(System.Type implementedContract, System.ServiceModel.Channels.Binding binding, System.Uri address, System.Uri listenUri) { return default(System.ServiceModel.Description.ServiceEndpoint); }
    protected override System.ServiceModel.Description.ServiceDescription CreateDescription(out System.Collections.Generic.IDictionary<System.String, System.ServiceModel.Description.ContractDescription> implementedContracts) { implementedContracts = default(System.Collections.Generic.IDictionary<System.String, System.ServiceModel.Description.ContractDescription>); return default(System.ServiceModel.Description.ServiceDescription); }
    protected override void OnClosing() { }
  }
}
namespace System.ServiceModel.Activation {
  [System.ObsoleteAttribute("The WF3 types are deprecated.  Instead, please use the new WF4 types from System.Activities.*")]
  public partial class WorkflowServiceHostFactory : System.ServiceModel.Activation.ServiceHostFactoryBase {
    public WorkflowServiceHostFactory() { }
    public override System.ServiceModel.ServiceHostBase CreateServiceHost(string constructorString, System.Uri[] baseAddresses) { return default(System.ServiceModel.ServiceHostBase); }
  }
}
namespace System.ServiceModel.Activities.Description {
  [System.ObsoleteAttribute("The WF3 types are deprecated.  Instead, please use the new WF4 types from System.Activities.*")]
  public partial class WorkflowRuntimeEndpoint : System.ServiceModel.Activities.WorkflowHostingEndpoint {
    public WorkflowRuntimeEndpoint() : base (default(System.Type)) { }
    public void AddService(object service) { }
    public object GetService(System.Type serviceType) { return default(object); }
    public T GetService<T>() { return default(T); }
    protected override System.Guid OnGetInstanceId(System.Object[] inputs, System.ServiceModel.OperationContext operationContext) { return default(System.Guid); }
    protected override System.Activities.Bookmark OnResolveBookmark(System.Object[] inputs, System.ServiceModel.OperationContext operationContext, System.ServiceModel.Activities.WorkflowHostingResponseContext responseContext, out object value) { value = default(object); return default(System.Activities.Bookmark); }
    public void RemoveService(object service) { }
  }
}
namespace System.ServiceModel.Configuration {
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.Workflow.Runtime.Configuration.WorkflowRuntimeServiceElement))]
  [System.ObsoleteAttribute("The WF3 types are deprecated.  Instead, please use the new WF4 types from System.Activities.*")]
  public partial class ExtendedWorkflowRuntimeServiceElementCollection : System.Workflow.Runtime.Configuration.WorkflowRuntimeServiceElementCollection {
    public ExtendedWorkflowRuntimeServiceElementCollection() { }
    public void Remove(string key) { }
    public void Remove(System.Workflow.Runtime.Configuration.WorkflowRuntimeServiceElement serviceSettings) { }
  }
  [System.ObsoleteAttribute("The WF3 types are deprecated.  Instead, please use the new WF4 types from System.Activities.*")]
  public partial class PersistenceProviderElement : System.ServiceModel.Configuration.BehaviorExtensionElement {
    public PersistenceProviderElement() { }
    public override System.Type BehaviorType { get { return default(System.Type); } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Configuration.TimeSpanOrInfiniteConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("persistenceOperationTimeout", IsRequired=false, DefaultValue="00:00:30")]
    [System.Configuration.PositiveTimeSpanValidatorAttribute]
    public System.TimeSpan PersistenceOperationTimeout { get { return default(System.TimeSpan); } set { } }
    public System.Collections.Specialized.NameValueCollection PersistenceProviderArguments { get { return default(System.Collections.Specialized.NameValueCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("type", IsRequired=true)]
    [System.Configuration.StringValidatorAttribute(MinLength=0)]
    public string Type { get { return default(string); } set { } }
    protected internal override object CreateBehavior() { return default(object); }
    protected override bool IsModified() { return default(bool); }
    protected override bool OnDeserializeUnrecognizedAttribute(string name, string value) { return default(bool); }
    protected override void PostDeserialize() { }
    protected override bool SerializeElement(System.Xml.XmlWriter writer, bool serializeCollectionKey) { return default(bool); }
    protected override void Unmerge(System.Configuration.ConfigurationElement sourceElement, System.Configuration.ConfigurationElement parentElement, System.Configuration.ConfigurationSaveMode saveMode) { }
  }
  [System.ObsoleteAttribute("The WF3 types are deprecated.  Instead, please use the new WF4 types from System.Activities.*")]
  public partial class WorkflowRuntimeElement : System.ServiceModel.Configuration.BehaviorExtensionElement {
    public WorkflowRuntimeElement() { }
    public override System.Type BehaviorType { get { return default(System.Type); } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Configuration.TimeSpanOrInfiniteConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("cachedInstanceExpiration", IsRequired=false, DefaultValue="00:10:00")]
    [System.Configuration.PositiveTimeSpanValidatorAttribute]
    public System.TimeSpan CachedInstanceExpiration { get { return default(System.TimeSpan); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("commonParameters", DefaultValue=null)]
    public System.Configuration.NameValueConfigurationCollection CommonParameters { get { return default(System.Configuration.NameValueConfigurationCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("enablePerformanceCounters", DefaultValue=true)]
    public bool EnablePerformanceCounters { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("name", DefaultValue="")]
    [System.Configuration.StringValidatorAttribute(MinLength=0)]
    public string Name { get { return default(string); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("services", DefaultValue=null)]
    public System.ServiceModel.Configuration.ExtendedWorkflowRuntimeServiceElementCollection Services { get { return default(System.ServiceModel.Configuration.ExtendedWorkflowRuntimeServiceElementCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("validateOnCreate", DefaultValue=true)]
    public bool ValidateOnCreate { get { return default(bool); } set { } }
    protected internal override object CreateBehavior() { return default(object); }
  }
}
namespace System.ServiceModel.Description {
  [System.AttributeUsageAttribute((System.AttributeTargets)(64))]
  [System.ObsoleteAttribute("The WF3 types are deprecated.  Instead, please use the new WF4 types from System.Activities.*")]
  public sealed partial class DurableOperationAttribute : System.Attribute, System.ServiceModel.Description.IOperationBehavior {
    public DurableOperationAttribute() { }
    public bool CanCreateInstance { get { return default(bool); } set { } }
    public bool CompletesInstance { get { return default(bool); } set { } }
    public void AddBindingParameters(System.ServiceModel.Description.OperationDescription operationDescription, System.ServiceModel.Channels.BindingParameterCollection bindingParameters) { }
    public void ApplyClientBehavior(System.ServiceModel.Description.OperationDescription operationDescription, System.ServiceModel.Dispatcher.ClientOperation clientOperation) { }
    public void ApplyDispatchBehavior(System.ServiceModel.Description.OperationDescription operationDescription, System.ServiceModel.Dispatcher.DispatchOperation dispatchOperation) { }
    public void Validate(System.ServiceModel.Description.OperationDescription operationDescription) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
  [System.ObsoleteAttribute("The WF3 types are deprecated.  Instead, please use the new WF4 types from System.Activities.*")]
  public sealed partial class DurableServiceAttribute : System.Attribute, System.ServiceModel.Description.IServiceBehavior {
    public DurableServiceAttribute() { }
    public bool SaveStateInOperationTransaction { get { return default(bool); } set { } }
    public System.ServiceModel.Description.UnknownExceptionAction UnknownExceptionAction { get { return default(System.ServiceModel.Description.UnknownExceptionAction); } set { } }
    public void AddBindingParameters(System.ServiceModel.Description.ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase, System.Collections.ObjectModel.Collection<System.ServiceModel.Description.ServiceEndpoint> endpoints, System.ServiceModel.Channels.BindingParameterCollection bindingParameters) { }
    public void ApplyDispatchBehavior(System.ServiceModel.Description.ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase) { }
    public void Validate(System.ServiceModel.Description.ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase) { }
  }
  [System.ObsoleteAttribute("The WF3 types are deprecated.  Instead, please use the new WF4 types from System.Activities.*")]
  public partial class PersistenceProviderBehavior : System.ServiceModel.Description.IServiceBehavior {
    public PersistenceProviderBehavior(System.ServiceModel.Persistence.PersistenceProviderFactory providerFactory) { }
    public PersistenceProviderBehavior(System.ServiceModel.Persistence.PersistenceProviderFactory providerFactory, System.TimeSpan persistenceOperationTimeout) { }
    public System.TimeSpan PersistenceOperationTimeout { get { return default(System.TimeSpan); } set { } }
    public System.ServiceModel.Persistence.PersistenceProviderFactory PersistenceProviderFactory { get { return default(System.ServiceModel.Persistence.PersistenceProviderFactory); } set { } }
    public virtual void AddBindingParameters(System.ServiceModel.Description.ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase, System.Collections.ObjectModel.Collection<System.ServiceModel.Description.ServiceEndpoint> endpoints, System.ServiceModel.Channels.BindingParameterCollection bindingParameters) { }
    public virtual void ApplyDispatchBehavior(System.ServiceModel.Description.ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase) { }
    public virtual void Validate(System.ServiceModel.Description.ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase) { }
  }
  [System.ObsoleteAttribute("The WF3 types are deprecated.  Instead, please use the new WF4 types from System.Activities.*")]
  public enum UnknownExceptionAction {
    AbortInstance = 1,
    TerminateInstance = 0,
  }
  [System.ObsoleteAttribute("The WF3 types are deprecated.  Instead, please use the new WF4 types from System.Activities.*")]
  public partial class WorkflowRuntimeBehavior : System.ServiceModel.Description.IServiceBehavior {
    public WorkflowRuntimeBehavior() { }
    public System.TimeSpan CachedInstanceExpiration { get { return default(System.TimeSpan); } set { } }
    public System.Workflow.Runtime.WorkflowRuntime WorkflowRuntime { get { return default(System.Workflow.Runtime.WorkflowRuntime); } }
    public void AddBindingParameters(System.ServiceModel.Description.ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase, System.Collections.ObjectModel.Collection<System.ServiceModel.Description.ServiceEndpoint> endpoints, System.ServiceModel.Channels.BindingParameterCollection bindingParameters) { }
    public void ApplyDispatchBehavior(System.ServiceModel.Description.ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase) { }
    public void Validate(System.ServiceModel.Description.ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase) { }
  }
}
namespace System.ServiceModel.Dispatcher {
  [System.ObsoleteAttribute("The WF3 types are deprecated.  Instead, please use the new WF4 types from System.Activities.*")]
  public static partial class DurableOperationContext {
    public static System.Guid InstanceId { get { return default(System.Guid); } }
    public static void AbortInstance() { }
    public static void CompleteInstance() { }
  }
}
namespace System.ServiceModel.Persistence {
  [System.ObsoleteAttribute("The WF3 types are deprecated.  Instead, please use the new WF4 types from System.Activities.*")]
  public partial class InstanceLockException : System.ServiceModel.Persistence.PersistenceException {
    public InstanceLockException() { }
    public InstanceLockException(System.Guid id) { }
    public InstanceLockException(System.Guid id, System.Exception innerException) { }
    public InstanceLockException(System.Guid id, string message) { }
    public InstanceLockException(System.Guid id, string message, System.Exception innerException) { }
    protected InstanceLockException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public InstanceLockException(string message) { }
    public InstanceLockException(string message, System.Exception innerException) { }
    public System.Guid InstanceId { get { return default(System.Guid); } }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, SerializationFormatter=true)]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  [System.ObsoleteAttribute("The WF3 types are deprecated.  Instead, please use the new WF4 types from System.Activities.*")]
  public partial class InstanceNotFoundException : System.ServiceModel.Persistence.PersistenceException {
    public InstanceNotFoundException() { }
    public InstanceNotFoundException(System.Guid id) { }
    public InstanceNotFoundException(System.Guid id, System.Exception innerException) { }
    public InstanceNotFoundException(System.Guid id, string message) { }
    public InstanceNotFoundException(System.Guid id, string message, System.Exception innerException) { }
    protected InstanceNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public InstanceNotFoundException(string message) { }
    public InstanceNotFoundException(string message, System.Exception innerException) { }
    public System.Guid InstanceId { get { return default(System.Guid); } }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, SerializationFormatter=true)]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  [System.ObsoleteAttribute("The WF3 types are deprecated.  Instead, please use the new WF4 types from System.Activities.*")]
  public abstract partial class LockingPersistenceProvider : System.ServiceModel.Persistence.PersistenceProvider {
    protected LockingPersistenceProvider(System.Guid id) : base (default(System.Guid)) { }
    public override System.IAsyncResult BeginCreate(object instance, System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public abstract System.IAsyncResult BeginCreate(object instance, System.TimeSpan timeout, bool unlockInstance, System.AsyncCallback callback, object state);
    public override System.IAsyncResult BeginLoad(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public abstract System.IAsyncResult BeginLoad(System.TimeSpan timeout, bool lockInstance, System.AsyncCallback callback, object state);
    public override System.IAsyncResult BeginLoadIfChanged(System.TimeSpan timeout, object instanceToken, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public virtual System.IAsyncResult BeginLoadIfChanged(System.TimeSpan timeout, object instanceToken, bool lockInstance, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public abstract System.IAsyncResult BeginUnlock(System.TimeSpan timeout, System.AsyncCallback callback, object state);
    public override System.IAsyncResult BeginUpdate(object instance, System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public abstract System.IAsyncResult BeginUpdate(object instance, System.TimeSpan timeout, bool unlockInstance, System.AsyncCallback callback, object state);
    public override object Create(object instance, System.TimeSpan timeout) { return default(object); }
    public abstract object Create(object instance, System.TimeSpan timeout, bool unlockInstance);
    public abstract void EndUnlock(System.IAsyncResult result);
    public override object Load(System.TimeSpan timeout) { return default(object); }
    public abstract object Load(System.TimeSpan timeout, bool lockInstance);
    public virtual bool LoadIfChanged(System.TimeSpan timeout, object instanceToken, bool lockInstance, out object instance) { instance = default(object); return default(bool); }
    public override bool LoadIfChanged(System.TimeSpan timeout, object instanceToken, out object instance) { instance = default(object); return default(bool); }
    public abstract void Unlock(System.TimeSpan timeout);
    public override object Update(object instance, System.TimeSpan timeout) { return default(object); }
    public abstract object Update(object instance, System.TimeSpan timeout, bool unlockInstance);
  }
  [System.ObsoleteAttribute("The WF3 types are deprecated.  Instead, please use the new WF4 types from System.Activities.*")]
  public partial class PersistenceException : System.ServiceModel.CommunicationException {
    public PersistenceException() { }
    protected PersistenceException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public PersistenceException(string message) { }
    public PersistenceException(string message, System.Exception innerException) { }
  }
  [System.ObsoleteAttribute("The WF3 types are deprecated.  Instead, please use the new WF4 types from System.Activities.*")]
  public abstract partial class PersistenceProvider : System.ServiceModel.Channels.CommunicationObject {
    protected PersistenceProvider(System.Guid id) { }
    public System.Guid Id { get { return default(System.Guid); } }
    public abstract System.IAsyncResult BeginCreate(object instance, System.TimeSpan timeout, System.AsyncCallback callback, object state);
    public abstract System.IAsyncResult BeginDelete(object instance, System.TimeSpan timeout, System.AsyncCallback callback, object state);
    public abstract System.IAsyncResult BeginLoad(System.TimeSpan timeout, System.AsyncCallback callback, object state);
    public virtual System.IAsyncResult BeginLoadIfChanged(System.TimeSpan timeout, object instanceToken, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public abstract System.IAsyncResult BeginUpdate(object instance, System.TimeSpan timeout, System.AsyncCallback callback, object state);
    public abstract object Create(object instance, System.TimeSpan timeout);
    public abstract void Delete(object instance, System.TimeSpan timeout);
    public abstract object EndCreate(System.IAsyncResult result);
    public abstract void EndDelete(System.IAsyncResult result);
    public abstract object EndLoad(System.IAsyncResult result);
    public virtual bool EndLoadIfChanged(System.IAsyncResult result, out object instance) { instance = default(object); return default(bool); }
    public abstract object EndUpdate(System.IAsyncResult result);
    public abstract object Load(System.TimeSpan timeout);
    public virtual bool LoadIfChanged(System.TimeSpan timeout, object instanceToken, out object instance) { instance = default(object); return default(bool); }
    public abstract object Update(object instance, System.TimeSpan timeout);
  }
  [System.ObsoleteAttribute("The WF3 types are deprecated.  Instead, please use the new WF4 types from System.Activities.*")]
  public abstract partial class PersistenceProviderFactory : System.ServiceModel.Channels.CommunicationObject {
    protected PersistenceProviderFactory() { }
    public abstract System.ServiceModel.Persistence.PersistenceProvider CreateProvider(System.Guid id);
  }
  [System.ObsoleteAttribute("The WF3 types are deprecated.  Instead, please use the new WF4 types from System.Activities.*")]
  public partial class SqlPersistenceProviderFactory : System.ServiceModel.Persistence.PersistenceProviderFactory {
    public SqlPersistenceProviderFactory(System.Collections.Specialized.NameValueCollection parameters) { }
    public SqlPersistenceProviderFactory(string connectionString) { }
    public SqlPersistenceProviderFactory(string connectionString, bool serializeAsText) { }
    public SqlPersistenceProviderFactory(string connectionString, bool serializeAsText, System.TimeSpan lockTimeout) { }
    public string ConnectionString { get { return default(string); } set { } }
    protected override System.TimeSpan DefaultCloseTimeout { get { return default(System.TimeSpan); } }
    protected override System.TimeSpan DefaultOpenTimeout { get { return default(System.TimeSpan); } }
    public System.TimeSpan LockTimeout { get { return default(System.TimeSpan); } set { } }
    public bool SerializeAsText { get { return default(bool); } set { } }
    public override System.ServiceModel.Persistence.PersistenceProvider CreateProvider(System.Guid id) { return default(System.ServiceModel.Persistence.PersistenceProvider); }
    protected override void OnAbort() { }
    protected override System.IAsyncResult OnBeginClose(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected override System.IAsyncResult OnBeginOpen(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected override void OnClose(System.TimeSpan timeout) { }
    protected override void OnEndClose(System.IAsyncResult result) { }
    protected override void OnEndOpen(System.IAsyncResult result) { }
    protected override void OnOpen(System.TimeSpan timeout) { }
  }
}
namespace System.Workflow.Activities {
  [System.ComponentModel.Design.Serialization.DesignerSerializerAttribute(typeof(System.Workflow.ComponentModel.Serialization.DependencyObjectCodeDomSerializer), typeof(System.ComponentModel.Design.Serialization.CodeDomSerializer))]
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Workflow.Activities.ChannelTokenTypeConverter))]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class ChannelToken : System.Workflow.ComponentModel.DependencyObject {
    public ChannelToken() { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ServiceModel.SR2DescriptionAttribute("ChannelToken_EndpointName_Description")]
    public string EndpointName { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ServiceModel.SR2DescriptionAttribute("ChannelToken_Name_Description")]
    public string Name { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Workflow.ComponentModel.Design.PropertyValueProviderTypeConverter))]
    [System.ServiceModel.SR2DescriptionAttribute("ChannelToken_OwnerActivityName_Description")]
    public string OwnerActivityName { get { return default(string); } set { } }
  }
  [System.ComponentModel.Design.Serialization.DesignerSerializerAttribute(typeof(System.Workflow.ComponentModel.Serialization.DependencyObjectCodeDomSerializer), typeof(System.ComponentModel.Design.Serialization.CodeDomSerializer))]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class ContextToken : System.Workflow.ComponentModel.DependencyObject {
    public const string RootContextName = "(RootContext)";
    public ContextToken() { }
    public ContextToken(string name) { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ServiceModel.SR2DescriptionAttribute("ContextToken_Name_Description")]
    public string Name { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Workflow.ComponentModel.Design.PropertyValueProviderTypeConverter))]
    [System.ServiceModel.SR2DescriptionAttribute("ContextToken_OwnerActivityName_Description")]
    public string OwnerActivityName { get { return default(string); } set { } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class OperationInfo : System.Workflow.Activities.OperationInfoBase {
    public OperationInfo() { }
    public string ContractName { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool HasProtectionLevel { get { return default(bool); } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool IsOneWay { get { return default(bool); } set { } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    public System.Workflow.Activities.OperationParameterInfoCollection Parameters { get { return default(System.Workflow.Activities.OperationParameterInfoCollection); } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Nullable<System.Net.Security.ProtectionLevel> ProtectionLevel { get { return default(System.Nullable<System.Net.Security.ProtectionLevel>); } set { } }
    public override System.Workflow.Activities.OperationInfoBase Clone() { return default(System.Workflow.Activities.OperationInfoBase); }
    public override bool Equals(object obj) { return default(bool); }
    protected internal override string GetContractFullName(System.IServiceProvider provider) { return default(string); }
    protected internal override System.Type GetContractType(System.IServiceProvider provider) { return default(System.Type); }
    public override int GetHashCode() { return default(int); }
    protected internal override bool GetIsOneWay(System.IServiceProvider provider) { return default(bool); }
    protected internal override System.Reflection.MethodInfo GetMethodInfo(System.IServiceProvider provider) { return default(System.Reflection.MethodInfo); }
    protected internal override System.Workflow.Activities.OperationParameterInfoCollection GetParameters(System.IServiceProvider provider) { return default(System.Workflow.Activities.OperationParameterInfoCollection); }
    public override string ToString() { return default(string); }
  }
  [System.ComponentModel.Design.Serialization.DesignerSerializerAttribute(typeof(System.Workflow.ComponentModel.Serialization.DependencyObjectCodeDomSerializer), typeof(System.ComponentModel.Design.Serialization.CodeDomSerializer))]
  [System.ComponentModel.EditorAttribute(typeof(System.Workflow.Activities.Design.ServiceOperationUIEditor), typeof(System.Drawing.Design.UITypeEditor))]
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Workflow.Activities.ServiceOperationInfoTypeConverter))]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public abstract partial class OperationInfoBase : System.Workflow.ComponentModel.DependencyObject {
    protected OperationInfoBase() { }
    public virtual string Name { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public virtual string PrincipalPermissionName { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public virtual string PrincipalPermissionRole { get { return default(string); } set { } }
    public virtual System.Workflow.Activities.OperationInfoBase Clone() { return default(System.Workflow.Activities.OperationInfoBase); }
    public override bool Equals(object obj) { return default(bool); }
    protected internal abstract string GetContractFullName(System.IServiceProvider provider);
    protected internal abstract System.Type GetContractType(System.IServiceProvider provider);
    public override int GetHashCode() { return default(int); }
    protected internal abstract bool GetIsOneWay(System.IServiceProvider provider);
    protected internal abstract System.Reflection.MethodInfo GetMethodInfo(System.IServiceProvider provider);
    protected internal abstract System.Workflow.Activities.OperationParameterInfoCollection GetParameters(System.IServiceProvider provider);
  }
  [System.ComponentModel.BrowsableAttribute(true)]
  [System.ComponentModel.Design.Serialization.DesignerSerializerAttribute(typeof(System.Workflow.ComponentModel.Serialization.DependencyObjectCodeDomSerializer), typeof(System.ComponentModel.Design.Serialization.CodeDomSerializer))]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class OperationParameterInfo : System.Workflow.ComponentModel.DependencyObject {
    public static readonly System.Workflow.ComponentModel.DependencyProperty AttributesProperty;
    public static readonly System.Workflow.ComponentModel.DependencyProperty NameProperty;
    public static readonly System.Workflow.ComponentModel.DependencyProperty ParameterTypeProperty;
    public static readonly System.Workflow.ComponentModel.DependencyProperty PositionProperty;
    public OperationParameterInfo() { }
    public OperationParameterInfo(string parameterName) { }
    public System.Reflection.ParameterAttributes Attributes { get { return default(System.Reflection.ParameterAttributes); } set { } }
    public bool IsIn { get { return default(bool); } }
    public bool IsLcid { get { return default(bool); } }
    public bool IsOptional { get { return default(bool); } }
    public bool IsOut { get { return default(bool); } }
    public bool IsRetval { get { return default(bool); } }
    public string Name { get { return default(string); } set { } }
    public System.Type ParameterType { get { return default(System.Type); } set { } }
    public int Position { get { return default(int); } set { } }
    public System.Workflow.Activities.OperationParameterInfo Clone() { return default(System.Workflow.Activities.OperationParameterInfo); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }
  [System.ComponentModel.Design.Serialization.DesignerSerializerAttribute(typeof(System.Workflow.ComponentModel.Serialization.CollectionMarkupSerializer), typeof(System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializer))]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class OperationParameterInfoCollection : System.Collections.Generic.List<System.Workflow.Activities.OperationParameterInfo>, System.Collections.Generic.ICollection<System.Workflow.Activities.OperationParameterInfo>, System.Collections.Generic.IEnumerable<System.Workflow.Activities.OperationParameterInfo>, System.Collections.Generic.IList<System.Workflow.Activities.OperationParameterInfo>, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList {
    public OperationParameterInfoCollection() { }
    public OperationParameterInfoCollection(System.Workflow.Activities.OperationInfoBase owner) { }
    public new int Count { get { return default(int); } }
    public new System.Workflow.Activities.OperationParameterInfo this[int index] { get { return default(System.Workflow.Activities.OperationParameterInfo); } set { } }
    public System.Workflow.Activities.OperationParameterInfo this[string key] { get { return default(System.Workflow.Activities.OperationParameterInfo); } }
    int System.Collections.Generic.ICollection<System.Workflow.Activities.OperationParameterInfo>.Count { get { return default(int); } }
    bool System.Collections.Generic.ICollection<System.Workflow.Activities.OperationParameterInfo>.IsReadOnly { get { return default(bool); } }
    System.Workflow.Activities.OperationParameterInfo System.Collections.Generic.IList<System.Workflow.Activities.OperationParameterInfo>.this[int index] { get { return default(System.Workflow.Activities.OperationParameterInfo); } set { } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    bool System.Collections.IList.IsFixedSize { get { return default(bool); } }
    bool System.Collections.IList.IsReadOnly { get { return default(bool); } }
    object System.Collections.IList.this[int index] { get { return default(object); } set { } }
    public new void Add(System.Workflow.Activities.OperationParameterInfo item) { }
    public new void Clear() { }
    public new bool Contains(System.Workflow.Activities.OperationParameterInfo item) { return default(bool); }
    public new System.Collections.Generic.IEnumerator<System.Workflow.Activities.OperationParameterInfo> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Workflow.Activities.OperationParameterInfo>); }
    public new int IndexOf(System.Workflow.Activities.OperationParameterInfo item) { return default(int); }
    public new void Insert(int index, System.Workflow.Activities.OperationParameterInfo item) { }
    public new bool Remove(System.Workflow.Activities.OperationParameterInfo item) { return default(bool); }
    public new void RemoveAt(int index) { }
    void System.Collections.Generic.ICollection<System.Workflow.Activities.OperationParameterInfo>.Add(System.Workflow.Activities.OperationParameterInfo item) { }
    void System.Collections.Generic.ICollection<System.Workflow.Activities.OperationParameterInfo>.Clear() { }
    bool System.Collections.Generic.ICollection<System.Workflow.Activities.OperationParameterInfo>.Contains(System.Workflow.Activities.OperationParameterInfo item) { return default(bool); }
    void System.Collections.Generic.ICollection<System.Workflow.Activities.OperationParameterInfo>.CopyTo(System.Workflow.Activities.OperationParameterInfo[] array, int arrayIndex) { }
    bool System.Collections.Generic.ICollection<System.Workflow.Activities.OperationParameterInfo>.Remove(System.Workflow.Activities.OperationParameterInfo item) { return default(bool); }
    System.Collections.Generic.IEnumerator<System.Workflow.Activities.OperationParameterInfo> System.Collections.Generic.IEnumerable<System.Workflow.Activities.OperationParameterInfo>.GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Workflow.Activities.OperationParameterInfo>); }
    int System.Collections.Generic.IList<System.Workflow.Activities.OperationParameterInfo>.IndexOf(System.Workflow.Activities.OperationParameterInfo item) { return default(int); }
    void System.Collections.Generic.IList<System.Workflow.Activities.OperationParameterInfo>.Insert(int index, System.Workflow.Activities.OperationParameterInfo item) { }
    void System.Collections.Generic.IList<System.Workflow.Activities.OperationParameterInfo>.RemoveAt(int index) { }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    int System.Collections.IList.Add(object value) { return default(int); }
    void System.Collections.IList.Clear() { }
    bool System.Collections.IList.Contains(object value) { return default(bool); }
    int System.Collections.IList.IndexOf(object value) { return default(int); }
    void System.Collections.IList.Insert(int index, object value) { }
    void System.Collections.IList.Remove(object value) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class OperationValidationEventArgs : System.EventArgs {
    public OperationValidationEventArgs(System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Claims.ClaimSet> claimSets) { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Claims.ClaimSet> ClaimSets { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Claims.ClaimSet>); } }
    public bool IsValid { get { return default(bool); } set { } }
  }
  [System.ComponentModel.DesignerAttribute(typeof(System.Workflow.Activities.ReceiveActivityDesigner), typeof(System.ComponentModel.Design.IDesigner))]
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Workflow.Activities.ReceiveActivity), "Design.Resources.ReceiveActivity.png")]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.ServiceModel.SR2CategoryAttribute("Standard")]
  [System.ServiceModel.SR2DescriptionAttribute("ReceiveActivityDescription")]
  [System.Workflow.ComponentModel.Compiler.ActivityValidatorAttribute(typeof(System.Workflow.Activities.ReceiveActivityValidator))]
  public sealed partial class ReceiveActivity : System.Workflow.Activities.SequenceActivity, System.Workflow.Activities.IEventActivity, System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.QueueEventArgs> {
    public static readonly System.Workflow.ComponentModel.DependencyProperty FaultMessageProperty;
    public static readonly System.Workflow.ComponentModel.DependencyProperty OperationValidationEvent;
    public static readonly System.Workflow.ComponentModel.DependencyProperty WorkflowServiceAttributesProperty;
    public ReceiveActivity() { }
    public ReceiveActivity(string name) { }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(1))]
    [System.ServiceModel.SR2CategoryAttribute("Activity")]
    [System.ServiceModel.SR2DescriptionAttribute("Receive_CanCreateInstance_Description")]
    public bool CanCreateInstance { get { return default(bool); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Collections.Generic.IDictionary<System.String, System.String> Context { get { return default(System.Collections.Generic.IDictionary<System.String, System.String>); } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Workflow.Activities.ContextTokenTypeConverter))]
    [System.ServiceModel.SR2CategoryAttribute("Activity")]
    [System.ServiceModel.SR2DescriptionAttribute("Receive_ContextToken_Description")]
    public System.Workflow.Activities.ContextToken ContextToken { get { return default(System.Workflow.Activities.ContextToken); } set { } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(1))]
    [System.ServiceModel.SR2CategoryAttribute("Activity")]
    [System.ServiceModel.SR2DescriptionAttribute("Receive_FaultMessage_Description")]
    public System.ServiceModel.FaultException FaultMessage { get { return default(System.ServiceModel.FaultException); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    public System.Workflow.ComponentModel.WorkflowParameterBindingCollection ParameterBindings { get { return default(System.Workflow.ComponentModel.WorkflowParameterBindingCollection); } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(1))]
    [System.ServiceModel.SR2CategoryAttribute("Activity")]
    [System.ServiceModel.SR2DescriptionAttribute("Receive_OperationInfo_Description")]
    public System.Workflow.Activities.OperationInfoBase ServiceOperationInfo { get { return default(System.Workflow.Activities.OperationInfoBase); } set { } }
    System.IComparable System.Workflow.Activities.IEventActivity.QueueName { get { return default(System.IComparable); } }
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.ServiceModel.SR2DescriptionAttribute("Receive_OperationValidation_Description")]
    [System.ServiceModel.SRCategoryAttribute("Handlers")]
    public event System.EventHandler<System.Workflow.Activities.OperationValidationEventArgs> OperationValidation { add { } remove { } }
    protected override System.Workflow.ComponentModel.ActivityExecutionStatus Cancel(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    protected override void Dispose(bool disposing) { }
    protected override System.Workflow.ComponentModel.ActivityExecutionStatus Execute(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    public static System.Collections.Generic.IDictionary<System.String, System.String> GetContext(System.Workflow.ComponentModel.Activity activity, string contextName, string ownerActivityName) { return default(System.Collections.Generic.IDictionary<System.String, System.String>); }
    public static System.Collections.Generic.IDictionary<System.String, System.String> GetContext(System.Workflow.ComponentModel.Activity activity, System.Workflow.Activities.ContextToken contextToken) { return default(System.Collections.Generic.IDictionary<System.String, System.String>); }
    public static System.Collections.Generic.IDictionary<System.String, System.String> GetRootContext(System.Workflow.ComponentModel.Activity activity) { return default(System.Collections.Generic.IDictionary<System.String, System.String>); }
    public static object GetWorkflowServiceAttributes(object dependencyObject) { return default(object); }
    protected override System.Workflow.ComponentModel.ActivityExecutionStatus HandleFault(System.Workflow.ComponentModel.ActivityExecutionContext executionContext, System.Exception exception) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    protected internal override void Initialize(System.IServiceProvider provider) { }
    protected override void InitializeProperties() { }
    protected override void OnSequenceComplete(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { }
    public static void SetWorkflowServiceAttributes(object dependencyObject, object value) { }
    void System.Workflow.Activities.IEventActivity.Subscribe(System.Workflow.ComponentModel.ActivityExecutionContext parentContext, System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.QueueEventArgs> parentEventHandler) { }
    void System.Workflow.Activities.IEventActivity.Unsubscribe(System.Workflow.ComponentModel.ActivityExecutionContext parentContext, System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.QueueEventArgs> parentEventHandler) { }
    void System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.QueueEventArgs>.OnEvent(object sender, System.Workflow.ComponentModel.QueueEventArgs e) { }
  }
  [System.ComponentModel.DesignerAttribute(typeof(System.Workflow.Activities.SendActivityDesigner), typeof(System.ComponentModel.Design.IDesigner))]
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Workflow.Activities.SendActivity), "Design.Resources.SendActivity.png")]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.ServiceModel.SR2CategoryAttribute("Standard")]
  [System.ServiceModel.SR2DescriptionAttribute("SendActivityDescription")]
  [System.Workflow.ComponentModel.Compiler.ActivityValidatorAttribute(typeof(System.Workflow.Activities.SendActivityValidator))]
  public sealed partial class SendActivity : System.Workflow.ComponentModel.Activity {
    public static readonly System.Workflow.ComponentModel.DependencyProperty AfterResponseEvent;
    public static readonly System.Workflow.ComponentModel.DependencyProperty BeforeSendEvent;
    public static readonly System.Workflow.ComponentModel.DependencyProperty CustomAddressProperty;
    public const string ReturnValuePropertyName = "(ReturnValue)";
    public SendActivity() { }
    public SendActivity(string name) { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ServiceModel.SR2CategoryAttribute("Activity")]
    [System.ServiceModel.SR2DescriptionAttribute("Send_ChannelToken_Description")]
    public System.Workflow.Activities.ChannelToken ChannelToken { get { return default(System.Workflow.Activities.ChannelToken); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Collections.Generic.IDictionary<System.String, System.String> Context { get { return default(System.Collections.Generic.IDictionary<System.String, System.String>); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ServiceModel.SR2CategoryAttribute("Activity")]
    [System.ServiceModel.SR2DescriptionAttribute("Send_CustomAddress_Description")]
    public string CustomAddress { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    public System.Workflow.ComponentModel.WorkflowParameterBindingCollection ParameterBindings { get { return default(System.Workflow.ComponentModel.WorkflowParameterBindingCollection); } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(1))]
    [System.ServiceModel.SR2CategoryAttribute("Activity")]
    [System.ServiceModel.SR2DescriptionAttribute("Send_OperationInfo_Description")]
    public System.Workflow.Activities.TypedOperationInfo ServiceOperationInfo { get { return default(System.Workflow.Activities.TypedOperationInfo); } set { } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(1))]
    [System.ServiceModel.SR2CategoryAttribute("Handlers")]
    [System.ServiceModel.SR2DescriptionAttribute("Send_AfterResponse_Description")]
    public event System.EventHandler<System.Workflow.Activities.SendActivityEventArgs> AfterResponse { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(1))]
    [System.ServiceModel.SR2CategoryAttribute("Handlers")]
    [System.ServiceModel.SR2DescriptionAttribute("Send_BeforeSend_Description")]
    public event System.EventHandler<System.Workflow.Activities.SendActivityEventArgs> BeforeSend { add { } remove { } }
    protected internal override System.Workflow.ComponentModel.ActivityExecutionStatus Execute(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    public static System.Collections.Generic.IDictionary<System.String, System.String> GetContext(System.Workflow.ComponentModel.Activity activity, string endpointName, string ownerActivityName, System.Type contractType) { return default(System.Collections.Generic.IDictionary<System.String, System.String>); }
    public static System.Collections.Generic.IDictionary<System.String, System.String> GetContext(System.Workflow.ComponentModel.Activity activity, System.Workflow.Activities.ChannelToken endpoint, System.Type contractType) { return default(System.Collections.Generic.IDictionary<System.String, System.String>); }
    protected override void InitializeProperties() { }
    public static void SetContext(System.Workflow.ComponentModel.Activity activity, string endpointName, string ownerActivityName, System.Type contractType, System.Collections.Generic.IDictionary<System.String, System.String> context) { }
    public static void SetContext(System.Workflow.ComponentModel.Activity activity, System.Workflow.Activities.ChannelToken endpoint, System.Type contractType, System.Collections.Generic.IDictionary<System.String, System.String> context) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class SendActivityEventArgs : System.EventArgs {
    public SendActivityEventArgs(System.Workflow.Activities.SendActivity sendActivity) { }
    public System.Workflow.Activities.SendActivity SendActivity { get { return default(System.Workflow.Activities.SendActivity); } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class TypedOperationInfo : System.Workflow.Activities.OperationInfoBase {
    public TypedOperationInfo() { }
    public TypedOperationInfo(System.Type contractType, string operationName) { }
    public System.Type ContractType { get { return default(System.Type); } set { } }
    public override System.Workflow.Activities.OperationInfoBase Clone() { return default(System.Workflow.Activities.OperationInfoBase); }
    public override bool Equals(object obj) { return default(bool); }
    protected internal override string GetContractFullName(System.IServiceProvider provider) { return default(string); }
    protected internal override System.Type GetContractType(System.IServiceProvider provider) { return default(System.Type); }
    public override int GetHashCode() { return default(int); }
    protected internal override bool GetIsOneWay(System.IServiceProvider provider) { return default(bool); }
    protected internal override System.Reflection.MethodInfo GetMethodInfo(System.IServiceProvider provider) { return default(System.Reflection.MethodInfo); }
    protected internal override System.Workflow.Activities.OperationParameterInfoCollection GetParameters(System.IServiceProvider provider) { return default(System.Workflow.Activities.OperationParameterInfoCollection); }
    public override string ToString() { return default(string); }
  }
  [System.ComponentModel.Design.Serialization.DesignerSerializerAttribute(typeof(System.Workflow.ComponentModel.Serialization.DependencyObjectCodeDomSerializer), typeof(System.ComponentModel.Design.Serialization.CodeDomSerializer))]
  [System.ComponentModel.Design.Serialization.DesignerSerializerAttribute(typeof(System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializer), typeof(System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializer))]
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Workflow.Activities.WorkflowServiceAttributesTypeConverter))]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class WorkflowServiceAttributes : System.Workflow.ComponentModel.DependencyObject {
    public WorkflowServiceAttributes() { }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.AddressFilterMode)(0))]
    public System.ServiceModel.AddressFilterMode AddressFilterMode { get { return default(System.ServiceModel.AddressFilterMode); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public string ConfigurationName { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool IgnoreExtensionDataObject { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool IncludeExceptionDetailInFaults { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(65536)]
    public int MaxItemsInObjectGraph { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public string Name { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public string Namespace { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool UseSynchronizationContext { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool ValidateMustUnderstand { get { return default(bool); } set { } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class WorkflowServiceAttributesDynamicPropertyValidator : System.Workflow.ComponentModel.Compiler.Validator {
    public WorkflowServiceAttributesDynamicPropertyValidator() { }
    public override System.Workflow.ComponentModel.Compiler.ValidationErrorCollection Validate(System.Workflow.ComponentModel.Compiler.ValidationManager manager, object obj) { return default(System.Workflow.ComponentModel.Compiler.ValidationErrorCollection); }
  }
}
namespace System.Workflow.Runtime.Hosting {
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class ChannelManagerService : System.Workflow.Runtime.Hosting.WorkflowRuntimeService {
    public ChannelManagerService() { }
    public ChannelManagerService(System.Collections.Generic.IList<System.ServiceModel.Description.ServiceEndpoint> endpoints) { }
    public ChannelManagerService(System.Collections.Specialized.NameValueCollection parameters) { }
    public ChannelManagerService(System.ServiceModel.Channels.ChannelPoolSettings settings) { }
    public ChannelManagerService(System.ServiceModel.Channels.ChannelPoolSettings settings, System.Collections.Generic.IList<System.ServiceModel.Description.ServiceEndpoint> endpoints) { }
    protected internal override void Start() { }
    protected internal override void Stop() { }
  }
}
