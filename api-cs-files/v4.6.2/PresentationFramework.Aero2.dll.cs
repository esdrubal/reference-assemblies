namespace Microsoft.Windows.Themes {
  public sealed partial class BulletChrome : System.Windows.FrameworkElement {
    public static readonly System.Windows.DependencyProperty BackgroundProperty;
    public static readonly System.Windows.DependencyProperty BorderBrushProperty;
    public static readonly System.Windows.DependencyProperty IsCheckedProperty;
    public static readonly System.Windows.DependencyProperty IsRoundProperty;
    public static readonly System.Windows.DependencyProperty RenderMouseOverProperty;
    public static readonly System.Windows.DependencyProperty RenderPressedProperty;
    public BulletChrome() { }
    public System.Windows.Media.Brush Background { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Media.Brush BorderBrush { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Nullable<System.Boolean> IsChecked { get { return default(System.Nullable<System.Boolean>); } set { } }
    public bool IsRound { get { return default(bool); } set { } }
    public bool RenderMouseOver { get { return default(bool); } set { } }
    public bool RenderPressed { get { return default(bool); } set { } }
    protected override System.Windows.Size MeasureOverride(System.Windows.Size availableSize) { return default(System.Windows.Size); }
    protected override void OnRender(System.Windows.Media.DrawingContext drawingContext) { }
  }
  public sealed partial class ButtonChrome : System.Windows.Controls.Decorator {
    public static readonly System.Windows.DependencyProperty BackgroundProperty;
    public static readonly System.Windows.DependencyProperty BorderBrushProperty;
    public static readonly System.Windows.DependencyProperty RenderDefaultedProperty;
    public static readonly System.Windows.DependencyProperty RenderMouseOverProperty;
    public static readonly System.Windows.DependencyProperty RenderPressedProperty;
    public static readonly System.Windows.DependencyProperty RoundCornersProperty;
    public ButtonChrome() { }
    public System.Windows.Media.Brush Background { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Media.Brush BorderBrush { get { return default(System.Windows.Media.Brush); } set { } }
    public bool RenderDefaulted { get { return default(bool); } set { } }
    public bool RenderMouseOver { get { return default(bool); } set { } }
    public bool RenderPressed { get { return default(bool); } set { } }
    public bool RoundCorners { get { return default(bool); } set { } }
    protected override System.Windows.Size ArrangeOverride(System.Windows.Size finalSize) { return default(System.Windows.Size); }
    protected override System.Windows.Size MeasureOverride(System.Windows.Size availableSize) { return default(System.Windows.Size); }
    protected override void OnRender(System.Windows.Media.DrawingContext drawingContext) { }
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
  public sealed partial class ListBoxChrome : System.Windows.Controls.Decorator {
    public static readonly System.Windows.DependencyProperty BackgroundProperty;
    public static readonly System.Windows.DependencyProperty BorderBrushProperty;
    public static readonly System.Windows.DependencyProperty BorderThicknessProperty;
    public static readonly System.Windows.DependencyProperty RenderFocusedProperty;
    public static readonly System.Windows.DependencyProperty RenderMouseOverProperty;
    public ListBoxChrome() { }
    public System.Windows.Media.Brush Background { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Media.Brush BorderBrush { get { return default(System.Windows.Media.Brush); } set { } }
    public System.Windows.Thickness BorderThickness { get { return default(System.Windows.Thickness); } set { } }
    public bool RenderFocused { get { return default(bool); } set { } }
    public bool RenderMouseOver { get { return default(bool); } set { } }
    protected override System.Windows.Size ArrangeOverride(System.Windows.Size finalSize) { return default(System.Windows.Size); }
    protected override System.Windows.Size MeasureOverride(System.Windows.Size availableSize) { return default(System.Windows.Size); }
    protected override void OnRender(System.Windows.Media.DrawingContext dc) { }
  }
  public static partial class PlatformCulture {
    public static System.Windows.FlowDirection FlowDirection { get { return default(System.Windows.FlowDirection); } }
  }
  public partial class ProgressBarHighlightConverter : System.Windows.Data.IMultiValueConverter {
    public ProgressBarHighlightConverter() { }
    public object Convert(System.Object[] values, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) { return default(object); }
    public System.Object[] ConvertBack(object value, System.Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture) { return default(System.Object[]); }
  }
  public sealed partial class ScrollChrome : System.Windows.FrameworkElement {
    public static readonly System.Windows.DependencyProperty RenderMouseOverProperty;
    public static readonly System.Windows.DependencyProperty RenderPressedProperty;
    public static readonly System.Windows.DependencyProperty ScrollGlyphProperty;
    public ScrollChrome() { }
    public bool RenderMouseOver { get { return default(bool); } set { } }
    public bool RenderPressed { get { return default(bool); } set { } }
    protected override System.Windows.Size ArrangeOverride(System.Windows.Size finalSize) { return default(System.Windows.Size); }
    public static Microsoft.Windows.Themes.ScrollGlyph GetScrollGlyph(System.Windows.DependencyObject element) { return default(Microsoft.Windows.Themes.ScrollGlyph); }
    protected override System.Windows.Size MeasureOverride(System.Windows.Size availableSize) { return default(System.Windows.Size); }
    protected override void OnRender(System.Windows.Media.DrawingContext drawingContext) { }
    public static void SetScrollGlyph(System.Windows.DependencyObject element, Microsoft.Windows.Themes.ScrollGlyph value) { }
  }
  public enum ScrollGlyph {
    DownArrow = 4,
    HorizontalGripper = 6,
    LeftArrow = 1,
    None = 0,
    RightArrow = 2,
    UpArrow = 3,
    VerticalGripper = 5,
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
