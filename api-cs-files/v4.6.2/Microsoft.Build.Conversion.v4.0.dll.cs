namespace Microsoft.Build.Conversion {
  public sealed partial class ProjectFileConverter {
    public ProjectFileConverter() { }
    public bool ConversionSkippedBecauseProjectAlreadyConverted { get { return default(bool); } }
    public System.String[] ConversionWarnings { get { return default(System.String[]); } }
    public bool IsUserFile { get { return default(bool); } set { } }
    public string NewProjectFile { get { return default(string); } set { } }
    public string OldProjectFile { get { return default(string); } set { } }
    public string SolutionFile { get { return default(string); } set { } }
    public void Convert() { }
    [System.ObsoleteAttribute("Use parameterless overload instead")]
    public void Convert(Microsoft.Build.BuildEngine.ProjectLoadSettings projectLoadSettings) { }
    [System.ObsoleteAttribute("Use parameterless overload instead.")]
    public void Convert(string msbuildBinPath) { }
    public Microsoft.Build.Construction.ProjectRootElement ConvertInMemory() { return default(Microsoft.Build.Construction.ProjectRootElement); }
    [System.ObsoleteAttribute("Use parameterless ConvertInMemory() method instead")]
    public Microsoft.Build.BuildEngine.Project ConvertInMemory(Microsoft.Build.BuildEngine.Engine engine) { return default(Microsoft.Build.BuildEngine.Project); }
    [System.ObsoleteAttribute("Use parameterless ConvertInMemory() method instead")]
    public Microsoft.Build.BuildEngine.Project ConvertInMemory(Microsoft.Build.BuildEngine.Engine engine, Microsoft.Build.BuildEngine.ProjectLoadSettings projectLoadSettings) { return default(Microsoft.Build.BuildEngine.Project); }
    public bool FSharpSpecificConversions(bool actuallyMakeChanges) { return default(bool); }
  }
}
