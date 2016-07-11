namespace Microsoft.VisualBasic {
  public enum AppWinStyle : short {
    Hide = (short)0,
    MaximizedFocus = (short)3,
    MinimizedFocus = (short)2,
    MinimizedNoFocus = (short)6,
    NormalFocus = (short)1,
    NormalNoFocus = (short)4,
  }
  public enum AudioPlayMode : short {
    Background = (short)1,
    BackgroundLoop = (short)2,
    WaitToComplete = (short)0,
  }
  public enum CallType {
    Get = 2,
    Let = 4,
    Method = 1,
    Set = 8,
  }
  [System.Diagnostics.DebuggerDisplayAttribute("Count = {Count}")]
  [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(Microsoft.VisualBasic.Collection.CollectionDebugView))]
  public sealed partial class Collection : System.Collections.ICollection, System.Collections.IList, System.Runtime.Serialization.IDeserializationCallback, System.Runtime.Serialization.ISerializable {
    public Collection() { }
    public int Count { get { return default(int); } }
    int IList_Count { get { return default(int); } }
    [System.Runtime.CompilerServices.IndexerName("IList_Item")]
    object this[int index] { get { return default(object); } set { } }
    bool IsFixedSize { get { return default(bool); } }
    bool IsReadOnly { get { return default(bool); } }
    bool IsSynchronized { get { return default(bool); } }
    public object this[int Index] { get { return default(object); } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public object this[object Index] { get { return default(object); } }
    public object this[string Key] { get { return default(object); } }
    object SyncRoot { get { return default(object); } }
    public void Add(object Item, string Key=null, object Before=null, object After=null) { }
    public void Clear() { }
    public bool Contains(string Key) { return default(bool); }
    void CopyTo(System.Array array, int index) { }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    System.Collections.IEnumerator IEnumerable_GetEnumerator() { return default(System.Collections.IEnumerator); }
    int IList_Add(object value) { return default(int); }
    void IList_Clear() { }
    bool IListContains(object value) { return default(bool); }
    int IndexOf(object value) { return default(int); }
    void Insert(int index, object value) { }
    void OnDeserialization(object sender) { }
    public void Remove(int Index) { }
    void Remove(object value) { }
    public void Remove(string Key) { }
    void RemoveAt(int index) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), Inherited=false, AllowMultiple=false)]
  public sealed partial class ComClassAttribute : System.Attribute {
    public ComClassAttribute() { }
    public ComClassAttribute(string _ClassID) { }
    public ComClassAttribute(string _ClassID, string _InterfaceID) { }
    public ComClassAttribute(string _ClassID, string _InterfaceID, string _EventID) { }
    public string ClassID { get { return default(string); } }
    public string EventID { get { return default(string); } }
    public string InterfaceID { get { return default(string); } }
    public bool InterfaceShadows { get { return default(bool); } set { } }
  }
  public enum CompareMethod {
    Binary = 0,
    Text = 1,
  }
  [Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute]
  public sealed partial class Constants {
    public const Microsoft.VisualBasic.MsgBoxResult vbAbort = 3;
    public const Microsoft.VisualBasic.MsgBoxStyle vbAbortRetryIgnore = 2;
    public const Microsoft.VisualBasic.MsgBoxStyle vbApplicationModal = 0;
    public const Microsoft.VisualBasic.FileAttribute vbArchive = 32;
    public const Microsoft.VisualBasic.VariantType vbArray = 8192;
    public const string vbBack = "\b";
    public const Microsoft.VisualBasic.CompareMethod vbBinaryCompare = 0;
    public const Microsoft.VisualBasic.VariantType vbBoolean = 11;
    public const Microsoft.VisualBasic.VariantType vbByte = 17;
    public const Microsoft.VisualBasic.MsgBoxResult vbCancel = 2;
    public const string vbCr = "\r";
    public const Microsoft.VisualBasic.MsgBoxStyle vbCritical = 16;
    public const string vbCrLf = "\r\n";
    public const Microsoft.VisualBasic.VariantType vbCurrency = 6;
    public const Microsoft.VisualBasic.VariantType vbDate = 7;
    public const Microsoft.VisualBasic.VariantType vbDecimal = 14;
    public const Microsoft.VisualBasic.MsgBoxStyle vbDefaultButton1 = 0;
    public const Microsoft.VisualBasic.MsgBoxStyle vbDefaultButton2 = 256;
    public const Microsoft.VisualBasic.MsgBoxStyle vbDefaultButton3 = 512;
    public const Microsoft.VisualBasic.FileAttribute vbDirectory = 16;
    public const Microsoft.VisualBasic.VariantType vbDouble = 5;
    public const Microsoft.VisualBasic.VariantType vbEmpty = 0;
    public const Microsoft.VisualBasic.MsgBoxStyle vbExclamation = 48;
    public const Microsoft.VisualBasic.TriState vbFalse = 0;
    public const Microsoft.VisualBasic.FirstWeekOfYear vbFirstFourDays = 2;
    public const Microsoft.VisualBasic.FirstWeekOfYear vbFirstFullWeek = 3;
    public const Microsoft.VisualBasic.FirstWeekOfYear vbFirstJan1 = 1;
    public const string vbFormFeed = "\f";
    public const Microsoft.VisualBasic.FirstDayOfWeek vbFriday = 6;
    public const Microsoft.VisualBasic.DateFormat vbGeneralDate = 0;
    public const Microsoft.VisualBasic.CallType vbGet = 2;
    public const Microsoft.VisualBasic.FileAttribute vbHidden = 2;
    public const Microsoft.VisualBasic.AppWinStyle vbHide = (short)0;
    public const Microsoft.VisualBasic.VbStrConv vbHiragana = 32;
    public const Microsoft.VisualBasic.MsgBoxResult vbIgnore = 5;
    public const Microsoft.VisualBasic.MsgBoxStyle vbInformation = 64;
    public const Microsoft.VisualBasic.VariantType vbInteger = 3;
    public const Microsoft.VisualBasic.VbStrConv vbKatakana = 16;
    public const Microsoft.VisualBasic.CallType vbLet = 4;
    public const string vbLf = "\n";
    public const Microsoft.VisualBasic.VbStrConv vbLinguisticCasing = 1024;
    public const Microsoft.VisualBasic.VariantType vbLong = 20;
    public const Microsoft.VisualBasic.DateFormat vbLongDate = 1;
    public const Microsoft.VisualBasic.DateFormat vbLongTime = 3;
    public const Microsoft.VisualBasic.VbStrConv vbLowerCase = 2;
    public const Microsoft.VisualBasic.AppWinStyle vbMaximizedFocus = (short)3;
    public const Microsoft.VisualBasic.CallType vbMethod = 1;
    public const Microsoft.VisualBasic.AppWinStyle vbMinimizedFocus = (short)2;
    public const Microsoft.VisualBasic.AppWinStyle vbMinimizedNoFocus = (short)6;
    public const Microsoft.VisualBasic.FirstDayOfWeek vbMonday = 2;
    public const Microsoft.VisualBasic.MsgBoxStyle vbMsgBoxHelp = 16384;
    public const Microsoft.VisualBasic.MsgBoxStyle vbMsgBoxRight = 524288;
    public const Microsoft.VisualBasic.MsgBoxStyle vbMsgBoxRtlReading = 1048576;
    public const Microsoft.VisualBasic.MsgBoxStyle vbMsgBoxSetForeground = 65536;
    public const Microsoft.VisualBasic.VbStrConv vbNarrow = 8;
    public const string vbNewLine = "\r\n";
    public const Microsoft.VisualBasic.MsgBoxResult vbNo = 7;
    public const Microsoft.VisualBasic.FileAttribute vbNormal = 0;
    public const Microsoft.VisualBasic.AppWinStyle vbNormalFocus = (short)1;
    public const Microsoft.VisualBasic.AppWinStyle vbNormalNoFocus = (short)4;
    public const Microsoft.VisualBasic.VariantType vbNull = 1;
    public const string vbNullChar = "\0";
    public const string vbNullString = null;
    public const Microsoft.VisualBasic.VariantType vbObject = 9;
    public const int vbObjectError = -2147221504;
    public const Microsoft.VisualBasic.MsgBoxResult vbOK = 1;
    public const Microsoft.VisualBasic.MsgBoxStyle vbOKCancel = 1;
    public const Microsoft.VisualBasic.MsgBoxStyle vbOKOnly = 0;
    public const Microsoft.VisualBasic.VbStrConv vbProperCase = 3;
    public const Microsoft.VisualBasic.MsgBoxStyle vbQuestion = 32;
    public const Microsoft.VisualBasic.FileAttribute vbReadOnly = 1;
    public const Microsoft.VisualBasic.MsgBoxResult vbRetry = 4;
    public const Microsoft.VisualBasic.MsgBoxStyle vbRetryCancel = 5;
    public const Microsoft.VisualBasic.FirstDayOfWeek vbSaturday = 7;
    public const Microsoft.VisualBasic.CallType vbSet = 8;
    public const Microsoft.VisualBasic.DateFormat vbShortDate = 2;
    public const Microsoft.VisualBasic.DateFormat vbShortTime = 4;
    public const Microsoft.VisualBasic.VbStrConv vbSimplifiedChinese = 256;
    public const Microsoft.VisualBasic.VariantType vbSingle = 4;
    public const Microsoft.VisualBasic.VariantType vbString = 8;
    public const Microsoft.VisualBasic.FirstDayOfWeek vbSunday = 1;
    public const Microsoft.VisualBasic.FileAttribute vbSystem = 4;
    public const Microsoft.VisualBasic.MsgBoxStyle vbSystemModal = 4096;
    public const string vbTab = "\t";
    public const Microsoft.VisualBasic.CompareMethod vbTextCompare = 1;
    public const Microsoft.VisualBasic.FirstDayOfWeek vbThursday = 5;
    public const Microsoft.VisualBasic.VbStrConv vbTraditionalChinese = 512;
    public const Microsoft.VisualBasic.TriState vbTrue = -1;
    public const Microsoft.VisualBasic.FirstDayOfWeek vbTuesday = 3;
    public const Microsoft.VisualBasic.VbStrConv vbUpperCase = 1;
    public const Microsoft.VisualBasic.TriState vbUseDefault = -2;
    public const Microsoft.VisualBasic.VariantType vbUserDefinedType = 36;
    public const Microsoft.VisualBasic.FirstWeekOfYear vbUseSystem = 0;
    public const Microsoft.VisualBasic.FirstDayOfWeek vbUseSystemDayOfWeek = 0;
    public const Microsoft.VisualBasic.VariantType vbVariant = 12;
    public const string vbVerticalTab = "\v";
    public const Microsoft.VisualBasic.FileAttribute vbVolume = 8;
    public const Microsoft.VisualBasic.FirstDayOfWeek vbWednesday = 4;
    public const Microsoft.VisualBasic.VbStrConv vbWide = 4;
    public const Microsoft.VisualBasic.MsgBoxResult vbYes = 6;
    public const Microsoft.VisualBasic.MsgBoxStyle vbYesNo = 4;
    public const Microsoft.VisualBasic.MsgBoxStyle vbYesNoCancel = 3;
    public Constants() { }
  }
  public sealed partial class ControlChars {
    public const char Back = '\b';
    public const char Cr = '\r';
    public const string CrLf = "\r\n";
    public const char FormFeed = '\f';
    public const char Lf = '\n';
    public const string NewLine = "\r\n";
    public const char NullChar = '\0';
    public const char Quote = '"';
    public const char Tab = '\t';
    public const char VerticalTab = '\v';
    public ControlChars() { }
  }
  [Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute]
  public sealed partial class Conversion {
    public Conversion() { }
    public static string ErrorToString() { return default(string); }
    public static string ErrorToString(int ErrorNumber) { return default(string); }
    public static decimal Fix(decimal Number) { return default(decimal); }
    public static double Fix(double Number) { return default(double); }
    public static short Fix(short Number) { return default(short); }
    public static int Fix(int Number) { return default(int); }
    public static long Fix(long Number) { return default(long); }
    public static object Fix(object Number) { return default(object); }
    public static float Fix(float Number) { return default(float); }
    public static string Hex(byte Number) { return default(string); }
    public static string Hex(short Number) { return default(string); }
    public static string Hex(int Number) { return default(string); }
    public static string Hex(long Number) { return default(string); }
    public static string Hex(object Number) { return default(string); }
    [System.CLSCompliantAttribute(false)]
    public static string Hex(sbyte Number) { return default(string); }
    [System.CLSCompliantAttribute(false)]
    public static string Hex(ushort Number) { return default(string); }
    [System.CLSCompliantAttribute(false)]
    public static string Hex(uint Number) { return default(string); }
    [System.CLSCompliantAttribute(false)]
    public static string Hex(ulong Number) { return default(string); }
    public static decimal Int(decimal Number) { return default(decimal); }
    public static double Int(double Number) { return default(double); }
    public static short Int(short Number) { return default(short); }
    public static int Int(int Number) { return default(int); }
    public static long Int(long Number) { return default(long); }
    public static object Int(object Number) { return default(object); }
    public static float Int(float Number) { return default(float); }
    public static string Oct(byte Number) { return default(string); }
    public static string Oct(short Number) { return default(string); }
    public static string Oct(int Number) { return default(string); }
    public static string Oct(long Number) { return default(string); }
    public static string Oct(object Number) { return default(string); }
    [System.CLSCompliantAttribute(false)]
    public static string Oct(sbyte Number) { return default(string); }
    [System.CLSCompliantAttribute(false)]
    public static string Oct(ushort Number) { return default(string); }
    [System.CLSCompliantAttribute(false)]
    public static string Oct(uint Number) { return default(string); }
    [System.CLSCompliantAttribute(false)]
    public static string Oct(ulong Number) { return default(string); }
    public static string Str(object Number) { return default(string); }
    public static int Val(char Expression) { return default(int); }
    public static double Val(object Expression) { return default(double); }
    public static double Val(string InputStr) { return default(double); }
  }
  [Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute]
  public sealed partial class DateAndTime {
    public DateAndTime() { }
    public static string DateString { get { return default(string); } set { } }
    public static System.DateTime Now { get { return default(System.DateTime); } }
    public static System.DateTime TimeOfDay { get { return default(System.DateTime); } set { } }
    public static double Timer { get { return default(double); } }
    public static string TimeString { get { return default(string); } set { } }
    public static System.DateTime Today { get { return default(System.DateTime); } set { } }
    public static System.DateTime DateAdd(Microsoft.VisualBasic.DateInterval Interval, double Number, System.DateTime DateValue) { return default(System.DateTime); }
    public static System.DateTime DateAdd(string Interval, double Number, object DateValue) { return default(System.DateTime); }
    public static long DateDiff(Microsoft.VisualBasic.DateInterval Interval, System.DateTime Date1, System.DateTime Date2, Microsoft.VisualBasic.FirstDayOfWeek DayOfWeek=(Microsoft.VisualBasic.FirstDayOfWeek)(1), Microsoft.VisualBasic.FirstWeekOfYear WeekOfYear=(Microsoft.VisualBasic.FirstWeekOfYear)(1)) { return default(long); }
    public static long DateDiff(string Interval, object Date1, object Date2, Microsoft.VisualBasic.FirstDayOfWeek DayOfWeek=(Microsoft.VisualBasic.FirstDayOfWeek)(1), Microsoft.VisualBasic.FirstWeekOfYear WeekOfYear=(Microsoft.VisualBasic.FirstWeekOfYear)(1)) { return default(long); }
    public static int DatePart(Microsoft.VisualBasic.DateInterval Interval, System.DateTime DateValue, Microsoft.VisualBasic.FirstDayOfWeek FirstDayOfWeekValue=(Microsoft.VisualBasic.FirstDayOfWeek)(1), Microsoft.VisualBasic.FirstWeekOfYear FirstWeekOfYearValue=(Microsoft.VisualBasic.FirstWeekOfYear)(1)) { return default(int); }
    public static int DatePart(string Interval, object DateValue, Microsoft.VisualBasic.FirstDayOfWeek DayOfWeek=(Microsoft.VisualBasic.FirstDayOfWeek)(1), Microsoft.VisualBasic.FirstWeekOfYear WeekOfYear=(Microsoft.VisualBasic.FirstWeekOfYear)(1)) { return default(int); }
    public static System.DateTime DateSerial(int Year, int Month, int Day) { return default(System.DateTime); }
    public static System.DateTime DateValue(string StringDate) { return default(System.DateTime); }
    public static int Day(System.DateTime DateValue) { return default(int); }
    public static int Hour(System.DateTime TimeValue) { return default(int); }
    public static int Minute(System.DateTime TimeValue) { return default(int); }
    public static int Month(System.DateTime DateValue) { return default(int); }
    public static string MonthName(int Month, bool Abbreviate=false) { return default(string); }
    public static int Second(System.DateTime TimeValue) { return default(int); }
    public static System.DateTime TimeSerial(int Hour, int Minute, int Second) { return default(System.DateTime); }
    public static System.DateTime TimeValue(string StringTime) { return default(System.DateTime); }
    public static int Weekday(System.DateTime DateValue, Microsoft.VisualBasic.FirstDayOfWeek DayOfWeek=(Microsoft.VisualBasic.FirstDayOfWeek)(1)) { return default(int); }
    public static string WeekdayName(int Weekday, bool Abbreviate=false, Microsoft.VisualBasic.FirstDayOfWeek FirstDayOfWeekValue=(Microsoft.VisualBasic.FirstDayOfWeek)(0)) { return default(string); }
    public static int Year(System.DateTime DateValue) { return default(int); }
  }
  public enum DateFormat {
    GeneralDate = 0,
    LongDate = 1,
    LongTime = 3,
    ShortDate = 2,
    ShortTime = 4,
  }
  public enum DateInterval {
    Day = 4,
    DayOfYear = 3,
    Hour = 7,
    Minute = 8,
    Month = 2,
    Quarter = 1,
    Second = 9,
    Weekday = 6,
    WeekOfYear = 5,
    Year = 0,
  }
  public enum DueDate {
    BegOfPeriod = 1,
    EndOfPeriod = 0,
  }
  public sealed partial class ErrObject {
    internal ErrObject() { }
    public string Description { get { return default(string); } set { } }
    public int Erl { get { return default(int); } }
    public int HelpContext { get { return default(int); } set { } }
    public string HelpFile { get { return default(string); } set { } }
    public int LastDllError { get { return default(int); } }
    public int Number { get { return default(int); } set { } }
    public string Source { get { return default(string); } set { } }
    [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(2))]
    public void Clear() { }
    public System.Exception GetException() { return default(System.Exception); }
    public void Raise(int Number, object Source=null, object Description=null, object HelpFile=null, object HelpContext=null) { }
  }
  [System.FlagsAttribute]
  public enum FileAttribute {
    Archive = 32,
    Directory = 16,
    Hidden = 2,
    Normal = 0,
    ReadOnly = 1,
    System = 4,
    Volume = 8,
  }
  [Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute]
  public sealed partial class FileSystem {
    public FileSystem() { }
    public static void ChDir(string Path) { }
    public static void ChDrive(char Drive) { }
    public static void ChDrive(string Drive) { }
    public static string CurDir() { return default(string); }
    public static string CurDir(char Drive) { return default(string); }
    public static string Dir() { return default(string); }
    public static string Dir(string Pathname, Microsoft.VisualBasic.FileAttribute Attributes=(Microsoft.VisualBasic.FileAttribute)(0)) { return default(string); }
    public static bool EOF(int FileNumber) { return default(bool); }
    public static Microsoft.VisualBasic.OpenMode FileAttr(int FileNumber) { return default(Microsoft.VisualBasic.OpenMode); }
    public static void FileClose(params System.Int32[] FileNumbers) { }
    public static void FileCopy(string Source, string Destination) { }
    public static System.DateTime FileDateTime(string PathName) { return default(System.DateTime); }
    public static void FileGet(int FileNumber, ref System.Array Value, long RecordNumber=(long)-1, bool ArrayIsDynamic=false, bool StringIsFixedLength=false) { }
    public static void FileGet(int FileNumber, ref bool Value, long RecordNumber=(long)-1) { }
    public static void FileGet(int FileNumber, ref byte Value, long RecordNumber=(long)-1) { }
    public static void FileGet(int FileNumber, ref char Value, long RecordNumber=(long)-1) { }
    public static void FileGet(int FileNumber, ref System.DateTime Value, long RecordNumber=(long)-1) { }
    public static void FileGet(int FileNumber, ref decimal Value, long RecordNumber=(long)-1) { }
    public static void FileGet(int FileNumber, ref double Value, long RecordNumber=(long)-1) { }
    public static void FileGet(int FileNumber, ref short Value, long RecordNumber=(long)-1) { }
    public static void FileGet(int FileNumber, ref int Value, long RecordNumber=(long)-1) { }
    public static void FileGet(int FileNumber, ref long Value, long RecordNumber=(long)-1) { }
    public static void FileGet(int FileNumber, ref float Value, long RecordNumber=(long)-1) { }
    public static void FileGet(int FileNumber, ref string Value, long RecordNumber=(long)-1, bool StringIsFixedLength=false) { }
    public static void FileGet(int FileNumber, ref System.ValueType Value, long RecordNumber=(long)-1) { }
    public static void FileGetObject(int FileNumber, ref object Value, long RecordNumber=(long)-1) { }
    public static long FileLen(string PathName) { return default(long); }
    public static void FileOpen(int FileNumber, string FileName, Microsoft.VisualBasic.OpenMode Mode, Microsoft.VisualBasic.OpenAccess Access=(Microsoft.VisualBasic.OpenAccess)(-1), Microsoft.VisualBasic.OpenShare Share=(Microsoft.VisualBasic.OpenShare)(-1), int RecordLength=-1) { }
    public static void FilePut(int FileNumber, System.Array Value, long RecordNumber=(long)-1, bool ArrayIsDynamic=false, bool StringIsFixedLength=false) { }
    public static void FilePut(int FileNumber, bool Value, long RecordNumber=(long)-1) { }
    public static void FilePut(int FileNumber, byte Value, long RecordNumber=(long)-1) { }
    public static void FilePut(int FileNumber, char Value, long RecordNumber=(long)-1) { }
    public static void FilePut(int FileNumber, System.DateTime Value, long RecordNumber=(long)-1) { }
    public static void FilePut(int FileNumber, decimal Value, long RecordNumber=(long)-1) { }
    public static void FilePut(int FileNumber, double Value, long RecordNumber=(long)-1) { }
    public static void FilePut(int FileNumber, short Value, long RecordNumber=(long)-1) { }
    public static void FilePut(int FileNumber, int Value, long RecordNumber=(long)-1) { }
    public static void FilePut(int FileNumber, long Value, long RecordNumber=(long)-1) { }
    public static void FilePut(int FileNumber, float Value, long RecordNumber=(long)-1) { }
    public static void FilePut(int FileNumber, string Value, long RecordNumber=(long)-1, bool StringIsFixedLength=false) { }
    public static void FilePut(int FileNumber, System.ValueType Value, long RecordNumber=(long)-1) { }
    [System.ObsoleteAttribute("This member has been deprectated. Try FilePutObject.")]
    public static void FilePut(object FileNumber, object Value, object RecordNumber=-1) { }
    public static void FilePutObject(int FileNumber, object Value, long RecordNumber=(long)-1) { }
    public static void FileWidth(int FileNumber, int RecordWidth) { }
    public static int FreeFile() { return default(int); }
    public static Microsoft.VisualBasic.FileAttribute GetAttr(string PathName) { return default(Microsoft.VisualBasic.FileAttribute); }
    public static void Input(int FileNumber, ref bool Value) { }
    public static void Input(int FileNumber, ref byte Value) { }
    public static void Input(int FileNumber, ref char Value) { }
    public static void Input(int FileNumber, ref System.DateTime Value) { }
    public static void Input(int FileNumber, ref decimal Value) { }
    public static void Input(int FileNumber, ref double Value) { }
    public static void Input(int FileNumber, ref short Value) { }
    public static void Input(int FileNumber, ref int Value) { }
    public static void Input(int FileNumber, ref long Value) { }
    public static void Input(int FileNumber, ref object Value) { }
    public static void Input(int FileNumber, ref float Value) { }
    public static void Input(int FileNumber, ref string Value) { }
    public static string InputString(int FileNumber, int CharCount) { return default(string); }
    public static void Kill(string PathName) { }
    public static string LineInput(int FileNumber) { return default(string); }
    public static long Loc(int FileNumber) { return default(long); }
    public static void Lock(int FileNumber) { }
    public static void Lock(int FileNumber, long Record) { }
    public static void Lock(int FileNumber, long FromRecord, long ToRecord) { }
    public static long LOF(int FileNumber) { return default(long); }
    public static void MkDir(string Path) { }
    public static void Print(int FileNumber, params System.Object[] Output) { }
    public static void PrintLine(int FileNumber, params System.Object[] Output) { }
    public static void Rename(string OldPath, string NewPath) { }
    public static void Reset() { }
    public static void RmDir(string Path) { }
    public static long Seek(int FileNumber) { return default(long); }
    public static void Seek(int FileNumber, long Position) { }
    public static void SetAttr(string PathName, Microsoft.VisualBasic.FileAttribute Attributes) { }
    public static Microsoft.VisualBasic.SpcInfo SPC(short Count) { return default(Microsoft.VisualBasic.SpcInfo); }
    public static Microsoft.VisualBasic.TabInfo TAB() { return default(Microsoft.VisualBasic.TabInfo); }
    public static Microsoft.VisualBasic.TabInfo TAB(short Column) { return default(Microsoft.VisualBasic.TabInfo); }
    public static void Unlock(int FileNumber) { }
    public static void Unlock(int FileNumber, long Record) { }
    public static void Unlock(int FileNumber, long FromRecord, long ToRecord) { }
    public static void Write(int FileNumber, params System.Object[] Output) { }
    public static void WriteLine(int FileNumber, params System.Object[] Output) { }
  }
  [Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute]
  public sealed partial class Financial {
    public Financial() { }
    public static double DDB(double Cost, double Salvage, double Life, double Period, double Factor=2) { return default(double); }
    public static double FV(double Rate, double NPer, double Pmt, double PV=0, Microsoft.VisualBasic.DueDate Due=(Microsoft.VisualBasic.DueDate)(0)) { return default(double); }
    public static double IPmt(double Rate, double Per, double NPer, double PV, double FV=0, Microsoft.VisualBasic.DueDate Due=(Microsoft.VisualBasic.DueDate)(0)) { return default(double); }
    public static double IRR(ref System.Double[] ValueArray, double Guess=0.1) { return default(double); }
    public static double MIRR(ref System.Double[] ValueArray, double FinanceRate, double ReinvestRate) { return default(double); }
    public static double NPer(double Rate, double Pmt, double PV, double FV=0, Microsoft.VisualBasic.DueDate Due=(Microsoft.VisualBasic.DueDate)(0)) { return default(double); }
    public static double NPV(double Rate, ref System.Double[] ValueArray) { return default(double); }
    public static double Pmt(double Rate, double NPer, double PV, double FV=0, Microsoft.VisualBasic.DueDate Due=(Microsoft.VisualBasic.DueDate)(0)) { return default(double); }
    public static double PPmt(double Rate, double Per, double NPer, double PV, double FV=0, Microsoft.VisualBasic.DueDate Due=(Microsoft.VisualBasic.DueDate)(0)) { return default(double); }
    public static double PV(double Rate, double NPer, double Pmt, double FV=0, Microsoft.VisualBasic.DueDate Due=(Microsoft.VisualBasic.DueDate)(0)) { return default(double); }
    public static double Rate(double NPer, double Pmt, double PV, double FV=0, Microsoft.VisualBasic.DueDate Due=(Microsoft.VisualBasic.DueDate)(0), double Guess=0.1) { return default(double); }
    public static double SLN(double Cost, double Salvage, double Life) { return default(double); }
    public static double SYD(double Cost, double Salvage, double Life, double Period) { return default(double); }
  }
  public enum FirstDayOfWeek {
    Friday = 6,
    Monday = 2,
    Saturday = 7,
    Sunday = 1,
    System = 0,
    Thursday = 5,
    Tuesday = 3,
    Wednesday = 4,
  }
  public enum FirstWeekOfYear {
    FirstFourDays = 2,
    FirstFullWeek = 3,
    Jan1 = 1,
    System = 0,
  }
  [Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute]
  public sealed partial class Globals {
    public Globals() { }
    public static string ScriptEngine { get { return default(string); } }
    public static int ScriptEngineBuildVersion { get { return default(int); } }
    public static int ScriptEngineMajorVersion { get { return default(int); } }
    public static int ScriptEngineMinorVersion { get { return default(int); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false, Inherited=false)]
  public sealed partial class HideModuleNameAttribute : System.Attribute {
    public HideModuleNameAttribute() { }
  }
  [Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute]
  public sealed partial class Information {
    public Information() { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public static int Erl() { return default(int); }
    public static Microsoft.VisualBasic.ErrObject Err() { return default(Microsoft.VisualBasic.ErrObject); }
    public static bool IsArray(object VarName) { return default(bool); }
    public static bool IsDate(object Expression) { return default(bool); }
    public static bool IsDBNull(object Expression) { return default(bool); }
    public static bool IsError(object Expression) { return default(bool); }
    public static bool IsNothing(object Expression) { return default(bool); }
    public static bool IsNumeric(object Expression) { return default(bool); }
    public static bool IsReference(object Expression) { return default(bool); }
    public static int LBound(System.Array Array, int Rank=1) { return default(int); }
    public static int QBColor(int Color) { return default(int); }
    public static int RGB(int Red, int Green, int Blue) { return default(int); }
    public static string SystemTypeName(string VbName) { return default(string); }
    public static string TypeName(object VarName) { return default(string); }
    public static int UBound(System.Array Array, int Rank=1) { return default(int); }
    public static Microsoft.VisualBasic.VariantType VarType(object VarName) { return default(Microsoft.VisualBasic.VariantType); }
    public static string VbTypeName(string UrtName) { return default(string); }
  }
  [Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute]
  public sealed partial class Interaction {
    public Interaction() { }
    public static void AppActivate(int ProcessId) { }
    public static void AppActivate(string Title) { }
    public static void Beep() { }
    [System.MonoLimitationAttribute("CallType.Let options is not supported.")]
    public static object CallByName(object ObjectRef, string ProcName, Microsoft.VisualBasic.CallType UseCallType, params System.Object[] Args) { return default(object); }
    public static object Choose(double Index, params System.Object[] Choice) { return default(object); }
    public static string Command() { return default(string); }
    public static object CreateObject(string ProgId, string ServerName="") { return default(object); }
    public static void DeleteSetting(string AppName, string Section=null, string Key=null) { }
    public static string Environ(int Expression) { return default(string); }
    public static string Environ(string Expression) { return default(string); }
    [System.MonoLimitationAttribute("If this function is used the assembly have to be recompiled when you switch platforms.")]
    public static System.String[,] GetAllSettings(string AppName, string Section) { return default(System.String[,]); }
    public static object GetObject(string PathName=null, string Class=null) { return default(object); }
    public static string GetSetting(string AppName, string Section, string Key, string Default="") { return default(string); }
    public static object IIf(bool Expression, object TruePart, object FalsePart) { return default(object); }
    public static string InputBox(string Prompt, string Title="", string DefaultResponse="", int XPos=-1, int YPos=-1) { return default(string); }
    public static Microsoft.VisualBasic.MsgBoxResult MsgBox(object Prompt, Microsoft.VisualBasic.MsgBoxStyle Button=(Microsoft.VisualBasic.MsgBoxStyle)(0), object Title=null) { return default(Microsoft.VisualBasic.MsgBoxResult); }
    public static string Partition(long Number, long Start, long Stop, long Interval) { return default(string); }
    public static void SaveSetting(string AppName, string Section, string Key, string Setting) { }
    public static int Shell(string Pathname, Microsoft.VisualBasic.AppWinStyle Style=(Microsoft.VisualBasic.AppWinStyle)(2), bool Wait=false, int Timeout=-1) { return default(int); }
    public static object Switch(params System.Object[] VarExpr) { return default(object); }
    public partial class InputForm : System.Windows.Forms.Form {
      public InputForm(string Prompt, string Title="", string DefaultResponse="", int XPos=-1, int YPos=-1) { }
      public string Run() { return default(string); }
    }
  }
  public enum MsgBoxResult {
    Abort = 3,
    Cancel = 2,
    Ignore = 5,
    No = 7,
    Ok = 1,
    Retry = 4,
    Yes = 6,
  }
  [System.FlagsAttribute]
  public enum MsgBoxStyle {
    AbortRetryIgnore = 2,
    ApplicationModal = 0,
    Critical = 16,
    DefaultButton1 = 0,
    DefaultButton2 = 256,
    DefaultButton3 = 512,
    Exclamation = 48,
    Information = 64,
    MsgBoxHelp = 16384,
    MsgBoxRight = 524288,
    MsgBoxRtlReading = 1048576,
    MsgBoxSetForeground = 65536,
    OkCancel = 1,
    OkOnly = 0,
    Question = 32,
    RetryCancel = 5,
    SystemModal = 4096,
    YesNo = 4,
    YesNoCancel = 3,
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false, Inherited=false)]
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
  public sealed partial class MyGroupCollectionAttribute : System.Attribute {
    public MyGroupCollectionAttribute(string typeToCollect, string createInstanceMethodName, string disposeInstanceMethodName, string defaultInstanceAlias) { }
    public string CreateMethod { get { return default(string); } }
    public string DefaultInstanceAlias { get { return default(string); } }
    public string DisposeMethod { get { return default(string); } }
    public string MyGroupName { get { return default(string); } }
  }
  public enum OpenAccess {
    Default = -1,
    Read = 1,
    ReadWrite = 3,
    Write = 2,
  }
  public enum OpenMode {
    Append = 8,
    Binary = 32,
    Input = 1,
    Output = 2,
    Random = 4,
  }
  public enum OpenShare {
    Default = -1,
    LockRead = 2,
    LockReadWrite = 0,
    LockWrite = 1,
    Shared = 3,
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct SpcInfo {
    public short Count;
  }
  [Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute]
  public sealed partial class Strings {
    public Strings() { }
    public static int Asc(char String) { return default(int); }
    public static int Asc(string String) { return default(int); }
    public static int AscW(char String) { return default(int); }
    public static int AscW(string String) { return default(int); }
    public static char Chr(int CharCode) { return default(char); }
    public static char ChrW(int CharCode) { return default(char); }
    public static System.String[] Filter(System.Object[] Source, string Match, bool Include=true, [Microsoft.VisualBasic.CompilerServices.OptionCompareAttribute]Microsoft.VisualBasic.CompareMethod Compare=(Microsoft.VisualBasic.CompareMethod)(0)) { return default(System.String[]); }
    public static System.String[] Filter(System.String[] Source, string Match, bool Include=true, [Microsoft.VisualBasic.CompilerServices.OptionCompareAttribute]Microsoft.VisualBasic.CompareMethod Compare=(Microsoft.VisualBasic.CompareMethod)(0)) { return default(System.String[]); }
    public static string Format(object Expression, string Style="") { return default(string); }
    public static string FormatCurrency(object Expression, int NumDigitsAfterDecimal=-1, Microsoft.VisualBasic.TriState IncludeLeadingDigit=(Microsoft.VisualBasic.TriState)(-2), Microsoft.VisualBasic.TriState UseParensForNegativeNumbers=(Microsoft.VisualBasic.TriState)(-2), Microsoft.VisualBasic.TriState GroupDigits=(Microsoft.VisualBasic.TriState)(-2)) { return default(string); }
    public static string FormatDateTime(System.DateTime Expression, Microsoft.VisualBasic.DateFormat NamedFormat=(Microsoft.VisualBasic.DateFormat)(0)) { return default(string); }
    public static string FormatNumber(object Expression, int NumDigitsAfterDecimal=-1, Microsoft.VisualBasic.TriState IncludeLeadingDigit=(Microsoft.VisualBasic.TriState)(-2), Microsoft.VisualBasic.TriState UseParensForNegativeNumbers=(Microsoft.VisualBasic.TriState)(-2), Microsoft.VisualBasic.TriState GroupDigits=(Microsoft.VisualBasic.TriState)(-2)) { return default(string); }
    public static string FormatPercent(object Expression, int NumDigitsAfterDecimal=-1, Microsoft.VisualBasic.TriState IncludeLeadingDigit=(Microsoft.VisualBasic.TriState)(-2), Microsoft.VisualBasic.TriState UseParensForNegativeNumbers=(Microsoft.VisualBasic.TriState)(-2), Microsoft.VisualBasic.TriState GroupDigits=(Microsoft.VisualBasic.TriState)(-2)) { return default(string); }
    public static char GetChar(string str, int Index) { return default(char); }
    public static int InStr(int Start, string String1, string String2, [Microsoft.VisualBasic.CompilerServices.OptionCompareAttribute]Microsoft.VisualBasic.CompareMethod Compare=(Microsoft.VisualBasic.CompareMethod)(0)) { return default(int); }
    public static int InStr(string String1, string String2, [Microsoft.VisualBasic.CompilerServices.OptionCompareAttribute]Microsoft.VisualBasic.CompareMethod Compare=(Microsoft.VisualBasic.CompareMethod)(0)) { return default(int); }
    public static int InStrRev(string StringCheck, string StringMatch, int Start=-1, [Microsoft.VisualBasic.CompilerServices.OptionCompareAttribute]Microsoft.VisualBasic.CompareMethod Compare=(Microsoft.VisualBasic.CompareMethod)(0)) { return default(int); }
    public static string Join(System.Object[] SourceArray, string Delimiter=" ") { return default(string); }
    public static string Join(System.String[] SourceArray, string Delimiter=" ") { return default(string); }
    public static char LCase(char Value) { return default(char); }
    public static string LCase(string Value) { return default(string); }
    public static string Left(string str, int Length) { return default(string); }
    public static int Len(bool Expression) { return default(int); }
    public static int Len(byte Expression) { return default(int); }
    public static int Len(char Expression) { return default(int); }
    public static int Len(System.DateTime Expression) { return default(int); }
    public static int Len(decimal Expression) { return default(int); }
    public static int Len(double Expression) { return default(int); }
    public static int Len(short Expression) { return default(int); }
    public static int Len(int Expression) { return default(int); }
    public static int Len(long Expression) { return default(int); }
    public static int Len(object Expression) { return default(int); }
    [System.CLSCompliantAttribute(false)]
    public static int Len(sbyte Expression) { return default(int); }
    public static int Len(float Expression) { return default(int); }
    public static int Len(string Expression) { return default(int); }
    [System.CLSCompliantAttribute(false)]
    public static int Len(ushort Expression) { return default(int); }
    [System.CLSCompliantAttribute(false)]
    public static int Len(uint Expression) { return default(int); }
    [System.CLSCompliantAttribute(false)]
    public static int Len(ulong Expression) { return default(int); }
    public static string LSet(string Source, int Length) { return default(string); }
    public static string LTrim(string str) { return default(string); }
    public static string Mid(string str, int Start) { return default(string); }
    public static string Mid(string str, int Start, int Length) { return default(string); }
    public static string Replace(string Expression, string Find, string Replacement, int Start=1, int Count=-1, [Microsoft.VisualBasic.CompilerServices.OptionCompareAttribute]Microsoft.VisualBasic.CompareMethod Compare=(Microsoft.VisualBasic.CompareMethod)(0)) { return default(string); }
    public static string Right(string str, int Length) { return default(string); }
    public static string RSet(string Source, int Length) { return default(string); }
    public static string RTrim(string str) { return default(string); }
    public static string Space(int Number) { return default(string); }
    public static System.String[] Split(string Expression, string Delimiter=" ", int Limit=-1, [Microsoft.VisualBasic.CompilerServices.OptionCompareAttribute]Microsoft.VisualBasic.CompareMethod Compare=(Microsoft.VisualBasic.CompareMethod)(0)) { return default(System.String[]); }
    public static int StrComp(string String1, string String2, [Microsoft.VisualBasic.CompilerServices.OptionCompareAttribute]Microsoft.VisualBasic.CompareMethod Compare=(Microsoft.VisualBasic.CompareMethod)(0)) { return default(int); }
    public static string StrConv(string str, Microsoft.VisualBasic.VbStrConv Conversion, int LocaleID=0) { return default(string); }
    public static string StrDup(int Number, char Character) { return default(string); }
    public static object StrDup(int Number, object Character) { return default(object); }
    public static string StrDup(int Number, string Character) { return default(string); }
    public static string StrReverse(string Expression) { return default(string); }
    public static string Trim(string str) { return default(string); }
    public static char UCase(char Value) { return default(char); }
    public static string UCase(string Value) { return default(string); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct TabInfo {
    public short Column;
  }
  public enum TriState {
    False = 0,
    True = -1,
    UseDefault = -2,
  }
  public enum VariantType {
    Array = 8192,
    Boolean = 11,
    Byte = 17,
    Char = 18,
    Currency = 6,
    DataObject = 13,
    Date = 7,
    Decimal = 14,
    Double = 5,
    Empty = 0,
    Error = 10,
    Integer = 3,
    Long = 20,
    Null = 1,
    Object = 9,
    Short = 2,
    Single = 4,
    String = 8,
    UserDefinedType = 36,
    Variant = 12,
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(256), Inherited=false, AllowMultiple=false)]
  public sealed partial class VBFixedArrayAttribute : System.Attribute {
    public VBFixedArrayAttribute(int UpperBound1) { }
    public VBFixedArrayAttribute(int UpperBound1, int UpperBound2) { }
    public System.Int32[] Bounds { get { return default(System.Int32[]); } }
    public int Length { get { return default(int); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(256), Inherited=false, AllowMultiple=false)]
  public sealed partial class VBFixedStringAttribute : System.Attribute {
    public VBFixedStringAttribute(int Length) { }
    public int Length { get { return default(int); } }
  }
  [Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute]
  public sealed partial class VBMath {
    public VBMath() { }
    public static void Randomize() { }
    public static void Randomize(double Number) { }
    public static float Rnd() { return default(float); }
    public static float Rnd(float Number) { return default(float); }
  }
  [System.FlagsAttribute]
  public enum VbStrConv {
    Hiragana = 32,
    Katakana = 16,
    LinguisticCasing = 1024,
    Lowercase = 2,
    Narrow = 8,
    None = 0,
    ProperCase = 3,
    SimplifiedChinese = 256,
    TraditionalChinese = 512,
    Uppercase = 1,
    Wide = 4,
  }
}
namespace Microsoft.VisualBasic.ApplicationServices {
  public partial class ApplicationBase {
    public ApplicationBase() { }
    public System.Globalization.CultureInfo Culture { get { return default(System.Globalization.CultureInfo); } }
    public Microsoft.VisualBasic.ApplicationServices.AssemblyInfo Info { get { return default(Microsoft.VisualBasic.ApplicationServices.AssemblyInfo); } }
    public Microsoft.VisualBasic.Logging.Log Log { get { return default(Microsoft.VisualBasic.Logging.Log); } }
    public System.Globalization.CultureInfo UICulture { get { return default(System.Globalization.CultureInfo); } }
    public void ChangeCulture(string cultureName) { }
    public void ChangeUICulture(string cultureName) { }
    public string GetEnvironmentVariable(string name) { return default(string); }
  }
  public partial class AssemblyInfo {
    public AssemblyInfo(System.Reflection.Assembly currentAssembly) { }
    public string AssemblyName { get { return default(string); } }
    public string CompanyName { get { return default(string); } }
    public string Copyright { get { return default(string); } }
    public string Description { get { return default(string); } }
    public string DirectoryPath { get { return default(string); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Reflection.Assembly> LoadedAssemblies { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Reflection.Assembly>); } }
    public string ProductName { get { return default(string); } }
    public string StackTrace { get { return default(string); } }
    public string Title { get { return default(string); } }
    public string Trademark { get { return default(string); } }
    public System.Version Version { get { return default(System.Version); } }
    public long WorkingSet { get { return default(long); } }
  }
  public enum AuthenticationMode {
    ApplicationDefined = 1,
    Windows = 0,
  }
  [System.ComponentModel.TypeConverterAttribute(typeof(Microsoft.VisualBasic.ApplicationServices.BuiltInRoleConverter))]
  public enum BuiltInRole {
    AccountOperator = 548,
    Administrator = 544,
    BackupOperator = 551,
    Guest = 546,
    PowerUser = 547,
    PrintOperator = 550,
    Replicator = 552,
    SystemOperator = 549,
    User = 545,
  }
  public partial class BuiltInRoleConverter : System.ComponentModel.TypeConverter {
    public BuiltInRoleConverter() { }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public partial class CantStartSingleInstanceException : System.Exception {
    public CantStartSingleInstanceException() { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    protected CantStartSingleInstanceException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public CantStartSingleInstanceException(string message) { }
    public CantStartSingleInstanceException(string message, System.Exception inner) { }
  }
  public partial class ConsoleApplicationBase : Microsoft.VisualBasic.ApplicationServices.ApplicationBase {
    public ConsoleApplicationBase() { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.String> CommandLineArgs { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.String>); } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    protected System.Collections.ObjectModel.ReadOnlyCollection<System.String> InternalCommandLine { set { } }
    public bool IsNetworkDeployed { get { return default(bool); } }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public partial class NoStartupFormException : System.Exception {
    public NoStartupFormException() { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    protected NoStartupFormException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public NoStartupFormException(string message) { }
    public NoStartupFormException(string message, System.Exception inner) { }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
  public delegate void ShutdownEventHandler(object sender, System.EventArgs e);
  public enum ShutdownMode {
    AfterAllFormsClose = 1,
    AfterMainFormCloses = 0,
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public partial class StartupEventArgs : System.ComponentModel.CancelEventArgs {
    public StartupEventArgs(System.Collections.ObjectModel.ReadOnlyCollection<System.String> args) { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.String> CommandLine { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.String>); } }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
  public delegate void StartupEventHandler(object sender, Microsoft.VisualBasic.ApplicationServices.StartupEventArgs e);
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
  public partial class StartupNextInstanceEventArgs : System.EventArgs {
    public StartupNextInstanceEventArgs(System.Collections.ObjectModel.ReadOnlyCollection<System.String> args, bool bringToForegroundFlag) { }
    public bool BringToForeground { get { return default(bool); } set { } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.String> CommandLine { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.String>); } }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
  public delegate void StartupNextInstanceEventHandler(object sender, Microsoft.VisualBasic.ApplicationServices.StartupNextInstanceEventArgs e);
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public partial class UnhandledExceptionEventArgs : System.Threading.ThreadExceptionEventArgs {
    public UnhandledExceptionEventArgs(bool exitApplication, System.Exception exception) : base (default(System.Exception)) { }
    public bool ExitApplication { get { return default(bool); } set { } }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
  public delegate void UnhandledExceptionEventHandler(object sender, Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs e);
  public partial class User {
    public User() { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public System.Security.Principal.IPrincipal CurrentPrincipal { get { return default(System.Security.Principal.IPrincipal); } set { } }
    protected virtual System.Security.Principal.IPrincipal InternalPrincipal { get { return default(System.Security.Principal.IPrincipal); } set { } }
    public bool IsAuthenticated { get { return default(bool); } }
    public string Name { get { return default(string); } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public void InitializeWithWindowsUser() { }
    public bool IsInRole(Microsoft.VisualBasic.ApplicationServices.BuiltInRole role) { return default(bool); }
    public bool IsInRole(string role) { return default(bool); }
  }
  public partial class WebUser : Microsoft.VisualBasic.ApplicationServices.User {
    public WebUser() { }
    protected override System.Security.Principal.IPrincipal InternalPrincipal { get { return default(System.Security.Principal.IPrincipal); } set { } }
  }
  public partial class WindowsFormsApplicationBase : Microsoft.VisualBasic.ApplicationServices.ConsoleApplicationBase {
    public WindowsFormsApplicationBase() { }
    public WindowsFormsApplicationBase(Microsoft.VisualBasic.ApplicationServices.AuthenticationMode mode) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public System.Windows.Forms.ApplicationContext ApplicationContext { get { return default(System.Windows.Forms.ApplicationContext); } }
    protected bool EnableVisualStyles { get { return default(bool); } set { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    protected bool IsSingleInstance { get { return default(bool); } set { } }
    protected System.Windows.Forms.Form MainForm { get { return default(System.Windows.Forms.Form); } set { } }
    public int MinimumSplashScreenDisplayTime { get { return default(int); } set { } }
    public System.Windows.Forms.FormCollection OpenForms { get { return default(System.Windows.Forms.FormCollection); } }
    public bool SaveMySettingsOnExit { get { return default(bool); } set { } }
    protected Microsoft.VisualBasic.ApplicationServices.ShutdownMode ShutdownStyle { get { return default(Microsoft.VisualBasic.ApplicationServices.ShutdownMode); } set { } }
    public System.Windows.Forms.Form SplashScreen { get { return default(System.Windows.Forms.Form); } set { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    protected static bool UseCompatibleTextRendering { get { return default(bool); } }
    public event Microsoft.VisualBasic.Devices.NetworkAvailableEventHandler NetworkAvailabilityChanged { add { } remove { } }
    public event Microsoft.VisualBasic.ApplicationServices.ShutdownEventHandler Shutdown { add { } remove { } }
    public event Microsoft.VisualBasic.ApplicationServices.StartupEventHandler Startup { add { } remove { } }
    public event Microsoft.VisualBasic.ApplicationServices.StartupNextInstanceEventHandler StartupNextInstance { add { } remove { } }
    public event Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventHandler UnhandledException { add { } remove { } }
    public void DoEvents() { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    protected void HideSplashScreen() { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    protected virtual void OnCreateMainForm() { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    protected virtual void OnCreateSplashScreen() { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    [System.STAThreadAttribute]
    protected virtual bool OnInitialize(System.Collections.ObjectModel.ReadOnlyCollection<System.String> commandLineArgs) { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    protected virtual void OnRun() { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    protected virtual void OnShutdown() { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    protected virtual bool OnStartup(Microsoft.VisualBasic.ApplicationServices.StartupEventArgs eventArgs) { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    protected virtual void OnStartupNextInstance(Microsoft.VisualBasic.ApplicationServices.StartupNextInstanceEventArgs eventArgs) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    protected virtual bool OnUnhandledException(Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs e) { return default(bool); }
    public void Run(System.String[] commandLine) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    protected void ShowSplashScreen() { }
  }
}
namespace Microsoft.VisualBasic.CompilerServices {
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class BooleanType {
    internal BooleanType() { }
    public static bool FromObject(object Value) { return default(bool); }
    public static bool FromString(string Value) { return default(bool); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class ByteType {
    internal ByteType() { }
    public static byte FromObject(object Value) { return default(byte); }
    public static byte FromString(string value) { return default(byte); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class CharArrayType {
    internal CharArrayType() { }
    public static System.Char[] FromObject(object Value) { return default(System.Char[]); }
    public static System.Char[] FromString(string Value) { return default(System.Char[]); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class CharType {
    internal CharType() { }
    public static char FromObject(object Value) { return default(char); }
    public static char FromString(string value) { return default(char); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class Conversions {
    internal Conversions() { }
    public static object ChangeType(object Expression, System.Type TargetType) { return default(object); }
    public static string FromCharAndCount(char Value, int Count) { return default(string); }
    public static string FromCharArray(System.Char[] Value) { return default(string); }
    public static string FromCharArraySubset(System.Char[] Value, int StartIndex, int Length) { return default(string); }
    public static bool ToBoolean(object Value) { return default(bool); }
    public static bool ToBoolean(string Value) { return default(bool); }
    public static byte ToByte(object Value) { return default(byte); }
    public static byte ToByte(string Value) { return default(byte); }
    public static char ToChar(object Value) { return default(char); }
    public static char ToChar(string Value) { return default(char); }
    public static System.Char[] ToCharArrayRankOne(object Value) { return default(System.Char[]); }
    public static System.Char[] ToCharArrayRankOne(string Value) { return default(System.Char[]); }
    public static System.DateTime ToDate(object Value) { return default(System.DateTime); }
    public static System.DateTime ToDate(string Value) { return default(System.DateTime); }
    public static decimal ToDecimal(bool Value) { return default(decimal); }
    public static decimal ToDecimal(object Value) { return default(decimal); }
    public static decimal ToDecimal(string Value) { return default(decimal); }
    public static double ToDouble(object Value) { return default(double); }
    public static double ToDouble(string Value) { return default(double); }
    public static T ToGenericParameter<T>(object Value) { return default(T); }
    public static int ToInteger(object Value) { return default(int); }
    public static int ToInteger(string Value) { return default(int); }
    public static long ToLong(object Value) { return default(long); }
    public static long ToLong(string Value) { return default(long); }
    [System.CLSCompliantAttribute(false)]
    public static sbyte ToSByte(object Value) { return default(sbyte); }
    [System.CLSCompliantAttribute(false)]
    public static sbyte ToSByte(string Value) { return default(sbyte); }
    public static short ToShort(object Value) { return default(short); }
    public static short ToShort(string Value) { return default(short); }
    public static float ToSingle(object Value) { return default(float); }
    public static float ToSingle(string Value) { return default(float); }
    public static string ToString(bool Value) { return default(string); }
    public static string ToString(byte Value) { return default(string); }
    public static string ToString(char Value) { return default(string); }
    public static string ToString(System.DateTime Value) { return default(string); }
    public static string ToString(decimal Value) { return default(string); }
    public static string ToString(decimal Value, System.Globalization.NumberFormatInfo NumberFormat) { return default(string); }
    public static string ToString(double Value) { return default(string); }
    public static string ToString(double Value, System.Globalization.NumberFormatInfo NumberFormat) { return default(string); }
    public static string ToString(short Value) { return default(string); }
    public static string ToString(int Value) { return default(string); }
    public static string ToString(long Value) { return default(string); }
    public static string ToString(object Value) { return default(string); }
    public static string ToString(float Value) { return default(string); }
    public static string ToString(float Value, System.Globalization.NumberFormatInfo NumberFormat) { return default(string); }
    [System.CLSCompliantAttribute(false)]
    public static string ToString(uint Value) { return default(string); }
    [System.CLSCompliantAttribute(false)]
    public static string ToString(ulong Value) { return default(string); }
    [System.CLSCompliantAttribute(false)]
    public static uint ToUInteger(object Value) { return default(uint); }
    [System.CLSCompliantAttribute(false)]
    public static uint ToUInteger(string Value) { return default(uint); }
    [System.CLSCompliantAttribute(false)]
    public static ulong ToULong(object Value) { return default(ulong); }
    [System.CLSCompliantAttribute(false)]
    public static ulong ToULong(string Value) { return default(ulong); }
    [System.CLSCompliantAttribute(false)]
    public static ushort ToUShort(object Value) { return default(ushort); }
    [System.CLSCompliantAttribute(false)]
    public static ushort ToUShort(string Value) { return default(ushort); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class DateType {
    internal DateType() { }
    public static System.DateTime FromObject(object Value) { return default(System.DateTime); }
    public static System.DateTime FromString(string Value) { return default(System.DateTime); }
    public static System.DateTime FromString(string Value, System.Globalization.CultureInfo culture) { return default(System.DateTime); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class DecimalType {
    internal DecimalType() { }
    public static decimal FromBoolean(bool Value) { return default(decimal); }
    public static decimal FromObject(object Value) { return default(decimal); }
    public static decimal FromObject(object Value, System.Globalization.NumberFormatInfo NumberFormat) { return default(decimal); }
    public static decimal FromString(string Value) { return default(decimal); }
    public static decimal FromString(string Value, System.Globalization.NumberFormatInfo NumberFormat) { return default(decimal); }
    public static decimal Parse(string Value, System.Globalization.NumberFormatInfo NumberFormat) { return default(decimal); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false, Inherited=false)]
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class DesignerGeneratedAttribute : System.Attribute {
    public DesignerGeneratedAttribute() { }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class DoubleType {
    internal DoubleType() { }
    public static double FromObject(object Value) { return default(double); }
    public static double FromObject(object Value, System.Globalization.NumberFormatInfo NumberFormat) { return default(double); }
    public static double FromString(string Value) { return default(double); }
    public static double FromString(string Value, System.Globalization.NumberFormatInfo NumberFormat) { return default(double); }
    public static double Parse(string Value) { return default(double); }
    public static double Parse(string Value, System.Globalization.NumberFormatInfo NumberFormat) { return default(double); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class ExceptionUtils {
    internal ExceptionUtils() { }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class FlowControl {
    internal FlowControl() { }
    public static void CheckForSyncLockOnValueType(object obj) { }
    public static System.Collections.IEnumerator ForEachInArr(System.Array ary) { return default(System.Collections.IEnumerator); }
    public static System.Collections.IEnumerator ForEachInObj(object obj) { return default(System.Collections.IEnumerator); }
    public static bool ForEachNextObj(ref object obj, System.Collections.IEnumerator enumerator) { return default(bool); }
    public static bool ForLoopInitObj(object Counter, object Start, object Limit, object StepValue, ref object LoopForResult, ref object CounterResult) { return default(bool); }
    public static bool ForNextCheckDec(decimal count, decimal limit, decimal StepValue) { return default(bool); }
    public static bool ForNextCheckObj(object Counter, object LoopObj, ref object CounterResult) { return default(bool); }
    public static bool ForNextCheckR4(float count, float limit, float StepValue) { return default(bool); }
    public static bool ForNextCheckR8(double count, double limit, double StepValue) { return default(bool); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class HostServices {
    public HostServices() { }
    public static Microsoft.VisualBasic.CompilerServices.IVbHost VBHost { get { return default(Microsoft.VisualBasic.CompilerServices.IVbHost); } set { } }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class IncompleteInitialization : System.Exception {
    public IncompleteInitialization() { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public IncompleteInitialization(string message) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public IncompleteInitialization(string message, System.Exception innerException) { }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class IntegerType {
    internal IntegerType() { }
    public static int FromObject(object Value) { return default(int); }
    public static int FromString(string Value) { return default(int); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class InternalErrorException : System.Exception {
    public InternalErrorException() { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public InternalErrorException(string message) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public InternalErrorException(string message, System.Exception innerException) { }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public partial interface IVbHost {
    System.Windows.Forms.IWin32Window GetParentWindow();
    string GetWindowTitle();
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class LateBinding {
    internal LateBinding() { }
    [System.Diagnostics.DebuggerHiddenAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    public static void LateCall(object o, System.Type objType, string name, System.Object[] args, System.String[] paramnames, System.Boolean[] CopyBack) { }
    [System.Diagnostics.DebuggerHiddenAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    public static object LateGet(object o, System.Type objType, string name, System.Object[] args, System.String[] paramnames, System.Boolean[] CopyBack) { return default(object); }
    [System.Diagnostics.DebuggerHiddenAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    public static object LateIndexGet(object o, System.Object[] args, System.String[] paramnames) { return default(object); }
    [System.Diagnostics.DebuggerHiddenAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    public static void LateIndexSet(object o, System.Object[] args, System.String[] paramnames) { }
    [System.Diagnostics.DebuggerHiddenAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    public static void LateIndexSetComplex(object o, System.Object[] args, System.String[] paramnames, bool OptimisticSet, bool RValueBase) { }
    [System.Diagnostics.DebuggerHiddenAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    public static void LateSet(object o, System.Type objType, string name, System.Object[] args, System.String[] paramnames) { }
    [System.Diagnostics.DebuggerHiddenAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    public static void LateSetComplex(object o, System.Type objType, string name, System.Object[] args, System.String[] paramnames, bool OptimisticSet, bool RValueBase) { }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class LikeOperator {
    internal LikeOperator() { }
    public static object LikeObject(object Source, object Pattern, Microsoft.VisualBasic.CompareMethod CompareOption) { return default(object); }
    public static bool LikeString(string Source, string Pattern, Microsoft.VisualBasic.CompareMethod CompareOption) { return default(bool); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class LongType {
    internal LongType() { }
    public static long FromObject(object Value) { return default(long); }
    public static long FromString(string value) { return default(long); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class NewLateBinding {
    internal NewLateBinding() { }
    [System.Diagnostics.DebuggerHiddenAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    public static object LateCall(object Instance, System.Type Type, string MemberName, System.Object[] Arguments, System.String[] ArgumentNames, System.Type[] TypeArguments, System.Boolean[] CopyBack, bool IgnoreReturn) { return default(object); }
    [System.Diagnostics.DebuggerHiddenAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    public static bool LateCanEvaluate(object instance, System.Type type, string memberName, System.Object[] arguments, bool allowFunctionEvaluation, bool allowPropertyEvaluation) { return default(bool); }
    [System.Diagnostics.DebuggerHiddenAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    public static object LateGet(object Instance, System.Type Type, string MemberName, System.Object[] Arguments, System.String[] ArgumentNames, System.Type[] TypeArguments, System.Boolean[] CopyBack) { return default(object); }
    [System.Diagnostics.DebuggerHiddenAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    public static object LateIndexGet(object Instance, System.Object[] Arguments, System.String[] ArgumentNames) { return default(object); }
    [System.Diagnostics.DebuggerHiddenAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    public static void LateIndexSet(object Instance, System.Object[] Arguments, System.String[] ArgumentNames) { }
    [System.Diagnostics.DebuggerHiddenAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    public static void LateIndexSetComplex(object Instance, System.Object[] Arguments, System.String[] ArgumentNames, bool OptimisticSet, bool RValueBase) { }
    [System.Diagnostics.DebuggerHiddenAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    public static void LateSet(object Instance, System.Type Type, string MemberName, System.Object[] Arguments, System.String[] ArgumentNames, System.Type[] TypeArguments) { }
    [System.Diagnostics.DebuggerHiddenAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    public static void LateSet(object Instance, System.Type Type, string MemberName, System.Object[] Arguments, System.String[] ArgumentNames, System.Type[] TypeArguments, bool OptimisticSet, bool RValueBase, Microsoft.VisualBasic.CallType CallType) { }
    [System.Diagnostics.DebuggerHiddenAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    public static void LateSetComplex(object Instance, System.Type Type, string MemberName, System.Object[] Arguments, System.String[] ArgumentNames, System.Type[] TypeArguments, bool OptimisticSet, bool RValueBase) { }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class ObjectFlowControl {
    internal ObjectFlowControl() { }
    public static void CheckForSyncLockOnValueType(object Expression) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public sealed partial class ForLoopControl {
      internal ForLoopControl() { }
      public static bool ForLoopInitObj(object Counter, object Start, object Limit, object StepValue, ref object LoopForResult, ref object CounterResult) { return default(bool); }
      public static bool ForNextCheckDec(decimal count, decimal limit, decimal StepValue) { return default(bool); }
      public static bool ForNextCheckObj(object Counter, object LoopObj, ref object CounterResult) { return default(bool); }
      public static bool ForNextCheckR4(float count, float limit, float StepValue) { return default(bool); }
      public static bool ForNextCheckR8(double count, double limit, double StepValue) { return default(bool); }
    }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class ObjectType {
    public ObjectType() { }
    public static object AddObj(object o1, object o2) { return default(object); }
    public static object BitAndObj(object obj1, object obj2) { return default(object); }
    public static object BitOrObj(object obj1, object obj2) { return default(object); }
    public static object BitXorObj(object obj1, object obj2) { return default(object); }
    public static object DivObj(object o1, object o2) { return default(object); }
    public static object GetObjectValuePrimitive(object o) { return default(object); }
    public static object IDivObj(object o1, object o2) { return default(object); }
    public static bool LikeObj(object vLeft, object vRight, Microsoft.VisualBasic.CompareMethod CompareOption) { return default(bool); }
    public static object ModObj(object o1, object o2) { return default(object); }
    public static object MulObj(object o1, object o2) { return default(object); }
    public static object NegObj(object obj) { return default(object); }
    public static object NotObj(object obj) { return default(object); }
    public static int ObjTst(object o1, object o2, bool TextCompare) { return default(int); }
    public static object PlusObj(object obj) { return default(object); }
    public static object PowObj(object o1, object o2) { return default(object); }
    public static object ShiftLeftObj(object o1, int amount) { return default(object); }
    public static object ShiftRightObj(object o1, int amount) { return default(object); }
    public static object StrCatObj(object vLeft, object vRight) { return default(object); }
    public static object SubObj(object o1, object o2) { return default(object); }
    public static object XorObj(object obj1, object obj2) { return default(object); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class Operators {
    internal Operators() { }
    public static object AddObject(object Left, object Right) { return default(object); }
    public static object AndObject(object Left, object Right) { return default(object); }
    public static int CompareObject(object Left, object Right, bool TextCompare) { return default(int); }
    public static object CompareObjectEqual(object Left, object Right, bool TextCompare) { return default(object); }
    public static object CompareObjectGreater(object Left, object Right, bool TextCompare) { return default(object); }
    public static object CompareObjectGreaterEqual(object Left, object Right, bool TextCompare) { return default(object); }
    public static object CompareObjectLess(object Left, object Right, bool TextCompare) { return default(object); }
    public static object CompareObjectLessEqual(object Left, object Right, bool TextCompare) { return default(object); }
    public static object CompareObjectNotEqual(object Left, object Right, bool TextCompare) { return default(object); }
    public static int CompareString(string Left, string Right, bool TextCompare) { return default(int); }
    public static object ConcatenateObject(object Left, object Right) { return default(object); }
    public static bool ConditionalCompareObjectEqual(object Left, object Right, bool TextCompare) { return default(bool); }
    public static bool ConditionalCompareObjectGreater(object Left, object Right, bool TextCompare) { return default(bool); }
    public static bool ConditionalCompareObjectGreaterEqual(object Left, object Right, bool TextCompare) { return default(bool); }
    public static bool ConditionalCompareObjectLess(object Left, object Right, bool TextCompare) { return default(bool); }
    public static bool ConditionalCompareObjectLessEqual(object Left, object Right, bool TextCompare) { return default(bool); }
    public static bool ConditionalCompareObjectNotEqual(object Left, object Right, bool TextCompare) { return default(bool); }
    public static object DivideObject(object Left, object Right) { return default(object); }
    public static object ExponentObject(object Left, object Right) { return default(object); }
    public static object IntDivideObject(object Left, object Right) { return default(object); }
    public static object LeftShiftObject(object Operand, object Amount) { return default(object); }
    public static object LikeObject(object Source, object Pattern, Microsoft.VisualBasic.CompareMethod CompareOption) { return default(object); }
    public static bool LikeString(string Source, string Pattern, Microsoft.VisualBasic.CompareMethod CompareOption) { return default(bool); }
    public static object ModObject(object Left, object Right) { return default(object); }
    public static object MultiplyObject(object Left, object Right) { return default(object); }
    public static object NegateObject(object Operand) { return default(object); }
    public static object NotObject(object Operand) { return default(object); }
    public static object OrObject(object Left, object Right) { return default(object); }
    public static object PlusObject(object Operand) { return default(object); }
    public static object RightShiftObject(object Operand, object Amount) { return default(object); }
    public static object SubtractObject(object Left, object Right) { return default(object); }
    public static object XorObject(object Left, object Right) { return default(object); }
    public enum CompareResult {
      Equal = 1,
      Greater = 2,
      Less = 0,
      NotResolved = 3,
    }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(2048), Inherited=false, AllowMultiple=false)]
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class OptionCompareAttribute : System.Attribute {
    public OptionCompareAttribute() { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), Inherited=false, AllowMultiple=false)]
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class OptionTextAttribute : System.Attribute {
    public OptionTextAttribute() { }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class ProjectData {
    internal ProjectData() { }
    [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(2))]
    public static void ClearProjectError() { }
    public static System.Exception CreateProjectError(int hr) { return default(System.Exception); }
    public static void EndApp() { }
    [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(2))]
    public static void SetProjectError(System.Exception ex) { }
    [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(2))]
    public static void SetProjectError(System.Exception ex, int lErl) { }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class ShortType {
    internal ShortType() { }
    public static short FromObject(object Value) { return default(short); }
    public static short FromString(string value) { return default(short); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class SingleType {
    internal SingleType() { }
    public static float FromObject(object Value) { return default(float); }
    public static float FromObject(object Value, System.Globalization.NumberFormatInfo NumberFormat) { return default(float); }
    public static float FromString(string value) { return default(float); }
    public static float FromString(string Value, System.Globalization.NumberFormatInfo NumberFormat) { return default(float); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), Inherited=false, AllowMultiple=false)]
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class StandardModuleAttribute : System.Attribute {
    public StandardModuleAttribute() { }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class StaticLocalInitFlag {
    public short State;
    public StaticLocalInitFlag() { }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class StringType {
    internal StringType() { }
    public static string FromBoolean(bool Value) { return default(string); }
    public static string FromByte(byte value) { return default(string); }
    public static string FromChar(char Value) { return default(string); }
    public static string FromDate(System.DateTime value) { return default(string); }
    public static string FromDecimal(decimal Value) { return default(string); }
    public static string FromDecimal(decimal Value, System.Globalization.NumberFormatInfo NumberFormat) { return default(string); }
    public static string FromDouble(double value) { return default(string); }
    public static string FromDouble(double Value, System.Globalization.NumberFormatInfo NumberFormat) { return default(string); }
    public static string FromInteger(int Value) { return default(string); }
    public static string FromLong(long value) { return default(string); }
    public static string FromObject(object Value) { return default(string); }
    public static string FromShort(short value) { return default(string); }
    public static string FromSingle(float value) { return default(string); }
    public static string FromSingle(float Value, System.Globalization.NumberFormatInfo NumberFormat) { return default(string); }
    public static void MidStmtStr(ref string sDest, int StartPosition, int MaxInsertLength, string sInsert) { }
    public static int StrCmp(string sLeft, string sRight, bool textCompare) { return default(int); }
    public static bool StrLike(string Source, string Pattern, Microsoft.VisualBasic.CompareMethod CompareOption) { return default(bool); }
    public static bool StrLikeBinary(string Source, string Pattern) { return default(bool); }
    public static bool StrLikeText(string Source, string Pattern) { return default(bool); }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class Utils {
    internal Utils() { }
    public static System.Array CopyArray(System.Array arySrc, System.Array aryDest) { return default(System.Array); }
    public static string GetResourceString(string ResourceKey, params System.String[] Args) { return default(string); }
    public static string MethodToString(System.Reflection.MethodBase Method) { return default(string); }
    public static object SetCultureInfo(System.Globalization.CultureInfo Culture) { return default(object); }
    public static void ThrowException(int hr) { }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class Versioned {
    internal Versioned() { }
    public static object CallByName(object Instance, string MethodName, Microsoft.VisualBasic.CallType UseCallType, params System.Object[] Arguments) { return default(object); }
    public static bool IsNumeric(object Expression) { return default(bool); }
    public static string SystemTypeName(string VbName) { return default(string); }
    public static string TypeName(object Expression) { return default(string); }
    public static string VbTypeName(string SystemName) { return default(string); }
  }
}
namespace Microsoft.VisualBasic.Devices {
  public partial class Audio {
    public Audio() { }
    public void Play(System.Byte[] data, Microsoft.VisualBasic.AudioPlayMode playMode) { }
    public void Play(System.IO.Stream stream, Microsoft.VisualBasic.AudioPlayMode playMode) { }
    public void Play(string location) { }
    public void Play(string location, Microsoft.VisualBasic.AudioPlayMode playMode) { }
    public void PlaySystemSound(System.Media.SystemSound systemSound) { }
    public void Stop() { }
  }
  public partial class Clock {
    public Clock() { }
    public System.DateTime GmtTime { get { return default(System.DateTime); } }
    public System.DateTime LocalTime { get { return default(System.DateTime); } }
    public int TickCount { get { return default(int); } }
  }
  public partial class Computer : Microsoft.VisualBasic.Devices.ServerComputer {
    public Computer() { }
    public Microsoft.VisualBasic.Devices.Audio Audio { get { return default(Microsoft.VisualBasic.Devices.Audio); } }
    public Microsoft.VisualBasic.MyServices.ClipboardProxy Clipboard { get { return default(Microsoft.VisualBasic.MyServices.ClipboardProxy); } }
    public Microsoft.VisualBasic.Devices.Keyboard Keyboard { get { return default(Microsoft.VisualBasic.Devices.Keyboard); } }
    public Microsoft.VisualBasic.Devices.Mouse Mouse { get { return default(Microsoft.VisualBasic.Devices.Mouse); } }
    public Microsoft.VisualBasic.Devices.Ports Ports { get { return default(Microsoft.VisualBasic.Devices.Ports); } }
    public System.Windows.Forms.Screen Screen { get { return default(System.Windows.Forms.Screen); } }
  }
  [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(Microsoft.VisualBasic.Devices.ComputerInfo.ComputerInfoDebugView))]
  public partial class ComputerInfo {
    public ComputerInfo() { }
    [System.CLSCompliantAttribute(false)]
    public ulong AvailablePhysicalMemory { get { return default(ulong); } }
    [System.CLSCompliantAttribute(false)]
    public ulong AvailableVirtualMemory { get { return default(ulong); } }
    public System.Globalization.CultureInfo InstalledUICulture { get { return default(System.Globalization.CultureInfo); } }
    public string OSFullName { get { return default(string); } }
    public string OSPlatform { get { return default(string); } }
    public string OSVersion { get { return default(string); } }
    [System.CLSCompliantAttribute(false)]
    public ulong TotalPhysicalMemory { get { return default(ulong); } }
    [System.CLSCompliantAttribute(false)]
    public ulong TotalVirtualMemory { get { return default(ulong); } }
  }
  public partial class Keyboard {
    public Keyboard() { }
    public bool AltKeyDown { get { return default(bool); } }
    public bool CapsLock { get { return default(bool); } }
    public bool CtrlKeyDown { get { return default(bool); } }
    public bool NumLock { get { return default(bool); } }
    public bool ScrollLock { get { return default(bool); } }
    public bool ShiftKeyDown { get { return default(bool); } }
    public void SendKeys(string keys) { }
    public void SendKeys(string keys, bool wait) { }
  }
  public partial class Mouse {
    public Mouse() { }
    public bool ButtonsSwapped { get { return default(bool); } }
    public bool WheelExists { get { return default(bool); } }
    public int WheelScrollLines { get { return default(int); } }
  }
  public partial class Network {
    public Network() { }
    public bool IsAvailable { get { return default(bool); } }
    public event Microsoft.VisualBasic.Devices.NetworkAvailableEventHandler NetworkAvailabilityChanged { add { } remove { } }
    public void DownloadFile(string address, string destinationFileName) { }
    public void DownloadFile(string address, string destinationFileName, string userName, string password) { }
    public void DownloadFile(string address, string destinationFileName, string userName, string password, bool showUI, int connectionTimeout, bool overwrite) { }
    public void DownloadFile(string address, string destinationFileName, string userName, string password, bool showUI, int connectionTimeout, bool overwrite, Microsoft.VisualBasic.FileIO.UICancelOption onUserCancel) { }
    public void DownloadFile(System.Uri address, string destinationFileName) { }
    public void DownloadFile(System.Uri address, string destinationFileName, System.Net.ICredentials networkCredentials, bool showUI, int connectionTimeout, bool overwrite) { }
    public void DownloadFile(System.Uri address, string destinationFileName, System.Net.ICredentials networkCredentials, bool showUI, int connectionTimeout, bool overwrite, Microsoft.VisualBasic.FileIO.UICancelOption onUserCancel) { }
    public void DownloadFile(System.Uri address, string destinationFileName, string userName, string password) { }
    public void DownloadFile(System.Uri address, string destinationFileName, string userName, string password, bool showUI, int connectionTimeout, bool overwrite) { }
    public void DownloadFile(System.Uri address, string destinationFileName, string userName, string password, bool showUI, int connectionTimeout, bool overwrite, Microsoft.VisualBasic.FileIO.UICancelOption onUserCancel) { }
    [System.MonoNotSupportedAttribute("")]
    public bool Ping(string hostNameOrAddress) { return default(bool); }
    [System.MonoNotSupportedAttribute("")]
    public bool Ping(string hostNameOrAddress, int timeout) { return default(bool); }
    [System.MonoNotSupportedAttribute("")]
    public bool Ping(System.Uri address) { return default(bool); }
    [System.MonoNotSupportedAttribute("")]
    public bool Ping(System.Uri address, int timeout) { return default(bool); }
    public void UploadFile(string sourceFileName, string address) { }
    public void UploadFile(string sourceFileName, string address, string userName, string password) { }
    public void UploadFile(string sourceFileName, string address, string userName, string password, bool showUI, int connectionTimeout) { }
    public void UploadFile(string sourceFileName, string address, string userName, string password, bool showUI, int connectionTimeout, Microsoft.VisualBasic.FileIO.UICancelOption onUserCancel) { }
    public void UploadFile(string sourceFileName, System.Uri address) { }
    public void UploadFile(string sourceFileName, System.Uri address, System.Net.ICredentials networkCredentials, bool showUI, int connectionTimeout) { }
    public void UploadFile(string sourceFileName, System.Uri address, System.Net.ICredentials networkCredentials, bool showUI, int connectionTimeout, Microsoft.VisualBasic.FileIO.UICancelOption onUserCancel) { }
    public void UploadFile(string sourceFileName, System.Uri address, string userName, string password) { }
    public void UploadFile(string sourceFileName, System.Uri address, string userName, string password, bool showUI, int connectionTimeout) { }
    public void UploadFile(string sourceFileName, System.Uri address, string userName, string password, bool showUI, int connectionTimeout, Microsoft.VisualBasic.FileIO.UICancelOption onUserCancel) { }
  }
  public partial class NetworkAvailableEventArgs : System.EventArgs {
    public NetworkAvailableEventArgs(bool networkAvailable) { }
    public bool IsNetworkAvailable { get { return default(bool); } }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
  public delegate void NetworkAvailableEventHandler(object sender, Microsoft.VisualBasic.Devices.NetworkAvailableEventArgs e);
  public partial class Ports {
    public Ports() { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.String> SerialPortNames { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.String>); } }
    public System.IO.Ports.SerialPort OpenSerialPort(string portName) { return default(System.IO.Ports.SerialPort); }
    public System.IO.Ports.SerialPort OpenSerialPort(string portName, int baudRate) { return default(System.IO.Ports.SerialPort); }
    public System.IO.Ports.SerialPort OpenSerialPort(string portName, int baudRate, System.IO.Ports.Parity parity) { return default(System.IO.Ports.SerialPort); }
    public System.IO.Ports.SerialPort OpenSerialPort(string portName, int baudRate, System.IO.Ports.Parity parity, int dataBits) { return default(System.IO.Ports.SerialPort); }
    public System.IO.Ports.SerialPort OpenSerialPort(string portName, int baudRate, System.IO.Ports.Parity parity, int dataBits, System.IO.Ports.StopBits stopBits) { return default(System.IO.Ports.SerialPort); }
  }
  public partial class ServerComputer {
    public ServerComputer() { }
    public Microsoft.VisualBasic.Devices.Clock Clock { get { return default(Microsoft.VisualBasic.Devices.Clock); } }
    public Microsoft.VisualBasic.MyServices.FileSystemProxy FileSystem { get { return default(Microsoft.VisualBasic.MyServices.FileSystemProxy); } }
    public Microsoft.VisualBasic.Devices.ComputerInfo Info { get { return default(Microsoft.VisualBasic.Devices.ComputerInfo); } }
    public string Name { get { return default(string); } }
    public Microsoft.VisualBasic.Devices.Network Network { get { return default(Microsoft.VisualBasic.Devices.Network); } }
    public Microsoft.VisualBasic.MyServices.RegistryProxy Registry { get { return default(Microsoft.VisualBasic.MyServices.RegistryProxy); } }
  }
}
namespace Microsoft.VisualBasic.FileIO {
  public enum DeleteDirectoryOption {
    DeleteAllContents = 5,
    ThrowIfDirectoryNonEmpty = 4,
  }
  public enum FieldType {
    Delimited = 0,
    FixedWidth = 1,
  }
  public partial class FileSystem {
    public FileSystem() { }
    public static string CurrentDirectory { get { return default(string); } set { } }
    public static System.Collections.ObjectModel.ReadOnlyCollection<System.IO.DriveInfo> Drives { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.IO.DriveInfo>); } }
    public static string CombinePath(string baseDirectory, string relativePath) { return default(string); }
    public static void CopyDirectory(string sourceDirectoryName, string destinationDirectoryName) { }
    public static void CopyDirectory(string sourceDirectoryName, string destinationDirectoryName, Microsoft.VisualBasic.FileIO.UIOption showUI) { }
    public static void CopyDirectory(string sourceDirectoryName, string destinationDirectoryName, Microsoft.VisualBasic.FileIO.UIOption showUI, Microsoft.VisualBasic.FileIO.UICancelOption onUserCancel) { }
    public static void CopyDirectory(string sourceDirectoryName, string destinationDirectoryName, bool overwrite) { }
    public static void CopyFile(string sourceFileName, string destinationFileName) { }
    public static void CopyFile(string sourceFileName, string destinationFileName, Microsoft.VisualBasic.FileIO.UIOption showUI) { }
    public static void CopyFile(string sourceFileName, string destinationFileName, Microsoft.VisualBasic.FileIO.UIOption showUI, Microsoft.VisualBasic.FileIO.UICancelOption onUserCancel) { }
    public static void CopyFile(string sourceFileName, string destinationFileName, bool overwrite) { }
    public static void CreateDirectory(string directory) { }
    public static void DeleteDirectory(string directory, Microsoft.VisualBasic.FileIO.DeleteDirectoryOption onDirectoryNotEmpty) { }
    public static void DeleteDirectory(string directory, Microsoft.VisualBasic.FileIO.UIOption showUI, Microsoft.VisualBasic.FileIO.RecycleOption recycle) { }
    public static void DeleteDirectory(string directory, Microsoft.VisualBasic.FileIO.UIOption showUI, Microsoft.VisualBasic.FileIO.RecycleOption recycle, Microsoft.VisualBasic.FileIO.UICancelOption onUserCancel) { }
    public static void DeleteFile(string file) { }
    public static void DeleteFile(string file, Microsoft.VisualBasic.FileIO.UIOption showUI, Microsoft.VisualBasic.FileIO.RecycleOption recycle) { }
    public static void DeleteFile(string file, Microsoft.VisualBasic.FileIO.UIOption showUI, Microsoft.VisualBasic.FileIO.RecycleOption recycle, Microsoft.VisualBasic.FileIO.UICancelOption onUserCancel) { }
    public static bool DirectoryExists(string directory) { return default(bool); }
    public static bool FileExists(string file) { return default(bool); }
    public static System.Collections.ObjectModel.ReadOnlyCollection<System.String> FindInFiles(string directory, string containsText, bool ignoreCase, Microsoft.VisualBasic.FileIO.SearchOption searchType) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.String>); }
    public static System.Collections.ObjectModel.ReadOnlyCollection<System.String> FindInFiles(string directory, string containsText, bool ignoreCase, Microsoft.VisualBasic.FileIO.SearchOption searchType, params System.String[] fileWildcards) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.String>); }
    public static System.Collections.ObjectModel.ReadOnlyCollection<System.String> GetDirectories(string directory) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.String>); }
    public static System.Collections.ObjectModel.ReadOnlyCollection<System.String> GetDirectories(string directory, Microsoft.VisualBasic.FileIO.SearchOption searchType, params System.String[] wildcards) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.String>); }
    public static System.IO.DirectoryInfo GetDirectoryInfo(string directory) { return default(System.IO.DirectoryInfo); }
    public static System.IO.DriveInfo GetDriveInfo(string drive) { return default(System.IO.DriveInfo); }
    public static System.IO.FileInfo GetFileInfo(string file) { return default(System.IO.FileInfo); }
    public static System.Collections.ObjectModel.ReadOnlyCollection<System.String> GetFiles(string directory) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.String>); }
    public static System.Collections.ObjectModel.ReadOnlyCollection<System.String> GetFiles(string directory, Microsoft.VisualBasic.FileIO.SearchOption searchType, params System.String[] wildcards) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.String>); }
    public static string GetName(string path) { return default(string); }
    public static string GetParentPath(string path) { return default(string); }
    public static string GetTempFileName() { return default(string); }
    public static void MoveDirectory(string sourceDirectoryName, string destinationDirectoryName) { }
    public static void MoveDirectory(string sourceDirectoryName, string destinationDirectoryName, Microsoft.VisualBasic.FileIO.UIOption showUI) { }
    public static void MoveDirectory(string sourceDirectoryName, string destinationDirectoryName, Microsoft.VisualBasic.FileIO.UIOption showUI, Microsoft.VisualBasic.FileIO.UICancelOption onUserCancel) { }
    public static void MoveDirectory(string sourceDirectoryName, string destinationDirectoryName, bool overwrite) { }
    public static void MoveFile(string sourceFileName, string destinationFileName) { }
    public static void MoveFile(string sourceFileName, string destinationFileName, Microsoft.VisualBasic.FileIO.UIOption showUI) { }
    public static void MoveFile(string sourceFileName, string destinationFileName, Microsoft.VisualBasic.FileIO.UIOption showUI, Microsoft.VisualBasic.FileIO.UICancelOption onUserCancel) { }
    public static void MoveFile(string sourceFileName, string destinationFileName, bool overwrite) { }
    public static Microsoft.VisualBasic.FileIO.TextFieldParser OpenTextFieldParser(string file) { return default(Microsoft.VisualBasic.FileIO.TextFieldParser); }
    public static Microsoft.VisualBasic.FileIO.TextFieldParser OpenTextFieldParser(string file, params System.Int32[] fieldWidths) { return default(Microsoft.VisualBasic.FileIO.TextFieldParser); }
    public static Microsoft.VisualBasic.FileIO.TextFieldParser OpenTextFieldParser(string file, params System.String[] delimiters) { return default(Microsoft.VisualBasic.FileIO.TextFieldParser); }
    public static System.IO.StreamReader OpenTextFileReader(string file) { return default(System.IO.StreamReader); }
    public static System.IO.StreamReader OpenTextFileReader(string file, System.Text.Encoding encoding) { return default(System.IO.StreamReader); }
    public static System.IO.StreamWriter OpenTextFileWriter(string file, bool append) { return default(System.IO.StreamWriter); }
    public static System.IO.StreamWriter OpenTextFileWriter(string file, bool append, System.Text.Encoding encoding) { return default(System.IO.StreamWriter); }
    public static System.Byte[] ReadAllBytes(string file) { return default(System.Byte[]); }
    public static string ReadAllText(string file) { return default(string); }
    public static string ReadAllText(string file, System.Text.Encoding encoding) { return default(string); }
    public static void RenameDirectory(string directory, string newName) { }
    public static void RenameFile(string file, string newName) { }
    public static void WriteAllBytes(string file, System.Byte[] data, bool append) { }
    public static void WriteAllText(string file, string text, bool append) { }
    public static void WriteAllText(string file, string text, bool append, System.Text.Encoding encoding) { }
  }
  public partial class MalformedLineException : System.Exception {
    public MalformedLineException() { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    protected MalformedLineException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public MalformedLineException(string message) { }
    public MalformedLineException(string message, System.Exception innerException) { }
    public MalformedLineException(string message, long lineNumber) { }
    public MalformedLineException(string message, long lineNumber, System.Exception innerException) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(0))]
    public long LineNumber { get { return default(long); } set { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, SerializationFormatter=true)]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public override string ToString() { return default(string); }
  }
  public enum RecycleOption {
    DeletePermanently = 2,
    SendToRecycleBin = 3,
  }
  public enum SearchOption {
    SearchAllSubDirectories = 3,
    SearchTopLevelOnly = 2,
  }
  public partial class SpecialDirectories {
    public SpecialDirectories() { }
    public static string AllUsersApplicationData { get { return default(string); } }
    public static string CurrentUserApplicationData { get { return default(string); } }
    public static string Desktop { get { return default(string); } }
    public static string MyDocuments { get { return default(string); } }
    public static string MyMusic { get { return default(string); } }
    public static string MyPictures { get { return default(string); } }
    public static string ProgramFiles { get { return default(string); } }
    public static string Programs { get { return default(string); } }
    public static string Temp { get { return default(string); } }
  }
  public partial class TextFieldParser : System.IDisposable {
    public TextFieldParser(System.IO.Stream stream) { }
    public TextFieldParser(System.IO.Stream stream, System.Text.Encoding defaultEncoding) { }
    public TextFieldParser(System.IO.Stream stream, System.Text.Encoding defaultEncoding, bool detectEncoding) { }
    public TextFieldParser(System.IO.Stream stream, System.Text.Encoding defaultEncoding, bool detectEncoding, bool leaveOpen) { }
    public TextFieldParser(System.IO.TextReader reader) { }
    public TextFieldParser(string path) { }
    public TextFieldParser(string path, System.Text.Encoding defaultEncoding) { }
    public TextFieldParser(string path, System.Text.Encoding defaultEncoding, bool detectEncoding) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public System.String[] CommentTokens { get { return default(System.String[]); } set { } }
    public System.String[] Delimiters { get { return default(System.String[]); } set { } }
    public bool EndOfData { get { return default(bool); } }
    public string ErrorLine { get { return default(string); } }
    public long ErrorLineNumber { get { return default(long); } }
    public System.Int32[] FieldWidths { get { return default(System.Int32[]); } set { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public bool HasFieldsEnclosedInQuotes { get { return default(bool); } set { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public long LineNumber { get { return default(long); } }
    public Microsoft.VisualBasic.FileIO.FieldType TextFieldType { get { return default(Microsoft.VisualBasic.FileIO.FieldType); } set { } }
    public bool TrimWhiteSpace { get { return default(bool); } set { } }
    public void Close() { }
    void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    ~TextFieldParser() { }
    public string PeekChars(int numberOfChars) { return default(string); }
    public System.String[] ReadFields() { return default(System.String[]); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public string ReadLine() { return default(string); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public string ReadToEnd() { return default(string); }
    public void SetDelimiters(params System.String[] delimiters) { }
    public void SetFieldWidths(params System.Int32[] fieldWidths) { }
  }
  public enum UICancelOption {
    DoNothing = 2,
    ThrowException = 3,
  }
  public enum UIOption {
    AllDialogs = 3,
    OnlyErrorDialogs = 2,
  }
}
namespace Microsoft.VisualBasic.Logging {
  public partial class AspLog : Microsoft.VisualBasic.Logging.Log {
    public AspLog() { }
    public AspLog(string name) { }
    protected internal override void InitializeWithDefaultsSinceNoConfigExists() { }
  }
  public enum DiskSpaceExhaustedOption {
    DiscardMessages = 1,
    ThrowException = 0,
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public partial class FileLogTraceListener : System.Diagnostics.TraceListener {
    public FileLogTraceListener() { }
    public FileLogTraceListener(string name) { }
    public bool Append { get { return default(bool); } set { } }
    public bool AutoFlush { get { return default(bool); } set { } }
    public string BaseFileName { get { return default(string); } set { } }
    public string CustomLocation { get { return default(string); } set { } }
    public string Delimiter { get { return default(string); } set { } }
    public Microsoft.VisualBasic.Logging.DiskSpaceExhaustedOption DiskSpaceExhaustedBehavior { get { return default(Microsoft.VisualBasic.Logging.DiskSpaceExhaustedOption); } set { } }
    public System.Text.Encoding Encoding { get { return default(System.Text.Encoding); } set { } }
    public string FullLogFileName { get { return default(string); } }
    public bool IncludeHostName { get { return default(bool); } set { } }
    public Microsoft.VisualBasic.Logging.LogFileLocation Location { get { return default(Microsoft.VisualBasic.Logging.LogFileLocation); } set { } }
    public Microsoft.VisualBasic.Logging.LogFileCreationScheduleOption LogFileCreationSchedule { get { return default(Microsoft.VisualBasic.Logging.LogFileCreationScheduleOption); } set { } }
    public long MaxFileSize { get { return default(long); } set { } }
    public long ReserveDiskSpace { get { return default(long); } set { } }
    public override void Close() { }
    protected override void Dispose(bool disposing) { }
    public override void Flush() { }
    protected override System.String[] GetSupportedAttributes() { return default(System.String[]); }
    public override void TraceData(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, object data) { }
    public override void TraceData(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, params System.Object[] data) { }
    public override void TraceEvent(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, string message) { }
    public override void TraceEvent(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, string format, params System.Object[] args) { }
    public override void Write(string message) { }
    public override void WriteLine(string message) { }
  }
  public partial class Log {
    public Log() { }
    public Log(string name) { }
    public Microsoft.VisualBasic.Logging.FileLogTraceListener DefaultFileLogWriter { get { return default(Microsoft.VisualBasic.Logging.FileLogTraceListener); } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public System.Diagnostics.TraceSource TraceSource { get { return default(System.Diagnostics.TraceSource); } }
    protected internal virtual void InitializeWithDefaultsSinceNoConfigExists() { }
    public void WriteEntry(string message) { }
    public void WriteEntry(string message, System.Diagnostics.TraceEventType severity) { }
    public void WriteEntry(string message, System.Diagnostics.TraceEventType severity, int id) { }
    public void WriteException(System.Exception ex) { }
    public void WriteException(System.Exception ex, System.Diagnostics.TraceEventType severity, string additionalInfo) { }
    public void WriteException(System.Exception ex, System.Diagnostics.TraceEventType severity, string additionalInfo, int id) { }
  }
  public enum LogFileCreationScheduleOption {
    Daily = 1,
    None = 0,
    Weekly = 2,
  }
  public enum LogFileLocation {
    CommonApplicationDirectory = 2,
    Custom = 4,
    ExecutableDirectory = 3,
    LocalUserApplicationDirectory = 1,
    TempDirectory = 0,
  }
}
namespace Microsoft.VisualBasic.MyServices {
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public partial class ClipboardProxy {
    internal ClipboardProxy() { }
    public void Clear() { }
    public bool ContainsAudio() { return default(bool); }
    public bool ContainsData(string format) { return default(bool); }
    public bool ContainsFileDropList() { return default(bool); }
    public bool ContainsImage() { return default(bool); }
    public bool ContainsText() { return default(bool); }
    public bool ContainsText(System.Windows.Forms.TextDataFormat format) { return default(bool); }
    public System.IO.Stream GetAudioStream() { return default(System.IO.Stream); }
    public object GetData(string format) { return default(object); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public System.Windows.Forms.IDataObject GetDataObject() { return default(System.Windows.Forms.IDataObject); }
    public System.Collections.Specialized.StringCollection GetFileDropList() { return default(System.Collections.Specialized.StringCollection); }
    public System.Drawing.Image GetImage() { return default(System.Drawing.Image); }
    public string GetText() { return default(string); }
    public string GetText(System.Windows.Forms.TextDataFormat format) { return default(string); }
    public void SetAudio(System.Byte[] audioBytes) { }
    public void SetAudio(System.IO.Stream audioStream) { }
    public void SetData(string format, object data) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public void SetDataObject(System.Windows.Forms.DataObject data) { }
    public void SetFileDropList(System.Collections.Specialized.StringCollection filePaths) { }
    public void SetImage(System.Drawing.Image image) { }
    public void SetText(string text) { }
    public void SetText(string text, System.Windows.Forms.TextDataFormat format) { }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public partial class FileSystemProxy {
    internal FileSystemProxy() { }
    public string CurrentDirectory { get { return default(string); } set { } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.IO.DriveInfo> Drives { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.IO.DriveInfo>); } }
    public Microsoft.VisualBasic.MyServices.SpecialDirectoriesProxy SpecialDirectories { get { return default(Microsoft.VisualBasic.MyServices.SpecialDirectoriesProxy); } }
    public string CombinePath(string baseDirectory, string relativePath) { return default(string); }
    public void CopyDirectory(string sourceDirectoryName, string destinationDirectoryName) { }
    public void CopyDirectory(string sourceDirectoryName, string destinationDirectoryName, Microsoft.VisualBasic.FileIO.UIOption showUI) { }
    public void CopyDirectory(string sourceDirectoryName, string destinationDirectoryName, Microsoft.VisualBasic.FileIO.UIOption showUI, Microsoft.VisualBasic.FileIO.UICancelOption onUserCancel) { }
    public void CopyDirectory(string sourceDirectoryName, string destinationDirectoryName, bool overwrite) { }
    public void CopyFile(string sourceFileName, string destinationFileName) { }
    public void CopyFile(string sourceFileName, string destinationFileName, Microsoft.VisualBasic.FileIO.UIOption showUI) { }
    public void CopyFile(string sourceFileName, string destinationFileName, Microsoft.VisualBasic.FileIO.UIOption showUI, Microsoft.VisualBasic.FileIO.UICancelOption onUserCancel) { }
    public void CopyFile(string sourceFileName, string destinationFileName, bool overwrite) { }
    public void CreateDirectory(string directory) { }
    public void DeleteDirectory(string directory, Microsoft.VisualBasic.FileIO.DeleteDirectoryOption onDirectoryNotEmpty) { }
    public void DeleteDirectory(string directory, Microsoft.VisualBasic.FileIO.UIOption showUI, Microsoft.VisualBasic.FileIO.RecycleOption recycle) { }
    public void DeleteDirectory(string directory, Microsoft.VisualBasic.FileIO.UIOption showUI, Microsoft.VisualBasic.FileIO.RecycleOption recycle, Microsoft.VisualBasic.FileIO.UICancelOption onUserCancel) { }
    public void DeleteFile(string file) { }
    public void DeleteFile(string file, Microsoft.VisualBasic.FileIO.UIOption showUI, Microsoft.VisualBasic.FileIO.RecycleOption recycle) { }
    public void DeleteFile(string file, Microsoft.VisualBasic.FileIO.UIOption showUI, Microsoft.VisualBasic.FileIO.RecycleOption recycle, Microsoft.VisualBasic.FileIO.UICancelOption onUserCancel) { }
    public bool DirectoryExists(string directory) { return default(bool); }
    public bool FileExists(string file) { return default(bool); }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.String> FindInFiles(string directory, string containsText, bool ignoreCase, Microsoft.VisualBasic.FileIO.SearchOption searchType) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.String>); }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.String> FindInFiles(string directory, string containsText, bool ignoreCase, Microsoft.VisualBasic.FileIO.SearchOption searchType, params System.String[] fileWildcards) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.String>); }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.String> GetDirectories(string directory) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.String>); }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.String> GetDirectories(string directory, Microsoft.VisualBasic.FileIO.SearchOption searchType, params System.String[] wildcards) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.String>); }
    public System.IO.DirectoryInfo GetDirectoryInfo(string directory) { return default(System.IO.DirectoryInfo); }
    public System.IO.DriveInfo GetDriveInfo(string drive) { return default(System.IO.DriveInfo); }
    public System.IO.FileInfo GetFileInfo(string file) { return default(System.IO.FileInfo); }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.String> GetFiles(string directory) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.String>); }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.String> GetFiles(string directory, Microsoft.VisualBasic.FileIO.SearchOption searchType, params System.String[] wildcards) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.String>); }
    public string GetName(string path) { return default(string); }
    public string GetParentPath(string path) { return default(string); }
    public string GetTempFileName() { return default(string); }
    public void MoveDirectory(string sourceDirectoryName, string destinationDirectoryName) { }
    public void MoveDirectory(string sourceDirectoryName, string destinationDirectoryName, Microsoft.VisualBasic.FileIO.UIOption showUI) { }
    public void MoveDirectory(string sourceDirectoryName, string destinationDirectoryName, Microsoft.VisualBasic.FileIO.UIOption showUI, Microsoft.VisualBasic.FileIO.UICancelOption onUserCancel) { }
    public void MoveDirectory(string sourceDirectoryName, string destinationDirectoryName, bool overwrite) { }
    public void MoveFile(string sourceFileName, string destinationFileName) { }
    public void MoveFile(string sourceFileName, string destinationFileName, Microsoft.VisualBasic.FileIO.UIOption showUI) { }
    public void MoveFile(string sourceFileName, string destinationFileName, Microsoft.VisualBasic.FileIO.UIOption showUI, Microsoft.VisualBasic.FileIO.UICancelOption onUserCancel) { }
    public void MoveFile(string sourceFileName, string destinationFileName, bool overwrite) { }
    public Microsoft.VisualBasic.FileIO.TextFieldParser OpenTextFieldParser(string file) { return default(Microsoft.VisualBasic.FileIO.TextFieldParser); }
    public Microsoft.VisualBasic.FileIO.TextFieldParser OpenTextFieldParser(string file, params System.Int32[] fieldWidths) { return default(Microsoft.VisualBasic.FileIO.TextFieldParser); }
    public Microsoft.VisualBasic.FileIO.TextFieldParser OpenTextFieldParser(string file, params System.String[] delimiters) { return default(Microsoft.VisualBasic.FileIO.TextFieldParser); }
    public System.IO.StreamReader OpenTextFileReader(string file) { return default(System.IO.StreamReader); }
    public System.IO.StreamReader OpenTextFileReader(string file, System.Text.Encoding encoding) { return default(System.IO.StreamReader); }
    public System.IO.StreamWriter OpenTextFileWriter(string file, bool append) { return default(System.IO.StreamWriter); }
    public System.IO.StreamWriter OpenTextFileWriter(string file, bool append, System.Text.Encoding encoding) { return default(System.IO.StreamWriter); }
    public System.Byte[] ReadAllBytes(string file) { return default(System.Byte[]); }
    public string ReadAllText(string file) { return default(string); }
    public string ReadAllText(string file, System.Text.Encoding encoding) { return default(string); }
    public void RenameDirectory(string directory, string newName) { }
    public void RenameFile(string file, string newName) { }
    public void WriteAllBytes(string file, System.Byte[] data, bool append) { }
    public void WriteAllText(string file, string text, bool append) { }
    public void WriteAllText(string file, string text, bool append, System.Text.Encoding encoding) { }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public partial class RegistryProxy {
    internal RegistryProxy() { }
    public Microsoft.Win32.RegistryKey ClassesRoot { get { return default(Microsoft.Win32.RegistryKey); } }
    public Microsoft.Win32.RegistryKey CurrentConfig { get { return default(Microsoft.Win32.RegistryKey); } }
    public Microsoft.Win32.RegistryKey CurrentUser { get { return default(Microsoft.Win32.RegistryKey); } }
    public Microsoft.Win32.RegistryKey DynData { get { return default(Microsoft.Win32.RegistryKey); } }
    public Microsoft.Win32.RegistryKey LocalMachine { get { return default(Microsoft.Win32.RegistryKey); } }
    public Microsoft.Win32.RegistryKey PerformanceData { get { return default(Microsoft.Win32.RegistryKey); } }
    public Microsoft.Win32.RegistryKey Users { get { return default(Microsoft.Win32.RegistryKey); } }
    public object GetValue(string keyName, string valueName, object defaultValue) { return default(object); }
    public void SetValue(string keyName, string valueName, object value) { }
    public void SetValue(string keyName, string valueName, object value, Microsoft.Win32.RegistryValueKind valueKind) { }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public partial class SpecialDirectoriesProxy {
    internal SpecialDirectoriesProxy() { }
    public string AllUsersApplicationData { get { return default(string); } }
    public string CurrentUserApplicationData { get { return default(string); } }
    public string Desktop { get { return default(string); } }
    public string MyDocuments { get { return default(string); } }
    public string MyMusic { get { return default(string); } }
    public string MyPictures { get { return default(string); } }
    public string ProgramFiles { get { return default(string); } }
    public string Programs { get { return default(string); } }
    public string Temp { get { return default(string); } }
  }
}
namespace Microsoft.VisualBasic.MyServices.Internal {
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public partial class ContextValue<T> {
    public ContextValue() { }
    public T Value { get { return default(T); } set { } }
  }
}
