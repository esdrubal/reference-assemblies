namespace System.Reactive {
  public partial interface IEventPattern<out TSender, out TEventArgs> where TEventArgs : System.EventArgs {
    TEventArgs EventArgs { get; }
    TSender Sender { get; }
  }
  public partial interface IEventPatternSource<TEventArgs> where TEventArgs : System.EventArgs {
    event System.EventHandler<TEventArgs> OnNext;
  }
  public partial interface IEventSource<out T> {
    event System.Action<T> OnNext;
  }
  public partial interface IObserver<in TValue, out TResult> {
    TResult OnCompleted();
    TResult OnError(System.Exception exception);
    TResult OnNext(TValue value);
  }
}
namespace System.Reactive.Concurrency {
  public partial interface IScheduledItem<TAbsolute> {
    TAbsolute DueTime { get; }
    void Invoke();
  }
  public partial interface IScheduler {
    System.DateTimeOffset Now { get; }
    System.IDisposable Schedule<TState>(TState state, System.DateTimeOffset dueTime, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.IDisposable> action);
    System.IDisposable Schedule<TState>(TState state, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.IDisposable> action);
    System.IDisposable Schedule<TState>(TState state, System.TimeSpan dueTime, System.Func<System.Reactive.Concurrency.IScheduler, TState, System.IDisposable> action);
  }
  public partial interface ISchedulerLongRunning {
    System.IDisposable ScheduleLongRunning<TState>(TState state, System.Action<TState, System.Reactive.Disposables.ICancelable> action);
  }
  public partial interface ISchedulerPeriodic {
    System.IDisposable SchedulePeriodic<TState>(TState state, System.TimeSpan period, System.Func<TState, TState> action);
  }
  public partial interface IStopwatch {
    System.TimeSpan Elapsed { get; }
  }
  public partial interface IStopwatchProvider {
    System.Reactive.Concurrency.IStopwatch StartStopwatch();
  }
}
namespace System.Reactive.Disposables {
  public partial interface ICancelable : System.IDisposable {
    bool IsDisposed { get; }
  }
}
namespace System.Reactive.Linq {
  public partial interface IGroupedObservable<out TKey, out TElement> : System.IObservable<TElement> {
    TKey Key { get; }
  }
  public partial interface IQbservable {
    System.Type ElementType { get; }
    System.Linq.Expressions.Expression Expression { get; }
    System.Reactive.Linq.IQbservableProvider Provider { get; }
  }
  public partial interface IQbservable<out T> : System.IObservable<T>, System.Reactive.Linq.IQbservable {
  }
  public partial interface IQbservableProvider {
    System.Reactive.Linq.IQbservable<TResult> CreateQuery<TResult>(System.Linq.Expressions.Expression expression);
  }
}
namespace System.Reactive.Subjects {
  public partial interface IConnectableObservable<out T> : System.IObservable<T> {
    System.IDisposable Connect();
  }
  public partial interface ISubject<T> : System.IObservable<T>, System.IObserver<T>, System.Reactive.Subjects.ISubject<T, T> {
  }
  public partial interface ISubject<in TSource, out TResult> : System.IObservable<TResult>, System.IObserver<TSource> {
  }
}
