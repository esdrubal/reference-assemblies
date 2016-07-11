namespace System.IO.Log {
  public sealed partial class FileRecordSequence : System.IDisposable, System.IO.Log.IRecordSequence {
    public FileRecordSequence(string path) { }
    public FileRecordSequence(string path, System.IO.FileAccess access) { }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.Demand, Unrestricted=true)]
    public FileRecordSequence(string path, System.IO.FileAccess access, int size) { }
    public System.IO.Log.SequenceNumber BaseSequenceNumber { get { return default(System.IO.Log.SequenceNumber); } }
    public System.IO.Log.SequenceNumber LastSequenceNumber { get { return default(System.IO.Log.SequenceNumber); } }
    public long MaximumRecordLength { get { return default(long); } }
    public long ReservedBytes { get { return default(long); } }
    public System.IO.Log.SequenceNumber RestartSequenceNumber { get { return default(System.IO.Log.SequenceNumber); } }
    public bool RetryAppend { get { return default(bool); } set { } }
    public event System.EventHandler<System.IO.Log.TailPinnedEventArgs> TailPinned { add { } remove { } }
    public void AdvanceBaseSequenceNumber(System.IO.Log.SequenceNumber newBaseSequenceNumber) { }
    public System.IO.Log.SequenceNumber Append(System.ArraySegment<System.Byte> data, System.IO.Log.SequenceNumber nextUndoRecord, System.IO.Log.SequenceNumber previousRecord, System.IO.Log.RecordAppendOptions recordAppendOptions) { return default(System.IO.Log.SequenceNumber); }
    public System.IO.Log.SequenceNumber Append(System.ArraySegment<System.Byte> data, System.IO.Log.SequenceNumber nextUndoRecord, System.IO.Log.SequenceNumber previousRecord, System.IO.Log.RecordAppendOptions recordAppendOptions, System.IO.Log.ReservationCollection reservations) { return default(System.IO.Log.SequenceNumber); }
    public System.IO.Log.SequenceNumber Append(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> data, System.IO.Log.SequenceNumber nextUndoRecord, System.IO.Log.SequenceNumber previousRecord, System.IO.Log.RecordAppendOptions recordAppendOptions) { return default(System.IO.Log.SequenceNumber); }
    public System.IO.Log.SequenceNumber Append(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> data, System.IO.Log.SequenceNumber nextUndoRecord, System.IO.Log.SequenceNumber previousRecord, System.IO.Log.RecordAppendOptions recordAppendOptions, System.IO.Log.ReservationCollection reservations) { return default(System.IO.Log.SequenceNumber); }
    public System.IAsyncResult BeginAppend(System.ArraySegment<System.Byte> data, System.IO.Log.SequenceNumber nextUndoRecord, System.IO.Log.SequenceNumber previousRecord, System.IO.Log.RecordAppendOptions recordAppendOptions, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginAppend(System.ArraySegment<System.Byte> data, System.IO.Log.SequenceNumber nextUndoRecord, System.IO.Log.SequenceNumber previousRecord, System.IO.Log.RecordAppendOptions recordAppendOptions, System.IO.Log.ReservationCollection reservations, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginAppend(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> data, System.IO.Log.SequenceNumber nextUndoRecord, System.IO.Log.SequenceNumber previousRecord, System.IO.Log.RecordAppendOptions recordAppendOptions, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginAppend(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> data, System.IO.Log.SequenceNumber nextUndoRecord, System.IO.Log.SequenceNumber previousRecord, System.IO.Log.RecordAppendOptions recordAppendOptions, System.IO.Log.ReservationCollection reservations, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginFlush(System.IO.Log.SequenceNumber sequenceNumber, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginReserveAndAppend(System.ArraySegment<System.Byte> data, System.IO.Log.SequenceNumber nextUndoRecord, System.IO.Log.SequenceNumber previousRecord, System.IO.Log.RecordAppendOptions recordAppendOptions, System.IO.Log.ReservationCollection reservationCollection, System.Int64[] reservations, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginReserveAndAppend(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> data, System.IO.Log.SequenceNumber nextUndoRecord, System.IO.Log.SequenceNumber previousRecord, System.IO.Log.RecordAppendOptions recordAppendOptions, System.IO.Log.ReservationCollection reservationCollection, System.Int64[] reservations, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginWriteRestartArea(System.ArraySegment<System.Byte> data, System.IO.Log.SequenceNumber newBaseSeqNum, System.IO.Log.ReservationCollection reservation, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginWriteRestartArea(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> data, System.IO.Log.SequenceNumber newBaseSeqNum, System.IO.Log.ReservationCollection reservation, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IO.Log.ReservationCollection CreateReservationCollection() { return default(System.IO.Log.ReservationCollection); }
    public void Dispose() { }
    public System.IO.Log.SequenceNumber EndAppend(System.IAsyncResult result) { return default(System.IO.Log.SequenceNumber); }
    public System.IO.Log.SequenceNumber EndFlush(System.IAsyncResult result) { return default(System.IO.Log.SequenceNumber); }
    public System.IO.Log.SequenceNumber EndReserveAndAppend(System.IAsyncResult result) { return default(System.IO.Log.SequenceNumber); }
    public System.IO.Log.SequenceNumber EndWriteRestartArea(System.IAsyncResult result) { return default(System.IO.Log.SequenceNumber); }
    public System.IO.Log.SequenceNumber Flush() { return default(System.IO.Log.SequenceNumber); }
    public System.IO.Log.SequenceNumber Flush(System.IO.Log.SequenceNumber sequenceNumber) { return default(System.IO.Log.SequenceNumber); }
    public System.Collections.Generic.IEnumerable<System.IO.Log.LogRecord> ReadLogRecords(System.IO.Log.SequenceNumber start, System.IO.Log.LogRecordEnumeratorType logRecordEnum) { return default(System.Collections.Generic.IEnumerable<System.IO.Log.LogRecord>); }
    public System.Collections.Generic.IEnumerable<System.IO.Log.LogRecord> ReadRestartAreas() { return default(System.Collections.Generic.IEnumerable<System.IO.Log.LogRecord>); }
    public System.IO.Log.SequenceNumber ReserveAndAppend(System.ArraySegment<System.Byte> data, System.IO.Log.SequenceNumber nextUndoRecord, System.IO.Log.SequenceNumber previousRecord, System.IO.Log.RecordAppendOptions recordAppendOptions, System.IO.Log.ReservationCollection reservationCollection, params System.Int64[] reservations) { return default(System.IO.Log.SequenceNumber); }
    public System.IO.Log.SequenceNumber ReserveAndAppend(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> data, System.IO.Log.SequenceNumber nextUndoRecord, System.IO.Log.SequenceNumber previousRecord, System.IO.Log.RecordAppendOptions recordAppendOptions, System.IO.Log.ReservationCollection reservationCollection, params System.Int64[] reservations) { return default(System.IO.Log.SequenceNumber); }
    public System.IO.Log.SequenceNumber WriteRestartArea(System.ArraySegment<System.Byte> data) { return default(System.IO.Log.SequenceNumber); }
    public System.IO.Log.SequenceNumber WriteRestartArea(System.ArraySegment<System.Byte> data, System.IO.Log.SequenceNumber newBaseSeqNum) { return default(System.IO.Log.SequenceNumber); }
    public System.IO.Log.SequenceNumber WriteRestartArea(System.ArraySegment<System.Byte> data, System.IO.Log.SequenceNumber newBaseSeqNum, System.IO.Log.ReservationCollection reservations) { return default(System.IO.Log.SequenceNumber); }
    public System.IO.Log.SequenceNumber WriteRestartArea(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> data) { return default(System.IO.Log.SequenceNumber); }
    public System.IO.Log.SequenceNumber WriteRestartArea(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> data, System.IO.Log.SequenceNumber newBaseSeqNum) { return default(System.IO.Log.SequenceNumber); }
    public System.IO.Log.SequenceNumber WriteRestartArea(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> data, System.IO.Log.SequenceNumber newBaseSeqNum, System.IO.Log.ReservationCollection reservations) { return default(System.IO.Log.SequenceNumber); }
  }
  public sealed partial class FileRegion {
    internal FileRegion() { }
    public long FileLength { get { return default(long); } }
    public long Offset { get { return default(long); } }
    public string Path { get { return default(string); } }
    public System.IO.Stream GetStream() { return default(System.IO.Stream); }
  }
  public partial interface IRecordSequence : System.IDisposable {
    System.IO.Log.SequenceNumber BaseSequenceNumber { get; }
    System.IO.Log.SequenceNumber LastSequenceNumber { get; }
    long MaximumRecordLength { get; }
    long ReservedBytes { get; }
    System.IO.Log.SequenceNumber RestartSequenceNumber { get; }
    bool RetryAppend { get; set; }
    event System.EventHandler<System.IO.Log.TailPinnedEventArgs> TailPinned;
    void AdvanceBaseSequenceNumber(System.IO.Log.SequenceNumber newBaseSequenceNumber);
    System.IO.Log.SequenceNumber Append(System.ArraySegment<System.Byte> data, System.IO.Log.SequenceNumber nextUndoRecord, System.IO.Log.SequenceNumber previousRecord, System.IO.Log.RecordAppendOptions recordAppendOptions);
    System.IO.Log.SequenceNumber Append(System.ArraySegment<System.Byte> data, System.IO.Log.SequenceNumber nextUndoRecord, System.IO.Log.SequenceNumber previousRecord, System.IO.Log.RecordAppendOptions recordAppendOptions, System.IO.Log.ReservationCollection reservations);
    System.IO.Log.SequenceNumber Append(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> data, System.IO.Log.SequenceNumber nextUndoRecord, System.IO.Log.SequenceNumber previousRecord, System.IO.Log.RecordAppendOptions recordAppendOptions);
    System.IO.Log.SequenceNumber Append(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> data, System.IO.Log.SequenceNumber nextUndoRecord, System.IO.Log.SequenceNumber previousRecord, System.IO.Log.RecordAppendOptions recordAppendOptions, System.IO.Log.ReservationCollection reservations);
    System.IAsyncResult BeginAppend(System.ArraySegment<System.Byte> data, System.IO.Log.SequenceNumber nextUndoRecord, System.IO.Log.SequenceNumber previousRecord, System.IO.Log.RecordAppendOptions recordAppendOptions, System.AsyncCallback callback, object state);
    System.IAsyncResult BeginAppend(System.ArraySegment<System.Byte> data, System.IO.Log.SequenceNumber nextUndoRecord, System.IO.Log.SequenceNumber previousRecord, System.IO.Log.RecordAppendOptions recordAppendOptions, System.IO.Log.ReservationCollection reservations, System.AsyncCallback callback, object state);
    System.IAsyncResult BeginAppend(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> data, System.IO.Log.SequenceNumber nextUndoRecord, System.IO.Log.SequenceNumber previousRecord, System.IO.Log.RecordAppendOptions recordAppendOptions, System.AsyncCallback callback, object state);
    System.IAsyncResult BeginAppend(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> data, System.IO.Log.SequenceNumber nextUndoRecord, System.IO.Log.SequenceNumber previousUndoRecord, System.IO.Log.RecordAppendOptions recordAppendOptions, System.IO.Log.ReservationCollection reservations, System.AsyncCallback callback, object state);
    System.IAsyncResult BeginFlush(System.IO.Log.SequenceNumber sequenceNumber, System.AsyncCallback callback, object state);
    System.IAsyncResult BeginReserveAndAppend(System.ArraySegment<System.Byte> data, System.IO.Log.SequenceNumber nextUndoRecord, System.IO.Log.SequenceNumber previousRecord, System.IO.Log.RecordAppendOptions recordAppendOptions, System.IO.Log.ReservationCollection reservationCollection, System.Int64[] reservations, System.AsyncCallback callback, object state);
    System.IAsyncResult BeginReserveAndAppend(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> data, System.IO.Log.SequenceNumber nextUndoRecord, System.IO.Log.SequenceNumber previousRecord, System.IO.Log.RecordAppendOptions recordAppendOptions, System.IO.Log.ReservationCollection reservationCollection, System.Int64[] reservations, System.AsyncCallback callback, object state);
    System.IAsyncResult BeginWriteRestartArea(System.ArraySegment<System.Byte> data, System.IO.Log.SequenceNumber newBaseSequenceNumber, System.IO.Log.ReservationCollection reservation, System.AsyncCallback callback, object state);
    System.IAsyncResult BeginWriteRestartArea(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> data, System.IO.Log.SequenceNumber newBaseSequenceNumber, System.IO.Log.ReservationCollection reservation, System.AsyncCallback callback, object state);
    System.IO.Log.ReservationCollection CreateReservationCollection();
    System.IO.Log.SequenceNumber EndAppend(System.IAsyncResult result);
    System.IO.Log.SequenceNumber EndFlush(System.IAsyncResult result);
    System.IO.Log.SequenceNumber EndReserveAndAppend(System.IAsyncResult result);
    System.IO.Log.SequenceNumber EndWriteRestartArea(System.IAsyncResult result);
    System.IO.Log.SequenceNumber Flush();
    System.IO.Log.SequenceNumber Flush(System.IO.Log.SequenceNumber sequenceNumber);
    System.Collections.Generic.IEnumerable<System.IO.Log.LogRecord> ReadLogRecords(System.IO.Log.SequenceNumber start, System.IO.Log.LogRecordEnumeratorType logRecordEnum);
    System.Collections.Generic.IEnumerable<System.IO.Log.LogRecord> ReadRestartAreas();
    System.IO.Log.SequenceNumber ReserveAndAppend(System.ArraySegment<System.Byte> data, System.IO.Log.SequenceNumber nextUndoRecord, System.IO.Log.SequenceNumber previousRecord, System.IO.Log.RecordAppendOptions recordAppendOptions, System.IO.Log.ReservationCollection reservationCollection, params System.Int64[] reservations);
    System.IO.Log.SequenceNumber ReserveAndAppend(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> data, System.IO.Log.SequenceNumber nextUndoRecord, System.IO.Log.SequenceNumber previousRecord, System.IO.Log.RecordAppendOptions recordAppendOptions, System.IO.Log.ReservationCollection reservationCollection, params System.Int64[] reservations);
    System.IO.Log.SequenceNumber WriteRestartArea(System.ArraySegment<System.Byte> data);
    System.IO.Log.SequenceNumber WriteRestartArea(System.ArraySegment<System.Byte> data, System.IO.Log.SequenceNumber newBaseSequenceNumber);
    System.IO.Log.SequenceNumber WriteRestartArea(System.ArraySegment<System.Byte> data, System.IO.Log.SequenceNumber newBaseSequenceNumber, System.IO.Log.ReservationCollection reservation);
    System.IO.Log.SequenceNumber WriteRestartArea(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> data);
    System.IO.Log.SequenceNumber WriteRestartArea(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> data, System.IO.Log.SequenceNumber newBaseSequenceNumber);
    System.IO.Log.SequenceNumber WriteRestartArea(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> data, System.IO.Log.SequenceNumber newBaseSequenceNumber, System.IO.Log.ReservationCollection reservation);
  }
  public sealed partial class LogArchiveSnapshot {
    internal LogArchiveSnapshot() { }
    public System.Collections.Generic.IEnumerable<System.IO.Log.FileRegion> ArchiveRegions { get { return default(System.Collections.Generic.IEnumerable<System.IO.Log.FileRegion>); } }
    public System.IO.Log.SequenceNumber ArchiveTail { get { return default(System.IO.Log.SequenceNumber); } }
    public System.IO.Log.SequenceNumber BaseSequenceNumber { get { return default(System.IO.Log.SequenceNumber); } }
    public System.IO.Log.SequenceNumber LastSequenceNumber { get { return default(System.IO.Log.SequenceNumber); } }
  }
  public sealed partial class LogExtent {
    internal LogExtent() { }
    public string Path { get { return default(string); } }
    public long Size { get { return default(long); } }
    public System.IO.Log.LogExtentState State { get { return default(System.IO.Log.LogExtentState); } }
  }
  public sealed partial class LogExtentCollection : System.Collections.Generic.IEnumerable<System.IO.Log.LogExtent>, System.Collections.IEnumerable {
    internal LogExtentCollection() { }
    public int Count { get { return default(int); } }
    public int FreeCount { get { return default(int); } }
    public void Add(string path) { }
    public void Add(string path, long size) { }
    public System.Collections.Generic.IEnumerator<System.IO.Log.LogExtent> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.IO.Log.LogExtent>); }
    public void Remove(System.IO.Log.LogExtent extent, bool force) { }
    public void Remove(string path, bool force) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public enum LogExtentState {
    Active = 4,
    ActivePendingDelete = 8,
    Inactive = 2,
    Initializing = 1,
    PendingArchive = 16,
    PendingArchiveAndDelete = 32,
    Unknown = 0,
  }
  public sealed partial class LogPolicy {
    internal LogPolicy() { }
    public bool AutoGrow { get { return default(bool); } set { } }
    public int AutoShrinkPercentage { get { return default(int); } set { } }
    public System.IO.Log.PolicyUnit GrowthRate { get { return default(System.IO.Log.PolicyUnit); } set { } }
    public int MaximumExtentCount { get { return default(int); } set { } }
    public int MinimumExtentCount { get { return default(int); } set { } }
    public string NewExtentPrefix { get { return default(string); } set { } }
    public long NextExtentSuffix { get { return default(long); } set { } }
    public System.IO.Log.PolicyUnit PinnedTailThreshold { get { return default(System.IO.Log.PolicyUnit); } set { } }
    public void Commit() { }
    public void Refresh() { }
  }
  public abstract partial class LogRecord : System.IDisposable {
    protected LogRecord() { }
    public abstract System.IO.Stream Data { get; }
    public abstract System.IO.Log.SequenceNumber Previous { get; }
    public abstract System.IO.Log.SequenceNumber SequenceNumber { get; }
    public abstract System.IO.Log.SequenceNumber User { get; }
    public abstract void Dispose();
  }
  public enum LogRecordEnumeratorType {
    Next = 2,
    Previous = 1,
    User = 0,
  }
  public sealed partial class LogRecordSequence : System.IDisposable, System.IO.Log.IRecordSequence {
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.Demand, Unrestricted=true)]
    public LogRecordSequence(System.IO.Log.LogStore logStore) { }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.Demand, Unrestricted=true)]
    public LogRecordSequence(System.IO.Log.LogStore logStore, int bufferSize, int bufferCount) { }
    public LogRecordSequence(string path, System.IO.FileMode mode) { }
    public LogRecordSequence(string path, System.IO.FileMode mode, System.IO.FileAccess access) { }
    public LogRecordSequence(string path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare share) { }
    public LogRecordSequence(string path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare share, int bufferSize, int bufferCount) { }
    public LogRecordSequence(string path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare share, int bufferSize, int bufferCount, System.Security.AccessControl.FileSecurity fileSecurity) { }
    public System.IO.Log.SequenceNumber BaseSequenceNumber { get { return default(System.IO.Log.SequenceNumber); } }
    public System.IO.Log.SequenceNumber LastSequenceNumber { get { return default(System.IO.Log.SequenceNumber); } }
    public System.IO.Log.LogStore LogStore { get { return default(System.IO.Log.LogStore); } }
    public long MaximumRecordLength { get { return default(long); } }
    public long ReservedBytes { get { return default(long); } }
    public System.IO.Log.SequenceNumber RestartSequenceNumber { get { return default(System.IO.Log.SequenceNumber); } }
    public bool RetryAppend { get { return default(bool); } set { } }
    public event System.EventHandler<System.IO.Log.TailPinnedEventArgs> TailPinned { add { } remove { } }
    public void AdvanceBaseSequenceNumber(System.IO.Log.SequenceNumber newBaseSequenceNumber) { }
    public System.IO.Log.SequenceNumber Append(System.ArraySegment<System.Byte> data, System.IO.Log.SequenceNumber nextUndoRecord, System.IO.Log.SequenceNumber previousRecord, System.IO.Log.RecordAppendOptions recordAppendOptions) { return default(System.IO.Log.SequenceNumber); }
    public System.IO.Log.SequenceNumber Append(System.ArraySegment<System.Byte> data, System.IO.Log.SequenceNumber nextUndoRecord, System.IO.Log.SequenceNumber previousRecord, System.IO.Log.RecordAppendOptions recordAppendOptions, System.IO.Log.ReservationCollection reservations) { return default(System.IO.Log.SequenceNumber); }
    public System.IO.Log.SequenceNumber Append(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> data, System.IO.Log.SequenceNumber userRecord, System.IO.Log.SequenceNumber previousRecord, System.IO.Log.RecordAppendOptions recordAppendOptions) { return default(System.IO.Log.SequenceNumber); }
    public System.IO.Log.SequenceNumber Append(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> data, System.IO.Log.SequenceNumber userRecord, System.IO.Log.SequenceNumber previousRecord, System.IO.Log.RecordAppendOptions recordAppendOptions, System.IO.Log.ReservationCollection reservations) { return default(System.IO.Log.SequenceNumber); }
    public System.IAsyncResult BeginAppend(System.ArraySegment<System.Byte> data, System.IO.Log.SequenceNumber nextUndoRecord, System.IO.Log.SequenceNumber previousRecord, System.IO.Log.RecordAppendOptions recordAppendOptions, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginAppend(System.ArraySegment<System.Byte> data, System.IO.Log.SequenceNumber nextUndoRecord, System.IO.Log.SequenceNumber previousRecord, System.IO.Log.RecordAppendOptions recordAppendOptions, System.IO.Log.ReservationCollection reservations, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginAppend(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> data, System.IO.Log.SequenceNumber userRecord, System.IO.Log.SequenceNumber previousRecord, System.IO.Log.RecordAppendOptions recordAppendOptions, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginAppend(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> data, System.IO.Log.SequenceNumber userRecord, System.IO.Log.SequenceNumber previousRecord, System.IO.Log.RecordAppendOptions recordAppendOptions, System.IO.Log.ReservationCollection reservations, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginFlush(System.IO.Log.SequenceNumber sequenceNumber, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginReserveAndAppend(System.ArraySegment<System.Byte> data, System.IO.Log.SequenceNumber nextUndoRecord, System.IO.Log.SequenceNumber previousRecord, System.IO.Log.RecordAppendOptions recordAppendOptions, System.IO.Log.ReservationCollection reservationCollection, System.Int64[] reservations, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginReserveAndAppend(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> data, System.IO.Log.SequenceNumber userRecord, System.IO.Log.SequenceNumber previousRecord, System.IO.Log.RecordAppendOptions recordAppendOptions, System.IO.Log.ReservationCollection reservationCollection, System.Int64[] reservations, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginWriteRestartArea(System.ArraySegment<System.Byte> data, System.IO.Log.SequenceNumber newBaseSeqNum, System.IO.Log.ReservationCollection reservation, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginWriteRestartArea(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> data, System.IO.Log.SequenceNumber newBaseSeqNum, System.IO.Log.ReservationCollection reservationCollection, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IO.Log.ReservationCollection CreateReservationCollection() { return default(System.IO.Log.ReservationCollection); }
    public void Dispose() { }
    public System.IO.Log.SequenceNumber EndAppend(System.IAsyncResult result) { return default(System.IO.Log.SequenceNumber); }
    public System.IO.Log.SequenceNumber EndFlush(System.IAsyncResult result) { return default(System.IO.Log.SequenceNumber); }
    public System.IO.Log.SequenceNumber EndReserveAndAppend(System.IAsyncResult result) { return default(System.IO.Log.SequenceNumber); }
    public System.IO.Log.SequenceNumber EndWriteRestartArea(System.IAsyncResult result) { return default(System.IO.Log.SequenceNumber); }
    public System.IO.Log.SequenceNumber Flush() { return default(System.IO.Log.SequenceNumber); }
    public System.IO.Log.SequenceNumber Flush(System.IO.Log.SequenceNumber sequenceNumber) { return default(System.IO.Log.SequenceNumber); }
    public System.Collections.Generic.IEnumerable<System.IO.Log.LogRecord> ReadLogRecords(System.IO.Log.SequenceNumber start, System.IO.Log.LogRecordEnumeratorType logRecordEnum) { return default(System.Collections.Generic.IEnumerable<System.IO.Log.LogRecord>); }
    public System.Collections.Generic.IEnumerable<System.IO.Log.LogRecord> ReadRestartAreas() { return default(System.Collections.Generic.IEnumerable<System.IO.Log.LogRecord>); }
    public System.IO.Log.SequenceNumber ReserveAndAppend(System.ArraySegment<System.Byte> data, System.IO.Log.SequenceNumber nextUndoRecord, System.IO.Log.SequenceNumber previousRecord, System.IO.Log.RecordAppendOptions recordAppendOptions, System.IO.Log.ReservationCollection reservationCollection, params System.Int64[] reservations) { return default(System.IO.Log.SequenceNumber); }
    public System.IO.Log.SequenceNumber ReserveAndAppend(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> data, System.IO.Log.SequenceNumber userRecord, System.IO.Log.SequenceNumber previousRecord, System.IO.Log.RecordAppendOptions recordAppendOptions, System.IO.Log.ReservationCollection reservationCollection, params System.Int64[] reservations) { return default(System.IO.Log.SequenceNumber); }
    public void SetLastRecord(System.IO.Log.SequenceNumber sequenceNumber) { }
    public System.IO.Log.SequenceNumber WriteRestartArea(System.ArraySegment<System.Byte> data) { return default(System.IO.Log.SequenceNumber); }
    public System.IO.Log.SequenceNumber WriteRestartArea(System.ArraySegment<System.Byte> data, System.IO.Log.SequenceNumber newBaseSeqNum) { return default(System.IO.Log.SequenceNumber); }
    public System.IO.Log.SequenceNumber WriteRestartArea(System.ArraySegment<System.Byte> data, System.IO.Log.SequenceNumber newBaseSeqNum, System.IO.Log.ReservationCollection reservations) { return default(System.IO.Log.SequenceNumber); }
    public System.IO.Log.SequenceNumber WriteRestartArea(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> data) { return default(System.IO.Log.SequenceNumber); }
    public System.IO.Log.SequenceNumber WriteRestartArea(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> data, System.IO.Log.SequenceNumber newBaseSeqNum) { return default(System.IO.Log.SequenceNumber); }
    public System.IO.Log.SequenceNumber WriteRestartArea(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> data, System.IO.Log.SequenceNumber newBaseSeqNum, System.IO.Log.ReservationCollection reservationCollection) { return default(System.IO.Log.SequenceNumber); }
  }
  public sealed partial class LogStore : System.IDisposable {
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.Demand, Unrestricted=true)]
    public LogStore(Microsoft.Win32.SafeHandles.SafeFileHandle handle) { }
    public LogStore(string path, System.IO.FileMode mode) { }
    public LogStore(string path, System.IO.FileMode mode, System.IO.FileAccess access) { }
    public LogStore(string path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare share) { }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.Demand, Unrestricted=true)]
    public LogStore(string path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare share, System.Security.AccessControl.FileSecurity fileSecurity) { }
    public bool Archivable { get { return default(bool); } set { } }
    public System.IO.Log.SequenceNumber BaseSequenceNumber { get { return default(System.IO.Log.SequenceNumber); } }
    public System.IO.Log.LogExtentCollection Extents { get { return default(System.IO.Log.LogExtentCollection); } }
    public long FreeBytes { get { return default(long); } }
    public Microsoft.Win32.SafeHandles.SafeFileHandle Handle { get { return default(Microsoft.Win32.SafeHandles.SafeFileHandle); } }
    public System.IO.Log.SequenceNumber LastSequenceNumber { get { return default(System.IO.Log.SequenceNumber); } }
    public long Length { get { return default(long); } }
    public System.IO.Log.LogPolicy Policy { get { return default(System.IO.Log.LogPolicy); } }
    public int StreamCount { get { return default(int); } }
    public System.IO.Log.LogArchiveSnapshot CreateLogArchiveSnapshot() { return default(System.IO.Log.LogArchiveSnapshot); }
    public System.IO.Log.LogArchiveSnapshot CreateLogArchiveSnapshot(System.IO.Log.SequenceNumber first, System.IO.Log.SequenceNumber last) { return default(System.IO.Log.LogArchiveSnapshot); }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.Demand, Unrestricted=true)]
    public static void Delete(string path) { }
    public void Dispose() { }
    public void SetArchiveTail(System.IO.Log.SequenceNumber archiveTail) { }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct PolicyUnit {
    public PolicyUnit(long value, System.IO.Log.PolicyUnitType type) { throw new System.NotImplementedException(); }
    public System.IO.Log.PolicyUnitType Type { get { return default(System.IO.Log.PolicyUnitType); } }
    public long Value { get { return default(long); } }
    public override bool Equals(object obj) { return default(bool); }
    public static System.IO.Log.PolicyUnit Extents(long value) { return default(System.IO.Log.PolicyUnit); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.IO.Log.PolicyUnit left, System.IO.Log.PolicyUnit right) { return default(bool); }
    public static bool operator !=(System.IO.Log.PolicyUnit left, System.IO.Log.PolicyUnit right) { return default(bool); }
    public static System.IO.Log.PolicyUnit Percentage(long value) { return default(System.IO.Log.PolicyUnit); }
    public override string ToString() { return default(string); }
  }
  public enum PolicyUnitType {
    Extents = 0,
    Percentage = 1,
  }
  [System.FlagsAttribute]
  public enum RecordAppendOptions {
    ForceAppend = 1,
    ForceFlush = 2,
    None = 0,
  }
  public abstract partial class ReservationCollection : System.Collections.Generic.ICollection<System.Int64>, System.Collections.Generic.IEnumerable<System.Int64>, System.Collections.IEnumerable {
    protected ReservationCollection() { }
    public int Count { get { return default(int); } }
    public bool IsReadOnly { get { return default(bool); } }
    public void Add(long size) { }
    public void Clear() { }
    public bool Contains(long size) { return default(bool); }
    public void CopyTo(System.Int64[] array, int arrayIndex) { }
    ~ReservationCollection() { }
    protected abstract void FreeReservation(long size);
    protected long GetBestMatchingReservation(long size) { return default(long); }
    public System.Collections.Generic.IEnumerator<System.Int64> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Int64>); }
    protected abstract void MakeReservation(long size);
    public bool Remove(long item) { return default(bool); }
    protected void ReservationFreed(long size) { }
    protected void ReservationMade(long size) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public partial class ReservationNotFoundException : System.ArgumentException {
    public ReservationNotFoundException() { }
    protected ReservationNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public ReservationNotFoundException(string message) { }
    public ReservationNotFoundException(string message, System.Exception inner) { }
  }
  public partial class SequenceFullException : System.Exception {
    public SequenceFullException() { }
    protected SequenceFullException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public SequenceFullException(string message) { }
    public SequenceFullException(string message, System.Exception inner) { }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct SequenceNumber : System.IComparable<System.IO.Log.SequenceNumber> {
    public SequenceNumber(System.Byte[] sequenceNumber) { throw new System.NotImplementedException(); }
    public static System.IO.Log.SequenceNumber Invalid { get { return default(System.IO.Log.SequenceNumber); } }
    public int CompareTo(System.IO.Log.SequenceNumber other) { return default(int); }
    public bool Equals(System.IO.Log.SequenceNumber other) { return default(bool); }
    public override bool Equals(object other) { return default(bool); }
    public System.Byte[] GetBytes() { return default(System.Byte[]); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.IO.Log.SequenceNumber c1, System.IO.Log.SequenceNumber c2) { return default(bool); }
    public static bool operator >(System.IO.Log.SequenceNumber c1, System.IO.Log.SequenceNumber c2) { return default(bool); }
    public static bool operator >=(System.IO.Log.SequenceNumber c1, System.IO.Log.SequenceNumber c2) { return default(bool); }
    public static bool operator !=(System.IO.Log.SequenceNumber c1, System.IO.Log.SequenceNumber c2) { return default(bool); }
    public static bool operator <(System.IO.Log.SequenceNumber c1, System.IO.Log.SequenceNumber c2) { return default(bool); }
    public static bool operator <=(System.IO.Log.SequenceNumber c1, System.IO.Log.SequenceNumber c2) { return default(bool); }
  }
  public sealed partial class TailPinnedEventArgs : System.EventArgs {
    public TailPinnedEventArgs(System.IO.Log.SequenceNumber sequenceNumber) { }
    public System.IO.Log.SequenceNumber TargetSequenceNumber { get { return default(System.IO.Log.SequenceNumber); } }
  }
}
