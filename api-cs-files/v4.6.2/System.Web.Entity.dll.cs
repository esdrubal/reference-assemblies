namespace System.Web.UI.WebControls {
  [System.ComponentModel.DefaultEventAttribute("Selecting")]
  [System.ComponentModel.DefaultPropertyAttribute("EntitySetName")]
  [System.ComponentModel.DesignerAttribute("System.Web.UI.Design.WebControls.EntityDataSourceDesigner, System.Web.Entity.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Web.UI.WebControls.EntityDataSource), "EntityDataSource.ico")]
  [System.Web.UI.ParseChildrenAttribute(true)]
  [System.Web.UI.PersistChildrenAttribute(false)]
  [System.Web.UI.WebControls.ResourceDescriptionAttribute("EntityDataSource_Description")]
  [System.Web.UI.WebControls.ResourceDisplayNameAttribute("EntityDataSource_DisplayName")]
  public partial class EntityDataSource : System.Web.UI.DataSourceControl, System.Web.DynamicData.IDynamicDataSource, System.Web.UI.IDataSource, System.Web.UI.WebControls.IQueryableDataSource {
    public EntityDataSource() { }
    public EntityDataSource(System.Data.EntityClient.EntityConnection connection) { }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Web.UI.WebControls.ResourceDescriptionAttribute("PropertyDescription_AutoGenerateOrderByClause")]
    public bool AutoGenerateOrderByClause { get { return default(bool); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Web.UI.WebControls.ResourceDescriptionAttribute("PropertyDescription_AutoGenerateWhereClause")]
    public bool AutoGenerateWhereClause { get { return default(bool); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Web.UI.WebControls.ResourceDescriptionAttribute("PropertyDescription_AutoPage")]
    public bool AutoPage { get { return default(bool); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Web.UI.WebControls.ResourceDescriptionAttribute("PropertyDescription_AutoSort")]
    public bool AutoSort { get { return default(bool); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    public System.Web.UI.WebControls.ParameterCollection CommandParameters { get { return default(System.Web.UI.WebControls.ParameterCollection); } }
    public string CommandText { get { return default(string); } set { } }
    public string ConnectionString { get { return default(string); } set { } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Type ContextType { get { return default(System.Type); } set { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Web.UI.WebControls.ResourceDescriptionAttribute("PropertyDescription_ContextTypeName")]
    public string ContextTypeName { get { return default(string); } set { } }
    public string DefaultContainerName { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    public System.Web.UI.WebControls.ParameterCollection DeleteParameters { get { return default(System.Web.UI.WebControls.ParameterCollection); } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Web.UI.WebControls.ResourceDescriptionAttribute("PropertyDescription_EnableDelete")]
    public bool EnableDelete { get { return default(bool); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Web.UI.WebControls.ResourceDescriptionAttribute("PropertyDescription_EnableFlattening")]
    public bool EnableFlattening { get { return default(bool); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Web.UI.WebControls.ResourceDescriptionAttribute("PropertyDescription_EnableInsert")]
    public bool EnableInsert { get { return default(bool); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Web.UI.WebControls.ResourceDescriptionAttribute("PropertyDescription_EnableUpdate")]
    public bool EnableUpdate { get { return default(bool); } set { } }
    public string EntitySetName { get { return default(string); } set { } }
    public string EntityTypeFilter { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Web.UI.WebControls.ResourceDescriptionAttribute("PropertyDescription_GroupBy")]
    public string GroupBy { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Web.UI.WebControls.ResourceDescriptionAttribute("PropertyDescription_Include")]
    public string Include { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    public System.Web.UI.WebControls.ParameterCollection InsertParameters { get { return default(System.Web.UI.WebControls.ParameterCollection); } }
    public string OrderBy { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    public System.Web.UI.WebControls.ParameterCollection OrderByParameters { get { return default(System.Web.UI.WebControls.ParameterCollection); } }
    public string Select { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    public System.Web.UI.WebControls.ParameterCollection SelectParameters { get { return default(System.Web.UI.WebControls.ParameterCollection); } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Web.UI.WebControls.ResourceDescriptionAttribute("PropertyDescription_StoreOriginalValuesInViewState")]
    public bool StoreOriginalValuesInViewState { get { return default(bool); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    public System.Web.UI.WebControls.ParameterCollection UpdateParameters { get { return default(System.Web.UI.WebControls.ParameterCollection); } }
    public string Where { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    public System.Web.UI.WebControls.ParameterCollection WhereParameters { get { return default(System.Web.UI.WebControls.ParameterCollection); } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.Web.UI.WebControls.ResourceDescriptionAttribute("PropertyDescription_ContextCreated")]
    public event System.EventHandler<System.Web.UI.WebControls.EntityDataSourceContextCreatedEventArgs> ContextCreated { add { } remove { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.Web.UI.WebControls.ResourceDescriptionAttribute("PropertyDescription_ContextCreating")]
    public event System.EventHandler<System.Web.UI.WebControls.EntityDataSourceContextCreatingEventArgs> ContextCreating { add { } remove { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.Web.UI.WebControls.ResourceDescriptionAttribute("PropertyDescription_ContextDisposing")]
    public event System.EventHandler<System.Web.UI.WebControls.EntityDataSourceContextDisposingEventArgs> ContextDisposing { add { } remove { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.Web.UI.WebControls.ResourceDescriptionAttribute("PropertyDescription_Deleted")]
    public event System.EventHandler<System.Web.UI.WebControls.EntityDataSourceChangedEventArgs> Deleted { add { } remove { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.Web.UI.WebControls.ResourceDescriptionAttribute("PropertyDescription_Deleting")]
    public event System.EventHandler<System.Web.UI.WebControls.EntityDataSourceChangingEventArgs> Deleting { add { } remove { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.Web.UI.WebControls.ResourceDescriptionAttribute("PropertyDescription_Inserted")]
    public event System.EventHandler<System.Web.UI.WebControls.EntityDataSourceChangedEventArgs> Inserted { add { } remove { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.Web.UI.WebControls.ResourceDescriptionAttribute("PropertyDescription_Inserting")]
    public event System.EventHandler<System.Web.UI.WebControls.EntityDataSourceChangingEventArgs> Inserting { add { } remove { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.Web.UI.WebControls.ResourceDescriptionAttribute("PropertyDescription_QueryCreated")]
    public event System.EventHandler<System.Web.UI.WebControls.QueryCreatedEventArgs> QueryCreated { add { } remove { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.Web.UI.WebControls.ResourceDescriptionAttribute("PropertyDescription_Selected")]
    public event System.EventHandler<System.Web.UI.WebControls.EntityDataSourceSelectedEventArgs> Selected { add { } remove { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.Web.UI.WebControls.ResourceDescriptionAttribute("PropertyDescription_Selecting")]
    public event System.EventHandler<System.Web.UI.WebControls.EntityDataSourceSelectingEventArgs> Selecting { add { } remove { } }
    event System.EventHandler<System.Web.DynamicData.DynamicValidatorEventArgs> System.Web.DynamicData.IDynamicDataSource.Exception { add { } remove { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.Web.UI.WebControls.ResourceDescriptionAttribute("PropertyDescription_Updated")]
    public event System.EventHandler<System.Web.UI.WebControls.EntityDataSourceChangedEventArgs> Updated { add { } remove { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.Web.UI.WebControls.ResourceDescriptionAttribute("PropertyDescription_Updating")]
    public event System.EventHandler<System.Web.UI.WebControls.EntityDataSourceChangingEventArgs> Updating { add { } remove { } }
    protected virtual System.Web.UI.WebControls.EntityDataSourceView CreateView() { return default(System.Web.UI.WebControls.EntityDataSourceView); }
    protected override System.Web.UI.DataSourceView GetView(string viewName) { return default(System.Web.UI.DataSourceView); }
    protected override System.Collections.ICollection GetViewNames() { return default(System.Collections.ICollection); }
    protected override void LoadControlState(object savedState) { }
    protected override void OnInit(System.EventArgs e) { }
    protected override void OnUnload(System.EventArgs e) { }
    protected override object SaveControlState() { return default(object); }
    void System.Web.UI.WebControls.IQueryableDataSource.RaiseViewChanged() { }
    protected override void TrackViewState() { }
  }
  public partial class EntityDataSourceChangedEventArgs : System.EventArgs {
    internal EntityDataSourceChangedEventArgs() { }
    public System.Data.Objects.ObjectContext Context { get { return default(System.Data.Objects.ObjectContext); } }
    public object Entity { get { return default(object); } }
    public System.Exception Exception { get { return default(System.Exception); } }
    public bool ExceptionHandled { get { return default(bool); } set { } }
  }
  public partial class EntityDataSourceChangingEventArgs : System.ComponentModel.CancelEventArgs {
    internal EntityDataSourceChangingEventArgs() { }
    public System.Data.Objects.ObjectContext Context { get { return default(System.Data.Objects.ObjectContext); } }
    public object Entity { get { return default(object); } }
    public System.Exception Exception { get { return default(System.Exception); } }
    public bool ExceptionHandled { get { return default(bool); } set { } }
  }
  public partial class EntityDataSourceContextCreatedEventArgs : System.EventArgs {
    internal EntityDataSourceContextCreatedEventArgs() { }
    public System.Data.Objects.ObjectContext Context { get { return default(System.Data.Objects.ObjectContext); } }
  }
  public partial class EntityDataSourceContextCreatingEventArgs : System.EventArgs {
    internal EntityDataSourceContextCreatingEventArgs() { }
    public System.Data.Objects.ObjectContext Context { get { return default(System.Data.Objects.ObjectContext); } set { } }
  }
  public partial class EntityDataSourceContextDisposingEventArgs : System.ComponentModel.CancelEventArgs {
    internal EntityDataSourceContextDisposingEventArgs() { }
    public System.Data.Objects.ObjectContext Context { get { return default(System.Data.Objects.ObjectContext); } }
  }
  public partial class EntityDataSourceSelectedEventArgs : System.EventArgs {
    internal EntityDataSourceSelectedEventArgs() { }
    public System.Data.Objects.ObjectContext Context { get { return default(System.Data.Objects.ObjectContext); } }
    public System.Exception Exception { get { return default(System.Exception); } }
    public bool ExceptionHandled { get { return default(bool); } set { } }
    public System.Collections.IEnumerable Results { get { return default(System.Collections.IEnumerable); } }
    public System.Web.UI.DataSourceSelectArguments SelectArguments { get { return default(System.Web.UI.DataSourceSelectArguments); } }
    public int TotalRowCount { get { return default(int); } }
  }
  public partial class EntityDataSourceSelectingEventArgs : System.ComponentModel.CancelEventArgs {
    internal EntityDataSourceSelectingEventArgs() { }
    public System.Web.UI.WebControls.EntityDataSource DataSource { get { return default(System.Web.UI.WebControls.EntityDataSource); } }
    public System.Web.UI.DataSourceSelectArguments SelectArguments { get { return default(System.Web.UI.DataSourceSelectArguments); } }
  }
  public sealed partial class EntityDataSourceValidationException : System.Exception, System.Web.DynamicData.IDynamicValidatorException {
    public EntityDataSourceValidationException() { }
    public EntityDataSourceValidationException(string message) { }
    public EntityDataSourceValidationException(string message, System.Exception innerException) { }
    System.Collections.Generic.IDictionary<System.String, System.Exception> System.Web.DynamicData.IDynamicValidatorException.InnerExceptions { get { return default(System.Collections.Generic.IDictionary<System.String, System.Exception>); } }
  }
  public partial class EntityDataSourceView : System.Web.UI.DataSourceView, System.Web.UI.IStateManager {
    public EntityDataSourceView(System.Web.UI.WebControls.EntityDataSource owner, string viewName) : base (default(System.Web.UI.IDataSource), default(string)) { }
    public override bool CanDelete { get { return default(bool); } }
    public override bool CanInsert { get { return default(bool); } }
    public override bool CanPage { get { return default(bool); } }
    public override bool CanRetrieveTotalRowCount { get { return default(bool); } }
    public override bool CanSort { get { return default(bool); } }
    public override bool CanUpdate { get { return default(bool); } }
    bool System.Web.UI.IStateManager.IsTrackingViewState { get { return default(bool); } }
    public event System.EventHandler<System.Web.UI.WebControls.EntityDataSourceContextCreatedEventArgs> ContextCreated { add { } remove { } }
    public event System.EventHandler<System.Web.UI.WebControls.EntityDataSourceContextCreatingEventArgs> ContextCreating { add { } remove { } }
    public event System.EventHandler<System.Web.UI.WebControls.EntityDataSourceContextDisposingEventArgs> ContextDisposing { add { } remove { } }
    public event System.EventHandler<System.Web.UI.WebControls.EntityDataSourceChangedEventArgs> Deleted { add { } remove { } }
    public event System.EventHandler<System.Web.UI.WebControls.EntityDataSourceChangingEventArgs> Deleting { add { } remove { } }
    public event System.EventHandler<System.Web.DynamicData.DynamicValidatorEventArgs> Exception { add { } remove { } }
    public event System.EventHandler<System.Web.UI.WebControls.EntityDataSourceChangedEventArgs> Inserted { add { } remove { } }
    public event System.EventHandler<System.Web.UI.WebControls.EntityDataSourceChangingEventArgs> Inserting { add { } remove { } }
    [System.CLSCompliantAttribute(false)]
    public event System.EventHandler<System.Web.UI.WebControls.QueryCreatedEventArgs> QueryCreated { add { } remove { } }
    public event System.EventHandler<System.Web.UI.WebControls.EntityDataSourceSelectedEventArgs> Selected { add { } remove { } }
    public event System.EventHandler<System.Web.UI.WebControls.EntityDataSourceSelectingEventArgs> Selecting { add { } remove { } }
    public event System.EventHandler<System.Web.UI.WebControls.EntityDataSourceChangedEventArgs> Updated { add { } remove { } }
    public event System.EventHandler<System.Web.UI.WebControls.EntityDataSourceChangingEventArgs> Updating { add { } remove { } }
    protected override int ExecuteDelete(System.Collections.IDictionary keys, System.Collections.IDictionary oldValues) { return default(int); }
    protected override int ExecuteInsert(System.Collections.IDictionary values) { return default(int); }
    protected override System.Collections.IEnumerable ExecuteSelect(System.Web.UI.DataSourceSelectArguments arguments) { return default(System.Collections.IEnumerable); }
    protected override int ExecuteUpdate(System.Collections.IDictionary keys, System.Collections.IDictionary values, System.Collections.IDictionary oldValues) { return default(int); }
    public System.Data.DataTable GetViewSchema() { return default(System.Data.DataTable); }
    void System.Web.UI.IStateManager.LoadViewState(object savedState) { }
    object System.Web.UI.IStateManager.SaveViewState() { return default(object); }
    void System.Web.UI.IStateManager.TrackViewState() { }
  }
}
