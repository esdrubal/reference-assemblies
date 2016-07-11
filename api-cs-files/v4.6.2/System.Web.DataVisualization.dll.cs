namespace System.Web.UI.DataVisualization.Charting {
  [System.ComponentModel.DefaultPropertyAttribute("Name")]
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotation_Annotation")]
  public abstract partial class Annotation : System.Web.UI.DataVisualization.Charting.ChartNamedElement, System.Web.UI.DataVisualization.Charting.IChartMapArea {
    protected Annotation() { }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.ContentAlignment), "MiddleCenter")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAlignment")]
    public virtual System.Drawing.ContentAlignment Alignment { get { return default(System.Drawing.ContentAlignment); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.ContentAlignment), "BottomCenter")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAnchor")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnchorAlignment")]
    public virtual System.Drawing.ContentAlignment AnchorAlignment { get { return default(System.Drawing.ContentAlignment); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.AnchorPointUITypeEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.AnchorPointValueConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAnchor")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnchorDataPoint")]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public virtual System.Web.UI.DataVisualization.Charting.DataPoint AnchorDataPoint { get { return default(System.Web.UI.DataVisualization.Charting.DataPoint); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAnchor")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnchorDataPointName")]
    public virtual string AnchorDataPointName { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAnchor")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnchorOffsetX3")]
    public virtual double AnchorOffsetX { get { return default(double); } set { } }
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAnchor")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnchorOffsetY3")]
    public virtual double AnchorOffsetY { get { return default(double); } set { } }
    [System.ComponentModel.DefaultValueAttribute(0.0 / 0.0)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.DoubleNanValueConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAnchor")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnchorX")]
    public virtual double AnchorX { get { return default(double); } set { } }
    [System.ComponentModel.DefaultValueAttribute(0.0 / 0.0)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.DoubleNanValueConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAnchor")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnchorY")]
    public virtual double AnchorY { get { return default(double); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public System.Web.UI.DataVisualization.Charting.AnnotationGroup AnnotationGroup { get { return default(System.Web.UI.DataVisualization.Charting.AnnotationGroup); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotation_AnnotationType")]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public abstract string AnnotationType { get; }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.AnnotationAxisUITypeEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.AnnotationAxisValueConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAnchorAxes")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxisX")]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public virtual System.Web.UI.DataVisualization.Charting.Axis AxisX { get { return default(System.Web.UI.DataVisualization.Charting.Axis); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAnchorAxes")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxisXName")]
    public virtual string AxisXName { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.AnnotationAxisUITypeEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.AnnotationAxisValueConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAnchorAxes")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxisY")]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public virtual System.Web.UI.DataVisualization.Charting.Axis AxisY { get { return default(System.Web.UI.DataVisualization.Charting.Axis); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAnchorAxes")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxisYName")]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public virtual string AxisYName { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackColor")]
    public virtual System.Drawing.Color BackColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.GradientStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.GradientEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackGradientStyle")]
    public virtual System.Web.UI.DataVisualization.Charting.GradientStyle BackGradientStyle { get { return default(System.Web.UI.DataVisualization.Charting.GradientStyle); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ChartHatchStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.HatchStyleEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackHatchStyle")]
    public virtual System.Web.UI.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { get { return default(System.Web.UI.DataVisualization.Charting.ChartHatchStyle); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackSecondaryColor")]
    public virtual System.Drawing.Color BackSecondaryColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(0.0 / 0.0)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.DoubleNanValueConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributePosition")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBottom")]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public virtual double Bottom { get { return default(double); } set { } }
    [System.ComponentModel.DefaultValueAttribute("NotSet")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.LegendAreaNameConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationClipToChartArea")]
    public virtual string ClipToChartArea { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Font), "Microsoft Sans Serif, 8pt")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTextFont")]
    public virtual System.Drawing.Font Font { get { return default(System.Drawing.Font); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeForeColor")]
    public virtual System.Drawing.Color ForeColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.DefaultValueAttribute(0.0 / 0.0)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.DoubleNanValueConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributePosition")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationHeight")]
    public virtual double Height { get { return default(double); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeSelected")]
    public virtual bool IsSelected { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributePosition")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeSizeAlwaysRelative")]
    public virtual bool IsSizeAlwaysRelative { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineColor")]
    public virtual System.Drawing.Color LineColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ChartDashStyle)(5))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineDashStyle")]
    public virtual System.Web.UI.DataVisualization.Charting.ChartDashStyle LineDashStyle { get { return default(System.Web.UI.DataVisualization.Charting.ChartDashStyle); } set { } }
    [System.ComponentModel.DefaultValueAttribute(1)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineWidth")]
    public virtual int LineWidth { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMapAreaAttributes")]
    public virtual string MapAreaAttributes { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.ParenthesizePropertyNameAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeName4")]
    public override string Name { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMapArea")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributePostBackValue")]
    public string PostBackValue { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(0.0 / 0.0)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.DoubleNanValueConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributePosition")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeRight3")]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public virtual double Right { get { return default(double); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "128,0,0,0")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeShadowColor")]
    public virtual System.Drawing.Color ShadowColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeShadowOffset")]
    public virtual int ShadowOffset { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeSmartLabels")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    public System.Web.UI.DataVisualization.Charting.AnnotationSmartLabelStyle SmartLabelStyle { get { return default(System.Web.UI.DataVisualization.Charting.AnnotationSmartLabelStyle); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Web.UI.DataVisualization.Charting.TextStyle), "Default")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTextStyle")]
    public virtual System.Web.UI.DataVisualization.Charting.TextStyle TextStyle { get { return default(System.Web.UI.DataVisualization.Charting.TextStyle); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeToolTip")]
    public virtual string ToolTip { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeUrl")]
    public virtual string Url { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.ComponentModel.ParenthesizePropertyNameAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeVisible")]
    public virtual bool Visible { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(0.0 / 0.0)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.DoubleNanValueConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributePosition")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationWidth")]
    public virtual double Width { get { return default(double); } set { } }
    [System.ComponentModel.DefaultValueAttribute(0.0 / 0.0)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.DoubleNanValueConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributePosition")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationBaseX")]
    public virtual double X { get { return default(double); } set { } }
    [System.ComponentModel.DefaultValueAttribute(0.0 / 0.0)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.DoubleNanValueConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributePosition")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationBaseY")]
    public virtual double Y { get { return default(double); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAnchorAxes")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxisYName")]
    public virtual string YAxisName { get { return default(string); } set { } }
    public virtual void BringToFront() { }
    protected override void Dispose(bool disposing) { }
    public virtual void ResizeToContent() { }
    public virtual void SendToBack() { }
    public void SetAnchor(System.Web.UI.DataVisualization.Charting.DataPoint dataPoint) { }
    public void SetAnchor(System.Web.UI.DataVisualization.Charting.DataPoint dataPoint1, System.Web.UI.DataVisualization.Charting.DataPoint dataPoint2) { }
  }
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotations3")]
  public partial class AnnotationCollection : System.Web.UI.DataVisualization.Charting.ChartNamedElementCollection<System.Web.UI.DataVisualization.Charting.Annotation> {
    internal AnnotationCollection() { }
    public override System.Web.UI.DataVisualization.Charting.Annotation FindByName(string name) { return default(System.Web.UI.DataVisualization.Charting.Annotation); }
  }
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationGroup_AnnotationGroup")]
  public partial class AnnotationGroup : System.Web.UI.DataVisualization.Charting.Annotation {
    public AnnotationGroup() { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.ContentAlignment), "MiddleCenter")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAlignment")]
    public override System.Drawing.ContentAlignment Alignment { get { return default(System.Drawing.ContentAlignment); } set { } }
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.AnnotationCollectionEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAnnotations")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationGroup_Annotations")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    public System.Web.UI.DataVisualization.Charting.AnnotationCollection Annotations { get { return default(System.Web.UI.DataVisualization.Charting.AnnotationCollection); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationType")]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public override string AnnotationType { get { return default(string); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackColor")]
    public override System.Drawing.Color BackColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.GradientStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.GradientEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackGradientStyle")]
    public override System.Web.UI.DataVisualization.Charting.GradientStyle BackGradientStyle { get { return default(System.Web.UI.DataVisualization.Charting.GradientStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ChartHatchStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.HatchStyleEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackHatchStyle")]
    public override System.Web.UI.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { get { return default(System.Web.UI.DataVisualization.Charting.ChartHatchStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackSecondaryColor")]
    public override System.Drawing.Color BackSecondaryColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute("NotSet")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.LegendAreaNameConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationGroup_ClipToChartArea")]
    public override string ClipToChartArea { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Font), "Microsoft Sans Serif, 8pt")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTextFont")]
    public override System.Drawing.Font Font { get { return default(System.Drawing.Font); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeForeColor")]
    public override System.Drawing.Color ForeColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationGroup_Selected")]
    public override bool IsSelected { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributePosition")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationGroup_SizeAlwaysRelative")]
    public override bool IsSizeAlwaysRelative { get { return default(bool); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineColor")]
    public override System.Drawing.Color LineColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ChartDashStyle)(5))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineDashStyle")]
    public override System.Web.UI.DataVisualization.Charting.ChartDashStyle LineDashStyle { get { return default(System.Web.UI.DataVisualization.Charting.ChartDashStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(1)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineWidth")]
    public override int LineWidth { get { return default(int); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "128,0,0,0")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeShadowColor")]
    public override System.Drawing.Color ShadowColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeShadowOffset")]
    public override int ShadowOffset { get { return default(int); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override System.Web.UI.DataVisualization.Charting.TextStyle TextStyle { get { return default(System.Web.UI.DataVisualization.Charting.TextStyle); } set { } }
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.ComponentModel.ParenthesizePropertyNameAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationGroup_Visible")]
    public override bool Visible { get { return default(bool); } set { } }
    protected override void Dispose(bool disposing) { }
  }
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationPathPoint_AnnotationPathPoint")]
  public partial class AnnotationPathPoint : System.Web.UI.DataVisualization.Charting.ChartElement {
    public AnnotationPathPoint() { }
    public AnnotationPathPoint(float x, float y) { }
    public AnnotationPathPoint(float x, float y, byte type) { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute("PathPoint")]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationPathPoint_Name")]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public string Name { get { return default(string); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(byte), "1")]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributePosition")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationPathPoint_Name")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public byte PointType { get { return default(byte); } set { } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0f)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributePosition")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationPathPoint_X")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public float X { get { return default(float); } set { } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0f)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributePosition")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationPathPoint_Y")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public float Y { get { return default(float); } set { } }
  }
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationPathPointCollection_AnnotationPathPointCollection")]
  public partial class AnnotationPathPointCollection : System.Web.UI.DataVisualization.Charting.ChartElementCollection<System.Web.UI.DataVisualization.Charting.AnnotationPathPoint> {
    public AnnotationPathPointCollection(System.Web.UI.DataVisualization.Charting.PolylineAnnotation annotation) { }
    protected override void Dispose(bool disposing) { }
    public override void Invalidate() { }
  }
  [System.ComponentModel.DefaultPropertyAttribute("Enabled")]
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.NoNameExpandableObjectConverter))]
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationSmartLabelsStyle_AnnotationSmartLabelsStyle")]
  public partial class AnnotationSmartLabelStyle : System.Web.UI.DataVisualization.Charting.SmartLabelStyle {
    public AnnotationSmartLabelStyle() { }
    public AnnotationSmartLabelStyle(object chartElement) { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Transparent")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCalloutBackColor")]
    public override System.Drawing.Color CalloutBackColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.LineAnchorCapStyle)(1))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCalloutLineAnchorCapStyle")]
    public override System.Web.UI.DataVisualization.Charting.LineAnchorCapStyle CalloutLineAnchorCapStyle { get { return default(System.Web.UI.DataVisualization.Charting.LineAnchorCapStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCalloutLineColor")]
    public override System.Drawing.Color CalloutLineColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ChartDashStyle)(5))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineDashStyle")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public override System.Web.UI.DataVisualization.Charting.ChartDashStyle CalloutLineDashStyle { get { return default(System.Web.UI.DataVisualization.Charting.ChartDashStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(1)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineWidth")]
    public override int CalloutLineWidth { get { return default(int); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.LabelCalloutStyle)(1))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCalloutStyle3")]
    public override System.Web.UI.DataVisualization.Charting.LabelCalloutStyle CalloutStyle { get { return default(System.Web.UI.DataVisualization.Charting.LabelCalloutStyle); } set { } }
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
    All = 7,
    AxesView = 4,
    None = 0,
    PlotPosition = 2,
    Position = 1,
  }
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeArrowAnnotation_ArrowAnnotation")]
  public partial class ArrowAnnotation : System.Web.UI.DataVisualization.Charting.Annotation {
    public ArrowAnnotation() { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.ContentAlignment), "TopLeft")]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAnchor")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnchorAlignment")]
    public override System.Drawing.ContentAlignment AnchorAlignment { get { return default(System.Drawing.ContentAlignment); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationType")]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public override string AnnotationType { get { return default(string); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(5)]
    [System.ComponentModel.ParenthesizePropertyNameAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeArrowAnnotation_ArrowSize")]
    public virtual int ArrowSize { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ArrowStyle)(0))]
    [System.ComponentModel.ParenthesizePropertyNameAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeArrowAnnotation_ArrowStyle")]
    public virtual System.Web.UI.DataVisualization.Charting.ArrowStyle ArrowStyle { get { return default(System.Web.UI.DataVisualization.Charting.ArrowStyle); } set { } }
  }
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeArrowStyle_ArrowStyle")]
  public enum ArrowStyle {
    DoubleArrow = 1,
    Simple = 0,
    Tailed = 2,
  }
  [System.ComponentModel.DefaultPropertyAttribute("Enabled")]
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxis_Axis")]
  public partial class Axis : System.Web.UI.DataVisualization.Charting.ChartNamedElement, System.Web.UI.DataVisualization.Charting.IChartMapArea {
    public Axis() { }
    public Axis(System.Web.UI.DataVisualization.Charting.ChartArea chartArea, System.Web.UI.DataVisualization.Charting.AxisName axisTypeName) { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.AxisArrowStyle)(0))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeArrows")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.AxisArrowStyle ArrowStyle { get { return default(System.Web.UI.DataVisualization.Charting.AxisArrowStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeType")]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public virtual System.Web.UI.DataVisualization.Charting.AxisName AxisName { get { return default(System.Web.UI.DataVisualization.Charting.AxisName); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0.0 / 0.0)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.AxisCrossingValueConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeScale")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCrossing")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public virtual double Crossing { get { return default(double); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartCollectionEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLabels")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCustomLabels")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    public System.Web.UI.DataVisualization.Charting.CustomLabelsCollection CustomLabels { get { return default(System.Web.UI.DataVisualization.Charting.CustomLabelsCollection); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Web.UI.DataVisualization.Charting.AxisEnabled), "Auto")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeEnabled7")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.AxisEnabled Enabled { get { return default(System.Web.UI.DataVisualization.Charting.AxisEnabled); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeInterlacedColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color InterlacedColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.AxisIntervalValueConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeInterval")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeInterval4")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public double Interval { get { return default(double); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.IntervalAutoMode)(0))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeInterval")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeIntervalAutoMode")]
    public System.Web.UI.DataVisualization.Charting.IntervalAutoMode IntervalAutoMode { get { return default(System.Web.UI.DataVisualization.Charting.IntervalAutoMode); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.AxisIntervalValueConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeInterval")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeIntervalOffset6")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public double IntervalOffset { get { return default(double); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.DateTimeIntervalType)(0))]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeInterval")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeIntervalOffsetType4")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.DateTimeIntervalType IntervalOffsetType { get { return default(System.Web.UI.DataVisualization.Charting.DateTimeIntervalType); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.DateTimeIntervalType)(0))]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeInterval")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeIntervalType4")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.DateTimeIntervalType IntervalType { get { return default(System.Web.UI.DataVisualization.Charting.DateTimeIntervalType); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeInterlaced")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public bool IsInterlaced { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLabels")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLabelsAutoFit")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public bool IsLabelAutoFit { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeScale")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLogarithmic")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public bool IsLogarithmic { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeScale")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMargin")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public bool IsMarginVisible { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMarksNextToAxis")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public virtual bool IsMarksNextToAxis { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeScale")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeReverse")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public bool IsReversed { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeScale")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeStartFromZero3")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public bool IsStartedFromZero { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(10)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLabels")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLabelsAutoFitMaxFontSize")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public int LabelAutoFitMaxFontSize { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(6)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLabels")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLabelsAutoFitMinFontSize")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public int LabelAutoFitMinFontSize { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.LabelAutoFitStyles)(79))]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.FlagsEnumUITypeEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLabels")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLabelsAutoFitStyle")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.LabelAutoFitStyles LabelAutoFitStyle { get { return default(System.Web.UI.DataVisualization.Charting.LabelAutoFitStyles); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.NoNameExpandableObjectConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLabels")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLabelStyle")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    public System.Web.UI.DataVisualization.Charting.LabelStyle LabelStyle { get { return default(System.Web.UI.DataVisualization.Charting.LabelStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color LineColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ChartDashStyle)(5))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineDashStyle")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.ChartDashStyle LineDashStyle { get { return default(System.Web.UI.DataVisualization.Charting.ChartDashStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(1)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineWidth")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public int LineWidth { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(10)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeScale")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLogarithmBase")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public double LogarithmBase { get { return default(double); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.NoNameExpandableObjectConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeGridTickMarks")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMajorGrid")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    public System.Web.UI.DataVisualization.Charting.Grid MajorGrid { get { return default(System.Web.UI.DataVisualization.Charting.Grid); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.NoNameExpandableObjectConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeGridTickMarks")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMajorTickMark")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    public System.Web.UI.DataVisualization.Charting.TickMark MajorTickMark { get { return default(System.Web.UI.DataVisualization.Charting.TickMark); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMapArea")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMapAreaAttributes")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public string MapAreaAttributes { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0.0 / 0.0)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.AxisMinMaxAutoValueConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeScale")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMaximum")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public double Maximum { get { return default(double); } set { } }
    [System.ComponentModel.DefaultValueAttribute(75f)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLabels")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxis_MaxAutoSize")]
    public float MaximumAutoSize { get { return default(float); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0.0 / 0.0)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.AxisMinMaxAutoValueConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeScale")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMinimum")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public double Minimum { get { return default(double); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.NoNameExpandableObjectConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeGridTickMarks")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMinorGrid")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    public System.Web.UI.DataVisualization.Charting.Grid MinorGrid { get { return default(System.Web.UI.DataVisualization.Charting.Grid); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.NoNameExpandableObjectConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeGridTickMarks")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMinorTickMark")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    public System.Web.UI.DataVisualization.Charting.TickMark MinorTickMark { get { return default(System.Web.UI.DataVisualization.Charting.TickMark); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxis_Name")]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public override string Name { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMapArea")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributePostBackValue")]
    public string PostBackValue { get { return default(string); } set { } }
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.NoNameExpandableObjectConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeScale")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeScaleBreakStyle")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    public virtual System.Web.UI.DataVisualization.Charting.AxisScaleBreakStyle ScaleBreakStyle { get { return default(System.Web.UI.DataVisualization.Charting.AxisScaleBreakStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.NoNameExpandableObjectConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeDataView")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeView")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    public System.Web.UI.DataVisualization.Charting.AxisScaleView ScaleView { get { return default(System.Web.UI.DataVisualization.Charting.AxisScaleView); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartCollectionEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeStripLines")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    public System.Web.UI.DataVisualization.Charting.StripLinesCollection StripLines { get { return default(System.Web.UI.DataVisualization.Charting.StripLinesCollection); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.TextOrientation)(0))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeTitle")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttribute_TextOrientation")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.TextOrientation TextOrientation { get { return default(System.Web.UI.DataVisualization.Charting.TextOrientation); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeTitle")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTitle6")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public string Title { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.StringAlignment), "Center")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeTitle")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTitleAlignment")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.StringAlignment TitleAlignment { get { return default(System.Drawing.StringAlignment); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Font), "Microsoft Sans Serif, 8pt")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeTitle")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTitleFont")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Font TitleFont { get { return default(System.Drawing.Font); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeTitle")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTitleColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color TitleForeColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMapArea")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeToolTip")]
    public string ToolTip { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.UrlValueEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMapArea")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeUrl")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public string Url { get { return default(string); } set { } }
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
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxisScaleBreakStyle_AxisScaleBreakStyle")]
  public partial class AxisScaleBreakStyle {
    public AxisScaleBreakStyle() { }
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.BreakLineStyle)(3))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxisScaleBreakStyle_BreakLineType")]
    public System.Web.UI.DataVisualization.Charting.BreakLineStyle BreakLineStyle { get { return default(System.Web.UI.DataVisualization.Charting.BreakLineStyle); } set { } }
    [System.ComponentModel.DefaultValueAttribute(25)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxisScaleBreakStyle_CollapsibleSpaceThreshold")]
    public int CollapsibleSpaceThreshold { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.ComponentModel.ParenthesizePropertyNameAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxisScaleBreakStyle_Enabled")]
    public bool Enabled { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineColor")]
    public System.Drawing.Color LineColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ChartDashStyle)(5))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineDashStyle")]
    public System.Web.UI.DataVisualization.Charting.ChartDashStyle LineDashStyle { get { return default(System.Web.UI.DataVisualization.Charting.ChartDashStyle); } set { } }
    [System.ComponentModel.DefaultValueAttribute(1)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineWidth")]
    public int LineWidth { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute(2)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxisScaleBreakStyle_MaxNumberOfBreaks")]
    public int MaxNumberOfBreaks { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute(1.5)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxisScaleBreakStyle_Spacing")]
    public double Spacing { get { return default(double); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.StartFromZero)(0))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxisScaleBreakStyle_StartFromZero")]
    public System.Web.UI.DataVisualization.Charting.StartFromZero StartFromZero { get { return default(System.Web.UI.DataVisualization.Charting.StartFromZero); } set { } }
  }
  [System.ComponentModel.DefaultPropertyAttribute("Position")]
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxisDataView_AxisDataView")]
  public partial class AxisScaleView {
    public AxisScaleView() { }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAxisView")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxisDataView_IsZoomed")]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public bool IsZoomed { get { return default(bool); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0.0 / 0.0)]
    [System.ComponentModel.ParenthesizePropertyNameAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.DoubleDateNanValueConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAxisView")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxisDataView_Position")]
    public double Position { get { return default(double); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0.0 / 0.0)]
    [System.ComponentModel.ParenthesizePropertyNameAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.DoubleNanValueConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAxisView")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxisDataView_Size")]
    public double Size { get { return default(double); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.DateTimeIntervalType)(0))]
    [System.ComponentModel.ParenthesizePropertyNameAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAxisView")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxisDataView_SizeType")]
    public System.Web.UI.DataVisualization.Charting.DateTimeIntervalType SizeType { get { return default(System.Web.UI.DataVisualization.Charting.DateTimeIntervalType); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public double ViewMaximum { get { return default(double); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public double ViewMinimum { get { return default(double); } }
  }
  public enum AxisType {
    Primary = 0,
    Secondary = 1,
  }
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorder3DAnnotation_Border3DAnnotation")]
  public partial class Border3DAnnotation : System.Web.UI.DataVisualization.Charting.RectangleAnnotation {
    public Border3DAnnotation() { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationType")]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public override string AnnotationType { get { return default(string); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.LegendConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderSkin")]
    public System.Web.UI.DataVisualization.Charting.BorderSkin BorderSkin { get { return default(System.Web.UI.DataVisualization.Charting.BorderSkin); } set { } }
  }
  [System.ComponentModel.DefaultPropertyAttribute("SkinStyle")]
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderSkin_BorderSkin")]
  public partial class BorderSkin : System.Web.UI.DataVisualization.Charting.ChartElement {
    public BorderSkin() { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Gray")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeFrameBackColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color BackColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.GradientStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.GradientEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackGradientStyle")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.GradientStyle BackGradientStyle { get { return default(System.Web.UI.DataVisualization.Charting.GradientStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ChartHatchStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.HatchStyleEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeFrameBackHatchStyle")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { get { return default(System.Web.UI.DataVisualization.Charting.ChartHatchStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ImageValueEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackImage")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public string BackImage { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ChartImageAlignmentStyle)(0))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackImageAlign")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.ChartImageAlignmentStyle BackImageAlignment { get { return default(System.Web.UI.DataVisualization.Charting.ChartImageAlignmentStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeImageTransparentColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color BackImageTransparentColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ChartImageWrapMode)(0))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeImageWrapMode")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.ChartImageWrapMode BackImageWrapMode { get { return default(System.Web.UI.DataVisualization.Charting.ChartImageWrapMode); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderSkin_FrameBackSecondaryColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color BackSecondaryColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color BorderColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ChartDashStyle)(0))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderSkin_FrameBorderDashStyle")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.ChartDashStyle BorderDashStyle { get { return default(System.Web.UI.DataVisualization.Charting.ChartDashStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(1)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderSkin_FrameBorderWidth")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public int BorderWidth { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "White")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderSkin_PageColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color PageColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.BorderSkinStyle)(0))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.ParenthesizePropertyNameAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderSkin_SkinStyle")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.BorderSkinStyle SkinStyle { get { return default(System.Web.UI.DataVisualization.Charting.BorderSkinStyle); } set { } }
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
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCalloutAnnotation_CalloutAnnotation")]
  public partial class CalloutAnnotation : System.Web.UI.DataVisualization.Charting.TextAnnotation {
    public CalloutAnnotation() { }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.ContentAlignment), "BottomLeft")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAnchor")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnchorAlignment")]
    public override System.Drawing.ContentAlignment AnchorAlignment { get { return default(System.Drawing.ContentAlignment); } set { } }
    [System.ComponentModel.DefaultValueAttribute(3)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAnchor")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCalloutAnnotation_AnchorOffsetX")]
    public override double AnchorOffsetX { get { return default(double); } set { } }
    [System.ComponentModel.DefaultValueAttribute(3)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAnchor")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCalloutAnnotation_AnchorOffsetY")]
    public override double AnchorOffsetY { get { return default(double); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationType")]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public override string AnnotationType { get { return default(string); } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackColor")]
    public override System.Drawing.Color BackColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.GradientStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.GradientEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackGradientStyle")]
    public override System.Web.UI.DataVisualization.Charting.GradientStyle BackGradientStyle { get { return default(System.Web.UI.DataVisualization.Charting.GradientStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ChartHatchStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.HatchStyleEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackHatchStyle")]
    public override System.Web.UI.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { get { return default(System.Web.UI.DataVisualization.Charting.ChartHatchStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackSecondaryColor")]
    public override System.Drawing.Color BackSecondaryColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.LineAnchorCapStyle)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCalloutAnnotation_CalloutAnchorCap")]
    public virtual System.Web.UI.DataVisualization.Charting.LineAnchorCapStyle CalloutAnchorCap { get { return default(System.Web.UI.DataVisualization.Charting.LineAnchorCapStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.CalloutStyle)(3))]
    [System.ComponentModel.ParenthesizePropertyNameAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCalloutAnnotation_CalloutStyle")]
    public virtual System.Web.UI.DataVisualization.Charting.CalloutStyle CalloutStyle { get { return default(System.Web.UI.DataVisualization.Charting.CalloutStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineColor")]
    public override System.Drawing.Color LineColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ChartDashStyle)(5))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineDashStyle")]
    public override System.Web.UI.DataVisualization.Charting.ChartDashStyle LineDashStyle { get { return default(System.Web.UI.DataVisualization.Charting.ChartDashStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(1)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineWidth")]
    public override int LineWidth { get { return default(int); } set { } }
  }
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCalloutStyle_CalloutStyle")]
  public enum CalloutStyle {
    Borderline = 1,
    Cloud = 2,
    Ellipse = 5,
    Perspective = 6,
    Rectangle = 3,
    RoundedRectangle = 4,
    SimpleLine = 0,
  }
  [System.ComponentModel.DefaultEventAttribute("Load")]
  [System.ComponentModel.DesignerAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartWebDesigner, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  [System.ComponentModel.DisplayNameAttribute("Chart")]
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Web.UI.DataVisualization.Charting.Chart), "ChartControl.ico")]
  [System.Web.UI.SupportsEventValidationAttribute]
  [System.Web.UI.ToolboxDataAttribute("<{0}:Chart runat=server><Series><{0}:Series Name=\"Series1\"></{0}:Series></Series><ChartAreas><{0}:ChartArea Name=\"ChartArea1\"></{0}:ChartArea></ChartAreas></{0}:Chart>")]
  public partial class Chart : System.Web.UI.WebControls.DataBoundControl, System.Web.UI.IPostBackEventHandler {
    public Chart() { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.LocalizableAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartImageAlternateText")]
    public string AlternateText { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.AnnotationCollectionEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeChart")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotations3")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    public System.Web.UI.DataVisualization.Charting.AnnotationCollection Annotations { get { return default(System.Web.UI.DataVisualization.Charting.AnnotationCollection); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Web.UI.DataVisualization.Charting.AntiAliasingStyles), "All")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.FlagsEnumUITypeEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeImage")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAntiAlias")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.AntiAliasingStyles AntiAliasing { get { return default(System.Web.UI.DataVisualization.Charting.AntiAliasingStyles); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "White")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public override System.Drawing.Color BackColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.GradientStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.GradientEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackGradientStyle")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.GradientStyle BackGradientStyle { get { return default(System.Web.UI.DataVisualization.Charting.GradientStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ChartHatchStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.HatchStyleEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackHatchStyle")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { get { return default(System.Web.UI.DataVisualization.Charting.ChartHatchStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.UrlValueEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackImage")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public string BackImage { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ChartImageAlignmentStyle)(0))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackImageAlign")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.ChartImageAlignmentStyle BackImageAlignment { get { return default(System.Web.UI.DataVisualization.Charting.ChartImageAlignmentStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeImageTransparentColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color BackImageTransparentColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ChartImageWrapMode)(0))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeImageWrapMode")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.ChartImageWrapMode BackImageWrapMode { get { return default(System.Web.UI.DataVisualization.Charting.ChartImageWrapMode); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackSecondaryColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color BackSecondaryColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override System.Drawing.Color BorderColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "White")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color BorderlineColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ChartDashStyle)(0))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderDashStyle")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.ChartDashStyle BorderlineDashStyle { get { return default(System.Web.UI.DataVisualization.Charting.ChartDashStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(1)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChart_BorderlineWidth")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public int BorderlineWidth { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.BorderSkinStyle)(0))]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.LegendConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderSkin")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    public System.Web.UI.DataVisualization.Charting.BorderSkin BorderSkin { get { return default(System.Web.UI.DataVisualization.Charting.BorderSkin); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override System.Web.UI.WebControls.BorderStyle BorderStyle { get { return default(System.Web.UI.WebControls.BorderStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override System.Web.UI.WebControls.Unit BorderWidth { get { return default(System.Web.UI.WebControls.Unit); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChart_BuildNumber")]
    public string BuildNumber { get { return default(string); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartCollectionEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeChart")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartAreas")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    public System.Web.UI.DataVisualization.Charting.ChartAreaCollection ChartAreas { get { return default(System.Web.UI.DataVisualization.Charting.ChartAreaCollection); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeImage")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChart_Compression")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public int Compression { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public string CurrentImageLocation { get { return default(string); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeData")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeDataManipulator")]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public System.Web.UI.DataVisualization.Charting.DataManipulator DataManipulator { get { return default(System.Web.UI.DataVisualization.Charting.DataManipulator); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.ChartDataSourceConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeData")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeDataSource")]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public override object DataSource { get { return default(object); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.UrlValueEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.LocalizableAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAccessibility")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartImageDescriptionUrl")]
    [System.Web.UI.UrlPropertyAttribute]
    public string DescriptionUrl { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeViewState")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChart_EnableViewState")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public override bool EnableViewState { get { return default(bool); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public override System.Web.UI.WebControls.FontInfo Font { get { return default(System.Web.UI.WebControls.FontInfo); } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChart_ForeColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public override System.Drawing.Color ForeColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Web.UI.WebControls.Unit), "300")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeImage")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeHeight3")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public override System.Web.UI.WebControls.Unit Height { get { return default(System.Web.UI.WebControls.Unit); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("ChartPic_#SEQ(300,3)")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ImageValueEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeImage")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChart_ImageUrl")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public string ImageLocation { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeChart")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChart_Images")]
    public System.Web.UI.DataVisualization.Charting.NamedImagesCollection Images { get { return default(System.Web.UI.DataVisualization.Charting.NamedImagesCollection); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ImageStorageMode)(0))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeImage")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChart_ImageStorageMode")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.ImageStorageMode ImageStorageMode { get { return default(System.Web.UI.DataVisualization.Charting.ImageStorageMode); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ChartImageType)(2))]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeImage")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartImageType")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.ChartImageType ImageType { get { return default(System.Web.UI.DataVisualization.Charting.ChartImageType); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMap")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeIsMapAreaAttributesEncoded")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public bool IsMapAreaAttributesEncoded { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMap")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMapEnabled")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public bool IsMapEnabled { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeImage")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChart_SoftShadows")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public bool IsSoftShadows { get { return default(bool); } set { } }
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.LegendCollectionEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeChart")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegends")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    public System.Web.UI.DataVisualization.Charting.LegendCollection Legends { get { return default(System.Web.UI.DataVisualization.Charting.LegendCollection); } }
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartCollectionEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMap")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMapAreas")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    public System.Web.UI.DataVisualization.Charting.MapAreasCollection MapAreas { get { return default(System.Web.UI.DataVisualization.Charting.MapAreasCollection); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ChartColorPalette)(12))]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ColorPaletteEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributePalette")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.ChartColorPalette Palette { get { return default(System.Web.UI.DataVisualization.Charting.ChartColorPalette); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.ColorArrayConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChart_PaletteCustomColors")]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(1))]
    public System.Drawing.Color[] PaletteCustomColors { get { return default(System.Drawing.Color[]); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.RenderType)(0))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeImage")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChart_RenderType")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.RenderType RenderType { get { return default(System.Web.UI.DataVisualization.Charting.RenderType); } set { } }
    [System.ComponentModel.CategoryAttribute("Appearance")]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.RightToLeft)(0))]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeRightToLeft")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.RightToLeft RightToLeft { get { return default(System.Web.UI.DataVisualization.Charting.RightToLeft); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeSerializer")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChart_Serializer")]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public System.Web.UI.DataVisualization.Charting.ChartSerializer Serializer { get { return default(System.Web.UI.DataVisualization.Charting.ChartSerializer); } }
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.SeriesCollectionEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeChart")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChart_Series")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    [System.Web.UI.ThemeableAttribute(false)]
    public System.Web.UI.DataVisualization.Charting.SeriesCollection Series { get { return default(System.Web.UI.DataVisualization.Charting.SeriesCollection); } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeSuppressExceptions")]
    public bool SuppressExceptions { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Web.UI.DataVisualization.Charting.TextAntiAliasingQuality), "High")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeImage")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTextAntiAliasingQuality")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.TextAntiAliasingQuality TextAntiAliasingQuality { get { return default(System.Web.UI.DataVisualization.Charting.TextAntiAliasingQuality); } set { } }
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartCollectionEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeChart")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTitles")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    public System.Web.UI.DataVisualization.Charting.TitleCollection Titles { get { return default(System.Web.UI.DataVisualization.Charting.TitleCollection); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Web.UI.DataVisualization.Charting.SerializationContents), "Default")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.FlagsEnumUITypeEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeBehavior")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChart_ViewStateContent")]
    public System.Web.UI.DataVisualization.Charting.SerializationContents ViewStateContent { get { return default(System.Web.UI.DataVisualization.Charting.SerializationContents); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("ViewStateData has been deprecated. Please investigate Control.ViewState instead.")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeViewState")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChart_ViewStateData")]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public string ViewStateData { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Web.UI.WebControls.Unit), "300")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeImage")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeWidth")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public override System.Web.UI.WebControls.Unit Width { get { return default(System.Web.UI.WebControls.Unit); } set { } }
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAction")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartEvent_Click")]
    public event System.Web.UI.WebControls.ImageMapEventHandler Click { add { } remove { } }
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartEvent_Customize")]
    public event System.EventHandler Customize { add { } remove { } }
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartEvent_CustomizeLegend")]
    public event System.EventHandler<System.Web.UI.DataVisualization.Charting.CustomizeLegendEventArgs> CustomizeLegend { add { } remove { } }
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartEvent_CustomizeMapAreas")]
    public event System.EventHandler<System.Web.UI.DataVisualization.Charting.CustomizeMapAreasEventArgs> CustomizeMapAreas { add { } remove { } }
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartEvent_PrePaint")]
    public event System.EventHandler<System.Web.UI.DataVisualization.Charting.FormatNumberEventArgs> FormatNumber { add { } remove { } }
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartEvent_PostPaint")]
    public event System.EventHandler<System.Web.UI.DataVisualization.Charting.ChartPaintEventArgs> PostPaint { add { } remove { } }
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartEvent_PrePaint")]
    public event System.EventHandler<System.Web.UI.DataVisualization.Charting.ChartPaintEventArgs> PrePaint { add { } remove { } }
    public void AlignDataPointsByAxisLabel() { }
    public void AlignDataPointsByAxisLabel(string series) { }
    public void AlignDataPointsByAxisLabel(string series, System.Web.UI.DataVisualization.Charting.PointSortOrder sortingOrder) { }
    public void AlignDataPointsByAxisLabel(System.Web.UI.DataVisualization.Charting.PointSortOrder sortingOrder) { }
    public void ApplyPaletteColors() { }
    public void DataBindCrossTable(System.Collections.IEnumerable dataSource, string seriesGroupByField, string xField, string yFields, string otherFields) { }
    public void DataBindCrossTable(System.Collections.IEnumerable dataSource, string seriesGroupByField, string xField, string yFields, string otherFields, System.Web.UI.DataVisualization.Charting.PointSortOrder sortingOrder) { }
    public void DataBindTable(System.Collections.IEnumerable dataSource) { }
    public void DataBindTable(System.Collections.IEnumerable dataSource, string xField) { }
    public sealed override void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public System.Web.UI.DataVisualization.Charting.ChartElementOutline GetChartElementOutline(object chartElement, System.Web.UI.DataVisualization.Charting.ChartElementType elementType) { return default(System.Web.UI.DataVisualization.Charting.ChartElementOutline); }
    public string GetHtmlImageMap(string name) { return default(string); }
    public object GetService(System.Type serviceType) { return default(object); }
    public System.Web.UI.DataVisualization.Charting.HitTestResult HitTest(int x, int y) { return default(System.Web.UI.DataVisualization.Charting.HitTestResult); }
    public System.Web.UI.DataVisualization.Charting.HitTestResult HitTest(int x, int y, bool ignoreTransparent) { return default(System.Web.UI.DataVisualization.Charting.HitTestResult); }
    public System.Web.UI.DataVisualization.Charting.HitTestResult[] HitTest(int x, int y, bool ignoreTransparent, params System.Web.UI.DataVisualization.Charting.ChartElementType[] requestedElement) { return default(System.Web.UI.DataVisualization.Charting.HitTestResult[]); }
    public System.Web.UI.DataVisualization.Charting.HitTestResult HitTest(int x, int y, System.Web.UI.DataVisualization.Charting.ChartElementType requestedElement) { return default(System.Web.UI.DataVisualization.Charting.HitTestResult); }
    public void LoadTemplate(System.IO.Stream stream) { }
    public void LoadTemplate(string name) { }
    protected override void LoadViewState(object savedState) { }
    protected virtual void OnClick(System.Web.UI.WebControls.ImageMapEventArgs e) { }
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChart_OnCustomize")]
    protected virtual void OnCustomize(System.EventArgs e) { }
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChart_OnCustomizeLegend")]
    protected virtual void OnCustomizeLegend(System.Web.UI.DataVisualization.Charting.CustomizeLegendEventArgs e) { }
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChart_OnCustomizeMapAreas")]
    protected virtual void OnCustomizeMapAreas(System.Web.UI.DataVisualization.Charting.CustomizeMapAreasEventArgs e) { }
    protected virtual void OnFormatNumber(object caller, System.Web.UI.DataVisualization.Charting.FormatNumberEventArgs e) { }
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChart_OnPaint")]
    protected virtual void OnPostPaint(System.Web.UI.DataVisualization.Charting.ChartPaintEventArgs e) { }
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChart_OnBackPaint")]
    protected virtual void OnPrePaint(System.Web.UI.DataVisualization.Charting.ChartPaintEventArgs e) { }
    public void Paint(System.Drawing.Graphics graphics, System.Drawing.Rectangle position) { }
    protected override void PerformDataBinding(System.Collections.IEnumerable data) { }
    protected virtual void RaisePostBackEvent(string eventArgument) { }
    protected override void Render(System.Web.UI.HtmlTextWriter writer) { }
    public void ResetAutoValues() { }
    public void SaveImage(System.IO.Stream imageStream) { }
    public void SaveImage(System.IO.Stream imageStream, System.Web.UI.DataVisualization.Charting.ChartImageFormat format) { }
    public void SaveImage(string imageFileName) { }
    public void SaveImage(string imageFileName, System.Web.UI.DataVisualization.Charting.ChartImageFormat format) { }
    protected override object SaveViewState() { return default(object); }
    public void SaveXml(string name) { }
    void System.Web.UI.IPostBackEventHandler.RaisePostBackEvent(string eventArgument) { }
    protected override void ValidateDataSource(object dataSource) { }
  }
  [System.ComponentModel.DefaultPropertyAttribute("Axes")]
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartArea_ChartArea")]
  public partial class ChartArea : System.Web.UI.DataVisualization.Charting.ChartNamedElement {
    public ChartArea() { }
    public ChartArea(string name) { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.AreaAlignmentOrientations)(1))]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.FlagsEnumUITypeEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAlignment")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartArea_AlignOrientation")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.AreaAlignmentOrientations AlignmentOrientation { get { return default(System.Web.UI.DataVisualization.Charting.AreaAlignmentOrientations); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.AreaAlignmentStyles)(7))]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.FlagsEnumUITypeEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAlignment")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartArea_AlignType")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.AreaAlignmentStyles AlignmentStyle { get { return default(System.Web.UI.DataVisualization.Charting.AreaAlignmentStyles); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("NotSet")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.LegendAreaNameConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAlignment")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartArea_AlignWithChartArea")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public string AlignWithChartArea { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.NoNameExpandableObjectConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttribute3D")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeArea3DStyle")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    public System.Web.UI.DataVisualization.Charting.ChartArea3DStyle Area3DStyle { get { return default(System.Web.UI.DataVisualization.Charting.ChartArea3DStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.AxesArrayEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.AxesArrayConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAxes")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartArea_Axes")]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public System.Web.UI.DataVisualization.Charting.Axis[] Axes { get { return default(System.Web.UI.DataVisualization.Charting.Axis[]); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.NoNameExpandableObjectConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAxis")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartArea_AxisX")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    public System.Web.UI.DataVisualization.Charting.Axis AxisX { get { return default(System.Web.UI.DataVisualization.Charting.Axis); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.NoNameExpandableObjectConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAxis")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartArea_AxisX2")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    public System.Web.UI.DataVisualization.Charting.Axis AxisX2 { get { return default(System.Web.UI.DataVisualization.Charting.Axis); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.NoNameExpandableObjectConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAxis")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartArea_AxisY")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    public System.Web.UI.DataVisualization.Charting.Axis AxisY { get { return default(System.Web.UI.DataVisualization.Charting.Axis); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.NoNameExpandableObjectConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAxis")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartArea_AxisY2")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    public System.Web.UI.DataVisualization.Charting.Axis AxisY2 { get { return default(System.Web.UI.DataVisualization.Charting.Axis); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color BackColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.GradientStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.GradientEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackGradientStyle")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.GradientStyle BackGradientStyle { get { return default(System.Web.UI.DataVisualization.Charting.GradientStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ChartHatchStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.HatchStyleEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackHatchStyle")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { get { return default(System.Web.UI.DataVisualization.Charting.ChartHatchStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ImageValueEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackImage")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public string BackImage { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ChartImageAlignmentStyle)(0))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackImageAlign")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.ChartImageAlignmentStyle BackImageAlignment { get { return default(System.Web.UI.DataVisualization.Charting.ChartImageAlignmentStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeImageTransparentColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color BackImageTransparentColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ChartImageWrapMode)(0))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeImageWrapMode")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.ChartImageWrapMode BackImageWrapMode { get { return default(System.Web.UI.DataVisualization.Charting.ChartImageWrapMode); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackSecondaryColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color BackSecondaryColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color BorderColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ChartDashStyle)(0))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderDashStyle")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.ChartDashStyle BorderDashStyle { get { return default(System.Web.UI.DataVisualization.Charting.ChartDashStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(1)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderWidth")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public int BorderWidth { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.ElementPositionConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartArea_InnerPlotPosition")]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(2))]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    public System.Web.UI.DataVisualization.Charting.ElementPosition InnerPlotPosition { get { return default(System.Web.UI.DataVisualization.Charting.ElementPosition); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartArea_EquallySizedAxesFont")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public bool IsSameFontSizeForAllAxes { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartArea_Name")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public override string Name { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.ElementPositionConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartArea_Position")]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(2))]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    public System.Web.UI.DataVisualization.Charting.ElementPosition Position { get { return default(System.Web.UI.DataVisualization.Charting.ElementPosition); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "128,0,0,0")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeShadowColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color ShadowColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeShadowOffset")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public int ShadowOffset { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.ComponentModel.ParenthesizePropertyNameAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartArea_Visible")]
    public virtual bool Visible { get { return default(bool); } set { } }
    protected override void Dispose(bool disposing) { }
    public float GetSeriesDepth(System.Web.UI.DataVisualization.Charting.Series series) { return default(float); }
    public float GetSeriesZPosition(System.Web.UI.DataVisualization.Charting.Series series) { return default(float); }
    public void RecalculateAxesScale() { }
    public void TransformPoints(System.Web.UI.DataVisualization.Charting.Point3D[] points) { }
  }
  public partial class ChartArea3DStyle {
    public ChartArea3DStyle() { }
    public ChartArea3DStyle(System.Web.UI.DataVisualization.Charting.ChartArea chartArea) { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.ComponentModel.ParenthesizePropertyNameAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttribute3D")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartArea3DStyle_Enable3D")]
    public bool Enable3D { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(30)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttribute3D")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartArea3DStyle_Inclination")]
    public int Inclination { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttribute3D")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartArea3DStyle_Clustered")]
    public bool IsClustered { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttribute3D")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartArea3DStyle_RightAngleAxes")]
    public bool IsRightAngleAxes { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Web.UI.DataVisualization.Charting.LightStyle), "Simplistic")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttribute3D")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartArea3DStyle_Light")]
    public System.Web.UI.DataVisualization.Charting.LightStyle LightStyle { get { return default(System.Web.UI.DataVisualization.Charting.LightStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttribute3D")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartArea3DStyle_Perspective")]
    public int Perspective { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(100)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttribute3D")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartArea3DStyle_PointDepth")]
    public int PointDepth { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(100)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttribute3D")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartArea3DStyle_PointGapDepth")]
    public int PointGapDepth { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(30)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttribute3D")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartArea3DStyle_Rotation")]
    public int Rotation { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(7)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttribute3D")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartArea3DStyle_WallWidth")]
    public int WallWidth { get { return default(int); } set { } }
  }
  public partial class ChartAreaCollection : System.Web.UI.DataVisualization.Charting.ChartNamedElementCollection<System.Web.UI.DataVisualization.Charting.ChartArea> {
    internal ChartAreaCollection() { }
    public System.Web.UI.DataVisualization.Charting.ChartArea Add(string name) { return default(System.Web.UI.DataVisualization.Charting.ChartArea); }
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
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public object Tag { get { return default(object); } set { } }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
  }
  public abstract partial class ChartElementCollection<T> : System.Collections.ObjectModel.Collection<T>, System.IDisposable where T : System.Web.UI.DataVisualization.Charting.ChartElement {
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
    Annotation = 16,
    Axis = 3,
    AxisLabelImage = 7,
    AxisLabels = 8,
    AxisTitle = 9,
    DataPoint = 10,
    DataPointLabel = 11,
    Gridlines = 5,
    LegendArea = 12,
    LegendHeader = 14,
    LegendItem = 15,
    LegendTitle = 13,
    Nothing = 0,
    PlottingArea = 2,
    StripLines = 6,
    TickMarks = 4,
    Title = 1,
  }
  public partial class ChartGraphics : System.Web.UI.DataVisualization.Charting.ChartElement {
    internal ChartGraphics() { }
    public System.Drawing.Graphics Graphics { get { return default(System.Drawing.Graphics); } set { } }
    protected override void Dispose(bool disposing) { }
    public System.Drawing.PointF GetAbsolutePoint(System.Drawing.PointF point) { return default(System.Drawing.PointF); }
    public System.Drawing.RectangleF GetAbsoluteRectangle(System.Drawing.RectangleF rectangle) { return default(System.Drawing.RectangleF); }
    public System.Drawing.SizeF GetAbsoluteSize(System.Drawing.SizeF size) { return default(System.Drawing.SizeF); }
    public double GetPositionFromAxis(string chartAreaName, System.Web.UI.DataVisualization.Charting.AxisName axis, double axisValue) { return default(double); }
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
  public partial class ChartHttpHandler : System.Web.UI.Page, System.Web.IHttpHandler, System.Web.SessionState.IRequiresSessionState {
    public ChartHttpHandler() { }
    public static System.Web.UI.DataVisualization.Charting.ChartHttpHandlerSettings Settings { get { return default(System.Web.UI.DataVisualization.Charting.ChartHttpHandlerSettings); } }
    bool System.Web.IHttpHandler.IsReusable { get { return default(bool); } }
    void System.Web.IHttpHandler.ProcessRequest(System.Web.HttpContext context) { }
  }
  public partial class ChartHttpHandlerSettings {
    internal ChartHttpHandlerSettings() { }
    public string CustomHandlerName { get { return default(string); } set { } }
    public string Directory { get { return default(string); } set { } }
    public string FolderName { get { return default(string); } set { } }
    public System.Type HandlerType { get { return default(System.Type); } }
    public string this[string name] { get { return default(string); } }
    public bool PrivateImages { get { return default(bool); } }
    public System.Web.UI.DataVisualization.Charting.ChartHttpHandlerStorageType StorageType { get { return default(System.Web.UI.DataVisualization.Charting.ChartHttpHandlerStorageType); } set { } }
    public System.TimeSpan Timeout { get { return default(System.TimeSpan); } set { } }
    public string Url { get { return default(string); } set { } }
  }
  public enum ChartHttpHandlerStorageType {
    File = 1,
    InProcess = 0,
    Session = 2,
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
    EmfDual = 7,
    EmfPlus = 6,
    Gif = 4,
    Jpeg = 0,
    Png = 1,
    Tiff = 3,
  }
  public enum ChartImageType {
    Bmp = 0,
    Emf = 3,
    Jpeg = 1,
    Png = 2,
  }
  public enum ChartImageWrapMode {
    Scaled = 4,
    Tile = 0,
    TileFlipX = 1,
    TileFlipXY = 3,
    TileFlipY = 2,
    Unscaled = 100,
  }
  public abstract partial class ChartNamedElement : System.Web.UI.DataVisualization.Charting.ChartElement {
    protected ChartNamedElement() { }
    protected ChartNamedElement(string name) { }
    [System.ComponentModel.DefaultValueAttribute("")]
    public virtual string Name { get { return default(string); } set { } }
  }
  public abstract partial class ChartNamedElementCollection<T> : System.Web.UI.DataVisualization.Charting.ChartElementCollection<T> where T : System.Web.UI.DataVisualization.Charting.ChartNamedElement {
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
    public System.Web.UI.DataVisualization.Charting.Chart Chart { get { return default(System.Web.UI.DataVisualization.Charting.Chart); } }
    public object ChartElement { get { return default(object); } }
    public System.Web.UI.DataVisualization.Charting.ChartGraphics ChartGraphics { get { return default(System.Web.UI.DataVisualization.Charting.ChartGraphics); } }
    public System.Web.UI.DataVisualization.Charting.ElementPosition Position { get { return default(System.Web.UI.DataVisualization.Charting.ElementPosition); } }
  }
  [System.ComponentModel.DefaultPropertyAttribute("Format")]
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartSerializer_ChartSerializer")]
  public partial class ChartSerializer {
    internal ChartSerializer() { }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Web.UI.DataVisualization.Charting.SerializationContents), "Default")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartSerializer_Content")]
    public System.Web.UI.DataVisualization.Charting.SerializationContents Content { get { return default(System.Web.UI.DataVisualization.Charting.SerializationContents); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Web.UI.DataVisualization.Charting.SerializationFormat), "Xml")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartSerializer_Format")]
    public System.Web.UI.DataVisualization.Charting.SerializationFormat Format { get { return default(System.Web.UI.DataVisualization.Charting.SerializationFormat); } set { } }
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartSerializer_ResetWhenLoading")]
    public bool IsResetWhenLoading { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartSerializer_TemplateMode")]
    public bool IsTemplateMode { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartSerializer_IgnoreUnknownXmlAttributes")]
    public bool IsUnknownAttributeIgnored { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartSerializer_NonSerializableContent")]
    public string NonSerializableContent { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeChartSerializer_SerializableContent")]
    public string SerializableContent { get { return default(string); } set { } }
    protected string GetContentString(System.Web.UI.DataVisualization.Charting.SerializationContents content, bool serializable) { return default(string); }
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
  public partial class CustomizeLegendEventArgs : System.EventArgs {
    public CustomizeLegendEventArgs(System.Web.UI.DataVisualization.Charting.LegendItemsCollection legendItems) { }
    public CustomizeLegendEventArgs(System.Web.UI.DataVisualization.Charting.LegendItemsCollection legendItems, string legendName) { }
    public System.Web.UI.DataVisualization.Charting.LegendItemsCollection LegendItems { get { return default(System.Web.UI.DataVisualization.Charting.LegendItemsCollection); } }
    public string LegendName { get { return default(string); } }
  }
  public partial class CustomizeMapAreasEventArgs : System.EventArgs {
    public CustomizeMapAreasEventArgs(System.Web.UI.DataVisualization.Charting.MapAreasCollection areaItems) { }
    public System.Web.UI.DataVisualization.Charting.MapAreasCollection MapAreaItems { get { return default(System.Web.UI.DataVisualization.Charting.MapAreasCollection); } }
  }
  [System.ComponentModel.DefaultPropertyAttribute("Text")]
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCustomLabel_CustomLabel")]
  public partial class CustomLabel : System.Web.UI.DataVisualization.Charting.ChartNamedElement, System.Web.UI.DataVisualization.Charting.IChartMapArea {
    public CustomLabel() { }
    public CustomLabel(double fromPosition, double toPosition, string text, int labelRow, System.Web.UI.DataVisualization.Charting.LabelMarkStyle markStyle) { }
    public CustomLabel(double fromPosition, double toPosition, string text, int labelRow, System.Web.UI.DataVisualization.Charting.LabelMarkStyle markStyle, System.Web.UI.DataVisualization.Charting.GridTickTypes gridTick) { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public System.Web.UI.DataVisualization.Charting.Axis Axis { get { return default(System.Web.UI.DataVisualization.Charting.Axis); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeForeColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color ForeColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.AxisLabelDateValueConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCustomLabel_From")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public double FromPosition { get { return default(double); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.GridTickTypes)(0))]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.FlagsEnumUITypeEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCustomLabel_GridTicks")]
    public System.Web.UI.DataVisualization.Charting.GridTickTypes GridTicks { get { return default(System.Web.UI.DataVisualization.Charting.GridTickTypes); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ImageValueEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCustomLabel_Image")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public string Image { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMapArea")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMapAreaAttributes")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public string ImageMapAreaAttributes { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMapArea")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributePostBackValue")]
    public string ImagePostBackValue { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeImageTransparentColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color ImageTransparentColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.UrlValueEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMapArea")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCustomLabel_ImageUrl")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public string ImageUrl { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.LabelMarkStyle)(0))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCustomLabel_LabelMark")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.LabelMarkStyle LabelMark { get { return default(System.Web.UI.DataVisualization.Charting.LabelMarkStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMapArea")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMapAreaAttributes")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public string MapAreaAttributes { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCustomLabel_MarkColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color MarkColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.DefaultValueAttribute("Custom LabelStyle")]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.DesignOnlyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCustomLabel_Name")]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public override string Name { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMapArea")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributePostBackValue")]
    public string PostBackValue { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCustomLabel_RowIndex")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public int RowIndex { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCustomLabel_Text")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public string Text { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMapArea")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeToolTip")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public string ToolTip { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.AxisLabelDateValueConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCustomLabel_To")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public double ToPosition { get { return default(double); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.UrlValueEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMapArea")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeUrl")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public string Url { get { return default(string); } set { } }
    public System.Web.UI.DataVisualization.Charting.CustomLabel Clone() { return default(System.Web.UI.DataVisualization.Charting.CustomLabel); }
  }
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCustomLabelsCollection_CustomLabelsCollection")]
  public partial class CustomLabelsCollection : System.Web.UI.DataVisualization.Charting.ChartElementCollection<System.Web.UI.DataVisualization.Charting.CustomLabel> {
    internal CustomLabelsCollection() { }
    public System.Web.UI.DataVisualization.Charting.CustomLabel Add(double fromPosition, double toPosition, string text) { return default(System.Web.UI.DataVisualization.Charting.CustomLabel); }
    public System.Web.UI.DataVisualization.Charting.CustomLabel Add(double fromPosition, double toPosition, string text, int rowIndex, System.Web.UI.DataVisualization.Charting.LabelMarkStyle markStyle) { return default(System.Web.UI.DataVisualization.Charting.CustomLabel); }
    public System.Web.UI.DataVisualization.Charting.CustomLabel Add(double fromPosition, double toPosition, string text, int rowIndex, System.Web.UI.DataVisualization.Charting.LabelMarkStyle markStyle, System.Web.UI.DataVisualization.Charting.GridTickTypes gridTick) { return default(System.Web.UI.DataVisualization.Charting.CustomLabel); }
    public void Add(double labelsStep, System.Web.UI.DataVisualization.Charting.DateTimeIntervalType intervalType) { }
    public void Add(double labelsStep, System.Web.UI.DataVisualization.Charting.DateTimeIntervalType intervalType, double min, double max, string format, int rowIndex, System.Web.UI.DataVisualization.Charting.LabelMarkStyle markStyle) { }
    public void Add(double labelsStep, System.Web.UI.DataVisualization.Charting.DateTimeIntervalType intervalType, string format) { }
    public void Add(double labelsStep, System.Web.UI.DataVisualization.Charting.DateTimeIntervalType intervalType, string format, int rowIndex, System.Web.UI.DataVisualization.Charting.LabelMarkStyle markStyle) { }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.CustomPropertiesTypeConverter))]
  public partial class CustomProperties {
    internal CustomProperties() { }
  }
  public partial class DataFormula {
    public DataFormula() { }
    public bool IsEmptyPointIgnored { get { return default(bool); } set { } }
    public bool IsStartFromFirst { get { return default(bool); } set { } }
    public System.Web.UI.DataVisualization.Charting.StatisticFormula Statistics { get { return default(System.Web.UI.DataVisualization.Charting.StatisticFormula); } }
    public void CopySeriesValues(string inputSeries, string outputSeries) { }
    public void FinancialFormula(System.Web.UI.DataVisualization.Charting.FinancialFormula formulaName, string inputSeries) { }
    public void FinancialFormula(System.Web.UI.DataVisualization.Charting.FinancialFormula formulaName, string inputSeries, string outputSeries) { }
    public void FinancialFormula(System.Web.UI.DataVisualization.Charting.FinancialFormula formulaName, string parameters, string inputSeries, string outputSeries) { }
    public void FinancialFormula(System.Web.UI.DataVisualization.Charting.FinancialFormula formulaName, string parameters, System.Web.UI.DataVisualization.Charting.Series inputSeries, System.Web.UI.DataVisualization.Charting.Series outputSeries) { }
    public void FinancialFormula(System.Web.UI.DataVisualization.Charting.FinancialFormula formulaName, System.Web.UI.DataVisualization.Charting.Series inputSeries) { }
    public void FinancialFormula(System.Web.UI.DataVisualization.Charting.FinancialFormula formulaName, System.Web.UI.DataVisualization.Charting.Series inputSeries, System.Web.UI.DataVisualization.Charting.Series outputSeries) { }
  }
  public partial class DataManipulator : System.Web.UI.DataVisualization.Charting.DataFormula {
    public DataManipulator() { }
    public bool FilterMatchedPoints { get { return default(bool); } set { } }
    public bool FilterSetEmptyPoints { get { return default(bool); } set { } }
    public System.Data.DataSet ExportSeriesValues() { return default(System.Data.DataSet); }
    public System.Data.DataSet ExportSeriesValues(string seriesNames) { return default(System.Data.DataSet); }
    public System.Data.DataSet ExportSeriesValues(System.Web.UI.DataVisualization.Charting.Series series) { return default(System.Data.DataSet); }
    public void Filter(System.Web.UI.DataVisualization.Charting.CompareMethod compareMethod, double compareValue, string inputSeriesNames) { }
    public void Filter(System.Web.UI.DataVisualization.Charting.CompareMethod compareMethod, double compareValue, string inputSeriesNames, string outputSeriesNames) { }
    public void Filter(System.Web.UI.DataVisualization.Charting.CompareMethod compareMethod, double compareValue, string inputSeriesNames, string outputSeriesNames, string usingValue) { }
    public void Filter(System.Web.UI.DataVisualization.Charting.CompareMethod compareMethod, double compareValue, System.Web.UI.DataVisualization.Charting.Series inputSeries) { }
    public void Filter(System.Web.UI.DataVisualization.Charting.CompareMethod compareMethod, double compareValue, System.Web.UI.DataVisualization.Charting.Series inputSeries, System.Web.UI.DataVisualization.Charting.Series outputSeries) { }
    public void Filter(System.Web.UI.DataVisualization.Charting.CompareMethod compareMethod, double compareValue, System.Web.UI.DataVisualization.Charting.Series inputSeries, System.Web.UI.DataVisualization.Charting.Series outputSeries, string usingValue) { }
    public void Filter(System.Web.UI.DataVisualization.Charting.DateRangeType dateRange, string rangeElements, string inputSeriesNames) { }
    public void Filter(System.Web.UI.DataVisualization.Charting.DateRangeType dateRange, string rangeElements, string inputSeriesNames, string outputSeriesNames) { }
    public void Filter(System.Web.UI.DataVisualization.Charting.DateRangeType dateRange, string rangeElements, System.Web.UI.DataVisualization.Charting.Series inputSeries) { }
    public void Filter(System.Web.UI.DataVisualization.Charting.DateRangeType dateRange, string rangeElements, System.Web.UI.DataVisualization.Charting.Series inputSeries, System.Web.UI.DataVisualization.Charting.Series outputSeries) { }
    public void Filter(System.Web.UI.DataVisualization.Charting.IDataPointFilter filterInterface, string inputSeriesNames) { }
    public void Filter(System.Web.UI.DataVisualization.Charting.IDataPointFilter filterInterface, string inputSeriesNames, string outputSeriesNames) { }
    public void Filter(System.Web.UI.DataVisualization.Charting.IDataPointFilter filterInterface, System.Web.UI.DataVisualization.Charting.Series inputSeries) { }
    public void Filter(System.Web.UI.DataVisualization.Charting.IDataPointFilter filterInterface, System.Web.UI.DataVisualization.Charting.Series inputSeries, System.Web.UI.DataVisualization.Charting.Series outputSeries) { }
    public void FilterTopN(int pointCount, string inputSeriesNames) { }
    public void FilterTopN(int pointCount, string inputSeriesNames, string outputSeriesNames) { }
    public void FilterTopN(int pointCount, string inputSeriesNames, string outputSeriesNames, string usingValue) { }
    public void FilterTopN(int pointCount, string inputSeriesNames, string outputSeriesNames, string usingValue, bool getTopValues) { }
    public void FilterTopN(int pointCount, System.Web.UI.DataVisualization.Charting.Series inputSeries) { }
    public void FilterTopN(int pointCount, System.Web.UI.DataVisualization.Charting.Series inputSeries, System.Web.UI.DataVisualization.Charting.Series outputSeries) { }
    public void FilterTopN(int pointCount, System.Web.UI.DataVisualization.Charting.Series inputSeries, System.Web.UI.DataVisualization.Charting.Series outputSeries, string usingValue) { }
    public void FilterTopN(int pointCount, System.Web.UI.DataVisualization.Charting.Series inputSeries, System.Web.UI.DataVisualization.Charting.Series outputSeries, string usingValue, bool getTopValues) { }
    public void Group(string formula, double interval, System.Web.UI.DataVisualization.Charting.IntervalType intervalType, double intervalOffset, System.Web.UI.DataVisualization.Charting.IntervalType intervalOffsetType, string inputSeriesName) { }
    public void Group(string formula, double interval, System.Web.UI.DataVisualization.Charting.IntervalType intervalType, double intervalOffset, System.Web.UI.DataVisualization.Charting.IntervalType intervalOffsetType, string inputSeriesName, string outputSeriesName) { }
    public void Group(string formula, double interval, System.Web.UI.DataVisualization.Charting.IntervalType intervalType, double intervalOffset, System.Web.UI.DataVisualization.Charting.IntervalType intervalOffsetType, System.Web.UI.DataVisualization.Charting.Series inputSeries) { }
    public void Group(string formula, double interval, System.Web.UI.DataVisualization.Charting.IntervalType intervalType, double intervalOffset, System.Web.UI.DataVisualization.Charting.IntervalType intervalOffsetType, System.Web.UI.DataVisualization.Charting.Series inputSeries, System.Web.UI.DataVisualization.Charting.Series outputSeries) { }
    public void Group(string formula, double interval, System.Web.UI.DataVisualization.Charting.IntervalType intervalType, string inputSeriesName) { }
    public void Group(string formula, double interval, System.Web.UI.DataVisualization.Charting.IntervalType intervalType, string inputSeriesName, string outputSeriesName) { }
    public void Group(string formula, double interval, System.Web.UI.DataVisualization.Charting.IntervalType intervalType, System.Web.UI.DataVisualization.Charting.Series inputSeries) { }
    public void Group(string formula, double interval, System.Web.UI.DataVisualization.Charting.IntervalType intervalType, System.Web.UI.DataVisualization.Charting.Series inputSeries, System.Web.UI.DataVisualization.Charting.Series outputSeries) { }
    public void GroupByAxisLabel(string formula, string inputSeriesName) { }
    public void GroupByAxisLabel(string formula, string inputSeriesName, string outputSeriesName) { }
    public void GroupByAxisLabel(string formula, System.Web.UI.DataVisualization.Charting.Series inputSeries) { }
    public void GroupByAxisLabel(string formula, System.Web.UI.DataVisualization.Charting.Series inputSeries, System.Web.UI.DataVisualization.Charting.Series outputSeries) { }
    public void InsertEmptyPoints(double interval, System.Web.UI.DataVisualization.Charting.IntervalType intervalType, double intervalOffset, System.Web.UI.DataVisualization.Charting.IntervalType intervalOffsetType, double fromXValue, double toXValue, string seriesName) { }
    public void InsertEmptyPoints(double interval, System.Web.UI.DataVisualization.Charting.IntervalType intervalType, double intervalOffset, System.Web.UI.DataVisualization.Charting.IntervalType intervalOffsetType, double fromXValue, double toXValue, System.Web.UI.DataVisualization.Charting.Series series) { }
    public void InsertEmptyPoints(double interval, System.Web.UI.DataVisualization.Charting.IntervalType intervalType, double intervalOffset, System.Web.UI.DataVisualization.Charting.IntervalType intervalOffsetType, string seriesName) { }
    public void InsertEmptyPoints(double interval, System.Web.UI.DataVisualization.Charting.IntervalType intervalType, double intervalOffset, System.Web.UI.DataVisualization.Charting.IntervalType intervalOffsetType, System.Web.UI.DataVisualization.Charting.Series series) { }
    public void InsertEmptyPoints(double interval, System.Web.UI.DataVisualization.Charting.IntervalType intervalType, string seriesName) { }
    public void InsertEmptyPoints(double interval, System.Web.UI.DataVisualization.Charting.IntervalType intervalType, System.Web.UI.DataVisualization.Charting.Series series) { }
    public void Sort(System.Collections.Generic.IComparer<System.Web.UI.DataVisualization.Charting.DataPoint> comparer, string seriesName) { }
    public void Sort(System.Collections.Generic.IComparer<System.Web.UI.DataVisualization.Charting.DataPoint> comparer, System.Web.UI.DataVisualization.Charting.Series series) { }
    public void Sort(System.Web.UI.DataVisualization.Charting.PointSortOrder pointSortOrder, string seriesName) { }
    public void Sort(System.Web.UI.DataVisualization.Charting.PointSortOrder pointSortOrder, string sortBy, string seriesName) { }
    public void Sort(System.Web.UI.DataVisualization.Charting.PointSortOrder pointSortOrder, string sortBy, System.Web.UI.DataVisualization.Charting.Series series) { }
    public void Sort(System.Web.UI.DataVisualization.Charting.PointSortOrder pointSortOrder, System.Web.UI.DataVisualization.Charting.Series series) { }
  }
  [System.ComponentModel.DefaultPropertyAttribute("YValues")]
  [System.ComponentModel.TypeConverterAttribute("System.Web.UI.Design.DataVisualization.Charting.DataPointConverter, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeDataPoint_DataPoint")]
  [System.Web.UI.ThemeableAttribute(false)]
  public partial class DataPoint : System.Web.UI.DataVisualization.Charting.DataPointCustomProperties {
    public DataPoint() { }
    public DataPoint(double xValue, double yValue) { }
    public DataPoint(double xValue, System.Double[] yValues) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public DataPoint(double xValue, string yValues) { }
    public DataPoint(System.Web.UI.DataVisualization.Charting.Series series) { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeData")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeDataPoint_Empty")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public bool IsEmpty { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeData")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeDataPoint_Name")]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public override string Name { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(double), "0.0")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.DataPointValueConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeData")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeDataPoint_XValue")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public double XValue { get { return default(double); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.EditorAttribute(typeof(System.Drawing.Design.UITypeEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.DoubleArrayConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeData")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeDataPoint_YValues")]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(1))]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Double[] YValues { get { return default(System.Double[]); } set { } }
    public System.Web.UI.DataVisualization.Charting.DataPoint Clone() { return default(System.Web.UI.DataVisualization.Charting.DataPoint); }
    public double GetValueByName(string valueName) { return default(double); }
    public void SetValueXY(object xValue, params System.Object[] yValue) { }
    public void SetValueY(params System.Object[] yValue) { }
  }
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeDataPointCollection_DataPointCollection")]
  [System.Web.UI.ThemeableAttribute(false)]
  public partial class DataPointCollection : System.Web.UI.DataVisualization.Charting.ChartElementCollection<System.Web.UI.DataVisualization.Charting.DataPoint> {
    internal DataPointCollection() { }
    public System.Web.UI.DataVisualization.Charting.DataPoint Add(params System.Double[] y) { return default(System.Web.UI.DataVisualization.Charting.DataPoint); }
    public int AddXY(double xValue, double yValue) { return default(int); }
    public int AddXY(object xValue, params System.Object[] yValue) { return default(int); }
    public int AddY(double yValue) { return default(int); }
    public int AddY(params System.Object[] yValue) { return default(int); }
    public void DataBind(System.Collections.IEnumerable dataSource, string xField, string yFields, string otherFields) { }
    public void DataBindXY(System.Collections.IEnumerable xValue, params System.Collections.IEnumerable[] yValues) { }
    public void DataBindXY(System.Collections.IEnumerable xValue, string xField, System.Collections.IEnumerable yValue, string yFields) { }
    public void DataBindY(System.Collections.IEnumerable yValue, string yFields) { }
    public void DataBindY(params System.Collections.IEnumerable[] yValue) { }
    public System.Collections.Generic.IEnumerable<System.Web.UI.DataVisualization.Charting.DataPoint> FindAllByValue(double valueToFind) { return default(System.Collections.Generic.IEnumerable<System.Web.UI.DataVisualization.Charting.DataPoint>); }
    [System.Runtime.CompilerServices.IteratorStateMachineAttribute(typeof(System.Web.UI.DataVisualization.Charting.DataPointCollection.<FindAllByValue>d__23))]
    public System.Collections.Generic.IEnumerable<System.Web.UI.DataVisualization.Charting.DataPoint> FindAllByValue(double valueToFind, string useValue) { return default(System.Collections.Generic.IEnumerable<System.Web.UI.DataVisualization.Charting.DataPoint>); }
    [System.Runtime.CompilerServices.IteratorStateMachineAttribute(typeof(System.Web.UI.DataVisualization.Charting.DataPointCollection.<FindAllByValue>d__22))]
    public System.Collections.Generic.IEnumerable<System.Web.UI.DataVisualization.Charting.DataPoint> FindAllByValue(double valueToFind, string useValue, int startIndex) { return default(System.Collections.Generic.IEnumerable<System.Web.UI.DataVisualization.Charting.DataPoint>); }
    public System.Web.UI.DataVisualization.Charting.DataPoint FindByValue(double valueToFind) { return default(System.Web.UI.DataVisualization.Charting.DataPoint); }
    public System.Web.UI.DataVisualization.Charting.DataPoint FindByValue(double valueToFind, string useValue) { return default(System.Web.UI.DataVisualization.Charting.DataPoint); }
    public System.Web.UI.DataVisualization.Charting.DataPoint FindByValue(double valueToFind, string useValue, int startIndex) { return default(System.Web.UI.DataVisualization.Charting.DataPoint); }
    public System.Web.UI.DataVisualization.Charting.DataPoint FindMaxByValue() { return default(System.Web.UI.DataVisualization.Charting.DataPoint); }
    public System.Web.UI.DataVisualization.Charting.DataPoint FindMaxByValue(string useValue) { return default(System.Web.UI.DataVisualization.Charting.DataPoint); }
    public System.Web.UI.DataVisualization.Charting.DataPoint FindMaxByValue(string useValue, int startIndex) { return default(System.Web.UI.DataVisualization.Charting.DataPoint); }
    public System.Web.UI.DataVisualization.Charting.DataPoint FindMinByValue() { return default(System.Web.UI.DataVisualization.Charting.DataPoint); }
    public System.Web.UI.DataVisualization.Charting.DataPoint FindMinByValue(string useValue) { return default(System.Web.UI.DataVisualization.Charting.DataPoint); }
    public System.Web.UI.DataVisualization.Charting.DataPoint FindMinByValue(string useValue, int startIndex) { return default(System.Web.UI.DataVisualization.Charting.DataPoint); }
    public void InsertXY(int index, object xValue, params System.Object[] yValue) { }
    public void InsertY(int index, params System.Object[] yValue) { }
  }
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeDataPointComparer_DataPointComparer")]
  public partial class DataPointComparer : System.Collections.Generic.IComparer<System.Web.UI.DataVisualization.Charting.DataPoint> {
    public DataPointComparer(System.Web.UI.DataVisualization.Charting.Series series, System.Web.UI.DataVisualization.Charting.PointSortOrder sortOrder, string sortBy) { }
    public int Compare(System.Web.UI.DataVisualization.Charting.DataPoint x, System.Web.UI.DataVisualization.Charting.DataPoint y) { return default(int); }
  }
  [System.ComponentModel.DefaultPropertyAttribute("LabelStyle")]
  [System.ComponentModel.TypeConverterAttribute("System.Web.UI.Design.DataVisualization.Charting.DataPointCustomPropertiesConverter, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeDataPointCustomProperties_DataPointCustomProperties")]
  public partial class DataPointCustomProperties : System.Web.UI.DataVisualization.Charting.ChartNamedElement, System.Web.UI.DataVisualization.Charting.IChartMapArea {
    public DataPointCustomProperties() { }
    public DataPointCustomProperties(System.Web.UI.DataVisualization.Charting.Series series, bool pointProperties) { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.KeywordsStringEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxisLabel")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public virtual string AxisLabel { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.GradientEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackGradientStyle")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.GradientStyle BackGradientStyle { get { return default(System.Web.UI.DataVisualization.Charting.GradientStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.HatchStyleEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackHatchStyle")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { get { return default(System.Web.UI.DataVisualization.Charting.ChartHatchStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ImageValueEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackImage")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public string BackImage { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackImageAlign")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.ChartImageAlignmentStyle BackImageAlignment { get { return default(System.Web.UI.DataVisualization.Charting.ChartImageAlignmentStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeImageTransparentColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color BackImageTransparentColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeImageWrapMode")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.ChartImageWrapMode BackImageWrapMode { get { return default(System.Web.UI.DataVisualization.Charting.ChartImageWrapMode); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackSecondaryColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color BackSecondaryColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color BorderColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderDashStyle")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.ChartDashStyle BorderDashStyle { get { return default(System.Web.UI.DataVisualization.Charting.ChartDashStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderWidth")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public int BorderWidth { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeColor4")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color Color { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCustomAttributesExtended")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public string CustomProperties { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.DesignOnlyAttribute(true)]
    [System.ComponentModel.DisplayNameAttribute("CustomProperties")]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCustomAttributesExtended")]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public System.Web.UI.DataVisualization.Charting.CustomProperties CustomPropertiesExtended { get { return default(System.Web.UI.DataVisualization.Charting.CustomProperties); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLabelAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeFont")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Font Font { get { return default(System.Drawing.Font); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLabel")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeShowLabelAsValue")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public bool IsValueShownAsLabel { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLegend")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeShowInLegend")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public bool IsVisibleInLegend { get { return default(bool); } set { } }
    public string this[int index] { get { return default(string); } }
    public string this[string name] { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.KeywordsStringEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLabel")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLabel")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public virtual string Label { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLabelAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLabel_FontAngle")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public int LabelAngle { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLabelAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLabelBackColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color LabelBackColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLabelAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color LabelBorderColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ChartDashStyle)(5))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLabelAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLabelBorderDashStyle")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.ChartDashStyle LabelBorderDashStyle { get { return default(System.Web.UI.DataVisualization.Charting.ChartDashStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(1)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLabelAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderWidth")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public int LabelBorderWidth { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLabelAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeFontColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color LabelForeColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLabel")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLabelFormat")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public string LabelFormat { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLabel")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMapAreaAttributes")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public string LabelMapAreaAttributes { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.KeywordsStringEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLabel")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributePostBackValue")]
    public string LabelPostBackValue { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.KeywordsStringEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLabel")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLabelToolTip")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public string LabelToolTip { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.UrlValueEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMapArea")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeUrl")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public string LabelUrl { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.KeywordsStringEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLegend")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMapAreaAttributes")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public string LegendMapAreaAttributes { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.KeywordsStringEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLegend")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributePostBackValue")]
    public string LegendPostBackValue { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.KeywordsStringEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLegend")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendText")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public string LegendText { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.KeywordsStringEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLegend")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendToolTip")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public string LegendToolTip { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.UrlValueEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLegend")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendUrl")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public string LegendUrl { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.KeywordsStringEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMapArea")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMapAreaAttributes")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public string MapAreaAttributes { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMarker")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMarkerBorderColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color MarkerBorderColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMarker")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMarkerBorderWidth")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public int MarkerBorderWidth { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMarker")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMarkerColor3")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color MarkerColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ImageValueEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMarker")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMarkerImage")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public string MarkerImage { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMarker")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeImageTransparentColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color MarkerImageTransparentColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMarker")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMarkerSize")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public int MarkerSize { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.MarkerStyleEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMarker")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMarkerStyle4")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.MarkerStyle MarkerStyle { get { return default(System.Web.UI.DataVisualization.Charting.MarkerStyle); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.KeywordsStringEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMapArea")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributePostBackValue")]
    public string PostBackValue { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.KeywordsStringEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMapArea")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeToolTip")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public string ToolTip { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.UrlValueEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMapArea")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeUrl")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public string Url { get { return default(string); } set { } }
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
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeElementPosition_ElementPosition")]
  public partial class ElementPosition : System.Web.UI.DataVisualization.Charting.ChartElement {
    public ElementPosition() { }
    public ElementPosition(float x, float y, float width, float height) { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeElementPosition_Auto")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public bool Auto { get { return default(bool); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public float Bottom { get { return default(float); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0f)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeElementPosition_Height")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public float Height { get { return default(float); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public float Right { get { return default(float); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public System.Drawing.SizeF Size { get { return default(System.Drawing.SizeF); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0f)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeElementPosition_Width")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public float Width { get { return default(float); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0f)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeElementPosition_X")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public float X { get { return default(float); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0f)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeElementPosition_Y")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public float Y { get { return default(float); } set { } }
    public void FromRectangleF(System.Drawing.RectangleF rect) { }
    public System.Drawing.RectangleF ToRectangleF() { return default(System.Drawing.RectangleF); }
  }
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeEllipseAnnotation_EllipseAnnotation")]
  public partial class EllipseAnnotation : System.Web.UI.DataVisualization.Charting.RectangleAnnotation {
    public EllipseAnnotation() { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationType")]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
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
    public System.Web.UI.DataVisualization.Charting.ChartElementType ElementType { get { return default(System.Web.UI.DataVisualization.Charting.ChartElementType); } }
    public string Format { get { return default(string); } }
    public string LocalizedValue { get { return default(string); } set { } }
    public object SenderTag { get { return default(object); } }
    public double Value { get { return default(double); } }
    public System.Web.UI.DataVisualization.Charting.ChartValueType ValueType { get { return default(System.Web.UI.DataVisualization.Charting.ChartValueType); } }
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
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeGrid_Grid")]
  public partial class Grid {
    public Grid() { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeEnabled5")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public bool Enabled { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.AxisElementIntervalValueConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeData")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeInterval6")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public double Interval { get { return default(double); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.AxisElementIntervalValueConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeData")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeIntervalOffset3")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public double IntervalOffset { get { return default(double); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeData")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeIntervalOffsetType6")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.DateTimeIntervalType IntervalOffsetType { get { return default(System.Web.UI.DataVisualization.Charting.DateTimeIntervalType); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeData")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeIntervalType3")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.DateTimeIntervalType IntervalType { get { return default(System.Web.UI.DataVisualization.Charting.DateTimeIntervalType); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color LineColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ChartDashStyle)(5))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineDashStyle")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.ChartDashStyle LineDashStyle { get { return default(System.Web.UI.DataVisualization.Charting.ChartDashStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(1)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineWidth")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
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
    public System.Web.UI.DataVisualization.Charting.Axis Axis { get { return default(System.Web.UI.DataVisualization.Charting.Axis); } set { } }
    public System.Web.UI.DataVisualization.Charting.ChartArea ChartArea { get { return default(System.Web.UI.DataVisualization.Charting.ChartArea); } set { } }
    public System.Web.UI.DataVisualization.Charting.ChartElementType ChartElementType { get { return default(System.Web.UI.DataVisualization.Charting.ChartElementType); } set { } }
    public object Object { get { return default(object); } set { } }
    public int PointIndex { get { return default(int); } set { } }
    public System.Web.UI.DataVisualization.Charting.Series Series { get { return default(System.Web.UI.DataVisualization.Charting.Series); } set { } }
    public object SubObject { get { return default(object); } set { } }
  }
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeHorizontalLineAnnotation_HorizontalLineAnnotation")]
  public partial class HorizontalLineAnnotation : System.Web.UI.DataVisualization.Charting.LineAnnotation {
    public HorizontalLineAnnotation() { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationType")]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public override string AnnotationType { get { return default(string); } }
  }
  public partial interface IChartMapArea {
    string MapAreaAttributes { get; set; }
    string PostBackValue { get; set; }
    object Tag { get; set; }
    string ToolTip { get; set; }
    string Url { get; set; }
  }
  public partial interface IChartStorageHandler {
    void Delete(string key);
    bool Exists(string key);
    System.Byte[] Load(string key);
    void Save(string key, System.Byte[] data);
  }
  public partial interface IDataPointFilter {
    bool FilterDataPoint(System.Web.UI.DataVisualization.Charting.DataPoint point, System.Web.UI.DataVisualization.Charting.Series series, int pointIndex);
  }
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeImageAnnotation_ImageAnnotation")]
  public partial class ImageAnnotation : System.Web.UI.DataVisualization.Charting.Annotation {
    public ImageAnnotation() { }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.ContentAlignment), "MiddleCenter")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeImage")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeImageAnnotation_Alignment")]
    public override System.Drawing.ContentAlignment Alignment { get { return default(System.Drawing.ContentAlignment); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationType")]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public override string AnnotationType { get { return default(string); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    public override System.Drawing.Color BackColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.GradientStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.GradientEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    public override System.Web.UI.DataVisualization.Charting.GradientStyle BackGradientStyle { get { return default(System.Web.UI.DataVisualization.Charting.GradientStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ChartHatchStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.HatchStyleEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    public override System.Web.UI.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { get { return default(System.Web.UI.DataVisualization.Charting.ChartHatchStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    public override System.Drawing.Color BackSecondaryColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Font), "Microsoft Sans Serif, 8pt")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    public override System.Drawing.Font Font { get { return default(System.Drawing.Font); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    public override System.Drawing.Color ForeColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ImageValueEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeImage")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeImageAnnotation_Image")]
    public virtual string Image { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeImage")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeImageTransparentColor")]
    public System.Drawing.Color ImageTransparentColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ChartImageWrapMode)(4))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeImage")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeImageWrapMode")]
    public System.Web.UI.DataVisualization.Charting.ChartImageWrapMode ImageWrapMode { get { return default(System.Web.UI.DataVisualization.Charting.ChartImageWrapMode); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    public override System.Drawing.Color LineColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ChartDashStyle)(5))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineDashStyle")]
    public override System.Web.UI.DataVisualization.Charting.ChartDashStyle LineDashStyle { get { return default(System.Web.UI.DataVisualization.Charting.ChartDashStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(1)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineWidth")]
    public override int LineWidth { get { return default(int); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override System.Web.UI.DataVisualization.Charting.TextStyle TextStyle { get { return default(System.Web.UI.DataVisualization.Charting.TextStyle); } set { } }
  }
  public enum ImageStorageMode {
    UseHttpHandler = 0,
    UseImageLocation = 1,
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
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLabelCalloutStyle_LabelCalloutStyle")]
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
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLabelOutsidePlotAreaStyle_LabelOutsidePlotAreaStyle")]
  public enum LabelOutsidePlotAreaStyle {
    No = 1,
    Partial = 2,
    Yes = 0,
  }
  [System.ComponentModel.DefaultPropertyAttribute("Enabled")]
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLabel_Label")]
  public partial class LabelStyle : System.Web.UI.DataVisualization.Charting.ChartElement {
    public LabelStyle() { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLabel_FontAngle")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public int Angle { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLabel_Enabled")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public bool Enabled { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Font), "Microsoft Sans Serif, 8pt")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLabel_Font")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Font Font { get { return default(System.Drawing.Font); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeFontColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color ForeColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLabel_Format")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public string Format { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0.0 / 0.0)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.AxisElementIntervalValueConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeData")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLabel_Interval")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public double Interval { get { return default(double); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0.0 / 0.0)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.AxisElementIntervalValueConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeData")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLabel_IntervalOffset")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public double IntervalOffset { get { return default(double); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.DateTimeIntervalType)(10))]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeData")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLabel_IntervalOffsetType")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.DateTimeIntervalType IntervalOffsetType { get { return default(System.Web.UI.DataVisualization.Charting.DateTimeIntervalType); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.DateTimeIntervalType)(10))]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeData")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLabel_IntervalType")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.DateTimeIntervalType IntervalType { get { return default(System.Web.UI.DataVisualization.Charting.DateTimeIntervalType); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLabel_ShowEndLabels")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public bool IsEndLabelVisible { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLabel_OffsetLabels")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public bool IsStaggered { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLabel_TruncatedLabels")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public bool TruncatedLabels { get { return default(bool); } set { } }
    protected override void Dispose(bool disposing) { }
  }
  [System.ComponentModel.DefaultPropertyAttribute("Enabled")]
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_Legend")]
  public partial class Legend : System.Web.UI.DataVisualization.Charting.ChartNamedElement {
    public Legend() { }
    public Legend(string name) { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Drawing.StringAlignment)(0))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeDocking")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_Alignment")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.StringAlignment Alignment { get { return default(System.Drawing.StringAlignment); } set { } }
    [System.ComponentModel.DefaultValueAttribute(7)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_AutoFitMinFontSize")]
    public int AutoFitMinFontSize { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color BackColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.GradientStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.GradientEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackGradientStyle")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.GradientStyle BackGradientStyle { get { return default(System.Web.UI.DataVisualization.Charting.GradientStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ChartHatchStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.HatchStyleEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackHatchStyle")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { get { return default(System.Web.UI.DataVisualization.Charting.ChartHatchStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ImageValueEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackImage")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public string BackImage { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ChartImageAlignmentStyle)(0))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackImageAlign")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.ChartImageAlignmentStyle BackImageAlignment { get { return default(System.Web.UI.DataVisualization.Charting.ChartImageAlignmentStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeImageTransparentColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color BackImageTransparentColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ChartImageWrapMode)(0))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeImageWrapMode")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.ChartImageWrapMode BackImageWrapMode { get { return default(System.Web.UI.DataVisualization.Charting.ChartImageWrapMode); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackSecondaryColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color BackSecondaryColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color BorderColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ChartDashStyle)(5))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderDashStyle")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.ChartDashStyle BorderDashStyle { get { return default(System.Web.UI.DataVisualization.Charting.ChartDashStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(1)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderWidth")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public int BorderWidth { get { return default(int); } set { } }
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.LegendCellColumnCollectionEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeCellColumns")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_CellColumns")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    public System.Web.UI.DataVisualization.Charting.LegendCellColumnCollection CellColumns { get { return default(System.Web.UI.DataVisualization.Charting.LegendCellColumnCollection); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.LegendItemCollectionEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_CustomItems")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    public System.Web.UI.DataVisualization.Charting.LegendItemsCollection CustomItems { get { return default(System.Web.UI.DataVisualization.Charting.LegendItemsCollection); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("NotSet")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.LegendAreaNameConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeDocking")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_DockToChartArea")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public string DockedToChartArea { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.Docking)(1))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeDocking")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_Docking")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.Docking Docking { get { return default(System.Web.UI.DataVisualization.Charting.Docking); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.ParenthesizePropertyNameAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_Enabled")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public bool Enabled { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Font), "Microsoft Sans Serif, 8pt")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_Font")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Font Font { get { return default(System.Drawing.Font); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendFontColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color ForeColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Web.UI.DataVisualization.Charting.LegendSeparatorStyle), "None")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeCellColumns")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_HeaderSeparator")]
    public System.Web.UI.DataVisualization.Charting.LegendSeparatorStyle HeaderSeparator { get { return default(System.Web.UI.DataVisualization.Charting.LegendSeparatorStyle); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeCellColumns")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_HeaderSeparatorColor")]
    public System.Drawing.Color HeaderSeparatorColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute("NotSet")]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.LegendAreaNameConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_InsideChartArea")]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public string InsideChartArea { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_InterlacedRows")]
    public bool InterlacedRows { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_InterlacedRowsColor")]
    public System.Drawing.Color InterlacedRowsColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeDocking")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_DockInsideChartArea")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public bool IsDockedInsideChartArea { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_EquallySpacedItems")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public bool IsEquallySpacedItems { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_AutoFitText")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public bool IsTextAutoFit { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Web.UI.DataVisualization.Charting.LegendSeparatorStyle), "None")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeCellColumns")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_ItemColumnSeparator")]
    public System.Web.UI.DataVisualization.Charting.LegendSeparatorStyle ItemColumnSeparator { get { return default(System.Web.UI.DataVisualization.Charting.LegendSeparatorStyle); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeCellColumns")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_ItemColumnSeparatorColor")]
    public System.Drawing.Color ItemColumnSeparatorColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.DefaultValueAttribute(50)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeCellColumns")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_ItemColumnSpacing")]
    public int ItemColumnSpacing { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.LegendItemOrder)(0))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_Reversed")]
    public System.Web.UI.DataVisualization.Charting.LegendItemOrder LegendItemOrder { get { return default(System.Web.UI.DataVisualization.Charting.LegendItemOrder); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.LegendStyle)(2))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.ParenthesizePropertyNameAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_LegendStyle")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.LegendStyle LegendStyle { get { return default(System.Web.UI.DataVisualization.Charting.LegendStyle); } set { } }
    [System.ComponentModel.DefaultValueAttribute(50f)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeDocking")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_MaxAutoSize")]
    public float MaximumAutoSize { get { return default(float); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_Name")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public override string Name { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.ElementPositionConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_Position")]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(2))]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    public System.Web.UI.DataVisualization.Charting.ElementPosition Position { get { return default(System.Web.UI.DataVisualization.Charting.ElementPosition); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "128, 0, 0, 0")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeShadowColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color ShadowColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeShadowOffset")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public int ShadowOffset { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.LegendTableStyle)(0))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.ParenthesizePropertyNameAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_TableStyle")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.LegendTableStyle TableStyle { get { return default(System.Web.UI.DataVisualization.Charting.LegendTableStyle); } set { } }
    [System.ComponentModel.DefaultValueAttribute(25)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_TextWrapThreshold")]
    public int TextWrapThreshold { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeTitle")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_Title")]
    public string Title { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.StringAlignment), "Center")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeTitle")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_TitleAlignment")]
    public System.Drawing.StringAlignment TitleAlignment { get { return default(System.Drawing.StringAlignment); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeTitle")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTitleBackColor")]
    public System.Drawing.Color TitleBackColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Font), "Microsoft Sans Serif, 8pt, style=Bold")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeTitle")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTitleFont")]
    public System.Drawing.Font TitleFont { get { return default(System.Drawing.Font); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeTitle")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_TitleColor")]
    public System.Drawing.Color TitleForeColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Web.UI.DataVisualization.Charting.LegendSeparatorStyle), "None")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeTitle")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_TitleSeparator")]
    public System.Web.UI.DataVisualization.Charting.LegendSeparatorStyle TitleSeparator { get { return default(System.Web.UI.DataVisualization.Charting.LegendSeparatorStyle); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeTitle")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegend_TitleSeparatorColor")]
    public System.Drawing.Color TitleSeparatorColor { get { return default(System.Drawing.Color); } set { } }
    protected override void Dispose(bool disposing) { }
  }
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCell_LegendCell")]
  public partial class LegendCell : System.Web.UI.DataVisualization.Charting.ChartNamedElement, System.Web.UI.DataVisualization.Charting.IChartMapArea {
    public LegendCell() { }
    public LegendCell(string text) { }
    public LegendCell(System.Web.UI.DataVisualization.Charting.LegendCellType cellType, string text) { }
    public LegendCell(System.Web.UI.DataVisualization.Charting.LegendCellType cellType, string text, System.Drawing.ContentAlignment alignment) { }
    [System.ComponentModel.DefaultValueAttribute((System.Drawing.ContentAlignment)(32))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLayout")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCell_Alignment")]
    public virtual System.Drawing.ContentAlignment Alignment { get { return default(System.Drawing.ContentAlignment); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackColor")]
    public virtual System.Drawing.Color BackColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.DefaultValueAttribute(1)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLayout")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCell_CellSpan")]
    public virtual int CellSpan { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.LegendCellType)(0))]
    [System.ComponentModel.ParenthesizePropertyNameAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCell_CellType")]
    public virtual System.Web.UI.DataVisualization.Charting.LegendCellType CellType { get { return default(System.Web.UI.DataVisualization.Charting.LegendCellType); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCell_Font")]
    public virtual System.Drawing.Font Font { get { return default(System.Drawing.Font); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeForeColor")]
    public virtual System.Drawing.Color ForeColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ImageValueEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCell_Image")]
    public virtual string Image { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Size), "0, 0")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.SizeEmptyValueConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLayout")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCell_ImageSize")]
    public virtual System.Drawing.Size ImageSize { get { return default(System.Drawing.Size); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeImageTransparentColor")]
    public virtual System.Drawing.Color ImageTransparentColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public virtual System.Web.UI.DataVisualization.Charting.Legend Legend { get { return default(System.Web.UI.DataVisualization.Charting.Legend); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public virtual System.Web.UI.DataVisualization.Charting.LegendItem LegendItem { get { return default(System.Web.UI.DataVisualization.Charting.LegendItem); } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMapArea")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMapAreaAttributes")]
    public virtual string MapAreaAttributes { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Web.UI.DataVisualization.Charting.Margins), "0,0,15,15")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLayout")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCell_Margins")]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(1))]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    public virtual System.Web.UI.DataVisualization.Charting.Margins Margins { get { return default(System.Web.UI.DataVisualization.Charting.Margins); } set { } }
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCell_Name")]
    public override string Name { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMapArea")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributePostBackValue")]
    public string PostBackValue { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Size), "200, 70")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLayout")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCell_SeriesSymbolSize")]
    public virtual System.Drawing.Size SeriesSymbolSize { get { return default(System.Drawing.Size); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCell_Text")]
    public virtual string Text { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMapArea")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeToolTip")]
    public virtual string ToolTip { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.UrlValueEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMapArea")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeUrl")]
    public virtual string Url { get { return default(string); } set { } }
    protected override void Dispose(bool disposing) { }
  }
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCellCollection_LegendCellCollection")]
  public partial class LegendCellCollection : System.Web.UI.DataVisualization.Charting.ChartNamedElementCollection<System.Web.UI.DataVisualization.Charting.LegendCell> {
    internal LegendCellCollection() { }
    public int Add(System.Web.UI.DataVisualization.Charting.LegendCellType cellType, string text, System.Drawing.ContentAlignment alignment) { return default(int); }
    public void Insert(int index, System.Web.UI.DataVisualization.Charting.LegendCellType cellType, string text, System.Drawing.ContentAlignment alignment) { }
  }
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCellColumn_LegendCellColumn")]
  public partial class LegendCellColumn : System.Web.UI.DataVisualization.Charting.ChartNamedElement, System.Web.UI.DataVisualization.Charting.IChartMapArea {
    public LegendCellColumn() { }
    public LegendCellColumn(string headerText, System.Web.UI.DataVisualization.Charting.LegendCellColumnType columnType, string text) { }
    public LegendCellColumn(string headerText, System.Web.UI.DataVisualization.Charting.LegendCellColumnType columnType, string text, System.Drawing.ContentAlignment alignment) { }
    [System.ComponentModel.DefaultValueAttribute((System.Drawing.ContentAlignment)(32))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeSeriesItems")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCellColumn_Alignment")]
    public virtual System.Drawing.ContentAlignment Alignment { get { return default(System.Drawing.ContentAlignment); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeSeriesItems")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackColor")]
    public virtual System.Drawing.Color BackColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.LegendCellColumnType)(0))]
    [System.ComponentModel.ParenthesizePropertyNameAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeSeriesItems")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCellColumn_ColumnType")]
    public virtual System.Web.UI.DataVisualization.Charting.LegendCellColumnType ColumnType { get { return default(System.Web.UI.DataVisualization.Charting.LegendCellColumnType); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeSeriesItems")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCellColumn_Font")]
    public virtual System.Drawing.Font Font { get { return default(System.Drawing.Font); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeSeriesItems")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeForeColor")]
    public virtual System.Drawing.Color ForeColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.StringAlignment), "Center")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeHeader")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCellColumn_HeaderTextAlignment")]
    public System.Drawing.StringAlignment HeaderAlignment { get { return default(System.Drawing.StringAlignment); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeHeader")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeHeaderBackColor")]
    public virtual System.Drawing.Color HeaderBackColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Font), "Microsoft Sans Serif, 8pt, style=Bold")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeHeader")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCellColumn_HeaderFont")]
    public virtual System.Drawing.Font HeaderFont { get { return default(System.Drawing.Font); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeHeader")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCellColumn_HeaderColor")]
    public virtual System.Drawing.Color HeaderForeColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeHeader")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCellColumn_HeaderText")]
    public virtual string HeaderText { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public virtual System.Web.UI.DataVisualization.Charting.Legend Legend { get { return default(System.Web.UI.DataVisualization.Charting.Legend); } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.KeywordsStringEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeSeriesItems")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMapAreaAttributes")]
    public virtual string MapAreaAttributes { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Web.UI.DataVisualization.Charting.Margins), "0,0,15,15")]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeSeriesItems")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCellColumn_Margins")]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(1))]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    public virtual System.Web.UI.DataVisualization.Charting.Margins Margins { get { return default(System.Web.UI.DataVisualization.Charting.Margins); } set { } }
    [System.ComponentModel.DefaultValueAttribute(-1)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.IntNanValueConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeSize")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCellColumn_MaximumWidth")]
    public virtual int MaximumWidth { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute(-1)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.IntNanValueConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeSize")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCellColumn_MinimumWidth")]
    public virtual int MinimumWidth { get { return default(int); } set { } }
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCellColumn_Name")]
    public override string Name { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeSeriesItems")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributePostBackValue")]
    public string PostBackValue { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Size), "200, 70")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeSeriesItems")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCellColumn_SeriesSymbolSize")]
    public virtual System.Drawing.Size SeriesSymbolSize { get { return default(System.Drawing.Size); } set { } }
    [System.ComponentModel.DefaultValueAttribute("#LEGENDTEXT")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.KeywordsStringEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeSeriesItems")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCellColumn_Text")]
    public virtual string Text { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.KeywordsStringEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeSeriesItems")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeToolTip")]
    public virtual string ToolTip { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.KeywordsStringEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeSeriesItems")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeUrl")]
    public virtual string Url { get { return default(string); } set { } }
    protected override void Dispose(bool disposing) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeMargins() { return default(bool); }
  }
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCellColumnCollection_LegendCellColumnCollection")]
  public partial class LegendCellColumnCollection : System.Web.UI.DataVisualization.Charting.ChartNamedElementCollection<System.Web.UI.DataVisualization.Charting.LegendCellColumn> {
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
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendCollection_LegendCollection")]
  public partial class LegendCollection : System.Web.UI.DataVisualization.Charting.ChartNamedElementCollection<System.Web.UI.DataVisualization.Charting.Legend> {
    internal LegendCollection() { }
    public System.Web.UI.DataVisualization.Charting.Legend Add(string name) { return default(System.Web.UI.DataVisualization.Charting.Legend); }
  }
  public enum LegendImageStyle {
    Line = 1,
    Marker = 2,
    Rectangle = 0,
  }
  [System.ComponentModel.DefaultPropertyAttribute("Name")]
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendItem_LegendItem")]
  public partial class LegendItem : System.Web.UI.DataVisualization.Charting.ChartNamedElement, System.Web.UI.DataVisualization.Charting.IChartMapArea {
    public LegendItem() { }
    public LegendItem(string name, System.Drawing.Color color, string image) { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.GradientStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.GradientEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackGradientStyle")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.GradientStyle BackGradientStyle { get { return default(System.Web.UI.DataVisualization.Charting.GradientStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ChartHatchStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.HatchStyleEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackHatchStyle")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { get { return default(System.Web.UI.DataVisualization.Charting.ChartHatchStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeImageTransparentColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color BackImageTransparentColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackSecondaryColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color BackSecondaryColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color BorderColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ChartDashStyle)(5))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderDashStyle")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.ChartDashStyle BorderDashStyle { get { return default(System.Web.UI.DataVisualization.Charting.ChartDashStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(1)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderWidth")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public int BorderWidth { get { return default(int); } set { } }
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.LegendCellCollectionEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendItem_Cells")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    public System.Web.UI.DataVisualization.Charting.LegendCellCollection Cells { get { return default(System.Web.UI.DataVisualization.Charting.LegendCellCollection); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendItem_Color")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color Color { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.ComponentModel.ParenthesizePropertyNameAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendItem_Enabled")]
    public bool Enabled { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ImageValueEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendItem_Image")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public string Image { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Web.UI.DataVisualization.Charting.LegendImageStyle), "Rectangle")]
    [System.ComponentModel.ParenthesizePropertyNameAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendItem_Style")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.LegendImageStyle ImageStyle { get { return default(System.Web.UI.DataVisualization.Charting.LegendImageStyle); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public System.Web.UI.DataVisualization.Charting.Legend Legend { get { return default(System.Web.UI.DataVisualization.Charting.Legend); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMapArea")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMapAreaAttributes")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public string MapAreaAttributes { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMarker")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMarkerBorderColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color MarkerBorderColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.DefaultValueAttribute(1)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMarker")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMarkerBorderWidth")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public int MarkerBorderWidth { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMarker")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendItem_MarkerColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color MarkerColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ImageValueEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMarker")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMarkerImage")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public string MarkerImage { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMarker")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeImageTransparentColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color MarkerImageTransparentColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(5)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMarker")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendItem_MarkerSize")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public int MarkerSize { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.MarkerStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.MarkerStyleEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMarker")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendItem_MarkerStyle")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.MarkerStyle MarkerStyle { get { return default(System.Web.UI.DataVisualization.Charting.MarkerStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.ParenthesizePropertyNameAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendItem_Name")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public override string Name { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMapArea")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributePostBackValue")]
    public string PostBackValue { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendItem_SeparatorColor")]
    public System.Drawing.Color SeparatorColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Web.UI.DataVisualization.Charting.LegendSeparatorStyle), "None")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendItem_Separator")]
    public System.Web.UI.DataVisualization.Charting.LegendSeparatorStyle SeparatorType { get { return default(System.Web.UI.DataVisualization.Charting.LegendSeparatorStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendItem_SeriesName")]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public string SeriesName { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(-1)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLegendItem_SeriesPointIndex")]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public int SeriesPointIndex { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "128,0,0,0")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeShadowColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color ShadowColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeShadowOffset")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    public int ShadowOffset { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMapArea")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeToolTip")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public string ToolTip { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.UrlValueEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMapArea")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeUrl")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public string Url { get { return default(string); } set { } }
    protected override void Dispose(bool disposing) { }
  }
  public enum LegendItemOrder {
    Auto = 0,
    ReversedSeriesOrder = 2,
    SameAsSeriesOrder = 1,
  }
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCustomLabelsCollection_CustomLabelsCollection")]
  public partial class LegendItemsCollection : System.Web.UI.DataVisualization.Charting.ChartElementCollection<System.Web.UI.DataVisualization.Charting.LegendItem> {
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
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineAnchorCapStyle_LineAnchorCapStyle")]
  public enum LineAnchorCapStyle {
    Arrow = 1,
    Diamond = 2,
    None = 0,
    Round = 4,
    Square = 3,
  }
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineAnnotation_LineAnnotation")]
  public partial class LineAnnotation : System.Web.UI.DataVisualization.Charting.Annotation {
    public LineAnnotation() { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.ContentAlignment), "MiddleCenter")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    public override System.Drawing.ContentAlignment Alignment { get { return default(System.Drawing.ContentAlignment); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.ContentAlignment), "TopLeft")]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAnchor")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnchorAlignment")]
    public override System.Drawing.ContentAlignment AnchorAlignment { get { return default(System.Drawing.ContentAlignment); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationType")]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public override string AnnotationType { get { return default(string); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    public override System.Drawing.Color BackColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.GradientStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.GradientEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    public override System.Web.UI.DataVisualization.Charting.GradientStyle BackGradientStyle { get { return default(System.Web.UI.DataVisualization.Charting.GradientStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ChartHatchStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.HatchStyleEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    public override System.Web.UI.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { get { return default(System.Web.UI.DataVisualization.Charting.ChartHatchStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    public override System.Drawing.Color BackSecondaryColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.LineAnchorCapStyle)(0))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeStartCap3")]
    public virtual System.Web.UI.DataVisualization.Charting.LineAnchorCapStyle EndCap { get { return default(System.Web.UI.DataVisualization.Charting.LineAnchorCapStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Font), "Microsoft Sans Serif, 8pt")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    public override System.Drawing.Font Font { get { return default(System.Drawing.Font); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeForeColor")]
    public override System.Drawing.Color ForeColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeDrawInfinitive")]
    public virtual bool IsInfinitive { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributePosition")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeSizeAlwaysRelative3")]
    public override bool IsSizeAlwaysRelative { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.LineAnchorCapStyle)(0))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeStartCap3")]
    public virtual System.Web.UI.DataVisualization.Charting.LineAnchorCapStyle StartCap { get { return default(System.Web.UI.DataVisualization.Charting.LineAnchorCapStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override System.Web.UI.DataVisualization.Charting.TextStyle TextStyle { get { return default(System.Web.UI.DataVisualization.Charting.TextStyle); } set { } }
  }
  [System.ComponentModel.DefaultPropertyAttribute("ToolTip")]
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMapArea_MapArea")]
  public partial class MapArea : System.Web.UI.DataVisualization.Charting.ChartNamedElement, System.Web.UI.DataVisualization.Charting.IChartMapArea {
    public MapArea() { }
    public MapArea(string url, System.Drawing.Drawing2D.GraphicsPath path) { }
    public MapArea(string url, System.Drawing.RectangleF rect) { }
    public MapArea(string toolTip, string url, string attributes, string postBackValue, System.Drawing.Drawing2D.GraphicsPath path, object tag) { }
    public MapArea(string toolTip, string url, string attributes, string postBackValue, System.Drawing.RectangleF rect, object tag) { }
    public MapArea(System.Web.UI.DataVisualization.Charting.MapAreaShape shape, string url, System.Single[] coordinates) { }
    public MapArea(System.Web.UI.DataVisualization.Charting.MapAreaShape shape, string toolTip, string url, string attributes, string postBackValue, System.Single[] coordinates, object tag) { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.MapAreaCoordinatesConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeShape")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMapArea_Coordinates")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Single[] Coordinates { get { return default(System.Single[]); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMapArea_Custom")]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public bool IsCustom { get { return default(bool); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMapArea")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMapAreaAttributes")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public string MapAreaAttributes { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute("Map Area")]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeData")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMapArea_Name")]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public override string Name { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMapArea")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributePostBackValue")]
    public string PostBackValue { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Web.UI.DataVisualization.Charting.MapAreaShape), "Rectangle")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeShape")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMapArea_Shape")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.MapAreaShape Shape { get { return default(System.Web.UI.DataVisualization.Charting.MapAreaShape); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMapArea")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeToolTip")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public string ToolTip { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.UrlValueEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMapArea")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeUrl")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public string Url { get { return default(string); } set { } }
  }
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMapAreasCollection_MapAreasCollection")]
  public partial class MapAreasCollection : System.Web.UI.DataVisualization.Charting.ChartElementCollection<System.Web.UI.DataVisualization.Charting.MapArea> {
    public MapAreasCollection() { }
  }
  public enum MapAreaShape {
    Circle = 1,
    Polygon = 2,
    Rectangle = 0,
  }
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.MarginExpandableObjectConverter))]
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMargins_Margins")]
  public partial class Margins {
    public Margins() { }
    public Margins(int top, int bottom, int left, int right) { }
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMargins_Bottom")]
    public int Bottom { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMargins_Left")]
    public int Left { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMargins_Right")]
    public int Right { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMargins_Top")]
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
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeNamedImage_NamedImage")]
  public partial class NamedImage : System.Web.UI.DataVisualization.Charting.ChartNamedElement {
    public NamedImage() { }
    public NamedImage(string name, System.Drawing.Image image) { }
    [System.ComponentModel.BindableAttribute(false)]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeNamedImage_Image")]
    public System.Drawing.Image Image { get { return default(System.Drawing.Image); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeNamedImage_Name")]
    public override string Name { get { return default(string); } set { } }
    protected override void Dispose(bool disposing) { }
  }
  public partial class NamedImagesCollection : System.Web.UI.DataVisualization.Charting.ChartNamedElementCollection<System.Web.UI.DataVisualization.Charting.NamedImage> {
    internal NamedImagesCollection() { }
  }
  public partial class Point3D {
    public Point3D() { }
    public Point3D(float x, float y, float z) { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributePoint3D_PointF")]
    public System.Drawing.PointF PointF { get { return default(System.Drawing.PointF); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributePoint3D_X")]
    public float X { get { return default(float); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributePoint3D_Y")]
    public float Y { get { return default(float); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributePoint3D_Z")]
    public float Z { get { return default(float); } set { } }
  }
  public enum PointSortOrder {
    Ascending = 0,
    Descending = 1,
  }
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributePolygonAnnotation_PolygonAnnotation")]
  public partial class PolygonAnnotation : System.Web.UI.DataVisualization.Charting.PolylineAnnotation {
    public PolygonAnnotation() { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationType")]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public override string AnnotationType { get { return default(string); } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackColor")]
    public override System.Drawing.Color BackColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.GradientStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.GradientEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackGradientStyle")]
    public override System.Web.UI.DataVisualization.Charting.GradientStyle BackGradientStyle { get { return default(System.Web.UI.DataVisualization.Charting.GradientStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ChartHatchStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.HatchStyleEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackHatchStyle")]
    public override System.Web.UI.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { get { return default(System.Web.UI.DataVisualization.Charting.ChartHatchStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackSecondaryColor")]
    public override System.Drawing.Color BackSecondaryColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.LineAnchorCapStyle)(0))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    public override System.Web.UI.DataVisualization.Charting.LineAnchorCapStyle EndCap { get { return default(System.Web.UI.DataVisualization.Charting.LineAnchorCapStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.LineAnchorCapStyle)(0))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    public override System.Web.UI.DataVisualization.Charting.LineAnchorCapStyle StartCap { get { return default(System.Web.UI.DataVisualization.Charting.LineAnchorCapStyle); } set { } }
  }
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributePolylineAnnotation_PolylineAnnotation")]
  public partial class PolylineAnnotation : System.Web.UI.DataVisualization.Charting.Annotation {
    public PolylineAnnotation() { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.ContentAlignment), "MiddleCenter")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    public override System.Drawing.ContentAlignment Alignment { get { return default(System.Drawing.ContentAlignment); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationType")]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public override string AnnotationType { get { return default(string); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    public override System.Drawing.Color BackColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.GradientStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.GradientEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    public override System.Web.UI.DataVisualization.Charting.GradientStyle BackGradientStyle { get { return default(System.Web.UI.DataVisualization.Charting.GradientStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ChartHatchStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.HatchStyleEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    public override System.Web.UI.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { get { return default(System.Web.UI.DataVisualization.Charting.ChartHatchStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    public override System.Drawing.Color BackSecondaryColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.LineAnchorCapStyle)(0))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeStartCap3")]
    public virtual System.Web.UI.DataVisualization.Charting.LineAnchorCapStyle EndCap { get { return default(System.Web.UI.DataVisualization.Charting.LineAnchorCapStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Font), "Microsoft Sans Serif, 8pt")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    public override System.Drawing.Font Font { get { return default(System.Drawing.Font); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeForeColor")]
    public override System.Drawing.Color ForeColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributePosition")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributePath")]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public virtual System.Drawing.Drawing2D.GraphicsPath GraphicsPath { get { return default(System.Drawing.Drawing2D.GraphicsPath); } set { } }
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartCollectionEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributePosition")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributePathPoints")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    public System.Web.UI.DataVisualization.Charting.AnnotationPathPointCollection GraphicsPathPoints { get { return default(System.Web.UI.DataVisualization.Charting.AnnotationPathPointCollection); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeFreeDrawPlacement")]
    public virtual bool IsFreeDrawPlacement { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.LineAnchorCapStyle)(0))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeStartCap3")]
    public virtual System.Web.UI.DataVisualization.Charting.LineAnchorCapStyle StartCap { get { return default(System.Web.UI.DataVisualization.Charting.LineAnchorCapStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override System.Web.UI.DataVisualization.Charting.TextStyle TextStyle { get { return default(System.Web.UI.DataVisualization.Charting.TextStyle); } set { } }
    protected override void Dispose(bool disposing) { }
  }
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeRectangleAnnotation_RectangleAnnotation")]
  public partial class RectangleAnnotation : System.Web.UI.DataVisualization.Charting.TextAnnotation {
    public RectangleAnnotation() { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationType")]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public override string AnnotationType { get { return default(string); } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackColor")]
    public override System.Drawing.Color BackColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.GradientStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.GradientEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackGradientStyle")]
    public override System.Web.UI.DataVisualization.Charting.GradientStyle BackGradientStyle { get { return default(System.Web.UI.DataVisualization.Charting.GradientStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ChartHatchStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.HatchStyleEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackHatchStyle")]
    public override System.Web.UI.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { get { return default(System.Web.UI.DataVisualization.Charting.ChartHatchStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackSecondaryColor")]
    public override System.Drawing.Color BackSecondaryColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineColor")]
    public override System.Drawing.Color LineColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ChartDashStyle)(5))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineDashStyle")]
    public override System.Web.UI.DataVisualization.Charting.ChartDashStyle LineDashStyle { get { return default(System.Web.UI.DataVisualization.Charting.ChartDashStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(1)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineWidth")]
    public override int LineWidth { get { return default(int); } set { } }
  }
  public enum RenderType {
    BinaryStreaming = 1,
    ImageMap = 2,
    ImageTag = 0,
  }
  public enum RightToLeft {
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    Inherit = 0,
    No = 0,
    Yes = 1,
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
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeSeries_Series")]
  public partial class Series : System.Web.UI.DataVisualization.Charting.DataPointCustomProperties {
    public Series() { }
    public Series(string name) { }
    public Series(string name, int yValues) { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAxisLabel")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public override string AxisLabel { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.SeriesAreaNameConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeChart")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeSeries_ChartArea")]
    public string ChartArea { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.SeriesChartType)(10))]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartTypeEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeChart")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeSeries_Type")]
    public System.Web.UI.DataVisualization.Charting.SeriesChartType ChartType { get { return default(System.Web.UI.DataVisualization.Charting.SeriesChartType); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute("Column")]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartTypeEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.ChartTypeConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeChart")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeSeries_Type")]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public string ChartTypeName { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeEmptyPoints")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeSeries_EmptyPointStyle")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    public System.Web.UI.DataVisualization.Charting.DataPointCustomProperties EmptyPointStyle { get { return default(System.Web.UI.DataVisualization.Charting.DataPointCustomProperties); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.ParenthesizePropertyNameAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeSeries_Enabled")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public bool Enabled { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeData")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeSeries_XValueIndexed")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public bool IsXValueIndexed { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.SeriesLegendNameConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLegend")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeSeries_Legend")]
    public string Legend { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(1)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMarker")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeSeries_MarkerStep")]
    public int MarkerStep { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeData")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeSeries_Name")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public override string Name { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ChartColorPalette)(0))]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ColorPaletteEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributePalette")]
    public System.Web.UI.DataVisualization.Charting.ChartColorPalette Palette { get { return default(System.Web.UI.DataVisualization.Charting.ChartColorPalette); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.DataPointCollectionEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeData")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeSeries_Points")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    [System.Web.UI.ThemeableAttribute(false)]
    public System.Web.UI.DataVisualization.Charting.DataPointCollection Points { get { return default(System.Web.UI.DataVisualization.Charting.DataPointCollection); } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "128,0,0,0")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeShadowColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color ShadowColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeShadowOffset")]
    public int ShadowOffset { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeLabel")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeSeries_SmartLabels")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    public System.Web.UI.DataVisualization.Charting.SmartLabelStyle SmartLabelStyle { get { return default(System.Web.UI.DataVisualization.Charting.SmartLabelStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.AxisType)(0))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAxes")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeSeries_XAxisType")]
    public System.Web.UI.DataVisualization.Charting.AxisType XAxisType { get { return default(System.Web.UI.DataVisualization.Charting.AxisType); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.TypeConverterAttribute("System.Web.UI.Design.DataVisualization.Charting.SeriesDataFieldXConvertor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeDataSource")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeSeries_ValueMemberX")]
    public string XValueMember { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ChartValueType)(0))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeData")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeSeries_XValueType")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.ChartValueType XValueType { get { return default(System.Web.UI.DataVisualization.Charting.ChartValueType); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.AxisType)(0))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAxes")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeSeries_YAxisType")]
    public System.Web.UI.DataVisualization.Charting.AxisType YAxisType { get { return default(System.Web.UI.DataVisualization.Charting.AxisType); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.SeriesDataFieldValueAxisUITypeEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute("System.Web.UI.Design.DataVisualization.Charting.SeriesDataFieldYConvertor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeDataSource")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeSeries_ValueMembersY")]
    public string YValueMembers { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(1)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeData")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeSeries_YValuesPerPoint")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public int YValuesPerPoint { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ChartValueType)(0))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.SeriesYValueTypeConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeData")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeSeries_YValueType")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.ChartValueType YValueType { get { return default(System.Web.UI.DataVisualization.Charting.ChartValueType); } set { } }
    protected override void Dispose(bool disposing) { }
    public void Sort(System.Collections.Generic.IComparer<System.Web.UI.DataVisualization.Charting.DataPoint> comparer) { }
    public void Sort(System.Web.UI.DataVisualization.Charting.PointSortOrder pointSortOrder) { }
    public void Sort(System.Web.UI.DataVisualization.Charting.PointSortOrder pointSortOrder, string sortBy) { }
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
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeSeriesCollection_SeriesCollection")]
  public partial class SeriesCollection : System.Web.UI.DataVisualization.Charting.ChartNamedElementCollection<System.Web.UI.DataVisualization.Charting.Series> {
    internal SeriesCollection() { }
    public System.Web.UI.DataVisualization.Charting.Series Add(string name) { return default(System.Web.UI.DataVisualization.Charting.Series); }
  }
  [System.ComponentModel.DefaultPropertyAttribute("Enabled")]
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.NoNameExpandableObjectConverter))]
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeSmartLabelsStyle_SmartLabelsStyle")]
  public partial class SmartLabelStyle {
    public SmartLabelStyle() { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.LabelOutsidePlotAreaStyle)(2))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAllowOutsidePlotArea")]
    public virtual System.Web.UI.DataVisualization.Charting.LabelOutsidePlotAreaStyle AllowOutsidePlotArea { get { return default(System.Web.UI.DataVisualization.Charting.LabelOutsidePlotAreaStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Transparent")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCalloutBackColor")]
    public virtual System.Drawing.Color CalloutBackColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.LineAnchorCapStyle)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCalloutLineAnchorCap")]
    public virtual System.Web.UI.DataVisualization.Charting.LineAnchorCapStyle CalloutLineAnchorCapStyle { get { return default(System.Web.UI.DataVisualization.Charting.LineAnchorCapStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCalloutLineColor")]
    public virtual System.Drawing.Color CalloutLineColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ChartDashStyle)(5))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineDashStyle")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public virtual System.Web.UI.DataVisualization.Charting.ChartDashStyle CalloutLineDashStyle { get { return default(System.Web.UI.DataVisualization.Charting.ChartDashStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(1)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineWidth")]
    public virtual int CalloutLineWidth { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.LabelCalloutStyle)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeCalloutStyle3")]
    public virtual System.Web.UI.DataVisualization.Charting.LabelCalloutStyle CalloutStyle { get { return default(System.Web.UI.DataVisualization.Charting.LabelCalloutStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.ComponentModel.ParenthesizePropertyNameAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeEnabled13")]
    public virtual bool Enabled { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMarkerOverlapping")]
    public virtual bool IsMarkerOverlappingAllowed { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeHideOverlapped")]
    public virtual bool IsOverlappedHidden { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(30)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMaxMovingDistance")]
    public virtual double MaxMovingDistance { get { return default(double); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMinMovingDistance")]
    public virtual double MinMovingDistance { get { return default(double); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Web.UI.DataVisualization.Charting.LabelAlignmentStyles), "Top, Bottom, Right, Left, TopLeft, TopRight, BottomLeft, BottomRight")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.FlagsEnumUITypeEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMovingDirection")]
    public virtual System.Web.UI.DataVisualization.Charting.LabelAlignmentStyles MovingDirection { get { return default(System.Web.UI.DataVisualization.Charting.LabelAlignmentStyles); } set { } }
  }
  public enum StartFromZero {
    Auto = 0,
    No = 2,
    Yes = 1,
  }
  public partial class StatisticFormula {
    internal StatisticFormula() { }
    public System.Web.UI.DataVisualization.Charting.AnovaResult Anova(double probability, string inputSeriesNames) { return default(System.Web.UI.DataVisualization.Charting.AnovaResult); }
    public double BetaFunction(double m, double n) { return default(double); }
    public double Correlation(string firstInputSeriesName, string secondInputSeriesName) { return default(double); }
    public double Covariance(string firstInputSeriesName, string secondInputSeriesName) { return default(double); }
    public double FDistribution(double value, int firstDegreeOfFreedom, int secondDegreeOfFreedom) { return default(double); }
    public System.Web.UI.DataVisualization.Charting.FTestResult FTest(double probability, string firstInputSeriesName, string secondInputSeriesName) { return default(System.Web.UI.DataVisualization.Charting.FTestResult); }
    public double GammaFunction(double value) { return default(double); }
    public double InverseFDistribution(double probability, int firstDegreeOfFreedom, int secondDegreeOfFreedom) { return default(double); }
    public double InverseNormalDistribution(double probability) { return default(double); }
    public double InverseTDistribution(double probability, int degreeOfFreedom) { return default(double); }
    public double Mean(string inputSeriesName) { return default(double); }
    public double Median(string inputSeriesName) { return default(double); }
    public double NormalDistribution(double zValue) { return default(double); }
    public double TDistribution(double value, int degreeOfFreedom, bool oneTail) { return default(double); }
    public System.Web.UI.DataVisualization.Charting.TTestResult TTestEqualVariances(double hypothesizedMeanDifference, double probability, string firstInputSeriesName, string secondInputSeriesName) { return default(System.Web.UI.DataVisualization.Charting.TTestResult); }
    public System.Web.UI.DataVisualization.Charting.TTestResult TTestPaired(double hypothesizedMeanDifference, double probability, string firstInputSeriesName, string secondInputSeriesName) { return default(System.Web.UI.DataVisualization.Charting.TTestResult); }
    public System.Web.UI.DataVisualization.Charting.TTestResult TTestUnequalVariances(double hypothesizedMeanDifference, double probability, string firstInputSeriesName, string secondInputSeriesName) { return default(System.Web.UI.DataVisualization.Charting.TTestResult); }
    public double Variance(string inputSeriesName, bool sampleVariance) { return default(double); }
    public System.Web.UI.DataVisualization.Charting.ZTestResult ZTest(double hypothesizedMeanDifference, double varianceFirstGroup, double varianceSecondGroup, double probability, string firstInputSeriesName, string secondInputSeriesName) { return default(System.Web.UI.DataVisualization.Charting.ZTestResult); }
  }
  [System.ComponentModel.DefaultPropertyAttribute("IntervalOffset")]
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeStripLine_StripLine")]
  public partial class StripLine : System.Web.UI.DataVisualization.Charting.ChartElement, System.Web.UI.DataVisualization.Charting.IChartMapArea {
    public StripLine() { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color BackColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.GradientStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.GradientEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackGradientStyle")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.GradientStyle BackGradientStyle { get { return default(System.Web.UI.DataVisualization.Charting.GradientStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ChartHatchStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.HatchStyleEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackHatchStyle")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { get { return default(System.Web.UI.DataVisualization.Charting.ChartHatchStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ImageValueEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackImage")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public string BackImage { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ChartImageAlignmentStyle)(0))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackImageAlign")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.ChartImageAlignmentStyle BackImageAlignment { get { return default(System.Web.UI.DataVisualization.Charting.ChartImageAlignmentStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeImageTransparentColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color BackImageTransparentColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ChartImageWrapMode)(0))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeImageWrapMode")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.ChartImageWrapMode BackImageWrapMode { get { return default(System.Web.UI.DataVisualization.Charting.ChartImageWrapMode); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackSecondaryColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color BackSecondaryColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color BorderColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ChartDashStyle)(5))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderDashStyle")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.ChartDashStyle BorderDashStyle { get { return default(System.Web.UI.DataVisualization.Charting.ChartDashStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(1)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderWidth")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public int BorderWidth { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Font), "Microsoft Sans Serif, 8pt")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeTitle")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTitleFont")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Font Font { get { return default(System.Drawing.Font); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeTitle")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeStripLine_TitleColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color ForeColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeData")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeStripLine_Interval")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public double Interval { get { return default(double); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.AxisLabelDateValueConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeData")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeStripLine_IntervalOffset")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public double IntervalOffset { get { return default(double); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.DateTimeIntervalType)(0))]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeData")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeStripLine_IntervalOffsetType")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.DateTimeIntervalType IntervalOffsetType { get { return default(System.Web.UI.DataVisualization.Charting.DateTimeIntervalType); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.DateTimeIntervalType)(0))]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeData")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeStripLine_IntervalType")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.DateTimeIntervalType IntervalType { get { return default(System.Web.UI.DataVisualization.Charting.DateTimeIntervalType); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMapArea")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMapAreaAttributes")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public string MapAreaAttributes { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(false)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute("StripLine")]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeStripLine_Name")]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public string Name { get { return default(string); } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMapArea")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributePostBackValue")]
    public string PostBackValue { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeData")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeStripLine_StripWidth")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public double StripWidth { get { return default(double); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.DateTimeIntervalType)(0))]
    [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeData")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeStripLine_StripWidthType")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.DateTimeIntervalType StripWidthType { get { return default(System.Web.UI.DataVisualization.Charting.DateTimeIntervalType); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeTitle")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeStripLine_Title")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public string Text { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.StringAlignment), "Far")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeTitle")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeStripLine_TitleAlignment")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.StringAlignment TextAlignment { get { return default(System.Drawing.StringAlignment); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.StringAlignment), "Near")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeTitle")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeStripLine_TitleLineAlignment")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.StringAlignment TextLineAlignment { get { return default(System.Drawing.StringAlignment); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.TextOrientation)(0))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttribute_TextOrientation")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.TextOrientation TextOrientation { get { return default(System.Web.UI.DataVisualization.Charting.TextOrientation); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMapArea")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeToolTip")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public string ToolTip { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.UrlValueEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMapArea")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeUrl")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public string Url { get { return default(string); } set { } }
    protected override void Dispose(bool disposing) { }
  }
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeStripLinesCollection_StripLinesCollection")]
  public partial class StripLinesCollection : System.Web.UI.DataVisualization.Charting.ChartElementCollection<System.Web.UI.DataVisualization.Charting.StripLine> {
    internal StripLinesCollection() { }
  }
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTextAnnotation_TextAnnotation")]
  public partial class TextAnnotation : System.Web.UI.DataVisualization.Charting.Annotation {
    public TextAnnotation() { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTextAnnotation_AnnotationType")]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public override string AnnotationType { get { return default(string); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    public override System.Drawing.Color BackColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.GradientStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.GradientEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    public override System.Web.UI.DataVisualization.Charting.GradientStyle BackGradientStyle { get { return default(System.Web.UI.DataVisualization.Charting.GradientStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ChartHatchStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.HatchStyleEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    public override System.Web.UI.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { get { return default(System.Web.UI.DataVisualization.Charting.ChartHatchStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    public override System.Drawing.Color BackSecondaryColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Font), "Microsoft Sans Serif, 8pt")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTextFont4")]
    public override System.Drawing.Font Font { get { return default(System.Drawing.Font); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMultiline")]
    public virtual bool IsMultiline { get { return default(bool); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    public override System.Drawing.Color LineColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ChartDashStyle)(5))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    public override System.Web.UI.DataVisualization.Charting.ChartDashStyle LineDashStyle { get { return default(System.Web.UI.DataVisualization.Charting.ChartDashStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(1)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeLineWidth")]
    public override int LineWidth { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeText")]
    public virtual string Text { get { return default(string); } set { } }
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
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTickMark_TickMark")]
  public partial class TickMark : System.Web.UI.DataVisualization.Charting.Grid {
    public TickMark() { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(1f)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTickMark_Size")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public float Size { get { return default(float); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.TickMarkStyle)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTickMark_Style")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.TickMarkStyle TickMarkStyle { get { return default(System.Web.UI.DataVisualization.Charting.TickMarkStyle); } set { } }
  }
  public enum TickMarkStyle {
    AcrossAxis = 3,
    InsideArea = 2,
    None = 0,
    OutsideArea = 1,
  }
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTitle5")]
  public partial class Title : System.Web.UI.DataVisualization.Charting.ChartNamedElement, System.IDisposable, System.Web.UI.DataVisualization.Charting.IChartMapArea {
    public Title() { }
    public Title(string text) { }
    public Title(string text, System.Web.UI.DataVisualization.Charting.Docking docking) { }
    public Title(string text, System.Web.UI.DataVisualization.Charting.Docking docking, System.Drawing.Font font, System.Drawing.Color color) { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Drawing.ContentAlignment)(32))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeDocking")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTitle_Alignment")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.ContentAlignment Alignment { get { return default(System.Drawing.ContentAlignment); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color BackColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.GradientStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.GradientEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackGradientStyle")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.GradientStyle BackGradientStyle { get { return default(System.Web.UI.DataVisualization.Charting.GradientStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ChartHatchStyle)(0))]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.HatchStyleEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackHatchStyle")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.ChartHatchStyle BackHatchStyle { get { return default(System.Web.UI.DataVisualization.Charting.ChartHatchStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ImageValueEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackImage")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public string BackImage { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ChartImageAlignmentStyle)(0))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackImageAlign")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.ChartImageAlignmentStyle BackImageAlignment { get { return default(System.Web.UI.DataVisualization.Charting.ChartImageAlignmentStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeImageTransparentColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color BackImageTransparentColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ChartImageWrapMode)(0))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeImageWrapMode")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.ChartImageWrapMode BackImageWrapMode { get { return default(System.Web.UI.DataVisualization.Charting.ChartImageWrapMode); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBackSecondaryColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color BackSecondaryColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color BorderColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.ChartDashStyle)(5))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderDashStyle")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.ChartDashStyle BorderDashStyle { get { return default(System.Web.UI.DataVisualization.Charting.ChartDashStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(1)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeBorderWidth")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public int BorderWidth { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("NotSet")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.LegendAreaNameConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeDocking")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTitle_DockToChartArea")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public string DockedToChartArea { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.Docking)(0))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeDocking")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTitle_Docking")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.Docking Docking { get { return default(System.Web.UI.DataVisualization.Charting.Docking); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeDocking")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTitle_DockOffset")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public int DockingOffset { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Font), "Microsoft Sans Serif, 8pt")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTitle_Font")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Font Font { get { return default(System.Drawing.Font); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "Black")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTitle_Color")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color ForeColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeDocking")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTitle_DockInsideChartArea")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public bool IsDockedInsideChartArea { get { return default(bool); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMapArea")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeMapAreaAttributes")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public string MapAreaAttributes { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTitle_Name")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public override string Name { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.DataVisualization.Charting.ElementPositionConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTitle_Position")]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(2))]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    public System.Web.UI.DataVisualization.Charting.ElementPosition Position { get { return default(System.Web.UI.DataVisualization.Charting.ElementPosition); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMapArea")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributePostBackValue")]
    public string PostBackValue { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Drawing.Color), "128, 0, 0, 0")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.ChartColorEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.ColorConverter))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeShadowColor")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Drawing.Color ShadowColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute(0)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeShadowOffset")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public int ShadowOffset { get { return default(int); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.ParenthesizePropertyNameAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTitle_Text")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public string Text { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.TextOrientation)(0))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttribute_TextOrientation")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.TextOrientation TextOrientation { get { return default(System.Web.UI.DataVisualization.Charting.TextOrientation); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.DataVisualization.Charting.TextStyle)(0))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTextStyle")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public System.Web.UI.DataVisualization.Charting.TextStyle TextStyle { get { return default(System.Web.UI.DataVisualization.Charting.TextStyle); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMapArea")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeToolTip")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public string ToolTip { get { return default(string); } set { } }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.DataVisualization.Charting.UrlValueEditor, System.Web.DataVisualization.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMapArea")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeUrl")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(0))]
    public string Url { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.ComponentModel.ParenthesizePropertyNameAttribute(true)]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeAppearance")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTitle_Visible")]
    public virtual bool Visible { get { return default(bool); } set { } }
    protected override void Dispose(bool disposing) { }
  }
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeTitles")]
  public partial class TitleCollection : System.Web.UI.DataVisualization.Charting.ChartNamedElementCollection<System.Web.UI.DataVisualization.Charting.Title> {
    internal TitleCollection() { }
    public System.Web.UI.DataVisualization.Charting.Title Add(string name) { return default(System.Web.UI.DataVisualization.Charting.Title); }
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
  [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeVerticalLineAnnotation_VerticalLineAnnotation")]
  public partial class VerticalLineAnnotation : System.Web.UI.DataVisualization.Charting.LineAnnotation {
    public VerticalLineAnnotation() { }
    [System.ComponentModel.BindableAttribute(true)]
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Web.UI.DataVisualization.Charting.SRCategoryAttribute("CategoryAttributeMisc")]
    [System.Web.UI.DataVisualization.Charting.SRDescriptionAttribute("DescriptionAttributeAnnotationType")]
    [System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibilityAttribute((System.Web.UI.DataVisualization.Charting.Utilities.SerializationVisibility)(0))]
    public override string AnnotationType { get { return default(string); } }
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
