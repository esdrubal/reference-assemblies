namespace System.Web.UI.Design.WebControls {
  public partial class EntityDataSourceDesigner : System.Web.UI.Design.DataSourceDesigner {
    public EntityDataSourceDesigner() { }
    public override bool CanConfigure { get { return default(bool); } }
    public override bool CanRefreshSchema { get { return default(bool); } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.EditorAttribute(typeof(System.Web.UI.Design.WebControls.EntityDataSourceStatementEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.Web.UI.Design.WebControls.Util.ResourceDescriptionAttribute("PropertyDescription_CommandText")]
    public string CommandText { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.Design.WebControls.Util.ResourceDescriptionAttribute("PropertyDescription_ConnectionString")]
    public string ConnectionString { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.Design.WebControls.EntityDataSourceContainerNameConverter))]
    [System.Web.UI.Design.WebControls.Util.ResourceDescriptionAttribute("PropertyDescription_DefaultContainerName")]
    public string DefaultContainerName { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.Design.WebControls.EntityDataSourceEntitySetNameConverter))]
    [System.Web.UI.Design.WebControls.Util.ResourceDescriptionAttribute("PropertyDescription_EntitySetName")]
    public string EntitySetName { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.Design.WebControls.EntityDataSourceEntityTypeFilterConverter))]
    [System.Web.UI.Design.WebControls.Util.ResourceDescriptionAttribute("PropertyDescription_EntityTypeFilter")]
    public string EntityTypeFilter { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.EditorAttribute(typeof(System.Web.UI.Design.WebControls.EntityDataSourceStatementEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.Web.UI.Design.WebControls.Util.ResourceDescriptionAttribute("PropertyDescription_OrderBy")]
    public string OrderBy { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute(typeof(System.Web.UI.Design.WebControls.EntityDataSourceStatementEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.Web.UI.Design.WebControls.Util.ResourceDescriptionAttribute("PropertyDescription_Select")]
    public string Select { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.EditorAttribute(typeof(System.Web.UI.Design.WebControls.EntityDataSourceStatementEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.Web.UI.Design.WebControls.Util.ResourceDescriptionAttribute("PropertyDescription_Where")]
    public string Where { get { return default(string); } set { } }
    public override void Configure() { }
    public override System.Web.UI.Design.DesignerDataSourceView GetView(string viewName) { return default(System.Web.UI.Design.DesignerDataSourceView); }
    public override System.String[] GetViewNames() { return default(System.String[]); }
    public override void Initialize(System.ComponentModel.IComponent component) { }
    protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
    public override void RefreshSchema(bool preferSilent) { }
  }
  public partial class EntityDesignerDataSourceView : System.Web.UI.Design.DesignerDataSourceView {
    public EntityDesignerDataSourceView(System.Web.UI.Design.WebControls.EntityDataSourceDesigner owner) : base (default(System.Web.UI.Design.IDataSourceDesigner), default(string)) { }
    public override bool CanDelete { get { return default(bool); } }
    public override bool CanInsert { get { return default(bool); } }
    public override bool CanPage { get { return default(bool); } }
    public override bool CanSort { get { return default(bool); } }
    public override bool CanUpdate { get { return default(bool); } }
    public override System.Web.UI.Design.IDataSourceViewSchema Schema { get { return default(System.Web.UI.Design.IDataSourceViewSchema); } }
    public override System.Collections.IEnumerable GetDesignTimeData(int minimumRows, out bool isSampleData) { isSampleData = default(bool); return default(System.Collections.IEnumerable); }
  }
}
