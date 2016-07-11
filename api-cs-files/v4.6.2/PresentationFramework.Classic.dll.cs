namespace Microsoft.Windows.Themes {
  public sealed partial class ClassicBorderDecorator : System.Windows.Controls.Decorator {
    public static readonly System.Windows.DependencyProperty BackgroundProperty;
    public static readonly System.Windows.DependencyProperty BorderBrushProperty;
    public static readonly System.Windows.DependencyProperty BorderStyleProperty;
    public static readonly System.Windows.DependencyProperty BorderThicknessProperty;
    public ClassicBorderDecorator() { }
    public System.Windows.Media.Brush Background { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Media.Brush BorderBrush { get { return default(System.Windows.Media.Brush); } set { } }
    public Microsoft.Windows.Themes.ClassicBorderStyle BorderStyle { get { return default(Microsoft.Windows.Themes.ClassicBorderStyle); } set { } }
    public System.Windows.Thickness BorderThickness { get { return default(System.Windows.Thickness); } set { } }
    public static System.Windows.Media.Brush ClassicBorderBrush { get { return default(System.Windows.Media.Brush); } }
    protected override System.Windows.Size ArrangeOverride(System.Windows.Size finalSize) { return default(System.Windows.Size); }
    protected override System.Windows.Size MeasureOverride(System.Windows.Size availableSize) { return default(System.Windows.Size); }
    protected override void OnRender(System.Windows.Media.DrawingContext drawingContext) { }
  }
  public enum ClassicBorderStyle {
    AltPressed = 15,
    AltRaised = 14,
    Etched = 5,
    HorizontalLine = 6,
    None = 0,
    RadioButton = 16,
    Raised = 1,
    RaisedFocused = 3,
    RaisedPressed = 2,
    Sunken = 4,
    TabBottom = 11,
    TabLeft = 10,
    TabRight = 8,
    TabTop = 9,
    ThinPressed = 13,
    ThinRaised = 12,
    VerticalLine = 7,
  }
  public sealed partial class DataGridHeaderBorder : System.Windows.Controls.Border {
    public static readonly System.Windows.DependencyProperty IsClickableProperty;
    public static readonly System.Windows.DependencyProperty IsHoveredProperty;
    public static readonly System.Windows.DependencyProperty IsPressedProperty;
    public static readonly System.Windows.DependencyProperty IsSelectedProperty;
    public static readonly System.Windows.DependencyProperty OrientationProperty;
    public static readonly System.Windows.DependencyProperty SeparatorBrushProperty;
    public static readonly System.Windows.DependencyProperty SeparatorVisibilityProperty;
    public static readonly System.Windows.DependencyProperty SortDirectionProperty;
    public DataGridHeaderBorder() { }
    public bool IsClickable { get { return default(bool); } set { } }
    public bool IsHovered { get { return default(bool); } set { } }
    public bool IsPressed { get { return default(bool); } set { } }
    public bool IsSelected { get { return default(bool); } set { } }
    public System.Windows.Controls.Orientation Orientation { get { return default(System.Windows.Controls.Orientation); } set { } }
    public System.Windows.Media.Brush SeparatorBrush { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Visibility SeparatorVisibility { get { return default(System.Windows.Visibility); } set { } }
    public System.Nullable<System.ComponentModel.ListSortDirection> SortDirection { get { return default(System.Nullable<System.ComponentModel.ListSortDirection>); } set { } }
    protected override System.Windows.Size ArrangeOverride(System.Windows.Size arrangeSize) { return default(System.Windows.Size); }
    protected override System.Windows.Size MeasureOverride(System.Windows.Size constraint) { return default(System.Windows.Size); }
    protected override void OnRender(System.Windows.Media.DrawingContext dc) { }
  }
  public static partial class PlatformCulture {
    public static System.Windows.FlowDirection FlowDirection { get { return default(System.Windows.FlowDirection); } }
  }
  public partial class ProgressBarBrushConverter : System.Windows.Data.IMultiValueConverter {
    public ProgressBarBrushConverter() { }
    public object Convert(System.Object[] values, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) { return default(object); }
    public System.Object[] ConvertBack(object value, System.Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture) { return default(System.Object[]); }
  }
  public sealed partial class SystemDropShadowChrome : System.Windows.Controls.Decorator {
    public static readonly System.Windows.DependencyProperty ColorProperty;
    public static readonly System.Windows.DependencyProperty CornerRadiusProperty;
    public SystemDropShadowChrome() { }
    public System.Windows.Media.Color Color { get { return default(System.Windows.Media.Color); } set { } }
    public System.Windows.CornerRadius CornerRadius { get { return default(System.Windows.CornerRadius); } set { } }
    protected override void OnRender(System.Windows.Media.DrawingContext drawingContext) { }
  }
}
