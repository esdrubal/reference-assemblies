namespace System.Web.Mobile {
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class CookielessData : System.Collections.Specialized.HybridDictionary {
    public CookielessData() { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  public sealed partial class DeviceFilterElement : System.Configuration.ConfigurationElement {
    public DeviceFilterElement(string name, string compareName, string argument) { }
    public DeviceFilterElement(string name, System.Type filterClass, string method) { }
    [System.Configuration.ConfigurationPropertyAttribute("argument")]
    [System.Configuration.StringValidatorAttribute(MinLength=1)]
    public string Argument { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("compare")]
    [System.Configuration.StringValidatorAttribute(MinLength=1)]
    public string Compare { get { return default(string); } set { } }
    protected override System.Configuration.ConfigurationElementProperty ElementProperty { get { return default(System.Configuration.ConfigurationElementProperty); } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.MobileControls.MobileTypeNameConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("type")]
    public System.Type FilterClass { get { return default(System.Type); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("method")]
    [System.Configuration.StringValidatorAttribute(MinLength=1)]
    public string Method { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("name", IsRequired=true, IsKey=true)]
    [System.Configuration.StringValidatorAttribute(MinLength=1)]
    public string Name { get { return default(string); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.Web.Mobile.DeviceFilterElement), AddItemName="filter", CollectionType=(System.Configuration.ConfigurationElementCollectionType)(0))]
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  public sealed partial class DeviceFilterElementCollection : System.Configuration.ConfigurationElementCollection {
    public DeviceFilterElementCollection() { }
    public System.Object[] AllKeys { get { return default(System.Object[]); } }
    public override System.Configuration.ConfigurationElementCollectionType CollectionType { get { return default(System.Configuration.ConfigurationElementCollectionType); } }
    protected override string ElementName { get { return default(string); } }
    public System.Web.Mobile.DeviceFilterElement this[int index] { get { return default(System.Web.Mobile.DeviceFilterElement); } set { } }
    public new System.Web.Mobile.DeviceFilterElement this[string name] { get { return default(System.Web.Mobile.DeviceFilterElement); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    public void Add(System.Web.Mobile.DeviceFilterElement deviceFilter) { }
    public void Clear() { }
    protected override System.Configuration.ConfigurationElement CreateNewElement() { return default(System.Configuration.ConfigurationElement); }
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
    public void Remove(string name) { }
    public void Remove(System.Web.Mobile.DeviceFilterElement deviceFilter) { }
    public void RemoveAt(int index) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  public sealed partial class DeviceFiltersSection : System.Configuration.ConfigurationSection {
    public DeviceFiltersSection() { }
    [System.Configuration.ConfigurationPropertyAttribute("", IsDefaultCollection=true)]
    public System.Web.Mobile.DeviceFilterElementCollection Filters { get { return default(System.Web.Mobile.DeviceFilterElementCollection); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class ErrorHandlerModule : System.Web.IHttpModule {
    public ErrorHandlerModule() { }
    void System.Web.IHttpModule.Dispose() { }
    void System.Web.IHttpModule.Init(System.Web.HttpApplication application) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class MobileCapabilities : System.Web.HttpBrowserCapabilities {
    public static readonly string PreferredRenderingTypeChtml10;
    public static readonly string PreferredRenderingTypeHtml32;
    public static readonly string PreferredRenderingTypeWml11;
    public static readonly string PreferredRenderingTypeWml12;
    public MobileCapabilities() { }
    public bool HasCapability(string delegateName, string optionalParameter) { return default(bool); }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class MobileDeviceCapabilitiesSectionHandler : System.Configuration.IConfigurationSectionHandler {
    public MobileDeviceCapabilitiesSectionHandler() { }
    protected object Create(object parent, object context, System.Xml.XmlNode node) { return default(object); }
    object System.Configuration.IConfigurationSectionHandler.Create(object parent, object context, System.Xml.XmlNode node) { return default(object); }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class MobileErrorInfo {
    internal MobileErrorInfo() { }
    public static readonly string ContextKey;
    public string Description { get { return default(string); } set { } }
    public string File { get { return default(string); } set { } }
    public string this[string key] { get { return default(string); } set { } }
    public string LineNumber { get { return default(string); } set { } }
    public string MiscText { get { return default(string); } set { } }
    public string MiscTitle { get { return default(string); } set { } }
    public string Type { get { return default(string); } set { } }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class MobileFormsAuthentication {
    internal MobileFormsAuthentication() { }
    public static void RedirectFromLoginPage(string userName, bool createPersistentCookie) { }
    public static void RedirectFromLoginPage(string userName, bool createPersistentCookie, string strCookiePath) { }
    public static void SignOut() { }
  }
}
namespace System.Web.UI.Design.MobileControls {
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  public partial interface IMobileDesigner {
    void UpdateRendering();
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  public partial interface IMobileWebFormServices {
    void ClearUndoStack();
    object GetCache(string controlID, object key);
    void RefreshPageView();
    void SetCache(string controlID, object key, object value);
    void UpdateRenderingRecursive(System.Web.UI.Control rootControl);
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public sealed partial class MobileResource {
    internal MobileResource() { }
    public static string GetString(string name) { return default(string); }
  }
}
namespace System.Web.UI.Design.MobileControls.Converters {
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class DataFieldConverter : System.ComponentModel.TypeConverter {
    public DataFieldConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { return default(System.ComponentModel.TypeConverter.StandardValuesCollection); }
    public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class DataMemberConverter : System.ComponentModel.TypeConverter {
    public DataMemberConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { return default(System.ComponentModel.TypeConverter.StandardValuesCollection); }
    public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
  }
}
namespace System.Web.UI.MobileControls {
  [System.ComponentModel.DefaultEventAttribute("AdCreated")]
  [System.ComponentModel.DefaultPropertyAttribute("AdvertisementFile")]
  [System.ComponentModel.DesignerAttribute(typeof(System.Web.UI.Design.MobileControls.AdRotatorDesigner))]
  [System.ComponentModel.ToolboxItemAttribute(typeof(System.Web.UI.Design.WebControlToolboxItem))]
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.UI.MobileControls.DesignerAdapterAttribute(typeof(System.Web.UI.Design.MobileControls.Adapters.DesignerAdRotatorAdapter))]
  [System.Web.UI.ToolboxDataAttribute("<{0}:AdRotator runat=\"server\"></{0}:AdRotator>")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class AdRotator : System.Web.UI.MobileControls.MobileControl {
    public AdRotator() { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute(typeof(System.Web.UI.Design.XmlUrlEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Behavior")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("AdRotator_AdvertisementFile")]
    public string AdvertisementFile { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("ImageUrl")]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Behavior")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("AdRotator_ImageKey")]
    public string ImageKey { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Behavior")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("AdRotator_KeywordFilter")]
    public string KeywordFilter { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("NavigateUrl")]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Behavior")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("AdRotator_NavigateUrlKey")]
    public string NavigateUrlKey { get { return default(string); } set { } }
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Action")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("AdRotator_AdCreated")]
    public event System.Web.UI.WebControls.AdCreatedEventHandler AdCreated { add { } remove { } }
    protected virtual System.Web.UI.WebControls.AdRotator CreateWebAdRotator() { return default(System.Web.UI.WebControls.AdRotator); }
    protected virtual void OnAdCreated(System.Web.UI.WebControls.AdCreatedEventArgs e) { }
    protected override void Render(System.Web.UI.HtmlTextWriter writer) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  public enum Alignment {
    Center = 2,
    Left = 1,
    NotSet = 0,
    Right = 3,
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class ArrayListCollectionBase : System.Collections.ICollection, System.Collections.IEnumerable {
    internal ArrayListCollectionBase() { }
    public int Count { get { return default(int); } }
    public bool IsReadOnly { get { return default(bool); } }
    public bool IsSynchronized { get { return default(bool); } }
    protected System.Collections.ArrayList Items { get { return default(System.Collections.ArrayList); } set { } }
    public object SyncRoot { get { return default(object); } }
    public void CopyTo(System.Array array, int index) { }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  [System.ComponentModel.DefaultPropertyAttribute("ErrorMessage")]
  [System.ComponentModel.DesignerAttribute(typeof(System.Web.UI.Design.MobileControls.BaseValidatorDesigner))]
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.UI.DataBindingHandlerAttribute("System.Web.UI.Design.TextDataBindingHandler, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [System.Web.UI.MobileControls.DesignerAdapterAttribute(typeof(System.Web.UI.Design.MobileControls.Adapters.DesignerValidatorAdapter))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public abstract partial class BaseValidator : System.Web.UI.MobileControls.TextControl, System.Web.UI.IValidator {
    protected BaseValidator() { }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.Design.MobileControls.Converters.ValidatedMobileControlConverter))]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Behavior")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("BaseValidator_ControlToValidate")]
    public string ControlToValidate { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.WebControls.ValidatorDisplay)(2))]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Appearance")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("BaseValidator_Display")]
    public System.Web.UI.WebControls.ValidatorDisplay Display { get { return default(System.Web.UI.WebControls.ValidatorDisplay); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Appearance")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("BaseValidator_ErrorMessage")]
    public string ErrorMessage { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public bool IsValid { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute("error")]
    public override string StyleReference { get { return default(string); } set { } }
    public override int VisibleWeight { get { return default(int); } }
    protected void CheckControlValidationProperty(string name, string propertyName) { }
    protected virtual bool ControlPropertiesValid() { return default(bool); }
    protected override System.Web.UI.MobileControls.Style CreateStyle() { return default(System.Web.UI.MobileControls.Style); }
    protected virtual System.Web.UI.WebControls.BaseValidator CreateWebValidator() { return default(System.Web.UI.WebControls.BaseValidator); }
    protected abstract bool EvaluateIsValid();
    protected override void OnInit(System.EventArgs e) { }
    protected override void OnPreRender(System.EventArgs e) { }
    public void Validate() { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  public enum BooleanOption {
    False = 0,
    NotSet = -1,
    True = 1,
  }
  [System.ComponentModel.DefaultEventAttribute("SelectionChanged")]
  [System.ComponentModel.DefaultPropertyAttribute("SelectedDate")]
  [System.ComponentModel.DesignerAttribute(typeof(System.Web.UI.Design.MobileControls.CalendarDesigner))]
  [System.ComponentModel.ToolboxItemAttribute("System.Web.UI.Design.WebControlToolboxItem, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.UI.DataBindingHandlerAttribute(typeof(System.Web.UI.Design.MobileControls.CalendarDataBindingHandler))]
  [System.Web.UI.MobileControls.DesignerAdapterAttribute(typeof(System.Web.UI.Design.MobileControls.Adapters.DesignerCalendarAdapter))]
  [System.Web.UI.ToolboxDataAttribute("<{0}:Calendar runat=\"server\"></{0}:Calendar>")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class Calendar : System.Web.UI.MobileControls.MobileControl, System.Web.UI.IPostBackEventHandler {
    public Calendar() { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Appearance")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("Calendar_CalendarEntryText")]
    public string CalendarEntryText { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.WebControls.FirstDayOfWeek)(7))]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Appearance")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("Calendar_FirstDayOfWeek")]
    public System.Web.UI.WebControls.FirstDayOfWeek FirstDayOfWeek { get { return default(System.Web.UI.WebControls.FirstDayOfWeek); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.DateTime), "1/1/0001")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("Calendar_SelectedDate")]
    public System.DateTime SelectedDate { get { return default(System.DateTime); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Web.UI.WebControls.SelectedDatesCollection SelectedDates { get { return default(System.Web.UI.WebControls.SelectedDatesCollection); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.WebControls.CalendarSelectionMode)(1))]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Behavior")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("Calendar_SelectionMode")]
    public System.Web.UI.WebControls.CalendarSelectionMode SelectionMode { get { return default(System.Web.UI.WebControls.CalendarSelectionMode); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Appearance")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("Calendar_ShowDayHeader")]
    public bool ShowDayHeader { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.DateTime), "1/1/0001")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("Calendar_VisibleDate")]
    public System.DateTime VisibleDate { get { return default(System.DateTime); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Web.UI.WebControls.Calendar WebCalendar { get { return default(System.Web.UI.WebControls.Calendar); } }
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Action")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("Calendar_OnSelectionChanged")]
    public event System.EventHandler SelectionChanged { add { } remove { } }
    protected virtual System.Web.UI.WebControls.Calendar CreateWebCalendar() { return default(System.Web.UI.WebControls.Calendar); }
    protected virtual void OnSelectionChanged() { }
    protected void RaisePostBackEvent(string eventArgument) { }
    public void RaiseSelectionChangedEvent() { }
    void System.Web.UI.IPostBackEventHandler.RaisePostBackEvent(string eventArgument) { }
  }
  [System.ComponentModel.DefaultEventAttribute("Click")]
  [System.ComponentModel.DefaultPropertyAttribute("Text")]
  [System.ComponentModel.DesignerAttribute(typeof(System.Web.UI.Design.MobileControls.CommandDesigner))]
  [System.ComponentModel.ToolboxItemAttribute("System.Web.UI.Design.WebControlToolboxItem, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.UI.DataBindingHandlerAttribute("System.Web.UI.Design.TextDataBindingHandler, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [System.Web.UI.MobileControls.DesignerAdapterAttribute(typeof(System.Web.UI.Design.MobileControls.Adapters.DesignerCommandAdapter))]
  [System.Web.UI.ToolboxDataAttribute("<{0}:Command runat=\"server\">Command</{0}:Command>")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class Command : System.Web.UI.MobileControls.TextControl, System.Web.UI.IPostBackDataHandler, System.Web.UI.IPostBackEventHandler {
    public Command() { }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Behavior")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("Command_CausesValidation")]
    public bool CausesValidation { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Behavior")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("Command_CommandArgument")]
    public string CommandArgument { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Behavior")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("Command_CommandName")]
    public string CommandName { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.MobileControls.CommandFormat)(0))]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Appearance")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("Command_Format")]
    public System.Web.UI.MobileControls.CommandFormat Format { get { return default(System.Web.UI.MobileControls.CommandFormat); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute(typeof(System.Web.UI.Design.MobileControls.ImageUrlEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Appearance")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("Image_ImageUrl")]
    public string ImageUrl { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Behavior")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("Command_SoftkeyLabel")]
    public string SoftkeyLabel { get { return default(string); } set { } }
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Action")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("Command_OnClick")]
    public event System.EventHandler Click { add { } remove { } }
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Action")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("Command_OnItemCommand")]
    public event System.Web.UI.WebControls.CommandEventHandler ItemCommand { add { } remove { } }
    protected override bool IsFormSubmitControl() { return default(bool); }
    protected bool LoadPostData(string key, System.Collections.Specialized.NameValueCollection data) { return default(bool); }
    protected virtual void OnClick(System.EventArgs e) { }
    protected virtual void OnItemCommand(System.Web.UI.WebControls.CommandEventArgs e) { }
    protected override void OnPreRender(System.EventArgs e) { }
    protected void RaisePostBackEvent(string argument) { }
    protected void RaisePostDataChangedEvent() { }
    bool System.Web.UI.IPostBackDataHandler.LoadPostData(string key, System.Collections.Specialized.NameValueCollection data) { return default(bool); }
    void System.Web.UI.IPostBackDataHandler.RaisePostDataChangedEvent() { }
    void System.Web.UI.IPostBackEventHandler.RaisePostBackEvent(string eventArgument) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  public enum CommandFormat {
    Button = 0,
    Link = 1,
  }
  [System.ComponentModel.ToolboxItemAttribute("System.Web.UI.Design.WebControlToolboxItem, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.UI.ToolboxDataAttribute("<{0}:CompareValidator runat=\"server\" ErrorMessage=\"CompareValidator\"></{0}:CompareValidator>")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class CompareValidator : System.Web.UI.MobileControls.BaseValidator {
    public CompareValidator() { }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.Design.MobileControls.Converters.ValidatedMobileControlConverter))]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Behavior")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("CompareValidator_ControlToCompare")]
    public string ControlToCompare { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.WebControls.ValidationCompareOperator)(0))]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Behavior")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("CompareValidator_Operator")]
    public System.Web.UI.WebControls.ValidationCompareOperator Operator { get { return default(System.Web.UI.WebControls.ValidationCompareOperator); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.WebControls.ValidationDataType)(0))]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Behavior")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("CompareValidator_Type")]
    public System.Web.UI.WebControls.ValidationDataType Type { get { return default(System.Web.UI.WebControls.ValidationDataType); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Behavior")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("CompareValidator_ValueToCompare")]
    public string ValueToCompare { get { return default(string); } set { } }
    protected override bool ControlPropertiesValid() { return default(bool); }
    protected override System.Web.UI.WebControls.BaseValidator CreateWebValidator() { return default(System.Web.UI.WebControls.BaseValidator); }
    protected override bool EvaluateIsValid() { return default(bool); }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class Constants {
    public static readonly string AlternatingItemTemplateTag;
    public static readonly string ContentTemplateTag;
    public static readonly int DefaultSessionsStateHistorySize;
    public static readonly string EventArgumentID;
    public static readonly string EventSourceID;
    public static readonly string FooterTemplateTag;
    public static readonly string FormIDPrefix;
    public static readonly string HeaderTemplateTag;
    public static readonly string ItemDetailsTemplateTag;
    public static readonly string ItemTemplateTag;
    public static readonly string LabelTemplateTag;
    public static readonly string OptimumPageWeightParameter;
    public static readonly string PagePrefix;
    public static readonly string ScreenCharactersHeightParameter;
    public static readonly string ScriptTemplateTag;
    public static readonly char SelectionListSpecialCharacter;
    public static readonly string SeparatorTemplateTag;
    public static readonly string SymbolProtocol;
    public static readonly string UniqueFilePathSuffixVariable;
    public static readonly string UniqueFilePathSuffixVariableWithoutEqual;
    public Constants() { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  public sealed partial class ControlElement : System.Configuration.ConfigurationElement {
    public ControlElement(string name, System.Type adapter) { }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.MobileControls.MobileTypeNameConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("adapter", IsRequired=true)]
    [System.Configuration.SubclassTypeValidatorAttribute(typeof(System.Web.UI.MobileControls.IControlAdapter))]
    public System.Type Adapter { get { return default(System.Type); } set { } }
    public System.Type Control { get { return default(System.Type); } set { } }
    protected override System.Configuration.ConfigurationElementProperty ElementProperty { get { return default(System.Configuration.ConfigurationElementProperty); } }
    [System.Configuration.ConfigurationPropertyAttribute("name", IsRequired=true, IsKey=true)]
    [System.Configuration.StringValidatorAttribute(MinLength=1)]
    public string Name { get { return default(string); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.Web.UI.MobileControls.ControlElement), AddItemName="control")]
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  public sealed partial class ControlElementCollection : System.Configuration.ConfigurationElementCollection {
    public ControlElementCollection() { }
    public System.Object[] AllKeys { get { return default(System.Object[]); } }
    public override System.Configuration.ConfigurationElementCollectionType CollectionType { get { return default(System.Configuration.ConfigurationElementCollectionType); } }
    protected override string ElementName { get { return default(string); } }
    public System.Web.UI.MobileControls.ControlElement this[int index] { get { return default(System.Web.UI.MobileControls.ControlElement); } set { } }
    public new System.Web.UI.MobileControls.ControlElement this[string name] { get { return default(System.Web.UI.MobileControls.ControlElement); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    protected override bool ThrowOnDuplicate { get { return default(bool); } }
    public void Add(System.Web.UI.MobileControls.ControlElement controlElement) { }
    public void Clear() { }
    protected override System.Configuration.ConfigurationElement CreateNewElement() { return default(System.Configuration.ConfigurationElement); }
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
    public void Remove(string name) { }
    public void Remove(System.Web.UI.MobileControls.ControlElement controlElement) { }
    public void RemoveAt(int index) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class ControlPager {
    public static readonly int DefaultWeight;
    public static readonly int UseDefaultWeight;
    public ControlPager(System.Web.UI.MobileControls.Form form, int pageWeight) { }
    public int PageCount { get { return default(int); } set { } }
    public int PageWeight { get { return default(int); } }
    public int RemainingWeight { get { return default(int); } set { } }
    public System.Web.UI.MobileControls.ItemPager GetItemPager(System.Web.UI.MobileControls.MobileControl control, int itemCount, int itemsPerPage, int itemWeight) { return default(System.Web.UI.MobileControls.ItemPager); }
    public int GetPage(int weight) { return default(int); }
  }
  [System.ComponentModel.DefaultEventAttribute("ServerValidate")]
  [System.ComponentModel.ToolboxItemAttribute("System.Web.UI.Design.WebControlToolboxItem, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.UI.ToolboxDataAttribute("<{0}:CustomValidator runat=\"server\" ErrorMessage=\"CustomValidator\"></{0}:CustomValidator>")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class CustomValidator : System.Web.UI.MobileControls.BaseValidator {
    public CustomValidator() { }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("CustomValidator_OnServerValidate")]
    public event System.Web.UI.WebControls.ServerValidateEventHandler ServerValidate { add { } remove { } }
    protected override bool ControlPropertiesValid() { return default(bool); }
    protected override System.Web.UI.WebControls.BaseValidator CreateWebValidator() { return default(System.Web.UI.WebControls.BaseValidator); }
    protected override bool EvaluateIsValid() { return default(bool); }
    protected virtual bool OnServerValidate(string value) { return default(bool); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), Inherited=true)]
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class DesignerAdapterAttribute : System.Attribute {
    public DesignerAdapterAttribute(string adapterTypeName) { }
    public DesignerAdapterAttribute(System.Type adapterType) { }
    public virtual string TypeName { get { return default(string); } }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  public sealed partial class DeviceElement : System.Configuration.ConfigurationElement {
    public DeviceElement(string name, string inheritsFrom) { }
    public DeviceElement(string name, string inheritsFrom, System.Type predicateClass, string predicateMethod, System.Type pageAdapter) { }
    public DeviceElement(string name, System.Type predicateClass, string predicateMethod, System.Type pageAdapter) { }
    [System.Configuration.ConfigurationPropertyAttribute("", IsDefaultCollection=true)]
    public System.Web.UI.MobileControls.ControlElementCollection Controls { get { return default(System.Web.UI.MobileControls.ControlElementCollection); } }
    protected override System.Configuration.ConfigurationElementProperty ElementProperty { get { return default(System.Configuration.ConfigurationElementProperty); } }
    [System.Configuration.ConfigurationPropertyAttribute("inheritsFrom")]
    [System.Configuration.StringValidatorAttribute(MinLength=1)]
    public string InheritsFrom { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("name", IsRequired=true, IsKey=true)]
    [System.Configuration.StringValidatorAttribute(MinLength=1)]
    public string Name { get { return default(string); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.MobileControls.MobileTypeNameConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("pageAdapter")]
    [System.Configuration.SubclassTypeValidatorAttribute(typeof(System.Web.UI.MobileControls.IPageAdapter))]
    public System.Type PageAdapter { get { return default(System.Type); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.MobileControls.MobileTypeNameConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("predicateClass")]
    public System.Type PredicateClass { get { return default(System.Type); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("predicateMethod")]
    [System.Configuration.StringValidatorAttribute(MinLength=1)]
    public string PredicateMethod { get { return default(string); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.Web.UI.MobileControls.DeviceElement), AddItemName="device")]
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  public sealed partial class DeviceElementCollection : System.Configuration.ConfigurationElementCollection {
    public DeviceElementCollection() { }
    public System.Object[] AllKeys { get { return default(System.Object[]); } }
    public override System.Configuration.ConfigurationElementCollectionType CollectionType { get { return default(System.Configuration.ConfigurationElementCollectionType); } }
    protected override string ElementName { get { return default(string); } }
    public System.Web.UI.MobileControls.DeviceElement this[int index] { get { return default(System.Web.UI.MobileControls.DeviceElement); } set { } }
    public new System.Web.UI.MobileControls.DeviceElement this[string name] { get { return default(System.Web.UI.MobileControls.DeviceElement); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    protected override bool ThrowOnDuplicate { get { return default(bool); } }
    public void Add(System.Web.UI.MobileControls.DeviceElement deviceElement) { }
    public void Clear() { }
    protected override System.Configuration.ConfigurationElement CreateNewElement() { return default(System.Configuration.ConfigurationElement); }
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
    public void Remove(string name) { }
    public void Remove(System.Web.UI.MobileControls.DeviceElement deviceElement) { }
    public void RemoveAt(int index) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class DeviceOverridableAttribute : System.Attribute {
    public DeviceOverridableAttribute() { }
    public DeviceOverridableAttribute(bool overridable) { }
    public bool Overridable { get { return default(bool); } }
  }
  [System.ComponentModel.DesignerAttribute(typeof(System.Web.UI.Design.MobileControls.DeviceSpecificDesigner))]
  [System.ComponentModel.ToolboxItemFilterAttribute("System.Web.UI")]
  [System.ComponentModel.ToolboxItemFilterAttribute("System.Web.UI.MobileControls", (System.ComponentModel.ToolboxItemFilterType)(3))]
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.UI.ControlBuilderAttribute(typeof(System.Web.UI.MobileControls.DeviceSpecificControlBuilder))]
  [System.Web.UI.MobileControls.PersistNameAttribute("DeviceSpecific")]
  [System.Web.UI.ParseChildrenAttribute(false)]
  [System.Web.UI.PersistChildrenAttribute(false)]
  [System.Web.UI.ToolboxDataAttribute("<{0}:DeviceSpecific runat=\"server\"></{0}:DeviceSpecific>")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class DeviceSpecific : System.Web.UI.Control {
    public DeviceSpecific() { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(2))]
    public System.Web.UI.MobileControls.DeviceSpecificChoiceCollection Choices { get { return default(System.Web.UI.MobileControls.DeviceSpecificChoiceCollection); } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public override bool EnableViewState { get { return default(bool); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public bool HasTemplates { get { return default(bool); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Web.UI.MobileControls.MobilePage MobilePage { get { return default(System.Web.UI.MobileControls.MobilePage); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public object Owner { get { return default(object); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Web.UI.MobileControls.DeviceSpecificChoice SelectedChoice { get { return default(System.Web.UI.MobileControls.DeviceSpecificChoice); } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public override bool Visible { get { return default(bool); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public new event System.EventHandler DataBinding { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public new event System.EventHandler Disposed { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public new event System.EventHandler Init { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public new event System.EventHandler Load { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public new event System.EventHandler PreRender { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public new event System.EventHandler Unload { add { } remove { } }
    protected override void AddParsedSubObject(object obj) { }
    public System.Web.UI.ITemplate GetTemplate(string templateName) { return default(System.Web.UI.ITemplate); }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.UI.ControlBuilderAttribute(typeof(System.Web.UI.MobileControls.DeviceSpecificChoiceControlBuilder))]
  [System.Web.UI.MobileControls.PersistNameAttribute("Choice")]
  [System.Web.UI.PersistChildrenAttribute(false)]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class DeviceSpecificChoice : System.Web.UI.IAttributeAccessor, System.Web.UI.IParserAccessor {
    public DeviceSpecificChoice() { }
    public string Argument { get { return default(string); } set { } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    public System.Collections.IDictionary Contents { get { return default(System.Collections.IDictionary); } }
    [System.ComponentModel.DefaultValueAttribute("")]
    public string Filter { get { return default(string); } set { } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public bool HasTemplates { get { return default(bool); } }
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    public System.Collections.IDictionary Templates { get { return default(System.Collections.IDictionary); } }
    [System.ComponentModel.DefaultValueAttribute("")]
    public string Xmlns { get { return default(string); } set { } }
    protected void AddParsedSubObject(object obj) { }
    protected string GetAttribute(string key) { return default(string); }
    protected void SetAttribute(string key, string value) { }
    string System.Web.UI.IAttributeAccessor.GetAttribute(string name) { return default(string); }
    void System.Web.UI.IAttributeAccessor.SetAttribute(string name, string value) { }
    void System.Web.UI.IParserAccessor.AddParsedSubObject(object obj) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class DeviceSpecificChoiceCollection : System.Web.UI.MobileControls.ArrayListCollectionBase {
    internal DeviceSpecificChoiceCollection() { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(2))]
    public System.Collections.ArrayList All { get { return default(System.Collections.ArrayList); } }
    public System.Web.UI.MobileControls.DeviceSpecificChoice this[int index] { get { return default(System.Web.UI.MobileControls.DeviceSpecificChoice); } }
    public void Add(System.Web.UI.MobileControls.DeviceSpecificChoice choice) { }
    public void AddAt(int index, System.Web.UI.MobileControls.DeviceSpecificChoice choice) { }
    public void Clear() { }
    public void Remove(System.Web.UI.MobileControls.DeviceSpecificChoice choice) { }
    public void RemoveAt(int index) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class DeviceSpecificChoiceControlBuilder : System.Web.UI.ControlBuilder {
    public DeviceSpecificChoiceControlBuilder() { }
    public override void AppendLiteralString(string text) { }
    public override void AppendSubBuilder(System.Web.UI.ControlBuilder subBuilder) { }
    public override System.Type GetChildControlType(string tagName, System.Collections.IDictionary attributes) { return default(System.Type); }
    public override void Init(System.Web.UI.TemplateParser parser, System.Web.UI.ControlBuilder parentBuilder, System.Type type, string tagName, string id, System.Collections.IDictionary attributes) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class DeviceSpecificChoiceTemplateBuilder : System.Web.UI.TemplateBuilder {
    public DeviceSpecificChoiceTemplateBuilder() { }
    public override void AppendLiteralString(string text) { }
    public override void AppendSubBuilder(System.Web.UI.ControlBuilder subBuilder) { }
    public override void Init(System.Web.UI.TemplateParser parser, System.Web.UI.ControlBuilder parentBuilder, System.Type type, string tagName, string id, System.Collections.IDictionary attributes) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class DeviceSpecificChoiceTemplateContainer {
    public DeviceSpecificChoiceTemplateContainer() { }
    public string Name { get { return default(string); } set { } }
    [System.Web.UI.FilterableAttribute(false)]
    [System.Web.UI.TemplateContainerAttribute(typeof(System.Web.UI.MobileControls.TemplateContainer))]
    public System.Web.UI.ITemplate Template { get { return default(System.Web.UI.ITemplate); } set { } }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class DeviceSpecificControlBuilder : System.Web.UI.ControlBuilder {
    public DeviceSpecificControlBuilder() { }
    public override void AppendLiteralString(string text) { }
    public override System.Type GetChildControlType(string tagName, System.Collections.IDictionary attributes) { return default(System.Type); }
  }
  [System.ComponentModel.ToolboxItemAttribute(false)]
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class ErrorFormatterPage : System.Web.UI.MobileControls.MobilePage {
    public ErrorFormatterPage() { }
    protected System.Web.Mobile.MobileErrorInfo ErrorInfo { get { return default(System.Web.Mobile.MobileErrorInfo); } }
    protected virtual void InitContent() { }
    protected override object LoadPageStateFromPersistenceMedium() { return default(object); }
    protected override void OnInit(System.EventArgs e) { }
    protected override void SavePageStateToPersistenceMedium(object viewState) { }
  }
  [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.ExpandableObjectConverter))]
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class FontInfo {
    internal FontInfo() { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.MobileControls.BooleanOption)(-1))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Appearance")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("FontInfo_Bold")]
    public System.Web.UI.MobileControls.BooleanOption Bold { get { return default(System.Web.UI.MobileControls.BooleanOption); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.MobileControls.BooleanOption)(-1))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Appearance")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("FontInfo_Italic")]
    public System.Web.UI.MobileControls.BooleanOption Italic { get { return default(System.Web.UI.MobileControls.BooleanOption); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute(typeof(System.Drawing.Design.FontNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.Design.MobileControls.Converters.FontNameConverter))]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Appearance")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("FontInfo_Name")]
    public string Name { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.MobileControls.FontSize)(0))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Appearance")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("FontInfo_Size")]
    public System.Web.UI.MobileControls.FontSize Size { get { return default(System.Web.UI.MobileControls.FontSize); } set { } }
    public override string ToString() { return default(string); }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  public enum FontSize {
    Large = 3,
    Normal = 1,
    NotSet = 0,
    Small = 2,
  }
  [System.ComponentModel.DefaultEventAttribute("Activate")]
  [System.ComponentModel.DesignerAttribute(typeof(System.Web.UI.Design.MobileControls.FormDesigner))]
  [System.ComponentModel.ToolboxItemAttribute("System.Web.UI.Design.WebControlToolboxItem, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.UI.ControlBuilderAttribute(typeof(System.Web.UI.MobileControls.FormControlBuilder))]
  [System.Web.UI.MobileControls.DesignerAdapterAttribute(typeof(System.Web.UI.MobileControls.Adapters.HtmlFormAdapter))]
  [System.Web.UI.PersistChildrenAttribute(true)]
  [System.Web.UI.ToolboxDataAttribute("<{0}:Form runat=\"server\"></{0}:Form>")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class Form : System.Web.UI.MobileControls.Panel, System.Web.UI.IPostBackEventHandler, System.Web.UI.MobileControls.ITemplateable {
    public Form() { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute(typeof(System.Web.UI.Design.UrlEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Behavior")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("Form_Action")]
    public string Action { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override bool BreakAfter { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Web.UI.Control ControlToPaginate { get { return default(System.Web.UI.Control); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public int CurrentPage { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Web.UI.MobileControls.Panel Footer { get { return default(System.Web.UI.MobileControls.Panel); } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Web.UI.MobileControls.Panel Header { get { return default(System.Web.UI.MobileControls.Panel); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.MobileControls.FormMethod)(1))]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Behavior")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("Form_Method")]
    public System.Web.UI.MobileControls.FormMethod Method { get { return default(System.Web.UI.MobileControls.FormMethod); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public int PageCount { get { return default(int); } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Style")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("Form_PagerStyle")]
    public System.Web.UI.MobileControls.PagerStyle PagerStyle { get { return default(System.Web.UI.MobileControls.PagerStyle); } }
    protected override bool PaginateChildren { get { return default(bool); } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Web.UI.MobileControls.Panel Script { get { return default(System.Web.UI.MobileControls.Panel); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Appearance")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("Form_Title")]
    public string Title { get { return default(string); } set { } }
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Action")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("Form_OnActivate")]
    public event System.EventHandler Activate { add { } remove { } }
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Action")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("Form_OnDeactivate")]
    public event System.EventHandler Deactivate { add { } remove { } }
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Action")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("Form_OnPaginated")]
    public event System.EventHandler Paginated { add { } remove { } }
    public override void CreateDefaultTemplatedUI(bool doDataBind) { }
    public System.Collections.IList GetLinkedForms(int optimumPageWeight) { return default(System.Collections.IList); }
    public virtual bool HasActivateHandler() { return default(bool); }
    public virtual bool HasDeactivateHandler() { return default(bool); }
    protected override void LoadPrivateViewState(object state) { }
    protected virtual void OnActivate(System.EventArgs e) { }
    protected override void OnDataBinding(System.EventArgs e) { }
    protected virtual void OnDeactivate(System.EventArgs e) { }
    protected override void OnInit(System.EventArgs e) { }
    protected virtual void OnPaginated(System.EventArgs e) { }
    protected override void OnPreRender(System.EventArgs e) { }
    public override void PaginateRecursive(System.Web.UI.MobileControls.ControlPager pager) { }
    protected void RaisePostBackEvent(string eventArgument) { }
    protected override void Render(System.Web.UI.HtmlTextWriter writer) { }
    protected override object SavePrivateViewState() { return default(object); }
    void System.Web.UI.IPostBackEventHandler.RaisePostBackEvent(string eventArgument) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class FormControlBuilder : System.Web.UI.MobileControls.LiteralTextContainerControlBuilder {
    public FormControlBuilder() { }
    public override void AppendSubBuilder(System.Web.UI.ControlBuilder subBuilder) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  public enum FormMethod {
    Get = 0,
    Post = 1,
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial interface IControlAdapter {
    System.Web.UI.MobileControls.MobileControl Control { get; set; }
    int ItemWeight { get; }
    System.Web.UI.MobileControls.MobilePage Page { get; }
    int VisibleWeight { get; }
    void CreateTemplatedUI(bool doDataBind);
    bool HandlePostBackEvent(string eventArgument);
    void LoadAdapterState(object state);
    bool LoadPostData(string postDataKey, System.Collections.Specialized.NameValueCollection postCollection, object controlPrivateData, out bool dataChanged);
    void OnInit(System.EventArgs e);
    void OnLoad(System.EventArgs e);
    void OnPreRender(System.EventArgs e);
    void OnUnload(System.EventArgs e);
    void Render(System.Web.UI.HtmlTextWriter writer);
    object SaveAdapterState();
  }
  [System.ComponentModel.DefaultPropertyAttribute("ImageUrl")]
  [System.ComponentModel.DesignerAttribute(typeof(System.Web.UI.Design.MobileControls.ImageDesigner))]
  [System.ComponentModel.ToolboxItemAttribute(typeof(System.Web.UI.Design.WebControlToolboxItem))]
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.UI.MobileControls.DesignerAdapterAttribute(typeof(System.Web.UI.Design.MobileControls.Adapters.DesignerImageAdapter))]
  [System.Web.UI.ToolboxDataAttribute("<{0}:Image runat=\"server\"></{0}:Image>")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class Image : System.Web.UI.MobileControls.MobileControl, System.Web.UI.IPostBackEventHandler {
    public Image() { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Appearance")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("Image_AlternateText")]
    public string AlternateText { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute(typeof(System.Web.UI.Design.MobileControls.ImageUrlEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Appearance")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("Image_ImageUrl")]
    public string ImageUrl { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.Design.MobileControls.Converters.NavigateUrlConverter))]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Navigation")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("Image_NavigateUrl")]
    public string NavigateUrl { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Behavior")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("Image_SoftkeyLabel")]
    public string SoftkeyLabel { get { return default(string); } set { } }
    protected void RaisePostBackEvent(string argument) { }
    void System.Web.UI.IPostBackEventHandler.RaisePostBackEvent(string eventArgument) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial interface IObjectListFieldCollection : System.Collections.ICollection, System.Collections.IEnumerable {
    System.Web.UI.MobileControls.ObjectListField this[int index] { get; }
    System.Web.UI.MobileControls.ObjectListField[] GetAll();
    int IndexOf(string fieldIDOrTitle);
    int IndexOf(System.Web.UI.MobileControls.ObjectListField field);
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial interface IPageAdapter : System.Web.UI.MobileControls.IControlAdapter {
    System.Collections.IList CacheVaryByHeaders { get; }
    System.Collections.IDictionary CookielessDataDictionary { get; set; }
    int OptimumPageWeight { get; }
    new System.Web.UI.MobileControls.MobilePage Page { get; set; }
    bool PersistCookielessData { get; set; }
    System.Web.UI.HtmlTextWriter CreateTextWriter(System.IO.TextWriter writer);
    System.Collections.Specialized.NameValueCollection DeterminePostBackMode(System.Web.HttpRequest request, string postEventSourceID, string postEventArgumentID, System.Collections.Specialized.NameValueCollection baseCollection);
    bool HandleError(System.Exception e, System.Web.UI.HtmlTextWriter writer);
    bool HandlePagePostBackEvent(string eventSource, string eventArgument);
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class ItemPager {
    public ItemPager() { }
    public ItemPager(System.Web.UI.MobileControls.ControlPager pager, System.Web.UI.MobileControls.MobileControl control, int itemCount, int itemsPerPage, int itemWeight) { }
    public int ItemCount { get { return default(int); } }
    public int ItemIndex { get { return default(int); } }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial interface ITemplateable {
  }
  [System.ComponentModel.DefaultPropertyAttribute("Text")]
  [System.ComponentModel.DesignerAttribute(typeof(System.Web.UI.Design.MobileControls.LabelDesigner))]
  [System.ComponentModel.ToolboxItemAttribute("System.Web.UI.Design.WebControlToolboxItem, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.UI.DataBindingHandlerAttribute("System.Web.UI.Design.TextDataBindingHandler, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [System.Web.UI.MobileControls.DesignerAdapterAttribute(typeof(System.Web.UI.Design.MobileControls.Adapters.DesignerLabelAdapter))]
  [System.Web.UI.ToolboxDataAttribute("<{0}:Label runat=\"server\">Label</{0}:Label>")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class Label : System.Web.UI.MobileControls.TextControl {
    public Label() { }
  }
  [System.ComponentModel.DefaultPropertyAttribute("Text")]
  [System.ComponentModel.DesignerAttribute(typeof(System.Web.UI.Design.MobileControls.LinkDesigner))]
  [System.ComponentModel.ToolboxItemAttribute("System.Web.UI.Design.WebControlToolboxItem, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.UI.DataBindingHandlerAttribute("System.Web.UI.Design.TextDataBindingHandler, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [System.Web.UI.MobileControls.DesignerAdapterAttribute(typeof(System.Web.UI.Design.MobileControls.Adapters.DesignerLinkAdapter))]
  [System.Web.UI.ToolboxDataAttribute("<{0}:Link runat=server>Link</{0}:Link>")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class Link : System.Web.UI.MobileControls.TextControl, System.Web.UI.IPostBackEventHandler {
    public Link() { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.Design.MobileControls.Converters.NavigateUrlConverter))]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Navigation")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("Link_NavigateUrl")]
    public string NavigateUrl { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Behavior")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("Link_SoftkeyLabel")]
    public string SoftkeyLabel { get { return default(string); } set { } }
    public override void AddLinkedForms(System.Collections.IList linkedForms) { }
    protected void RaisePostBackEvent(string argument) { }
    void System.Web.UI.IPostBackEventHandler.RaisePostBackEvent(string eventArgument) { }
  }
  [System.ComponentModel.DefaultEventAttribute("ItemCommand")]
  [System.ComponentModel.DefaultPropertyAttribute("DataSource")]
  [System.ComponentModel.DesignerAttribute(typeof(System.Web.UI.Design.MobileControls.ListDesigner))]
  [System.ComponentModel.EditorAttribute(typeof(System.Web.UI.Design.MobileControls.ListComponentEditor), typeof(System.ComponentModel.ComponentEditor))]
  [System.ComponentModel.ToolboxItemAttribute("System.Web.UI.Design.WebControlToolboxItem, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.UI.ControlBuilderAttribute(typeof(System.Web.UI.MobileControls.ListControlBuilder))]
  [System.Web.UI.MobileControls.DesignerAdapterAttribute(typeof(System.Web.UI.Design.MobileControls.Adapters.DesignerListAdapter))]
  [System.Web.UI.ToolboxDataAttribute("<{0}:List runat=\"server\"></{0}:List>")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class List : System.Web.UI.MobileControls.PagedControl, System.Web.UI.INamingContainer, System.Web.UI.IPostBackEventHandler, System.Web.UI.MobileControls.ITemplateable {
    public List() { }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.Design.MobileControls.Converters.DataMemberConverter))]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Data")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("List_DataMember")]
    public virtual string DataMember { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Data")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("List_DataSource")]
    public virtual object DataSource { get { return default(object); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.Design.MobileControls.Converters.DataFieldConverter))]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Data")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("List_DataTextField")]
    public string DataTextField { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.Design.MobileControls.Converters.DataFieldConverter))]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Data")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("List_DataValueField")]
    public string DataValueField { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.MobileControls.ListDecoration)(0))]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Appearance")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("List_Decoration")]
    public System.Web.UI.MobileControls.ListDecoration Decoration { get { return default(System.Web.UI.MobileControls.ListDecoration); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public bool HasItemCommandHandler { get { return default(bool); } }
    protected override int InternalItemCount { get { return default(int); } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.EditorAttribute(typeof(System.Web.UI.Design.MobileControls.ItemCollectionEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("List_Items")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(2))]
    public System.Web.UI.MobileControls.MobileListItemCollection Items { get { return default(System.Web.UI.MobileControls.MobileListItemCollection); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Behavior")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("List_ItemsAsLinks")]
    public bool ItemsAsLinks { get { return default(bool); } set { } }
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Action")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("List_OnItemCommand")]
    public event System.Web.UI.MobileControls.ListCommandEventHandler ItemCommand { add { } remove { } }
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Action")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("List_OnItemDataBind")]
    public event System.Web.UI.MobileControls.ListDataBindEventHandler ItemDataBind { add { } remove { } }
    protected override void AddParsedSubObject(object obj) { }
    protected override void CreateChildControls() { }
    public override void CreateDefaultTemplatedUI(bool doDataBind) { }
    protected virtual void CreateItems(System.Collections.IEnumerable dataSource) { }
    protected override void EnsureChildControls() { }
    public override void EnsureTemplatedUI() { }
    protected override void LoadViewState(object savedState) { }
    protected override bool OnBubbleEvent(object sender, System.EventArgs e) { return default(bool); }
    protected override void OnDataBinding(System.EventArgs e) { }
    protected virtual void OnItemCommand(System.Web.UI.MobileControls.ListCommandEventArgs e) { }
    protected virtual void OnItemDataBind(System.Web.UI.MobileControls.ListDataBindEventArgs e) { }
    protected override void OnLoadItems(System.Web.UI.MobileControls.LoadItemsEventArgs e) { }
    protected override void OnPageChange(int oldPageIndex, int newPageIndex) { }
    protected override void OnPreRender(System.EventArgs e) { }
    protected void RaisePostBackEvent(string eventArgument) { }
    protected override object SaveViewState() { return default(object); }
    void System.Web.UI.IPostBackEventHandler.RaisePostBackEvent(string eventArgument) { }
    protected override void TrackViewState() { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class ListCommandEventArgs : System.Web.UI.WebControls.CommandEventArgs {
    protected static readonly string DefaultCommand;
    public ListCommandEventArgs(System.Web.UI.MobileControls.MobileListItem item, object commandSource) : base (default(System.Web.UI.WebControls.CommandEventArgs)) { }
    public ListCommandEventArgs(System.Web.UI.MobileControls.MobileListItem item, object commandSource, System.Web.UI.WebControls.CommandEventArgs originalArgs) : base (default(System.Web.UI.WebControls.CommandEventArgs)) { }
    public object CommandSource { get { return default(object); } }
    public System.Web.UI.MobileControls.MobileListItem ListItem { get { return default(System.Web.UI.MobileControls.MobileListItem); } }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  public delegate void ListCommandEventHandler(object sender, System.Web.UI.MobileControls.ListCommandEventArgs e);
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class ListControlBuilder : System.Web.UI.MobileControls.MobileControlBuilder {
    public ListControlBuilder() { }
    public override System.Type GetChildControlType(string tagName, System.Collections.IDictionary attributes) { return default(System.Type); }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class ListDataBindEventArgs : System.EventArgs {
    public ListDataBindEventArgs(System.Web.UI.MobileControls.MobileListItem item, object dataItem) { }
    public object DataItem { get { return default(object); } }
    public System.Web.UI.MobileControls.MobileListItem ListItem { get { return default(System.Web.UI.MobileControls.MobileListItem); } }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  public delegate void ListDataBindEventHandler(object sender, System.Web.UI.MobileControls.ListDataBindEventArgs e);
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  public enum ListDecoration {
    Bulleted = 1,
    None = 0,
    Numbered = 2,
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  public enum ListSelectType {
    CheckBox = 4,
    DropDown = 0,
    ListBox = 1,
    MultiSelectListBox = 3,
    Radio = 2,
  }
  [System.ComponentModel.ToolboxItemAttribute(false)]
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class LiteralLink : System.Web.UI.MobileControls.Link {
    public LiteralLink() { }
  }
  [System.ComponentModel.ToolboxItemAttribute(false)]
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.UI.ControlBuilderAttribute(typeof(System.Web.UI.MobileControls.LiteralTextControlBuilder))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class LiteralText : System.Web.UI.MobileControls.PagedControl {
    public LiteralText() { }
    protected override int InternalItemCount { get { return default(int); } }
    protected override int ItemWeight { get { return default(int); } }
    public string PagedText { get { return default(string); } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    public string Text { get { return default(string); } set { } }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class LiteralTextContainerControlBuilder : System.Web.UI.MobileControls.MobileControlBuilder {
    internal LiteralTextContainerControlBuilder() { }
    public override void AppendLiteralString(string text) { }
    public override void AppendSubBuilder(System.Web.UI.ControlBuilder subBuilder) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class LiteralTextControlBuilder : System.Web.UI.MobileControls.MobileControlBuilder {
    public LiteralTextControlBuilder() { }
    public override bool AllowWhitespaceLiterals() { return default(bool); }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class LoadItemsEventArgs : System.EventArgs {
    public LoadItemsEventArgs(int index, int count) { }
    public int ItemCount { get { return default(int); } }
    public int ItemIndex { get { return default(int); } }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  public delegate void LoadItemsEventHandler(object sender, System.Web.UI.MobileControls.LoadItemsEventArgs e);
  [System.ComponentModel.DesignerAttribute(typeof(System.Web.UI.Design.MobileControls.MobileControlDesigner))]
  [System.ComponentModel.ToolboxItemAttribute(false)]
  [System.ComponentModel.ToolboxItemFilterAttribute("System.Web.UI")]
  [System.ComponentModel.ToolboxItemFilterAttribute("System.Web.UI.MobileControls", (System.ComponentModel.ToolboxItemFilterType)(3))]
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.UI.ControlBuilderAttribute(typeof(System.Web.UI.MobileControls.MobileControlBuilder))]
  [System.Web.UI.ParseChildrenAttribute(false)]
  [System.Web.UI.PersistChildrenAttribute(false)]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public abstract partial class MobileControl : System.Web.UI.Control, System.Web.UI.IAttributeAccessor {
    protected MobileControl() { }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public new System.Web.UI.MobileControls.IControlAdapter Adapter { get { return default(System.Web.UI.MobileControls.IControlAdapter); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.MobileControls.Alignment)(0))]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Appearance")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("MobileControl_Alignment")]
    public virtual System.Web.UI.MobileControls.Alignment Alignment { get { return default(System.Web.UI.MobileControls.Alignment); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.WebControls.WebColorConverter))]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Appearance")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("MobileControl_BackColor")]
    public virtual System.Drawing.Color BackColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Behavior")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("MobileControl_BreakAfter")]
    public virtual bool BreakAfter { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Web.UI.StateBag CustomAttributes { get { return default(System.Web.UI.StateBag); } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    public System.Web.UI.MobileControls.DeviceSpecific DeviceSpecific { get { return default(System.Web.UI.MobileControls.DeviceSpecific); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public sealed override bool EnableTheming { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public int FirstPage { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Appearance")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("MobileControl_Font")]
    public virtual System.Web.UI.MobileControls.FontInfo Font { get { return default(System.Web.UI.MobileControls.FontInfo); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.WebControls.WebColorConverter))]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Appearance")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("Style_ForeColor")]
    public virtual System.Drawing.Color ForeColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Web.UI.MobileControls.Form Form { get { return default(System.Web.UI.MobileControls.Form); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    protected string InnerText { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public virtual bool IsTemplated { get { return default(bool); } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public int LastPage { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Web.UI.MobileControls.MobilePage MobilePage { get { return default(System.Web.UI.MobileControls.MobilePage); } }
    protected virtual bool PaginateChildren { get { return default(bool); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public sealed override string SkinID { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    protected internal virtual System.Web.UI.MobileControls.Style Style { get { return default(System.Web.UI.MobileControls.Style); } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.Design.MobileControls.Converters.StyleReferenceConverter))]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Appearance")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("MobileControl_StyleReference")]
    public virtual string StyleReference { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public virtual int VisibleWeight { get { return default(int); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.MobileControls.Wrapping)(0))]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Appearance")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("MobileControl_Wrapping")]
    public virtual System.Web.UI.MobileControls.Wrapping Wrapping { get { return default(System.Web.UI.MobileControls.Wrapping); } set { } }
    protected override void AddedControl(System.Web.UI.Control control, int index) { }
    public virtual void AddLinkedForms(System.Collections.IList linkedForms) { }
    protected override void AddParsedSubObject(object obj) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public sealed override void ApplyStyleSheetSkin(System.Web.UI.Page page) { }
    public virtual void CreateDefaultTemplatedUI(bool doDataBind) { }
    protected virtual System.Web.UI.MobileControls.Style CreateStyle() { return default(System.Web.UI.MobileControls.Style); }
    protected virtual void CreateTemplatedUI(bool doDataBind) { }
    public virtual void EnsureTemplatedUI() { }
    protected string GetAttribute(string name) { return default(string); }
    public virtual System.Web.UI.ITemplate GetTemplate(string templateName) { return default(System.Web.UI.ITemplate); }
    protected virtual bool IsFormSubmitControl() { return default(bool); }
    public bool IsVisibleOnPage(int pageNumber) { return default(bool); }
    protected virtual void LoadPrivateViewState(object state) { }
    protected override void LoadViewState(object savedState) { }
    protected override void OnDataBinding(System.EventArgs e) { }
    protected override void OnInit(System.EventArgs e) { }
    protected override void OnLoad(System.EventArgs e) { }
    protected virtual void OnPageChange(int oldPageIndex, int newPageIndex) { }
    protected override void OnPreRender(System.EventArgs e) { }
    protected virtual void OnRender(System.Web.UI.HtmlTextWriter writer) { }
    protected override void OnUnload(System.EventArgs e) { }
    public virtual void PaginateRecursive(System.Web.UI.MobileControls.ControlPager pager) { }
    protected override void RemovedControl(System.Web.UI.Control control) { }
    protected override void Render(System.Web.UI.HtmlTextWriter writer) { }
    public new void RenderChildren(System.Web.UI.HtmlTextWriter writer) { }
    public System.Web.UI.MobileControls.Form ResolveFormReference(string formID) { return default(System.Web.UI.MobileControls.Form); }
    public new string ResolveUrl(string relativeUrl) { return default(string); }
    protected virtual object SavePrivateViewState() { return default(object); }
    protected override object SaveViewState() { return default(object); }
    protected void SetAttribute(string name, string value) { }
    string System.Web.UI.IAttributeAccessor.GetAttribute(string name) { return default(string); }
    void System.Web.UI.IAttributeAccessor.SetAttribute(string name, string value) { }
    protected override void TrackViewState() { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class MobileControlBuilder : System.Web.UI.ControlBuilder {
    public MobileControlBuilder() { }
    public override bool AllowWhitespaceLiterals() { return default(bool); }
    public override System.Type GetChildControlType(string tagName, System.Collections.IDictionary attributes) { return default(System.Type); }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  public sealed partial class MobileControlsSection : System.Configuration.ConfigurationSection {
    public MobileControlsSection() { }
    [System.Configuration.ConfigurationPropertyAttribute("allowCustomAttributes", DefaultValue=false)]
    public bool AllowCustomAttributes { get { return default(bool); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.MobileControls.MobileTypeNameConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("cookielessDataDictionaryType", DefaultValue=typeof(System.Web.Mobile.CookielessData))]
    [System.Configuration.SubclassTypeValidatorAttribute(typeof(System.Collections.IDictionary))]
    public System.Type CookielessDataDictionaryType { get { return default(System.Type); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("", IsDefaultCollection=true)]
    public System.Web.UI.MobileControls.DeviceElementCollection Devices { get { return default(System.Web.UI.MobileControls.DeviceElementCollection); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("sessionStateHistorySize", DefaultValue=6)]
    [System.Configuration.IntegerValidatorAttribute(MinValue=0)]
    public int SessionStateHistorySize { get { return default(int); } set { } }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class MobileControlsSectionHandler : System.Configuration.IConfigurationSectionHandler {
    public MobileControlsSectionHandler() { }
    protected object Create(object parent, object context, System.Xml.XmlNode input) { return default(object); }
    object System.Configuration.IConfigurationSectionHandler.Create(object parent, object context, System.Xml.XmlNode input) { return default(object); }
  }
  [System.ComponentModel.ToolboxItemAttribute(false)]
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.UI.MobileControls.PersistNameAttribute("Item")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class MobileListItem : System.Web.UI.MobileControls.TemplateContainer, System.Web.UI.IStateManager {
    public MobileListItem() { }
    public MobileListItem(object dataItem, string text, string value) { }
    public MobileListItem(string text) { }
    public MobileListItem(string text, string value) { }
    public MobileListItem(System.Web.UI.MobileControls.MobileListItemType itemType) { }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public object DataItem { get { return default(object); } set { } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public int Index { get { return default(int); } }
    protected new bool IsTrackingViewState { get { return default(bool); } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool Selected { get { return default(bool); } set { } }
    bool System.Web.UI.IStateManager.IsTrackingViewState { get { return default(bool); } }
    [System.ComponentModel.DefaultValueAttribute("")]
    public string Text { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    public string Value { get { return default(string); } set { } }
    public override bool Equals(object o) { return default(bool); }
    public static System.Web.UI.MobileControls.MobileListItem FromString(string s) { return default(System.Web.UI.MobileControls.MobileListItem); }
    public override int GetHashCode() { return default(int); }
    protected new void LoadViewState(object state) { }
    protected override bool OnBubbleEvent(object source, System.EventArgs e) { return default(bool); }
    public static implicit operator System.Web.UI.MobileControls.MobileListItem (string s) { return default(System.Web.UI.MobileControls.MobileListItem); }
    protected new object SaveViewState() { return default(object); }
    void System.Web.UI.IStateManager.LoadViewState(object state) { }
    object System.Web.UI.IStateManager.SaveViewState() { return default(object); }
    void System.Web.UI.IStateManager.TrackViewState() { }
    public override string ToString() { return default(string); }
    protected new void TrackViewState() { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class MobileListItemCollection : System.Web.UI.MobileControls.ArrayListCollectionBase, System.Web.UI.IStateManager {
    public MobileListItemCollection() { }
    public MobileListItemCollection(System.Collections.ArrayList items) { }
    protected bool IsTrackingViewState { get { return default(bool); } }
    public System.Web.UI.MobileControls.MobileListItem this[int index] { get { return default(System.Web.UI.MobileControls.MobileListItem); } }
    bool System.Web.UI.IStateManager.IsTrackingViewState { get { return default(bool); } }
    public virtual void Add(string item) { }
    public void Add(System.Web.UI.MobileControls.MobileListItem item) { }
    public void Clear() { }
    public bool Contains(System.Web.UI.MobileControls.MobileListItem item) { return default(bool); }
    public System.Web.UI.MobileControls.MobileListItem[] GetAll() { return default(System.Web.UI.MobileControls.MobileListItem[]); }
    public int IndexOf(System.Web.UI.MobileControls.MobileListItem item) { return default(int); }
    public virtual void Insert(int index, string item) { }
    public void Insert(int index, System.Web.UI.MobileControls.MobileListItem item) { }
    protected void LoadViewState(object state) { }
    public virtual void Remove(string item) { }
    public void Remove(System.Web.UI.MobileControls.MobileListItem item) { }
    public void RemoveAt(int index) { }
    protected object SaveViewState() { return default(object); }
    public void SetAll(System.Web.UI.MobileControls.MobileListItem[] value) { }
    void System.Web.UI.IStateManager.LoadViewState(object state) { }
    object System.Web.UI.IStateManager.SaveViewState() { return default(object); }
    void System.Web.UI.IStateManager.TrackViewState() { }
    protected void TrackViewState() { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  public enum MobileListItemType {
    FooterItem = 2,
    HeaderItem = 0,
    ListItem = 1,
    SeparatorItem = 3,
  }
  [System.ComponentModel.DesignerAttribute("Microsoft.VisualStudio.Web.WebForms.MobileWebFormDesigner, Microsoft.VisualStudio.Web, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(System.ComponentModel.Design.IRootDesigner))]
  [System.ComponentModel.ToolboxItemAttribute(false)]
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class MobilePage : System.Web.UI.Page {
    public static readonly string HiddenPostEventArgumentId;
    public static readonly string HiddenPostEventSourceId;
    public static readonly string HiddenVariablePrefix;
    public static readonly string PageClientViewStateKey;
    public static readonly string ViewStateID;
    public MobilePage() { }
    [System.ComponentModel.BrowsableAttribute(false)]
    public string AbsoluteFilePath { get { return default(string); } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Web.UI.MobileControls.Form ActiveForm { get { return default(System.Web.UI.MobileControls.Form); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public new System.Web.UI.MobileControls.IPageAdapter Adapter { get { return default(System.Web.UI.MobileControls.IPageAdapter); } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public bool AllowCustomAttributes { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public string ClientViewState { get { return default(string); } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new bool DesignMode { get { return default(bool); } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public virtual System.Web.Mobile.MobileCapabilities Device { get { return default(System.Web.Mobile.MobileCapabilities); } }
    public override bool EnableEventValidation { get { return default(bool); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public override bool EnableTheming { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Collections.IList Forms { get { return default(System.Collections.IList); } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Collections.IDictionary HiddenVariables { get { return default(System.Collections.IDictionary); } }
    public override char IdSeparator { get { return default(char); } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public sealed override string MasterPageFile { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public string QueryStringText { get { return default(string); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public string RelativeFilePath { get { return default(string); } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Web.UI.MobileControls.StyleSheet StyleSheet { get { return default(System.Web.UI.MobileControls.StyleSheet); } set { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public override string StyleSheetTheme { get { return default(string); } set { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public override string Theme { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ComponentModel.LocalizableAttribute(false)]
    public new string Title { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public new string UniqueFilePathSuffix { get { return default(string); } }
    protected override void AddedControl(System.Web.UI.Control control, int index) { }
    protected override void AddParsedSubObject(object o) { }
    protected override System.Web.UI.HtmlTextWriter CreateHtmlTextWriter(System.IO.TextWriter writer) { return default(System.Web.UI.HtmlTextWriter); }
    protected override System.Collections.Specialized.NameValueCollection DeterminePostBackMode() { return default(System.Collections.Specialized.NameValueCollection); }
    public virtual System.Web.UI.MobileControls.IControlAdapter GetControlAdapter(System.Web.UI.MobileControls.MobileControl control) { return default(System.Web.UI.MobileControls.IControlAdapter); }
    public System.Web.UI.MobileControls.Form GetForm(string id) { return default(System.Web.UI.MobileControls.Form); }
    public object GetPrivateViewState(System.Web.UI.MobileControls.MobileControl ctl) { return default(object); }
    public bool HasHiddenVariables() { return default(bool); }
    protected override void InitOutputCache(int duration, string varyByContentEncoding, string varyByHeader, string varyByCustom, System.Web.UI.OutputCacheLocation location, string varyByParam) { }
    protected override void InitOutputCache(int duration, string varyByHeader, string varyByCustom, System.Web.UI.OutputCacheLocation location, string varyByParam) { }
    protected override object LoadPageStateFromPersistenceMedium() { return default(object); }
    protected override void LoadViewState(object savedState) { }
    public string MakePathAbsolute(string virtualPath) { return default(string); }
    protected virtual void OnDeviceCustomize(System.EventArgs e) { }
    protected override void OnError(System.EventArgs e) { }
    protected override void OnInit(System.EventArgs e) { }
    protected override void OnLoad(System.EventArgs e) { }
    protected override void OnPreInit(System.EventArgs e) { }
    protected override void OnPreRender(System.EventArgs e) { }
    protected override void OnUnload(System.EventArgs e) { }
    protected virtual void OnViewStateExpire(System.EventArgs e) { }
    protected override void RaisePostBackEvent(System.Web.UI.IPostBackEventHandler sourceControl, string eventArgument) { }
    public void RedirectToMobilePage(string url) { }
    public void RedirectToMobilePage(string url, bool endResponse) { }
    protected override void RemovedControl(System.Web.UI.Control control) { }
    protected override void Render(System.Web.UI.HtmlTextWriter writer) { }
    public override void RenderControl(System.Web.UI.HtmlTextWriter writer) { }
    protected override void SavePageStateToPersistenceMedium(object view) { }
    protected override object SaveViewState() { return default(object); }
    public override void Validate() { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override void VerifyRenderingInServerForm(System.Web.UI.Control control) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  public sealed partial class MobileTypeNameConverter : System.Configuration.ConfigurationConverterBase {
    public MobileTypeNameConverter() { }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext ctx, System.Globalization.CultureInfo ci, object data) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext ctx, System.Globalization.CultureInfo ci, object value, System.Type targetType) { return default(object); }
  }
  [System.ComponentModel.DesignerAttribute("Microsoft.VisualStudio.Web.WebForms.MobileWebFormDesigner, Microsoft.VisualStudio.Web, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(System.ComponentModel.Design.IRootDesigner))]
  [System.ComponentModel.DesignerAttribute(typeof(System.Web.UI.Design.MobileControls.MobileUserControlDesigner))]
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class MobileUserControl : System.Web.UI.UserControl {
    public MobileUserControl() { }
    protected override void AddParsedSubObject(object o) { }
  }
  [System.ComponentModel.DefaultEventAttribute("ItemCommand")]
  [System.ComponentModel.DefaultPropertyAttribute("DataSource")]
  [System.ComponentModel.DesignerAttribute(typeof(System.Web.UI.Design.MobileControls.ObjectListDesigner))]
  [System.ComponentModel.EditorAttribute(typeof(System.Web.UI.Design.MobileControls.ObjectListComponentEditor), typeof(System.ComponentModel.ComponentEditor))]
  [System.ComponentModel.ToolboxItemAttribute("System.Web.UI.Design.WebControlToolboxItem, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.UI.ControlBuilderAttribute(typeof(System.Web.UI.MobileControls.ObjectListControlBuilder))]
  [System.Web.UI.MobileControls.DesignerAdapterAttribute(typeof(System.Web.UI.Design.MobileControls.Adapters.DesignerObjectListAdapter))]
  [System.Web.UI.ToolboxDataAttribute("<{0}:ObjectList runat=\"server\" LabelStyle-StyleReference=\"title\" CommandStyle-StyleReference=\"subcommand\"></{0}:ObjectList>")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class ObjectList : System.Web.UI.MobileControls.PagedControl, System.Web.UI.INamingContainer, System.Web.UI.IPostBackEventHandler, System.Web.UI.MobileControls.ITemplateable {
    public ObjectList() { }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Web.UI.MobileControls.IObjectListFieldCollection AllFields { get { return default(System.Web.UI.MobileControls.IObjectListFieldCollection); } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Behavior")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("ObjectList_AutoGenerateFields")]
    public bool AutoGenerateFields { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Appearance")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("ObjectList_BackCommandText")]
    public string BackCommandText { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.EditorAttribute(typeof(System.Web.UI.Design.MobileControls.CommandCollectionEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Data")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("ObjectList_Commands")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(2))]
    public virtual System.Web.UI.MobileControls.ObjectListCommandCollection Commands { get { return default(System.Web.UI.MobileControls.ObjectListCommandCollection); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Style")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("ObjectList_CommandStyle")]
    public System.Web.UI.MobileControls.Style CommandStyle { get { return default(System.Web.UI.MobileControls.Style); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.Design.MobileControls.Converters.DataMemberConverter))]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Data")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("List_DataMember")]
    public virtual string DataMember { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Data")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("ObjectList_DataSource")]
    public virtual object DataSource { get { return default(object); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.Design.MobileControls.Converters.DefaultCommandConverter))]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Data")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("ObjectList_DefaultCommand")]
    public string DefaultCommand { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Web.UI.MobileControls.Panel Details { get { return default(System.Web.UI.MobileControls.Panel); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Appearance")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("ObjectList_DetailsCommandText")]
    public string DetailsCommandText { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.EditorAttribute(typeof(System.Web.UI.Design.MobileControls.FieldCollectionEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Data")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("ObjectList_Fields")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(2))]
    public virtual System.Web.UI.MobileControls.ObjectListFieldCollection Fields { get { return default(System.Web.UI.MobileControls.ObjectListFieldCollection); } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public bool HasItemCommandHandler { get { return default(bool); } }
    protected override int InternalItemCount { get { return default(int); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public virtual System.Web.UI.MobileControls.ObjectListItemCollection Items { get { return default(System.Web.UI.MobileControls.ObjectListItemCollection); } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.Design.MobileControls.Converters.DataFieldConverter))]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Data")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("ObjectList_LabelField")]
    public string LabelField { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public int LabelFieldIndex { get { return default(int); } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Style")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("ObjectList_LabelStyle")]
    public System.Web.UI.MobileControls.Style LabelStyle { get { return default(System.Web.UI.MobileControls.Style); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Appearance")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("ObjectList_MoreText")]
    public string MoreText { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public int SelectedIndex { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Web.UI.MobileControls.ObjectListItem Selection { get { return default(System.Web.UI.MobileControls.ObjectListItem); } }
    public static string SelectMoreCommand { get { return default(string); } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Int32[] TableFieldIndices { get { return default(System.Int32[]); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute(typeof(System.Web.UI.Design.MobileControls.TableFieldsEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Data")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("ObjectList_TableFields")]
    public string TableFields { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Web.UI.MobileControls.ObjectListViewMode ViewMode { get { return default(System.Web.UI.MobileControls.ObjectListViewMode); } set { } }
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Action")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("ObjectList_OnItemCommand")]
    public event System.Web.UI.MobileControls.ObjectListCommandEventHandler ItemCommand { add { } remove { } }
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Action")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("ObjectList_OnItemDataBind")]
    public event System.Web.UI.MobileControls.ObjectListDataBindEventHandler ItemDataBind { add { } remove { } }
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Action")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("ObjectList_OnItemSelect")]
    public event System.Web.UI.MobileControls.ObjectListSelectEventHandler ItemSelect { add { } remove { } }
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Action")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("ObjectList_OnShowItemCommands")]
    public event System.Web.UI.MobileControls.ObjectListShowCommandsEventHandler ShowItemCommands { add { } remove { } }
    protected override void AddParsedSubObject(object obj) { }
    protected void CreateAutoGeneratedFields(System.Collections.IEnumerable dataSource) { }
    protected override void CreateChildControls() { }
    protected virtual System.Web.UI.MobileControls.ObjectListItem CreateItem(object dataItem) { return default(System.Web.UI.MobileControls.ObjectListItem); }
    protected virtual void CreateItems(System.Collections.IEnumerable dataSource) { }
    public void CreateTemplatedItemDetails(bool doDataBind) { }
    public void CreateTemplatedItemsList(bool doDataBind) { }
    public override void DataBind() { }
    protected override void EnsureChildControls() { }
    public override void EnsureTemplatedUI() { }
    protected override void LoadPrivateViewState(object state) { }
    protected override void LoadViewState(object savedState) { }
    protected override bool OnBubbleEvent(object sender, System.EventArgs e) { return default(bool); }
    protected override void OnDataBinding(System.EventArgs e) { }
    protected virtual void OnItemCommand(System.Web.UI.MobileControls.ObjectListCommandEventArgs e) { }
    protected virtual void OnItemDataBind(System.Web.UI.MobileControls.ObjectListDataBindEventArgs e) { }
    protected virtual void OnItemSelect(System.Web.UI.MobileControls.ObjectListSelectEventArgs e) { }
    protected override void OnLoadItems(System.Web.UI.MobileControls.LoadItemsEventArgs e) { }
    protected override void OnPreRender(System.EventArgs e) { }
    protected virtual void OnShowItemCommands(System.Web.UI.MobileControls.ObjectListShowCommandsEventArgs e) { }
    public void PreShowItemCommands(int itemIndex) { }
    public void RaiseDefaultItemEvent(int itemIndex) { }
    protected void RaisePostBackEvent(string eventArgument) { }
    protected override object SavePrivateViewState() { return default(object); }
    protected override object SaveViewState() { return default(object); }
    public bool SelectListItem(int itemIndex, bool selectMore) { return default(bool); }
    void System.Web.UI.IPostBackEventHandler.RaisePostBackEvent(string eventArgument) { }
    protected override void TrackViewState() { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.UI.MobileControls.PersistNameAttribute("Command")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class ObjectListCommand {
    public ObjectListCommand() { }
    public ObjectListCommand(string name, string text) { }
    [System.ComponentModel.DefaultValueAttribute("")]
    public string Name { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    public string Text { get { return default(string); } set { } }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class ObjectListCommandCollection : System.Web.UI.MobileControls.ArrayListCollectionBase, System.Web.UI.IStateManager {
    internal ObjectListCommandCollection() { }
    protected bool IsTrackingViewState { get { return default(bool); } }
    public System.Web.UI.MobileControls.ObjectListCommand this[int index] { get { return default(System.Web.UI.MobileControls.ObjectListCommand); } }
    bool System.Web.UI.IStateManager.IsTrackingViewState { get { return default(bool); } }
    public void Add(System.Web.UI.MobileControls.ObjectListCommand command) { }
    public void AddAt(int index, System.Web.UI.MobileControls.ObjectListCommand command) { }
    public void Clear() { }
    public int IndexOf(string s) { return default(int); }
    protected void LoadViewState(object state) { }
    public void Remove(string s) { }
    public void RemoveAt(int index) { }
    protected object SaveViewState() { return default(object); }
    void System.Web.UI.IStateManager.LoadViewState(object state) { }
    object System.Web.UI.IStateManager.SaveViewState() { return default(object); }
    void System.Web.UI.IStateManager.TrackViewState() { }
    protected void TrackViewState() { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class ObjectListCommandEventArgs : System.Web.UI.WebControls.CommandEventArgs {
    protected static readonly string DefaultCommand;
    public ObjectListCommandEventArgs(System.Web.UI.MobileControls.ObjectListItem item, object commandSource, System.Web.UI.WebControls.CommandEventArgs originalArgs) : base (default(System.Web.UI.WebControls.CommandEventArgs)) { }
    public ObjectListCommandEventArgs(System.Web.UI.MobileControls.ObjectListItem item, string commandName) : base (default(System.Web.UI.WebControls.CommandEventArgs)) { }
    public object CommandSource { get { return default(object); } }
    public System.Web.UI.MobileControls.ObjectListItem ListItem { get { return default(System.Web.UI.MobileControls.ObjectListItem); } }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  public delegate void ObjectListCommandEventHandler(object sender, System.Web.UI.MobileControls.ObjectListCommandEventArgs e);
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class ObjectListControlBuilder : System.Web.UI.MobileControls.MobileControlBuilder {
    public ObjectListControlBuilder() { }
    public override System.Type GetChildControlType(string tagName, System.Collections.IDictionary attributes) { return default(System.Type); }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class ObjectListDataBindEventArgs : System.EventArgs {
    public ObjectListDataBindEventArgs(System.Web.UI.MobileControls.ObjectListItem item, object dataItem) { }
    public object DataItem { get { return default(object); } }
    public System.Web.UI.MobileControls.ObjectListItem ListItem { get { return default(System.Web.UI.MobileControls.ObjectListItem); } }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  public delegate void ObjectListDataBindEventHandler(object sender, System.Web.UI.MobileControls.ObjectListDataBindEventArgs e);
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.UI.MobileControls.PersistNameAttribute("Field")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public sealed partial class ObjectListField : System.Web.UI.IStateManager {
    public ObjectListField() { }
    [System.ComponentModel.DefaultValueAttribute("")]
    public string DataField { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    public string DataFormatString { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    public string Name { get { return default(string); } set { } }
    bool System.Web.UI.IStateManager.IsTrackingViewState { get { return default(bool); } }
    [System.ComponentModel.DefaultValueAttribute("")]
    public string Title { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool Visible { get { return default(bool); } set { } }
    public void DataBindItem(int fieldIndex, System.Web.UI.MobileControls.ObjectListItem item) { }
    void System.Web.UI.IStateManager.LoadViewState(object state) { }
    object System.Web.UI.IStateManager.SaveViewState() { return default(object); }
    void System.Web.UI.IStateManager.TrackViewState() { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class ObjectListFieldCollection : System.Web.UI.MobileControls.ArrayListCollectionBase, System.Collections.ICollection, System.Collections.IEnumerable, System.Web.UI.IStateManager, System.Web.UI.MobileControls.IObjectListFieldCollection {
    internal ObjectListFieldCollection() { }
    protected bool IsTrackingViewState { get { return default(bool); } }
    public System.Web.UI.MobileControls.ObjectListField this[int index] { get { return default(System.Web.UI.MobileControls.ObjectListField); } }
    bool System.Web.UI.IStateManager.IsTrackingViewState { get { return default(bool); } }
    public void Add(System.Web.UI.MobileControls.ObjectListField field) { }
    public void AddAt(int index, System.Web.UI.MobileControls.ObjectListField field) { }
    public void Clear() { }
    public System.Web.UI.MobileControls.ObjectListField[] GetAll() { return default(System.Web.UI.MobileControls.ObjectListField[]); }
    public int IndexOf(string fieldIDOrName) { return default(int); }
    public int IndexOf(System.Web.UI.MobileControls.ObjectListField field) { return default(int); }
    protected void LoadViewState(object savedState) { }
    public void Remove(System.Web.UI.MobileControls.ObjectListField field) { }
    public void RemoveAt(int index) { }
    protected object SaveViewState() { return default(object); }
    public void SetAll(System.Web.UI.MobileControls.ObjectListField[] value) { }
    void System.Web.UI.IStateManager.LoadViewState(object state) { }
    object System.Web.UI.IStateManager.SaveViewState() { return default(object); }
    void System.Web.UI.IStateManager.TrackViewState() { }
    protected void TrackViewState() { }
  }
  [System.ComponentModel.ToolboxItemAttribute(false)]
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class ObjectListItem : System.Web.UI.MobileControls.MobileListItem {
    internal ObjectListItem() { }
    public string this[int index] { get { return default(string); } set { } }
    public string this[string key] { get { return default(string); } set { } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    protected override bool OnBubbleEvent(object source, System.EventArgs e) { return default(bool); }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class ObjectListItemCollection : System.Web.UI.MobileControls.ArrayListCollectionBase, System.Web.UI.IStateManager {
    internal ObjectListItemCollection() { }
    protected bool IsTrackingViewState { get { return default(bool); } }
    public System.Web.UI.MobileControls.ObjectListItem this[int index] { get { return default(System.Web.UI.MobileControls.ObjectListItem); } }
    bool System.Web.UI.IStateManager.IsTrackingViewState { get { return default(bool); } }
    public void Clear() { }
    public bool Contains(System.Web.UI.MobileControls.ObjectListItem item) { return default(bool); }
    public System.Web.UI.MobileControls.ObjectListItem[] GetAll() { return default(System.Web.UI.MobileControls.ObjectListItem[]); }
    public int IndexOf(System.Web.UI.MobileControls.ObjectListItem item) { return default(int); }
    protected void LoadViewState(object state) { }
    protected object SaveViewState() { return default(object); }
    void System.Web.UI.IStateManager.LoadViewState(object state) { }
    object System.Web.UI.IStateManager.SaveViewState() { return default(object); }
    void System.Web.UI.IStateManager.TrackViewState() { }
    protected void TrackViewState() { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class ObjectListSelectEventArgs : System.EventArgs {
    public ObjectListSelectEventArgs(System.Web.UI.MobileControls.ObjectListItem item, bool selectMore) { }
    public System.Web.UI.MobileControls.ObjectListItem ListItem { get { return default(System.Web.UI.MobileControls.ObjectListItem); } }
    public bool SelectMore { get { return default(bool); } }
    public bool UseDefaultHandling { get { return default(bool); } set { } }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  public delegate void ObjectListSelectEventHandler(object sender, System.Web.UI.MobileControls.ObjectListSelectEventArgs e);
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class ObjectListShowCommandsEventArgs : System.EventArgs {
    public ObjectListShowCommandsEventArgs(System.Web.UI.MobileControls.ObjectListItem item, System.Web.UI.MobileControls.ObjectListCommandCollection commands) { }
    public System.Web.UI.MobileControls.ObjectListCommandCollection Commands { get { return default(System.Web.UI.MobileControls.ObjectListCommandCollection); } }
    public System.Web.UI.MobileControls.ObjectListItem ListItem { get { return default(System.Web.UI.MobileControls.ObjectListItem); } }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  public delegate void ObjectListShowCommandsEventHandler(object sender, System.Web.UI.MobileControls.ObjectListShowCommandsEventArgs e);
  [System.AttributeUsageAttribute((System.AttributeTargets)(128))]
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class ObjectListTitleAttribute : System.Attribute {
    public ObjectListTitleAttribute(string title) { }
    public virtual string Title { get { return default(string); } }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  public enum ObjectListViewMode {
    Commands = 1,
    Details = 2,
    List = 0,
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public abstract partial class PagedControl : System.Web.UI.MobileControls.MobileControl {
    protected PagedControl() { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public int FirstVisibleItemIndex { get { return default(int); } }
    protected abstract int InternalItemCount { get; }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Paging")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("PagedControl_ItemCount")]
    public int ItemCount { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Paging")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("PagedControl_ItemsPerPage")]
    public int ItemsPerPage { get { return default(int); } set { } }
    protected virtual int ItemWeight { get { return default(int); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public int VisibleItemCount { get { return default(int); } }
    public override int VisibleWeight { get { return default(int); } }
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Action")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("PagedControl_OnLoadItems")]
    public event System.Web.UI.MobileControls.LoadItemsEventHandler LoadItems { add { } remove { } }
    protected override void LoadPrivateViewState(object state) { }
    protected virtual void OnLoadItems(System.Web.UI.MobileControls.LoadItemsEventArgs e) { }
    protected override void OnPageChange(int oldPageIndex, int newPageIndex) { }
    protected override void OnPreRender(System.EventArgs e) { }
    public override void PaginateRecursive(System.Web.UI.MobileControls.ControlPager pager) { }
    protected override object SavePrivateViewState() { return default(object); }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class PagerStyle : System.Web.UI.MobileControls.Style {
    public static readonly object NextPageTextKey;
    public static readonly object PageLabelKey;
    public static readonly object PreviousPageTextKey;
    public PagerStyle() { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Appearance")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("PagerStyle_NextPageText")]
    public string NextPageText { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Appearance")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("PagerStyle_PageLabel")]
    public string PageLabel { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Appearance")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("PagerStyle_PreviousPageText")]
    public string PreviousPageText { get { return default(string); } set { } }
    public string GetNextPageText(int currentPageIndex) { return default(string); }
    public string GetPageLabelText(int currentPageIndex, int pageCount) { return default(string); }
    public string GetPreviousPageText(int currentPageIndex) { return default(string); }
  }
  [System.ComponentModel.DesignerAttribute(typeof(System.Web.UI.Design.MobileControls.PanelDesigner))]
  [System.ComponentModel.ToolboxItemAttribute("System.Web.UI.Design.WebControlToolboxItem, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.UI.ControlBuilderAttribute(typeof(System.Web.UI.MobileControls.PanelControlBuilder))]
  [System.Web.UI.MobileControls.DesignerAdapterAttribute(typeof(System.Web.UI.MobileControls.Adapters.HtmlPanelAdapter))]
  [System.Web.UI.PersistChildrenAttribute(true)]
  [System.Web.UI.ToolboxDataAttribute("<{0}:Panel runat=\"server\"></{0}:Panel>")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class Panel : System.Web.UI.MobileControls.MobileControl, System.Web.UI.MobileControls.ITemplateable {
    public Panel() { }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public override bool BreakAfter { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Web.UI.MobileControls.Panel Content { get { return default(System.Web.UI.MobileControls.Panel); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Behavior")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("Panel_Paginate")]
    public virtual bool Paginate { get { return default(bool); } set { } }
    protected override bool PaginateChildren { get { return default(bool); } }
    public override void AddLinkedForms(System.Collections.IList linkedForms) { }
    public override void CreateDefaultTemplatedUI(bool doDataBind) { }
    protected override void OnInit(System.EventArgs e) { }
    public override void PaginateRecursive(System.Web.UI.MobileControls.ControlPager pager) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class PanelControlBuilder : System.Web.UI.MobileControls.LiteralTextContainerControlBuilder {
    public PanelControlBuilder() { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class PersistNameAttribute : System.Attribute {
    public static readonly System.Web.UI.MobileControls.PersistNameAttribute Default;
    public PersistNameAttribute(string name) { }
    public string Name { get { return default(string); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool IsDefaultAttribute() { return default(bool); }
  }
  [System.ComponentModel.DefaultPropertyAttribute("Text")]
  [System.ComponentModel.DesignerAttribute(typeof(System.Web.UI.Design.MobileControls.PhoneCallDesigner))]
  [System.ComponentModel.ToolboxItemAttribute("System.Web.UI.Design.WebControlToolboxItem, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.UI.DataBindingHandlerAttribute("System.Web.UI.Design.TextDataBindingHandler, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [System.Web.UI.MobileControls.DesignerAdapterAttribute(typeof(System.Web.UI.Design.MobileControls.Adapters.DesignerLabelAdapter))]
  [System.Web.UI.ToolboxDataAttribute("<{0}:PhoneCall runat=\"server\">PhoneCall</{0}:PhoneCall>")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class PhoneCall : System.Web.UI.MobileControls.TextControl, System.Web.UI.IPostBackEventHandler {
    public PhoneCall() { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("{0} {1}")]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Behavior")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("PhoneCall_AlternateFormat")]
    public string AlternateFormat { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.Design.MobileControls.Converters.NavigateUrlConverter))]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Navigation")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("PhoneCall_AlternateUrl")]
    public string AlternateUrl { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Navigation")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("PhoneCall_PhoneNumber")]
    public string PhoneNumber { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Behavior")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("PhoneCall_SoftkeyLabel")]
    public string SoftkeyLabel { get { return default(string); } set { } }
    public override void AddLinkedForms(System.Collections.IList linkedForms) { }
    protected override void OnPreRender(System.EventArgs e) { }
    protected void RaisePostBackEvent(string argument) { }
    void System.Web.UI.IPostBackEventHandler.RaisePostBackEvent(string eventArgument) { }
  }
  [System.ComponentModel.ToolboxItemAttribute("System.Web.UI.Design.WebControlToolboxItem, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.UI.ToolboxDataAttribute("<{0}:RangeValidator runat=\"server\" ErrorMessage=\"RangeValidator\"></{0}:RangeValidator>")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class RangeValidator : System.Web.UI.MobileControls.BaseValidator {
    public RangeValidator() { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Behavior")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("RangeValidator_MaximumValue")]
    public string MaximumValue { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Behavior")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("RangeValidator_MinimumValue")]
    public string MinimumValue { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.WebControls.ValidationDataType)(0))]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Behavior")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("RangeValidator_Type")]
    public System.Web.UI.WebControls.ValidationDataType Type { get { return default(System.Web.UI.WebControls.ValidationDataType); } set { } }
    protected override bool ControlPropertiesValid() { return default(bool); }
    protected override System.Web.UI.WebControls.BaseValidator CreateWebValidator() { return default(System.Web.UI.WebControls.BaseValidator); }
    protected override bool EvaluateIsValid() { return default(bool); }
  }
  [System.ComponentModel.ToolboxItemAttribute("System.Web.UI.Design.WebControlToolboxItem, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.UI.ToolboxDataAttribute("<{0}:RegularExpressionValidator runat=\"server\" ErrorMessage=\"RegularExpressionValidator\"></{0}:RegularExpressionValidator>")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class RegularExpressionValidator : System.Web.UI.MobileControls.BaseValidator {
    public RegularExpressionValidator() { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.WebControls.RegexTypeEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(System.Drawing.Design.UITypeEditor))]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Behavior")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("RegularExpressionValidator_ValidationExpression")]
    public string ValidationExpression { get { return default(string); } set { } }
    protected override System.Web.UI.WebControls.BaseValidator CreateWebValidator() { return default(System.Web.UI.WebControls.BaseValidator); }
    protected override bool EvaluateIsValid() { return default(bool); }
  }
  [System.ComponentModel.ToolboxItemAttribute("System.Web.UI.Design.WebControlToolboxItem, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.UI.ToolboxDataAttribute("<{0}:RequiredFieldValidator runat=\"server\" ErrorMessage=\"RequiredFieldValidator\"></{0}:RequiredFieldValidator>")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class RequiredFieldValidator : System.Web.UI.MobileControls.BaseValidator {
    public RequiredFieldValidator() { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Behavior")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("RequiredFieldValidator_InitialValue")]
    public string InitialValue { get { return default(string); } set { } }
    protected override System.Web.UI.WebControls.BaseValidator CreateWebValidator() { return default(System.Web.UI.WebControls.BaseValidator); }
    protected override bool EvaluateIsValid() { return default(bool); }
  }
  [System.ComponentModel.DefaultEventAttribute("SelectedIndexChanged")]
  [System.ComponentModel.DefaultPropertyAttribute("DataSource")]
  [System.ComponentModel.DesignerAttribute(typeof(System.Web.UI.Design.MobileControls.SelectionListDesigner))]
  [System.ComponentModel.EditorAttribute(typeof(System.Web.UI.Design.MobileControls.SelectionListComponentEditor), typeof(System.ComponentModel.ComponentEditor))]
  [System.ComponentModel.ToolboxItemAttribute("System.Web.UI.Design.WebControlToolboxItem, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.UI.ControlBuilderAttribute(typeof(System.Web.UI.MobileControls.ListControlBuilder))]
  [System.Web.UI.MobileControls.DesignerAdapterAttribute(typeof(System.Web.UI.Design.MobileControls.Adapters.DesignerSelectionListAdapter))]
  [System.Web.UI.ToolboxDataAttribute("<{0}:SelectionList runat=\"server\"></{0}:SelectionList>")]
  [System.Web.UI.ValidationPropertyAttribute("Selection")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class SelectionList : System.Web.UI.MobileControls.MobileControl, System.Web.UI.IPostBackDataHandler {
    public SelectionList() { }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.Design.MobileControls.Converters.DataMemberConverter))]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Data")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("List_DataMember")]
    public virtual string DataMember { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Data")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("List_DataSource")]
    public virtual object DataSource { get { return default(object); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.Design.MobileControls.Converters.DataFieldConverter))]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Data")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("List_DataTextField")]
    public string DataTextField { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.Design.MobileControls.Converters.DataFieldConverter))]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Data")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("List_DataValueField")]
    public string DataValueField { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public bool IsMultiSelect { get { return default(bool); } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.EditorAttribute(typeof(System.Web.UI.Design.MobileControls.ItemCollectionEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("List_Items")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(2))]
    public System.Web.UI.MobileControls.MobileListItemCollection Items { get { return default(System.Web.UI.MobileControls.MobileListItemCollection); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(4)]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Appearance")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("SelectionList_Rows")]
    public int Rows { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public int SelectedIndex { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Web.UI.MobileControls.MobileListItem Selection { get { return default(System.Web.UI.MobileControls.MobileListItem); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.MobileControls.ListSelectType)(0))]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Appearance")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("SelectionList_SelectType")]
    public System.Web.UI.MobileControls.ListSelectType SelectType { get { return default(System.Web.UI.MobileControls.ListSelectType); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Appearance")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("Input_Title")]
    public string Title { get { return default(string); } set { } }
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Action")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("List_OnItemDataBind")]
    public event System.Web.UI.MobileControls.ListDataBindEventHandler ItemDataBind { add { } remove { } }
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Action")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("SelectionList_OnSelectedIndexChanged")]
    public event System.EventHandler SelectedIndexChanged { add { } remove { } }
    protected override void AddParsedSubObject(object obj) { }
    protected virtual void CreateItems(System.Collections.IEnumerable dataSource) { }
    protected bool LoadPostData(string postDataKey, System.Collections.Specialized.NameValueCollection postCollection) { return default(bool); }
    protected override void LoadViewState(object savedState) { }
    protected override void OnDataBinding(System.EventArgs e) { }
    protected virtual void OnItemDataBind(System.Web.UI.MobileControls.ListDataBindEventArgs e) { }
    protected override void OnPreRender(System.EventArgs e) { }
    protected virtual void OnSelectedIndexChanged(System.EventArgs e) { }
    protected void RaisePostDataChangedEvent() { }
    protected override object SaveViewState() { return default(object); }
    bool System.Web.UI.IPostBackDataHandler.LoadPostData(string key, System.Collections.Specialized.NameValueCollection data) { return default(bool); }
    void System.Web.UI.IPostBackDataHandler.RaisePostDataChangedEvent() { }
    protected override void TrackViewState() { }
  }
  [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.ExpandableObjectConverter))]
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.UI.ControlBuilderAttribute(typeof(System.Web.UI.MobileControls.MobileControlBuilder))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class Style : System.ICloneable, System.Web.UI.IParserAccessor, System.Web.UI.IStateManager, System.Web.UI.MobileControls.ITemplateable {
    public static readonly object AlignmentKey;
    public static readonly object BackColorKey;
    public static readonly object BoldKey;
    public static readonly object FontNameKey;
    public static readonly object FontSizeKey;
    public static readonly object ForeColorKey;
    public static readonly object ItalicKey;
    public static readonly object WrappingKey;
    public Style() { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.MobileControls.Alignment)(0))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Appearance")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("Style_Alignment")]
    public System.Web.UI.MobileControls.Alignment Alignment { get { return default(System.Web.UI.MobileControls.Alignment); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.WebControls.WebColorConverter))]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Appearance")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("Style_BackColor")]
    public System.Drawing.Color BackColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Web.UI.MobileControls.MobileControl Control { get { return default(System.Web.UI.MobileControls.MobileControl); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    public System.Web.UI.MobileControls.DeviceSpecific DeviceSpecific { get { return default(System.Web.UI.MobileControls.DeviceSpecific); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Appearance")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("Style_Font")]
    public System.Web.UI.MobileControls.FontInfo Font { get { return default(System.Web.UI.MobileControls.FontInfo); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.WebControls.WebColorConverter))]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Appearance")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("Style_ForeColor")]
    public System.Drawing.Color ForeColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public bool IsTemplated { get { return default(bool); } }
    protected bool IsTrackingViewState { get { return default(bool); } }
    public object this[object key] { get { return default(object); } set { } }
    public object this[object key, bool inherit] { get { return default(object); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("Style_Name")]
    public string Name { get { return default(string); } set { } }
    protected internal System.Web.UI.StateBag State { get { return default(System.Web.UI.StateBag); } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.Design.MobileControls.Converters.StyleReferenceConverter))]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Appearance")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("Style_Reference")]
    public virtual string StyleReference { get { return default(string); } set { } }
    bool System.Web.UI.IStateManager.IsTrackingViewState { get { return default(bool); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.MobileControls.Wrapping)(0))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Appearance")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("Style_Wrapping")]
    public System.Web.UI.MobileControls.Wrapping Wrapping { get { return default(System.Web.UI.MobileControls.Wrapping); } set { } }
    protected void AddParsedSubObject(object o) { }
    public void ApplyTo(System.Web.UI.WebControls.WebControl control) { }
    public object Clone() { return default(object); }
    public System.Web.UI.ITemplate GetTemplate(string templateName) { return default(System.Web.UI.ITemplate); }
    protected void LoadViewState(object state) { }
    public static object RegisterStyle(string name, System.Type type, object defaultValue, bool inherit) { return default(object); }
    protected object SaveViewState() { return default(object); }
    void System.Web.UI.IParserAccessor.AddParsedSubObject(object o) { }
    void System.Web.UI.IStateManager.LoadViewState(object state) { }
    object System.Web.UI.IStateManager.SaveViewState() { return default(object); }
    void System.Web.UI.IStateManager.TrackViewState() { }
    protected void TrackViewState() { }
  }
  [System.ComponentModel.DesignerAttribute(typeof(System.Web.UI.Design.MobileControls.StyleSheetDesigner))]
  [System.ComponentModel.EditorAttribute(typeof(System.Web.UI.Design.MobileControls.StyleSheetComponentEditor), typeof(System.ComponentModel.ComponentEditor))]
  [System.ComponentModel.ToolboxItemAttribute(typeof(System.Web.UI.Design.WebControlToolboxItem))]
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.UI.ControlBuilderAttribute(typeof(System.Web.UI.MobileControls.StyleSheetControlBuilder))]
  [System.Web.UI.ToolboxDataAttribute("<{0}:StyleSheet runat=\"server\"></{0}:StyleSheet>")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class StyleSheet : System.Web.UI.MobileControls.MobileControl {
    public StyleSheet() { }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override System.Web.UI.MobileControls.Alignment Alignment { get { return default(System.Web.UI.MobileControls.Alignment); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override System.Drawing.Color BackColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override bool BreakAfter { get { return default(bool); } set { } }
    public static System.Web.UI.MobileControls.StyleSheet Default { get { return default(System.Web.UI.MobileControls.StyleSheet); } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public override bool EnableViewState { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override System.Web.UI.MobileControls.FontInfo Font { get { return default(System.Web.UI.MobileControls.FontInfo); } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override System.Drawing.Color ForeColor { get { return default(System.Drawing.Color); } set { } }
    public System.Web.UI.MobileControls.Style this[string name] { get { return default(System.Web.UI.MobileControls.Style); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute(typeof(System.Web.UI.Design.MobileControls.StyleSheetRefUrlEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Behavior")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("StyleSheet_ReferencePath")]
    public string ReferencePath { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override string StyleReference { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Collections.ICollection Styles { get { return default(System.Collections.ICollection); } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public override bool Visible { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override System.Web.UI.MobileControls.Wrapping Wrapping { get { return default(System.Web.UI.MobileControls.Wrapping); } set { } }
    protected override void AddParsedSubObject(object o) { }
    public void Clear() { }
    protected override void LoadViewState(object savedState) { }
    public void Remove(string name) { }
    protected override object SaveViewState() { return default(object); }
    protected override void TrackViewState() { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class StyleSheetControlBuilder : System.Web.UI.MobileControls.MobileControlBuilder {
    public StyleSheetControlBuilder() { }
    public override System.Type GetChildControlType(string name, System.Collections.IDictionary attributes) { return default(System.Type); }
  }
  [System.ComponentModel.ToolboxItemAttribute(false)]
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class TemplateContainer : System.Web.UI.MobileControls.Panel, System.Web.UI.INamingContainer {
    public TemplateContainer() { }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public override bool BreakAfter { get { return default(bool); } set { } }
  }
  [System.ComponentModel.DefaultEventAttribute("TextChanged")]
  [System.ComponentModel.DefaultPropertyAttribute("Text")]
  [System.ComponentModel.DesignerAttribute(typeof(System.Web.UI.Design.MobileControls.TextBoxDesigner))]
  [System.ComponentModel.ToolboxItemAttribute("System.Web.UI.Design.WebControlToolboxItem, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.UI.ControlBuilderAttribute(typeof(System.Web.UI.MobileControls.TextBoxControlBuilder))]
  [System.Web.UI.DataBindingHandlerAttribute("System.Web.UI.Design.TextDataBindingHandler, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [System.Web.UI.MobileControls.DesignerAdapterAttribute(typeof(System.Web.UI.Design.MobileControls.Adapters.DesignerTextBoxAdapter))]
  [System.Web.UI.ToolboxDataAttribute("<{0}:TextBox runat=\"server\"></{0}:TextBox>")]
  [System.Web.UI.ValidationPropertyAttribute("Text")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class TextBox : System.Web.UI.MobileControls.TextControl, System.Web.UI.IPostBackDataHandler {
    public TextBox() { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Behavior")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("TextBox_MaxLength")]
    public int MaxLength { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Behavior")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("TextBox_Numeric")]
    public bool Numeric { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Behavior")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("TextBox_Password")]
    public bool Password { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Behavior")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("TextBox_Size")]
    public int Size { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Appearance")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("Input_Title")]
    public string Title { get { return default(string); } set { } }
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("TextBox_OnTextChanged")]
    public event System.EventHandler TextChanged { add { } remove { } }
    protected bool LoadPostData(string key, System.Collections.Specialized.NameValueCollection data) { return default(bool); }
    protected virtual void OnTextChanged(System.EventArgs e) { }
    protected void RaisePostDataChangedEvent() { }
    bool System.Web.UI.IPostBackDataHandler.LoadPostData(string key, System.Collections.Specialized.NameValueCollection data) { return default(bool); }
    void System.Web.UI.IPostBackDataHandler.RaisePostDataChangedEvent() { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class TextBoxControlBuilder : System.Web.UI.MobileControls.MobileControlBuilder {
    public TextBoxControlBuilder() { }
    public override bool AllowWhitespaceLiterals() { return default(bool); }
  }
  [System.ComponentModel.ToolboxItemAttribute(false)]
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public abstract partial class TextControl : System.Web.UI.MobileControls.MobileControl {
    protected TextControl() { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Appearance")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("TextControl_Text")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(3))]
    public string Text { get { return default(string); } set { } }
  }
  [System.ComponentModel.DefaultPropertyAttribute("Text")]
  [System.ComponentModel.DesignerAttribute(typeof(System.Web.UI.Design.MobileControls.TextViewDesigner))]
  [System.ComponentModel.ToolboxItemAttribute("System.Web.UI.Design.WebControlToolboxItem, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.UI.DataBindingHandlerAttribute("System.Web.UI.Design.TextDataBindingHandler, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [System.Web.UI.MobileControls.DesignerAdapterAttribute("System.Web.UI.Design.MobileControls.Adapters.DesignerTextViewAdapter")]
  [System.Web.UI.ToolboxDataAttribute("<{0}:TextView runat=\"server\">TextView</{0}:TextView>")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class TextView : System.Web.UI.MobileControls.PagedControl {
    public TextView() { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public int FirstVisibleElementIndex { get { return default(int); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public int FirstVisibleElementOffset { get { return default(int); } }
    protected override int InternalItemCount { get { return default(int); } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public new int ItemCount { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public new int ItemsPerPage { get { return default(int); } set { } }
    protected override int ItemWeight { get { return default(int); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public int LastVisibleElementIndex { get { return default(int); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public int LastVisibleElementOffset { get { return default(int); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Appearance")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("TextView_Text")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(2))]
    public string Text { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public new event System.Web.UI.MobileControls.LoadItemsEventHandler LoadItems { add { } remove { } }
    public System.Web.UI.MobileControls.TextViewElement GetElement(int index) { return default(System.Web.UI.MobileControls.TextViewElement); }
    protected override void OnRender(System.Web.UI.HtmlTextWriter writer) { }
    public override void PaginateRecursive(System.Web.UI.MobileControls.ControlPager pager) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class TextViewElement {
    internal TextViewElement() { }
    public bool BreakAfter { get { return default(bool); } }
    public bool IsBold { get { return default(bool); } }
    public bool IsItalic { get { return default(bool); } }
    public string Text { get { return default(string); } }
    public string Url { get { return default(string); } }
  }
  [System.ComponentModel.DefaultPropertyAttribute("FormToValidate")]
  [System.ComponentModel.DesignerAttribute(typeof(System.Web.UI.Design.MobileControls.ValidationSummaryDesigner))]
  [System.ComponentModel.ToolboxItemAttribute("System.Web.UI.Design.WebControlToolboxItem, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.UI.MobileControls.DesignerAdapterAttribute(typeof(System.Web.UI.Design.MobileControls.Adapters.DesignerValidationSummaryAdapter))]
  [System.Web.UI.ToolboxDataAttribute("<{0}:ValidationSummary runat=\"server\"></{0}:ValidationSummary>")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class ValidationSummary : System.Web.UI.MobileControls.MobileControl {
    public ValidationSummary() { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Appearance")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("ValidationSummary_BackLabel")]
    public string BackLabel { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.Design.MobileControls.Converters.FormConverter))]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Behavior")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("ValidationSummary_FormToValidate")]
    public string FormToValidate { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.MobileControls.MobileCategoryAttribute("Category_Appearance")]
    [System.Web.UI.MobileControls.MobileSysDescriptionAttribute("ValidationSummary_HeaderText")]
    public string HeaderText { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute("error")]
    public override string StyleReference { get { return default(string); } set { } }
    public System.String[] GetErrorMessages() { return default(System.String[]); }
    protected override void OnLoad(System.EventArgs e) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  public enum Wrapping {
    NotSet = 0,
    NoWrap = 2,
    Wrap = 1,
  }
}
namespace System.Web.UI.MobileControls.Adapters {
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class ChtmlCalendarAdapter : System.Web.UI.MobileControls.Adapters.HtmlControlAdapter {
    public ChtmlCalendarAdapter() { }
    protected new System.Web.UI.MobileControls.Calendar Control { get { return default(System.Web.UI.MobileControls.Calendar); } }
    public override bool RequiresFormTag { get { return default(bool); } }
    public override bool HandlePostBackEvent(string eventArgument) { return default(bool); }
    public override void LoadAdapterState(object state) { }
    public override void OnInit(System.EventArgs e) { }
    public override void OnLoad(System.EventArgs e) { }
    public override void OnPreRender(System.EventArgs e) { }
    public override void Render(System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter writer) { }
    public override object SaveAdapterState() { return default(object); }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class ChtmlCommandAdapter : System.Web.UI.MobileControls.Adapters.HtmlCommandAdapter {
    public ChtmlCommandAdapter() { }
    public override bool RequiresFormTag { get { return default(bool); } }
    protected override void AddAttributes(System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter writer) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class ChtmlFormAdapter : System.Web.UI.MobileControls.Adapters.HtmlFormAdapter {
    public ChtmlFormAdapter() { }
    protected override bool RenderExtraHeadElements(System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter writer) { return default(bool); }
    protected internal override void RenderPagerTag(System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter writer, int pageToNavigate, string text) { }
    protected override bool ShouldRenderFormTag() { return default(bool); }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class ChtmlImageAdapter : System.Web.UI.MobileControls.Adapters.HtmlImageAdapter {
    public ChtmlImageAdapter() { }
    protected override void AddAttributes(System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter writer) { }
    protected internal override void RenderImage(System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter writer) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class ChtmlLinkAdapter : System.Web.UI.MobileControls.Adapters.HtmlLinkAdapter {
    public ChtmlLinkAdapter() { }
    protected override void AddAttributes(System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter writer) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class ChtmlMobileTextWriter : System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter {
    public ChtmlMobileTextWriter(System.IO.TextWriter writer, System.Web.Mobile.MobileCapabilities device) : base (default(System.IO.TextWriter), default(System.Web.Mobile.MobileCapabilities)) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class ChtmlPageAdapter : System.Web.UI.MobileControls.Adapters.HtmlPageAdapter {
    public ChtmlPageAdapter() { }
    protected override string EventArgumentKey { get { return default(string); } }
    protected override string EventSourceKey { get { return default(string); } }
    public override System.Web.UI.HtmlTextWriter CreateTextWriter(System.IO.TextWriter writer) { return default(System.Web.UI.HtmlTextWriter); }
    public override System.Collections.Specialized.NameValueCollection DeterminePostBackMode(System.Web.HttpRequest request, string postEventSourceID, string postEventArgumentID, System.Collections.Specialized.NameValueCollection baseCollection) { return default(System.Collections.Specialized.NameValueCollection); }
    public static new bool DeviceQualifies(System.Web.HttpContext context) { return default(bool); }
    public override void RenderPostBackEvent(System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter writer, string target, string argument) { }
    public override void RenderPostBackHeader(System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter writer, System.Web.UI.MobileControls.Form form) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class ChtmlPhoneCallAdapter : System.Web.UI.MobileControls.Adapters.HtmlPhoneCallAdapter {
    public ChtmlPhoneCallAdapter() { }
    protected override void AddAttributes(System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter writer) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class ChtmlSelectionListAdapter : System.Web.UI.MobileControls.Adapters.HtmlSelectionListAdapter {
    public ChtmlSelectionListAdapter() { }
    public override bool RequiresFormTag { get { return default(bool); } }
    public override void Render(System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter writer) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class ChtmlTextBoxAdapter : System.Web.UI.MobileControls.Adapters.HtmlTextBoxAdapter {
    public ChtmlTextBoxAdapter() { }
    public override bool RequiresFormTag { get { return default(bool); } }
    protected override void AddAttributes(System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter writer) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public abstract partial class ControlAdapter : System.Web.UI.MobileControls.IControlAdapter {
    protected static readonly int BackLabel;
    protected static readonly int CallLabel;
    protected static readonly int GoLabel;
    protected static readonly int LinkLabel;
    protected static readonly int MoreLabel;
    protected static readonly int NextLabel;
    protected static readonly int OKLabel;
    protected static readonly int OptionsLabel;
    protected static readonly int PreviousLabel;
    protected ControlAdapter() { }
    public System.Web.UI.MobileControls.MobileControl Control { get { return default(System.Web.UI.MobileControls.MobileControl); } set { } }
    public virtual System.Web.Mobile.MobileCapabilities Device { get { return default(System.Web.Mobile.MobileCapabilities); } }
    public virtual int ItemWeight { get { return default(int); } }
    public virtual System.Web.UI.MobileControls.MobilePage Page { get { return default(System.Web.UI.MobileControls.MobilePage); } set { } }
    public System.Web.UI.MobileControls.Style Style { get { return default(System.Web.UI.MobileControls.Style); } }
    public virtual int VisibleWeight { get { return default(int); } }
    protected virtual int CalculateOptimumPageWeight(int defaultPageWeight) { return default(int); }
    public virtual void CreateTemplatedUI(bool doDataBind) { }
    protected string GetDefaultLabel(int labelID) { return default(string); }
    public virtual bool HandlePostBackEvent(string eventArgument) { return default(bool); }
    public virtual void LoadAdapterState(object state) { }
    public virtual bool LoadPostData(string key, System.Collections.Specialized.NameValueCollection data, object controlPrivateData, out bool dataChanged) { dataChanged = default(bool); return default(bool); }
    public virtual void OnInit(System.EventArgs e) { }
    public virtual void OnLoad(System.EventArgs e) { }
    public virtual void OnPreRender(System.EventArgs e) { }
    public virtual void OnUnload(System.EventArgs e) { }
    public virtual void Render(System.Web.UI.HtmlTextWriter writer) { }
    protected void RenderChildren(System.Web.UI.HtmlTextWriter writer) { }
    public virtual object SaveAdapterState() { return default(object); }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class HtmlCalendarAdapter : System.Web.UI.MobileControls.Adapters.HtmlControlAdapter {
    public HtmlCalendarAdapter() { }
    protected new System.Web.UI.MobileControls.Calendar Control { get { return default(System.Web.UI.MobileControls.Calendar); } }
    public override void Render(System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter writer) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class HtmlCommandAdapter : System.Web.UI.MobileControls.Adapters.HtmlControlAdapter {
    public HtmlCommandAdapter() { }
    protected new System.Web.UI.MobileControls.Command Control { get { return default(System.Web.UI.MobileControls.Command); } }
    public override bool LoadPostData(string key, System.Collections.Specialized.NameValueCollection data, object controlPrivateData, out bool dataChanged) { dataChanged = default(bool); return default(bool); }
    public override void Render(System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter writer) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class HtmlControlAdapter : System.Web.UI.MobileControls.Adapters.ControlAdapter {
    protected static readonly int NotSecondaryUI;
    public HtmlControlAdapter() { }
    protected System.Web.UI.MobileControls.Adapters.HtmlFormAdapter FormAdapter { get { return default(System.Web.UI.MobileControls.Adapters.HtmlFormAdapter); } }
    protected System.Web.UI.MobileControls.Adapters.HtmlPageAdapter PageAdapter { get { return default(System.Web.UI.MobileControls.Adapters.HtmlPageAdapter); } }
    public virtual bool RequiresFormTag { get { return default(bool); } }
    protected int SecondaryUIMode { get { return default(int); } set { } }
    protected virtual void AddAccesskeyAttribute(System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter writer) { }
    protected virtual void AddAttributes(System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter writer) { }
    protected virtual void AddJPhoneMultiMediaAttributes(System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter writer) { }
    protected void ExitSecondaryUIMode() { }
    public override void LoadAdapterState(object state) { }
    public override void Render(System.Web.UI.HtmlTextWriter writer) { }
    public virtual void Render(System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter writer) { }
    protected virtual void RenderAsHiddenInputField(System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter writer) { }
    protected void RenderBeginLink(System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter writer, string target) { }
    protected void RenderEndLink(System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter writer) { }
    protected void RenderPostBackEventAsAnchor(System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter writer, string argument, string linkText) { }
    protected void RenderPostBackEventAsAttribute(System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter writer, string attributeName, string argument) { }
    protected void RenderPostBackEventReference(System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter writer, string argument) { }
    public override object SaveAdapterState() { return default(object); }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class HtmlFormAdapter : System.Web.UI.MobileControls.Adapters.HtmlControlAdapter {
    public HtmlFormAdapter() { }
    protected new System.Web.UI.MobileControls.Form Control { get { return default(System.Web.UI.MobileControls.Form); } }
    protected internal void DisablePager() { }
    public override void Render(System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter writer) { }
    protected virtual void RenderBodyTag(System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter writer, System.Collections.IDictionary attributes) { }
    protected virtual bool RenderExtraHeadElements(System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter writer) { return default(bool); }
    protected virtual void RenderPager(System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter writer) { }
    protected internal virtual void RenderPagerTag(System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter writer, int pageToNavigate, string text) { }
    protected virtual bool ShouldRenderFormTag() { return default(bool); }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class HtmlImageAdapter : System.Web.UI.MobileControls.Adapters.HtmlControlAdapter {
    public HtmlImageAdapter() { }
    protected new System.Web.UI.MobileControls.Image Control { get { return default(System.Web.UI.MobileControls.Image); } }
    public override void Render(System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter writer) { }
    protected internal virtual void RenderImage(System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter writer) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class HtmlLabelAdapter : System.Web.UI.MobileControls.Adapters.HtmlControlAdapter {
    public HtmlLabelAdapter() { }
    protected new System.Web.UI.MobileControls.TextControl Control { get { return default(System.Web.UI.MobileControls.TextControl); } }
    public override void Render(System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter writer) { }
    protected internal bool WhiteSpace(string s) { return default(bool); }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class HtmlLinkAdapter : System.Web.UI.MobileControls.Adapters.HtmlControlAdapter {
    public HtmlLinkAdapter() { }
    protected new System.Web.UI.MobileControls.Link Control { get { return default(System.Web.UI.MobileControls.Link); } }
    public override void Render(System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter writer) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class HtmlListAdapter : System.Web.UI.MobileControls.Adapters.HtmlControlAdapter {
    public HtmlListAdapter() { }
    protected new System.Web.UI.MobileControls.List Control { get { return default(System.Web.UI.MobileControls.List); } }
    public override void Render(System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter writer) { }
    protected virtual void RenderList(System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter writer) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class HtmlLiteralTextAdapter : System.Web.UI.MobileControls.Adapters.HtmlControlAdapter {
    public HtmlLiteralTextAdapter() { }
    protected new System.Web.UI.MobileControls.LiteralText Control { get { return default(System.Web.UI.MobileControls.LiteralText); } }
    public override void Render(System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter writer) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class HtmlMobileTextWriter : System.Web.UI.MobileControls.Adapters.MobileTextWriter {
    public HtmlMobileTextWriter(System.IO.TextWriter writer, System.Web.Mobile.MobileCapabilities device) : base (default(System.IO.TextWriter), default(System.Web.Mobile.MobileCapabilities)) { }
    protected internal bool RenderBodyColor { get { return default(bool); } set { } }
    protected internal bool RenderBold { get { return default(bool); } set { } }
    protected internal bool RenderDivAlign { get { return default(bool); } set { } }
    protected internal bool RenderDivNoWrap { get { return default(bool); } set { } }
    protected internal bool RenderFontColor { get { return default(bool); } set { } }
    protected internal bool RenderFontName { get { return default(bool); } set { } }
    protected internal bool RenderFontSize { get { return default(bool); } set { } }
    protected internal bool RenderItalic { get { return default(bool); } set { } }
    protected internal bool RequiresNoBreakInFormatting { get { return default(bool); } set { } }
    public void BeginStyleContext() { }
    public void EndStyleContext() { }
    public override void EnterFormat(System.Web.UI.MobileControls.Style style) { }
    public override void EnterLayout(System.Web.UI.MobileControls.Style style) { }
    public new void EnterStyle(System.Web.UI.MobileControls.Style style) { }
    public override void ExitFormat(System.Web.UI.MobileControls.Style style) { }
    public override void ExitFormat(System.Web.UI.MobileControls.Style style, bool breakAfter) { }
    public override void ExitLayout(System.Web.UI.MobileControls.Style style) { }
    public override void ExitLayout(System.Web.UI.MobileControls.Style style, bool breakAfter) { }
    public new void ExitStyle(System.Web.UI.MobileControls.Style style) { }
    public void ExitStyle(System.Web.UI.MobileControls.Style style, bool breakAfter) { }
    protected internal void MarkStyleContext() { }
    protected internal void UnMarkStyleContext() { }
    public override void Write(char c) { }
    public override void Write(string text) { }
    public override void WriteBeginTag(string tag) { }
    public new void WriteBreak() { }
    public override void WriteEncodedText(string text) { }
    public override void WriteFullBeginTag(string tag) { }
    public void WriteHiddenField(string name, string value) { }
    public override void WriteLine(string text) { }
    public void WriteText(string text, bool encodeText) { }
    public void WriteUrlParameter(string name, string value) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class HtmlObjectListAdapter : System.Web.UI.MobileControls.Adapters.HtmlControlAdapter {
    protected internal static readonly string BackToList;
    protected internal static readonly string ShowMore;
    protected internal static readonly string ShowMoreFormat;
    public HtmlObjectListAdapter() { }
    protected new System.Web.UI.MobileControls.ObjectList Control { get { return default(System.Web.UI.MobileControls.ObjectList); } }
    public override void CreateTemplatedUI(bool doDataBind) { }
    public override bool HandlePostBackEvent(string eventArgument) { return default(bool); }
    protected bool HasCommands() { return default(bool); }
    protected bool HasDefaultCommand() { return default(bool); }
    protected bool HasItemDetails() { return default(bool); }
    public override void OnInit(System.EventArgs e) { }
    protected bool OnlyHasDefaultCommand() { return default(bool); }
    public override void OnPreRender(System.EventArgs e) { }
    public override void Render(System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter writer) { }
    protected virtual void RenderItemDetails(System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter writer, System.Web.UI.MobileControls.ObjectListItem item) { }
    protected virtual void RenderItemsList(System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter writer) { }
    protected virtual bool ShouldRenderAsTable() { return default(bool); }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class HtmlPageAdapter : System.Web.UI.MobileControls.Adapters.HtmlControlAdapter, System.Web.UI.MobileControls.IControlAdapter, System.Web.UI.MobileControls.IPageAdapter {
    public HtmlPageAdapter() { }
    protected internal HtmlPageAdapter(int defaultPageWeight) { }
    public virtual System.Collections.IList CacheVaryByHeaders { get { return default(System.Collections.IList); } }
    public System.Collections.IDictionary CookielessDataDictionary { get { return default(System.Collections.IDictionary); } set { } }
    protected virtual string EventArgumentKey { get { return default(string); } }
    protected virtual string EventSourceKey { get { return default(string); } }
    public virtual int OptimumPageWeight { get { return default(int); } }
    public override System.Web.UI.MobileControls.MobilePage Page { get { return default(System.Web.UI.MobileControls.MobilePage); } set { } }
    public bool PersistCookielessData { get { return default(bool); } set { } }
    public virtual System.Web.UI.HtmlTextWriter CreateTextWriter(System.IO.TextWriter writer) { return default(System.Web.UI.HtmlTextWriter); }
    public virtual System.Collections.Specialized.NameValueCollection DeterminePostBackMode(System.Web.HttpRequest request, string postEventSourceID, string postEventArgumentID, System.Collections.Specialized.NameValueCollection baseCollection) { return default(System.Collections.Specialized.NameValueCollection); }
    public static bool DeviceQualifies(System.Web.HttpContext context) { return default(bool); }
    public string GetFormUrl(System.Web.UI.MobileControls.Form form) { return default(string); }
    public virtual bool HandleError(System.Exception e, System.Web.UI.HtmlTextWriter writer) { return default(bool); }
    public virtual bool HandlePagePostBackEvent(string eventSource, string eventArgument) { return default(bool); }
    public virtual bool IsFormRendered(System.Web.UI.MobileControls.Form form) { return default(bool); }
    public override void Render(System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter writer) { }
    public virtual void RenderForm(System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter writer, System.Web.UI.MobileControls.Form form) { }
    protected void RenderHiddenVariables(System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter writer) { }
    public virtual void RenderPostBackEvent(System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter writer, string target, string argument) { }
    public virtual void RenderPostBackHeader(System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter writer, System.Web.UI.MobileControls.Form form) { }
    public virtual void RenderUrlPostBackEvent(System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter writer, string target, string argument) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class HtmlPanelAdapter : System.Web.UI.MobileControls.Adapters.HtmlControlAdapter {
    public HtmlPanelAdapter() { }
    protected new System.Web.UI.MobileControls.Panel Control { get { return default(System.Web.UI.MobileControls.Panel); } }
    public override void OnInit(System.EventArgs e) { }
    public override void Render(System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter writer) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class HtmlPhoneCallAdapter : System.Web.UI.MobileControls.Adapters.HtmlControlAdapter {
    public HtmlPhoneCallAdapter() { }
    protected new System.Web.UI.MobileControls.PhoneCall Control { get { return default(System.Web.UI.MobileControls.PhoneCall); } }
    public override void Render(System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter writer) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class HtmlSelectionListAdapter : System.Web.UI.MobileControls.Adapters.HtmlControlAdapter {
    public HtmlSelectionListAdapter() { }
    protected new System.Web.UI.MobileControls.SelectionList Control { get { return default(System.Web.UI.MobileControls.SelectionList); } }
    public override bool LoadPostData(string key, System.Collections.Specialized.NameValueCollection data, object controlPrivateData, out bool dataChanged) { dataChanged = default(bool); return default(bool); }
    public override void OnInit(System.EventArgs e) { }
    public override void Render(System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter writer) { }
    protected override void RenderAsHiddenInputField(System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter writer) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class HtmlTextBoxAdapter : System.Web.UI.MobileControls.Adapters.HtmlControlAdapter {
    public HtmlTextBoxAdapter() { }
    protected new System.Web.UI.MobileControls.TextBox Control { get { return default(System.Web.UI.MobileControls.TextBox); } }
    public override void OnInit(System.EventArgs e) { }
    public override void Render(System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter writer) { }
    protected override void RenderAsHiddenInputField(System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter writer) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class HtmlTextViewAdapter : System.Web.UI.MobileControls.Adapters.HtmlControlAdapter {
    public HtmlTextViewAdapter() { }
    protected new System.Web.UI.MobileControls.TextView Control { get { return default(System.Web.UI.MobileControls.TextView); } }
    public override void Render(System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter writer) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class HtmlValidationSummaryAdapter : System.Web.UI.MobileControls.Adapters.HtmlControlAdapter {
    public HtmlValidationSummaryAdapter() { }
    protected new System.Web.UI.MobileControls.ValidationSummary Control { get { return default(System.Web.UI.MobileControls.ValidationSummary); } }
    public override void OnInit(System.EventArgs e) { }
    public override void Render(System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter writer) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class HtmlValidatorAdapter : System.Web.UI.MobileControls.Adapters.HtmlControlAdapter {
    public HtmlValidatorAdapter() { }
    protected new System.Web.UI.MobileControls.BaseValidator Control { get { return default(System.Web.UI.MobileControls.BaseValidator); } }
    public override void Render(System.Web.UI.MobileControls.Adapters.HtmlMobileTextWriter writer) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class MobileTextWriter : System.Web.UI.MobileControls.Adapters.MultiPartWriter {
    public MobileTextWriter(System.IO.TextWriter writer, System.Web.Mobile.MobileCapabilities device) : base (default(System.IO.TextWriter)) { }
    public System.Web.Mobile.MobileCapabilities Device { get { return default(System.Web.Mobile.MobileCapabilities); } }
    public override bool SupportsMultiPart { get { return default(bool); } }
    public override void AddResource(string url, string contentType) { }
    public override void BeginFile(string url, string contentType, string charset) { }
    public override void BeginResponse() { }
    public override void EndFile() { }
    public override void EndResponse() { }
    public virtual void EnterFormat(System.Web.UI.MobileControls.Style style) { }
    public virtual void EnterLayout(System.Web.UI.MobileControls.Style style) { }
    public void EnterStyle(System.Web.UI.MobileControls.Style style) { }
    public virtual void ExitFormat(System.Web.UI.MobileControls.Style style) { }
    public virtual void ExitFormat(System.Web.UI.MobileControls.Style style, bool breakAfter) { }
    public virtual void ExitLayout(System.Web.UI.MobileControls.Style style) { }
    public virtual void ExitLayout(System.Web.UI.MobileControls.Style style, bool breakAfter) { }
    public void ExitStyle(System.Web.UI.MobileControls.Style style) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public abstract partial class MultiPartWriter : System.Web.UI.HtmlTextWriter {
    protected MultiPartWriter(System.IO.TextWriter writer) : base (default(System.IO.TextWriter)) { }
    public virtual bool SupportsMultiPart { get { return default(bool); } }
    public void AddResource(string url) { }
    public abstract void AddResource(string url, string contentType);
    public abstract void BeginFile(string url, string contentType, string charset);
    public abstract void BeginResponse();
    public abstract void EndFile();
    public abstract void EndResponse();
    public virtual string NewUrl(string filetype) { return default(string); }
  }
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Unrestricted=true)]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
  public partial class SR {
    public const string CalendarAdapterFirstPrompt = "CalendarAdapterFirstPrompt";
    public const string CalendarAdapterOptionChooseDate = "CalendarAdapterOptionChooseDate";
    public const string CalendarAdapterOptionChooseMonth = "CalendarAdapterOptionChooseMonth";
    public const string CalendarAdapterOptionChooseWeek = "CalendarAdapterOptionChooseWeek";
    public const string CalendarAdapterOptionEra = "CalendarAdapterOptionEra";
    public const string CalendarAdapterOptionPrompt = "CalendarAdapterOptionPrompt";
    public const string CalendarAdapterOptionType = "CalendarAdapterOptionType";
    public const string CalendarAdapterTextBoxErrorMessage = "CalendarAdapterTextBoxErrorMessage";
    public const string ChtmlImageAdapterDecimalCodeExpectedAfterGroupChar = "ChtmlImageAdapterDecimalCodeExpectedAfterGroupChar";
    public const string ChtmlPageAdapterRedirectLinkLabel = "ChtmlPageAdapterRedirectLinkLabel";
    public const string ChtmlPageAdapterRedirectPageContent = "ChtmlPageAdapterRedirectPageContent";
    public const string ControlAdapterBasePagePropertyShouldNotBeSet = "ControlAdapterBasePagePropertyShouldNotBeSet";
    public const string FormAdapterMultiControlsAttemptSecondaryUI = "FormAdapterMultiControlsAttemptSecondaryUI";
    public const string MobileTextWriterNotMultiPart = "MobileTextWriterNotMultiPart";
    public const string ObjectListAdapter_InvalidPostedData = "ObjectListAdapter_InvalidPostedData";
    public const string WmlMobileTextWriterBackLabel = "WmlMobileTextWriterBackLabel";
    public const string WmlMobileTextWriterGoLabel = "WmlMobileTextWriterGoLabel";
    public const string WmlMobileTextWriterOKLabel = "WmlMobileTextWriterOKLabel";
    public const string WmlObjectListAdapterDetails = "WmlObjectListAdapterDetails";
    public const string WmlPageAdapterMethod = "WmlPageAdapterMethod";
    public const string WmlPageAdapterPartialStackTrace = "WmlPageAdapterPartialStackTrace";
    public const string WmlPageAdapterServerError = "WmlPageAdapterServerError";
    public const string WmlPageAdapterStackTrace = "WmlPageAdapterStackTrace";
    public const string XhtmlCssHandler_IdNotPresent = "XhtmlCssHandler_IdNotPresent";
    public const string XhtmlCssHandler_StylesheetNotFound = "XhtmlCssHandler_StylesheetNotFound";
    public const string XhtmlMobileTextWriter_CacheKeyNotSet = "XhtmlMobileTextWriter_CacheKeyNotSet";
    public const string XhtmlMobileTextWriter_SessionKeyNotSet = "XhtmlMobileTextWriter_SessionKeyNotSet";
    public const string XhtmlObjectListAdapter_InvalidPostedData = "XhtmlObjectListAdapter_InvalidPostedData";
    public SR() { }
    public static bool GetBoolean(System.Globalization.CultureInfo culture, string name) { return default(bool); }
    public static bool GetBoolean(string name) { return default(bool); }
    public static byte GetByte(System.Globalization.CultureInfo culture, string name) { return default(byte); }
    public static byte GetByte(string name) { return default(byte); }
    public static char GetChar(System.Globalization.CultureInfo culture, string name) { return default(char); }
    public static char GetChar(string name) { return default(char); }
    public static double GetDouble(System.Globalization.CultureInfo culture, string name) { return default(double); }
    public static double GetDouble(string name) { return default(double); }
    public static float GetFloat(System.Globalization.CultureInfo culture, string name) { return default(float); }
    public static float GetFloat(string name) { return default(float); }
    public static int GetInt(System.Globalization.CultureInfo culture, string name) { return default(int); }
    public static int GetInt(string name) { return default(int); }
    public static long GetLong(System.Globalization.CultureInfo culture, string name) { return default(long); }
    public static long GetLong(string name) { return default(long); }
    public static object GetObject(System.Globalization.CultureInfo culture, string name) { return default(object); }
    public static object GetObject(string name) { return default(object); }
    public static short GetShort(System.Globalization.CultureInfo culture, string name) { return default(short); }
    public static short GetShort(string name) { return default(short); }
    public static string GetString(System.Globalization.CultureInfo culture, string name) { return default(string); }
    public static string GetString(System.Globalization.CultureInfo culture, string name, params System.Object[] args) { return default(string); }
    public static string GetString(string name) { return default(string); }
    public static string GetString(string name, params System.Object[] args) { return default(string); }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class UpWmlMobileTextWriter : System.Web.UI.MobileControls.Adapters.WmlMobileTextWriter {
    public UpWmlMobileTextWriter(System.IO.TextWriter writer, System.Web.Mobile.MobileCapabilities device, System.Web.UI.MobileControls.MobilePage page) : base (default(System.IO.TextWriter), default(System.Web.Mobile.MobileCapabilities), default(System.Web.UI.MobileControls.MobilePage)) { }
    protected override void AnalyzePostBack(bool includeVariables, System.Web.UI.MobileControls.Adapters.WmlPostFieldType postBackType) { }
    public override void BeginCustomMarkup() { }
    public override void BeginForm(System.Web.UI.MobileControls.Form form) { }
    protected override string CalculateFormPostBackUrl(bool externalSubmit, ref bool encode) { return default(string); }
    protected override string CalculateFormQueryString() { return default(string); }
    public override void EndForm() { }
    protected override void OpenParagraph(System.Web.UI.MobileControls.Adapters.WmlMobileTextWriter.WmlLayout layout, bool writeAlignment, bool writeWrapping) { }
    protected override void PostAnalyzeForm() { }
    public override void RenderBeginHyperlink(string targetUrl, bool encodeUrl, string softkeyLabel, bool implicitSoftkeyLabel, bool mapToSoftkey) { }
    public override void RenderBeginPostBack(string softkeyLabel, bool implicitSoftkeyLabel, bool mapToSoftkey) { }
    public override void RenderBeginSelect(string name, string iname, string ivalue, string title, bool multiSelect) { }
    protected override void RenderEndForm() { }
    public override void RenderEndHyperlink(bool breakAfter) { }
    public override void RenderEndPostBack(string target, string argument, System.Web.UI.MobileControls.Adapters.WmlPostFieldType postBackType, bool includeVariables, bool breakAfter) { }
    public override void RenderEndSelect(bool breakAfter) { }
    public override void RenderImage(string source, string localSource, string alternateText, bool breakAfter) { }
    public override void RenderSelectOption(string text) { }
    public override void RenderSelectOption(string text, string value) { }
    public override void RenderText(string text, bool breakAfter, bool encodeText) { }
    public override void RenderTextBox(string id, string value, string format, string title, bool password, int size, int maxLength, bool generateRandomID, bool breakAfter) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class UpWmlPageAdapter : System.Web.UI.MobileControls.Adapters.WmlPageAdapter {
    public UpWmlPageAdapter() { }
    public override System.Web.UI.HtmlTextWriter CreateTextWriter(System.IO.TextWriter writer) { return default(System.Web.UI.HtmlTextWriter); }
    public static new bool DeviceQualifies(System.Web.HttpContext context) { return default(bool); }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class WmlCalendarAdapter : System.Web.UI.MobileControls.Adapters.WmlControlAdapter {
    public WmlCalendarAdapter() { }
    protected new System.Web.UI.MobileControls.Calendar Control { get { return default(System.Web.UI.MobileControls.Calendar); } }
    public override bool HandlePostBackEvent(string eventArgument) { return default(bool); }
    public override void LoadAdapterState(object state) { }
    public override void OnInit(System.EventArgs e) { }
    public override void OnLoad(System.EventArgs e) { }
    public override void OnPreRender(System.EventArgs e) { }
    public override void Render(System.Web.UI.MobileControls.Adapters.WmlMobileTextWriter writer) { }
    public override object SaveAdapterState() { return default(object); }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class WmlCommandAdapter : System.Web.UI.MobileControls.Adapters.WmlControlAdapter {
    public WmlCommandAdapter() { }
    protected new System.Web.UI.MobileControls.Command Control { get { return default(System.Web.UI.MobileControls.Command); } }
    public override void Render(System.Web.UI.MobileControls.Adapters.WmlMobileTextWriter writer) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class WmlControlAdapter : System.Web.UI.MobileControls.Adapters.ControlAdapter {
    protected static readonly int NotSecondaryUI;
    public WmlControlAdapter() { }
    protected System.Web.UI.MobileControls.Adapters.WmlFormAdapter FormAdapter { get { return default(System.Web.UI.MobileControls.Adapters.WmlFormAdapter); } }
    protected System.Web.UI.MobileControls.Adapters.WmlPageAdapter PageAdapter { get { return default(System.Web.UI.MobileControls.Adapters.WmlPageAdapter); } }
    protected int SecondaryUIMode { get { return default(int); } set { } }
    protected string DeterminePostBack(string target) { return default(string); }
    protected void ExitSecondaryUIMode() { }
    protected virtual string GetPostBackValue() { return default(string); }
    public override void LoadAdapterState(object state) { }
    public override void Render(System.Web.UI.HtmlTextWriter writer) { }
    public virtual void Render(System.Web.UI.MobileControls.Adapters.WmlMobileTextWriter writer) { }
    protected void RenderBeginLink(System.Web.UI.MobileControls.Adapters.WmlMobileTextWriter writer, string targetUrl, string softkeyLabel, bool implicitSoftkeyLabel, bool mapToSoftkey) { }
    protected void RenderEndLink(System.Web.UI.MobileControls.Adapters.WmlMobileTextWriter writer, string targetUrl, bool breakAfter) { }
    protected void RenderLink(System.Web.UI.MobileControls.Adapters.WmlMobileTextWriter writer, string targetUrl, string softkeyLabel, bool implicitSoftkeyLabel, bool mapToSoftkey, string text, bool breakAfter) { }
    protected void RenderPostBackEvent(System.Web.UI.MobileControls.Adapters.WmlMobileTextWriter writer, string argument, string softkeyLabel, bool mapToSoftkey, string text, bool breakAfter) { }
    protected void RenderPostBackEvent(System.Web.UI.MobileControls.Adapters.WmlMobileTextWriter writer, string argument, string softkeyLabel, bool mapToSoftkey, string text, bool breakAfter, System.Web.UI.MobileControls.Adapters.WmlPostFieldType postBackType) { }
    protected void RenderSubmitEvent(System.Web.UI.MobileControls.Adapters.WmlMobileTextWriter writer, string softkeyLabel, string text, bool breakAfter) { }
    public override object SaveAdapterState() { return default(object); }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class WmlFormAdapter : System.Web.UI.MobileControls.Adapters.WmlControlAdapter {
    public WmlFormAdapter() { }
    protected new System.Web.UI.MobileControls.Form Control { get { return default(System.Web.UI.MobileControls.Form); } }
    public virtual System.Collections.IDictionary CalculatePostBackVariables() { return default(System.Collections.IDictionary); }
    public override bool HandlePostBackEvent(string eventArgument) { return default(bool); }
    public override void Render(System.Web.UI.MobileControls.Adapters.WmlMobileTextWriter writer) { }
    protected internal virtual void RenderCardTag(System.Web.UI.MobileControls.Adapters.WmlMobileTextWriter writer, System.Collections.IDictionary attributes) { }
    protected internal virtual void RenderExtraCardElements(System.Web.UI.MobileControls.Adapters.WmlMobileTextWriter writer) { }
    protected virtual void RenderPager(System.Web.UI.MobileControls.Adapters.WmlMobileTextWriter writer) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class WmlImageAdapter : System.Web.UI.MobileControls.Adapters.WmlControlAdapter {
    public WmlImageAdapter() { }
    protected new System.Web.UI.MobileControls.Image Control { get { return default(System.Web.UI.MobileControls.Image); } }
    public override void Render(System.Web.UI.MobileControls.Adapters.WmlMobileTextWriter writer) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class WmlLabelAdapter : System.Web.UI.MobileControls.Adapters.WmlControlAdapter {
    public WmlLabelAdapter() { }
    protected new System.Web.UI.MobileControls.TextControl Control { get { return default(System.Web.UI.MobileControls.TextControl); } }
    public override void Render(System.Web.UI.MobileControls.Adapters.WmlMobileTextWriter writer) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class WmlLinkAdapter : System.Web.UI.MobileControls.Adapters.WmlControlAdapter {
    public WmlLinkAdapter() { }
    protected new System.Web.UI.MobileControls.Link Control { get { return default(System.Web.UI.MobileControls.Link); } }
    public override void Render(System.Web.UI.MobileControls.Adapters.WmlMobileTextWriter writer) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class WmlListAdapter : System.Web.UI.MobileControls.Adapters.WmlControlAdapter {
    public WmlListAdapter() { }
    protected new System.Web.UI.MobileControls.List Control { get { return default(System.Web.UI.MobileControls.List); } }
    public override void OnInit(System.EventArgs e) { }
    public override void Render(System.Web.UI.MobileControls.Adapters.WmlMobileTextWriter writer) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class WmlLiteralTextAdapter : System.Web.UI.MobileControls.Adapters.WmlControlAdapter {
    public WmlLiteralTextAdapter() { }
    protected new System.Web.UI.MobileControls.LiteralText Control { get { return default(System.Web.UI.MobileControls.LiteralText); } }
    public override void Render(System.Web.UI.MobileControls.Adapters.WmlMobileTextWriter writer) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class WmlMobileTextWriter : System.Web.UI.MobileControls.Adapters.MobileTextWriter {
    public WmlMobileTextWriter(System.IO.TextWriter writer, System.Web.Mobile.MobileCapabilities device, System.Web.UI.MobileControls.MobilePage page) : base (default(System.IO.TextWriter), default(System.Web.Mobile.MobileCapabilities)) { }
    public bool AnalyzeMode { get { return default(bool); } set { } }
    protected System.Web.UI.MobileControls.Form CurrentForm { get { return default(System.Web.UI.MobileControls.Form); } }
    protected virtual System.Web.UI.MobileControls.Adapters.WmlMobileTextWriter.WmlFormat DefaultFormat { get { return default(System.Web.UI.MobileControls.Adapters.WmlMobileTextWriter.WmlFormat); } }
    protected virtual System.Web.UI.MobileControls.Adapters.WmlMobileTextWriter.WmlLayout DefaultLayout { get { return default(System.Web.UI.MobileControls.Adapters.WmlMobileTextWriter.WmlLayout); } }
    protected int NumberOfSoftkeys { get { return default(int); } }
    protected System.Web.UI.MobileControls.MobilePage Page { get { return default(System.Web.UI.MobileControls.MobilePage); } }
    protected bool PendingBreak { get { return default(bool); } set { } }
    public void AddFormVariable(string clientID, string value, bool generateRandomID) { }
    protected virtual void AnalyzePostBack(bool includeVariables, System.Web.UI.MobileControls.Adapters.WmlPostFieldType postBackType) { }
    public virtual void BeginCustomMarkup() { }
    public virtual void BeginForm(System.Web.UI.MobileControls.Form form) { }
    protected virtual string CalculateFormPostBackUrl(bool externalSubmit, ref bool encode) { return default(string); }
    protected virtual string CalculateFormQueryString() { return default(string); }
    protected virtual void CloseCharacterFormat() { }
    protected virtual void CloseParagraph() { }
    public virtual void EndCustomMarkup() { }
    public virtual void EndForm() { }
    protected virtual void EnsureFormat() { }
    protected virtual void EnsureLayout() { }
    public override void EnterFormat(System.Web.UI.MobileControls.Style style) { }
    public override void EnterLayout(System.Web.UI.MobileControls.Style style) { }
    public override void ExitFormat(System.Web.UI.MobileControls.Style style) { }
    public override void ExitLayout(System.Web.UI.MobileControls.Style style, bool breakAfter) { }
    public virtual bool IsValidSoftkeyLabel(string label) { return default(bool); }
    protected internal string MapClientIDToShortName(string clientID, bool generateRandomID) { return default(string); }
    protected virtual void OpenCharacterFormat(System.Web.UI.MobileControls.Adapters.WmlMobileTextWriter.WmlFormat format, bool writeBold, bool writeItalic, bool writeSize) { }
    protected virtual void OpenParagraph(System.Web.UI.MobileControls.Adapters.WmlMobileTextWriter.WmlLayout layout, bool writeAlignment, bool writeWrapping) { }
    protected virtual void PostAnalyzeForm() { }
    protected virtual void RenderBeginForm(System.Web.UI.MobileControls.Form form) { }
    public virtual void RenderBeginHyperlink(string targetUrl, bool encodeUrl, string softkeyLabel, bool implicitSoftkeyLabel, bool mapToSoftkey) { }
    public virtual void RenderBeginPostBack(string softkeyLabel, bool implicitSoftkeyLabel, bool mapToSoftkey) { }
    public virtual void RenderBeginSelect(string name, string iname, string ivalue, string title, bool multiSelect) { }
    protected void RenderDoEvent(string doType, string target, string arg, System.Web.UI.MobileControls.Adapters.WmlPostFieldType postBackType, string text, bool includeVariables) { }
    protected virtual void RenderEndForm() { }
    public virtual void RenderEndHyperlink(bool breakAfter) { }
    public virtual void RenderEndPostBack(string target, string argument, System.Web.UI.MobileControls.Adapters.WmlPostFieldType postBackType, bool includeVariables, bool breakAfter) { }
    public virtual void RenderEndSelect(bool breakAfter) { }
    public virtual void RenderExtraCards() { }
    protected void RenderFormDoEvent(string doType, string arg, System.Web.UI.MobileControls.Adapters.WmlPostFieldType postBackType, string text) { }
    public virtual void RenderGoAction(string target, string argument, System.Web.UI.MobileControls.Adapters.WmlPostFieldType postBackType, bool includeVariables) { }
    public virtual void RenderImage(string source, string localSource, string alternateText, bool breakAfter) { }
    public virtual void RenderSelectOption(string text) { }
    public virtual void RenderSelectOption(string text, string value) { }
    public void RenderText(string text) { }
    public void RenderText(string text, bool breakAfter) { }
    public virtual void RenderText(string text, bool breakAfter, bool encodeText) { }
    public virtual void RenderTextBox(string id, string value, string format, string title, bool password, int size, int maxLength, bool generateRandomID, bool breakAfter) { }
    public virtual void ResetFormattingState() { }
    protected virtual bool UsePostBackCard(bool includeVariables) { return default(bool); }
    public override void WriteAttribute(string attribute, string value, bool encode) { }
    protected new void WriteBreak() { }
    public override void WriteEncodedText(string text) { }
    public override void WriteEncodedUrl(string url) { }
    public void WritePostField(string name, string value) { }
    public void WritePostField(string name, string value, System.Web.UI.MobileControls.Adapters.WmlPostFieldType type) { }
    public void WritePostFieldVariable(string name, string arg) { }
    public void WriteText(string text, bool encodeText) { }
    protected void WriteTextEncodedAttribute(string attribute, string value) { }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    protected partial class WmlFormat {
      public WmlFormat(bool bold, bool italic, System.Web.UI.MobileControls.FontSize size) { }
      public WmlFormat(System.Web.UI.MobileControls.Style style, System.Web.UI.MobileControls.Adapters.WmlMobileTextWriter.WmlFormat currentFormat) { }
      public bool Bold { get { return default(bool); } set { } }
      public bool Italic { get { return default(bool); } set { } }
      public System.Web.UI.MobileControls.FontSize Size { get { return default(System.Web.UI.MobileControls.FontSize); } set { } }
      public bool WrittenBold { get { return default(bool); } set { } }
      public bool WrittenItalic { get { return default(bool); } set { } }
      public bool WrittenSize { get { return default(bool); } set { } }
      public virtual bool Compare(System.Web.UI.MobileControls.Adapters.WmlMobileTextWriter.WmlFormat format) { return default(bool); }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    protected partial class WmlLayout {
      public WmlLayout(System.Web.UI.MobileControls.Alignment alignment, System.Web.UI.MobileControls.Wrapping wrapping) { }
      public WmlLayout(System.Web.UI.MobileControls.Style style, System.Web.UI.MobileControls.Adapters.WmlMobileTextWriter.WmlLayout currentLayout) { }
      public System.Web.UI.MobileControls.Alignment Align { get { return default(System.Web.UI.MobileControls.Alignment); } set { } }
      public System.Web.UI.MobileControls.Wrapping Wrap { get { return default(System.Web.UI.MobileControls.Wrapping); } set { } }
      public virtual bool Compare(System.Web.UI.MobileControls.Adapters.WmlMobileTextWriter.WmlLayout layout) { return default(bool); }
    }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class WmlObjectListAdapter : System.Web.UI.MobileControls.Adapters.WmlControlAdapter {
    public WmlObjectListAdapter() { }
    protected new System.Web.UI.MobileControls.ObjectList Control { get { return default(System.Web.UI.MobileControls.ObjectList); } }
    public override void CreateTemplatedUI(bool doDataBind) { }
    public override bool HandlePostBackEvent(string eventArgument) { return default(bool); }
    protected bool HasCommands() { return default(bool); }
    protected bool HasDefaultCommand() { return default(bool); }
    protected bool HasItemDetails() { return default(bool); }
    protected bool OnlyHasDefaultCommand() { return default(bool); }
    public override void OnPreRender(System.EventArgs e) { }
    public override void Render(System.Web.UI.MobileControls.Adapters.WmlMobileTextWriter writer) { }
    protected virtual void RenderItemDetails(System.Web.UI.MobileControls.Adapters.WmlMobileTextWriter writer, System.Web.UI.MobileControls.ObjectListItem item) { }
    protected virtual void RenderItemMenu(System.Web.UI.MobileControls.Adapters.WmlMobileTextWriter writer, System.Web.UI.MobileControls.ObjectListItem item) { }
    protected virtual void RenderItemsList(System.Web.UI.MobileControls.Adapters.WmlMobileTextWriter writer) { }
    protected virtual bool ShouldRenderAsTable() { return default(bool); }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class WmlPageAdapter : System.Web.UI.MobileControls.Adapters.WmlControlAdapter, System.Web.UI.MobileControls.IControlAdapter, System.Web.UI.MobileControls.IPageAdapter {
    public WmlPageAdapter() { }
    public virtual System.Collections.IList CacheVaryByHeaders { get { return default(System.Collections.IList); } }
    public System.Collections.IDictionary CookielessDataDictionary { get { return default(System.Collections.IDictionary); } set { } }
    public virtual int OptimumPageWeight { get { return default(int); } }
    public override System.Web.UI.MobileControls.MobilePage Page { get { return default(System.Web.UI.MobileControls.MobilePage); } set { } }
    public bool PersistCookielessData { get { return default(bool); } set { } }
    public virtual System.Web.UI.HtmlTextWriter CreateTextWriter(System.IO.TextWriter writer) { return default(System.Web.UI.HtmlTextWriter); }
    public virtual System.Collections.Specialized.NameValueCollection DeterminePostBackMode(System.Web.HttpRequest request, string postEventSourceID, string postEventArgumentID, System.Collections.Specialized.NameValueCollection baseCollection) { return default(System.Collections.Specialized.NameValueCollection); }
    public static bool DeviceQualifies(System.Web.HttpContext context) { return default(bool); }
    public virtual bool HandleError(System.Exception e, System.Web.UI.HtmlTextWriter writer) { return default(bool); }
    public virtual bool HandlePagePostBackEvent(string eventSource, string eventArgument) { return default(bool); }
    public virtual bool IsFormRendered(System.Web.UI.MobileControls.Form form) { return default(bool); }
    public override void Render(System.Web.UI.MobileControls.Adapters.WmlMobileTextWriter writer) { }
    protected virtual void RenderForm(System.Web.UI.MobileControls.Adapters.WmlMobileTextWriter writer, System.Web.UI.MobileControls.Form form) { }
    public virtual bool RendersMultipleForms() { return default(bool); }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class WmlPanelAdapter : System.Web.UI.MobileControls.Adapters.WmlControlAdapter {
    public WmlPanelAdapter() { }
    protected new System.Web.UI.MobileControls.Panel Control { get { return default(System.Web.UI.MobileControls.Panel); } }
    public override void Render(System.Web.UI.MobileControls.Adapters.WmlMobileTextWriter writer) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class WmlPhoneCallAdapter : System.Web.UI.MobileControls.Adapters.WmlControlAdapter {
    public WmlPhoneCallAdapter() { }
    protected new System.Web.UI.MobileControls.PhoneCall Control { get { return default(System.Web.UI.MobileControls.PhoneCall); } }
    public override void Render(System.Web.UI.MobileControls.Adapters.WmlMobileTextWriter writer) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  public enum WmlPostFieldType {
    Normal = 0,
    Raw = 3,
    Submit = 1,
    Variable = 2,
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class WmlSelectionListAdapter : System.Web.UI.MobileControls.Adapters.WmlControlAdapter {
    public WmlSelectionListAdapter() { }
    protected new System.Web.UI.MobileControls.SelectionList Control { get { return default(System.Web.UI.MobileControls.SelectionList); } }
    protected override string GetPostBackValue() { return default(string); }
    public override bool LoadPostData(string key, System.Collections.Specialized.NameValueCollection data, object controlPrivateData, out bool dataChanged) { dataChanged = default(bool); return default(bool); }
    public override void OnInit(System.EventArgs e) { }
    public override void OnPreRender(System.EventArgs e) { }
    public override void Render(System.Web.UI.MobileControls.Adapters.WmlMobileTextWriter writer) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class WmlTextBoxAdapter : System.Web.UI.MobileControls.Adapters.WmlControlAdapter {
    public WmlTextBoxAdapter() { }
    protected new System.Web.UI.MobileControls.TextBox Control { get { return default(System.Web.UI.MobileControls.TextBox); } }
    protected override string GetPostBackValue() { return default(string); }
    public override void OnInit(System.EventArgs e) { }
    public override void Render(System.Web.UI.MobileControls.Adapters.WmlMobileTextWriter writer) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class WmlTextViewAdapter : System.Web.UI.MobileControls.Adapters.WmlControlAdapter {
    public WmlTextViewAdapter() { }
    protected new System.Web.UI.MobileControls.TextView Control { get { return default(System.Web.UI.MobileControls.TextView); } }
    public override void Render(System.Web.UI.MobileControls.Adapters.WmlMobileTextWriter writer) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class WmlValidationSummaryAdapter : System.Web.UI.MobileControls.Adapters.WmlControlAdapter {
    public WmlValidationSummaryAdapter() { }
    protected new System.Web.UI.MobileControls.ValidationSummary Control { get { return default(System.Web.UI.MobileControls.ValidationSummary); } }
    public override void OnInit(System.EventArgs e) { }
    public override void Render(System.Web.UI.MobileControls.Adapters.WmlMobileTextWriter writer) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class WmlValidatorAdapter : System.Web.UI.MobileControls.Adapters.WmlControlAdapter {
    public WmlValidatorAdapter() { }
    protected new System.Web.UI.MobileControls.BaseValidator Control { get { return default(System.Web.UI.MobileControls.BaseValidator); } }
    public override void Render(System.Web.UI.MobileControls.Adapters.WmlMobileTextWriter writer) { }
  }
}
namespace System.Web.UI.MobileControls.Adapters.XhtmlAdapters {
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  public enum Doctype {
    NotSet = 0,
    Wml20 = 3,
    XhtmlBasic = 1,
    XhtmlMobileProfile = 2,
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  public enum StyleSheetLocation {
    ApplicationCache = 1,
    Internal = 4,
    None = 5,
    NotSet = 0,
    PhysicalFile = 3,
    SessionState = 2,
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class XhtmlCalendarAdapter : System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlControlAdapter {
    public XhtmlCalendarAdapter() { }
    protected new System.Web.UI.MobileControls.Calendar Control { get { return default(System.Web.UI.MobileControls.Calendar); } }
    public override bool HandlePostBackEvent(string eventArgument) { return default(bool); }
    public override void LoadAdapterState(object state) { }
    public override void OnInit(System.EventArgs e) { }
    public override void OnLoad(System.EventArgs e) { }
    public override void OnPreRender(System.EventArgs e) { }
    public override void Render(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer) { }
    public override object SaveAdapterState() { return default(object); }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class XhtmlCommandAdapter : System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlControlAdapter {
    public XhtmlCommandAdapter() { }
    protected new System.Web.UI.MobileControls.Command Control { get { return default(System.Web.UI.MobileControls.Command); } }
    public override bool LoadPostData(string key, System.Collections.Specialized.NameValueCollection data, object controlPrivateData, out bool dataChanged) { dataChanged = default(bool); return default(bool); }
    public override void Render(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class XhtmlControlAdapter : System.Web.UI.MobileControls.Adapters.ControlAdapter {
    protected static readonly int NotSecondaryUI;
    public XhtmlControlAdapter() { }
    protected virtual System.Web.UI.MobileControls.Adapters.XhtmlAdapters.StyleSheetLocation CssLocation { get { return default(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.StyleSheetLocation); } }
    protected virtual System.Web.UI.MobileControls.Adapters.XhtmlAdapters.Doctype DocumentType { get { return default(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.Doctype); } }
    protected System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlPageAdapter PageAdapter { get { return default(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlPageAdapter); } }
    protected virtual int SecondaryUIMode { get { return default(int); } set { } }
    protected virtual string StyleSheetLocationAttributeValue { get { return default(string); } }
    protected virtual string StyleSheetStorageApplicationSetting { get { return default(string); } }
    protected virtual void ClearPendingBreakIfDeviceBreaksOnBlockLevel(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer) { }
    protected virtual void ConditionalClearCachedEndTag(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer, string s) { }
    protected virtual void ConditionalClearPendingBreak(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer) { }
    protected virtual void ConditionalEnterFormat(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer, System.Web.UI.MobileControls.Style style) { }
    protected virtual void ConditionalEnterLayout(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer, System.Web.UI.MobileControls.Style style) { }
    protected virtual void ConditionalEnterStyle(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer, System.Web.UI.MobileControls.Style style) { }
    protected virtual void ConditionalEnterStyle(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer, System.Web.UI.MobileControls.Style style, string tag) { }
    protected virtual void ConditionalExitFormat(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer, System.Web.UI.MobileControls.Style style) { }
    protected virtual void ConditionalExitLayout(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer, System.Web.UI.MobileControls.Style style) { }
    protected virtual void ConditionalExitStyle(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer, System.Web.UI.MobileControls.Style style) { }
    protected virtual void ConditionalPopPhysicalCssClass(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer) { }
    protected virtual void ConditionalRenderClassAttribute(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer) { }
    protected virtual void ConditionalRenderClosingDivElement(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer) { }
    protected virtual void ConditionalRenderClosingSpanElement(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer) { }
    protected virtual void ConditionalRenderCustomAttribute(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer, string attributeName) { }
    protected virtual void ConditionalRenderCustomAttribute(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer, string attributeName, string markupAttributeName) { }
    protected virtual void ConditionalRenderOpeningDivElement(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer) { }
    protected virtual void ConditionalRenderOpeningSpanElement(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer) { }
    protected virtual void ConditionalSetPendingBreak(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer) { }
    protected virtual void ConditionalSetPendingBreakAfterInline(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer) { }
    protected virtual void ExitSecondaryUIMode() { }
    protected virtual string GetCustomAttributeValue(string attributeName) { return default(string); }
    protected virtual string GetCustomAttributeValue(System.Web.UI.MobileControls.MobileControl control, string attributeName) { return default(string); }
    public override void LoadAdapterState(object state) { }
    protected string PreprocessQueryString(string queryString) { return default(string); }
    public override void Render(System.Web.UI.HtmlTextWriter writer) { }
    public virtual void Render(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer) { }
    protected virtual void RenderAsHiddenInputField(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer) { }
    protected virtual void RenderBeginLink(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer, string target) { }
    protected virtual void RenderBeginLink(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer, string target, string accessKey, System.Web.UI.MobileControls.Style style, string cssClass) { }
    protected virtual void RenderBeginLink(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer, string target, string accessKey, System.Web.UI.MobileControls.Style style, string cssClass, string title) { }
    protected virtual void RenderClosingListTag(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer, string tagName) { }
    protected virtual void RenderEndLink(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer) { }
    protected void RenderOffPageVariables(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer, System.Web.UI.Control control, int page) { }
    protected virtual void RenderOpeningListTag(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer, string tagName) { }
    protected virtual void RenderPostBackEventAsAnchor(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer, string argument, string linkText) { }
    protected virtual void RenderPostBackEventAsAnchor(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer, string argument, string linkText, string accessKey) { }
    protected virtual void RenderPostBackEventAsAnchor(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer, string argument, string linkText, string accessKey, System.Web.UI.MobileControls.Style style, string cssClass) { }
    public override object SaveAdapterState() { return default(object); }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class XhtmlCssHandler : System.Web.IHttpHandler, System.Web.SessionState.IRequiresSessionState {
    public XhtmlCssHandler() { }
    public bool IsReusable { get { return default(bool); } }
    public void ProcessRequest(System.Web.HttpContext context) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class XhtmlFormAdapter : System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlControlAdapter {
    public XhtmlFormAdapter() { }
    public new System.Web.UI.MobileControls.Form Control { get { return default(System.Web.UI.MobileControls.Form); } }
    public override void Render(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer) { }
    protected virtual void RenderPager(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer) { }
    protected virtual void RenderPagerTag(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer, int pageToNavigate, string text, string accessKeyCustomAttribute) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class XhtmlImageAdapter : System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlControlAdapter {
    public XhtmlImageAdapter() { }
    protected new System.Web.UI.MobileControls.Image Control { get { return default(System.Web.UI.MobileControls.Image); } }
    public override void Render(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer) { }
    protected virtual void RenderImage(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class XhtmlLabelAdapter : System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlControlAdapter {
    public XhtmlLabelAdapter() { }
    public new System.Web.UI.MobileControls.Label Control { get { return default(System.Web.UI.MobileControls.Label); } }
    public override void Render(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class XhtmlLinkAdapter : System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlControlAdapter {
    public XhtmlLinkAdapter() { }
    protected new System.Web.UI.MobileControls.Link Control { get { return default(System.Web.UI.MobileControls.Link); } }
    public override void Render(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class XhtmlListAdapter : System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlControlAdapter {
    public XhtmlListAdapter() { }
    protected new System.Web.UI.MobileControls.List Control { get { return default(System.Web.UI.MobileControls.List); } }
    public override void Render(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer) { }
    protected virtual void RenderList(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class XhtmlLiteralTextAdapter : System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlControlAdapter {
    public XhtmlLiteralTextAdapter() { }
    protected new System.Web.UI.MobileControls.LiteralText Control { get { return default(System.Web.UI.MobileControls.LiteralText); } }
    public override void Render(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class XhtmlMobileTextWriter : System.Web.UI.MobileControls.Adapters.MobileTextWriter {
    public XhtmlMobileTextWriter(System.IO.TextWriter writer, System.Web.Mobile.MobileCapabilities device) : base (default(System.IO.TextWriter), default(System.Web.Mobile.MobileCapabilities)) { }
    public virtual string CacheKey { get { return default(string); } }
    public string CustomBodyStyles { get { return default(string); } set { } }
    public virtual string SessionKey { get { return default(string); } }
    public virtual bool SupportsNoWrapStyle { get { return default(bool); } set { } }
    public bool SuppressNewLine { get { return default(bool); } set { } }
    public bool UseDivsForBreaks { get { return default(bool); } set { } }
    public virtual void AddOnEnterForwardSetVar(string var) { }
    public virtual void AddOnEnterForwardSetVar(string var, string value) { }
    public virtual void BeginCachedRendering() { }
    public virtual void ClearPendingBreak() { }
    public virtual void EndCachedRendering() { }
    public override void EnterFormat(System.Web.UI.MobileControls.Style style) { }
    public override void EnterLayout(System.Web.UI.MobileControls.Style style) { }
    public new void EnterStyle(System.Web.UI.MobileControls.Style style) { }
    public override void ExitFormat(System.Web.UI.MobileControls.Style style) { }
    public override void ExitFormat(System.Web.UI.MobileControls.Style style, bool breakafter) { }
    public override void ExitLayout(System.Web.UI.MobileControls.Style style) { }
    public override void ExitLayout(System.Web.UI.MobileControls.Style style, bool breakafter) { }
    public new void ExitStyle(System.Web.UI.MobileControls.Style style) { }
    public virtual bool IsStyleSheetEmpty() { return default(bool); }
    public virtual void MarkWmlOnEventLocation() { }
    public virtual void SetBodyStyle(System.Web.UI.MobileControls.Style style) { }
    public virtual void SetCacheKey(System.Web.Caching.Cache cache) { }
    public virtual void SetPendingBreak() { }
    public virtual void SetSessionKey(System.Web.SessionState.HttpSessionState session) { }
    public override void WriteAttribute(string attribute, string value, bool encode) { }
    public override void WriteBeginTag(string tag) { }
    public virtual new void WriteBreak() { }
    public virtual void WriteCachedMarkup() { }
    public virtual void WriteDoctypeDeclaration(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.Doctype type) { }
    public virtual void WriteEncodedAttributeValue(string value) { }
    public override void WriteEndTag(string tag) { }
    public override void WriteFullBeginTag(string tag) { }
    public virtual void WriteHiddenField(string name) { }
    public virtual void WriteHiddenField(string name, string value) { }
    public override void WriteLine() { }
    public override void WriteLine(bool v) { }
    public override void WriteLine(char v) { }
    public override void WriteLine(System.Char[] v) { }
    public override void WriteLine(System.Char[] buffer, int index, int count) { }
    public override void WriteLine(double v) { }
    public override void WriteLine(int v) { }
    public override void WriteLine(long v) { }
    public override void WriteLine(object v) { }
    public override void WriteLine(float v) { }
    public override void WriteLine(string s) { }
    public override void WriteLine(string format, object arg) { }
    public override void WriteLine(string format, object arg0, object arg1) { }
    public override void WriteLine(string format, params System.Object[] arg) { }
    public virtual void WritePendingBreak() { }
    public virtual void WriteUrlParameter(string name, string value) { }
    public virtual void WriteXmlDeclaration() { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class XhtmlObjectListAdapter : System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlControlAdapter {
    protected internal static readonly string BackToList;
    protected internal static readonly string ShowMore;
    protected internal static readonly string ShowMoreFormat;
    public XhtmlObjectListAdapter() { }
    protected new System.Web.UI.MobileControls.ObjectList Control { get { return default(System.Web.UI.MobileControls.ObjectList); } }
    public override void CreateTemplatedUI(bool doDataBind) { }
    public override bool HandlePostBackEvent(string eventArgument) { return default(bool); }
    protected bool HasCommands() { return default(bool); }
    protected bool HasDefaultCommand() { return default(bool); }
    protected virtual bool HasItemDetails() { return default(bool); }
    protected bool OnlyHasDefaultCommand() { return default(bool); }
    public override void OnPreRender(System.EventArgs e) { }
    public override void Render(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer) { }
    protected virtual void RenderItemDetails(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer, System.Web.UI.MobileControls.ObjectListItem item) { }
    protected virtual void RenderItemsList(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class XhtmlPageAdapter : System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlControlAdapter, System.Web.UI.MobileControls.IControlAdapter, System.Web.UI.MobileControls.IPageAdapter {
    public XhtmlPageAdapter() { }
    public virtual System.Collections.IList CacheVaryByHeaders { get { return default(System.Collections.IList); } }
    public System.Collections.IDictionary CookielessDataDictionary { get { return default(System.Collections.IDictionary); } set { } }
    public virtual string EventArgumentKey { get { return default(string); } }
    public virtual string EventSourceKey { get { return default(string); } }
    public virtual int OptimumPageWeight { get { return default(int); } }
    public override System.Web.UI.MobileControls.MobilePage Page { get { return default(System.Web.UI.MobileControls.MobilePage); } set { } }
    public bool PersistCookielessData { get { return default(bool); } set { } }
    public virtual System.Web.UI.HtmlTextWriter CreateTextWriter(System.IO.TextWriter writer) { return default(System.Web.UI.HtmlTextWriter); }
    public virtual System.Collections.Specialized.NameValueCollection DeterminePostBackMode(System.Web.HttpRequest request, string postEventSourceID, string postEventArgumentID, System.Collections.Specialized.NameValueCollection baseCollection) { return default(System.Collections.Specialized.NameValueCollection); }
    public static bool DeviceQualifies(System.Web.HttpContext context) { return default(bool); }
    public virtual bool HandleError(System.Exception e, System.Web.UI.HtmlTextWriter writer) { return default(bool); }
    public virtual bool HandlePagePostBackEvent(string eventSource, string eventArgument) { return default(bool); }
    protected virtual void InitWriterState(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer) { }
    public override void OnPreRender(System.EventArgs e) { }
    public override void Render(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer) { }
    public virtual void RenderUrlPostBackEvent(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer, string target, string argument) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class XhtmlPanelAdapter : System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlControlAdapter {
    public XhtmlPanelAdapter() { }
    protected new System.Web.UI.MobileControls.Panel Control { get { return default(System.Web.UI.MobileControls.Panel); } }
    public override void Render(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class XhtmlPhoneCallAdapter : System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlControlAdapter {
    public XhtmlPhoneCallAdapter() { }
    protected new System.Web.UI.MobileControls.PhoneCall Control { get { return default(System.Web.UI.MobileControls.PhoneCall); } }
    public override void Render(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class XhtmlSelectionListAdapter : System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlControlAdapter {
    public XhtmlSelectionListAdapter() { }
    protected new System.Web.UI.MobileControls.SelectionList Control { get { return default(System.Web.UI.MobileControls.SelectionList); } }
    public override bool LoadPostData(string key, System.Collections.Specialized.NameValueCollection data, object controlPrivateData, out bool dataChanged) { dataChanged = default(bool); return default(bool); }
    public override void Render(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer) { }
    protected override void RenderAsHiddenInputField(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class XhtmlTextBoxAdapter : System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlControlAdapter {
    public XhtmlTextBoxAdapter() { }
    public new System.Web.UI.MobileControls.TextBox Control { get { return default(System.Web.UI.MobileControls.TextBox); } }
    public override void OnInit(System.EventArgs e) { }
    public override void Render(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer) { }
    protected override void RenderAsHiddenInputField(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class XhtmlTextViewAdapter : System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlControlAdapter {
    public XhtmlTextViewAdapter() { }
    protected new System.Web.UI.MobileControls.TextView Control { get { return default(System.Web.UI.MobileControls.TextView); } }
    public override void Render(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer) { }
    public void RenderElement(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer, int index, int beginSubstring, int endSubstring) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class XhtmlValidationSummaryAdapter : System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlControlAdapter {
    public XhtmlValidationSummaryAdapter() { }
    protected new System.Web.UI.MobileControls.ValidationSummary Control { get { return default(System.Web.UI.MobileControls.ValidationSummary); } }
    public override void OnInit(System.EventArgs e) { }
    public override void Render(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer) { }
  }
  [System.ObsoleteAttribute("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
  public partial class XhtmlValidatorAdapter : System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlControlAdapter {
    public XhtmlValidatorAdapter() { }
    protected new System.Web.UI.MobileControls.BaseValidator Control { get { return default(System.Web.UI.MobileControls.BaseValidator); } }
    public override void Render(System.Web.UI.MobileControls.Adapters.XhtmlAdapters.XhtmlMobileTextWriter writer) { }
  }
}
