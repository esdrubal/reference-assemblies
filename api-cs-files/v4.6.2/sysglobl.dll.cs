namespace System.Globalization {
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public sealed partial class CultureAndRegionInfoBuilder {
    public CultureAndRegionInfoBuilder(string cultureName, System.Globalization.CultureAndRegionModifiers flags) { }
    public System.Globalization.Calendar[] AvailableCalendars { get { return default(System.Globalization.Calendar[]); } set { } }
    public System.Globalization.CompareInfo CompareInfo { get { return default(System.Globalization.CompareInfo); } set { } }
    public System.Globalization.CultureInfo ConsoleFallbackUICulture { get { return default(System.Globalization.CultureInfo); } set { } }
    public string CultureEnglishName { get { return default(string); } set { } }
    public string CultureName { get { return default(string); } }
    public string CultureNativeName { get { return default(string); } set { } }
    public System.Globalization.CultureTypes CultureTypes { get { return default(System.Globalization.CultureTypes); } }
    public string CurrencyEnglishName { get { return default(string); } set { } }
    public string CurrencyNativeName { get { return default(string); } set { } }
    public int GeoId { get { return default(int); } set { } }
    public System.Globalization.DateTimeFormatInfo GregorianDateTimeFormat { get { return default(System.Globalization.DateTimeFormatInfo); } set { } }
    public string IetfLanguageTag { get { return default(string); } set { } }
    public bool IsMetric { get { return default(bool); } set { } }
    public string ISOCurrencySymbol { get { return default(string); } set { } }
    public bool IsRightToLeft { get { return default(bool); } set { } }
    public int KeyboardLayoutId { get { return default(int); } set { } }
    public int LCID { get { return default(int); } }
    public System.Globalization.NumberFormatInfo NumberFormat { get { return default(System.Globalization.NumberFormatInfo); } set { } }
    public System.Globalization.CultureInfo Parent { get { return default(System.Globalization.CultureInfo); } set { } }
    public string RegionEnglishName { get { return default(string); } set { } }
    public string RegionName { get { return default(string); } }
    public string RegionNativeName { get { return default(string); } set { } }
    public System.Globalization.TextInfo TextInfo { get { return default(System.Globalization.TextInfo); } set { } }
    public string ThreeLetterISOLanguageName { get { return default(string); } set { } }
    public string ThreeLetterISORegionName { get { return default(string); } set { } }
    public string ThreeLetterWindowsLanguageName { get { return default(string); } set { } }
    public string ThreeLetterWindowsRegionName { get { return default(string); } set { } }
    public string TwoLetterISOLanguageName { get { return default(string); } set { } }
    public string TwoLetterISORegionName { get { return default(string); } set { } }
    public static System.Globalization.CultureAndRegionInfoBuilder CreateFromLdml(string xmlFileName) { return default(System.Globalization.CultureAndRegionInfoBuilder); }
    public void LoadDataFromCultureInfo(System.Globalization.CultureInfo culture) { }
    public void LoadDataFromRegionInfo(System.Globalization.RegionInfo region) { }
    public void Register() { }
    public void Save(string filename) { }
    public static void Unregister(string cultureName) { }
  }
  [System.FlagsAttribute]
  public enum CultureAndRegionModifiers {
    Neutral = 1,
    None = 0,
    Replacement = 2,
  }
}
