namespace System.Collections.Specialized {
  public partial class CollectionChangedEventManager : System.Windows.WeakEventManager {
    internal CollectionChangedEventManager() { }
    public static void AddHandler(System.Collections.Specialized.INotifyCollectionChanged source, System.EventHandler<System.Collections.Specialized.NotifyCollectionChangedEventArgs> handler) { }
    public static void AddListener(System.Collections.Specialized.INotifyCollectionChanged source, System.Windows.IWeakEventListener listener) { }
    protected override System.Windows.WeakEventManager.ListenerList NewListenerList() { return default(System.Windows.WeakEventManager.ListenerList); }
    public static void RemoveHandler(System.Collections.Specialized.INotifyCollectionChanged source, System.EventHandler<System.Collections.Specialized.NotifyCollectionChangedEventArgs> handler) { }
    public static void RemoveListener(System.Collections.Specialized.INotifyCollectionChanged source, System.Windows.IWeakEventListener listener) { }
    protected override void StartListening(object source) { }
    protected override void StopListening(object source) { }
  }
}
namespace System.ComponentModel {
  public partial class CurrentChangedEventManager : System.Windows.WeakEventManager {
    internal CurrentChangedEventManager() { }
    public static void AddHandler(System.ComponentModel.ICollectionView source, System.EventHandler<System.EventArgs> handler) { }
    public static void AddListener(System.ComponentModel.ICollectionView source, System.Windows.IWeakEventListener listener) { }
    protected override System.Windows.WeakEventManager.ListenerList NewListenerList() { return default(System.Windows.WeakEventManager.ListenerList); }
    public static void RemoveHandler(System.ComponentModel.ICollectionView source, System.EventHandler<System.EventArgs> handler) { }
    public static void RemoveListener(System.ComponentModel.ICollectionView source, System.Windows.IWeakEventListener listener) { }
    protected override void StartListening(object source) { }
    protected override void StopListening(object source) { }
  }
  public partial class CurrentChangingEventArgs : System.EventArgs {
    public CurrentChangingEventArgs() { }
    public CurrentChangingEventArgs(bool isCancelable) { }
    public bool Cancel { get { return default(bool); } set { } }
    public bool IsCancelable { get { return default(bool); } }
  }
  public delegate void CurrentChangingEventHandler(object sender, System.ComponentModel.CurrentChangingEventArgs e);
  public partial class CurrentChangingEventManager : System.Windows.WeakEventManager {
    internal CurrentChangingEventManager() { }
    public static void AddHandler(System.ComponentModel.ICollectionView source, System.EventHandler<System.ComponentModel.CurrentChangingEventArgs> handler) { }
    public static void AddListener(System.ComponentModel.ICollectionView source, System.Windows.IWeakEventListener listener) { }
    protected override System.Windows.WeakEventManager.ListenerList NewListenerList() { return default(System.Windows.WeakEventManager.ListenerList); }
    public static void RemoveHandler(System.ComponentModel.ICollectionView source, System.EventHandler<System.ComponentModel.CurrentChangingEventArgs> handler) { }
    public static void RemoveListener(System.ComponentModel.ICollectionView source, System.Windows.IWeakEventListener listener) { }
    protected override void StartListening(object source) { }
    protected override void StopListening(object source) { }
  }
  public sealed partial class DependencyPropertyDescriptor : System.ComponentModel.PropertyDescriptor {
    internal DependencyPropertyDescriptor() : base (default(string), default(System.Attribute[])) { }
    public override System.ComponentModel.AttributeCollection Attributes { get { return default(System.ComponentModel.AttributeCollection); } }
    public override string Category { get { return default(string); } }
    public override System.Type ComponentType { get { return default(System.Type); } }
    public override System.ComponentModel.TypeConverter Converter { get { return default(System.ComponentModel.TypeConverter); } }
    public System.Windows.DependencyProperty DependencyProperty { get { return default(System.Windows.DependencyProperty); } }
    public override string Description { get { return default(string); } }
    public System.Windows.CoerceValueCallback DesignerCoerceValueCallback { get { return default(System.Windows.CoerceValueCallback); } set { } }
    public override bool DesignTimeOnly { get { return default(bool); } }
    public override string DisplayName { get { return default(string); } }
    public bool IsAttached { get { return default(bool); } }
    public override bool IsBrowsable { get { return default(bool); } }
    public override bool IsLocalizable { get { return default(bool); } }
    public override bool IsReadOnly { get { return default(bool); } }
    public System.Windows.PropertyMetadata Metadata { get { return default(System.Windows.PropertyMetadata); } }
    public override System.Type PropertyType { get { return default(System.Type); } }
    public override bool SupportsChangeEvents { get { return default(bool); } }
    public override void AddValueChanged(object component, System.EventHandler handler) { }
    public override bool CanResetValue(object component) { return default(bool); }
    public override bool Equals(object obj) { return default(bool); }
    public static System.ComponentModel.DependencyPropertyDescriptor FromName(string name, System.Type ownerType, System.Type targetType) { return default(System.ComponentModel.DependencyPropertyDescriptor); }
    public static System.ComponentModel.DependencyPropertyDescriptor FromName(string name, System.Type ownerType, System.Type targetType, bool ignorePropertyType) { return default(System.ComponentModel.DependencyPropertyDescriptor); }
    public static System.ComponentModel.DependencyPropertyDescriptor FromProperty(System.ComponentModel.PropertyDescriptor property) { return default(System.ComponentModel.DependencyPropertyDescriptor); }
    public static System.ComponentModel.DependencyPropertyDescriptor FromProperty(System.Windows.DependencyProperty dependencyProperty, System.Type targetType) { return default(System.ComponentModel.DependencyPropertyDescriptor); }
    public override System.ComponentModel.PropertyDescriptorCollection GetChildProperties(object instance, System.Attribute[] filter) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public override object GetEditor(System.Type editorBaseType) { return default(object); }
    public override int GetHashCode() { return default(int); }
    public override object GetValue(object component) { return default(object); }
    public override void RemoveValueChanged(object component, System.EventHandler handler) { }
    public override void ResetValue(object component) { }
    public override void SetValue(object component, object value) { }
    public override bool ShouldSerializeValue(object component) { return default(bool); }
    public override string ToString() { return default(string); }
  }
  public partial class ErrorsChangedEventManager : System.Windows.WeakEventManager {
    internal ErrorsChangedEventManager() { }
    public static void AddHandler(System.ComponentModel.INotifyDataErrorInfo source, System.EventHandler<System.ComponentModel.DataErrorsChangedEventArgs> handler) { }
    protected override System.Windows.WeakEventManager.ListenerList NewListenerList() { return default(System.Windows.WeakEventManager.ListenerList); }
    public static void RemoveHandler(System.ComponentModel.INotifyDataErrorInfo source, System.EventHandler<System.ComponentModel.DataErrorsChangedEventArgs> handler) { }
    protected override void StartListening(object source) { }
    protected override void StopListening(object source) { }
  }
  public abstract partial class GroupDescription : System.ComponentModel.INotifyPropertyChanged {
    protected GroupDescription() { }
    public System.Collections.ObjectModel.ObservableCollection<System.Object> GroupNames { get { return default(System.Collections.ObjectModel.ObservableCollection<System.Object>); } }
    protected virtual event System.ComponentModel.PropertyChangedEventHandler PropertyChanged { add { } remove { } }
    event System.ComponentModel.PropertyChangedEventHandler System.ComponentModel.INotifyPropertyChanged.PropertyChanged { add { } remove { } }
    public abstract object GroupNameFromItem(object item, int level, System.Globalization.CultureInfo culture);
    public virtual bool NamesMatch(object groupName, object itemName) { return default(bool); }
    protected virtual void OnPropertyChanged(System.ComponentModel.PropertyChangedEventArgs e) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeGroupNames() { return default(bool); }
  }
  public partial interface ICollectionView : System.Collections.IEnumerable, System.Collections.Specialized.INotifyCollectionChanged {
    bool CanFilter { get; }
    bool CanGroup { get; }
    bool CanSort { get; }
    System.Globalization.CultureInfo Culture { get; set; }
    object CurrentItem { get; }
    int CurrentPosition { get; }
    System.Predicate<System.Object> Filter { get; set; }
    System.Collections.ObjectModel.ObservableCollection<System.ComponentModel.GroupDescription> GroupDescriptions { get; }
    System.Collections.ObjectModel.ReadOnlyObservableCollection<System.Object> Groups { get; }
    bool IsCurrentAfterLast { get; }
    bool IsCurrentBeforeFirst { get; }
    bool IsEmpty { get; }
    System.ComponentModel.SortDescriptionCollection SortDescriptions { get; }
    System.Collections.IEnumerable SourceCollection { get; }
    event System.EventHandler CurrentChanged;
    event System.ComponentModel.CurrentChangingEventHandler CurrentChanging;
    bool Contains(object item);
    System.IDisposable DeferRefresh();
    bool MoveCurrentTo(object item);
    bool MoveCurrentToFirst();
    bool MoveCurrentToLast();
    bool MoveCurrentToNext();
    bool MoveCurrentToPosition(int position);
    bool MoveCurrentToPrevious();
    void Refresh();
  }
  public partial interface ICollectionViewFactory {
    System.ComponentModel.ICollectionView CreateView();
  }
  public partial interface ICollectionViewLiveShaping {
    bool CanChangeLiveFiltering { get; }
    bool CanChangeLiveGrouping { get; }
    bool CanChangeLiveSorting { get; }
    System.Nullable<System.Boolean> IsLiveFiltering { get; set; }
    System.Nullable<System.Boolean> IsLiveGrouping { get; set; }
    System.Nullable<System.Boolean> IsLiveSorting { get; set; }
    System.Collections.ObjectModel.ObservableCollection<System.String> LiveFilteringProperties { get; }
    System.Collections.ObjectModel.ObservableCollection<System.String> LiveGroupingProperties { get; }
    System.Collections.ObjectModel.ObservableCollection<System.String> LiveSortingProperties { get; }
  }
  public partial interface IEditableCollectionView {
    bool CanAddNew { get; }
    bool CanCancelEdit { get; }
    bool CanRemove { get; }
    object CurrentAddItem { get; }
    object CurrentEditItem { get; }
    bool IsAddingNew { get; }
    bool IsEditingItem { get; }
    System.ComponentModel.NewItemPlaceholderPosition NewItemPlaceholderPosition { get; set; }
    object AddNew();
    void CancelEdit();
    void CancelNew();
    void CommitEdit();
    void CommitNew();
    void EditItem(object item);
    void Remove(object item);
    void RemoveAt(int index);
  }
  public partial interface IEditableCollectionViewAddNewItem : System.ComponentModel.IEditableCollectionView {
    bool CanAddNewItem { get; }
    object AddNewItem(object newItem);
  }
  public partial interface IItemProperties {
    System.Collections.ObjectModel.ReadOnlyCollection<System.ComponentModel.ItemPropertyInfo> ItemProperties { get; }
  }
  public partial class ItemPropertyInfo {
    public ItemPropertyInfo(string name, System.Type type, object descriptor) { }
    public object Descriptor { get { return default(object); } }
    public string Name { get { return default(string); } }
    public System.Type PropertyType { get { return default(System.Type); } }
  }
  public enum NewItemPlaceholderPosition {
    AtBeginning = 1,
    AtEnd = 2,
    None = 0,
  }
  public partial class PropertyChangedEventManager : System.Windows.WeakEventManager {
    internal PropertyChangedEventManager() { }
    public static void AddHandler(System.ComponentModel.INotifyPropertyChanged source, System.EventHandler<System.ComponentModel.PropertyChangedEventArgs> handler, string propertyName) { }
    public static void AddListener(System.ComponentModel.INotifyPropertyChanged source, System.Windows.IWeakEventListener listener, string propertyName) { }
    protected override System.Windows.WeakEventManager.ListenerList NewListenerList() { return default(System.Windows.WeakEventManager.ListenerList); }
    protected override bool Purge(object source, object data, bool purgeAll) { return default(bool); }
    public static void RemoveHandler(System.ComponentModel.INotifyPropertyChanged source, System.EventHandler<System.ComponentModel.PropertyChangedEventArgs> handler, string propertyName) { }
    public static void RemoveListener(System.ComponentModel.INotifyPropertyChanged source, System.Windows.IWeakEventListener listener, string propertyName) { }
    protected override void StartListening(object source) { }
    protected override void StopListening(object source) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(192))]
  public sealed partial class PropertyFilterAttribute : System.Attribute {
    public static readonly System.ComponentModel.PropertyFilterAttribute Default;
    public PropertyFilterAttribute(System.ComponentModel.PropertyFilterOptions filter) { }
    public System.ComponentModel.PropertyFilterOptions Filter { get { return default(System.ComponentModel.PropertyFilterOptions); } }
    public override bool Equals(object value) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool Match(object value) { return default(bool); }
  }
  [System.FlagsAttribute]
  public enum PropertyFilterOptions {
    All = 15,
    Invalid = 1,
    None = 0,
    SetValues = 2,
    UnsetValues = 4,
    Valid = 8,
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct SortDescription {
    public SortDescription(string propertyName, System.ComponentModel.ListSortDirection direction) { throw new System.NotImplementedException(); }
    public System.ComponentModel.ListSortDirection Direction { get { return default(System.ComponentModel.ListSortDirection); } set { } }
    public bool IsSealed { get { return default(bool); } }
    public string PropertyName { get { return default(string); } set { } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.ComponentModel.SortDescription sd1, System.ComponentModel.SortDescription sd2) { return default(bool); }
    public static bool operator !=(System.ComponentModel.SortDescription sd1, System.ComponentModel.SortDescription sd2) { return default(bool); }
  }
  public partial class SortDescriptionCollection : System.Collections.ObjectModel.Collection<System.ComponentModel.SortDescription>, System.Collections.Specialized.INotifyCollectionChanged {
    public static readonly System.ComponentModel.SortDescriptionCollection Empty;
    public SortDescriptionCollection() { }
    protected event System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged { add { } remove { } }
    event System.Collections.Specialized.NotifyCollectionChangedEventHandler System.Collections.Specialized.INotifyCollectionChanged.CollectionChanged { add { } remove { } }
    protected override void ClearItems() { }
    protected override void InsertItem(int index, System.ComponentModel.SortDescription item) { }
    protected override void RemoveItem(int index) { }
    protected override void SetItem(int index, System.ComponentModel.SortDescription item) { }
  }
}
namespace System.Diagnostics {
  public enum PresentationTraceLevel {
    High = 3,
    Low = 1,
    Medium = 2,
    None = 0,
  }
  public static partial class PresentationTraceSources {
    public static readonly System.Windows.DependencyProperty TraceLevelProperty;
    public static System.Diagnostics.TraceSource AnimationSource { get { return default(System.Diagnostics.TraceSource); } }
    public static System.Diagnostics.TraceSource DataBindingSource { get { return default(System.Diagnostics.TraceSource); } }
    public static System.Diagnostics.TraceSource DependencyPropertySource { get { return default(System.Diagnostics.TraceSource); } }
    public static System.Diagnostics.TraceSource DocumentsSource { get { return default(System.Diagnostics.TraceSource); } }
    public static System.Diagnostics.TraceSource FreezableSource { get { return default(System.Diagnostics.TraceSource); } }
    public static System.Diagnostics.TraceSource HwndHostSource { get { return default(System.Diagnostics.TraceSource); } }
    public static System.Diagnostics.TraceSource MarkupSource { get { return default(System.Diagnostics.TraceSource); } }
    public static System.Diagnostics.TraceSource NameScopeSource { get { return default(System.Diagnostics.TraceSource); } }
    public static System.Diagnostics.TraceSource ResourceDictionarySource { get { return default(System.Diagnostics.TraceSource); } }
    public static System.Diagnostics.TraceSource RoutedEventSource { get { return default(System.Diagnostics.TraceSource); } }
    public static System.Diagnostics.TraceSource ShellSource { get { return default(System.Diagnostics.TraceSource); } }
    public static System.Diagnostics.PresentationTraceLevel GetTraceLevel(object element) { return default(System.Diagnostics.PresentationTraceLevel); }
    public static void Refresh() { }
    public static void SetTraceLevel(object element, System.Diagnostics.PresentationTraceLevel traceLevel) { }
  }
}
namespace System.IO {
  public partial class FileFormatException : System.FormatException, System.Runtime.Serialization.ISerializable {
    public FileFormatException() { }
    protected FileFormatException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public FileFormatException(string message) { }
    public FileFormatException(string message, System.Exception innerException) { }
    public FileFormatException(System.Uri sourceUri) { }
    public FileFormatException(System.Uri sourceUri, System.Exception innerException) { }
    public FileFormatException(System.Uri sourceUri, string message) { }
    public FileFormatException(System.Uri sourceUri, string message, System.Exception innerException) { }
    public System.Uri SourceUri { [System.Security.SecuritySafeCriticalAttribute]get { return default(System.Uri); } }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(128))]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
}
namespace System.IO.Packaging {
  public enum CertificateEmbeddingOption {
    InCertificatePart = 0,
    InSignaturePart = 1,
    NotEmbedded = 2,
  }
  public enum CompressionOption {
    Fast = 2,
    Maximum = 1,
    Normal = 0,
    NotCompressed = -1,
    SuperFast = 3,
  }
  public partial class EncryptedPackageEnvelope : System.IDisposable {
    internal EncryptedPackageEnvelope() { }
    public System.IO.FileAccess FileOpenAccess { get { return default(System.IO.FileAccess); } }
    public System.IO.Packaging.PackageProperties PackageProperties { get { return default(System.IO.Packaging.PackageProperties); } }
    public System.IO.Packaging.RightsManagementInformation RightsManagementInformation { get { return default(System.IO.Packaging.RightsManagementInformation); } }
    public System.IO.Packaging.StorageInfo StorageInfo { get { return default(System.IO.Packaging.StorageInfo); } }
    public void Close() { }
    public static System.IO.Packaging.EncryptedPackageEnvelope Create(System.IO.Stream envelopeStream, System.Security.RightsManagement.PublishLicense publishLicense, System.Security.RightsManagement.CryptoProvider cryptoProvider) { return default(System.IO.Packaging.EncryptedPackageEnvelope); }
    public static System.IO.Packaging.EncryptedPackageEnvelope Create(string envelopeFileName, System.Security.RightsManagement.PublishLicense publishLicense, System.Security.RightsManagement.CryptoProvider cryptoProvider) { return default(System.IO.Packaging.EncryptedPackageEnvelope); }
    public static System.IO.Packaging.EncryptedPackageEnvelope CreateFromPackage(System.IO.Stream envelopeStream, System.IO.Stream packageStream, System.Security.RightsManagement.PublishLicense publishLicense, System.Security.RightsManagement.CryptoProvider cryptoProvider) { return default(System.IO.Packaging.EncryptedPackageEnvelope); }
    public static System.IO.Packaging.EncryptedPackageEnvelope CreateFromPackage(string envelopeFileName, System.IO.Stream packageStream, System.Security.RightsManagement.PublishLicense publishLicense, System.Security.RightsManagement.CryptoProvider cryptoProvider) { return default(System.IO.Packaging.EncryptedPackageEnvelope); }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public void Flush() { }
    public System.IO.Packaging.Package GetPackage() { return default(System.IO.Packaging.Package); }
    public static bool IsEncryptedPackageEnvelope(System.IO.Stream stream) { return default(bool); }
    public static bool IsEncryptedPackageEnvelope(string fileName) { return default(bool); }
    public static System.IO.Packaging.EncryptedPackageEnvelope Open(System.IO.Stream envelopeStream) { return default(System.IO.Packaging.EncryptedPackageEnvelope); }
    public static System.IO.Packaging.EncryptedPackageEnvelope Open(string envelopeFileName) { return default(System.IO.Packaging.EncryptedPackageEnvelope); }
    public static System.IO.Packaging.EncryptedPackageEnvelope Open(string envelopeFileName, System.IO.FileAccess access) { return default(System.IO.Packaging.EncryptedPackageEnvelope); }
    public static System.IO.Packaging.EncryptedPackageEnvelope Open(string envelopeFileName, System.IO.FileAccess access, System.IO.FileShare sharing) { return default(System.IO.Packaging.EncryptedPackageEnvelope); }
  }
  public enum EncryptionOption {
    None = 0,
    RightsManagement = 1,
  }
  public delegate void InvalidSignatureEventHandler(object sender, System.IO.Packaging.SignatureVerificationEventArgs e);
  public abstract partial class Package : System.IDisposable {
    protected Package(System.IO.FileAccess openFileAccess) { }
    protected Package(System.IO.FileAccess openFileAccess, bool streaming) { }
    public System.IO.FileAccess FileOpenAccess { get { return default(System.IO.FileAccess); } }
    public System.IO.Packaging.PackageProperties PackageProperties { get { return default(System.IO.Packaging.PackageProperties); } }
    public void Close() { }
    public System.IO.Packaging.PackagePart CreatePart(System.Uri partUri, string contentType) { return default(System.IO.Packaging.PackagePart); }
    public System.IO.Packaging.PackagePart CreatePart(System.Uri partUri, string contentType, System.IO.Packaging.CompressionOption compressionOption) { return default(System.IO.Packaging.PackagePart); }
    protected abstract System.IO.Packaging.PackagePart CreatePartCore(System.Uri partUri, string contentType, System.IO.Packaging.CompressionOption compressionOption);
    public System.IO.Packaging.PackageRelationship CreateRelationship(System.Uri targetUri, System.IO.Packaging.TargetMode targetMode, string relationshipType) { return default(System.IO.Packaging.PackageRelationship); }
    public System.IO.Packaging.PackageRelationship CreateRelationship(System.Uri targetUri, System.IO.Packaging.TargetMode targetMode, string relationshipType, string id) { return default(System.IO.Packaging.PackageRelationship); }
    public void DeletePart(System.Uri partUri) { }
    protected abstract void DeletePartCore(System.Uri partUri);
    public void DeleteRelationship(string id) { }
    protected virtual void Dispose(bool disposing) { }
    public void Flush() { }
    protected abstract void FlushCore();
    public System.IO.Packaging.PackagePart GetPart(System.Uri partUri) { return default(System.IO.Packaging.PackagePart); }
    protected abstract System.IO.Packaging.PackagePart GetPartCore(System.Uri partUri);
    public System.IO.Packaging.PackagePartCollection GetParts() { return default(System.IO.Packaging.PackagePartCollection); }
    protected abstract System.IO.Packaging.PackagePart[] GetPartsCore();
    public System.IO.Packaging.PackageRelationship GetRelationship(string id) { return default(System.IO.Packaging.PackageRelationship); }
    public System.IO.Packaging.PackageRelationshipCollection GetRelationships() { return default(System.IO.Packaging.PackageRelationshipCollection); }
    public System.IO.Packaging.PackageRelationshipCollection GetRelationshipsByType(string relationshipType) { return default(System.IO.Packaging.PackageRelationshipCollection); }
    public static System.IO.Packaging.Package Open(System.IO.Stream stream) { return default(System.IO.Packaging.Package); }
    public static System.IO.Packaging.Package Open(System.IO.Stream stream, System.IO.FileMode packageMode) { return default(System.IO.Packaging.Package); }
    public static System.IO.Packaging.Package Open(System.IO.Stream stream, System.IO.FileMode packageMode, System.IO.FileAccess packageAccess) { return default(System.IO.Packaging.Package); }
    public static System.IO.Packaging.Package Open(string path) { return default(System.IO.Packaging.Package); }
    public static System.IO.Packaging.Package Open(string path, System.IO.FileMode packageMode) { return default(System.IO.Packaging.Package); }
    public static System.IO.Packaging.Package Open(string path, System.IO.FileMode packageMode, System.IO.FileAccess packageAccess) { return default(System.IO.Packaging.Package); }
    public static System.IO.Packaging.Package Open(string path, System.IO.FileMode packageMode, System.IO.FileAccess packageAccess, System.IO.FileShare packageShare) { return default(System.IO.Packaging.Package); }
    public virtual bool PartExists(System.Uri partUri) { return default(bool); }
    public bool RelationshipExists(string id) { return default(bool); }
    void System.IDisposable.Dispose() { }
  }
  public partial class PackageDigitalSignature {
    internal PackageDigitalSignature() { }
    public System.IO.Packaging.CertificateEmbeddingOption CertificateEmbeddingOption { get { return default(System.IO.Packaging.CertificateEmbeddingOption); } }
    public System.Security.Cryptography.Xml.Signature Signature { get { return default(System.Security.Cryptography.Xml.Signature); } set { } }
    public System.IO.Packaging.PackagePart SignaturePart { get { return default(System.IO.Packaging.PackagePart); } }
    public string SignatureType { get { return default(string); } }
    public System.Byte[] SignatureValue { get { return default(System.Byte[]); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Uri> SignedParts { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Uri>); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.IO.Packaging.PackageRelationshipSelector> SignedRelationshipSelectors { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.IO.Packaging.PackageRelationshipSelector>); } }
    public System.Security.Cryptography.X509Certificates.X509Certificate Signer { get { return default(System.Security.Cryptography.X509Certificates.X509Certificate); } }
    public System.DateTime SigningTime { get { return default(System.DateTime); } }
    public string TimeFormat { get { return default(string); } }
    public System.Collections.Generic.List<System.String> GetPartTransformList(System.Uri partName) { return default(System.Collections.Generic.List<System.String>); }
    public System.IO.Packaging.VerifyResult Verify() { return default(System.IO.Packaging.VerifyResult); }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.SecurityTreatAsSafeAttribute]
    public System.IO.Packaging.VerifyResult Verify(System.Security.Cryptography.X509Certificates.X509Certificate signingCertificate) { return default(System.IO.Packaging.VerifyResult); }
  }
  public sealed partial class PackageDigitalSignatureManager {
    public PackageDigitalSignatureManager(System.IO.Packaging.Package package) { }
    public System.IO.Packaging.CertificateEmbeddingOption CertificateOption { get { return default(System.IO.Packaging.CertificateEmbeddingOption); } set { } }
    public static string DefaultHashAlgorithm { get { return default(string); } }
    public string HashAlgorithm { get { return default(string); } set { } }
    public bool IsSigned { get { return default(bool); } }
    public System.IntPtr ParentWindow { get { return default(System.IntPtr); } set { } }
    public System.Uri SignatureOrigin { get { return default(System.Uri); } }
    public static string SignatureOriginRelationshipType { get { return default(string); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.IO.Packaging.PackageDigitalSignature> Signatures { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.IO.Packaging.PackageDigitalSignature>); } }
    public string TimeFormat { get { return default(string); } set { } }
    public System.Collections.Generic.Dictionary<System.String, System.String> TransformMapping { get { return default(System.Collections.Generic.Dictionary<System.String, System.String>); } }
    public event System.IO.Packaging.InvalidSignatureEventHandler InvalidSignatureEvent { add { } remove { } }
    public System.IO.Packaging.PackageDigitalSignature Countersign() { return default(System.IO.Packaging.PackageDigitalSignature); }
    public System.IO.Packaging.PackageDigitalSignature Countersign(System.Security.Cryptography.X509Certificates.X509Certificate certificate) { return default(System.IO.Packaging.PackageDigitalSignature); }
    public System.IO.Packaging.PackageDigitalSignature Countersign(System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Collections.Generic.IEnumerable<System.Uri> signatures) { return default(System.IO.Packaging.PackageDigitalSignature); }
    public System.IO.Packaging.PackageDigitalSignature GetSignature(System.Uri signatureUri) { return default(System.IO.Packaging.PackageDigitalSignature); }
    public void RemoveAllSignatures() { }
    public void RemoveSignature(System.Uri signatureUri) { }
    public System.IO.Packaging.PackageDigitalSignature Sign(System.Collections.Generic.IEnumerable<System.Uri> parts) { return default(System.IO.Packaging.PackageDigitalSignature); }
    public System.IO.Packaging.PackageDigitalSignature Sign(System.Collections.Generic.IEnumerable<System.Uri> parts, System.Security.Cryptography.X509Certificates.X509Certificate certificate) { return default(System.IO.Packaging.PackageDigitalSignature); }
    public System.IO.Packaging.PackageDigitalSignature Sign(System.Collections.Generic.IEnumerable<System.Uri> parts, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Collections.Generic.IEnumerable<System.IO.Packaging.PackageRelationshipSelector> relationshipSelectors) { return default(System.IO.Packaging.PackageDigitalSignature); }
    public System.IO.Packaging.PackageDigitalSignature Sign(System.Collections.Generic.IEnumerable<System.Uri> parts, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Collections.Generic.IEnumerable<System.IO.Packaging.PackageRelationshipSelector> relationshipSelectors, string signatureId) { return default(System.IO.Packaging.PackageDigitalSignature); }
    [System.Security.SecurityCriticalAttribute]
    public System.IO.Packaging.PackageDigitalSignature Sign(System.Collections.Generic.IEnumerable<System.Uri> parts, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Collections.Generic.IEnumerable<System.IO.Packaging.PackageRelationshipSelector> relationshipSelectors, string signatureId, System.Collections.Generic.IEnumerable<System.Security.Cryptography.Xml.DataObject> signatureObjects, System.Collections.Generic.IEnumerable<System.Security.Cryptography.Xml.Reference> objectReferences) { return default(System.IO.Packaging.PackageDigitalSignature); }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
    public static System.Security.Cryptography.X509Certificates.X509ChainStatusFlags VerifyCertificate(System.Security.Cryptography.X509Certificates.X509Certificate certificate) { return default(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags); }
    public System.IO.Packaging.VerifyResult VerifySignatures(bool exitOnFailure) { return default(System.IO.Packaging.VerifyResult); }
  }
  public abstract partial class PackagePart {
    protected PackagePart(System.IO.Packaging.Package package, System.Uri partUri) { }
    protected PackagePart(System.IO.Packaging.Package package, System.Uri partUri, string contentType) { }
    protected PackagePart(System.IO.Packaging.Package package, System.Uri partUri, string contentType, System.IO.Packaging.CompressionOption compressionOption) { }
    public System.IO.Packaging.CompressionOption CompressionOption { get { return default(System.IO.Packaging.CompressionOption); } }
    public string ContentType { get { return default(string); } }
    public System.IO.Packaging.Package Package { get { return default(System.IO.Packaging.Package); } }
    public System.Uri Uri { get { return default(System.Uri); } }
    public System.IO.Packaging.PackageRelationship CreateRelationship(System.Uri targetUri, System.IO.Packaging.TargetMode targetMode, string relationshipType) { return default(System.IO.Packaging.PackageRelationship); }
    public System.IO.Packaging.PackageRelationship CreateRelationship(System.Uri targetUri, System.IO.Packaging.TargetMode targetMode, string relationshipType, string id) { return default(System.IO.Packaging.PackageRelationship); }
    public void DeleteRelationship(string id) { }
    protected virtual string GetContentTypeCore() { return default(string); }
    public System.IO.Packaging.PackageRelationship GetRelationship(string id) { return default(System.IO.Packaging.PackageRelationship); }
    public System.IO.Packaging.PackageRelationshipCollection GetRelationships() { return default(System.IO.Packaging.PackageRelationshipCollection); }
    public System.IO.Packaging.PackageRelationshipCollection GetRelationshipsByType(string relationshipType) { return default(System.IO.Packaging.PackageRelationshipCollection); }
    public System.IO.Stream GetStream() { return default(System.IO.Stream); }
    public System.IO.Stream GetStream(System.IO.FileMode mode) { return default(System.IO.Stream); }
    public System.IO.Stream GetStream(System.IO.FileMode mode, System.IO.FileAccess access) { return default(System.IO.Stream); }
    protected abstract System.IO.Stream GetStreamCore(System.IO.FileMode mode, System.IO.FileAccess access);
    public bool RelationshipExists(string id) { return default(bool); }
  }
  public partial class PackagePartCollection : System.Collections.Generic.IEnumerable<System.IO.Packaging.PackagePart>, System.Collections.IEnumerable {
    internal PackagePartCollection() { }
    public System.Collections.Generic.IEnumerator<System.IO.Packaging.PackagePart> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.IO.Packaging.PackagePart>); }
    System.Collections.Generic.IEnumerator<System.IO.Packaging.PackagePart> System.Collections.Generic.IEnumerable<System.IO.Packaging.PackagePart>.GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.IO.Packaging.PackagePart>); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public abstract partial class PackageProperties : System.IDisposable {
    protected PackageProperties() { }
    public abstract string Category { get; set; }
    public abstract string ContentStatus { get; set; }
    public abstract string ContentType { get; set; }
    public abstract System.Nullable<System.DateTime> Created { get; set; }
    public abstract string Creator { get; set; }
    public abstract string Description { get; set; }
    public abstract string Identifier { get; set; }
    public abstract string Keywords { get; set; }
    public abstract string Language { get; set; }
    public abstract string LastModifiedBy { get; set; }
    public abstract System.Nullable<System.DateTime> LastPrinted { get; set; }
    public abstract System.Nullable<System.DateTime> Modified { get; set; }
    public abstract string Revision { get; set; }
    public abstract string Subject { get; set; }
    public abstract string Title { get; set; }
    public abstract string Version { get; set; }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
  }
  public partial class PackageRelationship {
    internal PackageRelationship() { }
    public string Id { get { return default(string); } }
    public System.IO.Packaging.Package Package { get { return default(System.IO.Packaging.Package); } }
    public string RelationshipType { get { return default(string); } }
    public System.Uri SourceUri { get { return default(System.Uri); } }
    public System.IO.Packaging.TargetMode TargetMode { get { return default(System.IO.Packaging.TargetMode); } }
    public System.Uri TargetUri { get { return default(System.Uri); } }
  }
  public partial class PackageRelationshipCollection : System.Collections.Generic.IEnumerable<System.IO.Packaging.PackageRelationship>, System.Collections.IEnumerable {
    internal PackageRelationshipCollection() { }
    public System.Collections.Generic.IEnumerator<System.IO.Packaging.PackageRelationship> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.IO.Packaging.PackageRelationship>); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public sealed partial class PackageRelationshipSelector {
    public PackageRelationshipSelector(System.Uri sourceUri, System.IO.Packaging.PackageRelationshipSelectorType selectorType, string selectionCriteria) { }
    public string SelectionCriteria { get { return default(string); } }
    public System.IO.Packaging.PackageRelationshipSelectorType SelectorType { get { return default(System.IO.Packaging.PackageRelationshipSelectorType); } }
    public System.Uri SourceUri { get { return default(System.Uri); } }
    public System.Collections.Generic.List<System.IO.Packaging.PackageRelationship> Select(System.IO.Packaging.Package package) { return default(System.Collections.Generic.List<System.IO.Packaging.PackageRelationship>); }
  }
  public enum PackageRelationshipSelectorType {
    Id = 0,
    Type = 1,
  }
  public static partial class PackUriHelper {
    public static readonly string UriSchemePack;
    public static int ComparePackUri(System.Uri firstPackUri, System.Uri secondPackUri) { return default(int); }
    public static int ComparePartUri(System.Uri firstPartUri, System.Uri secondPartUri) { return default(int); }
    public static System.Uri Create(System.Uri packageUri) { return default(System.Uri); }
    public static System.Uri Create(System.Uri packageUri, System.Uri partUri) { return default(System.Uri); }
    public static System.Uri Create(System.Uri packageUri, System.Uri partUri, string fragment) { return default(System.Uri); }
    public static System.Uri CreatePartUri(System.Uri partUri) { return default(System.Uri); }
    public static System.Uri GetNormalizedPartUri(System.Uri partUri) { return default(System.Uri); }
    public static System.Uri GetPackageUri(System.Uri packUri) { return default(System.Uri); }
    public static System.Uri GetPartUri(System.Uri packUri) { return default(System.Uri); }
    public static System.Uri GetRelationshipPartUri(System.Uri partUri) { return default(System.Uri); }
    public static System.Uri GetRelativeUri(System.Uri sourcePartUri, System.Uri targetPartUri) { return default(System.Uri); }
    public static System.Uri GetSourcePartUriFromRelationshipPartUri(System.Uri relationshipPartUri) { return default(System.Uri); }
    public static bool IsRelationshipPartUri(System.Uri partUri) { return default(bool); }
    public static System.Uri ResolvePartUri(System.Uri sourcePartUri, System.Uri targetUri) { return default(System.Uri); }
  }
  public partial class RightsManagementInformation {
    internal RightsManagementInformation() { }
    public System.Security.RightsManagement.CryptoProvider CryptoProvider { get { return default(System.Security.RightsManagement.CryptoProvider); } set { } }
    public void DeleteUseLicense(System.Security.RightsManagement.ContentUser userKey) { }
    public System.Collections.Generic.IDictionary<System.Security.RightsManagement.ContentUser, System.Security.RightsManagement.UseLicense> GetEmbeddedUseLicenses() { return default(System.Collections.Generic.IDictionary<System.Security.RightsManagement.ContentUser, System.Security.RightsManagement.UseLicense>); }
    public System.Security.RightsManagement.PublishLicense LoadPublishLicense() { return default(System.Security.RightsManagement.PublishLicense); }
    public System.Security.RightsManagement.UseLicense LoadUseLicense(System.Security.RightsManagement.ContentUser userKey) { return default(System.Security.RightsManagement.UseLicense); }
    public void SavePublishLicense(System.Security.RightsManagement.PublishLicense publishLicense) { }
    public void SaveUseLicense(System.Security.RightsManagement.ContentUser userKey, System.Security.RightsManagement.UseLicense useLicense) { }
  }
  public partial class SignatureVerificationEventArgs : System.EventArgs {
    internal SignatureVerificationEventArgs() { }
    public System.IO.Packaging.PackageDigitalSignature Signature { get { return default(System.IO.Packaging.PackageDigitalSignature); } }
    public System.IO.Packaging.VerifyResult VerifyResult { get { return default(System.IO.Packaging.VerifyResult); } }
  }
  public partial class StorageInfo {
    internal StorageInfo() { }
    public string Name { get { return default(string); } }
    public System.IO.Packaging.StreamInfo CreateStream(string name) { return default(System.IO.Packaging.StreamInfo); }
    public System.IO.Packaging.StreamInfo CreateStream(string name, System.IO.Packaging.CompressionOption compressionOption, System.IO.Packaging.EncryptionOption encryptionOption) { return default(System.IO.Packaging.StreamInfo); }
    public System.IO.Packaging.StorageInfo CreateSubStorage(string name) { return default(System.IO.Packaging.StorageInfo); }
    public void DeleteStream(string name) { }
    public void DeleteSubStorage(string name) { }
    public System.IO.Packaging.StreamInfo GetStreamInfo(string name) { return default(System.IO.Packaging.StreamInfo); }
    public System.IO.Packaging.StreamInfo[] GetStreams() { return default(System.IO.Packaging.StreamInfo[]); }
    public System.IO.Packaging.StorageInfo GetSubStorageInfo(string name) { return default(System.IO.Packaging.StorageInfo); }
    public System.IO.Packaging.StorageInfo[] GetSubStorages() { return default(System.IO.Packaging.StorageInfo[]); }
    public bool StreamExists(string name) { return default(bool); }
    public bool SubStorageExists(string name) { return default(bool); }
  }
  public partial class StreamInfo {
    internal StreamInfo() { }
    public System.IO.Packaging.CompressionOption CompressionOption { get { return default(System.IO.Packaging.CompressionOption); } }
    public System.IO.Packaging.EncryptionOption EncryptionOption { get { return default(System.IO.Packaging.EncryptionOption); } }
    public string Name { get { return default(string); } }
    public System.IO.Stream GetStream() { return default(System.IO.Stream); }
    public System.IO.Stream GetStream(System.IO.FileMode mode) { return default(System.IO.Stream); }
    public System.IO.Stream GetStream(System.IO.FileMode mode, System.IO.FileAccess access) { return default(System.IO.Stream); }
  }
  public enum TargetMode {
    External = 1,
    Internal = 0,
  }
  public enum VerifyResult {
    CertificateRequired = 2,
    InvalidCertificate = 3,
    InvalidSignature = 1,
    NotSigned = 5,
    ReferenceNotFound = 4,
    Success = 0,
  }
  public sealed partial class ZipPackage : System.IO.Packaging.Package {
    internal ZipPackage() : base (default(System.IO.FileAccess)) { }
    protected override System.IO.Packaging.PackagePart CreatePartCore(System.Uri partUri, string contentType, System.IO.Packaging.CompressionOption compressionOption) { return default(System.IO.Packaging.PackagePart); }
    protected override void DeletePartCore(System.Uri partUri) { }
    protected override void Dispose(bool disposing) { }
    protected override void FlushCore() { }
    protected override System.IO.Packaging.PackagePart GetPartCore(System.Uri partUri) { return default(System.IO.Packaging.PackagePart); }
    protected override System.IO.Packaging.PackagePart[] GetPartsCore() { return default(System.IO.Packaging.PackagePart[]); }
  }
  public sealed partial class ZipPackagePart : System.IO.Packaging.PackagePart {
    internal ZipPackagePart() : base (default(System.IO.Packaging.Package), default(System.Uri)) { }
    protected override System.IO.Stream GetStreamCore(System.IO.FileMode mode, System.IO.FileAccess access) { return default(System.IO.Stream); }
  }
}
namespace System.Security.Permissions {
  public sealed partial class MediaPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission {
    public MediaPermission() { }
    public MediaPermission(System.Security.Permissions.MediaPermissionAudio permissionAudio) { }
    public MediaPermission(System.Security.Permissions.MediaPermissionAudio permissionAudio, System.Security.Permissions.MediaPermissionVideo permissionVideo, System.Security.Permissions.MediaPermissionImage permissionImage) { }
    public MediaPermission(System.Security.Permissions.MediaPermissionImage permissionImage) { }
    public MediaPermission(System.Security.Permissions.MediaPermissionVideo permissionVideo) { }
    public MediaPermission(System.Security.Permissions.PermissionState state) { }
    public System.Security.Permissions.MediaPermissionAudio Audio { get { return default(System.Security.Permissions.MediaPermissionAudio); } }
    public System.Security.Permissions.MediaPermissionImage Image { get { return default(System.Security.Permissions.MediaPermissionImage); } }
    public System.Security.Permissions.MediaPermissionVideo Video { get { return default(System.Security.Permissions.MediaPermissionVideo); } }
    public override System.Security.IPermission Copy() { return default(System.Security.IPermission); }
    public override void FromXml(System.Security.SecurityElement securityElement) { }
    public override System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
    public override bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
    public bool IsUnrestricted() { return default(bool); }
    public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
    public override System.Security.IPermission Union(System.Security.IPermission target) { return default(System.Security.IPermission); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
  public sealed partial class MediaPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute {
    public MediaPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
    public System.Security.Permissions.MediaPermissionAudio Audio { get { return default(System.Security.Permissions.MediaPermissionAudio); } set { } }
    public System.Security.Permissions.MediaPermissionImage Image { get { return default(System.Security.Permissions.MediaPermissionImage); } set { } }
    public System.Security.Permissions.MediaPermissionVideo Video { get { return default(System.Security.Permissions.MediaPermissionVideo); } set { } }
    public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
  }
  public enum MediaPermissionAudio {
    AllAudio = 3,
    NoAudio = 0,
    SafeAudio = 2,
    SiteOfOriginAudio = 1,
  }
  public enum MediaPermissionImage {
    AllImage = 3,
    NoImage = 0,
    SafeImage = 2,
    SiteOfOriginImage = 1,
  }
  public enum MediaPermissionVideo {
    AllVideo = 3,
    NoVideo = 0,
    SafeVideo = 2,
    SiteOfOriginVideo = 1,
  }
  public sealed partial class WebBrowserPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission {
    public WebBrowserPermission() { }
    public WebBrowserPermission(System.Security.Permissions.PermissionState state) { }
    public WebBrowserPermission(System.Security.Permissions.WebBrowserPermissionLevel webBrowserPermissionLevel) { }
    public System.Security.Permissions.WebBrowserPermissionLevel Level { get { return default(System.Security.Permissions.WebBrowserPermissionLevel); } set { } }
    public override System.Security.IPermission Copy() { return default(System.Security.IPermission); }
    public override void FromXml(System.Security.SecurityElement securityElement) { }
    public override System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
    public override bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
    public bool IsUnrestricted() { return default(bool); }
    public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
    public override System.Security.IPermission Union(System.Security.IPermission target) { return default(System.Security.IPermission); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
  public sealed partial class WebBrowserPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute {
    public WebBrowserPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
    public System.Security.Permissions.WebBrowserPermissionLevel Level { get { return default(System.Security.Permissions.WebBrowserPermissionLevel); } set { } }
    public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
  }
  public enum WebBrowserPermissionLevel {
    None = 0,
    Safe = 1,
    Unrestricted = 2,
  }
}
namespace System.Security.RightsManagement {
  public enum AuthenticationType {
    Internal = 3,
    Passport = 1,
    Windows = 0,
    WindowsPassport = 2,
  }
  [System.Security.SecurityCriticalAttribute((System.Security.SecurityCriticalScope)(1))]
  public partial class ContentGrant {
    public ContentGrant(System.Security.RightsManagement.ContentUser user, System.Security.RightsManagement.ContentRight right) { }
    public ContentGrant(System.Security.RightsManagement.ContentUser user, System.Security.RightsManagement.ContentRight right, System.DateTime validFrom, System.DateTime validUntil) { }
    public System.Security.RightsManagement.ContentRight Right { get { return default(System.Security.RightsManagement.ContentRight); } }
    public System.Security.RightsManagement.ContentUser User { get { return default(System.Security.RightsManagement.ContentUser); } }
    public System.DateTime ValidFrom { get { return default(System.DateTime); } }
    public System.DateTime ValidUntil { get { return default(System.DateTime); } }
  }
  public enum ContentRight {
    DocumentEdit = 11,
    Edit = 1,
    Export = 12,
    Extract = 3,
    Forward = 7,
    ObjectModel = 4,
    Owner = 5,
    Print = 2,
    Reply = 8,
    ReplyAll = 9,
    Sign = 10,
    View = 0,
    ViewRightsData = 6,
  }
  [System.Security.SecurityCriticalAttribute((System.Security.SecurityCriticalScope)(1))]
  public partial class ContentUser {
    public ContentUser(string name, System.Security.RightsManagement.AuthenticationType authenticationType) { }
    public static System.Security.RightsManagement.ContentUser AnyoneUser { get { return default(System.Security.RightsManagement.ContentUser); } }
    public System.Security.RightsManagement.AuthenticationType AuthenticationType { get { return default(System.Security.RightsManagement.AuthenticationType); } }
    public string Name { get { return default(string); } }
    public static System.Security.RightsManagement.ContentUser OwnerUser { get { return default(System.Security.RightsManagement.ContentUser); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public bool IsAuthenticated() { return default(bool); }
  }
  [System.Security.SecurityCriticalAttribute((System.Security.SecurityCriticalScope)(1))]
  public partial class CryptoProvider : System.IDisposable {
    internal CryptoProvider() { }
    public int BlockSize { get { return default(int); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Security.RightsManagement.ContentGrant> BoundGrants { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Security.RightsManagement.ContentGrant>); } }
    public bool CanDecrypt { get { return default(bool); } }
    public bool CanEncrypt { get { return default(bool); } }
    public bool CanMergeBlocks { get { return default(bool); } }
    public System.Byte[] Decrypt(System.Byte[] cryptoText) { return default(System.Byte[]); }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public System.Byte[] Encrypt(System.Byte[] clearText) { return default(System.Byte[]); }
    ~CryptoProvider() { }
  }
  [System.Security.SecurityCriticalAttribute((System.Security.SecurityCriticalScope)(1))]
  public partial class LocalizedNameDescriptionPair {
    public LocalizedNameDescriptionPair(string name, string description) { }
    public string Description { get { return default(string); } }
    public string Name { get { return default(string); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }
  [System.Security.SecurityCriticalAttribute((System.Security.SecurityCriticalScope)(1))]
  public partial class PublishLicense {
    public PublishLicense(string signedPublishLicense) { }
    public System.Guid ContentId { get { return default(System.Guid); } }
    public string ReferralInfoName { get { return default(string); } }
    public System.Uri ReferralInfoUri { get { return default(System.Uri); } }
    public System.Uri UseLicenseAcquisitionUrl { get { return default(System.Uri); } }
    public System.Security.RightsManagement.UseLicense AcquireUseLicense(System.Security.RightsManagement.SecureEnvironment secureEnvironment) { return default(System.Security.RightsManagement.UseLicense); }
    public System.Security.RightsManagement.UseLicense AcquireUseLicenseNoUI(System.Security.RightsManagement.SecureEnvironment secureEnvironment) { return default(System.Security.RightsManagement.UseLicense); }
    public System.Security.RightsManagement.UnsignedPublishLicense DecryptUnsignedPublishLicense(System.Security.RightsManagement.CryptoProvider cryptoProvider) { return default(System.Security.RightsManagement.UnsignedPublishLicense); }
    public override string ToString() { return default(string); }
  }
  public partial class RightsManagementException : System.Exception {
    public RightsManagementException() { }
    protected RightsManagementException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public RightsManagementException(System.Security.RightsManagement.RightsManagementFailureCode failureCode) { }
    public RightsManagementException(System.Security.RightsManagement.RightsManagementFailureCode failureCode, System.Exception innerException) { }
    public RightsManagementException(System.Security.RightsManagement.RightsManagementFailureCode failureCode, string message) { }
    public RightsManagementException(System.Security.RightsManagement.RightsManagementFailureCode failureCode, string message, System.Exception innerException) { }
    public RightsManagementException(string message) { }
    public RightsManagementException(string message, System.Exception innerException) { }
    public System.Security.RightsManagement.RightsManagementFailureCode FailureCode { get { return default(System.Security.RightsManagement.RightsManagementFailureCode); } }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(128))]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public enum RightsManagementFailureCode {
    Aborted = -2147168447,
    ActivationFailed = -2147168448,
    AdEntryNotFound = -2147168419,
    AlreadyInProgress = -2147168456,
    AuthenticationFailed = -2147168445,
    BadGetInfoQuery = -2147168494,
    BindAccessPrincipalNotEnabling = -2147168478,
    BindAccessUnsatisfied = -2147168477,
    BindContentNotInEndUseLicense = -2147168479,
    BindIndicatedPrincipalMissing = -2147168476,
    BindIntervalTimeViolated = -2147168465,
    BindMachineNotFoundInGroupIdentity = -2147168475,
    BindNoApplicableRevocationList = -2147168472,
    BindNoSatisfiedRightsGroup = -2147168464,
    BindPolicyViolation = -2147168485,
    BindRevocationListStale = -2147168473,
    BindRevokedIssuer = -2147168483,
    BindRevokedLicense = -2147168484,
    BindRevokedModule = -2147168480,
    BindRevokedPrincipal = -2147168482,
    BindRevokedResource = -2147168481,
    BindSpecifiedWorkMissing = -2147168463,
    BindValidityTimeViolated = -2147168488,
    BrokenCertChain = -2147168487,
    ClockRollbackDetected = -2147168491,
    CryptoOperationUnsupported = -2147168492,
    DebuggerDetected = -2147168416,
    EmailNotVerified = -2147168422,
    EnablingPrincipalFailure = -2147168496,
    EncryptionNotPermitted = -2147168508,
    EnvironmentCannotLoad = -2147168501,
    EnvironmentNotLoaded = -2147168502,
    ExpiredOfficialIssuanceLicenseTemplate = -2147168425,
    GlobalOptionAlreadySet = -2147168396,
    GroupIdentityNotSet = -2147168455,
    HidCorrupted = -2147168442,
    HidInvalid = -2147168423,
    IdMismatch = -2147168459,
    IncompatibleObjects = -2147168498,
    InfoNotInLicense = -2147168511,
    InfoNotPresent = -2147168495,
    InstallationFailed = -2147168443,
    InvalidAlgorithmType = -2147168503,
    InvalidClientLicensorCertificate = -2147168424,
    InvalidEmail = -2147168437,
    InvalidEncodingType = -2147168505,
    InvalidHandle = -2147168468,
    InvalidIssuanceLicenseTemplate = -2147168428,
    InvalidKeyLength = -2147168427,
    InvalidLicense = -2147168512,
    InvalidLicenseSignature = -2147168510,
    InvalidLockboxPath = -2147168399,
    InvalidLockboxType = -2147168400,
    InvalidNumericalValue = -2147168504,
    InvalidRegistryPath = -2147168398,
    InvalidServerResponse = -2147168441,
    InvalidTimeInfo = -2147168431,
    InvalidVersion = -2147168506,
    KeyTypeUnsupported = -2147168493,
    LibraryFail = -2147168497,
    LibraryUnsupportedPlugIn = -2147168474,
    LicenseAcquisitionFailed = -2147168460,
    LicenseBindingToWindowsIdentityFailed = -2147168429,
    ManifestPolicyViolation = -2147183860,
    MetadataNotSet = -2147168433,
    NeedsGroupIdentityActivation = -2147168450,
    NeedsMachineActivation = -2147168451,
    NoAesCryptoProvider = -2147168397,
    NoConnect = -2147168453,
    NoDistributionPointUrlFound = -2147168457,
    NoLicense = -2147168452,
    NoMoreData = -2147168461,
    NotAChain = -2147168418,
    NotSet = -2147168434,
    OutdatedModule = -2147168435,
    OutOfQuota = -2147168446,
    OwnerLicenseNotFound = -2147168395,
    QueryReportsNoResults = -2147168490,
    RecordNotFound = -2147168454,
    RequestDenied = -2147168417,
    RevocationInfoNotSet = -2147168432,
    RightNotGranted = -2147168507,
    RightNotSet = -2147168430,
    ServerError = -2147168444,
    ServerNotFound = -2147168438,
    ServiceGone = -2147168420,
    ServiceMoved = -2147168421,
    ServiceNotFound = -2147168440,
    Success = 0,
    TooManyCertificates = -2147168458,
    TooManyLoadedEnvironments = -2147168500,
    UnexpectedException = -2147168489,
    UseDefault = -2147168439,
    ValidityTimeViolation = -2147168436,
  }
  [System.Security.SecurityCriticalAttribute((System.Security.SecurityCriticalScope)(1))]
  public partial class SecureEnvironment : System.IDisposable {
    internal SecureEnvironment() { }
    public string ApplicationManifest { get { return default(string); } }
    public System.Security.RightsManagement.ContentUser User { get { return default(System.Security.RightsManagement.ContentUser); } }
    public static System.Security.RightsManagement.SecureEnvironment Create(string applicationManifest, System.Security.RightsManagement.AuthenticationType authentication, System.Security.RightsManagement.UserActivationMode userActivationMode) { return default(System.Security.RightsManagement.SecureEnvironment); }
    public static System.Security.RightsManagement.SecureEnvironment Create(string applicationManifest, System.Security.RightsManagement.ContentUser user) { return default(System.Security.RightsManagement.SecureEnvironment); }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public static System.Collections.ObjectModel.ReadOnlyCollection<System.Security.RightsManagement.ContentUser> GetActivatedUsers() { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Security.RightsManagement.ContentUser>); }
    public static bool IsUserActivated(System.Security.RightsManagement.ContentUser user) { return default(bool); }
    public static void RemoveActivatedUser(System.Security.RightsManagement.ContentUser user) { }
  }
  [System.Security.SecurityCriticalAttribute((System.Security.SecurityCriticalScope)(1))]
  public partial class UnsignedPublishLicense {
    public UnsignedPublishLicense() { }
    public UnsignedPublishLicense(string publishLicenseTemplate) { }
    public System.Guid ContentId { get { return default(System.Guid); } set { } }
    public System.Collections.Generic.ICollection<System.Security.RightsManagement.ContentGrant> Grants { get { return default(System.Collections.Generic.ICollection<System.Security.RightsManagement.ContentGrant>); } }
    public System.Collections.Generic.IDictionary<System.Int32, System.Security.RightsManagement.LocalizedNameDescriptionPair> LocalizedNameDescriptionDictionary { get { return default(System.Collections.Generic.IDictionary<System.Int32, System.Security.RightsManagement.LocalizedNameDescriptionPair>); } }
    public System.Security.RightsManagement.ContentUser Owner { get { return default(System.Security.RightsManagement.ContentUser); } set { } }
    public string ReferralInfoName { get { return default(string); } set { } }
    public System.Uri ReferralInfoUri { get { return default(System.Uri); } set { } }
    public System.Security.RightsManagement.PublishLicense Sign(System.Security.RightsManagement.SecureEnvironment secureEnvironment, out System.Security.RightsManagement.UseLicense authorUseLicense) { authorUseLicense = default(System.Security.RightsManagement.UseLicense); return default(System.Security.RightsManagement.PublishLicense); }
    public override string ToString() { return default(string); }
  }
  [System.Security.SecurityCriticalAttribute((System.Security.SecurityCriticalScope)(1))]
  public partial class UseLicense {
    public UseLicense(string useLicense) { }
    public System.Collections.Generic.IDictionary<System.String, System.String> ApplicationData { get { return default(System.Collections.Generic.IDictionary<System.String, System.String>); } }
    public System.Guid ContentId { get { return default(System.Guid); } }
    public System.Security.RightsManagement.ContentUser Owner { get { return default(System.Security.RightsManagement.ContentUser); } }
    public System.Security.RightsManagement.CryptoProvider Bind(System.Security.RightsManagement.SecureEnvironment secureEnvironment) { return default(System.Security.RightsManagement.CryptoProvider); }
    public override bool Equals(object x) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
  }
  public enum UserActivationMode {
    Permanent = 0,
    Temporary = 1,
  }
}
namespace System.Windows {
  public abstract partial class AttachedPropertyBrowsableAttribute : System.Attribute {
    protected AttachedPropertyBrowsableAttribute() { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=true)]
  public sealed partial class AttachedPropertyBrowsableForTypeAttribute : System.Windows.AttachedPropertyBrowsableAttribute {
    public AttachedPropertyBrowsableForTypeAttribute(System.Type targetType) { }
    public System.Type TargetType { get { return default(System.Type); } }
    public override object TypeId { get { return default(object); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=false)]
  public sealed partial class AttachedPropertyBrowsableWhenAttributePresentAttribute : System.Windows.AttachedPropertyBrowsableAttribute {
    public AttachedPropertyBrowsableWhenAttributePresentAttribute(System.Type attributeType) { }
    public System.Type AttributeType { get { return default(System.Type); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }
  public static partial class BaseCompatibilityPreferences {
    public static bool FlowDispatcherSynchronizationContextPriority { get { return default(bool); } set { } }
    public static bool InlineDispatcherSynchronizationContextSend { get { return default(bool); } set { } }
    public static bool ReuseDispatcherSynchronizationContextInstance { get { return default(bool); } set { } }
  }
  public delegate object CoerceValueCallback(System.Windows.DependencyObject d, object baseValue);
  [System.ComponentModel.TypeDescriptionProviderAttribute(typeof(MS.Internal.ComponentModel.DependencyObjectProvider))]
  [System.Windows.Markup.NameScopePropertyAttribute("NameScope", typeof(System.Windows.NameScope))]
  public partial class DependencyObject : System.Windows.Threading.DispatcherObject {
    public DependencyObject() { }
    public System.Windows.DependencyObjectType DependencyObjectType { get { return default(System.Windows.DependencyObjectType); } }
    public bool IsSealed { get { return default(bool); } }
    public void ClearValue(System.Windows.DependencyProperty dp) { }
    public void ClearValue(System.Windows.DependencyPropertyKey key) { }
    public void CoerceValue(System.Windows.DependencyProperty dp) { }
    public sealed override bool Equals(object obj) { return default(bool); }
    public sealed override int GetHashCode() { return default(int); }
    public System.Windows.LocalValueEnumerator GetLocalValueEnumerator() { return default(System.Windows.LocalValueEnumerator); }
    public object GetValue(System.Windows.DependencyProperty dp) { return default(object); }
    public void InvalidateProperty(System.Windows.DependencyProperty dp) { }
    protected virtual void OnPropertyChanged(System.Windows.DependencyPropertyChangedEventArgs e) { }
    public object ReadLocalValue(System.Windows.DependencyProperty dp) { return default(object); }
    public void SetCurrentValue(System.Windows.DependencyProperty dp, object value) { }
    public void SetValue(System.Windows.DependencyProperty dp, object value) { }
    public void SetValue(System.Windows.DependencyPropertyKey key, object value) { }
    protected internal virtual bool ShouldSerializeProperty(System.Windows.DependencyProperty dp) { return default(bool); }
  }
  public partial class DependencyObjectType {
    internal DependencyObjectType() { }
    public System.Windows.DependencyObjectType BaseType { get { return default(System.Windows.DependencyObjectType); } }
    public int Id { get { return default(int); } }
    public string Name { get { return default(string); } }
    public System.Type SystemType { get { return default(System.Type); } }
    public static System.Windows.DependencyObjectType FromSystemType(System.Type systemType) { return default(System.Windows.DependencyObjectType); }
    public override int GetHashCode() { return default(int); }
    public bool IsInstanceOfType(System.Windows.DependencyObject dependencyObject) { return default(bool); }
    public bool IsSubclassOf(System.Windows.DependencyObjectType dependencyObjectType) { return default(bool); }
  }
  [System.ComponentModel.TypeConverterAttribute("System.Windows.Markup.DependencyPropertyConverter, PresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35, Custom=null")]
  [System.Windows.Markup.ValueSerializerAttribute(typeof(System.Windows.DependencyPropertyValueSerializer))]
  public sealed partial class DependencyProperty {
    internal DependencyProperty() { }
    public static readonly object UnsetValue;
    public System.Windows.PropertyMetadata DefaultMetadata { get { return default(System.Windows.PropertyMetadata); } }
    public int GlobalIndex { get { return default(int); } }
    public string Name { get { return default(string); } }
    public System.Type OwnerType { get { return default(System.Type); } }
    public System.Type PropertyType { get { return default(System.Type); } }
    public bool ReadOnly { get { return default(bool); } }
    public System.Windows.ValidateValueCallback ValidateValueCallback { get { return default(System.Windows.ValidateValueCallback); } }
    public System.Windows.DependencyProperty AddOwner(System.Type ownerType) { return default(System.Windows.DependencyProperty); }
    public System.Windows.DependencyProperty AddOwner(System.Type ownerType, System.Windows.PropertyMetadata typeMetadata) { return default(System.Windows.DependencyProperty); }
    public override int GetHashCode() { return default(int); }
    public System.Windows.PropertyMetadata GetMetadata(System.Type forType) { return default(System.Windows.PropertyMetadata); }
    public System.Windows.PropertyMetadata GetMetadata(System.Windows.DependencyObject dependencyObject) { return default(System.Windows.PropertyMetadata); }
    public System.Windows.PropertyMetadata GetMetadata(System.Windows.DependencyObjectType dependencyObjectType) { return default(System.Windows.PropertyMetadata); }
    public bool IsValidType(object value) { return default(bool); }
    public bool IsValidValue(object value) { return default(bool); }
    public void OverrideMetadata(System.Type forType, System.Windows.PropertyMetadata typeMetadata) { }
    public void OverrideMetadata(System.Type forType, System.Windows.PropertyMetadata typeMetadata, System.Windows.DependencyPropertyKey key) { }
    public static System.Windows.DependencyProperty Register(string name, System.Type propertyType, System.Type ownerType) { return default(System.Windows.DependencyProperty); }
    public static System.Windows.DependencyProperty Register(string name, System.Type propertyType, System.Type ownerType, System.Windows.PropertyMetadata typeMetadata) { return default(System.Windows.DependencyProperty); }
    public static System.Windows.DependencyProperty Register(string name, System.Type propertyType, System.Type ownerType, System.Windows.PropertyMetadata typeMetadata, System.Windows.ValidateValueCallback validateValueCallback) { return default(System.Windows.DependencyProperty); }
    public static System.Windows.DependencyProperty RegisterAttached(string name, System.Type propertyType, System.Type ownerType) { return default(System.Windows.DependencyProperty); }
    public static System.Windows.DependencyProperty RegisterAttached(string name, System.Type propertyType, System.Type ownerType, System.Windows.PropertyMetadata defaultMetadata) { return default(System.Windows.DependencyProperty); }
    public static System.Windows.DependencyProperty RegisterAttached(string name, System.Type propertyType, System.Type ownerType, System.Windows.PropertyMetadata defaultMetadata, System.Windows.ValidateValueCallback validateValueCallback) { return default(System.Windows.DependencyProperty); }
    public static System.Windows.DependencyPropertyKey RegisterAttachedReadOnly(string name, System.Type propertyType, System.Type ownerType, System.Windows.PropertyMetadata defaultMetadata) { return default(System.Windows.DependencyPropertyKey); }
    public static System.Windows.DependencyPropertyKey RegisterAttachedReadOnly(string name, System.Type propertyType, System.Type ownerType, System.Windows.PropertyMetadata defaultMetadata, System.Windows.ValidateValueCallback validateValueCallback) { return default(System.Windows.DependencyPropertyKey); }
    public static System.Windows.DependencyPropertyKey RegisterReadOnly(string name, System.Type propertyType, System.Type ownerType, System.Windows.PropertyMetadata typeMetadata) { return default(System.Windows.DependencyPropertyKey); }
    public static System.Windows.DependencyPropertyKey RegisterReadOnly(string name, System.Type propertyType, System.Type ownerType, System.Windows.PropertyMetadata typeMetadata, System.Windows.ValidateValueCallback validateValueCallback) { return default(System.Windows.DependencyPropertyKey); }
    public override string ToString() { return default(string); }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct DependencyPropertyChangedEventArgs {
    public DependencyPropertyChangedEventArgs(System.Windows.DependencyProperty property, object oldValue, object newValue) { throw new System.NotImplementedException(); }
    public object NewValue { get { return default(object); } }
    public object OldValue { get { return default(object); } }
    public System.Windows.DependencyProperty Property { get { return default(System.Windows.DependencyProperty); } }
    public override bool Equals(object obj) { return default(bool); }
    public bool Equals(System.Windows.DependencyPropertyChangedEventArgs args) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Windows.DependencyPropertyChangedEventArgs left, System.Windows.DependencyPropertyChangedEventArgs right) { return default(bool); }
    public static bool operator !=(System.Windows.DependencyPropertyChangedEventArgs left, System.Windows.DependencyPropertyChangedEventArgs right) { return default(bool); }
  }
  public delegate void DependencyPropertyChangedEventHandler(object sender, System.Windows.DependencyPropertyChangedEventArgs e);
  public sealed partial class DependencyPropertyKey {
    internal DependencyPropertyKey() { }
    public System.Windows.DependencyProperty DependencyProperty { get { return default(System.Windows.DependencyProperty); } }
    public void OverrideMetadata(System.Type forType, System.Windows.PropertyMetadata typeMetadata) { }
  }
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.ExpressionConverter))]
  public partial class Expression {
    internal Expression() { }
  }
  public partial class ExpressionConverter : System.ComponentModel.TypeConverter {
    public ExpressionConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
  }
  public abstract partial class Freezable : System.Windows.DependencyObject {
    protected Freezable() { }
    public bool CanFreeze { get { return default(bool); } }
    public bool IsFrozen { get { return default(bool); } }
    public event System.EventHandler Changed { add { } remove { } }
    public System.Windows.Freezable Clone() { return default(System.Windows.Freezable); }
    protected virtual void CloneCore(System.Windows.Freezable sourceFreezable) { }
    public System.Windows.Freezable CloneCurrentValue() { return default(System.Windows.Freezable); }
    protected virtual void CloneCurrentValueCore(System.Windows.Freezable sourceFreezable) { }
    protected System.Windows.Freezable CreateInstance() { return default(System.Windows.Freezable); }
    protected abstract System.Windows.Freezable CreateInstanceCore();
    public void Freeze() { }
    protected internal static bool Freeze(System.Windows.Freezable freezable, bool isChecking) { return default(bool); }
    protected virtual bool FreezeCore(bool isChecking) { return default(bool); }
    public System.Windows.Freezable GetAsFrozen() { return default(System.Windows.Freezable); }
    protected virtual void GetAsFrozenCore(System.Windows.Freezable sourceFreezable) { }
    public System.Windows.Freezable GetCurrentValueAsFrozen() { return default(System.Windows.Freezable); }
    protected virtual void GetCurrentValueAsFrozenCore(System.Windows.Freezable sourceFreezable) { }
    protected virtual void OnChanged() { }
    protected void OnFreezablePropertyChanged(System.Windows.DependencyObject oldValue, System.Windows.DependencyObject newValue) { }
    protected void OnFreezablePropertyChanged(System.Windows.DependencyObject oldValue, System.Windows.DependencyObject newValue, System.Windows.DependencyProperty property) { }
    protected override void OnPropertyChanged(System.Windows.DependencyPropertyChangedEventArgs e) { }
    protected void ReadPreamble() { }
    protected void WritePostscript() { }
    protected void WritePreamble() { }
  }
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Int32RectConverter))]
  [System.Windows.Markup.ValueSerializerAttribute(typeof(System.Windows.Converters.Int32RectValueSerializer))]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Int32Rect : System.IFormattable {
    public Int32Rect(int x, int y, int width, int height) { throw new System.NotImplementedException(); }
    public static System.Windows.Int32Rect Empty { get { return default(System.Windows.Int32Rect); } }
    public bool HasArea { get { return default(bool); } }
    public int Height { get { return default(int); } set { } }
    public bool IsEmpty { get { return default(bool); } }
    public int Width { get { return default(int); } set { } }
    public int X { get { return default(int); } set { } }
    public int Y { get { return default(int); } set { } }
    public override bool Equals(object o) { return default(bool); }
    public bool Equals(System.Windows.Int32Rect value) { return default(bool); }
    public static bool Equals(System.Windows.Int32Rect int32Rect1, System.Windows.Int32Rect int32Rect2) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Windows.Int32Rect int32Rect1, System.Windows.Int32Rect int32Rect2) { return default(bool); }
    public static bool operator !=(System.Windows.Int32Rect int32Rect1, System.Windows.Int32Rect int32Rect2) { return default(bool); }
    public static System.Windows.Int32Rect Parse(string source) { return default(System.Windows.Int32Rect); }
    string System.IFormattable.ToString(string format, System.IFormatProvider provider) { return default(string); }
    public override string ToString() { return default(string); }
    public string ToString(System.IFormatProvider provider) { return default(string); }
  }
  public sealed partial class Int32RectConverter : System.ComponentModel.TypeConverter {
    public Int32RectConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
  }
  public partial interface IWeakEventListener {
    bool ReceiveWeakEvent(System.Type managerType, object sender, System.EventArgs e);
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct LocalValueEntry {
    public System.Windows.DependencyProperty Property { get { return default(System.Windows.DependencyProperty); } }
    public object Value { get { return default(object); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Windows.LocalValueEntry obj1, System.Windows.LocalValueEntry obj2) { return default(bool); }
    public static bool operator !=(System.Windows.LocalValueEntry obj1, System.Windows.LocalValueEntry obj2) { return default(bool); }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct LocalValueEnumerator : System.Collections.IEnumerator {
    public int Count { get { return default(int); } }
    public System.Windows.LocalValueEntry Current { get { return default(System.Windows.LocalValueEntry); } }
    object System.Collections.IEnumerator.Current { get { return default(object); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public bool MoveNext() { return default(bool); }
    public static bool operator ==(System.Windows.LocalValueEnumerator obj1, System.Windows.LocalValueEnumerator obj2) { return default(bool); }
    public static bool operator !=(System.Windows.LocalValueEnumerator obj1, System.Windows.LocalValueEnumerator obj2) { return default(bool); }
    public void Reset() { }
  }
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("PresentationFramework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  public partial class NameScope : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String, System.Object>>, System.Collections.Generic.IDictionary<System.String, System.Object>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>, System.Collections.IEnumerable, System.Windows.Markup.INameScope, System.Windows.Markup.INameScopeDictionary {
    public static readonly System.Windows.DependencyProperty NameScopeProperty;
    public NameScope() { }
    public int Count { get { return default(int); } }
    public bool IsReadOnly { get { return default(bool); } }
    public object this[string key] { get { return default(object); } set { } }
    public System.Collections.Generic.ICollection<System.String> Keys { get { return default(System.Collections.Generic.ICollection<System.String>); } }
    public System.Collections.Generic.ICollection<System.Object> Values { get { return default(System.Collections.Generic.ICollection<System.Object>); } }
    public void Add(System.Collections.Generic.KeyValuePair<System.String, System.Object> item) { }
    public void Add(string key, object value) { }
    public void Clear() { }
    public bool Contains(System.Collections.Generic.KeyValuePair<System.String, System.Object> item) { return default(bool); }
    public bool ContainsKey(string key) { return default(bool); }
    public void CopyTo(System.Collections.Generic.KeyValuePair<System.String, System.Object>[] array, int arrayIndex) { }
    public object FindName(string name) { return default(object); }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public static System.Windows.Markup.INameScope GetNameScope(System.Windows.DependencyObject dependencyObject) { return default(System.Windows.Markup.INameScope); }
    public void RegisterName(string name, object scopedElement) { }
    public bool Remove(System.Collections.Generic.KeyValuePair<System.String, System.Object> item) { return default(bool); }
    public bool Remove(string key) { return default(bool); }
    public static void SetNameScope(System.Windows.DependencyObject dependencyObject, System.Windows.Markup.INameScope value) { }
    System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String, System.Object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String, System.Object>>); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    public bool TryGetValue(string key, out object value) { value = default(object); return default(bool); }
    public void UnregisterName(string name) { }
  }
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.PointConverter))]
  [System.Windows.Markup.ValueSerializerAttribute(typeof(System.Windows.Converters.PointValueSerializer))]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Point : System.IFormattable {
    public Point(double x, double y) { throw new System.NotImplementedException(); }
    public double X { get { return default(double); } set { } }
    public double Y { get { return default(double); } set { } }
    public static System.Windows.Point Add(System.Windows.Point point, System.Windows.Vector vector) { return default(System.Windows.Point); }
    public override bool Equals(object o) { return default(bool); }
    public bool Equals(System.Windows.Point value) { return default(bool); }
    public static bool Equals(System.Windows.Point point1, System.Windows.Point point2) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static System.Windows.Point Multiply(System.Windows.Point point, System.Windows.Media.Matrix matrix) { return default(System.Windows.Point); }
    public void Offset(double offsetX, double offsetY) { }
    public static System.Windows.Point operator +(System.Windows.Point point, System.Windows.Vector vector) { return default(System.Windows.Point); }
    public static bool operator ==(System.Windows.Point point1, System.Windows.Point point2) { return default(bool); }
    public static explicit operator System.Windows.Size (System.Windows.Point point) { return default(System.Windows.Size); }
    public static explicit operator System.Windows.Vector (System.Windows.Point point) { return default(System.Windows.Vector); }
    public static bool operator !=(System.Windows.Point point1, System.Windows.Point point2) { return default(bool); }
    public static System.Windows.Point operator *(System.Windows.Point point, System.Windows.Media.Matrix matrix) { return default(System.Windows.Point); }
    public static System.Windows.Vector operator -(System.Windows.Point point1, System.Windows.Point point2) { return default(System.Windows.Vector); }
    public static System.Windows.Point operator -(System.Windows.Point point, System.Windows.Vector vector) { return default(System.Windows.Point); }
    public static System.Windows.Point Parse(string source) { return default(System.Windows.Point); }
    public static System.Windows.Vector Subtract(System.Windows.Point point1, System.Windows.Point point2) { return default(System.Windows.Vector); }
    public static System.Windows.Point Subtract(System.Windows.Point point, System.Windows.Vector vector) { return default(System.Windows.Point); }
    string System.IFormattable.ToString(string format, System.IFormatProvider provider) { return default(string); }
    public override string ToString() { return default(string); }
    public string ToString(System.IFormatProvider provider) { return default(string); }
  }
  public sealed partial class PointConverter : System.ComponentModel.TypeConverter {
    public PointConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
  }
  public delegate void PropertyChangedCallback(System.Windows.DependencyObject d, System.Windows.DependencyPropertyChangedEventArgs e);
  public partial class PropertyMetadata {
    public PropertyMetadata() { }
    public PropertyMetadata(object defaultValue) { }
    public PropertyMetadata(object defaultValue, System.Windows.PropertyChangedCallback propertyChangedCallback) { }
    public PropertyMetadata(object defaultValue, System.Windows.PropertyChangedCallback propertyChangedCallback, System.Windows.CoerceValueCallback coerceValueCallback) { }
    public PropertyMetadata(System.Windows.PropertyChangedCallback propertyChangedCallback) { }
    public System.Windows.CoerceValueCallback CoerceValueCallback { get { return default(System.Windows.CoerceValueCallback); } set { } }
    public object DefaultValue { get { return default(object); } set { } }
    protected bool IsSealed { get { return default(bool); } }
    public System.Windows.PropertyChangedCallback PropertyChangedCallback { get { return default(System.Windows.PropertyChangedCallback); } set { } }
    protected virtual void Merge(System.Windows.PropertyMetadata baseMetadata, System.Windows.DependencyProperty dp) { }
    protected virtual void OnApply(System.Windows.DependencyProperty dp, System.Type targetType) { }
  }
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.RectConverter))]
  [System.Windows.Markup.ValueSerializerAttribute(typeof(System.Windows.Converters.RectValueSerializer))]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Rect : System.IFormattable {
    public Rect(double x, double y, double width, double height) { throw new System.NotImplementedException(); }
    public Rect(System.Windows.Point point1, System.Windows.Point point2) { throw new System.NotImplementedException(); }
    public Rect(System.Windows.Point location, System.Windows.Size size) { throw new System.NotImplementedException(); }
    public Rect(System.Windows.Point point, System.Windows.Vector vector) { throw new System.NotImplementedException(); }
    public Rect(System.Windows.Size size) { throw new System.NotImplementedException(); }
    public double Bottom { get { return default(double); } }
    public System.Windows.Point BottomLeft { get { return default(System.Windows.Point); } }
    public System.Windows.Point BottomRight { get { return default(System.Windows.Point); } }
    public static System.Windows.Rect Empty { get { return default(System.Windows.Rect); } }
    public double Height { get { return default(double); } set { } }
    public bool IsEmpty { get { return default(bool); } }
    public double Left { get { return default(double); } }
    public System.Windows.Point Location { get { return default(System.Windows.Point); } set { } }
    public double Right { get { return default(double); } }
    public System.Windows.Size Size { get { return default(System.Windows.Size); } set { } }
    public double Top { get { return default(double); } }
    public System.Windows.Point TopLeft { get { return default(System.Windows.Point); } }
    public System.Windows.Point TopRight { get { return default(System.Windows.Point); } }
    public double Width { get { return default(double); } set { } }
    public double X { get { return default(double); } set { } }
    public double Y { get { return default(double); } set { } }
    public bool Contains(double x, double y) { return default(bool); }
    public bool Contains(System.Windows.Point point) { return default(bool); }
    public bool Contains(System.Windows.Rect rect) { return default(bool); }
    public override bool Equals(object o) { return default(bool); }
    public bool Equals(System.Windows.Rect value) { return default(bool); }
    public static bool Equals(System.Windows.Rect rect1, System.Windows.Rect rect2) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public void Inflate(double width, double height) { }
    public static System.Windows.Rect Inflate(System.Windows.Rect rect, double width, double height) { return default(System.Windows.Rect); }
    public static System.Windows.Rect Inflate(System.Windows.Rect rect, System.Windows.Size size) { return default(System.Windows.Rect); }
    public void Inflate(System.Windows.Size size) { }
    public void Intersect(System.Windows.Rect rect) { }
    public static System.Windows.Rect Intersect(System.Windows.Rect rect1, System.Windows.Rect rect2) { return default(System.Windows.Rect); }
    public bool IntersectsWith(System.Windows.Rect rect) { return default(bool); }
    public void Offset(double offsetX, double offsetY) { }
    public static System.Windows.Rect Offset(System.Windows.Rect rect, double offsetX, double offsetY) { return default(System.Windows.Rect); }
    public static System.Windows.Rect Offset(System.Windows.Rect rect, System.Windows.Vector offsetVector) { return default(System.Windows.Rect); }
    public void Offset(System.Windows.Vector offsetVector) { }
    public static bool operator ==(System.Windows.Rect rect1, System.Windows.Rect rect2) { return default(bool); }
    public static bool operator !=(System.Windows.Rect rect1, System.Windows.Rect rect2) { return default(bool); }
    public static System.Windows.Rect Parse(string source) { return default(System.Windows.Rect); }
    public void Scale(double scaleX, double scaleY) { }
    string System.IFormattable.ToString(string format, System.IFormatProvider provider) { return default(string); }
    public override string ToString() { return default(string); }
    public string ToString(System.IFormatProvider provider) { return default(string); }
    public void Transform(System.Windows.Media.Matrix matrix) { }
    public static System.Windows.Rect Transform(System.Windows.Rect rect, System.Windows.Media.Matrix matrix) { return default(System.Windows.Rect); }
    public void Union(System.Windows.Point point) { }
    public void Union(System.Windows.Rect rect) { }
    public static System.Windows.Rect Union(System.Windows.Rect rect, System.Windows.Point point) { return default(System.Windows.Rect); }
    public static System.Windows.Rect Union(System.Windows.Rect rect1, System.Windows.Rect rect2) { return default(System.Windows.Rect); }
  }
  public sealed partial class RectConverter : System.ComponentModel.TypeConverter {
    public RectConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
  }
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.SizeConverter))]
  [System.Windows.Markup.ValueSerializerAttribute(typeof(System.Windows.Converters.SizeValueSerializer))]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Size : System.IFormattable {
    public Size(double width, double height) { throw new System.NotImplementedException(); }
    public static System.Windows.Size Empty { get { return default(System.Windows.Size); } }
    public double Height { get { return default(double); } set { } }
    public bool IsEmpty { get { return default(bool); } }
    public double Width { get { return default(double); } set { } }
    public override bool Equals(object o) { return default(bool); }
    public bool Equals(System.Windows.Size value) { return default(bool); }
    public static bool Equals(System.Windows.Size size1, System.Windows.Size size2) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Windows.Size size1, System.Windows.Size size2) { return default(bool); }
    public static explicit operator System.Windows.Point (System.Windows.Size size) { return default(System.Windows.Point); }
    public static explicit operator System.Windows.Vector (System.Windows.Size size) { return default(System.Windows.Vector); }
    public static bool operator !=(System.Windows.Size size1, System.Windows.Size size2) { return default(bool); }
    public static System.Windows.Size Parse(string source) { return default(System.Windows.Size); }
    string System.IFormattable.ToString(string format, System.IFormatProvider provider) { return default(string); }
    public override string ToString() { return default(string); }
    public string ToString(System.IFormatProvider provider) { return default(string); }
  }
  public sealed partial class SizeConverter : System.ComponentModel.TypeConverter {
    public SizeConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
  }
  [System.Security.SecurityCriticalAttribute((System.Security.SecurityCriticalScope)(1))]
  [System.Security.Permissions.UIPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Window=(System.Security.Permissions.UIPermissionWindow)(3))]
  public partial class SplashScreen {
    [System.Security.SecurityCriticalAttribute]
    public SplashScreen(System.Reflection.Assembly resourceAssembly, string resourceName) { }
    [System.Security.SecurityCriticalAttribute]
    public SplashScreen(string resourceName) { }
    [System.Security.SecurityCriticalAttribute]
    public void Close(System.TimeSpan fadeoutDuration) { }
    [System.Security.SecurityCriticalAttribute]
    public void Show(bool autoClose) { }
    [System.Security.SecurityCriticalAttribute]
    public void Show(bool autoClose, bool topMost) { }
  }
  public delegate bool ValidateValueCallback(object value);
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.VectorConverter))]
  [System.Windows.Markup.ValueSerializerAttribute(typeof(System.Windows.Converters.VectorValueSerializer))]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Vector : System.IFormattable {
    public Vector(double x, double y) { throw new System.NotImplementedException(); }
    public double Length { get { return default(double); } }
    public double LengthSquared { get { return default(double); } }
    public double X { get { return default(double); } set { } }
    public double Y { get { return default(double); } set { } }
    public static System.Windows.Point Add(System.Windows.Vector vector, System.Windows.Point point) { return default(System.Windows.Point); }
    public static System.Windows.Vector Add(System.Windows.Vector vector1, System.Windows.Vector vector2) { return default(System.Windows.Vector); }
    public static double AngleBetween(System.Windows.Vector vector1, System.Windows.Vector vector2) { return default(double); }
    public static double CrossProduct(System.Windows.Vector vector1, System.Windows.Vector vector2) { return default(double); }
    public static double Determinant(System.Windows.Vector vector1, System.Windows.Vector vector2) { return default(double); }
    public static System.Windows.Vector Divide(System.Windows.Vector vector, double scalar) { return default(System.Windows.Vector); }
    public override bool Equals(object o) { return default(bool); }
    public bool Equals(System.Windows.Vector value) { return default(bool); }
    public static bool Equals(System.Windows.Vector vector1, System.Windows.Vector vector2) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static System.Windows.Vector Multiply(double scalar, System.Windows.Vector vector) { return default(System.Windows.Vector); }
    public static System.Windows.Vector Multiply(System.Windows.Vector vector, double scalar) { return default(System.Windows.Vector); }
    public static System.Windows.Vector Multiply(System.Windows.Vector vector, System.Windows.Media.Matrix matrix) { return default(System.Windows.Vector); }
    public static double Multiply(System.Windows.Vector vector1, System.Windows.Vector vector2) { return default(double); }
    public void Negate() { }
    public void Normalize() { }
    public static System.Windows.Point operator +(System.Windows.Vector vector, System.Windows.Point point) { return default(System.Windows.Point); }
    public static System.Windows.Vector operator +(System.Windows.Vector vector1, System.Windows.Vector vector2) { return default(System.Windows.Vector); }
    public static System.Windows.Vector operator /(System.Windows.Vector vector, double scalar) { return default(System.Windows.Vector); }
    public static bool operator ==(System.Windows.Vector vector1, System.Windows.Vector vector2) { return default(bool); }
    public static explicit operator System.Windows.Point (System.Windows.Vector vector) { return default(System.Windows.Point); }
    public static explicit operator System.Windows.Size (System.Windows.Vector vector) { return default(System.Windows.Size); }
    public static bool operator !=(System.Windows.Vector vector1, System.Windows.Vector vector2) { return default(bool); }
    public static System.Windows.Vector operator *(double scalar, System.Windows.Vector vector) { return default(System.Windows.Vector); }
    public static System.Windows.Vector operator *(System.Windows.Vector vector, double scalar) { return default(System.Windows.Vector); }
    public static System.Windows.Vector operator *(System.Windows.Vector vector, System.Windows.Media.Matrix matrix) { return default(System.Windows.Vector); }
    public static double operator *(System.Windows.Vector vector1, System.Windows.Vector vector2) { return default(double); }
    public static System.Windows.Vector operator -(System.Windows.Vector vector1, System.Windows.Vector vector2) { return default(System.Windows.Vector); }
    public static System.Windows.Vector operator -(System.Windows.Vector vector) { return default(System.Windows.Vector); }
    public static System.Windows.Vector Parse(string source) { return default(System.Windows.Vector); }
    public static System.Windows.Vector Subtract(System.Windows.Vector vector1, System.Windows.Vector vector2) { return default(System.Windows.Vector); }
    string System.IFormattable.ToString(string format, System.IFormatProvider provider) { return default(string); }
    public override string ToString() { return default(string); }
    public string ToString(System.IFormatProvider provider) { return default(string); }
  }
  public sealed partial class VectorConverter : System.ComponentModel.TypeConverter {
    public VectorConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
  }
  public abstract partial class WeakEventManager : System.Windows.Threading.DispatcherObject {
    protected WeakEventManager() { }
    protected object this[object source] { get { return default(object); } set { } }
    protected System.IDisposable ReadLock { get { return default(System.IDisposable); } }
    protected System.IDisposable WriteLock { get { return default(System.IDisposable); } }
    protected void DeliverEvent(object sender, System.EventArgs args) { }
    protected void DeliverEventToList(object sender, System.EventArgs args, System.Windows.WeakEventManager.ListenerList list) { }
    protected static System.Windows.WeakEventManager GetCurrentManager(System.Type managerType) { return default(System.Windows.WeakEventManager); }
    protected virtual System.Windows.WeakEventManager.ListenerList NewListenerList() { return default(System.Windows.WeakEventManager.ListenerList); }
    protected void ProtectedAddHandler(object source, System.Delegate handler) { }
    protected void ProtectedAddListener(object source, System.Windows.IWeakEventListener listener) { }
    protected void ProtectedRemoveHandler(object source, System.Delegate handler) { }
    protected void ProtectedRemoveListener(object source, System.Windows.IWeakEventListener listener) { }
    protected virtual bool Purge(object source, object data, bool purgeAll) { return default(bool); }
    protected void Remove(object source) { }
    protected void ScheduleCleanup() { }
    protected static void SetCurrentManager(System.Type managerType, System.Windows.WeakEventManager manager) { }
    protected abstract void StartListening(object source);
    protected abstract void StopListening(object source);
    protected partial class ListenerList {
      public ListenerList() { }
      public ListenerList(int capacity) { }
      public int Count { get { return default(int); } }
      public static System.Windows.WeakEventManager.ListenerList Empty { get { return default(System.Windows.WeakEventManager.ListenerList); } }
      public bool IsEmpty { get { return default(bool); } }
      public System.Windows.IWeakEventListener this[int index] { get { return default(System.Windows.IWeakEventListener); } }
      public void Add(System.Windows.IWeakEventListener listener) { }
      public void AddHandler(System.Delegate handler) { }
      public bool BeginUse() { return default(bool); }
      public virtual System.Windows.WeakEventManager.ListenerList Clone() { return default(System.Windows.WeakEventManager.ListenerList); }
      protected void CopyTo(System.Windows.WeakEventManager.ListenerList newList) { }
      public virtual bool DeliverEvent(object sender, System.EventArgs args, System.Type managerType) { return default(bool); }
      public void EndUse() { }
      public static bool PrepareForWriting(ref System.Windows.WeakEventManager.ListenerList list) { return default(bool); }
      public bool Purge() { return default(bool); }
      public void Remove(System.Windows.IWeakEventListener listener) { }
      public void RemoveHandler(System.Delegate handler) { }
    }
    protected partial class ListenerList<TEventArgs> : System.Windows.WeakEventManager.ListenerList where TEventArgs : System.EventArgs {
      public ListenerList() { }
      public ListenerList(int capacity) { }
      public override System.Windows.WeakEventManager.ListenerList Clone() { return default(System.Windows.WeakEventManager.ListenerList); }
      public override bool DeliverEvent(object sender, System.EventArgs e, System.Type managerType) { return default(bool); }
    }
  }
  public partial class WeakEventManager<TEventSource, TEventArgs> : System.Windows.WeakEventManager where TEventArgs : System.EventArgs {
    internal WeakEventManager() { }
    public static void AddHandler(TEventSource source, string eventName, System.EventHandler<TEventArgs> handler) { }
    protected override System.Windows.WeakEventManager.ListenerList NewListenerList() { return default(System.Windows.WeakEventManager.ListenerList); }
    public static void RemoveHandler(TEventSource source, string eventName, System.EventHandler<TEventArgs> handler) { }
    protected override void StartListening(object source) { }
    protected override void StopListening(object source) { }
  }
}
namespace System.Windows.Converters {
  public partial class Int32RectValueSerializer : System.Windows.Markup.ValueSerializer {
    public Int32RectValueSerializer() { }
    public override bool CanConvertFromString(string value, System.Windows.Markup.IValueSerializerContext context) { return default(bool); }
    public override bool CanConvertToString(object value, System.Windows.Markup.IValueSerializerContext context) { return default(bool); }
    public override object ConvertFromString(string value, System.Windows.Markup.IValueSerializerContext context) { return default(object); }
    public override string ConvertToString(object value, System.Windows.Markup.IValueSerializerContext context) { return default(string); }
  }
  public partial class PointValueSerializer : System.Windows.Markup.ValueSerializer {
    public PointValueSerializer() { }
    public override bool CanConvertFromString(string value, System.Windows.Markup.IValueSerializerContext context) { return default(bool); }
    public override bool CanConvertToString(object value, System.Windows.Markup.IValueSerializerContext context) { return default(bool); }
    public override object ConvertFromString(string value, System.Windows.Markup.IValueSerializerContext context) { return default(object); }
    public override string ConvertToString(object value, System.Windows.Markup.IValueSerializerContext context) { return default(string); }
  }
  public partial class RectValueSerializer : System.Windows.Markup.ValueSerializer {
    public RectValueSerializer() { }
    public override bool CanConvertFromString(string value, System.Windows.Markup.IValueSerializerContext context) { return default(bool); }
    public override bool CanConvertToString(object value, System.Windows.Markup.IValueSerializerContext context) { return default(bool); }
    public override object ConvertFromString(string value, System.Windows.Markup.IValueSerializerContext context) { return default(object); }
    public override string ConvertToString(object value, System.Windows.Markup.IValueSerializerContext context) { return default(string); }
  }
  public partial class SizeValueSerializer : System.Windows.Markup.ValueSerializer {
    public SizeValueSerializer() { }
    public override bool CanConvertFromString(string value, System.Windows.Markup.IValueSerializerContext context) { return default(bool); }
    public override bool CanConvertToString(object value, System.Windows.Markup.IValueSerializerContext context) { return default(bool); }
    public override object ConvertFromString(string value, System.Windows.Markup.IValueSerializerContext context) { return default(object); }
    public override string ConvertToString(object value, System.Windows.Markup.IValueSerializerContext context) { return default(string); }
  }
  public partial class VectorValueSerializer : System.Windows.Markup.ValueSerializer {
    public VectorValueSerializer() { }
    public override bool CanConvertFromString(string value, System.Windows.Markup.IValueSerializerContext context) { return default(bool); }
    public override bool CanConvertToString(object value, System.Windows.Markup.IValueSerializerContext context) { return default(bool); }
    public override object ConvertFromString(string value, System.Windows.Markup.IValueSerializerContext context) { return default(object); }
    public override string ConvertToString(object value, System.Windows.Markup.IValueSerializerContext context) { return default(string); }
  }
}
namespace System.Windows.Data {
  public abstract partial class DataSourceProvider : System.ComponentModel.INotifyPropertyChanged, System.ComponentModel.ISupportInitialize {
    protected DataSourceProvider() { }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public object Data { get { return default(object); } }
    protected System.Windows.Threading.Dispatcher Dispatcher { get { return default(System.Windows.Threading.Dispatcher); } set { } }
    public System.Exception Error { get { return default(System.Exception); } }
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool IsInitialLoadEnabled { get { return default(bool); } set { } }
    protected bool IsRefreshDeferred { get { return default(bool); } }
    public event System.EventHandler DataChanged { add { } remove { } }
    protected virtual event System.ComponentModel.PropertyChangedEventHandler PropertyChanged { add { } remove { } }
    event System.ComponentModel.PropertyChangedEventHandler System.ComponentModel.INotifyPropertyChanged.PropertyChanged { add { } remove { } }
    protected virtual void BeginInit() { }
    protected virtual void BeginQuery() { }
    public virtual System.IDisposable DeferRefresh() { return default(System.IDisposable); }
    protected virtual void EndInit() { }
    public void InitialLoad() { }
    protected virtual void OnPropertyChanged(System.ComponentModel.PropertyChangedEventArgs e) { }
    protected void OnQueryFinished(object newData) { }
    protected virtual void OnQueryFinished(object newData, System.Exception error, System.Windows.Threading.DispatcherOperationCallback completionWork, object callbackArguments) { }
    public void Refresh() { }
    void System.ComponentModel.ISupportInitialize.BeginInit() { }
    void System.ComponentModel.ISupportInitialize.EndInit() { }
  }
}
namespace System.Windows.Input {
  public enum FocusNavigationDirection {
    Down = 7,
    First = 2,
    Last = 3,
    Left = 4,
    Next = 0,
    Previous = 1,
    Right = 5,
    Up = 6,
  }
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Input.KeyConverter))]
  [System.Windows.Markup.ValueSerializerAttribute(typeof(System.Windows.Input.KeyValueSerializer))]
  public enum Key {
    A = 44,
    AbntC1 = 147,
    AbntC2 = 148,
    Add = 85,
    Apps = 72,
    Attn = 163,
    B = 45,
    Back = 2,
    BrowserBack = 122,
    BrowserFavorites = 127,
    BrowserForward = 123,
    BrowserHome = 128,
    BrowserRefresh = 124,
    BrowserSearch = 126,
    BrowserStop = 125,
    C = 46,
    Cancel = 1,
    Capital = 8,
    CapsLock = 8,
    Clear = 5,
    CrSel = 164,
    D = 47,
    D0 = 34,
    D1 = 35,
    D2 = 36,
    D3 = 37,
    D4 = 38,
    D5 = 39,
    D6 = 40,
    D7 = 41,
    D8 = 42,
    D9 = 43,
    DbeAlphanumeric = 157,
    DbeCodeInput = 167,
    DbeDbcsChar = 161,
    DbeDetermineString = 169,
    DbeEnterDialogConversionMode = 170,
    DbeEnterImeConfigureMode = 165,
    DbeEnterWordRegisterMode = 164,
    DbeFlushString = 166,
    DbeHiragana = 159,
    DbeKatakana = 158,
    DbeNoCodeInput = 168,
    DbeNoRoman = 163,
    DbeRoman = 162,
    DbeSbcsChar = 160,
    DeadCharProcessed = 172,
    Decimal = 88,
    Delete = 32,
    Divide = 89,
    Down = 26,
    E = 48,
    End = 21,
    Enter = 6,
    EraseEof = 166,
    Escape = 13,
    Execute = 29,
    ExSel = 165,
    F = 49,
    F1 = 90,
    F10 = 99,
    F11 = 100,
    F12 = 101,
    F13 = 102,
    F14 = 103,
    F15 = 104,
    F16 = 105,
    F17 = 106,
    F18 = 107,
    F19 = 108,
    F2 = 91,
    F20 = 109,
    F21 = 110,
    F22 = 111,
    F23 = 112,
    F24 = 113,
    F3 = 92,
    F4 = 93,
    F5 = 94,
    F6 = 95,
    F7 = 96,
    F8 = 97,
    F9 = 98,
    FinalMode = 11,
    G = 50,
    H = 51,
    HangulMode = 9,
    HanjaMode = 12,
    Help = 33,
    Home = 22,
    I = 52,
    ImeAccept = 16,
    ImeConvert = 14,
    ImeModeChange = 17,
    ImeNonConvert = 15,
    ImeProcessed = 155,
    Insert = 31,
    J = 53,
    JunjaMode = 10,
    K = 54,
    KanaMode = 9,
    KanjiMode = 12,
    L = 55,
    LaunchApplication1 = 138,
    LaunchApplication2 = 139,
    LaunchMail = 136,
    Left = 23,
    LeftAlt = 120,
    LeftCtrl = 118,
    LeftShift = 116,
    LineFeed = 4,
    LWin = 70,
    M = 56,
    MediaNextTrack = 132,
    MediaPlayPause = 135,
    MediaPreviousTrack = 133,
    MediaStop = 134,
    Multiply = 84,
    N = 57,
    Next = 20,
    NoName = 169,
    None = 0,
    NumLock = 114,
    NumPad0 = 74,
    NumPad1 = 75,
    NumPad2 = 76,
    NumPad3 = 77,
    NumPad4 = 78,
    NumPad5 = 79,
    NumPad6 = 80,
    NumPad7 = 81,
    NumPad8 = 82,
    NumPad9 = 83,
    O = 58,
    Oem1 = 140,
    Oem102 = 154,
    Oem2 = 145,
    Oem3 = 146,
    Oem4 = 149,
    Oem5 = 150,
    Oem6 = 151,
    Oem7 = 152,
    Oem8 = 153,
    OemAttn = 157,
    OemAuto = 160,
    OemBackslash = 154,
    OemBackTab = 162,
    OemClear = 171,
    OemCloseBrackets = 151,
    OemComma = 142,
    OemCopy = 159,
    OemEnlw = 161,
    OemFinish = 158,
    OemMinus = 143,
    OemOpenBrackets = 149,
    OemPeriod = 144,
    OemPipe = 150,
    OemPlus = 141,
    OemQuestion = 145,
    OemQuotes = 152,
    OemSemicolon = 140,
    OemTilde = 146,
    P = 59,
    Pa1 = 170,
    PageDown = 20,
    PageUp = 19,
    Pause = 7,
    Play = 167,
    Print = 28,
    PrintScreen = 30,
    Prior = 19,
    Q = 60,
    R = 61,
    Return = 6,
    Right = 25,
    RightAlt = 121,
    RightCtrl = 119,
    RightShift = 117,
    RWin = 71,
    S = 62,
    Scroll = 115,
    Select = 27,
    SelectMedia = 137,
    Separator = 86,
    Sleep = 73,
    Snapshot = 30,
    Space = 18,
    Subtract = 87,
    System = 156,
    T = 63,
    Tab = 3,
    U = 64,
    Up = 24,
    V = 65,
    VolumeDown = 130,
    VolumeMute = 129,
    VolumeUp = 131,
    W = 66,
    X = 67,
    Y = 68,
    Z = 69,
    Zoom = 168,
  }
  public partial class KeyConverter : System.ComponentModel.TypeConverter {
    public KeyConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object source) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
  }
  public static partial class KeyInterop {
    public static System.Windows.Input.Key KeyFromVirtualKey(int virtualKey) { return default(System.Windows.Input.Key); }
    public static int VirtualKeyFromKey(System.Windows.Input.Key key) { return default(int); }
  }
  public partial class KeyValueSerializer : System.Windows.Markup.ValueSerializer {
    public KeyValueSerializer() { }
    public override bool CanConvertFromString(string value, System.Windows.Markup.IValueSerializerContext context) { return default(bool); }
    public override bool CanConvertToString(object value, System.Windows.Markup.IValueSerializerContext context) { return default(bool); }
    public override object ConvertFromString(string value, System.Windows.Markup.IValueSerializerContext context) { return default(object); }
    public override string ConvertToString(object value, System.Windows.Markup.IValueSerializerContext context) { return default(string); }
  }
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Input.ModifierKeysConverter))]
  [System.FlagsAttribute]
  [System.Windows.Markup.ValueSerializerAttribute(typeof(System.Windows.Input.ModifierKeysValueSerializer))]
  public enum ModifierKeys {
    Alt = 1,
    Control = 2,
    None = 0,
    Shift = 4,
    Windows = 8,
  }
  public partial class ModifierKeysConverter : System.ComponentModel.TypeConverter {
    public ModifierKeysConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object source) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
    public static bool IsDefinedModifierKeys(System.Windows.Input.ModifierKeys modifierKeys) { return default(bool); }
  }
  public partial class ModifierKeysValueSerializer : System.Windows.Markup.ValueSerializer {
    public ModifierKeysValueSerializer() { }
    public override bool CanConvertFromString(string value, System.Windows.Markup.IValueSerializerContext context) { return default(bool); }
    public override bool CanConvertToString(object value, System.Windows.Markup.IValueSerializerContext context) { return default(bool); }
    public override object ConvertFromString(string value, System.Windows.Markup.IValueSerializerContext context) { return default(object); }
    public override string ConvertToString(object value, System.Windows.Markup.IValueSerializerContext context) { return default(string); }
  }
  public partial class TraversalRequest {
    public TraversalRequest(System.Windows.Input.FocusNavigationDirection focusNavigationDirection) { }
    public System.Windows.Input.FocusNavigationDirection FocusNavigationDirection { get { return default(System.Windows.Input.FocusNavigationDirection); } }
    public bool Wrapped { get { return default(bool); } set { } }
  }
}
namespace System.Windows.Interop {
  public static partial class ComponentDispatcher {
    public static System.Windows.Interop.MSG CurrentKeyboardMessage { [System.Security.SecurityCriticalAttribute]get { return default(System.Windows.Interop.MSG); } }
    public static bool IsThreadModal { [System.Security.SecurityCriticalAttribute]get { return default(bool); } }
    public static event System.EventHandler EnterThreadModal { add { } remove { } }
    public static event System.EventHandler LeaveThreadModal { add { } remove { } }
    public static event System.Windows.Interop.ThreadMessageEventHandler ThreadFilterMessage { add { } remove { } }
    public static event System.EventHandler ThreadIdle { add { } remove { } }
    public static event System.Windows.Interop.ThreadMessageEventHandler ThreadPreprocessMessage { add { } remove { } }
    [System.Security.SecurityCriticalAttribute]
    public static void PopModal() { }
    [System.Security.SecurityCriticalAttribute]
    public static void PushModal() { }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.UIPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
    public static void RaiseIdle() { }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.UIPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
    public static bool RaiseThreadMessage(ref System.Windows.Interop.MSG msg) { return default(bool); }
  }
  public partial interface IKeyboardInputSink {
    System.Windows.Interop.IKeyboardInputSite KeyboardInputSite { get; [System.Security.SecurityCriticalAttribute]set; }
    bool HasFocusWithin();
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.UIPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
    bool OnMnemonic(ref System.Windows.Interop.MSG msg, System.Windows.Input.ModifierKeys modifiers);
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.UIPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
    System.Windows.Interop.IKeyboardInputSite RegisterKeyboardInputSink(System.Windows.Interop.IKeyboardInputSink sink);
    bool TabInto(System.Windows.Input.TraversalRequest request);
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.UIPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
    bool TranslateAccelerator(ref System.Windows.Interop.MSG msg, System.Windows.Input.ModifierKeys modifiers);
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.UIPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
    bool TranslateChar(ref System.Windows.Interop.MSG msg, System.Windows.Input.ModifierKeys modifiers);
  }
  public partial interface IKeyboardInputSite {
    System.Windows.Interop.IKeyboardInputSink Sink { get; }
    bool OnNoMoreTabStops(System.Windows.Input.TraversalRequest request);
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.UIPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
    void Unregister();
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct MSG {
    public System.IntPtr hwnd { [System.Security.SecurityCriticalAttribute]get { return default(System.IntPtr); } [System.Security.SecurityCriticalAttribute]set { } }
    public System.IntPtr lParam { [System.Security.SecurityCriticalAttribute]get { return default(System.IntPtr); } [System.Security.SecurityCriticalAttribute]set { } }
    public int message { [System.Security.SecurityCriticalAttribute]get { return default(int); } [System.Security.SecurityCriticalAttribute]set { } }
    public int pt_x { [System.Security.SecurityCriticalAttribute]get { return default(int); } [System.Security.SecurityCriticalAttribute]set { } }
    public int pt_y { [System.Security.SecurityCriticalAttribute]get { return default(int); } [System.Security.SecurityCriticalAttribute]set { } }
    public int time { [System.Security.SecurityCriticalAttribute]get { return default(int); } [System.Security.SecurityCriticalAttribute]set { } }
    public System.IntPtr wParam { [System.Security.SecurityCriticalAttribute]get { return default(System.IntPtr); } [System.Security.SecurityCriticalAttribute]set { } }
  }
  public delegate void ThreadMessageEventHandler(ref System.Windows.Interop.MSG msg, ref bool handled);
}
namespace System.Windows.Markup {
  [System.FlagsAttribute]
  public enum DesignerSerializationOptions {
    SerializeAsAttribute = 1,
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(448), AllowMultiple=false)]
  public sealed partial class DesignerSerializationOptionsAttribute : System.Attribute {
    public DesignerSerializationOptionsAttribute(System.Windows.Markup.DesignerSerializationOptions designerSerializationOptions) { }
    public System.Windows.Markup.DesignerSerializationOptions DesignerSerializationOptions { get { return default(System.Windows.Markup.DesignerSerializationOptions); } }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public abstract partial class InternalTypeHelper {
    protected InternalTypeHelper() { }
    protected internal abstract void AddEventHandler(System.Reflection.EventInfo eventInfo, object target, System.Delegate handler);
    protected internal abstract System.Delegate CreateDelegate(System.Type delegateType, object target, string handler);
    protected internal abstract object CreateInstance(System.Type type, System.Globalization.CultureInfo culture);
    protected internal abstract object GetPropertyValue(System.Reflection.PropertyInfo propertyInfo, object target, System.Globalization.CultureInfo culture);
    protected internal abstract void SetPropertyValue(System.Reflection.PropertyInfo propertyInfo, object target, object value, System.Globalization.CultureInfo culture);
  }
  [System.ObsoleteAttribute("IReceiveMarkupExtension has been deprecated. This interface is no longer in use.")]
  public partial interface IReceiveMarkupExtension {
    void ReceiveMarkupExtension(string property, System.Windows.Markup.MarkupExtension markupExtension, System.IServiceProvider serviceProvider);
  }
  [System.ComponentModel.BrowsableAttribute(false)]
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public partial class ServiceProviders : System.IServiceProvider {
    public ServiceProviders() { }
    public void AddService(System.Type serviceType, object service) { }
    public object GetService(System.Type serviceType) { return default(object); }
  }
}
namespace System.Windows.Markup.Primitives {
  public abstract partial class MarkupObject {
    internal MarkupObject() { }
    public abstract System.ComponentModel.AttributeCollection Attributes { get; }
    public abstract object Instance { get; }
    public abstract System.Type ObjectType { get; }
    public virtual System.Collections.Generic.IEnumerable<System.Windows.Markup.Primitives.MarkupProperty> Properties { get { return default(System.Collections.Generic.IEnumerable<System.Windows.Markup.Primitives.MarkupProperty>); } }
    public abstract void AssignRootContext(System.Windows.Markup.IValueSerializerContext context);
  }
  public abstract partial class MarkupProperty {
    internal MarkupProperty() { }
    public abstract System.ComponentModel.AttributeCollection Attributes { get; }
    public virtual System.Windows.DependencyProperty DependencyProperty { get { return default(System.Windows.DependencyProperty); } }
    public virtual bool IsAttached { get { return default(bool); } }
    public virtual bool IsComposite { get { return default(bool); } }
    public virtual bool IsConstructorArgument { get { return default(bool); } }
    public virtual bool IsContent { get { return default(bool); } }
    public virtual bool IsKey { get { return default(bool); } }
    public virtual bool IsValueAsString { get { return default(bool); } }
    public abstract System.Collections.Generic.IEnumerable<System.Windows.Markup.Primitives.MarkupObject> Items { get; }
    public abstract string Name { get; }
    public virtual System.ComponentModel.PropertyDescriptor PropertyDescriptor { get { return default(System.ComponentModel.PropertyDescriptor); } }
    public abstract System.Type PropertyType { get; }
    public abstract string StringValue { get; }
    public abstract System.Collections.Generic.IEnumerable<System.Type> TypeReferences { get; }
    public abstract object Value { get; }
  }
}
namespace System.Windows.Media {
  [System.AttributeUsageAttribute((System.AttributeTargets)(1), AllowMultiple=false)]
  public sealed partial class DisableDpiAwarenessAttribute : System.Attribute {
    public DisableDpiAwarenessAttribute() { }
  }
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Media.MatrixConverter))]
  [System.Windows.Markup.ValueSerializerAttribute(typeof(System.Windows.Media.Converters.MatrixValueSerializer))]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Matrix : System.IFormattable {
    public Matrix(double m11, double m12, double m21, double m22, double offsetX, double offsetY) { throw new System.NotImplementedException(); }
    public double Determinant { get { return default(double); } }
    public bool HasInverse { get { return default(bool); } }
    public static System.Windows.Media.Matrix Identity { get { return default(System.Windows.Media.Matrix); } }
    public bool IsIdentity { get { return default(bool); } }
    public double M11 { get { return default(double); } set { } }
    public double M12 { get { return default(double); } set { } }
    public double M21 { get { return default(double); } set { } }
    public double M22 { get { return default(double); } set { } }
    public double OffsetX { get { return default(double); } set { } }
    public double OffsetY { get { return default(double); } set { } }
    public void Append(System.Windows.Media.Matrix matrix) { }
    public override bool Equals(object o) { return default(bool); }
    public bool Equals(System.Windows.Media.Matrix value) { return default(bool); }
    public static bool Equals(System.Windows.Media.Matrix matrix1, System.Windows.Media.Matrix matrix2) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public void Invert() { }
    public static System.Windows.Media.Matrix Multiply(System.Windows.Media.Matrix trans1, System.Windows.Media.Matrix trans2) { return default(System.Windows.Media.Matrix); }
    public static bool operator ==(System.Windows.Media.Matrix matrix1, System.Windows.Media.Matrix matrix2) { return default(bool); }
    public static bool operator !=(System.Windows.Media.Matrix matrix1, System.Windows.Media.Matrix matrix2) { return default(bool); }
    public static System.Windows.Media.Matrix operator *(System.Windows.Media.Matrix trans1, System.Windows.Media.Matrix trans2) { return default(System.Windows.Media.Matrix); }
    public static System.Windows.Media.Matrix Parse(string source) { return default(System.Windows.Media.Matrix); }
    public void Prepend(System.Windows.Media.Matrix matrix) { }
    public void Rotate(double angle) { }
    public void RotateAt(double angle, double centerX, double centerY) { }
    public void RotateAtPrepend(double angle, double centerX, double centerY) { }
    public void RotatePrepend(double angle) { }
    public void Scale(double scaleX, double scaleY) { }
    public void ScaleAt(double scaleX, double scaleY, double centerX, double centerY) { }
    public void ScaleAtPrepend(double scaleX, double scaleY, double centerX, double centerY) { }
    public void ScalePrepend(double scaleX, double scaleY) { }
    public void SetIdentity() { }
    public void Skew(double skewX, double skewY) { }
    public void SkewPrepend(double skewX, double skewY) { }
    string System.IFormattable.ToString(string format, System.IFormatProvider provider) { return default(string); }
    public override string ToString() { return default(string); }
    public string ToString(System.IFormatProvider provider) { return default(string); }
    public System.Windows.Point Transform(System.Windows.Point point) { return default(System.Windows.Point); }
    public void Transform(System.Windows.Point[] points) { }
    public System.Windows.Vector Transform(System.Windows.Vector vector) { return default(System.Windows.Vector); }
    public void Transform(System.Windows.Vector[] vectors) { }
    public void Translate(double offsetX, double offsetY) { }
    public void TranslatePrepend(double offsetX, double offsetY) { }
  }
  public sealed partial class MatrixConverter : System.ComponentModel.TypeConverter {
    public MatrixConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
  }
}
namespace System.Windows.Media.Converters {
  public partial class MatrixValueSerializer : System.Windows.Markup.ValueSerializer {
    public MatrixValueSerializer() { }
    public override bool CanConvertFromString(string value, System.Windows.Markup.IValueSerializerContext context) { return default(bool); }
    public override bool CanConvertToString(object value, System.Windows.Markup.IValueSerializerContext context) { return default(bool); }
    public override object ConvertFromString(string value, System.Windows.Markup.IValueSerializerContext context) { return default(object); }
    public override string ConvertToString(object value, System.Windows.Markup.IValueSerializerContext context) { return default(string); }
  }
}
namespace System.Windows.Threading {
  public sealed partial class Dispatcher {
    internal Dispatcher() { }
    public static System.Windows.Threading.Dispatcher CurrentDispatcher { get { return default(System.Windows.Threading.Dispatcher); } }
    public bool HasShutdownFinished { get { return default(bool); } }
    public bool HasShutdownStarted { get { return default(bool); } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public System.Windows.Threading.DispatcherHooks Hooks { [System.Security.SecurityCriticalAttribute]get { return default(System.Windows.Threading.DispatcherHooks); } }
    public System.Threading.Thread Thread { get { return default(System.Threading.Thread); } }
    public event System.EventHandler ShutdownFinished { add { } remove { } }
    public event System.EventHandler ShutdownStarted { add { } remove { } }
    public event System.Windows.Threading.DispatcherUnhandledExceptionEventHandler UnhandledException { add { } remove { } }
    public event System.Windows.Threading.DispatcherUnhandledExceptionFilterEventHandler UnhandledExceptionFilter { add { } remove { } }
    public System.Windows.Threading.DispatcherOperation BeginInvoke(System.Delegate method, params System.Object[] args) { return default(System.Windows.Threading.DispatcherOperation); }
    public System.Windows.Threading.DispatcherOperation BeginInvoke(System.Delegate method, System.Windows.Threading.DispatcherPriority priority, params System.Object[] args) { return default(System.Windows.Threading.DispatcherOperation); }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public System.Windows.Threading.DispatcherOperation BeginInvoke(System.Windows.Threading.DispatcherPriority priority, System.Delegate method) { return default(System.Windows.Threading.DispatcherOperation); }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public System.Windows.Threading.DispatcherOperation BeginInvoke(System.Windows.Threading.DispatcherPriority priority, System.Delegate method, object arg) { return default(System.Windows.Threading.DispatcherOperation); }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public System.Windows.Threading.DispatcherOperation BeginInvoke(System.Windows.Threading.DispatcherPriority priority, System.Delegate method, object arg, params System.Object[] args) { return default(System.Windows.Threading.DispatcherOperation); }
    [System.Security.SecurityCriticalAttribute]
    public void BeginInvokeShutdown(System.Windows.Threading.DispatcherPriority priority) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool CheckAccess() { return default(bool); }
    public System.Windows.Threading.DispatcherProcessingDisabled DisableProcessing() { return default(System.Windows.Threading.DispatcherProcessingDisabled); }
    [System.Security.SecurityCriticalAttribute]
    public static void ExitAllFrames() { }
    public static System.Windows.Threading.Dispatcher FromThread(System.Threading.Thread thread) { return default(System.Windows.Threading.Dispatcher); }
    public void Invoke(System.Action callback) { }
    public void Invoke(System.Action callback, System.Windows.Threading.DispatcherPriority priority) { }
    public void Invoke(System.Action callback, System.Windows.Threading.DispatcherPriority priority, System.Threading.CancellationToken cancellationToken) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public void Invoke(System.Action callback, System.Windows.Threading.DispatcherPriority priority, System.Threading.CancellationToken cancellationToken, System.TimeSpan timeout) { }
    public object Invoke(System.Delegate method, params System.Object[] args) { return default(object); }
    public object Invoke(System.Delegate method, System.TimeSpan timeout, params System.Object[] args) { return default(object); }
    public object Invoke(System.Delegate method, System.TimeSpan timeout, System.Windows.Threading.DispatcherPriority priority, params System.Object[] args) { return default(object); }
    public object Invoke(System.Delegate method, System.Windows.Threading.DispatcherPriority priority, params System.Object[] args) { return default(object); }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public object Invoke(System.Windows.Threading.DispatcherPriority priority, System.Delegate method) { return default(object); }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public object Invoke(System.Windows.Threading.DispatcherPriority priority, System.Delegate method, object arg) { return default(object); }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public object Invoke(System.Windows.Threading.DispatcherPriority priority, System.Delegate method, object arg, params System.Object[] args) { return default(object); }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public object Invoke(System.Windows.Threading.DispatcherPriority priority, System.TimeSpan timeout, System.Delegate method) { return default(object); }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public object Invoke(System.Windows.Threading.DispatcherPriority priority, System.TimeSpan timeout, System.Delegate method, object arg) { return default(object); }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public object Invoke(System.Windows.Threading.DispatcherPriority priority, System.TimeSpan timeout, System.Delegate method, object arg, params System.Object[] args) { return default(object); }
    public TResult Invoke<TResult>(System.Func<TResult> callback) { return default(TResult); }
    public TResult Invoke<TResult>(System.Func<TResult> callback, System.Windows.Threading.DispatcherPriority priority) { return default(TResult); }
    public TResult Invoke<TResult>(System.Func<TResult> callback, System.Windows.Threading.DispatcherPriority priority, System.Threading.CancellationToken cancellationToken) { return default(TResult); }
    [System.Security.SecuritySafeCriticalAttribute]
    public TResult Invoke<TResult>(System.Func<TResult> callback, System.Windows.Threading.DispatcherPriority priority, System.Threading.CancellationToken cancellationToken, System.TimeSpan timeout) { return default(TResult); }
    public System.Windows.Threading.DispatcherOperation InvokeAsync(System.Action callback) { return default(System.Windows.Threading.DispatcherOperation); }
    public System.Windows.Threading.DispatcherOperation InvokeAsync(System.Action callback, System.Windows.Threading.DispatcherPriority priority) { return default(System.Windows.Threading.DispatcherOperation); }
    [System.Security.SecuritySafeCriticalAttribute]
    public System.Windows.Threading.DispatcherOperation InvokeAsync(System.Action callback, System.Windows.Threading.DispatcherPriority priority, System.Threading.CancellationToken cancellationToken) { return default(System.Windows.Threading.DispatcherOperation); }
    public System.Windows.Threading.DispatcherOperation<TResult> InvokeAsync<TResult>(System.Func<TResult> callback) { return default(System.Windows.Threading.DispatcherOperation<TResult>); }
    public System.Windows.Threading.DispatcherOperation<TResult> InvokeAsync<TResult>(System.Func<TResult> callback, System.Windows.Threading.DispatcherPriority priority) { return default(System.Windows.Threading.DispatcherOperation<TResult>); }
    [System.Security.SecuritySafeCriticalAttribute]
    public System.Windows.Threading.DispatcherOperation<TResult> InvokeAsync<TResult>(System.Func<TResult> callback, System.Windows.Threading.DispatcherPriority priority, System.Threading.CancellationToken cancellationToken) { return default(System.Windows.Threading.DispatcherOperation<TResult>); }
    [System.Security.SecurityCriticalAttribute]
    public void InvokeShutdown() { }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.UIPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
    public static void PushFrame(System.Windows.Threading.DispatcherFrame frame) { }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.UIPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
    public static void Run() { }
    public static void ValidatePriority(System.Windows.Threading.DispatcherPriority priority, string parameterName) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void VerifyAccess() { }
    public static System.Windows.Threading.DispatcherPriorityAwaitable Yield() { return default(System.Windows.Threading.DispatcherPriorityAwaitable); }
    public static System.Windows.Threading.DispatcherPriorityAwaitable Yield(System.Windows.Threading.DispatcherPriority priority) { return default(System.Windows.Threading.DispatcherPriorityAwaitable); }
  }
  public partial class DispatcherEventArgs : System.EventArgs {
    internal DispatcherEventArgs() { }
    public System.Windows.Threading.Dispatcher Dispatcher { get { return default(System.Windows.Threading.Dispatcher); } }
  }
  public partial class DispatcherFrame : System.Windows.Threading.DispatcherObject {
    public DispatcherFrame() { }
    public DispatcherFrame(bool exitWhenRequested) { }
    public bool Continue { get { return default(bool); } [System.Security.SecurityCriticalAttribute]set { } }
  }
  public sealed partial class DispatcherHookEventArgs : System.EventArgs {
    public DispatcherHookEventArgs(System.Windows.Threading.DispatcherOperation operation) { }
    public System.Windows.Threading.Dispatcher Dispatcher { get { return default(System.Windows.Threading.Dispatcher); } }
    public System.Windows.Threading.DispatcherOperation Operation { get { return default(System.Windows.Threading.DispatcherOperation); } }
  }
  public delegate void DispatcherHookEventHandler(object sender, System.Windows.Threading.DispatcherHookEventArgs e);
  public sealed partial class DispatcherHooks {
    internal DispatcherHooks() { }
    public event System.EventHandler DispatcherInactive { add { } remove { } }
    public event System.Windows.Threading.DispatcherHookEventHandler OperationAborted { add { } remove { } }
    public event System.Windows.Threading.DispatcherHookEventHandler OperationCompleted { add { } remove { } }
    public event System.Windows.Threading.DispatcherHookEventHandler OperationPosted { add { } remove { } }
    public event System.Windows.Threading.DispatcherHookEventHandler OperationPriorityChanged { add { } remove { } }
    public event System.Windows.Threading.DispatcherHookEventHandler OperationStarted { add { } remove { } }
  }
  public abstract partial class DispatcherObject {
    protected DispatcherObject() { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public System.Windows.Threading.Dispatcher Dispatcher { get { return default(System.Windows.Threading.Dispatcher); } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool CheckAccess() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void VerifyAccess() { }
  }
  public partial class DispatcherOperation {
    internal DispatcherOperation() { }
    public System.Windows.Threading.Dispatcher Dispatcher { get { return default(System.Windows.Threading.Dispatcher); } }
    public System.Windows.Threading.DispatcherPriority Priority { get { return default(System.Windows.Threading.DispatcherPriority); } set { } }
    public object Result { get { return default(object); } }
    public System.Windows.Threading.DispatcherOperationStatus Status { get { return default(System.Windows.Threading.DispatcherOperationStatus); } }
    public System.Threading.Tasks.Task Task { get { return default(System.Threading.Tasks.Task); } }
    public event System.EventHandler Aborted { add { } remove { } }
    public event System.EventHandler Completed { add { } remove { } }
    public bool Abort() { return default(bool); }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public System.Runtime.CompilerServices.TaskAwaiter GetAwaiter() { return default(System.Runtime.CompilerServices.TaskAwaiter); }
    protected virtual object InvokeDelegateCore() { return default(object); }
    public System.Windows.Threading.DispatcherOperationStatus Wait() { return default(System.Windows.Threading.DispatcherOperationStatus); }
    [System.Security.SecurityCriticalAttribute]
    public System.Windows.Threading.DispatcherOperationStatus Wait(System.TimeSpan timeout) { return default(System.Windows.Threading.DispatcherOperationStatus); }
  }
  public partial class DispatcherOperation<TResult> : System.Windows.Threading.DispatcherOperation {
    internal DispatcherOperation() { }
    public new TResult Result { get { return default(TResult); } }
    public new System.Threading.Tasks.Task<TResult> Task { get { return default(System.Threading.Tasks.Task<TResult>); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public new System.Runtime.CompilerServices.TaskAwaiter<TResult> GetAwaiter() { return default(System.Runtime.CompilerServices.TaskAwaiter<TResult>); }
    protected override object InvokeDelegateCore() { return default(object); }
  }
  public delegate object DispatcherOperationCallback(object arg);
  public enum DispatcherOperationStatus {
    Aborted = 1,
    Completed = 2,
    Executing = 3,
    Pending = 0,
  }
  public enum DispatcherPriority {
    ApplicationIdle = 2,
    Background = 4,
    ContextIdle = 3,
    DataBind = 8,
    Inactive = 0,
    Input = 5,
    Invalid = -1,
    Loaded = 6,
    Normal = 9,
    Render = 7,
    Send = 10,
    SystemIdle = 1,
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct DispatcherPriorityAwaitable {
    public System.Windows.Threading.DispatcherPriorityAwaiter GetAwaiter() { return default(System.Windows.Threading.DispatcherPriorityAwaiter); }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct DispatcherPriorityAwaiter : System.Runtime.CompilerServices.INotifyCompletion {
    public bool IsCompleted { get { return default(bool); } }
    public void GetResult() { }
    public void OnCompleted(System.Action continuation) { }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct DispatcherProcessingDisabled : System.IDisposable {
    public void Dispose() { }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Windows.Threading.DispatcherProcessingDisabled left, System.Windows.Threading.DispatcherProcessingDisabled right) { return default(bool); }
    public static bool operator !=(System.Windows.Threading.DispatcherProcessingDisabled left, System.Windows.Threading.DispatcherProcessingDisabled right) { return default(bool); }
  }
  public sealed partial class DispatcherSynchronizationContext : System.Threading.SynchronizationContext {
    public DispatcherSynchronizationContext() { }
    public DispatcherSynchronizationContext(System.Windows.Threading.Dispatcher dispatcher) { }
    public DispatcherSynchronizationContext(System.Windows.Threading.Dispatcher dispatcher, System.Windows.Threading.DispatcherPriority priority) { }
    public override System.Threading.SynchronizationContext CreateCopy() { return default(System.Threading.SynchronizationContext); }
    public override void Post(System.Threading.SendOrPostCallback d, object state) { }
    public override void Send(System.Threading.SendOrPostCallback d, object state) { }
    [System.Runtime.ConstrainedExecution.PrePrepareMethodAttribute]
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(96))]
    public override int Wait(System.IntPtr[] waitHandles, bool waitAll, int millisecondsTimeout) { return default(int); }
  }
  public partial class DispatcherTimer {
    public DispatcherTimer() { }
    public DispatcherTimer(System.TimeSpan interval, System.Windows.Threading.DispatcherPriority priority, System.EventHandler callback, System.Windows.Threading.Dispatcher dispatcher) { }
    public DispatcherTimer(System.Windows.Threading.DispatcherPriority priority) { }
    public DispatcherTimer(System.Windows.Threading.DispatcherPriority priority, System.Windows.Threading.Dispatcher dispatcher) { }
    public System.Windows.Threading.Dispatcher Dispatcher { get { return default(System.Windows.Threading.Dispatcher); } }
    public System.TimeSpan Interval { get { return default(System.TimeSpan); } set { } }
    public bool IsEnabled { get { return default(bool); } set { } }
    public object Tag { get { return default(object); } set { } }
    public event System.EventHandler Tick { add { } remove { } }
    public void Start() { }
    public void Stop() { }
  }
  public sealed partial class DispatcherUnhandledExceptionEventArgs : System.Windows.Threading.DispatcherEventArgs {
    internal DispatcherUnhandledExceptionEventArgs() { }
    public System.Exception Exception { get { return default(System.Exception); } }
    public bool Handled { get { return default(bool); } set { } }
  }
  public delegate void DispatcherUnhandledExceptionEventHandler(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e);
  public sealed partial class DispatcherUnhandledExceptionFilterEventArgs : System.Windows.Threading.DispatcherEventArgs {
    internal DispatcherUnhandledExceptionFilterEventArgs() { }
    public System.Exception Exception { get { return default(System.Exception); } }
    public bool RequestCatch { get { return default(bool); } set { } }
  }
  public delegate void DispatcherUnhandledExceptionFilterEventHandler(object sender, System.Windows.Threading.DispatcherUnhandledExceptionFilterEventArgs e);
}
