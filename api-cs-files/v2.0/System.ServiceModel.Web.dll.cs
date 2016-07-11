namespace System {
  public partial class UriTemplate {
    public UriTemplate(string template) { }
    public UriTemplate(string template, bool ignoreTrailingSlash) { }
    public UriTemplate(string template, bool ignoreTrailingSlash, System.Collections.Generic.IDictionary<System.String, System.String> additionalDefaults) { }
    public UriTemplate(string template, System.Collections.Generic.IDictionary<System.String, System.String> additionalDefaults) { }
    public System.Collections.Generic.IDictionary<System.String, System.String> Defaults { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IDictionary<System.String, System.String>); } }
    public bool IgnoreTrailingSlash { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.String> PathSegmentVariableNames { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.String>); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.String> QueryValueVariableNames { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.String>); } }
    public System.Uri BindByName(System.Uri baseAddress, System.Collections.Generic.IDictionary<System.String, System.String> parameters) { return default(System.Uri); }
    public System.Uri BindByName(System.Uri baseAddress, System.Collections.Generic.IDictionary<System.String, System.String> parameters, bool omitDefaults) { return default(System.Uri); }
    public System.Uri BindByName(System.Uri baseAddress, System.Collections.Specialized.NameValueCollection parameters) { return default(System.Uri); }
    public System.Uri BindByName(System.Uri baseAddress, System.Collections.Specialized.NameValueCollection parameters, bool omitDefaults) { return default(System.Uri); }
    public System.Uri BindByPosition(System.Uri baseAddress, params System.String[] values) { return default(System.Uri); }
    public bool IsEquivalentTo(System.UriTemplate other) { return default(bool); }
    public System.UriTemplateMatch Match(System.Uri baseAddress, System.Uri candidate) { return default(System.UriTemplateMatch); }
    public override string ToString() { return default(string); }
  }
  public partial class UriTemplateEquivalenceComparer : System.Collections.Generic.IEqualityComparer<System.UriTemplate> {
    public UriTemplateEquivalenceComparer() { }
    public bool Equals(System.UriTemplate x, System.UriTemplate y) { return default(bool); }
    public int GetHashCode(System.UriTemplate obj) { return default(int); }
  }
  public partial class UriTemplateMatch {
    public UriTemplateMatch() { }
    public System.Uri BaseUri { get { return default(System.Uri); } set { } }
    public System.Collections.Specialized.NameValueCollection BoundVariables { get { return default(System.Collections.Specialized.NameValueCollection); } }
    public object Data { get { return default(object); } set { } }
    public System.Collections.Specialized.NameValueCollection QueryParameters { get { return default(System.Collections.Specialized.NameValueCollection); } }
    public System.Collections.ObjectModel.Collection<System.String> RelativePathSegments { get { return default(System.Collections.ObjectModel.Collection<System.String>); } }
    public System.Uri RequestUri { get { return default(System.Uri); } set { } }
    public System.UriTemplate Template { get { return default(System.UriTemplate); } set { } }
    public System.Collections.ObjectModel.Collection<System.String> WildcardPathSegments { get { return default(System.Collections.ObjectModel.Collection<System.String>); } }
  }
  public partial class UriTemplateMatchException : System.SystemException {
    public UriTemplateMatchException() { }
    protected UriTemplateMatchException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public UriTemplateMatchException(string msg) { }
    public UriTemplateMatchException(string msg, System.Exception inner) { }
  }
  public partial class UriTemplateTable {
    public UriTemplateTable() { }
    public UriTemplateTable(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.UriTemplate, System.Object>> keyValuePairs) { }
    public UriTemplateTable(System.Uri baseAddress) { }
    public UriTemplateTable(System.Uri baseAddress, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.UriTemplate, System.Object>> keyValuePairs) { }
    public System.Uri BaseAddress { get { return default(System.Uri); } set { } }
    public bool IsReadOnly { get { return default(bool); } }
    public System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<System.UriTemplate, System.Object>> KeyValuePairs { get { return default(System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<System.UriTemplate, System.Object>>); } }
    [System.MonoTODOAttribute]
    public void MakeReadOnly(bool allowDuplicateEquivalentUriTemplates) { }
    public System.Collections.ObjectModel.Collection<System.UriTemplateMatch> Match(System.Uri uri) { return default(System.Collections.ObjectModel.Collection<System.UriTemplateMatch>); }
    public System.UriTemplateMatch MatchSingle(System.Uri uri) { return default(System.UriTemplateMatch); }
  }
}
namespace System.Runtime.Serialization.Json {
  public sealed partial class DataContractJsonSerializer : System.Runtime.Serialization.XmlObjectSerializer {
    public DataContractJsonSerializer(System.Type type) { }
    public DataContractJsonSerializer(System.Type type, System.Collections.Generic.IEnumerable<System.Type> knownTypes) { }
    public DataContractJsonSerializer(System.Type type, System.Collections.Generic.IEnumerable<System.Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, System.Runtime.Serialization.IDataContractSurrogate dataContractSurrogate, bool alwaysEmitTypeInformation) { }
    public DataContractJsonSerializer(System.Type type, string rootName) { }
    public DataContractJsonSerializer(System.Type type, string rootName, System.Collections.Generic.IEnumerable<System.Type> knownTypes) { }
    public DataContractJsonSerializer(System.Type type, string rootName, System.Collections.Generic.IEnumerable<System.Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, System.Runtime.Serialization.IDataContractSurrogate dataContractSurrogate, bool alwaysEmitTypeInformation) { }
    public DataContractJsonSerializer(System.Type type, System.Xml.XmlDictionaryString rootName) { }
    public DataContractJsonSerializer(System.Type type, System.Xml.XmlDictionaryString rootName, System.Collections.Generic.IEnumerable<System.Type> knownTypes) { }
    public DataContractJsonSerializer(System.Type type, System.Xml.XmlDictionaryString rootName, System.Collections.Generic.IEnumerable<System.Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, System.Runtime.Serialization.IDataContractSurrogate dataContractSurrogate, bool alwaysEmitTypeInformation) { }
    [System.MonoTODOAttribute]
    public System.Runtime.Serialization.IDataContractSurrogate DataContractSurrogate { get { return default(System.Runtime.Serialization.IDataContractSurrogate); } }
    [System.MonoTODOAttribute]
    public bool IgnoreExtensionDataObject { get { return default(bool); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Type> KnownTypes { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Type>); } }
    public int MaxItemsInObjectGraph { get { return default(int); } }
    public override bool IsStartObject(System.Xml.XmlDictionaryReader reader) { return default(bool); }
    public override bool IsStartObject(System.Xml.XmlReader reader) { return default(bool); }
    public override object ReadObject(System.IO.Stream stream) { return default(object); }
    public override object ReadObject(System.Xml.XmlDictionaryReader reader) { return default(object); }
    public override object ReadObject(System.Xml.XmlDictionaryReader reader, bool verifyObjectName) { return default(object); }
    public override object ReadObject(System.Xml.XmlReader reader) { return default(object); }
    public override object ReadObject(System.Xml.XmlReader reader, bool verifyObjectName) { return default(object); }
    public override void WriteEndObject(System.Xml.XmlDictionaryWriter writer) { }
    public override void WriteEndObject(System.Xml.XmlWriter writer) { }
    public override void WriteObject(System.IO.Stream stream, object graph) { }
    public override void WriteObject(System.Xml.XmlDictionaryWriter writer, object graph) { }
    public override void WriteObject(System.Xml.XmlWriter writer, object graph) { }
    public override void WriteObjectContent(System.Xml.XmlDictionaryWriter writer, object graph) { }
    public override void WriteObjectContent(System.Xml.XmlWriter writer, object graph) { }
    public override void WriteStartObject(System.Xml.XmlDictionaryWriter writer, object graph) { }
    public override void WriteStartObject(System.Xml.XmlWriter writer, object graph) { }
  }
  public partial interface IXmlJsonReaderInitializer {
    void SetInput(System.Byte[] buffer, int offset, int count, System.Text.Encoding encoding, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.OnXmlDictionaryReaderClose onClose);
    void SetInput(System.IO.Stream stream, System.Text.Encoding encoding, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.OnXmlDictionaryReaderClose onClose);
  }
  public partial interface IXmlJsonWriterInitializer {
    void SetOutput(System.IO.Stream stream, System.Text.Encoding encoding, bool ownsStream);
  }
  public static partial class JsonReaderWriterFactory {
    public static System.Xml.XmlDictionaryReader CreateJsonReader(System.Byte[] buffer, int offset, int count, System.Text.Encoding encoding, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.OnXmlDictionaryReaderClose onClose) { return default(System.Xml.XmlDictionaryReader); }
    public static System.Xml.XmlDictionaryReader CreateJsonReader(System.Byte[] buffer, int offset, int count, System.Xml.XmlDictionaryReaderQuotas quotas) { return default(System.Xml.XmlDictionaryReader); }
    public static System.Xml.XmlDictionaryReader CreateJsonReader(System.Byte[] buffer, System.Xml.XmlDictionaryReaderQuotas quotas) { return default(System.Xml.XmlDictionaryReader); }
    public static System.Xml.XmlDictionaryReader CreateJsonReader(System.IO.Stream stream, System.Text.Encoding encoding, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.OnXmlDictionaryReaderClose onClose) { return default(System.Xml.XmlDictionaryReader); }
    public static System.Xml.XmlDictionaryReader CreateJsonReader(System.IO.Stream stream, System.Xml.XmlDictionaryReaderQuotas quotas) { return default(System.Xml.XmlDictionaryReader); }
    public static System.Xml.XmlDictionaryWriter CreateJsonWriter(System.IO.Stream stream) { return default(System.Xml.XmlDictionaryWriter); }
    public static System.Xml.XmlDictionaryWriter CreateJsonWriter(System.IO.Stream stream, System.Text.Encoding encoding) { return default(System.Xml.XmlDictionaryWriter); }
    public static System.Xml.XmlDictionaryWriter CreateJsonWriter(System.IO.Stream stream, System.Text.Encoding encoding, bool ownsStream) { return default(System.Xml.XmlDictionaryWriter); }
  }
}
namespace System.ServiceModel {
  public partial class WebHttpBinding : System.ServiceModel.Channels.Binding, System.ServiceModel.Channels.IBindingRuntimePreferences {
    public WebHttpBinding() { }
    public WebHttpBinding(System.ServiceModel.WebHttpSecurityMode mode) { }
    public WebHttpBinding(string configurationName) { }
    public bool AllowCookies { get { return default(bool); } set { } }
    public bool BypassProxyOnLocal { get { return default(bool); } set { } }
    public System.ServiceModel.EnvelopeVersion EnvelopeVersion { get { return default(System.ServiceModel.EnvelopeVersion); } }
    public System.ServiceModel.HostNameComparisonMode HostNameComparisonMode { get { return default(System.ServiceModel.HostNameComparisonMode); } set { } }
    public long MaxBufferPoolSize { get { return default(long); } set { } }
    public int MaxBufferSize { get { return default(int); } set { } }
    public long MaxReceivedMessageSize { get { return default(long); } set { } }
    public System.Uri ProxyAddress { get { return default(System.Uri); } set { } }
    public System.Xml.XmlDictionaryReaderQuotas ReaderQuotas { get { return default(System.Xml.XmlDictionaryReaderQuotas); } set { } }
    public override string Scheme { get { return default(string); } }
    public System.ServiceModel.WebHttpSecurity Security { get { return default(System.ServiceModel.WebHttpSecurity); } }
    bool System.ServiceModel.Channels.IBindingRuntimePreferences.ReceiveSynchronously { get { return default(bool); } }
    public System.ServiceModel.TransferMode TransferMode { get { return default(System.ServiceModel.TransferMode); } set { } }
    public bool UseDefaultWebProxy { get { return default(bool); } set { } }
    public System.Text.Encoding WriteEncoding { get { return default(System.Text.Encoding); } set { } }
    public override System.ServiceModel.Channels.BindingElementCollection CreateBindingElements() { return default(System.ServiceModel.Channels.BindingElementCollection); }
  }
  public sealed partial class WebHttpSecurity {
    internal WebHttpSecurity() { }
    public System.ServiceModel.WebHttpSecurityMode Mode { get { return default(System.ServiceModel.WebHttpSecurityMode); } set { } }
    public System.ServiceModel.HttpTransportSecurity Transport { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.HttpTransportSecurity); } }
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
}
namespace System.ServiceModel.Description {
  public partial class WebHttpBehavior : System.ServiceModel.Description.IEndpointBehavior {
    public WebHttpBehavior() { }
    public virtual System.ServiceModel.Web.WebMessageBodyStyle DefaultBodyStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Web.WebMessageBodyStyle); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public virtual System.ServiceModel.Web.WebMessageFormat DefaultOutgoingRequestFormat { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Web.WebMessageFormat); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public virtual System.ServiceModel.Web.WebMessageFormat DefaultOutgoingResponseFormat { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Web.WebMessageFormat); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
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
namespace System.ServiceModel.Syndication {
  [System.Xml.Serialization.XmlRootAttribute("feed", Namespace="http://www.w3.org/2005/Atom")]
  public partial class Atom10FeedFormatter : System.ServiceModel.Syndication.SyndicationFeedFormatter, System.Xml.Serialization.IXmlSerializable {
    public Atom10FeedFormatter() { }
    public Atom10FeedFormatter(System.ServiceModel.Syndication.SyndicationFeed feedToWrite) { }
    public Atom10FeedFormatter(System.Type feedTypeToCreate) { }
    protected System.Type FeedType { get { return default(System.Type); } }
    public bool PreserveAttributeExtensions { get { return default(bool); } set { } }
    public bool PreserveElementExtensions { get { return default(bool); } set { } }
    public override string Version { get { return default(string); } }
    public override bool CanRead(System.Xml.XmlReader reader) { return default(bool); }
    protected override System.ServiceModel.Syndication.SyndicationFeed CreateFeedInstance() { return default(System.ServiceModel.Syndication.SyndicationFeed); }
    public override void ReadFrom(System.Xml.XmlReader reader) { }
    protected virtual System.ServiceModel.Syndication.SyndicationItem ReadItem(System.Xml.XmlReader reader, System.ServiceModel.Syndication.SyndicationFeed feed) { return default(System.ServiceModel.Syndication.SyndicationItem); }
    protected virtual System.Collections.Generic.IEnumerable<System.ServiceModel.Syndication.SyndicationItem> ReadItems(System.Xml.XmlReader reader, System.ServiceModel.Syndication.SyndicationFeed feed, out bool areAllItemsRead) { areAllItemsRead = default(bool); return default(System.Collections.Generic.IEnumerable<System.ServiceModel.Syndication.SyndicationItem>); }
    System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { return default(System.Xml.Schema.XmlSchema); }
    void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
    void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
    [System.MonoTODOAttribute("Find out how feedBaseUri is used")]
    protected virtual void WriteItem(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.SyndicationItem item, System.Uri feedBaseUri) { }
    protected virtual void WriteItems(System.Xml.XmlWriter writer, System.Collections.Generic.IEnumerable<System.ServiceModel.Syndication.SyndicationItem> items, System.Uri feedBaseUri) { }
    public override void WriteTo(System.Xml.XmlWriter writer) { }
  }
  [System.Xml.Serialization.XmlRootAttribute("feed", Namespace="http://www.w3.org/2005/Atom")]
  public partial class Atom10FeedFormatter<TSyndicationFeed> : System.ServiceModel.Syndication.Atom10FeedFormatter where TSyndicationFeed : System.ServiceModel.Syndication.SyndicationFeed, new() {
    public Atom10FeedFormatter() { }
    public Atom10FeedFormatter(TSyndicationFeed feedToWrite) { }
    protected override System.ServiceModel.Syndication.SyndicationFeed CreateFeedInstance() { return default(System.ServiceModel.Syndication.SyndicationFeed); }
  }
  [System.Xml.Serialization.XmlRootAttribute("entry", Namespace="http://www.w3.org/2005/Atom")]
  public partial class Atom10ItemFormatter : System.ServiceModel.Syndication.SyndicationItemFormatter, System.Xml.Serialization.IXmlSerializable {
    public Atom10ItemFormatter() { }
    public Atom10ItemFormatter(System.ServiceModel.Syndication.SyndicationItem feedToWrite) { }
    public Atom10ItemFormatter(System.Type itemTypeToCreate) { }
    protected System.Type ItemType { get { return default(System.Type); } }
    public bool PreserveAttributeExtensions { get { return default(bool); } set { } }
    public bool PreserveElementExtensions { get { return default(bool); } set { } }
    public override string Version { get { return default(string); } }
    public override bool CanRead(System.Xml.XmlReader reader) { return default(bool); }
    protected override System.ServiceModel.Syndication.SyndicationItem CreateItemInstance() { return default(System.ServiceModel.Syndication.SyndicationItem); }
    public override void ReadFrom(System.Xml.XmlReader reader) { }
    System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { return default(System.Xml.Schema.XmlSchema); }
    void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
    void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
    public override void WriteTo(System.Xml.XmlWriter writer) { }
  }
  [System.Xml.Serialization.XmlRootAttribute("entry", Namespace="http://www.w3.org/2005/Atom")]
  public partial class Atom10ItemFormatter<TSyndicationItem> : System.ServiceModel.Syndication.Atom10ItemFormatter where TSyndicationItem : System.ServiceModel.Syndication.SyndicationItem, new() {
    public Atom10ItemFormatter() { }
    public Atom10ItemFormatter(TSyndicationItem itemToWrite) { }
    protected override System.ServiceModel.Syndication.SyndicationItem CreateItemInstance() { return default(System.ServiceModel.Syndication.SyndicationItem); }
  }
  [System.Xml.Serialization.XmlRootAttribute("categories", Namespace="http://www.w3.org/2007/app")]
  public partial class AtomPub10CategoriesDocumentFormatter : System.ServiceModel.Syndication.CategoriesDocumentFormatter, System.Xml.Serialization.IXmlSerializable {
    public AtomPub10CategoriesDocumentFormatter() { }
    public AtomPub10CategoriesDocumentFormatter(System.ServiceModel.Syndication.CategoriesDocument documentToWrite) { }
    public AtomPub10CategoriesDocumentFormatter(System.Type inlineDocumentType, System.Type referencedDocumentType) { }
    public override string Version { get { return default(string); } }
    public override bool CanRead(System.Xml.XmlReader reader) { return default(bool); }
    protected override System.ServiceModel.Syndication.InlineCategoriesDocument CreateInlineCategoriesDocument() { return default(System.ServiceModel.Syndication.InlineCategoriesDocument); }
    protected override System.ServiceModel.Syndication.ReferencedCategoriesDocument CreateReferencedCategoriesDocument() { return default(System.ServiceModel.Syndication.ReferencedCategoriesDocument); }
    public override void ReadFrom(System.Xml.XmlReader reader) { }
    System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { return default(System.Xml.Schema.XmlSchema); }
    void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
    void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
    public override void WriteTo(System.Xml.XmlWriter writer) { }
  }
  [System.Xml.Serialization.XmlRootAttribute("service", Namespace="http://www.w3.org/2007/app")]
  public partial class AtomPub10ServiceDocumentFormatter : System.ServiceModel.Syndication.ServiceDocumentFormatter, System.Xml.Serialization.IXmlSerializable {
    public AtomPub10ServiceDocumentFormatter() { }
    public AtomPub10ServiceDocumentFormatter(System.ServiceModel.Syndication.ServiceDocument documentToWrite) { }
    public AtomPub10ServiceDocumentFormatter(System.Type documentTypeToCreate) { }
    public override string Version { get { return default(string); } }
    public override bool CanRead(System.Xml.XmlReader reader) { return default(bool); }
    protected override System.ServiceModel.Syndication.ServiceDocument CreateDocumentInstance() { return default(System.ServiceModel.Syndication.ServiceDocument); }
    public override void ReadFrom(System.Xml.XmlReader reader) { }
    System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { return default(System.Xml.Schema.XmlSchema); }
    void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
    void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
    public override void WriteTo(System.Xml.XmlWriter writer) { }
  }
  [System.Xml.Serialization.XmlRootAttribute("service", Namespace="http://www.w3.org/2007/app")]
  public partial class AtomPub10ServiceDocumentFormatter<TServiceDocument> : System.ServiceModel.Syndication.AtomPub10ServiceDocumentFormatter where TServiceDocument : System.ServiceModel.Syndication.ServiceDocument, new() {
    public AtomPub10ServiceDocumentFormatter() { }
    public AtomPub10ServiceDocumentFormatter(TServiceDocument documentToWrite) { }
    protected override System.ServiceModel.Syndication.ServiceDocument CreateDocumentInstance() { return default(System.ServiceModel.Syndication.ServiceDocument); }
  }
  public abstract partial class CategoriesDocument {
    internal CategoriesDocument() { }
    public System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.String> AttributeExtensions { get { return default(System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.String>); } }
    public System.Uri BaseUri { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Uri); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.ServiceModel.Syndication.SyndicationElementExtensionCollection ElementExtensions { get { return default(System.ServiceModel.Syndication.SyndicationElementExtensionCollection); } }
    public string Language { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public static System.ServiceModel.Syndication.InlineCategoriesDocument Create(System.Collections.ObjectModel.Collection<System.ServiceModel.Syndication.SyndicationCategory> categories) { return default(System.ServiceModel.Syndication.InlineCategoriesDocument); }
    public static System.ServiceModel.Syndication.InlineCategoriesDocument Create(System.Collections.ObjectModel.Collection<System.ServiceModel.Syndication.SyndicationCategory> categories, bool isFixed, string scheme) { return default(System.ServiceModel.Syndication.InlineCategoriesDocument); }
    public static System.ServiceModel.Syndication.ReferencedCategoriesDocument Create(System.Uri linkToCategoriesDocument) { return default(System.ServiceModel.Syndication.ReferencedCategoriesDocument); }
    public System.ServiceModel.Syndication.CategoriesDocumentFormatter GetFormatter() { return default(System.ServiceModel.Syndication.CategoriesDocumentFormatter); }
    public static System.ServiceModel.Syndication.CategoriesDocument Load(System.Xml.XmlReader reader) { return default(System.ServiceModel.Syndication.CategoriesDocument); }
    public void Save(System.Xml.XmlWriter writer) { }
    protected internal virtual bool TryParseAttribute(string name, string ns, string value, string version) { return default(bool); }
    protected internal virtual bool TryParseElement(System.Xml.XmlReader reader, string version) { return default(bool); }
    protected internal virtual void WriteAttributeExtensions(System.Xml.XmlWriter writer, string version) { }
    protected internal virtual void WriteElementExtensions(System.Xml.XmlWriter writer, string version) { }
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public abstract partial class CategoriesDocumentFormatter {
    protected CategoriesDocumentFormatter() { }
    protected CategoriesDocumentFormatter(System.ServiceModel.Syndication.CategoriesDocument documentToWrite) { }
    public System.ServiceModel.Syndication.CategoriesDocument Document { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Syndication.CategoriesDocument); } }
    public abstract string Version { get; }
    public abstract bool CanRead(System.Xml.XmlReader reader);
    protected virtual System.ServiceModel.Syndication.InlineCategoriesDocument CreateInlineCategoriesDocument() { return default(System.ServiceModel.Syndication.InlineCategoriesDocument); }
    protected virtual System.ServiceModel.Syndication.ReferencedCategoriesDocument CreateReferencedCategoriesDocument() { return default(System.ServiceModel.Syndication.ReferencedCategoriesDocument); }
    public abstract void ReadFrom(System.Xml.XmlReader reader);
    protected virtual void SetDocument(System.ServiceModel.Syndication.CategoriesDocument document) { }
    public abstract void WriteTo(System.Xml.XmlWriter writer);
  }
  public partial class InlineCategoriesDocument : System.ServiceModel.Syndication.CategoriesDocument {
    public InlineCategoriesDocument() { }
    public InlineCategoriesDocument(System.Collections.Generic.IEnumerable<System.ServiceModel.Syndication.SyndicationCategory> categories) { }
    public InlineCategoriesDocument(System.Collections.Generic.IEnumerable<System.ServiceModel.Syndication.SyndicationCategory> categories, bool isFixed, string scheme) { }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Syndication.SyndicationCategory> Categories { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Syndication.SyndicationCategory>); } }
    public bool IsFixed { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Scheme { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected internal virtual System.ServiceModel.Syndication.SyndicationCategory CreateCategory() { return default(System.ServiceModel.Syndication.SyndicationCategory); }
  }
  public partial class ReferencedCategoriesDocument : System.ServiceModel.Syndication.CategoriesDocument {
    public ReferencedCategoriesDocument() { }
    public ReferencedCategoriesDocument(System.Uri link) { }
    public System.Uri Link { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Uri); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial class ResourceCollectionInfo {
    public ResourceCollectionInfo() { }
    public ResourceCollectionInfo(System.ServiceModel.Syndication.TextSyndicationContent title, System.Uri link) { }
    public ResourceCollectionInfo(System.ServiceModel.Syndication.TextSyndicationContent title, System.Uri link, System.Collections.Generic.IEnumerable<System.ServiceModel.Syndication.CategoriesDocument> categories, bool allowsNewEntries) { }
    public ResourceCollectionInfo(System.ServiceModel.Syndication.TextSyndicationContent title, System.Uri link, System.Collections.Generic.IEnumerable<System.ServiceModel.Syndication.CategoriesDocument> categories, System.Collections.Generic.IEnumerable<System.String> accepts) { }
    public ResourceCollectionInfo(string title, System.Uri link) { }
    public System.Collections.ObjectModel.Collection<System.String> Accepts { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.ObjectModel.Collection<System.String>); } }
    public System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.String> AttributeExtensions { get { return default(System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.String>); } }
    public System.Uri BaseUri { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Uri); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Syndication.CategoriesDocument> Categories { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Syndication.CategoriesDocument>); } }
    public System.ServiceModel.Syndication.SyndicationElementExtensionCollection ElementExtensions { get { return default(System.ServiceModel.Syndication.SyndicationElementExtensionCollection); } }
    public System.Uri Link { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Uri); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.ServiceModel.Syndication.TextSyndicationContent Title { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Syndication.TextSyndicationContent); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected internal virtual System.ServiceModel.Syndication.InlineCategoriesDocument CreateInlineCategoriesDocument() { return default(System.ServiceModel.Syndication.InlineCategoriesDocument); }
    protected internal virtual System.ServiceModel.Syndication.ReferencedCategoriesDocument CreateReferencedCategoriesDocument() { return default(System.ServiceModel.Syndication.ReferencedCategoriesDocument); }
    protected internal virtual bool TryParseAttribute(string name, string ns, string value, string version) { return default(bool); }
    protected internal virtual bool TryParseElement(System.Xml.XmlReader reader, string version) { return default(bool); }
    protected internal virtual void WriteAttributeExtensions(System.Xml.XmlWriter writer, string version) { }
    protected internal virtual void WriteElementExtensions(System.Xml.XmlWriter writer, string version) { }
  }
  [System.Xml.Serialization.XmlRootAttribute("rss", Namespace="")]
  public partial class Rss20FeedFormatter : System.ServiceModel.Syndication.SyndicationFeedFormatter, System.Xml.Serialization.IXmlSerializable {
    public Rss20FeedFormatter() { }
    public Rss20FeedFormatter(System.ServiceModel.Syndication.SyndicationFeed feedToWrite) { }
    public Rss20FeedFormatter(System.ServiceModel.Syndication.SyndicationFeed feedToWrite, bool serializeExtensionsAsAtom) { }
    public Rss20FeedFormatter(System.Type feedTypeToCreate) { }
    protected System.Type FeedType { get { return default(System.Type); } }
    public bool PreserveAttributeExtensions { get { return default(bool); } set { } }
    public bool PreserveElementExtensions { get { return default(bool); } set { } }
    public bool SerializeExtensionsAsAtom { get { return default(bool); } set { } }
    public override string Version { get { return default(string); } }
    public override bool CanRead(System.Xml.XmlReader reader) { return default(bool); }
    protected override System.ServiceModel.Syndication.SyndicationFeed CreateFeedInstance() { return default(System.ServiceModel.Syndication.SyndicationFeed); }
    public override void ReadFrom(System.Xml.XmlReader reader) { }
    protected virtual System.ServiceModel.Syndication.SyndicationItem ReadItem(System.Xml.XmlReader reader, System.ServiceModel.Syndication.SyndicationFeed feed) { return default(System.ServiceModel.Syndication.SyndicationItem); }
    protected virtual System.Collections.Generic.IEnumerable<System.ServiceModel.Syndication.SyndicationItem> ReadItems(System.Xml.XmlReader reader, System.ServiceModel.Syndication.SyndicationFeed feed, out bool areAllItemsRead) { areAllItemsRead = default(bool); return default(System.Collections.Generic.IEnumerable<System.ServiceModel.Syndication.SyndicationItem>); }
    protected internal override void SetFeed(System.ServiceModel.Syndication.SyndicationFeed feed) { }
    System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { return default(System.Xml.Schema.XmlSchema); }
    void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
    void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
    protected virtual void WriteItem(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.SyndicationItem item, System.Uri feedBaseUri) { }
    protected virtual void WriteItems(System.Xml.XmlWriter writer, System.Collections.Generic.IEnumerable<System.ServiceModel.Syndication.SyndicationItem> items, System.Uri feedBaseUri) { }
    public override void WriteTo(System.Xml.XmlWriter writer) { }
  }
  [System.Xml.Serialization.XmlRootAttribute("rss", Namespace="")]
  public partial class Rss20FeedFormatter<TSyndicationFeed> : System.ServiceModel.Syndication.Rss20FeedFormatter where TSyndicationFeed : System.ServiceModel.Syndication.SyndicationFeed, new() {
    public Rss20FeedFormatter() { }
    public Rss20FeedFormatter(TSyndicationFeed feedToWrite) { }
    public Rss20FeedFormatter(TSyndicationFeed feedToWrite, bool serializeExtensionsAsAtom) { }
    protected override System.ServiceModel.Syndication.SyndicationFeed CreateFeedInstance() { return default(System.ServiceModel.Syndication.SyndicationFeed); }
  }
  [System.Xml.Serialization.XmlRootAttribute("item", Namespace="")]
  public partial class Rss20ItemFormatter : System.ServiceModel.Syndication.SyndicationItemFormatter, System.Xml.Serialization.IXmlSerializable {
    public Rss20ItemFormatter() { }
    public Rss20ItemFormatter(System.ServiceModel.Syndication.SyndicationItem itemToWrite) { }
    public Rss20ItemFormatter(System.ServiceModel.Syndication.SyndicationItem itemToWrite, bool serializeExtensionsAsAtom) { }
    public Rss20ItemFormatter(System.Type itemTypeToCreate) { }
    protected System.Type ItemType { get { return default(System.Type); } }
    public bool PreserveAttributeExtensions { get { return default(bool); } set { } }
    public bool PreserveElementExtensions { get { return default(bool); } set { } }
    public bool SerializeExtensionsAsAtom { get { return default(bool); } set { } }
    public override string Version { get { return default(string); } }
    public override bool CanRead(System.Xml.XmlReader reader) { return default(bool); }
    protected override System.ServiceModel.Syndication.SyndicationItem CreateItemInstance() { return default(System.ServiceModel.Syndication.SyndicationItem); }
    public override void ReadFrom(System.Xml.XmlReader reader) { }
    System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { return default(System.Xml.Schema.XmlSchema); }
    void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
    void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
    public override void WriteTo(System.Xml.XmlWriter writer) { }
  }
  [System.Xml.Serialization.XmlRootAttribute("item", Namespace="")]
  public partial class Rss20ItemFormatter<TSyndicationItem> : System.ServiceModel.Syndication.Rss20ItemFormatter where TSyndicationItem : System.ServiceModel.Syndication.SyndicationItem, new() {
    public Rss20ItemFormatter() { }
    public Rss20ItemFormatter(TSyndicationItem itemToWrite) { }
    public Rss20ItemFormatter(TSyndicationItem itemToWrite, bool serializeExtensionsAsAtom) { }
    protected override System.ServiceModel.Syndication.SyndicationItem CreateItemInstance() { return default(System.ServiceModel.Syndication.SyndicationItem); }
  }
  public partial class ServiceDocument {
    public ServiceDocument() { }
    public ServiceDocument(System.Collections.Generic.IEnumerable<System.ServiceModel.Syndication.Workspace> workspaces) { }
    public System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.String> AttributeExtensions { get { return default(System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.String>); } }
    public System.Uri BaseUri { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Uri); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.ServiceModel.Syndication.SyndicationElementExtensionCollection ElementExtensions { get { return default(System.ServiceModel.Syndication.SyndicationElementExtensionCollection); } }
    public string Language { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Syndication.Workspace> Workspaces { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Syndication.Workspace>); } }
    protected internal virtual System.ServiceModel.Syndication.Workspace CreateWorkspace() { return default(System.ServiceModel.Syndication.Workspace); }
    public System.ServiceModel.Syndication.ServiceDocumentFormatter GetFormatter() { return default(System.ServiceModel.Syndication.ServiceDocumentFormatter); }
    public static System.ServiceModel.Syndication.ServiceDocument Load(System.Xml.XmlReader reader) { return default(System.ServiceModel.Syndication.ServiceDocument); }
    public static TServiceDocument Load<TServiceDocument>(System.Xml.XmlReader reader) where TServiceDocument : System.ServiceModel.Syndication.ServiceDocument, new() { return default(TServiceDocument); }
    public void Save(System.Xml.XmlWriter writer) { }
    protected internal virtual bool TryParseAttribute(string name, string ns, string value, string version) { return default(bool); }
    protected internal virtual bool TryParseElement(System.Xml.XmlReader reader, string version) { return default(bool); }
    protected internal virtual void WriteAttributeExtensions(System.Xml.XmlWriter writer, string version) { }
    protected internal virtual void WriteElementExtensions(System.Xml.XmlWriter writer, string version) { }
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public abstract partial class ServiceDocumentFormatter {
    protected ServiceDocumentFormatter() { }
    protected ServiceDocumentFormatter(System.ServiceModel.Syndication.ServiceDocument documentToWrite) { }
    public System.ServiceModel.Syndication.ServiceDocument Document { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Syndication.ServiceDocument); } }
    public abstract string Version { get; }
    public abstract bool CanRead(System.Xml.XmlReader reader);
    protected static System.ServiceModel.Syndication.SyndicationCategory CreateCategory(System.ServiceModel.Syndication.InlineCategoriesDocument inlineCategories) { return default(System.ServiceModel.Syndication.SyndicationCategory); }
    protected static System.ServiceModel.Syndication.ResourceCollectionInfo CreateCollection(System.ServiceModel.Syndication.Workspace workspace) { return default(System.ServiceModel.Syndication.ResourceCollectionInfo); }
    protected virtual System.ServiceModel.Syndication.ServiceDocument CreateDocumentInstance() { return default(System.ServiceModel.Syndication.ServiceDocument); }
    protected static System.ServiceModel.Syndication.InlineCategoriesDocument CreateInlineCategories(System.ServiceModel.Syndication.ResourceCollectionInfo collection) { return default(System.ServiceModel.Syndication.InlineCategoriesDocument); }
    protected static System.ServiceModel.Syndication.ReferencedCategoriesDocument CreateReferencedCategories(System.ServiceModel.Syndication.ResourceCollectionInfo collection) { return default(System.ServiceModel.Syndication.ReferencedCategoriesDocument); }
    protected static System.ServiceModel.Syndication.Workspace CreateWorkspace(System.ServiceModel.Syndication.ServiceDocument document) { return default(System.ServiceModel.Syndication.Workspace); }
    [System.MonoTODOAttribute("Use maxExtensionSize somewhere")]
    protected static void LoadElementExtensions(System.Xml.XmlReader reader, System.ServiceModel.Syndication.CategoriesDocument categories, int maxExtensionSize) { }
    [System.MonoTODOAttribute("Use maxExtensionSize somewhere")]
    protected static void LoadElementExtensions(System.Xml.XmlReader reader, System.ServiceModel.Syndication.ResourceCollectionInfo collection, int maxExtensionSize) { }
    [System.MonoTODOAttribute("Use maxExtensionSize somewhere")]
    protected static void LoadElementExtensions(System.Xml.XmlReader reader, System.ServiceModel.Syndication.ServiceDocument document, int maxExtensionSize) { }
    [System.MonoTODOAttribute("Use maxExtensionSize somewhere")]
    protected static void LoadElementExtensions(System.Xml.XmlReader reader, System.ServiceModel.Syndication.Workspace workspace, int maxExtensionSize) { }
    public abstract void ReadFrom(System.Xml.XmlReader reader);
    protected virtual void SetDocument(System.ServiceModel.Syndication.ServiceDocument document) { }
    protected static bool TryParseAttribute(string name, string ns, string value, System.ServiceModel.Syndication.CategoriesDocument categories, string version) { return default(bool); }
    protected static bool TryParseAttribute(string name, string ns, string value, System.ServiceModel.Syndication.ResourceCollectionInfo collection, string version) { return default(bool); }
    protected static bool TryParseAttribute(string name, string ns, string value, System.ServiceModel.Syndication.ServiceDocument document, string version) { return default(bool); }
    protected static bool TryParseAttribute(string name, string ns, string value, System.ServiceModel.Syndication.Workspace workspace, string version) { return default(bool); }
    protected static bool TryParseElement(System.Xml.XmlReader reader, System.ServiceModel.Syndication.CategoriesDocument categories, string version) { return default(bool); }
    protected static bool TryParseElement(System.Xml.XmlReader reader, System.ServiceModel.Syndication.ResourceCollectionInfo collection, string version) { return default(bool); }
    protected static bool TryParseElement(System.Xml.XmlReader reader, System.ServiceModel.Syndication.ServiceDocument document, string version) { return default(bool); }
    protected static bool TryParseElement(System.Xml.XmlReader reader, System.ServiceModel.Syndication.Workspace workspace, string version) { return default(bool); }
    protected static void WriteAttributeExtensions(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.CategoriesDocument categories, string version) { }
    protected static void WriteAttributeExtensions(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.ResourceCollectionInfo collection, string version) { }
    protected static void WriteAttributeExtensions(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.ServiceDocument document, string version) { }
    protected static void WriteAttributeExtensions(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.Workspace workspace, string version) { }
    protected static void WriteElementExtensions(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.CategoriesDocument categories, string version) { }
    protected static void WriteElementExtensions(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.ResourceCollectionInfo collection, string version) { }
    protected static void WriteElementExtensions(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.ServiceDocument document, string version) { }
    protected static void WriteElementExtensions(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.Workspace workspace, string version) { }
    public abstract void WriteTo(System.Xml.XmlWriter writer);
  }
  public partial class SyndicationCategory {
    public SyndicationCategory() { }
    protected SyndicationCategory(System.ServiceModel.Syndication.SyndicationCategory source) { }
    public SyndicationCategory(string name) { }
    public SyndicationCategory(string name, string scheme, string label) { }
    public System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.String> AttributeExtensions { get { return default(System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.String>); } }
    public System.ServiceModel.Syndication.SyndicationElementExtensionCollection ElementExtensions { get { return default(System.ServiceModel.Syndication.SyndicationElementExtensionCollection); } }
    public string Label { get { return default(string); } set { } }
    public string Name { get { return default(string); } set { } }
    public string Scheme { get { return default(string); } set { } }
    public virtual System.ServiceModel.Syndication.SyndicationCategory Clone() { return default(System.ServiceModel.Syndication.SyndicationCategory); }
    protected internal virtual bool TryParseAttribute(string name, string ns, string value, string version) { return default(bool); }
    protected internal virtual bool TryParseElement(System.Xml.XmlReader reader, string version) { return default(bool); }
    protected internal virtual void WriteAttributeExtensions(System.Xml.XmlWriter writer, string version) { }
    protected internal virtual void WriteElementExtensions(System.Xml.XmlWriter writer, string version) { }
  }
  public abstract partial class SyndicationContent {
    protected SyndicationContent() { }
    protected SyndicationContent(System.ServiceModel.Syndication.SyndicationContent source) { }
    public System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.String> AttributeExtensions { get { return default(System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.String>); } }
    public abstract string Type { get; }
    public abstract System.ServiceModel.Syndication.SyndicationContent Clone();
    public static System.ServiceModel.Syndication.TextSyndicationContent CreateHtmlContent(string content) { return default(System.ServiceModel.Syndication.TextSyndicationContent); }
    public static System.ServiceModel.Syndication.TextSyndicationContent CreatePlaintextContent(string content) { return default(System.ServiceModel.Syndication.TextSyndicationContent); }
    public static System.ServiceModel.Syndication.UrlSyndicationContent CreateUrlContent(System.Uri url, string mediaType) { return default(System.ServiceModel.Syndication.UrlSyndicationContent); }
    public static System.ServiceModel.Syndication.TextSyndicationContent CreateXhtmlContent(string content) { return default(System.ServiceModel.Syndication.TextSyndicationContent); }
    public static System.ServiceModel.Syndication.XmlSyndicationContent CreateXmlContent(object dataContractObject) { return default(System.ServiceModel.Syndication.XmlSyndicationContent); }
    public static System.ServiceModel.Syndication.XmlSyndicationContent CreateXmlContent(object dataContractObject, System.Runtime.Serialization.XmlObjectSerializer dataContractSerializer) { return default(System.ServiceModel.Syndication.XmlSyndicationContent); }
    public static System.ServiceModel.Syndication.XmlSyndicationContent CreateXmlContent(object xmlSerializerObject, System.Xml.Serialization.XmlSerializer serializer) { return default(System.ServiceModel.Syndication.XmlSyndicationContent); }
    public static System.ServiceModel.Syndication.XmlSyndicationContent CreateXmlContent(System.Xml.XmlReader reader) { return default(System.ServiceModel.Syndication.XmlSyndicationContent); }
    protected abstract void WriteContentsTo(System.Xml.XmlWriter writer);
    public void WriteTo(System.Xml.XmlWriter writer, string outerElementName, string outerElementNamespace) { }
  }
  public partial class SyndicationElementExtension {
    public SyndicationElementExtension(object dataContractExtension) { }
    public SyndicationElementExtension(object dataContractExtension, System.Runtime.Serialization.XmlObjectSerializer dataContractSerializer) { }
    public SyndicationElementExtension(object xmlSerializerExtension, System.Xml.Serialization.XmlSerializer serializer) { }
    public SyndicationElementExtension(string outerName, string outerNamespace, object dataContractExtension) { }
    public SyndicationElementExtension(string outerName, string outerNamespace, object dataContractExtension, System.Runtime.Serialization.XmlObjectSerializer dataContractSerializer) { }
    public SyndicationElementExtension(System.Xml.XmlReader xmlReader) { }
    public string OuterName { get { return default(string); } }
    public string OuterNamespace { get { return default(string); } }
    public TExtension GetObject<TExtension>() { return default(TExtension); }
    public TExtension GetObject<TExtension>(System.Runtime.Serialization.XmlObjectSerializer serializer) { return default(TExtension); }
    public TExtension GetObject<TExtension>(System.Xml.Serialization.XmlSerializer serializer) { return default(TExtension); }
    public System.Xml.XmlReader GetReader() { return default(System.Xml.XmlReader); }
    public void WriteTo(System.Xml.XmlWriter writer) { }
  }
  public sealed partial class SyndicationElementExtensionCollection : System.Collections.ObjectModel.Collection<System.ServiceModel.Syndication.SyndicationElementExtension> {
    internal SyndicationElementExtensionCollection() { }
    public void Add(object extension) { }
    public void Add(object dataContractExtension, System.Runtime.Serialization.DataContractSerializer serializer) { }
    public void Add(object xmlSerializerExtension, System.Xml.Serialization.XmlSerializer serializer) { }
    public void Add(string outerName, string outerNamespace, object dataContractExtension) { }
    public void Add(string outerName, string outerNamespace, object dataContractExtension, System.Runtime.Serialization.XmlObjectSerializer dataContractSerializer) { }
    public void Add(System.Xml.XmlReader xmlReader) { }
    [System.MonoTODOAttribute("Find out what is expected here")]
    protected override void ClearItems() { }
    [System.MonoTODOAttribute]
    public System.Xml.XmlReader GetReaderAtElementExtensions() { return default(System.Xml.XmlReader); }
    protected override void InsertItem(int index, System.ServiceModel.Syndication.SyndicationElementExtension item) { }
    public System.Collections.ObjectModel.Collection<TExtension> ReadElementExtensions<TExtension>(string extensionName, string extensionNamespace) { return default(System.Collections.ObjectModel.Collection<TExtension>); }
    public System.Collections.ObjectModel.Collection<TExtension> ReadElementExtensions<TExtension>(string extensionName, string extensionNamespace, System.Runtime.Serialization.XmlObjectSerializer serializer) { return default(System.Collections.ObjectModel.Collection<TExtension>); }
    public System.Collections.ObjectModel.Collection<TExtension> ReadElementExtensions<TExtension>(string extensionName, string extensionNamespace, System.Xml.Serialization.XmlSerializer serializer) { return default(System.Collections.ObjectModel.Collection<TExtension>); }
    [System.MonoTODOAttribute("Find out what is expected here")]
    protected override void RemoveItem(int index) { }
    protected override void SetItem(int index, System.ServiceModel.Syndication.SyndicationElementExtension item) { }
  }
  public partial class SyndicationFeed {
    public SyndicationFeed() { }
    public SyndicationFeed(System.Collections.Generic.IEnumerable<System.ServiceModel.Syndication.SyndicationItem> items) { }
    protected SyndicationFeed(System.ServiceModel.Syndication.SyndicationFeed source, bool cloneItems) { }
    public SyndicationFeed(string title, string description, System.Uri feedAlternateLink) { }
    public SyndicationFeed(string title, string description, System.Uri feedAlternateLink, System.Collections.Generic.IEnumerable<System.ServiceModel.Syndication.SyndicationItem> items) { }
    public SyndicationFeed(string title, string description, System.Uri feedAlternateLink, string id, System.DateTimeOffset lastUpdatedTime) { }
    public SyndicationFeed(string title, string description, System.Uri feedAlternateLink, string id, System.DateTimeOffset lastUpdatedTime, System.Collections.Generic.IEnumerable<System.ServiceModel.Syndication.SyndicationItem> items) { }
    public System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.String> AttributeExtensions { get { return default(System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.String>); } }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Syndication.SyndicationPerson> Authors { get { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Syndication.SyndicationPerson>); } }
    public System.Uri BaseUri { get { return default(System.Uri); } set { } }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Syndication.SyndicationCategory> Categories { get { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Syndication.SyndicationCategory>); } }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Syndication.SyndicationPerson> Contributors { get { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Syndication.SyndicationPerson>); } }
    public System.ServiceModel.Syndication.TextSyndicationContent Copyright { get { return default(System.ServiceModel.Syndication.TextSyndicationContent); } set { } }
    public System.ServiceModel.Syndication.TextSyndicationContent Description { get { return default(System.ServiceModel.Syndication.TextSyndicationContent); } set { } }
    public System.ServiceModel.Syndication.SyndicationElementExtensionCollection ElementExtensions { get { return default(System.ServiceModel.Syndication.SyndicationElementExtensionCollection); } }
    public string Generator { get { return default(string); } set { } }
    public string Id { get { return default(string); } set { } }
    public System.Uri ImageUrl { get { return default(System.Uri); } set { } }
    public System.Collections.Generic.IEnumerable<System.ServiceModel.Syndication.SyndicationItem> Items { get { return default(System.Collections.Generic.IEnumerable<System.ServiceModel.Syndication.SyndicationItem>); } set { } }
    public string Language { get { return default(string); } set { } }
    public System.DateTimeOffset LastUpdatedTime { get { return default(System.DateTimeOffset); } set { } }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Syndication.SyndicationLink> Links { get { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Syndication.SyndicationLink>); } }
    public System.ServiceModel.Syndication.TextSyndicationContent Title { get { return default(System.ServiceModel.Syndication.TextSyndicationContent); } set { } }
    public virtual System.ServiceModel.Syndication.SyndicationFeed Clone(bool cloneItems) { return default(System.ServiceModel.Syndication.SyndicationFeed); }
    protected internal virtual System.ServiceModel.Syndication.SyndicationCategory CreateCategory() { return default(System.ServiceModel.Syndication.SyndicationCategory); }
    protected internal virtual System.ServiceModel.Syndication.SyndicationItem CreateItem() { return default(System.ServiceModel.Syndication.SyndicationItem); }
    protected internal virtual System.ServiceModel.Syndication.SyndicationLink CreateLink() { return default(System.ServiceModel.Syndication.SyndicationLink); }
    protected internal virtual System.ServiceModel.Syndication.SyndicationPerson CreatePerson() { return default(System.ServiceModel.Syndication.SyndicationPerson); }
    public System.ServiceModel.Syndication.Atom10FeedFormatter GetAtom10Formatter() { return default(System.ServiceModel.Syndication.Atom10FeedFormatter); }
    public System.ServiceModel.Syndication.Rss20FeedFormatter GetRss20Formatter() { return default(System.ServiceModel.Syndication.Rss20FeedFormatter); }
    public System.ServiceModel.Syndication.Rss20FeedFormatter GetRss20Formatter(bool serializeExtensionsAsAtom) { return default(System.ServiceModel.Syndication.Rss20FeedFormatter); }
    public static System.ServiceModel.Syndication.SyndicationFeed Load(System.Xml.XmlReader reader) { return default(System.ServiceModel.Syndication.SyndicationFeed); }
    public static TSyndicationFeed Load<TSyndicationFeed>(System.Xml.XmlReader reader) where TSyndicationFeed : System.ServiceModel.Syndication.SyndicationFeed, new() { return default(TSyndicationFeed); }
    public void SaveAsAtom10(System.Xml.XmlWriter writer) { }
    public void SaveAsRss20(System.Xml.XmlWriter writer) { }
    protected internal virtual bool TryParseAttribute(string name, string ns, string value, string version) { return default(bool); }
    protected internal virtual bool TryParseElement(System.Xml.XmlReader reader, string version) { return default(bool); }
    protected internal virtual void WriteAttributeExtensions(System.Xml.XmlWriter writer, string version) { }
    protected internal virtual void WriteElementExtensions(System.Xml.XmlWriter writer, string version) { }
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public abstract partial class SyndicationFeedFormatter {
    protected SyndicationFeedFormatter() { }
    protected SyndicationFeedFormatter(System.ServiceModel.Syndication.SyndicationFeed feedToWrite) { }
    public System.ServiceModel.Syndication.SyndicationFeed Feed { get { return default(System.ServiceModel.Syndication.SyndicationFeed); } }
    public abstract string Version { get; }
    public abstract bool CanRead(System.Xml.XmlReader reader);
    protected internal static System.ServiceModel.Syndication.SyndicationCategory CreateCategory(System.ServiceModel.Syndication.SyndicationFeed feed) { return default(System.ServiceModel.Syndication.SyndicationCategory); }
    protected internal static System.ServiceModel.Syndication.SyndicationCategory CreateCategory(System.ServiceModel.Syndication.SyndicationItem item) { return default(System.ServiceModel.Syndication.SyndicationCategory); }
    protected abstract System.ServiceModel.Syndication.SyndicationFeed CreateFeedInstance();
    protected internal static System.ServiceModel.Syndication.SyndicationItem CreateItem(System.ServiceModel.Syndication.SyndicationFeed feed) { return default(System.ServiceModel.Syndication.SyndicationItem); }
    protected internal static System.ServiceModel.Syndication.SyndicationLink CreateLink(System.ServiceModel.Syndication.SyndicationFeed feed) { return default(System.ServiceModel.Syndication.SyndicationLink); }
    protected internal static System.ServiceModel.Syndication.SyndicationLink CreateLink(System.ServiceModel.Syndication.SyndicationItem item) { return default(System.ServiceModel.Syndication.SyndicationLink); }
    protected internal static System.ServiceModel.Syndication.SyndicationPerson CreatePerson(System.ServiceModel.Syndication.SyndicationFeed feed) { return default(System.ServiceModel.Syndication.SyndicationPerson); }
    protected internal static System.ServiceModel.Syndication.SyndicationPerson CreatePerson(System.ServiceModel.Syndication.SyndicationItem item) { return default(System.ServiceModel.Syndication.SyndicationPerson); }
    [System.MonoTODOAttribute("use maxExtensionsSize parameter")]
    protected internal static void LoadElementExtensions(System.Xml.XmlReader reader, System.ServiceModel.Syndication.SyndicationCategory category, int maxExtensionSize) { }
    [System.MonoTODOAttribute("use maxExtensionsSize parameter")]
    protected internal static void LoadElementExtensions(System.Xml.XmlReader reader, System.ServiceModel.Syndication.SyndicationFeed feed, int maxExtensionSize) { }
    [System.MonoTODOAttribute("use maxExtensionsSize parameter")]
    protected internal static void LoadElementExtensions(System.Xml.XmlReader reader, System.ServiceModel.Syndication.SyndicationItem item, int maxExtensionSize) { }
    [System.MonoTODOAttribute("use maxExtensionsSize parameter")]
    protected internal static void LoadElementExtensions(System.Xml.XmlReader reader, System.ServiceModel.Syndication.SyndicationLink link, int maxExtensionSize) { }
    [System.MonoTODOAttribute("use maxExtensionsSize parameter")]
    protected internal static void LoadElementExtensions(System.Xml.XmlReader reader, System.ServiceModel.Syndication.SyndicationPerson person, int maxExtensionSize) { }
    public abstract void ReadFrom(System.Xml.XmlReader reader);
    protected internal virtual void SetFeed(System.ServiceModel.Syndication.SyndicationFeed feed) { }
    public override string ToString() { return default(string); }
    protected internal static bool TryParseAttribute(string name, string ns, string value, System.ServiceModel.Syndication.SyndicationCategory category, string version) { return default(bool); }
    protected internal static bool TryParseAttribute(string name, string ns, string value, System.ServiceModel.Syndication.SyndicationFeed feed, string version) { return default(bool); }
    protected internal static bool TryParseAttribute(string name, string ns, string value, System.ServiceModel.Syndication.SyndicationItem item, string version) { return default(bool); }
    protected internal static bool TryParseAttribute(string name, string ns, string value, System.ServiceModel.Syndication.SyndicationLink link, string version) { return default(bool); }
    protected internal static bool TryParseAttribute(string name, string ns, string value, System.ServiceModel.Syndication.SyndicationPerson person, string version) { return default(bool); }
    protected internal static bool TryParseContent(System.Xml.XmlReader reader, System.ServiceModel.Syndication.SyndicationItem item, string contentType, string version, out System.ServiceModel.Syndication.SyndicationContent content) { content = default(System.ServiceModel.Syndication.SyndicationContent); return default(bool); }
    protected internal static bool TryParseElement(System.Xml.XmlReader reader, System.ServiceModel.Syndication.SyndicationCategory category, string version) { return default(bool); }
    protected internal static bool TryParseElement(System.Xml.XmlReader reader, System.ServiceModel.Syndication.SyndicationFeed feed, string version) { return default(bool); }
    protected internal static bool TryParseElement(System.Xml.XmlReader reader, System.ServiceModel.Syndication.SyndicationItem item, string version) { return default(bool); }
    protected internal static bool TryParseElement(System.Xml.XmlReader reader, System.ServiceModel.Syndication.SyndicationLink link, string version) { return default(bool); }
    protected internal static bool TryParseElement(System.Xml.XmlReader reader, System.ServiceModel.Syndication.SyndicationPerson person, string version) { return default(bool); }
    protected internal static void WriteAttributeExtensions(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.SyndicationCategory category, string version) { }
    protected internal static void WriteAttributeExtensions(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.SyndicationFeed feed, string version) { }
    protected internal static void WriteAttributeExtensions(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.SyndicationItem item, string version) { }
    protected internal static void WriteAttributeExtensions(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.SyndicationLink link, string version) { }
    protected internal static void WriteAttributeExtensions(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.SyndicationPerson person, string version) { }
    protected internal static void WriteElementExtensions(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.SyndicationCategory category, string version) { }
    protected internal static void WriteElementExtensions(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.SyndicationFeed feed, string version) { }
    protected internal static void WriteElementExtensions(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.SyndicationItem item, string version) { }
    protected internal static void WriteElementExtensions(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.SyndicationLink link, string version) { }
    protected internal static void WriteElementExtensions(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.SyndicationPerson person, string version) { }
    public abstract void WriteTo(System.Xml.XmlWriter writer);
  }
  public partial class SyndicationItem {
    public SyndicationItem() { }
    protected SyndicationItem(System.ServiceModel.Syndication.SyndicationItem source) { }
    public SyndicationItem(string title, System.ServiceModel.Syndication.SyndicationContent content, System.Uri feedAlternateLink, string id, System.DateTimeOffset lastUpdatedTime) { }
    public SyndicationItem(string title, string content, System.Uri feedAlternateLink) { }
    public SyndicationItem(string title, string content, System.Uri feedAlternateLink, string id, System.DateTimeOffset lastUpdatedTime) { }
    public System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.String> AttributeExtensions { get { return default(System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.String>); } }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Syndication.SyndicationPerson> Authors { get { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Syndication.SyndicationPerson>); } }
    public System.Uri BaseUri { get { return default(System.Uri); } set { } }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Syndication.SyndicationCategory> Categories { get { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Syndication.SyndicationCategory>); } }
    public System.ServiceModel.Syndication.SyndicationContent Content { get { return default(System.ServiceModel.Syndication.SyndicationContent); } set { } }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Syndication.SyndicationPerson> Contributors { get { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Syndication.SyndicationPerson>); } }
    public System.ServiceModel.Syndication.TextSyndicationContent Copyright { get { return default(System.ServiceModel.Syndication.TextSyndicationContent); } set { } }
    public System.ServiceModel.Syndication.SyndicationElementExtensionCollection ElementExtensions { get { return default(System.ServiceModel.Syndication.SyndicationElementExtensionCollection); } }
    public string Id { get { return default(string); } set { } }
    public System.DateTimeOffset LastUpdatedTime { get { return default(System.DateTimeOffset); } set { } }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Syndication.SyndicationLink> Links { get { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Syndication.SyndicationLink>); } }
    public System.DateTimeOffset PublishDate { get { return default(System.DateTimeOffset); } set { } }
    public System.ServiceModel.Syndication.SyndicationFeed SourceFeed { get { return default(System.ServiceModel.Syndication.SyndicationFeed); } set { } }
    public System.ServiceModel.Syndication.TextSyndicationContent Summary { get { return default(System.ServiceModel.Syndication.TextSyndicationContent); } set { } }
    public System.ServiceModel.Syndication.TextSyndicationContent Title { get { return default(System.ServiceModel.Syndication.TextSyndicationContent); } set { } }
    public void AddPermalink(System.Uri link) { }
    public virtual System.ServiceModel.Syndication.SyndicationItem Clone() { return default(System.ServiceModel.Syndication.SyndicationItem); }
    protected internal virtual System.ServiceModel.Syndication.SyndicationCategory CreateCategory() { return default(System.ServiceModel.Syndication.SyndicationCategory); }
    protected internal virtual System.ServiceModel.Syndication.SyndicationLink CreateLink() { return default(System.ServiceModel.Syndication.SyndicationLink); }
    protected internal virtual System.ServiceModel.Syndication.SyndicationPerson CreatePerson() { return default(System.ServiceModel.Syndication.SyndicationPerson); }
    public System.ServiceModel.Syndication.Atom10ItemFormatter GetAtom10Formatter() { return default(System.ServiceModel.Syndication.Atom10ItemFormatter); }
    public System.ServiceModel.Syndication.Rss20ItemFormatter GetRss20Formatter() { return default(System.ServiceModel.Syndication.Rss20ItemFormatter); }
    public System.ServiceModel.Syndication.Rss20ItemFormatter GetRss20Formatter(bool serializeExtensionsAsAtom) { return default(System.ServiceModel.Syndication.Rss20ItemFormatter); }
    public static System.ServiceModel.Syndication.SyndicationItem Load(System.Xml.XmlReader reader) { return default(System.ServiceModel.Syndication.SyndicationItem); }
    public static TSyndicationItem Load<TSyndicationItem>(System.Xml.XmlReader reader) where TSyndicationItem : System.ServiceModel.Syndication.SyndicationItem, new() { return default(TSyndicationItem); }
    public void SaveAsAtom10(System.Xml.XmlWriter writer) { }
    public void SaveAsRss20(System.Xml.XmlWriter writer) { }
    protected internal virtual bool TryParseAttribute(string name, string ns, string value, string version) { return default(bool); }
    protected internal virtual bool TryParseContent(System.Xml.XmlReader reader, string contentType, string version, out System.ServiceModel.Syndication.SyndicationContent content) { content = default(System.ServiceModel.Syndication.SyndicationContent); return default(bool); }
    protected internal virtual bool TryParseElement(System.Xml.XmlReader reader, string version) { return default(bool); }
    protected internal virtual void WriteAttributeExtensions(System.Xml.XmlWriter writer, string version) { }
    protected internal virtual void WriteElementExtensions(System.Xml.XmlWriter writer, string version) { }
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public abstract partial class SyndicationItemFormatter {
    protected SyndicationItemFormatter() { }
    protected SyndicationItemFormatter(System.ServiceModel.Syndication.SyndicationItem itemToWrite) { }
    public System.ServiceModel.Syndication.SyndicationItem Item { get { return default(System.ServiceModel.Syndication.SyndicationItem); } }
    public abstract string Version { get; }
    public abstract bool CanRead(System.Xml.XmlReader reader);
    protected internal static System.ServiceModel.Syndication.SyndicationCategory CreateCategory(System.ServiceModel.Syndication.SyndicationItem item) { return default(System.ServiceModel.Syndication.SyndicationCategory); }
    protected abstract System.ServiceModel.Syndication.SyndicationItem CreateItemInstance();
    protected internal static System.ServiceModel.Syndication.SyndicationLink CreateLink(System.ServiceModel.Syndication.SyndicationItem item) { return default(System.ServiceModel.Syndication.SyndicationLink); }
    protected internal static System.ServiceModel.Syndication.SyndicationPerson CreatePerson(System.ServiceModel.Syndication.SyndicationItem item) { return default(System.ServiceModel.Syndication.SyndicationPerson); }
    [System.MonoTODOAttribute("use maxExtensionsSize parameter")]
    protected internal static void LoadElementExtensions(System.Xml.XmlReader reader, System.ServiceModel.Syndication.SyndicationCategory category, int maxExtensionSize) { }
    [System.MonoTODOAttribute("use maxExtensionsSize parameter")]
    protected internal static void LoadElementExtensions(System.Xml.XmlReader reader, System.ServiceModel.Syndication.SyndicationItem item, int maxExtensionSize) { }
    [System.MonoTODOAttribute("use maxExtensionsSize parameter")]
    protected internal static void LoadElementExtensions(System.Xml.XmlReader reader, System.ServiceModel.Syndication.SyndicationLink link, int maxExtensionSize) { }
    [System.MonoTODOAttribute("use maxExtensionsSize parameter")]
    protected internal static void LoadElementExtensions(System.Xml.XmlReader reader, System.ServiceModel.Syndication.SyndicationPerson person, int maxExtensionSize) { }
    public abstract void ReadFrom(System.Xml.XmlReader reader);
    protected internal virtual void SetItem(System.ServiceModel.Syndication.SyndicationItem item) { }
    public override string ToString() { return default(string); }
    protected internal static bool TryParseAttribute(string name, string ns, string value, System.ServiceModel.Syndication.SyndicationCategory category, string version) { return default(bool); }
    protected internal static bool TryParseAttribute(string name, string ns, string value, System.ServiceModel.Syndication.SyndicationItem item, string version) { return default(bool); }
    protected internal static bool TryParseAttribute(string name, string ns, string value, System.ServiceModel.Syndication.SyndicationLink link, string version) { return default(bool); }
    protected internal static bool TryParseAttribute(string name, string ns, string value, System.ServiceModel.Syndication.SyndicationPerson person, string version) { return default(bool); }
    protected internal static bool TryParseContent(System.Xml.XmlReader reader, System.ServiceModel.Syndication.SyndicationItem item, string contentType, string version, out System.ServiceModel.Syndication.SyndicationContent content) { content = default(System.ServiceModel.Syndication.SyndicationContent); return default(bool); }
    protected internal static bool TryParseElement(System.Xml.XmlReader reader, System.ServiceModel.Syndication.SyndicationCategory category, string version) { return default(bool); }
    protected internal static bool TryParseElement(System.Xml.XmlReader reader, System.ServiceModel.Syndication.SyndicationItem item, string version) { return default(bool); }
    protected internal static bool TryParseElement(System.Xml.XmlReader reader, System.ServiceModel.Syndication.SyndicationLink link, string version) { return default(bool); }
    protected internal static bool TryParseElement(System.Xml.XmlReader reader, System.ServiceModel.Syndication.SyndicationPerson person, string version) { return default(bool); }
    protected internal static void WriteAttributeExtensions(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.SyndicationCategory category, string version) { }
    protected internal static void WriteAttributeExtensions(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.SyndicationItem item, string version) { }
    protected internal static void WriteAttributeExtensions(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.SyndicationLink link, string version) { }
    protected internal static void WriteAttributeExtensions(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.SyndicationPerson person, string version) { }
    protected internal void WriteElementExtensions(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.SyndicationCategory category, string version) { }
    protected internal static void WriteElementExtensions(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.SyndicationItem item, string version) { }
    protected internal void WriteElementExtensions(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.SyndicationLink link, string version) { }
    protected internal void WriteElementExtensions(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.SyndicationPerson person, string version) { }
    public abstract void WriteTo(System.Xml.XmlWriter writer);
  }
  public partial class SyndicationLink {
    public SyndicationLink() { }
    protected SyndicationLink(System.ServiceModel.Syndication.SyndicationLink source) { }
    public SyndicationLink(System.Uri uri) { }
    public SyndicationLink(System.Uri uri, string relationshipType, string title, string mediaType, long length) { }
    public System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.String> AttributeExtensions { get { return default(System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.String>); } }
    public System.Uri BaseUri { get { return default(System.Uri); } set { } }
    public System.ServiceModel.Syndication.SyndicationElementExtensionCollection ElementExtensions { get { return default(System.ServiceModel.Syndication.SyndicationElementExtensionCollection); } }
    public long Length { get { return default(long); } set { } }
    public string MediaType { get { return default(string); } set { } }
    public string RelationshipType { get { return default(string); } set { } }
    public string Title { get { return default(string); } set { } }
    public System.Uri Uri { get { return default(System.Uri); } set { } }
    public virtual System.ServiceModel.Syndication.SyndicationLink Clone() { return default(System.ServiceModel.Syndication.SyndicationLink); }
    public static System.ServiceModel.Syndication.SyndicationLink CreateAlternateLink(System.Uri uri) { return default(System.ServiceModel.Syndication.SyndicationLink); }
    public static System.ServiceModel.Syndication.SyndicationLink CreateAlternateLink(System.Uri uri, string mediaType) { return default(System.ServiceModel.Syndication.SyndicationLink); }
    public static System.ServiceModel.Syndication.SyndicationLink CreateMediaEnclosureLink(System.Uri uri, string mediaType, long length) { return default(System.ServiceModel.Syndication.SyndicationLink); }
    public static System.ServiceModel.Syndication.SyndicationLink CreateSelfLink(System.Uri uri) { return default(System.ServiceModel.Syndication.SyndicationLink); }
    public static System.ServiceModel.Syndication.SyndicationLink CreateSelfLink(System.Uri uri, string mediaType) { return default(System.ServiceModel.Syndication.SyndicationLink); }
    public System.Uri GetAbsoluteUri() { return default(System.Uri); }
    protected internal virtual bool TryParseAttribute(string name, string ns, string value, string version) { return default(bool); }
    protected internal virtual bool TryParseElement(System.Xml.XmlReader reader, string version) { return default(bool); }
    protected internal virtual void WriteAttributeExtensions(System.Xml.XmlWriter writer, string version) { }
    protected internal virtual void WriteElementExtensions(System.Xml.XmlWriter writer, string version) { }
  }
  public partial class SyndicationPerson {
    public SyndicationPerson() { }
    protected SyndicationPerson(System.ServiceModel.Syndication.SyndicationPerson source) { }
    public SyndicationPerson(string email) { }
    public SyndicationPerson(string email, string name, string uri) { }
    public System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.String> AttributeExtensions { get { return default(System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.String>); } }
    public System.ServiceModel.Syndication.SyndicationElementExtensionCollection ElementExtensions { get { return default(System.ServiceModel.Syndication.SyndicationElementExtensionCollection); } }
    public string Email { get { return default(string); } set { } }
    public string Name { get { return default(string); } set { } }
    public string Uri { get { return default(string); } set { } }
    public virtual System.ServiceModel.Syndication.SyndicationPerson Clone() { return default(System.ServiceModel.Syndication.SyndicationPerson); }
    protected internal virtual bool TryParseAttribute(string name, string ns, string value, string version) { return default(bool); }
    protected internal virtual bool TryParseElement(System.Xml.XmlReader reader, string version) { return default(bool); }
    protected internal virtual void WriteAttributeExtensions(System.Xml.XmlWriter writer, string version) { }
    protected internal virtual void WriteElementExtensions(System.Xml.XmlWriter writer, string version) { }
  }
  public static partial class SyndicationVersions {
    public const string Atom10 = "Atom10";
    public const string Rss20 = "Rss20";
  }
  public partial class TextSyndicationContent : System.ServiceModel.Syndication.SyndicationContent {
    protected TextSyndicationContent(System.ServiceModel.Syndication.TextSyndicationContent source) { }
    public TextSyndicationContent(string text) { }
    public TextSyndicationContent(string text, System.ServiceModel.Syndication.TextSyndicationContentKind textKind) { }
    public string Text { get { return default(string); } }
    public override string Type { get { return default(string); } }
    public override System.ServiceModel.Syndication.SyndicationContent Clone() { return default(System.ServiceModel.Syndication.SyndicationContent); }
    protected override void WriteContentsTo(System.Xml.XmlWriter writer) { }
  }
  public enum TextSyndicationContentKind {
    Html = 1,
    Plaintext = 0,
    XHtml = 2,
  }
  public partial class UrlSyndicationContent : System.ServiceModel.Syndication.SyndicationContent {
    protected UrlSyndicationContent(System.ServiceModel.Syndication.UrlSyndicationContent source) { }
    public UrlSyndicationContent(System.Uri url, string mediaType) { }
    public override string Type { get { return default(string); } }
    public System.Uri Url { get { return default(System.Uri); } }
    public override System.ServiceModel.Syndication.SyndicationContent Clone() { return default(System.ServiceModel.Syndication.SyndicationContent); }
    protected override void WriteContentsTo(System.Xml.XmlWriter writer) { }
  }
  public partial class Workspace {
    public Workspace() { }
    public Workspace(System.ServiceModel.Syndication.TextSyndicationContent title, System.Collections.Generic.IEnumerable<System.ServiceModel.Syndication.ResourceCollectionInfo> collections) { }
    public Workspace(string title, System.Collections.Generic.IEnumerable<System.ServiceModel.Syndication.ResourceCollectionInfo> collections) { }
    public System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.String> AttributeExtensions { get { return default(System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.String>); } }
    public System.Uri BaseUri { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Uri); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Syndication.ResourceCollectionInfo> Collections { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Syndication.ResourceCollectionInfo>); } }
    public System.ServiceModel.Syndication.SyndicationElementExtensionCollection ElementExtensions { get { return default(System.ServiceModel.Syndication.SyndicationElementExtensionCollection); } }
    public System.ServiceModel.Syndication.TextSyndicationContent Title { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Syndication.TextSyndicationContent); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    protected internal virtual System.ServiceModel.Syndication.ResourceCollectionInfo CreateResourceCollection() { return default(System.ServiceModel.Syndication.ResourceCollectionInfo); }
    protected internal virtual bool TryParseAttribute(string name, string ns, string value, string version) { return default(bool); }
    protected internal virtual bool TryParseElement(System.Xml.XmlReader reader, string version) { return default(bool); }
    protected internal virtual void WriteAttributeExtensions(System.Xml.XmlWriter writer, string version) { }
    protected internal virtual void WriteElementExtensions(System.Xml.XmlWriter writer, string version) { }
  }
  public partial class XmlSyndicationContent : System.ServiceModel.Syndication.SyndicationContent {
    protected XmlSyndicationContent(System.ServiceModel.Syndication.XmlSyndicationContent source) { }
    public XmlSyndicationContent(string type, object dataContractExtension, System.Runtime.Serialization.XmlObjectSerializer dataContractSerializer) { }
    public XmlSyndicationContent(string type, object xmlSerializerExtension, System.Xml.Serialization.XmlSerializer serializer) { }
    public XmlSyndicationContent(string type, System.ServiceModel.Syndication.SyndicationElementExtension extension) { }
    public XmlSyndicationContent(System.Xml.XmlReader reader) { }
    public System.ServiceModel.Syndication.SyndicationElementExtension Extension { get { return default(System.ServiceModel.Syndication.SyndicationElementExtension); } }
    public override string Type { get { return default(string); } }
    public override System.ServiceModel.Syndication.SyndicationContent Clone() { return default(System.ServiceModel.Syndication.SyndicationContent); }
    public System.Xml.XmlDictionaryReader GetReaderAtContent() { return default(System.Xml.XmlDictionaryReader); }
    public TContent ReadContent<TContent>() { return default(TContent); }
    public TContent ReadContent<TContent>(System.Runtime.Serialization.XmlObjectSerializer serializer) { return default(TContent); }
    public TContent ReadContent<TContent>(System.Xml.Serialization.XmlSerializer serializer) { return default(TContent); }
    protected override void WriteContentsTo(System.Xml.XmlWriter writer) { }
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
    public void Detach(System.ServiceModel.OperationContext context) { }
  }
  public partial class WebServiceHost : System.ServiceModel.ServiceHost {
    public WebServiceHost() { }
    public WebServiceHost(object singletonInstance, params System.Uri[] baseAddresses) { }
    public WebServiceHost(System.Type serviceType, params System.Uri[] baseAddresses) { }
    protected override void OnOpening() { }
  }
}
