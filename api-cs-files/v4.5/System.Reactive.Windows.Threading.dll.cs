namespace System.Reactive.Concurrency {
  public partial class DispatcherScheduler : System.Reactive.Concurrency.LocalScheduler, System.Reactive.Concurrency.ISchedulerPeriodic {
    public DispatcherScheduler(System.Windows.Threading.Dispatcher dispatcher) { }
    public static System.Reactive.Concurrency.DispatcherScheduler Current { get { return default(System.Reactive.Concurrency.DispatcherScheduler); } }
    public System.Windows.Threading.Dispatcher Dispatcher { get { return default(System.Windows.Threading.Dispatcher); } }
    [System.ObsoleteAttribute("Use the Current property to retrieve the DispatcherScheduler instance for the current thread's Dispatcher object. See http://go.microsoft.com/fwlink/?LinkID=260866 for more information.")]
    public static System.Reactive.Concurrency.DispatcherScheduler Instance { get { return default(System.Reactive.Concurrency.DispatcherScheduler); } }
    public override System.IDisposable Schedule<TState>(TState state, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.IDisposable> action) { return default(System.IDisposable); }
    public override System.IDisposable Schedule<TState>(TState state, System.TimeSpan dueTime, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.IDisposable> action) { return default(System.IDisposable); }
    public System.IDisposable SchedulePeriodic<TState>(TState state, System.TimeSpan period, System.Func<TState, TState> action) { return default(System.IDisposable); }
  }
}
namespace System.Reactive.Linq {
  public static partial class DispatcherObservable {
    public static System.IObservable<TSource> ObserveOn<TSource>(this System.IObservable<TSource> source, System.Reactive.Concurrency.DispatcherScheduler scheduler) { return default(System.IObservable<TSource>); }
    public static System.IObservable<TSource> ObserveOn<TSource>(this System.IObservable<TSource> source, System.Windows.Threading.Dispatcher dispatcher) { return default(System.IObservable<TSource>); }
    public static System.IObservable<TSource> ObserveOn<TSource>(this System.IObservable<TSource> source, System.Windows.Threading.DispatcherObject dispatcherObject) { return default(System.IObservable<TSource>); }
    public static System.IObservable<TSource> ObserveOnDispatcher<TSource>(this System.IObservable<TSource> source) { return default(System.IObservable<TSource>); }
    public static System.IObservable<TSource> SubscribeOn<TSource>(this System.IObservable<TSource> source, System.Reactive.Concurrency.DispatcherScheduler scheduler) { return default(System.IObservable<TSource>); }
    public static System.IObservable<TSource> SubscribeOn<TSource>(this System.IObservable<TSource> source, System.Windows.Threading.Dispatcher dispatcher) { return default(System.IObservable<TSource>); }
    public static System.IObservable<TSource> SubscribeOn<TSource>(this System.IObservable<TSource> source, System.Windows.Threading.DispatcherObject dispatcherObject) { return default(System.IObservable<TSource>); }
    public static System.IObservable<TSource> SubscribeOnDispatcher<TSource>(this System.IObservable<TSource> source) { return default(System.IObservable<TSource>); }
  }
}
