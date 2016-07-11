namespace RabbitMQ.Client {
  public partial class AmqpTcpEndpoint {
    public const int UseDefaultPort = -1;
    public AmqpTcpEndpoint() { }
    public AmqpTcpEndpoint(RabbitMQ.Client.IProtocol protocol) { }
    public AmqpTcpEndpoint(RabbitMQ.Client.IProtocol protocol, string hostName) { }
    public AmqpTcpEndpoint(RabbitMQ.Client.IProtocol protocol, string hostName, int portOrMinusOne) { }
    public AmqpTcpEndpoint(RabbitMQ.Client.IProtocol protocol, string hostName, int portOrMinusOne, RabbitMQ.Client.SslOption ssl) { }
    public AmqpTcpEndpoint(RabbitMQ.Client.IProtocol protocol, System.Uri uri) { }
    public AmqpTcpEndpoint(RabbitMQ.Client.IProtocol protocol, System.Uri uri, RabbitMQ.Client.SslOption ssl) { }
    public AmqpTcpEndpoint(string hostName) { }
    public AmqpTcpEndpoint(string hostName, int portOrMinusOne) { }
    public AmqpTcpEndpoint(System.Uri uri) { }
    public string HostName { get { return default(string); } set { } }
    public int Port { get { return default(int); } set { } }
    public RabbitMQ.Client.IProtocol Protocol { get { return default(RabbitMQ.Client.IProtocol); } set { } }
    public RabbitMQ.Client.SslOption Ssl { get { return default(RabbitMQ.Client.SslOption); } set { } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static RabbitMQ.Client.AmqpTcpEndpoint Parse(RabbitMQ.Client.IProtocol protocol, string address) { return default(RabbitMQ.Client.AmqpTcpEndpoint); }
    public static RabbitMQ.Client.AmqpTcpEndpoint[] ParseMultiple(RabbitMQ.Client.IProtocol protocol, string addresses) { return default(RabbitMQ.Client.AmqpTcpEndpoint[]); }
    public override string ToString() { return default(string); }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct AmqpTimestamp {
    public AmqpTimestamp(long unixTime) { throw new System.NotImplementedException(); }
    public long UnixTime { get { return default(long); } }
    public override string ToString() { return default(string); }
  }
  public partial class AmqpVersion {
    public AmqpVersion(int major, int minor) { }
    public int Major { get { return default(int); } }
    public int Minor { get { return default(int); } }
    public override bool Equals(object other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
  }
  public partial class BasicGetResult {
    public BasicGetResult(ulong deliveryTag, bool redelivered, string exchange, string routingKey, uint messageCount, RabbitMQ.Client.IBasicProperties basicProperties, System.Byte[] body) { }
    public RabbitMQ.Client.IBasicProperties BasicProperties { get { return default(RabbitMQ.Client.IBasicProperties); } }
    public System.Byte[] Body { get { return default(System.Byte[]); } }
    public ulong DeliveryTag { get { return default(ulong); } }
    public string Exchange { get { return default(string); } }
    public uint MessageCount { get { return default(uint); } }
    public bool Redelivered { get { return default(bool); } }
    public string RoutingKey { get { return default(string); } }
  }
  public partial class BinaryTableValue {
    public BinaryTableValue() { }
    public BinaryTableValue(System.Byte[] bytes) { }
    public System.Byte[] Bytes { get { return default(System.Byte[]); } set { } }
  }
  public partial class ConnectionFactory {
    public System.Collections.IDictionary ClientProperties;
    public const ushort DefaultChannelMax = (ushort)0;
    public const uint DefaultFrameMax = (uint)0;
    public const ushort DefaultHeartbeat = (ushort)0;
    public const string DefaultPass = "guest";
    public const string DefaultUser = "guest";
    public const string DefaultVHost = "/";
    public string HostName;
    public string Password;
    public int Port;
    public RabbitMQ.Client.IProtocol Protocol;
    public ushort RequestedChannelMax;
    public uint RequestedFrameMax;
    public ushort RequestedHeartbeat;
    public RabbitMQ.Client.SslOption Ssl;
    public string UserName;
    public string VirtualHost;
    public ConnectionFactory() { }
    public string Address { get { return default(string); } set { } }
    public RabbitMQ.Client.AmqpTcpEndpoint Endpoint { get { return default(RabbitMQ.Client.AmqpTcpEndpoint); } set { } }
    public virtual RabbitMQ.Client.IConnection CreateConnection() { return default(RabbitMQ.Client.IConnection); }
    public virtual RabbitMQ.Client.IConnection CreateConnection(int maxRedirects) { return default(RabbitMQ.Client.IConnection); }
    protected virtual RabbitMQ.Client.IConnection CreateConnection(int maxRedirects, System.Collections.IDictionary connectionAttempts, System.Collections.IDictionary connectionErrors, params RabbitMQ.Client.AmqpTcpEndpoint[] endpoints) { return default(RabbitMQ.Client.IConnection); }
    protected virtual RabbitMQ.Client.IConnection FollowRedirectChain(int maxRedirects, System.Collections.IDictionary connectionAttempts, System.Collections.IDictionary connectionErrors, ref RabbitMQ.Client.AmqpTcpEndpoint[] mostRecentKnownHosts, RabbitMQ.Client.AmqpTcpEndpoint endpoint) { return default(RabbitMQ.Client.IConnection); }
  }
  public partial class DefaultBasicConsumer : RabbitMQ.Client.IBasicConsumer {
    public DefaultBasicConsumer() { }
    public DefaultBasicConsumer(RabbitMQ.Client.IModel model) { }
    public string ConsumerTag { get { return default(string); } set { } }
    public bool IsRunning { get { return default(bool); } }
    public RabbitMQ.Client.IModel Model { get { return default(RabbitMQ.Client.IModel); } set { } }
    public RabbitMQ.Client.ShutdownEventArgs ShutdownReason { get { return default(RabbitMQ.Client.ShutdownEventArgs); } }
    public virtual void HandleBasicCancelOk(string consumerTag) { }
    public virtual void HandleBasicConsumeOk(string consumerTag) { }
    public virtual void HandleBasicDeliver(string consumerTag, ulong deliveryTag, bool redelivered, string exchange, string routingKey, RabbitMQ.Client.IBasicProperties properties, System.Byte[] body) { }
    public virtual void HandleModelShutdown(RabbitMQ.Client.IModel model, RabbitMQ.Client.ShutdownEventArgs reason) { }
    public virtual void OnCancel() { }
  }
  public partial class ExchangeType {
    internal ExchangeType() { }
    public const string Direct = "direct";
    public const string Fanout = "fanout";
    public const string Topic = "topic";
    public static System.Collections.ICollection All() { return default(System.Collections.ICollection); }
  }
  public partial interface IBasicConsumer {
    RabbitMQ.Client.IModel Model { get; }
    void HandleBasicCancelOk(string consumerTag);
    void HandleBasicConsumeOk(string consumerTag);
    void HandleBasicDeliver(string consumerTag, ulong deliveryTag, bool redelivered, string exchange, string routingKey, RabbitMQ.Client.IBasicProperties properties, System.Byte[] body);
    void HandleModelShutdown(RabbitMQ.Client.IModel model, RabbitMQ.Client.ShutdownEventArgs reason);
  }
  public partial interface IBasicProperties : RabbitMQ.Client.IContentHeader, System.ICloneable {
    string AppId { get; set; }
    string ClusterId { get; set; }
    string ContentEncoding { get; set; }
    string ContentType { get; set; }
    string CorrelationId { get; set; }
    byte DeliveryMode { get; set; }
    string Expiration { get; set; }
    System.Collections.IDictionary Headers { get; set; }
    string MessageId { get; set; }
    byte Priority { get; set; }
    string ReplyTo { get; set; }
    RabbitMQ.Client.PublicationAddress ReplyToAddress { get; set; }
    RabbitMQ.Client.AmqpTimestamp Timestamp { get; set; }
    string Type { get; set; }
    string UserId { get; set; }
    void ClearAppId();
    void ClearClusterId();
    void ClearContentEncoding();
    void ClearContentType();
    void ClearCorrelationId();
    void ClearDeliveryMode();
    void ClearExpiration();
    void ClearHeaders();
    void ClearMessageId();
    void ClearPriority();
    void ClearReplyTo();
    void ClearTimestamp();
    void ClearType();
    void ClearUserId();
    bool IsAppIdPresent();
    bool IsClusterIdPresent();
    bool IsContentEncodingPresent();
    bool IsContentTypePresent();
    bool IsCorrelationIdPresent();
    bool IsDeliveryModePresent();
    bool IsExpirationPresent();
    bool IsHeadersPresent();
    bool IsMessageIdPresent();
    bool IsPriorityPresent();
    bool IsReplyToPresent();
    bool IsTimestampPresent();
    bool IsTypePresent();
    bool IsUserIdPresent();
    void SetPersistent(bool persistent);
  }
  public partial interface IConnection : System.IDisposable {
    bool AutoClose { get; set; }
    ushort ChannelMax { get; }
    System.Collections.IDictionary ClientProperties { get; }
    RabbitMQ.Client.ShutdownEventArgs CloseReason { get; }
    RabbitMQ.Client.AmqpTcpEndpoint Endpoint { get; }
    uint FrameMax { get; }
    ushort Heartbeat { get; }
    bool IsOpen { get; }
    RabbitMQ.Client.AmqpTcpEndpoint[] KnownHosts { get; }
    RabbitMQ.Client.IProtocol Protocol { get; }
    System.Collections.IDictionary ServerProperties { get; }
    System.Collections.IList ShutdownReport { get; }
    event RabbitMQ.Client.Events.CallbackExceptionEventHandler CallbackException;
    event RabbitMQ.Client.Events.ConnectionShutdownEventHandler ConnectionShutdown;
    void Abort();
    void Abort(int timeout);
    void Abort(ushort reasonCode, string reasonText);
    void Abort(ushort reasonCode, string reasonText, int timeout);
    void Close();
    void Close(int timeout);
    void Close(ushort reasonCode, string reasonText);
    void Close(ushort reasonCode, string reasonText, int timeout);
    RabbitMQ.Client.IModel CreateModel();
  }
  public partial interface IContentHeader : System.ICloneable {
    int ProtocolClassId { get; }
    string ProtocolClassName { get; }
  }
  public partial interface IFileProperties : RabbitMQ.Client.IContentHeader, System.ICloneable {
    string ClusterId { get; set; }
    string ContentEncoding { get; set; }
    string ContentType { get; set; }
    string Filename { get; set; }
    System.Collections.IDictionary Headers { get; set; }
    string MessageId { get; set; }
    byte Priority { get; set; }
    string ReplyTo { get; set; }
    RabbitMQ.Client.AmqpTimestamp Timestamp { get; set; }
    void ClearClusterId();
    void ClearContentEncoding();
    void ClearContentType();
    void ClearFilename();
    void ClearHeaders();
    void ClearMessageId();
    void ClearPriority();
    void ClearReplyTo();
    void ClearTimestamp();
    bool IsClusterIdPresent();
    bool IsContentEncodingPresent();
    bool IsContentTypePresent();
    bool IsFilenamePresent();
    bool IsHeadersPresent();
    bool IsMessageIdPresent();
    bool IsPriorityPresent();
    bool IsReplyToPresent();
    bool IsTimestampPresent();
  }
  public partial interface IMethod {
    int ProtocolClassId { get; }
    int ProtocolMethodId { get; }
    string ProtocolMethodName { get; }
  }
  public partial interface IModel : System.IDisposable {
    RabbitMQ.Client.ShutdownEventArgs CloseReason { get; }
    bool IsOpen { get; }
    event RabbitMQ.Client.Events.BasicReturnEventHandler BasicReturn;
    event RabbitMQ.Client.Events.CallbackExceptionEventHandler CallbackException;
    event RabbitMQ.Client.Events.ModelShutdownEventHandler ModelShutdown;
    [RabbitMQ.Client.Apigen.Attributes.AmqpMethodDoNotImplementAttribute(null)]
    void Abort();
    [RabbitMQ.Client.Apigen.Attributes.AmqpMethodDoNotImplementAttribute(null)]
    void Abort(ushort replyCode, string replyText);
    void BasicAck(ulong deliveryTag, bool multiple);
    [RabbitMQ.Client.Apigen.Attributes.AmqpMethodDoNotImplementAttribute(null)]
    void BasicCancel(string consumerTag);
    [RabbitMQ.Client.Apigen.Attributes.AmqpMethodDoNotImplementAttribute(null)]
    string BasicConsume(string queue, bool noAck, System.Collections.IDictionary filter, RabbitMQ.Client.IBasicConsumer consumer);
    [RabbitMQ.Client.Apigen.Attributes.AmqpMethodDoNotImplementAttribute(null)]
    string BasicConsume(string queue, bool noAck, string consumerTag, bool noLocal, bool exclusive, System.Collections.IDictionary filter, RabbitMQ.Client.IBasicConsumer consumer);
    [RabbitMQ.Client.Apigen.Attributes.AmqpMethodDoNotImplementAttribute(null)]
    string BasicConsume(string queue, bool noAck, string consumerTag, System.Collections.IDictionary filter, RabbitMQ.Client.IBasicConsumer consumer);
    [RabbitMQ.Client.Apigen.Attributes.AmqpMethodDoNotImplementAttribute(null)]
    string BasicConsume(string queue, System.Collections.IDictionary filter, RabbitMQ.Client.IBasicConsumer consumer);
    [RabbitMQ.Client.Apigen.Attributes.AmqpMethodDoNotImplementAttribute(null)]
    RabbitMQ.Client.BasicGetResult BasicGet(string queue, bool noAck);
    [RabbitMQ.Client.Apigen.Attributes.AmqpMethodDoNotImplementAttribute(null)]
    void BasicPublish(RabbitMQ.Client.PublicationAddress addr, RabbitMQ.Client.IBasicProperties basicProperties, System.Byte[] body);
    [RabbitMQ.Client.Apigen.Attributes.AmqpMethodDoNotImplementAttribute(null)]
    void BasicPublish(string exchange, string routingKey, RabbitMQ.Client.IBasicProperties basicProperties, System.Byte[] body);
    [RabbitMQ.Client.Apigen.Attributes.AmqpMethodDoNotImplementAttribute(null)]
    void BasicPublish(string exchange, string routingKey, bool mandatory, bool immediate, RabbitMQ.Client.IBasicProperties basicProperties, System.Byte[] body);
    void BasicQos(uint prefetchSize, ushort prefetchCount, bool global);
    void BasicRecover(bool requeue);
    void BasicReject(ulong deliveryTag, bool requeue);
    [RabbitMQ.Client.Apigen.Attributes.AmqpFieldMappingAttribute(null, "active")]void ChannelFlow(bool active);
    [RabbitMQ.Client.Apigen.Attributes.AmqpMethodDoNotImplementAttribute(null)]
    void Close();
    [RabbitMQ.Client.Apigen.Attributes.AmqpMethodDoNotImplementAttribute(null)]
    void Close(ushort replyCode, string replyText);
    [RabbitMQ.Client.Apigen.Attributes.AmqpContentHeaderFactoryAttribute("basic")]
    RabbitMQ.Client.IBasicProperties CreateBasicProperties();
    [RabbitMQ.Client.Apigen.Attributes.AmqpContentHeaderFactoryAttribute("file")]
    RabbitMQ.Client.IFileProperties CreateFileProperties();
    [RabbitMQ.Client.Apigen.Attributes.AmqpContentHeaderFactoryAttribute("stream")]
    RabbitMQ.Client.IStreamProperties CreateStreamProperties();
    void DtxSelect();
    void DtxStart(string dtxIdentifier);
    [RabbitMQ.Client.Apigen.Attributes.AmqpMethodDoNotImplementAttribute(null)]
    void ExchangeDeclare(string exchange, string type);
    [RabbitMQ.Client.Apigen.Attributes.AmqpMethodDoNotImplementAttribute(null)]
    void ExchangeDeclare(string exchange, string type, bool durable);
    void ExchangeDeclare(string exchange, string type, bool passive, bool durable, bool autoDelete, bool @internal, [RabbitMQ.Client.Apigen.Attributes.AmqpNowaitArgumentAttribute(null)]bool nowait, System.Collections.IDictionary arguments);
    void ExchangeDelete(string exchange, bool ifUnused, [RabbitMQ.Client.Apigen.Attributes.AmqpNowaitArgumentAttribute(null)]bool nowait);
    void QueueBind(string queue, string exchange, string routingKey, [RabbitMQ.Client.Apigen.Attributes.AmqpNowaitArgumentAttribute(null)]bool nowait, System.Collections.IDictionary arguments);
    [RabbitMQ.Client.Apigen.Attributes.AmqpMethodDoNotImplementAttribute(null)]
    string QueueDeclare();
    [RabbitMQ.Client.Apigen.Attributes.AmqpMethodDoNotImplementAttribute(null)]
    string QueueDeclare(string queue);
    [RabbitMQ.Client.Apigen.Attributes.AmqpMethodDoNotImplementAttribute(null)]
    string QueueDeclare(string queue, bool durable);
    [RabbitMQ.Client.Apigen.Attributes.AmqpFieldMappingAttribute(null, "queue")]string QueueDeclare(string queue, bool passive, bool durable, bool exclusive, bool autoDelete, [RabbitMQ.Client.Apigen.Attributes.AmqpNowaitArgumentAttribute(null)]bool nowait, System.Collections.IDictionary arguments);
    [RabbitMQ.Client.Apigen.Attributes.AmqpFieldMappingAttribute(null, "messageCount")]uint QueueDelete(string queue, bool ifUnused, bool ifEmpty, [RabbitMQ.Client.Apigen.Attributes.AmqpNowaitArgumentAttribute(null, "0xFFFFFFFF")]bool nowait);
    [RabbitMQ.Client.Apigen.Attributes.AmqpFieldMappingAttribute(null, "messageCount")]uint QueuePurge(string queue, [RabbitMQ.Client.Apigen.Attributes.AmqpNowaitArgumentAttribute(null, "0xFFFFFFFF")]bool nowait);
    [RabbitMQ.Client.Apigen.Attributes.AmqpUnsupportedAttribute("RabbitMQ.Client.Framing.v0_8qpid")]
    void QueueUnbind(string queue, string exchange, string routingKey, System.Collections.IDictionary arguments);
    void TxCommit();
    void TxRollback();
    void TxSelect();
  }
  public partial interface IProtocol {
    string ApiName { get; }
    int DefaultPort { get; }
    int MajorVersion { get; }
    int MinorVersion { get; }
    RabbitMQ.Client.IConnection CreateConnection(RabbitMQ.Client.ConnectionFactory factory, bool insist, RabbitMQ.Client.Impl.IFrameHandler frameHandler);
    RabbitMQ.Client.Impl.IFrameHandler CreateFrameHandler(RabbitMQ.Client.AmqpTcpEndpoint endpoint);
    RabbitMQ.Client.IModel CreateModel(RabbitMQ.Client.Impl.ISession session);
  }
  public partial interface IStreamProperties : RabbitMQ.Client.IContentHeader, System.ICloneable {
    string ContentEncoding { get; set; }
    string ContentType { get; set; }
    System.Collections.IDictionary Headers { get; set; }
    byte Priority { get; set; }
    RabbitMQ.Client.AmqpTimestamp Timestamp { get; set; }
    void ClearContentEncoding();
    void ClearContentType();
    void ClearHeaders();
    void ClearPriority();
    void ClearTimestamp();
    bool IsContentEncodingPresent();
    bool IsContentTypePresent();
    bool IsHeadersPresent();
    bool IsPriorityPresent();
    bool IsTimestampPresent();
  }
  public partial class Protocols {
    internal Protocols() { }
    public static readonly string DefaultAppSettingsKey;
    public static readonly string EnvironmentVariable;
    public static RabbitMQ.Client.IProtocol AMQP_0_8 { get { return default(RabbitMQ.Client.IProtocol); } }
    public static RabbitMQ.Client.IProtocol AMQP_0_8_QPID { get { return default(RabbitMQ.Client.IProtocol); } }
    public static RabbitMQ.Client.IProtocol AMQP_0_9 { get { return default(RabbitMQ.Client.IProtocol); } }
    public static RabbitMQ.Client.IProtocol DefaultProtocol { get { return default(RabbitMQ.Client.IProtocol); } }
    public static RabbitMQ.Client.IProtocol FromConfiguration() { return default(RabbitMQ.Client.IProtocol); }
    public static RabbitMQ.Client.IProtocol FromConfiguration(string appSettingsKey) { return default(RabbitMQ.Client.IProtocol); }
    public static RabbitMQ.Client.IProtocol FromEnvironment() { return default(RabbitMQ.Client.IProtocol); }
    public static RabbitMQ.Client.IProtocol FromEnvironment(string appSettingsKey) { return default(RabbitMQ.Client.IProtocol); }
    public static RabbitMQ.Client.IProtocol FromEnvironmentVariable() { return default(RabbitMQ.Client.IProtocol); }
    public static RabbitMQ.Client.IProtocol Lookup(string name) { return default(RabbitMQ.Client.IProtocol); }
    public static RabbitMQ.Client.IProtocol SafeLookup(string name) { return default(RabbitMQ.Client.IProtocol); }
  }
  public partial class PublicationAddress {
    public static readonly System.Text.RegularExpressions.Regex PSEUDO_URI_PARSER;
    public PublicationAddress(string exchangeType, string exchangeName, string routingKey) { }
    public string ExchangeName { get { return default(string); } }
    public string ExchangeType { get { return default(string); } }
    public string RoutingKey { get { return default(string); } }
    public static RabbitMQ.Client.PublicationAddress Parse(string uriLikeString) { return default(RabbitMQ.Client.PublicationAddress); }
    public override string ToString() { return default(string); }
  }
  public partial class QueueingBasicConsumer : RabbitMQ.Client.DefaultBasicConsumer {
    protected RabbitMQ.Util.SharedQueue m_queue;
    public QueueingBasicConsumer() { }
    public QueueingBasicConsumer(RabbitMQ.Client.IModel model) { }
    public QueueingBasicConsumer(RabbitMQ.Client.IModel model, RabbitMQ.Util.SharedQueue queue) { }
    public RabbitMQ.Util.SharedQueue Queue { get { return default(RabbitMQ.Util.SharedQueue); } }
    public override void HandleBasicDeliver(string consumerTag, ulong deliveryTag, bool redelivered, string exchange, string routingKey, RabbitMQ.Client.IBasicProperties properties, System.Byte[] body) { }
    public override void OnCancel() { }
  }
  public partial class ShutdownEventArgs : System.EventArgs {
    public ShutdownEventArgs(RabbitMQ.Client.ShutdownInitiator initiator, ushort replyCode, string replyText) { }
    public ShutdownEventArgs(RabbitMQ.Client.ShutdownInitiator initiator, ushort replyCode, string replyText, object cause) { }
    public ShutdownEventArgs(RabbitMQ.Client.ShutdownInitiator initiator, ushort replyCode, string replyText, ushort classId, ushort methodId) { }
    public ShutdownEventArgs(RabbitMQ.Client.ShutdownInitiator initiator, ushort replyCode, string replyText, ushort classId, ushort methodId, object cause) { }
    public object Cause { get { return default(object); } }
    public ushort ClassId { get { return default(ushort); } }
    public RabbitMQ.Client.ShutdownInitiator Initiator { get { return default(RabbitMQ.Client.ShutdownInitiator); } }
    public ushort MethodId { get { return default(ushort); } }
    public ushort ReplyCode { get { return default(ushort); } }
    public string ReplyText { get { return default(string); } }
    public override string ToString() { return default(string); }
  }
  public enum ShutdownInitiator {
    Application = 0,
    Library = 1,
    Peer = 2,
  }
  public partial class ShutdownReportEntry {
    public string m_description;
    public System.Exception m_ex;
    public ShutdownReportEntry(string description, System.Exception ex) { }
    public string Description { get { return default(string); } }
    public System.Exception Exception { get { return default(System.Exception); } }
    public override string ToString() { return default(string); }
  }
  public partial class SslHelper {
    internal SslHelper() { }
    public static System.IO.Stream TcpUpgrade(System.IO.Stream tcpStream, RabbitMQ.Client.SslOption sslOption) { return default(System.IO.Stream); }
  }
  public partial class SslOption {
    public SslOption() { }
    public SslOption(string serverName) { }
    public SslOption(string serverName, string certPath, bool enabled) { }
    public System.Net.Security.SslPolicyErrors AcceptablePolicyErrors { get { return default(System.Net.Security.SslPolicyErrors); } set { } }
    public string CertPassphrase { get { return default(string); } set { } }
    public string CertPath { get { return default(string); } set { } }
    public System.Security.Cryptography.X509Certificates.X509CertificateCollection Certs { get { return default(System.Security.Cryptography.X509Certificates.X509CertificateCollection); } }
    public bool Enabled { get { return default(bool); } set { } }
    public string ServerName { get { return default(string); } set { } }
    public System.Security.Authentication.SslProtocols Version { get { return default(System.Security.Authentication.SslProtocols); } set { } }
  }
}
namespace RabbitMQ.Client.Apigen.Attributes {
  public abstract partial class AmqpApigenAttribute : System.Attribute {
    public string m_namespaceName;
    public AmqpApigenAttribute(string namespaceName) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
  public partial class AmqpAsynchronousHandlerAttribute : RabbitMQ.Client.Apigen.Attributes.AmqpApigenAttribute {
    public AmqpAsynchronousHandlerAttribute(string namespaceName) : base (default(string)) { }
  }
  public partial class AmqpContentBodyMappingAttribute : System.Attribute {
    public AmqpContentBodyMappingAttribute() { }
  }
  public partial class AmqpContentHeaderFactoryAttribute : System.Attribute {
    public string m_contentClass;
    public AmqpContentHeaderFactoryAttribute(string contentClass) { }
  }
  public partial class AmqpContentHeaderMappingAttribute : System.Attribute {
    public AmqpContentHeaderMappingAttribute() { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
  public partial class AmqpFieldMappingAttribute : RabbitMQ.Client.Apigen.Attributes.AmqpApigenAttribute {
    public string m_fieldName;
    public AmqpFieldMappingAttribute(string namespaceName, string fieldName) : base (default(string)) { }
  }
  public partial class AmqpForceOneWayAttribute : System.Attribute {
    public AmqpForceOneWayAttribute() { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
  public partial class AmqpMethodDoNotImplementAttribute : RabbitMQ.Client.Apigen.Attributes.AmqpApigenAttribute {
    public AmqpMethodDoNotImplementAttribute(string namespaceName) : base (default(string)) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
  public partial class AmqpMethodMappingAttribute : RabbitMQ.Client.Apigen.Attributes.AmqpApigenAttribute {
    public string m_className;
    public string m_methodName;
    public AmqpMethodMappingAttribute(string namespaceName, string className, string methodName) : base (default(string)) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
  public partial class AmqpNowaitArgumentAttribute : RabbitMQ.Client.Apigen.Attributes.AmqpApigenAttribute {
    public string m_replacementExpression;
    public AmqpNowaitArgumentAttribute(string namespaceName) : base (default(string)) { }
    public AmqpNowaitArgumentAttribute(string namespaceName, string replacementExpression) : base (default(string)) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
  public partial class AmqpUnsupportedAttribute : RabbitMQ.Client.Apigen.Attributes.AmqpApigenAttribute {
    public AmqpUnsupportedAttribute(string namespaceName) : base (default(string)) { }
  }
}
namespace RabbitMQ.Client.Content {
  public partial class BasicMessageBuilder : RabbitMQ.Client.Content.IMessageBuilder {
    public const int DefaultAccumulatorSize = 1024;
    protected System.IO.MemoryStream m_accumulator;
    protected RabbitMQ.Client.IBasicProperties m_properties;
    protected RabbitMQ.Util.NetworkBinaryWriter m_writer;
    public BasicMessageBuilder(RabbitMQ.Client.IModel model) { }
    public BasicMessageBuilder(RabbitMQ.Client.IModel model, int initialAccumulatorSize) { }
    public System.IO.Stream BodyStream { get { return default(System.IO.Stream); } }
    public System.Collections.IDictionary Headers { get { return default(System.Collections.IDictionary); } }
    public RabbitMQ.Client.IBasicProperties Properties { get { return default(RabbitMQ.Client.IBasicProperties); } }
    public RabbitMQ.Util.NetworkBinaryWriter Writer { get { return default(RabbitMQ.Util.NetworkBinaryWriter); } }
    public virtual System.Byte[] GetContentBody() { return default(System.Byte[]); }
    public virtual RabbitMQ.Client.IContentHeader GetContentHeader() { return default(RabbitMQ.Client.IContentHeader); }
    public virtual string GetDefaultContentType() { return default(string); }
    public RabbitMQ.Client.Content.IMessageBuilder RawWrite(byte b) { return default(RabbitMQ.Client.Content.IMessageBuilder); }
    public RabbitMQ.Client.Content.IMessageBuilder RawWrite(System.Byte[] bytes) { return default(RabbitMQ.Client.Content.IMessageBuilder); }
    public RabbitMQ.Client.Content.IMessageBuilder RawWrite(System.Byte[] bytes, int offset, int length) { return default(RabbitMQ.Client.Content.IMessageBuilder); }
  }
  public partial class BasicMessageReader : RabbitMQ.Client.Content.IMessageReader {
    protected System.Byte[] m_body;
    protected RabbitMQ.Client.IBasicProperties m_properties;
    protected RabbitMQ.Util.NetworkBinaryReader m_reader;
    protected System.IO.MemoryStream m_stream;
    public BasicMessageReader(RabbitMQ.Client.IBasicProperties properties, System.Byte[] body) { }
    public System.Byte[] BodyBytes { get { return default(System.Byte[]); } }
    public System.IO.Stream BodyStream { get { return default(System.IO.Stream); } }
    public System.Collections.IDictionary Headers { get { return default(System.Collections.IDictionary); } }
    public RabbitMQ.Client.IBasicProperties Properties { get { return default(RabbitMQ.Client.IBasicProperties); } }
    public RabbitMQ.Util.NetworkBinaryReader Reader { get { return default(RabbitMQ.Util.NetworkBinaryReader); } }
    public int RawRead() { return default(int); }
    public int RawRead(System.Byte[] target, int offset, int length) { return default(int); }
  }
  public partial class BytesMessageBuilder : RabbitMQ.Client.Content.BasicMessageBuilder, RabbitMQ.Client.Content.IBytesMessageBuilder, RabbitMQ.Client.Content.IMessageBuilder {
    public static readonly string MimeType;
    public BytesMessageBuilder(RabbitMQ.Client.IModel model) : base (default(RabbitMQ.Client.IModel)) { }
    public BytesMessageBuilder(RabbitMQ.Client.IModel model, int initialAccumulatorSize) : base (default(RabbitMQ.Client.IModel)) { }
    public override string GetDefaultContentType() { return default(string); }
    public RabbitMQ.Client.Content.IBytesMessageBuilder Write(System.Byte[] source, int offset, int count) { return default(RabbitMQ.Client.Content.IBytesMessageBuilder); }
    public RabbitMQ.Client.Content.IBytesMessageBuilder WriteByte(byte value) { return default(RabbitMQ.Client.Content.IBytesMessageBuilder); }
    public RabbitMQ.Client.Content.IBytesMessageBuilder WriteBytes(System.Byte[] source) { return default(RabbitMQ.Client.Content.IBytesMessageBuilder); }
    public RabbitMQ.Client.Content.IBytesMessageBuilder WriteChar(char value) { return default(RabbitMQ.Client.Content.IBytesMessageBuilder); }
    public RabbitMQ.Client.Content.IBytesMessageBuilder WriteDouble(double value) { return default(RabbitMQ.Client.Content.IBytesMessageBuilder); }
    public RabbitMQ.Client.Content.IBytesMessageBuilder WriteInt16(short value) { return default(RabbitMQ.Client.Content.IBytesMessageBuilder); }
    public RabbitMQ.Client.Content.IBytesMessageBuilder WriteInt32(int value) { return default(RabbitMQ.Client.Content.IBytesMessageBuilder); }
    public RabbitMQ.Client.Content.IBytesMessageBuilder WriteInt64(long value) { return default(RabbitMQ.Client.Content.IBytesMessageBuilder); }
    public RabbitMQ.Client.Content.IBytesMessageBuilder WriteSingle(float value) { return default(RabbitMQ.Client.Content.IBytesMessageBuilder); }
    public RabbitMQ.Client.Content.IBytesMessageBuilder WriteString(string value) { return default(RabbitMQ.Client.Content.IBytesMessageBuilder); }
  }
  public partial class BytesMessageReader : RabbitMQ.Client.Content.BasicMessageReader, RabbitMQ.Client.Content.IBytesMessageReader, RabbitMQ.Client.Content.IMessageReader {
    public static readonly string MimeType;
    public BytesMessageReader(RabbitMQ.Client.IBasicProperties properties, System.Byte[] payload) : base (default(RabbitMQ.Client.IBasicProperties), default(System.Byte[])) { }
    public int Read(System.Byte[] target, int offset, int count) { return default(int); }
    public byte ReadByte() { return default(byte); }
    public System.Byte[] ReadBytes(int count) { return default(System.Byte[]); }
    public char ReadChar() { return default(char); }
    public double ReadDouble() { return default(double); }
    public short ReadInt16() { return default(short); }
    public int ReadInt32() { return default(int); }
    public long ReadInt64() { return default(long); }
    public float ReadSingle() { return default(float); }
    public string ReadString() { return default(string); }
  }
  public partial class BytesWireFormatting {
    public BytesWireFormatting() { }
    public static int Read(RabbitMQ.Util.NetworkBinaryReader reader, System.Byte[] target, int offset, int count) { return default(int); }
    public static byte ReadByte(RabbitMQ.Util.NetworkBinaryReader reader) { return default(byte); }
    public static System.Byte[] ReadBytes(RabbitMQ.Util.NetworkBinaryReader reader, int count) { return default(System.Byte[]); }
    public static char ReadChar(RabbitMQ.Util.NetworkBinaryReader reader) { return default(char); }
    public static double ReadDouble(RabbitMQ.Util.NetworkBinaryReader reader) { return default(double); }
    public static short ReadInt16(RabbitMQ.Util.NetworkBinaryReader reader) { return default(short); }
    public static int ReadInt32(RabbitMQ.Util.NetworkBinaryReader reader) { return default(int); }
    public static long ReadInt64(RabbitMQ.Util.NetworkBinaryReader reader) { return default(long); }
    public static float ReadSingle(RabbitMQ.Util.NetworkBinaryReader reader) { return default(float); }
    public static string ReadString(RabbitMQ.Util.NetworkBinaryReader reader) { return default(string); }
    public static void Write(RabbitMQ.Util.NetworkBinaryWriter writer, System.Byte[] source, int offset, int count) { }
    public static void WriteByte(RabbitMQ.Util.NetworkBinaryWriter writer, byte value) { }
    public static void WriteBytes(RabbitMQ.Util.NetworkBinaryWriter writer, System.Byte[] source) { }
    public static void WriteChar(RabbitMQ.Util.NetworkBinaryWriter writer, char value) { }
    public static void WriteDouble(RabbitMQ.Util.NetworkBinaryWriter writer, double value) { }
    public static void WriteInt16(RabbitMQ.Util.NetworkBinaryWriter writer, short value) { }
    public static void WriteInt32(RabbitMQ.Util.NetworkBinaryWriter writer, int value) { }
    public static void WriteInt64(RabbitMQ.Util.NetworkBinaryWriter writer, long value) { }
    public static void WriteSingle(RabbitMQ.Util.NetworkBinaryWriter writer, float value) { }
    public static void WriteString(RabbitMQ.Util.NetworkBinaryWriter writer, string value) { }
  }
  public partial interface IBytesMessageBuilder : RabbitMQ.Client.Content.IMessageBuilder {
    RabbitMQ.Client.Content.IBytesMessageBuilder Write(System.Byte[] source, int offset, int count);
    RabbitMQ.Client.Content.IBytesMessageBuilder WriteByte(byte value);
    RabbitMQ.Client.Content.IBytesMessageBuilder WriteBytes(System.Byte[] source);
    RabbitMQ.Client.Content.IBytesMessageBuilder WriteChar(char value);
    RabbitMQ.Client.Content.IBytesMessageBuilder WriteDouble(double value);
    RabbitMQ.Client.Content.IBytesMessageBuilder WriteInt16(short value);
    RabbitMQ.Client.Content.IBytesMessageBuilder WriteInt32(int value);
    RabbitMQ.Client.Content.IBytesMessageBuilder WriteInt64(long value);
    RabbitMQ.Client.Content.IBytesMessageBuilder WriteSingle(float value);
    RabbitMQ.Client.Content.IBytesMessageBuilder WriteString(string value);
  }
  public partial interface IBytesMessageReader : RabbitMQ.Client.Content.IMessageReader {
    int Read(System.Byte[] target, int offset, int count);
    byte ReadByte();
    System.Byte[] ReadBytes(int count);
    char ReadChar();
    double ReadDouble();
    short ReadInt16();
    int ReadInt32();
    long ReadInt64();
    float ReadSingle();
    string ReadString();
  }
  public partial interface IMapMessageBuilder : RabbitMQ.Client.Content.IMessageBuilder {
    System.Collections.IDictionary Body { get; }
  }
  public partial interface IMapMessageReader : RabbitMQ.Client.Content.IMessageReader {
    System.Collections.IDictionary Body { get; }
  }
  public partial interface IMessageBuilder {
    System.IO.Stream BodyStream { get; }
    System.Collections.IDictionary Headers { get; }
    System.Byte[] GetContentBody();
    RabbitMQ.Client.IContentHeader GetContentHeader();
    string GetDefaultContentType();
    RabbitMQ.Client.Content.IMessageBuilder RawWrite(byte b);
    RabbitMQ.Client.Content.IMessageBuilder RawWrite(System.Byte[] bytes);
    RabbitMQ.Client.Content.IMessageBuilder RawWrite(System.Byte[] bytes, int offset, int length);
  }
  public partial interface IMessageReader {
    System.Byte[] BodyBytes { get; }
    System.IO.Stream BodyStream { get; }
    System.Collections.IDictionary Headers { get; }
    int RawRead();
    int RawRead(System.Byte[] target, int offset, int length);
  }
  public partial interface IStreamMessageBuilder : RabbitMQ.Client.Content.IMessageBuilder {
    RabbitMQ.Client.Content.IStreamMessageBuilder WriteBool(bool value);
    RabbitMQ.Client.Content.IStreamMessageBuilder WriteByte(byte value);
    RabbitMQ.Client.Content.IStreamMessageBuilder WriteBytes(System.Byte[] source);
    RabbitMQ.Client.Content.IStreamMessageBuilder WriteBytes(System.Byte[] source, int offset, int count);
    RabbitMQ.Client.Content.IStreamMessageBuilder WriteChar(char value);
    RabbitMQ.Client.Content.IStreamMessageBuilder WriteDouble(double value);
    RabbitMQ.Client.Content.IStreamMessageBuilder WriteInt16(short value);
    RabbitMQ.Client.Content.IStreamMessageBuilder WriteInt32(int value);
    RabbitMQ.Client.Content.IStreamMessageBuilder WriteInt64(long value);
    RabbitMQ.Client.Content.IStreamMessageBuilder WriteObject(object value);
    RabbitMQ.Client.Content.IStreamMessageBuilder WriteObjects(params System.Object[] values);
    RabbitMQ.Client.Content.IStreamMessageBuilder WriteSingle(float value);
    RabbitMQ.Client.Content.IStreamMessageBuilder WriteString(string value);
  }
  public partial interface IStreamMessageReader : RabbitMQ.Client.Content.IMessageReader {
    bool ReadBool();
    byte ReadByte();
    System.Byte[] ReadBytes();
    char ReadChar();
    double ReadDouble();
    short ReadInt16();
    int ReadInt32();
    long ReadInt64();
    object ReadObject();
    System.Object[] ReadObjects();
    float ReadSingle();
    string ReadString();
  }
  public partial class MapMessageBuilder : RabbitMQ.Client.Content.BasicMessageBuilder, RabbitMQ.Client.Content.IMapMessageBuilder, RabbitMQ.Client.Content.IMessageBuilder {
    protected System.Collections.IDictionary m_table;
    public static readonly string MimeType;
    public MapMessageBuilder(RabbitMQ.Client.IModel model) : base (default(RabbitMQ.Client.IModel)) { }
    public MapMessageBuilder(RabbitMQ.Client.IModel model, int initialAccumulatorSize) : base (default(RabbitMQ.Client.IModel)) { }
    public System.Collections.IDictionary Body { get { return default(System.Collections.IDictionary); } }
    public override System.Byte[] GetContentBody() { return default(System.Byte[]); }
    public override string GetDefaultContentType() { return default(string); }
  }
  public partial class MapMessageReader : RabbitMQ.Client.Content.BasicMessageReader, RabbitMQ.Client.Content.IMapMessageReader, RabbitMQ.Client.Content.IMessageReader {
    protected System.Collections.IDictionary m_table;
    public static readonly string MimeType;
    public MapMessageReader(RabbitMQ.Client.IBasicProperties properties, System.Byte[] payload) : base (default(RabbitMQ.Client.IBasicProperties), default(System.Byte[])) { }
    public System.Collections.IDictionary Body { get { return default(System.Collections.IDictionary); } }
  }
  public partial class MapWireFormatting {
    public MapWireFormatting() { }
    public static System.Collections.IDictionary ReadMap(RabbitMQ.Util.NetworkBinaryReader reader) { return default(System.Collections.IDictionary); }
    public static void WriteMap(RabbitMQ.Util.NetworkBinaryWriter writer, System.Collections.IDictionary table) { }
  }
  public partial class PrimitiveParser {
    public PrimitiveParser() { }
    public static void InvalidConversion(string target, object source) { }
    public static bool ParseBool(string value) { return default(bool); }
    public static byte ParseByte(string value) { return default(byte); }
    public static double ParseDouble(string value) { return default(double); }
    public static float ParseFloat(string value) { return default(float); }
    public static int ParseInt(string value) { return default(int); }
    public static long ParseLong(string value) { return default(long); }
    public static short ParseShort(string value) { return default(short); }
  }
  public partial class StreamMessageBuilder : RabbitMQ.Client.Content.BasicMessageBuilder, RabbitMQ.Client.Content.IMessageBuilder, RabbitMQ.Client.Content.IStreamMessageBuilder {
    public static readonly string MimeType;
    public StreamMessageBuilder(RabbitMQ.Client.IModel model) : base (default(RabbitMQ.Client.IModel)) { }
    public StreamMessageBuilder(RabbitMQ.Client.IModel model, int initialAccumulatorSize) : base (default(RabbitMQ.Client.IModel)) { }
    public override string GetDefaultContentType() { return default(string); }
    public RabbitMQ.Client.Content.IStreamMessageBuilder WriteBool(bool value) { return default(RabbitMQ.Client.Content.IStreamMessageBuilder); }
    public RabbitMQ.Client.Content.IStreamMessageBuilder WriteByte(byte value) { return default(RabbitMQ.Client.Content.IStreamMessageBuilder); }
    public RabbitMQ.Client.Content.IStreamMessageBuilder WriteBytes(System.Byte[] source) { return default(RabbitMQ.Client.Content.IStreamMessageBuilder); }
    public RabbitMQ.Client.Content.IStreamMessageBuilder WriteBytes(System.Byte[] source, int offset, int count) { return default(RabbitMQ.Client.Content.IStreamMessageBuilder); }
    public RabbitMQ.Client.Content.IStreamMessageBuilder WriteChar(char value) { return default(RabbitMQ.Client.Content.IStreamMessageBuilder); }
    public RabbitMQ.Client.Content.IStreamMessageBuilder WriteDouble(double value) { return default(RabbitMQ.Client.Content.IStreamMessageBuilder); }
    public RabbitMQ.Client.Content.IStreamMessageBuilder WriteInt16(short value) { return default(RabbitMQ.Client.Content.IStreamMessageBuilder); }
    public RabbitMQ.Client.Content.IStreamMessageBuilder WriteInt32(int value) { return default(RabbitMQ.Client.Content.IStreamMessageBuilder); }
    public RabbitMQ.Client.Content.IStreamMessageBuilder WriteInt64(long value) { return default(RabbitMQ.Client.Content.IStreamMessageBuilder); }
    public RabbitMQ.Client.Content.IStreamMessageBuilder WriteObject(object value) { return default(RabbitMQ.Client.Content.IStreamMessageBuilder); }
    public RabbitMQ.Client.Content.IStreamMessageBuilder WriteObjects(params System.Object[] values) { return default(RabbitMQ.Client.Content.IStreamMessageBuilder); }
    public RabbitMQ.Client.Content.IStreamMessageBuilder WriteSingle(float value) { return default(RabbitMQ.Client.Content.IStreamMessageBuilder); }
    public RabbitMQ.Client.Content.IStreamMessageBuilder WriteString(string value) { return default(RabbitMQ.Client.Content.IStreamMessageBuilder); }
  }
  public partial class StreamMessageReader : RabbitMQ.Client.Content.BasicMessageReader, RabbitMQ.Client.Content.IMessageReader, RabbitMQ.Client.Content.IStreamMessageReader {
    public static readonly string MimeType;
    public StreamMessageReader(RabbitMQ.Client.IBasicProperties properties, System.Byte[] payload) : base (default(RabbitMQ.Client.IBasicProperties), default(System.Byte[])) { }
    public bool ReadBool() { return default(bool); }
    public byte ReadByte() { return default(byte); }
    public System.Byte[] ReadBytes() { return default(System.Byte[]); }
    public char ReadChar() { return default(char); }
    public double ReadDouble() { return default(double); }
    public short ReadInt16() { return default(short); }
    public int ReadInt32() { return default(int); }
    public long ReadInt64() { return default(long); }
    public object ReadObject() { return default(object); }
    public System.Object[] ReadObjects() { return default(System.Object[]); }
    public float ReadSingle() { return default(float); }
    public string ReadString() { return default(string); }
  }
  public partial class StreamWireFormatting {
    public StreamWireFormatting() { }
    public static bool ReadBool(RabbitMQ.Util.NetworkBinaryReader reader) { return default(bool); }
    public static byte ReadByte(RabbitMQ.Util.NetworkBinaryReader reader) { return default(byte); }
    public static System.Byte[] ReadBytes(RabbitMQ.Util.NetworkBinaryReader reader) { return default(System.Byte[]); }
    public static char ReadChar(RabbitMQ.Util.NetworkBinaryReader reader) { return default(char); }
    public static double ReadDouble(RabbitMQ.Util.NetworkBinaryReader reader) { return default(double); }
    public static short ReadInt16(RabbitMQ.Util.NetworkBinaryReader reader) { return default(short); }
    public static int ReadInt32(RabbitMQ.Util.NetworkBinaryReader reader) { return default(int); }
    public static long ReadInt64(RabbitMQ.Util.NetworkBinaryReader reader) { return default(long); }
    public static object ReadNonnullObject(string target, RabbitMQ.Util.NetworkBinaryReader reader) { return default(object); }
    public static object ReadObject(RabbitMQ.Util.NetworkBinaryReader reader) { return default(object); }
    public static float ReadSingle(RabbitMQ.Util.NetworkBinaryReader reader) { return default(float); }
    public static string ReadString(RabbitMQ.Util.NetworkBinaryReader reader) { return default(string); }
    public static string ReadUntypedString(RabbitMQ.Util.NetworkBinaryReader reader) { return default(string); }
    public static void WriteBool(RabbitMQ.Util.NetworkBinaryWriter writer, bool value) { }
    public static void WriteByte(RabbitMQ.Util.NetworkBinaryWriter writer, byte value) { }
    public static void WriteBytes(RabbitMQ.Util.NetworkBinaryWriter writer, System.Byte[] value) { }
    public static void WriteBytes(RabbitMQ.Util.NetworkBinaryWriter writer, System.Byte[] value, int offset, int length) { }
    public static void WriteChar(RabbitMQ.Util.NetworkBinaryWriter writer, char value) { }
    public static void WriteDouble(RabbitMQ.Util.NetworkBinaryWriter writer, double value) { }
    public static void WriteInt16(RabbitMQ.Util.NetworkBinaryWriter writer, short value) { }
    public static void WriteInt32(RabbitMQ.Util.NetworkBinaryWriter writer, int value) { }
    public static void WriteInt64(RabbitMQ.Util.NetworkBinaryWriter writer, long value) { }
    public static void WriteObject(RabbitMQ.Util.NetworkBinaryWriter writer, object value) { }
    public static void WriteSingle(RabbitMQ.Util.NetworkBinaryWriter writer, float value) { }
    public static void WriteString(RabbitMQ.Util.NetworkBinaryWriter writer, string value) { }
    public static void WriteUntypedString(RabbitMQ.Util.NetworkBinaryWriter writer, string value) { }
  }
  public enum StreamWireFormattingTag {
    Bool = 1,
    Byte = 2,
    Bytes = 3,
    Char = 5,
    Double = 9,
    Int16 = 4,
    Int32 = 6,
    Int64 = 7,
    Null = 11,
    Single = 8,
    String = 10,
  }
}
namespace RabbitMQ.Client.Events {
  public partial class BasicDeliverEventArgs : System.EventArgs {
    public BasicDeliverEventArgs() { }
    public BasicDeliverEventArgs(string consumerTag, ulong deliveryTag, bool redelivered, string exchange, string routingKey, RabbitMQ.Client.IBasicProperties properties, System.Byte[] body) { }
    public RabbitMQ.Client.IBasicProperties BasicProperties { get { return default(RabbitMQ.Client.IBasicProperties); } set { } }
    public System.Byte[] Body { get { return default(System.Byte[]); } set { } }
    public string ConsumerTag { get { return default(string); } set { } }
    public ulong DeliveryTag { get { return default(ulong); } set { } }
    public string Exchange { get { return default(string); } set { } }
    public bool Redelivered { get { return default(bool); } set { } }
    public string RoutingKey { get { return default(string); } set { } }
  }
  public delegate void BasicDeliverEventHandler(RabbitMQ.Client.IBasicConsumer sender, RabbitMQ.Client.Events.BasicDeliverEventArgs args);
  public partial class BasicReturnEventArgs : System.EventArgs {
    public BasicReturnEventArgs() { }
    public RabbitMQ.Client.IBasicProperties BasicProperties { get { return default(RabbitMQ.Client.IBasicProperties); } set { } }
    public System.Byte[] Body { get { return default(System.Byte[]); } set { } }
    public string Exchange { get { return default(string); } set { } }
    public ushort ReplyCode { get { return default(ushort); } set { } }
    public string ReplyText { get { return default(string); } set { } }
    public string RoutingKey { get { return default(string); } set { } }
  }
  public delegate void BasicReturnEventHandler(RabbitMQ.Client.IModel model, RabbitMQ.Client.Events.BasicReturnEventArgs args);
  public partial class CallbackExceptionEventArgs : System.EventArgs {
    public CallbackExceptionEventArgs(System.Exception exception) { }
    public System.Collections.IDictionary Detail { get { return default(System.Collections.IDictionary); } }
    public System.Exception Exception { get { return default(System.Exception); } }
  }
  public delegate void CallbackExceptionEventHandler(object sender, RabbitMQ.Client.Events.CallbackExceptionEventArgs e);
  public delegate void ConnectionShutdownEventHandler(RabbitMQ.Client.IConnection connection, RabbitMQ.Client.ShutdownEventArgs reason);
  public partial class ConsumerEventArgs : System.EventArgs {
    public ConsumerEventArgs(string consumerTag) { }
    public string ConsumerTag { get { return default(string); } }
  }
  public delegate void ConsumerEventHandler(object sender, RabbitMQ.Client.Events.ConsumerEventArgs e);
  public delegate void ConsumerShutdownEventHandler(object sender, RabbitMQ.Client.ShutdownEventArgs e);
  public partial class EventingBasicConsumer : RabbitMQ.Client.DefaultBasicConsumer {
    public EventingBasicConsumer() { }
    public event RabbitMQ.Client.Events.BasicDeliverEventHandler Received { add { } remove { } }
    public event RabbitMQ.Client.Events.ConsumerEventHandler Registered { add { } remove { } }
    public event RabbitMQ.Client.Events.ConsumerShutdownEventHandler Shutdown { add { } remove { } }
    public event RabbitMQ.Client.Events.ConsumerEventHandler Unregistered { add { } remove { } }
    public override void HandleBasicCancelOk(string consumerTag) { }
    public override void HandleBasicConsumeOk(string consumerTag) { }
    public override void HandleBasicDeliver(string consumerTag, ulong deliveryTag, bool redelivered, string exchange, string routingKey, RabbitMQ.Client.IBasicProperties properties, System.Byte[] body) { }
    public override void HandleModelShutdown(RabbitMQ.Client.IModel model, RabbitMQ.Client.ShutdownEventArgs reason) { }
  }
  public delegate void ModelShutdownEventHandler(RabbitMQ.Client.IModel model, RabbitMQ.Client.ShutdownEventArgs reason);
}
namespace RabbitMQ.Client.Exceptions {
  public partial class AlreadyClosedException : RabbitMQ.Client.Exceptions.OperationInterruptedException {
    public AlreadyClosedException(RabbitMQ.Client.ShutdownEventArgs reason) { }
  }
  public partial class BrokerUnreachableException : System.IO.IOException {
    public BrokerUnreachableException(System.Collections.IDictionary connectionAttempts, System.Collections.IDictionary connectionErrors) { }
    public System.Collections.IDictionary ConnectionAttempts { get { return default(System.Collections.IDictionary); } }
    public System.Collections.IDictionary ConnectionErrors { get { return default(System.Collections.IDictionary); } }
    public override System.Collections.IDictionary Data { get { return default(System.Collections.IDictionary); } }
    public override string ToString() { return default(string); }
  }
  public partial class ChannelAllocationException : System.Exception {
    public ChannelAllocationException() { }
    public ChannelAllocationException(int channel) { }
    public int Channel { get { return default(int); } }
  }
  public partial class OperationInterruptedException : System.Exception {
    protected RabbitMQ.Client.ShutdownEventArgs m_shutdownReason;
    protected OperationInterruptedException() { }
    public OperationInterruptedException(RabbitMQ.Client.ShutdownEventArgs reason) { }
    protected OperationInterruptedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    protected OperationInterruptedException(string message) { }
    protected OperationInterruptedException(string message, System.Exception inner) { }
    public RabbitMQ.Client.ShutdownEventArgs ShutdownReason { get { return default(RabbitMQ.Client.ShutdownEventArgs); } }
  }
  public partial class PacketNotRecognizedException : System.Net.ProtocolViolationException {
    public PacketNotRecognizedException(int transportHigh, int transportLow, int serverMajor, int serverMinor) { }
    public int ServerMajor { get { return default(int); } }
    public int ServerMinor { get { return default(int); } }
    public int TransportHigh { get { return default(int); } }
    public int TransportLow { get { return default(int); } }
  }
  public partial class PossibleAuthenticationFailureException : System.Exception {
    public PossibleAuthenticationFailureException(string msg, System.Exception inner) { }
  }
  public partial class ProtocolVersionMismatchException : System.Net.ProtocolViolationException {
    public ProtocolVersionMismatchException(int clientMajor, int clientMinor, int serverMajor, int serverMinor) { }
    public int ClientMajor { get { return default(int); } }
    public int ClientMinor { get { return default(int); } }
    public int ServerMajor { get { return default(int); } }
    public int ServerMinor { get { return default(int); } }
  }
  public partial class UnexpectedMethodException : System.Exception {
    public UnexpectedMethodException(RabbitMQ.Client.IMethod method) { }
    public RabbitMQ.Client.IMethod Method { get { return default(RabbitMQ.Client.IMethod); } }
  }
  public partial class UnsupportedMethodException : System.NotSupportedException {
    public UnsupportedMethodException(string methodName) { }
    public string MethodName { get { return default(string); } }
  }
  public partial class UnsupportedMethodFieldException : System.NotSupportedException {
    public UnsupportedMethodFieldException(string methodName, string fieldName) { }
    public string FieldName { get { return default(string); } }
    public string MethodName { get { return default(string); } }
  }
  public partial class WireFormattingException : System.Net.ProtocolViolationException {
    public WireFormattingException(string message) { }
    public WireFormattingException(string message, object offender) { }
    public object Offender { get { return default(object); } }
  }
}
namespace RabbitMQ.Client.Framing.Impl.v0_8 {
  public partial class AccessRequest : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IAccessRequest, RabbitMQ.Client.IMethod {
    public const int ClassId = 30;
    public bool m_active;
    public bool m_exclusive;
    public bool m_passive;
    public bool m_read;
    public string m_realm;
    public bool m_write;
    public const int MethodId = 10;
    public AccessRequest() { }
    public AccessRequest(string initRealm, bool initExclusive, bool initPassive, bool initActive, bool initWrite, bool initRead) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_8.IAccessRequest.Active { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_8.IAccessRequest.Exclusive { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_8.IAccessRequest.Passive { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_8.IAccessRequest.Read { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_8.IAccessRequest.Realm { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_8.IAccessRequest.Write { get { return default(bool); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class AccessRequestOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IAccessRequestOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 30;
    public ushort m_ticket;
    public const int MethodId = 11;
    public AccessRequestOk() { }
    public AccessRequestOk(ushort initTicket) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_8.IAccessRequestOk.Ticket { get { return default(ushort); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class BasicAck : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IBasicAck, RabbitMQ.Client.IMethod {
    public const int ClassId = 60;
    public ulong m_deliveryTag;
    public bool m_multiple;
    public const int MethodId = 80;
    public BasicAck() { }
    public BasicAck(ulong initDeliveryTag, bool initMultiple) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    ulong RabbitMQ.Client.Framing.v0_8.IBasicAck.DeliveryTag { get { return default(ulong); } }
    bool RabbitMQ.Client.Framing.v0_8.IBasicAck.Multiple { get { return default(bool); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class BasicCancel : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IBasicCancel, RabbitMQ.Client.IMethod {
    public const int ClassId = 60;
    public string m_consumerTag;
    public bool m_nowait;
    public const int MethodId = 30;
    public BasicCancel() { }
    public BasicCancel(string initConsumerTag, bool initNowait) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8.IBasicCancel.ConsumerTag { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_8.IBasicCancel.Nowait { get { return default(bool); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class BasicCancelOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IBasicCancelOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 60;
    public string m_consumerTag;
    public const int MethodId = 31;
    public BasicCancelOk() { }
    public BasicCancelOk(string initConsumerTag) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8.IBasicCancelOk.ConsumerTag { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class BasicConsume : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IBasicConsume, RabbitMQ.Client.IMethod {
    public const int ClassId = 60;
    public string m_consumerTag;
    public bool m_exclusive;
    public bool m_noAck;
    public bool m_noLocal;
    public bool m_nowait;
    public string m_queue;
    public ushort m_ticket;
    public const int MethodId = 20;
    public BasicConsume() { }
    public BasicConsume(ushort initTicket, string initQueue, string initConsumerTag, bool initNoLocal, bool initNoAck, bool initExclusive, bool initNowait) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8.IBasicConsume.ConsumerTag { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_8.IBasicConsume.Exclusive { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_8.IBasicConsume.NoAck { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_8.IBasicConsume.NoLocal { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_8.IBasicConsume.Nowait { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_8.IBasicConsume.Queue { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_8.IBasicConsume.Ticket { get { return default(ushort); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class BasicConsumeOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IBasicConsumeOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 60;
    public string m_consumerTag;
    public const int MethodId = 21;
    public BasicConsumeOk() { }
    public BasicConsumeOk(string initConsumerTag) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8.IBasicConsumeOk.ConsumerTag { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class BasicDeliver : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IBasicDeliver, RabbitMQ.Client.IMethod {
    public const int ClassId = 60;
    public string m_consumerTag;
    public ulong m_deliveryTag;
    public string m_exchange;
    public bool m_redelivered;
    public string m_routingKey;
    public const int MethodId = 60;
    public BasicDeliver() { }
    public BasicDeliver(string initConsumerTag, ulong initDeliveryTag, bool initRedelivered, string initExchange, string initRoutingKey) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8.IBasicDeliver.ConsumerTag { get { return default(string); } }
    ulong RabbitMQ.Client.Framing.v0_8.IBasicDeliver.DeliveryTag { get { return default(ulong); } }
    string RabbitMQ.Client.Framing.v0_8.IBasicDeliver.Exchange { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_8.IBasicDeliver.Redelivered { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_8.IBasicDeliver.RoutingKey { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class BasicGet : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IBasicGet, RabbitMQ.Client.IMethod {
    public const int ClassId = 60;
    public bool m_noAck;
    public string m_queue;
    public ushort m_ticket;
    public const int MethodId = 70;
    public BasicGet() { }
    public BasicGet(ushort initTicket, string initQueue, bool initNoAck) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_8.IBasicGet.NoAck { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_8.IBasicGet.Queue { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_8.IBasicGet.Ticket { get { return default(ushort); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class BasicGetEmpty : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IBasicGetEmpty, RabbitMQ.Client.IMethod {
    public const int ClassId = 60;
    public string m_clusterId;
    public const int MethodId = 72;
    public BasicGetEmpty() { }
    public BasicGetEmpty(string initClusterId) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8.IBasicGetEmpty.ClusterId { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class BasicGetOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IBasicGetOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 60;
    public ulong m_deliveryTag;
    public string m_exchange;
    public uint m_messageCount;
    public bool m_redelivered;
    public string m_routingKey;
    public const int MethodId = 71;
    public BasicGetOk() { }
    public BasicGetOk(ulong initDeliveryTag, bool initRedelivered, string initExchange, string initRoutingKey, uint initMessageCount) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    ulong RabbitMQ.Client.Framing.v0_8.IBasicGetOk.DeliveryTag { get { return default(ulong); } }
    string RabbitMQ.Client.Framing.v0_8.IBasicGetOk.Exchange { get { return default(string); } }
    uint RabbitMQ.Client.Framing.v0_8.IBasicGetOk.MessageCount { get { return default(uint); } }
    bool RabbitMQ.Client.Framing.v0_8.IBasicGetOk.Redelivered { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_8.IBasicGetOk.RoutingKey { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class BasicPublish : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IBasicPublish, RabbitMQ.Client.IMethod {
    public const int ClassId = 60;
    public string m_exchange;
    public bool m_immediate;
    public bool m_mandatory;
    public string m_routingKey;
    public ushort m_ticket;
    public const int MethodId = 40;
    public BasicPublish() { }
    public BasicPublish(ushort initTicket, string initExchange, string initRoutingKey, bool initMandatory, bool initImmediate) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8.IBasicPublish.Exchange { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_8.IBasicPublish.Immediate { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_8.IBasicPublish.Mandatory { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_8.IBasicPublish.RoutingKey { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_8.IBasicPublish.Ticket { get { return default(ushort); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class BasicQos : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IBasicQos, RabbitMQ.Client.IMethod {
    public const int ClassId = 60;
    public bool m_global;
    public ushort m_prefetchCount;
    public uint m_prefetchSize;
    public const int MethodId = 10;
    public BasicQos() { }
    public BasicQos(uint initPrefetchSize, ushort initPrefetchCount, bool initGlobal) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_8.IBasicQos.Global { get { return default(bool); } }
    ushort RabbitMQ.Client.Framing.v0_8.IBasicQos.PrefetchCount { get { return default(ushort); } }
    uint RabbitMQ.Client.Framing.v0_8.IBasicQos.PrefetchSize { get { return default(uint); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class BasicQosOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IBasicQosOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 60;
    public const int MethodId = 11;
    public BasicQosOk() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class BasicRecover : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IBasicRecover, RabbitMQ.Client.IMethod {
    public const int ClassId = 60;
    public bool m_requeue;
    public const int MethodId = 100;
    public BasicRecover() { }
    public BasicRecover(bool initRequeue) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_8.IBasicRecover.Requeue { get { return default(bool); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class BasicReject : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IBasicReject, RabbitMQ.Client.IMethod {
    public const int ClassId = 60;
    public ulong m_deliveryTag;
    public bool m_requeue;
    public const int MethodId = 90;
    public BasicReject() { }
    public BasicReject(ulong initDeliveryTag, bool initRequeue) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    ulong RabbitMQ.Client.Framing.v0_8.IBasicReject.DeliveryTag { get { return default(ulong); } }
    bool RabbitMQ.Client.Framing.v0_8.IBasicReject.Requeue { get { return default(bool); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class BasicReturn : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IBasicReturn, RabbitMQ.Client.IMethod {
    public const int ClassId = 60;
    public string m_exchange;
    public ushort m_replyCode;
    public string m_replyText;
    public string m_routingKey;
    public const int MethodId = 50;
    public BasicReturn() { }
    public BasicReturn(ushort initReplyCode, string initReplyText, string initExchange, string initRoutingKey) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8.IBasicReturn.Exchange { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_8.IBasicReturn.ReplyCode { get { return default(ushort); } }
    string RabbitMQ.Client.Framing.v0_8.IBasicReturn.ReplyText { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8.IBasicReturn.RoutingKey { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ChannelAlert : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IChannelAlert, RabbitMQ.Client.IMethod {
    public const int ClassId = 20;
    public System.Collections.IDictionary m_details;
    public ushort m_replyCode;
    public string m_replyText;
    public const int MethodId = 30;
    public ChannelAlert() { }
    public ChannelAlert(ushort initReplyCode, string initReplyText, System.Collections.IDictionary initDetails) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    System.Collections.IDictionary RabbitMQ.Client.Framing.v0_8.IChannelAlert.Details { get { return default(System.Collections.IDictionary); } }
    ushort RabbitMQ.Client.Framing.v0_8.IChannelAlert.ReplyCode { get { return default(ushort); } }
    string RabbitMQ.Client.Framing.v0_8.IChannelAlert.ReplyText { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ChannelClose : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IChannelClose, RabbitMQ.Client.IMethod {
    public const int ClassId = 20;
    public ushort m_classId;
    public ushort m_methodId;
    public ushort m_replyCode;
    public string m_replyText;
    public const int MethodId = 40;
    public ChannelClose() { }
    public ChannelClose(ushort initReplyCode, string initReplyText, ushort initClassId, ushort initMethodId) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_8.IChannelClose.ClassId { get { return default(ushort); } }
    ushort RabbitMQ.Client.Framing.v0_8.IChannelClose.MethodId { get { return default(ushort); } }
    ushort RabbitMQ.Client.Framing.v0_8.IChannelClose.ReplyCode { get { return default(ushort); } }
    string RabbitMQ.Client.Framing.v0_8.IChannelClose.ReplyText { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ChannelCloseOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IChannelCloseOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 20;
    public const int MethodId = 41;
    public ChannelCloseOk() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ChannelFlow : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IChannelFlow, RabbitMQ.Client.IMethod {
    public const int ClassId = 20;
    public bool m_active;
    public const int MethodId = 20;
    public ChannelFlow() { }
    public ChannelFlow(bool initActive) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_8.IChannelFlow.Active { get { return default(bool); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ChannelFlowOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IChannelFlowOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 20;
    public bool m_active;
    public const int MethodId = 21;
    public ChannelFlowOk() { }
    public ChannelFlowOk(bool initActive) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_8.IChannelFlowOk.Active { get { return default(bool); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ChannelOpen : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IChannelOpen, RabbitMQ.Client.IMethod {
    public const int ClassId = 20;
    public string m_outOfBand;
    public const int MethodId = 10;
    public ChannelOpen() { }
    public ChannelOpen(string initOutOfBand) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8.IChannelOpen.OutOfBand { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ChannelOpenOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IChannelOpenOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 20;
    public const int MethodId = 11;
    public ChannelOpenOk() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public enum ClassId {
    Access = 30,
    Basic = 60,
    Channel = 20,
    Connection = 10,
    Dtx = 100,
    Exchange = 40,
    File = 70,
    Invalid = -1,
    Queue = 50,
    Stream = 80,
    Test = 120,
    Tunnel = 110,
    Tx = 90,
  }
  public partial class Connection : RabbitMQ.Client.Impl.ConnectionBase {
    public Connection(RabbitMQ.Client.ConnectionFactory factory, bool insist, RabbitMQ.Client.Impl.IFrameHandler frameHandler) : base (default(RabbitMQ.Client.ConnectionFactory), default(bool), default(RabbitMQ.Client.Impl.IFrameHandler)) { }
  }
  public partial class ConnectionClose : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IConnectionClose, RabbitMQ.Client.IMethod {
    public const int ClassId = 10;
    public ushort m_classId;
    public ushort m_methodId;
    public ushort m_replyCode;
    public string m_replyText;
    public const int MethodId = 60;
    public ConnectionClose() { }
    public ConnectionClose(ushort initReplyCode, string initReplyText, ushort initClassId, ushort initMethodId) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_8.IConnectionClose.ClassId { get { return default(ushort); } }
    ushort RabbitMQ.Client.Framing.v0_8.IConnectionClose.MethodId { get { return default(ushort); } }
    ushort RabbitMQ.Client.Framing.v0_8.IConnectionClose.ReplyCode { get { return default(ushort); } }
    string RabbitMQ.Client.Framing.v0_8.IConnectionClose.ReplyText { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ConnectionCloseOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IConnectionCloseOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 10;
    public const int MethodId = 61;
    public ConnectionCloseOk() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ConnectionOpen : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IConnectionOpen, RabbitMQ.Client.IMethod {
    public const int ClassId = 10;
    public string m_capabilities;
    public bool m_insist;
    public string m_virtualHost;
    public const int MethodId = 40;
    public ConnectionOpen() { }
    public ConnectionOpen(string initVirtualHost, string initCapabilities, bool initInsist) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8.IConnectionOpen.Capabilities { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_8.IConnectionOpen.Insist { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_8.IConnectionOpen.VirtualHost { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ConnectionOpenOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IConnectionOpenOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 10;
    public string m_knownHosts;
    public const int MethodId = 41;
    public ConnectionOpenOk() { }
    public ConnectionOpenOk(string initKnownHosts) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8.IConnectionOpenOk.KnownHosts { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ConnectionRedirect : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IConnectionRedirect, RabbitMQ.Client.IMethod {
    public const int ClassId = 10;
    public string m_host;
    public string m_knownHosts;
    public const int MethodId = 50;
    public ConnectionRedirect() { }
    public ConnectionRedirect(string initHost, string initKnownHosts) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8.IConnectionRedirect.Host { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8.IConnectionRedirect.KnownHosts { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ConnectionSecure : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IConnectionSecure, RabbitMQ.Client.IMethod {
    public const int ClassId = 10;
    public System.Byte[] m_challenge;
    public const int MethodId = 20;
    public ConnectionSecure() { }
    public ConnectionSecure(System.Byte[] initChallenge) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    System.Byte[] RabbitMQ.Client.Framing.v0_8.IConnectionSecure.Challenge { get { return default(System.Byte[]); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ConnectionSecureOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IConnectionSecureOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 10;
    public System.Byte[] m_response;
    public const int MethodId = 21;
    public ConnectionSecureOk() { }
    public ConnectionSecureOk(System.Byte[] initResponse) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    System.Byte[] RabbitMQ.Client.Framing.v0_8.IConnectionSecureOk.Response { get { return default(System.Byte[]); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ConnectionStart : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IConnectionStart, RabbitMQ.Client.IMethod {
    public const int ClassId = 10;
    public System.Byte[] m_locales;
    public System.Byte[] m_mechanisms;
    public System.Collections.IDictionary m_serverProperties;
    public byte m_versionMajor;
    public byte m_versionMinor;
    public const int MethodId = 10;
    public ConnectionStart() { }
    public ConnectionStart(byte initVersionMajor, byte initVersionMinor, System.Collections.IDictionary initServerProperties, System.Byte[] initMechanisms, System.Byte[] initLocales) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    System.Byte[] RabbitMQ.Client.Framing.v0_8.IConnectionStart.Locales { get { return default(System.Byte[]); } }
    System.Byte[] RabbitMQ.Client.Framing.v0_8.IConnectionStart.Mechanisms { get { return default(System.Byte[]); } }
    System.Collections.IDictionary RabbitMQ.Client.Framing.v0_8.IConnectionStart.ServerProperties { get { return default(System.Collections.IDictionary); } }
    byte RabbitMQ.Client.Framing.v0_8.IConnectionStart.VersionMajor { get { return default(byte); } }
    byte RabbitMQ.Client.Framing.v0_8.IConnectionStart.VersionMinor { get { return default(byte); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ConnectionStartOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IConnectionStartOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 10;
    public System.Collections.IDictionary m_clientProperties;
    public string m_locale;
    public string m_mechanism;
    public System.Byte[] m_response;
    public const int MethodId = 11;
    public ConnectionStartOk() { }
    public ConnectionStartOk(System.Collections.IDictionary initClientProperties, string initMechanism, System.Byte[] initResponse, string initLocale) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    System.Collections.IDictionary RabbitMQ.Client.Framing.v0_8.IConnectionStartOk.ClientProperties { get { return default(System.Collections.IDictionary); } }
    string RabbitMQ.Client.Framing.v0_8.IConnectionStartOk.Locale { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8.IConnectionStartOk.Mechanism { get { return default(string); } }
    System.Byte[] RabbitMQ.Client.Framing.v0_8.IConnectionStartOk.Response { get { return default(System.Byte[]); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ConnectionTune : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IConnectionTune, RabbitMQ.Client.IMethod {
    public const int ClassId = 10;
    public ushort m_channelMax;
    public uint m_frameMax;
    public ushort m_heartbeat;
    public const int MethodId = 30;
    public ConnectionTune() { }
    public ConnectionTune(ushort initChannelMax, uint initFrameMax, ushort initHeartbeat) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_8.IConnectionTune.ChannelMax { get { return default(ushort); } }
    uint RabbitMQ.Client.Framing.v0_8.IConnectionTune.FrameMax { get { return default(uint); } }
    ushort RabbitMQ.Client.Framing.v0_8.IConnectionTune.Heartbeat { get { return default(ushort); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ConnectionTuneOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IConnectionTuneOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 10;
    public ushort m_channelMax;
    public uint m_frameMax;
    public ushort m_heartbeat;
    public const int MethodId = 31;
    public ConnectionTuneOk() { }
    public ConnectionTuneOk(ushort initChannelMax, uint initFrameMax, ushort initHeartbeat) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_8.IConnectionTuneOk.ChannelMax { get { return default(ushort); } }
    uint RabbitMQ.Client.Framing.v0_8.IConnectionTuneOk.FrameMax { get { return default(uint); } }
    ushort RabbitMQ.Client.Framing.v0_8.IConnectionTuneOk.Heartbeat { get { return default(ushort); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class DtxSelect : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IDtxSelect, RabbitMQ.Client.IMethod {
    public const int ClassId = 100;
    public const int MethodId = 10;
    public DtxSelect() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class DtxSelectOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IDtxSelectOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 100;
    public const int MethodId = 11;
    public DtxSelectOk() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class DtxStart : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IDtxStart, RabbitMQ.Client.IMethod {
    public const int ClassId = 100;
    public string m_dtxIdentifier;
    public const int MethodId = 20;
    public DtxStart() { }
    public DtxStart(string initDtxIdentifier) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8.IDtxStart.DtxIdentifier { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class DtxStartOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IDtxStartOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 100;
    public const int MethodId = 21;
    public DtxStartOk() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ExchangeDeclare : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IExchangeDeclare, RabbitMQ.Client.IMethod {
    public const int ClassId = 40;
    public System.Collections.IDictionary m_arguments;
    public bool m_autoDelete;
    public bool m_durable;
    public string m_exchange;
    public bool m_internal;
    public bool m_nowait;
    public bool m_passive;
    public ushort m_ticket;
    public string m_type;
    public const int MethodId = 10;
    public ExchangeDeclare() { }
    public ExchangeDeclare(ushort initTicket, string initExchange, string initType, bool initPassive, bool initDurable, bool initAutoDelete, bool initInternal, bool initNowait, System.Collections.IDictionary initArguments) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    System.Collections.IDictionary RabbitMQ.Client.Framing.v0_8.IExchangeDeclare.Arguments { get { return default(System.Collections.IDictionary); } }
    bool RabbitMQ.Client.Framing.v0_8.IExchangeDeclare.AutoDelete { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_8.IExchangeDeclare.Durable { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_8.IExchangeDeclare.Exchange { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_8.IExchangeDeclare.Internal { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_8.IExchangeDeclare.Nowait { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_8.IExchangeDeclare.Passive { get { return default(bool); } }
    ushort RabbitMQ.Client.Framing.v0_8.IExchangeDeclare.Ticket { get { return default(ushort); } }
    string RabbitMQ.Client.Framing.v0_8.IExchangeDeclare.Type { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ExchangeDeclareOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IExchangeDeclareOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 40;
    public const int MethodId = 11;
    public ExchangeDeclareOk() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ExchangeDelete : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IExchangeDelete, RabbitMQ.Client.IMethod {
    public const int ClassId = 40;
    public string m_exchange;
    public bool m_ifUnused;
    public bool m_nowait;
    public ushort m_ticket;
    public const int MethodId = 20;
    public ExchangeDelete() { }
    public ExchangeDelete(ushort initTicket, string initExchange, bool initIfUnused, bool initNowait) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8.IExchangeDelete.Exchange { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_8.IExchangeDelete.IfUnused { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_8.IExchangeDelete.Nowait { get { return default(bool); } }
    ushort RabbitMQ.Client.Framing.v0_8.IExchangeDelete.Ticket { get { return default(ushort); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ExchangeDeleteOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IExchangeDeleteOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 40;
    public const int MethodId = 21;
    public ExchangeDeleteOk() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class FileAck : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IFileAck, RabbitMQ.Client.IMethod {
    public const int ClassId = 70;
    public ulong m_deliveryTag;
    public bool m_multiple;
    public const int MethodId = 90;
    public FileAck() { }
    public FileAck(ulong initDeliveryTag, bool initMultiple) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    ulong RabbitMQ.Client.Framing.v0_8.IFileAck.DeliveryTag { get { return default(ulong); } }
    bool RabbitMQ.Client.Framing.v0_8.IFileAck.Multiple { get { return default(bool); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class FileCancel : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IFileCancel, RabbitMQ.Client.IMethod {
    public const int ClassId = 70;
    public string m_consumerTag;
    public bool m_nowait;
    public const int MethodId = 30;
    public FileCancel() { }
    public FileCancel(string initConsumerTag, bool initNowait) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8.IFileCancel.ConsumerTag { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_8.IFileCancel.Nowait { get { return default(bool); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class FileCancelOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IFileCancelOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 70;
    public string m_consumerTag;
    public const int MethodId = 31;
    public FileCancelOk() { }
    public FileCancelOk(string initConsumerTag) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8.IFileCancelOk.ConsumerTag { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class FileConsume : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IFileConsume, RabbitMQ.Client.IMethod {
    public const int ClassId = 70;
    public string m_consumerTag;
    public bool m_exclusive;
    public bool m_noAck;
    public bool m_noLocal;
    public bool m_nowait;
    public string m_queue;
    public ushort m_ticket;
    public const int MethodId = 20;
    public FileConsume() { }
    public FileConsume(ushort initTicket, string initQueue, string initConsumerTag, bool initNoLocal, bool initNoAck, bool initExclusive, bool initNowait) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8.IFileConsume.ConsumerTag { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_8.IFileConsume.Exclusive { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_8.IFileConsume.NoAck { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_8.IFileConsume.NoLocal { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_8.IFileConsume.Nowait { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_8.IFileConsume.Queue { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_8.IFileConsume.Ticket { get { return default(ushort); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class FileConsumeOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IFileConsumeOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 70;
    public string m_consumerTag;
    public const int MethodId = 21;
    public FileConsumeOk() { }
    public FileConsumeOk(string initConsumerTag) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8.IFileConsumeOk.ConsumerTag { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class FileDeliver : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IFileDeliver, RabbitMQ.Client.IMethod {
    public const int ClassId = 70;
    public string m_consumerTag;
    public ulong m_deliveryTag;
    public string m_exchange;
    public string m_identifier;
    public bool m_redelivered;
    public string m_routingKey;
    public const int MethodId = 80;
    public FileDeliver() { }
    public FileDeliver(string initConsumerTag, ulong initDeliveryTag, bool initRedelivered, string initExchange, string initRoutingKey, string initIdentifier) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8.IFileDeliver.ConsumerTag { get { return default(string); } }
    ulong RabbitMQ.Client.Framing.v0_8.IFileDeliver.DeliveryTag { get { return default(ulong); } }
    string RabbitMQ.Client.Framing.v0_8.IFileDeliver.Exchange { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8.IFileDeliver.Identifier { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_8.IFileDeliver.Redelivered { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_8.IFileDeliver.RoutingKey { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class FileOpen : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IFileOpen, RabbitMQ.Client.IMethod {
    public const int ClassId = 70;
    public ulong m_contentSize;
    public string m_identifier;
    public const int MethodId = 40;
    public FileOpen() { }
    public FileOpen(string initIdentifier, ulong initContentSize) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    ulong RabbitMQ.Client.Framing.v0_8.IFileOpen.ContentSize { get { return default(ulong); } }
    string RabbitMQ.Client.Framing.v0_8.IFileOpen.Identifier { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class FileOpenOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IFileOpenOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 70;
    public ulong m_stagedSize;
    public const int MethodId = 41;
    public FileOpenOk() { }
    public FileOpenOk(ulong initStagedSize) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    ulong RabbitMQ.Client.Framing.v0_8.IFileOpenOk.StagedSize { get { return default(ulong); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class FilePublish : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IFilePublish, RabbitMQ.Client.IMethod {
    public const int ClassId = 70;
    public string m_exchange;
    public string m_identifier;
    public bool m_immediate;
    public bool m_mandatory;
    public string m_routingKey;
    public ushort m_ticket;
    public const int MethodId = 60;
    public FilePublish() { }
    public FilePublish(ushort initTicket, string initExchange, string initRoutingKey, bool initMandatory, bool initImmediate, string initIdentifier) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8.IFilePublish.Exchange { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8.IFilePublish.Identifier { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_8.IFilePublish.Immediate { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_8.IFilePublish.Mandatory { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_8.IFilePublish.RoutingKey { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_8.IFilePublish.Ticket { get { return default(ushort); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class FileQos : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IFileQos, RabbitMQ.Client.IMethod {
    public const int ClassId = 70;
    public bool m_global;
    public ushort m_prefetchCount;
    public uint m_prefetchSize;
    public const int MethodId = 10;
    public FileQos() { }
    public FileQos(uint initPrefetchSize, ushort initPrefetchCount, bool initGlobal) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_8.IFileQos.Global { get { return default(bool); } }
    ushort RabbitMQ.Client.Framing.v0_8.IFileQos.PrefetchCount { get { return default(ushort); } }
    uint RabbitMQ.Client.Framing.v0_8.IFileQos.PrefetchSize { get { return default(uint); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class FileQosOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IFileQosOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 70;
    public const int MethodId = 11;
    public FileQosOk() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class FileReject : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IFileReject, RabbitMQ.Client.IMethod {
    public const int ClassId = 70;
    public ulong m_deliveryTag;
    public bool m_requeue;
    public const int MethodId = 100;
    public FileReject() { }
    public FileReject(ulong initDeliveryTag, bool initRequeue) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    ulong RabbitMQ.Client.Framing.v0_8.IFileReject.DeliveryTag { get { return default(ulong); } }
    bool RabbitMQ.Client.Framing.v0_8.IFileReject.Requeue { get { return default(bool); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class FileReturn : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IFileReturn, RabbitMQ.Client.IMethod {
    public const int ClassId = 70;
    public string m_exchange;
    public ushort m_replyCode;
    public string m_replyText;
    public string m_routingKey;
    public const int MethodId = 70;
    public FileReturn() { }
    public FileReturn(ushort initReplyCode, string initReplyText, string initExchange, string initRoutingKey) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8.IFileReturn.Exchange { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_8.IFileReturn.ReplyCode { get { return default(ushort); } }
    string RabbitMQ.Client.Framing.v0_8.IFileReturn.ReplyText { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8.IFileReturn.RoutingKey { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class FileStage : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IFileStage, RabbitMQ.Client.IMethod {
    public const int ClassId = 70;
    public const int MethodId = 50;
    public FileStage() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class Model : RabbitMQ.Client.Impl.ModelBase {
    public Model(RabbitMQ.Client.Impl.ISession session) : base (default(RabbitMQ.Client.Impl.ISession)) { }
    public override void _Private_BasicCancel(string consumerTag, bool nowait) { }
    public override void _Private_BasicConsume(string queue, string consumerTag, bool noLocal, bool noAck, bool exclusive, bool nowait, System.Collections.IDictionary filter) { }
    public override void _Private_BasicGet(string queue, bool noAck) { }
    public override void _Private_BasicPublish(string exchange, string routingKey, bool mandatory, bool immediate, RabbitMQ.Client.IBasicProperties basicProperties, System.Byte[] body) { }
    public override void _Private_ChannelClose(ushort replyCode, string replyText, ushort classId, ushort methodId) { }
    public override void _Private_ChannelCloseOk() { }
    public override void _Private_ChannelFlowOk() { }
    public override void _Private_ChannelOpen(string outOfBand) { }
    public override void _Private_ConnectionClose(ushort replyCode, string replyText, ushort classId, ushort methodId) { }
    public override void _Private_ConnectionCloseOk() { }
    public override void _Private_ConnectionOpen(string virtualHost, string capabilities, bool insist) { }
    public override void BasicAck(ulong deliveryTag, bool multiple) { }
    public override void BasicQos(uint prefetchSize, ushort prefetchCount, bool global) { }
    public override void BasicRecover(bool requeue) { }
    public override void BasicReject(ulong deliveryTag, bool requeue) { }
    public override void ChannelFlow(bool active) { }
    public override RabbitMQ.Client.Impl.ConnectionTuneDetails ConnectionStartOk(System.Collections.IDictionary clientProperties, string mechanism, System.Byte[] response, string locale) { return default(RabbitMQ.Client.Impl.ConnectionTuneDetails); }
    public override void ConnectionTuneOk(ushort channelMax, uint frameMax, ushort heartbeat) { }
    public override RabbitMQ.Client.IBasicProperties CreateBasicProperties() { return default(RabbitMQ.Client.IBasicProperties); }
    public override RabbitMQ.Client.IFileProperties CreateFileProperties() { return default(RabbitMQ.Client.IFileProperties); }
    public override RabbitMQ.Client.IStreamProperties CreateStreamProperties() { return default(RabbitMQ.Client.IStreamProperties); }
    public override bool DispatchAsynchronous(RabbitMQ.Client.Impl.Command cmd) { return default(bool); }
    public override void DtxSelect() { }
    public override void DtxStart(string dtxIdentifier) { }
    public override void ExchangeDeclare(string exchange, string type, bool passive, bool durable, bool autoDelete, bool @internal, bool nowait, System.Collections.IDictionary arguments) { }
    public override void ExchangeDelete(string exchange, bool ifUnused, bool nowait) { }
    public override void QueueBind(string queue, string exchange, string routingKey, bool nowait, System.Collections.IDictionary arguments) { }
    public override string QueueDeclare(string queue, bool passive, bool durable, bool exclusive, bool autoDelete, bool nowait, System.Collections.IDictionary arguments) { return default(string); }
    public override uint QueueDelete(string queue, bool ifUnused, bool ifEmpty, bool nowait) { return default(uint); }
    public override uint QueuePurge(string queue, bool nowait) { return default(uint); }
    public override void QueueUnbind(string queue, string exchange, string routingKey, System.Collections.IDictionary arguments) { }
    public override void TxCommit() { }
    public override void TxRollback() { }
    public override void TxSelect() { }
  }
  public abstract partial class ProtocolBase : RabbitMQ.Client.Impl.AbstractProtocolBase {
    protected ProtocolBase() { }
    public override bool CanSendWhileClosed(RabbitMQ.Client.Impl.Command cmd) { return default(bool); }
    public override void CreateChannelClose(ushort reasonCode, string reasonText, out RabbitMQ.Client.Impl.Command request, out int replyClassId, out int replyMethodId) { request = default(RabbitMQ.Client.Impl.Command); replyClassId = default(int); replyMethodId = default(int); }
    public override RabbitMQ.Client.IConnection CreateConnection(RabbitMQ.Client.ConnectionFactory factory, bool insist, RabbitMQ.Client.Impl.IFrameHandler frameHandler) { return default(RabbitMQ.Client.IConnection); }
    public override void CreateConnectionClose(ushort reasonCode, string reasonText, out RabbitMQ.Client.Impl.Command request, out int replyClassId, out int replyMethodId) { request = default(RabbitMQ.Client.Impl.Command); replyClassId = default(int); replyMethodId = default(int); }
    public override RabbitMQ.Client.Impl.IFrameHandler CreateFrameHandler(RabbitMQ.Client.AmqpTcpEndpoint endpoint) { return default(RabbitMQ.Client.Impl.IFrameHandler); }
    public override RabbitMQ.Client.IModel CreateModel(RabbitMQ.Client.Impl.ISession session) { return default(RabbitMQ.Client.IModel); }
  }
  public partial class QueueBind : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IQueueBind, RabbitMQ.Client.IMethod {
    public const int ClassId = 50;
    public System.Collections.IDictionary m_arguments;
    public string m_exchange;
    public bool m_nowait;
    public string m_queue;
    public string m_routingKey;
    public ushort m_ticket;
    public const int MethodId = 20;
    public QueueBind() { }
    public QueueBind(ushort initTicket, string initQueue, string initExchange, string initRoutingKey, bool initNowait, System.Collections.IDictionary initArguments) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    System.Collections.IDictionary RabbitMQ.Client.Framing.v0_8.IQueueBind.Arguments { get { return default(System.Collections.IDictionary); } }
    string RabbitMQ.Client.Framing.v0_8.IQueueBind.Exchange { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_8.IQueueBind.Nowait { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_8.IQueueBind.Queue { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8.IQueueBind.RoutingKey { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_8.IQueueBind.Ticket { get { return default(ushort); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class QueueBindOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IQueueBindOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 50;
    public const int MethodId = 21;
    public QueueBindOk() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class QueueDeclare : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IQueueDeclare, RabbitMQ.Client.IMethod {
    public const int ClassId = 50;
    public System.Collections.IDictionary m_arguments;
    public bool m_autoDelete;
    public bool m_durable;
    public bool m_exclusive;
    public bool m_nowait;
    public bool m_passive;
    public string m_queue;
    public ushort m_ticket;
    public const int MethodId = 10;
    public QueueDeclare() { }
    public QueueDeclare(ushort initTicket, string initQueue, bool initPassive, bool initDurable, bool initExclusive, bool initAutoDelete, bool initNowait, System.Collections.IDictionary initArguments) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    System.Collections.IDictionary RabbitMQ.Client.Framing.v0_8.IQueueDeclare.Arguments { get { return default(System.Collections.IDictionary); } }
    bool RabbitMQ.Client.Framing.v0_8.IQueueDeclare.AutoDelete { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_8.IQueueDeclare.Durable { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_8.IQueueDeclare.Exclusive { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_8.IQueueDeclare.Nowait { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_8.IQueueDeclare.Passive { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_8.IQueueDeclare.Queue { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_8.IQueueDeclare.Ticket { get { return default(ushort); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class QueueDeclareOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IQueueDeclareOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 50;
    public uint m_consumerCount;
    public uint m_messageCount;
    public string m_queue;
    public const int MethodId = 11;
    public QueueDeclareOk() { }
    public QueueDeclareOk(string initQueue, uint initMessageCount, uint initConsumerCount) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    uint RabbitMQ.Client.Framing.v0_8.IQueueDeclareOk.ConsumerCount { get { return default(uint); } }
    uint RabbitMQ.Client.Framing.v0_8.IQueueDeclareOk.MessageCount { get { return default(uint); } }
    string RabbitMQ.Client.Framing.v0_8.IQueueDeclareOk.Queue { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class QueueDelete : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IQueueDelete, RabbitMQ.Client.IMethod {
    public const int ClassId = 50;
    public bool m_ifEmpty;
    public bool m_ifUnused;
    public bool m_nowait;
    public string m_queue;
    public ushort m_ticket;
    public const int MethodId = 40;
    public QueueDelete() { }
    public QueueDelete(ushort initTicket, string initQueue, bool initIfUnused, bool initIfEmpty, bool initNowait) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_8.IQueueDelete.IfEmpty { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_8.IQueueDelete.IfUnused { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_8.IQueueDelete.Nowait { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_8.IQueueDelete.Queue { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_8.IQueueDelete.Ticket { get { return default(ushort); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class QueueDeleteOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IQueueDeleteOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 50;
    public uint m_messageCount;
    public const int MethodId = 41;
    public QueueDeleteOk() { }
    public QueueDeleteOk(uint initMessageCount) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    uint RabbitMQ.Client.Framing.v0_8.IQueueDeleteOk.MessageCount { get { return default(uint); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class QueuePurge : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IQueuePurge, RabbitMQ.Client.IMethod {
    public const int ClassId = 50;
    public bool m_nowait;
    public string m_queue;
    public ushort m_ticket;
    public const int MethodId = 30;
    public QueuePurge() { }
    public QueuePurge(ushort initTicket, string initQueue, bool initNowait) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_8.IQueuePurge.Nowait { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_8.IQueuePurge.Queue { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_8.IQueuePurge.Ticket { get { return default(ushort); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class QueuePurgeOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IQueuePurgeOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 50;
    public uint m_messageCount;
    public const int MethodId = 31;
    public QueuePurgeOk() { }
    public QueuePurgeOk(uint initMessageCount) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    uint RabbitMQ.Client.Framing.v0_8.IQueuePurgeOk.MessageCount { get { return default(uint); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class QueueUnbind : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IQueueUnbind, RabbitMQ.Client.IMethod {
    public const int ClassId = 50;
    public System.Collections.IDictionary m_arguments;
    public string m_exchange;
    public string m_queue;
    public string m_routingKey;
    public ushort m_ticket;
    public const int MethodId = 50;
    public QueueUnbind() { }
    public QueueUnbind(ushort initTicket, string initQueue, string initExchange, string initRoutingKey, System.Collections.IDictionary initArguments) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    System.Collections.IDictionary RabbitMQ.Client.Framing.v0_8.IQueueUnbind.Arguments { get { return default(System.Collections.IDictionary); } }
    string RabbitMQ.Client.Framing.v0_8.IQueueUnbind.Exchange { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8.IQueueUnbind.Queue { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8.IQueueUnbind.RoutingKey { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_8.IQueueUnbind.Ticket { get { return default(ushort); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class QueueUnbindOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IQueueUnbindOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 50;
    public const int MethodId = 51;
    public QueueUnbindOk() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class StreamCancel : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IStreamCancel, RabbitMQ.Client.IMethod {
    public const int ClassId = 80;
    public string m_consumerTag;
    public bool m_nowait;
    public const int MethodId = 30;
    public StreamCancel() { }
    public StreamCancel(string initConsumerTag, bool initNowait) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8.IStreamCancel.ConsumerTag { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_8.IStreamCancel.Nowait { get { return default(bool); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class StreamCancelOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IStreamCancelOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 80;
    public string m_consumerTag;
    public const int MethodId = 31;
    public StreamCancelOk() { }
    public StreamCancelOk(string initConsumerTag) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8.IStreamCancelOk.ConsumerTag { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class StreamConsume : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IStreamConsume, RabbitMQ.Client.IMethod {
    public const int ClassId = 80;
    public string m_consumerTag;
    public bool m_exclusive;
    public bool m_noLocal;
    public bool m_nowait;
    public string m_queue;
    public ushort m_ticket;
    public const int MethodId = 20;
    public StreamConsume() { }
    public StreamConsume(ushort initTicket, string initQueue, string initConsumerTag, bool initNoLocal, bool initExclusive, bool initNowait) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8.IStreamConsume.ConsumerTag { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_8.IStreamConsume.Exclusive { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_8.IStreamConsume.NoLocal { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_8.IStreamConsume.Nowait { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_8.IStreamConsume.Queue { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_8.IStreamConsume.Ticket { get { return default(ushort); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class StreamConsumeOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IStreamConsumeOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 80;
    public string m_consumerTag;
    public const int MethodId = 21;
    public StreamConsumeOk() { }
    public StreamConsumeOk(string initConsumerTag) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8.IStreamConsumeOk.ConsumerTag { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class StreamDeliver : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IStreamDeliver, RabbitMQ.Client.IMethod {
    public const int ClassId = 80;
    public string m_consumerTag;
    public ulong m_deliveryTag;
    public string m_exchange;
    public string m_queue;
    public const int MethodId = 60;
    public StreamDeliver() { }
    public StreamDeliver(string initConsumerTag, ulong initDeliveryTag, string initExchange, string initQueue) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8.IStreamDeliver.ConsumerTag { get { return default(string); } }
    ulong RabbitMQ.Client.Framing.v0_8.IStreamDeliver.DeliveryTag { get { return default(ulong); } }
    string RabbitMQ.Client.Framing.v0_8.IStreamDeliver.Exchange { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8.IStreamDeliver.Queue { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class StreamPublish : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IStreamPublish, RabbitMQ.Client.IMethod {
    public const int ClassId = 80;
    public string m_exchange;
    public bool m_immediate;
    public bool m_mandatory;
    public string m_routingKey;
    public ushort m_ticket;
    public const int MethodId = 40;
    public StreamPublish() { }
    public StreamPublish(ushort initTicket, string initExchange, string initRoutingKey, bool initMandatory, bool initImmediate) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8.IStreamPublish.Exchange { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_8.IStreamPublish.Immediate { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_8.IStreamPublish.Mandatory { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_8.IStreamPublish.RoutingKey { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_8.IStreamPublish.Ticket { get { return default(ushort); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class StreamQos : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IStreamQos, RabbitMQ.Client.IMethod {
    public const int ClassId = 80;
    public uint m_consumeRate;
    public bool m_global;
    public ushort m_prefetchCount;
    public uint m_prefetchSize;
    public const int MethodId = 10;
    public StreamQos() { }
    public StreamQos(uint initPrefetchSize, ushort initPrefetchCount, uint initConsumeRate, bool initGlobal) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    uint RabbitMQ.Client.Framing.v0_8.IStreamQos.ConsumeRate { get { return default(uint); } }
    bool RabbitMQ.Client.Framing.v0_8.IStreamQos.Global { get { return default(bool); } }
    ushort RabbitMQ.Client.Framing.v0_8.IStreamQos.PrefetchCount { get { return default(ushort); } }
    uint RabbitMQ.Client.Framing.v0_8.IStreamQos.PrefetchSize { get { return default(uint); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class StreamQosOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IStreamQosOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 80;
    public const int MethodId = 11;
    public StreamQosOk() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class StreamReturn : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IStreamReturn, RabbitMQ.Client.IMethod {
    public const int ClassId = 80;
    public string m_exchange;
    public ushort m_replyCode;
    public string m_replyText;
    public string m_routingKey;
    public const int MethodId = 50;
    public StreamReturn() { }
    public StreamReturn(ushort initReplyCode, string initReplyText, string initExchange, string initRoutingKey) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8.IStreamReturn.Exchange { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_8.IStreamReturn.ReplyCode { get { return default(ushort); } }
    string RabbitMQ.Client.Framing.v0_8.IStreamReturn.ReplyText { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8.IStreamReturn.RoutingKey { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class TestContent : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.ITestContent, RabbitMQ.Client.IMethod {
    public const int ClassId = 120;
    public const int MethodId = 40;
    public TestContent() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class TestContentOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.ITestContentOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 120;
    public uint m_contentChecksum;
    public const int MethodId = 41;
    public TestContentOk() { }
    public TestContentOk(uint initContentChecksum) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    uint RabbitMQ.Client.Framing.v0_8.ITestContentOk.ContentChecksum { get { return default(uint); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class TestInteger : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.ITestInteger, RabbitMQ.Client.IMethod {
    public const int ClassId = 120;
    public byte m_integer1;
    public ushort m_integer2;
    public uint m_integer3;
    public ulong m_integer4;
    public byte m_operation;
    public const int MethodId = 10;
    public TestInteger() { }
    public TestInteger(byte initInteger1, ushort initInteger2, uint initInteger3, ulong initInteger4, byte initOperation) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    byte RabbitMQ.Client.Framing.v0_8.ITestInteger.Integer1 { get { return default(byte); } }
    ushort RabbitMQ.Client.Framing.v0_8.ITestInteger.Integer2 { get { return default(ushort); } }
    uint RabbitMQ.Client.Framing.v0_8.ITestInteger.Integer3 { get { return default(uint); } }
    ulong RabbitMQ.Client.Framing.v0_8.ITestInteger.Integer4 { get { return default(ulong); } }
    byte RabbitMQ.Client.Framing.v0_8.ITestInteger.Operation { get { return default(byte); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class TestIntegerOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.ITestIntegerOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 120;
    public ulong m_result;
    public const int MethodId = 11;
    public TestIntegerOk() { }
    public TestIntegerOk(ulong initResult) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    ulong RabbitMQ.Client.Framing.v0_8.ITestIntegerOk.Result { get { return default(ulong); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class TestString : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.ITestString, RabbitMQ.Client.IMethod {
    public const int ClassId = 120;
    public byte m_operation;
    public string m_string1;
    public System.Byte[] m_string2;
    public const int MethodId = 20;
    public TestString() { }
    public TestString(string initString1, System.Byte[] initString2, byte initOperation) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    byte RabbitMQ.Client.Framing.v0_8.ITestString.Operation { get { return default(byte); } }
    string RabbitMQ.Client.Framing.v0_8.ITestString.String1 { get { return default(string); } }
    System.Byte[] RabbitMQ.Client.Framing.v0_8.ITestString.String2 { get { return default(System.Byte[]); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class TestStringOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.ITestStringOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 120;
    public System.Byte[] m_result;
    public const int MethodId = 21;
    public TestStringOk() { }
    public TestStringOk(System.Byte[] initResult) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    System.Byte[] RabbitMQ.Client.Framing.v0_8.ITestStringOk.Result { get { return default(System.Byte[]); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class TestTable : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.ITestTable, RabbitMQ.Client.IMethod {
    public const int ClassId = 120;
    public byte m_integerOp;
    public byte m_stringOp;
    public System.Collections.IDictionary m_table;
    public const int MethodId = 30;
    public TestTable() { }
    public TestTable(System.Collections.IDictionary initTable, byte initIntegerOp, byte initStringOp) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    byte RabbitMQ.Client.Framing.v0_8.ITestTable.IntegerOp { get { return default(byte); } }
    byte RabbitMQ.Client.Framing.v0_8.ITestTable.StringOp { get { return default(byte); } }
    System.Collections.IDictionary RabbitMQ.Client.Framing.v0_8.ITestTable.Table { get { return default(System.Collections.IDictionary); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class TestTableOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.ITestTableOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 120;
    public ulong m_integerResult;
    public System.Byte[] m_stringResult;
    public const int MethodId = 31;
    public TestTableOk() { }
    public TestTableOk(ulong initIntegerResult, System.Byte[] initStringResult) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    ulong RabbitMQ.Client.Framing.v0_8.ITestTableOk.IntegerResult { get { return default(ulong); } }
    System.Byte[] RabbitMQ.Client.Framing.v0_8.ITestTableOk.StringResult { get { return default(System.Byte[]); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class TunnelRequest : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.ITunnelRequest, RabbitMQ.Client.IMethod {
    public const int ClassId = 110;
    public System.Collections.IDictionary m_metaData;
    public const int MethodId = 10;
    public TunnelRequest() { }
    public TunnelRequest(System.Collections.IDictionary initMetaData) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    System.Collections.IDictionary RabbitMQ.Client.Framing.v0_8.ITunnelRequest.MetaData { get { return default(System.Collections.IDictionary); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class TxCommit : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.ITxCommit, RabbitMQ.Client.IMethod {
    public const int ClassId = 90;
    public const int MethodId = 20;
    public TxCommit() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class TxCommitOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.ITxCommitOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 90;
    public const int MethodId = 21;
    public TxCommitOk() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class TxRollback : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.ITxRollback, RabbitMQ.Client.IMethod {
    public const int ClassId = 90;
    public const int MethodId = 30;
    public TxRollback() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class TxRollbackOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.ITxRollbackOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 90;
    public const int MethodId = 31;
    public TxRollbackOk() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class TxSelect : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.ITxSelect, RabbitMQ.Client.IMethod {
    public const int ClassId = 90;
    public const int MethodId = 10;
    public TxSelect() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class TxSelectOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.ITxSelectOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 90;
    public const int MethodId = 11;
    public TxSelectOk() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
}
namespace RabbitMQ.Client.Framing.Impl.v0_8qpid {
  public partial class AccessRequest : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IAccessRequest, RabbitMQ.Client.IMethod {
    public const int ClassId = 30;
    public bool m_active;
    public bool m_exclusive;
    public bool m_passive;
    public bool m_read;
    public string m_realm;
    public bool m_write;
    public const int MethodId = 10;
    public AccessRequest() { }
    public AccessRequest(string initRealm, bool initExclusive, bool initPassive, bool initActive, bool initWrite, bool initRead) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IAccessRequest.Active { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IAccessRequest.Exclusive { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IAccessRequest.Passive { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IAccessRequest.Read { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IAccessRequest.Realm { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IAccessRequest.Write { get { return default(bool); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class AccessRequestOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IAccessRequestOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 30;
    public ushort m_ticket;
    public const int MethodId = 11;
    public AccessRequestOk() { }
    public AccessRequestOk(ushort initTicket) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_8qpid.IAccessRequestOk.Ticket { get { return default(ushort); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class BasicAck : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IBasicAck, RabbitMQ.Client.IMethod {
    public const int ClassId = 60;
    public ulong m_deliveryTag;
    public bool m_multiple;
    public const int MethodId = 80;
    public BasicAck() { }
    public BasicAck(ulong initDeliveryTag, bool initMultiple) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    ulong RabbitMQ.Client.Framing.v0_8qpid.IBasicAck.DeliveryTag { get { return default(ulong); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IBasicAck.Multiple { get { return default(bool); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class BasicCancel : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IBasicCancel, RabbitMQ.Client.IMethod {
    public const int ClassId = 60;
    public string m_consumerTag;
    public bool m_nowait;
    public const int MethodId = 30;
    public BasicCancel() { }
    public BasicCancel(string initConsumerTag, bool initNowait) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IBasicCancel.ConsumerTag { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IBasicCancel.Nowait { get { return default(bool); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class BasicCancelOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IBasicCancelOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 60;
    public string m_consumerTag;
    public const int MethodId = 31;
    public BasicCancelOk() { }
    public BasicCancelOk(string initConsumerTag) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IBasicCancelOk.ConsumerTag { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class BasicConsume : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IBasicConsume, RabbitMQ.Client.IMethod {
    public const int ClassId = 60;
    public System.Collections.IDictionary m_arguments;
    public string m_consumerTag;
    public bool m_exclusive;
    public bool m_noAck;
    public bool m_noLocal;
    public bool m_nowait;
    public string m_queue;
    public ushort m_ticket;
    public const int MethodId = 20;
    public BasicConsume() { }
    public BasicConsume(ushort initTicket, string initQueue, string initConsumerTag, bool initNoLocal, bool initNoAck, bool initExclusive, bool initNowait, System.Collections.IDictionary initArguments) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    System.Collections.IDictionary RabbitMQ.Client.Framing.v0_8qpid.IBasicConsume.Arguments { get { return default(System.Collections.IDictionary); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IBasicConsume.ConsumerTag { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IBasicConsume.Exclusive { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IBasicConsume.NoAck { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IBasicConsume.NoLocal { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IBasicConsume.Nowait { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IBasicConsume.Queue { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_8qpid.IBasicConsume.Ticket { get { return default(ushort); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class BasicConsumeOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IBasicConsumeOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 60;
    public string m_consumerTag;
    public const int MethodId = 21;
    public BasicConsumeOk() { }
    public BasicConsumeOk(string initConsumerTag) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IBasicConsumeOk.ConsumerTag { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class BasicDeliver : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IBasicDeliver, RabbitMQ.Client.IMethod {
    public const int ClassId = 60;
    public string m_consumerTag;
    public ulong m_deliveryTag;
    public string m_exchange;
    public bool m_redelivered;
    public string m_routingKey;
    public const int MethodId = 60;
    public BasicDeliver() { }
    public BasicDeliver(string initConsumerTag, ulong initDeliveryTag, bool initRedelivered, string initExchange, string initRoutingKey) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IBasicDeliver.ConsumerTag { get { return default(string); } }
    ulong RabbitMQ.Client.Framing.v0_8qpid.IBasicDeliver.DeliveryTag { get { return default(ulong); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IBasicDeliver.Exchange { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IBasicDeliver.Redelivered { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IBasicDeliver.RoutingKey { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class BasicGet : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IBasicGet, RabbitMQ.Client.IMethod {
    public const int ClassId = 60;
    public bool m_noAck;
    public string m_queue;
    public ushort m_ticket;
    public const int MethodId = 70;
    public BasicGet() { }
    public BasicGet(ushort initTicket, string initQueue, bool initNoAck) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IBasicGet.NoAck { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IBasicGet.Queue { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_8qpid.IBasicGet.Ticket { get { return default(ushort); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class BasicGetEmpty : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IBasicGetEmpty, RabbitMQ.Client.IMethod {
    public const int ClassId = 60;
    public string m_clusterId;
    public const int MethodId = 72;
    public BasicGetEmpty() { }
    public BasicGetEmpty(string initClusterId) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IBasicGetEmpty.ClusterId { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class BasicGetOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IBasicGetOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 60;
    public ulong m_deliveryTag;
    public string m_exchange;
    public uint m_messageCount;
    public bool m_redelivered;
    public string m_routingKey;
    public const int MethodId = 71;
    public BasicGetOk() { }
    public BasicGetOk(ulong initDeliveryTag, bool initRedelivered, string initExchange, string initRoutingKey, uint initMessageCount) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    ulong RabbitMQ.Client.Framing.v0_8qpid.IBasicGetOk.DeliveryTag { get { return default(ulong); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IBasicGetOk.Exchange { get { return default(string); } }
    uint RabbitMQ.Client.Framing.v0_8qpid.IBasicGetOk.MessageCount { get { return default(uint); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IBasicGetOk.Redelivered { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IBasicGetOk.RoutingKey { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class BasicPublish : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IBasicPublish, RabbitMQ.Client.IMethod {
    public const int ClassId = 60;
    public string m_exchange;
    public bool m_immediate;
    public bool m_mandatory;
    public string m_routingKey;
    public ushort m_ticket;
    public const int MethodId = 40;
    public BasicPublish() { }
    public BasicPublish(ushort initTicket, string initExchange, string initRoutingKey, bool initMandatory, bool initImmediate) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IBasicPublish.Exchange { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IBasicPublish.Immediate { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IBasicPublish.Mandatory { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IBasicPublish.RoutingKey { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_8qpid.IBasicPublish.Ticket { get { return default(ushort); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class BasicQos : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IBasicQos, RabbitMQ.Client.IMethod {
    public const int ClassId = 60;
    public bool m_global;
    public ushort m_prefetchCount;
    public uint m_prefetchSize;
    public const int MethodId = 10;
    public BasicQos() { }
    public BasicQos(uint initPrefetchSize, ushort initPrefetchCount, bool initGlobal) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IBasicQos.Global { get { return default(bool); } }
    ushort RabbitMQ.Client.Framing.v0_8qpid.IBasicQos.PrefetchCount { get { return default(ushort); } }
    uint RabbitMQ.Client.Framing.v0_8qpid.IBasicQos.PrefetchSize { get { return default(uint); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class BasicQosOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IBasicQosOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 60;
    public const int MethodId = 11;
    public BasicQosOk() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class BasicRecover : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IBasicRecover, RabbitMQ.Client.IMethod {
    public const int ClassId = 60;
    public bool m_requeue;
    public const int MethodId = 100;
    public BasicRecover() { }
    public BasicRecover(bool initRequeue) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IBasicRecover.Requeue { get { return default(bool); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class BasicRecoverOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IBasicRecoverOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 60;
    public const int MethodId = 101;
    public BasicRecoverOk() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class BasicReject : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IBasicReject, RabbitMQ.Client.IMethod {
    public const int ClassId = 60;
    public ulong m_deliveryTag;
    public bool m_requeue;
    public const int MethodId = 90;
    public BasicReject() { }
    public BasicReject(ulong initDeliveryTag, bool initRequeue) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    ulong RabbitMQ.Client.Framing.v0_8qpid.IBasicReject.DeliveryTag { get { return default(ulong); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IBasicReject.Requeue { get { return default(bool); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class BasicReturn : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IBasicReturn, RabbitMQ.Client.IMethod {
    public const int ClassId = 60;
    public string m_exchange;
    public ushort m_replyCode;
    public string m_replyText;
    public string m_routingKey;
    public const int MethodId = 50;
    public BasicReturn() { }
    public BasicReturn(ushort initReplyCode, string initReplyText, string initExchange, string initRoutingKey) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IBasicReturn.Exchange { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_8qpid.IBasicReturn.ReplyCode { get { return default(ushort); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IBasicReturn.ReplyText { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IBasicReturn.RoutingKey { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ChannelAlert : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IChannelAlert, RabbitMQ.Client.IMethod {
    public const int ClassId = 20;
    public System.Collections.IDictionary m_details;
    public ushort m_replyCode;
    public string m_replyText;
    public const int MethodId = 30;
    public ChannelAlert() { }
    public ChannelAlert(ushort initReplyCode, string initReplyText, System.Collections.IDictionary initDetails) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    System.Collections.IDictionary RabbitMQ.Client.Framing.v0_8qpid.IChannelAlert.Details { get { return default(System.Collections.IDictionary); } }
    ushort RabbitMQ.Client.Framing.v0_8qpid.IChannelAlert.ReplyCode { get { return default(ushort); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IChannelAlert.ReplyText { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ChannelClose : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IChannelClose, RabbitMQ.Client.IMethod {
    public const int ClassId = 20;
    public ushort m_classId;
    public ushort m_methodId;
    public ushort m_replyCode;
    public string m_replyText;
    public const int MethodId = 40;
    public ChannelClose() { }
    public ChannelClose(ushort initReplyCode, string initReplyText, ushort initClassId, ushort initMethodId) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_8qpid.IChannelClose.ClassId { get { return default(ushort); } }
    ushort RabbitMQ.Client.Framing.v0_8qpid.IChannelClose.MethodId { get { return default(ushort); } }
    ushort RabbitMQ.Client.Framing.v0_8qpid.IChannelClose.ReplyCode { get { return default(ushort); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IChannelClose.ReplyText { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ChannelCloseOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IChannelCloseOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 20;
    public const int MethodId = 41;
    public ChannelCloseOk() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ChannelFlow : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IChannelFlow, RabbitMQ.Client.IMethod {
    public const int ClassId = 20;
    public bool m_active;
    public const int MethodId = 20;
    public ChannelFlow() { }
    public ChannelFlow(bool initActive) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IChannelFlow.Active { get { return default(bool); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ChannelFlowOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IChannelFlowOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 20;
    public bool m_active;
    public const int MethodId = 21;
    public ChannelFlowOk() { }
    public ChannelFlowOk(bool initActive) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IChannelFlowOk.Active { get { return default(bool); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ChannelOpen : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IChannelOpen, RabbitMQ.Client.IMethod {
    public const int ClassId = 20;
    public string m_outOfBand;
    public const int MethodId = 10;
    public ChannelOpen() { }
    public ChannelOpen(string initOutOfBand) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IChannelOpen.OutOfBand { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ChannelOpenOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IChannelOpenOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 20;
    public const int MethodId = 11;
    public ChannelOpenOk() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public enum ClassId {
    Access = 30,
    Basic = 60,
    Channel = 20,
    Connection = 10,
    Dtx = 100,
    Exchange = 40,
    File = 70,
    Invalid = -1,
    Queue = 50,
    Stream = 80,
    Test = 120,
    Tunnel = 110,
    Tx = 90,
  }
  public partial class Connection : RabbitMQ.Client.Impl.ConnectionBase {
    public Connection(RabbitMQ.Client.ConnectionFactory factory, bool insist, RabbitMQ.Client.Impl.IFrameHandler frameHandler) : base (default(RabbitMQ.Client.ConnectionFactory), default(bool), default(RabbitMQ.Client.Impl.IFrameHandler)) { }
  }
  public partial class ConnectionClose : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IConnectionClose, RabbitMQ.Client.IMethod {
    public const int ClassId = 10;
    public ushort m_classId;
    public ushort m_methodId;
    public ushort m_replyCode;
    public string m_replyText;
    public const int MethodId = 60;
    public ConnectionClose() { }
    public ConnectionClose(ushort initReplyCode, string initReplyText, ushort initClassId, ushort initMethodId) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_8qpid.IConnectionClose.ClassId { get { return default(ushort); } }
    ushort RabbitMQ.Client.Framing.v0_8qpid.IConnectionClose.MethodId { get { return default(ushort); } }
    ushort RabbitMQ.Client.Framing.v0_8qpid.IConnectionClose.ReplyCode { get { return default(ushort); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IConnectionClose.ReplyText { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ConnectionCloseOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IConnectionCloseOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 10;
    public const int MethodId = 61;
    public ConnectionCloseOk() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ConnectionOpen : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IConnectionOpen, RabbitMQ.Client.IMethod {
    public const int ClassId = 10;
    public string m_capabilities;
    public bool m_insist;
    public string m_virtualHost;
    public const int MethodId = 40;
    public ConnectionOpen() { }
    public ConnectionOpen(string initVirtualHost, string initCapabilities, bool initInsist) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IConnectionOpen.Capabilities { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IConnectionOpen.Insist { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IConnectionOpen.VirtualHost { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ConnectionOpenOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IConnectionOpenOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 10;
    public string m_knownHosts;
    public const int MethodId = 41;
    public ConnectionOpenOk() { }
    public ConnectionOpenOk(string initKnownHosts) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IConnectionOpenOk.KnownHosts { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ConnectionRedirect : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IConnectionRedirect, RabbitMQ.Client.IMethod {
    public const int ClassId = 10;
    public string m_host;
    public string m_knownHosts;
    public const int MethodId = 50;
    public ConnectionRedirect() { }
    public ConnectionRedirect(string initHost, string initKnownHosts) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IConnectionRedirect.Host { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IConnectionRedirect.KnownHosts { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ConnectionSecure : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IConnectionSecure, RabbitMQ.Client.IMethod {
    public const int ClassId = 10;
    public System.Byte[] m_challenge;
    public const int MethodId = 20;
    public ConnectionSecure() { }
    public ConnectionSecure(System.Byte[] initChallenge) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    System.Byte[] RabbitMQ.Client.Framing.v0_8qpid.IConnectionSecure.Challenge { get { return default(System.Byte[]); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ConnectionSecureOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IConnectionSecureOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 10;
    public System.Byte[] m_response;
    public const int MethodId = 21;
    public ConnectionSecureOk() { }
    public ConnectionSecureOk(System.Byte[] initResponse) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    System.Byte[] RabbitMQ.Client.Framing.v0_8qpid.IConnectionSecureOk.Response { get { return default(System.Byte[]); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ConnectionStart : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IConnectionStart, RabbitMQ.Client.IMethod {
    public const int ClassId = 10;
    public System.Byte[] m_locales;
    public System.Byte[] m_mechanisms;
    public System.Collections.IDictionary m_serverProperties;
    public byte m_versionMajor;
    public byte m_versionMinor;
    public const int MethodId = 10;
    public ConnectionStart() { }
    public ConnectionStart(byte initVersionMajor, byte initVersionMinor, System.Collections.IDictionary initServerProperties, System.Byte[] initMechanisms, System.Byte[] initLocales) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    System.Byte[] RabbitMQ.Client.Framing.v0_8qpid.IConnectionStart.Locales { get { return default(System.Byte[]); } }
    System.Byte[] RabbitMQ.Client.Framing.v0_8qpid.IConnectionStart.Mechanisms { get { return default(System.Byte[]); } }
    System.Collections.IDictionary RabbitMQ.Client.Framing.v0_8qpid.IConnectionStart.ServerProperties { get { return default(System.Collections.IDictionary); } }
    byte RabbitMQ.Client.Framing.v0_8qpid.IConnectionStart.VersionMajor { get { return default(byte); } }
    byte RabbitMQ.Client.Framing.v0_8qpid.IConnectionStart.VersionMinor { get { return default(byte); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ConnectionStartOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IConnectionStartOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 10;
    public System.Collections.IDictionary m_clientProperties;
    public string m_locale;
    public string m_mechanism;
    public System.Byte[] m_response;
    public const int MethodId = 11;
    public ConnectionStartOk() { }
    public ConnectionStartOk(System.Collections.IDictionary initClientProperties, string initMechanism, System.Byte[] initResponse, string initLocale) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    System.Collections.IDictionary RabbitMQ.Client.Framing.v0_8qpid.IConnectionStartOk.ClientProperties { get { return default(System.Collections.IDictionary); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IConnectionStartOk.Locale { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IConnectionStartOk.Mechanism { get { return default(string); } }
    System.Byte[] RabbitMQ.Client.Framing.v0_8qpid.IConnectionStartOk.Response { get { return default(System.Byte[]); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ConnectionTune : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IConnectionTune, RabbitMQ.Client.IMethod {
    public const int ClassId = 10;
    public ushort m_channelMax;
    public uint m_frameMax;
    public ushort m_heartbeat;
    public const int MethodId = 30;
    public ConnectionTune() { }
    public ConnectionTune(ushort initChannelMax, uint initFrameMax, ushort initHeartbeat) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_8qpid.IConnectionTune.ChannelMax { get { return default(ushort); } }
    uint RabbitMQ.Client.Framing.v0_8qpid.IConnectionTune.FrameMax { get { return default(uint); } }
    ushort RabbitMQ.Client.Framing.v0_8qpid.IConnectionTune.Heartbeat { get { return default(ushort); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ConnectionTuneOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IConnectionTuneOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 10;
    public ushort m_channelMax;
    public uint m_frameMax;
    public ushort m_heartbeat;
    public const int MethodId = 31;
    public ConnectionTuneOk() { }
    public ConnectionTuneOk(ushort initChannelMax, uint initFrameMax, ushort initHeartbeat) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_8qpid.IConnectionTuneOk.ChannelMax { get { return default(ushort); } }
    uint RabbitMQ.Client.Framing.v0_8qpid.IConnectionTuneOk.FrameMax { get { return default(uint); } }
    ushort RabbitMQ.Client.Framing.v0_8qpid.IConnectionTuneOk.Heartbeat { get { return default(ushort); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class DtxSelect : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IDtxSelect, RabbitMQ.Client.IMethod {
    public const int ClassId = 100;
    public const int MethodId = 10;
    public DtxSelect() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class DtxSelectOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IDtxSelectOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 100;
    public const int MethodId = 11;
    public DtxSelectOk() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class DtxStart : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IDtxStart, RabbitMQ.Client.IMethod {
    public const int ClassId = 100;
    public string m_dtxIdentifier;
    public const int MethodId = 20;
    public DtxStart() { }
    public DtxStart(string initDtxIdentifier) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IDtxStart.DtxIdentifier { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class DtxStartOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IDtxStartOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 100;
    public const int MethodId = 21;
    public DtxStartOk() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ExchangeBound : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IExchangeBound, RabbitMQ.Client.IMethod {
    public const int ClassId = 40;
    public string m_exchange;
    public string m_queue;
    public string m_routingKey;
    public const int MethodId = 22;
    public ExchangeBound() { }
    public ExchangeBound(string initExchange, string initRoutingKey, string initQueue) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IExchangeBound.Exchange { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IExchangeBound.Queue { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IExchangeBound.RoutingKey { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ExchangeBoundOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IExchangeBoundOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 40;
    public ushort m_replyCode;
    public string m_replyText;
    public const int MethodId = 23;
    public ExchangeBoundOk() { }
    public ExchangeBoundOk(ushort initReplyCode, string initReplyText) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_8qpid.IExchangeBoundOk.ReplyCode { get { return default(ushort); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IExchangeBoundOk.ReplyText { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ExchangeDeclare : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IExchangeDeclare, RabbitMQ.Client.IMethod {
    public const int ClassId = 40;
    public System.Collections.IDictionary m_arguments;
    public bool m_autoDelete;
    public bool m_durable;
    public string m_exchange;
    public bool m_internal;
    public bool m_nowait;
    public bool m_passive;
    public ushort m_ticket;
    public string m_type;
    public const int MethodId = 10;
    public ExchangeDeclare() { }
    public ExchangeDeclare(ushort initTicket, string initExchange, string initType, bool initPassive, bool initDurable, bool initAutoDelete, bool initInternal, bool initNowait, System.Collections.IDictionary initArguments) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    System.Collections.IDictionary RabbitMQ.Client.Framing.v0_8qpid.IExchangeDeclare.Arguments { get { return default(System.Collections.IDictionary); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IExchangeDeclare.AutoDelete { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IExchangeDeclare.Durable { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IExchangeDeclare.Exchange { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IExchangeDeclare.Internal { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IExchangeDeclare.Nowait { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IExchangeDeclare.Passive { get { return default(bool); } }
    ushort RabbitMQ.Client.Framing.v0_8qpid.IExchangeDeclare.Ticket { get { return default(ushort); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IExchangeDeclare.Type { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ExchangeDeclareOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IExchangeDeclareOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 40;
    public const int MethodId = 11;
    public ExchangeDeclareOk() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ExchangeDelete : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IExchangeDelete, RabbitMQ.Client.IMethod {
    public const int ClassId = 40;
    public string m_exchange;
    public bool m_ifUnused;
    public bool m_nowait;
    public ushort m_ticket;
    public const int MethodId = 20;
    public ExchangeDelete() { }
    public ExchangeDelete(ushort initTicket, string initExchange, bool initIfUnused, bool initNowait) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IExchangeDelete.Exchange { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IExchangeDelete.IfUnused { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IExchangeDelete.Nowait { get { return default(bool); } }
    ushort RabbitMQ.Client.Framing.v0_8qpid.IExchangeDelete.Ticket { get { return default(ushort); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ExchangeDeleteOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IExchangeDeleteOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 40;
    public const int MethodId = 21;
    public ExchangeDeleteOk() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class FileAck : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IFileAck, RabbitMQ.Client.IMethod {
    public const int ClassId = 70;
    public ulong m_deliveryTag;
    public bool m_multiple;
    public const int MethodId = 90;
    public FileAck() { }
    public FileAck(ulong initDeliveryTag, bool initMultiple) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    ulong RabbitMQ.Client.Framing.v0_8qpid.IFileAck.DeliveryTag { get { return default(ulong); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IFileAck.Multiple { get { return default(bool); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class FileCancel : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IFileCancel, RabbitMQ.Client.IMethod {
    public const int ClassId = 70;
    public string m_consumerTag;
    public bool m_nowait;
    public const int MethodId = 30;
    public FileCancel() { }
    public FileCancel(string initConsumerTag, bool initNowait) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IFileCancel.ConsumerTag { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IFileCancel.Nowait { get { return default(bool); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class FileCancelOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IFileCancelOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 70;
    public string m_consumerTag;
    public const int MethodId = 31;
    public FileCancelOk() { }
    public FileCancelOk(string initConsumerTag) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IFileCancelOk.ConsumerTag { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class FileConsume : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IFileConsume, RabbitMQ.Client.IMethod {
    public const int ClassId = 70;
    public string m_consumerTag;
    public bool m_exclusive;
    public bool m_noAck;
    public bool m_noLocal;
    public bool m_nowait;
    public string m_queue;
    public ushort m_ticket;
    public const int MethodId = 20;
    public FileConsume() { }
    public FileConsume(ushort initTicket, string initQueue, string initConsumerTag, bool initNoLocal, bool initNoAck, bool initExclusive, bool initNowait) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IFileConsume.ConsumerTag { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IFileConsume.Exclusive { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IFileConsume.NoAck { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IFileConsume.NoLocal { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IFileConsume.Nowait { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IFileConsume.Queue { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_8qpid.IFileConsume.Ticket { get { return default(ushort); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class FileConsumeOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IFileConsumeOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 70;
    public string m_consumerTag;
    public const int MethodId = 21;
    public FileConsumeOk() { }
    public FileConsumeOk(string initConsumerTag) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IFileConsumeOk.ConsumerTag { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class FileDeliver : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IFileDeliver, RabbitMQ.Client.IMethod {
    public const int ClassId = 70;
    public string m_consumerTag;
    public ulong m_deliveryTag;
    public string m_exchange;
    public string m_identifier;
    public bool m_redelivered;
    public string m_routingKey;
    public const int MethodId = 80;
    public FileDeliver() { }
    public FileDeliver(string initConsumerTag, ulong initDeliveryTag, bool initRedelivered, string initExchange, string initRoutingKey, string initIdentifier) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IFileDeliver.ConsumerTag { get { return default(string); } }
    ulong RabbitMQ.Client.Framing.v0_8qpid.IFileDeliver.DeliveryTag { get { return default(ulong); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IFileDeliver.Exchange { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IFileDeliver.Identifier { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IFileDeliver.Redelivered { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IFileDeliver.RoutingKey { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class FileOpen : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IFileOpen, RabbitMQ.Client.IMethod {
    public const int ClassId = 70;
    public ulong m_contentSize;
    public string m_identifier;
    public const int MethodId = 40;
    public FileOpen() { }
    public FileOpen(string initIdentifier, ulong initContentSize) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    ulong RabbitMQ.Client.Framing.v0_8qpid.IFileOpen.ContentSize { get { return default(ulong); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IFileOpen.Identifier { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class FileOpenOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IFileOpenOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 70;
    public ulong m_stagedSize;
    public const int MethodId = 41;
    public FileOpenOk() { }
    public FileOpenOk(ulong initStagedSize) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    ulong RabbitMQ.Client.Framing.v0_8qpid.IFileOpenOk.StagedSize { get { return default(ulong); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class FilePublish : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IFilePublish, RabbitMQ.Client.IMethod {
    public const int ClassId = 70;
    public string m_exchange;
    public string m_identifier;
    public bool m_immediate;
    public bool m_mandatory;
    public string m_routingKey;
    public ushort m_ticket;
    public const int MethodId = 60;
    public FilePublish() { }
    public FilePublish(ushort initTicket, string initExchange, string initRoutingKey, bool initMandatory, bool initImmediate, string initIdentifier) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IFilePublish.Exchange { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IFilePublish.Identifier { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IFilePublish.Immediate { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IFilePublish.Mandatory { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IFilePublish.RoutingKey { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_8qpid.IFilePublish.Ticket { get { return default(ushort); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class FileQos : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IFileQos, RabbitMQ.Client.IMethod {
    public const int ClassId = 70;
    public bool m_global;
    public ushort m_prefetchCount;
    public uint m_prefetchSize;
    public const int MethodId = 10;
    public FileQos() { }
    public FileQos(uint initPrefetchSize, ushort initPrefetchCount, bool initGlobal) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IFileQos.Global { get { return default(bool); } }
    ushort RabbitMQ.Client.Framing.v0_8qpid.IFileQos.PrefetchCount { get { return default(ushort); } }
    uint RabbitMQ.Client.Framing.v0_8qpid.IFileQos.PrefetchSize { get { return default(uint); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class FileQosOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IFileQosOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 70;
    public const int MethodId = 11;
    public FileQosOk() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class FileReject : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IFileReject, RabbitMQ.Client.IMethod {
    public const int ClassId = 70;
    public ulong m_deliveryTag;
    public bool m_requeue;
    public const int MethodId = 100;
    public FileReject() { }
    public FileReject(ulong initDeliveryTag, bool initRequeue) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    ulong RabbitMQ.Client.Framing.v0_8qpid.IFileReject.DeliveryTag { get { return default(ulong); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IFileReject.Requeue { get { return default(bool); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class FileReturn : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IFileReturn, RabbitMQ.Client.IMethod {
    public const int ClassId = 70;
    public string m_exchange;
    public ushort m_replyCode;
    public string m_replyText;
    public string m_routingKey;
    public const int MethodId = 70;
    public FileReturn() { }
    public FileReturn(ushort initReplyCode, string initReplyText, string initExchange, string initRoutingKey) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IFileReturn.Exchange { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_8qpid.IFileReturn.ReplyCode { get { return default(ushort); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IFileReturn.ReplyText { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IFileReturn.RoutingKey { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class FileStage : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IFileStage, RabbitMQ.Client.IMethod {
    public const int ClassId = 70;
    public const int MethodId = 50;
    public FileStage() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class Model : RabbitMQ.Client.Impl.ModelBase {
    public Model(RabbitMQ.Client.Impl.ISession session) : base (default(RabbitMQ.Client.Impl.ISession)) { }
    public override void _Private_BasicCancel(string consumerTag, bool nowait) { }
    public override void _Private_BasicConsume(string queue, string consumerTag, bool noLocal, bool noAck, bool exclusive, bool nowait, System.Collections.IDictionary filter) { }
    public override void _Private_BasicGet(string queue, bool noAck) { }
    public override void _Private_BasicPublish(string exchange, string routingKey, bool mandatory, bool immediate, RabbitMQ.Client.IBasicProperties basicProperties, System.Byte[] body) { }
    public override void _Private_ChannelClose(ushort replyCode, string replyText, ushort classId, ushort methodId) { }
    public override void _Private_ChannelCloseOk() { }
    public override void _Private_ChannelFlowOk() { }
    public override void _Private_ChannelOpen(string outOfBand) { }
    public override void _Private_ConnectionClose(ushort replyCode, string replyText, ushort classId, ushort methodId) { }
    public override void _Private_ConnectionCloseOk() { }
    public override void _Private_ConnectionOpen(string virtualHost, string capabilities, bool insist) { }
    public override void BasicAck(ulong deliveryTag, bool multiple) { }
    public override void BasicQos(uint prefetchSize, ushort prefetchCount, bool global) { }
    public override void BasicRecover(bool requeue) { }
    public override void BasicReject(ulong deliveryTag, bool requeue) { }
    public override void ChannelFlow(bool active) { }
    public override RabbitMQ.Client.Impl.ConnectionTuneDetails ConnectionStartOk(System.Collections.IDictionary clientProperties, string mechanism, System.Byte[] response, string locale) { return default(RabbitMQ.Client.Impl.ConnectionTuneDetails); }
    public override void ConnectionTuneOk(ushort channelMax, uint frameMax, ushort heartbeat) { }
    public override RabbitMQ.Client.IBasicProperties CreateBasicProperties() { return default(RabbitMQ.Client.IBasicProperties); }
    public override RabbitMQ.Client.IFileProperties CreateFileProperties() { return default(RabbitMQ.Client.IFileProperties); }
    public override RabbitMQ.Client.IStreamProperties CreateStreamProperties() { return default(RabbitMQ.Client.IStreamProperties); }
    public override bool DispatchAsynchronous(RabbitMQ.Client.Impl.Command cmd) { return default(bool); }
    public override void DtxSelect() { }
    public override void DtxStart(string dtxIdentifier) { }
    public override void ExchangeDeclare(string exchange, string type, bool passive, bool durable, bool autoDelete, bool @internal, bool nowait, System.Collections.IDictionary arguments) { }
    public override void ExchangeDelete(string exchange, bool ifUnused, bool nowait) { }
    public override void QueueBind(string queue, string exchange, string routingKey, bool nowait, System.Collections.IDictionary arguments) { }
    public override string QueueDeclare(string queue, bool passive, bool durable, bool exclusive, bool autoDelete, bool nowait, System.Collections.IDictionary arguments) { return default(string); }
    public override uint QueueDelete(string queue, bool ifUnused, bool ifEmpty, bool nowait) { return default(uint); }
    public override uint QueuePurge(string queue, bool nowait) { return default(uint); }
    public override void QueueUnbind(string queue, string exchange, string routingKey, System.Collections.IDictionary arguments) { }
    public override void TxCommit() { }
    public override void TxRollback() { }
    public override void TxSelect() { }
  }
  public abstract partial class ProtocolBase : RabbitMQ.Client.Impl.AbstractProtocolBase {
    protected ProtocolBase() { }
    public override bool CanSendWhileClosed(RabbitMQ.Client.Impl.Command cmd) { return default(bool); }
    public override void CreateChannelClose(ushort reasonCode, string reasonText, out RabbitMQ.Client.Impl.Command request, out int replyClassId, out int replyMethodId) { request = default(RabbitMQ.Client.Impl.Command); replyClassId = default(int); replyMethodId = default(int); }
    public override RabbitMQ.Client.IConnection CreateConnection(RabbitMQ.Client.ConnectionFactory factory, bool insist, RabbitMQ.Client.Impl.IFrameHandler frameHandler) { return default(RabbitMQ.Client.IConnection); }
    public override void CreateConnectionClose(ushort reasonCode, string reasonText, out RabbitMQ.Client.Impl.Command request, out int replyClassId, out int replyMethodId) { request = default(RabbitMQ.Client.Impl.Command); replyClassId = default(int); replyMethodId = default(int); }
    public override RabbitMQ.Client.Impl.IFrameHandler CreateFrameHandler(RabbitMQ.Client.AmqpTcpEndpoint endpoint) { return default(RabbitMQ.Client.Impl.IFrameHandler); }
    public override RabbitMQ.Client.IModel CreateModel(RabbitMQ.Client.Impl.ISession session) { return default(RabbitMQ.Client.IModel); }
  }
  public partial class QueueBind : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IQueueBind, RabbitMQ.Client.IMethod {
    public const int ClassId = 50;
    public System.Collections.IDictionary m_arguments;
    public string m_exchange;
    public bool m_nowait;
    public string m_queue;
    public string m_routingKey;
    public ushort m_ticket;
    public const int MethodId = 20;
    public QueueBind() { }
    public QueueBind(ushort initTicket, string initQueue, string initExchange, string initRoutingKey, bool initNowait, System.Collections.IDictionary initArguments) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    System.Collections.IDictionary RabbitMQ.Client.Framing.v0_8qpid.IQueueBind.Arguments { get { return default(System.Collections.IDictionary); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IQueueBind.Exchange { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IQueueBind.Nowait { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IQueueBind.Queue { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IQueueBind.RoutingKey { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_8qpid.IQueueBind.Ticket { get { return default(ushort); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class QueueBindOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IQueueBindOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 50;
    public const int MethodId = 21;
    public QueueBindOk() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class QueueDeclare : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IQueueDeclare, RabbitMQ.Client.IMethod {
    public const int ClassId = 50;
    public System.Collections.IDictionary m_arguments;
    public bool m_autoDelete;
    public bool m_durable;
    public bool m_exclusive;
    public bool m_nowait;
    public bool m_passive;
    public string m_queue;
    public ushort m_ticket;
    public const int MethodId = 10;
    public QueueDeclare() { }
    public QueueDeclare(ushort initTicket, string initQueue, bool initPassive, bool initDurable, bool initExclusive, bool initAutoDelete, bool initNowait, System.Collections.IDictionary initArguments) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    System.Collections.IDictionary RabbitMQ.Client.Framing.v0_8qpid.IQueueDeclare.Arguments { get { return default(System.Collections.IDictionary); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IQueueDeclare.AutoDelete { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IQueueDeclare.Durable { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IQueueDeclare.Exclusive { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IQueueDeclare.Nowait { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IQueueDeclare.Passive { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IQueueDeclare.Queue { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_8qpid.IQueueDeclare.Ticket { get { return default(ushort); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class QueueDeclareOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IQueueDeclareOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 50;
    public uint m_consumerCount;
    public uint m_messageCount;
    public string m_queue;
    public const int MethodId = 11;
    public QueueDeclareOk() { }
    public QueueDeclareOk(string initQueue, uint initMessageCount, uint initConsumerCount) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    uint RabbitMQ.Client.Framing.v0_8qpid.IQueueDeclareOk.ConsumerCount { get { return default(uint); } }
    uint RabbitMQ.Client.Framing.v0_8qpid.IQueueDeclareOk.MessageCount { get { return default(uint); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IQueueDeclareOk.Queue { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class QueueDelete : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IQueueDelete, RabbitMQ.Client.IMethod {
    public const int ClassId = 50;
    public bool m_ifEmpty;
    public bool m_ifUnused;
    public bool m_nowait;
    public string m_queue;
    public ushort m_ticket;
    public const int MethodId = 40;
    public QueueDelete() { }
    public QueueDelete(ushort initTicket, string initQueue, bool initIfUnused, bool initIfEmpty, bool initNowait) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IQueueDelete.IfEmpty { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IQueueDelete.IfUnused { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IQueueDelete.Nowait { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IQueueDelete.Queue { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_8qpid.IQueueDelete.Ticket { get { return default(ushort); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class QueueDeleteOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IQueueDeleteOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 50;
    public uint m_messageCount;
    public const int MethodId = 41;
    public QueueDeleteOk() { }
    public QueueDeleteOk(uint initMessageCount) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    uint RabbitMQ.Client.Framing.v0_8qpid.IQueueDeleteOk.MessageCount { get { return default(uint); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class QueuePurge : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IQueuePurge, RabbitMQ.Client.IMethod {
    public const int ClassId = 50;
    public bool m_nowait;
    public string m_queue;
    public ushort m_ticket;
    public const int MethodId = 30;
    public QueuePurge() { }
    public QueuePurge(ushort initTicket, string initQueue, bool initNowait) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IQueuePurge.Nowait { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IQueuePurge.Queue { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_8qpid.IQueuePurge.Ticket { get { return default(ushort); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class QueuePurgeOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IQueuePurgeOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 50;
    public uint m_messageCount;
    public const int MethodId = 31;
    public QueuePurgeOk() { }
    public QueuePurgeOk(uint initMessageCount) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    uint RabbitMQ.Client.Framing.v0_8qpid.IQueuePurgeOk.MessageCount { get { return default(uint); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class StreamCancel : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IStreamCancel, RabbitMQ.Client.IMethod {
    public const int ClassId = 80;
    public string m_consumerTag;
    public bool m_nowait;
    public const int MethodId = 30;
    public StreamCancel() { }
    public StreamCancel(string initConsumerTag, bool initNowait) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IStreamCancel.ConsumerTag { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IStreamCancel.Nowait { get { return default(bool); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class StreamCancelOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IStreamCancelOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 80;
    public string m_consumerTag;
    public const int MethodId = 31;
    public StreamCancelOk() { }
    public StreamCancelOk(string initConsumerTag) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IStreamCancelOk.ConsumerTag { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class StreamConsume : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IStreamConsume, RabbitMQ.Client.IMethod {
    public const int ClassId = 80;
    public string m_consumerTag;
    public bool m_exclusive;
    public bool m_noLocal;
    public bool m_nowait;
    public string m_queue;
    public ushort m_ticket;
    public const int MethodId = 20;
    public StreamConsume() { }
    public StreamConsume(ushort initTicket, string initQueue, string initConsumerTag, bool initNoLocal, bool initExclusive, bool initNowait) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IStreamConsume.ConsumerTag { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IStreamConsume.Exclusive { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IStreamConsume.NoLocal { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IStreamConsume.Nowait { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IStreamConsume.Queue { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_8qpid.IStreamConsume.Ticket { get { return default(ushort); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class StreamConsumeOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IStreamConsumeOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 80;
    public string m_consumerTag;
    public const int MethodId = 21;
    public StreamConsumeOk() { }
    public StreamConsumeOk(string initConsumerTag) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IStreamConsumeOk.ConsumerTag { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class StreamDeliver : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IStreamDeliver, RabbitMQ.Client.IMethod {
    public const int ClassId = 80;
    public string m_consumerTag;
    public ulong m_deliveryTag;
    public string m_exchange;
    public string m_queue;
    public const int MethodId = 60;
    public StreamDeliver() { }
    public StreamDeliver(string initConsumerTag, ulong initDeliveryTag, string initExchange, string initQueue) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IStreamDeliver.ConsumerTag { get { return default(string); } }
    ulong RabbitMQ.Client.Framing.v0_8qpid.IStreamDeliver.DeliveryTag { get { return default(ulong); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IStreamDeliver.Exchange { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IStreamDeliver.Queue { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class StreamPublish : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IStreamPublish, RabbitMQ.Client.IMethod {
    public const int ClassId = 80;
    public string m_exchange;
    public bool m_immediate;
    public bool m_mandatory;
    public string m_routingKey;
    public ushort m_ticket;
    public const int MethodId = 40;
    public StreamPublish() { }
    public StreamPublish(ushort initTicket, string initExchange, string initRoutingKey, bool initMandatory, bool initImmediate) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IStreamPublish.Exchange { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IStreamPublish.Immediate { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IStreamPublish.Mandatory { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IStreamPublish.RoutingKey { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_8qpid.IStreamPublish.Ticket { get { return default(ushort); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class StreamQos : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IStreamQos, RabbitMQ.Client.IMethod {
    public const int ClassId = 80;
    public uint m_consumeRate;
    public bool m_global;
    public ushort m_prefetchCount;
    public uint m_prefetchSize;
    public const int MethodId = 10;
    public StreamQos() { }
    public StreamQos(uint initPrefetchSize, ushort initPrefetchCount, uint initConsumeRate, bool initGlobal) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    uint RabbitMQ.Client.Framing.v0_8qpid.IStreamQos.ConsumeRate { get { return default(uint); } }
    bool RabbitMQ.Client.Framing.v0_8qpid.IStreamQos.Global { get { return default(bool); } }
    ushort RabbitMQ.Client.Framing.v0_8qpid.IStreamQos.PrefetchCount { get { return default(ushort); } }
    uint RabbitMQ.Client.Framing.v0_8qpid.IStreamQos.PrefetchSize { get { return default(uint); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class StreamQosOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IStreamQosOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 80;
    public const int MethodId = 11;
    public StreamQosOk() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class StreamReturn : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IStreamReturn, RabbitMQ.Client.IMethod {
    public const int ClassId = 80;
    public string m_exchange;
    public ushort m_replyCode;
    public string m_replyText;
    public string m_routingKey;
    public const int MethodId = 50;
    public StreamReturn() { }
    public StreamReturn(ushort initReplyCode, string initReplyText, string initExchange, string initRoutingKey) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IStreamReturn.Exchange { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_8qpid.IStreamReturn.ReplyCode { get { return default(ushort); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IStreamReturn.ReplyText { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_8qpid.IStreamReturn.RoutingKey { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class TestContent : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.ITestContent, RabbitMQ.Client.IMethod {
    public const int ClassId = 120;
    public const int MethodId = 40;
    public TestContent() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class TestContentOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.ITestContentOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 120;
    public uint m_contentChecksum;
    public const int MethodId = 41;
    public TestContentOk() { }
    public TestContentOk(uint initContentChecksum) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    uint RabbitMQ.Client.Framing.v0_8qpid.ITestContentOk.ContentChecksum { get { return default(uint); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class TestInteger : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.ITestInteger, RabbitMQ.Client.IMethod {
    public const int ClassId = 120;
    public byte m_integer1;
    public ushort m_integer2;
    public uint m_integer3;
    public ulong m_integer4;
    public byte m_operation;
    public const int MethodId = 10;
    public TestInteger() { }
    public TestInteger(byte initInteger1, ushort initInteger2, uint initInteger3, ulong initInteger4, byte initOperation) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    byte RabbitMQ.Client.Framing.v0_8qpid.ITestInteger.Integer1 { get { return default(byte); } }
    ushort RabbitMQ.Client.Framing.v0_8qpid.ITestInteger.Integer2 { get { return default(ushort); } }
    uint RabbitMQ.Client.Framing.v0_8qpid.ITestInteger.Integer3 { get { return default(uint); } }
    ulong RabbitMQ.Client.Framing.v0_8qpid.ITestInteger.Integer4 { get { return default(ulong); } }
    byte RabbitMQ.Client.Framing.v0_8qpid.ITestInteger.Operation { get { return default(byte); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class TestIntegerOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.ITestIntegerOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 120;
    public ulong m_result;
    public const int MethodId = 11;
    public TestIntegerOk() { }
    public TestIntegerOk(ulong initResult) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    ulong RabbitMQ.Client.Framing.v0_8qpid.ITestIntegerOk.Result { get { return default(ulong); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class TestString : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.ITestString, RabbitMQ.Client.IMethod {
    public const int ClassId = 120;
    public byte m_operation;
    public string m_string1;
    public System.Byte[] m_string2;
    public const int MethodId = 20;
    public TestString() { }
    public TestString(string initString1, System.Byte[] initString2, byte initOperation) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    byte RabbitMQ.Client.Framing.v0_8qpid.ITestString.Operation { get { return default(byte); } }
    string RabbitMQ.Client.Framing.v0_8qpid.ITestString.String1 { get { return default(string); } }
    System.Byte[] RabbitMQ.Client.Framing.v0_8qpid.ITestString.String2 { get { return default(System.Byte[]); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class TestStringOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.ITestStringOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 120;
    public System.Byte[] m_result;
    public const int MethodId = 21;
    public TestStringOk() { }
    public TestStringOk(System.Byte[] initResult) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    System.Byte[] RabbitMQ.Client.Framing.v0_8qpid.ITestStringOk.Result { get { return default(System.Byte[]); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class TestTable : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.ITestTable, RabbitMQ.Client.IMethod {
    public const int ClassId = 120;
    public byte m_integerOp;
    public byte m_stringOp;
    public System.Collections.IDictionary m_table;
    public const int MethodId = 30;
    public TestTable() { }
    public TestTable(System.Collections.IDictionary initTable, byte initIntegerOp, byte initStringOp) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    byte RabbitMQ.Client.Framing.v0_8qpid.ITestTable.IntegerOp { get { return default(byte); } }
    byte RabbitMQ.Client.Framing.v0_8qpid.ITestTable.StringOp { get { return default(byte); } }
    System.Collections.IDictionary RabbitMQ.Client.Framing.v0_8qpid.ITestTable.Table { get { return default(System.Collections.IDictionary); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class TestTableOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.ITestTableOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 120;
    public ulong m_integerResult;
    public System.Byte[] m_stringResult;
    public const int MethodId = 31;
    public TestTableOk() { }
    public TestTableOk(ulong initIntegerResult, System.Byte[] initStringResult) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    ulong RabbitMQ.Client.Framing.v0_8qpid.ITestTableOk.IntegerResult { get { return default(ulong); } }
    System.Byte[] RabbitMQ.Client.Framing.v0_8qpid.ITestTableOk.StringResult { get { return default(System.Byte[]); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class TunnelRequest : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.ITunnelRequest, RabbitMQ.Client.IMethod {
    public const int ClassId = 110;
    public System.Collections.IDictionary m_metaData;
    public const int MethodId = 10;
    public TunnelRequest() { }
    public TunnelRequest(System.Collections.IDictionary initMetaData) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    System.Collections.IDictionary RabbitMQ.Client.Framing.v0_8qpid.ITunnelRequest.MetaData { get { return default(System.Collections.IDictionary); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class TxCommit : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.ITxCommit, RabbitMQ.Client.IMethod {
    public const int ClassId = 90;
    public const int MethodId = 20;
    public TxCommit() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class TxCommitOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.ITxCommitOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 90;
    public const int MethodId = 21;
    public TxCommitOk() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class TxRollback : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.ITxRollback, RabbitMQ.Client.IMethod {
    public const int ClassId = 90;
    public const int MethodId = 30;
    public TxRollback() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class TxRollbackOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.ITxRollbackOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 90;
    public const int MethodId = 31;
    public TxRollbackOk() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class TxSelect : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.ITxSelect, RabbitMQ.Client.IMethod {
    public const int ClassId = 90;
    public const int MethodId = 10;
    public TxSelect() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class TxSelectOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.ITxSelectOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 90;
    public const int MethodId = 11;
    public TxSelectOk() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
}
namespace RabbitMQ.Client.Framing.Impl.v0_9 {
  public partial class AccessRequest : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IAccessRequest, RabbitMQ.Client.IMethod {
    public const int ClassId = 30;
    public bool m_active;
    public bool m_exclusive;
    public bool m_passive;
    public bool m_read;
    public string m_realm;
    public bool m_write;
    public const int MethodId = 10;
    public AccessRequest() { }
    public AccessRequest(string initRealm, bool initExclusive, bool initPassive, bool initActive, bool initWrite, bool initRead) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_9.IAccessRequest.Active { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_9.IAccessRequest.Exclusive { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_9.IAccessRequest.Passive { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_9.IAccessRequest.Read { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_9.IAccessRequest.Realm { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_9.IAccessRequest.Write { get { return default(bool); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class AccessRequestOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IAccessRequestOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 30;
    public ushort m_ticket;
    public const int MethodId = 11;
    public AccessRequestOk() { }
    public AccessRequestOk(ushort initTicket) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_9.IAccessRequestOk.Ticket { get { return default(ushort); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class BasicAck : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IBasicAck, RabbitMQ.Client.IMethod {
    public const int ClassId = 60;
    public ulong m_deliveryTag;
    public bool m_multiple;
    public const int MethodId = 80;
    public BasicAck() { }
    public BasicAck(ulong initDeliveryTag, bool initMultiple) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    ulong RabbitMQ.Client.Framing.v0_9.IBasicAck.DeliveryTag { get { return default(ulong); } }
    bool RabbitMQ.Client.Framing.v0_9.IBasicAck.Multiple { get { return default(bool); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class BasicCancel : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IBasicCancel, RabbitMQ.Client.IMethod {
    public const int ClassId = 60;
    public string m_consumerTag;
    public bool m_nowait;
    public const int MethodId = 30;
    public BasicCancel() { }
    public BasicCancel(string initConsumerTag, bool initNowait) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_9.IBasicCancel.ConsumerTag { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_9.IBasicCancel.Nowait { get { return default(bool); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class BasicCancelOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IBasicCancelOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 60;
    public string m_consumerTag;
    public const int MethodId = 31;
    public BasicCancelOk() { }
    public BasicCancelOk(string initConsumerTag) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_9.IBasicCancelOk.ConsumerTag { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class BasicConsume : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IBasicConsume, RabbitMQ.Client.IMethod {
    public const int ClassId = 60;
    public string m_consumerTag;
    public bool m_exclusive;
    public System.Collections.IDictionary m_filter;
    public bool m_noAck;
    public bool m_noLocal;
    public bool m_nowait;
    public string m_queue;
    public ushort m_ticket;
    public const int MethodId = 20;
    public BasicConsume() { }
    public BasicConsume(ushort initTicket, string initQueue, string initConsumerTag, bool initNoLocal, bool initNoAck, bool initExclusive, bool initNowait, System.Collections.IDictionary initFilter) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_9.IBasicConsume.ConsumerTag { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_9.IBasicConsume.Exclusive { get { return default(bool); } }
    System.Collections.IDictionary RabbitMQ.Client.Framing.v0_9.IBasicConsume.Filter { get { return default(System.Collections.IDictionary); } }
    bool RabbitMQ.Client.Framing.v0_9.IBasicConsume.NoAck { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_9.IBasicConsume.NoLocal { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_9.IBasicConsume.Nowait { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_9.IBasicConsume.Queue { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_9.IBasicConsume.Ticket { get { return default(ushort); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class BasicConsumeOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IBasicConsumeOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 60;
    public string m_consumerTag;
    public const int MethodId = 21;
    public BasicConsumeOk() { }
    public BasicConsumeOk(string initConsumerTag) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_9.IBasicConsumeOk.ConsumerTag { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class BasicDeliver : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IBasicDeliver, RabbitMQ.Client.IMethod {
    public const int ClassId = 60;
    public string m_consumerTag;
    public ulong m_deliveryTag;
    public string m_exchange;
    public bool m_redelivered;
    public string m_routingKey;
    public const int MethodId = 60;
    public BasicDeliver() { }
    public BasicDeliver(string initConsumerTag, ulong initDeliveryTag, bool initRedelivered, string initExchange, string initRoutingKey) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_9.IBasicDeliver.ConsumerTag { get { return default(string); } }
    ulong RabbitMQ.Client.Framing.v0_9.IBasicDeliver.DeliveryTag { get { return default(ulong); } }
    string RabbitMQ.Client.Framing.v0_9.IBasicDeliver.Exchange { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_9.IBasicDeliver.Redelivered { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_9.IBasicDeliver.RoutingKey { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class BasicGet : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IBasicGet, RabbitMQ.Client.IMethod {
    public const int ClassId = 60;
    public bool m_noAck;
    public string m_queue;
    public ushort m_ticket;
    public const int MethodId = 70;
    public BasicGet() { }
    public BasicGet(ushort initTicket, string initQueue, bool initNoAck) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_9.IBasicGet.NoAck { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_9.IBasicGet.Queue { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_9.IBasicGet.Ticket { get { return default(ushort); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class BasicGetEmpty : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IBasicGetEmpty, RabbitMQ.Client.IMethod {
    public const int ClassId = 60;
    public string m_clusterId;
    public const int MethodId = 72;
    public BasicGetEmpty() { }
    public BasicGetEmpty(string initClusterId) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_9.IBasicGetEmpty.ClusterId { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class BasicGetOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IBasicGetOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 60;
    public ulong m_deliveryTag;
    public string m_exchange;
    public uint m_messageCount;
    public bool m_redelivered;
    public string m_routingKey;
    public const int MethodId = 71;
    public BasicGetOk() { }
    public BasicGetOk(ulong initDeliveryTag, bool initRedelivered, string initExchange, string initRoutingKey, uint initMessageCount) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    ulong RabbitMQ.Client.Framing.v0_9.IBasicGetOk.DeliveryTag { get { return default(ulong); } }
    string RabbitMQ.Client.Framing.v0_9.IBasicGetOk.Exchange { get { return default(string); } }
    uint RabbitMQ.Client.Framing.v0_9.IBasicGetOk.MessageCount { get { return default(uint); } }
    bool RabbitMQ.Client.Framing.v0_9.IBasicGetOk.Redelivered { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_9.IBasicGetOk.RoutingKey { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class BasicPublish : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IBasicPublish, RabbitMQ.Client.IMethod {
    public const int ClassId = 60;
    public string m_exchange;
    public bool m_immediate;
    public bool m_mandatory;
    public string m_routingKey;
    public ushort m_ticket;
    public const int MethodId = 40;
    public BasicPublish() { }
    public BasicPublish(ushort initTicket, string initExchange, string initRoutingKey, bool initMandatory, bool initImmediate) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_9.IBasicPublish.Exchange { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_9.IBasicPublish.Immediate { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_9.IBasicPublish.Mandatory { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_9.IBasicPublish.RoutingKey { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_9.IBasicPublish.Ticket { get { return default(ushort); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class BasicQos : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IBasicQos, RabbitMQ.Client.IMethod {
    public const int ClassId = 60;
    public bool m_global;
    public ushort m_prefetchCount;
    public uint m_prefetchSize;
    public const int MethodId = 10;
    public BasicQos() { }
    public BasicQos(uint initPrefetchSize, ushort initPrefetchCount, bool initGlobal) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_9.IBasicQos.Global { get { return default(bool); } }
    ushort RabbitMQ.Client.Framing.v0_9.IBasicQos.PrefetchCount { get { return default(ushort); } }
    uint RabbitMQ.Client.Framing.v0_9.IBasicQos.PrefetchSize { get { return default(uint); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class BasicQosOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IBasicQosOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 60;
    public const int MethodId = 11;
    public BasicQosOk() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class BasicRecover : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IBasicRecover, RabbitMQ.Client.IMethod {
    public const int ClassId = 60;
    public bool m_requeue;
    public const int MethodId = 100;
    public BasicRecover() { }
    public BasicRecover(bool initRequeue) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_9.IBasicRecover.Requeue { get { return default(bool); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class BasicReject : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IBasicReject, RabbitMQ.Client.IMethod {
    public const int ClassId = 60;
    public ulong m_deliveryTag;
    public bool m_requeue;
    public const int MethodId = 90;
    public BasicReject() { }
    public BasicReject(ulong initDeliveryTag, bool initRequeue) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    ulong RabbitMQ.Client.Framing.v0_9.IBasicReject.DeliveryTag { get { return default(ulong); } }
    bool RabbitMQ.Client.Framing.v0_9.IBasicReject.Requeue { get { return default(bool); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class BasicReturn : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IBasicReturn, RabbitMQ.Client.IMethod {
    public const int ClassId = 60;
    public string m_exchange;
    public ushort m_replyCode;
    public string m_replyText;
    public string m_routingKey;
    public const int MethodId = 50;
    public BasicReturn() { }
    public BasicReturn(ushort initReplyCode, string initReplyText, string initExchange, string initRoutingKey) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_9.IBasicReturn.Exchange { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_9.IBasicReturn.ReplyCode { get { return default(ushort); } }
    string RabbitMQ.Client.Framing.v0_9.IBasicReturn.ReplyText { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_9.IBasicReturn.RoutingKey { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ChannelClose : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IChannelClose, RabbitMQ.Client.IMethod {
    public const int ClassId = 20;
    public ushort m_classId;
    public ushort m_methodId;
    public ushort m_replyCode;
    public string m_replyText;
    public const int MethodId = 40;
    public ChannelClose() { }
    public ChannelClose(ushort initReplyCode, string initReplyText, ushort initClassId, ushort initMethodId) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_9.IChannelClose.ClassId { get { return default(ushort); } }
    ushort RabbitMQ.Client.Framing.v0_9.IChannelClose.MethodId { get { return default(ushort); } }
    ushort RabbitMQ.Client.Framing.v0_9.IChannelClose.ReplyCode { get { return default(ushort); } }
    string RabbitMQ.Client.Framing.v0_9.IChannelClose.ReplyText { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ChannelCloseOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IChannelCloseOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 20;
    public const int MethodId = 41;
    public ChannelCloseOk() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ChannelFlow : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IChannelFlow, RabbitMQ.Client.IMethod {
    public const int ClassId = 20;
    public bool m_active;
    public const int MethodId = 20;
    public ChannelFlow() { }
    public ChannelFlow(bool initActive) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_9.IChannelFlow.Active { get { return default(bool); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ChannelFlowOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IChannelFlowOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 20;
    public bool m_active;
    public const int MethodId = 21;
    public ChannelFlowOk() { }
    public ChannelFlowOk(bool initActive) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_9.IChannelFlowOk.Active { get { return default(bool); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ChannelOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IChannelOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 20;
    public const int MethodId = 80;
    public ChannelOk() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ChannelOpen : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IChannelOpen, RabbitMQ.Client.IMethod {
    public const int ClassId = 20;
    public string m_outOfBand;
    public const int MethodId = 10;
    public ChannelOpen() { }
    public ChannelOpen(string initOutOfBand) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_9.IChannelOpen.OutOfBand { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ChannelOpenOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IChannelOpenOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 20;
    public System.Byte[] m_channelId;
    public const int MethodId = 11;
    public ChannelOpenOk() { }
    public ChannelOpenOk(System.Byte[] initChannelId) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    System.Byte[] RabbitMQ.Client.Framing.v0_9.IChannelOpenOk.ChannelId { get { return default(System.Byte[]); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ChannelPing : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IChannelPing, RabbitMQ.Client.IMethod {
    public const int ClassId = 20;
    public const int MethodId = 60;
    public ChannelPing() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ChannelPong : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IChannelPong, RabbitMQ.Client.IMethod {
    public const int ClassId = 20;
    public const int MethodId = 70;
    public ChannelPong() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ChannelResume : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IChannelResume, RabbitMQ.Client.IMethod {
    public const int ClassId = 20;
    public System.Byte[] m_channelId;
    public const int MethodId = 50;
    public ChannelResume() { }
    public ChannelResume(System.Byte[] initChannelId) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    System.Byte[] RabbitMQ.Client.Framing.v0_9.IChannelResume.ChannelId { get { return default(System.Byte[]); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public enum ClassId {
    Access = 30,
    Basic = 60,
    Channel = 20,
    Connection = 10,
    Dtx = 100,
    Exchange = 40,
    File = 70,
    Invalid = -1,
    Message = 120,
    Queue = 50,
    Stream = 80,
    Tunnel = 110,
    Tx = 90,
  }
  public partial class Connection : RabbitMQ.Client.Impl.ConnectionBase {
    public Connection(RabbitMQ.Client.ConnectionFactory factory, bool insist, RabbitMQ.Client.Impl.IFrameHandler frameHandler) : base (default(RabbitMQ.Client.ConnectionFactory), default(bool), default(RabbitMQ.Client.Impl.IFrameHandler)) { }
  }
  public partial class ConnectionClose : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IConnectionClose, RabbitMQ.Client.IMethod {
    public const int ClassId = 10;
    public ushort m_classId;
    public ushort m_methodId;
    public ushort m_replyCode;
    public string m_replyText;
    public const int MethodId = 50;
    public ConnectionClose() { }
    public ConnectionClose(ushort initReplyCode, string initReplyText, ushort initClassId, ushort initMethodId) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_9.IConnectionClose.ClassId { get { return default(ushort); } }
    ushort RabbitMQ.Client.Framing.v0_9.IConnectionClose.MethodId { get { return default(ushort); } }
    ushort RabbitMQ.Client.Framing.v0_9.IConnectionClose.ReplyCode { get { return default(ushort); } }
    string RabbitMQ.Client.Framing.v0_9.IConnectionClose.ReplyText { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ConnectionCloseOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IConnectionCloseOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 10;
    public const int MethodId = 51;
    public ConnectionCloseOk() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ConnectionOpen : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IConnectionOpen, RabbitMQ.Client.IMethod {
    public const int ClassId = 10;
    public string m_capabilities;
    public bool m_insist;
    public string m_virtualHost;
    public const int MethodId = 40;
    public ConnectionOpen() { }
    public ConnectionOpen(string initVirtualHost, string initCapabilities, bool initInsist) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_9.IConnectionOpen.Capabilities { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_9.IConnectionOpen.Insist { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_9.IConnectionOpen.VirtualHost { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ConnectionOpenOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IConnectionOpenOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 10;
    public string m_knownHosts;
    public const int MethodId = 41;
    public ConnectionOpenOk() { }
    public ConnectionOpenOk(string initKnownHosts) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_9.IConnectionOpenOk.KnownHosts { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ConnectionRedirect : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IConnectionRedirect, RabbitMQ.Client.IMethod {
    public const int ClassId = 10;
    public string m_host;
    public string m_knownHosts;
    public const int MethodId = 42;
    public ConnectionRedirect() { }
    public ConnectionRedirect(string initHost, string initKnownHosts) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_9.IConnectionRedirect.Host { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_9.IConnectionRedirect.KnownHosts { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ConnectionSecure : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IConnectionSecure, RabbitMQ.Client.IMethod {
    public const int ClassId = 10;
    public System.Byte[] m_challenge;
    public const int MethodId = 20;
    public ConnectionSecure() { }
    public ConnectionSecure(System.Byte[] initChallenge) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    System.Byte[] RabbitMQ.Client.Framing.v0_9.IConnectionSecure.Challenge { get { return default(System.Byte[]); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ConnectionSecureOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IConnectionSecureOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 10;
    public System.Byte[] m_response;
    public const int MethodId = 21;
    public ConnectionSecureOk() { }
    public ConnectionSecureOk(System.Byte[] initResponse) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    System.Byte[] RabbitMQ.Client.Framing.v0_9.IConnectionSecureOk.Response { get { return default(System.Byte[]); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ConnectionStart : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IConnectionStart, RabbitMQ.Client.IMethod {
    public const int ClassId = 10;
    public System.Byte[] m_locales;
    public System.Byte[] m_mechanisms;
    public System.Collections.IDictionary m_serverProperties;
    public byte m_versionMajor;
    public byte m_versionMinor;
    public const int MethodId = 10;
    public ConnectionStart() { }
    public ConnectionStart(byte initVersionMajor, byte initVersionMinor, System.Collections.IDictionary initServerProperties, System.Byte[] initMechanisms, System.Byte[] initLocales) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    System.Byte[] RabbitMQ.Client.Framing.v0_9.IConnectionStart.Locales { get { return default(System.Byte[]); } }
    System.Byte[] RabbitMQ.Client.Framing.v0_9.IConnectionStart.Mechanisms { get { return default(System.Byte[]); } }
    System.Collections.IDictionary RabbitMQ.Client.Framing.v0_9.IConnectionStart.ServerProperties { get { return default(System.Collections.IDictionary); } }
    byte RabbitMQ.Client.Framing.v0_9.IConnectionStart.VersionMajor { get { return default(byte); } }
    byte RabbitMQ.Client.Framing.v0_9.IConnectionStart.VersionMinor { get { return default(byte); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ConnectionStartOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IConnectionStartOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 10;
    public System.Collections.IDictionary m_clientProperties;
    public string m_locale;
    public string m_mechanism;
    public System.Byte[] m_response;
    public const int MethodId = 11;
    public ConnectionStartOk() { }
    public ConnectionStartOk(System.Collections.IDictionary initClientProperties, string initMechanism, System.Byte[] initResponse, string initLocale) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    System.Collections.IDictionary RabbitMQ.Client.Framing.v0_9.IConnectionStartOk.ClientProperties { get { return default(System.Collections.IDictionary); } }
    string RabbitMQ.Client.Framing.v0_9.IConnectionStartOk.Locale { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_9.IConnectionStartOk.Mechanism { get { return default(string); } }
    System.Byte[] RabbitMQ.Client.Framing.v0_9.IConnectionStartOk.Response { get { return default(System.Byte[]); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ConnectionTune : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IConnectionTune, RabbitMQ.Client.IMethod {
    public const int ClassId = 10;
    public ushort m_channelMax;
    public uint m_frameMax;
    public ushort m_heartbeat;
    public const int MethodId = 30;
    public ConnectionTune() { }
    public ConnectionTune(ushort initChannelMax, uint initFrameMax, ushort initHeartbeat) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_9.IConnectionTune.ChannelMax { get { return default(ushort); } }
    uint RabbitMQ.Client.Framing.v0_9.IConnectionTune.FrameMax { get { return default(uint); } }
    ushort RabbitMQ.Client.Framing.v0_9.IConnectionTune.Heartbeat { get { return default(ushort); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ConnectionTuneOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IConnectionTuneOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 10;
    public ushort m_channelMax;
    public uint m_frameMax;
    public ushort m_heartbeat;
    public const int MethodId = 31;
    public ConnectionTuneOk() { }
    public ConnectionTuneOk(ushort initChannelMax, uint initFrameMax, ushort initHeartbeat) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_9.IConnectionTuneOk.ChannelMax { get { return default(ushort); } }
    uint RabbitMQ.Client.Framing.v0_9.IConnectionTuneOk.FrameMax { get { return default(uint); } }
    ushort RabbitMQ.Client.Framing.v0_9.IConnectionTuneOk.Heartbeat { get { return default(ushort); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class DtxSelect : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IDtxSelect, RabbitMQ.Client.IMethod {
    public const int ClassId = 100;
    public const int MethodId = 10;
    public DtxSelect() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class DtxSelectOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IDtxSelectOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 100;
    public const int MethodId = 11;
    public DtxSelectOk() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class DtxStart : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IDtxStart, RabbitMQ.Client.IMethod {
    public const int ClassId = 100;
    public string m_dtxIdentifier;
    public const int MethodId = 20;
    public DtxStart() { }
    public DtxStart(string initDtxIdentifier) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_9.IDtxStart.DtxIdentifier { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class DtxStartOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IDtxStartOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 100;
    public const int MethodId = 21;
    public DtxStartOk() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ExchangeDeclare : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IExchangeDeclare, RabbitMQ.Client.IMethod {
    public const int ClassId = 40;
    public System.Collections.IDictionary m_arguments;
    public bool m_autoDelete;
    public bool m_durable;
    public string m_exchange;
    public bool m_internal;
    public bool m_nowait;
    public bool m_passive;
    public ushort m_ticket;
    public string m_type;
    public const int MethodId = 10;
    public ExchangeDeclare() { }
    public ExchangeDeclare(ushort initTicket, string initExchange, string initType, bool initPassive, bool initDurable, bool initAutoDelete, bool initInternal, bool initNowait, System.Collections.IDictionary initArguments) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    System.Collections.IDictionary RabbitMQ.Client.Framing.v0_9.IExchangeDeclare.Arguments { get { return default(System.Collections.IDictionary); } }
    bool RabbitMQ.Client.Framing.v0_9.IExchangeDeclare.AutoDelete { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_9.IExchangeDeclare.Durable { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_9.IExchangeDeclare.Exchange { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_9.IExchangeDeclare.Internal { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_9.IExchangeDeclare.Nowait { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_9.IExchangeDeclare.Passive { get { return default(bool); } }
    ushort RabbitMQ.Client.Framing.v0_9.IExchangeDeclare.Ticket { get { return default(ushort); } }
    string RabbitMQ.Client.Framing.v0_9.IExchangeDeclare.Type { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ExchangeDeclareOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IExchangeDeclareOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 40;
    public const int MethodId = 11;
    public ExchangeDeclareOk() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ExchangeDelete : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IExchangeDelete, RabbitMQ.Client.IMethod {
    public const int ClassId = 40;
    public string m_exchange;
    public bool m_ifUnused;
    public bool m_nowait;
    public ushort m_ticket;
    public const int MethodId = 20;
    public ExchangeDelete() { }
    public ExchangeDelete(ushort initTicket, string initExchange, bool initIfUnused, bool initNowait) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_9.IExchangeDelete.Exchange { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_9.IExchangeDelete.IfUnused { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_9.IExchangeDelete.Nowait { get { return default(bool); } }
    ushort RabbitMQ.Client.Framing.v0_9.IExchangeDelete.Ticket { get { return default(ushort); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class ExchangeDeleteOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IExchangeDeleteOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 40;
    public const int MethodId = 21;
    public ExchangeDeleteOk() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class FileAck : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IFileAck, RabbitMQ.Client.IMethod {
    public const int ClassId = 70;
    public ulong m_deliveryTag;
    public bool m_multiple;
    public const int MethodId = 90;
    public FileAck() { }
    public FileAck(ulong initDeliveryTag, bool initMultiple) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    ulong RabbitMQ.Client.Framing.v0_9.IFileAck.DeliveryTag { get { return default(ulong); } }
    bool RabbitMQ.Client.Framing.v0_9.IFileAck.Multiple { get { return default(bool); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class FileCancel : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IFileCancel, RabbitMQ.Client.IMethod {
    public const int ClassId = 70;
    public string m_consumerTag;
    public bool m_nowait;
    public const int MethodId = 30;
    public FileCancel() { }
    public FileCancel(string initConsumerTag, bool initNowait) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_9.IFileCancel.ConsumerTag { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_9.IFileCancel.Nowait { get { return default(bool); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class FileCancelOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IFileCancelOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 70;
    public string m_consumerTag;
    public const int MethodId = 31;
    public FileCancelOk() { }
    public FileCancelOk(string initConsumerTag) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_9.IFileCancelOk.ConsumerTag { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class FileConsume : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IFileConsume, RabbitMQ.Client.IMethod {
    public const int ClassId = 70;
    public string m_consumerTag;
    public bool m_exclusive;
    public System.Collections.IDictionary m_filter;
    public bool m_noAck;
    public bool m_noLocal;
    public bool m_nowait;
    public string m_queue;
    public ushort m_ticket;
    public const int MethodId = 20;
    public FileConsume() { }
    public FileConsume(ushort initTicket, string initQueue, string initConsumerTag, bool initNoLocal, bool initNoAck, bool initExclusive, bool initNowait, System.Collections.IDictionary initFilter) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_9.IFileConsume.ConsumerTag { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_9.IFileConsume.Exclusive { get { return default(bool); } }
    System.Collections.IDictionary RabbitMQ.Client.Framing.v0_9.IFileConsume.Filter { get { return default(System.Collections.IDictionary); } }
    bool RabbitMQ.Client.Framing.v0_9.IFileConsume.NoAck { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_9.IFileConsume.NoLocal { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_9.IFileConsume.Nowait { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_9.IFileConsume.Queue { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_9.IFileConsume.Ticket { get { return default(ushort); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class FileConsumeOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IFileConsumeOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 70;
    public string m_consumerTag;
    public const int MethodId = 21;
    public FileConsumeOk() { }
    public FileConsumeOk(string initConsumerTag) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_9.IFileConsumeOk.ConsumerTag { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class FileDeliver : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IFileDeliver, RabbitMQ.Client.IMethod {
    public const int ClassId = 70;
    public string m_consumerTag;
    public ulong m_deliveryTag;
    public string m_exchange;
    public string m_identifier;
    public bool m_redelivered;
    public string m_routingKey;
    public const int MethodId = 80;
    public FileDeliver() { }
    public FileDeliver(string initConsumerTag, ulong initDeliveryTag, bool initRedelivered, string initExchange, string initRoutingKey, string initIdentifier) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_9.IFileDeliver.ConsumerTag { get { return default(string); } }
    ulong RabbitMQ.Client.Framing.v0_9.IFileDeliver.DeliveryTag { get { return default(ulong); } }
    string RabbitMQ.Client.Framing.v0_9.IFileDeliver.Exchange { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_9.IFileDeliver.Identifier { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_9.IFileDeliver.Redelivered { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_9.IFileDeliver.RoutingKey { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class FileOpen : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IFileOpen, RabbitMQ.Client.IMethod {
    public const int ClassId = 70;
    public ulong m_contentSize;
    public string m_identifier;
    public const int MethodId = 40;
    public FileOpen() { }
    public FileOpen(string initIdentifier, ulong initContentSize) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    ulong RabbitMQ.Client.Framing.v0_9.IFileOpen.ContentSize { get { return default(ulong); } }
    string RabbitMQ.Client.Framing.v0_9.IFileOpen.Identifier { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class FileOpenOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IFileOpenOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 70;
    public ulong m_stagedSize;
    public const int MethodId = 41;
    public FileOpenOk() { }
    public FileOpenOk(ulong initStagedSize) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    ulong RabbitMQ.Client.Framing.v0_9.IFileOpenOk.StagedSize { get { return default(ulong); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class FilePublish : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IFilePublish, RabbitMQ.Client.IMethod {
    public const int ClassId = 70;
    public string m_exchange;
    public string m_identifier;
    public bool m_immediate;
    public bool m_mandatory;
    public string m_routingKey;
    public ushort m_ticket;
    public const int MethodId = 60;
    public FilePublish() { }
    public FilePublish(ushort initTicket, string initExchange, string initRoutingKey, bool initMandatory, bool initImmediate, string initIdentifier) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_9.IFilePublish.Exchange { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_9.IFilePublish.Identifier { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_9.IFilePublish.Immediate { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_9.IFilePublish.Mandatory { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_9.IFilePublish.RoutingKey { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_9.IFilePublish.Ticket { get { return default(ushort); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class FileQos : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IFileQos, RabbitMQ.Client.IMethod {
    public const int ClassId = 70;
    public bool m_global;
    public ushort m_prefetchCount;
    public uint m_prefetchSize;
    public const int MethodId = 10;
    public FileQos() { }
    public FileQos(uint initPrefetchSize, ushort initPrefetchCount, bool initGlobal) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_9.IFileQos.Global { get { return default(bool); } }
    ushort RabbitMQ.Client.Framing.v0_9.IFileQos.PrefetchCount { get { return default(ushort); } }
    uint RabbitMQ.Client.Framing.v0_9.IFileQos.PrefetchSize { get { return default(uint); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class FileQosOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IFileQosOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 70;
    public const int MethodId = 11;
    public FileQosOk() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class FileReject : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IFileReject, RabbitMQ.Client.IMethod {
    public const int ClassId = 70;
    public ulong m_deliveryTag;
    public bool m_requeue;
    public const int MethodId = 100;
    public FileReject() { }
    public FileReject(ulong initDeliveryTag, bool initRequeue) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    ulong RabbitMQ.Client.Framing.v0_9.IFileReject.DeliveryTag { get { return default(ulong); } }
    bool RabbitMQ.Client.Framing.v0_9.IFileReject.Requeue { get { return default(bool); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class FileReturn : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IFileReturn, RabbitMQ.Client.IMethod {
    public const int ClassId = 70;
    public string m_exchange;
    public ushort m_replyCode;
    public string m_replyText;
    public string m_routingKey;
    public const int MethodId = 70;
    public FileReturn() { }
    public FileReturn(ushort initReplyCode, string initReplyText, string initExchange, string initRoutingKey) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_9.IFileReturn.Exchange { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_9.IFileReturn.ReplyCode { get { return default(ushort); } }
    string RabbitMQ.Client.Framing.v0_9.IFileReturn.ReplyText { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_9.IFileReturn.RoutingKey { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class FileStage : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IFileStage, RabbitMQ.Client.IMethod {
    public const int ClassId = 70;
    public const int MethodId = 50;
    public FileStage() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class MessageAppend : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IMessageAppend, RabbitMQ.Client.IMethod {
    public const int ClassId = 120;
    public System.Byte[] m_bytes;
    public System.Byte[] m_reference;
    public const int MethodId = 80;
    public MessageAppend() { }
    public MessageAppend(System.Byte[] initReference, System.Byte[] initBytes) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    System.Byte[] RabbitMQ.Client.Framing.v0_9.IMessageAppend.Bytes { get { return default(System.Byte[]); } }
    System.Byte[] RabbitMQ.Client.Framing.v0_9.IMessageAppend.Reference { get { return default(System.Byte[]); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class MessageCancel : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IMessageCancel, RabbitMQ.Client.IMethod {
    public const int ClassId = 120;
    public string m_destination;
    public const int MethodId = 30;
    public MessageCancel() { }
    public MessageCancel(string initDestination) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_9.IMessageCancel.Destination { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class MessageCheckpoint : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IMessageCheckpoint, RabbitMQ.Client.IMethod {
    public const int ClassId = 120;
    public string m_identifier;
    public System.Byte[] m_reference;
    public const int MethodId = 90;
    public MessageCheckpoint() { }
    public MessageCheckpoint(System.Byte[] initReference, string initIdentifier) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_9.IMessageCheckpoint.Identifier { get { return default(string); } }
    System.Byte[] RabbitMQ.Client.Framing.v0_9.IMessageCheckpoint.Reference { get { return default(System.Byte[]); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class MessageClose : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IMessageClose, RabbitMQ.Client.IMethod {
    public const int ClassId = 120;
    public System.Byte[] m_reference;
    public const int MethodId = 70;
    public MessageClose() { }
    public MessageClose(System.Byte[] initReference) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    System.Byte[] RabbitMQ.Client.Framing.v0_9.IMessageClose.Reference { get { return default(System.Byte[]); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class MessageConsume : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IMessageConsume, RabbitMQ.Client.IMethod {
    public const int ClassId = 120;
    public string m_destination;
    public bool m_exclusive;
    public System.Collections.IDictionary m_filter;
    public bool m_noAck;
    public bool m_noLocal;
    public string m_queue;
    public ushort m_ticket;
    public const int MethodId = 20;
    public MessageConsume() { }
    public MessageConsume(ushort initTicket, string initQueue, string initDestination, bool initNoLocal, bool initNoAck, bool initExclusive, System.Collections.IDictionary initFilter) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_9.IMessageConsume.Destination { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_9.IMessageConsume.Exclusive { get { return default(bool); } }
    System.Collections.IDictionary RabbitMQ.Client.Framing.v0_9.IMessageConsume.Filter { get { return default(System.Collections.IDictionary); } }
    bool RabbitMQ.Client.Framing.v0_9.IMessageConsume.NoAck { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_9.IMessageConsume.NoLocal { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_9.IMessageConsume.Queue { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_9.IMessageConsume.Ticket { get { return default(ushort); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class MessageEmpty : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IMessageEmpty, RabbitMQ.Client.IMethod {
    public const int ClassId = 120;
    public const int MethodId = 510;
    public MessageEmpty() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class MessageGet : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IMessageGet, RabbitMQ.Client.IMethod {
    public const int ClassId = 120;
    public string m_destination;
    public bool m_noAck;
    public string m_queue;
    public ushort m_ticket;
    public const int MethodId = 40;
    public MessageGet() { }
    public MessageGet(ushort initTicket, string initQueue, string initDestination, bool initNoAck) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_9.IMessageGet.Destination { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_9.IMessageGet.NoAck { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_9.IMessageGet.Queue { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_9.IMessageGet.Ticket { get { return default(ushort); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class MessageOffset : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IMessageOffset, RabbitMQ.Client.IMethod {
    public const int ClassId = 120;
    public ulong m_value;
    public const int MethodId = 530;
    public MessageOffset() { }
    public MessageOffset(ulong initValue) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    ulong RabbitMQ.Client.Framing.v0_9.IMessageOffset.Value { get { return default(ulong); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class MessageOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IMessageOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 120;
    public const int MethodId = 500;
    public MessageOk() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class MessageOpen : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IMessageOpen, RabbitMQ.Client.IMethod {
    public const int ClassId = 120;
    public System.Byte[] m_reference;
    public const int MethodId = 60;
    public MessageOpen() { }
    public MessageOpen(System.Byte[] initReference) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    System.Byte[] RabbitMQ.Client.Framing.v0_9.IMessageOpen.Reference { get { return default(System.Byte[]); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class MessageQos : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IMessageQos, RabbitMQ.Client.IMethod {
    public const int ClassId = 120;
    public bool m_global;
    public ushort m_prefetchCount;
    public uint m_prefetchSize;
    public const int MethodId = 110;
    public MessageQos() { }
    public MessageQos(uint initPrefetchSize, ushort initPrefetchCount, bool initGlobal) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_9.IMessageQos.Global { get { return default(bool); } }
    ushort RabbitMQ.Client.Framing.v0_9.IMessageQos.PrefetchCount { get { return default(ushort); } }
    uint RabbitMQ.Client.Framing.v0_9.IMessageQos.PrefetchSize { get { return default(uint); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class MessageRecover : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IMessageRecover, RabbitMQ.Client.IMethod {
    public const int ClassId = 120;
    public bool m_requeue;
    public const int MethodId = 50;
    public MessageRecover() { }
    public MessageRecover(bool initRequeue) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_9.IMessageRecover.Requeue { get { return default(bool); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class MessageReject : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IMessageReject, RabbitMQ.Client.IMethod {
    public const int ClassId = 120;
    public ushort m_code;
    public string m_text;
    public const int MethodId = 520;
    public MessageReject() { }
    public MessageReject(ushort initCode, string initText) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_9.IMessageReject.Code { get { return default(ushort); } }
    string RabbitMQ.Client.Framing.v0_9.IMessageReject.Text { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class MessageResume : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IMessageResume, RabbitMQ.Client.IMethod {
    public const int ClassId = 120;
    public string m_identifier;
    public System.Byte[] m_reference;
    public const int MethodId = 100;
    public MessageResume() { }
    public MessageResume(System.Byte[] initReference, string initIdentifier) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_9.IMessageResume.Identifier { get { return default(string); } }
    System.Byte[] RabbitMQ.Client.Framing.v0_9.IMessageResume.Reference { get { return default(System.Byte[]); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class MessageTransfer : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IMessageTransfer, RabbitMQ.Client.IMethod {
    public const int ClassId = 120;
    public string m_appId;
    public System.Collections.IDictionary m_applicationHeaders;
    public System.Byte[] m_body;
    public string m_contentEncoding;
    public string m_contentType;
    public string m_correlationId;
    public byte m_deliveryMode;
    public string m_destination;
    public string m_exchange;
    public RabbitMQ.Client.AmqpTimestamp m_expiration;
    public bool m_immediate;
    public string m_messageId;
    public byte m_priority;
    public bool m_redelivered;
    public string m_replyTo;
    public string m_routingKey;
    public System.Byte[] m_securityToken;
    public ushort m_ticket;
    public RabbitMQ.Client.AmqpTimestamp m_timestamp;
    public string m_transactionId;
    public ulong m_ttl;
    public string m_userId;
    public const int MethodId = 10;
    public MessageTransfer() { }
    public MessageTransfer(ushort initTicket, string initDestination, bool initRedelivered, bool initImmediate, ulong initTtl, byte initPriority, RabbitMQ.Client.AmqpTimestamp initTimestamp, byte initDeliveryMode, RabbitMQ.Client.AmqpTimestamp initExpiration, string initExchange, string initRoutingKey, string initMessageId, string initCorrelationId, string initReplyTo, string initContentType, string initContentEncoding, string initUserId, string initAppId, string initTransactionId, System.Byte[] initSecurityToken, System.Collections.IDictionary initApplicationHeaders, System.Byte[] initBody) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_9.IMessageTransfer.AppId { get { return default(string); } }
    System.Collections.IDictionary RabbitMQ.Client.Framing.v0_9.IMessageTransfer.ApplicationHeaders { get { return default(System.Collections.IDictionary); } }
    System.Byte[] RabbitMQ.Client.Framing.v0_9.IMessageTransfer.Body { get { return default(System.Byte[]); } }
    string RabbitMQ.Client.Framing.v0_9.IMessageTransfer.ContentEncoding { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_9.IMessageTransfer.ContentType { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_9.IMessageTransfer.CorrelationId { get { return default(string); } }
    byte RabbitMQ.Client.Framing.v0_9.IMessageTransfer.DeliveryMode { get { return default(byte); } }
    string RabbitMQ.Client.Framing.v0_9.IMessageTransfer.Destination { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_9.IMessageTransfer.Exchange { get { return default(string); } }
    RabbitMQ.Client.AmqpTimestamp RabbitMQ.Client.Framing.v0_9.IMessageTransfer.Expiration { get { return default(RabbitMQ.Client.AmqpTimestamp); } }
    bool RabbitMQ.Client.Framing.v0_9.IMessageTransfer.Immediate { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_9.IMessageTransfer.MessageId { get { return default(string); } }
    byte RabbitMQ.Client.Framing.v0_9.IMessageTransfer.Priority { get { return default(byte); } }
    bool RabbitMQ.Client.Framing.v0_9.IMessageTransfer.Redelivered { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_9.IMessageTransfer.ReplyTo { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_9.IMessageTransfer.RoutingKey { get { return default(string); } }
    System.Byte[] RabbitMQ.Client.Framing.v0_9.IMessageTransfer.SecurityToken { get { return default(System.Byte[]); } }
    ushort RabbitMQ.Client.Framing.v0_9.IMessageTransfer.Ticket { get { return default(ushort); } }
    RabbitMQ.Client.AmqpTimestamp RabbitMQ.Client.Framing.v0_9.IMessageTransfer.Timestamp { get { return default(RabbitMQ.Client.AmqpTimestamp); } }
    string RabbitMQ.Client.Framing.v0_9.IMessageTransfer.TransactionId { get { return default(string); } }
    ulong RabbitMQ.Client.Framing.v0_9.IMessageTransfer.Ttl { get { return default(ulong); } }
    string RabbitMQ.Client.Framing.v0_9.IMessageTransfer.UserId { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class Model : RabbitMQ.Client.Impl.ModelBase {
    public Model(RabbitMQ.Client.Impl.ISession session) : base (default(RabbitMQ.Client.Impl.ISession)) { }
    public override void _Private_BasicCancel(string consumerTag, bool nowait) { }
    public override void _Private_BasicConsume(string queue, string consumerTag, bool noLocal, bool noAck, bool exclusive, bool nowait, System.Collections.IDictionary filter) { }
    public override void _Private_BasicGet(string queue, bool noAck) { }
    public override void _Private_BasicPublish(string exchange, string routingKey, bool mandatory, bool immediate, RabbitMQ.Client.IBasicProperties basicProperties, System.Byte[] body) { }
    public override void _Private_ChannelClose(ushort replyCode, string replyText, ushort classId, ushort methodId) { }
    public override void _Private_ChannelCloseOk() { }
    public override void _Private_ChannelFlowOk() { }
    public override void _Private_ChannelOpen(string outOfBand) { }
    public override void _Private_ConnectionClose(ushort replyCode, string replyText, ushort classId, ushort methodId) { }
    public override void _Private_ConnectionCloseOk() { }
    public override void _Private_ConnectionOpen(string virtualHost, string capabilities, bool insist) { }
    public override void BasicAck(ulong deliveryTag, bool multiple) { }
    public override void BasicQos(uint prefetchSize, ushort prefetchCount, bool global) { }
    public override void BasicRecover(bool requeue) { }
    public override void BasicReject(ulong deliveryTag, bool requeue) { }
    public override void ChannelFlow(bool active) { }
    public override RabbitMQ.Client.Impl.ConnectionTuneDetails ConnectionStartOk(System.Collections.IDictionary clientProperties, string mechanism, System.Byte[] response, string locale) { return default(RabbitMQ.Client.Impl.ConnectionTuneDetails); }
    public override void ConnectionTuneOk(ushort channelMax, uint frameMax, ushort heartbeat) { }
    public override RabbitMQ.Client.IBasicProperties CreateBasicProperties() { return default(RabbitMQ.Client.IBasicProperties); }
    public override RabbitMQ.Client.IFileProperties CreateFileProperties() { return default(RabbitMQ.Client.IFileProperties); }
    public override RabbitMQ.Client.IStreamProperties CreateStreamProperties() { return default(RabbitMQ.Client.IStreamProperties); }
    public override bool DispatchAsynchronous(RabbitMQ.Client.Impl.Command cmd) { return default(bool); }
    public override void DtxSelect() { }
    public override void DtxStart(string dtxIdentifier) { }
    public override void ExchangeDeclare(string exchange, string type, bool passive, bool durable, bool autoDelete, bool @internal, bool nowait, System.Collections.IDictionary arguments) { }
    public override void ExchangeDelete(string exchange, bool ifUnused, bool nowait) { }
    public override void QueueBind(string queue, string exchange, string routingKey, bool nowait, System.Collections.IDictionary arguments) { }
    public override string QueueDeclare(string queue, bool passive, bool durable, bool exclusive, bool autoDelete, bool nowait, System.Collections.IDictionary arguments) { return default(string); }
    public override uint QueueDelete(string queue, bool ifUnused, bool ifEmpty, bool nowait) { return default(uint); }
    public override uint QueuePurge(string queue, bool nowait) { return default(uint); }
    public override void QueueUnbind(string queue, string exchange, string routingKey, System.Collections.IDictionary arguments) { }
    public override void TxCommit() { }
    public override void TxRollback() { }
    public override void TxSelect() { }
  }
  public abstract partial class ProtocolBase : RabbitMQ.Client.Impl.AbstractProtocolBase {
    protected ProtocolBase() { }
    public override bool CanSendWhileClosed(RabbitMQ.Client.Impl.Command cmd) { return default(bool); }
    public override void CreateChannelClose(ushort reasonCode, string reasonText, out RabbitMQ.Client.Impl.Command request, out int replyClassId, out int replyMethodId) { request = default(RabbitMQ.Client.Impl.Command); replyClassId = default(int); replyMethodId = default(int); }
    public override RabbitMQ.Client.IConnection CreateConnection(RabbitMQ.Client.ConnectionFactory factory, bool insist, RabbitMQ.Client.Impl.IFrameHandler frameHandler) { return default(RabbitMQ.Client.IConnection); }
    public override void CreateConnectionClose(ushort reasonCode, string reasonText, out RabbitMQ.Client.Impl.Command request, out int replyClassId, out int replyMethodId) { request = default(RabbitMQ.Client.Impl.Command); replyClassId = default(int); replyMethodId = default(int); }
    public override RabbitMQ.Client.Impl.IFrameHandler CreateFrameHandler(RabbitMQ.Client.AmqpTcpEndpoint endpoint) { return default(RabbitMQ.Client.Impl.IFrameHandler); }
    public override RabbitMQ.Client.IModel CreateModel(RabbitMQ.Client.Impl.ISession session) { return default(RabbitMQ.Client.IModel); }
  }
  public partial class QueueBind : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IQueueBind, RabbitMQ.Client.IMethod {
    public const int ClassId = 50;
    public System.Collections.IDictionary m_arguments;
    public string m_exchange;
    public bool m_nowait;
    public string m_queue;
    public string m_routingKey;
    public ushort m_ticket;
    public const int MethodId = 20;
    public QueueBind() { }
    public QueueBind(ushort initTicket, string initQueue, string initExchange, string initRoutingKey, bool initNowait, System.Collections.IDictionary initArguments) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    System.Collections.IDictionary RabbitMQ.Client.Framing.v0_9.IQueueBind.Arguments { get { return default(System.Collections.IDictionary); } }
    string RabbitMQ.Client.Framing.v0_9.IQueueBind.Exchange { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_9.IQueueBind.Nowait { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_9.IQueueBind.Queue { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_9.IQueueBind.RoutingKey { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_9.IQueueBind.Ticket { get { return default(ushort); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class QueueBindOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IQueueBindOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 50;
    public const int MethodId = 21;
    public QueueBindOk() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class QueueDeclare : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IQueueDeclare, RabbitMQ.Client.IMethod {
    public const int ClassId = 50;
    public System.Collections.IDictionary m_arguments;
    public bool m_autoDelete;
    public bool m_durable;
    public bool m_exclusive;
    public bool m_nowait;
    public bool m_passive;
    public string m_queue;
    public ushort m_ticket;
    public const int MethodId = 10;
    public QueueDeclare() { }
    public QueueDeclare(ushort initTicket, string initQueue, bool initPassive, bool initDurable, bool initExclusive, bool initAutoDelete, bool initNowait, System.Collections.IDictionary initArguments) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    System.Collections.IDictionary RabbitMQ.Client.Framing.v0_9.IQueueDeclare.Arguments { get { return default(System.Collections.IDictionary); } }
    bool RabbitMQ.Client.Framing.v0_9.IQueueDeclare.AutoDelete { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_9.IQueueDeclare.Durable { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_9.IQueueDeclare.Exclusive { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_9.IQueueDeclare.Nowait { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_9.IQueueDeclare.Passive { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_9.IQueueDeclare.Queue { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_9.IQueueDeclare.Ticket { get { return default(ushort); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class QueueDeclareOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IQueueDeclareOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 50;
    public uint m_consumerCount;
    public uint m_messageCount;
    public string m_queue;
    public const int MethodId = 11;
    public QueueDeclareOk() { }
    public QueueDeclareOk(string initQueue, uint initMessageCount, uint initConsumerCount) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    uint RabbitMQ.Client.Framing.v0_9.IQueueDeclareOk.ConsumerCount { get { return default(uint); } }
    uint RabbitMQ.Client.Framing.v0_9.IQueueDeclareOk.MessageCount { get { return default(uint); } }
    string RabbitMQ.Client.Framing.v0_9.IQueueDeclareOk.Queue { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class QueueDelete : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IQueueDelete, RabbitMQ.Client.IMethod {
    public const int ClassId = 50;
    public bool m_ifEmpty;
    public bool m_ifUnused;
    public bool m_nowait;
    public string m_queue;
    public ushort m_ticket;
    public const int MethodId = 40;
    public QueueDelete() { }
    public QueueDelete(ushort initTicket, string initQueue, bool initIfUnused, bool initIfEmpty, bool initNowait) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_9.IQueueDelete.IfEmpty { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_9.IQueueDelete.IfUnused { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_9.IQueueDelete.Nowait { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_9.IQueueDelete.Queue { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_9.IQueueDelete.Ticket { get { return default(ushort); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class QueueDeleteOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IQueueDeleteOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 50;
    public uint m_messageCount;
    public const int MethodId = 41;
    public QueueDeleteOk() { }
    public QueueDeleteOk(uint initMessageCount) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    uint RabbitMQ.Client.Framing.v0_9.IQueueDeleteOk.MessageCount { get { return default(uint); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class QueuePurge : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IQueuePurge, RabbitMQ.Client.IMethod {
    public const int ClassId = 50;
    public bool m_nowait;
    public string m_queue;
    public ushort m_ticket;
    public const int MethodId = 30;
    public QueuePurge() { }
    public QueuePurge(ushort initTicket, string initQueue, bool initNowait) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_9.IQueuePurge.Nowait { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_9.IQueuePurge.Queue { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_9.IQueuePurge.Ticket { get { return default(ushort); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class QueuePurgeOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IQueuePurgeOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 50;
    public uint m_messageCount;
    public const int MethodId = 31;
    public QueuePurgeOk() { }
    public QueuePurgeOk(uint initMessageCount) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    uint RabbitMQ.Client.Framing.v0_9.IQueuePurgeOk.MessageCount { get { return default(uint); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class QueueUnbind : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IQueueUnbind, RabbitMQ.Client.IMethod {
    public const int ClassId = 50;
    public System.Collections.IDictionary m_arguments;
    public string m_exchange;
    public string m_queue;
    public string m_routingKey;
    public ushort m_ticket;
    public const int MethodId = 50;
    public QueueUnbind() { }
    public QueueUnbind(ushort initTicket, string initQueue, string initExchange, string initRoutingKey, System.Collections.IDictionary initArguments) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    System.Collections.IDictionary RabbitMQ.Client.Framing.v0_9.IQueueUnbind.Arguments { get { return default(System.Collections.IDictionary); } }
    string RabbitMQ.Client.Framing.v0_9.IQueueUnbind.Exchange { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_9.IQueueUnbind.Queue { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_9.IQueueUnbind.RoutingKey { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_9.IQueueUnbind.Ticket { get { return default(ushort); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class QueueUnbindOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IQueueUnbindOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 50;
    public const int MethodId = 51;
    public QueueUnbindOk() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class StreamCancel : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IStreamCancel, RabbitMQ.Client.IMethod {
    public const int ClassId = 80;
    public string m_consumerTag;
    public bool m_nowait;
    public const int MethodId = 30;
    public StreamCancel() { }
    public StreamCancel(string initConsumerTag, bool initNowait) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_9.IStreamCancel.ConsumerTag { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_9.IStreamCancel.Nowait { get { return default(bool); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class StreamCancelOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IStreamCancelOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 80;
    public string m_consumerTag;
    public const int MethodId = 31;
    public StreamCancelOk() { }
    public StreamCancelOk(string initConsumerTag) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_9.IStreamCancelOk.ConsumerTag { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class StreamConsume : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IStreamConsume, RabbitMQ.Client.IMethod {
    public const int ClassId = 80;
    public string m_consumerTag;
    public bool m_exclusive;
    public System.Collections.IDictionary m_filter;
    public bool m_noLocal;
    public bool m_nowait;
    public string m_queue;
    public ushort m_ticket;
    public const int MethodId = 20;
    public StreamConsume() { }
    public StreamConsume(ushort initTicket, string initQueue, string initConsumerTag, bool initNoLocal, bool initExclusive, bool initNowait, System.Collections.IDictionary initFilter) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_9.IStreamConsume.ConsumerTag { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_9.IStreamConsume.Exclusive { get { return default(bool); } }
    System.Collections.IDictionary RabbitMQ.Client.Framing.v0_9.IStreamConsume.Filter { get { return default(System.Collections.IDictionary); } }
    bool RabbitMQ.Client.Framing.v0_9.IStreamConsume.NoLocal { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_9.IStreamConsume.Nowait { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_9.IStreamConsume.Queue { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_9.IStreamConsume.Ticket { get { return default(ushort); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class StreamConsumeOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IStreamConsumeOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 80;
    public string m_consumerTag;
    public const int MethodId = 21;
    public StreamConsumeOk() { }
    public StreamConsumeOk(string initConsumerTag) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_9.IStreamConsumeOk.ConsumerTag { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class StreamDeliver : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IStreamDeliver, RabbitMQ.Client.IMethod {
    public const int ClassId = 80;
    public string m_consumerTag;
    public ulong m_deliveryTag;
    public string m_exchange;
    public string m_queue;
    public const int MethodId = 60;
    public StreamDeliver() { }
    public StreamDeliver(string initConsumerTag, ulong initDeliveryTag, string initExchange, string initQueue) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_9.IStreamDeliver.ConsumerTag { get { return default(string); } }
    ulong RabbitMQ.Client.Framing.v0_9.IStreamDeliver.DeliveryTag { get { return default(ulong); } }
    string RabbitMQ.Client.Framing.v0_9.IStreamDeliver.Exchange { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_9.IStreamDeliver.Queue { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class StreamPublish : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IStreamPublish, RabbitMQ.Client.IMethod {
    public const int ClassId = 80;
    public string m_exchange;
    public bool m_immediate;
    public bool m_mandatory;
    public string m_routingKey;
    public ushort m_ticket;
    public const int MethodId = 40;
    public StreamPublish() { }
    public StreamPublish(ushort initTicket, string initExchange, string initRoutingKey, bool initMandatory, bool initImmediate) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_9.IStreamPublish.Exchange { get { return default(string); } }
    bool RabbitMQ.Client.Framing.v0_9.IStreamPublish.Immediate { get { return default(bool); } }
    bool RabbitMQ.Client.Framing.v0_9.IStreamPublish.Mandatory { get { return default(bool); } }
    string RabbitMQ.Client.Framing.v0_9.IStreamPublish.RoutingKey { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_9.IStreamPublish.Ticket { get { return default(ushort); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class StreamQos : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IStreamQos, RabbitMQ.Client.IMethod {
    public const int ClassId = 80;
    public uint m_consumeRate;
    public bool m_global;
    public ushort m_prefetchCount;
    public uint m_prefetchSize;
    public const int MethodId = 10;
    public StreamQos() { }
    public StreamQos(uint initPrefetchSize, ushort initPrefetchCount, uint initConsumeRate, bool initGlobal) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    uint RabbitMQ.Client.Framing.v0_9.IStreamQos.ConsumeRate { get { return default(uint); } }
    bool RabbitMQ.Client.Framing.v0_9.IStreamQos.Global { get { return default(bool); } }
    ushort RabbitMQ.Client.Framing.v0_9.IStreamQos.PrefetchCount { get { return default(ushort); } }
    uint RabbitMQ.Client.Framing.v0_9.IStreamQos.PrefetchSize { get { return default(uint); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class StreamQosOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IStreamQosOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 80;
    public const int MethodId = 11;
    public StreamQosOk() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class StreamReturn : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IStreamReturn, RabbitMQ.Client.IMethod {
    public const int ClassId = 80;
    public string m_exchange;
    public ushort m_replyCode;
    public string m_replyText;
    public string m_routingKey;
    public const int MethodId = 50;
    public StreamReturn() { }
    public StreamReturn(ushort initReplyCode, string initReplyText, string initExchange, string initRoutingKey) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_9.IStreamReturn.Exchange { get { return default(string); } }
    ushort RabbitMQ.Client.Framing.v0_9.IStreamReturn.ReplyCode { get { return default(ushort); } }
    string RabbitMQ.Client.Framing.v0_9.IStreamReturn.ReplyText { get { return default(string); } }
    string RabbitMQ.Client.Framing.v0_9.IStreamReturn.RoutingKey { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class TunnelRequest : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.ITunnelRequest, RabbitMQ.Client.IMethod {
    public const int ClassId = 110;
    public System.Collections.IDictionary m_metaData;
    public const int MethodId = 10;
    public TunnelRequest() { }
    public TunnelRequest(System.Collections.IDictionary initMetaData) { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    System.Collections.IDictionary RabbitMQ.Client.Framing.v0_9.ITunnelRequest.MetaData { get { return default(System.Collections.IDictionary); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class TxCommit : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.ITxCommit, RabbitMQ.Client.IMethod {
    public const int ClassId = 90;
    public const int MethodId = 20;
    public TxCommit() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class TxCommitOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.ITxCommitOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 90;
    public const int MethodId = 21;
    public TxCommitOk() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class TxRollback : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.ITxRollback, RabbitMQ.Client.IMethod {
    public const int ClassId = 90;
    public const int MethodId = 30;
    public TxRollback() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class TxRollbackOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.ITxRollbackOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 90;
    public const int MethodId = 31;
    public TxRollbackOk() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class TxSelect : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.ITxSelect, RabbitMQ.Client.IMethod {
    public const int ClassId = 90;
    public const int MethodId = 10;
    public TxSelect() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
  public partial class TxSelectOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.ITxSelectOk, RabbitMQ.Client.IMethod {
    public const int ClassId = 90;
    public const int MethodId = 11;
    public TxSelectOk() { }
    public override bool HasContent { get { return default(bool); } }
    public override int ProtocolClassId { get { return default(int); } }
    public override int ProtocolMethodId { get { return default(int); } }
    public override string ProtocolMethodName { get { return default(string); } }
    public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
    public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
  }
}
namespace RabbitMQ.Client.Framing.v0_8 {
  public partial class BasicProperties : RabbitMQ.Client.Impl.BasicProperties {
    public BasicProperties() { }
    public override string AppId { get { return default(string); } set { } }
    public override string ClusterId { get { return default(string); } set { } }
    public override string ContentEncoding { get { return default(string); } set { } }
    public override string ContentType { get { return default(string); } set { } }
    public override string CorrelationId { get { return default(string); } set { } }
    public override byte DeliveryMode { get { return default(byte); } set { } }
    public override string Expiration { get { return default(string); } set { } }
    public override System.Collections.IDictionary Headers { get { return default(System.Collections.IDictionary); } set { } }
    public override string MessageId { get { return default(string); } set { } }
    public override byte Priority { get { return default(byte); } set { } }
    public override int ProtocolClassId { get { return default(int); } }
    public override string ProtocolClassName { get { return default(string); } }
    public override string ReplyTo { get { return default(string); } set { } }
    public override RabbitMQ.Client.AmqpTimestamp Timestamp { get { return default(RabbitMQ.Client.AmqpTimestamp); } set { } }
    public override string Type { get { return default(string); } set { } }
    public override string UserId { get { return default(string); } set { } }
    public override void AppendPropertyDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ClearAppId() { }
    public override void ClearClusterId() { }
    public override void ClearContentEncoding() { }
    public override void ClearContentType() { }
    public override void ClearCorrelationId() { }
    public override void ClearDeliveryMode() { }
    public override void ClearExpiration() { }
    public override void ClearHeaders() { }
    public override void ClearMessageId() { }
    public override void ClearPriority() { }
    public override void ClearReplyTo() { }
    public override void ClearTimestamp() { }
    public override void ClearType() { }
    public override void ClearUserId() { }
    public override bool IsAppIdPresent() { return default(bool); }
    public override bool IsClusterIdPresent() { return default(bool); }
    public override bool IsContentEncodingPresent() { return default(bool); }
    public override bool IsContentTypePresent() { return default(bool); }
    public override bool IsCorrelationIdPresent() { return default(bool); }
    public override bool IsDeliveryModePresent() { return default(bool); }
    public override bool IsExpirationPresent() { return default(bool); }
    public override bool IsHeadersPresent() { return default(bool); }
    public override bool IsMessageIdPresent() { return default(bool); }
    public override bool IsPriorityPresent() { return default(bool); }
    public override bool IsReplyToPresent() { return default(bool); }
    public override bool IsTimestampPresent() { return default(bool); }
    public override bool IsTypePresent() { return default(bool); }
    public override bool IsUserIdPresent() { return default(bool); }
    public override void ReadPropertiesFrom(RabbitMQ.Client.Impl.ContentHeaderPropertyReader reader) { }
    public override void WritePropertiesTo(RabbitMQ.Client.Impl.ContentHeaderPropertyWriter writer) { }
  }
  public partial class Constants {
    public const int AccessRefused = 403;
    public const int ChannelError = 504;
    public const int CommandInvalid = 503;
    public const int ConnectionForced = 320;
    public const int ContentTooLarge = 311;
    public const int FrameBody = 3;
    public const int FrameEnd = 206;
    public const int FrameError = 501;
    public const int FrameHeader = 2;
    public const int FrameHeartbeat = 8;
    public const int FrameMethod = 1;
    public const int FrameMinSize = 4096;
    public const int FrameOobBody = 6;
    public const int FrameOobHeader = 5;
    public const int FrameOobMethod = 4;
    public const int FrameTrace = 7;
    public const int InternalError = 541;
    public const int InvalidPath = 402;
    public const int NotAllowed = 530;
    public const int NotDelivered = 310;
    public const int NotFound = 404;
    public const int NotImplemented = 540;
    public const int ReplySuccess = 200;
    public const int ResourceError = 506;
    public const int ResourceLocked = 405;
    public const int SyntaxError = 502;
    public Constants() { }
  }
  public partial class FileProperties : RabbitMQ.Client.Impl.FileProperties {
    public FileProperties() { }
    public override string ClusterId { get { return default(string); } set { } }
    public override string ContentEncoding { get { return default(string); } set { } }
    public override string ContentType { get { return default(string); } set { } }
    public override string Filename { get { return default(string); } set { } }
    public override System.Collections.IDictionary Headers { get { return default(System.Collections.IDictionary); } set { } }
    public override string MessageId { get { return default(string); } set { } }
    public override byte Priority { get { return default(byte); } set { } }
    public override int ProtocolClassId { get { return default(int); } }
    public override string ProtocolClassName { get { return default(string); } }
    public override string ReplyTo { get { return default(string); } set { } }
    public override RabbitMQ.Client.AmqpTimestamp Timestamp { get { return default(RabbitMQ.Client.AmqpTimestamp); } set { } }
    public override void AppendPropertyDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ClearClusterId() { }
    public override void ClearContentEncoding() { }
    public override void ClearContentType() { }
    public override void ClearFilename() { }
    public override void ClearHeaders() { }
    public override void ClearMessageId() { }
    public override void ClearPriority() { }
    public override void ClearReplyTo() { }
    public override void ClearTimestamp() { }
    public override bool IsClusterIdPresent() { return default(bool); }
    public override bool IsContentEncodingPresent() { return default(bool); }
    public override bool IsContentTypePresent() { return default(bool); }
    public override bool IsFilenamePresent() { return default(bool); }
    public override bool IsHeadersPresent() { return default(bool); }
    public override bool IsMessageIdPresent() { return default(bool); }
    public override bool IsPriorityPresent() { return default(bool); }
    public override bool IsReplyToPresent() { return default(bool); }
    public override bool IsTimestampPresent() { return default(bool); }
    public override void ReadPropertiesFrom(RabbitMQ.Client.Impl.ContentHeaderPropertyReader reader) { }
    public override void WritePropertiesTo(RabbitMQ.Client.Impl.ContentHeaderPropertyWriter writer) { }
  }
  public partial interface IAccessRequest : RabbitMQ.Client.IMethod {
    bool Active { get; }
    bool Exclusive { get; }
    bool Passive { get; }
    bool Read { get; }
    string Realm { get; }
    bool Write { get; }
  }
  public partial interface IAccessRequestOk : RabbitMQ.Client.IMethod {
    ushort Ticket { get; }
  }
  public partial interface IBasicAck : RabbitMQ.Client.IMethod {
    ulong DeliveryTag { get; }
    bool Multiple { get; }
  }
  public partial interface IBasicCancel : RabbitMQ.Client.IMethod {
    string ConsumerTag { get; }
    bool Nowait { get; }
  }
  public partial interface IBasicCancelOk : RabbitMQ.Client.IMethod {
    string ConsumerTag { get; }
  }
  public partial interface IBasicConsume : RabbitMQ.Client.IMethod {
    string ConsumerTag { get; }
    bool Exclusive { get; }
    bool NoAck { get; }
    bool NoLocal { get; }
    bool Nowait { get; }
    string Queue { get; }
    ushort Ticket { get; }
  }
  public partial interface IBasicConsumeOk : RabbitMQ.Client.IMethod {
    string ConsumerTag { get; }
  }
  public partial interface IBasicDeliver : RabbitMQ.Client.IMethod {
    string ConsumerTag { get; }
    ulong DeliveryTag { get; }
    string Exchange { get; }
    bool Redelivered { get; }
    string RoutingKey { get; }
  }
  public partial interface IBasicGet : RabbitMQ.Client.IMethod {
    bool NoAck { get; }
    string Queue { get; }
    ushort Ticket { get; }
  }
  public partial interface IBasicGetEmpty : RabbitMQ.Client.IMethod {
    string ClusterId { get; }
  }
  public partial interface IBasicGetOk : RabbitMQ.Client.IMethod {
    ulong DeliveryTag { get; }
    string Exchange { get; }
    uint MessageCount { get; }
    bool Redelivered { get; }
    string RoutingKey { get; }
  }
  public partial interface IBasicPublish : RabbitMQ.Client.IMethod {
    string Exchange { get; }
    bool Immediate { get; }
    bool Mandatory { get; }
    string RoutingKey { get; }
    ushort Ticket { get; }
  }
  public partial interface IBasicQos : RabbitMQ.Client.IMethod {
    bool Global { get; }
    ushort PrefetchCount { get; }
    uint PrefetchSize { get; }
  }
  public partial interface IBasicQosOk : RabbitMQ.Client.IMethod {
  }
  public partial interface IBasicRecover : RabbitMQ.Client.IMethod {
    bool Requeue { get; }
  }
  public partial interface IBasicReject : RabbitMQ.Client.IMethod {
    ulong DeliveryTag { get; }
    bool Requeue { get; }
  }
  public partial interface IBasicReturn : RabbitMQ.Client.IMethod {
    string Exchange { get; }
    ushort ReplyCode { get; }
    string ReplyText { get; }
    string RoutingKey { get; }
  }
  public partial interface IChannelAlert : RabbitMQ.Client.IMethod {
    System.Collections.IDictionary Details { get; }
    ushort ReplyCode { get; }
    string ReplyText { get; }
  }
  public partial interface IChannelClose : RabbitMQ.Client.IMethod {
    ushort ClassId { get; }
    ushort MethodId { get; }
    ushort ReplyCode { get; }
    string ReplyText { get; }
  }
  public partial interface IChannelCloseOk : RabbitMQ.Client.IMethod {
  }
  public partial interface IChannelFlow : RabbitMQ.Client.IMethod {
    bool Active { get; }
  }
  public partial interface IChannelFlowOk : RabbitMQ.Client.IMethod {
    bool Active { get; }
  }
  public partial interface IChannelOpen : RabbitMQ.Client.IMethod {
    string OutOfBand { get; }
  }
  public partial interface IChannelOpenOk : RabbitMQ.Client.IMethod {
  }
  public partial interface IConnectionClose : RabbitMQ.Client.IMethod {
    ushort ClassId { get; }
    ushort MethodId { get; }
    ushort ReplyCode { get; }
    string ReplyText { get; }
  }
  public partial interface IConnectionCloseOk : RabbitMQ.Client.IMethod {
  }
  public partial interface IConnectionOpen : RabbitMQ.Client.IMethod {
    string Capabilities { get; }
    bool Insist { get; }
    string VirtualHost { get; }
  }
  public partial interface IConnectionOpenOk : RabbitMQ.Client.IMethod {
    string KnownHosts { get; }
  }
  public partial interface IConnectionRedirect : RabbitMQ.Client.IMethod {
    string Host { get; }
    string KnownHosts { get; }
  }
  public partial interface IConnectionSecure : RabbitMQ.Client.IMethod {
    System.Byte[] Challenge { get; }
  }
  public partial interface IConnectionSecureOk : RabbitMQ.Client.IMethod {
    System.Byte[] Response { get; }
  }
  public partial interface IConnectionStart : RabbitMQ.Client.IMethod {
    System.Byte[] Locales { get; }
    System.Byte[] Mechanisms { get; }
    System.Collections.IDictionary ServerProperties { get; }
    byte VersionMajor { get; }
    byte VersionMinor { get; }
  }
  public partial interface IConnectionStartOk : RabbitMQ.Client.IMethod {
    System.Collections.IDictionary ClientProperties { get; }
    string Locale { get; }
    string Mechanism { get; }
    System.Byte[] Response { get; }
  }
  public partial interface IConnectionTune : RabbitMQ.Client.IMethod {
    ushort ChannelMax { get; }
    uint FrameMax { get; }
    ushort Heartbeat { get; }
  }
  public partial interface IConnectionTuneOk : RabbitMQ.Client.IMethod {
    ushort ChannelMax { get; }
    uint FrameMax { get; }
    ushort Heartbeat { get; }
  }
  public partial interface IDtxSelect : RabbitMQ.Client.IMethod {
  }
  public partial interface IDtxSelectOk : RabbitMQ.Client.IMethod {
  }
  public partial interface IDtxStart : RabbitMQ.Client.IMethod {
    string DtxIdentifier { get; }
  }
  public partial interface IDtxStartOk : RabbitMQ.Client.IMethod {
  }
  public partial interface IExchangeDeclare : RabbitMQ.Client.IMethod {
    System.Collections.IDictionary Arguments { get; }
    bool AutoDelete { get; }
    bool Durable { get; }
    string Exchange { get; }
    bool Internal { get; }
    bool Nowait { get; }
    bool Passive { get; }
    ushort Ticket { get; }
    string Type { get; }
  }
  public partial interface IExchangeDeclareOk : RabbitMQ.Client.IMethod {
  }
  public partial interface IExchangeDelete : RabbitMQ.Client.IMethod {
    string Exchange { get; }
    bool IfUnused { get; }
    bool Nowait { get; }
    ushort Ticket { get; }
  }
  public partial interface IExchangeDeleteOk : RabbitMQ.Client.IMethod {
  }
  public partial interface IFileAck : RabbitMQ.Client.IMethod {
    ulong DeliveryTag { get; }
    bool Multiple { get; }
  }
  public partial interface IFileCancel : RabbitMQ.Client.IMethod {
    string ConsumerTag { get; }
    bool Nowait { get; }
  }
  public partial interface IFileCancelOk : RabbitMQ.Client.IMethod {
    string ConsumerTag { get; }
  }
  public partial interface IFileConsume : RabbitMQ.Client.IMethod {
    string ConsumerTag { get; }
    bool Exclusive { get; }
    bool NoAck { get; }
    bool NoLocal { get; }
    bool Nowait { get; }
    string Queue { get; }
    ushort Ticket { get; }
  }
  public partial interface IFileConsumeOk : RabbitMQ.Client.IMethod {
    string ConsumerTag { get; }
  }
  public partial interface IFileDeliver : RabbitMQ.Client.IMethod {
    string ConsumerTag { get; }
    ulong DeliveryTag { get; }
    string Exchange { get; }
    string Identifier { get; }
    bool Redelivered { get; }
    string RoutingKey { get; }
  }
  public partial interface IFileOpen : RabbitMQ.Client.IMethod {
    ulong ContentSize { get; }
    string Identifier { get; }
  }
  public partial interface IFileOpenOk : RabbitMQ.Client.IMethod {
    ulong StagedSize { get; }
  }
  public partial interface IFilePublish : RabbitMQ.Client.IMethod {
    string Exchange { get; }
    string Identifier { get; }
    bool Immediate { get; }
    bool Mandatory { get; }
    string RoutingKey { get; }
    ushort Ticket { get; }
  }
  public partial interface IFileQos : RabbitMQ.Client.IMethod {
    bool Global { get; }
    ushort PrefetchCount { get; }
    uint PrefetchSize { get; }
  }
  public partial interface IFileQosOk : RabbitMQ.Client.IMethod {
  }
  public partial interface IFileReject : RabbitMQ.Client.IMethod {
    ulong DeliveryTag { get; }
    bool Requeue { get; }
  }
  public partial interface IFileReturn : RabbitMQ.Client.IMethod {
    string Exchange { get; }
    ushort ReplyCode { get; }
    string ReplyText { get; }
    string RoutingKey { get; }
  }
  public partial interface IFileStage : RabbitMQ.Client.IMethod {
  }
  public partial interface IQueueBind : RabbitMQ.Client.IMethod {
    System.Collections.IDictionary Arguments { get; }
    string Exchange { get; }
    bool Nowait { get; }
    string Queue { get; }
    string RoutingKey { get; }
    ushort Ticket { get; }
  }
  public partial interface IQueueBindOk : RabbitMQ.Client.IMethod {
  }
  public partial interface IQueueDeclare : RabbitMQ.Client.IMethod {
    System.Collections.IDictionary Arguments { get; }
    bool AutoDelete { get; }
    bool Durable { get; }
    bool Exclusive { get; }
    bool Nowait { get; }
    bool Passive { get; }
    string Queue { get; }
    ushort Ticket { get; }
  }
  public partial interface IQueueDeclareOk : RabbitMQ.Client.IMethod {
    uint ConsumerCount { get; }
    uint MessageCount { get; }
    string Queue { get; }
  }
  public partial interface IQueueDelete : RabbitMQ.Client.IMethod {
    bool IfEmpty { get; }
    bool IfUnused { get; }
    bool Nowait { get; }
    string Queue { get; }
    ushort Ticket { get; }
  }
  public partial interface IQueueDeleteOk : RabbitMQ.Client.IMethod {
    uint MessageCount { get; }
  }
  public partial interface IQueuePurge : RabbitMQ.Client.IMethod {
    bool Nowait { get; }
    string Queue { get; }
    ushort Ticket { get; }
  }
  public partial interface IQueuePurgeOk : RabbitMQ.Client.IMethod {
    uint MessageCount { get; }
  }
  public partial interface IQueueUnbind : RabbitMQ.Client.IMethod {
    System.Collections.IDictionary Arguments { get; }
    string Exchange { get; }
    string Queue { get; }
    string RoutingKey { get; }
    ushort Ticket { get; }
  }
  public partial interface IQueueUnbindOk : RabbitMQ.Client.IMethod {
  }
  public partial interface IStreamCancel : RabbitMQ.Client.IMethod {
    string ConsumerTag { get; }
    bool Nowait { get; }
  }
  public partial interface IStreamCancelOk : RabbitMQ.Client.IMethod {
    string ConsumerTag { get; }
  }
  public partial interface IStreamConsume : RabbitMQ.Client.IMethod {
    string ConsumerTag { get; }
    bool Exclusive { get; }
    bool NoLocal { get; }
    bool Nowait { get; }
    string Queue { get; }
    ushort Ticket { get; }
  }
  public partial interface IStreamConsumeOk : RabbitMQ.Client.IMethod {
    string ConsumerTag { get; }
  }
  public partial interface IStreamDeliver : RabbitMQ.Client.IMethod {
    string ConsumerTag { get; }
    ulong DeliveryTag { get; }
    string Exchange { get; }
    string Queue { get; }
  }
  public partial interface IStreamPublish : RabbitMQ.Client.IMethod {
    string Exchange { get; }
    bool Immediate { get; }
    bool Mandatory { get; }
    string RoutingKey { get; }
    ushort Ticket { get; }
  }
  public partial interface IStreamQos : RabbitMQ.Client.IMethod {
    uint ConsumeRate { get; }
    bool Global { get; }
    ushort PrefetchCount { get; }
    uint PrefetchSize { get; }
  }
  public partial interface IStreamQosOk : RabbitMQ.Client.IMethod {
  }
  public partial interface IStreamReturn : RabbitMQ.Client.IMethod {
    string Exchange { get; }
    ushort ReplyCode { get; }
    string ReplyText { get; }
    string RoutingKey { get; }
  }
  public partial interface ITestContent : RabbitMQ.Client.IMethod {
  }
  public partial interface ITestContentOk : RabbitMQ.Client.IMethod {
    uint ContentChecksum { get; }
  }
  public partial interface ITestInteger : RabbitMQ.Client.IMethod {
    byte Integer1 { get; }
    ushort Integer2 { get; }
    uint Integer3 { get; }
    ulong Integer4 { get; }
    byte Operation { get; }
  }
  public partial interface ITestIntegerOk : RabbitMQ.Client.IMethod {
    ulong Result { get; }
  }
  public partial interface ITestString : RabbitMQ.Client.IMethod {
    byte Operation { get; }
    string String1 { get; }
    System.Byte[] String2 { get; }
  }
  public partial interface ITestStringOk : RabbitMQ.Client.IMethod {
    System.Byte[] Result { get; }
  }
  public partial interface ITestTable : RabbitMQ.Client.IMethod {
    byte IntegerOp { get; }
    byte StringOp { get; }
    System.Collections.IDictionary Table { get; }
  }
  public partial interface ITestTableOk : RabbitMQ.Client.IMethod {
    ulong IntegerResult { get; }
    System.Byte[] StringResult { get; }
  }
  public partial interface ITunnelRequest : RabbitMQ.Client.IMethod {
    System.Collections.IDictionary MetaData { get; }
  }
  public partial interface ITxCommit : RabbitMQ.Client.IMethod {
  }
  public partial interface ITxCommitOk : RabbitMQ.Client.IMethod {
  }
  public partial interface ITxRollback : RabbitMQ.Client.IMethod {
  }
  public partial interface ITxRollbackOk : RabbitMQ.Client.IMethod {
  }
  public partial interface ITxSelect : RabbitMQ.Client.IMethod {
  }
  public partial interface ITxSelectOk : RabbitMQ.Client.IMethod {
  }
  public partial class Protocol : RabbitMQ.Client.Framing.Impl.v0_8.ProtocolBase {
    public Protocol() { }
    public override string ApiName { get { return default(string); } }
    public override int DefaultPort { get { return default(int); } }
    public override int MajorVersion { get { return default(int); } }
    public override int MinorVersion { get { return default(int); } }
    public override RabbitMQ.Client.Impl.ContentHeaderBase DecodeContentHeaderFrom(RabbitMQ.Util.NetworkBinaryReader reader) { return default(RabbitMQ.Client.Impl.ContentHeaderBase); }
    public override RabbitMQ.Client.Impl.MethodBase DecodeMethodFrom(RabbitMQ.Util.NetworkBinaryReader reader) { return default(RabbitMQ.Client.Impl.MethodBase); }
  }
  public partial class StreamProperties : RabbitMQ.Client.Impl.StreamProperties {
    public StreamProperties() { }
    public override string ContentEncoding { get { return default(string); } set { } }
    public override string ContentType { get { return default(string); } set { } }
    public override System.Collections.IDictionary Headers { get { return default(System.Collections.IDictionary); } set { } }
    public override byte Priority { get { return default(byte); } set { } }
    public override int ProtocolClassId { get { return default(int); } }
    public override string ProtocolClassName { get { return default(string); } }
    public override RabbitMQ.Client.AmqpTimestamp Timestamp { get { return default(RabbitMQ.Client.AmqpTimestamp); } set { } }
    public override void AppendPropertyDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ClearContentEncoding() { }
    public override void ClearContentType() { }
    public override void ClearHeaders() { }
    public override void ClearPriority() { }
    public override void ClearTimestamp() { }
    public override bool IsContentEncodingPresent() { return default(bool); }
    public override bool IsContentTypePresent() { return default(bool); }
    public override bool IsHeadersPresent() { return default(bool); }
    public override bool IsPriorityPresent() { return default(bool); }
    public override bool IsTimestampPresent() { return default(bool); }
    public override void ReadPropertiesFrom(RabbitMQ.Client.Impl.ContentHeaderPropertyReader reader) { }
    public override void WritePropertiesTo(RabbitMQ.Client.Impl.ContentHeaderPropertyWriter writer) { }
  }
  public partial class TestProperties : RabbitMQ.Client.Impl.ContentHeaderBase {
    public TestProperties() { }
    public override int ProtocolClassId { get { return default(int); } }
    public override string ProtocolClassName { get { return default(string); } }
    public override void AppendPropertyDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadPropertiesFrom(RabbitMQ.Client.Impl.ContentHeaderPropertyReader reader) { }
    public override void WritePropertiesTo(RabbitMQ.Client.Impl.ContentHeaderPropertyWriter writer) { }
  }
  public partial class TunnelProperties : RabbitMQ.Client.Impl.ContentHeaderBase {
    public TunnelProperties() { }
    public byte Broadcast { get { return default(byte); } set { } }
    public string DataName { get { return default(string); } set { } }
    public byte Durable { get { return default(byte); } set { } }
    public System.Collections.IDictionary Headers { get { return default(System.Collections.IDictionary); } set { } }
    public override int ProtocolClassId { get { return default(int); } }
    public override string ProtocolClassName { get { return default(string); } }
    public string ProxyName { get { return default(string); } set { } }
    public override void AppendPropertyDebugStringTo(System.Text.StringBuilder sb) { }
    public void ClearBroadcast() { }
    public void ClearDataName() { }
    public void ClearDurable() { }
    public void ClearHeaders() { }
    public void ClearProxyName() { }
    public bool IsBroadcastPresent() { return default(bool); }
    public bool IsDataNamePresent() { return default(bool); }
    public bool IsDurablePresent() { return default(bool); }
    public bool IsHeadersPresent() { return default(bool); }
    public bool IsProxyNamePresent() { return default(bool); }
    public override void ReadPropertiesFrom(RabbitMQ.Client.Impl.ContentHeaderPropertyReader reader) { }
    public override void WritePropertiesTo(RabbitMQ.Client.Impl.ContentHeaderPropertyWriter writer) { }
  }
}
namespace RabbitMQ.Client.Framing.v0_8qpid {
  public partial class BasicProperties : RabbitMQ.Client.Impl.BasicProperties {
    public BasicProperties() { }
    public override string AppId { get { return default(string); } set { } }
    public override string ClusterId { get { return default(string); } set { } }
    public override string ContentEncoding { get { return default(string); } set { } }
    public override string ContentType { get { return default(string); } set { } }
    public override string CorrelationId { get { return default(string); } set { } }
    public override byte DeliveryMode { get { return default(byte); } set { } }
    public override string Expiration { get { return default(string); } set { } }
    public override System.Collections.IDictionary Headers { get { return default(System.Collections.IDictionary); } set { } }
    public override string MessageId { get { return default(string); } set { } }
    public override byte Priority { get { return default(byte); } set { } }
    public override int ProtocolClassId { get { return default(int); } }
    public override string ProtocolClassName { get { return default(string); } }
    public override string ReplyTo { get { return default(string); } set { } }
    public override RabbitMQ.Client.AmqpTimestamp Timestamp { get { return default(RabbitMQ.Client.AmqpTimestamp); } set { } }
    public override string Type { get { return default(string); } set { } }
    public override string UserId { get { return default(string); } set { } }
    public override void AppendPropertyDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ClearAppId() { }
    public override void ClearClusterId() { }
    public override void ClearContentEncoding() { }
    public override void ClearContentType() { }
    public override void ClearCorrelationId() { }
    public override void ClearDeliveryMode() { }
    public override void ClearExpiration() { }
    public override void ClearHeaders() { }
    public override void ClearMessageId() { }
    public override void ClearPriority() { }
    public override void ClearReplyTo() { }
    public override void ClearTimestamp() { }
    public override void ClearType() { }
    public override void ClearUserId() { }
    public override bool IsAppIdPresent() { return default(bool); }
    public override bool IsClusterIdPresent() { return default(bool); }
    public override bool IsContentEncodingPresent() { return default(bool); }
    public override bool IsContentTypePresent() { return default(bool); }
    public override bool IsCorrelationIdPresent() { return default(bool); }
    public override bool IsDeliveryModePresent() { return default(bool); }
    public override bool IsExpirationPresent() { return default(bool); }
    public override bool IsHeadersPresent() { return default(bool); }
    public override bool IsMessageIdPresent() { return default(bool); }
    public override bool IsPriorityPresent() { return default(bool); }
    public override bool IsReplyToPresent() { return default(bool); }
    public override bool IsTimestampPresent() { return default(bool); }
    public override bool IsTypePresent() { return default(bool); }
    public override bool IsUserIdPresent() { return default(bool); }
    public override void ReadPropertiesFrom(RabbitMQ.Client.Impl.ContentHeaderPropertyReader reader) { }
    public override void WritePropertiesTo(RabbitMQ.Client.Impl.ContentHeaderPropertyWriter writer) { }
  }
  public partial class Constants {
    public const int AccessRefused = 403;
    public const int ChannelError = 504;
    public const int CommandInvalid = 503;
    public const int ConnectionForced = 320;
    public const int ContentTooLarge = 311;
    public const int FrameBody = 3;
    public const int FrameEnd = 206;
    public const int FrameError = 501;
    public const int FrameHeader = 2;
    public const int FrameHeartbeat = 8;
    public const int FrameMethod = 1;
    public const int FrameMinSize = 4096;
    public const int FrameOobBody = 6;
    public const int FrameOobHeader = 5;
    public const int FrameOobMethod = 4;
    public const int FrameTrace = 7;
    public const int InternalError = 541;
    public const int InvalidPath = 402;
    public const int NotAllowed = 530;
    public const int NotDelivered = 310;
    public const int NotFound = 404;
    public const int NotImplemented = 540;
    public const int ReplySuccess = 200;
    public const int ResourceError = 506;
    public const int ResourceLocked = 405;
    public const int SyntaxError = 502;
    public Constants() { }
  }
  public partial class FileProperties : RabbitMQ.Client.Impl.FileProperties {
    public FileProperties() { }
    public override string ClusterId { get { return default(string); } set { } }
    public override string ContentEncoding { get { return default(string); } set { } }
    public override string ContentType { get { return default(string); } set { } }
    public override string Filename { get { return default(string); } set { } }
    public override System.Collections.IDictionary Headers { get { return default(System.Collections.IDictionary); } set { } }
    public override string MessageId { get { return default(string); } set { } }
    public override byte Priority { get { return default(byte); } set { } }
    public override int ProtocolClassId { get { return default(int); } }
    public override string ProtocolClassName { get { return default(string); } }
    public override string ReplyTo { get { return default(string); } set { } }
    public override RabbitMQ.Client.AmqpTimestamp Timestamp { get { return default(RabbitMQ.Client.AmqpTimestamp); } set { } }
    public override void AppendPropertyDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ClearClusterId() { }
    public override void ClearContentEncoding() { }
    public override void ClearContentType() { }
    public override void ClearFilename() { }
    public override void ClearHeaders() { }
    public override void ClearMessageId() { }
    public override void ClearPriority() { }
    public override void ClearReplyTo() { }
    public override void ClearTimestamp() { }
    public override bool IsClusterIdPresent() { return default(bool); }
    public override bool IsContentEncodingPresent() { return default(bool); }
    public override bool IsContentTypePresent() { return default(bool); }
    public override bool IsFilenamePresent() { return default(bool); }
    public override bool IsHeadersPresent() { return default(bool); }
    public override bool IsMessageIdPresent() { return default(bool); }
    public override bool IsPriorityPresent() { return default(bool); }
    public override bool IsReplyToPresent() { return default(bool); }
    public override bool IsTimestampPresent() { return default(bool); }
    public override void ReadPropertiesFrom(RabbitMQ.Client.Impl.ContentHeaderPropertyReader reader) { }
    public override void WritePropertiesTo(RabbitMQ.Client.Impl.ContentHeaderPropertyWriter writer) { }
  }
  public partial interface IAccessRequest : RabbitMQ.Client.IMethod {
    bool Active { get; }
    bool Exclusive { get; }
    bool Passive { get; }
    bool Read { get; }
    string Realm { get; }
    bool Write { get; }
  }
  public partial interface IAccessRequestOk : RabbitMQ.Client.IMethod {
    ushort Ticket { get; }
  }
  public partial interface IBasicAck : RabbitMQ.Client.IMethod {
    ulong DeliveryTag { get; }
    bool Multiple { get; }
  }
  public partial interface IBasicCancel : RabbitMQ.Client.IMethod {
    string ConsumerTag { get; }
    bool Nowait { get; }
  }
  public partial interface IBasicCancelOk : RabbitMQ.Client.IMethod {
    string ConsumerTag { get; }
  }
  public partial interface IBasicConsume : RabbitMQ.Client.IMethod {
    System.Collections.IDictionary Arguments { get; }
    string ConsumerTag { get; }
    bool Exclusive { get; }
    bool NoAck { get; }
    bool NoLocal { get; }
    bool Nowait { get; }
    string Queue { get; }
    ushort Ticket { get; }
  }
  public partial interface IBasicConsumeOk : RabbitMQ.Client.IMethod {
    string ConsumerTag { get; }
  }
  public partial interface IBasicDeliver : RabbitMQ.Client.IMethod {
    string ConsumerTag { get; }
    ulong DeliveryTag { get; }
    string Exchange { get; }
    bool Redelivered { get; }
    string RoutingKey { get; }
  }
  public partial interface IBasicGet : RabbitMQ.Client.IMethod {
    bool NoAck { get; }
    string Queue { get; }
    ushort Ticket { get; }
  }
  public partial interface IBasicGetEmpty : RabbitMQ.Client.IMethod {
    string ClusterId { get; }
  }
  public partial interface IBasicGetOk : RabbitMQ.Client.IMethod {
    ulong DeliveryTag { get; }
    string Exchange { get; }
    uint MessageCount { get; }
    bool Redelivered { get; }
    string RoutingKey { get; }
  }
  public partial interface IBasicPublish : RabbitMQ.Client.IMethod {
    string Exchange { get; }
    bool Immediate { get; }
    bool Mandatory { get; }
    string RoutingKey { get; }
    ushort Ticket { get; }
  }
  public partial interface IBasicQos : RabbitMQ.Client.IMethod {
    bool Global { get; }
    ushort PrefetchCount { get; }
    uint PrefetchSize { get; }
  }
  public partial interface IBasicQosOk : RabbitMQ.Client.IMethod {
  }
  public partial interface IBasicRecover : RabbitMQ.Client.IMethod {
    bool Requeue { get; }
  }
  public partial interface IBasicRecoverOk : RabbitMQ.Client.IMethod {
  }
  public partial interface IBasicReject : RabbitMQ.Client.IMethod {
    ulong DeliveryTag { get; }
    bool Requeue { get; }
  }
  public partial interface IBasicReturn : RabbitMQ.Client.IMethod {
    string Exchange { get; }
    ushort ReplyCode { get; }
    string ReplyText { get; }
    string RoutingKey { get; }
  }
  public partial interface IChannelAlert : RabbitMQ.Client.IMethod {
    System.Collections.IDictionary Details { get; }
    ushort ReplyCode { get; }
    string ReplyText { get; }
  }
  public partial interface IChannelClose : RabbitMQ.Client.IMethod {
    ushort ClassId { get; }
    ushort MethodId { get; }
    ushort ReplyCode { get; }
    string ReplyText { get; }
  }
  public partial interface IChannelCloseOk : RabbitMQ.Client.IMethod {
  }
  public partial interface IChannelFlow : RabbitMQ.Client.IMethod {
    bool Active { get; }
  }
  public partial interface IChannelFlowOk : RabbitMQ.Client.IMethod {
    bool Active { get; }
  }
  public partial interface IChannelOpen : RabbitMQ.Client.IMethod {
    string OutOfBand { get; }
  }
  public partial interface IChannelOpenOk : RabbitMQ.Client.IMethod {
  }
  public partial interface IConnectionClose : RabbitMQ.Client.IMethod {
    ushort ClassId { get; }
    ushort MethodId { get; }
    ushort ReplyCode { get; }
    string ReplyText { get; }
  }
  public partial interface IConnectionCloseOk : RabbitMQ.Client.IMethod {
  }
  public partial interface IConnectionOpen : RabbitMQ.Client.IMethod {
    string Capabilities { get; }
    bool Insist { get; }
    string VirtualHost { get; }
  }
  public partial interface IConnectionOpenOk : RabbitMQ.Client.IMethod {
    string KnownHosts { get; }
  }
  public partial interface IConnectionRedirect : RabbitMQ.Client.IMethod {
    string Host { get; }
    string KnownHosts { get; }
  }
  public partial interface IConnectionSecure : RabbitMQ.Client.IMethod {
    System.Byte[] Challenge { get; }
  }
  public partial interface IConnectionSecureOk : RabbitMQ.Client.IMethod {
    System.Byte[] Response { get; }
  }
  public partial interface IConnectionStart : RabbitMQ.Client.IMethod {
    System.Byte[] Locales { get; }
    System.Byte[] Mechanisms { get; }
    System.Collections.IDictionary ServerProperties { get; }
    byte VersionMajor { get; }
    byte VersionMinor { get; }
  }
  public partial interface IConnectionStartOk : RabbitMQ.Client.IMethod {
    System.Collections.IDictionary ClientProperties { get; }
    string Locale { get; }
    string Mechanism { get; }
    System.Byte[] Response { get; }
  }
  public partial interface IConnectionTune : RabbitMQ.Client.IMethod {
    ushort ChannelMax { get; }
    uint FrameMax { get; }
    ushort Heartbeat { get; }
  }
  public partial interface IConnectionTuneOk : RabbitMQ.Client.IMethod {
    ushort ChannelMax { get; }
    uint FrameMax { get; }
    ushort Heartbeat { get; }
  }
  public partial interface IDtxSelect : RabbitMQ.Client.IMethod {
  }
  public partial interface IDtxSelectOk : RabbitMQ.Client.IMethod {
  }
  public partial interface IDtxStart : RabbitMQ.Client.IMethod {
    string DtxIdentifier { get; }
  }
  public partial interface IDtxStartOk : RabbitMQ.Client.IMethod {
  }
  public partial interface IExchangeBound : RabbitMQ.Client.IMethod {
    string Exchange { get; }
    string Queue { get; }
    string RoutingKey { get; }
  }
  public partial interface IExchangeBoundOk : RabbitMQ.Client.IMethod {
    ushort ReplyCode { get; }
    string ReplyText { get; }
  }
  public partial interface IExchangeDeclare : RabbitMQ.Client.IMethod {
    System.Collections.IDictionary Arguments { get; }
    bool AutoDelete { get; }
    bool Durable { get; }
    string Exchange { get; }
    bool Internal { get; }
    bool Nowait { get; }
    bool Passive { get; }
    ushort Ticket { get; }
    string Type { get; }
  }
  public partial interface IExchangeDeclareOk : RabbitMQ.Client.IMethod {
  }
  public partial interface IExchangeDelete : RabbitMQ.Client.IMethod {
    string Exchange { get; }
    bool IfUnused { get; }
    bool Nowait { get; }
    ushort Ticket { get; }
  }
  public partial interface IExchangeDeleteOk : RabbitMQ.Client.IMethod {
  }
  public partial interface IFileAck : RabbitMQ.Client.IMethod {
    ulong DeliveryTag { get; }
    bool Multiple { get; }
  }
  public partial interface IFileCancel : RabbitMQ.Client.IMethod {
    string ConsumerTag { get; }
    bool Nowait { get; }
  }
  public partial interface IFileCancelOk : RabbitMQ.Client.IMethod {
    string ConsumerTag { get; }
  }
  public partial interface IFileConsume : RabbitMQ.Client.IMethod {
    string ConsumerTag { get; }
    bool Exclusive { get; }
    bool NoAck { get; }
    bool NoLocal { get; }
    bool Nowait { get; }
    string Queue { get; }
    ushort Ticket { get; }
  }
  public partial interface IFileConsumeOk : RabbitMQ.Client.IMethod {
    string ConsumerTag { get; }
  }
  public partial interface IFileDeliver : RabbitMQ.Client.IMethod {
    string ConsumerTag { get; }
    ulong DeliveryTag { get; }
    string Exchange { get; }
    string Identifier { get; }
    bool Redelivered { get; }
    string RoutingKey { get; }
  }
  public partial interface IFileOpen : RabbitMQ.Client.IMethod {
    ulong ContentSize { get; }
    string Identifier { get; }
  }
  public partial interface IFileOpenOk : RabbitMQ.Client.IMethod {
    ulong StagedSize { get; }
  }
  public partial interface IFilePublish : RabbitMQ.Client.IMethod {
    string Exchange { get; }
    string Identifier { get; }
    bool Immediate { get; }
    bool Mandatory { get; }
    string RoutingKey { get; }
    ushort Ticket { get; }
  }
  public partial interface IFileQos : RabbitMQ.Client.IMethod {
    bool Global { get; }
    ushort PrefetchCount { get; }
    uint PrefetchSize { get; }
  }
  public partial interface IFileQosOk : RabbitMQ.Client.IMethod {
  }
  public partial interface IFileReject : RabbitMQ.Client.IMethod {
    ulong DeliveryTag { get; }
    bool Requeue { get; }
  }
  public partial interface IFileReturn : RabbitMQ.Client.IMethod {
    string Exchange { get; }
    ushort ReplyCode { get; }
    string ReplyText { get; }
    string RoutingKey { get; }
  }
  public partial interface IFileStage : RabbitMQ.Client.IMethod {
  }
  public partial interface IQueueBind : RabbitMQ.Client.IMethod {
    System.Collections.IDictionary Arguments { get; }
    string Exchange { get; }
    bool Nowait { get; }
    string Queue { get; }
    string RoutingKey { get; }
    ushort Ticket { get; }
  }
  public partial interface IQueueBindOk : RabbitMQ.Client.IMethod {
  }
  public partial interface IQueueDeclare : RabbitMQ.Client.IMethod {
    System.Collections.IDictionary Arguments { get; }
    bool AutoDelete { get; }
    bool Durable { get; }
    bool Exclusive { get; }
    bool Nowait { get; }
    bool Passive { get; }
    string Queue { get; }
    ushort Ticket { get; }
  }
  public partial interface IQueueDeclareOk : RabbitMQ.Client.IMethod {
    uint ConsumerCount { get; }
    uint MessageCount { get; }
    string Queue { get; }
  }
  public partial interface IQueueDelete : RabbitMQ.Client.IMethod {
    bool IfEmpty { get; }
    bool IfUnused { get; }
    bool Nowait { get; }
    string Queue { get; }
    ushort Ticket { get; }
  }
  public partial interface IQueueDeleteOk : RabbitMQ.Client.IMethod {
    uint MessageCount { get; }
  }
  public partial interface IQueuePurge : RabbitMQ.Client.IMethod {
    bool Nowait { get; }
    string Queue { get; }
    ushort Ticket { get; }
  }
  public partial interface IQueuePurgeOk : RabbitMQ.Client.IMethod {
    uint MessageCount { get; }
  }
  public partial interface IStreamCancel : RabbitMQ.Client.IMethod {
    string ConsumerTag { get; }
    bool Nowait { get; }
  }
  public partial interface IStreamCancelOk : RabbitMQ.Client.IMethod {
    string ConsumerTag { get; }
  }
  public partial interface IStreamConsume : RabbitMQ.Client.IMethod {
    string ConsumerTag { get; }
    bool Exclusive { get; }
    bool NoLocal { get; }
    bool Nowait { get; }
    string Queue { get; }
    ushort Ticket { get; }
  }
  public partial interface IStreamConsumeOk : RabbitMQ.Client.IMethod {
    string ConsumerTag { get; }
  }
  public partial interface IStreamDeliver : RabbitMQ.Client.IMethod {
    string ConsumerTag { get; }
    ulong DeliveryTag { get; }
    string Exchange { get; }
    string Queue { get; }
  }
  public partial interface IStreamPublish : RabbitMQ.Client.IMethod {
    string Exchange { get; }
    bool Immediate { get; }
    bool Mandatory { get; }
    string RoutingKey { get; }
    ushort Ticket { get; }
  }
  public partial interface IStreamQos : RabbitMQ.Client.IMethod {
    uint ConsumeRate { get; }
    bool Global { get; }
    ushort PrefetchCount { get; }
    uint PrefetchSize { get; }
  }
  public partial interface IStreamQosOk : RabbitMQ.Client.IMethod {
  }
  public partial interface IStreamReturn : RabbitMQ.Client.IMethod {
    string Exchange { get; }
    ushort ReplyCode { get; }
    string ReplyText { get; }
    string RoutingKey { get; }
  }
  public partial interface ITestContent : RabbitMQ.Client.IMethod {
  }
  public partial interface ITestContentOk : RabbitMQ.Client.IMethod {
    uint ContentChecksum { get; }
  }
  public partial interface ITestInteger : RabbitMQ.Client.IMethod {
    byte Integer1 { get; }
    ushort Integer2 { get; }
    uint Integer3 { get; }
    ulong Integer4 { get; }
    byte Operation { get; }
  }
  public partial interface ITestIntegerOk : RabbitMQ.Client.IMethod {
    ulong Result { get; }
  }
  public partial interface ITestString : RabbitMQ.Client.IMethod {
    byte Operation { get; }
    string String1 { get; }
    System.Byte[] String2 { get; }
  }
  public partial interface ITestStringOk : RabbitMQ.Client.IMethod {
    System.Byte[] Result { get; }
  }
  public partial interface ITestTable : RabbitMQ.Client.IMethod {
    byte IntegerOp { get; }
    byte StringOp { get; }
    System.Collections.IDictionary Table { get; }
  }
  public partial interface ITestTableOk : RabbitMQ.Client.IMethod {
    ulong IntegerResult { get; }
    System.Byte[] StringResult { get; }
  }
  public partial interface ITunnelRequest : RabbitMQ.Client.IMethod {
    System.Collections.IDictionary MetaData { get; }
  }
  public partial interface ITxCommit : RabbitMQ.Client.IMethod {
  }
  public partial interface ITxCommitOk : RabbitMQ.Client.IMethod {
  }
  public partial interface ITxRollback : RabbitMQ.Client.IMethod {
  }
  public partial interface ITxRollbackOk : RabbitMQ.Client.IMethod {
  }
  public partial interface ITxSelect : RabbitMQ.Client.IMethod {
  }
  public partial interface ITxSelectOk : RabbitMQ.Client.IMethod {
  }
  public partial class Protocol : RabbitMQ.Client.Framing.Impl.v0_8qpid.ProtocolBase {
    public Protocol() { }
    public override string ApiName { get { return default(string); } }
    public override int DefaultPort { get { return default(int); } }
    public override int MajorVersion { get { return default(int); } }
    public override int MinorVersion { get { return default(int); } }
    public override RabbitMQ.Client.Impl.ContentHeaderBase DecodeContentHeaderFrom(RabbitMQ.Util.NetworkBinaryReader reader) { return default(RabbitMQ.Client.Impl.ContentHeaderBase); }
    public override RabbitMQ.Client.Impl.MethodBase DecodeMethodFrom(RabbitMQ.Util.NetworkBinaryReader reader) { return default(RabbitMQ.Client.Impl.MethodBase); }
  }
  public partial class StreamProperties : RabbitMQ.Client.Impl.StreamProperties {
    public StreamProperties() { }
    public override string ContentEncoding { get { return default(string); } set { } }
    public override string ContentType { get { return default(string); } set { } }
    public override System.Collections.IDictionary Headers { get { return default(System.Collections.IDictionary); } set { } }
    public override byte Priority { get { return default(byte); } set { } }
    public override int ProtocolClassId { get { return default(int); } }
    public override string ProtocolClassName { get { return default(string); } }
    public override RabbitMQ.Client.AmqpTimestamp Timestamp { get { return default(RabbitMQ.Client.AmqpTimestamp); } set { } }
    public override void AppendPropertyDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ClearContentEncoding() { }
    public override void ClearContentType() { }
    public override void ClearHeaders() { }
    public override void ClearPriority() { }
    public override void ClearTimestamp() { }
    public override bool IsContentEncodingPresent() { return default(bool); }
    public override bool IsContentTypePresent() { return default(bool); }
    public override bool IsHeadersPresent() { return default(bool); }
    public override bool IsPriorityPresent() { return default(bool); }
    public override bool IsTimestampPresent() { return default(bool); }
    public override void ReadPropertiesFrom(RabbitMQ.Client.Impl.ContentHeaderPropertyReader reader) { }
    public override void WritePropertiesTo(RabbitMQ.Client.Impl.ContentHeaderPropertyWriter writer) { }
  }
  public partial class TestProperties : RabbitMQ.Client.Impl.ContentHeaderBase {
    public TestProperties() { }
    public override int ProtocolClassId { get { return default(int); } }
    public override string ProtocolClassName { get { return default(string); } }
    public override void AppendPropertyDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ReadPropertiesFrom(RabbitMQ.Client.Impl.ContentHeaderPropertyReader reader) { }
    public override void WritePropertiesTo(RabbitMQ.Client.Impl.ContentHeaderPropertyWriter writer) { }
  }
  public partial class TunnelProperties : RabbitMQ.Client.Impl.ContentHeaderBase {
    public TunnelProperties() { }
    public byte Broadcast { get { return default(byte); } set { } }
    public string DataName { get { return default(string); } set { } }
    public byte Durable { get { return default(byte); } set { } }
    public System.Collections.IDictionary Headers { get { return default(System.Collections.IDictionary); } set { } }
    public override int ProtocolClassId { get { return default(int); } }
    public override string ProtocolClassName { get { return default(string); } }
    public string ProxyName { get { return default(string); } set { } }
    public override void AppendPropertyDebugStringTo(System.Text.StringBuilder sb) { }
    public void ClearBroadcast() { }
    public void ClearDataName() { }
    public void ClearDurable() { }
    public void ClearHeaders() { }
    public void ClearProxyName() { }
    public bool IsBroadcastPresent() { return default(bool); }
    public bool IsDataNamePresent() { return default(bool); }
    public bool IsDurablePresent() { return default(bool); }
    public bool IsHeadersPresent() { return default(bool); }
    public bool IsProxyNamePresent() { return default(bool); }
    public override void ReadPropertiesFrom(RabbitMQ.Client.Impl.ContentHeaderPropertyReader reader) { }
    public override void WritePropertiesTo(RabbitMQ.Client.Impl.ContentHeaderPropertyWriter writer) { }
  }
}
namespace RabbitMQ.Client.Framing.v0_9 {
  public partial class BasicProperties : RabbitMQ.Client.Impl.BasicProperties {
    public BasicProperties() { }
    public override string AppId { get { return default(string); } set { } }
    public override string ClusterId { get { return default(string); } set { } }
    public override string ContentEncoding { get { return default(string); } set { } }
    public override string ContentType { get { return default(string); } set { } }
    public override string CorrelationId { get { return default(string); } set { } }
    public override byte DeliveryMode { get { return default(byte); } set { } }
    public override string Expiration { get { return default(string); } set { } }
    public override System.Collections.IDictionary Headers { get { return default(System.Collections.IDictionary); } set { } }
    public override string MessageId { get { return default(string); } set { } }
    public override byte Priority { get { return default(byte); } set { } }
    public override int ProtocolClassId { get { return default(int); } }
    public override string ProtocolClassName { get { return default(string); } }
    public override string ReplyTo { get { return default(string); } set { } }
    public override RabbitMQ.Client.AmqpTimestamp Timestamp { get { return default(RabbitMQ.Client.AmqpTimestamp); } set { } }
    public override string Type { get { return default(string); } set { } }
    public override string UserId { get { return default(string); } set { } }
    public override void AppendPropertyDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ClearAppId() { }
    public override void ClearClusterId() { }
    public override void ClearContentEncoding() { }
    public override void ClearContentType() { }
    public override void ClearCorrelationId() { }
    public override void ClearDeliveryMode() { }
    public override void ClearExpiration() { }
    public override void ClearHeaders() { }
    public override void ClearMessageId() { }
    public override void ClearPriority() { }
    public override void ClearReplyTo() { }
    public override void ClearTimestamp() { }
    public override void ClearType() { }
    public override void ClearUserId() { }
    public override bool IsAppIdPresent() { return default(bool); }
    public override bool IsClusterIdPresent() { return default(bool); }
    public override bool IsContentEncodingPresent() { return default(bool); }
    public override bool IsContentTypePresent() { return default(bool); }
    public override bool IsCorrelationIdPresent() { return default(bool); }
    public override bool IsDeliveryModePresent() { return default(bool); }
    public override bool IsExpirationPresent() { return default(bool); }
    public override bool IsHeadersPresent() { return default(bool); }
    public override bool IsMessageIdPresent() { return default(bool); }
    public override bool IsPriorityPresent() { return default(bool); }
    public override bool IsReplyToPresent() { return default(bool); }
    public override bool IsTimestampPresent() { return default(bool); }
    public override bool IsTypePresent() { return default(bool); }
    public override bool IsUserIdPresent() { return default(bool); }
    public override void ReadPropertiesFrom(RabbitMQ.Client.Impl.ContentHeaderPropertyReader reader) { }
    public override void WritePropertiesTo(RabbitMQ.Client.Impl.ContentHeaderPropertyWriter writer) { }
  }
  public partial class Constants {
    public const int AccessRefused = 403;
    public const int ChannelError = 504;
    public const int CommandInvalid = 503;
    public const int ConnectionForced = 320;
    public const int ContentTooLarge = 311;
    public const int FrameBody = 3;
    public const int FrameEnd = 206;
    public const int FrameError = 501;
    public const int FrameHeader = 2;
    public const int FrameHeartbeat = 8;
    public const int FrameMethod = 1;
    public const int FrameMinSize = 4096;
    public const int FrameOobBody = 6;
    public const int FrameOobHeader = 5;
    public const int FrameOobMethod = 4;
    public const int FrameTrace = 7;
    public const int InternalError = 541;
    public const int InvalidPath = 402;
    public const int NoConsumers = 313;
    public const int NoRoute = 312;
    public const int NotAllowed = 530;
    public const int NotDelivered = 310;
    public const int NotFound = 404;
    public const int NotImplemented = 540;
    public const int PreconditionFailed = 406;
    public const int ReplySuccess = 200;
    public const int ResourceError = 506;
    public const int ResourceLocked = 405;
    public const int SyntaxError = 502;
    public Constants() { }
  }
  public partial class FileProperties : RabbitMQ.Client.Impl.FileProperties {
    public FileProperties() { }
    public override string ClusterId { get { return default(string); } set { } }
    public override string ContentEncoding { get { return default(string); } set { } }
    public override string ContentType { get { return default(string); } set { } }
    public override string Filename { get { return default(string); } set { } }
    public override System.Collections.IDictionary Headers { get { return default(System.Collections.IDictionary); } set { } }
    public override string MessageId { get { return default(string); } set { } }
    public override byte Priority { get { return default(byte); } set { } }
    public override int ProtocolClassId { get { return default(int); } }
    public override string ProtocolClassName { get { return default(string); } }
    public override string ReplyTo { get { return default(string); } set { } }
    public override RabbitMQ.Client.AmqpTimestamp Timestamp { get { return default(RabbitMQ.Client.AmqpTimestamp); } set { } }
    public override void AppendPropertyDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ClearClusterId() { }
    public override void ClearContentEncoding() { }
    public override void ClearContentType() { }
    public override void ClearFilename() { }
    public override void ClearHeaders() { }
    public override void ClearMessageId() { }
    public override void ClearPriority() { }
    public override void ClearReplyTo() { }
    public override void ClearTimestamp() { }
    public override bool IsClusterIdPresent() { return default(bool); }
    public override bool IsContentEncodingPresent() { return default(bool); }
    public override bool IsContentTypePresent() { return default(bool); }
    public override bool IsFilenamePresent() { return default(bool); }
    public override bool IsHeadersPresent() { return default(bool); }
    public override bool IsMessageIdPresent() { return default(bool); }
    public override bool IsPriorityPresent() { return default(bool); }
    public override bool IsReplyToPresent() { return default(bool); }
    public override bool IsTimestampPresent() { return default(bool); }
    public override void ReadPropertiesFrom(RabbitMQ.Client.Impl.ContentHeaderPropertyReader reader) { }
    public override void WritePropertiesTo(RabbitMQ.Client.Impl.ContentHeaderPropertyWriter writer) { }
  }
  public partial interface IAccessRequest : RabbitMQ.Client.IMethod {
    bool Active { get; }
    bool Exclusive { get; }
    bool Passive { get; }
    bool Read { get; }
    string Realm { get; }
    bool Write { get; }
  }
  public partial interface IAccessRequestOk : RabbitMQ.Client.IMethod {
    ushort Ticket { get; }
  }
  public partial interface IBasicAck : RabbitMQ.Client.IMethod {
    ulong DeliveryTag { get; }
    bool Multiple { get; }
  }
  public partial interface IBasicCancel : RabbitMQ.Client.IMethod {
    string ConsumerTag { get; }
    bool Nowait { get; }
  }
  public partial interface IBasicCancelOk : RabbitMQ.Client.IMethod {
    string ConsumerTag { get; }
  }
  public partial interface IBasicConsume : RabbitMQ.Client.IMethod {
    string ConsumerTag { get; }
    bool Exclusive { get; }
    System.Collections.IDictionary Filter { get; }
    bool NoAck { get; }
    bool NoLocal { get; }
    bool Nowait { get; }
    string Queue { get; }
    ushort Ticket { get; }
  }
  public partial interface IBasicConsumeOk : RabbitMQ.Client.IMethod {
    string ConsumerTag { get; }
  }
  public partial interface IBasicDeliver : RabbitMQ.Client.IMethod {
    string ConsumerTag { get; }
    ulong DeliveryTag { get; }
    string Exchange { get; }
    bool Redelivered { get; }
    string RoutingKey { get; }
  }
  public partial interface IBasicGet : RabbitMQ.Client.IMethod {
    bool NoAck { get; }
    string Queue { get; }
    ushort Ticket { get; }
  }
  public partial interface IBasicGetEmpty : RabbitMQ.Client.IMethod {
    string ClusterId { get; }
  }
  public partial interface IBasicGetOk : RabbitMQ.Client.IMethod {
    ulong DeliveryTag { get; }
    string Exchange { get; }
    uint MessageCount { get; }
    bool Redelivered { get; }
    string RoutingKey { get; }
  }
  public partial interface IBasicPublish : RabbitMQ.Client.IMethod {
    string Exchange { get; }
    bool Immediate { get; }
    bool Mandatory { get; }
    string RoutingKey { get; }
    ushort Ticket { get; }
  }
  public partial interface IBasicQos : RabbitMQ.Client.IMethod {
    bool Global { get; }
    ushort PrefetchCount { get; }
    uint PrefetchSize { get; }
  }
  public partial interface IBasicQosOk : RabbitMQ.Client.IMethod {
  }
  public partial interface IBasicRecover : RabbitMQ.Client.IMethod {
    bool Requeue { get; }
  }
  public partial interface IBasicReject : RabbitMQ.Client.IMethod {
    ulong DeliveryTag { get; }
    bool Requeue { get; }
  }
  public partial interface IBasicReturn : RabbitMQ.Client.IMethod {
    string Exchange { get; }
    ushort ReplyCode { get; }
    string ReplyText { get; }
    string RoutingKey { get; }
  }
  public partial interface IChannelClose : RabbitMQ.Client.IMethod {
    ushort ClassId { get; }
    ushort MethodId { get; }
    ushort ReplyCode { get; }
    string ReplyText { get; }
  }
  public partial interface IChannelCloseOk : RabbitMQ.Client.IMethod {
  }
  public partial interface IChannelFlow : RabbitMQ.Client.IMethod {
    bool Active { get; }
  }
  public partial interface IChannelFlowOk : RabbitMQ.Client.IMethod {
    bool Active { get; }
  }
  public partial interface IChannelOk : RabbitMQ.Client.IMethod {
  }
  public partial interface IChannelOpen : RabbitMQ.Client.IMethod {
    string OutOfBand { get; }
  }
  public partial interface IChannelOpenOk : RabbitMQ.Client.IMethod {
    System.Byte[] ChannelId { get; }
  }
  public partial interface IChannelPing : RabbitMQ.Client.IMethod {
  }
  public partial interface IChannelPong : RabbitMQ.Client.IMethod {
  }
  public partial interface IChannelResume : RabbitMQ.Client.IMethod {
    System.Byte[] ChannelId { get; }
  }
  public partial interface IConnectionClose : RabbitMQ.Client.IMethod {
    ushort ClassId { get; }
    ushort MethodId { get; }
    ushort ReplyCode { get; }
    string ReplyText { get; }
  }
  public partial interface IConnectionCloseOk : RabbitMQ.Client.IMethod {
  }
  public partial interface IConnectionOpen : RabbitMQ.Client.IMethod {
    string Capabilities { get; }
    bool Insist { get; }
    string VirtualHost { get; }
  }
  public partial interface IConnectionOpenOk : RabbitMQ.Client.IMethod {
    string KnownHosts { get; }
  }
  public partial interface IConnectionRedirect : RabbitMQ.Client.IMethod {
    string Host { get; }
    string KnownHosts { get; }
  }
  public partial interface IConnectionSecure : RabbitMQ.Client.IMethod {
    System.Byte[] Challenge { get; }
  }
  public partial interface IConnectionSecureOk : RabbitMQ.Client.IMethod {
    System.Byte[] Response { get; }
  }
  public partial interface IConnectionStart : RabbitMQ.Client.IMethod {
    System.Byte[] Locales { get; }
    System.Byte[] Mechanisms { get; }
    System.Collections.IDictionary ServerProperties { get; }
    byte VersionMajor { get; }
    byte VersionMinor { get; }
  }
  public partial interface IConnectionStartOk : RabbitMQ.Client.IMethod {
    System.Collections.IDictionary ClientProperties { get; }
    string Locale { get; }
    string Mechanism { get; }
    System.Byte[] Response { get; }
  }
  public partial interface IConnectionTune : RabbitMQ.Client.IMethod {
    ushort ChannelMax { get; }
    uint FrameMax { get; }
    ushort Heartbeat { get; }
  }
  public partial interface IConnectionTuneOk : RabbitMQ.Client.IMethod {
    ushort ChannelMax { get; }
    uint FrameMax { get; }
    ushort Heartbeat { get; }
  }
  public partial interface IDtxSelect : RabbitMQ.Client.IMethod {
  }
  public partial interface IDtxSelectOk : RabbitMQ.Client.IMethod {
  }
  public partial interface IDtxStart : RabbitMQ.Client.IMethod {
    string DtxIdentifier { get; }
  }
  public partial interface IDtxStartOk : RabbitMQ.Client.IMethod {
  }
  public partial interface IExchangeDeclare : RabbitMQ.Client.IMethod {
    System.Collections.IDictionary Arguments { get; }
    bool AutoDelete { get; }
    bool Durable { get; }
    string Exchange { get; }
    bool Internal { get; }
    bool Nowait { get; }
    bool Passive { get; }
    ushort Ticket { get; }
    string Type { get; }
  }
  public partial interface IExchangeDeclareOk : RabbitMQ.Client.IMethod {
  }
  public partial interface IExchangeDelete : RabbitMQ.Client.IMethod {
    string Exchange { get; }
    bool IfUnused { get; }
    bool Nowait { get; }
    ushort Ticket { get; }
  }
  public partial interface IExchangeDeleteOk : RabbitMQ.Client.IMethod {
  }
  public partial interface IFileAck : RabbitMQ.Client.IMethod {
    ulong DeliveryTag { get; }
    bool Multiple { get; }
  }
  public partial interface IFileCancel : RabbitMQ.Client.IMethod {
    string ConsumerTag { get; }
    bool Nowait { get; }
  }
  public partial interface IFileCancelOk : RabbitMQ.Client.IMethod {
    string ConsumerTag { get; }
  }
  public partial interface IFileConsume : RabbitMQ.Client.IMethod {
    string ConsumerTag { get; }
    bool Exclusive { get; }
    System.Collections.IDictionary Filter { get; }
    bool NoAck { get; }
    bool NoLocal { get; }
    bool Nowait { get; }
    string Queue { get; }
    ushort Ticket { get; }
  }
  public partial interface IFileConsumeOk : RabbitMQ.Client.IMethod {
    string ConsumerTag { get; }
  }
  public partial interface IFileDeliver : RabbitMQ.Client.IMethod {
    string ConsumerTag { get; }
    ulong DeliveryTag { get; }
    string Exchange { get; }
    string Identifier { get; }
    bool Redelivered { get; }
    string RoutingKey { get; }
  }
  public partial interface IFileOpen : RabbitMQ.Client.IMethod {
    ulong ContentSize { get; }
    string Identifier { get; }
  }
  public partial interface IFileOpenOk : RabbitMQ.Client.IMethod {
    ulong StagedSize { get; }
  }
  public partial interface IFilePublish : RabbitMQ.Client.IMethod {
    string Exchange { get; }
    string Identifier { get; }
    bool Immediate { get; }
    bool Mandatory { get; }
    string RoutingKey { get; }
    ushort Ticket { get; }
  }
  public partial interface IFileQos : RabbitMQ.Client.IMethod {
    bool Global { get; }
    ushort PrefetchCount { get; }
    uint PrefetchSize { get; }
  }
  public partial interface IFileQosOk : RabbitMQ.Client.IMethod {
  }
  public partial interface IFileReject : RabbitMQ.Client.IMethod {
    ulong DeliveryTag { get; }
    bool Requeue { get; }
  }
  public partial interface IFileReturn : RabbitMQ.Client.IMethod {
    string Exchange { get; }
    ushort ReplyCode { get; }
    string ReplyText { get; }
    string RoutingKey { get; }
  }
  public partial interface IFileStage : RabbitMQ.Client.IMethod {
  }
  public partial interface IMessageAppend : RabbitMQ.Client.IMethod {
    System.Byte[] Bytes { get; }
    System.Byte[] Reference { get; }
  }
  public partial interface IMessageCancel : RabbitMQ.Client.IMethod {
    string Destination { get; }
  }
  public partial interface IMessageCheckpoint : RabbitMQ.Client.IMethod {
    string Identifier { get; }
    System.Byte[] Reference { get; }
  }
  public partial interface IMessageClose : RabbitMQ.Client.IMethod {
    System.Byte[] Reference { get; }
  }
  public partial interface IMessageConsume : RabbitMQ.Client.IMethod {
    string Destination { get; }
    bool Exclusive { get; }
    System.Collections.IDictionary Filter { get; }
    bool NoAck { get; }
    bool NoLocal { get; }
    string Queue { get; }
    ushort Ticket { get; }
  }
  public partial interface IMessageEmpty : RabbitMQ.Client.IMethod {
  }
  public partial interface IMessageGet : RabbitMQ.Client.IMethod {
    string Destination { get; }
    bool NoAck { get; }
    string Queue { get; }
    ushort Ticket { get; }
  }
  public partial interface IMessageOffset : RabbitMQ.Client.IMethod {
    ulong Value { get; }
  }
  public partial interface IMessageOk : RabbitMQ.Client.IMethod {
  }
  public partial interface IMessageOpen : RabbitMQ.Client.IMethod {
    System.Byte[] Reference { get; }
  }
  public partial interface IMessageQos : RabbitMQ.Client.IMethod {
    bool Global { get; }
    ushort PrefetchCount { get; }
    uint PrefetchSize { get; }
  }
  public partial interface IMessageRecover : RabbitMQ.Client.IMethod {
    bool Requeue { get; }
  }
  public partial interface IMessageReject : RabbitMQ.Client.IMethod {
    ushort Code { get; }
    string Text { get; }
  }
  public partial interface IMessageResume : RabbitMQ.Client.IMethod {
    string Identifier { get; }
    System.Byte[] Reference { get; }
  }
  public partial interface IMessageTransfer : RabbitMQ.Client.IMethod {
    string AppId { get; }
    System.Collections.IDictionary ApplicationHeaders { get; }
    System.Byte[] Body { get; }
    string ContentEncoding { get; }
    string ContentType { get; }
    string CorrelationId { get; }
    byte DeliveryMode { get; }
    string Destination { get; }
    string Exchange { get; }
    RabbitMQ.Client.AmqpTimestamp Expiration { get; }
    bool Immediate { get; }
    string MessageId { get; }
    byte Priority { get; }
    bool Redelivered { get; }
    string ReplyTo { get; }
    string RoutingKey { get; }
    System.Byte[] SecurityToken { get; }
    ushort Ticket { get; }
    RabbitMQ.Client.AmqpTimestamp Timestamp { get; }
    string TransactionId { get; }
    ulong Ttl { get; }
    string UserId { get; }
  }
  public partial interface IQueueBind : RabbitMQ.Client.IMethod {
    System.Collections.IDictionary Arguments { get; }
    string Exchange { get; }
    bool Nowait { get; }
    string Queue { get; }
    string RoutingKey { get; }
    ushort Ticket { get; }
  }
  public partial interface IQueueBindOk : RabbitMQ.Client.IMethod {
  }
  public partial interface IQueueDeclare : RabbitMQ.Client.IMethod {
    System.Collections.IDictionary Arguments { get; }
    bool AutoDelete { get; }
    bool Durable { get; }
    bool Exclusive { get; }
    bool Nowait { get; }
    bool Passive { get; }
    string Queue { get; }
    ushort Ticket { get; }
  }
  public partial interface IQueueDeclareOk : RabbitMQ.Client.IMethod {
    uint ConsumerCount { get; }
    uint MessageCount { get; }
    string Queue { get; }
  }
  public partial interface IQueueDelete : RabbitMQ.Client.IMethod {
    bool IfEmpty { get; }
    bool IfUnused { get; }
    bool Nowait { get; }
    string Queue { get; }
    ushort Ticket { get; }
  }
  public partial interface IQueueDeleteOk : RabbitMQ.Client.IMethod {
    uint MessageCount { get; }
  }
  public partial interface IQueuePurge : RabbitMQ.Client.IMethod {
    bool Nowait { get; }
    string Queue { get; }
    ushort Ticket { get; }
  }
  public partial interface IQueuePurgeOk : RabbitMQ.Client.IMethod {
    uint MessageCount { get; }
  }
  public partial interface IQueueUnbind : RabbitMQ.Client.IMethod {
    System.Collections.IDictionary Arguments { get; }
    string Exchange { get; }
    string Queue { get; }
    string RoutingKey { get; }
    ushort Ticket { get; }
  }
  public partial interface IQueueUnbindOk : RabbitMQ.Client.IMethod {
  }
  public partial interface IStreamCancel : RabbitMQ.Client.IMethod {
    string ConsumerTag { get; }
    bool Nowait { get; }
  }
  public partial interface IStreamCancelOk : RabbitMQ.Client.IMethod {
    string ConsumerTag { get; }
  }
  public partial interface IStreamConsume : RabbitMQ.Client.IMethod {
    string ConsumerTag { get; }
    bool Exclusive { get; }
    System.Collections.IDictionary Filter { get; }
    bool NoLocal { get; }
    bool Nowait { get; }
    string Queue { get; }
    ushort Ticket { get; }
  }
  public partial interface IStreamConsumeOk : RabbitMQ.Client.IMethod {
    string ConsumerTag { get; }
  }
  public partial interface IStreamDeliver : RabbitMQ.Client.IMethod {
    string ConsumerTag { get; }
    ulong DeliveryTag { get; }
    string Exchange { get; }
    string Queue { get; }
  }
  public partial interface IStreamPublish : RabbitMQ.Client.IMethod {
    string Exchange { get; }
    bool Immediate { get; }
    bool Mandatory { get; }
    string RoutingKey { get; }
    ushort Ticket { get; }
  }
  public partial interface IStreamQos : RabbitMQ.Client.IMethod {
    uint ConsumeRate { get; }
    bool Global { get; }
    ushort PrefetchCount { get; }
    uint PrefetchSize { get; }
  }
  public partial interface IStreamQosOk : RabbitMQ.Client.IMethod {
  }
  public partial interface IStreamReturn : RabbitMQ.Client.IMethod {
    string Exchange { get; }
    ushort ReplyCode { get; }
    string ReplyText { get; }
    string RoutingKey { get; }
  }
  public partial interface ITunnelRequest : RabbitMQ.Client.IMethod {
    System.Collections.IDictionary MetaData { get; }
  }
  public partial interface ITxCommit : RabbitMQ.Client.IMethod {
  }
  public partial interface ITxCommitOk : RabbitMQ.Client.IMethod {
  }
  public partial interface ITxRollback : RabbitMQ.Client.IMethod {
  }
  public partial interface ITxRollbackOk : RabbitMQ.Client.IMethod {
  }
  public partial interface ITxSelect : RabbitMQ.Client.IMethod {
  }
  public partial interface ITxSelectOk : RabbitMQ.Client.IMethod {
  }
  public partial class Protocol : RabbitMQ.Client.Framing.Impl.v0_9.ProtocolBase {
    public Protocol() { }
    public override string ApiName { get { return default(string); } }
    public override int DefaultPort { get { return default(int); } }
    public override int MajorVersion { get { return default(int); } }
    public override int MinorVersion { get { return default(int); } }
    public override RabbitMQ.Client.Impl.ContentHeaderBase DecodeContentHeaderFrom(RabbitMQ.Util.NetworkBinaryReader reader) { return default(RabbitMQ.Client.Impl.ContentHeaderBase); }
    public override RabbitMQ.Client.Impl.MethodBase DecodeMethodFrom(RabbitMQ.Util.NetworkBinaryReader reader) { return default(RabbitMQ.Client.Impl.MethodBase); }
  }
  public partial class StreamProperties : RabbitMQ.Client.Impl.StreamProperties {
    public StreamProperties() { }
    public override string ContentEncoding { get { return default(string); } set { } }
    public override string ContentType { get { return default(string); } set { } }
    public override System.Collections.IDictionary Headers { get { return default(System.Collections.IDictionary); } set { } }
    public override byte Priority { get { return default(byte); } set { } }
    public override int ProtocolClassId { get { return default(int); } }
    public override string ProtocolClassName { get { return default(string); } }
    public override RabbitMQ.Client.AmqpTimestamp Timestamp { get { return default(RabbitMQ.Client.AmqpTimestamp); } set { } }
    public override void AppendPropertyDebugStringTo(System.Text.StringBuilder sb) { }
    public override void ClearContentEncoding() { }
    public override void ClearContentType() { }
    public override void ClearHeaders() { }
    public override void ClearPriority() { }
    public override void ClearTimestamp() { }
    public override bool IsContentEncodingPresent() { return default(bool); }
    public override bool IsContentTypePresent() { return default(bool); }
    public override bool IsHeadersPresent() { return default(bool); }
    public override bool IsPriorityPresent() { return default(bool); }
    public override bool IsTimestampPresent() { return default(bool); }
    public override void ReadPropertiesFrom(RabbitMQ.Client.Impl.ContentHeaderPropertyReader reader) { }
    public override void WritePropertiesTo(RabbitMQ.Client.Impl.ContentHeaderPropertyWriter writer) { }
  }
  public partial class TunnelProperties : RabbitMQ.Client.Impl.ContentHeaderBase {
    public TunnelProperties() { }
    public byte Broadcast { get { return default(byte); } set { } }
    public string DataName { get { return default(string); } set { } }
    public byte Durable { get { return default(byte); } set { } }
    public System.Collections.IDictionary Headers { get { return default(System.Collections.IDictionary); } set { } }
    public override int ProtocolClassId { get { return default(int); } }
    public override string ProtocolClassName { get { return default(string); } }
    public string ProxyName { get { return default(string); } set { } }
    public override void AppendPropertyDebugStringTo(System.Text.StringBuilder sb) { }
    public void ClearBroadcast() { }
    public void ClearDataName() { }
    public void ClearDurable() { }
    public void ClearHeaders() { }
    public void ClearProxyName() { }
    public bool IsBroadcastPresent() { return default(bool); }
    public bool IsDataNamePresent() { return default(bool); }
    public bool IsDurablePresent() { return default(bool); }
    public bool IsHeadersPresent() { return default(bool); }
    public bool IsProxyNamePresent() { return default(bool); }
    public override void ReadPropertiesFrom(RabbitMQ.Client.Impl.ContentHeaderPropertyReader reader) { }
    public override void WritePropertiesTo(RabbitMQ.Client.Impl.ContentHeaderPropertyWriter writer) { }
  }
}
namespace RabbitMQ.Client.Impl {
  public abstract partial class AbstractProtocolBase : RabbitMQ.Client.IProtocol {
    protected AbstractProtocolBase() { }
    public abstract string ApiName { get; }
    public abstract int DefaultPort { get; }
    public abstract int MajorVersion { get; }
    public abstract int MinorVersion { get; }
    public RabbitMQ.Client.AmqpVersion Version { get { return default(RabbitMQ.Client.AmqpVersion); } }
    public abstract bool CanSendWhileClosed(RabbitMQ.Client.Impl.Command cmd);
    public abstract void CreateChannelClose(ushort reasonCode, string reasonText, out RabbitMQ.Client.Impl.Command request, out int replyClassId, out int replyMethodId);
    public abstract RabbitMQ.Client.IConnection CreateConnection(RabbitMQ.Client.ConnectionFactory factory, bool insist, RabbitMQ.Client.Impl.IFrameHandler frameHandler);
    public abstract void CreateConnectionClose(ushort reasonCode, string reasonText, out RabbitMQ.Client.Impl.Command request, out int replyClassId, out int replyMethodId);
    public abstract RabbitMQ.Client.Impl.IFrameHandler CreateFrameHandler(RabbitMQ.Client.AmqpTcpEndpoint endpoint);
    public abstract RabbitMQ.Client.IModel CreateModel(RabbitMQ.Client.Impl.ISession session);
    public abstract RabbitMQ.Client.Impl.ContentHeaderBase DecodeContentHeaderFrom(RabbitMQ.Util.NetworkBinaryReader reader);
    public abstract RabbitMQ.Client.Impl.MethodBase DecodeMethodFrom(RabbitMQ.Util.NetworkBinaryReader reader);
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
  }
  public enum AssemblyState {
    Complete = 3,
    ExpectingContentBody = 2,
    ExpectingContentHeader = 1,
    ExpectingMethod = 0,
  }
  public abstract partial class BasicProperties : RabbitMQ.Client.Impl.ContentHeaderBase, RabbitMQ.Client.IBasicProperties, RabbitMQ.Client.IContentHeader, System.ICloneable {
    protected BasicProperties() { }
    public abstract string AppId { get; set; }
    public abstract string ClusterId { get; set; }
    public abstract string ContentEncoding { get; set; }
    public abstract string ContentType { get; set; }
    public abstract string CorrelationId { get; set; }
    public abstract byte DeliveryMode { get; set; }
    public abstract string Expiration { get; set; }
    public abstract System.Collections.IDictionary Headers { get; set; }
    public abstract string MessageId { get; set; }
    public abstract byte Priority { get; set; }
    public abstract string ReplyTo { get; set; }
    public RabbitMQ.Client.PublicationAddress ReplyToAddress { get { return default(RabbitMQ.Client.PublicationAddress); } set { } }
    public abstract RabbitMQ.Client.AmqpTimestamp Timestamp { get; set; }
    public abstract string Type { get; set; }
    public abstract string UserId { get; set; }
    public abstract void ClearAppId();
    public abstract void ClearClusterId();
    public abstract void ClearContentEncoding();
    public abstract void ClearContentType();
    public abstract void ClearCorrelationId();
    public abstract void ClearDeliveryMode();
    public abstract void ClearExpiration();
    public abstract void ClearHeaders();
    public abstract void ClearMessageId();
    public abstract void ClearPriority();
    public abstract void ClearReplyTo();
    public abstract void ClearTimestamp();
    public abstract void ClearType();
    public abstract void ClearUserId();
    public override object Clone() { return default(object); }
    public abstract bool IsAppIdPresent();
    public abstract bool IsClusterIdPresent();
    public abstract bool IsContentEncodingPresent();
    public abstract bool IsContentTypePresent();
    public abstract bool IsCorrelationIdPresent();
    public abstract bool IsDeliveryModePresent();
    public abstract bool IsExpirationPresent();
    public abstract bool IsHeadersPresent();
    public abstract bool IsMessageIdPresent();
    public abstract bool IsPriorityPresent();
    public abstract bool IsReplyToPresent();
    public abstract bool IsTimestampPresent();
    public abstract bool IsTypePresent();
    public abstract bool IsUserIdPresent();
    public void SetPersistent(bool persistent) { }
  }
  public partial class ChannelErrorException : RabbitMQ.Client.Impl.HardProtocolException {
    public ChannelErrorException(int channel) : base (default(string)) { }
    public int Channel { get { return default(int); } }
    public override ushort ReplyCode { get { return default(ushort); } }
  }
  public partial class Command {
    public const int EmptyContentBodyFrameSize = 8;
    public System.Byte[] m_body0;
    public System.Collections.ArrayList m_bodyN;
    public RabbitMQ.Client.Impl.ContentHeaderBase m_header;
    public RabbitMQ.Client.Impl.MethodBase m_method;
    public Command() { }
    public Command(RabbitMQ.Client.Impl.MethodBase method) { }
    public Command(RabbitMQ.Client.Impl.MethodBase method, RabbitMQ.Client.Impl.ContentHeaderBase header, System.Byte[] body) { }
    public System.Byte[] Body { get { return default(System.Byte[]); } }
    public RabbitMQ.Client.Impl.ContentHeaderBase Header { get { return default(RabbitMQ.Client.Impl.ContentHeaderBase); } }
    public RabbitMQ.Client.Impl.MethodBase Method { get { return default(RabbitMQ.Client.Impl.MethodBase); } }
    public void AppendBodyFragment(System.Byte[] fragment) { }
    public static void CheckEmptyContentBodyFrameSize() { }
    public System.Byte[] ConsolidateBody() { return default(System.Byte[]); }
    public void Transmit(int channelNumber, RabbitMQ.Client.Impl.ConnectionBase connection) { }
  }
  public partial class CommandAssembler {
    public RabbitMQ.Client.Impl.Command m_command;
    public RabbitMQ.Client.Impl.AbstractProtocolBase m_protocol;
    public ulong m_remainingBodyBytes;
    public RabbitMQ.Client.Impl.AssemblyState m_state;
    public CommandAssembler(RabbitMQ.Client.Impl.AbstractProtocolBase protocol) { }
    public RabbitMQ.Client.Impl.Command HandleFrame(RabbitMQ.Client.Impl.Frame f) { return default(RabbitMQ.Client.Impl.Command); }
  }
  public delegate void CommandHandler(RabbitMQ.Client.Impl.ISession session, RabbitMQ.Client.Impl.Command cmd);
  public abstract partial class ConnectionBase : RabbitMQ.Client.IConnection, System.IDisposable {
    public static int ConnectionCloseTimeout;
    public static int HandshakeTimeout;
    public System.Threading.ManualResetEvent m_appContinuation;
    public RabbitMQ.Client.Events.CallbackExceptionEventHandler m_callbackException;
    public System.Collections.IDictionary m_clientProperties;
    public bool m_closed;
    public RabbitMQ.Client.ShutdownEventArgs m_closeReason;
    public RabbitMQ.Client.Events.ConnectionShutdownEventHandler m_connectionShutdown;
    public readonly object m_eventLock;
    public RabbitMQ.Client.ConnectionFactory m_factory;
    public RabbitMQ.Client.Impl.IFrameHandler m_frameHandler;
    public uint m_frameMax;
    public ushort m_heartbeat;
    public readonly RabbitMQ.Client.Impl.Frame m_heartbeatFrame;
    public System.Threading.AutoResetEvent m_heartbeatRead;
    public System.Threading.AutoResetEvent m_heartbeatWrite;
    public System.Guid m_id;
    public RabbitMQ.Client.AmqpTcpEndpoint[] m_knownHosts;
    public int m_missedHeartbeats;
    public RabbitMQ.Client.Impl.ModelBase m_model0;
    public bool m_running;
    public System.Collections.IDictionary m_serverProperties;
    public RabbitMQ.Client.Impl.MainSession m_session0;
    public RabbitMQ.Client.Impl.SessionManager m_sessionManager;
    public System.Collections.IList m_shutdownReport;
    public ConnectionBase(RabbitMQ.Client.ConnectionFactory factory, bool insist, RabbitMQ.Client.Impl.IFrameHandler frameHandler) { }
    public bool AutoClose { get { return default(bool); } set { } }
    public ushort ChannelMax { get { return default(ushort); } }
    public System.Collections.IDictionary ClientProperties { get { return default(System.Collections.IDictionary); } set { } }
    public RabbitMQ.Client.ShutdownEventArgs CloseReason { get { return default(RabbitMQ.Client.ShutdownEventArgs); } }
    public RabbitMQ.Client.AmqpTcpEndpoint Endpoint { get { return default(RabbitMQ.Client.AmqpTcpEndpoint); } }
    public uint FrameMax { get { return default(uint); } set { } }
    public ushort Heartbeat { get { return default(ushort); } set { } }
    public bool IsOpen { get { return default(bool); } }
    public RabbitMQ.Client.AmqpTcpEndpoint[] KnownHosts { get { return default(RabbitMQ.Client.AmqpTcpEndpoint[]); } set { } }
    public RabbitMQ.Client.Impl.AbstractProtocolBase Protocol { get { return default(RabbitMQ.Client.Impl.AbstractProtocolBase); } }
    RabbitMQ.Client.IProtocol RabbitMQ.Client.IConnection.Protocol { get { return default(RabbitMQ.Client.IProtocol); } }
    public System.Collections.IDictionary ServerProperties { get { return default(System.Collections.IDictionary); } set { } }
    public System.Collections.IList ShutdownReport { get { return default(System.Collections.IList); } }
    public event RabbitMQ.Client.Events.CallbackExceptionEventHandler CallbackException { add { } remove { } }
    public event RabbitMQ.Client.Events.ConnectionShutdownEventHandler ConnectionShutdown { add { } remove { } }
    public void Abort() { }
    public void Abort(int timeout) { }
    public void Abort(ushort reasonCode, string reasonText) { }
    public void Abort(ushort reasonCode, string reasonText, RabbitMQ.Client.ShutdownInitiator initiator, int timeout) { }
    public void Abort(ushort reasonCode, string reasonText, int timeout) { }
    public void Close() { }
    public void Close(RabbitMQ.Client.ShutdownEventArgs reason) { }
    public void Close(RabbitMQ.Client.ShutdownEventArgs reason, bool abort, int timeout) { }
    public void Close(int timeout) { }
    public void Close(ushort reasonCode, string reasonText) { }
    public void Close(ushort reasonCode, string reasonText, int timeout) { }
    public void ClosingLoop() { }
    public RabbitMQ.Client.Impl.Command ConnectionCloseWrapper(ushort reasonCode, string reasonText) { return default(RabbitMQ.Client.Impl.Command); }
    public RabbitMQ.Client.IModel CreateModel() { return default(RabbitMQ.Client.IModel); }
    public RabbitMQ.Client.Impl.ISession CreateSession() { return default(RabbitMQ.Client.Impl.ISession); }
    public RabbitMQ.Client.Impl.ISession CreateSession(int channelNumber) { return default(RabbitMQ.Client.Impl.ISession); }
    public static System.Collections.IDictionary DefaultClientProperties() { return default(System.Collections.IDictionary); }
    public void FinishClose() { }
    public void HandleDomainUnload(object sender, System.EventArgs ea) { }
    public void HandleMainLoopException(RabbitMQ.Client.ShutdownEventArgs reason) { }
    public bool HardProtocolExceptionHandler(RabbitMQ.Client.Impl.HardProtocolException hpe) { return default(bool); }
    public void HeartbeatReadLoop() { }
    public void HeartbeatWriteLoop() { }
    public void InternalClose(RabbitMQ.Client.ShutdownEventArgs reason) { }
    public void LogCloseError(string error, System.Exception ex) { }
    public void MainLoop() { }
    public void MainLoopIteration() { }
    public void NotifyHeartbeatThread() { }
    public void NotifyReceivedCloseOk() { }
    public void OnCallbackException(RabbitMQ.Client.Events.CallbackExceptionEventArgs args) { }
    public void OnShutdown() { }
    public void Open(bool insist) { }
    public void PrettyPrintShutdownReport() { }
    public void QuiesceChannel(RabbitMQ.Client.Impl.SoftProtocolException pe) { }
    public bool SetCloseReason(RabbitMQ.Client.ShutdownEventArgs reason) { return default(bool); }
    public void StartHeartbeatLoop(System.Threading.ThreadStart loop, string name) { }
    public void StartHeartbeatLoops() { }
    public void StartMainLoop() { }
    void System.IDisposable.Dispose() { }
    public void TerminateMainloop() { }
    public override string ToString() { return default(string); }
    public void WriteFrame(RabbitMQ.Client.Impl.Frame f) { }
    public delegate void ConnectionCloseDelegate(ushort replyCode, string replyText, ushort classId, ushort methodId);
  }
  public partial class ConnectionStartDetails {
    public System.Byte[] m_locales;
    public System.Byte[] m_mechanisms;
    public System.Collections.IDictionary m_serverProperties;
    public byte m_versionMajor;
    public byte m_versionMinor;
    public ConnectionStartDetails() { }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct ConnectionTuneDetails {
    public ushort m_channelMax;
    public uint m_frameMax;
    public ushort m_heartbeat;
  }
  public abstract partial class ContentHeaderBase : RabbitMQ.Client.IContentHeader, System.ICloneable {
    protected ContentHeaderBase() { }
    public abstract int ProtocolClassId { get; }
    public abstract string ProtocolClassName { get; }
    public abstract void AppendPropertyDebugStringTo(System.Text.StringBuilder sb);
    public virtual object Clone() { return default(object); }
    public ulong ReadFrom(RabbitMQ.Util.NetworkBinaryReader reader) { return default(ulong); }
    public abstract void ReadPropertiesFrom(RabbitMQ.Client.Impl.ContentHeaderPropertyReader reader);
    public abstract void WritePropertiesTo(RabbitMQ.Client.Impl.ContentHeaderPropertyWriter writer);
    public void WriteTo(RabbitMQ.Util.NetworkBinaryWriter writer, ulong bodySize) { }
  }
  public partial class ContentHeaderPropertyReader {
    protected ushort m_bitCount;
    protected ushort m_flagWord;
    public ContentHeaderPropertyReader(RabbitMQ.Util.NetworkBinaryReader reader) { }
    public RabbitMQ.Util.NetworkBinaryReader BaseReader { get { return default(RabbitMQ.Util.NetworkBinaryReader); } }
    public bool ContinuationBitSet { get { return default(bool); } }
    public void FinishPresence() { }
    public bool ReadBit() { return default(bool); }
    public void ReadFlagWord() { }
    public uint ReadLong() { return default(uint); }
    public ulong ReadLonglong() { return default(ulong); }
    public System.Byte[] ReadLongstr() { return default(System.Byte[]); }
    public byte ReadOctet() { return default(byte); }
    public bool ReadPresence() { return default(bool); }
    public ushort ReadShort() { return default(ushort); }
    public string ReadShortstr() { return default(string); }
    public System.Collections.IDictionary ReadTable() { return default(System.Collections.IDictionary); }
    public RabbitMQ.Client.AmqpTimestamp ReadTimestamp() { return default(RabbitMQ.Client.AmqpTimestamp); }
  }
  public partial class ContentHeaderPropertyWriter {
    protected int m_bitCount;
    protected ushort m_flagWord;
    public ContentHeaderPropertyWriter(RabbitMQ.Util.NetworkBinaryWriter writer) { }
    public RabbitMQ.Util.NetworkBinaryWriter BaseWriter { get { return default(RabbitMQ.Util.NetworkBinaryWriter); } }
    public void FinishPresence() { }
    public void WriteBit(bool bit) { }
    public void WriteLong(uint val) { }
    public void WriteLonglong(ulong val) { }
    public void WriteLongstr(System.Byte[] val) { }
    public void WriteOctet(byte val) { }
    public void WritePresence(bool present) { }
    public void WriteShort(ushort val) { }
    public void WriteShortstr(string val) { }
    public void WriteTable(System.Collections.IDictionary val) { }
    public void WriteTimestamp(RabbitMQ.Client.AmqpTimestamp val) { }
  }
  public abstract partial class FileProperties : RabbitMQ.Client.Impl.ContentHeaderBase, RabbitMQ.Client.IContentHeader, RabbitMQ.Client.IFileProperties, System.ICloneable {
    protected FileProperties() { }
    public abstract string ClusterId { get; set; }
    public abstract string ContentEncoding { get; set; }
    public abstract string ContentType { get; set; }
    public abstract string Filename { get; set; }
    public abstract System.Collections.IDictionary Headers { get; set; }
    public abstract string MessageId { get; set; }
    public abstract byte Priority { get; set; }
    public abstract string ReplyTo { get; set; }
    public abstract RabbitMQ.Client.AmqpTimestamp Timestamp { get; set; }
    public abstract void ClearClusterId();
    public abstract void ClearContentEncoding();
    public abstract void ClearContentType();
    public abstract void ClearFilename();
    public abstract void ClearHeaders();
    public abstract void ClearMessageId();
    public abstract void ClearPriority();
    public abstract void ClearReplyTo();
    public abstract void ClearTimestamp();
    public override object Clone() { return default(object); }
    public abstract bool IsClusterIdPresent();
    public abstract bool IsContentEncodingPresent();
    public abstract bool IsContentTypePresent();
    public abstract bool IsFilenamePresent();
    public abstract bool IsHeadersPresent();
    public abstract bool IsMessageIdPresent();
    public abstract bool IsPriorityPresent();
    public abstract bool IsReplyToPresent();
    public abstract bool IsTimestampPresent();
  }
  public partial class Frame {
    public System.IO.MemoryStream m_accumulator;
    public int m_channel;
    public System.Byte[] m_payload;
    public int m_type;
    public Frame() { }
    public Frame(int type, int channel) { }
    public Frame(int type, int channel, System.Byte[] payload) { }
    public int Channel { get { return default(int); } }
    public System.Byte[] Payload { get { return default(System.Byte[]); } }
    public int Type { get { return default(int); } }
    public void FinishWriting() { }
    public RabbitMQ.Util.NetworkBinaryReader GetReader() { return default(RabbitMQ.Util.NetworkBinaryReader); }
    public RabbitMQ.Util.NetworkBinaryWriter GetWriter() { return default(RabbitMQ.Util.NetworkBinaryWriter); }
    public static void ProcessProtocolHeader(RabbitMQ.Util.NetworkBinaryReader reader) { }
    public static RabbitMQ.Client.Impl.Frame ReadFrom(RabbitMQ.Util.NetworkBinaryReader reader) { return default(RabbitMQ.Client.Impl.Frame); }
    public override string ToString() { return default(string); }
    public void WriteTo(RabbitMQ.Util.NetworkBinaryWriter writer) { }
  }
  public abstract partial class HardProtocolException : RabbitMQ.Client.Impl.ProtocolException {
    protected HardProtocolException(string message) : base (default(string)) { }
  }
  public partial interface IFrameHandler {
    RabbitMQ.Client.AmqpTcpEndpoint Endpoint { get; }
    int Timeout { get; set; }
    void Close();
    RabbitMQ.Client.Impl.Frame ReadFrame();
    void SendHeader();
    void WriteFrame(RabbitMQ.Client.Impl.Frame frame);
  }
  public partial interface IFullModel : RabbitMQ.Client.IModel, System.IDisposable {
    [RabbitMQ.Client.Apigen.Attributes.AmqpForceOneWayAttribute]
    [RabbitMQ.Client.Apigen.Attributes.AmqpMethodMappingAttribute(null, "basic", "cancel")]
    void _Private_BasicCancel(string consumerTag, bool nowait);
    [RabbitMQ.Client.Apigen.Attributes.AmqpForceOneWayAttribute]
    [RabbitMQ.Client.Apigen.Attributes.AmqpMethodMappingAttribute(null, "basic", "consume")]
    void _Private_BasicConsume(string queue, string consumerTag, bool noLocal, bool noAck, bool exclusive, bool nowait, [RabbitMQ.Client.Apigen.Attributes.AmqpFieldMappingAttribute("RabbitMQ.Client.Framing.v0_8qpid", "arguments"), RabbitMQ.Client.Apigen.Attributes.AmqpUnsupportedAttribute("RabbitMQ.Client.Framing.v0_8")]System.Collections.IDictionary filter);
    [RabbitMQ.Client.Apigen.Attributes.AmqpForceOneWayAttribute]
    [RabbitMQ.Client.Apigen.Attributes.AmqpMethodMappingAttribute(null, "basic", "get")]
    void _Private_BasicGet(string queue, bool noAck);
    [RabbitMQ.Client.Apigen.Attributes.AmqpMethodMappingAttribute(null, "basic", "publish")]
    void _Private_BasicPublish(string exchange, string routingKey, bool mandatory, bool immediate, [RabbitMQ.Client.Apigen.Attributes.AmqpContentHeaderMappingAttribute]RabbitMQ.Client.IBasicProperties basicProperties, [RabbitMQ.Client.Apigen.Attributes.AmqpContentBodyMappingAttribute]System.Byte[] body);
    [RabbitMQ.Client.Apigen.Attributes.AmqpForceOneWayAttribute]
    [RabbitMQ.Client.Apigen.Attributes.AmqpMethodMappingAttribute(null, "channel", "close")]
    void _Private_ChannelClose(ushort replyCode, string replyText, ushort classId, ushort methodId);
    [RabbitMQ.Client.Apigen.Attributes.AmqpMethodMappingAttribute(null, "channel", "close-ok")]
    void _Private_ChannelCloseOk();
    [RabbitMQ.Client.Apigen.Attributes.AmqpMethodMappingAttribute(null, "channel", "flow-ok")]
    void _Private_ChannelFlowOk();
    [RabbitMQ.Client.Apigen.Attributes.AmqpMethodMappingAttribute(null, "channel", "open")]
    void _Private_ChannelOpen(string outOfBand);
    [RabbitMQ.Client.Apigen.Attributes.AmqpMethodMappingAttribute(null, "connection", "close")]
    void _Private_ConnectionClose(ushort replyCode, string replyText, ushort classId, ushort methodId);
    [RabbitMQ.Client.Apigen.Attributes.AmqpMethodMappingAttribute(null, "connection", "close-ok")]
    void _Private_ConnectionCloseOk();
    [RabbitMQ.Client.Apigen.Attributes.AmqpForceOneWayAttribute]
    [RabbitMQ.Client.Apigen.Attributes.AmqpMethodMappingAttribute(null, "connection", "open")]
    void _Private_ConnectionOpen(string virtualHost, string capabilities, bool insist);
    [RabbitMQ.Client.Apigen.Attributes.AmqpMethodMappingAttribute(null, "connection", "tune")]RabbitMQ.Client.Impl.ConnectionTuneDetails ConnectionStartOk(System.Collections.IDictionary clientProperties, string mechanism, System.Byte[] response, string locale);
    void ConnectionTuneOk(ushort channelMax, uint frameMax, ushort heartbeat);
    void HandleBasicCancelOk(string consumerTag);
    void HandleBasicConsumeOk(string consumerTag);
    void HandleBasicDeliver(string consumerTag, ulong deliveryTag, bool redelivered, string exchange, string routingKey, [RabbitMQ.Client.Apigen.Attributes.AmqpContentHeaderMappingAttribute]RabbitMQ.Client.IBasicProperties basicProperties, [RabbitMQ.Client.Apigen.Attributes.AmqpContentBodyMappingAttribute]System.Byte[] body);
    void HandleBasicGetEmpty();
    void HandleBasicGetOk(ulong deliveryTag, bool redelivered, string exchange, string routingKey, uint messageCount, [RabbitMQ.Client.Apigen.Attributes.AmqpContentHeaderMappingAttribute]RabbitMQ.Client.IBasicProperties basicProperties, [RabbitMQ.Client.Apigen.Attributes.AmqpContentBodyMappingAttribute]System.Byte[] body);
    void HandleBasicReturn(ushort replyCode, string replyText, string exchange, string routingKey, [RabbitMQ.Client.Apigen.Attributes.AmqpContentHeaderMappingAttribute]RabbitMQ.Client.IBasicProperties basicProperties, [RabbitMQ.Client.Apigen.Attributes.AmqpContentBodyMappingAttribute]System.Byte[] body);
    void HandleChannelClose(ushort replyCode, string replyText, ushort classId, ushort methodId);
    void HandleChannelCloseOk();
    void HandleChannelFlow(bool active);
    void HandleConnectionClose(ushort replyCode, string replyText, ushort classId, ushort methodId);
    void HandleConnectionOpenOk(string knownHosts);
    void HandleConnectionRedirect(string host, string knownHosts);
    void HandleConnectionStart(byte versionMajor, byte versionMinor, System.Collections.IDictionary serverProperties, System.Byte[] mechanisms, System.Byte[] locales);
  }
  public partial interface IRpcContinuation {
    void HandleCommand(RabbitMQ.Client.Impl.Command cmd);
    void HandleModelShutdown(RabbitMQ.Client.ShutdownEventArgs reason);
  }
  public partial interface ISession {
    int ChannelNumber { get; }
    RabbitMQ.Client.ShutdownEventArgs CloseReason { get; }
    RabbitMQ.Client.Impl.CommandHandler CommandReceived { get; set; }
    RabbitMQ.Client.IConnection Connection { get; }
    bool IsOpen { get; }
    event RabbitMQ.Client.Impl.SessionShutdownEventHandler SessionShutdown;
    void Close(RabbitMQ.Client.ShutdownEventArgs reason);
    void Close(RabbitMQ.Client.ShutdownEventArgs reason, bool notify);
    void HandleFrame(RabbitMQ.Client.Impl.Frame frame);
    void Notify();
    void Transmit(RabbitMQ.Client.Impl.Command cmd);
  }
  public partial class MainSession : RabbitMQ.Client.Impl.Session {
    public int m_closeClassId;
    public int m_closeMethodId;
    public int m_closeOkClassId;
    public int m_closeOkMethodId;
    public bool m_closeServerInitiated;
    public bool m_closing;
    public RabbitMQ.Client.Impl.MainSession.SessionCloseDelegate m_handler;
    public MainSession(RabbitMQ.Client.Impl.ConnectionBase connection) : base (default(RabbitMQ.Client.Impl.ConnectionBase), default(int)) { }
    public RabbitMQ.Client.Impl.MainSession.SessionCloseDelegate Handler { get { return default(RabbitMQ.Client.Impl.MainSession.SessionCloseDelegate); } set { } }
    public override void HandleFrame(RabbitMQ.Client.Impl.Frame frame) { }
    public void SetSessionClosing(bool closeServerInitiated) { }
    public override void Transmit(RabbitMQ.Client.Impl.Command cmd) { }
    public delegate void SessionCloseDelegate();
  }
  public partial class MalformedFrameException : RabbitMQ.Client.Impl.HardProtocolException {
    public MalformedFrameException(string message) : base (default(string)) { }
    public override ushort ReplyCode { get { return default(ushort); } }
  }
  public partial class MethodArgumentReader {
    public MethodArgumentReader(RabbitMQ.Util.NetworkBinaryReader reader) { }
    public RabbitMQ.Util.NetworkBinaryReader BaseReader { get { return default(RabbitMQ.Util.NetworkBinaryReader); } }
    public bool ReadBit() { return default(bool); }
    public System.Byte[] ReadContent() { return default(System.Byte[]); }
    public uint ReadLong() { return default(uint); }
    public ulong ReadLonglong() { return default(ulong); }
    public System.Byte[] ReadLongstr() { return default(System.Byte[]); }
    public byte ReadOctet() { return default(byte); }
    public ushort ReadShort() { return default(ushort); }
    public string ReadShortstr() { return default(string); }
    public System.Collections.IDictionary ReadTable() { return default(System.Collections.IDictionary); }
    public RabbitMQ.Client.AmqpTimestamp ReadTimestamp() { return default(RabbitMQ.Client.AmqpTimestamp); }
  }
  public partial class MethodArgumentWriter {
    public MethodArgumentWriter(RabbitMQ.Util.NetworkBinaryWriter writer) { }
    public RabbitMQ.Util.NetworkBinaryWriter BaseWriter { get { return default(RabbitMQ.Util.NetworkBinaryWriter); } }
    public void Flush() { }
    public void WriteBit(bool val) { }
    public void WriteContent(System.Byte[] val) { }
    public void WriteLong(uint val) { }
    public void WriteLonglong(ulong val) { }
    public void WriteLongstr(System.Byte[] val) { }
    public void WriteOctet(byte val) { }
    public void WriteShort(ushort val) { }
    public void WriteShortstr(string val) { }
    public void WriteTable(System.Collections.IDictionary val) { }
    public void WriteTimestamp(RabbitMQ.Client.AmqpTimestamp val) { }
  }
  public abstract partial class MethodBase : RabbitMQ.Client.IMethod {
    protected MethodBase() { }
    public abstract bool HasContent { get; }
    public abstract int ProtocolClassId { get; }
    public abstract int ProtocolMethodId { get; }
    public abstract string ProtocolMethodName { get; }
    public abstract void AppendArgumentDebugStringTo(System.Text.StringBuilder sb);
    public abstract void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader);
    public abstract void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer);
  }
  public abstract partial class ModelBase : RabbitMQ.Client.IModel, RabbitMQ.Client.Impl.IFullModel, System.IDisposable {
    public RabbitMQ.Client.ShutdownEventArgs m_closeReason;
    public RabbitMQ.Util.BlockingCell m_connectionStartCell;
    public readonly System.Collections.IDictionary m_consumers;
    public RabbitMQ.Client.Impl.RpcContinuationQueue m_continuationQueue;
    public System.Threading.ManualResetEvent m_flowControlBlock;
    public RabbitMQ.Client.Impl.ISession m_session;
    public ModelBase(RabbitMQ.Client.Impl.ISession session) { }
    public RabbitMQ.Client.ShutdownEventArgs CloseReason { get { return default(RabbitMQ.Client.ShutdownEventArgs); } }
    public bool IsOpen { get { return default(bool); } }
    public event RabbitMQ.Client.Events.BasicReturnEventHandler BasicReturn { add { } remove { } }
    public event RabbitMQ.Client.Events.CallbackExceptionEventHandler CallbackException { add { } remove { } }
    public event RabbitMQ.Client.Events.ModelShutdownEventHandler ModelShutdown { add { } remove { } }
    public abstract void _Private_BasicCancel(string consumerTag, bool nowait);
    public abstract void _Private_BasicConsume(string queue, string consumerTag, bool noLocal, bool noAck, bool exclusive, bool nowait, System.Collections.IDictionary filter);
    public abstract void _Private_BasicGet(string queue, bool noAck);
    public abstract void _Private_BasicPublish(string exchange, string routingKey, bool mandatory, bool immediate, RabbitMQ.Client.IBasicProperties basicProperties, System.Byte[] body);
    public abstract void _Private_ChannelClose(ushort replyCode, string replyText, ushort classId, ushort methodId);
    public abstract void _Private_ChannelCloseOk();
    public abstract void _Private_ChannelFlowOk();
    public abstract void _Private_ChannelOpen(string outOfBand);
    public abstract void _Private_ConnectionClose(ushort replyCode, string replyText, ushort classId, ushort methodId);
    public abstract void _Private_ConnectionCloseOk();
    public abstract void _Private_ConnectionOpen(string virtualHost, string capabilities, bool insist);
    public void Abort() { }
    public void Abort(ushort replyCode, string replyText) { }
    public abstract void BasicAck(ulong deliveryTag, bool multiple);
    public void BasicCancel(string consumerTag) { }
    public string BasicConsume(string queue, bool noAck, System.Collections.IDictionary filter, RabbitMQ.Client.IBasicConsumer consumer) { return default(string); }
    public string BasicConsume(string queue, bool noAck, string consumerTag, bool noLocal, bool exclusive, System.Collections.IDictionary filter, RabbitMQ.Client.IBasicConsumer consumer) { return default(string); }
    public string BasicConsume(string queue, bool noAck, string consumerTag, System.Collections.IDictionary filter, RabbitMQ.Client.IBasicConsumer consumer) { return default(string); }
    public string BasicConsume(string queue, System.Collections.IDictionary filter, RabbitMQ.Client.IBasicConsumer consumer) { return default(string); }
    public RabbitMQ.Client.BasicGetResult BasicGet(string queue, bool noAck) { return default(RabbitMQ.Client.BasicGetResult); }
    public void BasicPublish(RabbitMQ.Client.PublicationAddress addr, RabbitMQ.Client.IBasicProperties basicProperties, System.Byte[] body) { }
    public void BasicPublish(string exchange, string routingKey, RabbitMQ.Client.IBasicProperties basicProperties, System.Byte[] body) { }
    public void BasicPublish(string exchange, string routingKey, bool mandatory, bool immediate, RabbitMQ.Client.IBasicProperties basicProperties, System.Byte[] body) { }
    public abstract void BasicQos(uint prefetchSize, ushort prefetchCount, bool global);
    public abstract void BasicRecover(bool requeue);
    public abstract void BasicReject(ulong deliveryTag, bool requeue);
    public abstract void ChannelFlow(bool active);
    public void Close() { }
    public void Close(ushort replyCode, string replyText) { }
    public void Close(ushort replyCode, string replyText, bool abort) { }
    public string ConnectionOpen(string virtualHost, string capabilities, bool insist) { return default(string); }
    public abstract RabbitMQ.Client.Impl.ConnectionTuneDetails ConnectionStartOk(System.Collections.IDictionary clientProperties, string mechanism, System.Byte[] response, string locale);
    public abstract void ConnectionTuneOk(ushort channelMax, uint frameMax, ushort heartbeat);
    public abstract RabbitMQ.Client.IBasicProperties CreateBasicProperties();
    public abstract RabbitMQ.Client.IFileProperties CreateFileProperties();
    public abstract RabbitMQ.Client.IStreamProperties CreateStreamProperties();
    public abstract bool DispatchAsynchronous(RabbitMQ.Client.Impl.Command cmd);
    public abstract void DtxSelect();
    public abstract void DtxStart(string dtxIdentifier);
    public void Enqueue(RabbitMQ.Client.Impl.IRpcContinuation k) { }
    public void ExchangeDeclare(string exchange, string type) { }
    public void ExchangeDeclare(string exchange, string type, bool durable) { }
    public abstract void ExchangeDeclare(string exchange, string type, bool passive, bool durable, bool autoDelete, bool @internal, bool nowait, System.Collections.IDictionary arguments);
    public abstract void ExchangeDelete(string exchange, bool ifUnused, bool nowait);
    public void FinishClose() { }
    public void HandleBasicCancelOk(string consumerTag) { }
    public void HandleBasicConsumeOk(string consumerTag) { }
    public void HandleBasicDeliver(string consumerTag, ulong deliveryTag, bool redelivered, string exchange, string routingKey, RabbitMQ.Client.IBasicProperties basicProperties, System.Byte[] body) { }
    public void HandleBasicGetEmpty() { }
    public void HandleBasicGetOk(ulong deliveryTag, bool redelivered, string exchange, string routingKey, uint messageCount, RabbitMQ.Client.IBasicProperties basicProperties, System.Byte[] body) { }
    public void HandleBasicReturn(ushort replyCode, string replyText, string exchange, string routingKey, RabbitMQ.Client.IBasicProperties basicProperties, System.Byte[] body) { }
    public void HandleChannelClose(ushort replyCode, string replyText, ushort classId, ushort methodId) { }
    public void HandleChannelCloseOk() { }
    public void HandleChannelFlow(bool active) { }
    public void HandleCommand(RabbitMQ.Client.Impl.ISession session, RabbitMQ.Client.Impl.Command cmd) { }
    public void HandleConnectionClose(ushort replyCode, string replyText, ushort classId, ushort methodId) { }
    public void HandleConnectionOpenOk(string knownHosts) { }
    public void HandleConnectionRedirect(string host, string knownHosts) { }
    public void HandleConnectionStart(byte versionMajor, byte versionMinor, System.Collections.IDictionary serverProperties, System.Byte[] mechanisms, System.Byte[] locales) { }
    public RabbitMQ.Client.Impl.MethodBase ModelRpc(RabbitMQ.Client.Impl.MethodBase method, RabbitMQ.Client.Impl.ContentHeaderBase header, System.Byte[] body) { return default(RabbitMQ.Client.Impl.MethodBase); }
    public void ModelSend(RabbitMQ.Client.Impl.MethodBase method, RabbitMQ.Client.Impl.ContentHeaderBase header, System.Byte[] body) { }
    public virtual void OnBasicReturn(RabbitMQ.Client.Events.BasicReturnEventArgs args) { }
    public virtual void OnCallbackException(RabbitMQ.Client.Events.CallbackExceptionEventArgs args) { }
    public virtual void OnModelShutdown(RabbitMQ.Client.ShutdownEventArgs reason) { }
    public void OnSessionShutdown(RabbitMQ.Client.Impl.ISession session, RabbitMQ.Client.ShutdownEventArgs reason) { }
    public abstract void QueueBind(string queue, string exchange, string routingKey, bool nowait, System.Collections.IDictionary arguments);
    public string QueueDeclare() { return default(string); }
    public string QueueDeclare(string queue) { return default(string); }
    public string QueueDeclare(string queue, bool durable) { return default(string); }
    public abstract string QueueDeclare(string queue, bool passive, bool durable, bool exclusive, bool autoDelete, bool nowait, System.Collections.IDictionary arguments);
    public abstract uint QueueDelete(string queue, bool ifUnused, bool ifEmpty, bool nowait);
    public abstract uint QueuePurge(string queue, bool nowait);
    public abstract void QueueUnbind(string queue, string exchange, string routingKey, System.Collections.IDictionary arguments);
    public bool SetCloseReason(RabbitMQ.Client.ShutdownEventArgs reason) { return default(bool); }
    void System.IDisposable.Dispose() { }
    public override string ToString() { return default(string); }
    public void TransmitAndEnqueue(RabbitMQ.Client.Impl.Command cmd, RabbitMQ.Client.Impl.IRpcContinuation k) { }
    public abstract void TxCommit();
    public abstract void TxRollback();
    public abstract void TxSelect();
    public partial class BasicConsumerRpcContinuation : RabbitMQ.Client.Impl.SimpleBlockingRpcContinuation {
      public RabbitMQ.Client.IBasicConsumer m_consumer;
      public string m_consumerTag;
      public BasicConsumerRpcContinuation() { }
    }
    public partial class BasicGetRpcContinuation : RabbitMQ.Client.Impl.SimpleBlockingRpcContinuation {
      public RabbitMQ.Client.BasicGetResult m_result;
      public BasicGetRpcContinuation() { }
    }
    public partial class ConnectionOpenContinuation : RabbitMQ.Client.Impl.SimpleBlockingRpcContinuation {
      public string m_host;
      public string m_knownHosts;
      public bool m_redirect;
      public ConnectionOpenContinuation() { }
    }
  }
  public abstract partial class ProtocolException : System.Net.ProtocolViolationException {
    protected ProtocolException(string message) { }
    public abstract ushort ReplyCode { get; }
    public virtual RabbitMQ.Client.ShutdownEventArgs ShutdownReason { get { return default(RabbitMQ.Client.ShutdownEventArgs); } }
  }
  public partial class QuiescingSession : RabbitMQ.Client.Impl.SessionBase {
    public RabbitMQ.Client.ShutdownEventArgs m_reason;
    public int m_replyClassId;
    public int m_replyMethodId;
    public QuiescingSession(RabbitMQ.Client.Impl.ConnectionBase connection, int channelNumber, RabbitMQ.Client.ShutdownEventArgs reason, int replyClassId, int replyMethodId) : base (default(RabbitMQ.Client.Impl.ConnectionBase), default(int)) { }
    public override void HandleFrame(RabbitMQ.Client.Impl.Frame frame) { }
  }
  public partial class RedirectException : System.Exception {
    public RabbitMQ.Client.AmqpTcpEndpoint m_host;
    public RabbitMQ.Client.AmqpTcpEndpoint[] m_knownHosts;
    public RedirectException(RabbitMQ.Client.AmqpTcpEndpoint host, RabbitMQ.Client.AmqpTcpEndpoint[] knownHosts) { }
    public RedirectException(RabbitMQ.Client.IProtocol protocol, string host, string knownHosts) { }
    public RabbitMQ.Client.AmqpTcpEndpoint Host { get { return default(RabbitMQ.Client.AmqpTcpEndpoint); } }
    public RabbitMQ.Client.AmqpTcpEndpoint[] KnownHosts { get { return default(RabbitMQ.Client.AmqpTcpEndpoint[]); } }
    public static RabbitMQ.Client.AmqpTcpEndpoint ParseHost(RabbitMQ.Client.IProtocol protocol, string host) { return default(RabbitMQ.Client.AmqpTcpEndpoint); }
  }
  public partial class RpcContinuationQueue {
    public RabbitMQ.Client.Impl.IRpcContinuation m_outstandingRpc;
    public RpcContinuationQueue() { }
    public void Enqueue(RabbitMQ.Client.Impl.IRpcContinuation k) { }
    public void HandleModelShutdown(RabbitMQ.Client.ShutdownEventArgs reason) { }
    public RabbitMQ.Client.Impl.IRpcContinuation Next() { return default(RabbitMQ.Client.Impl.IRpcContinuation); }
  }
  public partial class Session : RabbitMQ.Client.Impl.SessionBase {
    public RabbitMQ.Client.Impl.CommandAssembler m_assembler;
    public Session(RabbitMQ.Client.Impl.ConnectionBase connection, int channelNumber) : base (default(RabbitMQ.Client.Impl.ConnectionBase), default(int)) { }
    public override void HandleFrame(RabbitMQ.Client.Impl.Frame frame) { }
  }
  public abstract partial class SessionBase : RabbitMQ.Client.Impl.ISession {
    public readonly int m_channelNumber;
    public RabbitMQ.Client.ShutdownEventArgs m_closeReason;
    public readonly RabbitMQ.Client.Impl.ConnectionBase m_connection;
    public SessionBase(RabbitMQ.Client.Impl.ConnectionBase connection, int channelNumber) { }
    public int ChannelNumber { get { return default(int); } }
    public RabbitMQ.Client.ShutdownEventArgs CloseReason { get { return default(RabbitMQ.Client.ShutdownEventArgs); } }
    public RabbitMQ.Client.Impl.CommandHandler CommandReceived { get { return default(RabbitMQ.Client.Impl.CommandHandler); } set { } }
    public RabbitMQ.Client.Impl.ConnectionBase Connection { get { return default(RabbitMQ.Client.Impl.ConnectionBase); } }
    public bool IsOpen { get { return default(bool); } }
    RabbitMQ.Client.IConnection RabbitMQ.Client.Impl.ISession.Connection { get { return default(RabbitMQ.Client.IConnection); } }
    public event RabbitMQ.Client.Impl.SessionShutdownEventHandler SessionShutdown { add { } remove { } }
    public void Close(RabbitMQ.Client.ShutdownEventArgs reason) { }
    public void Close(RabbitMQ.Client.ShutdownEventArgs reason, bool notify) { }
    public abstract void HandleFrame(RabbitMQ.Client.Impl.Frame frame);
    public void Notify() { }
    public virtual void OnCommandReceived(RabbitMQ.Client.Impl.Command cmd) { }
    public virtual void OnConnectionShutdown(RabbitMQ.Client.IConnection conn, RabbitMQ.Client.ShutdownEventArgs reason) { }
    public virtual void OnSessionShutdown(RabbitMQ.Client.ShutdownEventArgs reason) { }
    public override string ToString() { return default(string); }
    public virtual void Transmit(RabbitMQ.Client.Impl.Command cmd) { }
  }
  public partial class SessionManager {
    public readonly ushort ChannelMax;
    public SessionManager(RabbitMQ.Client.Impl.ConnectionBase connection, ushort channelMax) { }
    public bool AutoClose { get { return default(bool); } set { } }
    public int Count { get { return default(int); } }
    public void AutoCloseConnection() { }
    public void CheckAutoClose() { }
    public RabbitMQ.Client.Impl.ISession Create() { return default(RabbitMQ.Client.Impl.ISession); }
    public RabbitMQ.Client.Impl.ISession Create(int channelNumber) { return default(RabbitMQ.Client.Impl.ISession); }
    public RabbitMQ.Client.Impl.ISession CreateInternal(int channelNumber) { return default(RabbitMQ.Client.Impl.ISession); }
    public void HandleSessionShutdown(RabbitMQ.Client.Impl.ISession session, RabbitMQ.Client.ShutdownEventArgs reason) { }
    public RabbitMQ.Client.Impl.ISession Lookup(int number) { return default(RabbitMQ.Client.Impl.ISession); }
    public RabbitMQ.Client.Impl.ISession Swap(int channelNumber, RabbitMQ.Client.Impl.ISession replacement) { return default(RabbitMQ.Client.Impl.ISession); }
  }
  public delegate void SessionShutdownEventHandler(RabbitMQ.Client.Impl.ISession session, RabbitMQ.Client.ShutdownEventArgs reason);
  public partial class ShutdownContinuation {
    public readonly RabbitMQ.Util.BlockingCell m_cell;
    public ShutdownContinuation() { }
    public virtual void OnShutdown(RabbitMQ.Client.IConnection sender, RabbitMQ.Client.ShutdownEventArgs reason) { }
    public virtual void OnShutdown(RabbitMQ.Client.IModel sender, RabbitMQ.Client.ShutdownEventArgs reason) { }
    public virtual RabbitMQ.Client.ShutdownEventArgs Wait() { return default(RabbitMQ.Client.ShutdownEventArgs); }
  }
  public partial class SimpleBlockingRpcContinuation : RabbitMQ.Client.Impl.IRpcContinuation {
    public readonly RabbitMQ.Util.BlockingCell m_cell;
    public SimpleBlockingRpcContinuation() { }
    public virtual RabbitMQ.Client.Impl.Command GetReply() { return default(RabbitMQ.Client.Impl.Command); }
    public virtual void HandleCommand(RabbitMQ.Client.Impl.Command cmd) { }
    public virtual void HandleModelShutdown(RabbitMQ.Client.ShutdownEventArgs reason) { }
  }
  public partial class SocketFrameHandler_0_9 : RabbitMQ.Client.Impl.IFrameHandler {
    public RabbitMQ.Client.AmqpTcpEndpoint m_endpoint;
    public RabbitMQ.Util.NetworkBinaryReader m_reader;
    public System.Net.Sockets.TcpClient m_socket;
    public RabbitMQ.Util.NetworkBinaryWriter m_writer;
    public const int WSAEWOULDBLOCK = 10035;
    public SocketFrameHandler_0_9(RabbitMQ.Client.AmqpTcpEndpoint endpoint) { }
    public RabbitMQ.Client.AmqpTcpEndpoint Endpoint { get { return default(RabbitMQ.Client.AmqpTcpEndpoint); } }
    public int Timeout { get { return default(int); } set { } }
    public void Close() { }
    public RabbitMQ.Client.Impl.Frame ReadFrame() { return default(RabbitMQ.Client.Impl.Frame); }
    public void SendHeader() { }
    public void WriteFrame(RabbitMQ.Client.Impl.Frame frame) { }
  }
  public abstract partial class SoftProtocolException : RabbitMQ.Client.Impl.ProtocolException {
    protected SoftProtocolException(int channelNumber, string message) : base (default(string)) { }
    public int Channel { get { return default(int); } }
  }
  public abstract partial class StreamProperties : RabbitMQ.Client.Impl.ContentHeaderBase, RabbitMQ.Client.IContentHeader, RabbitMQ.Client.IStreamProperties, System.ICloneable {
    protected StreamProperties() { }
    public abstract string ContentEncoding { get; set; }
    public abstract string ContentType { get; set; }
    public abstract System.Collections.IDictionary Headers { get; set; }
    public abstract byte Priority { get; set; }
    public abstract RabbitMQ.Client.AmqpTimestamp Timestamp { get; set; }
    public abstract void ClearContentEncoding();
    public abstract void ClearContentType();
    public abstract void ClearHeaders();
    public abstract void ClearPriority();
    public abstract void ClearTimestamp();
    public override object Clone() { return default(object); }
    public abstract bool IsContentEncodingPresent();
    public abstract bool IsContentTypePresent();
    public abstract bool IsHeadersPresent();
    public abstract bool IsPriorityPresent();
    public abstract bool IsTimestampPresent();
  }
  public partial class SyntaxError : RabbitMQ.Client.Impl.HardProtocolException {
    public SyntaxError(string message) : base (default(string)) { }
    public override ushort ReplyCode { get { return default(ushort); } }
  }
  public partial class UnexpectedFrameException : RabbitMQ.Client.Impl.HardProtocolException {
    public RabbitMQ.Client.Impl.Frame m_frame;
    public UnexpectedFrameException(RabbitMQ.Client.Impl.Frame frame) : base (default(string)) { }
    public RabbitMQ.Client.Impl.Frame Frame { get { return default(RabbitMQ.Client.Impl.Frame); } }
    public override ushort ReplyCode { get { return default(ushort); } }
  }
  public partial class UnknownClassOrMethodException : RabbitMQ.Client.Impl.HardProtocolException {
    public UnknownClassOrMethodException(ushort classId, ushort methodId) : base (default(string)) { }
    public ushort ClassId { get { return default(ushort); } }
    public ushort MethodId { get { return default(ushort); } }
    public override ushort ReplyCode { get { return default(ushort); } }
    public override string ToString() { return default(string); }
  }
  public partial class WireFormatting {
    public WireFormatting() { }
    public static decimal AmqpToDecimal(byte scale, uint unsignedMantissa) { return default(decimal); }
    public static void DecimalToAmqp(decimal value, out byte scale, out int mantissa) { scale = default(byte); mantissa = default(int); }
    public static System.Collections.IList ReadArray(RabbitMQ.Util.NetworkBinaryReader reader) { return default(System.Collections.IList); }
    public static decimal ReadDecimal(RabbitMQ.Util.NetworkBinaryReader reader) { return default(decimal); }
    public static object ReadFieldValue(RabbitMQ.Util.NetworkBinaryReader reader) { return default(object); }
    public static uint ReadLong(RabbitMQ.Util.NetworkBinaryReader reader) { return default(uint); }
    public static ulong ReadLonglong(RabbitMQ.Util.NetworkBinaryReader reader) { return default(ulong); }
    public static System.Byte[] ReadLongstr(RabbitMQ.Util.NetworkBinaryReader reader) { return default(System.Byte[]); }
    public static byte ReadOctet(RabbitMQ.Util.NetworkBinaryReader reader) { return default(byte); }
    public static ushort ReadShort(RabbitMQ.Util.NetworkBinaryReader reader) { return default(ushort); }
    public static string ReadShortstr(RabbitMQ.Util.NetworkBinaryReader reader) { return default(string); }
    public static System.Collections.IDictionary ReadTable(RabbitMQ.Util.NetworkBinaryReader reader) { return default(System.Collections.IDictionary); }
    public static RabbitMQ.Client.AmqpTimestamp ReadTimestamp(RabbitMQ.Util.NetworkBinaryReader reader) { return default(RabbitMQ.Client.AmqpTimestamp); }
    public static void WriteArray(RabbitMQ.Util.NetworkBinaryWriter writer, System.Collections.IList val) { }
    public static void WriteDecimal(RabbitMQ.Util.NetworkBinaryWriter writer, decimal value) { }
    public static void WriteFieldValue(RabbitMQ.Util.NetworkBinaryWriter writer, object value) { }
    public static void WriteLong(RabbitMQ.Util.NetworkBinaryWriter writer, uint val) { }
    public static void WriteLonglong(RabbitMQ.Util.NetworkBinaryWriter writer, ulong val) { }
    public static void WriteLongstr(RabbitMQ.Util.NetworkBinaryWriter writer, System.Byte[] val) { }
    public static void WriteOctet(RabbitMQ.Util.NetworkBinaryWriter writer, byte val) { }
    public static void WriteShort(RabbitMQ.Util.NetworkBinaryWriter writer, ushort val) { }
    public static void WriteShortstr(RabbitMQ.Util.NetworkBinaryWriter writer, string val) { }
    public static void WriteTable(RabbitMQ.Util.NetworkBinaryWriter writer, System.Collections.IDictionary val) { }
    public static void WriteTimestamp(RabbitMQ.Util.NetworkBinaryWriter writer, RabbitMQ.Client.AmqpTimestamp val) { }
  }
}
namespace RabbitMQ.Client.MessagePatterns {
  public partial class SimpleRpcClient : System.IDisposable {
    protected RabbitMQ.Client.IModel m_model;
    protected RabbitMQ.Client.MessagePatterns.Subscription m_subscription;
    public SimpleRpcClient(RabbitMQ.Client.IModel model) { }
    public SimpleRpcClient(RabbitMQ.Client.IModel model, RabbitMQ.Client.PublicationAddress address) { }
    public SimpleRpcClient(RabbitMQ.Client.IModel model, string queueName) { }
    public SimpleRpcClient(RabbitMQ.Client.IModel model, string exchange, string exchangeType, string routingKey) { }
    public RabbitMQ.Client.PublicationAddress Address { get { return default(RabbitMQ.Client.PublicationAddress); } set { } }
    public RabbitMQ.Client.IModel Model { get { return default(RabbitMQ.Client.IModel); } }
    public RabbitMQ.Client.MessagePatterns.Subscription Subscription { get { return default(RabbitMQ.Client.MessagePatterns.Subscription); } }
    public int TimeoutMilliseconds { get { return default(int); } set { } }
    public event System.EventHandler Disconnected { add { } remove { } }
    public event System.EventHandler TimedOut { add { } remove { } }
    public virtual RabbitMQ.Client.Events.BasicDeliverEventArgs Call(RabbitMQ.Client.IBasicProperties requestProperties, System.Byte[] body) { return default(RabbitMQ.Client.Events.BasicDeliverEventArgs); }
    public virtual System.Byte[] Call(RabbitMQ.Client.IBasicProperties requestProperties, System.Byte[] body, out RabbitMQ.Client.IBasicProperties replyProperties) { replyProperties = default(RabbitMQ.Client.IBasicProperties); return default(System.Byte[]); }
    public virtual System.Byte[] Call(System.Byte[] body) { return default(System.Byte[]); }
    public virtual System.Object[] Call(params System.Object[] args) { return default(System.Object[]); }
    public virtual void Cast(RabbitMQ.Client.IBasicProperties requestProperties, System.Byte[] body) { }
    public void Close() { }
    protected virtual void EnsureSubscription() { }
    public virtual void OnDisconnected() { }
    public virtual void OnTimedOut() { }
    protected virtual RabbitMQ.Client.Events.BasicDeliverEventArgs RetrieveReply(string correlationId) { return default(RabbitMQ.Client.Events.BasicDeliverEventArgs); }
    void System.IDisposable.Dispose() { }
  }
  public partial class SimpleRpcServer : System.IDisposable {
    protected RabbitMQ.Client.MessagePatterns.Subscription m_subscription;
    public SimpleRpcServer(RabbitMQ.Client.MessagePatterns.Subscription subscription) { }
    public bool Transactional { get { return default(bool); } }
    public void Close() { }
    public virtual System.Byte[] HandleCall(bool isRedelivered, RabbitMQ.Client.IBasicProperties requestProperties, System.Byte[] body, out RabbitMQ.Client.IBasicProperties replyProperties) { replyProperties = default(RabbitMQ.Client.IBasicProperties); return default(System.Byte[]); }
    public virtual void HandleCast(bool isRedelivered, RabbitMQ.Client.IBasicProperties requestProperties, System.Byte[] body) { }
    public virtual System.Byte[] HandleSimpleCall(bool isRedelivered, RabbitMQ.Client.IBasicProperties requestProperties, System.Byte[] body, out RabbitMQ.Client.IBasicProperties replyProperties) { replyProperties = default(RabbitMQ.Client.IBasicProperties); return default(System.Byte[]); }
    public virtual void HandleSimpleCast(bool isRedelivered, RabbitMQ.Client.IBasicProperties requestProperties, System.Byte[] body) { }
    public virtual void HandleStreamMessageCall(RabbitMQ.Client.Content.IStreamMessageBuilder replyWriter, bool isRedelivered, RabbitMQ.Client.IBasicProperties requestProperties, System.Object[] args) { }
    public void MainLoop() { }
    public virtual void ProcessRequest(RabbitMQ.Client.Events.BasicDeliverEventArgs evt) { }
    public void SetTransactional() { }
    void System.IDisposable.Dispose() { }
  }
  public partial class Subscription : System.Collections.IEnumerable, System.Collections.IEnumerator, System.IDisposable {
    protected RabbitMQ.Client.QueueingBasicConsumer m_consumer;
    protected readonly object m_consumerLock;
    protected string m_consumerTag;
    protected RabbitMQ.Client.Events.BasicDeliverEventArgs m_latestEvent;
    protected RabbitMQ.Client.IModel m_model;
    protected bool m_noAck;
    protected string m_queueName;
    protected bool m_shouldDelete;
    public Subscription(RabbitMQ.Client.IModel model) { }
    public Subscription(RabbitMQ.Client.IModel model, string queueName) { }
    public Subscription(RabbitMQ.Client.IModel model, string queueName, bool noAck) { }
    public Subscription(RabbitMQ.Client.IModel model, string queueName, bool noAck, string exchangeName, string exchangeType, string routingKey) { }
    public Subscription(RabbitMQ.Client.IModel model, string exchangeName, string exchangeType, string routingKey) { }
    public Subscription(RabbitMQ.Client.IModel model, string queueName, string exchangeName, string exchangeType, string routingKey) { }
    public RabbitMQ.Client.IBasicConsumer Consumer { get { return default(RabbitMQ.Client.IBasicConsumer); } }
    public string ConsumerTag { get { return default(string); } }
    public RabbitMQ.Client.Events.BasicDeliverEventArgs LatestEvent { get { return default(RabbitMQ.Client.Events.BasicDeliverEventArgs); } }
    public RabbitMQ.Client.IModel Model { get { return default(RabbitMQ.Client.IModel); } }
    public bool NoAck { get { return default(bool); } }
    public string QueueName { get { return default(string); } }
    object System.Collections.IEnumerator.Current { get { return default(object); } }
    public void Ack() { }
    public void Ack(RabbitMQ.Client.Events.BasicDeliverEventArgs evt) { }
    public void Bind(string exchangeName, string exchangeType, string routingKey) { }
    public void Close() { }
    public RabbitMQ.Client.Events.BasicDeliverEventArgs Next() { return default(RabbitMQ.Client.Events.BasicDeliverEventArgs); }
    public bool Next(int millisecondsTimeout, out RabbitMQ.Client.Events.BasicDeliverEventArgs result) { result = default(RabbitMQ.Client.Events.BasicDeliverEventArgs); return default(bool); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    bool System.Collections.IEnumerator.MoveNext() { return default(bool); }
    void System.Collections.IEnumerator.Reset() { }
    void System.IDisposable.Dispose() { }
  }
}
namespace RabbitMQ.Util {
  public partial class BlockingCell {
    public BlockingCell() { }
    public object Value { get { return default(object); } set { } }
    public bool GetValue(int millisecondsTimeout, out object result) { result = default(object); return default(bool); }
    public static int validatedTimeout(int timeout) { return default(int); }
  }
  public partial class DebugUtil {
    internal DebugUtil() { }
    public static void Dump(System.Byte[] bytes) { }
    public static void Dump(System.Byte[] bytes, System.IO.TextWriter writer) { }
    public static void DumpKeyValue(string key, object value, System.IO.TextWriter writer, int indent) { }
    public static void DumpProperties(object value, System.IO.TextWriter writer, int indent) { }
  }
  public partial class Either {
    internal Either() { }
    public RabbitMQ.Util.EitherAlternative Alternative { get { return default(RabbitMQ.Util.EitherAlternative); } }
    public object Value { get { return default(object); } }
    public static RabbitMQ.Util.Either Left(object value) { return default(RabbitMQ.Util.Either); }
    public static RabbitMQ.Util.Either Right(object value) { return default(RabbitMQ.Util.Either); }
  }
  public enum EitherAlternative {
    Left = 0,
    Right = 1,
  }
  public partial class IntAllocator {
    public IntAllocator(int start, int end) { }
    public int Allocate() { return default(int); }
    public void Free(int id) { }
    public bool Reserve(int id) { return default(bool); }
    public partial class IntervalList {
      public int End;
      public RabbitMQ.Util.IntAllocator.IntervalList Next;
      public int Start;
      public IntervalList(int start, int end) { }
      public static RabbitMQ.Util.IntAllocator.IntervalList FromArray(System.Int32[] xs, int length) { return default(RabbitMQ.Util.IntAllocator.IntervalList); }
      public static RabbitMQ.Util.IntAllocator.IntervalList Merge(RabbitMQ.Util.IntAllocator.IntervalList x, RabbitMQ.Util.IntAllocator.IntervalList y) { return default(RabbitMQ.Util.IntAllocator.IntervalList); }
    }
  }
  public partial class NetworkBinaryReader : System.IO.BinaryReader {
    public NetworkBinaryReader(System.IO.Stream input) : base (default(System.IO.Stream)) { }
    public NetworkBinaryReader(System.IO.Stream input, System.Text.Encoding encoding) : base (default(System.IO.Stream)) { }
    public override double ReadDouble() { return default(double); }
    public override short ReadInt16() { return default(short); }
    public override int ReadInt32() { return default(int); }
    public override long ReadInt64() { return default(long); }
    public override float ReadSingle() { return default(float); }
    public override ushort ReadUInt16() { return default(ushort); }
    public override uint ReadUInt32() { return default(uint); }
    public override ulong ReadUInt64() { return default(ulong); }
    public static System.IO.BinaryReader TemporaryBinaryReader(System.Byte[] bytes) { return default(System.IO.BinaryReader); }
  }
  public partial class NetworkBinaryWriter : System.IO.BinaryWriter {
    public NetworkBinaryWriter(System.IO.Stream output) { }
    public NetworkBinaryWriter(System.IO.Stream output, System.Text.Encoding encoding) { }
    public static System.IO.BinaryWriter TemporaryBinaryWriter(int initialSize) { return default(System.IO.BinaryWriter); }
    public static System.Byte[] TemporaryContents(System.IO.BinaryWriter w) { return default(System.Byte[]); }
    public override void Write(double d) { }
    public override void Write(short i) { }
    public override void Write(int i) { }
    public override void Write(long i) { }
    public override void Write(float f) { }
    public override void Write(ushort i) { }
    public override void Write(uint i) { }
    public override void Write(ulong i) { }
  }
  public partial class Semaphore {
    public Semaphore() { }
    public Semaphore(int initialCount) { }
    public int Value { get { return default(int); } }
    public void Release() { }
    public bool TryWait() { return default(bool); }
    public void Wait() { }
  }
  public partial class SharedQueue : System.Collections.IEnumerable {
    protected bool m_isOpen;
    protected System.Collections.Queue m_queue;
    public SharedQueue() { }
    public void Close() { }
    public object Dequeue() { return default(object); }
    public bool Dequeue(int millisecondsTimeout, out object result) { result = default(object); return default(bool); }
    public object DequeueNoWait(object defaultValue) { return default(object); }
    public void Enqueue(object o) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  public partial class SharedQueueEnumerator : System.Collections.IEnumerator {
    protected object m_current;
    protected RabbitMQ.Util.SharedQueue m_queue;
    public SharedQueueEnumerator(RabbitMQ.Util.SharedQueue queue) { }
    object System.Collections.IEnumerator.Current { get { return default(object); } }
    bool System.Collections.IEnumerator.MoveNext() { return default(bool); }
    void System.Collections.IEnumerator.Reset() { }
  }
  public partial class XmlUtil {
    internal XmlUtil() { }
    public static System.Xml.XmlTextWriter CreateIndentedXmlWriter() { return default(System.Xml.XmlTextWriter); }
    public static System.Xml.XmlTextWriter CreateIndentedXmlWriter(System.IO.Stream stream) { return default(System.Xml.XmlTextWriter); }
    public static System.Xml.XmlTextWriter CreateIndentedXmlWriter(string path) { return default(System.Xml.XmlTextWriter); }
    public static System.Xml.XmlDocument SerializeObject(System.Type serializationType, object obj) { return default(System.Xml.XmlDocument); }
  }
}
