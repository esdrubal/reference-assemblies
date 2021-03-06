namespace System.Windows.Automation {
  public sealed partial class AsyncContentLoadedEventArgs : System.Windows.Automation.AutomationEventArgs {
    public AsyncContentLoadedEventArgs(System.Windows.Automation.AsyncContentLoadedState asyncContentState, double percentComplete) : base (default(System.Windows.Automation.AutomationEvent)) { }
    public System.Windows.Automation.AsyncContentLoadedState AsyncContentLoadedState { get { return default(System.Windows.Automation.AsyncContentLoadedState); } }
    public double PercentComplete { get { return default(double); } }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("d8e55844-7043-4edc-979d-593cc6b4775e")]
  public enum AsyncContentLoadedState {
    Beginning = 0,
    Completed = 2,
    Progress = 1,
  }
  public static partial class AutomationElementIdentifiers {
    public static readonly System.Windows.Automation.AutomationProperty AcceleratorKeyProperty;
    public static readonly System.Windows.Automation.AutomationProperty AccessKeyProperty;
    public static readonly System.Windows.Automation.AutomationEvent AsyncContentLoadedEvent;
    public static readonly System.Windows.Automation.AutomationEvent AutomationFocusChangedEvent;
    public static readonly System.Windows.Automation.AutomationProperty AutomationIdProperty;
    public static readonly System.Windows.Automation.AutomationEvent AutomationPropertyChangedEvent;
    public static readonly System.Windows.Automation.AutomationProperty BoundingRectangleProperty;
    public static readonly System.Windows.Automation.AutomationProperty ClassNameProperty;
    public static readonly System.Windows.Automation.AutomationProperty ClickablePointProperty;
    public static readonly System.Windows.Automation.AutomationProperty ControlTypeProperty;
    public static readonly System.Windows.Automation.AutomationProperty CultureProperty;
    public static readonly System.Windows.Automation.AutomationProperty FrameworkIdProperty;
    public static readonly System.Windows.Automation.AutomationProperty HasKeyboardFocusProperty;
    public static readonly System.Windows.Automation.AutomationProperty HelpTextProperty;
    public static readonly System.Windows.Automation.AutomationProperty IsContentElementProperty;
    public static readonly System.Windows.Automation.AutomationProperty IsControlElementProperty;
    public static readonly System.Windows.Automation.AutomationProperty IsDockPatternAvailableProperty;
    public static readonly System.Windows.Automation.AutomationProperty IsEnabledProperty;
    public static readonly System.Windows.Automation.AutomationProperty IsExpandCollapsePatternAvailableProperty;
    public static readonly System.Windows.Automation.AutomationProperty IsGridItemPatternAvailableProperty;
    public static readonly System.Windows.Automation.AutomationProperty IsGridPatternAvailableProperty;
    public static readonly System.Windows.Automation.AutomationProperty IsInvokePatternAvailableProperty;
    public static readonly System.Windows.Automation.AutomationProperty IsItemContainerPatternAvailableProperty;
    public static readonly System.Windows.Automation.AutomationProperty IsKeyboardFocusableProperty;
    public static readonly System.Windows.Automation.AutomationProperty IsMultipleViewPatternAvailableProperty;
    public static readonly System.Windows.Automation.AutomationProperty IsOffscreenProperty;
    public static readonly System.Windows.Automation.AutomationProperty IsPasswordProperty;
    public static readonly System.Windows.Automation.AutomationProperty IsRangeValuePatternAvailableProperty;
    public static readonly System.Windows.Automation.AutomationProperty IsRequiredForFormProperty;
    public static readonly System.Windows.Automation.AutomationProperty IsScrollItemPatternAvailableProperty;
    public static readonly System.Windows.Automation.AutomationProperty IsScrollPatternAvailableProperty;
    public static readonly System.Windows.Automation.AutomationProperty IsSelectionItemPatternAvailableProperty;
    public static readonly System.Windows.Automation.AutomationProperty IsSelectionPatternAvailableProperty;
    public static readonly System.Windows.Automation.AutomationProperty IsSynchronizedInputPatternAvailableProperty;
    public static readonly System.Windows.Automation.AutomationProperty IsTableItemPatternAvailableProperty;
    public static readonly System.Windows.Automation.AutomationProperty IsTablePatternAvailableProperty;
    public static readonly System.Windows.Automation.AutomationProperty IsTextPatternAvailableProperty;
    public static readonly System.Windows.Automation.AutomationProperty IsTogglePatternAvailableProperty;
    public static readonly System.Windows.Automation.AutomationProperty IsTransformPatternAvailableProperty;
    public static readonly System.Windows.Automation.AutomationProperty IsValuePatternAvailableProperty;
    public static readonly System.Windows.Automation.AutomationProperty IsVirtualizedItemPatternAvailableProperty;
    public static readonly System.Windows.Automation.AutomationProperty IsWindowPatternAvailableProperty;
    public static readonly System.Windows.Automation.AutomationProperty ItemStatusProperty;
    public static readonly System.Windows.Automation.AutomationProperty ItemTypeProperty;
    public static readonly System.Windows.Automation.AutomationProperty LabeledByProperty;
    public static readonly System.Windows.Automation.AutomationEvent LayoutInvalidatedEvent;
    public static readonly System.Windows.Automation.AutomationProperty LocalizedControlTypeProperty;
    public static readonly System.Windows.Automation.AutomationEvent MenuClosedEvent;
    public static readonly System.Windows.Automation.AutomationEvent MenuOpenedEvent;
    public static readonly System.Windows.Automation.AutomationProperty NameProperty;
    public static readonly System.Windows.Automation.AutomationProperty NativeWindowHandleProperty;
    public static readonly object NotSupported;
    public static readonly System.Windows.Automation.AutomationProperty OrientationProperty;
    public static readonly System.Windows.Automation.AutomationProperty ProcessIdProperty;
    public static readonly System.Windows.Automation.AutomationProperty RuntimeIdProperty;
    public static readonly System.Windows.Automation.AutomationEvent StructureChangedEvent;
    public static readonly System.Windows.Automation.AutomationEvent ToolTipClosedEvent;
    public static readonly System.Windows.Automation.AutomationEvent ToolTipOpenedEvent;
  }
  public partial class AutomationEvent : System.Windows.Automation.AutomationIdentifier {
    internal AutomationEvent() { }
    public static System.Windows.Automation.AutomationEvent LookupById(int id) { return default(System.Windows.Automation.AutomationEvent); }
  }
  public partial class AutomationEventArgs : System.EventArgs {
    public AutomationEventArgs(System.Windows.Automation.AutomationEvent eventId) { }
    public System.Windows.Automation.AutomationEvent EventId { get { return default(System.Windows.Automation.AutomationEvent); } }
  }
  public delegate void AutomationEventHandler(object sender, System.Windows.Automation.AutomationEventArgs e);
  public partial class AutomationIdentifier : System.IComparable {
    internal AutomationIdentifier() { }
    public int Id { get { return default(int); } }
    public string ProgrammaticName { get { return default(string); } }
    public int CompareTo(object obj) { return default(int); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }
  public partial class AutomationPattern : System.Windows.Automation.AutomationIdentifier {
    internal AutomationPattern() { }
    public static System.Windows.Automation.AutomationPattern LookupById(int id) { return default(System.Windows.Automation.AutomationPattern); }
  }
  public partial class AutomationProperty : System.Windows.Automation.AutomationIdentifier {
    internal AutomationProperty() { }
    public static System.Windows.Automation.AutomationProperty LookupById(int id) { return default(System.Windows.Automation.AutomationProperty); }
  }
  public sealed partial class AutomationPropertyChangedEventArgs : System.Windows.Automation.AutomationEventArgs {
    public AutomationPropertyChangedEventArgs(System.Windows.Automation.AutomationProperty property, object oldValue, object newValue) : base (default(System.Windows.Automation.AutomationEvent)) { }
    public object NewValue { get { return default(object); } }
    public object OldValue { get { return default(object); } }
    public System.Windows.Automation.AutomationProperty Property { get { return default(System.Windows.Automation.AutomationProperty); } }
  }
  public delegate void AutomationPropertyChangedEventHandler(object sender, System.Windows.Automation.AutomationPropertyChangedEventArgs e);
  public partial class AutomationTextAttribute : System.Windows.Automation.AutomationIdentifier {
    internal AutomationTextAttribute() { }
    public static System.Windows.Automation.AutomationTextAttribute LookupById(int id) { return default(System.Windows.Automation.AutomationTextAttribute); }
  }
  public partial class ControlType : System.Windows.Automation.AutomationIdentifier {
    internal ControlType() { }
    public static readonly System.Windows.Automation.ControlType Button;
    public static readonly System.Windows.Automation.ControlType Calendar;
    public static readonly System.Windows.Automation.ControlType CheckBox;
    public static readonly System.Windows.Automation.ControlType ComboBox;
    public static readonly System.Windows.Automation.ControlType Custom;
    public static readonly System.Windows.Automation.ControlType DataGrid;
    public static readonly System.Windows.Automation.ControlType DataItem;
    public static readonly System.Windows.Automation.ControlType Document;
    public static readonly System.Windows.Automation.ControlType Edit;
    public static readonly System.Windows.Automation.ControlType Group;
    public static readonly System.Windows.Automation.ControlType Header;
    public static readonly System.Windows.Automation.ControlType HeaderItem;
    public static readonly System.Windows.Automation.ControlType Hyperlink;
    public static readonly System.Windows.Automation.ControlType Image;
    public static readonly System.Windows.Automation.ControlType List;
    public static readonly System.Windows.Automation.ControlType ListItem;
    public static readonly System.Windows.Automation.ControlType Menu;
    public static readonly System.Windows.Automation.ControlType MenuBar;
    public static readonly System.Windows.Automation.ControlType MenuItem;
    public static readonly System.Windows.Automation.ControlType Pane;
    public static readonly System.Windows.Automation.ControlType ProgressBar;
    public static readonly System.Windows.Automation.ControlType RadioButton;
    public static readonly System.Windows.Automation.ControlType ScrollBar;
    public static readonly System.Windows.Automation.ControlType Separator;
    public static readonly System.Windows.Automation.ControlType Slider;
    public static readonly System.Windows.Automation.ControlType Spinner;
    public static readonly System.Windows.Automation.ControlType SplitButton;
    public static readonly System.Windows.Automation.ControlType StatusBar;
    public static readonly System.Windows.Automation.ControlType Tab;
    public static readonly System.Windows.Automation.ControlType TabItem;
    public static readonly System.Windows.Automation.ControlType Table;
    public static readonly System.Windows.Automation.ControlType Text;
    public static readonly System.Windows.Automation.ControlType Thumb;
    public static readonly System.Windows.Automation.ControlType TitleBar;
    public static readonly System.Windows.Automation.ControlType ToolBar;
    public static readonly System.Windows.Automation.ControlType ToolTip;
    public static readonly System.Windows.Automation.ControlType Tree;
    public static readonly System.Windows.Automation.ControlType TreeItem;
    public static readonly System.Windows.Automation.ControlType Window;
    public string LocalizedControlType { get { return default(string); } }
    public System.Windows.Automation.AutomationPattern[] GetNeverSupportedPatterns() { return default(System.Windows.Automation.AutomationPattern[]); }
    public System.Windows.Automation.AutomationPattern[][] GetRequiredPatternSets() { return default(System.Windows.Automation.AutomationPattern[][]); }
    public System.Windows.Automation.AutomationProperty[] GetRequiredProperties() { return default(System.Windows.Automation.AutomationProperty[]); }
    public static System.Windows.Automation.ControlType LookupById(int id) { return default(System.Windows.Automation.ControlType); }
  }
  public static partial class DockPatternIdentifiers {
    public static readonly System.Windows.Automation.AutomationProperty DockPositionProperty;
    public static readonly System.Windows.Automation.AutomationPattern Pattern;
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("70d46e77-e3a8-449d-913c-e30eb2afecdb")]
  public enum DockPosition {
    Bottom = 2,
    Fill = 4,
    Left = 1,
    None = 5,
    Right = 3,
    Top = 0,
  }
  public partial class ElementNotAvailableException : System.SystemException {
    public ElementNotAvailableException() { }
    public ElementNotAvailableException(System.Exception innerException) { }
    protected ElementNotAvailableException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public ElementNotAvailableException(string message) { }
    public ElementNotAvailableException(string message, System.Exception innerException) { }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, SerializationFormatter=true)]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial class ElementNotEnabledException : System.InvalidOperationException {
    public ElementNotEnabledException() { }
    protected ElementNotEnabledException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public ElementNotEnabledException(string message) { }
    public ElementNotEnabledException(string message, System.Exception innerException) { }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, SerializationFormatter=true)]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public static partial class ExpandCollapsePatternIdentifiers {
    public static readonly System.Windows.Automation.AutomationProperty ExpandCollapseStateProperty;
    public static readonly System.Windows.Automation.AutomationPattern Pattern;
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("76d12d7e-b227-4417-9ce2-42642ffa896a")]
  public enum ExpandCollapseState {
    Collapsed = 0,
    Expanded = 1,
    LeafNode = 3,
    PartiallyExpanded = 2,
  }
  public static partial class GridItemPatternIdentifiers {
    public static readonly System.Windows.Automation.AutomationProperty ColumnProperty;
    public static readonly System.Windows.Automation.AutomationProperty ColumnSpanProperty;
    public static readonly System.Windows.Automation.AutomationProperty ContainingGridProperty;
    public static readonly System.Windows.Automation.AutomationPattern Pattern;
    public static readonly System.Windows.Automation.AutomationProperty RowProperty;
    public static readonly System.Windows.Automation.AutomationProperty RowSpanProperty;
  }
  public static partial class GridPatternIdentifiers {
    public static readonly System.Windows.Automation.AutomationProperty ColumnCountProperty;
    public static readonly System.Windows.Automation.AutomationPattern Pattern;
    public static readonly System.Windows.Automation.AutomationProperty RowCountProperty;
  }
  public static partial class InvokePatternIdentifiers {
    public static readonly System.Windows.Automation.AutomationEvent InvokedEvent;
    public static readonly System.Windows.Automation.AutomationPattern Pattern;
  }
  public static partial class ItemContainerPatternIdentifiers {
    public static readonly System.Windows.Automation.AutomationPattern Pattern;
  }
  public static partial class MultipleViewPatternIdentifiers {
    public static readonly System.Windows.Automation.AutomationProperty CurrentViewProperty;
    public static readonly System.Windows.Automation.AutomationPattern Pattern;
    public static readonly System.Windows.Automation.AutomationProperty SupportedViewsProperty;
  }
  public partial class NoClickablePointException : System.Exception {
    public NoClickablePointException() { }
    protected NoClickablePointException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public NoClickablePointException(string message) { }
    public NoClickablePointException(string message, System.Exception innerException) { }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, SerializationFormatter=true)]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("5F8A77B4-E685-48c1-94D0-8BB6AFA43DF9")]
  public enum OrientationType {
    Horizontal = 1,
    None = 0,
    Vertical = 2,
  }
  public partial class ProxyAssemblyNotLoadedException : System.Exception {
    public ProxyAssemblyNotLoadedException() { }
    protected ProxyAssemblyNotLoadedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public ProxyAssemblyNotLoadedException(string message) { }
    public ProxyAssemblyNotLoadedException(string message, System.Exception innerException) { }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, SerializationFormatter=true)]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public static partial class RangeValuePatternIdentifiers {
    public static readonly System.Windows.Automation.AutomationProperty IsReadOnlyProperty;
    public static readonly System.Windows.Automation.AutomationProperty LargeChangeProperty;
    public static readonly System.Windows.Automation.AutomationProperty MaximumProperty;
    public static readonly System.Windows.Automation.AutomationProperty MinimumProperty;
    public static readonly System.Windows.Automation.AutomationPattern Pattern;
    public static readonly System.Windows.Automation.AutomationProperty SmallChangeProperty;
    public static readonly System.Windows.Automation.AutomationProperty ValueProperty;
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("15fdf2e2-9847-41cd-95dd-510612a025ea")]
  public enum RowOrColumnMajor {
    ColumnMajor = 1,
    Indeterminate = 2,
    RowMajor = 0,
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("bd52d3c7-f990-4c52-9ae3-5c377e9eb772")]
  public enum ScrollAmount {
    LargeDecrement = 0,
    LargeIncrement = 3,
    NoAmount = 2,
    SmallDecrement = 1,
    SmallIncrement = 4,
  }
  public static partial class ScrollItemPatternIdentifiers {
    public static readonly System.Windows.Automation.AutomationPattern Pattern;
  }
  public static partial class ScrollPatternIdentifiers {
    public static readonly System.Windows.Automation.AutomationProperty HorizontallyScrollableProperty;
    public static readonly System.Windows.Automation.AutomationProperty HorizontalScrollPercentProperty;
    public static readonly System.Windows.Automation.AutomationProperty HorizontalViewSizeProperty;
    public const double NoScroll = -1;
    public static readonly System.Windows.Automation.AutomationPattern Pattern;
    public static readonly System.Windows.Automation.AutomationProperty VerticallyScrollableProperty;
    public static readonly System.Windows.Automation.AutomationProperty VerticalScrollPercentProperty;
    public static readonly System.Windows.Automation.AutomationProperty VerticalViewSizeProperty;
  }
  public static partial class SelectionItemPatternIdentifiers {
    public static readonly System.Windows.Automation.AutomationEvent ElementAddedToSelectionEvent;
    public static readonly System.Windows.Automation.AutomationEvent ElementRemovedFromSelectionEvent;
    public static readonly System.Windows.Automation.AutomationEvent ElementSelectedEvent;
    public static readonly System.Windows.Automation.AutomationProperty IsSelectedProperty;
    public static readonly System.Windows.Automation.AutomationPattern Pattern;
    public static readonly System.Windows.Automation.AutomationProperty SelectionContainerProperty;
  }
  public static partial class SelectionPatternIdentifiers {
    public static readonly System.Windows.Automation.AutomationProperty CanSelectMultipleProperty;
    public static readonly System.Windows.Automation.AutomationEvent InvalidatedEvent;
    public static readonly System.Windows.Automation.AutomationProperty IsSelectionRequiredProperty;
    public static readonly System.Windows.Automation.AutomationPattern Pattern;
    public static readonly System.Windows.Automation.AutomationProperty SelectionProperty;
  }
  public sealed partial class StructureChangedEventArgs : System.Windows.Automation.AutomationEventArgs {
    public StructureChangedEventArgs(System.Windows.Automation.StructureChangeType structureChangeType, System.Int32[] runtimeId) : base (default(System.Windows.Automation.AutomationEvent)) { }
    public System.Windows.Automation.StructureChangeType StructureChangeType { get { return default(System.Windows.Automation.StructureChangeType); } }
    public System.Int32[] GetRuntimeId() { return default(System.Int32[]); }
  }
  public delegate void StructureChangedEventHandler(object sender, System.Windows.Automation.StructureChangedEventArgs e);
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("e4cfef41-071d-472c-a65c-c14f59ea81eb")]
  public enum StructureChangeType {
    ChildAdded = 0,
    ChildRemoved = 1,
    ChildrenBulkAdded = 3,
    ChildrenBulkRemoved = 4,
    ChildrenInvalidated = 2,
    ChildrenReordered = 5,
  }
  [System.FlagsAttribute]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("3d9e3d8f-bfb0-484f-84ab-93ff4280cbc4")]
  public enum SupportedTextSelection {
    Multiple = 2,
    None = 0,
    Single = 1,
  }
  public static partial class SynchronizedInputPatternIdentifiers {
    public static readonly System.Windows.Automation.AutomationEvent InputDiscardedEvent;
    public static readonly System.Windows.Automation.AutomationEvent InputReachedOtherElementEvent;
    public static readonly System.Windows.Automation.AutomationEvent InputReachedTargetEvent;
    public static readonly System.Windows.Automation.AutomationPattern Pattern;
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("fdc8f176-aed2-477a-8c89-5604c66f278d")]
  public enum SynchronizedInputType {
    KeyDown = 2,
    KeyUp = 1,
    MouseLeftButtonDown = 8,
    MouseLeftButtonUp = 4,
    MouseRightButtonDown = 32,
    MouseRightButtonUp = 16,
  }
  public static partial class TableItemPatternIdentifiers {
    public static readonly System.Windows.Automation.AutomationProperty ColumnHeaderItemsProperty;
    public static readonly System.Windows.Automation.AutomationPattern Pattern;
    public static readonly System.Windows.Automation.AutomationProperty RowHeaderItemsProperty;
  }
  public static partial class TablePatternIdentifiers {
    public static readonly System.Windows.Automation.AutomationProperty ColumnHeadersProperty;
    public static readonly System.Windows.Automation.AutomationPattern Pattern;
    public static readonly System.Windows.Automation.AutomationProperty RowHeadersProperty;
    public static readonly System.Windows.Automation.AutomationProperty RowOrColumnMajorProperty;
  }
  public static partial class TextPatternIdentifiers {
    public static readonly System.Windows.Automation.AutomationTextAttribute AnimationStyleAttribute;
    public static readonly System.Windows.Automation.AutomationTextAttribute BackgroundColorAttribute;
    public static readonly System.Windows.Automation.AutomationTextAttribute BulletStyleAttribute;
    public static readonly System.Windows.Automation.AutomationTextAttribute CapStyleAttribute;
    public static readonly System.Windows.Automation.AutomationTextAttribute CultureAttribute;
    public static readonly System.Windows.Automation.AutomationTextAttribute FontNameAttribute;
    public static readonly System.Windows.Automation.AutomationTextAttribute FontSizeAttribute;
    public static readonly System.Windows.Automation.AutomationTextAttribute FontWeightAttribute;
    public static readonly System.Windows.Automation.AutomationTextAttribute ForegroundColorAttribute;
    public static readonly System.Windows.Automation.AutomationTextAttribute HorizontalTextAlignmentAttribute;
    public static readonly System.Windows.Automation.AutomationTextAttribute IndentationFirstLineAttribute;
    public static readonly System.Windows.Automation.AutomationTextAttribute IndentationLeadingAttribute;
    public static readonly System.Windows.Automation.AutomationTextAttribute IndentationTrailingAttribute;
    public static readonly System.Windows.Automation.AutomationTextAttribute IsHiddenAttribute;
    public static readonly System.Windows.Automation.AutomationTextAttribute IsItalicAttribute;
    public static readonly System.Windows.Automation.AutomationTextAttribute IsReadOnlyAttribute;
    public static readonly System.Windows.Automation.AutomationTextAttribute IsSubscriptAttribute;
    public static readonly System.Windows.Automation.AutomationTextAttribute IsSuperscriptAttribute;
    public static readonly System.Windows.Automation.AutomationTextAttribute MarginBottomAttribute;
    public static readonly System.Windows.Automation.AutomationTextAttribute MarginLeadingAttribute;
    public static readonly System.Windows.Automation.AutomationTextAttribute MarginTopAttribute;
    public static readonly System.Windows.Automation.AutomationTextAttribute MarginTrailingAttribute;
    public static readonly object MixedAttributeValue;
    public static readonly System.Windows.Automation.AutomationTextAttribute OutlineStylesAttribute;
    public static readonly System.Windows.Automation.AutomationTextAttribute OverlineColorAttribute;
    public static readonly System.Windows.Automation.AutomationTextAttribute OverlineStyleAttribute;
    public static readonly System.Windows.Automation.AutomationPattern Pattern;
    public static readonly System.Windows.Automation.AutomationTextAttribute StrikethroughColorAttribute;
    public static readonly System.Windows.Automation.AutomationTextAttribute StrikethroughStyleAttribute;
    public static readonly System.Windows.Automation.AutomationTextAttribute TabsAttribute;
    public static readonly System.Windows.Automation.AutomationEvent TextChangedEvent;
    public static readonly System.Windows.Automation.AutomationTextAttribute TextFlowDirectionsAttribute;
    public static readonly System.Windows.Automation.AutomationEvent TextSelectionChangedEvent;
    public static readonly System.Windows.Automation.AutomationTextAttribute UnderlineColorAttribute;
    public static readonly System.Windows.Automation.AutomationTextAttribute UnderlineStyleAttribute;
  }
  public static partial class TogglePatternIdentifiers {
    public static readonly System.Windows.Automation.AutomationPattern Pattern;
    public static readonly System.Windows.Automation.AutomationProperty ToggleStateProperty;
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("ad7db4af-7166-4478-a402-ad5b77eab2fa")]
  public enum ToggleState {
    Indeterminate = 2,
    Off = 0,
    On = 1,
  }
  public static partial class TransformPatternIdentifiers {
    public static readonly System.Windows.Automation.AutomationProperty CanMoveProperty;
    public static readonly System.Windows.Automation.AutomationProperty CanResizeProperty;
    public static readonly System.Windows.Automation.AutomationProperty CanRotateProperty;
    public static readonly System.Windows.Automation.AutomationPattern Pattern;
  }
  [System.FlagsAttribute]
  public enum TreeScope {
    Ancestors = 16,
    Children = 2,
    Descendants = 4,
    Element = 1,
    Parent = 8,
    Subtree = 7,
  }
  public static partial class ValuePatternIdentifiers {
    public static readonly System.Windows.Automation.AutomationProperty IsReadOnlyProperty;
    public static readonly System.Windows.Automation.AutomationPattern Pattern;
    public static readonly System.Windows.Automation.AutomationProperty ValueProperty;
  }
  public static partial class VirtualizedItemPatternIdentifiers {
    public static readonly System.Windows.Automation.AutomationPattern Pattern;
  }
  public sealed partial class WindowClosedEventArgs : System.Windows.Automation.AutomationEventArgs {
    public WindowClosedEventArgs(System.Int32[] runtimeId) : base (default(System.Windows.Automation.AutomationEvent)) { }
    public System.Int32[] GetRuntimeId() { return default(System.Int32[]); }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("65101cc7-7904-408e-87a7-8c6dbd83a18b")]
  public enum WindowInteractionState {
    BlockedByModalWindow = 3,
    Closing = 1,
    NotResponding = 4,
    ReadyForUserInteraction = 2,
    Running = 0,
  }
  public static partial class WindowPatternIdentifiers {
    public static readonly System.Windows.Automation.AutomationProperty CanMaximizeProperty;
    public static readonly System.Windows.Automation.AutomationProperty CanMinimizeProperty;
    public static readonly System.Windows.Automation.AutomationProperty IsModalProperty;
    public static readonly System.Windows.Automation.AutomationProperty IsTopmostProperty;
    public static readonly System.Windows.Automation.AutomationPattern Pattern;
    public static readonly System.Windows.Automation.AutomationEvent WindowClosedEvent;
    public static readonly System.Windows.Automation.AutomationProperty WindowInteractionStateProperty;
    public static readonly System.Windows.Automation.AutomationEvent WindowOpenedEvent;
    public static readonly System.Windows.Automation.AutomationProperty WindowVisualStateProperty;
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("fdc8f176-aed2-477a-8c89-ea04cc5f278d")]
  public enum WindowVisualState {
    Maximized = 1,
    Minimized = 2,
    Normal = 0,
  }
}
namespace System.Windows.Automation.Text {
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("B6C08F15-AA5E-4754-9E4C-AA279D3F36D4")]
  public enum AnimationStyle {
    BlinkingBackground = 2,
    LasVegasLights = 1,
    MarchingBlackAnts = 4,
    MarchingRedAnts = 5,
    None = 0,
    Other = -1,
    Shimmer = 6,
    SparkleText = 3,
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("814FAC6C-F8DE-4682-AF5F-37C4F720990C")]
  public enum BulletStyle {
    DashBullet = 5,
    FilledRoundBullet = 2,
    FilledSquareBullet = 4,
    HollowRoundBullet = 1,
    HollowSquareBullet = 3,
    None = 0,
    Other = -1,
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("4E33C74B-7848-4f1e-B819-A0D866C2EA1F")]
  public enum CapStyle {
    AllCap = 2,
    AllPetiteCaps = 3,
    None = 0,
    Other = -1,
    PetiteCaps = 4,
    SmallCap = 1,
    Titling = 6,
    Unicase = 5,
  }
  [System.FlagsAttribute]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("2E22CC6B-7C34-4002-91AA-E103A09D1027")]
  public enum FlowDirections {
    BottomToTop = 2,
    Default = 0,
    RightToLeft = 1,
    Vertical = 4,
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("1FBE7021-A1E4-4e9b-BE94-2C7DFA59D5DD")]
  public enum HorizontalTextAlignment {
    Centered = 1,
    Justified = 3,
    Left = 0,
    Right = 2,
  }
  [System.FlagsAttribute]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("1F57B37D-CB59-43f4-95E0-7C9E40DB427E")]
  public enum OutlineStyles {
    Embossed = 8,
    Engraved = 4,
    None = 0,
    Outline = 1,
    Shadow = 2,
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("909D8633-2941-428e-A549-C752E2FC078C")]
  public enum TextDecorationLineStyle {
    Dash = 5,
    DashDot = 6,
    DashDotDot = 7,
    Dot = 4,
    Double = 3,
    DoubleWavy = 11,
    LongDash = 13,
    None = 0,
    Other = -1,
    Single = 1,
    ThickDash = 14,
    ThickDashDot = 15,
    ThickDashDotDot = 16,
    ThickDot = 17,
    ThickLongDash = 18,
    ThickSingle = 9,
    ThickWavy = 12,
    Wavy = 8,
    WordsOnly = 2,
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("62242CAC-9CD0-4364-813D-4F0A36DD842D")]
  public enum TextPatternRangeEndpoint {
    End = 1,
    Start = 0,
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("A044E5C8-FC20-4747-8CC8-1487F9CBB680")]
  public enum TextUnit {
    Character = 0,
    Document = 6,
    Format = 1,
    Line = 3,
    Page = 5,
    Paragraph = 4,
    Word = 2,
  }
}
