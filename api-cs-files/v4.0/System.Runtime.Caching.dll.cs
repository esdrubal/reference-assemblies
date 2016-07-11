namespace System.Runtime.Caching {
  public abstract partial class CacheEntryChangeMonitor : System.Runtime.Caching.ChangeMonitor {
    protected CacheEntryChangeMonitor() { }
    public abstract System.Collections.ObjectModel.ReadOnlyCollection<System.String> CacheKeys { get; }
    public abstract System.DateTimeOffset LastModified { get; }
    public abstract string RegionName { get; }
  }
  public partial class CacheEntryRemovedArguments {
    public CacheEntryRemovedArguments(System.Runtime.Caching.ObjectCache source, System.Runtime.Caching.CacheEntryRemovedReason reason, System.Runtime.Caching.CacheItem cacheItem) { }
    public System.Runtime.Caching.CacheItem CacheItem { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Runtime.Caching.CacheItem); } }
    public System.Runtime.Caching.CacheEntryRemovedReason RemovedReason { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Runtime.Caching.CacheEntryRemovedReason); } }
    public System.Runtime.Caching.ObjectCache Source { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Runtime.Caching.ObjectCache); } }
  }
  public delegate void CacheEntryRemovedCallback(System.Runtime.Caching.CacheEntryRemovedArguments arguments);
  public enum CacheEntryRemovedReason {
    CacheSpecificEviction = 4,
    ChangeMonitorChanged = 3,
    Evicted = 2,
    Expired = 1,
    Removed = 0,
  }
  public partial class CacheEntryUpdateArguments {
    public CacheEntryUpdateArguments(System.Runtime.Caching.ObjectCache source, System.Runtime.Caching.CacheEntryRemovedReason reason, string key, string regionName) { }
    public string Key { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string RegionName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public System.Runtime.Caching.CacheEntryRemovedReason RemovedReason { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Runtime.Caching.CacheEntryRemovedReason); } }
    public System.Runtime.Caching.ObjectCache Source { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Runtime.Caching.ObjectCache); } }
    public System.Runtime.Caching.CacheItem UpdatedCacheItem { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Runtime.Caching.CacheItem); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Runtime.Caching.CacheItemPolicy UpdatedCacheItemPolicy { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Runtime.Caching.CacheItemPolicy); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public delegate void CacheEntryUpdateCallback(System.Runtime.Caching.CacheEntryUpdateArguments arguments);
  public partial class CacheItem {
    public CacheItem(string key) { }
    public CacheItem(string key, object value) { }
    public CacheItem(string key, object value, string regionName) { }
    public string Key { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string RegionName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public object Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial class CacheItemPolicy {
    public CacheItemPolicy() { }
    public System.DateTimeOffset AbsoluteExpiration { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.DateTimeOffset); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.ObjectModel.Collection<System.Runtime.Caching.ChangeMonitor> ChangeMonitors { get { return default(System.Collections.ObjectModel.Collection<System.Runtime.Caching.ChangeMonitor>); } }
    public System.Runtime.Caching.CacheItemPriority Priority { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Runtime.Caching.CacheItemPriority); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Runtime.Caching.CacheEntryRemovedCallback RemovedCallback { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Runtime.Caching.CacheEntryRemovedCallback); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.TimeSpan SlidingExpiration { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.TimeSpan); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Runtime.Caching.CacheEntryUpdateCallback UpdateCallback { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Runtime.Caching.CacheEntryUpdateCallback); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public enum CacheItemPriority {
    Default = 0,
    NotRemovable = 1,
  }
  public abstract partial class ChangeMonitor : System.IDisposable {
    protected ChangeMonitor() { }
    public bool HasChanged { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    public bool IsDisposed { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    public abstract string UniqueId { get; }
    public void Dispose() { }
    protected abstract void Dispose(bool disposing);
    protected void InitializationComplete() { }
    public void NotifyOnChanged(System.Runtime.Caching.OnChangedCallback onChangedCallback) { }
    protected void OnChanged(object state) { }
  }
  [System.FlagsAttribute]
  public enum DefaultCacheCapabilities {
    AbsoluteExpirations = 8,
    CacheEntryChangeMonitors = 4,
    CacheEntryRemovedCallback = 64,
    CacheEntryUpdateCallback = 32,
    CacheRegions = 128,
    InMemoryProvider = 1,
    None = 0,
    OutOfProcessProvider = 2,
    SlidingExpirations = 16,
  }
  public abstract partial class FileChangeMonitor : System.Runtime.Caching.ChangeMonitor {
    protected FileChangeMonitor() { }
    public abstract System.Collections.ObjectModel.ReadOnlyCollection<System.String> FilePaths { get; }
    public abstract System.DateTimeOffset LastModified { get; }
  }
  public sealed partial class HostFileChangeMonitor : System.Runtime.Caching.FileChangeMonitor {
    public HostFileChangeMonitor(System.Collections.Generic.IList<System.String> filePaths) { }
    public override System.Collections.ObjectModel.ReadOnlyCollection<System.String> FilePaths { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.String>); } }
    public override System.DateTimeOffset LastModified { get { return default(System.DateTimeOffset); } }
    public override string UniqueId { get { return default(string); } }
    protected override void Dispose(bool disposing) { }
  }
  public partial class MemoryCache : System.Runtime.Caching.ObjectCache, System.Collections.IEnumerable, System.IDisposable {
    public MemoryCache(string name, System.Collections.Specialized.NameValueCollection config=null) { }
    public long CacheMemoryLimit { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(long); } }
    public static System.Runtime.Caching.MemoryCache Default { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Runtime.Caching.MemoryCache); } }
    public override System.Runtime.Caching.DefaultCacheCapabilities DefaultCacheCapabilities { get { return default(System.Runtime.Caching.DefaultCacheCapabilities); } }
    public override object this[string key] { get { return default(object); } set { } }
    public override string Name { get { return default(string); } }
    public long PhysicalMemoryLimit { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(long); } }
    public System.TimeSpan PollingInterval { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.TimeSpan); } }
    public override System.Runtime.Caching.CacheItem AddOrGetExisting(System.Runtime.Caching.CacheItem item, System.Runtime.Caching.CacheItemPolicy policy) { return default(System.Runtime.Caching.CacheItem); }
    public override object AddOrGetExisting(string key, object value, System.DateTimeOffset absoluteExpiration, string regionName=null) { return default(object); }
    public override object AddOrGetExisting(string key, object value, System.Runtime.Caching.CacheItemPolicy policy, string regionName=null) { return default(object); }
    public override bool Contains(string key, string regionName=null) { return default(bool); }
    public override System.Runtime.Caching.CacheEntryChangeMonitor CreateCacheEntryChangeMonitor(System.Collections.Generic.IEnumerable<System.String> keys, string regionName=null) { return default(System.Runtime.Caching.CacheEntryChangeMonitor); }
    public void Dispose() { }
    public override object Get(string key, string regionName=null) { return default(object); }
    public override System.Runtime.Caching.CacheItem GetCacheItem(string key, string regionName=null) { return default(System.Runtime.Caching.CacheItem); }
    public override long GetCount(string regionName=null) { return default(long); }
    protected override System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String, System.Object>> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String, System.Object>>); }
    public override System.Collections.Generic.IDictionary<System.String, System.Object> GetValues(System.Collections.Generic.IEnumerable<System.String> keys, string regionName=null) { return default(System.Collections.Generic.IDictionary<System.String, System.Object>); }
    public override object Remove(string key, string regionName=null) { return default(object); }
    public override void Set(System.Runtime.Caching.CacheItem item, System.Runtime.Caching.CacheItemPolicy policy) { }
    public override void Set(string key, object value, System.DateTimeOffset absoluteExpiration, string regionName=null) { }
    public override void Set(string key, object value, System.Runtime.Caching.CacheItemPolicy policy, string regionName=null) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    public long Trim(int percent) { return default(long); }
  }
  public abstract partial class ObjectCache : System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>, System.Collections.IEnumerable {
    public static readonly System.DateTimeOffset InfiniteAbsoluteExpiration;
    public static readonly System.TimeSpan NoSlidingExpiration;
    protected ObjectCache() { }
    public abstract System.Runtime.Caching.DefaultCacheCapabilities DefaultCacheCapabilities { get; }
    public static System.IServiceProvider Host { get { return default(System.IServiceProvider); } set { } }
    public abstract object this[string key] { get; set; }
    public abstract string Name { get; }
    public virtual bool Add(System.Runtime.Caching.CacheItem item, System.Runtime.Caching.CacheItemPolicy policy) { return default(bool); }
    public virtual bool Add(string key, object value, System.DateTimeOffset absoluteExpiration, string regionName=null) { return default(bool); }
    public virtual bool Add(string key, object value, System.Runtime.Caching.CacheItemPolicy policy, string regionName=null) { return default(bool); }
    public abstract System.Runtime.Caching.CacheItem AddOrGetExisting(System.Runtime.Caching.CacheItem value, System.Runtime.Caching.CacheItemPolicy policy);
    public abstract object AddOrGetExisting(string key, object value, System.DateTimeOffset absoluteExpiration, string regionName=null);
    public abstract object AddOrGetExisting(string key, object value, System.Runtime.Caching.CacheItemPolicy policy, string regionName=null);
    public abstract bool Contains(string key, string regionName=null);
    public abstract System.Runtime.Caching.CacheEntryChangeMonitor CreateCacheEntryChangeMonitor(System.Collections.Generic.IEnumerable<System.String> keys, string regionName=null);
    public abstract object Get(string key, string regionName=null);
    public abstract System.Runtime.Caching.CacheItem GetCacheItem(string key, string regionName=null);
    public abstract long GetCount(string regionName=null);
    protected abstract System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String, System.Object>> GetEnumerator();
    public abstract System.Collections.Generic.IDictionary<System.String, System.Object> GetValues(System.Collections.Generic.IEnumerable<System.String> keys, string regionName=null);
    public virtual System.Collections.Generic.IDictionary<System.String, System.Object> GetValues(string regionName=null, params System.String[] keys) { return default(System.Collections.Generic.IDictionary<System.String, System.Object>); }
    public abstract object Remove(string key, string regionName=null);
    public abstract void Set(System.Runtime.Caching.CacheItem item, System.Runtime.Caching.CacheItemPolicy policy);
    public abstract void Set(string key, object value, System.DateTimeOffset absoluteExpiration, string regionName=null);
    public abstract void Set(string key, object value, System.Runtime.Caching.CacheItemPolicy policy, string regionName=null);
    System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String, System.Object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string,object>>.GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String, System.Object>>); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public delegate void OnChangedCallback(object state);
  public sealed partial class SqlChangeMonitor : System.Runtime.Caching.ChangeMonitor {
    public SqlChangeMonitor(System.Data.SqlClient.SqlDependency dependency) { }
    public override string UniqueId { get { return default(string); } }
    protected override void Dispose(bool disposing) { }
  }
}
namespace System.Runtime.Caching.Configuration {
  public sealed partial class CachingSectionGroup : System.Configuration.ConfigurationSectionGroup {
    public CachingSectionGroup() { }
    [System.Configuration.ConfigurationPropertyAttribute("memoryCache")]
    public System.Runtime.Caching.Configuration.MemoryCacheSection MemoryCaches { get { return default(System.Runtime.Caching.Configuration.MemoryCacheSection); } }
  }
  public sealed partial class MemoryCacheElement : System.Configuration.ConfigurationElement {
    public MemoryCacheElement(string name) { }
    [System.Configuration.ConfigurationPropertyAttribute("cacheMemoryLimitMegabytes", DefaultValue=0)]
    [System.Configuration.IntegerValidatorAttribute(MinValue=1)]
    public int CacheMemoryLimitMegabytes { get { return default(int); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Configuration.WhiteSpaceTrimStringConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("name", DefaultValue="", IsRequired=true, IsKey=true)]
    [System.Configuration.StringValidatorAttribute(MinLength=1)]
    public string Name { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("physicalMemoryLimitPercentage", DefaultValue=0)]
    [System.Configuration.IntegerValidatorAttribute(MinValue=1, MaxValue=100)]
    public int PhysicalMemoryLimitPercentage { get { return default(int); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Configuration.InfiniteTimeSpanConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("pollingInterval", DefaultValue="00:02:00")]
    public System.TimeSpan PollingInterval { get { return default(System.TimeSpan); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  public sealed partial class MemoryCacheSection : System.Configuration.ConfigurationSection {
    public MemoryCacheSection() { }
    [System.Configuration.ConfigurationPropertyAttribute("namedCaches")]
    public System.Runtime.Caching.Configuration.MemoryCacheSettingsCollection NamedCaches { get { return default(System.Runtime.Caching.Configuration.MemoryCacheSettingsCollection); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.Runtime.Caching.Configuration.MemoryCacheElement), CollectionType=(System.Configuration.ConfigurationElementCollectionType)(1))]
  public sealed partial class MemoryCacheSettingsCollection : System.Configuration.ConfigurationElementCollection {
    public MemoryCacheSettingsCollection() { }
    public override System.Configuration.ConfigurationElementCollectionType CollectionType { get { return default(System.Configuration.ConfigurationElementCollectionType); } }
    public System.Runtime.Caching.Configuration.MemoryCacheElement this[int index] { get { return default(System.Runtime.Caching.Configuration.MemoryCacheElement); } set { } }
    public new System.Runtime.Caching.Configuration.MemoryCacheElement this[string key] { get { return default(System.Runtime.Caching.Configuration.MemoryCacheElement); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    public void Add(System.Runtime.Caching.Configuration.MemoryCacheElement cache) { }
    public void Clear() { }
    protected override System.Configuration.ConfigurationElement CreateNewElement() { return default(System.Configuration.ConfigurationElement); }
    protected override System.Configuration.ConfigurationElement CreateNewElement(string elementName) { return default(System.Configuration.ConfigurationElement); }
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
    public int IndexOf(System.Runtime.Caching.Configuration.MemoryCacheElement cache) { return default(int); }
    public void Remove(System.Runtime.Caching.Configuration.MemoryCacheElement cache) { }
    public void RemoveAt(int index) { }
  }
}
namespace System.Runtime.Caching.Hosting {
  public partial interface IApplicationIdentifier {
    string GetApplicationId();
  }
  public partial interface IFileChangeNotificationSystem {
    void StartMonitoring(string filePath, System.Runtime.Caching.OnChangedCallback onChangedCallback, out object state, out System.DateTimeOffset lastWriteTime, out long fileSize);
    void StopMonitoring(string filePath, object state);
  }
  public partial interface IMemoryCacheManager {
    void ReleaseCache(System.Runtime.Caching.MemoryCache cache);
    void UpdateCacheSize(long size, System.Runtime.Caching.MemoryCache cache);
  }
}
