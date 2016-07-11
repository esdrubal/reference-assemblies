namespace WebMatrix.Data {
  public partial class ConnectionEventArgs : System.EventArgs {
    public ConnectionEventArgs(System.Data.Common.DbConnection connection) { }
    public System.Data.Common.DbConnection Connection { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Data.Common.DbConnection); } }
  }
  public partial class Database : System.IDisposable {
    internal Database() { }
    public System.Data.Common.DbConnection Connection { get { return default(System.Data.Common.DbConnection); } }
    public static event System.EventHandler<WebMatrix.Data.ConnectionEventArgs> ConnectionOpened { add { } remove { } }
    public void Close() { }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public int Execute(string commandText, params System.Object[] args) { return default(int); }
    public object GetLastInsertId() { return default(object); }
    public static WebMatrix.Data.Database Open(string name) { return default(WebMatrix.Data.Database); }
    public static WebMatrix.Data.Database OpenConnectionString(string connectionString) { return default(WebMatrix.Data.Database); }
    public static WebMatrix.Data.Database OpenConnectionString(string connectionString, string providerName) { return default(WebMatrix.Data.Database); }
    public dynamic Query(string commandText, params System.Object[] args) { return default(System.Collections.Generic.IEnumerable<System.Object>); }
    public dynamic QuerySingle(string commandText, params System.Object[] args) { return default(object); }
    public object QueryValue(string commandText, params System.Object[] args) { return default(object); }
  }
  public sealed partial class DynamicRecord : System.Dynamic.DynamicObject, System.ComponentModel.ICustomTypeDescriptor {
    internal DynamicRecord() { }
    public System.Collections.Generic.IList<System.String> Columns { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IList<System.String>); } }
    public object this[int index] { get { return default(object); } }
    public object this[string name] { get { return default(object); } }
    public override System.Collections.Generic.IEnumerable<System.String> GetDynamicMemberNames() { return default(System.Collections.Generic.IEnumerable<System.String>); }
    System.ComponentModel.AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { return default(System.ComponentModel.AttributeCollection); }
    string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { return default(string); }
    string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { return default(string); }
    System.ComponentModel.TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { return default(System.ComponentModel.TypeConverter); }
    System.ComponentModel.EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { return default(System.ComponentModel.EventDescriptor); }
    System.ComponentModel.PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { return default(System.ComponentModel.PropertyDescriptor); }
    object System.ComponentModel.ICustomTypeDescriptor.GetEditor(System.Type editorBaseType) { return default(object); }
    System.ComponentModel.EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { return default(System.ComponentModel.EventDescriptorCollection); }
    System.ComponentModel.EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(System.Attribute[] attributes) { return default(System.ComponentModel.EventDescriptorCollection); }
    System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { return default(System.ComponentModel.PropertyDescriptorCollection); }
    System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(System.Attribute[] attributes) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd) { return default(object); }
    public override bool TryGetMember(System.Dynamic.GetMemberBinder binder, out object result) { result = default(object); return default(bool); }
  }
}
