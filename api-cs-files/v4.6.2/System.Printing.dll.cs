namespace System.Printing {
  [System.FlagsAttribute]
  public enum EnumeratedPrintQueueTypes {
    Connections = 16,
    DirectPrinting = 2,
    EnableBidi = 2048,
    EnableDevQuery = 128,
    Fax = 16384,
    KeepPrintedJobs = 256,
    Local = 64,
    PublishedInDirectoryServices = 8192,
    PushedMachineConnection = 262144,
    PushedUserConnection = 131072,
    Queued = 1,
    RawOnly = 4096,
    Shared = 8,
    TerminalServer = 32768,
    WorkOffline = 1024,
  }
  public sealed partial class LocalPrintServer : System.Printing.PrintServer {
    public LocalPrintServer() { }
    public LocalPrintServer(System.Printing.LocalPrintServerIndexedProperty[] propertiesFilter) { }
    public LocalPrintServer(System.Printing.LocalPrintServerIndexedProperty[] propertiesFilter, System.Printing.PrintSystemDesiredAccess desiredAccess) { }
    public LocalPrintServer(System.Printing.PrintSystemDesiredAccess desiredAccess) { }
    public LocalPrintServer(System.String[] propertiesFilter) { }
    public LocalPrintServer(System.String[] propertiesFilter, System.Printing.PrintSystemDesiredAccess desiredAccess) { }
    public System.Printing.PrintQueue DefaultPrintQueue { get { return default(System.Printing.PrintQueue); } set { } }
    public sealed override void Commit() { }
    public bool ConnectToPrintQueue(System.Printing.PrintQueue printer) { return default(bool); }
    public bool ConnectToPrintQueue(string printQueuePath) { return default(bool); }
    public bool DisconnectFromPrintQueue(System.Printing.PrintQueue printer) { return default(bool); }
    public bool DisconnectFromPrintQueue(string printQueuePath) { return default(bool); }
    public static System.Printing.PrintQueue GetDefaultPrintQueue() { return default(System.Printing.PrintQueue); }
    public sealed override void Refresh() { }
  }
  public enum LocalPrintServerIndexedProperty {
    BeepEnabled = 5,
    DefaultPortThreadPriority = 2,
    DefaultPrintQueue = 12,
    DefaultSchedulerPriority = 4,
    DefaultSpoolDirectory = 0,
    EventLog = 7,
    MajorVersion = 8,
    MinorVersion = 9,
    NetPopup = 6,
    PortThreadPriority = 1,
    RestartJobOnPoolEnabled = 11,
    RestartJobOnPoolTimeout = 10,
    SchedulerPriority = 3,
  }
  public partial class PrintDocumentImageableArea {
    internal PrintDocumentImageableArea() { }
    public double ExtentHeight { get { return default(double); } }
    public double ExtentWidth { get { return default(double); } }
    public double MediaSizeHeight { get { return default(double); } }
    public double MediaSizeWidth { get { return default(double); } }
    public double OriginHeight { get { return default(double); } }
    public double OriginWidth { get { return default(double); } }
  }
  public sealed partial class PrintDriver : System.Printing.PrintFilter {
    internal PrintDriver() { }
    public sealed override void Commit() { }
    [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
    protected sealed override void InternalDispose(bool disposing) { }
    public sealed override void Refresh() { }
  }
  public abstract partial class PrintFilter : System.Printing.PrintSystemObject {
    internal PrintFilter() { }
    [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
    protected override void InternalDispose(bool disposing) { }
  }
  public partial class PrintJobInfoCollection : System.Printing.PrintSystemObjects, System.Collections.Generic.IEnumerable<System.Printing.PrintSystemJobInfo>, System.Collections.IEnumerable, System.IDisposable {
    public PrintJobInfoCollection(System.Printing.PrintQueue printQueue, System.String[] propertyFilter) { }
    public void Add(System.Printing.PrintSystemJobInfo printObject) { }
    [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
    protected override void Dispose(bool A_0) { }
    public virtual System.Collections.Generic.IEnumerator<System.Printing.PrintSystemJobInfo> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Printing.PrintSystemJobInfo>); }
    virtual System.Collections.IEnumerator GetNonGenericEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public enum PrintJobPriority {
    Default = 1,
    Maximum = 99,
    Minimum = 1,
    None = 0,
  }
  public partial class PrintJobSettings {
    internal PrintJobSettings() { }
    public System.Printing.PrintTicket CurrentPrintTicket { [System.Security.SecuritySafeCriticalAttribute]get { return default(System.Printing.PrintTicket); } [System.Security.SecuritySafeCriticalAttribute]set { } }
    public string Description { get { return default(string); } set { } }
  }
  [System.FlagsAttribute]
  public enum PrintJobStatus {
    Blocked = 512,
    Completed = 4096,
    Deleted = 256,
    Deleting = 4,
    Error = 2,
    None = 0,
    Offline = 32,
    PaperOut = 64,
    Paused = 1,
    Printed = 128,
    Printing = 16,
    Restarted = 2048,
    Retained = 8192,
    Spooling = 8,
    UserIntervention = 1024,
  }
  public enum PrintJobType {
    Legacy = 2,
    None = 0,
    Xps = 1,
  }
  public sealed partial class PrintPort : System.Printing.PrintSystemObject {
    internal PrintPort() { }
    public sealed override void Commit() { }
    [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
    protected sealed override void InternalDispose(bool disposing) { }
    public sealed override void Refresh() { }
  }
  public sealed partial class PrintProcessor : System.Printing.PrintFilter {
    internal PrintProcessor() { }
    public sealed override void Commit() { }
    [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
    protected sealed override void InternalDispose(bool disposing) { }
    public sealed override void Refresh() { }
  }
  [System.Drawing.Printing.PrintingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Drawing.Printing.PrintingPermissionLevel)(2))]
  public partial class PrintQueue : System.Printing.PrintSystemObject {
    [System.Security.SecuritySafeCriticalAttribute]
    public PrintQueue(System.Printing.PrintServer printServer, string printQueueName) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public PrintQueue(System.Printing.PrintServer printServer, string printQueueName, int printSchemaVersion) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public PrintQueue(System.Printing.PrintServer printServer, string printQueueName, int printSchemaVersion, System.Printing.PrintSystemDesiredAccess desiredAccess) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public PrintQueue(System.Printing.PrintServer printServer, string printQueueName, System.Printing.PrintQueueIndexedProperty[] propertyFilter) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public PrintQueue(System.Printing.PrintServer printServer, string printQueueName, System.Printing.PrintQueueIndexedProperty[] propertyFilter, System.Printing.PrintSystemDesiredAccess desiredAccess) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public PrintQueue(System.Printing.PrintServer printServer, string printQueueName, System.Printing.PrintSystemDesiredAccess desiredAccess) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public PrintQueue(System.Printing.PrintServer printServer, string printQueueName, System.String[] propertyFilter) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public PrintQueue(System.Printing.PrintServer printServer, string printQueueName, System.String[] propertyFilter, System.Printing.PrintSystemDesiredAccess desiredAccess) { }
    public virtual int AveragePagesPerMinute { get { return default(int); } }
    public int ClientPrintSchemaVersion { get { return default(int); } }
    public virtual string Comment { get { return default(string); } set { } }
    public System.Printing.PrintJobSettings CurrentJobSettings { [System.Security.SecuritySafeCriticalAttribute]get { return default(System.Printing.PrintJobSettings); } }
    public virtual System.Printing.PrintTicket DefaultPrintTicket { [System.Security.SecurityCriticalAttribute]get { return default(System.Printing.PrintTicket); } [System.Security.SecuritySafeCriticalAttribute]set { } }
    public virtual int DefaultPriority { get { return default(int); } set { } }
    public virtual string Description { get { return default(string); } }
    public string FullName { get { return default(string); } }
    public bool HasPaperProblem { get { return default(bool); } }
    public bool HasToner { get { return default(bool); } }
    public virtual System.Printing.PrintServer HostingPrintServer { get { return default(System.Printing.PrintServer); } protected set { } }
    public bool InPartialTrust { [System.Security.SecurityCriticalAttribute]get { return default(bool); } [System.Security.SecurityCriticalAttribute]set { } }
    public bool IsBidiEnabled { get { return default(bool); } }
    public bool IsBusy { get { return default(bool); } }
    public bool IsDevQueryEnabled { get { return default(bool); } }
    public bool IsDirect { get { return default(bool); } }
    public bool IsDoorOpened { get { return default(bool); } }
    public bool IsHidden { get { return default(bool); } }
    public bool IsInError { get { return default(bool); } }
    public bool IsInitializing { get { return default(bool); } }
    public bool IsIOActive { get { return default(bool); } }
    public bool IsManualFeedRequired { get { return default(bool); } }
    public bool IsNotAvailable { get { return default(bool); } }
    public bool IsOffline { get { return default(bool); } }
    public bool IsOutOfMemory { get { return default(bool); } }
    public bool IsOutOfPaper { get { return default(bool); } }
    public bool IsOutputBinFull { get { return default(bool); } }
    public bool IsPaperJammed { get { return default(bool); } }
    public bool IsPaused { get { return default(bool); } }
    public bool IsPendingDeletion { get { return default(bool); } }
    public bool IsPowerSaveOn { get { return default(bool); } }
    public bool IsPrinting { get { return default(bool); } }
    public bool IsProcessing { get { return default(bool); } }
    public bool IsPublished { get { return default(bool); } }
    public bool IsQueued { get { return default(bool); } }
    public bool IsRawOnlyEnabled { get { return default(bool); } }
    public bool IsServerUnknown { get { return default(bool); } }
    public bool IsShared { get { return default(bool); } }
    public bool IsTonerLow { get { return default(bool); } }
    public bool IsWaiting { get { return default(bool); } }
    public bool IsWarmingUp { get { return default(bool); } }
    public bool IsXpsDevice { [System.Security.SecurityCriticalAttribute]get { return default(bool); } }
    public bool KeepPrintedJobs { get { return default(bool); } }
    public virtual string Location { get { return default(string); } set { } }
    public static int MaxPrintSchemaVersion { [System.Security.SecuritySafeCriticalAttribute]get { return default(int); } }
    public sealed override string Name { get { return default(string); } set { } }
    public bool NeedUserIntervention { get { return default(bool); } }
    public virtual int NumberOfJobs { get { return default(int); } }
    public bool PagePunt { get { return default(bool); } }
    public bool PrintingIsCancelled { get { return default(bool); } set { } }
    public virtual int Priority { get { return default(int); } set { } }
    public System.Printing.PrintQueueAttributes QueueAttributes { get { return default(System.Printing.PrintQueueAttributes); } }
    public virtual System.Printing.PrintDriver QueueDriver { get { return default(System.Printing.PrintDriver); } set { } }
    public virtual System.Printing.PrintPort QueuePort { get { return default(System.Printing.PrintPort); } set { } }
    public virtual System.Printing.PrintProcessor QueuePrintProcessor { get { return default(System.Printing.PrintProcessor); } set { } }
    public System.Printing.PrintQueueStatus QueueStatus { get { return default(System.Printing.PrintQueueStatus); } }
    public bool ScheduleCompletedJobsFirst { get { return default(bool); } }
    public virtual string SeparatorFile { get { return default(string); } set { } }
    public virtual string ShareName { get { return default(string); } set { } }
    public virtual int StartTimeOfDay { get { return default(int); } set { } }
    public virtual int UntilTimeOfDay { get { return default(int); } set { } }
    public virtual System.Printing.PrintTicket UserPrintTicket { [System.Security.SecurityCriticalAttribute]get { return default(System.Printing.PrintTicket); } [System.Security.SecuritySafeCriticalAttribute]set { } }
    [System.Security.SecuritySafeCriticalAttribute]
    public System.Printing.PrintSystemJobInfo AddJob() { return default(System.Printing.PrintSystemJobInfo); }
    [System.Security.SecuritySafeCriticalAttribute]
    public System.Printing.PrintSystemJobInfo AddJob(string jobName) { return default(System.Printing.PrintSystemJobInfo); }
    [System.Security.SecuritySafeCriticalAttribute]
    public System.Printing.PrintSystemJobInfo AddJob(string jobName, System.Printing.PrintTicket printTicket) { return default(System.Printing.PrintSystemJobInfo); }
    [System.Security.SecuritySafeCriticalAttribute]
    public System.Printing.PrintSystemJobInfo AddJob(string jobName, string documentPath, bool fastCopy) { return default(System.Printing.PrintSystemJobInfo); }
    [System.Security.SecuritySafeCriticalAttribute]
    public System.Printing.PrintSystemJobInfo AddJob(string jobName, string documentPath, bool fastCopy, System.Printing.PrintTicket printTicket) { return default(System.Printing.PrintSystemJobInfo); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override void Commit() { }
    [System.Security.SecurityCriticalAttribute]
    public static System.Windows.Xps.XpsDocumentWriter CreateXpsDocumentWriter(ref double width, ref double height) { return default(System.Windows.Xps.XpsDocumentWriter); }
    [System.Security.SecurityCriticalAttribute]
    public static System.Windows.Xps.XpsDocumentWriter CreateXpsDocumentWriter(ref System.Printing.PrintDocumentImageableArea documentImageableArea) { return default(System.Windows.Xps.XpsDocumentWriter); }
    [System.Security.SecurityCriticalAttribute]
    public static System.Windows.Xps.XpsDocumentWriter CreateXpsDocumentWriter(ref System.Printing.PrintDocumentImageableArea documentImageableArea, ref System.Windows.Controls.PageRangeSelection pageRangeSelection, ref System.Windows.Controls.PageRange pageRange) { return default(System.Windows.Xps.XpsDocumentWriter); }
    public static System.Windows.Xps.XpsDocumentWriter CreateXpsDocumentWriter(System.Printing.PrintQueue printQueue) { return default(System.Windows.Xps.XpsDocumentWriter); }
    [System.Security.SecurityCriticalAttribute]
    public static System.Windows.Xps.XpsDocumentWriter CreateXpsDocumentWriter(string jobDescription, ref System.Printing.PrintDocumentImageableArea documentImageableArea) { return default(System.Windows.Xps.XpsDocumentWriter); }
    [System.Security.SecurityCriticalAttribute]
    public static System.Windows.Xps.XpsDocumentWriter CreateXpsDocumentWriter(string jobDescription, ref System.Printing.PrintDocumentImageableArea documentImageableArea, ref System.Windows.Controls.PageRangeSelection pageRangeSelection, ref System.Windows.Controls.PageRange pageRange) { return default(System.Windows.Xps.XpsDocumentWriter); }
    public System.Printing.PrintSystemJobInfo GetJob(int jobId) { return default(System.Printing.PrintSystemJobInfo); }
    [System.Security.SecuritySafeCriticalAttribute]
    public System.Printing.PrintCapabilities GetPrintCapabilities() { return default(System.Printing.PrintCapabilities); }
    [System.Security.SecurityCriticalAttribute]
    public System.Printing.PrintCapabilities GetPrintCapabilities(System.Printing.PrintTicket printTicket) { return default(System.Printing.PrintCapabilities); }
    [System.Security.SecuritySafeCriticalAttribute]
    public System.IO.MemoryStream GetPrintCapabilitiesAsXml() { return default(System.IO.MemoryStream); }
    [System.Security.SecuritySafeCriticalAttribute]
    public System.IO.MemoryStream GetPrintCapabilitiesAsXml(System.Printing.PrintTicket printTicket) { return default(System.IO.MemoryStream); }
    public System.Printing.PrintJobInfoCollection GetPrintJobInfoCollection() { return default(System.Printing.PrintJobInfoCollection); }
    [System.Security.SecurityCriticalAttribute]
    protected sealed override void InternalDispose(bool disposing) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public System.Printing.ValidationResult MergeAndValidatePrintTicket(System.Printing.PrintTicket basePrintTicket, System.Printing.PrintTicket deltaPrintTicket) { return default(System.Printing.ValidationResult); }
    [System.Security.SecuritySafeCriticalAttribute]
    public System.Printing.ValidationResult MergeAndValidatePrintTicket(System.Printing.PrintTicket basePrintTicket, System.Printing.PrintTicket deltaPrintTicket, System.Printing.PrintTicketScope scope) { return default(System.Printing.ValidationResult); }
    public virtual void Pause() { }
    public virtual void Purge() { }
    public override void Refresh() { }
    public virtual void Resume() { }
  }
  [System.FlagsAttribute]
  public enum PrintQueueAttributes {
    Direct = 2,
    EnableBidi = 2048,
    EnableDevQuery = 128,
    Hidden = 32,
    KeepPrintedJobs = 256,
    None = 0,
    Published = 8192,
    Queued = 1,
    RawOnly = 4096,
    ScheduleCompletedJobsFirst = 512,
    Shared = 8,
  }
  public partial class PrintQueueCollection : System.Printing.PrintSystemObjects, System.Collections.Generic.IEnumerable<System.Printing.PrintQueue>, System.Collections.IEnumerable, System.IDisposable {
    public PrintQueueCollection() { }
    public PrintQueueCollection(System.Printing.PrintServer printServer, System.String[] propertyFilter) { }
    public PrintQueueCollection(System.Printing.PrintServer printServer, System.String[] propertyFilter, System.Printing.EnumeratedPrintQueueTypes[] enumerationFlag) { }
    public static object SyncRoot { get { return default(object); } }
    public void Add(System.Printing.PrintQueue printObject) { }
    [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
    protected override void Dispose(bool A_0) { }
    public virtual System.Collections.Generic.IEnumerator<System.Printing.PrintQueue> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Printing.PrintQueue>); }
    virtual System.Collections.IEnumerator GetNonGenericEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public enum PrintQueueIndexedProperty {
    AveragePagesPerMinute = 9,
    Comment = 2,
    DefaultPrintTicket = 19,
    DefaultPriority = 6,
    Description = 4,
    HostingPrintServer = 15,
    Location = 3,
    Name = 0,
    NumberOfJobs = 10,
    Priority = 5,
    QueueAttributes = 11,
    QueueDriver = 12,
    QueuePort = 13,
    QueuePrintProcessor = 14,
    QueueStatus = 16,
    SeparatorFile = 17,
    ShareName = 1,
    StartTimeOfDay = 7,
    UntilTimeOfDay = 8,
    UserPrintTicket = 18,
  }
  [System.FlagsAttribute]
  public enum PrintQueueStatus {
    Busy = 512,
    DoorOpen = 4194304,
    Error = 2,
    Initializing = 32768,
    IOActive = 256,
    ManualFeed = 32,
    None = 0,
    NotAvailable = 4096,
    NoToner = 262144,
    Offline = 128,
    OutOfMemory = 2097152,
    OutputBinFull = 2048,
    PagePunt = 524288,
    PaperJam = 8,
    PaperOut = 16,
    PaperProblem = 64,
    Paused = 1,
    PendingDeletion = 4,
    PowerSave = 16777216,
    Printing = 1024,
    Processing = 16384,
    ServerUnknown = 8388608,
    TonerLow = 131072,
    UserIntervention = 1048576,
    Waiting = 8192,
    WarmingUp = 65536,
  }
  public partial class PrintQueueStream : System.IO.Stream {
    [System.Security.SecurityCriticalAttribute]
    public PrintQueueStream(System.Printing.PrintQueue printQueue, string printJobName) { }
    [System.Security.SecurityCriticalAttribute]
    public PrintQueueStream(System.Printing.PrintQueue printQueue, string printJobName, bool commitDataOnClose) { }
    [System.Security.SecurityCriticalAttribute]
    public PrintQueueStream(System.Printing.PrintQueue printQueue, string printJobName, bool commitDataOnClose, System.Printing.PrintTicket printTicket) { }
    public override bool CanRead { get { return default(bool); } }
    public override bool CanSeek { get { return default(bool); } }
    public override bool CanWrite { get { return default(bool); } }
    public int JobIdentifier { [System.Security.SecurityCriticalAttribute]get { return default(int); } }
    public override long Length { [System.Security.SecurityCriticalAttribute]get { return default(long); } }
    public override long Position { [System.Security.SecurityCriticalAttribute]get { return default(long); } [System.Security.SecurityCriticalAttribute]set { } }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, ExternalThreading=true)]
    public override System.IAsyncResult BeginWrite(System.Byte[] buffer, int offset, int count, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    [System.Security.SecurityCriticalAttribute]
    public override void Close() { }
    [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
    protected override void Dispose(bool A_0) { }
    public override void EndWrite(System.IAsyncResult asyncResult) { }
    ~PrintQueueStream() { }
    [System.Security.SecurityCriticalAttribute]
    public override void Flush() { }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.SecurityTreatAsSafeAttribute]
    public void HandlePackagingProgressEvent(object sender, System.Windows.Xps.Packaging.PackagingProgressEventArgs e) { }
    [System.Security.SecurityCriticalAttribute]
    public override int Read(System.Byte[] buffer, int offset, int count) { return default(int); }
    [System.Security.SecurityCriticalAttribute]
    public override long Seek(long offset, System.IO.SeekOrigin origin) { return default(long); }
    public override void SetLength(long value) { }
    [System.Security.SecurityCriticalAttribute]
    public override void Write(System.Byte[] buffer, int offset, int count) { }
  }
  public partial class PrintQueueStringProperty {
    public PrintQueueStringProperty() { }
    public string Name { get { return default(string); } set { } }
    public System.Printing.PrintQueueStringPropertyType Type { get { return default(System.Printing.PrintQueueStringPropertyType); } set { } }
  }
  public enum PrintQueueStringPropertyType {
    Comment = 1,
    Location = 0,
    ShareName = 2,
  }
  public partial class PrintServer : System.Printing.PrintSystemObject {
    public PrintServer() { }
    public PrintServer(System.Printing.PrintSystemDesiredAccess desiredAccess) { }
    public PrintServer(string path) { }
    public PrintServer(string path, System.Printing.PrintServerIndexedProperty[] propertiesFilter) { }
    public PrintServer(string path, System.Printing.PrintServerIndexedProperty[] propertiesFilter, System.Printing.PrintSystemDesiredAccess desiredAccess) { }
    public PrintServer(string path, System.Printing.PrintSystemDesiredAccess desiredAccess) { }
    public PrintServer(string path, System.String[] propertiesFilter) { }
    public PrintServer(string path, System.String[] propertiesFilter, System.Printing.PrintSystemDesiredAccess desiredAccess) { }
    public bool BeepEnabled { get { return default(bool); } set { } }
    public System.Threading.ThreadPriority DefaultPortThreadPriority { get { return default(System.Threading.ThreadPriority); } }
    public System.Threading.ThreadPriority DefaultSchedulerPriority { get { return default(System.Threading.ThreadPriority); } }
    public string DefaultSpoolDirectory { get { return default(string); } set { } }
    public System.Printing.PrintServerEventLoggingTypes EventLog { get { return default(System.Printing.PrintServerEventLoggingTypes); } set { } }
    protected bool IsDelayInitialized { get { return default(bool); } set { } }
    public int MajorVersion { get { return default(int); } }
    public int MinorVersion { get { return default(int); } }
    public sealed override string Name { get { return default(string); } }
    public bool NetPopup { get { return default(bool); } set { } }
    public System.Threading.ThreadPriority PortThreadPriority { get { return default(System.Threading.ThreadPriority); } set { } }
    public bool RestartJobOnPoolEnabled { get { return default(bool); } set { } }
    public int RestartJobOnPoolTimeout { get { return default(int); } set { } }
    public System.Threading.ThreadPriority SchedulerPriority { get { return default(System.Threading.ThreadPriority); } set { } }
    public byte SubSystemVersion { get { return default(byte); } }
    public override void Commit() { }
    public static bool DeletePrintQueue(System.Printing.PrintQueue printQueue) { return default(bool); }
    public static bool DeletePrintQueue(string printQueueName) { return default(bool); }
    public System.Printing.PrintQueue GetPrintQueue(string printQueueName) { return default(System.Printing.PrintQueue); }
    public System.Printing.PrintQueue GetPrintQueue(string printQueueName, System.String[] propertiesFilter) { return default(System.Printing.PrintQueue); }
    public System.Printing.PrintQueueCollection GetPrintQueues() { return default(System.Printing.PrintQueueCollection); }
    public System.Printing.PrintQueueCollection GetPrintQueues(System.Printing.EnumeratedPrintQueueTypes[] enumerationFlag) { return default(System.Printing.PrintQueueCollection); }
    public System.Printing.PrintQueueCollection GetPrintQueues(System.Printing.PrintQueueIndexedProperty[] propertiesFilter) { return default(System.Printing.PrintQueueCollection); }
    public System.Printing.PrintQueueCollection GetPrintQueues(System.Printing.PrintQueueIndexedProperty[] propertiesFilter, System.Printing.EnumeratedPrintQueueTypes[] enumerationFlag) { return default(System.Printing.PrintQueueCollection); }
    public System.Printing.PrintQueueCollection GetPrintQueues(System.String[] propertiesFilter) { return default(System.Printing.PrintQueueCollection); }
    public System.Printing.PrintQueueCollection GetPrintQueues(System.String[] propertiesFilter, System.Printing.EnumeratedPrintQueueTypes[] enumerationFlag) { return default(System.Printing.PrintQueueCollection); }
    public System.Printing.PrintQueue InstallPrintQueue(string printQueueName, string driverName, System.String[] portNames, string printProcessorName, System.Printing.IndexedProperties.PrintPropertyDictionary initialParameters) { return default(System.Printing.PrintQueue); }
    public System.Printing.PrintQueue InstallPrintQueue(string printQueueName, string driverName, System.String[] portNames, string printProcessorName, System.Printing.PrintQueueAttributes printQueueAttributes) { return default(System.Printing.PrintQueue); }
    public System.Printing.PrintQueue InstallPrintQueue(string printQueueName, string driverName, System.String[] portNames, string printProcessorName, System.Printing.PrintQueueAttributes printQueueAttributes, System.Printing.PrintQueueStringProperty printQueueProperty, int printQueuePriority, int printQueueDefaultPriority) { return default(System.Printing.PrintQueue); }
    public System.Printing.PrintQueue InstallPrintQueue(string printQueueName, string driverName, System.String[] portNames, string printProcessorName, System.Printing.PrintQueueAttributes printQueueAttributes, string printQueueShareName, string printQueueComment, string printQueueLocation, string printQueueSeparatorFile, int printQueuePriority, int printQueueDefaultPriority) { return default(System.Printing.PrintQueue); }
    [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
    [System.Security.SecurityCriticalAttribute]
    protected sealed override void InternalDispose(bool disposing) { }
    public override void Refresh() { }
  }
  [System.FlagsAttribute]
  public enum PrintServerEventLoggingTypes {
    LogAllPrintingEvents = 5,
    LogPrintingErrorEvents = 2,
    LogPrintingInformationEvents = 4,
    LogPrintingSuccessEvents = 1,
    LogPrintingWarningEvents = 3,
    None = 0,
  }
  public enum PrintServerIndexedProperty {
    BeepEnabled = 5,
    DefaultPortThreadPriority = 2,
    DefaultSchedulerPriority = 4,
    DefaultSpoolDirectory = 0,
    EventLog = 7,
    MajorVersion = 8,
    MinorVersion = 9,
    NetPopup = 6,
    PortThreadPriority = 1,
    RestartJobOnPoolEnabled = 11,
    RestartJobOnPoolTimeout = 10,
    SchedulerPriority = 3,
  }
  public enum PrintSystemDesiredAccess {
    AdministratePrinter = 983052,
    AdministrateServer = 983041,
    EnumerateServer = 131074,
    None = 0,
    UsePrinter = 131080,
  }
  public partial class PrintSystemJobInfo : System.Printing.PrintSystemObject {
    internal PrintSystemJobInfo() { }
    public System.Printing.PrintQueue HostingPrintQueue { get { return default(System.Printing.PrintQueue); } }
    public System.Printing.PrintServer HostingPrintServer { get { return default(System.Printing.PrintServer); } }
    public bool IsBlocked { get { return default(bool); } }
    public bool IsCompleted { get { return default(bool); } }
    public bool IsDeleted { get { return default(bool); } }
    public bool IsDeleting { get { return default(bool); } }
    public bool IsInError { get { return default(bool); } }
    public bool IsOffline { get { return default(bool); } }
    public bool IsPaperOut { get { return default(bool); } }
    public bool IsPaused { get { return default(bool); } }
    public bool IsPrinted { get { return default(bool); } }
    public bool IsPrinting { get { return default(bool); } }
    public bool IsRestarted { get { return default(bool); } }
    public bool IsRetained { get { return default(bool); } }
    public bool IsSpooling { get { return default(bool); } }
    public bool IsUserInterventionRequired { get { return default(bool); } }
    public int JobIdentifier { get { return default(int); } }
    public string JobName { get { return default(string); } set { } }
    public int JobSize { get { return default(int); } }
    public System.Printing.PrintJobStatus JobStatus { get { return default(System.Printing.PrintJobStatus); } }
    public System.IO.Stream JobStream { get { return default(System.IO.Stream); } }
    public int NumberOfPages { get { return default(int); } }
    public int NumberOfPagesPrinted { get { return default(int); } }
    public int PositionInPrintQueue { get { return default(int); } }
    public System.Printing.PrintJobPriority Priority { get { return default(System.Printing.PrintJobPriority); } }
    public int StartTimeOfDay { get { return default(int); } }
    public string Submitter { get { return default(string); } }
    public System.DateTime TimeJobSubmitted { get { return default(System.DateTime); } }
    public int TimeSinceStartedPrinting { get { return default(int); } }
    public int UntilTimeOfDay { get { return default(int); } }
    public void Cancel() { }
    public override void Commit() { }
    public static System.Printing.PrintSystemJobInfo Get(System.Printing.PrintQueue printQueue, int jobIdentifier) { return default(System.Printing.PrintSystemJobInfo); }
    [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
    protected sealed override void InternalDispose(bool disposing) { }
    public void Pause() { }
    public override void Refresh() { }
    public void Restart() { }
    public void Resume() { }
  }
  public abstract partial class PrintSystemObject : System.IDisposable {
    protected PrintSystemObject() { }
    protected PrintSystemObject(System.Printing.PrintSystemObjectLoadMode mode) { }
    protected bool IsDisposed { get { return default(bool); } set { } }
    public virtual string Name { get { return default(string); } }
    public virtual System.Printing.PrintSystemObject Parent { get { return default(System.Printing.PrintSystemObject); } }
    public System.Printing.IndexedProperties.PrintPropertyDictionary PropertiesCollection { get { return default(System.Printing.IndexedProperties.PrintPropertyDictionary); } }
    protected static System.String[] BaseAttributeNames() { return default(System.String[]); }
    public abstract void Commit();
    public sealed override void Dispose() { }
    [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
    protected virtual void Dispose(bool A_0) { }
    ~PrintSystemObject() { }
    protected void Initialize() { }
    [System.Security.SecurityCriticalAttribute]
    protected virtual void InternalDispose(bool disposing) { }
    public abstract void Refresh();
  }
  public enum PrintSystemObjectLoadMode {
    LoadInitialized = 2,
    LoadUninitialized = 1,
    None = 0,
  }
  public partial class PrintSystemObjectPropertiesChangedEventArgs : System.EventArgs, System.IDisposable {
    public PrintSystemObjectPropertiesChangedEventArgs(System.Collections.Specialized.StringCollection events) { }
    public System.Collections.Specialized.StringCollection PropertiesNames { get { return default(System.Collections.Specialized.StringCollection); } }
    public sealed override void Dispose() { }
    protected virtual void Dispose(bool A_0) { }
  }
  public partial class PrintSystemObjectPropertyChangedEventArgs : System.EventArgs, System.IDisposable {
    public PrintSystemObjectPropertyChangedEventArgs(string eventName) { }
    public string PropertyName { get { return default(string); } }
    public sealed override void Dispose() { }
    protected virtual void Dispose(bool A_0) { }
  }
  public abstract partial class PrintSystemObjects : System.IDisposable {
    protected PrintSystemObjects() { }
    public sealed override void Dispose() { }
    protected virtual void Dispose(bool A_0) { }
  }
}
namespace System.Printing.IndexedProperties {
  public sealed partial class PrintBooleanProperty : System.Printing.IndexedProperties.PrintProperty {
    public PrintBooleanProperty(string attributeName) : base (default(string)) { }
    public PrintBooleanProperty(string attributeName, object attributeValue) : base (default(string)) { }
    public override object Value { get { return default(object); } [System.Security.SecurityCriticalAttribute]set { } }
    [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
    protected sealed override void InternalDispose(bool disposing) { }
    public static implicit operator bool (System.Printing.IndexedProperties.PrintBooleanProperty attribRef) { return default(bool); }
    public static implicit operator bool (System.Printing.IndexedProperties.PrintBooleanProperty attribRef) { return default(bool); }
  }
  public sealed partial class PrintByteArrayProperty : System.Printing.IndexedProperties.PrintProperty {
    public PrintByteArrayProperty(string attributeName) : base (default(string)) { }
    public PrintByteArrayProperty(string attributeName, object attributeValue) : base (default(string)) { }
    public override object Value { get { return default(object); } set { } }
    [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
    protected sealed override void InternalDispose(bool disposing) { }
    public static implicit operator System.Byte[] (System.Printing.IndexedProperties.PrintByteArrayProperty attribRef) { return default(System.Byte[]); }
    public static implicit operator System.Byte[] (System.Printing.IndexedProperties.PrintByteArrayProperty attribRef) { return default(System.Byte[]); }
  }
  public sealed partial class PrintDateTimeProperty : System.Printing.IndexedProperties.PrintProperty {
    public PrintDateTimeProperty(string attributeName) : base (default(string)) { }
    public PrintDateTimeProperty(string attributeName, object attributeValue) : base (default(string)) { }
    public override object Value { get { return default(object); } set { } }
    [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
    protected sealed override void InternalDispose(bool disposing) { }
    public static implicit operator System.ValueType (System.Printing.IndexedProperties.PrintDateTimeProperty attribRef) { return default(System.ValueType); }
    public static implicit operator System.ValueType (System.Printing.IndexedProperties.PrintDateTimeProperty attribRef) { return default(System.ValueType); }
  }
  public sealed partial class PrintDriverProperty : System.Printing.IndexedProperties.PrintProperty {
    public PrintDriverProperty(string attributeName) : base (default(string)) { }
    public PrintDriverProperty(string attributeName, object attributeValue) : base (default(string)) { }
    public override object Value { get { return default(object); } set { } }
    [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
    protected sealed override void InternalDispose(bool disposing) { }
    public static implicit operator System.Printing.PrintDriver (System.Printing.IndexedProperties.PrintDriverProperty attribRef) { return default(System.Printing.PrintDriver); }
    public static implicit operator System.Printing.PrintDriver (System.Printing.IndexedProperties.PrintDriverProperty attribRef) { return default(System.Printing.PrintDriver); }
  }
  public sealed partial class PrintInt32Property : System.Printing.IndexedProperties.PrintProperty {
    public PrintInt32Property(string attributeName) : base (default(string)) { }
    public PrintInt32Property(string attributeName, object attributeValue) : base (default(string)) { }
    public override object Value { get { return default(object); } [System.Security.SecurityCriticalAttribute]set { } }
    [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
    protected sealed override void InternalDispose(bool disposing) { }
    public static implicit operator int (System.Printing.IndexedProperties.PrintInt32Property attribRef) { return default(int); }
    public static implicit operator int (System.Printing.IndexedProperties.PrintInt32Property attribRef) { return default(int); }
  }
  public sealed partial class PrintJobPriorityProperty : System.Printing.IndexedProperties.PrintProperty {
    public PrintJobPriorityProperty(string attributeName) : base (default(string)) { }
    public PrintJobPriorityProperty(string attributeName, object attributeValue) : base (default(string)) { }
    public override object Value { get { return default(object); } set { } }
    [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
    protected sealed override void InternalDispose(bool disposing) { }
    public static implicit operator System.Printing.PrintJobPriority (System.Printing.IndexedProperties.PrintJobPriorityProperty attribRef) { return default(System.Printing.PrintJobPriority); }
    public static implicit operator System.Printing.PrintJobPriority (System.Printing.IndexedProperties.PrintJobPriorityProperty attribRef) { return default(System.Printing.PrintJobPriority); }
  }
  public sealed partial class PrintJobStatusProperty : System.Printing.IndexedProperties.PrintProperty {
    public PrintJobStatusProperty(string attributeName) : base (default(string)) { }
    public PrintJobStatusProperty(string attributeName, object attributeValue) : base (default(string)) { }
    public override object Value { get { return default(object); } set { } }
    [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
    protected sealed override void InternalDispose(bool disposing) { }
    public static implicit operator System.Printing.PrintJobStatus (System.Printing.IndexedProperties.PrintJobStatusProperty attribRef) { return default(System.Printing.PrintJobStatus); }
    public static implicit operator System.Printing.PrintJobStatus (System.Printing.IndexedProperties.PrintJobStatusProperty attribRef) { return default(System.Printing.PrintJobStatus); }
  }
  public sealed partial class PrintPortProperty : System.Printing.IndexedProperties.PrintProperty {
    public PrintPortProperty(string attributeName) : base (default(string)) { }
    public PrintPortProperty(string attributeName, object attributeValue) : base (default(string)) { }
    public override object Value { get { return default(object); } set { } }
    [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
    protected sealed override void InternalDispose(bool disposing) { }
    public static implicit operator System.Printing.PrintPort (System.Printing.IndexedProperties.PrintPortProperty attribRef) { return default(System.Printing.PrintPort); }
    public static implicit operator System.Printing.PrintPort (System.Printing.IndexedProperties.PrintPortProperty attribRef) { return default(System.Printing.PrintPort); }
  }
  public sealed partial class PrintProcessorProperty : System.Printing.IndexedProperties.PrintProperty {
    public PrintProcessorProperty(string attributeName) : base (default(string)) { }
    public PrintProcessorProperty(string attributeName, object attributeValue) : base (default(string)) { }
    public override object Value { get { return default(object); } set { } }
    [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
    protected sealed override void InternalDispose(bool disposing) { }
    public static implicit operator System.Printing.PrintProcessor (System.Printing.IndexedProperties.PrintProcessorProperty attribRef) { return default(System.Printing.PrintProcessor); }
    public static implicit operator System.Printing.PrintProcessor (System.Printing.IndexedProperties.PrintProcessorProperty attribRef) { return default(System.Printing.PrintProcessor); }
  }
  public abstract partial class PrintProperty : System.IDisposable, System.Runtime.Serialization.IDeserializationCallback {
    protected PrintProperty(string attributeName) { }
    protected bool IsDisposed { get { return default(bool); } set { } }
    protected internal bool IsInitialized { protected set { } }
    public virtual string Name { get { return default(string); } }
    public abstract object Value { get; set; }
    public sealed override void Dispose() { }
    [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
    protected virtual void Dispose(bool A_0) { }
    ~PrintProperty() { }
    protected virtual void InternalDispose(bool disposing) { }
    public virtual void OnDeserialization(object sender) { }
  }
  public partial class PrintPropertyDictionary : System.Collections.Hashtable, System.IDisposable, System.Runtime.Serialization.IDeserializationCallback, System.Runtime.Serialization.ISerializable {
    public PrintPropertyDictionary() { }
    protected PrintPropertyDictionary(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public void Add(System.Printing.IndexedProperties.PrintProperty attributeValue) { }
    public sealed override void Dispose() { }
    protected virtual void Dispose(bool A_0) { }
    [System.Security.SecurityCriticalAttribute]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public System.Printing.IndexedProperties.PrintProperty GetProperty(string attribName) { return default(System.Printing.IndexedProperties.PrintProperty); }
    public override void OnDeserialization(object sender) { }
    public void SetProperty(string attribName, System.Printing.IndexedProperties.PrintProperty attribValue) { }
  }
  public sealed partial class PrintQueueAttributeProperty : System.Printing.IndexedProperties.PrintProperty {
    public PrintQueueAttributeProperty(string attributeName) : base (default(string)) { }
    public PrintQueueAttributeProperty(string attributeName, object attributeValue) : base (default(string)) { }
    public override object Value { get { return default(object); } set { } }
    [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
    protected sealed override void InternalDispose(bool disposing) { }
    public static implicit operator System.Printing.PrintQueueAttributes (System.Printing.IndexedProperties.PrintQueueAttributeProperty attributeRef) { return default(System.Printing.PrintQueueAttributes); }
    public static implicit operator System.Printing.PrintQueueAttributes (System.Printing.IndexedProperties.PrintQueueAttributeProperty attributeRef) { return default(System.Printing.PrintQueueAttributes); }
  }
  public sealed partial class PrintQueueProperty : System.Printing.IndexedProperties.PrintProperty {
    public PrintQueueProperty(string attributeName) : base (default(string)) { }
    public PrintQueueProperty(string attributeName, object attributeValue) : base (default(string)) { }
    public override object Value { get { return default(object); } set { } }
    [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
    protected sealed override void InternalDispose(bool disposing) { }
    public static implicit operator System.Printing.PrintQueue (System.Printing.IndexedProperties.PrintQueueProperty attribRef) { return default(System.Printing.PrintQueue); }
    public static implicit operator System.Printing.PrintQueue (System.Printing.IndexedProperties.PrintQueueProperty attribRef) { return default(System.Printing.PrintQueue); }
  }
  public sealed partial class PrintQueueStatusProperty : System.Printing.IndexedProperties.PrintProperty {
    public PrintQueueStatusProperty(string attributeName) : base (default(string)) { }
    public PrintQueueStatusProperty(string attributeName, object attributeValue) : base (default(string)) { }
    public override object Value { get { return default(object); } set { } }
    [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
    protected sealed override void InternalDispose(bool disposing) { }
    public static implicit operator System.Printing.PrintQueueStatus (System.Printing.IndexedProperties.PrintQueueStatusProperty attributeRef) { return default(System.Printing.PrintQueueStatus); }
    public static implicit operator System.Printing.PrintQueueStatus (System.Printing.IndexedProperties.PrintQueueStatusProperty attributeRef) { return default(System.Printing.PrintQueueStatus); }
  }
  public sealed partial class PrintServerLoggingProperty : System.Printing.IndexedProperties.PrintProperty {
    public PrintServerLoggingProperty(string attributeName) : base (default(string)) { }
    public PrintServerLoggingProperty(string attributeName, object attributeValue) : base (default(string)) { }
    public override object Value { get { return default(object); } [System.Security.SecurityCriticalAttribute]set { } }
    [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
    protected sealed override void InternalDispose(bool disposing) { }
    public static implicit operator System.Printing.PrintServerEventLoggingTypes (System.Printing.IndexedProperties.PrintServerLoggingProperty attribRef) { return default(System.Printing.PrintServerEventLoggingTypes); }
    public static implicit operator System.Printing.PrintServerEventLoggingTypes (System.Printing.IndexedProperties.PrintServerLoggingProperty attribRef) { return default(System.Printing.PrintServerEventLoggingTypes); }
  }
  public sealed partial class PrintServerProperty : System.Printing.IndexedProperties.PrintProperty {
    public PrintServerProperty(string attributeName) : base (default(string)) { }
    public PrintServerProperty(string attributeName, object attributeValue) : base (default(string)) { }
    public override object Value { get { return default(object); } set { } }
    [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
    protected sealed override void InternalDispose(bool disposing) { }
    public static implicit operator System.Printing.PrintServer (System.Printing.IndexedProperties.PrintServerProperty attribRef) { return default(System.Printing.PrintServer); }
    public static implicit operator System.Printing.PrintServer (System.Printing.IndexedProperties.PrintServerProperty attribRef) { return default(System.Printing.PrintServer); }
  }
  public sealed partial class PrintStreamProperty : System.Printing.IndexedProperties.PrintProperty {
    public PrintStreamProperty(string attributeName) : base (default(string)) { }
    public PrintStreamProperty(string attributeName, object attributeValue) : base (default(string)) { }
    public override object Value { get { return default(object); } set { } }
    [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
    protected sealed override void InternalDispose(bool disposing) { }
    public static implicit operator System.IO.Stream (System.Printing.IndexedProperties.PrintStreamProperty attributeRef) { return default(System.IO.Stream); }
    public static implicit operator System.IO.Stream (System.Printing.IndexedProperties.PrintStreamProperty attributeRef) { return default(System.IO.Stream); }
  }
  public sealed partial class PrintStringProperty : System.Printing.IndexedProperties.PrintProperty {
    public PrintStringProperty(string attributeName) : base (default(string)) { }
    public PrintStringProperty(string attributeName, object attributeValue) : base (default(string)) { }
    public override object Value { get { return default(object); } set { } }
    [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
    protected sealed override void InternalDispose(bool disposing) { }
    public static implicit operator string (System.Printing.IndexedProperties.PrintStringProperty attributeRef) { return default(string); }
    public static implicit operator string (System.Printing.IndexedProperties.PrintStringProperty attributeRef) { return default(string); }
  }
  public sealed partial class PrintSystemTypeProperty : System.Printing.IndexedProperties.PrintProperty {
    public PrintSystemTypeProperty(string attributeName) : base (default(string)) { }
    public PrintSystemTypeProperty(string attributeName, object attributeValue) : base (default(string)) { }
    public override object Value { get { return default(object); } set { } }
    [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
    protected sealed override void InternalDispose(bool disposing) { }
    public static implicit operator System.Type (System.Printing.IndexedProperties.PrintSystemTypeProperty attribRef) { return default(System.Type); }
    public static implicit operator System.Type (System.Printing.IndexedProperties.PrintSystemTypeProperty attribRef) { return default(System.Type); }
  }
  public sealed partial class PrintThreadPriorityProperty : System.Printing.IndexedProperties.PrintProperty {
    public PrintThreadPriorityProperty(string attributeName) : base (default(string)) { }
    public PrintThreadPriorityProperty(string attributeName, object attributeValue) : base (default(string)) { }
    public override object Value { get { return default(object); } [System.Security.SecurityCriticalAttribute]set { } }
    [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
    protected sealed override void InternalDispose(bool disposing) { }
    public static implicit operator System.Threading.ThreadPriority (System.Printing.IndexedProperties.PrintThreadPriorityProperty attribRef) { return default(System.Threading.ThreadPriority); }
    public static implicit operator System.Threading.ThreadPriority (System.Printing.IndexedProperties.PrintThreadPriorityProperty attribRef) { return default(System.Threading.ThreadPriority); }
  }
  public sealed partial class PrintTicketProperty : System.Printing.IndexedProperties.PrintProperty {
    [System.Security.SecuritySafeCriticalAttribute]
    public PrintTicketProperty(string attributeName) : base (default(string)) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public PrintTicketProperty(string attributeName, object attributeValue) : base (default(string)) { }
    public override object Value { [System.Security.SecuritySafeCriticalAttribute]get { return default(object); } [System.Security.SecuritySafeCriticalAttribute]set { } }
    [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
    [System.Security.SecuritySafeCriticalAttribute]
    protected sealed override void InternalDispose(bool disposing) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public static implicit operator System.Printing.PrintTicket (System.Printing.IndexedProperties.PrintTicketProperty attribRef) { return default(System.Printing.PrintTicket); }
    [System.Security.SecuritySafeCriticalAttribute]
    public static implicit operator System.Printing.PrintTicket (System.Printing.IndexedProperties.PrintTicketProperty attribRef) { return default(System.Printing.PrintTicket); }
  }
}
namespace System.Windows.Xps {
  public partial class VisualsToXpsDocument : System.Windows.Documents.Serialization.SerializerWriterCollator {
    internal VisualsToXpsDocument() { }
    public override void BeginBatchWrite() { }
    [System.Security.SecuritySafeCriticalAttribute]
    public override void Cancel() { }
    [System.Security.SecuritySafeCriticalAttribute]
    public override void CancelAsync() { }
    [System.Security.SecuritySafeCriticalAttribute]
    public override void EndBatchWrite() { }
    public override void Write(System.Windows.Media.Visual visual) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public override void Write(System.Windows.Media.Visual visual, System.Printing.PrintTicket printTicket) { }
    public override void WriteAsync(System.Windows.Media.Visual visual) { }
    public override void WriteAsync(System.Windows.Media.Visual visual, object userSuppliedState) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public override void WriteAsync(System.Windows.Media.Visual visual, System.Printing.PrintTicket printTicket) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public override void WriteAsync(System.Windows.Media.Visual visual, System.Printing.PrintTicket printTicket, object userSuppliedState) { }
  }
  public enum XpsDocumentNotificationLevel {
    None = 0,
    ReceiveNotificationDisabled = 2,
    ReceiveNotificationEnabled = 1,
  }
  public partial class XpsDocumentWriter : System.Windows.Documents.Serialization.SerializerWriter {
    internal XpsDocumentWriter() { }
    public override event System.Windows.Documents.Serialization.WritingCancelledEventHandler WritingCancelled { add { } remove { } }
    public virtual event System.Windows.Documents.Serialization.WritingCompletedEventHandler WritingCompleted { add { } remove { } }
    public override event System.Windows.Documents.Serialization.WritingPrintTicketRequiredEventHandler WritingPrintTicketRequired { add { } remove { } }
    public override event System.Windows.Documents.Serialization.WritingProgressChangedEventHandler WritingProgressChanged { add { } remove { } }
    [System.Security.SecuritySafeCriticalAttribute]
    public override void CancelAsync() { }
    [System.Security.SecuritySafeCriticalAttribute]
    public override System.Windows.Documents.Serialization.SerializerWriterCollator CreateVisualsCollator() { return default(System.Windows.Documents.Serialization.SerializerWriterCollator); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override System.Windows.Documents.Serialization.SerializerWriterCollator CreateVisualsCollator(System.Printing.PrintTicket documentSequencePrintTicket, System.Printing.PrintTicket documentPrintTicket) { return default(System.Windows.Documents.Serialization.SerializerWriterCollator); }
    protected void raise__WritingCancelled(object value0, System.Windows.Documents.Serialization.WritingCancelledEventArgs value1) { }
    protected void raise__WritingCompleted(object value0, System.Windows.Documents.Serialization.WritingCompletedEventArgs value1) { }
    protected void raise__WritingProgressChanged(object value0, System.Windows.Documents.Serialization.WritingProgressChangedEventArgs value1) { }
    public virtual void raise_WritingCancelled(object sender, System.Windows.Documents.Serialization.WritingCancelledEventArgs args) { }
    public virtual void raise_WritingCompleted(object sender, System.Windows.Documents.Serialization.WritingCompletedEventArgs e) { }
    public virtual void raise_WritingPrintTicketRequired(object sender, System.Windows.Documents.Serialization.WritingPrintTicketRequiredEventArgs e) { }
    public virtual void raise_WritingProgressChanged(object sender, System.Windows.Documents.Serialization.WritingProgressChangedEventArgs e) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public void Write(string documentPath) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public void Write(string documentPath, System.Windows.Xps.XpsDocumentNotificationLevel notificationLevel) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public override void Write(System.Windows.Documents.DocumentPaginator documentPaginator) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public override void Write(System.Windows.Documents.DocumentPaginator documentPaginator, System.Printing.PrintTicket printTicket) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public override void Write(System.Windows.Documents.FixedDocument fixedDocument) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public override void Write(System.Windows.Documents.FixedDocument fixedDocument, System.Printing.PrintTicket printTicket) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public override void Write(System.Windows.Documents.FixedDocumentSequence fixedDocumentSequence) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public override void Write(System.Windows.Documents.FixedDocumentSequence fixedDocumentSequence, System.Printing.PrintTicket printTicket) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public override void Write(System.Windows.Documents.FixedPage fixedPage) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public override void Write(System.Windows.Documents.FixedPage fixedPage, System.Printing.PrintTicket printTicket) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public override void Write(System.Windows.Media.Visual visual) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public override void Write(System.Windows.Media.Visual visual, System.Printing.PrintTicket printTicket) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public void WriteAsync(string documentPath) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public void WriteAsync(string documentPath, System.Windows.Xps.XpsDocumentNotificationLevel notificationLevel) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public override void WriteAsync(System.Windows.Documents.DocumentPaginator documentPaginator) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public override void WriteAsync(System.Windows.Documents.DocumentPaginator documentPaginator, object userSuppliedState) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public override void WriteAsync(System.Windows.Documents.DocumentPaginator documentPaginator, System.Printing.PrintTicket printTicket) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public override void WriteAsync(System.Windows.Documents.DocumentPaginator documentPaginator, System.Printing.PrintTicket printTicket, object userSuppliedState) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public override void WriteAsync(System.Windows.Documents.FixedDocument fixedDocument) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public override void WriteAsync(System.Windows.Documents.FixedDocument fixedDocument, object userSuppliedState) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public override void WriteAsync(System.Windows.Documents.FixedDocument fixedDocument, System.Printing.PrintTicket printTicket) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public override void WriteAsync(System.Windows.Documents.FixedDocument fixedDocument, System.Printing.PrintTicket printTicket, object userSuppliedState) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public override void WriteAsync(System.Windows.Documents.FixedDocumentSequence fixedDocumentSequence) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public override void WriteAsync(System.Windows.Documents.FixedDocumentSequence fixedDocumentSequence, object userSuppliedState) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public override void WriteAsync(System.Windows.Documents.FixedDocumentSequence fixedDocumentSequence, System.Printing.PrintTicket printTicket) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public override void WriteAsync(System.Windows.Documents.FixedDocumentSequence fixedDocumentSequence, System.Printing.PrintTicket printTicket, object userSuppliedState) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public override void WriteAsync(System.Windows.Documents.FixedPage fixedPage) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public override void WriteAsync(System.Windows.Documents.FixedPage fixedPage, object userSuppliedState) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public override void WriteAsync(System.Windows.Documents.FixedPage fixedPage, System.Printing.PrintTicket printTicket) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public override void WriteAsync(System.Windows.Documents.FixedPage fixedPage, System.Printing.PrintTicket printTicket, object userSuppliedState) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public override void WriteAsync(System.Windows.Media.Visual visual) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public override void WriteAsync(System.Windows.Media.Visual visual, object userSuppliedState) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public override void WriteAsync(System.Windows.Media.Visual visual, System.Printing.PrintTicket printTicket) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public override void WriteAsync(System.Windows.Media.Visual visual, System.Printing.PrintTicket printTicket, object userSuppliedState) { }
  }
  public partial class XpsWriterException : System.Exception {
    public XpsWriterException() { }
    protected XpsWriterException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public XpsWriterException(string message) { }
    public XpsWriterException(string message, System.Exception innerException) { }
  }
}
