namespace System.Runtime.Serialization.Formatters.Soap {
  public sealed partial class SoapFormatter : System.Runtime.Remoting.Messaging.IRemotingFormatter, System.Runtime.Serialization.IFormatter {
    public SoapFormatter() { }
    public SoapFormatter(System.Runtime.Serialization.ISurrogateSelector selector, System.Runtime.Serialization.StreamingContext context) { }
    public System.Runtime.Serialization.Formatters.FormatterAssemblyStyle AssemblyFormat { get { return default(System.Runtime.Serialization.Formatters.FormatterAssemblyStyle); } set { } }
    public System.Runtime.Serialization.SerializationBinder Binder { get { return default(System.Runtime.Serialization.SerializationBinder); } set { } }
    public System.Runtime.Serialization.StreamingContext Context { get { return default(System.Runtime.Serialization.StreamingContext); } set { } }
    [System.MonoTODOAttribute("Interpret this")]
    public System.Runtime.Serialization.Formatters.TypeFilterLevel FilterLevel { get { return default(System.Runtime.Serialization.Formatters.TypeFilterLevel); } set { } }
    public System.Runtime.Serialization.ISurrogateSelector SurrogateSelector { get { return default(System.Runtime.Serialization.ISurrogateSelector); } set { } }
    public System.Runtime.Serialization.Formatters.ISoapMessage TopObject { get { return default(System.Runtime.Serialization.Formatters.ISoapMessage); } set { } }
    public System.Runtime.Serialization.Formatters.FormatterTypeStyle TypeFormat { get { return default(System.Runtime.Serialization.Formatters.FormatterTypeStyle); } set { } }
    public object Deserialize(System.IO.Stream serializationStream) { return default(object); }
    public object Deserialize(System.IO.Stream serializationStream, System.Runtime.Remoting.Messaging.HeaderHandler handler) { return default(object); }
    public void Serialize(System.IO.Stream serializationStream, object graph) { }
    public void Serialize(System.IO.Stream serializationStream, object graph, System.Runtime.Remoting.Messaging.Header[] headers) { }
  }
}
