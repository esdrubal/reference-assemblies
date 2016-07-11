namespace System.Data {
  public static partial class DataRowComparer {
    public static System.Data.DataRowComparer<System.Data.DataRow> Default { get { return default(System.Data.DataRowComparer<System.Data.DataRow>); } }
  }
  public sealed partial class DataRowComparer<TRow> : System.Collections.Generic.IEqualityComparer<TRow> where TRow : System.Data.DataRow {
    internal DataRowComparer() { }
    public static System.Data.DataRowComparer<TRow> Default { get { return default(System.Data.DataRowComparer<TRow>); } }
    public bool Equals(TRow leftRow, TRow rightRow) { return default(bool); }
    public int GetHashCode(TRow row) { return default(int); }
  }
  public static partial class DataRowExtensions {
    public static T Field<T>(this System.Data.DataRow row, System.Data.DataColumn column) { return default(T); }
    public static T Field<T>(this System.Data.DataRow row, System.Data.DataColumn column, System.Data.DataRowVersion version) { return default(T); }
    public static T Field<T>(this System.Data.DataRow row, int columnIndex) { return default(T); }
    public static T Field<T>(this System.Data.DataRow row, int columnIndex, System.Data.DataRowVersion version) { return default(T); }
    public static T Field<T>(this System.Data.DataRow row, string columnName) { return default(T); }
    public static T Field<T>(this System.Data.DataRow row, string columnName, System.Data.DataRowVersion version) { return default(T); }
    public static void SetField<T>(this System.Data.DataRow row, System.Data.DataColumn column, T value) { }
    public static void SetField<T>(this System.Data.DataRow row, int columnIndex, T value) { }
    public static void SetField<T>(this System.Data.DataRow row, string columnName, T value) { }
  }
  public static partial class DataTableExtensions {
    public static System.Data.DataView AsDataView(this System.Data.DataTable table) { return default(System.Data.DataView); }
    [System.MonoTODOAttribute("We should implement an effective DataView derivation; looks like .NET does.")]
    public static System.Data.DataView AsDataView<T>(this System.Data.EnumerableRowCollection<T> source) where T : System.Data.DataRow { return default(System.Data.DataView); }
    public static System.Data.EnumerableRowCollection<System.Data.DataRow> AsEnumerable(this System.Data.DataTable source) { return default(System.Data.EnumerableRowCollection<System.Data.DataRow>); }
    public static System.Data.DataTable CopyToDataTable<T>(this System.Collections.Generic.IEnumerable<T> source) where T : System.Data.DataRow { return default(System.Data.DataTable); }
    public static void CopyToDataTable<T>(this System.Collections.Generic.IEnumerable<T> source, System.Data.DataTable table, System.Data.LoadOption options) where T : System.Data.DataRow { }
    public static void CopyToDataTable<T>(this System.Collections.Generic.IEnumerable<T> source, System.Data.DataTable table, System.Data.LoadOption options, System.Data.FillErrorEventHandler errorHandler) where T : System.Data.DataRow { }
  }
  public abstract partial class EnumerableRowCollection : System.Collections.IEnumerable {
    internal EnumerableRowCollection() { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public partial class EnumerableRowCollection<TRow> : System.Data.EnumerableRowCollection, System.Collections.Generic.IEnumerable<TRow>, System.Collections.IEnumerable {
    internal EnumerableRowCollection() { }
    [System.Diagnostics.DebuggerHiddenAttribute]
    public System.Collections.Generic.IEnumerator<TRow> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<TRow>); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public static partial class EnumerableRowCollectionExtensions {
    public static System.Data.EnumerableRowCollection<TResult> Cast<TResult>(this System.Data.EnumerableRowCollection source) { return default(System.Data.EnumerableRowCollection<TResult>); }
    public static System.Data.OrderedEnumerableRowCollection<TRow> OrderBy<TRow, TKey>(this System.Data.EnumerableRowCollection<TRow> source, System.Func<TRow, TKey> keySelector) { return default(System.Data.OrderedEnumerableRowCollection<TRow>); }
    public static System.Data.OrderedEnumerableRowCollection<TRow> OrderBy<TRow, TKey>(this System.Data.EnumerableRowCollection<TRow> source, System.Func<TRow, TKey> keySelector, System.Collections.Generic.IComparer<TKey> comparer) { return default(System.Data.OrderedEnumerableRowCollection<TRow>); }
    public static System.Data.OrderedEnumerableRowCollection<TRow> OrderByDescending<TRow, TKey>(this System.Data.EnumerableRowCollection<TRow> source, System.Func<TRow, TKey> keySelector) { return default(System.Data.OrderedEnumerableRowCollection<TRow>); }
    public static System.Data.OrderedEnumerableRowCollection<TRow> OrderByDescending<TRow, TKey>(this System.Data.EnumerableRowCollection<TRow> source, System.Func<TRow, TKey> keySelector, System.Collections.Generic.IComparer<TKey> comparer) { return default(System.Data.OrderedEnumerableRowCollection<TRow>); }
    public static System.Data.EnumerableRowCollection<S> Select<TRow, S>(this System.Data.EnumerableRowCollection<TRow> source, System.Func<TRow, S> selector) { return default(System.Data.EnumerableRowCollection<S>); }
    public static System.Data.OrderedEnumerableRowCollection<TRow> ThenBy<TRow, TKey>(this System.Data.OrderedEnumerableRowCollection<TRow> source, System.Func<TRow, TKey> keySelector) { return default(System.Data.OrderedEnumerableRowCollection<TRow>); }
    public static System.Data.OrderedEnumerableRowCollection<TRow> ThenBy<TRow, TKey>(this System.Data.OrderedEnumerableRowCollection<TRow> source, System.Func<TRow, TKey> keySelector, System.Collections.Generic.IComparer<TKey> comparer) { return default(System.Data.OrderedEnumerableRowCollection<TRow>); }
    public static System.Data.OrderedEnumerableRowCollection<TRow> ThenByDescending<TRow, TKey>(this System.Data.OrderedEnumerableRowCollection<TRow> source, System.Func<TRow, TKey> keySelector) { return default(System.Data.OrderedEnumerableRowCollection<TRow>); }
    public static System.Data.OrderedEnumerableRowCollection<TRow> ThenByDescending<TRow, TKey>(this System.Data.OrderedEnumerableRowCollection<TRow> source, System.Func<TRow, TKey> keySelector, System.Collections.Generic.IComparer<TKey> comparer) { return default(System.Data.OrderedEnumerableRowCollection<TRow>); }
    public static System.Data.EnumerableRowCollection<TRow> Where<TRow>(this System.Data.EnumerableRowCollection<TRow> source, System.Func<TRow, System.Boolean> predicate) { return default(System.Data.EnumerableRowCollection<TRow>); }
  }
  public sealed partial class OrderedEnumerableRowCollection<TRow> : System.Data.EnumerableRowCollection<TRow> {
    internal OrderedEnumerableRowCollection() { }
  }
  public abstract partial class TypedTableBase<T> : System.Data.DataTable, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable where T : System.Data.DataRow {
    protected TypedTableBase() { }
    protected TypedTableBase(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public System.Data.EnumerableRowCollection<TResult> Cast<TResult>() { return default(System.Data.EnumerableRowCollection<TResult>); }
    [System.Diagnostics.DebuggerHiddenAttribute]
    public System.Collections.Generic.IEnumerator<T> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<T>); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public static partial class TypedTableBaseExtensions {
    public static System.Data.EnumerableRowCollection<TRow> AsEnumerable<TRow>(this System.Data.TypedTableBase<TRow> source) where TRow : System.Data.DataRow { return default(System.Data.EnumerableRowCollection<TRow>); }
    public static System.Data.OrderedEnumerableRowCollection<TRow> OrderBy<TRow, TKey>(this System.Data.TypedTableBase<TRow> source, System.Func<TRow, TKey> keySelector) where TRow : System.Data.DataRow { return default(System.Data.OrderedEnumerableRowCollection<TRow>); }
    public static System.Data.OrderedEnumerableRowCollection<TRow> OrderBy<TRow, TKey>(this System.Data.TypedTableBase<TRow> source, System.Func<TRow, TKey> keySelector, System.Collections.Generic.IComparer<TKey> comparer) where TRow : System.Data.DataRow { return default(System.Data.OrderedEnumerableRowCollection<TRow>); }
    public static System.Data.OrderedEnumerableRowCollection<TRow> OrderByDescending<TRow, TKey>(this System.Data.TypedTableBase<TRow> source, System.Func<TRow, TKey> keySelector) where TRow : System.Data.DataRow { return default(System.Data.OrderedEnumerableRowCollection<TRow>); }
    public static System.Data.OrderedEnumerableRowCollection<TRow> OrderByDescending<TRow, TKey>(this System.Data.TypedTableBase<TRow> source, System.Func<TRow, TKey> keySelector, System.Collections.Generic.IComparer<TKey> comparer) where TRow : System.Data.DataRow { return default(System.Data.OrderedEnumerableRowCollection<TRow>); }
    public static System.Data.EnumerableRowCollection<S> Select<TRow, S>(this System.Data.TypedTableBase<TRow> source, System.Func<TRow, S> selector) where TRow : System.Data.DataRow { return default(System.Data.EnumerableRowCollection<S>); }
    public static System.Data.EnumerableRowCollection<TRow> Where<TRow>(this System.Data.TypedTableBase<TRow> source, System.Func<TRow, System.Boolean> predicate) where TRow : System.Data.DataRow { return default(System.Data.EnumerableRowCollection<TRow>); }
  }
}
