namespace System.Windows.Automation.Peers {
  public sealed partial class WindowsFormsHostAutomationPeer : System.Windows.Automation.Peers.FrameworkElementAutomationPeer {
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.Demand, Name="FullTrust")]
    public WindowsFormsHostAutomationPeer(System.Windows.Forms.Integration.WindowsFormsHost owner) : base (default(System.Windows.FrameworkElement)) { }
    protected internal override bool IsHwndHost { get { return default(bool); } }
    protected override System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore() { return default(System.Windows.Automation.Peers.AutomationControlType); }
    protected override string GetClassNameCore() { return default(string); }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.SecurityTreatAsSafeAttribute]
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.Demand, Name="FullTrust")]
    protected override System.Windows.Automation.Peers.HostedWindowWrapper GetHostRawElementProviderCore() { return default(System.Windows.Automation.Peers.HostedWindowWrapper); }
  }
}
namespace System.Windows.Forms.Integration {
  public partial class ChildChangedEventArgs : System.EventArgs {
    public ChildChangedEventArgs(object previousChild) { }
    public object PreviousChild { get { return default(object); } }
  }
  [System.ComponentModel.DefaultEventAttribute("ChildChanged")]
  [System.ComponentModel.Design.Serialization.DesignerSerializerAttribute("WindowsFormsIntegration.Design.ElementHostCodeDomSerializer, WindowsFormsIntegration.Design, Version=1.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.ComponentModel.Design.Serialization.CodeDomSerializer, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [System.ComponentModel.DesignerAttribute("WindowsFormsIntegration.Design.ElementHostDesigner, WindowsFormsIntegration.Design, Version=1.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Windows.Markup.ContentPropertyAttribute("Child")]
  public partial class ElementHost : System.Windows.Forms.Control {
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.Demand, Name="FullTrust")]
    public ElementHost() { }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(0))]
    public override bool AutoSize { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool BackColorTransparent { get { return default(bool); } set { } }
    protected override bool CanEnableIme { get { return default(bool); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Windows.UIElement Child { get { return default(System.Windows.UIElement); } set { } }
    protected override System.Drawing.Size DefaultSize { get { return default(System.Drawing.Size); } }
    public override bool Focused { get { return default(bool); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Windows.Controls.Panel HostContainer { get { return default(System.Windows.Controls.Panel); } }
    protected override System.Windows.Forms.ImeMode ImeModeBase { get { return default(System.Windows.Forms.ImeMode); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public System.Windows.Forms.Integration.PropertyMap PropertyMap { get { return default(System.Windows.Forms.Integration.PropertyMap); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new event System.EventHandler BindingContextChanged { add { } remove { } }
    public event System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs> ChildChanged { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new event System.EventHandler Click { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new event System.EventHandler ClientSizeChanged { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new event System.Windows.Forms.ControlEventHandler ControlAdded { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new event System.Windows.Forms.ControlEventHandler ControlRemoved { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new event System.EventHandler CursorChanged { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new event System.EventHandler DoubleClick { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new event System.Windows.Forms.DragEventHandler DragDrop { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new event System.Windows.Forms.DragEventHandler DragEnter { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new event System.EventHandler DragLeave { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new event System.Windows.Forms.DragEventHandler DragOver { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new event System.EventHandler Enter { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new event System.EventHandler FontChanged { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new event System.EventHandler ForeColorChanged { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new event System.Windows.Forms.GiveFeedbackEventHandler GiveFeedback { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new event System.EventHandler GotFocus { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new event System.Windows.Forms.InvalidateEventHandler Invalidated { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new event System.Windows.Forms.KeyEventHandler KeyDown { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new event System.Windows.Forms.KeyPressEventHandler KeyPress { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new event System.Windows.Forms.KeyEventHandler KeyUp { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new event System.Windows.Forms.LayoutEventHandler Layout { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new event System.EventHandler Leave { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new event System.EventHandler LostFocus { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new event System.EventHandler MouseCaptureChanged { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new event System.Windows.Forms.MouseEventHandler MouseClick { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new event System.Windows.Forms.MouseEventHandler MouseDoubleClick { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new event System.Windows.Forms.MouseEventHandler MouseDown { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new event System.EventHandler MouseEnter { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new event System.EventHandler MouseHover { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new event System.EventHandler MouseLeave { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new event System.Windows.Forms.MouseEventHandler MouseMove { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new event System.Windows.Forms.MouseEventHandler MouseUp { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new event System.Windows.Forms.MouseEventHandler MouseWheel { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new event System.EventHandler PaddingChanged { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new event System.Windows.Forms.PaintEventHandler Paint { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new event System.Windows.Forms.PreviewKeyDownEventHandler PreviewKeyDown { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new event System.Windows.Forms.QueryContinueDragEventHandler QueryContinueDrag { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new event System.EventHandler Resize { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new event System.EventHandler RightToLeftChanged { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new event System.EventHandler SizeChanged { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new event System.EventHandler TextChanged { add { } remove { } }
    protected override void Dispose(bool disposing) { }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.Demand, Name="FullTrust")]
    public static void EnableModelessKeyboardInterop(System.Windows.Window window) { }
    public override System.Drawing.Size GetPreferredSize(System.Drawing.Size proposedSize) { return default(System.Drawing.Size); }
    protected override bool IsInputChar(char charCode) { return default(bool); }
    protected override void OnEnabledChanged(System.EventArgs e) { }
    protected override void OnGotFocus(System.EventArgs e) { }
    protected override void OnHandleCreated(System.EventArgs e) { }
    protected override void OnLeave(System.EventArgs e) { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    protected override void OnPaint(System.Windows.Forms.PaintEventArgs e) { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    protected override void OnPaintBackground(System.Windows.Forms.PaintEventArgs pevent) { }
    protected override void OnPrint(System.Windows.Forms.PaintEventArgs e) { }
    [System.Security.Permissions.UIPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Window=(System.Security.Permissions.UIPermissionWindow)(3))]
    public virtual void OnPropertyChanged(string propertyName, object value) { }
    protected override void OnVisibleChanged(System.EventArgs e) { }
    protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData) { return default(bool); }
    protected override bool ProcessMnemonic(char charCode) { return default(bool); }
    protected override void ScaleCore(float dx, float dy) { }
    protected override void Select(bool directed, bool forward) { }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
    protected override void WndProc(ref System.Windows.Forms.Message m) { }
  }
  public partial class IntegrationExceptionEventArgs : System.EventArgs {
    public IntegrationExceptionEventArgs(bool throwException, System.Exception exception) { }
    public System.Exception Exception { get { return default(System.Exception); } }
    public bool ThrowException { get { return default(bool); } set { } }
  }
  public partial class LayoutExceptionEventArgs : System.Windows.Forms.Integration.IntegrationExceptionEventArgs {
    public LayoutExceptionEventArgs(System.Exception exception) : base (default(bool), default(System.Exception)) { }
  }
  [System.Security.SecurityCriticalAttribute]
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
  public partial class PropertyMap {
    public PropertyMap() { }
    public PropertyMap(object source) { }
    protected System.Collections.Generic.Dictionary<System.String, System.Windows.Forms.Integration.PropertyTranslator> DefaultTranslators { get { return default(System.Collections.Generic.Dictionary<System.String, System.Windows.Forms.Integration.PropertyTranslator>); } }
    public System.Windows.Forms.Integration.PropertyTranslator this[string propertyName] { get { return default(System.Windows.Forms.Integration.PropertyTranslator); } set { } }
    public System.Collections.ICollection Keys { get { return default(System.Collections.ICollection); } }
    protected object SourceObject { get { return default(object); } }
    public System.Collections.ICollection Values { get { return default(System.Collections.ICollection); } }
    public event System.EventHandler<System.Windows.Forms.Integration.PropertyMappingExceptionEventArgs> PropertyMappingError { add { } remove { } }
    public void Add(string propertyName, System.Windows.Forms.Integration.PropertyTranslator translator) { }
    public void Apply(string propertyName) { }
    public void ApplyAll() { }
    public void Clear() { }
    public bool Contains(string propertyName) { return default(bool); }
    public void Remove(string propertyName) { }
    public void Reset(string propertyName) { }
    public void ResetAll() { }
  }
  public partial class PropertyMappingExceptionEventArgs : System.Windows.Forms.Integration.IntegrationExceptionEventArgs {
    public PropertyMappingExceptionEventArgs(System.Exception exception, string propertyName, object propertyValue) : base (default(bool), default(System.Exception)) { }
    public string PropertyName { get { return default(string); } }
    public object PropertyValue { get { return default(object); } }
  }
  public delegate void PropertyTranslator(object host, string propertyName, object value);
  [System.ComponentModel.DefaultEventAttribute("ChildChanged")]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Windows.Markup.ContentPropertyAttribute("Child")]
  public partial class WindowsFormsHost : System.Windows.Interop.HwndHost, System.Windows.Interop.IKeyboardInputSink {
    public static readonly System.Windows.DependencyProperty BackgroundProperty;
    public static readonly System.Windows.DependencyProperty FontFamilyProperty;
    public static readonly System.Windows.DependencyProperty FontSizeProperty;
    public static readonly System.Windows.DependencyProperty FontStyleProperty;
    public static readonly System.Windows.DependencyProperty FontWeightProperty;
    public static readonly System.Windows.DependencyProperty ForegroundProperty;
    public static readonly System.Windows.DependencyProperty PaddingProperty;
    public static readonly System.Windows.DependencyProperty TabIndexProperty;
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.Demand, Name="FullTrust")]
    public WindowsFormsHost() { }
    public System.Windows.Media.Brush Background { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Forms.Control Child { get { return default(System.Windows.Forms.Control); } set { } }
    public System.Windows.Media.FontFamily FontFamily { get { return default(System.Windows.Media.FontFamily); } set { } }
    public double FontSize { get { return default(double); } set { } }
    public System.Windows.FontStyle FontStyle { get { return default(System.Windows.FontStyle); } set { } }
    public System.Windows.FontWeight FontWeight { get { return default(System.Windows.FontWeight); } set { } }
    public System.Windows.Media.Brush Foreground { get { return default(System.Windows.Media.Brush); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.CategoryAttribute("Behavior")]
    public System.Windows.Thickness Padding { get { return default(System.Windows.Thickness); } set { } }
    public System.Windows.Forms.Integration.PropertyMap PropertyMap { get { return default(System.Windows.Forms.Integration.PropertyMap); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.CategoryAttribute("Behavior")]
    public int TabIndex { get { return default(int); } set { } }
    public event System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs> ChildChanged { add { } remove { } }
    public event System.EventHandler<System.Windows.Forms.Integration.LayoutExceptionEventArgs> LayoutError { add { } remove { } }
    protected override System.Windows.Size ArrangeOverride(System.Windows.Size finalSize) { return default(System.Windows.Size); }
    protected override System.Runtime.InteropServices.HandleRef BuildWindowCore(System.Runtime.InteropServices.HandleRef hwndParent) { return default(System.Runtime.InteropServices.HandleRef); }
    protected override void DestroyWindowCore(System.Runtime.InteropServices.HandleRef hwnd) { }
    protected override void Dispose(bool disposing) { }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.Demand, Name="FullTrust")]
    public static void EnableWindowsFormsInterop() { }
    protected override System.Windows.Size MeasureOverride(System.Windows.Size constraint) { return default(System.Windows.Size); }
    protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { return default(System.Windows.Automation.Peers.AutomationPeer); }
    protected override void OnPropertyChanged(System.Windows.DependencyPropertyChangedEventArgs e) { }
    protected virtual System.Windows.Vector ScaleChild(System.Windows.Vector newScale) { return default(System.Windows.Vector); }
    public virtual bool TabInto(System.Windows.Input.TraversalRequest request) { return default(bool); }
    protected override System.IntPtr WndProc(System.IntPtr hwnd, int msg, System.IntPtr wParam, System.IntPtr lParam, ref bool handled) { return default(System.IntPtr); }
  }
}
