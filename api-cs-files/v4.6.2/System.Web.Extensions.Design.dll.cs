namespace System.Web.UI.Design {
  public partial class AsyncPostBackTriggerControlIDConverter : System.ComponentModel.StringConverter {
    public AsyncPostBackTriggerControlIDConverter() { }
    public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { return default(System.ComponentModel.TypeConverter.StandardValuesCollection); }
    public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
  }
  public partial class AsyncPostBackTriggerEventNameConverter : System.ComponentModel.StringConverter {
    public AsyncPostBackTriggerEventNameConverter() { }
    public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { return default(System.ComponentModel.TypeConverter.StandardValuesCollection); }
    public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
  }
  public partial class CollectionEditorBase : System.ComponentModel.Design.CollectionEditor {
    public CollectionEditorBase(System.Type type) : base (default(System.Type)) { }
    protected override System.ComponentModel.Design.CollectionEditor.CollectionForm CreateCollectionForm() { return default(System.ComponentModel.Design.CollectionEditor.CollectionForm); }
  }
  public partial class ExtenderControlDesigner : System.Web.UI.Design.ControlDesigner {
    public ExtenderControlDesigner() { }
    protected override bool Visible { get { return default(bool); } }
    protected override void Dispose(bool disposing) { }
    public override string GetDesignTimeHtml() { return default(string); }
    public override void Initialize(System.ComponentModel.IComponent component) { }
    protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
  }
  public partial class ExtenderControlToolboxItem : System.Web.UI.Design.WebControlToolboxItem {
    public ExtenderControlToolboxItem() { }
    protected ExtenderControlToolboxItem(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public ExtenderControlToolboxItem(System.Type type) { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Type> GetTargetControlTypes(System.ComponentModel.Design.IDesignerHost host) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Type>); }
    public override void Initialize(System.Type type) { }
  }
  public partial class PostBackTriggerControlIDConverter : System.ComponentModel.StringConverter {
    public PostBackTriggerControlIDConverter() { }
    public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { return default(System.ComponentModel.TypeConverter.StandardValuesCollection); }
    public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
  }
  public partial class QueryExtenderDesigner : System.Web.UI.Design.ControlDesigner {
    public QueryExtenderDesigner() { }
    public override string GetDesignTimeHtml() { return default(string); }
  }
  public partial class ScriptManagerDesigner : System.Web.UI.Design.ControlDesigner {
    public ScriptManagerDesigner() { }
    public static string GetApplicationServices(System.Web.UI.ScriptManager scriptManager, System.Collections.Generic.IEnumerable<System.Web.UI.ScriptManagerProxy> proxies) { return default(string); }
    public override string GetDesignTimeHtml() { return default(string); }
    public static string GetProxyScript(System.Web.UI.ScriptManager scriptManager, System.Web.UI.ServiceReference serviceReference) { return default(string); }
    public static string GetProxyUrl(System.Web.UI.ScriptManager scriptManager, System.Web.UI.ServiceReference serviceReference) { return default(string); }
    public static string GetScriptFromWebResource(System.Reflection.Assembly assembly, string resourceName, System.Globalization.CultureInfo culture) { return default(string); }
    public static System.Collections.ObjectModel.ReadOnlyCollection<System.Web.UI.ScriptReference> GetScriptReferences(System.Web.UI.ScriptManager scriptManager, System.Collections.Generic.IEnumerable<System.Web.UI.ScriptManagerProxy> proxies) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Web.UI.ScriptReference>); }
    public static System.Collections.ObjectModel.ReadOnlyCollection<System.Web.UI.ServiceReference> GetServiceReferences(System.Web.UI.ScriptManager scriptManager, System.Collections.Generic.IEnumerable<System.Web.UI.ScriptManagerProxy> proxies) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Web.UI.ServiceReference>); }
    public override void Initialize(System.ComponentModel.IComponent component) { }
  }
  public partial class ScriptManagerProxyDesigner : System.Web.UI.Design.ControlDesigner {
    public ScriptManagerProxyDesigner() { }
    public override string GetDesignTimeHtml() { return default(string); }
    public override void Initialize(System.ComponentModel.IComponent component) { }
  }
  public partial class ServiceReferenceCollectionEditor : System.Web.UI.Design.CollectionEditorBase {
    public ServiceReferenceCollectionEditor(System.Type type) : base (default(System.Type)) { }
    protected override bool CanSelectMultipleInstances() { return default(bool); }
    protected override System.Type[] CreateNewItemTypes() { return default(System.Type[]); }
  }
  public partial class TimerDesigner : System.Web.UI.Design.ControlDesigner {
    public TimerDesigner() { }
    public override string GetDesignTimeHtml() { return default(string); }
  }
  public partial class UpdatePanelDesigner : System.Web.UI.Design.ControlDesigner {
    public UpdatePanelDesigner() { }
    protected override bool UsePreviewControl { get { return default(bool); } }
    public override string GetDesignTimeHtml(System.Web.UI.Design.DesignerRegionCollection regions) { return default(string); }
    public override string GetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region) { return default(string); }
    public override void Initialize(System.ComponentModel.IComponent component) { }
    public override void OnComponentChanged(object sender, System.ComponentModel.Design.ComponentChangedEventArgs ce) { }
    public override void SetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region, string content) { }
  }
  public partial class UpdatePanelTriggerCollectionEditor : System.Web.UI.Design.CollectionEditorBase {
    public UpdatePanelTriggerCollectionEditor(System.Type type) : base (default(System.Type)) { }
    protected override bool CanSelectMultipleInstances() { return default(bool); }
    protected override System.Type CreateCollectionItemType() { return default(System.Type); }
    protected override System.Type[] CreateNewItemTypes() { return default(System.Type[]); }
    public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { return default(object); }
  }
  public partial class UpdateProgressAssociatedUpdatePanelIDConverter : System.ComponentModel.StringConverter {
    public UpdateProgressAssociatedUpdatePanelIDConverter() { }
    public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { return default(System.ComponentModel.TypeConverter.StandardValuesCollection); }
    public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
  }
  public partial class UpdateProgressDesigner : System.Web.UI.Design.ControlDesigner {
    public UpdateProgressDesigner() { }
    protected override bool UsePreviewControl { get { return default(bool); } }
    public override string GetDesignTimeHtml(System.Web.UI.Design.DesignerRegionCollection regions) { return default(string); }
    public override string GetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region) { return default(string); }
    public override void SetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region, string content) { }
  }
}
namespace System.Web.UI.Design.WebControls {
  public partial class DataPagerDesigner : System.Web.UI.Design.ControlDesigner {
    public DataPagerDesigner() { }
    public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { return default(System.ComponentModel.Design.DesignerActionListCollection); } }
    public string PagedControlID { get { return default(string); } set { } }
    public override System.Web.UI.Design.TemplateGroupCollection TemplateGroups { get { return default(System.Web.UI.Design.TemplateGroupCollection); } }
    protected override bool UsePreviewControl { get { return default(bool); } }
    public override string GetDesignTimeHtml() { return default(string); }
    protected override string GetEmptyDesignTimeHtml() { return default(string); }
    public override void Initialize(System.ComponentModel.IComponent component) { }
    protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
  }
  [System.Security.SecurityCriticalAttribute]
  public partial class DataPagerFieldTypeEditor : System.Drawing.Design.UITypeEditor {
    public DataPagerFieldTypeEditor() { }
    public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { return default(object); }
    public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { return default(System.Drawing.Design.UITypeEditorEditStyle); }
  }
  public partial class LinqDataSourceDesigner : System.Web.UI.Design.DataSourceDesigner {
    public LinqDataSourceDesigner() { }
    public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { return default(System.ComponentModel.Design.DesignerActionListCollection); } }
    public override bool CanConfigure { get { return default(bool); } }
    public override bool CanRefreshSchema { get { return default(bool); } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.Design.WebControls.LinqDataSourceContextTypeConverter))]
    [System.Web.UI.ResourceDescriptionAttribute("LinqDataSource_ContextTypeName")]
    public string ContextTypeName { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorAttribute(typeof(System.Web.UI.Design.WebControls.LinqDataSourceStatementEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.Design.WebControls.LinqDataSourceInsertUpdateDeleteStatementConverter))]
    [System.Web.UI.ResourceDescriptionAttribute("LinqDataSource_DeleteParameters")]
    public string Delete { get { return default(string); } set { } }
    public bool EnableDelete { get { return default(bool); } set { } }
    public bool EnableInsert { get { return default(bool); } set { } }
    public bool EnableUpdate { get { return default(bool); } set { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute(typeof(System.Web.UI.Design.WebControls.LinqDataSourceStatementEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.Web.UI.ResourceDescriptionAttribute("LinqDataSource_GroupBy")]
    public string GroupBy { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorAttribute(typeof(System.Web.UI.Design.WebControls.LinqDataSourceStatementEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.Design.WebControls.LinqDataSourceInsertUpdateDeleteStatementConverter))]
    [System.Web.UI.ResourceDescriptionAttribute("LinqDataSource_InsertParameters")]
    public string Insert { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute(typeof(System.Web.UI.Design.WebControls.LinqDataSourceStatementEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.Web.UI.ResourceDescriptionAttribute("LinqDataSource_OrderBy")]
    public string OrderBy { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute(typeof(System.Web.UI.Design.WebControls.LinqDataSourceStatementEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.Web.UI.ResourceDescriptionAttribute("LinqDataSource_OrderGroupsBy")]
    public string OrderGroupsBy { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute(typeof(System.Web.UI.Design.WebControls.LinqDataSourceStatementEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.Web.UI.ResourceDescriptionAttribute("LinqDataSource_Select")]
    public string Select { get { return default(string); } set { } }
    public System.IServiceProvider ServiceProvider { get { return default(System.IServiceProvider); } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.Design.WebControls.LinqDataSourceTableConverter))]
    [System.Web.UI.ResourceDescriptionAttribute("LinqDataSource_TableName")]
    public string TableName { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorAttribute(typeof(System.Web.UI.Design.WebControls.LinqDataSourceStatementEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.Design.WebControls.LinqDataSourceInsertUpdateDeleteStatementConverter))]
    [System.Web.UI.ResourceDescriptionAttribute("LinqDataSource_UpdateParameters")]
    public string Update { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute(typeof(System.Web.UI.Design.WebControls.LinqDataSourceStatementEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.Web.UI.ResourceDescriptionAttribute("LinqDataSource_Where")]
    public string Where { get { return default(string); } set { } }
    public override void Configure() { }
    public override System.Web.UI.Design.DesignerDataSourceView GetView(string viewName) { return default(System.Web.UI.Design.DesignerDataSourceView); }
    public override System.String[] GetViewNames() { return default(System.String[]); }
    public override void Initialize(System.ComponentModel.IComponent component) { }
    protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
    public override void RefreshSchema(bool preferSilent) { }
  }
  public partial class LinqDesignerDataSourceView : System.Web.UI.Design.DesignerDataSourceView {
    public LinqDesignerDataSourceView(System.Web.UI.Design.WebControls.LinqDataSourceDesigner owner) : base (default(System.Web.UI.Design.IDataSourceDesigner), default(string)) { }
    public override bool CanDelete { get { return default(bool); } }
    public override bool CanInsert { get { return default(bool); } }
    public override bool CanPage { get { return default(bool); } }
    public override bool CanSort { get { return default(bool); } }
    public override bool CanUpdate { get { return default(bool); } }
    public bool IsDataContext { get { return default(bool); } }
    public bool IsTableTypeTable { get { return default(bool); } }
    public override System.Web.UI.Design.IDataSourceViewSchema Schema { get { return default(System.Web.UI.Design.IDataSourceViewSchema); } }
    public override System.Collections.IEnumerable GetDesignTimeData(int minimumRows, out bool isSampleData) { isSampleData = default(bool); return default(System.Collections.IEnumerable); }
  }
  public partial class ListViewDesigner : System.Web.UI.Design.WebControls.DataBoundControlDesigner {
    public ListViewDesigner() { }
    public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { return default(System.ComponentModel.Design.DesignerActionListCollection); } }
    protected override int SampleRowCount { get { return default(int); } }
    protected override bool UsePreviewControl { get { return default(bool); } }
    public override string GetDesignTimeHtml() { return default(string); }
    public override string GetDesignTimeHtml(System.Web.UI.Design.DesignerRegionCollection regions) { return default(string); }
    public override string GetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region) { return default(string); }
    protected override string GetEmptyDesignTimeHtml() { return default(string); }
    public override void Initialize(System.ComponentModel.IComponent component) { }
    public override void OnComponentChanged(object sender, System.ComponentModel.Design.ComponentChangedEventArgs ce) { }
    protected override void OnSchemaRefreshed() { }
    public override void SetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region, string content) { }
  }
}
