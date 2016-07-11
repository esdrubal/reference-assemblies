namespace Microsoft.VisualBasic.Compatibility.VB6 {
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public abstract partial class BaseControlArray : System.ComponentModel.Component, System.ComponentModel.ISupportInitialize {
    protected System.ComponentModel.IContainer components;
    protected System.Collections.Hashtable controlAddedAtDesignTime;
    protected System.Collections.Hashtable controls;
    protected bool fIsEndInitCalled;
    protected System.Collections.Hashtable indices;
    protected BaseControlArray() { }
    protected BaseControlArray(System.ComponentModel.IContainer Container) { }
    protected bool BaseCanExtend(object target) { return default(bool); }
    protected short BaseGetIndex(object ctl) { return default(short); }
    protected object BaseGetItem(short Index) { return default(object); }
    protected void BaseResetIndex(object o) { }
    protected void BaseSetIndex(object ctl, short Index, bool fIsDynamic=false) { }
    protected bool BaseShouldSerializeIndex(object o) { return default(bool); }
    void BeginInit() { }
    public short Count() { return default(short); }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, SharedState=true)]
    protected override void Dispose(bool disposing) { }
    void EndInit() { }
    protected abstract System.Type GetControlInstanceType();
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    protected abstract void HookUpControlEvents(object o);
    public short LBound() { return default(short); }
    public void Load(short Index) { }
    public short UBound() { return default(short); }
    public void Unload(short Index) { }
  }
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public abstract partial class BaseOcxArray : Microsoft.VisualBasic.Compatibility.VB6.BaseControlArray {
    protected BaseOcxArray() { }
    protected BaseOcxArray(System.ComponentModel.IContainer Container) { }
    public event System.EventHandler CausesValidationChanged { add { } remove { } }
    public event System.EventHandler ClientSizeChanged { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public event System.EventHandler ContextMenuChanged { add { } remove { } }
    public event System.EventHandler ContextMenuStripChanged { add { } remove { } }
    public event System.Windows.Forms.ControlEventHandler ControlAdded { add { } remove { } }
    public event System.Windows.Forms.ControlEventHandler ControlRemoved { add { } remove { } }
    public event System.EventHandler DockChanged { add { } remove { } }
    public event System.EventHandler Enter { add { } remove { } }
    public event System.EventHandler Leave { add { } remove { } }
    public event System.EventHandler LocationChanged { add { } remove { } }
    public event System.EventHandler MarginChanged { add { } remove { } }
    public event System.EventHandler MouseCaptureChanged { add { } remove { } }
    public event System.EventHandler Move { add { } remove { } }
    public event System.EventHandler PaddingChanged { add { } remove { } }
    public event System.EventHandler ParentChanged { add { } remove { } }
    public event System.EventHandler RegionChanged { add { } remove { } }
    public event System.EventHandler Resize { add { } remove { } }
    public event System.EventHandler SizeChanged { add { } remove { } }
    public event System.EventHandler SystemColorsChanged { add { } remove { } }
    public event System.EventHandler Validated { add { } remove { } }
    public event System.ComponentModel.CancelEventHandler Validating { add { } remove { } }
    public event System.EventHandler VisibleChanged { add { } remove { } }
    protected override void HookUpControlEvents(object o) { }
  }
  [System.ComponentModel.ProvidePropertyAttribute("Index", typeof(System.Windows.Forms.Button))]
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class ButtonArray : Microsoft.VisualBasic.Compatibility.VB6.BaseControlArray, System.ComponentModel.IExtenderProvider {
    public ButtonArray() { }
    public ButtonArray(System.ComponentModel.IContainer Container) { }
    public System.Windows.Forms.Button this[short Index] { get { return default(System.Windows.Forms.Button); } }
    public event System.EventHandler AutoSizeChanged { add { } remove { } }
    public event System.EventHandler BackColorChanged { add { } remove { } }
    public event System.EventHandler BackgroundImageChanged { add { } remove { } }
    public event System.EventHandler BackgroundImageLayoutChanged { add { } remove { } }
    public event System.EventHandler BindingContextChanged { add { } remove { } }
    public event System.EventHandler CausesValidationChanged { add { } remove { } }
    public event System.Windows.Forms.UICuesEventHandler ChangeUICues { add { } remove { } }
    public event System.EventHandler Click { add { } remove { } }
    public event System.EventHandler ClientSizeChanged { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public event System.EventHandler ContextMenuChanged { add { } remove { } }
    public event System.EventHandler ContextMenuStripChanged { add { } remove { } }
    public event System.Windows.Forms.ControlEventHandler ControlAdded { add { } remove { } }
    public event System.Windows.Forms.ControlEventHandler ControlRemoved { add { } remove { } }
    public event System.EventHandler CursorChanged { add { } remove { } }
    public event System.EventHandler DockChanged { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragDrop { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragEnter { add { } remove { } }
    public event System.EventHandler DragLeave { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragOver { add { } remove { } }
    public event System.EventHandler EnabledChanged { add { } remove { } }
    public event System.EventHandler Enter { add { } remove { } }
    public event System.EventHandler FontChanged { add { } remove { } }
    public event System.EventHandler ForeColorChanged { add { } remove { } }
    public event System.Windows.Forms.GiveFeedbackEventHandler GiveFeedback { add { } remove { } }
    public event System.Windows.Forms.HelpEventHandler HelpRequested { add { } remove { } }
    public event System.Windows.Forms.KeyEventHandler KeyDown { add { } remove { } }
    public event System.Windows.Forms.KeyPressEventHandler KeyPress { add { } remove { } }
    public event System.Windows.Forms.KeyEventHandler KeyUp { add { } remove { } }
    public event System.Windows.Forms.LayoutEventHandler Layout { add { } remove { } }
    public event System.EventHandler Leave { add { } remove { } }
    public event System.EventHandler LocationChanged { add { } remove { } }
    public event System.EventHandler MarginChanged { add { } remove { } }
    public event System.EventHandler MouseCaptureChanged { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseClick { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseDown { add { } remove { } }
    public event System.EventHandler MouseEnter { add { } remove { } }
    public event System.EventHandler MouseHover { add { } remove { } }
    public event System.EventHandler MouseLeave { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseMove { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseUp { add { } remove { } }
    public event System.EventHandler Move { add { } remove { } }
    public event System.EventHandler PaddingChanged { add { } remove { } }
    public event System.Windows.Forms.PaintEventHandler Paint { add { } remove { } }
    public event System.EventHandler ParentChanged { add { } remove { } }
    public event System.Windows.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp { add { } remove { } }
    public event System.Windows.Forms.QueryContinueDragEventHandler QueryContinueDrag { add { } remove { } }
    public event System.EventHandler RegionChanged { add { } remove { } }
    public event System.EventHandler Resize { add { } remove { } }
    public event System.EventHandler RightToLeftChanged { add { } remove { } }
    public event System.EventHandler SizeChanged { add { } remove { } }
    public event System.EventHandler StyleChanged { add { } remove { } }
    public event System.EventHandler SystemColorsChanged { add { } remove { } }
    public event System.EventHandler TabIndexChanged { add { } remove { } }
    public event System.EventHandler TabStopChanged { add { } remove { } }
    public event System.EventHandler TextChanged { add { } remove { } }
    public event System.EventHandler Validated { add { } remove { } }
    public event System.ComponentModel.CancelEventHandler Validating { add { } remove { } }
    public event System.EventHandler VisibleChanged { add { } remove { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    bool CanExtend(object target) { return default(bool); }
    protected override System.Type GetControlInstanceType() { return default(System.Type); }
    public short GetIndex(System.Windows.Forms.Button o) { return default(short); }
    protected override void HookUpControlEvents(object o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void ResetIndex(System.Windows.Forms.Button o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void SetIndex(System.Windows.Forms.Button o, short Index) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeIndex(System.Windows.Forms.Button o) { return default(bool); }
  }
  [System.ComponentModel.ProvidePropertyAttribute("Index", typeof(System.Windows.Forms.CheckBox))]
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class CheckBoxArray : Microsoft.VisualBasic.Compatibility.VB6.BaseControlArray, System.ComponentModel.IExtenderProvider {
    public CheckBoxArray() { }
    public CheckBoxArray(System.ComponentModel.IContainer Container) { }
    public System.Windows.Forms.CheckBox this[short Index] { get { return default(System.Windows.Forms.CheckBox); } }
    public event System.EventHandler AppearanceChanged { add { } remove { } }
    public event System.EventHandler AutoSizeChanged { add { } remove { } }
    public event System.EventHandler BackColorChanged { add { } remove { } }
    public event System.EventHandler BackgroundImageChanged { add { } remove { } }
    public event System.EventHandler BackgroundImageLayoutChanged { add { } remove { } }
    public event System.EventHandler BindingContextChanged { add { } remove { } }
    public event System.EventHandler CausesValidationChanged { add { } remove { } }
    public event System.Windows.Forms.UICuesEventHandler ChangeUICues { add { } remove { } }
    public event System.EventHandler CheckedChanged { add { } remove { } }
    public event System.EventHandler CheckStateChanged { add { } remove { } }
    public event System.EventHandler Click { add { } remove { } }
    public event System.EventHandler ClientSizeChanged { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public event System.EventHandler ContextMenuChanged { add { } remove { } }
    public event System.EventHandler ContextMenuStripChanged { add { } remove { } }
    public event System.Windows.Forms.ControlEventHandler ControlAdded { add { } remove { } }
    public event System.Windows.Forms.ControlEventHandler ControlRemoved { add { } remove { } }
    public event System.EventHandler CursorChanged { add { } remove { } }
    public event System.EventHandler DockChanged { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragDrop { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragEnter { add { } remove { } }
    public event System.EventHandler DragLeave { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragOver { add { } remove { } }
    public event System.EventHandler EnabledChanged { add { } remove { } }
    public event System.EventHandler Enter { add { } remove { } }
    public event System.EventHandler FontChanged { add { } remove { } }
    public event System.EventHandler ForeColorChanged { add { } remove { } }
    public event System.Windows.Forms.GiveFeedbackEventHandler GiveFeedback { add { } remove { } }
    public event System.Windows.Forms.HelpEventHandler HelpRequested { add { } remove { } }
    public event System.Windows.Forms.KeyEventHandler KeyDown { add { } remove { } }
    public event System.Windows.Forms.KeyPressEventHandler KeyPress { add { } remove { } }
    public event System.Windows.Forms.KeyEventHandler KeyUp { add { } remove { } }
    public event System.Windows.Forms.LayoutEventHandler Layout { add { } remove { } }
    public event System.EventHandler Leave { add { } remove { } }
    public event System.EventHandler LocationChanged { add { } remove { } }
    public event System.EventHandler MarginChanged { add { } remove { } }
    public event System.EventHandler MouseCaptureChanged { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseClick { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseDown { add { } remove { } }
    public event System.EventHandler MouseEnter { add { } remove { } }
    public event System.EventHandler MouseHover { add { } remove { } }
    public event System.EventHandler MouseLeave { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseMove { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseUp { add { } remove { } }
    public event System.EventHandler Move { add { } remove { } }
    public event System.EventHandler PaddingChanged { add { } remove { } }
    public event System.Windows.Forms.PaintEventHandler Paint { add { } remove { } }
    public event System.EventHandler ParentChanged { add { } remove { } }
    public event System.Windows.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp { add { } remove { } }
    public event System.Windows.Forms.QueryContinueDragEventHandler QueryContinueDrag { add { } remove { } }
    public event System.EventHandler RegionChanged { add { } remove { } }
    public event System.EventHandler Resize { add { } remove { } }
    public event System.EventHandler RightToLeftChanged { add { } remove { } }
    public event System.EventHandler SizeChanged { add { } remove { } }
    public event System.EventHandler StyleChanged { add { } remove { } }
    public event System.EventHandler SystemColorsChanged { add { } remove { } }
    public event System.EventHandler TabIndexChanged { add { } remove { } }
    public event System.EventHandler TabStopChanged { add { } remove { } }
    public event System.EventHandler TextChanged { add { } remove { } }
    public event System.EventHandler Validated { add { } remove { } }
    public event System.ComponentModel.CancelEventHandler Validating { add { } remove { } }
    public event System.EventHandler VisibleChanged { add { } remove { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    bool CanExtend(object target) { return default(bool); }
    protected override System.Type GetControlInstanceType() { return default(System.Type); }
    public short GetIndex(System.Windows.Forms.CheckBox o) { return default(short); }
    protected override void HookUpControlEvents(object o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void ResetIndex(System.Windows.Forms.CheckBox o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void SetIndex(System.Windows.Forms.CheckBox o, short Index) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeIndex(System.Windows.Forms.CheckBox o) { return default(bool); }
  }
  [System.ComponentModel.ProvidePropertyAttribute("Index", typeof(System.Windows.Forms.CheckedListBox))]
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class CheckedListBoxArray : Microsoft.VisualBasic.Compatibility.VB6.BaseControlArray, System.ComponentModel.IExtenderProvider {
    public CheckedListBoxArray() { }
    public CheckedListBoxArray(System.ComponentModel.IContainer Container) { }
    public System.Windows.Forms.CheckedListBox this[short Index] { get { return default(System.Windows.Forms.CheckedListBox); } }
    public event System.EventHandler BackColorChanged { add { } remove { } }
    public event System.EventHandler BindingContextChanged { add { } remove { } }
    public event System.EventHandler CausesValidationChanged { add { } remove { } }
    public event System.Windows.Forms.UICuesEventHandler ChangeUICues { add { } remove { } }
    public event System.EventHandler Click { add { } remove { } }
    public event System.EventHandler ClientSizeChanged { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public event System.EventHandler ContextMenuChanged { add { } remove { } }
    public event System.EventHandler ContextMenuStripChanged { add { } remove { } }
    public event System.Windows.Forms.ControlEventHandler ControlAdded { add { } remove { } }
    public event System.Windows.Forms.ControlEventHandler ControlRemoved { add { } remove { } }
    public event System.EventHandler CursorChanged { add { } remove { } }
    public event System.EventHandler DockChanged { add { } remove { } }
    public event System.EventHandler DoubleClick { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragDrop { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragEnter { add { } remove { } }
    public event System.EventHandler DragLeave { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragOver { add { } remove { } }
    public event System.EventHandler EnabledChanged { add { } remove { } }
    public event System.EventHandler Enter { add { } remove { } }
    public event System.EventHandler FontChanged { add { } remove { } }
    public event System.EventHandler ForeColorChanged { add { } remove { } }
    public event System.Windows.Forms.ListControlConvertEventHandler Format { add { } remove { } }
    public event System.EventHandler FormatStringChanged { add { } remove { } }
    public event System.EventHandler FormattingEnabledChanged { add { } remove { } }
    public event System.Windows.Forms.GiveFeedbackEventHandler GiveFeedback { add { } remove { } }
    public event System.Windows.Forms.HelpEventHandler HelpRequested { add { } remove { } }
    public event System.EventHandler ImeModeChanged { add { } remove { } }
    public event System.Windows.Forms.ItemCheckEventHandler ItemCheck { add { } remove { } }
    public event System.Windows.Forms.KeyEventHandler KeyDown { add { } remove { } }
    public event System.Windows.Forms.KeyPressEventHandler KeyPress { add { } remove { } }
    public event System.Windows.Forms.KeyEventHandler KeyUp { add { } remove { } }
    public event System.Windows.Forms.LayoutEventHandler Layout { add { } remove { } }
    public event System.EventHandler Leave { add { } remove { } }
    public event System.EventHandler LocationChanged { add { } remove { } }
    public event System.EventHandler MarginChanged { add { } remove { } }
    public event System.EventHandler MouseCaptureChanged { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseClick { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseDoubleClick { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseDown { add { } remove { } }
    public event System.EventHandler MouseEnter { add { } remove { } }
    public event System.EventHandler MouseHover { add { } remove { } }
    public event System.EventHandler MouseLeave { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseMove { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseUp { add { } remove { } }
    public event System.EventHandler Move { add { } remove { } }
    public event System.EventHandler PaddingChanged { add { } remove { } }
    public event System.EventHandler ParentChanged { add { } remove { } }
    public event System.Windows.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp { add { } remove { } }
    public event System.Windows.Forms.QueryContinueDragEventHandler QueryContinueDrag { add { } remove { } }
    public event System.EventHandler RegionChanged { add { } remove { } }
    public event System.EventHandler Resize { add { } remove { } }
    public event System.EventHandler RightToLeftChanged { add { } remove { } }
    public event System.EventHandler SelectedIndexChanged { add { } remove { } }
    public event System.EventHandler SelectedValueChanged { add { } remove { } }
    public event System.EventHandler SizeChanged { add { } remove { } }
    public event System.EventHandler StyleChanged { add { } remove { } }
    public event System.EventHandler SystemColorsChanged { add { } remove { } }
    public event System.EventHandler TabIndexChanged { add { } remove { } }
    public event System.EventHandler TabStopChanged { add { } remove { } }
    public event System.EventHandler Validated { add { } remove { } }
    public event System.ComponentModel.CancelEventHandler Validating { add { } remove { } }
    public event System.EventHandler VisibleChanged { add { } remove { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    bool CanExtend(object target) { return default(bool); }
    protected override System.Type GetControlInstanceType() { return default(System.Type); }
    public short GetIndex(System.Windows.Forms.CheckedListBox o) { return default(short); }
    protected override void HookUpControlEvents(object o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void ResetIndex(System.Windows.Forms.CheckedListBox o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void SetIndex(System.Windows.Forms.CheckedListBox o, short Index) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeIndex(System.Windows.Forms.CheckedListBox o) { return default(bool); }
  }
  [System.ComponentModel.ProvidePropertyAttribute("Index", typeof(System.Windows.Forms.ColorDialog))]
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class ColorDialogArray : Microsoft.VisualBasic.Compatibility.VB6.BaseControlArray, System.ComponentModel.IExtenderProvider {
    public ColorDialogArray() { }
    public ColorDialogArray(System.ComponentModel.IContainer Container) { }
    public System.Windows.Forms.ColorDialog this[short Index] { get { return default(System.Windows.Forms.ColorDialog); } }
    public event System.EventHandler HelpRequest { add { } remove { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    bool CanExtend(object target) { return default(bool); }
    protected override System.Type GetControlInstanceType() { return default(System.Type); }
    public short GetIndex(System.Windows.Forms.ColorDialog o) { return default(short); }
    protected override void HookUpControlEvents(object o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void ResetIndex(System.Windows.Forms.ColorDialog o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void SetIndex(System.Windows.Forms.ColorDialog o, short Index) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeIndex(System.Windows.Forms.ColorDialog o) { return default(bool); }
  }
  [System.ComponentModel.ProvidePropertyAttribute("Index", typeof(System.Windows.Forms.ComboBox))]
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class ComboBoxArray : Microsoft.VisualBasic.Compatibility.VB6.BaseControlArray, System.ComponentModel.IExtenderProvider {
    public ComboBoxArray() { }
    public ComboBoxArray(System.ComponentModel.IContainer Container) { }
    public System.Windows.Forms.ComboBox this[short Index] { get { return default(System.Windows.Forms.ComboBox); } }
    public event System.EventHandler BackColorChanged { add { } remove { } }
    public event System.EventHandler BindingContextChanged { add { } remove { } }
    public event System.EventHandler CausesValidationChanged { add { } remove { } }
    public event System.Windows.Forms.UICuesEventHandler ChangeUICues { add { } remove { } }
    public event System.EventHandler Click { add { } remove { } }
    public event System.EventHandler ClientSizeChanged { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public event System.EventHandler ContextMenuChanged { add { } remove { } }
    public event System.EventHandler ContextMenuStripChanged { add { } remove { } }
    public event System.Windows.Forms.ControlEventHandler ControlAdded { add { } remove { } }
    public event System.Windows.Forms.ControlEventHandler ControlRemoved { add { } remove { } }
    public event System.EventHandler CursorChanged { add { } remove { } }
    public event System.EventHandler DataSourceChanged { add { } remove { } }
    public event System.EventHandler DisplayMemberChanged { add { } remove { } }
    public event System.EventHandler DockChanged { add { } remove { } }
    public event System.EventHandler DoubleClick { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragDrop { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragEnter { add { } remove { } }
    public event System.EventHandler DragLeave { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragOver { add { } remove { } }
    public event System.Windows.Forms.DrawItemEventHandler DrawItem { add { } remove { } }
    public event System.EventHandler DropDown { add { } remove { } }
    public event System.EventHandler DropDownClosed { add { } remove { } }
    public event System.EventHandler DropDownStyleChanged { add { } remove { } }
    public event System.EventHandler EnabledChanged { add { } remove { } }
    public event System.EventHandler Enter { add { } remove { } }
    public event System.EventHandler FontChanged { add { } remove { } }
    public event System.EventHandler ForeColorChanged { add { } remove { } }
    public event System.Windows.Forms.ListControlConvertEventHandler Format { add { } remove { } }
    public event System.EventHandler FormatStringChanged { add { } remove { } }
    public event System.EventHandler FormattingEnabledChanged { add { } remove { } }
    public event System.Windows.Forms.GiveFeedbackEventHandler GiveFeedback { add { } remove { } }
    public event System.Windows.Forms.HelpEventHandler HelpRequested { add { } remove { } }
    public event System.EventHandler ImeModeChanged { add { } remove { } }
    public event System.Windows.Forms.KeyEventHandler KeyDown { add { } remove { } }
    public event System.Windows.Forms.KeyPressEventHandler KeyPress { add { } remove { } }
    public event System.Windows.Forms.KeyEventHandler KeyUp { add { } remove { } }
    public event System.Windows.Forms.LayoutEventHandler Layout { add { } remove { } }
    public event System.EventHandler Leave { add { } remove { } }
    public event System.EventHandler LocationChanged { add { } remove { } }
    public event System.EventHandler MarginChanged { add { } remove { } }
    public event System.Windows.Forms.MeasureItemEventHandler MeasureItem { add { } remove { } }
    public event System.EventHandler MouseCaptureChanged { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseClick { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseDoubleClick { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseDown { add { } remove { } }
    public event System.EventHandler MouseEnter { add { } remove { } }
    public event System.EventHandler MouseHover { add { } remove { } }
    public event System.EventHandler MouseLeave { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseMove { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseUp { add { } remove { } }
    public event System.EventHandler Move { add { } remove { } }
    public event System.EventHandler PaddingChanged { add { } remove { } }
    public event System.EventHandler ParentChanged { add { } remove { } }
    public event System.Windows.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp { add { } remove { } }
    public event System.Windows.Forms.QueryContinueDragEventHandler QueryContinueDrag { add { } remove { } }
    public event System.EventHandler RegionChanged { add { } remove { } }
    public event System.EventHandler Resize { add { } remove { } }
    public event System.EventHandler RightToLeftChanged { add { } remove { } }
    public event System.EventHandler SelectedIndexChanged { add { } remove { } }
    public event System.EventHandler SelectedValueChanged { add { } remove { } }
    public event System.EventHandler SelectionChangeCommitted { add { } remove { } }
    public event System.EventHandler SizeChanged { add { } remove { } }
    public event System.EventHandler StyleChanged { add { } remove { } }
    public event System.EventHandler SystemColorsChanged { add { } remove { } }
    public event System.EventHandler TabIndexChanged { add { } remove { } }
    public event System.EventHandler TabStopChanged { add { } remove { } }
    public event System.EventHandler TextChanged { add { } remove { } }
    public event System.EventHandler TextUpdate { add { } remove { } }
    public event System.EventHandler Validated { add { } remove { } }
    public event System.ComponentModel.CancelEventHandler Validating { add { } remove { } }
    public event System.EventHandler ValueMemberChanged { add { } remove { } }
    public event System.EventHandler VisibleChanged { add { } remove { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    bool CanExtend(object target) { return default(bool); }
    protected override System.Type GetControlInstanceType() { return default(System.Type); }
    public short GetIndex(System.Windows.Forms.ComboBox o) { return default(short); }
    protected override void HookUpControlEvents(object o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void ResetIndex(System.Windows.Forms.ComboBox o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void SetIndex(System.Windows.Forms.ComboBox o, short Index) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeIndex(System.Windows.Forms.ComboBox o) { return default(bool); }
  }
  [System.ComponentModel.DesignerAttribute(typeof(Microsoft.VisualBasic.Compatibility.VB6.CompatibilityListBoxDesigner))]
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class DirListBox : System.Windows.Forms.ListBox {
    public DirListBox() { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new int ColumnWidth { get { return default(int); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new object DataSource { get { return default(object); } set { } }
    [System.Runtime.CompilerServices.IndexerName("DirList")]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public string this[int Index] { get { return default(string); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public int DirListCount { get { return default(int); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public int DirListIndex { get { return default(int); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public override System.Windows.Forms.DrawMode DrawMode { get { return default(System.Windows.Forms.DrawMode); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new int ItemHeight { get { return default(int); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new System.Windows.Forms.ListBox.ObjectCollection Items { get { return default(System.Windows.Forms.ListBox.ObjectCollection); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new bool MultiColumn { get { return default(bool); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public string Path { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new System.Windows.Forms.SelectionMode SelectionMode { get { return default(System.Windows.Forms.SelectionMode); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new bool Sorted { get { return default(bool); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new string ValueMember { get { return default(string); } set { } }
    public event System.EventHandler Change { add { } remove { } }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, SharedState=true)]
    protected override void Dispose(bool Disposing) { }
    protected override void OnBackColorChanged(System.EventArgs e) { }
    protected virtual void OnChange(System.EventArgs e) { }
    protected override void OnDoubleClick(System.EventArgs e) { }
    protected override void OnDrawItem(System.Windows.Forms.DrawItemEventArgs e) { }
    protected override void OnFontChanged(System.EventArgs e) { }
    protected override void OnHandleCreated(System.EventArgs e) { }
    protected override void OnSelectedIndexChanged(System.EventArgs e) { }
    public override void Refresh() { }
  }
  [System.ComponentModel.ProvidePropertyAttribute("Index", typeof(Microsoft.VisualBasic.Compatibility.VB6.DirListBox))]
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class DirListBoxArray : Microsoft.VisualBasic.Compatibility.VB6.BaseControlArray, System.ComponentModel.IExtenderProvider {
    public DirListBoxArray() { }
    public DirListBoxArray(System.ComponentModel.IContainer Container) { }
    public Microsoft.VisualBasic.Compatibility.VB6.DirListBox this[short Index] { get { return default(Microsoft.VisualBasic.Compatibility.VB6.DirListBox); } }
    public event System.EventHandler BackColorChanged { add { } remove { } }
    public event System.EventHandler BindingContextChanged { add { } remove { } }
    public event System.EventHandler CausesValidationChanged { add { } remove { } }
    public event System.EventHandler Change { add { } remove { } }
    public event System.Windows.Forms.UICuesEventHandler ChangeUICues { add { } remove { } }
    public event System.EventHandler ContextMenuChanged { add { } remove { } }
    public event System.EventHandler CursorChanged { add { } remove { } }
    public event System.EventHandler DataSourceChanged { add { } remove { } }
    public event System.EventHandler DisplayMemberChanged { add { } remove { } }
    public event System.EventHandler DockChanged { add { } remove { } }
    public event System.EventHandler DoubleClick { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragDrop { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragEnter { add { } remove { } }
    public event System.EventHandler DragLeave { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragOver { add { } remove { } }
    public event System.Windows.Forms.DrawItemEventHandler DrawItem { add { } remove { } }
    public event System.EventHandler EnabledChanged { add { } remove { } }
    public event System.EventHandler Enter { add { } remove { } }
    public event System.EventHandler FontChanged { add { } remove { } }
    public event System.EventHandler ForeColorChanged { add { } remove { } }
    public event System.Windows.Forms.GiveFeedbackEventHandler GiveFeedback { add { } remove { } }
    public event System.Windows.Forms.HelpEventHandler HelpRequested { add { } remove { } }
    public event System.EventHandler ImeModeChanged { add { } remove { } }
    public event System.Windows.Forms.KeyEventHandler KeyDown { add { } remove { } }
    public event System.Windows.Forms.KeyPressEventHandler KeyPress { add { } remove { } }
    public event System.Windows.Forms.KeyEventHandler KeyUp { add { } remove { } }
    public event System.Windows.Forms.LayoutEventHandler Layout { add { } remove { } }
    public event System.EventHandler Leave { add { } remove { } }
    public event System.EventHandler LocationChanged { add { } remove { } }
    public event System.Windows.Forms.MeasureItemEventHandler MeasureItem { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseDown { add { } remove { } }
    public event System.EventHandler MouseEnter { add { } remove { } }
    public event System.EventHandler MouseHover { add { } remove { } }
    public event System.EventHandler MouseLeave { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseMove { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseUp { add { } remove { } }
    public event System.EventHandler Move { add { } remove { } }
    public event System.EventHandler ParentChanged { add { } remove { } }
    public event System.Windows.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp { add { } remove { } }
    public event System.Windows.Forms.QueryContinueDragEventHandler QueryContinueDrag { add { } remove { } }
    public event System.EventHandler Resize { add { } remove { } }
    public event System.EventHandler RightToLeftChanged { add { } remove { } }
    public event System.EventHandler SelectedIndexChanged { add { } remove { } }
    public event System.EventHandler SelectedValueChanged { add { } remove { } }
    public event System.EventHandler SizeChanged { add { } remove { } }
    public event System.EventHandler StyleChanged { add { } remove { } }
    public event System.EventHandler SystemColorsChanged { add { } remove { } }
    public event System.EventHandler TabIndexChanged { add { } remove { } }
    public event System.EventHandler TabStopChanged { add { } remove { } }
    public event System.EventHandler Validated { add { } remove { } }
    public event System.ComponentModel.CancelEventHandler Validating { add { } remove { } }
    public event System.EventHandler ValueMemberChanged { add { } remove { } }
    public event System.EventHandler VisibleChanged { add { } remove { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    bool CanExtend(object target) { return default(bool); }
    protected override System.Type GetControlInstanceType() { return default(System.Type); }
    public short GetIndex(Microsoft.VisualBasic.Compatibility.VB6.DirListBox o) { return default(short); }
    protected override void HookUpControlEvents(object o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void ResetIndex(Microsoft.VisualBasic.Compatibility.VB6.DirListBox o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void SetIndex(Microsoft.VisualBasic.Compatibility.VB6.DirListBox o, short Index) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeIndex(Microsoft.VisualBasic.Compatibility.VB6.DirListBox o) { return default(bool); }
  }
  [System.ComponentModel.DesignerAttribute(typeof(Microsoft.VisualBasic.Compatibility.VB6.CompatibilityComboBoxDesigner))]
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class DriveListBox : System.Windows.Forms.ComboBox {
    public DriveListBox() { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new object DataSource { get { return default(object); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new string DisplayMember { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public new System.Windows.Forms.DrawMode DrawMode { get { return default(System.Windows.Forms.DrawMode); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public string Drive { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new System.Windows.Forms.ComboBoxStyle DropDownStyle { get { return default(System.Windows.Forms.ComboBoxStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public new int ItemHeight { get { return default(int); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new System.Windows.Forms.ComboBox.ObjectCollection Items { get { return default(System.Windows.Forms.ComboBox.ObjectCollection); } }
    [System.Runtime.CompilerServices.IndexerName("Items")]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public string this[int Index] { get { return default(string); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new int MaxLength { get { return default(int); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new bool Sorted { get { return default(bool); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new string Text { get { return default(string); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new string ValueMember { get { return default(string); } set { } }
    protected override void Dispose(bool disposing) { }
    protected override void OnBackColorChanged(System.EventArgs e) { }
    protected override void OnDrawItem(System.Windows.Forms.DrawItemEventArgs e) { }
    protected override void OnFontChanged(System.EventArgs e) { }
    protected override void OnHandleCreated(System.EventArgs e) { }
    protected override void OnSelectedIndexChanged(System.EventArgs e) { }
    public override void Refresh() { }
    protected override void WndProc(ref System.Windows.Forms.Message m) { }
  }
  [System.ComponentModel.ProvidePropertyAttribute("Index", typeof(Microsoft.VisualBasic.Compatibility.VB6.DriveListBox))]
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class DriveListBoxArray : Microsoft.VisualBasic.Compatibility.VB6.BaseControlArray, System.ComponentModel.IExtenderProvider {
    public DriveListBoxArray() { }
    public DriveListBoxArray(System.ComponentModel.IContainer Container) { }
    public Microsoft.VisualBasic.Compatibility.VB6.DriveListBox this[short Index] { get { return default(Microsoft.VisualBasic.Compatibility.VB6.DriveListBox); } }
    public event System.EventHandler BackColorChanged { add { } remove { } }
    public event System.EventHandler BindingContextChanged { add { } remove { } }
    public event System.EventHandler CausesValidationChanged { add { } remove { } }
    public event System.Windows.Forms.UICuesEventHandler ChangeUICues { add { } remove { } }
    public event System.EventHandler Click { add { } remove { } }
    public event System.EventHandler ContextMenuChanged { add { } remove { } }
    public event System.EventHandler CursorChanged { add { } remove { } }
    public event System.EventHandler DataSourceChanged { add { } remove { } }
    public event System.EventHandler DisplayMemberChanged { add { } remove { } }
    public event System.EventHandler DockChanged { add { } remove { } }
    public event System.EventHandler DoubleClick { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragDrop { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragEnter { add { } remove { } }
    public event System.EventHandler DragLeave { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragOver { add { } remove { } }
    public event System.Windows.Forms.DrawItemEventHandler DrawItem { add { } remove { } }
    public event System.EventHandler DropDown { add { } remove { } }
    public event System.EventHandler DropDownStyleChanged { add { } remove { } }
    public event System.EventHandler EnabledChanged { add { } remove { } }
    public event System.EventHandler Enter { add { } remove { } }
    public event System.EventHandler FontChanged { add { } remove { } }
    public event System.EventHandler ForeColorChanged { add { } remove { } }
    public event System.Windows.Forms.GiveFeedbackEventHandler GiveFeedback { add { } remove { } }
    public event System.Windows.Forms.HelpEventHandler HelpRequested { add { } remove { } }
    public event System.EventHandler ImeModeChanged { add { } remove { } }
    public event System.Windows.Forms.KeyEventHandler KeyDown { add { } remove { } }
    public event System.Windows.Forms.KeyPressEventHandler KeyPress { add { } remove { } }
    public event System.Windows.Forms.KeyEventHandler KeyUp { add { } remove { } }
    public event System.Windows.Forms.LayoutEventHandler Layout { add { } remove { } }
    public event System.EventHandler Leave { add { } remove { } }
    public event System.EventHandler LocationChanged { add { } remove { } }
    public event System.Windows.Forms.MeasureItemEventHandler MeasureItem { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseDown { add { } remove { } }
    public event System.EventHandler MouseEnter { add { } remove { } }
    public event System.EventHandler MouseHover { add { } remove { } }
    public event System.EventHandler MouseLeave { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseMove { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseUp { add { } remove { } }
    public event System.EventHandler Move { add { } remove { } }
    public event System.EventHandler ParentChanged { add { } remove { } }
    public event System.Windows.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp { add { } remove { } }
    public event System.Windows.Forms.QueryContinueDragEventHandler QueryContinueDrag { add { } remove { } }
    public event System.EventHandler Resize { add { } remove { } }
    public event System.EventHandler RightToLeftChanged { add { } remove { } }
    public event System.EventHandler SelectedIndexChanged { add { } remove { } }
    public event System.EventHandler SelectedValueChanged { add { } remove { } }
    public event System.EventHandler SelectionChangeCommitted { add { } remove { } }
    public event System.EventHandler SizeChanged { add { } remove { } }
    public event System.EventHandler StyleChanged { add { } remove { } }
    public event System.EventHandler SystemColorsChanged { add { } remove { } }
    public event System.EventHandler TabIndexChanged { add { } remove { } }
    public event System.EventHandler TabStopChanged { add { } remove { } }
    public event System.EventHandler TextChanged { add { } remove { } }
    public event System.EventHandler Validated { add { } remove { } }
    public event System.ComponentModel.CancelEventHandler Validating { add { } remove { } }
    public event System.EventHandler ValueMemberChanged { add { } remove { } }
    public event System.EventHandler VisibleChanged { add { } remove { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    bool CanExtend(object target) { return default(bool); }
    protected override System.Type GetControlInstanceType() { return default(System.Type); }
    public short GetIndex(Microsoft.VisualBasic.Compatibility.VB6.DriveListBox o) { return default(short); }
    protected override void HookUpControlEvents(object o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void ResetIndex(Microsoft.VisualBasic.Compatibility.VB6.DriveListBox o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void SetIndex(Microsoft.VisualBasic.Compatibility.VB6.DriveListBox o, short Index) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeIndex(Microsoft.VisualBasic.Compatibility.VB6.DriveListBox o) { return default(bool); }
  }
  [System.ComponentModel.DesignerAttribute(typeof(Microsoft.VisualBasic.Compatibility.VB6.CompatibilityListBoxDesigner))]
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class FileListBox : System.Windows.Forms.ListBox {
    public FileListBox() { }
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool Archive { get { return default(bool); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new object DataSource { get { return default(object); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new string DisplayMember { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public string FileName { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool Hidden { get { return default(bool); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new int ItemHeight { get { return default(int); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new System.Windows.Forms.ListBox.ObjectCollection Items { get { return default(System.Windows.Forms.ListBox.ObjectCollection); } }
    [System.Runtime.CompilerServices.IndexerName("Items")]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public string this[int Index] { get { return default(string); } }
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool Normal { get { return default(bool); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public string Path { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    public string Pattern { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool ReadOnly { get { return default(bool); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new bool Sorted { get { return default(bool); } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool System { get { return default(bool); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new string ValueMember { get { return default(string); } set { } }
    public event System.EventHandler PathChange { add { } remove { } }
    public event System.EventHandler PatternChange { add { } remove { } }
    protected override void OnDoubleClick(System.EventArgs e) { }
    protected virtual void OnPathChange(System.EventArgs e) { }
    protected virtual void OnPatternChange(System.EventArgs e) { }
    protected override void OnSelectedIndexChanged(System.EventArgs e) { }
    public override void Refresh() { }
  }
  [System.ComponentModel.ProvidePropertyAttribute("Index", typeof(Microsoft.VisualBasic.Compatibility.VB6.FileListBox))]
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class FileListBoxArray : Microsoft.VisualBasic.Compatibility.VB6.BaseControlArray, System.ComponentModel.IExtenderProvider {
    public FileListBoxArray() { }
    public FileListBoxArray(System.ComponentModel.IContainer Container) { }
    public Microsoft.VisualBasic.Compatibility.VB6.FileListBox this[short Index] { get { return default(Microsoft.VisualBasic.Compatibility.VB6.FileListBox); } }
    public event System.EventHandler BackColorChanged { add { } remove { } }
    public event System.EventHandler BindingContextChanged { add { } remove { } }
    public event System.EventHandler CausesValidationChanged { add { } remove { } }
    public event System.Windows.Forms.UICuesEventHandler ChangeUICues { add { } remove { } }
    public event System.EventHandler ContextMenuChanged { add { } remove { } }
    public event System.EventHandler CursorChanged { add { } remove { } }
    public event System.EventHandler DataSourceChanged { add { } remove { } }
    public event System.EventHandler DisplayMemberChanged { add { } remove { } }
    public event System.EventHandler DockChanged { add { } remove { } }
    public event System.EventHandler DoubleClick { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragDrop { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragEnter { add { } remove { } }
    public event System.EventHandler DragLeave { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragOver { add { } remove { } }
    public event System.Windows.Forms.DrawItemEventHandler DrawItem { add { } remove { } }
    public event System.EventHandler EnabledChanged { add { } remove { } }
    public event System.EventHandler Enter { add { } remove { } }
    public event System.EventHandler FontChanged { add { } remove { } }
    public event System.EventHandler ForeColorChanged { add { } remove { } }
    public event System.Windows.Forms.GiveFeedbackEventHandler GiveFeedback { add { } remove { } }
    public event System.Windows.Forms.HelpEventHandler HelpRequested { add { } remove { } }
    public event System.EventHandler ImeModeChanged { add { } remove { } }
    public event System.Windows.Forms.KeyEventHandler KeyDown { add { } remove { } }
    public event System.Windows.Forms.KeyPressEventHandler KeyPress { add { } remove { } }
    public event System.Windows.Forms.KeyEventHandler KeyUp { add { } remove { } }
    public event System.Windows.Forms.LayoutEventHandler Layout { add { } remove { } }
    public event System.EventHandler Leave { add { } remove { } }
    public event System.EventHandler LocationChanged { add { } remove { } }
    public event System.Windows.Forms.MeasureItemEventHandler MeasureItem { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseDown { add { } remove { } }
    public event System.EventHandler MouseEnter { add { } remove { } }
    public event System.EventHandler MouseHover { add { } remove { } }
    public event System.EventHandler MouseLeave { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseMove { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseUp { add { } remove { } }
    public event System.EventHandler Move { add { } remove { } }
    public event System.EventHandler ParentChanged { add { } remove { } }
    public event System.EventHandler PathChange { add { } remove { } }
    public event System.EventHandler PatternChange { add { } remove { } }
    public event System.Windows.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp { add { } remove { } }
    public event System.Windows.Forms.QueryContinueDragEventHandler QueryContinueDrag { add { } remove { } }
    public event System.EventHandler Resize { add { } remove { } }
    public event System.EventHandler RightToLeftChanged { add { } remove { } }
    public event System.EventHandler SelectedIndexChanged { add { } remove { } }
    public event System.EventHandler SelectedValueChanged { add { } remove { } }
    public event System.EventHandler SizeChanged { add { } remove { } }
    public event System.EventHandler StyleChanged { add { } remove { } }
    public event System.EventHandler SystemColorsChanged { add { } remove { } }
    public event System.EventHandler TabIndexChanged { add { } remove { } }
    public event System.EventHandler TabStopChanged { add { } remove { } }
    public event System.EventHandler Validated { add { } remove { } }
    public event System.ComponentModel.CancelEventHandler Validating { add { } remove { } }
    public event System.EventHandler ValueMemberChanged { add { } remove { } }
    public event System.EventHandler VisibleChanged { add { } remove { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    bool CanExtend(object target) { return default(bool); }
    protected override System.Type GetControlInstanceType() { return default(System.Type); }
    public short GetIndex(Microsoft.VisualBasic.Compatibility.VB6.FileListBox o) { return default(short); }
    protected override void HookUpControlEvents(object o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void ResetIndex(Microsoft.VisualBasic.Compatibility.VB6.FileListBox o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void SetIndex(Microsoft.VisualBasic.Compatibility.VB6.FileListBox o, short Index) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeIndex(Microsoft.VisualBasic.Compatibility.VB6.FileListBox o) { return default(bool); }
  }
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class FixedLengthString {
    protected int m_nMaxChars;
    protected string m_strValue;
    public FixedLengthString(int MaxChars) { }
    public FixedLengthString(int MaxChars, string InitialValue) { }
    public string Value { get { return default(string); } set { } }
    public override string ToString() { return default(string); }
  }
  [System.ComponentModel.ProvidePropertyAttribute("Index", typeof(System.Windows.Forms.FontDialog))]
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class FontDialogArray : Microsoft.VisualBasic.Compatibility.VB6.BaseControlArray, System.ComponentModel.IExtenderProvider {
    public FontDialogArray() { }
    public FontDialogArray(System.ComponentModel.IContainer Container) { }
    public System.Windows.Forms.FontDialog this[short Index] { get { return default(System.Windows.Forms.FontDialog); } }
    public event System.EventHandler Apply { add { } remove { } }
    public event System.EventHandler HelpRequest { add { } remove { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    bool CanExtend(object target) { return default(bool); }
    protected override System.Type GetControlInstanceType() { return default(System.Type); }
    public short GetIndex(System.Windows.Forms.FontDialog o) { return default(short); }
    protected override void HookUpControlEvents(object o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void ResetIndex(System.Windows.Forms.FontDialog o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void SetIndex(System.Windows.Forms.FontDialog o, short Index) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeIndex(System.Windows.Forms.FontDialog o) { return default(bool); }
  }
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public enum FormShowConstants {
    Modal = 1,
    Modeless = 0,
  }
  [System.ComponentModel.ProvidePropertyAttribute("Index", typeof(System.Windows.Forms.GroupBox))]
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class GroupBoxArray : Microsoft.VisualBasic.Compatibility.VB6.BaseControlArray, System.ComponentModel.IExtenderProvider {
    public GroupBoxArray() { }
    public GroupBoxArray(System.ComponentModel.IContainer Container) { }
    public System.Windows.Forms.GroupBox this[short Index] { get { return default(System.Windows.Forms.GroupBox); } }
    public event System.EventHandler AutoSizeChanged { add { } remove { } }
    public event System.EventHandler BackColorChanged { add { } remove { } }
    public event System.EventHandler BackgroundImageChanged { add { } remove { } }
    public event System.EventHandler BackgroundImageLayoutChanged { add { } remove { } }
    public event System.EventHandler BindingContextChanged { add { } remove { } }
    public event System.EventHandler CausesValidationChanged { add { } remove { } }
    public event System.Windows.Forms.UICuesEventHandler ChangeUICues { add { } remove { } }
    public event System.EventHandler ClientSizeChanged { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public event System.EventHandler ContextMenuChanged { add { } remove { } }
    public event System.EventHandler ContextMenuStripChanged { add { } remove { } }
    public event System.Windows.Forms.ControlEventHandler ControlAdded { add { } remove { } }
    public event System.Windows.Forms.ControlEventHandler ControlRemoved { add { } remove { } }
    public event System.EventHandler CursorChanged { add { } remove { } }
    public event System.EventHandler DockChanged { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragDrop { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragEnter { add { } remove { } }
    public event System.EventHandler DragLeave { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragOver { add { } remove { } }
    public event System.EventHandler EnabledChanged { add { } remove { } }
    public event System.EventHandler Enter { add { } remove { } }
    public event System.EventHandler FontChanged { add { } remove { } }
    public event System.EventHandler ForeColorChanged { add { } remove { } }
    public event System.Windows.Forms.GiveFeedbackEventHandler GiveFeedback { add { } remove { } }
    public event System.Windows.Forms.HelpEventHandler HelpRequested { add { } remove { } }
    public event System.EventHandler ImeModeChanged { add { } remove { } }
    public event System.Windows.Forms.LayoutEventHandler Layout { add { } remove { } }
    public event System.EventHandler Leave { add { } remove { } }
    public event System.EventHandler LocationChanged { add { } remove { } }
    public event System.EventHandler MarginChanged { add { } remove { } }
    public event System.EventHandler MouseCaptureChanged { add { } remove { } }
    public event System.EventHandler MouseHover { add { } remove { } }
    public event System.EventHandler Move { add { } remove { } }
    public event System.EventHandler PaddingChanged { add { } remove { } }
    public event System.Windows.Forms.PaintEventHandler Paint { add { } remove { } }
    public event System.EventHandler ParentChanged { add { } remove { } }
    public event System.Windows.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp { add { } remove { } }
    public event System.Windows.Forms.QueryContinueDragEventHandler QueryContinueDrag { add { } remove { } }
    public event System.EventHandler RegionChanged { add { } remove { } }
    public event System.EventHandler Resize { add { } remove { } }
    public event System.EventHandler RightToLeftChanged { add { } remove { } }
    public event System.EventHandler SizeChanged { add { } remove { } }
    public event System.EventHandler StyleChanged { add { } remove { } }
    public event System.EventHandler SystemColorsChanged { add { } remove { } }
    public event System.EventHandler TabIndexChanged { add { } remove { } }
    public event System.EventHandler TextChanged { add { } remove { } }
    public event System.EventHandler Validated { add { } remove { } }
    public event System.ComponentModel.CancelEventHandler Validating { add { } remove { } }
    public event System.EventHandler VisibleChanged { add { } remove { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    bool CanExtend(object target) { return default(bool); }
    protected override System.Type GetControlInstanceType() { return default(System.Type); }
    public short GetIndex(System.Windows.Forms.GroupBox o) { return default(short); }
    protected override void HookUpControlEvents(object o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void ResetIndex(System.Windows.Forms.GroupBox o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void SetIndex(System.Windows.Forms.GroupBox o, short Index) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeIndex(System.Windows.Forms.GroupBox o) { return default(bool); }
  }
  [System.ComponentModel.ProvidePropertyAttribute("Index", typeof(System.Windows.Forms.HScrollBar))]
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class HScrollBarArray : Microsoft.VisualBasic.Compatibility.VB6.BaseControlArray, System.ComponentModel.IExtenderProvider {
    public HScrollBarArray() { }
    public HScrollBarArray(System.ComponentModel.IContainer Container) { }
    public System.Windows.Forms.HScrollBar this[short Index] { get { return default(System.Windows.Forms.HScrollBar); } }
    public event System.EventHandler BindingContextChanged { add { } remove { } }
    public event System.EventHandler CausesValidationChanged { add { } remove { } }
    public event System.Windows.Forms.UICuesEventHandler ChangeUICues { add { } remove { } }
    public event System.EventHandler ClientSizeChanged { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public event System.EventHandler ContextMenuChanged { add { } remove { } }
    public event System.EventHandler ContextMenuStripChanged { add { } remove { } }
    public event System.Windows.Forms.ControlEventHandler ControlAdded { add { } remove { } }
    public event System.Windows.Forms.ControlEventHandler ControlRemoved { add { } remove { } }
    public event System.EventHandler CursorChanged { add { } remove { } }
    public event System.EventHandler DockChanged { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragDrop { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragEnter { add { } remove { } }
    public event System.EventHandler DragLeave { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragOver { add { } remove { } }
    public event System.EventHandler EnabledChanged { add { } remove { } }
    public event System.EventHandler Enter { add { } remove { } }
    public event System.Windows.Forms.GiveFeedbackEventHandler GiveFeedback { add { } remove { } }
    public event System.Windows.Forms.HelpEventHandler HelpRequested { add { } remove { } }
    public event System.Windows.Forms.KeyEventHandler KeyDown { add { } remove { } }
    public event System.Windows.Forms.KeyPressEventHandler KeyPress { add { } remove { } }
    public event System.Windows.Forms.KeyEventHandler KeyUp { add { } remove { } }
    public event System.Windows.Forms.LayoutEventHandler Layout { add { } remove { } }
    public event System.EventHandler Leave { add { } remove { } }
    public event System.EventHandler LocationChanged { add { } remove { } }
    public event System.EventHandler MarginChanged { add { } remove { } }
    public event System.EventHandler MouseCaptureChanged { add { } remove { } }
    public event System.EventHandler MouseEnter { add { } remove { } }
    public event System.EventHandler MouseHover { add { } remove { } }
    public event System.EventHandler MouseLeave { add { } remove { } }
    public event System.EventHandler Move { add { } remove { } }
    public event System.EventHandler PaddingChanged { add { } remove { } }
    public event System.EventHandler ParentChanged { add { } remove { } }
    public event System.Windows.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp { add { } remove { } }
    public event System.Windows.Forms.QueryContinueDragEventHandler QueryContinueDrag { add { } remove { } }
    public event System.EventHandler RegionChanged { add { } remove { } }
    public event System.EventHandler Resize { add { } remove { } }
    public event System.EventHandler RightToLeftChanged { add { } remove { } }
    public event System.Windows.Forms.ScrollEventHandler Scroll { add { } remove { } }
    public event System.EventHandler SizeChanged { add { } remove { } }
    public event System.EventHandler StyleChanged { add { } remove { } }
    public event System.EventHandler SystemColorsChanged { add { } remove { } }
    public event System.EventHandler TabIndexChanged { add { } remove { } }
    public event System.EventHandler TabStopChanged { add { } remove { } }
    public event System.EventHandler Validated { add { } remove { } }
    public event System.ComponentModel.CancelEventHandler Validating { add { } remove { } }
    public event System.EventHandler ValueChanged { add { } remove { } }
    public event System.EventHandler VisibleChanged { add { } remove { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    bool CanExtend(object target) { return default(bool); }
    protected override System.Type GetControlInstanceType() { return default(System.Type); }
    public short GetIndex(System.Windows.Forms.HScrollBar o) { return default(short); }
    protected override void HookUpControlEvents(object o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void ResetIndex(System.Windows.Forms.HScrollBar o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void SetIndex(System.Windows.Forms.HScrollBar o, short Index) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeIndex(System.Windows.Forms.HScrollBar o) { return default(bool); }
  }
  [System.ComponentModel.ProvidePropertyAttribute("Index", typeof(System.Windows.Forms.ImageList))]
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class ImageListArray : Microsoft.VisualBasic.Compatibility.VB6.BaseControlArray, System.ComponentModel.IExtenderProvider {
    public ImageListArray() { }
    public ImageListArray(System.ComponentModel.IContainer Container) { }
    public System.Windows.Forms.ImageList this[short Index] { get { return default(System.Windows.Forms.ImageList); } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    bool CanExtend(object target) { return default(bool); }
    protected override System.Type GetControlInstanceType() { return default(System.Type); }
    public short GetIndex(System.Windows.Forms.ImageList o) { return default(short); }
    protected override void HookUpControlEvents(object o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void ResetIndex(System.Windows.Forms.ImageList o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void SetIndex(System.Windows.Forms.ImageList o, short Index) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeIndex(System.Windows.Forms.ImageList o) { return default(bool); }
  }
  [System.ComponentModel.ProvidePropertyAttribute("Index", typeof(System.Windows.Forms.Label))]
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class LabelArray : Microsoft.VisualBasic.Compatibility.VB6.BaseControlArray, System.ComponentModel.IExtenderProvider {
    public LabelArray() { }
    public LabelArray(System.ComponentModel.IContainer Container) { }
    public System.Windows.Forms.Label this[short Index] { get { return default(System.Windows.Forms.Label); } }
    public event System.EventHandler AutoSizeChanged { add { } remove { } }
    public event System.EventHandler BackColorChanged { add { } remove { } }
    public event System.EventHandler BindingContextChanged { add { } remove { } }
    public event System.EventHandler CausesValidationChanged { add { } remove { } }
    public event System.Windows.Forms.UICuesEventHandler ChangeUICues { add { } remove { } }
    public event System.EventHandler Click { add { } remove { } }
    public event System.EventHandler ClientSizeChanged { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public event System.EventHandler ContextMenuChanged { add { } remove { } }
    public event System.EventHandler ContextMenuStripChanged { add { } remove { } }
    public event System.Windows.Forms.ControlEventHandler ControlAdded { add { } remove { } }
    public event System.Windows.Forms.ControlEventHandler ControlRemoved { add { } remove { } }
    public event System.EventHandler CursorChanged { add { } remove { } }
    public event System.EventHandler DockChanged { add { } remove { } }
    public event System.EventHandler DoubleClick { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragDrop { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragEnter { add { } remove { } }
    public event System.EventHandler DragLeave { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragOver { add { } remove { } }
    public event System.EventHandler EnabledChanged { add { } remove { } }
    public event System.EventHandler Enter { add { } remove { } }
    public event System.EventHandler FontChanged { add { } remove { } }
    public event System.EventHandler ForeColorChanged { add { } remove { } }
    public event System.Windows.Forms.GiveFeedbackEventHandler GiveFeedback { add { } remove { } }
    public event System.Windows.Forms.HelpEventHandler HelpRequested { add { } remove { } }
    public event System.Windows.Forms.LayoutEventHandler Layout { add { } remove { } }
    public event System.EventHandler Leave { add { } remove { } }
    public event System.EventHandler LocationChanged { add { } remove { } }
    public event System.EventHandler MarginChanged { add { } remove { } }
    public event System.EventHandler MouseCaptureChanged { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseClick { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseDoubleClick { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseDown { add { } remove { } }
    public event System.EventHandler MouseEnter { add { } remove { } }
    public event System.EventHandler MouseHover { add { } remove { } }
    public event System.EventHandler MouseLeave { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseMove { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseUp { add { } remove { } }
    public event System.EventHandler Move { add { } remove { } }
    public event System.EventHandler PaddingChanged { add { } remove { } }
    public event System.Windows.Forms.PaintEventHandler Paint { add { } remove { } }
    public event System.EventHandler ParentChanged { add { } remove { } }
    public event System.Windows.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp { add { } remove { } }
    public event System.Windows.Forms.QueryContinueDragEventHandler QueryContinueDrag { add { } remove { } }
    public event System.EventHandler RegionChanged { add { } remove { } }
    public event System.EventHandler Resize { add { } remove { } }
    public event System.EventHandler RightToLeftChanged { add { } remove { } }
    public event System.EventHandler SizeChanged { add { } remove { } }
    public event System.EventHandler StyleChanged { add { } remove { } }
    public event System.EventHandler SystemColorsChanged { add { } remove { } }
    public event System.EventHandler TabIndexChanged { add { } remove { } }
    public event System.EventHandler TextAlignChanged { add { } remove { } }
    public event System.EventHandler TextChanged { add { } remove { } }
    public event System.EventHandler Validated { add { } remove { } }
    public event System.ComponentModel.CancelEventHandler Validating { add { } remove { } }
    public event System.EventHandler VisibleChanged { add { } remove { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    bool CanExtend(object target) { return default(bool); }
    protected override System.Type GetControlInstanceType() { return default(System.Type); }
    public short GetIndex(System.Windows.Forms.Label o) { return default(short); }
    protected override void HookUpControlEvents(object o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void ResetIndex(System.Windows.Forms.Label o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void SetIndex(System.Windows.Forms.Label o, short Index) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeIndex(System.Windows.Forms.Label o) { return default(bool); }
  }
  [System.ComponentModel.ProvidePropertyAttribute("Index", typeof(System.Windows.Forms.ListBox))]
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class ListBoxArray : Microsoft.VisualBasic.Compatibility.VB6.BaseControlArray, System.ComponentModel.IExtenderProvider {
    public ListBoxArray() { }
    public ListBoxArray(System.ComponentModel.IContainer Container) { }
    public System.Windows.Forms.ListBox this[short Index] { get { return default(System.Windows.Forms.ListBox); } }
    public event System.EventHandler BackColorChanged { add { } remove { } }
    public event System.EventHandler BindingContextChanged { add { } remove { } }
    public event System.EventHandler CausesValidationChanged { add { } remove { } }
    public event System.Windows.Forms.UICuesEventHandler ChangeUICues { add { } remove { } }
    public event System.EventHandler Click { add { } remove { } }
    public event System.EventHandler ClientSizeChanged { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public event System.EventHandler ContextMenuChanged { add { } remove { } }
    public event System.EventHandler ContextMenuStripChanged { add { } remove { } }
    public event System.Windows.Forms.ControlEventHandler ControlAdded { add { } remove { } }
    public event System.Windows.Forms.ControlEventHandler ControlRemoved { add { } remove { } }
    public event System.EventHandler CursorChanged { add { } remove { } }
    public event System.EventHandler DataSourceChanged { add { } remove { } }
    public event System.EventHandler DisplayMemberChanged { add { } remove { } }
    public event System.EventHandler DockChanged { add { } remove { } }
    public event System.EventHandler DoubleClick { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragDrop { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragEnter { add { } remove { } }
    public event System.EventHandler DragLeave { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragOver { add { } remove { } }
    public event System.Windows.Forms.DrawItemEventHandler DrawItem { add { } remove { } }
    public event System.EventHandler EnabledChanged { add { } remove { } }
    public event System.EventHandler Enter { add { } remove { } }
    public event System.EventHandler FontChanged { add { } remove { } }
    public event System.EventHandler ForeColorChanged { add { } remove { } }
    public event System.Windows.Forms.ListControlConvertEventHandler Format { add { } remove { } }
    public event System.EventHandler FormatStringChanged { add { } remove { } }
    public event System.EventHandler FormattingEnabledChanged { add { } remove { } }
    public event System.Windows.Forms.GiveFeedbackEventHandler GiveFeedback { add { } remove { } }
    public event System.Windows.Forms.HelpEventHandler HelpRequested { add { } remove { } }
    public event System.EventHandler ImeModeChanged { add { } remove { } }
    public event System.Windows.Forms.KeyEventHandler KeyDown { add { } remove { } }
    public event System.Windows.Forms.KeyPressEventHandler KeyPress { add { } remove { } }
    public event System.Windows.Forms.KeyEventHandler KeyUp { add { } remove { } }
    public event System.Windows.Forms.LayoutEventHandler Layout { add { } remove { } }
    public event System.EventHandler Leave { add { } remove { } }
    public event System.EventHandler LocationChanged { add { } remove { } }
    public event System.EventHandler MarginChanged { add { } remove { } }
    public event System.Windows.Forms.MeasureItemEventHandler MeasureItem { add { } remove { } }
    public event System.EventHandler MouseCaptureChanged { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseClick { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseDoubleClick { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseDown { add { } remove { } }
    public event System.EventHandler MouseEnter { add { } remove { } }
    public event System.EventHandler MouseHover { add { } remove { } }
    public event System.EventHandler MouseLeave { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseMove { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseUp { add { } remove { } }
    public event System.EventHandler Move { add { } remove { } }
    public event System.EventHandler PaddingChanged { add { } remove { } }
    public event System.EventHandler ParentChanged { add { } remove { } }
    public event System.Windows.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp { add { } remove { } }
    public event System.Windows.Forms.QueryContinueDragEventHandler QueryContinueDrag { add { } remove { } }
    public event System.EventHandler RegionChanged { add { } remove { } }
    public event System.EventHandler Resize { add { } remove { } }
    public event System.EventHandler RightToLeftChanged { add { } remove { } }
    public event System.EventHandler SelectedIndexChanged { add { } remove { } }
    public event System.EventHandler SelectedValueChanged { add { } remove { } }
    public event System.EventHandler SizeChanged { add { } remove { } }
    public event System.EventHandler StyleChanged { add { } remove { } }
    public event System.EventHandler SystemColorsChanged { add { } remove { } }
    public event System.EventHandler TabIndexChanged { add { } remove { } }
    public event System.EventHandler TabStopChanged { add { } remove { } }
    public event System.EventHandler Validated { add { } remove { } }
    public event System.ComponentModel.CancelEventHandler Validating { add { } remove { } }
    public event System.EventHandler ValueMemberChanged { add { } remove { } }
    public event System.EventHandler VisibleChanged { add { } remove { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    bool CanExtend(object target) { return default(bool); }
    protected override System.Type GetControlInstanceType() { return default(System.Type); }
    public short GetIndex(System.Windows.Forms.ListBox o) { return default(short); }
    protected override void HookUpControlEvents(object o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void ResetIndex(System.Windows.Forms.ListBox o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void SetIndex(System.Windows.Forms.ListBox o, short Index) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeIndex(System.Windows.Forms.ListBox o) { return default(bool); }
  }
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class ListBoxItem {
    public int ItemData;
    public string ItemString;
    public ListBoxItem(string ItemString) { }
    public ListBoxItem(string ItemString, int ItemData) { }
    public override string ToString() { return default(string); }
  }
  [System.ComponentModel.ProvidePropertyAttribute("Index", typeof(System.Windows.Forms.ListView))]
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class ListViewArray : Microsoft.VisualBasic.Compatibility.VB6.BaseControlArray, System.ComponentModel.IExtenderProvider {
    public ListViewArray() { }
    public ListViewArray(System.ComponentModel.IContainer Container) { }
    public System.Windows.Forms.ListView this[short Index] { get { return default(System.Windows.Forms.ListView); } }
    public event System.Windows.Forms.LabelEditEventHandler AfterLabelEdit { add { } remove { } }
    public event System.EventHandler BackColorChanged { add { } remove { } }
    public event System.EventHandler BackgroundImageChanged { add { } remove { } }
    public event System.Windows.Forms.LabelEditEventHandler BeforeLabelEdit { add { } remove { } }
    public event System.EventHandler BindingContextChanged { add { } remove { } }
    public event System.Windows.Forms.CacheVirtualItemsEventHandler CacheVirtualItems { add { } remove { } }
    public event System.EventHandler CausesValidationChanged { add { } remove { } }
    public event System.Windows.Forms.UICuesEventHandler ChangeUICues { add { } remove { } }
    public event System.EventHandler Click { add { } remove { } }
    public event System.EventHandler ClientSizeChanged { add { } remove { } }
    public event System.Windows.Forms.ColumnClickEventHandler ColumnClick { add { } remove { } }
    public event System.Windows.Forms.ColumnReorderedEventHandler ColumnReordered { add { } remove { } }
    public event System.Windows.Forms.ColumnWidthChangedEventHandler ColumnWidthChanged { add { } remove { } }
    public event System.Windows.Forms.ColumnWidthChangingEventHandler ColumnWidthChanging { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public event System.EventHandler ContextMenuChanged { add { } remove { } }
    public event System.EventHandler ContextMenuStripChanged { add { } remove { } }
    public event System.Windows.Forms.ControlEventHandler ControlAdded { add { } remove { } }
    public event System.Windows.Forms.ControlEventHandler ControlRemoved { add { } remove { } }
    public event System.EventHandler CursorChanged { add { } remove { } }
    public event System.EventHandler DockChanged { add { } remove { } }
    public event System.EventHandler DoubleClick { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragDrop { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragEnter { add { } remove { } }
    public event System.EventHandler DragLeave { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragOver { add { } remove { } }
    public event System.Windows.Forms.DrawListViewColumnHeaderEventHandler DrawColumnHeader { add { } remove { } }
    public event System.Windows.Forms.DrawListViewItemEventHandler DrawItem { add { } remove { } }
    public event System.Windows.Forms.DrawListViewSubItemEventHandler DrawSubItem { add { } remove { } }
    public event System.EventHandler EnabledChanged { add { } remove { } }
    public event System.EventHandler Enter { add { } remove { } }
    public event System.EventHandler FontChanged { add { } remove { } }
    public event System.EventHandler ForeColorChanged { add { } remove { } }
    public event System.Windows.Forms.GiveFeedbackEventHandler GiveFeedback { add { } remove { } }
    public event System.Windows.Forms.HelpEventHandler HelpRequested { add { } remove { } }
    public event System.EventHandler ImeModeChanged { add { } remove { } }
    public event System.EventHandler ItemActivate { add { } remove { } }
    public event System.Windows.Forms.ItemCheckEventHandler ItemCheck { add { } remove { } }
    public event System.Windows.Forms.ItemCheckedEventHandler ItemChecked { add { } remove { } }
    public event System.Windows.Forms.ItemDragEventHandler ItemDrag { add { } remove { } }
    public event System.Windows.Forms.ListViewItemMouseHoverEventHandler ItemMouseHover { add { } remove { } }
    public event System.Windows.Forms.ListViewItemSelectionChangedEventHandler ItemSelectionChanged { add { } remove { } }
    public event System.Windows.Forms.KeyEventHandler KeyDown { add { } remove { } }
    public event System.Windows.Forms.KeyPressEventHandler KeyPress { add { } remove { } }
    public event System.Windows.Forms.KeyEventHandler KeyUp { add { } remove { } }
    public event System.Windows.Forms.LayoutEventHandler Layout { add { } remove { } }
    public event System.EventHandler Leave { add { } remove { } }
    public event System.EventHandler LocationChanged { add { } remove { } }
    public event System.EventHandler MarginChanged { add { } remove { } }
    public event System.EventHandler MouseCaptureChanged { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseClick { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseDoubleClick { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseDown { add { } remove { } }
    public event System.EventHandler MouseEnter { add { } remove { } }
    public event System.EventHandler MouseHover { add { } remove { } }
    public event System.EventHandler MouseLeave { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseMove { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseUp { add { } remove { } }
    public event System.EventHandler Move { add { } remove { } }
    public event System.EventHandler PaddingChanged { add { } remove { } }
    public event System.EventHandler ParentChanged { add { } remove { } }
    public event System.Windows.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp { add { } remove { } }
    public event System.Windows.Forms.QueryContinueDragEventHandler QueryContinueDrag { add { } remove { } }
    public event System.EventHandler RegionChanged { add { } remove { } }
    public event System.EventHandler Resize { add { } remove { } }
    public event System.Windows.Forms.RetrieveVirtualItemEventHandler RetrieveVirtualItem { add { } remove { } }
    public event System.EventHandler RightToLeftChanged { add { } remove { } }
    public event System.EventHandler RightToLeftLayoutChanged { add { } remove { } }
    public event System.Windows.Forms.SearchForVirtualItemEventHandler SearchForVirtualItem { add { } remove { } }
    public event System.EventHandler SelectedIndexChanged { add { } remove { } }
    public event System.EventHandler SizeChanged { add { } remove { } }
    public event System.EventHandler StyleChanged { add { } remove { } }
    public event System.EventHandler SystemColorsChanged { add { } remove { } }
    public event System.EventHandler TabIndexChanged { add { } remove { } }
    public event System.EventHandler TabStopChanged { add { } remove { } }
    public event System.EventHandler Validated { add { } remove { } }
    public event System.ComponentModel.CancelEventHandler Validating { add { } remove { } }
    public event System.Windows.Forms.ListViewVirtualItemsSelectionRangeChangedEventHandler VirtualItemsSelectionRangeChanged { add { } remove { } }
    public event System.EventHandler VisibleChanged { add { } remove { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    bool CanExtend(object target) { return default(bool); }
    protected override System.Type GetControlInstanceType() { return default(System.Type); }
    public short GetIndex(System.Windows.Forms.ListView o) { return default(short); }
    protected override void HookUpControlEvents(object o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void ResetIndex(System.Windows.Forms.ListView o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void SetIndex(System.Windows.Forms.ListView o, short Index) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeIndex(System.Windows.Forms.ListView o) { return default(bool); }
  }
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public enum LoadResConstants {
    ResBitmap = 0,
    ResCursor = 2,
    ResIcon = 1,
  }
  [System.ComponentModel.ProvidePropertyAttribute("Index", typeof(System.Windows.Forms.MaskedTextBox))]
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class MaskedTextBoxArray : Microsoft.VisualBasic.Compatibility.VB6.BaseControlArray, System.ComponentModel.IExtenderProvider {
    public MaskedTextBoxArray() { }
    public MaskedTextBoxArray(System.ComponentModel.IContainer Container) { }
    public System.Windows.Forms.MaskedTextBox this[short Index] { get { return default(System.Windows.Forms.MaskedTextBox); } }
    public event System.EventHandler BackColorChanged { add { } remove { } }
    public event System.EventHandler BindingContextChanged { add { } remove { } }
    public event System.EventHandler BorderStyleChanged { add { } remove { } }
    public event System.EventHandler CausesValidationChanged { add { } remove { } }
    public event System.Windows.Forms.UICuesEventHandler ChangeUICues { add { } remove { } }
    public event System.EventHandler Click { add { } remove { } }
    public event System.EventHandler ClientSizeChanged { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public event System.EventHandler ContextMenuChanged { add { } remove { } }
    public event System.EventHandler ContextMenuStripChanged { add { } remove { } }
    public event System.Windows.Forms.ControlEventHandler ControlAdded { add { } remove { } }
    public event System.Windows.Forms.ControlEventHandler ControlRemoved { add { } remove { } }
    public event System.EventHandler CursorChanged { add { } remove { } }
    public event System.EventHandler DockChanged { add { } remove { } }
    public event System.EventHandler DoubleClick { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragDrop { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragEnter { add { } remove { } }
    public event System.EventHandler DragLeave { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragOver { add { } remove { } }
    public event System.EventHandler EnabledChanged { add { } remove { } }
    public event System.EventHandler Enter { add { } remove { } }
    public event System.EventHandler FontChanged { add { } remove { } }
    public event System.EventHandler ForeColorChanged { add { } remove { } }
    public event System.Windows.Forms.GiveFeedbackEventHandler GiveFeedback { add { } remove { } }
    public event System.Windows.Forms.HelpEventHandler HelpRequested { add { } remove { } }
    public event System.EventHandler HideSelectionChanged { add { } remove { } }
    public event System.EventHandler ImeModeChanged { add { } remove { } }
    public event System.EventHandler IsOverwriteModeChanged { add { } remove { } }
    public event System.Windows.Forms.KeyEventHandler KeyDown { add { } remove { } }
    public event System.Windows.Forms.KeyPressEventHandler KeyPress { add { } remove { } }
    public event System.Windows.Forms.KeyEventHandler KeyUp { add { } remove { } }
    public event System.Windows.Forms.LayoutEventHandler Layout { add { } remove { } }
    public event System.EventHandler Leave { add { } remove { } }
    public event System.EventHandler LocationChanged { add { } remove { } }
    public event System.EventHandler MarginChanged { add { } remove { } }
    public event System.EventHandler MaskChanged { add { } remove { } }
    public event System.Windows.Forms.MaskInputRejectedEventHandler MaskInputRejected { add { } remove { } }
    public event System.EventHandler ModifiedChanged { add { } remove { } }
    public event System.EventHandler MouseCaptureChanged { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseClick { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseDoubleClick { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseDown { add { } remove { } }
    public event System.EventHandler MouseEnter { add { } remove { } }
    public event System.EventHandler MouseHover { add { } remove { } }
    public event System.EventHandler MouseLeave { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseMove { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseUp { add { } remove { } }
    public event System.EventHandler Move { add { } remove { } }
    public event System.EventHandler ParentChanged { add { } remove { } }
    public event System.Windows.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp { add { } remove { } }
    public event System.Windows.Forms.QueryContinueDragEventHandler QueryContinueDrag { add { } remove { } }
    public event System.EventHandler ReadOnlyChanged { add { } remove { } }
    public event System.EventHandler RegionChanged { add { } remove { } }
    public event System.EventHandler Resize { add { } remove { } }
    public event System.EventHandler RightToLeftChanged { add { } remove { } }
    public event System.EventHandler SizeChanged { add { } remove { } }
    public event System.EventHandler StyleChanged { add { } remove { } }
    public event System.EventHandler SystemColorsChanged { add { } remove { } }
    public event System.EventHandler TabIndexChanged { add { } remove { } }
    public event System.EventHandler TabStopChanged { add { } remove { } }
    public event System.EventHandler TextAlignChanged { add { } remove { } }
    public event System.EventHandler TextChanged { add { } remove { } }
    public event System.Windows.Forms.TypeValidationEventHandler TypeValidationCompleted { add { } remove { } }
    public event System.EventHandler Validated { add { } remove { } }
    public event System.ComponentModel.CancelEventHandler Validating { add { } remove { } }
    public event System.EventHandler VisibleChanged { add { } remove { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    bool CanExtend(object target) { return default(bool); }
    protected override System.Type GetControlInstanceType() { return default(System.Type); }
    public short GetIndex(System.Windows.Forms.MaskedTextBox o) { return default(short); }
    protected override void HookUpControlEvents(object o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void ResetIndex(System.Windows.Forms.MaskedTextBox o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void SetIndex(System.Windows.Forms.MaskedTextBox o, short Index) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeIndex(System.Windows.Forms.MaskedTextBox o) { return default(bool); }
  }
  [System.ComponentModel.ProvidePropertyAttribute("Index", typeof(System.Windows.Forms.MenuItem))]
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class MenuItemArray : Microsoft.VisualBasic.Compatibility.VB6.BaseControlArray, System.ComponentModel.IExtenderProvider {
    public MenuItemArray() { }
    public MenuItemArray(System.ComponentModel.IContainer Container) { }
    public System.Windows.Forms.MenuItem this[short Index] { get { return default(System.Windows.Forms.MenuItem); } }
    public event System.EventHandler Click { add { } remove { } }
    public event System.Windows.Forms.DrawItemEventHandler DrawItem { add { } remove { } }
    public event System.Windows.Forms.MeasureItemEventHandler MeasureItem { add { } remove { } }
    public event System.EventHandler Popup { add { } remove { } }
    public event System.EventHandler Select { add { } remove { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    bool CanExtend(object target) { return default(bool); }
    protected override System.Type GetControlInstanceType() { return default(System.Type); }
    public short GetIndex(System.Windows.Forms.MenuItem o) { return default(short); }
    protected override void HookUpControlEvents(object o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void ResetIndex(System.Windows.Forms.MenuItem o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void SetIndex(System.Windows.Forms.MenuItem o, short Index) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeIndex(System.Windows.Forms.MenuItem o) { return default(bool); }
  }
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public enum MouseButtonConstants {
    LeftButton = 1,
    MiddleButton = 4,
    RightButton = 2,
  }
  [System.ComponentModel.ProvidePropertyAttribute("Index", typeof(System.Windows.Forms.OpenFileDialog))]
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class OpenFileDialogArray : Microsoft.VisualBasic.Compatibility.VB6.BaseControlArray, System.ComponentModel.IExtenderProvider {
    public OpenFileDialogArray() { }
    public OpenFileDialogArray(System.ComponentModel.IContainer Container) { }
    public System.Windows.Forms.OpenFileDialog this[short Index] { get { return default(System.Windows.Forms.OpenFileDialog); } }
    public event System.ComponentModel.CancelEventHandler FileOk { add { } remove { } }
    public event System.EventHandler HelpRequest { add { } remove { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    bool CanExtend(object target) { return default(bool); }
    protected override System.Type GetControlInstanceType() { return default(System.Type); }
    public short GetIndex(System.Windows.Forms.OpenFileDialog o) { return default(short); }
    protected override void HookUpControlEvents(object o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void ResetIndex(System.Windows.Forms.OpenFileDialog o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void SetIndex(System.Windows.Forms.OpenFileDialog o, short Index) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeIndex(System.Windows.Forms.OpenFileDialog o) { return default(bool); }
  }
  [System.ComponentModel.ProvidePropertyAttribute("Index", typeof(System.Windows.Forms.Panel))]
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class PanelArray : Microsoft.VisualBasic.Compatibility.VB6.BaseControlArray, System.ComponentModel.IExtenderProvider {
    public PanelArray() { }
    public PanelArray(System.ComponentModel.IContainer Container) { }
    public System.Windows.Forms.Panel this[short Index] { get { return default(System.Windows.Forms.Panel); } }
    public event System.EventHandler AutoSizeChanged { add { } remove { } }
    public event System.EventHandler BackColorChanged { add { } remove { } }
    public event System.EventHandler BackgroundImageChanged { add { } remove { } }
    public event System.EventHandler BackgroundImageLayoutChanged { add { } remove { } }
    public event System.EventHandler BindingContextChanged { add { } remove { } }
    public event System.EventHandler CausesValidationChanged { add { } remove { } }
    public event System.Windows.Forms.UICuesEventHandler ChangeUICues { add { } remove { } }
    public event System.EventHandler Click { add { } remove { } }
    public event System.EventHandler ClientSizeChanged { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public event System.EventHandler ContextMenuChanged { add { } remove { } }
    public event System.EventHandler ContextMenuStripChanged { add { } remove { } }
    public event System.Windows.Forms.ControlEventHandler ControlAdded { add { } remove { } }
    public event System.Windows.Forms.ControlEventHandler ControlRemoved { add { } remove { } }
    public event System.EventHandler CursorChanged { add { } remove { } }
    public event System.EventHandler DockChanged { add { } remove { } }
    public event System.EventHandler DoubleClick { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragDrop { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragEnter { add { } remove { } }
    public event System.EventHandler DragLeave { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragOver { add { } remove { } }
    public event System.EventHandler EnabledChanged { add { } remove { } }
    public event System.EventHandler Enter { add { } remove { } }
    public event System.EventHandler FontChanged { add { } remove { } }
    public event System.EventHandler ForeColorChanged { add { } remove { } }
    public event System.Windows.Forms.GiveFeedbackEventHandler GiveFeedback { add { } remove { } }
    public event System.Windows.Forms.HelpEventHandler HelpRequested { add { } remove { } }
    public event System.EventHandler ImeModeChanged { add { } remove { } }
    public event System.Windows.Forms.LayoutEventHandler Layout { add { } remove { } }
    public event System.EventHandler Leave { add { } remove { } }
    public event System.EventHandler LocationChanged { add { } remove { } }
    public event System.EventHandler MarginChanged { add { } remove { } }
    public event System.EventHandler MouseCaptureChanged { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseClick { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseDoubleClick { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseDown { add { } remove { } }
    public event System.EventHandler MouseEnter { add { } remove { } }
    public event System.EventHandler MouseHover { add { } remove { } }
    public event System.EventHandler MouseLeave { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseMove { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseUp { add { } remove { } }
    public event System.EventHandler Move { add { } remove { } }
    public event System.EventHandler PaddingChanged { add { } remove { } }
    public event System.Windows.Forms.PaintEventHandler Paint { add { } remove { } }
    public event System.EventHandler ParentChanged { add { } remove { } }
    public event System.Windows.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp { add { } remove { } }
    public event System.Windows.Forms.QueryContinueDragEventHandler QueryContinueDrag { add { } remove { } }
    public event System.EventHandler RegionChanged { add { } remove { } }
    public event System.EventHandler Resize { add { } remove { } }
    public event System.EventHandler RightToLeftChanged { add { } remove { } }
    public event System.Windows.Forms.ScrollEventHandler Scroll { add { } remove { } }
    public event System.EventHandler SizeChanged { add { } remove { } }
    public event System.EventHandler StyleChanged { add { } remove { } }
    public event System.EventHandler SystemColorsChanged { add { } remove { } }
    public event System.EventHandler TabIndexChanged { add { } remove { } }
    public event System.EventHandler TabStopChanged { add { } remove { } }
    public event System.EventHandler Validated { add { } remove { } }
    public event System.ComponentModel.CancelEventHandler Validating { add { } remove { } }
    public event System.EventHandler VisibleChanged { add { } remove { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    bool CanExtend(object target) { return default(bool); }
    protected override System.Type GetControlInstanceType() { return default(System.Type); }
    public short GetIndex(System.Windows.Forms.Panel o) { return default(short); }
    protected override void HookUpControlEvents(object o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void ResetIndex(System.Windows.Forms.Panel o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void SetIndex(System.Windows.Forms.Panel o, short Index) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeIndex(System.Windows.Forms.Panel o) { return default(bool); }
  }
  [System.ComponentModel.ProvidePropertyAttribute("Index", typeof(System.Windows.Forms.PictureBox))]
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class PictureBoxArray : Microsoft.VisualBasic.Compatibility.VB6.BaseControlArray, System.ComponentModel.IExtenderProvider {
    public PictureBoxArray() { }
    public PictureBoxArray(System.ComponentModel.IContainer Container) { }
    public System.Windows.Forms.PictureBox this[short Index] { get { return default(System.Windows.Forms.PictureBox); } }
    public event System.EventHandler BackColorChanged { add { } remove { } }
    public event System.EventHandler BackgroundImageChanged { add { } remove { } }
    public event System.EventHandler BackgroundImageLayoutChanged { add { } remove { } }
    public event System.EventHandler BindingContextChanged { add { } remove { } }
    public event System.Windows.Forms.UICuesEventHandler ChangeUICues { add { } remove { } }
    public event System.EventHandler Click { add { } remove { } }
    public event System.EventHandler ClientSizeChanged { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public event System.EventHandler ContextMenuChanged { add { } remove { } }
    public event System.EventHandler ContextMenuStripChanged { add { } remove { } }
    public event System.Windows.Forms.ControlEventHandler ControlAdded { add { } remove { } }
    public event System.Windows.Forms.ControlEventHandler ControlRemoved { add { } remove { } }
    public event System.EventHandler CursorChanged { add { } remove { } }
    public event System.EventHandler DockChanged { add { } remove { } }
    public event System.EventHandler DoubleClick { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragDrop { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragEnter { add { } remove { } }
    public event System.EventHandler DragLeave { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragOver { add { } remove { } }
    public event System.EventHandler EnabledChanged { add { } remove { } }
    public event System.Windows.Forms.GiveFeedbackEventHandler GiveFeedback { add { } remove { } }
    public event System.Windows.Forms.HelpEventHandler HelpRequested { add { } remove { } }
    public event System.Windows.Forms.LayoutEventHandler Layout { add { } remove { } }
    public event System.ComponentModel.AsyncCompletedEventHandler LoadCompleted { add { } remove { } }
    public event System.ComponentModel.ProgressChangedEventHandler LoadProgressChanged { add { } remove { } }
    public event System.EventHandler LocationChanged { add { } remove { } }
    public event System.EventHandler MarginChanged { add { } remove { } }
    public event System.EventHandler MouseCaptureChanged { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseClick { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseDoubleClick { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseDown { add { } remove { } }
    public event System.EventHandler MouseEnter { add { } remove { } }
    public event System.EventHandler MouseHover { add { } remove { } }
    public event System.EventHandler MouseLeave { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseMove { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseUp { add { } remove { } }
    public event System.EventHandler Move { add { } remove { } }
    public event System.EventHandler PaddingChanged { add { } remove { } }
    public event System.Windows.Forms.PaintEventHandler Paint { add { } remove { } }
    public event System.EventHandler ParentChanged { add { } remove { } }
    public event System.Windows.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp { add { } remove { } }
    public event System.Windows.Forms.QueryContinueDragEventHandler QueryContinueDrag { add { } remove { } }
    public event System.EventHandler RegionChanged { add { } remove { } }
    public event System.EventHandler Resize { add { } remove { } }
    public event System.EventHandler SizeChanged { add { } remove { } }
    public event System.EventHandler SizeModeChanged { add { } remove { } }
    public event System.EventHandler StyleChanged { add { } remove { } }
    public event System.EventHandler SystemColorsChanged { add { } remove { } }
    public event System.EventHandler Validated { add { } remove { } }
    public event System.ComponentModel.CancelEventHandler Validating { add { } remove { } }
    public event System.EventHandler VisibleChanged { add { } remove { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    bool CanExtend(object target) { return default(bool); }
    protected override System.Type GetControlInstanceType() { return default(System.Type); }
    public short GetIndex(System.Windows.Forms.PictureBox o) { return default(short); }
    protected override void HookUpControlEvents(object o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void ResetIndex(System.Windows.Forms.PictureBox o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void SetIndex(System.Windows.Forms.PictureBox o, short Index) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeIndex(System.Windows.Forms.PictureBox o) { return default(bool); }
  }
  [System.ComponentModel.ProvidePropertyAttribute("Index", typeof(System.Windows.Forms.PrintDialog))]
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class PrintDialogArray : Microsoft.VisualBasic.Compatibility.VB6.BaseControlArray, System.ComponentModel.IExtenderProvider {
    public PrintDialogArray() { }
    public PrintDialogArray(System.ComponentModel.IContainer Container) { }
    public System.Windows.Forms.PrintDialog this[short Index] { get { return default(System.Windows.Forms.PrintDialog); } }
    public event System.EventHandler HelpRequest { add { } remove { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    bool CanExtend(object target) { return default(bool); }
    protected override System.Type GetControlInstanceType() { return default(System.Type); }
    public short GetIndex(System.Windows.Forms.PrintDialog o) { return default(short); }
    protected override void HookUpControlEvents(object o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void ResetIndex(System.Windows.Forms.PrintDialog o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void SetIndex(System.Windows.Forms.PrintDialog o, short Index) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeIndex(System.Windows.Forms.PrintDialog o) { return default(bool); }
  }
  [System.ComponentModel.ProvidePropertyAttribute("Index", typeof(System.Windows.Forms.ProgressBar))]
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class ProgressBarArray : Microsoft.VisualBasic.Compatibility.VB6.BaseControlArray, System.ComponentModel.IExtenderProvider {
    public ProgressBarArray() { }
    public ProgressBarArray(System.ComponentModel.IContainer Container) { }
    public System.Windows.Forms.ProgressBar this[short Index] { get { return default(System.Windows.Forms.ProgressBar); } }
    public event System.EventHandler BackColorChanged { add { } remove { } }
    public event System.EventHandler BindingContextChanged { add { } remove { } }
    public event System.Windows.Forms.UICuesEventHandler ChangeUICues { add { } remove { } }
    public event System.EventHandler Click { add { } remove { } }
    public event System.EventHandler ClientSizeChanged { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public event System.EventHandler ContextMenuChanged { add { } remove { } }
    public event System.EventHandler ContextMenuStripChanged { add { } remove { } }
    public event System.Windows.Forms.ControlEventHandler ControlAdded { add { } remove { } }
    public event System.Windows.Forms.ControlEventHandler ControlRemoved { add { } remove { } }
    public event System.EventHandler CursorChanged { add { } remove { } }
    public event System.EventHandler DockChanged { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragDrop { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragEnter { add { } remove { } }
    public event System.EventHandler DragLeave { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragOver { add { } remove { } }
    public event System.EventHandler EnabledChanged { add { } remove { } }
    public event System.EventHandler ForeColorChanged { add { } remove { } }
    public event System.Windows.Forms.GiveFeedbackEventHandler GiveFeedback { add { } remove { } }
    public event System.Windows.Forms.HelpEventHandler HelpRequested { add { } remove { } }
    public event System.Windows.Forms.LayoutEventHandler Layout { add { } remove { } }
    public event System.EventHandler LocationChanged { add { } remove { } }
    public event System.EventHandler MarginChanged { add { } remove { } }
    public event System.EventHandler MouseCaptureChanged { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseClick { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseDown { add { } remove { } }
    public event System.EventHandler MouseEnter { add { } remove { } }
    public event System.EventHandler MouseHover { add { } remove { } }
    public event System.EventHandler MouseLeave { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseMove { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseUp { add { } remove { } }
    public event System.EventHandler Move { add { } remove { } }
    public event System.EventHandler PaddingChanged { add { } remove { } }
    public event System.EventHandler ParentChanged { add { } remove { } }
    public event System.Windows.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp { add { } remove { } }
    public event System.Windows.Forms.QueryContinueDragEventHandler QueryContinueDrag { add { } remove { } }
    public event System.EventHandler RegionChanged { add { } remove { } }
    public event System.EventHandler Resize { add { } remove { } }
    public event System.EventHandler RightToLeftChanged { add { } remove { } }
    public event System.EventHandler RightToLeftLayoutChanged { add { } remove { } }
    public event System.EventHandler SizeChanged { add { } remove { } }
    public event System.EventHandler StyleChanged { add { } remove { } }
    public event System.EventHandler SystemColorsChanged { add { } remove { } }
    public event System.EventHandler TabIndexChanged { add { } remove { } }
    public event System.EventHandler Validated { add { } remove { } }
    public event System.ComponentModel.CancelEventHandler Validating { add { } remove { } }
    public event System.EventHandler VisibleChanged { add { } remove { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    bool CanExtend(object target) { return default(bool); }
    protected override System.Type GetControlInstanceType() { return default(System.Type); }
    public short GetIndex(System.Windows.Forms.ProgressBar o) { return default(short); }
    protected override void HookUpControlEvents(object o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void ResetIndex(System.Windows.Forms.ProgressBar o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void SetIndex(System.Windows.Forms.ProgressBar o, short Index) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeIndex(System.Windows.Forms.ProgressBar o) { return default(bool); }
  }
  [System.ComponentModel.ProvidePropertyAttribute("Index", typeof(System.Windows.Forms.RadioButton))]
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class RadioButtonArray : Microsoft.VisualBasic.Compatibility.VB6.BaseControlArray, System.ComponentModel.IExtenderProvider {
    public RadioButtonArray() { }
    public RadioButtonArray(System.ComponentModel.IContainer Container) { }
    public System.Windows.Forms.RadioButton this[short Index] { get { return default(System.Windows.Forms.RadioButton); } }
    public event System.EventHandler AppearanceChanged { add { } remove { } }
    public event System.EventHandler AutoSizeChanged { add { } remove { } }
    public event System.EventHandler BackColorChanged { add { } remove { } }
    public event System.EventHandler BackgroundImageChanged { add { } remove { } }
    public event System.EventHandler BackgroundImageLayoutChanged { add { } remove { } }
    public event System.EventHandler BindingContextChanged { add { } remove { } }
    public event System.EventHandler CausesValidationChanged { add { } remove { } }
    public event System.Windows.Forms.UICuesEventHandler ChangeUICues { add { } remove { } }
    public event System.EventHandler CheckedChanged { add { } remove { } }
    public event System.EventHandler Click { add { } remove { } }
    public event System.EventHandler ClientSizeChanged { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public event System.EventHandler ContextMenuChanged { add { } remove { } }
    public event System.EventHandler ContextMenuStripChanged { add { } remove { } }
    public event System.Windows.Forms.ControlEventHandler ControlAdded { add { } remove { } }
    public event System.Windows.Forms.ControlEventHandler ControlRemoved { add { } remove { } }
    public event System.EventHandler CursorChanged { add { } remove { } }
    public event System.EventHandler DockChanged { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragDrop { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragEnter { add { } remove { } }
    public event System.EventHandler DragLeave { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragOver { add { } remove { } }
    public event System.EventHandler EnabledChanged { add { } remove { } }
    public event System.EventHandler Enter { add { } remove { } }
    public event System.EventHandler FontChanged { add { } remove { } }
    public event System.EventHandler ForeColorChanged { add { } remove { } }
    public event System.Windows.Forms.GiveFeedbackEventHandler GiveFeedback { add { } remove { } }
    public event System.Windows.Forms.HelpEventHandler HelpRequested { add { } remove { } }
    public event System.Windows.Forms.KeyEventHandler KeyDown { add { } remove { } }
    public event System.Windows.Forms.KeyPressEventHandler KeyPress { add { } remove { } }
    public event System.Windows.Forms.KeyEventHandler KeyUp { add { } remove { } }
    public event System.Windows.Forms.LayoutEventHandler Layout { add { } remove { } }
    public event System.EventHandler Leave { add { } remove { } }
    public event System.EventHandler LocationChanged { add { } remove { } }
    public event System.EventHandler MarginChanged { add { } remove { } }
    public event System.EventHandler MouseCaptureChanged { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseClick { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseDown { add { } remove { } }
    public event System.EventHandler MouseEnter { add { } remove { } }
    public event System.EventHandler MouseHover { add { } remove { } }
    public event System.EventHandler MouseLeave { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseMove { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseUp { add { } remove { } }
    public event System.EventHandler Move { add { } remove { } }
    public event System.EventHandler PaddingChanged { add { } remove { } }
    public event System.Windows.Forms.PaintEventHandler Paint { add { } remove { } }
    public event System.EventHandler ParentChanged { add { } remove { } }
    public event System.Windows.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp { add { } remove { } }
    public event System.Windows.Forms.QueryContinueDragEventHandler QueryContinueDrag { add { } remove { } }
    public event System.EventHandler RegionChanged { add { } remove { } }
    public event System.EventHandler Resize { add { } remove { } }
    public event System.EventHandler RightToLeftChanged { add { } remove { } }
    public event System.EventHandler SizeChanged { add { } remove { } }
    public event System.EventHandler StyleChanged { add { } remove { } }
    public event System.EventHandler SystemColorsChanged { add { } remove { } }
    public event System.EventHandler TabIndexChanged { add { } remove { } }
    public event System.EventHandler TabStopChanged { add { } remove { } }
    public event System.EventHandler TextChanged { add { } remove { } }
    public event System.EventHandler Validated { add { } remove { } }
    public event System.ComponentModel.CancelEventHandler Validating { add { } remove { } }
    public event System.EventHandler VisibleChanged { add { } remove { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    bool CanExtend(object target) { return default(bool); }
    protected override System.Type GetControlInstanceType() { return default(System.Type); }
    public short GetIndex(System.Windows.Forms.RadioButton o) { return default(short); }
    protected override void HookUpControlEvents(object o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void ResetIndex(System.Windows.Forms.RadioButton o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void SetIndex(System.Windows.Forms.RadioButton o, short Index) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeIndex(System.Windows.Forms.RadioButton o) { return default(bool); }
  }
  [System.ComponentModel.ProvidePropertyAttribute("Index", typeof(System.Windows.Forms.RichTextBox))]
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class RichTextBoxArray : Microsoft.VisualBasic.Compatibility.VB6.BaseControlArray, System.ComponentModel.IExtenderProvider {
    public RichTextBoxArray() { }
    public RichTextBoxArray(System.ComponentModel.IContainer Container) { }
    public System.Windows.Forms.RichTextBox this[short Index] { get { return default(System.Windows.Forms.RichTextBox); } }
    public event System.EventHandler AcceptsTabChanged { add { } remove { } }
    public event System.EventHandler BackColorChanged { add { } remove { } }
    public event System.EventHandler BindingContextChanged { add { } remove { } }
    public event System.EventHandler BorderStyleChanged { add { } remove { } }
    public event System.EventHandler CausesValidationChanged { add { } remove { } }
    public event System.Windows.Forms.UICuesEventHandler ChangeUICues { add { } remove { } }
    public event System.EventHandler Click { add { } remove { } }
    public event System.EventHandler ClientSizeChanged { add { } remove { } }
    public event System.Windows.Forms.ContentsResizedEventHandler ContentsResized { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public event System.EventHandler ContextMenuChanged { add { } remove { } }
    public event System.EventHandler ContextMenuStripChanged { add { } remove { } }
    public event System.Windows.Forms.ControlEventHandler ControlAdded { add { } remove { } }
    public event System.Windows.Forms.ControlEventHandler ControlRemoved { add { } remove { } }
    public event System.EventHandler CursorChanged { add { } remove { } }
    public event System.EventHandler DockChanged { add { } remove { } }
    public event System.EventHandler DoubleClick { add { } remove { } }
    public event System.EventHandler EnabledChanged { add { } remove { } }
    public event System.EventHandler Enter { add { } remove { } }
    public event System.EventHandler FontChanged { add { } remove { } }
    public event System.EventHandler ForeColorChanged { add { } remove { } }
    public event System.Windows.Forms.HelpEventHandler HelpRequested { add { } remove { } }
    public event System.EventHandler HideSelectionChanged { add { } remove { } }
    public event System.EventHandler HScroll { add { } remove { } }
    public event System.EventHandler ImeChange { add { } remove { } }
    public event System.EventHandler ImeModeChanged { add { } remove { } }
    public event System.Windows.Forms.KeyEventHandler KeyDown { add { } remove { } }
    public event System.Windows.Forms.KeyPressEventHandler KeyPress { add { } remove { } }
    public event System.Windows.Forms.KeyEventHandler KeyUp { add { } remove { } }
    public event System.Windows.Forms.LayoutEventHandler Layout { add { } remove { } }
    public event System.EventHandler Leave { add { } remove { } }
    public event System.Windows.Forms.LinkClickedEventHandler LinkClicked { add { } remove { } }
    public event System.EventHandler LocationChanged { add { } remove { } }
    public event System.EventHandler MarginChanged { add { } remove { } }
    public event System.EventHandler ModifiedChanged { add { } remove { } }
    public event System.EventHandler MouseCaptureChanged { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseClick { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseDoubleClick { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseDown { add { } remove { } }
    public event System.EventHandler MouseEnter { add { } remove { } }
    public event System.EventHandler MouseHover { add { } remove { } }
    public event System.EventHandler MouseLeave { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseMove { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseUp { add { } remove { } }
    public event System.EventHandler Move { add { } remove { } }
    public event System.EventHandler MultilineChanged { add { } remove { } }
    public event System.EventHandler ParentChanged { add { } remove { } }
    public event System.EventHandler Protected { add { } remove { } }
    public event System.Windows.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp { add { } remove { } }
    public event System.EventHandler ReadOnlyChanged { add { } remove { } }
    public event System.EventHandler RegionChanged { add { } remove { } }
    public event System.EventHandler Resize { add { } remove { } }
    public event System.EventHandler RightToLeftChanged { add { } remove { } }
    public event System.EventHandler SelectionChanged { add { } remove { } }
    public event System.EventHandler SizeChanged { add { } remove { } }
    public event System.EventHandler StyleChanged { add { } remove { } }
    public event System.EventHandler SystemColorsChanged { add { } remove { } }
    public event System.EventHandler TabIndexChanged { add { } remove { } }
    public event System.EventHandler TabStopChanged { add { } remove { } }
    public event System.EventHandler TextChanged { add { } remove { } }
    public event System.EventHandler Validated { add { } remove { } }
    public event System.ComponentModel.CancelEventHandler Validating { add { } remove { } }
    public event System.EventHandler VisibleChanged { add { } remove { } }
    public event System.EventHandler VScroll { add { } remove { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    bool CanExtend(object target) { return default(bool); }
    protected override System.Type GetControlInstanceType() { return default(System.Type); }
    public short GetIndex(System.Windows.Forms.RichTextBox o) { return default(short); }
    protected override void HookUpControlEvents(object o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void ResetIndex(System.Windows.Forms.RichTextBox o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void SetIndex(System.Windows.Forms.RichTextBox o, short Index) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeIndex(System.Windows.Forms.RichTextBox o) { return default(bool); }
  }
  [System.ComponentModel.ProvidePropertyAttribute("Index", typeof(System.Windows.Forms.SaveFileDialog))]
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class SaveFileDialogArray : Microsoft.VisualBasic.Compatibility.VB6.BaseControlArray, System.ComponentModel.IExtenderProvider {
    public SaveFileDialogArray() { }
    public SaveFileDialogArray(System.ComponentModel.IContainer Container) { }
    public System.Windows.Forms.SaveFileDialog this[short Index] { get { return default(System.Windows.Forms.SaveFileDialog); } }
    public event System.ComponentModel.CancelEventHandler FileOk { add { } remove { } }
    public event System.EventHandler HelpRequest { add { } remove { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    bool CanExtend(object target) { return default(bool); }
    protected override System.Type GetControlInstanceType() { return default(System.Type); }
    public short GetIndex(System.Windows.Forms.SaveFileDialog o) { return default(short); }
    protected override void HookUpControlEvents(object o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void ResetIndex(System.Windows.Forms.SaveFileDialog o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void SetIndex(System.Windows.Forms.SaveFileDialog o, short Index) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeIndex(System.Windows.Forms.SaveFileDialog o) { return default(bool); }
  }
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public enum ScaleMode {
    Centimeters = 7,
    Characters = 4,
    Himetric = 8,
    Inches = 5,
    Millimeters = 6,
    Points = 2,
  }
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public enum ShiftConstants {
    AltMask = 4,
    CtrlMask = 2,
    ShiftMask = 1,
  }
  [System.ComponentModel.ProvidePropertyAttribute("Index", typeof(System.Windows.Forms.StatusBar))]
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class StatusBarArray : Microsoft.VisualBasic.Compatibility.VB6.BaseControlArray, System.ComponentModel.IExtenderProvider {
    public StatusBarArray() { }
    public StatusBarArray(System.ComponentModel.IContainer Container) { }
    public System.Windows.Forms.StatusBar this[short Index] { get { return default(System.Windows.Forms.StatusBar); } }
    public event System.EventHandler BindingContextChanged { add { } remove { } }
    public event System.EventHandler CausesValidationChanged { add { } remove { } }
    public event System.Windows.Forms.UICuesEventHandler ChangeUICues { add { } remove { } }
    public event System.EventHandler Click { add { } remove { } }
    public event System.EventHandler ClientSizeChanged { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public event System.EventHandler ContextMenuChanged { add { } remove { } }
    public event System.EventHandler ContextMenuStripChanged { add { } remove { } }
    public event System.Windows.Forms.ControlEventHandler ControlAdded { add { } remove { } }
    public event System.Windows.Forms.ControlEventHandler ControlRemoved { add { } remove { } }
    public event System.EventHandler CursorChanged { add { } remove { } }
    public event System.EventHandler DockChanged { add { } remove { } }
    public event System.EventHandler DoubleClick { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragDrop { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragEnter { add { } remove { } }
    public event System.EventHandler DragLeave { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragOver { add { } remove { } }
    public event System.Windows.Forms.StatusBarDrawItemEventHandler DrawItem { add { } remove { } }
    public event System.EventHandler EnabledChanged { add { } remove { } }
    public event System.EventHandler Enter { add { } remove { } }
    public event System.EventHandler FontChanged { add { } remove { } }
    public event System.Windows.Forms.GiveFeedbackEventHandler GiveFeedback { add { } remove { } }
    public event System.Windows.Forms.HelpEventHandler HelpRequested { add { } remove { } }
    public event System.Windows.Forms.KeyEventHandler KeyDown { add { } remove { } }
    public event System.Windows.Forms.KeyPressEventHandler KeyPress { add { } remove { } }
    public event System.Windows.Forms.KeyEventHandler KeyUp { add { } remove { } }
    public event System.Windows.Forms.LayoutEventHandler Layout { add { } remove { } }
    public event System.EventHandler Leave { add { } remove { } }
    public event System.EventHandler LocationChanged { add { } remove { } }
    public event System.EventHandler MarginChanged { add { } remove { } }
    public event System.EventHandler MouseCaptureChanged { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseClick { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseDoubleClick { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseDown { add { } remove { } }
    public event System.EventHandler MouseEnter { add { } remove { } }
    public event System.EventHandler MouseHover { add { } remove { } }
    public event System.EventHandler MouseLeave { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseMove { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseUp { add { } remove { } }
    public event System.EventHandler Move { add { } remove { } }
    public event System.EventHandler PaddingChanged { add { } remove { } }
    public event System.Windows.Forms.StatusBarPanelClickEventHandler PanelClick { add { } remove { } }
    public event System.EventHandler ParentChanged { add { } remove { } }
    public event System.Windows.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp { add { } remove { } }
    public event System.Windows.Forms.QueryContinueDragEventHandler QueryContinueDrag { add { } remove { } }
    public event System.EventHandler RegionChanged { add { } remove { } }
    public event System.EventHandler Resize { add { } remove { } }
    public event System.EventHandler RightToLeftChanged { add { } remove { } }
    public event System.EventHandler SizeChanged { add { } remove { } }
    public event System.EventHandler StyleChanged { add { } remove { } }
    public event System.EventHandler SystemColorsChanged { add { } remove { } }
    public event System.EventHandler TabIndexChanged { add { } remove { } }
    public event System.EventHandler TabStopChanged { add { } remove { } }
    public event System.EventHandler TextChanged { add { } remove { } }
    public event System.EventHandler Validated { add { } remove { } }
    public event System.ComponentModel.CancelEventHandler Validating { add { } remove { } }
    public event System.EventHandler VisibleChanged { add { } remove { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    bool CanExtend(object target) { return default(bool); }
    protected override System.Type GetControlInstanceType() { return default(System.Type); }
    public short GetIndex(System.Windows.Forms.StatusBar o) { return default(short); }
    protected override void HookUpControlEvents(object o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void ResetIndex(System.Windows.Forms.StatusBar o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void SetIndex(System.Windows.Forms.StatusBar o, short Index) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeIndex(System.Windows.Forms.StatusBar o) { return default(bool); }
  }
  [System.ComponentModel.ProvidePropertyAttribute("Index", typeof(System.Windows.Forms.StatusStrip))]
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class StatusStripArray : Microsoft.VisualBasic.Compatibility.VB6.BaseControlArray, System.ComponentModel.IExtenderProvider {
    public StatusStripArray() { }
    public StatusStripArray(System.ComponentModel.IContainer Container) { }
    public System.Windows.Forms.StatusStrip this[short Index] { get { return default(System.Windows.Forms.StatusStrip); } }
    public event System.EventHandler AutoSizeChanged { add { } remove { } }
    public event System.EventHandler BackColorChanged { add { } remove { } }
    public event System.EventHandler BackgroundImageChanged { add { } remove { } }
    public event System.EventHandler BackgroundImageLayoutChanged { add { } remove { } }
    public event System.EventHandler BeginDrag { add { } remove { } }
    public event System.EventHandler BindingContextChanged { add { } remove { } }
    public event System.Windows.Forms.UICuesEventHandler ChangeUICues { add { } remove { } }
    public event System.EventHandler Click { add { } remove { } }
    public event System.EventHandler ClientSizeChanged { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public event System.EventHandler ContextMenuChanged { add { } remove { } }
    public event System.EventHandler ContextMenuStripChanged { add { } remove { } }
    public event System.EventHandler DockChanged { add { } remove { } }
    public event System.EventHandler DoubleClick { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragDrop { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragEnter { add { } remove { } }
    public event System.EventHandler DragLeave { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragOver { add { } remove { } }
    public event System.EventHandler EnabledChanged { add { } remove { } }
    public event System.EventHandler EndDrag { add { } remove { } }
    public event System.EventHandler Enter { add { } remove { } }
    public event System.EventHandler FontChanged { add { } remove { } }
    public event System.Windows.Forms.GiveFeedbackEventHandler GiveFeedback { add { } remove { } }
    public event System.Windows.Forms.HelpEventHandler HelpRequested { add { } remove { } }
    public event System.EventHandler ImeModeChanged { add { } remove { } }
    public event System.Windows.Forms.ToolStripItemEventHandler ItemAdded { add { } remove { } }
    public event System.Windows.Forms.ToolStripItemClickedEventHandler ItemClicked { add { } remove { } }
    public event System.Windows.Forms.ToolStripItemEventHandler ItemRemoved { add { } remove { } }
    public event System.Windows.Forms.KeyEventHandler KeyDown { add { } remove { } }
    public event System.Windows.Forms.KeyPressEventHandler KeyPress { add { } remove { } }
    public event System.Windows.Forms.KeyEventHandler KeyUp { add { } remove { } }
    public event System.Windows.Forms.LayoutEventHandler Layout { add { } remove { } }
    public event System.EventHandler LayoutCompleted { add { } remove { } }
    public event System.EventHandler LayoutStyleChanged { add { } remove { } }
    public event System.EventHandler Leave { add { } remove { } }
    public event System.EventHandler LocationChanged { add { } remove { } }
    public event System.EventHandler MarginChanged { add { } remove { } }
    public event System.EventHandler MouseCaptureChanged { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseClick { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseDoubleClick { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseDown { add { } remove { } }
    public event System.EventHandler MouseEnter { add { } remove { } }
    public event System.EventHandler MouseHover { add { } remove { } }
    public event System.EventHandler MouseLeave { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseMove { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseUp { add { } remove { } }
    public event System.EventHandler Move { add { } remove { } }
    public event System.Windows.Forms.PaintEventHandler Paint { add { } remove { } }
    public event System.Windows.Forms.PaintEventHandler PaintGrip { add { } remove { } }
    public event System.EventHandler ParentChanged { add { } remove { } }
    public event System.Windows.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp { add { } remove { } }
    public event System.Windows.Forms.QueryContinueDragEventHandler QueryContinueDrag { add { } remove { } }
    public event System.EventHandler RegionChanged { add { } remove { } }
    public event System.EventHandler Resize { add { } remove { } }
    public event System.EventHandler RightToLeftChanged { add { } remove { } }
    public event System.Windows.Forms.ScrollEventHandler Scroll { add { } remove { } }
    public event System.EventHandler SizeChanged { add { } remove { } }
    public event System.EventHandler StyleChanged { add { } remove { } }
    public event System.EventHandler SystemColorsChanged { add { } remove { } }
    public event System.EventHandler TabIndexChanged { add { } remove { } }
    public event System.EventHandler TabStopChanged { add { } remove { } }
    public event System.EventHandler TextChanged { add { } remove { } }
    public event System.EventHandler Validated { add { } remove { } }
    public event System.ComponentModel.CancelEventHandler Validating { add { } remove { } }
    public event System.EventHandler VisibleChanged { add { } remove { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    bool CanExtend(object target) { return default(bool); }
    protected override System.Type GetControlInstanceType() { return default(System.Type); }
    public short GetIndex(System.Windows.Forms.StatusStrip o) { return default(short); }
    protected override void HookUpControlEvents(object o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void ResetIndex(System.Windows.Forms.StatusStrip o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void SetIndex(System.Windows.Forms.StatusStrip o, short Index) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeIndex(System.Windows.Forms.StatusStrip o) { return default(bool); }
  }
  [Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute]
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public sealed partial class Support {
    internal Support() { }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static System.Array CopyArray(System.Array SourceArray) { return default(System.Array); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static object CursorToIPicture(System.Windows.Forms.Cursor curs) { return default(object); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static bool Eqv(bool a, bool b) { return default(bool); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static byte Eqv(byte a, byte b) { return default(byte); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static short Eqv(short a, short b) { return default(short); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static int Eqv(int a, int b) { return default(int); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static long Eqv(long a, long b) { return default(long); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static object Eqv(object a, object b) { return default(object); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static System.Drawing.Font FontChangeBold(System.Drawing.Font CurrentFont, bool Bold) { return default(System.Drawing.Font); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static System.Drawing.Font FontChangeGdiCharSet(System.Drawing.Font CurrentFont, byte GdiCharSet) { return default(System.Drawing.Font); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static System.Drawing.Font FontChangeItalic(System.Drawing.Font CurrentFont, bool Italic) { return default(System.Drawing.Font); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static System.Drawing.Font FontChangeName(System.Drawing.Font CurrentFont, string Name) { return default(System.Drawing.Font); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static System.Drawing.Font FontChangeSize(System.Drawing.Font CurrentFont, float Size) { return default(System.Drawing.Font); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static System.Drawing.Font FontChangeStrikeout(System.Drawing.Font CurrentFont, bool Strikeout) { return default(System.Drawing.Font); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static System.Drawing.Font FontChangeUnderline(System.Drawing.Font CurrentFont, bool Underline) { return default(System.Drawing.Font); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static object FontToIFont(System.Drawing.Font fnt) { return default(object); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static string Format(object Expression, string Style="", Microsoft.VisualBasic.FirstDayOfWeek DayOfWeek=(Microsoft.VisualBasic.FirstDayOfWeek)(1), Microsoft.VisualBasic.FirstWeekOfYear WeekOfYear=(Microsoft.VisualBasic.FirstWeekOfYear)(1)) { return default(string); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static double FromPixelsUserHeight(double Height, double ScaleHeight, int OriginalHeightInPixels) { return default(double); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static double FromPixelsUserWidth(double Width, double ScaleWidth, int OriginalWidthInPixels) { return default(double); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static double FromPixelsUserX(double X, double ScaleLeft, double ScaleWidth, int OriginalWidthInPixels) { return default(double); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static double FromPixelsUserY(double Y, double ScaleTop, double ScaleHeight, int OriginalHeightInPixels) { return default(double); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static double FromPixelsX(double X, Microsoft.VisualBasic.Compatibility.VB6.ScaleMode ToScale) { return default(double); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static double FromPixelsY(double Y, Microsoft.VisualBasic.Compatibility.VB6.ScaleMode ToScale) { return default(double); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static System.Windows.Forms.Control GetActiveControl() { return default(System.Windows.Forms.Control); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static bool GetCancel(System.Windows.Forms.Button btn) { return default(bool); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static bool GetDefault(System.Windows.Forms.Button btn) { return default(bool); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static string GetEXEName() { return default(string); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static System.IntPtr GetHInstance() { return default(System.IntPtr); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static int GetItemData(System.Windows.Forms.Control Control, int Index) { return default(int); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static string GetItemString(System.Windows.Forms.Control Control, int Index) { return default(string); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static string GetPath() { return default(string); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static object IconToIPicture(System.Drawing.Icon ico) { return default(object); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static System.Drawing.Font IFontToFont(object objFnt) { return default(System.Drawing.Font); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static object ImageToIPicture(System.Drawing.Image img) { return default(object); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static object ImageToIPictureDisp(System.Drawing.Image img) { return default(object); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static bool Imp(bool a, bool b) { return default(bool); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static byte Imp(byte a, byte b) { return default(byte); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static short Imp(short a, short b) { return default(short); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static int Imp(int a, int b) { return default(int); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static long Imp(long a, long b) { return default(long); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static object Imp(object a, object b) { return default(object); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static System.Drawing.Image IPictureDispToImage(object pict) { return default(System.Drawing.Image); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static System.Drawing.Image IPictureToImage(object pict) { return default(System.Drawing.Image); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static object LoadResData(object ID, object restype) { return default(object); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static object LoadResData(object ID, object restype, System.Globalization.CultureInfo Culture) { return default(object); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static object LoadResPicture(object ID, Microsoft.VisualBasic.Compatibility.VB6.LoadResConstants restype) { return default(object); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static object LoadResPicture(object ID, Microsoft.VisualBasic.Compatibility.VB6.LoadResConstants restype, System.Globalization.CultureInfo Culture) { return default(object); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static string LoadResString(int ID) { return default(string); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static string LoadResString(int ID, System.Globalization.CultureInfo Culture) { return default(string); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static double PixelsToTwipsX(double X) { return default(double); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static double PixelsToTwipsY(double Y) { return default(double); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static void SendKeys(string Keys, bool Wait=false) { }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static void SetCancel(System.Windows.Forms.Button btn, bool Cancel) { }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static void SetDefault(System.Windows.Forms.Button btn, bool Default) { }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static void SetItemData(System.Windows.Forms.Control Control, int Index, int ItemData) { }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static void SetItemString(System.Windows.Forms.Control Control, int Index, string ItemString) { }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static void SetResourceBaseName(string BaseFileName) { }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static void SetResourceBaseName(string ProjectNamespace, string BaseFileName) { }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static void ShowForm(System.Windows.Forms.Form Form, int Modal=0, System.Windows.Forms.Form OwnerForm=null) { }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static string TabLayout(params System.Object[] Args) { return default(string); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static double ToPixelsUserHeight(double Height, double ScaleHeight, int OriginalHeightInPixels) { return default(double); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static double ToPixelsUserWidth(double Width, double ScaleWidth, int OriginalWidthInPixels) { return default(double); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static double ToPixelsUserX(double X, double ScaleLeft, double ScaleWidth, int OriginalWidthInPixels) { return default(double); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static double ToPixelsUserY(double Y, double ScaleTop, double ScaleHeight, int OriginalHeightInPixels) { return default(double); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static double ToPixelsX(double X, Microsoft.VisualBasic.Compatibility.VB6.ScaleMode FromScale) { return default(double); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static double ToPixelsY(double Y, Microsoft.VisualBasic.Compatibility.VB6.ScaleMode FromScale) { return default(double); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static float TwipsPerPixelX() { return default(float); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static float TwipsPerPixelY() { return default(float); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static double TwipsToPixelsX(double X) { return default(double); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static double TwipsToPixelsY(double Y) { return default(double); }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static void ValidateControls(System.Windows.Forms.ContainerControl Form) { }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static void WhatsThisMode(System.Windows.Forms.Form Form) { }
    [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
    public static void ZOrder(System.Windows.Forms.Control Control, int Position) { }
  }
  [System.ComponentModel.ProvidePropertyAttribute("Index", typeof(System.Windows.Forms.TabControl))]
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class TabControlArray : Microsoft.VisualBasic.Compatibility.VB6.BaseControlArray, System.ComponentModel.IExtenderProvider {
    public TabControlArray() { }
    public TabControlArray(System.ComponentModel.IContainer Container) { }
    public System.Windows.Forms.TabControl this[short Index] { get { return default(System.Windows.Forms.TabControl); } }
    public event System.EventHandler BindingContextChanged { add { } remove { } }
    public event System.EventHandler CausesValidationChanged { add { } remove { } }
    public event System.Windows.Forms.UICuesEventHandler ChangeUICues { add { } remove { } }
    public event System.EventHandler Click { add { } remove { } }
    public event System.EventHandler ClientSizeChanged { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public event System.EventHandler ContextMenuChanged { add { } remove { } }
    public event System.EventHandler ContextMenuStripChanged { add { } remove { } }
    public event System.Windows.Forms.ControlEventHandler ControlAdded { add { } remove { } }
    public event System.Windows.Forms.ControlEventHandler ControlRemoved { add { } remove { } }
    public event System.EventHandler CursorChanged { add { } remove { } }
    public event System.Windows.Forms.TabControlEventHandler Deselected { add { } remove { } }
    public event System.Windows.Forms.TabControlCancelEventHandler Deselecting { add { } remove { } }
    public event System.EventHandler DockChanged { add { } remove { } }
    public event System.EventHandler DoubleClick { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragDrop { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragEnter { add { } remove { } }
    public event System.EventHandler DragLeave { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragOver { add { } remove { } }
    public event System.Windows.Forms.DrawItemEventHandler DrawItem { add { } remove { } }
    public event System.EventHandler EnabledChanged { add { } remove { } }
    public event System.EventHandler Enter { add { } remove { } }
    public event System.EventHandler FontChanged { add { } remove { } }
    public event System.Windows.Forms.GiveFeedbackEventHandler GiveFeedback { add { } remove { } }
    public event System.Windows.Forms.HelpEventHandler HelpRequested { add { } remove { } }
    public event System.EventHandler ImeModeChanged { add { } remove { } }
    public event System.Windows.Forms.KeyEventHandler KeyDown { add { } remove { } }
    public event System.Windows.Forms.KeyPressEventHandler KeyPress { add { } remove { } }
    public event System.Windows.Forms.KeyEventHandler KeyUp { add { } remove { } }
    public event System.Windows.Forms.LayoutEventHandler Layout { add { } remove { } }
    public event System.EventHandler Leave { add { } remove { } }
    public event System.EventHandler LocationChanged { add { } remove { } }
    public event System.EventHandler MarginChanged { add { } remove { } }
    public event System.EventHandler MouseCaptureChanged { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseClick { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseDoubleClick { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseDown { add { } remove { } }
    public event System.EventHandler MouseEnter { add { } remove { } }
    public event System.EventHandler MouseHover { add { } remove { } }
    public event System.EventHandler MouseLeave { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseMove { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseUp { add { } remove { } }
    public event System.EventHandler Move { add { } remove { } }
    public event System.EventHandler PaddingChanged { add { } remove { } }
    public event System.EventHandler ParentChanged { add { } remove { } }
    public event System.Windows.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp { add { } remove { } }
    public event System.Windows.Forms.QueryContinueDragEventHandler QueryContinueDrag { add { } remove { } }
    public event System.EventHandler RegionChanged { add { } remove { } }
    public event System.EventHandler Resize { add { } remove { } }
    public event System.EventHandler RightToLeftChanged { add { } remove { } }
    public event System.EventHandler RightToLeftLayoutChanged { add { } remove { } }
    public event System.Windows.Forms.TabControlEventHandler Selected { add { } remove { } }
    public event System.EventHandler SelectedIndexChanged { add { } remove { } }
    public event System.Windows.Forms.TabControlCancelEventHandler Selecting { add { } remove { } }
    public event System.EventHandler SizeChanged { add { } remove { } }
    public event System.EventHandler StyleChanged { add { } remove { } }
    public event System.EventHandler SystemColorsChanged { add { } remove { } }
    public event System.EventHandler TabIndexChanged { add { } remove { } }
    public event System.EventHandler TabStopChanged { add { } remove { } }
    public event System.EventHandler Validated { add { } remove { } }
    public event System.ComponentModel.CancelEventHandler Validating { add { } remove { } }
    public event System.EventHandler VisibleChanged { add { } remove { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    bool CanExtend(object target) { return default(bool); }
    protected override System.Type GetControlInstanceType() { return default(System.Type); }
    public short GetIndex(System.Windows.Forms.TabControl o) { return default(short); }
    protected override void HookUpControlEvents(object o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void ResetIndex(System.Windows.Forms.TabControl o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void SetIndex(System.Windows.Forms.TabControl o, short Index) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeIndex(System.Windows.Forms.TabControl o) { return default(bool); }
  }
  [System.ComponentModel.ProvidePropertyAttribute("Index", typeof(System.Windows.Forms.TextBox))]
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class TextBoxArray : Microsoft.VisualBasic.Compatibility.VB6.BaseControlArray, System.ComponentModel.IExtenderProvider {
    public TextBoxArray() { }
    public TextBoxArray(System.ComponentModel.IContainer Container) { }
    public System.Windows.Forms.TextBox this[short Index] { get { return default(System.Windows.Forms.TextBox); } }
    public event System.EventHandler AcceptsTabChanged { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public event System.EventHandler AutoSizeChanged { add { } remove { } }
    public event System.EventHandler BackColorChanged { add { } remove { } }
    public event System.EventHandler BindingContextChanged { add { } remove { } }
    public event System.EventHandler BorderStyleChanged { add { } remove { } }
    public event System.EventHandler CausesValidationChanged { add { } remove { } }
    public event System.Windows.Forms.UICuesEventHandler ChangeUICues { add { } remove { } }
    public event System.EventHandler Click { add { } remove { } }
    public event System.EventHandler ClientSizeChanged { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public event System.EventHandler ContextMenuChanged { add { } remove { } }
    public event System.EventHandler ContextMenuStripChanged { add { } remove { } }
    public event System.Windows.Forms.ControlEventHandler ControlAdded { add { } remove { } }
    public event System.Windows.Forms.ControlEventHandler ControlRemoved { add { } remove { } }
    public event System.EventHandler CursorChanged { add { } remove { } }
    public event System.EventHandler DockChanged { add { } remove { } }
    public event System.EventHandler DoubleClick { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragDrop { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragEnter { add { } remove { } }
    public event System.EventHandler DragLeave { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragOver { add { } remove { } }
    public event System.EventHandler EnabledChanged { add { } remove { } }
    public event System.EventHandler Enter { add { } remove { } }
    public event System.EventHandler FontChanged { add { } remove { } }
    public event System.EventHandler ForeColorChanged { add { } remove { } }
    public event System.Windows.Forms.GiveFeedbackEventHandler GiveFeedback { add { } remove { } }
    public event System.Windows.Forms.HelpEventHandler HelpRequested { add { } remove { } }
    public event System.EventHandler HideSelectionChanged { add { } remove { } }
    public event System.EventHandler ImeModeChanged { add { } remove { } }
    public event System.Windows.Forms.KeyEventHandler KeyDown { add { } remove { } }
    public event System.Windows.Forms.KeyPressEventHandler KeyPress { add { } remove { } }
    public event System.Windows.Forms.KeyEventHandler KeyUp { add { } remove { } }
    public event System.Windows.Forms.LayoutEventHandler Layout { add { } remove { } }
    public event System.EventHandler Leave { add { } remove { } }
    public event System.EventHandler LocationChanged { add { } remove { } }
    public event System.EventHandler MarginChanged { add { } remove { } }
    public event System.EventHandler ModifiedChanged { add { } remove { } }
    public event System.EventHandler MouseCaptureChanged { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseClick { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseDoubleClick { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseDown { add { } remove { } }
    public event System.EventHandler MouseEnter { add { } remove { } }
    public event System.EventHandler MouseHover { add { } remove { } }
    public event System.EventHandler MouseLeave { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseMove { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseUp { add { } remove { } }
    public event System.EventHandler Move { add { } remove { } }
    public event System.EventHandler MultilineChanged { add { } remove { } }
    public event System.EventHandler ParentChanged { add { } remove { } }
    public event System.Windows.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp { add { } remove { } }
    public event System.Windows.Forms.QueryContinueDragEventHandler QueryContinueDrag { add { } remove { } }
    public event System.EventHandler ReadOnlyChanged { add { } remove { } }
    public event System.EventHandler RegionChanged { add { } remove { } }
    public event System.EventHandler Resize { add { } remove { } }
    public event System.EventHandler RightToLeftChanged { add { } remove { } }
    public event System.EventHandler SizeChanged { add { } remove { } }
    public event System.EventHandler StyleChanged { add { } remove { } }
    public event System.EventHandler SystemColorsChanged { add { } remove { } }
    public event System.EventHandler TabIndexChanged { add { } remove { } }
    public event System.EventHandler TabStopChanged { add { } remove { } }
    public event System.EventHandler TextAlignChanged { add { } remove { } }
    public event System.EventHandler TextChanged { add { } remove { } }
    public event System.EventHandler Validated { add { } remove { } }
    public event System.ComponentModel.CancelEventHandler Validating { add { } remove { } }
    public event System.EventHandler VisibleChanged { add { } remove { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    bool CanExtend(object target) { return default(bool); }
    protected override System.Type GetControlInstanceType() { return default(System.Type); }
    public short GetIndex(System.Windows.Forms.TextBox o) { return default(short); }
    protected override void HookUpControlEvents(object o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void ResetIndex(System.Windows.Forms.TextBox o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void SetIndex(System.Windows.Forms.TextBox o, short Index) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeIndex(System.Windows.Forms.TextBox o) { return default(bool); }
  }
  [System.ComponentModel.ProvidePropertyAttribute("Index", typeof(System.Windows.Forms.Timer))]
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class TimerArray : Microsoft.VisualBasic.Compatibility.VB6.BaseControlArray, System.ComponentModel.IExtenderProvider {
    public TimerArray() { }
    public TimerArray(System.ComponentModel.IContainer Container) { }
    public System.Windows.Forms.Timer this[short Index] { get { return default(System.Windows.Forms.Timer); } }
    public event System.EventHandler Tick { add { } remove { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    bool CanExtend(object target) { return default(bool); }
    protected override System.Type GetControlInstanceType() { return default(System.Type); }
    public short GetIndex(System.Windows.Forms.Timer o) { return default(short); }
    protected override void HookUpControlEvents(object o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void ResetIndex(System.Windows.Forms.Timer o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void SetIndex(System.Windows.Forms.Timer o, short Index) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeIndex(System.Windows.Forms.Timer o) { return default(bool); }
  }
  [System.ComponentModel.ProvidePropertyAttribute("Index", typeof(System.Windows.Forms.ToolBar))]
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class ToolBarArray : Microsoft.VisualBasic.Compatibility.VB6.BaseControlArray, System.ComponentModel.IExtenderProvider {
    public ToolBarArray() { }
    public ToolBarArray(System.ComponentModel.IContainer Container) { }
    public System.Windows.Forms.ToolBar this[short Index] { get { return default(System.Windows.Forms.ToolBar); } }
    public event System.EventHandler AutoSizeChanged { add { } remove { } }
    public event System.EventHandler BindingContextChanged { add { } remove { } }
    public event System.Windows.Forms.ToolBarButtonClickEventHandler ButtonClick { add { } remove { } }
    public event System.Windows.Forms.ToolBarButtonClickEventHandler ButtonDropDown { add { } remove { } }
    public event System.EventHandler CausesValidationChanged { add { } remove { } }
    public event System.Windows.Forms.UICuesEventHandler ChangeUICues { add { } remove { } }
    public event System.EventHandler Click { add { } remove { } }
    public event System.EventHandler ClientSizeChanged { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public event System.EventHandler ContextMenuChanged { add { } remove { } }
    public event System.EventHandler ContextMenuStripChanged { add { } remove { } }
    public event System.Windows.Forms.ControlEventHandler ControlAdded { add { } remove { } }
    public event System.Windows.Forms.ControlEventHandler ControlRemoved { add { } remove { } }
    public event System.EventHandler CursorChanged { add { } remove { } }
    public event System.EventHandler DockChanged { add { } remove { } }
    public event System.EventHandler DoubleClick { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragDrop { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragEnter { add { } remove { } }
    public event System.EventHandler DragLeave { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragOver { add { } remove { } }
    public event System.EventHandler EnabledChanged { add { } remove { } }
    public event System.EventHandler Enter { add { } remove { } }
    public event System.EventHandler FontChanged { add { } remove { } }
    public event System.Windows.Forms.GiveFeedbackEventHandler GiveFeedback { add { } remove { } }
    public event System.Windows.Forms.HelpEventHandler HelpRequested { add { } remove { } }
    public event System.Windows.Forms.KeyEventHandler KeyDown { add { } remove { } }
    public event System.Windows.Forms.KeyPressEventHandler KeyPress { add { } remove { } }
    public event System.Windows.Forms.KeyEventHandler KeyUp { add { } remove { } }
    public event System.Windows.Forms.LayoutEventHandler Layout { add { } remove { } }
    public event System.EventHandler Leave { add { } remove { } }
    public event System.EventHandler LocationChanged { add { } remove { } }
    public event System.EventHandler MarginChanged { add { } remove { } }
    public event System.EventHandler MouseCaptureChanged { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseClick { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseDoubleClick { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseDown { add { } remove { } }
    public event System.EventHandler MouseEnter { add { } remove { } }
    public event System.EventHandler MouseHover { add { } remove { } }
    public event System.EventHandler MouseLeave { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseMove { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseUp { add { } remove { } }
    public event System.EventHandler Move { add { } remove { } }
    public event System.EventHandler PaddingChanged { add { } remove { } }
    public event System.EventHandler ParentChanged { add { } remove { } }
    public event System.Windows.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp { add { } remove { } }
    public event System.Windows.Forms.QueryContinueDragEventHandler QueryContinueDrag { add { } remove { } }
    public event System.EventHandler RegionChanged { add { } remove { } }
    public event System.EventHandler Resize { add { } remove { } }
    public event System.EventHandler SizeChanged { add { } remove { } }
    public event System.EventHandler StyleChanged { add { } remove { } }
    public event System.EventHandler SystemColorsChanged { add { } remove { } }
    public event System.EventHandler TabIndexChanged { add { } remove { } }
    public event System.EventHandler TabStopChanged { add { } remove { } }
    public event System.EventHandler Validated { add { } remove { } }
    public event System.ComponentModel.CancelEventHandler Validating { add { } remove { } }
    public event System.EventHandler VisibleChanged { add { } remove { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    bool CanExtend(object target) { return default(bool); }
    protected override System.Type GetControlInstanceType() { return default(System.Type); }
    public short GetIndex(System.Windows.Forms.ToolBar o) { return default(short); }
    protected override void HookUpControlEvents(object o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void ResetIndex(System.Windows.Forms.ToolBar o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void SetIndex(System.Windows.Forms.ToolBar o, short Index) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeIndex(System.Windows.Forms.ToolBar o) { return default(bool); }
  }
  [System.ComponentModel.ProvidePropertyAttribute("Index", typeof(System.Windows.Forms.ToolStrip))]
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class ToolStripArray : Microsoft.VisualBasic.Compatibility.VB6.BaseControlArray, System.ComponentModel.IExtenderProvider {
    public ToolStripArray() { }
    public ToolStripArray(System.ComponentModel.IContainer Container) { }
    public System.Windows.Forms.ToolStrip this[short Index] { get { return default(System.Windows.Forms.ToolStrip); } }
    public event System.EventHandler AutoSizeChanged { add { } remove { } }
    public event System.EventHandler BackColorChanged { add { } remove { } }
    public event System.EventHandler BackgroundImageChanged { add { } remove { } }
    public event System.EventHandler BackgroundImageLayoutChanged { add { } remove { } }
    public event System.EventHandler BeginDrag { add { } remove { } }
    public event System.EventHandler BindingContextChanged { add { } remove { } }
    public event System.Windows.Forms.UICuesEventHandler ChangeUICues { add { } remove { } }
    public event System.EventHandler Click { add { } remove { } }
    public event System.EventHandler ClientSizeChanged { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public event System.EventHandler ContextMenuChanged { add { } remove { } }
    public event System.EventHandler ContextMenuStripChanged { add { } remove { } }
    public event System.EventHandler DockChanged { add { } remove { } }
    public event System.EventHandler DoubleClick { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragDrop { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragEnter { add { } remove { } }
    public event System.EventHandler DragLeave { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragOver { add { } remove { } }
    public event System.EventHandler EnabledChanged { add { } remove { } }
    public event System.EventHandler EndDrag { add { } remove { } }
    public event System.EventHandler Enter { add { } remove { } }
    public event System.EventHandler FontChanged { add { } remove { } }
    public event System.Windows.Forms.GiveFeedbackEventHandler GiveFeedback { add { } remove { } }
    public event System.Windows.Forms.HelpEventHandler HelpRequested { add { } remove { } }
    public event System.EventHandler ImeModeChanged { add { } remove { } }
    public event System.Windows.Forms.ToolStripItemEventHandler ItemAdded { add { } remove { } }
    public event System.Windows.Forms.ToolStripItemClickedEventHandler ItemClicked { add { } remove { } }
    public event System.Windows.Forms.ToolStripItemEventHandler ItemRemoved { add { } remove { } }
    public event System.Windows.Forms.KeyEventHandler KeyDown { add { } remove { } }
    public event System.Windows.Forms.KeyPressEventHandler KeyPress { add { } remove { } }
    public event System.Windows.Forms.KeyEventHandler KeyUp { add { } remove { } }
    public event System.Windows.Forms.LayoutEventHandler Layout { add { } remove { } }
    public event System.EventHandler LayoutCompleted { add { } remove { } }
    public event System.EventHandler LayoutStyleChanged { add { } remove { } }
    public event System.EventHandler Leave { add { } remove { } }
    public event System.EventHandler LocationChanged { add { } remove { } }
    public event System.EventHandler MarginChanged { add { } remove { } }
    public event System.EventHandler MouseCaptureChanged { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseClick { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseDoubleClick { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseDown { add { } remove { } }
    public event System.EventHandler MouseEnter { add { } remove { } }
    public event System.EventHandler MouseHover { add { } remove { } }
    public event System.EventHandler MouseLeave { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseMove { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseUp { add { } remove { } }
    public event System.EventHandler Move { add { } remove { } }
    public event System.EventHandler PaddingChanged { add { } remove { } }
    public event System.Windows.Forms.PaintEventHandler Paint { add { } remove { } }
    public event System.Windows.Forms.PaintEventHandler PaintGrip { add { } remove { } }
    public event System.EventHandler ParentChanged { add { } remove { } }
    public event System.Windows.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp { add { } remove { } }
    public event System.Windows.Forms.QueryContinueDragEventHandler QueryContinueDrag { add { } remove { } }
    public event System.EventHandler RegionChanged { add { } remove { } }
    public event System.EventHandler Resize { add { } remove { } }
    public event System.EventHandler RightToLeftChanged { add { } remove { } }
    public event System.Windows.Forms.ScrollEventHandler Scroll { add { } remove { } }
    public event System.EventHandler SizeChanged { add { } remove { } }
    public event System.EventHandler StyleChanged { add { } remove { } }
    public event System.EventHandler SystemColorsChanged { add { } remove { } }
    public event System.EventHandler TabIndexChanged { add { } remove { } }
    public event System.EventHandler TabStopChanged { add { } remove { } }
    public event System.EventHandler TextChanged { add { } remove { } }
    public event System.EventHandler Validated { add { } remove { } }
    public event System.ComponentModel.CancelEventHandler Validating { add { } remove { } }
    public event System.EventHandler VisibleChanged { add { } remove { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    bool CanExtend(object target) { return default(bool); }
    protected override System.Type GetControlInstanceType() { return default(System.Type); }
    public short GetIndex(System.Windows.Forms.ToolStrip o) { return default(short); }
    protected override void HookUpControlEvents(object o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void ResetIndex(System.Windows.Forms.ToolStrip o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void SetIndex(System.Windows.Forms.ToolStrip o, short Index) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeIndex(System.Windows.Forms.ToolStrip o) { return default(bool); }
  }
  [System.ComponentModel.ProvidePropertyAttribute("Index", typeof(System.Windows.Forms.ToolStripMenuItem))]
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class ToolStripMenuItemArray : Microsoft.VisualBasic.Compatibility.VB6.BaseControlArray, System.ComponentModel.IExtenderProvider {
    public ToolStripMenuItemArray() { }
    public ToolStripMenuItemArray(System.ComponentModel.IContainer Container) { }
    public System.Windows.Forms.ToolStripMenuItem this[short Index] { get { return default(System.Windows.Forms.ToolStripMenuItem); } }
    public event System.EventHandler BackColorChanged { add { } remove { } }
    public event System.EventHandler CheckedChanged { add { } remove { } }
    public event System.EventHandler CheckStateChanged { add { } remove { } }
    public event System.EventHandler Click { add { } remove { } }
    public event System.EventHandler DisplayStyleChanged { add { } remove { } }
    public event System.EventHandler DoubleClick { add { } remove { } }
    public event System.EventHandler DropDownClosed { add { } remove { } }
    public event System.Windows.Forms.ToolStripItemClickedEventHandler DropDownItemClicked { add { } remove { } }
    public event System.EventHandler DropDownOpened { add { } remove { } }
    public event System.EventHandler DropDownOpening { add { } remove { } }
    public event System.EventHandler EnabledChanged { add { } remove { } }
    public event System.EventHandler ForeColorChanged { add { } remove { } }
    public event System.EventHandler LocationChanged { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseDown { add { } remove { } }
    public event System.EventHandler MouseEnter { add { } remove { } }
    public event System.EventHandler MouseHover { add { } remove { } }
    public event System.EventHandler MouseLeave { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseMove { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseUp { add { } remove { } }
    public event System.EventHandler OwnerChanged { add { } remove { } }
    public event System.Windows.Forms.PaintEventHandler Paint { add { } remove { } }
    public event System.Windows.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp { add { } remove { } }
    public event System.EventHandler RightToLeftChanged { add { } remove { } }
    public event System.EventHandler TextChanged { add { } remove { } }
    public event System.EventHandler VisibleChanged { add { } remove { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    bool CanExtend(object target) { return default(bool); }
    protected override System.Type GetControlInstanceType() { return default(System.Type); }
    public short GetIndex(System.Windows.Forms.ToolStripMenuItem o) { return default(short); }
    protected override void HookUpControlEvents(object o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void ResetIndex(System.Windows.Forms.ToolStripMenuItem o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void SetIndex(System.Windows.Forms.ToolStripMenuItem o, short Index) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeIndex(System.Windows.Forms.ToolStripMenuItem o) { return default(bool); }
  }
  [System.ComponentModel.ProvidePropertyAttribute("Index", typeof(System.Windows.Forms.TreeView))]
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class TreeViewArray : Microsoft.VisualBasic.Compatibility.VB6.BaseControlArray, System.ComponentModel.IExtenderProvider {
    public TreeViewArray() { }
    public TreeViewArray(System.ComponentModel.IContainer Container) { }
    public System.Windows.Forms.TreeView this[short Index] { get { return default(System.Windows.Forms.TreeView); } }
    public event System.Windows.Forms.TreeViewEventHandler AfterCheck { add { } remove { } }
    public event System.Windows.Forms.TreeViewEventHandler AfterCollapse { add { } remove { } }
    public event System.Windows.Forms.TreeViewEventHandler AfterExpand { add { } remove { } }
    public event System.Windows.Forms.NodeLabelEditEventHandler AfterLabelEdit { add { } remove { } }
    public event System.Windows.Forms.TreeViewEventHandler AfterSelect { add { } remove { } }
    public event System.EventHandler BackColorChanged { add { } remove { } }
    public event System.Windows.Forms.TreeViewCancelEventHandler BeforeCheck { add { } remove { } }
    public event System.Windows.Forms.TreeViewCancelEventHandler BeforeCollapse { add { } remove { } }
    public event System.Windows.Forms.TreeViewCancelEventHandler BeforeExpand { add { } remove { } }
    public event System.Windows.Forms.NodeLabelEditEventHandler BeforeLabelEdit { add { } remove { } }
    public event System.Windows.Forms.TreeViewCancelEventHandler BeforeSelect { add { } remove { } }
    public event System.EventHandler BindingContextChanged { add { } remove { } }
    public event System.EventHandler CausesValidationChanged { add { } remove { } }
    public event System.Windows.Forms.UICuesEventHandler ChangeUICues { add { } remove { } }
    public event System.EventHandler Click { add { } remove { } }
    public event System.EventHandler ClientSizeChanged { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public event System.EventHandler ContextMenuChanged { add { } remove { } }
    public event System.EventHandler ContextMenuStripChanged { add { } remove { } }
    public event System.Windows.Forms.ControlEventHandler ControlAdded { add { } remove { } }
    public event System.Windows.Forms.ControlEventHandler ControlRemoved { add { } remove { } }
    public event System.EventHandler CursorChanged { add { } remove { } }
    public event System.EventHandler DockChanged { add { } remove { } }
    public event System.EventHandler DoubleClick { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragDrop { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragEnter { add { } remove { } }
    public event System.EventHandler DragLeave { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragOver { add { } remove { } }
    public event System.Windows.Forms.DrawTreeNodeEventHandler DrawNode { add { } remove { } }
    public event System.EventHandler EnabledChanged { add { } remove { } }
    public event System.EventHandler Enter { add { } remove { } }
    public event System.EventHandler FontChanged { add { } remove { } }
    public event System.EventHandler ForeColorChanged { add { } remove { } }
    public event System.Windows.Forms.GiveFeedbackEventHandler GiveFeedback { add { } remove { } }
    public event System.Windows.Forms.HelpEventHandler HelpRequested { add { } remove { } }
    public event System.EventHandler ImeModeChanged { add { } remove { } }
    public event System.Windows.Forms.ItemDragEventHandler ItemDrag { add { } remove { } }
    public event System.Windows.Forms.KeyEventHandler KeyDown { add { } remove { } }
    public event System.Windows.Forms.KeyPressEventHandler KeyPress { add { } remove { } }
    public event System.Windows.Forms.KeyEventHandler KeyUp { add { } remove { } }
    public event System.Windows.Forms.LayoutEventHandler Layout { add { } remove { } }
    public event System.EventHandler Leave { add { } remove { } }
    public event System.EventHandler LocationChanged { add { } remove { } }
    public event System.EventHandler MarginChanged { add { } remove { } }
    public event System.EventHandler MouseCaptureChanged { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseClick { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseDoubleClick { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseDown { add { } remove { } }
    public event System.EventHandler MouseEnter { add { } remove { } }
    public event System.EventHandler MouseHover { add { } remove { } }
    public event System.EventHandler MouseLeave { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseMove { add { } remove { } }
    public event System.Windows.Forms.MouseEventHandler MouseUp { add { } remove { } }
    public event System.EventHandler Move { add { } remove { } }
    public event System.Windows.Forms.TreeNodeMouseClickEventHandler NodeMouseClick { add { } remove { } }
    public event System.Windows.Forms.TreeNodeMouseClickEventHandler NodeMouseDoubleClick { add { } remove { } }
    public event System.Windows.Forms.TreeNodeMouseHoverEventHandler NodeMouseHover { add { } remove { } }
    public event System.EventHandler PaddingChanged { add { } remove { } }
    public event System.EventHandler ParentChanged { add { } remove { } }
    public event System.Windows.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp { add { } remove { } }
    public event System.Windows.Forms.QueryContinueDragEventHandler QueryContinueDrag { add { } remove { } }
    public event System.EventHandler RegionChanged { add { } remove { } }
    public event System.EventHandler Resize { add { } remove { } }
    public event System.EventHandler RightToLeftChanged { add { } remove { } }
    public event System.EventHandler RightToLeftLayoutChanged { add { } remove { } }
    public event System.EventHandler SizeChanged { add { } remove { } }
    public event System.EventHandler StyleChanged { add { } remove { } }
    public event System.EventHandler SystemColorsChanged { add { } remove { } }
    public event System.EventHandler TabIndexChanged { add { } remove { } }
    public event System.EventHandler TabStopChanged { add { } remove { } }
    public event System.EventHandler Validated { add { } remove { } }
    public event System.ComponentModel.CancelEventHandler Validating { add { } remove { } }
    public event System.EventHandler VisibleChanged { add { } remove { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    bool CanExtend(object target) { return default(bool); }
    protected override System.Type GetControlInstanceType() { return default(System.Type); }
    public short GetIndex(System.Windows.Forms.TreeView o) { return default(short); }
    protected override void HookUpControlEvents(object o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void ResetIndex(System.Windows.Forms.TreeView o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void SetIndex(System.Windows.Forms.TreeView o, short Index) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeIndex(System.Windows.Forms.TreeView o) { return default(bool); }
  }
  [System.ComponentModel.ProvidePropertyAttribute("Index", typeof(System.Windows.Forms.VScrollBar))]
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class VScrollBarArray : Microsoft.VisualBasic.Compatibility.VB6.BaseControlArray, System.ComponentModel.IExtenderProvider {
    public VScrollBarArray() { }
    public VScrollBarArray(System.ComponentModel.IContainer Container) { }
    public System.Windows.Forms.VScrollBar this[short Index] { get { return default(System.Windows.Forms.VScrollBar); } }
    public event System.EventHandler BindingContextChanged { add { } remove { } }
    public event System.EventHandler CausesValidationChanged { add { } remove { } }
    public event System.Windows.Forms.UICuesEventHandler ChangeUICues { add { } remove { } }
    public event System.EventHandler ClientSizeChanged { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public event System.EventHandler ContextMenuChanged { add { } remove { } }
    public event System.EventHandler ContextMenuStripChanged { add { } remove { } }
    public event System.Windows.Forms.ControlEventHandler ControlAdded { add { } remove { } }
    public event System.Windows.Forms.ControlEventHandler ControlRemoved { add { } remove { } }
    public event System.EventHandler CursorChanged { add { } remove { } }
    public event System.EventHandler DockChanged { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragDrop { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragEnter { add { } remove { } }
    public event System.EventHandler DragLeave { add { } remove { } }
    public event System.Windows.Forms.DragEventHandler DragOver { add { } remove { } }
    public event System.EventHandler EnabledChanged { add { } remove { } }
    public event System.EventHandler Enter { add { } remove { } }
    public event System.Windows.Forms.GiveFeedbackEventHandler GiveFeedback { add { } remove { } }
    public event System.Windows.Forms.HelpEventHandler HelpRequested { add { } remove { } }
    public event System.Windows.Forms.KeyEventHandler KeyDown { add { } remove { } }
    public event System.Windows.Forms.KeyPressEventHandler KeyPress { add { } remove { } }
    public event System.Windows.Forms.KeyEventHandler KeyUp { add { } remove { } }
    public event System.Windows.Forms.LayoutEventHandler Layout { add { } remove { } }
    public event System.EventHandler Leave { add { } remove { } }
    public event System.EventHandler LocationChanged { add { } remove { } }
    public event System.EventHandler MarginChanged { add { } remove { } }
    public event System.EventHandler MouseCaptureChanged { add { } remove { } }
    public event System.EventHandler MouseEnter { add { } remove { } }
    public event System.EventHandler MouseHover { add { } remove { } }
    public event System.EventHandler MouseLeave { add { } remove { } }
    public event System.EventHandler Move { add { } remove { } }
    public event System.EventHandler PaddingChanged { add { } remove { } }
    public event System.EventHandler ParentChanged { add { } remove { } }
    public event System.Windows.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp { add { } remove { } }
    public event System.Windows.Forms.QueryContinueDragEventHandler QueryContinueDrag { add { } remove { } }
    public event System.EventHandler RegionChanged { add { } remove { } }
    public event System.EventHandler Resize { add { } remove { } }
    public event System.Windows.Forms.ScrollEventHandler Scroll { add { } remove { } }
    public event System.EventHandler SizeChanged { add { } remove { } }
    public event System.EventHandler StyleChanged { add { } remove { } }
    public event System.EventHandler SystemColorsChanged { add { } remove { } }
    public event System.EventHandler TabIndexChanged { add { } remove { } }
    public event System.EventHandler TabStopChanged { add { } remove { } }
    public event System.EventHandler Validated { add { } remove { } }
    public event System.ComponentModel.CancelEventHandler Validating { add { } remove { } }
    public event System.EventHandler ValueChanged { add { } remove { } }
    public event System.EventHandler VisibleChanged { add { } remove { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    bool CanExtend(object target) { return default(bool); }
    protected override System.Type GetControlInstanceType() { return default(System.Type); }
    public short GetIndex(System.Windows.Forms.VScrollBar o) { return default(short); }
    protected override void HookUpControlEvents(object o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void ResetIndex(System.Windows.Forms.VScrollBar o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void SetIndex(System.Windows.Forms.VScrollBar o, short Index) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeIndex(System.Windows.Forms.VScrollBar o) { return default(bool); }
  }
  [System.ComponentModel.ProvidePropertyAttribute("Index", typeof(System.Windows.Forms.WebBrowser))]
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class WebBrowserArray : Microsoft.VisualBasic.Compatibility.VB6.BaseControlArray, System.ComponentModel.IExtenderProvider {
    public WebBrowserArray() { }
    public WebBrowserArray(System.ComponentModel.IContainer Container) { }
    public System.Windows.Forms.WebBrowser this[short Index] { get { return default(System.Windows.Forms.WebBrowser); } }
    public event System.EventHandler CausesValidationChanged { add { } remove { } }
    public event System.EventHandler ClientSizeChanged { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public event System.EventHandler ContextMenuChanged { add { } remove { } }
    public event System.EventHandler ContextMenuStripChanged { add { } remove { } }
    public event System.Windows.Forms.ControlEventHandler ControlAdded { add { } remove { } }
    public event System.Windows.Forms.ControlEventHandler ControlRemoved { add { } remove { } }
    public event System.EventHandler DockChanged { add { } remove { } }
    public event System.Windows.Forms.WebBrowserDocumentCompletedEventHandler DocumentCompleted { add { } remove { } }
    public event System.EventHandler FileDownload { add { } remove { } }
    public event System.EventHandler LocationChanged { add { } remove { } }
    public event System.EventHandler MarginChanged { add { } remove { } }
    public event System.EventHandler Move { add { } remove { } }
    public event System.Windows.Forms.WebBrowserNavigatedEventHandler Navigated { add { } remove { } }
    public event System.Windows.Forms.WebBrowserNavigatingEventHandler Navigating { add { } remove { } }
    public event System.ComponentModel.CancelEventHandler NewWindow { add { } remove { } }
    public event System.EventHandler ParentChanged { add { } remove { } }
    public event System.Windows.Forms.WebBrowserProgressChangedEventHandler ProgressChanged { add { } remove { } }
    public event System.EventHandler RegionChanged { add { } remove { } }
    public event System.EventHandler Resize { add { } remove { } }
    public event System.EventHandler SizeChanged { add { } remove { } }
    public event System.EventHandler SystemColorsChanged { add { } remove { } }
    public event System.EventHandler Validated { add { } remove { } }
    public event System.ComponentModel.CancelEventHandler Validating { add { } remove { } }
    public event System.EventHandler VisibleChanged { add { } remove { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    bool CanExtend(object target) { return default(bool); }
    protected override System.Type GetControlInstanceType() { return default(System.Type); }
    public short GetIndex(System.Windows.Forms.WebBrowser o) { return default(short); }
    protected override void HookUpControlEvents(object o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void ResetIndex(System.Windows.Forms.WebBrowser o) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void SetIndex(System.Windows.Forms.WebBrowser o, short Index) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeIndex(System.Windows.Forms.WebBrowser o) { return default(bool); }
  }
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class WebClass {
    public WebClass(string UserWebClassName, string WebClassFileName, object ContainingClass) { }
    public string Name { get { return default(string); } }
    public Microsoft.VisualBasic.Compatibility.VB6.WebItem NextItem { get { return default(Microsoft.VisualBasic.Compatibility.VB6.WebItem); } set { } }
    public string UrlData { get { return default(string); } set { } }
    public void ProcessEvents(System.Web.HttpRequest Request) { }
    public string URLFor(Microsoft.VisualBasic.Compatibility.VB6.WebItem obj, string EventName="") { return default(string); }
    public string URLFor(string objName, string EventName="") { return default(string); }
  }
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class WebClassContainingClassNotOptional : System.Exception {
    public WebClassContainingClassNotOptional() { }
  }
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class WebClassCouldNotFindEvent : System.Exception {
    public WebClassCouldNotFindEvent() { }
    public WebClassCouldNotFindEvent(string eventName) { }
  }
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class WebClassNextItemCannotBeCurrentWebItem : System.Exception {
    public WebClassNextItemCannotBeCurrentWebItem() { }
  }
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class WebClassNextItemRespondNotFound : System.Exception {
    public WebClassNextItemRespondNotFound() { }
  }
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class WebClassUserWebClassNameNotOptional : System.Exception {
    public WebClassUserWebClassNameNotOptional() { }
  }
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class WebClassWebClassFileNameNotOptional : System.Exception {
    public WebClassWebClassFileNameNotOptional() { }
  }
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class WebClassWebItemNotValid : System.Exception {
    public WebClassWebItemNotValid(string itemName) { }
  }
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class WebItem {
    public WebItem(string Name, Microsoft.VisualBasic.Compatibility.VB6.WebClass AssociatedWebClass, string HtmlTemplateFilename="") { }
    public string Name { get { return default(string); } }
    public bool ReScanReplacements { get { return default(bool); } set { } }
    public string TagPrefix { get { return default(string); } set { } }
    public void WriteTemplate(System.Web.HttpResponse Response, string HtmlTemplateFilename="") { }
  }
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class WebItemAssociatedWebClassNotOptional : System.Exception {
    public WebItemAssociatedWebClassNotOptional() { }
  }
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class WebItemClosingTagNotFound : System.Exception {
    public WebItemClosingTagNotFound(string TagName) { }
  }
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class WebItemCouldNotLoadEmbeddedResource : System.Exception {
    public WebItemCouldNotLoadEmbeddedResource() { }
  }
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class WebItemCouldNotLoadTemplateFile : System.Exception {
    public WebItemCouldNotLoadTemplateFile() { }
  }
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class WebItemNameNotOptional : System.Exception {
    public WebItemNameNotOptional() { }
  }
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class WebItemNoTemplateSpecified : System.Exception {
    public WebItemNoTemplateSpecified() { }
  }
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class WebItemTooManyNestedTags : System.Exception {
    public WebItemTooManyNestedTags() { }
  }
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public partial class WebItemUnexpectedErrorReadingTemplateFile : System.Exception {
    public WebItemUnexpectedErrorReadingTemplateFile(string innerMessage) { }
  }
  [System.ObsoleteAttribute("Microsoft.VisualBasic.Compatibility.* classes are obsolete and supported within 32 bit processes only. http://go.microsoft.com/fwlink/?linkid=160862")]
  public enum ZOrderConstants {
    BringToFront = 0,
    SendToBack = 1,
  }
}
