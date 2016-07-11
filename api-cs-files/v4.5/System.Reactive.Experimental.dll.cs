namespace System.Reactive {
  [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=false, Inherited=true)]
  [System.Reactive.ExperimentalAttribute]
  public sealed partial class ExperimentalAttribute : System.Attribute {
    public ExperimentalAttribute() { }
  }
  [System.Reactive.ExperimentalAttribute]
  public partial class ListObservable<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IList<T>, System.Collections.IEnumerable, System.IObservable<System.Object> {
    public ListObservable(System.IObservable<T> source) { }
    public int Count { get { return default(int); } }
    public bool IsReadOnly { get { return default(bool); } }
    public T this[int index] { get { return default(T); } set { } }
    public T Value { get { return default(T); } }
    public void Add(T item) { }
    public void Clear() { }
    public bool Contains(T item) { return default(bool); }
    public void CopyTo(T[] array, int arrayIndex) { }
    public System.Collections.Generic.IEnumerator<T> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<T>); }
    public int IndexOf(T item) { return default(int); }
    public void Insert(int index, T item) { }
    public bool Remove(T item) { return default(bool); }
    public void RemoveAt(int index) { }
    public System.IDisposable Subscribe(System.IObserver<System.Object> observer) { return default(System.IDisposable); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
}
namespace System.Reactive.Linq {
  public static partial class ObservableEx {
    [System.Reactive.ExperimentalAttribute]
    public static System.IObservable<System.Reactive.Unit> Create(System.Func<System.Collections.Generic.IEnumerable<System.IObservable<System.Object>>> iteratorMethod) { return default(System.IObservable<System.Reactive.Unit>); }
    [System.Reactive.ExperimentalAttribute]
    public static System.IObservable<TResult> Create<TResult>(System.Func<System.IObserver<TResult>, System.Collections.Generic.IEnumerable<System.IObservable<System.Object>>> iteratorMethod) { return default(System.IObservable<TResult>); }
    [System.Reactive.ExperimentalAttribute]
    public static System.IObservable<TSource> Expand<TSource>(this System.IObservable<TSource> source, System.Func<TSource, System.IObservable<TSource>> selector) { return default(System.IObservable<TSource>); }
    [System.Reactive.ExperimentalAttribute]
    public static System.IObservable<TSource> Expand<TSource>(this System.IObservable<TSource> source, System.Func<TSource, System.IObservable<TSource>> selector, System.Reactive.Concurrency.IScheduler scheduler) { return default(System.IObservable<TSource>); }
    [System.Reactive.ExperimentalAttribute]
    public static System.IObservable<TSource[]> ForkJoin<TSource>(this System.Collections.Generic.IEnumerable<System.IObservable<TSource>> sources) { return default(System.IObservable<TSource[]>); }
    [System.Reactive.ExperimentalAttribute]
    public static System.IObservable<TSource[]> ForkJoin<TSource>(params System.IObservable<TSource>[] sources) { return default(System.IObservable<TSource[]>); }
    [System.Reactive.ExperimentalAttribute]
    public static System.IObservable<TResult> ForkJoin<TSource1, TSource2, TResult>(this System.IObservable<TSource1> first, System.IObservable<TSource2> second, System.Func<TSource1, TSource2, TResult> resultSelector) { return default(System.IObservable<TResult>); }
    [System.Reactive.ExperimentalAttribute]
    public static System.IObservable<TResult> Let<TSource, TResult>(this System.IObservable<TSource> source, System.Func<System.IObservable<TSource>, System.IObservable<TResult>> selector) { return default(System.IObservable<TResult>); }
    [System.Reactive.ExperimentalAttribute]
    public static System.IObservable<TResult> ManySelect<TSource, TResult>(this System.IObservable<TSource> source, System.Func<System.IObservable<TSource>, TResult> selector) { return default(System.IObservable<TResult>); }
    [System.Reactive.ExperimentalAttribute]
    public static System.IObservable<TResult> ManySelect<TSource, TResult>(this System.IObservable<TSource> source, System.Func<System.IObservable<TSource>, TResult> selector, System.Reactive.Concurrency.IScheduler scheduler) { return default(System.IObservable<TResult>); }
    [System.Reactive.ExperimentalAttribute]
    public static System.Reactive.ListObservable<TSource> ToListObservable<TSource>(this System.IObservable<TSource> source) { return default(System.Reactive.ListObservable<TSource>); }
  }
  [System.Reactive.Linq.LocalQueryMethodImplementationTypeAttribute(typeof(System.Reactive.Linq.ObservableEx))]
  public static partial class QbservableEx {
    [System.Reactive.ExperimentalAttribute]
    public static System.Reactive.Linq.IQbservable<System.Reactive.Unit> Create(this System.Reactive.Linq.IQbservableProvider provider, System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<System.IObservable<System.Object>>>> iteratorMethod) { return default(System.Reactive.Linq.IQbservable<System.Reactive.Unit>); }
    [System.Reactive.ExperimentalAttribute]
    public static System.Reactive.Linq.IQbservable<TResult> Create<TResult>(this System.Reactive.Linq.IQbservableProvider provider, System.Linq.Expressions.Expression<System.Func<System.IObserver<TResult>, System.Collections.Generic.IEnumerable<System.IObservable<System.Object>>>> iteratorMethod) { return default(System.Reactive.Linq.IQbservable<TResult>); }
    [System.Reactive.ExperimentalAttribute]
    public static System.Reactive.Linq.IQbservable<TSource> Expand<TSource>(this System.Reactive.Linq.IQbservable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, System.IObservable<TSource>>> selector) { return default(System.Reactive.Linq.IQbservable<TSource>); }
    [System.Reactive.ExperimentalAttribute]
    public static System.Reactive.Linq.IQbservable<TSource> Expand<TSource>(this System.Reactive.Linq.IQbservable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, System.IObservable<TSource>>> selector, System.Reactive.Concurrency.IScheduler scheduler) { return default(System.Reactive.Linq.IQbservable<TSource>); }
    [System.Reactive.ExperimentalAttribute]
    public static System.Reactive.Linq.IQbservable<TSource[]> ForkJoin<TSource>(this System.Reactive.Linq.IQbservableProvider provider, System.Collections.Generic.IEnumerable<System.IObservable<TSource>> sources) { return default(System.Reactive.Linq.IQbservable<TSource[]>); }
    [System.Reactive.ExperimentalAttribute]
    public static System.Reactive.Linq.IQbservable<TSource[]> ForkJoin<TSource>(this System.Reactive.Linq.IQbservableProvider provider, params System.IObservable<TSource>[] sources) { return default(System.Reactive.Linq.IQbservable<TSource[]>); }
    [System.Reactive.ExperimentalAttribute]
    public static System.Reactive.Linq.IQbservable<TResult> ForkJoin<TSource1, TSource2, TResult>(this System.Reactive.Linq.IQbservable<TSource1> first, System.IObservable<TSource2> second, System.Linq.Expressions.Expression<System.Func<TSource1, TSource2, TResult>> resultSelector) { return default(System.Reactive.Linq.IQbservable<TResult>); }
    [System.Reactive.ExperimentalAttribute]
    public static System.Reactive.Linq.IQbservable<TResult> Let<TSource, TResult>(this System.Reactive.Linq.IQbservable<TSource> source, System.Linq.Expressions.Expression<System.Func<System.IObservable<TSource>, System.IObservable<TResult>>> selector) { return default(System.Reactive.Linq.IQbservable<TResult>); }
    [System.Reactive.ExperimentalAttribute]
    public static System.Reactive.Linq.IQbservable<TResult> ManySelect<TSource, TResult>(this System.Reactive.Linq.IQbservable<TSource> source, System.Linq.Expressions.Expression<System.Func<System.IObservable<TSource>, TResult>> selector) { return default(System.Reactive.Linq.IQbservable<TResult>); }
    [System.Reactive.ExperimentalAttribute]
    public static System.Reactive.Linq.IQbservable<TResult> ManySelect<TSource, TResult>(this System.Reactive.Linq.IQbservable<TSource> source, System.Linq.Expressions.Expression<System.Func<System.IObservable<TSource>, TResult>> selector, System.Reactive.Concurrency.IScheduler scheduler) { return default(System.Reactive.Linq.IQbservable<TResult>); }
  }
}
