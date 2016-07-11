namespace Mono.Simd {
  [System.AttributeUsageAttribute((System.AttributeTargets)(224), Inherited=false)]
  public sealed partial class AccelerationAttribute : System.Attribute {
    public AccelerationAttribute(Mono.Simd.AccelMode mode) { }
    public Mono.Simd.AccelMode Mode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Mono.Simd.AccelMode); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  [System.FlagsAttribute]
  public enum AccelMode {
    None = 0,
    SSE1 = 1,
    SSE2 = 2,
    SSE3 = 4,
    SSE41 = 16,
    SSE42 = 32,
    SSE4A = 64,
    SSSE3 = 8,
  }
  public static partial class ArrayExtensions {
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector16b GetVector(this System.Byte[] array, int offset) { return default(Mono.Simd.Vector16b); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector2d GetVector(this System.Double[] array, int offset) { return default(Mono.Simd.Vector2d); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector8s GetVector(this System.Int16[] array, int offset) { return default(Mono.Simd.Vector8s); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector4i GetVector(this System.Int32[] array, int offset) { return default(Mono.Simd.Vector4i); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector2l GetVector(this System.Int64[] array, int offset) { return default(Mono.Simd.Vector2l); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector16sb GetVector(this System.SByte[] array, int offset) { return default(Mono.Simd.Vector16sb); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector4f GetVector(this System.Single[] array, int offset) { return default(Mono.Simd.Vector4f); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector8us GetVector(this System.UInt16[] array, int offset) { return default(Mono.Simd.Vector8us); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector4ui GetVector(this System.UInt32[] array, int offset) { return default(Mono.Simd.Vector4ui); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector2ul GetVector(this System.UInt64[] array, int offset) { return default(Mono.Simd.Vector2ul); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector16b GetVectorAligned(this System.Byte[] array, int offset) { return default(Mono.Simd.Vector16b); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector2d GetVectorAligned(this System.Double[] array, int offset) { return default(Mono.Simd.Vector2d); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector8s GetVectorAligned(this System.Int16[] array, int offset) { return default(Mono.Simd.Vector8s); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector4i GetVectorAligned(this System.Int32[] array, int offset) { return default(Mono.Simd.Vector4i); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector2l GetVectorAligned(this System.Int64[] array, int offset) { return default(Mono.Simd.Vector2l); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector16sb GetVectorAligned(this System.SByte[] array, int offset) { return default(Mono.Simd.Vector16sb); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector4f GetVectorAligned(this System.Single[] array, int offset) { return default(Mono.Simd.Vector4f); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector8us GetVectorAligned(this System.UInt16[] array, int offset) { return default(Mono.Simd.Vector8us); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector4ui GetVectorAligned(this System.UInt32[] array, int offset) { return default(Mono.Simd.Vector4ui); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector2ul GetVectorAligned(this System.UInt64[] array, int offset) { return default(Mono.Simd.Vector2ul); }
    public static bool IsAligned<T>(this T[] vect, int index) where T : struct { return default(bool); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void SetVector(this System.Byte[] array, Mono.Simd.Vector16b val, int offset) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void SetVector(this System.Double[] array, Mono.Simd.Vector2d val, int offset) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void SetVector(this System.Int16[] array, Mono.Simd.Vector8s val, int offset) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void SetVector(this System.Int32[] array, Mono.Simd.Vector4i val, int offset) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void SetVector(this System.Int64[] array, Mono.Simd.Vector2l val, int offset) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void SetVector(this System.SByte[] array, Mono.Simd.Vector16sb val, int offset) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void SetVector(this System.Single[] array, Mono.Simd.Vector4f val, int offset) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void SetVector(this System.UInt16[] array, Mono.Simd.Vector8us val, int offset) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void SetVector(this System.UInt32[] array, Mono.Simd.Vector4ui val, int offset) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void SetVector(this System.UInt64[] array, Mono.Simd.Vector2ul val, int offset) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void SetVectorAligned(this System.Byte[] array, Mono.Simd.Vector16b val, int offset) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void SetVectorAligned(this System.Double[] array, Mono.Simd.Vector2d val, int offset) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void SetVectorAligned(this System.Int16[] array, Mono.Simd.Vector8s val, int offset) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void SetVectorAligned(this System.Int32[] array, Mono.Simd.Vector4i val, int offset) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void SetVectorAligned(this System.Int64[] array, Mono.Simd.Vector2l val, int offset) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void SetVectorAligned(this System.SByte[] array, Mono.Simd.Vector16sb val, int offset) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void SetVectorAligned(this System.Single[] array, Mono.Simd.Vector4f val, int offset) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void SetVectorAligned(this System.UInt16[] array, Mono.Simd.Vector8us val, int offset) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void SetVectorAligned(this System.UInt32[] array, Mono.Simd.Vector4ui val, int offset) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void SetVectorAligned(this System.UInt64[] array, Mono.Simd.Vector2ul val, int offset) { }
  }
  public enum ShuffleSel {
    ExpandInterleavedXY = 68,
    ExpandInterleavedZW = 238,
    ExpandW = 255,
    ExpandX = 0,
    ExpandXY = 80,
    ExpandY = 85,
    ExpandZ = 170,
    ExpandZW = 250,
    RotateLeft = 147,
    RotateRight = 57,
    Swap = 27,
    WFromW = 192,
    WFromX = 0,
    WFromY = 64,
    WFromZ = 128,
    XFromW = 3,
    XFromX = 0,
    XFromY = 1,
    XFromZ = 2,
    YFromW = 12,
    YFromX = 0,
    YFromY = 4,
    YFromZ = 8,
    ZFromW = 48,
    ZFromX = 0,
    ZFromY = 16,
    ZFromZ = 32,
  }
  public static partial class SimdRuntime {
    public static Mono.Simd.AccelMode AccelMode { get { return default(Mono.Simd.AccelMode); } }
    public static bool IsMethodAccelerated(System.Type type, string method) { return default(bool); }
    public static bool IsMethodAccelerated(System.Type type, string method, params System.Type[] signature) { return default(bool); }
    public static Mono.Simd.AccelMode MethodAccelerationMode(System.Reflection.MethodInfo method) { return default(Mono.Simd.AccelMode); }
    public static Mono.Simd.AccelMode MethodAccelerationMode(System.Type type, string method) { return default(Mono.Simd.AccelMode); }
    public static Mono.Simd.AccelMode MethodAccelerationMode(System.Type type, string method, params System.Type[] signature) { return default(Mono.Simd.AccelMode); }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit, Size=16)]
  public partial struct Vector16b {
    public Vector16b(byte b) { throw new System.NotImplementedException(); }
    public Vector16b(byte v0, byte v1, byte v2, byte v3, byte v4, byte v5, byte v6, byte v7, byte v8, byte v9, byte v10, byte v11, byte v12, byte v13, byte v14, byte v15) { throw new System.NotImplementedException(); }
    [System.Runtime.CompilerServices.IndexerName("Component")]
    public byte this[int index] { get { return default(byte); } set { } }
    public static Mono.Simd.Vector16b One { get { return default(Mono.Simd.Vector16b); } }
    public byte V0 { get { return default(byte); } set { } }
    public byte V1 { get { return default(byte); } set { } }
    public byte V10 { get { return default(byte); } set { } }
    public byte V11 { get { return default(byte); } set { } }
    public byte V12 { get { return default(byte); } set { } }
    public byte V13 { get { return default(byte); } set { } }
    public byte V14 { get { return default(byte); } set { } }
    public byte V15 { get { return default(byte); } set { } }
    public byte V2 { get { return default(byte); } set { } }
    public byte V3 { get { return default(byte); } set { } }
    public byte V4 { get { return default(byte); } set { } }
    public byte V5 { get { return default(byte); } set { } }
    public byte V6 { get { return default(byte); } set { } }
    public byte V7 { get { return default(byte); } set { } }
    public byte V8 { get { return default(byte); } set { } }
    public byte V9 { get { return default(byte); } set { } }
    public static Mono.Simd.Vector16b Zero { get { return default(Mono.Simd.Vector16b); } }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public unsafe static Mono.Simd.Vector16b LoadAligned(Mono.Simd.Vector16b* v) { return default(Mono.Simd.Vector16b); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static Mono.Simd.Vector16b LoadAligned(ref Mono.Simd.Vector16b v) { return default(Mono.Simd.Vector16b); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector16b operator +(Mono.Simd.Vector16b va, Mono.Simd.Vector16b vb) { return default(Mono.Simd.Vector16b); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector16b operator &(Mono.Simd.Vector16b va, Mono.Simd.Vector16b vb) { return default(Mono.Simd.Vector16b); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector16b operator |(Mono.Simd.Vector16b va, Mono.Simd.Vector16b vb) { return default(Mono.Simd.Vector16b); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static bool operator ==(Mono.Simd.Vector16b va, Mono.Simd.Vector16b vb) { return default(bool); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector16b operator ^(Mono.Simd.Vector16b va, Mono.Simd.Vector16b vb) { return default(Mono.Simd.Vector16b); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static explicit operator Mono.Simd.Vector16sb (Mono.Simd.Vector16b v) { return default(Mono.Simd.Vector16sb); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector2d (Mono.Simd.Vector16b v) { return default(Mono.Simd.Vector2d); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector2l (Mono.Simd.Vector16b v) { return default(Mono.Simd.Vector2l); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static explicit operator Mono.Simd.Vector2ul (Mono.Simd.Vector16b v) { return default(Mono.Simd.Vector2ul); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector4f (Mono.Simd.Vector16b v) { return default(Mono.Simd.Vector4f); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector4i (Mono.Simd.Vector16b v) { return default(Mono.Simd.Vector4i); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static explicit operator Mono.Simd.Vector4ui (Mono.Simd.Vector16b v) { return default(Mono.Simd.Vector4ui); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector8s (Mono.Simd.Vector16b v) { return default(Mono.Simd.Vector8s); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static explicit operator Mono.Simd.Vector8us (Mono.Simd.Vector16b v) { return default(Mono.Simd.Vector8us); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static bool operator !=(Mono.Simd.Vector16b va, Mono.Simd.Vector16b vb) { return default(bool); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector16b operator -(Mono.Simd.Vector16b va, Mono.Simd.Vector16b vb) { return default(Mono.Simd.Vector16b); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public unsafe static void PrefetchNonTemporal(Mono.Simd.Vector16b* res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void PrefetchNonTemporal(ref Mono.Simd.Vector16b res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public unsafe static void PrefetchTemporal1stLevelCache(Mono.Simd.Vector16b* res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void PrefetchTemporal1stLevelCache(ref Mono.Simd.Vector16b res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public unsafe static void PrefetchTemporal2ndLevelCache(Mono.Simd.Vector16b* res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void PrefetchTemporal2ndLevelCache(ref Mono.Simd.Vector16b res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public unsafe static void PrefetchTemporalAllCacheLevels(Mono.Simd.Vector16b* res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void PrefetchTemporalAllCacheLevels(ref Mono.Simd.Vector16b res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public unsafe static void StoreAligned(Mono.Simd.Vector16b* res, Mono.Simd.Vector16b val) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static void StoreAligned(ref Mono.Simd.Vector16b res, Mono.Simd.Vector16b val) { }
    public override string ToString() { return default(string); }
  }
  [System.CLSCompliantAttribute(false)]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit, Size=16)]
  public partial struct Vector16sb {
    public Vector16sb(sbyte sb) { throw new System.NotImplementedException(); }
    public Vector16sb(sbyte v0, sbyte v1, sbyte v2, sbyte v3, sbyte v4, sbyte v5, sbyte v6, sbyte v7, sbyte v8, sbyte v9, sbyte v10, sbyte v11, sbyte v12, sbyte v13, sbyte v14, sbyte v15) { throw new System.NotImplementedException(); }
    [System.Runtime.CompilerServices.IndexerName("Component")]
    public sbyte this[int index] { get { return default(sbyte); } set { } }
    public static Mono.Simd.Vector16sb MinusOne { get { return default(Mono.Simd.Vector16sb); } }
    public static Mono.Simd.Vector16sb One { get { return default(Mono.Simd.Vector16sb); } }
    public sbyte V0 { get { return default(sbyte); } set { } }
    public sbyte V1 { get { return default(sbyte); } set { } }
    public sbyte V10 { get { return default(sbyte); } set { } }
    public sbyte V11 { get { return default(sbyte); } set { } }
    public sbyte V12 { get { return default(sbyte); } set { } }
    public sbyte V13 { get { return default(sbyte); } set { } }
    public sbyte V14 { get { return default(sbyte); } set { } }
    public sbyte V15 { get { return default(sbyte); } set { } }
    public sbyte V2 { get { return default(sbyte); } set { } }
    public sbyte V3 { get { return default(sbyte); } set { } }
    public sbyte V4 { get { return default(sbyte); } set { } }
    public sbyte V5 { get { return default(sbyte); } set { } }
    public sbyte V6 { get { return default(sbyte); } set { } }
    public sbyte V7 { get { return default(sbyte); } set { } }
    public sbyte V8 { get { return default(sbyte); } set { } }
    public sbyte V9 { get { return default(sbyte); } set { } }
    public static Mono.Simd.Vector16sb Zero { get { return default(Mono.Simd.Vector16sb); } }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public unsafe static Mono.Simd.Vector16sb LoadAligned(Mono.Simd.Vector16sb* v) { return default(Mono.Simd.Vector16sb); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static Mono.Simd.Vector16sb LoadAligned(ref Mono.Simd.Vector16sb v) { return default(Mono.Simd.Vector16sb); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector16sb operator +(Mono.Simd.Vector16sb va, Mono.Simd.Vector16sb vb) { return default(Mono.Simd.Vector16sb); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector16sb operator &(Mono.Simd.Vector16sb va, Mono.Simd.Vector16sb vb) { return default(Mono.Simd.Vector16sb); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector16sb operator |(Mono.Simd.Vector16sb va, Mono.Simd.Vector16sb vb) { return default(Mono.Simd.Vector16sb); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static bool operator ==(Mono.Simd.Vector16sb va, Mono.Simd.Vector16sb vb) { return default(bool); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector16sb operator ^(Mono.Simd.Vector16sb va, Mono.Simd.Vector16sb vb) { return default(Mono.Simd.Vector16sb); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector16b (Mono.Simd.Vector16sb v) { return default(Mono.Simd.Vector16b); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector2d (Mono.Simd.Vector16sb v) { return default(Mono.Simd.Vector2d); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector2l (Mono.Simd.Vector16sb v) { return default(Mono.Simd.Vector2l); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector2ul (Mono.Simd.Vector16sb v) { return default(Mono.Simd.Vector2ul); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector4f (Mono.Simd.Vector16sb v) { return default(Mono.Simd.Vector4f); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector4i (Mono.Simd.Vector16sb v) { return default(Mono.Simd.Vector4i); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector4ui (Mono.Simd.Vector16sb v) { return default(Mono.Simd.Vector4ui); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector8s (Mono.Simd.Vector16sb v) { return default(Mono.Simd.Vector8s); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector8us (Mono.Simd.Vector16sb v) { return default(Mono.Simd.Vector8us); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static bool operator !=(Mono.Simd.Vector16sb va, Mono.Simd.Vector16sb vb) { return default(bool); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector16sb operator -(Mono.Simd.Vector16sb va, Mono.Simd.Vector16sb vb) { return default(Mono.Simd.Vector16sb); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public unsafe static void PrefetchNonTemporal(Mono.Simd.Vector16sb* res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void PrefetchNonTemporal(ref Mono.Simd.Vector16sb res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public unsafe static void PrefetchTemporal1stLevelCache(Mono.Simd.Vector16sb* res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void PrefetchTemporal1stLevelCache(ref Mono.Simd.Vector16sb res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public unsafe static void PrefetchTemporal2ndLevelCache(Mono.Simd.Vector16sb* res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void PrefetchTemporal2ndLevelCache(ref Mono.Simd.Vector16sb res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public unsafe static void PrefetchTemporalAllCacheLevels(Mono.Simd.Vector16sb* res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void PrefetchTemporalAllCacheLevels(ref Mono.Simd.Vector16sb res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public unsafe static void StoreAligned(Mono.Simd.Vector16sb* res, Mono.Simd.Vector16sb val) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static void StoreAligned(ref Mono.Simd.Vector16sb res, Mono.Simd.Vector16sb val) { }
    public override string ToString() { return default(string); }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit, Size=16)]
  public partial struct Vector2d {
    public Vector2d(double d) { throw new System.NotImplementedException(); }
    public Vector2d(double x, double y) { throw new System.NotImplementedException(); }
    [System.Runtime.CompilerServices.IndexerName("Component")]
    public double this[int index] { get { return default(double); } set { } }
    public static Mono.Simd.Vector2d E { get { return default(Mono.Simd.Vector2d); } }
    public static Mono.Simd.Vector2d MinusOne { get { return default(Mono.Simd.Vector2d); } }
    public static Mono.Simd.Vector2d One { get { return default(Mono.Simd.Vector2d); } }
    public static Mono.Simd.Vector2d Pi { get { return default(Mono.Simd.Vector2d); } }
    public double X { get { return default(double); } set { } }
    public double Y { get { return default(double); } set { } }
    public static Mono.Simd.Vector2d Zero { get { return default(Mono.Simd.Vector2d); } }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public unsafe static Mono.Simd.Vector2d LoadAligned(Mono.Simd.Vector2d* v) { return default(Mono.Simd.Vector2d); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static Mono.Simd.Vector2d LoadAligned(ref Mono.Simd.Vector2d v) { return default(Mono.Simd.Vector2d); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector2d operator +(Mono.Simd.Vector2d v1, Mono.Simd.Vector2d v2) { return default(Mono.Simd.Vector2d); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector2d operator &(Mono.Simd.Vector2d v1, Mono.Simd.Vector2d v2) { return default(Mono.Simd.Vector2d); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector2d operator |(Mono.Simd.Vector2d v1, Mono.Simd.Vector2d v2) { return default(Mono.Simd.Vector2d); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector2d operator /(Mono.Simd.Vector2d v1, Mono.Simd.Vector2d v2) { return default(Mono.Simd.Vector2d); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector2d operator ^(Mono.Simd.Vector2d v1, Mono.Simd.Vector2d v2) { return default(Mono.Simd.Vector2d); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector16b (Mono.Simd.Vector2d v) { return default(Mono.Simd.Vector16b); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static explicit operator Mono.Simd.Vector16sb (Mono.Simd.Vector2d v) { return default(Mono.Simd.Vector16sb); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector2l (Mono.Simd.Vector2d v) { return default(Mono.Simd.Vector2l); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static explicit operator Mono.Simd.Vector2ul (Mono.Simd.Vector2d v) { return default(Mono.Simd.Vector2ul); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector4f (Mono.Simd.Vector2d v) { return default(Mono.Simd.Vector4f); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector4i (Mono.Simd.Vector2d v) { return default(Mono.Simd.Vector4i); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static explicit operator Mono.Simd.Vector4ui (Mono.Simd.Vector2d v) { return default(Mono.Simd.Vector4ui); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector8s (Mono.Simd.Vector2d v) { return default(Mono.Simd.Vector8s); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static explicit operator Mono.Simd.Vector8us (Mono.Simd.Vector2d v) { return default(Mono.Simd.Vector8us); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector2d operator *(Mono.Simd.Vector2d v1, Mono.Simd.Vector2d v2) { return default(Mono.Simd.Vector2d); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector2d operator -(Mono.Simd.Vector2d v1, Mono.Simd.Vector2d v2) { return default(Mono.Simd.Vector2d); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public unsafe static void PrefetchNonTemporal(Mono.Simd.Vector2d* res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void PrefetchNonTemporal(ref Mono.Simd.Vector2d res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public unsafe static void PrefetchTemporal1stLevelCache(Mono.Simd.Vector2d* res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void PrefetchTemporal1stLevelCache(ref Mono.Simd.Vector2d res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public unsafe static void PrefetchTemporal2ndLevelCache(Mono.Simd.Vector2d* res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void PrefetchTemporal2ndLevelCache(ref Mono.Simd.Vector2d res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public unsafe static void PrefetchTemporalAllCacheLevels(Mono.Simd.Vector2d* res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void PrefetchTemporalAllCacheLevels(ref Mono.Simd.Vector2d res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public unsafe static void StoreAligned(Mono.Simd.Vector2d* res, Mono.Simd.Vector2d val) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static void StoreAligned(ref Mono.Simd.Vector2d res, Mono.Simd.Vector2d val) { }
    public override string ToString() { return default(string); }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit, Size=16)]
  public partial struct Vector2l {
    public Vector2l(long l) { throw new System.NotImplementedException(); }
    public Vector2l(long x, long y) { throw new System.NotImplementedException(); }
    [System.Runtime.CompilerServices.IndexerName("Component")]
    public long this[int index] { get { return default(long); } set { } }
    public static Mono.Simd.Vector2l MinusOne { get { return default(Mono.Simd.Vector2l); } }
    public static Mono.Simd.Vector2l One { get { return default(Mono.Simd.Vector2l); } }
    public long X { get { return default(long); } set { } }
    public long Y { get { return default(long); } set { } }
    public static Mono.Simd.Vector2l Zero { get { return default(Mono.Simd.Vector2l); } }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public unsafe static Mono.Simd.Vector2l LoadAligned(Mono.Simd.Vector2l* v) { return default(Mono.Simd.Vector2l); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static Mono.Simd.Vector2l LoadAligned(ref Mono.Simd.Vector2l v) { return default(Mono.Simd.Vector2l); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector2l operator +(Mono.Simd.Vector2l v1, Mono.Simd.Vector2l v2) { return default(Mono.Simd.Vector2l); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector2l operator &(Mono.Simd.Vector2l v1, Mono.Simd.Vector2l v2) { return default(Mono.Simd.Vector2l); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector2l operator |(Mono.Simd.Vector2l v1, Mono.Simd.Vector2l v2) { return default(Mono.Simd.Vector2l); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector2l operator ^(Mono.Simd.Vector2l v1, Mono.Simd.Vector2l v2) { return default(Mono.Simd.Vector2l); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector16b (Mono.Simd.Vector2l v) { return default(Mono.Simd.Vector16b); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static explicit operator Mono.Simd.Vector16sb (Mono.Simd.Vector2l v) { return default(Mono.Simd.Vector16sb); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector2d (Mono.Simd.Vector2l v) { return default(Mono.Simd.Vector2d); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static explicit operator Mono.Simd.Vector2ul (Mono.Simd.Vector2l v) { return default(Mono.Simd.Vector2ul); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector4f (Mono.Simd.Vector2l v) { return default(Mono.Simd.Vector4f); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector4i (Mono.Simd.Vector2l v) { return default(Mono.Simd.Vector4i); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static explicit operator Mono.Simd.Vector4ui (Mono.Simd.Vector2l v) { return default(Mono.Simd.Vector4ui); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector8s (Mono.Simd.Vector2l v) { return default(Mono.Simd.Vector8s); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static explicit operator Mono.Simd.Vector8us (Mono.Simd.Vector2l v) { return default(Mono.Simd.Vector8us); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector2l operator <<(Mono.Simd.Vector2l v1, int amount) { return default(Mono.Simd.Vector2l); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector2l operator -(Mono.Simd.Vector2l v1, Mono.Simd.Vector2l v2) { return default(Mono.Simd.Vector2l); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public unsafe static void PrefetchNonTemporal(Mono.Simd.Vector2l* res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void PrefetchNonTemporal(ref Mono.Simd.Vector2l res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public unsafe static void PrefetchTemporal1stLevelCache(Mono.Simd.Vector2l* res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void PrefetchTemporal1stLevelCache(ref Mono.Simd.Vector2l res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public unsafe static void PrefetchTemporal2ndLevelCache(Mono.Simd.Vector2l* res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void PrefetchTemporal2ndLevelCache(ref Mono.Simd.Vector2l res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public unsafe static void PrefetchTemporalAllCacheLevels(Mono.Simd.Vector2l* res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void PrefetchTemporalAllCacheLevels(ref Mono.Simd.Vector2l res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public unsafe static void StoreAligned(Mono.Simd.Vector2l* res, Mono.Simd.Vector2l val) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static void StoreAligned(ref Mono.Simd.Vector2l res, Mono.Simd.Vector2l val) { }
    public override string ToString() { return default(string); }
  }
  [System.CLSCompliantAttribute(false)]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit, Size=16)]
  public partial struct Vector2ul {
    public Vector2ul(ulong ul) { throw new System.NotImplementedException(); }
    public Vector2ul(ulong x, ulong y) { throw new System.NotImplementedException(); }
    [System.Runtime.CompilerServices.IndexerName("Component")]
    public ulong this[int index] { get { return default(ulong); } set { } }
    public static Mono.Simd.Vector2ul One { get { return default(Mono.Simd.Vector2ul); } }
    public ulong X { get { return default(ulong); } set { } }
    public ulong Y { get { return default(ulong); } set { } }
    public static Mono.Simd.Vector2ul Zero { get { return default(Mono.Simd.Vector2ul); } }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public unsafe static Mono.Simd.Vector2ul LoadAligned(Mono.Simd.Vector2ul* v) { return default(Mono.Simd.Vector2ul); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static Mono.Simd.Vector2ul LoadAligned(ref Mono.Simd.Vector2ul v) { return default(Mono.Simd.Vector2ul); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector2ul operator +(Mono.Simd.Vector2ul v1, Mono.Simd.Vector2ul v2) { return default(Mono.Simd.Vector2ul); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector2ul operator &(Mono.Simd.Vector2ul v1, Mono.Simd.Vector2ul v2) { return default(Mono.Simd.Vector2ul); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector2ul operator |(Mono.Simd.Vector2ul v1, Mono.Simd.Vector2ul v2) { return default(Mono.Simd.Vector2ul); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector2ul operator ^(Mono.Simd.Vector2ul v1, Mono.Simd.Vector2ul v2) { return default(Mono.Simd.Vector2ul); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector16b (Mono.Simd.Vector2ul v) { return default(Mono.Simd.Vector16b); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector16sb (Mono.Simd.Vector2ul v) { return default(Mono.Simd.Vector16sb); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector2d (Mono.Simd.Vector2ul v) { return default(Mono.Simd.Vector2d); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector2l (Mono.Simd.Vector2ul v) { return default(Mono.Simd.Vector2l); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector4f (Mono.Simd.Vector2ul v) { return default(Mono.Simd.Vector4f); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector4i (Mono.Simd.Vector2ul v) { return default(Mono.Simd.Vector4i); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector4ui (Mono.Simd.Vector2ul v) { return default(Mono.Simd.Vector4ui); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector8s (Mono.Simd.Vector2ul v) { return default(Mono.Simd.Vector8s); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector8us (Mono.Simd.Vector2ul v) { return default(Mono.Simd.Vector8us); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector2ul operator <<(Mono.Simd.Vector2ul v1, int amount) { return default(Mono.Simd.Vector2ul); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector2ul operator >>(Mono.Simd.Vector2ul v1, int amount) { return default(Mono.Simd.Vector2ul); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector2ul operator -(Mono.Simd.Vector2ul v1, Mono.Simd.Vector2ul v2) { return default(Mono.Simd.Vector2ul); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public unsafe static void PrefetchNonTemporal(Mono.Simd.Vector2ul* res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void PrefetchNonTemporal(ref Mono.Simd.Vector2ul res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public unsafe static void PrefetchTemporal1stLevelCache(Mono.Simd.Vector2ul* res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void PrefetchTemporal1stLevelCache(ref Mono.Simd.Vector2ul res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public unsafe static void PrefetchTemporal2ndLevelCache(Mono.Simd.Vector2ul* res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void PrefetchTemporal2ndLevelCache(ref Mono.Simd.Vector2ul res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public unsafe static void PrefetchTemporalAllCacheLevels(Mono.Simd.Vector2ul* res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void PrefetchTemporalAllCacheLevels(ref Mono.Simd.Vector2ul res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public unsafe static void StoreAligned(Mono.Simd.Vector2ul* res, Mono.Simd.Vector2ul val) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static void StoreAligned(ref Mono.Simd.Vector2ul res, Mono.Simd.Vector2ul val) { }
    public override string ToString() { return default(string); }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit, Size=16)]
  public partial struct Vector4f {
    public Vector4f(float f) { throw new System.NotImplementedException(); }
    public Vector4f(float x, float y, float z, float w) { throw new System.NotImplementedException(); }
    [System.Runtime.CompilerServices.IndexerName("Component")]
    public float this[int index] { get { return default(float); } set { } }
    public static Mono.Simd.Vector4f E { get { return default(Mono.Simd.Vector4f); } }
    public static Mono.Simd.Vector4f MinusOne { get { return default(Mono.Simd.Vector4f); } }
    public static Mono.Simd.Vector4f One { get { return default(Mono.Simd.Vector4f); } }
    public static Mono.Simd.Vector4f Pi { get { return default(Mono.Simd.Vector4f); } }
    public float W { get { return default(float); } set { } }
    public float X { get { return default(float); } set { } }
    public float Y { get { return default(float); } set { } }
    public float Z { get { return default(float); } set { } }
    public static Mono.Simd.Vector4f Zero { get { return default(Mono.Simd.Vector4f); } }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public unsafe static Mono.Simd.Vector4f LoadAligned(Mono.Simd.Vector4f* v) { return default(Mono.Simd.Vector4f); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static Mono.Simd.Vector4f LoadAligned(ref Mono.Simd.Vector4f v) { return default(Mono.Simd.Vector4f); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static Mono.Simd.Vector4f operator +(Mono.Simd.Vector4f v1, Mono.Simd.Vector4f v2) { return default(Mono.Simd.Vector4f); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static Mono.Simd.Vector4f operator &(Mono.Simd.Vector4f v1, Mono.Simd.Vector4f v2) { return default(Mono.Simd.Vector4f); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static Mono.Simd.Vector4f operator |(Mono.Simd.Vector4f v1, Mono.Simd.Vector4f v2) { return default(Mono.Simd.Vector4f); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static Mono.Simd.Vector4f operator /(Mono.Simd.Vector4f v1, Mono.Simd.Vector4f v2) { return default(Mono.Simd.Vector4f); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static bool operator ==(Mono.Simd.Vector4f v1, Mono.Simd.Vector4f v2) { return default(bool); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static Mono.Simd.Vector4f operator ^(Mono.Simd.Vector4f v1, Mono.Simd.Vector4f v2) { return default(Mono.Simd.Vector4f); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector16b (Mono.Simd.Vector4f v) { return default(Mono.Simd.Vector16b); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static explicit operator Mono.Simd.Vector16sb (Mono.Simd.Vector4f v) { return default(Mono.Simd.Vector16sb); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector2d (Mono.Simd.Vector4f v) { return default(Mono.Simd.Vector2d); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector2l (Mono.Simd.Vector4f v) { return default(Mono.Simd.Vector2l); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static explicit operator Mono.Simd.Vector2ul (Mono.Simd.Vector4f v) { return default(Mono.Simd.Vector2ul); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector4i (Mono.Simd.Vector4f v) { return default(Mono.Simd.Vector4i); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static explicit operator Mono.Simd.Vector4ui (Mono.Simd.Vector4f v) { return default(Mono.Simd.Vector4ui); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector8s (Mono.Simd.Vector4f v) { return default(Mono.Simd.Vector8s); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static explicit operator Mono.Simd.Vector8us (Mono.Simd.Vector4f v) { return default(Mono.Simd.Vector8us); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static bool operator !=(Mono.Simd.Vector4f v1, Mono.Simd.Vector4f v2) { return default(bool); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static Mono.Simd.Vector4f operator *(Mono.Simd.Vector4f v1, Mono.Simd.Vector4f v2) { return default(Mono.Simd.Vector4f); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static Mono.Simd.Vector4f operator *(Mono.Simd.Vector4f v, float scalar) { return default(Mono.Simd.Vector4f); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static Mono.Simd.Vector4f operator *(float scalar, Mono.Simd.Vector4f v) { return default(Mono.Simd.Vector4f); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static Mono.Simd.Vector4f operator -(Mono.Simd.Vector4f v1, Mono.Simd.Vector4f v2) { return default(Mono.Simd.Vector4f); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public unsafe static void PrefetchNonTemporal(Mono.Simd.Vector4f* res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void PrefetchNonTemporal(ref Mono.Simd.Vector4f res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public unsafe static void PrefetchTemporal1stLevelCache(Mono.Simd.Vector4f* res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void PrefetchTemporal1stLevelCache(ref Mono.Simd.Vector4f res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public unsafe static void PrefetchTemporal2ndLevelCache(Mono.Simd.Vector4f* res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void PrefetchTemporal2ndLevelCache(ref Mono.Simd.Vector4f res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public unsafe static void PrefetchTemporalAllCacheLevels(Mono.Simd.Vector4f* res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void PrefetchTemporalAllCacheLevels(ref Mono.Simd.Vector4f res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public unsafe static void StoreAligned(Mono.Simd.Vector4f* res, Mono.Simd.Vector4f val) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static void StoreAligned(ref Mono.Simd.Vector4f res, Mono.Simd.Vector4f val) { }
    public override string ToString() { return default(string); }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit, Size=16)]
  public partial struct Vector4i {
    public Vector4i(int i) { throw new System.NotImplementedException(); }
    public Vector4i(int x, int y, int z, int w) { throw new System.NotImplementedException(); }
    [System.Runtime.CompilerServices.IndexerName("Component")]
    public int this[int index] { get { return default(int); } set { } }
    public static Mono.Simd.Vector4i Identity { get { return default(Mono.Simd.Vector4i); } }
    public static Mono.Simd.Vector4i MinusOne { get { return default(Mono.Simd.Vector4i); } }
    public int W { get { return default(int); } set { } }
    public int X { get { return default(int); } set { } }
    public int Y { get { return default(int); } set { } }
    public int Z { get { return default(int); } set { } }
    public static Mono.Simd.Vector4i Zero { get { return default(Mono.Simd.Vector4i); } }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public unsafe static Mono.Simd.Vector4i LoadAligned(Mono.Simd.Vector4i* v) { return default(Mono.Simd.Vector4i); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static Mono.Simd.Vector4i LoadAligned(ref Mono.Simd.Vector4i v) { return default(Mono.Simd.Vector4i); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector4i operator +(Mono.Simd.Vector4i v1, Mono.Simd.Vector4i v2) { return default(Mono.Simd.Vector4i); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector4i operator &(Mono.Simd.Vector4i v1, Mono.Simd.Vector4i v2) { return default(Mono.Simd.Vector4i); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector4i operator |(Mono.Simd.Vector4i v1, Mono.Simd.Vector4i v2) { return default(Mono.Simd.Vector4i); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static bool operator ==(Mono.Simd.Vector4i v1, Mono.Simd.Vector4i v2) { return default(bool); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector4i operator ^(Mono.Simd.Vector4i v1, Mono.Simd.Vector4i v2) { return default(Mono.Simd.Vector4i); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector16b (Mono.Simd.Vector4i v) { return default(Mono.Simd.Vector16b); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static explicit operator Mono.Simd.Vector16sb (Mono.Simd.Vector4i v) { return default(Mono.Simd.Vector16sb); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector2d (Mono.Simd.Vector4i v) { return default(Mono.Simd.Vector2d); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector2l (Mono.Simd.Vector4i v) { return default(Mono.Simd.Vector2l); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static explicit operator Mono.Simd.Vector2ul (Mono.Simd.Vector4i v) { return default(Mono.Simd.Vector2ul); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector4f (Mono.Simd.Vector4i v) { return default(Mono.Simd.Vector4f); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static explicit operator Mono.Simd.Vector4ui (Mono.Simd.Vector4i v) { return default(Mono.Simd.Vector4ui); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector8s (Mono.Simd.Vector4i v) { return default(Mono.Simd.Vector8s); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static explicit operator Mono.Simd.Vector8us (Mono.Simd.Vector4i v) { return default(Mono.Simd.Vector8us); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static bool operator !=(Mono.Simd.Vector4i v1, Mono.Simd.Vector4i v2) { return default(bool); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector4i operator <<(Mono.Simd.Vector4i v1, int amount) { return default(Mono.Simd.Vector4i); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(16))]
    public static Mono.Simd.Vector4i operator *(Mono.Simd.Vector4i v1, Mono.Simd.Vector4i v2) { return default(Mono.Simd.Vector4i); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector4i operator >>(Mono.Simd.Vector4i v1, int amount) { return default(Mono.Simd.Vector4i); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector4i operator -(Mono.Simd.Vector4i v1, Mono.Simd.Vector4i v2) { return default(Mono.Simd.Vector4i); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public unsafe static void PrefetchNonTemporal(Mono.Simd.Vector4i* res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void PrefetchNonTemporal(ref Mono.Simd.Vector4i res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public unsafe static void PrefetchTemporal1stLevelCache(Mono.Simd.Vector4i* res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void PrefetchTemporal1stLevelCache(ref Mono.Simd.Vector4i res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public unsafe static void PrefetchTemporal2ndLevelCache(Mono.Simd.Vector4i* res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void PrefetchTemporal2ndLevelCache(ref Mono.Simd.Vector4i res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public unsafe static void PrefetchTemporalAllCacheLevels(Mono.Simd.Vector4i* res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void PrefetchTemporalAllCacheLevels(ref Mono.Simd.Vector4i res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public unsafe static void StoreAligned(Mono.Simd.Vector4i* res, Mono.Simd.Vector4i val) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static void StoreAligned(ref Mono.Simd.Vector4i res, Mono.Simd.Vector4i val) { }
    public override string ToString() { return default(string); }
  }
  [System.CLSCompliantAttribute(false)]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit, Size=16)]
  public partial struct Vector4ui {
    public Vector4ui(uint ui) { throw new System.NotImplementedException(); }
    public Vector4ui(uint x, uint y, uint z, uint w) { throw new System.NotImplementedException(); }
    [System.Runtime.CompilerServices.IndexerName("Component")]
    public uint this[int index] { get { return default(uint); } set { } }
    public static Mono.Simd.Vector4ui Identity { get { return default(Mono.Simd.Vector4ui); } }
    public uint W { get { return default(uint); } set { } }
    public uint X { get { return default(uint); } set { } }
    public uint Y { get { return default(uint); } set { } }
    public uint Z { get { return default(uint); } set { } }
    public static Mono.Simd.Vector4ui Zero { get { return default(Mono.Simd.Vector4ui); } }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public unsafe static Mono.Simd.Vector4ui LoadAligned(Mono.Simd.Vector4ui* v) { return default(Mono.Simd.Vector4ui); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static Mono.Simd.Vector4ui LoadAligned(ref Mono.Simd.Vector4ui v) { return default(Mono.Simd.Vector4ui); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector4ui operator +(Mono.Simd.Vector4ui v1, Mono.Simd.Vector4ui v2) { return default(Mono.Simd.Vector4ui); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector4ui operator &(Mono.Simd.Vector4ui v1, Mono.Simd.Vector4ui v2) { return default(Mono.Simd.Vector4ui); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector4ui operator |(Mono.Simd.Vector4ui v1, Mono.Simd.Vector4ui v2) { return default(Mono.Simd.Vector4ui); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static bool operator ==(Mono.Simd.Vector4ui v1, Mono.Simd.Vector4ui v2) { return default(bool); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector4ui operator ^(Mono.Simd.Vector4ui v1, Mono.Simd.Vector4ui v2) { return default(Mono.Simd.Vector4ui); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector16b (Mono.Simd.Vector4ui v) { return default(Mono.Simd.Vector16b); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector16sb (Mono.Simd.Vector4ui v) { return default(Mono.Simd.Vector16sb); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector2d (Mono.Simd.Vector4ui v) { return default(Mono.Simd.Vector2d); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector2l (Mono.Simd.Vector4ui v) { return default(Mono.Simd.Vector2l); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector2ul (Mono.Simd.Vector4ui v) { return default(Mono.Simd.Vector2ul); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector4f (Mono.Simd.Vector4ui v) { return default(Mono.Simd.Vector4f); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector4i (Mono.Simd.Vector4ui v) { return default(Mono.Simd.Vector4i); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector8s (Mono.Simd.Vector4ui v) { return default(Mono.Simd.Vector8s); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector8us (Mono.Simd.Vector4ui v) { return default(Mono.Simd.Vector8us); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static bool operator !=(Mono.Simd.Vector4ui v1, Mono.Simd.Vector4ui v2) { return default(bool); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector4ui operator <<(Mono.Simd.Vector4ui v1, int amount) { return default(Mono.Simd.Vector4ui); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(16))]
    public static Mono.Simd.Vector4ui operator *(Mono.Simd.Vector4ui v1, Mono.Simd.Vector4ui v2) { return default(Mono.Simd.Vector4ui); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector4ui operator >>(Mono.Simd.Vector4ui v1, int amount) { return default(Mono.Simd.Vector4ui); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector4ui operator -(Mono.Simd.Vector4ui v1, Mono.Simd.Vector4ui v2) { return default(Mono.Simd.Vector4ui); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public unsafe static void PrefetchNonTemporal(Mono.Simd.Vector4ui* res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void PrefetchNonTemporal(ref Mono.Simd.Vector4ui res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public unsafe static void PrefetchTemporal1stLevelCache(Mono.Simd.Vector4ui* res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void PrefetchTemporal1stLevelCache(ref Mono.Simd.Vector4ui res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public unsafe static void PrefetchTemporal2ndLevelCache(Mono.Simd.Vector4ui* res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void PrefetchTemporal2ndLevelCache(ref Mono.Simd.Vector4ui res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public unsafe static void PrefetchTemporalAllCacheLevels(Mono.Simd.Vector4ui* res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void PrefetchTemporalAllCacheLevels(ref Mono.Simd.Vector4ui res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public unsafe static void StoreAligned(Mono.Simd.Vector4ui* res, Mono.Simd.Vector4ui val) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static void StoreAligned(ref Mono.Simd.Vector4ui res, Mono.Simd.Vector4ui val) { }
    public override string ToString() { return default(string); }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit, Size=16)]
  public partial struct Vector8s {
    public Vector8s(short s) { throw new System.NotImplementedException(); }
    public Vector8s(short v0, short v1, short v2, short v3, short v4, short v5, short v6, short v7) { throw new System.NotImplementedException(); }
    [System.Runtime.CompilerServices.IndexerName("Component")]
    public short this[int index] { get { return default(short); } set { } }
    public static Mono.Simd.Vector8s Identity { get { return default(Mono.Simd.Vector8s); } }
    public static Mono.Simd.Vector8s MinusOne { get { return default(Mono.Simd.Vector8s); } }
    public short V0 { get { return default(short); } set { } }
    public short V1 { get { return default(short); } set { } }
    public short V2 { get { return default(short); } set { } }
    public short V3 { get { return default(short); } set { } }
    public short V4 { get { return default(short); } set { } }
    public short V5 { get { return default(short); } set { } }
    public short V6 { get { return default(short); } set { } }
    public short V7 { get { return default(short); } set { } }
    public static Mono.Simd.Vector8s Zero { get { return default(Mono.Simd.Vector8s); } }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public unsafe static Mono.Simd.Vector8s LoadAligned(Mono.Simd.Vector8s* v) { return default(Mono.Simd.Vector8s); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static Mono.Simd.Vector8s LoadAligned(ref Mono.Simd.Vector8s v) { return default(Mono.Simd.Vector8s); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector8s operator +(Mono.Simd.Vector8s va, Mono.Simd.Vector8s vb) { return default(Mono.Simd.Vector8s); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector8s operator &(Mono.Simd.Vector8s va, Mono.Simd.Vector8s vb) { return default(Mono.Simd.Vector8s); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector8s operator |(Mono.Simd.Vector8s va, Mono.Simd.Vector8s vb) { return default(Mono.Simd.Vector8s); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static bool operator ==(Mono.Simd.Vector8s va, Mono.Simd.Vector8s vb) { return default(bool); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector8s operator ^(Mono.Simd.Vector8s va, Mono.Simd.Vector8s vb) { return default(Mono.Simd.Vector8s); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector16b (Mono.Simd.Vector8s v) { return default(Mono.Simd.Vector16b); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static explicit operator Mono.Simd.Vector16sb (Mono.Simd.Vector8s v) { return default(Mono.Simd.Vector16sb); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector2d (Mono.Simd.Vector8s v) { return default(Mono.Simd.Vector2d); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector2l (Mono.Simd.Vector8s v) { return default(Mono.Simd.Vector2l); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static explicit operator Mono.Simd.Vector2ul (Mono.Simd.Vector8s v) { return default(Mono.Simd.Vector2ul); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector4f (Mono.Simd.Vector8s v) { return default(Mono.Simd.Vector4f); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector4i (Mono.Simd.Vector8s v) { return default(Mono.Simd.Vector4i); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static explicit operator Mono.Simd.Vector4ui (Mono.Simd.Vector8s v) { return default(Mono.Simd.Vector4ui); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static explicit operator Mono.Simd.Vector8us (Mono.Simd.Vector8s v) { return default(Mono.Simd.Vector8us); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static bool operator !=(Mono.Simd.Vector8s va, Mono.Simd.Vector8s vb) { return default(bool); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector8s operator <<(Mono.Simd.Vector8s va, int amount) { return default(Mono.Simd.Vector8s); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector8s operator *(Mono.Simd.Vector8s va, Mono.Simd.Vector8s vb) { return default(Mono.Simd.Vector8s); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector8s operator >>(Mono.Simd.Vector8s va, int amount) { return default(Mono.Simd.Vector8s); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector8s operator -(Mono.Simd.Vector8s va, Mono.Simd.Vector8s vb) { return default(Mono.Simd.Vector8s); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public unsafe static void PrefetchNonTemporal(Mono.Simd.Vector8s* res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void PrefetchNonTemporal(ref Mono.Simd.Vector8s res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public unsafe static void PrefetchTemporal1stLevelCache(Mono.Simd.Vector8s* res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void PrefetchTemporal1stLevelCache(ref Mono.Simd.Vector8s res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public unsafe static void PrefetchTemporal2ndLevelCache(Mono.Simd.Vector8s* res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void PrefetchTemporal2ndLevelCache(ref Mono.Simd.Vector8s res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public unsafe static void PrefetchTemporalAllCacheLevels(Mono.Simd.Vector8s* res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void PrefetchTemporalAllCacheLevels(ref Mono.Simd.Vector8s res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public unsafe static void StoreAligned(Mono.Simd.Vector8s* res, Mono.Simd.Vector8s val) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static void StoreAligned(ref Mono.Simd.Vector8s res, Mono.Simd.Vector8s val) { }
    public override string ToString() { return default(string); }
  }
  [System.CLSCompliantAttribute(false)]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit, Size=16)]
  public partial struct Vector8us {
    public Vector8us(ushort us) { throw new System.NotImplementedException(); }
    public Vector8us(ushort v0, ushort v1, ushort v2, ushort v3, ushort v4, ushort v5, ushort v6, ushort v7) { throw new System.NotImplementedException(); }
    [System.Runtime.CompilerServices.IndexerName("Component")]
    public ushort this[int index] { get { return default(ushort); } set { } }
    public static Mono.Simd.Vector8us Identity { get { return default(Mono.Simd.Vector8us); } }
    public ushort V0 { get { return default(ushort); } set { } }
    public ushort V1 { get { return default(ushort); } set { } }
    public ushort V2 { get { return default(ushort); } set { } }
    public ushort V3 { get { return default(ushort); } set { } }
    public ushort V4 { get { return default(ushort); } set { } }
    public ushort V5 { get { return default(ushort); } set { } }
    public ushort V6 { get { return default(ushort); } set { } }
    public ushort V7 { get { return default(ushort); } set { } }
    public static Mono.Simd.Vector8us Zero { get { return default(Mono.Simd.Vector8us); } }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public unsafe static Mono.Simd.Vector8us LoadAligned(Mono.Simd.Vector8us* v) { return default(Mono.Simd.Vector8us); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static Mono.Simd.Vector8us LoadAligned(ref Mono.Simd.Vector8us v) { return default(Mono.Simd.Vector8us); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector8us operator +(Mono.Simd.Vector8us va, Mono.Simd.Vector8us vb) { return default(Mono.Simd.Vector8us); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector8us operator &(Mono.Simd.Vector8us va, Mono.Simd.Vector8us vb) { return default(Mono.Simd.Vector8us); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector8us operator |(Mono.Simd.Vector8us va, Mono.Simd.Vector8us vb) { return default(Mono.Simd.Vector8us); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static bool operator ==(Mono.Simd.Vector8us va, Mono.Simd.Vector8us vb) { return default(bool); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector8us operator ^(Mono.Simd.Vector8us va, Mono.Simd.Vector8us vb) { return default(Mono.Simd.Vector8us); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector16b (Mono.Simd.Vector8us v) { return default(Mono.Simd.Vector16b); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector16sb (Mono.Simd.Vector8us v) { return default(Mono.Simd.Vector16sb); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector2d (Mono.Simd.Vector8us v) { return default(Mono.Simd.Vector2d); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector2l (Mono.Simd.Vector8us v) { return default(Mono.Simd.Vector2l); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector2ul (Mono.Simd.Vector8us v) { return default(Mono.Simd.Vector2ul); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector4f (Mono.Simd.Vector8us v) { return default(Mono.Simd.Vector4f); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector4i (Mono.Simd.Vector8us v) { return default(Mono.Simd.Vector4i); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector4ui (Mono.Simd.Vector8us v) { return default(Mono.Simd.Vector4ui); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static explicit operator Mono.Simd.Vector8s (Mono.Simd.Vector8us v) { return default(Mono.Simd.Vector8s); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static bool operator !=(Mono.Simd.Vector8us va, Mono.Simd.Vector8us vb) { return default(bool); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector8us operator <<(Mono.Simd.Vector8us va, int amount) { return default(Mono.Simd.Vector8us); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector8us operator *(Mono.Simd.Vector8us va, Mono.Simd.Vector8us vb) { return default(Mono.Simd.Vector8us); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector8us operator >>(Mono.Simd.Vector8us va, int amount) { return default(Mono.Simd.Vector8us); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector8us operator -(Mono.Simd.Vector8us va, Mono.Simd.Vector8us vb) { return default(Mono.Simd.Vector8us); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public unsafe static void PrefetchNonTemporal(Mono.Simd.Vector8us* res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void PrefetchNonTemporal(ref Mono.Simd.Vector8us res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public unsafe static void PrefetchTemporal1stLevelCache(Mono.Simd.Vector8us* res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void PrefetchTemporal1stLevelCache(ref Mono.Simd.Vector8us res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public unsafe static void PrefetchTemporal2ndLevelCache(Mono.Simd.Vector8us* res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void PrefetchTemporal2ndLevelCache(ref Mono.Simd.Vector8us res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public unsafe static void PrefetchTemporalAllCacheLevels(Mono.Simd.Vector8us* res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    [System.CLSCompliantAttribute(false)]
    public static void PrefetchTemporalAllCacheLevels(ref Mono.Simd.Vector8us res) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public unsafe static void StoreAligned(Mono.Simd.Vector8us* res, Mono.Simd.Vector8us val) { }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static void StoreAligned(ref Mono.Simd.Vector8us res, Mono.Simd.Vector8us val) { }
    public override string ToString() { return default(string); }
  }
  public static partial class VectorOperations {
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(4))]
    public static Mono.Simd.Vector2d AddSub(this Mono.Simd.Vector2d v1, Mono.Simd.Vector2d v2) { return default(Mono.Simd.Vector2d); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(4))]
    public static Mono.Simd.Vector4f AddSub(this Mono.Simd.Vector4f v1, Mono.Simd.Vector4f v2) { return default(Mono.Simd.Vector4f); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector16b AddWithSaturation(this Mono.Simd.Vector16b va, Mono.Simd.Vector16b vb) { return default(Mono.Simd.Vector16b); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector16sb AddWithSaturation(this Mono.Simd.Vector16sb va, Mono.Simd.Vector16sb vb) { return default(Mono.Simd.Vector16sb); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector8s AddWithSaturation(this Mono.Simd.Vector8s va, Mono.Simd.Vector8s vb) { return default(Mono.Simd.Vector8s); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector8us AddWithSaturation(this Mono.Simd.Vector8us va, Mono.Simd.Vector8us vb) { return default(Mono.Simd.Vector8us); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector2d AndNot(this Mono.Simd.Vector2d v1, Mono.Simd.Vector2d v2) { return default(Mono.Simd.Vector2d); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static Mono.Simd.Vector4f AndNot(this Mono.Simd.Vector4f v1, Mono.Simd.Vector4f v2) { return default(Mono.Simd.Vector4f); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector4ui ArithmeticRightShift(this Mono.Simd.Vector4ui v1, int amount) { return default(Mono.Simd.Vector4ui); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector8us ArithmeticRightShift(this Mono.Simd.Vector8us va, int amount) { return default(Mono.Simd.Vector8us); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector16b Average(this Mono.Simd.Vector16b va, Mono.Simd.Vector16b vb) { return default(Mono.Simd.Vector16b); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector8us Average(this Mono.Simd.Vector8us va, Mono.Simd.Vector8us vb) { return default(Mono.Simd.Vector8us); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector16b CompareEqual(this Mono.Simd.Vector16b va, Mono.Simd.Vector16b vb) { return default(Mono.Simd.Vector16b); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector16sb CompareEqual(this Mono.Simd.Vector16sb va, Mono.Simd.Vector16sb vb) { return default(Mono.Simd.Vector16sb); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector2d CompareEqual(this Mono.Simd.Vector2d v1, Mono.Simd.Vector2d v2) { return default(Mono.Simd.Vector2d); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(16))]
    public static Mono.Simd.Vector2l CompareEqual(this Mono.Simd.Vector2l v1, Mono.Simd.Vector2l v2) { return default(Mono.Simd.Vector2l); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(16))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector2ul CompareEqual(this Mono.Simd.Vector2ul v1, Mono.Simd.Vector2ul v2) { return default(Mono.Simd.Vector2ul); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static Mono.Simd.Vector4f CompareEqual(this Mono.Simd.Vector4f v1, Mono.Simd.Vector4f v2) { return default(Mono.Simd.Vector4f); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector4i CompareEqual(this Mono.Simd.Vector4i v1, Mono.Simd.Vector4i v2) { return default(Mono.Simd.Vector4i); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector4ui CompareEqual(this Mono.Simd.Vector4ui v1, Mono.Simd.Vector4ui v2) { return default(Mono.Simd.Vector4ui); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector8s CompareEqual(this Mono.Simd.Vector8s va, Mono.Simd.Vector8s vb) { return default(Mono.Simd.Vector8s); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector8us CompareEqual(this Mono.Simd.Vector8us va, Mono.Simd.Vector8us vb) { return default(Mono.Simd.Vector8us); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector16sb CompareGreaterThan(this Mono.Simd.Vector16sb va, Mono.Simd.Vector16sb vb) { return default(Mono.Simd.Vector16sb); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(32))]
    public static Mono.Simd.Vector2l CompareGreaterThan(this Mono.Simd.Vector2l v1, Mono.Simd.Vector2l v2) { return default(Mono.Simd.Vector2l); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector4i CompareGreaterThan(this Mono.Simd.Vector4i v1, Mono.Simd.Vector4i v2) { return default(Mono.Simd.Vector4i); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector8s CompareGreaterThan(this Mono.Simd.Vector8s va, Mono.Simd.Vector8s vb) { return default(Mono.Simd.Vector8s); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector2d CompareLessEqual(this Mono.Simd.Vector2d v1, Mono.Simd.Vector2d v2) { return default(Mono.Simd.Vector2d); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static Mono.Simd.Vector4f CompareLessEqual(this Mono.Simd.Vector4f v1, Mono.Simd.Vector4f v2) { return default(Mono.Simd.Vector4f); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector2d CompareLessThan(this Mono.Simd.Vector2d v1, Mono.Simd.Vector2d v2) { return default(Mono.Simd.Vector2d); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static Mono.Simd.Vector4f CompareLessThan(this Mono.Simd.Vector4f v1, Mono.Simd.Vector4f v2) { return default(Mono.Simd.Vector4f); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector2d CompareNotEqual(this Mono.Simd.Vector2d v1, Mono.Simd.Vector2d v2) { return default(Mono.Simd.Vector2d); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static Mono.Simd.Vector4f CompareNotEqual(this Mono.Simd.Vector4f v1, Mono.Simd.Vector4f v2) { return default(Mono.Simd.Vector4f); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector2d CompareNotLessEqual(this Mono.Simd.Vector2d v1, Mono.Simd.Vector2d v2) { return default(Mono.Simd.Vector2d); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static Mono.Simd.Vector4f CompareNotLessEqual(this Mono.Simd.Vector4f v1, Mono.Simd.Vector4f v2) { return default(Mono.Simd.Vector4f); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector2d CompareNotLessThan(this Mono.Simd.Vector2d v1, Mono.Simd.Vector2d v2) { return default(Mono.Simd.Vector2d); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static Mono.Simd.Vector4f CompareNotLessThan(this Mono.Simd.Vector4f v1, Mono.Simd.Vector4f v2) { return default(Mono.Simd.Vector4f); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector2d CompareOrdered(this Mono.Simd.Vector2d v1, Mono.Simd.Vector2d v2) { return default(Mono.Simd.Vector2d); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static Mono.Simd.Vector4f CompareOrdered(this Mono.Simd.Vector4f v1, Mono.Simd.Vector4f v2) { return default(Mono.Simd.Vector4f); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector2d CompareUnordered(this Mono.Simd.Vector2d v1, Mono.Simd.Vector2d v2) { return default(Mono.Simd.Vector2d); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static Mono.Simd.Vector4f CompareUnordered(this Mono.Simd.Vector4f v1, Mono.Simd.Vector4f v2) { return default(Mono.Simd.Vector4f); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector2d ConvertToDouble(this Mono.Simd.Vector4f v0) { return default(Mono.Simd.Vector2d); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector2d ConvertToDouble(this Mono.Simd.Vector4i v0) { return default(Mono.Simd.Vector2d); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector4f ConvertToFloat(this Mono.Simd.Vector2d v0) { return default(Mono.Simd.Vector4f); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector4f ConvertToFloat(this Mono.Simd.Vector4i v0) { return default(Mono.Simd.Vector4f); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector4i ConvertToInt(this Mono.Simd.Vector2d v0) { return default(Mono.Simd.Vector4i); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector4i ConvertToInt(this Mono.Simd.Vector4f v0) { return default(Mono.Simd.Vector4i); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector4i ConvertToIntTruncated(this Mono.Simd.Vector2d v0) { return default(Mono.Simd.Vector4i); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector4i ConvertToIntTruncated(this Mono.Simd.Vector4f v0) { return default(Mono.Simd.Vector4i); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(4))]
    public static Mono.Simd.Vector2d Duplicate(this Mono.Simd.Vector2d v1) { return default(Mono.Simd.Vector2d); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(4))]
    public static Mono.Simd.Vector4f DuplicateHigh(this Mono.Simd.Vector4f v1) { return default(Mono.Simd.Vector4f); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(4))]
    public static Mono.Simd.Vector4f DuplicateLow(this Mono.Simd.Vector4f v1) { return default(Mono.Simd.Vector4f); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static int ExtractByteMask(this Mono.Simd.Vector16b va) { return default(int); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    [System.CLSCompliantAttribute(false)]
    public static int ExtractByteMask(this Mono.Simd.Vector16sb va) { return default(int); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(4))]
    public static Mono.Simd.Vector2d HorizontalAdd(this Mono.Simd.Vector2d v1, Mono.Simd.Vector2d v2) { return default(Mono.Simd.Vector2d); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(4))]
    public static Mono.Simd.Vector4f HorizontalAdd(this Mono.Simd.Vector4f v1, Mono.Simd.Vector4f v2) { return default(Mono.Simd.Vector4f); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(4))]
    public static Mono.Simd.Vector2d HorizontalSub(this Mono.Simd.Vector2d v1, Mono.Simd.Vector2d v2) { return default(Mono.Simd.Vector2d); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(4))]
    public static Mono.Simd.Vector4f HorizontalSub(this Mono.Simd.Vector4f v1, Mono.Simd.Vector4f v2) { return default(Mono.Simd.Vector4f); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector2d InterleaveHigh(this Mono.Simd.Vector2d v1, Mono.Simd.Vector2d v2) { return default(Mono.Simd.Vector2d); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static Mono.Simd.Vector4f InterleaveHigh(this Mono.Simd.Vector4f v1, Mono.Simd.Vector4f v2) { return default(Mono.Simd.Vector4f); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector2d InterleaveLow(this Mono.Simd.Vector2d v1, Mono.Simd.Vector2d v2) { return default(Mono.Simd.Vector2d); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static Mono.Simd.Vector4f InterleaveLow(this Mono.Simd.Vector4f v1, Mono.Simd.Vector4f v2) { return default(Mono.Simd.Vector4f); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static Mono.Simd.Vector4f InvSqrt(this Mono.Simd.Vector4f v1) { return default(Mono.Simd.Vector4f); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector2l LogicalRightShift(this Mono.Simd.Vector2l v1, int amount) { return default(Mono.Simd.Vector2l); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector4i LogicalRightShift(this Mono.Simd.Vector4i v1, int amount) { return default(Mono.Simd.Vector4i); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector8s LogicalRightShift(this Mono.Simd.Vector8s va, int amount) { return default(Mono.Simd.Vector8s); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector16b Max(this Mono.Simd.Vector16b va, Mono.Simd.Vector16b vb) { return default(Mono.Simd.Vector16b); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(16))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector16sb Max(this Mono.Simd.Vector16sb va, Mono.Simd.Vector16sb vb) { return default(Mono.Simd.Vector16sb); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector2d Max(this Mono.Simd.Vector2d v1, Mono.Simd.Vector2d v2) { return default(Mono.Simd.Vector2d); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static Mono.Simd.Vector4f Max(this Mono.Simd.Vector4f v1, Mono.Simd.Vector4f v2) { return default(Mono.Simd.Vector4f); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(16))]
    public static Mono.Simd.Vector4i Max(this Mono.Simd.Vector4i v1, Mono.Simd.Vector4i v2) { return default(Mono.Simd.Vector4i); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(16))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector4ui Max(this Mono.Simd.Vector4ui v1, Mono.Simd.Vector4ui v2) { return default(Mono.Simd.Vector4ui); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector8s Max(this Mono.Simd.Vector8s va, Mono.Simd.Vector8s vb) { return default(Mono.Simd.Vector8s); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(16))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector8us Max(this Mono.Simd.Vector8us va, Mono.Simd.Vector8us vb) { return default(Mono.Simd.Vector8us); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector16b Min(this Mono.Simd.Vector16b va, Mono.Simd.Vector16b vb) { return default(Mono.Simd.Vector16b); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(16))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector16sb Min(this Mono.Simd.Vector16sb va, Mono.Simd.Vector16sb vb) { return default(Mono.Simd.Vector16sb); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector2d Min(this Mono.Simd.Vector2d v1, Mono.Simd.Vector2d v2) { return default(Mono.Simd.Vector2d); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static Mono.Simd.Vector4f Min(this Mono.Simd.Vector4f v1, Mono.Simd.Vector4f v2) { return default(Mono.Simd.Vector4f); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(16))]
    public static Mono.Simd.Vector4i Min(this Mono.Simd.Vector4i v1, Mono.Simd.Vector4i v2) { return default(Mono.Simd.Vector4i); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(16))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector4ui Min(this Mono.Simd.Vector4ui v1, Mono.Simd.Vector4ui v2) { return default(Mono.Simd.Vector4ui); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector8s Min(this Mono.Simd.Vector8s va, Mono.Simd.Vector8s vb) { return default(Mono.Simd.Vector8s); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(16))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector8us Min(this Mono.Simd.Vector8us va, Mono.Simd.Vector8us vb) { return default(Mono.Simd.Vector8us); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector8s MultiplyStoreHigh(this Mono.Simd.Vector8s va, Mono.Simd.Vector8s vb) { return default(Mono.Simd.Vector8s); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector8us MultiplyStoreHigh(this Mono.Simd.Vector8us va, Mono.Simd.Vector8us vb) { return default(Mono.Simd.Vector8us); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector8s PackWithSignedSaturation(this Mono.Simd.Vector4i va, Mono.Simd.Vector4i vb) { return default(Mono.Simd.Vector8s); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector16sb PackWithSignedSaturation(this Mono.Simd.Vector8s va, Mono.Simd.Vector8s vb) { return default(Mono.Simd.Vector16sb); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(16))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector8us PackWithUnsignedSaturation(this Mono.Simd.Vector4i va, Mono.Simd.Vector4i vb) { return default(Mono.Simd.Vector8us); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector16b PackWithUnsignedSaturation(this Mono.Simd.Vector8s va, Mono.Simd.Vector8s vb) { return default(Mono.Simd.Vector16b); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static Mono.Simd.Vector4f Reciprocal(this Mono.Simd.Vector4f v1) { return default(Mono.Simd.Vector4f); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector2d Shuffle(this Mono.Simd.Vector2d v1, Mono.Simd.Vector2d v2, int sel) { return default(Mono.Simd.Vector2d); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector2l Shuffle(this Mono.Simd.Vector2l v1, Mono.Simd.Vector2l v2, int sel) { return default(Mono.Simd.Vector2l); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector2ul Shuffle(this Mono.Simd.Vector2ul v1, Mono.Simd.Vector2ul v2, int sel) { return default(Mono.Simd.Vector2ul); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector4f Shuffle(this Mono.Simd.Vector4f v1, Mono.Simd.ShuffleSel sel) { return default(Mono.Simd.Vector4f); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector4f Shuffle(this Mono.Simd.Vector4f v1, Mono.Simd.Vector4f v2, Mono.Simd.ShuffleSel sel) { return default(Mono.Simd.Vector4f); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector4i Shuffle(this Mono.Simd.Vector4i v1, Mono.Simd.ShuffleSel sel) { return default(Mono.Simd.Vector4i); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector4i Shuffle(this Mono.Simd.Vector4i v1, Mono.Simd.Vector4i v2, Mono.Simd.ShuffleSel sel) { return default(Mono.Simd.Vector4i); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector4ui Shuffle(this Mono.Simd.Vector4ui v1, Mono.Simd.ShuffleSel sel) { return default(Mono.Simd.Vector4ui); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector4ui Shuffle(this Mono.Simd.Vector4ui v1, Mono.Simd.Vector4ui v2, Mono.Simd.ShuffleSel sel) { return default(Mono.Simd.Vector4ui); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector8s ShuffleHigh(this Mono.Simd.Vector8s va, Mono.Simd.ShuffleSel sel) { return default(Mono.Simd.Vector8s); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector8us ShuffleHigh(this Mono.Simd.Vector8us va, Mono.Simd.ShuffleSel sel) { return default(Mono.Simd.Vector8us); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector8s ShuffleLow(this Mono.Simd.Vector8s va, Mono.Simd.ShuffleSel sel) { return default(Mono.Simd.Vector8s); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector8us ShuffleLow(this Mono.Simd.Vector8us va, Mono.Simd.ShuffleSel sel) { return default(Mono.Simd.Vector8us); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector8s SignedPackWithSignedSaturation(this Mono.Simd.Vector4ui va, Mono.Simd.Vector4ui vb) { return default(Mono.Simd.Vector8s); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector16sb SignedPackWithSignedSaturation(this Mono.Simd.Vector8us va, Mono.Simd.Vector8us vb) { return default(Mono.Simd.Vector16sb); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(16))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector8us SignedPackWithUnsignedSaturation(this Mono.Simd.Vector4ui va, Mono.Simd.Vector4ui vb) { return default(Mono.Simd.Vector8us); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector16b SignedPackWithUnsignedSaturation(this Mono.Simd.Vector8us va, Mono.Simd.Vector8us vb) { return default(Mono.Simd.Vector16b); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector2d Sqrt(this Mono.Simd.Vector2d v1) { return default(Mono.Simd.Vector2d); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(1))]
    public static Mono.Simd.Vector4f Sqrt(this Mono.Simd.Vector4f v1) { return default(Mono.Simd.Vector4f); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector16b SubtractWithSaturation(this Mono.Simd.Vector16b va, Mono.Simd.Vector16b vb) { return default(Mono.Simd.Vector16b); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector16sb SubtractWithSaturation(this Mono.Simd.Vector16sb va, Mono.Simd.Vector16sb vb) { return default(Mono.Simd.Vector16sb); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector8s SubtractWithSaturation(this Mono.Simd.Vector8s va, Mono.Simd.Vector8s vb) { return default(Mono.Simd.Vector8s); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector8us SubtractWithSaturation(this Mono.Simd.Vector8us va, Mono.Simd.Vector8us vb) { return default(Mono.Simd.Vector8us); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector8us SumOfAbsoluteDifferences(this Mono.Simd.Vector16b va, Mono.Simd.Vector16sb vb) { return default(Mono.Simd.Vector8us); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector16b UnpackHigh(this Mono.Simd.Vector16b va, Mono.Simd.Vector16b vb) { return default(Mono.Simd.Vector16b); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector16sb UnpackHigh(this Mono.Simd.Vector16sb va, Mono.Simd.Vector16sb vb) { return default(Mono.Simd.Vector16sb); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector2l UnpackHigh(this Mono.Simd.Vector2l v1, Mono.Simd.Vector2l v2) { return default(Mono.Simd.Vector2l); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector2ul UnpackHigh(this Mono.Simd.Vector2ul v1, Mono.Simd.Vector2ul v2) { return default(Mono.Simd.Vector2ul); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector4i UnpackHigh(this Mono.Simd.Vector4i v1, Mono.Simd.Vector4i v2) { return default(Mono.Simd.Vector4i); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector4ui UnpackHigh(this Mono.Simd.Vector4ui v1, Mono.Simd.Vector4ui v2) { return default(Mono.Simd.Vector4ui); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector8s UnpackHigh(this Mono.Simd.Vector8s va, Mono.Simd.Vector8s vb) { return default(Mono.Simd.Vector8s); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector8us UnpackHigh(this Mono.Simd.Vector8us va, Mono.Simd.Vector8us vb) { return default(Mono.Simd.Vector8us); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector16b UnpackLow(this Mono.Simd.Vector16b va, Mono.Simd.Vector16b vb) { return default(Mono.Simd.Vector16b); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector16sb UnpackLow(this Mono.Simd.Vector16sb va, Mono.Simd.Vector16sb vb) { return default(Mono.Simd.Vector16sb); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector2l UnpackLow(this Mono.Simd.Vector2l v1, Mono.Simd.Vector2l v2) { return default(Mono.Simd.Vector2l); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector2ul UnpackLow(this Mono.Simd.Vector2ul v1, Mono.Simd.Vector2ul v2) { return default(Mono.Simd.Vector2ul); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector4i UnpackLow(this Mono.Simd.Vector4i v1, Mono.Simd.Vector4i v2) { return default(Mono.Simd.Vector4i); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector4ui UnpackLow(this Mono.Simd.Vector4ui v1, Mono.Simd.Vector4ui v2) { return default(Mono.Simd.Vector4ui); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    public static Mono.Simd.Vector8s UnpackLow(this Mono.Simd.Vector8s va, Mono.Simd.Vector8s vb) { return default(Mono.Simd.Vector8s); }
    [Mono.Simd.AccelerationAttribute((Mono.Simd.AccelMode)(2))]
    [System.CLSCompliantAttribute(false)]
    public static Mono.Simd.Vector8us UnpackLow(this Mono.Simd.Vector8us va, Mono.Simd.Vector8us vb) { return default(Mono.Simd.Vector8us); }
  }
}
