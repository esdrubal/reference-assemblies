namespace System.Reflection.Context {
  public abstract partial class CustomReflectionContext : System.Reflection.ReflectionContext {
    protected CustomReflectionContext() { }
    protected CustomReflectionContext(System.Reflection.ReflectionContext source) { }
    [System.Runtime.CompilerServices.IteratorStateMachineAttribute(typeof(System.Reflection.Context.CustomReflectionContext.<AddProperties>d__8))]
    protected virtual System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo> AddProperties(System.Type type) { return default(System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo>); }
    protected System.Reflection.PropertyInfo CreateProperty(System.Type propertyType, string name, System.Func<System.Object, System.Object> getter, System.Action<System.Object, System.Object> setter) { return default(System.Reflection.PropertyInfo); }
    protected System.Reflection.PropertyInfo CreateProperty(System.Type propertyType, string name, System.Func<System.Object, System.Object> getter, System.Action<System.Object, System.Object> setter, System.Collections.Generic.IEnumerable<System.Attribute> propertyCustomAttributes, System.Collections.Generic.IEnumerable<System.Attribute> getterCustomAttributes, System.Collections.Generic.IEnumerable<System.Attribute> setterCustomAttributes) { return default(System.Reflection.PropertyInfo); }
    protected virtual System.Collections.Generic.IEnumerable<System.Object> GetCustomAttributes(System.Reflection.MemberInfo member, System.Collections.Generic.IEnumerable<System.Object> declaredAttributes) { return default(System.Collections.Generic.IEnumerable<System.Object>); }
    protected virtual System.Collections.Generic.IEnumerable<System.Object> GetCustomAttributes(System.Reflection.ParameterInfo parameter, System.Collections.Generic.IEnumerable<System.Object> declaredAttributes) { return default(System.Collections.Generic.IEnumerable<System.Object>); }
    public override System.Reflection.Assembly MapAssembly(System.Reflection.Assembly assembly) { return default(System.Reflection.Assembly); }
    public override System.Reflection.TypeInfo MapType(System.Reflection.TypeInfo type) { return default(System.Reflection.TypeInfo); }
  }
}
