namespace System {
  public static partial class ObservableExtensions {
    public static System.IDisposable Subscribe<T>(this System.IObservable<T> source) { return default(System.IDisposable); }
    public static System.IDisposable Subscribe<T>(this System.IObservable<T> source, System.Action<T> onNext) { return default(System.IDisposable); }
    public static System.IDisposable Subscribe<T>(this System.IObservable<T> source, System.Action<T> onNext, System.Action onCompleted) { return default(System.IDisposable); }
    public static void Subscribe<T>(this System.IObservable<T> source, System.Action<T> onNext, System.Action onCompleted, System.Threading.CancellationToken token) { }
    public static System.IDisposable Subscribe<T>(this System.IObservable<T> source, System.Action<T> onNext, System.Action<System.Exception> onError) { return default(System.IDisposable); }
    public static System.IDisposable Subscribe<T>(this System.IObservable<T> source, System.Action<T> onNext, System.Action<System.Exception> onError, System.Action onCompleted) { return default(System.IDisposable); }
    public static void Subscribe<T>(this System.IObservable<T> source, System.Action<T> onNext, System.Action<System.Exception> onError, System.Action onCompleted, System.Threading.CancellationToken token) { }
    public static void Subscribe<T>(this System.IObservable<T> source, System.Action<T> onNext, System.Action<System.Exception> onError, System.Threading.CancellationToken token) { }
    public static void Subscribe<T>(this System.IObservable<T> source, System.Action<T> onNext, System.Threading.CancellationToken token) { }
    public static void Subscribe<T>(this System.IObservable<T> source, System.IObserver<T> observer, System.Threading.CancellationToken token) { }
    public static void Subscribe<T>(this System.IObservable<T> source, System.Threading.CancellationToken token) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static System.IDisposable SubscribeSafe<T>(this System.IObservable<T> source, System.IObserver<T> observer) { return default(System.IDisposable); }
  }
}
namespace System.Reactive {
  public sealed partial class AnonymousObservable<T> : System.Reactive.ObservableBase<T> {
    public AnonymousObservable(System.Func<System.IObserver<T>, System.IDisposable> subscribe) { }
    protected override System.IDisposable SubscribeCore(System.IObserver<T> observer) { return default(System.IDisposable); }
  }
  public sealed partial class AnonymousObserver<T> : System.Reactive.ObserverBase<T> {
    public AnonymousObserver(System.Action<T> onNext) { }
    public AnonymousObserver(System.Action<T> onNext, System.Action onCompleted) { }
    public AnonymousObserver(System.Action<T> onNext, System.Action<System.Exception> onError) { }
    public AnonymousObserver(System.Action<T> onNext, System.Action<System.Exception> onError, System.Action onCompleted) { }
    protected override void OnCompletedCore() { }
    protected override void OnErrorCore(System.Exception error) { }
    protected override void OnNextCore(T value) { }
  }
  public static partial class Notification {
    public static System.Reactive.Notification<T> CreateOnCompleted<T>() { return default(System.Reactive.Notification<T>); }
    public static System.Reactive.Notification<T> CreateOnError<T>(System.Exception error) { return default(System.Reactive.Notification<T>); }
    public static System.Reactive.Notification<T> CreateOnNext<T>(T value) { return default(System.Reactive.Notification<T>); }
  }
  public abstract partial class Notification<T> : System.IEquatable<System.Reactive.Notification<T>> {
    protected internal Notification() { }
    public abstract System.Exception Exception { get; }
    public abstract bool HasValue { get; }
    public abstract System.Reactive.NotificationKind Kind { get; }
    public abstract T Value { get; }
    public abstract void Accept(System.Action<T> onNext, System.Action<System.Exception> onError, System.Action onCompleted);
    public abstract void Accept(System.IObserver<T> observer);
    public abstract TResult Accept<TResult>(System.Func<T, TResult> onNext, System.Func<System.Exception, TResult> onError, System.Func<TResult> onCompleted);
    public abstract TResult Accept<TResult>(System.Reactive.IObserver<T, TResult> observer);
    public override bool Equals(object obj) { return default(bool); }
    public abstract bool Equals(System.Reactive.Notification<T> other);
    public static bool operator ==(System.Reactive.Notification<T> left, System.Reactive.Notification<T> right) { return default(bool); }
    public static bool operator !=(System.Reactive.Notification<T> left, System.Reactive.Notification<T> right) { return default(bool); }
    public System.IObservable<T> ToObservable() { return default(System.IObservable<T>); }
    public System.IObservable<T> ToObservable(System.Reactive.Concurrency.IScheduler scheduler) { return default(System.IObservable<T>); }
  }
  public enum NotificationKind {
    OnCompleted = 2,
    OnError = 1,
    OnNext = 0,
  }
  public abstract partial class ObservableBase<T> : System.IObservable<T> {
    protected ObservableBase() { }
    public System.IDisposable Subscribe(System.IObserver<T> observer) { return default(System.IDisposable); }
    protected abstract System.IDisposable SubscribeCore(System.IObserver<T> observer);
  }
  public static partial class Observer {
    public static System.IObserver<T> AsObserver<T>(this System.IObserver<T> observer) { return default(System.IObserver<T>); }
    public static System.IObserver<T> Checked<T>(this System.IObserver<T> observer) { return default(System.IObserver<T>); }
    public static System.IObserver<T> Create<T>(System.Action<T> onNext) { return default(System.IObserver<T>); }
    public static System.IObserver<T> Create<T>(System.Action<T> onNext, System.Action onCompleted) { return default(System.IObserver<T>); }
    public static System.IObserver<T> Create<T>(System.Action<T> onNext, System.Action<System.Exception> onError) { return default(System.IObserver<T>); }
    public static System.IObserver<T> Create<T>(System.Action<T> onNext, System.Action<System.Exception> onError, System.Action onCompleted) { return default(System.IObserver<T>); }
    public static System.IObserver<T> NotifyOn<T>(this System.IObserver<T> observer, System.Reactive.Concurrency.IScheduler scheduler) { return default(System.IObserver<T>); }
    public static System.IObserver<T> NotifyOn<T>(this System.IObserver<T> observer, System.Threading.SynchronizationContext context) { return default(System.IObserver<T>); }
    public static System.IObserver<T> Synchronize<T>(System.IObserver<T> observer) { return default(System.IObserver<T>); }
    public static System.IObserver<T> Synchronize<T>(System.IObserver<T> observer, bool preventReentrancy) { return default(System.IObserver<T>); }
    public static System.IObserver<T> Synchronize<T>(System.IObserver<T> observer, object gate) { return default(System.IObserver<T>); }
    public static System.IObserver<T> Synchronize<T>(System.IObserver<T> observer, System.Reactive.Concurrency.AsyncLock asyncLock) { return default(System.IObserver<T>); }
    public static System.Action<System.Reactive.Notification<T>> ToNotifier<T>(this System.IObserver<T> observer) { return default(System.Action<System.Reactive.Notification<T>>); }
    public static System.IObserver<T> ToObserver<T>(this System.Action<System.Reactive.Notification<T>> handler) { return default(System.IObserver<T>); }
  }
  public abstract partial class ObserverBase<T> : System.IDisposable, System.IObserver<T> {
    protected ObserverBase() { }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public void OnCompleted() { }
    protected abstract void OnCompletedCore();
    public void OnError(System.Exception error) { }
    protected abstract void OnErrorCore(System.Exception error);
    public void OnNext(T value) { }
    protected abstract void OnNextCore(T value);
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Size=1)]
  public partial struct Unit : System.IEquatable<System.Reactive.Unit> {
    public static System.Reactive.Unit Default { get { return default(System.Reactive.Unit); } }
    public override bool Equals(object obj) { return default(bool); }
    public bool Equals(System.Reactive.Unit other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Reactive.Unit first, System.Reactive.Unit second) { return default(bool); }
    public static bool operator !=(System.Reactive.Unit first, System.Reactive.Unit second) { return default(bool); }
    public override string ToString() { return default(string); }
  }
}
namespace System.Reactive.Concurrency {
  public sealed partial class AsyncLock : System.IDisposable {
    public AsyncLock() { }
    public void Dispose() { }
    public void Wait(System.Action action) { }
  }
  public sealed partial class CurrentThreadScheduler : System.Reactive.Concurrency.LocalScheduler {
    internal CurrentThreadScheduler() { }
    public static System.Reactive.Concurrency.CurrentThreadScheduler Instance { get { return default(System.Reactive.Concurrency.CurrentThreadScheduler); } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static bool IsScheduleRequired { get { return default(bool); } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("This instance property is no longer supported. Use CurrentThreadScheduler.IsScheduleRequired instead. See http://go.microsoft.com/fwlink/?LinkID=260866 for more information.")]
    public bool ScheduleRequired { get { return default(bool); } }
    public override System.IDisposable Schedule<TState>(TState state, System.TimeSpan dueTime, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.IDisposable> action) { return default(System.IDisposable); }
  }
  public sealed partial class DefaultScheduler : System.Reactive.Concurrency.LocalScheduler, System.Reactive.Concurrency.ISchedulerPeriodic {
    internal DefaultScheduler() { }
    public static System.Reactive.Concurrency.DefaultScheduler Instance { get { return default(System.Reactive.Concurrency.DefaultScheduler); } }
    protected override object GetService(System.Type serviceType) { return default(object); }
    public override System.IDisposable Schedule<TState>(TState state, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.IDisposable> action) { return default(System.IDisposable); }
    public override System.IDisposable Schedule<TState>(TState state, System.TimeSpan dueTime, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.IDisposable> action) { return default(System.IDisposable); }
    public System.IDisposable SchedulePeriodic<TState>(TState state, System.TimeSpan period, System.Func<TState, TState> action) { return default(System.IDisposable); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public partial interface IConcurrencyAbstractionLayer {
    bool SupportsLongRunning { get; }
    System.IDisposable QueueUserWorkItem(System.Action<System.Object> action, object state);
    void Sleep(System.TimeSpan timeout);
    System.IDisposable StartPeriodicTimer(System.Action action, System.TimeSpan period);
    System.Reactive.Concurrency.IStopwatch StartStopwatch();
    void StartThread(System.Action<System.Object> action, object state);
    System.IDisposable StartTimer(System.Action<System.Object> action, object state, System.TimeSpan dueTime);
  }
  public sealed partial class ImmediateScheduler : System.Reactive.Concurrency.LocalScheduler {
    internal ImmediateScheduler() { }
    public static System.Reactive.Concurrency.ImmediateScheduler Instance { get { return default(System.Reactive.Concurrency.ImmediateScheduler); } }
    public override System.IDisposable Schedule<TState>(TState state, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.IDisposable> action) { return default(System.IDisposable); }
    public override System.IDisposable Schedule<TState>(TState state, System.TimeSpan dueTime, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.IDisposable> action) { return default(System.IDisposable); }
  }
  public abstract partial class LocalScheduler : System.IServiceProvider, System.Reactive.Concurrency.IScheduler, System.Reactive.Concurrency.IStopwatchProvider {
    protected LocalScheduler() { }
    public virtual System.DateTimeOffset Now { get { return default(System.DateTimeOffset); } }
    protected virtual object GetService(System.Type serviceType) { return default(object); }
    public virtual System.IDisposable Schedule<TState>(TState state, System.DateTimeOffset dueTime, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.IDisposable> action) { return default(System.IDisposable); }
    public virtual System.IDisposable Schedule<TState>(TState state, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.IDisposable> action) { return default(System.IDisposable); }
    public abstract System.IDisposable Schedule<TState>(TState state, System.TimeSpan dueTime, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.IDisposable> action);
    public virtual System.Reactive.Concurrency.IStopwatch StartStopwatch() { return default(System.Reactive.Concurrency.IStopwatch); }
    object System.IServiceProvider.GetService(System.Type serviceType) { return default(object); }
  }
  public abstract partial class ScheduledItem<TAbsolute> : System.IComparable<System.Reactive.Concurrency.ScheduledItem<TAbsolute>>, System.Reactive.Concurrency.IScheduledItem<TAbsolute> where TAbsolute : System.IComparable<TAbsolute> {
    protected ScheduledItem(TAbsolute dueTime, System.Collections.Generic.IComparer<TAbsolute> comparer) { }
    public TAbsolute DueTime { get { return default(TAbsolute); } }
    public bool IsCanceled { get { return default(bool); } }
    public void Cancel() { }
    public int CompareTo(System.Reactive.Concurrency.ScheduledItem<TAbsolute> other) { return default(int); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public void Invoke() { }
    protected abstract System.IDisposable InvokeCore();
    public static bool operator ==(System.Reactive.Concurrency.ScheduledItem<TAbsolute> left, System.Reactive.Concurrency.ScheduledItem<TAbsolute> right) { return default(bool); }
    public static bool operator >(System.Reactive.Concurrency.ScheduledItem<TAbsolute> left, System.Reactive.Concurrency.ScheduledItem<TAbsolute> right) { return default(bool); }
    public static bool operator >=(System.Reactive.Concurrency.ScheduledItem<TAbsolute> left, System.Reactive.Concurrency.ScheduledItem<TAbsolute> right) { return default(bool); }
    public static bool operator !=(System.Reactive.Concurrency.ScheduledItem<TAbsolute> left, System.Reactive.Concurrency.ScheduledItem<TAbsolute> right) { return default(bool); }
    public static bool operator <(System.Reactive.Concurrency.ScheduledItem<TAbsolute> left, System.Reactive.Concurrency.ScheduledItem<TAbsolute> right) { return default(bool); }
    public static bool operator <=(System.Reactive.Concurrency.ScheduledItem<TAbsolute> left, System.Reactive.Concurrency.ScheduledItem<TAbsolute> right) { return default(bool); }
  }
  public sealed partial class ScheduledItem<TAbsolute, TValue> : System.Reactive.Concurrency.ScheduledItem<TAbsolute> where TAbsolute : System.IComparable<TAbsolute> {
    public ScheduledItem(System.Reactive.Concurrency.IScheduler scheduler, TValue state, System.Func<System.Reactive.Concurrency.IScheduler, TValue, System.IDisposable> action, TAbsolute dueTime) : base (default(TAbsolute), default(System.Collections.Generic.IComparer<TAbsolute>)) { }
    public ScheduledItem(System.Reactive.Concurrency.IScheduler scheduler, TValue state, System.Func<System.Reactive.Concurrency.IScheduler, TValue, System.IDisposable> action, TAbsolute dueTime, System.Collections.Generic.IComparer<TAbsolute> comparer) : base (default(TAbsolute), default(System.Collections.Generic.IComparer<TAbsolute>)) { }
    protected override System.IDisposable InvokeCore() { return default(System.IDisposable); }
  }
  public static partial class Scheduler {
    public static System.Reactive.Concurrency.CurrentThreadScheduler CurrentThread { get { return default(System.Reactive.Concurrency.CurrentThreadScheduler); } }
    public static System.Reactive.Concurrency.DefaultScheduler Default { get { return default(System.Reactive.Concurrency.DefaultScheduler); } }
    public static System.Reactive.Concurrency.ImmediateScheduler Immediate { get { return default(System.Reactive.Concurrency.ImmediateScheduler); } }
    [System.ObsoleteAttribute("This property is no longer supported due to refactoring of the API surface and elimination of platform-specific dependencies. Please add a reference to the System.Reactive.PlatformServices assembly for your target platform and use NewThreadScheduler.Default to obtain an instance of this scheduler type. See http://go.microsoft.com/fwlink/?LinkID=260866 for more information.")]
    public static System.Reactive.Concurrency.IScheduler NewThread { get { return default(System.Reactive.Concurrency.IScheduler); } }
    public static System.DateTimeOffset Now { get { return default(System.DateTimeOffset); } }
    [System.ObsoleteAttribute("This property is no longer supported due to refactoring of the API surface and elimination of platform-specific dependencies. Please add a reference to the System.Reactive.PlatformServices assembly for your target platform and use TaskPoolScheduler.Default to obtain an instance of this scheduler type. See http://go.microsoft.com/fwlink/?LinkID=260866 for more information.")]
    public static System.Reactive.Concurrency.IScheduler TaskPool { get { return default(System.Reactive.Concurrency.IScheduler); } }
    [System.ObsoleteAttribute("This property is no longer supported due to refactoring of the API surface and elimination of platform-specific dependencies. Consider using Scheduler.Default to obtain the platform's most appropriate pool-based scheduler. In order to access a specific pool-based scheduler, please add a reference to the System.Reactive.PlatformServices assembly for your target platform and use the appropriate scheduler in the System.Reactive.Concurrency namespace. See http://go.microsoft.com/fwlink/?LinkID=260866 for more information.")]
    public static System.Reactive.Concurrency.IScheduler ThreadPool { get { return default(System.Reactive.Concurrency.IScheduler); } }
    public static System.Reactive.Concurrency.ISchedulerLongRunning AsLongRunning(this System.Reactive.Concurrency.IScheduler scheduler) { return default(System.Reactive.Concurrency.ISchedulerLongRunning); }
    public static System.Reactive.Concurrency.ISchedulerPeriodic AsPeriodic(this System.Reactive.Concurrency.IScheduler scheduler) { return default(System.Reactive.Concurrency.ISchedulerPeriodic); }
    public static System.Reactive.Concurrency.IStopwatchProvider AsStopwatchProvider(this System.Reactive.Concurrency.IScheduler scheduler) { return default(System.Reactive.Concurrency.IStopwatchProvider); }
    public static System.Reactive.Concurrency.IScheduler Catch<TException>(this System.Reactive.Concurrency.IScheduler scheduler, System.Func<TException, System.Boolean> handler) where TException : System.Exception { return default(System.Reactive.Concurrency.IScheduler); }
    public static System.Reactive.Concurrency.IScheduler DisableOptimizations(this System.Reactive.Concurrency.IScheduler scheduler) { return default(System.Reactive.Concurrency.IScheduler); }
    public static System.Reactive.Concurrency.IScheduler DisableOptimizations(this System.Reactive.Concurrency.IScheduler scheduler, params System.Type[] optimizationInterfaces) { return default(System.Reactive.Concurrency.IScheduler); }
    public static System.TimeSpan Normalize(System.TimeSpan timeSpan) { return default(System.TimeSpan); }
    public static System.IDisposable Schedule(this System.Reactive.Concurrency.IScheduler scheduler, System.Action action) { return default(System.IDisposable); }
    public static System.IDisposable Schedule(this System.Reactive.Concurrency.IScheduler scheduler, System.Action<System.Action> action) { return default(System.IDisposable); }
    public static System.IDisposable Schedule(this System.Reactive.Concurrency.IScheduler scheduler, System.DateTimeOffset dueTime, System.Action action) { return default(System.IDisposable); }
    public static System.IDisposable Schedule(this System.Reactive.Concurrency.IScheduler scheduler, System.DateTimeOffset dueTime, System.Action<System.Action<System.DateTimeOffset>> action) { return default(System.IDisposable); }
    public static System.IDisposable Schedule(this System.Reactive.Concurrency.IScheduler scheduler, System.TimeSpan dueTime, System.Action action) { return default(System.IDisposable); }
    public static System.IDisposable Schedule(this System.Reactive.Concurrency.IScheduler scheduler, System.TimeSpan dueTime, System.Action<System.Action<System.TimeSpan>> action) { return default(System.IDisposable); }
    public static System.IDisposable Schedule<TState>(this System.Reactive.Concurrency.IScheduler scheduler, TState state, System.Action<TState, System.Action<TState>> action) { return default(System.IDisposable); }
    public static System.IDisposable Schedule<TState>(this System.Reactive.Concurrency.IScheduler scheduler, TState state, System.DateTimeOffset dueTime, System.Action<TState, System.Action<TState, System.DateTimeOffset>> action) { return default(System.IDisposable); }
    public static System.IDisposable Schedule<TState>(this System.Reactive.Concurrency.IScheduler scheduler, TState state, System.TimeSpan dueTime, System.Action<TState, System.Action<TState, System.TimeSpan>> action) { return default(System.IDisposable); }
    public static System.IDisposable ScheduleAsync(this System.Reactive.Concurrency.IScheduler scheduler, System.DateTimeOffset dueTime, System.Func<System.Reactive.Concurrency.IScheduler, System.Threading.CancellationToken, System.Threading.Tasks.Task<System.IDisposable>> action) { return default(System.IDisposable); }
    public static System.IDisposable ScheduleAsync(this System.Reactive.Concurrency.IScheduler scheduler, System.DateTimeOffset dueTime, System.Func<System.Reactive.Concurrency.IScheduler, System.Threading.CancellationToken, System.Threading.Tasks.Task> action) { return default(System.IDisposable); }
    public static System.IDisposable ScheduleAsync(this System.Reactive.Concurrency.IScheduler scheduler, System.Func<System.Reactive.Concurrency.IScheduler, System.Threading.CancellationToken, System.Threading.Tasks.Task<System.IDisposable>> action) { return default(System.IDisposable); }
    public static System.IDisposable ScheduleAsync(this System.Reactive.Concurrency.IScheduler scheduler, System.Func<System.Reactive.Concurrency.IScheduler, System.Threading.CancellationToken, System.Threading.Tasks.Task> action) { return default(System.IDisposable); }
    public static System.IDisposable ScheduleAsync(this System.Reactive.Concurrency.IScheduler scheduler, System.TimeSpan dueTime, System.Func<System.Reactive.Concurrency.IScheduler, System.Threading.CancellationToken, System.Threading.Tasks.Task<System.IDisposable>> action) { return default(System.IDisposable); }
    public static System.IDisposable ScheduleAsync(this System.Reactive.Concurrency.IScheduler scheduler, System.TimeSpan dueTime, System.Func<System.Reactive.Concurrency.IScheduler, System.Threading.CancellationToken, System.Threading.Tasks.Task> action) { return default(System.IDisposable); }
    public static System.IDisposable ScheduleAsync<TState>(this System.Reactive.Concurrency.IScheduler scheduler, TState state, System.DateTimeOffset dueTime, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.Threading.CancellationToken, System.Threading.Tasks.Task<System.IDisposable>> action) { return default(System.IDisposable); }
    public static System.IDisposable ScheduleAsync<TState>(this System.Reactive.Concurrency.IScheduler scheduler, TState state, System.DateTimeOffset dueTime, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.Threading.CancellationToken, System.Threading.Tasks.Task> action) { return default(System.IDisposable); }
    public static System.IDisposable ScheduleAsync<TState>(this System.Reactive.Concurrency.IScheduler scheduler, TState state, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.Threading.CancellationToken, System.Threading.Tasks.Task<System.IDisposable>> action) { return default(System.IDisposable); }
    public static System.IDisposable ScheduleAsync<TState>(this System.Reactive.Concurrency.IScheduler scheduler, TState state, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.Threading.CancellationToken, System.Threading.Tasks.Task> action) { return default(System.IDisposable); }
    public static System.IDisposable ScheduleAsync<TState>(this System.Reactive.Concurrency.IScheduler scheduler, TState state, System.TimeSpan dueTime, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.Threading.CancellationToken, System.Threading.Tasks.Task<System.IDisposable>> action) { return default(System.IDisposable); }
    public static System.IDisposable ScheduleAsync<TState>(this System.Reactive.Concurrency.IScheduler scheduler, TState state, System.TimeSpan dueTime, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.Threading.CancellationToken, System.Threading.Tasks.Task> action) { return default(System.IDisposable); }
    public static System.IDisposable ScheduleLongRunning(this System.Reactive.Concurrency.ISchedulerLongRunning scheduler, System.Action<System.Reactive.Disposables.ICancelable> action) { return default(System.IDisposable); }
    public static System.IDisposable SchedulePeriodic(this System.Reactive.Concurrency.IScheduler scheduler, System.TimeSpan period, System.Action action) { return default(System.IDisposable); }
    public static System.IDisposable SchedulePeriodic<TState>(this System.Reactive.Concurrency.IScheduler scheduler, TState state, System.TimeSpan period, System.Action<TState> action) { return default(System.IDisposable); }
    public static System.IDisposable SchedulePeriodic<TState>(this System.Reactive.Concurrency.IScheduler scheduler, TState state, System.TimeSpan period, System.Func<TState, TState> action) { return default(System.IDisposable); }
    public static System.Reactive.Concurrency.SchedulerOperation Sleep(this System.Reactive.Concurrency.IScheduler scheduler, System.DateTimeOffset dueTime) { return default(System.Reactive.Concurrency.SchedulerOperation); }
    public static System.Reactive.Concurrency.SchedulerOperation Sleep(this System.Reactive.Concurrency.IScheduler scheduler, System.DateTimeOffset dueTime, System.Threading.CancellationToken cancellationToken) { return default(System.Reactive.Concurrency.SchedulerOperation); }
    public static System.Reactive.Concurrency.SchedulerOperation Sleep(this System.Reactive.Concurrency.IScheduler scheduler, System.TimeSpan dueTime) { return default(System.Reactive.Concurrency.SchedulerOperation); }
    public static System.Reactive.Concurrency.SchedulerOperation Sleep(this System.Reactive.Concurrency.IScheduler scheduler, System.TimeSpan dueTime, System.Threading.CancellationToken cancellationToken) { return default(System.Reactive.Concurrency.SchedulerOperation); }
    public static System.Reactive.Concurrency.IStopwatch StartStopwatch(this System.Reactive.Concurrency.IScheduler scheduler) { return default(System.Reactive.Concurrency.IStopwatch); }
    public static System.Reactive.Concurrency.SchedulerOperation Yield(this System.Reactive.Concurrency.IScheduler scheduler) { return default(System.Reactive.Concurrency.SchedulerOperation); }
    public static System.Reactive.Concurrency.SchedulerOperation Yield(this System.Reactive.Concurrency.IScheduler scheduler, System.Threading.CancellationToken cancellationToken) { return default(System.Reactive.Concurrency.SchedulerOperation); }
  }
  public sealed partial class SchedulerOperation {
    internal SchedulerOperation() { }
    public System.Reactive.Concurrency.SchedulerOperation ConfigureAwait(bool continueOnCapturedContext) { return default(System.Reactive.Concurrency.SchedulerOperation); }
    public System.Reactive.Concurrency.SchedulerOperationAwaiter GetAwaiter() { return default(System.Reactive.Concurrency.SchedulerOperationAwaiter); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class SchedulerOperationAwaiter : System.Runtime.CompilerServices.INotifyCompletion {
    internal SchedulerOperationAwaiter() { }
    public bool IsCompleted { get { return default(bool); } }
    public void GetResult() { }
    public void OnCompleted(System.Action continuation) { }
  }
  public partial class SchedulerQueue<TAbsolute> where TAbsolute : System.IComparable<TAbsolute> {
    public SchedulerQueue() { }
    public SchedulerQueue(int capacity) { }
    public int Count { get { return default(int); } }
    public System.Reactive.Concurrency.ScheduledItem<TAbsolute> Dequeue() { return default(System.Reactive.Concurrency.ScheduledItem<TAbsolute>); }
    public void Enqueue(System.Reactive.Concurrency.ScheduledItem<TAbsolute> scheduledItem) { }
    public System.Reactive.Concurrency.ScheduledItem<TAbsolute> Peek() { return default(System.Reactive.Concurrency.ScheduledItem<TAbsolute>); }
    public bool Remove(System.Reactive.Concurrency.ScheduledItem<TAbsolute> scheduledItem) { return default(bool); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
  public static partial class Synchronization {
    public static System.IObservable<TSource> ObserveOn<TSource>(System.IObservable<TSource> source, System.Reactive.Concurrency.IScheduler scheduler) { return default(System.IObservable<TSource>); }
    public static System.IObservable<TSource> ObserveOn<TSource>(System.IObservable<TSource> source, System.Threading.SynchronizationContext context) { return default(System.IObservable<TSource>); }
    public static System.IObservable<TSource> SubscribeOn<TSource>(System.IObservable<TSource> source, System.Reactive.Concurrency.IScheduler scheduler) { return default(System.IObservable<TSource>); }
    public static System.IObservable<TSource> SubscribeOn<TSource>(System.IObservable<TSource> source, System.Threading.SynchronizationContext context) { return default(System.IObservable<TSource>); }
    public static System.IObservable<TSource> Synchronize<TSource>(System.IObservable<TSource> source) { return default(System.IObservable<TSource>); }
    public static System.IObservable<TSource> Synchronize<TSource>(System.IObservable<TSource> source, object gate) { return default(System.IObservable<TSource>); }
  }
  public partial class SynchronizationContextScheduler : System.Reactive.Concurrency.LocalScheduler {
    public SynchronizationContextScheduler(System.Threading.SynchronizationContext context) { }
    public SynchronizationContextScheduler(System.Threading.SynchronizationContext context, bool alwaysPost) { }
    public override System.IDisposable Schedule<TState>(TState state, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.IDisposable> action) { return default(System.IDisposable); }
    public override System.IDisposable Schedule<TState>(TState state, System.TimeSpan dueTime, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.IDisposable> action) { return default(System.IDisposable); }
  }
}
namespace System.Reactive.Disposables {
  public sealed partial class BooleanDisposable : System.IDisposable, System.Reactive.Disposables.ICancelable {
    public BooleanDisposable() { }
    public bool IsDisposed { get { return default(bool); } }
    public void Dispose() { }
  }
  public sealed partial class CancellationDisposable : System.IDisposable, System.Reactive.Disposables.ICancelable {
    public CancellationDisposable() { }
    public CancellationDisposable(System.Threading.CancellationTokenSource cts) { }
    public bool IsDisposed { get { return default(bool); } }
    public System.Threading.CancellationToken Token { get { return default(System.Threading.CancellationToken); } }
    public void Dispose() { }
  }
  public sealed partial class CompositeDisposable : System.Collections.Generic.ICollection<System.IDisposable>, System.Collections.Generic.IEnumerable<System.IDisposable>, System.Collections.IEnumerable, System.IDisposable, System.Reactive.Disposables.ICancelable {
    public CompositeDisposable() { }
    public CompositeDisposable(System.Collections.Generic.IEnumerable<System.IDisposable> disposables) { }
    public CompositeDisposable(params System.IDisposable[] disposables) { }
    public CompositeDisposable(int capacity) { }
    public int Count { get { return default(int); } }
    public bool IsDisposed { get { return default(bool); } }
    public bool IsReadOnly { get { return default(bool); } }
    public void Add(System.IDisposable item) { }
    public void Clear() { }
    public bool Contains(System.IDisposable item) { return default(bool); }
    public void CopyTo(System.IDisposable[] array, int arrayIndex) { }
    public void Dispose() { }
    public System.Collections.Generic.IEnumerator<System.IDisposable> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.IDisposable>); }
    public bool Remove(System.IDisposable item) { return default(bool); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public sealed partial class ContextDisposable : System.IDisposable, System.Reactive.Disposables.ICancelable {
    public ContextDisposable(System.Threading.SynchronizationContext context, System.IDisposable disposable) { }
    public System.Threading.SynchronizationContext Context { get { return default(System.Threading.SynchronizationContext); } }
    public bool IsDisposed { get { return default(bool); } }
    public void Dispose() { }
  }
  public static partial class Disposable {
    public static System.IDisposable Empty { get { return default(System.IDisposable); } }
    public static System.IDisposable Create(System.Action dispose) { return default(System.IDisposable); }
  }
  public sealed partial class MultipleAssignmentDisposable : System.IDisposable, System.Reactive.Disposables.ICancelable {
    public MultipleAssignmentDisposable() { }
    public System.IDisposable Disposable { get { return default(System.IDisposable); } set { } }
    public bool IsDisposed { get { return default(bool); } }
    public void Dispose() { }
  }
  public sealed partial class RefCountDisposable : System.IDisposable, System.Reactive.Disposables.ICancelable {
    public RefCountDisposable(System.IDisposable disposable) { }
    public bool IsDisposed { get { return default(bool); } }
    public void Dispose() { }
    public System.IDisposable GetDisposable() { return default(System.IDisposable); }
  }
  public sealed partial class ScheduledDisposable : System.IDisposable, System.Reactive.Disposables.ICancelable {
    public ScheduledDisposable(System.Reactive.Concurrency.IScheduler scheduler, System.IDisposable disposable) { }
    public System.IDisposable Disposable { get { return default(System.IDisposable); } }
    public bool IsDisposed { get { return default(bool); } }
    public System.Reactive.Concurrency.IScheduler Scheduler { get { return default(System.Reactive.Concurrency.IScheduler); } }
    public void Dispose() { }
  }
  public sealed partial class SerialDisposable : System.IDisposable, System.Reactive.Disposables.ICancelable {
    public SerialDisposable() { }
    public System.IDisposable Disposable { get { return default(System.IDisposable); } set { } }
    public bool IsDisposed { get { return default(bool); } }
    public void Dispose() { }
  }
  public sealed partial class SingleAssignmentDisposable : System.IDisposable, System.Reactive.Disposables.ICancelable {
    public SingleAssignmentDisposable() { }
    public System.IDisposable Disposable { get { return default(System.IDisposable); } set { } }
    public bool IsDisposed { get { return default(bool); } }
    public void Dispose() { }
  }
}
namespace System.Reactive.PlatformServices {
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public partial class DefaultSystemClock : System.Reactive.PlatformServices.ISystemClock {
    public DefaultSystemClock() { }
    public System.DateTimeOffset UtcNow { get { return default(System.DateTimeOffset); } }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public static partial class HostLifecycleService {
    public static event System.EventHandler<System.Reactive.PlatformServices.HostResumingEventArgs> Resuming { add { } remove { } }
    public static event System.EventHandler<System.Reactive.PlatformServices.HostSuspendingEventArgs> Suspending { add { } remove { } }
    public static void AddRef() { }
    public static void Release() { }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public partial class HostResumingEventArgs : System.EventArgs {
    public HostResumingEventArgs() { }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public partial class HostSuspendingEventArgs : System.EventArgs {
    public HostSuspendingEventArgs() { }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public partial interface IExceptionServices {
    void Rethrow(System.Exception exception);
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public partial interface IHostLifecycleNotifications {
    event System.EventHandler<System.Reactive.PlatformServices.HostResumingEventArgs> Resuming;
    event System.EventHandler<System.Reactive.PlatformServices.HostSuspendingEventArgs> Suspending;
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public partial interface INotifySystemClockChanged {
    event System.EventHandler<System.Reactive.PlatformServices.SystemClockChangedEventArgs> SystemClockChanged;
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public partial interface IPlatformEnlightenmentProvider {
    T GetService<T>(params System.Object[] args) where T : class;
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public partial interface ISystemClock {
    System.DateTimeOffset UtcNow { get; }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public partial class PeriodicTimerSystemClockMonitor : System.Reactive.PlatformServices.INotifySystemClockChanged {
    public PeriodicTimerSystemClockMonitor(System.TimeSpan period) { }
    public event System.EventHandler<System.Reactive.PlatformServices.SystemClockChangedEventArgs> SystemClockChanged { add { } remove { } }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public static partial class PlatformEnlightenmentProvider {
    public static System.Reactive.PlatformServices.IPlatformEnlightenmentProvider Current { get { return default(System.Reactive.PlatformServices.IPlatformEnlightenmentProvider); } set { } }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public static partial class SystemClock {
    public static System.DateTimeOffset UtcNow { get { return default(System.DateTimeOffset); } }
    public static event System.EventHandler<System.Reactive.PlatformServices.SystemClockChangedEventArgs> SystemClockChanged { add { } remove { } }
    public static void AddRef() { }
    public static void Release() { }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public partial class SystemClockChangedEventArgs : System.EventArgs {
    public SystemClockChangedEventArgs() { }
    public SystemClockChangedEventArgs(System.DateTimeOffset oldTime, System.DateTimeOffset newTime) { }
    public System.DateTimeOffset NewTime { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.DateTimeOffset); } }
    public System.DateTimeOffset OldTime { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.DateTimeOffset); } }
  }
}
