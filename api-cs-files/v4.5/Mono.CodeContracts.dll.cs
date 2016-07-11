namespace Mono.CodeContracts.Rewrite {
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Size=1)]
  public partial struct AssemblyRef {
    public AssemblyRef(Mono.CodeContracts.Rewrite.AssemblyRef.TwoStreams streams) { throw new System.NotImplementedException(); }
    public AssemblyRef(string filename) { throw new System.NotImplementedException(); }
    public string Filename { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public bool IsFilename { get { return default(bool); } }
    public bool IsSet { get { return default(bool); } }
    public bool IsStream { get { return default(bool); } }
    public Mono.CodeContracts.Rewrite.AssemblyRef.TwoStreams Streams { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CodeContracts.Rewrite.AssemblyRef.TwoStreams); } }
    public static implicit operator Mono.CodeContracts.Rewrite.AssemblyRef (System.IO.Stream stream) { return default(Mono.CodeContracts.Rewrite.AssemblyRef); }
    public static implicit operator Mono.CodeContracts.Rewrite.AssemblyRef (string filename) { return default(Mono.CodeContracts.Rewrite.AssemblyRef); }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Size=1)]
    public partial struct TwoStreams {
      public TwoStreams(System.IO.Stream assembly, System.IO.Stream symbols) { throw new System.NotImplementedException(); }
      public System.IO.Stream Assembly { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.IO.Stream); } }
      public System.IO.Stream Symbols { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.IO.Stream); } }
    }
  }
  public partial class Rewriter {
    internal Rewriter() { }
    public static Mono.CodeContracts.Rewrite.RewriterResults Rewrite(Mono.CodeContracts.Rewrite.RewriterOptions options) { return default(Mono.CodeContracts.Rewrite.RewriterResults); }
  }
  public partial class RewriterOptions {
    public RewriterOptions() { }
    public Mono.CodeContracts.Rewrite.AssemblyRef Assembly { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CodeContracts.Rewrite.AssemblyRef); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool BreakIntoDebugger { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool Debug { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string ForceAssemblyRename { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public int Level { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public Mono.CodeContracts.Rewrite.AssemblyRef OutputFile { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.CodeContracts.Rewrite.AssemblyRef); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool Rewrite { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool ThrowOnFailure { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool WritePdbFile { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial class RewriterResults {
    internal RewriterResults() { }
    public bool AnyErrors { get { return default(bool); } }
    public bool AnyWarnings { get { return default(bool); } }
    public System.Collections.Generic.IEnumerable<System.String> Errors { get { return default(System.Collections.Generic.IEnumerable<System.String>); } }
    public System.Collections.Generic.IEnumerable<System.String> Warnings { get { return default(System.Collections.Generic.IEnumerable<System.String>); } }
  }
}
namespace Mono.CodeContracts.Static {
  public partial class Checker {
    internal Checker() { }
    public static Mono.CodeContracts.Static.CheckResults Check(Mono.CodeContracts.Static.CheckOptions options) { return default(Mono.CodeContracts.Static.CheckResults); }
  }
  public partial class CheckOptions {
    public CheckOptions() { }
    public string Assembly { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Method { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool ShowDebug { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial class CheckResults {
    internal CheckResults() { }
    public bool AnyErrors { get { return default(bool); } }
    public bool AnyWarnings { get { return default(bool); } }
    public System.Collections.Generic.IEnumerable<System.String> Errors { get { return default(System.Collections.Generic.IEnumerable<System.String>); } }
    public System.Collections.Generic.IDictionary<System.String, System.Collections.Generic.ICollection<System.String>> Results { get { return default(System.Collections.Generic.IDictionary<System.String, System.Collections.Generic.ICollection<System.String>>); } }
    public System.Collections.Generic.IEnumerable<System.String> Warnings { get { return default(System.Collections.Generic.IEnumerable<System.String>); } }
  }
}
namespace Mono.CodeContracts.Static.Analysis.Numerical {
  public partial class DisInterval : Mono.CodeContracts.Static.Analysis.Numerical.IntervalBase<Mono.CodeContracts.Static.Analysis.Numerical.DisInterval, Mono.CodeContracts.Static.Analysis.Numerical.Rational> {
    internal DisInterval() : base (default(Mono.CodeContracts.Static.Analysis.Numerical.Rational), default(Mono.CodeContracts.Static.Analysis.Numerical.Rational)) { }
    public static readonly Mono.CodeContracts.Static.Analysis.Numerical.DisInterval NotZero;
    public Mono.CodeContracts.Static.Analysis.Numerical.Interval AsInterval { get { return default(Mono.CodeContracts.Static.Analysis.Numerical.Interval); } }
    public override Mono.CodeContracts.Static.Analysis.Numerical.DisInterval Bottom { get { return default(Mono.CodeContracts.Static.Analysis.Numerical.DisInterval); } }
    public static Mono.CodeContracts.Static.Analysis.Numerical.DisInterval BottomValue { get { return default(Mono.CodeContracts.Static.Analysis.Numerical.DisInterval); } }
    public override bool IsBottom { get { return default(bool); } }
    public bool IsNotZero { get { return default(bool); } }
    public bool IsPositiveOrZero { get { return default(bool); } }
    public override bool IsTop { get { return default(bool); } }
    public override Mono.CodeContracts.Static.Analysis.Numerical.DisInterval Top { get { return default(Mono.CodeContracts.Static.Analysis.Numerical.DisInterval); } }
    public static Mono.CodeContracts.Static.Analysis.Numerical.DisInterval TopValue { get { return default(Mono.CodeContracts.Static.Analysis.Numerical.DisInterval); } }
    public override Mono.CodeContracts.Static.Analysis.Numerical.DisInterval Clone() { return default(Mono.CodeContracts.Static.Analysis.Numerical.DisInterval); }
    public override void Dump(System.IO.TextWriter tw) { }
    public override bool Equals(object other) { return default(bool); }
    public static Mono.CodeContracts.Static.Analysis.Numerical.DisInterval EverythingExcept(Mono.CodeContracts.Static.Analysis.Numerical.DisInterval interval) { return default(Mono.CodeContracts.Static.Analysis.Numerical.DisInterval); }
    public static Mono.CodeContracts.Static.Analysis.Numerical.DisInterval For(Mono.CodeContracts.Static.Analysis.Numerical.Interval interval) { return default(Mono.CodeContracts.Static.Analysis.Numerical.DisInterval); }
    public static Mono.CodeContracts.Static.Analysis.Numerical.DisInterval For(Mono.CodeContracts.Static.DataStructures.Sequence<Mono.CodeContracts.Static.Analysis.Numerical.Interval> intervals) { return default(Mono.CodeContracts.Static.Analysis.Numerical.DisInterval); }
    public override int GetHashCode() { return default(int); }
    public override Mono.CodeContracts.Static.Analysis.Numerical.DisInterval ImmutableVersion() { return default(Mono.CodeContracts.Static.Analysis.Numerical.DisInterval); }
    protected override bool IsFiniteBound(Mono.CodeContracts.Static.Analysis.Numerical.Rational n) { return default(bool); }
    public override Mono.CodeContracts.Static.Analysis.Numerical.DisInterval Join(Mono.CodeContracts.Static.Analysis.Numerical.DisInterval that) { return default(Mono.CodeContracts.Static.Analysis.Numerical.DisInterval); }
    public override Mono.CodeContracts.Static.Analysis.Numerical.DisInterval Join(Mono.CodeContracts.Static.Analysis.Numerical.DisInterval that, bool widening, out bool weaker) { weaker = default(bool); return default(Mono.CodeContracts.Static.Analysis.Numerical.DisInterval); }
    public static Mono.CodeContracts.Static.Analysis.Numerical.Interval JoinAll(Mono.CodeContracts.Static.DataStructures.Sequence<Mono.CodeContracts.Static.Analysis.Numerical.Interval> list) { return default(Mono.CodeContracts.Static.Analysis.Numerical.Interval); }
    public override bool LessEqual(Mono.CodeContracts.Static.Analysis.Numerical.DisInterval that) { return default(bool); }
    public override Mono.CodeContracts.Static.Analysis.Numerical.DisInterval Meet(Mono.CodeContracts.Static.Analysis.Numerical.DisInterval that) { return default(Mono.CodeContracts.Static.Analysis.Numerical.DisInterval); }
    public static Mono.CodeContracts.Static.DataStructures.Sequence<Mono.CodeContracts.Static.Analysis.Numerical.Interval> Normalize(Mono.CodeContracts.Static.DataStructures.Sequence<Mono.CodeContracts.Static.Analysis.Numerical.Interval> intervals, out bool isBottom) { isBottom = default(bool); return default(Mono.CodeContracts.Static.DataStructures.Sequence<Mono.CodeContracts.Static.Analysis.Numerical.Interval>); }
    public static Mono.CodeContracts.Static.Analysis.Numerical.DisInterval operator +(Mono.CodeContracts.Static.Analysis.Numerical.DisInterval left, Mono.CodeContracts.Static.Analysis.Numerical.DisInterval right) { return default(Mono.CodeContracts.Static.Analysis.Numerical.DisInterval); }
    public static Mono.CodeContracts.Static.Analysis.Numerical.DisInterval operator /(Mono.CodeContracts.Static.Analysis.Numerical.DisInterval left, Mono.CodeContracts.Static.Analysis.Numerical.DisInterval right) { return default(Mono.CodeContracts.Static.Analysis.Numerical.DisInterval); }
    public static Mono.CodeContracts.Static.Analysis.Numerical.DisInterval operator *(Mono.CodeContracts.Static.Analysis.Numerical.DisInterval left, Mono.CodeContracts.Static.Analysis.Numerical.DisInterval right) { return default(Mono.CodeContracts.Static.Analysis.Numerical.DisInterval); }
    public static Mono.CodeContracts.Static.Analysis.Numerical.DisInterval operator -(Mono.CodeContracts.Static.Analysis.Numerical.DisInterval left, Mono.CodeContracts.Static.Analysis.Numerical.DisInterval right) { return default(Mono.CodeContracts.Static.Analysis.Numerical.DisInterval); }
    public static Mono.CodeContracts.Static.Analysis.Numerical.DisInterval operator -(Mono.CodeContracts.Static.Analysis.Numerical.DisInterval left) { return default(Mono.CodeContracts.Static.Analysis.Numerical.DisInterval); }
    public Mono.CodeContracts.Static.Analysis.Numerical.DisInterval Select(System.Func<Mono.CodeContracts.Static.Analysis.Numerical.Interval, Mono.CodeContracts.Static.Analysis.Numerical.Interval> selector) { return default(Mono.CodeContracts.Static.Analysis.Numerical.DisInterval); }
    public override string ToString() { return default(string); }
    public override Mono.CodeContracts.Static.Analysis.Numerical.DisInterval Widen(Mono.CodeContracts.Static.Analysis.Numerical.DisInterval that) { return default(Mono.CodeContracts.Static.Analysis.Numerical.DisInterval); }
  }
  public enum ExpressionOperator {
    Add = 16,
    And = 3,
    Constant = 0,
    ConvertToInt32 = 24,
    Div = 19,
    Equal = 9,
    Equal_Obj = 10,
    GreaterEqualThan = 15,
    GreaterThan = 14,
    LessEqualThan = 13,
    LessThan = 12,
    LogicalAnd = 6,
    LogicalNot = 8,
    LogicalOr = 7,
    Mod = 20,
    Mult = 18,
    Not = 2,
    NotEqual = 11,
    Or = 4,
    SizeOf = 22,
    Sub = 17,
    UnaryMinus = 21,
    Unknown = 23,
    Variable = 1,
    Xor = 5,
  }
  public partial class Interval : Mono.CodeContracts.Static.Analysis.Numerical.IntervalBase<Mono.CodeContracts.Static.Analysis.Numerical.Interval, Mono.CodeContracts.Static.Analysis.Numerical.Rational>, System.IEquatable<Mono.CodeContracts.Static.Analysis.Numerical.Interval> {
    internal Interval() : base (default(Mono.CodeContracts.Static.Analysis.Numerical.Rational), default(Mono.CodeContracts.Static.Analysis.Numerical.Rational)) { }
    public override Mono.CodeContracts.Static.Analysis.Numerical.Interval Bottom { get { return default(Mono.CodeContracts.Static.Analysis.Numerical.Interval); } }
    public static Mono.CodeContracts.Static.Analysis.Numerical.Interval BottomValue { get { return default(Mono.CodeContracts.Static.Analysis.Numerical.Interval); } }
    public override bool IsBottom { get { return default(bool); } }
    public override bool IsTop { get { return default(bool); } }
    public override Mono.CodeContracts.Static.Analysis.Numerical.Interval Top { get { return default(Mono.CodeContracts.Static.Analysis.Numerical.Interval); } }
    public static Mono.CodeContracts.Static.Analysis.Numerical.Interval TopValue { get { return default(Mono.CodeContracts.Static.Analysis.Numerical.Interval); } }
    public static Mono.CodeContracts.Static.Analysis.Numerical.Interval ApplyConversion(Mono.CodeContracts.Static.Analysis.Numerical.ExpressionOperator conv, Mono.CodeContracts.Static.Analysis.Numerical.Interval intv) { return default(Mono.CodeContracts.Static.Analysis.Numerical.Interval); }
    public static bool AreConsecutiveIntegers(Mono.CodeContracts.Static.Analysis.Numerical.Interval prev, Mono.CodeContracts.Static.Analysis.Numerical.Interval next) { return default(bool); }
    public override Mono.CodeContracts.Static.Analysis.Numerical.Interval Clone() { return default(Mono.CodeContracts.Static.Analysis.Numerical.Interval); }
    public override void Dump(System.IO.TextWriter tw) { }
    public bool Equals(Mono.CodeContracts.Static.Analysis.Numerical.Interval that) { return default(bool); }
    public override bool Equals(object obj) { return default(bool); }
    public static Mono.CodeContracts.Static.Analysis.Numerical.Interval For(Mono.CodeContracts.Static.Analysis.Numerical.Rational value) { return default(Mono.CodeContracts.Static.Analysis.Numerical.Interval); }
    public static Mono.CodeContracts.Static.Analysis.Numerical.Interval For(Mono.CodeContracts.Static.Analysis.Numerical.Rational lowerBound, Mono.CodeContracts.Static.Analysis.Numerical.Rational upperBound) { return default(Mono.CodeContracts.Static.Analysis.Numerical.Interval); }
    public static Mono.CodeContracts.Static.Analysis.Numerical.Interval For(Mono.CodeContracts.Static.Analysis.Numerical.Rational lowerBound, long upperBound) { return default(Mono.CodeContracts.Static.Analysis.Numerical.Interval); }
    public static Mono.CodeContracts.Static.Analysis.Numerical.Interval For(long value) { return default(Mono.CodeContracts.Static.Analysis.Numerical.Interval); }
    public static Mono.CodeContracts.Static.Analysis.Numerical.Interval For(long lower, Mono.CodeContracts.Static.Analysis.Numerical.Rational upperBound) { return default(Mono.CodeContracts.Static.Analysis.Numerical.Interval); }
    public static Mono.CodeContracts.Static.Analysis.Numerical.Interval For(long lowerBound, long upperBound) { return default(Mono.CodeContracts.Static.Analysis.Numerical.Interval); }
    public override int GetHashCode() { return default(int); }
    public override Mono.CodeContracts.Static.Analysis.Numerical.Interval ImmutableVersion() { return default(Mono.CodeContracts.Static.Analysis.Numerical.Interval); }
    public bool Includes(int x) { return default(bool); }
    public bool Includes(long x) { return default(bool); }
    protected override bool IsFiniteBound(Mono.CodeContracts.Static.Analysis.Numerical.Rational n) { return default(bool); }
    public override Mono.CodeContracts.Static.Analysis.Numerical.Interval Join(Mono.CodeContracts.Static.Analysis.Numerical.Interval that) { return default(Mono.CodeContracts.Static.Analysis.Numerical.Interval); }
    public override Mono.CodeContracts.Static.Analysis.Numerical.Interval Join(Mono.CodeContracts.Static.Analysis.Numerical.Interval that, bool widening, out bool weaker) { weaker = default(bool); return default(Mono.CodeContracts.Static.Analysis.Numerical.Interval); }
    public override bool LessEqual(Mono.CodeContracts.Static.Analysis.Numerical.Interval that) { return default(bool); }
    public bool LessEqual(System.Collections.Generic.IEnumerable<Mono.CodeContracts.Static.Analysis.Numerical.Interval> right) { return default(bool); }
    public override Mono.CodeContracts.Static.Analysis.Numerical.Interval Meet(Mono.CodeContracts.Static.Analysis.Numerical.Interval that) { return default(Mono.CodeContracts.Static.Analysis.Numerical.Interval); }
    public bool OnTheLeftOf(Mono.CodeContracts.Static.Analysis.Numerical.Interval that) { return default(bool); }
    public static Mono.CodeContracts.Static.Analysis.Numerical.Interval operator +(Mono.CodeContracts.Static.Analysis.Numerical.Interval l, Mono.CodeContracts.Static.Analysis.Numerical.Interval r) { return default(Mono.CodeContracts.Static.Analysis.Numerical.Interval); }
    public static Mono.CodeContracts.Static.Analysis.Numerical.Interval operator /(Mono.CodeContracts.Static.Analysis.Numerical.Interval l, Mono.CodeContracts.Static.Analysis.Numerical.Interval r) { return default(Mono.CodeContracts.Static.Analysis.Numerical.Interval); }
    public static Mono.CodeContracts.Static.Analysis.Numerical.Interval operator *(Mono.CodeContracts.Static.Analysis.Numerical.Interval l, Mono.CodeContracts.Static.Analysis.Numerical.Interval r) { return default(Mono.CodeContracts.Static.Analysis.Numerical.Interval); }
    public static Mono.CodeContracts.Static.Analysis.Numerical.Interval operator -(Mono.CodeContracts.Static.Analysis.Numerical.Interval l, Mono.CodeContracts.Static.Analysis.Numerical.Interval r) { return default(Mono.CodeContracts.Static.Analysis.Numerical.Interval); }
    public static Mono.CodeContracts.Static.Analysis.Numerical.Interval operator -(Mono.CodeContracts.Static.Analysis.Numerical.Interval l) { return default(Mono.CodeContracts.Static.Analysis.Numerical.Interval); }
    public bool OverlapsWith(Mono.CodeContracts.Static.Analysis.Numerical.Interval that) { return default(bool); }
    public bool TryGetSingletonFiniteInt32(out int value) { value = default(int); return default(bool); }
    public override Mono.CodeContracts.Static.Analysis.Numerical.Interval Widen(Mono.CodeContracts.Static.Analysis.Numerical.Interval that) { return default(Mono.CodeContracts.Static.Analysis.Numerical.Interval); }
  }
  public abstract partial class IntervalBase<TInterval, TNumeric> : Mono.CodeContracts.Static.Lattices.IAbstractDomain<TInterval> where TInterval : Mono.CodeContracts.Static.Analysis.Numerical.IntervalBase<TInterval, TNumeric> {
    protected IntervalBase(TNumeric lowerBound, TNumeric upperBound) { }
    public abstract TInterval Bottom { get; }
    public abstract bool IsBottom { get; }
    public bool IsFinite { get { return default(bool); } }
    public bool IsSinglePoint { get { return default(bool); } }
    public abstract bool IsTop { get; }
    public TNumeric LowerBound { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TNumeric); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public abstract TInterval Top { get; }
    public TNumeric UpperBound { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(TNumeric); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public abstract TInterval Clone();
    public abstract void Dump(System.IO.TextWriter tw);
    public abstract TInterval ImmutableVersion();
    protected abstract bool IsFiniteBound(TNumeric n);
    public abstract TInterval Join(TInterval that);
    public abstract TInterval Join(TInterval that, bool widening, out bool weaker);
    public abstract bool LessEqual(TInterval that);
    public abstract TInterval Meet(TInterval that);
    public override string ToString() { return default(string); }
    public abstract TInterval Widen(TInterval that);
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Rational : System.IEquatable<Mono.CodeContracts.Static.Analysis.Numerical.Rational> {
    public static Mono.CodeContracts.Static.Analysis.Numerical.Rational MaxValue;
    public static Mono.CodeContracts.Static.Analysis.Numerical.Rational MinusInfinity;
    public static readonly Mono.CodeContracts.Static.Analysis.Numerical.Rational MinusOne;
    public static Mono.CodeContracts.Static.Analysis.Numerical.Rational MinValue;
    public static readonly Mono.CodeContracts.Static.Analysis.Numerical.Rational One;
    public static Mono.CodeContracts.Static.Analysis.Numerical.Rational PlusInfinity;
    public static readonly Mono.CodeContracts.Static.Analysis.Numerical.Rational Zero;
    public long Down { get { return default(long); } }
    public bool IsInfinity { get { return default(bool); } }
    public bool IsInt32 { get { return default(bool); } }
    public bool IsInteger { get { return default(bool); } }
    public bool IsMaxValue { get { return default(bool); } }
    public bool IsMinusInfinity { get { return default(bool); } }
    public bool IsMinValue { get { return default(bool); } }
    public bool IsPlusInfinity { get { return default(bool); } }
    public bool IsZero { get { return default(bool); } }
    public Mono.CodeContracts.Static.Analysis.Numerical.Rational NextInt32 { get { return default(Mono.CodeContracts.Static.Analysis.Numerical.Rational); } }
    public Mono.CodeContracts.Static.Analysis.Numerical.Rational NextInt64 { get { return default(Mono.CodeContracts.Static.Analysis.Numerical.Rational); } }
    public Mono.CodeContracts.Static.Analysis.Numerical.Rational PreviousInt32 { get { return default(Mono.CodeContracts.Static.Analysis.Numerical.Rational); } }
    public int Sign { get { return default(int); } }
    public long Up { get { return default(long); } }
    public static Mono.CodeContracts.Static.Analysis.Numerical.Rational Abs(Mono.CodeContracts.Static.Analysis.Numerical.Rational a) { return default(Mono.CodeContracts.Static.Analysis.Numerical.Rational); }
    public bool Equals(Mono.CodeContracts.Static.Analysis.Numerical.Rational other) { return default(bool); }
    public override bool Equals(object obj) { return default(bool); }
    public static Mono.CodeContracts.Static.Analysis.Numerical.Rational For(long number) { return default(Mono.CodeContracts.Static.Analysis.Numerical.Rational); }
    public static Mono.CodeContracts.Static.Analysis.Numerical.Rational For(long nominator, long denominator) { return default(Mono.CodeContracts.Static.Analysis.Numerical.Rational); }
    public override int GetHashCode() { return default(int); }
    public bool IsInRange(long min, long max) { return default(bool); }
    public static Mono.CodeContracts.Static.Analysis.Numerical.Rational Max(Mono.CodeContracts.Static.Analysis.Numerical.Rational a, Mono.CodeContracts.Static.Analysis.Numerical.Rational b) { return default(Mono.CodeContracts.Static.Analysis.Numerical.Rational); }
    public static Mono.CodeContracts.Static.Analysis.Numerical.Rational Min(Mono.CodeContracts.Static.Analysis.Numerical.Rational a, Mono.CodeContracts.Static.Analysis.Numerical.Rational b) { return default(Mono.CodeContracts.Static.Analysis.Numerical.Rational); }
    public static Mono.CodeContracts.Static.Analysis.Numerical.Rational operator +(Mono.CodeContracts.Static.Analysis.Numerical.Rational l, Mono.CodeContracts.Static.Analysis.Numerical.Rational r) { return default(Mono.CodeContracts.Static.Analysis.Numerical.Rational); }
    public static Mono.CodeContracts.Static.Analysis.Numerical.Rational operator +(Mono.CodeContracts.Static.Analysis.Numerical.Rational l, long i) { return default(Mono.CodeContracts.Static.Analysis.Numerical.Rational); }
    public static Mono.CodeContracts.Static.Analysis.Numerical.Rational operator /(Mono.CodeContracts.Static.Analysis.Numerical.Rational l, Mono.CodeContracts.Static.Analysis.Numerical.Rational r) { return default(Mono.CodeContracts.Static.Analysis.Numerical.Rational); }
    public static bool operator ==(Mono.CodeContracts.Static.Analysis.Numerical.Rational l, Mono.CodeContracts.Static.Analysis.Numerical.Rational r) { return default(bool); }
    public static explicit operator double (Mono.CodeContracts.Static.Analysis.Numerical.Rational r) { return default(double); }
    public static explicit operator int (Mono.CodeContracts.Static.Analysis.Numerical.Rational r) { return default(int); }
    public static explicit operator long (Mono.CodeContracts.Static.Analysis.Numerical.Rational r) { return default(long); }
    public static bool operator >(Mono.CodeContracts.Static.Analysis.Numerical.Rational l, Mono.CodeContracts.Static.Analysis.Numerical.Rational r) { return default(bool); }
    public static bool operator >(Mono.CodeContracts.Static.Analysis.Numerical.Rational l, long r) { return default(bool); }
    public static bool operator >(long l, Mono.CodeContracts.Static.Analysis.Numerical.Rational r) { return default(bool); }
    public static bool operator >=(Mono.CodeContracts.Static.Analysis.Numerical.Rational l, Mono.CodeContracts.Static.Analysis.Numerical.Rational r) { return default(bool); }
    public static bool operator >=(Mono.CodeContracts.Static.Analysis.Numerical.Rational l, long r) { return default(bool); }
    public static bool operator >=(long l, Mono.CodeContracts.Static.Analysis.Numerical.Rational r) { return default(bool); }
    public static implicit operator Mono.CodeContracts.Static.Analysis.Numerical.Rational (long l) { return default(Mono.CodeContracts.Static.Analysis.Numerical.Rational); }
    public static bool operator !=(Mono.CodeContracts.Static.Analysis.Numerical.Rational l, Mono.CodeContracts.Static.Analysis.Numerical.Rational r) { return default(bool); }
    public static bool operator <(Mono.CodeContracts.Static.Analysis.Numerical.Rational l, Mono.CodeContracts.Static.Analysis.Numerical.Rational r) { return default(bool); }
    public static bool operator <(Mono.CodeContracts.Static.Analysis.Numerical.Rational l, long r) { return default(bool); }
    public static bool operator <(long l, Mono.CodeContracts.Static.Analysis.Numerical.Rational r) { return default(bool); }
    public static bool operator <=(Mono.CodeContracts.Static.Analysis.Numerical.Rational l, Mono.CodeContracts.Static.Analysis.Numerical.Rational r) { return default(bool); }
    public static bool operator <=(Mono.CodeContracts.Static.Analysis.Numerical.Rational l, long r) { return default(bool); }
    public static bool operator <=(long l, Mono.CodeContracts.Static.Analysis.Numerical.Rational r) { return default(bool); }
    public static Mono.CodeContracts.Static.Analysis.Numerical.Rational operator *(Mono.CodeContracts.Static.Analysis.Numerical.Rational l, Mono.CodeContracts.Static.Analysis.Numerical.Rational r) { return default(Mono.CodeContracts.Static.Analysis.Numerical.Rational); }
    public static Mono.CodeContracts.Static.Analysis.Numerical.Rational operator -(Mono.CodeContracts.Static.Analysis.Numerical.Rational l, Mono.CodeContracts.Static.Analysis.Numerical.Rational r) { return default(Mono.CodeContracts.Static.Analysis.Numerical.Rational); }
    public static Mono.CodeContracts.Static.Analysis.Numerical.Rational operator -(Mono.CodeContracts.Static.Analysis.Numerical.Rational l, long i) { return default(Mono.CodeContracts.Static.Analysis.Numerical.Rational); }
    public static Mono.CodeContracts.Static.Analysis.Numerical.Rational operator -(Mono.CodeContracts.Static.Analysis.Numerical.Rational value) { return default(Mono.CodeContracts.Static.Analysis.Numerical.Rational); }
    public override string ToString() { return default(string); }
    public static bool TryAdd(Mono.CodeContracts.Static.Analysis.Numerical.Rational l, Mono.CodeContracts.Static.Analysis.Numerical.Rational r, out Mono.CodeContracts.Static.Analysis.Numerical.Rational result) { result = default(Mono.CodeContracts.Static.Analysis.Numerical.Rational); return default(bool); }
    public static bool TryDivide(Mono.CodeContracts.Static.Analysis.Numerical.Rational l, Mono.CodeContracts.Static.Analysis.Numerical.Rational r, out Mono.CodeContracts.Static.Analysis.Numerical.Rational result) { result = default(Mono.CodeContracts.Static.Analysis.Numerical.Rational); return default(bool); }
    public static bool TryMultiply(Mono.CodeContracts.Static.Analysis.Numerical.Rational l, Mono.CodeContracts.Static.Analysis.Numerical.Rational r, out Mono.CodeContracts.Static.Analysis.Numerical.Rational result) { result = default(Mono.CodeContracts.Static.Analysis.Numerical.Rational); return default(bool); }
    public static bool TrySubtract(Mono.CodeContracts.Static.Analysis.Numerical.Rational l, Mono.CodeContracts.Static.Analysis.Numerical.Rational r, out Mono.CodeContracts.Static.Analysis.Numerical.Rational result) { result = default(Mono.CodeContracts.Static.Analysis.Numerical.Rational); return default(bool); }
    public static bool TryUnaryMinus(Mono.CodeContracts.Static.Analysis.Numerical.Rational value, out Mono.CodeContracts.Static.Analysis.Numerical.Rational result) { result = default(Mono.CodeContracts.Static.Analysis.Numerical.Rational); return default(bool); }
  }
  public partial class RationalThreshold : Mono.CodeContracts.Static.Analysis.Numerical.Threshold<Mono.CodeContracts.Static.Analysis.Numerical.Rational> {
    public RationalThreshold(int size) : base (default(int)) { }
    protected override Mono.CodeContracts.Static.Analysis.Numerical.Rational MinusInfinity { get { return default(Mono.CodeContracts.Static.Analysis.Numerical.Rational); } }
    protected override Mono.CodeContracts.Static.Analysis.Numerical.Rational PlusInfinity { get { return default(Mono.CodeContracts.Static.Analysis.Numerical.Rational); } }
    protected override Mono.CodeContracts.Static.Analysis.Numerical.Rational Zero { get { return default(Mono.CodeContracts.Static.Analysis.Numerical.Rational); } }
    protected override bool LessThan(Mono.CodeContracts.Static.Analysis.Numerical.Rational a, Mono.CodeContracts.Static.Analysis.Numerical.Rational b) { return default(bool); }
  }
  public abstract partial class Threshold<T> {
    protected int NextFree;
    protected readonly System.Collections.Generic.List<T> Values;
    protected Threshold(int size) { }
    public int Count { get { return default(int); } }
    protected abstract T MinusInfinity { get; }
    protected abstract T PlusInfinity { get; }
    protected abstract T Zero { get; }
    public bool Add(T value) { return default(bool); }
    public int BinarySearch(T value, int low, int hi) { return default(int); }
    public T GetNext(T value) { return default(T); }
    public T GetPrevious(T value) { return default(T); }
    protected abstract bool LessThan(T a, T b);
  }
}
namespace Mono.CodeContracts.Static.DataStructures {
  public partial interface IImmutableIntMap<T> {
    T Any { get; }
    int Count { get; }
    T this[int key] { get; }
    System.Collections.Generic.IEnumerable<System.Int32> Keys { get; }
    System.Collections.Generic.IEnumerable<T> Values { get; }
    Mono.CodeContracts.Static.DataStructures.IImmutableIntMap<T> Add(int key, T value);
    bool Contains(int key);
    T Lookup(int key);
    Mono.CodeContracts.Static.DataStructures.IImmutableIntMap<T> Remove(int key);
    void Visit(System.Action<T> action);
    void Visit(System.Action<System.Int32, T> action);
  }
  public static partial class ImmutableIntMap<T> {
    public static readonly Mono.CodeContracts.Static.DataStructures.IImmutableIntMap<T> Empty;
  }
  public partial class Sequence<T> : System.IEquatable<Mono.CodeContracts.Static.DataStructures.Sequence<T>> {
    internal Sequence() { }
    public static readonly Mono.CodeContracts.Static.DataStructures.Sequence<T> Empty;
    public T Head { get { return default(T); } }
    public Mono.CodeContracts.Static.DataStructures.Sequence<T> Tail { get { return default(Mono.CodeContracts.Static.DataStructures.Sequence<T>); } }
    public static void Apply(Mono.CodeContracts.Static.DataStructures.Sequence<T> list, System.Action<T> action) { }
    public static Mono.CodeContracts.Static.DataStructures.Sequence<T> Cons(T elem, Mono.CodeContracts.Static.DataStructures.Sequence<T> tail) { return default(Mono.CodeContracts.Static.DataStructures.Sequence<T>); }
    public static bool Contains(Mono.CodeContracts.Static.DataStructures.Sequence<T> l, T o) { return default(bool); }
    public bool Equals(Mono.CodeContracts.Static.DataStructures.Sequence<T> other) { return default(bool); }
    public override bool Equals(object obj) { return default(bool); }
    public static Mono.CodeContracts.Static.DataStructures.Sequence<T> From(params T[] elems) { return default(Mono.CodeContracts.Static.DataStructures.Sequence<T>); }
    public static Mono.CodeContracts.Static.DataStructures.Sequence<T> From(System.Collections.Generic.IEnumerable<T> elems) { return default(Mono.CodeContracts.Static.DataStructures.Sequence<T>); }
    public override int GetHashCode() { return default(int); }
    public static int LengthOf(Mono.CodeContracts.Static.DataStructures.Sequence<T> list) { return default(int); }
    [System.Diagnostics.DebuggerHiddenAttribute]
    public static System.Collections.Generic.IEnumerable<T> PrivateGetEnumerable(Mono.CodeContracts.Static.DataStructures.Sequence<T> list) { return default(System.Collections.Generic.IEnumerable<T>); }
    public static Mono.CodeContracts.Static.DataStructures.Sequence<S> Select<S>(Mono.CodeContracts.Static.DataStructures.Sequence<T> list, System.Func<T, S> selector) { return default(Mono.CodeContracts.Static.DataStructures.Sequence<S>); }
    public static Mono.CodeContracts.Static.DataStructures.Sequence<T> Singleton(T value) { return default(Mono.CodeContracts.Static.DataStructures.Sequence<T>); }
    public override string ToString() { return default(string); }
  }
  public static partial class SequenceExtensions {
    public static bool All<T>(this Mono.CodeContracts.Static.DataStructures.Sequence<T> list, System.Predicate<T> predicate) { return default(bool); }
    public static bool Any<T>(this Mono.CodeContracts.Static.DataStructures.Sequence<T> list, System.Predicate<T> predicate) { return default(bool); }
    public static Mono.CodeContracts.Static.DataStructures.Sequence<T> Append<T>(this Mono.CodeContracts.Static.DataStructures.Sequence<T> list, Mono.CodeContracts.Static.DataStructures.Sequence<T> append) { return default(Mono.CodeContracts.Static.DataStructures.Sequence<T>); }
    public static void Apply<T>(this Mono.CodeContracts.Static.DataStructures.Sequence<T> list, System.Action<T> action) { }
    public static System.Collections.Generic.IEnumerable<T> AsEnumerable<T>(this Mono.CodeContracts.Static.DataStructures.Sequence<T> list) { return default(System.Collections.Generic.IEnumerable<T>); }
    public static Mono.CodeContracts.Static.DataStructures.Sequence<T> Coerce<S, T>(this Mono.CodeContracts.Static.DataStructures.Sequence<S> list) where S : T { return default(Mono.CodeContracts.Static.DataStructures.Sequence<T>); }
    public static Mono.CodeContracts.Static.DataStructures.Sequence<T> Cons<T>(this Mono.CodeContracts.Static.DataStructures.Sequence<T> rest, T elem) { return default(Mono.CodeContracts.Static.DataStructures.Sequence<T>); }
    public static void ForEach<T>(this Mono.CodeContracts.Static.DataStructures.Sequence<T> seq, System.Action<T> action) { }
    public static bool IsEmpty<T>(this Mono.CodeContracts.Static.DataStructures.Sequence<T> list) { return default(bool); }
    public static T Last<T>(this Mono.CodeContracts.Static.DataStructures.Sequence<T> list) { return default(T); }
    public static int Length<T>(this Mono.CodeContracts.Static.DataStructures.Sequence<T> list) { return default(int); }
    public static Mono.CodeContracts.Static.DataStructures.Sequence<T> Reverse<T>(this Mono.CodeContracts.Static.DataStructures.Sequence<T> list) { return default(Mono.CodeContracts.Static.DataStructures.Sequence<T>); }
    public static Mono.CodeContracts.Static.DataStructures.Sequence<S> Select<T, S>(this Mono.CodeContracts.Static.DataStructures.Sequence<T> list, System.Func<T, S> selector) { return default(Mono.CodeContracts.Static.DataStructures.Sequence<S>); }
    public static Mono.CodeContracts.Static.DataStructures.Sequence<T> Where<T>(this Mono.CodeContracts.Static.DataStructures.Sequence<T> list, System.Predicate<T> keep) { return default(Mono.CodeContracts.Static.DataStructures.Sequence<T>); }
  }
}
namespace Mono.CodeContracts.Static.DataStructures.Patricia {
  public partial class BranchNode<T> : Mono.CodeContracts.Static.DataStructures.Patricia.PatriciaTrieNode<T> {
    public readonly int BranchingBit;
    public readonly Mono.CodeContracts.Static.DataStructures.Patricia.PatriciaTrieNode<T> Left;
    public readonly int Prefix;
    public readonly Mono.CodeContracts.Static.DataStructures.Patricia.PatriciaTrieNode<T> Right;
    public BranchNode(int prefix, int branchingBit, Mono.CodeContracts.Static.DataStructures.Patricia.PatriciaTrieNode<T> left, Mono.CodeContracts.Static.DataStructures.Patricia.PatriciaTrieNode<T> right) { }
    public override int Count { get { return default(int); } }
    public override int Key { get { return default(int); } }
    public override Mono.CodeContracts.Static.DataStructures.IImmutableIntMap<T> Add(int key, T value) { return default(Mono.CodeContracts.Static.DataStructures.IImmutableIntMap<T>); }
    protected internal override void AppendToBuilder(System.Text.StringBuilder sb) { }
    public override bool Contains(int key) { return default(bool); }
    protected internal override void Dump(System.IO.TextWriter tw, string prefix) { }
    protected internal override void FillKeysTo(System.Collections.Generic.List<System.Int32> list) { }
    protected internal override void FillValuesTo(System.Collections.Generic.List<T> list) { }
    public override T Lookup(int key) { return default(T); }
    public override Mono.CodeContracts.Static.DataStructures.IImmutableIntMap<T> Remove(int key) { return default(Mono.CodeContracts.Static.DataStructures.IImmutableIntMap<T>); }
    public override void Visit(System.Action<T> action) { }
    public override void Visit(System.Action<System.Int32, T> action) { }
  }
  public partial class EmptyNode<T> : Mono.CodeContracts.Static.DataStructures.Patricia.PatriciaTrieNode<T> {
    public static readonly Mono.CodeContracts.Static.DataStructures.Patricia.EmptyNode<T> Instance;
    public EmptyNode() { }
    public override int Count { get { return default(int); } }
    public override int Key { get { return default(int); } }
    public override Mono.CodeContracts.Static.DataStructures.IImmutableIntMap<T> Add(int key, T value) { return default(Mono.CodeContracts.Static.DataStructures.IImmutableIntMap<T>); }
    protected internal override void AppendToBuilder(System.Text.StringBuilder sb) { }
    public override bool Contains(int key) { return default(bool); }
    protected internal override void Dump(System.IO.TextWriter tw, string prefix) { }
    protected internal override void FillKeysTo(System.Collections.Generic.List<System.Int32> list) { }
    protected internal override void FillValuesTo(System.Collections.Generic.List<T> list) { }
    public override T Lookup(int key) { return default(T); }
    public override Mono.CodeContracts.Static.DataStructures.IImmutableIntMap<T> Remove(int key) { return default(Mono.CodeContracts.Static.DataStructures.IImmutableIntMap<T>); }
    public override void Visit(System.Action<T> action) { }
    public override void Visit(System.Action<System.Int32, T> action) { }
  }
  public partial class LeafNode<T> : Mono.CodeContracts.Static.DataStructures.Patricia.PatriciaTrieNode<T> {
    public LeafNode(int key, T value) { }
    public override int Count { get { return default(int); } }
    public override int Key { get { return default(int); } }
    public T Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(T); } }
    public override Mono.CodeContracts.Static.DataStructures.IImmutableIntMap<T> Add(int key, T value) { return default(Mono.CodeContracts.Static.DataStructures.IImmutableIntMap<T>); }
    protected internal override void AppendToBuilder(System.Text.StringBuilder sb) { }
    public override bool Contains(int key) { return default(bool); }
    protected internal override void Dump(System.IO.TextWriter tw, string prefix) { }
    protected internal override void FillKeysTo(System.Collections.Generic.List<System.Int32> list) { }
    protected internal override void FillValuesTo(System.Collections.Generic.List<T> list) { }
    public override T Lookup(int key) { return default(T); }
    public override Mono.CodeContracts.Static.DataStructures.IImmutableIntMap<T> Remove(int key) { return default(Mono.CodeContracts.Static.DataStructures.IImmutableIntMap<T>); }
    public override void Visit(System.Action<T> action) { }
    public override void Visit(System.Action<System.Int32, T> action) { }
  }
  public abstract partial class PatriciaTrieNode<T> : Mono.CodeContracts.Static.DataStructures.IImmutableIntMap<T> {
    protected PatriciaTrieNode() { }
    public T Any { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(T); } }
    public abstract int Count { get; }
    public T this[int key] { get { return default(T); } }
    public abstract int Key { get; }
    public System.Collections.Generic.IEnumerable<System.Int32> Keys { get { return default(System.Collections.Generic.IEnumerable<System.Int32>); } }
    public System.Collections.Generic.IEnumerable<T> Values { get { return default(System.Collections.Generic.IEnumerable<T>); } }
    public abstract Mono.CodeContracts.Static.DataStructures.IImmutableIntMap<T> Add(int key, T value);
    protected internal abstract void AppendToBuilder(System.Text.StringBuilder sb);
    public abstract bool Contains(int key);
    public void Dump(System.IO.TextWriter tw) { }
    protected internal abstract void Dump(System.IO.TextWriter tw, string prefix);
    protected internal abstract void FillKeysTo(System.Collections.Generic.List<System.Int32> list);
    protected internal abstract void FillValuesTo(System.Collections.Generic.List<T> list);
    protected static bool IsZeroBitAt(int key, int branchingBit) { return default(bool); }
    protected static Mono.CodeContracts.Static.DataStructures.IImmutableIntMap<T> Join(Mono.CodeContracts.Static.DataStructures.Patricia.PatriciaTrieNode<T> left, Mono.CodeContracts.Static.DataStructures.Patricia.PatriciaTrieNode<T> right) { return default(Mono.CodeContracts.Static.DataStructures.IImmutableIntMap<T>); }
    public abstract T Lookup(int key);
    protected static bool MatchPrefix(int key, int prefix, int maskBit) { return default(bool); }
    public abstract Mono.CodeContracts.Static.DataStructures.IImmutableIntMap<T> Remove(int key);
    public override string ToString() { return default(string); }
    public abstract void Visit(System.Action<T> action);
    public abstract void Visit(System.Action<System.Int32, T> action);
  }
}
namespace Mono.CodeContracts.Static.Lattices {
  public static partial class AbstractDomainExtensions {
    public static string BottomSymbolIfAny<T>(this Mono.CodeContracts.Static.Lattices.IAbstractDomain<T> domain) { return default(string); }
    public static bool IsNormal<T>(this Mono.CodeContracts.Static.Lattices.IAbstractDomain<T> domain) { return default(bool); }
    public static bool TryTrivialJoin<T>(this T left, T right, out T result) where T : Mono.CodeContracts.Static.Lattices.IAbstractDomain<T> { result = default(T); return default(bool); }
    public static bool TryTrivialLessEqual<T>(this T left, T right, out bool result) where T : Mono.CodeContracts.Static.Lattices.IAbstractDomain<T> { result = default(bool); return default(bool); }
    public static bool TryTrivialMeet<T>(this T left, T right, out T result) where T : Mono.CodeContracts.Static.Lattices.IAbstractDomain<T> { result = default(T); return default(bool); }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct FlatDomain<T> : Mono.CodeContracts.Static.Lattices.IAbstractDomain<Mono.CodeContracts.Static.Lattices.FlatDomain<T>>, System.IEquatable<Mono.CodeContracts.Static.Lattices.FlatDomain<T>> where T : System.IEquatable<T> {
    public static readonly Mono.CodeContracts.Static.Lattices.FlatDomain<T> BottomValue;
    public static readonly Mono.CodeContracts.Static.Lattices.FlatDomain<T> TopValue;
    public readonly T Value;
    public FlatDomain(T value) { throw new System.NotImplementedException(); }
    public Mono.CodeContracts.Static.Lattices.FlatDomain<T> Bottom { get { return default(Mono.CodeContracts.Static.Lattices.FlatDomain<T>); } }
    public bool IsBottom { get { return default(bool); } }
    public bool IsTop { get { return default(bool); } }
    public Mono.CodeContracts.Static.Lattices.FlatDomain<T> Top { get { return default(Mono.CodeContracts.Static.Lattices.FlatDomain<T>); } }
    public Mono.CodeContracts.Static.Lattices.FlatDomain<T> Clone() { return default(Mono.CodeContracts.Static.Lattices.FlatDomain<T>); }
    public void Dump(System.IO.TextWriter tw) { }
    public bool Equals(Mono.CodeContracts.Static.Lattices.FlatDomain<T> that) { return default(bool); }
    public Mono.CodeContracts.Static.Lattices.FlatDomain<T> ImmutableVersion() { return default(Mono.CodeContracts.Static.Lattices.FlatDomain<T>); }
    public Mono.CodeContracts.Static.Lattices.FlatDomain<T> Join(Mono.CodeContracts.Static.Lattices.FlatDomain<T> that) { return default(Mono.CodeContracts.Static.Lattices.FlatDomain<T>); }
    public Mono.CodeContracts.Static.Lattices.FlatDomain<T> Join(Mono.CodeContracts.Static.Lattices.FlatDomain<T> that, bool widening, out bool weaker) { weaker = default(bool); return default(Mono.CodeContracts.Static.Lattices.FlatDomain<T>); }
    public bool LessEqual(Mono.CodeContracts.Static.Lattices.FlatDomain<T> that) { return default(bool); }
    public Mono.CodeContracts.Static.Lattices.FlatDomain<T> Meet(Mono.CodeContracts.Static.Lattices.FlatDomain<T> that) { return default(Mono.CodeContracts.Static.Lattices.FlatDomain<T>); }
    public static implicit operator Mono.CodeContracts.Static.Lattices.FlatDomain<T> (T value) { return default(Mono.CodeContracts.Static.Lattices.FlatDomain<T>); }
    public override string ToString() { return default(string); }
    public Mono.CodeContracts.Static.Lattices.FlatDomain<T> Widen(Mono.CodeContracts.Static.Lattices.FlatDomain<T> that) { return default(Mono.CodeContracts.Static.Lattices.FlatDomain<T>); }
  }
  public partial interface IAbstractDomain<T> {
    T Bottom { get; }
    bool IsBottom { get; }
    bool IsTop { get; }
    T Top { get; }
    T Clone();
    void Dump(System.IO.TextWriter tw);
    T ImmutableVersion();
    T Join(T that);
    T Join(T that, bool widen, out bool weaker);
    bool LessEqual(T that);
    T Meet(T that);
    T Widen(T that);
  }
}
