namespace System.Windows.Input.Manipulations {
  public sealed partial class InertiaExpansionBehavior2D : System.Windows.Input.Manipulations.InertiaParameters2D {
    public InertiaExpansionBehavior2D() { }
    public float DesiredDeceleration { get { return default(float); } set { } }
    public float DesiredExpansionX { get { return default(float); } set { } }
    public float DesiredExpansionY { get { return default(float); } set { } }
    public float InitialRadius { get { return default(float); } set { } }
    public float InitialVelocityX { get { return default(float); } set { } }
    public float InitialVelocityY { get { return default(float); } set { } }
  }
  public abstract partial class InertiaParameters2D {
    internal InertiaParameters2D() { }
  }
  public partial class InertiaProcessor2D {
    public InertiaProcessor2D() { }
    public System.Windows.Input.Manipulations.InertiaExpansionBehavior2D ExpansionBehavior { get { return default(System.Windows.Input.Manipulations.InertiaExpansionBehavior2D); } set { } }
    public float InitialOriginX { get { return default(float); } set { } }
    public float InitialOriginY { get { return default(float); } set { } }
    public bool IsRunning { get { return default(bool); } }
    public System.Windows.Input.Manipulations.InertiaRotationBehavior2D RotationBehavior { get { return default(System.Windows.Input.Manipulations.InertiaRotationBehavior2D); } set { } }
    public System.Windows.Input.Manipulations.InertiaTranslationBehavior2D TranslationBehavior { get { return default(System.Windows.Input.Manipulations.InertiaTranslationBehavior2D); } set { } }
    public event System.EventHandler<System.Windows.Input.Manipulations.Manipulation2DCompletedEventArgs> Completed { add { } remove { } }
    public event System.EventHandler<System.Windows.Input.Manipulations.Manipulation2DDeltaEventArgs> Delta { add { } remove { } }
    public void Complete(long timestamp) { }
    public bool Process(long timestamp) { return default(bool); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void SetParameters(System.Windows.Input.Manipulations.InertiaParameters2D parameters) { }
  }
  public sealed partial class InertiaRotationBehavior2D : System.Windows.Input.Manipulations.InertiaParameters2D {
    public InertiaRotationBehavior2D() { }
    public float DesiredDeceleration { get { return default(float); } set { } }
    public float DesiredRotation { get { return default(float); } set { } }
    public float InitialVelocity { get { return default(float); } set { } }
  }
  public sealed partial class InertiaTranslationBehavior2D : System.Windows.Input.Manipulations.InertiaParameters2D {
    public InertiaTranslationBehavior2D() { }
    public float DesiredDeceleration { get { return default(float); } set { } }
    public float DesiredDisplacement { get { return default(float); } set { } }
    public float InitialVelocityX { get { return default(float); } set { } }
    public float InitialVelocityY { get { return default(float); } set { } }
  }
  public partial class Manipulation2DCompletedEventArgs : System.EventArgs {
    internal Manipulation2DCompletedEventArgs() { }
    public float OriginX { get { return default(float); } }
    public float OriginY { get { return default(float); } }
    public System.Windows.Input.Manipulations.ManipulationDelta2D Total { get { return default(System.Windows.Input.Manipulations.ManipulationDelta2D); } }
    public System.Windows.Input.Manipulations.ManipulationVelocities2D Velocities { get { return default(System.Windows.Input.Manipulations.ManipulationVelocities2D); } }
  }
  public partial class Manipulation2DDeltaEventArgs : System.EventArgs {
    internal Manipulation2DDeltaEventArgs() { }
    public System.Windows.Input.Manipulations.ManipulationDelta2D Cumulative { get { return default(System.Windows.Input.Manipulations.ManipulationDelta2D); } }
    public System.Windows.Input.Manipulations.ManipulationDelta2D Delta { get { return default(System.Windows.Input.Manipulations.ManipulationDelta2D); } }
    public float OriginX { get { return default(float); } }
    public float OriginY { get { return default(float); } }
    public System.Windows.Input.Manipulations.ManipulationVelocities2D Velocities { get { return default(System.Windows.Input.Manipulations.ManipulationVelocities2D); } }
  }
  public partial class Manipulation2DStartedEventArgs : System.EventArgs {
    internal Manipulation2DStartedEventArgs() { }
    public float OriginX { get { return default(float); } }
    public float OriginY { get { return default(float); } }
  }
  public partial class ManipulationDelta2D {
    internal ManipulationDelta2D() { }
    public float ExpansionX { get { return default(float); } }
    public float ExpansionY { get { return default(float); } }
    public float Rotation { get { return default(float); } }
    public float ScaleX { get { return default(float); } }
    public float ScaleY { get { return default(float); } }
    public float TranslationX { get { return default(float); } }
    public float TranslationY { get { return default(float); } }
  }
  public abstract partial class ManipulationParameters2D {
    internal ManipulationParameters2D() { }
  }
  public sealed partial class ManipulationPivot2D : System.Windows.Input.Manipulations.ManipulationParameters2D {
    public ManipulationPivot2D() { }
    public float Radius { get { return default(float); } set { } }
    public float X { get { return default(float); } set { } }
    public float Y { get { return default(float); } set { } }
  }
  public partial class ManipulationProcessor2D {
    public ManipulationProcessor2D(System.Windows.Input.Manipulations.Manipulations2D supportedManipulations) { }
    public ManipulationProcessor2D(System.Windows.Input.Manipulations.Manipulations2D supportedManipulations, System.Windows.Input.Manipulations.ManipulationPivot2D pivot) { }
    public float MinimumScaleRotateRadius { get { return default(float); } set { } }
    public System.Windows.Input.Manipulations.ManipulationPivot2D Pivot { get { return default(System.Windows.Input.Manipulations.ManipulationPivot2D); } set { } }
    public System.Windows.Input.Manipulations.Manipulations2D SupportedManipulations { get { return default(System.Windows.Input.Manipulations.Manipulations2D); } set { } }
    public event System.EventHandler<System.Windows.Input.Manipulations.Manipulation2DCompletedEventArgs> Completed { add { } remove { } }
    public event System.EventHandler<System.Windows.Input.Manipulations.Manipulation2DDeltaEventArgs> Delta { add { } remove { } }
    public event System.EventHandler<System.Windows.Input.Manipulations.Manipulation2DStartedEventArgs> Started { add { } remove { } }
    public void CompleteManipulation(long timestamp) { }
    public void ProcessManipulators(long timestamp, System.Collections.Generic.IEnumerable<System.Windows.Input.Manipulations.Manipulator2D> manipulators) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public void SetParameters(System.Windows.Input.Manipulations.ManipulationParameters2D parameters) { }
  }
  [System.FlagsAttribute]
  public enum Manipulations2D {
    All = 15,
    None = 0,
    Rotate = 8,
    Scale = 4,
    Translate = 3,
    TranslateX = 1,
    TranslateY = 2,
  }
  public partial class ManipulationVelocities2D {
    internal ManipulationVelocities2D() { }
    public static readonly System.Windows.Input.Manipulations.ManipulationVelocities2D Zero;
    public float AngularVelocity { get { return default(float); } }
    public float ExpansionVelocityX { get { return default(float); } }
    public float ExpansionVelocityY { get { return default(float); } }
    public float LinearVelocityX { get { return default(float); } }
    public float LinearVelocityY { get { return default(float); } }
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Manipulator2D {
    public Manipulator2D(int id, float x, float y) { throw new System.NotImplementedException(); }
    public int Id { get { return default(int); } set { } }
    public float X { get { return default(float); } set { } }
    public float Y { get { return default(float); } set { } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Windows.Input.Manipulations.Manipulator2D manipulator1, System.Windows.Input.Manipulations.Manipulator2D manipulator2) { return default(bool); }
    public static bool operator !=(System.Windows.Input.Manipulations.Manipulator2D manipulator1, System.Windows.Input.Manipulations.Manipulator2D manipulator2) { return default(bool); }
  }
}
