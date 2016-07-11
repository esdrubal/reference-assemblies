namespace Mono.Tasklets {
  public partial class Continuation : System.IDisposable {
    public Continuation() { }
    public void Dispose() { }
    ~Continuation() { }
    public void Mark() { }
    public void Restore(int state) { }
    public int Store(int state) { return default(int); }
  }
}
