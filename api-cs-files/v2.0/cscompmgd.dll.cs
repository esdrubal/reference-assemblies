namespace Microsoft.CSharp {
  [System.ObsoleteAttribute]
  public partial class Compiler {
    internal Compiler() { }
    [System.MonoTODOAttribute("Have not implemented bugreports")]
    public static Microsoft.CSharp.CompilerError[] Compile(System.String[] sourceTexts, System.String[] sourceTextNames, string target, System.String[] imports, System.Collections.IDictionary options) { return default(Microsoft.CSharp.CompilerError[]); }
  }
  [System.ObsoleteAttribute]
  public partial class CompilerError {
    public Microsoft.CSharp.ErrorLevel ErrorLevel;
    public string ErrorMessage;
    public int ErrorNumber;
    public int SourceColumn;
    public string SourceFile;
    public int SourceLine;
    public CompilerError() { }
    public override string ToString() { return default(string); }
  }
  [System.ObsoleteAttribute]
  public enum ErrorLevel {
    Error = 2,
    FatalError = 3,
    None = 0,
    Warning = 1,
  }
}
