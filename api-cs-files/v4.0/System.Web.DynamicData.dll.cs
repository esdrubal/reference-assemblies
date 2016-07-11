namespace System.Web.DynamicData {
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class ContextConfiguration {
    public ContextConfiguration() { }
    public System.Func<System.Type, System.ComponentModel.TypeDescriptionProvider> MetadataProviderFactory { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Func<System.Type, System.ComponentModel.TypeDescriptionProvider>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool ScaffoldAllTables { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Web.DynamicData.DynamicControl), "DynamicControl.ico")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class DynamicControl : System.Web.UI.Control, System.Web.DynamicData.IFieldFormattingOptions, System.Web.DynamicData.IFieldTemplateHost, System.Web.UI.IAttributeAccessor {
    public DynamicControl() { }
    public DynamicControl(System.Web.UI.WebControls.DataBoundControlMode mode) { }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool ApplyFormatInEditMode { get { return default(bool); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public System.Web.DynamicData.MetaColumn Column { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.DynamicData.MetaColumn); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool ConvertEmptyStringToNull { get { return default(bool); } set { } }
    [System.ComponentModel.CategoryAttribute("Appearance")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.MonoTODOAttribute]
    [System.Web.UI.CssClassPropertyAttribute]
    public virtual string CssClass { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute("")]
    public string DataField { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute("")]
    public string DataFormatString { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.MonoTODOAttribute]
    public System.Web.UI.Control FieldTemplate { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.UI.Control); } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool HtmlEncode { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public System.Web.UI.WebControls.DataBoundControlMode Mode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.UI.WebControls.DataBoundControlMode); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute("")]
    public string NullDisplayText { get { return default(string); } set { } }
    System.Web.DynamicData.IFieldFormattingOptions System.Web.DynamicData.IFieldTemplateHost.FormattingOptions { get { return default(System.Web.DynamicData.IFieldFormattingOptions); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public virtual System.Web.DynamicData.MetaTable Table { get { return default(System.Web.DynamicData.MetaTable); } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute("")]
    public virtual string UIHint { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.ThemeableAttribute(false)]
    public virtual string ValidationGroup { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string GetAttribute(string key) { return default(string); }
    protected override void OnInit(System.EventArgs e) { }
    protected override void Render(System.Web.UI.HtmlTextWriter writer) { }
    public void SetAttribute(string key, string value) { }
  }
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class DynamicControlParameter : System.Web.UI.WebControls.Parameter, System.Web.DynamicData.IWhereParametersProvider {
    [System.MonoTODOAttribute]
    public DynamicControlParameter() { }
    [System.MonoTODOAttribute]
    public DynamicControlParameter(string controlId) { }
    [System.MonoTODOAttribute]
    public string ControlId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    protected override object Evaluate(System.Web.HttpContext context, System.Web.UI.Control control) { return default(object); }
    [System.MonoTODOAttribute]
    public virtual System.Collections.Generic.IEnumerable<System.Web.UI.WebControls.Parameter> GetWhereParameters(System.Web.DynamicData.IDynamicDataSource dataSource) { return default(System.Collections.Generic.IEnumerable<System.Web.UI.WebControls.Parameter>); }
  }
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public static partial class DynamicDataExtensions {
    public static object ConvertEditedValue(this System.Web.DynamicData.IFieldFormattingOptions formattingOptions, string value) { return default(object); }
    [System.MonoTODOAttribute]
    public static void EnablePersistedSelection(this System.Web.UI.WebControls.BaseDataBoundControl dataBoundControl) { }
    [System.MonoTODOAttribute]
    public static void ExpandDynamicWhereParameters(this System.Web.DynamicData.IDynamicDataSource dataSource) { }
    [System.MonoTODOAttribute]
    public static System.Web.DynamicData.IDynamicDataSource FindDataSourceControl(this System.Web.UI.Control current) { return default(System.Web.DynamicData.IDynamicDataSource); }
    [System.MonoTODOAttribute]
    public static System.Web.UI.Control FindFieldTemplate(this System.Web.UI.Control control, string columnName) { return default(System.Web.UI.Control); }
    public static System.Web.DynamicData.MetaTable FindMetaTable(this System.Web.UI.Control current) { return default(System.Web.DynamicData.MetaTable); }
    [System.MonoTODOAttribute]
    public static string FormatEditValue(this System.Web.DynamicData.IFieldFormattingOptions formattingOptions, object fieldValue) { return default(string); }
    [System.MonoTODOAttribute]
    public static string FormatValue(this System.Web.DynamicData.IFieldFormattingOptions formattingOptions, object fieldValue) { return default(string); }
    public static System.Web.DynamicData.MetaTable GetTable(this System.Web.DynamicData.IDynamicDataSource dataSource) { return default(System.Web.DynamicData.MetaTable); }
    [System.MonoTODOAttribute]
    public static void LoadWithForeignKeys(this System.Web.UI.WebControls.LinqDataSource dataSource, System.Type rowType) { }
  }
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Web.DynamicData.DynamicDataManager), "DynamicDataManager.ico")]
  [System.Web.UI.NonVisualControlAttribute]
  [System.Web.UI.ParseChildrenAttribute(true)]
  [System.Web.UI.PersistChildrenAttribute(false)]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class DynamicDataManager : System.Web.UI.Control {
    public DynamicDataManager() { }
    public bool AutoLoadForeignKeys { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public override bool Visible { get { return default(bool); } set { } }
    protected override void OnLoad(System.EventArgs e) { }
    public void RegisterControl(System.Web.UI.Control control) { }
    public void RegisterControl(System.Web.UI.Control control, bool setSelectionFromUrl) { }
  }
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class DynamicDataRoute : System.Web.Routing.Route {
    public DynamicDataRoute(string url) : base (default(string), default(System.Web.Routing.IRouteHandler)) { }
    public string Action { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Web.DynamicData.MetaModel Model { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.DynamicData.MetaModel); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public new System.Web.DynamicData.DynamicDataRouteHandler RouteHandler { get { return default(System.Web.DynamicData.DynamicDataRouteHandler); } set { } }
    public string Table { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string ViewName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string GetActionFromRouteData(System.Web.Routing.RouteData routeData) { return default(string); }
    public override System.Web.Routing.RouteData GetRouteData(System.Web.HttpContextBase httpContext) { return default(System.Web.Routing.RouteData); }
    public System.Web.DynamicData.MetaTable GetTableFromRouteData(System.Web.Routing.RouteData routeData) { return default(System.Web.DynamicData.MetaTable); }
    public override System.Web.Routing.VirtualPathData GetVirtualPath(System.Web.Routing.RequestContext requestContext, System.Web.Routing.RouteValueDictionary values) { return default(System.Web.Routing.VirtualPathData); }
  }
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class DynamicDataRouteHandler : System.Web.Routing.IRouteHandler {
    public DynamicDataRouteHandler() { }
    public System.Web.DynamicData.MetaModel Model { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.DynamicData.MetaModel); } }
    [System.MonoTODOAttribute("Needs a working test")]
    public virtual System.Web.IHttpHandler CreateHandler(System.Web.DynamicData.DynamicDataRoute route, System.Web.DynamicData.MetaTable table, string action) { return default(System.Web.IHttpHandler); }
    protected virtual string GetCustomPageVirtualPath(System.Web.DynamicData.MetaTable table, string viewName) { return default(string); }
    public static System.Web.Routing.RequestContext GetRequestContext(System.Web.HttpContext httpContext) { return default(System.Web.Routing.RequestContext); }
    public static System.Web.DynamicData.MetaTable GetRequestMetaTable(System.Web.HttpContext httpContext) { return default(System.Web.DynamicData.MetaTable); }
    protected virtual string GetScaffoldPageVirtualPath(System.Web.DynamicData.MetaTable table, string viewName) { return default(string); }
    public static void SetRequestMetaTable(System.Web.HttpContext httpContext, System.Web.DynamicData.MetaTable table) { }
    System.Web.IHttpHandler System.Web.Routing.IRouteHandler.GetHttpHandler(System.Web.Routing.RequestContext requestContext) { return default(System.Web.IHttpHandler); }
  }
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class DynamicField : System.Web.UI.WebControls.DataControlField, System.Web.DynamicData.IFieldFormattingOptions, System.Web.UI.IAttributeAccessor {
    public DynamicField() { }
    public bool ApplyFormatInEditMode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool ConvertEmptyStringToNull { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public virtual string DataField { get { return default(string); } set { } }
    public string DataFormatString { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override string HeaderText { get { return default(string); } set { } }
    public bool HtmlEncode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string NullDisplayText { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override string SortExpression { get { return default(string); } set { } }
    public virtual string UIHint { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    protected override void CopyProperties(System.Web.UI.WebControls.DataControlField newField) { }
    [System.MonoTODOAttribute]
    protected override System.Web.UI.WebControls.DataControlField CreateField() { return default(System.Web.UI.WebControls.DataControlField); }
    [System.MonoTODOAttribute]
    public override void ExtractValuesFromCell(System.Collections.Specialized.IOrderedDictionary dictionary, System.Web.UI.WebControls.DataControlFieldCell cell, System.Web.UI.WebControls.DataControlRowState rowState, bool includeReadOnly) { }
    public string GetAttribute(string key) { return default(string); }
    public override void InitializeCell(System.Web.UI.WebControls.DataControlFieldCell cell, System.Web.UI.WebControls.DataControlCellType cellType, System.Web.UI.WebControls.DataControlRowState rowState, int rowIndex) { }
    public void SetAttribute(string key, string value) { }
  }
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class DynamicQueryStringParameter : System.Web.UI.WebControls.Parameter, System.Web.DynamicData.IWhereParametersProvider {
    public DynamicQueryStringParameter() { }
    [System.MonoTODOAttribute]
    protected override object Evaluate(System.Web.HttpContext context, System.Web.UI.Control control) { return default(object); }
    [System.MonoTODOAttribute]
    public virtual System.Collections.Generic.IEnumerable<System.Web.UI.WebControls.Parameter> GetWhereParameters(System.Web.DynamicData.IDynamicDataSource dataSource) { return default(System.Collections.Generic.IEnumerable<System.Web.UI.WebControls.Parameter>); }
  }
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Web.DynamicData.DynamicValidator), "DynamicValidator.ico")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class DynamicValidator : System.Web.UI.WebControls.BaseValidator {
    public DynamicValidator() { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Web.UI.ThemeableAttribute(false)]
    public System.Web.DynamicData.MetaColumn Column { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.DynamicData.MetaColumn); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Web.UI.ThemeableAttribute(false)]
    public string ColumnName { get { return default(string); } }
    protected virtual System.Exception ValidationException { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Exception); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected override bool ControlPropertiesValid() { return default(bool); }
    [System.MonoTODOAttribute]
    protected override bool EvaluateIsValid() { return default(bool); }
    protected override void OnInit(System.EventArgs e) { }
    [System.MonoTODOAttribute]
    protected virtual void ValidateException(System.Exception exception) { }
  }
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class FieldTemplateFactory : System.Web.DynamicData.IFieldTemplateFactory {
    public FieldTemplateFactory() { }
    public System.Web.DynamicData.MetaModel Model { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.DynamicData.MetaModel); } }
    public string TemplateFolderVirtualPath { get { return default(string); } set { } }
    public virtual string BuildVirtualPath(string templateName, System.Web.DynamicData.MetaColumn column, System.Web.UI.WebControls.DataBoundControlMode mode) { return default(string); }
    public virtual System.Web.DynamicData.IFieldTemplate CreateFieldTemplate(System.Web.DynamicData.MetaColumn column, System.Web.UI.WebControls.DataBoundControlMode mode, string uiHint) { return default(System.Web.DynamicData.IFieldTemplate); }
    public virtual string GetFieldTemplateVirtualPath(System.Web.DynamicData.MetaColumn column, System.Web.UI.WebControls.DataBoundControlMode mode, string uiHint) { return default(string); }
    public virtual void Initialize(System.Web.DynamicData.MetaModel model) { }
    public virtual System.Web.UI.WebControls.DataBoundControlMode PreprocessMode(System.Web.DynamicData.MetaColumn column, System.Web.UI.WebControls.DataBoundControlMode mode) { return default(System.Web.UI.WebControls.DataBoundControlMode); }
  }
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class FieldTemplateUserControl : System.Web.UI.UserControl, System.Web.DynamicData.IFieldTemplate, System.Web.UI.IBindableControl {
    public FieldTemplateUserControl() { }
    public System.Web.DynamicData.MetaChildrenColumn ChildrenColumn { get { return default(System.Web.DynamicData.MetaChildrenColumn); } }
    [System.MonoTODOAttribute]
    protected string ChildrenPath { get { return default(string); } }
    public System.Web.DynamicData.MetaColumn Column { get { return default(System.Web.DynamicData.MetaColumn); } }
    [System.MonoTODOAttribute]
    public virtual System.Web.UI.Control DataControl { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.UI.Control); } }
    [System.MonoTODOAttribute]
    public virtual object FieldValue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public virtual string FieldValueEditString { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    [System.MonoTODOAttribute]
    public virtual string FieldValueString { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    [System.MonoTODOAttribute]
    public System.Web.DynamicData.MetaForeignKeyColumn ForeignKeyColumn { get { return default(System.Web.DynamicData.MetaForeignKeyColumn); } }
    [System.MonoTODOAttribute]
    protected string ForeignKeyPath { get { return default(string); } }
    [System.MonoTODOAttribute]
    public System.Web.DynamicData.IFieldFormattingOptions FormattingOptions { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.DynamicData.IFieldFormattingOptions); } }
    public System.Web.DynamicData.IFieldTemplateHost Host { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.DynamicData.IFieldTemplateHost); } }
    [System.MonoTODOAttribute]
    public System.ComponentModel.AttributeCollection MetadataAttributes { get { return default(System.ComponentModel.AttributeCollection); } }
    [System.MonoTODOAttribute]
    public System.Web.UI.WebControls.DataBoundControlMode Mode { get { return default(System.Web.UI.WebControls.DataBoundControlMode); } }
    [System.MonoTODOAttribute]
    public virtual object Row { get { return default(object); } }
    [System.MonoTODOAttribute]
    public System.Web.DynamicData.MetaTable Table { get { return default(System.Web.DynamicData.MetaTable); } }
    [System.MonoTODOAttribute]
    protected string BuildChildrenPath(string path) { return default(string); }
    [System.MonoTODOAttribute]
    protected string BuildForeignKeyPath(string path) { return default(string); }
    [System.MonoTODOAttribute]
    protected virtual object ConvertEditedValue(string value) { return default(object); }
    [System.MonoTODOAttribute]
    protected virtual void ExtractForeignKey(System.Collections.IDictionary dictionary, string selectedValue) { }
    [System.MonoTODOAttribute]
    protected virtual void ExtractValues(System.Collections.Specialized.IOrderedDictionary dictionary) { }
    [System.MonoTODOAttribute]
    protected System.Web.DynamicData.FieldTemplateUserControl FindOtherFieldTemplate(string columnName) { return default(System.Web.DynamicData.FieldTemplateUserControl); }
    [System.MonoTODOAttribute]
    public virtual string FormatFieldValue(object fieldValue) { return default(string); }
    [System.MonoTODOAttribute]
    protected virtual object GetColumnValue(System.Web.DynamicData.MetaColumn column) { return default(object); }
    [System.MonoTODOAttribute]
    protected void IgnoreModelValidationAttribute(System.Type attributeType) { }
    [System.MonoTODOAttribute]
    protected void PopulateListControl(System.Web.UI.WebControls.ListControl listControl) { }
    [System.MonoTODOAttribute]
    protected virtual void SetUpValidator(System.Web.UI.WebControls.BaseValidator validator) { }
    [System.MonoTODOAttribute]
    protected virtual void SetUpValidator(System.Web.UI.WebControls.BaseValidator validator, System.Web.DynamicData.MetaColumn column) { }
    void System.Web.DynamicData.IFieldTemplate.SetHost(System.Web.DynamicData.IFieldTemplateHost host) { }
    [System.MonoTODOAttribute]
    void System.Web.UI.IBindableControl.ExtractValues(System.Collections.Specialized.IOrderedDictionary dictionary) { }
  }
  [System.Web.UI.ParseChildrenAttribute(true)]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class FilterRepeater : System.Web.UI.WebControls.Repeater, System.Web.DynamicData.IWhereParametersProvider {
    public FilterRepeater() { }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.MonoTODOAttribute]
    [System.Web.UI.ThemeableAttribute(false)]
    public string ContextTypeName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute("DynamicFilter")]
    [System.MonoTODOAttribute]
    [System.Web.UI.IDReferencePropertyAttribute(typeof(System.Web.DynamicData.FilterUserControlBase))]
    [System.Web.UI.ThemeableAttribute(false)]
    public string DynamicFilterContainerId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public System.Web.DynamicData.MetaTable Table { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.DynamicData.MetaTable); } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.MonoTODOAttribute]
    [System.Web.UI.ThemeableAttribute(false)]
    public string TableName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public override bool Visible { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public override void DataBind() { }
    [System.MonoTODOAttribute]
    protected internal virtual System.Collections.Generic.IEnumerable<System.Web.DynamicData.MetaColumn> GetFilteredColumns() { return default(System.Collections.Generic.IEnumerable<System.Web.DynamicData.MetaColumn>); }
    [System.MonoTODOAttribute]
    public virtual System.Collections.Generic.IEnumerable<System.Web.UI.WebControls.Parameter> GetWhereParameters(System.Web.DynamicData.IDynamicDataSource dataSource) { return default(System.Collections.Generic.IEnumerable<System.Web.UI.WebControls.Parameter>); }
    [System.MonoTODOAttribute]
    protected virtual void OnFilterItemCreated(System.Web.UI.WebControls.RepeaterItem item) { }
    [System.MonoTODOAttribute]
    protected override void OnInit(System.EventArgs e) { }
    [System.MonoTODOAttribute]
    protected override void OnItemCreated(System.Web.UI.WebControls.RepeaterItemEventArgs e) { }
  }
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class FilterUserControlBase : System.Web.UI.UserControl, System.Web.DynamicData.IControlParameterTarget {
    public FilterUserControlBase() { }
    [System.MonoTODOAttribute]
    public System.Web.DynamicData.MetaColumn Column { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.DynamicData.MetaColumn); } }
    [System.MonoTODOAttribute]
    public string ContextTypeName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public string DataField { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public string InitialValue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    [System.MonoTODOAttribute]
    public virtual System.Web.UI.WebControls.DataKey SelectedDataKey { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.UI.WebControls.DataKey); } }
    [System.MonoTODOAttribute]
    public virtual string SelectedValue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    [System.MonoTODOAttribute]
    System.Web.DynamicData.MetaColumn System.Web.DynamicData.IControlParameterTarget.FilteredColumn { get { return default(System.Web.DynamicData.MetaColumn); } }
    [System.MonoTODOAttribute]
    System.Web.DynamicData.MetaTable System.Web.DynamicData.IControlParameterTarget.Table { get { return default(System.Web.DynamicData.MetaTable); } }
    [System.MonoTODOAttribute]
    public string TableName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public void PopulateListControl(System.Web.UI.WebControls.ListControl listControl) { }
    [System.MonoTODOAttribute]
    string System.Web.DynamicData.IControlParameterTarget.GetPropertyNameExpression(string columnName) { return default(string); }
  }
  [System.Web.AspNetHostingPermissionAttribute((System.Security.Permissions.SecurityAction)(6), Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute((System.Security.Permissions.SecurityAction)(7), Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial interface IControlParameterTarget {
    System.Web.DynamicData.MetaColumn FilteredColumn { get; }
    System.Web.DynamicData.MetaTable Table { get; }
    string GetPropertyNameExpression(string columnName);
  }
  [System.Web.AspNetHostingPermissionAttribute((System.Security.Permissions.SecurityAction)(6), Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute((System.Security.Permissions.SecurityAction)(7), Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial interface IFieldFormattingOptions {
    bool ApplyFormatInEditMode { get; }
    bool ConvertEmptyStringToNull { get; }
    string DataFormatString { get; }
    bool HtmlEncode { get; }
    string NullDisplayText { get; }
  }
  [System.Web.AspNetHostingPermissionAttribute((System.Security.Permissions.SecurityAction)(6), Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute((System.Security.Permissions.SecurityAction)(7), Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial interface IFieldTemplate {
    void SetHost(System.Web.DynamicData.IFieldTemplateHost host);
  }
  [System.Web.AspNetHostingPermissionAttribute((System.Security.Permissions.SecurityAction)(6), Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute((System.Security.Permissions.SecurityAction)(7), Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial interface IFieldTemplateFactory {
    System.Web.DynamicData.IFieldTemplate CreateFieldTemplate(System.Web.DynamicData.MetaColumn column, System.Web.UI.WebControls.DataBoundControlMode mode, string uiHint);
    void Initialize(System.Web.DynamicData.MetaModel model);
  }
  [System.Web.AspNetHostingPermissionAttribute((System.Security.Permissions.SecurityAction)(6), Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute((System.Security.Permissions.SecurityAction)(7), Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial interface IFieldTemplateHost {
    System.Web.DynamicData.MetaColumn Column { get; }
    System.Web.DynamicData.IFieldFormattingOptions FormattingOptions { get; }
    System.Web.UI.WebControls.DataBoundControlMode Mode { get; }
    string ValidationGroup { get; }
  }
  [System.Web.AspNetHostingPermissionAttribute((System.Security.Permissions.SecurityAction)(6), Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute((System.Security.Permissions.SecurityAction)(7), Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial interface IWhereParametersProvider {
    System.Collections.Generic.IEnumerable<System.Web.UI.WebControls.Parameter> GetWhereParameters(System.Web.DynamicData.IDynamicDataSource dataSource);
  }
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class MetaChildrenColumn : System.Web.DynamicData.MetaColumn {
    internal MetaChildrenColumn() { }
    [System.MonoTODOAttribute]
    public System.Web.DynamicData.MetaTable ChildTable { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.DynamicData.MetaTable); } }
    [System.MonoTODOAttribute]
    public System.Web.DynamicData.MetaColumn ColumnInOtherTable { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.DynamicData.MetaColumn); } }
    [System.MonoTODOAttribute]
    public string GetChildrenListPath(object row) { return default(string); }
    [System.MonoTODOAttribute]
    public string GetChildrenPath(string action, object row) { return default(string); }
    [System.MonoTODOAttribute]
    public string GetChildrenPath(string action, object row, string path) { return default(string); }
  }
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class MetaColumn : System.Web.DynamicData.IFieldFormattingOptions {
    internal MetaColumn() { }
    public bool ApplyFormatInEditMode { get { return default(bool); } }
    public System.ComponentModel.AttributeCollection Attributes { get { return default(System.ComponentModel.AttributeCollection); } }
    public System.Type ColumnType { get { return default(System.Type); } }
    public bool ConvertEmptyStringToNull { get { return default(bool); } }
    public string DataFormatString { get { return default(string); } }
    public System.ComponentModel.DataAnnotations.DataTypeAttribute DataTypeAttribute { get { return default(System.ComponentModel.DataAnnotations.DataTypeAttribute); } }
    public object DefaultValue { get { return default(object); } }
    public string Description { get { return default(string); } }
    public string DisplayName { get { return default(string); } }
    public System.Reflection.PropertyInfo EntityTypeProperty { get { return default(System.Reflection.PropertyInfo); } }
    public bool HtmlEncode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    public bool IsBinaryData { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    public bool IsCustomProperty { get { return default(bool); } }
    public bool IsFloatingPoint { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    public bool IsForeignKeyComponent { get { return default(bool); } }
    public bool IsGenerated { get { return default(bool); } }
    public bool IsInteger { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    public bool IsLongString { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    public bool IsPrimaryKey { get { return default(bool); } }
    public bool IsReadOnly { get { return default(bool); } }
    public bool IsRequired { get { return default(bool); } }
    public bool IsString { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    public int MaxLength { get { return default(int); } }
    public System.Web.DynamicData.MetaModel Model { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.DynamicData.MetaModel); } }
    public string Name { get { return default(string); } }
    public string NullDisplayText { get { return default(string); } }
    public System.Web.DynamicData.ModelProviders.ColumnProvider Provider { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.DynamicData.ModelProviders.ColumnProvider); } }
    public string RequiredErrorMessage { get { return default(string); } }
    public bool Scaffold { get { return default(bool); } set { } }
    public string SortExpression { get { return default(string); } }
    public System.Web.DynamicData.MetaTable Table { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.DynamicData.MetaTable); } }
    public System.TypeCode TypeCode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.TypeCode); } }
    public string UIHint { get { return default(string); } }
    public override string ToString() { return default(string); }
  }
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class MetaForeignKeyColumn : System.Web.DynamicData.MetaColumn {
    internal MetaForeignKeyColumn() { }
    [System.MonoTODOAttribute]
    public System.Collections.ObjectModel.ReadOnlyCollection<System.String> ForeignKeyNames { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.String>); } }
    [System.MonoTODOAttribute]
    public bool IsPrimaryKeyInThisTable { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    [System.MonoTODOAttribute]
    public System.Web.DynamicData.MetaTable ParentTable { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.DynamicData.MetaTable); } }
    [System.MonoTODOAttribute]
    public void ExtractForeignKey(System.Collections.IDictionary dictionary, string value) { }
    [System.MonoTODOAttribute]
    public string GetForeignKeyDetailsPath(object row) { return default(string); }
    [System.MonoTODOAttribute]
    public string GetForeignKeyPath(string action, object row) { return default(string); }
    [System.MonoTODOAttribute]
    public string GetForeignKeyPath(string action, object row, string path) { return default(string); }
    [System.MonoTODOAttribute]
    public string GetForeignKeyString(object row) { return default(string); }
    [System.MonoTODOAttribute]
    public System.Collections.Generic.IList<System.Object> GetForeignKeyValues(object row) { return default(System.Collections.Generic.IList<System.Object>); }
  }
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class MetaModel {
    public MetaModel() { }
    public static System.Web.DynamicData.MetaModel Default { get { return default(System.Web.DynamicData.MetaModel); } }
    public string DynamicDataFolderVirtualPath { get { return default(string); } set { } }
    public System.Web.DynamicData.IFieldTemplateFactory FieldTemplateFactory { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.DynamicData.IFieldTemplateFactory); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Web.DynamicData.MetaTable> Tables { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Web.DynamicData.MetaTable>); } }
    public System.Collections.Generic.List<System.Web.DynamicData.MetaTable> VisibleTables { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.List<System.Web.DynamicData.MetaTable>); } }
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
    public void RegisterContext(System.Web.DynamicData.ModelProviders.DataModelProvider dataModelProvider, System.Web.DynamicData.ContextConfiguration configuration) { }
    public static void ResetRegistrationException() { }
    public bool TryGetTable(string uniqueTableName, out System.Web.DynamicData.MetaTable table) { table = default(System.Web.DynamicData.MetaTable); return default(bool); }
  }
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class MetaTable {
    internal MetaTable() { }
    public System.ComponentModel.AttributeCollection Attributes { get { return default(System.ComponentModel.AttributeCollection); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Web.DynamicData.MetaColumn> Columns { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Web.DynamicData.MetaColumn>); } }
    public string DataContextPropertyName { get { return default(string); } }
    public System.Type DataContextType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } }
    public System.Web.DynamicData.MetaColumn DisplayColumn { get { return default(System.Web.DynamicData.MetaColumn); } }
    public string DisplayName { get { return default(string); } }
    public System.Type EntityType { get { return default(System.Type); } }
    public string ForeignKeyColumnsNames { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public bool HasPrimaryKey { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    public bool IsReadOnly { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    public string ListActionPath { get { return default(string); } }
    public System.Web.DynamicData.MetaModel Model { get { return default(System.Web.DynamicData.MetaModel); } }
    public string Name { get { return default(string); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Web.DynamicData.MetaColumn> PrimaryKeyColumns { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Web.DynamicData.MetaColumn>); } }
    public System.Web.DynamicData.ModelProviders.TableProvider Provider { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.DynamicData.ModelProviders.TableProvider); } }
    public bool Scaffold { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    public System.Web.DynamicData.MetaColumn SortColumn { get { return default(System.Web.DynamicData.MetaColumn); } }
    public bool SortDescending { get { return default(bool); } }
    public object CreateContext() { return default(object); }
    public string GetActionPath(string action) { return default(string); }
    public string GetActionPath(string action, System.Collections.Generic.IList<System.Object> primaryKeyValues) { return default(string); }
    public string GetActionPath(string action, System.Collections.Generic.IList<System.Object> primaryKeyValues, string path) { return default(string); }
    public string GetActionPath(string action, object row) { return default(string); }
    public string GetActionPath(string action, object row, string path) { return default(string); }
    public string GetActionPath(string action, System.Web.Routing.RouteValueDictionary routeValues) { return default(string); }
    public System.Web.DynamicData.MetaColumn GetColumn(string columnName) { return default(System.Web.DynamicData.MetaColumn); }
    public string GetDisplayString(object row) { return default(string); }
    public string GetPrimaryKeyString(System.Collections.Generic.IList<System.Object> primaryKeyValues) { return default(string); }
    public string GetPrimaryKeyString(object row) { return default(string); }
    public System.Collections.Generic.IList<System.Object> GetPrimaryKeyValues(object row) { return default(System.Collections.Generic.IList<System.Object>); }
    public System.Linq.IQueryable GetQuery() { return default(System.Linq.IQueryable); }
    public System.Linq.IQueryable GetQuery(object context) { return default(System.Linq.IQueryable); }
    public override string ToString() { return default(string); }
    public bool TryGetColumn(string columnName, out System.Web.DynamicData.MetaColumn column) { column = default(System.Web.DynamicData.MetaColumn); return default(bool); }
  }
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public static partial class PageAction {
    public static string Details { get { return default(string); } }
    public static string Edit { get { return default(string); } }
    public static string Insert { get { return default(string); } }
    public static string List { get { return default(string); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false)]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
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
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public abstract partial class AssociationProvider {
    protected AssociationProvider() { }
    [System.MonoTODOAttribute]
    public virtual System.Web.DynamicData.ModelProviders.AssociationDirection Direction { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.DynamicData.ModelProviders.AssociationDirection); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    [System.MonoTODOAttribute]
    public virtual System.Collections.ObjectModel.ReadOnlyCollection<System.String> ForeignKeyNames { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.String>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    [System.MonoTODOAttribute]
    public virtual System.Web.DynamicData.ModelProviders.ColumnProvider FromColumn { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.DynamicData.ModelProviders.ColumnProvider); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    [System.MonoTODOAttribute]
    public virtual bool IsPrimaryKeyInThisTable { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    [System.MonoTODOAttribute]
    public virtual System.Web.DynamicData.ModelProviders.ColumnProvider ToColumn { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.DynamicData.ModelProviders.ColumnProvider); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    [System.MonoTODOAttribute]
    public virtual System.Web.DynamicData.ModelProviders.TableProvider ToTable { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.DynamicData.ModelProviders.TableProvider); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    [System.MonoTODOAttribute]
    public virtual string GetSortExpression(System.Web.DynamicData.ModelProviders.ColumnProvider sortColumn) { return default(string); }
  }
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public abstract partial class ColumnProvider {
    protected ColumnProvider(System.Web.DynamicData.ModelProviders.TableProvider table) { }
    [System.MonoTODOAttribute]
    public virtual System.Web.DynamicData.ModelProviders.AssociationProvider Association { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.DynamicData.ModelProviders.AssociationProvider); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    [System.MonoTODOAttribute]
    public virtual System.Type ColumnType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    [System.MonoTODOAttribute]
    public virtual System.Reflection.PropertyInfo EntityTypeProperty { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Reflection.PropertyInfo); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    [System.MonoTODOAttribute]
    public virtual bool IsCustomProperty { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    [System.MonoTODOAttribute]
    public virtual bool IsForeignKeyComponent { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    [System.MonoTODOAttribute]
    public virtual bool IsGenerated { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    [System.MonoTODOAttribute]
    public virtual bool IsPrimaryKey { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    [System.MonoTODOAttribute]
    public virtual bool IsSortable { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    [System.MonoTODOAttribute]
    public virtual int MaxLength { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    [System.MonoTODOAttribute]
    public virtual string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    [System.MonoTODOAttribute]
    public virtual bool Nullable { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    [System.MonoTODOAttribute]
    public System.Web.DynamicData.ModelProviders.TableProvider Table { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.DynamicData.ModelProviders.TableProvider); } }
    [System.MonoTODOAttribute]
    public override string ToString() { return default(string); }
  }
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public abstract partial class DataModelProvider {
    protected DataModelProvider() { }
    [System.MonoTODOAttribute]
    public virtual System.Type ContextType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public abstract System.Collections.ObjectModel.ReadOnlyCollection<System.Web.DynamicData.ModelProviders.TableProvider> Tables { get; }
    public abstract object CreateContext();
  }
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public abstract partial class TableProvider {
    protected TableProvider(System.Web.DynamicData.ModelProviders.DataModelProvider model) { }
    public abstract System.Collections.ObjectModel.ReadOnlyCollection<System.Web.DynamicData.ModelProviders.ColumnProvider> Columns { get; }
    public System.Web.DynamicData.ModelProviders.DataModelProvider DataModel { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.DynamicData.ModelProviders.DataModelProvider); } }
    public virtual System.Type EntityType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public virtual string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public virtual object EvaluateForeignKey(object row, string foreignKeyName) { return default(object); }
    public abstract System.Linq.IQueryable GetQuery(object context);
    public override string ToString() { return default(string); }
  }
}
