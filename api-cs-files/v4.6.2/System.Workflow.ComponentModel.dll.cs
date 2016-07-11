namespace System.Workflow.ComponentModel {
  [System.ComponentModel.Design.Serialization.DesignerSerializerAttribute(typeof(System.Workflow.ComponentModel.Serialization.ActivityCodeDomSerializer), typeof(System.ComponentModel.Design.Serialization.CodeDomSerializer))]
  [System.ComponentModel.Design.Serialization.DesignerSerializerAttribute(typeof(System.Workflow.ComponentModel.Serialization.ActivityMarkupSerializer), typeof(System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializer))]
  [System.ComponentModel.Design.Serialization.DesignerSerializerAttribute(typeof(System.Workflow.ComponentModel.Serialization.ActivityTypeCodeDomSerializer), typeof(System.ComponentModel.Design.Serialization.TypeCodeDomSerializer))]
  [System.ComponentModel.DesignerAttribute(typeof(System.Workflow.ComponentModel.Design.ActivityDesigner), typeof(System.ComponentModel.Design.IDesigner))]
  [System.ComponentModel.DesignerAttribute(typeof(System.Workflow.ComponentModel.Design.ActivityDesigner), typeof(System.ComponentModel.Design.IRootDesigner))]
  [System.ComponentModel.DesignerCategoryAttribute("Component")]
  [System.ComponentModel.ToolboxItemAttribute(typeof(System.Workflow.ComponentModel.Design.ActivityToolboxItem))]
  [System.ComponentModel.ToolboxItemFilterAttribute("Microsoft.Workflow.VSDesigner", (System.ComponentModel.ToolboxItemFilterType)(3))]
  [System.ComponentModel.ToolboxItemFilterAttribute("System.Workflow.ComponentModel.Design.ActivitySet", (System.ComponentModel.ToolboxItemFilterType)(0))]
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Workflow.ComponentModel.Activity), "Design.Resources.Activity.png")]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Workflow.ComponentModel.ActivityExecutorAttribute(typeof(System.Workflow.ComponentModel.ActivityExecutor<System.Workflow.ComponentModel.Activity>))]
  [System.Workflow.ComponentModel.Compiler.ActivityCodeGeneratorAttribute(typeof(System.Workflow.ComponentModel.Compiler.ActivityCodeGenerator))]
  [System.Workflow.ComponentModel.Compiler.ActivityValidatorAttribute(typeof(System.Workflow.ComponentModel.Compiler.ActivityValidator))]
  [System.Workflow.ComponentModel.Serialization.RuntimeNamePropertyAttribute("Name")]
  public partial class Activity : System.Workflow.ComponentModel.DependencyObject {
    public static readonly System.Workflow.ComponentModel.DependencyProperty ActivityContextGuidProperty;
    public static readonly System.Workflow.ComponentModel.DependencyProperty CancelingEvent;
    public static readonly System.Workflow.ComponentModel.DependencyProperty ClosedEvent;
    public static readonly System.Workflow.ComponentModel.DependencyProperty CompensatingEvent;
    public static readonly System.Workflow.ComponentModel.DependencyProperty ExecutingEvent;
    public static readonly System.Workflow.ComponentModel.DependencyProperty FaultingEvent;
    public static readonly System.Workflow.ComponentModel.DependencyProperty StatusChangedEvent;
    public Activity() { }
    public Activity(string name) { }
    [SRCategoryAttribute("Activity")]
    [SRDescriptionAttribute("DescriptionDescr")]
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute(typeof(System.ComponentModel.Design.MultilineStringEditor), typeof(System.Drawing.Design.UITypeEditor))]
    public string Description { get { return default(string); } set { } }
    [SRCategoryAttribute("Activity")]
    [SRDescriptionAttribute("EnabledDescr")]
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool Enabled { get { return default(bool); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Workflow.ComponentModel.ActivityExecutionResult ExecutionResult { get { return default(System.Workflow.ComponentModel.ActivityExecutionResult); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Workflow.ComponentModel.ActivityExecutionStatus ExecutionStatus { get { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public bool IsDynamicActivity { get { return default(bool); } }
    [SRCategoryAttribute("Activity")]
    [SRDescriptionAttribute("NameDescr")]
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.ComponentModel.ParenthesizePropertyNameAttribute(true)]
    public string Name { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Workflow.ComponentModel.CompositeActivity Parent { get { return default(System.Workflow.ComponentModel.CompositeActivity); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public string QualifiedName { get { return default(string); } }
    protected System.Guid WorkflowInstanceId { get { return default(System.Guid); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public event System.EventHandler<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs> Canceling { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public event System.EventHandler<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs> Closed { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public event System.EventHandler<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs> Compensating { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public event System.EventHandler<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs> Executing { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public event System.EventHandler<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs> Faulting { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public event System.EventHandler<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs> StatusChanged { add { } remove { } }
    protected internal virtual System.Workflow.ComponentModel.ActivityExecutionStatus Cancel(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    public System.Workflow.ComponentModel.Activity Clone() { return default(System.Workflow.ComponentModel.Activity); }
    protected internal virtual System.Workflow.ComponentModel.ActivityExecutionStatus Execute(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    public System.Workflow.ComponentModel.Activity GetActivityByName(string activityQualifiedName) { return default(System.Workflow.ComponentModel.Activity); }
    public System.Workflow.ComponentModel.Activity GetActivityByName(string activityQualifiedName, bool withinThisActivityOnly) { return default(System.Workflow.ComponentModel.Activity); }
    protected internal virtual System.Workflow.ComponentModel.ActivityExecutionStatus HandleFault(System.Workflow.ComponentModel.ActivityExecutionContext executionContext, System.Exception exception) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    protected internal virtual void Initialize(System.IServiceProvider provider) { }
    protected internal void Invoke<T>(System.EventHandler<T> handler, T e) where T : System.EventArgs { }
    protected internal void Invoke<T>(System.Workflow.ComponentModel.IActivityEventListener<T> eventListener, T e) where T : System.EventArgs { }
    public static System.Workflow.ComponentModel.Activity Load(System.IO.Stream stream, System.Workflow.ComponentModel.Activity outerActivity) { return default(System.Workflow.ComponentModel.Activity); }
    public static System.Workflow.ComponentModel.Activity Load(System.IO.Stream stream, System.Workflow.ComponentModel.Activity outerActivity, System.Runtime.Serialization.IFormatter formatter) { return default(System.Workflow.ComponentModel.Activity); }
    protected internal virtual void OnActivityExecutionContextLoad(System.IServiceProvider provider) { }
    protected internal virtual void OnActivityExecutionContextUnload(System.IServiceProvider provider) { }
    protected virtual void OnClosed(System.IServiceProvider provider) { }
    protected internal void RaiseEvent(System.Workflow.ComponentModel.DependencyProperty dependencyEvent, object sender, System.EventArgs e) { }
    protected internal void RaiseGenericEvent<T>(System.Workflow.ComponentModel.DependencyProperty dependencyEvent, object sender, T e) where T : System.EventArgs { }
    public void RegisterForStatusChange(System.Workflow.ComponentModel.DependencyProperty dependencyProp, System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs> activityStatusChangeListener) { }
    public void Save(System.IO.Stream stream) { }
    public void Save(System.IO.Stream stream, System.Runtime.Serialization.IFormatter formatter) { }
    public override string ToString() { return default(string); }
    protected void TrackData(object userData) { }
    protected void TrackData(string userDataKey, object userData) { }
    protected internal virtual void Uninitialize(System.IServiceProvider provider) { }
    public void UnregisterForStatusChange(System.Workflow.ComponentModel.DependencyProperty dependencyProp, System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs> activityStatusChangeListener) { }
  }
  [System.ComponentModel.BrowsableAttribute(true)]
  [System.ComponentModel.Design.Serialization.DesignerSerializerAttribute(typeof(System.Workflow.ComponentModel.Serialization.BindMarkupExtensionSerializer), typeof(System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializer))]
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Workflow.ComponentModel.Design.ActivityBindTypeConverter))]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Workflow.ComponentModel.Compiler.ActivityValidatorAttribute(typeof(System.Workflow.ComponentModel.Compiler.ActivityBindValidator))]
  public sealed partial class ActivityBind : System.Workflow.ComponentModel.Serialization.MarkupExtension {
    public ActivityBind() { }
    public ActivityBind(string name) { }
    public ActivityBind(string name, string path) { }
    [SRDescriptionAttribute("ActivityBindIDDescription")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Workflow.ComponentModel.Serialization.ConstructorArgumentAttribute("name")]
    public string Name { get { return default(string); } set { } }
    [SRDescriptionAttribute("ActivityBindPathDescription")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Workflow.ComponentModel.Design.ActivityBindPathTypeConverter))]
    public string Path { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Collections.IDictionary UserData { get { return default(System.Collections.IDictionary); } }
    public object GetRuntimeValue(System.Workflow.ComponentModel.Activity activity) { return default(object); }
    public object GetRuntimeValue(System.Workflow.ComponentModel.Activity activity, System.Type targetType) { return default(object); }
    public override object ProvideValue(System.IServiceProvider provider) { return default(object); }
    public void SetRuntimeValue(System.Workflow.ComponentModel.Activity activity, object value) { }
    public override string ToString() { return default(string); }
  }
  [System.ComponentModel.Design.Serialization.DesignerSerializerAttribute(typeof(System.Workflow.ComponentModel.ActivityChangeActionMarkupSerializer), typeof(System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializer))]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public abstract partial class ActivityChangeAction : System.Workflow.ComponentModel.WorkflowChangeAction {
    protected ActivityChangeAction() { }
    protected ActivityChangeAction(System.Workflow.ComponentModel.CompositeActivity compositeActivity) { }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(1))]
    public string OwnerActivityDottedPath { get { return default(string); } }
    protected internal override System.Workflow.ComponentModel.Compiler.ValidationErrorCollection ValidateChanges(System.Workflow.ComponentModel.Activity contextActivity) { return default(System.Workflow.ComponentModel.Compiler.ValidationErrorCollection); }
  }
  [System.ComponentModel.Design.Serialization.DesignerSerializerAttribute(typeof(System.Workflow.ComponentModel.Serialization.ActivityCollectionMarkupSerializer), typeof(System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializer))]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class ActivityCollection : System.Collections.Generic.List<System.Workflow.ComponentModel.Activity>, System.Collections.Generic.ICollection<System.Workflow.ComponentModel.Activity>, System.Collections.Generic.IEnumerable<System.Workflow.ComponentModel.Activity>, System.Collections.Generic.IList<System.Workflow.ComponentModel.Activity>, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList {
    public ActivityCollection(System.Workflow.ComponentModel.Activity owner) { }
    public new int Count { get { return default(int); } }
    public new System.Workflow.ComponentModel.Activity this[int index] { get { return default(System.Workflow.ComponentModel.Activity); } set { } }
    public System.Workflow.ComponentModel.Activity this[string key] { get { return default(System.Workflow.ComponentModel.Activity); } }
    int System.Collections.Generic.ICollection<System.Workflow.ComponentModel.Activity>.Count { get { return default(int); } }
    bool System.Collections.Generic.ICollection<System.Workflow.ComponentModel.Activity>.IsReadOnly { get { return default(bool); } }
    System.Workflow.ComponentModel.Activity System.Collections.Generic.IList<System.Workflow.ComponentModel.Activity>.this[int index] { get { return default(System.Workflow.ComponentModel.Activity); } set { } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    bool System.Collections.IList.IsFixedSize { get { return default(bool); } }
    bool System.Collections.IList.IsReadOnly { get { return default(bool); } }
    object System.Collections.IList.this[int index] { get { return default(object); } set { } }
    public event System.EventHandler<System.Workflow.ComponentModel.ActivityCollectionChangeEventArgs> ListChanged { add { } remove { } }
    public new void Add(System.Workflow.ComponentModel.Activity item) { }
    public new void Clear() { }
    public new bool Contains(System.Workflow.ComponentModel.Activity item) { return default(bool); }
    public new System.Collections.Generic.IEnumerator<System.Workflow.ComponentModel.Activity> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Workflow.ComponentModel.Activity>); }
    public new int IndexOf(System.Workflow.ComponentModel.Activity item) { return default(int); }
    public new void Insert(int index, System.Workflow.ComponentModel.Activity item) { }
    public new bool Remove(System.Workflow.ComponentModel.Activity item) { return default(bool); }
    public new void RemoveAt(int index) { }
    void System.Collections.Generic.ICollection<System.Workflow.ComponentModel.Activity>.Add(System.Workflow.ComponentModel.Activity item) { }
    void System.Collections.Generic.ICollection<System.Workflow.ComponentModel.Activity>.Clear() { }
    bool System.Collections.Generic.ICollection<System.Workflow.ComponentModel.Activity>.Contains(System.Workflow.ComponentModel.Activity item) { return default(bool); }
    void System.Collections.Generic.ICollection<System.Workflow.ComponentModel.Activity>.CopyTo(System.Workflow.ComponentModel.Activity[] array, int arrayIndex) { }
    bool System.Collections.Generic.ICollection<System.Workflow.ComponentModel.Activity>.Remove(System.Workflow.ComponentModel.Activity item) { return default(bool); }
    System.Collections.Generic.IEnumerator<System.Workflow.ComponentModel.Activity> System.Collections.Generic.IEnumerable<System.Workflow.ComponentModel.Activity>.GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Workflow.ComponentModel.Activity>); }
    int System.Collections.Generic.IList<System.Workflow.ComponentModel.Activity>.IndexOf(System.Workflow.ComponentModel.Activity item) { return default(int); }
    void System.Collections.Generic.IList<System.Workflow.ComponentModel.Activity>.Insert(int index, System.Workflow.ComponentModel.Activity item) { }
    void System.Collections.Generic.IList<System.Workflow.ComponentModel.Activity>.RemoveAt(int index) { }
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
  public enum ActivityCollectionChangeAction {
    Add = 0,
    Remove = 1,
    Replace = 2,
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class ActivityCollectionChangeEventArgs : System.EventArgs {
    public ActivityCollectionChangeEventArgs(int index, System.Collections.Generic.ICollection<System.Workflow.ComponentModel.Activity> removedItems, System.Collections.Generic.ICollection<System.Workflow.ComponentModel.Activity> addedItems, object owner, System.Workflow.ComponentModel.ActivityCollectionChangeAction action) { }
    public ActivityCollectionChangeEventArgs(int index, System.Workflow.ComponentModel.Activity removedActivity, System.Workflow.ComponentModel.Activity addedActivity, object owner, System.Workflow.ComponentModel.ActivityCollectionChangeAction action) { }
    public System.Workflow.ComponentModel.ActivityCollectionChangeAction Action { get { return default(System.Workflow.ComponentModel.ActivityCollectionChangeAction); } }
    public System.Collections.Generic.IList<System.Workflow.ComponentModel.Activity> AddedItems { get { return default(System.Collections.Generic.IList<System.Workflow.ComponentModel.Activity>); } }
    public int Index { get { return default(int); } }
    public object Owner { get { return default(object); } }
    public System.Collections.Generic.IList<System.Workflow.ComponentModel.Activity> RemovedItems { get { return default(System.Collections.Generic.IList<System.Workflow.ComponentModel.Activity>); } }
  }
  [System.ComponentModel.BrowsableAttribute(true)]
  [System.ComponentModel.Design.Serialization.DesignerSerializerAttribute(typeof(System.Workflow.ComponentModel.Serialization.DependencyObjectCodeDomSerializer), typeof(System.ComponentModel.Design.Serialization.CodeDomSerializer))]
  [System.ComponentModel.Design.Serialization.DesignerSerializerAttribute(typeof(System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializer), typeof(System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializer))]
  [System.ComponentModel.MergablePropertyAttribute(false)]
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Workflow.ComponentModel.Design.ConditionTypeConverter))]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Workflow.ComponentModel.Compiler.ActivityValidatorAttribute(typeof(System.Workflow.ComponentModel.Compiler.ConditionValidator))]
  public abstract partial class ActivityCondition : System.Workflow.ComponentModel.DependencyObject {
    protected ActivityCondition() { }
    public abstract bool Evaluate(System.Workflow.ComponentModel.Activity activity, System.IServiceProvider provider);
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class ActivityExecutionContext : System.IDisposable, System.IServiceProvider {
    internal ActivityExecutionContext() { }
    public static readonly System.Workflow.ComponentModel.DependencyProperty CurrentExceptionProperty;
    public System.Workflow.ComponentModel.Activity Activity { get { return default(System.Workflow.ComponentModel.Activity); } }
    public System.Guid ContextGuid { get { return default(System.Guid); } }
    public System.Workflow.ComponentModel.ActivityExecutionContextManager ExecutionContextManager { get { return default(System.Workflow.ComponentModel.ActivityExecutionContextManager); } }
    public void CancelActivity(System.Workflow.ComponentModel.Activity activity) { }
    public void CloseActivity() { }
    public void ExecuteActivity(System.Workflow.ComponentModel.Activity activity) { }
    public object GetService(System.Type serviceType) { return default(object); }
    public T GetService<T>() { return default(T); }
    void System.IDisposable.Dispose() { }
    public void TrackData(object userData) { }
    public void TrackData(string userDataKey, object userData) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class ActivityExecutionContextManager {
    internal ActivityExecutionContextManager() { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Workflow.ComponentModel.ActivityExecutionContext> ExecutionContexts { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Workflow.ComponentModel.ActivityExecutionContext>); } }
    public System.Collections.Generic.IEnumerable<System.Guid> PersistedExecutionContexts { get { return default(System.Collections.Generic.IEnumerable<System.Guid>); } }
    public void CompleteExecutionContext(System.Workflow.ComponentModel.ActivityExecutionContext childContext) { }
    public void CompleteExecutionContext(System.Workflow.ComponentModel.ActivityExecutionContext childContext, bool forcePersist) { }
    public System.Workflow.ComponentModel.ActivityExecutionContext CreateExecutionContext(System.Workflow.ComponentModel.Activity activity) { return default(System.Workflow.ComponentModel.ActivityExecutionContext); }
    public System.Workflow.ComponentModel.ActivityExecutionContext GetExecutionContext(System.Workflow.ComponentModel.Activity activity) { return default(System.Workflow.ComponentModel.ActivityExecutionContext); }
    public System.Workflow.ComponentModel.ActivityExecutionContext GetPersistedExecutionContext(System.Guid contextGuid) { return default(System.Workflow.ComponentModel.ActivityExecutionContext); }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public enum ActivityExecutionResult : byte {
    Canceled = (byte)2,
    Compensated = (byte)3,
    Faulted = (byte)4,
    None = (byte)0,
    Succeeded = (byte)1,
    Uninitialized = (byte)5,
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public enum ActivityExecutionStatus : byte {
    Canceling = (byte)2,
    Closed = (byte)3,
    Compensating = (byte)4,
    Executing = (byte)1,
    Faulting = (byte)5,
    Initialized = (byte)0,
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class ActivityExecutionStatusChangedEventArgs : System.EventArgs {
    internal ActivityExecutionStatusChangedEventArgs() { }
    public System.Workflow.ComponentModel.Activity Activity { get { return default(System.Workflow.ComponentModel.Activity); } }
    public System.Workflow.ComponentModel.ActivityExecutionResult ExecutionResult { get { return default(System.Workflow.ComponentModel.ActivityExecutionResult); } }
    public System.Workflow.ComponentModel.ActivityExecutionStatus ExecutionStatus { get { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); } }
    public override string ToString() { return default(string); }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class AddedActivityAction : System.Workflow.ComponentModel.ActivityChangeAction {
    public AddedActivityAction() { }
    public AddedActivityAction(System.Workflow.ComponentModel.CompositeActivity compositeActivity, System.Workflow.ComponentModel.Activity activityAdded) { }
    public System.Workflow.ComponentModel.Activity AddedActivity { get { return default(System.Workflow.ComponentModel.Activity); } }
    public int Index { get { return default(int); } }
    protected internal override bool ApplyTo(System.Workflow.ComponentModel.Activity rootActivity) { return default(bool); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false)]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class AlternateFlowActivityAttribute : System.Attribute {
    public AlternateFlowActivityAttribute() { }
  }
  [System.ComponentModel.DesignerAttribute(typeof(System.Workflow.ComponentModel.Design.CancellationHandlerActivityDesigner), typeof(System.ComponentModel.Design.IDesigner))]
  [System.ComponentModel.ToolboxItemAttribute(false)]
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Workflow.ComponentModel.CancellationHandlerActivity), "Resources.CancellationHandler.bmp")]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Workflow.ComponentModel.AlternateFlowActivityAttribute]
  [System.Workflow.ComponentModel.Compiler.ActivityValidatorAttribute(typeof(System.Workflow.ComponentModel.CancellationHandlerValidator))]
  public sealed partial class CancellationHandlerActivity : System.Workflow.ComponentModel.CompositeActivity, System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs> {
    public CancellationHandlerActivity() { }
    public CancellationHandlerActivity(string name) { }
    protected internal override System.Workflow.ComponentModel.ActivityExecutionStatus Cancel(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    protected internal override System.Workflow.ComponentModel.ActivityExecutionStatus Execute(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    protected internal override void Initialize(System.IServiceProvider provider) { }
    protected internal override void OnActivityChangeRemove(System.Workflow.ComponentModel.ActivityExecutionContext executionContext, System.Workflow.ComponentModel.Activity removedActivity) { }
    protected internal override void OnWorkflowChangesCompleted(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { }
    void System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs>.OnEvent(object sender, System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs e) { }
  }
  [SRDescriptionAttribute("CompensatableTransactionalContextActivityDescription")]
  [System.ComponentModel.DesignerAttribute(typeof(System.Workflow.ComponentModel.Design.CompensatableTransactionScopeActivityDesigner), typeof(System.ComponentModel.Design.IDesigner))]
  [System.ComponentModel.ToolboxItemAttribute(typeof(System.Workflow.ComponentModel.Design.ActivityToolboxItem))]
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Workflow.ComponentModel.CompensatableTransactionScopeActivity), "Resources.Sequence.png")]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Workflow.ComponentModel.PersistOnCloseAttribute]
  [System.Workflow.ComponentModel.SupportsTransactionAttribute]
  public sealed partial class CompensatableTransactionScopeActivity : System.Workflow.ComponentModel.CompositeActivity, System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs>, System.Workflow.ComponentModel.ICompensatableActivity {
    public CompensatableTransactionScopeActivity() { }
    public CompensatableTransactionScopeActivity(string name) { }
    [SRDescriptionAttribute("TransactionDesc")]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.ComponentModel.ReadOnlyAttribute(true)]
    public System.Workflow.ComponentModel.WorkflowTransactionOptions TransactionOptions { get { return default(System.Workflow.ComponentModel.WorkflowTransactionOptions); } set { } }
    protected internal override System.Workflow.ComponentModel.ActivityExecutionStatus Cancel(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    protected internal override System.Workflow.ComponentModel.ActivityExecutionStatus Execute(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    protected internal override void OnActivityChangeRemove(System.Workflow.ComponentModel.ActivityExecutionContext executionContext, System.Workflow.ComponentModel.Activity removedActivity) { }
    protected internal override void OnWorkflowChangesCompleted(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { }
    void System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs>.OnEvent(object sender, System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs e) { }
    System.Workflow.ComponentModel.ActivityExecutionStatus System.Workflow.ComponentModel.ICompensatableActivity.Compensate(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
  }
  [SRCategoryAttribute("Standard")]
  [SRDescriptionAttribute("CompensateActivityDescription")]
  [System.ComponentModel.DesignerAttribute(typeof(System.Workflow.ComponentModel.CompensateDesigner), typeof(System.ComponentModel.Design.IDesigner))]
  [System.ComponentModel.ToolboxItemAttribute(typeof(System.Workflow.ComponentModel.Design.ActivityToolboxItem))]
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Workflow.ComponentModel.CompensateActivity), "Resources.Compensate.png")]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Workflow.ComponentModel.Compiler.ActivityValidatorAttribute(typeof(System.Workflow.ComponentModel.CompensateValidator))]
  public sealed partial class CompensateActivity : System.Workflow.ComponentModel.Activity, System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs> {
    public static readonly System.Workflow.ComponentModel.DependencyProperty TargetActivityNameProperty;
    public CompensateActivity() { }
    public CompensateActivity(string name) { }
    [SRCategoryAttribute("Activity")]
    [SRDescriptionAttribute("CompensatableActivityDescr")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Workflow.ComponentModel.Design.PropertyValueProviderTypeConverter))]
    public string TargetActivityName { get { return default(string); } set { } }
    protected internal override System.Workflow.ComponentModel.ActivityExecutionStatus Execute(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    protected internal override void Initialize(System.IServiceProvider provider) { }
    void System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs>.OnEvent(object sender, System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs e) { }
  }
  [SRCategoryAttribute("Standard")]
  [System.ComponentModel.DesignerAttribute(typeof(System.Workflow.ComponentModel.Design.CompensationHandlerActivityDesigner), typeof(System.ComponentModel.Design.IDesigner))]
  [System.ComponentModel.ToolboxItemAttribute(false)]
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Workflow.ComponentModel.CompensationHandlerActivity), "Resources.Compensation.png")]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Workflow.ComponentModel.AlternateFlowActivityAttribute]
  [System.Workflow.ComponentModel.Compiler.ActivityValidatorAttribute(typeof(System.Workflow.ComponentModel.CompensationValidator))]
  public sealed partial class CompensationHandlerActivity : System.Workflow.ComponentModel.CompositeActivity, System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs> {
    public CompensationHandlerActivity() { }
    public CompensationHandlerActivity(string name) { }
    protected internal override System.Workflow.ComponentModel.ActivityExecutionStatus Cancel(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    protected internal override System.Workflow.ComponentModel.ActivityExecutionStatus Execute(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    protected internal override void Initialize(System.IServiceProvider provider) { }
    protected internal override void OnActivityChangeRemove(System.Workflow.ComponentModel.ActivityExecutionContext executionContext, System.Workflow.ComponentModel.Activity removedActivity) { }
    protected internal override void OnWorkflowChangesCompleted(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { }
    void System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs>.OnEvent(object sender, System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs e) { }
  }
  [System.ComponentModel.Design.Serialization.DesignerSerializerAttribute(typeof(System.Workflow.ComponentModel.Serialization.CompositeActivityMarkupSerializer), typeof(System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializer))]
  [System.ComponentModel.TypeDescriptionProviderAttribute(typeof(System.Workflow.ComponentModel.Serialization.CompositeActivityTypeDescriptorProvider))]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Workflow.ComponentModel.ActivityExecutorAttribute(typeof(System.Workflow.ComponentModel.CompositeActivityExecutor<System.Workflow.ComponentModel.CompositeActivity>))]
  [System.Workflow.ComponentModel.Compiler.ActivityCodeGeneratorAttribute(typeof(System.Workflow.ComponentModel.Compiler.CompositeActivityCodeGenerator))]
  [System.Workflow.ComponentModel.Compiler.ActivityValidatorAttribute(typeof(System.Workflow.ComponentModel.Compiler.CompositeActivityValidator))]
  [System.Workflow.ComponentModel.Serialization.ContentPropertyAttribute("Activities")]
  public partial class CompositeActivity : System.Workflow.ComponentModel.Activity {
    public CompositeActivity() { }
    public CompositeActivity(System.Collections.Generic.IEnumerable<System.Workflow.ComponentModel.Activity> children) { }
    public CompositeActivity(string name) { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    public System.Workflow.ComponentModel.ActivityCollection Activities { get { return default(System.Workflow.ComponentModel.ActivityCollection); } }
    protected internal bool CanModifyActivities { get { return default(bool); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Workflow.ComponentModel.Activity> EnabledActivities { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Workflow.ComponentModel.Activity>); } }
    protected void ApplyWorkflowChanges(System.Workflow.ComponentModel.WorkflowChanges workflowChanges) { }
    protected override void Dispose(bool disposing) { }
    protected System.Workflow.ComponentModel.Activity[] GetDynamicActivities(System.Workflow.ComponentModel.Activity activity) { return default(System.Workflow.ComponentModel.Activity[]); }
    protected internal override System.Workflow.ComponentModel.ActivityExecutionStatus HandleFault(System.Workflow.ComponentModel.ActivityExecutionContext executionContext, System.Exception exception) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    protected internal override void Initialize(System.IServiceProvider provider) { }
    protected internal virtual void OnActivityChangeAdd(System.Workflow.ComponentModel.ActivityExecutionContext executionContext, System.Workflow.ComponentModel.Activity addedActivity) { }
    protected internal virtual void OnActivityChangeRemove(System.Workflow.ComponentModel.ActivityExecutionContext executionContext, System.Workflow.ComponentModel.Activity removedActivity) { }
    protected internal override void OnActivityExecutionContextLoad(System.IServiceProvider provider) { }
    protected internal override void OnActivityExecutionContextUnload(System.IServiceProvider provider) { }
    protected virtual void OnListChanged(System.Workflow.ComponentModel.ActivityCollectionChangeEventArgs e) { }
    protected virtual void OnListChanging(System.Workflow.ComponentModel.ActivityCollectionChangeEventArgs e) { }
    protected internal virtual void OnWorkflowChangesCompleted(System.Workflow.ComponentModel.ActivityExecutionContext rootContext) { }
    protected internal override void Uninitialize(System.IServiceProvider provider) { }
  }
  [System.ComponentModel.Design.Serialization.DesignerSerializerAttribute(typeof(System.Workflow.ComponentModel.Serialization.DependencyObjectCodeDomSerializer), typeof(System.ComponentModel.Design.Serialization.CodeDomSerializer))]
  [System.ComponentModel.Design.Serialization.DesignerSerializerAttribute(typeof(System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializer), typeof(System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializer))]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public abstract partial class DependencyObject : System.ComponentModel.IComponent, System.IDisposable {
    protected DependencyObject() { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    protected internal bool DesignMode { get { return default(bool); } }
    protected System.Workflow.ComponentModel.DependencyObject ParentDependencyObject { get { return default(System.Workflow.ComponentModel.DependencyObject); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public System.ComponentModel.ISite Site { get { return default(System.ComponentModel.ISite); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Collections.IDictionary UserData { get { return default(System.Collections.IDictionary); } }
    event System.EventHandler System.ComponentModel.IComponent.Disposed { add { } remove { } }
    public void AddHandler(System.Workflow.ComponentModel.DependencyProperty dependencyEvent, object value) { }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    ~DependencyObject() { }
    public System.Workflow.ComponentModel.ActivityBind GetBinding(System.Workflow.ComponentModel.DependencyProperty dependencyProperty) { return default(System.Workflow.ComponentModel.ActivityBind); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    protected virtual object GetBoundValue(System.Workflow.ComponentModel.ActivityBind bind, System.Type targetType) { return default(object); }
    protected T[] GetInvocationList<T>(System.Workflow.ComponentModel.DependencyProperty dependencyEvent) { return default(T[]); }
    public object GetValue(System.Workflow.ComponentModel.DependencyProperty dependencyProperty) { return default(object); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public object GetValueBase(System.Workflow.ComponentModel.DependencyProperty dependencyProperty) { return default(object); }
    protected virtual void InitializeProperties() { }
    public bool IsBindingSet(System.Workflow.ComponentModel.DependencyProperty dependencyProperty) { return default(bool); }
    public bool MetaEquals(System.Workflow.ComponentModel.DependencyObject dependencyObject) { return default(bool); }
    public void RemoveHandler(System.Workflow.ComponentModel.DependencyProperty dependencyEvent, object value) { }
    public bool RemoveProperty(System.Workflow.ComponentModel.DependencyProperty dependencyProperty) { return default(bool); }
    public void SetBinding(System.Workflow.ComponentModel.DependencyProperty dependencyProperty, System.Workflow.ComponentModel.ActivityBind bind) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    protected virtual void SetBoundValue(System.Workflow.ComponentModel.ActivityBind bind, object value) { }
    protected internal void SetReadOnlyPropertyValue(System.Workflow.ComponentModel.DependencyProperty dependencyProperty, object value) { }
    public void SetValue(System.Workflow.ComponentModel.DependencyProperty dependencyProperty, object value) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void SetValueBase(System.Workflow.ComponentModel.DependencyProperty dependencyProperty, object value) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class DependencyProperty : System.Runtime.Serialization.ISerializable {
    internal DependencyProperty() { }
    public System.Workflow.ComponentModel.PropertyMetadata DefaultMetadata { get { return default(System.Workflow.ComponentModel.PropertyMetadata); } }
    public bool IsAttached { get { return default(bool); } }
    public bool IsEvent { get { return default(bool); } }
    public string Name { get { return default(string); } }
    public System.Type OwnerType { get { return default(System.Type); } }
    public System.Type PropertyType { get { return default(System.Type); } }
    public System.Type ValidatorType { get { return default(System.Type); } }
    public static System.Workflow.ComponentModel.DependencyProperty FromName(string propertyName, System.Type ownerType) { return default(System.Workflow.ComponentModel.DependencyProperty); }
    public static System.Collections.Generic.IList<System.Workflow.ComponentModel.DependencyProperty> FromType(System.Type ownerType) { return default(System.Collections.Generic.IList<System.Workflow.ComponentModel.DependencyProperty>); }
    public override int GetHashCode() { return default(int); }
    public static System.Workflow.ComponentModel.DependencyProperty Register(string name, System.Type propertyType, System.Type ownerType) { return default(System.Workflow.ComponentModel.DependencyProperty); }
    public static System.Workflow.ComponentModel.DependencyProperty Register(string name, System.Type propertyType, System.Type ownerType, System.Workflow.ComponentModel.PropertyMetadata defaultMetadata) { return default(System.Workflow.ComponentModel.DependencyProperty); }
    public static System.Workflow.ComponentModel.DependencyProperty RegisterAttached(string name, System.Type propertyType, System.Type ownerType) { return default(System.Workflow.ComponentModel.DependencyProperty); }
    public static System.Workflow.ComponentModel.DependencyProperty RegisterAttached(string name, System.Type propertyType, System.Type ownerType, System.Workflow.ComponentModel.PropertyMetadata defaultMetadata) { return default(System.Workflow.ComponentModel.DependencyProperty); }
    public static System.Workflow.ComponentModel.DependencyProperty RegisterAttached(string name, System.Type propertyType, System.Type ownerType, System.Workflow.ComponentModel.PropertyMetadata defaultMetadata, System.Type validatorType) { return default(System.Workflow.ComponentModel.DependencyProperty); }
    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public override string ToString() { return default(string); }
  }
  [System.FlagsAttribute]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public enum DependencyPropertyOptions : byte {
    Default = (byte)1,
    DelegateProperty = (byte)32,
    Metadata = (byte)8,
    NonSerialized = (byte)16,
    Optional = (byte)4,
    ReadOnly = (byte)2,
  }
  [SRCategoryAttribute("Standard")]
  [SRDescriptionAttribute("FaultHandlerActivityDescription")]
  [System.ComponentModel.DesignerAttribute(typeof(System.Workflow.ComponentModel.Design.FaultHandlerActivityDesigner), typeof(System.ComponentModel.Design.IDesigner))]
  [System.ComponentModel.ToolboxItemAttribute(typeof(System.Workflow.ComponentModel.Design.ActivityToolboxItem))]
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Workflow.ComponentModel.FaultHandlerActivity), "Resources.Exception.png")]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Workflow.ComponentModel.Compiler.ActivityValidatorAttribute(typeof(System.Workflow.ComponentModel.FaultHandlerActivityValidator))]
  public sealed partial class FaultHandlerActivity : System.Workflow.ComponentModel.CompositeActivity, System.Workflow.ComponentModel.Design.ITypeFilterProvider, System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs>, System.Workflow.ComponentModel.IDynamicPropertyTypeProvider {
    public static readonly System.Workflow.ComponentModel.DependencyProperty FaultTypeProperty;
    public FaultHandlerActivity() { }
    public FaultHandlerActivity(string name) { }
    [SRDescriptionAttribute("FaultDescription")]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.ComponentModel.ReadOnlyAttribute(true)]
    public System.Exception Fault { get { return default(System.Exception); } }
    [SRDescriptionAttribute("ExceptionTypeDescr")]
    [System.ComponentModel.EditorAttribute(typeof(System.Workflow.ComponentModel.Design.TypeBrowserEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    public System.Type FaultType { get { return default(System.Type); } set { } }
    string System.Workflow.ComponentModel.Design.ITypeFilterProvider.FilterDescription { get { return default(string); } }
    protected internal override System.Workflow.ComponentModel.ActivityExecutionStatus Cancel(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    protected internal override System.Workflow.ComponentModel.ActivityExecutionStatus Execute(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    protected internal override void Initialize(System.IServiceProvider provider) { }
    protected internal override void OnActivityChangeRemove(System.Workflow.ComponentModel.ActivityExecutionContext executionContext, System.Workflow.ComponentModel.Activity removedActivity) { }
    protected internal override void OnWorkflowChangesCompleted(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { }
    bool System.Workflow.ComponentModel.Design.ITypeFilterProvider.CanFilterType(System.Type type, bool throwOnError) { return default(bool); }
    void System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs>.OnEvent(object sender, System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs e) { }
    System.Workflow.ComponentModel.Compiler.AccessTypes System.Workflow.ComponentModel.IDynamicPropertyTypeProvider.GetAccessType(System.IServiceProvider serviceProvider, string propertyName) { return default(System.Workflow.ComponentModel.Compiler.AccessTypes); }
    System.Type System.Workflow.ComponentModel.IDynamicPropertyTypeProvider.GetPropertyType(System.IServiceProvider serviceProvider, string propertyName) { return default(System.Type); }
  }
  [SRCategoryAttribute("Standard")]
  [System.ComponentModel.DesignerAttribute(typeof(System.Workflow.ComponentModel.Design.FaultHandlersActivityDesigner), typeof(System.ComponentModel.Design.IDesigner))]
  [System.ComponentModel.ToolboxItemAttribute(false)]
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Workflow.ComponentModel.FaultHandlersActivity), "Resources.Exceptions.png")]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Workflow.ComponentModel.AlternateFlowActivityAttribute]
  [System.Workflow.ComponentModel.Compiler.ActivityValidatorAttribute(typeof(System.Workflow.ComponentModel.FaultHandlersActivityValidator))]
  public sealed partial class FaultHandlersActivity : System.Workflow.ComponentModel.CompositeActivity, System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs> {
    public FaultHandlersActivity() { }
    public FaultHandlersActivity(string name) { }
    protected internal override System.Workflow.ComponentModel.ActivityExecutionStatus Cancel(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    protected internal override System.Workflow.ComponentModel.ActivityExecutionStatus Execute(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    protected internal override void Initialize(System.IServiceProvider provider) { }
    protected internal override void OnActivityChangeRemove(System.Workflow.ComponentModel.ActivityExecutionContext executionContext, System.Workflow.ComponentModel.Activity removedActivity) { }
    protected override void OnClosed(System.IServiceProvider provider) { }
    protected internal override void OnWorkflowChangesCompleted(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { }
    void System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs>.OnEvent(object sender, System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs e) { }
  }
  public delegate object GetValueOverride(System.Workflow.ComponentModel.DependencyObject d);
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial interface IActivityEventListener<T> where T : System.EventArgs {
    void OnEvent(object sender, T e);
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial interface ICompensatableActivity {
    System.Workflow.ComponentModel.ActivityExecutionStatus Compensate(System.Workflow.ComponentModel.ActivityExecutionContext executionContext);
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial interface IDynamicPropertyTypeProvider {
    System.Workflow.ComponentModel.Compiler.AccessTypes GetAccessType(System.IServiceProvider serviceProvider, string propertyName);
    System.Type GetPropertyType(System.IServiceProvider serviceProvider, string propertyName);
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial interface IStartWorkflow {
    System.Guid StartWorkflow(System.Type workflowType, System.Collections.Generic.Dictionary<System.String, System.Object> namedArgumentValues);
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial interface IWorkflowChangeDiff {
    System.Collections.Generic.IList<System.Workflow.ComponentModel.WorkflowChangeAction> Diff(object originalDefinition, object changedDefinition);
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false)]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class PersistOnCloseAttribute : System.Attribute {
    public PersistOnCloseAttribute() { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class PropertyMetadata {
    public PropertyMetadata() { }
    public PropertyMetadata(params System.Attribute[] attributes) { }
    public PropertyMetadata(object defaultValue) { }
    public PropertyMetadata(object defaultValue, params System.Attribute[] attributes) { }
    public PropertyMetadata(object defaultValue, System.Workflow.ComponentModel.DependencyPropertyOptions options) { }
    public PropertyMetadata(object defaultValue, System.Workflow.ComponentModel.DependencyPropertyOptions options, params System.Attribute[] attributes) { }
    public PropertyMetadata(object defaultValue, System.Workflow.ComponentModel.DependencyPropertyOptions options, System.Workflow.ComponentModel.GetValueOverride getValueOverride, System.Workflow.ComponentModel.SetValueOverride setValueOverride) { }
    public PropertyMetadata(object defaultValue, System.Workflow.ComponentModel.DependencyPropertyOptions options, System.Workflow.ComponentModel.GetValueOverride getValueOverride, System.Workflow.ComponentModel.SetValueOverride setValueOverride, params System.Attribute[] attributes) { }
    public PropertyMetadata(System.Workflow.ComponentModel.DependencyPropertyOptions options) { }
    public PropertyMetadata(System.Workflow.ComponentModel.DependencyPropertyOptions options, params System.Attribute[] attributes) { }
    public object DefaultValue { get { return default(object); } set { } }
    public System.Workflow.ComponentModel.GetValueOverride GetValueOverride { get { return default(System.Workflow.ComponentModel.GetValueOverride); } set { } }
    public bool IsMetaProperty { get { return default(bool); } }
    public bool IsNonSerialized { get { return default(bool); } }
    public bool IsReadOnly { get { return default(bool); } }
    protected bool IsSealed { get { return default(bool); } }
    public System.Workflow.ComponentModel.DependencyPropertyOptions Options { get { return default(System.Workflow.ComponentModel.DependencyPropertyOptions); } set { } }
    public System.Workflow.ComponentModel.SetValueOverride SetValueOverride { get { return default(System.Workflow.ComponentModel.SetValueOverride); } set { } }
    public System.Attribute[] GetAttributes() { return default(System.Attribute[]); }
    public System.Attribute[] GetAttributes(System.Type attributeType) { return default(System.Attribute[]); }
    protected virtual void OnApply(System.Workflow.ComponentModel.DependencyProperty dependencyProperty, System.Type targetType) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class QueueEventArgs : System.EventArgs {
    internal QueueEventArgs() { }
    public System.IComparable QueueName { get { return default(System.IComparable); } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class RemovedActivityAction : System.Workflow.ComponentModel.ActivityChangeAction {
    public RemovedActivityAction() { }
    public RemovedActivityAction(int removedActivityIndex, System.Workflow.ComponentModel.Activity originalActivity, System.Workflow.ComponentModel.CompositeActivity clonedParentActivity) { }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Workflow.ComponentModel.Activity OriginalRemovedActivity { get { return default(System.Workflow.ComponentModel.Activity); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(1))]
    public int RemovedActivityIndex { get { return default(int); } }
    protected internal override bool ApplyTo(System.Workflow.ComponentModel.Activity rootActivity) { return default(bool); }
    protected internal override System.Workflow.ComponentModel.Compiler.ValidationErrorCollection ValidateChanges(System.Workflow.ComponentModel.Activity contextActivity) { return default(System.Workflow.ComponentModel.Compiler.ValidationErrorCollection); }
  }
  public delegate void SetValueOverride(System.Workflow.ComponentModel.DependencyObject d, object value);
  [SRCategoryAttribute("Standard")]
  [SRDescriptionAttribute("SuspendActivityDescription")]
  [System.ComponentModel.DesignerAttribute(typeof(System.Workflow.ComponentModel.Design.SuspendDesigner), typeof(System.ComponentModel.Design.IDesigner))]
  [System.ComponentModel.ToolboxItemAttribute(typeof(System.Workflow.ComponentModel.Design.ActivityToolboxItem))]
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Workflow.ComponentModel.SuspendActivity), "Resources.Suspend.png")]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Workflow.ComponentModel.Compiler.ActivityValidatorAttribute(typeof(System.Workflow.ComponentModel.SuspendValidator))]
  public sealed partial class SuspendActivity : System.Workflow.ComponentModel.Activity {
    public static readonly System.Workflow.ComponentModel.DependencyProperty ErrorProperty;
    public SuspendActivity() { }
    public SuspendActivity(string name) { }
    [SRCategoryAttribute("Activity")]
    [SRDescriptionAttribute("SuspendErrorMessageDescr")]
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    public string Error { get { return default(string); } set { } }
    protected internal sealed override System.Workflow.ComponentModel.ActivityExecutionStatus Execute(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    protected internal override void Initialize(System.IServiceProvider provider) { }
  }
  [SRDescriptionAttribute("SynchronizationScopeActivityDescription")]
  [System.ComponentModel.DesignerAttribute(typeof(System.Workflow.ComponentModel.Design.SequenceDesigner), typeof(System.ComponentModel.Design.IDesigner))]
  [System.ComponentModel.ToolboxItemAttribute(typeof(System.Workflow.ComponentModel.Design.ActivityToolboxItem))]
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Workflow.ComponentModel.SynchronizationScopeActivity), "Resources.Sequence.png")]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Workflow.ComponentModel.SupportsSynchronizationAttribute]
  public sealed partial class SynchronizationScopeActivity : System.Workflow.ComponentModel.CompositeActivity, System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs> {
    public SynchronizationScopeActivity() { }
    public SynchronizationScopeActivity(string name) { }
    [SRDescriptionAttribute("SynchronizationHandlesDesc")]
    [SRDisplayNameAttribute("SynchronizationHandles")]
    [System.ComponentModel.EditorAttribute(typeof(System.Workflow.ComponentModel.SynchronizationHandlesEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Workflow.ComponentModel.SynchronizationHandlesTypeConverter))]
    public System.Collections.Generic.ICollection<System.String> SynchronizationHandles { get { return default(System.Collections.Generic.ICollection<System.String>); } set { } }
    protected internal override System.Workflow.ComponentModel.ActivityExecutionStatus Cancel(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    protected internal override System.Workflow.ComponentModel.ActivityExecutionStatus Execute(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    protected internal override void OnActivityChangeRemove(System.Workflow.ComponentModel.ActivityExecutionContext executionContext, System.Workflow.ComponentModel.Activity removedActivity) { }
    protected internal override void OnWorkflowChangesCompleted(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { }
    void System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs>.OnEvent(object sender, System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs e) { }
  }
  [SRCategoryAttribute("Standard")]
  [SRDescriptionAttribute("TerminateActivityDescription")]
  [System.ComponentModel.DesignerAttribute(typeof(System.Workflow.ComponentModel.Design.TerminateDesigner), typeof(System.ComponentModel.Design.IDesigner))]
  [System.ComponentModel.ToolboxItemAttribute(typeof(System.Workflow.ComponentModel.Design.ActivityToolboxItem))]
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Workflow.ComponentModel.TerminateActivity), "Resources.Terminate.png")]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class TerminateActivity : System.Workflow.ComponentModel.Activity {
    public static readonly System.Workflow.ComponentModel.DependencyProperty ErrorProperty;
    public TerminateActivity() { }
    public TerminateActivity(string name) { }
    [SRCategoryAttribute("Activity")]
    [SRDescriptionAttribute("TerminateErrorMessageDescr")]
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    public string Error { get { return default(string); } set { } }
    protected internal sealed override System.Workflow.ComponentModel.ActivityExecutionStatus Execute(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    protected internal override void Initialize(System.IServiceProvider provider) { }
  }
  [SRCategoryAttribute("Standard")]
  [SRDescriptionAttribute("FaultActivityDescription")]
  [System.ComponentModel.DesignerAttribute(typeof(System.Workflow.ComponentModel.Design.ThrowDesigner), typeof(System.ComponentModel.Design.IDesigner))]
  [System.ComponentModel.ToolboxItemAttribute(typeof(System.Workflow.ComponentModel.Design.ActivityToolboxItem))]
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Workflow.ComponentModel.ThrowActivity), "Resources.Throw.png")]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class ThrowActivity : System.Workflow.ComponentModel.Activity, System.Workflow.ComponentModel.Design.ITypeFilterProvider, System.Workflow.ComponentModel.IDynamicPropertyTypeProvider {
    [System.ComponentModel.BrowsableAttribute(false)]
    public static readonly System.Workflow.ComponentModel.DependencyProperty FaultProperty;
    [System.ComponentModel.BrowsableAttribute(false)]
    public static readonly System.Workflow.ComponentModel.DependencyProperty FaultTypeProperty;
    public ThrowActivity() { }
    public ThrowActivity(string name) { }
    [SRCategoryAttribute("Handlers")]
    [SRDescriptionAttribute("FaultDescription")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Workflow.ComponentModel.ThrowActivity.FaultConverter))]
    public System.Exception Fault { get { return default(System.Exception); } set { } }
    [SRCategoryAttribute("Handlers")]
    [SRDescriptionAttribute("FaultTypeDescription")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.EditorAttribute(typeof(System.Workflow.ComponentModel.Design.TypeBrowserEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Workflow.ComponentModel.ThrowActivity.FaultTypeConverter))]
    public System.Type FaultType { get { return default(System.Type); } set { } }
    string System.Workflow.ComponentModel.Design.ITypeFilterProvider.FilterDescription { get { return default(string); } }
    protected internal sealed override System.Workflow.ComponentModel.ActivityExecutionStatus Execute(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    protected internal override void Initialize(System.IServiceProvider provider) { }
    bool System.Workflow.ComponentModel.Design.ITypeFilterProvider.CanFilterType(System.Type type, bool throwOnError) { return default(bool); }
    System.Workflow.ComponentModel.Compiler.AccessTypes System.Workflow.ComponentModel.IDynamicPropertyTypeProvider.GetAccessType(System.IServiceProvider serviceProvider, string propertyName) { return default(System.Workflow.ComponentModel.Compiler.AccessTypes); }
    System.Type System.Workflow.ComponentModel.IDynamicPropertyTypeProvider.GetPropertyType(System.IServiceProvider serviceProvider, string propertyName) { return default(System.Type); }
  }
  [SRDescriptionAttribute("TransactionalContextActivityDescription")]
  [System.ComponentModel.DesignerAttribute(typeof(System.Workflow.ComponentModel.Design.TransactionScopeActivityDesigner), typeof(System.ComponentModel.Design.IDesigner))]
  [System.ComponentModel.ToolboxItemAttribute(typeof(System.Workflow.ComponentModel.Design.ActivityToolboxItem))]
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Workflow.ComponentModel.TransactionScopeActivity), "Resources.Sequence.png")]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Workflow.ComponentModel.PersistOnCloseAttribute]
  [System.Workflow.ComponentModel.SupportsTransactionAttribute]
  public sealed partial class TransactionScopeActivity : System.Workflow.ComponentModel.CompositeActivity, System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs> {
    public TransactionScopeActivity() { }
    public TransactionScopeActivity(string name) { }
    [SRDescriptionAttribute("TransactionDesc")]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.ComponentModel.ReadOnlyAttribute(true)]
    public System.Workflow.ComponentModel.WorkflowTransactionOptions TransactionOptions { get { return default(System.Workflow.ComponentModel.WorkflowTransactionOptions); } set { } }
    protected internal override System.Workflow.ComponentModel.ActivityExecutionStatus Cancel(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    protected internal override System.Workflow.ComponentModel.ActivityExecutionStatus Execute(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { return default(System.Workflow.ComponentModel.ActivityExecutionStatus); }
    protected internal override void OnActivityChangeRemove(System.Workflow.ComponentModel.ActivityExecutionContext executionContext, System.Workflow.ComponentModel.Activity removedActivity) { }
    protected internal override void OnWorkflowChangesCompleted(System.Workflow.ComponentModel.ActivityExecutionContext executionContext) { }
    void System.Workflow.ComponentModel.IActivityEventListener<System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs>.OnEvent(object sender, System.Workflow.ComponentModel.ActivityExecutionStatusChangedEventArgs e) { }
  }
  [System.ComponentModel.Design.Serialization.DesignerSerializerAttribute(typeof(System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializer), typeof(System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializer))]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public abstract partial class WorkflowChangeAction {
    protected WorkflowChangeAction() { }
    protected internal abstract bool ApplyTo(System.Workflow.ComponentModel.Activity rootActivity);
    protected internal abstract System.Workflow.ComponentModel.Compiler.ValidationErrorCollection ValidateChanges(System.Workflow.ComponentModel.Activity activity);
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class WorkflowChanges {
    public static readonly System.Workflow.ComponentModel.DependencyProperty ConditionProperty;
    public WorkflowChanges(System.Workflow.ComponentModel.Activity rootActivity) { }
    public System.Workflow.ComponentModel.CompositeActivity TransientWorkflow { get { return default(System.Workflow.ComponentModel.CompositeActivity); } }
    public static object GetCondition(object dependencyObject) { return default(object); }
    public static void SetCondition(object dependencyObject, object value) { }
    public System.Workflow.ComponentModel.Compiler.ValidationErrorCollection Validate() { return default(System.Workflow.ComponentModel.Compiler.ValidationErrorCollection); }
  }
  [System.ComponentModel.BrowsableAttribute(true)]
  [System.ComponentModel.Design.Serialization.DesignerSerializerAttribute(typeof(System.Workflow.ComponentModel.Serialization.DependencyObjectCodeDomSerializer), typeof(System.ComponentModel.Design.Serialization.CodeDomSerializer))]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class WorkflowParameterBinding : System.Workflow.ComponentModel.DependencyObject {
    public static readonly System.Workflow.ComponentModel.DependencyProperty ParameterNameProperty;
    public static readonly System.Workflow.ComponentModel.DependencyProperty ValueProperty;
    public WorkflowParameterBinding() { }
    public WorkflowParameterBinding(string parameterName) { }
    public string ParameterName { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public object Value { get { return default(object); } set { } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class WorkflowParameterBindingCollection : System.Collections.ObjectModel.KeyedCollection<System.String, System.Workflow.ComponentModel.WorkflowParameterBinding> {
    public WorkflowParameterBindingCollection(System.Workflow.ComponentModel.Activity ownerActivity) { }
    protected override void ClearItems() { }
    public System.Workflow.ComponentModel.WorkflowParameterBinding GetItem(string key) { return default(System.Workflow.ComponentModel.WorkflowParameterBinding); }
    protected override string GetKeyForItem(System.Workflow.ComponentModel.WorkflowParameterBinding item) { return default(string); }
    protected override void InsertItem(int index, System.Workflow.ComponentModel.WorkflowParameterBinding item) { }
    protected override void RemoveItem(int index) { }
    protected override void SetItem(int index, System.Workflow.ComponentModel.WorkflowParameterBinding item) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class WorkflowTerminatedException : System.Exception {
    public WorkflowTerminatedException() { }
    public WorkflowTerminatedException(string message) { }
    public WorkflowTerminatedException(string message, System.Exception exception) { }
  }
  [System.ComponentModel.BrowsableAttribute(true)]
  [System.ComponentModel.Design.Serialization.DesignerSerializerAttribute(typeof(System.Workflow.ComponentModel.Serialization.DependencyObjectCodeDomSerializer), typeof(System.ComponentModel.Design.Serialization.CodeDomSerializer))]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class WorkflowTransactionOptions : System.Workflow.ComponentModel.DependencyObject {
    public static readonly System.Workflow.ComponentModel.DependencyProperty IsolationLevelProperty;
    public static readonly System.Workflow.ComponentModel.DependencyProperty TimeoutDurationProperty;
    public WorkflowTransactionOptions() { }
    [SRCategoryAttribute("Activity")]
    [SRDescriptionAttribute("IsolationLevelDescr")]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    public System.Transactions.IsolationLevel IsolationLevel { get { return default(System.Transactions.IsolationLevel); } set { } }
    [SRCategoryAttribute("Activity")]
    [SRDescriptionAttribute("TimeoutDescr")]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.TimeSpan), "0:0:30")]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Workflow.ComponentModel.TimeoutDurationConverter))]
    public System.TimeSpan TimeoutDuration { get { return default(System.TimeSpan); } set { } }
  }
}
namespace System.Workflow.ComponentModel.Compiler {
  [System.FlagsAttribute]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public enum AccessTypes {
    Read = 1,
    ReadWrite = 3,
    Write = 2,
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class ActivityCodeGenerator {
    public ActivityCodeGenerator() { }
    public virtual void GenerateCode(System.Workflow.ComponentModel.Compiler.CodeGenerationManager manager, object obj) { }
    protected System.CodeDom.CodeTypeDeclaration GetCodeTypeDeclaration(System.Workflow.ComponentModel.Compiler.CodeGenerationManager manager, string fullClassName) { return default(System.CodeDom.CodeTypeDeclaration); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(1028), AllowMultiple=false, Inherited=true)]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class ActivityCodeGeneratorAttribute : System.Attribute {
    public ActivityCodeGeneratorAttribute(string codeGeneratorTypeName) { }
    public ActivityCodeGeneratorAttribute(System.Type codeGeneratorType) { }
    public string CodeGeneratorTypeName { get { return default(string); } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class ActivityValidator : System.Workflow.ComponentModel.Compiler.DependencyObjectValidator {
    public ActivityValidator() { }
    public override System.Workflow.ComponentModel.Compiler.ValidationErrorCollection Validate(System.Workflow.ComponentModel.Compiler.ValidationManager manager, object obj) { return default(System.Workflow.ComponentModel.Compiler.ValidationErrorCollection); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(1028), AllowMultiple=false, Inherited=true)]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class ActivityValidatorAttribute : System.Attribute {
    public ActivityValidatorAttribute(string validatorTypeName) { }
    public ActivityValidatorAttribute(System.Type validatorType) { }
    public string ValidatorTypeName { get { return default(string); } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class AttributeInfo {
    internal AttributeInfo() { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Object> ArgumentValues { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Object>); } }
    public System.Type AttributeType { get { return default(System.Type); } }
    public bool Creatable { get { return default(bool); } }
    public System.Attribute CreateAttribute() { return default(System.Attribute); }
    public object GetArgumentValueAs(System.IServiceProvider serviceProvider, int argumentIndex, System.Type requestedType) { return default(object); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(132), AllowMultiple=true)]
  [System.CLSCompliantAttribute(false)]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class AttributeInfoAttribute : System.Attribute {
    internal AttributeInfoAttribute() { }
    public System.Workflow.ComponentModel.Compiler.AttributeInfo AttributeInfo { get { return default(System.Workflow.ComponentModel.Compiler.AttributeInfo); } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Xml.Serialization.XmlTypeAttribute("authorizedType")]
  public sealed partial class AuthorizedType {
    public AuthorizedType() { }
    [System.Xml.Serialization.XmlAttributeAttribute]
    public string Assembly { get { return default(string); } set { } }
    [System.Xml.Serialization.XmlAttributeAttribute]
    public string Authorized { get { return default(string); } set { } }
    [System.Xml.Serialization.XmlAttributeAttribute]
    public string Namespace { get { return default(string); } set { } }
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Text.RegularExpressions.Regex RegularExpression { get { return default(System.Text.RegularExpressions.Regex); } }
    [System.Xml.Serialization.XmlAttributeAttribute]
    public string TypeName { get { return default(string); } set { } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class BindValidationContext {
    public BindValidationContext(System.Type targetType) { }
    public BindValidationContext(System.Type targetType, System.Workflow.ComponentModel.Compiler.AccessTypes access) { }
    public System.Workflow.ComponentModel.Compiler.AccessTypes Access { get { return default(System.Workflow.ComponentModel.Compiler.AccessTypes); } }
    public System.Type TargetType { get { return default(System.Type); } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class CodeGenerationManager : System.IServiceProvider {
    public CodeGenerationManager(System.IServiceProvider serviceProvider) { }
    public System.ComponentModel.Design.Serialization.ContextStack Context { get { return default(System.ComponentModel.Design.Serialization.ContextStack); } }
    public System.Workflow.ComponentModel.Compiler.ActivityCodeGenerator[] GetCodeGenerators(System.Type type) { return default(System.Workflow.ComponentModel.Compiler.ActivityCodeGenerator[]); }
    public object GetService(System.Type serviceType) { return default(object); }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class CompileWorkflowCleanupTask : Microsoft.Build.Utilities.Task, Microsoft.Build.Framework.ITask {
    public CompileWorkflowCleanupTask() { }
    public Microsoft.Build.Framework.ITaskItem[] TemporaryFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public override bool Execute() { return default(bool); }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class CompileWorkflowTask : Microsoft.Build.Utilities.Task, Microsoft.Build.Framework.ITask {
    public CompileWorkflowTask() { }
    public string AssemblyName { get { return default(string); } set { } }
    public bool BuildingProject { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Microsoft.Build.Framework.ITaskItem[] CompilationOptions { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public bool DelaySign { get { return default(bool); } set { } }
    public new object HostObject { get { return default(object); } }
    public string Imports { get { return default(string); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public string KeepTemporaryFiles { get { return default(string); } }
    public string KeyContainer { get { return default(string); } set { } }
    public string KeyFile { get { return default(string); } set { } }
    Microsoft.Build.Framework.ITaskHost Microsoft.Build.Framework.ITask.HostObject { get { return default(Microsoft.Build.Framework.ITaskHost); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public Microsoft.Build.Framework.ITaskItem[] OutputFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } }
    public string ProjectDirectory { get { return default(string); } set { } }
    public string ProjectExtension { get { return default(string); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] ReferenceFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] ResourceFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public string RootNamespace { get { return default(string); } set { } }
    public Microsoft.Build.Framework.ITaskItem[] SourceCodeFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public string TargetFramework { get { return default(string); } set { } }
    [Microsoft.Build.Framework.OutputAttribute]
    public System.String[] TemporaryFiles { get { return default(System.String[]); } }
    public Microsoft.Build.Framework.ITaskItem[] WorkflowMarkupFiles { get { return default(Microsoft.Build.Framework.ITaskItem[]); } set { } }
    public override bool Execute() { return default(bool); }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class CompositeActivityCodeGenerator : System.Workflow.ComponentModel.Compiler.ActivityCodeGenerator {
    public CompositeActivityCodeGenerator() { }
    public override void GenerateCode(System.Workflow.ComponentModel.Compiler.CodeGenerationManager manager, object obj) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class CompositeActivityValidator : System.Workflow.ComponentModel.Compiler.ActivityValidator {
    public CompositeActivityValidator() { }
    public override System.Workflow.ComponentModel.Compiler.ValidationErrorCollection Validate(System.Workflow.ComponentModel.Compiler.ValidationManager manager, object obj) { return default(System.Workflow.ComponentModel.Compiler.ValidationErrorCollection); }
    public override System.Workflow.ComponentModel.Compiler.ValidationError ValidateActivityChange(System.Workflow.ComponentModel.Activity activity, System.Workflow.ComponentModel.ActivityChangeAction action) { return default(System.Workflow.ComponentModel.Compiler.ValidationError); }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class ConditionValidator : System.Workflow.ComponentModel.Compiler.DependencyObjectValidator {
    public ConditionValidator() { }
    public override System.Workflow.ComponentModel.Compiler.ValidationErrorCollection Validate(System.Workflow.ComponentModel.Compiler.ValidationManager manager, object obj) { return default(System.Workflow.ComponentModel.Compiler.ValidationErrorCollection); }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class DependencyObjectValidator : System.Workflow.ComponentModel.Compiler.Validator {
    public DependencyObjectValidator() { }
    public override System.Workflow.ComponentModel.Compiler.ValidationErrorCollection Validate(System.Workflow.ComponentModel.Compiler.ValidationManager manager, object obj) { return default(System.Workflow.ComponentModel.Compiler.ValidationErrorCollection); }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial interface ITypeProvider {
    System.Reflection.Assembly LocalAssembly { get; }
    System.Collections.Generic.ICollection<System.Reflection.Assembly> ReferencedAssemblies { get; }
    System.Collections.Generic.IDictionary<System.Object, System.Exception> TypeLoadErrors { get; }
    event System.EventHandler TypeLoadErrorsChanged;
    event System.EventHandler TypesChanged;
    System.Type GetType(string name);
    System.Type GetType(string name, bool throwOnError);
    System.Type[] GetTypes();
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial interface IWorkflowCompilerOptionsService {
    bool CheckTypes { get; }
    string Language { get; }
    string RootNamespace { get; }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class PropertyValidationContext {
    public PropertyValidationContext(object propertyOwner, System.Reflection.PropertyInfo propertyInfo, string propertyName) { }
    public PropertyValidationContext(object propertyOwner, System.Workflow.ComponentModel.DependencyProperty dependencyProperty) { }
    public object Property { get { return default(object); } }
    public string PropertyName { get { return default(string); } }
    public object PropertyOwner { get { return default(object); } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class TypeProvider : System.IDisposable, System.IServiceProvider, System.Workflow.ComponentModel.Compiler.ITypeProvider {
    public TypeProvider(System.IServiceProvider serviceProvider) { }
    public System.Func<System.Type, System.String> AssemblyNameResolver { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Func<System.Type, System.String>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Func<System.Reflection.PropertyInfo, System.Object, System.Boolean> IsSupportedPropertyResolver { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Func<System.Reflection.PropertyInfo, System.Object, System.Boolean>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Reflection.Assembly LocalAssembly { get { return default(System.Reflection.Assembly); } }
    public System.Collections.Generic.ICollection<System.Reflection.Assembly> ReferencedAssemblies { get { return default(System.Collections.Generic.ICollection<System.Reflection.Assembly>); } }
    public System.Collections.Generic.IDictionary<System.Object, System.Exception> TypeLoadErrors { get { return default(System.Collections.Generic.IDictionary<System.Object, System.Exception>); } }
    public event System.EventHandler TypeLoadErrorsChanged { add { } remove { } }
    public event System.EventHandler TypesChanged { add { } remove { } }
    public void AddAssembly(System.Reflection.Assembly assembly) { }
    public void AddAssemblyReference(string path) { }
    public void AddCodeCompileUnit(System.CodeDom.CodeCompileUnit codeCompileUnit) { }
    public void Dispose() { }
    public string GetAssemblyName(System.Type type) { return default(string); }
    public static System.String[] GetEnumNames(System.Type enumType) { return default(System.String[]); }
    public static System.Type GetEventHandlerType(System.Reflection.EventInfo eventInfo) { return default(System.Type); }
    public object GetService(System.Type serviceType) { return default(object); }
    public System.Type GetType(string name) { return default(System.Type); }
    public System.Type GetType(string name, bool throwOnError) { return default(System.Type); }
    public System.Type[] GetTypes() { return default(System.Type[]); }
    public static bool IsAssignable(System.Type toType, System.Type fromType) { return default(bool); }
    public static bool IsEnum(System.Type type) { return default(bool); }
    public static bool IsSubclassOf(System.Type subclass, System.Type superClass) { return default(bool); }
    public bool IsSupportedProperty(System.Reflection.PropertyInfo property, object declaringInstance) { return default(bool); }
    public void RefreshCodeCompileUnit(System.CodeDom.CodeCompileUnit codeCompileUnit, System.EventHandler refresher) { }
    public void RemoveAssembly(System.Reflection.Assembly assembly) { }
    public void RemoveAssemblyReference(string path) { }
    public void RemoveCodeCompileUnit(System.CodeDom.CodeCompileUnit codeCompileUnit) { }
    public void SetLocalAssembly(System.Reflection.Assembly assembly) { }
  }
  public sealed partial class ValidationError {
    public ValidationError(string errorText, int errorNumber) { }
    public ValidationError(string errorText, int errorNumber, bool isWarning) { }
    public ValidationError(string errorText, int errorNumber, bool isWarning, string propertyName) { }
    public int ErrorNumber { get { return default(int); } }
    public string ErrorText { get { return default(string); } }
    public bool IsWarning { get { return default(bool); } }
    public string PropertyName { get { return default(string); } set { } }
    public System.Collections.IDictionary UserData { get { return default(System.Collections.IDictionary); } }
    public static System.Workflow.ComponentModel.Compiler.ValidationError GetNotSetValidationError(string propertyName) { return default(System.Workflow.ComponentModel.Compiler.ValidationError); }
    public override string ToString() { return default(string); }
  }
  public sealed partial class ValidationErrorCollection : System.Collections.ObjectModel.Collection<System.Workflow.ComponentModel.Compiler.ValidationError> {
    public ValidationErrorCollection() { }
    public ValidationErrorCollection(System.Collections.Generic.IEnumerable<System.Workflow.ComponentModel.Compiler.ValidationError> value) { }
    public ValidationErrorCollection(System.Workflow.ComponentModel.Compiler.ValidationErrorCollection value) { }
    public bool HasErrors { get { return default(bool); } }
    public bool HasWarnings { get { return default(bool); } }
    public void AddRange(System.Collections.Generic.IEnumerable<System.Workflow.ComponentModel.Compiler.ValidationError> value) { }
    protected override void InsertItem(int index, System.Workflow.ComponentModel.Compiler.ValidationError item) { }
    protected override void SetItem(int index, System.Workflow.ComponentModel.Compiler.ValidationError item) { }
    public System.Workflow.ComponentModel.Compiler.ValidationError[] ToArray() { return default(System.Workflow.ComponentModel.Compiler.ValidationError[]); }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class ValidationManager : System.IServiceProvider {
    public ValidationManager(System.IServiceProvider serviceProvider) { }
    public ValidationManager(System.IServiceProvider serviceProvider, bool validateChildActivities) { }
    public System.ComponentModel.Design.Serialization.ContextStack Context { get { return default(System.ComponentModel.Design.Serialization.ContextStack); } }
    public bool ValidateChildActivities { get { return default(bool); } }
    public object GetService(System.Type serviceType) { return default(object); }
    public System.Workflow.ComponentModel.Compiler.Validator[] GetValidators(System.Type type) { return default(System.Workflow.ComponentModel.Compiler.Validator[]); }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public enum ValidationOption {
    None = 0,
    Optional = 1,
    Required = 2,
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(640), AllowMultiple=false, Inherited=true)]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class ValidationOptionAttribute : System.Attribute {
    public ValidationOptionAttribute(System.Workflow.ComponentModel.Compiler.ValidationOption validationOption) { }
    public System.Workflow.ComponentModel.Compiler.ValidationOption ValidationOption { get { return default(System.Workflow.ComponentModel.Compiler.ValidationOption); } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class Validator {
    public Validator() { }
    protected string GetFullPropertyName(System.Workflow.ComponentModel.Compiler.ValidationManager manager) { return default(string); }
    public virtual System.Workflow.ComponentModel.Compiler.ValidationErrorCollection Validate(System.Workflow.ComponentModel.Compiler.ValidationManager manager, object obj) { return default(System.Workflow.ComponentModel.Compiler.ValidationErrorCollection); }
    public virtual System.Workflow.ComponentModel.Compiler.ValidationError ValidateActivityChange(System.Workflow.ComponentModel.Activity activity, System.Workflow.ComponentModel.ActivityChangeAction action) { return default(System.Workflow.ComponentModel.Compiler.ValidationError); }
    public virtual System.Workflow.ComponentModel.Compiler.ValidationErrorCollection ValidateProperties(System.Workflow.ComponentModel.Compiler.ValidationManager manager, object obj) { return default(System.Workflow.ComponentModel.Compiler.ValidationErrorCollection); }
    protected internal System.Workflow.ComponentModel.Compiler.ValidationErrorCollection ValidateProperty(System.Reflection.PropertyInfo propertyInfo, object propertyOwner, object propertyValue, System.Workflow.ComponentModel.Compiler.ValidationManager manager) { return default(System.Workflow.ComponentModel.Compiler.ValidationErrorCollection); }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class WorkflowCompilationContext {
    internal WorkflowCompilationContext() { }
    public bool CheckTypes { get { return default(bool); } }
    public static System.Workflow.ComponentModel.Compiler.WorkflowCompilationContext Current { get { return default(System.Workflow.ComponentModel.Compiler.WorkflowCompilationContext); } }
    public string Language { get { return default(string); } }
    public string RootNamespace { get { return default(string); } }
    public static System.IDisposable CreateScope(System.IServiceProvider serviceProvider) { return default(System.IDisposable); }
    public System.Collections.Generic.IList<System.Workflow.ComponentModel.Compiler.AuthorizedType> GetAuthorizedTypes() { return default(System.Collections.Generic.IList<System.Workflow.ComponentModel.Compiler.AuthorizedType>); }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class WorkflowCompiler {
    public WorkflowCompiler() { }
    public System.Workflow.ComponentModel.Compiler.WorkflowCompilerResults Compile(System.Workflow.ComponentModel.Compiler.WorkflowCompilerParameters parameters, params System.String[] files) { return default(System.Workflow.ComponentModel.Compiler.WorkflowCompilerResults); }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class WorkflowCompilerError : System.CodeDom.Compiler.CompilerError {
    public WorkflowCompilerError() { }
    public WorkflowCompilerError(string fileName, int line, int column, string errorNumber, string errorText) { }
    public WorkflowCompilerError(string fileName, System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializationException exception) { }
    public string PropertyName { get { return default(string); } set { } }
    public System.Collections.IDictionary UserData { get { return default(System.Collections.IDictionary); } }
    public override string ToString() { return default(string); }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class WorkflowCompilerOptionsService : System.Workflow.ComponentModel.Compiler.IWorkflowCompilerOptionsService {
    public WorkflowCompilerOptionsService() { }
    public virtual bool CheckTypes { get { return default(bool); } }
    public virtual string Language { get { return default(string); } }
    public virtual string RootNamespace { get { return default(string); } }
    public virtual string TargetFrameworkMoniker { get { return default(string); } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class WorkflowCompilerParameters : System.CodeDom.Compiler.CompilerParameters {
    public WorkflowCompilerParameters() { }
    public WorkflowCompilerParameters(System.String[] assemblyNames) { }
    public WorkflowCompilerParameters(System.String[] assemblyNames, string outputName) { }
    public WorkflowCompilerParameters(System.String[] assemblyNames, string outputName, bool includeDebugInformation) { }
    public WorkflowCompilerParameters(System.Workflow.ComponentModel.Compiler.WorkflowCompilerParameters parameters) { }
    public new string CompilerOptions { get { return default(string); } set { } }
    public bool GenerateCodeCompileUnitOnly { get { return default(bool); } set { } }
    public string LanguageToUse { get { return default(string); } set { } }
    public System.Collections.Specialized.StringCollection LibraryPaths { get { return default(System.Collections.Specialized.StringCollection); } }
    public System.Collections.Generic.IList<System.CodeDom.CodeCompileUnit> UserCodeCompileUnits { get { return default(System.Collections.Generic.IList<System.CodeDom.CodeCompileUnit>); } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class WorkflowCompilerResults : System.CodeDom.Compiler.CompilerResults {
    internal WorkflowCompilerResults() : base (default(System.CodeDom.Compiler.TempFileCollection)) { }
    public System.CodeDom.CodeCompileUnit CompiledUnit { get { return default(System.CodeDom.CodeCompileUnit); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false)]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class WorkflowMarkupSourceAttribute : System.Attribute {
    public WorkflowMarkupSourceAttribute(string fileName, string md5Digest) { }
    public string FileName { get { return default(string); } }
    public string MD5Digest { get { return default(string); } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class WorkflowValidationFailedException : System.Exception {
    public WorkflowValidationFailedException() { }
    public WorkflowValidationFailedException(string message) { }
    public WorkflowValidationFailedException(string message, System.Exception innerException) { }
    public WorkflowValidationFailedException(string message, System.Workflow.ComponentModel.Compiler.ValidationErrorCollection errors) { }
    public System.Workflow.ComponentModel.Compiler.ValidationErrorCollection Errors { get { return default(System.Workflow.ComponentModel.Compiler.ValidationErrorCollection); } }
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
}
namespace System.Workflow.ComponentModel.Design {
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class ActivityBindTypeConverter : System.ComponentModel.TypeConverter {
    public ActivityBindTypeConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object valueToConvert) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
    public override System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public override bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { return default(System.ComponentModel.TypeConverter.StandardValuesCollection); }
    public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class ActivityChangedEventArgs : System.EventArgs {
    public ActivityChangedEventArgs(System.Workflow.ComponentModel.Activity activity, System.ComponentModel.MemberDescriptor member, object oldValue, object newValue) { }
    public System.Workflow.ComponentModel.Activity Activity { get { return default(System.Workflow.ComponentModel.Activity); } }
    public System.ComponentModel.MemberDescriptor Member { get { return default(System.ComponentModel.MemberDescriptor); } }
    public object NewValue { get { return default(object); } }
    public object OldValue { get { return default(object); } }
  }
  [SRCategoryAttribute("ActivityDesigners", "System.Workflow.ComponentModel.Design.DesignerResources")]
  [System.ComponentModel.Design.Serialization.DesignerSerializerAttribute(typeof(System.Workflow.ComponentModel.Design.ActivityDesignerLayoutSerializer), typeof(System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializer))]
  [System.ComponentModel.ToolboxItemFilterAttribute("Microsoft.Workflow.VSDesigner", (System.ComponentModel.ToolboxItemFilterType)(3))]
  [System.ComponentModel.ToolboxItemFilterAttribute("System.Workflow.ComponentModel.Design.ActivitySet", (System.ComponentModel.ToolboxItemFilterType)(1))]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Workflow.ComponentModel.Design.ActivityDesignerThemeAttribute(typeof(System.Workflow.ComponentModel.Design.ActivityDesignerTheme))]
  public partial class ActivityDesigner : System.ComponentModel.Design.IDesigner, System.ComponentModel.Design.IDesignerFilter, System.ComponentModel.Design.IRootDesigner, System.Drawing.Design.IToolboxUser, System.IDisposable, System.Workflow.ComponentModel.Design.IPersistUIState, System.Workflow.ComponentModel.Design.IWorkflowRootDesigner {
    public ActivityDesigner() { }
    public virtual System.Windows.Forms.AccessibleObject AccessibilityObject { get { return default(System.Windows.Forms.AccessibleObject); } }
    public System.Workflow.ComponentModel.Activity Activity { get { return default(System.Workflow.ComponentModel.Activity); } }
    public System.Drawing.Rectangle Bounds { get { return default(System.Drawing.Rectangle); } }
    protected internal virtual System.Collections.ObjectModel.ReadOnlyCollection<System.Workflow.ComponentModel.Design.DesignerAction> DesignerActions { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Workflow.ComponentModel.Design.DesignerAction>); } }
    public System.Workflow.ComponentModel.Design.ActivityDesignerTheme DesignerTheme { get { return default(System.Workflow.ComponentModel.Design.ActivityDesignerTheme); } }
    protected internal virtual bool EnableVisualResizing { get { return default(bool); } }
    protected internal virtual System.Workflow.ComponentModel.Design.ActivityDesignerGlyphCollection Glyphs { get { return default(System.Workflow.ComponentModel.Design.ActivityDesignerGlyphCollection); } }
    public virtual System.Drawing.Image Image { get { return default(System.Drawing.Image); } protected set { } }
    protected virtual System.Drawing.Rectangle ImageRectangle { get { return default(System.Drawing.Rectangle); } }
    protected virtual System.Workflow.ComponentModel.Design.CompositeActivityDesigner InvokingDesigner { get { return default(System.Workflow.ComponentModel.Design.CompositeActivityDesigner); } set { } }
    public bool IsLocked { get { return default(bool); } }
    public bool IsPrimarySelection { get { return default(bool); } }
    public bool IsRootDesigner { get { return default(bool); } }
    public bool IsSelected { get { return default(bool); } }
    public virtual bool IsVisible { get { return default(bool); } }
    public virtual System.Drawing.Point Location { get { return default(System.Drawing.Point); } set { } }
    protected virtual System.Collections.ObjectModel.ReadOnlyCollection<System.Workflow.ComponentModel.Design.WorkflowDesignerMessageFilter> MessageFilters { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Workflow.ComponentModel.Design.WorkflowDesignerMessageFilter>); } }
    public virtual System.Drawing.Size MinimumSize { get { return default(System.Drawing.Size); } }
    public System.Workflow.ComponentModel.Design.CompositeActivityDesigner ParentDesigner { get { return default(System.Workflow.ComponentModel.Design.CompositeActivityDesigner); } }
    protected internal System.Workflow.ComponentModel.Design.WorkflowView ParentView { get { return default(System.Workflow.ComponentModel.Design.WorkflowView); } }
    protected virtual bool ShowSmartTag { get { return default(bool); } }
    public virtual System.Drawing.Size Size { get { return default(System.Drawing.Size); } set { } }
    protected virtual System.Drawing.Rectangle SmartTagRectangle { get { return default(System.Drawing.Rectangle); } }
    protected virtual System.Collections.ObjectModel.ReadOnlyCollection<System.Workflow.ComponentModel.Design.ActivityDesignerVerb> SmartTagVerbs { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Workflow.ComponentModel.Design.ActivityDesignerVerb>); } }
    System.ComponentModel.IComponent System.ComponentModel.Design.IDesigner.Component { get { return default(System.ComponentModel.IComponent); } }
    System.ComponentModel.Design.DesignerVerbCollection System.ComponentModel.Design.IDesigner.Verbs { get { return default(System.ComponentModel.Design.DesignerVerbCollection); } }
    System.ComponentModel.Design.ViewTechnology[] System.ComponentModel.Design.IRootDesigner.SupportedTechnologies { get { return default(System.ComponentModel.Design.ViewTechnology[]); } }
    System.Workflow.ComponentModel.Design.CompositeActivityDesigner System.Workflow.ComponentModel.Design.IWorkflowRootDesigner.InvokingDesigner { get { return default(System.Workflow.ComponentModel.Design.CompositeActivityDesigner); } set { } }
    System.Collections.ObjectModel.ReadOnlyCollection<System.Workflow.ComponentModel.Design.WorkflowDesignerMessageFilter> System.Workflow.ComponentModel.Design.IWorkflowRootDesigner.MessageFilters { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Workflow.ComponentModel.Design.WorkflowDesignerMessageFilter>); } }
    bool System.Workflow.ComponentModel.Design.IWorkflowRootDesigner.SupportsLayoutPersistence { get { return default(bool); } }
    public virtual string Text { get { return default(string); } protected set { } }
    protected virtual System.Drawing.Rectangle TextRectangle { get { return default(System.Drawing.Rectangle); } }
    protected virtual System.Workflow.ComponentModel.Design.ActivityDesignerVerbCollection Verbs { get { return default(System.Workflow.ComponentModel.Design.ActivityDesignerVerbCollection); } }
    public virtual bool CanBeParentedTo(System.Workflow.ComponentModel.Design.CompositeActivityDesigner parentActivityDesigner) { return default(bool); }
    protected virtual bool CanConnect(System.Workflow.ComponentModel.Design.ConnectionPoint source, System.Workflow.ComponentModel.Design.ConnectionPoint target) { return default(bool); }
    protected virtual System.Workflow.ComponentModel.Design.WorkflowView CreateView(System.ComponentModel.Design.ViewTechnology viewTechnology) { return default(System.Workflow.ComponentModel.Design.WorkflowView); }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    protected virtual void DoDefaultAction() { }
    public void EnsureVisible() { }
    ~ActivityDesigner() { }
    public virtual System.Collections.ObjectModel.ReadOnlyCollection<System.Workflow.ComponentModel.Design.ConnectionPoint> GetConnectionPoints(System.Workflow.ComponentModel.Design.DesignerEdges edges) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Workflow.ComponentModel.Design.ConnectionPoint>); }
    protected internal virtual System.Collections.ObjectModel.ReadOnlyCollection<System.Drawing.Point> GetConnections(System.Workflow.ComponentModel.Design.DesignerEdges edges) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Drawing.Point>); }
    public System.Drawing.Image GetPreviewImage(System.Drawing.Graphics compatibleGraphics) { return default(System.Drawing.Image); }
    public static System.Workflow.ComponentModel.Design.ActivityDesigner GetRootDesigner(System.IServiceProvider serviceProvider) { return default(System.Workflow.ComponentModel.Design.ActivityDesigner); }
    protected object GetService(System.Type serviceType) { return default(object); }
    public virtual System.Workflow.ComponentModel.Design.HitTestInfo HitTest(System.Drawing.Point point) { return default(System.Workflow.ComponentModel.Design.HitTestInfo); }
    protected virtual void Initialize(System.Workflow.ComponentModel.Activity activity) { }
    public void Invalidate() { }
    public void Invalidate(System.Drawing.Rectangle rectangle) { }
    public static bool IsCommentedActivity(System.Workflow.ComponentModel.Activity activity) { return default(bool); }
    protected virtual bool IsSupportedActivityType(System.Type activityType) { return default(bool); }
    protected virtual void LoadViewState(System.IO.BinaryReader reader) { }
    protected virtual void OnActivityChanged(System.Workflow.ComponentModel.Design.ActivityChangedEventArgs e) { }
    protected virtual void OnBeginResizing(System.Workflow.ComponentModel.Design.ActivityDesignerResizeEventArgs e) { }
    protected virtual void OnConnected(System.Workflow.ComponentModel.Design.ConnectionPoint source, System.Workflow.ComponentModel.Design.ConnectionPoint target) { }
    protected virtual void OnDragDrop(System.Workflow.ComponentModel.Design.ActivityDragEventArgs e) { }
    protected virtual void OnDragEnter(System.Workflow.ComponentModel.Design.ActivityDragEventArgs e) { }
    protected virtual void OnDragLeave() { }
    protected virtual void OnDragOver(System.Workflow.ComponentModel.Design.ActivityDragEventArgs e) { }
    protected virtual void OnEndResizing() { }
    protected internal virtual void OnExecuteDesignerAction(System.Workflow.ComponentModel.Design.DesignerAction designerAction) { }
    protected virtual void OnGiveFeedback(System.Windows.Forms.GiveFeedbackEventArgs e) { }
    protected virtual void OnKeyDown(System.Windows.Forms.KeyEventArgs e) { }
    protected virtual void OnKeyUp(System.Windows.Forms.KeyEventArgs e) { }
    protected virtual void OnLayoutPosition(System.Workflow.ComponentModel.Design.ActivityDesignerLayoutEventArgs e) { }
    protected virtual System.Drawing.Size OnLayoutSize(System.Workflow.ComponentModel.Design.ActivityDesignerLayoutEventArgs e) { return default(System.Drawing.Size); }
    protected virtual void OnMouseCaptureChanged() { }
    protected virtual void OnMouseDoubleClick(System.Windows.Forms.MouseEventArgs e) { }
    protected virtual void OnMouseDown(System.Windows.Forms.MouseEventArgs e) { }
    protected virtual void OnMouseDragBegin(System.Drawing.Point initialDragPoint, System.Windows.Forms.MouseEventArgs e) { }
    protected virtual void OnMouseDragEnd() { }
    protected virtual void OnMouseDragMove(System.Windows.Forms.MouseEventArgs e) { }
    protected virtual void OnMouseEnter(System.Windows.Forms.MouseEventArgs e) { }
    protected virtual void OnMouseHover(System.Windows.Forms.MouseEventArgs e) { }
    protected virtual void OnMouseLeave() { }
    protected virtual void OnMouseMove(System.Windows.Forms.MouseEventArgs e) { }
    protected virtual void OnMouseUp(System.Windows.Forms.MouseEventArgs e) { }
    protected virtual void OnPaint(System.Workflow.ComponentModel.Design.ActivityDesignerPaintEventArgs e) { }
    protected virtual void OnProcessMessage(System.Windows.Forms.Message message) { }
    protected virtual void OnQueryContinueDrag(System.Windows.Forms.QueryContinueDragEventArgs e) { }
    protected virtual void OnResizing(System.Workflow.ComponentModel.Design.ActivityDesignerResizeEventArgs e) { }
    protected virtual void OnScroll(System.Windows.Forms.ScrollBar sender, int value) { }
    protected virtual void OnShowSmartTagVerbs(System.Drawing.Point smartTagPoint) { }
    protected virtual void OnSmartTagVisibilityChanged(bool visible) { }
    protected virtual void OnThemeChange(System.Workflow.ComponentModel.Design.ActivityDesignerTheme newTheme) { }
    protected void PerformLayout() { }
    protected System.Drawing.Point PointToLogical(System.Drawing.Point point) { return default(System.Drawing.Point); }
    protected System.Drawing.Point PointToScreen(System.Drawing.Point point) { return default(System.Drawing.Point); }
    protected virtual void PostFilterAttributes(System.Collections.IDictionary attributes) { }
    protected virtual void PostFilterEvents(System.Collections.IDictionary events) { }
    protected virtual void PostFilterProperties(System.Collections.IDictionary properties) { }
    protected virtual void PreFilterAttributes(System.Collections.IDictionary attributes) { }
    protected virtual void PreFilterEvents(System.Collections.IDictionary events) { }
    protected virtual void PreFilterProperties(System.Collections.IDictionary properties) { }
    protected System.Drawing.Rectangle RectangleToLogical(System.Drawing.Rectangle rectangle) { return default(System.Drawing.Rectangle); }
    protected System.Drawing.Rectangle RectangleToScreen(System.Drawing.Rectangle rectangle) { return default(System.Drawing.Rectangle); }
    protected internal virtual void RefreshDesignerActions() { }
    protected void RefreshDesignerVerbs() { }
    protected virtual void SaveViewState(System.IO.BinaryWriter writer) { }
    protected void ShowInfoTip(string infoTip) { }
    protected void ShowInfoTip(string title, string infoTip) { }
    protected void ShowInPlaceTip(string infoTip, System.Drawing.Rectangle rectangle) { }
    void System.ComponentModel.Design.IDesigner.DoDefaultAction() { }
    void System.ComponentModel.Design.IDesigner.Initialize(System.ComponentModel.IComponent component) { }
    void System.ComponentModel.Design.IDesignerFilter.PostFilterAttributes(System.Collections.IDictionary attributes) { }
    void System.ComponentModel.Design.IDesignerFilter.PostFilterEvents(System.Collections.IDictionary events) { }
    void System.ComponentModel.Design.IDesignerFilter.PostFilterProperties(System.Collections.IDictionary properties) { }
    void System.ComponentModel.Design.IDesignerFilter.PreFilterAttributes(System.Collections.IDictionary attributes) { }
    void System.ComponentModel.Design.IDesignerFilter.PreFilterEvents(System.Collections.IDictionary events) { }
    void System.ComponentModel.Design.IDesignerFilter.PreFilterProperties(System.Collections.IDictionary properties) { }
    object System.ComponentModel.Design.IRootDesigner.GetView(System.ComponentModel.Design.ViewTechnology technology) { return default(object); }
    bool System.Drawing.Design.IToolboxUser.GetToolSupported(System.Drawing.Design.ToolboxItem toolboxItem) { return default(bool); }
    void System.Drawing.Design.IToolboxUser.ToolPicked(System.Drawing.Design.ToolboxItem toolboxItem) { }
    void System.Workflow.ComponentModel.Design.IPersistUIState.LoadViewState(System.IO.BinaryReader reader) { }
    void System.Workflow.ComponentModel.Design.IPersistUIState.SaveViewState(System.IO.BinaryWriter writer) { }
    bool System.Workflow.ComponentModel.Design.IWorkflowRootDesigner.IsSupportedActivityType(System.Type activityType) { return default(bool); }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class ActivityDesignerAccessibleObject : System.Windows.Forms.AccessibleObject {
    public ActivityDesignerAccessibleObject(System.Workflow.ComponentModel.Design.ActivityDesigner activityDesigner) { }
    protected System.Workflow.ComponentModel.Design.ActivityDesigner ActivityDesigner { get { return default(System.Workflow.ComponentModel.Design.ActivityDesigner); } }
    public override System.Drawing.Rectangle Bounds { get { return default(System.Drawing.Rectangle); } }
    public override string DefaultAction { get { return default(string); } }
    public override string Description { get { return default(string); } }
    public override string Help { get { return default(string); } }
    public override string Name { get { return default(string); } set { } }
    public override System.Windows.Forms.AccessibleObject Parent { get { return default(System.Windows.Forms.AccessibleObject); } }
    public override System.Windows.Forms.AccessibleRole Role { get { return default(System.Windows.Forms.AccessibleRole); } }
    public override System.Windows.Forms.AccessibleStates State { get { return default(System.Windows.Forms.AccessibleStates); } }
    public override void DoDefaultAction() { }
    protected object GetService(System.Type serviceType) { return default(object); }
    public override System.Windows.Forms.AccessibleObject Navigate(System.Windows.Forms.AccessibleNavigation navdir) { return default(System.Windows.Forms.AccessibleObject); }
    public override void Select(System.Windows.Forms.AccessibleSelection flags) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class ActivityDesignerGlyphCollection : System.Collections.Generic.List<System.Workflow.ComponentModel.Design.DesignerGlyph> {
    public ActivityDesignerGlyphCollection() { }
    public ActivityDesignerGlyphCollection(System.Collections.Generic.IEnumerable<System.Workflow.ComponentModel.Design.DesignerGlyph> glyphs) { }
    public ActivityDesignerGlyphCollection(System.Workflow.ComponentModel.Design.ActivityDesignerGlyphCollection glyphs) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class ActivityDesignerLayoutEventArgs : System.EventArgs {
    public ActivityDesignerLayoutEventArgs(System.Drawing.Graphics graphics, System.Workflow.ComponentModel.Design.ActivityDesignerTheme designerTheme) { }
    public System.Workflow.ComponentModel.Design.AmbientTheme AmbientTheme { get { return default(System.Workflow.ComponentModel.Design.AmbientTheme); } }
    public System.Workflow.ComponentModel.Design.ActivityDesignerTheme DesignerTheme { get { return default(System.Workflow.ComponentModel.Design.ActivityDesignerTheme); } }
    public System.Drawing.Graphics Graphics { get { return default(System.Drawing.Graphics); } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class ActivityDesignerLayoutSerializer : System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializer {
    public ActivityDesignerLayoutSerializer() { }
    protected override object CreateInstance(System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializationManager serializationManager, System.Type type) { return default(object); }
    protected internal override System.Reflection.PropertyInfo[] GetProperties(System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializationManager serializationManager, object obj) { return default(System.Reflection.PropertyInfo[]); }
    protected override void OnBeforeSerialize(System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializationManager serializationManager, object obj) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public static partial class ActivityDesignerPaint {
    public static void Draw3DButton(System.Drawing.Graphics graphics, System.Drawing.Image image, System.Drawing.Rectangle bounds, float transparency, System.Windows.Forms.ButtonState buttonState) { }
    public static void DrawExpandButton(System.Drawing.Graphics graphics, System.Drawing.Rectangle boundingRect, bool drawExpanded, System.Workflow.ComponentModel.Design.CompositeDesignerTheme compositeDesignerTheme) { }
    public static void DrawImage(System.Drawing.Graphics graphics, System.Drawing.Image image, System.Drawing.Rectangle destination, System.Drawing.Rectangle source, System.Workflow.ComponentModel.Design.DesignerContentAlignment alignment, float transparency, bool grayscale) { }
    public static void DrawImage(System.Drawing.Graphics graphics, System.Drawing.Image image, System.Drawing.Rectangle destination, System.Workflow.ComponentModel.Design.DesignerContentAlignment alignment) { }
    public static void DrawRoundedRectangle(System.Drawing.Graphics graphics, System.Drawing.Pen drawingPen, System.Drawing.Rectangle rectangle, int radius) { }
    public static void DrawText(System.Drawing.Graphics graphics, System.Drawing.Font font, string text, System.Drawing.Rectangle boundingRect, System.Drawing.StringAlignment alignment, System.Workflow.ComponentModel.Design.TextQuality textQuality, System.Drawing.Brush textBrush) { }
    public static System.Drawing.Drawing2D.GraphicsPath GetRoundedRectanglePath(System.Drawing.Rectangle rectangle, int radius) { return default(System.Drawing.Drawing2D.GraphicsPath); }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class ActivityDesignerPaintEventArgs : System.EventArgs {
    public ActivityDesignerPaintEventArgs(System.Drawing.Graphics graphics, System.Drawing.Rectangle clipRectangle, System.Drawing.Rectangle viewPort, System.Workflow.ComponentModel.Design.ActivityDesignerTheme designerTheme) { }
    public System.Workflow.ComponentModel.Design.AmbientTheme AmbientTheme { get { return default(System.Workflow.ComponentModel.Design.AmbientTheme); } }
    public System.Drawing.Rectangle ClipRectangle { get { return default(System.Drawing.Rectangle); } }
    public System.Workflow.ComponentModel.Design.ActivityDesignerTheme DesignerTheme { get { return default(System.Workflow.ComponentModel.Design.ActivityDesignerTheme); } }
    public System.Drawing.Graphics Graphics { get { return default(System.Drawing.Graphics); } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class ActivityDesignerResizeEventArgs : System.EventArgs {
    public ActivityDesignerResizeEventArgs(System.Workflow.ComponentModel.Design.DesignerEdges sizingEdge, System.Drawing.Rectangle newBounds) { }
    public System.Drawing.Rectangle Bounds { get { return default(System.Drawing.Rectangle); } }
    public System.Workflow.ComponentModel.Design.DesignerEdges SizingEdge { get { return default(System.Workflow.ComponentModel.Design.DesignerEdges); } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class ActivityDesignerTheme : System.Workflow.ComponentModel.Design.DesignerTheme {
    public ActivityDesignerTheme(System.Workflow.ComponentModel.Design.WorkflowTheme theme) : base (default(System.Workflow.ComponentModel.Design.WorkflowTheme)) { }
    [SRCategoryAttribute("BackgroundCategory", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [SRDescriptionAttribute("BackColorEndDesc", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [System.ComponentModel.EditorAttribute(typeof(System.Workflow.ComponentModel.Design.ColorPickerEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Workflow.ComponentModel.Design.ColorPickerConverter))]
    [System.Runtime.InteropServices.DispIdAttribute(6)]
    public virtual System.Drawing.Color BackColorEnd { get { return default(System.Drawing.Color); } set { } }
    [SRCategoryAttribute("BackgroundCategory", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [SRDescriptionAttribute("BackColorStartDesc", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [System.ComponentModel.EditorAttribute(typeof(System.Workflow.ComponentModel.Design.ColorPickerEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Workflow.ComponentModel.Design.ColorPickerConverter))]
    [System.Runtime.InteropServices.DispIdAttribute(5)]
    public virtual System.Drawing.Color BackColorStart { get { return default(System.Drawing.Color); } set { } }
    [SRCategoryAttribute("BackgroundCategory", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [SRDescriptionAttribute("BackgroundStyleDesc", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [System.Runtime.InteropServices.DispIdAttribute(7)]
    public virtual System.Drawing.Drawing2D.LinearGradientMode BackgroundStyle { get { return default(System.Drawing.Drawing2D.LinearGradientMode); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Drawing.Font BoldFont { get { return default(System.Drawing.Font); } }
    [SRCategoryAttribute("ForegroundCategory", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [SRDescriptionAttribute("BorderColorDesc", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [System.ComponentModel.EditorAttribute(typeof(System.Workflow.ComponentModel.Design.ColorPickerEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Workflow.ComponentModel.Design.ColorPickerConverter))]
    [System.Runtime.InteropServices.DispIdAttribute(3)]
    public virtual System.Drawing.Color BorderColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Drawing.Pen BorderPen { get { return default(System.Drawing.Pen); } }
    [SRCategoryAttribute("ForegroundCategory", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [SRDescriptionAttribute("BorderStyleDesc", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Workflow.ComponentModel.Design.FilteredEnumConverter))]
    [System.Runtime.InteropServices.DispIdAttribute(4)]
    public virtual System.Drawing.Drawing2D.DashStyle BorderStyle { get { return default(System.Drawing.Drawing2D.DashStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public int BorderWidth { get { return default(int); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Workflow.ComponentModel.Design.DesignerGeometry DesignerGeometry { get { return default(System.Workflow.ComponentModel.Design.DesignerGeometry); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Drawing.Image DesignerImage { get { return default(System.Drawing.Image); } }
    [SRCategoryAttribute("ForegroundCategory", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [SRDescriptionAttribute("ImageDesc", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [System.ComponentModel.EditorAttribute(typeof(System.Workflow.ComponentModel.Design.ImageBrowserEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.Runtime.InteropServices.DispIdAttribute(1)]
    public virtual string DesignerImagePath { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Drawing.Font Font { get { return default(System.Drawing.Font); } }
    [SRCategoryAttribute("ForegroundCategory", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [SRDescriptionAttribute("ForeColorDesc", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [System.ComponentModel.EditorAttribute(typeof(System.Workflow.ComponentModel.Design.ColorPickerEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Workflow.ComponentModel.Design.ColorPickerConverter))]
    [System.Runtime.InteropServices.DispIdAttribute(2)]
    public virtual System.Drawing.Color ForeColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Drawing.Brush ForegroundBrush { get { return default(System.Drawing.Brush); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Drawing.Pen ForegroundPen { get { return default(System.Drawing.Pen); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Drawing.Size ImageSize { get { return default(System.Drawing.Size); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Drawing.Size Size { get { return default(System.Drawing.Size); } }
    protected override void Dispose(bool disposing) { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Drawing.Brush GetBackgroundBrush(System.Drawing.Rectangle rectangle) { return default(System.Drawing.Brush); }
    public override void Initialize() { }
    public override void OnAmbientPropertyChanged(System.Workflow.ComponentModel.Design.AmbientProperty ambientProperty) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class ActivityDesignerThemeAttribute : System.Attribute {
    public ActivityDesignerThemeAttribute(System.Type designerThemeType) { }
    public System.Type DesignerThemeType { get { return default(System.Type); } }
    public string Xml { get { return default(string); } set { } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class ActivityDesignerVerb : System.ComponentModel.Design.DesignerVerb {
    public ActivityDesignerVerb(System.Workflow.ComponentModel.Design.ActivityDesigner activityDesigner, System.Workflow.ComponentModel.Design.DesignerVerbGroup verbGroup, string text, System.EventHandler invokeHandler) : base (default(string), default(System.EventHandler)) { }
    public ActivityDesignerVerb(System.Workflow.ComponentModel.Design.ActivityDesigner activityDesigner, System.Workflow.ComponentModel.Design.DesignerVerbGroup verbGroup, string text, System.EventHandler invokeHandler, System.EventHandler statusHandler) : base (default(string), default(System.EventHandler)) { }
    public override System.ComponentModel.Design.CommandID CommandID { get { return default(System.ComponentModel.Design.CommandID); } }
    public System.Workflow.ComponentModel.Design.DesignerVerbGroup Group { get { return default(System.Workflow.ComponentModel.Design.DesignerVerbGroup); } }
    public override int OleStatus { get { return default(int); } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
  public sealed partial class ActivityDesignerVerbCollection : System.ComponentModel.Design.DesignerVerbCollection {
    public ActivityDesignerVerbCollection() { }
    public ActivityDesignerVerbCollection(System.Collections.Generic.IEnumerable<System.Workflow.ComponentModel.Design.ActivityDesignerVerb> verbs) { }
    protected override void OnValidate(object value) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class ActivityDragEventArgs : System.Windows.Forms.DragEventArgs {
    internal ActivityDragEventArgs() : base (default(System.Windows.Forms.IDataObject), default(int), default(int), default(int), default(System.Windows.Forms.DragDropEffects), default(System.Windows.Forms.DragDropEffects)) { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Workflow.ComponentModel.Activity> Activities { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Workflow.ComponentModel.Activity>); } }
    public System.Drawing.Point DragImageSnapPoint { get { return default(System.Drawing.Point); } set { } }
    public System.Drawing.Point DragInitiationPoint { get { return default(System.Drawing.Point); } }
  }
  [SRCategoryAttribute("ActivityPreviewDesigners", "System.Workflow.ComponentModel.Design.DesignerResources")]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Workflow.ComponentModel.Design.ActivityDesignerThemeAttribute(typeof(System.Workflow.ComponentModel.Design.ActivityPreviewDesignerTheme))]
  public partial class ActivityPreviewDesigner : System.Workflow.ComponentModel.Design.SequentialActivityDesigner {
    public ActivityPreviewDesigner() { }
    public override System.Windows.Forms.AccessibleObject AccessibilityObject { get { return default(System.Windows.Forms.AccessibleObject); } }
    public override System.Collections.ObjectModel.ReadOnlyCollection<System.Workflow.ComponentModel.Design.ActivityDesigner> ContainedDesigners { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Workflow.ComponentModel.Design.ActivityDesigner>); } }
    protected override int CurrentDropTarget { get { return default(int); } set { } }
    public override object FirstSelectableObject { get { return default(object); } }
    protected internal override System.Workflow.ComponentModel.Design.ActivityDesignerGlyphCollection Glyphs { get { return default(System.Workflow.ComponentModel.Design.ActivityDesignerGlyphCollection); } }
    protected override string HelpText { get { return default(string); } set { } }
    public override object LastSelectableObject { get { return default(object); } }
    public override System.Drawing.Point Location { get { return default(System.Drawing.Point); } set { } }
    public System.Workflow.ComponentModel.Design.ActivityDesigner PreviewedDesigner { get { return default(System.Workflow.ComponentModel.Design.ActivityDesigner); } }
    public bool ShowPreview { get { return default(bool); } set { } }
    protected override System.Workflow.ComponentModel.Design.ActivityDesignerVerbCollection Verbs { get { return default(System.Workflow.ComponentModel.Design.ActivityDesignerVerbCollection); } }
    protected override void Dispose(bool disposing) { }
    public override void EnsureVisibleContainedDesigner(System.Workflow.ComponentModel.Design.ActivityDesigner containedDesigner) { }
    protected internal override System.Drawing.Rectangle[] GetConnectors() { return default(System.Drawing.Rectangle[]); }
    protected override System.Drawing.Rectangle[] GetDropTargets(System.Drawing.Point dropPoint) { return default(System.Drawing.Rectangle[]); }
    public override object GetNextSelectableObject(object obj, System.Workflow.ComponentModel.Design.DesignerNavigationDirection direction) { return default(object); }
    public override System.Workflow.ComponentModel.Design.HitTestInfo HitTest(System.Drawing.Point point) { return default(System.Workflow.ComponentModel.Design.HitTestInfo); }
    protected override void Initialize(System.Workflow.ComponentModel.Activity activity) { }
    public override bool IsContainedDesignerVisible(System.Workflow.ComponentModel.Design.ActivityDesigner containedDesigner) { return default(bool); }
    protected override void LoadViewState(System.IO.BinaryReader reader) { }
    protected override void OnContainedActivitiesChanged(System.Workflow.ComponentModel.ActivityCollectionChangeEventArgs listChangeArgs) { }
    protected override void OnDragEnter(System.Workflow.ComponentModel.Design.ActivityDragEventArgs e) { }
    protected override void OnDragOver(System.Workflow.ComponentModel.Design.ActivityDragEventArgs e) { }
    protected override void OnLayoutPosition(System.Workflow.ComponentModel.Design.ActivityDesignerLayoutEventArgs e) { }
    protected override System.Drawing.Size OnLayoutSize(System.Workflow.ComponentModel.Design.ActivityDesignerLayoutEventArgs e) { return default(System.Drawing.Size); }
    protected override void OnMouseDoubleClick(System.Windows.Forms.MouseEventArgs e) { }
    protected override void OnMouseDown(System.Windows.Forms.MouseEventArgs e) { }
    protected override void OnMouseLeave() { }
    protected override void OnMouseUp(System.Windows.Forms.MouseEventArgs e) { }
    protected override void OnPaint(System.Workflow.ComponentModel.Design.ActivityDesignerPaintEventArgs e) { }
    protected override void OnThemeChange(System.Workflow.ComponentModel.Design.ActivityDesignerTheme newTheme) { }
    protected internal override void RefreshDesignerActions() { }
    public void RefreshPreview() { }
    protected override void SaveViewState(System.IO.BinaryWriter writer) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class ActivityPreviewDesignerTheme : System.Workflow.ComponentModel.Design.CompositeDesignerTheme {
    public ActivityPreviewDesignerTheme(System.Workflow.ComponentModel.Design.WorkflowTheme theme) : base (default(System.Workflow.ComponentModel.Design.WorkflowTheme)) { }
    [SRCategoryAttribute("BackgroundCategory", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [SRDescriptionAttribute("PreviewBackColorDesc", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [System.ComponentModel.EditorAttribute(typeof(System.Workflow.ComponentModel.Design.ColorPickerEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Workflow.ComponentModel.Design.ColorPickerConverter))]
    [System.Runtime.InteropServices.DispIdAttribute(14)]
    public System.Drawing.Color PreviewBackColor { get { return default(System.Drawing.Color); } set { } }
    [SRCategoryAttribute("ForegroundCategory", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [SRDescriptionAttribute("PreviewBorderColorDesc", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [System.ComponentModel.EditorAttribute(typeof(System.Workflow.ComponentModel.Design.ColorPickerEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Workflow.ComponentModel.Design.ColorPickerConverter))]
    [System.Runtime.InteropServices.DispIdAttribute(15)]
    public System.Drawing.Color PreviewBorderColor { get { return default(System.Drawing.Color); } set { } }
    [SRCategoryAttribute("ForegroundCategory", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [SRDescriptionAttribute("PreviewForeColorDesc", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [System.ComponentModel.EditorAttribute(typeof(System.Workflow.ComponentModel.Design.ColorPickerEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Workflow.ComponentModel.Design.ColorPickerConverter))]
    [System.Runtime.InteropServices.DispIdAttribute(13)]
    public System.Drawing.Color PreviewForeColor { get { return default(System.Drawing.Color); } set { } }
    protected override void Dispose(bool disposing) { }
    public override void Initialize() { }
    public override void OnAmbientPropertyChanged(System.Workflow.ComponentModel.Design.AmbientProperty ambientProperty) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
  public partial class ActivityToolboxItem : System.Drawing.Design.ToolboxItem {
    public ActivityToolboxItem() { }
    protected ActivityToolboxItem(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public ActivityToolboxItem(System.Type type) { }
    protected override System.ComponentModel.IComponent[] CreateComponentsCore(System.ComponentModel.Design.IDesignerHost host) { return default(System.ComponentModel.IComponent[]); }
    public virtual System.ComponentModel.IComponent[] CreateComponentsWithUI(System.ComponentModel.Design.IDesignerHost host) { return default(System.ComponentModel.IComponent[]); }
    public static string GetToolboxDisplayName(System.Type activityType) { return default(string); }
    public static System.Drawing.Image GetToolboxImage(System.Type activityType) { return default(System.Drawing.Image); }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public enum AmbientProperty {
    DesignerSize = 0,
    OperatingSystemSetting = 1,
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class AmbientTheme : System.Workflow.ComponentModel.Design.DesignerTheme {
    public AmbientTheme(System.Workflow.ComponentModel.Design.WorkflowTheme theme) : base (default(System.Workflow.ComponentModel.Design.WorkflowTheme)) { }
    [SRCategoryAttribute("BackgroundCategory", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [SRDescriptionAttribute("WorkflowBackgroundDesc", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [System.ComponentModel.EditorAttribute(typeof(System.Workflow.ComponentModel.Design.ColorPickerEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Workflow.ComponentModel.Design.ColorPickerConverter))]
    [System.Runtime.InteropServices.DispIdAttribute(13)]
    public virtual System.Drawing.Color BackColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Drawing.Brush BackgroundBrush { get { return default(System.Drawing.Brush); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Drawing.Font BoldFont { get { return default(System.Drawing.Font); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public virtual int BorderWidth { get { return default(int); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Drawing.Brush CommentIndicatorBrush { get { return default(System.Drawing.Brush); } }
    [SRCategoryAttribute("ForegroundCategory", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [SRDescriptionAttribute("CommentColorDesc", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [System.ComponentModel.EditorAttribute(typeof(System.Workflow.ComponentModel.Design.ColorPickerEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Workflow.ComponentModel.Design.ColorPickerConverter))]
    [System.Runtime.InteropServices.DispIdAttribute(11)]
    public virtual System.Drawing.Color CommentIndicatorColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Drawing.Pen CommentIndicatorPen { get { return default(System.Drawing.Pen); } }
    [SRCategoryAttribute("ActivityAppearanceCategory", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [SRDescriptionAttribute("DesignerSizeDesc", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute((System.Workflow.ComponentModel.Design.DesignerSize)(1))]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Runtime.InteropServices.DispIdAttribute(20)]
    public virtual System.Workflow.ComponentModel.Design.DesignerSize DesignerSize { get { return default(System.Workflow.ComponentModel.Design.DesignerSize); } set { } }
    [SRCategoryAttribute("WorkflowAppearanceCategory", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [SRDescriptionAttribute("GrayscaleWorkflowDesc", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Runtime.InteropServices.DispIdAttribute(6)]
    public virtual bool DrawGrayscale { get { return default(bool); } set { } }
    [SRCategoryAttribute("ActivityAppearanceCategory", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [SRDescriptionAttribute("DrawRoundedDesignersDesc", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Runtime.InteropServices.DispIdAttribute(21)]
    public virtual bool DrawRounded { get { return default(bool); } set { } }
    [SRCategoryAttribute("WorkflowAppearanceCategory", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [SRDescriptionAttribute("WorkflowShadowDesc", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Runtime.InteropServices.DispIdAttribute(14)]
    public virtual bool DrawShadow { get { return default(bool); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Drawing.Brush DropIndicatorBrush { get { return default(System.Drawing.Brush); } }
    [SRCategoryAttribute("ForegroundCategory", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [SRDescriptionAttribute("DropHiliteDesc", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [System.ComponentModel.EditorAttribute(typeof(System.Workflow.ComponentModel.Design.ColorPickerEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Workflow.ComponentModel.Design.ColorPickerConverter))]
    [System.Runtime.InteropServices.DispIdAttribute(7)]
    public virtual System.Drawing.Color DropIndicatorColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Drawing.Pen DropIndicatorPen { get { return default(System.Drawing.Pen); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Drawing.Font Font { get { return default(System.Drawing.Font); } }
    [SRCategoryAttribute("WorkflowAppearanceCategory", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [SRDescriptionAttribute("FontDesc", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Workflow.ComponentModel.Design.FontFamilyConverter))]
    [System.Runtime.InteropServices.DispIdAttribute(1)]
    public virtual string FontName { get { return default(string); } set { } }
    [SRCategoryAttribute("ForegroundCategory", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [SRDescriptionAttribute("WorkflowForegroundDesc", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [System.ComponentModel.EditorAttribute(typeof(System.Workflow.ComponentModel.Design.ColorPickerEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Workflow.ComponentModel.Design.ColorPickerConverter))]
    [System.Runtime.InteropServices.DispIdAttribute(10)]
    public virtual System.Drawing.Color ForeColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Drawing.Brush ForegroundBrush { get { return default(System.Drawing.Brush); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Drawing.Pen ForegroundPen { get { return default(System.Drawing.Pen); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public virtual System.Drawing.Size GlyphSize { get { return default(System.Drawing.Size); } }
    [SRCategoryAttribute("BackgroundCategory", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [SRDescriptionAttribute("GridColorDesc", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [System.ComponentModel.EditorAttribute(typeof(System.Workflow.ComponentModel.Design.ColorPickerEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Workflow.ComponentModel.Design.ColorPickerConverter))]
    [System.Runtime.InteropServices.DispIdAttribute(19)]
    public virtual System.Drawing.Color GridColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public virtual System.Drawing.Size GridSize { get { return default(System.Drawing.Size); } }
    [SRCategoryAttribute("BackgroundCategory", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [SRDescriptionAttribute("GridStyleDesc", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [System.ComponentModel.DefaultValueAttribute((System.Drawing.Drawing2D.DashStyle)(1))]
    [System.Runtime.InteropServices.DispIdAttribute(18)]
    public virtual System.Drawing.Drawing2D.DashStyle GridStyle { get { return default(System.Drawing.Drawing2D.DashStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Drawing.Brush MajorGridBrush { get { return default(System.Drawing.Brush); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Drawing.Pen MajorGridPen { get { return default(System.Drawing.Pen); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public virtual System.Drawing.Size Margin { get { return default(System.Drawing.Size); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Drawing.Pen MinorGridPen { get { return default(System.Drawing.Pen); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Drawing.Brush ReadonlyIndicatorBrush { get { return default(System.Drawing.Brush); } }
    [SRCategoryAttribute("ForegroundCategory", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [SRDescriptionAttribute("LockColorDesc", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [System.ComponentModel.EditorAttribute(typeof(System.Workflow.ComponentModel.Design.ColorPickerEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Workflow.ComponentModel.Design.ColorPickerConverter))]
    [System.Runtime.InteropServices.DispIdAttribute(12)]
    public virtual System.Drawing.Color ReadonlyIndicatorColor { get { return default(System.Drawing.Color); } set { } }
    [SRCategoryAttribute("ForegroundCategory", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [SRDescriptionAttribute("SelectionForegroundDesc", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [System.ComponentModel.EditorAttribute(typeof(System.Workflow.ComponentModel.Design.ColorPickerEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Workflow.ComponentModel.Design.ColorPickerConverter))]
    [System.Runtime.InteropServices.DispIdAttribute(8)]
    public virtual System.Drawing.Color SelectionForeColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Drawing.Brush SelectionForegroundBrush { get { return default(System.Drawing.Brush); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Drawing.Pen SelectionForegroundPen { get { return default(System.Drawing.Pen); } }
    [SRCategoryAttribute("ForegroundCategory", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [SRDescriptionAttribute("SelectionPatternDesc", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [System.ComponentModel.EditorAttribute(typeof(System.Workflow.ComponentModel.Design.ColorPickerEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Workflow.ComponentModel.Design.ColorPickerConverter))]
    [System.Runtime.InteropServices.DispIdAttribute(9)]
    public virtual System.Drawing.Color SelectionPatternColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Drawing.Pen SelectionPatternPen { get { return default(System.Drawing.Pen); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public virtual System.Drawing.Size SelectionSize { get { return default(System.Drawing.Size); } }
    [SRCategoryAttribute("WorkflowAppearanceCategory", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [SRDescriptionAttribute("ShowConfigErrorDesc", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Runtime.InteropServices.DispIdAttribute(3)]
    public virtual bool ShowConfigErrors { get { return default(bool); } set { } }
    [SRCategoryAttribute("ActivityAppearanceCategory", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [SRDescriptionAttribute("DesignerBorderDesc", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Runtime.InteropServices.DispIdAttribute(24)]
    public virtual bool ShowDesignerBorder { get { return default(bool); } set { } }
    [SRCategoryAttribute("BackgroundCategory", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [SRDescriptionAttribute("ShowGridDesc", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Runtime.InteropServices.DispIdAttribute(17)]
    public virtual bool ShowGrid { get { return default(bool); } set { } }
    [SRCategoryAttribute("WorkflowAppearanceCategory", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [SRDescriptionAttribute("TextQualityDesc", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [System.ComponentModel.DefaultValueAttribute((System.Workflow.ComponentModel.Design.TextQuality)(0))]
    [System.Runtime.InteropServices.DispIdAttribute(2)]
    public virtual System.Workflow.ComponentModel.Design.TextQuality TextQuality { get { return default(System.Workflow.ComponentModel.Design.TextQuality); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public virtual bool UseOperatingSystemSettings { get { return default(bool); } }
    [SRCategoryAttribute("BackgroundCategory", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [SRDescriptionAttribute("WatermarkAlignmentDesc", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [System.ComponentModel.DefaultValueAttribute((System.Workflow.ComponentModel.Design.DesignerContentAlignment)(12))]
    [System.Runtime.InteropServices.DispIdAttribute(16)]
    public virtual System.Workflow.ComponentModel.Design.DesignerContentAlignment WatermarkAlignment { get { return default(System.Workflow.ComponentModel.Design.DesignerContentAlignment); } set { } }
    [SRCategoryAttribute("BackgroundCategory", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [SRDescriptionAttribute("WorkflowWatermarkDesc", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [System.ComponentModel.EditorAttribute(typeof(System.Workflow.ComponentModel.Design.ImageBrowserEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.Runtime.InteropServices.DispIdAttribute(15)]
    public virtual string WatermarkImagePath { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Drawing.Image WorkflowWatermarkImage { get { return default(System.Drawing.Image); } }
    protected override void Dispose(bool disposing) { }
    public override void Initialize() { }
    public override void OnAmbientPropertyChanged(System.Workflow.ComponentModel.Design.AmbientProperty ambientProperty) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
  public partial class BindUITypeEditor : System.Drawing.Design.UITypeEditor {
    public BindUITypeEditor() { }
    public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider serviceProvider, object value) { return default(object); }
    public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext typeDescriptorContext) { return default(System.Drawing.Design.UITypeEditorEditStyle); }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class CommentGlyph : System.Workflow.ComponentModel.Design.DesignerGlyph {
    public CommentGlyph() { }
    public override int Priority { get { return default(int); } }
    public override System.Drawing.Rectangle GetBounds(System.Workflow.ComponentModel.Design.ActivityDesigner designer, bool activated) { return default(System.Drawing.Rectangle); }
    protected override void OnPaint(System.Drawing.Graphics graphics, bool activated, System.Workflow.ComponentModel.Design.AmbientTheme ambientTheme, System.Workflow.ComponentModel.Design.ActivityDesigner designer) { }
  }
  [SRCategoryAttribute("CompositeActivityDesigners", "System.Workflow.ComponentModel.Design.DesignerResources")]
  [System.ComponentModel.Design.Serialization.DesignerSerializerAttribute(typeof(System.Workflow.ComponentModel.Design.CompositeActivityDesignerLayoutSerializer), typeof(System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializer))]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Workflow.ComponentModel.Design.ActivityDesignerThemeAttribute(typeof(System.Workflow.ComponentModel.Design.CompositeDesignerTheme))]
  public abstract partial class CompositeActivityDesigner : System.Workflow.ComponentModel.Design.ActivityDesigner {
    protected CompositeActivityDesigner() { }
    public override System.Windows.Forms.AccessibleObject AccessibilityObject { get { return default(System.Windows.Forms.AccessibleObject); } }
    public virtual bool CanExpandCollapse { get { return default(bool); } }
    public virtual System.Collections.ObjectModel.ReadOnlyCollection<System.Workflow.ComponentModel.Design.ActivityDesigner> ContainedDesigners { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Workflow.ComponentModel.Design.ActivityDesigner>); } }
    protected virtual System.Drawing.Rectangle ExpandButtonRectangle { get { return default(System.Drawing.Rectangle); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public virtual bool Expanded { get { return default(bool); } set { } }
    public virtual object FirstSelectableObject { get { return default(object); } }
    protected internal override System.Workflow.ComponentModel.Design.ActivityDesignerGlyphCollection Glyphs { get { return default(System.Workflow.ComponentModel.Design.ActivityDesignerGlyphCollection); } }
    protected override System.Drawing.Rectangle ImageRectangle { get { return default(System.Drawing.Rectangle); } }
    public bool IsEditable { get { return default(bool); } }
    public virtual object LastSelectableObject { get { return default(object); } }
    public override System.Drawing.Point Location { get { return default(System.Drawing.Point); } set { } }
    protected override System.Drawing.Rectangle TextRectangle { get { return default(System.Drawing.Rectangle); } }
    protected virtual int TitleHeight { get { return default(int); } }
    public virtual bool CanInsertActivities(System.Workflow.ComponentModel.Design.HitTestInfo insertLocation, System.Collections.ObjectModel.ReadOnlyCollection<System.Workflow.ComponentModel.Activity> activitiesToInsert) { return default(bool); }
    public virtual bool CanMoveActivities(System.Workflow.ComponentModel.Design.HitTestInfo moveLocation, System.Collections.ObjectModel.ReadOnlyCollection<System.Workflow.ComponentModel.Activity> activitiesToMove) { return default(bool); }
    public virtual bool CanRemoveActivities(System.Collections.ObjectModel.ReadOnlyCollection<System.Workflow.ComponentModel.Activity> activitiesToRemove) { return default(bool); }
    public static System.Workflow.ComponentModel.Activity[] DeserializeActivitiesFromDataObject(System.IServiceProvider serviceProvider, System.Windows.Forms.IDataObject dataObj) { return default(System.Workflow.ComponentModel.Activity[]); }
    protected override void Dispose(bool disposing) { }
    public virtual void EnsureVisibleContainedDesigner(System.Workflow.ComponentModel.Design.ActivityDesigner containedDesigner) { }
    public static System.Workflow.ComponentModel.Design.ActivityDesigner[] GetIntersectingDesigners(System.Workflow.ComponentModel.Design.ActivityDesigner topLevelDesigner, System.Drawing.Rectangle rectangle) { return default(System.Workflow.ComponentModel.Design.ActivityDesigner[]); }
    public virtual object GetNextSelectableObject(object current, System.Workflow.ComponentModel.Design.DesignerNavigationDirection direction) { return default(object); }
    public override System.Workflow.ComponentModel.Design.HitTestInfo HitTest(System.Drawing.Point point) { return default(System.Workflow.ComponentModel.Design.HitTestInfo); }
    protected override void Initialize(System.Workflow.ComponentModel.Activity activity) { }
    public static void InsertActivities(System.Workflow.ComponentModel.Design.CompositeActivityDesigner compositeActivityDesigner, System.Workflow.ComponentModel.Design.HitTestInfo insertLocation, System.Collections.ObjectModel.ReadOnlyCollection<System.Workflow.ComponentModel.Activity> activitiesToInsert, string undoTransactionDescription) { }
    public virtual void InsertActivities(System.Workflow.ComponentModel.Design.HitTestInfo insertLocation, System.Collections.ObjectModel.ReadOnlyCollection<System.Workflow.ComponentModel.Activity> activitiesToInsert) { }
    public virtual bool IsContainedDesignerVisible(System.Workflow.ComponentModel.Design.ActivityDesigner containedDesigner) { return default(bool); }
    protected override void LoadViewState(System.IO.BinaryReader reader) { }
    public virtual void MoveActivities(System.Workflow.ComponentModel.Design.HitTestInfo moveLocation, System.Collections.ObjectModel.ReadOnlyCollection<System.Workflow.ComponentModel.Activity> activitiesToMove) { }
    public static void MoveDesigners(System.Workflow.ComponentModel.Design.ActivityDesigner activityDesigner, bool moveBack) { }
    protected virtual void OnContainedActivitiesChanged(System.Workflow.ComponentModel.ActivityCollectionChangeEventArgs listChangeArgs) { }
    protected virtual void OnContainedActivitiesChanging(System.Workflow.ComponentModel.ActivityCollectionChangeEventArgs listChangeArgs) { }
    protected virtual void OnContainedActivityChanged(System.Workflow.ComponentModel.Design.ActivityChangedEventArgs e) { }
    protected override void OnKeyDown(System.Windows.Forms.KeyEventArgs e) { }
    protected override void OnLayoutPosition(System.Workflow.ComponentModel.Design.ActivityDesignerLayoutEventArgs e) { }
    protected override System.Drawing.Size OnLayoutSize(System.Workflow.ComponentModel.Design.ActivityDesignerLayoutEventArgs e) { return default(System.Drawing.Size); }
    protected override void OnMouseDown(System.Windows.Forms.MouseEventArgs e) { }
    protected override void OnPaint(System.Workflow.ComponentModel.Design.ActivityDesignerPaintEventArgs e) { }
    protected override void OnThemeChange(System.Workflow.ComponentModel.Design.ActivityDesignerTheme designerTheme) { }
    protected void PaintContainedDesigners(System.Workflow.ComponentModel.Design.ActivityDesignerPaintEventArgs e) { }
    public virtual void RemoveActivities(System.Collections.ObjectModel.ReadOnlyCollection<System.Workflow.ComponentModel.Activity> activitiesToRemove) { }
    public static void RemoveActivities(System.IServiceProvider serviceProvider, System.Collections.ObjectModel.ReadOnlyCollection<System.Workflow.ComponentModel.Activity> activitiesToRemove, string transactionDescription) { }
    protected override void SaveViewState(System.IO.BinaryWriter writer) { }
    public static System.Windows.Forms.IDataObject SerializeActivitiesToDataObject(System.IServiceProvider serviceProvider, System.Workflow.ComponentModel.Activity[] activities) { return default(System.Windows.Forms.IDataObject); }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class CompositeActivityDesignerLayoutSerializer : System.Workflow.ComponentModel.Design.ActivityDesignerLayoutSerializer {
    public CompositeActivityDesignerLayoutSerializer() { }
    protected internal override System.Reflection.PropertyInfo[] GetProperties(System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializationManager serializationManager, object obj) { return default(System.Reflection.PropertyInfo[]); }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class CompositeDesignerAccessibleObject : System.Workflow.ComponentModel.Design.ActivityDesignerAccessibleObject {
    public CompositeDesignerAccessibleObject(System.Workflow.ComponentModel.Design.CompositeActivityDesigner activityDesigner) : base (default(System.Workflow.ComponentModel.Design.ActivityDesigner)) { }
    public override System.Windows.Forms.AccessibleStates State { get { return default(System.Windows.Forms.AccessibleStates); } }
    public override System.Windows.Forms.AccessibleObject GetChild(int index) { return default(System.Windows.Forms.AccessibleObject); }
    public override int GetChildCount() { return default(int); }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class CompositeDesignerTheme : System.Workflow.ComponentModel.Design.ActivityDesignerTheme {
    public CompositeDesignerTheme(System.Workflow.ComponentModel.Design.WorkflowTheme theme) : base (default(System.Workflow.ComponentModel.Design.WorkflowTheme)) { }
    [SRCategoryAttribute("ForegroundCategory", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [SRDescriptionAttribute("ConnectorEndCapDesc", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [System.ComponentModel.DefaultValueAttribute((System.Workflow.ComponentModel.Design.LineAnchor)(2))]
    [System.Runtime.InteropServices.DispIdAttribute(12)]
    public virtual System.Workflow.ComponentModel.Design.LineAnchor ConnectorEndCap { get { return default(System.Workflow.ComponentModel.Design.LineAnchor); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public virtual System.Drawing.Size ConnectorSize { get { return default(System.Drawing.Size); } }
    [SRCategoryAttribute("ForegroundCategory", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [SRDescriptionAttribute("ConnectorStartCapDesc", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [System.ComponentModel.DefaultValueAttribute((System.Workflow.ComponentModel.Design.LineAnchor)(0))]
    [System.Runtime.InteropServices.DispIdAttribute(11)]
    public virtual System.Workflow.ComponentModel.Design.LineAnchor ConnectorStartCap { get { return default(System.Workflow.ComponentModel.Design.LineAnchor); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public virtual System.Drawing.Size ExpandButtonSize { get { return default(System.Drawing.Size); } }
    [SRCategoryAttribute("BackgroundCategory", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [SRDescriptionAttribute("DropShadowDesc", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Runtime.InteropServices.DispIdAttribute(10)]
    public virtual bool ShowDropShadow { get { return default(bool); } set { } }
    [SRCategoryAttribute("BackgroundCategory", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [SRDescriptionAttribute("WatermarkAlignmentDesc", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [System.ComponentModel.DefaultValueAttribute((System.Workflow.ComponentModel.Design.DesignerContentAlignment)(12))]
    [System.Runtime.InteropServices.DispIdAttribute(9)]
    public virtual System.Workflow.ComponentModel.Design.DesignerContentAlignment WatermarkAlignment { get { return default(System.Workflow.ComponentModel.Design.DesignerContentAlignment); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Drawing.Image WatermarkImage { get { return default(System.Drawing.Image); } }
    [SRCategoryAttribute("BackgroundCategory", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [SRDescriptionAttribute("WatermarkDesc", "System.Workflow.ComponentModel.Design.DesignerResources")]
    [System.ComponentModel.EditorAttribute(typeof(System.Workflow.ComponentModel.Design.ImageBrowserEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.Runtime.InteropServices.DispIdAttribute(8)]
    public virtual string WatermarkImagePath { get { return default(string); } set { } }
    protected override void Dispose(bool disposing) { }
    public System.Drawing.Brush GetExpandButtonBackgroundBrush(System.Drawing.Rectangle rectangle) { return default(System.Drawing.Brush); }
    public override void Initialize() { }
    public override void OnAmbientPropertyChanged(System.Workflow.ComponentModel.Design.AmbientProperty ambientProperty) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class ConfigErrorGlyph : System.Workflow.ComponentModel.Design.DesignerGlyph {
    public ConfigErrorGlyph() { }
    public override bool CanBeActivated { get { return default(bool); } }
    public override int Priority { get { return default(int); } }
    public override System.Drawing.Rectangle GetBounds(System.Workflow.ComponentModel.Design.ActivityDesigner designer, bool activated) { return default(System.Drawing.Rectangle); }
    protected override void OnActivate(System.Workflow.ComponentModel.Design.ActivityDesigner designer) { }
    protected override void OnPaint(System.Drawing.Graphics graphics, bool activated, System.Workflow.ComponentModel.Design.AmbientTheme ambientTheme, System.Workflow.ComponentModel.Design.ActivityDesigner designer) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class ConnectionPoint {
    public ConnectionPoint(System.Workflow.ComponentModel.Design.ActivityDesigner associatedDesigner, System.Workflow.ComponentModel.Design.DesignerEdges designerEdge, int connectionIndex) { }
    public System.Workflow.ComponentModel.Design.ActivityDesigner AssociatedDesigner { get { return default(System.Workflow.ComponentModel.Design.ActivityDesigner); } }
    public virtual System.Drawing.Rectangle Bounds { get { return default(System.Drawing.Rectangle); } }
    public System.Workflow.ComponentModel.Design.DesignerEdges ConnectionEdge { get { return default(System.Workflow.ComponentModel.Design.DesignerEdges); } }
    public int ConnectionIndex { get { return default(int); } }
    public virtual System.Drawing.Point Location { get { return default(System.Drawing.Point); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public void OnPaint(System.Workflow.ComponentModel.Design.ActivityDesignerPaintEventArgs e, bool drawHighlighted) { }
  }
  [System.ComponentModel.Design.Serialization.DesignerSerializerAttribute(typeof(System.Workflow.ComponentModel.Design.ConnectorLayoutSerializer), typeof(System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializer))]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class Connector : System.IDisposable {
    public Connector(System.Workflow.ComponentModel.Design.ConnectionPoint source, System.Workflow.ComponentModel.Design.ConnectionPoint target) { }
    public virtual System.Windows.Forms.AccessibleObject AccessibilityObject { get { return default(System.Windows.Forms.AccessibleObject); } }
    public System.Drawing.Rectangle Bounds { get { return default(System.Drawing.Rectangle); } }
    public bool ConnectorModified { get { return default(bool); } }
    public virtual System.Collections.ObjectModel.ReadOnlyCollection<System.Drawing.Point> ConnectorSegments { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Drawing.Point>); } }
    protected internal virtual System.Collections.Generic.ICollection<System.Drawing.Rectangle> ExcludedRoutingRectangles { get { return default(System.Collections.Generic.ICollection<System.Drawing.Rectangle>); } }
    public System.Workflow.ComponentModel.Design.FreeformActivityDesigner ParentDesigner { get { return default(System.Workflow.ComponentModel.Design.FreeformActivityDesigner); } }
    protected System.Workflow.ComponentModel.Design.WorkflowView ParentView { get { return default(System.Workflow.ComponentModel.Design.WorkflowView); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Workflow.ComponentModel.Design.ConnectionPoint Source { get { return default(System.Workflow.ComponentModel.Design.ConnectionPoint); } set { } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Workflow.ComponentModel.Design.ConnectionPoint Target { get { return default(System.Workflow.ComponentModel.Design.ConnectionPoint); } set { } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    protected virtual object GetService(System.Type serviceType) { return default(object); }
    public virtual bool HitTest(System.Drawing.Point point) { return default(bool); }
    public void Invalidate() { }
    public virtual void Offset(System.Drawing.Size size) { }
    protected internal virtual void OnLayout(System.Workflow.ComponentModel.Design.ActivityDesignerLayoutEventArgs e) { }
    protected internal virtual void OnPaint(System.Workflow.ComponentModel.Design.ActivityDesignerPaintEventArgs e) { }
    protected internal virtual void OnPaintEdited(System.Workflow.ComponentModel.Design.ActivityDesignerPaintEventArgs e, System.Drawing.Point[] segments, System.Drawing.Point[] segmentEditPoints) { }
    protected internal virtual void OnPaintSelected(System.Workflow.ComponentModel.Design.ActivityDesignerPaintEventArgs e, bool primarySelection, System.Drawing.Point[] segmentEditPoints) { }
    protected void PerformLayout() { }
    protected internal void SetConnectorSegments(System.Collections.Generic.ICollection<System.Drawing.Point> segments) { }
    void System.IDisposable.Dispose() { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class ConnectorAccessibleObject : System.Windows.Forms.AccessibleObject {
    public ConnectorAccessibleObject(System.Workflow.ComponentModel.Design.Connector connector) { }
    public override System.Drawing.Rectangle Bounds { get { return default(System.Drawing.Rectangle); } }
    public override string Name { get { return default(string); } set { } }
    public override System.Windows.Forms.AccessibleObject Parent { get { return default(System.Windows.Forms.AccessibleObject); } }
    public override System.Windows.Forms.AccessibleRole Role { get { return default(System.Windows.Forms.AccessibleRole); } }
    public override System.Windows.Forms.AccessibleObject HitTest(int x, int y) { return default(System.Windows.Forms.AccessibleObject); }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class ConnectorEventArgs : System.EventArgs {
    internal ConnectorEventArgs() { }
    public System.Workflow.ComponentModel.Design.Connector Connector { get { return default(System.Workflow.ComponentModel.Design.Connector); } }
  }
  public delegate void ConnectorEventHandler(object sender, System.Workflow.ComponentModel.Design.ConnectorEventArgs e);
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class ConnectorHitTestInfo : System.Workflow.ComponentModel.Design.HitTestInfo {
    public ConnectorHitTestInfo(System.Workflow.ComponentModel.Design.CompositeActivityDesigner compositeActivityDesigner, System.Workflow.ComponentModel.Design.HitTestLocations flags, int connector) : base (default(System.Workflow.ComponentModel.Design.ActivityDesigner), default(System.Workflow.ComponentModel.Design.HitTestLocations)) { }
    public override System.Drawing.Rectangle Bounds { get { return default(System.Drawing.Rectangle); } }
    public override object SelectableObject { get { return default(object); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override int MapToIndex() { return default(int); }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class ConnectorLayoutSerializer : System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializer {
    public ConnectorLayoutSerializer() { }
    protected override object CreateInstance(System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializationManager serializationManager, System.Type type) { return default(object); }
    protected System.Collections.Generic.Dictionary<System.String, System.String> GetConnectorConstructionArguments(System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializationManager serializationManager, System.Type type) { return default(System.Collections.Generic.Dictionary<System.String, System.String>); }
    protected internal override System.Reflection.PropertyInfo[] GetProperties(System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializationManager serializationManager, object obj) { return default(System.Reflection.PropertyInfo[]); }
    protected override void OnAfterDeserialize(System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializationManager serializationManager, object obj) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class DesignerAction {
    public DesignerAction(System.Workflow.ComponentModel.Design.ActivityDesigner activityDesigner, int actionId, string text) { }
    public DesignerAction(System.Workflow.ComponentModel.Design.ActivityDesigner activityDesigner, int actionId, string text, System.Drawing.Image image) { }
    public int ActionId { get { return default(int); } }
    public System.Drawing.Image Image { get { return default(System.Drawing.Image); } }
    public string PropertyName { get { return default(string); } set { } }
    public string Text { get { return default(string); } }
    public System.Collections.IDictionary UserData { get { return default(System.Collections.IDictionary); } }
    public void Invoke() { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public enum DesignerContentAlignment {
    Bottom = 8,
    BottomCenter = 24,
    BottomLeft = 9,
    BottomRight = 12,
    Center = 16,
    CenterLeft = 17,
    CenterRight = 20,
    Fill = 32,
    Left = 1,
    Right = 4,
    Top = 2,
    TopCenter = 18,
    TopLeft = 3,
    TopRight = 6,
  }
  [System.FlagsAttribute]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public enum DesignerEdges {
    All = 15,
    Bottom = 8,
    Left = 1,
    None = 0,
    Right = 4,
    Top = 2,
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public enum DesignerGeometry {
    Rectangle = 0,
    RoundedRectangle = 1,
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public abstract partial class DesignerGlyph {
    public const int HighestPriority = 0;
    public const int LowestPriority = 1000000;
    public const int NormalPriority = 10000;
    protected DesignerGlyph() { }
    public virtual bool CanBeActivated { get { return default(bool); } }
    public virtual int Priority { get { return default(int); } }
    public virtual System.Drawing.Rectangle GetBounds(System.Workflow.ComponentModel.Design.ActivityDesigner designer, bool activated) { return default(System.Drawing.Rectangle); }
    protected virtual void OnActivate(System.Workflow.ComponentModel.Design.ActivityDesigner designer) { }
    protected abstract void OnPaint(System.Drawing.Graphics graphics, bool activated, System.Workflow.ComponentModel.Design.AmbientTheme ambientTheme, System.Workflow.ComponentModel.Design.ActivityDesigner designer);
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public enum DesignerNavigationDirection {
    Down = 0,
    Left = 2,
    Right = 3,
    Up = 1,
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public enum DesignerSize {
    Large = 2,
    Medium = 1,
    Small = 0,
  }
  [System.ComponentModel.Design.Serialization.DesignerSerializerAttribute(typeof(System.Workflow.ComponentModel.Design.DesignerTheme.ThemeSerializer), typeof(System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializer))]
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Workflow.ComponentModel.Design.ThemeTypeConverter))]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public abstract partial class DesignerTheme : System.IDisposable {
    protected DesignerTheme(System.Workflow.ComponentModel.Design.WorkflowTheme theme) { }
    [System.ComponentModel.BrowsableAttribute(false)]
    public virtual string ApplyTo { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    protected System.Workflow.ComponentModel.Design.WorkflowTheme ContainingTheme { get { return default(System.Workflow.ComponentModel.Design.WorkflowTheme); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public virtual System.Type DesignerType { get { return default(System.Type); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public bool ReadOnly { get { return default(bool); } }
    protected virtual void Dispose(bool disposing) { }
    ~DesignerTheme() { }
    public virtual void Initialize() { }
    public virtual void OnAmbientPropertyChanged(System.Workflow.ComponentModel.Design.AmbientProperty ambientProperty) { }
    void System.IDisposable.Dispose() { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public enum DesignerVerbGroup {
    Actions = 4,
    Edit = 2,
    General = 0,
    Misc = 5,
    Options = 3,
    View = 1,
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class DesignerView {
    public DesignerView(int viewId, string text, System.Drawing.Image image) { }
    public DesignerView(int viewId, string text, System.Drawing.Image image, System.Workflow.ComponentModel.Design.ActivityDesigner associatedDesigner) { }
    public virtual System.Workflow.ComponentModel.Design.ActivityDesigner AssociatedDesigner { get { return default(System.Workflow.ComponentModel.Design.ActivityDesigner); } }
    public System.Drawing.Image Image { get { return default(System.Drawing.Image); } }
    public string Text { get { return default(string); } }
    public System.Collections.IDictionary UserData { get { return default(System.Collections.IDictionary); } }
    public int ViewId { get { return default(int); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public virtual void OnActivate() { }
    public virtual void OnDeactivate() { }
  }
  [System.ComponentModel.Design.Serialization.DesignerSerializerAttribute(typeof(System.Workflow.ComponentModel.Design.FreeformActivityDesignerLayoutSerializer), typeof(System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializer))]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class FreeformActivityDesigner : System.Workflow.ComponentModel.Design.CompositeActivityDesigner {
    public FreeformActivityDesigner() { }
    public override System.Windows.Forms.AccessibleObject AccessibilityObject { get { return default(System.Windows.Forms.AccessibleObject); } }
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool AutoSize { get { return default(bool); } set { } }
    public System.Drawing.Size AutoSizeMargin { get { return default(System.Drawing.Size); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.AutoSizeMode)(1))]
    public System.Windows.Forms.AutoSizeMode AutoSizeMode { get { return default(System.Windows.Forms.AutoSizeMode); } set { } }
    public override bool CanExpandCollapse { get { return default(bool); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Workflow.ComponentModel.Design.Connector> Connectors { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Workflow.ComponentModel.Design.Connector>); } }
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool EnableUserDrawnConnectors { get { return default(bool); } set { } }
    protected internal override bool EnableVisualResizing { get { return default(bool); } }
    public override object FirstSelectableObject { get { return default(object); } }
    protected internal override System.Workflow.ComponentModel.Design.ActivityDesignerGlyphCollection Glyphs { get { return default(System.Workflow.ComponentModel.Design.ActivityDesignerGlyphCollection); } }
    public override object LastSelectableObject { get { return default(object); } }
    public override System.Drawing.Point Location { get { return default(System.Drawing.Point); } set { } }
    public override System.Drawing.Size MinimumSize { get { return default(System.Drawing.Size); } }
    protected virtual bool ShowConnectorsInForeground { get { return default(bool); } }
    public event System.Workflow.ComponentModel.Design.ConnectorEventHandler ConnectorAdded { add { } remove { } }
    public event System.Workflow.ComponentModel.Design.ConnectorEventHandler ConnectorChanged { add { } remove { } }
    public event System.Workflow.ComponentModel.Design.ConnectorEventHandler ConnectorRemoved { add { } remove { } }
    public System.Workflow.ComponentModel.Design.Connector AddConnector(System.Workflow.ComponentModel.Design.ConnectionPoint source, System.Workflow.ComponentModel.Design.ConnectionPoint target) { return default(System.Workflow.ComponentModel.Design.Connector); }
    public void BringToFront(System.Workflow.ComponentModel.Design.ActivityDesigner containedDesigner) { }
    protected internal virtual bool CanConnectContainedDesigners(System.Workflow.ComponentModel.Design.ConnectionPoint source, System.Workflow.ComponentModel.Design.ConnectionPoint target) { return default(bool); }
    protected internal virtual bool CanResizeContainedDesigner(System.Workflow.ComponentModel.Design.ActivityDesigner containedDesigner) { return default(bool); }
    protected internal virtual System.Workflow.ComponentModel.Design.Connector CreateConnector(System.Workflow.ComponentModel.Design.ConnectionPoint source, System.Workflow.ComponentModel.Design.ConnectionPoint target) { return default(System.Workflow.ComponentModel.Design.Connector); }
    protected override void Dispose(bool disposing) { }
    public override object GetNextSelectableObject(object current, System.Workflow.ComponentModel.Design.DesignerNavigationDirection navigate) { return default(object); }
    public override System.Workflow.ComponentModel.Design.HitTestInfo HitTest(System.Drawing.Point point) { return default(System.Workflow.ComponentModel.Design.HitTestInfo); }
    protected override void Initialize(System.Workflow.ComponentModel.Activity activity) { }
    public override void InsertActivities(System.Workflow.ComponentModel.Design.HitTestInfo insertLocation, System.Collections.ObjectModel.ReadOnlyCollection<System.Workflow.ComponentModel.Activity> activitiesToInsert) { }
    public override void MoveActivities(System.Workflow.ComponentModel.Design.HitTestInfo moveLocation, System.Collections.ObjectModel.ReadOnlyCollection<System.Workflow.ComponentModel.Activity> activitiesToMove) { }
    public void MoveContainedDesigner(System.Workflow.ComponentModel.Design.ActivityDesigner containedDesigner, System.Drawing.Point newLocation) { }
    protected virtual void OnConnectorAdded(System.Workflow.ComponentModel.Design.ConnectorEventArgs e) { }
    protected internal virtual void OnConnectorChanged(System.Workflow.ComponentModel.Design.ConnectorEventArgs e) { }
    protected virtual void OnConnectorRemoved(System.Workflow.ComponentModel.Design.ConnectorEventArgs e) { }
    protected override void OnContainedActivitiesChanging(System.Workflow.ComponentModel.ActivityCollectionChangeEventArgs listChangeArgs) { }
    protected internal virtual void OnContainedDesignersConnected(System.Workflow.ComponentModel.Design.ConnectionPoint source, System.Workflow.ComponentModel.Design.ConnectionPoint target) { }
    protected override void OnDragDrop(System.Workflow.ComponentModel.Design.ActivityDragEventArgs e) { }
    protected override void OnDragOver(System.Workflow.ComponentModel.Design.ActivityDragEventArgs e) { }
    protected override void OnKeyDown(System.Windows.Forms.KeyEventArgs e) { }
    protected override void OnLayoutPosition(System.Workflow.ComponentModel.Design.ActivityDesignerLayoutEventArgs e) { }
    protected override System.Drawing.Size OnLayoutSize(System.Workflow.ComponentModel.Design.ActivityDesignerLayoutEventArgs e) { return default(System.Drawing.Size); }
    protected override void OnResizing(System.Workflow.ComponentModel.Design.ActivityDesignerResizeEventArgs e) { }
    protected override void OnThemeChange(System.Workflow.ComponentModel.Design.ActivityDesignerTheme newTheme) { }
    public void RemoveConnector(System.Workflow.ComponentModel.Design.Connector connector) { }
    public void ResizeContainedDesigner(System.Workflow.ComponentModel.Design.ActivityDesigner containedDesigner, System.Drawing.Size newSize) { }
    public void SendToBack(System.Workflow.ComponentModel.Design.ActivityDesigner containedDesigner) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class FreeformActivityDesignerLayoutSerializer : System.Workflow.ComponentModel.Design.CompositeActivityDesignerLayoutSerializer {
    public FreeformActivityDesignerLayoutSerializer() { }
    protected internal override System.Reflection.PropertyInfo[] GetProperties(System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializationManager serializationManager, object obj) { return default(System.Reflection.PropertyInfo[]); }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class HitTestInfo {
    public HitTestInfo(System.Workflow.ComponentModel.Design.ActivityDesigner designer, System.Workflow.ComponentModel.Design.HitTestLocations location) { }
    [System.ComponentModel.BrowsableAttribute(false)]
    public System.Workflow.ComponentModel.Design.ActivityDesigner AssociatedDesigner { get { return default(System.Workflow.ComponentModel.Design.ActivityDesigner); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public virtual System.Drawing.Rectangle Bounds { get { return default(System.Drawing.Rectangle); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public System.Workflow.ComponentModel.Design.HitTestLocations HitLocation { get { return default(System.Workflow.ComponentModel.Design.HitTestLocations); } }
    public static System.Workflow.ComponentModel.Design.HitTestInfo Nowhere { get { return default(System.Workflow.ComponentModel.Design.HitTestInfo); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public virtual object SelectableObject { get { return default(object); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public System.Collections.IDictionary UserData { get { return default(System.Collections.IDictionary); } }
    public virtual int MapToIndex() { return default(int); }
  }
  [System.FlagsAttribute]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public enum HitTestLocations {
    ActionArea = 2,
    Bottom = 32,
    Connector = 64,
    Designer = 1,
    Left = 4,
    None = 0,
    Right = 16,
    Top = 8,
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial interface IDesignerGlyphProvider {
    System.Workflow.ComponentModel.Design.ActivityDesignerGlyphCollection GetGlyphs(System.Workflow.ComponentModel.Design.ActivityDesigner activityDesigner);
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial interface IDesignerGlyphProviderService {
    System.Collections.ObjectModel.ReadOnlyCollection<System.Workflow.ComponentModel.Design.IDesignerGlyphProvider> GlyphProviders { get; }
    void AddGlyphProvider(System.Workflow.ComponentModel.Design.IDesignerGlyphProvider glyphProvider);
    void RemoveGlyphProvider(System.Workflow.ComponentModel.Design.IDesignerGlyphProvider glyphProvider);
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial interface IDesignerVerbProvider {
    System.Workflow.ComponentModel.Design.ActivityDesignerVerbCollection GetVerbs(System.Workflow.ComponentModel.Design.ActivityDesigner activityDesigner);
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial interface IDesignerVerbProviderService {
    System.Collections.ObjectModel.ReadOnlyCollection<System.Workflow.ComponentModel.Design.IDesignerVerbProvider> VerbProviders { get; }
    void AddVerbProvider(System.Workflow.ComponentModel.Design.IDesignerVerbProvider verbProvider);
    void RemoveVerbProvider(System.Workflow.ComponentModel.Design.IDesignerVerbProvider verbProvider);
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial interface IExtendedUIService {
    void AddAssemblyReference(System.Reflection.AssemblyName assemblyName);
    void AddDesignerActions(System.Workflow.ComponentModel.Design.DesignerAction[] actions);
    System.Windows.Forms.DialogResult AddWebReference(out System.Uri url, out System.Type proxyClass);
    System.Type GetProxyClassForUrl(System.Uri url);
    System.ComponentModel.ITypeDescriptorContext GetSelectedPropertyContext();
    System.Uri GetUrlForProxyClass(System.Type proxyClass);
    System.Collections.Generic.Dictionary<System.String, System.Type> GetXsdProjectItemsInfo();
    bool NavigateToProperty(string propName);
    void RemoveDesignerActions();
    void ShowToolsOptions();
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial interface IExtendedUIService2 {
    System.Reflection.Assembly GetReflectionAssembly(System.Reflection.AssemblyName assemblyName);
    System.Type GetRuntimeType(System.Type reflectionType);
    long GetTargetFrameworkVersion();
    bool IsSupportedType(System.Type type);
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial interface IIdentifierCreationService {
    void EnsureUniqueIdentifiers(System.Workflow.ComponentModel.CompositeActivity parentActivity, System.Collections.ICollection childActivities);
    void ValidateIdentifier(System.Workflow.ComponentModel.Activity activity, string identifier);
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial interface IMemberCreationService {
    void CreateEvent(string className, string eventName, System.Type eventType, System.Workflow.ComponentModel.Compiler.AttributeInfo[] attributes, bool emitDependencyProperty);
    void CreateField(string className, string fieldName, System.Type fieldType, System.Type[] genericParameterTypes, System.CodeDom.MemberAttributes attributes, System.CodeDom.CodeSnippetExpression initializationExpression, bool overwriteExisting);
    void CreateProperty(string className, string propertyName, System.Type propertyType, System.Workflow.ComponentModel.Compiler.AttributeInfo[] attributes, bool emitDependencyProperty, bool isMetaProperty, bool isAttached, System.Type ownerType, bool isReadOnly);
    void RemoveEvent(string className, string eventName, System.Type eventType);
    void RemoveProperty(string className, string propertyName, System.Type propertyType);
    void ShowCode();
    void ShowCode(System.Workflow.ComponentModel.Activity activity, string methodName, System.Type delegateType);
    void UpdateBaseType(string className, System.Type baseType);
    void UpdateEvent(string className, string oldEventName, System.Type oldEventType, string newEventName, System.Type newEventType, System.Workflow.ComponentModel.Compiler.AttributeInfo[] attributes, bool emitDependencyProperty, bool isMetaProperty);
    void UpdateProperty(string className, string oldPropertyName, System.Type oldPropertyType, string newPropertyName, System.Type newPropertyType, System.Workflow.ComponentModel.Compiler.AttributeInfo[] attributes, bool emitDependencyProperty, bool isMetaProperty);
    void UpdateTypeName(string oldClassName, string newClassName);
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial interface IPersistUIState {
    void LoadViewState(System.IO.BinaryReader reader);
    void SaveViewState(System.IO.BinaryWriter writer);
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial interface ITypeFilterProvider {
    string FilterDescription { get; }
    bool CanFilterType(System.Type type, bool throwOnError);
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("0E6DF9D7-B4B5-4af7-9647-FC335CCE393F")]
  public partial interface ITypeProviderCreator {
    System.Reflection.Assembly GetLocalAssembly(object obj);
    System.Reflection.Assembly GetTransientAssembly(System.Reflection.AssemblyName assemblyName);
    System.Workflow.ComponentModel.Compiler.ITypeProvider GetTypeProvider(object obj);
    System.ComponentModel.Design.ITypeResolutionService GetTypeResolutionService(object obj);
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial interface IWorkflowRootDesigner : System.ComponentModel.Design.IDesigner, System.ComponentModel.Design.IRootDesigner, System.IDisposable {
    System.Workflow.ComponentModel.Design.CompositeActivityDesigner InvokingDesigner { get; set; }
    System.Collections.ObjectModel.ReadOnlyCollection<System.Workflow.ComponentModel.Design.WorkflowDesignerMessageFilter> MessageFilters { get; }
    bool SupportsLayoutPersistence { get; }
    bool IsSupportedActivityType(System.Type activityType);
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public enum LineAnchor {
    Arrow = 1,
    ArrowAnchor = 2,
    Diamond = 3,
    DiamondAnchor = 4,
    None = 0,
    Rectangle = 7,
    RectangleAnchor = 8,
    Round = 5,
    RoundAnchor = 6,
    RoundedRectangle = 9,
    RoundedRectangleAnchor = 10,
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class LockedActivityGlyph : System.Workflow.ComponentModel.Design.DesignerGlyph {
    public LockedActivityGlyph() { }
    public override int Priority { get { return default(int); } }
    public override System.Drawing.Rectangle GetBounds(System.Workflow.ComponentModel.Design.ActivityDesigner designer, bool activated) { return default(System.Drawing.Rectangle); }
    protected override void OnPaint(System.Drawing.Graphics graphics, bool activated, System.Workflow.ComponentModel.Design.AmbientTheme ambientTheme, System.Workflow.ComponentModel.Design.ActivityDesigner designer) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class ParallelActivityDesigner : System.Workflow.ComponentModel.Design.StructuredCompositeActivityDesigner {
    public ParallelActivityDesigner() { }
    public override object FirstSelectableObject { get { return default(object); } }
    public override object LastSelectableObject { get { return default(object); } }
    protected override System.Workflow.ComponentModel.Design.ActivityDesignerVerbCollection Verbs { get { return default(System.Workflow.ComponentModel.Design.ActivityDesignerVerbCollection); } }
    public override bool CanMoveActivities(System.Workflow.ComponentModel.Design.HitTestInfo moveLocation, System.Collections.ObjectModel.ReadOnlyCollection<System.Workflow.ComponentModel.Activity> activitiesToMove) { return default(bool); }
    public override bool CanRemoveActivities(System.Collections.ObjectModel.ReadOnlyCollection<System.Workflow.ComponentModel.Activity> activitiesToRemove) { return default(bool); }
    protected override System.Drawing.Rectangle[] GetDropTargets(System.Drawing.Point dropPoint) { return default(System.Drawing.Rectangle[]); }
    public override object GetNextSelectableObject(object obj, System.Workflow.ComponentModel.Design.DesignerNavigationDirection direction) { return default(object); }
    protected virtual System.Workflow.ComponentModel.CompositeActivity OnCreateNewBranch() { return default(System.Workflow.ComponentModel.CompositeActivity); }
    protected override void OnLayoutPosition(System.Workflow.ComponentModel.Design.ActivityDesignerLayoutEventArgs e) { }
    protected override System.Drawing.Size OnLayoutSize(System.Workflow.ComponentModel.Design.ActivityDesignerLayoutEventArgs e) { return default(System.Drawing.Size); }
    protected override void OnPaint(System.Workflow.ComponentModel.Design.ActivityDesignerPaintEventArgs e) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class ReadOnlyActivityGlyph : System.Workflow.ComponentModel.Design.DesignerGlyph {
    public ReadOnlyActivityGlyph() { }
    public override int Priority { get { return default(int); } }
    public override System.Drawing.Rectangle GetBounds(System.Workflow.ComponentModel.Design.ActivityDesigner designer, bool activated) { return default(System.Drawing.Rectangle); }
    protected override void OnPaint(System.Drawing.Graphics graphics, bool activated, System.Workflow.ComponentModel.Design.AmbientTheme ambientTheme, System.Workflow.ComponentModel.Design.ActivityDesigner designer) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public abstract partial class SelectionGlyph : System.Workflow.ComponentModel.Design.DesignerGlyph {
    protected SelectionGlyph() { }
    public abstract bool IsPrimarySelection { get; }
    public override int Priority { get { return default(int); } }
    public override System.Drawing.Rectangle GetBounds(System.Workflow.ComponentModel.Design.ActivityDesigner designer, bool activated) { return default(System.Drawing.Rectangle); }
    public virtual System.Drawing.Rectangle[] GetGrabHandles(System.Workflow.ComponentModel.Design.ActivityDesigner designer) { return default(System.Drawing.Rectangle[]); }
    protected override void OnPaint(System.Drawing.Graphics graphics, bool activated, System.Workflow.ComponentModel.Design.AmbientTheme ambientTheme, System.Workflow.ComponentModel.Design.ActivityDesigner designer) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Workflow.ComponentModel.Design.ActivityDesignerThemeAttribute(typeof(System.Workflow.ComponentModel.Design.SequenceDesignerTheme))]
  public partial class SequenceDesigner : System.Workflow.ComponentModel.Design.SequentialActivityDesigner {
    public SequenceDesigner() { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class SequenceDesignerAccessibleObject : System.Workflow.ComponentModel.Design.CompositeDesignerAccessibleObject {
    public SequenceDesignerAccessibleObject(System.Workflow.ComponentModel.Design.SequentialActivityDesigner activityDesigner) : base (default(System.Workflow.ComponentModel.Design.CompositeActivityDesigner)) { }
    public override System.Windows.Forms.AccessibleObject GetChild(int index) { return default(System.Windows.Forms.AccessibleObject); }
    public override int GetChildCount() { return default(int); }
    public override System.Windows.Forms.AccessibleObject Navigate(System.Windows.Forms.AccessibleNavigation navdir) { return default(System.Windows.Forms.AccessibleObject); }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class SequentialActivityDesigner : System.Workflow.ComponentModel.Design.StructuredCompositeActivityDesigner {
    public SequentialActivityDesigner() { }
    public override System.Windows.Forms.AccessibleObject AccessibilityObject { get { return default(System.Windows.Forms.AccessibleObject); } }
    public override bool CanExpandCollapse { get { return default(bool); } }
    public override bool Expanded { get { return default(bool); } set { } }
    public override object FirstSelectableObject { get { return default(object); } }
    protected internal override System.Workflow.ComponentModel.Design.ActivityDesignerGlyphCollection Glyphs { get { return default(System.Workflow.ComponentModel.Design.ActivityDesignerGlyphCollection); } }
    protected virtual string HelpText { get { return default(string); } set { } }
    protected virtual System.Drawing.Rectangle HelpTextRectangle { get { return default(System.Drawing.Rectangle); } }
    protected System.Drawing.Size HelpTextSize { get { return default(System.Drawing.Size); } }
    public override object LastSelectableObject { get { return default(object); } }
    protected internal virtual System.Drawing.Rectangle[] GetConnectors() { return default(System.Drawing.Rectangle[]); }
    protected override System.Drawing.Rectangle[] GetDropTargets(System.Drawing.Point dropPoint) { return default(System.Drawing.Rectangle[]); }
    public override object GetNextSelectableObject(object obj, System.Workflow.ComponentModel.Design.DesignerNavigationDirection direction) { return default(object); }
    public override System.Workflow.ComponentModel.Design.HitTestInfo HitTest(System.Drawing.Point point) { return default(System.Workflow.ComponentModel.Design.HitTestInfo); }
    protected override void Initialize(System.Workflow.ComponentModel.Activity activity) { }
    protected override void OnLayoutPosition(System.Workflow.ComponentModel.Design.ActivityDesignerLayoutEventArgs e) { }
    protected override System.Drawing.Size OnLayoutSize(System.Workflow.ComponentModel.Design.ActivityDesignerLayoutEventArgs e) { return default(System.Drawing.Size); }
    protected override void OnPaint(System.Workflow.ComponentModel.Design.ActivityDesignerPaintEventArgs e) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class SequentialWorkflowHeaderFooter {
    public SequentialWorkflowHeaderFooter(System.Workflow.ComponentModel.Design.SequentialWorkflowRootDesigner parent, bool isHeader) { }
    protected System.Workflow.ComponentModel.Design.SequentialWorkflowRootDesigner AssociatedDesigner { get { return default(System.Workflow.ComponentModel.Design.SequentialWorkflowRootDesigner); } }
    public virtual System.Drawing.Rectangle Bounds { get { return default(System.Drawing.Rectangle); } }
    public virtual System.Drawing.Image Image { get { return default(System.Drawing.Image); } set { } }
    public virtual System.Drawing.Rectangle ImageRectangle { get { return default(System.Drawing.Rectangle); } }
    public virtual string Text { get { return default(string); } set { } }
    public virtual System.Drawing.Rectangle TextRectangle { get { return default(System.Drawing.Rectangle); } }
    public virtual void OnLayout(System.Workflow.ComponentModel.Design.ActivityDesignerLayoutEventArgs e) { }
    public virtual void OnPaint(System.Workflow.ComponentModel.Design.ActivityDesignerPaintEventArgs e) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class SequentialWorkflowRootDesigner : System.Workflow.ComponentModel.Design.SequentialActivityDesigner {
    public SequentialWorkflowRootDesigner() { }
    public override bool CanExpandCollapse { get { return default(bool); } }
    protected virtual System.Workflow.ComponentModel.Design.SequentialWorkflowHeaderFooter Footer { get { return default(System.Workflow.ComponentModel.Design.SequentialWorkflowHeaderFooter); } }
    protected internal override System.Workflow.ComponentModel.Design.ActivityDesignerGlyphCollection Glyphs { get { return default(System.Workflow.ComponentModel.Design.ActivityDesignerGlyphCollection); } }
    protected virtual System.Workflow.ComponentModel.Design.SequentialWorkflowHeaderFooter Header { get { return default(System.Workflow.ComponentModel.Design.SequentialWorkflowHeaderFooter); } }
    public override System.Drawing.Image Image { get { return default(System.Drawing.Image); } }
    protected override System.Drawing.Rectangle ImageRectangle { get { return default(System.Drawing.Rectangle); } }
    protected override System.Workflow.ComponentModel.Design.CompositeActivityDesigner InvokingDesigner { get { return default(System.Workflow.ComponentModel.Design.CompositeActivityDesigner); } set { } }
    public override System.Drawing.Size MinimumSize { get { return default(System.Drawing.Size); } }
    protected override bool ShowSmartTag { get { return default(bool); } }
    protected override System.Drawing.Rectangle SmartTagRectangle { get { return default(System.Drawing.Rectangle); } }
    public override string Text { get { return default(string); } }
    protected override int TitleHeight { get { return default(int); } }
    public override bool CanBeParentedTo(System.Workflow.ComponentModel.Design.CompositeActivityDesigner parentActivityDesigner) { return default(bool); }
    protected override System.Collections.ObjectModel.ReadOnlyCollection<System.Drawing.Point> GetInnerConnections(System.Workflow.ComponentModel.Design.DesignerEdges edges) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Drawing.Point>); }
    protected override System.Drawing.Size OnLayoutSize(System.Workflow.ComponentModel.Design.ActivityDesignerLayoutEventArgs e) { return default(System.Drawing.Size); }
    protected override void OnPaint(System.Workflow.ComponentModel.Design.ActivityDesignerPaintEventArgs e) { }
    protected override void OnSmartTagVisibilityChanged(bool visible) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class ShadowGlyph : System.Workflow.ComponentModel.Design.DesignerGlyph {
    public ShadowGlyph() { }
    public override int Priority { get { return default(int); } }
    public override System.Drawing.Rectangle GetBounds(System.Workflow.ComponentModel.Design.ActivityDesigner designer, bool activated) { return default(System.Drawing.Rectangle); }
    protected override void OnPaint(System.Drawing.Graphics graphics, bool activated, System.Workflow.ComponentModel.Design.AmbientTheme ambientTheme, System.Workflow.ComponentModel.Design.ActivityDesigner designer) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public abstract partial class StructuredCompositeActivityDesigner : System.Workflow.ComponentModel.Design.CompositeActivityDesigner {
    protected StructuredCompositeActivityDesigner() { }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Workflow.ComponentModel.Design.DesignerView ActiveView { get { return default(System.Workflow.ComponentModel.Design.DesignerView); } set { } }
    public override System.Collections.ObjectModel.ReadOnlyCollection<System.Workflow.ComponentModel.Design.ActivityDesigner> ContainedDesigners { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Workflow.ComponentModel.Design.ActivityDesigner>); } }
    protected virtual int CurrentDropTarget { get { return default(int); } set { } }
    public override object FirstSelectableObject { get { return default(object); } }
    public override object LastSelectableObject { get { return default(object); } }
    public override System.Drawing.Size MinimumSize { get { return default(System.Drawing.Size); } }
    protected override bool ShowSmartTag { get { return default(bool); } }
    protected override System.Collections.ObjectModel.ReadOnlyCollection<System.Workflow.ComponentModel.Design.ActivityDesignerVerb> SmartTagVerbs { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Workflow.ComponentModel.Design.ActivityDesignerVerb>); } }
    public virtual System.Collections.ObjectModel.ReadOnlyCollection<System.Workflow.ComponentModel.Design.DesignerView> Views { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Workflow.ComponentModel.Design.DesignerView>); } }
    public override bool CanInsertActivities(System.Workflow.ComponentModel.Design.HitTestInfo insertLocation, System.Collections.ObjectModel.ReadOnlyCollection<System.Workflow.ComponentModel.Activity> activitiesToInsert) { return default(bool); }
    public override bool CanRemoveActivities(System.Collections.ObjectModel.ReadOnlyCollection<System.Workflow.ComponentModel.Activity> activitiesToRemove) { return default(bool); }
    protected void DrawConnectors(System.Drawing.Graphics graphics, System.Drawing.Pen pen, System.Drawing.Point[] points, System.Workflow.ComponentModel.Design.LineAnchor startCap, System.Workflow.ComponentModel.Design.LineAnchor endCap) { }
    public override void EnsureVisibleContainedDesigner(System.Workflow.ComponentModel.Design.ActivityDesigner containedDesigner) { }
    protected virtual System.Drawing.Rectangle[] GetDropTargets(System.Drawing.Point dropPoint) { return default(System.Drawing.Rectangle[]); }
    protected virtual System.Collections.ObjectModel.ReadOnlyCollection<System.Drawing.Point> GetInnerConnections(System.Workflow.ComponentModel.Design.DesignerEdges edges) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Drawing.Point>); }
    public override object GetNextSelectableObject(object current, System.Workflow.ComponentModel.Design.DesignerNavigationDirection direction) { return default(object); }
    protected override void Initialize(System.Workflow.ComponentModel.Activity activity) { }
    public override void InsertActivities(System.Workflow.ComponentModel.Design.HitTestInfo insertLocation, System.Collections.ObjectModel.ReadOnlyCollection<System.Workflow.ComponentModel.Activity> activitiesToInsert) { }
    protected override void LoadViewState(System.IO.BinaryReader reader) { }
    public override void MoveActivities(System.Workflow.ComponentModel.Design.HitTestInfo moveLocation, System.Collections.ObjectModel.ReadOnlyCollection<System.Workflow.ComponentModel.Activity> activitiesToMove) { }
    protected override void OnActivityChanged(System.Workflow.ComponentModel.Design.ActivityChangedEventArgs e) { }
    protected override void OnContainedActivitiesChanging(System.Workflow.ComponentModel.ActivityCollectionChangeEventArgs listChangeArgs) { }
    protected override void OnDragDrop(System.Workflow.ComponentModel.Design.ActivityDragEventArgs e) { }
    protected override void OnDragEnter(System.Workflow.ComponentModel.Design.ActivityDragEventArgs e) { }
    protected override void OnDragLeave() { }
    protected override void OnDragOver(System.Workflow.ComponentModel.Design.ActivityDragEventArgs e) { }
    protected override void OnLayoutPosition(System.Workflow.ComponentModel.Design.ActivityDesignerLayoutEventArgs e) { }
    protected override System.Drawing.Size OnLayoutSize(System.Workflow.ComponentModel.Design.ActivityDesignerLayoutEventArgs e) { return default(System.Drawing.Size); }
    protected override void OnShowSmartTagVerbs(System.Drawing.Point smartTagPoint) { }
    protected virtual void OnViewChanged(System.Workflow.ComponentModel.Design.DesignerView view) { }
    protected override void SaveViewState(System.IO.BinaryWriter writer) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public enum TextQuality {
    Aliased = 0,
    AntiAliased = 1,
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class ThemeConfigurationDialog : System.Windows.Forms.Form {
    public ThemeConfigurationDialog(System.IServiceProvider serviceProvider) { }
    public ThemeConfigurationDialog(System.IServiceProvider serviceProvider, System.Workflow.ComponentModel.Design.WorkflowTheme theme) { }
    public System.Workflow.ComponentModel.Design.WorkflowTheme ComposedTheme { get { return default(System.Workflow.ComponentModel.Design.WorkflowTheme); } }
    protected override void Dispose(bool disposing) { }
    protected override void OnClosing(System.ComponentModel.CancelEventArgs e) { }
    protected override void OnHelpRequested(System.Windows.Forms.HelpEventArgs e) { }
    protected override void OnLoad(System.EventArgs e) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public enum ThemeType {
    Default = 0,
    System = 1,
    UserDefined = 2,
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class TypeBrowserDialog : System.Windows.Forms.Form, System.ComponentModel.ISite, System.IServiceProvider {
    public TypeBrowserDialog(System.IServiceProvider serviceProvider, System.Workflow.ComponentModel.Design.ITypeFilterProvider filterProvider, string selectedTypeName) { }
    public TypeBrowserDialog(System.IServiceProvider serviceProvider, System.Workflow.ComponentModel.Design.ITypeFilterProvider filterProvider, string selectedTypeName, System.Workflow.ComponentModel.Compiler.TypeProvider typeProvider) { }
    public System.Type SelectedType { get { return default(System.Type); } }
    System.ComponentModel.IComponent System.ComponentModel.ISite.Component { get { return default(System.ComponentModel.IComponent); } }
    System.ComponentModel.IContainer System.ComponentModel.ISite.Container { get { return default(System.ComponentModel.IContainer); } }
    bool System.ComponentModel.ISite.DesignMode { get { return default(bool); } }
    string System.ComponentModel.ISite.Name { get { return default(string); } set { } }
    protected override void Dispose(bool disposing) { }
    protected override void OnClosing(System.ComponentModel.CancelEventArgs e) { }
    protected override void OnHelpRequested(System.Windows.Forms.HelpEventArgs e) { }
    protected override void OnLoad(System.EventArgs e) { }
    protected override void OnPaint(System.Windows.Forms.PaintEventArgs paintArgs) { }
    protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData) { return default(bool); }
    object System.IServiceProvider.GetService(System.Type serviceType) { return default(object); }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
  public partial class TypeBrowserEditor : System.Drawing.Design.UITypeEditor {
    public TypeBrowserEditor() { }
    public override object EditValue(System.ComponentModel.ITypeDescriptorContext typeDescriptorContext, System.IServiceProvider serviceProvider, object value) { return default(object); }
    public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext typeDescriptorContext) { return default(System.Drawing.Design.UITypeEditorEditStyle); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(192), AllowMultiple=false)]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class TypeFilterProviderAttribute : System.Attribute {
    public TypeFilterProviderAttribute(string typeName) { }
    public TypeFilterProviderAttribute(System.Type type) { }
    public string TypeFilterProviderTypeName { get { return default(string); } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
  public abstract partial class WorkflowDesignerLoader : System.ComponentModel.Design.Serialization.BasicDesignerLoader {
    protected WorkflowDesignerLoader() { }
    public abstract string FileName { get; }
    public virtual bool InDebugMode { get { return default(bool); } }
    protected virtual System.ComponentModel.TypeDescriptionProvider TargetFrameworkTypeDescriptionProvider { get { return default(System.ComponentModel.TypeDescriptionProvider); } }
    public void AddActivityToDesigner(System.Workflow.ComponentModel.Activity activity) { }
    public override void Dispose() { }
    public override void Flush() { }
    public virtual void ForceReload() { }
    public abstract System.IO.TextReader GetFileReader(string filePath);
    public abstract System.IO.TextWriter GetFileWriter(string filePath);
    protected override void Initialize() { }
    protected void LoadDesignerLayout(System.Xml.XmlReader layoutReader, out System.Collections.IList layoutLoadErrors) { layoutLoadErrors = default(System.Collections.IList); }
    protected void LoadDesignerLayoutFromResource(System.Type type, string manifestResourceName, out System.Collections.IList errors) { errors = default(System.Collections.IList); }
    protected override void OnEndLoad(bool successful, System.Collections.ICollection errors) { }
    protected override void PerformFlush(System.ComponentModel.Design.Serialization.IDesignerSerializationManager serializationManager) { }
    protected override void PerformLoad(System.ComponentModel.Design.Serialization.IDesignerSerializationManager serializationManager) { }
    public void RemoveActivityFromDesigner(System.Workflow.ComponentModel.Activity activity) { }
    protected void SaveDesignerLayout(System.Xml.XmlWriter layoutWriter, System.Workflow.ComponentModel.Design.ActivityDesigner rootDesigner, out System.Collections.IList layoutSaveErrors) { layoutSaveErrors = default(System.Collections.IList); }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public abstract partial class WorkflowDesignerMessageFilter : System.IDisposable {
    protected WorkflowDesignerMessageFilter() { }
    protected System.Workflow.ComponentModel.Design.HitTestInfo MessageHitTestContext { get { return default(System.Workflow.ComponentModel.Design.HitTestInfo); } }
    protected System.Workflow.ComponentModel.Design.WorkflowView ParentView { get { return default(System.Workflow.ComponentModel.Design.WorkflowView); } }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    ~WorkflowDesignerMessageFilter() { }
    protected virtual void Initialize(System.Workflow.ComponentModel.Design.WorkflowView parentView) { }
    protected virtual bool OnDragDrop(System.Windows.Forms.DragEventArgs eventArgs) { return default(bool); }
    protected virtual bool OnDragEnter(System.Windows.Forms.DragEventArgs eventArgs) { return default(bool); }
    protected virtual bool OnDragLeave() { return default(bool); }
    protected virtual bool OnDragOver(System.Windows.Forms.DragEventArgs eventArgs) { return default(bool); }
    protected virtual bool OnGiveFeedback(System.Windows.Forms.GiveFeedbackEventArgs eventArgs) { return default(bool); }
    protected virtual bool OnKeyDown(System.Windows.Forms.KeyEventArgs eventArgs) { return default(bool); }
    protected virtual bool OnKeyUp(System.Windows.Forms.KeyEventArgs eventArgs) { return default(bool); }
    protected virtual void OnLayout(System.Windows.Forms.LayoutEventArgs eventArgs) { }
    protected virtual bool OnMouseCaptureChanged() { return default(bool); }
    protected virtual bool OnMouseDoubleClick(System.Windows.Forms.MouseEventArgs eventArgs) { return default(bool); }
    protected virtual bool OnMouseDown(System.Windows.Forms.MouseEventArgs eventArgs) { return default(bool); }
    protected virtual bool OnMouseEnter(System.Windows.Forms.MouseEventArgs eventArgs) { return default(bool); }
    protected virtual bool OnMouseHover(System.Windows.Forms.MouseEventArgs eventArgs) { return default(bool); }
    protected virtual bool OnMouseLeave() { return default(bool); }
    protected virtual bool OnMouseMove(System.Windows.Forms.MouseEventArgs eventArgs) { return default(bool); }
    protected virtual bool OnMouseUp(System.Windows.Forms.MouseEventArgs eventArgs) { return default(bool); }
    protected virtual bool OnMouseWheel(System.Windows.Forms.MouseEventArgs eventArgs) { return default(bool); }
    protected virtual bool OnPaint(System.Windows.Forms.PaintEventArgs eventArgs, System.Drawing.Rectangle viewPort, System.Workflow.ComponentModel.Design.AmbientTheme ambientTheme) { return default(bool); }
    protected virtual bool OnPaintWorkflowAdornments(System.Windows.Forms.PaintEventArgs eventArgs, System.Drawing.Rectangle viewPort, System.Workflow.ComponentModel.Design.AmbientTheme ambientTheme) { return default(bool); }
    protected virtual bool OnQueryContinueDrag(System.Windows.Forms.QueryContinueDragEventArgs eventArgs) { return default(bool); }
    protected virtual bool OnScroll(System.Windows.Forms.ScrollBar sender, int value) { return default(bool); }
    protected virtual bool OnShowContextMenu(System.Drawing.Point screenMenuPoint) { return default(bool); }
    protected virtual void OnThemeChange() { }
    protected virtual bool ProcessMessage(System.Windows.Forms.Message message) { return default(bool); }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class WorkflowMenuCommands : System.ComponentModel.Design.StandardCommands {
    public static readonly System.ComponentModel.Design.CommandID BreakpointActionMenu;
    public static readonly System.ComponentModel.Design.CommandID BreakpointConditionMenu;
    public static readonly System.ComponentModel.Design.CommandID BreakpointConstraintsMenu;
    public static readonly System.ComponentModel.Design.CommandID BreakpointHitCountMenu;
    public static readonly System.ComponentModel.Design.CommandID BreakpointLocationMenu;
    public static readonly System.ComponentModel.Design.CommandID ChangeTheme;
    public static readonly System.ComponentModel.Design.CommandID ClearBreakpointsMenu;
    public static readonly System.ComponentModel.Design.CommandID Collapse;
    public static readonly System.ComponentModel.Design.CommandID CopyToClipboard;
    public static readonly System.ComponentModel.Design.CommandID CreateTheme;
    public static readonly System.Guid DebugCommandSetId;
    public static readonly System.ComponentModel.Design.CommandID DebugStepBranchMenu;
    public static readonly System.ComponentModel.Design.CommandID DebugStepInstanceMenu;
    public static readonly System.Guid DebugWorkflowGroupId;
    public static readonly System.ComponentModel.Design.CommandID DefaultFilter;
    public static readonly System.ComponentModel.Design.CommandID DefaultPage;
    public static readonly System.ComponentModel.Design.CommandID DesignerActionsMenu;
    public static readonly System.ComponentModel.Design.CommandID DesignerProperties;
    public static readonly System.ComponentModel.Design.CommandID Disable;
    public static readonly System.ComponentModel.Design.CommandID Enable;
    public static readonly System.ComponentModel.Design.CommandID EnableBreakpointMenu;
    public static readonly System.ComponentModel.Design.CommandID ExecutionStateMenu;
    public static readonly System.ComponentModel.Design.CommandID Expand;
    public const int FirstZoomCommand = 12544;
    public static readonly System.ComponentModel.Design.CommandID GotoDisassemblyMenu;
    public static readonly System.ComponentModel.Design.CommandID InsertBreakpointMenu;
    public static readonly System.ComponentModel.Design.CommandID InsertTracePointMenu;
    public const int LastZoomCommand = 12551;
    public static readonly System.Guid MenuGuid;
    public static readonly System.ComponentModel.Design.CommandID NewDataBreakpointMenu;
    public static readonly System.ComponentModel.Design.CommandID NewFileTracePointMenu;
    public static readonly System.ComponentModel.Design.CommandID PageDown;
    public static readonly System.ComponentModel.Design.CommandID PageLayoutMenu;
    public static readonly System.ComponentModel.Design.CommandID PageSetup;
    public static readonly System.ComponentModel.Design.CommandID PageUp;
    public static readonly System.ComponentModel.Design.CommandID Pan;
    public static readonly System.ComponentModel.Design.CommandID PanMenu;
    public static readonly System.ComponentModel.Design.CommandID Print;
    public static readonly System.ComponentModel.Design.CommandID PrintPreview;
    public static readonly System.ComponentModel.Design.CommandID PrintPreviewPage;
    public static readonly System.ComponentModel.Design.CommandID RunToCursorMenu;
    public static readonly System.ComponentModel.Design.CommandID SaveAsImage;
    public static readonly System.ComponentModel.Design.CommandID SelectionMenu;
    public static readonly System.ComponentModel.Design.CommandID SetNextStatementMenu;
    public static readonly System.ComponentModel.Design.CommandID ShowAll;
    public static readonly System.ComponentModel.Design.CommandID ShowNextStatementMenu;
    public static readonly System.ComponentModel.Design.CommandID ToggleBreakpointMenu;
    public static readonly int VerbGroupActions;
    public static readonly int VerbGroupDesignerActions;
    public static readonly int VerbGroupEdit;
    public static readonly int VerbGroupGeneral;
    public static readonly int VerbGroupMisc;
    public static readonly int VerbGroupOptions;
    public static readonly int VerbGroupView;
    public static readonly System.Guid WorkflowCommandSetId;
    public const int WorkflowToolBar = 1292;
    public static readonly System.ComponentModel.Design.CommandID Zoom100Mode;
    public static readonly System.ComponentModel.Design.CommandID Zoom150Mode;
    public static readonly System.ComponentModel.Design.CommandID Zoom200Mode;
    public static readonly System.ComponentModel.Design.CommandID Zoom300Mode;
    public static readonly System.ComponentModel.Design.CommandID Zoom400Mode;
    public static readonly System.ComponentModel.Design.CommandID Zoom50Mode;
    public static readonly System.ComponentModel.Design.CommandID Zoom75Mode;
    public static readonly System.ComponentModel.Design.CommandID ZoomIn;
    public static readonly System.ComponentModel.Design.CommandID ZoomLevelCombo;
    public static readonly System.ComponentModel.Design.CommandID ZoomLevelListHandler;
    public static readonly System.ComponentModel.Design.CommandID ZoomMenu;
    public static readonly System.ComponentModel.Design.CommandID ZoomOut;
    public WorkflowMenuCommands() { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class WorkflowOutline : System.Windows.Forms.UserControl {
    public WorkflowOutline(System.IServiceProvider serviceProvider) { }
    protected internal bool NeedsExpandAll { get { return default(bool); } set { } }
    protected internal System.Windows.Forms.TreeNode RootNode { get { return default(System.Windows.Forms.TreeNode); } }
    protected internal System.Windows.Forms.TreeView TreeView { get { return default(System.Windows.Forms.TreeView); } }
    protected internal event System.Windows.Forms.TreeViewCancelEventHandler Expanding { add { } remove { } }
    protected virtual System.Workflow.ComponentModel.Design.WorkflowOutlineNode CreateNewNode(System.Workflow.ComponentModel.Activity activity) { return default(System.Workflow.ComponentModel.Design.WorkflowOutlineNode); }
    protected override void Dispose(bool disposing) { }
    protected System.Workflow.ComponentModel.Design.WorkflowOutlineNode GetNode(System.Workflow.ComponentModel.Activity activity) { return default(System.Workflow.ComponentModel.Design.WorkflowOutlineNode); }
    protected override object GetService(System.Type serviceType) { return default(object); }
    protected virtual void OnBeginUpdate() { }
    protected virtual void OnEndUpdate() { }
    protected override void OnLoad(System.EventArgs e) { }
    protected virtual void OnNodeAdded(System.Workflow.ComponentModel.Design.WorkflowOutlineNode node) { }
    protected virtual void OnNodeSelected(System.Workflow.ComponentModel.Design.WorkflowOutlineNode node) { }
    protected virtual void OnRefreshNode(System.Workflow.ComponentModel.Design.WorkflowOutlineNode node) { }
    protected void RefreshNode(System.Workflow.ComponentModel.Design.WorkflowOutlineNode nodeToUpdate, bool refreshChildNodes) { }
    public void RefreshWorkflowOutline() { }
    public void ReloadWorkflowOutline() { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class WorkflowOutlineNode : System.Windows.Forms.TreeNode {
    public WorkflowOutlineNode(System.Workflow.ComponentModel.Activity activity) { }
    public System.Workflow.ComponentModel.Activity Activity { get { return default(System.Workflow.ComponentModel.Activity); } }
    public virtual void OnActivityRename(string newName) { }
    public virtual void RefreshNode() { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class WorkflowPageSetupDialog : System.Windows.Forms.Form {
    public WorkflowPageSetupDialog(System.IServiceProvider serviceProvider) { }
    protected override void Dispose(bool disposing) { }
    protected override void OnHelpRequested(System.Windows.Forms.HelpEventArgs hlpevent) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class WorkflowTheme : System.IDisposable {
    public WorkflowTheme() { }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Workflow.ComponentModel.Design.AmbientTheme AmbientTheme { get { return default(System.Workflow.ComponentModel.Design.AmbientTheme); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public string ContainingFileDirectory { get { return default(string); } }
    public static System.Workflow.ComponentModel.Design.WorkflowTheme CurrentTheme { get { return default(System.Workflow.ComponentModel.Design.WorkflowTheme); } set { } }
    public string Description { get { return default(string); } set { } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    public System.Collections.IList DesignerThemes { get { return default(System.Collections.IList); } }
    public static bool EnableChangeNotification { get { return default(bool); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public string FilePath { get { return default(string); } set { } }
    public static string LookupPath { get { return default(string); } }
    public string Name { get { return default(string); } set { } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public bool ReadOnly { get { return default(bool); } set { } }
    public static string RegistryKeyPath { get { return default(string); } }
    public static System.Collections.Generic.IDictionary<System.Workflow.ComponentModel.Design.ThemeType, System.String[]> StandardThemes { get { return default(System.Collections.Generic.IDictionary<System.Workflow.ComponentModel.Design.ThemeType, System.String[]>); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Workflow.ComponentModel.Design.ThemeType Type { get { return default(System.Workflow.ComponentModel.Design.ThemeType); } }
    public string Version { get { return default(string); } set { } }
    public static event System.EventHandler ThemeChanged { add { } remove { } }
    public System.Workflow.ComponentModel.Design.WorkflowTheme Clone() { return default(System.Workflow.ComponentModel.Design.WorkflowTheme); }
    public static System.Workflow.ComponentModel.Design.WorkflowTheme CreateStandardTheme(System.Workflow.ComponentModel.Design.ThemeType standardThemeType) { return default(System.Workflow.ComponentModel.Design.WorkflowTheme); }
    ~WorkflowTheme() { }
    public static string GenerateThemeFilePath() { return default(string); }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Workflow.ComponentModel.Design.ActivityDesignerTheme GetDesignerTheme(System.Workflow.ComponentModel.Design.ActivityDesigner designer) { return default(System.Workflow.ComponentModel.Design.ActivityDesignerTheme); }
    public static System.Workflow.ComponentModel.Design.WorkflowTheme Load(System.ComponentModel.Design.Serialization.IDesignerSerializationManager serializationManager, string themeFilePath) { return default(System.Workflow.ComponentModel.Design.WorkflowTheme); }
    public static System.Workflow.ComponentModel.Design.WorkflowTheme Load(string themeFilePath) { return default(System.Workflow.ComponentModel.Design.WorkflowTheme); }
    public static System.Workflow.ComponentModel.Design.WorkflowTheme LoadThemeSettingFromRegistry() { return default(System.Workflow.ComponentModel.Design.WorkflowTheme); }
    public void Save(string themeFilePath) { }
    public static void SaveThemeSettingToRegistry() { }
    void System.IDisposable.Dispose() { }
  }
  [System.ComponentModel.ToolboxItemAttribute(false)]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  [System.Workflow.ComponentModel.Design.ActivityDesignerThemeAttribute(typeof(System.Workflow.ComponentModel.Design.AmbientTheme), Xml="<AmbientTheme xmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/workflow\" ApplyTo=\"System.Workflow.ComponentModel.Design.WorkflowView\" ShowConfigErrors=\"True\" DrawShadow=\"False\" DrawGrayscale=\"False\" DropIndicatorColor=\"0xFF006400\" SelectionForeColor=\"0xFF0000FF\" SelectionPatternColor=\"0xFF606060\" ForeColor=\"0xFF808080\" BackColor=\"0xFFFFFFFF\" ShowGrid=\"False\" GridColor=\"0xFFC0C0C0\" TextQuality=\"Aliased\" DrawRounded=\"True\" ShowDesignerBorder=\"True\" />")]
  public partial class WorkflowView : System.Windows.Forms.UserControl, System.IServiceProvider, System.Windows.Forms.IMessageFilter {
    public WorkflowView() { }
    public WorkflowView(System.IServiceProvider serviceProvider) { }
    public bool EnableFitToScreen { get { return default(bool); } set { } }
    public System.Windows.Forms.HScrollBar HScrollBar { get { return default(System.Windows.Forms.HScrollBar); } }
    public System.Drawing.Printing.PrintDocument PrintDocument { get { return default(System.Drawing.Printing.PrintDocument); } }
    public bool PrintPreviewMode { get { return default(bool); } set { } }
    public System.Workflow.ComponentModel.Design.ActivityDesigner RootDesigner { get { return default(System.Workflow.ComponentModel.Design.ActivityDesigner); } set { } }
    public System.Drawing.Point ScrollPosition { get { return default(System.Drawing.Point); } set { } }
    public int ShadowDepth { get { return default(int); } set { } }
    public System.Drawing.Rectangle ViewPortRectangle { get { return default(System.Drawing.Rectangle); } }
    public System.Drawing.Size ViewPortSize { get { return default(System.Drawing.Size); } }
    public System.Windows.Forms.VScrollBar VScrollBar { get { return default(System.Windows.Forms.VScrollBar); } }
    public int Zoom { get { return default(int); } set { } }
    public event System.EventHandler Idle { add { } remove { } }
    public event System.EventHandler RootDesignerChanged { add { } remove { } }
    public event System.EventHandler ZoomChanged { add { } remove { } }
    public void AddDesignerMessageFilter(System.Workflow.ComponentModel.Design.WorkflowDesignerMessageFilter designerMessageFilter) { }
    public System.Drawing.Point ClientPointToLogical(System.Drawing.Point clientPoint) { return default(System.Drawing.Point); }
    public System.Drawing.Rectangle ClientRectangleToLogical(System.Drawing.Rectangle rectangle) { return default(System.Drawing.Rectangle); }
    public System.Drawing.Size ClientSizeToLogical(System.Drawing.Size clientSize) { return default(System.Drawing.Size); }
    protected override System.Windows.Forms.AccessibleObject CreateAccessibilityInstance() { return default(System.Windows.Forms.AccessibleObject); }
    protected override void Dispose(bool disposing) { }
    public void EnsureVisible(object selectableObject) { }
    public void FitToScreenSize() { }
    public void FitToWorkflowSize() { }
    protected override object GetService(System.Type serviceType) { return default(object); }
    public void InvalidateClientRectangle(System.Drawing.Rectangle clientRectangle) { }
    public void InvalidateLogicalRectangle(System.Drawing.Rectangle logicalRectangle) { }
    public void LoadViewState(System.IO.Stream viewState) { }
    public System.Drawing.Point LogicalPointToClient(System.Drawing.Point logicalPoint) { return default(System.Drawing.Point); }
    public System.Drawing.Point LogicalPointToScreen(System.Drawing.Point logicalPoint) { return default(System.Drawing.Point); }
    public System.Drawing.Rectangle LogicalRectangleToClient(System.Drawing.Rectangle rectangle) { return default(System.Drawing.Rectangle); }
    public System.Drawing.Size LogicalSizeToClient(System.Drawing.Size logicalSize) { return default(System.Drawing.Size); }
    protected override void OnControlAdded(System.Windows.Forms.ControlEventArgs e) { }
    protected override void OnDragDrop(System.Windows.Forms.DragEventArgs dragEventArgs) { }
    protected override void OnDragEnter(System.Windows.Forms.DragEventArgs dragEventArgs) { }
    protected override void OnDragLeave(System.EventArgs e) { }
    protected override void OnDragOver(System.Windows.Forms.DragEventArgs dragEventArgs) { }
    protected override void OnGiveFeedback(System.Windows.Forms.GiveFeedbackEventArgs gfbevent) { }
    protected override void OnKeyDown(System.Windows.Forms.KeyEventArgs e) { }
    protected override void OnKeyUp(System.Windows.Forms.KeyEventArgs e) { }
    protected override void OnLayout(System.Windows.Forms.LayoutEventArgs levent) { }
    protected override void OnMouseCaptureChanged(System.EventArgs e) { }
    protected override void OnMouseDoubleClick(System.Windows.Forms.MouseEventArgs e) { }
    protected override void OnMouseDown(System.Windows.Forms.MouseEventArgs e) { }
    protected override void OnMouseEnter(System.EventArgs e) { }
    protected override void OnMouseHover(System.EventArgs e) { }
    protected override void OnMouseLeave(System.EventArgs e) { }
    protected override void OnMouseMove(System.Windows.Forms.MouseEventArgs e) { }
    protected override void OnMouseUp(System.Windows.Forms.MouseEventArgs e) { }
    protected override void OnMouseWheel(System.Windows.Forms.MouseEventArgs e) { }
    protected override void OnPaint(System.Windows.Forms.PaintEventArgs e) { }
    protected override void OnQueryContinueDrag(System.Windows.Forms.QueryContinueDragEventArgs qcdevent) { }
    protected virtual void OnRootDesignerChanged() { }
    protected virtual void OnZoomChanged() { }
    public void PerformLayout(bool immediateUpdate) { }
    public void RemoveDesignerMessageFilter(System.Workflow.ComponentModel.Design.WorkflowDesignerMessageFilter designerMessageFilter) { }
    public void SaveViewState(System.IO.Stream viewState) { }
    public void SaveWorkflowImage(System.IO.Stream stream, System.Drawing.Imaging.ImageFormat imageFormat) { }
    public void SaveWorkflowImage(string imageFile, System.Drawing.Imaging.ImageFormat imageFormat) { }
    public void SaveWorkflowImageToClipboard() { }
    public System.Drawing.Point ScreenPointToLogical(System.Drawing.Point screenPoint) { return default(System.Drawing.Point); }
    public void ShowInfoTip(string text) { }
    public void ShowInfoTip(string title, string text) { }
    public void ShowInPlaceToolTip(string toolTipText, System.Drawing.Rectangle toolTipRectangle) { }
    object System.IServiceProvider.GetService(System.Type serviceType) { return default(object); }
    bool System.Windows.Forms.IMessageFilter.PreFilterMessage(ref System.Windows.Forms.Message m) { return default(bool); }
    [System.Security.Permissions.UIPermissionAttribute(System.Security.Permissions.SecurityAction.Assert, Window=(System.Security.Permissions.UIPermissionWindow)(3))]
    protected override void WndProc(ref System.Windows.Forms.Message m) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class WorkflowViewAccessibleObject : System.Windows.Forms.Control.ControlAccessibleObject {
    public WorkflowViewAccessibleObject(System.Workflow.ComponentModel.Design.WorkflowView workflowView) : base (default(System.Windows.Forms.Control)) { }
    public override System.Drawing.Rectangle Bounds { get { return default(System.Drawing.Rectangle); } }
    public override string DefaultAction { get { return default(string); } }
    public override string Description { get { return default(string); } }
    public override string Help { get { return default(string); } }
    public override string Name { get { return default(string); } set { } }
    public override System.Windows.Forms.AccessibleRole Role { get { return default(System.Windows.Forms.AccessibleRole); } }
    public override System.Windows.Forms.AccessibleObject GetChild(int index) { return default(System.Windows.Forms.AccessibleObject); }
    public override int GetChildCount() { return default(int); }
    public override System.Windows.Forms.AccessibleObject Navigate(System.Windows.Forms.AccessibleNavigation navdir) { return default(System.Windows.Forms.AccessibleObject); }
  }
}
namespace System.Workflow.ComponentModel.Serialization {
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class ActivityCodeDomSerializationManager : System.ComponentModel.Design.Serialization.IDesignerSerializationManager, System.IServiceProvider {
    public ActivityCodeDomSerializationManager(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager) { }
    public System.ComponentModel.Design.Serialization.ContextStack Context { get { return default(System.ComponentModel.Design.Serialization.ContextStack); } }
    public System.ComponentModel.PropertyDescriptorCollection Properties { get { return default(System.ComponentModel.PropertyDescriptorCollection); } }
    protected System.ComponentModel.Design.Serialization.IDesignerSerializationManager SerializationManager { get { return default(System.ComponentModel.Design.Serialization.IDesignerSerializationManager); } set { } }
    public event System.ComponentModel.Design.Serialization.ResolveNameEventHandler ResolveName { add { } remove { } }
    public event System.EventHandler SerializationComplete { add { } remove { } }
    public void AddSerializationProvider(System.ComponentModel.Design.Serialization.IDesignerSerializationProvider provider) { }
    public object CreateInstance(System.Type type, System.Collections.ICollection arguments, string name, bool addToContainer) { return default(object); }
    public object GetInstance(string name) { return default(object); }
    public string GetName(object value) { return default(string); }
    public object GetSerializer(System.Type objectType, System.Type serializerType) { return default(object); }
    public object GetService(System.Type serviceType) { return default(object); }
    public System.Type GetType(string typeName) { return default(System.Type); }
    public void RemoveSerializationProvider(System.ComponentModel.Design.Serialization.IDesignerSerializationProvider provider) { }
    public void ReportError(object errorInformation) { }
    public void SetName(object instance, string name) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class ActivityCodeDomSerializer : System.Workflow.ComponentModel.Serialization.DependencyObjectCodeDomSerializer {
    public static readonly System.Workflow.ComponentModel.DependencyProperty MarkupFileNameProperty;
    public ActivityCodeDomSerializer() { }
    public override object Serialize(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object obj) { return default(object); }
  }
  [System.ComponentModel.Design.Serialization.DefaultSerializationProviderAttribute(typeof(System.Workflow.ComponentModel.Serialization.ActivityMarkupSerializationProvider))]
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class ActivityMarkupSerializer : System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializer {
    public static readonly System.Workflow.ComponentModel.DependencyProperty EndColumnProperty;
    public static readonly System.Workflow.ComponentModel.DependencyProperty EndLineProperty;
    public static readonly System.Workflow.ComponentModel.DependencyProperty StartColumnProperty;
    public static readonly System.Workflow.ComponentModel.DependencyProperty StartLineProperty;
    public ActivityMarkupSerializer() { }
    protected override object CreateInstance(System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializationManager serializationManager, System.Type type) { return default(object); }
    protected override void OnAfterSerialize(System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializationManager serializationManager, object obj) { }
    protected override void OnBeforeSerialize(System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializationManager serializationManager, object obj) { }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public sealed partial class ActivitySurrogateSelector : System.Runtime.Serialization.SurrogateSelector {
    public ActivitySurrogateSelector() { }
    public static System.Workflow.ComponentModel.Serialization.ActivitySurrogateSelector Default { get { return default(System.Workflow.ComponentModel.Serialization.ActivitySurrogateSelector); } }
    public override System.Runtime.Serialization.ISerializationSurrogate GetSurrogate(System.Type type, System.Runtime.Serialization.StreamingContext context, out System.Runtime.Serialization.ISurrogateSelector selector) { selector = default(System.Runtime.Serialization.ISurrogateSelector); return default(System.Runtime.Serialization.ISerializationSurrogate); }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class ActivityTypeCodeDomSerializer : System.ComponentModel.Design.Serialization.TypeCodeDomSerializer {
    public ActivityTypeCodeDomSerializer() { }
    public override object Deserialize(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, System.CodeDom.CodeTypeDeclaration declaration) { return default(object); }
    protected override System.CodeDom.CodeMemberMethod GetInitializeMethod(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, System.CodeDom.CodeTypeDeclaration typeDecl, object value) { return default(System.CodeDom.CodeMemberMethod); }
    protected override System.CodeDom.CodeMemberMethod[] GetInitializeMethods(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, System.CodeDom.CodeTypeDeclaration typeDecl) { return default(System.CodeDom.CodeMemberMethod[]); }
    public override System.CodeDom.CodeTypeDeclaration Serialize(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object root, System.Collections.ICollection members) { return default(System.CodeDom.CodeTypeDeclaration); }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class CompositeActivityMarkupSerializer : System.Workflow.ComponentModel.Serialization.ActivityMarkupSerializer {
    public CompositeActivityMarkupSerializer() { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(128), AllowMultiple=false, Inherited=false)]
  public sealed partial class ConstructorArgumentAttribute : System.Attribute {
    public ConstructorArgumentAttribute(string argumentName) { }
    public string ArgumentName { get { return default(string); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false, Inherited=true)]
  public sealed partial class ContentPropertyAttribute : System.Attribute {
    public ContentPropertyAttribute() { }
    public ContentPropertyAttribute(string name) { }
    public string Name { get { return default(string); } }
  }
  [System.ObsoleteAttribute("The System.Workflow.* types are deprecated.  Instead, please use the new types from System.Activities.*")]
  public partial class DependencyObjectCodeDomSerializer : System.ComponentModel.Design.Serialization.CodeDomSerializer {
    public DependencyObjectCodeDomSerializer() { }
    public override object Serialize(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object obj) { return default(object); }
  }
  public abstract partial class MarkupExtension {
    protected MarkupExtension() { }
    public abstract object ProvideValue(System.IServiceProvider provider);
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
  public sealed partial class RuntimeNamePropertyAttribute : System.Attribute {
    public RuntimeNamePropertyAttribute(string name) { }
    public string Name { get { return default(string); } }
  }
  public partial class WorkflowMarkupSerializationException : System.Exception {
    public WorkflowMarkupSerializationException() { }
    protected WorkflowMarkupSerializationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public WorkflowMarkupSerializationException(string message) { }
    public WorkflowMarkupSerializationException(string message, System.Exception innerException) { }
    public WorkflowMarkupSerializationException(string message, System.Exception innerException, int lineNumber, int columnNumber) { }
    public WorkflowMarkupSerializationException(string message, int lineNumber, int columnNumber) { }
    public int LineNumber { get { return default(int); } }
    public int LinePosition { get { return default(int); } }
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial class WorkflowMarkupSerializationManager : System.ComponentModel.Design.Serialization.IDesignerSerializationManager, System.IServiceProvider {
    public WorkflowMarkupSerializationManager(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager) { }
    public System.ComponentModel.Design.Serialization.ContextStack Context { get { return default(System.ComponentModel.Design.Serialization.ContextStack); } }
    public System.Reflection.Assembly LocalAssembly { get { return default(System.Reflection.Assembly); } set { } }
    protected internal System.ComponentModel.Design.Serialization.IDesignerSerializationManager SerializationManager { get { return default(System.ComponentModel.Design.Serialization.IDesignerSerializationManager); } set { } }
    System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.Design.Serialization.IDesignerSerializationManager.Properties { get { return default(System.ComponentModel.PropertyDescriptorCollection); } }
    event System.ComponentModel.Design.Serialization.ResolveNameEventHandler System.ComponentModel.Design.Serialization.IDesignerSerializationManager.ResolveName { add { } remove { } }
    event System.EventHandler System.ComponentModel.Design.Serialization.IDesignerSerializationManager.SerializationComplete { add { } remove { } }
    public void AddSerializationProvider(System.ComponentModel.Design.Serialization.IDesignerSerializationProvider provider) { }
    public object GetSerializer(System.Type objectType, System.Type serializerType) { return default(object); }
    public object GetService(System.Type serviceType) { return default(object); }
    public virtual System.Type GetType(string typeName) { return default(System.Type); }
    public virtual System.Type GetType(System.Xml.XmlQualifiedName xmlQualifiedName) { return default(System.Type); }
    public virtual System.Xml.XmlQualifiedName GetXmlQualifiedName(System.Type type, out string prefix) { prefix = default(string); return default(System.Xml.XmlQualifiedName); }
    public void RemoveSerializationProvider(System.ComponentModel.Design.Serialization.IDesignerSerializationProvider provider) { }
    public void ReportError(object errorInformation) { }
    object System.ComponentModel.Design.Serialization.IDesignerSerializationManager.CreateInstance(System.Type type, System.Collections.ICollection arguments, string name, bool addToContainer) { return default(object); }
    object System.ComponentModel.Design.Serialization.IDesignerSerializationManager.GetInstance(string name) { return default(object); }
    string System.ComponentModel.Design.Serialization.IDesignerSerializationManager.GetName(object value) { return default(string); }
    void System.ComponentModel.Design.Serialization.IDesignerSerializationManager.SetName(object instance, string name) { }
  }
  [System.ComponentModel.Design.Serialization.DefaultSerializationProviderAttribute(typeof(System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializationProvider))]
  public partial class WorkflowMarkupSerializer {
    public static readonly System.Workflow.ComponentModel.DependencyProperty ClrNamespacesProperty;
    public static readonly System.Workflow.ComponentModel.DependencyProperty EventsProperty;
    public static readonly System.Workflow.ComponentModel.DependencyProperty XClassProperty;
    public static readonly System.Workflow.ComponentModel.DependencyProperty XCodeProperty;
    public WorkflowMarkupSerializer() { }
    protected internal virtual void AddChild(System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializationManager serializationManager, object parentObject, object childObj) { }
    protected internal virtual bool CanSerializeToString(System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializationManager serializationManager, object value) { return default(bool); }
    protected internal virtual void ClearChildren(System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializationManager serializationManager, object obj) { }
    protected virtual object CreateInstance(System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializationManager serializationManager, System.Type type) { return default(object); }
    public object Deserialize(System.ComponentModel.Design.Serialization.IDesignerSerializationManager serializationManager, System.Xml.XmlReader reader) { return default(object); }
    public object Deserialize(System.Xml.XmlReader reader) { return default(object); }
    protected internal virtual object DeserializeFromString(System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializationManager serializationManager, System.Type propertyType, string value) { return default(object); }
    protected internal virtual System.Collections.IList GetChildren(System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializationManager serializationManager, object obj) { return default(System.Collections.IList); }
    protected internal virtual System.Reflection.EventInfo[] GetEvents(System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializationManager serializationManager, object obj) { return default(System.Reflection.EventInfo[]); }
    protected internal virtual System.Reflection.PropertyInfo[] GetProperties(System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializationManager serializationManager, object obj) { return default(System.Reflection.PropertyInfo[]); }
    protected virtual void OnAfterDeserialize(System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializationManager serializationManager, object obj) { }
    protected virtual void OnAfterSerialize(System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializationManager serializationManager, object obj) { }
    protected virtual void OnBeforeDeserialize(System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializationManager serializationManager, object obj) { }
    protected virtual void OnBeforeSerialize(System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializationManager serializationManager, object obj) { }
    public void Serialize(System.ComponentModel.Design.Serialization.IDesignerSerializationManager serializationManager, System.Xml.XmlWriter writer, object obj) { }
    public void Serialize(System.Xml.XmlWriter writer, object obj) { }
    protected internal virtual string SerializeToString(System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializationManager serializationManager, object value) { return default(string); }
    protected internal virtual bool ShouldSerializeValue(System.Workflow.ComponentModel.Serialization.WorkflowMarkupSerializationManager serializationManager, object value) { return default(bool); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(1), AllowMultiple=true)]
  public sealed partial class XmlnsDefinitionAttribute : System.Attribute {
    public XmlnsDefinitionAttribute(string xmlNamespace, string clrNamespace) { }
    public string AssemblyName { get { return default(string); } set { } }
    public string ClrNamespace { get { return default(string); } }
    public string XmlNamespace { get { return default(string); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(1), AllowMultiple=true)]
  public sealed partial class XmlnsPrefixAttribute : System.Attribute {
    public XmlnsPrefixAttribute(string xmlNamespace, string prefix) { }
    public string Prefix { get { return default(string); } }
    public string XmlNamespace { get { return default(string); } }
  }
}
