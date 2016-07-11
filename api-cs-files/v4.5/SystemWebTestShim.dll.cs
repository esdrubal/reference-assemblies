namespace SystemWebTestShim {
  public partial class BuildManager {
    public BuildManager() { }
    public static void SuppressDebugModeMessages() { }
  }
  public partial class DataBoundControlAdapter : System.Web.UI.WebControls.Adapters.DataBoundControlAdapter {
    public DataBoundControlAdapter(System.Web.UI.WebControls.DataBoundControl c) { }
    public new void PerformDataBinding(System.Collections.IEnumerable data) { }
  }
  public partial class HideDisabledControlAdapter : System.Web.UI.WebControls.Adapters.HideDisabledControlAdapter {
    public HideDisabledControlAdapter(System.Web.UI.WebControls.WebControl c) { }
    public new void Render(System.Web.UI.HtmlTextWriter w) { }
  }
  public partial class HierarchicalDataBoundControlAdapter : System.Web.UI.WebControls.Adapters.HierarchicalDataBoundControlAdapter {
    public HierarchicalDataBoundControlAdapter(System.Web.UI.WebControls.HierarchicalDataBoundControl h) { }
    public new void PerformDataBinding() { }
  }
  public partial class HttpCapabilitiesBase {
    public HttpCapabilitiesBase() { }
    public static bool GetConfigCapabilities_called { get { return default(bool); } set { } }
  }
  public partial class MenuAdapter : System.Web.UI.WebControls.Adapters.MenuAdapter {
    public MenuAdapter(System.Web.UI.WebControls.Menu c) { }
  }
  public partial class Page : System.Web.UI.Page {
    public Page() { }
    public string RawViewState { set { } }
    public void SetContext(System.Web.HttpContext ctx) { }
  }
  public partial class PageAdapter : System.Web.UI.Adapters.PageAdapter {
    public PageAdapter(SystemWebTestShim.Page p) { }
  }
  public partial class UrlUtils {
    public UrlUtils() { }
    public static string Canonic(string path) { return default(string); }
  }
  public partial class WebControlAdapter : System.Web.UI.WebControls.Adapters.WebControlAdapter {
    public WebControlAdapter(System.Web.UI.WebControls.WebControl c) { }
  }
}
