namespace System.Reactive.Concurrency {
  public partial class ControlScheduler : System.Reactive.Concurrency.LocalScheduler, System.Reactive.Concurrency.ISchedulerPeriodic {
    public ControlScheduler(System.Windows.Forms.Control control) { }
    public System.Windows.Forms.Control Control { get { return default(System.Windows.Forms.Control); } }
    public override System.IDisposable Schedule<TState>(TState state, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.IDisposable> action) { return default(System.IDisposable); }
    public override System.IDisposable Schedule<TState>(TState state, System.TimeSpan dueTime, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.IDisposable> action) { return default(System.IDisposable); }
    public System.IDisposable SchedulePeriodic<TState>(TState state, System.TimeSpan period, System.Func<TState, TState> action) { return default(System.IDisposable); }
  }
}
namespace System.Reactive.Linq {
  public static partial class ControlObservable {
    public static System.IObservable<TSource> ObserveOn<TSource>(this System.IObservable<TSource> source, System.Windows.Forms.Control control) { return default(System.IObservable<TSource>); }
    public static System.IObservable<TSource> SubscribeOn<TSource>(this System.IObservable<TSource> source, System.Windows.Forms.Control control) { return default(System.IObservable<TSource>); }
  }
}
