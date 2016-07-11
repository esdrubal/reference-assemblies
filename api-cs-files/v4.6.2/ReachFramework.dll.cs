namespace System.Printing {
  public enum Collation {
    Collated = 1,
    Uncollated = 2,
    Unknown = 0,
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public enum ConflictStatus {
    ConflictResolved = 1,
    NoConflict = 0,
  }
  public enum DeviceFontSubstitution {
    Off = 1,
    On = 2,
    Unknown = 0,
  }
  public enum Duplexing {
    OneSided = 1,
    TwoSidedLongEdge = 3,
    TwoSidedShortEdge = 2,
    Unknown = 0,
  }
  public enum InputBin {
    AutoSelect = 1,
    AutoSheetFeeder = 4,
    Cassette = 2,
    Manual = 5,
    Tractor = 3,
    Unknown = 0,
  }
  public enum OutputColor {
    Color = 1,
    Grayscale = 2,
    Monochrome = 3,
    Unknown = 0,
  }
  public enum OutputQuality {
    Automatic = 1,
    Draft = 2,
    Fax = 3,
    High = 4,
    Normal = 5,
    Photographic = 6,
    Text = 7,
    Unknown = 0,
  }
  public enum PageBorderless {
    Borderless = 1,
    None = 2,
    Unknown = 0,
  }
  public sealed partial class PageImageableArea {
    internal PageImageableArea() { }
    public double ExtentHeight { get { return default(double); } }
    public double ExtentWidth { get { return default(double); } }
    public double OriginHeight { get { return default(double); } }
    public double OriginWidth { get { return default(double); } }
    public override string ToString() { return default(string); }
  }
  public sealed partial class PageMediaSize {
    public PageMediaSize(double width, double height) { }
    public PageMediaSize(System.Printing.PageMediaSizeName mediaSizeName) { }
    public PageMediaSize(System.Printing.PageMediaSizeName mediaSizeName, double width, double height) { }
    public System.Nullable<System.Double> Height { get { return default(System.Nullable<System.Double>); } }
    public System.Nullable<System.Printing.PageMediaSizeName> PageMediaSizeName { get { return default(System.Nullable<System.Printing.PageMediaSizeName>); } }
    public System.Nullable<System.Double> Width { get { return default(System.Nullable<System.Double>); } }
    public override string ToString() { return default(string); }
  }
  public enum PageMediaSizeName {
    BusinessCard = 169,
    CreditCard = 170,
    ISOA0 = 1,
    ISOA1 = 2,
    ISOA10 = 3,
    ISOA2 = 4,
    ISOA3 = 5,
    ISOA3Extra = 7,
    ISOA3Rotated = 6,
    ISOA4 = 8,
    ISOA4Extra = 10,
    ISOA4Rotated = 9,
    ISOA5 = 11,
    ISOA5Extra = 13,
    ISOA5Rotated = 12,
    ISOA6 = 14,
    ISOA6Rotated = 15,
    ISOA7 = 16,
    ISOA8 = 17,
    ISOA9 = 18,
    ISOB0 = 19,
    ISOB1 = 20,
    ISOB10 = 21,
    ISOB2 = 22,
    ISOB3 = 23,
    ISOB4 = 24,
    ISOB4Envelope = 25,
    ISOB5Envelope = 26,
    ISOB5Extra = 27,
    ISOB7 = 28,
    ISOB8 = 29,
    ISOB9 = 30,
    ISOC0 = 31,
    ISOC1 = 32,
    ISOC10 = 33,
    ISOC2 = 34,
    ISOC3 = 35,
    ISOC3Envelope = 36,
    ISOC4 = 37,
    ISOC4Envelope = 38,
    ISOC5 = 39,
    ISOC5Envelope = 40,
    ISOC6 = 41,
    ISOC6C5Envelope = 43,
    ISOC6Envelope = 42,
    ISOC7 = 44,
    ISOC8 = 45,
    ISOC9 = 46,
    ISODLEnvelope = 47,
    ISODLEnvelopeRotated = 48,
    ISOSRA3 = 49,
    Japan2LPhoto = 156,
    JapanChou3Envelope = 65,
    JapanChou3EnvelopeRotated = 66,
    JapanChou4Envelope = 67,
    JapanChou4EnvelopeRotated = 68,
    JapanDoubleHagakiPostcard = 153,
    JapanDoubleHagakiPostcardRotated = 154,
    JapanHagakiPostcard = 69,
    JapanHagakiPostcardRotated = 70,
    JapanKaku2Envelope = 71,
    JapanKaku2EnvelopeRotated = 72,
    JapanKaku3Envelope = 73,
    JapanKaku3EnvelopeRotated = 74,
    JapanLPhoto = 155,
    JapanQuadrupleHagakiPostcard = 50,
    JapanYou1Envelope = 157,
    JapanYou2Envelope = 158,
    JapanYou3Envelope = 159,
    JapanYou4Envelope = 75,
    JapanYou4EnvelopeRotated = 160,
    JapanYou6Envelope = 161,
    JapanYou6EnvelopeRotated = 162,
    JISB0 = 51,
    JISB1 = 52,
    JISB10 = 53,
    JISB2 = 54,
    JISB3 = 55,
    JISB4 = 56,
    JISB4Rotated = 57,
    JISB5 = 58,
    JISB5Rotated = 59,
    JISB6 = 60,
    JISB6Rotated = 61,
    JISB7 = 62,
    JISB8 = 63,
    JISB9 = 64,
    NorthAmerica10x11 = 76,
    NorthAmerica10x12 = 167,
    NorthAmerica10x14 = 77,
    NorthAmerica11x17 = 78,
    NorthAmerica14x17 = 168,
    NorthAmerica4x6 = 163,
    NorthAmerica4x8 = 164,
    NorthAmerica5x7 = 165,
    NorthAmerica8x10 = 166,
    NorthAmerica9x11 = 79,
    NorthAmericaArchitectureASheet = 80,
    NorthAmericaArchitectureBSheet = 81,
    NorthAmericaArchitectureCSheet = 82,
    NorthAmericaArchitectureDSheet = 83,
    NorthAmericaArchitectureESheet = 84,
    NorthAmericaCSheet = 85,
    NorthAmericaDSheet = 86,
    NorthAmericaESheet = 87,
    NorthAmericaExecutive = 88,
    NorthAmericaGermanLegalFanfold = 89,
    NorthAmericaGermanStandardFanfold = 90,
    NorthAmericaLegal = 91,
    NorthAmericaLegalExtra = 92,
    NorthAmericaLetter = 93,
    NorthAmericaLetterExtra = 95,
    NorthAmericaLetterPlus = 96,
    NorthAmericaLetterRotated = 94,
    NorthAmericaMonarchEnvelope = 97,
    NorthAmericaNote = 98,
    NorthAmericaNumber10Envelope = 99,
    NorthAmericaNumber10EnvelopeRotated = 100,
    NorthAmericaNumber11Envelope = 102,
    NorthAmericaNumber12Envelope = 103,
    NorthAmericaNumber14Envelope = 104,
    NorthAmericaNumber9Envelope = 101,
    NorthAmericaPersonalEnvelope = 105,
    NorthAmericaQuarto = 106,
    NorthAmericaStatement = 107,
    NorthAmericaSuperA = 108,
    NorthAmericaSuperB = 109,
    NorthAmericaTabloid = 110,
    NorthAmericaTabloidExtra = 111,
    OtherMetricA3Plus = 113,
    OtherMetricA4Plus = 112,
    OtherMetricFolio = 114,
    OtherMetricInviteEnvelope = 115,
    OtherMetricItalianEnvelope = 116,
    PRC10Envelope = 119,
    PRC10EnvelopeRotated = 120,
    PRC16K = 121,
    PRC16KRotated = 122,
    PRC1Envelope = 117,
    PRC1EnvelopeRotated = 118,
    PRC2Envelope = 123,
    PRC2EnvelopeRotated = 124,
    PRC32K = 125,
    PRC32KBig = 127,
    PRC32KRotated = 126,
    PRC3Envelope = 128,
    PRC3EnvelopeRotated = 129,
    PRC4Envelope = 130,
    PRC4EnvelopeRotated = 131,
    PRC5Envelope = 132,
    PRC5EnvelopeRotated = 133,
    PRC6Envelope = 134,
    PRC6EnvelopeRotated = 135,
    PRC7Envelope = 136,
    PRC7EnvelopeRotated = 137,
    PRC8Envelope = 138,
    PRC8EnvelopeRotated = 139,
    PRC9Envelope = 140,
    PRC9EnvelopeRotated = 141,
    Roll04Inch = 142,
    Roll06Inch = 143,
    Roll08Inch = 144,
    Roll12Inch = 145,
    Roll15Inch = 146,
    Roll18Inch = 147,
    Roll22Inch = 148,
    Roll24Inch = 149,
    Roll30Inch = 150,
    Roll36Inch = 151,
    Roll54Inch = 152,
    Unknown = 0,
  }
  public enum PageMediaType {
    Archival = 2,
    AutoSelect = 1,
    BackPrintFilm = 3,
    Bond = 4,
    CardStock = 5,
    Continuous = 6,
    EnvelopePlain = 7,
    EnvelopeWindow = 8,
    Fabric = 9,
    HighResolution = 10,
    Label = 11,
    MultiLayerForm = 12,
    MultiPartForm = 13,
    None = 29,
    Photographic = 14,
    PhotographicFilm = 15,
    PhotographicGlossy = 16,
    PhotographicHighGloss = 17,
    PhotographicMatte = 18,
    PhotographicSatin = 19,
    PhotographicSemiGloss = 20,
    Plain = 21,
    Screen = 22,
    ScreenPaged = 23,
    Stationery = 24,
    TabStockFull = 25,
    TabStockPreCut = 26,
    Transparency = 27,
    TShirtTransfer = 28,
    Unknown = 0,
  }
  public enum PageOrder {
    Reverse = 2,
    Standard = 1,
    Unknown = 0,
  }
  public enum PageOrientation {
    Landscape = 1,
    Portrait = 2,
    ReverseLandscape = 3,
    ReversePortrait = 4,
    Unknown = 0,
  }
  public enum PageQualitativeResolution {
    Default = 1,
    Draft = 2,
    High = 3,
    Normal = 4,
    Other = 5,
    Unknown = 0,
  }
  public sealed partial class PageResolution {
    public PageResolution(int resolutionX, int resolutionY) { }
    public PageResolution(int resolutionX, int resolutionY, System.Printing.PageQualitativeResolution qualitative) { }
    public PageResolution(System.Printing.PageQualitativeResolution qualitative) { }
    public System.Nullable<System.Printing.PageQualitativeResolution> QualitativeResolution { get { return default(System.Nullable<System.Printing.PageQualitativeResolution>); } }
    public System.Nullable<System.Int32> X { get { return default(System.Nullable<System.Int32>); } }
    public System.Nullable<System.Int32> Y { get { return default(System.Nullable<System.Int32>); } }
    public override string ToString() { return default(string); }
  }
  public sealed partial class PageScalingFactorRange {
    internal PageScalingFactorRange() { }
    public int MaximumScale { get { return default(int); } }
    public int MinimumScale { get { return default(int); } }
    public override string ToString() { return default(string); }
  }
  public enum PagesPerSheetDirection {
    BottomLeft = 4,
    BottomRight = 2,
    LeftBottom = 3,
    LeftTop = 7,
    RightBottom = 1,
    RightTop = 5,
    TopLeft = 8,
    TopRight = 6,
    Unknown = 0,
  }
  public enum PhotoPrintingIntent {
    None = 1,
    PhotoBest = 2,
    PhotoDraft = 3,
    PhotoStandard = 4,
    Unknown = 0,
  }
  public sealed partial class PrintCapabilities {
    public PrintCapabilities(System.IO.Stream xmlStream) { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Printing.Collation> CollationCapability { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Printing.Collation>); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Printing.DeviceFontSubstitution> DeviceFontSubstitutionCapability { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Printing.DeviceFontSubstitution>); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Printing.Duplexing> DuplexingCapability { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Printing.Duplexing>); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Printing.InputBin> InputBinCapability { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Printing.InputBin>); } }
    public System.Nullable<System.Int32> MaxCopyCount { get { return default(System.Nullable<System.Int32>); } }
    public System.Nullable<System.Double> OrientedPageMediaHeight { get { return default(System.Nullable<System.Double>); } }
    public System.Nullable<System.Double> OrientedPageMediaWidth { get { return default(System.Nullable<System.Double>); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Printing.OutputColor> OutputColorCapability { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Printing.OutputColor>); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Printing.OutputQuality> OutputQualityCapability { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Printing.OutputQuality>); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Printing.PageBorderless> PageBorderlessCapability { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Printing.PageBorderless>); } }
    public System.Printing.PageImageableArea PageImageableArea { get { return default(System.Printing.PageImageableArea); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Printing.PageMediaSize> PageMediaSizeCapability { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Printing.PageMediaSize>); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Printing.PageMediaType> PageMediaTypeCapability { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Printing.PageMediaType>); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Printing.PageOrder> PageOrderCapability { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Printing.PageOrder>); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Printing.PageOrientation> PageOrientationCapability { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Printing.PageOrientation>); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Printing.PageResolution> PageResolutionCapability { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Printing.PageResolution>); } }
    public System.Printing.PageScalingFactorRange PageScalingFactorRange { get { return default(System.Printing.PageScalingFactorRange); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Int32> PagesPerSheetCapability { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Int32>); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Printing.PagesPerSheetDirection> PagesPerSheetDirectionCapability { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Printing.PagesPerSheetDirection>); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Printing.PhotoPrintingIntent> PhotoPrintingIntentCapability { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Printing.PhotoPrintingIntent>); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Printing.Stapling> StaplingCapability { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Printing.Stapling>); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Printing.TrueTypeFontMode> TrueTypeFontModeCapability { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Printing.TrueTypeFontMode>); } }
  }
  public partial class PrintCommitAttributesException : System.Printing.PrintSystemException {
    public PrintCommitAttributesException() { }
    public PrintCommitAttributesException(int errorCode, System.Collections.ObjectModel.Collection<System.String> attributesSuccessList, System.Collections.ObjectModel.Collection<System.String> attributesFailList) { }
    public PrintCommitAttributesException(int errorCode, string message, System.Collections.ObjectModel.Collection<System.String> attributesSuccessList, System.Collections.ObjectModel.Collection<System.String> attributesFailList, string objectName) { }
    protected PrintCommitAttributesException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public PrintCommitAttributesException(string message) { }
    public PrintCommitAttributesException(string message, System.Exception innerException) { }
    public System.Collections.ObjectModel.Collection<System.String> CommittedAttributesCollection { get { return default(System.Collections.ObjectModel.Collection<System.String>); } }
    public System.Collections.ObjectModel.Collection<System.String> FailedAttributesCollection { get { return default(System.Collections.ObjectModel.Collection<System.String>); } }
    public string PrintObjectName { get { return default(string); } }
    [System.Security.SecurityCriticalAttribute]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial class PrintingCanceledException : System.Printing.PrintJobException {
    public PrintingCanceledException() { }
    public PrintingCanceledException(int errorCode, string message) { }
    public PrintingCanceledException(int errorCode, string message, System.Exception innerException) { }
    public PrintingCanceledException(int errorCode, string message, string printQueueName, string jobName, int jobId) { }
    public PrintingCanceledException(int errorCode, string message, string printQueueName, string jobName, int jobId, System.Exception innerException) { }
    protected PrintingCanceledException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public PrintingCanceledException(string message) { }
    public PrintingCanceledException(string message, System.Exception innerException) { }
  }
  public partial class PrintingNotSupportedException : System.Printing.PrintSystemException {
    public PrintingNotSupportedException() { }
    protected PrintingNotSupportedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public PrintingNotSupportedException(string message) { }
    public PrintingNotSupportedException(string message, System.Exception innerException) { }
    [System.Security.SecurityCriticalAttribute]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial class PrintJobException : System.Printing.PrintSystemException {
    public PrintJobException() { }
    public PrintJobException(int errorCode, string message) { }
    public PrintJobException(int errorCode, string message, System.Exception innerException) { }
    public PrintJobException(int errorCode, string message, string printQueueName, string jobName, int jobId) { }
    public PrintJobException(int errorCode, string message, string printQueueName, string jobName, int jobId, System.Exception innerException) { }
    protected PrintJobException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public PrintJobException(string message) { }
    public PrintJobException(string message, System.Exception innerException) { }
    public int JobId { get { return default(int); } }
    public string JobName { get { return default(string); } }
    public string PrintQueueName { get { return default(string); } }
    [System.Security.SecurityCriticalAttribute]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial class PrintQueueException : System.Printing.PrintSystemException {
    public PrintQueueException() { }
    public PrintQueueException(int errorCode, string message, string printerName) { }
    public PrintQueueException(int errorCode, string message, string printerName, System.Exception innerException) { }
    public PrintQueueException(int errorCode, string message, string printerName, string printerMessage) { }
    protected PrintQueueException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public PrintQueueException(string message) { }
    public PrintQueueException(string message, System.Exception innerException) { }
    public string PrinterName { get { return default(string); } }
    [System.Security.SecurityCriticalAttribute]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial class PrintServerException : System.Printing.PrintSystemException {
    public PrintServerException() { }
    public PrintServerException(int errorCode, string message, string serverName) { }
    public PrintServerException(int errorCode, string message, string serverName, System.Exception innerException) { }
    protected PrintServerException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public PrintServerException(string message) { }
    public PrintServerException(string message, System.Exception innerException) { }
    public string ServerName { get { return default(string); } }
    [System.Security.SecurityCriticalAttribute]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial class PrintSystemException : System.SystemException {
    public PrintSystemException() { }
    public PrintSystemException(int errorCode, string message) { }
    public PrintSystemException(int errorCode, string message, System.Exception innerException) { }
    public PrintSystemException(int errorCode, string message, string printerMessage) { }
    protected PrintSystemException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public PrintSystemException(string message) { }
    public PrintSystemException(string message, System.Exception innerException) { }
    [System.Security.SecurityCriticalAttribute]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public sealed partial class PrintTicket : System.ComponentModel.INotifyPropertyChanged {
    public PrintTicket() { }
    public PrintTicket(System.IO.Stream xmlStream) { }
    public System.Nullable<System.Printing.Collation> Collation { get { return default(System.Nullable<System.Printing.Collation>); } set { } }
    public System.Nullable<System.Int32> CopyCount { get { return default(System.Nullable<System.Int32>); } set { } }
    public System.Nullable<System.Printing.DeviceFontSubstitution> DeviceFontSubstitution { get { return default(System.Nullable<System.Printing.DeviceFontSubstitution>); } set { } }
    public System.Nullable<System.Printing.Duplexing> Duplexing { get { return default(System.Nullable<System.Printing.Duplexing>); } set { } }
    public System.Nullable<System.Printing.InputBin> InputBin { get { return default(System.Nullable<System.Printing.InputBin>); } set { } }
    public System.Nullable<System.Printing.OutputColor> OutputColor { get { return default(System.Nullable<System.Printing.OutputColor>); } set { } }
    public System.Nullable<System.Printing.OutputQuality> OutputQuality { get { return default(System.Nullable<System.Printing.OutputQuality>); } set { } }
    public System.Nullable<System.Printing.PageBorderless> PageBorderless { get { return default(System.Nullable<System.Printing.PageBorderless>); } set { } }
    public System.Printing.PageMediaSize PageMediaSize { get { return default(System.Printing.PageMediaSize); } set { } }
    public System.Nullable<System.Printing.PageMediaType> PageMediaType { get { return default(System.Nullable<System.Printing.PageMediaType>); } set { } }
    public System.Nullable<System.Printing.PageOrder> PageOrder { get { return default(System.Nullable<System.Printing.PageOrder>); } set { } }
    public System.Nullable<System.Printing.PageOrientation> PageOrientation { get { return default(System.Nullable<System.Printing.PageOrientation>); } set { } }
    public System.Printing.PageResolution PageResolution { get { return default(System.Printing.PageResolution); } set { } }
    public System.Nullable<System.Int32> PageScalingFactor { get { return default(System.Nullable<System.Int32>); } set { } }
    public System.Nullable<System.Int32> PagesPerSheet { get { return default(System.Nullable<System.Int32>); } set { } }
    public System.Nullable<System.Printing.PagesPerSheetDirection> PagesPerSheetDirection { get { return default(System.Nullable<System.Printing.PagesPerSheetDirection>); } set { } }
    public System.Nullable<System.Printing.PhotoPrintingIntent> PhotoPrintingIntent { get { return default(System.Nullable<System.Printing.PhotoPrintingIntent>); } set { } }
    public System.Nullable<System.Printing.Stapling> Stapling { get { return default(System.Nullable<System.Printing.Stapling>); } set { } }
    public System.Nullable<System.Printing.TrueTypeFontMode> TrueTypeFontMode { get { return default(System.Nullable<System.Printing.TrueTypeFontMode>); } set { } }
    public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged { add { } remove { } }
    public System.Printing.PrintTicket Clone() { return default(System.Printing.PrintTicket); }
    public System.IO.MemoryStream GetXmlStream() { return default(System.IO.MemoryStream); }
    public void SaveTo(System.IO.Stream outStream) { }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public enum PrintTicketScope {
    DocumentScope = 1,
    JobScope = 2,
    PageScope = 0,
  }
  public enum Stapling {
    None = 10,
    SaddleStitch = 1,
    StapleBottomLeft = 2,
    StapleBottomRight = 3,
    StapleDualBottom = 7,
    StapleDualLeft = 4,
    StapleDualRight = 5,
    StapleDualTop = 6,
    StapleTopLeft = 8,
    StapleTopRight = 9,
    Unknown = 0,
  }
  public enum TrueTypeFontMode {
    Automatic = 1,
    DownloadAsNativeTrueTypeFont = 4,
    DownloadAsOutlineFont = 2,
    DownloadAsRasterFont = 3,
    RenderAsBitmap = 5,
    Unknown = 0,
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct ValidationResult {
    public System.Printing.ConflictStatus ConflictStatus { get { return default(System.Printing.ConflictStatus); } }
    public System.Printing.PrintTicket ValidatedPrintTicket { get { return default(System.Printing.PrintTicket); } }
    public override bool Equals(object o) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Printing.ValidationResult a, System.Printing.ValidationResult b) { return default(bool); }
    public static bool operator !=(System.Printing.ValidationResult a, System.Printing.ValidationResult b) { return default(bool); }
  }
}
namespace System.Printing.Interop {
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public enum BaseDevModeType {
    PrinterDefault = 1,
    UserDefault = 0,
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public sealed partial class PrintTicketConverter : System.IDisposable {
    public PrintTicketConverter(string deviceName, int clientPrintSchemaVersion) { }
    public static int MaxPrintSchemaVersion { get { return default(int); } }
    public System.Printing.PrintTicket ConvertDevModeToPrintTicket(System.Byte[] devMode) { return default(System.Printing.PrintTicket); }
    public System.Printing.PrintTicket ConvertDevModeToPrintTicket(System.Byte[] devMode, System.Printing.PrintTicketScope scope) { return default(System.Printing.PrintTicket); }
    public System.Byte[] ConvertPrintTicketToDevMode(System.Printing.PrintTicket printTicket, System.Printing.Interop.BaseDevModeType baseType) { return default(System.Byte[]); }
    public System.Byte[] ConvertPrintTicketToDevMode(System.Printing.PrintTicket printTicket, System.Printing.Interop.BaseDevModeType baseType, System.Printing.PrintTicketScope scope) { return default(System.Byte[]); }
    public void Dispose() { }
    void System.IDisposable.Dispose() { }
  }
}
namespace System.Windows.Xps {
  public partial class XpsException : System.Exception {
    public XpsException() { }
    protected XpsException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public XpsException(string message) { }
    public XpsException(string message, System.Exception innerException) { }
  }
  public partial class XpsPackagingException : System.Windows.Xps.XpsException {
    public XpsPackagingException() { }
    protected XpsPackagingException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public XpsPackagingException(string message) { }
    public XpsPackagingException(string message, System.Exception innerException) { }
  }
  public partial class XpsSerializationException : System.Windows.Xps.XpsException {
    public XpsSerializationException() { }
    protected XpsSerializationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public XpsSerializationException(string message) { }
    public XpsSerializationException(string message, System.Exception innerException) { }
  }
}
namespace System.Windows.Xps.Packaging {
  public partial interface IDocumentStructureProvider {
    System.Windows.Xps.Packaging.XpsStructure AddDocumentStructure();
  }
  public partial interface IStoryFragmentProvider {
    System.Windows.Xps.Packaging.XpsStructure AddStoryFragment();
  }
  public partial interface IXpsFixedDocumentReader : System.Windows.Xps.Packaging.IDocumentStructureProvider {
    int DocumentNumber { get; }
    System.Windows.Xps.Packaging.XpsStructure DocumentStructure { get; }
    System.Collections.ObjectModel.ReadOnlyCollection<System.Windows.Xps.Packaging.IXpsFixedPageReader> FixedPages { get; }
    System.Printing.PrintTicket PrintTicket { get; }
    System.Collections.Generic.ICollection<System.Windows.Xps.Packaging.XpsSignatureDefinition> SignatureDefinitions { get; }
    System.Windows.Xps.Packaging.XpsThumbnail Thumbnail { get; }
    System.Uri Uri { get; }
    void AddSignatureDefinition(System.Windows.Xps.Packaging.XpsSignatureDefinition signatureDefinition);
    void CommitSignatureDefinition();
    System.Windows.Xps.Packaging.IXpsFixedPageReader GetFixedPage(System.Uri pageSource);
    void RemoveSignatureDefinition(System.Windows.Xps.Packaging.XpsSignatureDefinition signatureDefinition);
  }
  public partial interface IXpsFixedDocumentSequenceReader {
    System.Collections.ObjectModel.ReadOnlyCollection<System.Windows.Xps.Packaging.IXpsFixedDocumentReader> FixedDocuments { get; }
    System.Printing.PrintTicket PrintTicket { get; }
    System.Windows.Xps.Packaging.XpsThumbnail Thumbnail { get; }
    System.Uri Uri { get; }
    System.Windows.Xps.Packaging.IXpsFixedDocumentReader GetFixedDocument(System.Uri documentSource);
  }
  public partial interface IXpsFixedDocumentSequenceWriter {
    System.Printing.PrintTicket PrintTicket { set; }
    System.Uri Uri { get; }
    System.Windows.Xps.Packaging.IXpsFixedDocumentWriter AddFixedDocument();
    System.Windows.Xps.Packaging.XpsThumbnail AddThumbnail(System.Windows.Xps.Packaging.XpsImageType imageType);
    void Commit();
  }
  public partial interface IXpsFixedDocumentWriter : System.Windows.Xps.Packaging.IDocumentStructureProvider {
    int DocumentNumber { get; }
    System.Printing.PrintTicket PrintTicket { set; }
    System.Uri Uri { get; }
    System.Windows.Xps.Packaging.IXpsFixedPageWriter AddFixedPage();
    System.Windows.Xps.Packaging.XpsThumbnail AddThumbnail(System.Windows.Xps.Packaging.XpsImageType imageType);
    void Commit();
  }
  public partial interface IXpsFixedPageReader : System.Windows.Xps.Packaging.IStoryFragmentProvider {
    System.Collections.Generic.ICollection<System.Windows.Xps.Packaging.XpsColorContext> ColorContexts { get; }
    System.Collections.Generic.ICollection<System.Windows.Xps.Packaging.XpsFont> Fonts { get; }
    System.Collections.Generic.ICollection<System.Windows.Xps.Packaging.XpsImage> Images { get; }
    int PageNumber { get; }
    System.Printing.PrintTicket PrintTicket { get; }
    System.Collections.Generic.ICollection<System.Windows.Xps.Packaging.XpsResourceDictionary> ResourceDictionaries { get; }
    System.Windows.Xps.Packaging.XpsStructure StoryFragment { get; }
    System.Windows.Xps.Packaging.XpsThumbnail Thumbnail { get; }
    System.Uri Uri { get; }
    System.Xml.XmlReader XmlReader { get; }
    System.Windows.Xps.Packaging.XpsColorContext GetColorContext(System.Uri uri);
    System.Windows.Xps.Packaging.XpsFont GetFont(System.Uri uri);
    System.Windows.Xps.Packaging.XpsImage GetImage(System.Uri uri);
    System.Windows.Xps.Packaging.XpsResource GetResource(System.Uri resourceUri);
    System.Windows.Xps.Packaging.XpsResourceDictionary GetResourceDictionary(System.Uri uri);
  }
  public partial interface IXpsFixedPageWriter : System.Windows.Xps.Packaging.IStoryFragmentProvider {
    System.Collections.Generic.IList<System.String> LinkTargetStream { get; }
    int PageNumber { get; }
    System.Printing.PrintTicket PrintTicket { set; }
    System.Uri Uri { get; }
    System.Xml.XmlWriter XmlWriter { get; }
    System.Windows.Xps.Packaging.XpsColorContext AddColorContext();
    System.Windows.Xps.Packaging.XpsFont AddFont();
    System.Windows.Xps.Packaging.XpsFont AddFont(bool obfuscate);
    System.Windows.Xps.Packaging.XpsFont AddFont(bool obfuscate, bool addRestrictedRelationship);
    System.Windows.Xps.Packaging.XpsImage AddImage(string mimeType);
    System.Windows.Xps.Packaging.XpsImage AddImage(System.Windows.Xps.Packaging.XpsImageType imageType);
    System.Windows.Xps.Packaging.XpsResource AddResource(System.Type resourceType, System.Uri resourceUri);
    System.Windows.Xps.Packaging.XpsResourceDictionary AddResourceDictionary();
    System.Windows.Xps.Packaging.XpsThumbnail AddThumbnail(System.Windows.Xps.Packaging.XpsImageType imageType);
    void Commit();
  }
  public enum PackageInterleavingOrder {
    ImagesLast = 3,
    None = 0,
    ResourceFirst = 1,
    ResourceLast = 2,
  }
  public enum PackagingAction {
    AddingDocumentSequence = 1,
    AddingFixedDocument = 3,
    AddingFixedPage = 5,
    DocumentSequenceCompleted = 2,
    FixedDocumentCompleted = 4,
    FixedPageCompleted = 6,
    FontAdded = 8,
    ImageAdded = 9,
    None = 0,
    ResourceAdded = 7,
    XpsDocumentCommitted = 10,
  }
  public partial class PackagingProgressEventArgs : System.EventArgs {
    public PackagingProgressEventArgs(System.Windows.Xps.Packaging.PackagingAction action, int numberCompleted) { }
    public System.Windows.Xps.Packaging.PackagingAction Action { get { return default(System.Windows.Xps.Packaging.PackagingAction); } }
    public int NumberCompleted { get { return default(int); } }
  }
  public delegate void PackagingProgressEventHandler(object sender, System.Windows.Xps.Packaging.PackagingProgressEventArgs e);
  public partial class SpotLocation {
    public SpotLocation() { }
    public System.Uri PageUri { get { return default(System.Uri); } set { } }
    public double StartX { get { return default(double); } set { } }
    public double StartY { get { return default(double); } set { } }
  }
  public partial class XpsColorContext : System.Windows.Xps.Packaging.XpsResource {
    internal XpsColorContext() { }
  }
  public partial class XpsDigitalSignature {
    public XpsDigitalSignature(System.IO.Packaging.PackageDigitalSignature packageSignature, System.Windows.Xps.Packaging.XpsDocument package) { }
    public bool DocumentPropertiesRestricted { get { return default(bool); } }
    public System.Nullable<System.Guid> Id { get { return default(System.Nullable<System.Guid>); } }
    public bool IsCertificateAvailable { get { return default(bool); } }
    public bool SignatureOriginRestricted { get { return default(bool); } }
    public string SignatureType { get { return default(string); } }
    public System.Byte[] SignatureValue { get { return default(System.Byte[]); } }
    public System.Windows.Xps.Packaging.IXpsFixedDocumentSequenceReader SignedDocumentSequence { get { return default(System.Windows.Xps.Packaging.IXpsFixedDocumentSequenceReader); } }
    public System.Security.Cryptography.X509Certificates.X509Certificate SignerCertificate { get { return default(System.Security.Cryptography.X509Certificates.X509Certificate); } }
    public System.DateTime SigningTime { get { return default(System.DateTime); } }
    public System.IO.Packaging.VerifyResult Verify() { return default(System.IO.Packaging.VerifyResult); }
    public System.IO.Packaging.VerifyResult Verify(System.Security.Cryptography.X509Certificates.X509Certificate certificate) { return default(System.IO.Packaging.VerifyResult); }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Unrestricted=true)]
    public System.Security.Cryptography.X509Certificates.X509ChainStatusFlags VerifyCertificate() { return default(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags); }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Unrestricted=true)]
    public static System.Security.Cryptography.X509Certificates.X509ChainStatusFlags VerifyCertificate(System.Security.Cryptography.X509Certificates.X509Certificate certificate) { return default(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags); }
  }
  [System.FlagsAttribute]
  public enum XpsDigSigPartAlteringRestrictions {
    Annotations = 2,
    CoreMetadata = 1,
    None = 0,
    SignatureOrigin = 4,
  }
  public partial class XpsDocument : System.Windows.Xps.Packaging.XpsPartBase, System.IDisposable {
    public XpsDocument(System.IO.Packaging.Package package) { }
    public XpsDocument(System.IO.Packaging.Package package, System.IO.Packaging.CompressionOption compressionOption) { }
    public XpsDocument(System.IO.Packaging.Package package, System.IO.Packaging.CompressionOption compressionOption, string path) { }
    public XpsDocument(string path, System.IO.FileAccess packageAccess) { }
    public XpsDocument(string path, System.IO.FileAccess packageAccess, System.IO.Packaging.CompressionOption compressionOption) { }
    public System.IO.Packaging.PackageProperties CoreDocumentProperties { get { return default(System.IO.Packaging.PackageProperties); } }
    public System.Windows.Xps.Packaging.IXpsFixedDocumentSequenceReader FixedDocumentSequenceReader { get { return default(System.Windows.Xps.Packaging.IXpsFixedDocumentSequenceReader); } }
    public bool IsReader { get { return default(bool); } }
    public bool IsSignable { get { return default(bool); } }
    public bool IsWriter { get { return default(bool); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Windows.Xps.Packaging.XpsDigitalSignature> Signatures { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Windows.Xps.Packaging.XpsDigitalSignature>); } }
    public System.Windows.Xps.Packaging.XpsThumbnail Thumbnail { get { return default(System.Windows.Xps.Packaging.XpsThumbnail); } set { } }
    public System.Windows.Xps.Packaging.IXpsFixedDocumentSequenceWriter AddFixedDocumentSequence() { return default(System.Windows.Xps.Packaging.IXpsFixedDocumentSequenceWriter); }
    public System.Windows.Xps.Packaging.XpsThumbnail AddThumbnail(System.Windows.Xps.Packaging.XpsImageType imageType) { return default(System.Windows.Xps.Packaging.XpsThumbnail); }
    public void Close() { }
    public static System.Windows.Xps.XpsDocumentWriter CreateXpsDocumentWriter(System.Windows.Xps.Packaging.XpsDocument xpsDocument) { return default(System.Windows.Xps.XpsDocumentWriter); }
    protected virtual void Dispose(bool disposing) { }
    public System.Windows.Documents.FixedDocumentSequence GetFixedDocumentSequence() { return default(System.Windows.Documents.FixedDocumentSequence); }
    public void RemoveSignature(System.Windows.Xps.Packaging.XpsDigitalSignature signature) { }
    public System.Windows.Xps.Packaging.XpsDigitalSignature SignDigitally(System.Security.Cryptography.X509Certificates.X509Certificate certificate, bool embedCertificate, System.Windows.Xps.Packaging.XpsDigSigPartAlteringRestrictions restrictions) { return default(System.Windows.Xps.Packaging.XpsDigitalSignature); }
    public System.Windows.Xps.Packaging.XpsDigitalSignature SignDigitally(System.Security.Cryptography.X509Certificates.X509Certificate certificate, bool embedCertificate, System.Windows.Xps.Packaging.XpsDigSigPartAlteringRestrictions restrictions, System.Guid id) { return default(System.Windows.Xps.Packaging.XpsDigitalSignature); }
    public System.Windows.Xps.Packaging.XpsDigitalSignature SignDigitally(System.Security.Cryptography.X509Certificates.X509Certificate certificate, bool embedCertificate, System.Windows.Xps.Packaging.XpsDigSigPartAlteringRestrictions restrictions, System.Guid id, bool testIsSignable) { return default(System.Windows.Xps.Packaging.XpsDigitalSignature); }
    void System.IDisposable.Dispose() { }
  }
  public partial class XpsFont : System.Windows.Xps.Packaging.XpsResource {
    internal XpsFont() { }
    public bool IsObfuscated { get { return default(bool); } }
    public bool IsRestricted { get { return default(bool); } set { } }
    public static void ObfuscateFontData(System.Byte[] fontData, System.Guid guid) { }
  }
  public partial class XpsImage : System.Windows.Xps.Packaging.XpsResource {
    internal XpsImage() { }
  }
  public enum XpsImageType {
    JpegImageType = 1,
    PngImageType = 0,
    TiffImageType = 2,
    WdpImageType = 3,
  }
  public abstract partial class XpsPartBase {
    internal XpsPartBase() { }
    public System.Uri Uri { get { return default(System.Uri); } set { } }
  }
  public partial class XpsResource : System.Windows.Xps.Packaging.XpsPartBase, System.IDisposable {
    internal XpsResource() { }
    public void Commit() { }
    public virtual System.IO.Stream GetStream() { return default(System.IO.Stream); }
    public System.Uri RelativeUri(System.Uri inUri) { return default(System.Uri); }
    void System.IDisposable.Dispose() { }
  }
  public partial class XpsResourceDictionary : System.Windows.Xps.Packaging.XpsResource {
    internal XpsResourceDictionary() { }
  }
  public enum XpsResourceSharing {
    NoResourceSharing = 1,
    ShareResources = 0,
  }
  public partial class XpsSignatureDefinition {
    public XpsSignatureDefinition() { }
    public System.Globalization.CultureInfo Culture { get { return default(System.Globalization.CultureInfo); } set { } }
    public bool HasBeenModified { get { return default(bool); } set { } }
    public string Intent { get { return default(string); } set { } }
    public string RequestedSigner { get { return default(string); } set { } }
    public System.Nullable<System.DateTime> SignBy { get { return default(System.Nullable<System.DateTime>); } set { } }
    public string SigningLocale { get { return default(string); } set { } }
    public System.Nullable<System.Guid> SpotId { get { return default(System.Nullable<System.Guid>); } set { } }
    public System.Windows.Xps.Packaging.SpotLocation SpotLocation { get { return default(System.Windows.Xps.Packaging.SpotLocation); } set { } }
  }
  public partial class XpsStructure : System.Windows.Xps.Packaging.XpsResource {
    internal XpsStructure() { }
  }
  public partial class XpsThumbnail : System.Windows.Xps.Packaging.XpsResource {
    internal XpsThumbnail() { }
  }
}
namespace System.Windows.Xps.Serialization {
  public abstract partial class BasePackagingPolicy : System.IDisposable {
    protected BasePackagingPolicy() { }
    public abstract System.Uri CurrentFixedDocumentUri { get; }
    public abstract System.Uri CurrentFixedPageUri { get; }
    public abstract System.Windows.Xps.Serialization.XpsResourceStream AcquireResourceStreamForXpsColorContext(string resourceId);
    public abstract System.Windows.Xps.Serialization.XpsResourceStream AcquireResourceStreamForXpsFont();
    public abstract System.Windows.Xps.Serialization.XpsResourceStream AcquireResourceStreamForXpsFont(string resourceId);
    public abstract System.Windows.Xps.Serialization.XpsResourceStream AcquireResourceStreamForXpsImage(string resourceId);
    public abstract System.Windows.Xps.Serialization.XpsResourceStream AcquireResourceStreamForXpsResourceDictionary(string resourceId);
    public abstract System.Collections.Generic.IList<System.String> AcquireStreamForLinkTargets();
    public abstract System.Xml.XmlWriter AcquireXmlWriterForFixedDocument();
    public abstract System.Xml.XmlWriter AcquireXmlWriterForFixedDocumentSequence();
    public abstract System.Xml.XmlWriter AcquireXmlWriterForFixedPage();
    public abstract System.Xml.XmlWriter AcquireXmlWriterForPage();
    public abstract System.Xml.XmlWriter AcquireXmlWriterForResourceDictionary();
    public abstract void PersistPrintTicket(System.Printing.PrintTicket printTicket);
    public abstract void PreCommitCurrentPage();
    public abstract void RelateResourceToCurrentPage(System.Uri targetUri, string relationshipName);
    public abstract void RelateRestrictedFontToCurrentDocument(System.Uri targetUri);
    public abstract void ReleaseResourceStreamForXpsColorContext();
    public abstract void ReleaseResourceStreamForXpsFont();
    public abstract void ReleaseResourceStreamForXpsFont(string resourceId);
    public abstract void ReleaseResourceStreamForXpsImage();
    public abstract void ReleaseResourceStreamForXpsResourceDictionary();
    public abstract void ReleaseXmlWriterForFixedDocument();
    public abstract void ReleaseXmlWriterForFixedDocumentSequence();
    public abstract void ReleaseXmlWriterForFixedPage();
    void System.IDisposable.Dispose() { }
  }
  public partial class ColorTypeConverter : System.ComponentModel.ExpandableObjectConverter {
    public ColorTypeConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
    public override System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public static string SerializeColorContext(System.IServiceProvider context, System.Windows.Media.ColorContext colorContext) { return default(string); }
  }
  [System.FlagsAttribute]
  public enum FontSubsetterCommitPolicies {
    CommitEntireSequence = 3,
    CommitPerDocument = 2,
    CommitPerPage = 1,
    None = 0,
  }
  public partial class FontTypeConverter : System.ComponentModel.ExpandableObjectConverter {
    public FontTypeConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
    public override System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes) { return default(System.ComponentModel.PropertyDescriptorCollection); }
  }
  public partial class ImageSourceTypeConverter : System.ComponentModel.ExpandableObjectConverter {
    public ImageSourceTypeConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.SecurityTreatAsSafeAttribute]
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
    public override System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes) { return default(System.ComponentModel.PropertyDescriptorCollection); }
  }
  public abstract partial class PackageSerializationManager : System.IDisposable {
    [System.Security.SecurityCriticalAttribute]
    protected PackageSerializationManager() { }
    public abstract void SaveAsXaml(object serializedObject);
    void System.IDisposable.Dispose() { }
  }
  public enum PrintTicketLevel {
    FixedDocumentPrintTicket = 2,
    FixedDocumentSequencePrintTicket = 1,
    FixedPagePrintTicket = 3,
    None = 0,
  }
  public enum SerializationState {
    Normal = 0,
    Stop = 1,
  }
  public partial class XpsPackagingPolicy : System.Windows.Xps.Serialization.BasePackagingPolicy {
    public XpsPackagingPolicy(System.Windows.Xps.Packaging.XpsDocument xpsPackage) { }
    public XpsPackagingPolicy(System.Windows.Xps.Packaging.XpsDocument xpsPackage, System.Windows.Xps.Packaging.PackageInterleavingOrder interleavingType) { }
    public override System.Uri CurrentFixedDocumentUri { get { return default(System.Uri); } }
    public override System.Uri CurrentFixedPageUri { get { return default(System.Uri); } }
    public event System.Windows.Xps.Packaging.PackagingProgressEventHandler PackagingProgressEvent { add { } remove { } }
    public override System.Windows.Xps.Serialization.XpsResourceStream AcquireResourceStreamForXpsColorContext(string resourceId) { return default(System.Windows.Xps.Serialization.XpsResourceStream); }
    public override System.Windows.Xps.Serialization.XpsResourceStream AcquireResourceStreamForXpsFont() { return default(System.Windows.Xps.Serialization.XpsResourceStream); }
    public override System.Windows.Xps.Serialization.XpsResourceStream AcquireResourceStreamForXpsFont(string resourceId) { return default(System.Windows.Xps.Serialization.XpsResourceStream); }
    public override System.Windows.Xps.Serialization.XpsResourceStream AcquireResourceStreamForXpsImage(string resourceId) { return default(System.Windows.Xps.Serialization.XpsResourceStream); }
    public override System.Windows.Xps.Serialization.XpsResourceStream AcquireResourceStreamForXpsResourceDictionary(string resourceId) { return default(System.Windows.Xps.Serialization.XpsResourceStream); }
    public override System.Collections.Generic.IList<System.String> AcquireStreamForLinkTargets() { return default(System.Collections.Generic.IList<System.String>); }
    public override System.Xml.XmlWriter AcquireXmlWriterForFixedDocument() { return default(System.Xml.XmlWriter); }
    public override System.Xml.XmlWriter AcquireXmlWriterForFixedDocumentSequence() { return default(System.Xml.XmlWriter); }
    public override System.Xml.XmlWriter AcquireXmlWriterForFixedPage() { return default(System.Xml.XmlWriter); }
    public override System.Xml.XmlWriter AcquireXmlWriterForPage() { return default(System.Xml.XmlWriter); }
    public override System.Xml.XmlWriter AcquireXmlWriterForResourceDictionary() { return default(System.Xml.XmlWriter); }
    public override void PersistPrintTicket(System.Printing.PrintTicket printTicket) { }
    public override void PreCommitCurrentPage() { }
    public override void RelateResourceToCurrentPage(System.Uri targetUri, string relationshipName) { }
    public override void RelateRestrictedFontToCurrentDocument(System.Uri targetUri) { }
    public override void ReleaseResourceStreamForXpsColorContext() { }
    public override void ReleaseResourceStreamForXpsFont() { }
    public override void ReleaseResourceStreamForXpsFont(string resourceId) { }
    public override void ReleaseResourceStreamForXpsImage() { }
    public override void ReleaseResourceStreamForXpsResourceDictionary() { }
    public override void ReleaseXmlWriterForFixedDocument() { }
    public override void ReleaseXmlWriterForFixedDocumentSequence() { }
    public override void ReleaseXmlWriterForFixedPage() { }
  }
  public partial class XpsResourceStream {
    public XpsResourceStream(System.IO.Stream stream, System.Uri uri) { }
    public System.IO.Stream Stream { get { return default(System.IO.Stream); } }
    public System.Uri Uri { get { return default(System.Uri); } }
    public void Initialize() { }
  }
  public partial class XpsSerializationCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    public XpsSerializationCompletedEventArgs(bool canceled, object state, System.Exception exception) { }
  }
  public delegate void XpsSerializationCompletedEventHandler(object sender, System.Windows.Xps.Serialization.XpsSerializationCompletedEventArgs e);
  public partial class XpsSerializationManager : System.Windows.Xps.Serialization.PackageSerializationManager {
    public XpsSerializationManager(System.Windows.Xps.Serialization.BasePackagingPolicy packagingPolicy, bool batchMode) { }
    public bool IsBatchMode { get { return default(bool); } }
    public event System.Windows.Xps.Serialization.XpsSerializationPrintTicketRequiredEventHandler XpsSerializationPrintTicketRequired { add { } remove { } }
    public event System.Windows.Xps.Serialization.XpsSerializationProgressChangedEventHandler XpsSerializationProgressChanged { add { } remove { } }
    public virtual void Commit() { }
    public override void SaveAsXaml(object serializedObject) { }
    public void SetFontSubsettingCountPolicy(int countPolicy) { }
    public void SetFontSubsettingPolicy(System.Windows.Xps.Serialization.FontSubsetterCommitPolicies policy) { }
  }
  public sealed partial class XpsSerializationManagerAsync : System.Windows.Xps.Serialization.XpsSerializationManager {
    public XpsSerializationManagerAsync(System.Windows.Xps.Serialization.BasePackagingPolicy packagingPolicy, bool batchMode) : base (default(System.Windows.Xps.Serialization.BasePackagingPolicy), default(bool)) { }
    public event System.Windows.Xps.Serialization.XpsSerializationCompletedEventHandler XpsSerializationCompleted { add { } remove { } }
    public void CancelAsync() { }
    public override void Commit() { }
    public override void SaveAsXaml(object serializedObject) { }
  }
  public partial class XpsSerializationPrintTicketRequiredEventArgs : System.EventArgs {
    public XpsSerializationPrintTicketRequiredEventArgs(System.Windows.Xps.Serialization.PrintTicketLevel printTicketLevel, int sequence) { }
    public System.Printing.PrintTicket PrintTicket { get { return default(System.Printing.PrintTicket); } set { } }
    public System.Windows.Xps.Serialization.PrintTicketLevel PrintTicketLevel { get { return default(System.Windows.Xps.Serialization.PrintTicketLevel); } }
    public int Sequence { get { return default(int); } }
  }
  public delegate void XpsSerializationPrintTicketRequiredEventHandler(object sender, System.Windows.Xps.Serialization.XpsSerializationPrintTicketRequiredEventArgs e);
  public partial class XpsSerializationProgressChangedEventArgs : System.ComponentModel.ProgressChangedEventArgs {
    public XpsSerializationProgressChangedEventArgs(System.Windows.Xps.Serialization.XpsWritingProgressChangeLevel writingLevel, int pageNumber, int progressPercentage, object userToken) : base (default(int), default(object)) { }
    public int PageNumber { get { return default(int); } }
    public System.Windows.Xps.Serialization.XpsWritingProgressChangeLevel WritingLevel { get { return default(System.Windows.Xps.Serialization.XpsWritingProgressChangeLevel); } }
  }
  public delegate void XpsSerializationProgressChangedEventHandler(object sender, System.Windows.Xps.Serialization.XpsSerializationProgressChangedEventArgs e);
  public sealed partial class XpsSerializerFactory : System.Windows.Documents.Serialization.ISerializerFactory {
    public XpsSerializerFactory() { }
    public string DefaultFileExtension { get { return default(string); } }
    public string DisplayName { get { return default(string); } }
    public string ManufacturerName { get { return default(string); } }
    public System.Uri ManufacturerWebsite { get { return default(System.Uri); } }
    public System.Windows.Documents.Serialization.SerializerWriter CreateSerializerWriter(System.IO.Stream stream) { return default(System.Windows.Documents.Serialization.SerializerWriter); }
  }
  public enum XpsWritingProgressChangeLevel {
    FixedDocumentSequenceWritingProgress = 1,
    FixedDocumentWritingProgress = 2,
    FixedPageWritingProgress = 3,
    None = 0,
  }
}
