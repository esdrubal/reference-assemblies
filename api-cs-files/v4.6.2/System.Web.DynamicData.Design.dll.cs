namespace System.Web.DynamicData.Design {
  public partial class DataControlReferenceCollectionEditor : System.ComponentModel.Design.CollectionEditor {
    public DataControlReferenceCollectionEditor(System.Type type) : base (default(System.Type)) { }
    protected override System.Type CreateCollectionItemType() { return default(System.Type); }
  }
  public partial class DataControlReferenceIDConverter : System.ComponentModel.StringConverter {
    public DataControlReferenceIDConverter() { }
    public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { return default(System.ComponentModel.TypeConverter.StandardValuesCollection); }
    public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
  }
  public partial class DynamicDataManagerDesigner : System.Web.UI.Design.ControlDesigner {
    public DynamicDataManagerDesigner() { }
    public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { return default(System.ComponentModel.Design.DesignerActionListCollection); } }
    public override string GetDesignTimeHtml() { return default(string); }
  }
  public partial class DynamicFieldDesigner : System.Web.UI.Design.WebControls.DataControlFieldDesigner {
    public DynamicFieldDesigner() { }
    public override string DefaultNodeText { get { return default(string); } }
    public override bool UsesSchema { get { return default(bool); } }
    public override System.Web.UI.WebControls.DataControlField CreateField() { return default(System.Web.UI.WebControls.DataControlField); }
    public override System.Web.UI.WebControls.DataControlField CreateField(System.Web.UI.Design.IDataSourceFieldSchema fieldSchema) { return default(System.Web.UI.WebControls.DataControlField); }
    public override System.Web.UI.WebControls.TemplateField CreateTemplateField(System.Web.UI.WebControls.DataControlField dataControlField, System.Web.UI.WebControls.DataBoundControl dataBoundControl) { return default(System.Web.UI.WebControls.TemplateField); }
    public override string GetNodeText(System.Web.UI.WebControls.DataControlField dataControlField) { return default(string); }
    public string GetTemplateContent(System.Web.UI.WebControls.DataControlField dataControlField, System.Web.UI.WebControls.DataBoundControlMode mode) { return default(string); }
    public override bool IsEnabled(System.Web.UI.WebControls.DataBoundControl parent) { return default(bool); }
  }
}
