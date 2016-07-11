namespace System.Web.DynamicData {
  public enum ContainerType {
    Item = 1,
    List = 0,
  }
  public partial class ContextConfiguration {
    public ContextConfiguration() { }
    public System.Func<System.Type, System.ComponentModel.TypeDescriptionProvider> MetadataProviderFactory { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Func<System.Type, System.ComponentModel.TypeDescriptionProvider>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool ScaffoldAllTables { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial class ControlFilterExpression : System.Web.UI.WebControls.Expressions.DataSourceExpression {
    public ControlFilterExpression() { }
    public string Column { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string ControlID { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override System.Linq.IQueryable GetQueryable(System.Linq.IQueryable source) { return default(System.Linq.IQueryable); }
    protected override void LoadViewState(object savedState) { }
    protected override object SaveViewState() { return default(object); }
    public override void SetContext(System.Web.UI.Control owner, System.Web.HttpContext context, System.Web.UI.WebControls.IQueryableDataSource dataSource) { }
    protected override void TrackViewState() { }
  }
  public partial class DataControlReference {
    public DataControlReference() { }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.TypeConverterAttribute("System.Web.DynamicData.Design.DataControlReferenceIDConverter, System.Web.DynamicData.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    [System.Web.UI.IDReferencePropertyAttribute]
    [System.Web.UI.ResourceDescriptionAttribute("DataControlReference_ControlID")]
    public string ControlID { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public System.Web.DynamicData.DynamicDataManager Owner { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.DynamicData.DynamicDataManager); } }
    public override string ToString() { return default(string); }
  }
  public partial class DataControlReferenceCollection : System.Collections.ObjectModel.Collection<System.Web.DynamicData.DataControlReference> {
    public DataControlReferenceCollection(System.Web.DynamicData.DynamicDataManager owner) { }
    public System.Web.DynamicData.DynamicDataManager Owner { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.DynamicData.DynamicDataManager); } }
    protected override void InsertItem(int index, System.Web.DynamicData.DataControlReference item) { }
    protected override void RemoveItem(int index) { }
    protected override void SetItem(int index, System.Web.DynamicData.DataControlReference item) { }
  }
  public partial class DefaultAutoFieldGenerator : System.Web.UI.IAutoFieldGenerator {
    public DefaultAutoFieldGenerator(System.Web.DynamicData.MetaTable table) { }
    protected virtual System.Web.DynamicData.DynamicField CreateField(System.Web.DynamicData.MetaColumn column, System.Web.DynamicData.ContainerType containerType, System.Web.UI.WebControls.DataBoundControlMode mode) { return default(System.Web.DynamicData.DynamicField); }
    public System.Collections.ICollection GenerateFields(System.Web.UI.Control control) { return default(System.Collections.ICollection); }
  }
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Web.DynamicData.DynamicControl), "DynamicControl.bmp")]
  public partial class DynamicControl : System.Web.UI.Control, System.Web.DynamicData.IFieldFormattingOptions, System.Web.DynamicData.IFieldTemplateHost, System.Web.UI.IAttributeAccessor {
    public DynamicControl() { }
    public DynamicControl(System.Web.UI.WebControls.DataBoundControlMode mode) { }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Web.UI.ResourceDescriptionAttribute("DynamicControlFieldCommon_ApplyFormatInEditMode")]
    public bool ApplyFormatInEditMode { get { return default(bool); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public System.Web.DynamicData.MetaColumn Column { get { return default(System.Web.DynamicData.MetaColumn); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Web.UI.ResourceDescriptionAttribute("DynamicControlFieldCommon_ConvertEmptyStringToNull")]
    public bool ConvertEmptyStringToNull { get { return default(bool); } set { } }
    [System.ComponentModel.CategoryAttribute("Appearance")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.CssClassPropertyAttribute]
    public virtual string CssClass { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.ResourceDescriptionAttribute("DynamicControlFieldCommon_DataField")]
    public string DataField { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.ResourceDescriptionAttribute("DynamicControlFieldCommon_DataFormatString")]
    public string DataFormatString { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public System.Web.UI.Control FieldTemplate { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.UI.Control); } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Web.UI.ResourceDescriptionAttribute("DynamicControlFieldCommon_HtmlEncode")]
    public bool HtmlEncode { get { return default(bool); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.WebControls.DataBoundControlMode)(0))]
    [System.Web.UI.ResourceDescriptionAttribute("DynamicField_Mode")]
    public System.Web.UI.WebControls.DataBoundControlMode Mode { get { return default(System.Web.UI.WebControls.DataBoundControlMode); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.ResourceDescriptionAttribute("DynamicControlFieldCommon_NullDisplayText")]
    public string NullDisplayText { get { return default(string); } set { } }
    System.Web.DynamicData.IFieldFormattingOptions System.Web.DynamicData.IFieldTemplateHost.FormattingOptions { get { return default(System.Web.DynamicData.IFieldFormattingOptions); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public virtual System.Web.DynamicData.MetaTable Table { get { return default(System.Web.DynamicData.MetaTable); } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.ResourceDescriptionAttribute("DynamicControlFieldCommon_UIHint")]
    public virtual string UIHint { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.ResourceDescriptionAttribute("DynamicControlFieldCommon_ValidationGroup")]
    [System.Web.UI.ThemeableAttribute(false)]
    public virtual string ValidationGroup { get { return default(string); } set { } }
    public string GetAttribute(string key) { return default(string); }
    protected override void OnInit(System.EventArgs e) { }
    protected override void Render(System.Web.UI.HtmlTextWriter writer) { }
    public void SetAttribute(string key, string value) { }
  }
  public partial class DynamicControlParameter : System.Web.UI.WebControls.Parameter, System.Web.DynamicData.IWhereParametersProvider {
    public DynamicControlParameter() { }
    public DynamicControlParameter(string controlId) { }
    public string ControlId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override object Evaluate(System.Web.HttpContext context, System.Web.UI.Control control) { return default(object); }
    public virtual System.Collections.Generic.IEnumerable<System.Web.UI.WebControls.Parameter> GetWhereParameters(System.Web.DynamicData.IDynamicDataSource dataSource) { return default(System.Collections.Generic.IEnumerable<System.Web.UI.WebControls.Parameter>); }
  }
  public static partial class DynamicDataExtensions {
    public static object ConvertEditedValue(this System.Web.DynamicData.IFieldFormattingOptions formattingOptions, string value) { return default(object); }
    [System.ObsoleteAttribute("Use the EnablePersistedSelection property on a databound control such as GridView or ListView.")]
    public static void EnablePersistedSelection(this System.Web.UI.WebControls.BaseDataBoundControl dataBoundControl) { }
    public static void ExpandDynamicWhereParameters(this System.Web.DynamicData.IDynamicDataSource dataSource) { }
    public static System.Web.DynamicData.IDynamicDataSource FindDataSourceControl(this System.Web.UI.Control current) { return default(System.Web.DynamicData.IDynamicDataSource); }
    public static System.Web.UI.Control FindFieldTemplate(this System.Web.UI.Control control, string columnName) { return default(System.Web.UI.Control); }
    public static System.Web.DynamicData.MetaTable FindMetaTable(this System.Web.UI.Control current) { return default(System.Web.DynamicData.MetaTable); }
    public static string FormatEditValue(this System.Web.DynamicData.IFieldFormattingOptions formattingOptions, object fieldValue) { return default(string); }
    public static string FormatValue(this System.Web.DynamicData.IFieldFormattingOptions formattingOptions, object fieldValue) { return default(string); }
    public static System.Collections.Generic.IDictionary<System.String, System.Object> GetDefaultValues(this System.Web.UI.IDataSource dataSource) { return default(System.Collections.Generic.IDictionary<System.String, System.Object>); }
    public static System.Collections.Generic.IDictionary<System.String, System.Object> GetDefaultValues(this System.Web.UI.INamingContainer control) { return default(System.Collections.Generic.IDictionary<System.String, System.Object>); }
    public static System.Type GetEnumType(this System.Web.DynamicData.MetaColumn column) { return default(System.Type); }
    public static System.Web.DynamicData.MetaTable GetMetaTable(this System.Web.UI.IDataSource dataSource) { return default(System.Web.DynamicData.MetaTable); }
    public static System.Web.DynamicData.MetaTable GetMetaTable(this System.Web.UI.INamingContainer control) { return default(System.Web.DynamicData.MetaTable); }
    public static System.Web.DynamicData.MetaTable GetTable(this System.Web.DynamicData.IDynamicDataSource dataSource) { return default(System.Web.DynamicData.MetaTable); }
    public static void LoadWith<TEntity>(this System.Web.UI.WebControls.LinqDataSource dataSource) { }
    public static void LoadWithForeignKeys(this System.Web.UI.WebControls.LinqDataSource dataSource, System.Type rowType) { }
    public static void SetMetaTable(this System.Web.UI.INamingContainer control, System.Web.DynamicData.MetaTable table) { }
    public static void SetMetaTable(this System.Web.UI.INamingContainer control, System.Web.DynamicData.MetaTable table, System.Collections.Generic.IDictionary<System.String, System.Object> defaultValues) { }
    public static void SetMetaTable(this System.Web.UI.INamingContainer control, System.Web.DynamicData.MetaTable table, object defaultValues) { }
    public static bool TryGetMetaTable(this System.Web.UI.IDataSource dataSource, out System.Web.DynamicData.MetaTable table) { table = default(System.Web.DynamicData.MetaTable); return default(bool); }
    public static bool TryGetMetaTable(this System.Web.UI.INamingContainer control, out System.Web.DynamicData.MetaTable table) { table = default(System.Web.DynamicData.MetaTable); return default(bool); }
  }
  [System.ComponentModel.DesignerAttribute("System.Web.DynamicData.Design.DynamicDataManagerDesigner, System.Web.DynamicData.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Web.DynamicData.DynamicDataManager), "DynamicDataManager.bmp")]
  [System.Web.UI.NonVisualControlAttribute]
  [System.Web.UI.ParseChildrenAttribute(true)]
  [System.Web.UI.PersistChildrenAttribute(false)]
  public partial class DynamicDataManager : System.Web.UI.Control {
    public DynamicDataManager() { }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Web.UI.ResourceDescriptionAttribute("DynamicDataManager_AutoLoadForeignKeys")]
    public bool AutoLoadForeignKeys { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override string ClientID { get { return default(string); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override System.Web.UI.ClientIDMode ClientIDMode { get { return default(System.Web.UI.ClientIDMode); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    public System.Web.DynamicData.DataControlReferenceCollection DataControls { get { return default(System.Web.DynamicData.DataControlReferenceCollection); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override bool Visible { get { return default(bool); } set { } }
    protected override void OnInit(System.EventArgs e) { }
    protected override void OnLoad(System.EventArgs e) { }
    public void RegisterControl(System.Web.UI.Control control) { }
    public void RegisterControl(System.Web.UI.Control control, bool setSelectionFromUrl) { }
  }
  public partial class DynamicDataRoute : System.Web.Routing.Route {
    public DynamicDataRoute(string url) : base (default(string), default(System.Web.Routing.IRouteHandler)) { }
    public string Action { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Web.DynamicData.MetaModel Model { get { return default(System.Web.DynamicData.MetaModel); } set { } }
    public new System.Web.DynamicData.DynamicDataRouteHandler RouteHandler { get { return default(System.Web.DynamicData.DynamicDataRouteHandler); } set { } }
    public string Table { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string ViewName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string GetActionFromRouteData(System.Web.Routing.RouteData routeData) { return default(string); }
    public override System.Web.Routing.RouteData GetRouteData(System.Web.HttpContextBase httpContext) { return default(System.Web.Routing.RouteData); }
    public System.Web.DynamicData.MetaTable GetTableFromRouteData(System.Web.Routing.RouteData routeData) { return default(System.Web.DynamicData.MetaTable); }
    public override System.Web.Routing.VirtualPathData GetVirtualPath(System.Web.Routing.RequestContext requestContext, System.Web.Routing.RouteValueDictionary values) { return default(System.Web.Routing.VirtualPathData); }
  }
  public partial class DynamicDataRouteHandler : System.Web.Routing.IRouteHandler {
    public DynamicDataRouteHandler() { }
    public System.Web.DynamicData.MetaModel Model { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.DynamicData.MetaModel); } }
    public virtual System.Web.IHttpHandler CreateHandler(System.Web.DynamicData.DynamicDataRoute route, System.Web.DynamicData.MetaTable table, string action) { return default(System.Web.IHttpHandler); }
    protected virtual string GetCustomPageVirtualPath(System.Web.DynamicData.MetaTable table, string viewName) { return default(string); }
    public static System.Web.Routing.RequestContext GetRequestContext(System.Web.HttpContext httpContext) { return default(System.Web.Routing.RequestContext); }
    public static System.Web.DynamicData.MetaTable GetRequestMetaTable(System.Web.HttpContext httpContext) { return default(System.Web.DynamicData.MetaTable); }
    protected virtual string GetScaffoldPageVirtualPath(System.Web.DynamicData.MetaTable table, string viewName) { return default(string); }
    public static void SetRequestMetaTable(System.Web.HttpContext httpContext, System.Web.DynamicData.MetaTable table) { }
    System.Web.IHttpHandler System.Web.Routing.IRouteHandler.GetHttpHandler(System.Web.Routing.RequestContext requestContext) { return default(System.Web.IHttpHandler); }
  }
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Web.DynamicData.DynamicEntity), "DynamicEntity.bmp")]
  public partial class DynamicEntity : System.Web.UI.Control {
    public DynamicEntity() { }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.WebControls.DataBoundControlMode)(0))]
    [System.Web.UI.ResourceDescriptionAttribute("DynamicEntity_Mode")]
    public System.Web.UI.WebControls.DataBoundControlMode Mode { get { return default(System.Web.UI.WebControls.DataBoundControlMode); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.ResourceDescriptionAttribute("DynamicControlFieldCommon_UIHint")]
    public string UIHint { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.ResourceDescriptionAttribute("DynamicControlFieldCommon_ValidationGroup")]
    [System.Web.UI.ThemeableAttribute(false)]
    public string ValidationGroup { get { return default(string); } set { } }
    protected override void OnLoad(System.EventArgs e) { }
    protected override void Render(System.Web.UI.HtmlTextWriter writer) { }
  }
  [System.ComponentModel.DesignerAttribute("System.Web.DynamicData.Design.DynamicFieldDesigner, System.Web.DynamicData.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  public partial class DynamicField : System.Web.UI.WebControls.DataControlField, System.Web.DynamicData.IFieldFormattingOptions, System.Web.UI.IAttributeAccessor {
    public DynamicField() { }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Web.UI.ResourceDescriptionAttribute("DynamicControlFieldCommon_ApplyFormatInEditMode")]
    public bool ApplyFormatInEditMode { get { return default(bool); } set { } }
    protected System.Web.DynamicData.MetaColumn Column { get { return default(System.Web.DynamicData.MetaColumn); } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Web.UI.ResourceDescriptionAttribute("DynamicControlFieldCommon_ConvertEmptyStringToNull")]
    public bool ConvertEmptyStringToNull { get { return default(bool); } set { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.ResourceDescriptionAttribute("DynamicControlFieldCommon_DataField")]
    public virtual string DataField { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.ResourceDescriptionAttribute("DynamicControlFieldCommon_DataFormatString")]
    public string DataFormatString { get { return default(string); } set { } }
    public override string HeaderText { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Web.UI.ResourceDescriptionAttribute("DynamicControlFieldCommon_HtmlEncode")]
    public bool HtmlEncode { get { return default(bool); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.ResourceDescriptionAttribute("DynamicControlFieldCommon_NullDisplayText")]
    public string NullDisplayText { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Web.UI.ResourceDescriptionAttribute("DynamicField_ReadOnly")]
    public virtual bool ReadOnly { get { return default(bool); } set { } }
    public override string SortExpression { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.ResourceDescriptionAttribute("DynamicControlFieldCommon_UIHint")]
    public virtual string UIHint { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.ValidateRequestMode)(0))]
    [System.Web.UI.ResourceDescriptionAttribute("DynamicField_ValidateRequestMode")]
    public new System.Web.UI.ValidateRequestMode ValidateRequestMode { get { return default(System.Web.UI.ValidateRequestMode); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.ResourceDescriptionAttribute("DynamicControlFieldCommon_ValidationGroup")]
    public virtual string ValidationGroup { get { return default(string); } set { } }
    protected virtual void ConfigureDynamicControl(System.Web.DynamicData.DynamicControl control) { }
    protected override void CopyProperties(System.Web.UI.WebControls.DataControlField newField) { }
    protected virtual System.Web.DynamicData.DynamicControl CreateDynamicControl() { return default(System.Web.DynamicData.DynamicControl); }
    protected override System.Web.UI.WebControls.DataControlField CreateField() { return default(System.Web.UI.WebControls.DataControlField); }
    public override void ExtractValuesFromCell(System.Collections.Specialized.IOrderedDictionary dictionary, System.Web.UI.WebControls.DataControlFieldCell cell, System.Web.UI.WebControls.DataControlRowState rowState, bool includeReadOnly) { }
    public string GetAttribute(string key) { return default(string); }
    public override void InitializeCell(System.Web.UI.WebControls.DataControlFieldCell cell, System.Web.UI.WebControls.DataControlCellType cellType, System.Web.UI.WebControls.DataControlRowState rowState, int rowIndex) { }
    public void SetAttribute(string key, string value) { }
  }
  public partial class DynamicFilter : System.Web.UI.Control, System.Web.DynamicData.IFilterExpressionProvider {
    public DynamicFilter() { }
    protected internal System.Web.DynamicData.MetaColumn Column { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.DynamicData.MetaColumn); } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.ResourceDescriptionAttribute("DynamicFilter_DataField")]
    public string DataField { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Web.UI.Control FilterTemplate { get { return default(System.Web.UI.Control); } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.ResourceDescriptionAttribute("DynamicFilter_FilterUIHint")]
    public string FilterUIHint { get { return default(string); } set { } }
    public event System.EventHandler FilterChanged { add { } remove { } }
    protected override void Render(System.Web.UI.HtmlTextWriter writer) { }
    System.Linq.IQueryable System.Web.DynamicData.IFilterExpressionProvider.GetQueryable(System.Linq.IQueryable source) { return default(System.Linq.IQueryable); }
    void System.Web.DynamicData.IFilterExpressionProvider.Initialize(System.Web.UI.WebControls.IQueryableDataSource dataSource) { }
  }
  public partial class DynamicFilterExpression : System.Web.UI.WebControls.Expressions.DataSourceExpression {
    public DynamicFilterExpression() { }
    public string ControlID { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override System.Linq.IQueryable GetQueryable(System.Linq.IQueryable source) { return default(System.Linq.IQueryable); }
    public override void SetContext(System.Web.UI.Control owner, System.Web.HttpContext context, System.Web.UI.WebControls.IQueryableDataSource dataSource) { }
  }
  [System.ComponentModel.DefaultPropertyAttribute("Action")]
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Web.DynamicData.DynamicHyperLink), "DynamicHyperLink.bmp")]
  public partial class DynamicHyperLink : System.Web.UI.WebControls.HyperLink, System.Web.UI.IAttributeAccessor {
    public DynamicHyperLink() { }
    [System.ComponentModel.CategoryAttribute("Navigation")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.DynamicData.ActionConverter))]
    [System.Web.UI.ResourceDescriptionAttribute("DynamicHyperLink_Action")]
    public string Action { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Navigation")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.ResourceDescriptionAttribute("DynamicHyperLink_ContextTypeName")]
    public string ContextTypeName { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Navigation")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.ResourceDescriptionAttribute("DynamicHyperLink_DataField")]
    public string DataField { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Navigation")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.ResourceDescriptionAttribute("DynamicHyperLink_TableName")]
    public string TableName { get { return default(string); } set { } }
    protected override void OnDataBinding(System.EventArgs e) { }
    protected override void OnPreRender(System.EventArgs e) { }
    string System.Web.UI.IAttributeAccessor.GetAttribute(string key) { return default(string); }
    void System.Web.UI.IAttributeAccessor.SetAttribute(string key, string value) { }
  }
  public partial class DynamicQueryStringParameter : System.Web.UI.WebControls.Parameter, System.Web.DynamicData.IWhereParametersProvider {
    public DynamicQueryStringParameter() { }
    protected override object Evaluate(System.Web.HttpContext context, System.Web.UI.Control control) { return default(object); }
    public virtual System.Collections.Generic.IEnumerable<System.Web.UI.WebControls.Parameter> GetWhereParameters(System.Web.DynamicData.IDynamicDataSource dataSource) { return default(System.Collections.Generic.IEnumerable<System.Web.UI.WebControls.Parameter>); }
  }
  public partial class DynamicRouteExpression : System.Web.UI.WebControls.Expressions.DataSourceExpression {
    public DynamicRouteExpression() { }
    [System.ComponentModel.DefaultValueAttribute("")]
    public string ColumnName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override System.Linq.IQueryable GetQueryable(System.Linq.IQueryable source) { return default(System.Linq.IQueryable); }
    public override void SetContext(System.Web.UI.Control owner, System.Web.HttpContext context, System.Web.UI.WebControls.IQueryableDataSource dataSource) { }
  }
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Web.DynamicData.DynamicValidator), "DynamicValidator.bmp")]
  public partial class DynamicValidator : System.Web.UI.WebControls.BaseValidator {
    public DynamicValidator() { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Web.UI.ThemeableAttribute(false)]
    public System.Web.DynamicData.MetaColumn Column { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.DynamicData.MetaColumn); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Web.UI.ThemeableAttribute(false)]
    public string ColumnName { get { return default(string); } }
    protected virtual System.Exception ValidationException { get { return default(System.Exception); } set { } }
    protected override bool ControlPropertiesValid() { return default(bool); }
    protected override bool EvaluateIsValid() { return default(bool); }
    protected override void OnInit(System.EventArgs e) { }
    protected virtual void ValidateException(System.Exception exception) { }
  }
  [System.Web.UI.ParseChildrenAttribute(true)]
  [System.Web.UI.PersistChildrenAttribute(false)]
  public partial class EntityTemplate : System.Web.UI.Control {
    public EntityTemplate() { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    [System.Web.UI.TemplateContainerAttribute(typeof(System.Web.UI.INamingContainer))]
    public virtual System.Web.UI.ITemplate ItemTemplate { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.UI.ITemplate); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial class EntityTemplateFactory {
    public EntityTemplateFactory() { }
    public virtual string BuildEntityTemplateVirtualPath(string templateName, System.Web.UI.WebControls.DataBoundControlMode mode) { return default(string); }
    public virtual System.Web.DynamicData.EntityTemplateUserControl CreateEntityTemplate(System.Web.DynamicData.MetaTable table, System.Web.UI.WebControls.DataBoundControlMode mode, string uiHint) { return default(System.Web.DynamicData.EntityTemplateUserControl); }
    public virtual string GetEntityTemplateVirtualPath(System.Web.DynamicData.MetaTable table, System.Web.UI.WebControls.DataBoundControlMode mode, string uiHint) { return default(string); }
  }
  public partial class EntityTemplateUserControl : System.Web.UI.UserControl {
    public EntityTemplateUserControl() { }
    public virtual System.Web.DynamicData.ContainerType ContainerType { get { return default(System.Web.DynamicData.ContainerType); } }
    public System.Web.UI.WebControls.DataBoundControlMode Mode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.UI.WebControls.DataBoundControlMode); } }
    public System.Web.DynamicData.MetaTable Table { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.DynamicData.MetaTable); } }
    public string ValidationGroup { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
  }
  public partial class FieldTemplateFactory : System.Web.DynamicData.IFieldTemplateFactory {
    public FieldTemplateFactory() { }
    public System.Web.DynamicData.MetaModel Model { get { return default(System.Web.DynamicData.MetaModel); } }
    public string TemplateFolderVirtualPath { get { return default(string); } set { } }
    public virtual string BuildVirtualPath(string templateName, System.Web.DynamicData.MetaColumn column, System.Web.UI.WebControls.DataBoundControlMode mode) { return default(string); }
    public virtual System.Web.DynamicData.IFieldTemplate CreateFieldTemplate(System.Web.DynamicData.MetaColumn column, System.Web.UI.WebControls.DataBoundControlMode mode, string uiHint) { return default(System.Web.DynamicData.IFieldTemplate); }
    public virtual string GetFieldTemplateVirtualPath(System.Web.DynamicData.MetaColumn column, System.Web.UI.WebControls.DataBoundControlMode mode, string uiHint) { return default(string); }
    public virtual void Initialize(System.Web.DynamicData.MetaModel model) { }
    public virtual System.Web.UI.WebControls.DataBoundControlMode PreprocessMode(System.Web.DynamicData.MetaColumn column, System.Web.UI.WebControls.DataBoundControlMode mode) { return default(System.Web.UI.WebControls.DataBoundControlMode); }
  }
  public partial class FieldTemplateUserControl : System.Web.UI.UserControl, System.Web.DynamicData.IFieldTemplate, System.Web.UI.IBindableControl {
    public FieldTemplateUserControl() { }
    [System.ComponentModel.BrowsableAttribute(false)]
    public System.Web.DynamicData.MetaChildrenColumn ChildrenColumn { get { return default(System.Web.DynamicData.MetaChildrenColumn); } }
    protected string ChildrenPath { get { return default(string); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public System.Web.DynamicData.MetaColumn Column { get { return default(System.Web.DynamicData.MetaColumn); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public virtual System.Web.DynamicData.ContainerType ContainerType { get { return default(System.Web.DynamicData.ContainerType); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public virtual System.Web.UI.Control DataControl { get { return default(System.Web.UI.Control); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public virtual object FieldValue { get { return default(object); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public virtual string FieldValueEditString { get { return default(string); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public virtual string FieldValueString { get { return default(string); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public System.Web.DynamicData.MetaForeignKeyColumn ForeignKeyColumn { get { return default(System.Web.DynamicData.MetaForeignKeyColumn); } }
    protected string ForeignKeyPath { get { return default(string); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public System.Web.DynamicData.IFieldFormattingOptions FormattingOptions { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.DynamicData.IFieldFormattingOptions); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public System.Web.DynamicData.IFieldTemplateHost Host { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.DynamicData.IFieldTemplateHost); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public System.ComponentModel.AttributeCollection MetadataAttributes { get { return default(System.ComponentModel.AttributeCollection); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public System.Web.UI.WebControls.DataBoundControlMode Mode { get { return default(System.Web.UI.WebControls.DataBoundControlMode); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public virtual object Row { get { return default(object); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public System.Web.DynamicData.MetaTable Table { get { return default(System.Web.DynamicData.MetaTable); } }
    protected string BuildChildrenPath(string path) { return default(string); }
    protected string BuildForeignKeyPath(string path) { return default(string); }
    protected virtual object ConvertEditedValue(string value) { return default(object); }
    protected virtual void ExtractForeignKey(System.Collections.IDictionary dictionary, string selectedValue) { }
    protected virtual void ExtractValues(System.Collections.Specialized.IOrderedDictionary dictionary) { }
    protected System.Web.DynamicData.FieldTemplateUserControl FindOtherFieldTemplate(string columnName) { return default(System.Web.DynamicData.FieldTemplateUserControl); }
    public virtual string FormatFieldValue(object fieldValue) { return default(string); }
    protected virtual object GetColumnValue(System.Web.DynamicData.MetaColumn column) { return default(object); }
    protected string GetSelectedValueString() { return default(string); }
    protected void IgnoreModelValidationAttribute(System.Type attributeType) { }
    protected void PopulateListControl(System.Web.UI.WebControls.ListControl listControl) { }
    protected virtual void SetUpValidator(System.Web.UI.WebControls.BaseValidator validator) { }
    protected virtual void SetUpValidator(System.Web.UI.WebControls.BaseValidator validator, System.Web.DynamicData.MetaColumn column) { }
    void System.Web.DynamicData.IFieldTemplate.SetHost(System.Web.DynamicData.IFieldTemplateHost host) { }
    void System.Web.UI.IBindableControl.ExtractValues(System.Collections.Specialized.IOrderedDictionary dictionary) { }
  }
  public partial class FilterFactory {
    public FilterFactory() { }
    public virtual System.Web.DynamicData.QueryableFilterUserControl CreateFilterControl(System.Web.DynamicData.MetaColumn column, string filterUIHint) { return default(System.Web.DynamicData.QueryableFilterUserControl); }
    public virtual string GetFilterVirtualPath(System.Web.DynamicData.MetaColumn column, string filterUIHint) { return default(string); }
  }
  [System.ComponentModel.ToolboxItemAttribute(false)]
  [System.Web.UI.ParseChildrenAttribute(true)]
  public partial class FilterRepeater : System.Web.UI.WebControls.Repeater, System.Web.DynamicData.IWhereParametersProvider {
    public FilterRepeater() { }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Web.UI.ThemeableAttribute(false)]
    public string ContextTypeName { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute("DynamicFilter")]
    [System.Web.UI.IDReferencePropertyAttribute(typeof(System.Web.DynamicData.FilterUserControlBase))]
    [System.Web.UI.ResourceDescriptionAttribute("DynamicFilterRepeater_DynamicFilterContainerId")]
    [System.Web.UI.ThemeableAttribute(false)]
    public string DynamicFilterContainerId { get { return default(string); } set { } }
    public System.Web.DynamicData.MetaTable Table { get { return default(System.Web.DynamicData.MetaTable); } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Web.UI.ResourceDescriptionAttribute("FilterRepeater_TableName")]
    [System.Web.UI.ThemeableAttribute(false)]
    public string TableName { get { return default(string); } set { } }
    public override bool Visible { get { return default(bool); } set { } }
    public override void DataBind() { }
    protected internal virtual System.Collections.Generic.IEnumerable<System.Web.DynamicData.MetaColumn> GetFilteredColumns() { return default(System.Collections.Generic.IEnumerable<System.Web.DynamicData.MetaColumn>); }
    public virtual System.Collections.Generic.IEnumerable<System.Web.UI.WebControls.Parameter> GetWhereParameters(System.Web.DynamicData.IDynamicDataSource dataSource) { return default(System.Collections.Generic.IEnumerable<System.Web.UI.WebControls.Parameter>); }
    protected virtual void OnFilterItemCreated(System.Web.UI.WebControls.RepeaterItem item) { }
    protected override void OnInit(System.EventArgs e) { }
    protected override void OnItemCreated(System.Web.UI.WebControls.RepeaterItemEventArgs e) { }
  }
  public partial class FilterUserControlBase : System.Web.UI.UserControl, System.Web.DynamicData.IControlParameterTarget {
    public FilterUserControlBase() { }
    public System.Web.DynamicData.MetaColumn Column { get { return default(System.Web.DynamicData.MetaColumn); } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public string ContextTypeName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public string DataField { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string InitialValue { get { return default(string); } }
    public virtual System.Web.UI.WebControls.DataKey SelectedDataKey { get { return default(System.Web.UI.WebControls.DataKey); } }
    public virtual string SelectedValue { get { return default(string); } }
    System.Web.DynamicData.MetaColumn System.Web.DynamicData.IControlParameterTarget.FilteredColumn { get { return default(System.Web.DynamicData.MetaColumn); } }
    System.Web.DynamicData.MetaTable System.Web.DynamicData.IControlParameterTarget.Table { get { return default(System.Web.DynamicData.MetaTable); } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    public string TableName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public void PopulateListControl(System.Web.UI.WebControls.ListControl listControl) { }
    string System.Web.DynamicData.IControlParameterTarget.GetPropertyNameExpression(string columnName) { return default(string); }
  }
  public partial interface IControlParameterTarget {
    System.Web.DynamicData.MetaColumn FilteredColumn { get; }
    System.Web.DynamicData.MetaTable Table { get; }
    string GetPropertyNameExpression(string columnName);
  }
  public partial interface IFieldFormattingOptions {
    bool ApplyFormatInEditMode { get; }
    bool ConvertEmptyStringToNull { get; }
    string DataFormatString { get; }
    bool HtmlEncode { get; }
    string NullDisplayText { get; }
  }
  public partial interface IFieldTemplate {
    void SetHost(System.Web.DynamicData.IFieldTemplateHost host);
  }
  public partial interface IFieldTemplateFactory {
    System.Web.DynamicData.IFieldTemplate CreateFieldTemplate(System.Web.DynamicData.MetaColumn column, System.Web.UI.WebControls.DataBoundControlMode mode, string uiHint);
    void Initialize(System.Web.DynamicData.MetaModel model);
  }
  public partial interface IFieldTemplateHost {
    System.Web.DynamicData.MetaColumn Column { get; }
    System.Web.DynamicData.IFieldFormattingOptions FormattingOptions { get; }
    System.Web.UI.WebControls.DataBoundControlMode Mode { get; }
    string ValidationGroup { get; }
  }
  public partial interface IFilterExpressionProvider {
    System.Linq.IQueryable GetQueryable(System.Linq.IQueryable source);
    void Initialize(System.Web.UI.WebControls.IQueryableDataSource dataSource);
  }
  public partial interface IWhereParametersProvider {
    System.Collections.Generic.IEnumerable<System.Web.UI.WebControls.Parameter> GetWhereParameters(System.Web.DynamicData.IDynamicDataSource dataSource);
  }
  public partial class MetaChildrenColumn : System.Web.DynamicData.MetaColumn {
    public MetaChildrenColumn(System.Web.DynamicData.MetaTable table, System.Web.DynamicData.ModelProviders.ColumnProvider entityMember) : base (default(System.Web.DynamicData.MetaTable), default(System.Web.DynamicData.ModelProviders.ColumnProvider)) { }
    public System.Web.DynamicData.MetaTable ChildTable { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.DynamicData.MetaTable); } }
    public System.Web.DynamicData.MetaColumn ColumnInOtherTable { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.DynamicData.MetaColumn); } }
    public bool IsManyToMany { get { return default(bool); } }
    public string GetChildrenListPath(object row) { return default(string); }
    public string GetChildrenPath(string action, object row) { return default(string); }
    public string GetChildrenPath(string action, object row, string path) { return default(string); }
    protected internal override void Initialize() { }
  }
  public partial class MetaColumn : System.Web.DynamicData.IFieldFormattingOptions {
    public MetaColumn(System.Web.DynamicData.MetaTable table, System.Web.DynamicData.ModelProviders.ColumnProvider columnProvider) { }
    public bool AllowInitialValue { get { return default(bool); } }
    public bool ApplyFormatInEditMode { get { return default(bool); } }
    public System.ComponentModel.AttributeCollection Attributes { get { return default(System.ComponentModel.AttributeCollection); } }
    public System.Type ColumnType { get { return default(System.Type); } }
    public bool ConvertEmptyStringToNull { get { return default(bool); } }
    public string DataFormatString { get { return default(string); } }
    public System.ComponentModel.DataAnnotations.DataTypeAttribute DataTypeAttribute { get { return default(System.ComponentModel.DataAnnotations.DataTypeAttribute); } }
    public object DefaultValue { get { return default(object); } }
    public virtual string Description { get { return default(string); } }
    public virtual string DisplayName { get { return default(string); } }
    public System.Reflection.PropertyInfo EntityTypeProperty { get { return default(System.Reflection.PropertyInfo); } }
    public string FilterUIHint { get { return default(string); } }
    public bool HtmlEncode { get { return default(bool); } }
    public bool IsBinaryData { get { return default(bool); } }
    public bool IsCustomProperty { get { return default(bool); } }
    public bool IsFloatingPoint { get { return default(bool); } }
    public bool IsForeignKeyComponent { get { return default(bool); } }
    public bool IsGenerated { get { return default(bool); } }
    public bool IsInteger { get { return default(bool); } }
    public bool IsLongString { get { return default(bool); } }
    public bool IsPrimaryKey { get { return default(bool); } }
    public virtual bool IsReadOnly { get { return default(bool); } }
    public bool IsRequired { get { return default(bool); } }
    public bool IsString { get { return default(bool); } }
    public int MaxLength { get { return default(int); } }
    public System.Web.DynamicData.MetaModel Model { get { return default(System.Web.DynamicData.MetaModel); } }
    public string Name { get { return default(string); } }
    public string NullDisplayText { get { return default(string); } }
    public virtual string Prompt { get { return default(string); } }
    public System.Web.DynamicData.ModelProviders.ColumnProvider Provider { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.DynamicData.ModelProviders.ColumnProvider); } }
    public string RequiredErrorMessage { get { return default(string); } }
    public virtual bool Scaffold { get { return default(bool); } set { } }
    public virtual string ShortDisplayName { get { return default(string); } }
    public string SortExpression { get { return default(string); } }
    public System.Web.DynamicData.MetaTable Table { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.DynamicData.MetaTable); } }
    public System.TypeCode TypeCode { get { return default(System.TypeCode); } }
    public virtual string UIHint { get { return default(string); } }
    protected virtual System.ComponentModel.AttributeCollection BuildAttributeCollection() { return default(System.ComponentModel.AttributeCollection); }
    protected internal virtual void Initialize() { }
    public void ResetMetadata() { }
    public override string ToString() { return default(string); }
  }
  public partial class MetaForeignKeyColumn : System.Web.DynamicData.MetaColumn {
    public MetaForeignKeyColumn(System.Web.DynamicData.MetaTable table, System.Web.DynamicData.ModelProviders.ColumnProvider entityMember) : base (default(System.Web.DynamicData.MetaTable), default(System.Web.DynamicData.ModelProviders.ColumnProvider)) { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.String> ForeignKeyNames { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.String>); } }
    public bool IsPrimaryKeyInThisTable { get { return default(bool); } }
    public System.Web.DynamicData.MetaTable ParentTable { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.DynamicData.MetaTable); } }
    public void ExtractForeignKey(System.Collections.IDictionary dictionary, string value) { }
    public string GetFilterExpression(string foreignKeyName) { return default(string); }
    public string GetForeignKeyDetailsPath(object row) { return default(string); }
    public string GetForeignKeyPath(string action, object row) { return default(string); }
    public string GetForeignKeyPath(string action, object row, string path) { return default(string); }
    public string GetForeignKeyString(object row) { return default(string); }
    public System.Collections.Generic.IList<System.Object> GetForeignKeyValues(object row) { return default(System.Collections.Generic.IList<System.Object>); }
    protected internal override void Initialize() { }
  }
  public partial class MetaModel {
    public MetaModel() { }
    public MetaModel(bool registerGlobally) { }
    public static System.Web.DynamicData.MetaModel Default { get { return default(System.Web.DynamicData.MetaModel); } }
    public string DynamicDataFolderVirtualPath { get { return default(string); } set { } }
    public System.Web.DynamicData.EntityTemplateFactory EntityTemplateFactory { get { return default(System.Web.DynamicData.EntityTemplateFactory); } set { } }
    public System.Web.DynamicData.IFieldTemplateFactory FieldTemplateFactory { get { return default(System.Web.DynamicData.IFieldTemplateFactory); } set { } }
    public System.Web.DynamicData.FilterFactory FilterFactory { get { return default(System.Web.DynamicData.FilterFactory); } set { } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Web.DynamicData.MetaTable> Tables { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Web.DynamicData.MetaTable>); } }
    public System.Collections.Generic.List<System.Web.DynamicData.MetaTable> VisibleTables { get { return default(System.Collections.Generic.List<System.Web.DynamicData.MetaTable>); } }
    protected virtual System.Web.DynamicData.MetaTable CreateTable(System.Web.DynamicData.ModelProviders.TableProvider provider) { return default(System.Web.DynamicData.MetaTable); }
    public string GetActionPath(string tableName, string action, object row) { return default(string); }
    public static System.Web.DynamicData.MetaModel GetModel(System.Type contextType) { return default(System.Web.DynamicData.MetaModel); }
    public System.Web.DynamicData.MetaTable GetTable(string uniqueTableName) { return default(System.Web.DynamicData.MetaTable); }
    public System.Web.DynamicData.MetaTable GetTable(string tableName, System.Type contextType) { return default(System.Web.DynamicData.MetaTable); }
    public System.Web.DynamicData.MetaTable GetTable(System.Type entityType) { return default(System.Web.DynamicData.MetaTable); }
    public void RegisterContext(System.Func<System.Object> contextFactory) { }
    public void RegisterContext(System.Func<System.Object> contextFactory, System.Web.DynamicData.ContextConfiguration configuration) { }
    public void RegisterContext(System.Type contextType) { }
    public void RegisterContext(System.Type contextType, System.Web.DynamicData.ContextConfiguration configuration) { }
    public void RegisterContext(System.Web.DynamicData.ModelProviders.DataModelProvider dataModelProvider) { }
    public virtual void RegisterContext(System.Web.DynamicData.ModelProviders.DataModelProvider dataModelProvider, System.Web.DynamicData.ContextConfiguration configuration) { }
    public static void ResetRegistrationException() { }
    public bool TryGetTable(string uniqueTableName, out System.Web.DynamicData.MetaTable table) { table = default(System.Web.DynamicData.MetaTable); return default(bool); }
    public bool TryGetTable(System.Type entityType, out System.Web.DynamicData.MetaTable table) { table = default(System.Web.DynamicData.MetaTable); return default(bool); }
  }
  public partial class MetaTable {
    public MetaTable(System.Web.DynamicData.MetaModel metaModel, System.Web.DynamicData.ModelProviders.TableProvider tableProvider) { }
    public System.ComponentModel.AttributeCollection Attributes { get { return default(System.ComponentModel.AttributeCollection); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Web.DynamicData.MetaColumn> Columns { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Web.DynamicData.MetaColumn>); } }
    public string DataContextPropertyName { get { return default(string); } }
    public System.Type DataContextType { get { return default(System.Type); } }
    public virtual System.Web.DynamicData.MetaColumn DisplayColumn { get { return default(System.Web.DynamicData.MetaColumn); } }
    public virtual string DisplayName { get { return default(string); } }
    public System.Type EntityType { get { return default(System.Type); } }
    public string ForeignKeyColumnsNames { get { return default(string); } }
    public bool HasPrimaryKey { get { return default(bool); } }
    public virtual bool IsReadOnly { get { return default(bool); } }
    public string ListActionPath { get { return default(string); } }
    public System.Web.DynamicData.MetaModel Model { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.DynamicData.MetaModel); } }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Web.DynamicData.MetaColumn> PrimaryKeyColumns { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Web.DynamicData.MetaColumn>); } }
    public System.Web.DynamicData.ModelProviders.TableProvider Provider { get { return default(System.Web.DynamicData.ModelProviders.TableProvider); } }
    public System.Type RootEntityType { get { return default(System.Type); } }
    public virtual bool Scaffold { get { return default(bool); } }
    public virtual System.Web.DynamicData.MetaColumn SortColumn { get { return default(System.Web.DynamicData.MetaColumn); } }
    public virtual bool SortDescending { get { return default(bool); } }
    protected virtual System.ComponentModel.AttributeCollection BuildAttributeCollection() { return default(System.ComponentModel.AttributeCollection); }
    public virtual bool CanDelete(System.Security.Principal.IPrincipal principal) { return default(bool); }
    public virtual bool CanInsert(System.Security.Principal.IPrincipal principal) { return default(bool); }
    public virtual bool CanRead(System.Security.Principal.IPrincipal principal) { return default(bool); }
    public virtual bool CanUpdate(System.Security.Principal.IPrincipal principal) { return default(bool); }
    protected virtual System.Web.DynamicData.MetaChildrenColumn CreateChildrenColumn(System.Web.DynamicData.ModelProviders.ColumnProvider columnProvider) { return default(System.Web.DynamicData.MetaChildrenColumn); }
    protected virtual System.Web.DynamicData.MetaColumn CreateColumn(System.Web.DynamicData.ModelProviders.ColumnProvider columnProvider) { return default(System.Web.DynamicData.MetaColumn); }
    public virtual object CreateContext() { return default(object); }
    protected virtual System.Web.DynamicData.MetaForeignKeyColumn CreateForeignKeyColumn(System.Web.DynamicData.ModelProviders.ColumnProvider columnProvider) { return default(System.Web.DynamicData.MetaForeignKeyColumn); }
    public static System.Web.DynamicData.MetaTable CreateTable(System.ComponentModel.ICustomTypeDescriptor typeDescriptor) { return default(System.Web.DynamicData.MetaTable); }
    public static System.Web.DynamicData.MetaTable CreateTable(System.Type entityType) { return default(System.Web.DynamicData.MetaTable); }
    public string GetActionPath(string action) { return default(string); }
    public string GetActionPath(string action, System.Collections.Generic.IList<System.Object> primaryKeyValues) { return default(string); }
    public string GetActionPath(string action, System.Collections.Generic.IList<System.Object> primaryKeyValues, string path) { return default(string); }
    public string GetActionPath(string action, object row) { return default(string); }
    public string GetActionPath(string action, object row, string path) { return default(string); }
    public string GetActionPath(string action, System.Web.Routing.RouteValueDictionary routeValues) { return default(string); }
    public System.Web.DynamicData.MetaColumn GetColumn(string columnName) { return default(System.Web.DynamicData.MetaColumn); }
    public System.Collections.Generic.IDictionary<System.String, System.Object> GetColumnValuesFromRoute(System.Web.HttpContext context) { return default(System.Collections.Generic.IDictionary<System.String, System.Object>); }
    public System.Web.UI.WebControls.DataKey GetDataKeyFromRoute() { return default(System.Web.UI.WebControls.DataKey); }
    public virtual string GetDisplayString(object row) { return default(string); }
    public virtual System.Collections.Generic.IEnumerable<System.Web.DynamicData.MetaColumn> GetFilteredColumns() { return default(System.Collections.Generic.IEnumerable<System.Web.DynamicData.MetaColumn>); }
    public System.Collections.Generic.IDictionary<System.String, System.Object> GetPrimaryKeyDictionary(object row) { return default(System.Collections.Generic.IDictionary<System.String, System.Object>); }
    public string GetPrimaryKeyString(System.Collections.Generic.IList<System.Object> primaryKeyValues) { return default(string); }
    public string GetPrimaryKeyString(object row) { return default(string); }
    public System.Collections.Generic.IList<System.Object> GetPrimaryKeyValues(object row) { return default(System.Collections.Generic.IList<System.Object>); }
    public System.Linq.IQueryable GetQuery() { return default(System.Linq.IQueryable); }
    public virtual System.Linq.IQueryable GetQuery(object context) { return default(System.Linq.IQueryable); }
    public virtual System.Collections.Generic.IEnumerable<System.Web.DynamicData.MetaColumn> GetScaffoldColumns(System.Web.UI.WebControls.DataBoundControlMode mode, System.Web.DynamicData.ContainerType containerType) { return default(System.Collections.Generic.IEnumerable<System.Web.DynamicData.MetaColumn>); }
    public static System.Web.DynamicData.MetaTable GetTable(System.Type entityType) { return default(System.Web.DynamicData.MetaTable); }
    protected internal virtual void Initialize() { }
    public void ResetMetadata() { }
    public override string ToString() { return default(string); }
    public bool TryGetColumn(string columnName, out System.Web.DynamicData.MetaColumn column) { column = default(System.Web.DynamicData.MetaColumn); return default(bool); }
    public static bool TryGetTable(System.Type entityType, out System.Web.DynamicData.MetaTable table) { table = default(System.Web.DynamicData.MetaTable); return default(bool); }
  }
  public static partial class PageAction {
    public static string Details { get { return default(string); } }
    public static string Edit { get { return default(string); } }
    public static string Insert { get { return default(string); } }
    public static string List { get { return default(string); } }
  }
  [System.Web.UI.ParseChildrenAttribute(true)]
  [System.Web.UI.PersistChildrenAttribute(false)]
  public partial class QueryableFilterRepeater : System.Web.UI.Control, System.Web.DynamicData.IFilterExpressionProvider {
    public QueryableFilterRepeater() { }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute("DynamicFilter")]
    [System.Web.UI.IDReferencePropertyAttribute(typeof(System.Web.DynamicData.QueryableFilterUserControl))]
    [System.Web.UI.ResourceDescriptionAttribute("DynamicFilterRepeater_DynamicFilterContainerId")]
    [System.Web.UI.ThemeableAttribute(false)]
    public string DynamicFilterContainerId { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    [System.Web.UI.TemplateContainerAttribute(typeof(System.Web.UI.INamingContainer))]
    public virtual System.Web.UI.ITemplate ItemTemplate { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.UI.ITemplate); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override void OnPreRender(System.EventArgs e) { }
    System.Linq.IQueryable System.Web.DynamicData.IFilterExpressionProvider.GetQueryable(System.Linq.IQueryable source) { return default(System.Linq.IQueryable); }
    void System.Web.DynamicData.IFilterExpressionProvider.Initialize(System.Web.UI.WebControls.IQueryableDataSource dataSource) { }
  }
  public abstract partial class QueryableFilterUserControl : System.Web.UI.UserControl {
    protected QueryableFilterUserControl() { }
    protected internal System.Web.DynamicData.MetaColumn Column { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.DynamicData.MetaColumn); } }
    public string DefaultValue { get { return default(string); } }
    public System.Collections.Generic.IDictionary<System.String, System.Object> DefaultValues { get { return default(System.Collections.Generic.IDictionary<System.String, System.Object>); } }
    public virtual System.Web.UI.Control FilterControl { get { return default(System.Web.UI.Control); } }
    public event System.EventHandler FilterChanged { add { } remove { } }
    public static System.Linq.IQueryable ApplyEqualityFilter(System.Linq.IQueryable source, string propertyName, object value) { return default(System.Linq.IQueryable); }
    public abstract System.Linq.IQueryable GetQueryable(System.Linq.IQueryable source);
    protected void OnFilterChanged() { }
    public void PopulateListControl(System.Web.UI.WebControls.ListControl listControl) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false)]
  public sealed partial class TableNameAttribute : System.Attribute {
    public TableNameAttribute(string name) { }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
  }
}
namespace System.Web.DynamicData.ModelProviders {
  public enum AssociationDirection {
    ManyToMany = 3,
    ManyToOne = 2,
    OneToMany = 1,
    OneToOne = 0,
  }
  public abstract partial class AssociationProvider {
    protected AssociationProvider() { }
    public virtual System.Web.DynamicData.ModelProviders.AssociationDirection Direction { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.DynamicData.ModelProviders.AssociationDirection); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public virtual System.Collections.ObjectModel.ReadOnlyCollection<System.String> ForeignKeyNames { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.String>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public virtual System.Web.DynamicData.ModelProviders.ColumnProvider FromColumn { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.DynamicData.ModelProviders.ColumnProvider); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public virtual bool IsPrimaryKeyInThisTable { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public virtual System.Web.DynamicData.ModelProviders.ColumnProvider ToColumn { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.DynamicData.ModelProviders.ColumnProvider); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public virtual System.Web.DynamicData.ModelProviders.TableProvider ToTable { get { return default(System.Web.DynamicData.ModelProviders.TableProvider); } protected set { } }
    public virtual string GetSortExpression(System.Web.DynamicData.ModelProviders.ColumnProvider sortColumn) { return default(string); }
  }
  public abstract partial class ColumnProvider {
    protected ColumnProvider(System.Web.DynamicData.ModelProviders.TableProvider table) { }
    public virtual System.Web.DynamicData.ModelProviders.AssociationProvider Association { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.DynamicData.ModelProviders.AssociationProvider); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public virtual System.ComponentModel.AttributeCollection Attributes { get { return default(System.ComponentModel.AttributeCollection); } }
    public virtual System.Type ColumnType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public virtual System.Reflection.PropertyInfo EntityTypeProperty { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Reflection.PropertyInfo); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public virtual bool IsCustomProperty { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public virtual bool IsForeignKeyComponent { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public virtual bool IsGenerated { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public virtual bool IsPrimaryKey { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public virtual bool IsReadOnly { get { return default(bool); } protected set { } }
    public virtual bool IsSortable { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public virtual int MaxLength { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public virtual string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public virtual bool Nullable { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public System.Web.DynamicData.ModelProviders.TableProvider Table { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.DynamicData.ModelProviders.TableProvider); } }
    protected static System.ComponentModel.AttributeCollection AddDefaultAttributes(System.Web.DynamicData.ModelProviders.ColumnProvider columnProvider, System.ComponentModel.AttributeCollection attributes) { return default(System.ComponentModel.AttributeCollection); }
    public override string ToString() { return default(string); }
  }
  public abstract partial class DataModelProvider {
    protected DataModelProvider() { }
    public virtual System.Type ContextType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public abstract System.Collections.ObjectModel.ReadOnlyCollection<System.Web.DynamicData.ModelProviders.TableProvider> Tables { get; }
    public abstract object CreateContext();
  }
  public abstract partial class TableProvider {
    protected TableProvider(System.Web.DynamicData.ModelProviders.DataModelProvider model) { }
    public virtual System.ComponentModel.AttributeCollection Attributes { get { return default(System.ComponentModel.AttributeCollection); } }
    public abstract System.Collections.ObjectModel.ReadOnlyCollection<System.Web.DynamicData.ModelProviders.ColumnProvider> Columns { get; }
    public virtual string DataContextPropertyName { get { return default(string); } protected set { } }
    public System.Web.DynamicData.ModelProviders.DataModelProvider DataModel { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.DynamicData.ModelProviders.DataModelProvider); } }
    public virtual System.Type EntityType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public virtual string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public virtual System.Type ParentEntityType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public virtual System.Type RootEntityType { get { return default(System.Type); } protected set { } }
    public virtual bool CanDelete(System.Security.Principal.IPrincipal principal) { return default(bool); }
    public virtual bool CanInsert(System.Security.Principal.IPrincipal principal) { return default(bool); }
    public virtual bool CanRead(System.Security.Principal.IPrincipal principal) { return default(bool); }
    public virtual bool CanUpdate(System.Security.Principal.IPrincipal principal) { return default(bool); }
    public virtual object EvaluateForeignKey(object row, string foreignKeyName) { return default(object); }
    public abstract System.Linq.IQueryable GetQuery(object context);
    public virtual System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor() { return default(System.ComponentModel.ICustomTypeDescriptor); }
    public override string ToString() { return default(string); }
  }
}
namespace System.Web.UI {
  public static partial class DataControlExtensions {
    public static void EnableDynamicData(this System.Web.UI.INamingContainer control, System.Type entityType) { }
    public static void EnableDynamicData(this System.Web.UI.INamingContainer control, System.Type entityType, System.Collections.Generic.IDictionary<System.String, System.Object> defaultValues) { }
    public static void EnableDynamicData(this System.Web.UI.INamingContainer control, System.Type entityType, object defaults) { }
  }
}
