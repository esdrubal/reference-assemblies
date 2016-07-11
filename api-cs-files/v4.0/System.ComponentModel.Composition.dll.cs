namespace System {
  public partial class Lazy<T, TMetadata> : System.Lazy<T> {
    public Lazy(TMetadata metadata) { }
    public Lazy(TMetadata metadata, bool isThreadSafe) { }
    public Lazy(System.Func<T> valueFactory, TMetadata metadata) { }
    public Lazy(System.Func<T> valueFactory, TMetadata metadata, bool isThreadSafe) { }
    public TMetadata Metadata { get { return default(TMetadata); } }
  }
}
namespace System.ComponentModel.Composition {
  public static partial class AttributedModelServices {
    public static System.ComponentModel.Composition.Primitives.ComposablePart AddExportedValue<T>(this System.ComponentModel.Composition.Hosting.CompositionBatch batch, T exportedValue) { return default(System.ComponentModel.Composition.Primitives.ComposablePart); }
    public static System.ComponentModel.Composition.Primitives.ComposablePart AddExportedValue<T>(this System.ComponentModel.Composition.Hosting.CompositionBatch batch, string contractName, T exportedValue) { return default(System.ComponentModel.Composition.Primitives.ComposablePart); }
    public static System.ComponentModel.Composition.Primitives.ComposablePart AddPart(this System.ComponentModel.Composition.Hosting.CompositionBatch batch, object attributedPart) { return default(System.ComponentModel.Composition.Primitives.ComposablePart); }
    public static void ComposeExportedValue<T>(this System.ComponentModel.Composition.Hosting.CompositionContainer container, T exportedValue) { }
    public static void ComposeExportedValue<T>(this System.ComponentModel.Composition.Hosting.CompositionContainer container, string contractName, T exportedValue) { }
    public static void ComposeParts(this System.ComponentModel.Composition.Hosting.CompositionContainer container, params System.Object[] attributedParts) { }
    public static System.ComponentModel.Composition.Primitives.ComposablePart CreatePart(object attributedPart) { return default(System.ComponentModel.Composition.Primitives.ComposablePart); }
    public static System.ComponentModel.Composition.Primitives.ComposablePartDefinition CreatePartDefinition(System.Type type, System.ComponentModel.Composition.Primitives.ICompositionElement origin) { return default(System.ComponentModel.Composition.Primitives.ComposablePartDefinition); }
    public static System.ComponentModel.Composition.Primitives.ComposablePartDefinition CreatePartDefinition(System.Type type, System.ComponentModel.Composition.Primitives.ICompositionElement origin, bool ensureIsDiscoverable) { return default(System.ComponentModel.Composition.Primitives.ComposablePartDefinition); }
    public static string GetContractName(System.Type type) { return default(string); }
    public static TMetadataView GetMetadataView<TMetadataView>(System.Collections.Generic.IDictionary<System.String, System.Object> metadata) { return default(TMetadataView); }
    public static string GetTypeIdentity(System.Reflection.MethodInfo method) { return default(string); }
    public static string GetTypeIdentity(System.Type type) { return default(string); }
    public static System.ComponentModel.Composition.Primitives.ComposablePart SatisfyImportsOnce(this System.ComponentModel.Composition.ICompositionService compositionService, object attributedPart) { return default(System.ComponentModel.Composition.Primitives.ComposablePart); }
  }
  public partial class ChangeRejectedException : System.ComponentModel.Composition.CompositionException {
    public ChangeRejectedException() { }
    public ChangeRejectedException(System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.CompositionError> errors) { }
    public ChangeRejectedException(string message) { }
    public ChangeRejectedException(string message, System.Exception innerException) { }
    public override string Message { get { return default(string); } }
  }
  public partial class CompositionContractMismatchException : System.Exception {
    public CompositionContractMismatchException() { }
    [System.Security.SecuritySafeCriticalAttribute]
    protected CompositionContractMismatchException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public CompositionContractMismatchException(string message) { }
    public CompositionContractMismatchException(string message, System.Exception innerException) { }
  }
  [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(System.ComponentModel.Composition.CompositionErrorDebuggerProxy))]
  public partial class CompositionError {
    public CompositionError(string message) { }
    public CompositionError(string message, System.ComponentModel.Composition.Primitives.ICompositionElement element) { }
    public CompositionError(string message, System.ComponentModel.Composition.Primitives.ICompositionElement element, System.Exception exception) { }
    public CompositionError(string message, System.Exception exception) { }
    public string Description { get { return default(string); } }
    public System.ComponentModel.Composition.Primitives.ICompositionElement Element { get { return default(System.ComponentModel.Composition.Primitives.ICompositionElement); } }
    public System.Exception Exception { get { return default(System.Exception); } }
    public override string ToString() { return default(string); }
  }
  public partial class CompositionException : System.Exception {
    public CompositionException() { }
    public CompositionException(System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.CompositionError> errors) { }
    public CompositionException(string message) { }
    public CompositionException(string message, System.Exception innerException) { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.ComponentModel.Composition.CompositionError> Errors { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.ComponentModel.Composition.CompositionError>); } }
    public override string Message { [System.Security.SecuritySafeCriticalAttribute]get { return default(string); } }
  }
  public enum CreationPolicy {
    Any = 0,
    NonShared = 2,
    Shared = 1,
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(452), AllowMultiple=true, Inherited=false)]
  public partial class ExportAttribute : System.Attribute {
    public ExportAttribute() { }
    public ExportAttribute(string contractName) { }
    public ExportAttribute(string contractName, System.Type contractType) { }
    public ExportAttribute(System.Type contractType) { }
    public string ContractName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public System.Type ContractType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(1476), AllowMultiple=true, Inherited=false)]
  public sealed partial class ExportMetadataAttribute : System.Attribute {
    public ExportMetadataAttribute(string name, object value) { }
    public bool IsMultiple { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public object Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } }
  }
  public partial interface ICompositionService {
    void SatisfyImportsOnce(System.ComponentModel.Composition.Primitives.ComposablePart part);
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(2432), AllowMultiple=false, Inherited=false)]
  public partial class ImportAttribute : System.Attribute {
    public ImportAttribute() { }
    public ImportAttribute(string contractName) { }
    public ImportAttribute(string contractName, System.Type contractType) { }
    public ImportAttribute(System.Type contractType) { }
    public bool AllowDefault { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool AllowRecomposition { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string ContractName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public System.Type ContractType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } }
    public System.ComponentModel.Composition.CreationPolicy RequiredCreationPolicy { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ComponentModel.Composition.CreationPolicy); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial class ImportCardinalityMismatchException : System.Exception {
    public ImportCardinalityMismatchException() { }
    [System.Security.SecuritySafeCriticalAttribute]
    protected ImportCardinalityMismatchException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public ImportCardinalityMismatchException(string message) { }
    public ImportCardinalityMismatchException(string message, System.Exception innerException) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(32), AllowMultiple=false, Inherited=false)]
  public partial class ImportingConstructorAttribute : System.Attribute {
    public ImportingConstructorAttribute() { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(2432), AllowMultiple=false, Inherited=false)]
  public partial class ImportManyAttribute : System.Attribute {
    public ImportManyAttribute() { }
    public ImportManyAttribute(string contractName) { }
    public ImportManyAttribute(string contractName, System.Type contractType) { }
    public ImportManyAttribute(System.Type contractType) { }
    public bool AllowRecomposition { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string ContractName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public System.Type ContractType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } }
    public System.ComponentModel.Composition.CreationPolicy RequiredCreationPolicy { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ComponentModel.Composition.CreationPolicy); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(1028), AllowMultiple=true, Inherited=true)]
  public partial class InheritedExportAttribute : System.ComponentModel.Composition.ExportAttribute {
    public InheritedExportAttribute() { }
    public InheritedExportAttribute(string contractName) { }
    public InheritedExportAttribute(string contractName, System.Type contractType) { }
    public InheritedExportAttribute(System.Type contractType) { }
  }
  public partial interface IPartImportsSatisfiedNotification {
    void OnImportsSatisfied();
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false, Inherited=true)]
  public sealed partial class MetadataAttributeAttribute : System.Attribute {
    public MetadataAttributeAttribute() { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false, Inherited=false)]
  public sealed partial class PartCreationPolicyAttribute : System.Attribute {
    public PartCreationPolicyAttribute(System.ComponentModel.Composition.CreationPolicy creationPolicy) { }
    public System.ComponentModel.Composition.CreationPolicy CreationPolicy { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ComponentModel.Composition.CreationPolicy); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=true, Inherited=false)]
  public sealed partial class PartMetadataAttribute : System.Attribute {
    public PartMetadataAttribute(string name, object value) { }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public object Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false, Inherited=false)]
  public sealed partial class PartNotDiscoverableAttribute : System.Attribute {
    public PartNotDiscoverableAttribute() { }
  }
}
namespace System.ComponentModel.Composition.Hosting {
  public partial class AggregateCatalog : System.ComponentModel.Composition.Primitives.ComposablePartCatalog, System.ComponentModel.Composition.Hosting.INotifyComposablePartCatalogChanged {
    public AggregateCatalog() { }
    public AggregateCatalog(System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartCatalog> catalogs) { }
    public AggregateCatalog(params System.ComponentModel.Composition.Primitives.ComposablePartCatalog[] catalogs) { }
    public System.Collections.Generic.ICollection<System.ComponentModel.Composition.Primitives.ComposablePartCatalog> Catalogs { get { return default(System.Collections.Generic.ICollection<System.ComponentModel.Composition.Primitives.ComposablePartCatalog>); } }
    public override System.Linq.IQueryable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> Parts { get { return default(System.Linq.IQueryable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition>); } }
    public event System.EventHandler<System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs> Changed { add { } remove { } }
    public event System.EventHandler<System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs> Changing { add { } remove { } }
    protected override void Dispose(bool disposing) { }
    public override System.Collections.Generic.IEnumerable<System.Tuple<System.ComponentModel.Composition.Primitives.ComposablePartDefinition, System.ComponentModel.Composition.Primitives.ExportDefinition>> GetExports(System.ComponentModel.Composition.Primitives.ImportDefinition definition) { return default(System.Collections.Generic.IEnumerable<System.Tuple<System.ComponentModel.Composition.Primitives.ComposablePartDefinition, System.ComponentModel.Composition.Primitives.ExportDefinition>>); }
    protected virtual void OnChanged(System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs e) { }
    protected virtual void OnChanging(System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs e) { }
  }
  public partial class AggregateExportProvider : System.ComponentModel.Composition.Hosting.ExportProvider, System.IDisposable {
    public AggregateExportProvider(System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Hosting.ExportProvider> providers) { }
    public AggregateExportProvider(params System.ComponentModel.Composition.Hosting.ExportProvider[] providers) { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.ComponentModel.Composition.Hosting.ExportProvider> Providers { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.ComponentModel.Composition.Hosting.ExportProvider>); } }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    protected override System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.Export> GetExportsCore(System.ComponentModel.Composition.Primitives.ImportDefinition definition, System.ComponentModel.Composition.Hosting.AtomicComposition atomicComposition) { return default(System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.Export>); }
  }
  [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(System.ComponentModel.Composition.Hosting.AssemblyCatalogDebuggerProxy))]
  public partial class AssemblyCatalog : System.ComponentModel.Composition.Primitives.ComposablePartCatalog, System.ComponentModel.Composition.Primitives.ICompositionElement {
    public AssemblyCatalog(System.Reflection.Assembly assembly) { }
    public AssemblyCatalog(string codeBase) { }
    public System.Reflection.Assembly Assembly { get { return default(System.Reflection.Assembly); } }
    public override System.Linq.IQueryable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> Parts { get { return default(System.Linq.IQueryable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition>); } }
    string System.ComponentModel.Composition.Primitives.ICompositionElement.DisplayName { get { return default(string); } }
    System.ComponentModel.Composition.Primitives.ICompositionElement System.ComponentModel.Composition.Primitives.ICompositionElement.Origin { get { return default(System.ComponentModel.Composition.Primitives.ICompositionElement); } }
    protected override void Dispose(bool disposing) { }
    public override System.Collections.Generic.IEnumerable<System.Tuple<System.ComponentModel.Composition.Primitives.ComposablePartDefinition, System.ComponentModel.Composition.Primitives.ExportDefinition>> GetExports(System.ComponentModel.Composition.Primitives.ImportDefinition definition) { return default(System.Collections.Generic.IEnumerable<System.Tuple<System.ComponentModel.Composition.Primitives.ComposablePartDefinition, System.ComponentModel.Composition.Primitives.ExportDefinition>>); }
    public override string ToString() { return default(string); }
  }
  public partial class AtomicComposition : System.IDisposable {
    public AtomicComposition() { }
    public AtomicComposition(System.ComponentModel.Composition.Hosting.AtomicComposition outerAtomicComposition) { }
    public void AddCompleteAction(System.Action completeAction) { }
    public void AddRevertAction(System.Action revertAction) { }
    public void Complete() { }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public void SetValue(object key, object value) { }
    public bool TryGetValue<T>(object key, out T value) { value = default(T); return default(bool); }
    public bool TryGetValue<T>(object key, bool localAtomicCompositionOnly, out T value) { value = default(T); return default(bool); }
  }
  public partial class CatalogExportProvider : System.ComponentModel.Composition.Hosting.ExportProvider, System.IDisposable {
    public CatalogExportProvider(System.ComponentModel.Composition.Primitives.ComposablePartCatalog catalog) { }
    public CatalogExportProvider(System.ComponentModel.Composition.Primitives.ComposablePartCatalog catalog, bool isThreadSafe) { }
    public System.ComponentModel.Composition.Primitives.ComposablePartCatalog Catalog { get { return default(System.ComponentModel.Composition.Primitives.ComposablePartCatalog); } }
    public System.ComponentModel.Composition.Hosting.ExportProvider SourceProvider { get { return default(System.ComponentModel.Composition.Hosting.ExportProvider); } set { } }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    protected override System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.Export> GetExportsCore(System.ComponentModel.Composition.Primitives.ImportDefinition definition, System.ComponentModel.Composition.Hosting.AtomicComposition atomicComposition) { return default(System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.Export>); }
  }
  public partial class ComposablePartCatalogChangeEventArgs : System.EventArgs {
    public ComposablePartCatalogChangeEventArgs(System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> addedDefinitions, System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> removedDefinitions, System.ComponentModel.Composition.Hosting.AtomicComposition atomicComposition) { }
    public System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> AddedDefinitions { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition>); } }
    public System.ComponentModel.Composition.Hosting.AtomicComposition AtomicComposition { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ComponentModel.Composition.Hosting.AtomicComposition); } }
    public System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> RemovedDefinitions { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition>); } }
  }
  public partial class ComposablePartExportProvider : System.ComponentModel.Composition.Hosting.ExportProvider, System.IDisposable {
    public ComposablePartExportProvider() { }
    public ComposablePartExportProvider(bool isThreadSafe) { }
    public System.ComponentModel.Composition.Hosting.ExportProvider SourceProvider { get { return default(System.ComponentModel.Composition.Hosting.ExportProvider); } set { } }
    public void Compose(System.ComponentModel.Composition.Hosting.CompositionBatch batch) { }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    protected override System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.Export> GetExportsCore(System.ComponentModel.Composition.Primitives.ImportDefinition definition, System.ComponentModel.Composition.Hosting.AtomicComposition atomicComposition) { return default(System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.Export>); }
  }
  public partial class CompositionBatch {
    public CompositionBatch() { }
    public CompositionBatch(System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePart> partsToAdd, System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ComposablePart> partsToRemove) { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.ComponentModel.Composition.Primitives.ComposablePart> PartsToAdd { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.ComponentModel.Composition.Primitives.ComposablePart>); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.ComponentModel.Composition.Primitives.ComposablePart> PartsToRemove { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.ComponentModel.Composition.Primitives.ComposablePart>); } }
    public System.ComponentModel.Composition.Primitives.ComposablePart AddExport(System.ComponentModel.Composition.Primitives.Export export) { return default(System.ComponentModel.Composition.Primitives.ComposablePart); }
    public void AddPart(System.ComponentModel.Composition.Primitives.ComposablePart part) { }
    public void RemovePart(System.ComponentModel.Composition.Primitives.ComposablePart part) { }
  }
  public static partial class CompositionConstants {
    public const string ExportTypeIdentityMetadataName = "ExportTypeIdentity";
    public const string PartCreationPolicyMetadataName = "System.ComponentModel.Composition.CreationPolicy";
  }
  public partial class CompositionContainer : System.ComponentModel.Composition.Hosting.ExportProvider, System.ComponentModel.Composition.ICompositionService, System.IDisposable {
    public CompositionContainer() { }
    public CompositionContainer(params System.ComponentModel.Composition.Hosting.ExportProvider[] providers) { }
    public CompositionContainer(System.ComponentModel.Composition.Primitives.ComposablePartCatalog catalog, bool isThreadSafe, params System.ComponentModel.Composition.Hosting.ExportProvider[] providers) { }
    public CompositionContainer(System.ComponentModel.Composition.Primitives.ComposablePartCatalog catalog, params System.ComponentModel.Composition.Hosting.ExportProvider[] providers) { }
    public System.ComponentModel.Composition.Primitives.ComposablePartCatalog Catalog { get { return default(System.ComponentModel.Composition.Primitives.ComposablePartCatalog); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.ComponentModel.Composition.Hosting.ExportProvider> Providers { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.ComponentModel.Composition.Hosting.ExportProvider>); } }
    public void Compose(System.ComponentModel.Composition.Hosting.CompositionBatch batch) { }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    protected override System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.Export> GetExportsCore(System.ComponentModel.Composition.Primitives.ImportDefinition definition, System.ComponentModel.Composition.Hosting.AtomicComposition atomicComposition) { return default(System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.Export>); }
    public void ReleaseExport(System.ComponentModel.Composition.Primitives.Export export) { }
    public void ReleaseExport<T>(System.Lazy<T> export) { }
    public void ReleaseExports(System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.Export> exports) { }
    public void ReleaseExports<T>(System.Collections.Generic.IEnumerable<System.Lazy<T>> exports) { }
    public void ReleaseExports<T, TMetadataView>(System.Collections.Generic.IEnumerable<System.Lazy<T, TMetadataView>> exports) { }
    public void SatisfyImportsOnce(System.ComponentModel.Composition.Primitives.ComposablePart part) { }
  }
  [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(System.ComponentModel.Composition.Hosting.DirectoryCatalog.DirectoryCatalogDebuggerProxy))]
  public partial class DirectoryCatalog : System.ComponentModel.Composition.Primitives.ComposablePartCatalog, System.ComponentModel.Composition.Hosting.INotifyComposablePartCatalogChanged, System.ComponentModel.Composition.Primitives.ICompositionElement {
    public DirectoryCatalog(string path) { }
    public DirectoryCatalog(string path, string searchPattern) { }
    public string FullPath { get { return default(string); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.String> LoadedFiles { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.String>); } }
    public override System.Linq.IQueryable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> Parts { get { return default(System.Linq.IQueryable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition>); } }
    public string Path { get { return default(string); } }
    public string SearchPattern { get { return default(string); } }
    string System.ComponentModel.Composition.Primitives.ICompositionElement.DisplayName { get { return default(string); } }
    System.ComponentModel.Composition.Primitives.ICompositionElement System.ComponentModel.Composition.Primitives.ICompositionElement.Origin { get { return default(System.ComponentModel.Composition.Primitives.ICompositionElement); } }
    public event System.EventHandler<System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs> Changed { add { } remove { } }
    public event System.EventHandler<System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs> Changing { add { } remove { } }
    protected override void Dispose(bool disposing) { }
    public override System.Collections.Generic.IEnumerable<System.Tuple<System.ComponentModel.Composition.Primitives.ComposablePartDefinition, System.ComponentModel.Composition.Primitives.ExportDefinition>> GetExports(System.ComponentModel.Composition.Primitives.ImportDefinition definition) { return default(System.Collections.Generic.IEnumerable<System.Tuple<System.ComponentModel.Composition.Primitives.ComposablePartDefinition, System.ComponentModel.Composition.Primitives.ExportDefinition>>); }
    protected virtual void OnChanged(System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs e) { }
    protected virtual void OnChanging(System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs e) { }
    public void Refresh() { }
    public override string ToString() { return default(string); }
  }
  public abstract partial class ExportProvider {
    protected ExportProvider() { }
    public event System.EventHandler<System.ComponentModel.Composition.Hosting.ExportsChangeEventArgs> ExportsChanged { add { } remove { } }
    public event System.EventHandler<System.ComponentModel.Composition.Hosting.ExportsChangeEventArgs> ExportsChanging { add { } remove { } }
    public System.Lazy<T> GetExport<T>() { return default(System.Lazy<T>); }
    public System.Lazy<T> GetExport<T>(string contractName) { return default(System.Lazy<T>); }
    public System.Lazy<T, TMetadataView> GetExport<T, TMetadataView>() { return default(System.Lazy<T, TMetadataView>); }
    public System.Lazy<T, TMetadataView> GetExport<T, TMetadataView>(string contractName) { return default(System.Lazy<T, TMetadataView>); }
    public T GetExportedValue<T>() { return default(T); }
    public T GetExportedValue<T>(string contractName) { return default(T); }
    public T GetExportedValueOrDefault<T>() { return default(T); }
    public T GetExportedValueOrDefault<T>(string contractName) { return default(T); }
    public System.Collections.Generic.IEnumerable<T> GetExportedValues<T>() { return default(System.Collections.Generic.IEnumerable<T>); }
    public System.Collections.Generic.IEnumerable<T> GetExportedValues<T>(string contractName) { return default(System.Collections.Generic.IEnumerable<T>); }
    public System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.Export> GetExports(System.ComponentModel.Composition.Primitives.ImportDefinition definition) { return default(System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.Export>); }
    public System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.Export> GetExports(System.ComponentModel.Composition.Primitives.ImportDefinition definition, System.ComponentModel.Composition.Hosting.AtomicComposition atomicComposition) { return default(System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.Export>); }
    public System.Collections.Generic.IEnumerable<System.Lazy<System.Object, System.Object>> GetExports(System.Type type, System.Type metadataViewType, string contractName) { return default(System.Collections.Generic.IEnumerable<System.Lazy<System.Object, System.Object>>); }
    public System.Collections.Generic.IEnumerable<System.Lazy<T>> GetExports<T>() { return default(System.Collections.Generic.IEnumerable<System.Lazy<T>>); }
    public System.Collections.Generic.IEnumerable<System.Lazy<T>> GetExports<T>(string contractName) { return default(System.Collections.Generic.IEnumerable<System.Lazy<T>>); }
    public System.Collections.Generic.IEnumerable<System.Lazy<T, TMetadataView>> GetExports<T, TMetadataView>() { return default(System.Collections.Generic.IEnumerable<System.Lazy<T, TMetadataView>>); }
    public System.Collections.Generic.IEnumerable<System.Lazy<T, TMetadataView>> GetExports<T, TMetadataView>(string contractName) { return default(System.Collections.Generic.IEnumerable<System.Lazy<T, TMetadataView>>); }
    protected abstract System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.Export> GetExportsCore(System.ComponentModel.Composition.Primitives.ImportDefinition definition, System.ComponentModel.Composition.Hosting.AtomicComposition atomicComposition);
    protected virtual void OnExportsChanged(System.ComponentModel.Composition.Hosting.ExportsChangeEventArgs e) { }
    protected virtual void OnExportsChanging(System.ComponentModel.Composition.Hosting.ExportsChangeEventArgs e) { }
    public bool TryGetExports(System.ComponentModel.Composition.Primitives.ImportDefinition definition, System.ComponentModel.Composition.Hosting.AtomicComposition atomicComposition, out System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.Export> exports) { exports = default(System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.Export>); return default(bool); }
  }
  public partial class ExportsChangeEventArgs : System.EventArgs {
    public ExportsChangeEventArgs(System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition> addedExports, System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition> removedExports, System.ComponentModel.Composition.Hosting.AtomicComposition atomicComposition) { }
    public System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition> AddedExports { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition>); } }
    public System.ComponentModel.Composition.Hosting.AtomicComposition AtomicComposition { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ComponentModel.Composition.Hosting.AtomicComposition); } }
    public System.Collections.Generic.IEnumerable<System.String> ChangedContractNames { get { return default(System.Collections.Generic.IEnumerable<System.String>); } }
    public System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition> RemovedExports { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition>); } }
  }
  public partial class ImportEngine : System.ComponentModel.Composition.ICompositionService, System.IDisposable {
    public ImportEngine(System.ComponentModel.Composition.Hosting.ExportProvider sourceProvider) { }
    public ImportEngine(System.ComponentModel.Composition.Hosting.ExportProvider sourceProvider, bool isThreadSafe) { }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public void PreviewImports(System.ComponentModel.Composition.Primitives.ComposablePart part, System.ComponentModel.Composition.Hosting.AtomicComposition atomicComposition) { }
    public void ReleaseImports(System.ComponentModel.Composition.Primitives.ComposablePart part, System.ComponentModel.Composition.Hosting.AtomicComposition atomicComposition) { }
    public void SatisfyImports(System.ComponentModel.Composition.Primitives.ComposablePart part) { }
    public void SatisfyImportsOnce(System.ComponentModel.Composition.Primitives.ComposablePart part) { }
  }
  public partial interface INotifyComposablePartCatalogChanged {
    event System.EventHandler<System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs> Changed;
    event System.EventHandler<System.ComponentModel.Composition.Hosting.ComposablePartCatalogChangeEventArgs> Changing;
  }
  [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(System.ComponentModel.Composition.Primitives.ComposablePartCatalogDebuggerProxy))]
  public partial class TypeCatalog : System.ComponentModel.Composition.Primitives.ComposablePartCatalog, System.ComponentModel.Composition.Primitives.ICompositionElement {
    public TypeCatalog(System.Collections.Generic.IEnumerable<System.Type> types) { }
    public TypeCatalog(params System.Type[] types) { }
    public override System.Linq.IQueryable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> Parts { get { return default(System.Linq.IQueryable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition>); } }
    string System.ComponentModel.Composition.Primitives.ICompositionElement.DisplayName { get { return default(string); } }
    System.ComponentModel.Composition.Primitives.ICompositionElement System.ComponentModel.Composition.Primitives.ICompositionElement.Origin { get { return default(System.ComponentModel.Composition.Primitives.ICompositionElement); } }
    protected override void Dispose(bool disposing) { }
    public override System.Collections.Generic.IEnumerable<System.Tuple<System.ComponentModel.Composition.Primitives.ComposablePartDefinition, System.ComponentModel.Composition.Primitives.ExportDefinition>> GetExports(System.ComponentModel.Composition.Primitives.ImportDefinition definition) { return default(System.Collections.Generic.IEnumerable<System.Tuple<System.ComponentModel.Composition.Primitives.ComposablePartDefinition, System.ComponentModel.Composition.Primitives.ExportDefinition>>); }
    public override string ToString() { return default(string); }
  }
}
namespace System.ComponentModel.Composition.Primitives {
  public abstract partial class ComposablePart {
    protected ComposablePart() { }
    public abstract System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition> ExportDefinitions { get; }
    public abstract System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ImportDefinition> ImportDefinitions { get; }
    public virtual System.Collections.Generic.IDictionary<System.String, System.Object> Metadata { get { return default(System.Collections.Generic.IDictionary<System.String, System.Object>); } }
    public virtual void Activate() { }
    public abstract object GetExportedValue(System.ComponentModel.Composition.Primitives.ExportDefinition definition);
    public abstract void SetImport(System.ComponentModel.Composition.Primitives.ImportDefinition definition, System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.Export> exports);
  }
  [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(System.ComponentModel.Composition.Primitives.ComposablePartCatalogDebuggerProxy))]
  public abstract partial class ComposablePartCatalog : System.IDisposable {
    protected ComposablePartCatalog() { }
    public abstract System.Linq.IQueryable<System.ComponentModel.Composition.Primitives.ComposablePartDefinition> Parts { get; }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public virtual System.Collections.Generic.IEnumerable<System.Tuple<System.ComponentModel.Composition.Primitives.ComposablePartDefinition, System.ComponentModel.Composition.Primitives.ExportDefinition>> GetExports(System.ComponentModel.Composition.Primitives.ImportDefinition definition) { return default(System.Collections.Generic.IEnumerable<System.Tuple<System.ComponentModel.Composition.Primitives.ComposablePartDefinition, System.ComponentModel.Composition.Primitives.ExportDefinition>>); }
  }
  public abstract partial class ComposablePartDefinition {
    protected ComposablePartDefinition() { }
    public abstract System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition> ExportDefinitions { get; }
    public abstract System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ImportDefinition> ImportDefinitions { get; }
    public virtual System.Collections.Generic.IDictionary<System.String, System.Object> Metadata { get { return default(System.Collections.Generic.IDictionary<System.String, System.Object>); } }
    public abstract System.ComponentModel.Composition.Primitives.ComposablePart CreatePart();
  }
  public partial class ComposablePartException : System.Exception {
    public ComposablePartException() { }
    [System.Security.SecuritySafeCriticalAttribute]
    protected ComposablePartException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public ComposablePartException(string message) { }
    public ComposablePartException(string message, System.ComponentModel.Composition.Primitives.ICompositionElement element) { }
    public ComposablePartException(string message, System.ComponentModel.Composition.Primitives.ICompositionElement element, System.Exception innerException) { }
    public ComposablePartException(string message, System.Exception innerException) { }
    public System.ComponentModel.Composition.Primitives.ICompositionElement Element { get { return default(System.ComponentModel.Composition.Primitives.ICompositionElement); } }
    [System.Security.SecurityCriticalAttribute]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial class ContractBasedImportDefinition : System.ComponentModel.Composition.Primitives.ImportDefinition {
    protected ContractBasedImportDefinition() { }
    public ContractBasedImportDefinition(string contractName, string requiredTypeIdentity, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Type>> requiredMetadata, System.ComponentModel.Composition.Primitives.ImportCardinality cardinality, bool isRecomposable, bool isPrerequisite, System.ComponentModel.Composition.CreationPolicy requiredCreationPolicy) { }
    public override System.Linq.Expressions.Expression<System.Func<System.ComponentModel.Composition.Primitives.ExportDefinition, System.Boolean>> Constraint { get { return default(System.Linq.Expressions.Expression<System.Func<System.ComponentModel.Composition.Primitives.ExportDefinition, System.Boolean>>); } }
    public virtual System.ComponentModel.Composition.CreationPolicy RequiredCreationPolicy { get { return default(System.ComponentModel.Composition.CreationPolicy); } }
    public virtual System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Type>> RequiredMetadata { get { return default(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Type>>); } }
    public virtual string RequiredTypeIdentity { get { return default(string); } }
    public override bool IsConstraintSatisfiedBy(System.ComponentModel.Composition.Primitives.ExportDefinition exportDefinition) { return default(bool); }
  }
  public partial class Export {
    protected Export() { }
    public Export(System.ComponentModel.Composition.Primitives.ExportDefinition definition, System.Func<System.Object> exportedValueGetter) { }
    public Export(string contractName, System.Collections.Generic.IDictionary<System.String, System.Object> metadata, System.Func<System.Object> exportedValueGetter) { }
    public Export(string contractName, System.Func<System.Object> exportedValueGetter) { }
    public virtual System.ComponentModel.Composition.Primitives.ExportDefinition Definition { get { return default(System.ComponentModel.Composition.Primitives.ExportDefinition); } }
    public System.Collections.Generic.IDictionary<System.String, System.Object> Metadata { get { return default(System.Collections.Generic.IDictionary<System.String, System.Object>); } }
    public object Value { get { return default(object); } }
    protected virtual object GetExportedValueCore() { return default(object); }
  }
  public partial class ExportDefinition {
    protected ExportDefinition() { }
    public ExportDefinition(string contractName, System.Collections.Generic.IDictionary<System.String, System.Object> metadata) { }
    public virtual string ContractName { get { return default(string); } }
    public virtual System.Collections.Generic.IDictionary<System.String, System.Object> Metadata { get { return default(System.Collections.Generic.IDictionary<System.String, System.Object>); } }
    public override string ToString() { return default(string); }
  }
  public partial class ExportedDelegate {
    protected ExportedDelegate() { }
    [System.Security.SecurityCriticalAttribute]
    public ExportedDelegate(object instance, System.Reflection.MethodInfo method) { }
    public virtual System.Delegate CreateDelegate(System.Type delegateType) { return default(System.Delegate); }
  }
  public partial interface ICompositionElement {
    string DisplayName { get; }
    System.ComponentModel.Composition.Primitives.ICompositionElement Origin { get; }
  }
  public enum ImportCardinality {
    ExactlyOne = 1,
    ZeroOrMore = 2,
    ZeroOrOne = 0,
  }
  public partial class ImportDefinition {
    protected ImportDefinition() { }
    public ImportDefinition(System.Linq.Expressions.Expression<System.Func<System.ComponentModel.Composition.Primitives.ExportDefinition, System.Boolean>> constraint, string contractName, System.ComponentModel.Composition.Primitives.ImportCardinality cardinality, bool isRecomposable, bool isPrerequisite) { }
    public virtual System.ComponentModel.Composition.Primitives.ImportCardinality Cardinality { get { return default(System.ComponentModel.Composition.Primitives.ImportCardinality); } }
    public virtual System.Linq.Expressions.Expression<System.Func<System.ComponentModel.Composition.Primitives.ExportDefinition, System.Boolean>> Constraint { get { return default(System.Linq.Expressions.Expression<System.Func<System.ComponentModel.Composition.Primitives.ExportDefinition, System.Boolean>>); } }
    public virtual string ContractName { get { return default(string); } }
    public virtual bool IsPrerequisite { get { return default(bool); } }
    public virtual bool IsRecomposable { get { return default(bool); } }
    public virtual bool IsConstraintSatisfiedBy(System.ComponentModel.Composition.Primitives.ExportDefinition exportDefinition) { return default(bool); }
    public override string ToString() { return default(string); }
  }
}
namespace System.ComponentModel.Composition.ReflectionModel {
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct LazyMemberInfo {
    public LazyMemberInfo(System.Reflection.MemberInfo member) { throw new System.NotImplementedException(); }
    public LazyMemberInfo(System.Reflection.MemberTypes memberType, System.Func<System.Reflection.MemberInfo[]> accessorsCreator) { throw new System.NotImplementedException(); }
    public LazyMemberInfo(System.Reflection.MemberTypes memberType, params System.Reflection.MemberInfo[] accessors) { throw new System.NotImplementedException(); }
    public System.Reflection.MemberTypes MemberType { get { return default(System.Reflection.MemberTypes); } }
    public override bool Equals(object obj) { return default(bool); }
    public System.Reflection.MemberInfo[] GetAccessors() { return default(System.Reflection.MemberInfo[]); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.ComponentModel.Composition.ReflectionModel.LazyMemberInfo left, System.ComponentModel.Composition.ReflectionModel.LazyMemberInfo right) { return default(bool); }
    public static bool operator !=(System.ComponentModel.Composition.ReflectionModel.LazyMemberInfo left, System.ComponentModel.Composition.ReflectionModel.LazyMemberInfo right) { return default(bool); }
  }
  [System.Security.SecurityCriticalAttribute]
  public static partial class ReflectionModelServices {
    public static System.ComponentModel.Composition.Primitives.ExportDefinition CreateExportDefinition(System.ComponentModel.Composition.ReflectionModel.LazyMemberInfo exportingMember, string contractName, System.Lazy<System.Collections.Generic.IDictionary<System.String, System.Object>> metadata, System.ComponentModel.Composition.Primitives.ICompositionElement origin) { return default(System.ComponentModel.Composition.Primitives.ExportDefinition); }
    public static System.ComponentModel.Composition.Primitives.ContractBasedImportDefinition CreateImportDefinition(System.ComponentModel.Composition.ReflectionModel.LazyMemberInfo importingMember, string contractName, string requiredTypeIdentity, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Type>> requiredMetadata, System.ComponentModel.Composition.Primitives.ImportCardinality cardinality, bool isRecomposable, System.ComponentModel.Composition.CreationPolicy requiredCreationPolicy, System.ComponentModel.Composition.Primitives.ICompositionElement origin) { return default(System.ComponentModel.Composition.Primitives.ContractBasedImportDefinition); }
    public static System.ComponentModel.Composition.Primitives.ContractBasedImportDefinition CreateImportDefinition(System.Lazy<System.Reflection.ParameterInfo> parameter, string contractName, string requiredTypeIdentity, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Type>> requiredMetadata, System.ComponentModel.Composition.Primitives.ImportCardinality cardinality, System.ComponentModel.Composition.CreationPolicy requiredCreationPolicy, System.ComponentModel.Composition.Primitives.ICompositionElement origin) { return default(System.ComponentModel.Composition.Primitives.ContractBasedImportDefinition); }
    public static System.ComponentModel.Composition.Primitives.ComposablePartDefinition CreatePartDefinition(System.Lazy<System.Type> partType, bool isDisposalRequired, System.Lazy<System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ImportDefinition>> imports, System.Lazy<System.Collections.Generic.IEnumerable<System.ComponentModel.Composition.Primitives.ExportDefinition>> exports, System.Lazy<System.Collections.Generic.IDictionary<System.String, System.Object>> metadata, System.ComponentModel.Composition.Primitives.ICompositionElement origin) { return default(System.ComponentModel.Composition.Primitives.ComposablePartDefinition); }
    public static System.ComponentModel.Composition.ReflectionModel.LazyMemberInfo GetExportingMember(System.ComponentModel.Composition.Primitives.ExportDefinition exportDefinition) { return default(System.ComponentModel.Composition.ReflectionModel.LazyMemberInfo); }
    public static System.ComponentModel.Composition.ReflectionModel.LazyMemberInfo GetImportingMember(System.ComponentModel.Composition.Primitives.ImportDefinition importDefinition) { return default(System.ComponentModel.Composition.ReflectionModel.LazyMemberInfo); }
    public static System.Lazy<System.Reflection.ParameterInfo> GetImportingParameter(System.ComponentModel.Composition.Primitives.ImportDefinition importDefinition) { return default(System.Lazy<System.Reflection.ParameterInfo>); }
    public static System.Lazy<System.Type> GetPartType(System.ComponentModel.Composition.Primitives.ComposablePartDefinition partDefinition) { return default(System.Lazy<System.Type>); }
    public static bool IsDisposalRequired(System.ComponentModel.Composition.Primitives.ComposablePartDefinition partDefinition) { return default(bool); }
    public static bool IsImportingParameter(System.ComponentModel.Composition.Primitives.ImportDefinition importDefinition) { return default(bool); }
  }
}
