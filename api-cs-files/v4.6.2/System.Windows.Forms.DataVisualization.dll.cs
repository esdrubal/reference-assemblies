namespace System.Windows.Forms.DataVisualization.Charting {
  [System.ComponentModel.DefaultPropertyAttribute("Name")]
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotation_Annotation")]
  public abstract partial class Annotation : System.Windows.Forms.DataVisualization.Charting.ChartNamedElement {
    protected Annotation() { }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.ContentAlignment), "MiddleCenter")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAlignment")]
    public virtual System.Drawing.ContentAlignment Alignment { get { return default(System.Drawing.ContentAlignment); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeEditing")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAllowAnchorMoving3")]
    public virtual bool AllowAnchorMoving { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeEditing")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAllowMoving")]
    public virtual bool AllowMoving { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeEditing")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAllowPathEditing3")]
    public virtual bool AllowPathEditing { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeEditing")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAllowResizing")]
    public virtual bool AllowResizing { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeEditing")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAllowSelecting")]
    public virtual bool AllowSelecting { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeEditing")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAllowTextEditing")]
    public virtual bool AllowTextEditing { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.ContentAlignment), "BottomCenter")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAnchor")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnchorAlignment")]
    public virtual System.Drawing.ContentAlignment AnchorAlignment { get { return default(System.Drawing.ContentAlignment); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.AnchorPointUITypeEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.AnchorPointValueConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAnchor")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnchorDataPoint")]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public virtual System.Windows.Forms.DataVisualization.Charting.DataPoint AnchorDataPoint { get { return default(System.Windows.Forms.DataVisualization.Charting.DataPoint); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAnchor")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnchorDataPointName")]
    public virtual string AnchorDataPointName { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAnchor")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnchorOffsetX3")]
    public virtual double AnchorOffsetX { get { return default(double); } set { } }
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAnchor")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnchorOffsetY3")]
    public virtual double AnchorOffsetY { get { return default(double); } set { } }
    [System.ComponentModel.DefaultValueAttribute(0.0 / 0.0)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.DoubleNanValueConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAnchor")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnchorX")]
    public virtual double AnchorX { get { return default(double); } set { } }
    [System.ComponentModel.DefaultValueAttribute(0.0 / 0.0)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.DoubleNanValueConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAnchor")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnchorY")]
    public virtual double AnchorY { get { return default(double); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public System.Windows.Forms.DataVisualization.Charting.AnnotationGroup AnnotationGroup { get { return default(System.Windows.Forms.DataVisualization.Charting.AnnotationGroup); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotation_AnnotationType")]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public abstract string AnnotationType { get; }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.AnnotationAxisUITypeEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.AnnotationAxisValueConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAnchorAxes")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxisX")]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public virtual System.Windows.Forms.DataVisualization.Charting.Axis AxisX { get { return default(System.Windows.Forms.DataVisualization.Charting.Axis); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAnchorAxes")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxisXName")]
    public virtual string AxisXName { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.AnnotationAxisUITypeEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.AnnotationAxisValueConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAnchorAxes")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxisY")]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public virtual System.Windows.Forms.DataVisualization.Charting.Axis AxisY { get { return default(System.Windows.Forms.DataVisualization.Charting.Axis); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAnchorAxes")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxisYName")]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public virtual string AxisYName { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackColor")]
    public virtual System.Drawing.Color BackColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.GradientStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.GradientEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackGradientStyle")]
    public virtual System.Windows.Forms.DataVisualization.Charting.GradientStyle BackGradientStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.GradientStyle); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.HatchStyleEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackHatchStyle")]
    public virtual System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackSecondaryColor")]
    public virtual System.Drawing.Color BackSecondaryColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(0.0 / 0.0)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.DoubleNanValueConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributePosition")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBottom")]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public virtual double Bottom { get { return default(double); } set { } }
    [System.ComponentModel.DefaultValueAttribute("NotSet")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.LegendAreaNameConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationClipToChartArea")]
    public virtual string ClipToChartArea { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Font), "Microsoft Sans Serif, 8pt")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTextFont")]
    public virtual System.Drawing.Font Font { get { return default(System.Drawing.Font); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeForeColor")]
    public virtual System.Drawing.Color ForeColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.DefaultValueAttribute(0.0 / 0.0)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.DoubleNanValueConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributePosition")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationHeight")]
    public virtual double Height { get { return default(double); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeSelected")]
    public virtual bool IsSelected { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributePosition")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeSizeAlwaysRelative")]
    public virtual bool IsSizeAlwaysRelative { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineColor")]
    public virtual System.Drawing.Color LineColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ChartDashStyle)(5))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineDashStyle")]
    public virtual System.Windows.Forms.DataVisualization.Charting.ChartDashStyle LineDashStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartDashStyle); } set { } }
    [System.ComponentModel.DefaultValueAttribute(1)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineWidth")]
    public virtual int LineWidth { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.ParenthesizePropertyNameAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeName4")]
    public override string Name { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(0.0 / 0.0)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.DoubleNanValueConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributePosition")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeRight3")]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public virtual double Right { get { return default(double); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "128,0,0,0")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeShadowColor")]
    public virtual System.Drawing.Color ShadowColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeShadowOffset")]
    public virtual int ShadowOffset { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeSmartLabels")]
    public System.Windows.Forms.DataVisualization.Charting.AnnotationSmartLabelStyle SmartLabelStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.AnnotationSmartLabelStyle); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.TextStyle), "Default")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTextStyle")]
    public virtual System.Windows.Forms.DataVisualization.Charting.TextStyle TextStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.TextStyle); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeToolTip")]
    public virtual string ToolTip { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.ComponentModel.ParenthesizePropertyNameAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeVisible")]
    public virtual bool Visible { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(0.0 / 0.0)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.DoubleNanValueConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributePosition")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationWidth")]
    public virtual double Width { get { return default(double); } set { } }
    [System.ComponentModel.DefaultValueAttribute(0.0 / 0.0)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.DoubleNanValueConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributePosition")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationBaseX")]
    public virtual double X { get { return default(double); } set { } }
    [System.ComponentModel.DefaultValueAttribute(0.0 / 0.0)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.DoubleNanValueConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributePosition")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationBaseY")]
    public virtual double Y { get { return default(double); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAnchorAxes")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxisYName")]
    public virtual string YAxisName { get { return default(string); } set { } }
    public virtual void BeginPlacement() { }
    public virtual void BringToFront() { }
    protected override void Dispose(bool disposing) { }
    public virtual void EndPlacement() { }
    public virtual void ResizeToContent() { }
    public virtual void SendToBack() { }
    public void SetAnchor(System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint) { }
    public void SetAnchor(System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1, System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2) { }
  }
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotations3")]
  public partial class AnnotationCollection : System.Windows.Forms.DataVisualization.Charting.ChartNamedElementCollection<System.Windows.Forms.DataVisualization.Charting.Annotation> {
    internal AnnotationCollection() { }
    public override System.Windows.Forms.DataVisualization.Charting.Annotation FindByName(string name) { return default(System.Windows.Forms.DataVisualization.Charting.Annotation); }
  }
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationGroup_AnnotationGroup")]
  public partial class AnnotationGroup : System.Windows.Forms.DataVisualization.Charting.Annotation {
    public AnnotationGroup() { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.ContentAlignment), "MiddleCenter")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAlignment")]
    public override System.Drawing.ContentAlignment Alignment { get { return default(System.Drawing.ContentAlignment); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeEditing")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationGroup_AllowAnchorMoving")]
    public override bool AllowAnchorMoving { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeEditing")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAllowMoving")]
    public override bool AllowMoving { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeEditing")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationGroup_AllowPathEditing")]
    public override bool AllowPathEditing { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeEditing")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAllowResizing")]
    public override bool AllowResizing { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeEditing")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAllowSelecting")]
    public override bool AllowSelecting { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeEditing")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAllowTextEditing")]
    public override bool AllowTextEditing { get { return default(bool); } set { } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.AnnotationCollectionEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAnnotations")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationGroup_Annotations")]
    public System.Windows.Forms.DataVisualization.Charting.AnnotationCollection Annotations { get { return default(System.Windows.Forms.DataVisualization.Charting.AnnotationCollection); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationType")]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public override string AnnotationType { get { return default(string); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackColor")]
    public override System.Drawing.Color BackColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.GradientStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.GradientEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackGradientStyle")]
    public override System.Windows.Forms.DataVisualization.Charting.GradientStyle BackGradientStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.GradientStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.HatchStyleEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackHatchStyle")]
    public override System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackSecondaryColor")]
    public override System.Drawing.Color BackSecondaryColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute("NotSet")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.LegendAreaNameConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationGroup_ClipToChartArea")]
    public override string ClipToChartArea { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Font), "Microsoft Sans Serif, 8pt")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTextFont")]
    public override System.Drawing.Font Font { get { return default(System.Drawing.Font); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeForeColor")]
    public override System.Drawing.Color ForeColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationGroup_Selected")]
    public override bool IsSelected { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributePosition")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationGroup_SizeAlwaysRelative")]
    public override bool IsSizeAlwaysRelative { get { return default(bool); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineColor")]
    public override System.Drawing.Color LineColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ChartDashStyle)(5))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineDashStyle")]
    public override System.Windows.Forms.DataVisualization.Charting.ChartDashStyle LineDashStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartDashStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(1)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineWidth")]
    public override int LineWidth { get { return default(int); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "128,0,0,0")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeShadowColor")]
    public override System.Drawing.Color ShadowColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeShadowOffset")]
    public override int ShadowOffset { get { return default(int); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override System.Windows.Forms.DataVisualization.Charting.TextStyle TextStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.TextStyle); } set { } }
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.ComponentModel.ParenthesizePropertyNameAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationGroup_Visible")]
    public override bool Visible { get { return default(bool); } set { } }
    protected override void Dispose(bool disposing) { }
  }
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationPathPoint_AnnotationPathPoint")]
  public partial class AnnotationPathPoint : System.Windows.Forms.DataVisualization.Charting.ChartElement {
    public AnnotationPathPoint() { }
    public AnnotationPathPoint(float x, float y) { }
    public AnnotationPathPoint(float x, float y, byte type) { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute("PathPoint")]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationPathPoint_Name")]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public string Name { get { return default(string); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(byte), "1")]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributePosition")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationPathPoint_Name")]
    public byte PointType { get { return default(byte); } set { } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0f)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributePosition")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationPathPoint_X")]
    public float X { get { return default(float); } set { } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0f)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributePosition")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationPathPoint_Y")]
    public float Y { get { return default(float); } set { } }
  }
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationPathPointCollection_AnnotationPathPointCollection")]
  public partial class AnnotationPathPointCollection : System.Windows.Forms.DataVisualization.Charting.ChartElementCollection<System.Windows.Forms.DataVisualization.Charting.AnnotationPathPoint> {
    public AnnotationPathPointCollection(System.Windows.Forms.DataVisualization.Charting.PolylineAnnotation annotation) { }
    protected override void Dispose(bool disposing) { }
    public override void Invalidate() { }
  }
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationPositionChangingEventArgs_AnnotationPositionChangingEventArgs")]
  public partial class AnnotationPositionChangingEventArgs : System.EventArgs {
    public AnnotationPositionChangingEventArgs() { }
    public System.Windows.Forms.DataVisualization.Charting.Annotation Annotation { get { return default(System.Windows.Forms.DataVisualization.Charting.Annotation); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public System.Drawing.PointF NewAnchorLocation { get { return default(System.Drawing.PointF); } set { } }
    public double NewAnchorLocationX { get { return default(double); } set { } }
    public double NewAnchorLocationY { get { return default(double); } set { } }
    public double NewLocationX { get { return default(double); } set { } }
    public double NewLocationY { get { return default(double); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public System.Drawing.RectangleF NewPosition { get { return default(System.Drawing.RectangleF); } set { } }
    public double NewSizeHeight { get { return default(double); } set { } }
    public double NewSizeWidth { get { return default(double); } set { } }
  }
  [System.ComponentModel.DefaultPropertyAttribute("Enabled")]
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.NoNameExpandableObjectConverter))]
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationSmartLabelsStyle_AnnotationSmartLabelsStyle")]
  public partial class AnnotationSmartLabelStyle : System.Windows.Forms.DataVisualization.Charting.SmartLabelStyle {
    public AnnotationSmartLabelStyle() { }
    public AnnotationSmartLabelStyle(object chartElement) { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Transparent")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCalloutBackColor")]
    public override System.Drawing.Color CalloutBackColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle)(1))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCalloutLineAnchorCapStyle")]
    public override System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle CalloutLineAnchorCapStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCalloutLineColor")]
    public override System.Drawing.Color CalloutLineColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ChartDashStyle)(5))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineDashStyle")]
    public override System.Windows.Forms.DataVisualization.Charting.ChartDashStyle CalloutLineDashStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartDashStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(1)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineWidth")]
    public override int CalloutLineWidth { get { return default(int); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.LabelCalloutStyle)(1))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCalloutStyle3")]
    public override System.Windows.Forms.DataVisualization.Charting.LabelCalloutStyle CalloutStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.LabelCalloutStyle); } set { } }
  }
  public partial class AnovaResult {
    public AnovaResult() { }
    public double DegreeOfFreedomBetweenGroups { get { return default(double); } }
    public double DegreeOfFreedomTotal { get { return default(double); } }
    public double DegreeOfFreedomWithinGroups { get { return default(double); } }
    public double FCriticalValue { get { return default(double); } }
    public double FRatio { get { return default(double); } }
    public double MeanSquareVarianceBetweenGroups { get { return default(double); } }
    public double MeanSquareVarianceWithinGroups { get { return default(double); } }
    public double SumOfSquaresBetweenGroups { get { return default(double); } }
    public double SumOfSquaresTotal { get { return default(double); } }
    public double SumOfSquaresWithinGroups { get { return default(double); } }
  }
  [System.FlagsAttribute]
  public enum AntiAliasingStyles {
    All = 3,
    Graphics = 2,
    None = 0,
    Text = 1,
  }
  [System.FlagsAttribute]
  public enum AreaAlignmentOrientations {
    All = 3,
    Horizontal = 2,
    None = 0,
    Vertical = 1,
  }
  [System.FlagsAttribute]
  public enum AreaAlignmentStyles {
    All = 15,
    AxesView = 4,
    Cursor = 8,
    None = 0,
    PlotPosition = 2,
    Position = 1,
  }
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeArrowAnnotation_ArrowAnnotation")]
  public partial class ArrowAnnotation : System.Windows.Forms.DataVisualization.Charting.Annotation {
    public ArrowAnnotation() { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.ContentAlignment), "TopLeft")]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAnchor")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnchorAlignment")]
    public override System.Drawing.ContentAlignment AnchorAlignment { get { return default(System.Drawing.ContentAlignment); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationType")]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public override string AnnotationType { get { return default(string); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(5)]
    [System.ComponentModel.ParenthesizePropertyNameAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeArrowAnnotation_ArrowSize")]
    public virtual int ArrowSize { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ArrowStyle)(0))]
    [System.ComponentModel.ParenthesizePropertyNameAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeArrowAnnotation_ArrowStyle")]
    public virtual System.Windows.Forms.DataVisualization.Charting.ArrowStyle ArrowStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.ArrowStyle); } set { } }
  }
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeArrowStyle_ArrowStyle")]
  public enum ArrowStyle {
    DoubleArrow = 1,
    Simple = 0,
    Tailed = 2,
  }
  [System.ComponentModel.DefaultPropertyAttribute("Enabled")]
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxis_Axis")]
  public partial class Axis : System.Windows.Forms.DataVisualization.Charting.ChartNamedElement {
    public Axis() { }
    public Axis(System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea, System.Windows.Forms.DataVisualization.Charting.AxisName axisTypeName) { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle)(0))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeArrows")]
    public System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle ArrowStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeType")]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public virtual System.Windows.Forms.DataVisualization.Charting.AxisName AxisName { get { return default(System.Windows.Forms.DataVisualization.Charting.AxisName); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0.0 / 0.0)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.AxisCrossingValueConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeScale")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCrossing")]
    public virtual double Crossing { get { return default(double); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartCollectionEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLabels")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCustomLabels")]
    public System.Windows.Forms.DataVisualization.Charting.CustomLabelsCollection CustomLabels { get { return default(System.Windows.Forms.DataVisualization.Charting.CustomLabelsCollection); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.AxisEnabled), "Auto")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeEnabled7")]
    public System.Windows.Forms.DataVisualization.Charting.AxisEnabled Enabled { get { return default(System.Windows.Forms.DataVisualization.Charting.AxisEnabled); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeInterlacedColor")]
    public System.Drawing.Color InterlacedColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.AxisIntervalValueConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeInterval")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeInterval4")]
    public double Interval { get { return default(double); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode)(0))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeInterval")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeIntervalAutoMode")]
    public System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode IntervalAutoMode { get { return default(System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.AxisIntervalValueConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeInterval")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeIntervalOffset6")]
    public double IntervalOffset { get { return default(double); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType)(0))]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeInterval")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeIntervalOffsetType4")]
    public System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType IntervalOffsetType { get { return default(System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType)(0))]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeInterval")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeIntervalType4")]
    public System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType IntervalType { get { return default(System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeInterlaced")]
    public bool IsInterlaced { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLabels")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLabelsAutoFit")]
    public bool IsLabelAutoFit { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeScale")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLogarithmic")]
    public bool IsLogarithmic { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeScale")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMargin")]
    public bool IsMarginVisible { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMarksNextToAxis")]
    public virtual bool IsMarksNextToAxis { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeScale")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeReverse")]
    public bool IsReversed { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeScale")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeStartFromZero3")]
    public bool IsStartedFromZero { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(10)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLabels")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLabelsAutoFitMaxFontSize")]
    public int LabelAutoFitMaxFontSize { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(6)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLabels")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLabelsAutoFitMinFontSize")]
    public int LabelAutoFitMinFontSize { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)(79))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.FlagsEnumUITypeEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLabels")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLabelsAutoFitStyle")]
    public System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles LabelAutoFitStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.NoNameExpandableObjectConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLabels")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLabelStyle")]
    public System.Windows.Forms.DataVisualization.Charting.LabelStyle LabelStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.LabelStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineColor")]
    public System.Drawing.Color LineColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ChartDashStyle)(5))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineDashStyle")]
    public System.Windows.Forms.DataVisualization.Charting.ChartDashStyle LineDashStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartDashStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(1)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineWidth")]
    public int LineWidth { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(10)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeScale")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLogarithmBase")]
    public double LogarithmBase { get { return default(double); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.NoNameExpandableObjectConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeGridTickMarks")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMajorGrid")]
    public System.Windows.Forms.DataVisualization.Charting.Grid MajorGrid { get { return default(System.Windows.Forms.DataVisualization.Charting.Grid); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.NoNameExpandableObjectConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeGridTickMarks")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMajorTickMark")]
    public System.Windows.Forms.DataVisualization.Charting.TickMark MajorTickMark { get { return default(System.Windows.Forms.DataVisualization.Charting.TickMark); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0.0 / 0.0)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.AxisMinMaxAutoValueConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeScale")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMaximum")]
    public double Maximum { get { return default(double); } set { } }
    [System.ComponentModel.DefaultValueAttribute(75f)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLabels")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxis_MaxAutoSize")]
    public float MaximumAutoSize { get { return default(float); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0.0 / 0.0)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.AxisMinMaxAutoValueConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeScale")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMinimum")]
    public double Minimum { get { return default(double); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.NoNameExpandableObjectConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeGridTickMarks")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMinorGrid")]
    public System.Windows.Forms.DataVisualization.Charting.Grid MinorGrid { get { return default(System.Windows.Forms.DataVisualization.Charting.Grid); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.NoNameExpandableObjectConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeGridTickMarks")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMinorTickMark")]
    public System.Windows.Forms.DataVisualization.Charting.TickMark MinorTickMark { get { return default(System.Windows.Forms.DataVisualization.Charting.TickMark); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxis_Name")]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public override string Name { get { return default(string); } set { } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.NoNameExpandableObjectConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeScale")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeScaleBreakStyle")]
    public virtual System.Windows.Forms.DataVisualization.Charting.AxisScaleBreakStyle ScaleBreakStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.AxisScaleBreakStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.NoNameExpandableObjectConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeDataView")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeView")]
    public System.Windows.Forms.DataVisualization.Charting.AxisScaleView ScaleView { get { return default(System.Windows.Forms.DataVisualization.Charting.AxisScaleView); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.NoNameExpandableObjectConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeDataView")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeScrollBar")]
    public System.Windows.Forms.DataVisualization.Charting.AxisScrollBar ScrollBar { get { return default(System.Windows.Forms.DataVisualization.Charting.AxisScrollBar); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartCollectionEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeStripLines")]
    public System.Windows.Forms.DataVisualization.Charting.StripLinesCollection StripLines { get { return default(System.Windows.Forms.DataVisualization.Charting.StripLinesCollection); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.TextOrientation)(0))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeTitle")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttribute_TextOrientation")]
    public System.Windows.Forms.DataVisualization.Charting.TextOrientation TextOrientation { get { return default(System.Windows.Forms.DataVisualization.Charting.TextOrientation); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeTitle")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTitle6")]
    public string Title { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.StringAlignment), "Center")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeTitle")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTitleAlignment")]
    public System.Drawing.StringAlignment TitleAlignment { get { return default(System.Drawing.StringAlignment); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Font), "Microsoft Sans Serif, 8pt")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeTitle")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTitleFont")]
    public System.Drawing.Font TitleFont { get { return default(System.Drawing.Font); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeTitle")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTitleColor")]
    public System.Drawing.Color TitleForeColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMapArea")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeToolTip")]
    public string ToolTip { get { return default(string); } set { } }
    protected override void Dispose(bool disposing) { }
    public double GetPosition(double axisValue) { return default(double); }
    public double PixelPositionToValue(double position) { return default(double); }
    public double PositionToValue(double position) { return default(double); }
    public void RoundAxisValues() { }
    public double ValueToPixelPosition(double axisValue) { return default(double); }
    public double ValueToPosition(double axisValue) { return default(double); }
  }
  public enum AxisArrowStyle {
    Lines = 3,
    None = 0,
    SharpTriangle = 2,
    Triangle = 1,
  }
  public enum AxisEnabled {
    Auto = 0,
    False = 2,
    True = 1,
  }
  public enum AxisName {
    X = 0,
    X2 = 2,
    Y = 1,
    Y2 = 3,
  }
  [System.ComponentModel.DefaultPropertyAttribute("Enabled")]
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxisScaleBreakStyle_AxisScaleBreakStyle")]
  public partial class AxisScaleBreakStyle {
    public AxisScaleBreakStyle() { }
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.BreakLineStyle)(3))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxisScaleBreakStyle_BreakLineType")]
    public System.Windows.Forms.DataVisualization.Charting.BreakLineStyle BreakLineStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.BreakLineStyle); } set { } }
    [System.ComponentModel.DefaultValueAttribute(25)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxisScaleBreakStyle_CollapsibleSpaceThreshold")]
    public int CollapsibleSpaceThreshold { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.ComponentModel.ParenthesizePropertyNameAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxisScaleBreakStyle_Enabled")]
    public bool Enabled { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineColor")]
    public System.Drawing.Color LineColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ChartDashStyle)(5))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineDashStyle")]
    public System.Windows.Forms.DataVisualization.Charting.ChartDashStyle LineDashStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartDashStyle); } set { } }
    [System.ComponentModel.DefaultValueAttribute(1)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineWidth")]
    public int LineWidth { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute(2)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxisScaleBreakStyle_MaxNumberOfBreaks")]
    public int MaxNumberOfBreaks { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute(1.5)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxisScaleBreakStyle_Spacing")]
    public double Spacing { get { return default(double); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.StartFromZero)(0))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxisScaleBreakStyle_StartFromZero")]
    public System.Windows.Forms.DataVisualization.Charting.StartFromZero StartFromZero { get { return default(System.Windows.Forms.DataVisualization.Charting.StartFromZero); } set { } }
  }
  [System.ComponentModel.DefaultPropertyAttribute("Position")]
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxisDataView_AxisDataView")]
  public partial class AxisScaleView {
    public AxisScaleView() { }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAxisView")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxisDataView_IsZoomed")]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public bool IsZoomed { get { return default(bool); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0.0 / 0.0)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.DoubleNanValueConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAxisView")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxisDataView_MinSize")]
    public double MinSize { get { return default(double); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType)(0))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAxisView")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxisDataView_MinSizeType")]
    public System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType MinSizeType { get { return default(System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0.0 / 0.0)]
    [System.ComponentModel.ParenthesizePropertyNameAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.DoubleDateNanValueConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAxisView")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxisDataView_Position")]
    public double Position { get { return default(double); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0.0 / 0.0)]
    [System.ComponentModel.ParenthesizePropertyNameAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.DoubleNanValueConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAxisView")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxisDataView_Size")]
    public double Size { get { return default(double); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType)(0))]
    [System.ComponentModel.ParenthesizePropertyNameAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAxisView")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxisDataView_SizeType")]
    public System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType SizeType { get { return default(System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(1)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAxisView")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxisDataView_SmallScrollMinSize")]
    public double SmallScrollMinSize { get { return default(double); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType)(0))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAxisView")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxisDataView_SmallScrollMinSizeType")]
    public System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType SmallScrollMinSizeType { get { return default(System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0.0 / 0.0)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.AxisMinMaxAutoValueConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAxisView")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxisDataView_SmallScrollSize")]
    public double SmallScrollSize { get { return default(double); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType)(0))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAxisView")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxisDataView_SmallScrollSizeType")]
    public System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType SmallScrollSizeType { get { return default(System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public double ViewMaximum { get { return default(double); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public double ViewMinimum { get { return default(double); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAxisView")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxisDataView_Zoomable")]
    public bool Zoomable { get { return default(bool); } set { } }
    public void Scroll(System.DateTime newPosition) { }
    public void Scroll(double newPosition) { }
    public void Scroll(System.Windows.Forms.DataVisualization.Charting.ScrollType scrollType) { }
    public void Zoom(double viewStart, double viewEnd) { }
    public void Zoom(double viewPosition, double viewSize, System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType viewSizeType) { }
    public void Zoom(double viewPosition, double viewSize, System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType viewSizeType, bool saveState) { }
    public void ZoomReset() { }
    public void ZoomReset(int numberOfViews) { }
  }
  public partial class AxisScrollBar : System.IDisposable {
    public AxisScrollBar() { }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public System.Windows.Forms.DataVisualization.Charting.Axis Axis { get { return default(System.Windows.Forms.DataVisualization.Charting.Axis); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAxisView")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackColor")]
    public System.Drawing.Color BackColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAxisView")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxisScrollBar_ButtonColor")]
    public System.Drawing.Color ButtonColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ScrollBarButtonStyles)(3))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.FlagsEnumUITypeEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAxisView")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxisScrollBar_Buttons")]
    public System.Windows.Forms.DataVisualization.Charting.ScrollBarButtonStyles ButtonStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.ScrollBarButtonStyles); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public System.Windows.Forms.DataVisualization.Charting.ChartArea ChartArea { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartArea); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAxisView")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxisScrollBar_Enabled")]
    public bool Enabled { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAxisView")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxisScrollBar_PositionInside")]
    public bool IsPositionedInside { get { return default(bool); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public bool IsVisible { get { return default(bool); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAxisView")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineColor")]
    public System.Drawing.Color LineColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(14)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAxisView")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxisScrollBar_Size")]
    public double Size { get { return default(double); } set { } }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
  }
  public enum AxisType {
    Primary = 0,
    Secondary = 1,
  }
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorder3DAnnotation_Border3DAnnotation")]
  public partial class Border3DAnnotation : System.Windows.Forms.DataVisualization.Charting.RectangleAnnotation {
    public Border3DAnnotation() { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationType")]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public override string AnnotationType { get { return default(string); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.LegendConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderSkin")]
    public System.Windows.Forms.DataVisualization.Charting.BorderSkin BorderSkin { get { return default(System.Windows.Forms.DataVisualization.Charting.BorderSkin); } set { } }
  }
  [System.ComponentModel.DefaultPropertyAttribute("SkinStyle")]
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderSkin_BorderSkin")]
  public partial class BorderSkin : System.Windows.Forms.DataVisualization.Charting.ChartElement {
    public BorderSkin() { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Gray")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeFrameBackColor")]
    public System.Drawing.Color BackColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.GradientStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.GradientEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackGradientStyle")]
    public System.Windows.Forms.DataVisualization.Charting.GradientStyle BackGradientStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.GradientStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.HatchStyleEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeFrameBackHatchStyle")]
    public System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ImageValueEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackImage")]
    public string BackImage { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle)(0))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackImageAlign")]
    public System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle BackImageAlignment { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeImageTransparentColor")]
    public System.Drawing.Color BackImageTransparentColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode)(0))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeImageWrapMode")]
    public System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode BackImageWrapMode { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderSkin_FrameBackSecondaryColor")]
    public System.Drawing.Color BackSecondaryColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderColor")]
    public System.Drawing.Color BorderColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ChartDashStyle)(0))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderSkin_FrameBorderDashStyle")]
    public System.Windows.Forms.DataVisualization.Charting.ChartDashStyle BorderDashStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartDashStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(1)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderSkin_FrameBorderWidth")]
    public int BorderWidth { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "White")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderSkin_PageColor")]
    public System.Drawing.Color PageColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle)(0))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.ParenthesizePropertyNameAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderSkin_SkinStyle")]
    public System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle SkinStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle); } set { } }
  }
  public enum BorderSkinStyle {
    Emboss = 1,
    FrameThin1 = 4,
    FrameThin2 = 5,
    FrameThin3 = 6,
    FrameThin4 = 7,
    FrameThin5 = 8,
    FrameThin6 = 9,
    FrameTitle1 = 10,
    FrameTitle2 = 11,
    FrameTitle3 = 12,
    FrameTitle4 = 13,
    FrameTitle5 = 14,
    FrameTitle6 = 15,
    FrameTitle7 = 16,
    FrameTitle8 = 17,
    None = 0,
    Raised = 2,
    Sunken = 3,
  }
  public enum BreakLineStyle {
    None = 0,
    Ragged = 3,
    Straight = 1,
    Wave = 2,
  }
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCalloutAnnotation_CalloutAnnotation")]
  public partial class CalloutAnnotation : System.Windows.Forms.DataVisualization.Charting.TextAnnotation {
    public CalloutAnnotation() { }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.ContentAlignment), "BottomLeft")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAnchor")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnchorAlignment")]
    public override System.Drawing.ContentAlignment AnchorAlignment { get { return default(System.Drawing.ContentAlignment); } set { } }
    [System.ComponentModel.DefaultValueAttribute(3)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAnchor")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCalloutAnnotation_AnchorOffsetX")]
    public override double AnchorOffsetX { get { return default(double); } set { } }
    [System.ComponentModel.DefaultValueAttribute(3)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAnchor")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCalloutAnnotation_AnchorOffsetY")]
    public override double AnchorOffsetY { get { return default(double); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationType")]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public override string AnnotationType { get { return default(string); } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackColor")]
    public override System.Drawing.Color BackColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.GradientStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.GradientEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackGradientStyle")]
    public override System.Windows.Forms.DataVisualization.Charting.GradientStyle BackGradientStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.GradientStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.HatchStyleEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackHatchStyle")]
    public override System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackSecondaryColor")]
    public override System.Drawing.Color BackSecondaryColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCalloutAnnotation_CalloutAnchorCap")]
    public virtual System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle CalloutAnchorCap { get { return default(System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.CalloutStyle)(3))]
    [System.ComponentModel.ParenthesizePropertyNameAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCalloutAnnotation_CalloutStyle")]
    public virtual System.Windows.Forms.DataVisualization.Charting.CalloutStyle CalloutStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.CalloutStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineColor")]
    public override System.Drawing.Color LineColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ChartDashStyle)(5))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineDashStyle")]
    public override System.Windows.Forms.DataVisualization.Charting.ChartDashStyle LineDashStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartDashStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(1)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineWidth")]
    public override int LineWidth { get { return default(int); } set { } }
  }
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCalloutStyle_CalloutStyle")]
  public enum CalloutStyle {
    Borderline = 1,
    Cloud = 2,
    Ellipse = 5,
    Perspective = 6,
    Rectangle = 3,
    RoundedRectangle = 4,
    SimpleLine = 0,
  }
  [System.ComponentModel.Design.Serialization.DesignerSerializerAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartWinDesignerSerializer, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.ComponentModel.Design.Serialization.CodeDomSerializer, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [System.ComponentModel.DesignerAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartWinDesigner, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  [System.ComponentModel.DisplayNameAttribute("Chart")]
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.Chart), "ChartControl.ico")]
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChart_Chart")]
  public partial class Chart : System.Windows.Forms.Control, System.ComponentModel.ISupportInitialize, System.IDisposable {
    public Chart() { }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.AnnotationCollectionEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeChart")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotations3")]
    public System.Windows.Forms.DataVisualization.Charting.AnnotationCollection Annotations { get { return default(System.Windows.Forms.DataVisualization.Charting.AnnotationCollection); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles), "All")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.FlagsEnumUITypeEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeImage")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAntiAlias")]
    public System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles AntiAliasing { get { return default(System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "White")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackColor")]
    public override System.Drawing.Color BackColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.GradientStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.GradientEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackGradientStyle")]
    public System.Windows.Forms.DataVisualization.Charting.GradientStyle BackGradientStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.GradientStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public override System.Drawing.Image BackgroundImage { get { return default(System.Drawing.Image); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.HatchStyleEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackHatchStyle")]
    public System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ImageValueEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackImage")]
    public string BackImage { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle)(0))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackImageAlign")]
    public System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle BackImageAlignment { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeImageTransparentColor")]
    public System.Drawing.Color BackImageTransparentColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode)(0))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeImageWrapMode")]
    public System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode BackImageWrapMode { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackSecondaryColor")]
    public System.Drawing.Color BackSecondaryColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "White")]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderColor")]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public System.Drawing.Color BorderColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ChartDashStyle)(0))]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderDashStyle")]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public System.Windows.Forms.DataVisualization.Charting.ChartDashStyle BorderDashStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartDashStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "White")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderColor")]
    public System.Drawing.Color BorderlineColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ChartDashStyle)(0))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderDashStyle")]
    public System.Windows.Forms.DataVisualization.Charting.ChartDashStyle BorderlineDashStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartDashStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(1)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChart_BorderlineWidth")]
    public int BorderlineWidth { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle)(0))]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.LegendConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderSkin")]
    public System.Windows.Forms.DataVisualization.Charting.BorderSkin BorderSkin { get { return default(System.Windows.Forms.DataVisualization.Charting.BorderSkin); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(1)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChart_BorderlineWidth")]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public int BorderWidth { get { return default(int); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChart_BuildNumber")]
    public string BuildNumber { get { return default(string); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartCollectionEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeChart")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartAreas")]
    public System.Windows.Forms.DataVisualization.Charting.ChartAreaCollection ChartAreas { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartAreaCollection); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeData")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeDataManipulator")]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public System.Windows.Forms.DataVisualization.Charting.DataManipulator DataManipulator { get { return default(System.Windows.Forms.DataVisualization.Charting.DataManipulator); } }
    [System.ComponentModel.AttributeProviderAttribute(typeof(System.ComponentModel.IListSource))]
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeData")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeDataSource")]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public object DataSource { get { return default(object); } set { } }
    protected override System.Drawing.Size DefaultSize { get { return default(System.Drawing.Size); } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Font), "Microsoft Sans Serif, 8pt")]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeCharttitle")]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public new System.Drawing.Font Font { get { return default(System.Drawing.Font); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeForeColor")]
    public override System.Drawing.Color ForeColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeChart")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChart_Images")]
    public System.Windows.Forms.DataVisualization.Charting.NamedImagesCollection Images { get { return default(System.Windows.Forms.DataVisualization.Charting.NamedImagesCollection); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeImage")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChart_SoftShadows")]
    public bool IsSoftShadows { get { return default(bool); } set { } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.LegendCollectionEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeChart")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegends")]
    public System.Windows.Forms.DataVisualization.Charting.LegendCollection Legends { get { return default(System.Windows.Forms.DataVisualization.Charting.LegendCollection); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ChartColorPalette)(12))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ColorPaletteEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributePalette")]
    public System.Windows.Forms.DataVisualization.Charting.ChartColorPalette Palette { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartColorPalette); } set { } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.ColorArrayConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChart_PaletteCustomColors")]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(1))]
    public System.Drawing.Color[] PaletteCustomColors { get { return default(System.Drawing.Color[]); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeChart")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChart_Printing")]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public System.Windows.Forms.DataVisualization.Charting.PrintingManager Printing { get { return default(System.Windows.Forms.DataVisualization.Charting.PrintingManager); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(96)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public double RenderingDpiX { get { return default(double); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(96)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public double RenderingDpiY { get { return default(double); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeSerializer")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChart_Serializer")]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public System.Windows.Forms.DataVisualization.Charting.ChartSerializer Serializer { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartSerializer); } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.SeriesCollectionEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeChart")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChart_Series")]
    public System.Windows.Forms.DataVisualization.Charting.SeriesCollection Series { get { return default(System.Windows.Forms.DataVisualization.Charting.SeriesCollection); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Size), "300, 300")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLayout")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChart_Size")]
    public new System.Drawing.Size Size { get { return default(System.Drawing.Size); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeSuppressExceptions")]
    public bool SuppressExceptions { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality), "High")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeImage")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTextAntiAliasingQuality")]
    public System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality TextAntiAliasingQuality { get { return default(System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality); } set { } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartCollectionEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeChart")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTitles")]
    public System.Windows.Forms.DataVisualization.Charting.TitleCollection Titles { get { return default(System.Windows.Forms.DataVisualization.Charting.TitleCollection); } }
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAnnotation")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartEvent_AnnotationPlaced")]
    public event System.EventHandler AnnotationPlaced { add { } remove { } }
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAnnotation")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartEvent_AnnotationPositionChanged")]
    public event System.EventHandler AnnotationPositionChanged { add { } remove { } }
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAnnotation")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartEvent_AnnotationPositionChanging")]
    public event System.EventHandler<System.Windows.Forms.DataVisualization.Charting.AnnotationPositionChangingEventArgs> AnnotationPositionChanging { add { } remove { } }
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAnnotation")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartEvent_AnnotationSelectionChanged")]
    public event System.EventHandler AnnotationSelectionChanged { add { } remove { } }
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAnnotation")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartEvent_AnnotationTextChanged")]
    public event System.EventHandler AnnotationTextChanged { add { } remove { } }
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAxisView")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartEvent_AxisScrollBarClicked")]
    public event System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ScrollBarEventArgs> AxisScrollBarClicked { add { } remove { } }
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAxisView")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartEvent_AxisViewChanged")]
    public event System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ViewEventArgs> AxisViewChanged { add { } remove { } }
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAxisView")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartEvent_AxisViewChanging")]
    public event System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ViewEventArgs> AxisViewChanging { add { } remove { } }
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeCursor")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartEvent_CursorPositionChanged")]
    public event System.EventHandler<System.Windows.Forms.DataVisualization.Charting.CursorEventArgs> CursorPositionChanged { add { } remove { } }
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeCursor")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartEvent_CursorPositionChanging")]
    public event System.EventHandler<System.Windows.Forms.DataVisualization.Charting.CursorEventArgs> CursorPositionChanging { add { } remove { } }
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartEvent_Customize")]
    public event System.EventHandler Customize { add { } remove { } }
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartEvent_CustomizeLegend")]
    public event System.EventHandler<System.Windows.Forms.DataVisualization.Charting.CustomizeLegendEventArgs> CustomizeLegend { add { } remove { } }
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartEvent_PrePaint")]
    public event System.EventHandler<System.Windows.Forms.DataVisualization.Charting.FormatNumberEventArgs> FormatNumber { add { } remove { } }
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeToolTips")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartEvent_GetToolTipText")]
    public event System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ToolTipEventArgs> GetToolTipText { add { } remove { } }
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartEvent_PostPaint")]
    public event System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ChartPaintEventArgs> PostPaint { add { } remove { } }
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartEvent_PrePaint")]
    public event System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ChartPaintEventArgs> PrePaint { add { } remove { } }
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeCursor")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartEvent_SelectionRangeChanged")]
    public event System.EventHandler<System.Windows.Forms.DataVisualization.Charting.CursorEventArgs> SelectionRangeChanged { add { } remove { } }
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeCursor")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartEvent_SelectionRangeChanging")]
    public event System.EventHandler<System.Windows.Forms.DataVisualization.Charting.CursorEventArgs> SelectionRangeChanging { add { } remove { } }
    public void AlignDataPointsByAxisLabel() { }
    public void AlignDataPointsByAxisLabel(string series) { }
    public void AlignDataPointsByAxisLabel(string series, System.Windows.Forms.DataVisualization.Charting.PointSortOrder sortingOrder) { }
    public void AlignDataPointsByAxisLabel(System.Windows.Forms.DataVisualization.Charting.PointSortOrder sortingOrder) { }
    public void ApplyPaletteColors() { }
    public void BeginInit() { }
    protected override System.Windows.Forms.AccessibleObject CreateAccessibilityInstance() { return default(System.Windows.Forms.AccessibleObject); }
    public void DataBind() { }
    public void DataBindCrossTable(System.Collections.IEnumerable dataSource, string seriesGroupByField, string xField, string yFields, string otherFields) { }
    public void DataBindCrossTable(System.Collections.IEnumerable dataSource, string seriesGroupByField, string xField, string yFields, string otherFields, System.Windows.Forms.DataVisualization.Charting.PointSortOrder sortingOrder) { }
    public void DataBindTable(System.Collections.IEnumerable dataSource) { }
    public void DataBindTable(System.Collections.IEnumerable dataSource, string xField) { }
    protected override void Dispose(bool disposing) { }
    public void EndInit() { }
    public System.Windows.Forms.DataVisualization.Charting.ChartElementOutline GetChartElementOutline(object element, System.Windows.Forms.DataVisualization.Charting.ChartElementType elementType) { return default(System.Windows.Forms.DataVisualization.Charting.ChartElementOutline); }
    public new object GetService(System.Type serviceType) { return default(object); }
    public System.Windows.Forms.DataVisualization.Charting.HitTestResult HitTest(int x, int y) { return default(System.Windows.Forms.DataVisualization.Charting.HitTestResult); }
    public System.Windows.Forms.DataVisualization.Charting.HitTestResult HitTest(int x, int y, bool ignoreTransparent) { return default(System.Windows.Forms.DataVisualization.Charting.HitTestResult); }
    public System.Windows.Forms.DataVisualization.Charting.HitTestResult[] HitTest(int x, int y, bool ignoreTransparent, params System.Windows.Forms.DataVisualization.Charting.ChartElementType[] requestedElement) { return default(System.Windows.Forms.DataVisualization.Charting.HitTestResult[]); }
    public System.Windows.Forms.DataVisualization.Charting.HitTestResult HitTest(int x, int y, System.Windows.Forms.DataVisualization.Charting.ChartElementType requestedElement) { return default(System.Windows.Forms.DataVisualization.Charting.HitTestResult); }
    public new void Invalidate() { }
    public new void Invalidate(System.Drawing.Rectangle rectangle) { }
    public void LoadTemplate(System.IO.Stream stream) { }
    public void LoadTemplate(string name) { }
    protected override void OnCursorChanged(System.EventArgs e) { }
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChart_OnCustomize")]
    protected virtual void OnCustomize() { }
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChart_OnCustomizeLegend")]
    protected virtual void OnCustomizeLegend(System.Windows.Forms.DataVisualization.Charting.LegendItemsCollection legendItems, string legendName) { }
    protected override void OnDoubleClick(System.EventArgs e) { }
    protected virtual void OnFormatNumber(System.Windows.Forms.DataVisualization.Charting.FormatNumberEventArgs e) { }
    protected override void OnLocationChanged(System.EventArgs e) { }
    protected override void OnMouseDown(System.Windows.Forms.MouseEventArgs e) { }
    protected override void OnMouseMove(System.Windows.Forms.MouseEventArgs e) { }
    protected override void OnMouseUp(System.Windows.Forms.MouseEventArgs e) { }
    protected override void OnPaint(System.Windows.Forms.PaintEventArgs e) { }
    protected override void OnPaintBackground(System.Windows.Forms.PaintEventArgs pevent) { }
    protected virtual void OnPostPaint(System.Windows.Forms.DataVisualization.Charting.ChartPaintEventArgs e) { }
    protected virtual void OnPrePaint(System.Windows.Forms.DataVisualization.Charting.ChartPaintEventArgs e) { }
    protected override void OnResize(System.EventArgs e) { }
    protected override void OnRightToLeftChanged(System.EventArgs e) { }
    protected override void OnSystemColorsChanged(System.EventArgs e) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override void Refresh() { }
    public void ResetAutoValues() { }
    public void SaveImage(System.IO.Stream imageStream, System.Drawing.Imaging.ImageFormat format) { }
    public void SaveImage(System.IO.Stream imageStream, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat format) { }
    public void SaveImage(string imageFileName, System.Drawing.Imaging.ImageFormat format) { }
    public void SaveImage(string imageFileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat format) { }
    public void UpdateAnnotations() { }
    public void UpdateCursor() { }
  }
  [System.ComponentModel.DefaultPropertyAttribute("Axes")]
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartArea_ChartArea")]
  public partial class ChartArea : System.Windows.Forms.DataVisualization.Charting.ChartNamedElement {
    public ChartArea() { }
    public ChartArea(string name) { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)(1))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.FlagsEnumUITypeEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAlignment")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartArea_AlignOrientation")]
    public System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations AlignmentOrientation { get { return default(System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles)(15))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.FlagsEnumUITypeEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAlignment")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartArea_AlignType")]
    public System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles AlignmentStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("NotSet")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.LegendAreaNameConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAlignment")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartArea_AlignWithChartArea")]
    public string AlignWithChartArea { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.NoNameExpandableObjectConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttribute3D")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeArea3DStyle")]
    public System.Windows.Forms.DataVisualization.Charting.ChartArea3DStyle Area3DStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartArea3DStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.AxesArrayEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.AxesArrayConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAxes")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartArea_Axes")]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public System.Windows.Forms.DataVisualization.Charting.Axis[] Axes { get { return default(System.Windows.Forms.DataVisualization.Charting.Axis[]); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.NoNameExpandableObjectConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAxis")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartArea_AxisX")]
    public System.Windows.Forms.DataVisualization.Charting.Axis AxisX { get { return default(System.Windows.Forms.DataVisualization.Charting.Axis); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.NoNameExpandableObjectConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAxis")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartArea_AxisX2")]
    public System.Windows.Forms.DataVisualization.Charting.Axis AxisX2 { get { return default(System.Windows.Forms.DataVisualization.Charting.Axis); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.NoNameExpandableObjectConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAxis")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartArea_AxisY")]
    public System.Windows.Forms.DataVisualization.Charting.Axis AxisY { get { return default(System.Windows.Forms.DataVisualization.Charting.Axis); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.NoNameExpandableObjectConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAxis")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartArea_AxisY2")]
    public System.Windows.Forms.DataVisualization.Charting.Axis AxisY2 { get { return default(System.Windows.Forms.DataVisualization.Charting.Axis); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackColor")]
    public System.Drawing.Color BackColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.GradientStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.GradientEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackGradientStyle")]
    public System.Windows.Forms.DataVisualization.Charting.GradientStyle BackGradientStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.GradientStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.HatchStyleEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackHatchStyle")]
    public System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ImageValueEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackImage")]
    public string BackImage { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle)(0))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackImageAlign")]
    public System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle BackImageAlignment { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeImageTransparentColor")]
    public System.Drawing.Color BackImageTransparentColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode)(0))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeImageWrapMode")]
    public System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode BackImageWrapMode { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackSecondaryColor")]
    public System.Drawing.Color BackSecondaryColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderColor")]
    public System.Drawing.Color BorderColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ChartDashStyle)(0))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderDashStyle")]
    public System.Windows.Forms.DataVisualization.Charting.ChartDashStyle BorderDashStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartDashStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(1)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderWidth")]
    public int BorderWidth { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.NoNameExpandableObjectConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeCursor")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartArea_CursorX")]
    public System.Windows.Forms.DataVisualization.Charting.Cursor CursorX { get { return default(System.Windows.Forms.DataVisualization.Charting.Cursor); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.NoNameExpandableObjectConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeCursor")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartArea_CursorY")]
    public System.Windows.Forms.DataVisualization.Charting.Cursor CursorY { get { return default(System.Windows.Forms.DataVisualization.Charting.Cursor); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.ElementPositionConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartArea_InnerPlotPosition")]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(2))]
    public System.Windows.Forms.DataVisualization.Charting.ElementPosition InnerPlotPosition { get { return default(System.Windows.Forms.DataVisualization.Charting.ElementPosition); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartArea_EquallySizedAxesFont")]
    public bool IsSameFontSizeForAllAxes { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartArea_Name")]
    public override string Name { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.ElementPositionConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartArea_Position")]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(2))]
    public System.Windows.Forms.DataVisualization.Charting.ElementPosition Position { get { return default(System.Windows.Forms.DataVisualization.Charting.ElementPosition); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "128,0,0,0")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeShadowColor")]
    public System.Drawing.Color ShadowColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeShadowOffset")]
    public int ShadowOffset { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.ComponentModel.ParenthesizePropertyNameAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartArea_Visible")]
    public virtual bool Visible { get { return default(bool); } set { } }
    protected override void Dispose(bool disposing) { }
    public float GetSeriesDepth(System.Windows.Forms.DataVisualization.Charting.Series series) { return default(float); }
    public float GetSeriesZPosition(System.Windows.Forms.DataVisualization.Charting.Series series) { return default(float); }
    public void RecalculateAxesScale() { }
    public void TransformPoints(System.Windows.Forms.DataVisualization.Charting.Point3D[] points) { }
  }
  public partial class ChartArea3DStyle {
    public ChartArea3DStyle() { }
    public ChartArea3DStyle(System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea) { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.ComponentModel.ParenthesizePropertyNameAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttribute3D")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartArea3DStyle_Enable3D")]
    public bool Enable3D { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(30)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttribute3D")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartArea3DStyle_Inclination")]
    public int Inclination { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttribute3D")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartArea3DStyle_Clustered")]
    public bool IsClustered { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttribute3D")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartArea3DStyle_RightAngleAxes")]
    public bool IsRightAngleAxes { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.LightStyle), "Simplistic")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttribute3D")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartArea3DStyle_Light")]
    public System.Windows.Forms.DataVisualization.Charting.LightStyle LightStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.LightStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttribute3D")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartArea3DStyle_Perspective")]
    public int Perspective { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(100)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttribute3D")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartArea3DStyle_PointDepth")]
    public int PointDepth { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(100)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttribute3D")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartArea3DStyle_PointGapDepth")]
    public int PointGapDepth { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(30)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttribute3D")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartArea3DStyle_Rotation")]
    public int Rotation { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(7)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttribute3D")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartArea3DStyle_WallWidth")]
    public int WallWidth { get { return default(int); } set { } }
  }
  public partial class ChartAreaCollection : System.Windows.Forms.DataVisualization.Charting.ChartNamedElementCollection<System.Windows.Forms.DataVisualization.Charting.ChartArea> {
    internal ChartAreaCollection() { }
    public System.Windows.Forms.DataVisualization.Charting.ChartArea Add(string name) { return default(System.Windows.Forms.DataVisualization.Charting.ChartArea); }
  }
  public enum ChartColorPalette {
    Berry = 8,
    Bright = 1,
    BrightPastel = 12,
    Chocolate = 9,
    EarthTones = 6,
    Excel = 3,
    Fire = 10,
    Grayscale = 2,
    Light = 4,
    None = 0,
    Pastel = 5,
    SeaGreen = 11,
    SemiTransparent = 7,
  }
  public enum ChartDashStyle {
    Dash = 1,
    DashDot = 2,
    DashDotDot = 3,
    Dot = 4,
    NotSet = 0,
    Solid = 5,
  }
  public abstract partial class ChartElement : System.IDisposable {
    protected ChartElement() { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public object Tag { get { return default(object); } set { } }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
  }
  public abstract partial class ChartElementCollection<T> : System.Collections.ObjectModel.Collection<T>, System.IDisposable where T : System.Windows.Forms.DataVisualization.Charting.ChartElement {
    internal ChartElementCollection() { }
    protected override void ClearItems() { }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    protected override void InsertItem(int index, T item) { }
    public virtual void Invalidate() { }
    protected override void RemoveItem(int index) { }
    public virtual void ResumeUpdates() { }
    protected override void SetItem(int index, T item) { }
    public virtual void SuspendUpdates() { }
  }
  public partial class ChartElementOutline : System.IDisposable {
    internal ChartElementOutline() { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Drawing.PointF> Markers { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Drawing.PointF>); } }
    public System.Drawing.Drawing2D.GraphicsPath OutlinePath { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Drawing.Drawing2D.GraphicsPath); } }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
  }
  public enum ChartElementType {
    Annotation = 22,
    Axis = 3,
    AxisLabelImage = 7,
    AxisLabels = 8,
    AxisTitle = 9,
    DataPoint = 16,
    DataPointLabel = 17,
    Gridlines = 5,
    LegendArea = 18,
    LegendHeader = 20,
    LegendItem = 21,
    LegendTitle = 19,
    Nothing = 0,
    PlottingArea = 2,
    ScrollBarLargeDecrement = 13,
    ScrollBarLargeIncrement = 14,
    ScrollBarSmallDecrement = 11,
    ScrollBarSmallIncrement = 12,
    ScrollBarThumbTracker = 10,
    ScrollBarZoomReset = 15,
    StripLines = 6,
    TickMarks = 4,
    Title = 1,
  }
  public partial class ChartGraphics : System.Windows.Forms.DataVisualization.Charting.ChartElement {
    internal ChartGraphics() { }
    public System.Drawing.Graphics Graphics { get { return default(System.Drawing.Graphics); } set { } }
    protected override void Dispose(bool disposing) { }
    public System.Drawing.PointF GetAbsolutePoint(System.Drawing.PointF point) { return default(System.Drawing.PointF); }
    public System.Drawing.RectangleF GetAbsoluteRectangle(System.Drawing.RectangleF rectangle) { return default(System.Drawing.RectangleF); }
    public System.Drawing.SizeF GetAbsoluteSize(System.Drawing.SizeF size) { return default(System.Drawing.SizeF); }
    public double GetPositionFromAxis(string chartAreaName, System.Windows.Forms.DataVisualization.Charting.AxisName axis, double axisValue) { return default(double); }
    public System.Drawing.PointF GetRelativePoint(System.Drawing.PointF point) { return default(System.Drawing.PointF); }
    public System.Drawing.RectangleF GetRelativeRectangle(System.Drawing.RectangleF rectangle) { return default(System.Drawing.RectangleF); }
    public System.Drawing.SizeF GetRelativeSize(System.Drawing.SizeF size) { return default(System.Drawing.SizeF); }
  }
  public enum ChartHatchStyle {
    BackwardDiagonal = 1,
    Cross = 2,
    DarkDownwardDiagonal = 3,
    DarkHorizontal = 4,
    DarkUpwardDiagonal = 5,
    DarkVertical = 6,
    DashedDownwardDiagonal = 7,
    DashedHorizontal = 8,
    DashedUpwardDiagonal = 9,
    DashedVertical = 10,
    DiagonalBrick = 11,
    DiagonalCross = 12,
    Divot = 13,
    DottedDiamond = 14,
    DottedGrid = 15,
    ForwardDiagonal = 16,
    Horizontal = 17,
    HorizontalBrick = 18,
    LargeCheckerBoard = 19,
    LargeConfetti = 20,
    LargeGrid = 21,
    LightDownwardDiagonal = 22,
    LightHorizontal = 23,
    LightUpwardDiagonal = 24,
    LightVertical = 25,
    NarrowHorizontal = 26,
    NarrowVertical = 27,
    None = 0,
    OutlinedDiamond = 28,
    Percent05 = 29,
    Percent10 = 30,
    Percent20 = 31,
    Percent25 = 32,
    Percent30 = 33,
    Percent40 = 34,
    Percent50 = 35,
    Percent60 = 36,
    Percent70 = 37,
    Percent75 = 38,
    Percent80 = 39,
    Percent90 = 40,
    Plaid = 41,
    Shingle = 42,
    SmallCheckerBoard = 43,
    SmallConfetti = 44,
    SmallGrid = 45,
    SolidDiamond = 46,
    Sphere = 47,
    Trellis = 48,
    Vertical = 49,
    Wave = 50,
    Weave = 51,
    WideDownwardDiagonal = 52,
    WideUpwardDiagonal = 53,
    ZigZag = 54,
  }
  public enum ChartImageAlignmentStyle {
    Bottom = 5,
    BottomLeft = 6,
    BottomRight = 4,
    Center = 8,
    Left = 7,
    Right = 3,
    Top = 1,
    TopLeft = 0,
    TopRight = 2,
  }
  public enum ChartImageFormat {
    Bmp = 2,
    Emf = 5,
    EmfDual = 6,
    EmfPlus = 7,
    Gif = 4,
    Jpeg = 0,
    Png = 1,
    Tiff = 3,
  }
  public enum ChartImageWrapMode {
    Scaled = 4,
    Tile = 0,
    TileFlipX = 1,
    TileFlipXY = 3,
    TileFlipY = 2,
    Unscaled = 100,
  }
  public abstract partial class ChartNamedElement : System.Windows.Forms.DataVisualization.Charting.ChartElement {
    protected ChartNamedElement() { }
    protected ChartNamedElement(string name) { }
    [System.ComponentModel.DefaultValueAttribute("")]
    public virtual string Name { get { return default(string); } set { } }
  }
  public abstract partial class ChartNamedElementCollection<T> : System.Windows.Forms.DataVisualization.Charting.ChartElementCollection<T> where T : System.Windows.Forms.DataVisualization.Charting.ChartNamedElement {
    internal ChartNamedElementCollection() { }
    public T this[string name] { get { return default(T); } set { } }
    protected virtual string NamePrefix { get { return default(string); } }
    public virtual T FindByName(string name) { return default(T); }
    public int IndexOf(string name) { return default(int); }
    protected override void InsertItem(int index, T item) { }
    public virtual bool IsUniqueName(string name) { return default(bool); }
    public virtual string NextUniqueName() { return default(string); }
    protected override void RemoveItem(int index) { }
    protected override void SetItem(int index, T item) { }
  }
  public partial class ChartPaintEventArgs : System.EventArgs {
    internal ChartPaintEventArgs() { }
    public System.Windows.Forms.DataVisualization.Charting.Chart Chart { get { return default(System.Windows.Forms.DataVisualization.Charting.Chart); } }
    public object ChartElement { get { return default(object); } }
    public System.Windows.Forms.DataVisualization.Charting.ChartGraphics ChartGraphics { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartGraphics); } }
    public System.Windows.Forms.DataVisualization.Charting.ElementPosition Position { get { return default(System.Windows.Forms.DataVisualization.Charting.ElementPosition); } }
  }
  [System.ComponentModel.DefaultPropertyAttribute("Format")]
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartSerializer_ChartSerializer")]
  public partial class ChartSerializer {
    internal ChartSerializer() { }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.SerializationContents), "Default")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartSerializer_Content")]
    public System.Windows.Forms.DataVisualization.Charting.SerializationContents Content { get { return default(System.Windows.Forms.DataVisualization.Charting.SerializationContents); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.SerializationFormat), "Xml")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartSerializer_Format")]
    public System.Windows.Forms.DataVisualization.Charting.SerializationFormat Format { get { return default(System.Windows.Forms.DataVisualization.Charting.SerializationFormat); } set { } }
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartSerializer_ResetWhenLoading")]
    public bool IsResetWhenLoading { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartSerializer_TemplateMode")]
    public bool IsTemplateMode { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartSerializer_IgnoreUnknownXmlAttributes")]
    public bool IsUnknownAttributeIgnored { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartSerializer_NonSerializableContent")]
    public string NonSerializableContent { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartSerializer_SerializableContent")]
    public string SerializableContent { get { return default(string); } set { } }
    protected string GetContentString(System.Windows.Forms.DataVisualization.Charting.SerializationContents content, bool serializable) { return default(string); }
    public void Load(System.IO.Stream stream) { }
    public void Load(System.IO.TextReader reader) { }
    public void Load(string fileName) { }
    public void Load(System.Xml.XmlReader reader) { }
    public void Reset() { }
    public void Save(System.IO.Stream stream) { }
    public void Save(System.IO.TextWriter writer) { }
    public void Save(string fileName) { }
    public void Save(System.Xml.XmlWriter writer) { }
  }
  public enum ChartValueType {
    Auto = 0,
    Date = 9,
    DateTime = 8,
    DateTimeOffset = 11,
    Double = 1,
    Int32 = 3,
    Int64 = 4,
    Single = 2,
    String = 7,
    Time = 10,
    UInt32 = 5,
    UInt64 = 6,
  }
  public enum CompareMethod {
    EqualTo = 2,
    LessThan = 1,
    LessThanOrEqualTo = 4,
    MoreThan = 0,
    MoreThanOrEqualTo = 3,
    NotEqualTo = 5,
  }
  [System.ComponentModel.DefaultPropertyAttribute("Enabled")]
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCursor_Cursor")]
  public partial class Cursor : System.IDisposable {
    public Cursor() { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeBehavior")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCursor_AutoScroll")]
    public bool AutoScroll { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.AxisType)(0))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeBehavior")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCursor_AxisType")]
    public System.Windows.Forms.DataVisualization.Charting.AxisType AxisType { get { return default(System.Windows.Forms.DataVisualization.Charting.AxisType); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(1)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeBehavior")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCursor_Interval")]
    public double Interval { get { return default(double); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeBehavior")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCursor_IntervalOffset")]
    public double IntervalOffset { get { return default(double); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType)(0))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeBehavior")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCursor_IntervalOffsetType")]
    public System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType IntervalOffsetType { get { return default(System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType)(0))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeBehavior")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCursor_IntervalType")]
    public System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType IntervalType { get { return default(System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeBehavior")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCursor_UserEnabled")]
    public bool IsUserEnabled { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeBehavior")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCursor_UserSelection")]
    public bool IsUserSelectionEnabled { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Red")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineColor")]
    public System.Drawing.Color LineColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ChartDashStyle)(5))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineDashStyle")]
    public System.Windows.Forms.DataVisualization.Charting.ChartDashStyle LineDashStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartDashStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(1)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineWidth")]
    public int LineWidth { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0.0 / 0.0)]
    [System.ComponentModel.ParenthesizePropertyNameAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.DoubleDateNanValueConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeBehavior")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCursor_Position")]
    public double Position { get { return default(double); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "LightGray")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCursor_SelectionColor")]
    public System.Drawing.Color SelectionColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0.0 / 0.0)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.DoubleDateNanValueConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeBehavior")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCursor_SelectionEnd")]
    public double SelectionEnd { get { return default(double); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0.0 / 0.0)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.DoubleDateNanValueConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeBehavior")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCursor_SelectionStart")]
    public double SelectionStart { get { return default(double); } set { } }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public void SetCursorPixelPosition(System.Drawing.PointF point, bool roundToBoundary) { }
    public void SetCursorPosition(double newPosition) { }
    public void SetSelectionPixelPosition(System.Drawing.PointF startPoint, System.Drawing.PointF endPoint, bool roundToBoundary) { }
    public void SetSelectionPosition(double newStart, double newEnd) { }
  }
  public partial class CursorEventArgs : System.EventArgs {
    public CursorEventArgs(System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea, System.Windows.Forms.DataVisualization.Charting.Axis axis, double newPosition) { }
    public CursorEventArgs(System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea, System.Windows.Forms.DataVisualization.Charting.Axis axis, double newSelectionStart, double newSelectionEnd) { }
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxis")]
    public System.Windows.Forms.DataVisualization.Charting.Axis Axis { get { return default(System.Windows.Forms.DataVisualization.Charting.Axis); } }
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartArea")]
    public System.Windows.Forms.DataVisualization.Charting.ChartArea ChartArea { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartArea); } }
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCursorEventArgs_NewPosition")]
    public double NewPosition { get { return default(double); } set { } }
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCursorEventArgs_NewSelectionEnd")]
    public double NewSelectionEnd { get { return default(double); } set { } }
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCursorEventArgs_NewSelectionStart")]
    public double NewSelectionStart { get { return default(double); } set { } }
  }
  public partial class CustomizeLegendEventArgs : System.EventArgs {
    public CustomizeLegendEventArgs(System.Windows.Forms.DataVisualization.Charting.LegendItemsCollection legendItems) { }
    public CustomizeLegendEventArgs(System.Windows.Forms.DataVisualization.Charting.LegendItemsCollection legendItems, string legendName) { }
    public System.Windows.Forms.DataVisualization.Charting.LegendItemsCollection LegendItems { get { return default(System.Windows.Forms.DataVisualization.Charting.LegendItemsCollection); } }
    public string LegendName { get { return default(string); } }
  }
  [System.ComponentModel.DefaultPropertyAttribute("Text")]
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCustomLabel_CustomLabel")]
  public partial class CustomLabel : System.Windows.Forms.DataVisualization.Charting.ChartNamedElement {
    public CustomLabel() { }
    public CustomLabel(double fromPosition, double toPosition, string text, int labelRow, System.Windows.Forms.DataVisualization.Charting.LabelMarkStyle markStyle) { }
    public CustomLabel(double fromPosition, double toPosition, string text, int labelRow, System.Windows.Forms.DataVisualization.Charting.LabelMarkStyle markStyle, System.Windows.Forms.DataVisualization.Charting.GridTickTypes gridTick) { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public System.Windows.Forms.DataVisualization.Charting.Axis Axis { get { return default(System.Windows.Forms.DataVisualization.Charting.Axis); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeForeColor")]
    public System.Drawing.Color ForeColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.AxisLabelDateValueConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCustomLabel_From")]
    public double FromPosition { get { return default(double); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.GridTickTypes)(0))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.FlagsEnumUITypeEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCustomLabel_GridTicks")]
    public System.Windows.Forms.DataVisualization.Charting.GridTickTypes GridTicks { get { return default(System.Windows.Forms.DataVisualization.Charting.GridTickTypes); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ImageValueEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCustomLabel_Image")]
    public string Image { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeImageTransparentColor")]
    public System.Drawing.Color ImageTransparentColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.LabelMarkStyle)(0))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCustomLabel_LabelMark")]
    public System.Windows.Forms.DataVisualization.Charting.LabelMarkStyle LabelMark { get { return default(System.Windows.Forms.DataVisualization.Charting.LabelMarkStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCustomLabel_MarkColor")]
    public System.Drawing.Color MarkColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.DefaultValueAttribute("Custom LabelStyle")]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.DesignOnlyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCustomLabel_Name")]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public override string Name { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCustomLabel_RowIndex")]
    public int RowIndex { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCustomLabel_Text")]
    public string Text { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMapArea")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeToolTip")]
    public string ToolTip { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.AxisLabelDateValueConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCustomLabel_To")]
    public double ToPosition { get { return default(double); } set { } }
    public System.Windows.Forms.DataVisualization.Charting.CustomLabel Clone() { return default(System.Windows.Forms.DataVisualization.Charting.CustomLabel); }
  }
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCustomLabelsCollection_CustomLabelsCollection")]
  public partial class CustomLabelsCollection : System.Windows.Forms.DataVisualization.Charting.ChartElementCollection<System.Windows.Forms.DataVisualization.Charting.CustomLabel> {
    internal CustomLabelsCollection() { }
    public System.Windows.Forms.DataVisualization.Charting.CustomLabel Add(double fromPosition, double toPosition, string text) { return default(System.Windows.Forms.DataVisualization.Charting.CustomLabel); }
    public System.Windows.Forms.DataVisualization.Charting.CustomLabel Add(double fromPosition, double toPosition, string text, int rowIndex, System.Windows.Forms.DataVisualization.Charting.LabelMarkStyle markStyle) { return default(System.Windows.Forms.DataVisualization.Charting.CustomLabel); }
    public System.Windows.Forms.DataVisualization.Charting.CustomLabel Add(double fromPosition, double toPosition, string text, int rowIndex, System.Windows.Forms.DataVisualization.Charting.LabelMarkStyle markStyle, System.Windows.Forms.DataVisualization.Charting.GridTickTypes gridTick) { return default(System.Windows.Forms.DataVisualization.Charting.CustomLabel); }
    public void Add(double labelsStep, System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType intervalType) { }
    public void Add(double labelsStep, System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType intervalType, double min, double max, string format, int rowIndex, System.Windows.Forms.DataVisualization.Charting.LabelMarkStyle markStyle) { }
    public void Add(double labelsStep, System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType intervalType, string format) { }
    public void Add(double labelsStep, System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType intervalType, string format, int rowIndex, System.Windows.Forms.DataVisualization.Charting.LabelMarkStyle markStyle) { }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.CustomPropertiesTypeConverter))]
  public partial class CustomProperties {
    internal CustomProperties() { }
  }
  public partial class DataFormula {
    public DataFormula() { }
    public bool IsEmptyPointIgnored { get { return default(bool); } set { } }
    public bool IsStartFromFirst { get { return default(bool); } set { } }
    public System.Windows.Forms.DataVisualization.Charting.StatisticFormula Statistics { get { return default(System.Windows.Forms.DataVisualization.Charting.StatisticFormula); } }
    public void CopySeriesValues(string inputSeries, string outputSeries) { }
    public void FinancialFormula(System.Windows.Forms.DataVisualization.Charting.FinancialFormula formulaName, string inputSeries) { }
    public void FinancialFormula(System.Windows.Forms.DataVisualization.Charting.FinancialFormula formulaName, string inputSeries, string outputSeries) { }
    public void FinancialFormula(System.Windows.Forms.DataVisualization.Charting.FinancialFormula formulaName, string parameters, string inputSeries, string outputSeries) { }
    public void FinancialFormula(System.Windows.Forms.DataVisualization.Charting.FinancialFormula formulaName, string parameters, System.Windows.Forms.DataVisualization.Charting.Series inputSeries, System.Windows.Forms.DataVisualization.Charting.Series outputSeries) { }
    public void FinancialFormula(System.Windows.Forms.DataVisualization.Charting.FinancialFormula formulaName, System.Windows.Forms.DataVisualization.Charting.Series inputSeries) { }
    public void FinancialFormula(System.Windows.Forms.DataVisualization.Charting.FinancialFormula formulaName, System.Windows.Forms.DataVisualization.Charting.Series inputSeries, System.Windows.Forms.DataVisualization.Charting.Series outputSeries) { }
  }
  public partial class DataManipulator : System.Windows.Forms.DataVisualization.Charting.DataFormula {
    public DataManipulator() { }
    public bool FilterMatchedPoints { get { return default(bool); } set { } }
    public bool FilterSetEmptyPoints { get { return default(bool); } set { } }
    public System.Data.DataSet ExportSeriesValues() { return default(System.Data.DataSet); }
    public System.Data.DataSet ExportSeriesValues(string seriesNames) { return default(System.Data.DataSet); }
    public System.Data.DataSet ExportSeriesValues(System.Windows.Forms.DataVisualization.Charting.Series series) { return default(System.Data.DataSet); }
    public void Filter(System.Windows.Forms.DataVisualization.Charting.CompareMethod compareMethod, double compareValue, string inputSeriesNames) { }
    public void Filter(System.Windows.Forms.DataVisualization.Charting.CompareMethod compareMethod, double compareValue, string inputSeriesNames, string outputSeriesNames) { }
    public void Filter(System.Windows.Forms.DataVisualization.Charting.CompareMethod compareMethod, double compareValue, string inputSeriesNames, string outputSeriesNames, string usingValue) { }
    public void Filter(System.Windows.Forms.DataVisualization.Charting.CompareMethod compareMethod, double compareValue, System.Windows.Forms.DataVisualization.Charting.Series inputSeries) { }
    public void Filter(System.Windows.Forms.DataVisualization.Charting.CompareMethod compareMethod, double compareValue, System.Windows.Forms.DataVisualization.Charting.Series inputSeries, System.Windows.Forms.DataVisualization.Charting.Series outputSeries) { }
    public void Filter(System.Windows.Forms.DataVisualization.Charting.CompareMethod compareMethod, double compareValue, System.Windows.Forms.DataVisualization.Charting.Series inputSeries, System.Windows.Forms.DataVisualization.Charting.Series outputSeries, string usingValue) { }
    public void Filter(System.Windows.Forms.DataVisualization.Charting.DateRangeType dateRange, string rangeElements, string inputSeriesNames) { }
    public void Filter(System.Windows.Forms.DataVisualization.Charting.DateRangeType dateRange, string rangeElements, string inputSeriesNames, string outputSeriesNames) { }
    public void Filter(System.Windows.Forms.DataVisualization.Charting.DateRangeType dateRange, string rangeElements, System.Windows.Forms.DataVisualization.Charting.Series inputSeries) { }
    public void Filter(System.Windows.Forms.DataVisualization.Charting.DateRangeType dateRange, string rangeElements, System.Windows.Forms.DataVisualization.Charting.Series inputSeries, System.Windows.Forms.DataVisualization.Charting.Series outputSeries) { }
    public void Filter(System.Windows.Forms.DataVisualization.Charting.IDataPointFilter filterInterface, string inputSeriesNames) { }
    public void Filter(System.Windows.Forms.DataVisualization.Charting.IDataPointFilter filterInterface, string inputSeriesNames, string outputSeriesNames) { }
    public void Filter(System.Windows.Forms.DataVisualization.Charting.IDataPointFilter filterInterface, System.Windows.Forms.DataVisualization.Charting.Series inputSeries) { }
    public void Filter(System.Windows.Forms.DataVisualization.Charting.IDataPointFilter filterInterface, System.Windows.Forms.DataVisualization.Charting.Series inputSeries, System.Windows.Forms.DataVisualization.Charting.Series outputSeries) { }
    public void FilterTopN(int pointCount, string inputSeriesNames) { }
    public void FilterTopN(int pointCount, string inputSeriesNames, string outputSeriesNames) { }
    public void FilterTopN(int pointCount, string inputSeriesNames, string outputSeriesNames, string usingValue) { }
    public void FilterTopN(int pointCount, string inputSeriesNames, string outputSeriesNames, string usingValue, bool getTopValues) { }
    public void FilterTopN(int pointCount, System.Windows.Forms.DataVisualization.Charting.Series inputSeries) { }
    public void FilterTopN(int pointCount, System.Windows.Forms.DataVisualization.Charting.Series inputSeries, System.Windows.Forms.DataVisualization.Charting.Series outputSeries) { }
    public void FilterTopN(int pointCount, System.Windows.Forms.DataVisualization.Charting.Series inputSeries, System.Windows.Forms.DataVisualization.Charting.Series outputSeries, string usingValue) { }
    public void FilterTopN(int pointCount, System.Windows.Forms.DataVisualization.Charting.Series inputSeries, System.Windows.Forms.DataVisualization.Charting.Series outputSeries, string usingValue, bool getTopValues) { }
    public void Group(string formula, double interval, System.Windows.Forms.DataVisualization.Charting.IntervalType intervalType, double intervalOffset, System.Windows.Forms.DataVisualization.Charting.IntervalType intervalOffsetType, string inputSeriesName) { }
    public void Group(string formula, double interval, System.Windows.Forms.DataVisualization.Charting.IntervalType intervalType, double intervalOffset, System.Windows.Forms.DataVisualization.Charting.IntervalType intervalOffsetType, string inputSeriesName, string outputSeriesName) { }
    public void Group(string formula, double interval, System.Windows.Forms.DataVisualization.Charting.IntervalType intervalType, double intervalOffset, System.Windows.Forms.DataVisualization.Charting.IntervalType intervalOffsetType, System.Windows.Forms.DataVisualization.Charting.Series inputSeries) { }
    public void Group(string formula, double interval, System.Windows.Forms.DataVisualization.Charting.IntervalType intervalType, double intervalOffset, System.Windows.Forms.DataVisualization.Charting.IntervalType intervalOffsetType, System.Windows.Forms.DataVisualization.Charting.Series inputSeries, System.Windows.Forms.DataVisualization.Charting.Series outputSeries) { }
    public void Group(string formula, double interval, System.Windows.Forms.DataVisualization.Charting.IntervalType intervalType, string inputSeriesName) { }
    public void Group(string formula, double interval, System.Windows.Forms.DataVisualization.Charting.IntervalType intervalType, string inputSeriesName, string outputSeriesName) { }
    public void Group(string formula, double interval, System.Windows.Forms.DataVisualization.Charting.IntervalType intervalType, System.Windows.Forms.DataVisualization.Charting.Series inputSeries) { }
    public void Group(string formula, double interval, System.Windows.Forms.DataVisualization.Charting.IntervalType intervalType, System.Windows.Forms.DataVisualization.Charting.Series inputSeries, System.Windows.Forms.DataVisualization.Charting.Series outputSeries) { }
    public void GroupByAxisLabel(string formula, string inputSeriesName) { }
    public void GroupByAxisLabel(string formula, string inputSeriesName, string outputSeriesName) { }
    public void GroupByAxisLabel(string formula, System.Windows.Forms.DataVisualization.Charting.Series inputSeries) { }
    public void GroupByAxisLabel(string formula, System.Windows.Forms.DataVisualization.Charting.Series inputSeries, System.Windows.Forms.DataVisualization.Charting.Series outputSeries) { }
    public void InsertEmptyPoints(double interval, System.Windows.Forms.DataVisualization.Charting.IntervalType intervalType, double intervalOffset, System.Windows.Forms.DataVisualization.Charting.IntervalType intervalOffsetType, double fromXValue, double toXValue, string seriesName) { }
    public void InsertEmptyPoints(double interval, System.Windows.Forms.DataVisualization.Charting.IntervalType intervalType, double intervalOffset, System.Windows.Forms.DataVisualization.Charting.IntervalType intervalOffsetType, double fromXValue, double toXValue, System.Windows.Forms.DataVisualization.Charting.Series series) { }
    public void InsertEmptyPoints(double interval, System.Windows.Forms.DataVisualization.Charting.IntervalType intervalType, double intervalOffset, System.Windows.Forms.DataVisualization.Charting.IntervalType intervalOffsetType, string seriesName) { }
    public void InsertEmptyPoints(double interval, System.Windows.Forms.DataVisualization.Charting.IntervalType intervalType, double intervalOffset, System.Windows.Forms.DataVisualization.Charting.IntervalType intervalOffsetType, System.Windows.Forms.DataVisualization.Charting.Series series) { }
    public void InsertEmptyPoints(double interval, System.Windows.Forms.DataVisualization.Charting.IntervalType intervalType, string seriesName) { }
    public void InsertEmptyPoints(double interval, System.Windows.Forms.DataVisualization.Charting.IntervalType intervalType, System.Windows.Forms.DataVisualization.Charting.Series series) { }
    public void Sort(System.Collections.Generic.IComparer<System.Windows.Forms.DataVisualization.Charting.DataPoint> comparer, string seriesName) { }
    public void Sort(System.Collections.Generic.IComparer<System.Windows.Forms.DataVisualization.Charting.DataPoint> comparer, System.Windows.Forms.DataVisualization.Charting.Series series) { }
    public void Sort(System.Windows.Forms.DataVisualization.Charting.PointSortOrder pointSortOrder, string seriesName) { }
    public void Sort(System.Windows.Forms.DataVisualization.Charting.PointSortOrder pointSortOrder, string sortBy, string seriesName) { }
    public void Sort(System.Windows.Forms.DataVisualization.Charting.PointSortOrder pointSortOrder, string sortBy, System.Windows.Forms.DataVisualization.Charting.Series series) { }
    public void Sort(System.Windows.Forms.DataVisualization.Charting.PointSortOrder pointSortOrder, System.Windows.Forms.DataVisualization.Charting.Series series) { }
  }
  [System.ComponentModel.DefaultPropertyAttribute("YValues")]
  [System.ComponentModel.TypeConverterAttribute("System.Windows.Forms.Design.DataVisualization.Charting.DataPointConverter, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeDataPoint_DataPoint")]
  public partial class DataPoint : System.Windows.Forms.DataVisualization.Charting.DataPointCustomProperties {
    public DataPoint() { }
    public DataPoint(double xValue, double yValue) { }
    public DataPoint(double xValue, System.Double[] yValues) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public DataPoint(double xValue, string yValues) { }
    public DataPoint(System.Windows.Forms.DataVisualization.Charting.Series series) { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeData")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeDataPoint_Empty")]
    public bool IsEmpty { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeData")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeDataPoint_Name")]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public override string Name { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(double), "0.0")]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.DataPointValueConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeData")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeDataPoint_XValue")]
    public double XValue { get { return default(double); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorAttribute(typeof(System.Drawing.Design.UITypeEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.DoubleArrayConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeData")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeDataPoint_YValues")]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(1))]
    public System.Double[] YValues { get { return default(System.Double[]); } set { } }
    public System.Windows.Forms.DataVisualization.Charting.DataPoint Clone() { return default(System.Windows.Forms.DataVisualization.Charting.DataPoint); }
    public double GetValueByName(string valueName) { return default(double); }
    public void SetValueXY(object xValue, params System.Object[] yValue) { }
    public void SetValueY(params System.Object[] yValue) { }
  }
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeDataPointCollection_DataPointCollection")]
  public partial class DataPointCollection : System.Windows.Forms.DataVisualization.Charting.ChartElementCollection<System.Windows.Forms.DataVisualization.Charting.DataPoint> {
    internal DataPointCollection() { }
    public System.Windows.Forms.DataVisualization.Charting.DataPoint Add(params System.Double[] y) { return default(System.Windows.Forms.DataVisualization.Charting.DataPoint); }
    public int AddXY(double xValue, double yValue) { return default(int); }
    public int AddXY(object xValue, params System.Object[] yValue) { return default(int); }
    public int AddY(double yValue) { return default(int); }
    public int AddY(params System.Object[] yValue) { return default(int); }
    protected override void ClearItems() { }
    public void DataBind(System.Collections.IEnumerable dataSource, string xField, string yFields, string otherFields) { }
    public void DataBindXY(System.Collections.IEnumerable xValue, params System.Collections.IEnumerable[] yValues) { }
    public void DataBindXY(System.Collections.IEnumerable xValue, string xField, System.Collections.IEnumerable yValue, string yFields) { }
    public void DataBindY(System.Collections.IEnumerable yValue, string yFields) { }
    public void DataBindY(params System.Collections.IEnumerable[] yValue) { }
    public System.Collections.Generic.IEnumerable<System.Windows.Forms.DataVisualization.Charting.DataPoint> FindAllByValue(double valueToFind) { return default(System.Collections.Generic.IEnumerable<System.Windows.Forms.DataVisualization.Charting.DataPoint>); }
    [System.Runtime.CompilerServices.IteratorStateMachineAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.DataPointCollection.<FindAllByValue>d__23))]
    public System.Collections.Generic.IEnumerable<System.Windows.Forms.DataVisualization.Charting.DataPoint> FindAllByValue(double valueToFind, string useValue) { return default(System.Collections.Generic.IEnumerable<System.Windows.Forms.DataVisualization.Charting.DataPoint>); }
    [System.Runtime.CompilerServices.IteratorStateMachineAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.DataPointCollection.<FindAllByValue>d__22))]
    public System.Collections.Generic.IEnumerable<System.Windows.Forms.DataVisualization.Charting.DataPoint> FindAllByValue(double valueToFind, string useValue, int startIndex) { return default(System.Collections.Generic.IEnumerable<System.Windows.Forms.DataVisualization.Charting.DataPoint>); }
    public System.Windows.Forms.DataVisualization.Charting.DataPoint FindByValue(double valueToFind) { return default(System.Windows.Forms.DataVisualization.Charting.DataPoint); }
    public System.Windows.Forms.DataVisualization.Charting.DataPoint FindByValue(double valueToFind, string useValue) { return default(System.Windows.Forms.DataVisualization.Charting.DataPoint); }
    public System.Windows.Forms.DataVisualization.Charting.DataPoint FindByValue(double valueToFind, string useValue, int startIndex) { return default(System.Windows.Forms.DataVisualization.Charting.DataPoint); }
    public System.Windows.Forms.DataVisualization.Charting.DataPoint FindMaxByValue() { return default(System.Windows.Forms.DataVisualization.Charting.DataPoint); }
    public System.Windows.Forms.DataVisualization.Charting.DataPoint FindMaxByValue(string useValue) { return default(System.Windows.Forms.DataVisualization.Charting.DataPoint); }
    public System.Windows.Forms.DataVisualization.Charting.DataPoint FindMaxByValue(string useValue, int startIndex) { return default(System.Windows.Forms.DataVisualization.Charting.DataPoint); }
    public System.Windows.Forms.DataVisualization.Charting.DataPoint FindMinByValue() { return default(System.Windows.Forms.DataVisualization.Charting.DataPoint); }
    public System.Windows.Forms.DataVisualization.Charting.DataPoint FindMinByValue(string useValue) { return default(System.Windows.Forms.DataVisualization.Charting.DataPoint); }
    public System.Windows.Forms.DataVisualization.Charting.DataPoint FindMinByValue(string useValue, int startIndex) { return default(System.Windows.Forms.DataVisualization.Charting.DataPoint); }
    public void InsertXY(int index, object xValue, params System.Object[] yValue) { }
    public void InsertY(int index, params System.Object[] yValue) { }
  }
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeDataPointComparer_DataPointComparer")]
  public partial class DataPointComparer : System.Collections.Generic.IComparer<System.Windows.Forms.DataVisualization.Charting.DataPoint> {
    public DataPointComparer(System.Windows.Forms.DataVisualization.Charting.Series series, System.Windows.Forms.DataVisualization.Charting.PointSortOrder sortOrder, string sortBy) { }
    public int Compare(System.Windows.Forms.DataVisualization.Charting.DataPoint x, System.Windows.Forms.DataVisualization.Charting.DataPoint y) { return default(int); }
  }
  [System.ComponentModel.DefaultPropertyAttribute("LabelStyle")]
  [System.ComponentModel.TypeConverterAttribute("System.Windows.Forms.Design.DataVisualization.Charting.DataPointCustomPropertiesConverter, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeDataPointCustomProperties_DataPointCustomProperties")]
  public partial class DataPointCustomProperties : System.Windows.Forms.DataVisualization.Charting.ChartNamedElement {
    public DataPointCustomProperties() { }
    public DataPointCustomProperties(System.Windows.Forms.DataVisualization.Charting.Series series, bool pointProperties) { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.KeywordsStringEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxisLabel")]
    public virtual string AxisLabel { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.GradientEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackGradientStyle")]
    public System.Windows.Forms.DataVisualization.Charting.GradientStyle BackGradientStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.GradientStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.HatchStyleEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackHatchStyle")]
    public System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ImageValueEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackImage")]
    public string BackImage { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackImageAlign")]
    public System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle BackImageAlignment { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeImageTransparentColor")]
    public System.Drawing.Color BackImageTransparentColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeImageWrapMode")]
    public System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode BackImageWrapMode { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackSecondaryColor")]
    public System.Drawing.Color BackSecondaryColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderColor")]
    public System.Drawing.Color BorderColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderDashStyle")]
    public System.Windows.Forms.DataVisualization.Charting.ChartDashStyle BorderDashStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartDashStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderWidth")]
    public int BorderWidth { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeColor4")]
    public System.Drawing.Color Color { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCustomAttributesExtended")]
    public string CustomProperties { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.DesignOnlyAttribute(true)]
    [System.ComponentModel.DisplayNameAttribute("CustomProperties")]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCustomAttributesExtended")]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public System.Windows.Forms.DataVisualization.Charting.CustomProperties CustomPropertiesExtended { get { return default(System.Windows.Forms.DataVisualization.Charting.CustomProperties); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLabelAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeFont")]
    public System.Drawing.Font Font { get { return default(System.Drawing.Font); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLabel")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeShowLabelAsValue")]
    public bool IsValueShownAsLabel { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLegend")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeShowInLegend")]
    public bool IsVisibleInLegend { get { return default(bool); } set { } }
    public string this[int index] { get { return default(string); } }
    public string this[string name] { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.KeywordsStringEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLabel")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLabel")]
    public virtual string Label { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLabelAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLabel_FontAngle")]
    public int LabelAngle { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLabelAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLabelBackColor")]
    public System.Drawing.Color LabelBackColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLabelAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderColor")]
    public System.Drawing.Color LabelBorderColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLabelAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLabelBorderDashStyle")]
    public System.Windows.Forms.DataVisualization.Charting.ChartDashStyle LabelBorderDashStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartDashStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLabelAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderWidth")]
    public int LabelBorderWidth { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLabelAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeFontColor")]
    public System.Drawing.Color LabelForeColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLabel")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLabelFormat")]
    public string LabelFormat { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.KeywordsStringEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLabel")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLabelToolTip")]
    public string LabelToolTip { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.KeywordsStringEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLegend")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendText")]
    public string LegendText { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.KeywordsStringEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLegend")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendToolTip")]
    public string LegendToolTip { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMarker")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMarkerBorderColor")]
    public System.Drawing.Color MarkerBorderColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMarker")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMarkerBorderWidth")]
    public int MarkerBorderWidth { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMarker")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMarkerColor3")]
    public System.Drawing.Color MarkerColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ImageValueEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMarker")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMarkerImage")]
    public string MarkerImage { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMarker")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeImageTransparentColor")]
    public System.Drawing.Color MarkerImageTransparentColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMarker")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMarkerSize")]
    public int MarkerSize { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.MarkerStyleEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMarker")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMarkerStyle4")]
    public System.Windows.Forms.DataVisualization.Charting.MarkerStyle MarkerStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.MarkerStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.KeywordsStringEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMapArea")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeToolTip")]
    public string ToolTip { get { return default(string); } set { } }
    public virtual void DeleteCustomProperty(string name) { }
    public virtual string GetCustomProperty(string name) { return default(string); }
    public virtual bool IsCustomPropertySet(string name) { return default(bool); }
    public void ResetIsValueShownAsLabel() { }
    public void ResetIsVisibleInLegend() { }
    public virtual void SetCustomProperty(string name, string propertyValue) { }
    public virtual void SetDefault(bool clearAll) { }
  }
  public enum DateRangeType {
    DayOfMonth = 3,
    DayOfWeek = 2,
    Hour = 4,
    Minute = 5,
    Month = 1,
    Year = 0,
  }
  public enum DateTimeIntervalType {
    Auto = 0,
    Days = 5,
    Hours = 6,
    Milliseconds = 9,
    Minutes = 7,
    Months = 3,
    NotSet = 10,
    Number = 1,
    Seconds = 8,
    Weeks = 4,
    Years = 2,
  }
  public enum Docking {
    Bottom = 2,
    Left = 3,
    Right = 1,
    Top = 0,
  }
  [System.ComponentModel.DefaultPropertyAttribute("Data")]
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeElementPosition_ElementPosition")]
  public partial class ElementPosition : System.Windows.Forms.DataVisualization.Charting.ChartElement {
    public ElementPosition() { }
    public ElementPosition(float x, float y, float width, float height) { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeElementPosition_Auto")]
    public bool Auto { get { return default(bool); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public float Bottom { get { return default(float); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0f)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeElementPosition_Height")]
    public float Height { get { return default(float); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public float Right { get { return default(float); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public System.Drawing.SizeF Size { get { return default(System.Drawing.SizeF); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0f)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeElementPosition_Width")]
    public float Width { get { return default(float); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0f)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeElementPosition_X")]
    public float X { get { return default(float); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0f)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeElementPosition_Y")]
    public float Y { get { return default(float); } set { } }
    public void FromRectangleF(System.Drawing.RectangleF rect) { }
    public System.Drawing.RectangleF ToRectangleF() { return default(System.Drawing.RectangleF); }
  }
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeEllipseAnnotation_EllipseAnnotation")]
  public partial class EllipseAnnotation : System.Windows.Forms.DataVisualization.Charting.RectangleAnnotation {
    public EllipseAnnotation() { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationType")]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public override string AnnotationType { get { return default(string); } }
  }
  public enum FinancialFormula {
    AccumulationDistribution = 0,
    AverageTrueRange = 1,
    BollingerBands = 2,
    ChaikinOscillator = 3,
    CommodityChannelIndex = 4,
    DetrendedPriceOscillator = 5,
    EaseOfMovement = 6,
    Envelopes = 7,
    ExponentialMovingAverage = 8,
    Forecasting = 9,
    MassIndex = 11,
    MedianPrice = 12,
    MoneyFlow = 13,
    MovingAverage = 21,
    MovingAverageConvergenceDivergence = 10,
    NegativeVolumeIndex = 14,
    OnBalanceVolume = 15,
    Performance = 16,
    PositiveVolumeIndex = 17,
    PriceVolumeTrend = 18,
    RateOfChange = 19,
    RelativeStrengthIndex = 20,
    StandardDeviation = 22,
    StochasticIndicator = 23,
    TriangularMovingAverage = 24,
    TripleExponentialMovingAverage = 25,
    TypicalPrice = 26,
    VolatilityChaikins = 27,
    VolumeOscillator = 28,
    WeightedClose = 29,
    WeightedMovingAverage = 30,
    WilliamsR = 31,
  }
  public partial class FormatNumberEventArgs : System.EventArgs {
    internal FormatNumberEventArgs() { }
    public System.Windows.Forms.DataVisualization.Charting.ChartElementType ElementType { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartElementType); } }
    public string Format { get { return default(string); } }
    public string LocalizedValue { get { return default(string); } set { } }
    public object SenderTag { get { return default(object); } }
    public double Value { get { return default(double); } }
    public System.Windows.Forms.DataVisualization.Charting.ChartValueType ValueType { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartValueType); } }
  }
  public partial class FTestResult {
    public FTestResult() { }
    public double FCriticalValueOneTail { get { return default(double); } }
    public double FirstSeriesMean { get { return default(double); } }
    public double FirstSeriesVariance { get { return default(double); } }
    public double FValue { get { return default(double); } }
    public double ProbabilityFOneTail { get { return default(double); } }
    public double SecondSeriesMean { get { return default(double); } }
    public double SecondSeriesVariance { get { return default(double); } }
  }
  public enum GradientStyle {
    Center = 3,
    DiagonalLeft = 4,
    DiagonalRight = 5,
    HorizontalCenter = 6,
    LeftRight = 1,
    None = 0,
    TopBottom = 2,
    VerticalCenter = 7,
  }
  [System.ComponentModel.DefaultPropertyAttribute("Enabled")]
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeGrid_Grid")]
  public partial class Grid {
    public Grid() { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeEnabled5")]
    public bool Enabled { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.AxisElementIntervalValueConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeData")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeInterval6")]
    public double Interval { get { return default(double); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.AxisElementIntervalValueConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeData")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeIntervalOffset3")]
    public double IntervalOffset { get { return default(double); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeData")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeIntervalOffsetType6")]
    public System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType IntervalOffsetType { get { return default(System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeData")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeIntervalType3")]
    public System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType IntervalType { get { return default(System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineColor")]
    public System.Drawing.Color LineColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ChartDashStyle)(5))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineDashStyle")]
    public System.Windows.Forms.DataVisualization.Charting.ChartDashStyle LineDashStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartDashStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(1)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineWidth")]
    public int LineWidth { get { return default(int); } set { } }
  }
  [System.FlagsAttribute]
  public enum GridTickTypes {
    All = 3,
    Gridline = 2,
    None = 0,
    TickMark = 1,
  }
  public partial class HitTestResult {
    public HitTestResult() { }
    public System.Windows.Forms.DataVisualization.Charting.Axis Axis { get { return default(System.Windows.Forms.DataVisualization.Charting.Axis); } set { } }
    public System.Windows.Forms.DataVisualization.Charting.ChartArea ChartArea { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartArea); } set { } }
    public System.Windows.Forms.DataVisualization.Charting.ChartElementType ChartElementType { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartElementType); } set { } }
    public object Object { get { return default(object); } set { } }
    public int PointIndex { get { return default(int); } set { } }
    public System.Windows.Forms.DataVisualization.Charting.Series Series { get { return default(System.Windows.Forms.DataVisualization.Charting.Series); } set { } }
    public object SubObject { get { return default(object); } set { } }
  }
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeHorizontalLineAnnotation_HorizontalLineAnnotation")]
  public partial class HorizontalLineAnnotation : System.Windows.Forms.DataVisualization.Charting.LineAnnotation {
    public HorizontalLineAnnotation() { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationType")]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public override string AnnotationType { get { return default(string); } }
  }
  public partial interface IDataPointFilter {
    bool FilterDataPoint(System.Windows.Forms.DataVisualization.Charting.DataPoint point, System.Windows.Forms.DataVisualization.Charting.Series series, int pointIndex);
  }
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeImageAnnotation_ImageAnnotation")]
  public partial class ImageAnnotation : System.Windows.Forms.DataVisualization.Charting.Annotation {
    public ImageAnnotation() { }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.ContentAlignment), "MiddleCenter")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeImage")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeImageAnnotation_Alignment")]
    public override System.Drawing.ContentAlignment Alignment { get { return default(System.Drawing.ContentAlignment); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationType")]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public override string AnnotationType { get { return default(string); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    public override System.Drawing.Color BackColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.GradientStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.GradientEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    public override System.Windows.Forms.DataVisualization.Charting.GradientStyle BackGradientStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.GradientStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.HatchStyleEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    public override System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    public override System.Drawing.Color BackSecondaryColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Font), "Microsoft Sans Serif, 8pt")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    public override System.Drawing.Font Font { get { return default(System.Drawing.Font); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    public override System.Drawing.Color ForeColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ImageValueEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeImage")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeImageAnnotation_Image")]
    public virtual string Image { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeImage")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeImageTransparentColor")]
    public System.Drawing.Color ImageTransparentColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode)(4))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeImage")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeImageWrapMode")]
    public System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode ImageWrapMode { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    public override System.Drawing.Color LineColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ChartDashStyle)(5))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineDashStyle")]
    public override System.Windows.Forms.DataVisualization.Charting.ChartDashStyle LineDashStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartDashStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(1)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineWidth")]
    public override int LineWidth { get { return default(int); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override System.Windows.Forms.DataVisualization.Charting.TextStyle TextStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.TextStyle); } set { } }
  }
  public enum IntervalAutoMode {
    FixedCount = 0,
    VariableCount = 1,
  }
  public enum IntervalType {
    Days = 4,
    Hours = 5,
    Milliseconds = 8,
    Minutes = 6,
    Months = 2,
    Number = 0,
    Seconds = 7,
    Weeks = 3,
    Years = 1,
  }
  [System.FlagsAttribute]
  public enum LabelAlignmentStyles {
    Bottom = 2,
    BottomLeft = 64,
    BottomRight = 128,
    Center = 256,
    Left = 8,
    Right = 4,
    Top = 1,
    TopLeft = 16,
    TopRight = 32,
  }
  [System.FlagsAttribute]
  public enum LabelAutoFitStyles {
    DecreaseFont = 2,
    IncreaseFont = 1,
    LabelsAngleStep30 = 8,
    LabelsAngleStep45 = 16,
    LabelsAngleStep90 = 32,
    None = 0,
    StaggeredLabels = 4,
    WordWrap = 64,
  }
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLabelCalloutStyle_LabelCalloutStyle")]
  public enum LabelCalloutStyle {
    Box = 2,
    None = 0,
    Underlined = 1,
  }
  public enum LabelMarkStyle {
    Box = 3,
    LineSideMark = 2,
    None = 0,
    SideMark = 1,
  }
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLabelOutsidePlotAreaStyle_LabelOutsidePlotAreaStyle")]
  public enum LabelOutsidePlotAreaStyle {
    No = 1,
    Partial = 2,
    Yes = 0,
  }
  [System.ComponentModel.DefaultPropertyAttribute("Enabled")]
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLabel_Label")]
  public partial class LabelStyle : System.Windows.Forms.DataVisualization.Charting.ChartElement {
    public LabelStyle() { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLabel_FontAngle")]
    public int Angle { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLabel_Enabled")]
    public bool Enabled { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Font), "Microsoft Sans Serif, 8pt")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLabel_Font")]
    public System.Drawing.Font Font { get { return default(System.Drawing.Font); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeFontColor")]
    public System.Drawing.Color ForeColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLabel_Format")]
    public string Format { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0.0 / 0.0)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.AxisElementIntervalValueConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeData")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLabel_Interval")]
    public double Interval { get { return default(double); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0.0 / 0.0)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.AxisElementIntervalValueConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeData")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLabel_IntervalOffset")]
    public double IntervalOffset { get { return default(double); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType)(10))]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeData")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLabel_IntervalOffsetType")]
    public System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType IntervalOffsetType { get { return default(System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType)(10))]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeData")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLabel_IntervalType")]
    public System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType IntervalType { get { return default(System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLabel_ShowEndLabels")]
    public bool IsEndLabelVisible { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLabel_OffsetLabels")]
    public bool IsStaggered { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLabel_TruncatedLabels")]
    public bool TruncatedLabels { get { return default(bool); } set { } }
    protected override void Dispose(bool disposing) { }
  }
  [System.ComponentModel.DefaultPropertyAttribute("Enabled")]
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_Legend")]
  public partial class Legend : System.Windows.Forms.DataVisualization.Charting.ChartNamedElement {
    public Legend() { }
    public Legend(string name) { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Drawing.StringAlignment)(0))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeDocking")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_Alignment")]
    public System.Drawing.StringAlignment Alignment { get { return default(System.Drawing.StringAlignment); } set { } }
    [System.ComponentModel.DefaultValueAttribute(7)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_AutoFitMinFontSize")]
    public int AutoFitMinFontSize { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackColor")]
    public System.Drawing.Color BackColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.GradientStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.GradientEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackGradientStyle")]
    public System.Windows.Forms.DataVisualization.Charting.GradientStyle BackGradientStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.GradientStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.HatchStyleEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackHatchStyle")]
    public System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ImageValueEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackImage")]
    public string BackImage { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle)(0))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackImageAlign")]
    public System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle BackImageAlignment { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeImageTransparentColor")]
    public System.Drawing.Color BackImageTransparentColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode)(0))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeImageWrapMode")]
    public System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode BackImageWrapMode { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackSecondaryColor")]
    public System.Drawing.Color BackSecondaryColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderColor")]
    public System.Drawing.Color BorderColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ChartDashStyle)(5))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderDashStyle")]
    public System.Windows.Forms.DataVisualization.Charting.ChartDashStyle BorderDashStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartDashStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(1)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderWidth")]
    public int BorderWidth { get { return default(int); } set { } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.LegendCellColumnCollectionEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeCellColumns")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_CellColumns")]
    public System.Windows.Forms.DataVisualization.Charting.LegendCellColumnCollection CellColumns { get { return default(System.Windows.Forms.DataVisualization.Charting.LegendCellColumnCollection); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.LegendItemCollectionEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_CustomItems")]
    public System.Windows.Forms.DataVisualization.Charting.LegendItemsCollection CustomItems { get { return default(System.Windows.Forms.DataVisualization.Charting.LegendItemsCollection); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("NotSet")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.LegendAreaNameConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeDocking")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_DockToChartArea")]
    public string DockedToChartArea { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.Docking)(1))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeDocking")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_Docking")]
    public System.Windows.Forms.DataVisualization.Charting.Docking Docking { get { return default(System.Windows.Forms.DataVisualization.Charting.Docking); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.ParenthesizePropertyNameAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_Enabled")]
    public bool Enabled { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Font), "Microsoft Sans Serif, 8pt")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_Font")]
    public System.Drawing.Font Font { get { return default(System.Drawing.Font); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendFontColor")]
    public System.Drawing.Color ForeColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle), "None")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeCellColumns")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_HeaderSeparator")]
    public System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle HeaderSeparator { get { return default(System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeCellColumns")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_HeaderSeparatorColor")]
    public System.Drawing.Color HeaderSeparatorColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute("NotSet")]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.LegendAreaNameConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_InsideChartArea")]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public string InsideChartArea { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_InterlacedRows")]
    public bool InterlacedRows { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_InterlacedRowsColor")]
    public System.Drawing.Color InterlacedRowsColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeDocking")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_DockInsideChartArea")]
    public bool IsDockedInsideChartArea { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_EquallySpacedItems")]
    public bool IsEquallySpacedItems { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_AutoFitText")]
    public bool IsTextAutoFit { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle), "None")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeCellColumns")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_ItemColumnSeparator")]
    public System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle ItemColumnSeparator { get { return default(System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeCellColumns")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_ItemColumnSeparatorColor")]
    public System.Drawing.Color ItemColumnSeparatorColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.DefaultValueAttribute(50)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeCellColumns")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_ItemColumnSpacing")]
    public int ItemColumnSpacing { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.LegendItemOrder)(0))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_Reversed")]
    public System.Windows.Forms.DataVisualization.Charting.LegendItemOrder LegendItemOrder { get { return default(System.Windows.Forms.DataVisualization.Charting.LegendItemOrder); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.LegendStyle)(2))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.ParenthesizePropertyNameAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_LegendStyle")]
    public System.Windows.Forms.DataVisualization.Charting.LegendStyle LegendStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.LegendStyle); } set { } }
    [System.ComponentModel.DefaultValueAttribute(50f)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeDocking")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_MaxAutoSize")]
    public float MaximumAutoSize { get { return default(float); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_Name")]
    public override string Name { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.ElementPositionConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_Position")]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(2))]
    public System.Windows.Forms.DataVisualization.Charting.ElementPosition Position { get { return default(System.Windows.Forms.DataVisualization.Charting.ElementPosition); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "128, 0, 0, 0")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeShadowColor")]
    public System.Drawing.Color ShadowColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeShadowOffset")]
    public int ShadowOffset { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.LegendTableStyle)(0))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.ParenthesizePropertyNameAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_TableStyle")]
    public System.Windows.Forms.DataVisualization.Charting.LegendTableStyle TableStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.LegendTableStyle); } set { } }
    [System.ComponentModel.DefaultValueAttribute(25)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_TextWrapThreshold")]
    public int TextWrapThreshold { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeTitle")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_Title")]
    public string Title { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.StringAlignment), "Center")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeTitle")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_TitleAlignment")]
    public System.Drawing.StringAlignment TitleAlignment { get { return default(System.Drawing.StringAlignment); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeTitle")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTitleBackColor")]
    public System.Drawing.Color TitleBackColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Font), "Microsoft Sans Serif, 8pt, style=Bold")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeTitle")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTitleFont")]
    public System.Drawing.Font TitleFont { get { return default(System.Drawing.Font); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeTitle")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_TitleColor")]
    public System.Drawing.Color TitleForeColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle), "None")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeTitle")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_TitleSeparator")]
    public System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle TitleSeparator { get { return default(System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeTitle")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_TitleSeparatorColor")]
    public System.Drawing.Color TitleSeparatorColor { get { return default(System.Drawing.Color); } set { } }
    protected override void Dispose(bool disposing) { }
  }
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCell_LegendCell")]
  public partial class LegendCell : System.Windows.Forms.DataVisualization.Charting.ChartNamedElement {
    public LegendCell() { }
    public LegendCell(string text) { }
    public LegendCell(System.Windows.Forms.DataVisualization.Charting.LegendCellType cellType, string text) { }
    public LegendCell(System.Windows.Forms.DataVisualization.Charting.LegendCellType cellType, string text, System.Drawing.ContentAlignment alignment) { }
    [System.ComponentModel.DefaultValueAttribute((System.Drawing.ContentAlignment)(32))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLayout")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCell_Alignment")]
    public virtual System.Drawing.ContentAlignment Alignment { get { return default(System.Drawing.ContentAlignment); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackColor")]
    public virtual System.Drawing.Color BackColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.DefaultValueAttribute(1)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLayout")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCell_CellSpan")]
    public virtual int CellSpan { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.LegendCellType)(0))]
    [System.ComponentModel.ParenthesizePropertyNameAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCell_CellType")]
    public virtual System.Windows.Forms.DataVisualization.Charting.LegendCellType CellType { get { return default(System.Windows.Forms.DataVisualization.Charting.LegendCellType); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCell_Font")]
    public virtual System.Drawing.Font Font { get { return default(System.Drawing.Font); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeForeColor")]
    public virtual System.Drawing.Color ForeColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ImageValueEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCell_Image")]
    public virtual string Image { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Size), "0, 0")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.SizeEmptyValueConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLayout")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCell_ImageSize")]
    public virtual System.Drawing.Size ImageSize { get { return default(System.Drawing.Size); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeImageTransparentColor")]
    public virtual System.Drawing.Color ImageTransparentColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public virtual System.Windows.Forms.DataVisualization.Charting.Legend Legend { get { return default(System.Windows.Forms.DataVisualization.Charting.Legend); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public virtual System.Windows.Forms.DataVisualization.Charting.LegendItem LegendItem { get { return default(System.Windows.Forms.DataVisualization.Charting.LegendItem); } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.Margins), "0,0,15,15")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLayout")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCell_Margins")]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(1))]
    public virtual System.Windows.Forms.DataVisualization.Charting.Margins Margins { get { return default(System.Windows.Forms.DataVisualization.Charting.Margins); } set { } }
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCell_Name")]
    public override string Name { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Size), "200, 70")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLayout")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCell_SeriesSymbolSize")]
    public virtual System.Drawing.Size SeriesSymbolSize { get { return default(System.Drawing.Size); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCell_Text")]
    public virtual string Text { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMapArea")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeToolTip")]
    public virtual string ToolTip { get { return default(string); } set { } }
    protected override void Dispose(bool disposing) { }
  }
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCellCollection_LegendCellCollection")]
  public partial class LegendCellCollection : System.Windows.Forms.DataVisualization.Charting.ChartNamedElementCollection<System.Windows.Forms.DataVisualization.Charting.LegendCell> {
    internal LegendCellCollection() { }
    public int Add(System.Windows.Forms.DataVisualization.Charting.LegendCellType cellType, string text, System.Drawing.ContentAlignment alignment) { return default(int); }
    public void Insert(int index, System.Windows.Forms.DataVisualization.Charting.LegendCellType cellType, string text, System.Drawing.ContentAlignment alignment) { }
  }
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCellColumn_LegendCellColumn")]
  public partial class LegendCellColumn : System.Windows.Forms.DataVisualization.Charting.ChartNamedElement {
    public LegendCellColumn() { }
    public LegendCellColumn(string headerText, System.Windows.Forms.DataVisualization.Charting.LegendCellColumnType columnType, string text) { }
    public LegendCellColumn(string headerText, System.Windows.Forms.DataVisualization.Charting.LegendCellColumnType columnType, string text, System.Drawing.ContentAlignment alignment) { }
    [System.ComponentModel.DefaultValueAttribute((System.Drawing.ContentAlignment)(32))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeSeriesItems")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCellColumn_Alignment")]
    public virtual System.Drawing.ContentAlignment Alignment { get { return default(System.Drawing.ContentAlignment); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeSeriesItems")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackColor")]
    public virtual System.Drawing.Color BackColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.LegendCellColumnType)(0))]
    [System.ComponentModel.ParenthesizePropertyNameAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeSeriesItems")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCellColumn_ColumnType")]
    public virtual System.Windows.Forms.DataVisualization.Charting.LegendCellColumnType ColumnType { get { return default(System.Windows.Forms.DataVisualization.Charting.LegendCellColumnType); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeSeriesItems")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCellColumn_Font")]
    public virtual System.Drawing.Font Font { get { return default(System.Drawing.Font); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeSeriesItems")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeForeColor")]
    public virtual System.Drawing.Color ForeColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.StringAlignment), "Center")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeHeader")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCellColumn_HeaderTextAlignment")]
    public System.Drawing.StringAlignment HeaderAlignment { get { return default(System.Drawing.StringAlignment); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeHeader")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeHeaderBackColor")]
    public virtual System.Drawing.Color HeaderBackColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Font), "Microsoft Sans Serif, 8pt, style=Bold")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeHeader")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCellColumn_HeaderFont")]
    public virtual System.Drawing.Font HeaderFont { get { return default(System.Drawing.Font); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeHeader")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCellColumn_HeaderColor")]
    public virtual System.Drawing.Color HeaderForeColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeHeader")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCellColumn_HeaderText")]
    public virtual string HeaderText { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public virtual System.Windows.Forms.DataVisualization.Charting.Legend Legend { get { return default(System.Windows.Forms.DataVisualization.Charting.Legend); } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.Margins), "0,0,15,15")]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeSeriesItems")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCellColumn_Margins")]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(1))]
    public virtual System.Windows.Forms.DataVisualization.Charting.Margins Margins { get { return default(System.Windows.Forms.DataVisualization.Charting.Margins); } set { } }
    [System.ComponentModel.DefaultValueAttribute(-1)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.IntNanValueConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeSize")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCellColumn_MaximumWidth")]
    public virtual int MaximumWidth { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute(-1)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.IntNanValueConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeSize")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCellColumn_MinimumWidth")]
    public virtual int MinimumWidth { get { return default(int); } set { } }
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCellColumn_Name")]
    public override string Name { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Size), "200, 70")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeSeriesItems")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCellColumn_SeriesSymbolSize")]
    public virtual System.Drawing.Size SeriesSymbolSize { get { return default(System.Drawing.Size); } set { } }
    [System.ComponentModel.DefaultValueAttribute("#LEGENDTEXT")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.KeywordsStringEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeSeriesItems")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCellColumn_Text")]
    public virtual string Text { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.KeywordsStringEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeSeriesItems")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeToolTip")]
    public virtual string ToolTip { get { return default(string); } set { } }
    protected override void Dispose(bool disposing) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeMargins() { return default(bool); }
  }
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCellColumnCollection_LegendCellColumnCollection")]
  public partial class LegendCellColumnCollection : System.Windows.Forms.DataVisualization.Charting.ChartNamedElementCollection<System.Windows.Forms.DataVisualization.Charting.LegendCellColumn> {
    internal LegendCellColumnCollection() { }
    protected override void Dispose(bool disposing) { }
  }
  public enum LegendCellColumnType {
    SeriesSymbol = 1,
    Text = 0,
  }
  public enum LegendCellType {
    Image = 2,
    SeriesSymbol = 1,
    Text = 0,
  }
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCollection_LegendCollection")]
  public partial class LegendCollection : System.Windows.Forms.DataVisualization.Charting.ChartNamedElementCollection<System.Windows.Forms.DataVisualization.Charting.Legend> {
    internal LegendCollection() { }
    public System.Windows.Forms.DataVisualization.Charting.Legend Add(string name) { return default(System.Windows.Forms.DataVisualization.Charting.Legend); }
  }
  public enum LegendImageStyle {
    Line = 1,
    Marker = 2,
    Rectangle = 0,
  }
  [System.ComponentModel.DefaultPropertyAttribute("Name")]
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendItem_LegendItem")]
  public partial class LegendItem : System.Windows.Forms.DataVisualization.Charting.ChartNamedElement {
    public LegendItem() { }
    public LegendItem(string name, System.Drawing.Color color, string image) { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.GradientStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.GradientEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackGradientStyle")]
    public System.Windows.Forms.DataVisualization.Charting.GradientStyle BackGradientStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.GradientStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.HatchStyleEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackHatchStyle")]
    public System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeImageTransparentColor")]
    public System.Drawing.Color BackImageTransparentColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackSecondaryColor")]
    public System.Drawing.Color BackSecondaryColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderColor")]
    public System.Drawing.Color BorderColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ChartDashStyle)(5))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderDashStyle")]
    public System.Windows.Forms.DataVisualization.Charting.ChartDashStyle BorderDashStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartDashStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(1)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderWidth")]
    public int BorderWidth { get { return default(int); } set { } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.LegendCellCollectionEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendItem_Cells")]
    public System.Windows.Forms.DataVisualization.Charting.LegendCellCollection Cells { get { return default(System.Windows.Forms.DataVisualization.Charting.LegendCellCollection); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendItem_Color")]
    public System.Drawing.Color Color { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.ComponentModel.ParenthesizePropertyNameAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendItem_Enabled")]
    public bool Enabled { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ImageValueEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendItem_Image")]
    public string Image { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.LegendImageStyle), "Rectangle")]
    [System.ComponentModel.ParenthesizePropertyNameAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendItem_Style")]
    public System.Windows.Forms.DataVisualization.Charting.LegendImageStyle ImageStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.LegendImageStyle); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public System.Windows.Forms.DataVisualization.Charting.Legend Legend { get { return default(System.Windows.Forms.DataVisualization.Charting.Legend); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMarker")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMarkerBorderColor")]
    public System.Drawing.Color MarkerBorderColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.DefaultValueAttribute(1)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMarker")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMarkerBorderWidth")]
    public int MarkerBorderWidth { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMarker")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendItem_MarkerColor")]
    public System.Drawing.Color MarkerColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ImageValueEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMarker")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMarkerImage")]
    public string MarkerImage { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMarker")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeImageTransparentColor")]
    public System.Drawing.Color MarkerImageTransparentColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(5)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMarker")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendItem_MarkerSize")]
    public int MarkerSize { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.MarkerStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.MarkerStyleEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMarker")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendItem_MarkerStyle")]
    public System.Windows.Forms.DataVisualization.Charting.MarkerStyle MarkerStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.MarkerStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.ParenthesizePropertyNameAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendItem_Name")]
    public override string Name { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendItem_SeparatorColor")]
    public System.Drawing.Color SeparatorColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle), "None")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendItem_Separator")]
    public System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle SeparatorType { get { return default(System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendItem_SeriesName")]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public string SeriesName { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(-1)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendItem_SeriesPointIndex")]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public int SeriesPointIndex { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "128,0,0,0")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeShadowColor")]
    public System.Drawing.Color ShadowColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeShadowOffset")]
    public int ShadowOffset { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMapArea")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeToolTip")]
    public string ToolTip { get { return default(string); } set { } }
    protected override void Dispose(bool disposing) { }
  }
  public enum LegendItemOrder {
    Auto = 0,
    ReversedSeriesOrder = 2,
    SameAsSeriesOrder = 1,
  }
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCustomLabelsCollection_CustomLabelsCollection")]
  public partial class LegendItemsCollection : System.Windows.Forms.DataVisualization.Charting.ChartElementCollection<System.Windows.Forms.DataVisualization.Charting.LegendItem> {
    internal LegendItemsCollection() { }
    public int Add(System.Drawing.Color color, string text) { return default(int); }
    public int Add(string image, string text) { return default(int); }
    public void Insert(int index, System.Drawing.Color color, string text) { }
    public void Insert(int index, string image, string text) { }
    public void Reverse() { }
  }
  public enum LegendSeparatorStyle {
    DashLine = 4,
    DotLine = 5,
    DoubleLine = 3,
    GradientLine = 6,
    Line = 1,
    None = 0,
    ThickGradientLine = 7,
    ThickLine = 2,
  }
  public enum LegendStyle {
    Column = 0,
    Row = 1,
    Table = 2,
  }
  public enum LegendTableStyle {
    Auto = 0,
    Tall = 2,
    Wide = 1,
  }
  public enum LightStyle {
    None = 0,
    Realistic = 2,
    Simplistic = 1,
  }
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineAnchorCapStyle_LineAnchorCapStyle")]
  public enum LineAnchorCapStyle {
    Arrow = 1,
    Diamond = 2,
    None = 0,
    Round = 4,
    Square = 3,
  }
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineAnnotation_LineAnnotation")]
  public partial class LineAnnotation : System.Windows.Forms.DataVisualization.Charting.Annotation {
    public LineAnnotation() { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.ContentAlignment), "MiddleCenter")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    public override System.Drawing.ContentAlignment Alignment { get { return default(System.Drawing.ContentAlignment); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.ContentAlignment), "TopLeft")]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAnchor")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnchorAlignment")]
    public override System.Drawing.ContentAlignment AnchorAlignment { get { return default(System.Drawing.ContentAlignment); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationType")]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public override string AnnotationType { get { return default(string); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    public override System.Drawing.Color BackColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.GradientStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.GradientEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    public override System.Windows.Forms.DataVisualization.Charting.GradientStyle BackGradientStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.GradientStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.HatchStyleEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    public override System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    public override System.Drawing.Color BackSecondaryColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle)(0))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeStartCap3")]
    public virtual System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle EndCap { get { return default(System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Font), "Microsoft Sans Serif, 8pt")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    public override System.Drawing.Font Font { get { return default(System.Drawing.Font); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeForeColor")]
    public override System.Drawing.Color ForeColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeDrawInfinitive")]
    public virtual bool IsInfinitive { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributePosition")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeSizeAlwaysRelative3")]
    public override bool IsSizeAlwaysRelative { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle)(0))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeStartCap3")]
    public virtual System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle StartCap { get { return default(System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override System.Windows.Forms.DataVisualization.Charting.TextStyle TextStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.TextStyle); } set { } }
  }
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.MarginExpandableObjectConverter))]
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMargins_Margins")]
  public partial class Margins {
    public Margins() { }
    public Margins(int top, int bottom, int left, int right) { }
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMargins_Bottom")]
    public int Bottom { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMargins_Left")]
    public int Left { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMargins_Right")]
    public int Right { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMargins_Top")]
    public int Top { get { return default(int); } set { } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public bool IsEmpty() { return default(bool); }
    public System.Drawing.RectangleF ToRectangleF() { return default(System.Drawing.RectangleF); }
    public override string ToString() { return default(string); }
  }
  public enum MarkerStyle {
    Circle = 2,
    Cross = 5,
    Diamond = 3,
    None = 0,
    Square = 1,
    Star10 = 9,
    Star4 = 6,
    Star5 = 7,
    Star6 = 8,
    Triangle = 4,
  }
  [System.ComponentModel.DefaultPropertyAttribute("Name")]
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeNamedImage_NamedImage")]
  public partial class NamedImage : System.Windows.Forms.DataVisualization.Charting.ChartNamedElement {
    public NamedImage() { }
    public NamedImage(string name, System.Drawing.Image image) { }
    [System.ComponentModel.BindableAttribute(false)]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeNamedImage_Image")]
    public System.Drawing.Image Image { get { return default(System.Drawing.Image); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeNamedImage_Name")]
    public override string Name { get { return default(string); } set { } }
    protected override void Dispose(bool disposing) { }
  }
  public partial class NamedImagesCollection : System.Windows.Forms.DataVisualization.Charting.ChartNamedElementCollection<System.Windows.Forms.DataVisualization.Charting.NamedImage> {
    internal NamedImagesCollection() { }
  }
  public partial class Point3D {
    public Point3D() { }
    public Point3D(float x, float y, float z) { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributePoint3D_PointF")]
    public System.Drawing.PointF PointF { get { return default(System.Drawing.PointF); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributePoint3D_X")]
    public float X { get { return default(float); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributePoint3D_Y")]
    public float Y { get { return default(float); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributePoint3D_Z")]
    public float Z { get { return default(float); } set { } }
  }
  public enum PointSortOrder {
    Ascending = 0,
    Descending = 1,
  }
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributePolygonAnnotation_PolygonAnnotation")]
  public partial class PolygonAnnotation : System.Windows.Forms.DataVisualization.Charting.PolylineAnnotation {
    public PolygonAnnotation() { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationType")]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public override string AnnotationType { get { return default(string); } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackColor")]
    public override System.Drawing.Color BackColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.GradientStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.GradientEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackGradientStyle")]
    public override System.Windows.Forms.DataVisualization.Charting.GradientStyle BackGradientStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.GradientStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.HatchStyleEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackHatchStyle")]
    public override System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackSecondaryColor")]
    public override System.Drawing.Color BackSecondaryColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle)(0))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    public override System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle EndCap { get { return default(System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle)(0))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    public override System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle StartCap { get { return default(System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle); } set { } }
  }
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributePolylineAnnotation_PolylineAnnotation")]
  public partial class PolylineAnnotation : System.Windows.Forms.DataVisualization.Charting.Annotation {
    public PolylineAnnotation() { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.ContentAlignment), "MiddleCenter")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    public override System.Drawing.ContentAlignment Alignment { get { return default(System.Drawing.ContentAlignment); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationType")]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public override string AnnotationType { get { return default(string); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    public override System.Drawing.Color BackColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.GradientStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.GradientEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    public override System.Windows.Forms.DataVisualization.Charting.GradientStyle BackGradientStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.GradientStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.HatchStyleEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    public override System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    public override System.Drawing.Color BackSecondaryColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle)(0))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeStartCap3")]
    public virtual System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle EndCap { get { return default(System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Font), "Microsoft Sans Serif, 8pt")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    public override System.Drawing.Font Font { get { return default(System.Drawing.Font); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeForeColor")]
    public override System.Drawing.Color ForeColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributePosition")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributePath")]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public virtual System.Drawing.Drawing2D.GraphicsPath GraphicsPath { get { return default(System.Drawing.Drawing2D.GraphicsPath); } set { } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartCollectionEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributePosition")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributePathPoints")]
    public System.Windows.Forms.DataVisualization.Charting.AnnotationPathPointCollection GraphicsPathPoints { get { return default(System.Windows.Forms.DataVisualization.Charting.AnnotationPathPointCollection); } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeFreeDrawPlacement")]
    public virtual bool IsFreeDrawPlacement { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle)(0))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeStartCap3")]
    public virtual System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle StartCap { get { return default(System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override System.Windows.Forms.DataVisualization.Charting.TextStyle TextStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.TextStyle); } set { } }
    protected override void Dispose(bool disposing) { }
    public override void EndPlacement() { }
  }
  public partial class PrintingManager : System.IDisposable {
    public PrintingManager(System.ComponentModel.Design.IServiceContainer container) { }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributePrintingManager_PrintDocument")]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public System.Drawing.Printing.PrintDocument PrintDocument { get { return default(System.Drawing.Printing.PrintDocument); } set { } }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public void PageSetup() { }
    public void Print(bool showPrintDialog) { }
    public void PrintPaint(System.Drawing.Graphics graphics, System.Drawing.Rectangle position) { }
    public void PrintPreview() { }
  }
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeRectangleAnnotation_RectangleAnnotation")]
  public partial class RectangleAnnotation : System.Windows.Forms.DataVisualization.Charting.TextAnnotation {
    public RectangleAnnotation() { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationType")]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public override string AnnotationType { get { return default(string); } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackColor")]
    public override System.Drawing.Color BackColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.GradientStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.GradientEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackGradientStyle")]
    public override System.Windows.Forms.DataVisualization.Charting.GradientStyle BackGradientStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.GradientStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.HatchStyleEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackHatchStyle")]
    public override System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackSecondaryColor")]
    public override System.Drawing.Color BackSecondaryColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineColor")]
    public override System.Drawing.Color LineColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ChartDashStyle)(5))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineDashStyle")]
    public override System.Windows.Forms.DataVisualization.Charting.ChartDashStyle LineDashStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartDashStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(1)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineWidth")]
    public override int LineWidth { get { return default(int); } set { } }
  }
  [System.FlagsAttribute]
  public enum ScrollBarButtonStyles {
    All = 3,
    None = 0,
    ResetZoom = 2,
    SmallScroll = 1,
  }
  public enum ScrollBarButtonType {
    LargeDecrement = 3,
    LargeIncrement = 4,
    SmallDecrement = 1,
    SmallIncrement = 2,
    ThumbTracker = 0,
    ZoomReset = 5,
  }
  public partial class ScrollBarEventArgs : System.EventArgs {
    public ScrollBarEventArgs(System.Windows.Forms.DataVisualization.Charting.Axis axis, int x, int y, System.Windows.Forms.DataVisualization.Charting.ScrollBarButtonType buttonType) { }
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxis")]
    public System.Windows.Forms.DataVisualization.Charting.Axis Axis { get { return default(System.Windows.Forms.DataVisualization.Charting.Axis); } }
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeScrollBarEventArgs_ButtonType")]
    public System.Windows.Forms.DataVisualization.Charting.ScrollBarButtonType ButtonType { get { return default(System.Windows.Forms.DataVisualization.Charting.ScrollBarButtonType); } }
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartArea")]
    public System.Windows.Forms.DataVisualization.Charting.ChartArea ChartArea { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartArea); } }
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeScrollBarEventArgs_Handled")]
    public bool IsHandled { get { return default(bool); } set { } }
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeScrollBarEventArgs_MousePositionX")]
    public int MousePositionX { get { return default(int); } }
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeScrollBarEventArgs_MousePositionY")]
    public int MousePositionY { get { return default(int); } }
  }
  public enum ScrollType {
    First = 4,
    LargeDecrement = 2,
    LargeIncrement = 3,
    Last = 5,
    SmallDecrement = 0,
    SmallIncrement = 1,
  }
  [System.FlagsAttribute]
  public enum SerializationContents {
    All = 7,
    Appearance = 4,
    Data = 2,
    Default = 1,
  }
  public enum SerializationFormat {
    Binary = 1,
    Xml = 0,
  }
  [System.ComponentModel.DefaultPropertyAttribute("Points")]
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeSeries_Series")]
  public partial class Series : System.Windows.Forms.DataVisualization.Charting.DataPointCustomProperties {
    public Series() { }
    public Series(string name) { }
    public Series(string name, int yValues) { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxisLabel")]
    public override string AxisLabel { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.SeriesAreaNameConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeChart")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeSeries_ChartArea")]
    public string ChartArea { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.SeriesChartType)(10))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartTypeEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeChart")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeSeries_Type")]
    public System.Windows.Forms.DataVisualization.Charting.SeriesChartType ChartType { get { return default(System.Windows.Forms.DataVisualization.Charting.SeriesChartType); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute("Column")]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartTypeEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.ChartTypeConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeChart")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeSeries_Type")]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public string ChartTypeName { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeEmptyPoints")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeSeries_EmptyPointStyle")]
    public System.Windows.Forms.DataVisualization.Charting.DataPointCustomProperties EmptyPointStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.DataPointCustomProperties); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.ParenthesizePropertyNameAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeSeries_Enabled")]
    public bool Enabled { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeData")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeSeries_XValueIndexed")]
    public bool IsXValueIndexed { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.SeriesLegendNameConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLegend")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeSeries_Legend")]
    public string Legend { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(1)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMarker")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeSeries_MarkerStep")]
    public int MarkerStep { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeData")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeSeries_Name")]
    public override string Name { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ChartColorPalette)(0))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ColorPaletteEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributePalette")]
    public System.Windows.Forms.DataVisualization.Charting.ChartColorPalette Palette { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartColorPalette); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.DataPointCollectionEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeData")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeSeries_Points")]
    public System.Windows.Forms.DataVisualization.Charting.DataPointCollection Points { get { return default(System.Windows.Forms.DataVisualization.Charting.DataPointCollection); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "128,0,0,0")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeShadowColor")]
    public System.Drawing.Color ShadowColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeShadowOffset")]
    public int ShadowOffset { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLabel")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeSeries_SmartLabels")]
    public System.Windows.Forms.DataVisualization.Charting.SmartLabelStyle SmartLabelStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.SmartLabelStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.AxisType)(0))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAxes")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeSeries_XAxisType")]
    public System.Windows.Forms.DataVisualization.Charting.AxisType XAxisType { get { return default(System.Windows.Forms.DataVisualization.Charting.AxisType); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.SeriesDataSourceMemberConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeDataSource")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeSeries_ValueMemberX")]
    public string XValueMember { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ChartValueType)(0))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeData")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeSeries_XValueType")]
    public System.Windows.Forms.DataVisualization.Charting.ChartValueType XValueType { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartValueType); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.AxisType)(0))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAxes")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeSeries_YAxisType")]
    public System.Windows.Forms.DataVisualization.Charting.AxisType YAxisType { get { return default(System.Windows.Forms.DataVisualization.Charting.AxisType); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.SeriesDataSourceMemberValueAxisUITypeEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.SeriesDataSourceMemberConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeDataSource")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeSeries_ValueMembersY")]
    public string YValueMembers { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(1)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeData")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeSeries_YValuesPerPoint")]
    public int YValuesPerPoint { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ChartValueType)(0))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.SeriesYValueTypeConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeData")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeSeries_YValueType")]
    public System.Windows.Forms.DataVisualization.Charting.ChartValueType YValueType { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartValueType); } set { } }
    protected override void Dispose(bool disposing) { }
    public void Sort(System.Collections.Generic.IComparer<System.Windows.Forms.DataVisualization.Charting.DataPoint> comparer) { }
    public void Sort(System.Windows.Forms.DataVisualization.Charting.PointSortOrder pointSortOrder) { }
    public void Sort(System.Windows.Forms.DataVisualization.Charting.PointSortOrder pointSortOrder, string sortBy) { }
  }
  public enum SeriesChartType {
    Area = 13,
    Bar = 7,
    BoxPlot = 28,
    Bubble = 2,
    Candlestick = 20,
    Column = 10,
    Doughnut = 18,
    ErrorBar = 27,
    FastLine = 6,
    FastPoint = 1,
    Funnel = 33,
    Kagi = 31,
    Line = 3,
    Pie = 17,
    Point = 0,
    PointAndFigure = 32,
    Polar = 26,
    Pyramid = 34,
    Radar = 25,
    Range = 21,
    RangeBar = 23,
    RangeColumn = 24,
    Renko = 29,
    Spline = 4,
    SplineArea = 14,
    SplineRange = 22,
    StackedArea = 15,
    StackedArea100 = 16,
    StackedBar = 8,
    StackedBar100 = 9,
    StackedColumn = 11,
    StackedColumn100 = 12,
    StepLine = 5,
    Stock = 19,
    ThreeLineBreak = 30,
  }
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeSeriesCollection_SeriesCollection")]
  public partial class SeriesCollection : System.Windows.Forms.DataVisualization.Charting.ChartNamedElementCollection<System.Windows.Forms.DataVisualization.Charting.Series> {
    internal SeriesCollection() { }
    public System.Windows.Forms.DataVisualization.Charting.Series Add(string name) { return default(System.Windows.Forms.DataVisualization.Charting.Series); }
  }
  [System.ComponentModel.DefaultPropertyAttribute("Enabled")]
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.NoNameExpandableObjectConverter))]
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeSmartLabelsStyle_SmartLabelsStyle")]
  public partial class SmartLabelStyle {
    public SmartLabelStyle() { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle)(2))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAllowOutsidePlotArea")]
    public virtual System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle AllowOutsidePlotArea { get { return default(System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Transparent")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCalloutBackColor")]
    public virtual System.Drawing.Color CalloutBackColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCalloutLineAnchorCap")]
    public virtual System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle CalloutLineAnchorCapStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCalloutLineColor")]
    public virtual System.Drawing.Color CalloutLineColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ChartDashStyle)(5))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineDashStyle")]
    public virtual System.Windows.Forms.DataVisualization.Charting.ChartDashStyle CalloutLineDashStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartDashStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(1)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineWidth")]
    public virtual int CalloutLineWidth { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.LabelCalloutStyle)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCalloutStyle3")]
    public virtual System.Windows.Forms.DataVisualization.Charting.LabelCalloutStyle CalloutStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.LabelCalloutStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.ComponentModel.ParenthesizePropertyNameAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeEnabled13")]
    public virtual bool Enabled { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMarkerOverlapping")]
    public virtual bool IsMarkerOverlappingAllowed { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeHideOverlapped")]
    public virtual bool IsOverlappedHidden { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(30)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMaxMovingDistance")]
    public virtual double MaxMovingDistance { get { return default(double); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMinMovingDistance")]
    public virtual double MinMovingDistance { get { return default(double); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles), "Top, Bottom, Right, Left, TopLeft, TopRight, BottomLeft, BottomRight")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.FlagsEnumUITypeEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMovingDirection")]
    public virtual System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles MovingDirection { get { return default(System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles); } set { } }
  }
  public enum StartFromZero {
    Auto = 0,
    No = 2,
    Yes = 1,
  }
  public partial class StatisticFormula {
    internal StatisticFormula() { }
    public System.Windows.Forms.DataVisualization.Charting.AnovaResult Anova(double probability, string inputSeriesNames) { return default(System.Windows.Forms.DataVisualization.Charting.AnovaResult); }
    public double BetaFunction(double m, double n) { return default(double); }
    public double Correlation(string firstInputSeriesName, string secondInputSeriesName) { return default(double); }
    public double Covariance(string firstInputSeriesName, string secondInputSeriesName) { return default(double); }
    public double FDistribution(double value, int firstDegreeOfFreedom, int secondDegreeOfFreedom) { return default(double); }
    public System.Windows.Forms.DataVisualization.Charting.FTestResult FTest(double probability, string firstInputSeriesName, string secondInputSeriesName) { return default(System.Windows.Forms.DataVisualization.Charting.FTestResult); }
    public double GammaFunction(double value) { return default(double); }
    public double InverseFDistribution(double probability, int firstDegreeOfFreedom, int secondDegreeOfFreedom) { return default(double); }
    public double InverseNormalDistribution(double probability) { return default(double); }
    public double InverseTDistribution(double probability, int degreeOfFreedom) { return default(double); }
    public double Mean(string inputSeriesName) { return default(double); }
    public double Median(string inputSeriesName) { return default(double); }
    public double NormalDistribution(double zValue) { return default(double); }
    public double TDistribution(double value, int degreeOfFreedom, bool oneTail) { return default(double); }
    public System.Windows.Forms.DataVisualization.Charting.TTestResult TTestEqualVariances(double hypothesizedMeanDifference, double probability, string firstInputSeriesName, string secondInputSeriesName) { return default(System.Windows.Forms.DataVisualization.Charting.TTestResult); }
    public System.Windows.Forms.DataVisualization.Charting.TTestResult TTestPaired(double hypothesizedMeanDifference, double probability, string firstInputSeriesName, string secondInputSeriesName) { return default(System.Windows.Forms.DataVisualization.Charting.TTestResult); }
    public System.Windows.Forms.DataVisualization.Charting.TTestResult TTestUnequalVariances(double hypothesizedMeanDifference, double probability, string firstInputSeriesName, string secondInputSeriesName) { return default(System.Windows.Forms.DataVisualization.Charting.TTestResult); }
    public double Variance(string inputSeriesName, bool sampleVariance) { return default(double); }
    public System.Windows.Forms.DataVisualization.Charting.ZTestResult ZTest(double hypothesizedMeanDifference, double varianceFirstGroup, double varianceSecondGroup, double probability, string firstInputSeriesName, string secondInputSeriesName) { return default(System.Windows.Forms.DataVisualization.Charting.ZTestResult); }
  }
  [System.ComponentModel.DefaultPropertyAttribute("IntervalOffset")]
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeStripLine_StripLine")]
  public partial class StripLine : System.Windows.Forms.DataVisualization.Charting.ChartElement {
    public StripLine() { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackColor")]
    public System.Drawing.Color BackColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.GradientStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.GradientEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackGradientStyle")]
    public System.Windows.Forms.DataVisualization.Charting.GradientStyle BackGradientStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.GradientStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.HatchStyleEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackHatchStyle")]
    public System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ImageValueEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackImage")]
    public string BackImage { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle)(0))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackImageAlign")]
    public System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle BackImageAlignment { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeImageTransparentColor")]
    public System.Drawing.Color BackImageTransparentColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode)(0))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeImageWrapMode")]
    public System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode BackImageWrapMode { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackSecondaryColor")]
    public System.Drawing.Color BackSecondaryColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderColor")]
    public System.Drawing.Color BorderColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ChartDashStyle)(5))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderDashStyle")]
    public System.Windows.Forms.DataVisualization.Charting.ChartDashStyle BorderDashStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartDashStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(1)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderWidth")]
    public int BorderWidth { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Font), "Microsoft Sans Serif, 8pt")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeTitle")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTitleFont")]
    public System.Drawing.Font Font { get { return default(System.Drawing.Font); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeTitle")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeStripLine_TitleColor")]
    public System.Drawing.Color ForeColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeData")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeStripLine_Interval")]
    public double Interval { get { return default(double); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.AxisLabelDateValueConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeData")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeStripLine_IntervalOffset")]
    public double IntervalOffset { get { return default(double); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType)(0))]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeData")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeStripLine_IntervalOffsetType")]
    public System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType IntervalOffsetType { get { return default(System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType)(0))]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeData")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeStripLine_IntervalType")]
    public System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType IntervalType { get { return default(System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute("StripLine")]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeStripLine_Name")]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public string Name { get { return default(string); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeData")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeStripLine_StripWidth")]
    public double StripWidth { get { return default(double); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType)(0))]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeData")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeStripLine_StripWidthType")]
    public System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType StripWidthType { get { return default(System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeTitle")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeStripLine_Title")]
    public string Text { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.StringAlignment), "Far")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeTitle")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeStripLine_TitleAlignment")]
    public System.Drawing.StringAlignment TextAlignment { get { return default(System.Drawing.StringAlignment); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.StringAlignment), "Near")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeTitle")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeStripLine_TitleLineAlignment")]
    public System.Drawing.StringAlignment TextLineAlignment { get { return default(System.Drawing.StringAlignment); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.TextOrientation)(0))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttribute_TextOrientation")]
    public System.Windows.Forms.DataVisualization.Charting.TextOrientation TextOrientation { get { return default(System.Windows.Forms.DataVisualization.Charting.TextOrientation); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMapArea")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeToolTip")]
    public string ToolTip { get { return default(string); } set { } }
    protected override void Dispose(bool disposing) { }
  }
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeStripLinesCollection_StripLinesCollection")]
  public partial class StripLinesCollection : System.Windows.Forms.DataVisualization.Charting.ChartElementCollection<System.Windows.Forms.DataVisualization.Charting.StripLine> {
    internal StripLinesCollection() { }
  }
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTextAnnotation_TextAnnotation")]
  public partial class TextAnnotation : System.Windows.Forms.DataVisualization.Charting.Annotation {
    public TextAnnotation() { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTextAnnotation_AnnotationType")]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public override string AnnotationType { get { return default(string); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    public override System.Drawing.Color BackColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.GradientStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.GradientEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    public override System.Windows.Forms.DataVisualization.Charting.GradientStyle BackGradientStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.GradientStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.HatchStyleEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    public override System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    public override System.Drawing.Color BackSecondaryColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Font), "Microsoft Sans Serif, 8pt")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTextFont4")]
    public override System.Drawing.Font Font { get { return default(System.Drawing.Font); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMultiline")]
    public virtual bool IsMultiline { get { return default(bool); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    public override System.Drawing.Color LineColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ChartDashStyle)(5))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    public override System.Windows.Forms.DataVisualization.Charting.ChartDashStyle LineDashStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartDashStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(1)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineWidth")]
    public override int LineWidth { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeText")]
    public virtual string Text { get { return default(string); } set { } }
    public void BeginTextEditing() { }
    public override void EndPlacement() { }
    public void StopTextEditing() { }
  }
  public enum TextAntiAliasingQuality {
    High = 1,
    Normal = 0,
    SystemDefault = 2,
  }
  public enum TextOrientation {
    Auto = 0,
    Horizontal = 1,
    Rotated270 = 3,
    Rotated90 = 2,
    Stacked = 4,
  }
  public enum TextStyle {
    Default = 0,
    Embed = 3,
    Emboss = 2,
    Frame = 4,
    Shadow = 1,
  }
  [System.ComponentModel.DefaultPropertyAttribute("Enabled")]
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTickMark_TickMark")]
  public partial class TickMark : System.Windows.Forms.DataVisualization.Charting.Grid {
    public TickMark() { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(1f)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTickMark_Size")]
    public float Size { get { return default(float); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.TickMarkStyle)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTickMark_Style")]
    public System.Windows.Forms.DataVisualization.Charting.TickMarkStyle TickMarkStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.TickMarkStyle); } set { } }
  }
  public enum TickMarkStyle {
    AcrossAxis = 3,
    InsideArea = 2,
    None = 0,
    OutsideArea = 1,
  }
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTitle5")]
  public partial class Title : System.Windows.Forms.DataVisualization.Charting.ChartNamedElement, System.IDisposable {
    public Title() { }
    public Title(string text) { }
    public Title(string text, System.Windows.Forms.DataVisualization.Charting.Docking docking) { }
    public Title(string text, System.Windows.Forms.DataVisualization.Charting.Docking docking, System.Drawing.Font font, System.Drawing.Color color) { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Drawing.ContentAlignment)(32))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeDocking")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTitle_Alignment")]
    public System.Drawing.ContentAlignment Alignment { get { return default(System.Drawing.ContentAlignment); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackColor")]
    public System.Drawing.Color BackColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.GradientStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.GradientEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackGradientStyle")]
    public System.Windows.Forms.DataVisualization.Charting.GradientStyle BackGradientStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.GradientStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.HatchStyleEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackHatchStyle")]
    public System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ImageValueEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackImage")]
    public string BackImage { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle)(0))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackImageAlign")]
    public System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle BackImageAlignment { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeImageTransparentColor")]
    public System.Drawing.Color BackImageTransparentColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode)(0))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeImageWrapMode")]
    public System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode BackImageWrapMode { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackSecondaryColor")]
    public System.Drawing.Color BackSecondaryColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderColor")]
    public System.Drawing.Color BorderColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.ChartDashStyle)(5))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderDashStyle")]
    public System.Windows.Forms.DataVisualization.Charting.ChartDashStyle BorderDashStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartDashStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(1)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderWidth")]
    public int BorderWidth { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("NotSet")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.LegendAreaNameConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeDocking")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTitle_DockToChartArea")]
    public string DockedToChartArea { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.Docking)(0))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeDocking")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTitle_Docking")]
    public System.Windows.Forms.DataVisualization.Charting.Docking Docking { get { return default(System.Windows.Forms.DataVisualization.Charting.Docking); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeDocking")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTitle_DockOffset")]
    public int DockingOffset { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Font), "Microsoft Sans Serif, 8pt")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTitle_Font")]
    public System.Drawing.Font Font { get { return default(System.Drawing.Font); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTitle_Color")]
    public System.Drawing.Color ForeColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeDocking")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTitle_DockInsideChartArea")]
    public bool IsDockedInsideChartArea { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTitle_Name")]
    public override string Name { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Windows.Forms.DataVisualization.Charting.ElementPositionConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTitle_Position")]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(2))]
    public System.Windows.Forms.DataVisualization.Charting.ElementPosition Position { get { return default(System.Windows.Forms.DataVisualization.Charting.ElementPosition); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "128, 0, 0, 0")]
    [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataVisualization.Charting.ChartColorEditor, System.Windows.Forms.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeShadowColor")]
    public System.Drawing.Color ShadowColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeShadowOffset")]
    public int ShadowOffset { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.ParenthesizePropertyNameAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTitle_Text")]
    public string Text { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.TextOrientation)(0))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttribute_TextOrientation")]
    public System.Windows.Forms.DataVisualization.Charting.TextOrientation TextOrientation { get { return default(System.Windows.Forms.DataVisualization.Charting.TextOrientation); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Windows.Forms.DataVisualization.Charting.TextStyle)(0))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTextStyle")]
    public System.Windows.Forms.DataVisualization.Charting.TextStyle TextStyle { get { return default(System.Windows.Forms.DataVisualization.Charting.TextStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeToolTip")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeToolTip")]
    public string ToolTip { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.ComponentModel.ParenthesizePropertyNameAttribute(true)]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTitle_Visible")]
    public virtual bool Visible { get { return default(bool); } set { } }
    protected override void Dispose(bool disposing) { }
  }
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTitles")]
  public partial class TitleCollection : System.Windows.Forms.DataVisualization.Charting.ChartNamedElementCollection<System.Windows.Forms.DataVisualization.Charting.Title> {
    internal TitleCollection() { }
    public System.Windows.Forms.DataVisualization.Charting.Title Add(string name) { return default(System.Windows.Forms.DataVisualization.Charting.Title); }
  }
  public partial class ToolTipEventArgs : System.EventArgs {
    public ToolTipEventArgs(int x, int y, string text, System.Windows.Forms.DataVisualization.Charting.HitTestResult result) { }
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeToolTipEventArgs_HitTestResult")]
    public System.Windows.Forms.DataVisualization.Charting.HitTestResult HitTestResult { get { return default(System.Windows.Forms.DataVisualization.Charting.HitTestResult); } }
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeToolTipEventArgs_Text")]
    public string Text { get { return default(string); } set { } }
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeToolTipEventArgs_X")]
    public int X { get { return default(int); } }
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeToolTipEventArgs_Y")]
    public int Y { get { return default(int); } }
  }
  public partial class TTestResult {
    public TTestResult() { }
    public double DegreeOfFreedom { get { return default(double); } }
    public double FirstSeriesMean { get { return default(double); } }
    public double FirstSeriesVariance { get { return default(double); } }
    public double ProbabilityTOneTail { get { return default(double); } }
    public double ProbabilityTTwoTail { get { return default(double); } }
    public double SecondSeriesMean { get { return default(double); } }
    public double SecondSeriesVariance { get { return default(double); } }
    public double TCriticalValueOneTail { get { return default(double); } }
    public double TCriticalValueTwoTail { get { return default(double); } }
    public double TValue { get { return default(double); } }
  }
  [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeVerticalLineAnnotation_VerticalLineAnnotation")]
  public partial class VerticalLineAnnotation : System.Windows.Forms.DataVisualization.Charting.LineAnnotation {
    public VerticalLineAnnotation() { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Windows.Forms.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationType")]
    [System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Windows.Forms.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public override string AnnotationType { get { return default(string); } }
  }
  public partial class ViewEventArgs : System.EventArgs {
    public ViewEventArgs(System.Windows.Forms.DataVisualization.Charting.Axis axis, double newPosition) { }
    public ViewEventArgs(System.Windows.Forms.DataVisualization.Charting.Axis axis, double newPosition, double newSize, System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType newSizeType) { }
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxis")]
    public System.Windows.Forms.DataVisualization.Charting.Axis Axis { get { return default(System.Windows.Forms.DataVisualization.Charting.Axis); } }
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartArea")]
    public System.Windows.Forms.DataVisualization.Charting.ChartArea ChartArea { get { return default(System.Windows.Forms.DataVisualization.Charting.ChartArea); } }
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeViewEventArgs_NewPosition")]
    public double NewPosition { get { return default(double); } set { } }
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeViewEventArgs_NewSize")]
    public double NewSize { get { return default(double); } set { } }
    [System.Windows.Forms.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeViewEventArgs_NewSizeType")]
    public System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType NewSizeType { get { return default(System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType); } set { } }
  }
  public partial class ZTestResult {
    public ZTestResult() { }
    public double FirstSeriesMean { get { return default(double); } }
    public double FirstSeriesVariance { get { return default(double); } }
    public double ProbabilityZOneTail { get { return default(double); } }
    public double ProbabilityZTwoTail { get { return default(double); } }
    public double SecondSeriesMean { get { return default(double); } }
    public double SecondSeriesVariance { get { return default(double); } }
    public double ZCriticalValueOneTail { get { return default(double); } }
    public double ZCriticalValueTwoTail { get { return default(double); } }
    public double ZValue { get { return default(double); } }
  }
}
