namespace System.Drawing {
  [System.ComponentModel.EditorAttribute("System.Drawing.Design.BitmapEditor, System.Drawing.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(System.Drawing.Design.UITypeEditor))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class Bitmap : System.Drawing.Image {
    public Bitmap(System.Drawing.Image original) { }
    public Bitmap(System.Drawing.Image original, System.Drawing.Size newSize) { }
    public Bitmap(System.Drawing.Image original, int width, int height) { }
    public Bitmap(int width, int height) { }
    public Bitmap(int width, int height, System.Drawing.Graphics g) { }
    public Bitmap(int width, int height, System.Drawing.Imaging.PixelFormat format) { }
    public Bitmap(int width, int height, int stride, System.Drawing.Imaging.PixelFormat format, System.IntPtr scan0) { }
    public Bitmap(System.IO.Stream stream) { }
    public Bitmap(System.IO.Stream stream, bool useIcm) { }
    public Bitmap(string filename) { }
    public Bitmap(string filename, bool useIcm) { }
    public Bitmap(System.Type type, string resource) { }
    public System.Drawing.Bitmap Clone(System.Drawing.Rectangle rect, System.Drawing.Imaging.PixelFormat format) { return default(System.Drawing.Bitmap); }
    public System.Drawing.Bitmap Clone(System.Drawing.RectangleF rect, System.Drawing.Imaging.PixelFormat format) { return default(System.Drawing.Bitmap); }
    public static System.Drawing.Bitmap FromHicon(System.IntPtr hicon) { return default(System.Drawing.Bitmap); }
    public static System.Drawing.Bitmap FromResource(System.IntPtr hinstance, string bitmapName) { return default(System.Drawing.Bitmap); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
    public System.IntPtr GetHbitmap() { return default(System.IntPtr); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
    public System.IntPtr GetHbitmap(System.Drawing.Color background) { return default(System.IntPtr); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
    public System.IntPtr GetHicon() { return default(System.IntPtr); }
    public System.Drawing.Color GetPixel(int x, int y) { return default(System.Drawing.Color); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
    public System.Drawing.Imaging.BitmapData LockBits(System.Drawing.Rectangle rect, System.Drawing.Imaging.ImageLockMode flags, System.Drawing.Imaging.PixelFormat format) { return default(System.Drawing.Imaging.BitmapData); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
    public System.Drawing.Imaging.BitmapData LockBits(System.Drawing.Rectangle rect, System.Drawing.Imaging.ImageLockMode flags, System.Drawing.Imaging.PixelFormat format, System.Drawing.Imaging.BitmapData bitmapData) { return default(System.Drawing.Imaging.BitmapData); }
    public void MakeTransparent() { }
    public void MakeTransparent(System.Drawing.Color transparentColor) { }
    public void SetPixel(int x, int y, System.Drawing.Color color) { }
    public void SetResolution(float xDpi, float yDpi) { }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
    public void UnlockBits(System.Drawing.Imaging.BitmapData bitmapdata) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(1))]
  public partial class BitmapSuffixInSameAssemblyAttribute : System.Attribute {
    public BitmapSuffixInSameAssemblyAttribute() { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(1))]
  public partial class BitmapSuffixInSatelliteAssemblyAttribute : System.Attribute {
    public BitmapSuffixInSatelliteAssemblyAttribute() { }
  }
  public abstract partial class Brush : System.MarshalByRefObject, System.ICloneable, System.IDisposable {
    protected Brush() { }
    public abstract object Clone();
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    ~Brush() { }
    protected internal void SetNativeBrush(System.IntPtr brush) { }
  }
  public sealed partial class Brushes {
    internal Brushes() { }
    public static System.Drawing.Brush AliceBlue { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush AntiqueWhite { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Aqua { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Aquamarine { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Azure { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Beige { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Bisque { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Black { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush BlanchedAlmond { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Blue { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush BlueViolet { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Brown { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush BurlyWood { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush CadetBlue { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Chartreuse { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Chocolate { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Coral { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush CornflowerBlue { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Cornsilk { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Crimson { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Cyan { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush DarkBlue { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush DarkCyan { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush DarkGoldenrod { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush DarkGray { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush DarkGreen { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush DarkKhaki { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush DarkMagenta { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush DarkOliveGreen { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush DarkOrange { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush DarkOrchid { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush DarkRed { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush DarkSalmon { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush DarkSeaGreen { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush DarkSlateBlue { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush DarkSlateGray { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush DarkTurquoise { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush DarkViolet { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush DeepPink { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush DeepSkyBlue { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush DimGray { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush DodgerBlue { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Firebrick { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush FloralWhite { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush ForestGreen { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Fuchsia { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Gainsboro { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush GhostWhite { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Gold { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Goldenrod { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Gray { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Green { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush GreenYellow { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Honeydew { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush HotPink { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush IndianRed { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Indigo { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Ivory { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Khaki { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Lavender { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush LavenderBlush { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush LawnGreen { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush LemonChiffon { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush LightBlue { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush LightCoral { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush LightCyan { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush LightGoldenrodYellow { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush LightGray { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush LightGreen { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush LightPink { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush LightSalmon { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush LightSeaGreen { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush LightSkyBlue { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush LightSlateGray { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush LightSteelBlue { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush LightYellow { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Lime { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush LimeGreen { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Linen { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Magenta { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Maroon { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush MediumAquamarine { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush MediumBlue { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush MediumOrchid { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush MediumPurple { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush MediumSeaGreen { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush MediumSlateBlue { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush MediumSpringGreen { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush MediumTurquoise { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush MediumVioletRed { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush MidnightBlue { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush MintCream { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush MistyRose { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Moccasin { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush NavajoWhite { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Navy { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush OldLace { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Olive { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush OliveDrab { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Orange { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush OrangeRed { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Orchid { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush PaleGoldenrod { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush PaleGreen { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush PaleTurquoise { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush PaleVioletRed { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush PapayaWhip { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush PeachPuff { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Peru { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Pink { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Plum { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush PowderBlue { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Purple { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Red { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush RosyBrown { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush RoyalBlue { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush SaddleBrown { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Salmon { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush SandyBrown { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush SeaGreen { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush SeaShell { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Sienna { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Silver { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush SkyBlue { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush SlateBlue { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush SlateGray { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Snow { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush SpringGreen { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush SteelBlue { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Tan { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Teal { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Thistle { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Tomato { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Transparent { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Turquoise { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Violet { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Wheat { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush White { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush WhiteSmoke { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Yellow { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush YellowGreen { get { return default(System.Drawing.Brush); } }
  }
  public sealed partial class BufferedGraphics : System.IDisposable {
    internal BufferedGraphics() { }
    public System.Drawing.Graphics Graphics { get { return default(System.Drawing.Graphics); } }
    public void Dispose() { }
    ~BufferedGraphics() { }
    public void Render() { }
    public void Render(System.Drawing.Graphics target) { }
    public void Render(System.IntPtr targetDC) { }
  }
  public sealed partial class BufferedGraphicsContext : System.IDisposable {
    public BufferedGraphicsContext() { }
    public System.Drawing.Size MaximumBuffer { get { return default(System.Drawing.Size); } set { } }
    public System.Drawing.BufferedGraphics Allocate(System.Drawing.Graphics targetGraphics, System.Drawing.Rectangle targetRectangle) { return default(System.Drawing.BufferedGraphics); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
    public System.Drawing.BufferedGraphics Allocate(System.IntPtr targetDC, System.Drawing.Rectangle targetRectangle) { return default(System.Drawing.BufferedGraphics); }
    public void Dispose() { }
    ~BufferedGraphicsContext() { }
    public void Invalidate() { }
  }
  public sealed partial class BufferedGraphicsManager {
    internal BufferedGraphicsManager() { }
    public static System.Drawing.BufferedGraphicsContext Current { get { return default(System.Drawing.BufferedGraphicsContext); } }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct CharacterRange {
    public CharacterRange(int First, int Length) { throw new System.NotImplementedException(); }
    public int First { get { return default(int); } set { } }
    public int Length { get { return default(int); } set { } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Drawing.CharacterRange cr1, System.Drawing.CharacterRange cr2) { return default(bool); }
    public static bool operator !=(System.Drawing.CharacterRange cr1, System.Drawing.CharacterRange cr2) { return default(bool); }
  }
  [System.ComponentModel.EditorAttribute("System.Drawing.Design.ColorEditor, System.Drawing.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(System.Drawing.Design.UITypeEditor))]
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
  [System.Diagnostics.DebuggerDisplayAttribute("{NameAndARGBValue}")]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Color {
    public static readonly System.Drawing.Color Empty;
    public byte A { get { return default(byte); } }
    public static System.Drawing.Color AliceBlue { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color AntiqueWhite { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Aqua { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Aquamarine { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Azure { get { return default(System.Drawing.Color); } }
    public byte B { get { return default(byte); } }
    public static System.Drawing.Color Beige { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Bisque { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Black { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color BlanchedAlmond { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Blue { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color BlueViolet { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Brown { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color BurlyWood { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color CadetBlue { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Chartreuse { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Chocolate { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Coral { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color CornflowerBlue { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Cornsilk { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Crimson { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Cyan { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color DarkBlue { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color DarkCyan { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color DarkGoldenrod { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color DarkGray { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color DarkGreen { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color DarkKhaki { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color DarkMagenta { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color DarkOliveGreen { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color DarkOrange { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color DarkOrchid { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color DarkRed { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color DarkSalmon { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color DarkSeaGreen { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color DarkSlateBlue { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color DarkSlateGray { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color DarkTurquoise { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color DarkViolet { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color DeepPink { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color DeepSkyBlue { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color DimGray { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color DodgerBlue { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Firebrick { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color FloralWhite { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color ForestGreen { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Fuchsia { get { return default(System.Drawing.Color); } }
    public byte G { get { return default(byte); } }
    public static System.Drawing.Color Gainsboro { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color GhostWhite { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Gold { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Goldenrod { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Gray { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Green { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color GreenYellow { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Honeydew { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color HotPink { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color IndianRed { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Indigo { get { return default(System.Drawing.Color); } }
    public bool IsEmpty { get { return default(bool); } }
    public bool IsKnownColor { get { return default(bool); } }
    public bool IsNamedColor { get { return default(bool); } }
    public bool IsSystemColor { get { return default(bool); } }
    public static System.Drawing.Color Ivory { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Khaki { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Lavender { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color LavenderBlush { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color LawnGreen { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color LemonChiffon { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color LightBlue { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color LightCoral { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color LightCyan { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color LightGoldenrodYellow { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color LightGray { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color LightGreen { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color LightPink { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color LightSalmon { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color LightSeaGreen { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color LightSkyBlue { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color LightSlateGray { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color LightSteelBlue { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color LightYellow { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Lime { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color LimeGreen { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Linen { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Magenta { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Maroon { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color MediumAquamarine { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color MediumBlue { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color MediumOrchid { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color MediumPurple { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color MediumSeaGreen { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color MediumSlateBlue { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color MediumSpringGreen { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color MediumTurquoise { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color MediumVioletRed { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color MidnightBlue { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color MintCream { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color MistyRose { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Moccasin { get { return default(System.Drawing.Color); } }
    public string Name { get { return default(string); } }
    public static System.Drawing.Color NavajoWhite { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Navy { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color OldLace { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Olive { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color OliveDrab { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Orange { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color OrangeRed { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Orchid { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color PaleGoldenrod { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color PaleGreen { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color PaleTurquoise { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color PaleVioletRed { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color PapayaWhip { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color PeachPuff { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Peru { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Pink { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Plum { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color PowderBlue { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Purple { get { return default(System.Drawing.Color); } }
    public byte R { get { return default(byte); } }
    public static System.Drawing.Color Red { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color RosyBrown { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color RoyalBlue { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color SaddleBrown { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Salmon { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color SandyBrown { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color SeaGreen { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color SeaShell { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Sienna { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Silver { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color SkyBlue { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color SlateBlue { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color SlateGray { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Snow { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color SpringGreen { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color SteelBlue { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Tan { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Teal { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Thistle { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Tomato { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Transparent { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Turquoise { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Violet { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Wheat { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color White { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color WhiteSmoke { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Yellow { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color YellowGreen { get { return default(System.Drawing.Color); } }
    public override bool Equals(object obj) { return default(bool); }
    public static System.Drawing.Color FromArgb(int argb) { return default(System.Drawing.Color); }
    public static System.Drawing.Color FromArgb(int alpha, System.Drawing.Color baseColor) { return default(System.Drawing.Color); }
    public static System.Drawing.Color FromArgb(int red, int green, int blue) { return default(System.Drawing.Color); }
    public static System.Drawing.Color FromArgb(int alpha, int red, int green, int blue) { return default(System.Drawing.Color); }
    public static System.Drawing.Color FromKnownColor(System.Drawing.KnownColor color) { return default(System.Drawing.Color); }
    public static System.Drawing.Color FromName(string name) { return default(System.Drawing.Color); }
    public float GetBrightness() { return default(float); }
    public override int GetHashCode() { return default(int); }
    public float GetHue() { return default(float); }
    public float GetSaturation() { return default(float); }
    public static bool operator ==(System.Drawing.Color left, System.Drawing.Color right) { return default(bool); }
    public static bool operator !=(System.Drawing.Color left, System.Drawing.Color right) { return default(bool); }
    public int ToArgb() { return default(int); }
    public System.Drawing.KnownColor ToKnownColor() { return default(System.Drawing.KnownColor); }
    public override string ToString() { return default(string); }
  }
  public partial class ColorConverter : System.ComponentModel.TypeConverter {
    public ColorConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
    public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { return default(System.ComponentModel.TypeConverter.StandardValuesCollection); }
    public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
  }
  public sealed partial class ColorTranslator {
    internal ColorTranslator() { }
    public static System.Drawing.Color FromHtml(string htmlColor) { return default(System.Drawing.Color); }
    public static System.Drawing.Color FromOle(int oleColor) { return default(System.Drawing.Color); }
    public static System.Drawing.Color FromWin32(int win32Color) { return default(System.Drawing.Color); }
    public static string ToHtml(System.Drawing.Color c) { return default(string); }
    public static int ToOle(System.Drawing.Color c) { return default(int); }
    public static int ToWin32(System.Drawing.Color c) { return default(int); }
  }
  [System.ComponentModel.EditorAttribute("System.Drawing.Design.ContentAlignmentEditor, System.Drawing.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(System.Drawing.Design.UITypeEditor))]
  public enum ContentAlignment {
    BottomCenter = 512,
    BottomLeft = 256,
    BottomRight = 1024,
    MiddleCenter = 32,
    MiddleLeft = 16,
    MiddleRight = 64,
    TopCenter = 2,
    TopLeft = 1,
    TopRight = 4,
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public enum CopyPixelOperation {
    Blackness = 66,
    CaptureBlt = 1073741824,
    DestinationInvert = 5570569,
    MergeCopy = 12583114,
    MergePaint = 12255782,
    NoMirrorBitmap = -2147483648,
    NotSourceCopy = 3342344,
    NotSourceErase = 1114278,
    PatCopy = 15728673,
    PatInvert = 5898313,
    PatPaint = 16452105,
    SourceAnd = 8913094,
    SourceCopy = 13369376,
    SourceErase = 4457256,
    SourceInvert = 6684742,
    SourcePaint = 15597702,
    Whiteness = 16711778,
  }
  [System.ComponentModel.EditorAttribute("System.Drawing.Design.FontEditor, System.Drawing.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(System.Drawing.Design.UITypeEditor))]
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.FontConverter))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class Font : System.MarshalByRefObject, System.ICloneable, System.IDisposable, System.Runtime.Serialization.ISerializable {
    public Font(System.Drawing.Font prototype, System.Drawing.FontStyle newStyle) { }
    public Font(System.Drawing.FontFamily family, float emSize) { }
    public Font(System.Drawing.FontFamily family, float emSize, System.Drawing.FontStyle style) { }
    public Font(System.Drawing.FontFamily family, float emSize, System.Drawing.FontStyle style, System.Drawing.GraphicsUnit unit) { }
    public Font(System.Drawing.FontFamily family, float emSize, System.Drawing.FontStyle style, System.Drawing.GraphicsUnit unit, byte gdiCharSet) { }
    public Font(System.Drawing.FontFamily family, float emSize, System.Drawing.FontStyle style, System.Drawing.GraphicsUnit unit, byte gdiCharSet, bool gdiVerticalFont) { }
    public Font(System.Drawing.FontFamily family, float emSize, System.Drawing.GraphicsUnit unit) { }
    public Font(string familyName, float emSize) { }
    public Font(string familyName, float emSize, System.Drawing.FontStyle style) { }
    public Font(string familyName, float emSize, System.Drawing.FontStyle style, System.Drawing.GraphicsUnit unit) { }
    public Font(string familyName, float emSize, System.Drawing.FontStyle style, System.Drawing.GraphicsUnit unit, byte gdiCharSet) { }
    public Font(string familyName, float emSize, System.Drawing.FontStyle style, System.Drawing.GraphicsUnit unit, byte gdiCharSet, bool gdiVerticalFont) { }
    public Font(string familyName, float emSize, System.Drawing.GraphicsUnit unit) { }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public bool Bold { get { return default(bool); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public System.Drawing.FontFamily FontFamily { get { return default(System.Drawing.FontFamily); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public byte GdiCharSet { get { return default(byte); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public bool GdiVerticalFont { get { return default(bool); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public int Height { get { return default(int); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public bool IsSystemFont { get { return default(bool); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public bool Italic { get { return default(bool); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorAttribute("System.Drawing.Design.FontNameEditor, System.Drawing.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.FontConverter.FontNameConverter))]
    public string Name { get { return default(string); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public string OriginalFontName { get { return default(string); } }
    public float Size { get { return default(float); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public float SizeInPoints { get { return default(float); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public bool Strikeout { get { return default(bool); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public System.Drawing.FontStyle Style { get { return default(System.Drawing.FontStyle); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public string SystemFontName { get { return default(string); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public bool Underline { get { return default(bool); } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.FontConverter.FontUnitConverter))]
    public System.Drawing.GraphicsUnit Unit { get { return default(System.Drawing.GraphicsUnit); } }
    public object Clone() { return default(object); }
    public void Dispose() { }
    public override bool Equals(object obj) { return default(bool); }
    ~Font() { }
    public static System.Drawing.Font FromHdc(System.IntPtr hdc) { return default(System.Drawing.Font); }
    public static System.Drawing.Font FromHfont(System.IntPtr hfont) { return default(System.Drawing.Font); }
    public static System.Drawing.Font FromLogFont(object lf) { return default(System.Drawing.Font); }
    public static System.Drawing.Font FromLogFont(object lf, System.IntPtr hdc) { return default(System.Drawing.Font); }
    public override int GetHashCode() { return default(int); }
    public float GetHeight() { return default(float); }
    public float GetHeight(System.Drawing.Graphics graphics) { return default(float); }
    public float GetHeight(float dpi) { return default(float); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(128))]
    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext context) { }
    public System.IntPtr ToHfont() { return default(System.IntPtr); }
    public void ToLogFont(object logFont) { }
    public void ToLogFont(object logFont, System.Drawing.Graphics graphics) { }
    public override string ToString() { return default(string); }
  }
  public partial class FontConverter : System.ComponentModel.TypeConverter {
    public FontConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
    public override object CreateInstance(System.ComponentModel.ITypeDescriptorContext context, System.Collections.IDictionary propertyValues) { return default(object); }
    ~FontConverter() { }
    public override bool GetCreateInstanceSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public override System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public override bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public sealed partial class FontNameConverter : System.ComponentModel.TypeConverter, System.IDisposable {
      public FontNameConverter() { }
      public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
      public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
      public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { return default(System.ComponentModel.TypeConverter.StandardValuesCollection); }
      public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
      public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
      void System.IDisposable.Dispose() { }
    }
    public partial class FontUnitConverter : System.ComponentModel.EnumConverter {
      public FontUnitConverter() : base (default(System.Type)) { }
      public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { return default(System.ComponentModel.TypeConverter.StandardValuesCollection); }
    }
  }
  public sealed partial class FontFamily : System.MarshalByRefObject, System.IDisposable {
    public FontFamily(System.Drawing.Text.GenericFontFamilies genericFamily) { }
    public FontFamily(string name) { }
    public FontFamily(string name, System.Drawing.Text.FontCollection fontCollection) { }
    public static System.Drawing.FontFamily[] Families { get { return default(System.Drawing.FontFamily[]); } }
    public static System.Drawing.FontFamily GenericMonospace { get { return default(System.Drawing.FontFamily); } }
    public static System.Drawing.FontFamily GenericSansSerif { get { return default(System.Drawing.FontFamily); } }
    public static System.Drawing.FontFamily GenericSerif { get { return default(System.Drawing.FontFamily); } }
    public string Name { get { return default(string); } }
    public void Dispose() { }
    public override bool Equals(object obj) { return default(bool); }
    ~FontFamily() { }
    public int GetCellAscent(System.Drawing.FontStyle style) { return default(int); }
    public int GetCellDescent(System.Drawing.FontStyle style) { return default(int); }
    public int GetEmHeight(System.Drawing.FontStyle style) { return default(int); }
    [System.ObsoleteAttribute("Do not use method GetFamilies, use property Families instead")]
    public static System.Drawing.FontFamily[] GetFamilies(System.Drawing.Graphics graphics) { return default(System.Drawing.FontFamily[]); }
    public override int GetHashCode() { return default(int); }
    public int GetLineSpacing(System.Drawing.FontStyle style) { return default(int); }
    public string GetName(int language) { return default(string); }
    public bool IsStyleAvailable(System.Drawing.FontStyle style) { return default(bool); }
    public override string ToString() { return default(string); }
  }
  [System.FlagsAttribute]
  public enum FontStyle {
    Bold = 1,
    Italic = 2,
    Regular = 0,
    Strikeout = 8,
    Underline = 4,
  }
  public sealed partial class Graphics : System.MarshalByRefObject, System.Drawing.IDeviceContext, System.IDisposable {
    internal Graphics() { }
    public System.Drawing.Region Clip { get { return default(System.Drawing.Region); } set { } }
    public System.Drawing.RectangleF ClipBounds { get { return default(System.Drawing.RectangleF); } }
    public System.Drawing.Drawing2D.CompositingMode CompositingMode { get { return default(System.Drawing.Drawing2D.CompositingMode); } set { } }
    public System.Drawing.Drawing2D.CompositingQuality CompositingQuality { get { return default(System.Drawing.Drawing2D.CompositingQuality); } set { } }
    public float DpiX { get { return default(float); } }
    public float DpiY { get { return default(float); } }
    public System.Drawing.Drawing2D.InterpolationMode InterpolationMode { get { return default(System.Drawing.Drawing2D.InterpolationMode); } set { } }
    public bool IsClipEmpty { get { return default(bool); } }
    public bool IsVisibleClipEmpty { get { return default(bool); } }
    public float PageScale { get { return default(float); } set { } }
    public System.Drawing.GraphicsUnit PageUnit { get { return default(System.Drawing.GraphicsUnit); } set { } }
    public System.Drawing.Drawing2D.PixelOffsetMode PixelOffsetMode { get { return default(System.Drawing.Drawing2D.PixelOffsetMode); } set { } }
    public System.Drawing.Point RenderingOrigin { get { return default(System.Drawing.Point); } set { } }
    public System.Drawing.Drawing2D.SmoothingMode SmoothingMode { get { return default(System.Drawing.Drawing2D.SmoothingMode); } set { } }
    public int TextContrast { get { return default(int); } set { } }
    public System.Drawing.Text.TextRenderingHint TextRenderingHint { get { return default(System.Drawing.Text.TextRenderingHint); } set { } }
    public System.Drawing.Drawing2D.Matrix Transform { get { return default(System.Drawing.Drawing2D.Matrix); } set { } }
    public System.Drawing.RectangleF VisibleClipBounds { get { return default(System.Drawing.RectangleF); } }
    public void AddMetafileComment(System.Byte[] data) { }
    public System.Drawing.Drawing2D.GraphicsContainer BeginContainer() { return default(System.Drawing.Drawing2D.GraphicsContainer); }
    public System.Drawing.Drawing2D.GraphicsContainer BeginContainer(System.Drawing.Rectangle dstrect, System.Drawing.Rectangle srcrect, System.Drawing.GraphicsUnit unit) { return default(System.Drawing.Drawing2D.GraphicsContainer); }
    public System.Drawing.Drawing2D.GraphicsContainer BeginContainer(System.Drawing.RectangleF dstrect, System.Drawing.RectangleF srcrect, System.Drawing.GraphicsUnit unit) { return default(System.Drawing.Drawing2D.GraphicsContainer); }
    public void Clear(System.Drawing.Color color) { }
    public void CopyFromScreen(System.Drawing.Point upperLeftSource, System.Drawing.Point upperLeftDestination, System.Drawing.Size blockRegionSize) { }
    public void CopyFromScreen(System.Drawing.Point upperLeftSource, System.Drawing.Point upperLeftDestination, System.Drawing.Size blockRegionSize, System.Drawing.CopyPixelOperation copyPixelOperation) { }
    public void CopyFromScreen(int sourceX, int sourceY, int destinationX, int destinationY, System.Drawing.Size blockRegionSize) { }
    public void CopyFromScreen(int sourceX, int sourceY, int destinationX, int destinationY, System.Drawing.Size blockRegionSize, System.Drawing.CopyPixelOperation copyPixelOperation) { }
    public void Dispose() { }
    public void DrawArc(System.Drawing.Pen pen, System.Drawing.Rectangle rect, float startAngle, float sweepAngle) { }
    public void DrawArc(System.Drawing.Pen pen, System.Drawing.RectangleF rect, float startAngle, float sweepAngle) { }
    public void DrawArc(System.Drawing.Pen pen, int x, int y, int width, int height, int startAngle, int sweepAngle) { }
    public void DrawArc(System.Drawing.Pen pen, float x, float y, float width, float height, float startAngle, float sweepAngle) { }
    public void DrawBezier(System.Drawing.Pen pen, System.Drawing.Point pt1, System.Drawing.Point pt2, System.Drawing.Point pt3, System.Drawing.Point pt4) { }
    public void DrawBezier(System.Drawing.Pen pen, System.Drawing.PointF pt1, System.Drawing.PointF pt2, System.Drawing.PointF pt3, System.Drawing.PointF pt4) { }
    public void DrawBezier(System.Drawing.Pen pen, float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4) { }
    public void DrawBeziers(System.Drawing.Pen pen, System.Drawing.Point[] points) { }
    public void DrawBeziers(System.Drawing.Pen pen, System.Drawing.PointF[] points) { }
    public void DrawClosedCurve(System.Drawing.Pen pen, System.Drawing.Point[] points) { }
    public void DrawClosedCurve(System.Drawing.Pen pen, System.Drawing.Point[] points, float tension, System.Drawing.Drawing2D.FillMode fillmode) { }
    public void DrawClosedCurve(System.Drawing.Pen pen, System.Drawing.PointF[] points) { }
    public void DrawClosedCurve(System.Drawing.Pen pen, System.Drawing.PointF[] points, float tension, System.Drawing.Drawing2D.FillMode fillmode) { }
    public void DrawCurve(System.Drawing.Pen pen, System.Drawing.Point[] points) { }
    public void DrawCurve(System.Drawing.Pen pen, System.Drawing.Point[] points, int offset, int numberOfSegments, float tension) { }
    public void DrawCurve(System.Drawing.Pen pen, System.Drawing.Point[] points, float tension) { }
    public void DrawCurve(System.Drawing.Pen pen, System.Drawing.PointF[] points) { }
    public void DrawCurve(System.Drawing.Pen pen, System.Drawing.PointF[] points, int offset, int numberOfSegments) { }
    public void DrawCurve(System.Drawing.Pen pen, System.Drawing.PointF[] points, int offset, int numberOfSegments, float tension) { }
    public void DrawCurve(System.Drawing.Pen pen, System.Drawing.PointF[] points, float tension) { }
    public void DrawEllipse(System.Drawing.Pen pen, System.Drawing.Rectangle rect) { }
    public void DrawEllipse(System.Drawing.Pen pen, System.Drawing.RectangleF rect) { }
    public void DrawEllipse(System.Drawing.Pen pen, int x, int y, int width, int height) { }
    public void DrawEllipse(System.Drawing.Pen pen, float x, float y, float width, float height) { }
    public void DrawIcon(System.Drawing.Icon icon, System.Drawing.Rectangle targetRect) { }
    public void DrawIcon(System.Drawing.Icon icon, int x, int y) { }
    public void DrawIconUnstretched(System.Drawing.Icon icon, System.Drawing.Rectangle targetRect) { }
    public void DrawImage(System.Drawing.Image image, System.Drawing.Point point) { }
    public void DrawImage(System.Drawing.Image image, System.Drawing.Point[] destPoints) { }
    public void DrawImage(System.Drawing.Image image, System.Drawing.Point[] destPoints, System.Drawing.Rectangle srcRect, System.Drawing.GraphicsUnit srcUnit) { }
    public void DrawImage(System.Drawing.Image image, System.Drawing.Point[] destPoints, System.Drawing.Rectangle srcRect, System.Drawing.GraphicsUnit srcUnit, System.Drawing.Imaging.ImageAttributes imageAttr) { }
    public void DrawImage(System.Drawing.Image image, System.Drawing.Point[] destPoints, System.Drawing.Rectangle srcRect, System.Drawing.GraphicsUnit srcUnit, System.Drawing.Imaging.ImageAttributes imageAttr, System.Drawing.Graphics.DrawImageAbort callback) { }
    public void DrawImage(System.Drawing.Image image, System.Drawing.Point[] destPoints, System.Drawing.Rectangle srcRect, System.Drawing.GraphicsUnit srcUnit, System.Drawing.Imaging.ImageAttributes imageAttr, System.Drawing.Graphics.DrawImageAbort callback, int callbackData) { }
    public void DrawImage(System.Drawing.Image image, System.Drawing.PointF point) { }
    public void DrawImage(System.Drawing.Image image, System.Drawing.PointF[] destPoints) { }
    public void DrawImage(System.Drawing.Image image, System.Drawing.PointF[] destPoints, System.Drawing.RectangleF srcRect, System.Drawing.GraphicsUnit srcUnit) { }
    public void DrawImage(System.Drawing.Image image, System.Drawing.PointF[] destPoints, System.Drawing.RectangleF srcRect, System.Drawing.GraphicsUnit srcUnit, System.Drawing.Imaging.ImageAttributes imageAttr) { }
    public void DrawImage(System.Drawing.Image image, System.Drawing.PointF[] destPoints, System.Drawing.RectangleF srcRect, System.Drawing.GraphicsUnit srcUnit, System.Drawing.Imaging.ImageAttributes imageAttr, System.Drawing.Graphics.DrawImageAbort callback) { }
    public void DrawImage(System.Drawing.Image image, System.Drawing.PointF[] destPoints, System.Drawing.RectangleF srcRect, System.Drawing.GraphicsUnit srcUnit, System.Drawing.Imaging.ImageAttributes imageAttr, System.Drawing.Graphics.DrawImageAbort callback, int callbackData) { }
    public void DrawImage(System.Drawing.Image image, System.Drawing.Rectangle rect) { }
    public void DrawImage(System.Drawing.Image image, System.Drawing.Rectangle destRect, System.Drawing.Rectangle srcRect, System.Drawing.GraphicsUnit srcUnit) { }
    public void DrawImage(System.Drawing.Image image, System.Drawing.Rectangle destRect, int srcX, int srcY, int srcWidth, int srcHeight, System.Drawing.GraphicsUnit srcUnit) { }
    public void DrawImage(System.Drawing.Image image, System.Drawing.Rectangle destRect, int srcX, int srcY, int srcWidth, int srcHeight, System.Drawing.GraphicsUnit srcUnit, System.Drawing.Imaging.ImageAttributes imageAttr) { }
    public void DrawImage(System.Drawing.Image image, System.Drawing.Rectangle destRect, int srcX, int srcY, int srcWidth, int srcHeight, System.Drawing.GraphicsUnit srcUnit, System.Drawing.Imaging.ImageAttributes imageAttr, System.Drawing.Graphics.DrawImageAbort callback) { }
    public void DrawImage(System.Drawing.Image image, System.Drawing.Rectangle destRect, int srcX, int srcY, int srcWidth, int srcHeight, System.Drawing.GraphicsUnit srcUnit, System.Drawing.Imaging.ImageAttributes imageAttrs, System.Drawing.Graphics.DrawImageAbort callback, System.IntPtr callbackData) { }
    public void DrawImage(System.Drawing.Image image, System.Drawing.Rectangle destRect, float srcX, float srcY, float srcWidth, float srcHeight, System.Drawing.GraphicsUnit srcUnit) { }
    public void DrawImage(System.Drawing.Image image, System.Drawing.Rectangle destRect, float srcX, float srcY, float srcWidth, float srcHeight, System.Drawing.GraphicsUnit srcUnit, System.Drawing.Imaging.ImageAttributes imageAttrs) { }
    public void DrawImage(System.Drawing.Image image, System.Drawing.Rectangle destRect, float srcX, float srcY, float srcWidth, float srcHeight, System.Drawing.GraphicsUnit srcUnit, System.Drawing.Imaging.ImageAttributes imageAttrs, System.Drawing.Graphics.DrawImageAbort callback) { }
    public void DrawImage(System.Drawing.Image image, System.Drawing.Rectangle destRect, float srcX, float srcY, float srcWidth, float srcHeight, System.Drawing.GraphicsUnit srcUnit, System.Drawing.Imaging.ImageAttributes imageAttrs, System.Drawing.Graphics.DrawImageAbort callback, System.IntPtr callbackData) { }
    public void DrawImage(System.Drawing.Image image, System.Drawing.RectangleF rect) { }
    public void DrawImage(System.Drawing.Image image, System.Drawing.RectangleF destRect, System.Drawing.RectangleF srcRect, System.Drawing.GraphicsUnit srcUnit) { }
    public void DrawImage(System.Drawing.Image image, int x, int y) { }
    public void DrawImage(System.Drawing.Image image, int x, int y, System.Drawing.Rectangle srcRect, System.Drawing.GraphicsUnit srcUnit) { }
    public void DrawImage(System.Drawing.Image image, int x, int y, int width, int height) { }
    public void DrawImage(System.Drawing.Image image, float x, float y) { }
    public void DrawImage(System.Drawing.Image image, float x, float y, System.Drawing.RectangleF srcRect, System.Drawing.GraphicsUnit srcUnit) { }
    public void DrawImage(System.Drawing.Image image, float x, float y, float width, float height) { }
    public void DrawImageUnscaled(System.Drawing.Image image, System.Drawing.Point point) { }
    public void DrawImageUnscaled(System.Drawing.Image image, System.Drawing.Rectangle rect) { }
    public void DrawImageUnscaled(System.Drawing.Image image, int x, int y) { }
    public void DrawImageUnscaled(System.Drawing.Image image, int x, int y, int width, int height) { }
    public void DrawImageUnscaledAndClipped(System.Drawing.Image image, System.Drawing.Rectangle rect) { }
    public void DrawLine(System.Drawing.Pen pen, System.Drawing.Point pt1, System.Drawing.Point pt2) { }
    public void DrawLine(System.Drawing.Pen pen, System.Drawing.PointF pt1, System.Drawing.PointF pt2) { }
    public void DrawLine(System.Drawing.Pen pen, int x1, int y1, int x2, int y2) { }
    public void DrawLine(System.Drawing.Pen pen, float x1, float y1, float x2, float y2) { }
    public void DrawLines(System.Drawing.Pen pen, System.Drawing.Point[] points) { }
    public void DrawLines(System.Drawing.Pen pen, System.Drawing.PointF[] points) { }
    public void DrawPath(System.Drawing.Pen pen, System.Drawing.Drawing2D.GraphicsPath path) { }
    public void DrawPie(System.Drawing.Pen pen, System.Drawing.Rectangle rect, float startAngle, float sweepAngle) { }
    public void DrawPie(System.Drawing.Pen pen, System.Drawing.RectangleF rect, float startAngle, float sweepAngle) { }
    public void DrawPie(System.Drawing.Pen pen, int x, int y, int width, int height, int startAngle, int sweepAngle) { }
    public void DrawPie(System.Drawing.Pen pen, float x, float y, float width, float height, float startAngle, float sweepAngle) { }
    public void DrawPolygon(System.Drawing.Pen pen, System.Drawing.Point[] points) { }
    public void DrawPolygon(System.Drawing.Pen pen, System.Drawing.PointF[] points) { }
    public void DrawRectangle(System.Drawing.Pen pen, System.Drawing.Rectangle rect) { }
    public void DrawRectangle(System.Drawing.Pen pen, int x, int y, int width, int height) { }
    public void DrawRectangle(System.Drawing.Pen pen, float x, float y, float width, float height) { }
    public void DrawRectangles(System.Drawing.Pen pen, System.Drawing.Rectangle[] rects) { }
    public void DrawRectangles(System.Drawing.Pen pen, System.Drawing.RectangleF[] rects) { }
    public void DrawString(string s, System.Drawing.Font font, System.Drawing.Brush brush, System.Drawing.PointF point) { }
    public void DrawString(string s, System.Drawing.Font font, System.Drawing.Brush brush, System.Drawing.PointF point, System.Drawing.StringFormat format) { }
    public void DrawString(string s, System.Drawing.Font font, System.Drawing.Brush brush, System.Drawing.RectangleF layoutRectangle) { }
    public void DrawString(string s, System.Drawing.Font font, System.Drawing.Brush brush, System.Drawing.RectangleF layoutRectangle, System.Drawing.StringFormat format) { }
    public void DrawString(string s, System.Drawing.Font font, System.Drawing.Brush brush, float x, float y) { }
    public void DrawString(string s, System.Drawing.Font font, System.Drawing.Brush brush, float x, float y, System.Drawing.StringFormat format) { }
    public void EndContainer(System.Drawing.Drawing2D.GraphicsContainer container) { }
    public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, System.Drawing.Point destPoint, System.Drawing.Graphics.EnumerateMetafileProc callback) { }
    public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, System.Drawing.Point destPoint, System.Drawing.Graphics.EnumerateMetafileProc callback, System.IntPtr callbackData) { }
    public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, System.Drawing.Point destPoint, System.Drawing.Graphics.EnumerateMetafileProc callback, System.IntPtr callbackData, System.Drawing.Imaging.ImageAttributes imageAttr) { }
    public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, System.Drawing.Point destPoint, System.Drawing.Rectangle srcRect, System.Drawing.GraphicsUnit srcUnit, System.Drawing.Graphics.EnumerateMetafileProc callback) { }
    public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, System.Drawing.Point destPoint, System.Drawing.Rectangle srcRect, System.Drawing.GraphicsUnit srcUnit, System.Drawing.Graphics.EnumerateMetafileProc callback, System.IntPtr callbackData) { }
    public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, System.Drawing.Point destPoint, System.Drawing.Rectangle srcRect, System.Drawing.GraphicsUnit unit, System.Drawing.Graphics.EnumerateMetafileProc callback, System.IntPtr callbackData, System.Drawing.Imaging.ImageAttributes imageAttr) { }
    public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, System.Drawing.Point[] destPoints, System.Drawing.Graphics.EnumerateMetafileProc callback) { }
    public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, System.Drawing.Point[] destPoints, System.Drawing.Graphics.EnumerateMetafileProc callback, System.IntPtr callbackData) { }
    public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, System.Drawing.Point[] destPoints, System.Drawing.Graphics.EnumerateMetafileProc callback, System.IntPtr callbackData, System.Drawing.Imaging.ImageAttributes imageAttr) { }
    public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, System.Drawing.Point[] destPoints, System.Drawing.Rectangle srcRect, System.Drawing.GraphicsUnit srcUnit, System.Drawing.Graphics.EnumerateMetafileProc callback) { }
    public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, System.Drawing.Point[] destPoints, System.Drawing.Rectangle srcRect, System.Drawing.GraphicsUnit srcUnit, System.Drawing.Graphics.EnumerateMetafileProc callback, System.IntPtr callbackData) { }
    public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, System.Drawing.Point[] destPoints, System.Drawing.Rectangle srcRect, System.Drawing.GraphicsUnit unit, System.Drawing.Graphics.EnumerateMetafileProc callback, System.IntPtr callbackData, System.Drawing.Imaging.ImageAttributes imageAttr) { }
    public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, System.Drawing.PointF destPoint, System.Drawing.Graphics.EnumerateMetafileProc callback) { }
    public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, System.Drawing.PointF destPoint, System.Drawing.Graphics.EnumerateMetafileProc callback, System.IntPtr callbackData) { }
    public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, System.Drawing.PointF destPoint, System.Drawing.Graphics.EnumerateMetafileProc callback, System.IntPtr callbackData, System.Drawing.Imaging.ImageAttributes imageAttr) { }
    public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, System.Drawing.PointF destPoint, System.Drawing.RectangleF srcRect, System.Drawing.GraphicsUnit srcUnit, System.Drawing.Graphics.EnumerateMetafileProc callback) { }
    public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, System.Drawing.PointF destPoint, System.Drawing.RectangleF srcRect, System.Drawing.GraphicsUnit srcUnit, System.Drawing.Graphics.EnumerateMetafileProc callback, System.IntPtr callbackData) { }
    public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, System.Drawing.PointF destPoint, System.Drawing.RectangleF srcRect, System.Drawing.GraphicsUnit unit, System.Drawing.Graphics.EnumerateMetafileProc callback, System.IntPtr callbackData, System.Drawing.Imaging.ImageAttributes imageAttr) { }
    public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, System.Drawing.PointF[] destPoints, System.Drawing.Graphics.EnumerateMetafileProc callback) { }
    public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, System.Drawing.PointF[] destPoints, System.Drawing.Graphics.EnumerateMetafileProc callback, System.IntPtr callbackData) { }
    public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, System.Drawing.PointF[] destPoints, System.Drawing.Graphics.EnumerateMetafileProc callback, System.IntPtr callbackData, System.Drawing.Imaging.ImageAttributes imageAttr) { }
    public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, System.Drawing.PointF[] destPoints, System.Drawing.RectangleF srcRect, System.Drawing.GraphicsUnit srcUnit, System.Drawing.Graphics.EnumerateMetafileProc callback) { }
    public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, System.Drawing.PointF[] destPoints, System.Drawing.RectangleF srcRect, System.Drawing.GraphicsUnit srcUnit, System.Drawing.Graphics.EnumerateMetafileProc callback, System.IntPtr callbackData) { }
    public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, System.Drawing.PointF[] destPoints, System.Drawing.RectangleF srcRect, System.Drawing.GraphicsUnit unit, System.Drawing.Graphics.EnumerateMetafileProc callback, System.IntPtr callbackData, System.Drawing.Imaging.ImageAttributes imageAttr) { }
    public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, System.Drawing.Rectangle destRect, System.Drawing.Graphics.EnumerateMetafileProc callback) { }
    public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, System.Drawing.Rectangle destRect, System.Drawing.Graphics.EnumerateMetafileProc callback, System.IntPtr callbackData) { }
    public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, System.Drawing.Rectangle destRect, System.Drawing.Graphics.EnumerateMetafileProc callback, System.IntPtr callbackData, System.Drawing.Imaging.ImageAttributes imageAttr) { }
    public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, System.Drawing.Rectangle destRect, System.Drawing.Rectangle srcRect, System.Drawing.GraphicsUnit srcUnit, System.Drawing.Graphics.EnumerateMetafileProc callback) { }
    public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, System.Drawing.Rectangle destRect, System.Drawing.Rectangle srcRect, System.Drawing.GraphicsUnit srcUnit, System.Drawing.Graphics.EnumerateMetafileProc callback, System.IntPtr callbackData) { }
    public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, System.Drawing.Rectangle destRect, System.Drawing.Rectangle srcRect, System.Drawing.GraphicsUnit unit, System.Drawing.Graphics.EnumerateMetafileProc callback, System.IntPtr callbackData, System.Drawing.Imaging.ImageAttributes imageAttr) { }
    public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, System.Drawing.RectangleF destRect, System.Drawing.Graphics.EnumerateMetafileProc callback) { }
    public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, System.Drawing.RectangleF destRect, System.Drawing.Graphics.EnumerateMetafileProc callback, System.IntPtr callbackData) { }
    public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, System.Drawing.RectangleF destRect, System.Drawing.Graphics.EnumerateMetafileProc callback, System.IntPtr callbackData, System.Drawing.Imaging.ImageAttributes imageAttr) { }
    public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, System.Drawing.RectangleF destRect, System.Drawing.RectangleF srcRect, System.Drawing.GraphicsUnit srcUnit, System.Drawing.Graphics.EnumerateMetafileProc callback) { }
    public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, System.Drawing.RectangleF destRect, System.Drawing.RectangleF srcRect, System.Drawing.GraphicsUnit srcUnit, System.Drawing.Graphics.EnumerateMetafileProc callback, System.IntPtr callbackData) { }
    public void EnumerateMetafile(System.Drawing.Imaging.Metafile metafile, System.Drawing.RectangleF destRect, System.Drawing.RectangleF srcRect, System.Drawing.GraphicsUnit unit, System.Drawing.Graphics.EnumerateMetafileProc callback, System.IntPtr callbackData, System.Drawing.Imaging.ImageAttributes imageAttr) { }
    public void ExcludeClip(System.Drawing.Rectangle rect) { }
    public void ExcludeClip(System.Drawing.Region region) { }
    public void FillClosedCurve(System.Drawing.Brush brush, System.Drawing.Point[] points) { }
    public void FillClosedCurve(System.Drawing.Brush brush, System.Drawing.Point[] points, System.Drawing.Drawing2D.FillMode fillmode) { }
    public void FillClosedCurve(System.Drawing.Brush brush, System.Drawing.Point[] points, System.Drawing.Drawing2D.FillMode fillmode, float tension) { }
    public void FillClosedCurve(System.Drawing.Brush brush, System.Drawing.PointF[] points) { }
    public void FillClosedCurve(System.Drawing.Brush brush, System.Drawing.PointF[] points, System.Drawing.Drawing2D.FillMode fillmode) { }
    public void FillClosedCurve(System.Drawing.Brush brush, System.Drawing.PointF[] points, System.Drawing.Drawing2D.FillMode fillmode, float tension) { }
    public void FillEllipse(System.Drawing.Brush brush, System.Drawing.Rectangle rect) { }
    public void FillEllipse(System.Drawing.Brush brush, System.Drawing.RectangleF rect) { }
    public void FillEllipse(System.Drawing.Brush brush, int x, int y, int width, int height) { }
    public void FillEllipse(System.Drawing.Brush brush, float x, float y, float width, float height) { }
    public void FillPath(System.Drawing.Brush brush, System.Drawing.Drawing2D.GraphicsPath path) { }
    public void FillPie(System.Drawing.Brush brush, System.Drawing.Rectangle rect, float startAngle, float sweepAngle) { }
    public void FillPie(System.Drawing.Brush brush, int x, int y, int width, int height, int startAngle, int sweepAngle) { }
    public void FillPie(System.Drawing.Brush brush, float x, float y, float width, float height, float startAngle, float sweepAngle) { }
    public void FillPolygon(System.Drawing.Brush brush, System.Drawing.Point[] points) { }
    public void FillPolygon(System.Drawing.Brush brush, System.Drawing.Point[] points, System.Drawing.Drawing2D.FillMode fillMode) { }
    public void FillPolygon(System.Drawing.Brush brush, System.Drawing.PointF[] points) { }
    public void FillPolygon(System.Drawing.Brush brush, System.Drawing.PointF[] points, System.Drawing.Drawing2D.FillMode fillMode) { }
    public void FillRectangle(System.Drawing.Brush brush, System.Drawing.Rectangle rect) { }
    public void FillRectangle(System.Drawing.Brush brush, System.Drawing.RectangleF rect) { }
    public void FillRectangle(System.Drawing.Brush brush, int x, int y, int width, int height) { }
    public void FillRectangle(System.Drawing.Brush brush, float x, float y, float width, float height) { }
    public void FillRectangles(System.Drawing.Brush brush, System.Drawing.Rectangle[] rects) { }
    public void FillRectangles(System.Drawing.Brush brush, System.Drawing.RectangleF[] rects) { }
    public void FillRegion(System.Drawing.Brush brush, System.Drawing.Region region) { }
    ~Graphics() { }
    public void Flush() { }
    public void Flush(System.Drawing.Drawing2D.FlushIntention intention) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static System.Drawing.Graphics FromHdc(System.IntPtr hdc) { return default(System.Drawing.Graphics); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static System.Drawing.Graphics FromHdc(System.IntPtr hdc, System.IntPtr hdevice) { return default(System.Drawing.Graphics); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
    public static System.Drawing.Graphics FromHdcInternal(System.IntPtr hdc) { return default(System.Drawing.Graphics); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static System.Drawing.Graphics FromHwnd(System.IntPtr hwnd) { return default(System.Drawing.Graphics); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
    public static System.Drawing.Graphics FromHwndInternal(System.IntPtr hwnd) { return default(System.Drawing.Graphics); }
    public static System.Drawing.Graphics FromImage(System.Drawing.Image image) { return default(System.Drawing.Graphics); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Security.Permissions.StrongNameIdentityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="System.Windows.Forms", PublicKey="0x00000000000000000400000000000000")]
    public object GetContextInfo() { return default(object); }
    public static System.IntPtr GetHalftonePalette() { return default(System.IntPtr); }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
    public System.IntPtr GetHdc() { return default(System.IntPtr); }
    public System.Drawing.Color GetNearestColor(System.Drawing.Color color) { return default(System.Drawing.Color); }
    public void IntersectClip(System.Drawing.Rectangle rect) { }
    public void IntersectClip(System.Drawing.RectangleF rect) { }
    public void IntersectClip(System.Drawing.Region region) { }
    public bool IsVisible(System.Drawing.Point point) { return default(bool); }
    public bool IsVisible(System.Drawing.PointF point) { return default(bool); }
    public bool IsVisible(System.Drawing.Rectangle rect) { return default(bool); }
    public bool IsVisible(System.Drawing.RectangleF rect) { return default(bool); }
    public bool IsVisible(int x, int y) { return default(bool); }
    public bool IsVisible(int x, int y, int width, int height) { return default(bool); }
    public bool IsVisible(float x, float y) { return default(bool); }
    public bool IsVisible(float x, float y, float width, float height) { return default(bool); }
    public System.Drawing.Region[] MeasureCharacterRanges(string text, System.Drawing.Font font, System.Drawing.RectangleF layoutRect, System.Drawing.StringFormat stringFormat) { return default(System.Drawing.Region[]); }
    public System.Drawing.SizeF MeasureString(string text, System.Drawing.Font font) { return default(System.Drawing.SizeF); }
    public System.Drawing.SizeF MeasureString(string text, System.Drawing.Font font, System.Drawing.PointF origin, System.Drawing.StringFormat stringFormat) { return default(System.Drawing.SizeF); }
    public System.Drawing.SizeF MeasureString(string text, System.Drawing.Font font, System.Drawing.SizeF layoutArea) { return default(System.Drawing.SizeF); }
    public System.Drawing.SizeF MeasureString(string text, System.Drawing.Font font, System.Drawing.SizeF layoutArea, System.Drawing.StringFormat stringFormat) { return default(System.Drawing.SizeF); }
    public System.Drawing.SizeF MeasureString(string text, System.Drawing.Font font, System.Drawing.SizeF layoutArea, System.Drawing.StringFormat stringFormat, out int charactersFitted, out int linesFilled) { charactersFitted = default(int); linesFilled = default(int); return default(System.Drawing.SizeF); }
    public System.Drawing.SizeF MeasureString(string text, System.Drawing.Font font, int width) { return default(System.Drawing.SizeF); }
    public System.Drawing.SizeF MeasureString(string text, System.Drawing.Font font, int width, System.Drawing.StringFormat format) { return default(System.Drawing.SizeF); }
    public void MultiplyTransform(System.Drawing.Drawing2D.Matrix matrix) { }
    public void MultiplyTransform(System.Drawing.Drawing2D.Matrix matrix, System.Drawing.Drawing2D.MatrixOrder order) { }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
    public void ReleaseHdc() { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public void ReleaseHdc(System.IntPtr hdc) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
    public void ReleaseHdcInternal(System.IntPtr hdc) { }
    public void ResetClip() { }
    public void ResetTransform() { }
    public void Restore(System.Drawing.Drawing2D.GraphicsState gstate) { }
    public void RotateTransform(float angle) { }
    public void RotateTransform(float angle, System.Drawing.Drawing2D.MatrixOrder order) { }
    public System.Drawing.Drawing2D.GraphicsState Save() { return default(System.Drawing.Drawing2D.GraphicsState); }
    public void ScaleTransform(float sx, float sy) { }
    public void ScaleTransform(float sx, float sy, System.Drawing.Drawing2D.MatrixOrder order) { }
    public void SetClip(System.Drawing.Drawing2D.GraphicsPath path) { }
    public void SetClip(System.Drawing.Drawing2D.GraphicsPath path, System.Drawing.Drawing2D.CombineMode combineMode) { }
    public void SetClip(System.Drawing.Graphics g) { }
    public void SetClip(System.Drawing.Graphics g, System.Drawing.Drawing2D.CombineMode combineMode) { }
    public void SetClip(System.Drawing.Rectangle rect) { }
    public void SetClip(System.Drawing.Rectangle rect, System.Drawing.Drawing2D.CombineMode combineMode) { }
    public void SetClip(System.Drawing.RectangleF rect) { }
    public void SetClip(System.Drawing.RectangleF rect, System.Drawing.Drawing2D.CombineMode combineMode) { }
    public void SetClip(System.Drawing.Region region, System.Drawing.Drawing2D.CombineMode combineMode) { }
    public void TransformPoints(System.Drawing.Drawing2D.CoordinateSpace destSpace, System.Drawing.Drawing2D.CoordinateSpace srcSpace, System.Drawing.Point[] pts) { }
    public void TransformPoints(System.Drawing.Drawing2D.CoordinateSpace destSpace, System.Drawing.Drawing2D.CoordinateSpace srcSpace, System.Drawing.PointF[] pts) { }
    public void TranslateClip(int dx, int dy) { }
    public void TranslateClip(float dx, float dy) { }
    public void TranslateTransform(float dx, float dy) { }
    public void TranslateTransform(float dx, float dy, System.Drawing.Drawing2D.MatrixOrder order) { }
    public delegate bool DrawImageAbort(System.IntPtr callbackdata);
    public delegate bool EnumerateMetafileProc(System.Drawing.Imaging.EmfPlusRecordType recordType, int flags, int dataSize, System.IntPtr data, System.Drawing.Imaging.PlayRecordCallback callbackData);
  }
  public enum GraphicsUnit {
    Display = 1,
    Document = 5,
    Inch = 4,
    Millimeter = 6,
    Pixel = 2,
    Point = 3,
    World = 0,
  }
  [System.ComponentModel.EditorAttribute("System.Drawing.Design.IconEditor, System.Drawing.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(System.Drawing.Design.UITypeEditor))]
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.IconConverter))]
  public sealed partial class Icon : System.MarshalByRefObject, System.ICloneable, System.IDisposable, System.Runtime.Serialization.ISerializable {
    public Icon(System.Drawing.Icon original, System.Drawing.Size size) { }
    public Icon(System.Drawing.Icon original, int width, int height) { }
    public Icon(System.IO.Stream stream) { }
    public Icon(System.IO.Stream stream, System.Drawing.Size size) { }
    public Icon(System.IO.Stream stream, int width, int height) { }
    public Icon(string fileName) { }
    public Icon(string fileName, System.Drawing.Size size) { }
    public Icon(string fileName, int width, int height) { }
    public Icon(System.Type type, string resource) { }
    [System.ComponentModel.BrowsableAttribute(false)]
    public System.IntPtr Handle { get { return default(System.IntPtr); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public int Height { get { return default(int); } }
    public System.Drawing.Size Size { get { return default(System.Drawing.Size); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public int Width { get { return default(int); } }
    public object Clone() { return default(object); }
    public void Dispose() { }
    public static System.Drawing.Icon ExtractAssociatedIcon(string filePath) { return default(System.Drawing.Icon); }
    ~Icon() { }
    public static System.Drawing.Icon FromHandle(System.IntPtr handle) { return default(System.Drawing.Icon); }
    public void Save(System.IO.Stream outputStream) { }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(128))]
    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext context) { }
    public System.Drawing.Bitmap ToBitmap() { return default(System.Drawing.Bitmap); }
    public override string ToString() { return default(string); }
  }
  public partial class IconConverter : System.ComponentModel.ExpandableObjectConverter {
    public IconConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
  }
  public partial interface IDeviceContext : System.IDisposable {
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
    System.IntPtr GetHdc();
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
    void ReleaseHdc();
  }
  [System.ComponentModel.EditorAttribute("System.Drawing.Design.ImageEditor, System.Drawing.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(System.Drawing.Design.UITypeEditor))]
  [System.ComponentModel.ImmutableObjectAttribute(true)]
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ImageConverter))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public abstract partial class Image : System.MarshalByRefObject, System.ICloneable, System.IDisposable, System.Runtime.Serialization.ISerializable {
    internal Image() { }
    [System.ComponentModel.BrowsableAttribute(false)]
    public int Flags { get { return default(int); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public System.Guid[] FrameDimensionsList { get { return default(System.Guid[]); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public int Height { get { return default(int); } }
    public float HorizontalResolution { get { return default(float); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public System.Drawing.Imaging.ColorPalette Palette { get { return default(System.Drawing.Imaging.ColorPalette); } set { } }
    public System.Drawing.SizeF PhysicalDimension { get { return default(System.Drawing.SizeF); } }
    public System.Drawing.Imaging.PixelFormat PixelFormat { get { return default(System.Drawing.Imaging.PixelFormat); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public System.Int32[] PropertyIdList { get { return default(System.Int32[]); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public System.Drawing.Imaging.PropertyItem[] PropertyItems { get { return default(System.Drawing.Imaging.PropertyItem[]); } }
    public System.Drawing.Imaging.ImageFormat RawFormat { get { return default(System.Drawing.Imaging.ImageFormat); } }
    public System.Drawing.Size Size { get { return default(System.Drawing.Size); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.LocalizableAttribute(false)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.StringConverter))]
    public object Tag { get { return default(object); } set { } }
    public float VerticalResolution { get { return default(float); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public int Width { get { return default(int); } }
    public object Clone() { return default(object); }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    ~Image() { }
    public static System.Drawing.Image FromFile(string filename) { return default(System.Drawing.Image); }
    public static System.Drawing.Image FromFile(string filename, bool useEmbeddedColorManagement) { return default(System.Drawing.Image); }
    public static System.Drawing.Bitmap FromHbitmap(System.IntPtr hbitmap) { return default(System.Drawing.Bitmap); }
    public static System.Drawing.Bitmap FromHbitmap(System.IntPtr hbitmap, System.IntPtr hpalette) { return default(System.Drawing.Bitmap); }
    public static System.Drawing.Image FromStream(System.IO.Stream stream) { return default(System.Drawing.Image); }
    public static System.Drawing.Image FromStream(System.IO.Stream stream, bool useEmbeddedColorManagement) { return default(System.Drawing.Image); }
    public static System.Drawing.Image FromStream(System.IO.Stream stream, bool useEmbeddedColorManagement, bool validateImageData) { return default(System.Drawing.Image); }
    public System.Drawing.RectangleF GetBounds(ref System.Drawing.GraphicsUnit pageUnit) { return default(System.Drawing.RectangleF); }
    public System.Drawing.Imaging.EncoderParameters GetEncoderParameterList(System.Guid encoder) { return default(System.Drawing.Imaging.EncoderParameters); }
    public int GetFrameCount(System.Drawing.Imaging.FrameDimension dimension) { return default(int); }
    public static int GetPixelFormatSize(System.Drawing.Imaging.PixelFormat pixfmt) { return default(int); }
    public System.Drawing.Imaging.PropertyItem GetPropertyItem(int propid) { return default(System.Drawing.Imaging.PropertyItem); }
    public System.Drawing.Image GetThumbnailImage(int thumbWidth, int thumbHeight, System.Drawing.Image.GetThumbnailImageAbort callback, System.IntPtr callbackData) { return default(System.Drawing.Image); }
    public static bool IsAlphaPixelFormat(System.Drawing.Imaging.PixelFormat pixfmt) { return default(bool); }
    public static bool IsCanonicalPixelFormat(System.Drawing.Imaging.PixelFormat pixfmt) { return default(bool); }
    public static bool IsExtendedPixelFormat(System.Drawing.Imaging.PixelFormat pixfmt) { return default(bool); }
    public void RemovePropertyItem(int propid) { }
    public void RotateFlip(System.Drawing.RotateFlipType rotateFlipType) { }
    public void Save(System.IO.Stream stream, System.Drawing.Imaging.ImageCodecInfo encoder, System.Drawing.Imaging.EncoderParameters encoderParams) { }
    public void Save(System.IO.Stream stream, System.Drawing.Imaging.ImageFormat format) { }
    public void Save(string filename) { }
    public void Save(string filename, System.Drawing.Imaging.ImageCodecInfo encoder, System.Drawing.Imaging.EncoderParameters encoderParams) { }
    public void Save(string filename, System.Drawing.Imaging.ImageFormat format) { }
    public void SaveAdd(System.Drawing.Image image, System.Drawing.Imaging.EncoderParameters encoderParams) { }
    public void SaveAdd(System.Drawing.Imaging.EncoderParameters encoderParams) { }
    public int SelectActiveFrame(System.Drawing.Imaging.FrameDimension dimension, int frameIndex) { return default(int); }
    public void SetPropertyItem(System.Drawing.Imaging.PropertyItem propitem) { }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(128))]
    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext context) { }
    public delegate bool GetThumbnailImageAbort();
  }
  public sealed partial class ImageAnimator {
    internal ImageAnimator() { }
    public static void Animate(System.Drawing.Image image, System.EventHandler onFrameChangedHandler) { }
    public static bool CanAnimate(System.Drawing.Image image) { return default(bool); }
    public static void StopAnimate(System.Drawing.Image image, System.EventHandler onFrameChangedHandler) { }
    public static void UpdateFrames() { }
    public static void UpdateFrames(System.Drawing.Image image) { }
  }
  public partial class ImageConverter : System.ComponentModel.TypeConverter {
    public ImageConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
    public override System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public override bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
  }
  public partial class ImageFormatConverter : System.ComponentModel.TypeConverter {
    public ImageFormatConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
    public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { return default(System.ComponentModel.TypeConverter.StandardValuesCollection); }
    public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
  }
  public enum KnownColor {
    ActiveBorder = 1,
    ActiveCaption = 2,
    ActiveCaptionText = 3,
    AliceBlue = 28,
    AntiqueWhite = 29,
    AppWorkspace = 4,
    Aqua = 30,
    Aquamarine = 31,
    Azure = 32,
    Beige = 33,
    Bisque = 34,
    Black = 35,
    BlanchedAlmond = 36,
    Blue = 37,
    BlueViolet = 38,
    Brown = 39,
    BurlyWood = 40,
    ButtonFace = 168,
    ButtonHighlight = 169,
    ButtonShadow = 170,
    CadetBlue = 41,
    Chartreuse = 42,
    Chocolate = 43,
    Control = 5,
    ControlDark = 6,
    ControlDarkDark = 7,
    ControlLight = 8,
    ControlLightLight = 9,
    ControlText = 10,
    Coral = 44,
    CornflowerBlue = 45,
    Cornsilk = 46,
    Crimson = 47,
    Cyan = 48,
    DarkBlue = 49,
    DarkCyan = 50,
    DarkGoldenrod = 51,
    DarkGray = 52,
    DarkGreen = 53,
    DarkKhaki = 54,
    DarkMagenta = 55,
    DarkOliveGreen = 56,
    DarkOrange = 57,
    DarkOrchid = 58,
    DarkRed = 59,
    DarkSalmon = 60,
    DarkSeaGreen = 61,
    DarkSlateBlue = 62,
    DarkSlateGray = 63,
    DarkTurquoise = 64,
    DarkViolet = 65,
    DeepPink = 66,
    DeepSkyBlue = 67,
    Desktop = 11,
    DimGray = 68,
    DodgerBlue = 69,
    Firebrick = 70,
    FloralWhite = 71,
    ForestGreen = 72,
    Fuchsia = 73,
    Gainsboro = 74,
    GhostWhite = 75,
    Gold = 76,
    Goldenrod = 77,
    GradientActiveCaption = 171,
    GradientInactiveCaption = 172,
    Gray = 78,
    GrayText = 12,
    Green = 79,
    GreenYellow = 80,
    Highlight = 13,
    HighlightText = 14,
    Honeydew = 81,
    HotPink = 82,
    HotTrack = 15,
    InactiveBorder = 16,
    InactiveCaption = 17,
    InactiveCaptionText = 18,
    IndianRed = 83,
    Indigo = 84,
    Info = 19,
    InfoText = 20,
    Ivory = 85,
    Khaki = 86,
    Lavender = 87,
    LavenderBlush = 88,
    LawnGreen = 89,
    LemonChiffon = 90,
    LightBlue = 91,
    LightCoral = 92,
    LightCyan = 93,
    LightGoldenrodYellow = 94,
    LightGray = 95,
    LightGreen = 96,
    LightPink = 97,
    LightSalmon = 98,
    LightSeaGreen = 99,
    LightSkyBlue = 100,
    LightSlateGray = 101,
    LightSteelBlue = 102,
    LightYellow = 103,
    Lime = 104,
    LimeGreen = 105,
    Linen = 106,
    Magenta = 107,
    Maroon = 108,
    MediumAquamarine = 109,
    MediumBlue = 110,
    MediumOrchid = 111,
    MediumPurple = 112,
    MediumSeaGreen = 113,
    MediumSlateBlue = 114,
    MediumSpringGreen = 115,
    MediumTurquoise = 116,
    MediumVioletRed = 117,
    Menu = 21,
    MenuBar = 173,
    MenuHighlight = 174,
    MenuText = 22,
    MidnightBlue = 118,
    MintCream = 119,
    MistyRose = 120,
    Moccasin = 121,
    NavajoWhite = 122,
    Navy = 123,
    OldLace = 124,
    Olive = 125,
    OliveDrab = 126,
    Orange = 127,
    OrangeRed = 128,
    Orchid = 129,
    PaleGoldenrod = 130,
    PaleGreen = 131,
    PaleTurquoise = 132,
    PaleVioletRed = 133,
    PapayaWhip = 134,
    PeachPuff = 135,
    Peru = 136,
    Pink = 137,
    Plum = 138,
    PowderBlue = 139,
    Purple = 140,
    Red = 141,
    RosyBrown = 142,
    RoyalBlue = 143,
    SaddleBrown = 144,
    Salmon = 145,
    SandyBrown = 146,
    ScrollBar = 23,
    SeaGreen = 147,
    SeaShell = 148,
    Sienna = 149,
    Silver = 150,
    SkyBlue = 151,
    SlateBlue = 152,
    SlateGray = 153,
    Snow = 154,
    SpringGreen = 155,
    SteelBlue = 156,
    Tan = 157,
    Teal = 158,
    Thistle = 159,
    Tomato = 160,
    Transparent = 27,
    Turquoise = 161,
    Violet = 162,
    Wheat = 163,
    White = 164,
    WhiteSmoke = 165,
    Window = 24,
    WindowFrame = 25,
    WindowText = 26,
    Yellow = 166,
    YellowGreen = 167,
  }
  public sealed partial class Pen : System.MarshalByRefObject, System.ICloneable, System.IDisposable {
    public Pen(System.Drawing.Brush brush) { }
    public Pen(System.Drawing.Brush brush, float width) { }
    public Pen(System.Drawing.Color color) { }
    public Pen(System.Drawing.Color color, float width) { }
    public System.Drawing.Drawing2D.PenAlignment Alignment { get { return default(System.Drawing.Drawing2D.PenAlignment); } set { } }
    public System.Drawing.Brush Brush { get { return default(System.Drawing.Brush); } set { } }
    public System.Drawing.Color Color { get { return default(System.Drawing.Color); } set { } }
    public System.Single[] CompoundArray { get { return default(System.Single[]); } set { } }
    public System.Drawing.Drawing2D.CustomLineCap CustomEndCap { get { return default(System.Drawing.Drawing2D.CustomLineCap); } set { } }
    public System.Drawing.Drawing2D.CustomLineCap CustomStartCap { get { return default(System.Drawing.Drawing2D.CustomLineCap); } set { } }
    public System.Drawing.Drawing2D.DashCap DashCap { get { return default(System.Drawing.Drawing2D.DashCap); } set { } }
    public float DashOffset { get { return default(float); } set { } }
    public System.Single[] DashPattern { get { return default(System.Single[]); } set { } }
    public System.Drawing.Drawing2D.DashStyle DashStyle { get { return default(System.Drawing.Drawing2D.DashStyle); } set { } }
    public System.Drawing.Drawing2D.LineCap EndCap { get { return default(System.Drawing.Drawing2D.LineCap); } set { } }
    public System.Drawing.Drawing2D.LineJoin LineJoin { get { return default(System.Drawing.Drawing2D.LineJoin); } set { } }
    public float MiterLimit { get { return default(float); } set { } }
    public System.Drawing.Drawing2D.PenType PenType { get { return default(System.Drawing.Drawing2D.PenType); } }
    public System.Drawing.Drawing2D.LineCap StartCap { get { return default(System.Drawing.Drawing2D.LineCap); } set { } }
    public System.Drawing.Drawing2D.Matrix Transform { get { return default(System.Drawing.Drawing2D.Matrix); } set { } }
    public float Width { get { return default(float); } set { } }
    public object Clone() { return default(object); }
    public void Dispose() { }
    ~Pen() { }
    public void MultiplyTransform(System.Drawing.Drawing2D.Matrix matrix) { }
    public void MultiplyTransform(System.Drawing.Drawing2D.Matrix matrix, System.Drawing.Drawing2D.MatrixOrder order) { }
    public void ResetTransform() { }
    public void RotateTransform(float angle) { }
    public void RotateTransform(float angle, System.Drawing.Drawing2D.MatrixOrder order) { }
    public void ScaleTransform(float sx, float sy) { }
    public void ScaleTransform(float sx, float sy, System.Drawing.Drawing2D.MatrixOrder order) { }
    public void SetLineCap(System.Drawing.Drawing2D.LineCap startCap, System.Drawing.Drawing2D.LineCap endCap, System.Drawing.Drawing2D.DashCap dashCap) { }
    public void TranslateTransform(float dx, float dy) { }
    public void TranslateTransform(float dx, float dy, System.Drawing.Drawing2D.MatrixOrder order) { }
  }
  public sealed partial class Pens {
    internal Pens() { }
    public static System.Drawing.Pen AliceBlue { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen AntiqueWhite { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Aqua { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Aquamarine { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Azure { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Beige { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Bisque { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Black { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen BlanchedAlmond { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Blue { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen BlueViolet { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Brown { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen BurlyWood { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen CadetBlue { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Chartreuse { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Chocolate { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Coral { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen CornflowerBlue { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Cornsilk { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Crimson { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Cyan { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen DarkBlue { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen DarkCyan { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen DarkGoldenrod { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen DarkGray { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen DarkGreen { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen DarkKhaki { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen DarkMagenta { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen DarkOliveGreen { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen DarkOrange { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen DarkOrchid { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen DarkRed { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen DarkSalmon { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen DarkSeaGreen { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen DarkSlateBlue { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen DarkSlateGray { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen DarkTurquoise { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen DarkViolet { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen DeepPink { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen DeepSkyBlue { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen DimGray { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen DodgerBlue { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Firebrick { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen FloralWhite { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen ForestGreen { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Fuchsia { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Gainsboro { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen GhostWhite { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Gold { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Goldenrod { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Gray { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Green { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen GreenYellow { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Honeydew { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen HotPink { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen IndianRed { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Indigo { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Ivory { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Khaki { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Lavender { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen LavenderBlush { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen LawnGreen { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen LemonChiffon { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen LightBlue { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen LightCoral { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen LightCyan { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen LightGoldenrodYellow { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen LightGray { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen LightGreen { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen LightPink { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen LightSalmon { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen LightSeaGreen { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen LightSkyBlue { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen LightSlateGray { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen LightSteelBlue { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen LightYellow { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Lime { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen LimeGreen { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Linen { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Magenta { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Maroon { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen MediumAquamarine { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen MediumBlue { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen MediumOrchid { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen MediumPurple { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen MediumSeaGreen { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen MediumSlateBlue { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen MediumSpringGreen { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen MediumTurquoise { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen MediumVioletRed { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen MidnightBlue { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen MintCream { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen MistyRose { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Moccasin { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen NavajoWhite { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Navy { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen OldLace { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Olive { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen OliveDrab { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Orange { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen OrangeRed { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Orchid { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen PaleGoldenrod { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen PaleGreen { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen PaleTurquoise { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen PaleVioletRed { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen PapayaWhip { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen PeachPuff { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Peru { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Pink { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Plum { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen PowderBlue { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Purple { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Red { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen RosyBrown { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen RoyalBlue { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen SaddleBrown { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Salmon { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen SandyBrown { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen SeaGreen { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen SeaShell { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Sienna { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Silver { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen SkyBlue { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen SlateBlue { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen SlateGray { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Snow { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen SpringGreen { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen SteelBlue { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Tan { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Teal { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Thistle { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Tomato { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Transparent { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Turquoise { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Violet { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Wheat { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen White { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen WhiteSmoke { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Yellow { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen YellowGreen { get { return default(System.Drawing.Pen); } }
  }
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.PointConverter))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Point {
    public static readonly System.Drawing.Point Empty;
    public Point(System.Drawing.Size sz) { throw new System.NotImplementedException(); }
    public Point(int dw) { throw new System.NotImplementedException(); }
    public Point(int x, int y) { throw new System.NotImplementedException(); }
    [System.ComponentModel.BrowsableAttribute(false)]
    public bool IsEmpty { get { return default(bool); } }
    public int X { get { return default(int); } set { } }
    public int Y { get { return default(int); } set { } }
    public static System.Drawing.Point Add(System.Drawing.Point pt, System.Drawing.Size sz) { return default(System.Drawing.Point); }
    public static System.Drawing.Point Ceiling(System.Drawing.PointF value) { return default(System.Drawing.Point); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public void Offset(System.Drawing.Point p) { }
    public void Offset(int dx, int dy) { }
    public static System.Drawing.Point operator +(System.Drawing.Point pt, System.Drawing.Size sz) { return default(System.Drawing.Point); }
    public static bool operator ==(System.Drawing.Point left, System.Drawing.Point right) { return default(bool); }
    public static explicit operator System.Drawing.Size (System.Drawing.Point p) { return default(System.Drawing.Size); }
    public static implicit operator System.Drawing.PointF (System.Drawing.Point p) { return default(System.Drawing.PointF); }
    public static bool operator !=(System.Drawing.Point left, System.Drawing.Point right) { return default(bool); }
    public static System.Drawing.Point operator -(System.Drawing.Point pt, System.Drawing.Size sz) { return default(System.Drawing.Point); }
    public static System.Drawing.Point Round(System.Drawing.PointF value) { return default(System.Drawing.Point); }
    public static System.Drawing.Point Subtract(System.Drawing.Point pt, System.Drawing.Size sz) { return default(System.Drawing.Point); }
    public override string ToString() { return default(string); }
    public static System.Drawing.Point Truncate(System.Drawing.PointF value) { return default(System.Drawing.Point); }
  }
  public partial class PointConverter : System.ComponentModel.TypeConverter {
    public PointConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
    public override object CreateInstance(System.ComponentModel.ITypeDescriptorContext context, System.Collections.IDictionary propertyValues) { return default(object); }
    public override bool GetCreateInstanceSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public override System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public override bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct PointF {
    public static readonly System.Drawing.PointF Empty;
    public PointF(float x, float y) { throw new System.NotImplementedException(); }
    [System.ComponentModel.BrowsableAttribute(false)]
    public bool IsEmpty { get { return default(bool); } }
    public float X { get { return default(float); } set { } }
    public float Y { get { return default(float); } set { } }
    public static System.Drawing.PointF Add(System.Drawing.PointF pt, System.Drawing.Size sz) { return default(System.Drawing.PointF); }
    public static System.Drawing.PointF Add(System.Drawing.PointF pt, System.Drawing.SizeF sz) { return default(System.Drawing.PointF); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static System.Drawing.PointF operator +(System.Drawing.PointF pt, System.Drawing.Size sz) { return default(System.Drawing.PointF); }
    public static System.Drawing.PointF operator +(System.Drawing.PointF pt, System.Drawing.SizeF sz) { return default(System.Drawing.PointF); }
    public static bool operator ==(System.Drawing.PointF left, System.Drawing.PointF right) { return default(bool); }
    public static bool operator !=(System.Drawing.PointF left, System.Drawing.PointF right) { return default(bool); }
    public static System.Drawing.PointF operator -(System.Drawing.PointF pt, System.Drawing.Size sz) { return default(System.Drawing.PointF); }
    public static System.Drawing.PointF operator -(System.Drawing.PointF pt, System.Drawing.SizeF sz) { return default(System.Drawing.PointF); }
    public static System.Drawing.PointF Subtract(System.Drawing.PointF pt, System.Drawing.Size sz) { return default(System.Drawing.PointF); }
    public static System.Drawing.PointF Subtract(System.Drawing.PointF pt, System.Drawing.SizeF sz) { return default(System.Drawing.PointF); }
    public override string ToString() { return default(string); }
  }
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.RectangleConverter))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Rectangle {
    public static readonly System.Drawing.Rectangle Empty;
    public Rectangle(System.Drawing.Point location, System.Drawing.Size size) { throw new System.NotImplementedException(); }
    public Rectangle(int x, int y, int width, int height) { throw new System.NotImplementedException(); }
    [System.ComponentModel.BrowsableAttribute(false)]
    public int Bottom { get { return default(int); } }
    public int Height { get { return default(int); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public bool IsEmpty { get { return default(bool); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public int Left { get { return default(int); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public System.Drawing.Point Location { get { return default(System.Drawing.Point); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public int Right { get { return default(int); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public System.Drawing.Size Size { get { return default(System.Drawing.Size); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public int Top { get { return default(int); } }
    public int Width { get { return default(int); } set { } }
    public int X { get { return default(int); } set { } }
    public int Y { get { return default(int); } set { } }
    public static System.Drawing.Rectangle Ceiling(System.Drawing.RectangleF value) { return default(System.Drawing.Rectangle); }
    public bool Contains(System.Drawing.Point pt) { return default(bool); }
    public bool Contains(System.Drawing.Rectangle rect) { return default(bool); }
    public bool Contains(int x, int y) { return default(bool); }
    public override bool Equals(object obj) { return default(bool); }
    public static System.Drawing.Rectangle FromLTRB(int left, int top, int right, int bottom) { return default(System.Drawing.Rectangle); }
    public override int GetHashCode() { return default(int); }
    public static System.Drawing.Rectangle Inflate(System.Drawing.Rectangle rect, int x, int y) { return default(System.Drawing.Rectangle); }
    public void Inflate(System.Drawing.Size size) { }
    public void Inflate(int width, int height) { }
    public void Intersect(System.Drawing.Rectangle rect) { }
    public static System.Drawing.Rectangle Intersect(System.Drawing.Rectangle a, System.Drawing.Rectangle b) { return default(System.Drawing.Rectangle); }
    public bool IntersectsWith(System.Drawing.Rectangle rect) { return default(bool); }
    public void Offset(System.Drawing.Point pos) { }
    public void Offset(int x, int y) { }
    public static bool operator ==(System.Drawing.Rectangle left, System.Drawing.Rectangle right) { return default(bool); }
    public static bool operator !=(System.Drawing.Rectangle left, System.Drawing.Rectangle right) { return default(bool); }
    public static System.Drawing.Rectangle Round(System.Drawing.RectangleF value) { return default(System.Drawing.Rectangle); }
    public override string ToString() { return default(string); }
    public static System.Drawing.Rectangle Truncate(System.Drawing.RectangleF value) { return default(System.Drawing.Rectangle); }
    public static System.Drawing.Rectangle Union(System.Drawing.Rectangle a, System.Drawing.Rectangle b) { return default(System.Drawing.Rectangle); }
  }
  public partial class RectangleConverter : System.ComponentModel.TypeConverter {
    public RectangleConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
    public override object CreateInstance(System.ComponentModel.ITypeDescriptorContext context, System.Collections.IDictionary propertyValues) { return default(object); }
    public override bool GetCreateInstanceSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public override System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public override bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct RectangleF {
    public static readonly System.Drawing.RectangleF Empty;
    public RectangleF(System.Drawing.PointF location, System.Drawing.SizeF size) { throw new System.NotImplementedException(); }
    public RectangleF(float x, float y, float width, float height) { throw new System.NotImplementedException(); }
    [System.ComponentModel.BrowsableAttribute(false)]
    public float Bottom { get { return default(float); } }
    public float Height { get { return default(float); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public bool IsEmpty { get { return default(bool); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public float Left { get { return default(float); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public System.Drawing.PointF Location { get { return default(System.Drawing.PointF); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public float Right { get { return default(float); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public System.Drawing.SizeF Size { get { return default(System.Drawing.SizeF); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public float Top { get { return default(float); } }
    public float Width { get { return default(float); } set { } }
    public float X { get { return default(float); } set { } }
    public float Y { get { return default(float); } set { } }
    public bool Contains(System.Drawing.PointF pt) { return default(bool); }
    public bool Contains(System.Drawing.RectangleF rect) { return default(bool); }
    public bool Contains(float x, float y) { return default(bool); }
    public override bool Equals(object obj) { return default(bool); }
    public static System.Drawing.RectangleF FromLTRB(float left, float top, float right, float bottom) { return default(System.Drawing.RectangleF); }
    public override int GetHashCode() { return default(int); }
    public static System.Drawing.RectangleF Inflate(System.Drawing.RectangleF rect, float x, float y) { return default(System.Drawing.RectangleF); }
    public void Inflate(System.Drawing.SizeF size) { }
    public void Inflate(float x, float y) { }
    public void Intersect(System.Drawing.RectangleF rect) { }
    public static System.Drawing.RectangleF Intersect(System.Drawing.RectangleF a, System.Drawing.RectangleF b) { return default(System.Drawing.RectangleF); }
    public bool IntersectsWith(System.Drawing.RectangleF rect) { return default(bool); }
    public void Offset(System.Drawing.PointF pos) { }
    public void Offset(float x, float y) { }
    public static bool operator ==(System.Drawing.RectangleF left, System.Drawing.RectangleF right) { return default(bool); }
    public static implicit operator System.Drawing.RectangleF (System.Drawing.Rectangle r) { return default(System.Drawing.RectangleF); }
    public static bool operator !=(System.Drawing.RectangleF left, System.Drawing.RectangleF right) { return default(bool); }
    public override string ToString() { return default(string); }
    public static System.Drawing.RectangleF Union(System.Drawing.RectangleF a, System.Drawing.RectangleF b) { return default(System.Drawing.RectangleF); }
  }
  public sealed partial class Region : System.MarshalByRefObject, System.IDisposable {
    public Region() { }
    public Region(System.Drawing.Drawing2D.GraphicsPath path) { }
    public Region(System.Drawing.Drawing2D.RegionData rgnData) { }
    public Region(System.Drawing.Rectangle rect) { }
    public Region(System.Drawing.RectangleF rect) { }
    public System.Drawing.Region Clone() { return default(System.Drawing.Region); }
    public void Complement(System.Drawing.Drawing2D.GraphicsPath path) { }
    public void Complement(System.Drawing.Rectangle rect) { }
    public void Complement(System.Drawing.RectangleF rect) { }
    public void Complement(System.Drawing.Region region) { }
    public void Dispose() { }
    public bool Equals(System.Drawing.Region region, System.Drawing.Graphics g) { return default(bool); }
    public void Exclude(System.Drawing.Drawing2D.GraphicsPath path) { }
    public void Exclude(System.Drawing.Rectangle rect) { }
    public void Exclude(System.Drawing.RectangleF rect) { }
    public void Exclude(System.Drawing.Region region) { }
    ~Region() { }
    public static System.Drawing.Region FromHrgn(System.IntPtr hrgn) { return default(System.Drawing.Region); }
    public System.Drawing.RectangleF GetBounds(System.Drawing.Graphics g) { return default(System.Drawing.RectangleF); }
    public System.IntPtr GetHrgn(System.Drawing.Graphics g) { return default(System.IntPtr); }
    public System.Drawing.Drawing2D.RegionData GetRegionData() { return default(System.Drawing.Drawing2D.RegionData); }
    public System.Drawing.RectangleF[] GetRegionScans(System.Drawing.Drawing2D.Matrix matrix) { return default(System.Drawing.RectangleF[]); }
    public void Intersect(System.Drawing.Drawing2D.GraphicsPath path) { }
    public void Intersect(System.Drawing.Rectangle rect) { }
    public void Intersect(System.Drawing.RectangleF rect) { }
    public void Intersect(System.Drawing.Region region) { }
    public bool IsEmpty(System.Drawing.Graphics g) { return default(bool); }
    public bool IsInfinite(System.Drawing.Graphics g) { return default(bool); }
    public bool IsVisible(System.Drawing.Point point) { return default(bool); }
    public bool IsVisible(System.Drawing.Point point, System.Drawing.Graphics g) { return default(bool); }
    public bool IsVisible(System.Drawing.PointF point) { return default(bool); }
    public bool IsVisible(System.Drawing.PointF point, System.Drawing.Graphics g) { return default(bool); }
    public bool IsVisible(System.Drawing.Rectangle rect) { return default(bool); }
    public bool IsVisible(System.Drawing.Rectangle rect, System.Drawing.Graphics g) { return default(bool); }
    public bool IsVisible(System.Drawing.RectangleF rect) { return default(bool); }
    public bool IsVisible(System.Drawing.RectangleF rect, System.Drawing.Graphics g) { return default(bool); }
    public bool IsVisible(int x, int y, System.Drawing.Graphics g) { return default(bool); }
    public bool IsVisible(int x, int y, int width, int height) { return default(bool); }
    public bool IsVisible(int x, int y, int width, int height, System.Drawing.Graphics g) { return default(bool); }
    public bool IsVisible(float x, float y) { return default(bool); }
    public bool IsVisible(float x, float y, System.Drawing.Graphics g) { return default(bool); }
    public bool IsVisible(float x, float y, float width, float height) { return default(bool); }
    public bool IsVisible(float x, float y, float width, float height, System.Drawing.Graphics g) { return default(bool); }
    public void MakeEmpty() { }
    public void MakeInfinite() { }
    public void ReleaseHrgn(System.IntPtr regionHandle) { }
    public void Transform(System.Drawing.Drawing2D.Matrix matrix) { }
    public void Translate(int dx, int dy) { }
    public void Translate(float dx, float dy) { }
    public void Union(System.Drawing.Drawing2D.GraphicsPath path) { }
    public void Union(System.Drawing.Rectangle rect) { }
    public void Union(System.Drawing.RectangleF rect) { }
    public void Union(System.Drawing.Region region) { }
    public void Xor(System.Drawing.Drawing2D.GraphicsPath path) { }
    public void Xor(System.Drawing.Rectangle rect) { }
    public void Xor(System.Drawing.RectangleF rect) { }
    public void Xor(System.Drawing.Region region) { }
  }
  public enum RotateFlipType {
    Rotate180FlipNone = 2,
    Rotate180FlipX = 6,
    Rotate180FlipXY = 0,
    Rotate180FlipY = 4,
    Rotate270FlipNone = 3,
    Rotate270FlipX = 7,
    Rotate270FlipXY = 1,
    Rotate270FlipY = 5,
    Rotate90FlipNone = 1,
    Rotate90FlipX = 5,
    Rotate90FlipXY = 3,
    Rotate90FlipY = 7,
    RotateNoneFlipNone = 0,
    RotateNoneFlipX = 4,
    RotateNoneFlipXY = 2,
    RotateNoneFlipY = 6,
  }
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.SizeConverter))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Size {
    public static readonly System.Drawing.Size Empty;
    public Size(System.Drawing.Point pt) { throw new System.NotImplementedException(); }
    public Size(int width, int height) { throw new System.NotImplementedException(); }
    public int Height { get { return default(int); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public bool IsEmpty { get { return default(bool); } }
    public int Width { get { return default(int); } set { } }
    public static System.Drawing.Size Add(System.Drawing.Size sz1, System.Drawing.Size sz2) { return default(System.Drawing.Size); }
    public static System.Drawing.Size Ceiling(System.Drawing.SizeF value) { return default(System.Drawing.Size); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static System.Drawing.Size operator +(System.Drawing.Size sz1, System.Drawing.Size sz2) { return default(System.Drawing.Size); }
    public static bool operator ==(System.Drawing.Size sz1, System.Drawing.Size sz2) { return default(bool); }
    public static explicit operator System.Drawing.Point (System.Drawing.Size size) { return default(System.Drawing.Point); }
    public static implicit operator System.Drawing.SizeF (System.Drawing.Size p) { return default(System.Drawing.SizeF); }
    public static bool operator !=(System.Drawing.Size sz1, System.Drawing.Size sz2) { return default(bool); }
    public static System.Drawing.Size operator -(System.Drawing.Size sz1, System.Drawing.Size sz2) { return default(System.Drawing.Size); }
    public static System.Drawing.Size Round(System.Drawing.SizeF value) { return default(System.Drawing.Size); }
    public static System.Drawing.Size Subtract(System.Drawing.Size sz1, System.Drawing.Size sz2) { return default(System.Drawing.Size); }
    public override string ToString() { return default(string); }
    public static System.Drawing.Size Truncate(System.Drawing.SizeF value) { return default(System.Drawing.Size); }
  }
  public partial class SizeConverter : System.ComponentModel.TypeConverter {
    public SizeConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
    public override object CreateInstance(System.ComponentModel.ITypeDescriptorContext context, System.Collections.IDictionary propertyValues) { return default(object); }
    public override bool GetCreateInstanceSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public override System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public override bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
  }
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.SizeFConverter))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct SizeF {
    public static readonly System.Drawing.SizeF Empty;
    public SizeF(System.Drawing.PointF pt) { throw new System.NotImplementedException(); }
    public SizeF(System.Drawing.SizeF size) { throw new System.NotImplementedException(); }
    public SizeF(float width, float height) { throw new System.NotImplementedException(); }
    public float Height { get { return default(float); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public bool IsEmpty { get { return default(bool); } }
    public float Width { get { return default(float); } set { } }
    public static System.Drawing.SizeF Add(System.Drawing.SizeF sz1, System.Drawing.SizeF sz2) { return default(System.Drawing.SizeF); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static System.Drawing.SizeF operator +(System.Drawing.SizeF sz1, System.Drawing.SizeF sz2) { return default(System.Drawing.SizeF); }
    public static bool operator ==(System.Drawing.SizeF sz1, System.Drawing.SizeF sz2) { return default(bool); }
    public static explicit operator System.Drawing.PointF (System.Drawing.SizeF size) { return default(System.Drawing.PointF); }
    public static bool operator !=(System.Drawing.SizeF sz1, System.Drawing.SizeF sz2) { return default(bool); }
    public static System.Drawing.SizeF operator -(System.Drawing.SizeF sz1, System.Drawing.SizeF sz2) { return default(System.Drawing.SizeF); }
    public static System.Drawing.SizeF Subtract(System.Drawing.SizeF sz1, System.Drawing.SizeF sz2) { return default(System.Drawing.SizeF); }
    public System.Drawing.PointF ToPointF() { return default(System.Drawing.PointF); }
    public System.Drawing.Size ToSize() { return default(System.Drawing.Size); }
    public override string ToString() { return default(string); }
  }
  public partial class SizeFConverter : System.ComponentModel.TypeConverter {
    public SizeFConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
    public override object CreateInstance(System.ComponentModel.ITypeDescriptorContext context, System.Collections.IDictionary propertyValues) { return default(object); }
    public override bool GetCreateInstanceSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public override System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public override bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
  }
  public sealed partial class SolidBrush : System.Drawing.Brush {
    public SolidBrush(System.Drawing.Color color) { }
    public System.Drawing.Color Color { get { return default(System.Drawing.Color); } set { } }
    public override object Clone() { return default(object); }
    protected override void Dispose(bool disposing) { }
  }
  public enum StringAlignment {
    Center = 1,
    Far = 2,
    Near = 0,
  }
  public enum StringDigitSubstitute {
    National = 2,
    None = 1,
    Traditional = 3,
    User = 0,
  }
  public sealed partial class StringFormat : System.MarshalByRefObject, System.ICloneable, System.IDisposable {
    public StringFormat() { }
    public StringFormat(System.Drawing.StringFormat format) { }
    public StringFormat(System.Drawing.StringFormatFlags options) { }
    public StringFormat(System.Drawing.StringFormatFlags options, int language) { }
    public System.Drawing.StringAlignment Alignment { get { return default(System.Drawing.StringAlignment); } set { } }
    public int DigitSubstitutionLanguage { get { return default(int); } }
    public System.Drawing.StringDigitSubstitute DigitSubstitutionMethod { get { return default(System.Drawing.StringDigitSubstitute); } }
    public System.Drawing.StringFormatFlags FormatFlags { get { return default(System.Drawing.StringFormatFlags); } set { } }
    public static System.Drawing.StringFormat GenericDefault { get { return default(System.Drawing.StringFormat); } }
    public static System.Drawing.StringFormat GenericTypographic { get { return default(System.Drawing.StringFormat); } }
    public System.Drawing.Text.HotkeyPrefix HotkeyPrefix { get { return default(System.Drawing.Text.HotkeyPrefix); } set { } }
    public System.Drawing.StringAlignment LineAlignment { get { return default(System.Drawing.StringAlignment); } set { } }
    public System.Drawing.StringTrimming Trimming { get { return default(System.Drawing.StringTrimming); } set { } }
    public object Clone() { return default(object); }
    public void Dispose() { }
    ~StringFormat() { }
    public System.Single[] GetTabStops(out float firstTabOffset) { firstTabOffset = default(float); return default(System.Single[]); }
    public void SetDigitSubstitution(int language, System.Drawing.StringDigitSubstitute substitute) { }
    public void SetMeasurableCharacterRanges(System.Drawing.CharacterRange[] ranges) { }
    public void SetTabStops(float firstTabOffset, System.Single[] tabStops) { }
    public override string ToString() { return default(string); }
  }
  [System.FlagsAttribute]
  public enum StringFormatFlags {
    DirectionRightToLeft = 1,
    DirectionVertical = 2,
    DisplayFormatControl = 32,
    FitBlackBox = 4,
    LineLimit = 8192,
    MeasureTrailingSpaces = 2048,
    NoClip = 16384,
    NoFontFallback = 1024,
    NoWrap = 4096,
  }
  public enum StringTrimming {
    Character = 1,
    EllipsisCharacter = 3,
    EllipsisPath = 5,
    EllipsisWord = 4,
    None = 0,
    Word = 2,
  }
  public enum StringUnit {
    Display = 1,
    Document = 5,
    Em = 32,
    Inch = 4,
    Millimeter = 6,
    Pixel = 2,
    Point = 3,
    World = 0,
  }
  public sealed partial class SystemBrushes {
    internal SystemBrushes() { }
    public static System.Drawing.Brush ActiveBorder { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush ActiveCaption { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush ActiveCaptionText { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush AppWorkspace { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush ButtonFace { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush ButtonHighlight { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush ButtonShadow { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Control { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush ControlDark { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush ControlDarkDark { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush ControlLight { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush ControlLightLight { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush ControlText { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Desktop { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush GradientActiveCaption { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush GradientInactiveCaption { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush GrayText { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Highlight { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush HighlightText { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush HotTrack { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush InactiveBorder { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush InactiveCaption { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush InactiveCaptionText { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Info { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush InfoText { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Menu { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush MenuBar { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush MenuHighlight { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush MenuText { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush ScrollBar { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush Window { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush WindowFrame { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush WindowText { get { return default(System.Drawing.Brush); } }
    public static System.Drawing.Brush FromSystemColor(System.Drawing.Color c) { return default(System.Drawing.Brush); }
  }
  public sealed partial class SystemColors {
    internal SystemColors() { }
    public static System.Drawing.Color ActiveBorder { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color ActiveCaption { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color ActiveCaptionText { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color AppWorkspace { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color ButtonFace { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color ButtonHighlight { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color ButtonShadow { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Control { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color ControlDark { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color ControlDarkDark { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color ControlLight { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color ControlLightLight { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color ControlText { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Desktop { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color GradientActiveCaption { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color GradientInactiveCaption { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color GrayText { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Highlight { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color HighlightText { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color HotTrack { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color InactiveBorder { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color InactiveCaption { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color InactiveCaptionText { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Info { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color InfoText { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Menu { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color MenuBar { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color MenuHighlight { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color MenuText { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color ScrollBar { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color Window { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color WindowFrame { get { return default(System.Drawing.Color); } }
    public static System.Drawing.Color WindowText { get { return default(System.Drawing.Color); } }
  }
  public sealed partial class SystemFonts {
    internal SystemFonts() { }
    public static System.Drawing.Font CaptionFont { get { return default(System.Drawing.Font); } }
    public static System.Drawing.Font DefaultFont { get { return default(System.Drawing.Font); } }
    public static System.Drawing.Font DialogFont { get { return default(System.Drawing.Font); } }
    public static System.Drawing.Font IconTitleFont { get { return default(System.Drawing.Font); } }
    public static System.Drawing.Font MenuFont { get { return default(System.Drawing.Font); } }
    public static System.Drawing.Font MessageBoxFont { get { return default(System.Drawing.Font); } }
    public static System.Drawing.Font SmallCaptionFont { get { return default(System.Drawing.Font); } }
    public static System.Drawing.Font StatusFont { get { return default(System.Drawing.Font); } }
    public static System.Drawing.Font GetFontByName(string systemFontName) { return default(System.Drawing.Font); }
  }
  public sealed partial class SystemIcons {
    internal SystemIcons() { }
    public static System.Drawing.Icon Application { get { return default(System.Drawing.Icon); } }
    public static System.Drawing.Icon Asterisk { get { return default(System.Drawing.Icon); } }
    public static System.Drawing.Icon Error { get { return default(System.Drawing.Icon); } }
    public static System.Drawing.Icon Exclamation { get { return default(System.Drawing.Icon); } }
    public static System.Drawing.Icon Hand { get { return default(System.Drawing.Icon); } }
    public static System.Drawing.Icon Information { get { return default(System.Drawing.Icon); } }
    public static System.Drawing.Icon Question { get { return default(System.Drawing.Icon); } }
    public static System.Drawing.Icon Shield { get { return default(System.Drawing.Icon); } }
    public static System.Drawing.Icon Warning { get { return default(System.Drawing.Icon); } }
    public static System.Drawing.Icon WinLogo { get { return default(System.Drawing.Icon); } }
  }
  public sealed partial class SystemPens {
    internal SystemPens() { }
    public static System.Drawing.Pen ActiveBorder { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen ActiveCaption { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen ActiveCaptionText { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen AppWorkspace { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen ButtonFace { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen ButtonHighlight { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen ButtonShadow { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Control { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen ControlDark { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen ControlDarkDark { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen ControlLight { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen ControlLightLight { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen ControlText { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Desktop { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen GradientActiveCaption { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen GradientInactiveCaption { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen GrayText { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Highlight { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen HighlightText { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen HotTrack { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen InactiveBorder { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen InactiveCaption { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen InactiveCaptionText { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Info { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen InfoText { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Menu { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen MenuBar { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen MenuHighlight { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen MenuText { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen ScrollBar { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen Window { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen WindowFrame { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen WindowText { get { return default(System.Drawing.Pen); } }
    public static System.Drawing.Pen FromSystemColor(System.Drawing.Color c) { return default(System.Drawing.Pen); }
  }
  public sealed partial class TextureBrush : System.Drawing.Brush {
    public TextureBrush(System.Drawing.Image bitmap) { }
    public TextureBrush(System.Drawing.Image image, System.Drawing.Drawing2D.WrapMode wrapMode) { }
    public TextureBrush(System.Drawing.Image image, System.Drawing.Drawing2D.WrapMode wrapMode, System.Drawing.Rectangle dstRect) { }
    public TextureBrush(System.Drawing.Image image, System.Drawing.Drawing2D.WrapMode wrapMode, System.Drawing.RectangleF dstRect) { }
    public TextureBrush(System.Drawing.Image image, System.Drawing.Rectangle dstRect) { }
    public TextureBrush(System.Drawing.Image image, System.Drawing.Rectangle dstRect, System.Drawing.Imaging.ImageAttributes imageAttr) { }
    public TextureBrush(System.Drawing.Image image, System.Drawing.RectangleF dstRect) { }
    public TextureBrush(System.Drawing.Image image, System.Drawing.RectangleF dstRect, System.Drawing.Imaging.ImageAttributes imageAttr) { }
    public System.Drawing.Image Image { get { return default(System.Drawing.Image); } }
    public System.Drawing.Drawing2D.Matrix Transform { get { return default(System.Drawing.Drawing2D.Matrix); } set { } }
    public System.Drawing.Drawing2D.WrapMode WrapMode { get { return default(System.Drawing.Drawing2D.WrapMode); } set { } }
    public override object Clone() { return default(object); }
    public void MultiplyTransform(System.Drawing.Drawing2D.Matrix matrix) { }
    public void MultiplyTransform(System.Drawing.Drawing2D.Matrix matrix, System.Drawing.Drawing2D.MatrixOrder order) { }
    public void ResetTransform() { }
    public void RotateTransform(float angle) { }
    public void RotateTransform(float angle, System.Drawing.Drawing2D.MatrixOrder order) { }
    public void ScaleTransform(float sx, float sy) { }
    public void ScaleTransform(float sx, float sy, System.Drawing.Drawing2D.MatrixOrder order) { }
    public void TranslateTransform(float dx, float dy) { }
    public void TranslateTransform(float dx, float dy, System.Drawing.Drawing2D.MatrixOrder order) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
  public partial class ToolboxBitmapAttribute : System.Attribute {
    public static readonly System.Drawing.ToolboxBitmapAttribute Default;
    public ToolboxBitmapAttribute(string imageFile) { }
    public ToolboxBitmapAttribute(System.Type t) { }
    public ToolboxBitmapAttribute(System.Type t, string name) { }
    public override bool Equals(object value) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public System.Drawing.Image GetImage(object component) { return default(System.Drawing.Image); }
    public System.Drawing.Image GetImage(object component, bool large) { return default(System.Drawing.Image); }
    public System.Drawing.Image GetImage(System.Type type) { return default(System.Drawing.Image); }
    public System.Drawing.Image GetImage(System.Type type, bool large) { return default(System.Drawing.Image); }
    public System.Drawing.Image GetImage(System.Type type, string imgName, bool large) { return default(System.Drawing.Image); }
    public static System.Drawing.Image GetImageFromResource(System.Type t, string imageName, bool large) { return default(System.Drawing.Image); }
  }
}
namespace System.Drawing.Configuration {
  public sealed partial class SystemDrawingSection : System.Configuration.ConfigurationSection {
    public SystemDrawingSection() { }
    [System.Configuration.ConfigurationPropertyAttribute("bitmapSuffix")]
    public string BitmapSuffix { get { return default(string); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
}
namespace System.Drawing.Design {
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
  public sealed partial class CategoryNameCollection : System.Collections.ReadOnlyCollectionBase {
    public CategoryNameCollection(System.Drawing.Design.CategoryNameCollection value) { }
    public CategoryNameCollection(System.String[] value) { }
    public string this[int index] { get { return default(string); } }
    public bool Contains(string value) { return default(bool); }
    public void CopyTo(System.String[] array, int index) { }
    public int IndexOf(string value) { return default(int); }
  }
  public partial interface IPropertyValueUIService {
    event System.EventHandler PropertyUIValueItemsChanged;
    void AddPropertyValueUIHandler(System.Drawing.Design.PropertyValueUIHandler newHandler);
    System.Drawing.Design.PropertyValueUIItem[] GetPropertyUIValueItems(System.ComponentModel.ITypeDescriptorContext context, System.ComponentModel.PropertyDescriptor propDesc);
    void NotifyPropertyValueUIItemsChanged();
    void RemovePropertyValueUIHandler(System.Drawing.Design.PropertyValueUIHandler newHandler);
  }
  public partial interface IToolboxItemProvider {
    System.Drawing.Design.ToolboxItemCollection Items { get; }
  }
  [System.Runtime.InteropServices.GuidAttribute("4BACD258-DE64-4048-BC4E-FEDBEF9ACB76")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
  public partial interface IToolboxService {
    System.Drawing.Design.CategoryNameCollection CategoryNames { get; }
    string SelectedCategory { get; set; }
    void AddCreator(System.Drawing.Design.ToolboxItemCreatorCallback creator, string format);
    void AddCreator(System.Drawing.Design.ToolboxItemCreatorCallback creator, string format, System.ComponentModel.Design.IDesignerHost host);
    void AddLinkedToolboxItem(System.Drawing.Design.ToolboxItem toolboxItem, System.ComponentModel.Design.IDesignerHost host);
    void AddLinkedToolboxItem(System.Drawing.Design.ToolboxItem toolboxItem, string category, System.ComponentModel.Design.IDesignerHost host);
    void AddToolboxItem(System.Drawing.Design.ToolboxItem toolboxItem);
    void AddToolboxItem(System.Drawing.Design.ToolboxItem toolboxItem, string category);
    System.Drawing.Design.ToolboxItem DeserializeToolboxItem(object serializedObject);
    System.Drawing.Design.ToolboxItem DeserializeToolboxItem(object serializedObject, System.ComponentModel.Design.IDesignerHost host);
    System.Drawing.Design.ToolboxItem GetSelectedToolboxItem();
    System.Drawing.Design.ToolboxItem GetSelectedToolboxItem(System.ComponentModel.Design.IDesignerHost host);
    System.Drawing.Design.ToolboxItemCollection GetToolboxItems();
    System.Drawing.Design.ToolboxItemCollection GetToolboxItems(System.ComponentModel.Design.IDesignerHost host);
    System.Drawing.Design.ToolboxItemCollection GetToolboxItems(string category);
    System.Drawing.Design.ToolboxItemCollection GetToolboxItems(string category, System.ComponentModel.Design.IDesignerHost host);
    bool IsSupported(object serializedObject, System.Collections.ICollection filterAttributes);
    bool IsSupported(object serializedObject, System.ComponentModel.Design.IDesignerHost host);
    bool IsToolboxItem(object serializedObject);
    bool IsToolboxItem(object serializedObject, System.ComponentModel.Design.IDesignerHost host);
    void Refresh();
    void RemoveCreator(string format);
    void RemoveCreator(string format, System.ComponentModel.Design.IDesignerHost host);
    void RemoveToolboxItem(System.Drawing.Design.ToolboxItem toolboxItem);
    void RemoveToolboxItem(System.Drawing.Design.ToolboxItem toolboxItem, string category);
    void SelectedToolboxItemUsed();
    object SerializeToolboxItem(System.Drawing.Design.ToolboxItem toolboxItem);
    bool SetCursor();
    void SetSelectedToolboxItem(System.Drawing.Design.ToolboxItem toolboxItem);
  }
  public partial interface IToolboxUser {
    bool GetToolSupported(System.Drawing.Design.ToolboxItem tool);
    void ToolPicked(System.Drawing.Design.ToolboxItem tool);
  }
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
  public partial class PaintValueEventArgs : System.EventArgs {
    public PaintValueEventArgs(System.ComponentModel.ITypeDescriptorContext context, object value, System.Drawing.Graphics graphics, System.Drawing.Rectangle bounds) { }
    public System.Drawing.Rectangle Bounds { get { return default(System.Drawing.Rectangle); } }
    public System.ComponentModel.ITypeDescriptorContext Context { get { return default(System.ComponentModel.ITypeDescriptorContext); } }
    public System.Drawing.Graphics Graphics { get { return default(System.Drawing.Graphics); } }
    public object Value { get { return default(object); } }
  }
  public delegate void PropertyValueUIHandler(System.ComponentModel.ITypeDescriptorContext context, System.ComponentModel.PropertyDescriptor propDesc, System.Collections.ArrayList valueUIItemList);
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
  public partial class PropertyValueUIItem {
    public PropertyValueUIItem(System.Drawing.Image uiItemImage, System.Drawing.Design.PropertyValueUIItemInvokeHandler handler, string tooltip) { }
    public virtual System.Drawing.Image Image { get { return default(System.Drawing.Image); } }
    public virtual System.Drawing.Design.PropertyValueUIItemInvokeHandler InvokeHandler { get { return default(System.Drawing.Design.PropertyValueUIItemInvokeHandler); } }
    public virtual string ToolTip { get { return default(string); } }
    public virtual void Reset() { }
  }
  public delegate void PropertyValueUIItemInvokeHandler(System.ComponentModel.ITypeDescriptorContext context, System.ComponentModel.PropertyDescriptor descriptor, System.Drawing.Design.PropertyValueUIItem invokedItem);
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
  public partial class ToolboxComponentsCreatedEventArgs : System.EventArgs {
    public ToolboxComponentsCreatedEventArgs(System.ComponentModel.IComponent[] components) { }
    public System.ComponentModel.IComponent[] Components { get { return default(System.ComponentModel.IComponent[]); } }
  }
  public delegate void ToolboxComponentsCreatedEventHandler(object sender, System.Drawing.Design.ToolboxComponentsCreatedEventArgs e);
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
  public partial class ToolboxComponentsCreatingEventArgs : System.EventArgs {
    public ToolboxComponentsCreatingEventArgs(System.ComponentModel.Design.IDesignerHost host) { }
    public System.ComponentModel.Design.IDesignerHost DesignerHost { get { return default(System.ComponentModel.Design.IDesignerHost); } }
  }
  public delegate void ToolboxComponentsCreatingEventHandler(object sender, System.Drawing.Design.ToolboxComponentsCreatingEventArgs e);
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
  public partial class ToolboxItem : System.Runtime.Serialization.ISerializable {
    public ToolboxItem() { }
    public ToolboxItem(System.Type toolType) { }
    public System.Reflection.AssemblyName AssemblyName { get { return default(System.Reflection.AssemblyName); } set { } }
    public System.Drawing.Bitmap Bitmap { get { return default(System.Drawing.Bitmap); } set { } }
    public string Company { get { return default(string); } set { } }
    public virtual string ComponentType { get { return default(string); } }
    public System.Reflection.AssemblyName[] DependentAssemblies { get { return default(System.Reflection.AssemblyName[]); } set { } }
    public string Description { get { return default(string); } set { } }
    public string DisplayName { get { return default(string); } set { } }
    public System.Collections.ICollection Filter { get { return default(System.Collections.ICollection); } set { } }
    public bool IsTransient { get { return default(bool); } set { } }
    public virtual bool Locked { get { return default(bool); } }
    public System.Drawing.Bitmap OriginalBitmap { get { return default(System.Drawing.Bitmap); } set { } }
    public System.Collections.IDictionary Properties { get { return default(System.Collections.IDictionary); } }
    public string TypeName { get { return default(string); } set { } }
    public virtual string Version { get { return default(string); } }
    public event System.Drawing.Design.ToolboxComponentsCreatedEventHandler ComponentsCreated { add { } remove { } }
    public event System.Drawing.Design.ToolboxComponentsCreatingEventHandler ComponentsCreating { add { } remove { } }
    protected void CheckUnlocked() { }
    public System.ComponentModel.IComponent[] CreateComponents() { return default(System.ComponentModel.IComponent[]); }
    public System.ComponentModel.IComponent[] CreateComponents(System.ComponentModel.Design.IDesignerHost host) { return default(System.ComponentModel.IComponent[]); }
    public System.ComponentModel.IComponent[] CreateComponents(System.ComponentModel.Design.IDesignerHost host, System.Collections.IDictionary defaultValues) { return default(System.ComponentModel.IComponent[]); }
    protected virtual System.ComponentModel.IComponent[] CreateComponentsCore(System.ComponentModel.Design.IDesignerHost host) { return default(System.ComponentModel.IComponent[]); }
    protected virtual System.ComponentModel.IComponent[] CreateComponentsCore(System.ComponentModel.Design.IDesignerHost host, System.Collections.IDictionary defaultValues) { return default(System.ComponentModel.IComponent[]); }
    protected virtual void Deserialize(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public override bool Equals(object obj) { return default(bool); }
    protected virtual object FilterPropertyValue(string propertyName, object value) { return default(object); }
    public override int GetHashCode() { return default(int); }
    public System.Type GetType(System.ComponentModel.Design.IDesignerHost host) { return default(System.Type); }
    protected virtual System.Type GetType(System.ComponentModel.Design.IDesignerHost host, System.Reflection.AssemblyName assemblyName, string typeName, bool reference) { return default(System.Type); }
    public virtual void Initialize(System.Type type) { }
    public virtual void Lock() { }
    protected virtual void OnComponentsCreated(System.Drawing.Design.ToolboxComponentsCreatedEventArgs args) { }
    protected virtual void OnComponentsCreating(System.Drawing.Design.ToolboxComponentsCreatingEventArgs args) { }
    protected virtual void Serialize(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public override string ToString() { return default(string); }
    protected void ValidatePropertyType(string propertyName, object value, System.Type expectedType, bool allowNull) { }
    protected virtual object ValidatePropertyValue(string propertyName, object value) { return default(object); }
  }
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
  public sealed partial class ToolboxItemCollection : System.Collections.ReadOnlyCollectionBase {
    public ToolboxItemCollection(System.Drawing.Design.ToolboxItem[] value) { }
    public ToolboxItemCollection(System.Drawing.Design.ToolboxItemCollection value) { }
    public System.Drawing.Design.ToolboxItem this[int index] { get { return default(System.Drawing.Design.ToolboxItem); } }
    public bool Contains(System.Drawing.Design.ToolboxItem value) { return default(bool); }
    public void CopyTo(System.Drawing.Design.ToolboxItem[] array, int index) { }
    public int IndexOf(System.Drawing.Design.ToolboxItem value) { return default(int); }
  }
  public delegate System.Drawing.Design.ToolboxItem ToolboxItemCreatorCallback(object serializedObject, string format);
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
  public partial class UITypeEditor {
    public UITypeEditor() { }
    public virtual bool IsDropDownResizable { get { return default(bool); } }
    public virtual object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { return default(object); }
    public object EditValue(System.IServiceProvider provider, object value) { return default(object); }
    public System.Drawing.Design.UITypeEditorEditStyle GetEditStyle() { return default(System.Drawing.Design.UITypeEditorEditStyle); }
    public virtual System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { return default(System.Drawing.Design.UITypeEditorEditStyle); }
    public bool GetPaintValueSupported() { return default(bool); }
    public virtual bool GetPaintValueSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public virtual void PaintValue(System.Drawing.Design.PaintValueEventArgs e) { }
    public void PaintValue(object value, System.Drawing.Graphics canvas, System.Drawing.Rectangle rectangle) { }
  }
  public enum UITypeEditorEditStyle {
    DropDown = 3,
    Modal = 2,
    None = 1,
  }
}
namespace System.Drawing.Drawing2D {
  public sealed partial class AdjustableArrowCap : System.Drawing.Drawing2D.CustomLineCap {
    public AdjustableArrowCap(float width, float height) : base (default(System.Drawing.Drawing2D.GraphicsPath), default(System.Drawing.Drawing2D.GraphicsPath)) { }
    public AdjustableArrowCap(float width, float height, bool isFilled) : base (default(System.Drawing.Drawing2D.GraphicsPath), default(System.Drawing.Drawing2D.GraphicsPath)) { }
    public bool Filled { get { return default(bool); } set { } }
    public float Height { get { return default(float); } set { } }
    public float MiddleInset { get { return default(float); } set { } }
    public float Width { get { return default(float); } set { } }
  }
  public sealed partial class Blend {
    public Blend() { }
    public Blend(int count) { }
    public System.Single[] Factors { get { return default(System.Single[]); } set { } }
    public System.Single[] Positions { get { return default(System.Single[]); } set { } }
  }
  public sealed partial class ColorBlend {
    public ColorBlend() { }
    public ColorBlend(int count) { }
    public System.Drawing.Color[] Colors { get { return default(System.Drawing.Color[]); } set { } }
    public System.Single[] Positions { get { return default(System.Single[]); } set { } }
  }
  public enum CombineMode {
    Complement = 5,
    Exclude = 4,
    Intersect = 1,
    Replace = 0,
    Union = 2,
    Xor = 3,
  }
  public enum CompositingMode {
    SourceCopy = 1,
    SourceOver = 0,
  }
  public enum CompositingQuality {
    AssumeLinear = 4,
    Default = 0,
    GammaCorrected = 3,
    HighQuality = 2,
    HighSpeed = 1,
    Invalid = -1,
  }
  public enum CoordinateSpace {
    Device = 2,
    Page = 1,
    World = 0,
  }
  public partial class CustomLineCap : System.MarshalByRefObject, System.ICloneable, System.IDisposable {
    public CustomLineCap(System.Drawing.Drawing2D.GraphicsPath fillPath, System.Drawing.Drawing2D.GraphicsPath strokePath) { }
    public CustomLineCap(System.Drawing.Drawing2D.GraphicsPath fillPath, System.Drawing.Drawing2D.GraphicsPath strokePath, System.Drawing.Drawing2D.LineCap baseCap) { }
    public CustomLineCap(System.Drawing.Drawing2D.GraphicsPath fillPath, System.Drawing.Drawing2D.GraphicsPath strokePath, System.Drawing.Drawing2D.LineCap baseCap, float baseInset) { }
    public System.Drawing.Drawing2D.LineCap BaseCap { get { return default(System.Drawing.Drawing2D.LineCap); } set { } }
    public float BaseInset { get { return default(float); } set { } }
    public System.Drawing.Drawing2D.LineJoin StrokeJoin { get { return default(System.Drawing.Drawing2D.LineJoin); } set { } }
    public float WidthScale { get { return default(float); } set { } }
    public object Clone() { return default(object); }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    ~CustomLineCap() { }
    public void GetStrokeCaps(out System.Drawing.Drawing2D.LineCap startCap, out System.Drawing.Drawing2D.LineCap endCap) { startCap = default(System.Drawing.Drawing2D.LineCap); endCap = default(System.Drawing.Drawing2D.LineCap); }
    public void SetStrokeCaps(System.Drawing.Drawing2D.LineCap startCap, System.Drawing.Drawing2D.LineCap endCap) { }
  }
  public enum DashCap {
    Flat = 0,
    Round = 2,
    Triangle = 3,
  }
  public enum DashStyle {
    Custom = 5,
    Dash = 1,
    DashDot = 3,
    DashDotDot = 4,
    Dot = 2,
    Solid = 0,
  }
  public enum FillMode {
    Alternate = 0,
    Winding = 1,
  }
  public enum FlushIntention {
    Flush = 0,
    Sync = 1,
  }
  public sealed partial class GraphicsContainer : System.MarshalByRefObject {
    internal GraphicsContainer() { }
  }
  public sealed partial class GraphicsPath : System.MarshalByRefObject, System.ICloneable, System.IDisposable {
    public GraphicsPath() { }
    public GraphicsPath(System.Drawing.Drawing2D.FillMode fillMode) { }
    public GraphicsPath(System.Drawing.Point[] pts, System.Byte[] types) { }
    public GraphicsPath(System.Drawing.Point[] pts, System.Byte[] types, System.Drawing.Drawing2D.FillMode fillMode) { }
    public GraphicsPath(System.Drawing.PointF[] pts, System.Byte[] types) { }
    public GraphicsPath(System.Drawing.PointF[] pts, System.Byte[] types, System.Drawing.Drawing2D.FillMode fillMode) { }
    public System.Drawing.Drawing2D.FillMode FillMode { get { return default(System.Drawing.Drawing2D.FillMode); } set { } }
    public System.Drawing.Drawing2D.PathData PathData { get { return default(System.Drawing.Drawing2D.PathData); } }
    public System.Drawing.PointF[] PathPoints { get { return default(System.Drawing.PointF[]); } }
    public System.Byte[] PathTypes { get { return default(System.Byte[]); } }
    public int PointCount { get { return default(int); } }
    public void AddArc(System.Drawing.Rectangle rect, float startAngle, float sweepAngle) { }
    public void AddArc(System.Drawing.RectangleF rect, float startAngle, float sweepAngle) { }
    public void AddArc(int x, int y, int width, int height, float startAngle, float sweepAngle) { }
    public void AddArc(float x, float y, float width, float height, float startAngle, float sweepAngle) { }
    public void AddBezier(System.Drawing.Point pt1, System.Drawing.Point pt2, System.Drawing.Point pt3, System.Drawing.Point pt4) { }
    public void AddBezier(System.Drawing.PointF pt1, System.Drawing.PointF pt2, System.Drawing.PointF pt3, System.Drawing.PointF pt4) { }
    public void AddBezier(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4) { }
    public void AddBezier(float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4) { }
    public void AddBeziers(params System.Drawing.Point[] points) { }
    public void AddBeziers(System.Drawing.PointF[] points) { }
    public void AddClosedCurve(System.Drawing.Point[] points) { }
    public void AddClosedCurve(System.Drawing.Point[] points, float tension) { }
    public void AddClosedCurve(System.Drawing.PointF[] points) { }
    public void AddClosedCurve(System.Drawing.PointF[] points, float tension) { }
    public void AddCurve(System.Drawing.Point[] points) { }
    public void AddCurve(System.Drawing.Point[] points, int offset, int numberOfSegments, float tension) { }
    public void AddCurve(System.Drawing.Point[] points, float tension) { }
    public void AddCurve(System.Drawing.PointF[] points) { }
    public void AddCurve(System.Drawing.PointF[] points, int offset, int numberOfSegments, float tension) { }
    public void AddCurve(System.Drawing.PointF[] points, float tension) { }
    public void AddEllipse(System.Drawing.Rectangle rect) { }
    public void AddEllipse(System.Drawing.RectangleF rect) { }
    public void AddEllipse(int x, int y, int width, int height) { }
    public void AddEllipse(float x, float y, float width, float height) { }
    public void AddLine(System.Drawing.Point pt1, System.Drawing.Point pt2) { }
    public void AddLine(System.Drawing.PointF pt1, System.Drawing.PointF pt2) { }
    public void AddLine(int x1, int y1, int x2, int y2) { }
    public void AddLine(float x1, float y1, float x2, float y2) { }
    public void AddLines(System.Drawing.Point[] points) { }
    public void AddLines(System.Drawing.PointF[] points) { }
    public void AddPath(System.Drawing.Drawing2D.GraphicsPath addingPath, bool connect) { }
    public void AddPie(System.Drawing.Rectangle rect, float startAngle, float sweepAngle) { }
    public void AddPie(int x, int y, int width, int height, float startAngle, float sweepAngle) { }
    public void AddPie(float x, float y, float width, float height, float startAngle, float sweepAngle) { }
    public void AddPolygon(System.Drawing.Point[] points) { }
    public void AddPolygon(System.Drawing.PointF[] points) { }
    public void AddRectangle(System.Drawing.Rectangle rect) { }
    public void AddRectangle(System.Drawing.RectangleF rect) { }
    public void AddRectangles(System.Drawing.Rectangle[] rects) { }
    public void AddRectangles(System.Drawing.RectangleF[] rects) { }
    public void AddString(string s, System.Drawing.FontFamily family, int style, float emSize, System.Drawing.Point origin, System.Drawing.StringFormat format) { }
    public void AddString(string s, System.Drawing.FontFamily family, int style, float emSize, System.Drawing.PointF origin, System.Drawing.StringFormat format) { }
    public void AddString(string s, System.Drawing.FontFamily family, int style, float emSize, System.Drawing.Rectangle layoutRect, System.Drawing.StringFormat format) { }
    public void AddString(string s, System.Drawing.FontFamily family, int style, float emSize, System.Drawing.RectangleF layoutRect, System.Drawing.StringFormat format) { }
    public void ClearMarkers() { }
    public object Clone() { return default(object); }
    public void CloseAllFigures() { }
    public void CloseFigure() { }
    public void Dispose() { }
    ~GraphicsPath() { }
    public void Flatten() { }
    public void Flatten(System.Drawing.Drawing2D.Matrix matrix) { }
    public void Flatten(System.Drawing.Drawing2D.Matrix matrix, float flatness) { }
    public System.Drawing.RectangleF GetBounds() { return default(System.Drawing.RectangleF); }
    public System.Drawing.RectangleF GetBounds(System.Drawing.Drawing2D.Matrix matrix) { return default(System.Drawing.RectangleF); }
    public System.Drawing.RectangleF GetBounds(System.Drawing.Drawing2D.Matrix matrix, System.Drawing.Pen pen) { return default(System.Drawing.RectangleF); }
    public System.Drawing.PointF GetLastPoint() { return default(System.Drawing.PointF); }
    public bool IsOutlineVisible(System.Drawing.Point point, System.Drawing.Pen pen) { return default(bool); }
    public bool IsOutlineVisible(System.Drawing.Point pt, System.Drawing.Pen pen, System.Drawing.Graphics graphics) { return default(bool); }
    public bool IsOutlineVisible(System.Drawing.PointF point, System.Drawing.Pen pen) { return default(bool); }
    public bool IsOutlineVisible(System.Drawing.PointF pt, System.Drawing.Pen pen, System.Drawing.Graphics graphics) { return default(bool); }
    public bool IsOutlineVisible(int x, int y, System.Drawing.Pen pen) { return default(bool); }
    public bool IsOutlineVisible(int x, int y, System.Drawing.Pen pen, System.Drawing.Graphics graphics) { return default(bool); }
    public bool IsOutlineVisible(float x, float y, System.Drawing.Pen pen) { return default(bool); }
    public bool IsOutlineVisible(float x, float y, System.Drawing.Pen pen, System.Drawing.Graphics graphics) { return default(bool); }
    public bool IsVisible(System.Drawing.Point point) { return default(bool); }
    public bool IsVisible(System.Drawing.Point pt, System.Drawing.Graphics graphics) { return default(bool); }
    public bool IsVisible(System.Drawing.PointF point) { return default(bool); }
    public bool IsVisible(System.Drawing.PointF pt, System.Drawing.Graphics graphics) { return default(bool); }
    public bool IsVisible(int x, int y) { return default(bool); }
    public bool IsVisible(int x, int y, System.Drawing.Graphics graphics) { return default(bool); }
    public bool IsVisible(float x, float y) { return default(bool); }
    public bool IsVisible(float x, float y, System.Drawing.Graphics graphics) { return default(bool); }
    public void Reset() { }
    public void Reverse() { }
    public void SetMarkers() { }
    public void StartFigure() { }
    public void Transform(System.Drawing.Drawing2D.Matrix matrix) { }
    public void Warp(System.Drawing.PointF[] destPoints, System.Drawing.RectangleF srcRect) { }
    public void Warp(System.Drawing.PointF[] destPoints, System.Drawing.RectangleF srcRect, System.Drawing.Drawing2D.Matrix matrix) { }
    public void Warp(System.Drawing.PointF[] destPoints, System.Drawing.RectangleF srcRect, System.Drawing.Drawing2D.Matrix matrix, System.Drawing.Drawing2D.WarpMode warpMode) { }
    public void Warp(System.Drawing.PointF[] destPoints, System.Drawing.RectangleF srcRect, System.Drawing.Drawing2D.Matrix matrix, System.Drawing.Drawing2D.WarpMode warpMode, float flatness) { }
    public void Widen(System.Drawing.Pen pen) { }
    public void Widen(System.Drawing.Pen pen, System.Drawing.Drawing2D.Matrix matrix) { }
    public void Widen(System.Drawing.Pen pen, System.Drawing.Drawing2D.Matrix matrix, float flatness) { }
  }
  public sealed partial class GraphicsPathIterator : System.MarshalByRefObject, System.IDisposable {
    public GraphicsPathIterator(System.Drawing.Drawing2D.GraphicsPath path) { }
    public int Count { get { return default(int); } }
    public int SubpathCount { get { return default(int); } }
    public int CopyData(ref System.Drawing.PointF[] points, ref System.Byte[] types, int startIndex, int endIndex) { return default(int); }
    public void Dispose() { }
    public int Enumerate(ref System.Drawing.PointF[] points, ref System.Byte[] types) { return default(int); }
    ~GraphicsPathIterator() { }
    public bool HasCurve() { return default(bool); }
    public int NextMarker(System.Drawing.Drawing2D.GraphicsPath path) { return default(int); }
    public int NextMarker(out int startIndex, out int endIndex) { startIndex = default(int); endIndex = default(int); return default(int); }
    public int NextPathType(out byte pathType, out int startIndex, out int endIndex) { pathType = default(byte); startIndex = default(int); endIndex = default(int); return default(int); }
    public int NextSubpath(System.Drawing.Drawing2D.GraphicsPath path, out bool isClosed) { isClosed = default(bool); return default(int); }
    public int NextSubpath(out int startIndex, out int endIndex, out bool isClosed) { startIndex = default(int); endIndex = default(int); isClosed = default(bool); return default(int); }
    public void Rewind() { }
  }
  public sealed partial class GraphicsState : System.MarshalByRefObject {
    internal GraphicsState() { }
  }
  public sealed partial class HatchBrush : System.Drawing.Brush {
    public HatchBrush(System.Drawing.Drawing2D.HatchStyle hatchstyle, System.Drawing.Color foreColor) { }
    public HatchBrush(System.Drawing.Drawing2D.HatchStyle hatchstyle, System.Drawing.Color foreColor, System.Drawing.Color backColor) { }
    public System.Drawing.Color BackgroundColor { get { return default(System.Drawing.Color); } }
    public System.Drawing.Color ForegroundColor { get { return default(System.Drawing.Color); } }
    public System.Drawing.Drawing2D.HatchStyle HatchStyle { get { return default(System.Drawing.Drawing2D.HatchStyle); } }
    public override object Clone() { return default(object); }
  }
  public enum HatchStyle {
    BackwardDiagonal = 3,
    Cross = 4,
    DarkDownwardDiagonal = 20,
    DarkHorizontal = 29,
    DarkUpwardDiagonal = 21,
    DarkVertical = 28,
    DashedDownwardDiagonal = 30,
    DashedHorizontal = 32,
    DashedUpwardDiagonal = 31,
    DashedVertical = 33,
    DiagonalBrick = 38,
    DiagonalCross = 5,
    Divot = 42,
    DottedDiamond = 44,
    DottedGrid = 43,
    ForwardDiagonal = 2,
    Horizontal = 0,
    HorizontalBrick = 39,
    LargeCheckerBoard = 50,
    LargeConfetti = 35,
    LargeGrid = 4,
    LightDownwardDiagonal = 18,
    LightHorizontal = 25,
    LightUpwardDiagonal = 19,
    LightVertical = 24,
    Max = 4,
    Min = 0,
    NarrowHorizontal = 27,
    NarrowVertical = 26,
    OutlinedDiamond = 51,
    Percent05 = 6,
    Percent10 = 7,
    Percent20 = 8,
    Percent25 = 9,
    Percent30 = 10,
    Percent40 = 11,
    Percent50 = 12,
    Percent60 = 13,
    Percent70 = 14,
    Percent75 = 15,
    Percent80 = 16,
    Percent90 = 17,
    Plaid = 41,
    Shingle = 45,
    SmallCheckerBoard = 49,
    SmallConfetti = 34,
    SmallGrid = 48,
    SolidDiamond = 52,
    Sphere = 47,
    Trellis = 46,
    Vertical = 1,
    Wave = 37,
    Weave = 40,
    WideDownwardDiagonal = 22,
    WideUpwardDiagonal = 23,
    ZigZag = 36,
  }
  public enum InterpolationMode {
    Bicubic = 4,
    Bilinear = 3,
    Default = 0,
    High = 2,
    HighQualityBicubic = 7,
    HighQualityBilinear = 6,
    Invalid = -1,
    Low = 1,
    NearestNeighbor = 5,
  }
  public sealed partial class LinearGradientBrush : System.Drawing.Brush {
    public LinearGradientBrush(System.Drawing.Point point1, System.Drawing.Point point2, System.Drawing.Color color1, System.Drawing.Color color2) { }
    public LinearGradientBrush(System.Drawing.PointF point1, System.Drawing.PointF point2, System.Drawing.Color color1, System.Drawing.Color color2) { }
    public LinearGradientBrush(System.Drawing.Rectangle rect, System.Drawing.Color color1, System.Drawing.Color color2, System.Drawing.Drawing2D.LinearGradientMode linearGradientMode) { }
    public LinearGradientBrush(System.Drawing.Rectangle rect, System.Drawing.Color color1, System.Drawing.Color color2, float angle) { }
    public LinearGradientBrush(System.Drawing.Rectangle rect, System.Drawing.Color color1, System.Drawing.Color color2, float angle, bool isAngleScaleable) { }
    public LinearGradientBrush(System.Drawing.RectangleF rect, System.Drawing.Color color1, System.Drawing.Color color2, System.Drawing.Drawing2D.LinearGradientMode linearGradientMode) { }
    public LinearGradientBrush(System.Drawing.RectangleF rect, System.Drawing.Color color1, System.Drawing.Color color2, float angle) { }
    public LinearGradientBrush(System.Drawing.RectangleF rect, System.Drawing.Color color1, System.Drawing.Color color2, float angle, bool isAngleScaleable) { }
    public System.Drawing.Drawing2D.Blend Blend { get { return default(System.Drawing.Drawing2D.Blend); } set { } }
    public bool GammaCorrection { get { return default(bool); } set { } }
    public System.Drawing.Drawing2D.ColorBlend InterpolationColors { get { return default(System.Drawing.Drawing2D.ColorBlend); } set { } }
    public System.Drawing.Color[] LinearColors { get { return default(System.Drawing.Color[]); } set { } }
    public System.Drawing.RectangleF Rectangle { get { return default(System.Drawing.RectangleF); } }
    public System.Drawing.Drawing2D.Matrix Transform { get { return default(System.Drawing.Drawing2D.Matrix); } set { } }
    public System.Drawing.Drawing2D.WrapMode WrapMode { get { return default(System.Drawing.Drawing2D.WrapMode); } set { } }
    public override object Clone() { return default(object); }
    public void MultiplyTransform(System.Drawing.Drawing2D.Matrix matrix) { }
    public void MultiplyTransform(System.Drawing.Drawing2D.Matrix matrix, System.Drawing.Drawing2D.MatrixOrder order) { }
    public void ResetTransform() { }
    public void RotateTransform(float angle) { }
    public void RotateTransform(float angle, System.Drawing.Drawing2D.MatrixOrder order) { }
    public void ScaleTransform(float sx, float sy) { }
    public void ScaleTransform(float sx, float sy, System.Drawing.Drawing2D.MatrixOrder order) { }
    public void SetBlendTriangularShape(float focus) { }
    public void SetBlendTriangularShape(float focus, float scale) { }
    public void SetSigmaBellShape(float focus) { }
    public void SetSigmaBellShape(float focus, float scale) { }
    public void TranslateTransform(float dx, float dy) { }
    public void TranslateTransform(float dx, float dy, System.Drawing.Drawing2D.MatrixOrder order) { }
  }
  public enum LinearGradientMode {
    BackwardDiagonal = 3,
    ForwardDiagonal = 2,
    Horizontal = 0,
    Vertical = 1,
  }
  public enum LineCap {
    AnchorMask = 240,
    ArrowAnchor = 20,
    Custom = 255,
    DiamondAnchor = 19,
    Flat = 0,
    NoAnchor = 16,
    Round = 2,
    RoundAnchor = 18,
    Square = 1,
    SquareAnchor = 17,
    Triangle = 3,
  }
  public enum LineJoin {
    Bevel = 1,
    Miter = 0,
    MiterClipped = 3,
    Round = 2,
  }
  public sealed partial class Matrix : System.MarshalByRefObject, System.IDisposable {
    public Matrix() { }
    public Matrix(System.Drawing.Rectangle rect, System.Drawing.Point[] plgpts) { }
    public Matrix(System.Drawing.RectangleF rect, System.Drawing.PointF[] plgpts) { }
    public Matrix(float m11, float m12, float m21, float m22, float dx, float dy) { }
    public System.Single[] Elements { get { return default(System.Single[]); } }
    public bool IsIdentity { get { return default(bool); } }
    public bool IsInvertible { get { return default(bool); } }
    public float OffsetX { get { return default(float); } }
    public float OffsetY { get { return default(float); } }
    public System.Drawing.Drawing2D.Matrix Clone() { return default(System.Drawing.Drawing2D.Matrix); }
    public void Dispose() { }
    public override bool Equals(object obj) { return default(bool); }
    ~Matrix() { }
    public override int GetHashCode() { return default(int); }
    public void Invert() { }
    public void Multiply(System.Drawing.Drawing2D.Matrix matrix) { }
    public void Multiply(System.Drawing.Drawing2D.Matrix matrix, System.Drawing.Drawing2D.MatrixOrder order) { }
    public void Reset() { }
    public void Rotate(float angle) { }
    public void Rotate(float angle, System.Drawing.Drawing2D.MatrixOrder order) { }
    public void RotateAt(float angle, System.Drawing.PointF point) { }
    public void RotateAt(float angle, System.Drawing.PointF point, System.Drawing.Drawing2D.MatrixOrder order) { }
    public void Scale(float scaleX, float scaleY) { }
    public void Scale(float scaleX, float scaleY, System.Drawing.Drawing2D.MatrixOrder order) { }
    public void Shear(float shearX, float shearY) { }
    public void Shear(float shearX, float shearY, System.Drawing.Drawing2D.MatrixOrder order) { }
    public void TransformPoints(System.Drawing.Point[] pts) { }
    public void TransformPoints(System.Drawing.PointF[] pts) { }
    public void TransformVectors(System.Drawing.Point[] pts) { }
    public void TransformVectors(System.Drawing.PointF[] pts) { }
    public void Translate(float offsetX, float offsetY) { }
    public void Translate(float offsetX, float offsetY, System.Drawing.Drawing2D.MatrixOrder order) { }
    public void VectorTransformPoints(System.Drawing.Point[] pts) { }
  }
  public enum MatrixOrder {
    Append = 1,
    Prepend = 0,
  }
  public sealed partial class PathData {
    public PathData() { }
    public System.Drawing.PointF[] Points { get { return default(System.Drawing.PointF[]); } set { } }
    public System.Byte[] Types { get { return default(System.Byte[]); } set { } }
  }
  public sealed partial class PathGradientBrush : System.Drawing.Brush {
    public PathGradientBrush(System.Drawing.Drawing2D.GraphicsPath path) { }
    public PathGradientBrush(System.Drawing.Point[] points) { }
    public PathGradientBrush(System.Drawing.Point[] points, System.Drawing.Drawing2D.WrapMode wrapMode) { }
    public PathGradientBrush(System.Drawing.PointF[] points) { }
    public PathGradientBrush(System.Drawing.PointF[] points, System.Drawing.Drawing2D.WrapMode wrapMode) { }
    public System.Drawing.Drawing2D.Blend Blend { get { return default(System.Drawing.Drawing2D.Blend); } set { } }
    public System.Drawing.Color CenterColor { get { return default(System.Drawing.Color); } set { } }
    public System.Drawing.PointF CenterPoint { get { return default(System.Drawing.PointF); } set { } }
    public System.Drawing.PointF FocusScales { get { return default(System.Drawing.PointF); } set { } }
    public System.Drawing.Drawing2D.ColorBlend InterpolationColors { get { return default(System.Drawing.Drawing2D.ColorBlend); } set { } }
    public System.Drawing.RectangleF Rectangle { get { return default(System.Drawing.RectangleF); } }
    public System.Drawing.Color[] SurroundColors { get { return default(System.Drawing.Color[]); } set { } }
    public System.Drawing.Drawing2D.Matrix Transform { get { return default(System.Drawing.Drawing2D.Matrix); } set { } }
    public System.Drawing.Drawing2D.WrapMode WrapMode { get { return default(System.Drawing.Drawing2D.WrapMode); } set { } }
    public override object Clone() { return default(object); }
    public void MultiplyTransform(System.Drawing.Drawing2D.Matrix matrix) { }
    public void MultiplyTransform(System.Drawing.Drawing2D.Matrix matrix, System.Drawing.Drawing2D.MatrixOrder order) { }
    public void ResetTransform() { }
    public void RotateTransform(float angle) { }
    public void RotateTransform(float angle, System.Drawing.Drawing2D.MatrixOrder order) { }
    public void ScaleTransform(float sx, float sy) { }
    public void ScaleTransform(float sx, float sy, System.Drawing.Drawing2D.MatrixOrder order) { }
    public void SetBlendTriangularShape(float focus) { }
    public void SetBlendTriangularShape(float focus, float scale) { }
    public void SetSigmaBellShape(float focus) { }
    public void SetSigmaBellShape(float focus, float scale) { }
    public void TranslateTransform(float dx, float dy) { }
    public void TranslateTransform(float dx, float dy, System.Drawing.Drawing2D.MatrixOrder order) { }
  }
  public enum PathPointType {
    Bezier = 3,
    Bezier3 = 3,
    CloseSubpath = 128,
    DashMode = 16,
    Line = 1,
    PathMarker = 32,
    PathTypeMask = 7,
    Start = 0,
  }
  public enum PenAlignment {
    Center = 0,
    Inset = 1,
    Left = 3,
    Outset = 2,
    Right = 4,
  }
  public enum PenType {
    HatchFill = 1,
    LinearGradient = 4,
    PathGradient = 3,
    SolidColor = 0,
    TextureFill = 2,
  }
  public enum PixelOffsetMode {
    Default = 0,
    Half = 4,
    HighQuality = 2,
    HighSpeed = 1,
    Invalid = -1,
    None = 3,
  }
  public enum QualityMode {
    Default = 0,
    High = 2,
    Invalid = -1,
    Low = 1,
  }
  public sealed partial class RegionData {
    internal RegionData() { }
    public System.Byte[] Data { get { return default(System.Byte[]); } set { } }
  }
  public enum SmoothingMode {
    AntiAlias = 4,
    Default = 0,
    HighQuality = 2,
    HighSpeed = 1,
    Invalid = -1,
    None = 3,
  }
  public enum WarpMode {
    Bilinear = 1,
    Perspective = 0,
  }
  public enum WrapMode {
    Clamp = 4,
    Tile = 0,
    TileFlipX = 1,
    TileFlipXY = 3,
    TileFlipY = 2,
  }
}
namespace System.Drawing.Imaging {
  public sealed partial class BitmapData {
    public BitmapData() { }
    public int Height { get { return default(int); } set { } }
    public System.Drawing.Imaging.PixelFormat PixelFormat { get { return default(System.Drawing.Imaging.PixelFormat); } set { } }
    public int Reserved { get { return default(int); } set { } }
    public System.IntPtr Scan0 { get { return default(System.IntPtr); } set { } }
    public int Stride { get { return default(int); } set { } }
    public int Width { get { return default(int); } set { } }
  }
  public enum ColorAdjustType {
    Any = 6,
    Bitmap = 1,
    Brush = 2,
    Count = 5,
    Default = 0,
    Pen = 3,
    Text = 4,
  }
  public enum ColorChannelFlag {
    ColorChannelC = 0,
    ColorChannelK = 3,
    ColorChannelLast = 4,
    ColorChannelM = 1,
    ColorChannelY = 2,
  }
  public sealed partial class ColorMap {
    public ColorMap() { }
    public System.Drawing.Color NewColor { get { return default(System.Drawing.Color); } set { } }
    public System.Drawing.Color OldColor { get { return default(System.Drawing.Color); } set { } }
  }
  public enum ColorMapType {
    Brush = 1,
    Default = 0,
  }
  public sealed partial class ColorMatrix {
    public ColorMatrix() { }
    [System.CLSCompliantAttribute(false)]
    public ColorMatrix(System.Single[][] newColorMatrix) { }
    public float this[int row, int column] { get { return default(float); } set { } }
    public float Matrix00 { get { return default(float); } set { } }
    public float Matrix01 { get { return default(float); } set { } }
    public float Matrix02 { get { return default(float); } set { } }
    public float Matrix03 { get { return default(float); } set { } }
    public float Matrix04 { get { return default(float); } set { } }
    public float Matrix10 { get { return default(float); } set { } }
    public float Matrix11 { get { return default(float); } set { } }
    public float Matrix12 { get { return default(float); } set { } }
    public float Matrix13 { get { return default(float); } set { } }
    public float Matrix14 { get { return default(float); } set { } }
    public float Matrix20 { get { return default(float); } set { } }
    public float Matrix21 { get { return default(float); } set { } }
    public float Matrix22 { get { return default(float); } set { } }
    public float Matrix23 { get { return default(float); } set { } }
    public float Matrix24 { get { return default(float); } set { } }
    public float Matrix30 { get { return default(float); } set { } }
    public float Matrix31 { get { return default(float); } set { } }
    public float Matrix32 { get { return default(float); } set { } }
    public float Matrix33 { get { return default(float); } set { } }
    public float Matrix34 { get { return default(float); } set { } }
    public float Matrix40 { get { return default(float); } set { } }
    public float Matrix41 { get { return default(float); } set { } }
    public float Matrix42 { get { return default(float); } set { } }
    public float Matrix43 { get { return default(float); } set { } }
    public float Matrix44 { get { return default(float); } set { } }
  }
  public enum ColorMatrixFlag {
    AltGrays = 2,
    Default = 0,
    SkipGrays = 1,
  }
  public enum ColorMode {
    Argb32Mode = 0,
    Argb64Mode = 1,
  }
  public sealed partial class ColorPalette {
    internal ColorPalette() { }
    public System.Drawing.Color[] Entries { get { return default(System.Drawing.Color[]); } }
    public int Flags { get { return default(int); } }
  }
  public enum EmfPlusRecordType {
    BeginContainer = 16423,
    BeginContainerNoParams = 16424,
    Clear = 16393,
    Comment = 16387,
    DrawArc = 16402,
    DrawBeziers = 16409,
    DrawClosedCurve = 16407,
    DrawCurve = 16408,
    DrawDriverString = 16438,
    DrawEllipse = 16399,
    DrawImage = 16410,
    DrawImagePoints = 16411,
    DrawLines = 16397,
    DrawPath = 16405,
    DrawPie = 16401,
    DrawRects = 16395,
    DrawString = 16412,
    EmfAbortPath = 68,
    EmfAlphaBlend = 114,
    EmfAngleArc = 41,
    EmfArcTo = 55,
    EmfBeginPath = 59,
    EmfBitBlt = 76,
    EmfChord = 46,
    EmfCloseFigure = 61,
    EmfColorCorrectPalette = 111,
    EmfColorMatchToTargetW = 121,
    EmfCreateBrushIndirect = 39,
    EmfCreateColorSpace = 99,
    EmfCreateColorSpaceW = 122,
    EmfCreateDibPatternBrushPt = 94,
    EmfCreateMonoBrush = 93,
    EmfCreatePalette = 49,
    EmfCreatePen = 38,
    EmfDeleteColorSpace = 101,
    EmfDeleteObject = 40,
    EmfDrawEscape = 105,
    EmfEllipse = 42,
    EmfEndPath = 60,
    EmfEof = 14,
    EmfExcludeClipRect = 29,
    EmfExtCreateFontIndirect = 82,
    EmfExtCreatePen = 95,
    EmfExtEscape = 106,
    EmfExtFloodFill = 53,
    EmfExtSelectClipRgn = 75,
    EmfExtTextOutA = 83,
    EmfExtTextOutW = 84,
    EmfFillPath = 62,
    EmfFillRgn = 71,
    EmfFlattenPath = 65,
    EmfForceUfiMapping = 109,
    EmfFrameRgn = 72,
    EmfGdiComment = 70,
    EmfGlsBoundedRecord = 103,
    EmfGlsRecord = 102,
    EmfGradientFill = 118,
    EmfHeader = 1,
    EmfIntersectClipRect = 30,
    EmfInvertRgn = 73,
    EmfLineTo = 54,
    EmfMaskBlt = 78,
    EmfMax = 122,
    EmfMin = 1,
    EmfModifyWorldTransform = 36,
    EmfMoveToEx = 27,
    EmfNamedEscpae = 110,
    EmfOffsetClipRgn = 26,
    EmfPaintRgn = 74,
    EmfPie = 47,
    EmfPixelFormat = 104,
    EmfPlgBlt = 79,
    EmfPlusRecordBase = 16384,
    EmfPolyBezier = 2,
    EmfPolyBezier16 = 85,
    EmfPolyBezierTo = 5,
    EmfPolyBezierTo16 = 88,
    EmfPolyDraw = 56,
    EmfPolyDraw16 = 92,
    EmfPolygon = 3,
    EmfPolygon16 = 86,
    EmfPolyline = 4,
    EmfPolyline16 = 87,
    EmfPolyLineTo = 6,
    EmfPolylineTo16 = 89,
    EmfPolyPolygon = 8,
    EmfPolyPolygon16 = 91,
    EmfPolyPolyline = 7,
    EmfPolyPolyline16 = 90,
    EmfPolyTextOutA = 96,
    EmfPolyTextOutW = 97,
    EmfRealizePalette = 52,
    EmfRectangle = 43,
    EmfReserved069 = 69,
    EmfReserved117 = 117,
    EmfResizePalette = 51,
    EmfRestoreDC = 34,
    EmfRoundArc = 45,
    EmfRoundRect = 44,
    EmfSaveDC = 33,
    EmfScaleViewportExtEx = 31,
    EmfScaleWindowExtEx = 32,
    EmfSelectClipPath = 67,
    EmfSelectObject = 37,
    EmfSelectPalette = 48,
    EmfSetArcDirection = 57,
    EmfSetBkColor = 25,
    EmfSetBkMode = 18,
    EmfSetBrushOrgEx = 13,
    EmfSetColorAdjustment = 23,
    EmfSetColorSpace = 100,
    EmfSetDIBitsToDevice = 80,
    EmfSetIcmMode = 98,
    EmfSetIcmProfileA = 112,
    EmfSetIcmProfileW = 113,
    EmfSetLayout = 115,
    EmfSetLinkedUfis = 119,
    EmfSetMapMode = 17,
    EmfSetMapperFlags = 16,
    EmfSetMetaRgn = 28,
    EmfSetMiterLimit = 58,
    EmfSetPaletteEntries = 50,
    EmfSetPixelV = 15,
    EmfSetPolyFillMode = 19,
    EmfSetROP2 = 20,
    EmfSetStretchBltMode = 21,
    EmfSetTextAlign = 22,
    EmfSetTextColor = 24,
    EmfSetTextJustification = 120,
    EmfSetViewportExtEx = 11,
    EmfSetViewportOrgEx = 12,
    EmfSetWindowExtEx = 9,
    EmfSetWindowOrgEx = 10,
    EmfSetWorldTransform = 35,
    EmfSmallTextOut = 108,
    EmfStartDoc = 107,
    EmfStretchBlt = 77,
    EmfStretchDIBits = 81,
    EmfStrokeAndFillPath = 63,
    EmfStrokePath = 64,
    EmfTransparentBlt = 116,
    EmfWidenPath = 66,
    EndContainer = 16425,
    EndOfFile = 16386,
    FillClosedCurve = 16406,
    FillEllipse = 16398,
    FillPath = 16404,
    FillPie = 16400,
    FillPolygon = 16396,
    FillRects = 16394,
    FillRegion = 16403,
    GetDC = 16388,
    Header = 16385,
    Invalid = 16384,
    Max = 16438,
    Min = 16385,
    MultiFormatEnd = 16391,
    MultiFormatSection = 16390,
    MultiFormatStart = 16389,
    MultiplyWorldTransform = 16428,
    Object = 16392,
    OffsetClip = 16437,
    ResetClip = 16433,
    ResetWorldTransform = 16427,
    Restore = 16422,
    RotateWorldTransform = 16431,
    Save = 16421,
    ScaleWorldTransform = 16430,
    SetAntiAliasMode = 16414,
    SetClipPath = 16435,
    SetClipRect = 16434,
    SetClipRegion = 16436,
    SetCompositingMode = 16419,
    SetCompositingQuality = 16420,
    SetInterpolationMode = 16417,
    SetPageTransform = 16432,
    SetPixelOffsetMode = 16418,
    SetRenderingOrigin = 16413,
    SetTextContrast = 16416,
    SetTextRenderingHint = 16415,
    SetWorldTransform = 16426,
    Total = 16439,
    TranslateWorldTransform = 16429,
    WmfAnimatePalette = 66614,
    WmfArc = 67607,
    WmfBitBlt = 67874,
    WmfChord = 67632,
    WmfCreateBrushIndirect = 66300,
    WmfCreateFontIndirect = 66299,
    WmfCreatePalette = 65783,
    WmfCreatePatternBrush = 66041,
    WmfCreatePenIndirect = 66298,
    WmfCreateRegion = 67327,
    WmfDeleteObject = 66032,
    WmfDibBitBlt = 67904,
    WmfDibCreatePatternBrush = 65858,
    WmfDibStretchBlt = 68417,
    WmfEllipse = 66584,
    WmfEscape = 67110,
    WmfExcludeClipRect = 66581,
    WmfExtFloodFill = 66888,
    WmfExtTextOut = 68146,
    WmfFillRegion = 66088,
    WmfFloodFill = 66585,
    WmfFrameRegion = 66601,
    WmfIntersectClipRect = 66582,
    WmfInvertRegion = 65834,
    WmfLineTo = 66067,
    WmfMoveTo = 66068,
    WmfOffsetCilpRgn = 66080,
    WmfOffsetViewportOrg = 66065,
    WmfOffsetWindowOrg = 66063,
    WmfPaintRegion = 65835,
    WmfPatBlt = 67101,
    WmfPie = 67610,
    WmfPolygon = 66340,
    WmfPolyline = 66341,
    WmfPolyPolygon = 66872,
    WmfRealizePalette = 65589,
    WmfRecordBase = 65536,
    WmfRectangle = 66587,
    WmfResizePalette = 65849,
    WmfRestoreDC = 65831,
    WmfRoundRect = 67100,
    WmfSaveDC = 65566,
    WmfScaleViewportExt = 66578,
    WmfScaleWindowExt = 66576,
    WmfSelectClipRegion = 65836,
    WmfSelectObject = 65837,
    WmfSelectPalette = 66100,
    WmfSetBkColor = 66049,
    WmfSetBkMode = 65794,
    WmfSetDibToDev = 68915,
    WmfSetLayout = 65865,
    WmfSetMapMode = 65795,
    WmfSetMapperFlags = 66097,
    WmfSetPalEntries = 65591,
    WmfSetPixel = 66591,
    WmfSetPolyFillMode = 65798,
    WmfSetRelAbs = 65797,
    WmfSetROP2 = 65796,
    WmfSetStretchBltMode = 65799,
    WmfSetTextAlign = 65838,
    WmfSetTextCharExtra = 65800,
    WmfSetTextColor = 66057,
    WmfSetTextJustification = 66058,
    WmfSetViewportExt = 66062,
    WmfSetViewportOrg = 66061,
    WmfSetWindowExt = 66060,
    WmfSetWindowOrg = 66059,
    WmfStretchBlt = 68387,
    WmfStretchDib = 69443,
    WmfTextOut = 66849,
  }
  public enum EmfType {
    EmfOnly = 3,
    EmfPlusDual = 5,
    EmfPlusOnly = 4,
  }
  public sealed partial class Encoder {
    public static readonly System.Drawing.Imaging.Encoder ChrominanceTable;
    public static readonly System.Drawing.Imaging.Encoder ColorDepth;
    public static readonly System.Drawing.Imaging.Encoder Compression;
    public static readonly System.Drawing.Imaging.Encoder LuminanceTable;
    public static readonly System.Drawing.Imaging.Encoder Quality;
    public static readonly System.Drawing.Imaging.Encoder RenderMethod;
    public static readonly System.Drawing.Imaging.Encoder SaveFlag;
    public static readonly System.Drawing.Imaging.Encoder ScanMethod;
    public static readonly System.Drawing.Imaging.Encoder Transformation;
    public static readonly System.Drawing.Imaging.Encoder Version;
    public Encoder(System.Guid guid) { }
    public System.Guid Guid { get { return default(System.Guid); } }
  }
  public sealed partial class EncoderParameter : System.IDisposable {
    public EncoderParameter(System.Drawing.Imaging.Encoder encoder, byte value) { }
    public EncoderParameter(System.Drawing.Imaging.Encoder encoder, byte value, bool undefined) { }
    public EncoderParameter(System.Drawing.Imaging.Encoder encoder, System.Byte[] value) { }
    public EncoderParameter(System.Drawing.Imaging.Encoder encoder, System.Byte[] value, bool undefined) { }
    public EncoderParameter(System.Drawing.Imaging.Encoder encoder, short value) { }
    public EncoderParameter(System.Drawing.Imaging.Encoder encoder, System.Int16[] value) { }
    public EncoderParameter(System.Drawing.Imaging.Encoder encoder, int numberValues, System.Drawing.Imaging.EncoderParameterValueType type, System.IntPtr value) { }
    public EncoderParameter(System.Drawing.Imaging.Encoder encoder, int numerator, int denominator) { }
    [System.ObsoleteAttribute("This constructor has been deprecated. Use EncoderParameter(Encoder encoder, int numberValues, EncoderParameterValueType type, IntPtr value) instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
    public EncoderParameter(System.Drawing.Imaging.Encoder encoder, int NumberOfValues, int Type, int Value) { }
    public EncoderParameter(System.Drawing.Imaging.Encoder encoder, int numerator1, int demoninator1, int numerator2, int demoninator2) { }
    public EncoderParameter(System.Drawing.Imaging.Encoder encoder, System.Int32[] numerator, System.Int32[] denominator) { }
    public EncoderParameter(System.Drawing.Imaging.Encoder encoder, System.Int32[] numerator1, System.Int32[] denominator1, System.Int32[] numerator2, System.Int32[] denominator2) { }
    public EncoderParameter(System.Drawing.Imaging.Encoder encoder, long value) { }
    public EncoderParameter(System.Drawing.Imaging.Encoder encoder, long rangebegin, long rangeend) { }
    public EncoderParameter(System.Drawing.Imaging.Encoder encoder, System.Int64[] value) { }
    public EncoderParameter(System.Drawing.Imaging.Encoder encoder, System.Int64[] rangebegin, System.Int64[] rangeend) { }
    public EncoderParameter(System.Drawing.Imaging.Encoder encoder, string value) { }
    public System.Drawing.Imaging.Encoder Encoder { get { return default(System.Drawing.Imaging.Encoder); } set { } }
    public int NumberOfValues { get { return default(int); } }
    public System.Drawing.Imaging.EncoderParameterValueType Type { get { return default(System.Drawing.Imaging.EncoderParameterValueType); } }
    public System.Drawing.Imaging.EncoderParameterValueType ValueType { get { return default(System.Drawing.Imaging.EncoderParameterValueType); } }
    public void Dispose() { }
    ~EncoderParameter() { }
  }
  public sealed partial class EncoderParameters : System.IDisposable {
    public EncoderParameters() { }
    public EncoderParameters(int count) { }
    public System.Drawing.Imaging.EncoderParameter[] Param { get { return default(System.Drawing.Imaging.EncoderParameter[]); } set { } }
    public void Dispose() { }
  }
  public enum EncoderParameterValueType {
    ValueTypeAscii = 2,
    ValueTypeByte = 1,
    ValueTypeLong = 4,
    ValueTypeLongRange = 6,
    ValueTypeRational = 5,
    ValueTypeRationalRange = 8,
    ValueTypeShort = 3,
    ValueTypeUndefined = 7,
  }
  public enum EncoderValue {
    ColorTypeCMYK = 0,
    ColorTypeYCCK = 1,
    CompressionCCITT3 = 3,
    CompressionCCITT4 = 4,
    CompressionLZW = 2,
    CompressionNone = 6,
    CompressionRle = 5,
    Flush = 20,
    FrameDimensionPage = 23,
    FrameDimensionResolution = 22,
    FrameDimensionTime = 21,
    LastFrame = 19,
    MultiFrame = 18,
    RenderNonProgressive = 12,
    RenderProgressive = 11,
    ScanMethodInterlaced = 7,
    ScanMethodNonInterlaced = 8,
    TransformFlipHorizontal = 16,
    TransformFlipVertical = 17,
    TransformRotate180 = 14,
    TransformRotate270 = 15,
    TransformRotate90 = 13,
    VersionGif87 = 9,
    VersionGif89 = 10,
  }
  public sealed partial class FrameDimension {
    public FrameDimension(System.Guid guid) { }
    public System.Guid Guid { get { return default(System.Guid); } }
    public static System.Drawing.Imaging.FrameDimension Page { get { return default(System.Drawing.Imaging.FrameDimension); } }
    public static System.Drawing.Imaging.FrameDimension Resolution { get { return default(System.Drawing.Imaging.FrameDimension); } }
    public static System.Drawing.Imaging.FrameDimension Time { get { return default(System.Drawing.Imaging.FrameDimension); } }
    public override bool Equals(object o) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
  }
  public sealed partial class ImageAttributes : System.ICloneable, System.IDisposable {
    public ImageAttributes() { }
    public void ClearBrushRemapTable() { }
    public void ClearColorKey() { }
    public void ClearColorKey(System.Drawing.Imaging.ColorAdjustType type) { }
    public void ClearColorMatrix() { }
    public void ClearColorMatrix(System.Drawing.Imaging.ColorAdjustType type) { }
    public void ClearGamma() { }
    public void ClearGamma(System.Drawing.Imaging.ColorAdjustType type) { }
    public void ClearNoOp() { }
    public void ClearNoOp(System.Drawing.Imaging.ColorAdjustType type) { }
    public void ClearOutputChannel() { }
    public void ClearOutputChannel(System.Drawing.Imaging.ColorAdjustType type) { }
    public void ClearOutputChannelColorProfile() { }
    public void ClearOutputChannelColorProfile(System.Drawing.Imaging.ColorAdjustType type) { }
    public void ClearRemapTable() { }
    public void ClearRemapTable(System.Drawing.Imaging.ColorAdjustType type) { }
    public void ClearThreshold() { }
    public void ClearThreshold(System.Drawing.Imaging.ColorAdjustType type) { }
    public object Clone() { return default(object); }
    public void Dispose() { }
    ~ImageAttributes() { }
    public void GetAdjustedPalette(System.Drawing.Imaging.ColorPalette palette, System.Drawing.Imaging.ColorAdjustType type) { }
    public void SetBrushRemapTable(System.Drawing.Imaging.ColorMap[] map) { }
    public void SetColorKey(System.Drawing.Color colorLow, System.Drawing.Color colorHigh) { }
    public void SetColorKey(System.Drawing.Color colorLow, System.Drawing.Color colorHigh, System.Drawing.Imaging.ColorAdjustType type) { }
    public void SetColorMatrices(System.Drawing.Imaging.ColorMatrix newColorMatrix, System.Drawing.Imaging.ColorMatrix grayMatrix) { }
    public void SetColorMatrices(System.Drawing.Imaging.ColorMatrix newColorMatrix, System.Drawing.Imaging.ColorMatrix grayMatrix, System.Drawing.Imaging.ColorMatrixFlag flags) { }
    public void SetColorMatrices(System.Drawing.Imaging.ColorMatrix newColorMatrix, System.Drawing.Imaging.ColorMatrix grayMatrix, System.Drawing.Imaging.ColorMatrixFlag mode, System.Drawing.Imaging.ColorAdjustType type) { }
    public void SetColorMatrix(System.Drawing.Imaging.ColorMatrix newColorMatrix) { }
    public void SetColorMatrix(System.Drawing.Imaging.ColorMatrix newColorMatrix, System.Drawing.Imaging.ColorMatrixFlag flags) { }
    public void SetColorMatrix(System.Drawing.Imaging.ColorMatrix newColorMatrix, System.Drawing.Imaging.ColorMatrixFlag mode, System.Drawing.Imaging.ColorAdjustType type) { }
    public void SetGamma(float gamma) { }
    public void SetGamma(float gamma, System.Drawing.Imaging.ColorAdjustType type) { }
    public void SetNoOp() { }
    public void SetNoOp(System.Drawing.Imaging.ColorAdjustType type) { }
    public void SetOutputChannel(System.Drawing.Imaging.ColorChannelFlag flags) { }
    public void SetOutputChannel(System.Drawing.Imaging.ColorChannelFlag flags, System.Drawing.Imaging.ColorAdjustType type) { }
    public void SetOutputChannelColorProfile(string colorProfileFilename) { }
    public void SetOutputChannelColorProfile(string colorProfileFilename, System.Drawing.Imaging.ColorAdjustType type) { }
    public void SetRemapTable(System.Drawing.Imaging.ColorMap[] map) { }
    public void SetRemapTable(System.Drawing.Imaging.ColorMap[] map, System.Drawing.Imaging.ColorAdjustType type) { }
    public void SetThreshold(float threshold) { }
    public void SetThreshold(float threshold, System.Drawing.Imaging.ColorAdjustType type) { }
    public void SetWrapMode(System.Drawing.Drawing2D.WrapMode mode) { }
    public void SetWrapMode(System.Drawing.Drawing2D.WrapMode mode, System.Drawing.Color color) { }
    public void SetWrapMode(System.Drawing.Drawing2D.WrapMode mode, System.Drawing.Color color, bool clamp) { }
  }
  [System.FlagsAttribute]
  public enum ImageCodecFlags {
    BlockingDecode = 32,
    Builtin = 65536,
    Decoder = 2,
    Encoder = 1,
    SeekableEncode = 16,
    SupportBitmap = 4,
    SupportVector = 8,
    System = 131072,
    User = 262144,
  }
  public sealed partial class ImageCodecInfo {
    internal ImageCodecInfo() { }
    public System.Guid Clsid { get { return default(System.Guid); } set { } }
    public string CodecName { get { return default(string); } set { } }
    public string DllName { get { return default(string); } set { } }
    public string FilenameExtension { get { return default(string); } set { } }
    public System.Drawing.Imaging.ImageCodecFlags Flags { get { return default(System.Drawing.Imaging.ImageCodecFlags); } set { } }
    public string FormatDescription { get { return default(string); } set { } }
    public System.Guid FormatID { get { return default(System.Guid); } set { } }
    public string MimeType { get { return default(string); } set { } }
    [System.CLSCompliantAttribute(false)]
    public System.Byte[][] SignatureMasks { get { return default(System.Byte[][]); } set { } }
    [System.CLSCompliantAttribute(false)]
    public System.Byte[][] SignaturePatterns { get { return default(System.Byte[][]); } set { } }
    public int Version { get { return default(int); } set { } }
    public static System.Drawing.Imaging.ImageCodecInfo[] GetImageDecoders() { return default(System.Drawing.Imaging.ImageCodecInfo[]); }
    public static System.Drawing.Imaging.ImageCodecInfo[] GetImageEncoders() { return default(System.Drawing.Imaging.ImageCodecInfo[]); }
  }
  [System.FlagsAttribute]
  public enum ImageFlags {
    Caching = 131072,
    ColorSpaceCmyk = 32,
    ColorSpaceGray = 64,
    ColorSpaceRgb = 16,
    ColorSpaceYcbcr = 128,
    ColorSpaceYcck = 256,
    HasAlpha = 2,
    HasRealDpi = 4096,
    HasRealPixelSize = 8192,
    HasTranslucent = 4,
    None = 0,
    PartiallyScalable = 8,
    ReadOnly = 65536,
    Scalable = 1,
  }
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ImageFormatConverter))]
  public sealed partial class ImageFormat {
    public ImageFormat(System.Guid guid) { }
    public static System.Drawing.Imaging.ImageFormat Bmp { get { return default(System.Drawing.Imaging.ImageFormat); } }
    public static System.Drawing.Imaging.ImageFormat Emf { get { return default(System.Drawing.Imaging.ImageFormat); } }
    public static System.Drawing.Imaging.ImageFormat Exif { get { return default(System.Drawing.Imaging.ImageFormat); } }
    public static System.Drawing.Imaging.ImageFormat Gif { get { return default(System.Drawing.Imaging.ImageFormat); } }
    public System.Guid Guid { get { return default(System.Guid); } }
    public static System.Drawing.Imaging.ImageFormat Icon { get { return default(System.Drawing.Imaging.ImageFormat); } }
    public static System.Drawing.Imaging.ImageFormat Jpeg { get { return default(System.Drawing.Imaging.ImageFormat); } }
    public static System.Drawing.Imaging.ImageFormat MemoryBmp { get { return default(System.Drawing.Imaging.ImageFormat); } }
    public static System.Drawing.Imaging.ImageFormat Png { get { return default(System.Drawing.Imaging.ImageFormat); } }
    public static System.Drawing.Imaging.ImageFormat Tiff { get { return default(System.Drawing.Imaging.ImageFormat); } }
    public static System.Drawing.Imaging.ImageFormat Wmf { get { return default(System.Drawing.Imaging.ImageFormat); } }
    public override bool Equals(object o) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
  }
  public enum ImageLockMode {
    ReadOnly = 1,
    ReadWrite = 3,
    UserInputBuffer = 4,
    WriteOnly = 2,
  }
  [System.ComponentModel.EditorAttribute("System.Drawing.Design.MetafileEditor, System.Drawing.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(System.Drawing.Design.UITypeEditor))]
  public sealed partial class Metafile : System.Drawing.Image {
    public Metafile(System.IntPtr henhmetafile, bool deleteEmf) { }
    public Metafile(System.IntPtr referenceHdc, System.Drawing.Imaging.EmfType emfType) { }
    public Metafile(System.IntPtr referenceHdc, System.Drawing.Imaging.EmfType emfType, string description) { }
    public Metafile(System.IntPtr hmetafile, System.Drawing.Imaging.WmfPlaceableFileHeader wmfHeader) { }
    public Metafile(System.IntPtr hmetafile, System.Drawing.Imaging.WmfPlaceableFileHeader wmfHeader, bool deleteWmf) { }
    public Metafile(System.IntPtr referenceHdc, System.Drawing.Rectangle frameRect) { }
    public Metafile(System.IntPtr referenceHdc, System.Drawing.Rectangle frameRect, System.Drawing.Imaging.MetafileFrameUnit frameUnit) { }
    public Metafile(System.IntPtr referenceHdc, System.Drawing.Rectangle frameRect, System.Drawing.Imaging.MetafileFrameUnit frameUnit, System.Drawing.Imaging.EmfType type) { }
    public Metafile(System.IntPtr referenceHdc, System.Drawing.Rectangle frameRect, System.Drawing.Imaging.MetafileFrameUnit frameUnit, System.Drawing.Imaging.EmfType type, string desc) { }
    public Metafile(System.IntPtr referenceHdc, System.Drawing.RectangleF frameRect) { }
    public Metafile(System.IntPtr referenceHdc, System.Drawing.RectangleF frameRect, System.Drawing.Imaging.MetafileFrameUnit frameUnit) { }
    public Metafile(System.IntPtr referenceHdc, System.Drawing.RectangleF frameRect, System.Drawing.Imaging.MetafileFrameUnit frameUnit, System.Drawing.Imaging.EmfType type) { }
    public Metafile(System.IntPtr referenceHdc, System.Drawing.RectangleF frameRect, System.Drawing.Imaging.MetafileFrameUnit frameUnit, System.Drawing.Imaging.EmfType type, string description) { }
    public Metafile(System.IO.Stream stream) { }
    public Metafile(System.IO.Stream stream, System.IntPtr referenceHdc) { }
    public Metafile(System.IO.Stream stream, System.IntPtr referenceHdc, System.Drawing.Imaging.EmfType type) { }
    public Metafile(System.IO.Stream stream, System.IntPtr referenceHdc, System.Drawing.Imaging.EmfType type, string description) { }
    public Metafile(System.IO.Stream stream, System.IntPtr referenceHdc, System.Drawing.Rectangle frameRect) { }
    public Metafile(System.IO.Stream stream, System.IntPtr referenceHdc, System.Drawing.Rectangle frameRect, System.Drawing.Imaging.MetafileFrameUnit frameUnit) { }
    public Metafile(System.IO.Stream stream, System.IntPtr referenceHdc, System.Drawing.Rectangle frameRect, System.Drawing.Imaging.MetafileFrameUnit frameUnit, System.Drawing.Imaging.EmfType type) { }
    public Metafile(System.IO.Stream stream, System.IntPtr referenceHdc, System.Drawing.Rectangle frameRect, System.Drawing.Imaging.MetafileFrameUnit frameUnit, System.Drawing.Imaging.EmfType type, string description) { }
    public Metafile(System.IO.Stream stream, System.IntPtr referenceHdc, System.Drawing.RectangleF frameRect) { }
    public Metafile(System.IO.Stream stream, System.IntPtr referenceHdc, System.Drawing.RectangleF frameRect, System.Drawing.Imaging.MetafileFrameUnit frameUnit) { }
    public Metafile(System.IO.Stream stream, System.IntPtr referenceHdc, System.Drawing.RectangleF frameRect, System.Drawing.Imaging.MetafileFrameUnit frameUnit, System.Drawing.Imaging.EmfType type) { }
    public Metafile(System.IO.Stream stream, System.IntPtr referenceHdc, System.Drawing.RectangleF frameRect, System.Drawing.Imaging.MetafileFrameUnit frameUnit, System.Drawing.Imaging.EmfType type, string description) { }
    public Metafile(string filename) { }
    public Metafile(string fileName, System.IntPtr referenceHdc) { }
    public Metafile(string fileName, System.IntPtr referenceHdc, System.Drawing.Imaging.EmfType type) { }
    public Metafile(string fileName, System.IntPtr referenceHdc, System.Drawing.Imaging.EmfType type, string description) { }
    public Metafile(string fileName, System.IntPtr referenceHdc, System.Drawing.Rectangle frameRect) { }
    public Metafile(string fileName, System.IntPtr referenceHdc, System.Drawing.Rectangle frameRect, System.Drawing.Imaging.MetafileFrameUnit frameUnit) { }
    public Metafile(string fileName, System.IntPtr referenceHdc, System.Drawing.Rectangle frameRect, System.Drawing.Imaging.MetafileFrameUnit frameUnit, System.Drawing.Imaging.EmfType type) { }
    public Metafile(string fileName, System.IntPtr referenceHdc, System.Drawing.Rectangle frameRect, System.Drawing.Imaging.MetafileFrameUnit frameUnit, System.Drawing.Imaging.EmfType type, string description) { }
    public Metafile(string fileName, System.IntPtr referenceHdc, System.Drawing.Rectangle frameRect, System.Drawing.Imaging.MetafileFrameUnit frameUnit, string description) { }
    public Metafile(string fileName, System.IntPtr referenceHdc, System.Drawing.RectangleF frameRect) { }
    public Metafile(string fileName, System.IntPtr referenceHdc, System.Drawing.RectangleF frameRect, System.Drawing.Imaging.MetafileFrameUnit frameUnit) { }
    public Metafile(string fileName, System.IntPtr referenceHdc, System.Drawing.RectangleF frameRect, System.Drawing.Imaging.MetafileFrameUnit frameUnit, System.Drawing.Imaging.EmfType type) { }
    public Metafile(string fileName, System.IntPtr referenceHdc, System.Drawing.RectangleF frameRect, System.Drawing.Imaging.MetafileFrameUnit frameUnit, System.Drawing.Imaging.EmfType type, string description) { }
    public Metafile(string fileName, System.IntPtr referenceHdc, System.Drawing.RectangleF frameRect, System.Drawing.Imaging.MetafileFrameUnit frameUnit, string desc) { }
    public System.IntPtr GetHenhmetafile() { return default(System.IntPtr); }
    public System.Drawing.Imaging.MetafileHeader GetMetafileHeader() { return default(System.Drawing.Imaging.MetafileHeader); }
    public static System.Drawing.Imaging.MetafileHeader GetMetafileHeader(System.IntPtr henhmetafile) { return default(System.Drawing.Imaging.MetafileHeader); }
    public static System.Drawing.Imaging.MetafileHeader GetMetafileHeader(System.IntPtr hmetafile, System.Drawing.Imaging.WmfPlaceableFileHeader wmfHeader) { return default(System.Drawing.Imaging.MetafileHeader); }
    public static System.Drawing.Imaging.MetafileHeader GetMetafileHeader(System.IO.Stream stream) { return default(System.Drawing.Imaging.MetafileHeader); }
    public static System.Drawing.Imaging.MetafileHeader GetMetafileHeader(string fileName) { return default(System.Drawing.Imaging.MetafileHeader); }
    public void PlayRecord(System.Drawing.Imaging.EmfPlusRecordType recordType, int flags, int dataSize, System.Byte[] data) { }
  }
  public enum MetafileFrameUnit {
    Document = 5,
    GdiCompatible = 7,
    Inch = 4,
    Millimeter = 6,
    Pixel = 2,
    Point = 3,
  }
  public sealed partial class MetafileHeader {
    internal MetafileHeader() { }
    public System.Drawing.Rectangle Bounds { get { return default(System.Drawing.Rectangle); } }
    public float DpiX { get { return default(float); } }
    public float DpiY { get { return default(float); } }
    public int EmfPlusHeaderSize { get { return default(int); } }
    public int LogicalDpiX { get { return default(int); } }
    public int LogicalDpiY { get { return default(int); } }
    public int MetafileSize { get { return default(int); } }
    public System.Drawing.Imaging.MetafileType Type { get { return default(System.Drawing.Imaging.MetafileType); } }
    public int Version { get { return default(int); } }
    public System.Drawing.Imaging.MetaHeader WmfHeader { get { return default(System.Drawing.Imaging.MetaHeader); } }
    public bool IsDisplay() { return default(bool); }
    public bool IsEmf() { return default(bool); }
    public bool IsEmfOrEmfPlus() { return default(bool); }
    public bool IsEmfPlus() { return default(bool); }
    public bool IsEmfPlusDual() { return default(bool); }
    public bool IsEmfPlusOnly() { return default(bool); }
    public bool IsWmf() { return default(bool); }
    public bool IsWmfPlaceable() { return default(bool); }
  }
  public enum MetafileType {
    Emf = 3,
    EmfPlusDual = 5,
    EmfPlusOnly = 4,
    Invalid = 0,
    Wmf = 1,
    WmfPlaceable = 2,
  }
  public sealed partial class MetaHeader {
    public MetaHeader() { }
    public short HeaderSize { get { return default(short); } set { } }
    public int MaxRecord { get { return default(int); } set { } }
    public short NoObjects { get { return default(short); } set { } }
    public short NoParameters { get { return default(short); } set { } }
    public int Size { get { return default(int); } set { } }
    public short Type { get { return default(short); } set { } }
    public short Version { get { return default(short); } set { } }
  }
  [System.FlagsAttribute]
  public enum PaletteFlags {
    GrayScale = 2,
    Halftone = 4,
    HasAlpha = 1,
  }
  public enum PixelFormat {
    Alpha = 262144,
    Canonical = 2097152,
    DontCare = 0,
    Extended = 1048576,
    Format16bppArgb1555 = 397319,
    Format16bppGrayScale = 1052676,
    Format16bppRgb555 = 135173,
    Format16bppRgb565 = 135174,
    Format1bppIndexed = 196865,
    Format24bppRgb = 137224,
    Format32bppArgb = 2498570,
    Format32bppPArgb = 925707,
    Format32bppRgb = 139273,
    Format48bppRgb = 1060876,
    Format4bppIndexed = 197634,
    Format64bppArgb = 3424269,
    Format64bppPArgb = 1851406,
    Format8bppIndexed = 198659,
    Gdi = 131072,
    Indexed = 65536,
    Max = 15,
    PAlpha = 524288,
    Undefined = 0,
  }
  public delegate void PlayRecordCallback(System.Drawing.Imaging.EmfPlusRecordType recordType, int flags, int dataSize, System.IntPtr recordData);
  public sealed partial class PropertyItem {
    internal PropertyItem() { }
    public int Id { get { return default(int); } set { } }
    public int Len { get { return default(int); } set { } }
    public short Type { get { return default(short); } set { } }
    public System.Byte[] Value { get { return default(System.Byte[]); } set { } }
  }
  public sealed partial class WmfPlaceableFileHeader {
    public WmfPlaceableFileHeader() { }
    public short BboxBottom { get { return default(short); } set { } }
    public short BboxLeft { get { return default(short); } set { } }
    public short BboxRight { get { return default(short); } set { } }
    public short BboxTop { get { return default(short); } set { } }
    public short Checksum { get { return default(short); } set { } }
    public short Hmf { get { return default(short); } set { } }
    public short Inch { get { return default(short); } set { } }
    public int Key { get { return default(int); } set { } }
    public int Reserved { get { return default(int); } set { } }
  }
}
namespace System.Drawing.Printing {
  public enum Duplex {
    Default = -1,
    Horizontal = 3,
    Simplex = 1,
    Vertical = 2,
  }
  public partial class InvalidPrinterException : System.SystemException {
    public InvalidPrinterException(System.Drawing.Printing.PrinterSettings settings) { }
    protected InvalidPrinterException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, SerializationFormatter=true)]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.Printing.MarginsConverter))]
  public partial class Margins : System.ICloneable {
    public Margins() { }
    public Margins(int left, int right, int top, int bottom) { }
    public int Bottom { get { return default(int); } set { } }
    public int Left { get { return default(int); } set { } }
    public int Right { get { return default(int); } set { } }
    public int Top { get { return default(int); } set { } }
    public object Clone() { return default(object); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Drawing.Printing.Margins m1, System.Drawing.Printing.Margins m2) { return default(bool); }
    public static bool operator !=(System.Drawing.Printing.Margins m1, System.Drawing.Printing.Margins m2) { return default(bool); }
    public override string ToString() { return default(string); }
  }
  public partial class MarginsConverter : System.ComponentModel.ExpandableObjectConverter {
    public MarginsConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
    public override object CreateInstance(System.ComponentModel.ITypeDescriptorContext context, System.Collections.IDictionary propertyValues) { return default(object); }
    public override bool GetCreateInstanceSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
  }
  public partial class PageSettings : System.ICloneable {
    public PageSettings() { }
    public PageSettings(System.Drawing.Printing.PrinterSettings printerSettings) { }
    public System.Drawing.Rectangle Bounds { get { return default(System.Drawing.Rectangle); } }
    public bool Color { get { return default(bool); } set { } }
    public float HardMarginX { get { return default(float); } }
    public float HardMarginY { get { return default(float); } }
    public bool Landscape { get { return default(bool); } set { } }
    public System.Drawing.Printing.Margins Margins { get { return default(System.Drawing.Printing.Margins); } set { } }
    public System.Drawing.Printing.PaperSize PaperSize { get { return default(System.Drawing.Printing.PaperSize); } set { } }
    public System.Drawing.Printing.PaperSource PaperSource { get { return default(System.Drawing.Printing.PaperSource); } set { } }
    public System.Drawing.RectangleF PrintableArea { get { return default(System.Drawing.RectangleF); } }
    public System.Drawing.Printing.PrinterResolution PrinterResolution { get { return default(System.Drawing.Printing.PrinterResolution); } set { } }
    public System.Drawing.Printing.PrinterSettings PrinterSettings { get { return default(System.Drawing.Printing.PrinterSettings); } set { } }
    public object Clone() { return default(object); }
    public void CopyToHdevmode(System.IntPtr hdevmode) { }
    public void SetHdevmode(System.IntPtr hdevmode) { }
    public override string ToString() { return default(string); }
  }
  public enum PaperKind {
    A2 = 66,
    A3 = 8,
    A3Extra = 63,
    A3ExtraTransverse = 68,
    A3Rotated = 76,
    A3Transverse = 67,
    A4 = 9,
    A4Extra = 53,
    A4Plus = 60,
    A4Rotated = 77,
    A4Small = 10,
    A4Transverse = 55,
    A5 = 11,
    A5Extra = 64,
    A5Rotated = 78,
    A5Transverse = 61,
    A6 = 70,
    A6Rotated = 83,
    APlus = 57,
    B4 = 12,
    B4Envelope = 33,
    B4JisRotated = 79,
    B5 = 13,
    B5Envelope = 34,
    B5Extra = 65,
    B5JisRotated = 80,
    B5Transverse = 62,
    B6Envelope = 35,
    B6Jis = 88,
    B6JisRotated = 89,
    BPlus = 58,
    C3Envelope = 29,
    C4Envelope = 30,
    C5Envelope = 28,
    C65Envelope = 32,
    C6Envelope = 31,
    CSheet = 24,
    Custom = 0,
    DLEnvelope = 27,
    DSheet = 25,
    ESheet = 26,
    Executive = 7,
    Folio = 14,
    GermanLegalFanfold = 41,
    GermanStandardFanfold = 40,
    InviteEnvelope = 47,
    IsoB4 = 42,
    ItalyEnvelope = 36,
    JapaneseDoublePostcard = 69,
    JapaneseDoublePostcardRotated = 82,
    JapaneseEnvelopeChouNumber3 = 73,
    JapaneseEnvelopeChouNumber3Rotated = 86,
    JapaneseEnvelopeChouNumber4 = 74,
    JapaneseEnvelopeChouNumber4Rotated = 87,
    JapaneseEnvelopeKakuNumber2 = 71,
    JapaneseEnvelopeKakuNumber2Rotated = 84,
    JapaneseEnvelopeKakuNumber3 = 72,
    JapaneseEnvelopeKakuNumber3Rotated = 85,
    JapaneseEnvelopeYouNumber4 = 91,
    JapaneseEnvelopeYouNumber4Rotated = 92,
    JapanesePostcard = 43,
    JapanesePostcardRotated = 81,
    Ledger = 4,
    Legal = 5,
    LegalExtra = 51,
    Letter = 1,
    LetterExtra = 50,
    LetterExtraTransverse = 56,
    LetterPlus = 59,
    LetterRotated = 75,
    LetterSmall = 2,
    LetterTransverse = 54,
    MonarchEnvelope = 37,
    Note = 18,
    Number10Envelope = 20,
    Number11Envelope = 21,
    Number12Envelope = 22,
    Number14Envelope = 23,
    Number9Envelope = 19,
    PersonalEnvelope = 38,
    Prc16K = 93,
    Prc16KRotated = 106,
    Prc32K = 94,
    Prc32KBig = 95,
    Prc32KBigRotated = 108,
    Prc32KRotated = 107,
    PrcEnvelopeNumber1 = 96,
    PrcEnvelopeNumber10 = 105,
    PrcEnvelopeNumber10Rotated = 118,
    PrcEnvelopeNumber1Rotated = 109,
    PrcEnvelopeNumber2 = 97,
    PrcEnvelopeNumber2Rotated = 110,
    PrcEnvelopeNumber3 = 98,
    PrcEnvelopeNumber3Rotated = 111,
    PrcEnvelopeNumber4 = 99,
    PrcEnvelopeNumber4Rotated = 112,
    PrcEnvelopeNumber5 = 100,
    PrcEnvelopeNumber5Rotated = 113,
    PrcEnvelopeNumber6 = 101,
    PrcEnvelopeNumber6Rotated = 114,
    PrcEnvelopeNumber7 = 102,
    PrcEnvelopeNumber7Rotated = 115,
    PrcEnvelopeNumber8 = 103,
    PrcEnvelopeNumber8Rotated = 116,
    PrcEnvelopeNumber9 = 104,
    PrcEnvelopeNumber9Rotated = 117,
    Quarto = 15,
    Standard10x11 = 45,
    Standard10x14 = 16,
    Standard11x17 = 17,
    Standard12x11 = 90,
    Standard15x11 = 46,
    Standard9x11 = 44,
    Statement = 6,
    Tabloid = 3,
    TabloidExtra = 52,
    USStandardFanfold = 39,
  }
  public partial class PaperSize {
    public PaperSize() { }
    public PaperSize(string name, int width, int height) { }
    public int Height { get { return default(int); } set { } }
    public System.Drawing.Printing.PaperKind Kind { get { return default(System.Drawing.Printing.PaperKind); } }
    public string PaperName { get { return default(string); } set { } }
    public int RawKind { get { return default(int); } set { } }
    public int Width { get { return default(int); } set { } }
    public override string ToString() { return default(string); }
  }
  public partial class PaperSource {
    public PaperSource() { }
    public System.Drawing.Printing.PaperSourceKind Kind { get { return default(System.Drawing.Printing.PaperSourceKind); } }
    public int RawKind { get { return default(int); } set { } }
    public string SourceName { get { return default(string); } set { } }
    public override string ToString() { return default(string); }
  }
  public enum PaperSourceKind {
    AutomaticFeed = 7,
    Cassette = 14,
    Custom = 257,
    Envelope = 5,
    FormSource = 15,
    LargeCapacity = 11,
    LargeFormat = 10,
    Lower = 2,
    Manual = 4,
    ManualFeed = 6,
    Middle = 3,
    SmallFormat = 9,
    TractorFeed = 8,
    Upper = 1,
  }
  public sealed partial class PreviewPageInfo {
    public PreviewPageInfo(System.Drawing.Image image, System.Drawing.Size physicalSize) { }
    public System.Drawing.Image Image { get { return default(System.Drawing.Image); } }
    public System.Drawing.Size PhysicalSize { get { return default(System.Drawing.Size); } }
  }
  public partial class PreviewPrintController : System.Drawing.Printing.PrintController {
    public PreviewPrintController() { }
    public override bool IsPreview { get { return default(bool); } }
    public virtual bool UseAntiAlias { get { return default(bool); } set { } }
    public System.Drawing.Printing.PreviewPageInfo[] GetPreviewPageInfo() { return default(System.Drawing.Printing.PreviewPageInfo[]); }
    public override void OnEndPage(System.Drawing.Printing.PrintDocument document, System.Drawing.Printing.PrintPageEventArgs e) { }
    public override void OnEndPrint(System.Drawing.Printing.PrintDocument document, System.Drawing.Printing.PrintEventArgs e) { }
    public override System.Drawing.Graphics OnStartPage(System.Drawing.Printing.PrintDocument document, System.Drawing.Printing.PrintPageEventArgs e) { return default(System.Drawing.Graphics); }
    public override void OnStartPrint(System.Drawing.Printing.PrintDocument document, System.Drawing.Printing.PrintEventArgs e) { }
  }
  public enum PrintAction {
    PrintToFile = 0,
    PrintToPreview = 1,
    PrintToPrinter = 2,
  }
  public abstract partial class PrintController {
    protected PrintController() { }
    public virtual bool IsPreview { get { return default(bool); } }
    public virtual void OnEndPage(System.Drawing.Printing.PrintDocument document, System.Drawing.Printing.PrintPageEventArgs e) { }
    public virtual void OnEndPrint(System.Drawing.Printing.PrintDocument document, System.Drawing.Printing.PrintEventArgs e) { }
    public virtual System.Drawing.Graphics OnStartPage(System.Drawing.Printing.PrintDocument document, System.Drawing.Printing.PrintPageEventArgs e) { return default(System.Drawing.Graphics); }
    public virtual void OnStartPrint(System.Drawing.Printing.PrintDocument document, System.Drawing.Printing.PrintEventArgs e) { }
  }
  [System.ComponentModel.DefaultEventAttribute("PrintPage")]
  [System.ComponentModel.DefaultPropertyAttribute("DocumentName")]
  [System.ComponentModel.ToolboxItemFilterAttribute("System.Drawing.Printing")]
  [System.Drawing.SRDescriptionAttribute("PrintDocumentDesc")]
  public partial class PrintDocument : System.ComponentModel.Component {
    public PrintDocument() { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Drawing.SRDescriptionAttribute("PDOCdocumentPageSettingsDescr")]
    public System.Drawing.Printing.PageSettings DefaultPageSettings { get { return default(System.Drawing.Printing.PageSettings); } set { } }
    [System.ComponentModel.DefaultValueAttribute("document")]
    [System.Drawing.SRDescriptionAttribute("PDOCdocumentNameDescr")]
    public string DocumentName { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Drawing.SRDescriptionAttribute("PDOCoriginAtMarginsDescr")]
    public bool OriginAtMargins { get { return default(bool); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Drawing.SRDescriptionAttribute("PDOCprintControllerDescr")]
    public System.Drawing.Printing.PrintController PrintController { get { return default(System.Drawing.Printing.PrintController); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Drawing.SRDescriptionAttribute("PDOCprinterSettingsDescr")]
    public System.Drawing.Printing.PrinterSettings PrinterSettings { get { return default(System.Drawing.Printing.PrinterSettings); } set { } }
    [System.Drawing.SRDescriptionAttribute("PDOCbeginPrintDescr")]
    public event System.Drawing.Printing.PrintEventHandler BeginPrint { add { } remove { } }
    [System.Drawing.SRDescriptionAttribute("PDOCendPrintDescr")]
    public event System.Drawing.Printing.PrintEventHandler EndPrint { add { } remove { } }
    [System.Drawing.SRDescriptionAttribute("PDOCprintPageDescr")]
    public event System.Drawing.Printing.PrintPageEventHandler PrintPage { add { } remove { } }
    [System.Drawing.SRDescriptionAttribute("PDOCqueryPageSettingsDescr")]
    public event System.Drawing.Printing.QueryPageSettingsEventHandler QueryPageSettings { add { } remove { } }
    protected virtual void OnBeginPrint(System.Drawing.Printing.PrintEventArgs e) { }
    protected virtual void OnEndPrint(System.Drawing.Printing.PrintEventArgs e) { }
    protected virtual void OnPrintPage(System.Drawing.Printing.PrintPageEventArgs e) { }
    protected virtual void OnQueryPageSettings(System.Drawing.Printing.QueryPageSettingsEventArgs e) { }
    public void Print() { }
    public override string ToString() { return default(string); }
  }
  public partial class PrinterResolution {
    public PrinterResolution() { }
    public System.Drawing.Printing.PrinterResolutionKind Kind { get { return default(System.Drawing.Printing.PrinterResolutionKind); } set { } }
    public int X { get { return default(int); } set { } }
    public int Y { get { return default(int); } set { } }
    public override string ToString() { return default(string); }
  }
  public enum PrinterResolutionKind {
    Custom = 0,
    Draft = -1,
    High = -4,
    Low = -2,
    Medium = -3,
  }
  public partial class PrinterSettings : System.ICloneable {
    public PrinterSettings() { }
    public bool CanDuplex { get { return default(bool); } }
    public bool Collate { get { return default(bool); } set { } }
    public short Copies { get { return default(short); } set { } }
    public System.Drawing.Printing.PageSettings DefaultPageSettings { get { return default(System.Drawing.Printing.PageSettings); } }
    public System.Drawing.Printing.Duplex Duplex { get { return default(System.Drawing.Printing.Duplex); } set { } }
    public int FromPage { get { return default(int); } set { } }
    public static System.Drawing.Printing.PrinterSettings.StringCollection InstalledPrinters { get { return default(System.Drawing.Printing.PrinterSettings.StringCollection); } }
    public bool IsDefaultPrinter { get { return default(bool); } }
    public bool IsPlotter { get { return default(bool); } }
    public bool IsValid { get { return default(bool); } }
    public int LandscapeAngle { get { return default(int); } }
    public int MaximumCopies { get { return default(int); } }
    public int MaximumPage { get { return default(int); } set { } }
    public int MinimumPage { get { return default(int); } set { } }
    public System.Drawing.Printing.PrinterSettings.PaperSizeCollection PaperSizes { get { return default(System.Drawing.Printing.PrinterSettings.PaperSizeCollection); } }
    public System.Drawing.Printing.PrinterSettings.PaperSourceCollection PaperSources { get { return default(System.Drawing.Printing.PrinterSettings.PaperSourceCollection); } }
    public string PrinterName { get { return default(string); } set { } }
    public System.Drawing.Printing.PrinterSettings.PrinterResolutionCollection PrinterResolutions { get { return default(System.Drawing.Printing.PrinterSettings.PrinterResolutionCollection); } }
    public string PrintFileName { get { return default(string); } set { } }
    public System.Drawing.Printing.PrintRange PrintRange { get { return default(System.Drawing.Printing.PrintRange); } set { } }
    public bool PrintToFile { get { return default(bool); } set { } }
    public bool SupportsColor { get { return default(bool); } }
    public int ToPage { get { return default(int); } set { } }
    public object Clone() { return default(object); }
    public System.Drawing.Graphics CreateMeasurementGraphics() { return default(System.Drawing.Graphics); }
    public System.Drawing.Graphics CreateMeasurementGraphics(bool honorOriginAtMargins) { return default(System.Drawing.Graphics); }
    public System.Drawing.Graphics CreateMeasurementGraphics(System.Drawing.Printing.PageSettings pageSettings) { return default(System.Drawing.Graphics); }
    public System.Drawing.Graphics CreateMeasurementGraphics(System.Drawing.Printing.PageSettings pageSettings, bool honorOriginAtMargins) { return default(System.Drawing.Graphics); }
    public System.IntPtr GetHdevmode() { return default(System.IntPtr); }
    public System.IntPtr GetHdevmode(System.Drawing.Printing.PageSettings pageSettings) { return default(System.IntPtr); }
    public System.IntPtr GetHdevnames() { return default(System.IntPtr); }
    public bool IsDirectPrintingSupported(System.Drawing.Image image) { return default(bool); }
    public bool IsDirectPrintingSupported(System.Drawing.Imaging.ImageFormat imageFormat) { return default(bool); }
    public void SetHdevmode(System.IntPtr hdevmode) { }
    public void SetHdevnames(System.IntPtr hdevnames) { }
    public override string ToString() { return default(string); }
    public partial class PaperSizeCollection : System.Collections.ICollection, System.Collections.IEnumerable {
      public PaperSizeCollection(System.Drawing.Printing.PaperSize[] array) { }
      public int Count { get { return default(int); } }
      public virtual System.Drawing.Printing.PaperSize this[int index] { get { return default(System.Drawing.Printing.PaperSize); } }
      int System.Collections.ICollection.Count { get { return default(int); } }
      bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
      object System.Collections.ICollection.SyncRoot { get { return default(object); } }
      [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
      public int Add(System.Drawing.Printing.PaperSize paperSize) { return default(int); }
      public void CopyTo(System.Drawing.Printing.PaperSize[] paperSizes, int index) { }
      public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
      void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
      System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    }
    public partial class PaperSourceCollection : System.Collections.ICollection, System.Collections.IEnumerable {
      public PaperSourceCollection(System.Drawing.Printing.PaperSource[] array) { }
      public int Count { get { return default(int); } }
      public virtual System.Drawing.Printing.PaperSource this[int index] { get { return default(System.Drawing.Printing.PaperSource); } }
      int System.Collections.ICollection.Count { get { return default(int); } }
      bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
      object System.Collections.ICollection.SyncRoot { get { return default(object); } }
      [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
      public int Add(System.Drawing.Printing.PaperSource paperSource) { return default(int); }
      public void CopyTo(System.Drawing.Printing.PaperSource[] paperSources, int index) { }
      public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
      void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
      System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    }
    public partial class PrinterResolutionCollection : System.Collections.ICollection, System.Collections.IEnumerable {
      public PrinterResolutionCollection(System.Drawing.Printing.PrinterResolution[] array) { }
      public int Count { get { return default(int); } }
      public virtual System.Drawing.Printing.PrinterResolution this[int index] { get { return default(System.Drawing.Printing.PrinterResolution); } }
      int System.Collections.ICollection.Count { get { return default(int); } }
      bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
      object System.Collections.ICollection.SyncRoot { get { return default(object); } }
      [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
      public int Add(System.Drawing.Printing.PrinterResolution printerResolution) { return default(int); }
      public void CopyTo(System.Drawing.Printing.PrinterResolution[] printerResolutions, int index) { }
      public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
      void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
      System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    }
    public partial class StringCollection : System.Collections.ICollection, System.Collections.IEnumerable {
      public StringCollection(System.String[] array) { }
      public int Count { get { return default(int); } }
      public virtual string this[int index] { get { return default(string); } }
      int System.Collections.ICollection.Count { get { return default(int); } }
      bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
      object System.Collections.ICollection.SyncRoot { get { return default(object); } }
      [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
      public int Add(string value) { return default(int); }
      public void CopyTo(System.String[] strings, int index) { }
      public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
      void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
      System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    }
  }
  public enum PrinterUnit {
    Display = 0,
    HundredthsOfAMillimeter = 2,
    TenthsOfAMillimeter = 3,
    ThousandthsOfAnInch = 1,
  }
  public sealed partial class PrinterUnitConvert {
    internal PrinterUnitConvert() { }
    public static double Convert(double value, System.Drawing.Printing.PrinterUnit fromUnit, System.Drawing.Printing.PrinterUnit toUnit) { return default(double); }
    public static System.Drawing.Point Convert(System.Drawing.Point value, System.Drawing.Printing.PrinterUnit fromUnit, System.Drawing.Printing.PrinterUnit toUnit) { return default(System.Drawing.Point); }
    public static System.Drawing.Printing.Margins Convert(System.Drawing.Printing.Margins value, System.Drawing.Printing.PrinterUnit fromUnit, System.Drawing.Printing.PrinterUnit toUnit) { return default(System.Drawing.Printing.Margins); }
    public static System.Drawing.Rectangle Convert(System.Drawing.Rectangle value, System.Drawing.Printing.PrinterUnit fromUnit, System.Drawing.Printing.PrinterUnit toUnit) { return default(System.Drawing.Rectangle); }
    public static System.Drawing.Size Convert(System.Drawing.Size value, System.Drawing.Printing.PrinterUnit fromUnit, System.Drawing.Printing.PrinterUnit toUnit) { return default(System.Drawing.Size); }
    public static int Convert(int value, System.Drawing.Printing.PrinterUnit fromUnit, System.Drawing.Printing.PrinterUnit toUnit) { return default(int); }
  }
  public partial class PrintEventArgs : System.ComponentModel.CancelEventArgs {
    public PrintEventArgs() { }
    public System.Drawing.Printing.PrintAction PrintAction { get { return default(System.Drawing.Printing.PrintAction); } }
  }
  public delegate void PrintEventHandler(object sender, System.Drawing.Printing.PrintEventArgs e);
  public sealed partial class PrintingPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission {
    public PrintingPermission(System.Drawing.Printing.PrintingPermissionLevel printingLevel) { }
    public PrintingPermission(System.Security.Permissions.PermissionState state) { }
    public System.Drawing.Printing.PrintingPermissionLevel Level { get { return default(System.Drawing.Printing.PrintingPermissionLevel); } set { } }
    public override System.Security.IPermission Copy() { return default(System.Security.IPermission); }
    public override void FromXml(System.Security.SecurityElement esd) { }
    public override System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
    public override bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
    public bool IsUnrestricted() { return default(bool); }
    public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
    public override System.Security.IPermission Union(System.Security.IPermission target) { return default(System.Security.IPermission); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
  public sealed partial class PrintingPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute {
    public PrintingPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
    public System.Drawing.Printing.PrintingPermissionLevel Level { get { return default(System.Drawing.Printing.PrintingPermissionLevel); } set { } }
    public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
  }
  public enum PrintingPermissionLevel {
    AllPrinting = 3,
    DefaultPrinting = 2,
    NoPrinting = 0,
    SafePrinting = 1,
  }
  public partial class PrintPageEventArgs : System.EventArgs {
    public PrintPageEventArgs(System.Drawing.Graphics graphics, System.Drawing.Rectangle marginBounds, System.Drawing.Rectangle pageBounds, System.Drawing.Printing.PageSettings pageSettings) { }
    public bool Cancel { get { return default(bool); } set { } }
    public System.Drawing.Graphics Graphics { get { return default(System.Drawing.Graphics); } }
    public bool HasMorePages { get { return default(bool); } set { } }
    public System.Drawing.Rectangle MarginBounds { get { return default(System.Drawing.Rectangle); } }
    public System.Drawing.Rectangle PageBounds { get { return default(System.Drawing.Rectangle); } }
    public System.Drawing.Printing.PageSettings PageSettings { get { return default(System.Drawing.Printing.PageSettings); } }
  }
  public delegate void PrintPageEventHandler(object sender, System.Drawing.Printing.PrintPageEventArgs e);
  public enum PrintRange {
    AllPages = 0,
    CurrentPage = 4194304,
    Selection = 1,
    SomePages = 2,
  }
  public partial class QueryPageSettingsEventArgs : System.Drawing.Printing.PrintEventArgs {
    public QueryPageSettingsEventArgs(System.Drawing.Printing.PageSettings pageSettings) { }
    public System.Drawing.Printing.PageSettings PageSettings { get { return default(System.Drawing.Printing.PageSettings); } set { } }
  }
  public delegate void QueryPageSettingsEventHandler(object sender, System.Drawing.Printing.QueryPageSettingsEventArgs e);
  public partial class StandardPrintController : System.Drawing.Printing.PrintController {
    public StandardPrintController() { }
    public override void OnEndPage(System.Drawing.Printing.PrintDocument document, System.Drawing.Printing.PrintPageEventArgs e) { }
    public override void OnEndPrint(System.Drawing.Printing.PrintDocument document, System.Drawing.Printing.PrintEventArgs e) { }
    public override System.Drawing.Graphics OnStartPage(System.Drawing.Printing.PrintDocument document, System.Drawing.Printing.PrintPageEventArgs e) { return default(System.Drawing.Graphics); }
    public override void OnStartPrint(System.Drawing.Printing.PrintDocument document, System.Drawing.Printing.PrintEventArgs e) { }
  }
}
namespace System.Drawing.Text {
  public abstract partial class FontCollection : System.IDisposable {
    internal FontCollection() { }
    public System.Drawing.FontFamily[] Families { get { return default(System.Drawing.FontFamily[]); } }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    ~FontCollection() { }
  }
  public enum GenericFontFamilies {
    Monospace = 2,
    SansSerif = 1,
    Serif = 0,
  }
  public enum HotkeyPrefix {
    Hide = 2,
    None = 0,
    Show = 1,
  }
  public sealed partial class InstalledFontCollection : System.Drawing.Text.FontCollection {
    public InstalledFontCollection() { }
  }
  public sealed partial class PrivateFontCollection : System.Drawing.Text.FontCollection {
    public PrivateFontCollection() { }
    public void AddFontFile(string filename) { }
    public void AddMemoryFont(System.IntPtr memory, int length) { }
    protected override void Dispose(bool disposing) { }
  }
  public enum TextRenderingHint {
    AntiAlias = 4,
    AntiAliasGridFit = 3,
    ClearTypeGridFit = 5,
    SingleBitPerPixel = 2,
    SingleBitPerPixelGridFit = 1,
    SystemDefault = 0,
  }
}
