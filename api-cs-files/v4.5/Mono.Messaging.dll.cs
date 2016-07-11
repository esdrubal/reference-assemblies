namespace Mono.Messaging {
  [System.FlagsAttribute]
  public enum AcknowledgeTypes {
    FullReachQueue = 5,
    FullReceive = 14,
    NegativeReceive = 8,
    None = 0,
    NotAcknowledgeReachQueue = 4,
    NotAcknowledgeReceive = 12,
    PositiveArrival = 1,
    PositiveReceive = 2,
  }
  public enum Acknowledgment {
    AccessDenied = 32772,
    BadDestinationQueue = 32768,
    BadEncryption = 32775,
    BadSignature = 32774,
    CouldNotEncrypt = 32776,
    HopCountExceeded = 32773,
    None = 0,
    NotTransactionalMessage = 32778,
    NotTransactionalQueue = 32777,
    Purged = 32769,
    QueueDeleted = 49152,
    QueueExceedMaximumSize = 32771,
    QueuePurged = 49153,
    ReachQueue = 2,
    ReachQueueTimeout = 32770,
    Receive = 16384,
    ReceiveTimeout = 49154,
  }
  public partial class CompletedEventArgs : System.EventArgs {
    public CompletedEventArgs(System.IAsyncResult result) { }
    public System.IAsyncResult AsyncResult { get { return default(System.IAsyncResult); } set { } }
  }
  public delegate void CompletedEventHandler(object sender, Mono.Messaging.CompletedEventArgs e);
  public partial class ConcurrentLinkedQueue<T> {
    public ConcurrentLinkedQueue() { }
    public T Dequeue() { return default(T); }
    public void Enqueue(T context) { }
    public override string ToString() { return default(string); }
  }
  public partial class ConnectionException : Mono.Messaging.MonoMessagingException {
    public ConnectionException(Mono.Messaging.QueueReference qRef) { }
    public ConnectionException(Mono.Messaging.QueueReference qRef, System.Exception e) { }
    public Mono.Messaging.QueueReference QRef { get { return default(Mono.Messaging.QueueReference); } }
  }
  public enum CryptographicProviderType {
    Dss = 3,
    Fortezza = 4,
    MicrosoftExchange = 5,
    None = 0,
    RsaFull = 1,
    RsqSig = 2,
    Ssl = 6,
    SttAcq = 8,
    SttBrnd = 9,
    SttIss = 11,
    SttMer = 7,
    SttRoot = 10,
  }
  public enum EncryptionAlgorithm {
    None = 0,
    Rc2 = 26114,
    Rc4 = 26625,
  }
  public enum EncryptionRequired {
    Body = 2,
    None = 0,
    Optional = 1,
  }
  public enum HashAlgorithm {
    Mac = 32773,
    Md2 = 32769,
    Md4 = 32770,
    Md5 = 32771,
    None = 0,
    Sha = 32772,
  }
  public partial interface IMessage {
    Mono.Messaging.AcknowledgeTypes AcknowledgeType { get; set; }
    Mono.Messaging.Acknowledgment Acknowledgment { get; }
    Mono.Messaging.IMessageQueue AdministrationQueue { get; set; }
    int AppSpecific { get; set; }
    System.DateTime ArrivedTime { get; }
    bool AttachSenderId { get; set; }
    bool Authenticated { get; }
    string AuthenticationProviderName { get; set; }
    Mono.Messaging.CryptographicProviderType AuthenticationProviderType { get; set; }
    System.IO.Stream BodyStream { get; set; }
    int BodyType { get; set; }
    System.Guid ConnectorType { get; set; }
    string CorrelationId { get; set; }
    Mono.Messaging.IMessageQueue DestinationQueue { get; }
    System.Byte[] DestinationSymmetricKey { get; set; }
    System.Byte[] DigitalSignature { get; set; }
    Mono.Messaging.EncryptionAlgorithm EncryptionAlgorithm { get; set; }
    System.Byte[] Extension { get; set; }
    Mono.Messaging.HashAlgorithm HashAlgorithm { get; set; }
    string Id { get; }
    bool IsFirstInTransaction { get; }
    bool IsLastInTransaction { get; }
    string Label { get; set; }
    Mono.Messaging.MessageType MessageType { get; }
    Mono.Messaging.MessagePriority Priority { get; set; }
    bool Recoverable { get; set; }
    Mono.Messaging.IMessageQueue ResponseQueue { get; set; }
    System.Byte[] SenderCertificate { get; set; }
    System.Byte[] SenderId { get; }
    long SenderVersion { get; }
    System.DateTime SentTime { get; }
    string SourceMachine { get; }
    System.TimeSpan TimeToBeReceived { get; set; }
    System.TimeSpan TimeToReachQueue { get; set; }
    string TransactionId { get; }
    Mono.Messaging.IMessageQueue TransactionStatusQueue { get; set; }
    bool UseAuthentication { get; set; }
    bool UseDeadLetterQueue { get; set; }
    bool UseEncryption { get; set; }
    bool UseJournalQueue { get; set; }
    bool UseTracing { get; set; }
    void SetDeliveryInfo(Mono.Messaging.Acknowledgment acknowledgment, System.DateTime arrivedTime, Mono.Messaging.IMessageQueue destinationQueue, string id, Mono.Messaging.MessageType messageType, System.Byte[] senderId, long senderVersion, System.DateTime sentTime, string sourceMachine, string transactionId);
  }
  public partial interface IMessageEnumerator : System.IDisposable {
    Mono.Messaging.IMessage Current { get; }
    System.IntPtr CursorHandle { get; }
    void Close();
    void Dispose(bool disposing);
    bool MoveNext();
    bool MoveNext(System.TimeSpan timeout);
    Mono.Messaging.IMessage RemoveCurrent();
    Mono.Messaging.IMessage RemoveCurrent(Mono.Messaging.IMessageQueueTransaction transaction);
    Mono.Messaging.IMessage RemoveCurrent(Mono.Messaging.MessageQueueTransactionType transactionType);
    Mono.Messaging.IMessage RemoveCurrent(System.TimeSpan timeout);
    Mono.Messaging.IMessage RemoveCurrent(System.TimeSpan timeout, Mono.Messaging.IMessageQueueTransaction transaction);
    Mono.Messaging.IMessage RemoveCurrent(System.TimeSpan timeout, Mono.Messaging.MessageQueueTransactionType transactionType);
  }
  public partial interface IMessageQueue {
    bool Authenticate { get; set; }
    short BasePriority { get; set; }
    bool CanRead { get; }
    bool CanWrite { get; }
    System.Guid Category { get; set; }
    System.DateTime CreateTime { get; }
    bool DenySharedReceive { get; set; }
    Mono.Messaging.EncryptionRequired EncryptionRequired { get; set; }
    System.Guid Id { get; }
    System.DateTime LastModifyTime { get; }
    long MaximumJournalSize { get; set; }
    long MaximumQueueSize { get; set; }
    Mono.Messaging.QueueReference QRef { get; set; }
    System.IntPtr ReadHandle { get; }
    System.ComponentModel.ISynchronizeInvoke SynchronizingObject { get; set; }
    bool Transactional { get; }
    bool UseJournalQueue { get; set; }
    System.IntPtr WriteHandle { get; }
    event Mono.Messaging.CompletedEventHandler PeekCompleted;
    event Mono.Messaging.CompletedEventHandler ReceiveCompleted;
    System.IAsyncResult BeginPeek();
    System.IAsyncResult BeginPeek(System.TimeSpan timeout);
    System.IAsyncResult BeginPeek(System.TimeSpan timeout, object stateObject);
    System.IAsyncResult BeginPeek(System.TimeSpan timeout, object stateObject, System.AsyncCallback callback);
    System.IAsyncResult BeginReceive();
    System.IAsyncResult BeginReceive(System.TimeSpan timeout);
    System.IAsyncResult BeginReceive(System.TimeSpan timeout, object stateObject);
    System.IAsyncResult BeginReceive(System.TimeSpan timeout, object stateObject, System.AsyncCallback callback);
    void Close();
    Mono.Messaging.IMessage EndPeek(System.IAsyncResult asyncResult);
    Mono.Messaging.IMessage EndReceive(System.IAsyncResult asyncResult);
    Mono.Messaging.IMessageEnumerator GetMessageEnumerator();
    Mono.Messaging.IMessage Peek();
    Mono.Messaging.IMessage Peek(System.TimeSpan timeout);
    Mono.Messaging.IMessage PeekByCorrelationId(string correlationId);
    Mono.Messaging.IMessage PeekByCorrelationId(string correlationId, System.TimeSpan timeout);
    Mono.Messaging.IMessage PeekById(string id);
    Mono.Messaging.IMessage PeekById(string id, System.TimeSpan timeout);
    void Purge();
    Mono.Messaging.IMessage Receive();
    Mono.Messaging.IMessage Receive(Mono.Messaging.IMessageQueueTransaction transaction);
    Mono.Messaging.IMessage Receive(Mono.Messaging.MessageQueueTransactionType transactionType);
    Mono.Messaging.IMessage Receive(System.TimeSpan timeout);
    Mono.Messaging.IMessage Receive(System.TimeSpan timeout, Mono.Messaging.IMessageQueueTransaction transaction);
    Mono.Messaging.IMessage Receive(System.TimeSpan timeout, Mono.Messaging.MessageQueueTransactionType transactionType);
    Mono.Messaging.IMessage ReceiveByCorrelationId(string correlationId);
    Mono.Messaging.IMessage ReceiveByCorrelationId(string correlationId, Mono.Messaging.IMessageQueueTransaction transaction);
    Mono.Messaging.IMessage ReceiveByCorrelationId(string correlationId, Mono.Messaging.MessageQueueTransactionType transactionType);
    Mono.Messaging.IMessage ReceiveByCorrelationId(string correlationId, System.TimeSpan timeout);
    Mono.Messaging.IMessage ReceiveByCorrelationId(string correlationId, System.TimeSpan timeout, Mono.Messaging.IMessageQueueTransaction transaction);
    Mono.Messaging.IMessage ReceiveByCorrelationId(string correlationId, System.TimeSpan timeout, Mono.Messaging.MessageQueueTransactionType transactionType);
    Mono.Messaging.IMessage ReceiveById(string id);
    Mono.Messaging.IMessage ReceiveById(string id, Mono.Messaging.IMessageQueueTransaction transaction);
    Mono.Messaging.IMessage ReceiveById(string id, Mono.Messaging.MessageQueueTransactionType transactionType);
    Mono.Messaging.IMessage ReceiveById(string id, System.TimeSpan timeout);
    Mono.Messaging.IMessage ReceiveById(string id, System.TimeSpan timeout, Mono.Messaging.IMessageQueueTransaction transaction);
    Mono.Messaging.IMessage ReceiveById(string id, System.TimeSpan timeout, Mono.Messaging.MessageQueueTransactionType transactionType);
    void Send(Mono.Messaging.IMessage message);
    void Send(Mono.Messaging.IMessage message, Mono.Messaging.IMessageQueueTransaction transaction);
    void Send(Mono.Messaging.IMessage message, Mono.Messaging.MessageQueueTransactionType transactionType);
    void SendPeekCompleted(System.IAsyncResult result);
    void SendReceiveCompleted(System.IAsyncResult result);
  }
  public partial interface IMessageQueueTransaction : System.IDisposable {
    Mono.Messaging.MessageQueueTransactionStatus Status { get; }
    void Abort();
    void Begin();
    void Commit();
  }
  public partial interface IMessagingProvider {
    Mono.Messaging.IMessage CreateMessage();
    Mono.Messaging.IMessageQueue CreateMessageQueue(Mono.Messaging.QueueReference qRef, bool transactional);
    Mono.Messaging.IMessageQueueTransaction CreateMessageQueueTransaction();
    void DeleteQueue(Mono.Messaging.QueueReference qRef);
    bool Exists(Mono.Messaging.QueueReference qRef);
    Mono.Messaging.IMessageQueue GetMessageQueue(Mono.Messaging.QueueReference qRef);
    Mono.Messaging.IMessageQueue[] GetPublicQueues();
  }
  public partial class MessageBase : Mono.Messaging.IMessage {
    public MessageBase() { }
    public Mono.Messaging.AcknowledgeTypes AcknowledgeType { get { return default(Mono.Messaging.AcknowledgeTypes); } set { } }
    public Mono.Messaging.Acknowledgment Acknowledgment { get { return default(Mono.Messaging.Acknowledgment); } }
    public Mono.Messaging.IMessageQueue AdministrationQueue { get { return default(Mono.Messaging.IMessageQueue); } set { } }
    public int AppSpecific { get { return default(int); } set { } }
    public System.DateTime ArrivedTime { get { return default(System.DateTime); } }
    public bool AttachSenderId { get { return default(bool); } set { } }
    public bool Authenticated { get { return default(bool); } }
    public string AuthenticationProviderName { get { return default(string); } set { } }
    public Mono.Messaging.CryptographicProviderType AuthenticationProviderType { get { return default(Mono.Messaging.CryptographicProviderType); } set { } }
    public System.IO.Stream BodyStream { get { return default(System.IO.Stream); } set { } }
    public int BodyType { get { return default(int); } set { } }
    public System.Guid ConnectorType { get { return default(System.Guid); } set { } }
    public string CorrelationId { get { return default(string); } set { } }
    public Mono.Messaging.IMessageQueue DestinationQueue { get { return default(Mono.Messaging.IMessageQueue); } }
    public System.Byte[] DestinationSymmetricKey { get { return default(System.Byte[]); } set { } }
    public System.Byte[] DigitalSignature { get { return default(System.Byte[]); } set { } }
    public Mono.Messaging.EncryptionAlgorithm EncryptionAlgorithm { get { return default(Mono.Messaging.EncryptionAlgorithm); } set { } }
    public System.Byte[] Extension { get { return default(System.Byte[]); } set { } }
    public Mono.Messaging.HashAlgorithm HashAlgorithm { get { return default(Mono.Messaging.HashAlgorithm); } set { } }
    public string Id { get { return default(string); } }
    public bool IsFirstInTransaction { get { return default(bool); } }
    public bool IsLastInTransaction { get { return default(bool); } }
    public string Label { get { return default(string); } set { } }
    public Mono.Messaging.MessageType MessageType { get { return default(Mono.Messaging.MessageType); } }
    public Mono.Messaging.MessagePriority Priority { get { return default(Mono.Messaging.MessagePriority); } set { } }
    public bool Recoverable { get { return default(bool); } set { } }
    public Mono.Messaging.IMessageQueue ResponseQueue { get { return default(Mono.Messaging.IMessageQueue); } set { } }
    public System.Byte[] SenderCertificate { get { return default(System.Byte[]); } set { } }
    public System.Byte[] SenderId { get { return default(System.Byte[]); } }
    public long SenderVersion { get { return default(long); } }
    public System.DateTime SentTime { get { return default(System.DateTime); } }
    public string SourceMachine { get { return default(string); } }
    public System.TimeSpan TimeToBeReceived { get { return default(System.TimeSpan); } set { } }
    public System.TimeSpan TimeToReachQueue { get { return default(System.TimeSpan); } set { } }
    public string TransactionId { get { return default(string); } }
    public Mono.Messaging.IMessageQueue TransactionStatusQueue { get { return default(Mono.Messaging.IMessageQueue); } set { } }
    public bool UseAuthentication { get { return default(bool); } set { } }
    public bool UseDeadLetterQueue { get { return default(bool); } set { } }
    public bool UseEncryption { get { return default(bool); } set { } }
    public bool UseJournalQueue { get { return default(bool); } set { } }
    public bool UseTracing { get { return default(bool); } set { } }
    public void SetDeliveryInfo(Mono.Messaging.Acknowledgment acknowledgment, System.DateTime arrivedTime, Mono.Messaging.IMessageQueue destinationQueue, string id, Mono.Messaging.MessageType messageType, System.Byte[] senderId, long senderVersion, System.DateTime sentTime, string sourceMachine, string transactionId) { }
  }
  public enum MessagePriority {
    AboveNormal = 4,
    High = 5,
    Highest = 7,
    Low = 2,
    Lowest = 0,
    Normal = 3,
    VeryHigh = 6,
    VeryLow = 1,
  }
  public abstract partial class MessageQueueBase {
    protected MessageQueueBase() { }
    protected abstract Mono.Messaging.IMessageQueue Queue { get; }
    public event Mono.Messaging.CompletedEventHandler PeekCompleted { add { } remove { } }
    public event Mono.Messaging.CompletedEventHandler ReceiveCompleted { add { } remove { } }
    public System.IAsyncResult BeginPeek() { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginPeek(System.TimeSpan timeout) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginPeek(System.TimeSpan timeout, object stateObject) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginPeek(System.TimeSpan timeout, object stateObject, System.AsyncCallback callback) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginReceive() { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginReceive(System.TimeSpan timeout) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginReceive(System.TimeSpan timeout, object stateObject) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginReceive(System.TimeSpan timeout, object stateObject, System.AsyncCallback callback) { return default(System.IAsyncResult); }
    public Mono.Messaging.IMessage EndPeek(System.IAsyncResult asyncResult) { return default(Mono.Messaging.IMessage); }
    public Mono.Messaging.IMessage EndReceive(System.IAsyncResult asyncResult) { return default(Mono.Messaging.IMessage); }
    public void SendPeekCompleted(System.IAsyncResult result) { }
    public void SendReceiveCompleted(System.IAsyncResult result) { }
  }
  public enum MessageQueueTransactionStatus {
    Aborted = 0,
    Committed = 1,
    Initialized = 2,
    Pending = 3,
  }
  public enum MessageQueueTransactionType {
    Automatic = 1,
    None = 0,
    Single = 3,
  }
  public enum MessageType {
    Acknowledgment = 1,
    Normal = 2,
    Report = 3,
  }
  public partial class MessageUnavailableException : Mono.Messaging.MonoMessagingException {
    public MessageUnavailableException() { }
    public MessageUnavailableException(string msg) { }
    public MessageUnavailableException(string msg, System.Exception e) { }
  }
  public partial class MessagingProviderLocator {
    internal MessagingProviderLocator() { }
    public static readonly System.TimeSpan InfiniteTimeout;
    public static Mono.Messaging.MessagingProviderLocator Instance { get { return default(Mono.Messaging.MessagingProviderLocator); } }
    public static Mono.Messaging.IMessagingProvider GetProvider() { return default(Mono.Messaging.IMessagingProvider); }
  }
  public partial class MonoMessagingException : System.Exception {
    public MonoMessagingException() { }
    public MonoMessagingException(string msg) { }
    public MonoMessagingException(string msg, System.Exception e) { }
  }
  public sealed partial class QueueReference {
    public static readonly Mono.Messaging.QueueReference DEFAULT;
    public static readonly string LOCALHOST;
    public QueueReference(string host, string queue, bool isPrivate) { }
    public string Host { get { return default(string); } }
    public bool IsPrivate { get { return default(bool); } }
    public string Queue { get { return default(string); } }
    public bool Equals(Mono.Messaging.QueueReference other) { return default(bool); }
    public override bool Equals(object other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool IsPrivateStr(string s) { return default(bool); }
    public static bool operator ==(Mono.Messaging.QueueReference a, Mono.Messaging.QueueReference b) { return default(bool); }
    public static bool operator !=(Mono.Messaging.QueueReference a, Mono.Messaging.QueueReference b) { return default(bool); }
    public static Mono.Messaging.QueueReference Parse(string path) { return default(Mono.Messaging.QueueReference); }
    public static string RemoveLeadingSlashes(string s) { return default(string); }
    public Mono.Messaging.QueueReference SetHost(string host) { return default(Mono.Messaging.QueueReference); }
    public Mono.Messaging.QueueReference SetQueue(string queue) { return default(Mono.Messaging.QueueReference); }
    public override string ToString() { return default(string); }
  }
}
