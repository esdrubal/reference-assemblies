namespace System.Drawing.Design {
  public partial class BitmapEditor : System.Drawing.Design.ImageEditor {
    public BitmapEditor() { }
    protected override System.String[] GetExtensions() { return default(System.String[]); }
    protected override string GetFileDialogDescription() { return default(string); }
    protected override System.Drawing.Image LoadFromStream(System.IO.Stream stream) { return default(System.Drawing.Image); }
  }
  public partial class ColorEditor : System.Drawing.Design.UITypeEditor {
    public ColorEditor() { }
    public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { return default(object); }
    public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { return default(System.Drawing.Design.UITypeEditorEditStyle); }
    public override bool GetPaintValueSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public override void PaintValue(System.Drawing.Design.PaintValueEventArgs e) { }
  }
  public partial class ContentAlignmentEditor : System.Drawing.Design.UITypeEditor {
    public ContentAlignmentEditor() { }
    public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { return default(object); }
    public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { return default(System.Drawing.Design.UITypeEditorEditStyle); }
  }
  public partial class CursorEditor : System.Drawing.Design.UITypeEditor {
    public CursorEditor() { }
    public override bool IsDropDownResizable { get { return default(bool); } }
    public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { return default(object); }
    public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { return default(System.Drawing.Design.UITypeEditorEditStyle); }
  }
  public partial class FontEditor : System.Drawing.Design.UITypeEditor {
    public FontEditor() { }
    public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { return default(object); }
    public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { return default(System.Drawing.Design.UITypeEditorEditStyle); }
  }
  public partial class FontNameEditor : System.Drawing.Design.UITypeEditor {
    public FontNameEditor() { }
    public override bool GetPaintValueSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public override void PaintValue(System.Drawing.Design.PaintValueEventArgs e) { }
  }
  public partial class IconEditor : System.Drawing.Design.UITypeEditor {
    public IconEditor() { }
    protected static string CreateExtensionsString(System.String[] extensions, string sep) { return default(string); }
    protected static string CreateFilterEntry(System.Drawing.Design.IconEditor e) { return default(string); }
    public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { return default(object); }
    public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { return default(System.Drawing.Design.UITypeEditorEditStyle); }
    protected virtual System.String[] GetExtensions() { return default(System.String[]); }
    protected virtual string GetFileDialogDescription() { return default(string); }
    public override bool GetPaintValueSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    protected virtual System.Drawing.Icon LoadFromStream(System.IO.Stream stream) { return default(System.Drawing.Icon); }
    public override void PaintValue(System.Drawing.Design.PaintValueEventArgs e) { }
  }
  public partial class ImageEditor : System.Drawing.Design.UITypeEditor {
    public ImageEditor() { }
    protected static string CreateExtensionsString(System.String[] extensions, string sep) { return default(string); }
    protected static string CreateFilterEntry(System.Drawing.Design.ImageEditor e) { return default(string); }
    public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { return default(object); }
    public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { return default(System.Drawing.Design.UITypeEditorEditStyle); }
    protected virtual System.String[] GetExtensions() { return default(System.String[]); }
    protected virtual string GetFileDialogDescription() { return default(string); }
    [System.MonoTODOAttribute]
    protected virtual System.Type[] GetImageExtenders() { return default(System.Type[]); }
    public override bool GetPaintValueSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    protected virtual System.Drawing.Image LoadFromStream(System.IO.Stream stream) { return default(System.Drawing.Image); }
    public override void PaintValue(System.Drawing.Design.PaintValueEventArgs e) { }
  }
  public partial class MetafileEditor : System.Drawing.Design.ImageEditor {
    public MetafileEditor() { }
    protected override System.String[] GetExtensions() { return default(System.String[]); }
    protected override string GetFileDialogDescription() { return default(string); }
    protected override System.Drawing.Image LoadFromStream(System.IO.Stream stream) { return default(System.Drawing.Image); }
  }
  public partial class ToolboxItemContainer : System.Runtime.Serialization.ISerializable {
    [System.MonoTODOAttribute]
    public ToolboxItemContainer(System.Drawing.Design.ToolboxItem item) { }
    [System.MonoTODOAttribute]
    protected ToolboxItemContainer(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    [System.MonoTODOAttribute]
    public ToolboxItemContainer(System.Windows.Forms.IDataObject data) { }
    [System.MonoTODOAttribute]
    public bool IsCreated { get { return default(bool); } }
    [System.MonoTODOAttribute]
    public bool IsTransient { get { return default(bool); } }
    [System.MonoTODOAttribute]
    public virtual System.Windows.Forms.IDataObject ToolboxData { get { return default(System.Windows.Forms.IDataObject); } }
    [System.MonoTODOAttribute]
    public override bool Equals(object obj) { return default(bool); }
    [System.MonoTODOAttribute]
    public virtual System.Collections.ICollection GetFilter(System.Collections.ICollection creators) { return default(System.Collections.ICollection); }
    [System.MonoTODOAttribute]
    public override int GetHashCode() { return default(int); }
    [System.MonoTODOAttribute]
    protected virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    [System.MonoTODOAttribute]
    public virtual System.Drawing.Design.ToolboxItem GetToolboxItem(System.Collections.ICollection creators) { return default(System.Drawing.Design.ToolboxItem); }
    [System.MonoTODOAttribute]
    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    [System.MonoTODOAttribute]
    public void UpdateFilter(System.Drawing.Design.ToolboxItem item) { }
  }
  public sealed partial class ToolboxItemCreator {
    internal ToolboxItemCreator() { }
    [System.MonoTODOAttribute]
    public string Format { get { return default(string); } }
    [System.MonoTODOAttribute]
    public System.Drawing.Design.ToolboxItem Create(System.Windows.Forms.IDataObject data) { return default(System.Drawing.Design.ToolboxItem); }
  }
  public abstract partial class ToolboxService : System.ComponentModel.Design.IComponentDiscoveryService, System.Drawing.Design.IToolboxService {
    [System.MonoTODOAttribute]
    protected ToolboxService() { }
    protected abstract System.Drawing.Design.CategoryNameCollection CategoryNames { get; }
    protected abstract string SelectedCategory { get; set; }
    protected abstract System.Drawing.Design.ToolboxItemContainer SelectedItemContainer { get; set; }
    System.Drawing.Design.CategoryNameCollection System.Drawing.Design.IToolboxService.CategoryNames { get { return default(System.Drawing.Design.CategoryNameCollection); } }
    string System.Drawing.Design.IToolboxService.SelectedCategory { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    protected virtual System.Drawing.Design.ToolboxItemContainer CreateItemContainer(System.Drawing.Design.ToolboxItem item, System.ComponentModel.Design.IDesignerHost link) { return default(System.Drawing.Design.ToolboxItemContainer); }
    [System.MonoTODOAttribute]
    protected virtual System.Drawing.Design.ToolboxItemContainer CreateItemContainer(System.Windows.Forms.IDataObject dataObject) { return default(System.Drawing.Design.ToolboxItemContainer); }
    [System.MonoTODOAttribute]
    protected virtual void FilterChanged() { }
    protected abstract System.Collections.IList GetItemContainers();
    protected abstract System.Collections.IList GetItemContainers(string categoryName);
    [System.MonoTODOAttribute]
    public static System.Drawing.Design.ToolboxItem GetToolboxItem(System.Type toolType) { return default(System.Drawing.Design.ToolboxItem); }
    [System.MonoTODOAttribute]
    public static System.Drawing.Design.ToolboxItem GetToolboxItem(System.Type toolType, bool nonPublic) { return default(System.Drawing.Design.ToolboxItem); }
    [System.MonoTODOAttribute]
    public static System.Collections.ICollection GetToolboxItems(System.Reflection.Assembly a, string newCodeBase) { return default(System.Collections.ICollection); }
    [System.MonoTODOAttribute]
    public static System.Collections.ICollection GetToolboxItems(System.Reflection.Assembly a, string newCodeBase, bool throwOnError) { return default(System.Collections.ICollection); }
    [System.MonoTODOAttribute]
    public static System.Collections.ICollection GetToolboxItems(System.Reflection.AssemblyName an) { return default(System.Collections.ICollection); }
    [System.MonoTODOAttribute]
    public static System.Collections.ICollection GetToolboxItems(System.Reflection.AssemblyName an, bool throwOnError) { return default(System.Collections.ICollection); }
    [System.MonoTODOAttribute]
    protected virtual bool IsItemContainer(System.Windows.Forms.IDataObject dataObject, System.ComponentModel.Design.IDesignerHost host) { return default(bool); }
    [System.MonoTODOAttribute]
    protected bool IsItemContainerSupported(System.Drawing.Design.ToolboxItemContainer container, System.ComponentModel.Design.IDesignerHost host) { return default(bool); }
    protected abstract void Refresh();
    [System.MonoTODOAttribute]
    protected virtual void SelectedItemContainerUsed() { }
    [System.MonoTODOAttribute]
    protected virtual bool SetCursor() { return default(bool); }
    System.Collections.ICollection System.ComponentModel.Design.IComponentDiscoveryService.GetComponentTypes(System.ComponentModel.Design.IDesignerHost designerHost, System.Type baseType) { return default(System.Collections.ICollection); }
    void System.Drawing.Design.IToolboxService.AddCreator(System.Drawing.Design.ToolboxItemCreatorCallback creator, string format) { }
    void System.Drawing.Design.IToolboxService.AddCreator(System.Drawing.Design.ToolboxItemCreatorCallback creator, string format, System.ComponentModel.Design.IDesignerHost host) { }
    void System.Drawing.Design.IToolboxService.AddLinkedToolboxItem(System.Drawing.Design.ToolboxItem toolboxItem, System.ComponentModel.Design.IDesignerHost host) { }
    void System.Drawing.Design.IToolboxService.AddLinkedToolboxItem(System.Drawing.Design.ToolboxItem toolboxItem, string category, System.ComponentModel.Design.IDesignerHost host) { }
    void System.Drawing.Design.IToolboxService.AddToolboxItem(System.Drawing.Design.ToolboxItem toolboxItem) { }
    void System.Drawing.Design.IToolboxService.AddToolboxItem(System.Drawing.Design.ToolboxItem toolboxItem, string category) { }
    System.Drawing.Design.ToolboxItem System.Drawing.Design.IToolboxService.DeserializeToolboxItem(object serializedObject) { return default(System.Drawing.Design.ToolboxItem); }
    System.Drawing.Design.ToolboxItem System.Drawing.Design.IToolboxService.DeserializeToolboxItem(object serializedObject, System.ComponentModel.Design.IDesignerHost host) { return default(System.Drawing.Design.ToolboxItem); }
    System.Drawing.Design.ToolboxItem System.Drawing.Design.IToolboxService.GetSelectedToolboxItem() { return default(System.Drawing.Design.ToolboxItem); }
    System.Drawing.Design.ToolboxItem System.Drawing.Design.IToolboxService.GetSelectedToolboxItem(System.ComponentModel.Design.IDesignerHost host) { return default(System.Drawing.Design.ToolboxItem); }
    System.Drawing.Design.ToolboxItemCollection System.Drawing.Design.IToolboxService.GetToolboxItems() { return default(System.Drawing.Design.ToolboxItemCollection); }
    System.Drawing.Design.ToolboxItemCollection System.Drawing.Design.IToolboxService.GetToolboxItems(System.ComponentModel.Design.IDesignerHost host) { return default(System.Drawing.Design.ToolboxItemCollection); }
    System.Drawing.Design.ToolboxItemCollection System.Drawing.Design.IToolboxService.GetToolboxItems(string category) { return default(System.Drawing.Design.ToolboxItemCollection); }
    System.Drawing.Design.ToolboxItemCollection System.Drawing.Design.IToolboxService.GetToolboxItems(string category, System.ComponentModel.Design.IDesignerHost host) { return default(System.Drawing.Design.ToolboxItemCollection); }
    bool System.Drawing.Design.IToolboxService.IsSupported(object serializedObject, System.Collections.ICollection filterAttributes) { return default(bool); }
    bool System.Drawing.Design.IToolboxService.IsSupported(object serializedObject, System.ComponentModel.Design.IDesignerHost host) { return default(bool); }
    bool System.Drawing.Design.IToolboxService.IsToolboxItem(object serializedObject) { return default(bool); }
    bool System.Drawing.Design.IToolboxService.IsToolboxItem(object serializedObject, System.ComponentModel.Design.IDesignerHost host) { return default(bool); }
    void System.Drawing.Design.IToolboxService.Refresh() { }
    void System.Drawing.Design.IToolboxService.RemoveCreator(string format) { }
    void System.Drawing.Design.IToolboxService.RemoveCreator(string format, System.ComponentModel.Design.IDesignerHost host) { }
    void System.Drawing.Design.IToolboxService.RemoveToolboxItem(System.Drawing.Design.ToolboxItem toolboxItem) { }
    void System.Drawing.Design.IToolboxService.RemoveToolboxItem(System.Drawing.Design.ToolboxItem toolboxItem, string category) { }
    void System.Drawing.Design.IToolboxService.SelectedToolboxItemUsed() { }
    object System.Drawing.Design.IToolboxService.SerializeToolboxItem(System.Drawing.Design.ToolboxItem toolboxItem) { return default(object); }
    bool System.Drawing.Design.IToolboxService.SetCursor() { return default(bool); }
    void System.Drawing.Design.IToolboxService.SetSelectedToolboxItem(System.Drawing.Design.ToolboxItem toolboxItem) { }
    [System.MonoTODOAttribute]
    public static void UnloadToolboxItems() { }
  }
}
