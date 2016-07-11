namespace Microsoft.Activities.Build {
  public sealed partial class WorkflowBuildMessageTask : Microsoft.Build.Utilities.Task {
    public WorkflowBuildMessageTask() { }
    public string MessageType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [Microsoft.Build.Framework.RequiredAttribute]
    public string ResourceName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override bool Execute() { return default(bool); }
  }
}
namespace Microsoft.Activities.Build.Debugger {
  public partial class DebugBuildExtension : Microsoft.Build.Tasks.Xaml.IXamlBuildTypeGenerationExtension {
    public DebugBuildExtension() { }
    public bool Execute(Microsoft.Build.Tasks.Xaml.ClassData classData, Microsoft.Build.Tasks.Xaml.XamlBuildTypeGenerationExtensionContext buildContext) { return default(bool); }
  }
}
namespace Microsoft.Activities.Build.Expressions {
  public partial class ExpressionsBuildExtension : Microsoft.Build.Tasks.Xaml.IXamlBuildTypeInspectionExtension {
    public ExpressionsBuildExtension() { }
    public bool Execute(Microsoft.Build.Tasks.Xaml.XamlBuildTypeInspectionExtensionContext buildContext) { return default(bool); }
  }
}
namespace Microsoft.Activities.Build.Validation {
  public partial class DeferredValidationTask : Microsoft.Build.Utilities.Task {
    public DeferredValidationTask() { }
    [Microsoft.Build.Framework.RequiredAttribute]
    public string DeferredValidationErrorsFilePath { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override bool Execute() { return default(bool); }
  }
  public partial class ReportDeferredValidationErrorsTask : Microsoft.Build.Utilities.Task {
    public ReportDeferredValidationErrorsTask() { }
    [Microsoft.Build.Framework.RequiredAttribute]
    public string DeferredValidationErrorsFilePath { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override bool Execute() { return default(bool); }
  }
}
