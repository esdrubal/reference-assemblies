namespace Accessibility {
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit, Size=4)]
  public partial struct __MIDL_IWinTypes_0009 {
    [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
    public int hInproc;
    [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
    public int hRemote;
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct _RemotableHandle {
    public int fContext;
    public Accessibility.__MIDL_IWinTypes_0009 u;
  }
  public enum AnnoScope {
    ANNO_CONTAINER = 1,
    ANNO_THIS = 0,
  }
  [System.Runtime.InteropServices.CoClassAttribute(typeof(Accessibility.CAccPropServicesClass))]
  [System.Runtime.InteropServices.GuidAttribute("6E26E776-04F0-495D-80E4-3330352E3169")]
  public partial interface CAccPropServices : Accessibility.IAccPropServices {
  }
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(0))]
  [System.Runtime.InteropServices.ComConversionLossAttribute]
  [System.Runtime.InteropServices.GuidAttribute("B5F8350B-0548-48B1-A6EE-88BD00B4A5E7")]
  [System.Runtime.InteropServices.TypeLibTypeAttribute((System.Runtime.InteropServices.TypeLibTypeFlags)(2))]
  public partial class CAccPropServicesClass : Accessibility.CAccPropServices, Accessibility.IAccPropServices {
    public CAccPropServicesClass() { }
    virtual void ClearHmenuProps([System.Runtime.InteropServices.ComAliasNameAttribute("Accessibility.wireHMENU")]ref Accessibility._RemotableHandle hmenu, uint idChild, ref System.Guid paProps, int cProps) { }
    virtual void ClearHwndProps([System.Runtime.InteropServices.ComAliasNameAttribute("Accessibility.wireHWND")]ref Accessibility._RemotableHandle hwnd, uint idObject, uint idChild, ref System.Guid paProps, int cProps) { }
    virtual void ClearProps(ref byte pIDString, uint dwIDStringLen, ref System.Guid paProps, int cProps) { }
    virtual void ComposeHmenuIdentityString([System.Runtime.InteropServices.ComAliasNameAttribute("Accessibility.wireHMENU")]ref Accessibility._RemotableHandle hmenu, uint idChild, System.IntPtr ppIDString, out uint pdwIDStringLen) { ppIDString = default(System.IntPtr); pdwIDStringLen = default(uint); }
    virtual void ComposeHwndIdentityString([System.Runtime.InteropServices.ComAliasNameAttribute("Accessibility.wireHWND")]ref Accessibility._RemotableHandle hwnd, uint idObject, uint idChild, System.IntPtr ppIDString, out uint pdwIDStringLen) { ppIDString = default(System.IntPtr); pdwIDStringLen = default(uint); }
    virtual void DecomposeHmenuIdentityString(ref byte pIDString, uint dwIDStringLen, [System.Runtime.InteropServices.ComAliasNameAttribute("Accessibility.wireHMENU")]System.IntPtr phmenu, out uint pidChild) { phmenu = default(System.IntPtr); pidChild = default(uint); }
    virtual void DecomposeHwndIdentityString(ref byte pIDString, uint dwIDStringLen, [System.Runtime.InteropServices.ComAliasNameAttribute("Accessibility.wireHWND")]System.IntPtr phwnd, out uint pidObject, out uint pidChild) { phwnd = default(System.IntPtr); pidObject = default(uint); pidChild = default(uint); }
    virtual void SetHmenuProp([System.Runtime.InteropServices.ComAliasNameAttribute("Accessibility.wireHMENU")]ref Accessibility._RemotableHandle hmenu, uint idChild, System.Guid idProp, object var) { }
    virtual void SetHmenuPropServer([System.Runtime.InteropServices.ComAliasNameAttribute("Accessibility.wireHMENU")]ref Accessibility._RemotableHandle hmenu, uint idChild, ref System.Guid paProps, int cProps, Accessibility.IAccPropServer pServer, Accessibility.AnnoScope AnnoScope) { }
    virtual void SetHmenuPropStr([System.Runtime.InteropServices.ComAliasNameAttribute("Accessibility.wireHMENU")]ref Accessibility._RemotableHandle hmenu, uint idChild, System.Guid idProp, string str) { }
    virtual void SetHwndProp([System.Runtime.InteropServices.ComAliasNameAttribute("Accessibility.wireHWND")]ref Accessibility._RemotableHandle hwnd, uint idObject, uint idChild, System.Guid idProp, object var) { }
    virtual void SetHwndPropServer([System.Runtime.InteropServices.ComAliasNameAttribute("Accessibility.wireHWND")]ref Accessibility._RemotableHandle hwnd, uint idObject, uint idChild, ref System.Guid paProps, int cProps, Accessibility.IAccPropServer pServer, Accessibility.AnnoScope AnnoScope) { }
    virtual void SetHwndPropStr([System.Runtime.InteropServices.ComAliasNameAttribute("Accessibility.wireHWND")]ref Accessibility._RemotableHandle hwnd, uint idObject, uint idChild, System.Guid idProp, string str) { }
    virtual void SetPropServer(ref byte pIDString, uint dwIDStringLen, ref System.Guid paProps, int cProps, Accessibility.IAccPropServer pServer, Accessibility.AnnoScope AnnoScope) { }
    virtual void SetPropValue(ref byte pIDString, uint dwIDStringLen, System.Guid idProp, object var) { }
  }
  [System.Runtime.InteropServices.GuidAttribute("618736E0-3C3D-11CF-810C-00AA00389B71")]
  [System.Runtime.InteropServices.TypeLibTypeAttribute((System.Runtime.InteropServices.TypeLibTypeFlags)(4176))]
  public partial interface IAccessible {
    [System.Runtime.CompilerServices.IndexerName("accChild")]
    [System.Runtime.InteropServices.DispIdAttribute(-5002)]
    object this[object varChild] { [System.Runtime.InteropServices.DispIdAttribute(-5002), System.Runtime.InteropServices.TypeLibFuncAttribute((System.Runtime.InteropServices.TypeLibFuncFlags)(64))]get; }
    [System.Runtime.InteropServices.DispIdAttribute(-5001)]
    int accChildCount { [System.Runtime.InteropServices.DispIdAttribute(-5001), System.Runtime.InteropServices.TypeLibFuncAttribute((System.Runtime.InteropServices.TypeLibFuncFlags)(64))]get; }
    [System.Runtime.CompilerServices.IndexerName("accDefaultAction")]
    [System.Runtime.InteropServices.DispIdAttribute(-5013)]
    string this[object varChild] { [System.Runtime.InteropServices.DispIdAttribute(-5013), System.Runtime.InteropServices.TypeLibFuncAttribute((System.Runtime.InteropServices.TypeLibFuncFlags)(64))]get; }
    [System.Runtime.CompilerServices.IndexerName("accDescription")]
    [System.Runtime.InteropServices.DispIdAttribute(-5005)]
    string this[object varChild] { [System.Runtime.InteropServices.DispIdAttribute(-5005), System.Runtime.InteropServices.TypeLibFuncAttribute((System.Runtime.InteropServices.TypeLibFuncFlags)(64))]get; }
    [System.Runtime.InteropServices.DispIdAttribute(-5011)]
    object accFocus { [System.Runtime.InteropServices.DispIdAttribute(-5011), System.Runtime.InteropServices.TypeLibFuncAttribute((System.Runtime.InteropServices.TypeLibFuncFlags)(64))]get; }
    [System.Runtime.CompilerServices.IndexerName("accHelp")]
    [System.Runtime.InteropServices.DispIdAttribute(-5008)]
    string this[object varChild] { [System.Runtime.InteropServices.DispIdAttribute(-5008), System.Runtime.InteropServices.TypeLibFuncAttribute((System.Runtime.InteropServices.TypeLibFuncFlags)(64))]get; }
    [System.Runtime.CompilerServices.IndexerName("accHelpTopic")]
    [System.Runtime.InteropServices.DispIdAttribute(-5009)]
    int this[out string pszHelpFile, object varChild] { [System.Runtime.InteropServices.DispIdAttribute(-5009), System.Runtime.InteropServices.TypeLibFuncAttribute((System.Runtime.InteropServices.TypeLibFuncFlags)(64))]get; }
    [System.Runtime.CompilerServices.IndexerName("accKeyboardShortcut")]
    [System.Runtime.InteropServices.DispIdAttribute(-5010)]
    string this[object varChild] { [System.Runtime.InteropServices.DispIdAttribute(-5010), System.Runtime.InteropServices.TypeLibFuncAttribute((System.Runtime.InteropServices.TypeLibFuncFlags)(64))]get; }
    [System.Runtime.CompilerServices.IndexerName("accName")]
    [System.Runtime.InteropServices.DispIdAttribute(-5003)]
    string this[object varChild] { [System.Runtime.InteropServices.DispIdAttribute(-5003), System.Runtime.InteropServices.TypeLibFuncAttribute((System.Runtime.InteropServices.TypeLibFuncFlags)(64))]get; [System.Runtime.InteropServices.DispIdAttribute(-5003), System.Runtime.InteropServices.TypeLibFuncAttribute((System.Runtime.InteropServices.TypeLibFuncFlags)(64))]set; }
    [System.Runtime.InteropServices.DispIdAttribute(-5000)]
    object accParent { [System.Runtime.InteropServices.DispIdAttribute(-5000), System.Runtime.InteropServices.TypeLibFuncAttribute((System.Runtime.InteropServices.TypeLibFuncFlags)(64))]get; }
    [System.Runtime.CompilerServices.IndexerName("accRole")]
    [System.Runtime.InteropServices.DispIdAttribute(-5006)]
    object this[object varChild] { [System.Runtime.InteropServices.DispIdAttribute(-5006), System.Runtime.InteropServices.TypeLibFuncAttribute((System.Runtime.InteropServices.TypeLibFuncFlags)(64))]get; }
    [System.Runtime.InteropServices.DispIdAttribute(-5012)]
    object accSelection { [System.Runtime.InteropServices.DispIdAttribute(-5012), System.Runtime.InteropServices.TypeLibFuncAttribute((System.Runtime.InteropServices.TypeLibFuncFlags)(64))]get; }
    [System.Runtime.CompilerServices.IndexerName("accState")]
    [System.Runtime.InteropServices.DispIdAttribute(-5007)]
    object this[object varChild] { [System.Runtime.InteropServices.DispIdAttribute(-5007), System.Runtime.InteropServices.TypeLibFuncAttribute((System.Runtime.InteropServices.TypeLibFuncFlags)(64))]get; }
    [System.Runtime.CompilerServices.IndexerName("accValue")]
    [System.Runtime.InteropServices.DispIdAttribute(-5004)]
    string this[object varChild] { [System.Runtime.InteropServices.DispIdAttribute(-5004), System.Runtime.InteropServices.TypeLibFuncAttribute((System.Runtime.InteropServices.TypeLibFuncFlags)(64))]get; [System.Runtime.InteropServices.DispIdAttribute(-5004), System.Runtime.InteropServices.TypeLibFuncAttribute((System.Runtime.InteropServices.TypeLibFuncFlags)(64))]set; }
    [System.Runtime.InteropServices.DispIdAttribute(-5018)]
    [System.Runtime.InteropServices.TypeLibFuncAttribute((System.Runtime.InteropServices.TypeLibFuncFlags)(64))]
    void accDoDefaultAction(object varChild);
    [System.Runtime.InteropServices.DispIdAttribute(-5017)]
    [System.Runtime.InteropServices.TypeLibFuncAttribute((System.Runtime.InteropServices.TypeLibFuncFlags)(64))]
    object accHitTest(int xLeft, int yTop);
    [System.Runtime.InteropServices.DispIdAttribute(-5015)]
    [System.Runtime.InteropServices.TypeLibFuncAttribute((System.Runtime.InteropServices.TypeLibFuncFlags)(64))]
    void accLocation(out int pxLeft, out int pyTop, out int pcxWidth, out int pcyHeight, object varChild);
    [System.Runtime.InteropServices.DispIdAttribute(-5016)]
    [System.Runtime.InteropServices.TypeLibFuncAttribute((System.Runtime.InteropServices.TypeLibFuncFlags)(64))]
    object accNavigate(int navDir, object varStart);
    [System.Runtime.InteropServices.DispIdAttribute(-5014)]
    [System.Runtime.InteropServices.TypeLibFuncAttribute((System.Runtime.InteropServices.TypeLibFuncFlags)(64))]
    void accSelect(int flagsSelect, object varChild);
  }
  [System.Runtime.InteropServices.GuidAttribute("03022430-ABC4-11D0-BDE2-00AA001A1953")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
  [System.Runtime.InteropServices.TypeLibTypeAttribute((System.Runtime.InteropServices.TypeLibTypeFlags)(272))]
  public partial interface IAccessibleHandler {
    void AccessibleObjectFromID(int hwnd, int lObjectID, out Accessibility.IAccessible pIAccessible);
  }
  [System.Runtime.InteropServices.ComConversionLossAttribute]
  [System.Runtime.InteropServices.GuidAttribute("7852B78D-1CFD-41C1-A615-9C0C85960B5F")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
  public partial interface IAccIdentity {
    void GetIdentityString(uint dwIDChild, System.IntPtr ppIDString, out uint pdwIDStringLen);
  }
  [System.Runtime.InteropServices.GuidAttribute("76C0DBBB-15E0-4E7B-B61B-20EEEA2001E0")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
  public partial interface IAccPropServer {
    void GetPropValue(ref byte pIDString, uint dwIDStringLen, System.Guid idProp, out object pvarValue, out int pfHasProp);
  }
  [System.Runtime.InteropServices.ComConversionLossAttribute]
  [System.Runtime.InteropServices.GuidAttribute("6E26E776-04F0-495D-80E4-3330352E3169")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
  public partial interface IAccPropServices {
    void ClearHmenuProps([System.Runtime.InteropServices.ComAliasNameAttribute("Accessibility.wireHMENU")]ref Accessibility._RemotableHandle hmenu, uint idChild, ref System.Guid paProps, int cProps);
    void ClearHwndProps([System.Runtime.InteropServices.ComAliasNameAttribute("Accessibility.wireHWND")]ref Accessibility._RemotableHandle hwnd, uint idObject, uint idChild, ref System.Guid paProps, int cProps);
    void ClearProps(ref byte pIDString, uint dwIDStringLen, ref System.Guid paProps, int cProps);
    void ComposeHmenuIdentityString([System.Runtime.InteropServices.ComAliasNameAttribute("Accessibility.wireHMENU")]ref Accessibility._RemotableHandle hmenu, uint idChild, System.IntPtr ppIDString, out uint pdwIDStringLen);
    void ComposeHwndIdentityString([System.Runtime.InteropServices.ComAliasNameAttribute("Accessibility.wireHWND")]ref Accessibility._RemotableHandle hwnd, uint idObject, uint idChild, System.IntPtr ppIDString, out uint pdwIDStringLen);
    void DecomposeHmenuIdentityString(ref byte pIDString, uint dwIDStringLen, [System.Runtime.InteropServices.ComAliasNameAttribute("Accessibility.wireHMENU")]System.IntPtr phmenu, out uint pidChild);
    void DecomposeHwndIdentityString(ref byte pIDString, uint dwIDStringLen, [System.Runtime.InteropServices.ComAliasNameAttribute("Accessibility.wireHWND")]System.IntPtr phwnd, out uint pidObject, out uint pidChild);
    void SetHmenuProp([System.Runtime.InteropServices.ComAliasNameAttribute("Accessibility.wireHMENU")]ref Accessibility._RemotableHandle hmenu, uint idChild, System.Guid idProp, object var);
    void SetHmenuPropServer([System.Runtime.InteropServices.ComAliasNameAttribute("Accessibility.wireHMENU")]ref Accessibility._RemotableHandle hmenu, uint idChild, ref System.Guid paProps, int cProps, Accessibility.IAccPropServer pServer, Accessibility.AnnoScope AnnoScope);
    void SetHmenuPropStr([System.Runtime.InteropServices.ComAliasNameAttribute("Accessibility.wireHMENU")]ref Accessibility._RemotableHandle hmenu, uint idChild, System.Guid idProp, string str);
    void SetHwndProp([System.Runtime.InteropServices.ComAliasNameAttribute("Accessibility.wireHWND")]ref Accessibility._RemotableHandle hwnd, uint idObject, uint idChild, System.Guid idProp, object var);
    void SetHwndPropServer([System.Runtime.InteropServices.ComAliasNameAttribute("Accessibility.wireHWND")]ref Accessibility._RemotableHandle hwnd, uint idObject, uint idChild, ref System.Guid paProps, int cProps, Accessibility.IAccPropServer pServer, Accessibility.AnnoScope AnnoScope);
    void SetHwndPropStr([System.Runtime.InteropServices.ComAliasNameAttribute("Accessibility.wireHWND")]ref Accessibility._RemotableHandle hwnd, uint idObject, uint idChild, System.Guid idProp, string str);
    void SetPropServer(ref byte pIDString, uint dwIDStringLen, ref System.Guid paProps, int cProps, Accessibility.IAccPropServer pServer, Accessibility.AnnoScope AnnoScope);
    void SetPropValue(ref byte pIDString, uint dwIDStringLen, System.Guid idProp, object var);
  }
}
