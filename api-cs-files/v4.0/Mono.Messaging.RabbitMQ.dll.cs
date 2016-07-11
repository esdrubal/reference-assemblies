namespace Mono.Messaging.RabbitMQ {
  public delegate RabbitMQ.Client.IConnection CreateConnectionDelegate(string host);
  public partial interface IMessagingContext : System.IDisposable {
    void Delete(Mono.Messaging.QueueReference qRef);
    void Purge(Mono.Messaging.QueueReference qRef);
    Mono.Messaging.IMessage Receive(Mono.Messaging.QueueReference qRef, System.TimeSpan timeout, Mono.Messaging.RabbitMQ.IsMatch matcher, bool ack);
    void Send(Mono.Messaging.QueueReference qRef, Mono.Messaging.IMessage msg);
  }
  public delegate bool IsMatch(RabbitMQ.Client.Events.BasicDeliverEventArgs result);
  public partial class MessageFactory {
    public MessageFactory(Mono.Messaging.RabbitMQ.RabbitMQMessagingProvider provider) { }
    public static System.DateTime AmqpTimestampToDateTime(RabbitMQ.Client.AmqpTimestamp ats) { return default(System.DateTime); }
    public static RabbitMQ.Client.AmqpTimestamp DateTimeToAmqpTimestamp(System.DateTime t) { return default(RabbitMQ.Client.AmqpTimestamp); }
    public static string GetString(System.Collections.IDictionary properties, string key) { return default(string); }
    public Mono.Messaging.IMessage ReadMessage(Mono.Messaging.QueueReference destination, RabbitMQ.Client.Events.BasicDeliverEventArgs result) { return default(Mono.Messaging.IMessage); }
    public static int TimeSpanToMillis(System.TimeSpan timespan) { return default(int); }
    public RabbitMQ.Client.Content.IMessageBuilder WriteMessage(RabbitMQ.Client.IModel ch, Mono.Messaging.IMessage msg) { return default(RabbitMQ.Client.Content.IMessageBuilder); }
  }
  public partial class MessagingContext : Mono.Messaging.RabbitMQ.IMessagingContext, System.IDisposable {
    public MessagingContext(Mono.Messaging.RabbitMQ.MessageFactory factory, string host, Mono.Messaging.RabbitMQ.CreateConnectionDelegate createConnection) { }
    public RabbitMQ.Client.IConnection Connection { get { return default(RabbitMQ.Client.IConnection); } }
    public RabbitMQ.Client.IModel Model { get { return default(RabbitMQ.Client.IModel); } }
    public void Delete(Mono.Messaging.QueueReference qRef) { }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public void Purge(Mono.Messaging.QueueReference qRef) { }
    public Mono.Messaging.IMessage Receive(Mono.Messaging.QueueReference qRef, System.TimeSpan timeout, Mono.Messaging.RabbitMQ.IsMatch matcher, bool ack) { return default(Mono.Messaging.IMessage); }
    public void Send(Mono.Messaging.QueueReference qRef, Mono.Messaging.IMessage message) { }
  }
  public partial class MessagingContextPool {
    public MessagingContextPool(Mono.Messaging.RabbitMQ.MessageFactory messageFactory, Mono.Messaging.RabbitMQ.CreateConnectionDelegate createConnectionDelegate) { }
    public Mono.Messaging.RabbitMQ.MessagingContext GetContext(string host) { return default(Mono.Messaging.RabbitMQ.MessagingContext); }
    public void ReturnContext(Mono.Messaging.RabbitMQ.MessagingContext context) { }
  }
  public partial class RabbitMQMessageEnumerator : Mono.Messaging.IMessageEnumerator, System.IDisposable {
    public RabbitMQMessageEnumerator(Mono.Messaging.RabbitMQ.MessageFactory helper, Mono.Messaging.QueueReference qRef) { }
    public Mono.Messaging.IMessage Current { get { return default(Mono.Messaging.IMessage); } }
    public System.IntPtr CursorHandle { get { return default(System.IntPtr); } }
    public void Close() { }
    public void Dispose() { }
    public void Dispose(bool disposing) { }
    public bool MoveNext() { return default(bool); }
    public bool MoveNext(System.TimeSpan timeout) { return default(bool); }
    public Mono.Messaging.IMessage RemoveCurrent() { return default(Mono.Messaging.IMessage); }
    public Mono.Messaging.IMessage RemoveCurrent(Mono.Messaging.IMessageQueueTransaction transaction) { return default(Mono.Messaging.IMessage); }
    public Mono.Messaging.IMessage RemoveCurrent(Mono.Messaging.MessageQueueTransactionType transactionType) { return default(Mono.Messaging.IMessage); }
    public Mono.Messaging.IMessage RemoveCurrent(System.TimeSpan timeout) { return default(Mono.Messaging.IMessage); }
    public Mono.Messaging.IMessage RemoveCurrent(System.TimeSpan timeout, Mono.Messaging.IMessageQueueTransaction transaction) { return default(Mono.Messaging.IMessage); }
    public Mono.Messaging.IMessage RemoveCurrent(System.TimeSpan timeout, Mono.Messaging.MessageQueueTransactionType transactionType) { return default(Mono.Messaging.IMessage); }
    public void Reset() { }
  }
  public partial class RabbitMQMessageQueue : Mono.Messaging.MessageQueueBase, Mono.Messaging.IMessageQueue {
    public RabbitMQMessageQueue(Mono.Messaging.RabbitMQ.RabbitMQMessagingProvider provider, Mono.Messaging.QueueReference qRef, bool transactional) { }
    public RabbitMQMessageQueue(Mono.Messaging.RabbitMQ.RabbitMQMessagingProvider provider, bool transactional) { }
    public bool Authenticate { get { return default(bool); } set { } }
    public short BasePriority { get { return default(short); } set { } }
    public bool CanRead { get { return default(bool); } }
    public bool CanWrite { get { return default(bool); } }
    public System.Guid Category { get { return default(System.Guid); } set { } }
    public System.DateTime CreateTime { get { return default(System.DateTime); } }
    public bool DenySharedReceive { get { return default(bool); } set { } }
    public Mono.Messaging.EncryptionRequired EncryptionRequired { get { return default(Mono.Messaging.EncryptionRequired); } set { } }
    public System.Guid Id { get { return default(System.Guid); } }
    public System.DateTime LastModifyTime { get { return default(System.DateTime); } }
    public long MaximumJournalSize { get { return default(long); } set { } }
    public long MaximumQueueSize { get { return default(long); } set { } }
    public Mono.Messaging.QueueReference QRef { get { return default(Mono.Messaging.QueueReference); } set { } }
    protected override Mono.Messaging.IMessageQueue Queue { get { return default(Mono.Messaging.IMessageQueue); } }
    public System.IntPtr ReadHandle { get { return default(System.IntPtr); } }
    public System.ComponentModel.ISynchronizeInvoke SynchronizingObject { get { return default(System.ComponentModel.ISynchronizeInvoke); } set { } }
    public bool Transactional { get { return default(bool); } }
    public bool UseJournalQueue { get { return default(bool); } set { } }
    public System.IntPtr WriteHandle { get { return default(System.IntPtr); } }
    public void Close() { }
    public static void Delete(Mono.Messaging.QueueReference qRef) { }
    public Mono.Messaging.IMessageEnumerator GetMessageEnumerator() { return default(Mono.Messaging.IMessageEnumerator); }
    void Mono.Messaging.IMessageQueue.add_PeekCompleted(Mono.Messaging.CompletedEventHandler value) { }
    void Mono.Messaging.IMessageQueue.add_ReceiveCompleted(Mono.Messaging.CompletedEventHandler value) { }
    System.IAsyncResult Mono.Messaging.IMessageQueue.BeginPeek() { return default(System.IAsyncResult); }
    System.IAsyncResult Mono.Messaging.IMessageQueue.BeginPeek(System.TimeSpan timeout) { return default(System.IAsyncResult); }
    System.IAsyncResult Mono.Messaging.IMessageQueue.BeginPeek(System.TimeSpan timeout, object stateObject) { return default(System.IAsyncResult); }
    System.IAsyncResult Mono.Messaging.IMessageQueue.BeginPeek(System.TimeSpan timeout, object stateObject, System.AsyncCallback callback) { return default(System.IAsyncResult); }
    System.IAsyncResult Mono.Messaging.IMessageQueue.BeginReceive() { return default(System.IAsyncResult); }
    System.IAsyncResult Mono.Messaging.IMessageQueue.BeginReceive(System.TimeSpan timeout) { return default(System.IAsyncResult); }
    System.IAsyncResult Mono.Messaging.IMessageQueue.BeginReceive(System.TimeSpan timeout, object stateObject) { return default(System.IAsyncResult); }
    System.IAsyncResult Mono.Messaging.IMessageQueue.BeginReceive(System.TimeSpan timeout, object stateObject, System.AsyncCallback callback) { return default(System.IAsyncResult); }
    Mono.Messaging.IMessage Mono.Messaging.IMessageQueue.EndPeek(System.IAsyncResult asyncResult) { return default(Mono.Messaging.IMessage); }
    Mono.Messaging.IMessage Mono.Messaging.IMessageQueue.EndReceive(System.IAsyncResult asyncResult) { return default(Mono.Messaging.IMessage); }
    void Mono.Messaging.IMessageQueue.remove_PeekCompleted(Mono.Messaging.CompletedEventHandler value) { }
    void Mono.Messaging.IMessageQueue.remove_ReceiveCompleted(Mono.Messaging.CompletedEventHandler value) { }
    void Mono.Messaging.IMessageQueue.SendPeekCompleted(System.IAsyncResult result) { }
    void Mono.Messaging.IMessageQueue.SendReceiveCompleted(System.IAsyncResult result) { }
    public Mono.Messaging.IMessage Peek() { return default(Mono.Messaging.IMessage); }
    public Mono.Messaging.IMessage Peek(System.TimeSpan timeout) { return default(Mono.Messaging.IMessage); }
    public Mono.Messaging.IMessage PeekByCorrelationId(string id) { return default(Mono.Messaging.IMessage); }
    public Mono.Messaging.IMessage PeekByCorrelationId(string id, System.TimeSpan timeout) { return default(Mono.Messaging.IMessage); }
    public Mono.Messaging.IMessage PeekById(string id) { return default(Mono.Messaging.IMessage); }
    public Mono.Messaging.IMessage PeekById(string id, System.TimeSpan timeout) { return default(Mono.Messaging.IMessage); }
    public void Purge() { }
    public Mono.Messaging.IMessage Receive() { return default(Mono.Messaging.IMessage); }
    public Mono.Messaging.IMessage Receive(Mono.Messaging.IMessageQueueTransaction transaction) { return default(Mono.Messaging.IMessage); }
    public Mono.Messaging.IMessage Receive(Mono.Messaging.MessageQueueTransactionType transactionType) { return default(Mono.Messaging.IMessage); }
    public Mono.Messaging.IMessage Receive(System.TimeSpan timeout) { return default(Mono.Messaging.IMessage); }
    public Mono.Messaging.IMessage Receive(System.TimeSpan timeout, Mono.Messaging.IMessageQueueTransaction transaction) { return default(Mono.Messaging.IMessage); }
    public Mono.Messaging.IMessage Receive(System.TimeSpan timeout, Mono.Messaging.MessageQueueTransactionType transactionType) { return default(Mono.Messaging.IMessage); }
    public Mono.Messaging.IMessage ReceiveByCorrelationId(string id) { return default(Mono.Messaging.IMessage); }
    public Mono.Messaging.IMessage ReceiveByCorrelationId(string id, Mono.Messaging.IMessageQueueTransaction transaction) { return default(Mono.Messaging.IMessage); }
    public Mono.Messaging.IMessage ReceiveByCorrelationId(string id, Mono.Messaging.MessageQueueTransactionType transactionType) { return default(Mono.Messaging.IMessage); }
    public Mono.Messaging.IMessage ReceiveByCorrelationId(string id, System.TimeSpan timeout) { return default(Mono.Messaging.IMessage); }
    public Mono.Messaging.IMessage ReceiveByCorrelationId(string id, System.TimeSpan timeout, Mono.Messaging.IMessageQueueTransaction transaction) { return default(Mono.Messaging.IMessage); }
    public Mono.Messaging.IMessage ReceiveByCorrelationId(string id, System.TimeSpan timeout, Mono.Messaging.MessageQueueTransactionType transactionType) { return default(Mono.Messaging.IMessage); }
    public Mono.Messaging.IMessage ReceiveById(string id) { return default(Mono.Messaging.IMessage); }
    public Mono.Messaging.IMessage ReceiveById(string id, Mono.Messaging.IMessageQueueTransaction transaction) { return default(Mono.Messaging.IMessage); }
    public Mono.Messaging.IMessage ReceiveById(string id, Mono.Messaging.MessageQueueTransactionType transactionType) { return default(Mono.Messaging.IMessage); }
    public Mono.Messaging.IMessage ReceiveById(string id, System.TimeSpan timeout) { return default(Mono.Messaging.IMessage); }
    public Mono.Messaging.IMessage ReceiveById(string id, System.TimeSpan timeout, Mono.Messaging.IMessageQueueTransaction transaction) { return default(Mono.Messaging.IMessage); }
    public Mono.Messaging.IMessage ReceiveById(string id, System.TimeSpan timeout, Mono.Messaging.MessageQueueTransactionType transactionType) { return default(Mono.Messaging.IMessage); }
    public void Send(Mono.Messaging.IMessage msg) { }
    public void Send(Mono.Messaging.IMessage msg, Mono.Messaging.IMessageQueueTransaction transaction) { }
    public void Send(Mono.Messaging.IMessage msg, Mono.Messaging.MessageQueueTransactionType transactionType) { }
  }
  public partial class RabbitMQMessageQueueTransaction : Mono.Messaging.IMessageQueueTransaction, Mono.Messaging.RabbitMQ.IMessagingContext, System.IDisposable {
    public RabbitMQMessageQueueTransaction(string txId, Mono.Messaging.RabbitMQ.MessagingContextPool contextPool) { }
    public string Id { get { return default(string); } }
    public Mono.Messaging.MessageQueueTransactionStatus Status { get { return default(Mono.Messaging.MessageQueueTransactionStatus); } }
    public void Abort() { }
    public void Begin() { }
    public void Commit() { }
    public void Delete(Mono.Messaging.QueueReference qRef) { }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public void Purge(Mono.Messaging.QueueReference qRef) { }
    public Mono.Messaging.IMessage Receive(Mono.Messaging.QueueReference qRef, System.TimeSpan timeout, Mono.Messaging.RabbitMQ.IsMatch matcher, bool ack) { return default(Mono.Messaging.IMessage); }
    public void Send(Mono.Messaging.QueueReference qRef, Mono.Messaging.IMessage msg) { }
  }
  public partial class RabbitMQMessagingProvider : Mono.Messaging.IMessagingProvider {
    public RabbitMQMessagingProvider() { }
    public Mono.Messaging.RabbitMQ.IMessagingContext CreateContext(string host) { return default(Mono.Messaging.RabbitMQ.IMessagingContext); }
    public Mono.Messaging.IMessage CreateMessage() { return default(Mono.Messaging.IMessage); }
    public Mono.Messaging.IMessageQueue CreateMessageQueue(Mono.Messaging.QueueReference qRef, bool transactional) { return default(Mono.Messaging.IMessageQueue); }
    public Mono.Messaging.IMessageQueueTransaction CreateMessageQueueTransaction() { return default(Mono.Messaging.IMessageQueueTransaction); }
    public void DeleteQueue(Mono.Messaging.QueueReference qRef) { }
    public bool Exists(Mono.Messaging.QueueReference qRef) { return default(bool); }
    public Mono.Messaging.IMessageQueue GetMessageQueue(Mono.Messaging.QueueReference qRef) { return default(Mono.Messaging.IMessageQueue); }
    public Mono.Messaging.IMessageQueue[] GetPublicQueues() { return default(Mono.Messaging.IMessageQueue[]); }
  }
}
