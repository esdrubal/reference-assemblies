namespace System.Reactive.Concurrency {
  public sealed partial class EventLoopScheduler : System.Reactive.Concurrency.LocalScheduler, System.IDisposable, System.Reactive.Concurrency.ISchedulerPeriodic {
    public EventLoopScheduler() { }
    public EventLoopScheduler(System.Func<System.Threading.ThreadStart, System.Threading.Thread> threadFactory) { }
    public void Dispose() { }
    public override System.IDisposable Schedule<TState>(TState state, System.TimeSpan dueTime, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.IDisposable> action) { return default(System.IDisposable); }
    public System.IDisposable SchedulePeriodic<TState>(TState state, System.TimeSpan period, System.Func<TState, TState> action) { return default(System.IDisposable); }
    public override System.Reactive.Concurrency.IStopwatch StartStopwatch() { return default(System.Reactive.Concurrency.IStopwatch); }
  }
  public sealed partial class NewThreadScheduler : System.Reactive.Concurrency.LocalScheduler, System.Reactive.Concurrency.ISchedulerLongRunning, System.Reactive.Concurrency.ISchedulerPeriodic {
    public NewThreadScheduler() { }
    public NewThreadScheduler(System.Func<System.Threading.ThreadStart, System.Threading.Thread> threadFactory) { }
    public static System.Reactive.Concurrency.NewThreadScheduler Default { get { return default(System.Reactive.Concurrency.NewThreadScheduler); } }
    public override System.IDisposable Schedule<TState>(TState state, System.TimeSpan dueTime, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.IDisposable> action) { return default(System.IDisposable); }
    public System.IDisposable ScheduleLongRunning<TState>(TState state, System.Action<TState, System.Reactive.Disposables.ICancelable> action) { return default(System.IDisposable); }
    public System.IDisposable SchedulePeriodic<TState>(TState state, System.TimeSpan period, System.Func<TState, TState> action) { return default(System.IDisposable); }
    public override System.Reactive.Concurrency.IStopwatch StartStopwatch() { return default(System.Reactive.Concurrency.IStopwatch); }
  }
  public sealed partial class TaskPoolScheduler : System.Reactive.Concurrency.LocalScheduler, System.Reactive.Concurrency.ISchedulerLongRunning, System.Reactive.Concurrency.ISchedulerPeriodic {
    public TaskPoolScheduler(System.Threading.Tasks.TaskFactory taskFactory) { }
    public static System.Reactive.Concurrency.TaskPoolScheduler Default { get { return default(System.Reactive.Concurrency.TaskPoolScheduler); } }
    public override System.IDisposable Schedule<TState>(TState state, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.IDisposable> action) { return default(System.IDisposable); }
    public override System.IDisposable Schedule<TState>(TState state, System.TimeSpan dueTime, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.IDisposable> action) { return default(System.IDisposable); }
    public System.IDisposable ScheduleLongRunning<TState>(TState state, System.Action<TState, System.Reactive.Disposables.ICancelable> action) { return default(System.IDisposable); }
    public System.IDisposable SchedulePeriodic<TState>(TState state, System.TimeSpan period, System.Func<TState, TState> action) { return default(System.IDisposable); }
    public override System.Reactive.Concurrency.IStopwatch StartStopwatch() { return default(System.Reactive.Concurrency.IStopwatch); }
  }
  public sealed partial class ThreadPoolScheduler : System.Reactive.Concurrency.LocalScheduler, System.Reactive.Concurrency.ISchedulerLongRunning, System.Reactive.Concurrency.ISchedulerPeriodic {
    internal ThreadPoolScheduler() { }
    public static System.Reactive.Concurrency.ThreadPoolScheduler Instance { get { return default(System.Reactive.Concurrency.ThreadPoolScheduler); } }
    public override System.IDisposable Schedule<TState>(TState state, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.IDisposable> action) { return default(System.IDisposable); }
    public override System.IDisposable Schedule<TState>(TState state, System.TimeSpan dueTime, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.IDisposable> action) { return default(System.IDisposable); }
    public System.IDisposable ScheduleLongRunning<TState>(TState state, System.Action<TState, System.Reactive.Disposables.ICancelable> action) { return default(System.IDisposable); }
    public System.IDisposable SchedulePeriodic<TState>(TState state, System.TimeSpan period, System.Func<TState, TState> action) { return default(System.IDisposable); }
    public override System.Reactive.Concurrency.IStopwatch StartStopwatch() { return default(System.Reactive.Concurrency.IStopwatch); }
  }
}
namespace System.Reactive.PlatformServices {
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public partial class CurrentPlatformEnlightenmentProvider : System.Reactive.PlatformServices.IPlatformEnlightenmentProvider {
    public CurrentPlatformEnlightenmentProvider() { }
    public virtual T GetService<T>(System.Object[] args) where T : class { return default(T); }
  }
  public static partial class EnlightenmentProvider {
    public static bool EnsureLoaded() { return default(bool); }
  }
}
