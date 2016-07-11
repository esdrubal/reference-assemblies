namespace System.Windows.Automation {
  public partial class AndCondition : System.Windows.Automation.Condition {
    public AndCondition(params System.Windows.Automation.Condition[] conditions) { }
    public System.Windows.Automation.Condition[] GetConditions() { return default(System.Windows.Automation.Condition[]); }
  }
  public static partial class Automation {
    public static readonly System.Windows.Automation.Condition ContentViewCondition;
    public static readonly System.Windows.Automation.Condition ControlViewCondition;
    public static readonly System.Windows.Automation.Condition RawViewCondition;
    public static void AddAutomationEventHandler(System.Windows.Automation.AutomationEvent eventId, System.Windows.Automation.AutomationElement element, System.Windows.Automation.TreeScope scope, System.Windows.Automation.AutomationEventHandler eventHandler) { }
    public static void AddAutomationFocusChangedEventHandler(System.Windows.Automation.AutomationFocusChangedEventHandler eventHandler) { }
    public static void AddAutomationPropertyChangedEventHandler(System.Windows.Automation.AutomationElement element, System.Windows.Automation.TreeScope scope, System.Windows.Automation.AutomationPropertyChangedEventHandler eventHandler, params System.Windows.Automation.AutomationProperty[] properties) { }
    public static void AddStructureChangedEventHandler(System.Windows.Automation.AutomationElement element, System.Windows.Automation.TreeScope scope, System.Windows.Automation.StructureChangedEventHandler eventHandler) { }
    public static bool Compare(System.Int32[] runtimeId1, System.Int32[] runtimeId2) { return default(bool); }
    public static bool Compare(System.Windows.Automation.AutomationElement el1, System.Windows.Automation.AutomationElement el2) { return default(bool); }
    public static string PatternName(System.Windows.Automation.AutomationPattern pattern) { return default(string); }
    public static string PropertyName(System.Windows.Automation.AutomationProperty property) { return default(string); }
    public static void RemoveAllEventHandlers() { }
    public static void RemoveAutomationEventHandler(System.Windows.Automation.AutomationEvent eventId, System.Windows.Automation.AutomationElement element, System.Windows.Automation.AutomationEventHandler eventHandler) { }
    public static void RemoveAutomationFocusChangedEventHandler(System.Windows.Automation.AutomationFocusChangedEventHandler eventHandler) { }
    public static void RemoveAutomationPropertyChangedEventHandler(System.Windows.Automation.AutomationElement element, System.Windows.Automation.AutomationPropertyChangedEventHandler eventHandler) { }
    public static void RemoveStructureChangedEventHandler(System.Windows.Automation.AutomationElement element, System.Windows.Automation.StructureChangedEventHandler eventHandler) { }
  }
  public sealed partial class AutomationElement {
    internal AutomationElement() { }
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
    public System.Windows.Automation.AutomationElement.AutomationElementInformation Cached { get { return default(System.Windows.Automation.AutomationElement.AutomationElementInformation); } }
    public System.Windows.Automation.AutomationElementCollection CachedChildren { get { return default(System.Windows.Automation.AutomationElementCollection); } }
    public System.Windows.Automation.AutomationElement CachedParent { get { return default(System.Windows.Automation.AutomationElement); } }
    public System.Windows.Automation.AutomationElement.AutomationElementInformation Current { get { return default(System.Windows.Automation.AutomationElement.AutomationElementInformation); } }
    public static System.Windows.Automation.AutomationElement FocusedElement { get { return default(System.Windows.Automation.AutomationElement); } }
    public static System.Windows.Automation.AutomationElement RootElement { get { return default(System.Windows.Automation.AutomationElement); } }
    public override bool Equals(object obj) { return default(bool); }
    ~AutomationElement() { }
    public System.Windows.Automation.AutomationElementCollection FindAll(System.Windows.Automation.TreeScope scope, System.Windows.Automation.Condition condition) { return default(System.Windows.Automation.AutomationElementCollection); }
    public System.Windows.Automation.AutomationElement FindFirst(System.Windows.Automation.TreeScope scope, System.Windows.Automation.Condition condition) { return default(System.Windows.Automation.AutomationElement); }
    public static System.Windows.Automation.AutomationElement FromHandle(System.IntPtr hwnd) { return default(System.Windows.Automation.AutomationElement); }
    public static System.Windows.Automation.AutomationElement FromLocalProvider(System.Windows.Automation.Provider.IRawElementProviderSimple localImpl) { return default(System.Windows.Automation.AutomationElement); }
    public static System.Windows.Automation.AutomationElement FromPoint(System.Windows.Point pt) { return default(System.Windows.Automation.AutomationElement); }
    public object GetCachedPattern(System.Windows.Automation.AutomationPattern pattern) { return default(object); }
    public object GetCachedPropertyValue(System.Windows.Automation.AutomationProperty property) { return default(object); }
    public object GetCachedPropertyValue(System.Windows.Automation.AutomationProperty property, bool ignoreDefaultValue) { return default(object); }
    public System.Windows.Point GetClickablePoint() { return default(System.Windows.Point); }
    public object GetCurrentPattern(System.Windows.Automation.AutomationPattern pattern) { return default(object); }
    public object GetCurrentPropertyValue(System.Windows.Automation.AutomationProperty property) { return default(object); }
    public object GetCurrentPropertyValue(System.Windows.Automation.AutomationProperty property, bool ignoreDefaultValue) { return default(object); }
    public override int GetHashCode() { return default(int); }
    public System.Int32[] GetRuntimeId() { return default(System.Int32[]); }
    public System.Windows.Automation.AutomationPattern[] GetSupportedPatterns() { return default(System.Windows.Automation.AutomationPattern[]); }
    public System.Windows.Automation.AutomationProperty[] GetSupportedProperties() { return default(System.Windows.Automation.AutomationProperty[]); }
    public System.Windows.Automation.AutomationElement GetUpdatedCache(System.Windows.Automation.CacheRequest request) { return default(System.Windows.Automation.AutomationElement); }
    public static bool operator ==(System.Windows.Automation.AutomationElement left, System.Windows.Automation.AutomationElement right) { return default(bool); }
    public static bool operator !=(System.Windows.Automation.AutomationElement left, System.Windows.Automation.AutomationElement right) { return default(bool); }
    public void SetFocus() { }
    public bool TryGetCachedPattern(System.Windows.Automation.AutomationPattern pattern, out object patternObject) { patternObject = default(object); return default(bool); }
    public bool TryGetClickablePoint(out System.Windows.Point pt) { pt = default(System.Windows.Point); return default(bool); }
    public bool TryGetCurrentPattern(System.Windows.Automation.AutomationPattern pattern, out object patternObject) { patternObject = default(object); return default(bool); }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct AutomationElementInformation {
      public string AcceleratorKey { get { return default(string); } }
      public string AccessKey { get { return default(string); } }
      public string AutomationId { get { return default(string); } }
      public System.Windows.Rect BoundingRectangle { get { return default(System.Windows.Rect); } }
      public string ClassName { get { return default(string); } }
      public System.Windows.Automation.ControlType ControlType { get { return default(System.Windows.Automation.ControlType); } }
      public string FrameworkId { get { return default(string); } }
      public bool HasKeyboardFocus { get { return default(bool); } }
      public string HelpText { get { return default(string); } }
      public bool IsContentElement { get { return default(bool); } }
      public bool IsControlElement { get { return default(bool); } }
      public bool IsEnabled { get { return default(bool); } }
      public bool IsKeyboardFocusable { get { return default(bool); } }
      public bool IsOffscreen { get { return default(bool); } }
      public bool IsPassword { get { return default(bool); } }
      public bool IsRequiredForForm { get { return default(bool); } }
      public string ItemStatus { get { return default(string); } }
      public string ItemType { get { return default(string); } }
      public System.Windows.Automation.AutomationElement LabeledBy { get { return default(System.Windows.Automation.AutomationElement); } }
      public string LocalizedControlType { get { return default(string); } }
      public string Name { get { return default(string); } }
      public int NativeWindowHandle { get { return default(int); } }
      public System.Windows.Automation.OrientationType Orientation { get { return default(System.Windows.Automation.OrientationType); } }
      public int ProcessId { get { return default(int); } }
    }
  }
  public partial class AutomationElementCollection : System.Collections.ICollection, System.Collections.IEnumerable {
    internal AutomationElementCollection() { }
    public int Count { get { return default(int); } }
    public virtual bool IsSynchronized { get { return default(bool); } }
    public System.Windows.Automation.AutomationElement this[int index] { get { return default(System.Windows.Automation.AutomationElement); } }
    public virtual object SyncRoot { get { return default(object); } }
    public virtual void CopyTo(System.Array array, int index) { }
    public void CopyTo(System.Windows.Automation.AutomationElement[] array, int index) { }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public enum AutomationElementMode {
    Full = 1,
    None = 0,
  }
  public partial class AutomationFocusChangedEventArgs : System.Windows.Automation.AutomationEventArgs {
    public AutomationFocusChangedEventArgs(int idObject, int idChild) : base (default(System.Windows.Automation.AutomationEvent)) { }
    public int ChildId { get { return default(int); } }
    public int ObjectId { get { return default(int); } }
  }
  public delegate void AutomationFocusChangedEventHandler(object sender, System.Windows.Automation.AutomationFocusChangedEventArgs e);
  public partial class BasePattern {
    internal BasePattern() { }
    ~BasePattern() { }
  }
  public sealed partial class CacheRequest {
    public CacheRequest() { }
    public System.Windows.Automation.AutomationElementMode AutomationElementMode { get { return default(System.Windows.Automation.AutomationElementMode); } set { } }
    public static System.Windows.Automation.CacheRequest Current { get { return default(System.Windows.Automation.CacheRequest); } }
    public System.Windows.Automation.Condition TreeFilter { get { return default(System.Windows.Automation.Condition); } set { } }
    public System.Windows.Automation.TreeScope TreeScope { get { return default(System.Windows.Automation.TreeScope); } set { } }
    public System.IDisposable Activate() { return default(System.IDisposable); }
    public void Add(System.Windows.Automation.AutomationPattern pattern) { }
    public void Add(System.Windows.Automation.AutomationProperty property) { }
    public System.Windows.Automation.CacheRequest Clone() { return default(System.Windows.Automation.CacheRequest); }
    public void Pop() { }
    public void Push() { }
  }
  public static partial class ClientSettings {
    public static void RegisterClientSideProviderAssembly(System.Reflection.AssemblyName assemblyName) { }
    public static void RegisterClientSideProviders(System.Windows.Automation.ClientSideProviderDescription[] clientSideProviderDescription) { }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct ClientSideProviderDescription {
    public ClientSideProviderDescription(System.Windows.Automation.ClientSideProviderFactoryCallback clientSideProviderFactoryCallback, string className) { throw new System.NotImplementedException(); }
    public ClientSideProviderDescription(System.Windows.Automation.ClientSideProviderFactoryCallback clientSideProviderFactoryCallback, string className, string imageName, System.Windows.Automation.ClientSideProviderMatchIndicator flags) { throw new System.NotImplementedException(); }
    public string ClassName { get { return default(string); } }
    public System.Windows.Automation.ClientSideProviderFactoryCallback ClientSideProviderFactoryCallback { get { return default(System.Windows.Automation.ClientSideProviderFactoryCallback); } }
    public System.Windows.Automation.ClientSideProviderMatchIndicator Flags { get { return default(System.Windows.Automation.ClientSideProviderMatchIndicator); } }
    public string ImageName { get { return default(string); } }
  }
  public delegate System.Windows.Automation.Provider.IRawElementProviderSimple ClientSideProviderFactoryCallback(System.IntPtr hwnd, int idChild, int idObject);
  [System.FlagsAttribute]
  public enum ClientSideProviderMatchIndicator {
    AllowSubstringMatch = 1,
    DisallowBaseClassNameMatch = 2,
    None = 0,
  }
  public abstract partial class Condition {
    internal Condition() { }
    public static readonly System.Windows.Automation.Condition FalseCondition;
    public static readonly System.Windows.Automation.Condition TrueCondition;
  }
  public partial class DockPattern : System.Windows.Automation.BasePattern {
    internal DockPattern() { }
    public static readonly System.Windows.Automation.AutomationProperty DockPositionProperty;
    public static readonly System.Windows.Automation.AutomationPattern Pattern;
    public System.Windows.Automation.DockPattern.DockPatternInformation Cached { get { return default(System.Windows.Automation.DockPattern.DockPatternInformation); } }
    public System.Windows.Automation.DockPattern.DockPatternInformation Current { get { return default(System.Windows.Automation.DockPattern.DockPatternInformation); } }
    public void SetDockPosition(System.Windows.Automation.DockPosition dockPosition) { }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct DockPatternInformation {
      public System.Windows.Automation.DockPosition DockPosition { get { return default(System.Windows.Automation.DockPosition); } }
    }
  }
  public partial class ExpandCollapsePattern : System.Windows.Automation.BasePattern {
    internal ExpandCollapsePattern() { }
    public static readonly System.Windows.Automation.AutomationProperty ExpandCollapseStateProperty;
    public static readonly System.Windows.Automation.AutomationPattern Pattern;
    public System.Windows.Automation.ExpandCollapsePattern.ExpandCollapsePatternInformation Cached { get { return default(System.Windows.Automation.ExpandCollapsePattern.ExpandCollapsePatternInformation); } }
    public System.Windows.Automation.ExpandCollapsePattern.ExpandCollapsePatternInformation Current { get { return default(System.Windows.Automation.ExpandCollapsePattern.ExpandCollapsePatternInformation); } }
    public void Collapse() { }
    public void Expand() { }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct ExpandCollapsePatternInformation {
      public System.Windows.Automation.ExpandCollapseState ExpandCollapseState { get { return default(System.Windows.Automation.ExpandCollapseState); } }
    }
  }
  public partial class GridItemPattern : System.Windows.Automation.BasePattern {
    internal GridItemPattern() { }
    public static readonly System.Windows.Automation.AutomationProperty ColumnProperty;
    public static readonly System.Windows.Automation.AutomationProperty ColumnSpanProperty;
    public static readonly System.Windows.Automation.AutomationProperty ContainingGridProperty;
    public static readonly System.Windows.Automation.AutomationPattern Pattern;
    public static readonly System.Windows.Automation.AutomationProperty RowProperty;
    public static readonly System.Windows.Automation.AutomationProperty RowSpanProperty;
    public System.Windows.Automation.GridItemPattern.GridItemPatternInformation Cached { get { return default(System.Windows.Automation.GridItemPattern.GridItemPatternInformation); } }
    public System.Windows.Automation.GridItemPattern.GridItemPatternInformation Current { get { return default(System.Windows.Automation.GridItemPattern.GridItemPatternInformation); } }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct GridItemPatternInformation {
      public int Column { get { return default(int); } }
      public int ColumnSpan { get { return default(int); } }
      public System.Windows.Automation.AutomationElement ContainingGrid { get { return default(System.Windows.Automation.AutomationElement); } }
      public int Row { get { return default(int); } }
      public int RowSpan { get { return default(int); } }
    }
  }
  public partial class GridPattern : System.Windows.Automation.BasePattern {
    internal GridPattern() { }
    public static readonly System.Windows.Automation.AutomationProperty ColumnCountProperty;
    public static readonly System.Windows.Automation.AutomationPattern Pattern;
    public static readonly System.Windows.Automation.AutomationProperty RowCountProperty;
    public System.Windows.Automation.GridPattern.GridPatternInformation Cached { get { return default(System.Windows.Automation.GridPattern.GridPatternInformation); } }
    public System.Windows.Automation.GridPattern.GridPatternInformation Current { get { return default(System.Windows.Automation.GridPattern.GridPatternInformation); } }
    public System.Windows.Automation.AutomationElement GetItem(int row, int column) { return default(System.Windows.Automation.AutomationElement); }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct GridPatternInformation {
      public int ColumnCount { get { return default(int); } }
      public int RowCount { get { return default(int); } }
    }
  }
  public partial class InvokePattern : System.Windows.Automation.BasePattern {
    internal InvokePattern() { }
    public static readonly System.Windows.Automation.AutomationEvent InvokedEvent;
    public static readonly System.Windows.Automation.AutomationPattern Pattern;
    public void Invoke() { }
  }
  public partial class ItemContainerPattern : System.Windows.Automation.BasePattern {
    internal ItemContainerPattern() { }
    public static readonly System.Windows.Automation.AutomationPattern Pattern;
    public System.Windows.Automation.AutomationElement FindItemByProperty(System.Windows.Automation.AutomationElement startAfter, System.Windows.Automation.AutomationProperty property, object value) { return default(System.Windows.Automation.AutomationElement); }
  }
  public partial class MultipleViewPattern : System.Windows.Automation.BasePattern {
    internal MultipleViewPattern() { }
    public static readonly System.Windows.Automation.AutomationProperty CurrentViewProperty;
    public static readonly System.Windows.Automation.AutomationPattern Pattern;
    public static readonly System.Windows.Automation.AutomationProperty SupportedViewsProperty;
    public System.Windows.Automation.MultipleViewPattern.MultipleViewPatternInformation Cached { get { return default(System.Windows.Automation.MultipleViewPattern.MultipleViewPatternInformation); } }
    public System.Windows.Automation.MultipleViewPattern.MultipleViewPatternInformation Current { get { return default(System.Windows.Automation.MultipleViewPattern.MultipleViewPatternInformation); } }
    public string GetViewName(int viewId) { return default(string); }
    public void SetCurrentView(int viewId) { }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct MultipleViewPatternInformation {
      public int CurrentView { get { return default(int); } }
      public System.Int32[] GetSupportedViews() { return default(System.Int32[]); }
    }
  }
  public partial class NotCondition : System.Windows.Automation.Condition {
    public NotCondition(System.Windows.Automation.Condition condition) { }
    public System.Windows.Automation.Condition Condition { get { return default(System.Windows.Automation.Condition); } }
  }
  public partial class OrCondition : System.Windows.Automation.Condition {
    public OrCondition(params System.Windows.Automation.Condition[] conditions) { }
    public System.Windows.Automation.Condition[] GetConditions() { return default(System.Windows.Automation.Condition[]); }
  }
  public partial class PropertyCondition : System.Windows.Automation.Condition {
    public PropertyCondition(System.Windows.Automation.AutomationProperty property, object value) { }
    public PropertyCondition(System.Windows.Automation.AutomationProperty property, object value, System.Windows.Automation.PropertyConditionFlags flags) { }
    public System.Windows.Automation.PropertyConditionFlags Flags { get { return default(System.Windows.Automation.PropertyConditionFlags); } }
    public System.Windows.Automation.AutomationProperty Property { get { return default(System.Windows.Automation.AutomationProperty); } }
    public object Value { get { return default(object); } }
  }
  [System.FlagsAttribute]
  public enum PropertyConditionFlags {
    IgnoreCase = 1,
    None = 0,
  }
  public partial class RangeValuePattern : System.Windows.Automation.BasePattern {
    internal RangeValuePattern() { }
    public static readonly System.Windows.Automation.AutomationProperty IsReadOnlyProperty;
    public static readonly System.Windows.Automation.AutomationProperty LargeChangeProperty;
    public static readonly System.Windows.Automation.AutomationProperty MaximumProperty;
    public static readonly System.Windows.Automation.AutomationProperty MinimumProperty;
    public static readonly System.Windows.Automation.AutomationPattern Pattern;
    public static readonly System.Windows.Automation.AutomationProperty SmallChangeProperty;
    public static readonly System.Windows.Automation.AutomationProperty ValueProperty;
    public System.Windows.Automation.RangeValuePattern.RangeValuePatternInformation Cached { get { return default(System.Windows.Automation.RangeValuePattern.RangeValuePatternInformation); } }
    public System.Windows.Automation.RangeValuePattern.RangeValuePatternInformation Current { get { return default(System.Windows.Automation.RangeValuePattern.RangeValuePatternInformation); } }
    public void SetValue(double value) { }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct RangeValuePatternInformation {
      public bool IsReadOnly { get { return default(bool); } }
      public double LargeChange { get { return default(double); } }
      public double Maximum { get { return default(double); } }
      public double Minimum { get { return default(double); } }
      public double SmallChange { get { return default(double); } }
      public double Value { get { return default(double); } }
    }
  }
  public partial class ScrollItemPattern : System.Windows.Automation.BasePattern {
    internal ScrollItemPattern() { }
    public static readonly System.Windows.Automation.AutomationPattern Pattern;
    public void ScrollIntoView() { }
  }
  public partial class ScrollPattern : System.Windows.Automation.BasePattern {
    internal ScrollPattern() { }
    public static readonly System.Windows.Automation.AutomationProperty HorizontallyScrollableProperty;
    public static readonly System.Windows.Automation.AutomationProperty HorizontalScrollPercentProperty;
    public static readonly System.Windows.Automation.AutomationProperty HorizontalViewSizeProperty;
    public const double NoScroll = -1;
    public static readonly System.Windows.Automation.AutomationPattern Pattern;
    public static readonly System.Windows.Automation.AutomationProperty VerticallyScrollableProperty;
    public static readonly System.Windows.Automation.AutomationProperty VerticalScrollPercentProperty;
    public static readonly System.Windows.Automation.AutomationProperty VerticalViewSizeProperty;
    public System.Windows.Automation.ScrollPattern.ScrollPatternInformation Cached { get { return default(System.Windows.Automation.ScrollPattern.ScrollPatternInformation); } }
    public System.Windows.Automation.ScrollPattern.ScrollPatternInformation Current { get { return default(System.Windows.Automation.ScrollPattern.ScrollPatternInformation); } }
    public void Scroll(System.Windows.Automation.ScrollAmount horizontalAmount, System.Windows.Automation.ScrollAmount verticalAmount) { }
    public void ScrollHorizontal(System.Windows.Automation.ScrollAmount amount) { }
    public void ScrollVertical(System.Windows.Automation.ScrollAmount amount) { }
    public void SetScrollPercent(double horizontalPercent, double verticalPercent) { }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct ScrollPatternInformation {
      public bool HorizontallyScrollable { get { return default(bool); } }
      public double HorizontalScrollPercent { get { return default(double); } }
      public double HorizontalViewSize { get { return default(double); } }
      public bool VerticallyScrollable { get { return default(bool); } }
      public double VerticalScrollPercent { get { return default(double); } }
      public double VerticalViewSize { get { return default(double); } }
    }
  }
  public partial class SelectionItemPattern : System.Windows.Automation.BasePattern {
    internal SelectionItemPattern() { }
    public static readonly System.Windows.Automation.AutomationEvent ElementAddedToSelectionEvent;
    public static readonly System.Windows.Automation.AutomationEvent ElementRemovedFromSelectionEvent;
    public static readonly System.Windows.Automation.AutomationEvent ElementSelectedEvent;
    public static readonly System.Windows.Automation.AutomationProperty IsSelectedProperty;
    public static readonly System.Windows.Automation.AutomationPattern Pattern;
    public static readonly System.Windows.Automation.AutomationProperty SelectionContainerProperty;
    public System.Windows.Automation.SelectionItemPattern.SelectionItemPatternInformation Cached { get { return default(System.Windows.Automation.SelectionItemPattern.SelectionItemPatternInformation); } }
    public System.Windows.Automation.SelectionItemPattern.SelectionItemPatternInformation Current { get { return default(System.Windows.Automation.SelectionItemPattern.SelectionItemPatternInformation); } }
    public void AddToSelection() { }
    public void RemoveFromSelection() { }
    public void Select() { }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct SelectionItemPatternInformation {
      public bool IsSelected { get { return default(bool); } }
      public System.Windows.Automation.AutomationElement SelectionContainer { get { return default(System.Windows.Automation.AutomationElement); } }
    }
  }
  public partial class SelectionPattern : System.Windows.Automation.BasePattern {
    internal SelectionPattern() { }
    public static readonly System.Windows.Automation.AutomationProperty CanSelectMultipleProperty;
    public static readonly System.Windows.Automation.AutomationEvent InvalidatedEvent;
    public static readonly System.Windows.Automation.AutomationProperty IsSelectionRequiredProperty;
    public static readonly System.Windows.Automation.AutomationPattern Pattern;
    public static readonly System.Windows.Automation.AutomationProperty SelectionProperty;
    public System.Windows.Automation.SelectionPattern.SelectionPatternInformation Cached { get { return default(System.Windows.Automation.SelectionPattern.SelectionPatternInformation); } }
    public System.Windows.Automation.SelectionPattern.SelectionPatternInformation Current { get { return default(System.Windows.Automation.SelectionPattern.SelectionPatternInformation); } }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct SelectionPatternInformation {
      public bool CanSelectMultiple { get { return default(bool); } }
      public bool IsSelectionRequired { get { return default(bool); } }
      public System.Windows.Automation.AutomationElement[] GetSelection() { return default(System.Windows.Automation.AutomationElement[]); }
    }
  }
  public partial class SynchronizedInputPattern : System.Windows.Automation.BasePattern {
    internal SynchronizedInputPattern() { }
    public static readonly System.Windows.Automation.AutomationEvent InputDiscardedEvent;
    public static readonly System.Windows.Automation.AutomationEvent InputReachedOtherElementEvent;
    public static readonly System.Windows.Automation.AutomationEvent InputReachedTargetEvent;
    public static readonly System.Windows.Automation.AutomationPattern Pattern;
    public void Cancel() { }
    public void StartListening(System.Windows.Automation.SynchronizedInputType inputType) { }
  }
  public partial class TableItemPattern : System.Windows.Automation.GridItemPattern {
    internal TableItemPattern() { }
    public static readonly System.Windows.Automation.AutomationProperty ColumnHeaderItemsProperty;
    public static readonly new System.Windows.Automation.AutomationPattern Pattern;
    public static readonly System.Windows.Automation.AutomationProperty RowHeaderItemsProperty;
    public new System.Windows.Automation.TableItemPattern.TableItemPatternInformation Cached { get { return default(System.Windows.Automation.TableItemPattern.TableItemPatternInformation); } }
    public new System.Windows.Automation.TableItemPattern.TableItemPatternInformation Current { get { return default(System.Windows.Automation.TableItemPattern.TableItemPatternInformation); } }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct TableItemPatternInformation {
      public int Column { get { return default(int); } }
      public int ColumnSpan { get { return default(int); } }
      public System.Windows.Automation.AutomationElement ContainingGrid { get { return default(System.Windows.Automation.AutomationElement); } }
      public int Row { get { return default(int); } }
      public int RowSpan { get { return default(int); } }
      public System.Windows.Automation.AutomationElement[] GetColumnHeaderItems() { return default(System.Windows.Automation.AutomationElement[]); }
      public System.Windows.Automation.AutomationElement[] GetRowHeaderItems() { return default(System.Windows.Automation.AutomationElement[]); }
    }
  }
  public partial class TablePattern : System.Windows.Automation.GridPattern {
    internal TablePattern() { }
    public static readonly System.Windows.Automation.AutomationProperty ColumnHeadersProperty;
    public static readonly new System.Windows.Automation.AutomationPattern Pattern;
    public static readonly System.Windows.Automation.AutomationProperty RowHeadersProperty;
    public static readonly System.Windows.Automation.AutomationProperty RowOrColumnMajorProperty;
    public new System.Windows.Automation.TablePattern.TablePatternInformation Cached { get { return default(System.Windows.Automation.TablePattern.TablePatternInformation); } }
    public new System.Windows.Automation.TablePattern.TablePatternInformation Current { get { return default(System.Windows.Automation.TablePattern.TablePatternInformation); } }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct TablePatternInformation {
      public int ColumnCount { get { return default(int); } }
      public int RowCount { get { return default(int); } }
      public System.Windows.Automation.RowOrColumnMajor RowOrColumnMajor { get { return default(System.Windows.Automation.RowOrColumnMajor); } }
      public System.Windows.Automation.AutomationElement[] GetColumnHeaders() { return default(System.Windows.Automation.AutomationElement[]); }
      public System.Windows.Automation.AutomationElement[] GetRowHeaders() { return default(System.Windows.Automation.AutomationElement[]); }
    }
  }
  public partial class TextPattern : System.Windows.Automation.BasePattern {
    internal TextPattern() { }
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
    public System.Windows.Automation.Text.TextPatternRange DocumentRange { get { return default(System.Windows.Automation.Text.TextPatternRange); } }
    public System.Windows.Automation.SupportedTextSelection SupportedTextSelection { get { return default(System.Windows.Automation.SupportedTextSelection); } }
    public System.Windows.Automation.Text.TextPatternRange[] GetSelection() { return default(System.Windows.Automation.Text.TextPatternRange[]); }
    public System.Windows.Automation.Text.TextPatternRange[] GetVisibleRanges() { return default(System.Windows.Automation.Text.TextPatternRange[]); }
    public System.Windows.Automation.Text.TextPatternRange RangeFromChild(System.Windows.Automation.AutomationElement childElement) { return default(System.Windows.Automation.Text.TextPatternRange); }
    public System.Windows.Automation.Text.TextPatternRange RangeFromPoint(System.Windows.Point screenLocation) { return default(System.Windows.Automation.Text.TextPatternRange); }
  }
  public partial class TogglePattern : System.Windows.Automation.BasePattern {
    internal TogglePattern() { }
    public static readonly System.Windows.Automation.AutomationPattern Pattern;
    public static readonly System.Windows.Automation.AutomationProperty ToggleStateProperty;
    public System.Windows.Automation.TogglePattern.TogglePatternInformation Cached { get { return default(System.Windows.Automation.TogglePattern.TogglePatternInformation); } }
    public System.Windows.Automation.TogglePattern.TogglePatternInformation Current { get { return default(System.Windows.Automation.TogglePattern.TogglePatternInformation); } }
    public void Toggle() { }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct TogglePatternInformation {
      public System.Windows.Automation.ToggleState ToggleState { get { return default(System.Windows.Automation.ToggleState); } }
    }
  }
  public partial class TransformPattern : System.Windows.Automation.BasePattern {
    internal TransformPattern() { }
    public static readonly System.Windows.Automation.AutomationProperty CanMoveProperty;
    public static readonly System.Windows.Automation.AutomationProperty CanResizeProperty;
    public static readonly System.Windows.Automation.AutomationProperty CanRotateProperty;
    public static readonly System.Windows.Automation.AutomationPattern Pattern;
    public System.Windows.Automation.TransformPattern.TransformPatternInformation Cached { get { return default(System.Windows.Automation.TransformPattern.TransformPatternInformation); } }
    public System.Windows.Automation.TransformPattern.TransformPatternInformation Current { get { return default(System.Windows.Automation.TransformPattern.TransformPatternInformation); } }
    public void Move(double x, double y) { }
    public void Resize(double width, double height) { }
    public void Rotate(double degrees) { }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct TransformPatternInformation {
      public bool CanMove { get { return default(bool); } }
      public bool CanResize { get { return default(bool); } }
      public bool CanRotate { get { return default(bool); } }
    }
  }
  public sealed partial class TreeWalker {
    public static readonly System.Windows.Automation.TreeWalker ContentViewWalker;
    public static readonly System.Windows.Automation.TreeWalker ControlViewWalker;
    public static readonly System.Windows.Automation.TreeWalker RawViewWalker;
    public TreeWalker(System.Windows.Automation.Condition condition) { }
    public System.Windows.Automation.Condition Condition { get { return default(System.Windows.Automation.Condition); } }
    public System.Windows.Automation.AutomationElement GetFirstChild(System.Windows.Automation.AutomationElement element) { return default(System.Windows.Automation.AutomationElement); }
    public System.Windows.Automation.AutomationElement GetFirstChild(System.Windows.Automation.AutomationElement element, System.Windows.Automation.CacheRequest request) { return default(System.Windows.Automation.AutomationElement); }
    public System.Windows.Automation.AutomationElement GetLastChild(System.Windows.Automation.AutomationElement element) { return default(System.Windows.Automation.AutomationElement); }
    public System.Windows.Automation.AutomationElement GetLastChild(System.Windows.Automation.AutomationElement element, System.Windows.Automation.CacheRequest request) { return default(System.Windows.Automation.AutomationElement); }
    public System.Windows.Automation.AutomationElement GetNextSibling(System.Windows.Automation.AutomationElement element) { return default(System.Windows.Automation.AutomationElement); }
    public System.Windows.Automation.AutomationElement GetNextSibling(System.Windows.Automation.AutomationElement element, System.Windows.Automation.CacheRequest request) { return default(System.Windows.Automation.AutomationElement); }
    public System.Windows.Automation.AutomationElement GetParent(System.Windows.Automation.AutomationElement element) { return default(System.Windows.Automation.AutomationElement); }
    public System.Windows.Automation.AutomationElement GetParent(System.Windows.Automation.AutomationElement element, System.Windows.Automation.CacheRequest request) { return default(System.Windows.Automation.AutomationElement); }
    public System.Windows.Automation.AutomationElement GetPreviousSibling(System.Windows.Automation.AutomationElement element) { return default(System.Windows.Automation.AutomationElement); }
    public System.Windows.Automation.AutomationElement GetPreviousSibling(System.Windows.Automation.AutomationElement element, System.Windows.Automation.CacheRequest request) { return default(System.Windows.Automation.AutomationElement); }
    public System.Windows.Automation.AutomationElement Normalize(System.Windows.Automation.AutomationElement element) { return default(System.Windows.Automation.AutomationElement); }
    public System.Windows.Automation.AutomationElement Normalize(System.Windows.Automation.AutomationElement element, System.Windows.Automation.CacheRequest request) { return default(System.Windows.Automation.AutomationElement); }
  }
  public partial class ValuePattern : System.Windows.Automation.BasePattern {
    internal ValuePattern() { }
    public static readonly System.Windows.Automation.AutomationProperty IsReadOnlyProperty;
    public static readonly System.Windows.Automation.AutomationPattern Pattern;
    public static readonly System.Windows.Automation.AutomationProperty ValueProperty;
    public System.Windows.Automation.ValuePattern.ValuePatternInformation Cached { get { return default(System.Windows.Automation.ValuePattern.ValuePatternInformation); } }
    public System.Windows.Automation.ValuePattern.ValuePatternInformation Current { get { return default(System.Windows.Automation.ValuePattern.ValuePatternInformation); } }
    public void SetValue(string value) { }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct ValuePatternInformation {
      public bool IsReadOnly { get { return default(bool); } }
      public string Value { get { return default(string); } }
    }
  }
  public partial class VirtualizedItemPattern : System.Windows.Automation.BasePattern {
    internal VirtualizedItemPattern() { }
    public static readonly System.Windows.Automation.AutomationPattern Pattern;
    public void Realize() { }
  }
  public partial class WindowPattern : System.Windows.Automation.BasePattern {
    internal WindowPattern() { }
    public static readonly System.Windows.Automation.AutomationProperty CanMaximizeProperty;
    public static readonly System.Windows.Automation.AutomationProperty CanMinimizeProperty;
    public static readonly System.Windows.Automation.AutomationProperty IsModalProperty;
    public static readonly System.Windows.Automation.AutomationProperty IsTopmostProperty;
    public static readonly System.Windows.Automation.AutomationPattern Pattern;
    public static readonly System.Windows.Automation.AutomationEvent WindowClosedEvent;
    public static readonly System.Windows.Automation.AutomationProperty WindowInteractionStateProperty;
    public static readonly System.Windows.Automation.AutomationEvent WindowOpenedEvent;
    public static readonly System.Windows.Automation.AutomationProperty WindowVisualStateProperty;
    public System.Windows.Automation.WindowPattern.WindowPatternInformation Cached { get { return default(System.Windows.Automation.WindowPattern.WindowPatternInformation); } }
    public System.Windows.Automation.WindowPattern.WindowPatternInformation Current { get { return default(System.Windows.Automation.WindowPattern.WindowPatternInformation); } }
    public void Close() { }
    public void SetWindowVisualState(System.Windows.Automation.WindowVisualState state) { }
    public bool WaitForInputIdle(int milliseconds) { return default(bool); }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct WindowPatternInformation {
      public bool CanMaximize { get { return default(bool); } }
      public bool CanMinimize { get { return default(bool); } }
      public bool IsModal { get { return default(bool); } }
      public bool IsTopmost { get { return default(bool); } }
      public System.Windows.Automation.WindowInteractionState WindowInteractionState { get { return default(System.Windows.Automation.WindowInteractionState); } }
      public System.Windows.Automation.WindowVisualState WindowVisualState { get { return default(System.Windows.Automation.WindowVisualState); } }
    }
  }
}
namespace System.Windows.Automation.Text {
  public partial class TextPatternRange {
    internal TextPatternRange() { }
    public System.Windows.Automation.TextPattern TextPattern { get { return default(System.Windows.Automation.TextPattern); } }
    public void AddToSelection() { }
    public System.Windows.Automation.Text.TextPatternRange Clone() { return default(System.Windows.Automation.Text.TextPatternRange); }
    public bool Compare(System.Windows.Automation.Text.TextPatternRange range) { return default(bool); }
    public int CompareEndpoints(System.Windows.Automation.Text.TextPatternRangeEndpoint endpoint, System.Windows.Automation.Text.TextPatternRange targetRange, System.Windows.Automation.Text.TextPatternRangeEndpoint targetEndpoint) { return default(int); }
    public void ExpandToEnclosingUnit(System.Windows.Automation.Text.TextUnit unit) { }
    public System.Windows.Automation.Text.TextPatternRange FindAttribute(System.Windows.Automation.AutomationTextAttribute attribute, object value, bool backward) { return default(System.Windows.Automation.Text.TextPatternRange); }
    public System.Windows.Automation.Text.TextPatternRange FindText(string text, bool backward, bool ignoreCase) { return default(System.Windows.Automation.Text.TextPatternRange); }
    public object GetAttributeValue(System.Windows.Automation.AutomationTextAttribute attribute) { return default(object); }
    public System.Windows.Rect[] GetBoundingRectangles() { return default(System.Windows.Rect[]); }
    public System.Windows.Automation.AutomationElement[] GetChildren() { return default(System.Windows.Automation.AutomationElement[]); }
    public System.Windows.Automation.AutomationElement GetEnclosingElement() { return default(System.Windows.Automation.AutomationElement); }
    public string GetText(int maxLength) { return default(string); }
    public int Move(System.Windows.Automation.Text.TextUnit unit, int count) { return default(int); }
    public void MoveEndpointByRange(System.Windows.Automation.Text.TextPatternRangeEndpoint endpoint, System.Windows.Automation.Text.TextPatternRange targetRange, System.Windows.Automation.Text.TextPatternRangeEndpoint targetEndpoint) { }
    public int MoveEndpointByUnit(System.Windows.Automation.Text.TextPatternRangeEndpoint endpoint, System.Windows.Automation.Text.TextUnit unit, int count) { return default(int); }
    public void RemoveFromSelection() { }
    public void ScrollIntoView(bool alignToTop) { }
    public void Select() { }
  }
}
