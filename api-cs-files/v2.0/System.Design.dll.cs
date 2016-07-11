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
    [System.MonoTODOAttribute]
    public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { return default(object); }
    public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { return default(System.Drawing.Design.UITypeEditorEditStyle); }
  }
  [System.ComponentModel.DesignTimeVisibleAttribute(false)]
  [System.ComponentModel.ToolboxItemAttribute(false)]
  public partial class ByteViewer : System.Windows.Forms.TableLayoutPanel {
    [System.MonoTODOAttribute]
    public ByteViewer() { }
    [System.MonoTODOAttribute]
    public virtual System.Byte[] GetBytes() { return default(System.Byte[]); }
    [System.MonoTODOAttribute]
    public virtual System.ComponentModel.Design.DisplayMode GetDisplayMode() { return default(System.ComponentModel.Design.DisplayMode); }
    [System.MonoTODOAttribute]
    protected override void OnKeyDown(System.Windows.Forms.KeyEventArgs e) { }
    [System.MonoTODOAttribute]
    protected override void OnLayout(System.Windows.Forms.LayoutEventArgs e) { }
    [System.MonoTODOAttribute]
    protected override void OnPaint(System.Windows.Forms.PaintEventArgs e) { }
    [System.MonoTODOAttribute]
    public virtual void SaveToFile(string path) { }
    [System.MonoTODOAttribute]
    protected virtual void ScrollChanged(object source, System.EventArgs e) { }
    [System.MonoTODOAttribute]
    public virtual void SetBytes(System.Byte[] bytes) { }
    [System.MonoTODOAttribute]
    public virtual void SetDisplayMode(System.ComponentModel.Design.DisplayMode mode) { }
    [System.MonoTODOAttribute]
    public virtual void SetFile(string path) { }
    [System.MonoTODOAttribute]
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
    protected virtual object GetService(System.Type service) { return default(object); }
    public virtual void Initialize(System.ComponentModel.IComponent component) { }
    public virtual void InitializeExistingComponent(System.Collections.IDictionary defaultValues) { }
    public virtual void InitializeNewComponent(System.Collections.IDictionary defaultValues) { }
    [System.ObsoleteAttribute("This method has been deprecated. Use InitializeExistingComponent instead.")]
    public virtual void InitializeNonDefault() { }
    protected System.ComponentModel.InheritanceAttribute InvokeGetInheritanceAttribute(System.ComponentModel.Design.ComponentDesigner toInvoke) { return default(System.ComponentModel.InheritanceAttribute); }
    [System.ObsoleteAttribute("This method has been deprecated. Use InitializeNewComponent instead.")]
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
    [System.MonoTODOAttribute]
    public DesignerActionService(System.IServiceProvider serviceProvider) { }
    public event System.ComponentModel.Design.DesignerActionListsChangedEventHandler DesignerActionListsChanged { add { } remove { } }
    [System.MonoTODOAttribute]
    public void Add(System.ComponentModel.IComponent comp, System.ComponentModel.Design.DesignerActionList actionList) { }
    [System.MonoTODOAttribute]
    public void Add(System.ComponentModel.IComponent comp, System.ComponentModel.Design.DesignerActionListCollection designerActionListCollection) { }
    [System.MonoTODOAttribute]
    public void Clear() { }
    [System.MonoTODOAttribute]
    public bool Contains(System.ComponentModel.IComponent comp) { return default(bool); }
    public void Dispose() { }
    [System.MonoTODOAttribute]
    protected virtual void Dispose(bool disposing) { }
    [System.MonoTODOAttribute]
    public System.ComponentModel.Design.DesignerActionListCollection GetComponentActions(System.ComponentModel.IComponent component) { return default(System.ComponentModel.Design.DesignerActionListCollection); }
    [System.MonoTODOAttribute]
    public virtual System.ComponentModel.Design.DesignerActionListCollection GetComponentActions(System.ComponentModel.IComponent component, System.ComponentModel.Design.ComponentActionsType type) { return default(System.ComponentModel.Design.DesignerActionListCollection); }
    [System.MonoTODOAttribute]
    protected virtual void GetComponentDesignerActions(System.ComponentModel.IComponent component, System.ComponentModel.Design.DesignerActionListCollection actionLists) { }
    [System.MonoTODOAttribute]
    protected virtual void GetComponentServiceActions(System.ComponentModel.IComponent component, System.ComponentModel.Design.DesignerActionListCollection actionLists) { }
    [System.MonoTODOAttribute]
    public void Remove(System.ComponentModel.Design.DesignerActionList actionList) { }
    [System.MonoTODOAttribute]
    public void Remove(System.ComponentModel.IComponent comp) { }
    [System.MonoTODOAttribute]
    public void Remove(System.ComponentModel.IComponent comp, System.ComponentModel.Design.DesignerActionList actionList) { }
  }
  public partial class DesignerActionTextItem : System.ComponentModel.Design.DesignerActionItem {
    public DesignerActionTextItem(string displayName, string category) : base (default(string), default(string), default(string)) { }
  }
  public sealed partial class DesignerActionUIService : System.IDisposable {
    internal DesignerActionUIService() { }
    public event System.ComponentModel.Design.DesignerActionUIStateChangeEventHandler DesignerActionUIStateChange { add { } remove { } }
    [System.MonoTODOAttribute]
    public void Dispose() { }
    [System.MonoTODOAttribute]
    public void HideUI(System.ComponentModel.IComponent component) { }
    [System.MonoTODOAttribute]
    public void Refresh(System.ComponentModel.IComponent component) { }
    [System.MonoTODOAttribute]
    public bool ShouldAutoShow(System.ComponentModel.IComponent component) { return default(bool); }
    [System.MonoTODOAttribute]
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
    [System.MonoTODOAttribute]
    public virtual System.Collections.ICollection GetCommands(string name) { return default(System.Collections.ICollection); }
  }
  public partial class DesignSurface : System.IDisposable, System.IServiceProvider {
    public DesignSurface() { }
    public DesignSurface(System.IServiceProvider parentProvider) { }
    public DesignSurface(System.IServiceProvider parentProvider, System.Type rootComponentType) { }
    public DesignSurface(System.Type rootComponentType) { }
    public System.ComponentModel.IContainer ComponentContainer { get { return default(System.ComponentModel.IContainer); } }
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
    [System.ObsoleteAttribute("CreateComponent has been replaced by CreateInstance")]
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
  public partial class DesignSurfaceManager : System.IDisposable, System.IServiceProvider {
    public DesignSurfaceManager() { }
    public DesignSurfaceManager(System.IServiceProvider serviceProvider) { }
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
    public object GetService(System.Type service) { return default(object); }
  }
  public enum DisplayMode {
    Ansi = 2,
    Auto = 4,
    Hexdump = 1,
    Unicode = 3,
  }
  public abstract partial class EventBindingService : System.ComponentModel.Design.IEventBindingService {
    protected EventBindingService(System.IServiceProvider provider) { }
    protected abstract string CreateUniqueMethodName(System.ComponentModel.IComponent component, System.ComponentModel.EventDescriptor eventDescriptor);
    protected virtual void FreeMethod(System.ComponentModel.IComponent component, System.ComponentModel.EventDescriptor e, string methodName) { }
    protected abstract System.Collections.ICollection GetCompatibleMethods(System.ComponentModel.EventDescriptor eventDescriptor);
    protected object GetService(System.Type service) { return default(object); }
    protected abstract bool ShowCode();
    protected abstract bool ShowCode(System.ComponentModel.IComponent component, System.ComponentModel.EventDescriptor e, string methodName);
    protected abstract bool ShowCode(int lineNumber);
    string System.ComponentModel.Design.IEventBindingService.CreateUniqueMethodName(System.ComponentModel.IComponent component, System.ComponentModel.EventDescriptor eventDescriptor) { return default(string); }
    System.Collections.ICollection System.ComponentModel.Design.IEventBindingService.GetCompatibleMethods(System.ComponentModel.EventDescriptor eventDescriptor) { return default(System.Collections.ICollection); }
    System.ComponentModel.EventDescriptor System.ComponentModel.Design.IEventBindingService.GetEvent(System.ComponentModel.PropertyDescriptor property) { return default(System.ComponentModel.EventDescriptor); }
    System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.Design.IEventBindingService.GetEventProperties(System.ComponentModel.EventDescriptorCollection events) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    System.ComponentModel.PropertyDescriptor System.ComponentModel.Design.IEventBindingService.GetEventProperty(System.ComponentModel.EventDescriptor eventDescriptor) { return default(System.ComponentModel.PropertyDescriptor); }
    bool System.ComponentModel.Design.IEventBindingService.ShowCode() { return default(bool); }
    bool System.ComponentModel.Design.IEventBindingService.ShowCode(System.ComponentModel.IComponent component, System.ComponentModel.EventDescriptor eventDescriptor) { return default(bool); }
    bool System.ComponentModel.Design.IEventBindingService.ShowCode(int lineNumber) { return default(bool); }
    protected virtual void UseMethod(System.ComponentModel.IComponent component, System.ComponentModel.EventDescriptor e, string methodName) { }
    protected virtual void ValidateMethodName(string methodName) { }
  }
  public sealed partial class ExceptionCollection : System.Exception {
    [System.MonoTODOAttribute]
    public ExceptionCollection(System.Collections.ArrayList exceptions) { }
    public System.Collections.ArrayList Exceptions { get { return default(System.Collections.ArrayList); } }
    [System.MonoTODOAttribute]
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
  public partial class InheritanceService : System.ComponentModel.Design.IInheritanceService, System.IDisposable {
    [System.MonoTODOAttribute]
    public InheritanceService() { }
    [System.MonoTODOAttribute]
    public void AddInheritedComponents(System.ComponentModel.IComponent component, System.ComponentModel.IContainer container) { }
    [System.MonoTODOAttribute]
    protected virtual void AddInheritedComponents(System.Type type, System.ComponentModel.IComponent component, System.ComponentModel.IContainer container) { }
    [System.MonoTODOAttribute]
    public void Dispose() { }
    [System.MonoTODOAttribute]
    protected virtual void Dispose(bool disposing) { }
    [System.MonoTODOAttribute]
    public System.ComponentModel.InheritanceAttribute GetInheritanceAttribute(System.ComponentModel.IComponent component) { return default(System.ComponentModel.InheritanceAttribute); }
    [System.MonoTODOAttribute]
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
  [System.ObsoleteAttribute("use CodeDomLocalizationProvider")]
  public partial class LocalizationExtenderProvider : System.ComponentModel.IExtenderProvider, System.IDisposable {
    [System.MonoTODOAttribute]
    public LocalizationExtenderProvider(System.ComponentModel.ISite serviceProvider, System.ComponentModel.IComponent baseComponent) { }
    [System.MonoTODOAttribute]
    public bool CanExtend(object o) { return default(bool); }
    [System.MonoTODOAttribute]
    public void Dispose() { }
    [System.MonoTODOAttribute]
    protected virtual void Dispose(bool disposing) { }
    [System.ComponentModel.DesignOnlyAttribute(true)]
    [System.ComponentModel.LocalizableAttribute(true)]
    [System.MonoTODOAttribute]
    public System.Globalization.CultureInfo GetLanguage(object o) { return default(System.Globalization.CultureInfo); }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.DesignOnlyAttribute(true)]
    [System.MonoTODOAttribute]
    public System.Globalization.CultureInfo GetLoadLanguage(object o) { return default(System.Globalization.CultureInfo); }
    [System.ComponentModel.DesignOnlyAttribute(true)]
    [System.ComponentModel.LocalizableAttribute(true)]
    [System.MonoTODOAttribute]
    public bool GetLocalizable(object o) { return default(bool); }
    [System.MonoTODOAttribute]
    public void ResetLanguage(object o) { }
    [System.MonoTODOAttribute]
    public void SetLanguage(object o, System.Globalization.CultureInfo language) { }
    [System.MonoTODOAttribute]
    public void SetLocalizable(object o, bool localizable) { }
    [System.MonoTODOAttribute]
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
    public virtual bool GlobalInvoke(System.ComponentModel.Design.CommandID commandID, object arg) { return default(bool); }
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
    [System.MonoTODOAttribute]
    public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { return default(object); }
    public bool EqualsToValue(object value) { return default(bool); }
    [System.MonoTODOAttribute]
    protected virtual void FillTreeWithData(System.ComponentModel.Design.ObjectSelectorEditor.Selector selector, System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider) { }
    public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { return default(System.Drawing.Design.UITypeEditorEditStyle); }
    public virtual void SetValue(object value) { }
    public partial class Selector : System.Windows.Forms.TreeView {
      [System.MonoTODOAttribute]
      public bool clickSeen;
      [System.MonoTODOAttribute]
      public Selector(System.ComponentModel.Design.ObjectSelectorEditor editor) { }
      [System.MonoTODOAttribute]
      public System.ComponentModel.Design.ObjectSelectorEditor.SelectorNode AddNode(string label, object value, System.ComponentModel.Design.ObjectSelectorEditor.SelectorNode parent) { return default(System.ComponentModel.Design.ObjectSelectorEditor.SelectorNode); }
      [System.MonoTODOAttribute]
      public void Clear() { }
      [System.MonoTODOAttribute]
      protected void OnAfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e) { }
      [System.MonoTODOAttribute]
      protected override void OnKeyDown(System.Windows.Forms.KeyEventArgs e) { }
      [System.MonoTODOAttribute]
      protected override void OnKeyPress(System.Windows.Forms.KeyPressEventArgs e) { }
      [System.MonoTODOAttribute]
      protected override void OnNodeMouseClick(System.Windows.Forms.TreeNodeMouseClickEventArgs e) { }
      [System.MonoTODOAttribute]
      public bool SetSelection(object value, System.Windows.Forms.TreeNodeCollection nodes) { return default(bool); }
      [System.MonoTODOAttribute]
      public void Start(System.Windows.Forms.Design.IWindowsFormsEditorService edSvc, object value) { }
      [System.MonoTODOAttribute]
      public void Stop() { }
      [System.MonoTODOAttribute]
      protected override void WndProc(ref System.Windows.Forms.Message m) { }
    }
    public partial class SelectorNode : System.Windows.Forms.TreeNode {
      public object value;
      public SelectorNode(string label, object value) { }
    }
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
      public virtual string Name { get { return default(string); } }
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
    [System.MonoTODOAttribute]
    public System.ComponentModel.Design.Data.DataSourceDescriptor this[int index] { get { return default(System.ComponentModel.Design.Data.DataSourceDescriptor); } set { } }
    [System.MonoTODOAttribute]
    public int Add(System.ComponentModel.Design.Data.DataSourceDescriptor value) { return default(int); }
    [System.MonoTODOAttribute]
    public bool Contains(System.ComponentModel.Design.Data.DataSourceDescriptor value) { return default(bool); }
    [System.MonoTODOAttribute]
    public void CopyTo(System.ComponentModel.Design.Data.DataSourceDescriptor[] array, int index) { }
    [System.MonoTODOAttribute]
    public int IndexOf(System.ComponentModel.Design.Data.DataSourceDescriptor value) { return default(int); }
    [System.MonoTODOAttribute]
    public void Insert(int index, System.ComponentModel.Design.Data.DataSourceDescriptor value) { }
    [System.MonoTODOAttribute]
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
    [System.MonoTODOAttribute]
    public System.ComponentModel.Design.Data.DataSourceGroup this[int index] { get { return default(System.ComponentModel.Design.Data.DataSourceGroup); } set { } }
    [System.MonoTODOAttribute]
    public int Add(System.ComponentModel.Design.Data.DataSourceGroup value) { return default(int); }
    [System.MonoTODOAttribute]
    public bool Contains(System.ComponentModel.Design.Data.DataSourceGroup value) { return default(bool); }
    [System.MonoTODOAttribute]
    public void CopyTo(System.ComponentModel.Design.Data.DataSourceGroup[] array, int index) { }
    [System.MonoTODOAttribute]
    public int IndexOf(System.ComponentModel.Design.Data.DataSourceGroup value) { return default(int); }
    [System.MonoTODOAttribute]
    public void Insert(int index, System.ComponentModel.Design.Data.DataSourceGroup value) { }
    [System.MonoTODOAttribute]
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
    [System.MonoTODOAttribute]
    public DesignerDataColumn(string name, System.Data.DbType dataType) { }
    [System.MonoTODOAttribute]
    public DesignerDataColumn(string name, System.Data.DbType dataType, object defaultValue) { }
    [System.MonoTODOAttribute]
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
    [System.MonoTODOAttribute]
    public DesignerDataConnection(string name, string providerName, string connectionString) { }
    [System.MonoTODOAttribute]
    public DesignerDataConnection(string name, string providerName, string connectionString, bool isConfigured) { }
    [System.MonoTODOAttribute]
    public string ConnectionString { get { return default(string); } }
    [System.MonoTODOAttribute]
    public bool IsConfigured { get { return default(bool); } }
    [System.MonoTODOAttribute]
    public string Name { get { return default(string); } }
    [System.MonoTODOAttribute]
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
    [System.MonoTODOAttribute]
    protected DesignerDataStoredProcedure(string name) { }
    [System.MonoTODOAttribute]
    protected DesignerDataStoredProcedure(string name, string owner) { }
    public string Name { get { return default(string); } }
    public string Owner { get { return default(string); } }
    [System.MonoTODOAttribute]
    public System.Collections.ICollection Parameters { get { return default(System.Collections.ICollection); } }
    protected abstract System.Collections.ICollection CreateParameters();
  }
  public abstract partial class DesignerDataTable : System.ComponentModel.Design.Data.DesignerDataTableBase {
    protected DesignerDataTable(string name) : base (default(string)) { }
    protected DesignerDataTable(string name, string owner) : base (default(string)) { }
    [System.MonoTODOAttribute]
    public System.Collections.ICollection Relationships { get { return default(System.Collections.ICollection); } }
    protected abstract System.Collections.ICollection CreateRelationships();
  }
  public abstract partial class DesignerDataTableBase {
    protected DesignerDataTableBase(string name) { }
    protected DesignerDataTableBase(string name, string owner) { }
    [System.MonoTODOAttribute]
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
      Force = 1,
      ModifyOnError = 2,
      NoFlush = 3,
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
    [System.MonoTODOAttribute]
    public CodeDomLocalizationProvider(System.IServiceProvider provider, System.ComponentModel.Design.Serialization.CodeDomLocalizationModel model) { }
    [System.MonoTODOAttribute]
    public CodeDomLocalizationProvider(System.IServiceProvider provider, System.ComponentModel.Design.Serialization.CodeDomLocalizationModel model, System.Globalization.CultureInfo[] supportedCultures) { }
    [System.MonoTODOAttribute]
    public void Dispose() { }
    [System.MonoTODOAttribute]
    object System.ComponentModel.Design.Serialization.IDesignerSerializationProvider.GetSerializer(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object currentSerializer, System.Type objectType, System.Type serializerType) { return default(object); }
  }
  public partial class CodeDomSerializer : System.ComponentModel.Design.Serialization.CodeDomSerializerBase {
    public CodeDomSerializer() { }
    public virtual object Deserialize(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object codeObject) { return default(object); }
    protected object DeserializeStatementToInstance(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, System.CodeDom.CodeStatement statement) { return default(object); }
    public virtual string GetTargetComponentName(System.CodeDom.CodeStatement statement, System.CodeDom.CodeExpression expression, System.Type targetType) { return default(string); }
    public virtual object Serialize(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object value) { return default(object); }
    public virtual object SerializeAbsolute(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object value) { return default(object); }
    public virtual System.CodeDom.CodeStatementCollection SerializeMember(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object owningobject, System.ComponentModel.MemberDescriptor member) { return default(System.CodeDom.CodeStatementCollection); }
    public virtual System.CodeDom.CodeStatementCollection SerializeMemberAbsolute(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object owningobject, System.ComponentModel.MemberDescriptor member) { return default(System.CodeDom.CodeStatementCollection); }
    [System.ObsoleteAttribute("This method has been deprecated. Use SerializeToExpression or GetExpression instead.")]
    protected System.CodeDom.CodeExpression SerializeToReferenceExpression(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object value) { return default(System.CodeDom.CodeExpression); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public abstract partial class CodeDomSerializerBase {
    internal CodeDomSerializerBase() { }
    protected object DeserializeExpression(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, string name, System.CodeDom.CodeExpression expression) { return default(object); }
    protected virtual object DeserializeInstance(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, System.Type type, System.Object[] parameters, string name, bool addToContainer) { return default(object); }
    protected void DeserializePropertiesFromResources(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object value, System.Attribute[] filter) { }
    protected void DeserializeStatement(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, System.CodeDom.CodeStatement statement) { }
    protected System.CodeDom.CodeExpression GetExpression(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object instance) { return default(System.CodeDom.CodeExpression); }
    protected System.ComponentModel.Design.Serialization.CodeDomSerializer GetSerializer(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object instance) { return default(System.ComponentModel.Design.Serialization.CodeDomSerializer); }
    protected System.ComponentModel.Design.Serialization.CodeDomSerializer GetSerializer(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, System.Type instanceType) { return default(System.ComponentModel.Design.Serialization.CodeDomSerializer); }
    protected string GetUniqueName(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object instance) { return default(string); }
    protected bool IsSerialized(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object value) { return default(bool); }
    protected bool IsSerialized(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object instance, bool honorPreset) { return default(bool); }
    protected System.CodeDom.CodeExpression SerializeCreationExpression(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object value, out bool isComplete) { isComplete = default(bool); return default(System.CodeDom.CodeExpression); }
    protected void SerializeEvent(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, System.CodeDom.CodeStatementCollection statements, object value, System.ComponentModel.EventDescriptor descriptor) { }
    protected void SerializeEvents(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, System.CodeDom.CodeStatementCollection statements, object value, params System.Attribute[] filter) { }
    protected void SerializeProperties(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, System.CodeDom.CodeStatementCollection statements, object value, System.Attribute[] filter) { }
    protected void SerializePropertiesToResources(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, System.CodeDom.CodeStatementCollection statements, object value, System.Attribute[] filter) { }
    protected void SerializeProperty(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, System.CodeDom.CodeStatementCollection statements, object value, System.ComponentModel.PropertyDescriptor propertyToSerialize) { }
    protected void SerializeResource(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, string resourceName, object value) { }
    protected void SerializeResourceInvariant(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, string resourceName, object value) { }
    protected System.CodeDom.CodeExpression SerializeToExpression(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object instance) { return default(System.CodeDom.CodeExpression); }
    protected System.CodeDom.CodeExpression SerializeToResourceExpression(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object value) { return default(System.CodeDom.CodeExpression); }
    protected System.CodeDom.CodeExpression SerializeToResourceExpression(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object value, bool ensureInvariant) { return default(System.CodeDom.CodeExpression); }
    protected void SetExpression(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object instance, System.CodeDom.CodeExpression expression) { }
    protected void SetExpression(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object instance, System.CodeDom.CodeExpression expression, bool isPreset) { }
  }
  public partial class CodeDomSerializerException : System.SystemException {
    public CodeDomSerializerException(System.Exception ex, System.CodeDom.CodeLinePragma linePragma) { }
    [System.MonoTODOAttribute]
    public CodeDomSerializerException(System.Exception ex, System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager) { }
    [System.MonoTODOAttribute]
    protected CodeDomSerializerException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public CodeDomSerializerException(string message, System.CodeDom.CodeLinePragma linePragma) { }
    [System.MonoTODOAttribute]
    public CodeDomSerializerException(string message, System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager) { }
    public System.CodeDom.CodeLinePragma LinePragma { get { return default(System.CodeDom.CodeLinePragma); } }
    [System.MonoTODOAttribute]
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
    public object GetSerializer(System.Type componentType, System.Type serializerType) { return default(object); }
    protected virtual object GetService(System.Type service) { return default(object); }
    protected virtual System.Type GetType(string name) { return default(System.Type); }
    protected virtual void OnResolveName(System.ComponentModel.Design.Serialization.ResolveNameEventArgs e) { }
    protected virtual void OnSessionCreated(System.EventArgs e) { }
    protected virtual void OnSessionDisposed(System.EventArgs e) { }
    void System.ComponentModel.Design.Serialization.IDesignerSerializationManager.AddSerializationProvider(System.ComponentModel.Design.Serialization.IDesignerSerializationProvider provider) { }
    object System.ComponentModel.Design.Serialization.IDesignerSerializationManager.CreateInstance(System.Type type, System.Collections.ICollection arguments, string name, bool addToContainer) { return default(object); }
    object System.ComponentModel.Design.Serialization.IDesignerSerializationManager.GetInstance(string name) { return default(object); }
    string System.ComponentModel.Design.Serialization.IDesignerSerializationManager.GetName(object instance) { return default(string); }
    object System.ComponentModel.Design.Serialization.IDesignerSerializationManager.GetSerializer(System.Type type, System.Type serializerType) { return default(object); }
    System.Type System.ComponentModel.Design.Serialization.IDesignerSerializationManager.GetType(string name) { return default(System.Type); }
    void System.ComponentModel.Design.Serialization.IDesignerSerializationManager.RemoveSerializationProvider(System.ComponentModel.Design.Serialization.IDesignerSerializationProvider provider) { }
    void System.ComponentModel.Design.Serialization.IDesignerSerializationManager.ReportError(object error) { }
    void System.ComponentModel.Design.Serialization.IDesignerSerializationManager.SetName(object instance, string name) { }
    object System.IServiceProvider.GetService(System.Type service) { return default(object); }
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
    public System.CodeDom.CodeStatementCollection this[object owner] { get { return default(System.CodeDom.CodeStatementCollection); } }
    public bool ContainsKey(object statementOwner) { return default(bool); }
    public System.Collections.IDictionaryEnumerator GetEnumerator() { return default(System.Collections.IDictionaryEnumerator); }
    public void Populate(System.Collections.ICollection statementOwners) { }
    public void Populate(object owner) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public sealed partial class RootContext {
    public RootContext(System.CodeDom.CodeExpression expresion, object value) { }
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
    [System.MonoTODOAttribute]
    public System.CodeDom.Compiler.CodeDomProvider CodeProvider { get { return default(System.CodeDom.Compiler.CodeDomProvider); } set { } }
    [System.MonoTODOAttribute]
    public System.Type ContainerParameterType { get { return default(System.Type); } set { } }
    [System.MonoTODOAttribute]
    public string DataSetClassName { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public bool IsGetMethod { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public bool PagingMethod { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public System.Data.Design.ParameterGenerationOption ParameterOption { get { return default(System.Data.Design.ParameterGenerationOption); } set { } }
    [System.MonoTODOAttribute]
    public string TableClassName { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public System.CodeDom.CodeMemberMethod GenerateMethod() { return default(System.CodeDom.CodeMemberMethod); }
    [System.MonoTODOAttribute]
    public string GenerateMethodSignature() { return default(string); }
    [System.MonoTODOAttribute]
    public System.CodeDom.CodeTypeDeclaration GenerateUpdatingMethods() { return default(System.CodeDom.CodeTypeDeclaration); }
    [System.MonoTODOAttribute]
    public void SetDesignTableContent(string designTableContent) { }
    [System.MonoTODOAttribute]
    public void SetMethodSourceContent(string methodSourceContent) { }
  }
  public enum ParameterGenerationOption {
    ClrTypes = 0,
    Objects = 2,
    SqlTypes = 1,
  }
  public sealed partial class TypedDataSetGenerator {
    internal TypedDataSetGenerator() { }
    [System.MonoTODOAttribute]
    public static System.Collections.Generic.ICollection<System.Reflection.Assembly> ReferencedAssemblies { get { return default(System.Collections.Generic.ICollection<System.Reflection.Assembly>); } }
    public static string Generate(System.Data.DataSet dataSet, System.CodeDom.CodeNamespace codeNamespace, System.CodeDom.Compiler.CodeDomProvider codeProvider) { return default(string); }
    public static string Generate(string inputFileContent, System.CodeDom.CodeCompileUnit compileUnit, System.CodeDom.CodeNamespace mainNamespace, System.CodeDom.Compiler.CodeDomProvider codeProvider) { return default(string); }
    [System.MonoTODOAttribute]
    public static void Generate(string inputFileContent, System.CodeDom.CodeCompileUnit compileUnit, System.CodeDom.CodeNamespace mainNamespace, System.CodeDom.Compiler.CodeDomProvider codeProvider, System.Collections.Hashtable customDBProviders) { }
    [System.MonoTODOAttribute]
    public static void Generate(string inputFileContent, System.CodeDom.CodeCompileUnit compileUnit, System.CodeDom.CodeNamespace mainNamespace, System.CodeDom.Compiler.CodeDomProvider codeProvider, System.Collections.Hashtable customDBProviders, System.Data.Design.TypedDataSetGenerator.GenerateOption option) { }
    [System.MonoTODOAttribute]
    public static void Generate(string inputFileContent, System.CodeDom.CodeCompileUnit compileUnit, System.CodeDom.CodeNamespace mainNamespace, System.CodeDom.Compiler.CodeDomProvider codeProvider, System.Data.Common.DbProviderFactory specifiedFactory) { }
    [System.MonoTODOAttribute]
    public static string Generate(string inputFileContent, System.CodeDom.CodeCompileUnit compileUnit, System.CodeDom.CodeNamespace mainNamespace, System.CodeDom.Compiler.CodeDomProvider codeProvider, System.Data.Design.TypedDataSetGenerator.GenerateOption option) { return default(string); }
    [System.MonoTODOAttribute]
    public static string GetProviderName(string inputFileContent) { return default(string); }
    [System.MonoTODOAttribute]
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
    public TypedDataSetGeneratorException(string error) { }
    public TypedDataSetGeneratorException(string error, System.Exception inner) { }
    public System.Collections.IList ErrorList { get { return default(System.Collections.IList); } }
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial class TypedDataSetSchemaImporterExtension : System.Xml.Serialization.Advanced.SchemaImporterExtension {
    public TypedDataSetSchemaImporterExtension() { }
    protected TypedDataSetSchemaImporterExtension(System.Data.Design.TypedDataSetGenerator.GenerateOption dataSetGenerateOptions) { }
    [System.MonoTODOAttribute]
    public override string ImportSchemaType(string name, string namespaceName, System.Xml.Schema.XmlSchemaObject context, System.Xml.Serialization.XmlSchemas schemas, System.Xml.Serialization.XmlSchemaImporter importer, System.CodeDom.CodeCompileUnit compileUnit, System.CodeDom.CodeNamespace mainNamespace, System.Xml.Serialization.CodeGenerationOptions options, System.CodeDom.Compiler.CodeDomProvider codeProvider) { return default(string); }
    [System.MonoTODOAttribute]
    public override string ImportSchemaType(System.Xml.Schema.XmlSchemaType type, System.Xml.Schema.XmlSchemaObject context, System.Xml.Serialization.XmlSchemas schemas, System.Xml.Serialization.XmlSchemaImporter importer, System.CodeDom.CodeCompileUnit compileUnit, System.CodeDom.CodeNamespace mainNamespace, System.Xml.Serialization.CodeGenerationOptions options, System.CodeDom.Compiler.CodeDomProvider codeProvider) { return default(string); }
  }
}
namespace System.Diagnostics.Design {
  public partial class LogConverter : System.ComponentModel.TypeConverter {
    public LogConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    [System.MonoTODOAttribute]
    public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { return default(System.ComponentModel.TypeConverter.StandardValuesCollection); }
    public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
  }
  public partial class ProcessDesigner : System.ComponentModel.Design.ComponentDesigner {
    public ProcessDesigner() { }
    [System.MonoTODOAttribute]
    protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
  }
  public partial class ProcessModuleDesigner : System.ComponentModel.Design.ComponentDesigner {
    public ProcessModuleDesigner() { }
    [System.MonoTODOAttribute]
    protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
  }
  public partial class ProcessThreadDesigner : System.ComponentModel.Design.ComponentDesigner {
    public ProcessThreadDesigner() { }
    [System.MonoTODOAttribute]
    protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
  }
}
namespace System.Messaging.Design {
  public partial class MessageDesigner : System.ComponentModel.Design.ComponentDesigner {
    public MessageDesigner() { }
    [System.MonoTODOAttribute]
    protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
  }
}
namespace System.Resources.Tools {
  public static partial class StronglyTypedResourceBuilder {
    public static System.CodeDom.CodeCompileUnit Create(System.Collections.IDictionary resourceList, string baseName, string generatedCodeNamespace, System.CodeDom.Compiler.CodeDomProvider codeProvider, bool internalClass, out System.String[] unmatchable) { unmatchable = default(System.String[]); return default(System.CodeDom.CodeCompileUnit); }
    public static System.CodeDom.CodeCompileUnit Create(System.Collections.IDictionary resourceList, string baseName, string generatedCodeNamespace, string resourcesNamespace, System.CodeDom.Compiler.CodeDomProvider codeProvider, bool internalClass, out System.String[] unmatchable) { unmatchable = default(System.String[]); return default(System.CodeDom.CodeCompileUnit); }
    public static System.CodeDom.CodeCompileUnit Create(string resxFile, string baseName, string generatedCodeNamespace, System.CodeDom.Compiler.CodeDomProvider codeProvider, bool internalClass, out System.String[] unmatchable) { unmatchable = default(System.String[]); return default(System.CodeDom.CodeCompileUnit); }
    public static System.CodeDom.CodeCompileUnit Create(string resxFile, string baseName, string generatedCodeNamespace, string resourcesNamespace, System.CodeDom.Compiler.CodeDomProvider codeProvider, bool internalClass, out System.String[] unmatchable) { unmatchable = default(System.String[]); return default(System.CodeDom.CodeCompileUnit); }
    public static string VerifyResourceName(string key, System.CodeDom.Compiler.CodeDomProvider provider) { return default(string); }
  }
}
namespace System.ServiceProcess.Design {
  public partial class ServiceControllerDesigner : System.ComponentModel.Design.ComponentDesigner {
    public ServiceControllerDesigner() { }
    [System.MonoTODOAttribute]
    protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
  }
}
namespace System.Web.UI.Design {
  public partial class AppSettingsExpressionEditor : System.Web.UI.Design.ExpressionEditor {
    public AppSettingsExpressionEditor() { }
    public override object EvaluateExpression(string expression, object parseTimeData, System.Type propertyType, System.IServiceProvider serviceProvider) { return default(object); }
    public override System.Web.UI.Design.ExpressionEditorSheet GetExpressionEditorSheet(string expression, System.IServiceProvider serviceProvider) { return default(System.Web.UI.Design.ExpressionEditorSheet); }
  }
  public partial class CalendarDataBindingHandler : System.Web.UI.Design.DataBindingHandler {
    public CalendarDataBindingHandler() { }
    [System.MonoTODOAttribute]
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
  public sealed partial class ColorBuilder {
    internal ColorBuilder() { }
    [System.MonoTODOAttribute]
    public static string BuildColor(System.ComponentModel.IComponent component, System.Windows.Forms.Control owner, string initialColor) { return default(string); }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class ConnectionStringEditor : System.Drawing.Design.UITypeEditor {
    public ConnectionStringEditor() { }
    [System.MonoTODOAttribute]
    public virtual new object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { return default(object); }
    [System.MonoTODOAttribute]
    public virtual new System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { return default(System.Drawing.Design.UITypeEditorEditStyle); }
    [System.MonoTODOAttribute]
    protected virtual string GetProviderName(object instance) { return default(string); }
    [System.MonoTODOAttribute]
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
    [System.MonoTODOAttribute]
    public override bool AllowResize { get { return default(bool); } }
    [System.MonoTODOAttribute]
    public virtual string FrameCaption { get { return default(string); } }
    [System.MonoTODOAttribute]
    public virtual System.Web.UI.WebControls.Style FrameStyle { get { return default(System.Web.UI.WebControls.Style); } }
    [System.MonoTODOAttribute]
    protected virtual void AddDesignTimeCssAttributes(System.Collections.IDictionary styleAttributes) { }
    [System.MonoTODOAttribute]
    public virtual System.Collections.IDictionary GetDesignTimeCssAttributes() { return default(System.Collections.IDictionary); }
    [System.MonoTODOAttribute]
    public override string GetDesignTimeHtml(System.Web.UI.Design.DesignerRegionCollection regions) { return default(string); }
    [System.MonoTODOAttribute]
    public override string GetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region) { return default(string); }
    [System.MonoTODOAttribute]
    public override string GetPersistenceContent() { return default(string); }
    [System.MonoTODOAttribute]
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
  [System.MonoTODOAttribute]
  public partial class ControlDesigner : System.Web.UI.Design.HtmlControlDesigner {
    public ControlDesigner() { }
    [System.MonoNotSupportedAttribute("")]
    public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { return default(System.ComponentModel.Design.DesignerActionListCollection); } }
    [System.MonoTODOAttribute]
    public virtual bool AllowResize { get { return default(bool); } }
    [System.MonoNotSupportedAttribute("")]
    public virtual System.Web.UI.Design.DesignerAutoFormatCollection AutoFormats { get { return default(System.Web.UI.Design.DesignerAutoFormatCollection); } }
    [System.MonoNotSupportedAttribute("")]
    protected virtual bool DataBindingsEnabled { get { return default(bool); } }
    [System.MonoNotSupportedAttribute("")]
    protected System.Web.UI.Design.ControlDesignerState DesignerState { [System.MonoNotSupportedAttribute("")]get { return default(System.Web.UI.Design.ControlDesignerState); } }
    [System.MonoTODOAttribute]
    [System.ObsoleteAttribute("It is documented as not in use anymore", true)]
    protected object DesignTimeElementView { get { return default(object); } }
    [System.MonoTODOAttribute]
    [System.ObsoleteAttribute("Use SetViewFlags(ViewFlags.DesignTimeHtmlRequiresLoadComplete, true)")]
    public virtual bool DesignTimeHtmlRequiresLoadComplete { get { return default(bool); } }
    [System.MonoNotSupportedAttribute("")]
    protected internal virtual bool HidePropertiesInTemplateMode { get { return default(bool); } }
    [System.MonoTODOAttribute]
    public virtual string ID { get { return default(string); } set { } }
    [System.MonoNotSupportedAttribute("")]
    public bool InTemplateMode { get { return default(bool); } }
    [System.MonoTODOAttribute]
    [System.ObsoleteAttribute("Use Tag.SetDirty() and Tag.IsDirty instead.")]
    public bool IsDirty { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    [System.ObsoleteAttribute("Use ContainerControlDesigner and EditableDesignerRegion")]
    public bool ReadOnly { get { return default(bool); } set { } }
    [System.MonoNotSupportedAttribute("")]
    protected System.Web.UI.Design.WebFormsRootDesigner RootDesigner { get { return default(System.Web.UI.Design.WebFormsRootDesigner); } }
    [System.MonoNotSupportedAttribute("")]
    protected System.Web.UI.Design.IControlDesignerTag Tag { get { return default(System.Web.UI.Design.IControlDesignerTag); } }
    [System.MonoNotSupportedAttribute("")]
    public virtual System.Web.UI.Design.TemplateGroupCollection TemplateGroups { [System.MonoNotSupportedAttribute("")]get { return default(System.Web.UI.Design.TemplateGroupCollection); } }
    [System.MonoNotSupportedAttribute("")]
    protected virtual bool UsePreviewControl { get { return default(bool); } }
    [System.MonoNotSupportedAttribute("")]
    public System.Web.UI.Control ViewControl { [System.MonoNotSupportedAttribute("")]get { return default(System.Web.UI.Control); } [System.MonoNotSupportedAttribute("")]set { } }
    [System.MonoNotSupportedAttribute("")]
    public virtual bool ViewControlCreated { [System.MonoNotSupportedAttribute("")]get { return default(bool); } [System.MonoNotSupportedAttribute("")]set { } }
    [System.MonoNotSupportedAttribute("")]
    protected string CreateErrorDesignTimeHtml(string errorMessage) { return default(string); }
    [System.MonoNotSupportedAttribute("")]
    protected string CreateErrorDesignTimeHtml(string errorMessage, System.Exception e) { return default(string); }
    [System.MonoTODOAttribute]
    protected string CreatePlaceHolderDesignTimeHtml() { return default(string); }
    [System.MonoTODOAttribute]
    protected string CreatePlaceHolderDesignTimeHtml(string instruction) { return default(string); }
    [System.MonoNotSupportedAttribute("")]
    protected virtual System.Web.UI.Control CreateViewControl() { return default(System.Web.UI.Control); }
    [System.MonoNotSupportedAttribute("")]
    public System.Drawing.Rectangle GetBounds() { return default(System.Drawing.Rectangle); }
    [System.MonoTODOAttribute]
    public virtual string GetDesignTimeHtml() { return default(string); }
    [System.MonoNotSupportedAttribute("")]
    public virtual string GetDesignTimeHtml(System.Web.UI.Design.DesignerRegionCollection regions) { return default(string); }
    [System.MonoNotSupportedAttribute("")]
    public static System.Web.UI.Design.DesignTimeResourceProviderFactory GetDesignTimeResourceProviderFactory(System.IServiceProvider serviceProvider) { return default(System.Web.UI.Design.DesignTimeResourceProviderFactory); }
    [System.MonoNotSupportedAttribute("")]
    public virtual string GetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region) { return default(string); }
    [System.MonoTODOAttribute]
    protected virtual string GetEmptyDesignTimeHtml() { return default(string); }
    [System.MonoTODOAttribute]
    protected virtual string GetErrorDesignTimeHtml(System.Exception e) { return default(string); }
    [System.MonoNotSupportedAttribute("")]
    public virtual string GetPersistenceContent() { return default(string); }
    [System.MonoTODOAttribute]
    [System.ObsoleteAttribute("Use GetPersistenceContent() instead")]
    public virtual string GetPersistInnerHtml() { return default(string); }
    [System.MonoNotSupportedAttribute("")]
    public System.Web.UI.Design.ViewRendering GetViewRendering() { return default(System.Web.UI.Design.ViewRendering); }
    [System.MonoNotSupportedAttribute("")]
    public static System.Web.UI.Design.ViewRendering GetViewRendering(System.Web.UI.Control control) { return default(System.Web.UI.Design.ViewRendering); }
    [System.MonoNotSupportedAttribute("")]
    public static System.Web.UI.Design.ViewRendering GetViewRendering(System.Web.UI.Design.ControlDesigner designer) { return default(System.Web.UI.Design.ViewRendering); }
    [System.MonoTODOAttribute]
    public override void Initialize(System.ComponentModel.IComponent component) { }
    [System.MonoTODOAttribute]
    public void Invalidate() { }
    [System.MonoTODOAttribute]
    public void Invalidate(System.Drawing.Rectangle rectangle) { }
    [System.MonoTODOAttribute]
    public static void InvokeTransactedChange(System.ComponentModel.IComponent component, System.Web.UI.Design.TransactedChangeCallback callback, object context, string description) { }
    [System.MonoTODOAttribute]
    public static void InvokeTransactedChange(System.ComponentModel.IComponent component, System.Web.UI.Design.TransactedChangeCallback callback, object context, string description, System.ComponentModel.MemberDescriptor member) { }
    [System.MonoTODOAttribute]
    public static void InvokeTransactedChange(System.IServiceProvider serviceProvider, System.ComponentModel.IComponent component, System.Web.UI.Design.TransactedChangeCallback callback, object context, string description, System.ComponentModel.MemberDescriptor member) { }
    [System.MonoTODOAttribute]
    [System.ObsoleteAttribute("Use DataBindings.Contains(string) instead")]
    public bool IsPropertyBound(string propName) { return default(bool); }
    [System.MonoTODOAttribute]
    public void Localize(System.Web.UI.Design.IDesignTimeResourceWriter resourceWriter) { }
    [System.MonoTODOAttribute]
    public virtual void OnAutoFormatApplied(System.Web.UI.Design.DesignerAutoFormat appliedAutoFormat) { }
    [System.MonoTODOAttribute]
    [System.ObsoleteAttribute("Use DataBindings.Changed event instead")]
    protected override void OnBindingsCollectionChanged(string propName) { }
    [System.MonoTODOAttribute]
    protected virtual void OnClick(System.Web.UI.Design.DesignerRegionMouseEventArgs e) { }
    [System.MonoTODOAttribute]
    public virtual void OnComponentChanged(object sender, System.ComponentModel.Design.ComponentChangedEventArgs ce) { }
    [System.MonoTODOAttribute]
    public virtual void OnComponentChanging(object sender, System.ComponentModel.Design.ComponentChangingEventArgs ce) { }
    [System.MonoTODOAttribute]
    [System.ObsoleteAttribute("Use OnComponentChanged() instead")]
    protected virtual void OnControlResize() { }
    [System.MonoTODOAttribute]
    protected virtual void OnPaint(System.Windows.Forms.PaintEventArgs e) { }
    [System.MonoTODOAttribute]
    protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
    [System.MonoTODOAttribute]
    [System.ObsoleteAttribute("Use OnComponentChanged() instead")]
    public void RaiseResizeEvent() { }
    [System.MonoTODOAttribute]
    public void RegisterClone(object original, object clone) { }
    [System.MonoNotSupportedAttribute("")]
    public virtual void SetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region, string content) { }
    [System.MonoTODOAttribute]
    protected void SetRegionContent(System.Web.UI.Design.EditableDesignerRegion region, string content) { }
    [System.MonoNotSupportedAttribute("")]
    protected void SetViewFlags(System.Web.UI.Design.ViewFlags viewFlags, bool setFlag) { }
    [System.MonoTODOAttribute]
    public virtual void UpdateDesignTimeHtml() { }
  }
  public sealed partial class ControlDesignerState {
    internal ControlDesignerState() { }
    [System.MonoNotSupportedAttribute("")]
    public object this[string key] { [System.MonoNotSupportedAttribute("")]get { return default(object); } [System.MonoNotSupportedAttribute("")]set { } }
  }
  public enum ControlLocation {
    After = 1,
    Before = 0,
    First = 2,
    FirstChild = 4,
    Last = 3,
    LastChild = 5,
  }
  public sealed partial class ControlParser {
    internal ControlParser() { }
    [System.MonoTODOAttribute]
    public static System.Web.UI.Control ParseControl(System.ComponentModel.Design.IDesignerHost designerHost, string controlText) { return default(System.Web.UI.Control); }
    [System.MonoTODOAttribute]
    public static System.Web.UI.Control ParseControl(System.ComponentModel.Design.IDesignerHost designerHost, string controlText, string directives) { return default(System.Web.UI.Control); }
    [System.MonoTODOAttribute]
    public static System.Web.UI.Control[] ParseControls(System.ComponentModel.Design.IDesignerHost designerHost, string controlText) { return default(System.Web.UI.Control[]); }
    [System.MonoTODOAttribute]
    public static System.Web.UI.ITemplate ParseTemplate(System.ComponentModel.Design.IDesignerHost designerHost, string templateText) { return default(System.Web.UI.ITemplate); }
    [System.MonoTODOAttribute]
    public static System.Web.UI.ITemplate ParseTemplate(System.ComponentModel.Design.IDesignerHost designerHost, string templateText, string directives) { return default(System.Web.UI.ITemplate); }
  }
  public sealed partial class ControlPersister {
    internal ControlPersister() { }
    [System.MonoTODOAttribute]
    public static void PersistControl(System.IO.TextWriter sw, System.Web.UI.Control control) { }
    [System.MonoTODOAttribute]
    public static void PersistControl(System.IO.TextWriter sw, System.Web.UI.Control control, System.ComponentModel.Design.IDesignerHost host) { }
    [System.MonoTODOAttribute]
    public static string PersistControl(System.Web.UI.Control control) { return default(string); }
    [System.MonoTODOAttribute]
    public static string PersistControl(System.Web.UI.Control control, System.ComponentModel.Design.IDesignerHost host) { return default(string); }
    [System.MonoTODOAttribute]
    public static void PersistInnerProperties(System.IO.TextWriter sw, object component, System.ComponentModel.Design.IDesignerHost host) { }
    [System.MonoTODOAttribute]
    public static string PersistInnerProperties(object component, System.ComponentModel.Design.IDesignerHost host) { return default(string); }
    [System.MonoNotSupportedAttribute("")]
    public static void PersistTemplate(System.IO.TextWriter writer, System.Web.UI.ITemplate template, System.ComponentModel.Design.IDesignerHost host) { }
    [System.MonoNotSupportedAttribute("")]
    public static string PersistTemplate(System.Web.UI.ITemplate template, System.ComponentModel.Design.IDesignerHost host) { return default(string); }
  }
  [System.ObsoleteAttribute("This class is not supposed to be in use anymore as DesignerActionList is supposed to be used for editing DataBinding")]
  public partial class DataBindingCollectionConverter : System.ComponentModel.TypeConverter {
    public DataBindingCollectionConverter() { }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
  }
  [System.ObsoleteAttribute("This class is not supposed to be in use anymore as DesignerActionList is supposed to be used for editing DataBinding")]
  public partial class DataBindingCollectionEditor : System.Drawing.Design.UITypeEditor {
    public DataBindingCollectionEditor() { }
    [System.MonoTODOAttribute]
    public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { return default(object); }
    public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { return default(System.Drawing.Design.UITypeEditorEditStyle); }
  }
  public abstract partial class DataBindingHandler {
    protected DataBindingHandler() { }
    public abstract void DataBindControl(System.ComponentModel.Design.IDesignerHost designerHost, System.Web.UI.Control control);
  }
  public partial class DataBindingValueUIHandler {
    public DataBindingValueUIHandler() { }
    [System.MonoTODOAttribute]
    public void OnGetUIValueItem(System.ComponentModel.ITypeDescriptorContext context, System.ComponentModel.PropertyDescriptor propDesc, System.Collections.ArrayList valueUIItemList) { }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class DataColumnSelectionConverter : System.ComponentModel.TypeConverter {
    public DataColumnSelectionConverter() { }
    [System.MonoTODOAttribute]
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    [System.MonoTODOAttribute]
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    [System.MonoTODOAttribute]
    public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { return default(System.ComponentModel.TypeConverter.StandardValuesCollection); }
    [System.MonoTODOAttribute]
    public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    [System.MonoTODOAttribute]
    public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
  }
  public partial class DataFieldConverter : System.ComponentModel.TypeConverter {
    public DataFieldConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    [System.MonoTODOAttribute]
    public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { return default(System.ComponentModel.TypeConverter.StandardValuesCollection); }
    public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
  }
  public partial class DataMemberConverter : System.ComponentModel.TypeConverter {
    public DataMemberConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    [System.MonoTODOAttribute]
    public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { return default(System.ComponentModel.TypeConverter.StandardValuesCollection); }
    public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
  }
  public sealed partial class DataSetFieldSchema : System.Web.UI.Design.IDataSourceFieldSchema {
    [System.MonoTODOAttribute]
    public DataSetFieldSchema(System.Data.DataColumn column) { }
    [System.MonoTODOAttribute]
    public System.Type DataType { get { return default(System.Type); } }
    [System.MonoTODOAttribute]
    public bool Identity { get { return default(bool); } }
    [System.MonoTODOAttribute]
    public bool IsReadOnly { get { return default(bool); } }
    [System.MonoTODOAttribute]
    public bool IsUnique { get { return default(bool); } }
    [System.MonoTODOAttribute]
    public int Length { get { return default(int); } }
    [System.MonoTODOAttribute]
    public string Name { get { return default(string); } }
    [System.MonoTODOAttribute]
    public bool Nullable { get { return default(bool); } }
    [System.MonoTODOAttribute]
    public int Precision { get { return default(int); } }
    [System.MonoTODOAttribute]
    public bool PrimaryKey { get { return default(bool); } }
    [System.MonoTODOAttribute]
    public int Scale { get { return default(int); } }
  }
  public sealed partial class DataSetSchema : System.Web.UI.Design.IDataSourceSchema {
    [System.MonoTODOAttribute]
    public DataSetSchema(System.Data.DataSet dataSet) { }
    [System.MonoTODOAttribute]
    public System.Web.UI.Design.IDataSourceViewSchema[] GetViews() { return default(System.Web.UI.Design.IDataSourceViewSchema[]); }
  }
  public sealed partial class DataSetViewSchema : System.Web.UI.Design.IDataSourceViewSchema {
    [System.MonoTODOAttribute]
    public DataSetViewSchema(System.Data.DataTable dataTable) { }
    [System.MonoTODOAttribute]
    public string Name { get { return default(string); } }
    [System.MonoTODOAttribute]
    public System.Web.UI.Design.IDataSourceViewSchema[] GetChildren() { return default(System.Web.UI.Design.IDataSourceViewSchema[]); }
    [System.MonoTODOAttribute]
    public System.Web.UI.Design.IDataSourceFieldSchema[] GetFields() { return default(System.Web.UI.Design.IDataSourceFieldSchema[]); }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class DataSourceBooleanViewSchemaConverter : System.Web.UI.Design.DataSourceViewSchemaConverter {
    public DataSourceBooleanViewSchemaConverter() { }
    [System.MonoTODOAttribute]
    public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { return default(System.ComponentModel.TypeConverter.StandardValuesCollection); }
  }
  public partial class DataSourceConverter : System.ComponentModel.TypeConverter {
    public DataSourceConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    [System.MonoTODOAttribute]
    public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { return default(System.ComponentModel.TypeConverter.StandardValuesCollection); }
    public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    [System.MonoTODOAttribute]
    protected virtual bool IsValidDataSource(System.ComponentModel.IComponent component) { return default(bool); }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class DataSourceDesigner : System.Web.UI.Design.ControlDesigner, System.Web.UI.Design.IDataSourceDesigner {
    public DataSourceDesigner() { }
    [System.MonoTODOAttribute]
    public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { return default(System.ComponentModel.Design.DesignerActionListCollection); } }
    [System.MonoTODOAttribute]
    public virtual bool CanConfigure { get { return default(bool); } }
    [System.MonoTODOAttribute]
    public virtual bool CanRefreshSchema { get { return default(bool); } }
    [System.MonoTODOAttribute]
    protected bool SuppressingDataSourceEvents { get { return default(bool); } }
    public event System.EventHandler DataSourceChanged { add { } remove { } }
    public event System.EventHandler SchemaRefreshed { add { } remove { } }
    [System.MonoTODOAttribute]
    public virtual void Configure() { }
    [System.MonoTODOAttribute]
    public override string GetDesignTimeHtml() { return default(string); }
    [System.MonoTODOAttribute]
    public virtual System.Web.UI.Design.DesignerDataSourceView GetView(string viewName) { return default(System.Web.UI.Design.DesignerDataSourceView); }
    [System.MonoTODOAttribute]
    public virtual System.String[] GetViewNames() { return default(System.String[]); }
    protected virtual void OnDataSourceChanged(System.EventArgs e) { }
    protected virtual void OnSchemaRefreshed(System.EventArgs e) { }
    [System.MonoTODOAttribute]
    public virtual void RefreshSchema(bool preferSilent) { }
    [System.MonoTODOAttribute]
    public virtual void ResumeDataSourceEvents() { }
    [System.MonoTODOAttribute]
    public static bool SchemasEquivalent(System.Web.UI.Design.IDataSourceSchema schema1, System.Web.UI.Design.IDataSourceSchema schema2) { return default(bool); }
    [System.MonoTODOAttribute]
    public virtual void SuppressDataSourceEvents() { }
    [System.MonoTODOAttribute]
    public static bool ViewSchemasEquivalent(System.Web.UI.Design.IDataSourceViewSchema viewSchema1, System.Web.UI.Design.IDataSourceViewSchema viewSchema2) { return default(bool); }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class DataSourceViewSchemaConverter : System.ComponentModel.TypeConverter {
    public DataSourceViewSchemaConverter() { }
    [System.MonoTODOAttribute]
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    [System.MonoTODOAttribute]
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    [System.MonoTODOAttribute]
    public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { return default(System.ComponentModel.TypeConverter.StandardValuesCollection); }
    [System.MonoTODOAttribute]
    public virtual System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context, System.Type typeFilter) { return default(System.ComponentModel.TypeConverter.StandardValuesCollection); }
    [System.MonoTODOAttribute]
    public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    [System.MonoTODOAttribute]
    public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
  }
  public abstract partial class DesignerAutoFormat {
    protected DesignerAutoFormat(string name) { }
    [System.MonoTODOAttribute]
    public string Name { get { return default(string); } }
    [System.MonoTODOAttribute]
    public System.Web.UI.Design.DesignerAutoFormatStyle Style { get { return default(System.Web.UI.Design.DesignerAutoFormatStyle); } }
    public abstract void Apply(System.Web.UI.Control control);
    [System.MonoTODOAttribute]
    public virtual System.Web.UI.Control GetPreviewControl(System.Web.UI.Control runtimeControl) { return default(System.Web.UI.Control); }
    [System.MonoTODOAttribute]
    public override string ToString() { return default(string); }
  }
  public sealed partial class DesignerAutoFormatCollection : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList {
    public DesignerAutoFormatCollection() { }
    [System.MonoTODOAttribute]
    public int Count { get { return default(int); } }
    [System.MonoTODOAttribute]
    public System.Web.UI.Design.DesignerAutoFormat this[int index] { get { return default(System.Web.UI.Design.DesignerAutoFormat); } }
    [System.MonoTODOAttribute]
    public System.Drawing.Size PreviewSize { get { return default(System.Drawing.Size); } }
    [System.MonoTODOAttribute]
    public object SyncRoot { get { return default(object); } }
    [System.MonoTODOAttribute]
    int System.Collections.ICollection.Count { get { return default(int); } }
    [System.MonoTODOAttribute]
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    [System.MonoTODOAttribute]
    bool System.Collections.IList.IsFixedSize { get { return default(bool); } }
    [System.MonoTODOAttribute]
    bool System.Collections.IList.IsReadOnly { get { return default(bool); } }
    [System.MonoTODOAttribute]
    object System.Collections.IList.this[int index] { get { return default(object); } set { } }
    [System.MonoTODOAttribute]
    public int Add(System.Web.UI.Design.DesignerAutoFormat format) { return default(int); }
    [System.MonoTODOAttribute]
    public void Clear() { }
    [System.MonoTODOAttribute]
    public bool Contains(System.Web.UI.Design.DesignerAutoFormat format) { return default(bool); }
    [System.MonoTODOAttribute]
    public int IndexOf(System.Web.UI.Design.DesignerAutoFormat format) { return default(int); }
    [System.MonoTODOAttribute]
    public void Insert(int index, System.Web.UI.Design.DesignerAutoFormat format) { }
    [System.MonoTODOAttribute]
    public void Remove(System.Web.UI.Design.DesignerAutoFormat format) { }
    [System.MonoTODOAttribute]
    public void RemoveAt(int index) { }
    [System.MonoTODOAttribute]
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    [System.MonoTODOAttribute]
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    [System.MonoTODOAttribute]
    int System.Collections.IList.Add(object item) { return default(int); }
    [System.MonoTODOAttribute]
    bool System.Collections.IList.Contains(object item) { return default(bool); }
    [System.MonoTODOAttribute]
    int System.Collections.IList.IndexOf(object item) { return default(int); }
    [System.MonoTODOAttribute]
    void System.Collections.IList.Insert(int index, object item) { }
    [System.MonoTODOAttribute]
    void System.Collections.IList.Remove(object item) { }
    [System.MonoTODOAttribute]
    void System.Collections.IList.RemoveAt(int index) { }
  }
  public partial class DesignerAutoFormatStyle : System.Web.UI.WebControls.Style {
    public DesignerAutoFormatStyle() { }
    [System.MonoTODOAttribute]
    public System.Web.UI.WebControls.VerticalAlign VerticalAlign { get { return default(System.Web.UI.WebControls.VerticalAlign); } set { } }
  }
  public abstract partial class DesignerDataSourceView {
    [System.MonoNotSupportedAttribute("")]
    protected DesignerDataSourceView(System.Web.UI.Design.IDataSourceDesigner owner, string viewName) { }
    [System.MonoNotSupportedAttribute("")]
    public virtual bool CanDelete { [System.MonoNotSupportedAttribute("")]get { return default(bool); } }
    [System.MonoNotSupportedAttribute("")]
    public virtual bool CanInsert { [System.MonoNotSupportedAttribute("")]get { return default(bool); } }
    [System.MonoNotSupportedAttribute("")]
    public virtual bool CanPage { [System.MonoNotSupportedAttribute("")]get { return default(bool); } }
    [System.MonoNotSupportedAttribute("")]
    public virtual bool CanRetrieveTotalRowCount { [System.MonoNotSupportedAttribute("")]get { return default(bool); } }
    [System.MonoNotSupportedAttribute("")]
    public virtual bool CanSort { [System.MonoNotSupportedAttribute("")]get { return default(bool); } }
    [System.MonoNotSupportedAttribute("")]
    public virtual bool CanUpdate { [System.MonoNotSupportedAttribute("")]get { return default(bool); } }
    [System.MonoNotSupportedAttribute("")]
    public System.Web.UI.Design.IDataSourceDesigner DataSourceDesigner { [System.MonoNotSupportedAttribute("")]get { return default(System.Web.UI.Design.IDataSourceDesigner); } }
    [System.MonoNotSupportedAttribute("")]
    public string Name { [System.MonoNotSupportedAttribute("")]get { return default(string); } }
    [System.MonoNotSupportedAttribute("")]
    public virtual System.Web.UI.Design.IDataSourceViewSchema Schema { [System.MonoNotSupportedAttribute("")]get { return default(System.Web.UI.Design.IDataSourceViewSchema); } }
    [System.MonoNotSupportedAttribute("")]
    public virtual System.Collections.IEnumerable GetDesignTimeData(int minimumRows, out bool isSampleData) { isSampleData = default(bool); return default(System.Collections.IEnumerable); }
  }
  public abstract partial class DesignerHierarchicalDataSourceView {
    [System.MonoTODOAttribute]
    protected DesignerHierarchicalDataSourceView(System.Web.UI.Design.IHierarchicalDataSourceDesigner owner, string viewPath) { }
    [System.MonoTODOAttribute]
    public System.Web.UI.Design.IHierarchicalDataSourceDesigner DataSourceDesigner { get { return default(System.Web.UI.Design.IHierarchicalDataSourceDesigner); } }
    [System.MonoTODOAttribute]
    public string Path { get { return default(string); } }
    [System.MonoTODOAttribute]
    public virtual System.Web.UI.Design.IDataSourceSchema Schema { get { return default(System.Web.UI.Design.IDataSourceSchema); } }
    [System.MonoTODOAttribute]
    public virtual System.Web.UI.IHierarchicalEnumerable GetDesignTimeData(out bool isSampleData) { isSampleData = default(bool); return default(System.Web.UI.IHierarchicalEnumerable); }
  }
  public abstract partial class DesignerObject : System.IServiceProvider {
    [System.MonoNotSupportedAttribute("")]
    protected DesignerObject(System.Web.UI.Design.ControlDesigner designer, string name) { }
    [System.MonoNotSupportedAttribute("")]
    public System.Web.UI.Design.ControlDesigner Designer { get { return default(System.Web.UI.Design.ControlDesigner); } }
    [System.MonoNotSupportedAttribute("")]
    public string Name { get { return default(string); } }
    [System.MonoNotSupportedAttribute("")]
    public System.Collections.IDictionary Properties { get { return default(System.Collections.IDictionary); } }
    [System.MonoNotSupportedAttribute("")]
    protected object GetService(System.Type serviceType) { return default(object); }
    [System.MonoNotSupportedAttribute("")]
    object System.IServiceProvider.GetService(System.Type serviceType) { return default(object); }
  }
  public partial class DesignerRegion : System.Web.UI.Design.DesignerObject {
    public static readonly string DesignerRegionAttributeName;
    [System.MonoNotSupportedAttribute("")]
    public DesignerRegion(System.Web.UI.Design.ControlDesigner designer, string name) : base (default(System.Web.UI.Design.ControlDesigner), default(string)) { }
    [System.MonoNotSupportedAttribute("")]
    public DesignerRegion(System.Web.UI.Design.ControlDesigner designer, string name, bool selectable) : base (default(System.Web.UI.Design.ControlDesigner), default(string)) { }
    [System.MonoNotSupportedAttribute("")]
    public virtual string Description { get { return default(string); } set { } }
    [System.MonoNotSupportedAttribute("")]
    public virtual string DisplayName { get { return default(string); } set { } }
    [System.MonoNotSupportedAttribute("")]
    public bool EnsureSize { get { return default(bool); } set { } }
    [System.MonoNotSupportedAttribute("")]
    public virtual bool Highlight { get { return default(bool); } set { } }
    [System.MonoNotSupportedAttribute("")]
    public virtual bool Selectable { get { return default(bool); } set { } }
    [System.MonoNotSupportedAttribute("")]
    public virtual bool Selected { get { return default(bool); } set { } }
    [System.MonoNotSupportedAttribute("")]
    public object UserData { get { return default(object); } set { } }
    [System.MonoNotSupportedAttribute("")]
    public System.Drawing.Rectangle GetBounds() { return default(System.Drawing.Rectangle); }
  }
  public partial class DesignerRegionCollection : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList {
    [System.MonoNotSupportedAttribute("")]
    public DesignerRegionCollection() { }
    [System.MonoNotSupportedAttribute("")]
    public DesignerRegionCollection(System.Web.UI.Design.ControlDesigner owner) { }
    [System.MonoNotSupportedAttribute("")]
    public int Count { get { return default(int); } }
    [System.MonoNotSupportedAttribute("")]
    public bool IsFixedSize { get { return default(bool); } }
    [System.MonoNotSupportedAttribute("")]
    public bool IsReadOnly { get { return default(bool); } }
    [System.MonoNotSupportedAttribute("")]
    public bool IsSynchronized { get { return default(bool); } }
    [System.MonoNotSupportedAttribute("")]
    public System.Web.UI.Design.DesignerRegion this[int index] { get { return default(System.Web.UI.Design.DesignerRegion); } set { } }
    [System.MonoNotSupportedAttribute("")]
    public System.Web.UI.Design.ControlDesigner Owner { get { return default(System.Web.UI.Design.ControlDesigner); } }
    [System.MonoNotSupportedAttribute("")]
    public object SyncRoot { get { return default(object); } }
    [System.MonoNotSupportedAttribute("")]
    int System.Collections.ICollection.Count { get { return default(int); } }
    [System.MonoNotSupportedAttribute("")]
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    [System.MonoNotSupportedAttribute("")]
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    [System.MonoNotSupportedAttribute("")]
    bool System.Collections.IList.IsFixedSize { get { return default(bool); } }
    [System.MonoNotSupportedAttribute("")]
    bool System.Collections.IList.IsReadOnly { get { return default(bool); } }
    [System.MonoNotSupportedAttribute("")]
    object System.Collections.IList.this[int index] { get { return default(object); } set { } }
    [System.MonoNotSupportedAttribute("")]
    public int Add(System.Web.UI.Design.DesignerRegion region) { return default(int); }
    [System.MonoNotSupportedAttribute("")]
    public void Clear() { }
    [System.MonoNotSupportedAttribute("")]
    public bool Contains(System.Web.UI.Design.DesignerRegion region) { return default(bool); }
    [System.MonoNotSupportedAttribute("")]
    public void CopyTo(System.Array array, int index) { }
    [System.MonoNotSupportedAttribute("")]
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    [System.MonoNotSupportedAttribute("")]
    public int IndexOf(System.Web.UI.Design.DesignerRegion region) { return default(int); }
    [System.MonoNotSupportedAttribute("")]
    public void Insert(int index, System.Web.UI.Design.DesignerRegion region) { }
    [System.MonoNotSupportedAttribute("")]
    public void Remove(System.Web.UI.Design.DesignerRegion region) { }
    [System.MonoNotSupportedAttribute("")]
    public void RemoveAt(int index) { }
    [System.MonoNotSupportedAttribute("")]
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    [System.MonoNotSupportedAttribute("")]
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    [System.MonoNotSupportedAttribute("")]
    int System.Collections.IList.Add(object o) { return default(int); }
    [System.MonoNotSupportedAttribute("")]
    void System.Collections.IList.Clear() { }
    [System.MonoNotSupportedAttribute("")]
    bool System.Collections.IList.Contains(object o) { return default(bool); }
    [System.MonoNotSupportedAttribute("")]
    int System.Collections.IList.IndexOf(object o) { return default(int); }
    [System.MonoNotSupportedAttribute("")]
    void System.Collections.IList.Insert(int index, object o) { }
    [System.MonoNotSupportedAttribute("")]
    void System.Collections.IList.Remove(object o) { }
    [System.MonoNotSupportedAttribute("")]
    void System.Collections.IList.RemoveAt(int index) { }
  }
  public sealed partial class DesignerRegionMouseEventArgs : System.EventArgs {
    [System.MonoNotSupportedAttribute("")]
    public DesignerRegionMouseEventArgs(System.Web.UI.Design.DesignerRegion region, System.Drawing.Point location) { }
    [System.MonoNotSupportedAttribute("")]
    public System.Drawing.Point Location { [System.MonoNotSupportedAttribute("")]get { return default(System.Drawing.Point); } }
    [System.MonoNotSupportedAttribute("")]
    public System.Web.UI.Design.DesignerRegion Region { [System.MonoNotSupportedAttribute("")]get { return default(System.Web.UI.Design.DesignerRegion); } }
  }
  public sealed partial class DesignTimeData {
    internal DesignTimeData() { }
    public static readonly System.EventHandler DataBindingHandler;
    [System.MonoTODOAttribute]
    public static System.Data.DataTable CreateDummyDataBoundDataTable() { return default(System.Data.DataTable); }
    [System.MonoTODOAttribute]
    public static System.Data.DataTable CreateDummyDataTable() { return default(System.Data.DataTable); }
    [System.MonoTODOAttribute]
    public static System.Data.DataTable CreateSampleDataTable(System.Collections.IEnumerable referenceData) { return default(System.Data.DataTable); }
    [System.MonoTODOAttribute]
    public static System.Data.DataTable CreateSampleDataTable(System.Collections.IEnumerable referenceData, bool useDataBoundData) { return default(System.Data.DataTable); }
    [System.MonoTODOAttribute]
    public static System.ComponentModel.PropertyDescriptorCollection GetDataFields(System.Collections.IEnumerable dataSource) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    [System.MonoTODOAttribute]
    public static System.Collections.IEnumerable GetDataMember(System.ComponentModel.IListSource dataSource, string dataMember) { return default(System.Collections.IEnumerable); }
    [System.MonoTODOAttribute]
    public static System.String[] GetDataMembers(object dataSource) { return default(System.String[]); }
    [System.MonoTODOAttribute]
    public static System.Collections.IEnumerable GetDesignTimeDataSource(System.Data.DataTable dataTable, int minimumRows) { return default(System.Collections.IEnumerable); }
    [System.MonoTODOAttribute]
    public static object GetSelectedDataSource(System.ComponentModel.IComponent component, string dataSource) { return default(object); }
    [System.MonoTODOAttribute]
    public static System.Collections.IEnumerable GetSelectedDataSource(System.ComponentModel.IComponent component, string dataSource, string dataMember) { return default(System.Collections.IEnumerable); }
  }
  public abstract partial class DesignTimeResourceProviderFactory {
    protected DesignTimeResourceProviderFactory() { }
    public abstract System.Web.Compilation.IResourceProvider CreateDesignTimeGlobalResourceProvider(System.IServiceProvider serviceProvider, string classKey);
    public abstract System.Web.Compilation.IResourceProvider CreateDesignTimeLocalResourceProvider(System.IServiceProvider serviceProvider);
    public abstract System.Web.UI.Design.IDesignTimeResourceWriter CreateDesignTimeLocalResourceWriter(System.IServiceProvider serviceProvider);
  }
  public partial class EditableDesignerRegion : System.Web.UI.Design.DesignerRegion {
    [System.MonoNotSupportedAttribute("")]
    public EditableDesignerRegion(System.Web.UI.Design.ControlDesigner owner, string name) : base (default(System.Web.UI.Design.ControlDesigner), default(string)) { }
    [System.MonoNotSupportedAttribute("")]
    public EditableDesignerRegion(System.Web.UI.Design.ControlDesigner owner, string name, bool serverControlsOnly) : base (default(System.Web.UI.Design.ControlDesigner), default(string)) { }
    [System.MonoNotSupportedAttribute("")]
    public virtual string Content { get { return default(string); } set { } }
    [System.MonoNotSupportedAttribute("")]
    public bool ServerControlsOnly { get { return default(bool); } set { } }
    [System.MonoNotSupportedAttribute("")]
    public virtual bool SupportsDataBinding { get { return default(bool); } set { } }
    [System.MonoNotSupportedAttribute("")]
    public virtual System.Web.UI.Design.ViewRendering GetChildViewRendering(System.Web.UI.Control control) { return default(System.Web.UI.Design.ViewRendering); }
  }
  public abstract partial class ExpressionEditor {
    protected ExpressionEditor() { }
    public string ExpressionPrefix { get { return default(string); } }
    public abstract object EvaluateExpression(string expression, object parseTimeData, System.Type propertyType, System.IServiceProvider serviceProvider);
    public static System.Web.UI.Design.ExpressionEditor GetExpressionEditor(string expressionPrefix, System.IServiceProvider serviceProvider) { return default(System.Web.UI.Design.ExpressionEditor); }
    [System.MonoTODOAttribute("the docs make it sound like this still requires accessing <expressionBuilders>")]
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
    [System.MonoTODOAttribute]
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class ExpressionsCollectionEditor : System.Drawing.Design.UITypeEditor {
    public ExpressionsCollectionEditor() { }
    [System.MonoTODOAttribute]
    public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { return default(object); }
    [System.MonoTODOAttribute]
    public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { return default(System.Drawing.Design.UITypeEditorEditStyle); }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class HierarchicalDataSourceConverter : System.Web.UI.Design.DataSourceConverter {
    public HierarchicalDataSourceConverter() { }
    [System.MonoTODOAttribute]
    protected override bool IsValidDataSource(System.ComponentModel.IComponent component) { return default(bool); }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class HierarchicalDataSourceDesigner : System.Web.UI.Design.ControlDesigner, System.Web.UI.Design.IHierarchicalDataSourceDesigner {
    public HierarchicalDataSourceDesigner() { }
    [System.MonoTODOAttribute]
    public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { return default(System.ComponentModel.Design.DesignerActionListCollection); } }
    [System.MonoTODOAttribute]
    public virtual bool CanConfigure { get { return default(bool); } }
    [System.MonoTODOAttribute]
    public virtual bool CanRefreshSchema { get { return default(bool); } }
    [System.MonoTODOAttribute]
    protected bool SuppressingDataSourceEvents { get { return default(bool); } }
    public event System.EventHandler DataSourceChanged { add { } remove { } }
    public event System.EventHandler SchemaRefreshed { add { } remove { } }
    public virtual void Configure() { }
    [System.MonoTODOAttribute]
    public override string GetDesignTimeHtml() { return default(string); }
    [System.MonoTODOAttribute]
    public virtual System.Web.UI.Design.DesignerHierarchicalDataSourceView GetView(string viewPath) { return default(System.Web.UI.Design.DesignerHierarchicalDataSourceView); }
    [System.MonoTODOAttribute]
    protected virtual void OnDataSourceChanged(System.EventArgs e) { }
    [System.MonoTODOAttribute]
    protected virtual void OnSchemaRefreshed(System.EventArgs e) { }
    [System.MonoTODOAttribute]
    public virtual void RefreshSchema(bool preferSilent) { }
    [System.MonoTODOAttribute]
    public virtual void ResumeDataSourceEvents() { }
    [System.MonoTODOAttribute]
    public virtual void SuppressDataSourceEvents() { }
  }
  [System.MonoTODOAttribute]
  public partial class HtmlControlDesigner : System.ComponentModel.Design.ComponentDesigner {
    [System.MonoTODOAttribute]
    public HtmlControlDesigner() { }
    [System.MonoTODOAttribute]
    [System.ObsoleteAttribute("Use ControlDesigner.Tag instead")]
    public System.Web.UI.Design.IHtmlControlDesignerBehavior Behavior { get { return default(System.Web.UI.Design.IHtmlControlDesignerBehavior); } set { } }
    [System.MonoTODOAttribute]
    public System.Web.UI.DataBindingCollection DataBindings { get { return default(System.Web.UI.DataBindingCollection); } }
    [System.MonoTODOAttribute]
    [System.ObsoleteAttribute("Use new WebFormsRootDesigner feature instead. It is not used anymore", true)]
    protected object DesignTimeElement { get { return default(object); } }
    public System.Web.UI.ExpressionBindingCollection Expressions { get { return default(System.Web.UI.ExpressionBindingCollection); } }
    [System.MonoTODOAttribute]
    [System.ObsoleteAttribute("Code serialization is not supported in 2.0 anymore")]
    public virtual bool ShouldCodeSerialize { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    protected override void Dispose(bool disposing) { }
    public override void Initialize(System.ComponentModel.IComponent component) { }
    [System.MonoTODOAttribute]
    [System.ObsoleteAttribute("Use ControlDesigner.Tag instead")]
    protected virtual void OnBehaviorAttached() { }
    [System.MonoTODOAttribute]
    [System.ObsoleteAttribute("Use ControlDesigner.Tag instead")]
    protected virtual void OnBehaviorDetaching() { }
    [System.MonoTODOAttribute]
    [System.ObsoleteAttribute("Use DataBinding.Changed event instead")]
    protected virtual void OnBindingsCollectionChanged(string propName) { }
    [System.MonoTODOAttribute]
    public virtual void OnSetParent() { }
    [System.MonoTODOAttribute]
    protected override void PreFilterEvents(System.Collections.IDictionary events) { }
    [System.MonoTODOAttribute]
    protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
  }
  public partial class HtmlIntrinsicControlDesigner : System.Web.UI.Design.HtmlControlDesigner {
    public HtmlIntrinsicControlDesigner() { }
  }
  public partial class HyperLinkDataBindingHandler : System.Web.UI.Design.DataBindingHandler {
    public HyperLinkDataBindingHandler() { }
    [System.MonoTODOAttribute]
    public override void DataBindControl(System.ComponentModel.Design.IDesignerHost designerHost, System.Web.UI.Control control) { }
  }
  public partial interface IContentResolutionService {
    System.Collections.IDictionary ContentDefinitions { get; }
    System.Web.UI.Design.ContentDesignerState GetContentDesignerState(string identifier);
    void SetContentDesignerState(string identifier, System.Web.UI.Design.ContentDesignerState state);
  }
  [System.ObsoleteAttribute("Use IControlDesignerTag interface instead")]
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
  [System.ObsoleteAttribute("Use IControlDesignerTag and IControlDesignerView instead")]
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
  [System.ObsoleteAttribute("Template editing is supported in ControlDesigner.TemplateGroups with SetViewFlags(ViewFlags.TemplateEditing, true) in 2.0.")]
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
  [System.ObsoleteAttribute("Template editing is supported in ControlDesigner.TemplateGroups with SetViewFlags(ViewFlags.TemplateEditing, true) in 2.0.")]
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
  [System.ObsoleteAttribute("Use new WebFormsReferenceManager feature")]
  public partial interface IWebFormReferenceManager {
    System.Type GetObjectType(string tagPrefix, string typeName);
    string GetRegisterDirectives();
    string GetTagPrefix(System.Type objectType);
  }
  public partial interface IWebFormsBuilderUIService {
    string BuildColor(System.Windows.Forms.Control owner, string initialColor);
    string BuildUrl(System.Windows.Forms.Control owner, string initialUrl, string baseUrl, string caption, string filter, System.Web.UI.Design.UrlBuilderOptions options);
  }
  [System.ObsoleteAttribute("Use new WebFormsReferenceManager feature")]
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
    [System.MonoTODOAttribute]
    protected override string Caption { get { return default(string); } }
    [System.MonoTODOAttribute]
    protected override string Filter { get { return default(string); } }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class MdbDataFileEditor : System.Web.UI.Design.UrlEditor {
    public MdbDataFileEditor() { }
    [System.MonoTODOAttribute]
    protected override string Caption { get { return default(string); } }
    [System.MonoTODOAttribute]
    protected override string Filter { get { return default(string); } }
  }
  [System.MonoTODOAttribute]
  [System.ObsoleteAttribute("Use ContainerControlDesigner instead")]
  public partial class ReadWriteControlDesigner : System.Web.UI.Design.ControlDesigner {
    [System.MonoTODOAttribute]
    public ReadWriteControlDesigner() { }
    [System.MonoTODOAttribute]
    public override string GetDesignTimeHtml() { return default(string); }
    [System.MonoTODOAttribute]
    protected virtual void MapPropertyToStyle(string propName, object varPropValue) { }
    [System.MonoTODOAttribute]
    [System.ObsoleteAttribute("Use ControlDesigner.Tag instead")]
    protected override void OnBehaviorAttached() { }
    [System.MonoTODOAttribute]
    public override void OnComponentChanged(object sender, System.ComponentModel.Design.ComponentChangedEventArgs ce) { }
    [System.MonoTODOAttribute]
    public override void UpdateDesignTimeHtml() { }
  }
  public partial class ResourceExpressionEditor : System.Web.UI.Design.ExpressionEditor {
    public ResourceExpressionEditor() { }
    public override object EvaluateExpression(string expression, object parseTimeData, System.Type propertyType, System.IServiceProvider serviceProvider) { return default(object); }
    public override System.Web.UI.Design.ExpressionEditorSheet GetExpressionEditorSheet(string expression, System.IServiceProvider serviceProvider) { return default(System.Web.UI.Design.ExpressionEditorSheet); }
  }
  public partial class ResourceExpressionEditorSheet : System.Web.UI.Design.ExpressionEditorSheet {
    [System.MonoTODOAttribute]
    public ResourceExpressionEditorSheet(string expression, System.IServiceProvider serviceProvider) : base (default(System.IServiceProvider)) { }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.MonoTODOAttribute]
    public string ClassKey { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public override bool IsValid { get { return default(bool); } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.MonoTODOAttribute]
    public string ResourceKey { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public override string GetExpression() { return default(string); }
  }
  public partial class SkinIDTypeConverter : System.ComponentModel.TypeConverter {
    [System.MonoTODOAttribute]
    public SkinIDTypeConverter() { }
    [System.MonoTODOAttribute]
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    [System.MonoTODOAttribute]
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destType) { return default(bool); }
    [System.MonoTODOAttribute]
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    [System.MonoTODOAttribute]
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
    [System.MonoTODOAttribute]
    public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { return default(System.ComponentModel.TypeConverter.StandardValuesCollection); }
    [System.MonoTODOAttribute]
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
  public abstract partial class TemplatedControlDesigner : System.Web.UI.Design.ControlDesigner {
    public TemplatedControlDesigner() { }
    [System.ObsoleteAttribute("Template editing is supported in ControlDesigner.TemplateGroups with SetViewFlags(ViewFlags.TemplateEditing, true) in 2.0.")]
    public System.Web.UI.Design.ITemplateEditingFrame ActiveTemplateEditingFrame { get { return default(System.Web.UI.Design.ITemplateEditingFrame); } }
    public bool CanEnterTemplateMode { get { return default(bool); } }
    protected override bool DataBindingsEnabled { get { return default(bool); } }
    [System.ObsoleteAttribute("Use ControlDesigner.InTemplateMode instead")]
    public new bool InTemplateMode { get { return default(bool); } }
    public override System.Web.UI.Design.TemplateGroupCollection TemplateGroups { get { return default(System.Web.UI.Design.TemplateGroupCollection); } }
    [System.ObsoleteAttribute("Template editing is supported in ControlDesigner.TemplateGroups with SetViewFlags(ViewFlags.TemplateEditing, true) in 2.0.")]
    protected abstract System.Web.UI.Design.ITemplateEditingFrame CreateTemplateEditingFrame(System.Web.UI.Design.TemplateEditingVerb verb);
    [System.MonoTODOAttribute]
    [System.ObsoleteAttribute("Template editing is supported in ControlDesigner.TemplateGroups with SetViewFlags(ViewFlags.TemplateEditing, true) in 2.0.")]
    public void EnterTemplateMode(System.Web.UI.Design.ITemplateEditingFrame newTemplateEditingFrame) { }
    [System.MonoTODOAttribute]
    [System.ObsoleteAttribute("Template editing is supported in ControlDesigner.TemplateGroups with SetViewFlags(ViewFlags.TemplateEditing, true) in 2.0.")]
    public void ExitTemplateMode(bool fSwitchingTemplates, bool fNested, bool fSave) { }
    [System.ObsoleteAttribute("Template editing is supported in ControlDesigner.TemplateGroups with SetViewFlags(ViewFlags.TemplateEditing, true) in 2.0.")]
    protected abstract System.Web.UI.Design.TemplateEditingVerb[] GetCachedTemplateEditingVerbs();
    [System.ObsoleteAttribute("Template editing is supported in ControlDesigner.TemplateGroups with SetViewFlags(ViewFlags.TemplateEditing, true) in 2.0.")]
    public virtual string GetTemplateContainerDataItemProperty(string templateName) { return default(string); }
    [System.ObsoleteAttribute("Template editing is supported in ControlDesigner.TemplateGroups with SetViewFlags(ViewFlags.TemplateEditing, true) in 2.0.")]
    public virtual System.Collections.IEnumerable GetTemplateContainerDataSource(string templateName) { return default(System.Collections.IEnumerable); }
    [System.ObsoleteAttribute("Template editing is supported in ControlDesigner.TemplateGroups with SetViewFlags(ViewFlags.TemplateEditing, true) in 2.0.")]
    public abstract string GetTemplateContent(System.Web.UI.Design.ITemplateEditingFrame editingFrame, string templateName, out bool allowEditing);
    [System.MonoTODOAttribute]
    [System.ObsoleteAttribute("Template editing is supported in ControlDesigner.TemplateGroups with SetViewFlags(ViewFlags.TemplateEditing, true) in 2.0.")]
    public System.Web.UI.Design.TemplateEditingVerb[] GetTemplateEditingVerbs() { return default(System.Web.UI.Design.TemplateEditingVerb[]); }
    [System.MonoTODOAttribute]
    protected System.Web.UI.ITemplate GetTemplateFromText(string text) { return default(System.Web.UI.ITemplate); }
    [System.ObsoleteAttribute("Template editing is supported in ControlDesigner.TemplateGroups with SetViewFlags(ViewFlags.TemplateEditing, true) in 2.0.")]
    public virtual System.Type GetTemplatePropertyParentType(string templateName) { return default(System.Type); }
    [System.MonoTODOAttribute]
    protected string GetTextFromTemplate(System.Web.UI.ITemplate template) { return default(string); }
    [System.MonoTODOAttribute]
    public override void Initialize(System.ComponentModel.IComponent component) { }
    [System.MonoTODOAttribute]
    [System.ObsoleteAttribute("Use ControlDesigner.Tag instead")]
    protected override void OnBehaviorAttached() { }
    [System.MonoTODOAttribute]
    public override void OnComponentChanged(object sender, System.ComponentModel.Design.ComponentChangedEventArgs ce) { }
    [System.MonoTODOAttribute]
    public override void OnSetParent() { }
    [System.MonoTODOAttribute]
    protected virtual void OnTemplateModeChanged() { }
    [System.MonoTODOAttribute]
    protected void SaveActiveTemplateEditingFrame() { }
    [System.ObsoleteAttribute("Template editing is supported in ControlDesigner.TemplateGroups with SetViewFlags(ViewFlags.TemplateEditing, true) in 2.0.")]
    public abstract void SetTemplateContent(System.Web.UI.Design.ITemplateEditingFrame editingFrame, string templateName, string templateContent);
    [System.MonoTODOAttribute]
    public override void UpdateDesignTimeHtml() { }
  }
  public partial class TemplatedEditableDesignerRegion : System.Web.UI.Design.EditableDesignerRegion {
    [System.MonoNotSupportedAttribute("")]
    public TemplatedEditableDesignerRegion(System.Web.UI.Design.TemplateDefinition templateDefinition) : base (default(System.Web.UI.Design.ControlDesigner), default(string)) { }
    [System.MonoNotSupportedAttribute("")]
    public virtual bool IsSingleInstanceTemplate { [System.MonoNotSupportedAttribute("")]get { return default(bool); } [System.MonoNotSupportedAttribute("")]set { } }
    [System.MonoNotSupportedAttribute("")]
    public override bool SupportsDataBinding { [System.MonoNotSupportedAttribute("")]get { return default(bool); } [System.MonoNotSupportedAttribute("")]set { } }
    [System.MonoNotSupportedAttribute("")]
    public System.Web.UI.Design.TemplateDefinition TemplateDefinition { [System.MonoNotSupportedAttribute("")]get { return default(System.Web.UI.Design.TemplateDefinition); } }
  }
  public partial class TemplateDefinition : System.Web.UI.Design.DesignerObject {
    [System.MonoNotSupportedAttribute("")]
    public TemplateDefinition(System.Web.UI.Design.ControlDesigner designer, string name, object templatedObject, string templatePropertyName) : base (default(System.Web.UI.Design.ControlDesigner), default(string)) { }
    [System.MonoNotSupportedAttribute("")]
    public TemplateDefinition(System.Web.UI.Design.ControlDesigner designer, string name, object templatedObject, string templatePropertyName, bool serverControlsOnly) : base (default(System.Web.UI.Design.ControlDesigner), default(string)) { }
    [System.MonoNotSupportedAttribute("")]
    public TemplateDefinition(System.Web.UI.Design.ControlDesigner designer, string name, object templatedObject, string templatePropertyName, System.Web.UI.WebControls.Style style) : base (default(System.Web.UI.Design.ControlDesigner), default(string)) { }
    [System.MonoNotSupportedAttribute("")]
    public TemplateDefinition(System.Web.UI.Design.ControlDesigner designer, string name, object templatedObject, string templatePropertyName, System.Web.UI.WebControls.Style style, bool serverControlsOnly) : base (default(System.Web.UI.Design.ControlDesigner), default(string)) { }
    [System.MonoNotSupportedAttribute("")]
    public virtual bool AllowEditing { [System.MonoNotSupportedAttribute("")]get { return default(bool); } }
    [System.MonoNotSupportedAttribute("")]
    public virtual string Content { [System.MonoNotSupportedAttribute("")]get { return default(string); } [System.MonoNotSupportedAttribute("")]set { } }
    [System.MonoNotSupportedAttribute("")]
    public bool ServerControlsOnly { [System.MonoNotSupportedAttribute("")]get { return default(bool); } }
    [System.MonoNotSupportedAttribute("")]
    public System.Web.UI.WebControls.Style Style { [System.MonoNotSupportedAttribute("")]get { return default(System.Web.UI.WebControls.Style); } }
    [System.MonoNotSupportedAttribute("")]
    public bool SupportsDataBinding { [System.MonoNotSupportedAttribute("")]get { return default(bool); } [System.MonoNotSupportedAttribute("")]set { } }
    [System.MonoNotSupportedAttribute("")]
    public object TemplatedObject { [System.MonoNotSupportedAttribute("")]get { return default(object); } }
    [System.MonoNotSupportedAttribute("")]
    public string TemplatePropertyName { [System.MonoNotSupportedAttribute("")]get { return default(string); } }
  }
  [System.ObsoleteAttribute("Template editing is supported in ControlDesigner.TemplateGroups with SetViewFlags(ViewFlags.TemplateEditing, true) in 2.0.")]
  public sealed partial class TemplateEditingService : System.IDisposable, System.Web.UI.Design.ITemplateEditingService {
    public TemplateEditingService(System.ComponentModel.Design.IDesignerHost designerHost) { }
    public bool SupportsNestedTemplateEditing { get { return default(bool); } }
    [System.MonoTODOAttribute]
    public System.Web.UI.Design.ITemplateEditingFrame CreateFrame(System.Web.UI.Design.TemplatedControlDesigner designer, string frameName, System.String[] templateNames) { return default(System.Web.UI.Design.ITemplateEditingFrame); }
    [System.MonoTODOAttribute]
    public System.Web.UI.Design.ITemplateEditingFrame CreateFrame(System.Web.UI.Design.TemplatedControlDesigner designer, string frameName, System.String[] templateNames, System.Web.UI.WebControls.Style controlStyle, System.Web.UI.WebControls.Style[] templateStyles) { return default(System.Web.UI.Design.ITemplateEditingFrame); }
    public void Dispose() { }
    ~TemplateEditingService() { }
    [System.MonoTODOAttribute]
    public string GetContainingTemplateName(System.Web.UI.Control control) { return default(string); }
  }
  [System.ObsoleteAttribute("Template editing is supported in ControlDesigner.TemplateGroups with SetViewFlags(ViewFlags.TemplateEditing, true) in 2.0.")]
  public partial class TemplateEditingVerb : System.ComponentModel.Design.DesignerVerb, System.IDisposable {
    [System.MonoTODOAttribute]
    public TemplateEditingVerb(string text, int index) : base (default(string), default(System.EventHandler)) { }
    public TemplateEditingVerb(string text, int index, System.Web.UI.Design.TemplatedControlDesigner designer) : base (default(string), default(System.EventHandler)) { }
    public int Index { get { return default(int); } }
    public void Dispose() { }
    [System.MonoTODOAttribute]
    protected virtual void Dispose(bool disposing) { }
    ~TemplateEditingVerb() { }
  }
  public partial class TemplateGroup {
    [System.MonoNotSupportedAttribute("")]
    public TemplateGroup(string groupName) { }
    [System.MonoNotSupportedAttribute("")]
    public TemplateGroup(string groupName, System.Web.UI.WebControls.Style groupStyle) { }
    [System.MonoNotSupportedAttribute("")]
    public string GroupName { [System.MonoNotSupportedAttribute("")]get { return default(string); } }
    [System.MonoNotSupportedAttribute("")]
    public System.Web.UI.WebControls.Style GroupStyle { [System.MonoNotSupportedAttribute("")]get { return default(System.Web.UI.WebControls.Style); } }
    [System.MonoNotSupportedAttribute("")]
    public bool IsEmpty { [System.MonoNotSupportedAttribute("")]get { return default(bool); } }
    [System.MonoNotSupportedAttribute("")]
    public System.Web.UI.Design.TemplateDefinition[] Templates { [System.MonoNotSupportedAttribute("")]get { return default(System.Web.UI.Design.TemplateDefinition[]); } }
    [System.MonoNotSupportedAttribute("")]
    public void AddTemplateDefinition(System.Web.UI.Design.TemplateDefinition templateDefinition) { }
  }
  public sealed partial class TemplateGroupCollection : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList {
    [System.MonoNotSupportedAttribute("")]
    public TemplateGroupCollection() { }
    [System.MonoNotSupportedAttribute("")]
    public int Count { [System.MonoNotSupportedAttribute("")]get { return default(int); } }
    [System.MonoNotSupportedAttribute("")]
    public System.Web.UI.Design.TemplateGroup this[int index] { [System.MonoNotSupportedAttribute("")]get { return default(System.Web.UI.Design.TemplateGroup); } [System.MonoNotSupportedAttribute("")]set { } }
    [System.MonoNotSupportedAttribute("")]
    int System.Collections.ICollection.Count { [System.MonoNotSupportedAttribute("")]get { return default(int); } }
    [System.MonoNotSupportedAttribute("")]
    bool System.Collections.ICollection.IsSynchronized { [System.MonoNotSupportedAttribute("")]get { return default(bool); } }
    [System.MonoNotSupportedAttribute("")]
    object System.Collections.ICollection.SyncRoot { [System.MonoNotSupportedAttribute("")]get { return default(object); } }
    [System.MonoNotSupportedAttribute("")]
    bool System.Collections.IList.IsFixedSize { [System.MonoNotSupportedAttribute("")]get { return default(bool); } }
    [System.MonoNotSupportedAttribute("")]
    bool System.Collections.IList.IsReadOnly { [System.MonoNotSupportedAttribute("")]get { return default(bool); } }
    [System.MonoNotSupportedAttribute("")]
    object System.Collections.IList.this[int index] { [System.MonoNotSupportedAttribute("")]get { return default(object); } [System.MonoNotSupportedAttribute("")]set { } }
    [System.MonoNotSupportedAttribute("")]
    public int Add(System.Web.UI.Design.TemplateGroup group) { return default(int); }
    [System.MonoNotSupportedAttribute("")]
    public void AddRange(System.Web.UI.Design.TemplateGroupCollection groups) { }
    [System.MonoNotSupportedAttribute("")]
    public void Clear() { }
    [System.MonoNotSupportedAttribute("")]
    public bool Contains(System.Web.UI.Design.TemplateGroup group) { return default(bool); }
    [System.MonoNotSupportedAttribute("")]
    public void CopyTo(System.Web.UI.Design.TemplateGroup[] array, int index) { }
    [System.MonoNotSupportedAttribute("")]
    public int IndexOf(System.Web.UI.Design.TemplateGroup group) { return default(int); }
    [System.MonoNotSupportedAttribute("")]
    public void Insert(int index, System.Web.UI.Design.TemplateGroup group) { }
    [System.MonoNotSupportedAttribute("")]
    public void Remove(System.Web.UI.Design.TemplateGroup group) { }
    [System.MonoNotSupportedAttribute("")]
    public void RemoveAt(int index) { }
    [System.MonoNotSupportedAttribute("")]
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    [System.MonoNotSupportedAttribute("")]
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    [System.MonoNotSupportedAttribute("")]
    int System.Collections.IList.Add(object o) { return default(int); }
    [System.MonoNotSupportedAttribute("")]
    void System.Collections.IList.Clear() { }
    [System.MonoNotSupportedAttribute("")]
    bool System.Collections.IList.Contains(object o) { return default(bool); }
    [System.MonoNotSupportedAttribute("")]
    int System.Collections.IList.IndexOf(object o) { return default(int); }
    [System.MonoNotSupportedAttribute("")]
    void System.Collections.IList.Insert(int index, object o) { }
    [System.MonoNotSupportedAttribute("")]
    void System.Collections.IList.Remove(object o) { }
    [System.MonoNotSupportedAttribute("")]
    void System.Collections.IList.RemoveAt(int index) { }
  }
  public partial class TemplateModeChangedEventArgs : System.EventArgs {
    public TemplateModeChangedEventArgs(System.Web.UI.Design.TemplateGroup newTemplateGroup) { }
    public System.Web.UI.Design.TemplateGroup NewTemplateGroup { get { return default(System.Web.UI.Design.TemplateGroup); } }
  }
  public partial class TextControlDesigner : System.Web.UI.Design.ControlDesigner {
    public TextControlDesigner() { }
    [System.MonoTODOAttribute]
    public override string GetDesignTimeHtml() { return default(string); }
  }
  public partial class TextDataBindingHandler : System.Web.UI.Design.DataBindingHandler {
    public TextDataBindingHandler() { }
    [System.MonoTODOAttribute]
    public override void DataBindControl(System.ComponentModel.Design.IDesignerHost designerHost, System.Web.UI.Control control) { }
  }
  public delegate bool TransactedChangeCallback(object context);
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public sealed partial class TypeSchema : System.Web.UI.Design.IDataSourceSchema {
    [System.MonoTODOAttribute]
    public TypeSchema(System.Type type) { }
    [System.MonoTODOAttribute]
    public System.Web.UI.Design.IDataSourceViewSchema[] GetViews() { return default(System.Web.UI.Design.IDataSourceViewSchema[]); }
  }
  public sealed partial class UrlBuilder {
    internal UrlBuilder() { }
    [System.MonoTODOAttribute]
    public static string BuildUrl(System.ComponentModel.IComponent component, System.Windows.Forms.Control owner, string initialUrl, string caption, string filter) { return default(string); }
    [System.MonoTODOAttribute]
    public static string BuildUrl(System.ComponentModel.IComponent component, System.Windows.Forms.Control owner, string initialUrl, string caption, string filter, System.Web.UI.Design.UrlBuilderOptions options) { return default(string); }
    [System.MonoTODOAttribute]
    public static string BuildUrl(System.IServiceProvider serviceProvider, System.Windows.Forms.Control owner, string initialUrl, string caption, string filter, System.Web.UI.Design.UrlBuilderOptions options) { return default(string); }
  }
  [System.FlagsAttribute]
  public enum UrlBuilderOptions {
    NoAbsolute = 1,
    None = 0,
  }
  public partial class UrlEditor : System.Drawing.Design.UITypeEditor {
    public UrlEditor() { }
    protected virtual string Caption { get { return default(string); } }
    protected virtual string Filter { get { return default(string); } }
    protected virtual System.Web.UI.Design.UrlBuilderOptions Options { get { return default(System.Web.UI.Design.UrlBuilderOptions); } }
    [System.MonoTODOAttribute]
    public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { return default(object); }
    [System.MonoTODOAttribute]
    public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { return default(System.Drawing.Design.UITypeEditorEditStyle); }
  }
  public partial class UserControlDesigner : System.Web.UI.Design.ControlDesigner {
    public UserControlDesigner() { }
    public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { return default(System.ComponentModel.Design.DesignerActionListCollection); } }
    public override bool AllowResize { get { return default(bool); } }
    public override string GetDesignTimeHtml() { return default(string); }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class UserControlFileEditor : System.Web.UI.Design.UrlEditor {
    public UserControlFileEditor() { }
    [System.MonoTODOAttribute]
    protected override string Caption { get { return default(string); } }
    [System.MonoTODOAttribute]
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
    [System.MonoNotSupportedAttribute("")]
    public ViewRendering(string content, System.Web.UI.Design.DesignerRegionCollection regions) { }
    [System.MonoNotSupportedAttribute("")]
    public string Content { get { return default(string); } }
    [System.MonoNotSupportedAttribute("")]
    public System.Web.UI.Design.DesignerRegionCollection Regions { get { return default(System.Web.UI.Design.DesignerRegionCollection); } }
  }
  [System.MonoTODOAttribute]
  public partial class WebControlToolboxItem : System.Drawing.Design.ToolboxItem {
    public WebControlToolboxItem() { }
    protected WebControlToolboxItem(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    [System.MonoTODOAttribute]
    public WebControlToolboxItem(System.Type type) { }
    [System.MonoTODOAttribute]
    protected override System.ComponentModel.IComponent[] CreateComponentsCore(System.ComponentModel.Design.IDesignerHost host) { return default(System.ComponentModel.IComponent[]); }
    [System.MonoTODOAttribute]
    protected override void Deserialize(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    [System.MonoTODOAttribute]
    public object GetToolAttributeValue(System.ComponentModel.Design.IDesignerHost host, System.Type attributeType) { return default(object); }
    [System.MonoTODOAttribute]
    public string GetToolHtml(System.ComponentModel.Design.IDesignerHost host) { return default(string); }
    [System.MonoTODOAttribute]
    public System.Type GetToolType(System.ComponentModel.Design.IDesignerHost host) { return default(System.Type); }
    [System.MonoTODOAttribute]
    public override void Initialize(System.Type type) { }
    [System.MonoTODOAttribute]
    protected override void Serialize(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial class WebFormsDesignerActionService : System.ComponentModel.Design.DesignerActionService {
    [System.MonoTODOAttribute]
    public WebFormsDesignerActionService(System.IServiceProvider serviceProvider) : base (default(System.IServiceProvider)) { }
    [System.MonoTODOAttribute]
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
    [System.MonoTODOAttribute]
    public virtual System.ComponentModel.IComponent Component { get { return default(System.ComponentModel.IComponent); } set { } }
    [System.MonoTODOAttribute]
    public System.Globalization.CultureInfo CurrentCulture { get { return default(System.Globalization.CultureInfo); } }
    public abstract string DocumentUrl { get; }
    public abstract bool IsDesignerViewLocked { get; }
    public abstract bool IsLoading { get; }
    public abstract System.Web.UI.Design.WebFormsReferenceManager ReferenceManager { get; }
    [System.MonoTODOAttribute]
    protected System.ComponentModel.Design.ViewTechnology[] SupportedTechnologies { get { return default(System.ComponentModel.Design.ViewTechnology[]); } }
    [System.MonoTODOAttribute]
    System.ComponentModel.Design.DesignerVerbCollection System.ComponentModel.Design.IDesigner.Verbs { get { return default(System.ComponentModel.Design.DesignerVerbCollection); } }
    [System.MonoTODOAttribute]
    System.ComponentModel.Design.ViewTechnology[] System.ComponentModel.Design.IRootDesigner.SupportedTechnologies { get { return default(System.ComponentModel.Design.ViewTechnology[]); } }
    [System.MonoTODOAttribute]
    protected System.ComponentModel.Design.DesignerVerbCollection Verbs { get { return default(System.ComponentModel.Design.DesignerVerbCollection); } }
    public event System.EventHandler LoadComplete { add { } remove { } }
    public abstract void AddClientScriptToDocument(System.Web.UI.Design.ClientScriptItem scriptItem);
    public abstract string AddControlToDocument(System.Web.UI.Control newControl, System.Web.UI.Control referenceControl, System.Web.UI.Design.ControlLocation location);
    [System.MonoTODOAttribute]
    protected virtual System.ComponentModel.Design.DesignerActionService CreateDesignerActionService(System.IServiceProvider serviceProvider) { return default(System.ComponentModel.Design.DesignerActionService); }
    [System.MonoTODOAttribute]
    protected virtual System.Web.UI.IUrlResolutionService CreateUrlResolutionService() { return default(System.Web.UI.IUrlResolutionService); }
    [System.MonoTODOAttribute]
    protected virtual void Dispose(bool disposing) { }
    ~WebFormsRootDesigner() { }
    [System.MonoTODOAttribute]
    public virtual string GenerateEmptyDesignTimeHtml(System.Web.UI.Control control) { return default(string); }
    [System.MonoTODOAttribute]
    public virtual string GenerateErrorDesignTimeHtml(System.Web.UI.Control control, System.Exception e, string errorMessage) { return default(string); }
    public abstract System.Web.UI.Design.ClientScriptItemCollection GetClientScriptsInDocument();
    protected internal abstract void GetControlViewAndTag(System.Web.UI.Control control, out System.Web.UI.Design.IControlDesignerView view, out System.Web.UI.Design.IControlDesignerTag tag);
    [System.MonoTODOAttribute]
    protected internal virtual object GetService(System.Type serviceType) { return default(object); }
    [System.MonoTODOAttribute]
    protected object GetView(System.ComponentModel.Design.ViewTechnology viewTechnology) { return default(object); }
    [System.MonoTODOAttribute]
    public virtual void Initialize(System.ComponentModel.IComponent component) { }
    [System.MonoTODOAttribute]
    protected virtual void OnLoadComplete(System.EventArgs e) { }
    [System.MonoTODOAttribute]
    protected virtual void PostFilterAttributes(System.Collections.IDictionary attributes) { }
    [System.MonoTODOAttribute]
    protected virtual void PostFilterEvents(System.Collections.IDictionary events) { }
    [System.MonoTODOAttribute]
    protected virtual void PostFilterProperties(System.Collections.IDictionary properties) { }
    [System.MonoTODOAttribute]
    protected virtual void PreFilterAttributes(System.Collections.IDictionary attributes) { }
    [System.MonoTODOAttribute]
    protected virtual void PreFilterEvents(System.Collections.IDictionary events) { }
    [System.MonoTODOAttribute]
    protected virtual void PreFilterProperties(System.Collections.IDictionary properties) { }
    public abstract void RemoveClientScriptFromDocument(string clientScriptId);
    public abstract void RemoveControlFromDocument(System.Web.UI.Control control);
    [System.MonoTODOAttribute]
    public string ResolveUrl(string relativeUrl) { return default(string); }
    [System.MonoTODOAttribute]
    public virtual void SetControlID(System.Web.UI.Control control, string id) { }
    [System.MonoTODOAttribute]
    void System.ComponentModel.Design.IDesigner.DoDefaultAction() { }
    [System.MonoTODOAttribute]
    void System.ComponentModel.Design.IDesignerFilter.PostFilterAttributes(System.Collections.IDictionary attributes) { }
    [System.MonoTODOAttribute]
    void System.ComponentModel.Design.IDesignerFilter.PostFilterEvents(System.Collections.IDictionary events) { }
    [System.MonoTODOAttribute]
    void System.ComponentModel.Design.IDesignerFilter.PostFilterProperties(System.Collections.IDictionary properties) { }
    [System.MonoTODOAttribute]
    void System.ComponentModel.Design.IDesignerFilter.PreFilterAttributes(System.Collections.IDictionary attributes) { }
    [System.MonoTODOAttribute]
    void System.ComponentModel.Design.IDesignerFilter.PreFilterEvents(System.Collections.IDictionary events) { }
    [System.MonoTODOAttribute]
    void System.ComponentModel.Design.IDesignerFilter.PreFilterProperties(System.Collections.IDictionary properties) { }
    [System.MonoTODOAttribute]
    object System.ComponentModel.Design.IRootDesigner.GetView(System.ComponentModel.Design.ViewTechnology viewTechnology) { return default(object); }
    [System.MonoTODOAttribute]
    void System.IDisposable.Dispose() { }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class XmlDataFileEditor : System.Web.UI.Design.UrlEditor {
    public XmlDataFileEditor() { }
    [System.MonoTODOAttribute]
    protected override string Caption { get { return default(string); } }
    [System.MonoTODOAttribute]
    protected override string Filter { get { return default(string); } }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public sealed partial class XmlDocumentSchema : System.Web.UI.Design.IDataSourceSchema {
    [System.MonoTODOAttribute]
    public XmlDocumentSchema(System.Xml.XmlDocument xmlDocument, string xPath) { }
    [System.MonoTODOAttribute]
    public System.Web.UI.Design.IDataSourceViewSchema[] GetViews() { return default(System.Web.UI.Design.IDataSourceViewSchema[]); }
  }
  public partial class XmlFileEditor : System.Drawing.Design.UITypeEditor {
    public XmlFileEditor() { }
    [System.MonoTODOAttribute]
    public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { return default(object); }
    public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { return default(System.Drawing.Design.UITypeEditorEditStyle); }
  }
  public partial class XmlUrlEditor : System.Web.UI.Design.UrlEditor {
    public XmlUrlEditor() { }
    protected override string Caption { get { return default(string); } }
    protected override string Filter { get { return default(string); } }
    protected override System.Web.UI.Design.UrlBuilderOptions Options { get { return default(System.Web.UI.Design.UrlBuilderOptions); } }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class XsdSchemaFileEditor : System.Web.UI.Design.UrlEditor {
    public XsdSchemaFileEditor() { }
    [System.MonoTODOAttribute]
    protected override string Caption { get { return default(string); } }
    [System.MonoTODOAttribute]
    protected override string Filter { get { return default(string); } }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class XslTransformFileEditor : System.Web.UI.Design.UrlEditor {
    public XslTransformFileEditor() { }
    [System.MonoTODOAttribute]
    protected override string Caption { get { return default(string); } }
    [System.MonoTODOAttribute]
    protected override string Filter { get { return default(string); } }
  }
  public partial class XslUrlEditor : System.Web.UI.Design.UrlEditor {
    public XslUrlEditor() { }
    protected override string Caption { get { return default(string); } }
    protected override string Filter { get { return default(string); } }
    protected override System.Web.UI.Design.UrlBuilderOptions Options { get { return default(System.Web.UI.Design.UrlBuilderOptions); } }
  }
}
namespace System.Web.UI.Design.WebControls {
  public partial class AdRotatorDesigner : System.Web.UI.Design.ControlDesigner {
    public AdRotatorDesigner() { }
    public override string GetDesignTimeHtml() { return default(string); }
  }
  public abstract partial class BaseDataBoundControlDesigner : System.Web.UI.Design.ControlDesigner {
    [System.MonoNotSupportedAttribute("")]
    protected BaseDataBoundControlDesigner() { }
    [System.MonoNotSupportedAttribute("")]
    public string DataSource { [System.MonoNotSupportedAttribute("")]get { return default(string); } [System.MonoNotSupportedAttribute("")]set { } }
    [System.MonoNotSupportedAttribute("")]
    public string DataSourceID { [System.MonoNotSupportedAttribute("")]get { return default(string); } [System.MonoNotSupportedAttribute("")]set { } }
    protected abstract bool ConnectToDataSource();
    protected abstract void CreateDataSource();
    protected abstract void DataBind(System.Web.UI.WebControls.BaseDataBoundControl dataBoundControl);
    protected abstract void DisconnectFromDataSource();
    [System.MonoNotSupportedAttribute("")]
    protected override void Dispose(bool disposing) { }
    [System.MonoNotSupportedAttribute("")]
    public override string GetDesignTimeHtml() { return default(string); }
    [System.MonoNotSupportedAttribute("")]
    protected override string GetEmptyDesignTimeHtml() { return default(string); }
    [System.MonoNotSupportedAttribute("")]
    protected override string GetErrorDesignTimeHtml(System.Exception e) { return default(string); }
    [System.MonoNotSupportedAttribute("")]
    public override void Initialize(System.ComponentModel.IComponent component) { }
    [System.MonoNotSupportedAttribute("")]
    protected virtual void OnDataSourceChanged(bool forceUpdateView) { }
    [System.MonoNotSupportedAttribute("")]
    protected virtual void OnSchemaRefreshed() { }
    [System.MonoNotSupportedAttribute("")]
    protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
    [System.MonoNotSupportedAttribute("")]
    public static System.Windows.Forms.DialogResult ShowCreateDataSourceDialog(System.Web.UI.Design.ControlDesigner controlDesigner, System.Type dataSourceType, bool configure, out string dataSourceID) { dataSourceID = default(string); return default(System.Windows.Forms.DialogResult); }
  }
  public abstract partial class BaseDataListComponentEditor : System.Windows.Forms.Design.WindowsFormsComponentEditor {
    public BaseDataListComponentEditor(int initial_page) { }
    public override bool EditComponent(System.ComponentModel.ITypeDescriptorContext context, object obj, System.Windows.Forms.IWin32Window parent) { return default(bool); }
    protected override int GetInitialComponentEditorPageIndex() { return default(int); }
  }
  public abstract partial class BaseDataListDesigner : System.Web.UI.Design.TemplatedControlDesigner, System.Web.UI.Design.IDataSourceProvider {
    public BaseDataListDesigner() { }
    public string DataKeyField { get { return default(string); } set { } }
    public string DataMember { get { return default(string); } set { } }
    public string DataSource { get { return default(string); } set { } }
    public override bool DesignTimeHtmlRequiresLoadComplete { get { return default(bool); } }
    public override System.ComponentModel.Design.DesignerVerbCollection Verbs { get { return default(System.ComponentModel.Design.DesignerVerbCollection); } }
    protected override void Dispose(bool disposing) { }
    protected System.Collections.IEnumerable GetDesignTimeDataSource(System.Collections.IEnumerable selected_data_source, int minimum_rows, out bool dummy_data_source) { dummy_data_source = default(bool); return default(System.Collections.IEnumerable); }
    protected System.Collections.IEnumerable GetDesignTimeDataSource(int minimum_rows, out bool dummy_data_source) { dummy_data_source = default(bool); return default(System.Collections.IEnumerable); }
    public virtual System.Collections.IEnumerable GetResolvedSelectedDataSource() { return default(System.Collections.IEnumerable); }
    public virtual object GetSelectedDataSource() { return default(object); }
    public override System.Collections.IEnumerable GetTemplateContainerDataSource(string template_name) { return default(System.Collections.IEnumerable); }
    public override void Initialize(System.ComponentModel.IComponent component) { }
    protected internal void InvokePropertyBuilder(int initial_page) { }
    protected void OnAutoFormat(object sender, System.EventArgs e) { }
    public override void OnComponentChanged(object sender, System.ComponentModel.Design.ComponentChangedEventArgs e) { }
    protected internal virtual void OnDataSourceChanged() { }
    protected void OnPropertyBuilder(object sender, System.EventArgs e) { }
    protected internal void OnStylesChanged() { }
    protected abstract void OnTemplateEditingVerbsChanged();
    protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
  }
  public partial class BaseValidatorDesigner : System.Web.UI.Design.ControlDesigner {
    public BaseValidatorDesigner() { }
    public override string GetDesignTimeHtml() { return default(string); }
  }
  public partial class ButtonDesigner : System.Web.UI.Design.ControlDesigner {
    public ButtonDesigner() { }
    public override string GetDesignTimeHtml() { return default(string); }
  }
  public partial class CalendarAutoFormatDialog : System.Windows.Forms.Form {
    public CalendarAutoFormatDialog(System.Web.UI.WebControls.Calendar calendar) { }
    protected void OnActivated(object source, System.EventArgs e) { }
    protected void OnDelayLoadActions() { }
    protected void OnOKClicked(object source, System.EventArgs e) { }
    protected void OnSelChangedScheme(object source, System.EventArgs e) { }
  }
  public partial class CalendarDesigner : System.Web.UI.Design.ControlDesigner {
    public CalendarDesigner() { }
    public override System.ComponentModel.Design.DesignerVerbCollection Verbs { get { return default(System.ComponentModel.Design.DesignerVerbCollection); } }
    public override void Initialize(System.ComponentModel.IComponent component) { }
    protected void OnAutoFormat(object sender, System.EventArgs e) { }
  }
  public partial class CheckBoxDesigner : System.Web.UI.Design.ControlDesigner {
    public CheckBoxDesigner() { }
    public override string GetDesignTimeHtml() { return default(string); }
  }
  public partial class DataBoundControlDesigner : System.Web.UI.Design.WebControls.BaseDataBoundControlDesigner, System.Web.UI.Design.IDataBindingSchemaProvider, System.Web.UI.Design.IDataSourceProvider {
    [System.MonoNotSupportedAttribute("")]
    public DataBoundControlDesigner() { }
    [System.MonoNotSupportedAttribute("")]
    public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { [System.MonoNotSupportedAttribute("")]get { return default(System.ComponentModel.Design.DesignerActionListCollection); } }
    [System.MonoNotSupportedAttribute("")]
    public string DataMember { [System.MonoNotSupportedAttribute("")]get { return default(string); } [System.MonoNotSupportedAttribute("")]set { } }
    [System.MonoNotSupportedAttribute("")]
    public System.Web.UI.Design.IDataSourceDesigner DataSourceDesigner { [System.MonoNotSupportedAttribute("")]get { return default(System.Web.UI.Design.IDataSourceDesigner); } }
    [System.MonoNotSupportedAttribute("")]
    public System.Web.UI.Design.DesignerDataSourceView DesignerView { [System.MonoNotSupportedAttribute("")]get { return default(System.Web.UI.Design.DesignerDataSourceView); } }
    [System.MonoNotSupportedAttribute("")]
    protected virtual int SampleRowCount { [System.MonoNotSupportedAttribute("")]get { return default(int); } }
    [System.MonoNotSupportedAttribute("")]
    bool System.Web.UI.Design.IDataBindingSchemaProvider.CanRefreshSchema { [System.MonoNotSupportedAttribute("")]get { return default(bool); } }
    [System.MonoNotSupportedAttribute("")]
    System.Web.UI.Design.IDataSourceViewSchema System.Web.UI.Design.IDataBindingSchemaProvider.Schema { get { return default(System.Web.UI.Design.IDataSourceViewSchema); } }
    [System.MonoNotSupportedAttribute("")]
    protected virtual bool UseDataSourcePickerActionList { [System.MonoNotSupportedAttribute("")]get { return default(bool); } }
    [System.MonoNotSupportedAttribute("")]
    protected override bool ConnectToDataSource() { return default(bool); }
    [System.MonoNotSupportedAttribute("")]
    protected override void CreateDataSource() { }
    [System.MonoNotSupportedAttribute("")]
    protected override void DataBind(System.Web.UI.WebControls.BaseDataBoundControl dataBoundControl) { }
    [System.MonoNotSupportedAttribute("")]
    protected override void DisconnectFromDataSource() { }
    [System.MonoNotSupportedAttribute("")]
    protected override void Dispose(bool disposing) { }
    [System.MonoNotSupportedAttribute("")]
    protected virtual System.Collections.IEnumerable GetDesignTimeDataSource() { return default(System.Collections.IEnumerable); }
    [System.MonoNotSupportedAttribute("")]
    protected virtual System.Collections.IEnumerable GetSampleDataSource() { return default(System.Collections.IEnumerable); }
    [System.MonoNotSupportedAttribute("")]
    protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
    [System.MonoNotSupportedAttribute("")]
    void System.Web.UI.Design.IDataBindingSchemaProvider.RefreshSchema(bool preferSilent) { }
    [System.MonoNotSupportedAttribute("")]
    System.Collections.IEnumerable System.Web.UI.Design.IDataSourceProvider.GetResolvedSelectedDataSource() { return default(System.Collections.IEnumerable); }
    [System.MonoNotSupportedAttribute("")]
    object System.Web.UI.Design.IDataSourceProvider.GetSelectedDataSource() { return default(object); }
  }
  public partial class DataListComponentEditor : System.Web.UI.Design.WebControls.BaseDataListComponentEditor {
    public DataListComponentEditor() : base (default(int)) { }
    public DataListComponentEditor(int initial_page) : base (default(int)) { }
    public override bool EditComponent(System.ComponentModel.ITypeDescriptorContext context, object obj, System.Windows.Forms.IWin32Window parent) { return default(bool); }
    protected override System.Type[] GetComponentEditorPages() { return default(System.Type[]); }
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
    [System.MonoTODOAttribute]
    public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { return default(System.ComponentModel.TypeConverter.StandardValuesCollection); }
    public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    protected virtual bool IsValidDataSource(System.ComponentModel.IComponent component) { return default(bool); }
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
  public partial class HyperLinkDesigner : System.Web.UI.Design.TextControlDesigner {
    public HyperLinkDesigner() { }
    public override string GetDesignTimeHtml() { return default(string); }
  }
  public partial class LabelDesigner : System.Web.UI.Design.TextControlDesigner {
    public LabelDesigner() { }
  }
  public partial class LinkButtonDesigner : System.Web.UI.Design.TextControlDesigner {
    public LinkButtonDesigner() { }
  }
  public partial class ListControlDataBindingHandler : System.Web.UI.Design.DataBindingHandler {
    public ListControlDataBindingHandler() { }
    public override void DataBindControl(System.ComponentModel.Design.IDesignerHost designer_host, System.Web.UI.Control control) { }
  }
  public partial class ListControlDesigner : System.Web.UI.Design.WebControls.DataBoundControlDesigner {
    public ListControlDesigner() { }
    public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { return default(System.ComponentModel.Design.DesignerActionListCollection); } }
    public string DataKeyField { get { return default(string); } set { } }
    public new string DataMember { get { return default(string); } set { } }
    public new string DataSource { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string DataTextField { get { return default(string); } set { } }
    public string DataValueField { get { return default(string); } set { } }
    protected override bool UseDataSourcePickerActionList { get { return default(bool); } }
    protected override void DataBind(System.Web.UI.WebControls.BaseDataBoundControl dataBoundControl) { }
    public override string GetDesignTimeHtml() { return default(string); }
    public virtual System.Collections.IEnumerable GetResolvedSelectedDataSource() { return default(System.Collections.IEnumerable); }
    public virtual object GetSelectedDataSource() { return default(object); }
    public override void Initialize(System.ComponentModel.IComponent component) { }
    public override void OnComponentChanged(object sender, System.ComponentModel.Design.ComponentChangedEventArgs e) { }
    protected internal virtual void OnDataSourceChanged() { }
    protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
  }
  public partial class PanelDesigner : System.Web.UI.Design.ReadWriteControlDesigner {
    public PanelDesigner() { }
    protected override void MapPropertyToStyle(string name, object value) { }
    protected override void OnBehaviorAttached() { }
  }
  public partial class RegexEditorDialog : System.Windows.Forms.Form {
    public RegexEditorDialog() { }
    public string RegularExpression { get { return default(string); } set { } }
    protected void CmdHelp_Click(object sender, System.EventArgs e) { }
    protected void CmdOK_Click(object sender, System.EventArgs e) { }
    protected void CmdTestValidate_Click(object sender, System.EventArgs e) { }
    protected override void Dispose(bool disposing) { }
    protected void LstStandardExpressions_SelectedIndexChanged(object sender, System.EventArgs e) { }
    protected void RegexTypeEditor_Activated(object sender, System.EventArgs e) { }
    protected void TxtExpression_Changed(object sender, System.EventArgs e) { }
  }
  public partial class RegexTypeEditor : System.Drawing.Design.UITypeEditor {
    public RegexTypeEditor() { }
    public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { return default(object); }
    public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { return default(System.Drawing.Design.UITypeEditorEditStyle); }
  }
  public partial class RepeaterDesigner : System.Web.UI.Design.ControlDesigner, System.Web.UI.Design.IDataSourceProvider {
    public RepeaterDesigner() { }
    public string DataMember { get { return default(string); } set { } }
    public string DataSource { get { return default(string); } set { } }
    protected bool TemplatesExist { get { return default(bool); } }
    protected override void Dispose(bool disposing) { }
    protected System.Collections.IEnumerable GetDesignTimeDataSource(System.Collections.IEnumerable selected_data_source, int minimum_rows) { return default(System.Collections.IEnumerable); }
    protected System.Collections.IEnumerable GetDesignTimeDataSource(int minimum_rows) { return default(System.Collections.IEnumerable); }
    public override string GetDesignTimeHtml() { return default(string); }
    protected override string GetEmptyDesignTimeHtml() { return default(string); }
    protected override string GetErrorDesignTimeHtml(System.Exception e) { return default(string); }
    public virtual System.Collections.IEnumerable GetResolvedSelectedDataSource() { return default(System.Collections.IEnumerable); }
    public virtual object GetSelectedDataSource() { return default(object); }
    public override void Initialize(System.ComponentModel.IComponent component) { }
    public override void OnComponentChanged(object sender, System.ComponentModel.Design.ComponentChangedEventArgs e) { }
    protected internal virtual void OnDataSourceChanged() { }
    protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
  }
  public partial class TableCellsCollectionEditor : System.ComponentModel.Design.CollectionEditor {
    public TableCellsCollectionEditor(System.Type type) : base (default(System.Type)) { }
    protected override bool CanSelectMultipleInstances() { return default(bool); }
    protected override object CreateInstance(System.Type item_type) { return default(object); }
  }
  public partial class TableDesigner : System.Web.UI.Design.ControlDesigner {
    public TableDesigner() { }
    public override string GetDesignTimeHtml() { return default(string); }
    public override string GetPersistInnerHtml() { return default(string); }
  }
  public partial class TableRowsCollectionEditor : System.ComponentModel.Design.CollectionEditor {
    public TableRowsCollectionEditor(System.Type type) : base (default(System.Type)) { }
    protected override bool CanSelectMultipleInstances() { return default(bool); }
    protected override object CreateInstance(System.Type item_type) { return default(object); }
  }
  public partial class XmlDesigner : System.Web.UI.Design.ControlDesigner {
    public XmlDesigner() { }
    protected override void Dispose(bool disposing) { }
    public override string GetDesignTimeHtml() { return default(string); }
    protected override string GetEmptyDesignTimeHtml() { return default(string); }
    public override void Initialize(System.ComponentModel.IComponent component) { }
  }
}
namespace System.Windows.Forms.Design {
  public sealed partial class AnchorEditor : System.Drawing.Design.UITypeEditor {
    public AnchorEditor() { }
    public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { return default(object); }
    public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { return default(System.Drawing.Design.UITypeEditorEditStyle); }
  }
  [System.MonoTODOAttribute]
  public partial class AxImporter {
    [System.MonoTODOAttribute]
    public AxImporter(System.Windows.Forms.Design.AxImporter.Options options) { }
    [System.MonoTODOAttribute]
    public System.String[] GeneratedAssemblies { get { return default(System.String[]); } }
    [System.MonoTODOAttribute]
    public System.String[] GeneratedSources { get { return default(System.String[]); } }
    [System.MonoTODOAttribute]
    public System.Runtime.InteropServices.TYPELIBATTR[] GeneratedTypeLibAttributes { get { return default(System.Runtime.InteropServices.TYPELIBATTR[]); } }
    [System.MonoTODOAttribute]
    public string GenerateFromFile(System.IO.FileInfo file) { return default(string); }
    [System.MonoTODOAttribute]
    public string GenerateFromTypeLibrary(System.Runtime.InteropServices.UCOMITypeLib typeLib) { return default(string); }
    [System.MonoTODOAttribute]
    public string GenerateFromTypeLibrary(System.Runtime.InteropServices.UCOMITypeLib typeLib, System.Guid clsid) { return default(string); }
    [System.MonoTODOAttribute]
    public static string GetFileOfTypeLib(ref System.Runtime.InteropServices.TYPELIBATTR tlibattr) { return default(string); }
    public partial interface IReferenceResolver {
      string ResolveActiveXReference(System.Runtime.InteropServices.UCOMITypeLib typeLib);
      string ResolveComReference(System.Reflection.AssemblyName name);
      string ResolveComReference(System.Runtime.InteropServices.UCOMITypeLib typeLib);
      string ResolveManagedReference(string assemName);
    }
    public sealed partial class Options {
      [System.MonoTODOAttribute]
      public bool delaySign;
      [System.MonoTODOAttribute]
      public bool genSources;
      [System.MonoTODOAttribute]
      public string keyContainer;
      [System.MonoTODOAttribute]
      public string keyFile;
      [System.MonoTODOAttribute]
      public System.Reflection.StrongNameKeyPair keyPair;
      [System.MonoTODOAttribute]
      public bool msBuildErrors;
      [System.MonoTODOAttribute]
      public bool noLogo;
      [System.MonoTODOAttribute]
      public string outputDirectory;
      [System.MonoTODOAttribute]
      public string outputName;
      [System.MonoTODOAttribute]
      public bool overwriteRCW;
      [System.MonoTODOAttribute]
      public System.Byte[] publicKey;
      [System.MonoTODOAttribute]
      public System.Windows.Forms.Design.AxImporter.IReferenceResolver references;
      [System.MonoTODOAttribute]
      public bool silentMode;
      [System.MonoTODOAttribute]
      public bool verboseMode;
      public Options() { }
    }
  }
  public partial class AxParameterData {
    [System.MonoTODOAttribute]
    public AxParameterData(System.Reflection.ParameterInfo info) { }
    [System.MonoTODOAttribute]
    public AxParameterData(System.Reflection.ParameterInfo info, bool ignoreByRefs) { }
    [System.MonoTODOAttribute]
    public AxParameterData(string inname, string typeName) { }
    [System.MonoTODOAttribute]
    public AxParameterData(string inname, System.Type type) { }
    public System.CodeDom.FieldDirection Direction { get { return default(System.CodeDom.FieldDirection); } }
    public bool IsByRef { get { return default(bool); } }
    public bool IsIn { get { return default(bool); } }
    public bool IsOptional { get { return default(bool); } }
    public bool IsOut { get { return default(bool); } }
    public string Name { get { return default(string); } [System.MonoTODOAttribute]set { } }
    public System.Type ParameterType { get { return default(System.Type); } }
    [System.MonoTODOAttribute]
    public string TypeName { get { return default(string); } }
    [System.MonoTODOAttribute]
    public static System.Windows.Forms.Design.AxParameterData[] Convert(System.Reflection.ParameterInfo[] infos) { return default(System.Windows.Forms.Design.AxParameterData[]); }
    [System.MonoTODOAttribute]
    public static System.Windows.Forms.Design.AxParameterData[] Convert(System.Reflection.ParameterInfo[] infos, bool ignoreByRefs) { return default(System.Windows.Forms.Design.AxParameterData[]); }
  }
  public partial class AxWrapperGen {
    [System.MonoTODOAttribute]
    public static System.Collections.ArrayList GeneratedSources;
    [System.MonoTODOAttribute]
    public AxWrapperGen(System.Type axType) { }
  }
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  public partial class BorderSidesEditor : System.Drawing.Design.UITypeEditor {
    public BorderSidesEditor() { }
    [System.MonoTODOAttribute]
    public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { return default(object); }
    [System.MonoTODOAttribute]
    public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { return default(System.Drawing.Design.UITypeEditorEditStyle); }
  }
  public partial class ComponentDocumentDesigner : System.ComponentModel.Design.ComponentDesigner, System.ComponentModel.Design.IDesigner, System.ComponentModel.Design.IRootDesigner, System.ComponentModel.Design.ITypeDescriptorFilterService, System.Drawing.Design.IToolboxUser, System.IDisposable {
    [System.MonoTODOAttribute]
    public ComponentDocumentDesigner() { }
    [System.MonoTODOAttribute]
    public System.Windows.Forms.Control Control { get { return default(System.Windows.Forms.Control); } }
    System.ComponentModel.Design.ViewTechnology[] System.ComponentModel.Design.IRootDesigner.SupportedTechnologies { get { return default(System.ComponentModel.Design.ViewTechnology[]); } }
    public bool TrayAutoArrange { get { return default(bool); } set { } }
    public bool TrayLargeIcon { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    protected override void Dispose(bool disposing) { }
    protected virtual bool GetToolSupported(System.Drawing.Design.ToolboxItem tool) { return default(bool); }
    [System.MonoTODOAttribute]
    public override void Initialize(System.ComponentModel.IComponent component) { }
    [System.MonoTODOAttribute]
    protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
    [System.MonoTODOAttribute]
    object System.ComponentModel.Design.IRootDesigner.GetView(System.ComponentModel.Design.ViewTechnology technology) { return default(object); }
    [System.MonoTODOAttribute]
    bool System.ComponentModel.Design.ITypeDescriptorFilterService.FilterAttributes(System.ComponentModel.IComponent component, System.Collections.IDictionary attributes) { return default(bool); }
    [System.MonoTODOAttribute]
    bool System.ComponentModel.Design.ITypeDescriptorFilterService.FilterEvents(System.ComponentModel.IComponent component, System.Collections.IDictionary events) { return default(bool); }
    [System.MonoTODOAttribute]
    bool System.ComponentModel.Design.ITypeDescriptorFilterService.FilterProperties(System.ComponentModel.IComponent component, System.Collections.IDictionary properties) { return default(bool); }
    bool System.Drawing.Design.IToolboxUser.GetToolSupported(System.Drawing.Design.ToolboxItem tool) { return default(bool); }
    [System.MonoTODOAttribute]
    void System.Drawing.Design.IToolboxUser.ToolPicked(System.Drawing.Design.ToolboxItem tool) { }
  }
  [System.ComponentModel.DesignTimeVisibleAttribute(false)]
  [System.ComponentModel.ProvidePropertyAttribute("Location", typeof(System.ComponentModel.IComponent))]
  [System.ComponentModel.ToolboxItemAttribute(false)]
  public partial class ComponentTray : System.Windows.Forms.ScrollableControl, System.ComponentModel.IExtenderProvider {
    public ComponentTray(System.ComponentModel.Design.IDesigner mainDesigner, System.IServiceProvider serviceProvider) { }
    public bool AutoArrange { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public int ComponentCount { get { return default(int); } }
    public bool ShowLargeIcons { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public virtual void AddComponent(System.ComponentModel.IComponent component) { }
    protected virtual bool CanCreateComponentFromTool(System.Drawing.Design.ToolboxItem tool) { return default(bool); }
    protected virtual bool CanDisplayComponent(System.ComponentModel.IComponent component) { return default(bool); }
    [System.MonoTODOAttribute]
    public void CreateComponentFromTool(System.Drawing.Design.ToolboxItem tool) { }
    [System.MonoTODOAttribute]
    protected void DisplayError(System.Exception e) { }
    protected override void Dispose(bool disposing) { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.CategoryAttribute("Layout")]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.DesignOnlyAttribute(true)]
    [System.ComponentModel.LocalizableAttribute(false)]
    [System.MonoTODOAttribute]
    public System.Drawing.Point GetLocation(System.ComponentModel.IComponent receiver) { return default(System.Drawing.Point); }
    [System.MonoTODOAttribute]
    public System.ComponentModel.IComponent GetNextComponent(System.ComponentModel.IComponent component, bool forward) { return default(System.ComponentModel.IComponent); }
    protected override object GetService(System.Type service) { return default(object); }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.CategoryAttribute("Layout")]
    [System.ComponentModel.DesignOnlyAttribute(true)]
    [System.ComponentModel.LocalizableAttribute(false)]
    [System.MonoTODOAttribute]
    public System.Drawing.Point GetTrayLocation(System.ComponentModel.IComponent receiver) { return default(System.Drawing.Point); }
    [System.MonoTODOAttribute]
    public bool IsTrayComponent(System.ComponentModel.IComponent comp) { return default(bool); }
    [System.MonoTODOAttribute]
    protected override void OnDragDrop(System.Windows.Forms.DragEventArgs de) { }
    [System.MonoTODOAttribute]
    protected override void OnDragEnter(System.Windows.Forms.DragEventArgs de) { }
    [System.MonoTODOAttribute]
    protected override void OnDragLeave(System.EventArgs e) { }
    [System.MonoTODOAttribute]
    protected override void OnDragOver(System.Windows.Forms.DragEventArgs de) { }
    [System.MonoTODOAttribute]
    protected override void OnGiveFeedback(System.Windows.Forms.GiveFeedbackEventArgs gfevent) { }
    [System.MonoTODOAttribute]
    protected override void OnLayout(System.Windows.Forms.LayoutEventArgs levent) { }
    [System.MonoTODOAttribute]
    protected virtual void OnLostCapture() { }
    [System.MonoTODOAttribute]
    protected override void OnMouseDoubleClick(System.Windows.Forms.MouseEventArgs e) { }
    [System.MonoTODOAttribute]
    protected override void OnMouseDown(System.Windows.Forms.MouseEventArgs e) { }
    [System.MonoTODOAttribute]
    protected override void OnMouseMove(System.Windows.Forms.MouseEventArgs e) { }
    [System.MonoTODOAttribute]
    protected override void OnMouseUp(System.Windows.Forms.MouseEventArgs e) { }
    [System.MonoTODOAttribute]
    protected override void OnPaint(System.Windows.Forms.PaintEventArgs pe) { }
    [System.MonoTODOAttribute]
    protected virtual void OnSetCursor() { }
    [System.MonoTODOAttribute]
    public virtual void RemoveComponent(System.ComponentModel.IComponent component) { }
    [System.MonoTODOAttribute]
    public void SetLocation(System.ComponentModel.IComponent receiver, System.Drawing.Point location) { }
    [System.MonoTODOAttribute]
    public void SetTrayLocation(System.ComponentModel.IComponent receiver, System.Drawing.Point location) { }
    bool System.ComponentModel.IExtenderProvider.CanExtend(object component) { return default(bool); }
    [System.MonoTODOAttribute]
    protected override void WndProc(ref System.Windows.Forms.Message m) { }
  }
  public partial class ControlDesigner : System.ComponentModel.Design.ComponentDesigner {
    protected System.Windows.Forms.AccessibleObject accessibilityObj;
    protected static readonly System.Drawing.Point InvalidPoint;
    public ControlDesigner() { }
    public virtual System.Windows.Forms.AccessibleObject AccessibilityObject { get { return default(System.Windows.Forms.AccessibleObject); } }
    public override System.Collections.ICollection AssociatedComponents { get { return default(System.Collections.ICollection); } }
    [System.MonoTODOAttribute]
    public bool AutoResizeHandles { get { return default(bool); } set { } }
    protected internal System.Windows.Forms.Design.Behavior.BehaviorService BehaviorService { get { return default(System.Windows.Forms.Design.Behavior.BehaviorService); } }
    public virtual System.Windows.Forms.Control Control { get { return default(System.Windows.Forms.Control); } }
    protected virtual bool EnableDragRect { get { return default(bool); } }
    [System.MonoTODOAttribute]
    protected override System.ComponentModel.InheritanceAttribute InheritanceAttribute { get { return default(System.ComponentModel.InheritanceAttribute); } }
    protected override System.ComponentModel.IComponent ParentComponent { get { return default(System.ComponentModel.IComponent); } }
    [System.MonoTODOAttribute]
    public virtual bool ParticipatesWithSnapLines { get { return default(bool); } }
    public virtual System.Windows.Forms.Design.SelectionRules SelectionRules { get { return default(System.Windows.Forms.Design.SelectionRules); } }
    [System.MonoTODOAttribute]
    public virtual System.Collections.IList SnapLines { get { return default(System.Collections.IList); } }
    protected void BaseWndProc(ref System.Windows.Forms.Message m) { }
    public virtual bool CanBeParentedTo(System.ComponentModel.Design.IDesigner parentDesigner) { return default(bool); }
    protected void DefWndProc(ref System.Windows.Forms.Message m) { }
    protected void DisplayError(System.Exception e) { }
    protected override void Dispose(bool disposing) { }
    protected bool EnableDesignMode(System.Windows.Forms.Control child, string name) { return default(bool); }
    protected void EnableDragDrop(bool value) { }
    [System.MonoTODOAttribute]
    protected virtual System.Windows.Forms.Design.Behavior.ControlBodyGlyph GetControlGlyph(System.Windows.Forms.Design.Behavior.GlyphSelectionType selectionType) { return default(System.Windows.Forms.Design.Behavior.ControlBodyGlyph); }
    [System.MonoTODOAttribute]
    public virtual System.Windows.Forms.Design.Behavior.GlyphCollection GetGlyphs(System.Windows.Forms.Design.Behavior.GlyphSelectionType selectionType) { return default(System.Windows.Forms.Design.Behavior.GlyphCollection); }
    protected virtual bool GetHitTest(System.Drawing.Point point) { return default(bool); }
    protected void HookChildControls(System.Windows.Forms.Control firstControl) { }
    public override void Initialize(System.ComponentModel.IComponent component) { }
    [System.MonoTODOAttribute]
    public override void InitializeExistingComponent(System.Collections.IDictionary defaultValues) { }
    [System.MonoTODOAttribute]
    public override void InitializeNewComponent(System.Collections.IDictionary defaultValues) { }
    public virtual System.Windows.Forms.Design.ControlDesigner InternalControlDesigner(int internalControlIndex) { return default(System.Windows.Forms.Design.ControlDesigner); }
    public virtual int NumberOfInternalControlDesigners() { return default(int); }
    protected virtual void OnContextMenu(int x, int y) { }
    protected virtual void OnCreateHandle() { }
    [System.MonoTODOAttribute]
    protected virtual void OnDragComplete(System.Windows.Forms.DragEventArgs de) { }
    protected virtual void OnDragDrop(System.Windows.Forms.DragEventArgs e) { }
    protected virtual void OnDragEnter(System.Windows.Forms.DragEventArgs e) { }
    protected virtual void OnDragLeave(System.EventArgs e) { }
    protected virtual void OnDragOver(System.Windows.Forms.DragEventArgs e) { }
    protected virtual void OnGiveFeedback(System.Windows.Forms.GiveFeedbackEventArgs e) { }
    protected virtual void OnMouseDragBegin(int x, int y) { }
    protected virtual void OnMouseDragEnd(bool cancel) { }
    protected virtual void OnMouseDragMove(int x, int y) { }
    protected virtual void OnMouseEnter() { }
    protected virtual void OnMouseHover() { }
    protected virtual void OnMouseLeave() { }
    protected virtual void OnPaintAdornments(System.Windows.Forms.PaintEventArgs pe) { }
    public override void OnSetComponentDefaults() { }
    protected virtual void OnSetCursor() { }
    protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
    protected void UnhookChildControls(System.Windows.Forms.Control firstControl) { }
    protected virtual void WndProc(ref System.Windows.Forms.Message m) { }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ControlDesignerAccessibleObject : System.Windows.Forms.AccessibleObject {
      [System.MonoTODOAttribute]
      public ControlDesignerAccessibleObject(System.Windows.Forms.Design.ControlDesigner designer, System.Windows.Forms.Control control) { }
      [System.MonoTODOAttribute]
      public override System.Drawing.Rectangle Bounds { get { return default(System.Drawing.Rectangle); } }
      [System.MonoTODOAttribute]
      public override string DefaultAction { get { return default(string); } }
      [System.MonoTODOAttribute]
      public override string Description { get { return default(string); } }
      [System.MonoTODOAttribute]
      public override string Name { get { return default(string); } }
      [System.MonoTODOAttribute]
      public override System.Windows.Forms.AccessibleObject Parent { get { return default(System.Windows.Forms.AccessibleObject); } }
      [System.MonoTODOAttribute]
      public override System.Windows.Forms.AccessibleRole Role { get { return default(System.Windows.Forms.AccessibleRole); } }
      [System.MonoTODOAttribute]
      public override System.Windows.Forms.AccessibleStates State { get { return default(System.Windows.Forms.AccessibleStates); } }
      [System.MonoTODOAttribute]
      public override string Value { get { return default(string); } }
      [System.MonoTODOAttribute]
      public override System.Windows.Forms.AccessibleObject GetChild(int index) { return default(System.Windows.Forms.AccessibleObject); }
      [System.MonoTODOAttribute]
      public override int GetChildCount() { return default(int); }
      [System.MonoTODOAttribute]
      public override System.Windows.Forms.AccessibleObject GetFocused() { return default(System.Windows.Forms.AccessibleObject); }
      [System.MonoTODOAttribute]
      public override System.Windows.Forms.AccessibleObject GetSelected() { return default(System.Windows.Forms.AccessibleObject); }
      [System.MonoTODOAttribute]
      public override System.Windows.Forms.AccessibleObject HitTest(int x, int y) { return default(System.Windows.Forms.AccessibleObject); }
    }
  }
  public partial class DesignerOptions {
    public DesignerOptions() { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.MonoTODOAttribute]
    public virtual bool EnableInSituEditing { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public virtual System.Drawing.Size GridSize { get { return default(System.Drawing.Size); } set { } }
    [System.MonoTODOAttribute]
    public virtual bool ObjectBoundSmartTagAutoShow { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public virtual bool ShowGrid { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public virtual bool SnapToGrid { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public virtual bool UseOptimizedCodeGeneration { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public virtual bool UseSmartTags { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
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
    protected virtual void EnsureMenuEditorService(System.ComponentModel.IComponent component) { }
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
    public partial class DesignerViewFrame : System.Windows.Forms.UserControl {
      public DesignerViewFrame(System.Windows.Forms.Control designedControl, System.Windows.Forms.Design.ComponentTray tray) { }
      public System.Windows.Forms.Design.ComponentTray ComponentTray { get { return default(System.Windows.Forms.Design.ComponentTray); } set { } }
      public System.Windows.Forms.Control DesignedControl { get { return default(System.Windows.Forms.Control); } set { } }
      protected override void Dispose(bool disposing) { }
      public void HideComponentTray() { }
      public void ShowComponentTray() { }
    }
  }
  public sealed partial class EventHandlerService {
    public EventHandlerService(System.Windows.Forms.Control focusWnd) { }
    public System.Windows.Forms.Control FocusWindow { get { return default(System.Windows.Forms.Control); } }
    public event System.EventHandler EventHandlerChanged { add { } remove { } }
    [System.MonoTODOAttribute]
    public object GetHandler(System.Type handlerType) { return default(object); }
    [System.MonoTODOAttribute]
    public void PopHandler(object handler) { }
    [System.MonoTODOAttribute]
    public void PushHandler(object handler) { }
  }
  public partial class FileNameEditor : System.Drawing.Design.UITypeEditor {
    public FileNameEditor() { }
    [System.MonoTODOAttribute]
    public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { return default(object); }
    public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { return default(System.Drawing.Design.UITypeEditorEditStyle); }
    [System.MonoTODOAttribute]
    protected virtual void InitializeDialog(System.Windows.Forms.OpenFileDialog openFileDialog) { }
  }
  [System.MonoTODOAttribute]
  public partial class FolderNameEditor : System.Drawing.Design.UITypeEditor {
    public FolderNameEditor() { }
    public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { return default(object); }
    public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { return default(System.Drawing.Design.UITypeEditorEditStyle); }
    protected virtual void InitializeDialog(System.Windows.Forms.Design.FolderNameEditor.FolderBrowser folderBrowser) { }
    protected sealed partial class FolderBrowser : System.ComponentModel.Component {
      [System.MonoTODOAttribute]
      public FolderBrowser() { }
      public string Description { get { return default(string); } set { } }
      public string DirectoryPath { get { return default(string); } }
      public System.Windows.Forms.Design.FolderNameEditor.FolderBrowserFolder StartLocation { get { return default(System.Windows.Forms.Design.FolderNameEditor.FolderBrowserFolder); } set { } }
      public System.Windows.Forms.Design.FolderNameEditor.FolderBrowserStyles Style { get { return default(System.Windows.Forms.Design.FolderNameEditor.FolderBrowserStyles); } set { } }
      [System.MonoTODOAttribute]
      public System.Windows.Forms.DialogResult ShowDialog() { return default(System.Windows.Forms.DialogResult); }
      [System.MonoTODOAttribute]
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
  public partial class ImageListCodeDomSerializer : System.ComponentModel.Design.Serialization.CodeDomSerializer {
    public ImageListCodeDomSerializer() { }
    [System.MonoTODOAttribute]
    public override object Deserialize(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object codeObject) { return default(object); }
    [System.MonoTODOAttribute]
    public override object Serialize(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object value) { return default(object); }
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
    [System.MonoTODOAttribute]
    public virtual System.Globalization.CultureInfo Culture { get { return default(System.Globalization.CultureInfo); } }
    public abstract string Mask { get; }
    public abstract string Name { get; }
    public abstract string Sample { get; }
    public abstract System.Type ValidatingType { get; }
    [System.MonoTODOAttribute]
    public override bool Equals(object maskDescriptor) { return default(bool); }
    [System.MonoTODOAttribute]
    public override int GetHashCode() { return default(int); }
    [System.MonoTODOAttribute]
    public static bool IsValidMaskDescriptor(System.Windows.Forms.Design.MaskDescriptor maskDescriptor) { return default(bool); }
    [System.MonoTODOAttribute]
    public static bool IsValidMaskDescriptor(System.Windows.Forms.Design.MaskDescriptor maskDescriptor, out string validationErrorDescription) { validationErrorDescription = default(string); return default(bool); }
    [System.MonoTODOAttribute]
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
    [System.MonoTODOAttribute]
    protected virtual bool AllowControlLasso { get { return default(bool); } }
    [System.MonoTODOAttribute]
    protected virtual bool AllowGenericDragBox { get { return default(bool); } }
    [System.MonoTODOAttribute]
    protected internal virtual bool AllowSetChildIndexOnDrop { get { return default(bool); } }
    protected virtual System.Drawing.Point DefaultControlLocation { get { return default(System.Drawing.Point); } }
    protected virtual bool DrawGrid { get { return default(bool); } set { } }
    protected override bool EnableDragRect { get { return default(bool); } }
    protected System.Drawing.Size GridSize { get { return default(System.Drawing.Size); } set { } }
    [System.MonoTODOAttribute]
    protected System.Drawing.Design.ToolboxItem MouseDragTool { get { return default(System.Drawing.Design.ToolboxItem); } }
    [System.MonoTODOAttribute]
    public override System.Collections.IList SnapLines { get { return default(System.Collections.IList); } }
    [System.MonoTODOAttribute]
    protected void AddPaddingSnapLines(ref System.Collections.ArrayList snapLines) { }
    public virtual bool CanParent(System.Windows.Forms.Control control) { return default(bool); }
    public virtual bool CanParent(System.Windows.Forms.Design.ControlDesigner designer) { return default(bool); }
    protected void CreateTool(System.Drawing.Design.ToolboxItem tool) { }
    protected void CreateTool(System.Drawing.Design.ToolboxItem tool, System.Drawing.Point location) { }
    protected void CreateTool(System.Drawing.Design.ToolboxItem tool, System.Drawing.Rectangle bounds) { }
    protected virtual System.ComponentModel.IComponent[] CreateToolCore(System.Drawing.Design.ToolboxItem tool, int x, int y, int width, int height, bool hasLocation, bool hasSize) { return default(System.ComponentModel.IComponent[]); }
    protected override void Dispose(bool disposing) { }
    protected System.Windows.Forms.Control GetControl(object component) { return default(System.Windows.Forms.Control); }
    [System.MonoTODOAttribute]
    protected override System.Windows.Forms.Design.Behavior.ControlBodyGlyph GetControlGlyph(System.Windows.Forms.Design.Behavior.GlyphSelectionType selectionType) { return default(System.Windows.Forms.Design.Behavior.ControlBodyGlyph); }
    [System.MonoTODOAttribute]
    public override System.Windows.Forms.Design.Behavior.GlyphCollection GetGlyphs(System.Windows.Forms.Design.Behavior.GlyphSelectionType selectionType) { return default(System.Windows.Forms.Design.Behavior.GlyphCollection); }
    [System.MonoTODOAttribute]
    protected virtual System.Windows.Forms.Control GetParentForComponent(System.ComponentModel.IComponent component) { return default(System.Windows.Forms.Control); }
    [System.MonoTODOAttribute]
    protected System.Drawing.Rectangle GetUpdatedRect(System.Drawing.Rectangle originalRect, System.Drawing.Rectangle dragRect, bool updateSize) { return default(System.Drawing.Rectangle); }
    public override void Initialize(System.ComponentModel.IComponent component) { }
    [System.MonoTODOAttribute]
    public override void InitializeNewComponent(System.Collections.IDictionary defaultValues) { }
    protected static void InvokeCreateTool(System.Windows.Forms.Design.ParentControlDesigner toInvoke, System.Drawing.Design.ToolboxItem tool) { }
    protected override void OnDragComplete(System.Windows.Forms.DragEventArgs de) { }
    protected override void OnDragDrop(System.Windows.Forms.DragEventArgs e) { }
    protected override void OnDragEnter(System.Windows.Forms.DragEventArgs e) { }
    protected override void OnDragLeave(System.EventArgs e) { }
    protected override void OnDragOver(System.Windows.Forms.DragEventArgs e) { }
    protected override void OnMouseDragBegin(int x, int y) { }
    protected override void OnMouseDragEnd(bool cancel) { }
    protected override void OnMouseDragMove(int x, int y) { }
    protected override void OnPaintAdornments(System.Windows.Forms.PaintEventArgs pe) { }
    protected override void OnSetCursor() { }
    protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
  }
  public partial class ScrollableControlDesigner : System.Windows.Forms.Design.ParentControlDesigner {
    public ScrollableControlDesigner() { }
    protected override bool GetHitTest(System.Drawing.Point point) { return default(bool); }
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
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
  public partial class ShortcutKeysEditor : System.Drawing.Design.UITypeEditor {
    public ShortcutKeysEditor() { }
    [System.MonoTODOAttribute]
    public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { return default(object); }
    [System.MonoTODOAttribute]
    public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { return default(System.Drawing.Design.UITypeEditorEditStyle); }
  }
  public partial class WindowsFormsDesignerOptionService : System.ComponentModel.Design.DesignerOptionService {
    public WindowsFormsDesignerOptionService() { }
    public virtual System.Windows.Forms.Design.DesignerOptions CompatibilityOptions { get { return default(System.Windows.Forms.Design.DesignerOptions); } }
    [System.MonoTODOAttribute]
    protected override void PopulateOptionCollection(System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection options) { }
  }
}
namespace System.Windows.Forms.Design.Behavior {
  public sealed partial class Adorner {
    public Adorner() { }
    [System.MonoTODOAttribute]
    public System.Windows.Forms.Design.Behavior.BehaviorService BehaviorService { get { return default(System.Windows.Forms.Design.Behavior.BehaviorService); } set { } }
    [System.MonoTODOAttribute]
    public bool Enabled { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public System.Windows.Forms.Design.Behavior.GlyphCollection Glyphs { get { return default(System.Windows.Forms.Design.Behavior.GlyphCollection); } }
    [System.MonoTODOAttribute]
    public void Invalidate() { }
    [System.MonoTODOAttribute]
    public void Invalidate(System.Drawing.Rectangle rectangle) { }
    [System.MonoTODOAttribute]
    public void Invalidate(System.Drawing.Region region) { }
  }
  public abstract partial class Behavior {
    [System.MonoTODOAttribute]
    protected Behavior() { }
    [System.MonoTODOAttribute]
    protected Behavior(bool callParentBehavior, System.Windows.Forms.Design.Behavior.BehaviorService behaviorService) { }
    [System.MonoTODOAttribute]
    public virtual System.Windows.Forms.Cursor Cursor { get { return default(System.Windows.Forms.Cursor); } }
    [System.MonoTODOAttribute]
    public virtual bool DisableAllCommands { get { return default(bool); } }
    [System.MonoTODOAttribute]
    public virtual System.ComponentModel.Design.MenuCommand FindCommand(System.ComponentModel.Design.CommandID commandId) { return default(System.ComponentModel.Design.MenuCommand); }
    [System.MonoTODOAttribute]
    public virtual void OnDragDrop(System.Windows.Forms.Design.Behavior.Glyph g, System.Windows.Forms.DragEventArgs e) { }
    [System.MonoTODOAttribute]
    public virtual void OnDragEnter(System.Windows.Forms.Design.Behavior.Glyph g, System.Windows.Forms.DragEventArgs e) { }
    [System.MonoTODOAttribute]
    public virtual void OnDragLeave(System.Windows.Forms.Design.Behavior.Glyph g, System.EventArgs e) { }
    [System.MonoTODOAttribute]
    public virtual void OnDragOver(System.Windows.Forms.Design.Behavior.Glyph g, System.Windows.Forms.DragEventArgs e) { }
    [System.MonoTODOAttribute]
    public virtual void OnGiveFeedback(System.Windows.Forms.Design.Behavior.Glyph g, System.Windows.Forms.GiveFeedbackEventArgs e) { }
    [System.MonoTODOAttribute]
    public virtual void OnLoseCapture(System.Windows.Forms.Design.Behavior.Glyph g, System.EventArgs e) { }
    [System.MonoTODOAttribute]
    public virtual bool OnMouseDoubleClick(System.Windows.Forms.Design.Behavior.Glyph g, System.Windows.Forms.MouseButtons button, System.Drawing.Point mouseLoc) { return default(bool); }
    [System.MonoTODOAttribute]
    public virtual bool OnMouseDown(System.Windows.Forms.Design.Behavior.Glyph g, System.Windows.Forms.MouseButtons button, System.Drawing.Point mouseLoc) { return default(bool); }
    [System.MonoTODOAttribute]
    public virtual bool OnMouseEnter(System.Windows.Forms.Design.Behavior.Glyph g) { return default(bool); }
    [System.MonoTODOAttribute]
    public virtual bool OnMouseHover(System.Windows.Forms.Design.Behavior.Glyph g, System.Drawing.Point mouseLoc) { return default(bool); }
    [System.MonoTODOAttribute]
    public virtual bool OnMouseLeave(System.Windows.Forms.Design.Behavior.Glyph g) { return default(bool); }
    [System.MonoTODOAttribute]
    public virtual bool OnMouseMove(System.Windows.Forms.Design.Behavior.Glyph g, System.Windows.Forms.MouseButtons button, System.Drawing.Point mouseLoc) { return default(bool); }
    [System.MonoTODOAttribute]
    public virtual bool OnMouseUp(System.Windows.Forms.Design.Behavior.Glyph g, System.Windows.Forms.MouseButtons button) { return default(bool); }
    [System.MonoTODOAttribute]
    public virtual void OnQueryContinueDrag(System.Windows.Forms.Design.Behavior.Glyph g, System.Windows.Forms.QueryContinueDragEventArgs e) { }
  }
  public partial class BehaviorDragDropEventArgs : System.EventArgs {
    public BehaviorDragDropEventArgs(System.Collections.ICollection dragComponents) { }
    public System.Collections.ICollection DragComponents { get { return default(System.Collections.ICollection); } }
  }
  public delegate void BehaviorDragDropEventHandler(object sender, System.Windows.Forms.Design.Behavior.BehaviorDragDropEventArgs e);
  public sealed partial class BehaviorService : System.IDisposable {
    internal BehaviorService() { }
    [System.MonoTODOAttribute]
    public System.Windows.Forms.Design.Behavior.BehaviorServiceAdornerCollection Adorners { get { return default(System.Windows.Forms.Design.Behavior.BehaviorServiceAdornerCollection); } }
    [System.MonoTODOAttribute]
    public System.Drawing.Graphics AdornerWindowGraphics { get { return default(System.Drawing.Graphics); } }
    [System.MonoTODOAttribute]
    public System.Windows.Forms.Design.Behavior.Behavior CurrentBehavior { get { return default(System.Windows.Forms.Design.Behavior.Behavior); } }
    public event System.Windows.Forms.Design.Behavior.BehaviorDragDropEventHandler BeginDrag { add { } remove { } }
    public event System.Windows.Forms.Design.Behavior.BehaviorDragDropEventHandler EndDrag { add { } remove { } }
    public event System.EventHandler Synchronize { add { } remove { } }
    [System.MonoTODOAttribute]
    public System.Drawing.Point AdornerWindowPointToScreen(System.Drawing.Point p) { return default(System.Drawing.Point); }
    [System.MonoTODOAttribute]
    public System.Drawing.Point AdornerWindowToScreen() { return default(System.Drawing.Point); }
    [System.MonoTODOAttribute]
    public System.Drawing.Rectangle ControlRectInAdornerWindow(System.Windows.Forms.Control c) { return default(System.Drawing.Rectangle); }
    [System.MonoTODOAttribute]
    public System.Drawing.Point ControlToAdornerWindow(System.Windows.Forms.Control c) { return default(System.Drawing.Point); }
    [System.MonoTODOAttribute]
    public void Dispose() { }
    [System.MonoTODOAttribute]
    public System.Windows.Forms.Design.Behavior.Behavior GetNextBehavior(System.Windows.Forms.Design.Behavior.Behavior behavior) { return default(System.Windows.Forms.Design.Behavior.Behavior); }
    [System.MonoTODOAttribute]
    public void Invalidate() { }
    [System.MonoTODOAttribute]
    public void Invalidate(System.Drawing.Rectangle rect) { }
    [System.MonoTODOAttribute]
    public void Invalidate(System.Drawing.Region r) { }
    [System.MonoTODOAttribute]
    public System.Drawing.Point MapAdornerWindowPoint(System.IntPtr handle, System.Drawing.Point pt) { return default(System.Drawing.Point); }
    [System.MonoTODOAttribute]
    public System.Windows.Forms.Design.Behavior.Behavior PopBehavior(System.Windows.Forms.Design.Behavior.Behavior behavior) { return default(System.Windows.Forms.Design.Behavior.Behavior); }
    [System.MonoTODOAttribute]
    public void PushBehavior(System.Windows.Forms.Design.Behavior.Behavior behavior) { }
    [System.MonoTODOAttribute]
    public void PushCaptureBehavior(System.Windows.Forms.Design.Behavior.Behavior behavior) { }
    [System.MonoTODOAttribute]
    public System.Drawing.Point ScreenToAdornerWindow(System.Drawing.Point p) { return default(System.Drawing.Point); }
    [System.MonoTODOAttribute]
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
    [System.MonoTODOAttribute]
    public System.ComponentModel.IComponent RelatedComponent { get { return default(System.ComponentModel.IComponent); } }
    [System.MonoTODOAttribute]
    public override System.Windows.Forms.Cursor GetHitTest(System.Drawing.Point p) { return default(System.Windows.Forms.Cursor); }
    [System.MonoTODOAttribute]
    public override void Paint(System.Windows.Forms.PaintEventArgs pe) { }
  }
  public partial class ControlBodyGlyph : System.Windows.Forms.Design.Behavior.ComponentGlyph {
    [System.MonoTODOAttribute]
    public ControlBodyGlyph(System.Drawing.Rectangle bounds, System.Windows.Forms.Cursor cursor, System.ComponentModel.IComponent relatedComponent, System.Windows.Forms.Design.Behavior.Behavior behavior) : base (default(System.ComponentModel.IComponent)) { }
    [System.MonoTODOAttribute]
    public ControlBodyGlyph(System.Drawing.Rectangle bounds, System.Windows.Forms.Cursor cursor, System.ComponentModel.IComponent relatedComponent, System.Windows.Forms.Design.ControlDesigner designer) : base (default(System.ComponentModel.IComponent)) { }
    [System.MonoTODOAttribute]
    public override System.Drawing.Rectangle Bounds { get { return default(System.Drawing.Rectangle); } }
    [System.MonoTODOAttribute]
    public override System.Windows.Forms.Cursor GetHitTest(System.Drawing.Point p) { return default(System.Windows.Forms.Cursor); }
  }
  public abstract partial class Glyph {
    [System.MonoTODOAttribute]
    protected Glyph(System.Windows.Forms.Design.Behavior.Behavior behavior) { }
    [System.MonoTODOAttribute]
    public virtual System.Windows.Forms.Design.Behavior.Behavior Behavior { get { return default(System.Windows.Forms.Design.Behavior.Behavior); } }
    [System.MonoTODOAttribute]
    public virtual System.Drawing.Rectangle Bounds { get { return default(System.Drawing.Rectangle); } }
    public abstract System.Windows.Forms.Cursor GetHitTest(System.Drawing.Point p);
    public abstract void Paint(System.Windows.Forms.PaintEventArgs pe);
    [System.MonoTODOAttribute]
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
    [System.MonoTODOAttribute]
    public SnapLine(System.Windows.Forms.Design.Behavior.SnapLineType type, int offset) { }
    [System.MonoTODOAttribute]
    public SnapLine(System.Windows.Forms.Design.Behavior.SnapLineType type, int offset, string filter) { }
    [System.MonoTODOAttribute]
    public SnapLine(System.Windows.Forms.Design.Behavior.SnapLineType type, int offset, string filter, System.Windows.Forms.Design.Behavior.SnapLinePriority priority) { }
    [System.MonoTODOAttribute]
    public SnapLine(System.Windows.Forms.Design.Behavior.SnapLineType type, int offset, System.Windows.Forms.Design.Behavior.SnapLinePriority priority) { }
    public string Filter { get { return default(string); } }
    public bool IsHorizontal { get { return default(bool); } }
    public bool IsVertical { get { return default(bool); } }
    public int Offset { get { return default(int); } }
    public System.Windows.Forms.Design.Behavior.SnapLinePriority Priority { get { return default(System.Windows.Forms.Design.Behavior.SnapLinePriority); } }
    public System.Windows.Forms.Design.Behavior.SnapLineType SnapLineType { get { return default(System.Windows.Forms.Design.Behavior.SnapLineType); } }
    [System.MonoTODOAttribute]
    public void AdjustOffset(int adjustment) { }
    [System.MonoTODOAttribute]
    public static bool ShouldSnap(System.Windows.Forms.Design.Behavior.SnapLine line1, System.Windows.Forms.Design.Behavior.SnapLine line2) { return default(bool); }
    [System.MonoTODOAttribute]
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
