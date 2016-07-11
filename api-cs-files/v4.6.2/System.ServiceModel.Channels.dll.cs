namespace System.ServiceModel {
  public partial class UdpBinding : System.ServiceModel.Channels.Binding, System.ServiceModel.Channels.IBindingRuntimePreferences {
    public UdpBinding() { }
    public UdpBinding(string configurationName) { }
    [System.ComponentModel.DefaultValueAttribute(0)]
    public int DuplicateMessageHistoryLength { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute((long)524288)]
    public long MaxBufferPoolSize { get { return default(long); } set { } }
    [System.ComponentModel.DefaultValueAttribute((long)0)]
    public long MaxPendingMessagesTotalSize { get { return default(long); } set { } }
    [System.ComponentModel.DefaultValueAttribute((long)65536)]
    public long MaxReceivedMessageSize { get { return default(long); } set { } }
    [System.ComponentModel.DefaultValueAttribute(0)]
    public int MaxRetransmitCount { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public string MulticastInterfaceId { get { return default(string); } set { } }
    public System.Xml.XmlDictionaryReaderQuotas ReaderQuotas { get { return default(System.Xml.XmlDictionaryReaderQuotas); } set { } }
    public override string Scheme { get { return default(string); } }
    bool System.ServiceModel.Channels.IBindingRuntimePreferences.ReceiveSynchronously { get { return default(bool); } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Configuration.EncodingConverter))]
    public System.Text.Encoding TextEncoding { get { return default(System.Text.Encoding); } set { } }
    [System.ComponentModel.DefaultValueAttribute(1)]
    public int TimeToLive { get { return default(int); } set { } }
    public override System.ServiceModel.Channels.BindingElementCollection CreateBindingElements() { return default(System.ServiceModel.Channels.BindingElementCollection); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeReaderQuotas() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeTextEncoding() { return default(bool); }
  }
}
namespace System.ServiceModel.Channels {
  public static partial class ByteStreamMessage {
    public static System.ServiceModel.Channels.Message CreateMessage(System.ArraySegment<System.Byte> buffer) { return default(System.ServiceModel.Channels.Message); }
    public static System.ServiceModel.Channels.Message CreateMessage(System.ArraySegment<System.Byte> buffer, System.ServiceModel.Channels.BufferManager bufferManager) { return default(System.ServiceModel.Channels.Message); }
    public static System.ServiceModel.Channels.Message CreateMessage(System.IO.Stream stream) { return default(System.ServiceModel.Channels.Message); }
  }
  public sealed partial class ByteStreamMessageEncodingBindingElement : System.ServiceModel.Channels.MessageEncodingBindingElement {
    public ByteStreamMessageEncodingBindingElement() { }
    public ByteStreamMessageEncodingBindingElement(System.Xml.XmlDictionaryReaderQuotas quota) { }
    public override System.ServiceModel.Channels.MessageVersion MessageVersion { get { return default(System.ServiceModel.Channels.MessageVersion); } set { } }
    public System.Xml.XmlDictionaryReaderQuotas ReaderQuotas { get { return default(System.Xml.XmlDictionaryReaderQuotas); } set { } }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public override System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public override bool CanBuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override bool CanBuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    public override System.ServiceModel.Channels.MessageEncoderFactory CreateMessageEncoderFactory() { return default(System.ServiceModel.Channels.MessageEncoderFactory); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeMessageVersion() { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeReaderQuotas() { return default(bool); }
  }
  public static partial class HttpRequestMessageExtensionMethods {
    public static System.ServiceModel.Channels.Message ToMessage(this System.Net.Http.HttpRequestMessage httpRequestMessage) { return default(System.ServiceModel.Channels.Message); }
  }
  public static partial class HttpResponseMessageExtensionMethods {
    public static System.ServiceModel.Channels.Message ToMessage(this System.Net.Http.HttpResponseMessage httpResponseMessage) { return default(System.ServiceModel.Channels.Message); }
  }
  public static partial class MessageExtensionMethods {
    public static System.Net.Http.HttpRequestMessage ToHttpRequestMessage(this System.ServiceModel.Channels.Message message) { return default(System.Net.Http.HttpRequestMessage); }
    public static System.Net.Http.HttpResponseMessage ToHttpResponseMessage(this System.ServiceModel.Channels.Message message) { return default(System.Net.Http.HttpResponseMessage); }
  }
  public partial class NetworkInterfaceMessageProperty {
    public NetworkInterfaceMessageProperty(int interfaceIndex) { }
    public int InterfaceIndex { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    public static string Name { get { return default(string); } }
    public void AddTo(System.ServiceModel.Channels.Message message) { }
    public void AddTo(System.ServiceModel.Channels.MessageProperties properties) { }
    public static bool TryGet(System.ServiceModel.Channels.Message message, out System.ServiceModel.Channels.NetworkInterfaceMessageProperty property) { property = default(System.ServiceModel.Channels.NetworkInterfaceMessageProperty); return default(bool); }
    public static bool TryGet(System.ServiceModel.Channels.MessageProperties properties, out System.ServiceModel.Channels.NetworkInterfaceMessageProperty property) { property = default(System.ServiceModel.Channels.NetworkInterfaceMessageProperty); return default(bool); }
  }
  public sealed partial class UdpRetransmissionSettings {
    public UdpRetransmissionSettings() { }
    public UdpRetransmissionSettings(int maxUnicastRetransmitCount, int maxMulticastRetransmitCount) { }
    public UdpRetransmissionSettings(int maxUnicastRetransmitCount, int maxMulticastRetransmitCount, System.TimeSpan delayLowerBound, System.TimeSpan delayUpperBound, System.TimeSpan maxDelayPerRetransmission) { }
    public System.TimeSpan DelayLowerBound { get { return default(System.TimeSpan); } set { } }
    public System.TimeSpan DelayUpperBound { get { return default(System.TimeSpan); } set { } }
    public System.TimeSpan MaxDelayPerRetransmission { get { return default(System.TimeSpan); } set { } }
    [System.ComponentModel.DefaultValueAttribute(0)]
    public int MaxMulticastRetransmitCount { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute(0)]
    public int MaxUnicastRetransmitCount { get { return default(int); } set { } }
    public bool ShouldSerializeDelayLowerBound() { return default(bool); }
    public bool ShouldSerializeDelayUpperBound() { return default(bool); }
    public bool ShouldSerializeMaxDelayPerRetransmission() { return default(bool); }
  }
  public partial class UdpTransportBindingElement : System.ServiceModel.Channels.TransportBindingElement, System.ServiceModel.Description.IPolicyExportExtension, System.ServiceModel.Description.IWsdlExportExtension {
    public UdpTransportBindingElement() { }
    [System.ComponentModel.DefaultValueAttribute(0)]
    public int DuplicateMessageHistoryLength { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute((long)0)]
    public long MaxPendingMessagesTotalSize { get { return default(long); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public string MulticastInterfaceId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.ServiceModel.Channels.UdpRetransmissionSettings RetransmissionSettings { get { return default(System.ServiceModel.Channels.UdpRetransmissionSettings); } set { } }
    public override string Scheme { get { return default(string); } }
    [System.ComponentModel.DefaultValueAttribute(65536)]
    public int SocketReceiveBufferSize { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute(1)]
    public int TimeToLive { get { return default(int); } set { } }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public override System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public override bool CanBuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override bool CanBuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public bool ShouldSerializeRetransmissionSettings() { return default(bool); }
    void System.ServiceModel.Description.IPolicyExportExtension.ExportPolicy(System.ServiceModel.Description.MetadataExporter exporter, System.ServiceModel.Description.PolicyConversionContext context) { }
    void System.ServiceModel.Description.IWsdlExportExtension.ExportContract(System.ServiceModel.Description.WsdlExporter exporter, System.ServiceModel.Description.WsdlContractConversionContext context) { }
    void System.ServiceModel.Description.IWsdlExportExtension.ExportEndpoint(System.ServiceModel.Description.WsdlExporter exporter, System.ServiceModel.Description.WsdlEndpointConversionContext context) { }
  }
  public partial class UdpTransportImporter : System.ServiceModel.Description.IPolicyImportExtension, System.ServiceModel.Description.IWsdlImportExtension {
    public UdpTransportImporter() { }
    public void BeforeImport(System.Web.Services.Description.ServiceDescriptionCollection wsdlDocuments, System.Xml.Schema.XmlSchemaSet xmlSchemas, System.Collections.Generic.ICollection<System.Xml.XmlElement> policy) { }
    public void ImportContract(System.ServiceModel.Description.WsdlImporter importer, System.ServiceModel.Description.WsdlContractConversionContext context) { }
    public void ImportEndpoint(System.ServiceModel.Description.WsdlImporter importer, System.ServiceModel.Description.WsdlEndpointConversionContext context) { }
    public void ImportPolicy(System.ServiceModel.Description.MetadataImporter importer, System.ServiceModel.Description.PolicyConversionContext context) { }
  }
}
namespace System.ServiceModel.Configuration {
  public sealed partial class ByteStreamMessageEncodingElement : System.ServiceModel.Configuration.BindingElementExtensionElement {
    public ByteStreamMessageEncodingElement() { }
    public override System.Type BindingElementType { get { return default(System.Type); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("readerQuotas")]
    public System.ServiceModel.Configuration.XmlDictionaryReaderQuotasElement ReaderQuotas { get { return default(System.ServiceModel.Configuration.XmlDictionaryReaderQuotasElement); } }
    public override void ApplyConfiguration(System.ServiceModel.Channels.BindingElement bindingElement) { }
    public override void CopyFrom(System.ServiceModel.Configuration.ServiceModelExtensionElement from) { }
    protected internal override System.ServiceModel.Channels.BindingElement CreateBindingElement() { return default(System.ServiceModel.Channels.BindingElement); }
    protected internal override void InitializeFrom(System.ServiceModel.Channels.BindingElement bindingElement) { }
  }
  public partial class UdpBindingCollectionElement : System.ServiceModel.Configuration.StandardBindingCollectionElement<System.ServiceModel.UdpBinding, System.ServiceModel.Configuration.UdpBindingElement> {
    public UdpBindingCollectionElement() { }
  }
  public partial class UdpBindingElement : System.ServiceModel.Configuration.StandardBindingElement {
    public UdpBindingElement() { }
    public UdpBindingElement(string name) { }
    protected override System.Type BindingElementType { get { return default(System.Type); } }
    [System.Configuration.ConfigurationPropertyAttribute("duplicateMessageHistoryLength", DefaultValue=0)]
    [System.Configuration.IntegerValidatorAttribute(MinValue=0)]
    public int DuplicateMessageHistoryLength { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxBufferPoolSize", DefaultValue=(long)524288)]
    [System.Configuration.LongValidatorAttribute(MinValue=(long)0)]
    public long MaxBufferPoolSize { get { return default(long); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxPendingMessagesTotalSize", DefaultValue=(long)0)]
    [System.Configuration.LongValidatorAttribute(MinValue=(long)0)]
    public long MaxPendingMessagesTotalSize { get { return default(long); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxReceivedMessageSize", DefaultValue=(long)65536)]
    [System.Configuration.LongValidatorAttribute(MinValue=(long)1)]
    public long MaxReceivedMessageSize { get { return default(long); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxRetransmitCount", DefaultValue=0)]
    [System.Configuration.IntegerValidatorAttribute(MinValue=0)]
    public int MaxRetransmitCount { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("multicastInterfaceId", DefaultValue=null)]
    [System.Configuration.StringValidatorAttribute]
    public string MulticastInterfaceId { get { return default(string); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("readerQuotas")]
    public System.ServiceModel.Configuration.XmlDictionaryReaderQuotasElement ReaderQuotas { get { return default(System.ServiceModel.Configuration.XmlDictionaryReaderQuotasElement); } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Configuration.EncodingConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("textEncoding", DefaultValue="utf-8")]
    public System.Text.Encoding TextEncoding { get { return default(System.Text.Encoding); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("timeToLive", DefaultValue=1)]
    [System.Configuration.IntegerValidatorAttribute(MinValue=0, MaxValue=255)]
    public int TimeToLive { get { return default(int); } set { } }
    protected internal override void InitializeFrom(System.ServiceModel.Channels.Binding binding) { }
    protected override void OnApplyConfiguration(System.ServiceModel.Channels.Binding binding) { }
  }
  public sealed partial class UdpRetransmissionSettingsElement : System.ServiceModel.Configuration.ServiceModelConfigurationElement {
    public UdpRetransmissionSettingsElement() { }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Configuration.TimeSpanOrInfiniteConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("delayLowerBound", DefaultValue="00:00:00.050")]
    [System.ServiceModel.Configuration.ServiceModelTimeSpanValidatorAttribute(MinValueString="00:00:00")]
    public System.TimeSpan DelayLowerBound { get { return default(System.TimeSpan); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Configuration.TimeSpanOrInfiniteConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("delayUpperBound", DefaultValue="00:00:00.250")]
    [System.ServiceModel.Configuration.ServiceModelTimeSpanValidatorAttribute(MinValueString="00:00:00")]
    public System.TimeSpan DelayUpperBound { get { return default(System.TimeSpan); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Configuration.TimeSpanOrInfiniteConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("maxDelayPerRetransmission", DefaultValue="00:00:00.500")]
    [System.ServiceModel.Configuration.ServiceModelTimeSpanValidatorAttribute(MinValueString="00:00:00")]
    public System.TimeSpan MaxDelayPerRetransmission { get { return default(System.TimeSpan); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxMulticastRetransmitCount", DefaultValue=0)]
    [System.Configuration.IntegerValidatorAttribute(MinValue=0)]
    public int MaxMulticastRetransmitCount { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxUnicastRetransmitCount", DefaultValue=0)]
    [System.Configuration.IntegerValidatorAttribute(MinValue=0)]
    public int MaxUnicastRetransmitCount { get { return default(int); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  public sealed partial class UdpTransportElement : System.ServiceModel.Configuration.TransportElement {
    public UdpTransportElement() { }
    public override System.Type BindingElementType { get { return default(System.Type); } }
    [System.Configuration.ConfigurationPropertyAttribute("duplicateMessageHistoryLength", DefaultValue=0)]
    [System.Configuration.IntegerValidatorAttribute(MinValue=0)]
    public int DuplicateMessageHistoryLength { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxPendingMessagesTotalSize", DefaultValue=(long)0)]
    [System.Configuration.LongValidatorAttribute(MinValue=(long)0)]
    public long MaxPendingMessagesTotalSize { get { return default(long); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("multicastInterfaceId", DefaultValue=null)]
    [System.Configuration.StringValidatorAttribute]
    public string MulticastInterfaceId { get { return default(string); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("retransmissionSettings")]
    public System.ServiceModel.Configuration.UdpRetransmissionSettingsElement RetransmissionSettings { get { return default(System.ServiceModel.Configuration.UdpRetransmissionSettingsElement); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("socketReceiveBufferSize", DefaultValue=65536)]
    [System.Configuration.IntegerValidatorAttribute(MinValue=1)]
    public int SocketReceiveBufferSize { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("timeToLive", DefaultValue=1)]
    [System.Configuration.IntegerValidatorAttribute(MinValue=0, MaxValue=255)]
    public int TimeToLive { get { return default(int); } set { } }
    public override void ApplyConfiguration(System.ServiceModel.Channels.BindingElement bindingElement) { }
    protected override System.ServiceModel.Channels.TransportBindingElement CreateDefaultBindingElement() { return default(System.ServiceModel.Channels.TransportBindingElement); }
    protected internal override void InitializeFrom(System.ServiceModel.Channels.BindingElement bindingElement) { }
  }
}
