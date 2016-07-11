namespace Microsoft.VisualC.StlClr {
  [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1005")]
  [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Naming", "CA1708")]
  public delegate TResult BinaryDelegate<TArg1, TArg2, TResult>(TArg1 A_0, TArg2 A_1);
  public partial class DequeEnumerator<TValue> : Microsoft.VisualC.StlClr.DequeEnumeratorBase<TValue>, System.Collections.Generic.IEnumerator<TValue> {
    [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline this type of method across NGen image boundaries")]
    public DequeEnumerator(Microsoft.VisualC.StlClr.IDeque<TValue> _Cont, int _First) : base (default(Microsoft.VisualC.StlClr.IDeque<TValue>), default(int)) { }
    public virtual new TValue Current { get { return default(TValue); } set { } }
    public sealed override void Dispose() { }
    protected virtual void Dispose(bool A_0) { }
    public override bool MoveNext() { return default(bool); }
    public override void Reset() { }
  }
  [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1038")]
  public partial class DequeEnumeratorBase<TValue> : System.Collections.IEnumerator {
    public DequeEnumeratorBase(Microsoft.VisualC.StlClr.IDeque<TValue> _Cont, int _First) { }
    public virtual object Current { get { return default(object); } set { } }
    public virtual bool MoveNext() { return default(bool); }
    public virtual void Reset() { }
  }
  public partial class GenericPair<TValue1, TValue2> {
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1051")]
    public TValue1 first;
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1051")]
    public TValue2 second;
    [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline this type of method across NGen image boundaries")]
    public GenericPair() { }
    public GenericPair(TValue1 _Val1) { }
    public GenericPair(TValue1 _Val1, TValue2 _Val2) { }
    public GenericPair(Microsoft.VisualC.StlClr.GenericPair<TValue1, TValue2> _Right) { }
    public GenericPair(ref System.Collections.Generic.KeyValuePair<TValue1, TValue2> _Right) { }
    public override bool Equals(object _Right_arg) { return default(bool); }
    public Microsoft.VisualC.StlClr.GenericPair<TValue1, TValue2> op_Assign(Microsoft.VisualC.StlClr.GenericPair<TValue1, TValue2> _Right) { return default(Microsoft.VisualC.StlClr.GenericPair<TValue1, TValue2>); }
    public void swap(Microsoft.VisualC.StlClr.GenericPair<TValue1, TValue2> _Right) { }
  }
  public partial class HashEnumerator<TKey, TValue> : Microsoft.VisualC.StlClr.HashEnumeratorBase<TKey, TValue>, System.Collections.Generic.IEnumerator<TValue> {
    [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline this type of method across NGen image boundaries")]
    public HashEnumerator(Microsoft.VisualC.StlClr.Generic.INode<TValue> _First) : base (default(Microsoft.VisualC.StlClr.Generic.INode<TValue>)) { }
    public virtual new TValue Current { get { return default(TValue); } set { } }
    public sealed override void Dispose() { }
    protected virtual void Dispose(bool A_0) { }
    public override bool MoveNext() { return default(bool); }
    public override void Reset() { }
  }
  [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1038")]
  public partial class HashEnumeratorBase<TKey, TValue> : System.Collections.IEnumerator {
    public HashEnumeratorBase(Microsoft.VisualC.StlClr.Generic.INode<TValue> _First) { }
    public virtual object Current { get { return default(object); } set { } }
    public virtual bool MoveNext() { return default(bool); }
    public virtual void Reset() { }
  }
  public partial interface IDeque<TValue> : Microsoft.VisualC.StlClr.Generic.IRandomAccessContainer<TValue>, System.Collections.ICollection, System.Collections.IEnumerable, System.ICloneable {
    TValue back_item { get; set; }
    TValue front_item { get; set; }
    TValue this[int _Pos] { get; set; }
    void assign(Microsoft.VisualC.StlClr.Generic.IInputIterator<TValue> _First, Microsoft.VisualC.StlClr.Generic.IInputIterator<TValue> _Last);
    void assign(System.Collections.IEnumerable _Right);
    void assign(int _Count, TValue _Val);
    TValue at(int _Pos);
    TValue back();
    void begin(ref Microsoft.VisualC.StlClr.Generic.ContainerRandomAccessIterator<TValue> );
    int begin_bias();
    void clear();
    bool empty();
    void end(ref Microsoft.VisualC.StlClr.Generic.ContainerRandomAccessIterator<TValue> );
    int end_bias();
    void erase(ref Microsoft.VisualC.StlClr.Generic.ContainerRandomAccessIterator<TValue> , Microsoft.VisualC.StlClr.Generic.ContainerRandomAccessIterator<TValue> _Where);
    void erase(ref Microsoft.VisualC.StlClr.Generic.ContainerRandomAccessIterator<TValue> , Microsoft.VisualC.StlClr.Generic.ContainerRandomAccessIterator<TValue> _First_iter, Microsoft.VisualC.StlClr.Generic.ContainerRandomAccessIterator<TValue> _Last_iter);
    TValue front();
    uint get_generation();
    void insert(Microsoft.VisualC.StlClr.Generic.ContainerRandomAccessIterator<TValue> _Where, Microsoft.VisualC.StlClr.Generic.IInputIterator<TValue> _First, Microsoft.VisualC.StlClr.Generic.IInputIterator<TValue> _Last);
    void insert(Microsoft.VisualC.StlClr.Generic.ContainerRandomAccessIterator<TValue> _Where_iter, System.Collections.IEnumerable _Right);
    void insert(Microsoft.VisualC.StlClr.Generic.ContainerRandomAccessIterator<TValue> _Where, int _Count, TValue _Val);
    void insert(ref Microsoft.VisualC.StlClr.Generic.ContainerRandomAccessIterator<TValue> , Microsoft.VisualC.StlClr.Generic.ContainerRandomAccessIterator<TValue> _Where, TValue _Val);
    void pop_back();
    void pop_front();
    void push_back(TValue _Val);
    void push_front(TValue _Val);
    void rbegin(ref Microsoft.VisualC.StlClr.Generic.ReverseRandomAccessIterator<TValue> );
    void rend(ref Microsoft.VisualC.StlClr.Generic.ReverseRandomAccessIterator<TValue> );
    void resize(int _Newsize);
    void resize(int _Newsize, TValue _Val);
    int size();
    void swap(Microsoft.VisualC.StlClr.IDeque<TValue> A_0);
  }
  [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1005")]
  public partial interface IHash<TKey, TValue> : Microsoft.VisualC.StlClr.Generic.IBidirectionalContainer<TValue>, System.Collections.ICollection, System.Collections.IEnumerable, System.ICloneable {
    void begin(ref Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> );
    int bucket_count();
    void clear();
    int count(TKey _Keyval);
    bool empty();
    void end(ref Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> );
    void equal_range(ref Microsoft.VisualC.StlClr.GenericPair<Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue>, Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue>> , TKey _Keyval);
    int erase(TKey _Keyval);
    void erase(ref Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> , Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> _Where);
    void erase(ref Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> , Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> _First_iter, Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> _Last_iter);
    void find(ref Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> , TKey _Keyval);
    Microsoft.VisualC.StlClr.UnaryDelegate<TKey, System.Int32> hash_delegate();
    void insert(ref Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> , Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> _Where, TValue _Val);
    void insert(Microsoft.VisualC.StlClr.Generic.IInputIterator<TValue> _First, Microsoft.VisualC.StlClr.Generic.IInputIterator<TValue> _Last);
    void insert(ref Microsoft.VisualC.StlClr.GenericPair<Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue>, System.Boolean> , TValue _Val);
    void insert(System.Collections.IEnumerable _Right);
    Microsoft.VisualC.StlClr.BinaryDelegate<TKey, TKey, System.Boolean> key_comp();
    float load_factor();
    void lower_bound(ref Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> , TKey _Keyval);
    float max_load_factor();
    void max_load_factor(float _Newmax);
    void rbegin(ref Microsoft.VisualC.StlClr.Generic.ReverseBidirectionalIterator<TValue> );
    void rehash(int _Buckets);
    void rend(ref Microsoft.VisualC.StlClr.Generic.ReverseBidirectionalIterator<TValue> );
    int size();
    void swap(Microsoft.VisualC.StlClr.IHash<TKey, TValue> _Right);
    void upper_bound(ref Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> , TKey _Keyval);
    Microsoft.VisualC.StlClr.BinaryDelegate<TValue, TValue, System.Boolean> value_comp();
  }
  public partial interface IList<TValue> : Microsoft.VisualC.StlClr.Generic.IBidirectionalContainer<TValue>, System.Collections.ICollection, System.Collections.IEnumerable, System.ICloneable {
    TValue back_item { get; set; }
    TValue front_item { get; set; }
    void assign(Microsoft.VisualC.StlClr.Generic.IInputIterator<TValue> _First, Microsoft.VisualC.StlClr.Generic.IInputIterator<TValue> _Last);
    void assign(System.Collections.IEnumerable _Right);
    void assign(int _Count, TValue _Val);
    TValue back();
    void begin(ref Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> );
    void clear();
    bool empty();
    void end(ref Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> );
    void erase(ref Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> , Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> _Where);
    void erase(ref Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> , Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> _First_iter, Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> _Last_iter);
    TValue front();
    void insert(Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> _Where, Microsoft.VisualC.StlClr.Generic.IInputIterator<TValue> _First, Microsoft.VisualC.StlClr.Generic.IInputIterator<TValue> _Last);
    void insert(Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> _Where_iter, System.Collections.IEnumerable _Right);
    void insert(Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> _Where, int _Count, TValue _Val);
    void insert(ref Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> , Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> _Where, TValue _Val);
    void merge(Microsoft.VisualC.StlClr.IList<TValue> _Right, Microsoft.VisualC.StlClr.BinaryDelegate<TValue, TValue, System.Boolean> _Pred);
    void pop_back();
    void pop_front();
    void push_back(TValue _Val);
    void push_front(TValue _Val);
    void rbegin(ref Microsoft.VisualC.StlClr.Generic.ReverseBidirectionalIterator<TValue> );
    void remove(TValue _Val);
    void remove_if(Microsoft.VisualC.StlClr.UnaryDelegate<TValue, System.Boolean> _Pred);
    void rend(ref Microsoft.VisualC.StlClr.Generic.ReverseBidirectionalIterator<TValue> );
    void resize(int _Newsize);
    void resize(int _Newsize, TValue _Val);
    void reverse();
    int size();
    void sort(Microsoft.VisualC.StlClr.BinaryDelegate<TValue, TValue, System.Boolean> _Pred);
    void splice(Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> _Where, Microsoft.VisualC.StlClr.IList<TValue> _Right);
    void splice(Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> _Where, Microsoft.VisualC.StlClr.IList<TValue> _Right, Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> _First);
    void splice(Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> _Where, Microsoft.VisualC.StlClr.IList<TValue> _Right, Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> _First, Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> _Last);
    void swap(Microsoft.VisualC.StlClr.IList<TValue> _Right);
    void unique(Microsoft.VisualC.StlClr.BinaryDelegate<TValue, TValue, System.Boolean> _Pred);
  }
  public partial interface IPriorityQueue<TValue, TCont> : System.ICloneable {
    TValue top_item { get; set; }
    void assign(Microsoft.VisualC.StlClr.IPriorityQueue<TValue, TCont> _Right);
    bool empty();
    TCont get_container();
    void pop();
    void push(TValue _Val);
    int size();
    TValue top();
    Microsoft.VisualC.StlClr.BinaryDelegate<TValue, TValue, System.Boolean> value_comp();
  }
  public partial interface IQueue<TValue, TCont> : System.ICloneable {
    void assign(Microsoft.VisualC.StlClr.IQueue<TValue, TCont> _Right);
    TValue back();
    bool empty();
    TValue front();
    TCont get_container();
    void pop();
    void push(TValue _Val);
    int size();
  }
  public partial interface IStack<TValue, TCont> : System.ICloneable {
    TValue top_item { get; set; }
    void assign(Microsoft.VisualC.StlClr.IStack<TValue, TCont> _Right);
    bool empty();
    TCont get_container();
    void pop();
    void push(TValue _Val);
    int size();
    TValue top();
  }
  [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1005")]
  public partial interface ITree<TKey, TValue> : Microsoft.VisualC.StlClr.Generic.IBidirectionalContainer<TValue>, System.Collections.ICollection, System.Collections.IEnumerable, System.ICloneable {
    void begin(ref Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> );
    void clear();
    int count(TKey _Keyval);
    bool empty();
    void end(ref Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> );
    void equal_range(ref Microsoft.VisualC.StlClr.GenericPair<Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue>, Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue>> , TKey _Keyval);
    int erase(TKey _Keyval);
    void erase(ref Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> , Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> _Where);
    void erase(ref Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> , Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> _First_iter, Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> _Last_iter);
    void find(ref Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> , TKey _Keyval);
    void insert(ref Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> , Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> _Where, TValue _Val);
    void insert(Microsoft.VisualC.StlClr.Generic.IInputIterator<TValue> _First, Microsoft.VisualC.StlClr.Generic.IInputIterator<TValue> _Last);
    void insert(ref Microsoft.VisualC.StlClr.GenericPair<Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue>, System.Boolean> , TValue _Val);
    void insert(System.Collections.Generic.IEnumerable<TValue> _Right);
    Microsoft.VisualC.StlClr.BinaryDelegate<TKey, TKey, System.Boolean> key_comp();
    void lower_bound(ref Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> , TKey _Keyval);
    void rbegin(ref Microsoft.VisualC.StlClr.Generic.ReverseBidirectionalIterator<TValue> );
    void rend(ref Microsoft.VisualC.StlClr.Generic.ReverseBidirectionalIterator<TValue> );
    int size();
    void swap(Microsoft.VisualC.StlClr.ITree<TKey, TValue> _Right);
    void upper_bound(ref Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> , TKey _Keyval);
    Microsoft.VisualC.StlClr.BinaryDelegate<TValue, TValue, System.Boolean> value_comp();
  }
  public partial interface IVector<TValue> : Microsoft.VisualC.StlClr.Generic.IRandomAccessContainer<TValue>, System.Collections.ICollection, System.Collections.IEnumerable, System.ICloneable {
    TValue back_item { get; set; }
    TValue front_item { get; set; }
    TValue this[int _Pos] { get; set; }
    void assign(Microsoft.VisualC.StlClr.Generic.IInputIterator<TValue> _First, Microsoft.VisualC.StlClr.Generic.IInputIterator<TValue> _Last);
    void assign(System.Collections.IEnumerable _Right);
    void assign(int _Count, TValue _Val);
    TValue at(int _Pos);
    TValue back();
    void begin(ref Microsoft.VisualC.StlClr.Generic.ContainerRandomAccessIterator<TValue> );
    int capacity();
    void clear();
    bool empty();
    void end(ref Microsoft.VisualC.StlClr.Generic.ContainerRandomAccessIterator<TValue> );
    void erase(ref Microsoft.VisualC.StlClr.Generic.ContainerRandomAccessIterator<TValue> , Microsoft.VisualC.StlClr.Generic.ContainerRandomAccessIterator<TValue> _Where);
    void erase(ref Microsoft.VisualC.StlClr.Generic.ContainerRandomAccessIterator<TValue> , Microsoft.VisualC.StlClr.Generic.ContainerRandomAccessIterator<TValue> _First_iter, Microsoft.VisualC.StlClr.Generic.ContainerRandomAccessIterator<TValue> _Last_iter);
    TValue front();
    uint get_generation();
    void insert(Microsoft.VisualC.StlClr.Generic.ContainerRandomAccessIterator<TValue> _Where, Microsoft.VisualC.StlClr.Generic.IInputIterator<TValue> _First, Microsoft.VisualC.StlClr.Generic.IInputIterator<TValue> _Last);
    void insert(Microsoft.VisualC.StlClr.Generic.ContainerRandomAccessIterator<TValue> _Where_iter, System.Collections.IEnumerable _Right);
    void insert(Microsoft.VisualC.StlClr.Generic.ContainerRandomAccessIterator<TValue> _Where, int _Count, TValue _Val);
    void insert(ref Microsoft.VisualC.StlClr.Generic.ContainerRandomAccessIterator<TValue> , Microsoft.VisualC.StlClr.Generic.ContainerRandomAccessIterator<TValue> _Where, TValue _Val);
    void pop_back();
    void push_back(TValue _Val);
    void rbegin(ref Microsoft.VisualC.StlClr.Generic.ReverseRandomAccessIterator<TValue> );
    void rend(ref Microsoft.VisualC.StlClr.Generic.ReverseRandomAccessIterator<TValue> );
    void reserve(int _Capacity);
    void resize(int _Newsize);
    void resize(int _Newsize, TValue _Val);
    int size();
    void swap(Microsoft.VisualC.StlClr.IVector<TValue> A_0);
  }
  [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1038")]
  public partial class ListEnumerator<TValue> : Microsoft.VisualC.StlClr.ListEnumeratorBase<TValue>, System.Collections.Generic.IEnumerator<TValue> {
    [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline this type of method across NGen image boundaries")]
    public ListEnumerator(Microsoft.VisualC.StlClr.Generic.INode<TValue> _First) : base (default(Microsoft.VisualC.StlClr.Generic.INode<TValue>)) { }
    public virtual new TValue Current { get { return default(TValue); } set { } }
    public sealed override void Dispose() { }
    protected virtual void Dispose(bool A_0) { }
    public override bool MoveNext() { return default(bool); }
    public override void Reset() { }
  }
  [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1038")]
  public partial class ListEnumeratorBase<TValue> : System.Collections.IEnumerator {
    public ListEnumeratorBase(Microsoft.VisualC.StlClr.Generic.INode<TValue> _First) { }
    public virtual object Current { get { return default(object); } set { } }
    public virtual bool MoveNext() { return default(bool); }
    public virtual void Reset() { }
  }
  [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1005")]
  public partial class TreeEnumerator<TKey, TValue> : Microsoft.VisualC.StlClr.TreeEnumeratorBase<TKey, TValue>, System.Collections.Generic.IEnumerator<TValue> {
    [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline this type of method across NGen image boundaries")]
    public TreeEnumerator(Microsoft.VisualC.StlClr.Generic.INode<TValue> _First) : base (default(Microsoft.VisualC.StlClr.Generic.INode<TValue>)) { }
    public virtual new TValue Current { get { return default(TValue); } set { } }
    public sealed override void Dispose() { }
    protected virtual void Dispose(bool A_0) { }
    public override bool MoveNext() { return default(bool); }
    public override void Reset() { }
  }
  [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1005")]
  [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1038")]
  public partial class TreeEnumeratorBase<TKey, TValue> : System.Collections.IEnumerator {
    public TreeEnumeratorBase(Microsoft.VisualC.StlClr.Generic.INode<TValue> _First) { }
    public virtual object Current { get { return default(object); } set { } }
    public virtual bool MoveNext() { return default(bool); }
    public virtual void Reset() { }
  }
  public delegate TResult UnaryDelegate<TArg, TResult>(TArg A_0);
  public partial class VectorEnumerator<TValue> : Microsoft.VisualC.StlClr.VectorEnumeratorBase<TValue>, System.Collections.Generic.IEnumerator<TValue> {
    [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline this type of method across NGen image boundaries")]
    public VectorEnumerator(Microsoft.VisualC.StlClr.IVector<TValue> _Cont, int _First) : base (default(Microsoft.VisualC.StlClr.IVector<TValue>), default(int)) { }
    public virtual new TValue Current { get { return default(TValue); } set { } }
    public sealed override void Dispose() { }
    protected virtual void Dispose(bool A_0) { }
    public override bool MoveNext() { return default(bool); }
    public override void Reset() { }
  }
  [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1038")]
  public partial class VectorEnumeratorBase<TValue> : System.Collections.IEnumerator {
    public VectorEnumeratorBase(Microsoft.VisualC.StlClr.IVector<TValue> _Cont, int _First) { }
    public virtual object Current { get { return default(object); } set { } }
    public virtual bool MoveNext() { return default(bool); }
    public virtual void Reset() { }
  }
}
namespace Microsoft.VisualC.StlClr.Generic {
  public partial class ConstContainerBidirectionalIterator<TValue> : Microsoft.VisualC.StlClr.Generic.IBidirectionalIterator<TValue> {
    public ConstContainerBidirectionalIterator() { }
    public ConstContainerBidirectionalIterator(Microsoft.VisualC.StlClr.Generic.ConstContainerBidirectionalIterator<TValue> _Right) { }
    public ConstContainerBidirectionalIterator(Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> _Right) { }
    public ConstContainerBidirectionalIterator(Microsoft.VisualC.StlClr.Generic.INode<TValue> _Node) { }
    public virtual object Clone() { return default(object); }
    public virtual object container() { return default(object); }
    public bool equal_to(Microsoft.VisualC.StlClr.Generic.ConstContainerBidirectionalIterator<TValue> _Right) { return default(bool); }
    public virtual bool equal_to(Microsoft.VisualC.StlClr.Generic.IInputIterator<TValue> _Right) { return default(bool); }
    public virtual int get_bias() { return default(int); }
    public virtual TValue get_cref() { return default(TValue); }
    public virtual object get_node() { return default(object); }
    public virtual TValue get_ref() { return default(TValue); }
    public virtual void next() { }
    public Microsoft.VisualC.StlClr.Generic.ConstContainerBidirectionalIterator<TValue> op_Assign(Microsoft.VisualC.StlClr.Generic.ConstContainerBidirectionalIterator<TValue> _Right) { return default(Microsoft.VisualC.StlClr.Generic.ConstContainerBidirectionalIterator<TValue>); }
    public Microsoft.VisualC.StlClr.Generic.ConstContainerBidirectionalIterator<TValue> op_Assign(Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> _Right) { return default(Microsoft.VisualC.StlClr.Generic.ConstContainerBidirectionalIterator<TValue>); }
    public void operator --(ref Microsoft.VisualC.StlClr.Generic.ConstContainerBidirectionalIterator<TValue> ) { }
    public void operator --(ref Microsoft.VisualC.StlClr.Generic.ConstContainerBidirectionalIterator<TValue> , int A_0) { }
    [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline this type of method across NGen image boundaries")]
    public bool operator ==(Microsoft.VisualC.StlClr.Generic.ConstContainerBidirectionalIterator<TValue> _Right) { return default(bool); }
    [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline this type of method across NGen image boundaries")]
    public bool operator ==(Microsoft.VisualC.StlClr.Generic.IInputIterator<TValue> _Right) { return default(bool); }
    public implicit operator Microsoft.VisualC.StlClr.Generic.IBidirectionalIterator<TValue> () { return default(Microsoft.VisualC.StlClr.Generic.IBidirectionalIterator<TValue>); }
    public void operator ++(ref Microsoft.VisualC.StlClr.Generic.ConstContainerBidirectionalIterator<TValue> ) { }
    public void operator ++(ref Microsoft.VisualC.StlClr.Generic.ConstContainerBidirectionalIterator<TValue> , int A_0) { }
    public bool operator !=(Microsoft.VisualC.StlClr.Generic.ConstContainerBidirectionalIterator<TValue> _Right) { return default(bool); }
    public bool operator !=(Microsoft.VisualC.StlClr.Generic.IInputIterator<TValue> _Right) { return default(bool); }
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1000")]
    [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline this type of method across NGen image boundaries")]
    public static TValue op_MemberSelection(Microsoft.VisualC.StlClr.Generic.ConstContainerBidirectionalIterator<TValue> _Left) { return default(TValue); }
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1000")]
    [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline this type of method across NGen image boundaries")]
    public static TValue op_PointerDereference(Microsoft.VisualC.StlClr.Generic.ConstContainerBidirectionalIterator<TValue> _Left) { return default(TValue); }
    public virtual void prev() { }
    public virtual bool valid() { return default(bool); }
  }
  public partial class ConstContainerRandomAccessIterator<TValue> : Microsoft.VisualC.StlClr.Generic.IRandomAccessIterator<TValue> {
    public ConstContainerRandomAccessIterator() { }
    public ConstContainerRandomAccessIterator(Microsoft.VisualC.StlClr.Generic.ConstContainerRandomAccessIterator<TValue> _Right) { }
    public ConstContainerRandomAccessIterator(Microsoft.VisualC.StlClr.Generic.ContainerRandomAccessIterator<TValue> _Right) { }
    public ConstContainerRandomAccessIterator(Microsoft.VisualC.StlClr.Generic.IRandomAccessContainer<TValue> _Cont, int _Offset) { }
    public TValue this[int _Pos] { get { return default(TValue); } }
    public virtual object Clone() { return default(object); }
    public virtual object container() { return default(object); }
    public int distance(Microsoft.VisualC.StlClr.Generic.ConstContainerRandomAccessIterator<TValue> _Right) { return default(int); }
    public virtual int distance(Microsoft.VisualC.StlClr.Generic.IRandomAccessIterator<TValue> _Right) { return default(int); }
    public bool equal_to(Microsoft.VisualC.StlClr.Generic.ConstContainerRandomAccessIterator<TValue> _Right) { return default(bool); }
    public virtual bool equal_to(Microsoft.VisualC.StlClr.Generic.IInputIterator<TValue> _Right) { return default(bool); }
    public virtual int get_bias() { return default(int); }
    public virtual TValue get_cref() { return default(TValue); }
    public virtual object get_node() { return default(object); }
    public virtual TValue get_ref() { return default(TValue); }
    public bool less_than(Microsoft.VisualC.StlClr.Generic.ConstContainerRandomAccessIterator<TValue> _Right) { return default(bool); }
    public virtual bool less_than(Microsoft.VisualC.StlClr.Generic.IRandomAccessIterator<TValue> _Right) { return default(bool); }
    public virtual int move(int _Offset) { return default(int); }
    public virtual void next() { }
    public void operator +(ref Microsoft.VisualC.StlClr.Generic.ConstContainerRandomAccessIterator<TValue> , int _Right) { }
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1000")]
    public static void operator +(ref Microsoft.VisualC.StlClr.Generic.ConstContainerRandomAccessIterator<TValue> , int _Left, Microsoft.VisualC.StlClr.Generic.ConstContainerRandomAccessIterator<TValue> _Right) { }
    public Microsoft.VisualC.StlClr.Generic.ConstContainerRandomAccessIterator<TValue> op_Assign(Microsoft.VisualC.StlClr.Generic.ConstContainerRandomAccessIterator<TValue> _Right) { return default(Microsoft.VisualC.StlClr.Generic.ConstContainerRandomAccessIterator<TValue>); }
    public Microsoft.VisualC.StlClr.Generic.ConstContainerRandomAccessIterator<TValue> op_Assign(Microsoft.VisualC.StlClr.Generic.ContainerRandomAccessIterator<TValue> _Right) { return default(Microsoft.VisualC.StlClr.Generic.ConstContainerRandomAccessIterator<TValue>); }
    public void operator --(ref Microsoft.VisualC.StlClr.Generic.ConstContainerRandomAccessIterator<TValue> ) { }
    public void operator --(ref Microsoft.VisualC.StlClr.Generic.ConstContainerRandomAccessIterator<TValue> , int A_0) { }
    [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline this type of method across NGen image boundaries")]
    public bool operator ==(Microsoft.VisualC.StlClr.Generic.ConstContainerRandomAccessIterator<TValue> _Right) { return default(bool); }
    [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline this type of method across NGen image boundaries")]
    public bool operator ==(Microsoft.VisualC.StlClr.Generic.IInputIterator<TValue> _Right) { return default(bool); }
    [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline this type of method across NGen image boundaries")]
    public bool operator >(Microsoft.VisualC.StlClr.Generic.ConstContainerRandomAccessIterator<TValue> _Right) { return default(bool); }
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1000")]
    [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline this type of method across NGen image boundaries")]
    public static bool operator >(Microsoft.VisualC.StlClr.Generic.IRandomAccessIterator<TValue> _Left, Microsoft.VisualC.StlClr.Generic.ConstContainerRandomAccessIterator<TValue> _Right) { return default(bool); }
    public bool operator >=(Microsoft.VisualC.StlClr.Generic.ConstContainerRandomAccessIterator<TValue> _Right) { return default(bool); }
    public bool operator >=(Microsoft.VisualC.StlClr.Generic.IRandomAccessIterator<TValue> _Right) { return default(bool); }
    public implicit operator Microsoft.VisualC.StlClr.Generic.IRandomAccessIterator<TValue> () { return default(Microsoft.VisualC.StlClr.Generic.IRandomAccessIterator<TValue>); }
    public void operator ++(ref Microsoft.VisualC.StlClr.Generic.ConstContainerRandomAccessIterator<TValue> ) { }
    public void operator ++(ref Microsoft.VisualC.StlClr.Generic.ConstContainerRandomAccessIterator<TValue> , int A_0) { }
    public bool operator !=(Microsoft.VisualC.StlClr.Generic.ConstContainerRandomAccessIterator<TValue> _Right) { return default(bool); }
    public bool operator !=(Microsoft.VisualC.StlClr.Generic.IInputIterator<TValue> _Right) { return default(bool); }
    [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline this type of method across NGen image boundaries")]
    public bool operator <(Microsoft.VisualC.StlClr.Generic.ConstContainerRandomAccessIterator<TValue> _Right) { return default(bool); }
    [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline this type of method across NGen image boundaries")]
    public bool operator <(Microsoft.VisualC.StlClr.Generic.IRandomAccessIterator<TValue> _Right) { return default(bool); }
    public bool operator <=(Microsoft.VisualC.StlClr.Generic.ConstContainerRandomAccessIterator<TValue> _Right) { return default(bool); }
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1000")]
    public static bool operator <=(Microsoft.VisualC.StlClr.Generic.IRandomAccessIterator<TValue> _Left, Microsoft.VisualC.StlClr.Generic.ConstContainerRandomAccessIterator<TValue> _Right) { return default(bool); }
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1000")]
    [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline this type of method across NGen image boundaries")]
    public static TValue op_MemberSelection(Microsoft.VisualC.StlClr.Generic.ConstContainerRandomAccessIterator<TValue> _Left) { return default(TValue); }
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1000")]
    [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline this type of method across NGen image boundaries")]
    public static TValue op_PointerDereference(Microsoft.VisualC.StlClr.Generic.ConstContainerRandomAccessIterator<TValue> _Left) { return default(TValue); }
    public void operator -(ref Microsoft.VisualC.StlClr.Generic.ConstContainerRandomAccessIterator<TValue> , int _Right) { }
    [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline this type of method across NGen image boundaries")]
    public int operator -(Microsoft.VisualC.StlClr.Generic.IRandomAccessIterator<TValue> _Right) { return default(int); }
    public virtual void prev() { }
    public virtual bool valid() { return default(bool); }
  }
  public partial class ConstReverseBidirectionalIterator<TValue> : Microsoft.VisualC.StlClr.Generic.IBidirectionalIterator<TValue> {
    public ConstReverseBidirectionalIterator() { }
    public ConstReverseBidirectionalIterator(Microsoft.VisualC.StlClr.Generic.ConstReverseBidirectionalIterator<TValue> _Right) { }
    public ConstReverseBidirectionalIterator(Microsoft.VisualC.StlClr.Generic.IBidirectionalIterator<TValue> _Iter) { }
    public ConstReverseBidirectionalIterator(Microsoft.VisualC.StlClr.Generic.ReverseBidirectionalIterator<TValue> _Iter) { }
    public Microsoft.VisualC.StlClr.Generic.IBidirectionalIterator<TValue> base() { return default(Microsoft.VisualC.StlClr.Generic.IBidirectionalIterator<TValue>); }
    public virtual object Clone() { return default(object); }
    public virtual object container() { return default(object); }
    public bool equal_to(Microsoft.VisualC.StlClr.Generic.ConstReverseBidirectionalIterator<TValue> _Right) { return default(bool); }
    public virtual bool equal_to(Microsoft.VisualC.StlClr.Generic.IInputIterator<TValue> _Right) { return default(bool); }
    public virtual int get_bias() { return default(int); }
    public virtual TValue get_cref() { return default(TValue); }
    public virtual object get_node() { return default(object); }
    public virtual TValue get_ref() { return default(TValue); }
    public virtual void next() { }
    public Microsoft.VisualC.StlClr.Generic.ConstReverseBidirectionalIterator<TValue> op_Assign(Microsoft.VisualC.StlClr.Generic.ConstReverseBidirectionalIterator<TValue> _Right) { return default(Microsoft.VisualC.StlClr.Generic.ConstReverseBidirectionalIterator<TValue>); }
    public Microsoft.VisualC.StlClr.Generic.ConstReverseBidirectionalIterator<TValue> op_Assign(Microsoft.VisualC.StlClr.Generic.ReverseBidirectionalIterator<TValue> _Right) { return default(Microsoft.VisualC.StlClr.Generic.ConstReverseBidirectionalIterator<TValue>); }
    public void operator --(ref Microsoft.VisualC.StlClr.Generic.ConstReverseBidirectionalIterator<TValue> ) { }
    public void operator --(ref Microsoft.VisualC.StlClr.Generic.ConstReverseBidirectionalIterator<TValue> , int A_0) { }
    [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline this type of method across NGen image boundaries")]
    public bool operator ==(Microsoft.VisualC.StlClr.Generic.ConstReverseBidirectionalIterator<TValue> _Right) { return default(bool); }
    [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline this type of method across NGen image boundaries")]
    public bool operator ==(Microsoft.VisualC.StlClr.Generic.IInputIterator<TValue> _Right) { return default(bool); }
    public implicit operator Microsoft.VisualC.StlClr.Generic.IBidirectionalIterator<TValue> () { return default(Microsoft.VisualC.StlClr.Generic.IBidirectionalIterator<TValue>); }
    public void operator ++(ref Microsoft.VisualC.StlClr.Generic.ConstReverseBidirectionalIterator<TValue> ) { }
    public void operator ++(ref Microsoft.VisualC.StlClr.Generic.ConstReverseBidirectionalIterator<TValue> , int A_0) { }
    public bool operator !=(Microsoft.VisualC.StlClr.Generic.ConstReverseBidirectionalIterator<TValue> _Right) { return default(bool); }
    public bool operator !=(Microsoft.VisualC.StlClr.Generic.IInputIterator<TValue> _Right) { return default(bool); }
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1000")]
    [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline this type of method across NGen image boundaries")]
    public static TValue op_MemberSelection(Microsoft.VisualC.StlClr.Generic.ConstReverseBidirectionalIterator<TValue> _Left) { return default(TValue); }
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1000")]
    [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline this type of method across NGen image boundaries")]
    public static TValue op_PointerDereference(Microsoft.VisualC.StlClr.Generic.ConstReverseBidirectionalIterator<TValue> _Left) { return default(TValue); }
    public virtual void prev() { }
    public virtual bool valid() { return default(bool); }
  }
  public partial class ConstReverseRandomAccessIterator<TValue> : Microsoft.VisualC.StlClr.Generic.IRandomAccessIterator<TValue> {
    public ConstReverseRandomAccessIterator() { }
    public ConstReverseRandomAccessIterator(Microsoft.VisualC.StlClr.Generic.ConstReverseRandomAccessIterator<TValue> _Right) { }
    public ConstReverseRandomAccessIterator(Microsoft.VisualC.StlClr.Generic.IRandomAccessIterator<TValue> _Iter) { }
    public ConstReverseRandomAccessIterator(Microsoft.VisualC.StlClr.Generic.ReverseRandomAccessIterator<TValue> _Iter) { }
    public TValue this[int _Pos] { get { return default(TValue); } }
    public Microsoft.VisualC.StlClr.Generic.IRandomAccessIterator<TValue> base() { return default(Microsoft.VisualC.StlClr.Generic.IRandomAccessIterator<TValue>); }
    public virtual object Clone() { return default(object); }
    public virtual object container() { return default(object); }
    public int distance(Microsoft.VisualC.StlClr.Generic.ConstReverseRandomAccessIterator<TValue> _Right) { return default(int); }
    public virtual int distance(Microsoft.VisualC.StlClr.Generic.IRandomAccessIterator<TValue> _Right) { return default(int); }
    public bool equal_to(Microsoft.VisualC.StlClr.Generic.ConstReverseRandomAccessIterator<TValue> _Right) { return default(bool); }
    public virtual bool equal_to(Microsoft.VisualC.StlClr.Generic.IInputIterator<TValue> _Right) { return default(bool); }
    public virtual int get_bias() { return default(int); }
    public virtual TValue get_cref() { return default(TValue); }
    public virtual object get_node() { return default(object); }
    public virtual TValue get_ref() { return default(TValue); }
    public bool less_than(Microsoft.VisualC.StlClr.Generic.ConstReverseRandomAccessIterator<TValue> _Right) { return default(bool); }
    public virtual bool less_than(Microsoft.VisualC.StlClr.Generic.IRandomAccessIterator<TValue> _Right) { return default(bool); }
    public virtual int move(int _Offset) { return default(int); }
    public virtual void next() { }
    public void operator +(ref Microsoft.VisualC.StlClr.Generic.ConstReverseRandomAccessIterator<TValue> , int _Right) { }
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1000")]
    public static void operator +(ref Microsoft.VisualC.StlClr.Generic.ConstReverseRandomAccessIterator<TValue> , int _Left, Microsoft.VisualC.StlClr.Generic.ConstReverseRandomAccessIterator<TValue> _Right) { }
    public Microsoft.VisualC.StlClr.Generic.ConstReverseRandomAccessIterator<TValue> op_Assign(Microsoft.VisualC.StlClr.Generic.ConstReverseRandomAccessIterator<TValue> _Right) { return default(Microsoft.VisualC.StlClr.Generic.ConstReverseRandomAccessIterator<TValue>); }
    public Microsoft.VisualC.StlClr.Generic.ConstReverseRandomAccessIterator<TValue> op_Assign(Microsoft.VisualC.StlClr.Generic.ReverseRandomAccessIterator<TValue> _Right) { return default(Microsoft.VisualC.StlClr.Generic.ConstReverseRandomAccessIterator<TValue>); }
    public void operator --(ref Microsoft.VisualC.StlClr.Generic.ConstReverseRandomAccessIterator<TValue> ) { }
    public void operator --(ref Microsoft.VisualC.StlClr.Generic.ConstReverseRandomAccessIterator<TValue> , int A_0) { }
    [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline this type of method across NGen image boundaries")]
    public bool operator ==(Microsoft.VisualC.StlClr.Generic.ConstReverseRandomAccessIterator<TValue> _Right) { return default(bool); }
    [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline this type of method across NGen image boundaries")]
    public bool operator >(Microsoft.VisualC.StlClr.Generic.ConstReverseRandomAccessIterator<TValue> _Right) { return default(bool); }
    public bool operator >=(Microsoft.VisualC.StlClr.Generic.ConstReverseRandomAccessIterator<TValue> _Right) { return default(bool); }
    public implicit operator Microsoft.VisualC.StlClr.Generic.IRandomAccessIterator<TValue> () { return default(Microsoft.VisualC.StlClr.Generic.IRandomAccessIterator<TValue>); }
    public void operator ++(ref Microsoft.VisualC.StlClr.Generic.ConstReverseRandomAccessIterator<TValue> ) { }
    public void operator ++(ref Microsoft.VisualC.StlClr.Generic.ConstReverseRandomAccessIterator<TValue> , int A_0) { }
    public bool operator !=(Microsoft.VisualC.StlClr.Generic.ConstReverseRandomAccessIterator<TValue> _Right) { return default(bool); }
    [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline this type of method across NGen image boundaries")]
    public bool operator <(Microsoft.VisualC.StlClr.Generic.ConstReverseRandomAccessIterator<TValue> _Right) { return default(bool); }
    public bool operator <=(Microsoft.VisualC.StlClr.Generic.ConstReverseRandomAccessIterator<TValue> _Right) { return default(bool); }
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1000")]
    [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline this type of method across NGen image boundaries")]
    public static TValue op_MemberSelection(Microsoft.VisualC.StlClr.Generic.ConstReverseRandomAccessIterator<TValue> _Left) { return default(TValue); }
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1000")]
    [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline this type of method across NGen image boundaries")]
    public static TValue op_PointerDereference(Microsoft.VisualC.StlClr.Generic.ConstReverseRandomAccessIterator<TValue> _Left) { return default(TValue); }
    public void operator -(ref Microsoft.VisualC.StlClr.Generic.ConstReverseRandomAccessIterator<TValue> , int _Right) { }
    [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline this type of method across NGen image boundaries")]
    public int operator -(Microsoft.VisualC.StlClr.Generic.IRandomAccessIterator<TValue> _Right) { return default(int); }
    public virtual void prev() { }
    public virtual bool valid() { return default(bool); }
  }
  public partial class ContainerBidirectionalIterator<TValue> : Microsoft.VisualC.StlClr.Generic.IBidirectionalIterator<TValue> {
    public ContainerBidirectionalIterator() { }
    public ContainerBidirectionalIterator(Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> _Right) { }
    public ContainerBidirectionalIterator(Microsoft.VisualC.StlClr.Generic.INode<TValue> _Node) { }
    public virtual object Clone() { return default(object); }
    public virtual object container() { return default(object); }
    public bool equal_to(Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> _Right) { return default(bool); }
    public virtual bool equal_to(Microsoft.VisualC.StlClr.Generic.IInputIterator<TValue> _Right) { return default(bool); }
    public virtual int get_bias() { return default(int); }
    public virtual TValue get_cref() { return default(TValue); }
    public virtual object get_node() { return default(object); }
    public virtual TValue get_ref() { return default(TValue); }
    public virtual void next() { }
    public Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> op_Assign(Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> _Right) { return default(Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue>); }
    public void operator --(ref Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> ) { }
    public void operator --(ref Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> , int A_0) { }
    [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline this type of method across NGen image boundaries")]
    public bool operator ==(Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> _Right) { return default(bool); }
    [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline this type of method across NGen image boundaries")]
    public bool operator ==(Microsoft.VisualC.StlClr.Generic.IInputIterator<TValue> _Right) { return default(bool); }
    public implicit operator Microsoft.VisualC.StlClr.Generic.IBidirectionalIterator<TValue> () { return default(Microsoft.VisualC.StlClr.Generic.IBidirectionalIterator<TValue>); }
    public void operator ++(ref Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> ) { }
    public void operator ++(ref Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> , int A_0) { }
    public bool operator !=(Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> _Right) { return default(bool); }
    public bool operator !=(Microsoft.VisualC.StlClr.Generic.IInputIterator<TValue> _Right) { return default(bool); }
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1000")]
    [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline this type of method across NGen image boundaries")]
    public static TValue op_MemberSelection(Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> _Left) { return default(TValue); }
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1000")]
    [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline this type of method across NGen image boundaries")]
    public static TValue op_PointerDereference(Microsoft.VisualC.StlClr.Generic.ContainerBidirectionalIterator<TValue> _Left) { return default(TValue); }
    public virtual void prev() { }
    public virtual bool valid() { return default(bool); }
  }
  public partial class ContainerRandomAccessIterator<TValue> : Microsoft.VisualC.StlClr.Generic.IRandomAccessIterator<TValue> {
    public ContainerRandomAccessIterator() { }
    public ContainerRandomAccessIterator(Microsoft.VisualC.StlClr.Generic.ContainerRandomAccessIterator<TValue> _Right) { }
    public ContainerRandomAccessIterator(Microsoft.VisualC.StlClr.Generic.IRandomAccessContainer<TValue> _Cont, int _Offset) { }
    public TValue this[int _Pos] { get { return default(TValue); } set { } }
    public virtual object Clone() { return default(object); }
    public virtual object container() { return default(object); }
    public int distance(Microsoft.VisualC.StlClr.Generic.ContainerRandomAccessIterator<TValue> _Right) { return default(int); }
    public virtual int distance(Microsoft.VisualC.StlClr.Generic.IRandomAccessIterator<TValue> _Right) { return default(int); }
    public bool equal_to(Microsoft.VisualC.StlClr.Generic.ContainerRandomAccessIterator<TValue> _Right) { return default(bool); }
    public virtual bool equal_to(Microsoft.VisualC.StlClr.Generic.IInputIterator<TValue> _Right) { return default(bool); }
    public virtual int get_bias() { return default(int); }
    public virtual TValue get_cref() { return default(TValue); }
    public virtual object get_node() { return default(object); }
    public virtual TValue get_ref() { return default(TValue); }
    public bool less_than(Microsoft.VisualC.StlClr.Generic.ContainerRandomAccessIterator<TValue> _Right) { return default(bool); }
    public virtual bool less_than(Microsoft.VisualC.StlClr.Generic.IRandomAccessIterator<TValue> _Right) { return default(bool); }
    public virtual int move(int _Offset) { return default(int); }
    public virtual void next() { }
    public void operator +(ref Microsoft.VisualC.StlClr.Generic.ContainerRandomAccessIterator<TValue> , int _Right) { }
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1000")]
    public static void operator +(ref Microsoft.VisualC.StlClr.Generic.ContainerRandomAccessIterator<TValue> , int _Left, Microsoft.VisualC.StlClr.Generic.ContainerRandomAccessIterator<TValue> _Right) { }
    public Microsoft.VisualC.StlClr.Generic.ContainerRandomAccessIterator<TValue> op_Assign(Microsoft.VisualC.StlClr.Generic.ContainerRandomAccessIterator<TValue> _Right) { return default(Microsoft.VisualC.StlClr.Generic.ContainerRandomAccessIterator<TValue>); }
    public void operator --(ref Microsoft.VisualC.StlClr.Generic.ContainerRandomAccessIterator<TValue> ) { }
    public void operator --(ref Microsoft.VisualC.StlClr.Generic.ContainerRandomAccessIterator<TValue> , int A_0) { }
    [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline this type of method across NGen image boundaries")]
    public bool operator ==(Microsoft.VisualC.StlClr.Generic.ContainerRandomAccessIterator<TValue> _Right) { return default(bool); }
    [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline this type of method across NGen image boundaries")]
    public bool operator ==(Microsoft.VisualC.StlClr.Generic.IInputIterator<TValue> _Right) { return default(bool); }
    [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline this type of method across NGen image boundaries")]
    public bool operator >(Microsoft.VisualC.StlClr.Generic.ContainerRandomAccessIterator<TValue> _Right) { return default(bool); }
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1000")]
    [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline this type of method across NGen image boundaries")]
    public static bool operator >(Microsoft.VisualC.StlClr.Generic.IRandomAccessIterator<TValue> _Left, Microsoft.VisualC.StlClr.Generic.ContainerRandomAccessIterator<TValue> _Right) { return default(bool); }
    public bool operator >=(Microsoft.VisualC.StlClr.Generic.ContainerRandomAccessIterator<TValue> _Right) { return default(bool); }
    public bool operator >=(Microsoft.VisualC.StlClr.Generic.IRandomAccessIterator<TValue> _Right) { return default(bool); }
    public implicit operator Microsoft.VisualC.StlClr.Generic.IRandomAccessIterator<TValue> () { return default(Microsoft.VisualC.StlClr.Generic.IRandomAccessIterator<TValue>); }
    public void operator ++(ref Microsoft.VisualC.StlClr.Generic.ContainerRandomAccessIterator<TValue> ) { }
    public void operator ++(ref Microsoft.VisualC.StlClr.Generic.ContainerRandomAccessIterator<TValue> , int A_0) { }
    public bool operator !=(Microsoft.VisualC.StlClr.Generic.ContainerRandomAccessIterator<TValue> _Right) { return default(bool); }
    public bool operator !=(Microsoft.VisualC.StlClr.Generic.IInputIterator<TValue> _Right) { return default(bool); }
    [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline this type of method across NGen image boundaries")]
    public bool operator <(Microsoft.VisualC.StlClr.Generic.ContainerRandomAccessIterator<TValue> _Right) { return default(bool); }
    [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline this type of method across NGen image boundaries")]
    public bool operator <(Microsoft.VisualC.StlClr.Generic.IRandomAccessIterator<TValue> _Right) { return default(bool); }
    public bool operator <=(Microsoft.VisualC.StlClr.Generic.ContainerRandomAccessIterator<TValue> _Right) { return default(bool); }
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1000")]
    public static bool operator <=(Microsoft.VisualC.StlClr.Generic.IRandomAccessIterator<TValue> _Left, Microsoft.VisualC.StlClr.Generic.ContainerRandomAccessIterator<TValue> _Right) { return default(bool); }
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1000")]
    [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline this type of method across NGen image boundaries")]
    public static TValue op_MemberSelection(Microsoft.VisualC.StlClr.Generic.ContainerRandomAccessIterator<TValue> _Left) { return default(TValue); }
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1000")]
    [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline this type of method across NGen image boundaries")]
    public static TValue op_PointerDereference(Microsoft.VisualC.StlClr.Generic.ContainerRandomAccessIterator<TValue> _Left) { return default(TValue); }
    public void operator -(ref Microsoft.VisualC.StlClr.Generic.ContainerRandomAccessIterator<TValue> , int _Right) { }
    [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline this type of method across NGen image boundaries")]
    public int operator -(Microsoft.VisualC.StlClr.Generic.IRandomAccessIterator<TValue> _Right) { return default(int); }
    public virtual void prev() { }
    public virtual bool valid() { return default(bool); }
  }
  public partial interface IBaseIterator<TValue> : System.ICloneable {
    object container();
    int get_bias();
    object get_node();
    void next();
    bool valid();
  }
  public partial interface IBidirectionalContainer<TValue> {
    uint get_generation();
  }
  public partial interface IBidirectionalIterator<TValue> : Microsoft.VisualC.StlClr.Generic.IForwardIterator<TValue> {
    void prev();
  }
  public partial interface IForwardIterator<TValue> : Microsoft.VisualC.StlClr.Generic.IInputIterator<TValue>, Microsoft.VisualC.StlClr.Generic.IOutputIterator<TValue> {
  }
  public partial interface IInputIterator<TValue> : Microsoft.VisualC.StlClr.Generic.IBaseIterator<TValue> {
    bool equal_to(Microsoft.VisualC.StlClr.Generic.IInputIterator<TValue> A_0);
    TValue get_cref();
  }
  public partial interface INode<TValue> {
    TValue _Value { get; set; }
    Microsoft.VisualC.StlClr.Generic.IBidirectionalContainer<TValue> container();
    bool is_head();
    Microsoft.VisualC.StlClr.Generic.INode<TValue> next_node();
    Microsoft.VisualC.StlClr.Generic.INode<TValue> prev_node();
  }
  public partial interface IOutputIterator<TValue> : Microsoft.VisualC.StlClr.Generic.IBaseIterator<TValue> {
    TValue get_ref();
  }
  public partial interface IRandomAccessContainer<TValue> {
    TValue at_bias(int A_0);
    bool valid_bias(int A_0);
  }
  public partial interface IRandomAccessIterator<TValue> : Microsoft.VisualC.StlClr.Generic.IBidirectionalIterator<TValue> {
    int distance(Microsoft.VisualC.StlClr.Generic.IRandomAccessIterator<TValue> _Right);
    bool less_than(Microsoft.VisualC.StlClr.Generic.IRandomAccessIterator<TValue> _Right);
    int move(int _Offset);
  }
  public partial class ReverseBidirectionalIterator<TValue> : Microsoft.VisualC.StlClr.Generic.IBidirectionalIterator<TValue> {
    public ReverseBidirectionalIterator() { }
    public ReverseBidirectionalIterator(Microsoft.VisualC.StlClr.Generic.IBidirectionalIterator<TValue> _Iter) { }
    public ReverseBidirectionalIterator(Microsoft.VisualC.StlClr.Generic.ReverseBidirectionalIterator<TValue> _Right) { }
    public Microsoft.VisualC.StlClr.Generic.IBidirectionalIterator<TValue> base() { return default(Microsoft.VisualC.StlClr.Generic.IBidirectionalIterator<TValue>); }
    public virtual object Clone() { return default(object); }
    public virtual object container() { return default(object); }
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1011")]
    public virtual bool equal_to(Microsoft.VisualC.StlClr.Generic.IInputIterator<TValue> _Right) { return default(bool); }
    public bool equal_to(Microsoft.VisualC.StlClr.Generic.ReverseBidirectionalIterator<TValue> _Right) { return default(bool); }
    public virtual int get_bias() { return default(int); }
    public virtual TValue get_cref() { return default(TValue); }
    public virtual object get_node() { return default(object); }
    public virtual TValue get_ref() { return default(TValue); }
    public virtual void next() { }
    public Microsoft.VisualC.StlClr.Generic.ReverseBidirectionalIterator<TValue> op_Assign(Microsoft.VisualC.StlClr.Generic.ReverseBidirectionalIterator<TValue> _Right) { return default(Microsoft.VisualC.StlClr.Generic.ReverseBidirectionalIterator<TValue>); }
    public void operator --(ref Microsoft.VisualC.StlClr.Generic.ReverseBidirectionalIterator<TValue> ) { }
    public void operator --(ref Microsoft.VisualC.StlClr.Generic.ReverseBidirectionalIterator<TValue> , int A_0) { }
    [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline this type of method across NGen image boundaries")]
    public bool operator ==(Microsoft.VisualC.StlClr.Generic.IInputIterator<TValue> _Right) { return default(bool); }
    [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline this type of method across NGen image boundaries")]
    public bool operator ==(Microsoft.VisualC.StlClr.Generic.ReverseBidirectionalIterator<TValue> _Right) { return default(bool); }
    public implicit operator Microsoft.VisualC.StlClr.Generic.IBidirectionalIterator<TValue> () { return default(Microsoft.VisualC.StlClr.Generic.IBidirectionalIterator<TValue>); }
    public void operator ++(ref Microsoft.VisualC.StlClr.Generic.ReverseBidirectionalIterator<TValue> ) { }
    public void operator ++(ref Microsoft.VisualC.StlClr.Generic.ReverseBidirectionalIterator<TValue> , int A_0) { }
    public bool operator !=(Microsoft.VisualC.StlClr.Generic.IInputIterator<TValue> _Right) { return default(bool); }
    public bool operator !=(Microsoft.VisualC.StlClr.Generic.ReverseBidirectionalIterator<TValue> _Right) { return default(bool); }
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1000")]
    [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline this type of method across NGen image boundaries")]
    public static TValue op_MemberSelection(Microsoft.VisualC.StlClr.Generic.ReverseBidirectionalIterator<TValue> _Left) { return default(TValue); }
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1000")]
    [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline this type of method across NGen image boundaries")]
    public static TValue op_PointerDereference(Microsoft.VisualC.StlClr.Generic.ReverseBidirectionalIterator<TValue> _Left) { return default(TValue); }
    public virtual void prev() { }
    public virtual bool valid() { return default(bool); }
  }
  public partial class ReverseRandomAccessIterator<TValue> : Microsoft.VisualC.StlClr.Generic.IRandomAccessIterator<TValue> {
    public ReverseRandomAccessIterator() { }
    public ReverseRandomAccessIterator(Microsoft.VisualC.StlClr.Generic.IRandomAccessIterator<TValue> _Iter) { }
    public ReverseRandomAccessIterator(Microsoft.VisualC.StlClr.Generic.ReverseRandomAccessIterator<TValue> _Right) { }
    public TValue this[int _Pos] { get { return default(TValue); } set { } }
    public Microsoft.VisualC.StlClr.Generic.IRandomAccessIterator<TValue> base() { return default(Microsoft.VisualC.StlClr.Generic.IRandomAccessIterator<TValue>); }
    public virtual object Clone() { return default(object); }
    public virtual object container() { return default(object); }
    public virtual int distance(Microsoft.VisualC.StlClr.Generic.IRandomAccessIterator<TValue> _Right) { return default(int); }
    public int distance(Microsoft.VisualC.StlClr.Generic.ReverseRandomAccessIterator<TValue> _Right) { return default(int); }
    public virtual bool equal_to(Microsoft.VisualC.StlClr.Generic.IInputIterator<TValue> _Right) { return default(bool); }
    public bool equal_to(Microsoft.VisualC.StlClr.Generic.ReverseRandomAccessIterator<TValue> _Right) { return default(bool); }
    public virtual int get_bias() { return default(int); }
    public virtual TValue get_cref() { return default(TValue); }
    public virtual object get_node() { return default(object); }
    public virtual TValue get_ref() { return default(TValue); }
    public virtual bool less_than(Microsoft.VisualC.StlClr.Generic.IRandomAccessIterator<TValue> _Right) { return default(bool); }
    public bool less_than(Microsoft.VisualC.StlClr.Generic.ReverseRandomAccessIterator<TValue> _Right) { return default(bool); }
    public virtual int move(int _Offset) { return default(int); }
    public virtual void next() { }
    public void operator +(ref Microsoft.VisualC.StlClr.Generic.ReverseRandomAccessIterator<TValue> , int _Right) { }
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1000")]
    public static void operator +(ref Microsoft.VisualC.StlClr.Generic.ReverseRandomAccessIterator<TValue> , int _Left, Microsoft.VisualC.StlClr.Generic.ReverseRandomAccessIterator<TValue> _Right) { }
    public Microsoft.VisualC.StlClr.Generic.ReverseRandomAccessIterator<TValue> op_Assign(Microsoft.VisualC.StlClr.Generic.ReverseRandomAccessIterator<TValue> _Right) { return default(Microsoft.VisualC.StlClr.Generic.ReverseRandomAccessIterator<TValue>); }
    public void operator --(ref Microsoft.VisualC.StlClr.Generic.ReverseRandomAccessIterator<TValue> ) { }
    public void operator --(ref Microsoft.VisualC.StlClr.Generic.ReverseRandomAccessIterator<TValue> , int A_0) { }
    [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline this type of method across NGen image boundaries")]
    public bool operator ==(Microsoft.VisualC.StlClr.Generic.ReverseRandomAccessIterator<TValue> _Right) { return default(bool); }
    [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline this type of method across NGen image boundaries")]
    public bool operator >(Microsoft.VisualC.StlClr.Generic.ReverseRandomAccessIterator<TValue> _Right) { return default(bool); }
    public bool operator >=(Microsoft.VisualC.StlClr.Generic.ReverseRandomAccessIterator<TValue> _Right) { return default(bool); }
    public implicit operator Microsoft.VisualC.StlClr.Generic.IRandomAccessIterator<TValue> () { return default(Microsoft.VisualC.StlClr.Generic.IRandomAccessIterator<TValue>); }
    public void operator ++(ref Microsoft.VisualC.StlClr.Generic.ReverseRandomAccessIterator<TValue> ) { }
    public void operator ++(ref Microsoft.VisualC.StlClr.Generic.ReverseRandomAccessIterator<TValue> , int A_0) { }
    public bool operator !=(Microsoft.VisualC.StlClr.Generic.ReverseRandomAccessIterator<TValue> _Right) { return default(bool); }
    [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline this type of method across NGen image boundaries")]
    public bool operator <(Microsoft.VisualC.StlClr.Generic.ReverseRandomAccessIterator<TValue> _Right) { return default(bool); }
    public bool operator <=(Microsoft.VisualC.StlClr.Generic.ReverseRandomAccessIterator<TValue> _Right) { return default(bool); }
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1000")]
    [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline this type of method across NGen image boundaries")]
    public static TValue op_MemberSelection(Microsoft.VisualC.StlClr.Generic.ReverseRandomAccessIterator<TValue> _Left) { return default(TValue); }
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1000")]
    [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline this type of method across NGen image boundaries")]
    public static TValue op_PointerDereference(Microsoft.VisualC.StlClr.Generic.ReverseRandomAccessIterator<TValue> _Left) { return default(TValue); }
    [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline this type of method across NGen image boundaries")]
    public int operator -(Microsoft.VisualC.StlClr.Generic.IRandomAccessIterator<TValue> _Right) { return default(int); }
    public void operator -(ref Microsoft.VisualC.StlClr.Generic.ReverseRandomAccessIterator<TValue> , int _Right) { }
    public virtual void prev() { }
    public virtual bool valid() { return default(bool); }
  }
}
