namespace System.ComponentModel.Design {
  public partial class ActiveDesignSurfaceChangedEventArgs : System.EventArgs {
    public ActiveDesignSurfaceChangedEventArgs(System.ComponentModel.Design.DesignSurface oldSurface, System.ComponentModel.Design.DesignSurface newSurface) { }
    public System.ComponentModel.Design.DesignSurface NewSurface { get { return default(System.ComponentModel.Design.DesignSurface); } }
    public System.ComponentModel.Design.DesignSurface OldSurface { get { return default(System.ComponentModel.Design.DesignSurface); } }
  }
  public delegate void ActiveDesignSurfaceChangedEventHandler(object sender, System.ComponentModel.Design.ActiveDesignSurfaceChangedEventArgs e);
  public partial class ArrayEditor : System.ComponentModel.Design.CollectionEditor {
    public ArrayEditor(System.Type type) : base (default(System.Type)) { }
    protected override System.Type CreateCollectionItemType() { return default(System.Type); }
    protected override System.Object[] GetItems(object editValue) { return default(System.Object[]); }
    protected override object SetItems(object editValue, System.Object[] value) { return default(object); }
  }
  public sealed partial class BinaryEditor : System.Drawing.Design.UITypeEditor {
    public BinaryEditor() { }
    public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { return default(object); }
    public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { return default(System.Drawing.Design.UITypeEditorEditStyle); }
  }
  [System.ComponentModel.DesignTimeVisibleAttribute(false)]
  [System.ComponentModel.ToolboxItemAttribute(false)]
  public partial class ByteViewer : System.Windows.Forms.TableLayoutPanel {
    public ByteViewer() { }
    public virtual System.Byte[] GetBytes() { return default(System.Byte[]); }
    public virtual System.ComponentModel.Design.DisplayMode GetDisplayMode() { return default(System.ComponentModel.Design.DisplayMode); }
    protected override void OnKeyDown(System.Windows.Forms.KeyEventArgs e) { }
    protected override void OnLayout(System.Windows.Forms.LayoutEventArgs e) { }
    protected override void OnPaint(System.Windows.Forms.PaintEventArgs e) { }
    public virtual void SaveToFile(string path) { }
    protected virtual void ScrollChanged(object source, System.EventArgs e) { }
    public virtual void SetBytes(System.Byte[] bytes) { }
    public virtual void SetDisplayMode(System.ComponentModel.Design.DisplayMode mode) { }
    public virtual void SetFile(string path) { }
    public virtual void SetStartLine(int line) { }
  }
  public partial class CollectionEditor : System.Drawing.Design.UITypeEditor {
    public CollectionEditor(System.Type type) { }
    protected System.Type CollectionItemType { get { return default(System.Type); } }
    protected System.Type CollectionType { get { return default(System.Type); } }
    protected System.ComponentModel.ITypeDescriptorContext Context { get { return default(System.ComponentModel.ITypeDescriptorContext); } }
    protected virtual string HelpTopic { get { return default(string); } }
    protected System.Type[] NewItemTypes { get { return default(System.Type[]); } }
    protected virtual void CancelChanges() { }
    protected virtual bool CanRemoveInstance(object value) { return default(bool); }
    protected virtual bool CanSelectMultipleInstances() { return default(bool); }
    protected virtual System.ComponentModel.Design.CollectionEditor.CollectionForm CreateCollectionForm() { return default(System.ComponentModel.Design.CollectionEditor.CollectionForm); }
    protected virtual System.Type CreateCollectionItemType() { return default(System.Type); }
    protected virtual object CreateInstance(System.Type itemType) { return default(object); }
    protected virtual System.Type[] CreateNewItemTypes() { return default(System.Type[]); }
    protected virtual void DestroyInstance(object instance) { }
    public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { return default(object); }
    protected virtual string GetDisplayText(object value) { return default(string); }
    public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { return default(System.Drawing.Design.UITypeEditorEditStyle); }
    protected virtual System.Object[] GetItems(object editValue) { return default(System.Object[]); }
    protected virtual System.Collections.IList GetObjectsFromInstance(object instance) { return default(System.Collections.IList); }
    protected object GetService(System.Type serviceType) { return default(object); }
    protected virtual object SetItems(object editValue, System.Object[] value) { return default(object); }
    protected virtual void ShowHelp() { }
    protected abstract partial class CollectionForm : System.Windows.Forms.Form {
      public CollectionForm(System.ComponentModel.Design.CollectionEditor editor) { }
      protected System.Type CollectionItemType { get { return default(System.Type); } }
      protected System.Type CollectionType { get { return default(System.Type); } }
      protected System.ComponentModel.ITypeDescriptorContext Context { get { return default(System.ComponentModel.ITypeDescriptorContext); } }
      public object EditValue { get { return default(object); } set { } }
      protected System.Object[] Items { get { return default(System.Object[]); } set { } }
      protected System.Type[] NewItemTypes { get { return default(System.Type[]); } }
      protected bool CanRemoveInstance(object value) { return default(bool); }
      protected virtual bool CanSelectMultipleInstances() { return default(bool); }
      protected object CreateInstance(System.Type itemType) { return default(object); }
      protected void DestroyInstance(object instance) { }
      protected virtual void DisplayError(System.Exception e) { }
      protected override object GetService(System.Type serviceType) { return default(object); }
      protected abstract void OnEditValueChanged();
      protected internal virtual System.Windows.Forms.DialogResult ShowEditorDialog(System.Windows.Forms.Design.IWindowsFormsEditorService edSvc) { return default(System.Windows.Forms.DialogResult); }
    }
  }
  public enum ComponentActionsType {
    All = 0,
    Component = 1,
    Service = 2,
  }
  public partial class ComponentDesigner : System.ComponentModel.Design.IComponentInitializer, System.ComponentModel.Design.IDesigner, System.ComponentModel.Design.IDesignerFilter, System.ComponentModel.Design.ITreeDesigner, System.IDisposable {
    public ComponentDesigner() { }
    public virtual System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { return default(System.ComponentModel.Design.DesignerActionListCollection); } }
    public virtual System.Collections.ICollection AssociatedComponents { get { return default(System.Collections.ICollection); } }
    public System.ComponentModel.IComponent Component { get { return default(System.ComponentModel.IComponent); } }
    protected virtual System.ComponentModel.InheritanceAttribute InheritanceAttribute { get { return default(System.ComponentModel.InheritanceAttribute); } }
    protected bool Inherited { get { return default(bool); } }
    protected virtual System.ComponentModel.IComponent ParentComponent { get { return default(System.ComponentModel.IComponent); } }
    protected System.ComponentModel.Design.ComponentDesigner.ShadowPropertyCollection ShadowProperties { get { return default(System.ComponentModel.Design.ComponentDesigner.ShadowPropertyCollection); } }
    System.Collections.ICollection System.ComponentModel.Design.ITreeDesigner.Children { get { return default(System.Collections.ICollection); } }
    System.ComponentModel.Design.IDesigner System.ComponentModel.Design.ITreeDesigner.Parent { get { return default(System.ComponentModel.Design.IDesigner); } }
    public virtual System.ComponentModel.Design.DesignerVerbCollection Verbs { get { return default(System.ComponentModel.Design.DesignerVerbCollection); } }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public virtual void DoDefaultAction() { }
    ~ComponentDesigner() { }
    protected virtual object GetService(System.Type serviceType) { return default(object); }
    public virtual void Initialize(System.ComponentModel.IComponent component) { }
    public virtual void InitializeExistingComponent(System.Collections.IDictionary defaultValues) { }
    public virtual void InitializeNewComponent(System.Collections.IDictionary defaultValues) { }
    [System.ObsoleteAttribute("This method has been deprecated. Use InitializeExistingComponent instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
    public virtual void InitializeNonDefault() { }
    protected System.ComponentModel.InheritanceAttribute InvokeGetInheritanceAttribute(System.ComponentModel.Design.ComponentDesigner toInvoke) { return default(System.ComponentModel.InheritanceAttribute); }
    [System.ObsoleteAttribute("This method has been deprecated. Use InitializeNewComponent instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
    public virtual void OnSetComponentDefaults() { }
    protected virtual void PostFilterAttributes(System.Collections.IDictionary attributes) { }
    protected virtual void PostFilterEvents(System.Collections.IDictionary events) { }
    protected virtual void PostFilterProperties(System.Collections.IDictionary properties) { }
    protected virtual void PreFilterAttributes(System.Collections.IDictionary attributes) { }
    protected virtual void PreFilterEvents(System.Collections.IDictionary events) { }
    protected virtual void PreFilterProperties(System.Collections.IDictionary properties) { }
    protected void RaiseComponentChanged(System.ComponentModel.MemberDescriptor member, object oldValue, object newValue) { }
    protected void RaiseComponentChanging(System.ComponentModel.MemberDescriptor member) { }
    void System.ComponentModel.Design.IDesignerFilter.PostFilterAttributes(System.Collections.IDictionary attributes) { }
    void System.ComponentModel.Design.IDesignerFilter.PostFilterEvents(System.Collections.IDictionary events) { }
    void System.ComponentModel.Design.IDesignerFilter.PostFilterProperties(System.Collections.IDictionary properties) { }
    void System.ComponentModel.Design.IDesignerFilter.PreFilterAttributes(System.Collections.IDictionary attributes) { }
    void System.ComponentModel.Design.IDesignerFilter.PreFilterEvents(System.Collections.IDictionary events) { }
    void System.ComponentModel.Design.IDesignerFilter.PreFilterProperties(System.Collections.IDictionary properties) { }
    protected sealed partial class ShadowPropertyCollection {
      internal ShadowPropertyCollection() { }
      public object this[string propertyName] { get { return default(object); } set { } }
      public bool Contains(string propertyName) { return default(bool); }
    }
  }
  public partial class DateTimeEditor : System.Drawing.Design.UITypeEditor {
    public DateTimeEditor() { }
    public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { return default(object); }
    public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { return default(System.Drawing.Design.UITypeEditorEditStyle); }
  }
  public sealed partial class DesignerActionHeaderItem : System.ComponentModel.Design.DesignerActionTextItem {
    public DesignerActionHeaderItem(string displayName) : base (default(string), default(string)) { }
    public DesignerActionHeaderItem(string displayName, string category) : base (default(string), default(string)) { }
  }
  public abstract partial class DesignerActionItem {
    public DesignerActionItem(string displayName, string category, string description) { }
    public bool AllowAssociate { get { return default(bool); } set { } }
    public virtual string Category { get { return default(string); } }
    public virtual string Description { get { return default(string); } }
    public virtual string DisplayName { get { return default(string); } }
    public System.Collections.IDictionary Properties { get { return default(System.Collections.IDictionary); } }
    public bool ShowInSourceView { get { return default(bool); } set { } }
  }
  public partial class DesignerActionItemCollection : System.Collections.CollectionBase {
    public DesignerActionItemCollection() { }
    public System.ComponentModel.Design.DesignerActionItem this[int index] { get { return default(System.ComponentModel.Design.DesignerActionItem); } set { } }
    public int Add(System.ComponentModel.Design.DesignerActionItem value) { return default(int); }
    public bool Contains(System.ComponentModel.Design.DesignerActionItem value) { return default(bool); }
    public void CopyTo(System.ComponentModel.Design.DesignerActionItem[] array, int index) { }
    public int IndexOf(System.ComponentModel.Design.DesignerActionItem value) { return default(int); }
    public void Insert(int index, System.ComponentModel.Design.DesignerActionItem value) { }
    public void Remove(System.ComponentModel.Design.DesignerActionItem value) { }
  }
  public partial class DesignerActionList {
    public DesignerActionList(System.ComponentModel.IComponent component) { }
    public virtual bool AutoShow { get { return default(bool); } set { } }
    public System.ComponentModel.IComponent Component { get { return default(System.ComponentModel.IComponent); } }
    public object GetService(System.Type serviceType) { return default(object); }
    public virtual System.ComponentModel.Design.DesignerActionItemCollection GetSortedActionItems() { return default(System.ComponentModel.Design.DesignerActionItemCollection); }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Security.SecurityCriticalAttribute]
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
  public partial class DesignerActionListCollection : System.Collections.CollectionBase {
    public DesignerActionListCollection() { }
    public DesignerActionListCollection(System.ComponentModel.Design.DesignerActionList[] value) { }
    public System.ComponentModel.Design.DesignerActionList this[int index] { get { return default(System.ComponentModel.Design.DesignerActionList); } set { } }
    public int Add(System.ComponentModel.Design.DesignerActionList value) { return default(int); }
    public void AddRange(System.ComponentModel.Design.DesignerActionList[] value) { }
    public void AddRange(System.ComponentModel.Design.DesignerActionListCollection value) { }
    public bool Contains(System.ComponentModel.Design.DesignerActionList value) { return default(bool); }
    public void CopyTo(System.ComponentModel.Design.DesignerActionList[] array, int index) { }
    public int IndexOf(System.ComponentModel.Design.DesignerActionList value) { return default(int); }
    public void Insert(int index, System.ComponentModel.Design.DesignerActionList value) { }
    protected override void OnClear() { }
    protected override void OnInsert(int index, object value) { }
    protected override void OnRemove(int index, object value) { }
    protected override void OnSet(int index, object oldValue, object newValue) { }
    protected override void OnValidate(object value) { }
    public void Remove(System.ComponentModel.Design.DesignerActionList value) { }
  }
  public partial class DesignerActionListsChangedEventArgs : System.EventArgs {
    public DesignerActionListsChangedEventArgs(object relatedObject, System.ComponentModel.Design.DesignerActionListsChangedType changeType, System.ComponentModel.Design.DesignerActionListCollection actionLists) { }
    public System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { return default(System.ComponentModel.Design.DesignerActionListCollection); } }
    public System.ComponentModel.Design.DesignerActionListsChangedType ChangeType { get { return default(System.ComponentModel.Design.DesignerActionListsChangedType); } }
    public object RelatedObject { get { return default(object); } }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public delegate void DesignerActionListsChangedEventHandler(object sender, System.ComponentModel.Design.DesignerActionListsChangedEventArgs e);
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public enum DesignerActionListsChangedType {
    ActionListsAdded = 0,
    ActionListsRemoved = 1,
  }
  public partial class DesignerActionMethodItem : System.ComponentModel.Design.DesignerActionItem {
    public DesignerActionMethodItem(System.ComponentModel.Design.DesignerActionList actionList, string memberName, string displayName) : base (default(string), default(string), default(string)) { }
    public DesignerActionMethodItem(System.ComponentModel.Design.DesignerActionList actionList, string memberName, string displayName, bool includeAsDesignerVerb) : base (default(string), default(string), default(string)) { }
    public DesignerActionMethodItem(System.ComponentModel.Design.DesignerActionList actionList, string memberName, string displayName, string category) : base (default(string), default(string), default(string)) { }
    public DesignerActionMethodItem(System.ComponentModel.Design.DesignerActionList actionList, string memberName, string displayName, string category, bool includeAsDesignerVerb) : base (default(string), default(string), default(string)) { }
    public DesignerActionMethodItem(System.ComponentModel.Design.DesignerActionList actionList, string memberName, string displayName, string category, string description) : base (default(string), default(string), default(string)) { }
    public DesignerActionMethodItem(System.ComponentModel.Design.DesignerActionList actionList, string memberName, string displayName, string category, string description, bool includeAsDesignerVerb) : base (default(string), default(string), default(string)) { }
    public virtual bool IncludeAsDesignerVerb { get { return default(bool); } }
    public virtual string MemberName { get { return default(string); } }
    public System.ComponentModel.IComponent RelatedComponent { get { return default(System.ComponentModel.IComponent); } set { } }
    public virtual void Invoke() { }
  }
  public sealed partial class DesignerActionPropertyItem : System.ComponentModel.Design.DesignerActionItem {
    public DesignerActionPropertyItem(string memberName, string displayName) : base (default(string), default(string), default(string)) { }
    public DesignerActionPropertyItem(string memberName, string displayName, string category) : base (default(string), default(string), default(string)) { }
    public DesignerActionPropertyItem(string memberName, string displayName, string category, string description) : base (default(string), default(string), default(string)) { }
    public string MemberName { get { return default(string); } }
    public System.ComponentModel.IComponent RelatedComponent { get { return default(System.ComponentModel.IComponent); } set { } }
  }
  public partial class DesignerActionService : System.IDisposable {
    public DesignerActionService(System.IServiceProvider serviceProvider) { }
    public event System.ComponentModel.Design.DesignerActionListsChangedEventHandler DesignerActionListsChanged { add { } remove { } }
    public void Add(System.ComponentModel.IComponent comp, System.ComponentModel.Design.DesignerActionList actionList) { }
    public void Add(System.ComponentModel.IComponent comp, System.ComponentModel.Design.DesignerActionListCollection designerActionListCollection) { }
    public void Clear() { }
    public bool Contains(System.ComponentModel.IComponent comp) { return default(bool); }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public System.ComponentModel.Design.DesignerActionListCollection GetComponentActions(System.ComponentModel.IComponent component) { return default(System.ComponentModel.Design.DesignerActionListCollection); }
    public virtual System.ComponentModel.Design.DesignerActionListCollection GetComponentActions(System.ComponentModel.IComponent component, System.ComponentModel.Design.ComponentActionsType type) { return default(System.ComponentModel.Design.DesignerActionListCollection); }
    protected virtual void GetComponentDesignerActions(System.ComponentModel.IComponent component, System.ComponentModel.Design.DesignerActionListCollection actionLists) { }
    protected virtual void GetComponentServiceActions(System.ComponentModel.IComponent component, System.ComponentModel.Design.DesignerActionListCollection actionLists) { }
    public void Remove(System.ComponentModel.Design.DesignerActionList actionList) { }
    public void Remove(System.ComponentModel.IComponent comp) { }
    public void Remove(System.ComponentModel.IComponent comp, System.ComponentModel.Design.DesignerActionList actionList) { }
  }
  public partial class DesignerActionTextItem : System.ComponentModel.Design.DesignerActionItem {
    public DesignerActionTextItem(string displayName, string category) : base (default(string), default(string), default(string)) { }
  }
  public sealed partial class DesignerActionUIService : System.IDisposable {
    internal DesignerActionUIService() { }
    public event System.ComponentModel.Design.DesignerActionUIStateChangeEventHandler DesignerActionUIStateChange { add { } remove { } }
    public void Dispose() { }
    public void HideUI(System.ComponentModel.IComponent component) { }
    public void Refresh(System.ComponentModel.IComponent component) { }
    public bool ShouldAutoShow(System.ComponentModel.IComponent component) { return default(bool); }
    public void ShowUI(System.ComponentModel.IComponent component) { }
  }
  public partial class DesignerActionUIStateChangeEventArgs : System.EventArgs {
    public DesignerActionUIStateChangeEventArgs(object relatedObject, System.ComponentModel.Design.DesignerActionUIStateChangeType changeType) { }
    public System.ComponentModel.Design.DesignerActionUIStateChangeType ChangeType { get { return default(System.ComponentModel.Design.DesignerActionUIStateChangeType); } }
    public object RelatedObject { get { return default(object); } }
  }
  public delegate void DesignerActionUIStateChangeEventHandler(object sender, System.ComponentModel.Design.DesignerActionUIStateChangeEventArgs e);
  public enum DesignerActionUIStateChangeType {
    Hide = 1,
    Refresh = 2,
    Show = 0,
  }
  public partial class DesignerCommandSet {
    public DesignerCommandSet() { }
    public System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { return default(System.ComponentModel.Design.DesignerActionListCollection); } }
    public System.ComponentModel.Design.DesignerVerbCollection Verbs { get { return default(System.ComponentModel.Design.DesignerVerbCollection); } }
    public virtual System.Collections.ICollection GetCommands(string name) { return default(System.Collections.ICollection); }
  }
  [System.Security.SecurityCriticalAttribute]
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
  public partial class DesignSurface : System.IDisposable, System.IServiceProvider {
    public DesignSurface() { }
    public DesignSurface(System.IServiceProvider parentProvider) { }
    public DesignSurface(System.IServiceProvider parentProvider, System.Type rootComponentType) { }
    public DesignSurface(System.Type rootComponentType) { }
    public System.ComponentModel.IContainer ComponentContainer { get { return default(System.ComponentModel.IContainer); } }
    public bool DtelLoading { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool IsLoaded { get { return default(bool); } }
    public System.Collections.ICollection LoadErrors { get { return default(System.Collections.ICollection); } }
    protected System.ComponentModel.Design.ServiceContainer ServiceContainer { get { return default(System.ComponentModel.Design.ServiceContainer); } }
    public object View { get { return default(object); } }
    public event System.EventHandler Disposed { add { } remove { } }
    public event System.EventHandler Flushed { add { } remove { } }
    public event System.ComponentModel.Design.LoadedEventHandler Loaded { add { } remove { } }
    public event System.EventHandler Loading { add { } remove { } }
    public event System.EventHandler Unloaded { add { } remove { } }
    public event System.EventHandler Unloading { add { } remove { } }
    public event System.EventHandler ViewActivated { add { } remove { } }
    public void BeginLoad(System.ComponentModel.Design.Serialization.DesignerLoader loader) { }
    public void BeginLoad(System.Type rootComponentType) { }
    [System.ObsoleteAttribute("CreateComponent has been replaced by CreateInstance and will be removed after Beta2")]
    protected internal virtual System.ComponentModel.IComponent CreateComponent(System.Type componentType) { return default(System.ComponentModel.IComponent); }
    protected internal virtual System.ComponentModel.Design.IDesigner CreateDesigner(System.ComponentModel.IComponent component, bool rootDesigner) { return default(System.ComponentModel.Design.IDesigner); }
    protected internal virtual object CreateInstance(System.Type type) { return default(object); }
    public System.ComponentModel.INestedContainer CreateNestedContainer(System.ComponentModel.IComponent owningComponent) { return default(System.ComponentModel.INestedContainer); }
    public System.ComponentModel.INestedContainer CreateNestedContainer(System.ComponentModel.IComponent owningComponent, string containerName) { return default(System.ComponentModel.INestedContainer); }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public void Flush() { }
    public object GetService(System.Type serviceType) { return default(object); }
    protected virtual void OnLoaded(System.ComponentModel.Design.LoadedEventArgs e) { }
    protected virtual void OnLoading(System.EventArgs e) { }
    protected virtual void OnUnloaded(System.EventArgs e) { }
    protected virtual void OnUnloading(System.EventArgs e) { }
    protected virtual void OnViewActivate(System.EventArgs e) { }
  }
  public sealed partial class DesignSurfaceCollection : System.Collections.ICollection, System.Collections.IEnumerable {
    internal DesignSurfaceCollection() { }
    public int Count { get { return default(int); } }
    public System.ComponentModel.Design.DesignSurface this[int index] { get { return default(System.ComponentModel.Design.DesignSurface); } }
    int System.Collections.ICollection.Count { get { return default(int); } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    public void CopyTo(System.ComponentModel.Design.DesignSurface[] array, int index) { }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public partial class DesignSurfaceEventArgs : System.EventArgs {
    public DesignSurfaceEventArgs(System.ComponentModel.Design.DesignSurface surface) { }
    public System.ComponentModel.Design.DesignSurface Surface { get { return default(System.ComponentModel.Design.DesignSurface); } }
  }
  public delegate void DesignSurfaceEventHandler(object sender, System.ComponentModel.Design.DesignSurfaceEventArgs e);
  [System.Security.SecurityCriticalAttribute]
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
  public partial class DesignSurfaceManager : System.IDisposable, System.IServiceProvider {
    public DesignSurfaceManager() { }
    public DesignSurfaceManager(System.IServiceProvider parentProvider) { }
    public virtual System.ComponentModel.Design.DesignSurface ActiveDesignSurface { get { return default(System.ComponentModel.Design.DesignSurface); } set { } }
    public System.ComponentModel.Design.DesignSurfaceCollection DesignSurfaces { get { return default(System.ComponentModel.Design.DesignSurfaceCollection); } }
    protected System.ComponentModel.Design.ServiceContainer ServiceContainer { get { return default(System.ComponentModel.Design.ServiceContainer); } }
    public event System.ComponentModel.Design.ActiveDesignSurfaceChangedEventHandler ActiveDesignSurfaceChanged { add { } remove { } }
    public event System.ComponentModel.Design.DesignSurfaceEventHandler DesignSurfaceCreated { add { } remove { } }
    public event System.ComponentModel.Design.DesignSurfaceEventHandler DesignSurfaceDisposed { add { } remove { } }
    public event System.EventHandler SelectionChanged { add { } remove { } }
    public System.ComponentModel.Design.DesignSurface CreateDesignSurface() { return default(System.ComponentModel.Design.DesignSurface); }
    public System.ComponentModel.Design.DesignSurface CreateDesignSurface(System.IServiceProvider parentProvider) { return default(System.ComponentModel.Design.DesignSurface); }
    protected virtual System.ComponentModel.Design.DesignSurface CreateDesignSurfaceCore(System.IServiceProvider parentProvider) { return default(System.ComponentModel.Design.DesignSurface); }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public object GetService(System.Type serviceType) { return default(object); }
  }
  public enum DisplayMode {
    Ansi = 2,
    Auto = 4,
    Hexdump = 1,
    Unicode = 3,
  }
  [System.Security.SecurityCriticalAttribute]
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
  public abstract partial class EventBindingService : System.ComponentModel.Design.IEventBindingService {
    protected EventBindingService(System.IServiceProvider provider) { }
    protected abstract string CreateUniqueMethodName(System.ComponentModel.IComponent component, System.ComponentModel.EventDescriptor e);
    protected virtual void FreeMethod(System.ComponentModel.IComponent component, System.ComponentModel.EventDescriptor e, string methodName) { }
    protected abstract System.Collections.ICollection GetCompatibleMethods(System.ComponentModel.EventDescriptor e);
    protected object GetService(System.Type serviceType) { return default(object); }
    protected abstract bool ShowCode();
    protected abstract bool ShowCode(System.ComponentModel.IComponent component, System.ComponentModel.EventDescriptor e, string methodName);
    protected abstract bool ShowCode(int lineNumber);
    string System.ComponentModel.Design.IEventBindingService.CreateUniqueMethodName(System.ComponentModel.IComponent component, System.ComponentModel.EventDescriptor e) { return default(string); }
    System.Collections.ICollection System.ComponentModel.Design.IEventBindingService.GetCompatibleMethods(System.ComponentModel.EventDescriptor e) { return default(System.Collections.ICollection); }
    System.ComponentModel.EventDescriptor System.ComponentModel.Design.IEventBindingService.GetEvent(System.ComponentModel.PropertyDescriptor property) { return default(System.ComponentModel.EventDescriptor); }
    System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.Design.IEventBindingService.GetEventProperties(System.ComponentModel.EventDescriptorCollection events) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    System.ComponentModel.PropertyDescriptor System.ComponentModel.Design.IEventBindingService.GetEventProperty(System.ComponentModel.EventDescriptor e) { return default(System.ComponentModel.PropertyDescriptor); }
    bool System.ComponentModel.Design.IEventBindingService.ShowCode() { return default(bool); }
    bool System.ComponentModel.Design.IEventBindingService.ShowCode(System.ComponentModel.IComponent component, System.ComponentModel.EventDescriptor e) { return default(bool); }
    bool System.ComponentModel.Design.IEventBindingService.ShowCode(int lineNumber) { return default(bool); }
    protected virtual void UseMethod(System.ComponentModel.IComponent component, System.ComponentModel.EventDescriptor e, string methodName) { }
    protected virtual void ValidateMethodName(string methodName) { }
  }
  public sealed partial class ExceptionCollection : System.Exception {
    public ExceptionCollection(System.Collections.ArrayList exceptions) { }
    public System.Collections.ArrayList Exceptions { get { return default(System.Collections.ArrayList); } }
    [System.Security.SecurityCriticalAttribute]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial interface IComponentDesignerDebugService {
    int IndentLevel { get; set; }
    System.Diagnostics.TraceListenerCollection Listeners { get; }
    void Assert(bool condition, string message);
    void Fail(string message);
    void Trace(string message, string category);
  }
  public partial interface IComponentDesignerStateService {
    object GetState(System.ComponentModel.IComponent component, string key);
    void SetState(System.ComponentModel.IComponent component, string key, object value);
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  [System.Runtime.InteropServices.GuidAttribute("665f0ba5-ce72-4e87-9ba0-3c461de74d0b")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
  public partial interface IDesignTimeAssemblyLoader {
    string GetTargetAssemblyPath(System.Reflection.AssemblyName runtimeOrTargetAssemblyName, string suggestedAssemblyPath, System.Runtime.Versioning.FrameworkName targetFramework);
    System.Reflection.Assembly LoadRuntimeAssembly(System.Reflection.AssemblyName targetAssemblyName);
  }
  public partial interface IMultitargetHelperService {
    string GetAssemblyQualifiedName(System.Type type);
  }
  public partial class InheritanceService : System.ComponentModel.Design.IInheritanceService, System.IDisposable {
    public InheritanceService() { }
    public void AddInheritedComponents(System.ComponentModel.IComponent component, System.ComponentModel.IContainer container) { }
    protected virtual void AddInheritedComponents(System.Type type, System.ComponentModel.IComponent component, System.ComponentModel.IContainer container) { }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public System.ComponentModel.InheritanceAttribute GetInheritanceAttribute(System.ComponentModel.IComponent component) { return default(System.ComponentModel.InheritanceAttribute); }
    protected virtual bool IgnoreInheritedMember(System.Reflection.MemberInfo member, System.ComponentModel.IComponent component) { return default(bool); }
  }
  public sealed partial class LoadedEventArgs : System.EventArgs {
    public LoadedEventArgs(bool succeeded, System.Collections.ICollection errors) { }
    public System.Collections.ICollection Errors { get { return default(System.Collections.ICollection); } }
    public bool HasSucceeded { get { return default(bool); } }
  }
  public delegate void LoadedEventHandler(object sender, System.ComponentModel.Design.LoadedEventArgs e);
  [System.ComponentModel.ProvidePropertyAttribute("Language", typeof(object))]
  [System.ComponentModel.ProvidePropertyAttribute("LoadLanguage", typeof(object))]
  [System.ComponentModel.ProvidePropertyAttribute("Localizable", typeof(object))]
  [System.ObsoleteAttribute("This class has been deprecated. Use CodeDomLocalizationProvider instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
  public partial class LocalizationExtenderProvider : System.ComponentModel.IExtenderProvider, System.IDisposable {
    public LocalizationExtenderProvider(System.ComponentModel.ISite serviceProvider, System.ComponentModel.IComponent baseComponent) { }
    public bool CanExtend(object o) { return default(bool); }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    [System.ComponentModel.DesignOnlyAttribute(true)]
    [System.ComponentModel.LocalizableAttribute(true)]
    [System.Design.SRDescriptionAttribute("ParentControlDesignerLanguageDescr")]
    public System.Globalization.CultureInfo GetLanguage(object o) { return default(System.Globalization.CultureInfo); }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.DesignOnlyAttribute(true)]
    public System.Globalization.CultureInfo GetLoadLanguage(object o) { return default(System.Globalization.CultureInfo); }
    [System.ComponentModel.DesignOnlyAttribute(true)]
    [System.ComponentModel.LocalizableAttribute(true)]
    [System.Design.SRDescriptionAttribute("ParentControlDesignerLocalizableDescr")]
    public bool GetLocalizable(object o) { return default(bool); }
    public void ResetLanguage(object o) { }
    public void SetLanguage(object o, System.Globalization.CultureInfo language) { }
    public void SetLocalizable(object o, bool localizable) { }
    public bool ShouldSerializeLanguage(object o) { return default(bool); }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class MenuCommandsChangedEventArgs : System.EventArgs {
    public MenuCommandsChangedEventArgs(System.ComponentModel.Design.MenuCommandsChangedType changeType, System.ComponentModel.Design.MenuCommand command) { }
    public System.ComponentModel.Design.MenuCommandsChangedType ChangeType { get { return default(System.ComponentModel.Design.MenuCommandsChangedType); } }
    public System.ComponentModel.Design.MenuCommand Command { get { return default(System.ComponentModel.Design.MenuCommand); } }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public delegate void MenuCommandsChangedEventHandler(object sender, System.ComponentModel.Design.MenuCommandsChangedEventArgs e);
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public enum MenuCommandsChangedType {
    CommandAdded = 0,
    CommandChanged = 2,
    CommandRemoved = 1,
  }
  public partial class MenuCommandService : System.ComponentModel.Design.IMenuCommandService, System.IDisposable {
    public MenuCommandService(System.IServiceProvider serviceProvider) { }
    public virtual System.ComponentModel.Design.DesignerVerbCollection Verbs { get { return default(System.ComponentModel.Design.DesignerVerbCollection); } }
    public event System.ComponentModel.Design.MenuCommandsChangedEventHandler MenuCommandsChanged { add { } remove { } }
    public virtual void AddCommand(System.ComponentModel.Design.MenuCommand command) { }
    public virtual void AddVerb(System.ComponentModel.Design.DesignerVerb verb) { }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    protected void EnsureVerbs() { }
    public System.ComponentModel.Design.MenuCommand FindCommand(System.ComponentModel.Design.CommandID commandID) { return default(System.ComponentModel.Design.MenuCommand); }
    protected System.ComponentModel.Design.MenuCommand FindCommand(System.Guid guid, int id) { return default(System.ComponentModel.Design.MenuCommand); }
    protected System.Collections.ICollection GetCommandList(System.Guid guid) { return default(System.Collections.ICollection); }
    protected object GetService(System.Type serviceType) { return default(object); }
    public virtual bool GlobalInvoke(System.ComponentModel.Design.CommandID commandID) { return default(bool); }
    public virtual bool GlobalInvoke(System.ComponentModel.Design.CommandID commandId, object arg) { return default(bool); }
    protected virtual void OnCommandsChanged(System.ComponentModel.Design.MenuCommandsChangedEventArgs e) { }
    public virtual void RemoveCommand(System.ComponentModel.Design.MenuCommand command) { }
    public virtual void RemoveVerb(System.ComponentModel.Design.DesignerVerb verb) { }
    public virtual void ShowContextMenu(System.ComponentModel.Design.CommandID menuID, int x, int y) { }
  }
  public sealed partial class MultilineStringEditor : System.Drawing.Design.UITypeEditor {
    public MultilineStringEditor() { }
    public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { return default(object); }
    public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { return default(System.Drawing.Design.UITypeEditorEditStyle); }
    public override bool GetPaintValueSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
  }
  public abstract partial class ObjectSelectorEditor : System.Drawing.Design.UITypeEditor {
    protected object currValue;
    protected object prevValue;
    public bool SubObjectSelector;
    public ObjectSelectorEditor() { }
    public ObjectSelectorEditor(bool subObjectSelector) { }
    public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { return default(object); }
    public bool EqualsToValue(object value) { return default(bool); }
    protected virtual void FillTreeWithData(System.ComponentModel.Design.ObjectSelectorEditor.Selector selector, System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider) { }
    public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { return default(System.Drawing.Design.UITypeEditorEditStyle); }
    public virtual void SetValue(object value) { }
    public partial class Selector : System.Windows.Forms.TreeView {
      public bool clickSeen;
      public Selector(System.ComponentModel.Design.ObjectSelectorEditor editor) { }
      public System.ComponentModel.Design.ObjectSelectorEditor.SelectorNode AddNode(string label, object value, System.ComponentModel.Design.ObjectSelectorEditor.SelectorNode parent) { return default(System.ComponentModel.Design.ObjectSelectorEditor.SelectorNode); }
      public void Clear() { }
      protected void OnAfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e) { }
      protected override void OnKeyDown(System.Windows.Forms.KeyEventArgs e) { }
      protected override void OnKeyPress(System.Windows.Forms.KeyPressEventArgs e) { }
      protected override void OnNodeMouseClick(System.Windows.Forms.TreeNodeMouseClickEventArgs e) { }
      public bool SetSelection(object value, System.Windows.Forms.TreeNodeCollection nodes) { return default(bool); }
      public void Start(System.Windows.Forms.Design.IWindowsFormsEditorService edSvc, object value) { }
      public void Stop() { }
      protected override void WndProc(ref System.Windows.Forms.Message m) { }
    }
    public partial class SelectorNode : System.Windows.Forms.TreeNode {
      public object value;
      public SelectorNode(string label, object value) { }
    }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(1036))]
  public sealed partial class ProjectTargetFrameworkAttribute : System.Attribute {
    public ProjectTargetFrameworkAttribute(string targetFrameworkMoniker) { }
    public string TargetFrameworkMoniker { get { return default(string); } }
  }
  public abstract partial class UndoEngine : System.IDisposable {
    protected UndoEngine(System.IServiceProvider provider) { }
    public bool Enabled { get { return default(bool); } set { } }
    public bool UndoInProgress { get { return default(bool); } }
    public event System.EventHandler Undoing { add { } remove { } }
    public event System.EventHandler Undone { add { } remove { } }
    protected abstract void AddUndoUnit(System.ComponentModel.Design.UndoEngine.UndoUnit unit);
    protected virtual System.ComponentModel.Design.UndoEngine.UndoUnit CreateUndoUnit(string name, bool primary) { return default(System.ComponentModel.Design.UndoEngine.UndoUnit); }
    protected virtual void DiscardUndoUnit(System.ComponentModel.Design.UndoEngine.UndoUnit unit) { }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    protected object GetRequiredService(System.Type serviceType) { return default(object); }
    protected object GetService(System.Type serviceType) { return default(object); }
    protected virtual void OnUndoing(System.EventArgs e) { }
    protected virtual void OnUndone(System.EventArgs e) { }
    protected partial class UndoUnit {
      public UndoUnit(System.ComponentModel.Design.UndoEngine engine, string name) { }
      public virtual bool IsEmpty { get { return default(bool); } }
      public string Name { get { return default(string); } }
      protected System.ComponentModel.Design.UndoEngine UndoEngine { get { return default(System.ComponentModel.Design.UndoEngine); } }
      public virtual void Close() { }
      public virtual void ComponentAdded(System.ComponentModel.Design.ComponentEventArgs e) { }
      public virtual void ComponentAdding(System.ComponentModel.Design.ComponentEventArgs e) { }
      public virtual void ComponentChanged(System.ComponentModel.Design.ComponentChangedEventArgs e) { }
      public virtual void ComponentChanging(System.ComponentModel.Design.ComponentChangingEventArgs e) { }
      public virtual void ComponentRemoved(System.ComponentModel.Design.ComponentEventArgs e) { }
      public virtual void ComponentRemoving(System.ComponentModel.Design.ComponentEventArgs e) { }
      public virtual void ComponentRename(System.ComponentModel.Design.ComponentRenameEventArgs e) { }
      protected object GetService(System.Type serviceType) { return default(object); }
      public override string ToString() { return default(string); }
      public void Undo() { }
      protected virtual void UndoCore() { }
    }
  }
}
namespace System.ComponentModel.Design.Data {
  public abstract partial class DataSourceDescriptor {
    protected DataSourceDescriptor() { }
    public abstract System.Drawing.Bitmap Image { get; }
    public abstract bool IsDesignable { get; }
    public abstract string Name { get; }
    public abstract string TypeName { get; }
  }
  public partial class DataSourceDescriptorCollection : System.Collections.CollectionBase {
    public DataSourceDescriptorCollection() { }
    public System.ComponentModel.Design.Data.DataSourceDescriptor this[int index] { get { return default(System.ComponentModel.Design.Data.DataSourceDescriptor); } set { } }
    public int Add(System.ComponentModel.Design.Data.DataSourceDescriptor value) { return default(int); }
    public bool Contains(System.ComponentModel.Design.Data.DataSourceDescriptor value) { return default(bool); }
    public void CopyTo(System.ComponentModel.Design.Data.DataSourceDescriptor[] array, int index) { }
    public int IndexOf(System.ComponentModel.Design.Data.DataSourceDescriptor value) { return default(int); }
    public void Insert(int index, System.ComponentModel.Design.Data.DataSourceDescriptor value) { }
    public void Remove(System.ComponentModel.Design.Data.DataSourceDescriptor value) { }
  }
  public abstract partial class DataSourceGroup {
    protected DataSourceGroup() { }
    public abstract System.ComponentModel.Design.Data.DataSourceDescriptorCollection DataSources { get; }
    public abstract System.Drawing.Bitmap Image { get; }
    public abstract bool IsDefault { get; }
    public abstract string Name { get; }
  }
  public partial class DataSourceGroupCollection : System.Collections.CollectionBase {
    public DataSourceGroupCollection() { }
    public System.ComponentModel.Design.Data.DataSourceGroup this[int index] { get { return default(System.ComponentModel.Design.Data.DataSourceGroup); } set { } }
    public int Add(System.ComponentModel.Design.Data.DataSourceGroup value) { return default(int); }
    public bool Contains(System.ComponentModel.Design.Data.DataSourceGroup value) { return default(bool); }
    public void CopyTo(System.ComponentModel.Design.Data.DataSourceGroup[] array, int index) { }
    public int IndexOf(System.ComponentModel.Design.Data.DataSourceGroup value) { return default(int); }
    public void Insert(int index, System.ComponentModel.Design.Data.DataSourceGroup value) { }
    public void Remove(System.ComponentModel.Design.Data.DataSourceGroup value) { }
  }
  [System.Runtime.InteropServices.GuidAttribute("ABE5C1F0-C96E-40c4-A22D-4A5CEC899BDC")]
  public abstract partial class DataSourceProviderService {
    protected DataSourceProviderService() { }
    public abstract bool SupportsAddNewDataSource { get; }
    public abstract bool SupportsConfigureDataSource { get; }
    public abstract object AddDataSourceInstance(System.ComponentModel.Design.IDesignerHost host, System.ComponentModel.Design.Data.DataSourceDescriptor dataSourceDescriptor);
    public abstract System.ComponentModel.Design.Data.DataSourceGroupCollection GetDataSources();
    public abstract System.ComponentModel.Design.Data.DataSourceGroup InvokeAddNewDataSource(System.Windows.Forms.IWin32Window parentWindow, System.Windows.Forms.FormStartPosition startPosition);
    public abstract bool InvokeConfigureDataSource(System.Windows.Forms.IWin32Window parentWindow, System.Windows.Forms.FormStartPosition startPosition, System.ComponentModel.Design.Data.DataSourceDescriptor dataSourceDescriptor);
    public abstract void NotifyDataSourceComponentAdded(object dsc);
  }
  public sealed partial class DesignerDataColumn {
    public DesignerDataColumn(string name, System.Data.DbType dataType) { }
    public DesignerDataColumn(string name, System.Data.DbType dataType, object defaultValue) { }
    public DesignerDataColumn(string name, System.Data.DbType dataType, object defaultValue, bool identity, bool nullable, bool primaryKey, int precision, int scale, int length) { }
    public System.Data.DbType DataType { get { return default(System.Data.DbType); } }
    public object DefaultValue { get { return default(object); } }
    public bool Identity { get { return default(bool); } }
    public int Length { get { return default(int); } }
    public string Name { get { return default(string); } }
    public bool Nullable { get { return default(bool); } }
    public int Precision { get { return default(int); } }
    public bool PrimaryKey { get { return default(bool); } }
    public int Scale { get { return default(int); } }
  }
  public sealed partial class DesignerDataConnection {
    public DesignerDataConnection(string name, string providerName, string connectionString) { }
    public DesignerDataConnection(string name, string providerName, string connectionString, bool isConfigured) { }
    public string ConnectionString { get { return default(string); } }
    public bool IsConfigured { get { return default(bool); } }
    public string Name { get { return default(string); } }
    public string ProviderName { get { return default(string); } }
  }
  public sealed partial class DesignerDataParameter {
    public DesignerDataParameter(string name, System.Data.DbType dataType, System.Data.ParameterDirection direction) { }
    public System.Data.DbType DataType { get { return default(System.Data.DbType); } }
    public System.Data.ParameterDirection Direction { get { return default(System.Data.ParameterDirection); } }
    public string Name { get { return default(string); } }
  }
  public sealed partial class DesignerDataRelationship {
    public DesignerDataRelationship(string name, System.Collections.ICollection parentColumns, System.ComponentModel.Design.Data.DesignerDataTable childTable, System.Collections.ICollection childColumns) { }
    public System.Collections.ICollection ChildColumns { get { return default(System.Collections.ICollection); } }
    public System.ComponentModel.Design.Data.DesignerDataTable ChildTable { get { return default(System.ComponentModel.Design.Data.DesignerDataTable); } }
    public string Name { get { return default(string); } }
    public System.Collections.ICollection ParentColumns { get { return default(System.Collections.ICollection); } }
  }
  public sealed partial class DesignerDataSchemaClass {
    internal DesignerDataSchemaClass() { }
    public static readonly System.ComponentModel.Design.Data.DesignerDataSchemaClass StoredProcedures;
    public static readonly System.ComponentModel.Design.Data.DesignerDataSchemaClass Tables;
    public static readonly System.ComponentModel.Design.Data.DesignerDataSchemaClass Views;
  }
  public abstract partial class DesignerDataStoredProcedure {
    protected DesignerDataStoredProcedure(string name) { }
    protected DesignerDataStoredProcedure(string name, string owner) { }
    public string Name { get { return default(string); } }
    public string Owner { get { return default(string); } }
    public System.Collections.ICollection Parameters { get { return default(System.Collections.ICollection); } }
    protected abstract System.Collections.ICollection CreateParameters();
  }
  public abstract partial class DesignerDataTable : System.ComponentModel.Design.Data.DesignerDataTableBase {
    protected DesignerDataTable(string name) : base (default(string)) { }
    protected DesignerDataTable(string name, string owner) : base (default(string)) { }
    public System.Collections.ICollection Relationships { get { return default(System.Collections.ICollection); } }
    protected abstract System.Collections.ICollection CreateRelationships();
  }
  public abstract partial class DesignerDataTableBase {
    protected DesignerDataTableBase(string name) { }
    protected DesignerDataTableBase(string name, string owner) { }
    public System.Collections.ICollection Columns { get { return default(System.Collections.ICollection); } }
    public string Name { get { return default(string); } }
    public string Owner { get { return default(string); } }
    protected abstract System.Collections.ICollection CreateColumns();
  }
  public abstract partial class DesignerDataView : System.ComponentModel.Design.Data.DesignerDataTableBase {
    protected DesignerDataView(string name) : base (default(string)) { }
    protected DesignerDataView(string name, string owner) : base (default(string)) { }
  }
  public partial interface IDataEnvironment {
    System.Collections.ICollection Connections { get; }
    System.ComponentModel.Design.Data.DesignerDataConnection BuildConnection(System.Windows.Forms.IWin32Window owner, System.ComponentModel.Design.Data.DesignerDataConnection initialConnection);
    string BuildQuery(System.Windows.Forms.IWin32Window owner, System.ComponentModel.Design.Data.DesignerDataConnection connection, System.ComponentModel.Design.Data.QueryBuilderMode mode, string initialQueryText);
    System.ComponentModel.Design.Data.DesignerDataConnection ConfigureConnection(System.Windows.Forms.IWin32Window owner, System.ComponentModel.Design.Data.DesignerDataConnection connection, string name);
    System.CodeDom.CodeExpression GetCodeExpression(System.ComponentModel.Design.Data.DesignerDataConnection connection);
    System.ComponentModel.Design.Data.IDesignerDataSchema GetConnectionSchema(System.ComponentModel.Design.Data.DesignerDataConnection connection);
    System.Data.Common.DbConnection GetDesignTimeConnection(System.ComponentModel.Design.Data.DesignerDataConnection connection);
  }
  public partial interface IDesignerDataSchema {
    System.Collections.ICollection GetSchemaItems(System.ComponentModel.Design.Data.DesignerDataSchemaClass schemaClass);
    bool SupportsSchemaClass(System.ComponentModel.Design.Data.DesignerDataSchemaClass schemaClass);
  }
  public enum QueryBuilderMode {
    Delete = 3,
    Insert = 2,
    Select = 0,
    Update = 1,
  }
}
namespace System.ComponentModel.Design.Serialization {
  [System.Security.SecurityCriticalAttribute]
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
  public abstract partial class BasicDesignerLoader : System.ComponentModel.Design.Serialization.DesignerLoader, System.ComponentModel.Design.Serialization.IDesignerLoaderService {
    protected BasicDesignerLoader() { }
    protected System.ComponentModel.Design.Serialization.IDesignerLoaderHost LoaderHost { get { return default(System.ComponentModel.Design.Serialization.IDesignerLoaderHost); } }
    public override bool Loading { get { return default(bool); } }
    protected virtual bool Modified { get { return default(bool); } set { } }
    protected object PropertyProvider { get { return default(object); } set { } }
    protected bool ReloadPending { get { return default(bool); } }
    public override void BeginLoad(System.ComponentModel.Design.Serialization.IDesignerLoaderHost host) { }
    public override void Dispose() { }
    protected virtual bool EnableComponentNotification(bool enable) { return default(bool); }
    public override void Flush() { }
    protected object GetService(System.Type serviceType) { return default(object); }
    protected virtual void Initialize() { }
    protected virtual bool IsReloadNeeded() { return default(bool); }
    protected virtual void OnBeginLoad() { }
    protected virtual void OnBeginUnload() { }
    protected virtual void OnEndLoad(bool successful, System.Collections.ICollection errors) { }
    protected virtual void OnModifying() { }
    protected abstract void PerformFlush(System.ComponentModel.Design.Serialization.IDesignerSerializationManager serializationManager);
    protected abstract void PerformLoad(System.ComponentModel.Design.Serialization.IDesignerSerializationManager serializationManager);
    protected void Reload(System.ComponentModel.Design.Serialization.BasicDesignerLoader.ReloadOptions flags) { }
    protected virtual void ReportFlushErrors(System.Collections.ICollection errors) { }
    protected void SetBaseComponentClassName(string name) { }
    void System.ComponentModel.Design.Serialization.IDesignerLoaderService.AddLoadDependency() { }
    void System.ComponentModel.Design.Serialization.IDesignerLoaderService.DependentLoadComplete(bool successful, System.Collections.ICollection errorCollection) { }
    bool System.ComponentModel.Design.Serialization.IDesignerLoaderService.Reload() { return default(bool); }
    [System.FlagsAttribute]
    protected enum ReloadOptions {
      Default = 0,
      Force = 2,
      ModifyOnError = 1,
      NoFlush = 4,
    }
  }
  public sealed partial class CodeDomComponentSerializationService : System.ComponentModel.Design.Serialization.ComponentSerializationService {
    public CodeDomComponentSerializationService() { }
    public CodeDomComponentSerializationService(System.IServiceProvider provider) { }
    public override System.ComponentModel.Design.Serialization.SerializationStore CreateStore() { return default(System.ComponentModel.Design.Serialization.SerializationStore); }
    public override System.Collections.ICollection Deserialize(System.ComponentModel.Design.Serialization.SerializationStore store) { return default(System.Collections.ICollection); }
    public override System.Collections.ICollection Deserialize(System.ComponentModel.Design.Serialization.SerializationStore store, System.ComponentModel.IContainer container) { return default(System.Collections.ICollection); }
    public override void DeserializeTo(System.ComponentModel.Design.Serialization.SerializationStore store, System.ComponentModel.IContainer container, bool validateRecycledTypes, bool applyDefaults) { }
    public override System.ComponentModel.Design.Serialization.SerializationStore LoadStore(System.IO.Stream stream) { return default(System.ComponentModel.Design.Serialization.SerializationStore); }
    public override void Serialize(System.ComponentModel.Design.Serialization.SerializationStore store, object value) { }
    public override void SerializeAbsolute(System.ComponentModel.Design.Serialization.SerializationStore store, object value) { }
    public override void SerializeMember(System.ComponentModel.Design.Serialization.SerializationStore store, object owningObject, System.ComponentModel.MemberDescriptor member) { }
    public override void SerializeMemberAbsolute(System.ComponentModel.Design.Serialization.SerializationStore store, object owningObject, System.ComponentModel.MemberDescriptor member) { }
  }
  [System.Security.SecurityCriticalAttribute]
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
  public abstract partial class CodeDomDesignerLoader : System.ComponentModel.Design.Serialization.BasicDesignerLoader, System.ComponentModel.Design.Serialization.IDesignerSerializationService, System.ComponentModel.Design.Serialization.INameCreationService {
    protected CodeDomDesignerLoader() { }
    protected abstract System.CodeDom.Compiler.CodeDomProvider CodeDomProvider { get; }
    protected abstract System.ComponentModel.Design.ITypeResolutionService TypeResolutionService { get; }
    public override void Dispose() { }
    protected override void Initialize() { }
    protected override bool IsReloadNeeded() { return default(bool); }
    protected override void OnBeginLoad() { }
    protected override void OnBeginUnload() { }
    protected virtual void OnComponentRename(object component, string oldName, string newName) { }
    protected override void OnEndLoad(bool successful, System.Collections.ICollection errors) { }
    protected abstract System.CodeDom.CodeCompileUnit Parse();
    protected override void PerformFlush(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager) { }
    protected override void PerformLoad(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager) { }
    System.Collections.ICollection System.ComponentModel.Design.Serialization.IDesignerSerializationService.Deserialize(object serializationData) { return default(System.Collections.ICollection); }
    object System.ComponentModel.Design.Serialization.IDesignerSerializationService.Serialize(System.Collections.ICollection objects) { return default(object); }
    string System.ComponentModel.Design.Serialization.INameCreationService.CreateName(System.ComponentModel.IContainer container, System.Type dataType) { return default(string); }
    bool System.ComponentModel.Design.Serialization.INameCreationService.IsValidName(string name) { return default(bool); }
    void System.ComponentModel.Design.Serialization.INameCreationService.ValidateName(string name) { }
    protected abstract void Write(System.CodeDom.CodeCompileUnit unit);
  }
  public enum CodeDomLocalizationModel {
    None = 0,
    PropertyAssignment = 1,
    PropertyReflection = 2,
  }
  public sealed partial class CodeDomLocalizationProvider : System.ComponentModel.Design.Serialization.IDesignerSerializationProvider, System.IDisposable {
    public CodeDomLocalizationProvider(System.IServiceProvider provider, System.ComponentModel.Design.Serialization.CodeDomLocalizationModel model) { }
    public CodeDomLocalizationProvider(System.IServiceProvider provider, System.ComponentModel.Design.Serialization.CodeDomLocalizationModel model, System.Globalization.CultureInfo[] supportedCultures) { }
    public void Dispose() { }
    object System.ComponentModel.Design.Serialization.IDesignerSerializationProvider.GetSerializer(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object currentSerializer, System.Type objectType, System.Type serializerType) { return default(object); }
  }
  [System.ComponentModel.Design.Serialization.DefaultSerializationProviderAttribute(typeof(System.ComponentModel.Design.Serialization.CodeDomSerializationProvider))]
  public partial class CodeDomSerializer : System.ComponentModel.Design.Serialization.CodeDomSerializerBase {
    public CodeDomSerializer() { }
    public virtual object Deserialize(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object codeObject) { return default(object); }
    protected object DeserializeStatementToInstance(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, System.CodeDom.CodeStatement statement) { return default(object); }
    public virtual string GetTargetComponentName(System.CodeDom.CodeStatement statement, System.CodeDom.CodeExpression expression, System.Type targetType) { return default(string); }
    public virtual object Serialize(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object value) { return default(object); }
    public virtual object SerializeAbsolute(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object value) { return default(object); }
    public virtual System.CodeDom.CodeStatementCollection SerializeMember(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object owningObject, System.ComponentModel.MemberDescriptor member) { return default(System.CodeDom.CodeStatementCollection); }
    public virtual System.CodeDom.CodeStatementCollection SerializeMemberAbsolute(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object owningObject, System.ComponentModel.MemberDescriptor member) { return default(System.CodeDom.CodeStatementCollection); }
    [System.ObsoleteAttribute("This method has been deprecated. Use SerializeToExpression or GetExpression instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
    protected System.CodeDom.CodeExpression SerializeToReferenceExpression(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object value) { return default(System.CodeDom.CodeExpression); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public abstract partial class CodeDomSerializerBase {
    internal CodeDomSerializerBase() { }
    protected object DeserializeExpression(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, string name, System.CodeDom.CodeExpression expression) { return default(object); }
    protected virtual object DeserializeInstance(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, System.Type type, System.Object[] parameters, string name, bool addToContainer) { return default(object); }
    protected void DeserializePropertiesFromResources(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object value, System.Attribute[] filter) { }
    protected void DeserializeStatement(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, System.CodeDom.CodeStatement statement) { }
    protected static System.ComponentModel.AttributeCollection GetAttributesFromTypeHelper(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, System.Type type) { return default(System.ComponentModel.AttributeCollection); }
    protected static System.ComponentModel.AttributeCollection GetAttributesHelper(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object instance) { return default(System.ComponentModel.AttributeCollection); }
    protected static System.ComponentModel.EventDescriptorCollection GetEventsHelper(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object instance, System.Attribute[] attributes) { return default(System.ComponentModel.EventDescriptorCollection); }
    protected System.CodeDom.CodeExpression GetExpression(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object value) { return default(System.CodeDom.CodeExpression); }
    protected static System.ComponentModel.PropertyDescriptorCollection GetPropertiesHelper(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object instance, System.Attribute[] attributes) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    protected static System.Type GetReflectionTypeFromTypeHelper(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, System.Type type) { return default(System.Type); }
    protected static System.Type GetReflectionTypeHelper(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object instance) { return default(System.Type); }
    protected System.ComponentModel.Design.Serialization.CodeDomSerializer GetSerializer(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object value) { return default(System.ComponentModel.Design.Serialization.CodeDomSerializer); }
    protected System.ComponentModel.Design.Serialization.CodeDomSerializer GetSerializer(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, System.Type valueType) { return default(System.ComponentModel.Design.Serialization.CodeDomSerializer); }
    protected static System.ComponentModel.TypeDescriptionProvider GetTargetFrameworkProvider(System.IServiceProvider provider, object instance) { return default(System.ComponentModel.TypeDescriptionProvider); }
    protected string GetUniqueName(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object value) { return default(string); }
    protected bool IsSerialized(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object value) { return default(bool); }
    protected bool IsSerialized(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object value, bool honorPreset) { return default(bool); }
    protected System.CodeDom.CodeExpression SerializeCreationExpression(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object value, out bool isComplete) { isComplete = default(bool); return default(System.CodeDom.CodeExpression); }
    protected void SerializeEvent(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, System.CodeDom.CodeStatementCollection statements, object value, System.ComponentModel.EventDescriptor descriptor) { }
    protected void SerializeEvents(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, System.CodeDom.CodeStatementCollection statements, object value, params System.Attribute[] filter) { }
    protected void SerializeProperties(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, System.CodeDom.CodeStatementCollection statements, object value, System.Attribute[] filter) { }
    protected void SerializePropertiesToResources(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, System.CodeDom.CodeStatementCollection statements, object value, System.Attribute[] filter) { }
    protected void SerializeProperty(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, System.CodeDom.CodeStatementCollection statements, object value, System.ComponentModel.PropertyDescriptor propertyToSerialize) { }
    protected void SerializeResource(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, string resourceName, object value) { }
    protected void SerializeResourceInvariant(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, string resourceName, object value) { }
    protected System.CodeDom.CodeExpression SerializeToExpression(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object value) { return default(System.CodeDom.CodeExpression); }
    protected System.CodeDom.CodeExpression SerializeToResourceExpression(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object value) { return default(System.CodeDom.CodeExpression); }
    protected System.CodeDom.CodeExpression SerializeToResourceExpression(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object value, bool ensureInvariant) { return default(System.CodeDom.CodeExpression); }
    protected void SetExpression(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object value, System.CodeDom.CodeExpression expression) { }
    protected void SetExpression(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object value, System.CodeDom.CodeExpression expression, bool isPreset) { }
  }
  public partial class CodeDomSerializerException : System.SystemException {
    public CodeDomSerializerException(System.Exception ex, System.CodeDom.CodeLinePragma linePragma) { }
    public CodeDomSerializerException(System.Exception ex, System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager) { }
    protected CodeDomSerializerException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public CodeDomSerializerException(string message, System.CodeDom.CodeLinePragma linePragma) { }
    public CodeDomSerializerException(string message, System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager) { }
    public System.CodeDom.CodeLinePragma LinePragma { get { return default(System.CodeDom.CodeLinePragma); } }
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial class CollectionCodeDomSerializer : System.ComponentModel.Design.Serialization.CodeDomSerializer {
    public CollectionCodeDomSerializer() { }
    protected bool MethodSupportsSerialization(System.Reflection.MethodInfo method) { return default(bool); }
    public override object Serialize(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object value) { return default(object); }
    protected virtual object SerializeCollection(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, System.CodeDom.CodeExpression targetExpression, System.Type targetType, System.Collections.ICollection originalCollection, System.Collections.ICollection valuesToSerialize) { return default(object); }
  }
  public partial class DesignerSerializationManager : System.ComponentModel.Design.Serialization.IDesignerSerializationManager, System.IServiceProvider {
    public DesignerSerializationManager() { }
    public DesignerSerializationManager(System.IServiceProvider provider) { }
    public System.ComponentModel.IContainer Container { get { return default(System.ComponentModel.IContainer); } set { } }
    public System.Collections.IList Errors { get { return default(System.Collections.IList); } }
    public bool PreserveNames { get { return default(bool); } set { } }
    public object PropertyProvider { get { return default(object); } set { } }
    public bool RecycleInstances { get { return default(bool); } set { } }
    System.ComponentModel.Design.Serialization.ContextStack System.ComponentModel.Design.Serialization.IDesignerSerializationManager.Context { get { return default(System.ComponentModel.Design.Serialization.ContextStack); } }
    System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.Design.Serialization.IDesignerSerializationManager.Properties { get { return default(System.ComponentModel.PropertyDescriptorCollection); } }
    public bool ValidateRecycledTypes { get { return default(bool); } set { } }
    public event System.EventHandler SessionCreated { add { } remove { } }
    public event System.EventHandler SessionDisposed { add { } remove { } }
    event System.ComponentModel.Design.Serialization.ResolveNameEventHandler System.ComponentModel.Design.Serialization.IDesignerSerializationManager.ResolveName { add { } remove { } }
    event System.EventHandler System.ComponentModel.Design.Serialization.IDesignerSerializationManager.SerializationComplete { add { } remove { } }
    protected virtual object CreateInstance(System.Type type, System.Collections.ICollection arguments, string name, bool addToContainer) { return default(object); }
    public System.IDisposable CreateSession() { return default(System.IDisposable); }
    public System.Type GetRuntimeType(string typeName) { return default(System.Type); }
    public object GetSerializer(System.Type objectType, System.Type serializerType) { return default(object); }
    protected virtual object GetService(System.Type serviceType) { return default(object); }
    protected virtual System.Type GetType(string typeName) { return default(System.Type); }
    protected virtual void OnResolveName(System.ComponentModel.Design.Serialization.ResolveNameEventArgs e) { }
    protected virtual void OnSessionCreated(System.EventArgs e) { }
    protected virtual void OnSessionDisposed(System.EventArgs e) { }
    void System.ComponentModel.Design.Serialization.IDesignerSerializationManager.AddSerializationProvider(System.ComponentModel.Design.Serialization.IDesignerSerializationProvider provider) { }
    object System.ComponentModel.Design.Serialization.IDesignerSerializationManager.CreateInstance(System.Type type, System.Collections.ICollection arguments, string name, bool addToContainer) { return default(object); }
    object System.ComponentModel.Design.Serialization.IDesignerSerializationManager.GetInstance(string name) { return default(object); }
    string System.ComponentModel.Design.Serialization.IDesignerSerializationManager.GetName(object value) { return default(string); }
    object System.ComponentModel.Design.Serialization.IDesignerSerializationManager.GetSerializer(System.Type objectType, System.Type serializerType) { return default(object); }
    System.Type System.ComponentModel.Design.Serialization.IDesignerSerializationManager.GetType(string typeName) { return default(System.Type); }
    void System.ComponentModel.Design.Serialization.IDesignerSerializationManager.RemoveSerializationProvider(System.ComponentModel.Design.Serialization.IDesignerSerializationProvider provider) { }
    void System.ComponentModel.Design.Serialization.IDesignerSerializationManager.ReportError(object errorInformation) { }
    void System.ComponentModel.Design.Serialization.IDesignerSerializationManager.SetName(object instance, string name) { }
    object System.IServiceProvider.GetService(System.Type serviceType) { return default(object); }
  }
  public sealed partial class ExpressionContext {
    public ExpressionContext(System.CodeDom.CodeExpression expression, System.Type expressionType, object owner) { }
    public ExpressionContext(System.CodeDom.CodeExpression expression, System.Type expressionType, object owner, object presetValue) { }
    public System.CodeDom.CodeExpression Expression { get { return default(System.CodeDom.CodeExpression); } }
    public System.Type ExpressionType { get { return default(System.Type); } }
    public object Owner { get { return default(object); } }
    public object PresetValue { get { return default(object); } }
  }
  public partial interface ICodeDomDesignerReload {
    bool ShouldReloadDesigner(System.CodeDom.CodeCompileUnit newTree);
  }
  public abstract partial class MemberCodeDomSerializer : System.ComponentModel.Design.Serialization.CodeDomSerializerBase {
    protected MemberCodeDomSerializer() { }
    public abstract void Serialize(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object value, System.ComponentModel.MemberDescriptor descriptor, System.CodeDom.CodeStatementCollection statements);
    public abstract bool ShouldSerialize(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object value, System.ComponentModel.MemberDescriptor descriptor);
  }
  public sealed partial class ObjectStatementCollection : System.Collections.IEnumerable {
    internal ObjectStatementCollection() { }
    public System.CodeDom.CodeStatementCollection this[object statementOwner] { get { return default(System.CodeDom.CodeStatementCollection); } }
    public bool ContainsKey(object statementOwner) { return default(bool); }
    public System.Collections.IDictionaryEnumerator GetEnumerator() { return default(System.Collections.IDictionaryEnumerator); }
    public void Populate(System.Collections.ICollection statementOwners) { }
    public void Populate(object owner) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public sealed partial class RootContext {
    public RootContext(System.CodeDom.CodeExpression expression, object value) { }
    public System.CodeDom.CodeExpression Expression { get { return default(System.CodeDom.CodeExpression); } }
    public object Value { get { return default(object); } }
  }
  public sealed partial class SerializeAbsoluteContext {
    public SerializeAbsoluteContext() { }
    public SerializeAbsoluteContext(System.ComponentModel.MemberDescriptor member) { }
    public System.ComponentModel.MemberDescriptor Member { get { return default(System.ComponentModel.MemberDescriptor); } }
    public bool ShouldSerialize(System.ComponentModel.MemberDescriptor member) { return default(bool); }
  }
  public sealed partial class StatementContext {
    public StatementContext() { }
    public System.ComponentModel.Design.Serialization.ObjectStatementCollection StatementCollection { get { return default(System.ComponentModel.Design.Serialization.ObjectStatementCollection); } }
  }
  [System.ComponentModel.Design.Serialization.DefaultSerializationProviderAttribute(typeof(System.ComponentModel.Design.Serialization.CodeDomSerializationProvider))]
  public partial class TypeCodeDomSerializer : System.ComponentModel.Design.Serialization.CodeDomSerializerBase {
    public TypeCodeDomSerializer() { }
    public virtual object Deserialize(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, System.CodeDom.CodeTypeDeclaration declaration) { return default(object); }
    protected virtual System.CodeDom.CodeMemberMethod GetInitializeMethod(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, System.CodeDom.CodeTypeDeclaration declaration, object value) { return default(System.CodeDom.CodeMemberMethod); }
    protected virtual System.CodeDom.CodeMemberMethod[] GetInitializeMethods(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, System.CodeDom.CodeTypeDeclaration declaration) { return default(System.CodeDom.CodeMemberMethod[]); }
    public virtual System.CodeDom.CodeTypeDeclaration Serialize(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object root, System.Collections.ICollection members) { return default(System.CodeDom.CodeTypeDeclaration); }
  }
}
namespace System.Data.Design {
  public partial class MethodSignatureGenerator {
    public MethodSignatureGenerator() { }
    public System.CodeDom.Compiler.CodeDomProvider CodeProvider { get { return default(System.CodeDom.Compiler.CodeDomProvider); } set { } }
    public System.Type ContainerParameterType { get { return default(System.Type); } set { } }
    public string DataSetClassName { get { return default(string); } set { } }
    public bool IsGetMethod { get { return default(bool); } set { } }
    public bool PagingMethod { get { return default(bool); } set { } }
    public System.Data.Design.ParameterGenerationOption ParameterOption { get { return default(System.Data.Design.ParameterGenerationOption); } set { } }
    public string TableClassName { get { return default(string); } set { } }
    public System.CodeDom.CodeMemberMethod GenerateMethod() { return default(System.CodeDom.CodeMemberMethod); }
    public string GenerateMethodSignature() { return default(string); }
    public System.CodeDom.CodeTypeDeclaration GenerateUpdatingMethods() { return default(System.CodeDom.CodeTypeDeclaration); }
    public void SetDesignTableContent(string designTableContent) { }
    public void SetMethodSourceContent(string methodSourceContent) { }
  }
  public enum ParameterGenerationOption {
    ClrTypes = 0,
    Objects = 2,
    SqlTypes = 1,
  }
  public sealed partial class TypedDataSetGenerator {
    internal TypedDataSetGenerator() { }
    public static System.Collections.Generic.ICollection<System.Reflection.Assembly> ReferencedAssemblies { get { return default(System.Collections.Generic.ICollection<System.Reflection.Assembly>); } }
    public static string Generate(System.Data.DataSet dataSet, System.CodeDom.CodeNamespace codeNamespace, System.CodeDom.Compiler.CodeDomProvider codeProvider) { return default(string); }
    public static string Generate(string inputFileContent, System.CodeDom.CodeCompileUnit compileUnit, System.CodeDom.CodeNamespace mainNamespace, System.CodeDom.Compiler.CodeDomProvider codeProvider) { return default(string); }
    public static void Generate(string inputFileContent, System.CodeDom.CodeCompileUnit compileUnit, System.CodeDom.CodeNamespace mainNamespace, System.CodeDom.Compiler.CodeDomProvider codeProvider, System.Collections.Hashtable customDBProviders) { }
    public static void Generate(string inputFileContent, System.CodeDom.CodeCompileUnit compileUnit, System.CodeDom.CodeNamespace mainNamespace, System.CodeDom.Compiler.CodeDomProvider codeProvider, System.Collections.Hashtable customDBProviders, System.Data.Design.TypedDataSetGenerator.GenerateOption option) { }
    public static void Generate(string inputFileContent, System.CodeDom.CodeCompileUnit compileUnit, System.CodeDom.CodeNamespace mainNamespace, System.CodeDom.Compiler.CodeDomProvider codeProvider, System.Collections.Hashtable customDBProviders, System.Data.Design.TypedDataSetGenerator.GenerateOption option, string dataSetNamespace) { }
    public static void Generate(string inputFileContent, System.CodeDom.CodeCompileUnit compileUnit, System.CodeDom.CodeNamespace mainNamespace, System.CodeDom.Compiler.CodeDomProvider codeProvider, System.Collections.Hashtable customDBProviders, System.Data.Design.TypedDataSetGenerator.GenerateOption option, string dataSetNamespace, string basePath) { }
    public static void Generate(string inputFileContent, System.CodeDom.CodeCompileUnit compileUnit, System.CodeDom.CodeNamespace mainNamespace, System.CodeDom.Compiler.CodeDomProvider codeProvider, System.Data.Common.DbProviderFactory specifiedFactory) { }
    public static string Generate(string inputFileContent, System.CodeDom.CodeCompileUnit compileUnit, System.CodeDom.CodeNamespace mainNamespace, System.CodeDom.Compiler.CodeDomProvider codeProvider, System.Data.Design.TypedDataSetGenerator.GenerateOption option) { return default(string); }
    public static string Generate(string inputFileContent, System.CodeDom.CodeCompileUnit compileUnit, System.CodeDom.CodeNamespace mainNamespace, System.CodeDom.Compiler.CodeDomProvider codeProvider, System.Data.Design.TypedDataSetGenerator.GenerateOption option, string dataSetNamespace) { return default(string); }
    public static string Generate(string inputFileContent, System.CodeDom.CodeCompileUnit compileUnit, System.CodeDom.CodeNamespace mainNamespace, System.CodeDom.Compiler.CodeDomProvider codeProvider, System.Data.Design.TypedDataSetGenerator.GenerateOption option, string dataSetNamespace, string basePath) { return default(string); }
    public static string GetProviderName(string inputFileContent) { return default(string); }
    public static string GetProviderName(string inputFileContent, string tableName) { return default(string); }
    [System.FlagsAttribute]
    public enum GenerateOption {
      HierarchicalUpdate = 1,
      LinqOverTypedDatasets = 2,
      None = 0,
    }
  }
  public partial class TypedDataSetGeneratorException : System.Data.DataException {
    public TypedDataSetGeneratorException() { }
    public TypedDataSetGeneratorException(System.Collections.IList list) { }
    protected TypedDataSetGeneratorException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public TypedDataSetGeneratorException(string message) { }
    public TypedDataSetGeneratorException(string message, System.Exception innerException) { }
    public System.Collections.IList ErrorList { get { return default(System.Collections.IList); } }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, SerializationFormatter=true)]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial class TypedDataSetSchemaImporterExtension : System.Xml.Serialization.Advanced.SchemaImporterExtension {
    public TypedDataSetSchemaImporterExtension() { }
    protected TypedDataSetSchemaImporterExtension(System.Data.Design.TypedDataSetGenerator.GenerateOption dataSetGenerateOptions) { }
    public override string ImportSchemaType(string name, string namespaceName, System.Xml.Schema.XmlSchemaObject context, System.Xml.Serialization.XmlSchemas schemas, System.Xml.Serialization.XmlSchemaImporter importer, System.CodeDom.CodeCompileUnit compileUnit, System.CodeDom.CodeNamespace mainNamespace, System.Xml.Serialization.CodeGenerationOptions options, System.CodeDom.Compiler.CodeDomProvider codeProvider) { return default(string); }
    public override string ImportSchemaType(System.Xml.Schema.XmlSchemaType type, System.Xml.Schema.XmlSchemaObject context, System.Xml.Serialization.XmlSchemas schemas, System.Xml.Serialization.XmlSchemaImporter importer, System.CodeDom.CodeCompileUnit compileUnit, System.CodeDom.CodeNamespace mainNamespace, System.Xml.Serialization.CodeGenerationOptions options, System.CodeDom.Compiler.CodeDomProvider codeProvider) { return default(string); }
  }
  public partial class TypedDataSetSchemaImporterExtensionFx35 : System.Data.Design.TypedDataSetSchemaImporterExtension {
    public TypedDataSetSchemaImporterExtensionFx35() { }
  }
}
namespace System.Diagnostics.Design {
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class LogConverter : System.ComponentModel.TypeConverter {
    public LogConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { return default(System.ComponentModel.TypeConverter.StandardValuesCollection); }
    public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class ProcessDesigner : System.ComponentModel.Design.ComponentDesigner {
    public ProcessDesigner() { }
    protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class ProcessModuleDesigner : System.ComponentModel.Design.ComponentDesigner {
    public ProcessModuleDesigner() { }
    protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class ProcessThreadDesigner : System.ComponentModel.Design.ComponentDesigner {
    public ProcessThreadDesigner() { }
    protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
  }
}
namespace System.Messaging.Design {
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class MessageDesigner : System.ComponentModel.Design.ComponentDesigner {
    public MessageDesigner() { }
    protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
  }
}
namespace System.Resources.Tools {
  public partial interface ITargetAwareCodeDomProvider {
    bool SupportsProperty(System.Type type, string propertyName, bool isWritable);
  }
  public static partial class StronglyTypedResourceBuilder {
    public static System.CodeDom.CodeCompileUnit Create(System.Collections.IDictionary resourceList, string baseName, string generatedCodeNamespace, System.CodeDom.Compiler.CodeDomProvider codeProvider, bool internalClass, out System.String[] unmatchable) { unmatchable = default(System.String[]); return default(System.CodeDom.CodeCompileUnit); }
    public static System.CodeDom.CodeCompileUnit Create(System.Collections.IDictionary resourceList, string baseName, string generatedCodeNamespace, string resourcesNamespace, System.CodeDom.Compiler.CodeDomProvider codeProvider, bool internalClass, out System.String[] unmatchable) { unmatchable = default(System.String[]); return default(System.CodeDom.CodeCompileUnit); }
    public static System.CodeDom.CodeCompileUnit Create(string resxFile, string baseName, string generatedCodeNamespace, System.CodeDom.Compiler.CodeDomProvider codeProvider, bool internalClass, out System.String[] unmatchable) { unmatchable = default(System.String[]); return default(System.CodeDom.CodeCompileUnit); }
    public static System.CodeDom.CodeCompileUnit Create(string resxFile, string baseName, string generatedCodeNamespace, string resourcesNamespace, System.CodeDom.Compiler.CodeDomProvider codeProvider, bool internalClass, out System.String[] unmatchable) { unmatchable = default(System.String[]); return default(System.CodeDom.CodeCompileUnit); }
    public static string VerifyResourceName(string key, System.CodeDom.Compiler.CodeDomProvider provider) { return default(string); }
  }
}
namespace System.ServiceProcess.Design {
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class ServiceControllerDesigner : System.ComponentModel.Design.ComponentDesigner {
    public ServiceControllerDesigner() { }
    protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
  }
}
namespace System.Web.UI.Design {
  public partial class AppSettingsExpressionEditor : System.Web.UI.Design.ExpressionEditor {
    public AppSettingsExpressionEditor() { }
    public override object EvaluateExpression(string expression, object parseTimeData, System.Type propertyType, System.IServiceProvider serviceProvider) { return default(object); }
    public override System.Web.UI.Design.ExpressionEditorSheet GetExpressionEditorSheet(string expression, System.IServiceProvider serviceProvider) { return default(System.Web.UI.Design.ExpressionEditorSheet); }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class CalendarDataBindingHandler : System.Web.UI.Design.DataBindingHandler {
    public CalendarDataBindingHandler() { }
    public override void DataBindControl(System.ComponentModel.Design.IDesignerHost designerHost, System.Web.UI.Control control) { }
  }
  public sealed partial class ClientScriptItem {
    public ClientScriptItem(string text, string source, string language, string type, string id) { }
    public string Id { get { return default(string); } }
    public string Language { get { return default(string); } }
    public string Source { get { return default(string); } }
    public string Text { get { return default(string); } }
    public string Type { get { return default(string); } }
  }
  public sealed partial class ClientScriptItemCollection : System.Collections.ReadOnlyCollectionBase {
    public ClientScriptItemCollection(System.Web.UI.Design.ClientScriptItem[] clientScriptItems) { }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public sealed partial class ColorBuilder {
    internal ColorBuilder() { }
    public static string BuildColor(System.ComponentModel.IComponent component, System.Windows.Forms.Control owner, string initialColor) { return default(string); }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class ConnectionStringEditor : System.Drawing.Design.UITypeEditor {
    public ConnectionStringEditor() { }
    public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { return default(object); }
    public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { return default(System.Drawing.Design.UITypeEditorEditStyle); }
    protected virtual string GetProviderName(object instance) { return default(string); }
    protected virtual void SetProviderName(object instance, System.ComponentModel.Design.Data.DesignerDataConnection connection) { }
  }
  public partial class ConnectionStringsExpressionEditor : System.Web.UI.Design.ExpressionEditor {
    public ConnectionStringsExpressionEditor() { }
    public override object EvaluateExpression(string expression, object parseTimeData, System.Type propertyType, System.IServiceProvider serviceProvider) { return default(object); }
    public override System.Web.UI.Design.ExpressionEditorSheet GetExpressionEditorSheet(string expression, System.IServiceProvider serviceProvider) { return default(System.Web.UI.Design.ExpressionEditorSheet); }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class ContainerControlDesigner : System.Web.UI.Design.ControlDesigner {
    public ContainerControlDesigner() { }
    public override bool AllowResize { get { return default(bool); } }
    public virtual string FrameCaption { get { return default(string); } }
    public virtual System.Web.UI.WebControls.Style FrameStyle { get { return default(System.Web.UI.WebControls.Style); } }
    protected virtual bool NoWrap { get { return default(bool); } }
    protected virtual void AddDesignTimeCssAttributes(System.Collections.IDictionary styleAttributes) { }
    public virtual System.Collections.IDictionary GetDesignTimeCssAttributes() { return default(System.Collections.IDictionary); }
    public override string GetDesignTimeHtml(System.Web.UI.Design.DesignerRegionCollection regions) { return default(string); }
    public override string GetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region) { return default(string); }
    public override string GetPersistenceContent() { return default(string); }
    public override void SetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region, string content) { }
  }
  public partial class ContentDefinition {
    public ContentDefinition(string id, string content, string designTimeHtml) { }
    public string ContentPlaceHolderID { get { return default(string); } }
    public string DefaultContent { get { return default(string); } }
    public string DefaultDesignTimeHtml { get { return default(string); } }
  }
  public enum ContentDesignerState {
    ShowDefaultContent = 0,
    ShowUserContent = 1,
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class ControlDesigner : System.Web.UI.Design.HtmlControlDesigner {
    public ControlDesigner() { }
    public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { return default(System.ComponentModel.Design.DesignerActionListCollection); } }
    public virtual bool AllowResize { get { return default(bool); } }
    public virtual System.Web.UI.Design.DesignerAutoFormatCollection AutoFormats { get { return default(System.Web.UI.Design.DesignerAutoFormatCollection); } }
    protected virtual bool DataBindingsEnabled { get { return default(bool); } }
    protected System.Web.UI.Design.ControlDesignerState DesignerState { get { return default(System.Web.UI.Design.ControlDesignerState); } }
    [System.ObsoleteAttribute("Error: This property can no longer be referenced, and is included to support existing compiled applications. The design-time element view architecture is no longer used. http://go.microsoft.com/fwlink/?linkid=14202", true)]
    protected object DesignTimeElementView { get { return default(object); } }
    [System.ObsoleteAttribute("The recommended alternative is SetViewFlags(ViewFlags.DesignTimeHtmlRequiresLoadComplete, true). http://go.microsoft.com/fwlink/?linkid=14202")]
    public virtual bool DesignTimeHtmlRequiresLoadComplete { get { return default(bool); } }
    protected internal virtual bool HidePropertiesInTemplateMode { get { return default(bool); } }
    public virtual string ID { get { return default(string); } set { } }
    protected bool InTemplateMode { get { return default(bool); } }
    [System.ObsoleteAttribute("The recommended alternative is to use Tag.SetDirty() and Tag.IsDirty. http://go.microsoft.com/fwlink/?linkid=14202")]
    public bool IsDirty { get { return default(bool); } set { } }
    [System.ObsoleteAttribute("The recommended alternative is to inherit from ContainerControlDesigner instead and to use an EditableDesignerRegion. Regions allow for better control of the content in the designer. http://go.microsoft.com/fwlink/?linkid=14202")]
    public bool ReadOnly { get { return default(bool); } set { } }
    protected System.Web.UI.Design.WebFormsRootDesigner RootDesigner { get { return default(System.Web.UI.Design.WebFormsRootDesigner); } }
    protected System.Web.UI.Design.IControlDesignerTag Tag { get { return default(System.Web.UI.Design.IControlDesignerTag); } }
    public virtual System.Web.UI.Design.TemplateGroupCollection TemplateGroups { get { return default(System.Web.UI.Design.TemplateGroupCollection); } }
    protected virtual bool UsePreviewControl { get { return default(bool); } }
    public System.Web.UI.Control ViewControl { get { return default(System.Web.UI.Control); } set { } }
    public virtual bool ViewControlCreated { get { return default(bool); } set { } }
    protected virtual bool Visible { get { return default(bool); } }
    protected string CreateErrorDesignTimeHtml(string errorMessage) { return default(string); }
    protected string CreateErrorDesignTimeHtml(string errorMessage, System.Exception e) { return default(string); }
    protected string CreatePlaceHolderDesignTimeHtml() { return default(string); }
    protected string CreatePlaceHolderDesignTimeHtml(string instruction) { return default(string); }
    protected virtual System.Web.UI.Control CreateViewControl() { return default(System.Web.UI.Control); }
    public System.Drawing.Rectangle GetBounds() { return default(System.Drawing.Rectangle); }
    public virtual string GetDesignTimeHtml() { return default(string); }
    public virtual string GetDesignTimeHtml(System.Web.UI.Design.DesignerRegionCollection regions) { return default(string); }
    public static System.Web.UI.Design.DesignTimeResourceProviderFactory GetDesignTimeResourceProviderFactory(System.IServiceProvider serviceProvider) { return default(System.Web.UI.Design.DesignTimeResourceProviderFactory); }
    public virtual string GetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region) { return default(string); }
    protected virtual string GetEmptyDesignTimeHtml() { return default(string); }
    protected virtual string GetErrorDesignTimeHtml(System.Exception e) { return default(string); }
    public virtual string GetPersistenceContent() { return default(string); }
    [System.ObsoleteAttribute("The recommended alternative is GetPersistenceContent(). http://go.microsoft.com/fwlink/?linkid=14202")]
    public virtual string GetPersistInnerHtml() { return default(string); }
    public System.Web.UI.Design.ViewRendering GetViewRendering() { return default(System.Web.UI.Design.ViewRendering); }
    public static System.Web.UI.Design.ViewRendering GetViewRendering(System.Web.UI.Control control) { return default(System.Web.UI.Design.ViewRendering); }
    public static System.Web.UI.Design.ViewRendering GetViewRendering(System.Web.UI.Design.ControlDesigner designer) { return default(System.Web.UI.Design.ViewRendering); }
    public override void Initialize(System.ComponentModel.IComponent component) { }
    public void Invalidate() { }
    public void Invalidate(System.Drawing.Rectangle rectangle) { }
    public static void InvokeTransactedChange(System.ComponentModel.IComponent component, System.Web.UI.Design.TransactedChangeCallback callback, object context, string description) { }
    public static void InvokeTransactedChange(System.ComponentModel.IComponent component, System.Web.UI.Design.TransactedChangeCallback callback, object context, string description, System.ComponentModel.MemberDescriptor member) { }
    public static void InvokeTransactedChange(System.IServiceProvider serviceProvider, System.ComponentModel.IComponent component, System.Web.UI.Design.TransactedChangeCallback callback, object context, string description, System.ComponentModel.MemberDescriptor member) { }
    [System.ObsoleteAttribute("The recommended alternative is DataBindings.Contains(string). The DataBindings collection allows more control of the databindings associated with the control. http://go.microsoft.com/fwlink/?linkid=14202")]
    public bool IsPropertyBound(string propName) { return default(bool); }
    public void Localize(System.Web.UI.Design.IDesignTimeResourceWriter resourceWriter) { }
    public virtual void OnAutoFormatApplied(System.Web.UI.Design.DesignerAutoFormat appliedAutoFormat) { }
    [System.ObsoleteAttribute("The recommended alternative is to handle the Changed event on the DataBindings collection. The DataBindings collection allows more control of the databindings associated with the control. http://go.microsoft.com/fwlink/?linkid=14202")]
    protected override void OnBindingsCollectionChanged(string propName) { }
    protected virtual void OnClick(System.Web.UI.Design.DesignerRegionMouseEventArgs e) { }
    public virtual void OnComponentChanged(object sender, System.ComponentModel.Design.ComponentChangedEventArgs ce) { }
    public virtual void OnComponentChanging(object sender, System.ComponentModel.Design.ComponentChangingEventArgs ce) { }
    [System.ObsoleteAttribute("The recommended alternative is OnComponentChanged(). OnComponentChanged is called when any property of the control is changed. http://go.microsoft.com/fwlink/?linkid=14202")]
    protected virtual void OnControlResize() { }
    protected virtual void OnPaint(System.Windows.Forms.PaintEventArgs e) { }
    protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
    [System.ObsoleteAttribute("Use of this method is not recommended because resizing is handled by the OnComponentChanged() method. http://go.microsoft.com/fwlink/?linkid=14202")]
    public void RaiseResizeEvent() { }
    public void RegisterClone(object original, object clone) { }
    public virtual void SetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region, string content) { }
    protected void SetRegionContent(System.Web.UI.Design.EditableDesignerRegion region, string content) { }
    protected void SetViewFlags(System.Web.UI.Design.ViewFlags viewFlags, bool setFlag) { }
    public virtual void UpdateDesignTimeHtml() { }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public sealed partial class ControlDesignerState {
    internal ControlDesignerState() { }
    public object this[string key] { get { return default(object); } set { } }
  }
  public enum ControlLocation {
    After = 1,
    Before = 0,
    First = 2,
    FirstChild = 4,
    Last = 3,
    LastChild = 5,
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public sealed partial class ControlParser {
    internal ControlParser() { }
    public static System.Web.UI.Control ParseControl(System.ComponentModel.Design.IDesignerHost designerHost, string controlText) { return default(System.Web.UI.Control); }
    public static System.Web.UI.Control ParseControl(System.ComponentModel.Design.IDesignerHost designerHost, string controlText, string directives) { return default(System.Web.UI.Control); }
    public static System.Web.UI.Control[] ParseControls(System.ComponentModel.Design.IDesignerHost designerHost, string controlText) { return default(System.Web.UI.Control[]); }
    public static System.Web.UI.ITemplate ParseTemplate(System.ComponentModel.Design.IDesignerHost designerHost, string templateText) { return default(System.Web.UI.ITemplate); }
    public static System.Web.UI.ITemplate ParseTemplate(System.ComponentModel.Design.IDesignerHost designerHost, string templateText, string directives) { return default(System.Web.UI.ITemplate); }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public sealed partial class ControlPersister {
    internal ControlPersister() { }
    public static void PersistControl(System.IO.TextWriter sw, System.Web.UI.Control control) { }
    public static void PersistControl(System.IO.TextWriter sw, System.Web.UI.Control control, System.ComponentModel.Design.IDesignerHost host) { }
    public static string PersistControl(System.Web.UI.Control control) { return default(string); }
    public static string PersistControl(System.Web.UI.Control control, System.ComponentModel.Design.IDesignerHost host) { return default(string); }
    public static void PersistInnerProperties(System.IO.TextWriter sw, object component, System.ComponentModel.Design.IDesignerHost host) { }
    public static string PersistInnerProperties(object component, System.ComponentModel.Design.IDesignerHost host) { return default(string); }
    public static void PersistTemplate(System.IO.TextWriter writer, System.Web.UI.ITemplate template, System.ComponentModel.Design.IDesignerHost host) { }
    public static string PersistTemplate(System.Web.UI.ITemplate template, System.ComponentModel.Design.IDesignerHost host) { return default(string); }
  }
  [System.ObsoleteAttribute("Use of this type is not recommended because DataBindings editing is launched via a DesignerActionList instead of the property grid. http://go.microsoft.com/fwlink/?linkid=14202")]
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class DataBindingCollectionConverter : System.ComponentModel.TypeConverter {
    public DataBindingCollectionConverter() { }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
  }
  [System.ObsoleteAttribute("Use of this type is not recommended because DataBindings editing is launched via a DesignerActionList instead of the property grid. http://go.microsoft.com/fwlink/?linkid=14202")]
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class DataBindingCollectionEditor : System.Drawing.Design.UITypeEditor {
    public DataBindingCollectionEditor() { }
    public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { return default(object); }
    public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { return default(System.Drawing.Design.UITypeEditorEditStyle); }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public abstract partial class DataBindingHandler {
    protected DataBindingHandler() { }
    public abstract void DataBindControl(System.ComponentModel.Design.IDesignerHost designerHost, System.Web.UI.Control control);
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class DataBindingValueUIHandler {
    public DataBindingValueUIHandler() { }
    public void OnGetUIValueItem(System.ComponentModel.ITypeDescriptorContext context, System.ComponentModel.PropertyDescriptor propDesc, System.Collections.ArrayList valueUIItemList) { }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class DataColumnSelectionConverter : System.ComponentModel.TypeConverter {
    public DataColumnSelectionConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { return default(System.ComponentModel.TypeConverter.StandardValuesCollection); }
    public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class DataFieldConverter : System.ComponentModel.TypeConverter {
    public DataFieldConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { return default(System.ComponentModel.TypeConverter.StandardValuesCollection); }
    public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class DataMemberConverter : System.ComponentModel.TypeConverter {
    public DataMemberConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { return default(System.ComponentModel.TypeConverter.StandardValuesCollection); }
    public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
  }
  public sealed partial class DataSetFieldSchema : System.Web.UI.Design.IDataSourceFieldSchema {
    public DataSetFieldSchema(System.Data.DataColumn column) { }
    public System.Type DataType { get { return default(System.Type); } }
    public bool Identity { get { return default(bool); } }
    public bool IsReadOnly { get { return default(bool); } }
    public bool IsUnique { get { return default(bool); } }
    public int Length { get { return default(int); } }
    public string Name { get { return default(string); } }
    public bool Nullable { get { return default(bool); } }
    public int Precision { get { return default(int); } }
    public bool PrimaryKey { get { return default(bool); } }
    public int Scale { get { return default(int); } }
  }
  public sealed partial class DataSetSchema : System.Web.UI.Design.IDataSourceSchema {
    public DataSetSchema(System.Data.DataSet dataSet) { }
    public System.Web.UI.Design.IDataSourceViewSchema[] GetViews() { return default(System.Web.UI.Design.IDataSourceViewSchema[]); }
  }
  public sealed partial class DataSetViewSchema : System.Web.UI.Design.IDataSourceViewSchema {
    public DataSetViewSchema(System.Data.DataTable dataTable) { }
    public string Name { get { return default(string); } }
    public System.Web.UI.Design.IDataSourceViewSchema[] GetChildren() { return default(System.Web.UI.Design.IDataSourceViewSchema[]); }
    public System.Web.UI.Design.IDataSourceFieldSchema[] GetFields() { return default(System.Web.UI.Design.IDataSourceFieldSchema[]); }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class DataSourceBooleanViewSchemaConverter : System.Web.UI.Design.DataSourceViewSchemaConverter {
    public DataSourceBooleanViewSchemaConverter() { }
    public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { return default(System.ComponentModel.TypeConverter.StandardValuesCollection); }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class DataSourceConverter : System.ComponentModel.TypeConverter {
    public DataSourceConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { return default(System.ComponentModel.TypeConverter.StandardValuesCollection); }
    public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    protected virtual bool IsValidDataSource(System.ComponentModel.IComponent component) { return default(bool); }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class DataSourceDesigner : System.Web.UI.Design.ControlDesigner, System.Web.UI.Design.IDataSourceDesigner {
    public DataSourceDesigner() { }
    public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { return default(System.ComponentModel.Design.DesignerActionListCollection); } }
    public virtual bool CanConfigure { get { return default(bool); } }
    public virtual bool CanRefreshSchema { get { return default(bool); } }
    protected bool SuppressingDataSourceEvents { get { return default(bool); } }
    public event System.EventHandler DataSourceChanged { add { } remove { } }
    public event System.EventHandler SchemaRefreshed { add { } remove { } }
    public virtual void Configure() { }
    public override string GetDesignTimeHtml() { return default(string); }
    public virtual System.Web.UI.Design.DesignerDataSourceView GetView(string viewName) { return default(System.Web.UI.Design.DesignerDataSourceView); }
    public virtual System.String[] GetViewNames() { return default(System.String[]); }
    protected virtual void OnDataSourceChanged(System.EventArgs e) { }
    protected virtual void OnSchemaRefreshed(System.EventArgs e) { }
    public virtual void RefreshSchema(bool preferSilent) { }
    public virtual void ResumeDataSourceEvents() { }
    public static bool SchemasEquivalent(System.Web.UI.Design.IDataSourceSchema schema1, System.Web.UI.Design.IDataSourceSchema schema2) { return default(bool); }
    public virtual void SuppressDataSourceEvents() { }
    public static bool ViewSchemasEquivalent(System.Web.UI.Design.IDataSourceViewSchema viewSchema1, System.Web.UI.Design.IDataSourceViewSchema viewSchema2) { return default(bool); }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class DataSourceViewSchemaConverter : System.ComponentModel.TypeConverter {
    public DataSourceViewSchemaConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { return default(System.ComponentModel.TypeConverter.StandardValuesCollection); }
    public virtual System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context, System.Type typeFilter) { return default(System.ComponentModel.TypeConverter.StandardValuesCollection); }
    public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
  }
  public abstract partial class DesignerAutoFormat {
    protected DesignerAutoFormat(string name) { }
    public string Name { get { return default(string); } }
    public System.Web.UI.Design.DesignerAutoFormatStyle Style { get { return default(System.Web.UI.Design.DesignerAutoFormatStyle); } }
    public abstract void Apply(System.Web.UI.Control control);
    public virtual System.Web.UI.Control GetPreviewControl(System.Web.UI.Control runtimeControl) { return default(System.Web.UI.Control); }
    public override string ToString() { return default(string); }
  }
  public sealed partial class DesignerAutoFormatCollection : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList {
    public DesignerAutoFormatCollection() { }
    public int Count { get { return default(int); } }
    public System.Web.UI.Design.DesignerAutoFormat this[int index] { get { return default(System.Web.UI.Design.DesignerAutoFormat); } }
    public System.Drawing.Size PreviewSize { get { return default(System.Drawing.Size); } }
    public object SyncRoot { get { return default(object); } }
    int System.Collections.ICollection.Count { get { return default(int); } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    bool System.Collections.IList.IsFixedSize { get { return default(bool); } }
    bool System.Collections.IList.IsReadOnly { get { return default(bool); } }
    object System.Collections.IList.this[int index] { get { return default(object); } set { } }
    public int Add(System.Web.UI.Design.DesignerAutoFormat format) { return default(int); }
    public void Clear() { }
    public bool Contains(System.Web.UI.Design.DesignerAutoFormat format) { return default(bool); }
    public int IndexOf(System.Web.UI.Design.DesignerAutoFormat format) { return default(int); }
    public void Insert(int index, System.Web.UI.Design.DesignerAutoFormat format) { }
    public void Remove(System.Web.UI.Design.DesignerAutoFormat format) { }
    public void RemoveAt(int index) { }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    int System.Collections.IList.Add(object value) { return default(int); }
    bool System.Collections.IList.Contains(object value) { return default(bool); }
    int System.Collections.IList.IndexOf(object value) { return default(int); }
    void System.Collections.IList.Insert(int index, object value) { }
    void System.Collections.IList.Remove(object value) { }
    void System.Collections.IList.RemoveAt(int index) { }
  }
  public partial class DesignerAutoFormatStyle : System.Web.UI.WebControls.Style {
    public DesignerAutoFormatStyle() { }
    public System.Web.UI.WebControls.VerticalAlign VerticalAlign { get { return default(System.Web.UI.WebControls.VerticalAlign); } set { } }
  }
  public abstract partial class DesignerDataSourceView {
    protected DesignerDataSourceView(System.Web.UI.Design.IDataSourceDesigner owner, string viewName) { }
    public virtual bool CanDelete { get { return default(bool); } }
    public virtual bool CanInsert { get { return default(bool); } }
    public virtual bool CanPage { get { return default(bool); } }
    public virtual bool CanRetrieveTotalRowCount { get { return default(bool); } }
    public virtual bool CanSort { get { return default(bool); } }
    public virtual bool CanUpdate { get { return default(bool); } }
    public System.Web.UI.Design.IDataSourceDesigner DataSourceDesigner { get { return default(System.Web.UI.Design.IDataSourceDesigner); } }
    public string Name { get { return default(string); } }
    public virtual System.Web.UI.Design.IDataSourceViewSchema Schema { get { return default(System.Web.UI.Design.IDataSourceViewSchema); } }
    public virtual System.Collections.IEnumerable GetDesignTimeData(int minimumRows, out bool isSampleData) { isSampleData = default(bool); return default(System.Collections.IEnumerable); }
  }
  public abstract partial class DesignerHierarchicalDataSourceView {
    protected DesignerHierarchicalDataSourceView(System.Web.UI.Design.IHierarchicalDataSourceDesigner owner, string viewPath) { }
    public System.Web.UI.Design.IHierarchicalDataSourceDesigner DataSourceDesigner { get { return default(System.Web.UI.Design.IHierarchicalDataSourceDesigner); } }
    public string Path { get { return default(string); } }
    public virtual System.Web.UI.Design.IDataSourceSchema Schema { get { return default(System.Web.UI.Design.IDataSourceSchema); } }
    public virtual System.Web.UI.IHierarchicalEnumerable GetDesignTimeData(out bool isSampleData) { isSampleData = default(bool); return default(System.Web.UI.IHierarchicalEnumerable); }
  }
  public abstract partial class DesignerObject : System.IServiceProvider {
    protected DesignerObject(System.Web.UI.Design.ControlDesigner designer, string name) { }
    public System.Web.UI.Design.ControlDesigner Designer { get { return default(System.Web.UI.Design.ControlDesigner); } }
    public string Name { get { return default(string); } }
    public System.Collections.IDictionary Properties { get { return default(System.Collections.IDictionary); } }
    protected object GetService(System.Type serviceType) { return default(object); }
    object System.IServiceProvider.GetService(System.Type serviceType) { return default(object); }
  }
  public partial class DesignerRegion : System.Web.UI.Design.DesignerObject {
    public static readonly string DesignerRegionAttributeName;
    public DesignerRegion(System.Web.UI.Design.ControlDesigner designer, string name) : base (default(System.Web.UI.Design.ControlDesigner), default(string)) { }
    public DesignerRegion(System.Web.UI.Design.ControlDesigner designer, string name, bool selectable) : base (default(System.Web.UI.Design.ControlDesigner), default(string)) { }
    public virtual string Description { get { return default(string); } set { } }
    public virtual string DisplayName { get { return default(string); } set { } }
    public bool EnsureSize { get { return default(bool); } set { } }
    public virtual bool Highlight { get { return default(bool); } set { } }
    public virtual bool Selectable { get { return default(bool); } set { } }
    public virtual bool Selected { get { return default(bool); } set { } }
    public object UserData { get { return default(object); } set { } }
    public System.Drawing.Rectangle GetBounds() { return default(System.Drawing.Rectangle); }
  }
  public partial class DesignerRegionCollection : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList {
    public DesignerRegionCollection() { }
    public DesignerRegionCollection(System.Web.UI.Design.ControlDesigner owner) { }
    public int Count { get { return default(int); } }
    public bool IsFixedSize { get { return default(bool); } }
    public bool IsReadOnly { get { return default(bool); } }
    public bool IsSynchronized { get { return default(bool); } }
    public System.Web.UI.Design.DesignerRegion this[int index] { get { return default(System.Web.UI.Design.DesignerRegion); } set { } }
    public System.Web.UI.Design.ControlDesigner Owner { get { return default(System.Web.UI.Design.ControlDesigner); } }
    public object SyncRoot { get { return default(object); } }
    int System.Collections.ICollection.Count { get { return default(int); } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    bool System.Collections.IList.IsFixedSize { get { return default(bool); } }
    bool System.Collections.IList.IsReadOnly { get { return default(bool); } }
    object System.Collections.IList.this[int index] { get { return default(object); } set { } }
    public int Add(System.Web.UI.Design.DesignerRegion region) { return default(int); }
    public void Clear() { }
    public bool Contains(System.Web.UI.Design.DesignerRegion region) { return default(bool); }
    public void CopyTo(System.Array array, int index) { }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public int IndexOf(System.Web.UI.Design.DesignerRegion region) { return default(int); }
    public void Insert(int index, System.Web.UI.Design.DesignerRegion region) { }
    public void Remove(System.Web.UI.Design.DesignerRegion region) { }
    public void RemoveAt(int index) { }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    int System.Collections.IList.Add(object o) { return default(int); }
    void System.Collections.IList.Clear() { }
    bool System.Collections.IList.Contains(object o) { return default(bool); }
    int System.Collections.IList.IndexOf(object o) { return default(int); }
    void System.Collections.IList.Insert(int index, object o) { }
    void System.Collections.IList.Remove(object o) { }
    void System.Collections.IList.RemoveAt(int index) { }
  }
  public sealed partial class DesignerRegionMouseEventArgs : System.EventArgs {
    public DesignerRegionMouseEventArgs(System.Web.UI.Design.DesignerRegion region, System.Drawing.Point location) { }
    public System.Drawing.Point Location { get { return default(System.Drawing.Point); } }
    public System.Web.UI.Design.DesignerRegion Region { get { return default(System.Web.UI.Design.DesignerRegion); } }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public sealed partial class DesignTimeData {
    internal DesignTimeData() { }
    public static readonly System.EventHandler DataBindingHandler;
    public static System.Data.DataTable CreateDummyDataBoundDataTable() { return default(System.Data.DataTable); }
    public static System.Data.DataTable CreateDummyDataTable() { return default(System.Data.DataTable); }
    public static System.Data.DataTable CreateSampleDataTable(System.Collections.IEnumerable referenceData) { return default(System.Data.DataTable); }
    public static System.Data.DataTable CreateSampleDataTable(System.Collections.IEnumerable referenceData, bool useDataBoundData) { return default(System.Data.DataTable); }
    public static System.ComponentModel.PropertyDescriptorCollection GetDataFields(System.Collections.IEnumerable dataSource) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public static System.Collections.IEnumerable GetDataMember(System.ComponentModel.IListSource dataSource, string dataMember) { return default(System.Collections.IEnumerable); }
    public static System.String[] GetDataMembers(object dataSource) { return default(System.String[]); }
    public static System.Collections.IEnumerable GetDesignTimeDataSource(System.Data.DataTable dataTable, int minimumRows) { return default(System.Collections.IEnumerable); }
    public static object GetSelectedDataSource(System.ComponentModel.IComponent component, string dataSource) { return default(object); }
    public static System.Collections.IEnumerable GetSelectedDataSource(System.ComponentModel.IComponent component, string dataSource, string dataMember) { return default(System.Collections.IEnumerable); }
  }
  public abstract partial class DesignTimeResourceProviderFactory {
    protected DesignTimeResourceProviderFactory() { }
    public abstract System.Web.Compilation.IResourceProvider CreateDesignTimeGlobalResourceProvider(System.IServiceProvider serviceProvider, string classKey);
    public abstract System.Web.Compilation.IResourceProvider CreateDesignTimeLocalResourceProvider(System.IServiceProvider serviceProvider);
    public abstract System.Web.UI.Design.IDesignTimeResourceWriter CreateDesignTimeLocalResourceWriter(System.IServiceProvider serviceProvider);
  }
  public partial class EditableDesignerRegion : System.Web.UI.Design.DesignerRegion {
    public EditableDesignerRegion(System.Web.UI.Design.ControlDesigner owner, string name) : base (default(System.Web.UI.Design.ControlDesigner), default(string)) { }
    public EditableDesignerRegion(System.Web.UI.Design.ControlDesigner owner, string name, bool serverControlsOnly) : base (default(System.Web.UI.Design.ControlDesigner), default(string)) { }
    public virtual string Content { get { return default(string); } set { } }
    public bool ServerControlsOnly { get { return default(bool); } set { } }
    public virtual bool SupportsDataBinding { get { return default(bool); } set { } }
    public virtual System.Web.UI.Design.ViewRendering GetChildViewRendering(System.Web.UI.Control control) { return default(System.Web.UI.Design.ViewRendering); }
  }
  public abstract partial class ExpressionEditor {
    protected ExpressionEditor() { }
    public string ExpressionPrefix { get { return default(string); } }
    public abstract object EvaluateExpression(string expression, object parseTimeData, System.Type propertyType, System.IServiceProvider serviceProvider);
    public static System.Web.UI.Design.ExpressionEditor GetExpressionEditor(string expressionPrefix, System.IServiceProvider serviceProvider) { return default(System.Web.UI.Design.ExpressionEditor); }
    public static System.Web.UI.Design.ExpressionEditor GetExpressionEditor(System.Type expressionBuilderType, System.IServiceProvider serviceProvider) { return default(System.Web.UI.Design.ExpressionEditor); }
    public virtual System.Web.UI.Design.ExpressionEditorSheet GetExpressionEditorSheet(string expression, System.IServiceProvider serviceProvider) { return default(System.Web.UI.Design.ExpressionEditorSheet); }
  }
  public abstract partial class ExpressionEditorSheet {
    protected ExpressionEditorSheet(System.IServiceProvider serviceProvider) { }
    [System.ComponentModel.BrowsableAttribute(false)]
    public virtual bool IsValid { get { return default(bool); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public System.IServiceProvider ServiceProvider { get { return default(System.IServiceProvider); } }
    public abstract string GetExpression();
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class ExpressionsCollectionConverter : System.ComponentModel.TypeConverter {
    public ExpressionsCollectionConverter() { }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class ExpressionsCollectionEditor : System.Drawing.Design.UITypeEditor {
    public ExpressionsCollectionEditor() { }
    public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { return default(object); }
    public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { return default(System.Drawing.Design.UITypeEditorEditStyle); }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class HierarchicalDataSourceConverter : System.Web.UI.Design.DataSourceConverter {
    public HierarchicalDataSourceConverter() { }
    protected override bool IsValidDataSource(System.ComponentModel.IComponent component) { return default(bool); }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class HierarchicalDataSourceDesigner : System.Web.UI.Design.ControlDesigner, System.Web.UI.Design.IHierarchicalDataSourceDesigner {
    public HierarchicalDataSourceDesigner() { }
    public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { return default(System.ComponentModel.Design.DesignerActionListCollection); } }
    public virtual bool CanConfigure { get { return default(bool); } }
    public virtual bool CanRefreshSchema { get { return default(bool); } }
    protected bool SuppressingDataSourceEvents { get { return default(bool); } }
    public event System.EventHandler DataSourceChanged { add { } remove { } }
    public event System.EventHandler SchemaRefreshed { add { } remove { } }
    public virtual void Configure() { }
    public override string GetDesignTimeHtml() { return default(string); }
    public virtual System.Web.UI.Design.DesignerHierarchicalDataSourceView GetView(string viewPath) { return default(System.Web.UI.Design.DesignerHierarchicalDataSourceView); }
    protected virtual void OnDataSourceChanged(System.EventArgs e) { }
    protected virtual void OnSchemaRefreshed(System.EventArgs e) { }
    public virtual void RefreshSchema(bool preferSilent) { }
    public virtual void ResumeDataSourceEvents() { }
    public virtual void SuppressDataSourceEvents() { }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class HtmlControlDesigner : System.ComponentModel.Design.ComponentDesigner {
    public HtmlControlDesigner() { }
    [System.ObsoleteAttribute("The recommended alternative is ControlDesigner.Tag. http://go.microsoft.com/fwlink/?linkid=14202")]
    public System.Web.UI.Design.IHtmlControlDesignerBehavior Behavior { get { return default(System.Web.UI.Design.IHtmlControlDesignerBehavior); } set { } }
    public System.Web.UI.DataBindingCollection DataBindings { get { return default(System.Web.UI.DataBindingCollection); } }
    [System.ObsoleteAttribute("Error: This property can no longer be referenced, and is included to support existing compiled applications. The design-time element may not always provide access to the element in the markup. There are alternate methods on WebFormsRootDesigner for handling client script and controls. http://go.microsoft.com/fwlink/?linkid=14202", true)]
    protected object DesignTimeElement { get { return default(object); } }
    public System.Web.UI.ExpressionBindingCollection Expressions { get { return default(System.Web.UI.ExpressionBindingCollection); } }
    [System.ObsoleteAttribute("Use of this property is not recommended because code serialization is not supported. http://go.microsoft.com/fwlink/?linkid=14202")]
    public virtual bool ShouldCodeSerialize { get { return default(bool); } set { } }
    protected override void Dispose(bool disposing) { }
    public override void Initialize(System.ComponentModel.IComponent component) { }
    [System.ObsoleteAttribute("The recommended alternative is ControlDesigner.Tag. http://go.microsoft.com/fwlink/?linkid=14202")]
    protected virtual void OnBehaviorAttached() { }
    [System.ObsoleteAttribute("The recommended alternative is ControlDesigner.Tag. http://go.microsoft.com/fwlink/?linkid=14202")]
    protected virtual void OnBehaviorDetaching() { }
    [System.ObsoleteAttribute("The recommended alternative is to handle the Changed event on the DataBindings collection. The DataBindings collection allows more control of the databindings associated with the control. http://go.microsoft.com/fwlink/?linkid=14202")]
    protected virtual void OnBindingsCollectionChanged(string propName) { }
    public virtual void OnSetParent() { }
    protected override void PreFilterEvents(System.Collections.IDictionary events) { }
    protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class HtmlIntrinsicControlDesigner : System.Web.UI.Design.HtmlControlDesigner {
    public HtmlIntrinsicControlDesigner() { }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class HyperLinkDataBindingHandler : System.Web.UI.Design.DataBindingHandler {
    public HyperLinkDataBindingHandler() { }
    public override void DataBindControl(System.ComponentModel.Design.IDesignerHost designerHost, System.Web.UI.Control control) { }
  }
  public partial interface IContentResolutionService {
    System.Collections.IDictionary ContentDefinitions { get; }
    System.Web.UI.Design.ContentDesignerState GetContentDesignerState(string identifier);
    void SetContentDesignerState(string identifier, System.Web.UI.Design.ContentDesignerState state);
  }
  [System.ObsoleteAttribute("The recommended alternative is System.Web.UI.Design.IControlDesignerTag and System.Web.UI.Design.IControlDesignerView. http://go.microsoft.com/fwlink/?linkid=14202")]
  public partial interface IControlDesignerBehavior {
    object DesignTimeElementView { get; }
    string DesignTimeHtml { get; set; }
    void OnTemplateModeChanged();
  }
  public partial interface IControlDesignerTag {
    bool IsDirty { get; }
    string GetAttribute(string name);
    string GetContent();
    string GetOuterContent();
    void RemoveAttribute(string name);
    void SetAttribute(string name, string value);
    void SetContent(string content);
    void SetDirty(bool dirty);
  }
  public partial interface IControlDesignerView {
    System.Web.UI.Design.DesignerRegion ContainingRegion { get; }
    System.ComponentModel.Design.IDesigner NamingContainerDesigner { get; }
    bool SupportsRegions { get; }
    event System.Web.UI.Design.ViewEventHandler ViewEvent;
    System.Drawing.Rectangle GetBounds(System.Web.UI.Design.DesignerRegion region);
    void Invalidate(System.Drawing.Rectangle rectangle);
    void SetFlags(System.Web.UI.Design.ViewFlags viewFlags, bool setFlag);
    void SetRegionContent(System.Web.UI.Design.EditableDesignerRegion region, string content);
    void Update();
  }
  public partial interface IDataBindingSchemaProvider {
    bool CanRefreshSchema { get; }
    System.Web.UI.Design.IDataSourceViewSchema Schema { get; }
    void RefreshSchema(bool preferSilent);
  }
  public partial interface IDataSourceDesigner {
    bool CanConfigure { get; }
    bool CanRefreshSchema { get; }
    event System.EventHandler DataSourceChanged;
    event System.EventHandler SchemaRefreshed;
    void Configure();
    System.Web.UI.Design.DesignerDataSourceView GetView(string viewName);
    System.String[] GetViewNames();
    void RefreshSchema(bool preferSilent);
    void ResumeDataSourceEvents();
    void SuppressDataSourceEvents();
  }
  public partial interface IDataSourceFieldSchema {
    System.Type DataType { get; }
    bool Identity { get; }
    bool IsReadOnly { get; }
    bool IsUnique { get; }
    int Length { get; }
    string Name { get; }
    bool Nullable { get; }
    int Precision { get; }
    bool PrimaryKey { get; }
    int Scale { get; }
  }
  public partial interface IDataSourceProvider {
    System.Collections.IEnumerable GetResolvedSelectedDataSource();
    object GetSelectedDataSource();
  }
  public partial interface IDataSourceSchema {
    System.Web.UI.Design.IDataSourceViewSchema[] GetViews();
  }
  public partial interface IDataSourceViewSchema {
    string Name { get; }
    System.Web.UI.Design.IDataSourceViewSchema[] GetChildren();
    System.Web.UI.Design.IDataSourceFieldSchema[] GetFields();
  }
  public partial interface IDesignTimeResourceProviderFactoryService {
    System.Web.UI.Design.DesignTimeResourceProviderFactory GetFactory();
  }
  public partial interface IDesignTimeResourceWriter : System.IDisposable, System.Resources.IResourceWriter {
    string CreateResourceKey(string resourceName, object obj);
  }
  public partial interface IDocumentProjectItem {
    System.IO.Stream GetContents();
    void Open();
  }
  public partial interface IFolderProjectItem {
    System.Collections.ICollection Children { get; }
    System.Web.UI.Design.IDocumentProjectItem AddDocument(string name, System.Byte[] content);
    System.Web.UI.Design.IFolderProjectItem AddFolder(string name);
  }
  public partial interface IHierarchicalDataSourceDesigner {
    bool CanConfigure { get; }
    bool CanRefreshSchema { get; }
    event System.EventHandler DataSourceChanged;
    event System.EventHandler SchemaRefreshed;
    void Configure();
    System.Web.UI.Design.DesignerHierarchicalDataSourceView GetView(string viewPath);
    void RefreshSchema(bool preferSilent);
    void ResumeDataSourceEvents();
    void SuppressDataSourceEvents();
  }
  [System.ObsoleteAttribute("The recommended alternative is System.Web.UI.Design.IControlDesignerTag and System.Web.UI.Design.IControlDesignerView. http://go.microsoft.com/fwlink/?linkid=14202")]
  public partial interface IHtmlControlDesignerBehavior {
    System.Web.UI.Design.HtmlControlDesigner Designer { get; set; }
    object DesignTimeElement { get; }
    object GetAttribute(string attribute, bool ignoreCase);
    object GetStyleAttribute(string attribute, bool designTimeOnly, bool ignoreCase);
    void RemoveAttribute(string attribute, bool ignoreCase);
    void RemoveStyleAttribute(string attribute, bool designTimeOnly, bool ignoreCase);
    void SetAttribute(string attribute, object value, bool ignoreCase);
    void SetStyleAttribute(string attribute, bool designTimeOnly, object value, bool ignoreCase);
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class ImageUrlEditor : System.Web.UI.Design.UrlEditor {
    public ImageUrlEditor() { }
    protected override string Caption { get { return default(string); } }
    protected override string Filter { get { return default(string); } }
  }
  public partial interface IProjectItem {
    string AppRelativeUrl { get; }
    string Name { get; }
    System.Web.UI.Design.IProjectItem Parent { get; }
    string PhysicalPath { get; }
  }
  [System.ObsoleteAttribute("Use of this type is not recommended because template editing is handled in ControlDesigner. To support template editing expose template data in the TemplateGroups property and call SetViewFlags(ViewFlags.TemplateEditing, true). http://go.microsoft.com/fwlink/?linkid=14202")]
  public partial interface ITemplateEditingFrame : System.IDisposable {
    System.Web.UI.WebControls.Style ControlStyle { get; }
    int InitialHeight { get; set; }
    int InitialWidth { get; set; }
    string Name { get; }
    System.String[] TemplateNames { get; }
    System.Web.UI.WebControls.Style[] TemplateStyles { get; }
    System.Web.UI.Design.TemplateEditingVerb Verb { get; set; }
    void Close(bool saveChanges);
    void Open();
    void Resize(int width, int height);
    void Save();
    void UpdateControlName(string newName);
  }
  [System.ObsoleteAttribute("Use of this type is not recommended because template editing is handled in ControlDesigner. To support template editing expose template data in the TemplateGroups property and call SetViewFlags(ViewFlags.TemplateEditing, true). http://go.microsoft.com/fwlink/?linkid=14202")]
  public partial interface ITemplateEditingService {
    bool SupportsNestedTemplateEditing { get; }
    System.Web.UI.Design.ITemplateEditingFrame CreateFrame(System.Web.UI.Design.TemplatedControlDesigner designer, string frameName, System.String[] templateNames);
    System.Web.UI.Design.ITemplateEditingFrame CreateFrame(System.Web.UI.Design.TemplatedControlDesigner designer, string frameName, System.String[] templateNames, System.Web.UI.WebControls.Style controlStyle, System.Web.UI.WebControls.Style[] templateStyles);
    string GetContainingTemplateName(System.Web.UI.Control control);
  }
  public partial interface IWebAdministrationService {
    void Start(System.Collections.IDictionary arguments);
  }
  [System.Runtime.InteropServices.GuidAttribute("cff39fa8-5607-4b6d-86f3-cc80b3cfe2dd")]
  public partial interface IWebApplication : System.IServiceProvider {
    System.Web.UI.Design.IProjectItem RootProjectItem { get; }
    System.Web.UI.Design.IProjectItem GetProjectItemFromUrl(string appRelativeUrl);
    System.Configuration.Configuration OpenWebConfiguration(bool isReadOnly);
  }
  [System.ObsoleteAttribute("The recommended alternative is System.Web.UI.Design.WebFormsReferenceManager. The WebFormsReferenceManager contains additional functionality and allows for more extensibility. To get the WebFormsReferenceManager use the RootDesigner.ReferenceManager property from your ControlDesigner. http://go.microsoft.com/fwlink/?linkid=14202")]
  public partial interface IWebFormReferenceManager {
    System.Type GetObjectType(string tagPrefix, string typeName);
    string GetRegisterDirectives();
    string GetTagPrefix(System.Type objectType);
  }
  public partial interface IWebFormsBuilderUIService {
    string BuildColor(System.Windows.Forms.Control owner, string initialColor);
    string BuildUrl(System.Windows.Forms.Control owner, string initialUrl, string baseUrl, string caption, string filter, System.Web.UI.Design.UrlBuilderOptions options);
  }
  [System.ObsoleteAttribute("The recommended alternative is System.Web.UI.Design.WebFormsRootDesigner. The WebFormsRootDesigner contains additional functionality and allows for more extensibility. To get the WebFormsRootDesigner use the RootDesigner property from your ControlDesigner. http://go.microsoft.com/fwlink/?linkid=14202")]
  public partial interface IWebFormsDocumentService {
    string DocumentUrl { get; }
    bool IsLoading { get; }
    event System.EventHandler LoadComplete;
    object CreateDiscardableUndoUnit();
    void DiscardUndoUnit(object discardableUndoUnit);
    void EnableUndo(bool enable);
    void UpdateSelection();
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class MailFileEditor : System.Web.UI.Design.UrlEditor {
    public MailFileEditor() { }
    protected override string Caption { get { return default(string); } }
    protected override string Filter { get { return default(string); } }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class MdbDataFileEditor : System.Web.UI.Design.UrlEditor {
    public MdbDataFileEditor() { }
    protected override string Caption { get { return default(string); } }
    protected override string Filter { get { return default(string); } }
  }
  [System.ObsoleteAttribute("The recommended alternative is ContainerControlDesigner because it uses an EditableDesignerRegion for editing the content. Designer regions allow for better control of the content being edited. http://go.microsoft.com/fwlink/?linkid=14202")]
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class ReadWriteControlDesigner : System.Web.UI.Design.ControlDesigner {
    public ReadWriteControlDesigner() { }
    public override string GetDesignTimeHtml() { return default(string); }
    protected virtual void MapPropertyToStyle(string propName, object varPropValue) { }
    [System.ObsoleteAttribute("The recommended alternative is ControlDesigner.Tag. http://go.microsoft.com/fwlink/?linkid=14202")]
    protected override void OnBehaviorAttached() { }
    public override void OnComponentChanged(object sender, System.ComponentModel.Design.ComponentChangedEventArgs ce) { }
    public override void UpdateDesignTimeHtml() { }
  }
  public partial class ResourceExpressionEditor : System.Web.UI.Design.ExpressionEditor {
    public ResourceExpressionEditor() { }
    public override object EvaluateExpression(string expression, object parseTimeData, System.Type propertyType, System.IServiceProvider serviceProvider) { return default(object); }
    public override System.Web.UI.Design.ExpressionEditorSheet GetExpressionEditorSheet(string expression, System.IServiceProvider serviceProvider) { return default(System.Web.UI.Design.ExpressionEditorSheet); }
  }
  public partial class ResourceExpressionEditorSheet : System.Web.UI.Design.ExpressionEditorSheet {
    public ResourceExpressionEditorSheet(string expression, System.IServiceProvider serviceProvider) : base (default(System.IServiceProvider)) { }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Design.SRDescriptionAttribute("ResourceExpressionEditorSheet_ClassKey")]
    public string ClassKey { get { return default(string); } set { } }
    public override bool IsValid { get { return default(bool); } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.Design.ResourceExpressionEditorSheet.ResourceKeyTypeConverter))]
    [System.Design.SRDescriptionAttribute("ResourceExpressionEditorSheet_ResourceKey")]
    public string ResourceKey { get { return default(string); } set { } }
    public override string GetExpression() { return default(string); }
  }
  public partial class RouteUrlExpressionEditor : System.Web.UI.Design.ExpressionEditor {
    public RouteUrlExpressionEditor() { }
    public override object EvaluateExpression(string expression, object parseTimeData, System.Type propertyType, System.IServiceProvider serviceProvider) { return default(object); }
    public override System.Web.UI.Design.ExpressionEditorSheet GetExpressionEditorSheet(string expression, System.IServiceProvider serviceProvider) { return default(System.Web.UI.Design.ExpressionEditorSheet); }
  }
  public partial class RouteUrlExpressionEditorSheet : System.Web.UI.Design.ExpressionEditorSheet {
    public RouteUrlExpressionEditorSheet(string expression, System.IServiceProvider serviceProvider) : base (default(System.IServiceProvider)) { }
    public override bool IsValid { get { return default(bool); } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Design.SRDescriptionAttribute("RouteUrlExpressionEditorSheet_RouteName")]
    public string RouteName { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Design.SRDescriptionAttribute("RouteUrlExpressionEditorSheet_RouteValues")]
    public string RouteValues { get { return default(string); } set { } }
    public override string GetExpression() { return default(string); }
  }
  public partial class RouteValueExpressionEditor : System.Web.UI.Design.ExpressionEditor {
    public RouteValueExpressionEditor() { }
    public override object EvaluateExpression(string expression, object parseTimeData, System.Type propertyType, System.IServiceProvider serviceProvider) { return default(object); }
    public override System.Web.UI.Design.ExpressionEditorSheet GetExpressionEditorSheet(string expression, System.IServiceProvider serviceProvider) { return default(System.Web.UI.Design.ExpressionEditorSheet); }
  }
  public partial class RouteValueExpressionEditorSheet : System.Web.UI.Design.ExpressionEditorSheet {
    public RouteValueExpressionEditorSheet(string expression, System.IServiceProvider serviceProvider) : base (default(System.IServiceProvider)) { }
    public override bool IsValid { get { return default(bool); } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Design.SRDescriptionAttribute("RouteValueExpressionEditorSheet_RouteValue")]
    public string RouteValue { get { return default(string); } set { } }
    public override string GetExpression() { return default(string); }
  }
  public partial class SkinIDTypeConverter : System.ComponentModel.TypeConverter {
    public SkinIDTypeConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
    public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { return default(System.ComponentModel.TypeConverter.StandardValuesCollection); }
    public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
  public sealed partial class SupportsPreviewControlAttribute : System.Attribute {
    public static readonly System.Web.UI.Design.SupportsPreviewControlAttribute Default;
    public SupportsPreviewControlAttribute(bool supportsPreviewControl) { }
    public bool SupportsPreviewControl { get { return default(bool); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool IsDefaultAttribute() { return default(bool); }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public abstract partial class TemplatedControlDesigner : System.Web.UI.Design.ControlDesigner {
    public TemplatedControlDesigner() { }
    [System.ObsoleteAttribute("Use of this property is not recommended because template editing is handled in ControlDesigner. To support template editing expose template data in the TemplateGroups property and call SetViewFlags(ViewFlags.TemplateEditing, true). http://go.microsoft.com/fwlink/?linkid=14202")]
    public System.Web.UI.Design.ITemplateEditingFrame ActiveTemplateEditingFrame { get { return default(System.Web.UI.Design.ITemplateEditingFrame); } }
    public bool CanEnterTemplateMode { get { return default(bool); } }
    protected override bool DataBindingsEnabled { get { return default(bool); } }
    [System.ObsoleteAttribute("The recommended alternative is System.Web.UI.Design.ControlDesigner.InTemplateMode. http://go.microsoft.com/fwlink/?linkid=14202")]
    public new bool InTemplateMode { get { return default(bool); } }
    public override System.Web.UI.Design.TemplateGroupCollection TemplateGroups { get { return default(System.Web.UI.Design.TemplateGroupCollection); } }
    [System.ObsoleteAttribute("Use of this method is not recommended because template editing is handled in ControlDesigner. To support template editing expose template data in the TemplateGroups property and call SetViewFlags(ViewFlags.TemplateEditing, true). http://go.microsoft.com/fwlink/?linkid=14202")]
    protected abstract System.Web.UI.Design.ITemplateEditingFrame CreateTemplateEditingFrame(System.Web.UI.Design.TemplateEditingVerb verb);
    [System.ObsoleteAttribute("Use of this method is not recommended because template editing is handled in ControlDesigner. To support template editing expose template data in the TemplateGroups property and call SetViewFlags(ViewFlags.TemplateEditing, true). http://go.microsoft.com/fwlink/?linkid=14202")]
    public void EnterTemplateMode(System.Web.UI.Design.ITemplateEditingFrame newTemplateEditingFrame) { }
    [System.ObsoleteAttribute("Use of this method is not recommended because template editing is handled in ControlDesigner. To support template editing expose template data in the TemplateGroups property and call SetViewFlags(ViewFlags.TemplateEditing, true). http://go.microsoft.com/fwlink/?linkid=14202")]
    public void ExitTemplateMode(bool fSwitchingTemplates, bool fNested, bool fSave) { }
    [System.ObsoleteAttribute("Use of this method is not recommended because template editing is handled in ControlDesigner. To support template editing expose template data in the TemplateGroups property and call SetViewFlags(ViewFlags.TemplateEditing, true). http://go.microsoft.com/fwlink/?linkid=14202")]
    protected abstract System.Web.UI.Design.TemplateEditingVerb[] GetCachedTemplateEditingVerbs();
    [System.ObsoleteAttribute("Use of this method is not recommended because template editing is handled in ControlDesigner. To support template editing expose template data in the TemplateGroups property and call SetViewFlags(ViewFlags.TemplateEditing, true). http://go.microsoft.com/fwlink/?linkid=14202")]
    public virtual string GetTemplateContainerDataItemProperty(string templateName) { return default(string); }
    [System.ObsoleteAttribute("Use of this method is not recommended because template editing is handled in ControlDesigner. To support template editing expose template data in the TemplateGroups property and call SetViewFlags(ViewFlags.TemplateEditing, true). http://go.microsoft.com/fwlink/?linkid=14202")]
    public virtual System.Collections.IEnumerable GetTemplateContainerDataSource(string templateName) { return default(System.Collections.IEnumerable); }
    [System.ObsoleteAttribute("Use of this method is not recommended because template editing is handled in ControlDesigner. To support template editing expose template data in the TemplateGroups property and call SetViewFlags(ViewFlags.TemplateEditing, true). http://go.microsoft.com/fwlink/?linkid=14202")]
    public abstract string GetTemplateContent(System.Web.UI.Design.ITemplateEditingFrame editingFrame, string templateName, out bool allowEditing);
    [System.ObsoleteAttribute("Use of this method is not recommended because template editing is handled in ControlDesigner. To support template editing expose template data in the TemplateGroups property and call SetViewFlags(ViewFlags.TemplateEditing, true). http://go.microsoft.com/fwlink/?linkid=14202")]
    public System.Web.UI.Design.TemplateEditingVerb[] GetTemplateEditingVerbs() { return default(System.Web.UI.Design.TemplateEditingVerb[]); }
    protected System.Web.UI.ITemplate GetTemplateFromText(string text) { return default(System.Web.UI.ITemplate); }
    [System.ObsoleteAttribute("Use of this method is not recommended because template editing is handled in ControlDesigner. To support template editing expose template data in the TemplateGroups property and call SetViewFlags(ViewFlags.TemplateEditing, true). http://go.microsoft.com/fwlink/?linkid=14202")]
    public virtual System.Type GetTemplatePropertyParentType(string templateName) { return default(System.Type); }
    protected string GetTextFromTemplate(System.Web.UI.ITemplate template) { return default(string); }
    public override void Initialize(System.ComponentModel.IComponent component) { }
    [System.ObsoleteAttribute("The recommended alternative is ControlDesigner.Tag. http://go.microsoft.com/fwlink/?linkid=14202")]
    protected override void OnBehaviorAttached() { }
    public override void OnComponentChanged(object sender, System.ComponentModel.Design.ComponentChangedEventArgs ce) { }
    public override void OnSetParent() { }
    protected virtual void OnTemplateModeChanged() { }
    protected void SaveActiveTemplateEditingFrame() { }
    [System.ObsoleteAttribute("Use of this method is not recommended because template editing is handled in ControlDesigner. To support template editing expose template data in the TemplateGroups property and call SetViewFlags(ViewFlags.TemplateEditing, true). http://go.microsoft.com/fwlink/?linkid=14202")]
    public abstract void SetTemplateContent(System.Web.UI.Design.ITemplateEditingFrame editingFrame, string templateName, string templateContent);
    public override void UpdateDesignTimeHtml() { }
  }
  public partial class TemplatedEditableDesignerRegion : System.Web.UI.Design.EditableDesignerRegion {
    public TemplatedEditableDesignerRegion(System.Web.UI.Design.TemplateDefinition templateDefinition) : base (default(System.Web.UI.Design.ControlDesigner), default(string)) { }
    public virtual bool IsSingleInstanceTemplate { get { return default(bool); } set { } }
    public override bool SupportsDataBinding { get { return default(bool); } set { } }
    public System.Web.UI.Design.TemplateDefinition TemplateDefinition { get { return default(System.Web.UI.Design.TemplateDefinition); } }
  }
  public partial class TemplateDefinition : System.Web.UI.Design.DesignerObject {
    public TemplateDefinition(System.Web.UI.Design.ControlDesigner designer, string name, object templatedObject, string templatePropertyName) : base (default(System.Web.UI.Design.ControlDesigner), default(string)) { }
    public TemplateDefinition(System.Web.UI.Design.ControlDesigner designer, string name, object templatedObject, string templatePropertyName, bool serverControlsOnly) : base (default(System.Web.UI.Design.ControlDesigner), default(string)) { }
    public TemplateDefinition(System.Web.UI.Design.ControlDesigner designer, string name, object templatedObject, string templatePropertyName, System.Web.UI.WebControls.Style style) : base (default(System.Web.UI.Design.ControlDesigner), default(string)) { }
    public TemplateDefinition(System.Web.UI.Design.ControlDesigner designer, string name, object templatedObject, string templatePropertyName, System.Web.UI.WebControls.Style style, bool serverControlsOnly) : base (default(System.Web.UI.Design.ControlDesigner), default(string)) { }
    public virtual bool AllowEditing { get { return default(bool); } }
    public virtual string Content { get { return default(string); } set { } }
    public bool ServerControlsOnly { get { return default(bool); } }
    public System.Web.UI.WebControls.Style Style { get { return default(System.Web.UI.WebControls.Style); } }
    public bool SupportsDataBinding { get { return default(bool); } set { } }
    public object TemplatedObject { get { return default(object); } }
    public string TemplatePropertyName { get { return default(string); } }
  }
  [System.ObsoleteAttribute("Use of this type is not recommended because template editing is handled in ControlDesigner. To support template editing expose template data in the TemplateGroups property and call SetViewFlags(ViewFlags.TemplateEditing, true). http://go.microsoft.com/fwlink/?linkid=14202")]
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public sealed partial class TemplateEditingService : System.IDisposable, System.Web.UI.Design.ITemplateEditingService {
    public TemplateEditingService(System.ComponentModel.Design.IDesignerHost designerHost) { }
    public bool SupportsNestedTemplateEditing { get { return default(bool); } }
    public System.Web.UI.Design.ITemplateEditingFrame CreateFrame(System.Web.UI.Design.TemplatedControlDesigner designer, string frameName, System.String[] templateNames) { return default(System.Web.UI.Design.ITemplateEditingFrame); }
    public System.Web.UI.Design.ITemplateEditingFrame CreateFrame(System.Web.UI.Design.TemplatedControlDesigner designer, string frameName, System.String[] templateNames, System.Web.UI.WebControls.Style controlStyle, System.Web.UI.WebControls.Style[] templateStyles) { return default(System.Web.UI.Design.ITemplateEditingFrame); }
    public void Dispose() { }
    ~TemplateEditingService() { }
    public string GetContainingTemplateName(System.Web.UI.Control control) { return default(string); }
  }
  [System.ObsoleteAttribute("Use of this type is not recommended because template editing is handled in ControlDesigner. To support template editing expose template data in the TemplateGroups property and call SetViewFlags(ViewFlags.TemplateEditing, true). http://go.microsoft.com/fwlink/?linkid=14202")]
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class TemplateEditingVerb : System.ComponentModel.Design.DesignerVerb, System.IDisposable {
    public TemplateEditingVerb(string text, int index) : base (default(string), default(System.EventHandler)) { }
    public TemplateEditingVerb(string text, int index, System.Web.UI.Design.TemplatedControlDesigner designer) : base (default(string), default(System.EventHandler)) { }
    public int Index { get { return default(int); } }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    ~TemplateEditingVerb() { }
  }
  public partial class TemplateGroup {
    public TemplateGroup(string groupName) { }
    public TemplateGroup(string groupName, System.Web.UI.WebControls.Style groupStyle) { }
    public string GroupName { get { return default(string); } }
    public System.Web.UI.WebControls.Style GroupStyle { get { return default(System.Web.UI.WebControls.Style); } }
    public bool IsEmpty { get { return default(bool); } }
    public System.Web.UI.Design.TemplateDefinition[] Templates { get { return default(System.Web.UI.Design.TemplateDefinition[]); } }
    public void AddTemplateDefinition(System.Web.UI.Design.TemplateDefinition templateDefinition) { }
  }
  public sealed partial class TemplateGroupCollection : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList {
    public TemplateGroupCollection() { }
    public int Count { get { return default(int); } }
    public System.Web.UI.Design.TemplateGroup this[int index] { get { return default(System.Web.UI.Design.TemplateGroup); } set { } }
    int System.Collections.ICollection.Count { get { return default(int); } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    bool System.Collections.IList.IsFixedSize { get { return default(bool); } }
    bool System.Collections.IList.IsReadOnly { get { return default(bool); } }
    object System.Collections.IList.this[int index] { get { return default(object); } set { } }
    public int Add(System.Web.UI.Design.TemplateGroup group) { return default(int); }
    public void AddRange(System.Web.UI.Design.TemplateGroupCollection groups) { }
    public void Clear() { }
    public bool Contains(System.Web.UI.Design.TemplateGroup group) { return default(bool); }
    public void CopyTo(System.Web.UI.Design.TemplateGroup[] array, int index) { }
    public int IndexOf(System.Web.UI.Design.TemplateGroup group) { return default(int); }
    public void Insert(int index, System.Web.UI.Design.TemplateGroup group) { }
    public void Remove(System.Web.UI.Design.TemplateGroup group) { }
    public void RemoveAt(int index) { }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    int System.Collections.IList.Add(object o) { return default(int); }
    void System.Collections.IList.Clear() { }
    bool System.Collections.IList.Contains(object o) { return default(bool); }
    int System.Collections.IList.IndexOf(object o) { return default(int); }
    void System.Collections.IList.Insert(int index, object o) { }
    void System.Collections.IList.Remove(object o) { }
    void System.Collections.IList.RemoveAt(int index) { }
  }
  public partial class TemplateModeChangedEventArgs : System.EventArgs {
    public TemplateModeChangedEventArgs(System.Web.UI.Design.TemplateGroup newTemplateGroup) { }
    public System.Web.UI.Design.TemplateGroup NewTemplateGroup { get { return default(System.Web.UI.Design.TemplateGroup); } }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class TextControlDesigner : System.Web.UI.Design.ControlDesigner {
    public TextControlDesigner() { }
    public override string GetDesignTimeHtml() { return default(string); }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class TextDataBindingHandler : System.Web.UI.Design.DataBindingHandler {
    public TextDataBindingHandler() { }
    public override void DataBindControl(System.ComponentModel.Design.IDesignerHost designerHost, System.Web.UI.Control control) { }
  }
  public delegate bool TransactedChangeCallback(object context);
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public sealed partial class TypeSchema : System.Web.UI.Design.IDataSourceSchema {
    public TypeSchema(System.Type type) { }
    public System.Web.UI.Design.IDataSourceViewSchema[] GetViews() { return default(System.Web.UI.Design.IDataSourceViewSchema[]); }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public sealed partial class UrlBuilder {
    internal UrlBuilder() { }
    public static string BuildUrl(System.ComponentModel.IComponent component, System.Windows.Forms.Control owner, string initialUrl, string caption, string filter) { return default(string); }
    public static string BuildUrl(System.ComponentModel.IComponent component, System.Windows.Forms.Control owner, string initialUrl, string caption, string filter, System.Web.UI.Design.UrlBuilderOptions options) { return default(string); }
    public static string BuildUrl(System.IServiceProvider serviceProvider, System.Windows.Forms.Control owner, string initialUrl, string caption, string filter, System.Web.UI.Design.UrlBuilderOptions options) { return default(string); }
  }
  [System.FlagsAttribute]
  public enum UrlBuilderOptions {
    NoAbsolute = 1,
    None = 0,
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class UrlEditor : System.Drawing.Design.UITypeEditor {
    public UrlEditor() { }
    protected virtual string Caption { get { return default(string); } }
    protected virtual string Filter { get { return default(string); } }
    protected virtual System.Web.UI.Design.UrlBuilderOptions Options { get { return default(System.Web.UI.Design.UrlBuilderOptions); } }
    public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { return default(object); }
    public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { return default(System.Drawing.Design.UITypeEditorEditStyle); }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class UserControlDesigner : System.Web.UI.Design.ControlDesigner {
    public UserControlDesigner() { }
    public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { return default(System.ComponentModel.Design.DesignerActionListCollection); } }
    public override bool AllowResize { get { return default(bool); } }
    public override string GetDesignTimeHtml() { return default(string); }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class UserControlFileEditor : System.Web.UI.Design.UrlEditor {
    public UserControlFileEditor() { }
    protected override string Caption { get { return default(string); } }
    protected override string Filter { get { return default(string); } }
  }
  public sealed partial class ViewEvent {
    internal ViewEvent() { }
    public static readonly System.Web.UI.Design.ViewEvent Click;
    public static readonly System.Web.UI.Design.ViewEvent Paint;
    public static readonly System.Web.UI.Design.ViewEvent TemplateModeChanged;
  }
  public partial class ViewEventArgs : System.EventArgs {
    public ViewEventArgs(System.Web.UI.Design.ViewEvent eventType, System.Web.UI.Design.DesignerRegion region, System.EventArgs eventArgs) { }
    public System.EventArgs EventArgs { get { return default(System.EventArgs); } }
    public System.Web.UI.Design.ViewEvent EventType { get { return default(System.Web.UI.Design.ViewEvent); } }
    public System.Web.UI.Design.DesignerRegion Region { get { return default(System.Web.UI.Design.DesignerRegion); } }
  }
  public delegate void ViewEventHandler(object sender, System.Web.UI.Design.ViewEventArgs e);
  [System.FlagsAttribute]
  public enum ViewFlags {
    CustomPaint = 1,
    DesignTimeHtmlRequiresLoadComplete = 2,
    TemplateEditing = 4,
  }
  public partial class ViewRendering {
    public ViewRendering(string content, System.Web.UI.Design.DesignerRegionCollection regions) { }
    public ViewRendering(string content, System.Web.UI.Design.DesignerRegionCollection regions, bool visible) { }
    public string Content { get { return default(string); } }
    public System.Web.UI.Design.DesignerRegionCollection Regions { get { return default(System.Web.UI.Design.DesignerRegionCollection); } }
    public bool Visible { get { return default(bool); } }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class WebControlToolboxItem : System.Drawing.Design.ToolboxItem {
    public WebControlToolboxItem() { }
    protected WebControlToolboxItem(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public WebControlToolboxItem(System.Type type) { }
    protected override System.ComponentModel.IComponent[] CreateComponentsCore(System.ComponentModel.Design.IDesignerHost host) { return default(System.ComponentModel.IComponent[]); }
    protected override void Deserialize(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public object GetToolAttributeValue(System.ComponentModel.Design.IDesignerHost host, System.Type attributeType) { return default(object); }
    public string GetToolHtml(System.ComponentModel.Design.IDesignerHost host) { return default(string); }
    public System.Type GetToolType(System.ComponentModel.Design.IDesignerHost host) { return default(System.Type); }
    public override void Initialize(System.Type type) { }
    protected override void Serialize(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial class WebFormsDesignerActionService : System.ComponentModel.Design.DesignerActionService {
    public WebFormsDesignerActionService(System.IServiceProvider serviceProvider) : base (default(System.IServiceProvider)) { }
    protected override void GetComponentDesignerActions(System.ComponentModel.IComponent component, System.ComponentModel.Design.DesignerActionListCollection actionLists) { }
  }
  public abstract partial class WebFormsReferenceManager {
    protected WebFormsReferenceManager() { }
    public abstract System.Collections.ICollection GetRegisterDirectives();
    public abstract string GetTagPrefix(System.Type objectType);
    public abstract System.Type GetType(string tagPrefix, string tagName);
    public abstract string GetUserControlPath(string tagPrefix, string tagName);
    public abstract string RegisterTagPrefix(System.Type objectType);
  }
  public abstract partial class WebFormsRootDesigner : System.ComponentModel.Design.IDesigner, System.ComponentModel.Design.IDesignerFilter, System.ComponentModel.Design.IRootDesigner, System.IDisposable {
    protected WebFormsRootDesigner() { }
    public virtual System.ComponentModel.IComponent Component { get { return default(System.ComponentModel.IComponent); } set { } }
    public System.Globalization.CultureInfo CurrentCulture { get { return default(System.Globalization.CultureInfo); } }
    public abstract string DocumentUrl { get; }
    public abstract bool IsDesignerViewLocked { get; }
    public abstract bool IsLoading { get; }
    public abstract System.Web.UI.Design.WebFormsReferenceManager ReferenceManager { get; }
    protected System.ComponentModel.Design.ViewTechnology[] SupportedTechnologies { get { return default(System.ComponentModel.Design.ViewTechnology[]); } }
    System.ComponentModel.Design.DesignerVerbCollection System.ComponentModel.Design.IDesigner.Verbs { get { return default(System.ComponentModel.Design.DesignerVerbCollection); } }
    System.ComponentModel.Design.ViewTechnology[] System.ComponentModel.Design.IRootDesigner.SupportedTechnologies { get { return default(System.ComponentModel.Design.ViewTechnology[]); } }
    protected System.ComponentModel.Design.DesignerVerbCollection Verbs { get { return default(System.ComponentModel.Design.DesignerVerbCollection); } }
    public event System.EventHandler LoadComplete { add { } remove { } }
    public abstract void AddClientScriptToDocument(System.Web.UI.Design.ClientScriptItem scriptItem);
    public abstract string AddControlToDocument(System.Web.UI.Control newControl, System.Web.UI.Control referenceControl, System.Web.UI.Design.ControlLocation location);
    protected virtual System.ComponentModel.Design.DesignerActionService CreateDesignerActionService(System.IServiceProvider serviceProvider) { return default(System.ComponentModel.Design.DesignerActionService); }
    protected virtual System.Web.UI.IUrlResolutionService CreateUrlResolutionService() { return default(System.Web.UI.IUrlResolutionService); }
    protected virtual void Dispose(bool disposing) { }
    ~WebFormsRootDesigner() { }
    public virtual string GenerateEmptyDesignTimeHtml(System.Web.UI.Control control) { return default(string); }
    public virtual string GenerateErrorDesignTimeHtml(System.Web.UI.Control control, System.Exception e, string errorMessage) { return default(string); }
    public abstract System.Web.UI.Design.ClientScriptItemCollection GetClientScriptsInDocument();
    protected internal abstract void GetControlViewAndTag(System.Web.UI.Control control, out System.Web.UI.Design.IControlDesignerView view, out System.Web.UI.Design.IControlDesignerTag tag);
    protected internal virtual object GetService(System.Type serviceType) { return default(object); }
    protected object GetView(System.ComponentModel.Design.ViewTechnology viewTechnology) { return default(object); }
    public virtual void Initialize(System.ComponentModel.IComponent component) { }
    protected virtual void OnLoadComplete(System.EventArgs e) { }
    protected virtual void PostFilterAttributes(System.Collections.IDictionary attributes) { }
    protected virtual void PostFilterEvents(System.Collections.IDictionary events) { }
    protected virtual void PostFilterProperties(System.Collections.IDictionary properties) { }
    protected virtual void PreFilterAttributes(System.Collections.IDictionary attributes) { }
    protected virtual void PreFilterEvents(System.Collections.IDictionary events) { }
    protected virtual void PreFilterProperties(System.Collections.IDictionary properties) { }
    public abstract void RemoveClientScriptFromDocument(string clientScriptId);
    public abstract void RemoveControlFromDocument(System.Web.UI.Control control);
    public string ResolveUrl(string relativeUrl) { return default(string); }
    public virtual void SetControlID(System.Web.UI.Control control, string id) { }
    void System.ComponentModel.Design.IDesigner.DoDefaultAction() { }
    void System.ComponentModel.Design.IDesignerFilter.PostFilterAttributes(System.Collections.IDictionary attributes) { }
    void System.ComponentModel.Design.IDesignerFilter.PostFilterEvents(System.Collections.IDictionary events) { }
    void System.ComponentModel.Design.IDesignerFilter.PostFilterProperties(System.Collections.IDictionary properties) { }
    void System.ComponentModel.Design.IDesignerFilter.PreFilterAttributes(System.Collections.IDictionary attributes) { }
    void System.ComponentModel.Design.IDesignerFilter.PreFilterEvents(System.Collections.IDictionary events) { }
    void System.ComponentModel.Design.IDesignerFilter.PreFilterProperties(System.Collections.IDictionary properties) { }
    object System.ComponentModel.Design.IRootDesigner.GetView(System.ComponentModel.Design.ViewTechnology viewTechnology) { return default(object); }
    void System.IDisposable.Dispose() { }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class XmlDataFileEditor : System.Web.UI.Design.UrlEditor {
    public XmlDataFileEditor() { }
    protected override string Caption { get { return default(string); } }
    protected override string Filter { get { return default(string); } }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public sealed partial class XmlDocumentSchema : System.Web.UI.Design.IDataSourceSchema {
    public XmlDocumentSchema(System.Xml.XmlDocument xmlDocument, string xPath) { }
    public System.Web.UI.Design.IDataSourceViewSchema[] GetViews() { return default(System.Web.UI.Design.IDataSourceViewSchema[]); }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class XmlFileEditor : System.Drawing.Design.UITypeEditor {
    public XmlFileEditor() { }
    public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { return default(object); }
    public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { return default(System.Drawing.Design.UITypeEditorEditStyle); }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class XmlUrlEditor : System.Web.UI.Design.UrlEditor {
    public XmlUrlEditor() { }
    protected override string Caption { get { return default(string); } }
    protected override string Filter { get { return default(string); } }
    protected override System.Web.UI.Design.UrlBuilderOptions Options { get { return default(System.Web.UI.Design.UrlBuilderOptions); } }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class XsdSchemaFileEditor : System.Web.UI.Design.UrlEditor {
    public XsdSchemaFileEditor() { }
    protected override string Caption { get { return default(string); } }
    protected override string Filter { get { return default(string); } }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class XslTransformFileEditor : System.Web.UI.Design.UrlEditor {
    public XslTransformFileEditor() { }
    protected override string Caption { get { return default(string); } }
    protected override string Filter { get { return default(string); } }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class XslUrlEditor : System.Web.UI.Design.UrlEditor {
    public XslUrlEditor() { }
    protected override string Caption { get { return default(string); } }
    protected override string Filter { get { return default(string); } }
    protected override System.Web.UI.Design.UrlBuilderOptions Options { get { return default(System.Web.UI.Design.UrlBuilderOptions); } }
  }
}
namespace System.Web.UI.Design.Directives {
  [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=false, Inherited=true)]
  public sealed partial class DirectiveAttribute : System.Attribute {
    public DirectiveAttribute() { }
    public bool AllowedOnMobilePages { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string BuilderType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool Culture { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string RenameType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool ServerLanguageExtensions { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool ServerLanguageNames { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public static partial class DirectiveRegistry {
    public static System.Collections.ObjectModel.ReadOnlyCollection<System.Type> GetDirectives(System.Version frameworkVersion, string extension) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Type>); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
  public sealed partial class SchemaElementNameAttribute : System.Attribute {
    public SchemaElementNameAttribute(string value) { }
    public string Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
  }
}
namespace System.Web.UI.Design.WebControls {
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class AccessDataSourceDesigner : System.Web.UI.Design.WebControls.SqlDataSourceDesigner {
    public AccessDataSourceDesigner() { }
    public string DataFile { get { return default(string); } set { } }
    protected override string GetConnectionString() { return default(string); }
    protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
  }
  [System.Web.UI.Design.SupportsPreviewControlAttribute(true)]
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class AdRotatorDesigner : System.Web.UI.Design.WebControls.DataBoundControlDesigner {
    public AdRotatorDesigner() { }
    public override string GetDesignTimeHtml() { return default(string); }
  }
  public abstract partial class BaseDataBoundControlDesigner : System.Web.UI.Design.ControlDesigner {
    protected BaseDataBoundControlDesigner() { }
    public string DataSource { get { return default(string); } set { } }
    public string DataSourceID { get { return default(string); } set { } }
    protected abstract bool ConnectToDataSource();
    protected abstract void CreateDataSource();
    protected abstract void DataBind(System.Web.UI.WebControls.BaseDataBoundControl dataBoundControl);
    protected abstract void DisconnectFromDataSource();
    protected override void Dispose(bool disposing) { }
    public override string GetDesignTimeHtml() { return default(string); }
    protected override string GetEmptyDesignTimeHtml() { return default(string); }
    protected override string GetErrorDesignTimeHtml(System.Exception e) { return default(string); }
    public override void Initialize(System.ComponentModel.IComponent component) { }
    protected virtual void OnDataSourceChanged(bool forceUpdateView) { }
    protected virtual void OnSchemaRefreshed() { }
    protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
    public static System.Windows.Forms.DialogResult ShowCreateDataSourceDialog(System.Web.UI.Design.ControlDesigner controlDesigner, System.Type dataSourceType, bool configure, out string dataSourceID) { dataSourceID = default(string); return default(System.Windows.Forms.DialogResult); }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public abstract partial class BaseDataListComponentEditor : System.Windows.Forms.Design.WindowsFormsComponentEditor {
    public BaseDataListComponentEditor(int initialPage) { }
    public override bool EditComponent(System.ComponentModel.ITypeDescriptorContext context, object obj, System.Windows.Forms.IWin32Window parent) { return default(bool); }
    protected override int GetInitialComponentEditorPageIndex() { return default(int); }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public abstract partial class BaseDataListDesigner : System.Web.UI.Design.TemplatedControlDesigner, System.Web.UI.Design.IDataBindingSchemaProvider, System.Web.UI.Design.IDataSourceProvider {
    protected BaseDataListDesigner() { }
    public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { return default(System.ComponentModel.Design.DesignerActionListCollection); } }
    public string DataKeyField { get { return default(string); } set { } }
    public string DataMember { get { return default(string); } set { } }
    public string DataSource { get { return default(string); } set { } }
    public System.Web.UI.Design.IDataSourceDesigner DataSourceDesigner { get { return default(System.Web.UI.Design.IDataSourceDesigner); } }
    public string DataSourceID { get { return default(string); } set { } }
    public System.Web.UI.Design.DesignerDataSourceView DesignerView { get { return default(System.Web.UI.Design.DesignerDataSourceView); } }
    bool System.Web.UI.Design.IDataBindingSchemaProvider.CanRefreshSchema { get { return default(bool); } }
    System.Web.UI.Design.IDataSourceViewSchema System.Web.UI.Design.IDataBindingSchemaProvider.Schema { get { return default(System.Web.UI.Design.IDataSourceViewSchema); } }
    protected override void Dispose(bool disposing) { }
    protected System.Collections.IEnumerable GetDesignTimeDataSource(System.Collections.IEnumerable selectedDataSource, int minimumRows, out bool dummyDataSource) { dummyDataSource = default(bool); return default(System.Collections.IEnumerable); }
    protected System.Collections.IEnumerable GetDesignTimeDataSource(int minimumRows, out bool dummyDataSource) { dummyDataSource = default(bool); return default(System.Collections.IEnumerable); }
    public System.Collections.IEnumerable GetResolvedSelectedDataSource() { return default(System.Collections.IEnumerable); }
    public object GetSelectedDataSource() { return default(object); }
    [System.ObsoleteAttribute("Use of this method is not recommended because template editing is handled in ControlDesigner. To support template editing expose template data in the TemplateGroups property and call SetViewFlags(ViewFlags.TemplateEditing, true). http://go.microsoft.com/fwlink/?linkid=14202")]
    public override System.Collections.IEnumerable GetTemplateContainerDataSource(string templateName) { return default(System.Collections.IEnumerable); }
    public override void Initialize(System.ComponentModel.IComponent component) { }
    protected internal void InvokePropertyBuilder(int initialPage) { }
    [System.ObsoleteAttribute("Use of this method is not recommended because the AutoFormat dialog is launched by the designer host. The list of available AutoFormats is exposed on the ControlDesigner in the AutoFormats property. http://go.microsoft.com/fwlink/?linkid=14202")]
    protected void OnAutoFormat(object sender, System.EventArgs e) { }
    public override void OnAutoFormatApplied(System.Web.UI.Design.DesignerAutoFormat appliedAutoFormat) { }
    public override void OnComponentChanged(object sender, System.ComponentModel.Design.ComponentChangedEventArgs e) { }
    protected internal virtual void OnDataSourceChanged() { }
    protected void OnPropertyBuilder(object sender, System.EventArgs e) { }
    protected virtual void OnSchemaRefreshed() { }
    protected internal void OnStylesChanged() { }
    protected abstract void OnTemplateEditingVerbsChanged();
    protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
    void System.Web.UI.Design.IDataBindingSchemaProvider.RefreshSchema(bool preferSilent) { }
  }
  [System.Web.UI.Design.SupportsPreviewControlAttribute(true)]
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class BaseValidatorDesigner : System.Web.UI.Design.WebControls.PreviewControlDesigner {
    public BaseValidatorDesigner() { }
    protected override System.Web.UI.Control CreateViewControl() { return default(System.Web.UI.Control); }
    public override string GetDesignTimeHtml() { return default(string); }
    protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
  }
  public partial class BulletedListDesigner : System.Web.UI.Design.WebControls.ListControlDesigner {
    public BulletedListDesigner() { }
    protected override bool UsePreviewControl { get { return default(bool); } }
    protected override void PostFilterEvents(System.Collections.IDictionary events) { }
  }
  [System.Web.UI.Design.SupportsPreviewControlAttribute(true)]
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class ButtonDesigner : System.Web.UI.Design.ControlDesigner {
    public ButtonDesigner() { }
    public override string GetDesignTimeHtml() { return default(string); }
  }
  [System.ComponentModel.ToolboxItemAttribute(false)]
  [System.ObsoleteAttribute("Use of this type is not recommended because the AutoFormat dialog is launched by the designer host. The list of available AutoFormats is exposed on the ControlDesigner in the AutoFormats property. http://go.microsoft.com/fwlink/?linkid=14202")]
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class CalendarAutoFormatDialog : System.Windows.Forms.Form {
    public CalendarAutoFormatDialog(System.Web.UI.WebControls.Calendar calendar) { }
    protected void DoDelayLoadActions() { }
    protected void OnActivated(object source, System.EventArgs e) { }
    protected void OnOKClicked(object source, System.EventArgs e) { }
    protected void OnSelChangedScheme(object source, System.EventArgs e) { }
    protected void SaveComponent() { }
  }
  [System.Web.UI.Design.SupportsPreviewControlAttribute(true)]
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class CalendarDesigner : System.Web.UI.Design.ControlDesigner {
    public CalendarDesigner() { }
    public override System.Web.UI.Design.DesignerAutoFormatCollection AutoFormats { get { return default(System.Web.UI.Design.DesignerAutoFormatCollection); } }
    public override void Initialize(System.ComponentModel.IComponent component) { }
    protected void OnAutoFormat(object sender, System.EventArgs e) { }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class ChangePasswordDesigner : System.Web.UI.Design.ControlDesigner {
    public ChangePasswordDesigner() { }
    public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { return default(System.ComponentModel.Design.DesignerActionListCollection); } }
    public override bool AllowResize { get { return default(bool); } }
    public override System.Web.UI.Design.DesignerAutoFormatCollection AutoFormats { get { return default(System.Web.UI.Design.DesignerAutoFormatCollection); } }
    public bool RenderOuterTable { get { return default(bool); } set { } }
    public override System.Web.UI.Design.TemplateGroupCollection TemplateGroups { get { return default(System.Web.UI.Design.TemplateGroupCollection); } }
    protected override bool UsePreviewControl { get { return default(bool); } }
    public override string GetDesignTimeHtml() { return default(string); }
    public override string GetDesignTimeHtml(System.Web.UI.Design.DesignerRegionCollection regions) { return default(string); }
    public override string GetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region) { return default(string); }
    protected override string GetErrorDesignTimeHtml(System.Exception e) { return default(string); }
    public override void Initialize(System.ComponentModel.IComponent component) { }
    protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
    public override void SetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region, string content) { }
  }
  [System.Web.UI.Design.SupportsPreviewControlAttribute(true)]
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class CheckBoxDesigner : System.Web.UI.Design.ControlDesigner {
    public CheckBoxDesigner() { }
    public override string GetDesignTimeHtml() { return default(string); }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class CompositeControlDesigner : System.Web.UI.Design.ControlDesigner {
    public CompositeControlDesigner() { }
    protected virtual void CreateChildControls() { }
    public override string GetDesignTimeHtml() { return default(string); }
    public override void Initialize(System.ComponentModel.IComponent component) { }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class ContentDesigner : System.Web.UI.Design.ControlDesigner {
    public ContentDesigner() { }
    public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { return default(System.ComponentModel.Design.DesignerActionListCollection); } }
    public override bool AllowResize { get { return default(bool); } }
    public override string GetDesignTimeHtml(System.Web.UI.Design.DesignerRegionCollection regions) { return default(string); }
    public override string GetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region) { return default(string); }
    public override string GetPersistenceContent() { return default(string); }
    protected override void PostFilterProperties(System.Collections.IDictionary properties) { }
    protected override void PreFilterEvents(System.Collections.IDictionary events) { }
    public override void SetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region, string content) { }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class ContentPlaceHolderDesigner : System.Web.UI.Design.ControlDesigner {
    public ContentPlaceHolderDesigner() { }
    public override bool AllowResize { get { return default(bool); } }
    public override string GetDesignTimeHtml() { return default(string); }
    public override string GetDesignTimeHtml(System.Web.UI.Design.DesignerRegionCollection regions) { return default(string); }
    public override string GetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region) { return default(string); }
    public override string GetPersistenceContent() { return default(string); }
    public override void SetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region, string content) { }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class CreateUserWizardDesigner : System.Web.UI.Design.WebControls.WizardDesigner {
    public CreateUserWizardDesigner() { }
    public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { return default(System.ComponentModel.Design.DesignerActionListCollection); } }
    public override System.Web.UI.Design.DesignerAutoFormatCollection AutoFormats { get { return default(System.Web.UI.Design.DesignerAutoFormatCollection); } }
    protected override bool UsePreviewControl { get { return default(bool); } }
    protected override void AddDesignerRegions(System.Web.UI.Design.DesignerRegionCollection regions) { }
    protected override void ConvertToCustomNavigationTemplate() { }
    protected override string GetErrorDesignTimeHtml(System.Exception e) { return default(string); }
    public override void Initialize(System.ComponentModel.IComponent component) { }
    protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class CreateUserWizardStepCollectionEditor : System.Web.UI.Design.WebControls.WizardStepCollectionEditor {
    public CreateUserWizardStepCollectionEditor(System.Type type) : base (default(System.Type)) { }
    protected override string HelpTopic { get { return default(string); } }
    protected override bool CanRemoveInstance(object value) { return default(bool); }
    protected override System.ComponentModel.Design.CollectionEditor.CollectionForm CreateCollectionForm() { return default(System.ComponentModel.Design.CollectionEditor.CollectionForm); }
  }
  public partial class DataBoundControlDesigner : System.Web.UI.Design.WebControls.BaseDataBoundControlDesigner, System.Web.UI.Design.IDataBindingSchemaProvider, System.Web.UI.Design.IDataSourceProvider {
    public DataBoundControlDesigner() { }
    public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { return default(System.ComponentModel.Design.DesignerActionListCollection); } }
    public string DataMember { get { return default(string); } set { } }
    public System.Web.UI.Design.IDataSourceDesigner DataSourceDesigner { get { return default(System.Web.UI.Design.IDataSourceDesigner); } }
    public System.Web.UI.Design.DesignerDataSourceView DesignerView { get { return default(System.Web.UI.Design.DesignerDataSourceView); } }
    protected virtual int SampleRowCount { get { return default(int); } }
    bool System.Web.UI.Design.IDataBindingSchemaProvider.CanRefreshSchema { get { return default(bool); } }
    System.Web.UI.Design.IDataSourceViewSchema System.Web.UI.Design.IDataBindingSchemaProvider.Schema { get { return default(System.Web.UI.Design.IDataSourceViewSchema); } }
    protected virtual bool UseDataSourcePickerActionList { get { return default(bool); } }
    protected override bool ConnectToDataSource() { return default(bool); }
    protected override void CreateDataSource() { }
    protected override void DataBind(System.Web.UI.WebControls.BaseDataBoundControl dataBoundControl) { }
    protected override void DisconnectFromDataSource() { }
    protected override void Dispose(bool disposing) { }
    protected virtual System.Collections.IEnumerable GetDesignTimeDataSource() { return default(System.Collections.IEnumerable); }
    protected virtual System.Collections.IEnumerable GetSampleDataSource() { return default(System.Collections.IEnumerable); }
    protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
    void System.Web.UI.Design.IDataBindingSchemaProvider.RefreshSchema(bool preferSilent) { }
    System.Collections.IEnumerable System.Web.UI.Design.IDataSourceProvider.GetResolvedSelectedDataSource() { return default(System.Collections.IEnumerable); }
    object System.Web.UI.Design.IDataSourceProvider.GetSelectedDataSource() { return default(object); }
  }
  public abstract partial class DataControlFieldDesigner {
    protected DataControlFieldDesigner() { }
    public abstract string DefaultNodeText { get; }
    protected System.IServiceProvider ServiceProvider { get { return default(System.IServiceProvider); } }
    public abstract bool UsesSchema { get; }
    public abstract System.Web.UI.WebControls.DataControlField CreateField();
    public abstract System.Web.UI.WebControls.DataControlField CreateField(System.Web.UI.Design.IDataSourceFieldSchema fieldSchema);
    public abstract System.Web.UI.WebControls.TemplateField CreateTemplateField(System.Web.UI.WebControls.DataControlField dataControlField, System.Web.UI.WebControls.DataBoundControl dataBoundControl);
    protected string GetNewDataSourceName(System.Type controlType, System.Web.UI.WebControls.DataBoundControlMode mode) { return default(string); }
    public abstract string GetNodeText(System.Web.UI.WebControls.DataControlField dataControlField);
    protected object GetService(System.Type serviceType) { return default(object); }
    protected System.Web.UI.ITemplate GetTemplate(System.Web.UI.WebControls.DataBoundControl control, string templateContent) { return default(System.Web.UI.ITemplate); }
    protected System.Web.UI.WebControls.TemplateField GetTemplateField(System.Web.UI.WebControls.DataControlField dataControlField, System.Web.UI.WebControls.DataBoundControl dataBoundControl) { return default(System.Web.UI.WebControls.TemplateField); }
    public abstract bool IsEnabled(System.Web.UI.WebControls.DataBoundControl parent);
  }
  public partial class DataControlFieldTypeEditor : System.Drawing.Design.UITypeEditor {
    public DataControlFieldTypeEditor() { }
    public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { return default(object); }
    public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { return default(System.Drawing.Design.UITypeEditorEditStyle); }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class DataGridColumnCollectionEditor : System.Drawing.Design.UITypeEditor {
    public DataGridColumnCollectionEditor() { }
    public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { return default(object); }
    public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { return default(System.Drawing.Design.UITypeEditorEditStyle); }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class DataGridComponentEditor : System.Web.UI.Design.WebControls.BaseDataListComponentEditor {
    public DataGridComponentEditor() : base (default(int)) { }
    public DataGridComponentEditor(int initialPage) : base (default(int)) { }
    protected override System.Type[] GetComponentEditorPages() { return default(System.Type[]); }
  }
  [System.Web.UI.Design.SupportsPreviewControlAttribute(true)]
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class DataGridDesigner : System.Web.UI.Design.WebControls.BaseDataListDesigner {
    public DataGridDesigner() { }
    public override System.Web.UI.Design.DesignerAutoFormatCollection AutoFormats { get { return default(System.Web.UI.Design.DesignerAutoFormatCollection); } }
    [System.ObsoleteAttribute("Use of this method is not recommended because template editing is handled in ControlDesigner. To support template editing expose template data in the TemplateGroups property and call SetViewFlags(ViewFlags.TemplateEditing, true). http://go.microsoft.com/fwlink/?linkid=14202")]
    protected override System.Web.UI.Design.ITemplateEditingFrame CreateTemplateEditingFrame(System.Web.UI.Design.TemplateEditingVerb verb) { return default(System.Web.UI.Design.ITemplateEditingFrame); }
    protected override void Dispose(bool disposing) { }
    [System.ObsoleteAttribute("Use of this method is not recommended because template editing is handled in ControlDesigner. To support template editing expose template data in the TemplateGroups property and call SetViewFlags(ViewFlags.TemplateEditing, true). http://go.microsoft.com/fwlink/?linkid=14202")]
    protected override System.Web.UI.Design.TemplateEditingVerb[] GetCachedTemplateEditingVerbs() { return default(System.Web.UI.Design.TemplateEditingVerb[]); }
    public override string GetDesignTimeHtml() { return default(string); }
    protected override string GetEmptyDesignTimeHtml() { return default(string); }
    protected override string GetErrorDesignTimeHtml(System.Exception e) { return default(string); }
    [System.ObsoleteAttribute("Use of this method is not recommended because template editing is handled in ControlDesigner. To support template editing expose template data in the TemplateGroups property and call SetViewFlags(ViewFlags.TemplateEditing, true). http://go.microsoft.com/fwlink/?linkid=14202")]
    public override string GetTemplateContainerDataItemProperty(string templateName) { return default(string); }
    [System.ObsoleteAttribute("Use of this method is not recommended because template editing is handled in ControlDesigner. To support template editing expose template data in the TemplateGroups property and call SetViewFlags(ViewFlags.TemplateEditing, true). http://go.microsoft.com/fwlink/?linkid=14202")]
    public override string GetTemplateContent(System.Web.UI.Design.ITemplateEditingFrame editingFrame, string templateName, out bool allowEditing) { allowEditing = default(bool); return default(string); }
    [System.ObsoleteAttribute("Use of this method is not recommended because template editing is handled in ControlDesigner. To support template editing expose template data in the TemplateGroups property and call SetViewFlags(ViewFlags.TemplateEditing, true). http://go.microsoft.com/fwlink/?linkid=14202")]
    public override System.Type GetTemplatePropertyParentType(string templateName) { return default(System.Type); }
    public override void Initialize(System.ComponentModel.IComponent component) { }
    public virtual void OnColumnsChanged() { }
    protected override void OnTemplateEditingVerbsChanged() { }
    [System.ObsoleteAttribute("Use of this method is not recommended because template editing is handled in ControlDesigner. To support template editing expose template data in the TemplateGroups property and call SetViewFlags(ViewFlags.TemplateEditing, true). http://go.microsoft.com/fwlink/?linkid=14202")]
    public override void SetTemplateContent(System.Web.UI.Design.ITemplateEditingFrame editingFrame, string templateName, string templateContent) { }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class DataListComponentEditor : System.Web.UI.Design.WebControls.BaseDataListComponentEditor {
    public DataListComponentEditor() : base (default(int)) { }
    public DataListComponentEditor(int initialPage) : base (default(int)) { }
    protected override System.Type[] GetComponentEditorPages() { return default(System.Type[]); }
  }
  [System.Web.UI.Design.SupportsPreviewControlAttribute(true)]
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class DataListDesigner : System.Web.UI.Design.WebControls.BaseDataListDesigner {
    public DataListDesigner() { }
    public override bool AllowResize { get { return default(bool); } }
    public override System.Web.UI.Design.DesignerAutoFormatCollection AutoFormats { get { return default(System.Web.UI.Design.DesignerAutoFormatCollection); } }
    protected bool TemplatesExist { get { return default(bool); } }
    [System.ObsoleteAttribute("Use of this method is not recommended because template editing is handled in ControlDesigner. To support template editing expose template data in the TemplateGroups property and call SetViewFlags(ViewFlags.TemplateEditing, true). http://go.microsoft.com/fwlink/?linkid=14202")]
    protected override System.Web.UI.Design.ITemplateEditingFrame CreateTemplateEditingFrame(System.Web.UI.Design.TemplateEditingVerb verb) { return default(System.Web.UI.Design.ITemplateEditingFrame); }
    protected override void Dispose(bool disposing) { }
    [System.ObsoleteAttribute("Use of this method is not recommended because template editing is handled in ControlDesigner. To support template editing expose template data in the TemplateGroups property and call SetViewFlags(ViewFlags.TemplateEditing, true). http://go.microsoft.com/fwlink/?linkid=14202")]
    protected override System.Web.UI.Design.TemplateEditingVerb[] GetCachedTemplateEditingVerbs() { return default(System.Web.UI.Design.TemplateEditingVerb[]); }
    public override string GetDesignTimeHtml() { return default(string); }
    protected override string GetEmptyDesignTimeHtml() { return default(string); }
    protected override string GetErrorDesignTimeHtml(System.Exception e) { return default(string); }
    [System.ObsoleteAttribute("Use of this method is not recommended because template editing is handled in ControlDesigner. To support template editing expose template data in the TemplateGroups property and call SetViewFlags(ViewFlags.TemplateEditing, true). http://go.microsoft.com/fwlink/?linkid=14202")]
    public override string GetTemplateContainerDataItemProperty(string templateName) { return default(string); }
    [System.ObsoleteAttribute("Use of this method is not recommended because template editing is handled in ControlDesigner. To support template editing expose template data in the TemplateGroups property and call SetViewFlags(ViewFlags.TemplateEditing, true). http://go.microsoft.com/fwlink/?linkid=14202")]
    public override string GetTemplateContent(System.Web.UI.Design.ITemplateEditingFrame editingFrame, string templateName, out bool allowEditing) { allowEditing = default(bool); return default(string); }
    public override void Initialize(System.ComponentModel.IComponent component) { }
    protected override void OnSchemaRefreshed() { }
    protected override void OnTemplateEditingVerbsChanged() { }
    [System.ObsoleteAttribute("Use of this method is not recommended because template editing is handled in ControlDesigner. To support template editing expose template data in the TemplateGroups property and call SetViewFlags(ViewFlags.TemplateEditing, true). http://go.microsoft.com/fwlink/?linkid=14202")]
    public override void SetTemplateContent(System.Web.UI.Design.ITemplateEditingFrame editingFrame, string templateName, string templateContent) { }
  }
  public partial class DataProviderNameConverter : System.ComponentModel.StringConverter {
    public DataProviderNameConverter() { }
    public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { return default(System.ComponentModel.TypeConverter.StandardValuesCollection); }
    public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
  }
  public partial class DataSourceIDConverter : System.ComponentModel.TypeConverter {
    public DataSourceIDConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { return default(System.ComponentModel.TypeConverter.StandardValuesCollection); }
    public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    protected virtual bool IsValidDataSource(System.ComponentModel.IComponent component) { return default(bool); }
  }
  public partial class DetailsViewDesigner : System.Web.UI.Design.WebControls.DataBoundControlDesigner {
    public DetailsViewDesigner() { }
    public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { return default(System.ComponentModel.Design.DesignerActionListCollection); } }
    public override System.Web.UI.Design.DesignerAutoFormatCollection AutoFormats { get { return default(System.Web.UI.Design.DesignerAutoFormatCollection); } }
    protected override int SampleRowCount { get { return default(int); } }
    public override System.Web.UI.Design.TemplateGroupCollection TemplateGroups { get { return default(System.Web.UI.Design.TemplateGroupCollection); } }
    protected override bool UsePreviewControl { get { return default(bool); } }
    protected override void DataBind(System.Web.UI.WebControls.BaseDataBoundControl dataBoundControl) { }
    public override string GetDesignTimeHtml() { return default(string); }
    public override string GetDesignTimeHtml(System.Web.UI.Design.DesignerRegionCollection regions) { return default(string); }
    public override string GetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region) { return default(string); }
    public override void Initialize(System.ComponentModel.IComponent component) { }
    protected override void OnClick(System.Web.UI.Design.DesignerRegionMouseEventArgs e) { }
    protected override void OnSchemaRefreshed() { }
    protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
    public override void SetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region, string content) { }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class EmbeddedMailObjectCollectionEditor : System.ComponentModel.Design.CollectionEditor {
    public EmbeddedMailObjectCollectionEditor(System.Type type) : base (default(System.Type)) { }
    public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { return default(object); }
  }
  public partial class FormViewDesigner : System.Web.UI.Design.WebControls.DataBoundControlDesigner {
    public FormViewDesigner() { }
    public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { return default(System.ComponentModel.Design.DesignerActionListCollection); } }
    public override System.Web.UI.Design.DesignerAutoFormatCollection AutoFormats { get { return default(System.Web.UI.Design.DesignerAutoFormatCollection); } }
    public bool RenderOuterTable { get { return default(bool); } set { } }
    protected override int SampleRowCount { get { return default(int); } }
    public override System.Web.UI.Design.TemplateGroupCollection TemplateGroups { get { return default(System.Web.UI.Design.TemplateGroupCollection); } }
    protected override bool UsePreviewControl { get { return default(bool); } }
    public override string GetDesignTimeHtml() { return default(string); }
    protected override string GetEmptyDesignTimeHtml() { return default(string); }
    public override void Initialize(System.ComponentModel.IComponent component) { }
    protected override void OnSchemaRefreshed() { }
    protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
  }
  public partial class GridViewDesigner : System.Web.UI.Design.WebControls.DataBoundControlDesigner {
    public GridViewDesigner() { }
    public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { return default(System.ComponentModel.Design.DesignerActionListCollection); } }
    public override System.Web.UI.Design.DesignerAutoFormatCollection AutoFormats { get { return default(System.Web.UI.Design.DesignerAutoFormatCollection); } }
    protected override int SampleRowCount { get { return default(int); } }
    public override System.Web.UI.Design.TemplateGroupCollection TemplateGroups { get { return default(System.Web.UI.Design.TemplateGroupCollection); } }
    protected override bool UsePreviewControl { get { return default(bool); } }
    protected override void DataBind(System.Web.UI.WebControls.BaseDataBoundControl dataBoundControl) { }
    public override string GetDesignTimeHtml() { return default(string); }
    public override string GetDesignTimeHtml(System.Web.UI.Design.DesignerRegionCollection regions) { return default(string); }
    public override string GetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region) { return default(string); }
    public override void Initialize(System.ComponentModel.IComponent component) { }
    protected override void OnClick(System.Web.UI.Design.DesignerRegionMouseEventArgs e) { }
    protected override void OnSchemaRefreshed() { }
    protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
    public override void SetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region, string content) { }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class HiddenFieldDesigner : System.Web.UI.Design.ControlDesigner {
    public HiddenFieldDesigner() { }
    public override string GetDesignTimeHtml() { return default(string); }
    public override void Initialize(System.ComponentModel.IComponent component) { }
  }
  public partial class HierarchicalDataBoundControlDesigner : System.Web.UI.Design.WebControls.BaseDataBoundControlDesigner {
    public HierarchicalDataBoundControlDesigner() { }
    public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { return default(System.ComponentModel.Design.DesignerActionListCollection); } }
    public System.Web.UI.Design.IHierarchicalDataSourceDesigner DataSourceDesigner { get { return default(System.Web.UI.Design.IHierarchicalDataSourceDesigner); } }
    public System.Web.UI.Design.DesignerHierarchicalDataSourceView DesignerView { get { return default(System.Web.UI.Design.DesignerHierarchicalDataSourceView); } }
    protected virtual bool UseDataSourcePickerActionList { get { return default(bool); } }
    protected override bool ConnectToDataSource() { return default(bool); }
    protected override void CreateDataSource() { }
    protected override void DataBind(System.Web.UI.WebControls.BaseDataBoundControl dataBoundControl) { }
    protected override void DisconnectFromDataSource() { }
    protected virtual System.Web.UI.IHierarchicalEnumerable GetDesignTimeDataSource() { return default(System.Web.UI.IHierarchicalEnumerable); }
    protected virtual System.Web.UI.IHierarchicalEnumerable GetSampleDataSource() { return default(System.Web.UI.IHierarchicalEnumerable); }
    protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
  }
  public partial class HierarchicalDataSourceIDConverter : System.Web.UI.Design.WebControls.DataSourceIDConverter {
    public HierarchicalDataSourceIDConverter() { }
    protected override bool IsValidDataSource(System.ComponentModel.IComponent component) { return default(bool); }
  }
  public partial class HotSpotCollectionEditor : System.ComponentModel.Design.CollectionEditor {
    public HotSpotCollectionEditor(System.Type type) : base (default(System.Type)) { }
    protected override string HelpTopic { get { return default(string); } }
    protected override bool CanSelectMultipleInstances() { return default(bool); }
    protected override System.Type[] CreateNewItemTypes() { return default(System.Type[]); }
  }
  [System.Web.UI.Design.SupportsPreviewControlAttribute(true)]
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class HyperLinkDesigner : System.Web.UI.Design.TextControlDesigner {
    public HyperLinkDesigner() { }
    public override string GetDesignTimeHtml() { return default(string); }
    public override void OnComponentChanged(object sender, System.ComponentModel.Design.ComponentChangedEventArgs ce) { }
  }
  [System.Web.UI.Design.SupportsPreviewControlAttribute(true)]
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class LabelDesigner : System.Web.UI.Design.TextControlDesigner {
    public LabelDesigner() { }
    public override void OnComponentChanged(object sender, System.ComponentModel.Design.ComponentChangedEventArgs ce) { }
  }
  [System.Web.UI.Design.SupportsPreviewControlAttribute(true)]
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class LinkButtonDesigner : System.Web.UI.Design.TextControlDesigner {
    public LinkButtonDesigner() { }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class ListControlDataBindingHandler : System.Web.UI.Design.DataBindingHandler {
    public ListControlDataBindingHandler() { }
    public override void DataBindControl(System.ComponentModel.Design.IDesignerHost designerHost, System.Web.UI.Control control) { }
  }
  [System.Web.UI.Design.SupportsPreviewControlAttribute(true)]
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class ListControlDesigner : System.Web.UI.Design.WebControls.DataBoundControlDesigner {
    public ListControlDesigner() { }
    public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { return default(System.ComponentModel.Design.DesignerActionListCollection); } }
    public string DataTextField { get { return default(string); } set { } }
    public string DataValueField { get { return default(string); } set { } }
    protected override bool UseDataSourcePickerActionList { get { return default(bool); } }
    protected override void DataBind(System.Web.UI.WebControls.BaseDataBoundControl dataBoundControl) { }
    public override string GetDesignTimeHtml() { return default(string); }
    public System.Collections.IEnumerable GetResolvedSelectedDataSource() { return default(System.Collections.IEnumerable); }
    public object GetSelectedDataSource() { return default(object); }
    public override void Initialize(System.ComponentModel.IComponent component) { }
    public virtual void OnDataSourceChanged() { }
    protected override void OnDataSourceChanged(bool forceUpdateView) { }
    protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class ListItemsCollectionEditor : System.ComponentModel.Design.CollectionEditor {
    public ListItemsCollectionEditor(System.Type type) : base (default(System.Type)) { }
    protected override string HelpTopic { get { return default(string); } }
    protected override bool CanSelectMultipleInstances() { return default(bool); }
  }
  [System.Web.UI.Design.SupportsPreviewControlAttribute(true)]
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class LiteralDesigner : System.Web.UI.Design.ControlDesigner {
    public LiteralDesigner() { }
    public override void OnComponentChanged(object sender, System.ComponentModel.Design.ComponentChangedEventArgs ce) { }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class LoginDesigner : System.Web.UI.Design.WebControls.CompositeControlDesigner {
    public LoginDesigner() { }
    public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { return default(System.ComponentModel.Design.DesignerActionListCollection); } }
    public override bool AllowResize { get { return default(bool); } }
    public override System.Web.UI.Design.DesignerAutoFormatCollection AutoFormats { get { return default(System.Web.UI.Design.DesignerAutoFormatCollection); } }
    public bool RenderOuterTable { get { return default(bool); } set { } }
    public override System.Web.UI.Design.TemplateGroupCollection TemplateGroups { get { return default(System.Web.UI.Design.TemplateGroupCollection); } }
    protected override bool UsePreviewControl { get { return default(bool); } }
    public override string GetDesignTimeHtml(System.Web.UI.Design.DesignerRegionCollection regions) { return default(string); }
    public override string GetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region) { return default(string); }
    protected override string GetErrorDesignTimeHtml(System.Exception e) { return default(string); }
    public override void Initialize(System.ComponentModel.IComponent component) { }
    protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
    public override void SetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region, string content) { }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class LoginNameDesigner : System.Web.UI.Design.ControlDesigner {
    public LoginNameDesigner() { }
    protected override bool UsePreviewControl { get { return default(bool); } }
    protected override string GetErrorDesignTimeHtml(System.Exception e) { return default(string); }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class LoginStatusDesigner : System.Web.UI.Design.WebControls.CompositeControlDesigner {
    public LoginStatusDesigner() { }
    public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { return default(System.ComponentModel.Design.DesignerActionListCollection); } }
    protected override bool UsePreviewControl { get { return default(bool); } }
    public override string GetDesignTimeHtml() { return default(string); }
    public override void Initialize(System.ComponentModel.IComponent component) { }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class LoginViewDesigner : System.Web.UI.Design.ControlDesigner {
    public LoginViewDesigner() { }
    public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { return default(System.ComponentModel.Design.DesignerActionListCollection); } }
    public override System.Web.UI.Design.TemplateGroupCollection TemplateGroups { get { return default(System.Web.UI.Design.TemplateGroupCollection); } }
    protected override bool UsePreviewControl { get { return default(bool); } }
    public override string GetDesignTimeHtml() { return default(string); }
    public override string GetDesignTimeHtml(System.Web.UI.Design.DesignerRegionCollection regions) { return default(string); }
    public override string GetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region) { return default(string); }
    protected override string GetEmptyDesignTimeHtml() { return default(string); }
    protected override string GetErrorDesignTimeHtml(System.Exception e) { return default(string); }
    public override void Initialize(System.ComponentModel.IComponent component) { }
    public override void OnComponentChanged(object sender, System.ComponentModel.Design.ComponentChangedEventArgs e) { }
    protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
    public override void SetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region, string content) { }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class MailDefinitionBodyFileNameEditor : System.Web.UI.Design.UrlEditor {
    public MailDefinitionBodyFileNameEditor() { }
    protected override string Caption { get { return default(string); } }
    protected override string Filter { get { return default(string); } }
  }
  public partial class MenuBindingsEditor : System.Drawing.Design.UITypeEditor {
    public MenuBindingsEditor() { }
    public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { return default(object); }
    public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { return default(System.Drawing.Design.UITypeEditorEditStyle); }
  }
  public partial class MenuDesigner : System.Web.UI.Design.WebControls.HierarchicalDataBoundControlDesigner, System.Web.UI.Design.IDataBindingSchemaProvider {
    public MenuDesigner() { }
    public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { return default(System.ComponentModel.Design.DesignerActionListCollection); } }
    public override System.Web.UI.Design.DesignerAutoFormatCollection AutoFormats { get { return default(System.Web.UI.Design.DesignerAutoFormatCollection); } }
    protected bool CanRefreshSchema { get { return default(bool); } }
    protected System.Web.UI.Design.IDataSourceViewSchema Schema { get { return default(System.Web.UI.Design.IDataSourceViewSchema); } }
    bool System.Web.UI.Design.IDataBindingSchemaProvider.CanRefreshSchema { get { return default(bool); } }
    System.Web.UI.Design.IDataSourceViewSchema System.Web.UI.Design.IDataBindingSchemaProvider.Schema { get { return default(System.Web.UI.Design.IDataSourceViewSchema); } }
    public override System.Web.UI.Design.TemplateGroupCollection TemplateGroups { get { return default(System.Web.UI.Design.TemplateGroupCollection); } }
    protected override bool UsePreviewControl { get { return default(bool); } }
    protected override void DataBind(System.Web.UI.WebControls.BaseDataBoundControl dataBoundControl) { }
    public override string GetDesignTimeHtml() { return default(string); }
    protected override string GetEmptyDesignTimeHtml() { return default(string); }
    protected override string GetErrorDesignTimeHtml(System.Exception e) { return default(string); }
    protected override System.Web.UI.IHierarchicalEnumerable GetSampleDataSource() { return default(System.Web.UI.IHierarchicalEnumerable); }
    public override void Initialize(System.ComponentModel.IComponent component) { }
    protected void RefreshSchema(bool preferSilent) { }
    void System.Web.UI.Design.IDataBindingSchemaProvider.RefreshSchema(bool preferSilent) { }
  }
  public partial class MenuItemCollectionEditor : System.Drawing.Design.UITypeEditor {
    public MenuItemCollectionEditor() { }
    public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { return default(object); }
    public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { return default(System.Drawing.Design.UITypeEditorEditStyle); }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class MenuItemStyleCollectionEditor : System.ComponentModel.Design.CollectionEditor {
    public MenuItemStyleCollectionEditor(System.Type type) : base (default(System.Type)) { }
    protected override bool CanSelectMultipleInstances() { return default(bool); }
    protected override System.ComponentModel.Design.CollectionEditor.CollectionForm CreateCollectionForm() { return default(System.ComponentModel.Design.CollectionEditor.CollectionForm); }
    protected override object CreateInstance(System.Type itemType) { return default(object); }
    protected override System.Type[] CreateNewItemTypes() { return default(System.Type[]); }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class MultiViewDesigner : System.Web.UI.Design.ContainerControlDesigner {
    public MultiViewDesigner() { }
    protected override bool NoWrap { get { return default(bool); } }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class ObjectDataSourceDesigner : System.Web.UI.Design.DataSourceDesigner {
    public ObjectDataSourceDesigner() { }
    public override bool CanConfigure { get { return default(bool); } }
    public override bool CanRefreshSchema { get { return default(bool); } }
    public string SelectMethod { get { return default(string); } set { } }
    public string TypeName { get { return default(string); } set { } }
    public override void Configure() { }
    public override System.Web.UI.Design.DesignerDataSourceView GetView(string viewName) { return default(System.Web.UI.Design.DesignerDataSourceView); }
    public override System.String[] GetViewNames() { return default(System.String[]); }
    protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
    public override void RefreshSchema(bool preferSilent) { }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class ObjectDesignerDataSourceView : System.Web.UI.Design.DesignerDataSourceView {
    public ObjectDesignerDataSourceView(System.Web.UI.Design.WebControls.ObjectDataSourceDesigner owner, string viewName) : base (default(System.Web.UI.Design.IDataSourceDesigner), default(string)) { }
    public override bool CanDelete { get { return default(bool); } }
    public override bool CanInsert { get { return default(bool); } }
    public override bool CanPage { get { return default(bool); } }
    public override bool CanRetrieveTotalRowCount { get { return default(bool); } }
    public override bool CanSort { get { return default(bool); } }
    public override bool CanUpdate { get { return default(bool); } }
    public override System.Web.UI.Design.IDataSourceViewSchema Schema { get { return default(System.Web.UI.Design.IDataSourceViewSchema); } }
    public override System.Collections.IEnumerable GetDesignTimeData(int minimumRows, out bool isSampleData) { isSampleData = default(bool); return default(System.Collections.IEnumerable); }
  }
  public partial class PanelContainerDesigner : System.Web.UI.Design.ContainerControlDesigner {
    public PanelContainerDesigner() { }
    public override string FrameCaption { get { return default(string); } }
    public override System.Web.UI.WebControls.Style FrameStyle { get { return default(System.Web.UI.WebControls.Style); } }
    protected override bool UsePreviewControl { get { return default(bool); } }
    protected override void AddDesignTimeCssAttributes(System.Collections.IDictionary styleAttributes) { }
    public override void Initialize(System.ComponentModel.IComponent component) { }
  }
  [System.ObsoleteAttribute("The recommended alternative is PanelContainerDesigner because it uses an EditableDesignerRegion for editing the content. Designer regions allow for better control of the content being edited. http://go.microsoft.com/fwlink/?linkid=14202")]
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class PanelDesigner : System.Web.UI.Design.ReadWriteControlDesigner {
    public PanelDesigner() { }
    protected override void MapPropertyToStyle(string propName, object varPropValue) { }
    [System.ObsoleteAttribute("The recommended alternative is ControlDesigner.Tag. http://go.microsoft.com/fwlink/?linkid=14202")]
    protected override void OnBehaviorAttached() { }
  }
  public partial class ParameterCollectionEditor : System.Drawing.Design.UITypeEditor {
    public ParameterCollectionEditor() { }
    public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { return default(object); }
    public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { return default(System.Drawing.Design.UITypeEditorEditStyle); }
  }
  public partial class ParameterEditorUserControl : System.Windows.Forms.UserControl {
    public ParameterEditorUserControl(System.IServiceProvider serviceProvider) { }
    public bool ParametersConfigured { get { return default(bool); } }
    public System.ComponentModel.TypeDescriptionProvider TypeDescriptionProvider { get { return default(System.ComponentModel.TypeDescriptionProvider); } }
    public event System.EventHandler ParametersChanged { add { } remove { } }
    public void AddParameters(System.Web.UI.WebControls.Parameter[] parameters) { }
    public void ClearParameters() { }
    public System.Web.UI.WebControls.Parameter[] GetParameters() { return default(System.Web.UI.WebControls.Parameter[]); }
    protected virtual void OnParametersChanged(object sender, System.EventArgs e) { }
    public void SetAllowCollectionChanges(bool allowChanges) { }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class PasswordRecoveryDesigner : System.Web.UI.Design.ControlDesigner {
    public PasswordRecoveryDesigner() { }
    public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { return default(System.ComponentModel.Design.DesignerActionListCollection); } }
    public override bool AllowResize { get { return default(bool); } }
    public override System.Web.UI.Design.DesignerAutoFormatCollection AutoFormats { get { return default(System.Web.UI.Design.DesignerAutoFormatCollection); } }
    public bool RenderOuterTable { get { return default(bool); } set { } }
    public override System.Web.UI.Design.TemplateGroupCollection TemplateGroups { get { return default(System.Web.UI.Design.TemplateGroupCollection); } }
    protected override bool UsePreviewControl { get { return default(bool); } }
    public override string GetDesignTimeHtml() { return default(string); }
    public override string GetDesignTimeHtml(System.Web.UI.Design.DesignerRegionCollection regions) { return default(string); }
    public override string GetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region) { return default(string); }
    protected override string GetErrorDesignTimeHtml(System.Exception e) { return default(string); }
    public override void Initialize(System.ComponentModel.IComponent component) { }
    protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
    public override void SetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region, string content) { }
  }
  [System.Web.UI.Design.SupportsPreviewControlAttribute(true)]
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class PreviewControlDesigner : System.Web.UI.Design.ControlDesigner {
    public PreviewControlDesigner() { }
    protected override bool UsePreviewControl { get { return default(bool); } }
  }
  [System.ComponentModel.ToolboxItemAttribute(false)]
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class RegexEditorDialog : System.Windows.Forms.Form {
    public RegexEditorDialog(System.ComponentModel.ISite site) { }
    public string RegularExpression { get { return default(string); } set { } }
    protected void cmdHelp_Click(object sender, System.EventArgs e) { }
    protected void cmdOK_Click(object sender, System.EventArgs e) { }
    protected void cmdTestValidate_Click(object sender, System.EventArgs args) { }
    protected override void Dispose(bool disposing) { }
    protected void lstStandardExpressions_SelectedIndexChanged(object sender, System.EventArgs e) { }
    protected void RegexTypeEditor_Activated(object sender, System.EventArgs e) { }
    protected void txtExpression_TextChanged(object sender, System.EventArgs e) { }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class RegexTypeEditor : System.Drawing.Design.UITypeEditor {
    public RegexTypeEditor() { }
    public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { return default(object); }
    public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { return default(System.Drawing.Design.UITypeEditorEditStyle); }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class RepeaterDesigner : System.Web.UI.Design.ControlDesigner, System.Web.UI.Design.IDataSourceProvider {
    public RepeaterDesigner() { }
    public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { return default(System.ComponentModel.Design.DesignerActionListCollection); } }
    public string DataMember { get { return default(string); } set { } }
    public string DataSource { get { return default(string); } set { } }
    public System.Web.UI.Design.IDataSourceDesigner DataSourceDesigner { get { return default(System.Web.UI.Design.IDataSourceDesigner); } }
    public string DataSourceID { get { return default(string); } set { } }
    public System.Web.UI.Design.DesignerDataSourceView DesignerView { get { return default(System.Web.UI.Design.DesignerDataSourceView); } }
    protected bool TemplatesExist { get { return default(bool); } }
    protected override void Dispose(bool disposing) { }
    protected virtual void ExecuteChooseDataSourcePostSteps() { }
    protected System.Collections.IEnumerable GetDesignTimeDataSource(System.Collections.IEnumerable selectedDataSource, int minimumRows) { return default(System.Collections.IEnumerable); }
    protected System.Collections.IEnumerable GetDesignTimeDataSource(int minimumRows) { return default(System.Collections.IEnumerable); }
    public override string GetDesignTimeHtml() { return default(string); }
    protected override string GetEmptyDesignTimeHtml() { return default(string); }
    protected override string GetErrorDesignTimeHtml(System.Exception e) { return default(string); }
    public System.Collections.IEnumerable GetResolvedSelectedDataSource() { return default(System.Collections.IEnumerable); }
    public object GetSelectedDataSource() { return default(object); }
    public override void Initialize(System.ComponentModel.IComponent component) { }
    public override void OnComponentChanged(object source, System.ComponentModel.Design.ComponentChangedEventArgs ce) { }
    public virtual void OnDataSourceChanged() { }
    protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class RoleGroupCollectionEditor : System.ComponentModel.Design.CollectionEditor {
    public RoleGroupCollectionEditor(System.Type type) : base (default(System.Type)) { }
    protected override bool CanSelectMultipleInstances() { return default(bool); }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class SiteMapDataSourceDesigner : System.Web.UI.Design.HierarchicalDataSourceDesigner, System.Web.UI.Design.IDataSourceDesigner {
    public SiteMapDataSourceDesigner() { }
    public override bool CanRefreshSchema { get { return default(bool); } }
    bool System.Web.UI.Design.IDataSourceDesigner.CanConfigure { get { return default(bool); } }
    bool System.Web.UI.Design.IDataSourceDesigner.CanRefreshSchema { get { return default(bool); } }
    event System.EventHandler System.Web.UI.Design.IDataSourceDesigner.DataSourceChanged { add { } remove { } }
    event System.EventHandler System.Web.UI.Design.IDataSourceDesigner.SchemaRefreshed { add { } remove { } }
    public override System.Web.UI.Design.DesignerHierarchicalDataSourceView GetView(string viewPath) { return default(System.Web.UI.Design.DesignerHierarchicalDataSourceView); }
    public virtual System.String[] GetViewNames() { return default(System.String[]); }
    public override void Initialize(System.ComponentModel.IComponent component) { }
    public override void OnComponentChanged(object sender, System.ComponentModel.Design.ComponentChangedEventArgs e) { }
    public override void RefreshSchema(bool preferSilent) { }
    void System.Web.UI.Design.IDataSourceDesigner.Configure() { }
    System.Web.UI.Design.DesignerDataSourceView System.Web.UI.Design.IDataSourceDesigner.GetView(string viewName) { return default(System.Web.UI.Design.DesignerDataSourceView); }
    System.String[] System.Web.UI.Design.IDataSourceDesigner.GetViewNames() { return default(System.String[]); }
    void System.Web.UI.Design.IDataSourceDesigner.RefreshSchema(bool preferSilent) { }
    void System.Web.UI.Design.IDataSourceDesigner.ResumeDataSourceEvents() { }
    void System.Web.UI.Design.IDataSourceDesigner.SuppressDataSourceEvents() { }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class SiteMapDesignerDataSourceView : System.Web.UI.Design.DesignerDataSourceView {
    public SiteMapDesignerDataSourceView(System.Web.UI.Design.WebControls.SiteMapDataSourceDesigner owner, string viewName) : base (default(System.Web.UI.Design.IDataSourceDesigner), default(string)) { }
    public override System.Web.UI.Design.IDataSourceViewSchema Schema { get { return default(System.Web.UI.Design.IDataSourceViewSchema); } }
    public override System.Collections.IEnumerable GetDesignTimeData(int minimumRows, out bool isSampleData) { isSampleData = default(bool); return default(System.Collections.IEnumerable); }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class SiteMapDesignerHierarchicalDataSourceView : System.Web.UI.Design.DesignerHierarchicalDataSourceView {
    public SiteMapDesignerHierarchicalDataSourceView(System.Web.UI.Design.WebControls.SiteMapDataSourceDesigner owner, string viewPath) : base (default(System.Web.UI.Design.IHierarchicalDataSourceDesigner), default(string)) { }
    public override System.Web.UI.Design.IDataSourceSchema Schema { get { return default(System.Web.UI.Design.IDataSourceSchema); } }
    public override System.Web.UI.IHierarchicalEnumerable GetDesignTimeData(out bool isSampleData) { isSampleData = default(bool); return default(System.Web.UI.IHierarchicalEnumerable); }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class SiteMapPathDesigner : System.Web.UI.Design.ControlDesigner {
    public SiteMapPathDesigner() { }
    public override System.Web.UI.Design.DesignerAutoFormatCollection AutoFormats { get { return default(System.Web.UI.Design.DesignerAutoFormatCollection); } }
    public override System.Web.UI.Design.TemplateGroupCollection TemplateGroups { get { return default(System.Web.UI.Design.TemplateGroupCollection); } }
    protected override bool UsePreviewControl { get { return default(bool); } }
    public override string GetDesignTimeHtml() { return default(string); }
    protected override string GetErrorDesignTimeHtml(System.Exception e) { return default(string); }
    public override void Initialize(System.ComponentModel.IComponent component) { }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class SqlDataSourceConnectionStringEditor : System.Web.UI.Design.ConnectionStringEditor {
    public SqlDataSourceConnectionStringEditor() { }
    protected override string GetProviderName(object instance) { return default(string); }
    protected override void SetProviderName(object instance, System.ComponentModel.Design.Data.DesignerDataConnection connection) { }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class SqlDataSourceDesigner : System.Web.UI.Design.DataSourceDesigner {
    public SqlDataSourceDesigner() { }
    public override bool CanConfigure { get { return default(bool); } }
    public override bool CanRefreshSchema { get { return default(bool); } }
    public string ConnectionString { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataSourceOperation)(0))]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorAttribute(typeof(System.Web.UI.Design.WebControls.SqlDataSourceQueryEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.Design.WebControls.SqlDataSourceQueryConverter))]
    [System.Design.SRDescriptionAttribute("SqlDataSourceDesigner_DeleteQuery")]
    public System.Web.UI.DataSourceOperation DeleteQuery { get { return default(System.Web.UI.DataSourceOperation); } set { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataSourceOperation)(1))]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorAttribute(typeof(System.Web.UI.Design.WebControls.SqlDataSourceQueryEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.Design.WebControls.SqlDataSourceQueryConverter))]
    [System.Design.SRDescriptionAttribute("SqlDataSourceDesigner_InsertQuery")]
    public System.Web.UI.DataSourceOperation InsertQuery { get { return default(System.Web.UI.DataSourceOperation); } set { } }
    public string ProviderName { get { return default(string); } set { } }
    public string SelectCommand { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataSourceOperation)(2))]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorAttribute(typeof(System.Web.UI.Design.WebControls.SqlDataSourceQueryEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.Design.WebControls.SqlDataSourceQueryConverter))]
    [System.Design.SRDescriptionAttribute("SqlDataSourceDesigner_SelectQuery")]
    public System.Web.UI.DataSourceOperation SelectQuery { get { return default(System.Web.UI.DataSourceOperation); } set { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataSourceOperation)(3))]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorAttribute(typeof(System.Web.UI.Design.WebControls.SqlDataSourceQueryEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.Design.WebControls.SqlDataSourceQueryConverter))]
    [System.Design.SRDescriptionAttribute("SqlDataSourceDesigner_UpdateQuery")]
    public System.Web.UI.DataSourceOperation UpdateQuery { get { return default(System.Web.UI.DataSourceOperation); } set { } }
    public override void Configure() { }
    protected virtual System.Web.UI.Design.WebControls.SqlDesignerDataSourceView CreateView(string viewName) { return default(System.Web.UI.Design.WebControls.SqlDesignerDataSourceView); }
    protected virtual void DeriveParameters(string providerName, System.Data.Common.DbCommand command) { }
    protected virtual string GetConnectionString() { return default(string); }
    public override System.Web.UI.Design.DesignerDataSourceView GetView(string viewName) { return default(System.Web.UI.Design.DesignerDataSourceView); }
    public override System.String[] GetViewNames() { return default(System.String[]); }
    protected internal virtual System.Web.UI.WebControls.Parameter[] InferParameterNames(System.ComponentModel.Design.Data.DesignerDataConnection connection, string commandText, System.Web.UI.WebControls.SqlDataSourceCommandType commandType) { return default(System.Web.UI.WebControls.Parameter[]); }
    protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
    public override void RefreshSchema(bool preferSilent) { }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class SqlDesignerDataSourceView : System.Web.UI.Design.DesignerDataSourceView {
    public SqlDesignerDataSourceView(System.Web.UI.Design.WebControls.SqlDataSourceDesigner owner, string viewName) : base (default(System.Web.UI.Design.IDataSourceDesigner), default(string)) { }
    public override bool CanDelete { get { return default(bool); } }
    public override bool CanInsert { get { return default(bool); } }
    public override bool CanPage { get { return default(bool); } }
    public override bool CanRetrieveTotalRowCount { get { return default(bool); } }
    public override bool CanSort { get { return default(bool); } }
    public override bool CanUpdate { get { return default(bool); } }
    public override System.Web.UI.Design.IDataSourceViewSchema Schema { get { return default(System.Web.UI.Design.IDataSourceViewSchema); } }
    public override System.Collections.IEnumerable GetDesignTimeData(int minimumRows, out bool isSampleData) { isSampleData = default(bool); return default(System.Collections.IEnumerable); }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class StyleCollectionEditor : System.ComponentModel.Design.CollectionEditor {
    public StyleCollectionEditor(System.Type type) : base (default(System.Type)) { }
    protected override object CreateInstance(System.Type itemType) { return default(object); }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class SubMenuStyleCollectionEditor : System.ComponentModel.Design.CollectionEditor {
    public SubMenuStyleCollectionEditor(System.Type type) : base (default(System.Type)) { }
    protected override bool CanSelectMultipleInstances() { return default(bool); }
    protected override System.ComponentModel.Design.CollectionEditor.CollectionForm CreateCollectionForm() { return default(System.ComponentModel.Design.CollectionEditor.CollectionForm); }
    protected override object CreateInstance(System.Type itemType) { return default(object); }
    protected override System.Type[] CreateNewItemTypes() { return default(System.Type[]); }
  }
  [System.Web.UI.Design.SupportsPreviewControlAttribute(true)]
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class SubstitutionDesigner : System.Web.UI.Design.ControlDesigner {
    public SubstitutionDesigner() { }
    public override string GetDesignTimeHtml() { return default(string); }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class TableCellsCollectionEditor : System.ComponentModel.Design.CollectionEditor {
    public TableCellsCollectionEditor(System.Type type) : base (default(System.Type)) { }
    protected override bool CanSelectMultipleInstances() { return default(bool); }
    protected override object CreateInstance(System.Type itemType) { return default(object); }
  }
  [System.Web.UI.Design.SupportsPreviewControlAttribute(true)]
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class TableDesigner : System.Web.UI.Design.ControlDesigner {
    public TableDesigner() { }
    public override string GetDesignTimeHtml() { return default(string); }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class TableRowsCollectionEditor : System.ComponentModel.Design.CollectionEditor {
    public TableRowsCollectionEditor(System.Type type) : base (default(System.Type)) { }
    protected override bool CanSelectMultipleInstances() { return default(bool); }
    protected override object CreateInstance(System.Type itemType) { return default(object); }
  }
  public partial class TreeNodeBindingDepthConverter : System.ComponentModel.Int32Converter {
    public TreeNodeBindingDepthConverter() { }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
  }
  public partial class TreeNodeCollectionEditor : System.Drawing.Design.UITypeEditor {
    public TreeNodeCollectionEditor() { }
    public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { return default(object); }
    public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { return default(System.Drawing.Design.UITypeEditorEditStyle); }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class TreeNodeStyleCollectionEditor : System.Web.UI.Design.WebControls.StyleCollectionEditor {
    public TreeNodeStyleCollectionEditor(System.Type type) : base (default(System.Type)) { }
    protected override System.Type CreateCollectionItemType() { return default(System.Type); }
  }
  public partial class TreeViewBindingsEditor : System.Drawing.Design.UITypeEditor {
    public TreeViewBindingsEditor() { }
    public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { return default(object); }
    public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { return default(System.Drawing.Design.UITypeEditorEditStyle); }
  }
  public partial class TreeViewDesigner : System.Web.UI.Design.WebControls.HierarchicalDataBoundControlDesigner {
    public TreeViewDesigner() { }
    public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { return default(System.ComponentModel.Design.DesignerActionListCollection); } }
    public override System.Web.UI.Design.DesignerAutoFormatCollection AutoFormats { get { return default(System.Web.UI.Design.DesignerAutoFormatCollection); } }
    protected override bool UsePreviewControl { get { return default(bool); } }
    protected void CreateLineImages() { }
    protected override void DataBind(System.Web.UI.WebControls.BaseDataBoundControl dataBoundControl) { }
    protected void EditBindings() { }
    protected void EditNodes() { }
    public override string GetDesignTimeHtml() { return default(string); }
    protected override string GetEmptyDesignTimeHtml() { return default(string); }
    protected override string GetErrorDesignTimeHtml(System.Exception e) { return default(string); }
    protected override System.Web.UI.IHierarchicalEnumerable GetSampleDataSource() { return default(System.Web.UI.IHierarchicalEnumerable); }
    public override void Initialize(System.ComponentModel.IComponent component) { }
  }
  [System.Web.UI.Design.SupportsPreviewControlAttribute(true)]
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class ValidationSummaryDesigner : System.Web.UI.Design.WebControls.PreviewControlDesigner {
    public ValidationSummaryDesigner() { }
    protected override System.Web.UI.Control CreateViewControl() { return default(System.Web.UI.Control); }
    protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class ViewDesigner : System.Web.UI.Design.ContainerControlDesigner {
    public ViewDesigner() { }
    protected override bool NoWrap { get { return default(bool); } }
    public override string GetDesignTimeHtml() { return default(string); }
    public override string GetDesignTimeHtml(System.Web.UI.Design.DesignerRegionCollection regions) { return default(string); }
    public override void Initialize(System.ComponentModel.IComponent component) { }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class WizardDesigner : System.Web.UI.Design.WebControls.CompositeControlDesigner {
    public WizardDesigner() { }
    public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { return default(System.ComponentModel.Design.DesignerActionListCollection); } }
    public override System.Web.UI.Design.DesignerAutoFormatCollection AutoFormats { get { return default(System.Web.UI.Design.DesignerAutoFormatCollection); } }
    protected bool DisplaySideBar { get { return default(bool); } set { } }
    public override System.Web.UI.Design.TemplateGroupCollection TemplateGroups { get { return default(System.Web.UI.Design.TemplateGroupCollection); } }
    protected override bool UsePreviewControl { get { return default(bool); } }
    protected virtual void AddDesignerRegions(System.Web.UI.Design.DesignerRegionCollection regions) { }
    protected virtual void ConvertToCustomNavigationTemplate() { }
    protected void ConvertToTemplate(string description, System.ComponentModel.IComponent component, string templateName, System.String[] keys) { }
    protected override void CreateChildControls() { }
    public override string GetDesignTimeHtml() { return default(string); }
    public override string GetDesignTimeHtml(System.Web.UI.Design.DesignerRegionCollection regions) { return default(string); }
    public override string GetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region) { return default(string); }
    public override void Initialize(System.ComponentModel.IComponent component) { }
    protected override void OnClick(System.Web.UI.Design.DesignerRegionMouseEventArgs e) { }
    public override void OnComponentChanged(object sender, System.ComponentModel.Design.ComponentChangedEventArgs ce) { }
    protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
    protected void ResetTemplate(string description, System.ComponentModel.IComponent component, string templateName) { }
    public override void SetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region, string content) { }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class WizardStepCollectionEditor : System.ComponentModel.Design.CollectionEditor {
    public WizardStepCollectionEditor(System.Type type) : base (default(System.Type)) { }
    protected override bool CanSelectMultipleInstances() { return default(bool); }
    protected override System.ComponentModel.Design.CollectionEditor.CollectionForm CreateCollectionForm() { return default(System.ComponentModel.Design.CollectionEditor.CollectionForm); }
    protected override object CreateInstance(System.Type itemType) { return default(object); }
    protected override System.Type[] CreateNewItemTypes() { return default(System.Type[]); }
  }
  public partial class WizardStepEditableRegion : System.Web.UI.Design.EditableDesignerRegion {
    public WizardStepEditableRegion(System.Web.UI.Design.WebControls.WizardDesigner designer, System.Web.UI.WebControls.WizardStepBase wizardStep) : base (default(System.Web.UI.Design.ControlDesigner), default(string)) { }
    public System.Web.UI.WebControls.WizardStepBase Step { get { return default(System.Web.UI.WebControls.WizardStepBase); } }
  }
  public partial class WizardStepTemplatedEditableRegion : System.Web.UI.Design.TemplatedEditableDesignerRegion {
    public WizardStepTemplatedEditableRegion(System.Web.UI.Design.TemplateDefinition templateDefinition, System.Web.UI.WebControls.WizardStepBase wizardStep) : base (default(System.Web.UI.Design.TemplateDefinition)) { }
    public System.Web.UI.WebControls.WizardStepBase Step { get { return default(System.Web.UI.WebControls.WizardStepBase); } }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class XmlDataSourceDesigner : System.Web.UI.Design.HierarchicalDataSourceDesigner, System.Web.UI.Design.IDataSourceDesigner {
    public XmlDataSourceDesigner() { }
    public override bool CanConfigure { get { return default(bool); } }
    public override bool CanRefreshSchema { get { return default(bool); } }
    public string Data { get { return default(string); } set { } }
    public string DataFile { get { return default(string); } set { } }
    bool System.Web.UI.Design.IDataSourceDesigner.CanConfigure { get { return default(bool); } }
    bool System.Web.UI.Design.IDataSourceDesigner.CanRefreshSchema { get { return default(bool); } }
    public string Transform { get { return default(string); } set { } }
    public string TransformFile { get { return default(string); } set { } }
    public string XPath { get { return default(string); } set { } }
    event System.EventHandler System.Web.UI.Design.IDataSourceDesigner.DataSourceChanged { add { } remove { } }
    event System.EventHandler System.Web.UI.Design.IDataSourceDesigner.SchemaRefreshed { add { } remove { } }
    public override void Configure() { }
    public override System.Web.UI.Design.DesignerHierarchicalDataSourceView GetView(string viewPath) { return default(System.Web.UI.Design.DesignerHierarchicalDataSourceView); }
    public override void Initialize(System.ComponentModel.IComponent component) { }
    protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
    public override void RefreshSchema(bool preferSilent) { }
    void System.Web.UI.Design.IDataSourceDesigner.Configure() { }
    System.Web.UI.Design.DesignerDataSourceView System.Web.UI.Design.IDataSourceDesigner.GetView(string viewName) { return default(System.Web.UI.Design.DesignerDataSourceView); }
    System.String[] System.Web.UI.Design.IDataSourceDesigner.GetViewNames() { return default(System.String[]); }
    void System.Web.UI.Design.IDataSourceDesigner.RefreshSchema(bool preferSilent) { }
    void System.Web.UI.Design.IDataSourceDesigner.ResumeDataSourceEvents() { }
    void System.Web.UI.Design.IDataSourceDesigner.SuppressDataSourceEvents() { }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class XmlDesigner : System.Web.UI.Design.ControlDesigner {
    public XmlDesigner() { }
    protected override void Dispose(bool disposing) { }
    public override string GetDesignTimeHtml() { return default(string); }
    protected override string GetEmptyDesignTimeHtml() { return default(string); }
    public override void Initialize(System.ComponentModel.IComponent component) { }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class XmlDesignerDataSourceView : System.Web.UI.Design.DesignerDataSourceView {
    public XmlDesignerDataSourceView(System.Web.UI.Design.WebControls.XmlDataSourceDesigner owner, string viewName) : base (default(System.Web.UI.Design.IDataSourceDesigner), default(string)) { }
    public override System.Web.UI.Design.IDataSourceViewSchema Schema { get { return default(System.Web.UI.Design.IDataSourceViewSchema); } }
    public override System.Collections.IEnumerable GetDesignTimeData(int minimumRows, out bool isSampleData) { isSampleData = default(bool); return default(System.Collections.IEnumerable); }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class XmlDesignerHierarchicalDataSourceView : System.Web.UI.Design.DesignerHierarchicalDataSourceView {
    public XmlDesignerHierarchicalDataSourceView(System.Web.UI.Design.WebControls.XmlDataSourceDesigner owner, string viewPath) : base (default(System.Web.UI.Design.IHierarchicalDataSourceDesigner), default(string)) { }
    public override System.Web.UI.Design.IDataSourceSchema Schema { get { return default(System.Web.UI.Design.IDataSourceSchema); } }
    public override System.Web.UI.IHierarchicalEnumerable GetDesignTimeData(out bool isSampleData) { isSampleData = default(bool); return default(System.Web.UI.IHierarchicalEnumerable); }
  }
}
namespace System.Web.UI.Design.WebControls.WebParts {
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class CatalogPartDesigner : System.Web.UI.Design.WebControls.WebParts.PartDesigner {
    public CatalogPartDesigner() { }
    protected override System.Web.UI.Control CreateViewControl() { return default(System.Web.UI.Control); }
    public override string GetDesignTimeHtml() { return default(string); }
    public override void Initialize(System.ComponentModel.IComponent component) { }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class CatalogZoneDesigner : System.Web.UI.Design.WebControls.WebParts.ToolZoneDesigner {
    public CatalogZoneDesigner() { }
    public override System.Web.UI.Design.DesignerAutoFormatCollection AutoFormats { get { return default(System.Web.UI.Design.DesignerAutoFormatCollection); } }
    public override System.Web.UI.Design.TemplateGroupCollection TemplateGroups { get { return default(System.Web.UI.Design.TemplateGroupCollection); } }
    public override string GetDesignTimeHtml() { return default(string); }
    public override string GetDesignTimeHtml(System.Web.UI.Design.DesignerRegionCollection regions) { return default(string); }
    public override string GetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region) { return default(string); }
    protected override string GetEmptyDesignTimeHtml() { return default(string); }
    public override void Initialize(System.ComponentModel.IComponent component) { }
    public override void SetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region, string content) { }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class ConnectionsZoneDesigner : System.Web.UI.Design.WebControls.WebParts.ToolZoneDesigner {
    public ConnectionsZoneDesigner() { }
    public override System.Web.UI.Design.DesignerAutoFormatCollection AutoFormats { get { return default(System.Web.UI.Design.DesignerAutoFormatCollection); } }
    public override string GetDesignTimeHtml() { return default(string); }
    public override void Initialize(System.ComponentModel.IComponent component) { }
    protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class DeclarativeCatalogPartDesigner : System.Web.UI.Design.WebControls.WebParts.CatalogPartDesigner {
    public DeclarativeCatalogPartDesigner() { }
    public override System.Web.UI.Design.TemplateGroupCollection TemplateGroups { get { return default(System.Web.UI.Design.TemplateGroupCollection); } }
    public override string GetDesignTimeHtml() { return default(string); }
    protected override string GetEmptyDesignTimeHtml() { return default(string); }
    public override void Initialize(System.ComponentModel.IComponent component) { }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class EditorPartDesigner : System.Web.UI.Design.WebControls.WebParts.PartDesigner {
    public EditorPartDesigner() { }
    protected override System.Web.UI.Control CreateViewControl() { return default(System.Web.UI.Control); }
    public override string GetDesignTimeHtml() { return default(string); }
    public override void Initialize(System.ComponentModel.IComponent component) { }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class EditorZoneDesigner : System.Web.UI.Design.WebControls.WebParts.ToolZoneDesigner {
    public EditorZoneDesigner() { }
    public override System.Web.UI.Design.DesignerAutoFormatCollection AutoFormats { get { return default(System.Web.UI.Design.DesignerAutoFormatCollection); } }
    public override System.Web.UI.Design.TemplateGroupCollection TemplateGroups { get { return default(System.Web.UI.Design.TemplateGroupCollection); } }
    public override string GetDesignTimeHtml() { return default(string); }
    public override string GetDesignTimeHtml(System.Web.UI.Design.DesignerRegionCollection regions) { return default(string); }
    public override string GetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region) { return default(string); }
    protected override string GetEmptyDesignTimeHtml() { return default(string); }
    public override void Initialize(System.ComponentModel.IComponent component) { }
    public override void SetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region, string content) { }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class PageCatalogPartDesigner : System.Web.UI.Design.WebControls.WebParts.CatalogPartDesigner {
    public PageCatalogPartDesigner() { }
    public override string GetDesignTimeHtml() { return default(string); }
    public override void Initialize(System.ComponentModel.IComponent component) { }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public abstract partial class PartDesigner : System.Web.UI.Design.WebControls.CompositeControlDesigner {
    internal PartDesigner() { }
    protected override bool UsePreviewControl { get { return default(bool); } }
    public override void Initialize(System.ComponentModel.IComponent component) { }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class ProxyWebPartManagerDesigner : System.Web.UI.Design.ControlDesigner {
    public ProxyWebPartManagerDesigner() { }
    protected override bool UsePreviewControl { get { return default(bool); } }
    public override string GetDesignTimeHtml() { return default(string); }
    public override void Initialize(System.ComponentModel.IComponent component) { }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class ToolZoneDesigner : System.Web.UI.Design.WebControls.WebParts.WebZoneDesigner {
    public ToolZoneDesigner() { }
    public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { return default(System.ComponentModel.Design.DesignerActionListCollection); } }
    protected bool ViewInBrowseMode { get { return default(bool); } }
    public override void Initialize(System.ComponentModel.IComponent component) { }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class WebPartDesigner : System.Web.UI.Design.WebControls.WebParts.PartDesigner {
    public WebPartDesigner() { }
    public override void Initialize(System.ComponentModel.IComponent component) { }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class WebPartManagerDesigner : System.Web.UI.Design.ControlDesigner {
    public WebPartManagerDesigner() { }
    protected override bool UsePreviewControl { get { return default(bool); } }
    public override string GetDesignTimeHtml() { return default(string); }
    public override void Initialize(System.ComponentModel.IComponent component) { }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class WebPartZoneBaseDesigner : System.Web.UI.Design.WebControls.WebParts.WebZoneDesigner {
    public WebPartZoneBaseDesigner() { }
    public override void Initialize(System.ComponentModel.IComponent component) { }
    protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class WebPartZoneDesigner : System.Web.UI.Design.WebControls.WebParts.WebPartZoneBaseDesigner {
    public WebPartZoneDesigner() { }
    public override System.Web.UI.Design.DesignerAutoFormatCollection AutoFormats { get { return default(System.Web.UI.Design.DesignerAutoFormatCollection); } }
    public override System.Web.UI.Design.TemplateGroupCollection TemplateGroups { get { return default(System.Web.UI.Design.TemplateGroupCollection); } }
    public override string GetDesignTimeHtml() { return default(string); }
    public override string GetDesignTimeHtml(System.Web.UI.Design.DesignerRegionCollection regions) { return default(string); }
    public override string GetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region) { return default(string); }
    protected override string GetEmptyDesignTimeHtml() { return default(string); }
    public override void Initialize(System.ComponentModel.IComponent component) { }
    public override void SetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region, string content) { }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public abstract partial class WebZoneDesigner : System.Web.UI.Design.ControlDesigner {
    internal WebZoneDesigner() { }
    protected override bool UsePreviewControl { get { return default(bool); } }
    public override void Initialize(System.ComponentModel.IComponent component) { }
  }
}
namespace System.Windows.Forms.Design {
  public sealed partial class AnchorEditor : System.Drawing.Design.UITypeEditor {
    public AnchorEditor() { }
    public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { return default(object); }
    public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { return default(System.Drawing.Design.UITypeEditorEditStyle); }
  }
  public partial class AxImporter {
    public AxImporter(System.Windows.Forms.Design.AxImporter.Options options) { }
    public System.String[] GeneratedAssemblies { get { return default(System.String[]); } }
    public System.String[] GeneratedSources { get { return default(System.String[]); } }
    public System.Runtime.InteropServices.TYPELIBATTR[] GeneratedTypeLibAttributes { get { return default(System.Runtime.InteropServices.TYPELIBATTR[]); } }
    public string GenerateFromFile(System.IO.FileInfo file) { return default(string); }
    public string GenerateFromTypeLibrary(System.Runtime.InteropServices.UCOMITypeLib typeLib) { return default(string); }
    public string GenerateFromTypeLibrary(System.Runtime.InteropServices.UCOMITypeLib typeLib, System.Guid clsid) { return default(string); }
    public static string GetFileOfTypeLib(ref System.Runtime.InteropServices.TYPELIBATTR tlibattr) { return default(string); }
    public partial interface IReferenceResolver {
      string ResolveActiveXReference(System.Runtime.InteropServices.UCOMITypeLib typeLib);
      string ResolveComReference(System.Reflection.AssemblyName name);
      string ResolveComReference(System.Runtime.InteropServices.UCOMITypeLib typeLib);
      string ResolveManagedReference(string assemName);
    }
    public sealed partial class Options {
      public bool delaySign;
      public bool genSources;
      public bool ignoreRegisteredOcx;
      public string keyContainer;
      public string keyFile;
      public System.Reflection.StrongNameKeyPair keyPair;
      public bool msBuildErrors;
      public bool noLogo;
      public string outputDirectory;
      public string outputName;
      public bool overwriteRCW;
      public System.Byte[] publicKey;
      public System.Windows.Forms.Design.AxImporter.IReferenceResolver references;
      public bool silentMode;
      public bool verboseMode;
      public Options() { }
    }
  }
  public partial class AxParameterData {
    public AxParameterData(System.Reflection.ParameterInfo info) { }
    public AxParameterData(System.Reflection.ParameterInfo info, bool ignoreByRefs) { }
    public AxParameterData(string inname, string typeName) { }
    public AxParameterData(string inname, System.Type type) { }
    public System.CodeDom.FieldDirection Direction { get { return default(System.CodeDom.FieldDirection); } }
    public bool IsByRef { get { return default(bool); } }
    public bool IsIn { get { return default(bool); } }
    public bool IsOptional { get { return default(bool); } }
    public bool IsOut { get { return default(bool); } }
    public string Name { get { return default(string); } set { } }
    public System.Type ParameterType { get { return default(System.Type); } }
    public string TypeName { get { return default(string); } }
    public static System.Windows.Forms.Design.AxParameterData[] Convert(System.Reflection.ParameterInfo[] infos) { return default(System.Windows.Forms.Design.AxParameterData[]); }
    public static System.Windows.Forms.Design.AxParameterData[] Convert(System.Reflection.ParameterInfo[] infos, bool ignoreByRefs) { return default(System.Windows.Forms.Design.AxParameterData[]); }
  }
  public partial class AxWrapperGen {
    public static System.Collections.ArrayList GeneratedSources;
    public AxWrapperGen(System.Type axType) { }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class BorderSidesEditor : System.Drawing.Design.UITypeEditor {
    public BorderSidesEditor() { }
    public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { return default(object); }
    public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { return default(System.Drawing.Design.UITypeEditorEditStyle); }
  }
  public partial class ComponentDocumentDesigner : System.ComponentModel.Design.ComponentDesigner, System.ComponentModel.Design.IDesigner, System.ComponentModel.Design.IRootDesigner, System.ComponentModel.Design.ITypeDescriptorFilterService, System.Drawing.Design.IToolboxUser, System.IDisposable {
    public ComponentDocumentDesigner() { }
    public System.Windows.Forms.Control Control { get { return default(System.Windows.Forms.Control); } }
    System.ComponentModel.Design.ViewTechnology[] System.ComponentModel.Design.IRootDesigner.SupportedTechnologies { get { return default(System.ComponentModel.Design.ViewTechnology[]); } }
    public bool TrayAutoArrange { get { return default(bool); } set { } }
    public bool TrayLargeIcon { get { return default(bool); } set { } }
    protected override void Dispose(bool disposing) { }
    protected virtual bool GetToolSupported(System.Drawing.Design.ToolboxItem tool) { return default(bool); }
    public override void Initialize(System.ComponentModel.IComponent component) { }
    protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
    object System.ComponentModel.Design.IRootDesigner.GetView(System.ComponentModel.Design.ViewTechnology technology) { return default(object); }
    bool System.ComponentModel.Design.ITypeDescriptorFilterService.FilterAttributes(System.ComponentModel.IComponent component, System.Collections.IDictionary attributes) { return default(bool); }
    bool System.ComponentModel.Design.ITypeDescriptorFilterService.FilterEvents(System.ComponentModel.IComponent component, System.Collections.IDictionary events) { return default(bool); }
    bool System.ComponentModel.Design.ITypeDescriptorFilterService.FilterProperties(System.ComponentModel.IComponent component, System.Collections.IDictionary properties) { return default(bool); }
    bool System.Drawing.Design.IToolboxUser.GetToolSupported(System.Drawing.Design.ToolboxItem tool) { return default(bool); }
    void System.Drawing.Design.IToolboxUser.ToolPicked(System.Drawing.Design.ToolboxItem tool) { }
  }
  [System.ComponentModel.DesignTimeVisibleAttribute(false)]
  [System.ComponentModel.ProvidePropertyAttribute("Location", typeof(System.ComponentModel.IComponent))]
  [System.ComponentModel.ProvidePropertyAttribute("TrayLocation", typeof(System.ComponentModel.IComponent))]
  [System.ComponentModel.ToolboxItemAttribute(false)]
  public partial class ComponentTray : System.Windows.Forms.ScrollableControl, System.ComponentModel.IExtenderProvider {
    public ComponentTray(System.ComponentModel.Design.IDesigner mainDesigner, System.IServiceProvider serviceProvider) { }
    public bool AutoArrange { get { return default(bool); } set { } }
    public int ComponentCount { get { return default(int); } }
    public bool ShowLargeIcons { get { return default(bool); } set { } }
    public virtual void AddComponent(System.ComponentModel.IComponent component) { }
    protected virtual bool CanCreateComponentFromTool(System.Drawing.Design.ToolboxItem tool) { return default(bool); }
    protected virtual bool CanDisplayComponent(System.ComponentModel.IComponent component) { return default(bool); }
    public void CreateComponentFromTool(System.Drawing.Design.ToolboxItem tool) { }
    protected void DisplayError(System.Exception e) { }
    protected override void Dispose(bool disposing) { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.CategoryAttribute("Layout")]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.DesignOnlyAttribute(true)]
    [System.ComponentModel.LocalizableAttribute(false)]
    [System.Design.SRDescriptionAttribute("ControlLocationDescr")]
    public System.Drawing.Point GetLocation(System.ComponentModel.IComponent receiver) { return default(System.Drawing.Point); }
    public System.ComponentModel.IComponent GetNextComponent(System.ComponentModel.IComponent component, bool forward) { return default(System.ComponentModel.IComponent); }
    protected override object GetService(System.Type serviceType) { return default(object); }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.CategoryAttribute("Layout")]
    [System.ComponentModel.DesignOnlyAttribute(true)]
    [System.ComponentModel.LocalizableAttribute(false)]
    [System.Design.SRDescriptionAttribute("ControlLocationDescr")]
    public System.Drawing.Point GetTrayLocation(System.ComponentModel.IComponent receiver) { return default(System.Drawing.Point); }
    public bool IsTrayComponent(System.ComponentModel.IComponent comp) { return default(bool); }
    protected override void OnDragDrop(System.Windows.Forms.DragEventArgs de) { }
    protected override void OnDragEnter(System.Windows.Forms.DragEventArgs de) { }
    protected override void OnDragLeave(System.EventArgs e) { }
    protected override void OnDragOver(System.Windows.Forms.DragEventArgs de) { }
    protected override void OnGiveFeedback(System.Windows.Forms.GiveFeedbackEventArgs gfevent) { }
    protected override void OnLayout(System.Windows.Forms.LayoutEventArgs levent) { }
    protected virtual void OnLostCapture() { }
    protected override void OnMouseDoubleClick(System.Windows.Forms.MouseEventArgs e) { }
    protected override void OnMouseDown(System.Windows.Forms.MouseEventArgs e) { }
    protected override void OnMouseMove(System.Windows.Forms.MouseEventArgs e) { }
    protected override void OnMouseUp(System.Windows.Forms.MouseEventArgs e) { }
    protected override void OnPaint(System.Windows.Forms.PaintEventArgs pe) { }
    protected virtual void OnSetCursor() { }
    public virtual void RemoveComponent(System.ComponentModel.IComponent component) { }
    public void SetLocation(System.ComponentModel.IComponent receiver, System.Drawing.Point location) { }
    public void SetTrayLocation(System.ComponentModel.IComponent receiver, System.Drawing.Point location) { }
    bool System.ComponentModel.IExtenderProvider.CanExtend(object component) { return default(bool); }
    protected override void WndProc(ref System.Windows.Forms.Message m) { }
  }
  public partial class ControlDesigner : System.ComponentModel.Design.ComponentDesigner {
    protected System.Windows.Forms.AccessibleObject accessibilityObj;
    protected static readonly System.Drawing.Point InvalidPoint;
    public ControlDesigner() { }
    public virtual System.Windows.Forms.AccessibleObject AccessibilityObject { get { return default(System.Windows.Forms.AccessibleObject); } }
    public override System.Collections.ICollection AssociatedComponents { get { return default(System.Collections.ICollection); } }
    public bool AutoResizeHandles { get { return default(bool); } set { } }
    protected System.Windows.Forms.Design.Behavior.BehaviorService BehaviorService { get { return default(System.Windows.Forms.Design.Behavior.BehaviorService); } }
    public virtual System.Windows.Forms.Control Control { get { return default(System.Windows.Forms.Control); } }
    protected virtual bool EnableDragRect { get { return default(bool); } }
    protected override System.ComponentModel.InheritanceAttribute InheritanceAttribute { get { return default(System.ComponentModel.InheritanceAttribute); } }
    protected override System.ComponentModel.IComponent ParentComponent { get { return default(System.ComponentModel.IComponent); } }
    public virtual bool ParticipatesWithSnapLines { get { return default(bool); } }
    public virtual System.Windows.Forms.Design.SelectionRules SelectionRules { get { return default(System.Windows.Forms.Design.SelectionRules); } }
    public virtual System.Collections.IList SnapLines { get { return default(System.Collections.IList); } }
    protected void BaseWndProc(ref System.Windows.Forms.Message m) { }
    public virtual bool CanBeParentedTo(System.ComponentModel.Design.IDesigner parentDesigner) { return default(bool); }
    protected void DefWndProc(ref System.Windows.Forms.Message m) { }
    protected void DisplayError(System.Exception e) { }
    protected override void Dispose(bool disposing) { }
    protected bool EnableDesignMode(System.Windows.Forms.Control child, string name) { return default(bool); }
    protected void EnableDragDrop(bool value) { }
    protected virtual System.Windows.Forms.Design.Behavior.ControlBodyGlyph GetControlGlyph(System.Windows.Forms.Design.Behavior.GlyphSelectionType selectionType) { return default(System.Windows.Forms.Design.Behavior.ControlBodyGlyph); }
    public virtual System.Windows.Forms.Design.Behavior.GlyphCollection GetGlyphs(System.Windows.Forms.Design.Behavior.GlyphSelectionType selectionType) { return default(System.Windows.Forms.Design.Behavior.GlyphCollection); }
    protected virtual bool GetHitTest(System.Drawing.Point point) { return default(bool); }
    protected void HookChildControls(System.Windows.Forms.Control firstChild) { }
    public override void Initialize(System.ComponentModel.IComponent component) { }
    public override void InitializeExistingComponent(System.Collections.IDictionary defaultValues) { }
    public override void InitializeNewComponent(System.Collections.IDictionary defaultValues) { }
    public virtual System.Windows.Forms.Design.ControlDesigner InternalControlDesigner(int internalControlIndex) { return default(System.Windows.Forms.Design.ControlDesigner); }
    public virtual int NumberOfInternalControlDesigners() { return default(int); }
    protected virtual void OnContextMenu(int x, int y) { }
    protected virtual void OnCreateHandle() { }
    protected virtual void OnDragComplete(System.Windows.Forms.DragEventArgs de) { }
    protected virtual void OnDragDrop(System.Windows.Forms.DragEventArgs de) { }
    protected virtual void OnDragEnter(System.Windows.Forms.DragEventArgs de) { }
    protected virtual void OnDragLeave(System.EventArgs e) { }
    protected virtual void OnDragOver(System.Windows.Forms.DragEventArgs de) { }
    protected virtual void OnGiveFeedback(System.Windows.Forms.GiveFeedbackEventArgs e) { }
    protected virtual void OnMouseDragBegin(int x, int y) { }
    protected virtual void OnMouseDragEnd(bool cancel) { }
    protected virtual void OnMouseDragMove(int x, int y) { }
    protected virtual void OnMouseEnter() { }
    protected virtual void OnMouseHover() { }
    protected virtual void OnMouseLeave() { }
    protected virtual void OnPaintAdornments(System.Windows.Forms.PaintEventArgs pe) { }
    [System.ObsoleteAttribute("This method has been deprecated. Use InitializeNewComponent instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
    public override void OnSetComponentDefaults() { }
    protected virtual void OnSetCursor() { }
    protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
    protected void UnhookChildControls(System.Windows.Forms.Control firstChild) { }
    protected virtual void WndProc(ref System.Windows.Forms.Message m) { }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ControlDesignerAccessibleObject : System.Windows.Forms.AccessibleObject {
      public ControlDesignerAccessibleObject(System.Windows.Forms.Design.ControlDesigner designer, System.Windows.Forms.Control control) { }
      public override System.Drawing.Rectangle Bounds { get { return default(System.Drawing.Rectangle); } }
      public override string DefaultAction { get { return default(string); } }
      public override string Description { get { return default(string); } }
      public override string Name { get { return default(string); } }
      public override System.Windows.Forms.AccessibleObject Parent { get { return default(System.Windows.Forms.AccessibleObject); } }
      public override System.Windows.Forms.AccessibleRole Role { get { return default(System.Windows.Forms.AccessibleRole); } }
      public override System.Windows.Forms.AccessibleStates State { get { return default(System.Windows.Forms.AccessibleStates); } }
      public override string Value { get { return default(string); } }
      public override System.Windows.Forms.AccessibleObject GetChild(int index) { return default(System.Windows.Forms.AccessibleObject); }
      public override int GetChildCount() { return default(int); }
      public override System.Windows.Forms.AccessibleObject GetFocused() { return default(System.Windows.Forms.AccessibleObject); }
      public override System.Windows.Forms.AccessibleObject GetSelected() { return default(System.Windows.Forms.AccessibleObject); }
      public override System.Windows.Forms.AccessibleObject HitTest(int x, int y) { return default(System.Windows.Forms.AccessibleObject); }
    }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class DesignerOptions {
    public DesignerOptions() { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Design.SRCategoryAttribute("DesignerOptions_EnableInSituEditingCat")]
    [System.Design.SRDescriptionAttribute("DesignerOptions_EnableInSituEditingDesc")]
    [System.Windows.Forms.Design.SRDisplayNameAttribute("DesignerOptions_EnableInSituEditingDisplay")]
    public virtual bool EnableInSituEditing { get { return default(bool); } set { } }
    [System.Design.SRCategoryAttribute("DesignerOptions_LayoutSettings")]
    [System.Design.SRDescriptionAttribute("DesignerOptions_GridSizeDesc")]
    [System.Windows.Forms.Design.SRDisplayNameAttribute("DesignerOptions_GridSizeDisplayName")]
    public virtual System.Drawing.Size GridSize { get { return default(System.Drawing.Size); } set { } }
    [System.Design.SRCategoryAttribute("DesignerOptions_ObjectBoundSmartTagSettings")]
    [System.Design.SRDescriptionAttribute("DesignerOptions_ObjectBoundSmartTagAutoShow")]
    [System.Windows.Forms.Design.SRDisplayNameAttribute("DesignerOptions_ObjectBoundSmartTagAutoShowDisplayName")]
    public virtual bool ObjectBoundSmartTagAutoShow { get { return default(bool); } set { } }
    [System.Design.SRCategoryAttribute("DesignerOptions_LayoutSettings")]
    [System.Design.SRDescriptionAttribute("DesignerOptions_ShowGridDesc")]
    [System.Windows.Forms.Design.SRDisplayNameAttribute("DesignerOptions_ShowGridDisplayName")]
    public virtual bool ShowGrid { get { return default(bool); } set { } }
    [System.Design.SRCategoryAttribute("DesignerOptions_LayoutSettings")]
    [System.Design.SRDescriptionAttribute("DesignerOptions_SnapToGridDesc")]
    [System.Windows.Forms.Design.SRDisplayNameAttribute("DesignerOptions_SnapToGridDisplayName")]
    public virtual bool SnapToGrid { get { return default(bool); } set { } }
    [System.Design.SRCategoryAttribute("DesignerOptions_CodeGenSettings")]
    [System.Design.SRDescriptionAttribute("DesignerOptions_OptimizedCodeGen")]
    [System.Windows.Forms.Design.SRDisplayNameAttribute("DesignerOptions_CodeGenDisplay")]
    public virtual bool UseOptimizedCodeGeneration { get { return default(bool); } set { } }
    [System.Design.SRCategoryAttribute("DesignerOptions_LayoutSettings")]
    [System.Design.SRDescriptionAttribute("DesignerOptions_UseSmartTags")]
    public virtual bool UseSmartTags { get { return default(bool); } set { } }
    [System.Design.SRCategoryAttribute("DesignerOptions_LayoutSettings")]
    [System.Design.SRDescriptionAttribute("DesignerOptions_UseSnapLines")]
    public virtual bool UseSnapLines { get { return default(bool); } set { } }
  }
  public sealed partial class DockEditor : System.Drawing.Design.UITypeEditor {
    public DockEditor() { }
    public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { return default(object); }
    public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { return default(System.Drawing.Design.UITypeEditorEditStyle); }
  }
  [System.ComponentModel.ToolboxItemFilterAttribute("System.Windows.Forms")]
  public partial class DocumentDesigner : System.Windows.Forms.Design.ScrollableControlDesigner, System.ComponentModel.Design.IDesigner, System.ComponentModel.Design.IRootDesigner, System.Drawing.Design.IToolboxUser, System.IDisposable {
    protected System.Windows.Forms.Design.IMenuEditorService menuEditorService;
    public DocumentDesigner() { }
    public override System.Windows.Forms.Design.SelectionRules SelectionRules { get { return default(System.Windows.Forms.Design.SelectionRules); } }
    System.ComponentModel.Design.ViewTechnology[] System.ComponentModel.Design.IRootDesigner.SupportedTechnologies { get { return default(System.ComponentModel.Design.ViewTechnology[]); } }
    protected override void Dispose(bool disposing) { }
    protected virtual void EnsureMenuEditorService(System.ComponentModel.IComponent c) { }
    public override System.Windows.Forms.Design.Behavior.GlyphCollection GetGlyphs(System.Windows.Forms.Design.Behavior.GlyphSelectionType selectionType) { return default(System.Windows.Forms.Design.Behavior.GlyphCollection); }
    protected virtual bool GetToolSupported(System.Drawing.Design.ToolboxItem tool) { return default(bool); }
    public override void Initialize(System.ComponentModel.IComponent component) { }
    protected override void OnContextMenu(int x, int y) { }
    protected override void OnCreateHandle() { }
    protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
    object System.ComponentModel.Design.IRootDesigner.GetView(System.ComponentModel.Design.ViewTechnology technology) { return default(object); }
    bool System.Drawing.Design.IToolboxUser.GetToolSupported(System.Drawing.Design.ToolboxItem tool) { return default(bool); }
    void System.Drawing.Design.IToolboxUser.ToolPicked(System.Drawing.Design.ToolboxItem tool) { }
    protected virtual void ToolPicked(System.Drawing.Design.ToolboxItem tool) { }
    protected override void WndProc(ref System.Windows.Forms.Message m) { }
  }
  public sealed partial class EventHandlerService {
    public EventHandlerService(System.Windows.Forms.Control focusWnd) { }
    public System.Windows.Forms.Control FocusWindow { get { return default(System.Windows.Forms.Control); } }
    public event System.EventHandler EventHandlerChanged { add { } remove { } }
    public object GetHandler(System.Type handlerType) { return default(object); }
    public void PopHandler(object handler) { }
    public void PushHandler(object handler) { }
  }
  public partial class FileNameEditor : System.Drawing.Design.UITypeEditor {
    public FileNameEditor() { }
    public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { return default(object); }
    public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { return default(System.Drawing.Design.UITypeEditorEditStyle); }
    protected virtual void InitializeDialog(System.Windows.Forms.OpenFileDialog openFileDialog) { }
  }
  public partial class FolderNameEditor : System.Drawing.Design.UITypeEditor {
    public FolderNameEditor() { }
    public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { return default(object); }
    public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { return default(System.Drawing.Design.UITypeEditorEditStyle); }
    protected virtual void InitializeDialog(System.Windows.Forms.Design.FolderNameEditor.FolderBrowser folderBrowser) { }
    protected sealed partial class FolderBrowser : System.ComponentModel.Component {
      public FolderBrowser() { }
      public string Description { get { return default(string); } set { } }
      public string DirectoryPath { get { return default(string); } }
      public System.Windows.Forms.Design.FolderNameEditor.FolderBrowserFolder StartLocation { get { return default(System.Windows.Forms.Design.FolderNameEditor.FolderBrowserFolder); } set { } }
      public System.Windows.Forms.Design.FolderNameEditor.FolderBrowserStyles Style { get { return default(System.Windows.Forms.Design.FolderNameEditor.FolderBrowserStyles); } set { } }
      public System.Windows.Forms.DialogResult ShowDialog() { return default(System.Windows.Forms.DialogResult); }
      public System.Windows.Forms.DialogResult ShowDialog(System.Windows.Forms.IWin32Window owner) { return default(System.Windows.Forms.DialogResult); }
    }
    protected enum FolderBrowserFolder {
      Desktop = 0,
      Favorites = 6,
      MyComputer = 17,
      MyDocuments = 5,
      MyPictures = 39,
      NetAndDialUpConnections = 49,
      NetworkNeighborhood = 18,
      Printers = 4,
      Recent = 8,
      SendTo = 9,
      StartMenu = 11,
      Templates = 21,
    }
    [System.FlagsAttribute]
    protected enum FolderBrowserStyles {
      BrowseForComputer = 4096,
      BrowseForEverything = 16384,
      BrowseForPrinter = 8192,
      RestrictToDomain = 2,
      RestrictToFilesystem = 1,
      RestrictToSubfolders = 8,
      ShowTextBox = 16,
    }
  }
  public partial interface IContainsThemedScrollbarWindows {
    System.Collections.IEnumerable ThemedScrollbarWindows();
  }
  public partial class ImageListCodeDomSerializer : System.ComponentModel.Design.Serialization.CodeDomSerializer {
    public ImageListCodeDomSerializer() { }
    public override object Deserialize(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object codeObject) { return default(object); }
    public override object Serialize(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object value) { return default(object); }
  }
  public partial class ImageListImageEditor : System.Drawing.Design.ImageEditor {
    public ImageListImageEditor() { }
    public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { return default(object); }
    protected override string GetFileDialogDescription() { return default(string); }
    protected override System.Type[] GetImageExtenders() { return default(System.Type[]); }
    public override bool GetPaintValueSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public override void PaintValue(System.Drawing.Design.PaintValueEventArgs e) { }
  }
  public partial interface IMenuEditorService {
    System.Windows.Forms.Menu GetMenu();
    bool IsActive();
    bool MessageFilter(ref System.Windows.Forms.Message m);
    void SetMenu(System.Windows.Forms.Menu menu);
    void SetSelection(System.Windows.Forms.MenuItem item);
  }
  public abstract partial class MaskDescriptor {
    protected MaskDescriptor() { }
    public virtual System.Globalization.CultureInfo Culture { get { return default(System.Globalization.CultureInfo); } }
    public abstract string Mask { get; }
    public abstract string Name { get; }
    public abstract string Sample { get; }
    public abstract System.Type ValidatingType { get; }
    public override bool Equals(object maskDescriptor) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool IsValidMaskDescriptor(System.Windows.Forms.Design.MaskDescriptor maskDescriptor) { return default(bool); }
    public static bool IsValidMaskDescriptor(System.Windows.Forms.Design.MaskDescriptor maskDescriptor, out string validationErrorDescription) { validationErrorDescription = default(string); return default(bool); }
    public override string ToString() { return default(string); }
  }
  public sealed partial class MenuCommands : System.ComponentModel.Design.StandardCommands {
    public static readonly System.ComponentModel.Design.CommandID ComponentTrayMenu;
    public static readonly System.ComponentModel.Design.CommandID ContainerMenu;
    public static readonly System.ComponentModel.Design.CommandID DesignerProperties;
    public static readonly System.ComponentModel.Design.CommandID EditLabel;
    public static readonly System.ComponentModel.Design.CommandID KeyCancel;
    public static readonly System.ComponentModel.Design.CommandID KeyDefaultAction;
    public static readonly System.ComponentModel.Design.CommandID KeyEnd;
    public static readonly System.ComponentModel.Design.CommandID KeyHome;
    public static readonly System.ComponentModel.Design.CommandID KeyInvokeSmartTag;
    public static readonly System.ComponentModel.Design.CommandID KeyMoveDown;
    public static readonly System.ComponentModel.Design.CommandID KeyMoveLeft;
    public static readonly System.ComponentModel.Design.CommandID KeyMoveRight;
    public static readonly System.ComponentModel.Design.CommandID KeyMoveUp;
    public static readonly System.ComponentModel.Design.CommandID KeyNudgeDown;
    public static readonly System.ComponentModel.Design.CommandID KeyNudgeHeightDecrease;
    public static readonly System.ComponentModel.Design.CommandID KeyNudgeHeightIncrease;
    public static readonly System.ComponentModel.Design.CommandID KeyNudgeLeft;
    public static readonly System.ComponentModel.Design.CommandID KeyNudgeRight;
    public static readonly System.ComponentModel.Design.CommandID KeyNudgeUp;
    public static readonly System.ComponentModel.Design.CommandID KeyNudgeWidthDecrease;
    public static readonly System.ComponentModel.Design.CommandID KeyNudgeWidthIncrease;
    public static readonly System.ComponentModel.Design.CommandID KeyReverseCancel;
    public static readonly System.ComponentModel.Design.CommandID KeySelectNext;
    public static readonly System.ComponentModel.Design.CommandID KeySelectPrevious;
    public static readonly System.ComponentModel.Design.CommandID KeyShiftEnd;
    public static readonly System.ComponentModel.Design.CommandID KeyShiftHome;
    public static readonly System.ComponentModel.Design.CommandID KeySizeHeightDecrease;
    public static readonly System.ComponentModel.Design.CommandID KeySizeHeightIncrease;
    public static readonly System.ComponentModel.Design.CommandID KeySizeWidthDecrease;
    public static readonly System.ComponentModel.Design.CommandID KeySizeWidthIncrease;
    public static readonly System.ComponentModel.Design.CommandID KeyTabOrderSelect;
    public static readonly System.ComponentModel.Design.CommandID SelectionMenu;
    public static readonly System.ComponentModel.Design.CommandID SetStatusRectangle;
    public static readonly System.ComponentModel.Design.CommandID SetStatusText;
    public static readonly System.ComponentModel.Design.CommandID TraySelectionMenu;
    public MenuCommands() { }
  }
  public partial class ParentControlDesigner : System.Windows.Forms.Design.ControlDesigner {
    public ParentControlDesigner() { }
    protected virtual bool AllowControlLasso { get { return default(bool); } }
    protected virtual bool AllowGenericDragBox { get { return default(bool); } }
    protected internal virtual bool AllowSetChildIndexOnDrop { get { return default(bool); } }
    protected virtual System.Drawing.Point DefaultControlLocation { get { return default(System.Drawing.Point); } }
    protected virtual bool DrawGrid { get { return default(bool); } set { } }
    protected override bool EnableDragRect { get { return default(bool); } }
    protected System.Drawing.Size GridSize { get { return default(System.Drawing.Size); } set { } }
    protected System.Drawing.Design.ToolboxItem MouseDragTool { get { return default(System.Drawing.Design.ToolboxItem); } }
    public override System.Collections.IList SnapLines { get { return default(System.Collections.IList); } }
    protected void AddPaddingSnapLines(ref System.Collections.ArrayList snapLines) { }
    protected internal virtual bool CanAddComponent(System.ComponentModel.IComponent component) { return default(bool); }
    public virtual bool CanParent(System.Windows.Forms.Control control) { return default(bool); }
    public virtual bool CanParent(System.Windows.Forms.Design.ControlDesigner controlDesigner) { return default(bool); }
    protected void CreateTool(System.Drawing.Design.ToolboxItem tool) { }
    protected void CreateTool(System.Drawing.Design.ToolboxItem tool, System.Drawing.Point location) { }
    protected void CreateTool(System.Drawing.Design.ToolboxItem tool, System.Drawing.Rectangle bounds) { }
    protected virtual System.ComponentModel.IComponent[] CreateToolCore(System.Drawing.Design.ToolboxItem tool, int x, int y, int width, int height, bool hasLocation, bool hasSize) { return default(System.ComponentModel.IComponent[]); }
    protected override void Dispose(bool disposing) { }
    protected System.Windows.Forms.Control GetControl(object component) { return default(System.Windows.Forms.Control); }
    protected override System.Windows.Forms.Design.Behavior.ControlBodyGlyph GetControlGlyph(System.Windows.Forms.Design.Behavior.GlyphSelectionType selectionType) { return default(System.Windows.Forms.Design.Behavior.ControlBodyGlyph); }
    public override System.Windows.Forms.Design.Behavior.GlyphCollection GetGlyphs(System.Windows.Forms.Design.Behavior.GlyphSelectionType selectionType) { return default(System.Windows.Forms.Design.Behavior.GlyphCollection); }
    protected virtual System.Windows.Forms.Control GetParentForComponent(System.ComponentModel.IComponent component) { return default(System.Windows.Forms.Control); }
    protected System.Drawing.Rectangle GetUpdatedRect(System.Drawing.Rectangle originalRect, System.Drawing.Rectangle dragRect, bool updateSize) { return default(System.Drawing.Rectangle); }
    public override void Initialize(System.ComponentModel.IComponent component) { }
    public override void InitializeNewComponent(System.Collections.IDictionary defaultValues) { }
    protected static void InvokeCreateTool(System.Windows.Forms.Design.ParentControlDesigner toInvoke, System.Drawing.Design.ToolboxItem tool) { }
    protected override void OnDragComplete(System.Windows.Forms.DragEventArgs de) { }
    protected override void OnDragDrop(System.Windows.Forms.DragEventArgs de) { }
    protected override void OnDragEnter(System.Windows.Forms.DragEventArgs de) { }
    protected override void OnDragLeave(System.EventArgs e) { }
    protected override void OnDragOver(System.Windows.Forms.DragEventArgs de) { }
    protected override void OnMouseDragBegin(int x, int y) { }
    protected override void OnMouseDragEnd(bool cancel) { }
    protected override void OnMouseDragMove(int x, int y) { }
    protected override void OnPaintAdornments(System.Windows.Forms.PaintEventArgs pe) { }
    protected override void OnSetCursor() { }
    protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
  }
  public partial class ScrollableControlDesigner : System.Windows.Forms.Design.ParentControlDesigner {
    public ScrollableControlDesigner() { }
    protected override bool GetHitTest(System.Drawing.Point pt) { return default(bool); }
    protected override void WndProc(ref System.Windows.Forms.Message m) { }
  }
  [System.FlagsAttribute]
  public enum SelectionRules {
    AllSizeable = 15,
    BottomSizeable = 2,
    LeftSizeable = 4,
    Locked = -2147483648,
    Moveable = 268435456,
    None = 0,
    RightSizeable = 8,
    TopSizeable = 1,
    Visible = 1073741824,
  }
  [System.Security.SecurityCriticalAttribute]
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class ShortcutKeysEditor : System.Drawing.Design.UITypeEditor {
    public ShortcutKeysEditor() { }
    public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { return default(object); }
    public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { return default(System.Drawing.Design.UITypeEditorEditStyle); }
  }
  public enum ThemedScrollbarMode {
    All = 1,
    None = 2,
    OnlyTopLevel = 3,
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct ThemedScrollbarWindow {
    public System.IntPtr Handle;
    public System.Windows.Forms.Design.ThemedScrollbarMode Mode;
  }
  public partial class WindowsFormsDesignerOptionService : System.ComponentModel.Design.DesignerOptionService {
    public WindowsFormsDesignerOptionService() { }
    public virtual System.Windows.Forms.Design.DesignerOptions CompatibilityOptions { get { return default(System.Windows.Forms.Design.DesignerOptions); } }
    protected override void PopulateOptionCollection(System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection options) { }
  }
}
namespace System.Windows.Forms.Design.Behavior {
  public sealed partial class Adorner {
    public Adorner() { }
    public System.Windows.Forms.Design.Behavior.BehaviorService BehaviorService { get { return default(System.Windows.Forms.Design.Behavior.BehaviorService); } set { } }
    public bool Enabled { get { return default(bool); } set { } }
    public System.Windows.Forms.Design.Behavior.GlyphCollection Glyphs { get { return default(System.Windows.Forms.Design.Behavior.GlyphCollection); } }
    public void Invalidate() { }
    public void Invalidate(System.Drawing.Rectangle rectangle) { }
    public void Invalidate(System.Drawing.Region region) { }
  }
  public abstract partial class Behavior {
    protected Behavior() { }
    protected Behavior(bool callParentBehavior, System.Windows.Forms.Design.Behavior.BehaviorService behaviorService) { }
    public virtual System.Windows.Forms.Cursor Cursor { get { return default(System.Windows.Forms.Cursor); } }
    public virtual bool DisableAllCommands { get { return default(bool); } }
    public virtual System.ComponentModel.Design.MenuCommand FindCommand(System.ComponentModel.Design.CommandID commandId) { return default(System.ComponentModel.Design.MenuCommand); }
    public virtual void OnDragDrop(System.Windows.Forms.Design.Behavior.Glyph g, System.Windows.Forms.DragEventArgs e) { }
    public virtual void OnDragEnter(System.Windows.Forms.Design.Behavior.Glyph g, System.Windows.Forms.DragEventArgs e) { }
    public virtual void OnDragLeave(System.Windows.Forms.Design.Behavior.Glyph g, System.EventArgs e) { }
    public virtual void OnDragOver(System.Windows.Forms.Design.Behavior.Glyph g, System.Windows.Forms.DragEventArgs e) { }
    public virtual void OnGiveFeedback(System.Windows.Forms.Design.Behavior.Glyph g, System.Windows.Forms.GiveFeedbackEventArgs e) { }
    public virtual void OnLoseCapture(System.Windows.Forms.Design.Behavior.Glyph g, System.EventArgs e) { }
    public virtual bool OnMouseDoubleClick(System.Windows.Forms.Design.Behavior.Glyph g, System.Windows.Forms.MouseButtons button, System.Drawing.Point mouseLoc) { return default(bool); }
    public virtual bool OnMouseDown(System.Windows.Forms.Design.Behavior.Glyph g, System.Windows.Forms.MouseButtons button, System.Drawing.Point mouseLoc) { return default(bool); }
    public virtual bool OnMouseEnter(System.Windows.Forms.Design.Behavior.Glyph g) { return default(bool); }
    public virtual bool OnMouseHover(System.Windows.Forms.Design.Behavior.Glyph g, System.Drawing.Point mouseLoc) { return default(bool); }
    public virtual bool OnMouseLeave(System.Windows.Forms.Design.Behavior.Glyph g) { return default(bool); }
    public virtual bool OnMouseMove(System.Windows.Forms.Design.Behavior.Glyph g, System.Windows.Forms.MouseButtons button, System.Drawing.Point mouseLoc) { return default(bool); }
    public virtual bool OnMouseUp(System.Windows.Forms.Design.Behavior.Glyph g, System.Windows.Forms.MouseButtons button) { return default(bool); }
    public virtual void OnQueryContinueDrag(System.Windows.Forms.Design.Behavior.Glyph g, System.Windows.Forms.QueryContinueDragEventArgs e) { }
  }
  public partial class BehaviorDragDropEventArgs : System.EventArgs {
    public BehaviorDragDropEventArgs(System.Collections.ICollection dragComponents) { }
    public System.Collections.ICollection DragComponents { get { return default(System.Collections.ICollection); } }
  }
  public delegate void BehaviorDragDropEventHandler(object sender, System.Windows.Forms.Design.Behavior.BehaviorDragDropEventArgs e);
  public sealed partial class BehaviorService : System.IDisposable {
    internal BehaviorService() { }
    public System.Windows.Forms.Design.Behavior.BehaviorServiceAdornerCollection Adorners { get { return default(System.Windows.Forms.Design.Behavior.BehaviorServiceAdornerCollection); } }
    public System.Drawing.Graphics AdornerWindowGraphics { get { return default(System.Drawing.Graphics); } }
    public System.Windows.Forms.Design.Behavior.Behavior CurrentBehavior { get { return default(System.Windows.Forms.Design.Behavior.Behavior); } }
    public event System.Windows.Forms.Design.Behavior.BehaviorDragDropEventHandler BeginDrag { add { } remove { } }
    public event System.Windows.Forms.Design.Behavior.BehaviorDragDropEventHandler EndDrag { add { } remove { } }
    public event System.EventHandler Synchronize { add { } remove { } }
    public System.Drawing.Point AdornerWindowPointToScreen(System.Drawing.Point p) { return default(System.Drawing.Point); }
    public System.Drawing.Point AdornerWindowToScreen() { return default(System.Drawing.Point); }
    public System.Drawing.Rectangle ControlRectInAdornerWindow(System.Windows.Forms.Control c) { return default(System.Drawing.Rectangle); }
    public System.Drawing.Point ControlToAdornerWindow(System.Windows.Forms.Control c) { return default(System.Drawing.Point); }
    public void Dispose() { }
    public System.Windows.Forms.Design.Behavior.Behavior GetNextBehavior(System.Windows.Forms.Design.Behavior.Behavior behavior) { return default(System.Windows.Forms.Design.Behavior.Behavior); }
    public void Invalidate() { }
    public void Invalidate(System.Drawing.Rectangle rect) { }
    public void Invalidate(System.Drawing.Region r) { }
    public System.Drawing.Point MapAdornerWindowPoint(System.IntPtr handle, System.Drawing.Point pt) { return default(System.Drawing.Point); }
    public System.Windows.Forms.Design.Behavior.Behavior PopBehavior(System.Windows.Forms.Design.Behavior.Behavior behavior) { return default(System.Windows.Forms.Design.Behavior.Behavior); }
    public void PushBehavior(System.Windows.Forms.Design.Behavior.Behavior behavior) { }
    public void PushCaptureBehavior(System.Windows.Forms.Design.Behavior.Behavior behavior) { }
    public System.Drawing.Point ScreenToAdornerWindow(System.Drawing.Point p) { return default(System.Drawing.Point); }
    public void SyncSelection() { }
  }
  public sealed partial class BehaviorServiceAdornerCollection : System.Collections.CollectionBase {
    public BehaviorServiceAdornerCollection(System.Windows.Forms.Design.Behavior.Adorner[] value) { }
    public BehaviorServiceAdornerCollection(System.Windows.Forms.Design.Behavior.BehaviorService behaviorService) { }
    public BehaviorServiceAdornerCollection(System.Windows.Forms.Design.Behavior.BehaviorServiceAdornerCollection value) { }
    public System.Windows.Forms.Design.Behavior.Adorner this[int index] { get { return default(System.Windows.Forms.Design.Behavior.Adorner); } set { } }
    public int Add(System.Windows.Forms.Design.Behavior.Adorner value) { return default(int); }
    public void AddRange(System.Windows.Forms.Design.Behavior.Adorner[] value) { }
    public void AddRange(System.Windows.Forms.Design.Behavior.BehaviorServiceAdornerCollection value) { }
    public bool Contains(System.Windows.Forms.Design.Behavior.Adorner value) { return default(bool); }
    public void CopyTo(System.Windows.Forms.Design.Behavior.Adorner[] array, int index) { }
    public new System.Windows.Forms.Design.Behavior.BehaviorServiceAdornerCollectionEnumerator GetEnumerator() { return default(System.Windows.Forms.Design.Behavior.BehaviorServiceAdornerCollectionEnumerator); }
    public int IndexOf(System.Windows.Forms.Design.Behavior.Adorner value) { return default(int); }
    public void Insert(int index, System.Windows.Forms.Design.Behavior.Adorner value) { }
    public void Remove(System.Windows.Forms.Design.Behavior.Adorner value) { }
  }
  public partial class BehaviorServiceAdornerCollectionEnumerator : System.Collections.IEnumerator {
    public BehaviorServiceAdornerCollectionEnumerator(System.Windows.Forms.Design.Behavior.BehaviorServiceAdornerCollection mappings) { }
    public System.Windows.Forms.Design.Behavior.Adorner Current { get { return default(System.Windows.Forms.Design.Behavior.Adorner); } }
    object System.Collections.IEnumerator.Current { get { return default(object); } }
    public bool MoveNext() { return default(bool); }
    public void Reset() { }
    bool System.Collections.IEnumerator.MoveNext() { return default(bool); }
    void System.Collections.IEnumerator.Reset() { }
  }
  public partial class ComponentGlyph : System.Windows.Forms.Design.Behavior.Glyph {
    public ComponentGlyph(System.ComponentModel.IComponent relatedComponent) : base (default(System.Windows.Forms.Design.Behavior.Behavior)) { }
    public ComponentGlyph(System.ComponentModel.IComponent relatedComponent, System.Windows.Forms.Design.Behavior.Behavior behavior) : base (default(System.Windows.Forms.Design.Behavior.Behavior)) { }
    public System.ComponentModel.IComponent RelatedComponent { get { return default(System.ComponentModel.IComponent); } }
    public override System.Windows.Forms.Cursor GetHitTest(System.Drawing.Point p) { return default(System.Windows.Forms.Cursor); }
    public override void Paint(System.Windows.Forms.PaintEventArgs pe) { }
  }
  public partial class ControlBodyGlyph : System.Windows.Forms.Design.Behavior.ComponentGlyph {
    public ControlBodyGlyph(System.Drawing.Rectangle bounds, System.Windows.Forms.Cursor cursor, System.ComponentModel.IComponent relatedComponent, System.Windows.Forms.Design.Behavior.Behavior behavior) : base (default(System.ComponentModel.IComponent), default(System.Windows.Forms.Design.Behavior.Behavior)) { }
    public ControlBodyGlyph(System.Drawing.Rectangle bounds, System.Windows.Forms.Cursor cursor, System.ComponentModel.IComponent relatedComponent, System.Windows.Forms.Design.ControlDesigner designer) : base (default(System.ComponentModel.IComponent), default(System.Windows.Forms.Design.Behavior.Behavior)) { }
    public override System.Drawing.Rectangle Bounds { get { return default(System.Drawing.Rectangle); } }
    public override System.Windows.Forms.Cursor GetHitTest(System.Drawing.Point p) { return default(System.Windows.Forms.Cursor); }
  }
  public abstract partial class Glyph {
    protected Glyph(System.Windows.Forms.Design.Behavior.Behavior behavior) { }
    public virtual System.Windows.Forms.Design.Behavior.Behavior Behavior { get { return default(System.Windows.Forms.Design.Behavior.Behavior); } }
    public virtual System.Drawing.Rectangle Bounds { get { return default(System.Drawing.Rectangle); } }
    public abstract System.Windows.Forms.Cursor GetHitTest(System.Drawing.Point p);
    public abstract void Paint(System.Windows.Forms.PaintEventArgs pe);
    protected void SetBehavior(System.Windows.Forms.Design.Behavior.Behavior behavior) { }
  }
  public partial class GlyphCollection : System.Collections.CollectionBase {
    public GlyphCollection() { }
    public GlyphCollection(System.Windows.Forms.Design.Behavior.Glyph[] value) { }
    public GlyphCollection(System.Windows.Forms.Design.Behavior.GlyphCollection value) { }
    public System.Windows.Forms.Design.Behavior.Glyph this[int index] { get { return default(System.Windows.Forms.Design.Behavior.Glyph); } set { } }
    public int Add(System.Windows.Forms.Design.Behavior.Glyph value) { return default(int); }
    public void AddRange(System.Windows.Forms.Design.Behavior.Glyph[] value) { }
    public void AddRange(System.Windows.Forms.Design.Behavior.GlyphCollection value) { }
    public bool Contains(System.Windows.Forms.Design.Behavior.Glyph value) { return default(bool); }
    public void CopyTo(System.Windows.Forms.Design.Behavior.Glyph[] array, int index) { }
    public int IndexOf(System.Windows.Forms.Design.Behavior.Glyph value) { return default(int); }
    public void Insert(int index, System.Windows.Forms.Design.Behavior.Glyph value) { }
    public void Remove(System.Windows.Forms.Design.Behavior.Glyph value) { }
  }
  public enum GlyphSelectionType {
    NotSelected = 0,
    Selected = 1,
    SelectedPrimary = 2,
  }
  public sealed partial class SnapLine {
    public SnapLine(System.Windows.Forms.Design.Behavior.SnapLineType type, int offset) { }
    public SnapLine(System.Windows.Forms.Design.Behavior.SnapLineType type, int offset, string filter) { }
    public SnapLine(System.Windows.Forms.Design.Behavior.SnapLineType type, int offset, string filter, System.Windows.Forms.Design.Behavior.SnapLinePriority priority) { }
    public SnapLine(System.Windows.Forms.Design.Behavior.SnapLineType type, int offset, System.Windows.Forms.Design.Behavior.SnapLinePriority priority) { }
    public string Filter { get { return default(string); } }
    public bool IsHorizontal { get { return default(bool); } }
    public bool IsVertical { get { return default(bool); } }
    public int Offset { get { return default(int); } }
    public System.Windows.Forms.Design.Behavior.SnapLinePriority Priority { get { return default(System.Windows.Forms.Design.Behavior.SnapLinePriority); } }
    public System.Windows.Forms.Design.Behavior.SnapLineType SnapLineType { get { return default(System.Windows.Forms.Design.Behavior.SnapLineType); } }
    public void AdjustOffset(int adjustment) { }
    public static bool ShouldSnap(System.Windows.Forms.Design.Behavior.SnapLine line1, System.Windows.Forms.Design.Behavior.SnapLine line2) { return default(bool); }
    public override string ToString() { return default(string); }
  }
  public enum SnapLinePriority {
    Always = 4,
    High = 3,
    Low = 1,
    Medium = 2,
  }
  public enum SnapLineType {
    Baseline = 6,
    Bottom = 1,
    Horizontal = 4,
    Left = 2,
    Right = 3,
    Top = 0,
    Vertical = 5,
  }
}
