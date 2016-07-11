namespace System.ServiceModel {
  public partial class WebHttpBinding : System.ServiceModel.Channels.Binding, System.ServiceModel.Channels.IBindingRuntimePreferences {
    public WebHttpBinding() { }
    public WebHttpBinding(System.ServiceModel.WebHttpSecurityMode securityMode) { }
    public WebHttpBinding(string configurationName) { }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool AllowCookies { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool BypassProxyOnLocal { get { return default(bool); } set { } }
    public System.ServiceModel.Channels.WebContentTypeMapper ContentTypeMapper { get { return default(System.ServiceModel.Channels.WebContentTypeMapper); } set { } }
    public bool CrossDomainScriptAccessEnabled { get { return default(bool); } set { } }
    public System.ServiceModel.EnvelopeVersion EnvelopeVersion { get { return default(System.ServiceModel.EnvelopeVersion); } }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.HostNameComparisonMode)(0))]
    public System.ServiceModel.HostNameComparisonMode HostNameComparisonMode { get { return default(System.ServiceModel.HostNameComparisonMode); } set { } }
    [System.ComponentModel.DefaultValueAttribute((long)524288)]
    public long MaxBufferPoolSize { get { return default(long); } set { } }
    [System.ComponentModel.DefaultValueAttribute(65536)]
    public int MaxBufferSize { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute((long)65536)]
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
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Configuration.EncodingConverter))]
    public System.Text.Encoding WriteEncoding { get { return default(System.Text.Encoding); } set { } }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingParameterCollection parameters) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public override System.ServiceModel.Channels.BindingElementCollection CreateBindingElements() { return default(System.ServiceModel.Channels.BindingElementCollection); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeReaderQuotas() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeSecurity() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeWriteEncoding() { return default(bool); }
  }
  public sealed partial class WebHttpSecurity {
    public WebHttpSecurity() { }
    public System.ServiceModel.WebHttpSecurityMode Mode { get { return default(System.ServiceModel.WebHttpSecurityMode); } set { } }
    public System.ServiceModel.HttpTransportSecurity Transport { get { return default(System.ServiceModel.HttpTransportSecurity); } set { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeMode() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
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
  public sealed partial class JavascriptCallbackResponseMessageProperty {
    public JavascriptCallbackResponseMessageProperty() { }
    public string CallbackFunctionName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public static string Name { get { return default(string); } }
    public System.Nullable<System.Net.HttpStatusCode> StatusCode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.Net.HttpStatusCode>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public abstract partial class StreamBodyWriter : System.ServiceModel.Channels.BodyWriter {
    protected StreamBodyWriter(bool isBuffered) : base (default(bool)) { }
    protected override System.ServiceModel.Channels.BodyWriter OnCreateBufferedCopy(int maxBufferSize) { return default(System.ServiceModel.Channels.BodyWriter); }
    protected abstract void OnWriteBodyContents(System.IO.Stream stream);
    protected override void OnWriteBodyContents(System.Xml.XmlDictionaryWriter writer) { }
  }
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
    public bool CrossDomainScriptAccessEnabled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public int MaxReadPoolSize { get { return default(int); } set { } }
    public int MaxWritePoolSize { get { return default(int); } set { } }
    public override System.ServiceModel.Channels.MessageVersion MessageVersion { get { return default(System.ServiceModel.Channels.MessageVersion); } set { } }
    public System.Xml.XmlDictionaryReaderQuotas ReaderQuotas { get { return default(System.Xml.XmlDictionaryReaderQuotas); } }
    public System.Text.Encoding WriteEncoding { get { return default(System.Text.Encoding); } set { } }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public override System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public override bool CanBuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    public override System.ServiceModel.Channels.MessageEncoderFactory CreateMessageEncoderFactory() { return default(System.ServiceModel.Channels.MessageEncoderFactory); }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
    void System.ServiceModel.Description.IWsdlExportExtension.ExportContract(System.ServiceModel.Description.WsdlExporter exporter, System.ServiceModel.Description.WsdlContractConversionContext context) { }
    void System.ServiceModel.Description.IWsdlExportExtension.ExportEndpoint(System.ServiceModel.Description.WsdlExporter exporter, System.ServiceModel.Description.WsdlEndpointConversionContext context) { }
  }
}
namespace System.ServiceModel.Configuration {
  public partial class WebHttpBindingCollectionElement : System.ServiceModel.Configuration.StandardBindingCollectionElement<System.ServiceModel.WebHttpBinding, System.ServiceModel.Configuration.WebHttpBindingElement> {
    public WebHttpBindingCollectionElement() { }
    protected internal override System.ServiceModel.Channels.Binding GetDefault() { return default(System.ServiceModel.Channels.Binding); }
  }
  public partial class WebHttpBindingElement : System.ServiceModel.Configuration.StandardBindingElement {
    public WebHttpBindingElement() { }
    public WebHttpBindingElement(string name) { }
    [System.Configuration.ConfigurationPropertyAttribute("allowCookies", DefaultValue=false)]
    public bool AllowCookies { get { return default(bool); } set { } }
    protected override System.Type BindingElementType { get { return default(System.Type); } }
    [System.Configuration.ConfigurationPropertyAttribute("bypassProxyOnLocal", DefaultValue=false)]
    public bool BypassProxyOnLocal { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("contentTypeMapper", DefaultValue="")]
    [System.Configuration.StringValidatorAttribute(MinLength=0)]
    public string ContentTypeMapper { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("crossDomainScriptAccessEnabled", DefaultValue=false)]
    public bool CrossDomainScriptAccessEnabled { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("hostNameComparisonMode", DefaultValue=(System.ServiceModel.HostNameComparisonMode)(0))]
    [System.ServiceModel.Configuration.ServiceModelEnumValidatorAttribute(typeof(System.ServiceModel.HostNameComparisonModeHelper))]
    public System.ServiceModel.HostNameComparisonMode HostNameComparisonMode { get { return default(System.ServiceModel.HostNameComparisonMode); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxBufferPoolSize", DefaultValue=(long)524288)]
    [System.Configuration.LongValidatorAttribute(MinValue=(long)0)]
    public long MaxBufferPoolSize { get { return default(long); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxBufferSize", DefaultValue=65536)]
    [System.Configuration.IntegerValidatorAttribute(MinValue=1)]
    public int MaxBufferSize { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxReceivedMessageSize", DefaultValue=(long)65536)]
    [System.Configuration.LongValidatorAttribute(MinValue=(long)1)]
    public long MaxReceivedMessageSize { get { return default(long); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("proxyAddress", DefaultValue=null)]
    public System.Uri ProxyAddress { get { return default(System.Uri); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("readerQuotas")]
    public System.ServiceModel.Configuration.XmlDictionaryReaderQuotasElement ReaderQuotas { get { return default(System.ServiceModel.Configuration.XmlDictionaryReaderQuotasElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("security")]
    public System.ServiceModel.Configuration.WebHttpSecurityElement Security { get { return default(System.ServiceModel.Configuration.WebHttpSecurityElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("transferMode", DefaultValue=(System.ServiceModel.TransferMode)(0))]
    [System.ServiceModel.Configuration.ServiceModelEnumValidatorAttribute(typeof(System.ServiceModel.TransferModeHelper))]
    public System.ServiceModel.TransferMode TransferMode { get { return default(System.ServiceModel.TransferMode); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("useDefaultWebProxy", DefaultValue=true)]
    public bool UseDefaultWebProxy { get { return default(bool); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Configuration.EncodingConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("writeEncoding", DefaultValue="utf-8")]
    [System.ServiceModel.Configuration.WebEncodingValidatorAttribute]
    public System.Text.Encoding WriteEncoding { get { return default(System.Text.Encoding); } set { } }
    protected internal override void InitializeFrom(System.ServiceModel.Channels.Binding binding) { }
    protected override void OnApplyConfiguration(System.ServiceModel.Channels.Binding binding) { }
  }
  public sealed partial class WebHttpElement : System.ServiceModel.Configuration.BehaviorExtensionElement {
    public WebHttpElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("automaticFormatSelectionEnabled")]
    public bool AutomaticFormatSelectionEnabled { get { return default(bool); } set { } }
    public override System.Type BehaviorType { get { return default(System.Type); } }
    [System.Configuration.ConfigurationPropertyAttribute("defaultBodyStyle")]
    [System.ServiceModel.Configuration.InternalEnumValidatorAttribute(typeof(System.ServiceModel.Web.WebMessageBodyStyleHelper))]
    public System.ServiceModel.Web.WebMessageBodyStyle DefaultBodyStyle { get { return default(System.ServiceModel.Web.WebMessageBodyStyle); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("defaultOutgoingResponseFormat")]
    [System.ServiceModel.Configuration.InternalEnumValidatorAttribute(typeof(System.ServiceModel.Web.WebMessageFormatHelper))]
    public System.ServiceModel.Web.WebMessageFormat DefaultOutgoingResponseFormat { get { return default(System.ServiceModel.Web.WebMessageFormat); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("faultExceptionEnabled")]
    public bool FaultExceptionEnabled { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("helpEnabled")]
    public bool HelpEnabled { get { return default(bool); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
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
    [System.ServiceModel.Configuration.InternalEnumValidatorAttribute(typeof(System.ServiceModel.Web.WebMessageFormatHelper))]
    public System.ServiceModel.Web.WebMessageFormat DefaultOutgoingResponseFormat { get { return default(System.ServiceModel.Web.WebMessageFormat); } set { } }
    protected internal override System.Type EndpointType { get { return default(System.Type); } }
    [System.Configuration.ConfigurationPropertyAttribute("faultExceptionEnabled", DefaultValue=false)]
    public bool FaultExceptionEnabled { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("helpEnabled", DefaultValue=false)]
    public bool HelpEnabled { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("hostNameComparisonMode", DefaultValue=(System.ServiceModel.HostNameComparisonMode)(0))]
    [System.ServiceModel.Configuration.ServiceModelEnumValidatorAttribute(typeof(System.ServiceModel.HostNameComparisonModeHelper))]
    public System.ServiceModel.HostNameComparisonMode HostNameComparisonMode { get { return default(System.ServiceModel.HostNameComparisonMode); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxBufferPoolSize", DefaultValue=(long)524288)]
    [System.Configuration.LongValidatorAttribute(MinValue=(long)0)]
    public long MaxBufferPoolSize { get { return default(long); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxBufferSize", DefaultValue=65536)]
    [System.Configuration.IntegerValidatorAttribute(MinValue=1)]
    public int MaxBufferSize { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxReceivedMessageSize", DefaultValue=(long)65536)]
    [System.Configuration.LongValidatorAttribute(MinValue=(long)1)]
    public long MaxReceivedMessageSize { get { return default(long); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("readerQuotas")]
    public System.ServiceModel.Configuration.XmlDictionaryReaderQuotasElement ReaderQuotas { get { return default(System.ServiceModel.Configuration.XmlDictionaryReaderQuotasElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("security")]
    public System.ServiceModel.Configuration.WebHttpSecurityElement Security { get { return default(System.ServiceModel.Configuration.WebHttpSecurityElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("transferMode", DefaultValue=(System.ServiceModel.TransferMode)(0))]
    [System.ServiceModel.Configuration.ServiceModelEnumValidatorAttribute(typeof(System.ServiceModel.TransferModeHelper))]
    public System.ServiceModel.TransferMode TransferMode { get { return default(System.ServiceModel.TransferMode); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Configuration.EncodingConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("writeEncoding", DefaultValue="utf-8")]
    [System.ServiceModel.Configuration.WebEncodingValidatorAttribute]
    public System.Text.Encoding WriteEncoding { get { return default(System.Text.Encoding); } set { } }
    protected internal override System.ServiceModel.Description.ServiceEndpoint CreateServiceEndpoint(System.ServiceModel.Description.ContractDescription contractDescription) { return default(System.ServiceModel.Description.ServiceEndpoint); }
    protected override void OnApplyConfiguration(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Configuration.ChannelEndpointElement serviceEndpointElement) { }
    protected override void OnApplyConfiguration(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Configuration.ServiceEndpointElement serviceEndpointElement) { }
    protected override void OnInitializeAndValidate(System.ServiceModel.Configuration.ChannelEndpointElement channelEndpointElement) { }
    protected override void OnInitializeAndValidate(System.ServiceModel.Configuration.ServiceEndpointElement serviceEndpointElement) { }
  }
  public sealed partial class WebHttpSecurityElement : System.ServiceModel.Configuration.ServiceModelConfigurationElement {
    public WebHttpSecurityElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("mode", DefaultValue=(System.ServiceModel.WebHttpSecurityMode)(0))]
    [System.ServiceModel.Configuration.InternalEnumValidatorAttribute(typeof(System.ServiceModel.WebHttpSecurityModeHelper))]
    public System.ServiceModel.WebHttpSecurityMode Mode { get { return default(System.ServiceModel.WebHttpSecurityMode); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("transport")]
    public System.ServiceModel.Configuration.HttpTransportSecurityElement Transport { get { return default(System.ServiceModel.Configuration.HttpTransportSecurityElement); } }
  }
  public sealed partial class WebMessageEncodingElement : System.ServiceModel.Configuration.BindingElementExtensionElement {
    public WebMessageEncodingElement() { }
    public override System.Type BindingElementType { get { return default(System.Type); } }
    [System.Configuration.ConfigurationPropertyAttribute("maxReadPoolSize", DefaultValue=64)]
    [System.Configuration.IntegerValidatorAttribute(MinValue=1)]
    public int MaxReadPoolSize { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxWritePoolSize", DefaultValue=16)]
    [System.Configuration.IntegerValidatorAttribute(MinValue=1)]
    public int MaxWritePoolSize { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("readerQuotas")]
    public System.ServiceModel.Configuration.XmlDictionaryReaderQuotasElement ReaderQuotas { get { return default(System.ServiceModel.Configuration.XmlDictionaryReaderQuotasElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("webContentTypeMapperType", DefaultValue="")]
    [System.Configuration.StringValidatorAttribute(MinLength=0)]
    public string WebContentTypeMapperType { get { return default(string); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Configuration.EncodingConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("writeEncoding", DefaultValue="utf-8")]
    [System.ServiceModel.Configuration.WebEncodingValidatorAttribute]
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
    [System.ServiceModel.Configuration.ServiceModelEnumValidatorAttribute(typeof(System.ServiceModel.HostNameComparisonModeHelper))]
    public System.ServiceModel.HostNameComparisonMode HostNameComparisonMode { get { return default(System.ServiceModel.HostNameComparisonMode); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxBufferPoolSize", DefaultValue=(long)524288)]
    [System.Configuration.LongValidatorAttribute(MinValue=(long)0)]
    public long MaxBufferPoolSize { get { return default(long); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxBufferSize", DefaultValue=65536)]
    [System.Configuration.IntegerValidatorAttribute(MinValue=1)]
    public int MaxBufferSize { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxReceivedMessageSize", DefaultValue=(long)65536)]
    [System.Configuration.LongValidatorAttribute(MinValue=(long)1)]
    public long MaxReceivedMessageSize { get { return default(long); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("readerQuotas")]
    public System.ServiceModel.Configuration.XmlDictionaryReaderQuotasElement ReaderQuotas { get { return default(System.ServiceModel.Configuration.XmlDictionaryReaderQuotasElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("security")]
    public System.ServiceModel.Configuration.WebHttpSecurityElement Security { get { return default(System.ServiceModel.Configuration.WebHttpSecurityElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("transferMode", DefaultValue=(System.ServiceModel.TransferMode)(0))]
    [System.ServiceModel.Configuration.ServiceModelEnumValidatorAttribute(typeof(System.ServiceModel.TransferModeHelper))]
    public System.ServiceModel.TransferMode TransferMode { get { return default(System.ServiceModel.TransferMode); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Configuration.EncodingConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("writeEncoding", DefaultValue="utf-8")]
    [System.ServiceModel.Configuration.WebEncodingValidatorAttribute]
    public System.Text.Encoding WriteEncoding { get { return default(System.Text.Encoding); } set { } }
    protected internal override System.ServiceModel.Description.ServiceEndpoint CreateServiceEndpoint(System.ServiceModel.Description.ContractDescription contractDescription) { return default(System.ServiceModel.Description.ServiceEndpoint); }
    protected override void OnApplyConfiguration(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Configuration.ChannelEndpointElement serviceEndpointElement) { }
    protected override void OnApplyConfiguration(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Configuration.ServiceEndpointElement serviceEndpointElement) { }
    protected override void OnInitializeAndValidate(System.ServiceModel.Configuration.ChannelEndpointElement channelEndpointElement) { }
    protected override void OnInitializeAndValidate(System.ServiceModel.Configuration.ServiceEndpointElement serviceEndpointElement) { }
  }
}
namespace System.ServiceModel.Description {
  [System.Runtime.Serialization.DataContractAttribute]
  public partial class JsonFaultDetail {
    public JsonFaultDetail() { }
    [System.Runtime.Serialization.DataMemberAttribute(Name="ExceptionDetail")]
    public System.ServiceModel.ExceptionDetail ExceptionDetail { get { return default(System.ServiceModel.ExceptionDetail); } set { } }
    [System.Runtime.Serialization.DataMemberAttribute(Name="ExceptionType")]
    public string ExceptionType { get { return default(string); } set { } }
    [System.Runtime.Serialization.DataMemberAttribute(Name="Message")]
    public string Message { get { return default(string); } set { } }
    [System.Runtime.Serialization.DataMemberAttribute(Name="StackTrace")]
    public string StackTrace { get { return default(string); } set { } }
  }
  public partial class WebHttpBehavior : System.ServiceModel.Description.IEndpointBehavior {
    public WebHttpBehavior() { }
    public virtual bool AutomaticFormatSelectionEnabled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public virtual System.ServiceModel.Web.WebMessageBodyStyle DefaultBodyStyle { get { return default(System.ServiceModel.Web.WebMessageBodyStyle); } set { } }
    public virtual System.ServiceModel.Web.WebMessageFormat DefaultOutgoingRequestFormat { get { return default(System.ServiceModel.Web.WebMessageFormat); } set { } }
    public virtual System.ServiceModel.Web.WebMessageFormat DefaultOutgoingResponseFormat { get { return default(System.ServiceModel.Web.WebMessageFormat); } set { } }
    public virtual bool FaultExceptionEnabled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public virtual bool HelpEnabled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected internal string JavascriptCallbackParameterName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public virtual void AddBindingParameters(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Channels.BindingParameterCollection bindingParameters) { }
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
    public virtual void Validate(System.ServiceModel.Description.ServiceEndpoint endpoint) { }
    protected virtual void ValidateBinding(System.ServiceModel.Description.ServiceEndpoint endpoint) { }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("Address={address}")]
  [System.Diagnostics.DebuggerDisplayAttribute("Name={name}")]
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
    public override bool AutomaticFormatSelectionEnabled { get { return default(bool); } set { } }
    public override System.ServiceModel.Web.WebMessageBodyStyle DefaultBodyStyle { get { return default(System.ServiceModel.Web.WebMessageBodyStyle); } set { } }
    public override System.ServiceModel.Web.WebMessageFormat DefaultOutgoingRequestFormat { get { return default(System.ServiceModel.Web.WebMessageFormat); } set { } }
    public override System.ServiceModel.Web.WebMessageFormat DefaultOutgoingResponseFormat { get { return default(System.ServiceModel.Web.WebMessageFormat); } set { } }
    public override bool FaultExceptionEnabled { get { return default(bool); } set { } }
    public override bool HelpEnabled { get { return default(bool); } set { } }
    protected override void AddClientErrorInspector(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.ClientRuntime clientRuntime) { }
    protected override void AddServerErrorHandlers(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.EndpointDispatcher endpointDispatcher) { }
    public override void ApplyClientBehavior(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.ClientRuntime clientRuntime) { }
    public override void ApplyDispatchBehavior(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.EndpointDispatcher endpointDispatcher) { }
    protected override System.ServiceModel.Dispatcher.QueryStringConverter GetQueryStringConverter(System.ServiceModel.Description.OperationDescription operationDescription) { return default(System.ServiceModel.Dispatcher.QueryStringConverter); }
    public override void Validate(System.ServiceModel.Description.ServiceEndpoint endpoint) { }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("Address={address}")]
  [System.Diagnostics.DebuggerDisplayAttribute("Name={name}")]
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
    public const string HttpOperationNamePropertyName = "HttpOperationName";
    public const string HttpOperationSelectorUriMatchedPropertyName = "UriMatched";
    protected WebHttpDispatchOperationSelector() { }
    public WebHttpDispatchOperationSelector(System.ServiceModel.Description.ServiceEndpoint endpoint) { }
    public virtual System.UriTemplate GetUriTemplate(string operationName) { return default(System.UriTemplate); }
    public string SelectOperation(ref System.ServiceModel.Channels.Message message) { return default(string); }
    protected virtual string SelectOperation(ref System.ServiceModel.Channels.Message message, out bool uriMatched) { uriMatched = default(bool); return default(string); }
  }
}
namespace System.ServiceModel.Web {
  [System.AttributeUsageAttribute((System.AttributeTargets)(64))]
  public sealed partial class AspNetCacheProfileAttribute : System.Attribute, System.ServiceModel.Description.IOperationBehavior {
    public AspNetCacheProfileAttribute(string cacheProfileName) { }
    public string CacheProfileName { get { return default(string); } }
    public void AddBindingParameters(System.ServiceModel.Description.OperationDescription operationDescription, System.ServiceModel.Channels.BindingParameterCollection bindingParameters) { }
    public void ApplyClientBehavior(System.ServiceModel.Description.OperationDescription operationDescription, System.ServiceModel.Dispatcher.ClientOperation clientOperation) { }
    public void ApplyDispatchBehavior(System.ServiceModel.Description.OperationDescription operationDescription, System.ServiceModel.Dispatcher.DispatchOperation dispatchOperation) { }
    public void Validate(System.ServiceModel.Description.OperationDescription operationDescription) { }
  }
  public partial class IncomingWebRequestContext {
    internal IncomingWebRequestContext() { }
    public string Accept { get { return default(string); } }
    public long ContentLength { get { return default(long); } }
    public string ContentType { get { return default(string); } }
    public System.Net.WebHeaderCollection Headers { get { return default(System.Net.WebHeaderCollection); } }
    public System.Collections.Generic.IEnumerable<System.String> IfMatch { get { return default(System.Collections.Generic.IEnumerable<System.String>); } }
    public System.Nullable<System.DateTime> IfModifiedSince { get { return default(System.Nullable<System.DateTime>); } }
    public System.Collections.Generic.IEnumerable<System.String> IfNoneMatch { get { return default(System.Collections.Generic.IEnumerable<System.String>); } }
    public System.Nullable<System.DateTime> IfUnmodifiedSince { get { return default(System.Nullable<System.DateTime>); } }
    public string Method { get { return default(string); } }
    public System.UriTemplateMatch UriTemplateMatch { get { return default(System.UriTemplateMatch); } set { } }
    public string UserAgent { get { return default(string); } }
    public void CheckConditionalRetrieve(System.DateTime lastModified) { }
    public void CheckConditionalRetrieve(System.Guid entityTag) { }
    public void CheckConditionalRetrieve(int entityTag) { }
    public void CheckConditionalRetrieve(long entityTag) { }
    public void CheckConditionalRetrieve(string entityTag) { }
    public void CheckConditionalUpdate(System.Guid entityTag) { }
    public void CheckConditionalUpdate(int entityTag) { }
    public void CheckConditionalUpdate(long entityTag) { }
    public void CheckConditionalUpdate(string entityTag) { }
    public System.Collections.ObjectModel.Collection<System.Net.Mime.ContentType> GetAcceptHeaderElements() { return default(System.Collections.ObjectModel.Collection<System.Net.Mime.ContentType>); }
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
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false)]
  public sealed partial class JavascriptCallbackBehaviorAttribute : System.Attribute, System.ServiceModel.Description.IContractBehavior {
    public JavascriptCallbackBehaviorAttribute() { }
    public string UrlParameterName { get { return default(string); } set { } }
    public void AddBindingParameters(System.ServiceModel.Description.ContractDescription contractDescription, System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Channels.BindingParameterCollection bindingParameters) { }
    public void ApplyClientBehavior(System.ServiceModel.Description.ContractDescription contractDescription, System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.ClientRuntime clientRuntime) { }
    public void ApplyDispatchBehavior(System.ServiceModel.Description.ContractDescription contractDescription, System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.DispatchRuntime dispatchRuntime) { }
    public void Validate(System.ServiceModel.Description.ContractDescription contractDescription, System.ServiceModel.Description.ServiceEndpoint endpoint) { }
  }
  public partial class OutgoingWebRequestContext {
    internal OutgoingWebRequestContext() { }
    public string Accept { get { return default(string); } set { } }
    public long ContentLength { get { return default(long); } set { } }
    public string ContentType { get { return default(string); } set { } }
    public System.Net.WebHeaderCollection Headers { get { return default(System.Net.WebHeaderCollection); } }
    public string IfMatch { get { return default(string); } set { } }
    public string IfModifiedSince { get { return default(string); } set { } }
    public string IfNoneMatch { get { return default(string); } set { } }
    public string IfUnmodifiedSince { get { return default(string); } set { } }
    public string Method { get { return default(string); } set { } }
    public bool SuppressEntityBody { get { return default(bool); } set { } }
    public string UserAgent { get { return default(string); } set { } }
  }
  public partial class OutgoingWebResponseContext {
    internal OutgoingWebResponseContext() { }
    public System.Text.Encoding BindingWriteEncoding { get { return default(System.Text.Encoding); } }
    public long ContentLength { get { return default(long); } set { } }
    public string ContentType { get { return default(string); } set { } }
    public string ETag { get { return default(string); } set { } }
    public System.Nullable<System.ServiceModel.Web.WebMessageFormat> Format { get { return default(System.Nullable<System.ServiceModel.Web.WebMessageFormat>); } set { } }
    public System.Net.WebHeaderCollection Headers { get { return default(System.Net.WebHeaderCollection); } }
    public System.DateTime LastModified { get { return default(System.DateTime); } set { } }
    public string Location { get { return default(string); } set { } }
    public System.Net.HttpStatusCode StatusCode { get { return default(System.Net.HttpStatusCode); } set { } }
    public string StatusDescription { get { return default(string); } set { } }
    public bool SuppressEntityBody { get { return default(bool); } set { } }
    public void SetETag(System.Guid entityTag) { }
    public void SetETag(int entityTag) { }
    public void SetETag(long entityTag) { }
    public void SetETag(string entityTag) { }
    public void SetStatusAsCreated(System.Uri locationUri) { }
    public void SetStatusAsNotFound() { }
    public void SetStatusAsNotFound(string description) { }
  }
  public partial class WebChannelFactory<TChannel> : System.ServiceModel.ChannelFactory<TChannel> where TChannel : class {
    public WebChannelFactory() { }
    public WebChannelFactory(System.ServiceModel.Channels.Binding binding) { }
    public WebChannelFactory(System.ServiceModel.Channels.Binding binding, System.Uri remoteAddress) { }
    public WebChannelFactory(System.ServiceModel.Description.ServiceEndpoint endpoint) { }
    public WebChannelFactory(string endpointConfigurationName) { }
    public WebChannelFactory(string endpointConfigurationName, System.Uri remoteAddress) { }
    public WebChannelFactory(System.Type channelType) { }
    public WebChannelFactory(System.Uri remoteAddress) { }
    protected override void OnOpening() { }
  }
  public partial class WebFaultException : System.ServiceModel.FaultException {
    public WebFaultException(System.Net.HttpStatusCode statusCode) { }
    protected WebFaultException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public System.Net.HttpStatusCode StatusCode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Net.HttpStatusCode); } }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, SerializationFormatter=true)]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial class WebFaultException<T> : System.ServiceModel.FaultException<T> {
    public WebFaultException(T detail, System.Net.HttpStatusCode statusCode) : base (default(T)) { }
    public WebFaultException(T detail, System.Net.HttpStatusCode statusCode, System.Collections.Generic.IEnumerable<System.Type> knownTypes) : base (default(T)) { }
    protected WebFaultException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base (default(T)) { }
    public System.Net.HttpStatusCode StatusCode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Net.HttpStatusCode); } }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, SerializationFormatter=true)]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
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
    void System.ServiceModel.Description.IOperationBehavior.AddBindingParameters(System.ServiceModel.Description.OperationDescription operationDescription, System.ServiceModel.Channels.BindingParameterCollection bindingParameters) { }
    void System.ServiceModel.Description.IOperationBehavior.ApplyClientBehavior(System.ServiceModel.Description.OperationDescription operationDescription, System.ServiceModel.Dispatcher.ClientOperation clientOperation) { }
    void System.ServiceModel.Description.IOperationBehavior.ApplyDispatchBehavior(System.ServiceModel.Description.OperationDescription operationDescription, System.ServiceModel.Dispatcher.DispatchOperation dispatchOperation) { }
    void System.ServiceModel.Description.IOperationBehavior.Validate(System.ServiceModel.Description.OperationDescription operationDescription) { }
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
    void System.ServiceModel.Description.IOperationBehavior.AddBindingParameters(System.ServiceModel.Description.OperationDescription operationDescription, System.ServiceModel.Channels.BindingParameterCollection bindingParameters) { }
    void System.ServiceModel.Description.IOperationBehavior.ApplyClientBehavior(System.ServiceModel.Description.OperationDescription operationDescription, System.ServiceModel.Dispatcher.ClientOperation clientOperation) { }
    void System.ServiceModel.Description.IOperationBehavior.ApplyDispatchBehavior(System.ServiceModel.Description.OperationDescription operationDescription, System.ServiceModel.Dispatcher.DispatchOperation dispatchOperation) { }
    void System.ServiceModel.Description.IOperationBehavior.Validate(System.ServiceModel.Description.OperationDescription operationDescription) { }
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
    public WebOperationContext(System.ServiceModel.OperationContext operationContext) { }
    public static System.ServiceModel.Web.WebOperationContext Current { get { return default(System.ServiceModel.Web.WebOperationContext); } }
    public System.ServiceModel.Web.IncomingWebRequestContext IncomingRequest { get { return default(System.ServiceModel.Web.IncomingWebRequestContext); } }
    public System.ServiceModel.Web.IncomingWebResponseContext IncomingResponse { get { return default(System.ServiceModel.Web.IncomingWebResponseContext); } }
    public System.ServiceModel.Web.OutgoingWebRequestContext OutgoingRequest { get { return default(System.ServiceModel.Web.OutgoingWebRequestContext); } }
    public System.ServiceModel.Web.OutgoingWebResponseContext OutgoingResponse { get { return default(System.ServiceModel.Web.OutgoingWebResponseContext); } }
    public void Attach(System.ServiceModel.OperationContext owner) { }
    public System.ServiceModel.Channels.Message CreateAtom10Response(System.ServiceModel.Syndication.ServiceDocument document) { return default(System.ServiceModel.Channels.Message); }
    public System.ServiceModel.Channels.Message CreateAtom10Response(System.ServiceModel.Syndication.SyndicationFeed feed) { return default(System.ServiceModel.Channels.Message); }
    public System.ServiceModel.Channels.Message CreateAtom10Response(System.ServiceModel.Syndication.SyndicationItem item) { return default(System.ServiceModel.Channels.Message); }
    public System.ServiceModel.Channels.Message CreateJsonResponse<T>(T instance) { return default(System.ServiceModel.Channels.Message); }
    public System.ServiceModel.Channels.Message CreateJsonResponse<T>(T instance, System.Runtime.Serialization.Json.DataContractJsonSerializer serializer) { return default(System.ServiceModel.Channels.Message); }
    public System.ServiceModel.Channels.Message CreateStreamResponse(System.Action<System.IO.Stream> streamWriter, string contentType) { return default(System.ServiceModel.Channels.Message); }
    public System.ServiceModel.Channels.Message CreateStreamResponse(System.IO.Stream stream, string contentType) { return default(System.ServiceModel.Channels.Message); }
    public System.ServiceModel.Channels.Message CreateStreamResponse(System.ServiceModel.Channels.StreamBodyWriter bodyWriter, string contentType) { return default(System.ServiceModel.Channels.Message); }
    public System.ServiceModel.Channels.Message CreateTextResponse(System.Action<System.IO.TextWriter> textWriter, string contentType) { return default(System.ServiceModel.Channels.Message); }
    public System.ServiceModel.Channels.Message CreateTextResponse(System.Action<System.IO.TextWriter> textWriter, string contentType, System.Text.Encoding encoding) { return default(System.ServiceModel.Channels.Message); }
    public System.ServiceModel.Channels.Message CreateTextResponse(string text) { return default(System.ServiceModel.Channels.Message); }
    public System.ServiceModel.Channels.Message CreateTextResponse(string text, string contentType) { return default(System.ServiceModel.Channels.Message); }
    public System.ServiceModel.Channels.Message CreateTextResponse(string text, string contentType, System.Text.Encoding encoding) { return default(System.ServiceModel.Channels.Message); }
    public System.ServiceModel.Channels.Message CreateXmlResponse(System.Xml.Linq.XDocument document) { return default(System.ServiceModel.Channels.Message); }
    public System.ServiceModel.Channels.Message CreateXmlResponse(System.Xml.Linq.XElement element) { return default(System.ServiceModel.Channels.Message); }
    public System.ServiceModel.Channels.Message CreateXmlResponse<T>(T instance) { return default(System.ServiceModel.Channels.Message); }
    public System.ServiceModel.Channels.Message CreateXmlResponse<T>(T instance, System.Runtime.Serialization.XmlObjectSerializer serializer) { return default(System.ServiceModel.Channels.Message); }
    public System.ServiceModel.Channels.Message CreateXmlResponse<T>(T instance, System.Xml.Serialization.XmlSerializer serializer) { return default(System.ServiceModel.Channels.Message); }
    public void Detach(System.ServiceModel.OperationContext owner) { }
    public System.UriTemplate GetUriTemplate(string operationName) { return default(System.UriTemplate); }
  }
  public partial class WebServiceHost : System.ServiceModel.ServiceHost {
    public WebServiceHost() { }
    public WebServiceHost(object singletonInstance, params System.Uri[] baseAddresses) { }
    public WebServiceHost(System.Type serviceType, params System.Uri[] baseAddresses) { }
    protected override void OnOpening() { }
  }
}
