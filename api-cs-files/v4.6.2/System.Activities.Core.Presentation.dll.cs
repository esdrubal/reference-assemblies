namespace System.Activities.Core.Presentation {
  public enum ConnectionPointType {
    Default = 0,
    Incoming = 1,
    Outgoing = 2,
  }
  public partial class DesignerMetadata : System.Activities.Presentation.Metadata.IRegisterMetadata {
    public DesignerMetadata() { }
    public void Register() { }
  }
  public sealed partial class FinalState {
    public FinalState() { }
  }
  public static partial class FlowchartDesignerCommands {
    public static readonly System.Windows.Input.RoutedCommand ConnectNodesCommand;
  }
  public sealed partial class GenericTypeArgumentConverter : System.Windows.Data.IValueConverter {
    public GenericTypeArgumentConverter() { }
    public object Convert(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) { return default(object); }
    public object ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) { return default(object); }
  }
  public partial class LocationChangedEventArgs : System.EventArgs {
    public LocationChangedEventArgs(System.Windows.Point newLocation) { }
    public System.Windows.Point NewLocation { get { return default(System.Windows.Point); } }
  }
}
namespace System.Activities.Core.Presentation.Factories {
  public sealed partial class ForEachWithBodyFactory<T> : System.Activities.Presentation.IActivityTemplateFactory {
    public ForEachWithBodyFactory() { }
    public System.Activities.Activity Create(System.Windows.DependencyObject target) { return default(System.Activities.Activity); }
  }
  public sealed partial class ParallelForEachWithBodyFactory<T> : System.Activities.Presentation.IActivityTemplateFactory {
    public ParallelForEachWithBodyFactory() { }
    public System.Activities.Activity Create(System.Windows.DependencyObject target) { return default(System.Activities.Activity); }
  }
  public sealed partial class PickWithTwoBranchesFactory : System.Activities.Presentation.IActivityTemplateFactory {
    public PickWithTwoBranchesFactory() { }
    public System.Activities.Activity Create(System.Windows.DependencyObject target) { return default(System.Activities.Activity); }
  }
  public sealed partial class StateMachineWithInitialStateFactory : System.Activities.Presentation.IActivityTemplateFactory {
    public StateMachineWithInitialStateFactory() { }
    public System.Activities.Activity Create(System.Windows.DependencyObject target) { return default(System.Activities.Activity); }
  }
}
namespace System.Activities.Core.Presentation.Themes {
  public sealed partial class DesignerStylesDictionary : System.Windows.ResourceDictionary, System.Windows.Markup.IComponentConnector {
    internal DesignerStylesDictionary() { }
    public static System.Windows.Style SequenceStyle { get { return default(System.Windows.Style); } }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void InitializeComponent() { }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Diagnostics.DebuggerNonUserCodeAttribute]
    void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) { }
  }
}
namespace System.Activities.Presentation {
  public partial class DynamicArgumentDesignerOptions {
    public DynamicArgumentDesignerOptions() { }
    public string ArgumentPrefix { get { return default(string); } set { } }
    public string Title { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public sealed partial class DynamicArgumentDialog : System.Activities.Presentation.WorkflowElementDialog {
    internal DynamicArgumentDialog() { }
    protected override void OnWorkflowElementDialogClosed(System.Nullable<System.Boolean> dialogResult) { }
    public static bool ShowDialog(System.Activities.Presentation.Model.ModelItem activity, System.Activities.Presentation.Model.ModelItem data, System.Activities.Presentation.EditingContext context, System.Windows.DependencyObject owner, System.Activities.Presentation.DynamicArgumentDesignerOptions options) { return default(bool); }
  }
}
namespace System.ServiceModel.Activities.Presentation {
  public static partial class ServiceContractImporter {
    public const string ContractTypeViewStateKey = "contractType";
    [System.Runtime.CompilerServices.IteratorStateMachineAttribute(typeof(System.ServiceModel.Activities.Presentation.ServiceContractImporter.<GenerateActivityTemplates>d__9))]
    public static System.Collections.Generic.IEnumerable<System.Activities.Presentation.Toolbox.ActivityTemplateFactoryBuilder> GenerateActivityTemplates(System.Type contractType) { return default(System.Collections.Generic.IEnumerable<System.Activities.Presentation.Toolbox.ActivityTemplateFactoryBuilder>); }
    public static string SaveActivityTemplate(System.Activities.Presentation.Toolbox.ActivityTemplateFactoryBuilder activityTemplate) { return default(string); }
    public static System.Type SelectContractType(System.Reflection.AssemblyName localAssemblyName, System.Collections.Generic.IList<System.Reflection.AssemblyName> referencedAssemblies, System.Activities.Presentation.EditingContext editingContext) { return default(System.Type); }
  }
}
namespace System.ServiceModel.Activities.Presentation.Factories {
  public sealed partial class ReceiveAndSendReplyFactory : System.Activities.Presentation.IActivityTemplateFactory {
    public ReceiveAndSendReplyFactory() { }
    public System.Activities.Activity Create(System.Windows.DependencyObject target) { return default(System.Activities.Activity); }
  }
  public sealed partial class SendAndReceiveReplyFactory : System.Activities.Presentation.IActivityTemplateFactory {
    public SendAndReceiveReplyFactory() { }
    public System.Activities.Activity Create(System.Windows.DependencyObject target) { return default(System.Activities.Activity); }
  }
}
namespace XamlGeneratedNamespace {
  [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.Diagnostics.DebuggerNonUserCodeAttribute]
  public sealed partial class GeneratedInternalTypeHelper : System.Windows.Markup.InternalTypeHelper {
    public GeneratedInternalTypeHelper() { }
    protected override void AddEventHandler(System.Reflection.EventInfo eventInfo, object target, System.Delegate handler) { }
    protected override System.Delegate CreateDelegate(System.Type delegateType, object target, string handler) { return default(System.Delegate); }
    protected override object CreateInstance(System.Type type, System.Globalization.CultureInfo culture) { return default(object); }
    protected override object GetPropertyValue(System.Reflection.PropertyInfo propertyInfo, object target, System.Globalization.CultureInfo culture) { return default(object); }
    protected override void SetPropertyValue(System.Reflection.PropertyInfo propertyInfo, object target, object value, System.Globalization.CultureInfo culture) { }
  }
}
