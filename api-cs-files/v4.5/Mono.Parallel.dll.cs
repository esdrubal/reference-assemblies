namespace Mono.Collections.Concurrent {
  public partial class ConcurrentOrderedList<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable {
    public ConcurrentOrderedList() { }
    public ConcurrentOrderedList(System.Collections.Generic.IEqualityComparer<T> comparer) { }
    public System.Collections.Generic.IEqualityComparer<T> Comparer { get { return default(System.Collections.Generic.IEqualityComparer<T>); } }
    public int Count { get { return default(int); } }
    bool System.Collections.Generic.ICollection<T>.IsReadOnly { get { return default(bool); } }
    public void Clear() { }
    public bool Contains(T data) { return default(bool); }
    public bool ContainsHash(int key) { return default(bool); }
    public void CopyTo(T[] array, int startIndex) { }
    void System.Collections.Generic.ICollection<T>.Add(T item) { }
    bool System.Collections.Generic.ICollection<T>.Remove(T item) { return default(bool); }
    System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { return default(System.Collections.Generic.IEnumerator<T>); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    public bool TryAdd(T data) { return default(bool); }
    public bool TryGetFromHash(int key, out T data) { data = default(T); return default(bool); }
    public bool TryPop(out T data) { data = default(T); return default(bool); }
    public bool TryRemove(T data) { return default(bool); }
    public bool TryRemoveHash(int key, out T data) { data = default(T); return default(bool); }
  }
  public partial class ConcurrentSkipList<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable {
    public ConcurrentSkipList() { }
    public ConcurrentSkipList(System.Collections.Generic.IEqualityComparer<T> comparer) { }
    public int Count { get { return default(int); } }
    bool System.Collections.Generic.ICollection<T>.IsReadOnly { get { return default(bool); } }
    public void Clear() { }
    public bool Contains(T value) { return default(bool); }
    public bool ContainsHash(int hash) { return default(bool); }
    public void CopyTo(T[] array, int startIndex) { }
    public bool Remove(T value) { return default(bool); }
    void System.Collections.Generic.ICollection<T>.Add(T item) { }
    System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { return default(System.Collections.Generic.IEnumerator<T>); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    public T[] ToArray() { return default(T[]); }
    public bool TryAdd(T value) { return default(bool); }
    public bool TryGetFromHash(int hash, out T value) { value = default(T); return default(bool); }
  }
}
namespace Mono.Threading {
  public partial class AtomicBoolean {
    public AtomicBoolean() { }
    public bool Value { get { return default(bool); } set { } }
    public bool CompareAndExchange(bool expected, bool newVal) { return default(bool); }
    public bool Equals(Mono.Threading.AtomicBoolean rhs) { return default(bool); }
    public override bool Equals(object rhs) { return default(bool); }
    public bool Exchange(bool newVal) { return default(bool); }
    public static Mono.Threading.AtomicBoolean FromValue(bool value) { return default(Mono.Threading.AtomicBoolean); }
    public override int GetHashCode() { return default(int); }
    public static explicit operator bool (Mono.Threading.AtomicBoolean rhs) { return default(bool); }
    public static implicit operator Mono.Threading.AtomicBoolean (bool rhs) { return default(Mono.Threading.AtomicBoolean); }
    public bool TryRelaxedSet() { return default(bool); }
    public bool TrySet() { return default(bool); }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct AtomicBooleanValue {
    public bool Value { get { return default(bool); } set { } }
    public bool CompareAndExchange(bool expected, bool newVal) { return default(bool); }
    public bool Equals(Mono.Threading.AtomicBooleanValue rhs) { return default(bool); }
    public override bool Equals(object rhs) { return default(bool); }
    public bool Exchange(bool newVal) { return default(bool); }
    public static Mono.Threading.AtomicBooleanValue FromValue(bool value) { return default(Mono.Threading.AtomicBooleanValue); }
    public override int GetHashCode() { return default(int); }
    public static explicit operator bool (Mono.Threading.AtomicBooleanValue rhs) { return default(bool); }
    public static implicit operator Mono.Threading.AtomicBooleanValue (bool rhs) { return default(Mono.Threading.AtomicBooleanValue); }
    public bool TryRelaxedSet() { return default(bool); }
    public bool TrySet() { return default(bool); }
  }
  public partial class CSnzi {
    public CSnzi() { }
    public Mono.Threading.CSnziNode Arrive() { return default(Mono.Threading.CSnziNode); }
    public bool Close() { return default(bool); }
    public bool Depart(Mono.Threading.CSnziNode node) { return default(bool); }
    public void Open() { }
    public System.Tuple<System.Boolean, Mono.Threading.CSnziState> Query() { return default(System.Tuple<System.Boolean, Mono.Threading.CSnziState>); }
  }
  public abstract partial class CSnziNode {
    protected CSnziNode() { }
  }
  public enum CSnziState {
    Closed = 1,
    Open = 0,
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct ReaderWriterLockSlimmer {
    public void EnterReadLock(ref bool taken) { }
    public void EnterWriteLock(ref bool taken) { }
    public void ExitReadLock() { }
    public void ExitWriteLock() { }
    public void TryEnterReadLock(ref bool taken) { }
    public void TryEnterWriteLock(ref bool taken) { }
  }
  public partial class Snzi {
    public Snzi() { }
    public bool IsSet { get { return default(bool); } }
    public void Decrement() { }
    public void Increment() { }
    public void Reset() { }
  }
  public partial class SpinLockWrapper {
    public System.Threading.SpinLock Lock;
    public SpinLockWrapper() { }
    public SpinLockWrapper(bool enableTracking) { }
  }
}
namespace Mono.Threading.Tasks {
  public partial class CyclicDeque<T> : Mono.Threading.Tasks.IConcurrentDeque<T> {
    public CyclicDeque() { }
    public bool IsEmpty { get { return default(bool); } }
    public System.Collections.Generic.IEnumerable<T> GetEnumerable() { return default(System.Collections.Generic.IEnumerable<T>); }
    public bool PeekBottom(out T obj) { obj = default(T); return default(bool); }
    public Mono.Threading.Tasks.PopResult PopBottom(out T obj) { obj = default(T); return default(Mono.Threading.Tasks.PopResult); }
    public Mono.Threading.Tasks.PopResult PopTop(out T obj) { obj = default(T); return default(Mono.Threading.Tasks.PopResult); }
    public void PushBottom(T obj) { }
  }
  public partial interface IConcurrentDeque<T> {
    System.Collections.Generic.IEnumerable<T> GetEnumerable();
    Mono.Threading.Tasks.PopResult PopBottom(out T obj);
    Mono.Threading.Tasks.PopResult PopTop(out T obj);
    void PushBottom(T obj);
  }
  public enum PopResult {
    Abort = 2,
    Empty = 1,
    Succeed = 0,
  }
}
