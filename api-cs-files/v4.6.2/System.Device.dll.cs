namespace System.Device.Location {
  public partial class CivicAddress {
    public static readonly System.Device.Location.CivicAddress Unknown;
    public CivicAddress() { }
    public CivicAddress(string addressLine1, string addressLine2, string building, string city, string countryRegion, string floorLevel, string postalCode, string stateProvince) { }
    public string AddressLine1 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string AddressLine2 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Building { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string City { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string CountryRegion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string FloorLevel { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool IsUnknown { get { return default(bool); } }
    public string PostalCode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string StateProvince { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public sealed partial class CivicAddressResolver : System.Device.Location.ICivicAddressResolver {
    public CivicAddressResolver() { }
    public event System.EventHandler<System.Device.Location.ResolveAddressCompletedEventArgs> ResolveAddressCompleted { add { } remove { } }
    public System.Device.Location.CivicAddress ResolveAddress(System.Device.Location.GeoCoordinate coordinate) { return default(System.Device.Location.CivicAddress); }
    public void ResolveAddressAsync(System.Device.Location.GeoCoordinate coordinate) { }
  }
  public partial class GeoCoordinate : System.IEquatable<System.Device.Location.GeoCoordinate> {
    public static readonly System.Device.Location.GeoCoordinate Unknown;
    public GeoCoordinate() { }
    public GeoCoordinate(double latitude, double longitude) { }
    public GeoCoordinate(double latitude, double longitude, double altitude) { }
    public GeoCoordinate(double latitude, double longitude, double altitude, double horizontalAccuracy, double verticalAccuracy, double speed, double course) { }
    public double Altitude { get { return default(double); } set { } }
    public double Course { get { return default(double); } set { } }
    public double HorizontalAccuracy { get { return default(double); } set { } }
    public bool IsUnknown { get { return default(bool); } }
    public double Latitude { get { return default(double); } set { } }
    public double Longitude { get { return default(double); } set { } }
    public double Speed { get { return default(double); } set { } }
    public double VerticalAccuracy { get { return default(double); } set { } }
    public bool Equals(System.Device.Location.GeoCoordinate other) { return default(bool); }
    public override bool Equals(object obj) { return default(bool); }
    public double GetDistanceTo(System.Device.Location.GeoCoordinate other) { return default(double); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Device.Location.GeoCoordinate left, System.Device.Location.GeoCoordinate right) { return default(bool); }
    public static bool operator !=(System.Device.Location.GeoCoordinate left, System.Device.Location.GeoCoordinate right) { return default(bool); }
    public override string ToString() { return default(string); }
  }
  [System.Security.SecurityCriticalAttribute]
  public partial class GeoCoordinateWatcher : System.ComponentModel.INotifyPropertyChanged, System.Device.Location.IGeoPositionWatcher<System.Device.Location.GeoCoordinate>, System.IDisposable {
    public GeoCoordinateWatcher() { }
    public GeoCoordinateWatcher(System.Device.Location.GeoPositionAccuracy desiredAccuracy) { }
    public System.Device.Location.GeoPositionAccuracy DesiredAccuracy { get { return default(System.Device.Location.GeoPositionAccuracy); } }
    public double MovementThreshold { get { return default(double); } set { } }
    public System.Device.Location.GeoPositionPermission Permission { get { return default(System.Device.Location.GeoPositionPermission); } }
    public System.Device.Location.GeoPosition<System.Device.Location.GeoCoordinate> Position { [System.Security.SecuritySafeCriticalAttribute]get { return default(System.Device.Location.GeoPosition<System.Device.Location.GeoCoordinate>); } }
    public System.Device.Location.GeoPositionStatus Status { [System.Security.SecuritySafeCriticalAttribute]get { return default(System.Device.Location.GeoPositionStatus); } }
    public event System.EventHandler<System.Device.Location.GeoPositionChangedEventArgs<System.Device.Location.GeoCoordinate>> PositionChanged { add { } remove { } }
    public event System.EventHandler<System.Device.Location.GeoPositionStatusChangedEventArgs> StatusChanged { add { } remove { } }
    event System.ComponentModel.PropertyChangedEventHandler System.ComponentModel.INotifyPropertyChanged.PropertyChanged { add { } remove { } }
    event System.EventHandler<System.Device.Location.GeoPositionChangedEventArgs<System.Device.Location.GeoCoordinate>> System.Device.Location.IGeoPositionWatcher<System.Device.Location.GeoCoordinate>.PositionChanged { add { } remove { } }
    event System.EventHandler<System.Device.Location.GeoPositionStatusChangedEventArgs> System.Device.Location.IGeoPositionWatcher<System.Device.Location.GeoCoordinate>.StatusChanged { add { } remove { } }
    [System.Security.SecuritySafeCriticalAttribute]
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    ~GeoCoordinateWatcher() { }
    protected void OnPositionChanged(System.Device.Location.GeoPositionChangedEventArgs<System.Device.Location.GeoCoordinate> e) { }
    protected void OnPositionStatusChanged(System.Device.Location.GeoPositionStatusChangedEventArgs e) { }
    protected void OnPropertyChanged(string propertyName) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public void Start() { }
    [System.Security.SecuritySafeCriticalAttribute]
    public void Start(bool suppressPermissionPrompt) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public void Stop() { }
    [System.Security.SecuritySafeCriticalAttribute]
    public bool TryStart(bool suppressPermissionPrompt, System.TimeSpan timeout) { return default(bool); }
  }
  public partial class GeoPosition<T> {
    public GeoPosition() { }
    public GeoPosition(System.DateTimeOffset timestamp, T position) { }
    public T Location { get { return default(T); } set { } }
    public System.DateTimeOffset Timestamp { get { return default(System.DateTimeOffset); } set { } }
  }
  public enum GeoPositionAccuracy {
    Default = 0,
    High = 1,
  }
  public partial class GeoPositionChangedEventArgs<T> : System.EventArgs {
    public GeoPositionChangedEventArgs(System.Device.Location.GeoPosition<T> position) { }
    public System.Device.Location.GeoPosition<T> Position { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Device.Location.GeoPosition<T>); } }
  }
  public enum GeoPositionPermission {
    Denied = 2,
    Granted = 1,
    Unknown = 0,
  }
  public enum GeoPositionStatus {
    Disabled = 3,
    Initializing = 1,
    NoData = 2,
    Ready = 0,
  }
  public partial class GeoPositionStatusChangedEventArgs : System.EventArgs {
    public GeoPositionStatusChangedEventArgs(System.Device.Location.GeoPositionStatus status) { }
    public System.Device.Location.GeoPositionStatus Status { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Device.Location.GeoPositionStatus); } }
  }
  public partial interface ICivicAddressResolver {
    event System.EventHandler<System.Device.Location.ResolveAddressCompletedEventArgs> ResolveAddressCompleted;
    System.Device.Location.CivicAddress ResolveAddress(System.Device.Location.GeoCoordinate coordinate);
    void ResolveAddressAsync(System.Device.Location.GeoCoordinate coordinate);
  }
  public partial interface IGeoPositionWatcher<T> {
    System.Device.Location.GeoPosition<T> Position { get; }
    System.Device.Location.GeoPositionStatus Status { get; }
    event System.EventHandler<System.Device.Location.GeoPositionChangedEventArgs<T>> PositionChanged;
    event System.EventHandler<System.Device.Location.GeoPositionStatusChangedEventArgs> StatusChanged;
    void Start();
    void Start(bool suppressPermissionPrompt);
    void Stop();
    bool TryStart(bool suppressPermissionPrompt, System.TimeSpan timeout);
  }
  public partial class ResolveAddressCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    public ResolveAddressCompletedEventArgs(System.Device.Location.CivicAddress address, System.Exception error, bool cancelled, object userState) { }
    public System.Device.Location.CivicAddress Address { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Device.Location.CivicAddress); } }
  }
}
