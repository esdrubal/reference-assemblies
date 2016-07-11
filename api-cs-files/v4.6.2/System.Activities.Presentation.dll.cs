namespace System.Activities.Presentation {
  public partial class ActivityDesigner : System.Activities.Presentation.WorkflowViewElement {
    public static readonly System.Windows.DependencyProperty IconProperty;
    public ActivityDesigner() { }
    public System.Windows.Media.DrawingBrush Icon { get { return default(System.Windows.Media.DrawingBrush); } set { } }
    protected override string GetAutomationIdMemberName() { return default(string); }
    protected internal override string GetAutomationItemStatus() { return default(string); }
    public override void OnApplyTemplate() { }
    protected internal override void OnEditAnnotation() { }
    protected override void OnModelItemChanged(object newItem) { }
    protected override void OnMouseUp(System.Windows.Input.MouseButtonEventArgs e) { }
    protected override void OnPreviewMouseDown(System.Windows.Input.MouseButtonEventArgs e) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(132))]
  public sealed partial class ActivityDesignerOptionsAttribute : System.Attribute {
    public ActivityDesignerOptionsAttribute() { }
    public bool AllowDrillIn { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool AlwaysCollapseChildren { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Func<System.Activities.Presentation.Model.ModelItem, System.Windows.Media.DrawingBrush> OutlineViewIconProvider { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Func<System.Activities.Presentation.Model.ModelItem, System.Windows.Media.DrawingBrush>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial class ArgumentAccessor {
    public ArgumentAccessor() { }
    public System.Func<System.Activities.Activity, System.Activities.Argument> Getter { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Func<System.Activities.Activity, System.Activities.Argument>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Action<System.Activities.Activity, System.Activities.Argument> Setter { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Action<System.Activities.Activity, System.Activities.Argument>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  [System.Windows.Markup.MarkupExtensionReturnTypeAttribute(typeof(System.Windows.ResourceDictionary))]
  public partial class CachedResourceDictionaryExtension : System.Windows.Markup.MarkupExtension {
    public CachedResourceDictionaryExtension() { }
    public System.Uri Source { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Uri); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override object ProvideValue(System.IServiceProvider serviceProvider) { return default(object); }
  }
  public partial class ClipboardData {
    public ClipboardData() { }
    public System.Collections.Generic.List<System.Object> Data { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.List<System.Object>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.Generic.List<System.Object> Metadata { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.List<System.Object>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Version { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public abstract partial class ContextItem {
    protected ContextItem() { }
    public abstract System.Type ItemType { get; }
    protected virtual void OnItemChanged(System.Activities.Presentation.EditingContext context, System.Activities.Presentation.ContextItem previousItem) { }
  }
  public abstract partial class ContextItemManager : System.Collections.Generic.IEnumerable<System.Activities.Presentation.ContextItem>, System.Collections.IEnumerable {
    protected ContextItemManager() { }
    public abstract bool Contains(System.Type itemType);
    public bool Contains<TItemType>() where TItemType : System.Activities.Presentation.ContextItem { return default(bool); }
    public abstract System.Collections.Generic.IEnumerator<System.Activities.Presentation.ContextItem> GetEnumerator();
    protected static object GetTarget(System.Delegate callback) { return default(object); }
    public abstract System.Activities.Presentation.ContextItem GetValue(System.Type itemType);
    public TItemType GetValue<TItemType>() where TItemType : System.Activities.Presentation.ContextItem { return default(TItemType); }
    protected static void NotifyItemChanged(System.Activities.Presentation.EditingContext context, System.Activities.Presentation.ContextItem item, System.Activities.Presentation.ContextItem previousItem) { }
    protected static System.Delegate RemoveCallback(System.Delegate existing, System.Delegate toRemove) { return default(System.Delegate); }
    public abstract void SetValue(System.Activities.Presentation.ContextItem value);
    public abstract void Subscribe(System.Type contextItemType, System.Activities.Presentation.SubscribeContextCallback callback);
    public void Subscribe<TContextItemType>(System.Activities.Presentation.SubscribeContextCallback<TContextItemType> callback) where TContextItemType : System.Activities.Presentation.ContextItem { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    public abstract void Unsubscribe(System.Type contextItemType, System.Activities.Presentation.SubscribeContextCallback callback);
    public void Unsubscribe<TContextItemType>(System.Activities.Presentation.SubscribeContextCallback<TContextItemType> callback) where TContextItemType : System.Activities.Presentation.ContextItem { }
  }
  public static partial class CutCopyPasteHelper {
    public static bool CanCopy(System.Activities.Presentation.EditingContext context) { return default(bool); }
    public static bool CanCut(System.Activities.Presentation.EditingContext context) { return default(bool); }
    public static bool CanPaste(System.Activities.Presentation.EditingContext context) { return default(bool); }
    public static void DoCopy(System.Activities.Presentation.EditingContext context) { }
    public static void DoCut(System.Activities.Presentation.EditingContext context) { }
    public static void DoPaste(System.Activities.Presentation.EditingContext context) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
  public sealed partial class DefaultTypeArgumentAttribute : System.Attribute {
    public DefaultTypeArgumentAttribute(System.Type type) { }
    public System.Type Type { get { return default(System.Type); } }
  }
  public sealed partial class DesignerConfigurationService {
    internal DesignerConfigurationService() { }
    public bool AnnotationEnabled { get { return default(bool); } set { } }
    public bool AutoConnectEnabled { get { return default(bool); } set { } }
    public bool AutoSplitEnabled { get { return default(bool); } set { } }
    public bool AutoSurroundWithSequenceEnabled { get { return default(bool); } set { } }
    public bool BackgroundValidationEnabled { get { return default(bool); } set { } }
    public bool LoadingFromUntrustedSourceEnabled { get { return default(bool); } set { } }
    public bool MultipleItemsContextMenuEnabled { get { return default(bool); } set { } }
    public bool MultipleItemsDragDropEnabled { get { return default(bool); } set { } }
    public bool NamespaceConversionEnabled { get { return default(bool); } set { } }
    public bool PanModeEnabled { get { return default(bool); } set { } }
    public bool RubberBandSelectionEnabled { get { return default(bool); } set { } }
    public System.Runtime.Versioning.FrameworkName TargetFrameworkName { get { return default(System.Runtime.Versioning.FrameworkName); } set { } }
  }
  public static partial class DragDropHelper {
    public static readonly string CompletedEffectsFormat;
    public static readonly string CompositeViewFormat;
    public static readonly string DragAnchorPointFormat;
    public static readonly System.Windows.DependencyProperty DragSourceProperty;
    public static readonly string ModelItemDataFormat;
    public static readonly string WorkflowItemTypeNameFormat;
    public static bool AllowDrop(System.Windows.IDataObject draggedDataObject, System.Activities.Presentation.EditingContext context, params System.Type[] allowedItemTypes) { return default(bool); }
    [System.ObsoleteAttribute("This method does not support dragging multiple items. Use \"public static IEnumerable<WorkflowViewElement> DoDragMove(IEnumerable<WorkflowViewElement> draggedViewElements, Point referencePoint)\" instead.")]
    public static System.Windows.DragDropEffects DoDragMove(System.Activities.Presentation.WorkflowViewElement draggedViewElement, System.Windows.Point referencePoint) { return default(System.Windows.DragDropEffects); }
    public static System.Windows.UIElement GetCompositeView(System.Activities.Presentation.WorkflowViewElement workflowViewElement) { return default(System.Windows.UIElement); }
    [System.ObsoleteAttribute("This method does not support dragging multiple items. Use \"public static UIElement GetCompositeView(WorkflowViewElement workflowViewElement)\" instead.")]
    public static System.Activities.Presentation.ICompositeView GetCompositeView(System.Windows.DragEventArgs e) { return default(System.Activities.Presentation.ICompositeView); }
    public static System.Windows.Point GetDragDropAnchorPoint(System.Windows.DragEventArgs e) { return default(System.Windows.Point); }
    [System.ObsoleteAttribute("This method does not support dragging multiple items. Consider using \"public static IEnumerable<WorkflowViewElement> GetDragDropMovedViewElements(DataObject data)\" instead.")]
    public static System.Windows.DragDropEffects GetDragDropCompletedEffects(System.Windows.DataObject data) { return default(System.Windows.DragDropEffects); }
    [System.ObsoleteAttribute("This method does not support dragging multiple items. Use \"public static IEnumerable<ModelItem> GetDraggedModelItems(DragEventArgs e)\" instead.")]
    public static System.Activities.Presentation.Model.ModelItem GetDraggedModelItem(System.Windows.DragEventArgs e) { return default(System.Activities.Presentation.Model.ModelItem); }
    public static System.Collections.Generic.IEnumerable<System.Activities.Presentation.Model.ModelItem> GetDraggedModelItems(System.Windows.DragEventArgs e) { return default(System.Collections.Generic.IEnumerable<System.Activities.Presentation.Model.ModelItem>); }
    [System.ObsoleteAttribute("This method does not support dropping multiple items. Use \"public static IEnumerable<object> GetDroppedObjects(DependencyObject dropTarget, DragEventArgs e, EditingContext context)\" instead.")]
    public static object GetDroppedObject(System.Windows.DependencyObject dropTarget, System.Windows.DragEventArgs e, System.Activities.Presentation.EditingContext context) { return default(object); }
    public static System.Collections.Generic.IEnumerable<System.Object> GetDroppedObjects(System.Windows.DependencyObject dropTarget, System.Windows.DragEventArgs e, System.Activities.Presentation.EditingContext context) { return default(System.Collections.Generic.IEnumerable<System.Object>); }
    public static void SetCompositeView(System.Activities.Presentation.WorkflowViewElement workflowViewElement, System.Windows.UIElement dragSource) { }
    [System.ObsoleteAttribute("This method does not support dragging multiple items. Consider using \"public static void SetDragDropMovedViewElements(DragEventArgs e, IEnumerable<WorkflowViewElement> movedViewElements)\" instead.")]
    public static void SetDragDropCompletedEffects(System.Windows.DragEventArgs e, System.Windows.DragDropEffects completedEffects) { }
  }
  public partial class EditingContext : System.IDisposable {
    public EditingContext() { }
    public System.Activities.Presentation.ContextItemManager Items { get { return default(System.Activities.Presentation.ContextItemManager); } }
    public System.Activities.Presentation.ServiceManager Services { get { return default(System.Activities.Presentation.ServiceManager); } }
    public event System.EventHandler Disposing { add { } remove { } }
    protected virtual System.Activities.Presentation.ContextItemManager CreateContextItemManager() { return default(System.Activities.Presentation.ContextItemManager); }
    protected virtual System.Activities.Presentation.ServiceManager CreateServiceManager() { return default(System.Activities.Presentation.ServiceManager); }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
  }
  public partial interface IActivityTemplateFactory {
    System.Activities.Activity Create(System.Windows.DependencyObject target);
  }
  public partial interface IActivityTemplateFactory<T> where T : class {
    T Create(System.Windows.DependencyObject target, System.Windows.IDataObject dataObject);
  }
  public partial interface IActivityToolboxService {
    void AddCategory(string categoryName);
    void AddItem(string qualifiedTypeName, string categoryName);
    System.Collections.Generic.IList<System.String> EnumCategories();
    System.Collections.Generic.IList<System.String> EnumItems(string categoryName);
    void RemoveCategory(string categoryName);
    void RemoveItem(string qualifiedTypeName, string categoryName);
  }
  public partial interface ICompositeView {
    System.Activities.Presentation.View.TypeResolvingOptions DroppingTypeResolvingOptions { get; }
    bool IsDefaultContainer { get; }
    bool CanPasteItems(System.Collections.Generic.List<System.Object> itemsToPaste);
    void OnItemMoved(System.Activities.Presentation.Model.ModelItem modelItem);
    object OnItemsCopied(System.Collections.Generic.List<System.Activities.Presentation.Model.ModelItem> itemsToCopy);
    object OnItemsCut(System.Collections.Generic.List<System.Activities.Presentation.Model.ModelItem> itemsToCut);
    void OnItemsDelete(System.Collections.Generic.List<System.Activities.Presentation.Model.ModelItem> itemsToDelete);
    void OnItemsPasted(System.Collections.Generic.List<System.Object> itemsToPaste, System.Collections.Generic.List<System.Object> metadata, System.Windows.Point pastePoint, System.Activities.Presentation.WorkflowViewElement pastePointReference);
  }
  public partial interface ICompositeViewEvents {
    void RegisterCompositeView(System.Activities.Presentation.ICompositeView container);
    void RegisterDefaultCompositeView(System.Activities.Presentation.ICompositeView container);
    void UnregisterCompositeView(System.Activities.Presentation.ICompositeView container);
    void UnregisterDefaultCompositeView(System.Activities.Presentation.ICompositeView container);
  }
  public partial interface IIntegratedHelpService {
    void AddContextAttribute(string name, string value, System.ComponentModel.Design.HelpKeywordType keywordType);
    void RemoveContextAttribute(string name, string value);
    void ShowHelpFromKeyword(string helpKeyword);
    void ShowHelpFromUrl(string helpUrl);
  }
  public partial interface IModalService {
    void SetModalState(bool isModal);
  }
  public partial interface IMultipleDragEnabledCompositeView : System.Activities.Presentation.ICompositeView {
    void OnItemsMoved(System.Collections.Generic.List<System.Activities.Presentation.Model.ModelItem> movedItems);
    System.Collections.Generic.List<System.Activities.Presentation.Model.ModelItem> SortSelectedItems(System.Collections.Generic.List<System.Activities.Presentation.Model.ModelItem> selectedItems);
  }
  public partial interface IWorkflowDesignerStorageService {
    void AddData(string key, object value);
    bool ContainsKey(string key);
    object GetData(string key);
    void RemoveData(string key);
    void SetData(string key, object value);
  }
  public partial interface IXamlLoadErrorService {
    void ShowXamlLoadErrors(System.Collections.Generic.IList<System.Activities.Presentation.XamlLoadErrorInfo> errors);
  }
  public sealed partial class ObjectReferenceService {
    public ObjectReferenceService(System.Activities.Presentation.EditingContext context) { }
    public event System.EventHandler<System.Activities.Presentation.SourceLocationUpdatedEventArgs> SourceLocationUpdated { add { } remove { } }
    public System.Guid AcquireObjectReference(int startLine, int startColumn, int endLine, int endColumn) { return default(System.Guid); }
    public System.Guid AcquireObjectReference(object obj) { return default(System.Guid); }
    public void ReleaseObjectReference(System.Guid objectReferenceId) { }
    public bool TryGetObject(System.Guid objectReferenceId, out object obj) { obj = default(object); return default(bool); }
  }
  public delegate object PublishServiceCallback(System.Type serviceType);
  public delegate TServiceType PublishServiceCallback<TServiceType>();
  public abstract partial class ServiceManager : System.Collections.Generic.IEnumerable<System.Type>, System.Collections.IEnumerable, System.IServiceProvider {
    protected ServiceManager() { }
    public abstract bool Contains(System.Type serviceType);
    public bool Contains<TServiceType>() { return default(bool); }
    public abstract System.Collections.Generic.IEnumerator<System.Type> GetEnumerator();
    public TServiceType GetRequiredService<TServiceType>() { return default(TServiceType); }
    public abstract object GetService(System.Type serviceType);
    public TServiceType GetService<TServiceType>() { return default(TServiceType); }
    protected static object GetTarget(System.Delegate callback) { return default(object); }
    public abstract void Publish(System.Type serviceType, System.Activities.Presentation.PublishServiceCallback callback);
    public abstract void Publish(System.Type serviceType, object serviceInstance);
    public void Publish<TServiceType>(TServiceType serviceInstance) { }
    public void Publish<TServiceType>(System.Activities.Presentation.PublishServiceCallback<TServiceType> callback) { }
    protected static System.Delegate RemoveCallback(System.Delegate existing, System.Delegate toRemove) { return default(System.Delegate); }
    public abstract void Subscribe(System.Type serviceType, System.Activities.Presentation.SubscribeServiceCallback callback);
    public void Subscribe<TServiceType>(System.Activities.Presentation.SubscribeServiceCallback<TServiceType> callback) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    public abstract void Unsubscribe(System.Type serviceType, System.Activities.Presentation.SubscribeServiceCallback callback);
    public void Unsubscribe<TServiceType>(System.Activities.Presentation.SubscribeServiceCallback<TServiceType> callback) { }
  }
  public partial class SourceLocationUpdatedEventArgs : System.EventArgs {
    public SourceLocationUpdatedEventArgs(System.Guid objectReference, System.Activities.Debugger.SourceLocation updatedSourceLocation) { }
    public System.Guid ObjectReference { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Guid); } }
    public System.Activities.Debugger.SourceLocation UpdatedSourceLocation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Debugger.SourceLocation); } }
  }
  public delegate void SubscribeContextCallback(System.Activities.Presentation.ContextItem item);
  public delegate void SubscribeContextCallback<TContextItemType>(TContextItemType item) where TContextItemType : System.Activities.Presentation.ContextItem;
  public delegate void SubscribeServiceCallback(System.Type serviceType, object serviceInstance);
  public delegate void SubscribeServiceCallback<TServiceType>(TServiceType serviceInstance);
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false)]
  public sealed partial class TypeResolvingOptionsAttribute : System.Attribute {
    public TypeResolvingOptionsAttribute() { }
    public TypeResolvingOptionsAttribute(System.Activities.Presentation.View.TypeResolvingOptions options) { }
    public System.Activities.Presentation.View.TypeResolvingOptions TypeResolvingOptions { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Presentation.View.TypeResolvingOptions); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial class UndoEngine {
    public UndoEngine(System.Activities.Presentation.EditingContext context) { }
    public bool IsUndoRedoInProgress { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    public event System.EventHandler<System.Activities.Presentation.UndoUnitEventArgs> RedoCompleted { add { } remove { } }
    public event System.EventHandler<System.Activities.Presentation.UndoUnitEventArgs> UndoCompleted { add { } remove { } }
    public event System.EventHandler UndoRedoBufferChanged { add { } remove { } }
    public event System.EventHandler<System.Activities.Presentation.UndoUnitEventArgs> UndoUnitAdded { add { } remove { } }
    public event System.EventHandler<System.Activities.Presentation.UndoUnitEventArgs> UndoUnitCancelled { add { } remove { } }
    public event System.EventHandler UndoUnitDiscarded { add { } remove { } }
    public void AddUndoUnit(System.Activities.Presentation.UndoUnit unit) { }
    public System.Collections.Generic.IEnumerable<System.String> GetRedoActions() { return default(System.Collections.Generic.IEnumerable<System.String>); }
    public System.Collections.Generic.IEnumerable<System.String> GetUndoActions() { return default(System.Collections.Generic.IEnumerable<System.String>); }
    public bool Redo() { return default(bool); }
    public bool Undo() { return default(bool); }
  }
  public abstract partial class UndoUnit {
    protected UndoUnit(System.Activities.Presentation.EditingContext context) { }
    public string Description { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected void ApplyGlobalState() { }
    public abstract void Redo();
    protected void SaveGlobalState() { }
    public abstract void Undo();
  }
  public partial class UndoUnitEventArgs : System.EventArgs {
    public UndoUnitEventArgs() { }
    public System.Activities.Presentation.UndoUnit UndoUnit { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Presentation.UndoUnit); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial class WorkflowDesigner {
    public WorkflowDesigner() { }
    public System.Activities.Presentation.EditingContext Context { get { return default(System.Activities.Presentation.EditingContext); } }
    public System.Windows.Controls.ContextMenu ContextMenu { get { return default(System.Windows.Controls.ContextMenu); } }
    public System.Activities.Presentation.Debug.IDesignerDebugView DebugManagerView { get { return default(System.Activities.Presentation.Debug.IDesignerDebugView); } }
    public System.Windows.UIElement OutlineView { get { return default(System.Windows.UIElement); } }
    public string PropertyInspectorFontAndColorData { set { } }
    public System.Windows.UIElement PropertyInspectorView { get { return default(System.Windows.UIElement); } }
    public string Text { get { return default(string); } set { } }
    public System.Windows.UIElement View { get { return default(System.Windows.UIElement); } }
    public event System.EventHandler ModelChanged { add { } remove { } }
    public event System.Windows.Controls.TextChangedEventHandler TextChanged { add { } remove { } }
    public void Flush() { }
    public bool IsInErrorState() { return default(bool); }
    public void Load() { }
    public void Load(object instance) { }
    public void Load(string fileName) { }
    public void Save(string fileName) { }
  }
  public static partial class WorkflowDesignerColors {
    public const string AnnotationBackgroundGradientBeginColorKey = "AnnotationBackgroundGradientBeginColorKey";
    public const string AnnotationBackgroundGradientEndColorKey = "AnnotationBackgroundGradientEndColorKey";
    public const string AnnotationBackgroundGradientMiddleColorKey = "AnnotationBackgroundGradientMiddleColorKey";
    public const string AnnotationBorderColorKey = "AnnotationBorderColorKey";
    public const string AnnotationDockButtonColorKey = "AnnotationDockButtonColorKey";
    public const string AnnotationDockButtonHoverBackgroundColorKey = "AnnotationDockButtonHoverBackgroundColorKey";
    public const string AnnotationDockButtonHoverBorderColorKey = "AnnotationDockButtonHoverBorderColorKey";
    public const string AnnotationDockButtonHoverColorKey = "AnnotationDockButtonHoverColorKey";
    public const string AnnotationDockTextColorKey = "AnnotationDockTextColorKey";
    public const string AnnotationUndockTextColorKey = "AnnotationUndockTextColorKey";
    public const string ContextMenuBackgroundGradientBeginColorKey = "ContextMenuColorGradientBeginColorKey";
    public const string ContextMenuBackgroundGradientEndColorKey = "ContextMenuColorGradientEndColorKey";
    public const string ContextMenuBorderColorKey = "ContextMenuBorderColorKey";
    public const string ContextMenuIconAreaColorKey = "ContextMenuIconAreaColorKey";
    public const string ContextMenuItemTextColorKey = "ContextMenuItemTextColorKey";
    public const string ContextMenuItemTextDisabledColorKey = "ContextMenuItemTextDisabledColorKey";
    public const string ContextMenuItemTextHoverColorKey = "ContextMenuItemTextHoverColorKey";
    public const string ContextMenuItemTextSelectedColorKey = "ContextMenuItemTextSelectedColorKey";
    public const string ContextMenuMouseOverBeginColorKey = "ContextMenuMouseOverBeginColorKey";
    public const string ContextMenuMouseOverBorderColorKey = "ContextMenuMouseOverBorderColorKey";
    public const string ContextMenuMouseOverEndColorKey = "ContextMenuMouseOverEndColorKey";
    public const string ContextMenuMouseOverMiddle1ColorKey = "ContextMenuMouseOverMiddle1ColorKey";
    public const string ContextMenuMouseOverMiddle2ColorKey = "ContextMenuMouseOverMiddle2ColorKey";
    public const string ContextMenuSeparatorColorKey = "ContextMenuSeparatorColorKey";
    public const string DesignerViewBackgroundColorKey = "DesignerViewBackgroundColorKey";
    public const string DesignerViewExpandAllCollapseAllButtonColorKey = "DesignerViewExpandAllCollapseAllButtonColorKey";
    public const string DesignerViewExpandAllCollapseAllButtonMouseOverColorKey = "DesignerViewExpandAllCollapseAllButtonMouseOverColorKey";
    public const string DesignerViewExpandAllCollapseAllPressedColorKey = "DesignerViewExpandAllCollapseAllPressedColorKey";
    public const string DesignerViewShellBarCaptionActiveColorKey = "DesignerViewShellBarCaptionActiveColorKey";
    public const string DesignerViewShellBarCaptionColorKey = "DesignerViewShellBarCaptionColorKey";
    public const string DesignerViewShellBarColorGradientBeginKey = "DesignerViewShellBarColorGradientBeginKey";
    public const string DesignerViewShellBarColorGradientEndKey = "DesignerViewShellBarColorGradientEndKey";
    public const string DesignerViewShellBarControlBackgroundColorKey = "DesignerViewShellBarControlBackgroundColorKey";
    public const string DesignerViewShellBarHoverColorGradientBeginKey = "DesignerViewShellBarSelectedHoverGradientBeginKey";
    public const string DesignerViewShellBarHoverColorGradientEndKey = "DesignerViewShellBarSelectedHoverGradientEndKey";
    public const string DesignerViewShellBarSelectedColorGradientBeginKey = "DesignerViewShellBarSelectedColorGradientBeginKey";
    public const string DesignerViewShellBarSelectedColorGradientEndKey = "DesignerViewShellBarSelectedColorGradientEndKey";
    public const string DesignerViewStatusBarBackgroundColorKey = "DesignerViewStatusBarBackgroundColorKey";
    public const string FlowchartExpressionButtonColorKey = "FlowchartExpressionButtonColorKey";
    public const string FlowchartExpressionButtonMouseOverColorKey = "FlowchartExpressionButtonMouseOverColorKey";
    public const string FlowchartExpressionButtonPressedColorKey = "FlowchartExpressionButtonPressedColorKey";
    public static readonly string FontFamilyKey;
    public static readonly string FontSizeKey;
    public static readonly string FontWeightKey;
    public const string OutlineViewBackgroundColorKey = "OutlineViewBackgroundColorKey";
    public const string OutlineViewCollapsedArrowBorderColorKey = "OutlineViewCollapsedArrowBorderColorKey";
    public const string OutlineViewCollapsedArrowHoverBorderColorKey = "OutlineViewCollapsedArrowHoverBorderColorKey";
    public const string OutlineViewExpandedArrowBorderColorKey = "OutlineViewExpandedArrowBorderColorKey";
    public const string OutlineViewExpandedArrowColorKey = "OutlineViewExpandedArrowColorKey";
    public const string OutlineViewItemHighlightBackgroundColorKey = "OutlineViewItemHighlightBackgroundColorKey";
    public const string OutlineViewItemSelectedTextColorKey = "OutlineViewTitemSelectedTextColorKey";
    public const string OutlineViewItemTextColorKey = "OutlineViewItemTextColorKey";
    public const string RubberBandRectangleColorKey = "RubberBandRectangleColorKey";
    public const string WorkflowViewElementBackgroundColorKey = "WorkflowViewElementBackgroundColorKey";
    public const string WorkflowViewElementBorderColorKey = "WorkflowViewElementBorderColorKey";
    public const string WorkflowViewElementCaptionColorKey = "WorkflowViewElementCaptionBrushColorKey";
    public const string WorkflowViewElementSelectedBackgroundColorKey = "WorkflowViewElementSelectedBackgroundColorKey";
    public const string WorkflowViewElementSelectedBorderColorKey = "WorkflowViewElementSelectedBorderColorKey";
    public static System.Windows.Media.Color AnnotationBackgroundGradientBeginColor { get { return default(System.Windows.Media.Color); } }
    public static System.Windows.Media.Color AnnotationBackgroundGradientEndColor { get { return default(System.Windows.Media.Color); } }
    public static System.Windows.Media.Color AnnotationBackgroundGradientMiddleColor { get { return default(System.Windows.Media.Color); } }
    public static System.Windows.Media.Color AnnotationBorderColor { get { return default(System.Windows.Media.Color); } }
    public static System.Windows.Media.Color AnnotationDockButtonColor { get { return default(System.Windows.Media.Color); } }
    public static System.Windows.Media.Color AnnotationDockButtonHoverBackgroundColor { get { return default(System.Windows.Media.Color); } }
    public static System.Windows.Media.Color AnnotationDockButtonHoverBorderColor { get { return default(System.Windows.Media.Color); } }
    public static System.Windows.Media.Color AnnotationDockButtonHoverColor { get { return default(System.Windows.Media.Color); } }
    public static System.Windows.Media.Color AnnotationDockTextColor { get { return default(System.Windows.Media.Color); } }
    public static System.Windows.Media.Color AnnotationUndockTextColor { get { return default(System.Windows.Media.Color); } }
    public static System.Windows.Media.Color ContextMenuBackgroundGradientBeginColor { get { return default(System.Windows.Media.Color); } }
    public static System.Windows.Media.Color ContextMenuBackgroundGradientEndColor { get { return default(System.Windows.Media.Color); } }
    public static System.Windows.Media.Color ContextMenuBorderColor { get { return default(System.Windows.Media.Color); } }
    public static System.Windows.Media.Color ContextMenuIconAreaColor { get { return default(System.Windows.Media.Color); } }
    public static System.Windows.Media.Color ContextMenuItemTextColor { get { return default(System.Windows.Media.Color); } }
    public static System.Windows.Media.Color ContextMenuItemTextDisabledColor { get { return default(System.Windows.Media.Color); } }
    public static System.Windows.Media.Color ContextMenuItemTextHoverColor { get { return default(System.Windows.Media.Color); } }
    public static System.Windows.Media.Color ContextMenuItemTextSelectedColor { get { return default(System.Windows.Media.Color); } }
    public static System.Windows.Media.Color ContextMenuMouseOverBeginColor { get { return default(System.Windows.Media.Color); } }
    public static System.Windows.Media.Color ContextMenuMouseOverBorderColor { get { return default(System.Windows.Media.Color); } }
    public static System.Windows.Media.Color ContextMenuMouseOverEndColor { get { return default(System.Windows.Media.Color); } }
    public static System.Windows.Media.Color ContextMenuMouseOverMiddle1Color { get { return default(System.Windows.Media.Color); } }
    public static System.Windows.Media.Color ContextMenuMouseOverMiddle2Color { get { return default(System.Windows.Media.Color); } }
    public static System.Windows.Media.Color ContextMenuSeparatorColor { get { return default(System.Windows.Media.Color); } }
    public static System.Windows.Media.Color DesignerViewBackgroundColor { get { return default(System.Windows.Media.Color); } }
    public static System.Windows.Media.Brush DesignerViewExpandAllCollapseAllButtonBrush { get { return default(System.Windows.Media.Brush); } }
    public static System.Windows.Media.Brush DesignerViewExpandAllCollapseAllButtonMouseOverBrush { get { return default(System.Windows.Media.Brush); } }
    public static System.Windows.Media.Brush DesignerViewExpandAllCollapseAllPressedBrush { get { return default(System.Windows.Media.Brush); } }
    public static System.Windows.Media.Color DesignerViewShellBarCaptionActiveColor { get { return default(System.Windows.Media.Color); } }
    public static System.Windows.Media.Color DesignerViewShellBarCaptionColor { get { return default(System.Windows.Media.Color); } }
    public static System.Windows.Media.Color DesignerViewShellBarColorGradientBeginColor { get { return default(System.Windows.Media.Color); } }
    public static System.Windows.Media.Color DesignerViewShellBarColorGradientEndColor { get { return default(System.Windows.Media.Color); } }
    public static System.Windows.Media.Color DesignerViewShellBarControlBackgroundColor { get { return default(System.Windows.Media.Color); } }
    public static System.Windows.Media.Color DesignerViewShellBarHoverColorGradientBeginColor { get { return default(System.Windows.Media.Color); } }
    public static System.Windows.Media.Color DesignerViewShellBarHoverColorGradientEndColor { get { return default(System.Windows.Media.Color); } }
    public static System.Windows.Media.Color DesignerViewShellBarSelectedColorGradientBeginColor { get { return default(System.Windows.Media.Color); } }
    public static System.Windows.Media.Color DesignerViewShellBarSelectedColorGradientEndColor { get { return default(System.Windows.Media.Color); } }
    public static System.Windows.Media.Color DesignerViewStatusBarBackgroundColor { get { return default(System.Windows.Media.Color); } }
    public static System.Windows.Media.Brush FlowchartExpressionButtonBrush { get { return default(System.Windows.Media.Brush); } }
    public static System.Windows.Media.Brush FlowchartExpressionButtonMouseOverBrush { get { return default(System.Windows.Media.Brush); } }
    public static System.Windows.Media.Brush FlowchartExpressionButtonPressedBrush { get { return default(System.Windows.Media.Brush); } }
    public static System.Windows.Media.FontFamily FontFamily { get { return default(System.Windows.Media.FontFamily); } }
    public static double FontSize { get { return default(double); } }
    public static System.Windows.FontWeight FontWeight { get { return default(System.Windows.FontWeight); } }
    public static System.Windows.Media.Color GridViewRowHoverColor { get { return default(System.Windows.Media.Color); } }
    public static System.Windows.Media.Color OutlineViewBackgroundColor { get { return default(System.Windows.Media.Color); } }
    public static System.Windows.Media.Color OutlineViewCollapsedArrowBorderColor { get { return default(System.Windows.Media.Color); } }
    public static System.Windows.Media.Color OutlineViewCollapsedArrowHoverBorderColor { get { return default(System.Windows.Media.Color); } }
    public static System.Windows.Media.Color OutlineViewExpandedArrowBorderColor { get { return default(System.Windows.Media.Color); } }
    public static System.Windows.Media.Color OutlineViewExpandedArrowColor { get { return default(System.Windows.Media.Color); } }
    public static System.Windows.Media.Color OutlineViewItemHighlightBackgroundColor { get { return default(System.Windows.Media.Color); } }
    public static System.Windows.Media.Color OutlineViewItemSelectedTextColor { get { return default(System.Windows.Media.Color); } }
    public static System.Windows.Media.Color OutlineViewItemTextColor { get { return default(System.Windows.Media.Color); } }
    public static string PropertyInspectorBackgroundBrushKey { get { return default(string); } }
    public static string PropertyInspectorBorderBrushKey { get { return default(string); } }
    public static string PropertyInspectorCategoryCaptionTextBrushKey { get { return default(string); } }
    public static string PropertyInspectorPaneBrushKey { get { return default(string); } }
    public static string PropertyInspectorPopupBrushKey { get { return default(string); } }
    public static string PropertyInspectorSelectedBackgroundBrushKey { get { return default(string); } }
    public static string PropertyInspectorSelectedForegroundBrushKey { get { return default(string); } }
    public static string PropertyInspectorTextBrushKey { get { return default(string); } }
    public static string PropertyInspectorToolBarBackgroundBrushKey { get { return default(string); } }
    public static string PropertyInspectorToolBarItemHoverBackgroundBrushKey { get { return default(string); } }
    public static string PropertyInspectorToolBarItemHoverBorderBrushKey { get { return default(string); } }
    public static string PropertyInspectorToolBarItemSelectedBackgroundBrushKey { get { return default(string); } }
    public static string PropertyInspectorToolBarItemSelectedBorderBrushKey { get { return default(string); } }
    public static string PropertyInspectorToolBarSeparatorBrushKey { get { return default(string); } }
    public static string PropertyInspectorToolBarTextBoxBorderBrushKey { get { return default(string); } }
    public static System.Windows.Media.Color WorkflowViewElementBackgroundColor { get { return default(System.Windows.Media.Color); } }
    public static System.Windows.Media.Color WorkflowViewElementBorderColor { get { return default(System.Windows.Media.Color); } }
    public static System.Windows.Media.Color WorkflowViewElementCaptionColor { get { return default(System.Windows.Media.Color); } }
    public static System.Windows.Media.Color WorkflowViewElementSelectedBackgroundColor { get { return default(System.Windows.Media.Color); } }
    public static System.Windows.Media.Color WorkflowViewElementSelectedBorderColor { get { return default(System.Windows.Media.Color); } }
  }
  public static partial class WorkflowDesignerIcons {
    public static void UseWindowsStoreAppStyleIcons() { }
    public static partial class Activities {
      public static System.Windows.Media.DrawingBrush AddToCollection { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush Assign { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush CancellationScope { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush ClearCollection { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush CompensableActivity { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush Compensate { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush Confirm { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush CorrelationScope { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush DefaultCustomActivity { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush Delay { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush DoWhile { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush ExistsInCollection { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush FinalState { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush Flowchart { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush FlowDecision { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush FlowDecisionNode { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush FlowSwitch { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush FlowSwitchNode { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush ForEach { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush If { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush InitializeCorrelation { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush Interop { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush InvokeDelegate { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush InvokeMethod { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush NoPersistScope { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush Parallel { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush ParallelForEach { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush Persist { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush Pick { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush PickBranch { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush Receive { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush ReceiveAndSendReply { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush ReceiveReply { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush RemoveFromCollection { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush Rethrow { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush Send { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush SendAndReceiveReply { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush SendReply { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush Sequence { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush StartNode { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush State { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush StateEntry { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush StateExit { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush StateMachine { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush StateTransition { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush Switch { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush TerminateWorkflow { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush Throw { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush TransactedReceiveScope { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush TransactionScope { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush TryCatch { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush While { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush WriteLine { get { return default(System.Windows.Media.DrawingBrush); } set { } }
    }
    public static partial class ContextMenuItems {
      public static System.Windows.Media.DrawingBrush Copy { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush CopyDisabled { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush Cut { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush CutDisabled { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush Delete { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush DeleteDisabled { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush Paste { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush PasteDisabled { get { return default(System.Windows.Media.DrawingBrush); } set { } }
    }
    public static partial class DesignerItems {
      public static System.Windows.Media.DrawingBrush ActivityErrorValidation { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush Annotation { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush DeleteButton { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush DeleteDisabledButton { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush FitToScreen { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush MoveDownButton { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush MoveDownDisabledButton { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush MoveUpButton { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush MoveUpDisabledButton { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush Overview { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush OverviewWindowCloseButton { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush PanMode { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush ResizeGrip { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush TextBoxErrorValidation { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush WarningValidation { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush WorkflowErrorValidation { get { return default(System.Windows.Media.DrawingBrush); } set { } }
      public static System.Windows.Media.DrawingBrush Zoom { get { return default(System.Windows.Media.DrawingBrush); } set { } }
    }
  }
  public partial class WorkflowElementDialog : System.Windows.Controls.ContentControl {
    public static readonly System.Windows.DependencyProperty ContextProperty;
    public static readonly System.Windows.DependencyProperty ModelItemProperty;
    public static readonly System.Windows.DependencyProperty TitleProperty;
    public static readonly System.Windows.DependencyProperty WindowResizeModeProperty;
    public static readonly System.Windows.DependencyProperty WindowSizeToContentProperty;
    protected WorkflowElementDialog() { }
    public System.Activities.Presentation.EditingContext Context { get { return default(System.Activities.Presentation.EditingContext); } set { } }
    public bool EnableMaximizeButton { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool EnableMinimizeButton { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string HelpKeyword { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Activities.Presentation.Model.ModelItem ModelItem { get { return default(System.Activities.Presentation.Model.ModelItem); } set { } }
    public System.Windows.DependencyObject Owner { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Windows.DependencyObject); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Title { get { return default(string); } set { } }
    public System.Windows.ResizeMode WindowResizeMode { get { return default(System.Windows.ResizeMode); } set { } }
    public System.Windows.SizeToContent WindowSizeToContent { get { return default(System.Windows.SizeToContent); } set { } }
    protected void EnableOk(bool enabled) { }
    protected override void OnInitialized(System.EventArgs e) { }
    protected virtual void OnModelItemChanged(object newItem) { }
    protected virtual void OnWorkflowElementDialogClosed(System.Nullable<System.Boolean> dialogResult) { }
    public void Show() { }
    public bool ShowOkCancel() { return default(bool); }
  }
  public partial class WorkflowFileItem : System.Activities.Presentation.ContextItem {
    public WorkflowFileItem() { }
    public sealed override System.Type ItemType { get { return default(System.Type); } }
    public string LoadedFile { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public sealed partial class WorkflowItemPresenter : System.Windows.Controls.ContentControl, System.Activities.Presentation.ICompositeView {
    public static readonly System.Windows.DependencyProperty AllowedItemTypeProperty;
    public static readonly System.Windows.DependencyProperty DroppingTypeResolvingOptionsProperty;
    public static readonly System.Windows.DependencyProperty HintTextProperty;
    public static readonly System.Windows.DependencyProperty IsDefaultContainerProperty;
    public static readonly System.Windows.DependencyProperty ItemProperty;
    public WorkflowItemPresenter() { }
    public System.Type AllowedItemType { get { return default(System.Type); } set { } }
    public System.Activities.Presentation.View.TypeResolvingOptions DroppingTypeResolvingOptions { get { return default(System.Activities.Presentation.View.TypeResolvingOptions); } set { } }
    public string HintText { get { return default(string); } set { } }
    public bool IsDefaultContainer { get { return default(bool); } set { } }
    public System.Activities.Presentation.Model.ModelItem Item { get { return default(System.Activities.Presentation.Model.ModelItem); } set { } }
    protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { return default(System.Windows.Automation.Peers.AutomationPeer); }
    protected override void OnDragEnter(System.Windows.DragEventArgs e) { }
    protected override void OnDragOver(System.Windows.DragEventArgs e) { }
    protected override void OnDrop(System.Windows.DragEventArgs e) { }
    protected override void OnInitialized(System.EventArgs e) { }
    protected override void OnMouseDown(System.Windows.Input.MouseButtonEventArgs e) { }
    protected override void OnRender(System.Windows.Media.DrawingContext drawingContext) { }
    bool System.Activities.Presentation.ICompositeView.CanPasteItems(System.Collections.Generic.List<System.Object> itemsToPaste) { return default(bool); }
    void System.Activities.Presentation.ICompositeView.OnItemMoved(System.Activities.Presentation.Model.ModelItem modelItem) { }
    object System.Activities.Presentation.ICompositeView.OnItemsCopied(System.Collections.Generic.List<System.Activities.Presentation.Model.ModelItem> itemsToCopy) { return default(object); }
    object System.Activities.Presentation.ICompositeView.OnItemsCut(System.Collections.Generic.List<System.Activities.Presentation.Model.ModelItem> itemsToCut) { return default(object); }
    void System.Activities.Presentation.ICompositeView.OnItemsDelete(System.Collections.Generic.List<System.Activities.Presentation.Model.ModelItem> itemsToDelete) { }
    void System.Activities.Presentation.ICompositeView.OnItemsPasted(System.Collections.Generic.List<System.Object> itemsToPaste, System.Collections.Generic.List<System.Object> metaData, System.Windows.Point pastePoint, System.Activities.Presentation.WorkflowViewElement pastePointReference) { }
  }
  public partial class WorkflowItemsPresenter : System.Windows.Controls.ContentControl, System.Activities.Presentation.ICompositeView, System.Activities.Presentation.IMultipleDragEnabledCompositeView {
    public static readonly System.Windows.DependencyProperty AllowedItemTypeProperty;
    public static readonly System.Windows.DependencyProperty DroppingTypeResolvingOptionsProperty;
    public static readonly System.Windows.DependencyProperty FooterTemplateProperty;
    public static readonly System.Windows.DependencyProperty HeaderTemplateProperty;
    public static readonly System.Windows.DependencyProperty HintTextProperty;
    public static readonly System.Windows.DependencyProperty IndexProperty;
    public static readonly System.Windows.DependencyProperty IsDefaultContainerProperty;
    public static readonly System.Windows.DependencyProperty ItemsPanelProperty;
    public static readonly System.Windows.DependencyProperty ItemsProperty;
    public static readonly System.Windows.DependencyProperty SpacerTemplateProperty;
    public WorkflowItemsPresenter() { }
    public System.Type AllowedItemType { get { return default(System.Type); } set { } }
    public System.Activities.Presentation.View.TypeResolvingOptions DroppingTypeResolvingOptions { get { return default(System.Activities.Presentation.View.TypeResolvingOptions); } set { } }
    public System.Windows.DataTemplate FooterTemplate { get { return default(System.Windows.DataTemplate); } set { } }
    public System.Windows.DataTemplate HeaderTemplate { get { return default(System.Windows.DataTemplate); } set { } }
    public string HintText { get { return default(string); } set { } }
    public bool IsDefaultContainer { get { return default(bool); } set { } }
    public System.Activities.Presentation.Model.ModelItemCollection Items { get { return default(System.Activities.Presentation.Model.ModelItemCollection); } set { } }
    public System.Windows.Controls.ItemsPanelTemplate ItemsPanel { get { return default(System.Windows.Controls.ItemsPanelTemplate); } set { } }
    public System.Windows.DataTemplate SpacerTemplate { get { return default(System.Windows.DataTemplate); } set { } }
    public bool CanPasteItems(System.Collections.Generic.List<System.Object> itemsToPaste) { return default(bool); }
    protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { return default(System.Windows.Automation.Peers.AutomationPeer); }
    protected override void OnDragEnter(System.Windows.DragEventArgs e) { }
    protected override void OnDragOver(System.Windows.DragEventArgs e) { }
    protected override void OnDrop(System.Windows.DragEventArgs e) { }
    protected override void OnInitialized(System.EventArgs e) { }
    public void OnItemMoved(System.Activities.Presentation.Model.ModelItem modelItem) { }
    public object OnItemsCopied(System.Collections.Generic.List<System.Activities.Presentation.Model.ModelItem> itemsToCopy) { return default(object); }
    public object OnItemsCut(System.Collections.Generic.List<System.Activities.Presentation.Model.ModelItem> itemsToCut) { return default(object); }
    public void OnItemsDelete(System.Collections.Generic.List<System.Activities.Presentation.Model.ModelItem> itemsToDelete) { }
    public void OnItemsMoved(System.Collections.Generic.List<System.Activities.Presentation.Model.ModelItem> movedItems) { }
    public void OnItemsPasted(System.Collections.Generic.List<System.Object> itemsToPaste, System.Collections.Generic.List<System.Object> metaData, System.Windows.Point pastePoint, System.Activities.Presentation.WorkflowViewElement pastePointReference) { }
    public System.Collections.Generic.List<System.Activities.Presentation.Model.ModelItem> SortSelectedItems(System.Collections.Generic.List<System.Activities.Presentation.Model.ModelItem> selectedItems) { return default(System.Collections.Generic.List<System.Activities.Presentation.Model.ModelItem>); }
  }
  public partial class WorkflowViewElement : System.Windows.Controls.ContentControl, System.Activities.Presentation.ICompositeViewEvents {
    public static readonly System.Windows.DependencyProperty ContextProperty;
    public static readonly System.Windows.DependencyProperty ExpandStateProperty;
    public static readonly System.Windows.DependencyProperty ModelItemProperty;
    public static readonly System.Windows.DependencyProperty PinStateProperty;
    public static readonly System.Windows.DependencyProperty ShowExpandedProperty;
    public WorkflowViewElement() { }
    public bool Collapsible { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected System.Collections.Generic.IList<System.Activities.Presentation.ICompositeView> CompositeViews { get { return default(System.Collections.Generic.IList<System.Activities.Presentation.ICompositeView>); } }
    public System.Activities.Presentation.EditingContext Context { get { return default(System.Activities.Presentation.EditingContext); } set { } }
    protected System.Activities.Presentation.ICompositeView DefaultCompositeView { get { return default(System.Activities.Presentation.ICompositeView); } }
    protected internal System.Activities.Presentation.View.DesignerView Designer { get { return default(System.Activities.Presentation.View.DesignerView); } }
    public System.Windows.FrameworkElement DragHandle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Windows.FrameworkElement); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool ExpandState { get { return default(bool); } set { } }
    protected bool IsReadOnly { get { return default(bool); } }
    public bool IsRootDesigner { get { return default(bool); } }
    public System.Activities.Presentation.Model.ModelItem ModelItem { get { return default(System.Activities.Presentation.Model.ModelItem); } set { } }
    public bool PinState { get { return default(bool); } set { } }
    public bool ShowExpanded { get { return default(bool); } }
    protected internal System.Activities.Presentation.Services.ViewService ViewService { get { return default(System.Activities.Presentation.Services.ViewService); } }
    protected internal System.Activities.Presentation.View.ViewStateService ViewStateService { get { return default(System.Activities.Presentation.View.ViewStateService); } }
    protected virtual string GetAutomationHelpText() { return default(string); }
    protected virtual string GetAutomationIdMemberName() { return default(string); }
    protected internal virtual string GetAutomationItemStatus() { return default(string); }
    protected virtual void OnContextMenuLoaded(System.Windows.Controls.ContextMenu menu) { }
    protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { return default(System.Windows.Automation.Peers.AutomationPeer); }
    protected override void OnDragEnter(System.Windows.DragEventArgs e) { }
    protected override void OnDragOver(System.Windows.DragEventArgs e) { }
    protected internal virtual void OnEditAnnotation() { }
    protected override void OnInitialized(System.EventArgs e) { }
    protected virtual void OnModelItemChanged(object newItem) { }
    protected override void OnMouseDown(System.Windows.Input.MouseButtonEventArgs e) { }
    protected override void OnMouseMove(System.Windows.Input.MouseEventArgs e) { }
    protected override void OnMouseUp(System.Windows.Input.MouseButtonEventArgs e) { }
    protected override void OnPreviewDragEnter(System.Windows.DragEventArgs e) { }
    protected override void OnPreviewDragLeave(System.Windows.DragEventArgs e) { }
    protected override void OnPreviewMouseUp(System.Windows.Input.MouseButtonEventArgs e) { }
    protected virtual void OnReadOnlyChanged(bool isReadOnly) { }
    protected virtual void OnShowExpandedChanged(bool newValue) { }
    public void RegisterCompositeView(System.Activities.Presentation.ICompositeView container) { }
    public void RegisterDefaultCompositeView(System.Activities.Presentation.ICompositeView container) { }
    public void UnregisterCompositeView(System.Activities.Presentation.ICompositeView container) { }
    public void UnregisterDefaultCompositeView(System.Activities.Presentation.ICompositeView container) { }
  }
  public partial class XamlLoadErrorInfo {
    public XamlLoadErrorInfo(string message, int lineNumber, int linePosition) { }
    public string FileName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public int LineNumber { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    public int LinePosition { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    public string Message { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
  }
}
namespace System.Activities.Presentation.Annotations {
  public static partial class Annotation {
    public static readonly System.Xaml.AttachableMemberIdentifier AnnotationTextProperty;
    public static readonly string AnnotationTextPropertyName;
    public static string GetAnnotationText(object instance) { return default(string); }
    public static void SetAnnotationText(object instance, string annotationText) { }
  }
}
namespace System.Activities.Presentation.Converters {
  public partial class ArgumentToExpressionConverter : System.Windows.Data.IValueConverter {
    public ArgumentToExpressionConverter() { }
    public object Convert(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) { return default(object); }
    public object ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) { return default(object); }
  }
  public partial class ArgumentToExpressionModelItemConverter : System.Windows.Data.IMultiValueConverter {
    public ArgumentToExpressionModelItemConverter() { }
    public object Convert(System.Object[] values, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) { return default(object); }
    public System.Object[] ConvertBack(object value, System.Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture) { return default(System.Object[]); }
  }
  public sealed partial class ModelPropertyEntryToModelItemConverter : System.Windows.Data.IMultiValueConverter, System.Windows.Data.IValueConverter {
    public ModelPropertyEntryToModelItemConverter() { }
    public object Convert(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) { return default(object); }
    public object Convert(System.Object[] values, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) { return default(object); }
    public object ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) { return default(object); }
    public System.Object[] ConvertBack(object value, System.Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture) { return default(System.Object[]); }
  }
  public partial class ModelPropertyEntryToOwnerActivityConverter : System.Windows.Data.IValueConverter {
    public ModelPropertyEntryToOwnerActivityConverter() { }
    public object Convert(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) { return default(object); }
    public object ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) { return default(object); }
  }
  public partial class ModelToObjectValueConverter : System.Windows.Data.IValueConverter {
    public ModelToObjectValueConverter() { }
    public object Convert(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) { return default(object); }
    public object ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) { return default(object); }
  }
  public partial class ObjectToModelValueConverter : System.Windows.Data.IMultiValueConverter {
    public ObjectToModelValueConverter() { }
    public object Convert(System.Object[] values, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) { return default(object); }
    public System.Object[] ConvertBack(object value, System.Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture) { return default(System.Object[]); }
  }
}
namespace System.Activities.Presentation.Debug {
  [System.FlagsAttribute]
  public enum BreakpointTypes {
    Bounded = 2,
    Conditional = 4,
    Enabled = 1,
    None = 0,
  }
  public partial class DebuggerService : System.Activities.Presentation.Debug.IDesignerDebugView {
    public DebuggerService(System.Activities.Presentation.EditingContext context) { }
    public System.Activities.Debugger.SourceLocation CurrentContext { get { return default(System.Activities.Debugger.SourceLocation); } set { } }
    public System.Activities.Debugger.SourceLocation CurrentLocation { get { return default(System.Activities.Debugger.SourceLocation); } set { } }
    public bool HideSourceFileName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool IsDebugging { get { return default(bool); } set { } }
    public System.Activities.Debugger.SourceLocation SelectedLocation { get { return default(System.Activities.Debugger.SourceLocation); } }
    public void DeleteBreakpoint(System.Activities.Debugger.SourceLocation sourceLocation) { }
    public void EnsureVisible(System.Activities.Debugger.SourceLocation sourceLocation) { }
    public System.Collections.Generic.IDictionary<System.Activities.Debugger.SourceLocation, System.Activities.Presentation.Debug.BreakpointTypes> GetBreakpointLocations() { return default(System.Collections.Generic.IDictionary<System.Activities.Debugger.SourceLocation, System.Activities.Presentation.Debug.BreakpointTypes>); }
    public System.Activities.Debugger.SourceLocation GetExactLocation(System.Activities.Debugger.SourceLocation approximateLocation) { return default(System.Activities.Debugger.SourceLocation); }
    public void InsertBreakpoint(System.Activities.Debugger.SourceLocation sourceLocation, System.Activities.Presentation.Debug.BreakpointTypes breakpointType) { }
    public void ResetBreakpoints() { }
    public void UpdateBreakpoint(System.Activities.Debugger.SourceLocation sourceLocation, System.Activities.Presentation.Debug.BreakpointTypes newBreakpointType) { }
    public void UpdateSourceLocations(System.Collections.Generic.Dictionary<System.Object, System.Activities.Debugger.SourceLocation> newSourceLocationMapping) { }
  }
  public partial interface IDesignerDebugView {
    System.Activities.Debugger.SourceLocation CurrentContext { get; set; }
    System.Activities.Debugger.SourceLocation CurrentLocation { get; set; }
    bool HideSourceFileName { get; set; }
    bool IsDebugging { get; set; }
    System.Activities.Debugger.SourceLocation SelectedLocation { get; }
    void DeleteBreakpoint(System.Activities.Debugger.SourceLocation sourceLocation);
    void EnsureVisible(System.Activities.Debugger.SourceLocation sourceLocation);
    System.Collections.Generic.IDictionary<System.Activities.Debugger.SourceLocation, System.Activities.Presentation.Debug.BreakpointTypes> GetBreakpointLocations();
    System.Activities.Debugger.SourceLocation GetExactLocation(System.Activities.Debugger.SourceLocation approximateLocation);
    void InsertBreakpoint(System.Activities.Debugger.SourceLocation sourceLocation, System.Activities.Presentation.Debug.BreakpointTypes breakpointType);
    void ResetBreakpoints();
    void UpdateBreakpoint(System.Activities.Debugger.SourceLocation sourceLocation, System.Activities.Presentation.Debug.BreakpointTypes breakpointType);
  }
}
namespace System.Activities.Presentation.Expressions {
  public delegate System.Activities.ActivityWithResult CreateExpressionFromStringCallback(string expressionText, bool useLocationExpression, System.Type expressionType);
  public abstract partial class ExpressionActivityEditor : System.Windows.Controls.UserControl {
    public static readonly System.Windows.DependencyProperty AcceptsReturnProperty;
    public static readonly System.Windows.DependencyProperty AcceptsTabProperty;
    public static readonly System.Windows.DependencyProperty ExplicitCommitProperty;
    public static readonly System.Windows.DependencyProperty ExpressionProperty;
    public static readonly System.Windows.DependencyProperty ExpressionTypeProperty;
    public static readonly System.Windows.DependencyProperty HintTextProperty;
    public static readonly System.Windows.DependencyProperty HorizontalScrollBarVisibilityProperty;
    public static readonly System.Windows.DependencyProperty IsIndependentExpressionProperty;
    public static readonly System.Windows.DependencyProperty IsReadOnlyProperty;
    public static readonly System.Windows.DependencyProperty IsSupportedExpressionProperty;
    public static readonly System.Windows.DependencyProperty OwnerActivityProperty;
    public static readonly System.Windows.DependencyProperty PathToArgumentProperty;
    public static readonly System.Windows.DependencyProperty UseLocationExpressionProperty;
    public static readonly System.Windows.DependencyProperty VerticalScrollBarVisibilityProperty;
    protected ExpressionActivityEditor() { }
    public bool AcceptsReturn { get { return default(bool); } set { } }
    public bool AcceptsTab { get { return default(bool); } set { } }
    protected System.Activities.Presentation.EditingContext Context { get { return default(System.Activities.Presentation.EditingContext); } }
    public bool ExplicitCommit { get { return default(bool); } set { } }
    public System.Activities.Presentation.Model.ModelItem Expression { get { return default(System.Activities.Presentation.Model.ModelItem); } set { } }
    public System.Type ExpressionType { get { return default(System.Type); } set { } }
    public string HintText { get { return default(string); } set { } }
    public System.Windows.Controls.ScrollBarVisibility HorizontalScrollBarVisibility { get { return default(System.Windows.Controls.ScrollBarVisibility); } set { } }
    public bool IsIndependentExpression { get { return default(bool); } set { } }
    public bool IsReadOnly { get { return default(bool); } set { } }
    public bool IsSupportedExpression { get { return default(bool); } set { } }
    public System.Activities.Presentation.Model.ModelItem OwnerActivity { get { return default(System.Activities.Presentation.Model.ModelItem); } set { } }
    public string PathToArgument { get { return default(string); } set { } }
    public bool UseLocationExpression { get { return default(bool); } set { } }
    public System.Windows.Controls.ScrollBarVisibility VerticalScrollBarVisibility { get { return default(System.Windows.Controls.ScrollBarVisibility); } set { } }
    public virtual void BeginEdit() { }
    public virtual bool CanCommit() { return default(bool); }
    public abstract bool Commit(bool isExplicitCommit);
    public static string GetExpressionActivityEditor(object target) { return default(string); }
    public static void SetExpressionActivityEditor(object target, string name) { }
  }
  public abstract partial class ExpressionMorphHelper {
    protected ExpressionMorphHelper() { }
    public virtual bool TryInferReturnType(System.Activities.ActivityWithResult expression, System.Activities.Presentation.EditingContext context, out System.Type returnType) { returnType = default(System.Type); return default(bool); }
    public abstract bool TryMorphExpression(System.Activities.ActivityWithResult expression, bool isLocationExpression, System.Type newType, System.Activities.Presentation.EditingContext context, out System.Activities.ActivityWithResult newExpression);
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
  public sealed partial class ExpressionMorphHelperAttribute : System.Attribute {
    public ExpressionMorphHelperAttribute(System.Type expressionMorphHelperType) { }
    public System.Type ExpressionMorphHelperType { get { return default(System.Type); } }
  }
  public abstract partial class TextualExpressionEditor : System.Activities.Presentation.Expressions.ExpressionActivityEditor {
    public static readonly System.Windows.DependencyProperty DefaultValueProperty;
    public static readonly System.Windows.DependencyProperty MaxLinesProperty;
    public static readonly System.Windows.DependencyProperty MinLinesProperty;
    protected TextualExpressionEditor() { }
    public string DefaultValue { get { return default(string); } set { } }
    public virtual System.Activities.Presentation.View.IExpressionEditorService ExpressionEditorService { get { return default(System.Activities.Presentation.View.IExpressionEditorService); } }
    public int MaxLines { get { return default(int); } set { } }
    public int MinLines { get { return default(int); } set { } }
    public virtual void OnCompleteWordCommandCanExecute(System.Windows.Input.CanExecuteRoutedEventArgs e) { }
    public virtual void OnCompleteWordCommandExecute(System.Windows.Input.ExecutedRoutedEventArgs e) { }
    public virtual void OnDecreaseFilterLevelCommandCanExecute(System.Windows.Input.CanExecuteRoutedEventArgs e) { }
    public virtual void OnDecreaseFilterLevelCommandExecute(System.Windows.Input.ExecutedRoutedEventArgs e) { }
    public virtual void OnGlobalIntellisenseCommandCanExecute(System.Windows.Input.CanExecuteRoutedEventArgs e) { }
    public virtual void OnGlobalIntellisenseCommandExecute(System.Windows.Input.ExecutedRoutedEventArgs e) { }
    public virtual void OnIncreaseFilterLevelCommandCanExecute(System.Windows.Input.CanExecuteRoutedEventArgs e) { }
    public virtual void OnIncreaseFilterLevelCommandExecute(System.Windows.Input.ExecutedRoutedEventArgs e) { }
    public virtual void OnParameterInfoCommandCanExecute(System.Windows.Input.CanExecuteRoutedEventArgs e) { }
    public virtual void OnParameterInfoCommandExecute(System.Windows.Input.ExecutedRoutedEventArgs e) { }
    public virtual void OnQuickInfoCommandCanExecute(System.Windows.Input.CanExecuteRoutedEventArgs e) { }
    public virtual void OnQuickInfoCommandExecute(System.Windows.Input.ExecutedRoutedEventArgs e) { }
  }
}
namespace System.Activities.Presentation.Hosting {
  public sealed partial class AssemblyContextControlItem : System.Activities.Presentation.ContextItem {
    public AssemblyContextControlItem() { }
    public System.Collections.Generic.IEnumerable<System.String> AllAssemblyNamesInContext { [System.Runtime.CompilerServices.IteratorStateMachineAttribute(typeof(System.Activities.Presentation.Hosting.AssemblyContextControlItem.<get_AllAssemblyNamesInContext>d__11))]get { return default(System.Collections.Generic.IEnumerable<System.String>); } }
    public override System.Type ItemType { get { return default(System.Type); } }
    public System.Reflection.AssemblyName LocalAssemblyName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Reflection.AssemblyName); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.Generic.IList<System.Reflection.AssemblyName> ReferencedAssemblyNames { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IList<System.Reflection.AssemblyName>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public static System.Reflection.Assembly GetAssembly(System.Reflection.AssemblyName assemblyName, System.Activities.Presentation.Hosting.IMultiTargetingSupportService multiTargetingService) { return default(System.Reflection.Assembly); }
    public System.Collections.Generic.IEnumerable<System.Reflection.Assembly> GetEnvironmentAssemblies(System.Activities.Presentation.Hosting.IMultiTargetingSupportService multiTargetingService) { return default(System.Collections.Generic.IEnumerable<System.Reflection.Assembly>); }
    public System.Collections.Generic.IEnumerable<System.Reflection.AssemblyName> GetEnvironmentAssemblyNames() { return default(System.Collections.Generic.IEnumerable<System.Reflection.AssemblyName>); }
  }
  public sealed partial class CommandInfo {
    internal CommandInfo() { }
    public System.Windows.Input.ICommand Command { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Windows.Input.ICommand); } }
    public bool IsBindingEnabledInDesigner { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public static partial class CommandValues {
    public const int DeleteBreakpoint = 7;
    public const int DisableBreakpoint = 9;
    public const int EnableBreakpoint = 8;
    public const int InsertBreakpoint = 6;
    public const int ShowProperties = 5;
  }
  public partial interface ICommandService {
    bool CanExecuteCommand(int commandId);
    void ExecuteCommand(int commandId, System.Collections.Generic.Dictionary<System.String, System.Object> parameters);
    bool IsCommandSupported(int commandId);
  }
  public partial interface IDocumentPersistenceService {
    void Flush(object documentRoot);
    object Load(string fileName);
    void OnModelChanged(object documentRoot);
  }
  public sealed partial class ImportedNamespaceContextItem : System.Activities.Presentation.ContextItem {
    public ImportedNamespaceContextItem() { }
    public System.Collections.ObjectModel.Collection<System.String> ImportedNamespaces { get { return default(System.Collections.ObjectModel.Collection<System.String>); } }
    public override System.Type ItemType { get { return default(System.Type); } }
    public void EnsureInitialized(System.Activities.Presentation.EditingContext context) { }
  }
  public partial interface IMultiTargetingSupportService {
    System.Reflection.Assembly GetReflectionAssembly(System.Reflection.AssemblyName targetAssemblyName);
    System.Type GetRuntimeType(System.Type reflectionType);
    bool IsSupportedType(System.Type type);
  }
  public partial interface IWorkflowCommandExtensionCallback {
    void OnWorkflowCommandLoaded(System.Activities.Presentation.Hosting.CommandInfo commandInfo);
  }
  public abstract partial class MultiTargetingSupportService : System.Activities.Presentation.Hosting.IMultiTargetingSupportService {
    protected MultiTargetingSupportService() { }
    public abstract System.Reflection.Assembly GetReflectionAssembly(System.Reflection.AssemblyName targetAssemblyName);
    public abstract System.Type GetReflectionType(System.Type objectType);
    public abstract System.Type GetRuntimeType(System.Type reflectionType);
    public abstract bool IsSupportedType(System.Type type);
  }
  public sealed partial class ReadOnlyState : System.Activities.Presentation.ContextItem {
    public ReadOnlyState() { }
    public bool IsReadOnly { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override System.Type ItemType { get { return default(System.Type); } }
  }
  public partial class WindowHelperService {
    public WindowHelperService(System.IntPtr hwnd) { }
    public System.IntPtr ParentWindowHwnd { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.IntPtr); } }
    public bool RegisterWindowMessageHandler(System.Activities.Presentation.Hosting.WindowMessage callback) { return default(bool); }
    public bool TrySetWindowOwner(System.Windows.DependencyObject source, System.Windows.Window target) { return default(bool); }
    public bool UnregisterWindowMessageHandler(System.Activities.Presentation.Hosting.WindowMessage callback) { return default(bool); }
  }
  public delegate void WindowMessage(int msgId, System.IntPtr parameter1, System.IntPtr parameter2);
  public sealed partial class WorkflowCommandExtensionItem : System.Activities.Presentation.ContextItem {
    public WorkflowCommandExtensionItem() { }
    public WorkflowCommandExtensionItem(System.Activities.Presentation.Hosting.IWorkflowCommandExtensionCallback callback) { }
    public override System.Type ItemType { get { return default(System.Type); } }
  }
}
namespace System.Activities.Presentation.Metadata {
  public static partial class ActivityArgumentHelper {
    public static void RegisterAccessorsGenerator(System.Type activityType, System.Func<System.Activities.Activity, System.Collections.Generic.IEnumerable<System.Activities.Presentation.ArgumentAccessor>> argumentAccessorsGenerator) { }
  }
  public delegate void AttributeCallback(System.Activities.Presentation.Metadata.AttributeCallbackBuilder builder);
  public sealed partial class AttributeCallbackBuilder {
    internal AttributeCallbackBuilder() { }
    public System.Type CallbackType { get { return default(System.Type); } }
    public void AddCustomAttributes(params System.Attribute[] attributes) { }
    public void AddCustomAttributes(System.ComponentModel.MemberDescriptor descriptor, params System.Attribute[] attributes) { }
    public void AddCustomAttributes(System.Reflection.MemberInfo member, params System.Attribute[] attributes) { }
    public void AddCustomAttributes(string memberName, params System.Attribute[] attributes) { }
    public void AddCustomAttributes(System.Windows.DependencyProperty dp, params System.Attribute[] attributes) { }
  }
  public sealed partial class AttributeTable {
    internal AttributeTable() { }
    public System.Collections.Generic.IEnumerable<System.Type> AttributedTypes { get { return default(System.Collections.Generic.IEnumerable<System.Type>); } }
    public bool ContainsAttributes(System.Type type) { return default(bool); }
    public System.Collections.IEnumerable GetCustomAttributes(System.Type type) { return default(System.Collections.IEnumerable); }
    public System.Collections.IEnumerable GetCustomAttributes(System.Type ownerType, System.ComponentModel.MemberDescriptor descriptor) { return default(System.Collections.IEnumerable); }
    public System.Collections.IEnumerable GetCustomAttributes(System.Type ownerType, System.Reflection.MemberInfo member) { return default(System.Collections.IEnumerable); }
    public System.Collections.IEnumerable GetCustomAttributes(System.Type ownerType, string memberName) { return default(System.Collections.IEnumerable); }
    public System.Collections.IEnumerable GetCustomAttributes(System.Type ownerType, System.Windows.DependencyProperty dp) { return default(System.Collections.IEnumerable); }
  }
  public partial class AttributeTableBuilder {
    public AttributeTableBuilder() { }
    public void AddCallback(System.Type type, System.Activities.Presentation.Metadata.AttributeCallback callback) { }
    public void AddCustomAttributes(System.Type type, params System.Attribute[] attributes) { }
    public void AddCustomAttributes(System.Type ownerType, System.ComponentModel.MemberDescriptor descriptor, params System.Attribute[] attributes) { }
    public void AddCustomAttributes(System.Type ownerType, System.Reflection.MemberInfo member, params System.Attribute[] attributes) { }
    public void AddCustomAttributes(System.Type ownerType, string memberName, params System.Attribute[] attributes) { }
    public void AddCustomAttributes(System.Type ownerType, System.Windows.DependencyProperty dp, params System.Attribute[] attributes) { }
    public void AddTable(System.Activities.Presentation.Metadata.AttributeTable table) { }
    public System.Activities.Presentation.Metadata.AttributeTable CreateTable() { return default(System.Activities.Presentation.Metadata.AttributeTable); }
    public void ValidateTable() { }
  }
  public partial class AttributeTableValidationException : System.Exception {
    public AttributeTableValidationException() { }
    protected AttributeTableValidationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public AttributeTableValidationException(string message) { }
    public AttributeTableValidationException(string message, System.Collections.Generic.IEnumerable<System.String> validationErrors) { }
    public AttributeTableValidationException(string message, System.Exception inner) { }
    public AttributeTableValidationException(string message, System.Exception inner, System.Collections.Generic.IEnumerable<System.String> validationErrors) { }
    public System.Collections.Generic.IEnumerable<System.String> ValidationErrors { get { return default(System.Collections.Generic.IEnumerable<System.String>); } }
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial interface IRegisterMetadata {
    void Register();
  }
  public static partial class MetadataStore {
    public static void AddAttributeTable(System.Activities.Presentation.Metadata.AttributeTable table) { }
  }
}
namespace System.Activities.Presentation.Model {
  public partial class AttachedPropertiesService {
    public AttachedPropertiesService() { }
    public void AddProperty(System.Activities.Presentation.Model.AttachedProperty property) { }
  }
  public abstract partial class AttachedProperty {
    protected AttachedProperty() { }
    public bool IsBrowsable { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public abstract bool IsReadOnly { get; }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Type OwnerType { get { return default(System.Type); } set { } }
    public abstract System.Type Type { get; }
    public abstract object GetValue(System.Activities.Presentation.Model.ModelItem modelItem);
    public void NotifyPropertyChanged(System.Activities.Presentation.Model.ModelItem modelItem) { }
    public abstract void ResetValue(System.Activities.Presentation.Model.ModelItem modelItem);
    public abstract void SetValue(System.Activities.Presentation.Model.ModelItem modelItem, object value);
  }
  public partial class AttachedProperty<T> : System.Activities.Presentation.Model.AttachedProperty {
    public AttachedProperty() { }
    public System.Func<System.Activities.Presentation.Model.ModelItem, T> Getter { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Func<System.Activities.Presentation.Model.ModelItem, T>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override bool IsReadOnly { get { return default(bool); } }
    public System.Action<System.Activities.Presentation.Model.ModelItem, T> Setter { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Action<System.Activities.Presentation.Model.ModelItem, T>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override System.Type Type { get { return default(System.Type); } }
    public override object GetValue(System.Activities.Presentation.Model.ModelItem modelItem) { return default(object); }
    public override void ResetValue(System.Activities.Presentation.Model.ModelItem modelItem) { }
    public override void SetValue(System.Activities.Presentation.Model.ModelItem modelItem, object Value) { }
  }
  public abstract partial class AttachedPropertyInfo {
    protected AttachedPropertyInfo() { }
    public string PropertyName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public sealed partial class AttachedPropertyInfo<T> : System.Activities.Presentation.Model.AttachedPropertyInfo {
    public AttachedPropertyInfo() { }
    public T DefaultValue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(T); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public abstract partial class Change {
    protected Change() { }
    public abstract string Description { get; }
    public abstract bool Apply();
    public abstract System.Activities.Presentation.Model.Change GetInverse();
  }
  [System.FlagsAttribute]
  public enum CreateOptions {
    InitializeDefaults = 1,
    None = 0,
  }
  public partial class EditingScope : System.Activities.Presentation.Model.ModelEditingScope {
    internal EditingScope() { }
    public System.Collections.Generic.List<System.Activities.Presentation.Model.Change> Changes { get { return default(System.Collections.Generic.List<System.Activities.Presentation.Model.Change>); } }
    public bool HasEffectiveChanges { get { return default(bool); } }
    protected override bool CanComplete() { return default(bool); }
    protected override void OnComplete() { }
    protected override bool OnException(System.Exception e) { return default(bool); }
    protected override void OnRevert(bool finalizing) { }
  }
  public partial class EditingScopeEventArgs : System.EventArgs {
    public EditingScopeEventArgs() { }
    public System.Activities.Presentation.Model.EditingScope EditingScope { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Presentation.Model.EditingScope); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public abstract partial class ModelEditingScope : System.IDisposable {
    protected ModelEditingScope() { }
    public string Description { get { return default(string); } set { } }
    protected abstract bool CanComplete();
    public void Complete() { }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    protected abstract void OnComplete();
    protected abstract bool OnException(System.Exception exception);
    protected abstract void OnRevert(bool finalizing);
    public void Revert() { }
  }
  public static partial class ModelFactory {
    public static System.Activities.Presentation.Model.ModelItem CreateItem(System.Activities.Presentation.EditingContext context, object item) { return default(System.Activities.Presentation.Model.ModelItem); }
    public static System.Activities.Presentation.Model.ModelItem CreateItem(System.Activities.Presentation.EditingContext context, System.Type itemType, System.Activities.Presentation.Model.CreateOptions options, params System.Object[] arguments) { return default(System.Activities.Presentation.Model.ModelItem); }
    public static System.Activities.Presentation.Model.ModelItem CreateItem(System.Activities.Presentation.EditingContext context, System.Type itemType, params System.Object[] arguments) { return default(System.Activities.Presentation.Model.ModelItem); }
    public static System.Activities.Presentation.Model.ModelItem CreateStaticMemberItem(System.Activities.Presentation.EditingContext context, System.Type type, string memberName) { return default(System.Activities.Presentation.Model.ModelItem); }
  }
  public abstract partial class ModelItem : System.ComponentModel.INotifyPropertyChanged {
    protected ModelItem() { }
    public abstract System.ComponentModel.AttributeCollection Attributes { get; }
    public abstract System.Activities.Presentation.Model.ModelProperty Content { get; }
    public abstract System.Type ItemType { get; }
    public abstract string Name { get; set; }
    public abstract System.Activities.Presentation.Model.ModelItem Parent { get; }
    public abstract System.Collections.Generic.IEnumerable<System.Activities.Presentation.Model.ModelItem> Parents { get; }
    public abstract System.Activities.Presentation.Model.ModelPropertyCollection Properties { get; }
    public abstract System.Activities.Presentation.Model.ModelItem Root { get; }
    public abstract System.Activities.Presentation.Model.ModelProperty Source { get; }
    public abstract System.Collections.Generic.IEnumerable<System.Activities.Presentation.Model.ModelProperty> Sources { get; }
    public abstract System.Windows.DependencyObject View { get; }
    public abstract event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
    public abstract System.Activities.Presentation.Model.ModelEditingScope BeginEdit();
    public virtual System.Activities.Presentation.Model.ModelEditingScope BeginEdit(bool shouldApplyChangesImmediately) { return default(System.Activities.Presentation.Model.ModelEditingScope); }
    public abstract System.Activities.Presentation.Model.ModelEditingScope BeginEdit(string description);
    public virtual System.Activities.Presentation.Model.ModelEditingScope BeginEdit(string description, bool shouldApplyChangesImmediately) { return default(System.Activities.Presentation.Model.ModelEditingScope); }
    public abstract object GetCurrentValue();
    public override string ToString() { return default(string); }
  }
  public abstract partial class ModelItemCollection : System.Activities.Presentation.Model.ModelItem, System.Collections.Generic.ICollection<System.Activities.Presentation.Model.ModelItem>, System.Collections.Generic.IEnumerable<System.Activities.Presentation.Model.ModelItem>, System.Collections.Generic.IList<System.Activities.Presentation.Model.ModelItem>, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.Collections.Specialized.INotifyCollectionChanged {
    public static readonly System.Windows.DependencyProperty ItemProperty;
    protected ModelItemCollection() { }
    public abstract int Count { get; }
    protected virtual bool IsFixedSize { get { return default(bool); } }
    public abstract bool IsReadOnly { get; }
    protected virtual bool IsSynchronized { get { return default(bool); } }
    public abstract System.Activities.Presentation.Model.ModelItem this[int index] { get; set; }
    protected virtual object SyncRoot { get { return default(object); } }
    int System.Collections.ICollection.Count { get { return default(int); } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    bool System.Collections.IList.IsFixedSize { get { return default(bool); } }
    bool System.Collections.IList.IsReadOnly { get { return default(bool); } }
    object System.Collections.IList.this[int index] { get { return default(object); } set { } }
    public abstract event System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged;
    public abstract void Add(System.Activities.Presentation.Model.ModelItem item);
    public abstract System.Activities.Presentation.Model.ModelItem Add(object value);
    public abstract void Clear();
    public abstract bool Contains(System.Activities.Presentation.Model.ModelItem item);
    public abstract bool Contains(object value);
    public abstract void CopyTo(System.Activities.Presentation.Model.ModelItem[] array, int arrayIndex);
    public abstract System.Collections.Generic.IEnumerator<System.Activities.Presentation.Model.ModelItem> GetEnumerator();
    public abstract int IndexOf(System.Activities.Presentation.Model.ModelItem item);
    public abstract void Insert(int index, System.Activities.Presentation.Model.ModelItem item);
    public abstract System.Activities.Presentation.Model.ModelItem Insert(int index, object value);
    public abstract void Move(int fromIndex, int toIndex);
    public abstract bool Remove(System.Activities.Presentation.Model.ModelItem item);
    public abstract bool Remove(object value);
    public abstract void RemoveAt(int index);
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    [System.Runtime.CompilerServices.IteratorStateMachineAttribute(typeof(System.Activities.Presentation.Model.ModelItemCollection.<System-Collections-IEnumerable-GetEnumerator>d__54))]
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    int System.Collections.IList.Add(object value) { return default(int); }
    void System.Collections.IList.Clear() { }
    bool System.Collections.IList.Contains(object value) { return default(bool); }
    int System.Collections.IList.IndexOf(object value) { return default(int); }
    void System.Collections.IList.Insert(int index, object value) { }
    void System.Collections.IList.Remove(object value) { }
    void System.Collections.IList.RemoveAt(int index) { }
  }
  public abstract partial class ModelItemDictionary : System.Activities.Presentation.Model.ModelItem, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.Activities.Presentation.Model.ModelItem, System.Activities.Presentation.Model.ModelItem>>, System.Collections.Generic.IDictionary<System.Activities.Presentation.Model.ModelItem, System.Activities.Presentation.Model.ModelItem>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Activities.Presentation.Model.ModelItem, System.Activities.Presentation.Model.ModelItem>>, System.Collections.ICollection, System.Collections.IDictionary, System.Collections.IEnumerable, System.Collections.Specialized.INotifyCollectionChanged {
    public static readonly System.Windows.DependencyProperty KeyProperty;
    protected ModelItemDictionary() { }
    public abstract int Count { get; }
    protected virtual bool IsFixedSize { get { return default(bool); } }
    public abstract bool IsReadOnly { get; }
    protected virtual bool IsSynchronized { get { return default(bool); } }
    public abstract System.Activities.Presentation.Model.ModelItem this[System.Activities.Presentation.Model.ModelItem key] { get; set; }
    public abstract System.Activities.Presentation.Model.ModelItem this[object key] { get; set; }
    public abstract System.Collections.Generic.ICollection<System.Activities.Presentation.Model.ModelItem> Keys { get; }
    protected virtual object SyncRoot { get { return default(object); } }
    int System.Collections.ICollection.Count { get { return default(int); } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    bool System.Collections.IDictionary.IsFixedSize { get { return default(bool); } }
    bool System.Collections.IDictionary.IsReadOnly { get { return default(bool); } }
    object System.Collections.IDictionary.this[object key] { get { return default(object); } set { } }
    System.Collections.ICollection System.Collections.IDictionary.Keys { get { return default(System.Collections.ICollection); } }
    System.Collections.ICollection System.Collections.IDictionary.Values { get { return default(System.Collections.ICollection); } }
    public abstract System.Collections.Generic.ICollection<System.Activities.Presentation.Model.ModelItem> Values { get; }
    public abstract event System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged;
    public abstract void Add(System.Activities.Presentation.Model.ModelItem key, System.Activities.Presentation.Model.ModelItem value);
    public abstract System.Activities.Presentation.Model.ModelItem Add(object key, object value);
    public abstract void Clear();
    protected virtual bool Contains(System.Collections.Generic.KeyValuePair<System.Activities.Presentation.Model.ModelItem, System.Activities.Presentation.Model.ModelItem> item) { return default(bool); }
    public abstract bool ContainsKey(System.Activities.Presentation.Model.ModelItem key);
    public abstract bool ContainsKey(object key);
    protected virtual void CopyTo(System.Collections.Generic.KeyValuePair<System.Activities.Presentation.Model.ModelItem, System.Activities.Presentation.Model.ModelItem>[] array, int arrayIndex) { }
    public abstract System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Activities.Presentation.Model.ModelItem, System.Activities.Presentation.Model.ModelItem>> GetEnumerator();
    public abstract bool Remove(System.Activities.Presentation.Model.ModelItem key);
    public abstract bool Remove(object key);
    void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.Activities.Presentation.Model.ModelItem,System.Activities.Presentation.Model.ModelItem>>.Add(System.Collections.Generic.KeyValuePair<System.Activities.Presentation.Model.ModelItem, System.Activities.Presentation.Model.ModelItem> item) { }
    bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.Activities.Presentation.Model.ModelItem,System.Activities.Presentation.Model.ModelItem>>.Contains(System.Collections.Generic.KeyValuePair<System.Activities.Presentation.Model.ModelItem, System.Activities.Presentation.Model.ModelItem> item) { return default(bool); }
    void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.Activities.Presentation.Model.ModelItem,System.Activities.Presentation.Model.ModelItem>>.CopyTo(System.Collections.Generic.KeyValuePair<System.Activities.Presentation.Model.ModelItem, System.Activities.Presentation.Model.ModelItem>[] array, int arrayIndex) { }
    bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.Activities.Presentation.Model.ModelItem,System.Activities.Presentation.Model.ModelItem>>.Remove(System.Collections.Generic.KeyValuePair<System.Activities.Presentation.Model.ModelItem, System.Activities.Presentation.Model.ModelItem> item) { return default(bool); }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    void System.Collections.IDictionary.Add(object key, object value) { }
    void System.Collections.IDictionary.Clear() { }
    bool System.Collections.IDictionary.Contains(object key) { return default(bool); }
    System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { return default(System.Collections.IDictionaryEnumerator); }
    void System.Collections.IDictionary.Remove(object key) { }
    [System.Runtime.CompilerServices.IteratorStateMachineAttribute(typeof(System.Activities.Presentation.Model.ModelItemDictionary.<System-Collections-IEnumerable-GetEnumerator>d__61))]
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    public abstract bool TryGetValue(System.Activities.Presentation.Model.ModelItem key, out System.Activities.Presentation.Model.ModelItem value);
    public abstract bool TryGetValue(object key, out System.Activities.Presentation.Model.ModelItem value);
  }
  public static partial class ModelItemExtensions {
    public static void Focus(this System.Activities.Presentation.Model.ModelItem item) { }
    public static void Focus(this System.Activities.Presentation.Model.ModelItem item, int level) { }
    public static System.Activities.Presentation.EditingContext GetEditingContext(this System.Activities.Presentation.Model.ModelItem modelItem) { return default(System.Activities.Presentation.EditingContext); }
    public static System.Activities.Presentation.Model.ModelItem GetModelItemFromPath(string path, System.Activities.Presentation.Model.ModelItem root) { return default(System.Activities.Presentation.Model.ModelItem); }
    public static string GetModelPath(this System.Activities.Presentation.Model.ModelItem modelItem) { return default(string); }
    public static bool IsParentOf(this System.Activities.Presentation.Model.ModelItem item, System.Activities.Presentation.Model.ModelItem child) { return default(bool); }
  }
  public abstract partial class ModelMemberCollection<TItemType, TFindType> : System.Collections.Generic.IEnumerable<TItemType>, System.Collections.IEnumerable {
    internal ModelMemberCollection() { }
    public TItemType this[TFindType value] { get { return default(TItemType); } }
    public TItemType this[string name] { get { return default(TItemType); } }
    public TItemType Find(TFindType value) { return default(TItemType); }
    protected abstract TItemType Find(TFindType value, bool throwOnError);
    public TItemType Find(string name) { return default(TItemType); }
    protected abstract TItemType Find(string name, bool throwOnError);
    public abstract System.Collections.Generic.IEnumerator<TItemType> GetEnumerator();
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public abstract partial class ModelProperty {
    protected ModelProperty() { }
    public abstract System.Type AttachedOwnerType { get; }
    public abstract System.ComponentModel.AttributeCollection Attributes { get; }
    public abstract System.Activities.Presentation.Model.ModelItemCollection Collection { get; }
    public abstract object ComputedValue { get; set; }
    public abstract System.ComponentModel.TypeConverter Converter { get; }
    public abstract object DefaultValue { get; }
    public abstract System.Activities.Presentation.Model.ModelItemDictionary Dictionary { get; }
    public abstract bool IsAttached { get; }
    public abstract bool IsBrowsable { get; }
    public abstract bool IsCollection { get; }
    public abstract bool IsDictionary { get; }
    public abstract bool IsReadOnly { get; }
    public abstract bool IsSet { get; }
    public abstract string Name { get; }
    public abstract System.Activities.Presentation.Model.ModelItem Parent { get; }
    public abstract System.Type PropertyType { get; }
    public abstract System.Activities.Presentation.Model.ModelItem Value { get; }
    public abstract void ClearValue();
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Activities.Presentation.Model.ModelProperty first, System.Activities.Presentation.Model.ModelProperty second) { return default(bool); }
    public static bool operator !=(System.Activities.Presentation.Model.ModelProperty first, System.Activities.Presentation.Model.ModelProperty second) { return default(bool); }
    public abstract System.Activities.Presentation.Model.ModelItem SetValue(object value);
  }
  public abstract partial class ModelPropertyCollection : System.Activities.Presentation.Model.ModelMemberCollection<System.Activities.Presentation.Model.ModelProperty, System.Windows.DependencyProperty> {
    protected ModelPropertyCollection() { }
  }
  public partial class ModelTreeManager {
    public ModelTreeManager(System.Activities.Presentation.EditingContext context) { }
    public System.Activities.Presentation.Model.ModelItem Root { get { return default(System.Activities.Presentation.Model.ModelItem); } }
    public event System.EventHandler<System.Activities.Presentation.Model.EditingScopeEventArgs> EditingScopeCompleted { add { } remove { } }
    public System.Activities.Presentation.Model.ModelItem CreateModelItem(System.Activities.Presentation.Model.ModelItem parent, object instance) { return default(System.Activities.Presentation.Model.ModelItem); }
    public System.Activities.Presentation.Model.ModelItem GetModelItem(object instance, bool shouldExpandModelTree) { return default(System.Activities.Presentation.Model.ModelItem); }
    public void Load(object rootInstance) { }
  }
  public static partial class MorphHelper {
    public static void AddPropertyValueMorphHelper(System.Type propertyType, System.Activities.Presentation.Model.PropertyValueMorphHelper extension) { }
    public static System.Activities.Presentation.Model.PropertyValueMorphHelper GetPropertyValueMorphHelper(System.Type propertyType) { return default(System.Activities.Presentation.Model.PropertyValueMorphHelper); }
    public static void MorphObject(System.Activities.Presentation.Model.ModelItem oldModelItem, System.Activities.Presentation.Model.ModelItem newModelitem) { }
    public static void MorphProperties(System.Activities.Presentation.Model.ModelItem oldModelItem, System.Activities.Presentation.Model.ModelItem newModelitem) { }
  }
  public delegate object PropertyValueMorphHelper(System.Activities.Presentation.Model.ModelItem originalValue, System.Activities.Presentation.Model.ModelProperty newModelProperty);
  public sealed partial class TextImage {
    public TextImage() { }
    public System.Collections.Generic.IList<System.String> Lines { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IList<System.String>); } }
    public int StartLineIndex { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
}
namespace System.Activities.Presentation.PropertyEditing {
  public abstract partial class CategoryEditor {
    protected CategoryEditor() { }
    public abstract System.Windows.DataTemplate EditorTemplate { get; }
    public abstract string TargetCategory { get; }
    public abstract bool ConsumesProperty(System.Activities.Presentation.PropertyEditing.PropertyEntry propertyEntry);
    public static System.ComponentModel.EditorAttribute CreateEditorAttribute(System.Activities.Presentation.PropertyEditing.CategoryEditor editor) { return default(System.ComponentModel.EditorAttribute); }
    public static System.ComponentModel.EditorAttribute CreateEditorAttribute(System.Type categoryEditorType) { return default(System.ComponentModel.EditorAttribute); }
    public abstract object GetImage(System.Windows.Size desiredSize);
  }
  public abstract partial class CategoryEntry : System.Activities.Presentation.PropertyEditing.IPropertyFilterTarget, System.ComponentModel.INotifyPropertyChanged {
    protected CategoryEntry(string name) { }
    public string CategoryName { get { return default(string); } }
    public abstract System.Activities.Presentation.PropertyEditing.PropertyEntry this[string propertyName] { get; }
    public virtual bool MatchesFilter { get { return default(bool); } protected set { } }
    public abstract System.Collections.Generic.IEnumerable<System.Activities.Presentation.PropertyEditing.PropertyEntry> Properties { get; }
    public event System.EventHandler<System.Activities.Presentation.PropertyEditing.PropertyFilterAppliedEventArgs> FilterApplied { add { } remove { } }
    public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged { add { } remove { } }
    public virtual void ApplyFilter(System.Activities.Presentation.PropertyEditing.PropertyFilter filter) { }
    public abstract bool MatchesPredicate(System.Activities.Presentation.PropertyEditing.PropertyFilterPredicate predicate);
    protected virtual void OnFilterApplied(System.Activities.Presentation.PropertyEditing.PropertyFilter filter) { }
    protected virtual void OnPropertyChanged(string propertyName) { }
  }
  public partial class DependencyPropertyValueSource : System.Activities.Presentation.PropertyEditing.PropertyValueSource {
    internal DependencyPropertyValueSource() { }
    public static System.Activities.Presentation.PropertyEditing.DependencyPropertyValueSource CustomMarkupExtension { get { return default(System.Activities.Presentation.PropertyEditing.DependencyPropertyValueSource); } }
    public static System.Activities.Presentation.PropertyEditing.DependencyPropertyValueSource DataBound { get { return default(System.Activities.Presentation.PropertyEditing.DependencyPropertyValueSource); } }
    public static System.Activities.Presentation.PropertyEditing.DependencyPropertyValueSource DefaultValue { get { return default(System.Activities.Presentation.PropertyEditing.DependencyPropertyValueSource); } }
    public static System.Activities.Presentation.PropertyEditing.DependencyPropertyValueSource Inherited { get { return default(System.Activities.Presentation.PropertyEditing.DependencyPropertyValueSource); } }
    public bool IsCustomMarkupExtension { get { return default(bool); } }
    public bool IsDataBound { get { return default(bool); } }
    public bool IsDefaultValue { get { return default(bool); } }
    public bool IsExpression { get { return default(bool); } }
    public bool IsInherited { get { return default(bool); } }
    public bool IsLocal { get { return default(bool); } }
    public bool IsLocalResource { get { return default(bool); } }
    public bool IsResource { get { return default(bool); } }
    public bool IsSystemResource { get { return default(bool); } }
    public bool IsTemplateBinding { get { return default(bool); } }
    public static System.Activities.Presentation.PropertyEditing.DependencyPropertyValueSource Local { get { return default(System.Activities.Presentation.PropertyEditing.DependencyPropertyValueSource); } }
    public static System.Activities.Presentation.PropertyEditing.DependencyPropertyValueSource LocalDynamicResource { get { return default(System.Activities.Presentation.PropertyEditing.DependencyPropertyValueSource); } }
    public static System.Activities.Presentation.PropertyEditing.DependencyPropertyValueSource LocalStaticResource { get { return default(System.Activities.Presentation.PropertyEditing.DependencyPropertyValueSource); } }
    public static System.Activities.Presentation.PropertyEditing.DependencyPropertyValueSource SystemResource { get { return default(System.Activities.Presentation.PropertyEditing.DependencyPropertyValueSource); } }
    public static System.Activities.Presentation.PropertyEditing.DependencyPropertyValueSource TemplateBinding { get { return default(System.Activities.Presentation.PropertyEditing.DependencyPropertyValueSource); } }
  }
  public partial class DialogPropertyValueEditor : System.Activities.Presentation.PropertyEditing.PropertyValueEditor {
    public DialogPropertyValueEditor() { }
    public DialogPropertyValueEditor(System.Windows.DataTemplate dialogEditorTemplate, System.Windows.DataTemplate inlineEditorTemplate) { }
    public System.Windows.DataTemplate DialogEditorTemplate { get { return default(System.Windows.DataTemplate); } set { } }
    public virtual void ShowDialog(System.Activities.Presentation.PropertyEditing.PropertyValue propertyValue, System.Windows.IInputElement commandSource) { }
  }
  public partial class EditModeSwitchButton : System.Windows.Controls.Button {
    public static readonly System.Windows.DependencyProperty SyncModeToOwningContainerProperty;
    public static readonly System.Windows.DependencyProperty TargetEditModeProperty;
    public EditModeSwitchButton() { }
    public bool SyncModeToOwningContainer { get { return default(bool); } set { } }
    public System.Activities.Presentation.PropertyEditing.PropertyContainerEditMode TargetEditMode { get { return default(System.Activities.Presentation.PropertyEditing.PropertyContainerEditMode); } set { } }
    protected override void OnMouseDown(System.Windows.Input.MouseButtonEventArgs e) { }
    protected override void OnPropertyChanged(System.Windows.DependencyPropertyChangedEventArgs e) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(128), AllowMultiple=true)]
  public sealed partial class EditorOptionAttribute : System.Attribute {
    public EditorOptionAttribute() { }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override object TypeId { get { return default(object); } }
    public object Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public static bool TryGetOptionValue(System.Collections.IEnumerable attributes, string optionName, out object optionValue) { optionValue = default(object); return default(bool); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(132))]
  public sealed partial class EditorReuseAttribute : System.Attribute {
    public EditorReuseAttribute(bool reuseEditor) { }
    public bool ReuseEditor { get { return default(bool); } }
  }
  public partial class ExtendedPropertyValueEditor : System.Activities.Presentation.PropertyEditing.PropertyValueEditor {
    public ExtendedPropertyValueEditor() { }
    public ExtendedPropertyValueEditor(System.Windows.DataTemplate extendedEditorTemplate, System.Windows.DataTemplate inlineEditorTemplate) { }
    public System.Windows.DataTemplate ExtendedEditorTemplate { get { return default(System.Windows.DataTemplate); } set { } }
  }
  public partial interface IPropertyFilterTarget {
    bool MatchesFilter { get; }
    event System.EventHandler<System.Activities.Presentation.PropertyEditing.PropertyFilterAppliedEventArgs> FilterApplied;
    void ApplyFilter(System.Activities.Presentation.PropertyEditing.PropertyFilter filter);
    bool MatchesPredicate(System.Activities.Presentation.PropertyEditing.PropertyFilterPredicate predicate);
  }
  public enum PropertyContainerEditMode {
    Dialog = 3,
    ExtendedPinned = 2,
    ExtendedPopup = 1,
    Inline = 0,
  }
  public abstract partial class PropertyEntry : System.Activities.Presentation.PropertyEditing.IPropertyFilterTarget, System.ComponentModel.INotifyPropertyChanged {
    protected PropertyEntry() { }
    protected PropertyEntry(System.Activities.Presentation.PropertyEditing.PropertyValue parentValue) { }
    public abstract string CategoryName { get; }
    public abstract string Description { get; }
    public virtual string DisplayName { get { return default(string); } }
    protected virtual bool HasStandardValues { get { return default(bool); } }
    public abstract bool IsAdvanced { get; }
    public abstract bool IsReadOnly { get; }
    public bool MatchesFilter { get { return default(bool); } protected set { } }
    public System.Activities.Presentation.PropertyEditing.PropertyValue ParentValue { get { return default(System.Activities.Presentation.PropertyEditing.PropertyValue); } }
    public abstract string PropertyName { get; }
    public abstract System.Type PropertyType { get; }
    public System.Activities.Presentation.PropertyEditing.PropertyValue PropertyValue { get { return default(System.Activities.Presentation.PropertyEditing.PropertyValue); } }
    public abstract System.Activities.Presentation.PropertyEditing.PropertyValueEditor PropertyValueEditor { get; }
    public abstract System.Collections.ICollection StandardValues { get; }
    public event System.EventHandler<System.Activities.Presentation.PropertyEditing.PropertyFilterAppliedEventArgs> FilterApplied { add { } remove { } }
    public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged { add { } remove { } }
    public virtual void ApplyFilter(System.Activities.Presentation.PropertyEditing.PropertyFilter filter) { }
    protected abstract System.Activities.Presentation.PropertyEditing.PropertyValue CreatePropertyValueInstance();
    public virtual bool MatchesPredicate(System.Activities.Presentation.PropertyEditing.PropertyFilterPredicate predicate) { return default(bool); }
    protected virtual void OnFilterApplied(System.Activities.Presentation.PropertyEditing.PropertyFilter filter) { }
    protected virtual void OnPropertyChanged(System.ComponentModel.PropertyChangedEventArgs e) { }
    protected virtual void OnPropertyChanged(string propertyName) { }
  }
  public abstract partial class PropertyEntryCollection : System.Collections.Generic.IEnumerable<System.Activities.Presentation.PropertyEditing.PropertyEntry>, System.Collections.IEnumerable {
    protected PropertyEntryCollection(System.Activities.Presentation.PropertyEditing.PropertyValue parentValue) { }
    public abstract int Count { get; }
    public abstract System.Activities.Presentation.PropertyEditing.PropertyEntry this[string propertyName] { get; }
    public System.Activities.Presentation.PropertyEditing.PropertyValue ParentValue { get { return default(System.Activities.Presentation.PropertyEditing.PropertyValue); } }
    public abstract System.Collections.Generic.IEnumerator<System.Activities.Presentation.PropertyEditing.PropertyEntry> GetEnumerator();
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public partial class PropertyFilter {
    public PropertyFilter(System.Collections.Generic.IEnumerable<System.Activities.Presentation.PropertyEditing.PropertyFilterPredicate> predicates) { }
    public PropertyFilter(string filterText) { }
    public bool IsEmpty { get { return default(bool); } }
    public bool Match(System.Activities.Presentation.PropertyEditing.IPropertyFilterTarget target) { return default(bool); }
  }
  public partial class PropertyFilterAppliedEventArgs : System.EventArgs {
    public PropertyFilterAppliedEventArgs(System.Activities.Presentation.PropertyEditing.PropertyFilter filter) { }
    public System.Activities.Presentation.PropertyEditing.PropertyFilter Filter { get { return default(System.Activities.Presentation.PropertyEditing.PropertyFilter); } }
  }
  public partial class PropertyFilterPredicate {
    public PropertyFilterPredicate(string matchText) { }
    protected string MatchText { get { return default(string); } }
    public virtual bool Match(string target) { return default(bool); }
  }
  public abstract partial class PropertyValue : System.ComponentModel.INotifyPropertyChanged {
    protected PropertyValue(System.Activities.Presentation.PropertyEditing.PropertyEntry parentProperty) { }
    public abstract bool CanConvertFromString { get; }
    protected virtual bool CatchExceptions { get { return default(bool); } }
    public abstract System.Activities.Presentation.PropertyEditing.PropertyValueCollection Collection { get; }
    public abstract bool HasSubProperties { get; }
    public abstract bool IsCollection { get; }
    public abstract bool IsDefaultValue { get; }
    public abstract bool IsMixedValue { get; }
    public System.Activities.Presentation.PropertyEditing.PropertyEntry ParentProperty { get { return default(System.Activities.Presentation.PropertyEditing.PropertyEntry); } }
    public abstract System.Activities.Presentation.PropertyEditing.PropertyValueSource Source { get; }
    public string StringValue { get { return default(string); } set { } }
    public abstract System.Activities.Presentation.PropertyEditing.PropertyEntryCollection SubProperties { get; }
    public object Value { get { return default(object); } set { } }
    public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged { add { } remove { } }
    public event System.EventHandler<System.Activities.Presentation.PropertyEditing.PropertyValueExceptionEventArgs> PropertyValueException { add { } remove { } }
    public event System.EventHandler RootValueChanged { add { } remove { } }
    public event System.EventHandler SubPropertyChanged { add { } remove { } }
    public abstract void ClearValue();
    protected abstract object ConvertStringToValue(string value);
    protected abstract string ConvertValueToString(object value);
    protected abstract object GetValueCore();
    protected virtual void NotifyRootValueChanged() { }
    protected void NotifySubPropertyChanged() { }
    protected virtual void OnPropertyChanged(System.ComponentModel.PropertyChangedEventArgs e) { }
    protected virtual void OnPropertyChanged(string propertyName) { }
    protected virtual void OnPropertyValueException(System.Activities.Presentation.PropertyEditing.PropertyValueExceptionEventArgs e) { }
    protected abstract void SetValueCore(object value);
    protected abstract void ValidateValue(object valueToValidate);
  }
  public abstract partial class PropertyValueCollection : System.Collections.Generic.IEnumerable<System.Activities.Presentation.PropertyEditing.PropertyValue>, System.Collections.IEnumerable, System.Collections.Specialized.INotifyCollectionChanged {
    protected PropertyValueCollection(System.Activities.Presentation.PropertyEditing.PropertyValue parentValue) { }
    public abstract int Count { get; }
    public abstract System.Activities.Presentation.PropertyEditing.PropertyValue this[int index] { get; }
    public System.Activities.Presentation.PropertyEditing.PropertyValue ParentValue { get { return default(System.Activities.Presentation.PropertyEditing.PropertyValue); } }
    public event System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged { add { } remove { } }
    public abstract System.Activities.Presentation.PropertyEditing.PropertyValue Add(object value);
    public abstract System.Collections.Generic.IEnumerator<System.Activities.Presentation.PropertyEditing.PropertyValue> GetEnumerator();
    public abstract System.Activities.Presentation.PropertyEditing.PropertyValue Insert(object value, int index);
    protected virtual void OnCollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventArgs e) { }
    public abstract bool Remove(System.Activities.Presentation.PropertyEditing.PropertyValue propertyValue);
    public abstract void RemoveAt(int index);
    public abstract void SetIndex(int currentIndex, int newIndex);
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public partial class PropertyValueEditor {
    public PropertyValueEditor() { }
    public PropertyValueEditor(System.Windows.DataTemplate inlineEditorTemplate) { }
    public System.Windows.DataTemplate InlineEditorTemplate { get { return default(System.Windows.DataTemplate); } set { } }
    public static System.ComponentModel.EditorAttribute CreateEditorAttribute(System.Activities.Presentation.PropertyEditing.PropertyValueEditor editor) { return default(System.ComponentModel.EditorAttribute); }
    public static System.ComponentModel.EditorAttribute CreateEditorAttribute(System.Type propertyValueEditorType) { return default(System.ComponentModel.EditorAttribute); }
  }
  public static partial class PropertyValueEditorCommands {
    public static System.Windows.Input.RoutedCommand AbortTransaction { get { return default(System.Windows.Input.RoutedCommand); } }
    public static System.Windows.Input.RoutedCommand BeginTransaction { get { return default(System.Windows.Input.RoutedCommand); } }
    public static System.Windows.Input.RoutedCommand CommitTransaction { get { return default(System.Windows.Input.RoutedCommand); } }
    public static System.Windows.Input.RoutedCommand FinishEditing { get { return default(System.Windows.Input.RoutedCommand); } }
    public static System.Windows.Input.RoutedCommand ShowDialogEditor { get { return default(System.Windows.Input.RoutedCommand); } }
    public static System.Windows.Input.RoutedCommand ShowExtendedPinnedEditor { get { return default(System.Windows.Input.RoutedCommand); } }
    public static System.Windows.Input.RoutedCommand ShowExtendedPopupEditor { get { return default(System.Windows.Input.RoutedCommand); } }
    public static System.Windows.Input.RoutedCommand ShowInlineEditor { get { return default(System.Windows.Input.RoutedCommand); } }
  }
  public partial class PropertyValueExceptionEventArgs : System.EventArgs {
    public PropertyValueExceptionEventArgs(string message, System.Activities.Presentation.PropertyEditing.PropertyValue value, System.Activities.Presentation.PropertyEditing.PropertyValueExceptionSource source, System.Exception exception) { }
    public System.Exception Exception { get { return default(System.Exception); } }
    public string Message { get { return default(string); } }
    public System.Activities.Presentation.PropertyEditing.PropertyValue PropertyValue { get { return default(System.Activities.Presentation.PropertyEditing.PropertyValue); } }
    public System.Activities.Presentation.PropertyEditing.PropertyValueExceptionSource Source { get { return default(System.Activities.Presentation.PropertyEditing.PropertyValueExceptionSource); } }
  }
  public enum PropertyValueExceptionSource {
    Get = 0,
    Set = 1,
  }
  public abstract partial class PropertyValueSource {
    protected PropertyValueSource() { }
  }
}
namespace System.Activities.Presentation.Services {
  public abstract partial class ModelChangedEventArgs : System.EventArgs {
    protected ModelChangedEventArgs() { }
    [System.ObsoleteAttribute("Don't use this property. Use \"ModelChangeInfo\" instead.")]
    public abstract System.Collections.Generic.IEnumerable<System.Activities.Presentation.Model.ModelItem> ItemsAdded { get; }
    [System.ObsoleteAttribute("Don't use this property. Use \"ModelChangeInfo\" instead.")]
    public abstract System.Collections.Generic.IEnumerable<System.Activities.Presentation.Model.ModelItem> ItemsRemoved { get; }
    public virtual System.Activities.Presentation.Services.ModelChangeInfo ModelChangeInfo { get { return default(System.Activities.Presentation.Services.ModelChangeInfo); } }
    [System.ObsoleteAttribute("Don't use this property. Use \"ModelChangeInfo\" instead.")]
    public abstract System.Collections.Generic.IEnumerable<System.Activities.Presentation.Model.ModelProperty> PropertiesChanged { get; }
  }
  public abstract partial class ModelChangeInfo {
    protected ModelChangeInfo() { }
    public abstract System.Activities.Presentation.Model.ModelItem Key { get; }
    public abstract System.Activities.Presentation.Services.ModelChangeType ModelChangeType { get; }
    public abstract System.Activities.Presentation.Model.ModelItem OldValue { get; }
    public abstract string PropertyName { get; }
    public abstract System.Activities.Presentation.Model.ModelItem Subject { get; }
    public abstract System.Activities.Presentation.Model.ModelItem Value { get; }
  }
  public enum ModelChangeType {
    CollectionItemAdded = 2,
    CollectionItemRemoved = 3,
    DictionaryKeyValueAdded = 4,
    DictionaryKeyValueRemoved = 5,
    DictionaryValueChanged = 6,
    None = 0,
    PropertyChanged = 1,
  }
  public abstract partial class ModelSearchService {
    protected ModelSearchService() { }
    public abstract System.Activities.Presentation.Model.TextImage GenerateTextImage();
    public abstract bool NavigateTo(int location);
    public abstract bool NavigateTo(int startLine, int startColumn, int endLine, int endColumn);
  }
  public abstract partial class ModelService {
    protected ModelService() { }
    public abstract System.Activities.Presentation.Model.ModelItem Root { get; }
    public abstract event System.EventHandler<System.Activities.Presentation.Services.ModelChangedEventArgs> ModelChanged;
    protected abstract System.Activities.Presentation.Model.ModelItem CreateItem(object item);
    protected abstract System.Activities.Presentation.Model.ModelItem CreateItem(System.Type itemType, System.Activities.Presentation.Model.CreateOptions options, params System.Object[] arguments);
    protected abstract System.Activities.Presentation.Model.ModelItem CreateStaticMemberItem(System.Type type, string memberName);
    public abstract System.Collections.Generic.IEnumerable<System.Activities.Presentation.Model.ModelItem> Find(System.Activities.Presentation.Model.ModelItem startingItem, System.Predicate<System.Type> match);
    public abstract System.Collections.Generic.IEnumerable<System.Activities.Presentation.Model.ModelItem> Find(System.Activities.Presentation.Model.ModelItem startingItem, System.Type type);
    public System.Activities.Presentation.Model.ModelItem FromName(System.Activities.Presentation.Model.ModelItem scope, string name) { return default(System.Activities.Presentation.Model.ModelItem); }
    public abstract System.Activities.Presentation.Model.ModelItem FromName(System.Activities.Presentation.Model.ModelItem scope, string name, System.StringComparison comparison);
  }
  public abstract partial class ViewService {
    protected ViewService() { }
    public abstract System.Activities.Presentation.Model.ModelItem GetModel(System.Windows.DependencyObject view);
    public abstract System.Windows.DependencyObject GetView(System.Activities.Presentation.Model.ModelItem model);
  }
}
namespace System.Activities.Presentation.Sqm {
  public partial interface IVSSqmService {
    void AddArrayToStream(int dataPointId, System.UInt32[] data, int count);
    void AddItemToStream(int dataPointId, uint value);
    void SetDatapoint(int dataPointId, uint value);
  }
}
namespace System.Activities.Presentation.Toolbox {
  [System.Windows.Markup.ContentPropertyAttribute("Implementation")]
  public abstract partial class ActivityTemplateFactory : System.Activities.Presentation.IActivityTemplateFactory {
    protected ActivityTemplateFactory() { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Windows.Markup.AmbientAttribute]
    [System.Windows.Markup.XamlDeferLoadAttribute(typeof(System.Activities.XamlIntegration.FuncDeferringLoader), typeof(System.Activities.Presentation.Toolbox.ActivityTemplateFactory))]
    protected virtual System.Func<System.Activities.Activity> Implementation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Func<System.Activities.Activity>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Activities.Activity Create(System.Windows.DependencyObject target) { return default(System.Activities.Activity); }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Implementation")]
  public abstract partial class ActivityTemplateFactory<T> : System.Activities.Presentation.IActivityTemplateFactory<T> where T : class {
    protected ActivityTemplateFactory() { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Windows.Markup.AmbientAttribute]
    [System.Windows.Markup.XamlDeferLoadAttribute(typeof(System.Activities.XamlIntegration.FuncDeferringLoader), typeof(System.Activities.Presentation.Toolbox.ActivityTemplateFactory))]
    protected virtual System.Func<T> Implementation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Func<T>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public T Create(System.Windows.DependencyObject target, System.Windows.IDataObject dataObject) { return default(T); }
  }
  [System.ComponentModel.DesignerAttribute(typeof(System.Activities.Presentation.View.ActivityTypeDesigner))]
  [System.Windows.Markup.ContentPropertyAttribute("Implementation")]
  public sealed partial class ActivityTemplateFactoryBuilder {
    public ActivityTemplateFactoryBuilder() { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Windows.Markup.DependsOnAttribute("TargetType")]
    public object Implementation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Windows.Markup.DependsOnAttribute("Name")]
    public System.Type TargetType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public sealed partial class ToolboxCategory : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.ComponentModel.INotifyPropertyChanged {
    public ToolboxCategory() { }
    public ToolboxCategory(string name) { }
    public string CategoryName { get { return default(string); } set { } }
    public System.Activities.Presentation.Toolbox.ToolboxItemWrapper this[int index] { get { return default(System.Activities.Presentation.Toolbox.ToolboxItemWrapper); } }
    int System.Collections.ICollection.Count { get { return default(int); } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    bool System.Collections.IList.IsFixedSize { get { return default(bool); } }
    bool System.Collections.IList.IsReadOnly { get { return default(bool); } }
    object System.Collections.IList.this[int index] { get { return default(object); } set { } }
    public System.Collections.Generic.ICollection<System.Activities.Presentation.Toolbox.ToolboxItemWrapper> Tools { get { return default(System.Collections.Generic.ICollection<System.Activities.Presentation.Toolbox.ToolboxItemWrapper>); } }
    public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged { add { } remove { } }
    public void Add(System.Activities.Presentation.Toolbox.ToolboxItemWrapper tool) { }
    public bool Remove(System.Activities.Presentation.Toolbox.ToolboxItemWrapper tool) { return default(bool); }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    int System.Collections.IList.Add(object value) { return default(int); }
    void System.Collections.IList.Clear() { }
    bool System.Collections.IList.Contains(object value) { return default(bool); }
    int System.Collections.IList.IndexOf(object value) { return default(int); }
    void System.Collections.IList.Insert(int index, object value) { }
    void System.Collections.IList.Remove(object value) { }
    void System.Collections.IList.RemoveAt(int index) { }
  }
  public sealed partial class ToolboxCategoryItems : System.Collections.Generic.ICollection<System.Activities.Presentation.Toolbox.ToolboxCategory>, System.Collections.Generic.IEnumerable<System.Activities.Presentation.Toolbox.ToolboxCategory>, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList {
    public ToolboxCategoryItems() { }
    public int Count { get { return default(int); } }
    public bool IsReadOnly { get { return default(bool); } }
    public System.Activities.Presentation.Toolbox.ToolboxCategory this[int index] { get { return default(System.Activities.Presentation.Toolbox.ToolboxCategory); } }
    int System.Collections.ICollection.Count { get { return default(int); } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    bool System.Collections.IList.IsFixedSize { get { return default(bool); } }
    bool System.Collections.IList.IsReadOnly { get { return default(bool); } }
    object System.Collections.IList.this[int index] { get { return default(object); } set { } }
    public void Add(System.Activities.Presentation.Toolbox.ToolboxCategory item) { }
    public void Clear() { }
    public bool Contains(System.Activities.Presentation.Toolbox.ToolboxCategory item) { return default(bool); }
    public void CopyTo(System.Activities.Presentation.Toolbox.ToolboxCategory[] array, int arrayIndex) { }
    public System.Collections.Generic.IEnumerator<System.Activities.Presentation.Toolbox.ToolboxCategory> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Activities.Presentation.Toolbox.ToolboxCategory>); }
    public bool Remove(System.Activities.Presentation.Toolbox.ToolboxCategory item) { return default(bool); }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    int System.Collections.IList.Add(object value) { return default(int); }
    void System.Collections.IList.Clear() { }
    bool System.Collections.IList.Contains(object value) { return default(bool); }
    int System.Collections.IList.IndexOf(object value) { return default(int); }
    void System.Collections.IList.Insert(int index, object value) { }
    void System.Collections.IList.Remove(object value) { }
    void System.Collections.IList.RemoveAt(int index) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Categories")]
  [System.Windows.TemplatePartAttribute(Name="PART_SearchBox")]
  [System.Windows.TemplatePartAttribute(Name="PART_Tools")]
  public sealed partial class ToolboxControl : System.Windows.Controls.Control {
    public static readonly System.Windows.DependencyProperty CategoryItemStyleProperty;
    public static readonly System.Windows.DependencyProperty CategoryTemplateProperty;
    public static readonly System.Windows.DependencyProperty SelectedToolProperty;
    public static readonly System.Windows.DependencyProperty ToolboxFileProperty;
    public static readonly System.Windows.RoutedEvent ToolCreatedEvent;
    public static readonly System.Windows.DependencyProperty ToolItemStyleProperty;
    public static readonly System.Windows.RoutedEvent ToolSelectedEvent;
    public static readonly System.Windows.DependencyProperty ToolTemplateProperty;
    public ToolboxControl() { }
    public System.Activities.Presentation.WorkflowDesigner AssociatedDesigner { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Activities.Presentation.WorkflowDesigner); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    public System.Activities.Presentation.Toolbox.ToolboxCategoryItems Categories { get { return default(System.Activities.Presentation.Toolbox.ToolboxCategoryItems); } set { } }
    public System.Windows.Style CategoryItemStyle { get { return default(System.Windows.Style); } set { } }
    public System.Windows.DataTemplate CategoryTemplate { get { return default(System.Windows.DataTemplate); } set { } }
    public System.Drawing.Design.ToolboxItem SelectedTool { get { return default(System.Drawing.Design.ToolboxItem); } }
    public string ToolboxFile { get { return default(string); } set { } }
    public System.Windows.Style ToolItemStyle { get { return default(System.Windows.Style); } set { } }
    public System.Windows.DataTemplate ToolTemplate { get { return default(System.Windows.DataTemplate); } set { } }
    public event System.Activities.Presentation.Toolbox.ToolCreatedEventHandler ToolCreated { add { } remove { } }
    public event System.Windows.RoutedEventHandler ToolSelected { add { } remove { } }
    public override void OnApplyTemplate() { }
    protected override void OnPreviewKeyDown(System.Windows.Input.KeyEventArgs e) { }
  }
  public sealed partial class ToolboxItemWrapper : System.ComponentModel.INotifyPropertyChanged {
    public ToolboxItemWrapper() { }
    public ToolboxItemWrapper(string toolName, string assemblyName, string bitmapName, string displayName) { }
    public ToolboxItemWrapper(System.Type toolType) { }
    public ToolboxItemWrapper(System.Type toolType, string displayName) { }
    public ToolboxItemWrapper(System.Type toolType, string bitmapName, string displayName) { }
    public string AssemblyName { get { return default(string); } set { } }
    public System.Drawing.Bitmap Bitmap { get { return default(System.Drawing.Bitmap); } }
    public string BitmapName { get { return default(string); } set { } }
    public string DisplayName { get { return default(string); } set { } }
    public bool IsValid { get { return default(bool); } }
    public string ToolName { get { return default(string); } set { } }
    public System.Type Type { get { return default(System.Type); } }
    public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged { add { } remove { } }
    public override string ToString() { return default(string); }
  }
  public sealed partial class ToolCreatedEventArgs : System.Windows.RoutedEventArgs {
    internal ToolCreatedEventArgs() { }
    public System.ComponentModel.IComponent[] Components { get { return default(System.ComponentModel.IComponent[]); } }
  }
  public delegate void ToolCreatedEventHandler(object sender, System.Activities.Presentation.Toolbox.ToolCreatedEventArgs e);
}
namespace System.Activities.Presentation.Validation {
  public partial interface IValidationErrorService {
    void ShowValidationErrors(System.Collections.Generic.IList<System.Activities.Presentation.Validation.ValidationErrorInfo> errors);
  }
  public partial class ValidationErrorInfo {
    public ValidationErrorInfo(System.Activities.Validation.ValidationError validationError) { }
    public ValidationErrorInfo(string message) { }
    public string FileName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Id { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public bool IsWarning { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    public string Message { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string PropertyName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public System.Guid SourceReferenceId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Guid); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial class ValidationService {
    public ValidationService(System.Activities.Presentation.EditingContext context) { }
    public System.Activities.Validation.ValidationSettings Settings { get { return default(System.Activities.Validation.ValidationSettings); } }
    public void NavigateToError(System.Activities.Presentation.Validation.ValidationErrorInfo validationErrorInfo) { }
    public void NavigateToError(string id) { }
    protected virtual void OnValidationCompleted() { }
    public void ValidateWorkflow() { }
  }
  public enum ValidationState {
    ChildInvalid = 1,
    Error = 3,
    Valid = 0,
    Warning = 2,
  }
}
namespace System.Activities.Presentation.View {
  public sealed partial class CommandMenuMode {
    internal CommandMenuMode() { }
    public static readonly System.Activities.Presentation.View.CommandMenuMode FullCommandMenu;
    public static readonly System.Activities.Presentation.View.CommandMenuMode NoCommandMenu;
  }
  public partial class DesignerView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
    internal DesignerView() { }
    public static readonly System.Windows.DependencyProperty ActivitySchemaProperty;
    public static readonly System.Windows.Input.ICommand AddAnnotationCommand;
    public static readonly System.Windows.Input.ICommand CollapseAllCommand;
    public static readonly System.Windows.Input.ICommand CollapseCommand;
    public static readonly System.Windows.DependencyProperty CommandMenuModeProperty;
    public static readonly System.Windows.Input.ICommand CommitCommand;
    public static readonly System.Windows.Input.ICommand CopyAsImageCommand;
    public static readonly System.Windows.Input.ICommand CopyCommand;
    public static readonly System.Windows.Input.ICommand CreateArgumentCommand;
    public static readonly System.Windows.Input.ICommand CreateVariableCommand;
    public static readonly System.Windows.Input.ICommand CreateWorkflowElementCommand;
    public const string CustomMenuItemsSeparatorCommand = "6F455692-EA19-4ac9-ABEE-57F6DF20A687";
    public static readonly System.Windows.Input.ICommand CutCommand;
    public static readonly System.Windows.Input.ICommand CycleThroughDesignerCommand;
    public static readonly System.Windows.Input.ICommand DeleteAllAnnotationCommand;
    public static readonly System.Windows.Input.ICommand DeleteAnnotationCommand;
    public static readonly System.Windows.Input.ICommand DeleteBreakpointCommand;
    public static readonly System.Windows.Input.ICommand DisableBreakpointCommand;
    public static readonly System.Windows.Input.ICommand EditAnnotationCommand;
    public static readonly System.Windows.Input.ICommand EnableBreakpointCommand;
    public static readonly System.Windows.Input.ICommand ExpandAllCommand;
    public static readonly System.Windows.Input.ICommand ExpandCommand;
    public static readonly System.Windows.Input.ICommand ExpandInPlaceCommand;
    public static readonly System.Windows.Input.ICommand FitToScreenCommand;
    public static readonly System.Windows.DependencyProperty FocusedViewElementProperty;
    public static readonly System.Windows.Input.ICommand GoToParentCommand;
    public static readonly System.Windows.Input.ICommand HideAllAnnotationCommand;
    public static readonly System.Windows.DependencyProperty InPanModeProperty;
    public static readonly System.Windows.Input.ICommand InsertBreakpointCommand;
    public static readonly System.Windows.DependencyProperty IsReadOnlyProperty;
    public static readonly System.Windows.DependencyProperty MenuItemStyleProperty;
    public static readonly System.Windows.DependencyProperty MenuSeparatorStyleProperty;
    public static readonly System.Windows.Input.ICommand MoveFocusCommand;
    public static readonly System.Windows.Input.ICommand PasteCommand;
    public static readonly System.Windows.Input.ICommand RedoCommand;
    public static readonly System.Windows.Input.ICommand ResetZoomCommand;
    public static readonly System.Windows.Input.ICommand RestoreCommand;
    public static readonly System.Windows.DependencyProperty RootDesignerProperty;
    public static readonly System.Windows.Input.ICommand SaveAsImageCommand;
    public static readonly System.Windows.Input.ICommand SelectAllCommand;
    public static readonly System.Windows.Input.ICommand ShowAllAnnotationCommand;
    public static readonly System.Windows.Input.ICommand ToggleArgumentDesignerCommand;
    public static readonly System.Windows.Input.ICommand ToggleImportsDesignerCommand;
    public static readonly System.Windows.Input.ICommand ToggleMiniMapCommand;
    public static readonly System.Windows.Input.ICommand ToggleSelectionCommand;
    public static readonly System.Windows.Input.ICommand ToggleVariableDesignerCommand;
    public static readonly System.Windows.Input.ICommand UndoCommand;
    public static readonly System.Windows.Input.ICommand ZoomInCommand;
    public static readonly System.Windows.Input.ICommand ZoomOutCommand;
    public System.Activities.Presentation.Model.ModelItem ActivitySchema { get { return default(System.Activities.Presentation.Model.ModelItem); } }
    public System.Activities.Presentation.EditingContext Context { get { return default(System.Activities.Presentation.EditingContext); } }
    public System.Activities.Presentation.WorkflowViewElement FocusedViewElement { get { return default(System.Activities.Presentation.WorkflowViewElement); } }
    public bool IsMultipleSelectionMode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    public bool IsReadOnly { get { return default(bool); } set { } }
    public System.Windows.Style MenuItemStyle { get { return default(System.Windows.Style); } set { } }
    public System.Windows.Style MenuSeparatorStyle { get { return default(System.Windows.Style); } set { } }
    public System.Windows.UIElement RootDesigner { get { return default(System.Windows.UIElement); } set { } }
    public bool ShouldCollapseAll { get { return default(bool); } set { } }
    public bool ShouldExpandAll { get { return default(bool); } set { } }
    public System.Activities.Presentation.View.ShellBarItemVisibility WorkflowShellBarItemVisibility { get { return default(System.Activities.Presentation.View.ShellBarItemVisibility); } set { } }
    public System.Activities.Presentation.View.ShellHeaderItemsVisibility WorkflowShellHeaderItemsVisibility { get { return default(System.Activities.Presentation.View.ShellHeaderItemsVisibility); } set { } }
    public double ZoomFactor { get { return default(double); } }
    public void FlushState() { }
    public static System.Activities.Presentation.View.CommandMenuMode GetCommandMenuMode(System.Windows.DependencyObject obj) { return default(System.Activities.Presentation.View.CommandMenuMode); }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void InitializeComponent() { }
    public void MakeRootDesigner(System.Activities.Presentation.Model.ModelItem modelItem) { }
    protected override void OnContextMenuOpening(System.Windows.Controls.ContextMenuEventArgs e) { }
    protected override void OnInitialized(System.EventArgs e) { }
    protected override void OnKeyDown(System.Windows.Input.KeyEventArgs e) { }
    protected override void OnPreviewDragOver(System.Windows.DragEventArgs e) { }
    protected override void OnPreviewMouseLeftButtonDown(System.Windows.Input.MouseButtonEventArgs e) { }
    protected override void OnPreviewMouseWheel(System.Windows.Input.MouseWheelEventArgs e) { }
    public void OnReferenceUpdated(System.Reflection.AssemblyName updatedReference, bool isAdded) { }
    public void RegisterViewElement(System.Activities.Presentation.WorkflowViewElement viewElement) { }
    public static void SetCommandMenuMode(System.Windows.DependencyObject obj, System.Activities.Presentation.View.CommandMenuMode value) { }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Diagnostics.DebuggerNonUserCodeAttribute]
    void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) { }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Diagnostics.DebuggerNonUserCodeAttribute]
    void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) { }
    public void UnregisterViewElement(System.Activities.Presentation.WorkflowViewElement viewElement) { }
  }
  public enum EditingState {
    Editing = 0,
    Idle = 2,
    Validating = 1,
  }
  public sealed partial class ExpressionTextBox : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
    public static readonly System.Windows.DependencyProperty AcceptsReturnProperty;
    public static readonly System.Windows.DependencyProperty AcceptsTabProperty;
    public static readonly System.Windows.Input.ICommand CompleteWordCommand;
    public static readonly System.Windows.Input.ICommand DecreaseFilterLevelCommand;
    public static readonly System.Windows.DependencyProperty DefaultValueProperty;
    public static readonly System.Windows.RoutedEvent EditorLostLogicalFocusEvent;
    public static readonly System.Windows.DependencyProperty ExplicitCommitProperty;
    public const string ExpressionActivityEditorOptionName = "ExpressionActivityEditorName";
    public static readonly System.Windows.DependencyProperty ExpressionActivityEditorProperty;
    public static readonly System.Windows.DependencyProperty ExpressionProperty;
    public static readonly System.Windows.DependencyProperty ExpressionTypeProperty;
    public static readonly System.Windows.Input.ICommand GlobalIntellisenseCommand;
    public static readonly System.Windows.DependencyProperty HintTextProperty;
    public static readonly System.Windows.DependencyProperty HorizontalScrollBarVisibilityProperty;
    public static readonly System.Windows.Input.ICommand IncreaseFilterLevelCommand;
    public static readonly System.Windows.DependencyProperty IsReadOnlyProperty;
    public static readonly System.Windows.DependencyProperty IsSupportedExpressionProperty;
    public static readonly System.Windows.DependencyProperty MaxLinesProperty;
    public static readonly System.Windows.DependencyProperty MinLinesProperty;
    public static readonly System.Windows.DependencyProperty OwnerActivityProperty;
    public static readonly System.Windows.Input.ICommand ParameterInfoCommand;
    public static readonly System.Windows.DependencyProperty PathToArgumentProperty;
    public static readonly System.Windows.Input.ICommand QuickInfoCommand;
    public static readonly System.Windows.DependencyProperty UseLocationExpressionProperty;
    public static readonly System.Windows.DependencyProperty VerticalScrollBarVisibilityProperty;
    public ExpressionTextBox() { }
    public bool AcceptsReturn { get { return default(bool); } set { } }
    public bool AcceptsTab { get { return default(bool); } set { } }
    public string DefaultValue { get { return default(string); } set { } }
    public bool ExplicitCommit { get { return default(bool); } set { } }
    public System.Activities.Presentation.Model.ModelItem Expression { get { return default(System.Activities.Presentation.Model.ModelItem); } set { } }
    public string ExpressionActivityEditor { get { return default(string); } set { } }
    public System.Activities.Presentation.View.IExpressionEditorService ExpressionEditorService { [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline this type of method across NGen image boundaries")]get { return default(System.Activities.Presentation.View.IExpressionEditorService); } }
    public System.Type ExpressionType { get { return default(System.Type); } set { } }
    public string HintText { get { return default(string); } set { } }
    public System.Windows.Controls.ScrollBarVisibility HorizontalScrollBarVisibility { get { return default(System.Windows.Controls.ScrollBarVisibility); } set { } }
    public bool IsReadOnly { get { return default(bool); } set { } }
    public bool IsSupportedExpression { get { return default(bool); } set { } }
    public int MaxLines { get { return default(int); } set { } }
    public int MinLines { get { return default(int); } set { } }
    public System.Activities.Presentation.Model.ModelItem OwnerActivity { get { return default(System.Activities.Presentation.Model.ModelItem); } set { } }
    public string PathToArgument { get { return default(string); } set { } }
    public bool UseLocationExpression { get { return default(bool); } set { } }
    public System.Windows.Controls.ScrollBarVisibility VerticalScrollBarVisibility { get { return default(System.Windows.Controls.ScrollBarVisibility); } set { } }
    public event System.Windows.RoutedEventHandler EditorLostLogicalFocus { add { } remove { } }
    public void BeginEdit() { }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void InitializeComponent() { }
    protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { return default(System.Windows.Automation.Peers.AutomationPeer); }
    protected override void OnInitialized(System.EventArgs e) { }
    protected override void OnPropertyChanged(System.Windows.DependencyPropertyChangedEventArgs e) { }
    public static void RegisterExpressionActivityEditor(string name, System.Type expressionActivityEditorType, System.Activities.Presentation.Expressions.CreateExpressionFromStringCallback convertFromString) { }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Diagnostics.DebuggerNonUserCodeAttribute]
    void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) { }
  }
  public partial interface IExpressionEditorInstance {
    bool AcceptsReturn { get; set; }
    bool AcceptsTab { get; set; }
    bool HasAggregateFocus { get; }
    System.Windows.Controls.ScrollBarVisibility HorizontalScrollBarVisibility { get; set; }
    System.Windows.Controls.Control HostControl { get; }
    int MaxLines { get; set; }
    int MinLines { get; set; }
    string Text { get; set; }
    System.Windows.Controls.ScrollBarVisibility VerticalScrollBarVisibility { get; set; }
    event System.EventHandler Closing;
    event System.EventHandler GotAggregateFocus;
    event System.EventHandler LostAggregateFocus;
    event System.EventHandler TextChanged;
    bool CanCompleteWord();
    bool CanCopy();
    bool CanCut();
    bool CanDecreaseFilterLevel();
    bool CanGlobalIntellisense();
    bool CanIncreaseFilterLevel();
    bool CanParameterInfo();
    bool CanPaste();
    bool CanQuickInfo();
    bool CanRedo();
    bool CanUndo();
    void ClearSelection();
    void Close();
    bool CompleteWord();
    bool Copy();
    bool Cut();
    bool DecreaseFilterLevel();
    void Focus();
    string GetCommittedText();
    bool GlobalIntellisense();
    bool IncreaseFilterLevel();
    bool ParameterInfo();
    bool Paste();
    bool QuickInfo();
    bool Redo();
    bool Undo();
  }
  public partial interface IExpressionEditorService {
    void CloseExpressionEditors();
    System.Activities.Presentation.View.IExpressionEditorInstance CreateExpressionEditor(System.Activities.Presentation.Hosting.AssemblyContextControlItem assemblies, System.Activities.Presentation.Hosting.ImportedNamespaceContextItem importedNamespaces, System.Collections.Generic.List<System.Activities.Presentation.Model.ModelItem> variables, string text);
    System.Activities.Presentation.View.IExpressionEditorInstance CreateExpressionEditor(System.Activities.Presentation.Hosting.AssemblyContextControlItem assemblies, System.Activities.Presentation.Hosting.ImportedNamespaceContextItem importedNamespaces, System.Collections.Generic.List<System.Activities.Presentation.Model.ModelItem> variables, string text, System.Type expressionType);
    System.Activities.Presentation.View.IExpressionEditorInstance CreateExpressionEditor(System.Activities.Presentation.Hosting.AssemblyContextControlItem assemblies, System.Activities.Presentation.Hosting.ImportedNamespaceContextItem importedNamespaces, System.Collections.Generic.List<System.Activities.Presentation.Model.ModelItem> variables, string text, System.Type expressionType, System.Windows.Size initialSize);
    System.Activities.Presentation.View.IExpressionEditorInstance CreateExpressionEditor(System.Activities.Presentation.Hosting.AssemblyContextControlItem assemblies, System.Activities.Presentation.Hosting.ImportedNamespaceContextItem importedNamespaces, System.Collections.Generic.List<System.Activities.Presentation.Model.ModelItem> variables, string text, System.Windows.Size initialSize);
    void UpdateContext(System.Activities.Presentation.Hosting.AssemblyContextControlItem assemblies, System.Activities.Presentation.Hosting.ImportedNamespaceContextItem importedNamespaces);
  }
  public enum PropertyKind {
    InArgument = 0,
    InOutArgument = 1,
    OutArgument = 2,
    Property = 3,
  }
  public partial class Selection : System.Activities.Presentation.ContextItem {
    public Selection() { }
    public Selection(params System.Activities.Presentation.Model.ModelItem[] selectedObjects) { }
    public Selection(System.Collections.Generic.IEnumerable<System.Activities.Presentation.Model.ModelItem> selectedObjects) { }
    public Selection(System.Collections.Generic.IEnumerable<System.Activities.Presentation.Model.ModelItem> selectedObjects, System.Predicate<System.Activities.Presentation.Model.ModelItem> match) { }
    public Selection(System.Collections.IEnumerable selectedObjects) { }
    public Selection(System.Collections.IEnumerable selectedObjects, System.Predicate<System.Activities.Presentation.Model.ModelItem> match) { }
    public sealed override System.Type ItemType { get { return default(System.Type); } }
    public System.Activities.Presentation.Model.ModelItem PrimarySelection { get { return default(System.Activities.Presentation.Model.ModelItem); } }
    public System.Collections.Generic.IEnumerable<System.Activities.Presentation.Model.ModelItem> SelectedObjects { get { return default(System.Collections.Generic.IEnumerable<System.Activities.Presentation.Model.ModelItem>); } }
    public int SelectionCount { get { return default(int); } }
    public static System.Activities.Presentation.View.Selection Select(System.Activities.Presentation.EditingContext context, System.Activities.Presentation.Model.ModelItem itemToSelect) { return default(System.Activities.Presentation.View.Selection); }
    public static System.Activities.Presentation.View.Selection SelectOnly(System.Activities.Presentation.EditingContext context, System.Activities.Presentation.Model.ModelItem itemToSelect) { return default(System.Activities.Presentation.View.Selection); }
    public static void Subscribe(System.Activities.Presentation.EditingContext context, System.Activities.Presentation.SubscribeContextCallback<System.Activities.Presentation.View.Selection> handler) { }
    public static System.Activities.Presentation.View.Selection Toggle(System.Activities.Presentation.EditingContext context, System.Activities.Presentation.Model.ModelItem itemToToggle) { return default(System.Activities.Presentation.View.Selection); }
    public static System.Activities.Presentation.View.Selection Union(System.Activities.Presentation.EditingContext context, System.Activities.Presentation.Model.ModelItem itemToAdd) { return default(System.Activities.Presentation.View.Selection); }
    public static void Unsubscribe(System.Activities.Presentation.EditingContext context, System.Activities.Presentation.SubscribeContextCallback<System.Activities.Presentation.View.Selection> handler) { }
  }
  [System.FlagsAttribute]
  public enum ShellBarItemVisibility {
    All = -1,
    Arguments = 2,
    Imports = 4,
    MiniMap = 16,
    None = 0,
    PanMode = 32,
    Variables = 1,
    Zoom = 8,
  }
  [System.FlagsAttribute]
  public enum ShellHeaderItemsVisibility {
    All = -1,
    Breadcrumb = 1,
    CollapseAll = 4,
    ExpandAll = 2,
    None = 0,
  }
  public sealed partial class TypePresenter : System.Windows.Controls.ContentControl, System.ComponentModel.INotifyPropertyChanged, System.Windows.Markup.IComponentConnector {
    public static readonly System.Windows.DependencyProperty AllowNullProperty;
    public static readonly System.Windows.DependencyProperty BrowseTypeDirectlyProperty;
    public static readonly System.Windows.DependencyProperty CenterActivityTypeResolverDialogProperty;
    public static readonly System.Windows.DependencyProperty CenterTypeBrowserDialogProperty;
    public static readonly System.Windows.DependencyProperty ContextProperty;
    public static readonly System.Windows.DependencyProperty FilterProperty;
    public static readonly System.Windows.DependencyProperty LabelProperty;
    public static readonly System.Windows.DependencyProperty MostRecentlyUsedTypesProperty;
    public static readonly System.Windows.DependencyProperty TextProperty;
    public static readonly System.Windows.RoutedEvent TypeBrowserClosedEvent;
    public static readonly System.Windows.RoutedEvent TypeBrowserOpenedEvent;
    public static readonly System.Windows.RoutedEvent TypeChangedEvent;
    public static readonly System.Windows.DependencyProperty TypeProperty;
    public TypePresenter() { }
    public bool AllowNull { get { return default(bool); } set { } }
    public bool BrowseTypeDirectly { get { return default(bool); } set { } }
    public bool CenterActivityTypeResolverDialog { get { return default(bool); } set { } }
    public bool CenterTypeBrowserDialog { get { return default(bool); } set { } }
    public System.Activities.Presentation.EditingContext Context { get { return default(System.Activities.Presentation.EditingContext); } set { } }
    public static System.Collections.ObjectModel.ObservableCollection<System.Type> DefaultMostRecentlyUsedTypes { get { return default(System.Collections.ObjectModel.ObservableCollection<System.Type>); } }
    public System.Func<System.Type, System.Boolean> Filter { get { return default(System.Func<System.Type, System.Boolean>); } set { } }
    public System.Collections.Generic.IEnumerable<System.Activities.Presentation.View.TypeWrapper> Items { [System.Runtime.CompilerServices.IteratorStateMachineAttribute(typeof(System.Activities.Presentation.View.TypePresenter.<get_Items>d__69))]get { return default(System.Collections.Generic.IEnumerable<System.Activities.Presentation.View.TypeWrapper>); } }
    public string Label { get { return default(string); } set { } }
    public System.Collections.ObjectModel.ObservableCollection<System.Type> MostRecentlyUsedTypes { get { return default(System.Collections.ObjectModel.ObservableCollection<System.Type>); } set { } }
    public string Text { get { return default(string); } }
    public System.Type Type { get { return default(System.Type); } set { } }
    public string TypeName { get { return default(string); } }
    public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged { add { } remove { } }
    public event System.Windows.RoutedEventHandler TypeBrowserClosed { add { } remove { } }
    public event System.Windows.RoutedEventHandler TypeBrowserOpened { add { } remove { } }
    public event System.Windows.RoutedEventHandler TypeChanged { add { } remove { } }
    public void FocusOnVisibleControl() { }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void InitializeComponent() { }
    protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { return default(System.Windows.Automation.Peers.AutomationPeer); }
    protected override void OnMouseLeftButtonDown(System.Windows.Input.MouseButtonEventArgs e) { }
    protected override void OnMouseLeftButtonUp(System.Windows.Input.MouseButtonEventArgs e) { }
    protected override void OnPreviewKeyDown(System.Windows.Input.KeyEventArgs e) { }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Diagnostics.DebuggerNonUserCodeAttribute]
    void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) { }
  }
  public partial class TypeResolvingOptions {
    public TypeResolvingOptions() { }
    public TypeResolvingOptions(System.Collections.Generic.IEnumerable<System.Type> defaultTypes) { }
    public bool BrowseTypeDirectly { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Func<System.Type, System.Boolean> Filter { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Func<System.Type, System.Boolean>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public sealed partial class TypeWrapper {
    internal TypeWrapper() { }
    public string DisplayName { get { return default(string); } }
    public bool IsTypeDefinition { get { return default(bool); } }
    public object Tag { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } }
    public System.Type Type { get { return default(System.Type); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
  }
  public partial class ViewCreatedEventArgs : System.EventArgs {
    public ViewCreatedEventArgs(System.Activities.Presentation.WorkflowViewElement view) { }
    public System.Activities.Presentation.WorkflowViewElement View { get { return default(System.Activities.Presentation.WorkflowViewElement); } }
  }
  public partial class ViewStateChangedEventArgs : System.EventArgs {
    public ViewStateChangedEventArgs(System.Activities.Presentation.Model.ModelItem modelItem, string key, object newValue, object oldValue) { }
    public string Key { get { return default(string); } }
    public object NewValue { get { return default(object); } }
    public object OldValue { get { return default(object); } }
    public System.Activities.Presentation.Model.ModelItem ParentModelItem { get { return default(System.Activities.Presentation.Model.ModelItem); } }
  }
  public delegate void ViewStateChangedEventHandler(object sender, System.Activities.Presentation.View.ViewStateChangedEventArgs e);
  public abstract partial class ViewStateService {
    protected ViewStateService() { }
    public abstract event System.Activities.Presentation.View.ViewStateChangedEventHandler UndoableViewStateChanged;
    public abstract event System.Activities.Presentation.View.ViewStateChangedEventHandler ViewStateChanged;
    public abstract bool RemoveViewState(System.Activities.Presentation.Model.ModelItem modelItem, string key);
    public abstract System.Collections.Generic.Dictionary<System.String, System.Object> RetrieveAllViewState(System.Activities.Presentation.Model.ModelItem modelItem);
    public abstract object RetrieveViewState(System.Activities.Presentation.Model.ModelItem modelItem, string key);
    public abstract void StoreViewState(System.Activities.Presentation.Model.ModelItem modelItem, string key, object value);
    public abstract void StoreViewStateWithUndo(System.Activities.Presentation.Model.ModelItem modelItem, string key, object value);
  }
  public partial class VirtualizedContainerService {
    public static readonly System.Xaml.AttachableMemberIdentifier HintSizeName;
    public VirtualizedContainerService(System.Activities.Presentation.EditingContext context) { }
    public System.Windows.UIElement GetContainer(System.Activities.Presentation.Model.ModelItem modelItem, System.Activities.Presentation.ICompositeView sourceContainer) { return default(System.Windows.UIElement); }
    public static object GetHintSize(object instance) { return default(object); }
    public System.Activities.Presentation.WorkflowViewElement GetViewElement(System.Activities.Presentation.Model.ModelItem modelItem, System.Activities.Presentation.ICompositeView sourceContainer) { return default(System.Activities.Presentation.WorkflowViewElement); }
    public static void SetHintSize(object instance, object value) { }
  }
  public partial class WorkflowViewService : System.Activities.Presentation.Services.ViewService {
    public WorkflowViewService(System.Activities.Presentation.EditingContext context) { }
    public event System.EventHandler<System.Activities.Presentation.View.ViewCreatedEventArgs> ViewCreated { add { } remove { } }
    protected System.Activities.Presentation.WorkflowViewElement CreateViewElement(System.Activities.Presentation.Model.ModelItem modelItem) { return default(System.Activities.Presentation.WorkflowViewElement); }
    public override System.Activities.Presentation.Model.ModelItem GetModel(System.Windows.DependencyObject view) { return default(System.Activities.Presentation.Model.ModelItem); }
    public override System.Windows.DependencyObject GetView(System.Activities.Presentation.Model.ModelItem model) { return default(System.Windows.DependencyObject); }
    public System.Activities.Presentation.WorkflowViewElement GetViewElement(System.Activities.Presentation.Model.ModelItem modelItem) { return default(System.Activities.Presentation.WorkflowViewElement); }
  }
  public partial class WorkflowViewStateService : System.Activities.Presentation.View.ViewStateService {
    public static readonly System.Xaml.AttachableMemberIdentifier ViewStateName;
    public WorkflowViewStateService(System.Activities.Presentation.EditingContext context) { }
    public override event System.Activities.Presentation.View.ViewStateChangedEventHandler UndoableViewStateChanged { add { } remove { } }
    public override event System.Activities.Presentation.View.ViewStateChangedEventHandler ViewStateChanged { add { } remove { } }
    public static System.Collections.Generic.Dictionary<System.String, System.Object> GetViewState(object instance) { return default(System.Collections.Generic.Dictionary<System.String, System.Object>); }
    public override bool RemoveViewState(System.Activities.Presentation.Model.ModelItem modelItem, string key) { return default(bool); }
    public override System.Collections.Generic.Dictionary<System.String, System.Object> RetrieveAllViewState(System.Activities.Presentation.Model.ModelItem modelItem) { return default(System.Collections.Generic.Dictionary<System.String, System.Object>); }
    public override object RetrieveViewState(System.Activities.Presentation.Model.ModelItem modelItem, string key) { return default(object); }
    public static void SetViewState(object instance, System.Collections.Generic.Dictionary<System.String, System.Object> value) { }
    public override void StoreViewState(System.Activities.Presentation.Model.ModelItem modelItem, string key, object value) { }
    public override void StoreViewStateWithUndo(System.Activities.Presentation.Model.ModelItem modelItem, string key, object value) { }
  }
}
namespace System.Activities.Presentation.View.OutlineView {
  [System.AttributeUsageAttribute((System.AttributeTargets)(128), Inherited=true, AllowMultiple=false)]
  public sealed partial class HidePropertyInOutlineViewAttribute : System.Attribute {
    public HidePropertyInOutlineViewAttribute() { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), Inherited=true, AllowMultiple=false)]
  public sealed partial class ShowInOutlineViewAttribute : System.Attribute {
    public ShowInOutlineViewAttribute() { }
    public string PromotedProperty { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(128), Inherited=true, AllowMultiple=false)]
  public sealed partial class ShowPropertyInOutlineViewAsSiblingAttribute : System.Attribute {
    public ShowPropertyInOutlineViewAsSiblingAttribute() { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(128), Inherited=true, AllowMultiple=false)]
  public sealed partial class ShowPropertyInOutlineViewAttribute : System.Attribute {
    public ShowPropertyInOutlineViewAttribute() { }
    public string ChildNodePrefix { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool CurrentPropertyVisible { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool DuplicatedChildNodesVisible { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
}
namespace System.Activities.Presentation.ViewState {
  public sealed partial class ViewStateData {
    public ViewStateData() { }
    public string Id { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  [System.Windows.Markup.ContentPropertyAttribute("ViewStateData")]
  public sealed partial class ViewStateManager {
    public ViewStateManager() { }
    public System.Collections.ObjectModel.Collection<System.Activities.Presentation.ViewState.ViewStateData> ViewStateData { get { return default(System.Collections.ObjectModel.Collection<System.Activities.Presentation.ViewState.ViewStateData>); } }
  }
  public static partial class WorkflowViewState {
    public static readonly System.Xaml.AttachableMemberIdentifier IdRefProperty;
    public static readonly System.Xaml.AttachableMemberIdentifier ViewStateManagerProperty;
    public static string GetIdRef(object instance) { return default(string); }
    public static System.Activities.Presentation.ViewState.ViewStateManager GetViewStateManager(object instance) { return default(System.Activities.Presentation.ViewState.ViewStateManager); }
    public static void SetIdRef(object instance, string idRef) { }
    public static void SetViewStateManager(object instance, System.Activities.Presentation.ViewState.ViewStateManager viewStateManager) { }
  }
}
namespace XamlGeneratedNamespace {
  [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.Diagnostics.DebuggerNonUserCodeAttribute]
  public sealed partial class GeneratedInternalTypeHelper : System.Windows.Markup.InternalTypeHelper {
    public GeneratedInternalTypeHelper() { }
    protected override void AddEventHandler(System.Reflection.EventInfo eventInfo, object target, System.Delegate handler) { }
    protected override System.Delegate CreateDelegate(System.Type delegateType, object target, string handler) { return default(System.Delegate); }
    protected override object CreateInstance(System.Type type, System.Globalization.CultureInfo culture) { return default(object); }
    protected override object GetPropertyValue(System.Reflection.PropertyInfo propertyInfo, object target, System.Globalization.CultureInfo culture) { return default(object); }
    protected override void SetPropertyValue(System.Reflection.PropertyInfo propertyInfo, object target, object value, System.Globalization.CultureInfo culture) { }
  }
}
