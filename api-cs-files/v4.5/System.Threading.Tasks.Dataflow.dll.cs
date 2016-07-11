namespace System.Threading.Tasks.Dataflow {
  public sealed partial class ActionBlock<TInput> : System.Threading.Tasks.Dataflow.IDataflowBlock, System.Threading.Tasks.Dataflow.ITargetBlock<TInput> {
    public ActionBlock(System.Action<TInput> action) { }
    public ActionBlock(System.Action<TInput> action, System.Threading.Tasks.Dataflow.ExecutionDataflowBlockOptions dataflowBlockOptions) { }
    public ActionBlock(System.Func<TInput, System.Threading.Tasks.Task> action) { }
    public ActionBlock(System.Func<TInput, System.Threading.Tasks.Task> action, System.Threading.Tasks.Dataflow.ExecutionDataflowBlockOptions dataflowBlockOptions) { }
    public System.Threading.Tasks.Task Completion { get { return default(System.Threading.Tasks.Task); } }
    public int InputCount { get { return default(int); } }
    public void Complete() { }
    public bool Post(TInput item) { return default(bool); }
    void System.Threading.Tasks.Dataflow.IDataflowBlock.Fault(System.Exception exception) { }
    System.Threading.Tasks.Dataflow.DataflowMessageStatus System.Threading.Tasks.Dataflow.ITargetBlock<TInput>.OfferMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, TInput messageValue, System.Threading.Tasks.Dataflow.ISourceBlock<TInput> source, bool consumeToAccept) { return default(System.Threading.Tasks.Dataflow.DataflowMessageStatus); }
    public override string ToString() { return default(string); }
  }
  public sealed partial class BatchBlock<T> : System.Threading.Tasks.Dataflow.IDataflowBlock, System.Threading.Tasks.Dataflow.IPropagatorBlock<T, T[]>, System.Threading.Tasks.Dataflow.IReceivableSourceBlock<T[]>, System.Threading.Tasks.Dataflow.ISourceBlock<T[]>, System.Threading.Tasks.Dataflow.ITargetBlock<T> {
    public BatchBlock(int batchSize) { }
    public BatchBlock(int batchSize, System.Threading.Tasks.Dataflow.GroupingDataflowBlockOptions dataflowBlockOptions) { }
    public int BatchSize { get { return default(int); } }
    public System.Threading.Tasks.Task Completion { get { return default(System.Threading.Tasks.Task); } }
    public int OutputCount { get { return default(int); } }
    public void Complete() { }
    public System.IDisposable LinkTo(System.Threading.Tasks.Dataflow.ITargetBlock<T[]> target, System.Threading.Tasks.Dataflow.DataflowLinkOptions linkOptions) { return default(System.IDisposable); }
    void System.Threading.Tasks.Dataflow.IDataflowBlock.Fault(System.Exception exception) { }
    T[] System.Threading.Tasks.Dataflow.ISourceBlock<T[]>.ConsumeMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<T[]> target, out bool messageConsumed) { messageConsumed = default(bool); return default(T[]); }
    void System.Threading.Tasks.Dataflow.ISourceBlock<T[]>.ReleaseReservation(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<T[]> target) { }
    bool System.Threading.Tasks.Dataflow.ISourceBlock<T[]>.ReserveMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<T[]> target) { return default(bool); }
    System.Threading.Tasks.Dataflow.DataflowMessageStatus System.Threading.Tasks.Dataflow.ITargetBlock<T>.OfferMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, T messageValue, System.Threading.Tasks.Dataflow.ISourceBlock<T> source, bool consumeToAccept) { return default(System.Threading.Tasks.Dataflow.DataflowMessageStatus); }
    public override string ToString() { return default(string); }
    public void TriggerBatch() { }
    public bool TryReceive(System.Predicate<T[]> filter, out T[] item) { item = default(T[]); return default(bool); }
    public bool TryReceiveAll(out System.Collections.Generic.IList<T[]> items) { items = default(System.Collections.Generic.IList<T[]>); return default(bool); }
  }
  public sealed partial class BatchedJoinBlock<T1, T2> : System.Threading.Tasks.Dataflow.IDataflowBlock, System.Threading.Tasks.Dataflow.IReceivableSourceBlock<System.Tuple<System.Collections.Generic.IList<T1>, System.Collections.Generic.IList<T2>>>, System.Threading.Tasks.Dataflow.ISourceBlock<System.Tuple<System.Collections.Generic.IList<T1>, System.Collections.Generic.IList<T2>>> {
    public BatchedJoinBlock(int batchSize) { }
    public BatchedJoinBlock(int batchSize, System.Threading.Tasks.Dataflow.GroupingDataflowBlockOptions dataflowBlockOptions) { }
    public int BatchSize { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    public System.Threading.Tasks.Task Completion { get { return default(System.Threading.Tasks.Task); } }
    public int OutputCount { get { return default(int); } }
    public System.Threading.Tasks.Dataflow.ITargetBlock<T1> Target1 { get { return default(System.Threading.Tasks.Dataflow.ITargetBlock<T1>); } }
    public System.Threading.Tasks.Dataflow.ITargetBlock<T2> Target2 { get { return default(System.Threading.Tasks.Dataflow.ITargetBlock<T2>); } }
    public void Complete() { }
    public System.IDisposable LinkTo(System.Threading.Tasks.Dataflow.ITargetBlock<System.Tuple<System.Collections.Generic.IList<T1>, System.Collections.Generic.IList<T2>>> target, System.Threading.Tasks.Dataflow.DataflowLinkOptions linkOptions) { return default(System.IDisposable); }
    void System.Threading.Tasks.Dataflow.IDataflowBlock.Fault(System.Exception exception) { }
    System.Tuple<System.Collections.Generic.IList<T1>, System.Collections.Generic.IList<T2>> System.Threading.Tasks.Dataflow.ISourceBlock<System.Tuple<System.Collections.Generic.IList<T1>,System.Collections.Generic.IList<T2>>>.ConsumeMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<System.Tuple<System.Collections.Generic.IList<T1>, System.Collections.Generic.IList<T2>>> target, out bool messageConsumed) { messageConsumed = default(bool); return default(System.Tuple<System.Collections.Generic.IList<T1>, System.Collections.Generic.IList<T2>>); }
    void System.Threading.Tasks.Dataflow.ISourceBlock<System.Tuple<System.Collections.Generic.IList<T1>,System.Collections.Generic.IList<T2>>>.ReleaseReservation(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<System.Tuple<System.Collections.Generic.IList<T1>, System.Collections.Generic.IList<T2>>> target) { }
    bool System.Threading.Tasks.Dataflow.ISourceBlock<System.Tuple<System.Collections.Generic.IList<T1>,System.Collections.Generic.IList<T2>>>.ReserveMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<System.Tuple<System.Collections.Generic.IList<T1>, System.Collections.Generic.IList<T2>>> target) { return default(bool); }
    public override string ToString() { return default(string); }
    public bool TryReceive(System.Predicate<System.Tuple<System.Collections.Generic.IList<T1>, System.Collections.Generic.IList<T2>>> filter, out System.Tuple<System.Collections.Generic.IList<T1>, System.Collections.Generic.IList<T2>> item) { item = default(System.Tuple<System.Collections.Generic.IList<T1>, System.Collections.Generic.IList<T2>>); return default(bool); }
    public bool TryReceiveAll(out System.Collections.Generic.IList<System.Tuple<System.Collections.Generic.IList<T1>, System.Collections.Generic.IList<T2>>> items) { items = default(System.Collections.Generic.IList<System.Tuple<System.Collections.Generic.IList<T1>, System.Collections.Generic.IList<T2>>>); return default(bool); }
  }
  public sealed partial class BatchedJoinBlock<T1, T2, T3> : System.Threading.Tasks.Dataflow.IDataflowBlock, System.Threading.Tasks.Dataflow.IReceivableSourceBlock<System.Tuple<System.Collections.Generic.IList<T1>, System.Collections.Generic.IList<T2>, System.Collections.Generic.IList<T3>>>, System.Threading.Tasks.Dataflow.ISourceBlock<System.Tuple<System.Collections.Generic.IList<T1>, System.Collections.Generic.IList<T2>, System.Collections.Generic.IList<T3>>> {
    public BatchedJoinBlock(int batchSize) { }
    public BatchedJoinBlock(int batchSize, System.Threading.Tasks.Dataflow.GroupingDataflowBlockOptions dataflowBlockOptions) { }
    public int BatchSize { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    public System.Threading.Tasks.Task Completion { get { return default(System.Threading.Tasks.Task); } }
    public int OutputCount { get { return default(int); } }
    public System.Threading.Tasks.Dataflow.ITargetBlock<T1> Target1 { get { return default(System.Threading.Tasks.Dataflow.ITargetBlock<T1>); } }
    public System.Threading.Tasks.Dataflow.ITargetBlock<T2> Target2 { get { return default(System.Threading.Tasks.Dataflow.ITargetBlock<T2>); } }
    public System.Threading.Tasks.Dataflow.ITargetBlock<T3> Target3 { get { return default(System.Threading.Tasks.Dataflow.ITargetBlock<T3>); } }
    public void Complete() { }
    public System.IDisposable LinkTo(System.Threading.Tasks.Dataflow.ITargetBlock<System.Tuple<System.Collections.Generic.IList<T1>, System.Collections.Generic.IList<T2>, System.Collections.Generic.IList<T3>>> target, System.Threading.Tasks.Dataflow.DataflowLinkOptions linkOptions) { return default(System.IDisposable); }
    void System.Threading.Tasks.Dataflow.IDataflowBlock.Fault(System.Exception exception) { }
    System.Tuple<System.Collections.Generic.IList<T1>, System.Collections.Generic.IList<T2>, System.Collections.Generic.IList<T3>> System.Threading.Tasks.Dataflow.ISourceBlock<System.Tuple<System.Collections.Generic.IList<T1>,System.Collections.Generic.IList<T2>,System.Collections.Generic.IList<T3>>>.ConsumeMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<System.Tuple<System.Collections.Generic.IList<T1>, System.Collections.Generic.IList<T2>, System.Collections.Generic.IList<T3>>> target, out bool messageConsumed) { messageConsumed = default(bool); return default(System.Tuple<System.Collections.Generic.IList<T1>, System.Collections.Generic.IList<T2>, System.Collections.Generic.IList<T3>>); }
    void System.Threading.Tasks.Dataflow.ISourceBlock<System.Tuple<System.Collections.Generic.IList<T1>,System.Collections.Generic.IList<T2>,System.Collections.Generic.IList<T3>>>.ReleaseReservation(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<System.Tuple<System.Collections.Generic.IList<T1>, System.Collections.Generic.IList<T2>, System.Collections.Generic.IList<T3>>> target) { }
    bool System.Threading.Tasks.Dataflow.ISourceBlock<System.Tuple<System.Collections.Generic.IList<T1>,System.Collections.Generic.IList<T2>,System.Collections.Generic.IList<T3>>>.ReserveMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<System.Tuple<System.Collections.Generic.IList<T1>, System.Collections.Generic.IList<T2>, System.Collections.Generic.IList<T3>>> target) { return default(bool); }
    public override string ToString() { return default(string); }
    public bool TryReceive(System.Predicate<System.Tuple<System.Collections.Generic.IList<T1>, System.Collections.Generic.IList<T2>, System.Collections.Generic.IList<T3>>> filter, out System.Tuple<System.Collections.Generic.IList<T1>, System.Collections.Generic.IList<T2>, System.Collections.Generic.IList<T3>> item) { item = default(System.Tuple<System.Collections.Generic.IList<T1>, System.Collections.Generic.IList<T2>, System.Collections.Generic.IList<T3>>); return default(bool); }
    public bool TryReceiveAll(out System.Collections.Generic.IList<System.Tuple<System.Collections.Generic.IList<T1>, System.Collections.Generic.IList<T2>, System.Collections.Generic.IList<T3>>> items) { items = default(System.Collections.Generic.IList<System.Tuple<System.Collections.Generic.IList<T1>, System.Collections.Generic.IList<T2>, System.Collections.Generic.IList<T3>>>); return default(bool); }
  }
  public sealed partial class BroadcastBlock<T> : System.Threading.Tasks.Dataflow.IDataflowBlock, System.Threading.Tasks.Dataflow.IPropagatorBlock<T, T>, System.Threading.Tasks.Dataflow.IReceivableSourceBlock<T>, System.Threading.Tasks.Dataflow.ISourceBlock<T>, System.Threading.Tasks.Dataflow.ITargetBlock<T> {
    public BroadcastBlock(System.Func<T, T> cloningFunction) { }
    public BroadcastBlock(System.Func<T, T> cloningFunction, System.Threading.Tasks.Dataflow.DataflowBlockOptions dataflowBlockOptions) { }
    public System.Threading.Tasks.Task Completion { get { return default(System.Threading.Tasks.Task); } }
    public void Complete() { }
    public System.IDisposable LinkTo(System.Threading.Tasks.Dataflow.ITargetBlock<T> target, System.Threading.Tasks.Dataflow.DataflowLinkOptions linkOptions) { return default(System.IDisposable); }
    void System.Threading.Tasks.Dataflow.IDataflowBlock.Fault(System.Exception exception) { }
    bool System.Threading.Tasks.Dataflow.IReceivableSourceBlock<T>.TryReceiveAll(out System.Collections.Generic.IList<T> items) { items = default(System.Collections.Generic.IList<T>); return default(bool); }
    T System.Threading.Tasks.Dataflow.ISourceBlock<T>.ConsumeMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<T> target, out bool messageConsumed) { messageConsumed = default(bool); return default(T); }
    void System.Threading.Tasks.Dataflow.ISourceBlock<T>.ReleaseReservation(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<T> target) { }
    bool System.Threading.Tasks.Dataflow.ISourceBlock<T>.ReserveMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<T> target) { return default(bool); }
    System.Threading.Tasks.Dataflow.DataflowMessageStatus System.Threading.Tasks.Dataflow.ITargetBlock<T>.OfferMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, T messageValue, System.Threading.Tasks.Dataflow.ISourceBlock<T> source, bool consumeToAccept) { return default(System.Threading.Tasks.Dataflow.DataflowMessageStatus); }
    public override string ToString() { return default(string); }
    public bool TryReceive(System.Predicate<T> filter, out T item) { item = default(T); return default(bool); }
  }
  public sealed partial class BufferBlock<T> : System.Threading.Tasks.Dataflow.IDataflowBlock, System.Threading.Tasks.Dataflow.IPropagatorBlock<T, T>, System.Threading.Tasks.Dataflow.IReceivableSourceBlock<T>, System.Threading.Tasks.Dataflow.ISourceBlock<T>, System.Threading.Tasks.Dataflow.ITargetBlock<T> {
    public BufferBlock() { }
    public BufferBlock(System.Threading.Tasks.Dataflow.DataflowBlockOptions dataflowBlockOptions) { }
    public System.Threading.Tasks.Task Completion { get { return default(System.Threading.Tasks.Task); } }
    public int Count { get { return default(int); } }
    public void Complete() { }
    public System.IDisposable LinkTo(System.Threading.Tasks.Dataflow.ITargetBlock<T> target, System.Threading.Tasks.Dataflow.DataflowLinkOptions linkOptions) { return default(System.IDisposable); }
    void System.Threading.Tasks.Dataflow.IDataflowBlock.Fault(System.Exception exception) { }
    T System.Threading.Tasks.Dataflow.ISourceBlock<T>.ConsumeMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<T> target, out bool messageConsumed) { messageConsumed = default(bool); return default(T); }
    void System.Threading.Tasks.Dataflow.ISourceBlock<T>.ReleaseReservation(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<T> target) { }
    bool System.Threading.Tasks.Dataflow.ISourceBlock<T>.ReserveMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<T> target) { return default(bool); }
    System.Threading.Tasks.Dataflow.DataflowMessageStatus System.Threading.Tasks.Dataflow.ITargetBlock<T>.OfferMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, T messageValue, System.Threading.Tasks.Dataflow.ISourceBlock<T> source, bool consumeToAccept) { return default(System.Threading.Tasks.Dataflow.DataflowMessageStatus); }
    public override string ToString() { return default(string); }
    public bool TryReceive(System.Predicate<T> filter, out T item) { item = default(T); return default(bool); }
    public bool TryReceiveAll(out System.Collections.Generic.IList<T> items) { items = default(System.Collections.Generic.IList<T>); return default(bool); }
  }
  public static partial class DataflowBlock {
    public static System.IObservable<TOutput> AsObservable<TOutput>(this System.Threading.Tasks.Dataflow.ISourceBlock<TOutput> source) { return default(System.IObservable<TOutput>); }
    public static System.IObserver<TInput> AsObserver<TInput>(this System.Threading.Tasks.Dataflow.ITargetBlock<TInput> target) { return default(System.IObserver<TInput>); }
    public static System.Threading.Tasks.Task<System.Int32> Choose<T1, T2>(System.Threading.Tasks.Dataflow.ISourceBlock<T1> source1, System.Action<T1> action1, System.Threading.Tasks.Dataflow.ISourceBlock<T2> source2, System.Action<T2> action2) { return default(System.Threading.Tasks.Task<System.Int32>); }
    public static System.Threading.Tasks.Task<System.Int32> Choose<T1, T2>(System.Threading.Tasks.Dataflow.ISourceBlock<T1> source1, System.Action<T1> action1, System.Threading.Tasks.Dataflow.ISourceBlock<T2> source2, System.Action<T2> action2, System.Threading.Tasks.Dataflow.DataflowBlockOptions dataflowBlockOptions) { return default(System.Threading.Tasks.Task<System.Int32>); }
    public static System.Threading.Tasks.Task<System.Int32> Choose<T1, T2, T3>(System.Threading.Tasks.Dataflow.ISourceBlock<T1> source1, System.Action<T1> action1, System.Threading.Tasks.Dataflow.ISourceBlock<T2> source2, System.Action<T2> action2, System.Threading.Tasks.Dataflow.ISourceBlock<T3> source3, System.Action<T3> action3) { return default(System.Threading.Tasks.Task<System.Int32>); }
    public static System.Threading.Tasks.Task<System.Int32> Choose<T1, T2, T3>(System.Threading.Tasks.Dataflow.ISourceBlock<T1> source1, System.Action<T1> action1, System.Threading.Tasks.Dataflow.ISourceBlock<T2> source2, System.Action<T2> action2, System.Threading.Tasks.Dataflow.ISourceBlock<T3> source3, System.Action<T3> action3, System.Threading.Tasks.Dataflow.DataflowBlockOptions dataflowBlockOptions) { return default(System.Threading.Tasks.Task<System.Int32>); }
    public static System.Threading.Tasks.Dataflow.IPropagatorBlock<TInput, TOutput> Encapsulate<TInput, TOutput>(System.Threading.Tasks.Dataflow.ITargetBlock<TInput> target, System.Threading.Tasks.Dataflow.ISourceBlock<TOutput> source) { return default(System.Threading.Tasks.Dataflow.IPropagatorBlock<TInput, TOutput>); }
    public static System.IDisposable LinkTo<TOutput>(this System.Threading.Tasks.Dataflow.ISourceBlock<TOutput> source, System.Threading.Tasks.Dataflow.ITargetBlock<TOutput> target) { return default(System.IDisposable); }
    public static System.IDisposable LinkTo<TOutput>(this System.Threading.Tasks.Dataflow.ISourceBlock<TOutput> source, System.Threading.Tasks.Dataflow.ITargetBlock<TOutput> target, System.Predicate<TOutput> predicate) { return default(System.IDisposable); }
    public static System.IDisposable LinkTo<TOutput>(this System.Threading.Tasks.Dataflow.ISourceBlock<TOutput> source, System.Threading.Tasks.Dataflow.ITargetBlock<TOutput> target, System.Threading.Tasks.Dataflow.DataflowLinkOptions linkOptions, System.Predicate<TOutput> predicate) { return default(System.IDisposable); }
    public static System.Threading.Tasks.Dataflow.ITargetBlock<TInput> NullTarget<TInput>() { return default(System.Threading.Tasks.Dataflow.ITargetBlock<TInput>); }
    public static System.Threading.Tasks.Task<System.Boolean> OutputAvailableAsync<TOutput>(this System.Threading.Tasks.Dataflow.ISourceBlock<TOutput> source) { return default(System.Threading.Tasks.Task<System.Boolean>); }
    public static System.Threading.Tasks.Task<System.Boolean> OutputAvailableAsync<TOutput>(this System.Threading.Tasks.Dataflow.ISourceBlock<TOutput> source, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<System.Boolean>); }
    public static bool Post<TInput>(this System.Threading.Tasks.Dataflow.ITargetBlock<TInput> target, TInput item) { return default(bool); }
    public static TOutput Receive<TOutput>(this System.Threading.Tasks.Dataflow.ISourceBlock<TOutput> source) { return default(TOutput); }
    public static TOutput Receive<TOutput>(this System.Threading.Tasks.Dataflow.ISourceBlock<TOutput> source, System.Threading.CancellationToken cancellationToken) { return default(TOutput); }
    public static TOutput Receive<TOutput>(this System.Threading.Tasks.Dataflow.ISourceBlock<TOutput> source, System.TimeSpan timeout) { return default(TOutput); }
    public static TOutput Receive<TOutput>(this System.Threading.Tasks.Dataflow.ISourceBlock<TOutput> source, System.TimeSpan timeout, System.Threading.CancellationToken cancellationToken) { return default(TOutput); }
    public static System.Threading.Tasks.Task<TOutput> ReceiveAsync<TOutput>(this System.Threading.Tasks.Dataflow.ISourceBlock<TOutput> source) { return default(System.Threading.Tasks.Task<TOutput>); }
    public static System.Threading.Tasks.Task<TOutput> ReceiveAsync<TOutput>(this System.Threading.Tasks.Dataflow.ISourceBlock<TOutput> source, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<TOutput>); }
    public static System.Threading.Tasks.Task<TOutput> ReceiveAsync<TOutput>(this System.Threading.Tasks.Dataflow.ISourceBlock<TOutput> source, System.TimeSpan timeout) { return default(System.Threading.Tasks.Task<TOutput>); }
    public static System.Threading.Tasks.Task<TOutput> ReceiveAsync<TOutput>(this System.Threading.Tasks.Dataflow.ISourceBlock<TOutput> source, System.TimeSpan timeout, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<TOutput>); }
    public static System.Threading.Tasks.Task<System.Boolean> SendAsync<TInput>(this System.Threading.Tasks.Dataflow.ITargetBlock<TInput> target, TInput item) { return default(System.Threading.Tasks.Task<System.Boolean>); }
    public static System.Threading.Tasks.Task<System.Boolean> SendAsync<TInput>(this System.Threading.Tasks.Dataflow.ITargetBlock<TInput> target, TInput item, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<System.Boolean>); }
    public static bool TryReceive<TOutput>(this System.Threading.Tasks.Dataflow.IReceivableSourceBlock<TOutput> source, out TOutput item) { item = default(TOutput); return default(bool); }
  }
  public partial class DataflowBlockOptions {
    public const int Unbounded = -1;
    public DataflowBlockOptions() { }
    public int BoundedCapacity { get { return default(int); } set { } }
    public System.Threading.CancellationToken CancellationToken { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Threading.CancellationToken); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public int MaxMessagesPerTask { get { return default(int); } set { } }
    public string NameFormat { get { return default(string); } set { } }
    public System.Threading.Tasks.TaskScheduler TaskScheduler { get { return default(System.Threading.Tasks.TaskScheduler); } set { } }
  }
  public partial class DataflowLinkOptions {
    public DataflowLinkOptions() { }
    public bool Append { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public int MaxMessages { get { return default(int); } set { } }
    public bool PropagateCompletion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct DataflowMessageHeader : System.IEquatable<System.Threading.Tasks.Dataflow.DataflowMessageHeader> {
    public DataflowMessageHeader(long id) { throw new System.NotImplementedException(); }
    public long Id { get { return default(long); } }
    public bool IsValid { get { return default(bool); } }
    public override bool Equals(object obj) { return default(bool); }
    public bool Equals(System.Threading.Tasks.Dataflow.DataflowMessageHeader other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Threading.Tasks.Dataflow.DataflowMessageHeader left, System.Threading.Tasks.Dataflow.DataflowMessageHeader right) { return default(bool); }
    public static bool operator !=(System.Threading.Tasks.Dataflow.DataflowMessageHeader left, System.Threading.Tasks.Dataflow.DataflowMessageHeader right) { return default(bool); }
  }
  public enum DataflowMessageStatus {
    Accepted = 0,
    Declined = 1,
    DecliningPermanently = 4,
    NotAvailable = 3,
    Postponed = 2,
  }
  public partial class ExecutionDataflowBlockOptions : System.Threading.Tasks.Dataflow.DataflowBlockOptions {
    public ExecutionDataflowBlockOptions() { }
    public int MaxDegreeOfParallelism { get { return default(int); } set { } }
    public bool SingleProducerConstrained { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial class GroupingDataflowBlockOptions : System.Threading.Tasks.Dataflow.DataflowBlockOptions {
    public GroupingDataflowBlockOptions() { }
    public bool Greedy { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public long MaxNumberOfGroups { get { return default(long); } set { } }
  }
  public partial interface IDataflowBlock {
    System.Threading.Tasks.Task Completion { get; }
    void Complete();
    void Fault(System.Exception exception);
  }
  public partial interface IPropagatorBlock<in TInput, out TOutput> : System.Threading.Tasks.Dataflow.IDataflowBlock, System.Threading.Tasks.Dataflow.ISourceBlock<TOutput>, System.Threading.Tasks.Dataflow.ITargetBlock<TInput> {
  }
  public partial interface IReceivableSourceBlock<TOutput> : System.Threading.Tasks.Dataflow.IDataflowBlock, System.Threading.Tasks.Dataflow.ISourceBlock<TOutput> {
    bool TryReceive(System.Predicate<TOutput> filter, out TOutput item);
    bool TryReceiveAll(out System.Collections.Generic.IList<TOutput> items);
  }
  public partial interface ISourceBlock<out TOutput> : System.Threading.Tasks.Dataflow.IDataflowBlock {
    TOutput ConsumeMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<TOutput> target, out bool messageConsumed);
    System.IDisposable LinkTo(System.Threading.Tasks.Dataflow.ITargetBlock<TOutput> target, System.Threading.Tasks.Dataflow.DataflowLinkOptions linkOptions);
    void ReleaseReservation(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<TOutput> target);
    bool ReserveMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<TOutput> target);
  }
  public partial interface ITargetBlock<in TInput> : System.Threading.Tasks.Dataflow.IDataflowBlock {
    System.Threading.Tasks.Dataflow.DataflowMessageStatus OfferMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, TInput messageValue, System.Threading.Tasks.Dataflow.ISourceBlock<TInput> source, bool consumeToAccept);
  }
  public sealed partial class JoinBlock<T1, T2> : System.Threading.Tasks.Dataflow.IDataflowBlock, System.Threading.Tasks.Dataflow.IReceivableSourceBlock<System.Tuple<T1, T2>>, System.Threading.Tasks.Dataflow.ISourceBlock<System.Tuple<T1, T2>> {
    public JoinBlock() { }
    public JoinBlock(System.Threading.Tasks.Dataflow.GroupingDataflowBlockOptions dataflowBlockOptions) { }
    public System.Threading.Tasks.Task Completion { get { return default(System.Threading.Tasks.Task); } }
    public int OutputCount { get { return default(int); } }
    public System.Threading.Tasks.Dataflow.ITargetBlock<T1> Target1 { get { return default(System.Threading.Tasks.Dataflow.ITargetBlock<T1>); } }
    public System.Threading.Tasks.Dataflow.ITargetBlock<T2> Target2 { get { return default(System.Threading.Tasks.Dataflow.ITargetBlock<T2>); } }
    public void Complete() { }
    public System.IDisposable LinkTo(System.Threading.Tasks.Dataflow.ITargetBlock<System.Tuple<T1, T2>> target, System.Threading.Tasks.Dataflow.DataflowLinkOptions linkOptions) { return default(System.IDisposable); }
    void System.Threading.Tasks.Dataflow.IDataflowBlock.Fault(System.Exception exception) { }
    System.Tuple<T1, T2> System.Threading.Tasks.Dataflow.ISourceBlock<System.Tuple<T1,T2>>.ConsumeMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<System.Tuple<T1, T2>> target, out bool messageConsumed) { messageConsumed = default(bool); return default(System.Tuple<T1, T2>); }
    void System.Threading.Tasks.Dataflow.ISourceBlock<System.Tuple<T1,T2>>.ReleaseReservation(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<System.Tuple<T1, T2>> target) { }
    bool System.Threading.Tasks.Dataflow.ISourceBlock<System.Tuple<T1,T2>>.ReserveMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<System.Tuple<T1, T2>> target) { return default(bool); }
    public override string ToString() { return default(string); }
    public bool TryReceive(System.Predicate<System.Tuple<T1, T2>> filter, out System.Tuple<T1, T2> item) { item = default(System.Tuple<T1, T2>); return default(bool); }
    public bool TryReceiveAll(out System.Collections.Generic.IList<System.Tuple<T1, T2>> items) { items = default(System.Collections.Generic.IList<System.Tuple<T1, T2>>); return default(bool); }
  }
  public sealed partial class JoinBlock<T1, T2, T3> : System.Threading.Tasks.Dataflow.IDataflowBlock, System.Threading.Tasks.Dataflow.IReceivableSourceBlock<System.Tuple<T1, T2, T3>>, System.Threading.Tasks.Dataflow.ISourceBlock<System.Tuple<T1, T2, T3>> {
    public JoinBlock() { }
    public JoinBlock(System.Threading.Tasks.Dataflow.GroupingDataflowBlockOptions dataflowBlockOptions) { }
    public System.Threading.Tasks.Task Completion { get { return default(System.Threading.Tasks.Task); } }
    public int OutputCount { get { return default(int); } }
    public System.Threading.Tasks.Dataflow.ITargetBlock<T1> Target1 { get { return default(System.Threading.Tasks.Dataflow.ITargetBlock<T1>); } }
    public System.Threading.Tasks.Dataflow.ITargetBlock<T2> Target2 { get { return default(System.Threading.Tasks.Dataflow.ITargetBlock<T2>); } }
    public System.Threading.Tasks.Dataflow.ITargetBlock<T3> Target3 { get { return default(System.Threading.Tasks.Dataflow.ITargetBlock<T3>); } }
    public void Complete() { }
    public System.IDisposable LinkTo(System.Threading.Tasks.Dataflow.ITargetBlock<System.Tuple<T1, T2, T3>> target, System.Threading.Tasks.Dataflow.DataflowLinkOptions linkOptions) { return default(System.IDisposable); }
    void System.Threading.Tasks.Dataflow.IDataflowBlock.Fault(System.Exception exception) { }
    System.Tuple<T1, T2, T3> System.Threading.Tasks.Dataflow.ISourceBlock<System.Tuple<T1,T2,T3>>.ConsumeMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<System.Tuple<T1, T2, T3>> target, out bool messageConsumed) { messageConsumed = default(bool); return default(System.Tuple<T1, T2, T3>); }
    void System.Threading.Tasks.Dataflow.ISourceBlock<System.Tuple<T1,T2,T3>>.ReleaseReservation(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<System.Tuple<T1, T2, T3>> target) { }
    bool System.Threading.Tasks.Dataflow.ISourceBlock<System.Tuple<T1,T2,T3>>.ReserveMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<System.Tuple<T1, T2, T3>> target) { return default(bool); }
    public override string ToString() { return default(string); }
    public bool TryReceive(System.Predicate<System.Tuple<T1, T2, T3>> filter, out System.Tuple<T1, T2, T3> item) { item = default(System.Tuple<T1, T2, T3>); return default(bool); }
    public bool TryReceiveAll(out System.Collections.Generic.IList<System.Tuple<T1, T2, T3>> items) { items = default(System.Collections.Generic.IList<System.Tuple<T1, T2, T3>>); return default(bool); }
  }
  public sealed partial class TransformBlock<TInput, TOutput> : System.Threading.Tasks.Dataflow.IDataflowBlock, System.Threading.Tasks.Dataflow.IPropagatorBlock<TInput, TOutput>, System.Threading.Tasks.Dataflow.IReceivableSourceBlock<TOutput>, System.Threading.Tasks.Dataflow.ISourceBlock<TOutput>, System.Threading.Tasks.Dataflow.ITargetBlock<TInput> {
    public TransformBlock(System.Func<TInput, TOutput> transform) { }
    public TransformBlock(System.Func<TInput, TOutput> transform, System.Threading.Tasks.Dataflow.ExecutionDataflowBlockOptions dataflowBlockOptions) { }
    public TransformBlock(System.Func<TInput, System.Threading.Tasks.Task<TOutput>> transform) { }
    public TransformBlock(System.Func<TInput, System.Threading.Tasks.Task<TOutput>> transform, System.Threading.Tasks.Dataflow.ExecutionDataflowBlockOptions dataflowBlockOptions) { }
    public System.Threading.Tasks.Task Completion { get { return default(System.Threading.Tasks.Task); } }
    public int InputCount { get { return default(int); } }
    public int OutputCount { get { return default(int); } }
    public void Complete() { }
    public System.IDisposable LinkTo(System.Threading.Tasks.Dataflow.ITargetBlock<TOutput> target, System.Threading.Tasks.Dataflow.DataflowLinkOptions linkOptions) { return default(System.IDisposable); }
    void System.Threading.Tasks.Dataflow.IDataflowBlock.Fault(System.Exception exception) { }
    TOutput System.Threading.Tasks.Dataflow.ISourceBlock<TOutput>.ConsumeMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<TOutput> target, out bool messageConsumed) { messageConsumed = default(bool); return default(TOutput); }
    void System.Threading.Tasks.Dataflow.ISourceBlock<TOutput>.ReleaseReservation(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<TOutput> target) { }
    bool System.Threading.Tasks.Dataflow.ISourceBlock<TOutput>.ReserveMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<TOutput> target) { return default(bool); }
    System.Threading.Tasks.Dataflow.DataflowMessageStatus System.Threading.Tasks.Dataflow.ITargetBlock<TInput>.OfferMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, TInput messageValue, System.Threading.Tasks.Dataflow.ISourceBlock<TInput> source, bool consumeToAccept) { return default(System.Threading.Tasks.Dataflow.DataflowMessageStatus); }
    public override string ToString() { return default(string); }
    public bool TryReceive(System.Predicate<TOutput> filter, out TOutput item) { item = default(TOutput); return default(bool); }
    public bool TryReceiveAll(out System.Collections.Generic.IList<TOutput> items) { items = default(System.Collections.Generic.IList<TOutput>); return default(bool); }
  }
  public sealed partial class TransformManyBlock<TInput, TOutput> : System.Threading.Tasks.Dataflow.IDataflowBlock, System.Threading.Tasks.Dataflow.IPropagatorBlock<TInput, TOutput>, System.Threading.Tasks.Dataflow.IReceivableSourceBlock<TOutput>, System.Threading.Tasks.Dataflow.ISourceBlock<TOutput>, System.Threading.Tasks.Dataflow.ITargetBlock<TInput> {
    public TransformManyBlock(System.Func<TInput, System.Collections.Generic.IEnumerable<TOutput>> transform) { }
    public TransformManyBlock(System.Func<TInput, System.Collections.Generic.IEnumerable<TOutput>> transform, System.Threading.Tasks.Dataflow.ExecutionDataflowBlockOptions dataflowBlockOptions) { }
    public TransformManyBlock(System.Func<TInput, System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<TOutput>>> transform) { }
    public TransformManyBlock(System.Func<TInput, System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<TOutput>>> transform, System.Threading.Tasks.Dataflow.ExecutionDataflowBlockOptions dataflowBlockOptions) { }
    public System.Threading.Tasks.Task Completion { get { return default(System.Threading.Tasks.Task); } }
    public int InputCount { get { return default(int); } }
    public int OutputCount { get { return default(int); } }
    public void Complete() { }
    public System.IDisposable LinkTo(System.Threading.Tasks.Dataflow.ITargetBlock<TOutput> target, System.Threading.Tasks.Dataflow.DataflowLinkOptions linkOptions) { return default(System.IDisposable); }
    void System.Threading.Tasks.Dataflow.IDataflowBlock.Fault(System.Exception exception) { }
    TOutput System.Threading.Tasks.Dataflow.ISourceBlock<TOutput>.ConsumeMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<TOutput> target, out bool messageConsumed) { messageConsumed = default(bool); return default(TOutput); }
    void System.Threading.Tasks.Dataflow.ISourceBlock<TOutput>.ReleaseReservation(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<TOutput> target) { }
    bool System.Threading.Tasks.Dataflow.ISourceBlock<TOutput>.ReserveMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<TOutput> target) { return default(bool); }
    System.Threading.Tasks.Dataflow.DataflowMessageStatus System.Threading.Tasks.Dataflow.ITargetBlock<TInput>.OfferMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, TInput messageValue, System.Threading.Tasks.Dataflow.ISourceBlock<TInput> source, bool consumeToAccept) { return default(System.Threading.Tasks.Dataflow.DataflowMessageStatus); }
    public override string ToString() { return default(string); }
    public bool TryReceive(System.Predicate<TOutput> filter, out TOutput item) { item = default(TOutput); return default(bool); }
    public bool TryReceiveAll(out System.Collections.Generic.IList<TOutput> items) { items = default(System.Collections.Generic.IList<TOutput>); return default(bool); }
  }
  public sealed partial class WriteOnceBlock<T> : System.Threading.Tasks.Dataflow.IDataflowBlock, System.Threading.Tasks.Dataflow.IPropagatorBlock<T, T>, System.Threading.Tasks.Dataflow.IReceivableSourceBlock<T>, System.Threading.Tasks.Dataflow.ISourceBlock<T>, System.Threading.Tasks.Dataflow.ITargetBlock<T> {
    public WriteOnceBlock(System.Func<T, T> cloningFunction) { }
    public WriteOnceBlock(System.Func<T, T> cloningFunction, System.Threading.Tasks.Dataflow.DataflowBlockOptions dataflowBlockOptions) { }
    public System.Threading.Tasks.Task Completion { get { return default(System.Threading.Tasks.Task); } }
    public void Complete() { }
    public System.IDisposable LinkTo(System.Threading.Tasks.Dataflow.ITargetBlock<T> target, System.Threading.Tasks.Dataflow.DataflowLinkOptions linkOptions) { return default(System.IDisposable); }
    void System.Threading.Tasks.Dataflow.IDataflowBlock.Fault(System.Exception exception) { }
    bool System.Threading.Tasks.Dataflow.IReceivableSourceBlock<T>.TryReceiveAll(out System.Collections.Generic.IList<T> items) { items = default(System.Collections.Generic.IList<T>); return default(bool); }
    T System.Threading.Tasks.Dataflow.ISourceBlock<T>.ConsumeMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<T> target, out bool messageConsumed) { messageConsumed = default(bool); return default(T); }
    void System.Threading.Tasks.Dataflow.ISourceBlock<T>.ReleaseReservation(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<T> target) { }
    bool System.Threading.Tasks.Dataflow.ISourceBlock<T>.ReserveMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, System.Threading.Tasks.Dataflow.ITargetBlock<T> target) { return default(bool); }
    System.Threading.Tasks.Dataflow.DataflowMessageStatus System.Threading.Tasks.Dataflow.ITargetBlock<T>.OfferMessage(System.Threading.Tasks.Dataflow.DataflowMessageHeader messageHeader, T messageValue, System.Threading.Tasks.Dataflow.ISourceBlock<T> source, bool consumeToAccept) { return default(System.Threading.Tasks.Dataflow.DataflowMessageStatus); }
    public override string ToString() { return default(string); }
    public bool TryReceive(System.Predicate<T> filter, out T item) { item = default(T); return default(bool); }
  }
}
