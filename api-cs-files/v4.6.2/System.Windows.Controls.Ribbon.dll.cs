namespace Microsoft.Windows.Input {
  public partial interface IPreviewCommand : System.Windows.Input.ICommand {
    void CancelPreview();
    void Preview(object parameter);
  }
  public partial interface IPreviewCommandSource : System.Windows.Input.ICommandSource {
    object PreviewCommandParameter { get; }
  }
}
namespace System.Windows.Automation.Peers {
  public partial class RibbonApplicationMenuAutomationPeer : System.Windows.Automation.Peers.RibbonMenuButtonAutomationPeer {
    public RibbonApplicationMenuAutomationPeer(System.Windows.Controls.Ribbon.RibbonApplicationMenu owner) : base (default(System.Windows.Controls.Ribbon.RibbonMenuButton)) { }
    protected override System.Collections.Generic.List<System.Windows.Automation.Peers.AutomationPeer> GetChildrenCore() { return default(System.Collections.Generic.List<System.Windows.Automation.Peers.AutomationPeer>); }
  }
  public partial class RibbonAutomationPeer : System.Windows.Automation.Peers.SelectorAutomationPeer, System.Windows.Automation.Provider.IExpandCollapseProvider, System.Windows.Automation.Provider.ISelectionProvider {
    public RibbonAutomationPeer(System.Windows.Controls.Ribbon.Ribbon owner) : base (default(System.Windows.Controls.Primitives.Selector)) { }
    public System.Windows.Automation.ExpandCollapseState ExpandCollapseState { get { return default(System.Windows.Automation.ExpandCollapseState); } }
    bool System.Windows.Automation.Provider.ISelectionProvider.CanSelectMultiple { get { return default(bool); } }
    bool System.Windows.Automation.Provider.ISelectionProvider.IsSelectionRequired { get { return default(bool); } }
    public void Collapse() { }
    protected override System.Windows.Automation.Peers.ItemAutomationPeer CreateItemAutomationPeer(object item) { return default(System.Windows.Automation.Peers.ItemAutomationPeer); }
    public void Expand() { }
    protected override System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore() { return default(System.Windows.Automation.Peers.AutomationControlType); }
    protected override System.Collections.Generic.List<System.Windows.Automation.Peers.AutomationPeer> GetChildrenCore() { return default(System.Collections.Generic.List<System.Windows.Automation.Peers.AutomationPeer>); }
    protected override string GetClassNameCore() { return default(string); }
    public override object GetPattern(System.Windows.Automation.Peers.PatternInterface patternInterface) { return default(object); }
    protected override bool IsOffscreenCore() { return default(bool); }
    protected override void SetFocusCore() { }
  }
  public partial class RibbonButtonAutomationPeer : System.Windows.Automation.Peers.ButtonAutomationPeer {
    public RibbonButtonAutomationPeer(System.Windows.Controls.Ribbon.RibbonButton owner) : base (default(System.Windows.Controls.Button)) { }
    protected override string GetAccessKeyCore() { return default(string); }
    protected override string GetClassNameCore() { return default(string); }
    protected override string GetHelpTextCore() { return default(string); }
    protected override string GetNameCore() { return default(string); }
  }
  public partial class RibbonCheckBoxAutomationPeer : System.Windows.Automation.Peers.CheckBoxAutomationPeer {
    public RibbonCheckBoxAutomationPeer(System.Windows.Controls.Ribbon.RibbonCheckBox owner) : base (default(System.Windows.Controls.CheckBox)) { }
    protected override string GetAccessKeyCore() { return default(string); }
    protected override string GetClassNameCore() { return default(string); }
    protected override string GetHelpTextCore() { return default(string); }
    protected override string GetNameCore() { return default(string); }
  }
  public partial class RibbonComboBoxAutomationPeer : System.Windows.Automation.Peers.RibbonMenuButtonAutomationPeer, System.Windows.Automation.Provider.IValueProvider {
    public RibbonComboBoxAutomationPeer(System.Windows.Controls.Ribbon.RibbonComboBox owner) : base (default(System.Windows.Controls.Ribbon.RibbonMenuButton)) { }
    public bool IsReadOnly { get { return default(bool); } }
    public string Value { get { return default(string); } }
    protected override System.Collections.Generic.List<System.Windows.Automation.Peers.AutomationPeer> GetChildrenCore() { return default(System.Collections.Generic.List<System.Windows.Automation.Peers.AutomationPeer>); }
    public override object GetPattern(System.Windows.Automation.Peers.PatternInterface patternInterface) { return default(object); }
    protected override void SetFocusCore() { }
    public void SetValue(string value) { }
  }
  public partial class RibbonContextMenuAutomationPeer : System.Windows.Automation.Peers.ItemsControlAutomationPeer {
    public RibbonContextMenuAutomationPeer(System.Windows.Controls.Ribbon.RibbonContextMenu owner) : base (default(System.Windows.Controls.ItemsControl)) { }
    protected override System.Windows.Automation.Peers.ItemAutomationPeer CreateItemAutomationPeer(object item) { return default(System.Windows.Automation.Peers.ItemAutomationPeer); }
    protected override System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore() { return default(System.Windows.Automation.Peers.AutomationControlType); }
    protected override string GetClassNameCore() { return default(string); }
    protected override bool IsContentElementCore() { return default(bool); }
  }
  public partial class RibbonContextualTabGroupAutomationPeer : System.Windows.Automation.Peers.FrameworkElementAutomationPeer {
    public RibbonContextualTabGroupAutomationPeer(System.Windows.Controls.Ribbon.RibbonContextualTabGroup owner) : base (default(System.Windows.FrameworkElement)) { }
    protected override string GetClassNameCore() { return default(string); }
    protected override string GetNameCore() { return default(string); }
  }
  public partial class RibbonContextualTabGroupDataAutomationPeer : System.Windows.Automation.Peers.ItemAutomationPeer, System.Windows.Automation.Provider.IInvokeProvider {
    public RibbonContextualTabGroupDataAutomationPeer(object item, System.Windows.Automation.Peers.RibbonContextualTabGroupItemsControlAutomationPeer owner) : base (default(object), default(System.Windows.Automation.Peers.ItemsControlAutomationPeer)) { }
    protected override System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore() { return default(System.Windows.Automation.Peers.AutomationControlType); }
    protected override string GetClassNameCore() { return default(string); }
    public override object GetPattern(System.Windows.Automation.Peers.PatternInterface patternInterface) { return default(object); }
    protected override bool IsContentElementCore() { return default(bool); }
    void System.Windows.Automation.Provider.IInvokeProvider.Invoke() { }
  }
  public partial class RibbonContextualTabGroupItemsControlAutomationPeer : System.Windows.Automation.Peers.ItemsControlAutomationPeer {
    public RibbonContextualTabGroupItemsControlAutomationPeer(System.Windows.Controls.Ribbon.RibbonContextualTabGroupItemsControl owner) : base (default(System.Windows.Controls.ItemsControl)) { }
    protected override System.Windows.Automation.Peers.ItemAutomationPeer CreateItemAutomationPeer(object item) { return default(System.Windows.Automation.Peers.ItemAutomationPeer); }
    public override object GetPattern(System.Windows.Automation.Peers.PatternInterface patternInterface) { return default(object); }
  }
  public partial class RibbonControlAutomationPeer : System.Windows.Automation.Peers.FrameworkElementAutomationPeer {
    public RibbonControlAutomationPeer(System.Windows.FrameworkElement owner) : base (default(System.Windows.FrameworkElement)) { }
    protected override string GetClassNameCore() { return default(string); }
  }
  public partial class RibbonControlDataAutomationPeer : System.Windows.Automation.Peers.ItemAutomationPeer {
    public RibbonControlDataAutomationPeer(object item, System.Windows.Automation.Peers.ItemsControlAutomationPeer itemsControlPeer) : base (default(object), default(System.Windows.Automation.Peers.ItemsControlAutomationPeer)) { }
    protected override System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore() { return default(System.Windows.Automation.Peers.AutomationControlType); }
    protected override string GetClassNameCore() { return default(string); }
    public override object GetPattern(System.Windows.Automation.Peers.PatternInterface patternInterface) { return default(object); }
  }
  public partial class RibbonControlGroupAutomationPeer : System.Windows.Automation.Peers.ItemsControlAutomationPeer {
    public RibbonControlGroupAutomationPeer(System.Windows.Controls.Ribbon.RibbonControlGroup owner) : base (default(System.Windows.Controls.ItemsControl)) { }
    protected override System.Windows.Automation.Peers.ItemAutomationPeer CreateItemAutomationPeer(object item) { return default(System.Windows.Automation.Peers.ItemAutomationPeer); }
    protected override System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore() { return default(System.Windows.Automation.Peers.AutomationControlType); }
    protected override string GetClassNameCore() { return default(string); }
  }
  public partial class RibbonGalleryAutomationPeer : System.Windows.Automation.Peers.ItemsControlAutomationPeer, System.Windows.Automation.Provider.ISelectionProvider {
    public RibbonGalleryAutomationPeer(System.Windows.Controls.Ribbon.RibbonGallery owner) : base (default(System.Windows.Controls.ItemsControl)) { }
    bool System.Windows.Automation.Provider.ISelectionProvider.CanSelectMultiple { get { return default(bool); } }
    bool System.Windows.Automation.Provider.ISelectionProvider.IsSelectionRequired { get { return default(bool); } }
    protected override System.Windows.Automation.Peers.ItemAutomationPeer CreateItemAutomationPeer(object item) { return default(System.Windows.Automation.Peers.ItemAutomationPeer); }
    protected override System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore() { return default(System.Windows.Automation.Peers.AutomationControlType); }
    protected override System.Collections.Generic.List<System.Windows.Automation.Peers.AutomationPeer> GetChildrenCore() { return default(System.Collections.Generic.List<System.Windows.Automation.Peers.AutomationPeer>); }
    protected override string GetClassNameCore() { return default(string); }
    protected override string GetHelpTextCore() { return default(string); }
    public override object GetPattern(System.Windows.Automation.Peers.PatternInterface patternInterface) { return default(object); }
    System.Windows.Automation.Provider.IRawElementProviderSimple[] System.Windows.Automation.Provider.ISelectionProvider.GetSelection() { return default(System.Windows.Automation.Provider.IRawElementProviderSimple[]); }
  }
  public partial class RibbonGalleryCategoryAutomationPeer : System.Windows.Automation.Peers.ItemsControlAutomationPeer {
    public RibbonGalleryCategoryAutomationPeer(System.Windows.Controls.Ribbon.RibbonGalleryCategory owner) : base (default(System.Windows.Controls.ItemsControl)) { }
    protected override System.Windows.Automation.Peers.ItemAutomationPeer CreateItemAutomationPeer(object item) { return default(System.Windows.Automation.Peers.ItemAutomationPeer); }
    protected override System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore() { return default(System.Windows.Automation.Peers.AutomationControlType); }
    protected override System.Collections.Generic.List<System.Windows.Automation.Peers.AutomationPeer> GetChildrenCore() { return default(System.Collections.Generic.List<System.Windows.Automation.Peers.AutomationPeer>); }
    protected override string GetClassNameCore() { return default(string); }
    public override object GetPattern(System.Windows.Automation.Peers.PatternInterface patternInterface) { return default(object); }
  }
  public partial class RibbonGalleryCategoryDataAutomationPeer : System.Windows.Automation.Peers.ItemAutomationPeer, System.Windows.Automation.Provider.IScrollItemProvider {
    public RibbonGalleryCategoryDataAutomationPeer(object owner, System.Windows.Automation.Peers.ItemsControlAutomationPeer itemsControlAutomationPeer) : base (default(object), default(System.Windows.Automation.Peers.ItemsControlAutomationPeer)) { }
    protected override System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore() { return default(System.Windows.Automation.Peers.AutomationControlType); }
    protected override string GetClassNameCore() { return default(string); }
    public override object GetPattern(System.Windows.Automation.Peers.PatternInterface patternInterface) { return default(object); }
    void System.Windows.Automation.Provider.IScrollItemProvider.ScrollIntoView() { }
  }
  public partial class RibbonGalleryItemAutomationPeer : System.Windows.Automation.Peers.FrameworkElementAutomationPeer {
    public RibbonGalleryItemAutomationPeer(System.Windows.Controls.Ribbon.RibbonGalleryItem owner) : base (default(System.Windows.FrameworkElement)) { }
    protected override string GetAccessKeyCore() { return default(string); }
    protected override System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore() { return default(System.Windows.Automation.Peers.AutomationControlType); }
    protected override string GetClassNameCore() { return default(string); }
    protected override string GetHelpTextCore() { return default(string); }
  }
  public partial class RibbonGalleryItemDataAutomationPeer : System.Windows.Automation.Peers.ItemAutomationPeer, System.Windows.Automation.Provider.IScrollItemProvider, System.Windows.Automation.Provider.ISelectionItemProvider {
    public RibbonGalleryItemDataAutomationPeer(object owner, System.Windows.Automation.Peers.ItemsControlAutomationPeer itemsControlAutomationPeer, System.Windows.Automation.Peers.RibbonGalleryCategoryDataAutomationPeer parentCategoryDataAutomationPeer) : base (default(object), default(System.Windows.Automation.Peers.ItemsControlAutomationPeer)) { }
    public System.Windows.Automation.Peers.RibbonGalleryCategoryDataAutomationPeer ParentCategoryDataAutomationPeer { get { return default(System.Windows.Automation.Peers.RibbonGalleryCategoryDataAutomationPeer); } }
    bool System.Windows.Automation.Provider.ISelectionItemProvider.IsSelected { get { return default(bool); } }
    System.Windows.Automation.Provider.IRawElementProviderSimple System.Windows.Automation.Provider.ISelectionItemProvider.SelectionContainer { get { return default(System.Windows.Automation.Provider.IRawElementProviderSimple); } }
    protected override System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore() { return default(System.Windows.Automation.Peers.AutomationControlType); }
    protected override string GetClassNameCore() { return default(string); }
    public override object GetPattern(System.Windows.Automation.Peers.PatternInterface patternInterface) { return default(object); }
    void System.Windows.Automation.Provider.IScrollItemProvider.ScrollIntoView() { }
    void System.Windows.Automation.Provider.ISelectionItemProvider.AddToSelection() { }
    void System.Windows.Automation.Provider.ISelectionItemProvider.RemoveFromSelection() { }
    void System.Windows.Automation.Provider.ISelectionItemProvider.Select() { }
  }
  public partial class RibbonGroupAutomationPeer : System.Windows.Automation.Peers.ItemsControlAutomationPeer {
    public RibbonGroupAutomationPeer(System.Windows.Controls.Ribbon.RibbonGroup owner) : base (default(System.Windows.Controls.ItemsControl)) { }
    protected override System.Windows.Automation.Peers.ItemAutomationPeer CreateItemAutomationPeer(object item) { return default(System.Windows.Automation.Peers.ItemAutomationPeer); }
    protected override System.Collections.Generic.List<System.Windows.Automation.Peers.AutomationPeer> GetChildrenCore() { return default(System.Collections.Generic.List<System.Windows.Automation.Peers.AutomationPeer>); }
    protected override string GetClassNameCore() { return default(string); }
    public override object GetPattern(System.Windows.Automation.Peers.PatternInterface patternInterface) { return default(object); }
    protected override void SetFocusCore() { }
  }
  public partial class RibbonGroupDataAutomationPeer : System.Windows.Automation.Peers.ItemAutomationPeer, System.Windows.Automation.Provider.IExpandCollapseProvider, System.Windows.Automation.Provider.IScrollItemProvider {
    public RibbonGroupDataAutomationPeer(object item, System.Windows.Automation.Peers.RibbonTabAutomationPeer itemsControlPeer) : base (default(object), default(System.Windows.Automation.Peers.ItemsControlAutomationPeer)) { }
    System.Windows.Automation.ExpandCollapseState System.Windows.Automation.Provider.IExpandCollapseProvider.ExpandCollapseState { get { return default(System.Windows.Automation.ExpandCollapseState); } }
    protected override System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore() { return default(System.Windows.Automation.Peers.AutomationControlType); }
    protected override string GetClassNameCore() { return default(string); }
    public override object GetPattern(System.Windows.Automation.Peers.PatternInterface patternInterface) { return default(object); }
    void System.Windows.Automation.Provider.IExpandCollapseProvider.Collapse() { }
    void System.Windows.Automation.Provider.IExpandCollapseProvider.Expand() { }
    void System.Windows.Automation.Provider.IScrollItemProvider.ScrollIntoView() { }
  }
  public partial class RibbonGroupHeaderAutomationPeer : System.Windows.Automation.Peers.FrameworkElementAutomationPeer {
    public RibbonGroupHeaderAutomationPeer(System.Windows.FrameworkElement owner) : base (default(System.Windows.FrameworkElement)) { }
    protected override System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore() { return default(System.Windows.Automation.Peers.AutomationControlType); }
    protected override string GetClassNameCore() { return default(string); }
    protected override string GetNameCore() { return default(string); }
    protected override bool IsContentElementCore() { return default(bool); }
  }
  public partial class RibbonMenuButtonAutomationPeer : System.Windows.Automation.Peers.ItemsControlAutomationPeer, System.Windows.Automation.Provider.IExpandCollapseProvider, System.Windows.Automation.Provider.ITransformProvider {
    public RibbonMenuButtonAutomationPeer(System.Windows.Controls.Ribbon.RibbonMenuButton owner) : base (default(System.Windows.Controls.ItemsControl)) { }
    System.Windows.Automation.ExpandCollapseState System.Windows.Automation.Provider.IExpandCollapseProvider.ExpandCollapseState { get { return default(System.Windows.Automation.ExpandCollapseState); } }
    bool System.Windows.Automation.Provider.ITransformProvider.CanMove { get { return default(bool); } }
    bool System.Windows.Automation.Provider.ITransformProvider.CanResize { get { return default(bool); } }
    bool System.Windows.Automation.Provider.ITransformProvider.CanRotate { get { return default(bool); } }
    protected override System.Windows.Automation.Peers.ItemAutomationPeer CreateItemAutomationPeer(object item) { return default(System.Windows.Automation.Peers.ItemAutomationPeer); }
    protected override string GetAccessKeyCore() { return default(string); }
    protected override System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore() { return default(System.Windows.Automation.Peers.AutomationControlType); }
    protected override System.Collections.Generic.List<System.Windows.Automation.Peers.AutomationPeer> GetChildrenCore() { return default(System.Collections.Generic.List<System.Windows.Automation.Peers.AutomationPeer>); }
    protected override string GetClassNameCore() { return default(string); }
    protected override string GetHelpTextCore() { return default(string); }
    protected override string GetNameCore() { return default(string); }
    public override object GetPattern(System.Windows.Automation.Peers.PatternInterface patternInterface) { return default(object); }
    void System.Windows.Automation.Provider.IExpandCollapseProvider.Collapse() { }
    void System.Windows.Automation.Provider.IExpandCollapseProvider.Expand() { }
    void System.Windows.Automation.Provider.ITransformProvider.Move(double x, double y) { }
    void System.Windows.Automation.Provider.ITransformProvider.Resize(double width, double height) { }
    void System.Windows.Automation.Provider.ITransformProvider.Rotate(double degrees) { }
  }
  public partial class RibbonMenuItemAutomationPeer : System.Windows.Automation.Peers.ItemsControlAutomationPeer {
    public RibbonMenuItemAutomationPeer(System.Windows.Controls.Ribbon.RibbonMenuItem owner) : base (default(System.Windows.Controls.ItemsControl)) { }
    protected override System.Windows.Automation.Peers.ItemAutomationPeer CreateItemAutomationPeer(object item) { return default(System.Windows.Automation.Peers.ItemAutomationPeer); }
    protected override string GetAccessKeyCore() { return default(string); }
    protected override System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore() { return default(System.Windows.Automation.Peers.AutomationControlType); }
    protected override string GetClassNameCore() { return default(string); }
    protected override string GetHelpTextCore() { return default(string); }
  }
  public partial class RibbonMenuItemDataAutomationPeer : System.Windows.Automation.Peers.ItemAutomationPeer, System.Windows.Automation.Provider.IExpandCollapseProvider, System.Windows.Automation.Provider.IInvokeProvider, System.Windows.Automation.Provider.IToggleProvider, System.Windows.Automation.Provider.ITransformProvider {
    public RibbonMenuItemDataAutomationPeer(object item, System.Windows.Automation.Peers.ItemsControlAutomationPeer itemsControlPeer) : base (default(object), default(System.Windows.Automation.Peers.ItemsControlAutomationPeer)) { }
    System.Windows.Automation.ExpandCollapseState System.Windows.Automation.Provider.IExpandCollapseProvider.ExpandCollapseState { get { return default(System.Windows.Automation.ExpandCollapseState); } }
    System.Windows.Automation.ToggleState System.Windows.Automation.Provider.IToggleProvider.ToggleState { get { return default(System.Windows.Automation.ToggleState); } }
    bool System.Windows.Automation.Provider.ITransformProvider.CanMove { get { return default(bool); } }
    bool System.Windows.Automation.Provider.ITransformProvider.CanResize { get { return default(bool); } }
    bool System.Windows.Automation.Provider.ITransformProvider.CanRotate { get { return default(bool); } }
    protected override System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore() { return default(System.Windows.Automation.Peers.AutomationControlType); }
    protected override string GetClassNameCore() { return default(string); }
    public override object GetPattern(System.Windows.Automation.Peers.PatternInterface patternInterface) { return default(object); }
    void System.Windows.Automation.Provider.IExpandCollapseProvider.Collapse() { }
    void System.Windows.Automation.Provider.IExpandCollapseProvider.Expand() { }
    void System.Windows.Automation.Provider.IInvokeProvider.Invoke() { }
    void System.Windows.Automation.Provider.IToggleProvider.Toggle() { }
    void System.Windows.Automation.Provider.ITransformProvider.Move(double x, double y) { }
    void System.Windows.Automation.Provider.ITransformProvider.Resize(double width, double height) { }
    void System.Windows.Automation.Provider.ITransformProvider.Rotate(double degrees) { }
  }
  public partial class RibbonQuickAccessToolBarAutomationPeer : System.Windows.Automation.Peers.ItemsControlAutomationPeer, System.Windows.Automation.Provider.IExpandCollapseProvider {
    public RibbonQuickAccessToolBarAutomationPeer(System.Windows.Controls.Ribbon.RibbonQuickAccessToolBar owner) : base (default(System.Windows.Controls.ItemsControl)) { }
    public System.Windows.Automation.ExpandCollapseState ExpandCollapseState { get { return default(System.Windows.Automation.ExpandCollapseState); } }
    public void Collapse() { }
    protected override System.Windows.Automation.Peers.ItemAutomationPeer CreateItemAutomationPeer(object item) { return default(System.Windows.Automation.Peers.ItemAutomationPeer); }
    public void Expand() { }
    protected override System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore() { return default(System.Windows.Automation.Peers.AutomationControlType); }
    protected override System.Collections.Generic.List<System.Windows.Automation.Peers.AutomationPeer> GetChildrenCore() { return default(System.Collections.Generic.List<System.Windows.Automation.Peers.AutomationPeer>); }
    protected override string GetClassNameCore() { return default(string); }
    public override object GetPattern(System.Windows.Automation.Peers.PatternInterface patternInterface) { return default(object); }
  }
  public partial class RibbonRadioButtonAutomationPeer : System.Windows.Automation.Peers.RadioButtonAutomationPeer {
    public RibbonRadioButtonAutomationPeer(System.Windows.Controls.Ribbon.RibbonRadioButton owner) : base (default(System.Windows.Controls.RadioButton)) { }
    protected override string GetAccessKeyCore() { return default(string); }
    protected override string GetClassNameCore() { return default(string); }
    protected override string GetHelpTextCore() { return default(string); }
    protected override string GetNameCore() { return default(string); }
  }
  public partial class RibbonSeparatorAutomationPeer : System.Windows.Automation.Peers.SeparatorAutomationPeer {
    public RibbonSeparatorAutomationPeer(System.Windows.Controls.Ribbon.RibbonSeparator owner) : base (default(System.Windows.Controls.Separator)) { }
    protected override string GetClassNameCore() { return default(string); }
    protected override string GetNameCore() { return default(string); }
  }
  public partial class RibbonSplitButtonAutomationPeer : System.Windows.Automation.Peers.RibbonMenuButtonAutomationPeer, System.Windows.Automation.Provider.IInvokeProvider, System.Windows.Automation.Provider.IToggleProvider {
    public RibbonSplitButtonAutomationPeer(System.Windows.Controls.Ribbon.RibbonSplitButton owner) : base (default(System.Windows.Controls.Ribbon.RibbonMenuButton)) { }
    System.Windows.Automation.ToggleState System.Windows.Automation.Provider.IToggleProvider.ToggleState { get { return default(System.Windows.Automation.ToggleState); } }
    protected override System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore() { return default(System.Windows.Automation.Peers.AutomationControlType); }
    public override object GetPattern(System.Windows.Automation.Peers.PatternInterface patternInterface) { return default(object); }
    void System.Windows.Automation.Provider.IInvokeProvider.Invoke() { }
    void System.Windows.Automation.Provider.IToggleProvider.Toggle() { }
  }
  public partial class RibbonTabAutomationPeer : System.Windows.Automation.Peers.ItemsControlAutomationPeer {
    public RibbonTabAutomationPeer(System.Windows.Controls.Ribbon.RibbonTab owner) : base (default(System.Windows.Controls.ItemsControl)) { }
    protected override System.Windows.Automation.Peers.ItemAutomationPeer CreateItemAutomationPeer(object item) { return default(System.Windows.Automation.Peers.ItemAutomationPeer); }
    protected override System.Windows.Rect GetBoundingRectangleCore() { return default(System.Windows.Rect); }
    protected override System.Collections.Generic.List<System.Windows.Automation.Peers.AutomationPeer> GetChildrenCore() { return default(System.Collections.Generic.List<System.Windows.Automation.Peers.AutomationPeer>); }
    protected override string GetClassNameCore() { return default(string); }
  }
  public partial class RibbonTabDataAutomationPeer : System.Windows.Automation.Peers.SelectorItemAutomationPeer, System.Windows.Automation.Provider.IExpandCollapseProvider, System.Windows.Automation.Provider.IScrollItemProvider, System.Windows.Automation.Provider.ISelectionItemProvider {
    public RibbonTabDataAutomationPeer(object item, System.Windows.Automation.Peers.RibbonAutomationPeer itemsControlPeer) : base (default(object), default(System.Windows.Automation.Peers.SelectorAutomationPeer)) { }
    System.Windows.Automation.ExpandCollapseState System.Windows.Automation.Provider.IExpandCollapseProvider.ExpandCollapseState { get { return default(System.Windows.Automation.ExpandCollapseState); } }
    protected override System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore() { return default(System.Windows.Automation.Peers.AutomationControlType); }
    protected override string GetClassNameCore() { return default(string); }
    public override object GetPattern(System.Windows.Automation.Peers.PatternInterface patternInterface) { return default(object); }
    void System.Windows.Automation.Provider.IExpandCollapseProvider.Collapse() { }
    void System.Windows.Automation.Provider.IExpandCollapseProvider.Expand() { }
    void System.Windows.Automation.Provider.IScrollItemProvider.ScrollIntoView() { }
    void System.Windows.Automation.Provider.ISelectionItemProvider.AddToSelection() { }
    void System.Windows.Automation.Provider.ISelectionItemProvider.RemoveFromSelection() { }
  }
  public partial class RibbonTabHeaderAutomationPeer : System.Windows.Automation.Peers.FrameworkElementAutomationPeer {
    public RibbonTabHeaderAutomationPeer(System.Windows.Controls.Ribbon.RibbonTabHeader owner) : base (default(System.Windows.FrameworkElement)) { }
    protected override string GetClassNameCore() { return default(string); }
  }
  public partial class RibbonTabHeaderDataAutomationPeer : System.Windows.Automation.Peers.ItemAutomationPeer {
    public RibbonTabHeaderDataAutomationPeer(object item, System.Windows.Automation.Peers.RibbonTabHeaderItemsControlAutomationPeer itemsControlPeer) : base (default(object), default(System.Windows.Automation.Peers.ItemsControlAutomationPeer)) { }
    protected override System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore() { return default(System.Windows.Automation.Peers.AutomationControlType); }
    protected override string GetClassNameCore() { return default(string); }
    public override object GetPattern(System.Windows.Automation.Peers.PatternInterface patternInterface) { return default(object); }
    protected override bool IsContentElementCore() { return default(bool); }
  }
  public partial class RibbonTabHeaderItemsControlAutomationPeer : System.Windows.Automation.Peers.ItemsControlAutomationPeer {
    public RibbonTabHeaderItemsControlAutomationPeer(System.Windows.Controls.Ribbon.RibbonTabHeaderItemsControl owner) : base (default(System.Windows.Controls.ItemsControl)) { }
    protected override System.Windows.Automation.Peers.ItemAutomationPeer CreateItemAutomationPeer(object item) { return default(System.Windows.Automation.Peers.ItemAutomationPeer); }
  }
  public partial class RibbonTextBoxAutomationPeer : System.Windows.Automation.Peers.TextBoxAutomationPeer, System.Windows.Automation.Provider.IInvokeProvider {
    public RibbonTextBoxAutomationPeer(System.Windows.Controls.Ribbon.RibbonTextBox owner) : base (default(System.Windows.Controls.TextBox)) { }
    protected override string GetAcceleratorKeyCore() { return default(string); }
    protected override string GetAccessKeyCore() { return default(string); }
    protected override string GetClassNameCore() { return default(string); }
    protected override string GetHelpTextCore() { return default(string); }
    protected override string GetNameCore() { return default(string); }
    public override object GetPattern(System.Windows.Automation.Peers.PatternInterface patternInterface) { return default(object); }
    void System.Windows.Automation.Provider.IInvokeProvider.Invoke() { }
  }
  public partial class RibbonTitleAutomationPeer : System.Windows.Automation.Peers.FrameworkElementAutomationPeer {
    public RibbonTitleAutomationPeer(System.Windows.FrameworkElement owner) : base (default(System.Windows.FrameworkElement)) { }
    protected override System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore() { return default(System.Windows.Automation.Peers.AutomationControlType); }
    protected override string GetClassNameCore() { return default(string); }
    protected override string GetNameCore() { return default(string); }
    protected override bool IsContentElementCore() { return default(bool); }
  }
  public partial class RibbonToggleButtonAutomationPeer : System.Windows.Automation.Peers.ToggleButtonAutomationPeer {
    public RibbonToggleButtonAutomationPeer(System.Windows.Controls.Ribbon.RibbonToggleButton owner) : base (default(System.Windows.Controls.Primitives.ToggleButton)) { }
    protected override string GetAccessKeyCore() { return default(string); }
    protected override string GetClassNameCore() { return default(string); }
    protected override string GetHelpTextCore() { return default(string); }
    protected override string GetNameCore() { return default(string); }
  }
  public partial class RibbonToolTipAutomationPeer : System.Windows.Automation.Peers.ToolTipAutomationPeer {
    public RibbonToolTipAutomationPeer(System.Windows.Controls.Ribbon.RibbonToolTip owner) : base (default(System.Windows.Controls.ToolTip)) { }
    protected override string GetClassNameCore() { return default(string); }
    protected override string GetNameCore() { return default(string); }
  }
  public partial class RibbonTwoLineTextAutomationPeer : System.Windows.Automation.Peers.FrameworkElementAutomationPeer {
    public RibbonTwoLineTextAutomationPeer(System.Windows.Controls.Ribbon.RibbonTwoLineText owner) : base (default(System.Windows.FrameworkElement)) { }
    protected override System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore() { return default(System.Windows.Automation.Peers.AutomationControlType); }
    protected override string GetClassNameCore() { return default(string); }
    protected override string GetNameCore() { return default(string); }
    protected override bool IsControlElementCore() { return default(bool); }
  }
}
namespace System.Windows.Controls {
  public partial class ActivatingKeyTipEventArgs : System.Windows.RoutedEventArgs {
    public ActivatingKeyTipEventArgs() { }
    public double KeyTipHorizontalOffset { get { return default(double); } set { } }
    public System.Windows.Controls.KeyTipHorizontalPlacement KeyTipHorizontalPlacement { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Windows.Controls.KeyTipHorizontalPlacement); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public double KeyTipVerticalOffset { get { return default(double); } set { } }
    public System.Windows.Controls.KeyTipVerticalPlacement KeyTipVerticalPlacement { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Windows.Controls.KeyTipVerticalPlacement); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Windows.Visibility KeyTipVisibility { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Windows.Visibility); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Windows.UIElement PlacementTarget { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Windows.UIElement); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void InvokeEventHandler(System.Delegate genericHandler, object genericTarget) { }
  }
  public delegate void ActivatingKeyTipEventHandler(object sender, System.Windows.Controls.ActivatingKeyTipEventArgs e);
  public partial class KeyTipAccessedEventArgs : System.Windows.RoutedEventArgs {
    public KeyTipAccessedEventArgs() { }
    public System.Windows.DependencyObject TargetKeyTipScope { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Windows.DependencyObject); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void InvokeEventHandler(System.Delegate genericHandler, object genericTarget) { }
  }
  public delegate void KeyTipAccessedEventHandler(object sender, System.Windows.Controls.KeyTipAccessedEventArgs e);
  public partial class KeyTipControl : System.Windows.Controls.Control {
    public static readonly System.Windows.DependencyProperty TextProperty;
    public KeyTipControl() { }
    public string Text { get { return default(string); } set { } }
  }
  public enum KeyTipHorizontalPlacement {
    KeyTipCenterAtTargetCenter = 4,
    KeyTipCenterAtTargetLeft = 3,
    KeyTipCenterAtTargetRight = 5,
    KeyTipLeftAtTargetCenter = 1,
    KeyTipLeftAtTargetLeft = 0,
    KeyTipLeftAtTargetRight = 2,
    KeyTipRightAtTargetCenter = 7,
    KeyTipRightAtTargetLeft = 6,
    KeyTipRightAtTargetRight = 8,
  }
  public partial class KeyTipService {
    internal KeyTipService() { }
    public static readonly System.Windows.RoutedEvent ActivatingKeyTipEvent;
    public static readonly System.Windows.DependencyProperty IsKeyTipScopeProperty;
    public static readonly System.Windows.RoutedEvent KeyTipAccessedEvent;
    public static readonly System.Windows.DependencyProperty KeyTipProperty;
    public static readonly System.Windows.DependencyProperty KeyTipStyleProperty;
    public static readonly System.Windows.RoutedEvent PreviewKeyTipAccessedEvent;
    public static void AddActivatingKeyTipHandler(System.Windows.DependencyObject element, System.Windows.Controls.ActivatingKeyTipEventHandler handler) { }
    public static void AddKeyTipAccessedHandler(System.Windows.DependencyObject element, System.Windows.Controls.KeyTipAccessedEventHandler handler) { }
    public static void AddPreviewKeyTipAccessedHandler(System.Windows.DependencyObject element, System.Windows.Controls.KeyTipAccessedEventHandler handler) { }
    public static void DismissKeyTips() { }
    public static bool GetIsKeyTipScope(System.Windows.DependencyObject element) { return default(bool); }
    public static string GetKeyTip(System.Windows.DependencyObject element) { return default(string); }
    public static System.Windows.Style GetKeyTipStyle(System.Windows.DependencyObject element) { return default(System.Windows.Style); }
    public static void RemoveActivatingKeyTipHandler(System.Windows.DependencyObject element, System.Windows.Controls.ActivatingKeyTipEventHandler handler) { }
    public static void RemoveKeyTipAccessedHandler(System.Windows.DependencyObject element, System.Windows.Controls.KeyTipAccessedEventHandler handler) { }
    public static void RemovePreviewKeyTipAccessedHandler(System.Windows.DependencyObject element, System.Windows.Controls.KeyTipAccessedEventHandler handler) { }
    public static void SetIsKeyTipScope(System.Windows.DependencyObject element, bool value) { }
    public static void SetKeyTip(System.Windows.DependencyObject element, string value) { }
    public static void SetKeyTipStyle(System.Windows.DependencyObject element, System.Windows.Style value) { }
  }
  public enum KeyTipVerticalPlacement {
    KeyTipBottomAtTargetBottom = 8,
    KeyTipBottomAtTargetCenter = 7,
    KeyTipBottomAtTargetTop = 6,
    KeyTipCenterAtTargetBottom = 5,
    KeyTipCenterAtTargetCenter = 4,
    KeyTipCenterAtTargetTop = 3,
    KeyTipTopAtTargetBottom = 2,
    KeyTipTopAtTargetCenter = 1,
    KeyTipTopAtTargetTop = 0,
  }
}
namespace System.Windows.Controls.Ribbon {
  [System.Windows.StyleTypedPropertyAttribute(Property="ContextualTabGroupStyle", StyleTargetType=typeof(System.Windows.Controls.Ribbon.RibbonContextualTabGroup))]
  [System.Windows.StyleTypedPropertyAttribute(Property="TabHeaderStyle", StyleTargetType=typeof(System.Windows.Controls.Ribbon.RibbonTabHeader))]
  [System.Windows.TemplatePartAttribute(Name="PART_ContextualTabGroupItemsControl", Type=typeof(System.Windows.Controls.Ribbon.RibbonContextualTabGroupItemsControl))]
  [System.Windows.TemplatePartAttribute(Name="PART_HelpPane", Type=typeof(System.Windows.Controls.ContentPresenter))]
  [System.Windows.TemplatePartAttribute(Name="PART_ITEMSPRESENTERPOPUP", Type=typeof(System.Windows.Controls.Primitives.Popup))]
  [System.Windows.TemplatePartAttribute(Name="PART_TitleHost", Type=typeof(System.Windows.Controls.ContentPresenter))]
  [System.Windows.TemplatePartAttribute(Name="PART_TitlePanel", Type=typeof(System.Windows.Controls.Ribbon.Primitives.RibbonTitlePanel))]
  [System.Windows.TemplatePartAttribute(Name="QatTopHost", Type=typeof(System.Windows.Controls.Grid))]
  public partial class Ribbon : System.Windows.Controls.Primitives.Selector {
    public static readonly System.Windows.DependencyProperty ApplicationMenuProperty;
    public static readonly System.Windows.DependencyProperty CheckedBackgroundProperty;
    public static readonly System.Windows.DependencyProperty CheckedBorderBrushProperty;
    public static readonly System.Windows.RoutedEvent CollapsedEvent;
    public static readonly System.Windows.DependencyProperty ContextualTabGroupHeaderTemplateProperty;
    public static readonly System.Windows.DependencyProperty ContextualTabGroupsSourceProperty;
    public static readonly System.Windows.DependencyProperty ContextualTabGroupStyleProperty;
    public static readonly System.Windows.RoutedEvent ExpandedEvent;
    public static readonly System.Windows.DependencyProperty FocusedBackgroundProperty;
    public static readonly System.Windows.DependencyProperty FocusedBorderBrushProperty;
    public static readonly System.Windows.DependencyProperty HelpPaneContentProperty;
    public static readonly System.Windows.DependencyProperty HelpPaneContentTemplateProperty;
    public static readonly System.Windows.DependencyProperty IsCollapsedProperty;
    public static readonly System.Windows.DependencyProperty IsDropDownOpenProperty;
    public static readonly System.Windows.DependencyProperty IsHostedInRibbonWindowProperty;
    public static readonly System.Windows.DependencyProperty IsMinimizedProperty;
    public static readonly System.Windows.DependencyProperty MouseOverBackgroundProperty;
    public static readonly System.Windows.DependencyProperty MouseOverBorderBrushProperty;
    public static readonly System.Windows.DependencyProperty PressedBackgroundProperty;
    public static readonly System.Windows.DependencyProperty PressedBorderBrushProperty;
    public static readonly System.Windows.DependencyProperty QuickAccessToolBarProperty;
    public static readonly System.Windows.DependencyProperty ShowQuickAccessToolBarOnTopProperty;
    public static readonly System.Windows.DependencyProperty TabHeaderStyleProperty;
    public static readonly System.Windows.DependencyProperty TabHeaderTemplateProperty;
    public static readonly System.Windows.DependencyProperty TitleProperty;
    public static readonly System.Windows.DependencyProperty TitleTemplateProperty;
    public static readonly System.Windows.DependencyProperty WindowIconVisibilityProperty;
    public Ribbon() { }
    public System.Windows.Controls.Ribbon.RibbonApplicationMenu ApplicationMenu { get { return default(System.Windows.Controls.Ribbon.RibbonApplicationMenu); } set { } }
    public System.Windows.Media.Brush CheckedBackground { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Media.Brush CheckedBorderBrush { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.DataTemplate ContextualTabGroupHeaderTemplate { get { return default(System.Windows.DataTemplate); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    public System.Collections.ObjectModel.Collection<System.Windows.Controls.Ribbon.RibbonContextualTabGroup> ContextualTabGroups { get { return default(System.Collections.ObjectModel.Collection<System.Windows.Controls.Ribbon.RibbonContextualTabGroup>); } }
    public System.Collections.IEnumerable ContextualTabGroupsSource { get { return default(System.Collections.IEnumerable); } set { } }
    public System.Windows.Style ContextualTabGroupStyle { get { return default(System.Windows.Style); } set { } }
    public System.Windows.Media.Brush FocusedBackground { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Media.Brush FocusedBorderBrush { get { return default(System.Windows.Media.Brush); } set { } }
    public object HelpPaneContent { get { return default(object); } set { } }
    public System.Windows.DataTemplate HelpPaneContentTemplate { get { return default(System.Windows.DataTemplate); } set { } }
    public bool IsCollapsed { get { return default(bool); } set { } }
    public bool IsDropDownOpen { get { return default(bool); } set { } }
    public bool IsHostedInRibbonWindow { get { return default(bool); } }
    public bool IsMinimized { get { return default(bool); } set { } }
    protected internal override System.Collections.IEnumerator LogicalChildren { get { return default(System.Collections.IEnumerator); } }
    public System.Windows.Media.Brush MouseOverBackground { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Media.Brush MouseOverBorderBrush { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Media.Brush PressedBackground { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Media.Brush PressedBorderBrush { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Controls.Ribbon.RibbonQuickAccessToolBar QuickAccessToolBar { get { return default(System.Windows.Controls.Ribbon.RibbonQuickAccessToolBar); } set { } }
    public bool ShowQuickAccessToolBarOnTop { get { return default(bool); } set { } }
    public System.Windows.Style TabHeaderStyle { get { return default(System.Windows.Style); } set { } }
    public System.Windows.DataTemplate TabHeaderTemplate { get { return default(System.Windows.DataTemplate); } set { } }
    public object Title { get { return default(object); } set { } }
    public System.Windows.DataTemplate TitleTemplate { get { return default(System.Windows.DataTemplate); } set { } }
    public System.Windows.Visibility WindowIconVisibility { get { return default(System.Windows.Visibility); } set { } }
    public event System.Windows.RoutedEventHandler Collapsed { add { } remove { } }
    public event System.Windows.RoutedEventHandler Expanded { add { } remove { } }
    protected override System.Windows.DependencyObject GetContainerForItemOverride() { return default(System.Windows.DependencyObject); }
    protected override bool IsItemItsOwnContainerOverride(object item) { return default(bool); }
    public override void OnApplyTemplate() { }
    protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { return default(System.Windows.Automation.Peers.AutomationPeer); }
    protected override void OnItemsChanged(System.Collections.Specialized.NotifyCollectionChangedEventArgs e) { }
    protected override void OnKeyDown(System.Windows.Input.KeyEventArgs e) { }
    protected override void OnMouseDown(System.Windows.Input.MouseButtonEventArgs e) { }
    protected override void OnPreviewMouseDown(System.Windows.Input.MouseButtonEventArgs e) { }
    protected override void OnPreviewMouseWheel(System.Windows.Input.MouseWheelEventArgs e) { }
    protected override void OnSelectionChanged(System.Windows.Controls.SelectionChangedEventArgs e) { }
    protected override void PrepareContainerForItemOverride(System.Windows.DependencyObject element, object item) { }
  }
  [System.Windows.StyleTypedPropertyAttribute(Property="ItemContainerStyle", StyleTargetType=typeof(System.Windows.Controls.Ribbon.RibbonApplicationMenuItem))]
  [System.Windows.TemplatePartAttribute(Name="PART_AuxiliaryPaneContentPresenter", Type=typeof(System.Windows.Controls.ContentPresenter))]
  [System.Windows.TemplatePartAttribute(Name="PART_FooterPaneContentPresenter", Type=typeof(System.Windows.Controls.ContentPresenter))]
  [System.Windows.TemplatePartAttribute(Name="PART_Popup", Type=typeof(System.Windows.Controls.Primitives.Popup))]
  [System.Windows.TemplatePartAttribute(Name="PART_PopupToggleButton", Type=typeof(System.Windows.Controls.Ribbon.RibbonToggleButton))]
  [System.Windows.TemplatePartAttribute(Name="PART_SubmenuPlaceholder", Type=typeof(System.Windows.FrameworkElement))]
  public partial class RibbonApplicationMenu : System.Windows.Controls.Ribbon.RibbonMenuButton {
    public static readonly System.Windows.DependencyProperty AuxiliaryPaneContentProperty;
    public static readonly System.Windows.DependencyProperty AuxiliaryPaneContentTemplateProperty;
    public static readonly System.Windows.DependencyProperty AuxiliaryPaneContentTemplateSelectorProperty;
    public static readonly System.Windows.DependencyProperty FooterPaneContentProperty;
    public static readonly System.Windows.DependencyProperty FooterPaneContentTemplateProperty;
    public static readonly System.Windows.DependencyProperty FooterPaneContentTemplateSelectorProperty;
    public RibbonApplicationMenu() { }
    public object AuxiliaryPaneContent { get { return default(object); } set { } }
    public System.Windows.DataTemplate AuxiliaryPaneContentTemplate { get { return default(System.Windows.DataTemplate); } set { } }
    public System.Windows.Controls.DataTemplateSelector AuxiliaryPaneContentTemplateSelector { get { return default(System.Windows.Controls.DataTemplateSelector); } set { } }
    public object FooterPaneContent { get { return default(object); } set { } }
    public System.Windows.DataTemplate FooterPaneContentTemplate { get { return default(System.Windows.DataTemplate); } set { } }
    public System.Windows.Controls.DataTemplateSelector FooterPaneContentTemplateSelector { get { return default(System.Windows.Controls.DataTemplateSelector); } set { } }
    protected override System.Windows.DependencyObject GetContainerForItemOverride() { return default(System.Windows.DependencyObject); }
    protected override bool IsItemItsOwnContainerOverride(object item) { return default(bool); }
    protected override void OnActivatingKeyTip(System.Windows.Controls.ActivatingKeyTipEventArgs e) { }
    public override void OnApplyTemplate() { }
    protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { return default(System.Windows.Automation.Peers.AutomationPeer); }
    protected override void OnPreviewKeyDown(System.Windows.Input.KeyEventArgs e) { }
    protected override bool ShouldApplyItemContainerStyle(System.Windows.DependencyObject container, object item) { return default(bool); }
  }
  [System.Windows.StyleTypedPropertyAttribute(Property="ItemContainerStyle", StyleTargetType=typeof(System.Windows.Controls.Ribbon.RibbonApplicationMenuItem))]
  public partial class RibbonApplicationMenuItem : System.Windows.Controls.Ribbon.RibbonMenuItem {
    public static readonly System.Windows.DependencyProperty LevelProperty;
    public RibbonApplicationMenuItem() { }
    public System.Windows.Controls.Ribbon.RibbonApplicationMenuItemLevel Level { get { return default(System.Windows.Controls.Ribbon.RibbonApplicationMenuItemLevel); } }
    protected override System.Windows.DependencyObject GetContainerForItemOverride() { return default(System.Windows.DependencyObject); }
    protected override bool IsItemItsOwnContainerOverride(object item) { return default(bool); }
    protected override void OnActivatingKeyTip(System.Windows.Controls.ActivatingKeyTipEventArgs e) { }
    public override void OnApplyTemplate() { }
    protected override void OnKeyDown(System.Windows.Input.KeyEventArgs e) { }
    protected override void PrepareContainerForItemOverride(System.Windows.DependencyObject element, object item) { }
    protected override bool ShouldApplyItemContainerStyle(System.Windows.DependencyObject container, object item) { return default(bool); }
  }
  public enum RibbonApplicationMenuItemLevel {
    Middle = 1,
    Sub = 2,
    Top = 0,
  }
  [System.Windows.StyleTypedPropertyAttribute(Property="ItemContainerStyle", StyleTargetType=typeof(System.Windows.Controls.Ribbon.RibbonApplicationMenuItem))]
  public partial class RibbonApplicationSplitMenuItem : System.Windows.Controls.Ribbon.RibbonSplitMenuItem {
    public static readonly System.Windows.DependencyProperty LevelProperty;
    public RibbonApplicationSplitMenuItem() { }
    public System.Windows.Controls.Ribbon.RibbonApplicationMenuItemLevel Level { get { return default(System.Windows.Controls.Ribbon.RibbonApplicationMenuItemLevel); } }
    protected override System.Windows.DependencyObject GetContainerForItemOverride() { return default(System.Windows.DependencyObject); }
    protected override bool IsItemItsOwnContainerOverride(object item) { return default(bool); }
    protected override void OnActivatingKeyTip(System.Windows.Controls.ActivatingKeyTipEventArgs e) { }
    public override void OnApplyTemplate() { }
    protected override void OnKeyDown(System.Windows.Input.KeyEventArgs e) { }
    protected override void PrepareContainerForItemOverride(System.Windows.DependencyObject element, object item) { }
    protected override bool ShouldApplyItemContainerStyle(System.Windows.DependencyObject container, object item) { return default(bool); }
  }
  [System.Windows.TemplatePartAttribute(Name="PART_Image", Type=typeof(System.Windows.Controls.Image))]
  public partial class RibbonButton : System.Windows.Controls.Button {
    public static readonly System.Windows.DependencyProperty CanAddToQuickAccessToolBarDirectlyProperty;
    public static readonly System.Windows.DependencyProperty ControlSizeDefinitionProperty;
    public static readonly System.Windows.DependencyProperty CornerRadiusProperty;
    public static readonly System.Windows.DependencyProperty FocusedBackgroundProperty;
    public static readonly System.Windows.DependencyProperty FocusedBorderBrushProperty;
    public static readonly System.Windows.DependencyProperty IsInControlGroupProperty;
    public static readonly System.Windows.DependencyProperty IsInQuickAccessToolBarProperty;
    public static readonly System.Windows.DependencyProperty KeyTipProperty;
    public static readonly System.Windows.DependencyProperty LabelProperty;
    public static readonly System.Windows.DependencyProperty LargeImageSourceProperty;
    public static readonly System.Windows.DependencyProperty MouseOverBackgroundProperty;
    public static readonly System.Windows.DependencyProperty MouseOverBorderBrushProperty;
    public static readonly System.Windows.DependencyProperty PressedBackgroundProperty;
    public static readonly System.Windows.DependencyProperty PressedBorderBrushProperty;
    public static readonly System.Windows.DependencyProperty QuickAccessToolBarControlSizeDefinitionProperty;
    public static readonly System.Windows.DependencyProperty QuickAccessToolBarIdProperty;
    public static readonly System.Windows.DependencyProperty RibbonProperty;
    public static readonly System.Windows.DependencyProperty ShowKeyboardCuesProperty;
    public static readonly System.Windows.DependencyProperty SmallImageSourceProperty;
    public static readonly System.Windows.DependencyProperty ToolTipDescriptionProperty;
    public static readonly System.Windows.DependencyProperty ToolTipFooterDescriptionProperty;
    public static readonly System.Windows.DependencyProperty ToolTipFooterImageSourceProperty;
    public static readonly System.Windows.DependencyProperty ToolTipFooterTitleProperty;
    public static readonly System.Windows.DependencyProperty ToolTipImageSourceProperty;
    public static readonly System.Windows.DependencyProperty ToolTipTitleProperty;
    public RibbonButton() { }
    public bool CanAddToQuickAccessToolBarDirectly { get { return default(bool); } set { } }
    public System.Windows.Controls.Ribbon.RibbonControlSizeDefinition ControlSizeDefinition { get { return default(System.Windows.Controls.Ribbon.RibbonControlSizeDefinition); } set { } }
    public System.Windows.CornerRadius CornerRadius { get { return default(System.Windows.CornerRadius); } set { } }
    public System.Windows.Media.Brush FocusedBackground { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Media.Brush FocusedBorderBrush { get { return default(System.Windows.Media.Brush); } set { } }
    public bool IsInControlGroup { get { return default(bool); } }
    public bool IsInQuickAccessToolBar { get { return default(bool); } }
    public string KeyTip { get { return default(string); } set { } }
    public string Label { get { return default(string); } set { } }
    public System.Windows.Media.ImageSource LargeImageSource { get { return default(System.Windows.Media.ImageSource); } set { } }
    public System.Windows.Media.Brush MouseOverBackground { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Media.Brush MouseOverBorderBrush { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Media.Brush PressedBackground { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Media.Brush PressedBorderBrush { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Controls.Ribbon.RibbonControlSizeDefinition QuickAccessToolBarControlSizeDefinition { get { return default(System.Windows.Controls.Ribbon.RibbonControlSizeDefinition); } set { } }
    public object QuickAccessToolBarId { get { return default(object); } set { } }
    public System.Windows.Controls.Ribbon.Ribbon Ribbon { get { return default(System.Windows.Controls.Ribbon.Ribbon); } }
    public bool ShowKeyboardCues { get { return default(bool); } }
    public System.Windows.Media.ImageSource SmallImageSource { get { return default(System.Windows.Media.ImageSource); } set { } }
    public string ToolTipDescription { get { return default(string); } set { } }
    public string ToolTipFooterDescription { get { return default(string); } set { } }
    public System.Windows.Media.ImageSource ToolTipFooterImageSource { get { return default(System.Windows.Media.ImageSource); } set { } }
    public string ToolTipFooterTitle { get { return default(string); } set { } }
    public System.Windows.Media.ImageSource ToolTipImageSource { get { return default(System.Windows.Media.ImageSource); } set { } }
    public string ToolTipTitle { get { return default(string); } set { } }
    protected virtual void OnActivatingKeyTip(System.Windows.Controls.ActivatingKeyTipEventArgs e) { }
    public override void OnApplyTemplate() { }
    protected override void OnClick() { }
    protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { return default(System.Windows.Automation.Peers.AutomationPeer); }
    protected override void OnGotKeyboardFocus(System.Windows.Input.KeyboardFocusChangedEventArgs e) { }
    protected virtual void OnKeyTipAccessed(System.Windows.Controls.KeyTipAccessedEventArgs e) { }
    protected override void OnLostKeyboardFocus(System.Windows.Input.KeyboardFocusChangedEventArgs e) { }
    protected override void OnMouseLeftButtonDown(System.Windows.Input.MouseButtonEventArgs e) { }
  }
  [System.Windows.TemplatePartAttribute(Name="PART_CheckBorder", Type=typeof(System.Windows.Controls.Border))]
  public partial class RibbonCheckBox : System.Windows.Controls.CheckBox {
    public static readonly System.Windows.DependencyProperty CanAddToQuickAccessToolBarDirectlyProperty;
    public static readonly System.Windows.DependencyProperty CheckedBackgroundProperty;
    public static readonly System.Windows.DependencyProperty CheckedBorderBrushProperty;
    public static readonly System.Windows.DependencyProperty ControlSizeDefinitionProperty;
    public static readonly System.Windows.DependencyProperty FocusedBackgroundProperty;
    public static readonly System.Windows.DependencyProperty FocusedBorderBrushProperty;
    public static readonly System.Windows.DependencyProperty IsInControlGroupProperty;
    public static readonly System.Windows.DependencyProperty IsInQuickAccessToolBarProperty;
    public static readonly System.Windows.DependencyProperty KeyTipProperty;
    public static readonly System.Windows.DependencyProperty LabelProperty;
    public static readonly System.Windows.DependencyProperty LargeImageSourceProperty;
    public static readonly System.Windows.DependencyProperty MouseOverBackgroundProperty;
    public static readonly System.Windows.DependencyProperty MouseOverBorderBrushProperty;
    public static readonly System.Windows.DependencyProperty PressedBackgroundProperty;
    public static readonly System.Windows.DependencyProperty PressedBorderBrushProperty;
    public static readonly System.Windows.DependencyProperty QuickAccessToolBarControlSizeDefinitionProperty;
    public static readonly System.Windows.DependencyProperty QuickAccessToolBarIdProperty;
    public static readonly System.Windows.DependencyProperty RibbonProperty;
    public static readonly System.Windows.DependencyProperty ShowKeyboardCuesProperty;
    public static readonly System.Windows.DependencyProperty SmallImageSourceProperty;
    public static readonly System.Windows.DependencyProperty ToolTipDescriptionProperty;
    public static readonly System.Windows.DependencyProperty ToolTipFooterDescriptionProperty;
    public static readonly System.Windows.DependencyProperty ToolTipFooterImageSourceProperty;
    public static readonly System.Windows.DependencyProperty ToolTipFooterTitleProperty;
    public static readonly System.Windows.DependencyProperty ToolTipImageSourceProperty;
    public static readonly System.Windows.DependencyProperty ToolTipTitleProperty;
    public RibbonCheckBox() { }
    public bool CanAddToQuickAccessToolBarDirectly { get { return default(bool); } set { } }
    public System.Windows.Media.Brush CheckedBackground { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Media.Brush CheckedBorderBrush { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Controls.Ribbon.RibbonControlSizeDefinition ControlSizeDefinition { get { return default(System.Windows.Controls.Ribbon.RibbonControlSizeDefinition); } set { } }
    public System.Windows.Media.Brush FocusedBackground { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Media.Brush FocusedBorderBrush { get { return default(System.Windows.Media.Brush); } set { } }
    public bool IsInControlGroup { get { return default(bool); } }
    public bool IsInQuickAccessToolBar { get { return default(bool); } }
    public string KeyTip { get { return default(string); } set { } }
    public string Label { get { return default(string); } set { } }
    public System.Windows.Media.ImageSource LargeImageSource { get { return default(System.Windows.Media.ImageSource); } set { } }
    public System.Windows.Media.Brush MouseOverBackground { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Media.Brush MouseOverBorderBrush { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Media.Brush PressedBackground { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Media.Brush PressedBorderBrush { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Controls.Ribbon.RibbonControlSizeDefinition QuickAccessToolBarControlSizeDefinition { get { return default(System.Windows.Controls.Ribbon.RibbonControlSizeDefinition); } set { } }
    public object QuickAccessToolBarId { get { return default(object); } set { } }
    public System.Windows.Controls.Ribbon.Ribbon Ribbon { get { return default(System.Windows.Controls.Ribbon.Ribbon); } }
    public bool ShowKeyboardCues { get { return default(bool); } }
    public System.Windows.Media.ImageSource SmallImageSource { get { return default(System.Windows.Media.ImageSource); } set { } }
    public string ToolTipDescription { get { return default(string); } set { } }
    public string ToolTipFooterDescription { get { return default(string); } set { } }
    public System.Windows.Media.ImageSource ToolTipFooterImageSource { get { return default(System.Windows.Media.ImageSource); } set { } }
    public string ToolTipFooterTitle { get { return default(string); } set { } }
    public System.Windows.Media.ImageSource ToolTipImageSource { get { return default(System.Windows.Media.ImageSource); } set { } }
    public string ToolTipTitle { get { return default(string); } set { } }
    protected virtual void OnActivatingKeyTip(System.Windows.Controls.ActivatingKeyTipEventArgs e) { }
    public override void OnApplyTemplate() { }
    protected override void OnClick() { }
    protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { return default(System.Windows.Automation.Peers.AutomationPeer); }
    protected override void OnGotKeyboardFocus(System.Windows.Input.KeyboardFocusChangedEventArgs e) { }
    protected virtual void OnKeyTipAccessed(System.Windows.Controls.KeyTipAccessedEventArgs e) { }
    protected override void OnLostKeyboardFocus(System.Windows.Input.KeyboardFocusChangedEventArgs e) { }
    protected override void OnMouseLeftButtonDown(System.Windows.Input.MouseButtonEventArgs e) { }
  }
  public partial class RibbonComboBox : System.Windows.Controls.Ribbon.RibbonMenuButton {
    public static readonly System.Windows.DependencyProperty IsEditableProperty;
    public static readonly System.Windows.DependencyProperty IsReadOnlyProperty;
    public static readonly System.Windows.DependencyProperty SelectionBoxItemProperty;
    public static readonly System.Windows.DependencyProperty SelectionBoxItemStringFormatProperty;
    public static readonly System.Windows.DependencyProperty SelectionBoxItemTemplateProperty;
    public static readonly System.Windows.DependencyProperty SelectionBoxItemTemplateSelectorProperty;
    public static readonly System.Windows.DependencyProperty SelectionBoxWidthProperty;
    public static readonly System.Windows.DependencyProperty ShowKeyboardCuesProperty;
    public static readonly System.Windows.DependencyProperty StaysOpenOnEditProperty;
    public static readonly System.Windows.DependencyProperty TextProperty;
    public RibbonComboBox() { }
    public bool IsEditable { get { return default(bool); } set { } }
    public bool IsReadOnly { get { return default(bool); } set { } }
    public object SelectionBoxItem { get { return default(object); } }
    public string SelectionBoxItemStringFormat { get { return default(string); } }
    public System.Windows.DataTemplate SelectionBoxItemTemplate { get { return default(System.Windows.DataTemplate); } }
    public System.Windows.Controls.DataTemplateSelector SelectionBoxItemTemplateSelector { get { return default(System.Windows.Controls.DataTemplateSelector); } }
    public double SelectionBoxWidth { get { return default(double); } set { } }
    public bool ShowKeyboardCues { get { return default(bool); } }
    public bool StaysOpenOnEdit { get { return default(bool); } set { } }
    public string Text { get { return default(string); } set { } }
    protected override void ClearContainerForItemOverride(System.Windows.DependencyObject element, object item) { }
    protected override void OnActivatingKeyTip(System.Windows.Controls.ActivatingKeyTipEventArgs e) { }
    public override void OnApplyTemplate() { }
    protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { return default(System.Windows.Automation.Peers.AutomationPeer); }
    protected override void OnGotKeyboardFocus(System.Windows.Input.KeyboardFocusChangedEventArgs e) { }
    protected override void OnIsKeyboardFocusWithinChanged(System.Windows.DependencyPropertyChangedEventArgs e) { }
    protected override void OnItemsChanged(System.Collections.Specialized.NotifyCollectionChangedEventArgs e) { }
    protected override void OnKeyDown(System.Windows.Input.KeyEventArgs e) { }
    protected override void OnKeyTipAccessed(System.Windows.Controls.KeyTipAccessedEventArgs e) { }
    protected override void OnKeyUp(System.Windows.Input.KeyEventArgs e) { }
    protected override void OnLostKeyboardFocus(System.Windows.Input.KeyboardFocusChangedEventArgs e) { }
    protected override void OnPreviewKeyDown(System.Windows.Input.KeyEventArgs e) { }
    protected override void OnPreviewMouseDown(System.Windows.Input.MouseButtonEventArgs e) { }
    protected override void OnTextInput(System.Windows.Input.TextCompositionEventArgs e) { }
    protected override void PrepareContainerForItemOverride(System.Windows.DependencyObject element, object item) { }
  }
  public static partial class RibbonCommands {
    public static System.Windows.Input.RoutedUICommand AddToQuickAccessToolBarCommand { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Windows.Input.RoutedUICommand); } }
    public static System.Windows.Input.RoutedUICommand MaximizeRibbonCommand { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Windows.Input.RoutedUICommand); } }
    public static System.Windows.Input.RoutedUICommand MinimizeRibbonCommand { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Windows.Input.RoutedUICommand); } }
    public static System.Windows.Input.RoutedUICommand RemoveFromQuickAccessToolBarCommand { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Windows.Input.RoutedUICommand); } }
    public static System.Windows.Input.RoutedUICommand ShowQuickAccessToolBarAboveRibbonCommand { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Windows.Input.RoutedUICommand); } }
    public static System.Windows.Input.RoutedUICommand ShowQuickAccessToolBarBelowRibbonCommand { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Windows.Input.RoutedUICommand); } }
  }
  public partial class RibbonContentPresenter : System.Windows.Controls.ContentPresenter {
    public static readonly System.Windows.DependencyProperty ControlSizeDefinitionProperty;
    public static readonly System.Windows.DependencyProperty IsInControlGroupProperty;
    public static readonly System.Windows.DependencyProperty IsInQuickAccessToolBarProperty;
    public RibbonContentPresenter() { }
    public System.Windows.Controls.Ribbon.RibbonControlSizeDefinition ControlSizeDefinition { get { return default(System.Windows.Controls.Ribbon.RibbonControlSizeDefinition); } set { } }
    public bool IsInControlGroup { get { return default(bool); } }
    public bool IsInQuickAccessToolBar { get { return default(bool); } }
    public override void OnApplyTemplate() { }
    protected override void OnTemplateChanged(System.Windows.DataTemplate oldTemplate, System.Windows.DataTemplate newTemplate) { }
  }
  [System.Windows.StyleTypedPropertyAttribute(Property="ItemContainerStyle", StyleTargetType=typeof(System.Windows.Controls.Ribbon.RibbonMenuItem))]
  public partial class RibbonContextMenu : System.Windows.Controls.ContextMenu {
    public static readonly System.Windows.DependencyProperty HasGalleryProperty;
    public RibbonContextMenu() { }
    public bool HasGallery { get { return default(bool); } }
    protected override void ClearContainerForItemOverride(System.Windows.DependencyObject element, object item) { }
    protected override System.Windows.DependencyObject GetContainerForItemOverride() { return default(System.Windows.DependencyObject); }
    protected override bool IsItemItsOwnContainerOverride(object item) { return default(bool); }
    protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { return default(System.Windows.Automation.Peers.AutomationPeer); }
    protected override void OnKeyDown(System.Windows.Input.KeyEventArgs e) { }
    protected override void PrepareContainerForItemOverride(System.Windows.DependencyObject element, object item) { }
    protected override bool ShouldApplyItemContainerStyle(System.Windows.DependencyObject container, object item) { return default(bool); }
  }
  [System.Windows.Markup.ContentPropertyAttribute("Header")]
  public partial class RibbonContextualTabGroup : System.Windows.Controls.Control {
    public static readonly System.Windows.DependencyProperty HeaderProperty;
    public static readonly System.Windows.DependencyProperty HeaderStringFormatProperty;
    public static readonly System.Windows.DependencyProperty HeaderTemplateProperty;
    public static readonly System.Windows.DependencyProperty HeaderTemplateSelectorProperty;
    public static readonly System.Windows.DependencyProperty RibbonProperty;
    public RibbonContextualTabGroup() { }
    public object Header { get { return default(object); } set { } }
    public string HeaderStringFormat { get { return default(string); } set { } }
    public System.Windows.DataTemplate HeaderTemplate { get { return default(System.Windows.DataTemplate); } set { } }
    public System.Windows.Controls.DataTemplateSelector HeaderTemplateSelector { get { return default(System.Windows.Controls.DataTemplateSelector); } set { } }
    public System.Windows.Controls.Ribbon.Ribbon Ribbon { get { return default(System.Windows.Controls.Ribbon.Ribbon); } }
    protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { return default(System.Windows.Automation.Peers.AutomationPeer); }
    protected virtual void OnHeaderChanged(object oldHeader, object newHeader) { }
    protected override void OnMouseDown(System.Windows.Input.MouseButtonEventArgs e) { }
    protected override void OnMouseUp(System.Windows.Input.MouseButtonEventArgs e) { }
  }
  public partial class RibbonContextualTabGroupItemsControl : System.Windows.Controls.ItemsControl {
    public static readonly System.Windows.DependencyProperty RibbonProperty;
    public RibbonContextualTabGroupItemsControl() { }
    public System.Windows.Controls.Ribbon.Ribbon Ribbon { get { return default(System.Windows.Controls.Ribbon.Ribbon); } }
    protected override void ClearContainerForItemOverride(System.Windows.DependencyObject element, object item) { }
    protected override System.Windows.DependencyObject GetContainerForItemOverride() { return default(System.Windows.DependencyObject); }
    protected override bool IsItemItsOwnContainerOverride(object item) { return default(bool); }
    public override void OnApplyTemplate() { }
    protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { return default(System.Windows.Automation.Peers.AutomationPeer); }
    protected override void PrepareContainerForItemOverride(System.Windows.DependencyObject element, object item) { }
  }
  [System.Windows.TemplatePartAttribute(Name="PART_ContentPresenter", Type=typeof(System.Windows.Controls.Ribbon.RibbonContentPresenter))]
  public partial class RibbonControl : System.Windows.Controls.ContentControl {
    public static readonly System.Windows.DependencyProperty ControlSizeDefinitionProperty;
    public static readonly System.Windows.DependencyProperty IsInControlGroupProperty;
    public static readonly System.Windows.DependencyProperty IsInQuickAccessToolBarProperty;
    public RibbonControl() { }
    public System.Windows.Controls.Ribbon.RibbonControlSizeDefinition ControlSizeDefinition { get { return default(System.Windows.Controls.Ribbon.RibbonControlSizeDefinition); } set { } }
    public bool IsInControlGroup { get { return default(bool); } }
    public bool IsInQuickAccessToolBar { get { return default(bool); } }
    public override void OnApplyTemplate() { }
    protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { return default(System.Windows.Automation.Peers.AutomationPeer); }
    protected override void OnTemplateChanged(System.Windows.Controls.ControlTemplate oldTemplate, System.Windows.Controls.ControlTemplate newTemplate) { }
  }
  public partial class RibbonControlGroup : System.Windows.Controls.ItemsControl {
    public static readonly System.Windows.DependencyProperty ControlSizeDefinitionProperty;
    public static readonly System.Windows.DependencyProperty RibbonProperty;
    public RibbonControlGroup() { }
    public System.Windows.Controls.Ribbon.RibbonControlSizeDefinition ControlSizeDefinition { get { return default(System.Windows.Controls.Ribbon.RibbonControlSizeDefinition); } set { } }
    public System.Windows.Controls.Ribbon.Ribbon Ribbon { get { return default(System.Windows.Controls.Ribbon.Ribbon); } }
    protected override void ClearContainerForItemOverride(System.Windows.DependencyObject element, object item) { }
    protected override System.Windows.DependencyObject GetContainerForItemOverride() { return default(System.Windows.DependencyObject); }
    protected override bool IsItemItsOwnContainerOverride(object item) { return default(bool); }
    public override void OnApplyTemplate() { }
    protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { return default(System.Windows.Automation.Peers.AutomationPeer); }
    protected override void PrepareContainerForItemOverride(System.Windows.DependencyObject element, object item) { }
  }
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Controls.Ribbon.RibbonControlLengthConverter))]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct RibbonControlLength : System.IEquatable<System.Windows.Controls.Ribbon.RibbonControlLength> {
    public RibbonControlLength(double pixels) { throw new System.NotImplementedException(); }
    public RibbonControlLength(double value, System.Windows.Controls.Ribbon.RibbonControlLengthUnitType type) { throw new System.NotImplementedException(); }
    public static System.Windows.Controls.Ribbon.RibbonControlLength Auto { get { return default(System.Windows.Controls.Ribbon.RibbonControlLength); } }
    public bool IsAbsolute { get { return default(bool); } }
    public bool IsAuto { get { return default(bool); } }
    public bool IsStar { get { return default(bool); } }
    public System.Windows.Controls.Ribbon.RibbonControlLengthUnitType RibbonControlLengthUnitType { get { return default(System.Windows.Controls.Ribbon.RibbonControlLengthUnitType); } }
    public double Value { get { return default(double); } }
    public override bool Equals(object obj) { return default(bool); }
    public bool Equals(System.Windows.Controls.Ribbon.RibbonControlLength other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Windows.Controls.Ribbon.RibbonControlLength length1, System.Windows.Controls.Ribbon.RibbonControlLength length2) { return default(bool); }
    public static bool operator !=(System.Windows.Controls.Ribbon.RibbonControlLength length1, System.Windows.Controls.Ribbon.RibbonControlLength length2) { return default(bool); }
    public override string ToString() { return default(string); }
  }
  public partial class RibbonControlLengthConverter : System.ComponentModel.TypeConverter {
    public RibbonControlLengthConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
  }
  public enum RibbonControlLengthUnitType {
    Auto = 0,
    Item = 2,
    Pixel = 1,
    Star = 3,
  }
  public static partial class RibbonControlService {
    public static readonly System.Windows.DependencyProperty CanAddToQuickAccessToolBarDirectlyProperty;
    public static readonly System.Windows.DependencyProperty CheckedBackgroundProperty;
    public static readonly System.Windows.DependencyProperty CheckedBorderBrushProperty;
    public static readonly System.Windows.DependencyProperty ControlSizeDefinitionProperty;
    public static readonly System.Windows.DependencyProperty CornerRadiusProperty;
    public static readonly System.Windows.DependencyProperty DefaultControlSizeDefinitionProperty;
    public static readonly System.Windows.RoutedEvent DismissPopupEvent;
    public static readonly System.Windows.DependencyProperty FocusedBackgroundProperty;
    public static readonly System.Windows.DependencyProperty FocusedBorderBrushProperty;
    public static readonly System.Windows.DependencyProperty IsInControlGroupProperty;
    public static readonly System.Windows.DependencyProperty IsInQuickAccessToolBarProperty;
    public static readonly System.Windows.DependencyProperty LabelProperty;
    public static readonly System.Windows.DependencyProperty LargeImageSourceProperty;
    public static readonly System.Windows.DependencyProperty MouseOverBackgroundProperty;
    public static readonly System.Windows.DependencyProperty MouseOverBorderBrushProperty;
    public static readonly System.Windows.DependencyProperty PressedBackgroundProperty;
    public static readonly System.Windows.DependencyProperty PressedBorderBrushProperty;
    public static readonly System.Windows.DependencyProperty QuickAccessToolBarControlSizeDefinitionProperty;
    public static readonly System.Windows.DependencyProperty QuickAccessToolBarIdProperty;
    public static readonly System.Windows.DependencyProperty RibbonProperty;
    public static readonly System.Windows.DependencyProperty ShowKeyboardCuesProperty;
    public static readonly System.Windows.DependencyProperty SmallImageSourceProperty;
    public static readonly System.Windows.DependencyProperty ToolTipDescriptionProperty;
    public static readonly System.Windows.DependencyProperty ToolTipFooterDescriptionProperty;
    public static readonly System.Windows.DependencyProperty ToolTipFooterImageSourceProperty;
    public static readonly System.Windows.DependencyProperty ToolTipFooterTitleProperty;
    public static readonly System.Windows.DependencyProperty ToolTipImageSourceProperty;
    public static readonly System.Windows.DependencyProperty ToolTipTitleProperty;
    public static void AddDismissPopupHandler(System.Windows.DependencyObject element, System.Windows.Controls.Ribbon.RibbonDismissPopupEventHandler handler) { }
    public static bool GetCanAddToQuickAccessToolBarDirectly(System.Windows.DependencyObject element) { return default(bool); }
    public static System.Windows.Media.Brush GetCheckedBackground(System.Windows.DependencyObject element) { return default(System.Windows.Media.Brush); }
    public static System.Windows.Media.Brush GetCheckedBorderBrush(System.Windows.DependencyObject element) { return default(System.Windows.Media.Brush); }
    public static System.Windows.Controls.Ribbon.RibbonControlSizeDefinition GetControlSizeDefinition(System.Windows.DependencyObject element) { return default(System.Windows.Controls.Ribbon.RibbonControlSizeDefinition); }
    public static System.Windows.CornerRadius GetCornerRadius(System.Windows.DependencyObject element) { return default(System.Windows.CornerRadius); }
    public static System.Windows.Controls.Ribbon.RibbonControlSizeDefinition GetDefaultControlSizeDefinition(System.Windows.DependencyObject element) { return default(System.Windows.Controls.Ribbon.RibbonControlSizeDefinition); }
    public static System.Windows.Media.Brush GetFocusedBackground(System.Windows.DependencyObject element) { return default(System.Windows.Media.Brush); }
    public static System.Windows.Media.Brush GetFocusedBorderBrush(System.Windows.DependencyObject element) { return default(System.Windows.Media.Brush); }
    public static bool GetIsInControlGroup(System.Windows.DependencyObject element) { return default(bool); }
    public static bool GetIsInQuickAccessToolBar(System.Windows.DependencyObject element) { return default(bool); }
    public static string GetLabel(System.Windows.DependencyObject element) { return default(string); }
    public static System.Windows.Media.ImageSource GetLargeImageSource(System.Windows.DependencyObject element) { return default(System.Windows.Media.ImageSource); }
    public static System.Windows.Media.Brush GetMouseOverBackground(System.Windows.DependencyObject element) { return default(System.Windows.Media.Brush); }
    public static System.Windows.Media.Brush GetMouseOverBorderBrush(System.Windows.DependencyObject element) { return default(System.Windows.Media.Brush); }
    public static System.Windows.Media.Brush GetPressedBackground(System.Windows.DependencyObject element) { return default(System.Windows.Media.Brush); }
    public static System.Windows.Media.Brush GetPressedBorderBrush(System.Windows.DependencyObject element) { return default(System.Windows.Media.Brush); }
    public static System.Windows.Controls.Ribbon.RibbonControlSizeDefinition GetQuickAccessToolBarControlSizeDefinition(System.Windows.DependencyObject element) { return default(System.Windows.Controls.Ribbon.RibbonControlSizeDefinition); }
    public static object GetQuickAccessToolBarId(System.Windows.DependencyObject element) { return default(object); }
    public static System.Windows.Controls.Ribbon.Ribbon GetRibbon(System.Windows.DependencyObject element) { return default(System.Windows.Controls.Ribbon.Ribbon); }
    public static bool GetShowKeyboardCues(System.Windows.DependencyObject element) { return default(bool); }
    public static System.Windows.Media.ImageSource GetSmallImageSource(System.Windows.DependencyObject element) { return default(System.Windows.Media.ImageSource); }
    public static string GetToolTipDescription(System.Windows.DependencyObject element) { return default(string); }
    public static string GetToolTipFooterDescription(System.Windows.DependencyObject element) { return default(string); }
    public static System.Windows.Media.ImageSource GetToolTipFooterImageSource(System.Windows.DependencyObject element) { return default(System.Windows.Media.ImageSource); }
    public static string GetToolTipFooterTitle(System.Windows.DependencyObject element) { return default(string); }
    public static System.Windows.Media.ImageSource GetToolTipImageSource(System.Windows.DependencyObject element) { return default(System.Windows.Media.ImageSource); }
    public static string GetToolTipTitle(System.Windows.DependencyObject element) { return default(string); }
    public static void RemoveDismissPopupHandler(System.Windows.DependencyObject element, System.Windows.Controls.Ribbon.RibbonDismissPopupEventHandler handler) { }
    public static void SetCanAddToQuickAccessToolBarDirectly(System.Windows.DependencyObject element, bool value) { }
    public static void SetCheckedBackground(System.Windows.DependencyObject element, System.Windows.Media.Brush value) { }
    public static void SetCheckedBorderBrush(System.Windows.DependencyObject element, System.Windows.Media.Brush value) { }
    public static void SetControlSizeDefinition(System.Windows.DependencyObject element, System.Windows.Controls.Ribbon.RibbonControlSizeDefinition value) { }
    public static void SetCornerRadius(System.Windows.DependencyObject element, System.Windows.CornerRadius value) { }
    public static void SetDefaultControlSizeDefinition(System.Windows.DependencyObject element, System.Windows.Controls.Ribbon.RibbonControlSizeDefinition value) { }
    public static void SetFocusedBackground(System.Windows.DependencyObject element, System.Windows.Media.Brush value) { }
    public static void SetFocusedBorderBrush(System.Windows.DependencyObject element, System.Windows.Media.Brush value) { }
    public static void SetLabel(System.Windows.DependencyObject element, string value) { }
    public static void SetLargeImageSource(System.Windows.DependencyObject element, System.Windows.Media.ImageSource value) { }
    public static void SetMouseOverBackground(System.Windows.DependencyObject element, System.Windows.Media.Brush value) { }
    public static void SetMouseOverBorderBrush(System.Windows.DependencyObject element, System.Windows.Media.Brush value) { }
    public static void SetPressedBackground(System.Windows.DependencyObject element, System.Windows.Media.Brush value) { }
    public static void SetPressedBorderBrush(System.Windows.DependencyObject element, System.Windows.Media.Brush value) { }
    public static void SetQuickAccessToolBarControlSizeDefinition(System.Windows.DependencyObject element, System.Windows.Controls.Ribbon.RibbonControlSizeDefinition value) { }
    public static void SetQuickAccessToolBarId(System.Windows.DependencyObject element, object value) { }
    public static void SetSmallImageSource(System.Windows.DependencyObject element, System.Windows.Media.ImageSource value) { }
    public static void SetToolTipDescription(System.Windows.DependencyObject element, string value) { }
    public static void SetToolTipFooterDescription(System.Windows.DependencyObject element, string value) { }
    public static void SetToolTipFooterImageSource(System.Windows.DependencyObject element, System.Windows.Media.ImageSource value) { }
    public static void SetToolTipFooterTitle(System.Windows.DependencyObject element, string value) { }
    public static void SetToolTipImageSource(System.Windows.DependencyObject element, System.Windows.Media.ImageSource value) { }
    public static void SetToolTipTitle(System.Windows.DependencyObject element, string value) { }
  }
  public partial class RibbonControlSizeDefinition : System.Windows.Freezable {
    public static readonly System.Windows.DependencyProperty ImageSizeProperty;
    public static readonly System.Windows.DependencyProperty IsCollapsedProperty;
    public static readonly System.Windows.DependencyProperty IsLabelVisibleProperty;
    public static readonly System.Windows.DependencyProperty MaxWidthProperty;
    public static readonly System.Windows.DependencyProperty MinWidthProperty;
    public static readonly System.Windows.DependencyProperty WidthProperty;
    public RibbonControlSizeDefinition() { }
    public System.Windows.Controls.Ribbon.RibbonImageSize ImageSize { get { return default(System.Windows.Controls.Ribbon.RibbonImageSize); } set { } }
    public bool IsCollapsed { get { return default(bool); } set { } }
    public bool IsLabelVisible { get { return default(bool); } set { } }
    public System.Windows.Controls.Ribbon.RibbonControlLength MaxWidth { get { return default(System.Windows.Controls.Ribbon.RibbonControlLength); } set { } }
    public System.Windows.Controls.Ribbon.RibbonControlLength MinWidth { get { return default(System.Windows.Controls.Ribbon.RibbonControlLength); } set { } }
    public System.Windows.Controls.Ribbon.RibbonControlLength Width { get { return default(System.Windows.Controls.Ribbon.RibbonControlLength); } set { } }
    protected override System.Windows.Freezable CreateInstanceCore() { return default(System.Windows.Freezable); }
  }
  public partial class RibbonControlSizeDefinitionCollection : System.Windows.FreezableCollection<System.Windows.Controls.Ribbon.RibbonControlSizeDefinition> {
    public RibbonControlSizeDefinitionCollection() { }
    protected override System.Windows.Freezable CreateInstanceCore() { return default(System.Windows.Freezable); }
  }
  public partial class RibbonDismissPopupEventArgs : System.Windows.RoutedEventArgs {
    public RibbonDismissPopupEventArgs() { }
    public RibbonDismissPopupEventArgs(System.Windows.Controls.Ribbon.RibbonDismissPopupMode dismissMode) { }
    public System.Windows.Controls.Ribbon.RibbonDismissPopupMode DismissMode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Windows.Controls.Ribbon.RibbonDismissPopupMode); } }
    protected override void InvokeEventHandler(System.Delegate genericHandler, object genericTarget) { }
  }
  public delegate void RibbonDismissPopupEventHandler(object sender, System.Windows.Controls.Ribbon.RibbonDismissPopupEventArgs e);
  public enum RibbonDismissPopupMode {
    Always = 0,
    MousePhysicallyNotOver = 1,
  }
  [System.Windows.TemplatePartAttribute(Name="PART_CurrentFilterItem", Type=typeof(System.Windows.Controls.ContentPresenter))]
  public partial class RibbonFilterMenuButton : System.Windows.Controls.Ribbon.RibbonMenuButton {
    public RibbonFilterMenuButton() { }
    protected override void OnActivatingKeyTip(System.Windows.Controls.ActivatingKeyTipEventArgs e) { }
    public override void OnApplyTemplate() { }
    protected override void OnDismissPopup(System.Windows.Controls.Ribbon.RibbonDismissPopupEventArgs e) { }
  }
  [System.Windows.StyleTypedPropertyAttribute(Property="AllFilterItemContainerStyle", StyleTargetType=typeof(System.Windows.Controls.Ribbon.RibbonMenuItem))]
  [System.Windows.StyleTypedPropertyAttribute(Property="FilterItemContainerStyle", StyleTargetType=typeof(System.Windows.Controls.Ribbon.RibbonMenuItem))]
  [System.Windows.StyleTypedPropertyAttribute(Property="GalleryItemStyle", StyleTargetType=typeof(System.Windows.Controls.Ribbon.RibbonGalleryItem))]
  [System.Windows.StyleTypedPropertyAttribute(Property="ItemContainerStyle", StyleTargetType=typeof(System.Windows.Controls.Ribbon.RibbonGalleryCategory))]
  [System.Windows.TemplatePartAttribute(Name="ItemsPresenter", Type=typeof(System.Windows.Controls.ItemsPresenter))]
  [System.Windows.TemplatePartAttribute(Name="PART_FilterContentPane", Type=typeof(System.Windows.Controls.ContentPresenter))]
  [System.Windows.TemplatePartAttribute(Name="PART_FilterMenuButton", Type=typeof(System.Windows.Controls.Ribbon.RibbonMenuButton))]
  [System.Windows.TemplatePartAttribute(Name="PART_ScrollViewer", Type=typeof(System.Windows.Controls.ScrollViewer))]
  public partial class RibbonGallery : System.Windows.Controls.ItemsControl, Microsoft.Windows.Input.IPreviewCommandSource, System.Windows.Input.ICommandSource, System.Windows.IWeakEventListener {
    public static readonly System.Windows.DependencyProperty AllFilterItemContainerStyleProperty;
    public static readonly System.Windows.DependencyProperty AllFilterItemTemplateProperty;
    public static readonly System.Windows.DependencyProperty CanAddToQuickAccessToolBarDirectlyProperty;
    public static readonly System.Windows.DependencyProperty CanUserFilterProperty;
    public static readonly System.Windows.DependencyProperty CategoryStyleProperty;
    public static readonly System.Windows.DependencyProperty CategoryTemplateProperty;
    public static readonly System.Windows.DependencyProperty ColumnsStretchToFillProperty;
    public static readonly System.Windows.DependencyProperty CommandParameterProperty;
    public static readonly System.Windows.DependencyProperty CommandProperty;
    public static readonly System.Windows.DependencyProperty CommandTargetProperty;
    public static readonly System.Windows.DependencyProperty FilterItemContainerStyleProperty;
    public static readonly System.Windows.DependencyProperty FilterItemContainerStyleSelectorProperty;
    public static readonly System.Windows.DependencyProperty FilterItemTemplateProperty;
    public static readonly System.Windows.DependencyProperty FilterItemTemplateSelectorProperty;
    public static readonly System.Windows.DependencyProperty FilterMenuButtonStyleProperty;
    public static readonly System.Windows.DependencyProperty FilterPaneContentProperty;
    public static readonly System.Windows.DependencyProperty FilterPaneContentTemplateProperty;
    public static readonly System.Windows.DependencyProperty GalleryItemStyleProperty;
    public static readonly System.Windows.DependencyProperty GalleryItemTemplateProperty;
    public static readonly System.Windows.DependencyProperty HighlightedItemProperty;
    public static readonly System.Windows.DependencyProperty IsSharedColumnSizeScopeProperty;
    public static readonly System.Windows.DependencyProperty IsSynchronizedWithCurrentItemProperty;
    public static readonly System.Windows.DependencyProperty MaxColumnCountProperty;
    public static readonly System.Windows.DependencyProperty MinColumnCountProperty;
    public static readonly System.Windows.DependencyProperty PreviewCommandParameterProperty;
    public static readonly System.Windows.DependencyProperty QuickAccessToolBarIdProperty;
    public static readonly System.Windows.DependencyProperty RibbonProperty;
    public static readonly System.Windows.DependencyProperty SelectedItemProperty;
    public static readonly System.Windows.DependencyProperty SelectedValuePathProperty;
    public static readonly System.Windows.DependencyProperty SelectedValueProperty;
    public static readonly System.Windows.RoutedEvent SelectionChangedEvent;
    public static readonly System.Windows.DependencyProperty SmallImageSourceProperty;
    public static readonly System.Windows.DependencyProperty ToolTipDescriptionProperty;
    public static readonly System.Windows.DependencyProperty ToolTipFooterDescriptionProperty;
    public static readonly System.Windows.DependencyProperty ToolTipFooterImageSourceProperty;
    public static readonly System.Windows.DependencyProperty ToolTipFooterTitleProperty;
    public static readonly System.Windows.DependencyProperty ToolTipImageSourceProperty;
    public static readonly System.Windows.DependencyProperty ToolTipTitleProperty;
    public RibbonGallery() { }
    public static object AllFilterItem { get { return default(object); } }
    public System.Windows.Style AllFilterItemContainerStyle { get { return default(System.Windows.Style); } set { } }
    public System.Windows.DataTemplate AllFilterItemTemplate { get { return default(System.Windows.DataTemplate); } set { } }
    public bool CanAddToQuickAccessToolBarDirectly { get { return default(bool); } set { } }
    public bool CanUserFilter { get { return default(bool); } set { } }
    public System.Windows.Style CategoryStyle { get { return default(System.Windows.Style); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    public System.Windows.DataTemplate CategoryTemplate { get { return default(System.Windows.DataTemplate); } set { } }
    public bool ColumnsStretchToFill { get { return default(bool); } set { } }
    public System.Windows.Input.ICommand Command { get { return default(System.Windows.Input.ICommand); } set { } }
    public object CommandParameter { get { return default(object); } set { } }
    public System.Windows.IInputElement CommandTarget { get { return default(System.Windows.IInputElement); } set { } }
    public static System.Windows.Input.RoutedCommand FilterCommand { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Windows.Input.RoutedCommand); } }
    public System.Windows.Style FilterItemContainerStyle { get { return default(System.Windows.Style); } set { } }
    public System.Windows.Controls.StyleSelector FilterItemContainerStyleSelector { get { return default(System.Windows.Controls.StyleSelector); } set { } }
    public System.Windows.DataTemplate FilterItemTemplate { get { return default(System.Windows.DataTemplate); } set { } }
    public System.Windows.Controls.DataTemplateSelector FilterItemTemplateSelector { get { return default(System.Windows.Controls.DataTemplateSelector); } set { } }
    public System.Windows.Style FilterMenuButtonStyle { get { return default(System.Windows.Style); } set { } }
    public object FilterPaneContent { get { return default(object); } set { } }
    public System.Windows.DataTemplate FilterPaneContentTemplate { get { return default(System.Windows.DataTemplate); } set { } }
    public System.Windows.Style GalleryItemStyle { get { return default(System.Windows.Style); } set { } }
    public System.Windows.DataTemplate GalleryItemTemplate { get { return default(System.Windows.DataTemplate); } set { } }
    public object HighlightedItem { get { return default(object); } }
    protected override bool IsEnabledCore { get { return default(bool); } }
    public bool IsSharedColumnSizeScope { get { return default(bool); } set { } }
    public System.Nullable<System.Boolean> IsSynchronizedWithCurrentItem { get { return default(System.Nullable<System.Boolean>); } set { } }
    public int MaxColumnCount { get { return default(int); } set { } }
    public int MinColumnCount { get { return default(int); } set { } }
    public object PreviewCommandParameter { get { return default(object); } set { } }
    public object QuickAccessToolBarId { get { return default(object); } set { } }
    public System.Windows.Controls.Ribbon.Ribbon Ribbon { get { return default(System.Windows.Controls.Ribbon.Ribbon); } }
    public object SelectedItem { get { return default(object); } set { } }
    public object SelectedValue { get { return default(object); } set { } }
    [System.Windows.LocalizabilityAttribute((System.Windows.LocalizationCategory)(17))]
    public string SelectedValuePath { get { return default(string); } set { } }
    public System.Windows.Media.ImageSource SmallImageSource { get { return default(System.Windows.Media.ImageSource); } set { } }
    public string ToolTipDescription { get { return default(string); } set { } }
    public string ToolTipFooterDescription { get { return default(string); } set { } }
    public System.Windows.Media.ImageSource ToolTipFooterImageSource { get { return default(System.Windows.Media.ImageSource); } set { } }
    public string ToolTipFooterTitle { get { return default(string); } set { } }
    public System.Windows.Media.ImageSource ToolTipImageSource { get { return default(System.Windows.Media.ImageSource); } set { } }
    public string ToolTipTitle { get { return default(string); } set { } }
    public event System.Windows.RoutedPropertyChangedEventHandler<System.Object> SelectionChanged { add { } remove { } }
    protected override void ClearContainerForItemOverride(System.Windows.DependencyObject element, object item) { }
    protected override System.Windows.DependencyObject GetContainerForItemOverride() { return default(System.Windows.DependencyObject); }
    protected override bool IsItemItsOwnContainerOverride(object item) { return default(bool); }
    public override void OnApplyTemplate() { }
    protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { return default(System.Windows.Automation.Peers.AutomationPeer); }
    protected virtual void OnHighlightedItemChanged(System.Windows.DependencyPropertyChangedEventArgs e) { }
    protected override void OnInitialized(System.EventArgs e) { }
    protected override void OnIsKeyboardFocusWithinChanged(System.Windows.DependencyPropertyChangedEventArgs e) { }
    protected override void OnItemsChanged(System.Collections.Specialized.NotifyCollectionChangedEventArgs e) { }
    protected override void OnItemsSourceChanged(System.Collections.IEnumerable oldValue, System.Collections.IEnumerable newValue) { }
    protected override void OnMouseEnter(System.Windows.Input.MouseEventArgs e) { }
    protected override void OnMouseLeave(System.Windows.Input.MouseEventArgs e) { }
    protected override void OnPreviewKeyDown(System.Windows.Input.KeyEventArgs e) { }
    protected virtual void OnSelectionChanged(System.Windows.RoutedPropertyChangedEventArgs<System.Object> e) { }
    protected override void PrepareContainerForItemOverride(System.Windows.DependencyObject element, object item) { }
    public void ScrollIntoView(object item) { }
    bool System.Windows.IWeakEventListener.ReceiveWeakEvent(System.Type managerType, object sender, System.EventArgs e) { return default(bool); }
  }
  [System.Windows.StyleTypedPropertyAttribute(Property="ItemContainerStyle", StyleTargetType=typeof(System.Windows.Controls.Ribbon.RibbonGalleryItem))]
  [System.Windows.TemplatePartAttribute(Name="ItemsHost", Type=typeof(System.Windows.Controls.ItemsPresenter))]
  [System.Windows.TemplatePartAttribute(Name="PART_Header", Type=typeof(System.Windows.Controls.ContentPresenter))]
  public partial class RibbonGalleryCategory : System.Windows.Controls.HeaderedItemsControl, System.Windows.IWeakEventListener {
    public static readonly System.Windows.DependencyProperty ColumnsStretchToFillProperty;
    public static readonly System.Windows.DependencyProperty HeaderVisibilityProperty;
    public static readonly System.Windows.DependencyProperty IsSharedColumnSizeScopeProperty;
    public static readonly System.Windows.DependencyProperty MaxColumnCountProperty;
    public static readonly System.Windows.DependencyProperty MinColumnCountProperty;
    public RibbonGalleryCategory() { }
    public bool ColumnsStretchToFill { get { return default(bool); } set { } }
    public System.Windows.Visibility HeaderVisibility { get { return default(System.Windows.Visibility); } set { } }
    public bool IsSharedColumnSizeScope { get { return default(bool); } set { } }
    public int MaxColumnCount { get { return default(int); } set { } }
    public int MinColumnCount { get { return default(int); } set { } }
    protected override void ClearContainerForItemOverride(System.Windows.DependencyObject element, object item) { }
    protected override System.Windows.DependencyObject GetContainerForItemOverride() { return default(System.Windows.DependencyObject); }
    protected override bool IsItemItsOwnContainerOverride(object item) { return default(bool); }
    public override void OnApplyTemplate() { }
    protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { return default(System.Windows.Automation.Peers.AutomationPeer); }
    protected override void OnInitialized(System.EventArgs e) { }
    protected override void OnItemsChanged(System.Collections.Specialized.NotifyCollectionChangedEventArgs e) { }
    protected override void OnItemsSourceChanged(System.Collections.IEnumerable oldValue, System.Collections.IEnumerable newValue) { }
    protected override void PrepareContainerForItemOverride(System.Windows.DependencyObject element, object item) { }
    bool System.Windows.IWeakEventListener.ReceiveWeakEvent(System.Type managerType, object sender, System.EventArgs e) { return default(bool); }
  }
  public partial class RibbonGalleryItem : System.Windows.Controls.ContentControl {
    public static readonly System.Windows.DependencyProperty CheckedBackgroundProperty;
    public static readonly System.Windows.DependencyProperty CheckedBorderBrushProperty;
    public static readonly System.Windows.DependencyProperty IsHighlightedProperty;
    public static readonly System.Windows.DependencyProperty IsPressedProperty;
    public static readonly System.Windows.DependencyProperty IsSelectedProperty;
    public static readonly System.Windows.DependencyProperty KeyTipProperty;
    public static readonly System.Windows.DependencyProperty MouseOverBackgroundProperty;
    public static readonly System.Windows.DependencyProperty MouseOverBorderBrushProperty;
    public static readonly System.Windows.DependencyProperty PressedBackgroundProperty;
    public static readonly System.Windows.DependencyProperty PressedBorderBrushProperty;
    public static readonly System.Windows.DependencyProperty RibbonProperty;
    public static readonly System.Windows.RoutedEvent SelectedEvent;
    public static readonly System.Windows.DependencyProperty ToolTipDescriptionProperty;
    public static readonly System.Windows.DependencyProperty ToolTipFooterDescriptionProperty;
    public static readonly System.Windows.DependencyProperty ToolTipFooterImageSourceProperty;
    public static readonly System.Windows.DependencyProperty ToolTipFooterTitleProperty;
    public static readonly System.Windows.DependencyProperty ToolTipImageSourceProperty;
    public static readonly System.Windows.DependencyProperty ToolTipTitleProperty;
    public static readonly System.Windows.RoutedEvent UnselectedEvent;
    public RibbonGalleryItem() { }
    public System.Windows.Media.Brush CheckedBackground { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Media.Brush CheckedBorderBrush { get { return default(System.Windows.Media.Brush); } set { } }
    public bool IsHighlighted { get { return default(bool); } }
    public bool IsPressed { get { return default(bool); } }
    public bool IsSelected { get { return default(bool); } set { } }
    public string KeyTip { get { return default(string); } set { } }
    public System.Windows.Media.Brush MouseOverBackground { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Media.Brush MouseOverBorderBrush { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Media.Brush PressedBackground { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Media.Brush PressedBorderBrush { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Controls.Ribbon.Ribbon Ribbon { get { return default(System.Windows.Controls.Ribbon.Ribbon); } }
    public string ToolTipDescription { get { return default(string); } set { } }
    public string ToolTipFooterDescription { get { return default(string); } set { } }
    public System.Windows.Media.ImageSource ToolTipFooterImageSource { get { return default(System.Windows.Media.ImageSource); } set { } }
    public string ToolTipFooterTitle { get { return default(string); } set { } }
    public System.Windows.Media.ImageSource ToolTipImageSource { get { return default(System.Windows.Media.ImageSource); } set { } }
    public string ToolTipTitle { get { return default(string); } set { } }
    public event System.Windows.RoutedEventHandler Selected { add { } remove { } }
    public event System.Windows.RoutedEventHandler Unselected { add { } remove { } }
    protected virtual void OnActivatingKeyTip(System.Windows.Controls.ActivatingKeyTipEventArgs e) { }
    protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { return default(System.Windows.Automation.Peers.AutomationPeer); }
    protected override void OnGotKeyboardFocus(System.Windows.Input.KeyboardFocusChangedEventArgs e) { }
    protected override void OnKeyDown(System.Windows.Input.KeyEventArgs e) { }
    protected virtual void OnKeyTipAccessed(System.Windows.Controls.KeyTipAccessedEventArgs e) { }
    protected override void OnKeyUp(System.Windows.Input.KeyEventArgs e) { }
    protected override void OnLostKeyboardFocus(System.Windows.Input.KeyboardFocusChangedEventArgs e) { }
    protected override void OnMouseLeave(System.Windows.Input.MouseEventArgs e) { }
    protected override void OnMouseLeftButtonDown(System.Windows.Input.MouseButtonEventArgs e) { }
    protected override void OnMouseLeftButtonUp(System.Windows.Input.MouseButtonEventArgs e) { }
    protected override void OnMouseMove(System.Windows.Input.MouseEventArgs e) { }
    protected internal virtual void OnSelected(System.Windows.RoutedEventArgs e) { }
    protected internal virtual void OnUnselected(System.Windows.RoutedEventArgs e) { }
  }
  [System.Windows.TemplatePartAttribute(Name="ItemsPresenter", Type=typeof(System.Windows.Controls.ItemsPresenter))]
  [System.Windows.TemplatePartAttribute(Name="PART_Header", Type=typeof(System.Windows.Controls.ContentPresenter))]
  [System.Windows.TemplatePartAttribute(Name="PART_HotBackground", Type=typeof(System.Windows.Controls.Border))]
  [System.Windows.TemplatePartAttribute(Name="PART_Popup", Type=typeof(System.Windows.Controls.Primitives.Popup))]
  [System.Windows.TemplatePartAttribute(Name="PART_PopupGrid", Type=typeof(System.Windows.Controls.Grid))]
  [System.Windows.TemplatePartAttribute(Name="PART_TemplateContentControl", Type=typeof(System.Windows.Controls.ContentControl))]
  [System.Windows.TemplatePartAttribute(Name="PART_ToggleButton", Type=typeof(System.Windows.Controls.Ribbon.RibbonToggleButton))]
  public partial class RibbonGroup : System.Windows.Controls.HeaderedItemsControl {
    public static readonly System.Windows.DependencyProperty CanAddToQuickAccessToolBarDirectlyProperty;
    public static readonly System.Windows.DependencyProperty GroupSizeDefinitionsProperty;
    public static readonly System.Windows.DependencyProperty IsCollapsedProperty;
    public static readonly System.Windows.DependencyProperty IsDropDownOpenProperty;
    public static readonly System.Windows.DependencyProperty IsInQuickAccessToolBarProperty;
    public static readonly System.Windows.DependencyProperty KeyTipProperty;
    public static readonly System.Windows.DependencyProperty LargeImageSourceProperty;
    public static readonly System.Windows.DependencyProperty MouseOverBackgroundProperty;
    public static readonly System.Windows.DependencyProperty MouseOverBorderBrushProperty;
    public static readonly System.Windows.DependencyProperty QuickAccessToolBarIdProperty;
    public static readonly System.Windows.DependencyProperty RibbonProperty;
    public static readonly System.Windows.DependencyProperty SmallImageSourceProperty;
    public static readonly System.Windows.DependencyProperty ToolTipDescriptionProperty;
    public static readonly System.Windows.DependencyProperty ToolTipFooterDescriptionProperty;
    public static readonly System.Windows.DependencyProperty ToolTipFooterImageSourceProperty;
    public static readonly System.Windows.DependencyProperty ToolTipFooterTitleProperty;
    public static readonly System.Windows.DependencyProperty ToolTipImageSourceProperty;
    public static readonly System.Windows.DependencyProperty ToolTipTitleProperty;
    public RibbonGroup() { }
    public bool CanAddToQuickAccessToolBarDirectly { get { return default(bool); } set { } }
    public System.Windows.Controls.Ribbon.RibbonGroupSizeDefinitionBaseCollection GroupSizeDefinitions { get { return default(System.Windows.Controls.Ribbon.RibbonGroupSizeDefinitionBaseCollection); } set { } }
    public bool IsCollapsed { get { return default(bool); } }
    public bool IsDropDownOpen { get { return default(bool); } set { } }
    public bool IsInQuickAccessToolBar { get { return default(bool); } }
    public string KeyTip { get { return default(string); } set { } }
    public System.Windows.Media.ImageSource LargeImageSource { get { return default(System.Windows.Media.ImageSource); } set { } }
    public System.Windows.Media.Brush MouseOverBackground { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Media.Brush MouseOverBorderBrush { get { return default(System.Windows.Media.Brush); } set { } }
    public object QuickAccessToolBarId { get { return default(object); } set { } }
    public System.Windows.Controls.Ribbon.Ribbon Ribbon { get { return default(System.Windows.Controls.Ribbon.Ribbon); } }
    public System.Windows.Media.ImageSource SmallImageSource { get { return default(System.Windows.Media.ImageSource); } set { } }
    public string ToolTipDescription { get { return default(string); } set { } }
    public string ToolTipFooterDescription { get { return default(string); } set { } }
    public System.Windows.Media.ImageSource ToolTipFooterImageSource { get { return default(System.Windows.Media.ImageSource); } set { } }
    public string ToolTipFooterTitle { get { return default(string); } set { } }
    public System.Windows.Media.ImageSource ToolTipImageSource { get { return default(System.Windows.Media.ImageSource); } set { } }
    public string ToolTipTitle { get { return default(string); } set { } }
    protected override void ClearContainerForItemOverride(System.Windows.DependencyObject element, object item) { }
    protected override System.Windows.DependencyObject GetContainerForItemOverride() { return default(System.Windows.DependencyObject); }
    protected override bool IsItemItsOwnContainerOverride(object item) { return default(bool); }
    protected override System.Windows.Size MeasureOverride(System.Windows.Size availableSize) { return default(System.Windows.Size); }
    protected virtual void OnActivatingKeyTip(System.Windows.Controls.ActivatingKeyTipEventArgs e) { }
    public override void OnApplyTemplate() { }
    protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { return default(System.Windows.Automation.Peers.AutomationPeer); }
    protected override void OnItemsChanged(System.Collections.Specialized.NotifyCollectionChangedEventArgs e) { }
    protected override void OnKeyDown(System.Windows.Input.KeyEventArgs e) { }
    protected virtual void OnKeyTipAccessed(System.Windows.Controls.KeyTipAccessedEventArgs e) { }
    protected override void OnMouseEnter(System.Windows.Input.MouseEventArgs e) { }
    protected override void OnMouseLeave(System.Windows.Input.MouseEventArgs e) { }
    protected override void OnPreviewMouseDown(System.Windows.Input.MouseButtonEventArgs e) { }
    protected internal override void OnRenderSizeChanged(System.Windows.SizeChangedInfo info) { }
    protected override void PrepareContainerForItemOverride(System.Windows.DependencyObject element, object item) { }
  }
  [System.Windows.Markup.ContentPropertyAttribute("ControlSizeDefinitions")]
  public partial class RibbonGroupSizeDefinition : System.Windows.Controls.Ribbon.RibbonGroupSizeDefinitionBase {
    public static readonly System.Windows.DependencyProperty ControlSizeDefinitionsProperty;
    public RibbonGroupSizeDefinition() { }
    public System.Windows.Controls.Ribbon.RibbonControlSizeDefinitionCollection ControlSizeDefinitions { get { return default(System.Windows.Controls.Ribbon.RibbonControlSizeDefinitionCollection); } set { } }
    protected override System.Windows.Freezable CreateInstanceCore() { return default(System.Windows.Freezable); }
  }
  public abstract partial class RibbonGroupSizeDefinitionBase : System.Windows.Freezable {
    public static readonly System.Windows.DependencyProperty IsCollapsedProperty;
    protected RibbonGroupSizeDefinitionBase() { }
    public bool IsCollapsed { get { return default(bool); } set { } }
  }
  public partial class RibbonGroupSizeDefinitionBaseCollection : System.Windows.FreezableCollection<System.Windows.Controls.Ribbon.RibbonGroupSizeDefinitionBase> {
    public RibbonGroupSizeDefinitionBaseCollection() { }
    protected override System.Windows.Freezable CreateInstanceCore() { return default(System.Windows.Freezable); }
  }
  [System.Windows.Markup.ContentPropertyAttribute("ContentTemplate")]
  public partial class RibbonGroupTemplateSizeDefinition : System.Windows.Controls.Ribbon.RibbonGroupSizeDefinitionBase {
    public static readonly System.Windows.DependencyProperty ContentTemplateProperty;
    public RibbonGroupTemplateSizeDefinition() { }
    public System.Windows.DataTemplate ContentTemplate { get { return default(System.Windows.DataTemplate); } set { } }
    protected override System.Windows.Freezable CreateInstanceCore() { return default(System.Windows.Freezable); }
  }
  public enum RibbonImageSize {
    Collapsed = 0,
    Large = 2,
    Small = 1,
  }
  [System.Windows.StyleTypedPropertyAttribute(Property="ItemContainerStyle", StyleTargetType=typeof(System.Windows.Controls.Ribbon.RibbonMenuItem))]
  [System.Windows.TemplatePartAttribute(Name="PART_Popup", Type=typeof(System.Windows.Controls.Primitives.Popup))]
  [System.Windows.TemplatePartAttribute(Name="PART_ResizeThumb", Type=typeof(System.Windows.Controls.Primitives.Thumb))]
  [System.Windows.TemplatePartAttribute(Name="PART_SubMenuScrollViewer", Type=typeof(System.Windows.Controls.ScrollViewer))]
  [System.Windows.TemplatePartAttribute(Name="PART_ToggleButton", Type=typeof(System.Windows.Controls.Ribbon.RibbonToggleButton))]
  public partial class RibbonMenuButton : System.Windows.Controls.Menu {
    public static readonly System.Windows.DependencyProperty CanAddToQuickAccessToolBarDirectlyProperty;
    public static readonly System.Windows.DependencyProperty CanUserResizeHorizontallyProperty;
    public static readonly System.Windows.DependencyProperty CanUserResizeVerticallyProperty;
    public static readonly System.Windows.DependencyProperty ControlSizeDefinitionProperty;
    public static readonly System.Windows.DependencyProperty DropDownHeightProperty;
    public static readonly System.Windows.DependencyProperty FocusedBackgroundProperty;
    public static readonly System.Windows.DependencyProperty FocusedBorderBrushProperty;
    public static readonly System.Windows.DependencyProperty HasGalleryProperty;
    public static readonly System.Windows.DependencyProperty IsDropDownOpenProperty;
    public static readonly System.Windows.DependencyProperty IsDropDownPositionedAboveProperty;
    public static readonly System.Windows.DependencyProperty IsInControlGroupProperty;
    public static readonly System.Windows.DependencyProperty IsInQuickAccessToolBarProperty;
    public static readonly System.Windows.DependencyProperty KeyTipProperty;
    public static readonly System.Windows.DependencyProperty LabelProperty;
    public static readonly System.Windows.DependencyProperty LargeImageSourceProperty;
    public static readonly System.Windows.DependencyProperty MouseOverBackgroundProperty;
    public static readonly System.Windows.DependencyProperty MouseOverBorderBrushProperty;
    public static readonly System.Windows.DependencyProperty PressedBackgroundProperty;
    public static readonly System.Windows.DependencyProperty PressedBorderBrushProperty;
    public static readonly System.Windows.DependencyProperty QuickAccessToolBarControlSizeDefinitionProperty;
    public static readonly System.Windows.DependencyProperty QuickAccessToolBarIdProperty;
    public static readonly System.Windows.DependencyProperty RibbonProperty;
    public static readonly System.Windows.DependencyProperty SmallImageSourceProperty;
    public static readonly System.Windows.DependencyProperty ToolTipDescriptionProperty;
    public static readonly System.Windows.DependencyProperty ToolTipFooterDescriptionProperty;
    public static readonly System.Windows.DependencyProperty ToolTipFooterImageSourceProperty;
    public static readonly System.Windows.DependencyProperty ToolTipFooterTitleProperty;
    public static readonly System.Windows.DependencyProperty ToolTipImageSourceProperty;
    public static readonly System.Windows.DependencyProperty ToolTipTitleProperty;
    public RibbonMenuButton() { }
    public bool CanAddToQuickAccessToolBarDirectly { get { return default(bool); } set { } }
    public bool CanUserResizeHorizontally { get { return default(bool); } set { } }
    public bool CanUserResizeVertically { get { return default(bool); } set { } }
    public System.Windows.Controls.Ribbon.RibbonControlSizeDefinition ControlSizeDefinition { get { return default(System.Windows.Controls.Ribbon.RibbonControlSizeDefinition); } set { } }
    public double DropDownHeight { get { return default(double); } set { } }
    public System.Windows.Media.Brush FocusedBackground { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Media.Brush FocusedBorderBrush { get { return default(System.Windows.Media.Brush); } set { } }
    protected internal override bool HandlesScrolling { get { return default(bool); } }
    public bool HasGallery { get { return default(bool); } }
    public bool IsDropDownOpen { get { return default(bool); } set { } }
    public bool IsDropDownPositionedAbove { get { return default(bool); } }
    public bool IsInControlGroup { get { return default(bool); } }
    public bool IsInQuickAccessToolBar { get { return default(bool); } }
    public string KeyTip { get { return default(string); } set { } }
    public string Label { get { return default(string); } set { } }
    public System.Windows.Media.ImageSource LargeImageSource { get { return default(System.Windows.Media.ImageSource); } set { } }
    public System.Windows.Media.Brush MouseOverBackground { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Media.Brush MouseOverBorderBrush { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Media.Brush PressedBackground { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Media.Brush PressedBorderBrush { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Controls.Ribbon.RibbonControlSizeDefinition QuickAccessToolBarControlSizeDefinition { get { return default(System.Windows.Controls.Ribbon.RibbonControlSizeDefinition); } set { } }
    public object QuickAccessToolBarId { get { return default(object); } set { } }
    public System.Windows.Controls.Ribbon.Ribbon Ribbon { get { return default(System.Windows.Controls.Ribbon.Ribbon); } }
    public System.Windows.Media.ImageSource SmallImageSource { get { return default(System.Windows.Media.ImageSource); } set { } }
    public string ToolTipDescription { get { return default(string); } set { } }
    public string ToolTipFooterDescription { get { return default(string); } set { } }
    public System.Windows.Media.ImageSource ToolTipFooterImageSource { get { return default(System.Windows.Media.ImageSource); } set { } }
    public string ToolTipFooterTitle { get { return default(string); } set { } }
    public System.Windows.Media.ImageSource ToolTipImageSource { get { return default(System.Windows.Media.ImageSource); } set { } }
    public string ToolTipTitle { get { return default(string); } set { } }
    public event System.EventHandler DropDownClosed { add { } remove { } }
    public event System.EventHandler DropDownOpened { add { } remove { } }
    protected override void ClearContainerForItemOverride(System.Windows.DependencyObject element, object item) { }
    protected override System.Windows.DependencyObject GetContainerForItemOverride() { return default(System.Windows.DependencyObject); }
    protected override void HandleMouseButton(System.Windows.Input.MouseButtonEventArgs e) { }
    protected override bool IsItemItsOwnContainerOverride(object item) { return default(bool); }
    protected virtual void OnActivatingKeyTip(System.Windows.Controls.ActivatingKeyTipEventArgs e) { }
    public override void OnApplyTemplate() { }
    protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { return default(System.Windows.Automation.Peers.AutomationPeer); }
    protected virtual void OnDismissPopup(System.Windows.Controls.Ribbon.RibbonDismissPopupEventArgs e) { }
    protected override void OnGotKeyboardFocus(System.Windows.Input.KeyboardFocusChangedEventArgs e) { }
    protected override void OnIsKeyboardFocusWithinChanged(System.Windows.DependencyPropertyChangedEventArgs e) { }
    protected override void OnKeyDown(System.Windows.Input.KeyEventArgs e) { }
    protected virtual void OnKeyTipAccessed(System.Windows.Controls.KeyTipAccessedEventArgs e) { }
    protected override void OnKeyUp(System.Windows.Input.KeyEventArgs e) { }
    protected override void OnPreviewKeyDown(System.Windows.Input.KeyEventArgs e) { }
    protected override void OnPreviewMouseDown(System.Windows.Input.MouseButtonEventArgs e) { }
    protected override void OnTemplateChanged(System.Windows.Controls.ControlTemplate oldTemplate, System.Windows.Controls.ControlTemplate newTemplate) { }
    protected override void PrepareContainerForItemOverride(System.Windows.DependencyObject element, object item) { }
    protected override bool ShouldApplyItemContainerStyle(System.Windows.DependencyObject container, object item) { return default(bool); }
  }
  [System.Windows.StyleTypedPropertyAttribute(Property="ItemContainerStyle", StyleTargetType=typeof(System.Windows.Controls.Ribbon.RibbonMenuItem))]
  [System.Windows.TemplatePartAttribute(Name="PART_Popup", Type=typeof(System.Windows.Controls.Primitives.Popup))]
  [System.Windows.TemplatePartAttribute(Name="PART_ResizeThumb", Type=typeof(System.Windows.Controls.Primitives.Thumb))]
  [System.Windows.TemplatePartAttribute(Name="PART_SideBarBorder", Type=typeof(System.Windows.Controls.Border))]
  [System.Windows.TemplatePartAttribute(Name="PART_SubMenuScrollViewer", Type=typeof(System.Windows.Controls.ScrollViewer))]
  public partial class RibbonMenuItem : System.Windows.Controls.MenuItem {
    public static readonly System.Windows.DependencyProperty CanAddToQuickAccessToolBarDirectlyProperty;
    public static readonly System.Windows.DependencyProperty CanUserResizeHorizontallyProperty;
    public static readonly System.Windows.DependencyProperty CanUserResizeVerticallyProperty;
    public static readonly System.Windows.DependencyProperty CheckedBackgroundProperty;
    public static readonly System.Windows.DependencyProperty CheckedBorderBrushProperty;
    public static readonly System.Windows.DependencyProperty DropDownHeightProperty;
    public static readonly System.Windows.DependencyProperty HasGalleryProperty;
    public static readonly System.Windows.DependencyProperty ImageSourceProperty;
    public static readonly System.Windows.DependencyProperty IsDropDownPositionedLeftProperty;
    public static readonly System.Windows.DependencyProperty KeyTipProperty;
    public static readonly System.Windows.DependencyProperty MouseOverBackgroundProperty;
    public static readonly System.Windows.DependencyProperty MouseOverBorderBrushProperty;
    public static readonly System.Windows.DependencyProperty PressedBackgroundProperty;
    public static readonly System.Windows.DependencyProperty PressedBorderBrushProperty;
    public static readonly System.Windows.DependencyProperty QuickAccessToolBarIdProperty;
    public static readonly System.Windows.DependencyProperty QuickAccessToolBarImageSourceProperty;
    public static readonly System.Windows.DependencyProperty RibbonProperty;
    public static readonly System.Windows.DependencyProperty ToolTipDescriptionProperty;
    public static readonly System.Windows.DependencyProperty ToolTipFooterDescriptionProperty;
    public static readonly System.Windows.DependencyProperty ToolTipFooterImageSourceProperty;
    public static readonly System.Windows.DependencyProperty ToolTipFooterTitleProperty;
    public static readonly System.Windows.DependencyProperty ToolTipImageSourceProperty;
    public static readonly System.Windows.DependencyProperty ToolTipTitleProperty;
    public RibbonMenuItem() { }
    public bool CanAddToQuickAccessToolBarDirectly { get { return default(bool); } set { } }
    public bool CanUserResizeHorizontally { get { return default(bool); } set { } }
    public bool CanUserResizeVertically { get { return default(bool); } set { } }
    public System.Windows.Media.Brush CheckedBackground { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Media.Brush CheckedBorderBrush { get { return default(System.Windows.Media.Brush); } set { } }
    public double DropDownHeight { get { return default(double); } set { } }
    public bool HasGallery { get { return default(bool); } }
    public System.Windows.Media.ImageSource ImageSource { get { return default(System.Windows.Media.ImageSource); } set { } }
    public bool IsDropDownPositionedLeft { get { return default(bool); } }
    public string KeyTip { get { return default(string); } set { } }
    public System.Windows.Media.Brush MouseOverBackground { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Media.Brush MouseOverBorderBrush { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Media.Brush PressedBackground { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Media.Brush PressedBorderBrush { get { return default(System.Windows.Media.Brush); } set { } }
    public object QuickAccessToolBarId { get { return default(object); } set { } }
    public System.Windows.Media.ImageSource QuickAccessToolBarImageSource { get { return default(System.Windows.Media.ImageSource); } set { } }
    public System.Windows.Controls.Ribbon.Ribbon Ribbon { get { return default(System.Windows.Controls.Ribbon.Ribbon); } }
    public string ToolTipDescription { get { return default(string); } set { } }
    public string ToolTipFooterDescription { get { return default(string); } set { } }
    public System.Windows.Media.ImageSource ToolTipFooterImageSource { get { return default(System.Windows.Media.ImageSource); } set { } }
    public string ToolTipFooterTitle { get { return default(string); } set { } }
    public System.Windows.Media.ImageSource ToolTipImageSource { get { return default(System.Windows.Media.ImageSource); } set { } }
    public string ToolTipTitle { get { return default(string); } set { } }
    protected override void ClearContainerForItemOverride(System.Windows.DependencyObject element, object item) { }
    protected override System.Windows.DependencyObject GetContainerForItemOverride() { return default(System.Windows.DependencyObject); }
    protected override bool IsItemItsOwnContainerOverride(object item) { return default(bool); }
    protected virtual void OnActivatingKeyTip(System.Windows.Controls.ActivatingKeyTipEventArgs e) { }
    public override void OnApplyTemplate() { }
    protected override void OnClick() { }
    protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { return default(System.Windows.Automation.Peers.AutomationPeer); }
    protected override void OnGotKeyboardFocus(System.Windows.Input.KeyboardFocusChangedEventArgs e) { }
    protected override void OnIsKeyboardFocusWithinChanged(System.Windows.DependencyPropertyChangedEventArgs e) { }
    protected override void OnKeyDown(System.Windows.Input.KeyEventArgs e) { }
    protected virtual void OnKeyTipAccessed(System.Windows.Controls.KeyTipAccessedEventArgs e) { }
    protected override void OnLostKeyboardFocus(System.Windows.Input.KeyboardFocusChangedEventArgs e) { }
    protected override void OnMouseEnter(System.Windows.Input.MouseEventArgs e) { }
    protected override void OnMouseLeave(System.Windows.Input.MouseEventArgs e) { }
    protected override void OnMouseLeftButtonDown(System.Windows.Input.MouseButtonEventArgs e) { }
    protected override void OnPreviewKeyUp(System.Windows.Input.KeyEventArgs e) { }
    protected override void PrepareContainerForItemOverride(System.Windows.DependencyObject element, object item) { }
    protected override bool ShouldApplyItemContainerStyle(System.Windows.DependencyObject container, object item) { return default(bool); }
  }
  [System.Windows.TemplatePartAttribute(Name="PART_MainPanel", Type=typeof(System.Windows.Controls.Ribbon.Primitives.RibbonQuickAccessToolBarPanel))]
  [System.Windows.TemplatePartAttribute(Name="PART_OverflowButton", Type=typeof(System.Windows.Controls.Ribbon.RibbonToggleButton))]
  [System.Windows.TemplatePartAttribute(Name="PART_OverflowPanel", Type=typeof(System.Windows.Controls.Ribbon.Primitives.RibbonQuickAccessToolBarOverflowPanel))]
  [System.Windows.TemplatePartAttribute(Name="PART_OverflowPopup", Type=typeof(System.Windows.Controls.Primitives.Popup))]
  public partial class RibbonQuickAccessToolBar : System.Windows.Controls.ItemsControl {
    public static readonly System.Windows.RoutedEvent CloneEvent;
    public static readonly System.Windows.DependencyProperty CustomizeMenuButtonProperty;
    public static readonly System.Windows.DependencyProperty HasOverflowItemsProperty;
    public static readonly System.Windows.DependencyProperty IsOverflowItemProperty;
    public static readonly System.Windows.DependencyProperty IsOverflowOpenProperty;
    public static readonly System.Windows.DependencyProperty RibbonProperty;
    public RibbonQuickAccessToolBar() { }
    public System.Windows.Controls.Ribbon.RibbonMenuButton CustomizeMenuButton { get { return default(System.Windows.Controls.Ribbon.RibbonMenuButton); } set { } }
    public bool HasOverflowItems { get { return default(bool); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public bool IsOverflowOpen { get { return default(bool); } set { } }
    public System.Windows.Controls.Ribbon.Ribbon Ribbon { get { return default(System.Windows.Controls.Ribbon.Ribbon); } }
    public static void AddCloneHandler(System.Windows.DependencyObject element, System.Windows.Controls.Ribbon.RibbonQuickAccessToolBarCloneEventHandler handler) { }
    protected override void ClearContainerForItemOverride(System.Windows.DependencyObject element, object item) { }
    protected override System.Windows.DependencyObject GetContainerForItemOverride() { return default(System.Windows.DependencyObject); }
    public static bool GetIsOverflowItem(System.Windows.DependencyObject element) { return default(bool); }
    protected override bool IsItemItsOwnContainerOverride(object item) { return default(bool); }
    protected virtual void OnActivatingKeyTip(System.Windows.Controls.ActivatingKeyTipEventArgs e) { }
    public override void OnApplyTemplate() { }
    protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { return default(System.Windows.Automation.Peers.AutomationPeer); }
    protected override void OnItemsChanged(System.Collections.Specialized.NotifyCollectionChangedEventArgs e) { }
    protected override void OnKeyDown(System.Windows.Input.KeyEventArgs e) { }
    protected virtual void OnPreviewKeyTipAccessed(System.Windows.Controls.KeyTipAccessedEventArgs e) { }
    protected override void PrepareContainerForItemOverride(System.Windows.DependencyObject element, object item) { }
    public static void RemoveCloneHandler(System.Windows.DependencyObject element, System.Windows.Controls.Ribbon.RibbonQuickAccessToolBarCloneEventHandler handler) { }
  }
  public partial class RibbonQuickAccessToolBarCloneEventArgs : System.Windows.RoutedEventArgs {
    public RibbonQuickAccessToolBarCloneEventArgs(System.Windows.UIElement targetElement) { }
    public System.Windows.UIElement CloneInstance { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Windows.UIElement); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Windows.UIElement InstanceToBeCloned { get { return default(System.Windows.UIElement); } }
    protected override void InvokeEventHandler(System.Delegate genericHandler, object genericTarget) { }
  }
  public delegate void RibbonQuickAccessToolBarCloneEventHandler(object sender, System.Windows.Controls.Ribbon.RibbonQuickAccessToolBarCloneEventArgs e);
  [System.Windows.TemplatePartAttribute(Name="PART_Image", Type=typeof(System.Windows.Controls.Image))]
  public partial class RibbonRadioButton : System.Windows.Controls.RadioButton {
    public static readonly System.Windows.DependencyProperty CanAddToQuickAccessToolBarDirectlyProperty;
    public static readonly System.Windows.DependencyProperty CheckedBackgroundProperty;
    public static readonly System.Windows.DependencyProperty CheckedBorderBrushProperty;
    public static readonly System.Windows.DependencyProperty ControlSizeDefinitionProperty;
    public static readonly System.Windows.DependencyProperty CornerRadiusProperty;
    public static readonly System.Windows.DependencyProperty FocusedBackgroundProperty;
    public static readonly System.Windows.DependencyProperty FocusedBorderBrushProperty;
    public static readonly System.Windows.DependencyProperty IsInControlGroupProperty;
    public static readonly System.Windows.DependencyProperty IsInQuickAccessToolBarProperty;
    public static readonly System.Windows.DependencyProperty KeyTipProperty;
    public static readonly System.Windows.DependencyProperty LabelProperty;
    public static readonly System.Windows.DependencyProperty LargeImageSourceProperty;
    public static readonly System.Windows.DependencyProperty MouseOverBackgroundProperty;
    public static readonly System.Windows.DependencyProperty MouseOverBorderBrushProperty;
    public static readonly System.Windows.DependencyProperty PressedBackgroundProperty;
    public static readonly System.Windows.DependencyProperty PressedBorderBrushProperty;
    public static readonly System.Windows.DependencyProperty QuickAccessToolBarControlSizeDefinitionProperty;
    public static readonly System.Windows.DependencyProperty QuickAccessToolBarIdProperty;
    public static readonly System.Windows.DependencyProperty RibbonProperty;
    public static readonly System.Windows.DependencyProperty ShowKeyboardCuesProperty;
    public static readonly System.Windows.DependencyProperty SmallImageSourceProperty;
    public static readonly System.Windows.DependencyProperty ToolTipDescriptionProperty;
    public static readonly System.Windows.DependencyProperty ToolTipFooterDescriptionProperty;
    public static readonly System.Windows.DependencyProperty ToolTipFooterImageSourceProperty;
    public static readonly System.Windows.DependencyProperty ToolTipFooterTitleProperty;
    public static readonly System.Windows.DependencyProperty ToolTipImageSourceProperty;
    public static readonly System.Windows.DependencyProperty ToolTipTitleProperty;
    public RibbonRadioButton() { }
    public bool CanAddToQuickAccessToolBarDirectly { get { return default(bool); } set { } }
    public System.Windows.Media.Brush CheckedBackground { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Media.Brush CheckedBorderBrush { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Controls.Ribbon.RibbonControlSizeDefinition ControlSizeDefinition { get { return default(System.Windows.Controls.Ribbon.RibbonControlSizeDefinition); } set { } }
    public System.Windows.CornerRadius CornerRadius { get { return default(System.Windows.CornerRadius); } set { } }
    public System.Windows.Media.Brush FocusedBackground { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Media.Brush FocusedBorderBrush { get { return default(System.Windows.Media.Brush); } set { } }
    public bool IsInControlGroup { get { return default(bool); } }
    public bool IsInQuickAccessToolBar { get { return default(bool); } }
    public string KeyTip { get { return default(string); } set { } }
    public string Label { get { return default(string); } set { } }
    public System.Windows.Media.ImageSource LargeImageSource { get { return default(System.Windows.Media.ImageSource); } set { } }
    public System.Windows.Media.Brush MouseOverBackground { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Media.Brush MouseOverBorderBrush { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Media.Brush PressedBackground { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Media.Brush PressedBorderBrush { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Controls.Ribbon.RibbonControlSizeDefinition QuickAccessToolBarControlSizeDefinition { get { return default(System.Windows.Controls.Ribbon.RibbonControlSizeDefinition); } set { } }
    public object QuickAccessToolBarId { get { return default(object); } set { } }
    public System.Windows.Controls.Ribbon.Ribbon Ribbon { get { return default(System.Windows.Controls.Ribbon.Ribbon); } }
    public bool ShowKeyboardCues { get { return default(bool); } }
    public System.Windows.Media.ImageSource SmallImageSource { get { return default(System.Windows.Media.ImageSource); } set { } }
    public string ToolTipDescription { get { return default(string); } set { } }
    public string ToolTipFooterDescription { get { return default(string); } set { } }
    public System.Windows.Media.ImageSource ToolTipFooterImageSource { get { return default(System.Windows.Media.ImageSource); } set { } }
    public string ToolTipFooterTitle { get { return default(string); } set { } }
    public System.Windows.Media.ImageSource ToolTipImageSource { get { return default(System.Windows.Media.ImageSource); } set { } }
    public string ToolTipTitle { get { return default(string); } set { } }
    protected virtual void OnActivatingKeyTip(System.Windows.Controls.ActivatingKeyTipEventArgs e) { }
    public override void OnApplyTemplate() { }
    protected override void OnClick() { }
    protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { return default(System.Windows.Automation.Peers.AutomationPeer); }
    protected override void OnGotKeyboardFocus(System.Windows.Input.KeyboardFocusChangedEventArgs e) { }
    protected virtual void OnKeyTipAccessed(System.Windows.Controls.KeyTipAccessedEventArgs e) { }
    protected override void OnLostKeyboardFocus(System.Windows.Input.KeyboardFocusChangedEventArgs e) { }
    protected override void OnMouseLeftButtonDown(System.Windows.Input.MouseButtonEventArgs e) { }
  }
  public partial class RibbonSeparator : System.Windows.Controls.Separator {
    public static readonly System.Windows.DependencyProperty LabelProperty;
    public static readonly System.Windows.DependencyProperty RibbonProperty;
    public RibbonSeparator() { }
    public string Label { get { return default(string); } set { } }
    public System.Windows.Controls.Ribbon.Ribbon Ribbon { get { return default(System.Windows.Controls.Ribbon.Ribbon); } }
    protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { return default(System.Windows.Automation.Peers.AutomationPeer); }
    protected override void OnPropertyChanged(System.Windows.DependencyPropertyChangedEventArgs e) { }
    protected internal override void OnVisualParentChanged(System.Windows.DependencyObject oldParent) { }
  }
  [System.Windows.TemplatePartAttribute(Name="PART_HeaderButton", Type=typeof(System.Windows.Controls.Primitives.ButtonBase))]
  [System.Windows.TemplatePartAttribute(Name="PART_ToggleButton", Type=typeof(System.Windows.Controls.Ribbon.RibbonToggleButton))]
  public partial class RibbonSplitButton : System.Windows.Controls.Ribbon.RibbonMenuButton, System.Windows.Input.ICommandSource {
    public static readonly System.Windows.DependencyProperty CheckedBackgroundProperty;
    public static readonly System.Windows.DependencyProperty CheckedBorderBrushProperty;
    public static readonly System.Windows.RoutedEvent ClickEvent;
    public static readonly System.Windows.DependencyProperty CommandParameterProperty;
    public static readonly System.Windows.DependencyProperty CommandProperty;
    public static readonly System.Windows.DependencyProperty CommandTargetProperty;
    public static readonly System.Windows.DependencyProperty DropDownToolTipDescriptionProperty;
    public static readonly System.Windows.DependencyProperty DropDownToolTipFooterDescriptionProperty;
    public static readonly System.Windows.DependencyProperty DropDownToolTipFooterImageSourceProperty;
    public static readonly System.Windows.DependencyProperty DropDownToolTipFooterTitleProperty;
    public static readonly System.Windows.DependencyProperty DropDownToolTipImageSourceProperty;
    public static readonly System.Windows.DependencyProperty DropDownToolTipTitleProperty;
    public static readonly System.Windows.DependencyProperty HeaderKeyTipProperty;
    public static readonly System.Windows.DependencyProperty HeaderQuickAccessToolBarIdProperty;
    public static readonly System.Windows.DependencyProperty IsCheckableProperty;
    public static readonly System.Windows.DependencyProperty IsCheckedProperty;
    public static readonly System.Windows.DependencyProperty LabelPositionProperty;
    public RibbonSplitButton() { }
    public System.Windows.Media.Brush CheckedBackground { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Media.Brush CheckedBorderBrush { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Input.ICommand Command { get { return default(System.Windows.Input.ICommand); } set { } }
    public object CommandParameter { get { return default(object); } set { } }
    public System.Windows.IInputElement CommandTarget { get { return default(System.Windows.IInputElement); } set { } }
    public string DropDownToolTipDescription { get { return default(string); } set { } }
    public string DropDownToolTipFooterDescription { get { return default(string); } set { } }
    public System.Windows.Media.ImageSource DropDownToolTipFooterImageSource { get { return default(System.Windows.Media.ImageSource); } set { } }
    public string DropDownToolTipFooterTitle { get { return default(string); } set { } }
    public System.Windows.Media.ImageSource DropDownToolTipImageSource { get { return default(System.Windows.Media.ImageSource); } set { } }
    public string DropDownToolTipTitle { get { return default(string); } set { } }
    public string HeaderKeyTip { get { return default(string); } set { } }
    public object HeaderQuickAccessToolBarId { get { return default(object); } set { } }
    public bool IsCheckable { get { return default(bool); } set { } }
    public bool IsChecked { get { return default(bool); } set { } }
    public System.Windows.Controls.Ribbon.RibbonSplitButtonLabelPosition LabelPosition { get { return default(System.Windows.Controls.Ribbon.RibbonSplitButtonLabelPosition); } set { } }
    public event System.Windows.RoutedEventHandler Click { add { } remove { } }
    protected override void OnActivatingKeyTip(System.Windows.Controls.ActivatingKeyTipEventArgs e) { }
    public override void OnApplyTemplate() { }
    protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { return default(System.Windows.Automation.Peers.AutomationPeer); }
  }
  public enum RibbonSplitButtonLabelPosition {
    DropDown = 1,
    Header = 0,
  }
  [System.Windows.TemplatePartAttribute(Name="PART_ArrowToggleButton", Type=typeof(System.Windows.Controls.Ribbon.RibbonToggleButton))]
  [System.Windows.TemplatePartAttribute(Name="PART_HeaderButton", Type=typeof(System.Windows.Controls.Ribbon.RibbonButton))]
  [System.Windows.TemplatePartAttribute(Name="PART_SideBarBorder", Type=typeof(System.Windows.Controls.Border))]
  public partial class RibbonSplitMenuItem : System.Windows.Controls.Ribbon.RibbonMenuItem {
    public static readonly System.Windows.DependencyProperty DropDownToolTipDescriptionProperty;
    public static readonly System.Windows.DependencyProperty DropDownToolTipFooterDescriptionProperty;
    public static readonly System.Windows.DependencyProperty DropDownToolTipFooterImageSourceProperty;
    public static readonly System.Windows.DependencyProperty DropDownToolTipFooterTitleProperty;
    public static readonly System.Windows.DependencyProperty DropDownToolTipImageSourceProperty;
    public static readonly System.Windows.DependencyProperty DropDownToolTipTitleProperty;
    public static readonly System.Windows.DependencyProperty HeaderKeyTipProperty;
    public static readonly System.Windows.DependencyProperty HeaderQuickAccessToolBarIdProperty;
    public RibbonSplitMenuItem() { }
    public string DropDownToolTipDescription { get { return default(string); } set { } }
    public string DropDownToolTipFooterDescription { get { return default(string); } set { } }
    public System.Windows.Media.ImageSource DropDownToolTipFooterImageSource { get { return default(System.Windows.Media.ImageSource); } set { } }
    public string DropDownToolTipFooterTitle { get { return default(string); } set { } }
    public System.Windows.Media.ImageSource DropDownToolTipImageSource { get { return default(System.Windows.Media.ImageSource); } set { } }
    public string DropDownToolTipTitle { get { return default(string); } set { } }
    public string HeaderKeyTip { get { return default(string); } set { } }
    public object HeaderQuickAccessToolBarId { get { return default(object); } set { } }
    protected override bool IsEnabledCore { get { return default(bool); } }
    protected override void OnActivatingKeyTip(System.Windows.Controls.ActivatingKeyTipEventArgs e) { }
    public override void OnApplyTemplate() { }
    protected override void OnKeyDown(System.Windows.Input.KeyEventArgs e) { }
    protected override void OnKeyTipAccessed(System.Windows.Controls.KeyTipAccessedEventArgs e) { }
  }
  [System.Windows.StyleTypedPropertyAttribute(Property="HeaderStyle", StyleTargetType=typeof(System.Windows.Controls.Ribbon.RibbonTabHeader))]
  public partial class RibbonTab : System.Windows.Controls.HeaderedItemsControl {
    public static readonly System.Windows.DependencyProperty ContextualTabGroupHeaderProperty;
    public static readonly System.Windows.DependencyProperty ContextualTabGroupProperty;
    public static readonly System.Windows.DependencyProperty GroupSizeReductionOrderProperty;
    public static readonly System.Windows.DependencyProperty HeaderStyleProperty;
    public static readonly System.Windows.DependencyProperty IsSelectedProperty;
    public static readonly System.Windows.DependencyProperty KeyTipProperty;
    public static readonly System.Windows.DependencyProperty RibbonProperty;
    public static readonly System.Windows.DependencyProperty TabHeaderLeftProperty;
    public static readonly System.Windows.DependencyProperty TabHeaderRightProperty;
    public RibbonTab() { }
    public System.Windows.Controls.Ribbon.RibbonContextualTabGroup ContextualTabGroup { get { return default(System.Windows.Controls.Ribbon.RibbonContextualTabGroup); } }
    public object ContextualTabGroupHeader { get { return default(object); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Controls.Ribbon.StringCollectionConverter))]
    public System.Collections.Specialized.StringCollection GroupSizeReductionOrder { get { return default(System.Collections.Specialized.StringCollection); } set { } }
    protected internal override bool HandlesScrolling { get { return default(bool); } }
    public System.Windows.Style HeaderStyle { get { return default(System.Windows.Style); } set { } }
    public bool IsSelected { get { return default(bool); } set { } }
    public string KeyTip { get { return default(string); } set { } }
    public System.Windows.Controls.Ribbon.Ribbon Ribbon { get { return default(System.Windows.Controls.Ribbon.Ribbon); } }
    public double TabHeaderLeft { get { return default(double); } }
    public double TabHeaderRight { get { return default(double); } }
    protected override void ClearContainerForItemOverride(System.Windows.DependencyObject element, object item) { }
    protected override System.Windows.DependencyObject GetContainerForItemOverride() { return default(System.Windows.DependencyObject); }
    protected override bool IsItemItsOwnContainerOverride(object item) { return default(bool); }
    protected virtual void OnActivatingKeyTip(System.Windows.Controls.ActivatingKeyTipEventArgs e) { }
    protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { return default(System.Windows.Automation.Peers.AutomationPeer); }
    protected override void OnItemsChanged(System.Collections.Specialized.NotifyCollectionChangedEventArgs e) { }
    protected override void OnKeyDown(System.Windows.Input.KeyEventArgs e) { }
    protected virtual void OnKeyTipAccessed(System.Windows.Controls.KeyTipAccessedEventArgs e) { }
    protected virtual void OnSelected(System.Windows.RoutedEventArgs e) { }
    protected virtual void OnUnselected(System.Windows.RoutedEventArgs e) { }
    protected override void PrepareContainerForItemOverride(System.Windows.DependencyObject element, object item) { }
  }
  [System.Windows.TemplatePartAttribute(Name="PART_OuterBorder", Type=typeof(System.Windows.Controls.Border))]
  public partial class RibbonTabHeader : System.Windows.Controls.ContentControl {
    public static readonly System.Windows.DependencyProperty CheckedBackgroundProperty;
    public static readonly System.Windows.DependencyProperty CheckedBorderBrushProperty;
    public static readonly System.Windows.DependencyProperty ContextualTabGroupProperty;
    public static readonly System.Windows.DependencyProperty FocusedBackgroundProperty;
    public static readonly System.Windows.DependencyProperty FocusedBorderBrushProperty;
    public static readonly System.Windows.DependencyProperty IsContextualTabProperty;
    public static readonly System.Windows.DependencyProperty IsRibbonTabSelectedProperty;
    public static readonly System.Windows.DependencyProperty MouseOverBackgroundProperty;
    public static readonly System.Windows.DependencyProperty MouseOverBorderBrushProperty;
    public static readonly System.Windows.DependencyProperty RibbonProperty;
    public RibbonTabHeader() { }
    public System.Windows.Media.Brush CheckedBackground { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Media.Brush CheckedBorderBrush { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Controls.Ribbon.RibbonContextualTabGroup ContextualTabGroup { get { return default(System.Windows.Controls.Ribbon.RibbonContextualTabGroup); } }
    public System.Windows.Media.Brush FocusedBackground { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Media.Brush FocusedBorderBrush { get { return default(System.Windows.Media.Brush); } set { } }
    public bool IsContextualTab { get { return default(bool); } }
    public bool IsRibbonTabSelected { get { return default(bool); } }
    public System.Windows.Media.Brush MouseOverBackground { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Media.Brush MouseOverBorderBrush { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Controls.Ribbon.Ribbon Ribbon { get { return default(System.Windows.Controls.Ribbon.Ribbon); } }
    protected virtual void OnActivatingKeyTip(System.Windows.Controls.ActivatingKeyTipEventArgs e) { }
    public override void OnApplyTemplate() { }
    protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { return default(System.Windows.Automation.Peers.AutomationPeer); }
    protected override void OnGotKeyboardFocus(System.Windows.Input.KeyboardFocusChangedEventArgs e) { }
    protected override void OnKeyDown(System.Windows.Input.KeyEventArgs e) { }
    protected virtual void OnKeyTipAccessed(System.Windows.Controls.KeyTipAccessedEventArgs e) { }
    protected override void OnMouseLeftButtonDown(System.Windows.Input.MouseButtonEventArgs e) { }
    protected override void OnRender(System.Windows.Media.DrawingContext drawingContext) { }
  }
  public partial class RibbonTabHeaderItemsControl : System.Windows.Controls.ItemsControl {
    public RibbonTabHeaderItemsControl() { }
    protected internal override bool HandlesScrolling { get { return default(bool); } }
    protected override System.Windows.DependencyObject GetContainerForItemOverride() { return default(System.Windows.DependencyObject); }
    protected override bool IsItemItsOwnContainerOverride(object item) { return default(bool); }
    public override void OnApplyTemplate() { }
    protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { return default(System.Windows.Automation.Peers.AutomationPeer); }
    protected override void PrepareContainerForItemOverride(System.Windows.DependencyObject element, object item) { }
  }
  [System.Windows.TemplatePartAttribute(Name="PART_ContentHost", Type=typeof(System.Windows.Controls.ScrollViewer))]
  public partial class RibbonTextBox : System.Windows.Controls.TextBox, System.Windows.Input.ICommandSource {
    public static readonly System.Windows.DependencyProperty CanAddToQuickAccessToolBarDirectlyProperty;
    public static readonly System.Windows.DependencyProperty CommandParameterProperty;
    public static readonly System.Windows.DependencyProperty CommandProperty;
    public static readonly System.Windows.DependencyProperty CommandTargetProperty;
    public static readonly System.Windows.DependencyProperty ControlSizeDefinitionProperty;
    public static readonly System.Windows.DependencyProperty FocusedBackgroundProperty;
    public static readonly System.Windows.DependencyProperty FocusedBorderBrushProperty;
    public static readonly System.Windows.DependencyProperty IsInControlGroupProperty;
    public static readonly System.Windows.DependencyProperty IsInQuickAccessToolBarProperty;
    public static readonly System.Windows.DependencyProperty KeyTipProperty;
    public static readonly System.Windows.DependencyProperty LabelProperty;
    public static readonly System.Windows.DependencyProperty LargeImageSourceProperty;
    public static readonly System.Windows.DependencyProperty MouseOverBackgroundProperty;
    public static readonly System.Windows.DependencyProperty MouseOverBorderBrushProperty;
    public static readonly System.Windows.DependencyProperty QuickAccessToolBarControlSizeDefinitionProperty;
    public static readonly System.Windows.DependencyProperty QuickAccessToolBarIdProperty;
    public static readonly System.Windows.DependencyProperty RibbonProperty;
    public static readonly System.Windows.DependencyProperty ShowKeyboardCuesProperty;
    public static readonly System.Windows.DependencyProperty SmallImageSourceProperty;
    public static readonly System.Windows.DependencyProperty TextBoxWidthProperty;
    public static readonly System.Windows.DependencyProperty ToolTipDescriptionProperty;
    public static readonly System.Windows.DependencyProperty ToolTipFooterDescriptionProperty;
    public static readonly System.Windows.DependencyProperty ToolTipFooterImageSourceProperty;
    public static readonly System.Windows.DependencyProperty ToolTipFooterTitleProperty;
    public static readonly System.Windows.DependencyProperty ToolTipImageSourceProperty;
    public static readonly System.Windows.DependencyProperty ToolTipTitleProperty;
    public RibbonTextBox() { }
    public bool CanAddToQuickAccessToolBarDirectly { get { return default(bool); } set { } }
    public System.Windows.Input.ICommand Command { get { return default(System.Windows.Input.ICommand); } set { } }
    public object CommandParameter { get { return default(object); } set { } }
    public System.Windows.IInputElement CommandTarget { get { return default(System.Windows.IInputElement); } set { } }
    public System.Windows.Controls.Ribbon.RibbonControlSizeDefinition ControlSizeDefinition { get { return default(System.Windows.Controls.Ribbon.RibbonControlSizeDefinition); } set { } }
    public System.Windows.Media.Brush FocusedBackground { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Media.Brush FocusedBorderBrush { get { return default(System.Windows.Media.Brush); } set { } }
    protected override bool IsEnabledCore { get { return default(bool); } }
    public bool IsInControlGroup { get { return default(bool); } }
    public bool IsInQuickAccessToolBar { get { return default(bool); } }
    public string KeyTip { get { return default(string); } set { } }
    public string Label { get { return default(string); } set { } }
    public System.Windows.Media.ImageSource LargeImageSource { get { return default(System.Windows.Media.ImageSource); } set { } }
    public System.Windows.Media.Brush MouseOverBackground { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Media.Brush MouseOverBorderBrush { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Controls.Ribbon.RibbonControlSizeDefinition QuickAccessToolBarControlSizeDefinition { get { return default(System.Windows.Controls.Ribbon.RibbonControlSizeDefinition); } set { } }
    public object QuickAccessToolBarId { get { return default(object); } set { } }
    public System.Windows.Controls.Ribbon.Ribbon Ribbon { get { return default(System.Windows.Controls.Ribbon.Ribbon); } }
    public bool ShowKeyboardCues { get { return default(bool); } }
    public System.Windows.Media.ImageSource SmallImageSource { get { return default(System.Windows.Media.ImageSource); } set { } }
    public double TextBoxWidth { get { return default(double); } set { } }
    public string ToolTipDescription { get { return default(string); } set { } }
    public string ToolTipFooterDescription { get { return default(string); } set { } }
    public System.Windows.Media.ImageSource ToolTipFooterImageSource { get { return default(System.Windows.Media.ImageSource); } set { } }
    public string ToolTipFooterTitle { get { return default(string); } set { } }
    public System.Windows.Media.ImageSource ToolTipImageSource { get { return default(System.Windows.Media.ImageSource); } set { } }
    public string ToolTipTitle { get { return default(string); } set { } }
    protected virtual void OnActivatingKeyTip(System.Windows.Controls.ActivatingKeyTipEventArgs e) { }
    public override void OnApplyTemplate() { }
    protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { return default(System.Windows.Automation.Peers.AutomationPeer); }
    protected override void OnGotKeyboardFocus(System.Windows.Input.KeyboardFocusChangedEventArgs e) { }
    protected override void OnKeyDown(System.Windows.Input.KeyEventArgs e) { }
    protected virtual void OnKeyTipAccessed(System.Windows.Controls.KeyTipAccessedEventArgs e) { }
    protected override void OnLostKeyboardFocus(System.Windows.Input.KeyboardFocusChangedEventArgs e) { }
    protected override void OnTemplateChanged(System.Windows.Controls.ControlTemplate oldTemplate, System.Windows.Controls.ControlTemplate newTemplate) { }
  }
  [System.Windows.TemplatePartAttribute(Name="PART_Image", Type=typeof(System.Windows.Controls.Image))]
  public partial class RibbonToggleButton : System.Windows.Controls.Primitives.ToggleButton {
    public static readonly System.Windows.DependencyProperty CanAddToQuickAccessToolBarDirectlyProperty;
    public static readonly System.Windows.DependencyProperty CheckedBackgroundProperty;
    public static readonly System.Windows.DependencyProperty CheckedBorderBrushProperty;
    public static readonly System.Windows.DependencyProperty ControlSizeDefinitionProperty;
    public static readonly System.Windows.DependencyProperty CornerRadiusProperty;
    public static readonly System.Windows.DependencyProperty FocusedBackgroundProperty;
    public static readonly System.Windows.DependencyProperty FocusedBorderBrushProperty;
    public static readonly System.Windows.DependencyProperty IsInControlGroupProperty;
    public static readonly System.Windows.DependencyProperty IsInQuickAccessToolBarProperty;
    public static readonly System.Windows.DependencyProperty KeyTipProperty;
    public static readonly System.Windows.DependencyProperty LabelProperty;
    public static readonly System.Windows.DependencyProperty LargeImageSourceProperty;
    public static readonly System.Windows.DependencyProperty MouseOverBackgroundProperty;
    public static readonly System.Windows.DependencyProperty MouseOverBorderBrushProperty;
    public static readonly System.Windows.DependencyProperty PressedBackgroundProperty;
    public static readonly System.Windows.DependencyProperty PressedBorderBrushProperty;
    public static readonly System.Windows.DependencyProperty QuickAccessToolBarControlSizeDefinitionProperty;
    public static readonly System.Windows.DependencyProperty QuickAccessToolBarIdProperty;
    public static readonly System.Windows.DependencyProperty RibbonProperty;
    public static readonly System.Windows.DependencyProperty ShowKeyboardCuesProperty;
    public static readonly System.Windows.DependencyProperty SmallImageSourceProperty;
    public static readonly System.Windows.DependencyProperty ToolTipDescriptionProperty;
    public static readonly System.Windows.DependencyProperty ToolTipFooterDescriptionProperty;
    public static readonly System.Windows.DependencyProperty ToolTipFooterImageSourceProperty;
    public static readonly System.Windows.DependencyProperty ToolTipFooterTitleProperty;
    public static readonly System.Windows.DependencyProperty ToolTipImageSourceProperty;
    public static readonly System.Windows.DependencyProperty ToolTipTitleProperty;
    public RibbonToggleButton() { }
    public bool CanAddToQuickAccessToolBarDirectly { get { return default(bool); } set { } }
    public System.Windows.Media.Brush CheckedBackground { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Media.Brush CheckedBorderBrush { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Controls.Ribbon.RibbonControlSizeDefinition ControlSizeDefinition { get { return default(System.Windows.Controls.Ribbon.RibbonControlSizeDefinition); } set { } }
    public System.Windows.CornerRadius CornerRadius { get { return default(System.Windows.CornerRadius); } set { } }
    public System.Windows.Media.Brush FocusedBackground { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Media.Brush FocusedBorderBrush { get { return default(System.Windows.Media.Brush); } set { } }
    public bool IsInControlGroup { get { return default(bool); } }
    public bool IsInQuickAccessToolBar { get { return default(bool); } }
    public string KeyTip { get { return default(string); } set { } }
    public string Label { get { return default(string); } set { } }
    public System.Windows.Media.ImageSource LargeImageSource { get { return default(System.Windows.Media.ImageSource); } set { } }
    public System.Windows.Media.Brush MouseOverBackground { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Media.Brush MouseOverBorderBrush { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Media.Brush PressedBackground { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Media.Brush PressedBorderBrush { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Controls.Ribbon.RibbonControlSizeDefinition QuickAccessToolBarControlSizeDefinition { get { return default(System.Windows.Controls.Ribbon.RibbonControlSizeDefinition); } set { } }
    public object QuickAccessToolBarId { get { return default(object); } set { } }
    public System.Windows.Controls.Ribbon.Ribbon Ribbon { get { return default(System.Windows.Controls.Ribbon.Ribbon); } }
    public bool ShowKeyboardCues { get { return default(bool); } }
    public System.Windows.Media.ImageSource SmallImageSource { get { return default(System.Windows.Media.ImageSource); } set { } }
    public string ToolTipDescription { get { return default(string); } set { } }
    public string ToolTipFooterDescription { get { return default(string); } set { } }
    public System.Windows.Media.ImageSource ToolTipFooterImageSource { get { return default(System.Windows.Media.ImageSource); } set { } }
    public string ToolTipFooterTitle { get { return default(string); } set { } }
    public System.Windows.Media.ImageSource ToolTipImageSource { get { return default(System.Windows.Media.ImageSource); } set { } }
    public string ToolTipTitle { get { return default(string); } set { } }
    protected virtual void OnActivatingKeyTip(System.Windows.Controls.ActivatingKeyTipEventArgs e) { }
    public override void OnApplyTemplate() { }
    protected override void OnClick() { }
    protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { return default(System.Windows.Automation.Peers.AutomationPeer); }
    protected override void OnGotKeyboardFocus(System.Windows.Input.KeyboardFocusChangedEventArgs e) { }
    protected virtual void OnKeyTipAccessed(System.Windows.Controls.KeyTipAccessedEventArgs e) { }
    protected override void OnLostKeyboardFocus(System.Windows.Input.KeyboardFocusChangedEventArgs e) { }
    protected override void OnMouseLeftButtonDown(System.Windows.Input.MouseButtonEventArgs e) { }
  }
  public partial class RibbonToolTip : System.Windows.Controls.ToolTip {
    public static readonly System.Windows.DependencyProperty DescriptionProperty;
    public static readonly System.Windows.DependencyProperty FooterDescriptionProperty;
    public static readonly System.Windows.DependencyProperty FooterImageSourceProperty;
    public static readonly System.Windows.DependencyProperty FooterTitleProperty;
    public static readonly System.Windows.DependencyProperty HasFooterProperty;
    public static readonly System.Windows.DependencyProperty HasHeaderProperty;
    public static readonly System.Windows.DependencyProperty ImageSourceProperty;
    public static readonly System.Windows.DependencyProperty IsPlacementTargetInRibbonGroupProperty;
    public static readonly System.Windows.DependencyProperty RibbonProperty;
    public static readonly System.Windows.DependencyProperty TitleProperty;
    public RibbonToolTip() { }
    public string Description { get { return default(string); } set { } }
    public string FooterDescription { get { return default(string); } set { } }
    public System.Windows.Media.ImageSource FooterImageSource { get { return default(System.Windows.Media.ImageSource); } set { } }
    public string FooterTitle { get { return default(string); } set { } }
    public bool HasFooter { get { return default(bool); } }
    public bool HasHeader { get { return default(bool); } }
    public System.Windows.Media.ImageSource ImageSource { get { return default(System.Windows.Media.ImageSource); } set { } }
    public bool IsPlacementTargetInRibbonGroup { get { return default(bool); } }
    public System.Windows.Controls.Ribbon.Ribbon Ribbon { get { return default(System.Windows.Controls.Ribbon.Ribbon); } }
    public string Title { get { return default(string); } set { } }
    protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { return default(System.Windows.Automation.Peers.AutomationPeer); }
  }
  [System.Windows.TemplatePartAttribute(Name="PART_Path", Type=typeof(System.Windows.Shapes.Path))]
  [System.Windows.TemplatePartAttribute(Name="PART_TextBlock1", Type=typeof(System.Windows.Controls.TextBlock))]
  [System.Windows.TemplatePartAttribute(Name="PART_TextBlock2", Type=typeof(System.Windows.Controls.TextBlock))]
  public partial class RibbonTwoLineText : System.Windows.Controls.Control {
    public static readonly System.Windows.DependencyProperty BaselineOffsetProperty;
    public static readonly System.Windows.DependencyProperty HasTwoLinesProperty;
    public static readonly System.Windows.DependencyProperty LineHeightProperty;
    public static readonly System.Windows.DependencyProperty LineStackingStrategyProperty;
    public static readonly new System.Windows.DependencyProperty PaddingProperty;
    public static readonly System.Windows.DependencyProperty PathDataProperty;
    public static readonly System.Windows.DependencyProperty PathFillProperty;
    public static readonly System.Windows.DependencyProperty PathStrokeProperty;
    public static readonly System.Windows.DependencyProperty TextAlignmentProperty;
    public static readonly System.Windows.DependencyProperty TextDecorationsProperty;
    public static readonly System.Windows.DependencyProperty TextEffectsProperty;
    public static readonly System.Windows.DependencyProperty TextProperty;
    public static readonly System.Windows.DependencyProperty TextTrimmingProperty;
    public RibbonTwoLineText() { }
    public double BaselineOffset { get { return default(double); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.LengthConverter))]
    public double LineHeight { get { return default(double); } set { } }
    public System.Windows.LineStackingStrategy LineStackingStrategy { get { return default(System.Windows.LineStackingStrategy); } set { } }
    public new System.Windows.Thickness Padding { get { return default(System.Windows.Thickness); } set { } }
    public System.Windows.Media.Brush PathFill { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Media.Brush PathStroke { get { return default(System.Windows.Media.Brush); } set { } }
    public string Text { get { return default(string); } set { } }
    public System.Windows.TextAlignment TextAlignment { get { return default(System.Windows.TextAlignment); } set { } }
    public System.Windows.TextDecorationCollection TextDecorations { get { return default(System.Windows.TextDecorationCollection); } set { } }
    public System.Windows.Media.TextEffectCollection TextEffects { get { return default(System.Windows.Media.TextEffectCollection); } set { } }
    public System.Windows.TextTrimming TextTrimming { get { return default(System.Windows.TextTrimming); } set { } }
    public static bool GetHasTwoLines(System.Windows.DependencyObject element) { return default(bool); }
    public static System.Windows.Media.Geometry GetPathData(System.Windows.DependencyObject element) { return default(System.Windows.Media.Geometry); }
    protected override System.Windows.Size MeasureOverride(System.Windows.Size availableSize) { return default(System.Windows.Size); }
    public override void OnApplyTemplate() { }
    protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { return default(System.Windows.Automation.Peers.AutomationPeer); }
    public static void SetHasTwoLines(System.Windows.DependencyObject element, bool value) { }
    public static void SetPathData(System.Windows.DependencyObject element, System.Windows.Media.Geometry value) { }
  }
  [System.Windows.TemplatePartAttribute(Name="PART_ClientAreaBorder", Type=typeof(System.Windows.Controls.Border))]
  [System.Windows.TemplatePartAttribute(Name="PART_Icon", Type=typeof(System.Windows.Controls.Image))]
  public partial class RibbonWindow : System.Windows.Window {
    public RibbonWindow() { }
    public override void OnApplyTemplate() { }
  }
  public partial class StringCollectionConverter : System.ComponentModel.TypeConverter {
    public StringCollectionConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
  }
}
namespace System.Windows.Controls.Ribbon.Primitives {
  public partial interface IProvideStarLayoutInfo : System.Windows.Controls.Ribbon.Primitives.IProvideStarLayoutInfoBase {
    System.Collections.Generic.IEnumerable<System.Windows.Controls.Ribbon.Primitives.StarLayoutInfo> StarLayoutCombinations { get; }
    void OnStarSizeAllocationCompleted();
  }
  public partial interface IProvideStarLayoutInfoBase {
    System.Windows.UIElement TargetElement { get; }
    void OnInitializeLayout();
  }
  public partial interface ISupportStarLayout {
    bool IsStarLayoutPass { get; }
    void RegisterStarLayoutProvider(System.Windows.Controls.Ribbon.Primitives.IProvideStarLayoutInfoBase starLayoutInfoProvider);
    void UnregisterStarLayoutProvider(System.Windows.Controls.Ribbon.Primitives.IProvideStarLayoutInfoBase starLayoutInfoProvider);
  }
  public partial class RibbonContextualTabGroupsPanel : System.Windows.Controls.Panel {
    public static readonly System.Windows.DependencyProperty RibbonProperty;
    public RibbonContextualTabGroupsPanel() { }
    public System.Windows.Controls.Ribbon.Ribbon Ribbon { get { return default(System.Windows.Controls.Ribbon.Ribbon); } }
    protected override System.Windows.Size ArrangeOverride(System.Windows.Size finalSize) { return default(System.Windows.Size); }
    protected override System.Windows.Size MeasureOverride(System.Windows.Size availableSize) { return default(System.Windows.Size); }
    protected override void OnIsItemsHostChanged(bool oldIsItemsHost, bool newIsItemsHost) { }
    protected override void OnRender(System.Windows.Media.DrawingContext drawingContext) { }
  }
  public partial class RibbonGalleryCategoriesPanel : System.Windows.Controls.Panel, System.Windows.Controls.Primitives.IScrollInfo, System.Windows.Controls.Ribbon.Primitives.IProvideStarLayoutInfoBase {
    public RibbonGalleryCategoriesPanel() { }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool CanHorizontallyScroll { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool CanVerticallyScroll { get { return default(bool); } set { } }
    public double ExtentHeight { get { return default(double); } }
    public double ExtentWidth { get { return default(double); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public double HorizontalOffset { get { return default(double); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Windows.Controls.ScrollViewer ScrollOwner { get { return default(System.Windows.Controls.ScrollViewer); } set { } }
    public System.Windows.UIElement TargetElement { get { return default(System.Windows.UIElement); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public double VerticalOffset { get { return default(double); } }
    public double ViewportHeight { get { return default(double); } }
    public double ViewportWidth { get { return default(double); } }
    protected override System.Windows.Size ArrangeOverride(System.Windows.Size finalSize) { return default(System.Windows.Size); }
    public void LineDown() { }
    public void LineLeft() { }
    public void LineRight() { }
    public void LineUp() { }
    public System.Windows.Rect MakeVisible(System.Windows.Media.Visual visual, System.Windows.Rect rectangle) { return default(System.Windows.Rect); }
    protected override System.Windows.Size MeasureOverride(System.Windows.Size availableSize) { return default(System.Windows.Size); }
    public void MouseWheelDown() { }
    public void MouseWheelLeft() { }
    public void MouseWheelRight() { }
    public void MouseWheelUp() { }
    public void OnInitializeLayout() { }
    public void PageDown() { }
    public void PageLeft() { }
    public void PageRight() { }
    public void PageUp() { }
    public void SetHorizontalOffset(double offset) { }
    public void SetVerticalOffset(double offset) { }
  }
  public partial class RibbonGalleryItemsPanel : System.Windows.Controls.Panel {
    public RibbonGalleryItemsPanel() { }
    protected override System.Windows.Size ArrangeOverride(System.Windows.Size finalSize) { return default(System.Windows.Size); }
    protected override System.Windows.Size MeasureOverride(System.Windows.Size availableSize) { return default(System.Windows.Size); }
  }
  public partial class RibbonGroupItemsPanel : System.Windows.Controls.Panel, System.Windows.Controls.Ribbon.Primitives.IProvideStarLayoutInfo, System.Windows.Controls.Ribbon.Primitives.IProvideStarLayoutInfoBase {
    public RibbonGroupItemsPanel() { }
    public System.Collections.Generic.IEnumerable<System.Windows.Controls.Ribbon.Primitives.StarLayoutInfo> StarLayoutCombinations { get { return default(System.Collections.Generic.IEnumerable<System.Windows.Controls.Ribbon.Primitives.StarLayoutInfo>); } }
    public System.Windows.UIElement TargetElement { get { return default(System.Windows.UIElement); } }
    protected override System.Windows.Size ArrangeOverride(System.Windows.Size finalSize) { return default(System.Windows.Size); }
    protected override System.Windows.Size MeasureOverride(System.Windows.Size availableSize) { return default(System.Windows.Size); }
    public void OnInitializeLayout() { }
    public void OnStarSizeAllocationCompleted() { }
  }
  public partial class RibbonGroupsPanel : System.Windows.Controls.StackPanel, System.Windows.Controls.Ribbon.Primitives.ISupportStarLayout {
    public static readonly System.Windows.DependencyProperty IsStarLayoutPassProperty;
    public RibbonGroupsPanel() { }
    public bool IsStarLayoutPass { get { return default(bool); } }
    protected override System.Windows.Size MeasureOverride(System.Windows.Size availableSize) { return default(System.Windows.Size); }
    public void RegisterStarLayoutProvider(System.Windows.Controls.Ribbon.Primitives.IProvideStarLayoutInfoBase starLayoutInfoProvider) { }
    public void UnregisterStarLayoutProvider(System.Windows.Controls.Ribbon.Primitives.IProvideStarLayoutInfoBase starLayoutInfoProvider) { }
  }
  public partial class RibbonMenuItemsPanel : System.Windows.Controls.VirtualizingStackPanel, System.Windows.Controls.Ribbon.Primitives.ISupportStarLayout {
    public RibbonMenuItemsPanel() { }
    public bool IsStarLayoutPass { get { return default(bool); } }
    protected override System.Windows.Size ArrangeOverride(System.Windows.Size finalSize) { return default(System.Windows.Size); }
    protected override System.Windows.Size MeasureOverride(System.Windows.Size availableSize) { return default(System.Windows.Size); }
    protected override void OnIsItemsHostChanged(bool oldIsItemsHost, bool newIsItemsHost) { }
    public void RegisterStarLayoutProvider(System.Windows.Controls.Ribbon.Primitives.IProvideStarLayoutInfoBase starLayoutInfoProvider) { }
    public void UnregisterStarLayoutProvider(System.Windows.Controls.Ribbon.Primitives.IProvideStarLayoutInfoBase starLayoutInfoProvider) { }
  }
  public partial class RibbonQuickAccessToolBarOverflowPanel : System.Windows.Controls.Panel {
    public RibbonQuickAccessToolBarOverflowPanel() { }
    protected override System.Windows.Size ArrangeOverride(System.Windows.Size finalSize) { return default(System.Windows.Size); }
    protected override System.Windows.Size MeasureOverride(System.Windows.Size availableSize) { return default(System.Windows.Size); }
  }
  public partial class RibbonQuickAccessToolBarPanel : System.Windows.Controls.VirtualizingPanel {
    public RibbonQuickAccessToolBarPanel() { }
    protected override System.Windows.Size ArrangeOverride(System.Windows.Size finalSize) { return default(System.Windows.Size); }
    protected override System.Windows.Size MeasureOverride(System.Windows.Size availableSize) { return default(System.Windows.Size); }
    protected override void OnItemsChanged(object sender, System.Windows.Controls.Primitives.ItemsChangedEventArgs args) { }
  }
  public sealed partial class RibbonScrollButtonVisibilityConverter : System.Windows.Data.IMultiValueConverter {
    public RibbonScrollButtonVisibilityConverter() { }
    public object Convert(System.Object[] values, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) { return default(object); }
    public System.Object[] ConvertBack(object value, System.Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture) { return default(System.Object[]); }
  }
  public partial class RibbonTabHeadersPanel : System.Windows.Controls.Panel, System.Windows.Controls.Primitives.IScrollInfo {
    public static readonly System.Windows.DependencyProperty RibbonProperty;
    public RibbonTabHeadersPanel() { }
    public bool CanHorizontallyScroll { get { return default(bool); } set { } }
    public bool CanVerticallyScroll { get { return default(bool); } set { } }
    public double ExtentHeight { get { return default(double); } }
    public double ExtentWidth { get { return default(double); } }
    public double HorizontalOffset { get { return default(double); } }
    public System.Windows.Controls.Ribbon.Ribbon Ribbon { get { return default(System.Windows.Controls.Ribbon.Ribbon); } }
    public System.Windows.Controls.ScrollViewer ScrollOwner { get { return default(System.Windows.Controls.ScrollViewer); } set { } }
    public double VerticalOffset { get { return default(double); } }
    public double ViewportHeight { get { return default(double); } }
    public double ViewportWidth { get { return default(double); } }
    protected override System.Windows.Size ArrangeOverride(System.Windows.Size finalSize) { return default(System.Windows.Size); }
    public void LineDown() { }
    public void LineLeft() { }
    public void LineRight() { }
    public void LineUp() { }
    public System.Windows.Rect MakeVisible(System.Windows.Media.Visual visual, System.Windows.Rect rectangle) { return default(System.Windows.Rect); }
    protected override System.Windows.Size MeasureOverride(System.Windows.Size availableSize) { return default(System.Windows.Size); }
    public void MouseWheelDown() { }
    public void MouseWheelLeft() { }
    public void MouseWheelRight() { }
    public void MouseWheelUp() { }
    protected override void OnIsItemsHostChanged(bool oldIsItemsHost, bool newIsItemsHost) { }
    protected override void OnRender(System.Windows.Media.DrawingContext drawingContext) { }
    public void PageDown() { }
    public void PageLeft() { }
    public void PageRight() { }
    public void PageUp() { }
    public void SetHorizontalOffset(double offset) { }
    public void SetVerticalOffset(double offset) { }
  }
  public partial class RibbonTabsPanel : System.Windows.Controls.Panel, System.Windows.Controls.Primitives.IScrollInfo {
    public RibbonTabsPanel() { }
    public bool CanHorizontallyScroll { get { return default(bool); } set { } }
    public bool CanVerticallyScroll { get { return default(bool); } set { } }
    public double ExtentHeight { get { return default(double); } }
    public double ExtentWidth { get { return default(double); } }
    public double HorizontalOffset { get { return default(double); } }
    public System.Windows.Controls.ScrollViewer ScrollOwner { get { return default(System.Windows.Controls.ScrollViewer); } set { } }
    public double VerticalOffset { get { return default(double); } }
    public double ViewportHeight { get { return default(double); } }
    public double ViewportWidth { get { return default(double); } }
    protected override System.Windows.Size ArrangeOverride(System.Windows.Size finalSize) { return default(System.Windows.Size); }
    public void LineDown() { }
    public void LineLeft() { }
    public void LineRight() { }
    public void LineUp() { }
    public System.Windows.Rect MakeVisible(System.Windows.Media.Visual visual, System.Windows.Rect rectangle) { return default(System.Windows.Rect); }
    protected override System.Windows.Size MeasureOverride(System.Windows.Size availableSize) { return default(System.Windows.Size); }
    public void MouseWheelDown() { }
    public void MouseWheelLeft() { }
    public void MouseWheelRight() { }
    public void MouseWheelUp() { }
    public void PageDown() { }
    public void PageLeft() { }
    public void PageRight() { }
    public void PageUp() { }
    public void SetHorizontalOffset(double offset) { }
    public void SetVerticalOffset(double offset) { }
  }
  public partial class RibbonTitlePanel : System.Windows.Controls.Panel {
    public static readonly System.Windows.DependencyProperty RibbonProperty;
    public RibbonTitlePanel() { }
    public System.Windows.Controls.Ribbon.Ribbon Ribbon { get { return default(System.Windows.Controls.Ribbon.Ribbon); } }
    protected override System.Windows.Size ArrangeOverride(System.Windows.Size finalSize) { return default(System.Windows.Size); }
    protected override System.Windows.Size MeasureOverride(System.Windows.Size availableSize) { return default(System.Windows.Size); }
  }
  public partial class RibbonWindowSmallIconConverter : System.Windows.Data.IValueConverter {
    public RibbonWindowSmallIconConverter() { }
    public object Convert(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) { return default(object); }
    public object ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) { return default(object); }
  }
  public partial class StarLayoutInfo : System.Windows.DependencyObject {
    public static readonly System.Windows.DependencyProperty AllocatedStarWidthProperty;
    public static readonly System.Windows.DependencyProperty RequestedStarMaxWidthProperty;
    public static readonly System.Windows.DependencyProperty RequestedStarMinWidthProperty;
    public static readonly System.Windows.DependencyProperty RequestedStarWeightProperty;
    public StarLayoutInfo() { }
    public double AllocatedStarWidth { get { return default(double); } set { } }
    public double RequestedStarMaxWidth { get { return default(double); } set { } }
    public double RequestedStarMinWidth { get { return default(double); } set { } }
    public double RequestedStarWeight { get { return default(double); } set { } }
  }
}
