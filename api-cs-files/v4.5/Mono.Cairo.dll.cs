namespace Cairo {
  public enum Antialias {
    Default = 0,
    Gray = 2,
    None = 1,
    Subpixel = 3,
  }
  public static partial class CairoAPI {
    public static int Version { get { return default(int); } }
    public static string VersionString { get { return default(string); } }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Color {
    public Color(double r, double g, double b) { throw new System.NotImplementedException(); }
    public Color(double r, double g, double b, double a) { throw new System.NotImplementedException(); }
    public double A { get { return default(double); } set { } }
    public double B { get { return default(double); } set { } }
    public double G { get { return default(double); } set { } }
    public double R { get { return default(double); } set { } }
  }
  public enum Content {
    Alpha = 8192,
    Color = 4096,
    ColorAlpha = 12288,
  }
  public partial class Context : System.IDisposable {
    public Context(Cairo.Surface surface) { }
    [System.ObsoleteAttribute]
    public Context(System.IntPtr state) { }
    public Context(System.IntPtr handle, bool owner) { }
    public Cairo.Antialias Antialias { get { return default(Cairo.Antialias); } set { } }
    [System.ObsoleteAttribute("Use SetSourceColor method")]
    public Cairo.Color Color { set { } }
    [System.ObsoleteAttribute("Use SetSourceRGBA method")]
    public Cairo.Color ColorRgb { set { } }
    [System.ObsoleteAttribute("Use GetFontFace/SetFontFace")]
    public Cairo.FontFace ContextFontFace { get { return default(Cairo.FontFace); } set { } }
    public Cairo.PointD CurrentPoint { get { return default(Cairo.PointD); } }
    public Cairo.FillRule FillRule { get { return default(Cairo.FillRule); } set { } }
    public Cairo.FontExtents FontExtents { get { return default(Cairo.FontExtents); } }
    public Cairo.Matrix FontMatrix { get { return default(Cairo.Matrix); } set { } }
    public Cairo.FontOptions FontOptions { get { return default(Cairo.FontOptions); } set { } }
    [System.ObsoleteAttribute("Use SetFontSize() instead.")]
    public double FontSize { set { } }
    [System.ObsoleteAttribute("Use GetGroupTarget()")]
    public Cairo.Surface GroupTarget { get { return default(Cairo.Surface); } }
    public System.IntPtr Handle { get { return default(System.IntPtr); } }
    public bool HasCurrentPoint { get { return default(bool); } }
    public Cairo.LineCap LineCap { get { return default(Cairo.LineCap); } set { } }
    public Cairo.LineJoin LineJoin { get { return default(Cairo.LineJoin); } set { } }
    public double LineWidth { get { return default(double); } set { } }
    public Cairo.Matrix Matrix { get { return default(Cairo.Matrix); } set { } }
    public double MiterLimit { get { return default(double); } set { } }
    public Cairo.Operator Operator { get { return default(Cairo.Operator); } set { } }
    [System.ObsoleteAttribute("Use GetSource/GetSource")]
    public Cairo.Pattern Pattern { get { return default(Cairo.Pattern); } set { } }
    public uint ReferenceCount { get { return default(uint); } }
    [System.ObsoleteAttribute("Use GetScaledFont/SetScaledFont")]
    public Cairo.ScaledFont ScaledFont { get { return default(Cairo.ScaledFont); } set { } }
    [System.ObsoleteAttribute("Use GetSource/GetSource")]
    public Cairo.Pattern Source { get { return default(Cairo.Pattern); } set { } }
    public Cairo.Status Status { get { return default(Cairo.Status); } }
    [System.ObsoleteAttribute("Use GetTarget/SetTarget")]
    public Cairo.Surface Target { get { return default(Cairo.Surface); } set { } }
    public double Tolerance { get { return default(double); } set { } }
    public void AppendPath(Cairo.Path path) { }
    public void Arc(double xc, double yc, double radius, double angle1, double angle2) { }
    public void ArcNegative(double xc, double yc, double radius, double angle1, double angle2) { }
    public void Clip() { }
    public void ClipPreserve() { }
    public void ClosePath() { }
    public void CopyPage() { }
    public Cairo.Path CopyPath() { return default(Cairo.Path); }
    public Cairo.Path CopyPathFlat() { return default(Cairo.Path); }
    public void CurveTo(Cairo.PointD p1, Cairo.PointD p2, Cairo.PointD p3) { }
    public void CurveTo(double x1, double y1, double x2, double y2, double x3, double y3) { }
    public void DeviceToUser(ref double x, ref double y) { }
    public void DeviceToUserDistance(ref double dx, ref double dy) { }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public void Fill() { }
    public Cairo.Rectangle FillExtents() { return default(Cairo.Rectangle); }
    public void FillPreserve() { }
    ~Context() { }
    [System.ObsoleteAttribute("Use SelectFontFace() instead.")]
    public void FontFace(string family, Cairo.FontSlant slant, Cairo.FontWeight weight) { }
    [System.ObsoleteAttribute("Use SetFontSize() instead.")]
    public void FontSetSize(double scale) { }
    public Cairo.FontFace GetContextFontFace() { return default(Cairo.FontFace); }
    public Cairo.Surface GetGroupTarget() { return default(Cairo.Surface); }
    public Cairo.ScaledFont GetScaledFont() { return default(Cairo.ScaledFont); }
    public Cairo.Pattern GetSource() { return default(Cairo.Pattern); }
    public Cairo.Surface GetTarget() { return default(Cairo.Surface); }
    public Cairo.TextExtents GlyphExtents(Cairo.Glyph[] glyphs) { return default(Cairo.TextExtents); }
    public void GlyphPath(Cairo.Glyph[] glyphs) { }
    [System.ObsoleteAttribute("The matrix argument was never used, use GlyphPath(Glyphs []) instead")]
    public void GlyphPath(Cairo.Matrix matrix, Cairo.Glyph[] glyphs) { }
    public void IdentityMatrix() { }
    public bool InClip(double x, double y) { return default(bool); }
    public bool InFill(double x, double y) { return default(bool); }
    public bool InStroke(double x, double y) { return default(bool); }
    [System.ObsoleteAttribute("Use DeviceToUserDistance instead")]
    public void InverseTransformDistance(ref double dx, ref double dy) { }
    [System.ObsoleteAttribute("Use InverseTransformPoint instead")]
    public void InverseTransformPoint(ref double x, ref double y) { }
    public void LineTo(Cairo.PointD p) { }
    public void LineTo(double x, double y) { }
    public void Mask(Cairo.Pattern pattern) { }
    public void MaskSurface(Cairo.Surface surface, double surface_x, double surface_y) { }
    public void MoveTo(Cairo.PointD p) { }
    public void MoveTo(double x, double y) { }
    public void NewPath() { }
    public void NewSubPath() { }
    public void Paint() { }
    public void PaintWithAlpha(double alpha) { }
    public Cairo.Pattern PopGroup() { return default(Cairo.Pattern); }
    public void PopGroupToSource() { }
    public void PushGroup() { }
    public void PushGroup(Cairo.Content content) { }
    public void Rectangle(Cairo.PointD p, double width, double height) { }
    public void Rectangle(Cairo.Rectangle rectangle) { }
    public void Rectangle(double x, double y, double width, double height) { }
    public void RelCurveTo(Cairo.Distance d1, Cairo.Distance d2, Cairo.Distance d3) { }
    public void RelCurveTo(double dx1, double dy1, double dx2, double dy2, double dx3, double dy3) { }
    public void RelLineTo(Cairo.Distance d) { }
    public void RelLineTo(double dx, double dy) { }
    public void RelMoveTo(Cairo.Distance d) { }
    public void RelMoveTo(double dx, double dy) { }
    public void ResetClip() { }
    public void Restore() { }
    public void Rotate(double angle) { }
    public void Save() { }
    public void Scale(double sx, double sy) { }
    public void SelectFontFace(string family, Cairo.FontSlant slant, Cairo.FontWeight weight) { }
    public void SetContextFontFace(Cairo.FontFace value) { }
    public void SetDash(System.Double[] dashes, double offset) { }
    public void SetFontSize(double scale) { }
    public void SetScaledFont(Cairo.ScaledFont font) { }
    public void SetSource(Cairo.Pattern source) { }
    public void SetSource(Cairo.Surface source) { }
    public void SetSource(Cairo.Surface source, double x, double y) { }
    public void SetSourceColor(Cairo.Color color) { }
    public void SetSourceRGB(double r, double g, double b) { }
    public void SetSourceRGBA(double r, double g, double b, double a) { }
    public void SetSourceSurface(Cairo.Surface source, int x, int y) { }
    public void SetTarget(Cairo.Surface target) { }
    public void ShowGlyphs(Cairo.Glyph[] glyphs) { }
    [System.ObsoleteAttribute("The matrix argument was never used, use ShowGlyphs(Glyphs []) instead")]
    public void ShowGlyphs(Cairo.Matrix matrix, Cairo.Glyph[] glyphs) { }
    public void ShowPage() { }
    public void ShowText(System.Byte[] utf8) { }
    public void ShowText(string str) { }
    public void Stroke() { }
    public Cairo.Rectangle StrokeExtents() { return default(Cairo.Rectangle); }
    public void StrokePreserve() { }
    public Cairo.TextExtents TextExtents(System.Byte[] utf8) { return default(Cairo.TextExtents); }
    public Cairo.TextExtents TextExtents(string s) { return default(Cairo.TextExtents); }
    public void TextPath(System.Byte[] utf8) { }
    public void TextPath(string str) { }
    public void Transform(Cairo.Matrix m) { }
    [System.ObsoleteAttribute("Use UserToDeviceDistance instead")]
    public void TransformDistance(ref double dx, ref double dy) { }
    [System.ObsoleteAttribute("Use UserToDevice instead")]
    public void TransformPoint(ref double x, ref double y) { }
    public void Translate(double tx, double ty) { }
    public void UserToDevice(ref double x, ref double y) { }
    public void UserToDeviceDistance(ref double dx, ref double dy) { }
  }
  public partial class DirectFBSurface : Cairo.Surface {
    public DirectFBSurface(System.IntPtr dfb, System.IntPtr dfb_surface) { }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Distance {
    public Distance(double dx, double dy) { throw new System.NotImplementedException(); }
    public double Dx { get { return default(double); } set { } }
    public double Dy { get { return default(double); } set { } }
  }
  public enum Extend {
    None = 0,
    Pad = 3,
    Reflect = 2,
    Repeat = 1,
  }
  public enum FillRule {
    EvenOdd = 1,
    Winding = 0,
  }
  public enum Filter {
    Best = 2,
    Bilinear = 4,
    Fast = 0,
    Gaussian = 5,
    Good = 1,
    Nearest = 3,
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct FontExtents {
    public FontExtents(double ascent, double descent, double height, double maxXAdvance, double maxYAdvance) { throw new System.NotImplementedException(); }
    public double Ascent { get { return default(double); } set { } }
    public double Descent { get { return default(double); } set { } }
    public double Height { get { return default(double); } set { } }
    public double MaxXAdvance { get { return default(double); } set { } }
    public double MaxYAdvance { get { return default(double); } set { } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(Cairo.FontExtents extents, Cairo.FontExtents other) { return default(bool); }
    public static bool operator !=(Cairo.FontExtents extents, Cairo.FontExtents other) { return default(bool); }
  }
  public partial class FontFace : System.IDisposable {
    [System.ObsoleteAttribute]
    public FontFace(System.IntPtr handle) { }
    public FontFace(System.IntPtr handle, bool owned) { }
    public Cairo.FontType FontType { get { return default(Cairo.FontType); } }
    public System.IntPtr Handle { get { return default(System.IntPtr); } }
    public uint ReferenceCount { get { return default(uint); } }
    public Cairo.Status Status { get { return default(Cairo.Status); } }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    ~FontFace() { }
  }
  public partial class FontOptions : System.IDisposable {
    public FontOptions() { }
    public Cairo.Antialias Antialias { get { return default(Cairo.Antialias); } set { } }
    public System.IntPtr Handle { get { return default(System.IntPtr); } }
    public Cairo.HintMetrics HintMetrics { get { return default(Cairo.HintMetrics); } set { } }
    public Cairo.HintStyle HintStyle { get { return default(Cairo.HintStyle); } set { } }
    public Cairo.Status Status { get { return default(Cairo.Status); } }
    public Cairo.SubpixelOrder SubpixelOrder { get { return default(Cairo.SubpixelOrder); } set { } }
    public Cairo.FontOptions Copy() { return default(Cairo.FontOptions); }
    [System.ObsoleteAttribute("Use Dispose()")]
    public void Destroy() { }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public override bool Equals(object other) { return default(bool); }
    ~FontOptions() { }
    public override int GetHashCode() { return default(int); }
    public void Merge(Cairo.FontOptions other) { }
    public static bool operator ==(Cairo.FontOptions options, Cairo.FontOptions other) { return default(bool); }
    public static bool operator !=(Cairo.FontOptions options, Cairo.FontOptions other) { return default(bool); }
  }
  public enum FontSlant {
    Italic = 1,
    Normal = 0,
    Oblique = 2,
  }
  public enum FontType {
    Atsui = 3,
    FreeType = 1,
    Toy = 0,
    Win32 = 2,
  }
  public enum FontWeight {
    Bold = 1,
    Normal = 0,
  }
  public enum Format {
    A1 = 3,
    A8 = 2,
    Argb32 = 0,
    ARGB32 = 0,
    Rgb16565 = 4,
    Rgb24 = 1,
    RGB24 = 1,
  }
  public partial class GlitzSurface : Cairo.Surface {
    public GlitzSurface(System.IntPtr glitz_surface) { }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Glyph {
    public Glyph(long index, double x, double y) { throw new System.NotImplementedException(); }
    public long Index { get { return default(long); } set { } }
    public double X { get { return default(double); } set { } }
    public double Y { get { return default(double); } set { } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(Cairo.Glyph glyph, Cairo.Glyph other) { return default(bool); }
    public static bool operator !=(Cairo.Glyph glyph, Cairo.Glyph other) { return default(bool); }
  }
  public partial class Gradient : Cairo.Pattern {
    [System.ObsoleteAttribute]
    protected Gradient() { }
    protected Gradient(System.IntPtr handle, bool owned) { }
    public int ColorStopCount { get { return default(int); } }
    public Cairo.Status AddColorStop(double offset, Cairo.Color c) { return default(Cairo.Status); }
    public Cairo.Status AddColorStopRgb(double offset, Cairo.Color c) { return default(Cairo.Status); }
  }
  [System.ObsoleteAttribute("Renamed Cairo.Context per suggestion from cairo binding guidelines.")]
  public partial class Graphics : Cairo.Context {
    public Graphics(Cairo.Surface surface) : base (default(Cairo.Surface)) { }
    public Graphics(System.IntPtr state) : base (default(Cairo.Surface)) { }
  }
  public enum HintMetrics {
    Default = 0,
    Off = 1,
    On = 2,
  }
  public enum HintStyle {
    Default = 0,
    Full = 4,
    Medium = 3,
    None = 1,
    Slight = 2,
  }
  public partial class ImageSurface : Cairo.Surface {
    public ImageSurface(Cairo.Format format, int width, int height) { }
    public ImageSurface(System.Byte[] data, Cairo.Format format, int width, int height, int stride) { }
    [System.ObsoleteAttribute("Use ImageSurface (byte[] data, Cairo.Format format, int width, int height, int stride)")]
    public ImageSurface(ref System.Byte[] data, Cairo.Format format, int width, int height, int stride) { }
    public ImageSurface(System.IntPtr data, Cairo.Format format, int width, int height, int stride) { }
    public ImageSurface(string filename) { }
    public System.Byte[] Data { get { return default(System.Byte[]); } }
    public System.IntPtr DataPtr { get { return default(System.IntPtr); } }
    public Cairo.Format Format { get { return default(Cairo.Format); } }
    public int Height { get { return default(int); } }
    public int Stride { get { return default(int); } }
    public int Width { get { return default(int); } }
  }
  public partial class LinearGradient : Cairo.Gradient {
    public LinearGradient(double x0, double y0, double x1, double y1) { }
    public Cairo.PointD[] LinearPoints { get { return default(Cairo.PointD[]); } }
  }
  public enum LineCap {
    Butt = 0,
    Round = 1,
    Square = 2,
  }
  public enum LineJoin {
    Bevel = 2,
    Miter = 0,
    Round = 1,
  }
  public partial class Matrix : System.ICloneable {
    public double X0;
    public double Xx;
    public double Xy;
    public double Y0;
    public double Yx;
    public double Yy;
    public Matrix() { }
    public Matrix(double xx, double yx, double xy, double yy, double x0, double y0) { }
    public object Clone() { return default(object); }
    public override bool Equals(object o) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public void Init(double xx, double yx, double xy, double yy, double x0, double y0) { }
    public void InitIdentity() { }
    public void InitRotate(double radians) { }
    public void InitScale(double sx, double sy) { }
    public void InitTranslate(double tx, double ty) { }
    public Cairo.Status Invert() { return default(Cairo.Status); }
    public bool IsIdentity() { return default(bool); }
    public void Multiply(Cairo.Matrix b) { }
    public static Cairo.Matrix Multiply(Cairo.Matrix a, Cairo.Matrix b) { return default(Cairo.Matrix); }
    public static bool operator ==(Cairo.Matrix lhs, Cairo.Matrix rhs) { return default(bool); }
    public static bool operator !=(Cairo.Matrix lhs, Cairo.Matrix rhs) { return default(bool); }
    public void Rotate(double radians) { }
    public void Scale(double sx, double sy) { }
    public override string ToString() { return default(string); }
    public void TransformDistance(ref double dx, ref double dy) { }
    public void TransformPoint(ref double x, ref double y) { }
    public void Translate(double tx, double ty) { }
  }
  public enum Operator {
    Add = 12,
    Atop = 5,
    Clear = 0,
    Dest = 6,
    DestAtop = 10,
    DestIn = 8,
    DestOut = 9,
    DestOver = 7,
    In = 3,
    Out = 4,
    Over = 2,
    Saturate = 13,
    Source = 1,
    Xor = 11,
  }
  public partial class Path : System.IDisposable {
    internal Path() { }
    public System.IntPtr Handle { get { return default(System.IntPtr); } }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    ~Path() { }
  }
  public partial class Pattern : System.IDisposable {
    [System.ObsoleteAttribute]
    protected System.IntPtr pattern;
    [System.ObsoleteAttribute]
    protected Pattern() { }
    [System.ObsoleteAttribute("Use the SurfacePattern constructor")]
    public Pattern(Cairo.Surface surface) { }
    public Cairo.Extend Extend { get { return default(Cairo.Extend); } set { } }
    public System.IntPtr Handle { get { return default(System.IntPtr); } }
    public Cairo.Matrix Matrix { get { return default(Cairo.Matrix); } set { } }
    public Cairo.PatternType PatternType { get { return default(Cairo.PatternType); } }
    [System.ObsoleteAttribute]
    public System.IntPtr Pointer { get { return default(System.IntPtr); } }
    public Cairo.Status Status { get { return default(Cairo.Status); } }
    [System.ObsoleteAttribute("Use Dispose()")]
    public void Destroy() { }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    ~Pattern() { }
    public static Cairo.Pattern Lookup(System.IntPtr pattern, bool owner) { return default(Cairo.Pattern); }
    [System.ObsoleteAttribute]
    protected void Reference() { }
  }
  public enum PatternType {
    Linear = 2,
    Radial = 3,
    Solid = 0,
    Surface = 1,
  }
  public partial class PdfSurface : Cairo.Surface {
    public PdfSurface(string filename, double width, double height) { }
    public void SetSize(double width, double height) { }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Point {
    public Point(int x, int y) { throw new System.NotImplementedException(); }
    public int X { get { return default(int); } set { } }
    public int Y { get { return default(int); } set { } }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct PointD {
    public PointD(double x, double y) { throw new System.NotImplementedException(); }
    public double X { get { return default(double); } set { } }
    public double Y { get { return default(double); } set { } }
  }
  public partial class PSSurface : Cairo.Surface {
    public PSSurface(string filename, double width, double height) { }
    public void BeginPageSetup() { }
    public void BeginSetup() { }
    public void DscComment(string comment) { }
    public void SetSize(double width, double height) { }
  }
  public partial class RadialGradient : Cairo.Gradient {
    public RadialGradient(double cx0, double cy0, double radius0, double cx1, double cy1, double radius1) { }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Rectangle {
    public Rectangle(Cairo.Point point, double width, double height) { throw new System.NotImplementedException(); }
    public Rectangle(double x, double y, double width, double height) { throw new System.NotImplementedException(); }
    public double Height { get { return default(double); } }
    public double Width { get { return default(double); } }
    public double X { get { return default(double); } }
    public double Y { get { return default(double); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(Cairo.Rectangle rectangle, Cairo.Rectangle other) { return default(bool); }
    public static bool operator !=(Cairo.Rectangle rectangle, Cairo.Rectangle other) { return default(bool); }
    public override string ToString() { return default(string); }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct RectangleInt {
    public int Height;
    public int Width;
    public int X;
    public int Y;
  }
  public partial class Region : System.IDisposable {
    public Region() { }
    public Region(Cairo.RectangleInt rect) { }
    public Region(Cairo.RectangleInt[] rects) { }
    [System.ObsoleteAttribute]
    public Region(System.IntPtr handle) { }
    public Region(System.IntPtr handle, bool owned) { }
    public Cairo.RectangleInt Extents { get { return default(Cairo.RectangleInt); } }
    public System.IntPtr Handle { get { return default(System.IntPtr); } }
    public bool IsEmpty { get { return default(bool); } }
    public int NumRectangles { get { return default(int); } }
    public Cairo.Status Status { get { return default(Cairo.Status); } }
    public Cairo.RegionOverlap ContainsPoint(Cairo.RectangleInt rectangle) { return default(Cairo.RegionOverlap); }
    public bool ContainsPoint(int x, int y) { return default(bool); }
    public Cairo.Region Copy() { return default(Cairo.Region); }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public override bool Equals(object obj) { return default(bool); }
    ~Region() { }
    public override int GetHashCode() { return default(int); }
    public Cairo.RectangleInt GetRectangle(int nth) { return default(Cairo.RectangleInt); }
    public Cairo.Status Intersect(Cairo.Region other) { return default(Cairo.Status); }
    public Cairo.Status IntersectRectangle(Cairo.RectangleInt rectangle) { return default(Cairo.Status); }
    public Cairo.Status Subtract(Cairo.Region other) { return default(Cairo.Status); }
    public Cairo.Status SubtractRectangle(Cairo.RectangleInt rectangle) { return default(Cairo.Status); }
    public void Translate(int dx, int dy) { }
    public Cairo.Status Union(Cairo.Region other) { return default(Cairo.Status); }
    public Cairo.Status UnionRectangle(Cairo.RectangleInt rectangle) { return default(Cairo.Status); }
    public Cairo.Status Xor(Cairo.Region other) { return default(Cairo.Status); }
    public Cairo.Status XorRectangle(Cairo.RectangleInt rectangle) { return default(Cairo.Status); }
  }
  public enum RegionOverlap {
    In = 0,
    Out = 1,
    Part = 2,
  }
  public partial class ScaledFont : System.IDisposable {
    protected System.IntPtr handle;
    public ScaledFont(Cairo.FontFace fontFace, Cairo.Matrix matrix, Cairo.Matrix ctm, Cairo.FontOptions options) { }
    public Cairo.FontExtents FontExtents { get { return default(Cairo.FontExtents); } }
    public Cairo.Matrix FontMatrix { get { return default(Cairo.Matrix); } }
    public Cairo.FontType FontType { get { return default(Cairo.FontType); } }
    public System.IntPtr Handle { get { return default(System.IntPtr); } }
    public Cairo.Status Status { get { return default(Cairo.Status); } }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    ~ScaledFont() { }
    public Cairo.TextExtents GlyphExtents(Cairo.Glyph[] glyphs) { return default(Cairo.TextExtents); }
    [System.ObsoleteAttribute]
    protected void Reference() { }
  }
  public partial class SolidPattern : Cairo.Pattern {
    public SolidPattern(Cairo.Color color) { }
    public SolidPattern(Cairo.Color color, bool solid) { }
    public SolidPattern(double r, double g, double b) { }
    public SolidPattern(double r, double g, double b, double a) { }
    public Cairo.Color Color { get { return default(Cairo.Color); } }
  }
  public enum Status {
    ClipNotRepresentable = 22,
    FileNotFound = 18,
    InvalidContent = 15,
    InvalidDash = 19,
    InvalidDscComment = 20,
    InvalidFormat = 16,
    InvalidIndex = 21,
    InvalidMatrix = 5,
    InvalidPathData = 9,
    InvalidPopGroup = 3,
    InvalidRestore = 2,
    InvalidStatus = 6,
    InvalidString = 8,
    InvalidVisual = 17,
    NoCurrentPoint = 4,
    NoMemory = 1,
    NullPointer = 7,
    PatternTypeMismatch = 14,
    ReadError = 10,
    Success = 0,
    SurfaceFinished = 12,
    SurfaceTypeMismatch = 13,
    WriteError = 11,
  }
  public enum SubpixelOrder {
    Bgr = 2,
    Default = 0,
    Rgb = 1,
    Vbgr = 4,
    Vrgb = 3,
  }
  public partial class Surface : System.IDisposable {
    [System.ObsoleteAttribute]
    protected static System.Collections.Hashtable surfaces;
    [System.ObsoleteAttribute]
    protected Surface() { }
    [System.ObsoleteAttribute]
    protected Surface(System.IntPtr ptr) { }
    protected Surface(System.IntPtr handle, bool owner) { }
    public Cairo.Content Content { get { return default(Cairo.Content); } }
    public Cairo.PointD DeviceOffset { get { return default(Cairo.PointD); } set { } }
    public System.IntPtr Handle { get { return default(System.IntPtr); } }
    [System.ObsoleteAttribute("Use Handle instead.")]
    public System.IntPtr Pointer { get { return default(System.IntPtr); } }
    public uint ReferenceCount { get { return default(uint); } }
    public Cairo.Status Status { get { return default(Cairo.Status); } }
    public Cairo.SurfaceType SurfaceType { get { return default(Cairo.SurfaceType); } }
    [System.ObsoleteAttribute("Use an ImageSurface constructor instead.")]
    public static Cairo.Surface CreateForImage(Cairo.Format format, int width, int height) { return default(Cairo.Surface); }
    [System.ObsoleteAttribute("Use an ImageSurface constructor instead.")]
    public static Cairo.Surface CreateForImage(ref System.Byte[] data, Cairo.Format format, int width, int height, int stride) { return default(Cairo.Surface); }
    public Cairo.Surface CreateSimilar(Cairo.Content content, int width, int height) { return default(Cairo.Surface); }
    [System.ObsoleteAttribute("Use Dispose()")]
    public void Destroy() { }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    ~Surface() { }
    public Cairo.Status Finish() { return default(Cairo.Status); }
    public void Flush() { }
    public static Cairo.Surface Lookup(System.IntPtr surface, bool owned) { return default(Cairo.Surface); }
    public void MarkDirty() { }
    public void MarkDirty(Cairo.Rectangle rectangle) { }
    public void SetFallbackResolution(double x, double y) { }
    public void Show(Cairo.Context gr, double x, double y) { }
    public void WriteToPng(string filename) { }
  }
  public partial class SurfacePattern : Cairo.Pattern {
    public SurfacePattern(Cairo.Surface surface) { }
    public new Cairo.Extend Extend { get { return default(Cairo.Extend); } set { } }
    public Cairo.Filter Filter { get { return default(Cairo.Filter); } set { } }
  }
  public enum SurfaceType {
    BeOS = 8,
    DirectFB = 9,
    Glitz = 5,
    Image = 0,
    Pdf = 1,
    PS = 2,
    Quartz = 6,
    Svg = 10,
    Win32 = 7,
    Xcb = 4,
    Xlib = 3,
  }
  public partial class SvgSurface : Cairo.Surface {
    public SvgSurface(string filename, double width, double height) { }
    public void RestrictToVersion(Cairo.SvgVersion version) { }
  }
  public enum SvgVersion {
    OnePointOne = 0,
    OnePointTwo = 1,
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct TextExtents {
    public double Height { get { return default(double); } set { } }
    public double Width { get { return default(double); } set { } }
    public double XAdvance { get { return default(double); } set { } }
    public double XBearing { get { return default(double); } set { } }
    public double YAdvance { get { return default(double); } set { } }
    public double YBearing { get { return default(double); } set { } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(Cairo.TextExtents extents, Cairo.TextExtents other) { return default(bool); }
    public static bool operator !=(Cairo.TextExtents extents, Cairo.TextExtents other) { return default(bool); }
  }
  public partial class Win32Surface : Cairo.Surface {
    public Win32Surface(System.IntPtr hdc) { }
  }
  public partial class XcbSurface : Cairo.Surface {
    public XcbSurface(System.IntPtr connection, uint drawable, System.IntPtr visual, int width, int height) { }
    public static Cairo.XcbSurface FromBitmap(System.IntPtr connection, uint bitmap, System.IntPtr screen, int width, int height) { return default(Cairo.XcbSurface); }
    public void SetSize(int width, int height) { }
  }
  public partial class XlibSurface : Cairo.Surface {
    public XlibSurface(System.IntPtr ptr, bool own) { }
    public XlibSurface(System.IntPtr display, System.IntPtr drawable, System.IntPtr visual, int width, int height) { }
    public int Depth { get { return default(int); } }
    public System.IntPtr Display { get { return default(System.IntPtr); } }
    public System.IntPtr Drawable { get { return default(System.IntPtr); } }
    public int Height { get { return default(int); } }
    public System.IntPtr Screen { get { return default(System.IntPtr); } }
    public System.IntPtr Visual { get { return default(System.IntPtr); } }
    public int Width { get { return default(int); } }
    public static Cairo.XlibSurface FromBitmap(System.IntPtr display, System.IntPtr bitmap, System.IntPtr screen, int width, int height) { return default(Cairo.XlibSurface); }
    public void SetDrawable(System.IntPtr drawable, int width, int height) { }
    public void SetSize(int width, int height) { }
  }
}
