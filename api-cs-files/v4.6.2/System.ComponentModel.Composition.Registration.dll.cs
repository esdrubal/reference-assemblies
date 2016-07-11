namespace System.ComponentModel.Composition.Registration {
  public sealed partial class ExportBuilder {
    public ExportBuilder() { }
    public System.ComponentModel.Composition.Registration.ExportBuilder AddMetadata(string name, System.Func<System.Type, System.Object> itemFunc) { return default(System.ComponentModel.Composition.Registration.ExportBuilder); }
    public System.ComponentModel.Composition.Registration.ExportBuilder AddMetadata(string name, object value) { return default(System.ComponentModel.Composition.Registration.ExportBuilder); }
    public System.ComponentModel.Composition.Registration.ExportBuilder AsContractName(string contractName) { return default(System.ComponentModel.Composition.Registration.ExportBuilder); }
    public System.ComponentModel.Composition.Registration.ExportBuilder AsContractType(System.Type type) { return default(System.ComponentModel.Composition.Registration.ExportBuilder); }
    public System.ComponentModel.Composition.Registration.ExportBuilder AsContractType<T>() { return default(System.ComponentModel.Composition.Registration.ExportBuilder); }
    public System.ComponentModel.Composition.Registration.ExportBuilder Inherited() { return default(System.ComponentModel.Composition.Registration.ExportBuilder); }
  }
  public sealed partial class ImportBuilder {
    public ImportBuilder() { }
    public System.ComponentModel.Composition.Registration.ImportBuilder AllowDefault() { return default(System.ComponentModel.Composition.Registration.ImportBuilder); }
    public System.ComponentModel.Composition.Registration.ImportBuilder AllowRecomposition() { return default(System.ComponentModel.Composition.Registration.ImportBuilder); }
    public System.ComponentModel.Composition.Registration.ImportBuilder AsContractName(string contractName) { return default(System.ComponentModel.Composition.Registration.ImportBuilder); }
    public System.ComponentModel.Composition.Registration.ImportBuilder AsContractType(System.Type type) { return default(System.ComponentModel.Composition.Registration.ImportBuilder); }
    public System.ComponentModel.Composition.Registration.ImportBuilder AsContractType<T>() { return default(System.ComponentModel.Composition.Registration.ImportBuilder); }
    public System.ComponentModel.Composition.Registration.ImportBuilder AsMany(bool isMany=true) { return default(System.ComponentModel.Composition.Registration.ImportBuilder); }
    public System.ComponentModel.Composition.Registration.ImportBuilder RequiredCreationPolicy(System.ComponentModel.Composition.CreationPolicy requiredCreationPolicy) { return default(System.ComponentModel.Composition.Registration.ImportBuilder); }
    public System.ComponentModel.Composition.Registration.ImportBuilder Source(System.ComponentModel.Composition.ImportSource source) { return default(System.ComponentModel.Composition.Registration.ImportBuilder); }
  }
  public partial class ParameterImportBuilder {
    public ParameterImportBuilder() { }
    public T Import<T>() { return default(T); }
    public T Import<T>(System.Action<System.ComponentModel.Composition.Registration.ImportBuilder> configure) { return default(T); }
  }
  public partial class PartBuilder {
    internal PartBuilder() { }
    public System.ComponentModel.Composition.Registration.PartBuilder AddMetadata(string name, System.Func<System.Type, System.Object> itemFunc) { return default(System.ComponentModel.Composition.Registration.PartBuilder); }
    public System.ComponentModel.Composition.Registration.PartBuilder AddMetadata(string name, object value) { return default(System.ComponentModel.Composition.Registration.PartBuilder); }
    public System.ComponentModel.Composition.Registration.PartBuilder Export() { return default(System.ComponentModel.Composition.Registration.PartBuilder); }
    public System.ComponentModel.Composition.Registration.PartBuilder Export(System.Action<System.ComponentModel.Composition.Registration.ExportBuilder> exportConfiguration) { return default(System.ComponentModel.Composition.Registration.PartBuilder); }
    public System.ComponentModel.Composition.Registration.PartBuilder Export<T>() { return default(System.ComponentModel.Composition.Registration.PartBuilder); }
    public System.ComponentModel.Composition.Registration.PartBuilder Export<T>(System.Action<System.ComponentModel.Composition.Registration.ExportBuilder> exportConfiguration) { return default(System.ComponentModel.Composition.Registration.PartBuilder); }
    public System.ComponentModel.Composition.Registration.PartBuilder ExportInterfaces() { return default(System.ComponentModel.Composition.Registration.PartBuilder); }
    public System.ComponentModel.Composition.Registration.PartBuilder ExportInterfaces(System.Predicate<System.Type> interfaceFilter) { return default(System.ComponentModel.Composition.Registration.PartBuilder); }
    public System.ComponentModel.Composition.Registration.PartBuilder ExportInterfaces(System.Predicate<System.Type> interfaceFilter, System.Action<System.Type, System.ComponentModel.Composition.Registration.ExportBuilder> exportConfiguration) { return default(System.ComponentModel.Composition.Registration.PartBuilder); }
    public System.ComponentModel.Composition.Registration.PartBuilder ExportProperties(System.Predicate<System.Reflection.PropertyInfo> propertyFilter) { return default(System.ComponentModel.Composition.Registration.PartBuilder); }
    public System.ComponentModel.Composition.Registration.PartBuilder ExportProperties(System.Predicate<System.Reflection.PropertyInfo> propertyFilter, System.Action<System.Reflection.PropertyInfo, System.ComponentModel.Composition.Registration.ExportBuilder> exportConfiguration) { return default(System.ComponentModel.Composition.Registration.PartBuilder); }
    public System.ComponentModel.Composition.Registration.PartBuilder ExportProperties<T>(System.Predicate<System.Reflection.PropertyInfo> propertyFilter) { return default(System.ComponentModel.Composition.Registration.PartBuilder); }
    public System.ComponentModel.Composition.Registration.PartBuilder ExportProperties<T>(System.Predicate<System.Reflection.PropertyInfo> propertyFilter, System.Action<System.Reflection.PropertyInfo, System.ComponentModel.Composition.Registration.ExportBuilder> exportConfiguration) { return default(System.ComponentModel.Composition.Registration.PartBuilder); }
    public System.ComponentModel.Composition.Registration.PartBuilder ImportProperties(System.Predicate<System.Reflection.PropertyInfo> propertyFilter) { return default(System.ComponentModel.Composition.Registration.PartBuilder); }
    public System.ComponentModel.Composition.Registration.PartBuilder ImportProperties(System.Predicate<System.Reflection.PropertyInfo> propertyFilter, System.Action<System.Reflection.PropertyInfo, System.ComponentModel.Composition.Registration.ImportBuilder> importConfiguration) { return default(System.ComponentModel.Composition.Registration.PartBuilder); }
    public System.ComponentModel.Composition.Registration.PartBuilder ImportProperties<T>(System.Predicate<System.Reflection.PropertyInfo> propertyFilter) { return default(System.ComponentModel.Composition.Registration.PartBuilder); }
    public System.ComponentModel.Composition.Registration.PartBuilder ImportProperties<T>(System.Predicate<System.Reflection.PropertyInfo> propertyFilter, System.Action<System.Reflection.PropertyInfo, System.ComponentModel.Composition.Registration.ImportBuilder> importConfiguration) { return default(System.ComponentModel.Composition.Registration.PartBuilder); }
    public System.ComponentModel.Composition.Registration.PartBuilder SelectConstructor(System.Func<System.Reflection.ConstructorInfo[], System.Reflection.ConstructorInfo> constructorFilter) { return default(System.ComponentModel.Composition.Registration.PartBuilder); }
    public System.ComponentModel.Composition.Registration.PartBuilder SelectConstructor(System.Func<System.Reflection.ConstructorInfo[], System.Reflection.ConstructorInfo> constructorFilter, System.Action<System.Reflection.ParameterInfo, System.ComponentModel.Composition.Registration.ImportBuilder> importConfiguration) { return default(System.ComponentModel.Composition.Registration.PartBuilder); }
    public System.ComponentModel.Composition.Registration.PartBuilder SetCreationPolicy(System.ComponentModel.Composition.CreationPolicy creationPolicy) { return default(System.ComponentModel.Composition.Registration.PartBuilder); }
  }
  public partial class PartBuilder<T> : System.ComponentModel.Composition.Registration.PartBuilder {
    internal PartBuilder() { }
    public System.ComponentModel.Composition.Registration.PartBuilder<T> ExportProperty(System.Linq.Expressions.Expression<System.Func<T, System.Object>> propertyFilter) { return default(System.ComponentModel.Composition.Registration.PartBuilder<T>); }
    public System.ComponentModel.Composition.Registration.PartBuilder<T> ExportProperty(System.Linq.Expressions.Expression<System.Func<T, System.Object>> propertyFilter, System.Action<System.ComponentModel.Composition.Registration.ExportBuilder> exportConfiguration) { return default(System.ComponentModel.Composition.Registration.PartBuilder<T>); }
    public System.ComponentModel.Composition.Registration.PartBuilder<T> ExportProperty<TContract>(System.Linq.Expressions.Expression<System.Func<T, System.Object>> propertyFilter) { return default(System.ComponentModel.Composition.Registration.PartBuilder<T>); }
    public System.ComponentModel.Composition.Registration.PartBuilder<T> ExportProperty<TContract>(System.Linq.Expressions.Expression<System.Func<T, System.Object>> propertyFilter, System.Action<System.ComponentModel.Composition.Registration.ExportBuilder> exportConfiguration) { return default(System.ComponentModel.Composition.Registration.PartBuilder<T>); }
    public System.ComponentModel.Composition.Registration.PartBuilder<T> ImportProperty(System.Linq.Expressions.Expression<System.Func<T, System.Object>> propertyFilter) { return default(System.ComponentModel.Composition.Registration.PartBuilder<T>); }
    public System.ComponentModel.Composition.Registration.PartBuilder<T> ImportProperty(System.Linq.Expressions.Expression<System.Func<T, System.Object>> propertyFilter, System.Action<System.ComponentModel.Composition.Registration.ImportBuilder> importConfiguration) { return default(System.ComponentModel.Composition.Registration.PartBuilder<T>); }
    public System.ComponentModel.Composition.Registration.PartBuilder<T> ImportProperty<TContract>(System.Linq.Expressions.Expression<System.Func<T, System.Object>> propertyFilter) { return default(System.ComponentModel.Composition.Registration.PartBuilder<T>); }
    public System.ComponentModel.Composition.Registration.PartBuilder<T> ImportProperty<TContract>(System.Linq.Expressions.Expression<System.Func<T, System.Object>> propertyFilter, System.Action<System.ComponentModel.Composition.Registration.ImportBuilder> importConfiguration) { return default(System.ComponentModel.Composition.Registration.PartBuilder<T>); }
    public System.ComponentModel.Composition.Registration.PartBuilder<T> SelectConstructor(System.Linq.Expressions.Expression<System.Func<System.ComponentModel.Composition.Registration.ParameterImportBuilder, T>> constructorFilter) { return default(System.ComponentModel.Composition.Registration.PartBuilder<T>); }
  }
  public partial class RegistrationBuilder : System.Reflection.Context.CustomReflectionContext {
    public RegistrationBuilder() { }
    public System.ComponentModel.Composition.Registration.PartBuilder ForType(System.Type type) { return default(System.ComponentModel.Composition.Registration.PartBuilder); }
    public System.ComponentModel.Composition.Registration.PartBuilder<T> ForType<T>() { return default(System.ComponentModel.Composition.Registration.PartBuilder<T>); }
    public System.ComponentModel.Composition.Registration.PartBuilder ForTypesDerivedFrom(System.Type type) { return default(System.ComponentModel.Composition.Registration.PartBuilder); }
    public System.ComponentModel.Composition.Registration.PartBuilder<T> ForTypesDerivedFrom<T>() { return default(System.ComponentModel.Composition.Registration.PartBuilder<T>); }
    public System.ComponentModel.Composition.Registration.PartBuilder ForTypesMatching(System.Predicate<System.Type> typeFilter) { return default(System.ComponentModel.Composition.Registration.PartBuilder); }
    public System.ComponentModel.Composition.Registration.PartBuilder<T> ForTypesMatching<T>(System.Predicate<System.Type> typeFilter) { return default(System.ComponentModel.Composition.Registration.PartBuilder<T>); }
    protected override System.Collections.Generic.IEnumerable<System.Object> GetCustomAttributes(System.Reflection.MemberInfo member, System.Collections.Generic.IEnumerable<System.Object> declaredAttributes) { return default(System.Collections.Generic.IEnumerable<System.Object>); }
    protected override System.Collections.Generic.IEnumerable<System.Object> GetCustomAttributes(System.Reflection.ParameterInfo parameter, System.Collections.Generic.IEnumerable<System.Object> declaredAttributes) { return default(System.Collections.Generic.IEnumerable<System.Object>); }
  }
}
