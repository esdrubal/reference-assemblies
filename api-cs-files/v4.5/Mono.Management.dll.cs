namespace Mono.Attach {
  public partial class VirtualMachine {
    public VirtualMachine(long pid) { }
    public bool IsCurrent { get { return default(bool); } }
    public long Pid { get { return default(long); } }
    public void Attach(string agent, string args) { }
    public System.String[] GetCommandLine() { return default(System.String[]); }
    public static System.Collections.Generic.List<Mono.Attach.VirtualMachine> GetVirtualMachines() { return default(System.Collections.Generic.List<Mono.Attach.VirtualMachine>); }
    public string GetWorkingDirectory() { return default(string); }
    public override string ToString() { return default(string); }
  }
}
