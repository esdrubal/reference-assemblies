namespace System.AddIn.Pipeline {
  public static partial class FrameworkElementAdapters {
    [System.Security.SecurityCriticalAttribute]
    public static System.Windows.FrameworkElement ContractToViewAdapter(System.AddIn.Contract.INativeHandleContract nativeHandleContract) { return default(System.Windows.FrameworkElement); }
    [System.Security.SecurityCriticalAttribute]
    public static System.AddIn.Contract.INativeHandleContract ViewToContractAdapter(System.Windows.FrameworkElement root) { return default(System.AddIn.Contract.INativeHandleContract); }
  }
}
namespace System.Windows.Threading {
  public static partial class DispatcherExtensions {
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public static System.Windows.Threading.DispatcherOperation BeginInvoke(this System.Windows.Threading.Dispatcher dispatcher, System.Action action) { return default(System.Windows.Threading.DispatcherOperation); }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public static System.Windows.Threading.DispatcherOperation BeginInvoke(this System.Windows.Threading.Dispatcher dispatcher, System.Action action, System.Windows.Threading.DispatcherPriority priority) { return default(System.Windows.Threading.DispatcherOperation); }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public static void Invoke(this System.Windows.Threading.Dispatcher dispatcher, System.Action action) { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public static void Invoke(this System.Windows.Threading.Dispatcher dispatcher, System.Action action, System.TimeSpan timeout) { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public static void Invoke(this System.Windows.Threading.Dispatcher dispatcher, System.Action action, System.TimeSpan timeout, System.Windows.Threading.DispatcherPriority priority) { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public static void Invoke(this System.Windows.Threading.Dispatcher dispatcher, System.Action action, System.Windows.Threading.DispatcherPriority priority) { }
  }
  public static partial class TaskExtensions {
    public static System.Windows.Threading.DispatcherOperationStatus DispatcherOperationWait(this System.Threading.Tasks.Task @this) { return default(System.Windows.Threading.DispatcherOperationStatus); }
    public static System.Windows.Threading.DispatcherOperationStatus DispatcherOperationWait(this System.Threading.Tasks.Task @this, System.TimeSpan timeout) { return default(System.Windows.Threading.DispatcherOperationStatus); }
    public static bool IsDispatcherOperationTask(this System.Threading.Tasks.Task @this) { return default(bool); }
  }
}
