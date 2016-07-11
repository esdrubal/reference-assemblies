namespace System.ServiceModel {
  public partial class WebHttpBinding : System.ServiceModel.Channels.Binding, System.ServiceModel.Channels.IBindingRuntimePreferences {
    public WebHttpBinding() { }
    public WebHttpBinding(System.ServiceModel.WebHttpSecurityMode mode) { }
    public WebHttpBinding(string configurationName) { }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool AllowCookies { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool BypassProxyOnLocal { get { return default(bool); } set { } }
    public System.ServiceModel.Channels.WebContentTypeMapper ContentTypeMapper { get { return default(System.ServiceModel.Channels.WebContentTypeMapper); } set { } }
    [System.MonoTODOAttribute]
    public bool CrossDomainScriptAccessEnabled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.ServiceModel.EnvelopeVersion EnvelopeVersion { get { return default(System.ServiceModel.EnvelopeVersion); } }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.HostNameComparisonMode)(0))]
    public System.ServiceModel.HostNameComparisonMode HostNameComparisonMode { get { return default(System.ServiceModel.HostNameComparisonMode); } set { } }
    [System.ComponentModel.DefaultValueAttribute(65536)]
    public long MaxBufferPoolSize { get { return default(long); } set { } }
    [System.ComponentModel.DefaultValueAttribute(524288)]
    public int MaxBufferSize { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute(65536)]
    public long MaxReceivedMessageSize { get { return default(long); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Uri ProxyAddress { get { return default(System.Uri); } set { } }
    public System.Xml.XmlDictionaryReaderQuotas ReaderQuotas { get { return default(System.Xml.XmlDictionaryReaderQuotas); } set { } }
    public override string Scheme { get { return default(string); } }
    public System.ServiceModel.WebHttpSecurity Security { get { return default(System.ServiceModel.WebHttpSecurity); } set { } }
    bool System.ServiceModel.Channels.IBindingRuntimePreferences.ReceiveSynchronously { get { return default(bool); } }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.TransferMode)(0))]
    public System.ServiceModel.TransferMode TransferMode { get { return default(System.ServiceModel.TransferMode); } set { } }
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool UseDefaultWebProxy { get { return default(bool); } set { } }
    public System.Text.Encoding WriteEncoding { get { return default(System.Text.Encoding); } set { } }
    public override System.ServiceModel.Channels.BindingElementCollection CreateBindingElements() { return default(System.ServiceModel.Channels.BindingElementCollection); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public bool ShouldSerializeReaderQuotas() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public bool ShouldSerializeSecurity() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public bool ShouldSerializeWriteEncoding() { return default(bool); }
  }
  public sealed partial class WebHttpSecurity {
    public WebHttpSecurity() { }
    public System.ServiceModel.WebHttpSecurityMode Mode { get { return default(System.ServiceModel.WebHttpSecurityMode); } set { } }
    public System.ServiceModel.HttpTransportSecurity Transport { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.HttpTransportSecurity); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public bool ShouldSerializeMode() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public bool ShouldSerializeTransport() { return default(bool); }
  }
  public enum WebHttpSecurityMode {
    None = 0,
    Transport = 1,
    TransportCredentialOnly = 2,
  }
}
namespace System.ServiceModel.Activation {
  public partial class WebScriptServiceHostFactory : System.ServiceModel.Activation.ServiceHostFactory {
    public WebScriptServiceHostFactory() { }
    protected override System.ServiceModel.ServiceHost CreateServiceHost(System.Type serviceType, System.Uri[] baseAddresses) { return default(System.ServiceModel.ServiceHost); }
  }
  public partial class WebServiceHostFactory : System.ServiceModel.Activation.ServiceHostFactory {
    public WebServiceHostFactory() { }
    protected override System.ServiceModel.ServiceHost CreateServiceHost(System.Type serviceType, System.Uri[] baseAddresses) { return default(System.ServiceModel.ServiceHost); }
  }
}
namespace System.ServiceModel.Channels {
  public sealed partial class WebBodyFormatMessageProperty : System.ServiceModel.Channels.IMessageProperty {
    public const string Name = "WebBodyFormatMessageProperty";
    public WebBodyFormatMessageProperty(System.ServiceModel.Channels.WebContentFormat format) { }
    public System.ServiceModel.Channels.WebContentFormat Format { get { return default(System.ServiceModel.Channels.WebContentFormat); } }
    public System.ServiceModel.Channels.IMessageProperty CreateCopy() { return default(System.ServiceModel.Channels.IMessageProperty); }
    public override string ToString() { return default(string); }
  }
  public enum WebContentFormat {
    Default = 0,
    Json = 2,
    Raw = 3,
    Xml = 1,
  }
  public abstract partial class WebContentTypeMapper {
    protected WebContentTypeMapper() { }
    public abstract System.ServiceModel.Channels.WebContentFormat GetMessageFormatForContentType(string contentType);
  }
  public sealed partial class WebMessageEncodingBindingElement : System.ServiceModel.Channels.MessageEncodingBindingElement, System.ServiceModel.Description.IWsdlExportExtension {
    public WebMessageEncodingBindingElement() { }
    public WebMessageEncodingBindingElement(System.Text.Encoding writeEncoding) { }
    public System.ServiceModel.Channels.WebContentTypeMapper ContentTypeMapper { get { return default(System.ServiceModel.Channels.WebContentTypeMapper); } set { } }
    [System.MonoTODOAttribute]
    public int MaxReadPoolSize { get { return default(int); } set { } }
    [System.MonoTODOAttribute]
    public int MaxWritePoolSize { get { return default(int); } set { } }
    public override System.ServiceModel.Channels.MessageVersion MessageVersion { get { return default(System.ServiceModel.Channels.MessageVersion); } set { } }
    public System.Xml.XmlDictionaryReaderQuotas ReaderQuotas { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xml.XmlDictionaryReaderQuotas); } }
    public System.Text.Encoding WriteEncoding { get { return default(System.Text.Encoding); } set { } }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public override System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    [System.MonoTODOAttribute("Why is it overriden?")]
    public override bool CanBuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    public override System.ServiceModel.Channels.MessageEncoderFactory CreateMessageEncoderFactory() { return default(System.ServiceModel.Channels.MessageEncoderFactory); }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
    [System.MonoTODOAttribute]
    void System.ServiceModel.Description.IWsdlExportExtension.ExportContract(System.ServiceModel.Description.WsdlExporter exporter, System.ServiceModel.Description.WsdlContractConversionContext context) { }
    [System.MonoTODOAttribute]
    void System.ServiceModel.Description.IWsdlExportExtension.ExportEndpoint(System.ServiceModel.Description.WsdlExporter exporter, System.ServiceModel.Description.WsdlEndpointConversionContext context) { }
  }
}
namespace System.ServiceModel.Configuration {
  public partial class WebHttpBindingCollectionElement : System.ServiceModel.Configuration.StandardBindingCollectionElement<System.ServiceModel.WebHttpBinding, System.ServiceModel.Configuration.WebHttpBindingElement> {
    public WebHttpBindingCollectionElement() { }
    protected internal override System.ServiceModel.Channels.Binding GetDefault() { return default(System.ServiceModel.Channels.Binding); }
  }
  public partial class WebHttpBindingElement : System.ServiceModel.Configuration.StandardBindingElement, System.ServiceModel.Configuration.IBindingConfigurationElement {
    public WebHttpBindingElement() { }
    public WebHttpBindingElement(string name) { }
    [System.Configuration.ConfigurationPropertyAttribute("allowCookies", DefaultValue=false, Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public bool AllowCookies { get { return default(bool); } set { } }
    protected override System.Type BindingElementType { get { return default(System.Type); } }
    [System.Configuration.ConfigurationPropertyAttribute("bypassProxyOnLocal", DefaultValue=false, Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public bool BypassProxyOnLocal { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("hostNameComparisonMode", DefaultValue="StrongWildcard", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.HostNameComparisonMode HostNameComparisonMode { get { return default(System.ServiceModel.HostNameComparisonMode); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxBufferPoolSize", DefaultValue="524288", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    [System.Configuration.LongValidatorAttribute(MinValue=(long)0, MaxValue=(long)9223372036854775807, ExcludeRange=false)]
    public long MaxBufferPoolSize { get { return default(long); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxBufferSize", DefaultValue="65536", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    [System.Configuration.IntegerValidatorAttribute(MinValue=1, MaxValue=2147483647, ExcludeRange=false)]
    public int MaxBufferSize { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxReceivedMessageSize", DefaultValue="65536", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    [System.Configuration.LongValidatorAttribute(MinValue=(long)1, MaxValue=(long)9223372036854775807, ExcludeRange=false)]
    public long MaxReceivedMessageSize { get { return default(long); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("proxyAddress", DefaultValue=null, Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.Uri ProxyAddress { get { return default(System.Uri); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("readerQuotas", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.XmlDictionaryReaderQuotasElement ReaderQuotas { get { return default(System.ServiceModel.Configuration.XmlDictionaryReaderQuotasElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("security", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.WebHttpSecurityElement Security { get { return default(System.ServiceModel.Configuration.WebHttpSecurityElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("transferMode", DefaultValue="Buffered", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.TransferMode TransferMode { get { return default(System.ServiceModel.TransferMode); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("useDefaultWebProxy", DefaultValue=true, Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public bool UseDefaultWebProxy { get { return default(bool); } set { } }
    [System.ComponentModel.TypeConverterAttribute]
    [System.Configuration.ConfigurationPropertyAttribute("writeEncoding", DefaultValue="utf-8", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.Text.Encoding WriteEncoding { get { return default(System.Text.Encoding); } set { } }
    protected internal override void InitializeFrom(System.ServiceModel.Channels.Binding binding) { }
    protected override void OnApplyConfiguration(System.ServiceModel.Channels.Binding binding) { }
  }
  public sealed partial class WebHttpElement : System.ServiceModel.Configuration.BehaviorExtensionElement {
    public WebHttpElement() { }
    public override System.Type BehaviorType { get { return default(System.Type); } }
    protected internal override object CreateBehavior() { return default(object); }
  }
  public partial class WebHttpEndpointCollectionElement : System.ServiceModel.Configuration.StandardEndpointCollectionElement<System.ServiceModel.Description.WebHttpEndpoint, System.ServiceModel.Configuration.WebHttpEndpointElement> {
    public WebHttpEndpointCollectionElement() { }
  }
  public partial class WebHttpEndpointElement : System.ServiceModel.Configuration.StandardEndpointElement {
    public WebHttpEndpointElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("automaticFormatSelectionEnabled", DefaultValue=false)]
    public bool AutomaticFormatSelectionEnabled { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("contentTypeMapper", DefaultValue="")]
    [System.Configuration.StringValidatorAttribute(MinLength=0)]
    public string ContentTypeMapper { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("crossDomainScriptAccessEnabled", DefaultValue=false)]
    public bool CrossDomainScriptAccessEnabled { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("defaultOutgoingResponseFormat", DefaultValue=(System.ServiceModel.Web.WebMessageFormat)(0))]
    public System.ServiceModel.Web.WebMessageFormat DefaultOutgoingResponseFormat { get { return default(System.ServiceModel.Web.WebMessageFormat); } set { } }
    protected internal override System.Type EndpointType { get { return default(System.Type); } }
    [System.Configuration.ConfigurationPropertyAttribute("faultExceptionEnabled", DefaultValue=false)]
    public bool FaultExceptionEnabled { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("helpEnabled", DefaultValue=false)]
    public bool HelpEnabled { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("hostNameComparisonMode", DefaultValue=(System.ServiceModel.HostNameComparisonMode)(0))]
    public System.ServiceModel.HostNameComparisonMode HostNameComparisonMode { get { return default(System.ServiceModel.HostNameComparisonMode); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxBufferPoolSize", DefaultValue=524288, Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    [System.Configuration.LongValidatorAttribute(MinValue=(long)0, MaxValue=(long)9223372036854775807, ExcludeRange=false)]
    public long MaxBufferPoolSize { get { return default(long); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxBufferSize", DefaultValue=65536, Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    [System.Configuration.IntegerValidatorAttribute(MinValue=1, MaxValue=2147483647, ExcludeRange=false)]
    public int MaxBufferSize { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxReceivedMessageSize", DefaultValue=65536, Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    [System.Configuration.LongValidatorAttribute(MinValue=(long)1, MaxValue=(long)9223372036854775807, ExcludeRange=false)]
    public long MaxReceivedMessageSize { get { return default(long); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("readerQuotas")]
    public System.ServiceModel.Configuration.XmlDictionaryReaderQuotasElement ReaderQuotas { get { return default(System.ServiceModel.Configuration.XmlDictionaryReaderQuotasElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("security")]
    public System.ServiceModel.Configuration.WebHttpSecurityElement Security { get { return default(System.ServiceModel.Configuration.WebHttpSecurityElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("transferMode", DefaultValue=(System.ServiceModel.TransferMode)(0))]
    public System.ServiceModel.TransferMode TransferMode { get { return default(System.ServiceModel.TransferMode); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Configuration.EncodingConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("writeEncoding", DefaultValue="utf-8")]
    public System.Text.Encoding WriteEncoding { get { return default(System.Text.Encoding); } set { } }
    protected internal override System.ServiceModel.Description.ServiceEndpoint CreateServiceEndpoint(System.ServiceModel.Description.ContractDescription contractDescription) { return default(System.ServiceModel.Description.ServiceEndpoint); }
    protected override void OnApplyConfiguration(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Configuration.ChannelEndpointElement serviceEndpointElement) { }
    protected override void OnApplyConfiguration(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Configuration.ServiceEndpointElement serviceEndpointElement) { }
    protected override void OnInitializeAndValidate(System.ServiceModel.Configuration.ChannelEndpointElement channelEndpointElement) { }
    protected override void OnInitializeAndValidate(System.ServiceModel.Configuration.ServiceEndpointElement serviceEndpointElement) { }
  }
  public sealed partial class WebHttpSecurityElement : System.Configuration.ConfigurationElement {
    public WebHttpSecurityElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("mode", DefaultValue="None", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.WebHttpSecurityMode Mode { get { return default(System.ServiceModel.WebHttpSecurityMode); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("transport", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.HttpTransportSecurityElement Transport { get { return default(System.ServiceModel.Configuration.HttpTransportSecurityElement); } }
  }
  public sealed partial class WebMessageEncodingElement : System.ServiceModel.Configuration.BindingElementExtensionElement {
    public WebMessageEncodingElement() { }
    public override System.Type BindingElementType { get { return default(System.Type); } }
    [System.Configuration.ConfigurationPropertyAttribute("maxReadPoolSize", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="64")]
    [System.Configuration.IntegerValidatorAttribute(MinValue=1, MaxValue=2147483647, ExcludeRange=false)]
    public int MaxReadPoolSize { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxWritePoolSize", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="16")]
    [System.Configuration.IntegerValidatorAttribute(MinValue=1, MaxValue=2147483647, ExcludeRange=false)]
    public int MaxWritePoolSize { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("readerQuotas", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.XmlDictionaryReaderQuotasElement ReaderQuotas { get { return default(System.ServiceModel.Configuration.XmlDictionaryReaderQuotasElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("webContentTypeMapperType", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="")]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647)]
    public string WebContentTypeMapperType { get { return default(string); } set { } }
    [System.ComponentModel.TypeConverterAttribute]
    [System.Configuration.ConfigurationPropertyAttribute("writeEncoding", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="utf-8")]
    public System.Text.Encoding WriteEncoding { get { return default(System.Text.Encoding); } set { } }
    public override void ApplyConfiguration(System.ServiceModel.Channels.BindingElement bindingElement) { }
    public override void CopyFrom(System.ServiceModel.Configuration.ServiceModelExtensionElement from) { }
    protected internal override System.ServiceModel.Channels.BindingElement CreateBindingElement() { return default(System.ServiceModel.Channels.BindingElement); }
  }
  public sealed partial class WebScriptEnablingElement : System.ServiceModel.Configuration.BehaviorExtensionElement {
    public WebScriptEnablingElement() { }
    public override System.Type BehaviorType { get { return default(System.Type); } }
    protected internal override object CreateBehavior() { return default(object); }
  }
  public partial class WebScriptEndpointCollectionElement : System.ServiceModel.Configuration.StandardEndpointCollectionElement<System.ServiceModel.Description.WebScriptEndpoint, System.ServiceModel.Configuration.WebScriptEndpointElement> {
    public WebScriptEndpointCollectionElement() { }
  }
  public partial class WebScriptEndpointElement : System.ServiceModel.Configuration.StandardEndpointElement {
    public WebScriptEndpointElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("contentTypeMapper", DefaultValue="")]
    [System.Configuration.StringValidatorAttribute(MinLength=0)]
    public string ContentTypeMapper { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("crossDomainScriptAccessEnabled", DefaultValue=false)]
    public bool CrossDomainScriptAccessEnabled { get { return default(bool); } set { } }
    protected internal override System.Type EndpointType { get { return default(System.Type); } }
    [System.Configuration.ConfigurationPropertyAttribute("hostNameComparisonMode", DefaultValue=(System.ServiceModel.HostNameComparisonMode)(0))]
    public System.ServiceModel.HostNameComparisonMode HostNameComparisonMode { get { return default(System.ServiceModel.HostNameComparisonMode); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxBufferPoolSize", DefaultValue=524288, Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    [System.Configuration.LongValidatorAttribute(MinValue=(long)0, MaxValue=(long)9223372036854775807, ExcludeRange=false)]
    public long MaxBufferPoolSize { get { return default(long); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxBufferSize", DefaultValue=65536, Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    [System.Configuration.IntegerValidatorAttribute(MinValue=1, MaxValue=2147483647, ExcludeRange=false)]
    public int MaxBufferSize { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxReceivedMessageSize", DefaultValue=65536, Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    [System.Configuration.LongValidatorAttribute(MinValue=(long)1, MaxValue=(long)9223372036854775807, ExcludeRange=false)]
    public long MaxReceivedMessageSize { get { return default(long); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("readerQuotas")]
    public System.ServiceModel.Configuration.XmlDictionaryReaderQuotasElement ReaderQuotas { get { return default(System.ServiceModel.Configuration.XmlDictionaryReaderQuotasElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("security")]
    public System.ServiceModel.Configuration.WebHttpSecurityElement Security { get { return default(System.ServiceModel.Configuration.WebHttpSecurityElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("transferMode", DefaultValue=(System.ServiceModel.TransferMode)(0))]
    public System.ServiceModel.TransferMode TransferMode { get { return default(System.ServiceModel.TransferMode); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Configuration.EncodingConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("writeEncoding", DefaultValue="utf-8")]
    public System.Text.Encoding WriteEncoding { get { return default(System.Text.Encoding); } set { } }
    protected internal override System.ServiceModel.Description.ServiceEndpoint CreateServiceEndpoint(System.ServiceModel.Description.ContractDescription contractDescription) { return default(System.ServiceModel.Description.ServiceEndpoint); }
    protected override void OnApplyConfiguration(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Configuration.ChannelEndpointElement serviceEndpointElement) { }
    protected override void OnApplyConfiguration(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Configuration.ServiceEndpointElement serviceEndpointElement) { }
    protected override void OnInitializeAndValidate(System.ServiceModel.Configuration.ChannelEndpointElement channelEndpointElement) { }
    protected override void OnInitializeAndValidate(System.ServiceModel.Configuration.ServiceEndpointElement serviceEndpointElement) { }
  }
}
namespace System.ServiceModel.Description {
  public partial class WebHttpBehavior : System.ServiceModel.Description.IEndpointBehavior {
    public WebHttpBehavior() { }
    public virtual bool AutomaticFormatSelectionEnabled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public virtual System.ServiceModel.Web.WebMessageBodyStyle DefaultBodyStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Web.WebMessageBodyStyle); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public virtual System.ServiceModel.Web.WebMessageFormat DefaultOutgoingRequestFormat { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Web.WebMessageFormat); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public virtual System.ServiceModel.Web.WebMessageFormat DefaultOutgoingResponseFormat { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Web.WebMessageFormat); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public virtual bool FaultExceptionEnabled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public virtual bool HelpEnabled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public virtual void AddBindingParameters(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Channels.BindingParameterCollection bindingParameters) { }
    [System.MonoTODOAttribute]
    protected virtual void AddClientErrorInspector(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.ClientRuntime clientRuntime) { }
    protected virtual void AddServerErrorHandlers(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.EndpointDispatcher endpointDispatcher) { }
    public virtual void ApplyClientBehavior(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.ClientRuntime clientRuntime) { }
    public virtual void ApplyDispatchBehavior(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.EndpointDispatcher endpointDispatcher) { }
    protected virtual System.ServiceModel.Dispatcher.WebHttpDispatchOperationSelector GetOperationSelector(System.ServiceModel.Description.ServiceEndpoint endpoint) { return default(System.ServiceModel.Dispatcher.WebHttpDispatchOperationSelector); }
    protected virtual System.ServiceModel.Dispatcher.QueryStringConverter GetQueryStringConverter(System.ServiceModel.Description.OperationDescription operationDescription) { return default(System.ServiceModel.Dispatcher.QueryStringConverter); }
    protected virtual System.ServiceModel.Dispatcher.IClientMessageFormatter GetReplyClientFormatter(System.ServiceModel.Description.OperationDescription operationDescription, System.ServiceModel.Description.ServiceEndpoint endpoint) { return default(System.ServiceModel.Dispatcher.IClientMessageFormatter); }
    protected virtual System.ServiceModel.Dispatcher.IDispatchMessageFormatter GetReplyDispatchFormatter(System.ServiceModel.Description.OperationDescription operationDescription, System.ServiceModel.Description.ServiceEndpoint endpoint) { return default(System.ServiceModel.Dispatcher.IDispatchMessageFormatter); }
    protected virtual System.ServiceModel.Dispatcher.IClientMessageFormatter GetRequestClientFormatter(System.ServiceModel.Description.OperationDescription operationDescription, System.ServiceModel.Description.ServiceEndpoint endpoint) { return default(System.ServiceModel.Dispatcher.IClientMessageFormatter); }
    protected virtual System.ServiceModel.Dispatcher.IDispatchMessageFormatter GetRequestDispatchFormatter(System.ServiceModel.Description.OperationDescription operationDescription, System.ServiceModel.Description.ServiceEndpoint endpoint) { return default(System.ServiceModel.Dispatcher.IDispatchMessageFormatter); }
    [System.MonoTODOAttribute("check UriTemplate validity")]
    public virtual void Validate(System.ServiceModel.Description.ServiceEndpoint endpoint) { }
    protected virtual void ValidateBinding(System.ServiceModel.Description.ServiceEndpoint endpoint) { }
    protected void ValidateOperation(System.ServiceModel.Description.OperationDescription operation) { }
  }
  [System.MonoTODOAttribute]
  public partial class WebHttpEndpoint : System.ServiceModel.Description.WebServiceEndpoint {
    public WebHttpEndpoint(System.ServiceModel.Description.ContractDescription contract) { }
    public WebHttpEndpoint(System.ServiceModel.Description.ContractDescription contract, System.ServiceModel.EndpointAddress address) { }
    public bool AutomaticFormatSelectionEnabled { get { return default(bool); } set { } }
    public System.ServiceModel.Web.WebMessageFormat DefaultOutgoingResponseFormat { get { return default(System.ServiceModel.Web.WebMessageFormat); } set { } }
    public bool FaultExceptionEnabled { get { return default(bool); } set { } }
    public bool HelpEnabled { get { return default(bool); } set { } }
    protected override System.Type WebEndpointType { get { return default(System.Type); } }
  }
  public sealed partial class WebScriptEnablingBehavior : System.ServiceModel.Description.WebHttpBehavior {
    public WebScriptEnablingBehavior() { }
    public override System.ServiceModel.Web.WebMessageBodyStyle DefaultBodyStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Web.WebMessageBodyStyle); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override System.ServiceModel.Web.WebMessageFormat DefaultOutgoingRequestFormat { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Web.WebMessageFormat); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override System.ServiceModel.Web.WebMessageFormat DefaultOutgoingResponseFormat { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Web.WebMessageFormat); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    protected override void AddClientErrorInspector(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.ClientRuntime clientRuntime) { }
    [System.MonoTODOAttribute]
    protected override void AddServerErrorHandlers(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.EndpointDispatcher endpointDispatcher) { }
    [System.MonoTODOAttribute]
    public override void ApplyClientBehavior(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.ClientRuntime clientRuntime) { }
    public override void ApplyDispatchBehavior(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.EndpointDispatcher endpointDispatcher) { }
    protected override System.ServiceModel.Dispatcher.QueryStringConverter GetQueryStringConverter(System.ServiceModel.Description.OperationDescription operationDescription) { return default(System.ServiceModel.Dispatcher.QueryStringConverter); }
    [System.MonoTODOAttribute("add non-XmlSerializer-ness check (but where?)")]
    public override void Validate(System.ServiceModel.Description.ServiceEndpoint endpoint) { }
  }
  [System.MonoTODOAttribute]
  public partial class WebScriptEndpoint : System.ServiceModel.Description.WebServiceEndpoint {
    public WebScriptEndpoint(System.ServiceModel.Description.ContractDescription contract) { }
    public WebScriptEndpoint(System.ServiceModel.Description.ContractDescription contract, System.ServiceModel.EndpointAddress address) { }
    protected override System.Type WebEndpointType { get { return default(System.Type); } }
  }
  public abstract partial class WebServiceEndpoint : System.ServiceModel.Description.ServiceEndpoint {
    internal WebServiceEndpoint() : base (default(System.ServiceModel.Description.ContractDescription)) { }
    public System.ServiceModel.Channels.WebContentTypeMapper ContentTypeMapper { get { return default(System.ServiceModel.Channels.WebContentTypeMapper); } set { } }
    public bool CrossDomainScriptAccessEnabled { get { return default(bool); } set { } }
    public System.ServiceModel.HostNameComparisonMode HostNameComparisonMode { get { return default(System.ServiceModel.HostNameComparisonMode); } set { } }
    public long MaxBufferPoolSize { get { return default(long); } set { } }
    public int MaxBufferSize { get { return default(int); } set { } }
    public long MaxReceivedMessageSize { get { return default(long); } set { } }
    public System.Xml.XmlDictionaryReaderQuotas ReaderQuotas { get { return default(System.Xml.XmlDictionaryReaderQuotas); } set { } }
    public System.ServiceModel.WebHttpSecurity Security { get { return default(System.ServiceModel.WebHttpSecurity); } }
    public System.ServiceModel.TransferMode TransferMode { get { return default(System.ServiceModel.TransferMode); } set { } }
    protected abstract System.Type WebEndpointType { get; }
    public System.Text.Encoding WriteEncoding { get { return default(System.Text.Encoding); } set { } }
  }
}
namespace System.ServiceModel.Dispatcher {
  public partial class JsonQueryStringConverter : System.ServiceModel.Dispatcher.QueryStringConverter {
    public JsonQueryStringConverter() { }
    public override bool CanConvert(System.Type type) { return default(bool); }
    public override object ConvertStringToValue(string parameter, System.Type parameterType) { return default(object); }
    public override string ConvertValueToString(object parameter, System.Type parameterType) { return default(string); }
  }
  public partial class QueryStringConverter {
    public QueryStringConverter() { }
    public virtual bool CanConvert(System.Type type) { return default(bool); }
    public virtual object ConvertStringToValue(string parameter, System.Type parameterType) { return default(object); }
    public virtual string ConvertValueToString(object parameter, System.Type parameterType) { return default(string); }
  }
  public partial class WebHttpDispatchOperationSelector : System.ServiceModel.Dispatcher.IDispatchOperationSelector {
    public const string HttpOperationSelectorUriMatchedPropertyName = "UriMatched";
    protected WebHttpDispatchOperationSelector() { }
    public WebHttpDispatchOperationSelector(System.ServiceModel.Description.ServiceEndpoint endpoint) { }
    public string SelectOperation(ref System.ServiceModel.Channels.Message message) { return default(string); }
    protected virtual string SelectOperation(ref System.ServiceModel.Channels.Message message, out bool uriMatched) { uriMatched = default(bool); return default(string); }
  }
}
namespace System.ServiceModel.Web {
  public partial class IncomingWebRequestContext {
    internal IncomingWebRequestContext() { }
    public string Accept { get { return default(string); } }
    public long ContentLength { get { return default(long); } }
    public string ContentType { get { return default(string); } }
    public System.Net.WebHeaderCollection Headers { get { return default(System.Net.WebHeaderCollection); } }
    public string Method { get { return default(string); } }
    public System.UriTemplateMatch UriTemplateMatch { get { return default(System.UriTemplateMatch); } set { } }
    public string UserAgent { get { return default(string); } }
  }
  public partial class IncomingWebResponseContext {
    internal IncomingWebResponseContext() { }
    public long ContentLength { get { return default(long); } }
    public string ContentType { get { return default(string); } }
    public string ETag { get { return default(string); } }
    public System.Net.WebHeaderCollection Headers { get { return default(System.Net.WebHeaderCollection); } }
    public string Location { get { return default(string); } }
    public System.Net.HttpStatusCode StatusCode { get { return default(System.Net.HttpStatusCode); } }
    public string StatusDescription { get { return default(string); } }
  }
  public partial class OutgoingWebRequestContext {
    internal OutgoingWebRequestContext() { }
    public string Accept { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public long ContentLength { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(long); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string ContentType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Net.WebHeaderCollection Headers { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Net.WebHeaderCollection); } }
    public string IfMatch { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string IfModifiedSince { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string IfNoneMatch { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string IfUnmodifiedSince { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Method { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool SuppressEntityBody { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string UserAgent { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial class OutgoingWebResponseContext {
    internal OutgoingWebResponseContext() { }
    public long ContentLength { get { return default(long); } set { } }
    public string ContentType { get { return default(string); } set { } }
    public string ETag { get { return default(string); } set { } }
    public System.Net.WebHeaderCollection Headers { get { return default(System.Net.WebHeaderCollection); } }
    public System.DateTime LastModified { get { return default(System.DateTime); } set { } }
    public string Location { get { return default(string); } set { } }
    public System.Net.HttpStatusCode StatusCode { get { return default(System.Net.HttpStatusCode); } set { } }
    public string StatusDescription { get { return default(string); } set { } }
    public bool SuppressEntityBody { get { return default(bool); } set { } }
    public void SetStatusAsCreated(System.Uri locationUri) { }
    public void SetStatusAsNotFound() { }
    public void SetStatusAsNotFound(string description) { }
  }
  public partial class WebChannelFactory<TChannel> : System.ServiceModel.ChannelFactory<TChannel> {
    public WebChannelFactory() { }
    public WebChannelFactory(System.ServiceModel.Channels.Binding binding) { }
    public WebChannelFactory(System.ServiceModel.Channels.Binding binding, System.Uri remoteAddress) { }
    public WebChannelFactory(System.ServiceModel.Description.ServiceEndpoint endpoint) { }
    public WebChannelFactory(string configurationName) { }
    public WebChannelFactory(string endpointConfigurationName, System.Uri remoteAddress) { }
    public WebChannelFactory(System.Type serviceType) { }
    public WebChannelFactory(System.Uri remoteAddress) { }
    protected override void OnOpening() { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(64))]
  public sealed partial class WebGetAttribute : System.Attribute, System.ServiceModel.Description.IOperationBehavior {
    public WebGetAttribute() { }
    public System.ServiceModel.Web.WebMessageBodyStyle BodyStyle { get { return default(System.ServiceModel.Web.WebMessageBodyStyle); } set { } }
    public bool IsBodyStyleSetExplicitly { get { return default(bool); } }
    public bool IsRequestFormatSetExplicitly { get { return default(bool); } }
    public bool IsResponseFormatSetExplicitly { get { return default(bool); } }
    public System.ServiceModel.Web.WebMessageFormat RequestFormat { get { return default(System.ServiceModel.Web.WebMessageFormat); } set { } }
    public System.ServiceModel.Web.WebMessageFormat ResponseFormat { get { return default(System.ServiceModel.Web.WebMessageFormat); } set { } }
    public string UriTemplate { get { return default(string); } set { } }
    void System.ServiceModel.Description.IOperationBehavior.AddBindingParameters(System.ServiceModel.Description.OperationDescription operation, System.ServiceModel.Channels.BindingParameterCollection parameters) { }
    void System.ServiceModel.Description.IOperationBehavior.ApplyClientBehavior(System.ServiceModel.Description.OperationDescription operation, System.ServiceModel.Dispatcher.ClientOperation client) { }
    void System.ServiceModel.Description.IOperationBehavior.ApplyDispatchBehavior(System.ServiceModel.Description.OperationDescription operation, System.ServiceModel.Dispatcher.DispatchOperation service) { }
    void System.ServiceModel.Description.IOperationBehavior.Validate(System.ServiceModel.Description.OperationDescription operation) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(64))]
  public sealed partial class WebInvokeAttribute : System.Attribute, System.ServiceModel.Description.IOperationBehavior {
    public WebInvokeAttribute() { }
    public System.ServiceModel.Web.WebMessageBodyStyle BodyStyle { get { return default(System.ServiceModel.Web.WebMessageBodyStyle); } set { } }
    public bool IsBodyStyleSetExplicitly { get { return default(bool); } }
    public bool IsRequestFormatSetExplicitly { get { return default(bool); } }
    public bool IsResponseFormatSetExplicitly { get { return default(bool); } }
    public string Method { get { return default(string); } set { } }
    public System.ServiceModel.Web.WebMessageFormat RequestFormat { get { return default(System.ServiceModel.Web.WebMessageFormat); } set { } }
    public System.ServiceModel.Web.WebMessageFormat ResponseFormat { get { return default(System.ServiceModel.Web.WebMessageFormat); } set { } }
    public string UriTemplate { get { return default(string); } set { } }
    void System.ServiceModel.Description.IOperationBehavior.AddBindingParameters(System.ServiceModel.Description.OperationDescription operation, System.ServiceModel.Channels.BindingParameterCollection parameters) { }
    void System.ServiceModel.Description.IOperationBehavior.ApplyClientBehavior(System.ServiceModel.Description.OperationDescription operation, System.ServiceModel.Dispatcher.ClientOperation client) { }
    void System.ServiceModel.Description.IOperationBehavior.ApplyDispatchBehavior(System.ServiceModel.Description.OperationDescription operation, System.ServiceModel.Dispatcher.DispatchOperation service) { }
    void System.ServiceModel.Description.IOperationBehavior.Validate(System.ServiceModel.Description.OperationDescription operation) { }
  }
  public enum WebMessageBodyStyle {
    Bare = 0,
    Wrapped = 1,
    WrappedRequest = 2,
    WrappedResponse = 3,
  }
  public enum WebMessageFormat {
    Json = 1,
    Xml = 0,
  }
  public partial class WebOperationContext : System.ServiceModel.IExtension<System.ServiceModel.OperationContext> {
    public WebOperationContext(System.ServiceModel.OperationContext operation) { }
    public static System.ServiceModel.Web.WebOperationContext Current { get { return default(System.ServiceModel.Web.WebOperationContext); } }
    public System.ServiceModel.Web.IncomingWebRequestContext IncomingRequest { get { return default(System.ServiceModel.Web.IncomingWebRequestContext); } }
    public System.ServiceModel.Web.IncomingWebResponseContext IncomingResponse { get { return default(System.ServiceModel.Web.IncomingWebResponseContext); } }
    public System.ServiceModel.Web.OutgoingWebRequestContext OutgoingRequest { get { return default(System.ServiceModel.Web.OutgoingWebRequestContext); } }
    public System.ServiceModel.Web.OutgoingWebResponseContext OutgoingResponse { get { return default(System.ServiceModel.Web.OutgoingWebResponseContext); } }
    public void Attach(System.ServiceModel.OperationContext context) { }
    public System.ServiceModel.Channels.Message CreateAtom10Response(System.ServiceModel.Syndication.ServiceDocument document) { return default(System.ServiceModel.Channels.Message); }
    public System.ServiceModel.Channels.Message CreateAtom10Response(System.ServiceModel.Syndication.SyndicationFeed feed) { return default(System.ServiceModel.Channels.Message); }
    public System.ServiceModel.Channels.Message CreateAtom10Response(System.ServiceModel.Syndication.SyndicationItem item) { return default(System.ServiceModel.Channels.Message); }
    public System.ServiceModel.Channels.Message CreateJsonResponse<T>(T instance) { return default(System.ServiceModel.Channels.Message); }
    public System.ServiceModel.Channels.Message CreateJsonResponse<T>(T instance, System.Runtime.Serialization.Json.DataContractJsonSerializer serializer) { return default(System.ServiceModel.Channels.Message); }
    public void Detach(System.ServiceModel.OperationContext context) { }
  }
  public partial class WebServiceHost : System.ServiceModel.ServiceHost {
    public WebServiceHost() { }
    public WebServiceHost(object singletonInstance, params System.Uri[] baseAddresses) { }
    public WebServiceHost(System.Type serviceType, params System.Uri[] baseAddresses) { }
    protected override void OnOpening() { }
  }
}
