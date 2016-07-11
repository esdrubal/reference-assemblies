namespace System.Workflow.Activities {
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class ActiveDirectoryRole : System.Workflow.Activities.WorkflowRole, System.IDisposable, System.Runtime.Serialization.ISerializable {
    internal ActiveDirectoryRole() { }
    public override string Name { get { return default(string); } set { } }
    public System.DirectoryServices.DirectoryEntry RootEntry { get { return default(System.DirectoryServices.DirectoryEntry); } }
    public System.Workflow.Activities.ActiveDirectoryRole GetAllReports() { return default(System.Workflow.Activities.ActiveDirectoryRole); }
    public System.Workflow.Activities.ActiveDirectoryRole GetDirectReports() { return default(System.Workflow.Activities.ActiveDirectoryRole); }
    public System.Collections.Generic.ICollection<System.DirectoryServices.DirectoryEntry> GetEntries() { return default(System.Collections.Generic.ICollection<System.DirectoryServices.DirectoryEntry>); }
    public override System.Collections.Generic.IList<System.String> GetIdentities() { return default(System.Collections.Generic.IList<System.String>); }
    public System.Workflow.Activities.ActiveDirectoryRole GetManager() { return default(System.Workflow.Activities.ActiveDirectoryRole); }
    public System.Workflow.Activities.ActiveDirectoryRole GetManagerialChain() { return default(System.Workflow.Activities.ActiveDirectoryRole); }
    public System.Workflow.Activities.ActiveDirectoryRole GetPeers() { return default(System.Workflow.Activities.ActiveDirectoryRole); }
    public System.Collections.Generic.IList<System.Security.Principal.SecurityIdentifier> GetSecurityIdentifiers() { return default(System.Collections.Generic.IList<System.Security.Principal.SecurityIdentifier>); }
    public override bool IncludesIdentity(string identity) { return default(bool); }
    void System.IDisposable.Dispose() { }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, SerializationFormatter=true)]
    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public static partial class ActiveDirectoryRoleFactory {
    public static System.Workflow.Activities.Configuration.ActiveDirectoryRoleFactoryConfiguration Configuration { get { return default(System.Workflow.Activities.Configuration.ActiveDirectoryRoleFactoryConfiguration); } }
    public static System.Workflow.Activities.ActiveDirectoryRole CreateFromAlias(string alias) { return default(System.Workflow.Activities.ActiveDirectoryRole); }
    public static System.Workflow.Activities.ActiveDirectoryRole CreateFromEmailAddress(string emailAddress) { return default(System.Workflow.Activities.ActiveDirectoryRole); }
    public static System.Workflow.Activities.ActiveDirectoryRole CreateFromSecurityIdentifier(System.Security.Principal.SecurityIdentifier sid) { return default(System.Workflow.Activities.ActiveDirectoryRole); }
  }
  [SRCategoryAttribute("Base")]
  [SRDescriptionAttribute("CallExternalMethodActivityDescription")]
  [System.ComponentModel.DefaultEventAttribute("MethodInvoking")]
  [System.ComponentModel.DesignerAttribute(typeof(System.Workflow.Activities.CallExternalMethodActivityDesigner), typeof(System.ComponentModel.Design.IDesigner))]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Workflow.ComponentModel.Compiler.ActivityValidatorAttribute(typeof(System.Workflow.Activities.CallExternalMethodActivityValidator))]
  public partial class CallExternalMethodActivity : System.Workflow.ComponentModel.Activity, System.Workflow.ComponentModel.IDynamicPropertyTypeProvider {
    public static readonly System.Workflow.ComponentModel.DependencyProperty CorrelationTokenProperty;
    public static readonly System.Workflow.ComponentModel.DependencyProperty InterfaceTypeProperty;
    public static readonly System.Workflow.ComponentModel.DependencyProperty MethodInvokingEvent;
    public static readonly System.Workflow.ComponentModel.DependencyProperty MethodNameProperty;
    public static readonly System.Workflow.ComponentModel.DependencyProperty ParameterBindingsProperty;
    public CallExternalMethodActivity() { }
    public CallExternalMethodActivity(string name) { }
    [SRCategoryAttribute("Activity")]
    [SRDescriptionAttribute("CorrelationSetDescr")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Workflow.Activities.CorrelationTokenTypeConverter))]
    public virtual System.Workflow.Runtime.CorrelationToken CorrelationToken { get { return default(System.Workflow.Runtime.CorrelationToken); } set { } }
    [SRCategoryAttribute("Activity")]
    [SRDescriptionAttribute("HelperExternalDataExchangeDesc")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.EditorAttribute(typeof(System.Workflow.ComponentModel.Design.TypeBrowserEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Workflow.ComponentModel.Design.TypeFilterProviderAttribute(typeof(System.Workflow.Activities.ExternalDataExchangeInterfaceTypeFilterProvider))]
    public virtual System.Type InterfaceType { get { return default(System.Type); } set { } }
    [SRCategoryAttribute("Activity")]
    [SRDescriptionAttribute("ExternalMethodNameDescr")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Workflow.Activities.Common.PropertyValueProviderTypeConverter))]
    public virtual string MethodName { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    public System.Workflow.ComponentModel.WorkflowParameterBindingCollection ParameterBindings { get { return default(System.Workflow.ComponentModel.WorkflowParameterBindingCollection); } }
    [SRCategoryAttribute("Handlers")]
    [SRDescriptionAttribute("OnBeforeMethodInvokeDescr")]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    public event System.EventHandler MethodInvoking { add { } remove { } }
    protected sealed override System.Workflow.ComponentModel.ActivityExecutionStatus Execute(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    protected override void InitializeProperties() { }
    protected virtual void OnMethodInvoked(System.EventArgs e) { }
    protected virtual void OnMethodInvoking(System.EventArgs e) { }
    System.Workflow.ComponentModel.Compiler.AccessTypes System.Workflow.ComponentModel.IDynamicPropertyTypeProvider.GetAccessType(System.IServiceProvider serviceProvider, string propertyName) { return default(System.Workflow.ComponentModel.Compiler.AccessTypes); }
    System.Type System.Workflow.ComponentModel.IDynamicPropertyTypeProvider.GetPropertyType(System.IServiceProvider serviceProvider, string propertyName) { return default(System.Type); }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class CallExternalMethodActivityValidator : System.Workflow.ComponentModel.Compiler.ActivityValidator {
    public CallExternalMethodActivityValidator() { }
    public override System.Workflow.ComponentModel.Compiler.ValidationErrorCollection Validate(System.Workflow.ComponentModel.Compiler.ValidationManager manager, object obj) { return default(System.Workflow.ComponentModel.Compiler.ValidationErrorCollection); }
  }
  [SRCategoryAttribute("Standard")]
  [SRDescriptionAttribute("CodeActivityDescription")]
  [System.ComponentModel.DefaultEventAttribute("ExecuteCode")]
  [System.ComponentModel.DesignerAttribute(typeof(System.Workflow.Activities.CodeDesigner), typeof(System.ComponentModel.Design.IDesigner))]
  [System.ComponentModel.ToolboxItemAttribute(typeof(System.Workflow.ComponentModel.Design.ActivityToolboxItem))]
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Workflow.Activities.CodeActivity), "Resources.code.png")]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Workflow.ComponentModel.Compiler.ActivityValidatorAttribute(typeof(System.Workflow.Activities.CodeActivity.CodeActivityValidator))]
  public sealed partial class CodeActivity : System.Workflow.ComponentModel.Activity {
    public static readonly System.Workflow.ComponentModel.DependencyProperty ExecuteCodeEvent;
    public CodeActivity() { }
    public CodeActivity(string name) { }
    [SRCategoryAttribute("Handlers")]
    [SRDescriptionAttribute("UserCodeHandlerDescr")]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    public event System.EventHandler ExecuteCode { add { } remove { } }
    protected sealed override System.Workflow.ComponentModel.ActivityExecutionStatus Execute(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
  }
  [SRDisplayNameAttribute("CodeConditionDisplayName")]
  [System.ComponentModel.ToolboxItemAttribute(false)]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Workflow.ComponentModel.Compiler.ActivityValidatorAttribute(typeof(System.Workflow.Activities.CodeCondition.CodeConditionValidator))]
  public partial class CodeCondition : System.Workflow.ComponentModel.ActivityCondition {
    public static readonly System.Workflow.ComponentModel.DependencyProperty ConditionEvent;
    public CodeCondition() { }
    [SRCategoryAttribute("Handlers")]
    [SRDescriptionAttribute("ExpressionDescr")]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    public event System.EventHandler<System.Workflow.Activities.ConditionalEventArgs> Condition { add { } remove { } }
    public override bool Evaluate(System.Workflow.ComponentModel.Activity ownerActivity, System.IServiceProvider provider) { return default(bool); }
    protected override object GetBoundValue(System.Workflow.ComponentModel.ActivityBind bind, System.Type targetType) { return default(object); }
  }
  [SRCategoryAttribute("Standard")]
  [SRDescriptionAttribute("CompensatableSequenceActivityDescription")]
  [System.ComponentModel.DesignerAttribute(typeof(System.Workflow.Activities.SequenceDesigner), typeof(System.ComponentModel.Design.IDesigner))]
  [System.ComponentModel.ToolboxItemAttribute(typeof(System.Workflow.ComponentModel.Design.ActivityToolboxItem))]
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Workflow.Activities.CompensatableSequenceActivity), "Resources.Sequence.png")]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class CompensatableSequenceActivity : System.Workflow.Activities.SequenceActivity, System.Workflow.ComponentModel.ICompensatableActivity {
    public CompensatableSequenceActivity() { }
    public CompensatableSequenceActivity(string name) { }
    System.Workflow.ComponentModel.ActivityExecutionStatus System.Workflow.ComponentModel.ICompensatableActivity.Compensate(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class ConditionalEventArgs : System.EventArgs {
    public ConditionalEventArgs() { }
    public ConditionalEventArgs(bool result) { }
    public bool Result { get { return default(bool); } set { } }
  }
  [SRCategoryAttribute("Standard")]
  [SRDescriptionAttribute("ConstrainedGroupActivityDescription")]
  [System.ComponentModel.DesignerAttribute(typeof(System.Workflow.Activities.ConditionedActivityGroupDesigner), typeof(System.ComponentModel.Design.IDesigner))]
  [System.ComponentModel.ToolboxItemAttribute(typeof(System.Workflow.ComponentModel.Design.ActivityToolboxItem))]
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Workflow.Activities.ConditionedActivityGroup), "Resources.cag.png")]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Workflow.ComponentModel.Compiler.ActivityValidatorAttribute(typeof(System.Workflow.Activities.ConditionedActivityGroupValidator))]
  [System.Workflow.Runtime.DebugEngine.WorkflowDebuggerSteppingAttribute((System.Workflow.Runtime.DebugEngine.WorkflowDebuggerSteppingOption)(1))]
  public sealed partial class ConditionedActivityGroup : System.Workflow.ComponentModel.CompositeActivity, System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs> {
    public static readonly System.Workflow.ComponentModel.DependencyProperty UntilConditionProperty;
    public static readonly System.Workflow.ComponentModel.DependencyProperty WhenConditionProperty;
    public ConditionedActivityGroup() { }
    public ConditionedActivityGroup(string name) { }
    [SRCategoryAttribute("Conditions")]
    [SRDescriptionAttribute("UntilConditionDescr")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Workflow.ComponentModel.ActivityCondition UntilCondition { get { return default(System.Workflow.ComponentModel.ActivityCondition); } set { } }
    protected override System.Workflow.ComponentModel.ActivityExecutionStatus Cancel(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    protected override System.Workflow.ComponentModel.ActivityExecutionStatus Execute(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    public int GetChildActivityExecutedCount(System.Workflow.ComponentModel.Activity child) { return default(int); }
    public System.Workflow.ComponentModel.Activity GetDynamicActivity(string childActivityName) { return default(System.Workflow.ComponentModel.Activity); }
    public static object GetWhenCondition(object dependencyObject) { return default(object); }
    protected override void OnActivityChangeAdd(System.Workflow.ComponentModel.ActivityExecutionContext executionContext, System.Workflow.ComponentModel.Activity addedActivity) { }
    protected override void OnActivityChangeRemove(System.Workflow.ComponentModel.ActivityExecutionContext executionContext, System.Workflow.ComponentModel.Activity removedActivity) { }
    protected override void OnClosed(System.IServiceProvider provider) { }
    protected override void OnWorkflowChangesCompleted(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { }
    public static void SetWhenCondition(object dependencyObject, object value) { }
    void System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs>.OnEvent(object sender, System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs e) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4672), AllowMultiple=true)]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class CorrelationAliasAttribute : System.Attribute {
    public CorrelationAliasAttribute(string name, string path) { }
    public string Name { get { return default(string); } }
    public string Path { get { return default(string); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(576), AllowMultiple=false)]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class CorrelationInitializerAttribute : System.Attribute {
    public CorrelationInitializerAttribute() { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(1024), AllowMultiple=true)]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class CorrelationParameterAttribute : System.Attribute {
    public CorrelationParameterAttribute(string name) { }
    public string Name { get { return default(string); } }
  }
  [SRCategoryAttribute("Standard")]
  [SRDescriptionAttribute("DelayActivityDescription")]
  [System.ComponentModel.DefaultEventAttribute("InitializeTimeoutDuration")]
  [System.ComponentModel.DesignerAttribute(typeof(System.Workflow.Activities.DelayDesigner), typeof(System.ComponentModel.Design.IDesigner))]
  [System.ComponentModel.ToolboxItemAttribute(typeof(System.Workflow.ComponentModel.Design.ActivityToolboxItem))]
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Workflow.Activities.DelayActivity), "Resources.Delay.png")]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Workflow.ComponentModel.Compiler.ActivityValidatorAttribute(typeof(System.Workflow.Activities.DelayActivity.DelayActivityValidator))]
  public sealed partial class DelayActivity : System.Workflow.ComponentModel.Activity, System.Workflow.Activities.IEventActivity, System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.QueueEventArgs> {
    public static readonly System.Workflow.ComponentModel.DependencyProperty InitializeTimeoutDurationEvent;
    public static readonly System.Workflow.ComponentModel.DependencyProperty TimeoutDurationProperty;
    public DelayActivity() { }
    public DelayActivity(string name) { }
    System.IComparable System.Workflow.Activities.IEventActivity.QueueName { get { return default(System.IComparable); } }
    [SRDescriptionAttribute("TimeoutDurationDescription")]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Workflow.Activities.DelayActivity.TimeoutDurationConverter))]
    public System.TimeSpan TimeoutDuration { get { return default(System.TimeSpan); } set { } }
    [SRCategoryAttribute("Handlers")]
    [SRDescriptionAttribute("TimeoutInitializerDescription")]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    public event System.EventHandler InitializeTimeoutDuration { add { } remove { } }
    protected override System.Workflow.ComponentModel.ActivityExecutionStatus Cancel(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    protected override System.Workflow.ComponentModel.ActivityExecutionStatus Execute(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    protected sealed override System.Workflow.ComponentModel.ActivityExecutionStatus HandleFault(System.Workflow.ComponentModel.ActivityExecutionContext executionContext, System.Exception exception) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    protected override void Initialize(System.IServiceProvider provider) { }
    protected override void OnClosed(System.IServiceProvider provider) { }
    void System.Workflow.Activities.IEventActivity.Subscribe(System.Workflow.ComponentModel.ActivityExecutionContext parentContext, System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.QueueEventArgs> parentEventHandler) { }
    void System.Workflow.Activities.IEventActivity.Unsubscribe(System.Workflow.ComponentModel.ActivityExecutionContext parentContext, System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.QueueEventArgs> parentEventHandler) { }
    void System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.QueueEventArgs>.OnEvent(object sender, System.Workflow.ComponentModel.QueueEventArgs e) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class EventDeliveryFailedException : System.SystemException {
    public EventDeliveryFailedException() { }
    public EventDeliveryFailedException(string message) { }
    public EventDeliveryFailedException(string message, System.Exception innerException) { }
  }
  [SRCategoryAttribute("Standard")]
  [SRDescriptionAttribute("EventDrivenActivityDescription")]
  [System.ComponentModel.DesignerAttribute(typeof(System.Workflow.Activities.EventDrivenDesigner), typeof(System.ComponentModel.Design.IDesigner))]
  [System.ComponentModel.ToolboxItemAttribute(typeof(System.Workflow.ComponentModel.Design.ActivityToolboxItem))]
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Workflow.Activities.EventDrivenActivity), "Resources.EventDriven.png")]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Workflow.ComponentModel.Compiler.ActivityValidatorAttribute(typeof(System.Workflow.Activities.EventDrivenValidator))]
  public sealed partial class EventDrivenActivity : System.Workflow.Activities.SequenceActivity {
    public EventDrivenActivity() { }
    public EventDrivenActivity(string name) { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Workflow.Activities.IEventActivity EventActivity { get { return default(System.Workflow.Activities.IEventActivity); } }
  }
  [SRCategoryAttribute("Standard")]
  [System.ComponentModel.DesignerAttribute(typeof(System.Workflow.Activities.EventHandlersDesigner), typeof(System.ComponentModel.Design.IDesigner))]
  [System.ComponentModel.ToolboxItemAttribute(false)]
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Workflow.Activities.EventHandlersActivity), "Resources.events.png")]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Workflow.ComponentModel.AlternateFlowActivityAttribute]
  [System.Workflow.ComponentModel.Compiler.ActivityValidatorAttribute(typeof(System.Workflow.Activities.EventHandlersValidator))]
  public sealed partial class EventHandlersActivity : System.Workflow.ComponentModel.CompositeActivity, System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs> {
    public EventHandlersActivity() { }
    public EventHandlersActivity(string name) { }
    protected override System.Workflow.ComponentModel.ActivityExecutionStatus Cancel(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    protected override System.Workflow.ComponentModel.ActivityExecutionStatus Execute(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    public System.Workflow.ComponentModel.Activity GetDynamicActivity(string childActivityName) { return default(System.Workflow.ComponentModel.Activity); }
    protected override void Initialize(System.IServiceProvider provider) { }
    protected override void OnActivityChangeAdd(System.Workflow.ComponentModel.ActivityExecutionContext executionContext, System.Workflow.ComponentModel.Activity addedActivity) { }
    protected override void OnActivityChangeRemove(System.Workflow.ComponentModel.ActivityExecutionContext executionContext, System.Workflow.ComponentModel.Activity removedActivity) { }
    protected override void OnClosed(System.IServiceProvider provider) { }
    protected override void OnWorkflowChangesCompleted(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { }
    void System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs>.OnEvent(object sender, System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs e) { }
  }
  [SRDescriptionAttribute("EventHandlingScopeActivityDescription")]
  [System.ComponentModel.DesignerAttribute(typeof(System.Workflow.Activities.EventHandlingScopeDesigner), typeof(System.ComponentModel.Design.IDesigner))]
  [System.ComponentModel.ToolboxItemAttribute(typeof(System.Workflow.ComponentModel.Design.ActivityToolboxItem))]
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Workflow.Activities.EventHandlingScopeActivity), "Resources.Sequence.png")]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Workflow.ComponentModel.Compiler.ActivityValidatorAttribute(typeof(System.Workflow.Activities.EventHandlingScopeValidator))]
  public sealed partial class EventHandlingScopeActivity : System.Workflow.ComponentModel.CompositeActivity, System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs> {
    public EventHandlingScopeActivity() { }
    public EventHandlingScopeActivity(string name) { }
    protected override System.Workflow.ComponentModel.ActivityExecutionStatus Cancel(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    protected override System.Workflow.ComponentModel.ActivityExecutionStatus Execute(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    protected override void OnActivityChangeRemove(System.Workflow.ComponentModel.ActivityExecutionContext executionContext, System.Workflow.ComponentModel.Activity removedActivity) { }
    protected override void OnWorkflowChangesCompleted(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { }
    void System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs>.OnEvent(object sender, System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs e) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class EventQueueName : System.IComparable {
    public EventQueueName(System.Type interfaceType, string operation) { }
    public EventQueueName(System.Type interfaceType, string operation, System.Collections.Generic.ICollection<System.Workflow.Runtime.CorrelationProperty> propertyValues) { }
    public System.Type InterfaceType { get { return default(System.Type); } }
    public string MethodName { get { return default(string); } }
    public int CompareTo(object toCompare) { return default(int); }
    public int CompareTo(System.Workflow.Activities.EventQueueName eventQueueName) { return default(int); }
    public override bool Equals(object obj) { return default(bool); }
    public System.Workflow.Runtime.CorrelationProperty[] GetCorrelationValues() { return default(System.Workflow.Runtime.CorrelationProperty[]); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Workflow.Activities.EventQueueName queueKey1, System.Workflow.Activities.EventQueueName queueKey2) { return default(bool); }
    public static bool operator >(System.Workflow.Activities.EventQueueName queueKey1, System.Workflow.Activities.EventQueueName queueKey2) { return default(bool); }
    public static bool operator !=(System.Workflow.Activities.EventQueueName queueKey1, System.Workflow.Activities.EventQueueName queueKey2) { return default(bool); }
    public static bool operator <(System.Workflow.Activities.EventQueueName queueKey1, System.Workflow.Activities.EventQueueName queueKey2) { return default(bool); }
    public override string ToString() { return default(string); }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public enum ExecutionType {
    Parallel = 1,
    Sequence = 0,
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class ExternalDataEventArgs : System.EventArgs {
    public ExternalDataEventArgs() { }
    public ExternalDataEventArgs(System.Guid instanceId) { }
    public ExternalDataEventArgs(System.Guid instanceId, System.Workflow.Runtime.IPendingWork workHandler, object workItem) { }
    public ExternalDataEventArgs(System.Guid instanceId, System.Workflow.Runtime.IPendingWork workHandler, object workItem, bool waitForIdle) { }
    public string Identity { get { return default(string); } set { } }
    public System.Guid InstanceId { get { return default(System.Guid); } set { } }
    public bool WaitForIdle { get { return default(bool); } set { } }
    public System.Workflow.Runtime.IPendingWork WorkHandler { get { return default(System.Workflow.Runtime.IPendingWork); } set { } }
    public object WorkItem { get { return default(object); } set { } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(1024), AllowMultiple=false, Inherited=false)]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class ExternalDataExchangeAttribute : System.Attribute {
    public ExternalDataExchangeAttribute() { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class ExternalDataExchangeService : System.Workflow.Runtime.Hosting.WorkflowRuntimeService {
    public ExternalDataExchangeService() { }
    public ExternalDataExchangeService(System.Collections.Specialized.NameValueCollection parameters) { }
    public ExternalDataExchangeService(string configSectionName) { }
    public ExternalDataExchangeService(System.Workflow.Activities.ExternalDataExchangeServiceSection settings) { }
    public virtual void AddService(object service) { }
    public virtual object GetService(System.Type serviceType) { return default(object); }
    public virtual void RemoveService(object service) { }
    protected override void Start() { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class ExternalDataExchangeServiceSection : System.Configuration.ConfigurationSection {
    public ExternalDataExchangeServiceSection() { }
    [System.Configuration.ConfigurationPropertyAttribute("Services", DefaultValue=null)]
    public System.Workflow.Runtime.Configuration.WorkflowRuntimeServiceElementCollection Services { get { return default(System.Workflow.Runtime.Configuration.WorkflowRuntimeServiceElementCollection); } }
  }
  [SRCategoryAttribute("Base")]
  [SRDescriptionAttribute("HandleExternalEventActivityDescription")]
  [System.ComponentModel.DefaultEventAttribute("Invoked")]
  [System.ComponentModel.DesignerAttribute(typeof(System.Workflow.Activities.HandleExternalEventActivityDesigner), typeof(System.ComponentModel.Design.IDesigner))]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Workflow.ComponentModel.Compiler.ActivityValidatorAttribute(typeof(System.Workflow.Activities.HandleExternalEventActivityValidator))]
  public partial class HandleExternalEventActivity : System.Workflow.ComponentModel.Activity, System.Workflow.Activities.IEventActivity, System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.QueueEventArgs>, System.Workflow.ComponentModel.IDynamicPropertyTypeProvider {
    public static readonly System.Workflow.ComponentModel.DependencyProperty CorrelationTokenProperty;
    public static readonly System.Workflow.ComponentModel.DependencyProperty EventNameProperty;
    public static readonly System.Workflow.ComponentModel.DependencyProperty InterfaceTypeProperty;
    public static readonly System.Workflow.ComponentModel.DependencyProperty InvokedEvent;
    public static readonly System.Workflow.ComponentModel.DependencyProperty ParameterBindingsProperty;
    public static readonly System.Workflow.ComponentModel.DependencyProperty RolesProperty;
    public HandleExternalEventActivity() { }
    public HandleExternalEventActivity(string name) { }
    [SRCategoryAttribute("Activity")]
    [SRDescriptionAttribute("CorrelationSetDescr")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Workflow.Activities.CorrelationTokenTypeConverter))]
    public virtual System.Workflow.Runtime.CorrelationToken CorrelationToken { get { return default(System.Workflow.Runtime.CorrelationToken); } set { } }
    [SRCategoryAttribute("Activity")]
    [SRDescriptionAttribute("ExternalEventNameDescr")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Workflow.Activities.Common.PropertyValueProviderTypeConverter))]
    public virtual string EventName { get { return default(string); } set { } }
    [SRCategoryAttribute("Activity")]
    [SRDescriptionAttribute("HelperExternalDataExchangeDesc")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.EditorAttribute(typeof(System.Workflow.ComponentModel.Design.TypeBrowserEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Workflow.ComponentModel.Design.TypeFilterProviderAttribute(typeof(System.Workflow.Activities.ExternalDataExchangeInterfaceTypeFilterProvider))]
    public virtual System.Type InterfaceType { get { return default(System.Type); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    public System.Workflow.ComponentModel.WorkflowParameterBindingCollection ParameterBindings { get { return default(System.Workflow.ComponentModel.WorkflowParameterBindingCollection); } }
    [SRCategoryAttribute("Activity")]
    [SRDescriptionAttribute("RoleDescr")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.EditorAttribute(typeof(System.Workflow.ComponentModel.Design.BindUITypeEditor), typeof(System.Drawing.Design.UITypeEditor))]
    public System.Workflow.Activities.WorkflowRoleCollection Roles { get { return default(System.Workflow.Activities.WorkflowRoleCollection); } set { } }
    System.IComparable System.Workflow.Activities.IEventActivity.QueueName { get { return default(System.IComparable); } }
    [SRCategoryAttribute("Handlers")]
    [SRDescriptionAttribute("OnAfterMethodInvokeDescr")]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    public event System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs> Invoked { add { } remove { } }
    protected sealed override System.Workflow.ComponentModel.ActivityExecutionStatus Cancel(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    protected sealed override System.Workflow.ComponentModel.ActivityExecutionStatus Execute(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    protected sealed override System.Workflow.ComponentModel.ActivityExecutionStatus HandleFault(System.Workflow.ComponentModel.ActivityExecutionContext executionContext, System.Exception exception) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    protected sealed override void Initialize(System.IServiceProvider provider) { }
    protected override void InitializeProperties() { }
    protected override void OnClosed(System.IServiceProvider provider) { }
    protected virtual void OnInvoked(System.EventArgs e) { }
    void System.Workflow.Activities.IEventActivity.Subscribe(System.Workflow.ComponentModel.ActivityExecutionContext parentContext, System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.QueueEventArgs> parentEventHandler) { }
    void System.Workflow.Activities.IEventActivity.Unsubscribe(System.Workflow.ComponentModel.ActivityExecutionContext parentContext, System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.QueueEventArgs> parentEventHandler) { }
    void System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.QueueEventArgs>.OnEvent(object sender, System.Workflow.ComponentModel.QueueEventArgs e) { }
    System.Workflow.ComponentModel.Compiler.AccessTypes System.Workflow.ComponentModel.IDynamicPropertyTypeProvider.GetAccessType(System.IServiceProvider serviceProvider, string propertyName) { return default(System.Workflow.ComponentModel.Compiler.AccessTypes); }
    System.Type System.Workflow.ComponentModel.IDynamicPropertyTypeProvider.GetPropertyType(System.IServiceProvider serviceProvider, string propertyName) { return default(System.Type); }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class HandleExternalEventActivityValidator : System.Workflow.ComponentModel.Compiler.ActivityValidator {
    public HandleExternalEventActivityValidator() { }
    public override System.Workflow.ComponentModel.Compiler.ValidationErrorCollection Validate(System.Workflow.ComponentModel.Compiler.ValidationManager manager, object obj) { return default(System.Workflow.ComponentModel.Compiler.ValidationErrorCollection); }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial interface IEventActivity {
    System.IComparable QueueName { get; }
    void Subscribe(System.Workflow.ComponentModel.ActivityExecutionContext parentContext, System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.QueueEventArgs> parentEventHandler);
    void Unsubscribe(System.Workflow.ComponentModel.ActivityExecutionContext parentContext, System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.QueueEventArgs> parentEventHandler);
  }
  [SRCategoryAttribute("Standard")]
  [SRDescriptionAttribute("ConditionalActivityDescription")]
  [System.ComponentModel.DesignerAttribute(typeof(System.Workflow.Activities.IfElseDesigner), typeof(System.ComponentModel.Design.IDesigner))]
  [System.ComponentModel.ToolboxItemAttribute(typeof(System.Workflow.Activities.IfElseToolboxItem))]
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Workflow.Activities.IfElseActivity), "Resources.Decision.png")]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Workflow.ComponentModel.Compiler.ActivityValidatorAttribute(typeof(System.Workflow.Activities.IfElseValidator))]
  public sealed partial class IfElseActivity : System.Workflow.ComponentModel.CompositeActivity, System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs> {
    public IfElseActivity() { }
    public IfElseActivity(string name) { }
    public System.Workflow.Activities.IfElseBranchActivity AddBranch(System.Collections.Generic.ICollection<System.Workflow.ComponentModel.Activity> activities) { return default(System.Workflow.Activities.IfElseBranchActivity); }
    public System.Workflow.Activities.IfElseBranchActivity AddBranch(System.Collections.Generic.ICollection<System.Workflow.ComponentModel.Activity> activities, System.Workflow.ComponentModel.ActivityCondition branchCondition) { return default(System.Workflow.Activities.IfElseBranchActivity); }
    protected override System.Workflow.ComponentModel.ActivityExecutionStatus Cancel(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    protected override System.Workflow.ComponentModel.ActivityExecutionStatus Execute(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    void System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs>.OnEvent(object sender, System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs e) { }
  }
  [SRCategoryAttribute("Standard")]
  [System.ComponentModel.DesignerAttribute(typeof(System.Workflow.Activities.IfElseBranchDesigner), typeof(System.ComponentModel.Design.IDesigner))]
  [System.ComponentModel.ToolboxItemAttribute(false)]
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Workflow.Activities.IfElseBranchActivity), "Resources.DecisionBranch.bmp")]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Workflow.ComponentModel.Compiler.ActivityValidatorAttribute(typeof(System.Workflow.Activities.IfElseBranchValidator))]
  public sealed partial class IfElseBranchActivity : System.Workflow.Activities.SequenceActivity {
    public static readonly System.Workflow.ComponentModel.DependencyProperty ConditionProperty;
    public IfElseBranchActivity() { }
    public IfElseBranchActivity(string name) { }
    [SRCategoryAttribute("Conditions")]
    [SRDescriptionAttribute("ConditionDescr")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(2))]
    public System.Workflow.ComponentModel.ActivityCondition Condition { get { return default(System.Workflow.ComponentModel.ActivityCondition); } set { } }
  }
  [SRCategoryAttribute("Standard")]
  [SRDescriptionAttribute("InvokeWebServiceActivityDescription")]
  [System.ComponentModel.DesignerAttribute(typeof(System.Workflow.Activities.InvokeWebServiceDesigner), typeof(System.ComponentModel.Design.IDesigner))]
  [System.ComponentModel.ToolboxItemAttribute(typeof(System.Workflow.Activities.InvokeWebServiceToolboxItem))]
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Workflow.Activities.InvokeWebServiceActivity), "Resources.WebServiceInOut.png")]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Workflow.ComponentModel.Compiler.ActivityValidatorAttribute(typeof(System.Workflow.Activities.InvokeWebServiceValidator))]
  public sealed partial class InvokeWebServiceActivity : System.Workflow.ComponentModel.Activity, System.Workflow.ComponentModel.IDynamicPropertyTypeProvider {
    public static readonly System.Workflow.ComponentModel.DependencyProperty InvokedEvent;
    public static readonly System.Workflow.ComponentModel.DependencyProperty InvokingEvent;
    public static readonly System.Workflow.ComponentModel.DependencyProperty MethodNameProperty;
    public static readonly System.Workflow.ComponentModel.DependencyProperty ParameterBindingsProperty;
    public static readonly System.Workflow.ComponentModel.DependencyProperty ProxyClassProperty;
    public static readonly System.Workflow.ComponentModel.DependencyProperty SessionIdProperty;
    public InvokeWebServiceActivity() { }
    public InvokeWebServiceActivity(string name) { }
    [SRCategoryAttribute("Activity")]
    [SRDescriptionAttribute("MethodNameDescr")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Workflow.Activities.Common.PropertyValueProviderTypeConverter))]
    public string MethodName { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    public System.Workflow.ComponentModel.WorkflowParameterBindingCollection ParameterBindings { get { return default(System.Workflow.ComponentModel.WorkflowParameterBindingCollection); } }
    [SRCategoryAttribute("Activity")]
    [SRDescriptionAttribute("ProxyClassDescr")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Workflow.Activities.Common.TypePropertyValueProviderTypeConverter))]
    public System.Type ProxyClass { get { return default(System.Type); } set { } }
    [SRCategoryAttribute("Activity")]
    [SRDescriptionAttribute("WebServiceSessionIDDescr")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    public string SessionId { get { return default(string); } set { } }
    [SRCategoryAttribute("Handlers")]
    [SRDescriptionAttribute("OnAfterMethodInvokeDescr")]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    public event System.EventHandler<System.Workflow.Activities.InvokeWebServiceEventArgs> Invoked { add { } remove { } }
    [SRCategoryAttribute("Handlers")]
    [SRDescriptionAttribute("OnBeforeMethodInvokeDescr")]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    public event System.EventHandler<System.Workflow.Activities.InvokeWebServiceEventArgs> Invoking { add { } remove { } }
    protected sealed override System.Workflow.ComponentModel.ActivityExecutionStatus Execute(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    protected override void OnClosed(System.IServiceProvider provider) { }
    System.Workflow.ComponentModel.Compiler.AccessTypes System.Workflow.ComponentModel.IDynamicPropertyTypeProvider.GetAccessType(System.IServiceProvider serviceProvider, string propertyName) { return default(System.Workflow.ComponentModel.Compiler.AccessTypes); }
    System.Type System.Workflow.ComponentModel.IDynamicPropertyTypeProvider.GetPropertyType(System.IServiceProvider serviceProvider, string propertyName) { return default(System.Type); }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class InvokeWebServiceEventArgs : System.EventArgs {
    public InvokeWebServiceEventArgs(object proxyInstance) { }
    public object WebServiceProxy { get { return default(object); } }
  }
  [SRDescriptionAttribute("InvokeWorkflowActivityDescription")]
  [System.ComponentModel.DefaultEventAttribute("Invoking")]
  [System.ComponentModel.ToolboxItemAttribute(typeof(System.Workflow.ComponentModel.Design.ActivityToolboxItem))]
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Workflow.Activities.InvokeWorkflowActivity), "Resources.Service.bmp")]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Workflow.ComponentModel.Compiler.ActivityValidatorAttribute(typeof(System.Workflow.Activities.InvokeWorkflowValidator))]
  public sealed partial class InvokeWorkflowActivity : System.Workflow.ComponentModel.Activity, System.Workflow.ComponentModel.Design.ITypeFilterProvider {
    public static readonly System.Workflow.ComponentModel.DependencyProperty InstanceIdProperty;
    public static readonly System.Workflow.ComponentModel.DependencyProperty InvokingEvent;
    public static readonly System.Workflow.ComponentModel.DependencyProperty ParameterBindingsProperty;
    public static readonly System.Workflow.ComponentModel.DependencyProperty TargetWorkflowProperty;
    public InvokeWorkflowActivity() { }
    public InvokeWorkflowActivity(string name) { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Guid InstanceId { get { return default(System.Guid); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    public System.Workflow.ComponentModel.WorkflowParameterBindingCollection ParameterBindings { get { return default(System.Workflow.ComponentModel.WorkflowParameterBindingCollection); } }
    string System.Workflow.ComponentModel.Design.ITypeFilterProvider.FilterDescription { get { return default(string); } }
    [SRCategoryAttribute("Activity")]
    [SRDescriptionAttribute("TargetWorkflowDescr")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.EditorAttribute(typeof(System.Workflow.ComponentModel.Design.TypeBrowserEditor), typeof(System.Drawing.Design.UITypeEditor))]
    public System.Type TargetWorkflow { get { return default(System.Type); } set { } }
    [SRCategoryAttribute("Handlers")]
    [SRDescriptionAttribute("InitializeCaleeDescr")]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    public event System.EventHandler Invoking { add { } remove { } }
    protected override System.Workflow.ComponentModel.ActivityExecutionStatus Execute(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    bool System.Workflow.ComponentModel.Design.ITypeFilterProvider.CanFilterType(System.Type type, bool throwOnError) { return default(bool); }
  }
  [SRCategoryAttribute("Standard")]
  [SRDescriptionAttribute("ListenActivityDescription")]
  [System.ComponentModel.DesignerAttribute(typeof(System.Workflow.Activities.ListenDesigner), typeof(System.ComponentModel.Design.IDesigner))]
  [System.ComponentModel.ToolboxItemAttribute(typeof(System.Workflow.Activities.ListenToolboxItem))]
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Workflow.Activities.ListenActivity), "Resources.Listen.png")]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Workflow.ComponentModel.Compiler.ActivityValidatorAttribute(typeof(System.Workflow.Activities.ListenValidator))]
  public sealed partial class ListenActivity : System.Workflow.ComponentModel.CompositeActivity, System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs> {
    public ListenActivity() { }
    public ListenActivity(string name) { }
    protected override System.Workflow.ComponentModel.ActivityExecutionStatus Cancel(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    protected override System.Workflow.ComponentModel.ActivityExecutionStatus Execute(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    protected sealed override void OnActivityChangeAdd(System.Workflow.ComponentModel.ActivityExecutionContext executionContext, System.Workflow.ComponentModel.Activity addedActivity) { }
    protected sealed override void OnActivityChangeRemove(System.Workflow.ComponentModel.ActivityExecutionContext executionContext, System.Workflow.ComponentModel.Activity removedActivity) { }
    protected override void OnClosed(System.IServiceProvider provider) { }
    protected override void OnWorkflowChangesCompleted(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { }
    void System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs>.OnEvent(object sender, System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs e) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class MessageEventSubscription {
    protected MessageEventSubscription() { }
    public MessageEventSubscription(System.IComparable queueName, System.Guid instanceId) { }
    public MessageEventSubscription(System.IComparable queueName, System.Guid instanceId, System.Guid subscriptionId) { }
    public MessageEventSubscription(System.IComparable queueName, System.Guid subscriptionId, System.Type interfaceType, string operation) { }
    public MessageEventSubscription(System.IComparable queueName, System.Guid instanceId, System.Type interfaceType, string operation, System.Guid subscriptionId) { }
    public virtual System.Collections.Generic.ICollection<System.Workflow.Runtime.CorrelationProperty> CorrelationProperties { get { return default(System.Collections.Generic.ICollection<System.Workflow.Runtime.CorrelationProperty>); } }
    public virtual System.Type InterfaceType { get { return default(System.Type); } set { } }
    public virtual string MethodName { get { return default(string); } set { } }
    public virtual System.IComparable QueueName { get { return default(System.IComparable); } protected set { } }
    public virtual System.Guid SubscriptionId { get { return default(System.Guid); } }
    public virtual System.Guid WorkflowInstanceId { get { return default(System.Guid); } }
  }
  [SRCategoryAttribute("Standard")]
  [SRDescriptionAttribute("ParallelActivityDescription")]
  [System.ComponentModel.DesignerAttribute(typeof(System.Workflow.Activities.ParallelDesigner), typeof(System.ComponentModel.Design.IDesigner))]
  [System.ComponentModel.ToolboxItemAttribute(typeof(System.Workflow.Activities.ParallelToolboxItem))]
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Workflow.Activities.ParallelActivity), "Resources.Parallel.png")]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Workflow.ComponentModel.Compiler.ActivityValidatorAttribute(typeof(System.Workflow.Activities.ParallelValidator))]
  [System.Workflow.Runtime.DebugEngine.WorkflowDebuggerSteppingAttribute((System.Workflow.Runtime.DebugEngine.WorkflowDebuggerSteppingOption)(1))]
  public sealed partial class ParallelActivity : System.Workflow.ComponentModel.CompositeActivity, System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs> {
    public ParallelActivity() { }
    public ParallelActivity(string name) { }
    protected override System.Workflow.ComponentModel.ActivityExecutionStatus Cancel(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    protected override System.Workflow.ComponentModel.ActivityExecutionStatus Execute(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    protected override void OnActivityChangeAdd(System.Workflow.ComponentModel.ActivityExecutionContext executionContext, System.Workflow.ComponentModel.Activity addedActivity) { }
    protected override void OnActivityChangeRemove(System.Workflow.ComponentModel.ActivityExecutionContext rootExecutionContext, System.Workflow.ComponentModel.Activity removedActivity) { }
    protected override void OnClosed(System.IServiceProvider provider) { }
    protected override void OnWorkflowChangesCompleted(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { }
    void System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs>.OnEvent(object sender, System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs e) { }
  }
  [SRCategoryAttribute("Standard")]
  [SRDescriptionAttribute("PolicyActivityDescription")]
  [System.ComponentModel.DesignerAttribute(typeof(System.Workflow.Activities.PolicyDesigner), typeof(System.ComponentModel.Design.IDesigner))]
  [System.ComponentModel.ToolboxItemAttribute(typeof(System.Workflow.ComponentModel.Design.ActivityToolboxItem))]
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Workflow.Activities.PolicyActivity), "Resources.Rule.png")]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class PolicyActivity : System.Workflow.ComponentModel.Activity {
    public static readonly System.Workflow.ComponentModel.DependencyProperty RuleSetReferenceProperty;
    public PolicyActivity() { }
    public PolicyActivity(string name) { }
    [SRDescriptionAttribute("RuleSetDescription")]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    public System.Workflow.Activities.Rules.RuleSetReference RuleSetReference { get { return default(System.Workflow.Activities.Rules.RuleSetReference); } set { } }
    protected override System.Workflow.ComponentModel.ActivityExecutionStatus Execute(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    protected override void Initialize(System.IServiceProvider provider) { }
  }
  [SRDescriptionAttribute("ReplicatorActivityDescription")]
  [System.ComponentModel.DefaultEventAttribute("Initialized")]
  [System.ComponentModel.DesignerAttribute(typeof(System.Workflow.Activities.ReplicatorDesigner), typeof(System.ComponentModel.Design.IDesigner))]
  [System.ComponentModel.ToolboxItemAttribute(typeof(System.Workflow.ComponentModel.Design.ActivityToolboxItem))]
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Workflow.Activities.ReplicatorActivity), "Resources.Replicator.png")]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Workflow.ComponentModel.Compiler.ActivityValidatorAttribute(typeof(System.Workflow.Activities.ReplicatorValidator))]
  [System.Workflow.Runtime.DebugEngine.WorkflowDebuggerSteppingAttribute((System.Workflow.Runtime.DebugEngine.WorkflowDebuggerSteppingOption)(1))]
  public sealed partial class ReplicatorActivity : System.Workflow.ComponentModel.CompositeActivity {
    public static readonly System.Workflow.ComponentModel.DependencyProperty ChildCompletedEvent;
    public static readonly System.Workflow.ComponentModel.DependencyProperty ChildInitializedEvent;
    public static readonly System.Workflow.ComponentModel.DependencyProperty CompletedEvent;
    public static readonly System.Workflow.ComponentModel.DependencyProperty ExecutionTypeProperty;
    public static readonly System.Workflow.ComponentModel.DependencyProperty InitialChildDataProperty;
    public static readonly System.Workflow.ComponentModel.DependencyProperty InitializedEvent;
    public static readonly System.Workflow.ComponentModel.DependencyProperty UntilConditionProperty;
    public ReplicatorActivity() { }
    public ReplicatorActivity(string name) { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public bool AllChildrenComplete { get { return default(bool); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Collections.IList CurrentChildData { get { return default(System.Collections.IList); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public int CurrentIndex { get { return default(int); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Collections.Generic.ICollection<System.Workflow.ComponentModel.Activity> DynamicActivities { get { return default(System.Collections.Generic.ICollection<System.Workflow.ComponentModel.Activity>); } }
    [SRCategoryAttribute("Properties")]
    [SRDescriptionAttribute("ExecutionTypeDescr")]
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(1))]
    public System.Workflow.Activities.ExecutionType ExecutionType { get { return default(System.Workflow.Activities.ExecutionType); } set { } }
    [SRCategoryAttribute("Properties")]
    [SRDescriptionAttribute("InitialChildDataDescr")]
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(1))]
    [System.ComponentModel.EditorAttribute(typeof(System.Workflow.ComponentModel.Design.BindUITypeEditor), typeof(System.Drawing.Design.UITypeEditor))]
    public System.Collections.IList InitialChildData { get { return default(System.Collections.IList); } set { } }
    [SRCategoryAttribute("Conditions")]
    [SRDescriptionAttribute("ReplicatorUntilConditionDescr")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Workflow.ComponentModel.ActivityCondition UntilCondition { get { return default(System.Workflow.ComponentModel.ActivityCondition); } set { } }
    [SRCategoryAttribute("Handlers")]
    [SRDescriptionAttribute("OnGeneratorChildCompletedDescr")]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    public event System.EventHandler<System.Workflow.Activities.ReplicatorChildEventArgs> ChildCompleted { add { } remove { } }
    [SRCategoryAttribute("Handlers")]
    [SRDescriptionAttribute("OnGeneratorChildInitializedDescr")]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    public event System.EventHandler<System.Workflow.Activities.ReplicatorChildEventArgs> ChildInitialized { add { } remove { } }
    [SRCategoryAttribute("Handlers")]
    [SRDescriptionAttribute("OnCompletedDescr")]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    public event System.EventHandler Completed { add { } remove { } }
    [SRCategoryAttribute("Handlers")]
    [SRDescriptionAttribute("OnInitializedDescr")]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    public event System.EventHandler Initialized { add { } remove { } }
    protected override System.Workflow.ComponentModel.ActivityExecutionStatus Cancel(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    protected override System.Workflow.ComponentModel.ActivityExecutionStatus Execute(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    public bool IsExecuting(int index) { return default(bool); }
    protected override void OnClosed(System.IServiceProvider provider) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class ReplicatorChildEventArgs : System.EventArgs {
    public ReplicatorChildEventArgs(object instanceData, System.Workflow.ComponentModel.Activity activity) { }
    public System.Workflow.ComponentModel.Activity Activity { get { return default(System.Workflow.ComponentModel.Activity); } }
    public object InstanceData { get { return default(object); } }
  }
  [SRCategoryAttribute("Standard")]
  [SRDescriptionAttribute("SequenceActivityDescription")]
  [System.ComponentModel.DesignerAttribute(typeof(System.Workflow.Activities.SequenceDesigner), typeof(System.ComponentModel.Design.IDesigner))]
  [System.ComponentModel.ToolboxItemAttribute(typeof(System.Workflow.ComponentModel.Design.ActivityToolboxItem))]
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Workflow.Activities.SequenceActivity), "Resources.Sequence.png")]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class SequenceActivity : System.Workflow.ComponentModel.CompositeActivity, System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs> {
    public SequenceActivity() { }
    public SequenceActivity(string name) { }
    protected override System.Workflow.ComponentModel.ActivityExecutionStatus Cancel(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    protected override System.Workflow.ComponentModel.ActivityExecutionStatus Execute(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    protected override System.Workflow.ComponentModel.ActivityExecutionStatus HandleFault(System.Workflow.ComponentModel.ActivityExecutionContext executionContext, System.Exception exception) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    protected override void OnActivityChangeRemove(System.Workflow.ComponentModel.ActivityExecutionContext executionContext, System.Workflow.ComponentModel.Activity removedActivity) { }
    protected virtual void OnSequenceComplete(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { }
    protected override void OnWorkflowChangesCompleted(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { }
    void System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs>.OnEvent(object sender, System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs e) { }
  }
  [SRCategoryAttribute("Standard")]
  [SRDisplayNameAttribute("SequentialWorkflow")]
  [System.ComponentModel.DesignerAttribute(typeof(System.Workflow.Activities.SequentialWorkflowDesigner), typeof(System.ComponentModel.Design.IDesigner))]
  [System.ComponentModel.DesignerAttribute(typeof(System.Workflow.Activities.SequentialWorkflowDesigner), typeof(System.ComponentModel.Design.IRootDesigner))]
  [System.ComponentModel.ToolboxItemAttribute(false)]
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Workflow.Activities.SequentialWorkflowActivity), "Resources.SequentialWorkflow.bmp")]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class SequentialWorkflowActivity : System.Workflow.Activities.SequenceActivity {
    public static readonly System.Workflow.ComponentModel.DependencyProperty CompletedEvent;
    public static readonly System.Workflow.ComponentModel.DependencyProperty InitializedEvent;
    public SequentialWorkflowActivity() { }
    public SequentialWorkflowActivity(string name) { }
    [SRCategoryAttribute("Conditions")]
    [SRDescriptionAttribute("DynamicUpdateConditionDescr")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Workflow.ComponentModel.ActivityCondition DynamicUpdateCondition { get { return default(System.Workflow.ComponentModel.ActivityCondition); } set { } }
    [SRCategoryAttribute("Handlers")]
    [SRDescriptionAttribute("OnCompletedDescr")]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    public event System.EventHandler Completed { add { } remove { } }
    [SRCategoryAttribute("Handlers")]
    [SRDescriptionAttribute("OnInitializedDescr")]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    public event System.EventHandler Initialized { add { } remove { } }
    protected override System.Workflow.ComponentModel.ActivityExecutionStatus Execute(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    protected sealed override void OnSequenceComplete(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { }
  }
  [SRCategoryAttribute("Standard")]
  [SRDescriptionAttribute("SetStateActivityDescription")]
  [System.ComponentModel.DesignerAttribute(typeof(System.Workflow.Activities.SetStateDesigner), typeof(System.ComponentModel.Design.IDesigner))]
  [System.ComponentModel.ToolboxItemAttribute(typeof(System.Workflow.ComponentModel.Design.ActivityToolboxItem))]
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Workflow.Activities.SetStateActivity), "Resources.SetStateActivity.png")]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  [System.Workflow.ComponentModel.Compiler.ActivityValidatorAttribute(typeof(System.Workflow.Activities.SetStateValidator))]
  public sealed partial class SetStateActivity : System.Workflow.ComponentModel.Activity {
    public static readonly System.Workflow.ComponentModel.DependencyProperty TargetStateNameProperty;
    public SetStateActivity() { }
    public SetStateActivity(string name) { }
    [SRDescriptionAttribute("TargetStateDescription")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.EditorAttribute(typeof(System.Workflow.Activities.StateDropDownEditor), typeof(System.Drawing.Design.UITypeEditor))]
    public string TargetStateName { get { return default(string); } set { } }
    protected override System.Workflow.ComponentModel.ActivityExecutionStatus Execute(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public partial class SetStateEventArgs : System.EventArgs {
    public SetStateEventArgs(string targetStateName) { }
    public string TargetStateName { get { return default(string); } }
  }
  [SRCategoryAttribute("Standard")]
  [SRDescriptionAttribute("StateActivityDescription")]
  [System.ComponentModel.DesignerAttribute(typeof(System.Workflow.Activities.StateDesigner), typeof(System.ComponentModel.Design.IDesigner))]
  [System.ComponentModel.ToolboxItemAttribute(typeof(System.Workflow.ComponentModel.Design.ActivityToolboxItem))]
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Workflow.Activities.StateActivity), "Resources.StateActivity.png")]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  [System.Workflow.ComponentModel.Compiler.ActivityValidatorAttribute(typeof(System.Workflow.Activities.StateActivityValidator))]
  public partial class StateActivity : System.Workflow.ComponentModel.CompositeActivity {
    public const string StateChangeTrackingDataKey = "StateActivity.StateChange";
    public StateActivity() { }
    public StateActivity(string name) { }
    protected override System.Workflow.ComponentModel.ActivityExecutionStatus Cancel(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    protected override System.Workflow.ComponentModel.ActivityExecutionStatus Execute(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    public System.Workflow.ComponentModel.Activity GetDynamicActivity(string childActivityName) { return default(System.Workflow.ComponentModel.Activity); }
    protected override void Initialize(System.IServiceProvider provider) { }
    protected override void OnActivityChangeAdd(System.Workflow.ComponentModel.ActivityExecutionContext executionContext, System.Workflow.ComponentModel.Activity addedActivity) { }
    protected override void OnClosed(System.IServiceProvider provider) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public partial class StateActivityValidator : System.Workflow.ComponentModel.Compiler.CompositeActivityValidator {
    public StateActivityValidator() { }
    public override System.Workflow.ComponentModel.Compiler.ValidationErrorCollection Validate(System.Workflow.ComponentModel.Compiler.ValidationManager manager, object obj) { return default(System.Workflow.ComponentModel.Compiler.ValidationErrorCollection); }
    public override System.Workflow.ComponentModel.Compiler.ValidationError ValidateActivityChange(System.Workflow.ComponentModel.Activity activity, System.Workflow.ComponentModel.ActivityChangeAction action) { return default(System.Workflow.ComponentModel.Compiler.ValidationError); }
  }
  [SRCategoryAttribute("Standard")]
  [SRDescriptionAttribute("StateFinalizationActivityDescription")]
  [System.ComponentModel.DesignerAttribute(typeof(System.Workflow.Activities.StateFinalizationDesigner), typeof(System.ComponentModel.Design.IDesigner))]
  [System.ComponentModel.ToolboxItemAttribute(typeof(System.Workflow.ComponentModel.Design.ActivityToolboxItem))]
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Workflow.Activities.StateFinalizationActivity), "Resources.StateFinalizationActivity.png")]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  [System.Workflow.ComponentModel.Compiler.ActivityValidatorAttribute(typeof(System.Workflow.Activities.StateFinalizationValidator))]
  public sealed partial class StateFinalizationActivity : System.Workflow.Activities.SequenceActivity {
    public StateFinalizationActivity() { }
    public StateFinalizationActivity(string name) { }
  }
  [SRCategoryAttribute("Standard")]
  [SRDescriptionAttribute("StateInitializationActivityDescription")]
  [System.ComponentModel.DesignerAttribute(typeof(System.Workflow.Activities.StateInitializationDesigner), typeof(System.ComponentModel.Design.IDesigner))]
  [System.ComponentModel.ToolboxItemAttribute(typeof(System.Workflow.ComponentModel.Design.ActivityToolboxItem))]
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Workflow.Activities.StateInitializationActivity), "Resources.StateInitializationActivity.png")]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  [System.Workflow.ComponentModel.Compiler.ActivityValidatorAttribute(typeof(System.Workflow.Activities.StateInitializationValidator))]
  public sealed partial class StateInitializationActivity : System.Workflow.Activities.SequenceActivity {
    public StateInitializationActivity() { }
    public StateInitializationActivity(string name) { }
  }
  [SRCategoryAttribute("Standard")]
  [SRDescriptionAttribute("StateMachineWorkflowActivityDescription")]
  [SRDisplayNameAttribute("StateMachineWorkflow")]
  [System.ComponentModel.DesignerAttribute(typeof(System.Workflow.Activities.StateMachineWorkflowDesigner), typeof(System.ComponentModel.Design.IDesigner))]
  [System.ComponentModel.DesignerAttribute(typeof(System.Workflow.Activities.StateMachineWorkflowDesigner), typeof(System.ComponentModel.Design.IRootDesigner))]
  [System.ComponentModel.ToolboxItemAttribute(false)]
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Workflow.Activities.StateMachineWorkflowActivity), "Resources.StateMachineWorkflowActivity.png")]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  [System.Workflow.ComponentModel.Compiler.ActivityValidatorAttribute(typeof(System.Workflow.Activities.StateActivityValidator))]
  public partial class StateMachineWorkflowActivity : System.Workflow.Activities.StateActivity {
    public static readonly System.Workflow.ComponentModel.DependencyProperty CompletedStateNameProperty;
    public static readonly System.Workflow.ComponentModel.DependencyProperty InitialStateNameProperty;
    public const string SetStateQueueName = "SetStateQueue";
    public StateMachineWorkflowActivity() { }
    public StateMachineWorkflowActivity(string name) { }
    [SRDescriptionAttribute("CompletedStateDescription")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute(typeof(System.Workflow.Activities.StateDropDownEditor), typeof(System.Drawing.Design.UITypeEditor))]
    public string CompletedStateName { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public string CurrentStateName { get { return default(string); } }
    [SRCategoryAttribute("Conditions")]
    [SRDescriptionAttribute("DynamicUpdateConditionDescr")]
    public System.Workflow.ComponentModel.ActivityCondition DynamicUpdateCondition { get { return default(System.Workflow.ComponentModel.ActivityCondition); } set { } }
    [SRDescriptionAttribute("InitialStateDescription")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute(typeof(System.Workflow.Activities.StateDropDownEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.Workflow.ComponentModel.Compiler.ValidationOptionAttribute((System.Workflow.ComponentModel.Compiler.ValidationOption)(1))]
    public string InitialStateName { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public string PreviousStateName { get { return default(string); } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class StateMachineWorkflowInstance {
    public StateMachineWorkflowInstance(System.Workflow.Runtime.WorkflowRuntime runtime, System.Guid instanceId) { }
    public System.Workflow.Activities.StateActivity CurrentState { get { return default(System.Workflow.Activities.StateActivity); } }
    public string CurrentStateName { get { return default(string); } }
    public System.Guid InstanceId { get { return default(System.Guid); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.String> PossibleStateTransitions { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.String>); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.String> StateHistory { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.String>); } }
    public System.Workflow.Activities.StateMachineWorkflowActivity StateMachineWorkflow { get { return default(System.Workflow.Activities.StateMachineWorkflowActivity); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Workflow.Activities.StateActivity> States { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Workflow.Activities.StateActivity>); } }
    public System.Workflow.Runtime.WorkflowInstance WorkflowInstance { get { return default(System.Workflow.Runtime.WorkflowInstance); } }
    public void EnqueueItem(System.IComparable queueName, object item) { }
    public void EnqueueItem(System.IComparable queueName, object item, System.Workflow.Runtime.IPendingWork pendingWork, object workItem) { }
    public void SetState(string targetStateName) { }
    public void SetState(System.Workflow.Activities.StateActivity targetState) { }
  }
  [SRCategoryAttribute("Standard")]
  [SRDescriptionAttribute("WebServiceFaultActivityDescription")]
  [System.ComponentModel.DefaultEventAttribute("SendingFault")]
  [System.ComponentModel.DesignerAttribute(typeof(System.Workflow.Activities.WebServiceFaultDesigner), typeof(System.ComponentModel.Design.IDesigner))]
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Workflow.Activities.WebServiceFaultActivity), "Resources.WebServiceOut.png")]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Workflow.ComponentModel.Compiler.ActivityValidatorAttribute(typeof(System.Workflow.Activities.WebServiceFaultValidator))]
  public sealed partial class WebServiceFaultActivity : System.Workflow.ComponentModel.Activity {
    public static readonly System.Workflow.ComponentModel.DependencyProperty FaultProperty;
    public static readonly System.Workflow.ComponentModel.DependencyProperty InputActivityNameProperty;
    public static readonly System.Workflow.ComponentModel.DependencyProperty SendingFaultEvent;
    public WebServiceFaultActivity() { }
    public WebServiceFaultActivity(string name) { }
    [SRCategoryAttribute("Properties")]
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(1))]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    public System.Exception Fault { get { return default(System.Exception); } set { } }
    [SRCategoryAttribute("Activity")]
    [SRDescriptionAttribute("ReceiveActivityNameDescription")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Workflow.Activities.Common.PropertyValueProviderTypeConverter))]
    public string InputActivityName { get { return default(string); } set { } }
    [SRCategoryAttribute("Handlers")]
    [SRDescriptionAttribute("OnBeforeFaultingDescr")]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    public event System.EventHandler SendingFault { add { } remove { } }
    protected override System.Workflow.ComponentModel.ActivityExecutionStatus Execute(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    protected override void Initialize(System.IServiceProvider provider) { }
  }
  [SRCategoryAttribute("Standard")]
  [SRDescriptionAttribute("WebServiceReceiveActivityDescription")]
  [System.ComponentModel.DefaultEventAttribute("InputReceived")]
  [System.ComponentModel.DesignerAttribute(typeof(System.Workflow.Activities.WebServiceReceiveDesigner), typeof(System.ComponentModel.Design.IDesigner))]
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Workflow.Activities.WebServiceInputActivity), "Resources.WebServiceIn.png")]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Workflow.ComponentModel.Compiler.ActivityCodeGeneratorAttribute(typeof(System.Workflow.Activities.WebServiceCodeGenerator))]
  [System.Workflow.ComponentModel.Compiler.ActivityValidatorAttribute(typeof(System.Workflow.Activities.WebServiceReceiveValidator))]
  public sealed partial class WebServiceInputActivity : System.Workflow.ComponentModel.Activity, System.Workflow.Activities.IEventActivity, System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.QueueEventArgs>, System.Workflow.ComponentModel.IDynamicPropertyTypeProvider {
    public static readonly System.Workflow.ComponentModel.DependencyProperty ActivitySubscribedProperty;
    public static readonly System.Workflow.ComponentModel.DependencyProperty InputReceivedEvent;
    public static readonly System.Workflow.ComponentModel.DependencyProperty InterfaceTypeProperty;
    public static readonly System.Workflow.ComponentModel.DependencyProperty IsActivatingProperty;
    public static readonly System.Workflow.ComponentModel.DependencyProperty MethodNameProperty;
    public static readonly System.Workflow.ComponentModel.DependencyProperty ParameterBindingsProperty;
    public static readonly System.Workflow.ComponentModel.DependencyProperty RolesProperty;
    public WebServiceInputActivity() { }
    public WebServiceInputActivity(string name) { }
    [SRCategoryAttribute("Activity")]
    [SRDescriptionAttribute("InterfaceTypeDescription")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.EditorAttribute(typeof(System.Workflow.ComponentModel.Design.TypeBrowserEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Workflow.ComponentModel.Design.TypeFilterProviderAttribute(typeof(System.Workflow.Activities.InterfaceTypeFilterProvider))]
    public System.Type InterfaceType { get { return default(System.Type); } set { } }
    [SRCategoryAttribute("Activity")]
    [SRDescriptionAttribute("ActivationDescr")]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    public bool IsActivating { get { return default(bool); } set { } }
    [SRCategoryAttribute("Activity")]
    [SRDescriptionAttribute("WebServiceMethodDescription")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Workflow.Activities.Common.PropertyValueProviderTypeConverter))]
    public string MethodName { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    public System.Workflow.ComponentModel.WorkflowParameterBindingCollection ParameterBindings { get { return default(System.Workflow.ComponentModel.WorkflowParameterBindingCollection); } }
    [SRCategoryAttribute("Activity")]
    [SRDescriptionAttribute("RoleDescr")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.EditorAttribute(typeof(System.Workflow.ComponentModel.Design.BindUITypeEditor), typeof(System.Drawing.Design.UITypeEditor))]
    public System.Workflow.Activities.WorkflowRoleCollection Roles { get { return default(System.Workflow.Activities.WorkflowRoleCollection); } set { } }
    System.IComparable System.Workflow.Activities.IEventActivity.QueueName { get { return default(System.IComparable); } }
    [SRCategoryAttribute("Handlers")]
    [SRDescriptionAttribute("OnAfterReceiveDescr")]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    public event System.EventHandler InputReceived { add { } remove { } }
    protected sealed override System.Workflow.ComponentModel.ActivityExecutionStatus Cancel(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    protected sealed override System.Workflow.ComponentModel.ActivityExecutionStatus Execute(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    protected sealed override System.Workflow.ComponentModel.ActivityExecutionStatus HandleFault(System.Workflow.ComponentModel.ActivityExecutionContext executionContext, System.Exception exception) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    protected sealed override void Initialize(System.IServiceProvider provider) { }
    void System.Workflow.Activities.IEventActivity.Subscribe(System.Workflow.ComponentModel.ActivityExecutionContext parentContext, System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.QueueEventArgs> parentEventHandler) { }
    void System.Workflow.Activities.IEventActivity.Unsubscribe(System.Workflow.ComponentModel.ActivityExecutionContext parentContext, System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.QueueEventArgs> parentEventHandler) { }
    void System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.QueueEventArgs>.OnEvent(object sender, System.Workflow.ComponentModel.QueueEventArgs e) { }
    System.Workflow.ComponentModel.Compiler.AccessTypes System.Workflow.ComponentModel.IDynamicPropertyTypeProvider.GetAccessType(System.IServiceProvider serviceProvider, string propertyName) { return default(System.Workflow.ComponentModel.Compiler.AccessTypes); }
    System.Type System.Workflow.ComponentModel.IDynamicPropertyTypeProvider.GetPropertyType(System.IServiceProvider serviceProvider, string propertyName) { return default(System.Type); }
  }
  [SRCategoryAttribute("Standard")]
  [SRDescriptionAttribute("WebServiceResponseActivityDescription")]
  [System.ComponentModel.DefaultEventAttribute("SendingOutput")]
  [System.ComponentModel.DesignerAttribute(typeof(System.Workflow.Activities.WebServiceResponseDesigner), typeof(System.ComponentModel.Design.IDesigner))]
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Workflow.Activities.WebServiceOutputActivity), "Resources.WebServiceOut.png")]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Workflow.ComponentModel.Compiler.ActivityValidatorAttribute(typeof(System.Workflow.Activities.WebServiceResponseValidator))]
  public sealed partial class WebServiceOutputActivity : System.Workflow.ComponentModel.Activity, System.Workflow.ComponentModel.IDynamicPropertyTypeProvider {
    public static readonly System.Workflow.ComponentModel.DependencyProperty InputActivityNameProperty;
    public static readonly System.Workflow.ComponentModel.DependencyProperty ParameterBindingsProperty;
    public static readonly System.Workflow.ComponentModel.DependencyProperty SendingOutputEvent;
    public WebServiceOutputActivity() { }
    public WebServiceOutputActivity(string name) { }
    [SRCategoryAttribute("Activity")]
    [SRDescriptionAttribute("ReceiveActivityNameDescription")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Workflow.Activities.Common.PropertyValueProviderTypeConverter))]
    public string InputActivityName { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    public System.Workflow.ComponentModel.WorkflowParameterBindingCollection ParameterBindings { get { return default(System.Workflow.ComponentModel.WorkflowParameterBindingCollection); } }
    [SRCategoryAttribute("Handlers")]
    [SRDescriptionAttribute("OnBeforeResponseDescr")]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    public event System.EventHandler SendingOutput { add { } remove { } }
    protected override System.Workflow.ComponentModel.ActivityExecutionStatus Execute(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    protected override void Initialize(System.IServiceProvider provider) { }
    System.Workflow.ComponentModel.Compiler.AccessTypes System.Workflow.ComponentModel.IDynamicPropertyTypeProvider.GetAccessType(System.IServiceProvider serviceProvider, string propertyName) { return default(System.Workflow.ComponentModel.Compiler.AccessTypes); }
    System.Type System.Workflow.ComponentModel.IDynamicPropertyTypeProvider.GetPropertyType(System.IServiceProvider serviceProvider, string propertyName) { return default(System.Type); }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class WebWorkflowRole : System.Workflow.Activities.WorkflowRole {
    public WebWorkflowRole(string roleName) { }
    public WebWorkflowRole(string roleName, string provider) { }
    public override string Name { get { return default(string); } set { } }
    public string RoleProvider { get { return default(string); } set { } }
    public override System.Collections.Generic.IList<System.String> GetIdentities() { return default(System.Collections.Generic.IList<System.String>); }
    public override bool IncludesIdentity(string identity) { return default(bool); }
  }
  [SRDescriptionAttribute("WhileActivityDescription")]
  [System.ComponentModel.DesignerAttribute(typeof(System.Workflow.Activities.WhileDesigner), typeof(System.ComponentModel.Design.IDesigner))]
  [System.ComponentModel.ToolboxItemAttribute(typeof(System.Workflow.ComponentModel.Design.ActivityToolboxItem))]
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Workflow.Activities.WhileActivity), "Resources.While.png")]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Workflow.ComponentModel.Compiler.ActivityValidatorAttribute(typeof(System.Workflow.Activities.WhileValidator))]
  public sealed partial class WhileActivity : System.Workflow.ComponentModel.CompositeActivity, System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs> {
    public static readonly System.Workflow.ComponentModel.DependencyProperty ConditionProperty;
    public WhileActivity() { }
    public WhileActivity(string name) { }
    [SRCategoryAttribute("Conditions")]
    [SRDescriptionAttribute("WhileConditionDescr")]
    public System.Workflow.ComponentModel.ActivityCondition Condition { get { return default(System.Workflow.ComponentModel.ActivityCondition); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Workflow.ComponentModel.Activity DynamicActivity { get { return default(System.Workflow.ComponentModel.Activity); } }
    protected override System.Workflow.ComponentModel.ActivityExecutionStatus Cancel(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    protected override System.Workflow.ComponentModel.ActivityExecutionStatus Execute(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    void System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs>.OnEvent(object sender, System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs e) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class WorkflowAuthorizationException : System.SystemException {
    public WorkflowAuthorizationException() { }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, SerializationFormatter=true)]
    protected WorkflowAuthorizationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public WorkflowAuthorizationException(string message) { }
    public WorkflowAuthorizationException(string message, System.Exception innerException) { }
    public WorkflowAuthorizationException(string activityName, string principalName) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public abstract partial class WorkflowRole {
    protected WorkflowRole() { }
    public abstract string Name { get; set; }
    public abstract System.Collections.Generic.IList<System.String> GetIdentities();
    public abstract bool IncludesIdentity(string identity);
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class WorkflowRoleCollection : System.Collections.Generic.List<System.Workflow.Activities.WorkflowRole> {
    public WorkflowRoleCollection() { }
    public bool IncludesIdentity(string identity) { return default(bool); }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public abstract partial class WorkflowSubscriptionService {
    protected WorkflowSubscriptionService() { }
    public abstract void CreateSubscription(System.Workflow.Activities.MessageEventSubscription subscription);
    public abstract void DeleteSubscription(System.Guid subscriptionId);
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public abstract partial class WorkflowWebService : System.Web.Services.WebService {
    protected WorkflowWebService(System.Type workflowType) { }
    protected System.Workflow.Runtime.WorkflowRuntime WorkflowRuntime { get { return default(System.Workflow.Runtime.WorkflowRuntime); } }
    protected System.Object[] Invoke(System.Type interfaceType, string methodName, bool isActivation, System.Object[] parameters) { return default(System.Object[]); }
  }
}
namespace System.Workflow.Activities.Configuration {
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class ActiveDirectoryRoleFactoryConfiguration : System.Configuration.ConfigurationSection {
    public ActiveDirectoryRoleFactoryConfiguration() { }
    [System.Configuration.ConfigurationPropertyAttribute("DirectReports", DefaultValue="directReports")]
    public string DirectReports { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("DistiguishedName", DefaultValue="distinguishedName")]
    public string DistinguishedName { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("Group", DefaultValue="group")]
    public string Group { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("Manager", DefaultValue="manager")]
    public string Manager { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("Member", DefaultValue="member")]
    public string Member { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("RootPath", DefaultValue="")]
    public string RootPath { get { return default(string); } set { } }
  }
}
namespace System.Workflow.Activities.Rules {
  public sealed partial class AddedConditionAction : System.Workflow.Activities.Rules.RuleConditionChangeAction {
    public AddedConditionAction() { }
    public AddedConditionAction(System.Workflow.Activities.Rules.RuleCondition addedConditionDefinition) { }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    public System.Workflow.Activities.Rules.RuleCondition ConditionDefinition { get { return default(System.Workflow.Activities.Rules.RuleCondition); } set { } }
    public override string ConditionName { get { return default(string); } }
    protected override bool ApplyTo(System.Workflow.ComponentModel.Activity rootActivity) { return default(bool); }
  }
  public sealed partial class AddedRuleSetAction : System.Workflow.Activities.Rules.RuleSetChangeAction {
    public AddedRuleSetAction() { }
    public AddedRuleSetAction(System.Workflow.Activities.Rules.RuleSet addedRuleSetDefinition) { }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    public System.Workflow.Activities.Rules.RuleSet RuleSetDefinition { get { return default(System.Workflow.Activities.Rules.RuleSet); } set { } }
    public override string RuleSetName { get { return default(string); } }
    protected override bool ApplyTo(System.Workflow.ComponentModel.Activity rootActivity) { return default(bool); }
  }
  public partial interface IRuleExpression {
    void AnalyzeUsage(System.Workflow.Activities.Rules.RuleAnalysis analysis, bool isRead, bool isWritten, System.Workflow.Activities.Rules.RulePathQualifier qualifier);
    System.CodeDom.CodeExpression Clone();
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Naming", "CA1720:AvoidTypeNamesInParameters", MessageId="0#")]
    void Decompile(System.Text.StringBuilder stringBuilder, System.CodeDom.CodeExpression parentExpression);
    System.Workflow.Activities.Rules.RuleExpressionResult Evaluate(System.Workflow.Activities.Rules.RuleExecution execution);
    bool Match(System.CodeDom.CodeExpression expression);
    System.Workflow.Activities.Rules.RuleExpressionInfo Validate(System.Workflow.Activities.Rules.RuleValidation validation, bool isWritten);
  }
  public sealed partial class RemovedConditionAction : System.Workflow.Activities.Rules.RuleConditionChangeAction {
    public RemovedConditionAction() { }
    public RemovedConditionAction(System.Workflow.Activities.Rules.RuleCondition removedConditionDefinition) { }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    public System.Workflow.Activities.Rules.RuleCondition ConditionDefinition { get { return default(System.Workflow.Activities.Rules.RuleCondition); } set { } }
    public override string ConditionName { get { return default(string); } }
    protected override bool ApplyTo(System.Workflow.ComponentModel.Activity rootActivity) { return default(bool); }
  }
  public sealed partial class RemovedRuleSetAction : System.Workflow.Activities.Rules.RuleSetChangeAction {
    public RemovedRuleSetAction() { }
    public RemovedRuleSetAction(System.Workflow.Activities.Rules.RuleSet removedRuleSetDefinition) { }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    public System.Workflow.Activities.Rules.RuleSet RuleSetDefinition { get { return default(System.Workflow.Activities.Rules.RuleSet); } set { } }
    public override string RuleSetName { get { return default(string); } }
    protected override bool ApplyTo(System.Workflow.ComponentModel.Activity rootActivity) { return default(bool); }
  }
  public partial class Rule {
    public Rule() { }
    public Rule(string name) { }
    public Rule(string name, System.Workflow.Activities.Rules.RuleCondition condition, System.Collections.Generic.IList<System.Workflow.Activities.Rules.RuleAction> thenActions) { }
    public Rule(string name, System.Workflow.Activities.Rules.RuleCondition condition, System.Collections.Generic.IList<System.Workflow.Activities.Rules.RuleAction> thenActions, System.Collections.Generic.IList<System.Workflow.Activities.Rules.RuleAction> elseActions) { }
    public bool Active { get { return default(bool); } set { } }
    public System.Workflow.Activities.Rules.RuleCondition Condition { get { return default(System.Workflow.Activities.Rules.RuleCondition); } set { } }
    public string Description { get { return default(string); } set { } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    public System.Collections.Generic.IList<System.Workflow.Activities.Rules.RuleAction> ElseActions { get { return default(System.Collections.Generic.IList<System.Workflow.Activities.Rules.RuleAction>); } }
    public string Name { get { return default(string); } set { } }
    public int Priority { get { return default(int); } set { } }
    public System.Workflow.Activities.Rules.RuleReevaluationBehavior ReevaluationBehavior { get { return default(System.Workflow.Activities.Rules.RuleReevaluationBehavior); } set { } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    public System.Collections.Generic.IList<System.Workflow.Activities.Rules.RuleAction> ThenActions { get { return default(System.Collections.Generic.IList<System.Workflow.Activities.Rules.RuleAction>); } }
    public System.Workflow.Activities.Rules.Rule Clone() { return default(System.Workflow.Activities.Rules.Rule); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }
  public abstract partial class RuleAction {
    protected RuleAction() { }
    public abstract System.Workflow.Activities.Rules.RuleAction Clone();
    public abstract void Execute(System.Workflow.Activities.Rules.RuleExecution context);
    public abstract System.Collections.Generic.ICollection<System.String> GetSideEffects(System.Workflow.Activities.Rules.RuleValidation validation);
    public abstract bool Validate(System.Workflow.Activities.Rules.RuleValidation validator);
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class RuleActionTrackingEvent {
    internal RuleActionTrackingEvent() { }
    public bool ConditionResult { get { return default(bool); } }
    public string RuleName { get { return default(string); } }
  }
  public partial class RuleAnalysis {
    public RuleAnalysis(System.Workflow.Activities.Rules.RuleValidation validation, bool forWrites) { }
    public bool ForWrites { get { return default(bool); } }
    public void AddSymbol(string symbol) { }
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
    public System.Collections.Generic.ICollection<System.String> GetSymbols() { return default(System.Collections.Generic.ICollection<System.String>); }
  }
  public abstract partial class RuleAttribute : System.Attribute {
    protected RuleAttribute() { }
  }
  public enum RuleAttributeTarget {
    Parameter = 0,
    This = 1,
  }
  public enum RuleChainingBehavior {
    Full = 2,
    None = 0,
    UpdateOnly = 1,
  }
  public abstract partial class RuleCondition {
    protected RuleCondition() { }
    public abstract string Name { get; set; }
    public abstract System.Workflow.Activities.Rules.RuleCondition Clone();
    public abstract bool Evaluate(System.Workflow.Activities.Rules.RuleExecution execution);
    public abstract System.Collections.Generic.ICollection<System.String> GetDependencies(System.Workflow.Activities.Rules.RuleValidation validation);
    public virtual void OnRuntimeInitialized() { }
    public abstract bool Validate(System.Workflow.Activities.Rules.RuleValidation validation);
  }
  [System.ComponentModel.Design.Serialization.DesignerSerializerAttribute(typeof(System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializer), typeof(System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializer))]
  public abstract partial class RuleConditionChangeAction : System.Workflow.ComponentModel.WorkflowChangeAction {
    protected RuleConditionChangeAction() { }
    public abstract string ConditionName { get; }
    protected override System.Workflow.ComponentModel.Compiler.ValidationErrorCollection ValidateChanges(System.Workflow.ComponentModel.Activity activity) { return default(System.Workflow.ComponentModel.Compiler.ValidationErrorCollection); }
  }
  public sealed partial class RuleConditionCollection : System.Collections.ObjectModel.KeyedCollection<System.String, System.Workflow.Activities.Rules.RuleCondition>, System.Workflow.ComponentModel.IWorkflowChangeDiff {
    public RuleConditionCollection() { }
    public new void Add(System.Workflow.Activities.Rules.RuleCondition item) { }
    public System.Collections.Generic.IList<System.Workflow.ComponentModel.WorkflowChangeAction> Diff(object originalDefinition, object changedDefinition) { return default(System.Collections.Generic.IList<System.Workflow.ComponentModel.WorkflowChangeAction>); }
    protected override string GetKeyForItem(System.Workflow.Activities.Rules.RuleCondition item) { return default(string); }
    protected override void InsertItem(int index, System.Workflow.Activities.Rules.RuleCondition item) { }
    protected override void RemoveItem(int index) { }
    protected override void SetItem(int index, System.Workflow.Activities.Rules.RuleCondition item) { }
  }
  [SRDisplayNameAttribute("RuleConditionDisplayName")]
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Workflow.Activities.Rules.Design.RuleConditionReferenceTypeConverter))]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Workflow.ComponentModel.Compiler.ActivityValidatorAttribute(typeof(System.Workflow.Activities.Rules.RuleConditionReferenceValidator))]
  public partial class RuleConditionReference : System.Workflow.ComponentModel.ActivityCondition {
    public RuleConditionReference() { }
    public string ConditionName { get { return default(string); } set { } }
    public override bool Evaluate(System.Workflow.ComponentModel.Activity activity, System.IServiceProvider provider) { return default(bool); }
    protected override void InitializeProperties() { }
  }
  public sealed partial class RuleDefinitions : System.Workflow.ComponentModel.IWorkflowChangeDiff {
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
    public static readonly System.Workflow.ComponentModel.DependencyProperty RuleDefinitionsProperty;
    public RuleDefinitions() { }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    public System.Workflow.Activities.Rules.RuleConditionCollection Conditions { get { return default(System.Workflow.Activities.Rules.RuleConditionCollection); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    public System.Workflow.Activities.Rules.RuleSetCollection RuleSets { get { return default(System.Workflow.Activities.Rules.RuleSetCollection); } }
    public System.Collections.Generic.IList<System.Workflow.ComponentModel.WorkflowChangeAction> Diff(object originalDefinition, object changedDefinition) { return default(System.Collections.Generic.IList<System.Workflow.ComponentModel.WorkflowChangeAction>); }
  }
  public partial class RuleEngine {
    public RuleEngine(System.Workflow.Activities.Rules.RuleSet ruleSet, System.Type objectType) { }
    public RuleEngine(System.Workflow.Activities.Rules.RuleSet ruleSet, System.Workflow.Activities.Rules.RuleValidation validation) { }
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Naming", "CA1720:AvoidTypeNamesInParameters", MessageId="0#")]
    public void Execute(object thisObject) { }
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Naming", "CA1720:AvoidTypeNamesInParameters", MessageId="0#")]
    public void Execute(object thisObject, System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { }
  }
  public partial class RuleEvaluationException : System.Workflow.Activities.Rules.RuleException, System.Runtime.Serialization.ISerializable {
    public RuleEvaluationException() { }
    protected RuleEvaluationException(System.Runtime.Serialization.SerializationInfo serializeInfo, System.Runtime.Serialization.StreamingContext context) { }
    public RuleEvaluationException(string message) { }
    public RuleEvaluationException(string message, System.Exception ex) { }
  }
  public partial class RuleEvaluationIncompatibleTypesException : System.Workflow.Activities.Rules.RuleException, System.Runtime.Serialization.ISerializable {
    public RuleEvaluationIncompatibleTypesException() { }
    protected RuleEvaluationIncompatibleTypesException(System.Runtime.Serialization.SerializationInfo serializeInfo, System.Runtime.Serialization.StreamingContext context) { }
    public RuleEvaluationIncompatibleTypesException(string message) { }
    public RuleEvaluationIncompatibleTypesException(string message, System.Exception ex) { }
    public RuleEvaluationIncompatibleTypesException(string message, System.Type left, System.CodeDom.CodeBinaryOperatorType op, System.Type right) { }
    public RuleEvaluationIncompatibleTypesException(string message, System.Type left, System.CodeDom.CodeBinaryOperatorType op, System.Type right, System.Exception ex) { }
    public System.Type Left { get { return default(System.Type); } set { } }
    public System.CodeDom.CodeBinaryOperatorType Operator { get { return default(System.CodeDom.CodeBinaryOperatorType); } set { } }
    public System.Type Right { get { return default(System.Type); } set { } }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, SerializationFormatter=true)]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial class RuleException : System.Exception, System.Runtime.Serialization.ISerializable {
    public RuleException() { }
    protected RuleException(System.Runtime.Serialization.SerializationInfo serializeInfo, System.Runtime.Serialization.StreamingContext context) { }
    public RuleException(string message) { }
    public RuleException(string message, System.Exception ex) { }
  }
  public partial class RuleExecution {
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Naming", "CA1720:AvoidTypeNamesInParameters", MessageId="1#")]
    public RuleExecution(System.Workflow.Activities.Rules.RuleValidation validation, object thisObject) { }
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Naming", "CA1720:AvoidTypeNamesInParameters", MessageId="1#")]
    public RuleExecution(System.Workflow.Activities.Rules.RuleValidation validation, object thisObject, System.Workflow.ComponentModel.ActivityExecutionContext activityExecutionContext) { }
    public System.Workflow.ComponentModel.Activity Activity { get { return default(System.Workflow.ComponentModel.Activity); } }
    public System.Workflow.ComponentModel.ActivityExecutionContext ActivityExecutionContext { get { return default(System.Workflow.ComponentModel.ActivityExecutionContext); } }
    public bool Halted { get { return default(bool); } set { } }
    public object ThisObject { get { return default(object); } }
    public System.Workflow.Activities.Rules.RuleValidation Validation { get { return default(System.Workflow.Activities.Rules.RuleValidation); } set { } }
  }
  public sealed partial class RuleExpressionCondition : System.Workflow.Activities.Rules.RuleCondition {
    public RuleExpressionCondition() { }
    public RuleExpressionCondition(System.CodeDom.CodeExpression expression) { }
    public RuleExpressionCondition(string conditionName) { }
    public RuleExpressionCondition(string conditionName, System.CodeDom.CodeExpression expression) { }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    public System.CodeDom.CodeExpression Expression { get { return default(System.CodeDom.CodeExpression); } set { } }
    public override string Name { get { return default(string); } set { } }
    public override System.Workflow.Activities.Rules.RuleCondition Clone() { return default(System.Workflow.Activities.Rules.RuleCondition); }
    public override bool Equals(object obj) { return default(bool); }
    public override bool Evaluate(System.Workflow.Activities.Rules.RuleExecution execution) { return default(bool); }
    public override System.Collections.Generic.ICollection<System.String> GetDependencies(System.Workflow.Activities.Rules.RuleValidation validation) { return default(System.Collections.Generic.ICollection<System.String>); }
    public override int GetHashCode() { return default(int); }
    public override void OnRuntimeInitialized() { }
    public override string ToString() { return default(string); }
    public override bool Validate(System.Workflow.Activities.Rules.RuleValidation validation) { return default(bool); }
  }
  public partial class RuleExpressionInfo {
    public RuleExpressionInfo(System.Type expressionType) { }
    public System.Type ExpressionType { get { return default(System.Type); } }
  }
  public abstract partial class RuleExpressionResult {
    protected RuleExpressionResult() { }
    public abstract object Value { get; set; }
  }
  public static partial class RuleExpressionWalker {
    public static void AnalyzeUsage(System.Workflow.Activities.Rules.RuleAnalysis analysis, System.CodeDom.CodeExpression expression, bool isRead, bool isWritten, System.Workflow.Activities.Rules.RulePathQualifier qualifier) { }
    public static System.CodeDom.CodeExpression Clone(System.CodeDom.CodeExpression originalExpression) { return default(System.CodeDom.CodeExpression); }
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Naming", "CA1720:AvoidTypeNamesInParameters", MessageId="0#")]
    public static void Decompile(System.Text.StringBuilder stringBuilder, System.CodeDom.CodeExpression expression, System.CodeDom.CodeExpression parentExpression) { }
    public static System.Workflow.Activities.Rules.RuleExpressionResult Evaluate(System.Workflow.Activities.Rules.RuleExecution execution, System.CodeDom.CodeExpression expression) { return default(System.Workflow.Activities.Rules.RuleExpressionResult); }
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1062:ValidateArgumentsOfPublicMethods")]
    public static bool Match(System.CodeDom.CodeExpression firstExpression, System.CodeDom.CodeExpression secondExpression) { return default(bool); }
    public static System.Workflow.Activities.Rules.RuleExpressionInfo Validate(System.Workflow.Activities.Rules.RuleValidation validation, System.CodeDom.CodeExpression expression, bool isWritten) { return default(System.Workflow.Activities.Rules.RuleExpressionInfo); }
  }
  public partial class RuleHaltAction : System.Workflow.Activities.Rules.RuleAction {
    public RuleHaltAction() { }
    public override System.Workflow.Activities.Rules.RuleAction Clone() { return default(System.Workflow.Activities.Rules.RuleAction); }
    public override bool Equals(object obj) { return default(bool); }
    public override void Execute(System.Workflow.Activities.Rules.RuleExecution context) { }
    public override int GetHashCode() { return default(int); }
    public override System.Collections.Generic.ICollection<System.String> GetSideEffects(System.Workflow.Activities.Rules.RuleValidation validation) { return default(System.Collections.Generic.ICollection<System.String>); }
    public override string ToString() { return default(string); }
    public override bool Validate(System.Workflow.Activities.Rules.RuleValidation validator) { return default(bool); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(192), AllowMultiple=true)]
  public sealed partial class RuleInvokeAttribute : System.Workflow.Activities.Rules.RuleAttribute {
    public RuleInvokeAttribute(string methodInvoked) { }
    public string MethodInvoked { get { return default(string); } }
  }
  public partial class RuleLiteralResult : System.Workflow.Activities.Rules.RuleExpressionResult {
    public RuleLiteralResult(object literal) { }
    public override object Value { get { return default(object); } set { } }
  }
  public partial class RulePathQualifier {
    public RulePathQualifier(string name, System.Workflow.Activities.Rules.RulePathQualifier next) { }
    public string Name { get { return default(string); } }
    public System.Workflow.Activities.Rules.RulePathQualifier Next { get { return default(System.Workflow.Activities.Rules.RulePathQualifier); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(192), AllowMultiple=true)]
  public sealed partial class RuleReadAttribute : System.Workflow.Activities.Rules.RuleReadWriteAttribute {
    public RuleReadAttribute(string path) : base (default(string), default(System.Workflow.Activities.Rules.RuleAttributeTarget)) { }
    public RuleReadAttribute(string path, System.Workflow.Activities.Rules.RuleAttributeTarget target) : base (default(string), default(System.Workflow.Activities.Rules.RuleAttributeTarget)) { }
  }
  public abstract partial class RuleReadWriteAttribute : System.Workflow.Activities.Rules.RuleAttribute {
    protected RuleReadWriteAttribute(string path, System.Workflow.Activities.Rules.RuleAttributeTarget target) { }
    public string Path { get { return default(string); } }
    public System.Workflow.Activities.Rules.RuleAttributeTarget Target { get { return default(System.Workflow.Activities.Rules.RuleAttributeTarget); } }
  }
  public enum RuleReevaluationBehavior {
    Always = 1,
    Never = 0,
  }
  public partial class RuleSet {
    public RuleSet() { }
    public RuleSet(string name) { }
    public RuleSet(string name, string description) { }
    public System.Workflow.Activities.Rules.RuleChainingBehavior ChainingBehavior { get { return default(System.Workflow.Activities.Rules.RuleChainingBehavior); } set { } }
    public string Description { get { return default(string); } set { } }
    public string Name { get { return default(string); } set { } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    public System.Collections.Generic.ICollection<System.Workflow.Activities.Rules.Rule> Rules { get { return default(System.Collections.Generic.ICollection<System.Workflow.Activities.Rules.Rule>); } }
    public System.Workflow.Activities.Rules.RuleSet Clone() { return default(System.Workflow.Activities.Rules.RuleSet); }
    public override bool Equals(object obj) { return default(bool); }
    public void Execute(System.Workflow.Activities.Rules.RuleExecution ruleExecution) { }
    public override int GetHashCode() { return default(int); }
    public bool Validate(System.Workflow.Activities.Rules.RuleValidation validation) { return default(bool); }
  }
  [System.ComponentModel.Design.Serialization.DesignerSerializerAttribute(typeof(System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializer), typeof(System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializer))]
  public abstract partial class RuleSetChangeAction : System.Workflow.ComponentModel.WorkflowChangeAction {
    protected RuleSetChangeAction() { }
    public abstract string RuleSetName { get; }
    protected override System.Workflow.ComponentModel.Compiler.ValidationErrorCollection ValidateChanges(System.Workflow.ComponentModel.Activity activity) { return default(System.Workflow.ComponentModel.Compiler.ValidationErrorCollection); }
  }
  public sealed partial class RuleSetCollection : System.Collections.ObjectModel.KeyedCollection<System.String, System.Workflow.Activities.Rules.RuleSet>, System.Workflow.ComponentModel.IWorkflowChangeDiff {
    public RuleSetCollection() { }
    public new void Add(System.Workflow.Activities.Rules.RuleSet item) { }
    public System.Collections.Generic.IList<System.Workflow.ComponentModel.WorkflowChangeAction> Diff(object originalDefinition, object changedDefinition) { return default(System.Collections.Generic.IList<System.Workflow.ComponentModel.WorkflowChangeAction>); }
    protected override string GetKeyForItem(System.Workflow.Activities.Rules.RuleSet item) { return default(string); }
    protected override void InsertItem(int index, System.Workflow.Activities.Rules.RuleSet item) { }
    protected override void RemoveItem(int index) { }
    protected override void SetItem(int index, System.Workflow.Activities.Rules.RuleSet item) { }
  }
  [System.ComponentModel.BrowsableAttribute(true)]
  [System.ComponentModel.Design.Serialization.DesignerSerializerAttribute(typeof(System.Workflow.ComponentModel.Serialization.DependencyObjectCodeDomSerializer), typeof(System.ComponentModel.Design.Serialization.CodeDomSerializer))]
  [System.ComponentModel.Design.Serialization.DesignerSerializerAttribute(typeof(System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializer), typeof(System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializer))]
  [System.ComponentModel.EditorAttribute(typeof(System.Workflow.Activities.Rules.Design.RuleSetNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Workflow.Activities.Rules.Design.RuleSetReferenceTypeConverter))]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Workflow.ComponentModel.Compiler.ActivityValidatorAttribute(typeof(System.Workflow.Activities.Rules.RuleSetReferenceValidator))]
  public sealed partial class RuleSetReference : System.Workflow.ComponentModel.DependencyObject {
    public RuleSetReference() { }
    public RuleSetReference(string ruleSetName) { }
    public string RuleSetName { get { return default(string); } set { } }
    protected override void InitializeProperties() { }
  }
  public partial class RuleSetValidationException : System.Workflow.Activities.Rules.RuleException, System.Runtime.Serialization.ISerializable {
    public RuleSetValidationException() { }
    protected RuleSetValidationException(System.Runtime.Serialization.SerializationInfo serializeInfo, System.Runtime.Serialization.StreamingContext context) { }
    public RuleSetValidationException(string message) { }
    public RuleSetValidationException(string message, System.Exception ex) { }
    public RuleSetValidationException(string message, System.Workflow.ComponentModel.Compiler.ValidationErrorCollection errors) { }
    public System.Workflow.ComponentModel.Compiler.ValidationErrorCollection Errors { get { return default(System.Workflow.ComponentModel.Compiler.ValidationErrorCollection); } }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, SerializationFormatter=true)]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial class RuleStatementAction : System.Workflow.Activities.Rules.RuleAction {
    public RuleStatementAction() { }
    public RuleStatementAction(System.CodeDom.CodeExpression codeDomExpression) { }
    public RuleStatementAction(System.CodeDom.CodeStatement codeDomStatement) { }
    public System.CodeDom.CodeStatement CodeDomStatement { get { return default(System.CodeDom.CodeStatement); } set { } }
    public override System.Workflow.Activities.Rules.RuleAction Clone() { return default(System.Workflow.Activities.Rules.RuleAction); }
    public override bool Equals(object obj) { return default(bool); }
    public override void Execute(System.Workflow.Activities.Rules.RuleExecution context) { }
    public override int GetHashCode() { return default(int); }
    public override System.Collections.Generic.ICollection<System.String> GetSideEffects(System.Workflow.Activities.Rules.RuleValidation validation) { return default(System.Collections.Generic.ICollection<System.String>); }
    public override string ToString() { return default(string); }
    public override bool Validate(System.Workflow.Activities.Rules.RuleValidation validator) { return default(bool); }
  }
  public partial class RuleUpdateAction : System.Workflow.Activities.Rules.RuleAction {
    public RuleUpdateAction() { }
    public RuleUpdateAction(string path) { }
    public string Path { get { return default(string); } set { } }
    public override System.Workflow.Activities.Rules.RuleAction Clone() { return default(System.Workflow.Activities.Rules.RuleAction); }
    public override bool Equals(object obj) { return default(bool); }
    public override void Execute(System.Workflow.Activities.Rules.RuleExecution context) { }
    public override int GetHashCode() { return default(int); }
    public override System.Collections.Generic.ICollection<System.String> GetSideEffects(System.Workflow.Activities.Rules.RuleValidation validation) { return default(System.Collections.Generic.ICollection<System.String>); }
    public override string ToString() { return default(string); }
    public override bool Validate(System.Workflow.Activities.Rules.RuleValidation validator) { return default(bool); }
  }
  public partial class RuleValidation {
    public RuleValidation(System.Type thisType, System.Workflow.ComponentModel.Compiler.ITypeProvider typeProvider) { }
    public RuleValidation(System.Workflow.ComponentModel.Activity activity, System.Workflow.ComponentModel.Compiler.ITypeProvider typeProvider, bool checkStaticType) { }
    public System.Workflow.ComponentModel.Compiler.ValidationErrorCollection Errors { get { return default(System.Workflow.ComponentModel.Compiler.ValidationErrorCollection); } }
    public System.Type ThisType { get { return default(System.Type); } }
    public System.Workflow.Activities.Rules.RuleExpressionInfo ExpressionInfo(System.CodeDom.CodeExpression expression) { return default(System.Workflow.Activities.Rules.RuleExpressionInfo); }
    public void PopParentExpression() { }
    public bool PushParentExpression(System.CodeDom.CodeExpression newParent) { return default(bool); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(192), AllowMultiple=true)]
  public sealed partial class RuleWriteAttribute : System.Workflow.Activities.Rules.RuleReadWriteAttribute {
    public RuleWriteAttribute(string path) : base (default(string), default(System.Workflow.Activities.Rules.RuleAttributeTarget)) { }
    public RuleWriteAttribute(string path, System.Workflow.Activities.Rules.RuleAttributeTarget target) : base (default(string), default(System.Workflow.Activities.Rules.RuleAttributeTarget)) { }
  }
  public sealed partial class UpdatedConditionAction : System.Workflow.Activities.Rules.RuleConditionChangeAction {
    public UpdatedConditionAction() { }
    public UpdatedConditionAction(System.Workflow.Activities.Rules.RuleCondition conditionDefinition, System.Workflow.Activities.Rules.RuleCondition newConditionDefinition) { }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    public System.Workflow.Activities.Rules.RuleCondition ConditionDefinition { get { return default(System.Workflow.Activities.Rules.RuleCondition); } set { } }
    public override string ConditionName { get { return default(string); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    public System.Workflow.Activities.Rules.RuleCondition NewConditionDefinition { get { return default(System.Workflow.Activities.Rules.RuleCondition); } set { } }
    protected override bool ApplyTo(System.Workflow.ComponentModel.Activity rootActivity) { return default(bool); }
  }
  public sealed partial class UpdatedRuleSetAction : System.Workflow.Activities.Rules.RuleSetChangeAction {
    public UpdatedRuleSetAction() { }
    public UpdatedRuleSetAction(System.Workflow.Activities.Rules.RuleSet originalRuleSetDefinition, System.Workflow.Activities.Rules.RuleSet updatedRuleSetDefinition) { }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    public System.Workflow.Activities.Rules.RuleSet OriginalRuleSetDefinition { get { return default(System.Workflow.Activities.Rules.RuleSet); } set { } }
    public override string RuleSetName { get { return default(string); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    public System.Workflow.Activities.Rules.RuleSet UpdatedRuleSetDefinition { get { return default(System.Workflow.Activities.Rules.RuleSet); } set { } }
    protected override bool ApplyTo(System.Workflow.ComponentModel.Activity rootActivity) { return default(bool); }
  }
}
namespace System.Workflow.Activities.Rules.Design {
  public partial class RuleConditionDialog : System.Windows.Forms.Form {
    public RuleConditionDialog(System.Type activityType, System.Workflow.ComponentModel.Compiler.ITypeProvider typeProvider, System.CodeDom.CodeExpression expression) { }
    public RuleConditionDialog(System.Workflow.ComponentModel.Activity activity, System.CodeDom.CodeExpression expression) { }
    public System.CodeDom.CodeExpression Expression { get { return default(System.CodeDom.CodeExpression); } }
    protected override void Dispose(bool disposing) { }
  }
  public partial class RuleSetDialog : System.Windows.Forms.Form {
    public RuleSetDialog(System.Type activityType, System.Workflow.ComponentModel.Compiler.ITypeProvider typeProvider, System.Workflow.Activities.Rules.RuleSet ruleSet) { }
    public RuleSetDialog(System.Workflow.ComponentModel.Activity activity, System.Workflow.Activities.Rules.RuleSet ruleSet) { }
    public System.Workflow.Activities.Rules.RuleSet RuleSet { get { return default(System.Workflow.Activities.Rules.RuleSet); } }
    protected override void Dispose(bool disposing) { }
    protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData) { return default(bool); }
  }
}
